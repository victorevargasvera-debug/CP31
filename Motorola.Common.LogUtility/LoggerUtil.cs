using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using NLog;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000011 RID: 17
	public static class LoggerUtil
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0000A684 File Offset: 0x00008884
		public static global::NLog.LogLevel ConvertLoggingLevelToNLogLevel(global::Motorola.Common.LogUtility.LoggingLevel loggingLevel)
		{
			global::NLog.LogLevel result = global::NLog.LogLevel.Info;
			short num;
			try
			{
				num = (short)427556871;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_179;
					case 1:
						goto IL_179;
					case 2:
						goto IL_179;
					case 3:
						goto IL_191;
					case 4:
						goto IL_179;
					case 5:
						goto IL_179;
					case 6:
						num = (short)1961033730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_4D;
						}
						continue;
					}
					IL_4D:
					num = (short)524349488;
					short num3 = num;
					num = (short)17362992;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)942866432;
						if (num != 0)
						{
						}
						switch (loggingLevel)
						{
						case global::Motorola.Common.LogUtility.LoggingLevel.Unknown:
						case global::Motorola.Common.LogUtility.LoggingLevel.UserOperation:
						case global::Motorola.Common.LogUtility.LoggingLevel.Performance:
						case global::Motorola.Common.LogUtility.LoggingLevel.EventInfo:
							result = global::NLog.LogLevel.Info;
							break;
						case global::Motorola.Common.LogUtility.LoggingLevel.EventDetail:
						case global::Motorola.Common.LogUtility.LoggingLevel.Info:
							goto IL_179;
						case global::Motorola.Common.LogUtility.LoggingLevel.EventWarning:
							result = global::NLog.LogLevel.Warn;
							num = (short)1896873988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.LogUtility.LoggingLevel.EventError:
						case global::Motorola.Common.LogUtility.LoggingLevel.Error:
							result = global::NLog.LogLevel.Error;
							num = (short)1999962113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.LogUtility.LoggingLevel.Debug:
							result = global::NLog.LogLevel.Trace;
							num = (short)1971257344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)421855238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					num = (short)319160325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_179:
					num = (short)846725123;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_191:;
			}
			catch
			{
			}
			num = (short)1268580352;
			short num4 = num;
			num = (short)432603137;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000A898 File Offset: 0x00008A98
		public static string ExportExceptionInfo(global::System.Exception e)
		{
			int a_ = 0;
			short num = (short)1196294149;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				global::Motorola.Common.CustomException.CommonException ex;
				switch (num2)
				{
				case 0:
					goto IL_19B;
				case 1:
					if (e.InnerException != null)
					{
						num = (short)1567096836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_256;
				case 2:
					stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᅓ⑕⩗㕙⹛᝝⑟塡䑣ᵥ塧ᝩ慫摭", a_), (ex != null) ? ex.ErrorCode.ToString() : global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("œ㡕㍗㑙㍛⥝๟", a_));
					stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᥓ㍕⭗⥙㵛㥝՟塡䑣ᵥ塧ᝩ慫摭", a_), e.Message);
					stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ݓ㥕ⵗ⡙㽛㭝婟䉡ὣ噥ᕧ杩晫", a_), e.Source);
					stringBuilder.Append(e.StackTrace);
					num = (short)1152647169;
					if (num != 0)
					{
					}
					num = (short)1229914113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)849501273;
					short num3 = num;
					num = (short)1621711961;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_71;
					default:
						goto IL_BC;
					}
					break;
				}
				case 4:
					stringBuilder.AppendLine(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("奓展啗偙ݛ᝝๟ౡţᑥⵧቩཫ୭oٱᵳ᥵ᙷ❹", a_));
					stringBuilder.Append(global::Motorola.Common.LogUtility.LoggerUtil.ExportExceptionInfo(e.InnerException));
					num = (short)1455751168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				goto IL_45;
				IL_71:
				num = (short)400818179;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45:
				num = (short)291438592;
				short num4 = num;
				if (e == null)
				{
					goto IL_71;
				}
				stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᅓ⹕㭗㽙ⱛ⩝य़ൡ੣履䡧ᅩ屫፭絯硱", a_), e.GetType());
				ex = (e as global::Motorola.Common.CustomException.CommonException);
				num = (short)1775370242;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BC:
			num = (short)1929117696;
			if (num != 0)
			{
			}
			return string.Empty;
			IL_19B:
			IL_256:
			return stringBuilder.ToString();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000AB04 File Offset: 0x00008D04
		public static string DateString(global::System.DateTime dt)
		{
			int a_ = 16;
			short num = (short)227934209;
			if (num != 0)
			{
			}
			num = (short)1947950366;
			short num2 = num;
			num = (short)1424252190;
			switch (num2 == num)
			{
			}
			num = (short)851902464;
			short num3 = num;
			num = (short)2054488064;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ὣ噥ᕧ䝩ᝫ彭䩯㙱䙳୵啷Ź乻䑽쑿낁旅ꚅ릉뚋쪍ꊏ꺓겗ꂙ\ud89b겝\udd9f颡\udfa3鎥銧麫펭邯즱芳貵ﲷ覹솻", a_), new object[]
			{
				dt.Year,
				dt.Month,
				dt.Day,
				dt.Hour,
				dt.Minute,
				dt.Second,
				dt.Millisecond
			});
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000AC3C File Offset: 0x00008E3C
		public static string DateStringWithoutMillisecond(global::System.DateTime dt)
		{
			int a_ = 1;
			short num = (short)119586430;
			short num2 = num;
			num = (short)12107390;
			switch (num2 == num)
			{
			}
			num = (short)1840185344;
			if (num != 0)
			{
			}
			num = (short)572129280;
			short num3 = num;
			num = (short)1001717761;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⹔杖⑘癚♜湞孠❢坤ᩦ䑨ၪ彬啮㕰䅲ࡴ坶ɸ䡺䝼㭾뎀ﺂ뾄ﲆ불놊즌붎ꦒꊖꎘ\udf9a꾜", a_), new object[]
			{
				dt.Year,
				dt.Month,
				dt.Day,
				dt.Hour,
				dt.Minute,
				dt.Second
			});
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000AD68 File Offset: 0x00008F68
		public static string LogTitle(string loggerName, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			int a_ = 3;
			short num = (short)1259077632;
			switch (num)
			{
			default:
			{
				num = (short)567148552;
				int num2 = (int)((global::System.IntPtr)num);
				string text2;
				for (;;)
				{
					string text;
					global::System.Reflection.MethodBase method;
					switch (num2)
					{
					case 0:
						goto IL_24E;
					case 1:
						text = string.Empty;
						goto IL_215;
					case 2:
						text = method.ReflectedType.Name;
						goto IL_215;
					case 3:
						if (!(method.ReflectedType == null))
						{
							num = (short)793837568;
							short num3 = num;
							num = (short)1994194948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1422983169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_2D8;
					case 5:
						num = (short)1151729665;
						if (num != 0)
						{
						}
						num = (short)357236739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (method != null)
						{
							num = (short)249823237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3;
					case 7:
					{
						num = (short)470679770;
						short num4 = num;
						num = (short)1175584986;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2D8;
						default:
							num = (short)1083310080;
							if (num != 0)
							{
							}
							method = e.StackFrame.GetMethod();
							text2 = string.Empty;
							num = (short)2032795654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					}
					IL_72:
					if (e.Level == global::Motorola.Common.LogUtility.LoggingLevel.Performance)
					{
						num = (short)161415175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DD;
					IL_215:
					string arg = text;
					text2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ⱖ楘♚獜⑞偠Ṣ", a_), arg, method.Name);
					num = (short)1938620416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D8:
					num = (short)988872706;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E3:
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ౖ≘歚⁜ɞ䅠㡢Ṥ噦ᑨ㙪䵬㑮ੰ䅲ࡴ⩶奸㉺፼彾첀회ꊐ좔랖쪘ﲜ토쒤쪦첨횬鮮첰閴킸횺\ud8bc뇀ꋂꯄ鳆니ﻊ냌鋎ﻐ裒껔ꓘ蛚﷜蓞髠퓢飤뫦", a_), new object[]
				{
					global::Motorola.Common.LogUtility.LoggerUtil.DateString(e.TimeStamp),
					global::System.Threading.Thread.CurrentThread.ManagedThreadId,
					e.Level,
					text2,
					e.StampName,
					global::Motorola.Common.LogUtility.LoggerUtil.c(e.StampName).TotalMilliseconds,
					global::Motorola.Common.LogUtility.LoggerUtil.b(e.StampName).TotalMilliseconds,
					loggerName
				});
				IL_24E:
				goto IL_E3;
				IL_2DD:
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ౖ≘歚⁜ɞ䅠㡢Ṥ噦ᑨ㙪䵬㑮ੰ䅲ࡴ⩶奸⁺ټ䱾ﲀ\ude82", a_), new object[]
				{
					global::Motorola.Common.LogUtility.LoggerUtil.DateString(e.TimeStamp),
					global::System.Threading.Thread.CurrentThread.ManagedThreadId,
					e.Level,
					loggerName
				});
			}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000B0A4 File Offset: 0x000092A4
		public static string LogBody(global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1969352287;
					short num3 = num2;
					num2 = (short)1922559583;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1230897153;
						if (num2 != 0)
						{
						}
						num2 = (short)1407844352;
						if (num2 != 0)
						{
						}
						stringBuilder.AppendLine();
						stringBuilder.AppendLine(global::Motorola.Common.LogUtility.LoggerUtil.ExportExceptionInfo(e.Exception));
						num2 = (short)181665792;
						short num4 = num2;
						num2 = (short)858718209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_130;
				case 2:
					if (e.Exception != null)
					{
						num2 = (short)459276288;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_132;
				}
				goto IL_1C;
			}
			IL_130:
			IL_132:
			return stringBuilder.ToString();
			IL_1C:
			stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine(e.Message);
			num2 = (short)978321410;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000B1EC File Offset: 0x000093EC
		public static string GetCurrentLogFolderPath(string rootLogFolder)
		{
			int a_ = 10;
			short num = (short)1962381057;
			short num2 = num;
			num = (short)387092225;
			switch (num2 == num)
			{
			}
			num = (short)881000449;
			if (num != 0)
			{
			}
			num = (short)451543040;
			short num3 = num;
			num = (short)1077739520;
			if (num != 0)
			{
			}
			global::System.DateTime now = global::System.DateTime.Now;
			string path = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("╝偟塡⁣呥ᕧ䝩ᝫ彭䩯㙱䙳୵啷Ź乻䑽쑿낁旅", a_), now.Year, now.Month, now.Day);
			return global::System.IO.Path.Combine(rootLogFolder, path);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000B2E4 File Offset: 0x000094E4
		public static string GetCurrentLogFolderPath()
		{
			short num = (short)1644514775;
			short num2 = num;
			num = (short)1774865879;
			switch (num2 == num)
			{
			}
			num = (short)1189609473;
			if (num != 0)
			{
			}
			num = (short)1333264384;
			short num3 = num;
			num = (short)1584463872;
			if (num != 0)
			{
			}
			return global::Motorola.Common.LogUtility.LoggerUtil.GetCurrentLogFolderPath(global::Motorola.Common.LogUtility.Configurator.GetLogDirectory());
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000B39C File Offset: 0x0000959C
		public static void LogInnerException(global::System.Exception e)
		{
			int a_ = 3;
			short num;
			try
			{
				num = (short)1054539776;
				switch (num)
				{
				default:
				{
					string path = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㑖⥘⡚ɜ⩞འࡢ୤ࡦṨժ㉬८ၰݲᑴ᭶♸Ṻོൾꮄ", a_));
					global::Motorola.Common.LogUtility.FileLocker fileLocker = new global::Motorola.Common.LogUtility.FileLocker(global::System.IO.Path.GetFileName(path));
					goto IL_4F;
					try
					{
						for (;;)
						{
							IL_4F:
							global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(path, true);
							try
							{
								global::Motorola.Common.LogUtility.LoggingEventArgs e2 = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.Error, global::System.DateTime.Now, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᅖ㡘⽚㱜㍞䅠੢୤०౨ᥪ䵬੮ͰŲᩴն", a_), e);
								string value = global::Motorola.Common.LogUtility.LoggerUtil.LogTitle(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("Ṗ㝘㕚㡜ⵞ䅠♢ᝤᕦ٨ᥪ", a_), e2);
								streamWriter.WriteLine(value);
								string value2 = global::Motorola.Common.LogUtility.LoggerUtil.LogBody(e2);
								streamWriter.WriteLine(value2);
								streamWriter.WriteLine(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("穖瑘癚灜牞䱠乢䡤䩦䑨䙪䁬䉮屰干塴婶呸噺偼剾검꺂ꢄꪆꒈꚊꂌꊎ벐뺒뢔몖뒘뚚난늞負躢袤", a_));
							}
							finally
							{
								num = (short)513081346;
								int num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)streamWriter).Dispose();
										num = (short)1066008577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_123;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_ED;
										}
										continue;
									}
									IL_ED:
									if (streamWriter == null)
									{
										break;
									}
									num = (short)1533870080;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_123:;
							}
							num = (short)469632732;
							short num3 = num;
							num = (short)86312668;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_15A;
							}
						}
						IL_15A:
						num = (short)1024589824;
						if (num != 0)
						{
						}
					}
					finally
					{
						num = (short)831913986;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)fileLocker).Dispose();
								num = (short)684326913;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1D9;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1A4;
								}
								continue;
							}
							IL_1A4:
							if (fileLocker == null)
							{
								break;
							}
							num = (short)1413414912;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1D9:;
					}
					break;
				}
				}
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1599143937;
			if (num != 0)
			{
			}
			num = (short)1841823744;
			short num4 = num;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000B628 File Offset: 0x00009828
		public static void SetTimeStampLabel(string labelName)
		{
			int a_ = 10;
			short num = (short)1474756612;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<string, global::System.DateTime> obj;
				bool flag;
				switch (num2)
				{
				case 0:
					goto IL_201;
				case 1:
					try
					{
						global::System.Threading.Monitor.Enter(obj, ref flag);
						global::Motorola.Common.LogUtility.LoggerUtil.b[global::Motorola.Common.LogUtility.LoggerUtil.a(labelName)] = global::System.DateTime.Now;
						return;
					}
					finally
					{
						num = (short)416153602;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1E1;
							case 1:
								goto IL_1FE;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_179;
								}
								continue;
							}
							IL_179:
							if (!flag)
							{
								break;
							}
							num = (short)1915293773;
							short num3 = num;
							num = (short)367726669;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1890451456;
								if (num != 0)
								{
								}
								num = (short)1748303872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1E1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1248788481;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1FE:;
					}
					goto Block_3;
				case 2:
					labelName = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ŝ㽟♡Ⅳ⁥⥧㽩⁫㩭⽯♱㵳㭵㵷⥹⡻㽽쵿튁\udb83쪅즇좉즋슍쾏\udc91햓\udb95\udd97얙쎛", a_);
					num = (short)641335299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_84;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				}
				IL_41:
				if (string.IsNullOrEmpty(labelName))
				{
					num = (short)1176371202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_84;
				Block_3:
				global::System.Collections.Generic.Dictionary<string, global::System.TimeSpan> obj2;
				try
				{
					IL_201:
					global::System.Threading.Monitor.Enter(obj2, ref flag);
					global::Motorola.Common.LogUtility.LoggerUtil.a[global::Motorola.Common.LogUtility.LoggerUtil.a(labelName)] = global::System.Diagnostics.Process.GetCurrentProcess().TotalProcessorTime;
					goto IL_63;
				}
				finally
				{
					num = (short)278528002;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							global::System.Threading.Monitor.Exit(obj2);
							num = (short)938475521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_28C;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_259;
							}
							continue;
						}
						IL_259:
						if (!flag)
						{
							break;
						}
						num = (short)1893138432;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_28C:;
				}
				break;
				IL_63:
				obj = global::Motorola.Common.LogUtility.LoggerUtil.b;
				flag = false;
				num = (short)539361281;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_84:
				obj2 = global::Motorola.Common.LogUtility.LoggerUtil.a;
				flag = false;
				num = (short)1392836609;
				if (num != 0)
				{
				}
				num = (short)724238336;
				short num4 = num;
				num = (short)2121924608;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		private static global::System.TimeSpan c(string A_0)
		{
			int a_ = 12;
			short num = (short)869400576;
			switch (num)
			{
			default:
			{
				num = (short)494010368;
				int num2 = (int)((global::System.IntPtr)num);
				string key;
				global::System.Collections.Generic.Dictionary<string, global::System.TimeSpan> obj;
				bool flag;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)2060615839;
						short num3 = num;
						num = (short)1057390751;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12E;
						case 1:
							break;
						default:
						{
							num = (short)1372717056;
							short num4 = num;
							break;
						}
						}
						num = (short)383778817;
						if (num != 0)
						{
						}
						num = (short)569966592;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_105;
						}
						continue;
					}
					case 1:
						A_0 = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㽟㵡⁣⍥⹧⭩㥫≭⑯⵱⁳㽵㕷㽹⽻⩽셿쾁풃\ud985쒇쮉캋쮍\udc8f춑\uda93힕햗\udf99쎛솝", a_);
						num = (short)620363779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (global::Motorola.Common.LogUtility.LoggerUtil.a.ContainsKey(key))
						{
							num = (short)198443013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_174;
					case 3:
						goto IL_17F;
					case 4:
						goto IL_144;
					case 5:
						obj = global::Motorola.Common.LogUtility.LoggerUtil.a;
						flag = false;
						goto IL_12E;
					}
					IL_105:
					if (string.IsNullOrEmpty(A_0))
					{
						num = (short)696385537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17F;
					IL_12E:
					num = (short)403243012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17F:
					key = global::Motorola.Common.LogUtility.LoggerUtil.a(A_0);
					num = (short)2093875202;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_144:
				global::System.TimeSpan result;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					global::System.TimeSpan timeSpan = global::System.Diagnostics.Process.GetCurrentProcess().TotalProcessorTime - global::Motorola.Common.LogUtility.LoggerUtil.a[key];
					global::Motorola.Common.LogUtility.LoggerUtil.a.Remove(key);
					result = timeSpan;
				}
				finally
				{
					num = (short)1689911296;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_22C;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)414056450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_264;
						}
						IL_22C:
						if (!flag)
						{
							break;
						}
						num = (short)1470627841;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_264:;
				}
				return result;
				IL_174:
				return default(global::System.TimeSpan);
			}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000BB68 File Offset: 0x00009D68
		private static global::System.TimeSpan b(string A_0)
		{
			int a_ = 18;
			short num = (short)1743192064;
			switch (num)
			{
			default:
			{
				num = (short)1298333696;
				int num2 = (int)((global::System.IntPtr)num);
				string key;
				global::System.Collections.Generic.Dictionary<string, global::System.DateTime> obj;
				bool flag;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1283790720;
						short num3 = num;
						num = (short)1464801152;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_104;
						case 1:
							break;
						default:
						{
							num = (short)483000320;
							short num4 = num;
							break;
						}
						}
						num = (short)1232470016;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D9;
						}
						continue;
					}
					case 1:
						A_0 = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㥥㝧⹩⥫⡭ㅯ❱㡳≵❷⹹㕻㍽앿톁킃입얇\uda89펋슍톏킑톓\uda95잗풙\udd9b펝ﶡﮣ", a_);
						num = (short)520814593;
						if (num != 0)
						{
						}
						num = (short)1291190275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (global::Motorola.Common.LogUtility.LoggerUtil.b.ContainsKey(key))
						{
							num = (short)1024524293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_171;
					case 3:
						goto IL_17C;
					case 4:
						goto IL_11A;
					case 5:
						obj = global::Motorola.Common.LogUtility.LoggerUtil.b;
						flag = false;
						goto IL_104;
					}
					IL_D9:
					if (string.IsNullOrEmpty(A_0))
					{
						num = (short)1902706689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17C;
					IL_104:
					num = (short)1767440388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17C:
					key = global::Motorola.Common.LogUtility.LoggerUtil.a(A_0);
					num = (short)431095810;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11A:
				global::System.TimeSpan result;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					result = global::System.DateTime.Now - global::Motorola.Common.LogUtility.LoggerUtil.b[key];
				}
				finally
				{
					num = (short)1799094272;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_218;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)885456898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_24F;
						}
						IL_218:
						if (!flag)
						{
							break;
						}
						num = (short)1413545985;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_24F:;
				}
				return result;
				IL_171:
				return default(global::System.TimeSpan);
			}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		public static string RootLogFolder
		{
			get
			{
				short num = (short)936574976;
				short num2 = num;
				num = (short)1735760091;
				short num3 = num;
				num = (short)111515867;
				switch (num3 == num)
				{
				}
				num = (short)781451264;
				if (num != 0)
				{
				}
				num = (short)1298268161;
				if (num != 0)
				{
				}
				return global::Motorola.Common.LogUtility.Configurator.GetLogDirectory();
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000BE88 File Offset: 0x0000A088
		private static string a(string A_0)
		{
			int a_ = 14;
			short num = (short)1001521152;
			short num2 = num;
			num = (short)2037467945;
			short num3 = num;
			num = (short)640305961;
			switch (num3 == num)
			{
			}
			num = (short)130613248;
			if (num != 0)
			{
			}
			num = (short)1414266881;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᥡ呣᭥㝧ᅩ嵫፭", a_), A_0, global::System.Threading.Thread.CurrentThread.ManagedThreadId);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000BF64 File Offset: 0x0000A164
		// Note: this type is marked as 'beforefieldinit'.
		static LoggerUtil()
		{
			short num = (short)860880896;
			short num2 = num;
			num = (short)1755241961;
			short num3 = num;
			num = (short)918347241;
			switch (num3 == num)
			{
			}
			num = (short)255459329;
			if (num != 0)
			{
			}
			num = (short)252248064;
			if (num != 0)
			{
			}
			global::Motorola.Common.LogUtility.LoggerUtil.a = new global::System.Collections.Generic.Dictionary<string, global::System.TimeSpan>();
			global::Motorola.Common.LogUtility.LoggerUtil.b = new global::System.Collections.Generic.Dictionary<string, global::System.DateTime>();
		}

		// Token: 0x0400004F RID: 79
		private static global::System.Collections.Generic.Dictionary<string, global::System.TimeSpan> a;

		// Token: 0x04000050 RID: 80
		private static global::System.Collections.Generic.Dictionary<string, global::System.DateTime> b;

		// Token: 0x04000051 RID: 81
		private const string c = "__DEFAULT_TIMESTAMP_LABEL_NAME__";
	}
}
