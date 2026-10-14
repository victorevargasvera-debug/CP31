using System;
using System.Threading;
using Motorola.Common.LogUtility.PerformanceMeasurement;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000015 RID: 21
	public static class LogManager
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x0000ED60 File Offset: 0x0000CF60
		public static global::Motorola.Common.LogUtility.ILog GetLogger(string loggerName)
		{
			short num = (short)1842697103;
			short num2 = num;
			num = (short)2042712975;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_70:
				num = (short)358875138;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2135425024;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_69;
				}
				break;
			}
			global::Motorola.Common.LogUtility.ILog log;
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)74448896;
					short num4 = num;
					log = global::Motorola.Common.LogUtility.LogManager.a();
					num = (short)1944780801;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return log;
				case 2:
					if (log == null)
					{
						num = (short)711131137;
						if (num != 0)
						{
						}
						num = (short)956563456;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return log;
				}
				goto IL_69;
			}
			return log;
			IL_69:
			log = global::Motorola.Common.LogUtility.Configurator.GetLogger(loggerName);
			goto IL_70;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000EE80 File Offset: 0x0000D080
		public static string DefaultLoggerName
		{
			get
			{
				int a_ = 0;
				short num = (short)789241592;
				short num2 = num;
				num = (short)1289346808;
				switch (num2 == num)
				{
				}
				num = (short)1625554945;
				if (num != 0)
				{
				}
				num = (short)1069940736;
				short num3 = num;
				num = (short)1881014272;
				if (num != 0)
				{
				}
				return global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ၓ㍕㹗㭙⥛㉝ᑟ䉡⡣॥ཧ൩५ᱭ", a_);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000EF44 File Offset: 0x0000D144
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
		public static string LogDirectory
		{
			get
			{
				short num = (short)1686546839;
				short num2 = num;
				num = (short)1538173335;
				switch (num2 == num)
				{
				}
				num = (short)1550712833;
				if (num != 0)
				{
				}
				num = (short)503119872;
				short num3 = num;
				num = (short)1559953408;
				if (num != 0)
				{
				}
				return global::Motorola.Common.LogUtility.Configurator.GetLogDirectory();
			}
			set
			{
				short num = (short)817872793;
				short num2 = num;
				num = (short)1012711321;
				switch (num2 == num)
				{
				}
				num = (short)395378689;
				if (num != 0)
				{
				}
				num = (short)799145984;
				short num3 = num;
				num = (short)1868300288;
				if (num != 0)
				{
				}
				global::Motorola.Common.LogUtility.Configurator.SetLogDirectory(value);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		public static void UpdateLogDirectoryInMemory(string path)
		{
			short num = (short)1258684417;
			if (num != 0)
			{
			}
			num = (short)523895910;
			short num2 = num;
			num = (short)159712358;
			switch (num2 == num)
			{
			}
			num = (short)49414144;
			short num3 = num;
			num = (short)884473856;
			if (num != 0)
			{
			}
			global::Motorola.Common.LogUtility.Configurator.UpdateLogDirectoryInMemory(path);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000F154 File Offset: 0x0000D354
		public static global::System.DateTime LoggerLaunchTime
		{
			get
			{
				short num = (short)1891802412;
				short num2 = num;
				num = (short)1402051884;
				switch (num2 == num)
				{
				}
				num = (short)224460801;
				if (num != 0)
				{
				}
				num = (short)978518016;
				short num3 = num;
				num = (short)1030750208;
				if (num != 0)
				{
				}
				return global::Motorola.Common.LogUtility.LogManager.c;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000F204 File Offset: 0x0000D404
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000F2B4 File Offset: 0x0000D4B4
		public static string ConfigFilePath
		{
			get
			{
				short num = (short)1622147073;
				if (num != 0)
				{
				}
				num = (short)1898462675;
				short num2 = num;
				num = (short)1180646867;
				switch (num2 == num)
				{
				}
				num = (short)1469251584;
				short num3 = num;
				num = (short)719388672;
				if (num != 0)
				{
				}
				return global::Motorola.Common.LogUtility.Configurator.ConfigFilePath;
			}
			set
			{
				short num = (short)1964161037;
				short num2 = num;
				num = (short)989902861;
				switch (num2 == num)
				{
				}
				num = (short)1227554817;
				if (num != 0)
				{
				}
				num = (short)1488781312;
				short num3 = num;
				num = (short)1555890176;
				if (num != 0)
				{
				}
				global::Motorola.Common.LogUtility.Configurator.ConfigFilePath = value;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000F364 File Offset: 0x0000D564
		private static global::Motorola.Common.LogUtility.ILog a()
		{
			object obj = global::Motorola.Common.LogUtility.LogManager.b;
			bool flag = false;
			short num;
			global::Motorola.Common.LogUtility.ILog result;
			try
			{
				num = (short)1388469260;
				short num2 = num;
				num = (short)46816268;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_B4:
					num = (short)1384382465;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)519176192;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_75;
					}
					break;
				}
				for (;;)
				{
					IL_5F:
					switch (num3)
					{
					case 0:
						goto IL_AC;
					case 1:
						goto IL_C9;
					case 2:
						goto IL_11F;
					case 3:
						if (global::Motorola.Common.LogUtility.LogManager.a != null)
						{
							num = (short)925564928;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.LogUtility.LogManager.a = new global::Motorola.Common.LogUtility.LogImpl();
						global::Motorola.Common.LogUtility.LogManager.a.Name = global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName;
						global::Motorola.Common.LogUtility.LogManager.a.Level = global::Motorola.Common.LogUtility.LoggingLevel.Error;
						global::Motorola.Common.LogUtility.LogManager.a.AddAppender(global::Motorola.Common.LogUtility.Configurator.GetDefaultAppender());
						result = global::Motorola.Common.LogUtility.LogManager.a;
						num = (short)369164290;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75;
				}
				IL_AC:
				result = global::Motorola.Common.LogUtility.LogManager.a;
				goto IL_B4;
				IL_C9:
				IL_11F:
				goto IL_188;
				IL_75:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)200343555;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5F;
			}
			finally
			{
				num = (short)764674050;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)1961230337;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_185;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_152;
						}
						continue;
					}
					IL_152:
					if (!flag)
					{
						break;
					}
					num = (short)821428224;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_185:;
			}
			IL_188:
			num = (short)1516634112;
			short num4 = num;
			num = (short)381485057;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000F568 File Offset: 0x0000D768
		// Note: this type is marked as 'beforefieldinit'.
		static LogManager()
		{
			short num = (short)488964097;
			if (num != 0)
			{
			}
			num = (short)258719909;
			short num2 = num;
			num = (short)1433583781;
			switch (num2 == num)
			{
			}
			num = (short)842924032;
			if (num != 0)
			{
			}
			num = (short)1279000576;
			short num3 = num;
			global::Motorola.Common.LogUtility.LogManager.a = null;
			global::Motorola.Common.LogUtility.LogManager.b = new object();
			global::Motorola.Common.LogUtility.LogManager.c = global::System.DateTime.Now;
		}

		// Token: 0x0400005E RID: 94
		private static global::Motorola.Common.LogUtility.LogImpl a;

		// Token: 0x0400005F RID: 95
		private static readonly object b;

		// Token: 0x04000060 RID: 96
		private static global::System.DateTime c;

		// Token: 0x04000061 RID: 97
		private const string d = "Default Logger";
	}
}
