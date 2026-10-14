using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using JetBrains.Annotations;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Internal.Fakeables;
using NLog.Targets;

namespace NLog
{
	// Token: 0x0200000D RID: 13
	public class LogFactory : global::System.IDisposable
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001CA RID: 458 RVA: 0x00002E1C File Offset: 0x0000101C
		// (remove) Token: 0x060001CB RID: 459 RVA: 0x00002E54 File Offset: 0x00001054
		public event global::System.EventHandler<global::NLog.Config.LoggingConfigurationChangedEventArgs> ConfigurationChanged;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001CC RID: 460 RVA: 0x00002E8C File Offset: 0x0000108C
		// (remove) Token: 0x060001CD RID: 461 RVA: 0x00002EC4 File Offset: 0x000010C4
		public event global::System.EventHandler<global::NLog.Config.LoggingConfigurationReloadedEventArgs> ConfigurationReloaded;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060001CE RID: 462 RVA: 0x00002EFC File Offset: 0x000010FC
		// (remove) Token: 0x060001CF RID: 463 RVA: 0x00002F30 File Offset: 0x00001130
		private static event global::System.EventHandler<global::System.EventArgs> LoggerShutdown;

		// Token: 0x060001D0 RID: 464 RVA: 0x00002F63 File Offset: 0x00001163
		static LogFactory()
		{
			global::NLog.LogFactory.RegisterEvents(global::NLog.LogFactory.CurrentAppDomain);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002F84 File Offset: 0x00001184
		public LogFactory()
		{
			this._watcher = new global::NLog.Internal.MultiFileWatcher();
			this._watcher.FileChanged += new global::System.IO.FileSystemEventHandler(this.ConfigFileChanged);
			global::NLog.LogFactory.LoggerShutdown += this.OnStopLogging;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002FEB File Offset: 0x000011EB
		public LogFactory(global::NLog.Config.LoggingConfiguration config) : this()
		{
			this.Configuration = config;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002FFA File Offset: 0x000011FA
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00003015 File Offset: 0x00001215
		public static global::NLog.Internal.Fakeables.IAppDomain CurrentAppDomain
		{
			get
			{
				global::NLog.Internal.Fakeables.IAppDomain result;
				if ((result = global::NLog.LogFactory.currentAppDomain) == null)
				{
					result = (global::NLog.LogFactory.currentAppDomain = new global::NLog.Internal.Fakeables.AppDomainWrapper(global::System.AppDomain.CurrentDomain));
				}
				return result;
			}
			set
			{
				global::NLog.LogFactory.UnregisterEvents(global::NLog.LogFactory.currentAppDomain);
				global::NLog.LogFactory.UnregisterEvents(value);
				global::NLog.LogFactory.RegisterEvents(value);
				global::NLog.LogFactory.currentAppDomain = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00003033 File Offset: 0x00001233
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0000303B File Offset: 0x0000123B
		public bool ThrowExceptions { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00003044 File Offset: 0x00001244
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000304C File Offset: 0x0000124C
		public bool? ThrowConfigExceptions { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00003055 File Offset: 0x00001255
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0000305D File Offset: 0x0000125D
		public bool KeepVariablesOnReload { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00003068 File Offset: 0x00001268
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00003128 File Offset: 0x00001328
		public global::NLog.Config.LoggingConfiguration Configuration
		{
			get
			{
				if (this._configLoaded)
				{
					return this._config;
				}
				object syncRoot = this._syncRoot;
				global::NLog.Config.LoggingConfiguration config;
				lock (syncRoot)
				{
					if (this._configLoaded || this._isDisposing)
					{
						config = this._config;
					}
					else
					{
						if (this._config == null)
						{
							this.TryLoadFromAppConfig();
						}
						if (this._config == null)
						{
							this.TryLoadFromFilePaths();
						}
						if (this._config != null)
						{
							try
							{
								this._config.Dump();
								this.ReconfigExistingLoggers();
								this.TryWachtingConfigFile();
								global::NLog.LogFactory.LogConfigurationInitialized();
							}
							finally
							{
								this._configLoaded = true;
							}
						}
						config = this._config;
					}
				}
				return config;
			}
			set
			{
				try
				{
					this._watcher.StopWatching();
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Error(ex, "Cannot stop file watching.");
					if (ex.MustBeRethrown())
					{
						throw;
					}
				}
				object syncRoot = this._syncRoot;
				lock (syncRoot)
				{
					global::NLog.Config.LoggingConfiguration config = this._config;
					if (config != null)
					{
						global::NLog.Common.InternalLogger.Info("Closing old configuration.");
						this.Flush();
						config.Close();
					}
					this._config = value;
					if (this._config == null)
					{
						this._configLoaded = false;
					}
					else
					{
						try
						{
							this._config.Dump();
							this.ReconfigExistingLoggers();
							this.TryWachtingConfigFile();
						}
						finally
						{
							this._configLoaded = true;
						}
					}
					this.OnConfigurationChanged(new global::NLog.Config.LoggingConfigurationChangedEventArgs(value, config));
				}
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00003204 File Offset: 0x00001404
		private void TryWachtingConfigFile()
		{
			try
			{
				this._watcher.Watch(this._config.FileNamesToWatch);
			}
			catch (global::System.Exception ex)
			{
				if (ex.MustBeRethrown())
				{
					throw;
				}
				global::NLog.Common.InternalLogger.Warn(ex, "Cannot start file watching: {0}", new object[]
				{
					string.Join(",", this._config.FileNamesToWatch.ToArray<string>())
				});
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00003274 File Offset: 0x00001474
		private void TryLoadFromFilePaths()
		{
			foreach (string text in this.GetCandidateConfigFilePaths())
			{
				if (global::System.IO.File.Exists(text))
				{
					this._config = this.TryLoadLoggingConfiguration(text);
					break;
				}
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000032D4 File Offset: 0x000014D4
		private void TryLoadFromAppConfig()
		{
			try
			{
				this._config = global::NLog.Config.XmlLoggingConfiguration.AppConfig;
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrown())
				{
					throw;
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000330C File Offset: 0x0000150C
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00003314 File Offset: 0x00001514
		public global::NLog.LogLevel GlobalThreshold
		{
			get
			{
				return this._globalThreshold;
			}
			set
			{
				object syncRoot = this._syncRoot;
				lock (syncRoot)
				{
					this._globalThreshold = value;
					this.ReconfigExistingLoggers();
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000335C File Offset: 0x0000155C
		[global::JetBrains.Annotations.CanBeNull]
		public global::System.Globalization.CultureInfo DefaultCultureInfo
		{
			get
			{
				global::NLog.Config.LoggingConfiguration configuration = this.Configuration;
				if (configuration == null)
				{
					return null;
				}
				return configuration.DefaultCultureInfo;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00003370 File Offset: 0x00001570
		internal static void LogConfigurationInitialized()
		{
			global::NLog.Common.InternalLogger.Info("Configuration initialized.");
			try
			{
				global::NLog.Common.InternalLogger.LogAssemblyVersion(typeof(global::NLog.ILogger).GetAssembly());
			}
			catch (global::System.Security.SecurityException ex)
			{
				global::NLog.Common.InternalLogger.Debug(ex, "Not running in full trust");
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000033BC File Offset: 0x000015BC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000033CB File Offset: 0x000015CB
		public global::NLog.Logger CreateNullLogger()
		{
			return new global::NLog.NullLogger(this);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000033D4 File Offset: 0x000015D4
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public global::NLog.Logger GetCurrentClassLogger()
		{
			string classFullName = global::NLog.Internal.StackTraceUsageUtils.GetClassFullName(new global::System.Diagnostics.StackFrame(1, false));
			return this.GetLogger(classFullName);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000033F8 File Offset: 0x000015F8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public T GetCurrentClassLogger<T>() where T : global::NLog.Logger
		{
			string classFullName = global::NLog.Internal.StackTraceUsageUtils.GetClassFullName(new global::System.Diagnostics.StackFrame(1, false));
			return (T)((object)this.GetLogger(classFullName, typeof(T)));
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00003428 File Offset: 0x00001628
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public global::NLog.Logger GetCurrentClassLogger(global::System.Type loggerType)
		{
			string classFullName = global::NLog.Internal.StackTraceUsageUtils.GetClassFullName(new global::System.Diagnostics.StackFrame(1, false));
			return this.GetLogger(classFullName, loggerType);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000344A File Offset: 0x0000164A
		public global::NLog.Logger GetLogger(string name)
		{
			return this.GetLogger(new global::NLog.LogFactory.LoggerCacheKey(name, typeof(global::NLog.Logger)));
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00003462 File Offset: 0x00001662
		public T GetLogger<T>(string name) where T : global::NLog.Logger
		{
			return (T)((object)this.GetLogger(new global::NLog.LogFactory.LoggerCacheKey(name, typeof(T))));
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000347F File Offset: 0x0000167F
		public global::NLog.Logger GetLogger(string name, global::System.Type loggerType)
		{
			return this.GetLogger(new global::NLog.LogFactory.LoggerCacheKey(name, loggerType));
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00003490 File Offset: 0x00001690
		public void ReconfigExistingLoggers()
		{
			object syncRoot = this._syncRoot;
			global::System.Collections.Generic.List<global::NLog.Logger> loggers;
			lock (syncRoot)
			{
				global::NLog.Config.LoggingConfiguration config = this._config;
				if (config != null)
				{
					config.InitializeAll();
				}
				loggers = this._loggerCache.GetLoggers();
			}
			foreach (global::NLog.Logger logger in loggers)
			{
				logger.SetConfiguration(this.GetConfigurationForLogger(logger.Name, this._config));
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00003538 File Offset: 0x00001738
		public void Flush()
		{
			this.Flush(global::NLog.LogFactory.DefaultFlushTimeout);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00003548 File Offset: 0x00001748
		public void Flush(global::System.TimeSpan timeout)
		{
			try
			{
				global::NLog.Common.AsyncHelpers.RunSynchronously(delegate(global::NLog.Common.AsyncContinuation cb)
				{
					this.Flush(cb, timeout);
				});
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "Error with flush.");
				if (ex.MustBeRethrown())
				{
					throw;
				}
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000035A4 File Offset: 0x000017A4
		public void Flush(int timeoutMilliseconds)
		{
			this.Flush(global::System.TimeSpan.FromMilliseconds((double)timeoutMilliseconds));
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000035B3 File Offset: 0x000017B3
		public void Flush(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			this.Flush(asyncContinuation, global::System.TimeSpan.MaxValue);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000035C1 File Offset: 0x000017C1
		public void Flush(global::NLog.Common.AsyncContinuation asyncContinuation, int timeoutMilliseconds)
		{
			this.Flush(asyncContinuation, global::System.TimeSpan.FromMilliseconds((double)timeoutMilliseconds));
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000035D4 File Offset: 0x000017D4
		public void Flush(global::NLog.Common.AsyncContinuation asyncContinuation, global::System.TimeSpan timeout)
		{
			try
			{
				global::NLog.Common.InternalLogger.Trace<global::System.TimeSpan>("LogFactory.Flush({0})", timeout);
				global::NLog.Config.LoggingConfiguration loggingConfiguration = null;
				object syncRoot = this._syncRoot;
				lock (syncRoot)
				{
					loggingConfiguration = this._config;
				}
				if (loggingConfiguration != null)
				{
					loggingConfiguration.FlushAllTargets(global::NLog.Common.AsyncHelpers.WithTimeout(asyncContinuation, timeout));
				}
				else
				{
					asyncContinuation(null);
				}
			}
			catch (global::System.Exception ex)
			{
				if (this.ThrowExceptions)
				{
					throw;
				}
				global::NLog.Common.InternalLogger.Error(ex, "Error with flush.");
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00003660 File Offset: 0x00001860
		[global::System.Obsolete("Use SuspendLogging() instead. Marked obsolete on NLog 4.0")]
		public global::System.IDisposable DisableLogging()
		{
			return this.SuspendLogging();
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00003668 File Offset: 0x00001868
		[global::System.Obsolete("Use ResumeLogging() instead. Marked obsolete on NLog 4.0")]
		public void EnableLogging()
		{
			this.ResumeLogging();
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00003670 File Offset: 0x00001870
		public global::System.IDisposable SuspendLogging()
		{
			object syncRoot = this._syncRoot;
			lock (syncRoot)
			{
				this._logsEnabled--;
				if (this._logsEnabled == -1)
				{
					this.ReconfigExistingLoggers();
				}
			}
			return new global::NLog.LogFactory.LogEnabler(this);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000036D0 File Offset: 0x000018D0
		public void ResumeLogging()
		{
			object syncRoot = this._syncRoot;
			lock (syncRoot)
			{
				this._logsEnabled++;
				if (this._logsEnabled == 0)
				{
					this.ReconfigExistingLoggers();
				}
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00003728 File Offset: 0x00001928
		public bool IsLoggingEnabled()
		{
			return this._logsEnabled >= 0;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00003736 File Offset: 0x00001936
		protected virtual void OnConfigurationChanged(global::NLog.Config.LoggingConfigurationChangedEventArgs e)
		{
			global::System.EventHandler<global::NLog.Config.LoggingConfigurationChangedEventArgs> configurationChanged = this.ConfigurationChanged;
			if (configurationChanged == null)
			{
				return;
			}
			configurationChanged(this, e);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000374A File Offset: 0x0000194A
		protected virtual void OnConfigurationReloaded(global::NLog.Config.LoggingConfigurationReloadedEventArgs e)
		{
			global::System.EventHandler<global::NLog.Config.LoggingConfigurationReloadedEventArgs> configurationReloaded = this.ConfigurationReloaded;
			if (configurationReloaded == null)
			{
				return;
			}
			configurationReloaded(this, e);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00003760 File Offset: 0x00001960
		internal void ReloadConfigOnTimer(object state)
		{
			if (this._reloadTimer == null && this._isDisposing)
			{
				return;
			}
			global::NLog.Config.LoggingConfiguration loggingConfiguration = (global::NLog.Config.LoggingConfiguration)state;
			global::NLog.Common.InternalLogger.Info("Reloading configuration...");
			object syncRoot = this._syncRoot;
			lock (syncRoot)
			{
				try
				{
					if (!this._isDisposing)
					{
						global::System.Threading.Timer reloadTimer = this._reloadTimer;
						if (reloadTimer != null)
						{
							this._reloadTimer = null;
							reloadTimer.WaitForDispose(global::System.TimeSpan.Zero);
						}
						this._watcher.StopWatching();
						if (this._config != loggingConfiguration)
						{
							throw new global::NLog.NLogConfigurationException("Config changed in between. Not reloading.");
						}
						global::NLog.Config.LoggingConfiguration loggingConfiguration2 = loggingConfiguration.Reload();
						global::NLog.Config.XmlLoggingConfiguration xmlLoggingConfiguration;
						if ((xmlLoggingConfiguration = (loggingConfiguration2 as global::NLog.Config.XmlLoggingConfiguration)) != null && xmlLoggingConfiguration.InitializeSucceeded != true)
						{
							throw new global::NLog.NLogConfigurationException("Configuration.Reload() failed. Invalid XML?");
						}
						if (loggingConfiguration2 == null)
						{
							throw new global::NLog.NLogConfigurationException("Configuration.Reload() returned null. Not reloading.");
						}
						if (this.KeepVariablesOnReload && this._config != null)
						{
							loggingConfiguration2.CopyVariables(this._config.Variables);
						}
						this.Configuration = loggingConfiguration2;
						this.OnConfigurationReloaded(new global::NLog.Config.LoggingConfigurationReloadedEventArgs(true));
					}
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Warn(ex, "NLog configuration while reloading");
					if (ex.MustBeRethrownImmediately())
					{
						throw;
					}
					this._watcher.Watch(loggingConfiguration.FileNamesToWatch);
					this.OnConfigurationReloaded(new global::NLog.Config.LoggingConfigurationReloadedEventArgs(false, ex));
				}
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000038F0 File Offset: 0x00001AF0
		private void GetTargetsByLevelForLogger(string name, global::System.Collections.Generic.IEnumerable<global::NLog.Config.LoggingRule> loggingRules, global::NLog.Internal.TargetWithFilterChain[] targetsByLevel, global::NLog.Internal.TargetWithFilterChain[] lastTargetsByLevel, bool[] suppressedLevels)
		{
			foreach (global::NLog.Config.LoggingRule loggingRule in loggingRules)
			{
				if (loggingRule.NameMatches(name))
				{
					for (int i = 0; i <= global::NLog.LogLevel.MaxLevel.Ordinal; i++)
					{
						if (i >= this.GlobalThreshold.Ordinal && !suppressedLevels[i] && loggingRule.IsLoggingEnabledForLevel(global::NLog.LogLevel.FromOrdinal(i)))
						{
							if (loggingRule.Final)
							{
								suppressedLevels[i] = true;
							}
							foreach (global::NLog.Targets.Target target in loggingRule.GetTargetsThreadSafe())
							{
								global::NLog.Internal.TargetWithFilterChain targetWithFilterChain = new global::NLog.Internal.TargetWithFilterChain(target, loggingRule.Filters);
								if (lastTargetsByLevel[i] != null)
								{
									lastTargetsByLevel[i].NextInChain = targetWithFilterChain;
								}
								else
								{
									targetsByLevel[i] = targetWithFilterChain;
								}
								lastTargetsByLevel[i] = targetWithFilterChain;
							}
						}
					}
					if (loggingRule.ChildRules.Count != 0)
					{
						this.GetTargetsByLevelForLogger(name, loggingRule.GetChildRulesThreadSafe(), targetsByLevel, lastTargetsByLevel, suppressedLevels);
					}
				}
			}
			for (int j = 0; j <= global::NLog.LogLevel.MaxLevel.Ordinal; j++)
			{
				global::NLog.Internal.TargetWithFilterChain targetWithFilterChain2 = targetsByLevel[j];
				if (targetWithFilterChain2 != null)
				{
					targetWithFilterChain2.PrecalculateStackTraceUsage();
				}
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00003A3C File Offset: 0x00001C3C
		internal global::NLog.Internal.LoggerConfiguration GetConfigurationForLogger(string name, global::NLog.Config.LoggingConfiguration configuration)
		{
			global::NLog.Internal.TargetWithFilterChain[] array = new global::NLog.Internal.TargetWithFilterChain[global::NLog.LogLevel.MaxLevel.Ordinal + 1];
			global::NLog.Internal.TargetWithFilterChain[] lastTargetsByLevel = new global::NLog.Internal.TargetWithFilterChain[global::NLog.LogLevel.MaxLevel.Ordinal + 1];
			bool[] suppressedLevels = new bool[global::NLog.LogLevel.MaxLevel.Ordinal + 1];
			if (configuration != null && this.IsLoggingEnabled())
			{
				global::System.Collections.Generic.List<global::NLog.Config.LoggingRule> loggingRulesThreadSafe = configuration.GetLoggingRulesThreadSafe();
				this.GetTargetsByLevelForLogger(name, loggingRulesThreadSafe, array, lastTargetsByLevel, suppressedLevels);
			}
			if (global::NLog.Common.InternalLogger.IsDebugEnabled)
			{
				global::NLog.Common.InternalLogger.Debug<string>("Targets for {0} by level:", name);
				for (int i = 0; i <= global::NLog.LogLevel.MaxLevel.Ordinal; i++)
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0} =>", new object[]
					{
						global::NLog.LogLevel.FromOrdinal(i)
					});
					for (global::NLog.Internal.TargetWithFilterChain targetWithFilterChain = array[i]; targetWithFilterChain != null; targetWithFilterChain = targetWithFilterChain.NextInChain)
					{
						stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, " {0}", new object[]
						{
							targetWithFilterChain.Target.Name
						});
						if (targetWithFilterChain.FilterChain.Count > 0)
						{
							stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, " ({0} filters)", new object[]
							{
								targetWithFilterChain.FilterChain.Count
							});
						}
					}
					global::NLog.Common.InternalLogger.Debug(stringBuilder.ToString());
				}
			}
			return new global::NLog.Internal.LoggerConfiguration(array, configuration != null && configuration.ExceptionLoggingOldStyle);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00003B90 File Offset: 0x00001D90
		private void Close(global::System.TimeSpan flushTimeout)
		{
			if (this._isDisposing)
			{
				return;
			}
			this._isDisposing = true;
			global::NLog.LogFactory.LoggerShutdown -= this.OnStopLogging;
			this.ConfigurationReloaded = null;
			if (this._watcher != null)
			{
				this._watcher.FileChanged -= new global::System.IO.FileSystemEventHandler(this.ConfigFileChanged);
				this._watcher.StopWatching();
			}
			if (global::System.Threading.Monitor.TryEnter(this._syncRoot, 500))
			{
				try
				{
					global::System.Threading.Timer reloadTimer = this._reloadTimer;
					if (reloadTimer != null)
					{
						this._reloadTimer = null;
						reloadTimer.WaitForDispose(global::System.TimeSpan.Zero);
					}
					global::NLog.Internal.MultiFileWatcher watcher = this._watcher;
					if (watcher != null)
					{
						watcher.Dispose();
					}
					global::NLog.Config.LoggingConfiguration config = this._config;
					if (this._configLoaded && config != null)
					{
						this.CloseOldConfig(flushTimeout, config);
					}
				}
				finally
				{
					global::System.Threading.Monitor.Exit(this._syncRoot);
				}
			}
			this.ConfigurationChanged = null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003C70 File Offset: 0x00001E70
		private void CloseOldConfig(global::System.TimeSpan flushTimeout, global::NLog.Config.LoggingConfiguration oldConfig)
		{
			try
			{
				bool flag = true;
				if (flushTimeout != global::System.TimeSpan.Zero && !global::NLog.Internal.PlatformDetector.IsMono && !global::NLog.Internal.PlatformDetector.IsUnix)
				{
					global::System.Threading.ManualResetEvent flushCompleted = new global::System.Threading.ManualResetEvent(false);
					oldConfig.FlushAllTargets(delegate(global::System.Exception ex)
					{
						flushCompleted.Set();
					});
					flag = flushCompleted.WaitOne(flushTimeout);
				}
				this._config = null;
				this.ReconfigExistingLoggers();
				if (!flag)
				{
					global::NLog.Common.InternalLogger.Warn("Target flush timeout. One or more targets did not complete flush operation, skipping target close.");
				}
				else
				{
					oldConfig.Close();
					this.OnConfigurationChanged(new global::NLog.Config.LoggingConfigurationChangedEventArgs(null, oldConfig));
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Exception ex2;
				global::NLog.Common.InternalLogger.Error(ex2, "Error with close.");
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00003D18 File Offset: 0x00001F18
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Close(global::System.TimeSpan.Zero);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00003D28 File Offset: 0x00001F28
		internal void Shutdown()
		{
			global::NLog.Common.InternalLogger.Info("Logger closing down...");
			if (!this._isDisposing && this._configLoaded)
			{
				object syncRoot = this._syncRoot;
				lock (syncRoot)
				{
					if (this._isDisposing || !this._configLoaded)
					{
						return;
					}
					this.Configuration = null;
					this._configLoaded = true;
					this.ReconfigExistingLoggers();
				}
			}
			global::NLog.Common.InternalLogger.Info("Logger has been closed down.");
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00003DAC File Offset: 0x00001FAC
		public global::System.Collections.Generic.IEnumerable<string> GetCandidateConfigFilePaths()
		{
			if (this._candidateConfigFilePaths != null)
			{
				return this._candidateConfigFilePaths.AsReadOnly();
			}
			return global::NLog.LogFactory.GetDefaultCandidateConfigFilePaths();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00003DC7 File Offset: 0x00001FC7
		public void SetCandidateConfigFilePaths(global::System.Collections.Generic.IEnumerable<string> filePaths)
		{
			this._candidateConfigFilePaths = new global::System.Collections.Generic.List<string>();
			if (filePaths != null)
			{
				this._candidateConfigFilePaths.AddRange(filePaths);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00003DE3 File Offset: 0x00001FE3
		public void ResetCandidateConfigFilePath()
		{
			this._candidateConfigFilePaths = null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00003DEC File Offset: 0x00001FEC
		private static global::System.Collections.Generic.IEnumerable<string> GetDefaultCandidateConfigFilePaths()
		{
			global::NLog.Internal.Fakeables.IAppDomain appDomain = global::NLog.LogFactory.CurrentAppDomain;
			if (((appDomain != null) ? appDomain.BaseDirectory : null) != null)
			{
				yield return global::System.IO.Path.Combine(global::NLog.LogFactory.CurrentAppDomain.BaseDirectory, "NLog.config");
				yield return global::System.IO.Path.Combine(global::NLog.LogFactory.CurrentAppDomain.BaseDirectory, "nlog.config");
			}
			else
			{
				yield return "NLog.config";
				yield return "nlog.config";
			}
			global::NLog.Internal.Fakeables.IAppDomain appDomain2 = global::NLog.LogFactory.CurrentAppDomain;
			string configurationFile = (appDomain2 != null) ? appDomain2.ConfigurationFile : null;
			if (configurationFile != null)
			{
				yield return global::System.IO.Path.ChangeExtension(configurationFile, ".nlog");
				if (configurationFile.Contains(".vshost."))
				{
					yield return global::System.IO.Path.ChangeExtension(configurationFile.Replace(".vshost.", "."), ".nlog");
				}
				global::System.Collections.Generic.IEnumerable<string> privateBinPath = global::NLog.LogFactory.CurrentAppDomain.PrivateBinPath;
				if (privateBinPath != null)
				{
					foreach (string path in privateBinPath)
					{
						if (path != null)
						{
							yield return global::System.IO.Path.Combine(path, "NLog.config");
							yield return global::System.IO.Path.Combine(path, "nlog.config");
						}
						path = null;
					}
					global::System.Collections.Generic.IEnumerator<string> enumerator = null;
				}
			}
			global::System.Reflection.Assembly assembly = typeof(global::NLog.LogFactory).Assembly;
			if (!assembly.GlobalAssemblyCache && !string.IsNullOrEmpty(assembly.Location))
			{
				yield return assembly.Location + ".nlog";
			}
			yield break;
			yield break;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00003DF8 File Offset: 0x00001FF8
		private global::NLog.Logger GetLogger(global::NLog.LogFactory.LoggerCacheKey cacheKey)
		{
			object syncRoot = this._syncRoot;
			global::NLog.Logger result;
			lock (syncRoot)
			{
				global::NLog.Logger logger = this._loggerCache.Retrieve(cacheKey);
				if (logger != null)
				{
					result = logger;
				}
				else
				{
					global::NLog.Logger logger2;
					if (cacheKey.ConcreteType != null && cacheKey.ConcreteType != typeof(global::NLog.Logger))
					{
						string fullName = cacheKey.ConcreteType.FullName;
						try
						{
							if (cacheKey.ConcreteType.IsStaticClass())
							{
								string message = string.Format("GetLogger / GetCurrentClassLogger is '{0}' as loggerType can be a static class and should inherit from Logger", fullName);
								global::NLog.Common.InternalLogger.Error(message);
								if (this.ThrowExceptions)
								{
									throw new global::NLog.NLogRuntimeException(message);
								}
								logger2 = global::NLog.LogFactory.CreateDefaultLogger(ref cacheKey);
							}
							else
							{
								logger2 = (global::NLog.Internal.FactoryHelper.CreateInstance(cacheKey.ConcreteType) as global::NLog.Logger);
								if (logger2 == null)
								{
									string message2 = string.Format("GetLogger / GetCurrentClassLogger got '{0}' as loggerType which doesn't inherit from Logger", fullName);
									global::NLog.Common.InternalLogger.Error(message2);
									if (this.ThrowExceptions)
									{
										throw new global::NLog.NLogRuntimeException(message2);
									}
									logger2 = global::NLog.LogFactory.CreateDefaultLogger(ref cacheKey);
								}
							}
							goto IL_114;
						}
						catch (global::System.Exception ex)
						{
							global::NLog.Common.InternalLogger.Error(ex, "GetLogger / GetCurrentClassLogger. Cannot create instance of type '{0}'. It should have an default contructor. ", new object[]
							{
								fullName
							});
							if (ex.MustBeRethrown())
							{
								throw;
							}
							logger2 = global::NLog.LogFactory.CreateDefaultLogger(ref cacheKey);
							goto IL_114;
						}
					}
					logger2 = new global::NLog.Logger();
					IL_114:
					if (cacheKey.ConcreteType != null)
					{
						logger2.Initialize(cacheKey.Name, this.GetConfigurationForLogger(cacheKey.Name, this.Configuration), this);
					}
					this._loggerCache.InsertOrUpdate(cacheKey, logger2);
					result = logger2;
				}
			}
			return result;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00003F98 File Offset: 0x00002198
		private static global::NLog.Logger CreateDefaultLogger(ref global::NLog.LogFactory.LoggerCacheKey cacheKey)
		{
			cacheKey = new global::NLog.LogFactory.LoggerCacheKey(cacheKey.Name, typeof(global::NLog.Logger));
			return new global::NLog.Logger();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00003FBA File Offset: 0x000021BA
		public global::NLog.LogFactory LoadConfiguration(string configFile)
		{
			if (global::NLog.Internal.FilePathLayout.DetectFilePathKind(configFile, true) == global::NLog.Targets.FilePathKind.Relative)
			{
				configFile = global::System.IO.Path.Combine(global::NLog.LogFactory.CurrentAppDomain.BaseDirectory, configFile);
			}
			this.Configuration = this.TryLoadLoggingConfiguration(configFile);
			return this;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00003FE8 File Offset: 0x000021E8
		private global::NLog.Config.LoggingConfiguration TryLoadLoggingConfiguration(string configFile)
		{
			global::NLog.Common.InternalLogger.Debug<string>("Loading config from {0}", configFile);
			global::NLog.Config.XmlLoggingConfiguration xmlLoggingConfiguration = new global::NLog.Config.XmlLoggingConfiguration(configFile, this);
			if (xmlLoggingConfiguration.InitializeSucceeded != true)
			{
				global::NLog.Common.InternalLogger.Warn<string>("Failed loading config from {0}. Invalid XML?", configFile);
			}
			return xmlLoggingConfiguration;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00004034 File Offset: 0x00002234
		private void ConfigFileChanged(object sender, global::System.EventArgs args)
		{
			global::NLog.Common.InternalLogger.Info<int>("Configuration file change detected! Reloading in {0}ms...", 1000);
			object syncRoot = this._syncRoot;
			lock (syncRoot)
			{
				if (!this._isDisposing)
				{
					if (this._reloadTimer == null)
					{
						global::NLog.Config.LoggingConfiguration configuration = this.Configuration;
						if (configuration != null)
						{
							this._reloadTimer = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(this.ReloadConfigOnTimer), configuration, 1000, -1);
						}
					}
					else
					{
						this._reloadTimer.Change(1000, -1);
					}
				}
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000040CC File Offset: 0x000022CC
		private static void RegisterEvents(global::NLog.Internal.Fakeables.IAppDomain appDomain)
		{
			if (appDomain == null)
			{
				return;
			}
			try
			{
				appDomain.ProcessExit += global::NLog.LogFactory.OnLoggerShutdown;
				appDomain.DomainUnload += global::NLog.LogFactory.OnLoggerShutdown;
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Error setting up termination events.");
				if (ex.MustBeRethrown())
				{
					throw;
				}
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000412C File Offset: 0x0000232C
		private static void UnregisterEvents(global::NLog.Internal.Fakeables.IAppDomain appDomain)
		{
			if (appDomain == null)
			{
				return;
			}
			appDomain.DomainUnload -= global::NLog.LogFactory.OnLoggerShutdown;
			appDomain.ProcessExit -= global::NLog.LogFactory.OnLoggerShutdown;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00004158 File Offset: 0x00002358
		private static void OnLoggerShutdown(object sender, global::System.EventArgs args)
		{
			try
			{
				global::System.EventHandler<global::System.EventArgs> loggerShutdown = global::NLog.LogFactory.LoggerShutdown;
				if (loggerShutdown != null)
				{
					loggerShutdown(sender, args);
				}
			}
			catch (global::System.Exception ex)
			{
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
				global::NLog.Common.InternalLogger.Error(ex, "LogFactory failed to shut down properly.");
			}
			finally
			{
				global::NLog.LogFactory.LoggerShutdown = null;
				if (global::NLog.LogFactory.currentAppDomain != null)
				{
					global::NLog.LogFactory.CurrentAppDomain = null;
				}
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000041C0 File Offset: 0x000023C0
		private void OnStopLogging(object sender, global::System.EventArgs args)
		{
			try
			{
				global::NLog.Common.InternalLogger.Info("Shutting down logging...");
				this.Close(global::System.TimeSpan.FromMilliseconds(1500.0));
				global::NLog.Common.InternalLogger.Info("Logger has been shut down.");
			}
			catch (global::System.Exception ex)
			{
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
				global::NLog.Common.InternalLogger.Error(ex, "Logger failed to shut down properly.");
			}
		}

		// Token: 0x04000013 RID: 19
		private const int ReconfigAfterFileChangedTimeout = 1000;

		// Token: 0x04000014 RID: 20
		internal global::System.Threading.Timer _reloadTimer;

		// Token: 0x04000015 RID: 21
		private readonly global::NLog.Internal.MultiFileWatcher _watcher;

		// Token: 0x04000016 RID: 22
		private static readonly global::System.TimeSpan DefaultFlushTimeout = global::System.TimeSpan.FromSeconds(15.0);

		// Token: 0x04000017 RID: 23
		private static global::NLog.Internal.Fakeables.IAppDomain currentAppDomain;

		// Token: 0x04000018 RID: 24
		internal readonly object _syncRoot = new object();

		// Token: 0x04000019 RID: 25
		private global::NLog.Config.LoggingConfiguration _config;

		// Token: 0x0400001A RID: 26
		private global::NLog.LogLevel _globalThreshold = global::NLog.LogLevel.MinLevel;

		// Token: 0x0400001B RID: 27
		private bool _configLoaded;

		// Token: 0x0400001C RID: 28
		private int _logsEnabled;

		// Token: 0x0400001D RID: 29
		private readonly global::NLog.LogFactory.LoggerCache _loggerCache = new global::NLog.LogFactory.LoggerCache();

		// Token: 0x0400001E RID: 30
		private global::System.Collections.Generic.List<string> _candidateConfigFilePaths;

		// Token: 0x04000025 RID: 37
		private bool _isDisposing;

		// Token: 0x020001B2 RID: 434
		internal struct LoggerCacheKey : global::System.IEquatable<global::NLog.LogFactory.LoggerCacheKey>
		{
			// Token: 0x0600119D RID: 4509 RVA: 0x0002E1D8 File Offset: 0x0002C3D8
			public LoggerCacheKey(string name, global::System.Type concreteType)
			{
				this.Name = name;
				this.ConcreteType = concreteType;
			}

			// Token: 0x0600119E RID: 4510 RVA: 0x0002E1E8 File Offset: 0x0002C3E8
			public override int GetHashCode()
			{
				return this.ConcreteType.GetHashCode() ^ this.Name.GetHashCode();
			}

			// Token: 0x0600119F RID: 4511 RVA: 0x0002E204 File Offset: 0x0002C404
			public override bool Equals(object obj)
			{
				if (obj is global::NLog.LogFactory.LoggerCacheKey)
				{
					global::NLog.LogFactory.LoggerCacheKey other = (global::NLog.LogFactory.LoggerCacheKey)obj;
					return this.Equals(other);
				}
				return false;
			}

			// Token: 0x060011A0 RID: 4512 RVA: 0x0002E22B File Offset: 0x0002C42B
			public bool Equals(global::NLog.LogFactory.LoggerCacheKey other)
			{
				return this.ConcreteType == other.ConcreteType && string.Equals(other.Name, this.Name, global::System.StringComparison.Ordinal);
			}

			// Token: 0x040004EC RID: 1260
			public readonly string Name;

			// Token: 0x040004ED RID: 1261
			public readonly global::System.Type ConcreteType;
		}

		// Token: 0x020001B3 RID: 435
		private class LoggerCache
		{
			// Token: 0x060011A1 RID: 4513 RVA: 0x0002E254 File Offset: 0x0002C454
			public void InsertOrUpdate(global::NLog.LogFactory.LoggerCacheKey cacheKey, global::NLog.Logger logger)
			{
				this._loggerCache[cacheKey] = new global::System.WeakReference(logger);
			}

			// Token: 0x060011A2 RID: 4514 RVA: 0x0002E268 File Offset: 0x0002C468
			public global::NLog.Logger Retrieve(global::NLog.LogFactory.LoggerCacheKey cacheKey)
			{
				global::System.WeakReference weakReference;
				if (this._loggerCache.TryGetValue(cacheKey, out weakReference))
				{
					return weakReference.Target as global::NLog.Logger;
				}
				return null;
			}

			// Token: 0x060011A3 RID: 4515 RVA: 0x0002E294 File Offset: 0x0002C494
			public global::System.Collections.Generic.List<global::NLog.Logger> GetLoggers()
			{
				global::System.Collections.Generic.List<global::NLog.Logger> list = new global::System.Collections.Generic.List<global::NLog.Logger>(this._loggerCache.Count);
				using (global::System.Collections.Generic.Dictionary<global::NLog.LogFactory.LoggerCacheKey, global::System.WeakReference>.ValueCollection.Enumerator enumerator = this._loggerCache.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::NLog.Logger item;
						if ((item = (enumerator.Current.Target as global::NLog.Logger)) != null)
						{
							list.Add(item);
						}
					}
				}
				return list;
			}

			// Token: 0x040004EE RID: 1262
			private readonly global::System.Collections.Generic.Dictionary<global::NLog.LogFactory.LoggerCacheKey, global::System.WeakReference> _loggerCache = new global::System.Collections.Generic.Dictionary<global::NLog.LogFactory.LoggerCacheKey, global::System.WeakReference>();
		}

		// Token: 0x020001B4 RID: 436
		private class LogEnabler : global::System.IDisposable
		{
			// Token: 0x060011A5 RID: 4517 RVA: 0x0002E31F File Offset: 0x0002C51F
			public LogEnabler(global::NLog.LogFactory factory)
			{
				this._factory = factory;
			}

			// Token: 0x060011A6 RID: 4518 RVA: 0x0002E32E File Offset: 0x0002C52E
			void global::System.IDisposable.Dispose()
			{
				this._factory.ResumeLogging();
			}

			// Token: 0x040004EF RID: 1263
			private readonly global::NLog.LogFactory _factory;
		}
	}
}
