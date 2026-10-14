using System;
using NLog.Targets;

namespace NLog.Config
{
	// Token: 0x02000170 RID: 368
	public static class SimpleConfigurator
	{
		// Token: 0x06001000 RID: 4096 RVA: 0x000296E9 File Offset: 0x000278E9
		public static void ConfigureForConsoleLogging()
		{
			global::NLog.Config.SimpleConfigurator.ConfigureForConsoleLogging(global::NLog.LogLevel.Info);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x000296F8 File Offset: 0x000278F8
		public static void ConfigureForConsoleLogging(global::NLog.LogLevel minLevel)
		{
			global::NLog.Targets.ConsoleTarget target = new global::NLog.Targets.ConsoleTarget();
			global::NLog.Config.LoggingConfiguration loggingConfiguration = new global::NLog.Config.LoggingConfiguration();
			loggingConfiguration.AddRule(minLevel, global::NLog.LogLevel.MaxLevel, target, "*");
			global::NLog.LogManager.Configuration = loggingConfiguration;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00029727 File Offset: 0x00027927
		public static void ConfigureForTargetLogging(global::NLog.Targets.Target target)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			global::NLog.Config.SimpleConfigurator.ConfigureForTargetLogging(target, global::NLog.LogLevel.Info);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00029742 File Offset: 0x00027942
		public static void ConfigureForTargetLogging(global::NLog.Targets.Target target, global::NLog.LogLevel minLevel)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			global::NLog.Config.LoggingConfiguration loggingConfiguration = new global::NLog.Config.LoggingConfiguration();
			loggingConfiguration.AddRule(minLevel, global::NLog.LogLevel.MaxLevel, target, "*");
			global::NLog.LogManager.Configuration = loggingConfiguration;
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0002976E File Offset: 0x0002796E
		public static void ConfigureForFileLogging(string fileName)
		{
			global::NLog.Config.SimpleConfigurator.ConfigureForFileLogging(fileName, global::NLog.LogLevel.Info);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0002977B File Offset: 0x0002797B
		public static void ConfigureForFileLogging(string fileName, global::NLog.LogLevel minLevel)
		{
			global::NLog.Config.SimpleConfigurator.ConfigureForTargetLogging(new global::NLog.Targets.FileTarget
			{
				FileName = fileName
			}, minLevel);
		}
	}
}
