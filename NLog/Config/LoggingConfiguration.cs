using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using JetBrains.Annotations;
using NLog.Common;
using NLog.Internal;
using NLog.Layouts;
using NLog.Targets;
using NLog.Targets.Wrappers;

namespace NLog.Config
{
	// Token: 0x02000165 RID: 357
	public class LoggingConfiguration
	{
		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00027C6A File Offset: 0x00025E6A
		public global::NLog.LogFactory LogFactory { get; }

		// Token: 0x06000F8A RID: 3978 RVA: 0x00027C72 File Offset: 0x00025E72
		public LoggingConfiguration() : this(global::NLog.LogManager.LogFactory)
		{
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00027C80 File Offset: 0x00025E80
		public LoggingConfiguration(global::NLog.LogFactory logFactory)
		{
			this.LogFactory = logFactory;
			this.LoggingRules = new global::System.Collections.Generic.List<global::NLog.Config.LoggingRule>();
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00027CD0 File Offset: 0x00025ED0
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00027CD8 File Offset: 0x00025ED8
		[global::System.Obsolete("This option will be removed in NLog 5. Marked obsolete on NLog 4.1")]
		public bool ExceptionLoggingOldStyle { get; set; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00027CE1 File Offset: 0x00025EE1
		public global::System.Collections.Generic.IDictionary<string, global::NLog.Layouts.SimpleLayout> Variables
		{
			get
			{
				return this._variables;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00027CE9 File Offset: 0x00025EE9
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::NLog.Targets.Target> ConfiguredNamedTargets
		{
			get
			{
				return this.GetAllTargetsThreadSafe().AsReadOnly();
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00027CF6 File Offset: 0x00025EF6
		public virtual global::System.Collections.Generic.IEnumerable<string> FileNamesToWatch
		{
			get
			{
				return global::NLog.Internal.ArrayHelper.Empty<string>();
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00027CFD File Offset: 0x00025EFD
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x00027D05 File Offset: 0x00025F05
		public global::System.Collections.Generic.IList<global::NLog.Config.LoggingRule> LoggingRules { get; private set; }

		// Token: 0x06000F93 RID: 3987 RVA: 0x00027D10 File Offset: 0x00025F10
		internal global::System.Collections.Generic.List<global::NLog.Config.LoggingRule> GetLoggingRulesThreadSafe()
		{
			global::System.Collections.Generic.IList<global::NLog.Config.LoggingRule> loggingRules = this.LoggingRules;
			global::System.Collections.Generic.List<global::NLog.Config.LoggingRule> result;
			lock (loggingRules)
			{
				result = this.LoggingRules.ToList<global::NLog.Config.LoggingRule>();
			}
			return result;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00027D58 File Offset: 0x00025F58
		private void AddLoggingRulesThreadSafe(global::NLog.Config.LoggingRule rule)
		{
			global::System.Collections.Generic.IList<global::NLog.Config.LoggingRule> loggingRules = this.LoggingRules;
			lock (loggingRules)
			{
				this.LoggingRules.Add(rule);
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00027DA0 File Offset: 0x00025FA0
		private bool TryGetTargetThreadSafe(string name, out global::NLog.Targets.Target target)
		{
			global::System.Collections.Generic.IDictionary<string, global::NLog.Targets.Target> targets = this._targets;
			bool result;
			lock (targets)
			{
				result = this._targets.TryGetValue(name, out target);
			}
			return result;
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00027DEC File Offset: 0x00025FEC
		private global::System.Collections.Generic.List<global::NLog.Targets.Target> GetAllTargetsThreadSafe()
		{
			global::System.Collections.Generic.IDictionary<string, global::NLog.Targets.Target> targets = this._targets;
			global::System.Collections.Generic.List<global::NLog.Targets.Target> result;
			lock (targets)
			{
				result = this._targets.Values.ToList<global::NLog.Targets.Target>();
			}
			return result;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00027E38 File Offset: 0x00026038
		private global::NLog.Targets.Target RemoveTargetThreadSafe(string name)
		{
			global::System.Collections.Generic.IDictionary<string, global::NLog.Targets.Target> targets = this._targets;
			global::NLog.Targets.Target target;
			lock (targets)
			{
				if (this._targets.TryGetValue(name, out target))
				{
					this._targets.Remove(name);
				}
			}
			if (target != null)
			{
				global::NLog.Common.InternalLogger.Debug<string, string>("Unregistered target {0}: {1}", name, target.GetType().FullName);
			}
			return target;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00027EAC File Offset: 0x000260AC
		private void AddTargetThreadSafe(string name, global::NLog.Targets.Target target, bool forceOverwrite)
		{
			if (string.IsNullOrEmpty(name) && !forceOverwrite)
			{
				return;
			}
			global::System.Collections.Generic.IDictionary<string, global::NLog.Targets.Target> targets = this._targets;
			lock (targets)
			{
				if (!forceOverwrite && this._targets.ContainsKey(name))
				{
					return;
				}
				this._targets[name] = target;
			}
			if (!string.IsNullOrEmpty(target.Name) && target.Name != name)
			{
				global::NLog.Common.InternalLogger.Info<string, string, string>("Registered target {0}: {1} (Target created with different name: {2})", name, target.GetType().FullName, target.Name);
				return;
			}
			global::NLog.Common.InternalLogger.Debug<string, string>("Registered target {0}: {1}", name, target.GetType().FullName);
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00027F60 File Offset: 0x00026160
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x00027F68 File Offset: 0x00026168
		[global::JetBrains.Annotations.CanBeNull]
		public global::System.Globalization.CultureInfo DefaultCultureInfo { get; set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00027F71 File Offset: 0x00026171
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::NLog.Targets.Target> AllTargets
		{
			get
			{
				return this._configItems.OfType<global::NLog.Targets.Target>().Concat(this.GetAllTargetsThreadSafe()).Distinct(global::NLog.Config.LoggingConfiguration.TargetNameComparer).ToList<global::NLog.Targets.Target>().AsReadOnly();
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00027F9D File Offset: 0x0002619D
		public void AddTarget([global::JetBrains.Annotations.NotNull] global::NLog.Targets.Target target)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			if (target.Name == null)
			{
				throw new global::System.ArgumentNullException("target.Name cannot be null.");
			}
			this.AddTargetThreadSafe(target.Name, target, true);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00027FCE File Offset: 0x000261CE
		public void AddTarget(string name, global::NLog.Targets.Target target)
		{
			if (name == null)
			{
				throw new global::System.ArgumentException("Target name cannot be null", "name");
			}
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			this.AddTargetThreadSafe(name, target, true);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00027FFC File Offset: 0x000261FC
		public global::NLog.Targets.Target FindTargetByName(string name)
		{
			global::NLog.Targets.Target result;
			if (!this.TryGetTargetThreadSafe(name, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00028017 File Offset: 0x00026217
		public TTarget FindTargetByName<TTarget>(string name) where TTarget : global::NLog.Targets.Target
		{
			return this.FindTargetByName(name) as TTarget;
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0002802C File Offset: 0x0002622C
		public void AddRule(global::NLog.LogLevel minLevel, global::NLog.LogLevel maxLevel, string targetName, string loggerNamePattern = "*")
		{
			global::NLog.Targets.Target target = this.FindTargetByName(targetName);
			if (target == null)
			{
				throw new global::NLog.NLogRuntimeException("Target '{0}' not found", new object[]
				{
					targetName
				});
			}
			this.AddRule(minLevel, maxLevel, target, loggerNamePattern, false);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00028065 File Offset: 0x00026265
		public void AddRule(global::NLog.LogLevel minLevel, global::NLog.LogLevel maxLevel, global::NLog.Targets.Target target, string loggerNamePattern = "*")
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			this.AddRule(minLevel, maxLevel, target, loggerNamePattern, false);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00028081 File Offset: 0x00026281
		public void AddRule(global::NLog.LogLevel minLevel, global::NLog.LogLevel maxLevel, global::NLog.Targets.Target target, string loggerNamePattern, bool final)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			this.AddLoggingRulesThreadSafe(new global::NLog.Config.LoggingRule(loggerNamePattern, minLevel, maxLevel, target)
			{
				Final = final
			});
			this.AddTargetThreadSafe(target.Name, target, false);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x000280B8 File Offset: 0x000262B8
		public void AddRuleForOneLevel(global::NLog.LogLevel level, string targetName, string loggerNamePattern = "*")
		{
			global::NLog.Targets.Target target = this.FindTargetByName(targetName);
			if (target == null)
			{
				throw new global::NLog.NLogConfigurationException("Target '{0}' not found", new object[]
				{
					targetName
				});
			}
			this.AddRuleForOneLevel(level, target, loggerNamePattern, false);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x000280EF File Offset: 0x000262EF
		public void AddRuleForOneLevel(global::NLog.LogLevel level, global::NLog.Targets.Target target, string loggerNamePattern = "*")
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			this.AddRuleForOneLevel(level, target, loggerNamePattern, false);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0002810C File Offset: 0x0002630C
		public void AddRuleForOneLevel(global::NLog.LogLevel level, global::NLog.Targets.Target target, string loggerNamePattern, bool final)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			global::NLog.Config.LoggingRule loggingRule = new global::NLog.Config.LoggingRule(loggerNamePattern, target)
			{
				Final = final
			};
			loggingRule.EnableLoggingForLevel(level);
			this.AddLoggingRulesThreadSafe(loggingRule);
			this.AddTargetThreadSafe(target.Name, target, false);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00028154 File Offset: 0x00026354
		public void AddRuleForAllLevels(string targetName, string loggerNamePattern = "*")
		{
			global::NLog.Targets.Target target = this.FindTargetByName(targetName);
			if (target == null)
			{
				throw new global::NLog.NLogRuntimeException("Target '{0}' not found", new object[]
				{
					targetName
				});
			}
			this.AddRuleForAllLevels(target, loggerNamePattern, false);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0002818A File Offset: 0x0002638A
		public void AddRuleForAllLevels(global::NLog.Targets.Target target, string loggerNamePattern = "*")
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			this.AddRuleForAllLevels(target, loggerNamePattern, false);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000281A4 File Offset: 0x000263A4
		public void AddRuleForAllLevels(global::NLog.Targets.Target target, string loggerNamePattern, bool final)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			global::NLog.Config.LoggingRule loggingRule = new global::NLog.Config.LoggingRule(loggerNamePattern, target)
			{
				Final = final
			};
			loggingRule.EnableLoggingForLevels(global::NLog.LogLevel.MinLevel, global::NLog.LogLevel.MaxLevel);
			this.AddLoggingRulesThreadSafe(loggingRule);
			this.AddTargetThreadSafe(target.Name, target, false);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x000281F3 File Offset: 0x000263F3
		public virtual global::NLog.Config.LoggingConfiguration Reload()
		{
			return this;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x000281F8 File Offset: 0x000263F8
		public void RemoveTarget(string name)
		{
			global::System.Collections.Generic.HashSet<global::NLog.Targets.Target> hashSet = new global::System.Collections.Generic.HashSet<global::NLog.Targets.Target>();
			global::NLog.Targets.Target target = this.RemoveTargetThreadSafe(name);
			if (target != null)
			{
				hashSet.Add(target);
			}
			if (!string.IsNullOrEmpty(name) || target != null)
			{
				foreach (global::NLog.Config.LoggingRule loggingRule in this.GetLoggingRulesThreadSafe())
				{
					foreach (global::NLog.Targets.Target target2 in loggingRule.GetTargetsThreadSafe())
					{
						if (target == target2 || (!string.IsNullOrEmpty(name) && target2.Name == name))
						{
							hashSet.Add(target2);
							loggingRule.RemoveTargetThreadSafe(target2);
						}
					}
				}
			}
			if (hashSet.Count > 0)
			{
				this.ValidateConfig();
				if (this.LogFactory != null)
				{
					this.LogFactory.ReconfigExistingLoggers();
				}
				else
				{
					global::NLog.LogManager.ReconfigExistingLoggers();
				}
				global::System.Threading.ManualResetEvent flushCompleted = new global::System.Threading.ManualResetEvent(false);
				global::NLog.Common.AsyncContinuation <>9__0;
				foreach (global::NLog.Targets.Target target3 in hashSet)
				{
					flushCompleted.Reset();
					global::NLog.Common.AsyncContinuation asyncContinuation;
					if ((asyncContinuation = <>9__0) == null)
					{
						asyncContinuation = (<>9__0 = delegate(global::System.Exception ex)
						{
							flushCompleted.Set();
						});
					}
					target3.Flush(asyncContinuation);
					flushCompleted.WaitOne(global::System.TimeSpan.FromSeconds(15.0));
					target3.Close();
				}
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000283A4 File Offset: 0x000265A4
		public void Install(global::NLog.Config.InstallationContext installationContext)
		{
			if (installationContext == null)
			{
				throw new global::System.ArgumentNullException("installationContext");
			}
			this.InitializeAll();
			foreach (global::NLog.Config.IInstallable installable in this.GetInstallableItems())
			{
				installationContext.Info("Installing '{0}'", new object[]
				{
					installable
				});
				try
				{
					installable.Install(installationContext);
					installationContext.Info("Finished installing '{0}'.", new object[]
					{
						installable
					});
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Error(ex, "Install of '{0}' failed.", new object[]
					{
						installable
					});
					if (ex.MustBeRethrownImmediately() || installationContext.ThrowExceptions)
					{
						throw;
					}
					installationContext.Error("Install of '{0}' failed: {1}.", new object[]
					{
						installable,
						ex
					});
				}
			}
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0002848C File Offset: 0x0002668C
		public void Uninstall(global::NLog.Config.InstallationContext installationContext)
		{
			if (installationContext == null)
			{
				throw new global::System.ArgumentNullException("installationContext");
			}
			this.InitializeAll();
			foreach (global::NLog.Config.IInstallable installable in this.GetInstallableItems())
			{
				installationContext.Info("Uninstalling '{0}'", new object[]
				{
					installable
				});
				try
				{
					installable.Uninstall(installationContext);
					installationContext.Info("Finished uninstalling '{0}'.", new object[]
					{
						installable
					});
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Error(ex, "Uninstall of '{0}' failed.", new object[]
					{
						installable
					});
					if (ex.MustBeRethrownImmediately())
					{
						throw;
					}
					installationContext.Error("Uninstall of '{0}' failed: {1}.", new object[]
					{
						installable,
						ex
					});
				}
			}
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00028568 File Offset: 0x00026768
		internal void Close()
		{
			global::NLog.Common.InternalLogger.Debug("Closing logging configuration...");
			foreach (global::NLog.Internal.ISupportsInitialize supportsInitialize in this.GetSupportsInitializes(false))
			{
				global::NLog.Common.InternalLogger.Trace<global::NLog.Internal.ISupportsInitialize>("Closing {0}", supportsInitialize);
				try
				{
					supportsInitialize.Close();
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Warn(ex, "Exception while closing.");
					if (ex.MustBeRethrown())
					{
						throw;
					}
				}
			}
			global::NLog.Common.InternalLogger.Debug("Finished closing logging configuration.");
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00028600 File Offset: 0x00026800
		internal void Dump()
		{
			if (!global::NLog.Common.InternalLogger.IsDebugEnabled)
			{
				return;
			}
			global::NLog.Common.InternalLogger.Debug("--- NLog configuration dump ---");
			global::NLog.Common.InternalLogger.Debug("Targets:");
			foreach (global::NLog.Targets.Target arg in this.GetAllTargetsThreadSafe())
			{
				global::NLog.Common.InternalLogger.Debug<global::NLog.Targets.Target>("{0}", arg);
			}
			global::NLog.Common.InternalLogger.Debug("Rules:");
			foreach (global::NLog.Config.LoggingRule arg2 in this.GetLoggingRulesThreadSafe())
			{
				global::NLog.Common.InternalLogger.Debug<global::NLog.Config.LoggingRule>("{0}", arg2);
			}
			global::NLog.Common.InternalLogger.Debug("--- End of NLog configuration dump ---");
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000286D0 File Offset: 0x000268D0
		internal void FlushAllTargets(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			global::NLog.Common.InternalLogger.Trace("Flushing all targets...");
			global::System.Collections.Generic.List<global::NLog.Targets.Target> list = new global::System.Collections.Generic.List<global::NLog.Targets.Target>();
			foreach (global::NLog.Config.LoggingRule loggingRule in this.GetLoggingRulesThreadSafe())
			{
				foreach (global::NLog.Targets.Target item in loggingRule.GetTargetsThreadSafe())
				{
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
			}
			global::NLog.Common.AsyncHelpers.ForEachItemInParallel<global::NLog.Targets.Target>(list, asyncContinuation, delegate(global::NLog.Targets.Target target, global::NLog.Common.AsyncContinuation cont)
			{
				target.Flush(cont);
			});
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0002879C File Offset: 0x0002699C
		internal void ValidateConfig()
		{
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			foreach (global::NLog.Config.LoggingRule item in this.GetLoggingRulesThreadSafe())
			{
				list.Add(item);
			}
			foreach (global::NLog.Targets.Target item2 in this.GetAllTargetsThreadSafe())
			{
				list.Add(item2);
			}
			this._configItems = global::NLog.Internal.ObjectGraphScanner.FindReachableObjects<object>(true, list.ToArray());
			global::NLog.Common.InternalLogger.Info<int>("Found {0} configuration items", this._configItems.Count);
			foreach (object o in this._configItems)
			{
				global::NLog.Internal.PropertyHelper.CheckRequiredParameters(o);
			}
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000288A0 File Offset: 0x00026AA0
		internal void InitializeAll()
		{
			this.ValidateConfig();
			foreach (global::NLog.Internal.ISupportsInitialize supportsInitialize in this.GetSupportsInitializes(true))
			{
				global::NLog.Common.InternalLogger.Trace<global::NLog.Internal.ISupportsInitialize>("Initializing {0}", supportsInitialize);
				try
				{
					supportsInitialize.Initialize(this);
				}
				catch (global::System.Exception ex)
				{
					if (ex.MustBeRethrown())
					{
						throw;
					}
					if (global::NLog.LogManager.ThrowExceptions)
					{
						throw new global::NLog.NLogConfigurationException(string.Format("Error during initialization of {0}", supportsInitialize), ex);
					}
				}
			}
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0002893C File Offset: 0x00026B3C
		internal void EnsureInitialized()
		{
			this.InitializeAll();
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00028944 File Offset: 0x00026B44
		private global::System.Collections.Generic.List<global::NLog.Config.IInstallable> GetInstallableItems()
		{
			return this._configItems.OfType<global::NLog.Config.IInstallable>().ToList<global::NLog.Config.IInstallable>();
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00028958 File Offset: 0x00026B58
		private global::System.Collections.Generic.List<global::NLog.Internal.ISupportsInitialize> GetSupportsInitializes(bool reverse = false)
		{
			global::System.Collections.Generic.IEnumerable<global::NLog.Internal.ISupportsInitialize> source = this._configItems.OfType<global::NLog.Internal.ISupportsInitialize>();
			if (reverse)
			{
				source = source.Reverse<global::NLog.Internal.ISupportsInitialize>();
			}
			return source.ToList<global::NLog.Internal.ISupportsInitialize>();
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00028984 File Offset: 0x00026B84
		internal void CopyVariables(global::System.Collections.Generic.IDictionary<string, global::NLog.Layouts.SimpleLayout> masterVariables)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::NLog.Layouts.SimpleLayout> keyValuePair in masterVariables)
			{
				this.Variables[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000289E0 File Offset: 0x00026BE0
		internal string ExpandSimpleVariables(string input)
		{
			string text = input;
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::NLog.Layouts.SimpleLayout> keyValuePair in this.Variables.ToList<global::System.Collections.Generic.KeyValuePair<string, global::NLog.Layouts.SimpleLayout>>())
			{
				global::NLog.Layouts.SimpleLayout value = keyValuePair.Value;
				if (value != null)
				{
					text = text.Replace("${" + keyValuePair.Key + "}", value.OriginalText);
				}
			}
			return text;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00028A64 File Offset: 0x00026C64
		internal void CheckUnusedTargets()
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::NLog.Targets.Target> configuredNamedTargets = this.ConfiguredNamedTargets;
			global::NLog.Common.InternalLogger.Debug<int, int>("Unused target checking is started... Rule Count: {0}, Target Count: {1}", this.LoggingRules.Count, configuredNamedTargets.Count);
			global::System.Collections.Generic.HashSet<string> targetNamesAtRules = new global::System.Collections.Generic.HashSet<string>(from t in this.GetLoggingRulesThreadSafe().SelectMany((global::NLog.Config.LoggingRule r) => r.Targets)
			select t.Name);
			global::System.Linq.ILookup<global::NLog.Targets.Target, global::NLog.Targets.Wrappers.WrapperTargetBase> wrappedTargets = configuredNamedTargets.OfType<global::NLog.Targets.Wrappers.WrapperTargetBase>().ToLookup((global::NLog.Targets.Wrappers.WrapperTargetBase wt) => wt.WrappedTarget, (global::NLog.Targets.Wrappers.WrapperTargetBase wt) => wt);
			global::System.Linq.ILookup<global::NLog.Targets.Target, global::NLog.Targets.Target> compoundTargets = configuredNamedTargets.OfType<global::NLog.Targets.Wrappers.CompoundTargetBase>().SelectMany((global::NLog.Targets.Wrappers.CompoundTargetBase wt) => from t in wt.Targets
			select new global::System.Collections.Generic.KeyValuePair<global::NLog.Targets.Target, global::NLog.Targets.Target>(t, wt)).ToLookup((global::System.Collections.Generic.KeyValuePair<global::NLog.Targets.Target, global::NLog.Targets.Target> p) => p.Key, (global::System.Collections.Generic.KeyValuePair<global::NLog.Targets.Target, global::NLog.Targets.Target> p) => p.Value);
			int arg = configuredNamedTargets.Count(delegate(global::NLog.Targets.Target target)
			{
				if (targetNamesAtRules.Contains(target.Name))
				{
					return false;
				}
				if (wrappedTargets.Contains(target))
				{
					foreach (global::NLog.Targets.Wrappers.WrapperTargetBase wrapperTargetBase in wrappedTargets[target])
					{
						if (targetNamesAtRules.Contains(wrapperTargetBase.Name))
						{
							return false;
						}
						if (wrappedTargets.Contains(wrapperTargetBase))
						{
							return false;
						}
						if (compoundTargets.Contains(wrapperTargetBase))
						{
							return false;
						}
					}
				}
				if (compoundTargets.Contains(target))
				{
					foreach (global::NLog.Targets.Target target2 in compoundTargets[target])
					{
						if (targetNamesAtRules.Contains(target2.Name))
						{
							return false;
						}
						if (wrappedTargets.Contains(target2))
						{
							return false;
						}
						if (compoundTargets.Contains(target2))
						{
							return false;
						}
					}
				}
				global::NLog.Common.InternalLogger.Warn<string>("Unused target detected. Add a rule for this target to the configuration. TargetName: {0}", target.Name);
				return true;
			});
			global::NLog.Common.InternalLogger.Debug<int, int, int>("Unused target checking is completed. Total Rule Count: {0}, Total Target Count: {1}, Unused Target Count: {2}", this.LoggingRules.Count, configuredNamedTargets.Count, arg);
		}

		// Token: 0x04000457 RID: 1111
		private readonly global::System.Collections.Generic.IDictionary<string, global::NLog.Targets.Target> _targets = new global::System.Collections.Generic.Dictionary<string, global::NLog.Targets.Target>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000458 RID: 1112
		private global::System.Collections.Generic.List<object> _configItems = new global::System.Collections.Generic.List<object>();

		// Token: 0x04000459 RID: 1113
		private readonly global::System.Collections.Generic.Dictionary<string, global::NLog.Layouts.SimpleLayout> _variables = new global::System.Collections.Generic.Dictionary<string, global::NLog.Layouts.SimpleLayout>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400045E RID: 1118
		private static readonly global::System.Collections.Generic.IEqualityComparer<global::NLog.Targets.Target> TargetNameComparer = new global::NLog.Config.LoggingConfiguration.TargetNameEqualityComparer();

		// Token: 0x02000237 RID: 567
		private class TargetNameEqualityComparer : global::System.Collections.Generic.IEqualityComparer<global::NLog.Targets.Target>
		{
			// Token: 0x0600138F RID: 5007 RVA: 0x00032BE7 File Offset: 0x00030DE7
			public bool Equals(global::NLog.Targets.Target x, global::NLog.Targets.Target y)
			{
				return string.Equals(x.Name, y.Name);
			}

			// Token: 0x06001390 RID: 5008 RVA: 0x00032BFA File Offset: 0x00030DFA
			public int GetHashCode(global::NLog.Targets.Target obj)
			{
				if (obj.Name == null)
				{
					return 0;
				}
				return obj.Name.GetHashCode();
			}
		}
	}
}
