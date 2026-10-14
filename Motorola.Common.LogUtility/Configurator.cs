using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Xml;
using Motorola.Common.LogUtility.PerformanceMeasurement;

namespace Motorola.Common.LogUtility
{
	// Token: 0x0200000D RID: 13
	public static class Configurator
	{
		// Token: 0x06000068 RID: 104 RVA: 0x0000812C File Offset: 0x0000632C
		public static global::Motorola.Common.LogUtility.ILog GetLogger(string loggerName)
		{
			object obj = global::Motorola.Common.LogUtility.Configurator.s;
			bool flag = false;
			short num;
			global::Motorola.Common.LogUtility.ILog result;
			try
			{
				global::System.Threading.Monitor.Enter(obj, ref flag);
				try
				{
					num = (short)1555955713;
					if (num != 0)
					{
					}
					num = (short)595853313;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_DF;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_70;
							}
							continue;
						case 2:
							goto IL_C3;
						case 3:
							global::Motorola.Common.LogUtility.Configurator.b(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath);
							result = (global::Motorola.Common.LogUtility.Configurator.m[loggerName] as global::Motorola.Common.LogUtility.ILog);
							num = (short)715587586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_70:
						if (global::System.IO.File.Exists(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath))
						{
							num = (short)1938161667;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)655884288;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_C3:
					goto IL_1A2;
					IL_DF:;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(ex);
				}
				result = null;
			}
			finally
			{
				num = (short)1421606914;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_153;
					case 1:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)2009333760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_11F;
						}
						continue;
					}
					IL_11F:
					if (!flag)
					{
						break;
					}
					num = (short)1974599681;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_153:
				num = (short)1692198023;
				short num3 = num;
				num = (short)1381950599;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_153;
				default:
					num = (short)1606680576;
					if (num != 0)
					{
					}
					break;
				}
			}
			IL_1A2:
			num = (short)1198325760;
			short num4 = num;
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00008324 File Offset: 0x00006524
		public static global::Motorola.Common.LogUtility.IAppender GetDefaultAppender()
		{
			int a_ = 10;
			object obj = global::Motorola.Common.LogUtility.Configurator.s;
			bool flag = false;
			short num2;
			global::Motorola.Common.LogUtility.IAppender result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_33;
				}
				int num;
				for (;;)
				{
					IL_1D:
					switch (num)
					{
					case 0:
						goto IL_FA;
					case 1:
						if (global::Motorola.Common.LogUtility.Configurator.n != null)
						{
							num2 = (short)1866727427;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::Motorola.Common.LogUtility.Configurator.n = new global::Motorola.Common.LogUtility.FileAppender();
						global::Motorola.Common.LogUtility.Configurator.n.Name = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᩝ՟ѡգ፥ѧṩ䱫⽭oɱᅳᡵᱷό๻", a_);
						global::Motorola.Common.LogUtility.Configurator.n.FileName = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㩝՟ѡգ፥ѧṩ䉫ɭὯᕱ", a_);
						global::Motorola.Common.LogUtility.Configurator.n.MaxSize = 1;
						global::Motorola.Common.LogUtility.Configurator.n.MaxBackup = 3;
						result = global::Motorola.Common.LogUtility.Configurator.n;
						num2 = (short)1666908160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_87;
					case 3:
						result = global::Motorola.Common.LogUtility.Configurator.n;
						num2 = (short)36044802;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_33;
				}
				IL_87:
				goto IL_1D8;
				IL_FA:
				num2 = (short)2126905345;
				if (num2 != 0)
				{
				}
				goto IL_1D8;
				IL_33:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num2 = (short)732889089;
				num = (int)((global::System.IntPtr)num2);
				goto IL_1D;
			}
			finally
			{
				num2 = (short)1373437954;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_18A;
					case 1:
						global::System.Threading.Monitor.Exit(obj);
						num2 = (short)1802829824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_156;
						}
						continue;
					}
					IL_156:
					if (!flag)
					{
						break;
					}
					num2 = (short)778108929;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_18A:
				num2 = (short)213415951;
				short num3 = num2;
				num2 = (short)1655142415;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_18A;
				default:
					num2 = (short)511705088;
					if (num2 != 0)
					{
					}
					break;
				}
			}
			IL_1D8:
			num2 = (short)509476864;
			short num4 = num2;
			return result;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008554 File Offset: 0x00006754
		public static string GetLogDirectory()
		{
			object obj = global::Motorola.Common.LogUtility.Configurator.s;
			bool flag = false;
			short num2;
			string result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_2A;
				}
				int num;
				for (;;)
				{
					IL_14:
					switch (num)
					{
					case 0:
						goto IL_15B;
					case 1:
						if (!global::Motorola.Common.LogUtility.Configurator.r)
						{
							num2 = (short)1191903235;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_120;
					case 2:
						goto IL_7F;
					case 3:
						try
						{
							global::Motorola.Common.LogUtility.Configurator.b(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath);
							goto IL_120;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(ex);
							goto IL_120;
						}
						goto Block_4;
					}
					goto IL_2A;
					IL_120:
					num2 = (short)1970012162;
					num = (int)((global::System.IntPtr)num2);
					continue;
					Block_4:
					try
					{
						IL_7F:
						num2 = (short)1904148481;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_10D;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_B4;
								}
								continue;
							case 2:
								goto IL_F9;
							case 3:
								global::System.IO.Directory.CreateDirectory(global::Motorola.Common.LogUtility.Configurator.q);
								num2 = (short)1767112706;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_B4:
							if (!global::System.IO.Directory.Exists(global::Motorola.Common.LogUtility.Configurator.q))
							{
								num2 = (short)1085145091;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_F9:
							num2 = (short)1744830464;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_10D:
						goto IL_13D;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(ex2);
						global::Motorola.Common.LogUtility.Configurator.q = global::Motorola.Common.LogUtility.Configurator.BinDir;
						goto IL_13D;
					}
					goto IL_120;
					IL_13D:
					result = global::Motorola.Common.LogUtility.Configurator.q;
					num2 = (short)1480261632;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_15B:
				goto IL_216;
				IL_2A:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num2 = (short)880476161;
				num = (int)((global::System.IntPtr)num2);
				goto IL_14;
			}
			finally
			{
				num2 = (short)1352138754;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_1C6;
					case 1:
						global::System.Threading.Monitor.Exit(obj);
						num2 = (short)248446976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_192;
						}
						continue;
					}
					IL_192:
					if (!flag)
					{
						break;
					}
					num2 = (short)1823539201;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1C6:
				num2 = (short)850194055;
				short num3 = num2;
				num2 = (short)1081470599;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1C6;
				default:
					num2 = (short)2004353024;
					if (num2 != 0)
					{
					}
					break;
				}
			}
			IL_216:
			num2 = (short)1150156801;
			if (num2 != 0)
			{
			}
			num2 = (short)1514471424;
			short num4 = num2;
			return result;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00008814 File Offset: 0x00006A14
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00008964 File Offset: 0x00006B64
		public static string ConfigFilePath
		{
			get
			{
				int a_ = 5;
				short num = (short)750518274;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EE;
					case 1:
					{
						num = (short)34144256;
						short num3 = num;
						num = (short)1209008129;
						if (num != 0)
						{
						}
						global::Motorola.Common.LogUtility.Configurator.t = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("癘᝚㉜㡞٠٢ᝤ⑦٨ժ୬ٮᙰ嵲൴᩶ᕸ", a_);
						num = (short)1877344256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3A;
						}
						continue;
					}
					IL_3A:
					if (!string.IsNullOrEmpty(global::Motorola.Common.LogUtility.Configurator.t))
					{
						break;
					}
					num = (short)972685313;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EE:
				num = (short)1796528222;
				short num4 = num;
				num = (short)1262868574;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_EE;
				default:
					num = (short)1451556864;
					if (num != 0)
					{
					}
					return global::Motorola.Common.LogUtility.Configurator.t;
				}
			}
			set
			{
				short num = (short)1589466088;
				short num2 = num;
				num = (short)1513247720;
				switch (num2 == num)
				{
				}
				num = (short)107020288;
				short num3 = num;
				num = (short)540475393;
				if (num != 0)
				{
				}
				num = (short)1494351872;
				if (num != 0)
				{
				}
				global::Motorola.Common.LogUtility.Configurator.t = value;
				global::Motorola.Common.LogUtility.Configurator.p = false;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008A1C File Offset: 0x00006C1C
		public static void UpdateLogDirectoryInMemory(string path)
		{
			short num;
			for (;;)
			{
				global::Motorola.Common.LogUtility.Configurator.r = true;
				if (!global::System.IO.Directory.Exists(path))
				{
					break;
				}
				num = (short)1825243136;
				short num2 = num;
				num = (short)70655011;
				short num3 = num;
				num = (short)2103188515;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6F;
				}
			}
			return;
			IL_6F:
			num = (short)1953103873;
			if (num != 0)
			{
			}
			num = (short)490471424;
			if (num != 0)
			{
			}
			global::Motorola.Common.LogUtility.Configurator.a(path);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008ADC File Offset: 0x00006CDC
		public static void SetLogDirectory(string path)
		{
			int a_ = 9;
			object obj = global::Motorola.Common.LogUtility.Configurator.s;
			bool flag = false;
			short num2;
			try
			{
				global::System.Threading.Monitor.Enter(obj, ref flag);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					int num;
					for (;;)
					{
						IL_27:
						switch (num)
						{
						case 0:
							num2 = (short)113049606;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							num2 = (short)1132134403;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							goto IL_148;
						case 3:
							goto IL_B6;
						case 4:
							if (!global::System.IO.Directory.Exists(path))
							{
								num2 = (short)98697216;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1104412677;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 5:
							if (global::Motorola.Common.LogUtility.Configurator.o == null)
							{
								num2 = (short)1092419585;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							global::Motorola.Common.LogUtility.Configurator.o.SelectSingleNode(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("牜灞٠ར੤զࡨݪ䉬୮ᡰŲၴᑶ൸ᑺོپ", a_)).InnerText = path;
							global::Motorola.Common.LogUtility.Configurator.o.Save(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath);
							global::Motorola.Common.LogUtility.Configurator.p = false;
							global::Motorola.Common.LogUtility.Configurator.b(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath);
							num2 = (short)1736441858;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 6:
							goto IL_9A;
						}
						goto IL_49;
					}
					IL_9A:
					IL_B6:
					IL_148:
					goto IL_231;
					IL_49:
					global::Motorola.Common.LogUtility.Configurator.b(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath);
					num2 = (short)1609302020;
					num = (int)((global::System.IntPtr)num2);
					goto IL_27;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(ex);
				}
			}
			finally
			{
				num2 = (short)1371209730;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_1BB;
					case 1:
						global::System.Threading.Monitor.Exit(obj);
						num2 = (short)1143799808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_187;
						}
						continue;
					}
					IL_187:
					if (!flag)
					{
						break;
					}
					num2 = (short)433717249;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1BB:
				num2 = (short)207759268;
				short num3 = num2;
				num2 = (short)1180313508;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1BB;
				default:
					num2 = (short)1846542337;
					if (num2 != 0)
					{
					}
					num2 = (short)1820196864;
					if (num2 != 0)
					{
					}
					break;
				}
			}
			IL_231:
			num2 = (short)729088000;
			short num4 = num2;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00008D78 File Offset: 0x00006F78
		private static void b(string A_0)
		{
			int a_ = 12;
			short num = (short)1817247748;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1528081925;
				short num3 = num;
				num = (short)505916933;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1F2;
				case 1:
					break;
				default:
				{
					num = (short)1283850240;
					short num4 = num;
					break;
				}
				}
				num = (short)636747776;
				if (num != 0)
				{
				}
				global::System.Xml.XmlNode xmlNode;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					num = (short)1427111942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					num = (short)76218369;
					if (num != 0)
					{
					}
					goto IL_1F2;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_BF;
					}
					continue;
				case 5:
					if (xmlNode != null)
					{
						num = (short)2084700161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					if (!global::Motorola.Common.LogUtility.Configurator.r)
					{
						num = (short)202964995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_BF:
				if (global::Motorola.Common.LogUtility.Configurator.p)
				{
					num = (short)310444032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::Motorola.Common.LogUtility.Configurator.p = true;
				global::Motorola.Common.LogUtility.Configurator.o = new global::System.Xml.XmlDocument();
				global::Motorola.Common.LogUtility.Configurator.o.Load(A_0);
				global::Motorola.Common.LogUtility.Configurator.b(global::Motorola.Common.LogUtility.Configurator.o.SelectNodes(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("佟䵡գᙥᡧཀྵɫ੭ᕯq", a_)));
				global::Motorola.Common.LogUtility.Configurator.a(global::Motorola.Common.LogUtility.Configurator.o.SelectNodes(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("佟䵡ࡣ॥ཧ൩५ᱭ", a_)));
				xmlNode = global::Motorola.Common.LogUtility.Configurator.o.SelectSingleNode(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("佟䵡ͣ੥ݧࡩ൫ɭ彯ᙱᵳѵᵷ᥹ࡻᅽﮁ", a_));
				num = (short)475004933;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F2:
				global::Motorola.Common.LogUtility.Configurator.a(xmlNode.InnerText);
				num = (short)429719554;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008F9C File Offset: 0x0000719C
		private static void a(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_FA;
				case 2:
				{
					num2 = (short)1572045514;
					short num3 = num2;
					num2 = (short)1333494474;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FA;
					default:
					{
						num2 = (short)407830529;
						if (num2 != 0)
						{
						}
						num2 = (short)179765248;
						if (num2 != 0)
						{
						}
						num2 = (short)632815616;
						short num4 = num2;
						if (!global::System.IO.Path.IsPathRooted(global::Motorola.Common.LogUtility.Configurator.q))
						{
							num2 = (short)247922689;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					break;
				}
				}
				goto IL_1C;
				IL_FA:
				global::Motorola.Common.LogUtility.Configurator.q = global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(global::Motorola.Common.LogUtility.Configurator.BinDir, global::Motorola.Common.LogUtility.Configurator.q));
				num2 = (short)46006272;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			global::Motorola.Common.LogUtility.Configurator.q = global::System.Environment.ExpandEnvironmentVariables(A_0);
			num2 = (short)488636418;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000090D8 File Offset: 0x000072D8
		private static void b(global::System.Xml.XmlNodeList A_0)
		{
			int a_ = 10;
			short num = (short)509280256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1114898433;
				if (num != 0)
				{
				}
				global::System.Collections.IEnumerator enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)1116340226;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)401735686;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
							global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("そşཡţ", a_)];
							num = (short)2048327690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::Motorola.Common.LogUtility.IAppender appender;
							try
							{
								num = (short)958988302;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Reflection.PropertyInfo property;
									object value;
									switch (num2)
									{
									case 0:
									{
										global::System.Xml.XmlAttribute xmlAttribute2;
										property = appender.GetType().GetProperty(xmlAttribute2.Value);
										num = (short)1140785173;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_2FA;
									case 2:
									{
										value = null;
										global::System.TypeCode typeCode = global::System.Type.GetTypeCode(property.PropertyType);
										num = (short)166985734;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_2FA;
									case 4:
										goto IL_2FA;
									case 6:
									{
										global::System.TypeCode typeCode;
										switch (typeCode)
										{
										case global::System.TypeCode.Empty:
										case global::System.TypeCode.Object:
										case global::System.TypeCode.DBNull:
										case (global::System.TypeCode)17:
											goto IL_2FA;
										case global::System.TypeCode.Boolean:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = bool.Parse(xmlAttribute3.Value);
											num = (short)18350098;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.Char:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = char.Parse(xmlAttribute3.Value);
											num = (short)59506703;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.SByte:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = sbyte.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)457310236;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.Byte:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = byte.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)1231814672;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.Int16:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = short.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)1438187537;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.UInt16:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = ushort.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)31391770;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.Int32:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = int.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)492699673;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.UInt32:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = uint.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)1993670659;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.Int64:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = long.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)1434845208;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.UInt64:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = ulong.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)1955397641;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.Single:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = float.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)1954807812;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.Double:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = double.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)879427597;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.Decimal:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = decimal.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)2118451212;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.DateTime:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = global::System.DateTime.Parse(xmlAttribute3.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											num = (short)1167786006;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case global::System.TypeCode.String:
										{
											global::System.Xml.XmlAttribute xmlAttribute3;
											value = xmlAttribute3.Value;
											num = (short)485097473;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										default:
											num = (short)730005531;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
									{
										global::System.Collections.IEnumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1448804375;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator2.Current;
										global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode2.Attributes[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("そşཡţ", a_)];
										num = (short)1286930443;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										goto IL_76B;
									case 9:
										goto IL_2FA;
									case 10:
									{
										global::System.Xml.XmlAttribute xmlAttribute3;
										if (xmlAttribute3 != null)
										{
											num = (short)1397620736;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 11:
									{
										global::System.Xml.XmlAttribute xmlAttribute2;
										if (xmlAttribute2 != null)
										{
											num = (short)1936719892;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 12:
										goto IL_2FA;
									case 13:
										goto IL_2FA;
									case 14:
										switch (0)
										{
										case 0:
											goto IL_20B;
										}
										continue;
									case 15:
										goto IL_2FA;
									case 16:
										goto IL_2FA;
									case 17:
										goto IL_2FA;
									case 18:
										goto IL_2FA;
									case 19:
										goto IL_2FA;
									case 20:
									{
										global::System.Xml.XmlNode xmlNode2;
										global::System.Xml.XmlAttribute xmlAttribute3 = xmlNode2.Attributes[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⡝ş๡ᅣͥ", a_)];
										num = (short)305070090;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 21:
										if (!(property == null))
										{
											num = (short)541261826;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 22:
										goto IL_2FA;
									case 23:
										num = (short)882704392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 24:
										goto IL_2FA;
									case 25:
										goto IL_2FA;
									case 26:
										goto IL_2FA;
									case 27:
										num = (short)364249107;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 28:
										goto IL_2FA;
									}
									goto IL_20B;
									IL_2FA:
									property.SetValue(appender, value, null);
									num = (short)748224517;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_6A7:
									num = (short)820379655;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_20B:
									goto IL_6A7;
								}
								IL_76B:
								goto IL_E8;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_78D;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_77A:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)643956738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (disposable != null)
										{
											num = (short)1668743168;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_7E4;
									case 2:
										goto IL_7E2;
									}
									goto IL_78D;
								}
								IL_7E2:
								IL_7E4:
								break;
								IL_78D:
								global::System.Collections.IEnumerator enumerator2;
								disposable = (enumerator2 as global::System.IDisposable);
								num = (short)1870659585;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_77A;
							}
							break;
							IL_E8:
							global::System.Xml.XmlAttribute xmlAttribute;
							global::Motorola.Common.LogUtility.Configurator.l[xmlAttribute.Value] = appender;
							num = (short)433651720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A9;
							}
							continue;
						case 3:
						{
							global::System.Xml.XmlAttribute xmlAttribute4;
							if (xmlAttribute4 != null)
							{
								num = (short)1603469321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_A1C;
						case 5:
						{
							global::Motorola.Common.LogUtility.IAppender appender;
							try
							{
								switch (0)
								{
								case 0:
									goto IL_8FE;
								}
								global::System.Reflection.Assembly assembly;
								for (;;)
								{
									IL_8DB:
									switch (num2)
									{
									case 0:
										if (!appender.IsEnabled)
										{
											num = (short)1642594310;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)195821571;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Xml.XmlAttribute xmlAttribute5;
										if (xmlAttribute5 != null)
										{
											num = (short)1527578628;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_971;
									}
									case 2:
										goto IL_9DA;
									case 3:
										goto IL_9F8;
									case 4:
									{
										global::System.Xml.XmlAttribute xmlAttribute5;
										assembly = global::System.Reflection.Assembly.LoadFile(global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(assembly.Location), xmlAttribute5.Value));
										num = (short)1511391237;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_971;
									case 6:
										num = (short)1552941058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8FE;
									IL_971:
									global::System.Xml.XmlAttribute xmlAttribute4;
									appender = (assembly.CreateInstance(xmlAttribute4.Value) as global::Motorola.Common.LogUtility.IAppender);
									num = (short)1555431424;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_9DA:
								break;
								IL_9F8:
								goto IL_88B;
								IL_8FE:
								assembly = global::System.Reflection.Assembly.GetCallingAssembly();
								num = (short)2111832065;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_8DB;
							}
							catch (global::System.Exception)
							{
								break;
							}
							goto IL_A03;
							IL_88B:
							global::System.Xml.XmlAttribute xmlAttribute;
							appender.Name = xmlAttribute.Value;
							global::System.Xml.XmlNode xmlNode;
							global::System.Collections.IEnumerator enumerator2 = xmlNode.SelectNodes(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("灝佟ቡգᑥ१ݩ", a_)).GetEnumerator();
							num = (short)1639120897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_A03;
						case 7:
						{
							global::System.Xml.XmlNode xmlNode;
							global::System.Xml.XmlAttribute xmlAttribute4 = xmlNode.Attributes[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⩝ᥟቡţ", a_)];
							num = (short)897515523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::System.Xml.XmlNode xmlNode;
							global::System.Xml.XmlAttribute xmlAttribute5 = xmlNode.Attributes[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㽝፟ᅡţ୥੧٩ᕫ", a_)];
							global::Motorola.Common.LogUtility.IAppender appender = null;
							num = (short)1179713541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							global::System.Xml.XmlAttribute xmlAttribute;
							if (xmlAttribute != null)
							{
								num = (short)1687748615;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_7E5:
						num = (short)1231552512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A9:
						goto IL_7E5;
						IL_A03:
						num = (short)1237647364;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_A1C:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_A3E;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_A2B:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)698220546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (disposable == null)
							{
								goto IL_AE8;
							}
							num = (short)1900824131;
							short num3 = num;
							num = (short)1002980931;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_AE6;
							default:
								num = (short)2034565120;
								if (num != 0)
								{
								}
								num = (short)234487808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_AE6;
						}
						goto IL_A3E;
					}
					IL_AE6:
					IL_AE8:
					goto EndFinally_20;
					IL_A3E:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1761345537;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_A2B;
					EndFinally_20:;
				}
				num = (short)713228288;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00009C48 File Offset: 0x00007E48
		private static void a(global::System.Xml.XmlNodeList A_0)
		{
			int a_ = 10;
			short num = (short)410124289;
			if (num != 0)
			{
			}
			num = (short)173670400;
			short num2 = num;
			num = (short)1310851072;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)926351370;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Xml.XmlAttribute xmlAttribute;
						global::Motorola.Common.LogUtility.LogImpl logImpl;
						switch (num3)
						{
						case 0:
							if (xmlAttribute != null)
							{
								num = (short)688979971;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
						{
							try
							{
								num = (short)1486553095;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.Common.LogUtility.IAppender appender;
									switch (num3)
									{
									case 0:
									{
										global::System.Collections.IEnumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)11730945;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator2.Current;
										appender = (global::Motorola.Common.LogUtility.Configurator.l[xmlNode.Value] as global::Motorola.Common.LogUtility.IAppender);
										num = (short)840564742;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)1921056771;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_21B;
									case 4:
										goto IL_19F;
									case 5:
										appender = global::Motorola.Common.LogUtility.Configurator.GetDefaultAppender();
										num = (short)645332996;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										if (appender == null)
										{
											num = (short)117374981;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_19F;
									case 7:
										switch (0)
										{
										case 0:
											goto IL_11C;
										}
										continue;
									}
									goto IL_11C;
									IL_19F:
									logImpl.AddAppender(appender);
									num = (short)671088642;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1C2:
									num = (short)1619460096;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_11C:
									goto IL_1C2;
								}
								IL_21B:
								goto IL_39E;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_23D;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_22A:
									switch (num3)
									{
									case 0:
									{
										num = (short)1988799880;
										short num4 = num;
										num = (short)474000776;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)1647378432;
											if (num != 0)
											{
											}
											disposable.Dispose();
											num = (short)140378113;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										goto IL_2E3;
									case 2:
										if (disposable != null)
										{
											num = (short)1254162432;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2E5;
									}
									goto IL_23D;
								}
								IL_2E3:
								IL_2E5:
								goto EndFinally_14;
								IL_23D:
								global::System.Collections.IEnumerator enumerator2;
								disposable = (enumerator2 as global::System.IDisposable);
								num = (short)763625474;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_22A;
								EndFinally_14:;
							}
							goto IL_2E6;
							IL_39E:
							global::System.Xml.XmlNode xmlNode2 = global::Motorola.Common.LogUtility.Configurator.o.SelectSingleNode(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("煝佟աࡣ॥੧୩k䅭ᱯ᝱ɳ፵ᑷ", a_));
							num = (short)199360519;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_4C9;
						case 3:
						{
							logImpl = new global::Motorola.Common.LogUtility.LogImpl();
							logImpl.Name = xmlAttribute.Value;
							global::System.Xml.XmlNode xmlNode3;
							global::System.Collections.IEnumerator enumerator2 = xmlNode3.SelectNodes(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㽝ၟቡţࡥ౧ཀྵṫ䍭ɯ᝱ታ奵㡷ࡹ᥻᡽", a_)).GetEnumerator();
							num = (short)969867265;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1578958856;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode3 = (global::System.Xml.XmlNode)enumerator.Current;
							xmlAttribute = xmlNode3.Attributes[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("そşཡţ", a_)];
							num = (short)1704919040;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							try
							{
								global::System.Xml.XmlNode xmlNode2;
								logImpl.Level = (global::Motorola.Common.LogUtility.LoggingLevel)global::System.Enum.Parse(typeof(global::Motorola.Common.LogUtility.LoggingLevel), xmlNode2.InnerText, true);
								goto IL_2E6;
							}
							catch (global::System.Exception)
							{
								logImpl.Level = global::Motorola.Common.LogUtility.LoggingLevel.Error;
								goto IL_2E6;
							}
							goto IL_4B1;
						case 6:
							goto IL_2E6;
						case 7:
						{
							global::System.Xml.XmlNode xmlNode2;
							if (xmlNode2 != null)
							{
								num = (short)2085027845;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							logImpl.Level = global::Motorola.Common.LogUtility.LoggingLevel.Error;
							num = (short)629014534;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_4B1;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_D0;
							}
							continue;
						}
						goto IL_D0;
						IL_2E6:
						global::Motorola.Common.LogUtility.Configurator.m[xmlAttribute.Value] = logImpl;
						num = (short)980287497;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_35C:
						num = (short)913309700;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D0:
						goto IL_35C;
						IL_4B1:
						num = (short)174391298;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_4C9:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_4E8;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_4D5:
						switch (num3)
						{
						case 0:
							disposable.Dispose();
							num = (short)1438646273;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_53D;
						case 2:
							if (disposable != null)
							{
								num = (short)2621440;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_53F;
						}
						goto IL_4E8;
					}
					IL_53D:
					IL_53F:
					goto EndFinally_15;
					IL_4E8:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1020854274;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_4D5;
					EndFinally_15:;
				}
				return;
			}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000A1E4 File Offset: 0x000083E4
		private static string BinDir
		{
			get
			{
				global::System.Reflection.Assembly executingAssembly = global::System.Reflection.Assembly.GetExecutingAssembly();
				if (executingAssembly != null)
				{
					short num = (short)1237394708;
					short num2 = num;
					num = (short)1358308628;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)452919297;
						if (num != 0)
						{
						}
						num = (short)1020919808;
						if (num != 0)
						{
						}
						num = (short)1011941376;
						short num3 = num;
						break;
					}
					}
					return global::System.IO.Path.GetDirectoryName(executingAssembly.Location);
				}
				return global::System.Diagnostics.Process.GetCurrentProcess().StartInfo.WorkingDirectory;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000A2BC File Offset: 0x000084BC
		// Note: this type is marked as 'beforefieldinit'.
		static Configurator()
		{
			short num = (short)938076316;
			short num2 = num;
			num = (short)1472063644;
			switch (num2 == num)
			{
			}
			num = (short)1694892033;
			if (num != 0)
			{
			}
			num = (short)2095972352;
			short num3 = num;
			num = (short)37945344;
			if (num != 0)
			{
			}
			global::Motorola.Common.LogUtility.Configurator.l = new global::System.Collections.Hashtable();
			global::Motorola.Common.LogUtility.Configurator.m = new global::System.Collections.Hashtable();
			global::Motorola.Common.LogUtility.Configurator.n = null;
			global::Motorola.Common.LogUtility.Configurator.o = null;
			global::Motorola.Common.LogUtility.Configurator.p = false;
			global::Motorola.Common.LogUtility.Configurator.q = global::Motorola.Common.LogUtility.Configurator.BinDir;
			global::Motorola.Common.LogUtility.Configurator.r = false;
			global::Motorola.Common.LogUtility.Configurator.s = new object();
			global::Motorola.Common.LogUtility.Configurator.t = string.Empty;
		}

		// Token: 0x0400002D RID: 45
		private const string a = "param";

		// Token: 0x0400002E RID: 46
		private const string b = "appender-ref";

		// Token: 0x0400002F RID: 47
		private const string c = "name";

		// Token: 0x04000030 RID: 48
		private const string d = "type";

		// Token: 0x04000031 RID: 49
		private const string e = "value";

		// Token: 0x04000032 RID: 50
		private const string f = "ref";

		// Token: 0x04000033 RID: 51
		private const string g = "assembly";

		// Token: 0x04000034 RID: 52
		private const string h = "//appender";

		// Token: 0x04000035 RID: 53
		private const string i = "//logger";

		// Token: 0x04000036 RID: 54
		private const string j = "//global/directory";

		// Token: 0x04000037 RID: 55
		private const string k = "//global/level";

		// Token: 0x04000038 RID: 56
		private static global::System.Collections.Hashtable l;

		// Token: 0x04000039 RID: 57
		private static global::System.Collections.Hashtable m;

		// Token: 0x0400003A RID: 58
		private static global::Motorola.Common.LogUtility.FileAppender n;

		// Token: 0x0400003B RID: 59
		private static global::System.Xml.XmlDocument o;

		// Token: 0x0400003C RID: 60
		private static bool p;

		// Token: 0x0400003D RID: 61
		private static string q;

		// Token: 0x0400003E RID: 62
		private static bool r;

		// Token: 0x0400003F RID: 63
		private static readonly object s;

		// Token: 0x04000040 RID: 64
		private static string t;
	}
}
