using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using NLog.Common;
using NLog.Config;
using NLog.Internal;

namespace NLog
{
	// Token: 0x02000011 RID: 17
	public static class LogManager
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00008012 File Offset: 0x00006212
		public static global::NLog.LogFactory LogFactory
		{
			get
			{
				return global::NLog.LogManager.factory;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060003E4 RID: 996 RVA: 0x00008019 File Offset: 0x00006219
		// (remove) Token: 0x060003E5 RID: 997 RVA: 0x00008026 File Offset: 0x00006226
		public static event global::System.EventHandler<global::NLog.Config.LoggingConfigurationChangedEventArgs> ConfigurationChanged
		{
			add
			{
				global::NLog.LogManager.factory.ConfigurationChanged += value;
			}
			remove
			{
				global::NLog.LogManager.factory.ConfigurationChanged -= value;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060003E6 RID: 998 RVA: 0x00008033 File Offset: 0x00006233
		// (remove) Token: 0x060003E7 RID: 999 RVA: 0x00008040 File Offset: 0x00006240
		public static event global::System.EventHandler<global::NLog.Config.LoggingConfigurationReloadedEventArgs> ConfigurationReloaded
		{
			add
			{
				global::NLog.LogManager.factory.ConfigurationReloaded += value;
			}
			remove
			{
				global::NLog.LogManager.factory.ConfigurationReloaded -= value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000804D File Offset: 0x0000624D
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00008059 File Offset: 0x00006259
		public static bool ThrowExceptions
		{
			get
			{
				return global::NLog.LogManager.factory.ThrowExceptions;
			}
			set
			{
				global::NLog.LogManager.factory.ThrowExceptions = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00008066 File Offset: 0x00006266
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00008072 File Offset: 0x00006272
		public static bool? ThrowConfigExceptions
		{
			get
			{
				return global::NLog.LogManager.factory.ThrowConfigExceptions;
			}
			set
			{
				global::NLog.LogManager.factory.ThrowConfigExceptions = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000807F File Offset: 0x0000627F
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0000808B File Offset: 0x0000628B
		public static bool KeepVariablesOnReload
		{
			get
			{
				return global::NLog.LogManager.factory.KeepVariablesOnReload;
			}
			set
			{
				global::NLog.LogManager.factory.KeepVariablesOnReload = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00008098 File Offset: 0x00006298
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x000080A4 File Offset: 0x000062A4
		public static global::NLog.Config.LoggingConfiguration Configuration
		{
			get
			{
				return global::NLog.LogManager.factory.Configuration;
			}
			set
			{
				global::NLog.LogManager.factory.Configuration = value;
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000080B1 File Offset: 0x000062B1
		public static global::NLog.LogFactory LoadConfiguration(string configFile)
		{
			global::NLog.LogManager.factory.LoadConfiguration(configFile);
			return global::NLog.LogManager.factory;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000080C4 File Offset: 0x000062C4
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x000080D0 File Offset: 0x000062D0
		public static global::NLog.LogLevel GlobalThreshold
		{
			get
			{
				return global::NLog.LogManager.factory.GlobalThreshold;
			}
			set
			{
				global::NLog.LogManager.factory.GlobalThreshold = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000080DD File Offset: 0x000062DD
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x000080FE File Offset: 0x000062FE
		[global::System.Obsolete("Use Configuration.DefaultCultureInfo property instead. Marked obsolete before v4.3.11")]
		public static global::NLog.LogManager.GetCultureInfo DefaultCultureInfo
		{
			get
			{
				return () => global::NLog.LogManager.factory.DefaultCultureInfo ?? global::System.Globalization.CultureInfo.CurrentCulture;
			}
			set
			{
				throw new global::System.NotSupportedException("Setting the DefaultCultureInfo delegate is no longer supported. Use the Configuration.DefaultCultureInfo property to change the default CultureInfo.");
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000810A File Offset: 0x0000630A
		[global::System.CLSCompliant(false)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static global::NLog.Logger GetCurrentClassLogger()
		{
			return global::NLog.LogManager.factory.GetLogger(global::NLog.Internal.StackTraceUsageUtils.GetClassFullName());
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000811B File Offset: 0x0000631B
		internal static bool IsHiddenAssembly(global::System.Reflection.Assembly assembly)
		{
			return global::NLog.LogManager._hiddenAssemblies != null && global::NLog.LogManager._hiddenAssemblies.Contains(assembly);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00008134 File Offset: 0x00006334
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void AddHiddenAssembly(global::System.Reflection.Assembly assembly)
		{
			object obj = global::NLog.LogManager.lockObject;
			lock (obj)
			{
				if (global::NLog.LogManager._hiddenAssemblies != null && global::NLog.LogManager._hiddenAssemblies.Contains(assembly))
				{
					return;
				}
				global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> hiddenAssemblies = global::NLog.LogManager._hiddenAssemblies;
				global::NLog.LogManager._hiddenAssemblies = new global::System.Collections.Generic.HashSet<global::System.Reflection.Assembly>(hiddenAssemblies ?? global::System.Linq.Enumerable.Empty<global::System.Reflection.Assembly>())
				{
					assembly
				};
			}
			global::NLog.Common.InternalLogger.Trace<string>("Assembly '{0}' will be hidden in callsite stacktrace", (assembly != null) ? assembly.FullName : null);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000081BC File Offset: 0x000063BC
		[global::System.CLSCompliant(false)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static global::NLog.Logger GetCurrentClassLogger(global::System.Type loggerType)
		{
			return global::NLog.LogManager.factory.GetLogger(global::NLog.Internal.StackTraceUsageUtils.GetClassFullName(), loggerType);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000081CE File Offset: 0x000063CE
		[global::System.CLSCompliant(false)]
		public static global::NLog.Logger CreateNullLogger()
		{
			return global::NLog.LogManager.factory.CreateNullLogger();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000081DA File Offset: 0x000063DA
		[global::System.CLSCompliant(false)]
		public static global::NLog.Logger GetLogger(string name)
		{
			return global::NLog.LogManager.factory.GetLogger(name);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000081E7 File Offset: 0x000063E7
		[global::System.CLSCompliant(false)]
		public static global::NLog.Logger GetLogger(string name, global::System.Type loggerType)
		{
			return global::NLog.LogManager.factory.GetLogger(name, loggerType);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000081F5 File Offset: 0x000063F5
		public static void ReconfigExistingLoggers()
		{
			global::NLog.LogManager.factory.ReconfigExistingLoggers();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00008201 File Offset: 0x00006401
		public static void Flush()
		{
			global::NLog.LogManager.factory.Flush();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000820D File Offset: 0x0000640D
		public static void Flush(global::System.TimeSpan timeout)
		{
			global::NLog.LogManager.factory.Flush(timeout);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000821A File Offset: 0x0000641A
		public static void Flush(int timeoutMilliseconds)
		{
			global::NLog.LogManager.factory.Flush(timeoutMilliseconds);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00008227 File Offset: 0x00006427
		public static void Flush(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			global::NLog.LogManager.factory.Flush(asyncContinuation);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00008234 File Offset: 0x00006434
		public static void Flush(global::NLog.Common.AsyncContinuation asyncContinuation, global::System.TimeSpan timeout)
		{
			global::NLog.LogManager.factory.Flush(asyncContinuation, timeout);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00008242 File Offset: 0x00006442
		public static void Flush(global::NLog.Common.AsyncContinuation asyncContinuation, int timeoutMilliseconds)
		{
			global::NLog.LogManager.factory.Flush(asyncContinuation, timeoutMilliseconds);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00008250 File Offset: 0x00006450
		public static global::System.IDisposable DisableLogging()
		{
			return global::NLog.LogManager.factory.SuspendLogging();
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000825C File Offset: 0x0000645C
		public static void EnableLogging()
		{
			global::NLog.LogManager.factory.ResumeLogging();
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00008268 File Offset: 0x00006468
		public static bool IsLoggingEnabled()
		{
			return global::NLog.LogManager.factory.IsLoggingEnabled();
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00008274 File Offset: 0x00006474
		public static void Shutdown()
		{
			global::NLog.LogManager.factory.Shutdown();
		}

		// Token: 0x0400003D RID: 61
		internal static readonly global::NLog.LogFactory factory = new global::NLog.LogFactory();

		// Token: 0x0400003E RID: 62
		private static global::System.Collections.Generic.ICollection<global::System.Reflection.Assembly> _hiddenAssemblies;

		// Token: 0x0400003F RID: 63
		private static readonly object lockObject = new object();

		// Token: 0x020001BF RID: 447
		// (Invoke) Token: 0x060011C4 RID: 4548
		[global::System.Obsolete("Marked obsolete before v4.3.11")]
		public delegate global::System.Globalization.CultureInfo GetCultureInfo();
	}
}
