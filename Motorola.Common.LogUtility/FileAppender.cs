using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Newtonsoft.Json.Linq;
using NLog;

namespace Motorola.Common.LogUtility
{
	// Token: 0x0200000B RID: 11
	public class FileAppender : global::Motorola.Common.LogUtility.IAppender, global::System.IDisposable
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00005310 File Offset: 0x00003510
		public FileAppender()
		{
			this.LoggingEvent += this.a;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005340 File Offset: 0x00003540
		private void a(object A_0, global::Motorola.Common.LogUtility.LoggingEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)606470144;
			int num2 = (int)((global::System.IntPtr)num);
			string loggerName;
			for (;;)
			{
				global::Motorola.Common.LogUtility.LogImpl logImpl;
				string text;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 1:
					if (A_1 == null)
					{
						num = (short)1986592772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2120482824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1B8;
				case 3:
				{
					if (logImpl == null)
					{
						goto IL_C2;
					}
					num = (short)1643339215;
					short num3 = num;
					num = (short)1406754255;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A0;
					default:
						num = (short)1340997632;
						if (num != 0)
						{
						}
						num = (short)248643590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_C2;
				case 5:
					goto IL_72;
				case 6:
					num = (short)1309736961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					text = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ɖ㝘ず㍜ぞᙠൢ㩤⭦٨౪੬੮Ͱ", a_);
					goto IL_17C;
				case 8:
					text = logImpl.Name;
					goto IL_17C;
				case 9:
					if (global::Motorola.Common.LogUtility.AppConfigurator.Instance.NLogEnabled)
					{
						goto IL_1A0;
					}
					goto IL_1F5;
				}
				IL_56:
				if (A_1 == null)
				{
					num = (short)1119944709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				logImpl = (A_0 as global::Motorola.Common.LogUtility.LogImpl);
				num = (short)1864892419;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C2:
				num = (short)1078788103;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17C:
				loggerName = text;
				num = (short)1973616649;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A0:
				num = (short)2070085634;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_72:
			num = (short)129695745;
			if (num != 0)
			{
			}
			return;
			IL_1B8:
			this.WriteNLog(loggerName, A_1);
			return;
			IL_1F5:
			num = (short)2133131264;
			short num4 = num;
			this.WriteFileLog(loggerName, A_1);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005574 File Offset: 0x00003774
		protected void WriteNLog(string loggerName, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			int a_ = 5;
			short num = (short)465764352;
			switch (num)
			{
			default:
			{
				num = (short)753926145;
				if (num != 0)
				{
				}
				num = (short)452591618;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_10D;
							}
							global::NLog.LogLevel level;
							for (;;)
							{
								IL_D2:
								string text;
								switch (num2)
								{
								case 0:
									if (e.Exception != null)
									{
										num = (short)1440022538;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1173618693;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_434;
								case 2:
									text = e.Message.Replace(global::System.Environment.NewLine, "");
									num = (short)1959723015;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_44D;
								case 4:
									goto IL_434;
								case 5:
									if (global::Motorola.Common.LogUtility.AppConfigurator.Instance.ElasticSearchLoggingEnabled)
									{
										num = (short)523042827;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::NLog.LogManager.GetLogger(loggerName).Log(level, text);
									num = (short)946405382;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_434;
								case 7:
									goto IL_1C8;
								case 8:
								{
									global::NLog.LogEventInfo logEventInfo;
									try
									{
										using (global::System.Collections.Generic.Dictionary<object, object>.Enumerator enumerator = global::Newtonsoft.Json.Linq.JObject.Parse(text).ToObject<global::System.Collections.Generic.Dictionary<object, object>>().GetEnumerator())
										{
											num = (short)1441005572;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													num = (short)1187643393;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													goto IL_36C;
												case 2:
												{
													num = (short)2102711354;
													short num3 = num;
													num = (short)1589957690;
													switch ((num3 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														break;
													default:
														num = (short)170000384;
														if (num != 0)
														{
														}
														if (!enumerator.MoveNext())
														{
															num = (short)2137980928;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														break;
													}
													global::System.Collections.Generic.KeyValuePair<object, object> item = enumerator.Current;
													logEventInfo.Properties.Add(item);
													num = (short)1113194499;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 4:
													switch (0)
													{
													case 0:
														goto IL_29B;
													}
													continue;
												}
												IL_29D:
												num = (short)1089011714;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_29B:
												goto IL_29D;
											}
											IL_36C:;
										}
										goto IL_20A;
									}
									catch
									{
										goto IL_20A;
									}
									goto IL_387;
									IL_20A:
									logEventInfo.Properties[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᡘ⭚ⵜ㍞ࡠbѤ፦hѪͬ", a_)] = loggerName;
									global::NLog.LogManager.GetLogger(loggerName).Log(logEventInfo);
									num = (short)1272905732;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_1C8;
								case 10:
									goto IL_387;
								case 11:
								{
									global::NLog.LogEventInfo logEventInfo = new global::NLog.LogEventInfo(level, loggerName, text);
									num = (short)1845559304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									if (e.Message != null)
									{
										num = (short)908197890;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									text = e.Exception.ToString();
									num = (short)607584265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_10D;
								IL_1C8:
								num = (short)766181376;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_387:
								global::NLog.LogManager.GetLogger(loggerName).Log(level, e.Exception, text, global::System.Array.Empty<object>());
								num = (short)1657798657;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_434:
								num = (short)20119555;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_44D:
							return;
							IL_10D:
							level = global::Motorola.Common.LogUtility.LoggerUtil.ConvertLoggingLevelToNLogLevel(e.Level);
							num = (short)1986002956;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_D2;
						}
						catch
						{
							return;
						}
						goto IL_452;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					}
					IL_7F:
					num = (short)160366592;
					short num4 = num;
					if (e == null)
					{
						num = (short)1723400193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_452:
					num = (short)1054212096;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005A40 File Offset: 0x00003C40
		protected void WriteFileLog(string loggerName, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			int a_ = 7;
			short num = (short)687210496;
			switch (num)
			{
			default:
			{
				num = (short)128385026;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					global::Motorola.Common.LogUtility.FileLocker fileLocker;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1877671940;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								bool flag;
								global::System.IO.StreamWriter streamWriter;
								switch (num2)
								{
								case 0:
									goto IL_2D9;
								case 1:
									goto IL_32F;
								case 2:
									global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(text));
									this.a(global::System.IO.Path.GetDirectoryName(text));
									num = (short)927989760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									try
									{
										num = (short)745996291;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_269;
											case 1:
											{
												num = (short)1094068467;
												short num3 = num;
												num = (short)1958750451;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_14F;
												default:
												{
													num = (short)595787776;
													if (num != 0)
													{
													}
													global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(text);
													global::System.Security.AccessControl.FileSecurity accessControl = fileInfo.GetAccessControl();
													global::System.Security.Principal.SecurityIdentifier identity = new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.WorldSid, null);
													accessControl.AddAccessRule(new global::System.Security.AccessControl.FileSystemAccessRule(identity, global::System.Security.AccessControl.FileSystemRights.FullControl, global::System.Security.AccessControl.AccessControlType.Allow));
													fileInfo.SetAccessControl(accessControl);
													num = (short)1542258690;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												break;
											}
											case 2:
												goto IL_224;
											case 3:
												goto IL_14F;
											}
											goto IL_170;
											IL_14F:
											switch (0)
											{
											case 0:
												IL_170:
												if (!flag)
												{
													goto IL_224;
												}
												num = (short)217120769;
												num2 = (int)((global::System.IntPtr)num);
												break;
											}
											continue;
											IL_224:
											streamWriter.WriteLine(global::Motorola.Common.LogUtility.LoggerUtil.LogTitle(loggerName, e));
											streamWriter.WriteLine(global::Motorola.Common.LogUtility.LoggerUtil.LogBody(e));
											streamWriter.WriteLine(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("癚灜牞䱠乢䡤䩦䑨䙪䁬䉮屰干塴婶呸噺偼剾검꺂ꢄꪆꒈꚊꂌꊎ벐뺒뢔몖뒘뚚난늞負躢袤誦蒨", a_));
											num = (short)1523122176;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_269:
										goto IL_309;
									}
									finally
									{
										num = (short)143065090;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_2D6;
											case 1:
												((global::System.IDisposable)streamWriter).Dispose();
												num = (short)1593901056;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_2A1;
												}
												continue;
											}
											IL_2A1:
											if (streamWriter == null)
											{
												break;
											}
											num = (short)92864513;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2D6:;
									}
									goto IL_2D9;
									IL_309:
									this.d(text);
									this.c(text);
									num = (short)1742536705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_DD;
									}
									continue;
								}
								IL_DD:
								if (!global::System.IO.Directory.Exists(global::System.IO.Path.GetDirectoryName(text)))
								{
									num = (short)608305154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2D9:
								flag = !global::System.IO.File.Exists(text);
								streamWriter = new global::System.IO.StreamWriter(text, true);
								num = (short)176029699;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_32F:
							return;
						}
						finally
						{
							num = (short)1419247618;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_39C;
								case 1:
									((global::System.IDisposable)fileLocker).Dispose();
									num = (short)961675264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_366;
									}
									continue;
								}
								IL_366:
								if (fileLocker == null)
								{
									break;
								}
								num = (short)63176705;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39C:;
						}
						goto IL_39F;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					IL_5A:
					if (e == null)
					{
						num = (short)1529675776;
						short num4 = num;
						num = (short)1620574209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_39F:
					text = this.a(e);
					fileLocker = new global::Motorola.Common.LogUtility.FileLocker(text);
					num = (short)804061185;
					if (num != 0)
					{
					}
					num = (short)651558912;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005E78 File Offset: 0x00004078
		protected void ClearSubscriber()
		{
			short num = (short)864538327;
			short num2 = num;
			num = (short)1235799767;
			switch (num2 == num)
			{
			}
			num = (short)1686241280;
			short num3 = num;
			num = (short)1815216129;
			if (num != 0)
			{
			}
			num = (short)638844928;
			if (num != 0)
			{
			}
			this.LoggingEvent -= this.a;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00005F30 File Offset: 0x00004130
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00005FE0 File Offset: 0x000041E0
		public string FileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1853545999;
				short num2 = num;
				num = (short)1510137359;
				switch (num2 == num)
				{
				}
				num = (short)875167744;
				short num3 = num;
				num = (short)1413152769;
				if (num != 0)
				{
				}
				num = (short)58523648;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1631125505;
				if (num != 0)
				{
				}
				num = (short)909234035;
				short num2 = num;
				num = (short)165465971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1603207168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)822673408;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00006090 File Offset: 0x00004290
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00006144 File Offset: 0x00004344
		public string SubFolderName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1879829651;
				short num2 = num;
				num = (short)140962963;
				switch (num2 == num)
				{
				}
				num = (short)1886322688;
				short num3 = num;
				num = (short)1094057985;
				if (num != 0)
				{
				}
				num = (short)1481834496;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)747640619;
				short num2 = num;
				num = (short)1207703339;
				switch (num2 == num)
				{
				}
				num = (short)172621824;
				short num3 = num;
				num = (short)92274689;
				if (num != 0)
				{
				}
				num = (short)1174142976;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000061F4 File Offset: 0x000043F4
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000062A8 File Offset: 0x000044A8
		public int MaxSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private get
			{
				short num = (short)1852454587;
				short num2 = num;
				num = (short)1480537787;
				switch (num2 == num)
				{
				}
				num = (short)1403977728;
				short num3 = num;
				num = (short)118358016;
				if (num != 0)
				{
				}
				num = (short)249495553;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1738757510;
				short num2 = num;
				num = (short)380654982;
				switch (num2 == num)
				{
				}
				num = (short)49872896;
				short num3 = num;
				num = (short)824180737;
				if (num != 0)
				{
				}
				num = (short)1575288832;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00006358 File Offset: 0x00004558
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00006408 File Offset: 0x00004608
		public int MaxBackup
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private get
			{
				short num = (short)1812332545;
				if (num != 0)
				{
				}
				num = (short)476843620;
				short num2 = num;
				num = (short)1933119076;
				switch (num2 == num)
				{
				default:
				{
					num = (short)673185792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1003749376;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)725779764;
				short num2 = num;
				num = (short)1341687092;
				switch (num2 == num)
				{
				}
				num = (short)218234880;
				short num3 = num;
				num = (short)213647361;
				if (num != 0)
				{
				}
				num = (short)817627136;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000064BC File Offset: 0x000046BC
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000656C File Offset: 0x0000476C
		public string EventSource
		{
			get
			{
				short num = (short)772060367;
				short num2 = num;
				num = (short)509195471;
				switch (num2 == num)
				{
				}
				num = (short)1824063488;
				short num3 = num;
				num = (short)2106982401;
				if (num != 0)
				{
				}
				num = (short)884408320;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)394603125;
				short num2 = num;
				num = (short)444476021;
				switch (num2 == num)
				{
				}
				num = (short)486932480;
				short num3 = num;
				num = (short)1100742656;
				if (num != 0)
				{
				}
				num = (short)324403201;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000661C File Offset: 0x0000481C
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000066C8 File Offset: 0x000048C8
		public string EventLogName
		{
			get
			{
				short num = (short)940267399;
				short num2 = num;
				num = (short)49305479;
				switch (num2 == num)
				{
				}
				num = (short)1696202752;
				short num3 = num;
				num = (short)1554317313;
				if (num != 0)
				{
				}
				num = (short)1331298304;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1505448939;
				short num2 = num;
				num = (short)1387680747;
				switch (num2 == num)
				{
				}
				num = (short)359596032;
				short num3 = num;
				num = (short)961019905;
				if (num != 0)
				{
				}
				num = (short)637665280;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006774 File Offset: 0x00004974
		public void Close()
		{
			short num = (short)1254880300;
			short num2 = num;
			num = (short)1659302956;
			switch (num2 == num)
			{
			}
			num = (short)616693760;
			short num3 = num;
			num = (short)2085027840;
			if (num != 0)
			{
			}
			num = (short)381222913;
			if (num != 0)
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000052 RID: 82 RVA: 0x00006820 File Offset: 0x00004A20
		// (remove) Token: 0x06000053 RID: 83 RVA: 0x00006958 File Offset: 0x00004B58
		public event global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> LoggingEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)49938433;
							if (num2 != 0)
							{
							}
							num2 = (short)429064192;
							short num3 = num2;
							num2 = (short)1831010304;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> value2 = (global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>>(ref this.i, value2, eventHandler2);
					num2 = (short)1191701174;
					short num4 = num2;
					num2 = (short)461105846;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1082720256;
						if (num2 != 0)
						{
						}
						num2 = (short)668794881;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				eventHandler = this.i;
				num2 = (short)72679426;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1843003393;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				int num2;
				global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> eventHandler;
				for (;;)
				{
					IL_32:
					global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> eventHandler2;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (eventHandler == eventHandler2)
						{
							num = (short)1591410688;
							short num3 = num;
							num = (short)623509504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62;
					case 2:
						goto IL_62;
					}
					goto IL_44;
					IL_62:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> value2 = (global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>>(ref this.i, value2, eventHandler2);
					num = (short)760898884;
					short num4 = num;
					num = (short)438723908;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)2007105536;
						if (num != 0)
						{
						}
						num = (short)817561601;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return;
				IL_44:
				eventHandler = this.i;
				num = (short)1033043970;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006A90 File Offset: 0x00004C90
		public void DoAppend(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			short num = (short)685309954;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C5;
				case 1:
					this.i(sender, e);
					num = (short)1959526400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)356909056;
					short num3 = num;
					num = (short)406585345;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				}
				}
				IL_81:
				if (this.i != null)
				{
					num = (short)1848508417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C5:
				num = (short)2137357865;
				short num4 = num;
				num = (short)1370390057;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_81;
				default:
					goto IL_FB;
				}
			}
			IL_FB:
			num = (short)1173880832;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00006BB0 File Offset: 0x00004DB0
		public bool IsEnabled
		{
			get
			{
				short num = (short)1269868738;
				short num2 = num;
				num = (short)1410574530;
				switch (num2 == num)
				{
				}
				num = (short)1412169728;
				short num3 = num;
				num = (short)1367801857;
				if (num != 0)
				{
				}
				num = (short)1979514880;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00006C58 File Offset: 0x00004E58
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00006D0C File Offset: 0x00004F0C
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1606380958;
				short num2 = num;
				num = (short)66743710;
				switch (num2 == num)
				{
				}
				num = (short)1093861376;
				short num3 = num;
				num = (short)275185664;
				if (num != 0)
				{
				}
				num = (short)1928986625;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1574205409;
				short num2 = num;
				num = (short)203519969;
				switch (num2 == num)
				{
				}
				num = (short)1222770688;
				short num3 = num;
				num = (short)1015480321;
				if (num != 0)
				{
				}
				num = (short)529203200;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00006DC0 File Offset: 0x00004FC0
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00006F78 File Offset: 0x00005178
		public string RootLogFolderPath
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				int num;
				short num2;
				string text;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)167562197;
						short num3 = num2;
						num2 = (short)674024405;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C4;
						default:
						{
							num2 = (short)967966720;
							short num4 = num2;
							num2 = (short)1677197312;
							if (num2 != 0)
							{
							}
							text = global::System.IO.Path.Combine(text, this.SubFolderName);
							num2 = (short)841416710;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_69;
					case 2:
						goto IL_C4;
					case 3:
						text = this.a;
						num2 = (short)2031288321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (!string.IsNullOrEmpty(this.a))
						{
							num2 = (short)441909251;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						text = global::Motorola.Common.LogUtility.Configurator.GetLogDirectory();
						num2 = (short)952565762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (!string.IsNullOrEmpty(this.SubFolderName))
						{
							num2 = (short)757989376;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return text;
					case 6:
						goto IL_17E;
					}
					goto IL_2C;
					IL_69:
					num2 = (short)1285488645;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_C4:
					goto IL_69;
				}
				IL_17E:
				num2 = (short)749338625;
				if (num2 != 0)
				{
				}
				return text;
				IL_2C:
				text = string.Empty;
				num2 = (short)192348164;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				short num = (short)1090392152;
				short num2 = num;
				num = (short)1335824472;
				switch (num2 == num)
				{
				}
				num = (short)734003201;
				if (num != 0)
				{
				}
				num = (short)2020671488;
				short num3 = num;
				num = (short)763035648;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007028 File Offset: 0x00005228
		private void d(string A_0)
		{
			while (new global::System.IO.FileInfo(A_0).Length / 1024L / 1024L < (long)this.MaxSize)
			{
				short num = (short)1429921076;
				short num2 = num;
				num = (short)1595727156;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1516044288;
					short num3 = num;
					num = (short)723779585;
					if (num != 0)
					{
					}
					num = (short)1078394880;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			string path = this.b(A_0);
			string directoryName = global::System.IO.Path.GetDirectoryName(A_0);
			global::System.IO.File.Move(A_0, global::System.IO.Path.Combine(directoryName, path));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007114 File Offset: 0x00005314
		private void c(string A_0)
		{
			int a_ = 14;
			short num = (short)1856962560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_75;
				}
				global::System.Collections.ArrayList arrayList;
				string[] files;
				for (;;)
				{
					IL_30:
					num = (short)1071513601;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_15A;
					case 1:
						goto IL_15A;
					case 2:
					{
						num = (short)1587994899;
						short num3 = num;
						num = (short)311353619;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E2;
						default:
						{
							num = (short)1136787456;
							if (num != 0)
							{
							}
							int num4;
							string[] array;
							if (num4 >= array.Length)
							{
								num = (short)491978757;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string value = array[num4];
							arrayList.Add(value);
							num4++;
							num = (short)1721106432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						if (files.Length <= this.MaxBackup + 1)
						{
							num = (short)2039021568;
							short num5 = num;
							num = (short)1318715396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						arrayList = new global::System.Collections.ArrayList();
						string[] array = files;
						int num4 = 0;
						num = (short)121503745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return;
					case 5:
						goto IL_1E0;
					}
					goto IL_75;
					IL_15A:
					num = (short)512950274;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1E0:
				IL_1E2:
				string fileName;
				arrayList.Sort(new global::Motorola.Common.LogUtility.FileAppender.CompareFileByIndex(fileName));
				global::System.IO.File.Delete(arrayList[0].ToString());
				return;
				IL_75:
				fileName = global::System.IO.Path.GetFileName(A_0);
				files = global::System.IO.Directory.GetFiles(global::System.IO.Path.GetDirectoryName(A_0), fileName + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䡡", a_));
				num = (short)459407363;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007320 File Offset: 0x00005520
		private string b(string A_0)
		{
			int a_ = 19;
			short num = (short)1928003584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				int i;
				string[] files;
				int num5;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						global::System.Text.RegularExpressions.Match match;
						if (match.Success)
						{
							num = (short)1515454466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A;
					}
					case 1:
						while (i < files.Length)
						{
							num = (short)317063169;
							if (num != 0)
							{
							}
							global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(files[i], global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䥦䅨呪公ٮὰᝲၴྲྀ䝸❺᥼呾ꢀꞂ", a_));
							num = (short)683433361;
							short num3 = num;
							num = (short)799432081;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)373948416;
								if (num != 0)
								{
								}
								num = (short)768868352;
								short num4 = num;
								num = (short)673382400;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_30;
							}
							}
						}
						num = (short)592248838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Text.RegularExpressions.Match match;
						num5 = global::System.Math.Max(num5, global::System.Convert.ToInt32(match.Groups[global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("๦ݨཪ࡬ᝮ", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture));
						num = (short)2029256709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1FE;
					case 4:
						goto IL_1FE;
					case 5:
						goto IL_9A;
					case 6:
						goto IL_239;
					}
					goto IL_53;
					IL_9A:
					i++;
					num = (short)106889219;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FE:
					num = (short)58785793;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_239:
				string fileName;
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᱦ奨ᙪ䍬ᑮ䁰๲", a_), fileName, ++num5);
				IL_53:
				num5 = 0;
				fileName = global::System.IO.Path.GetFileName(A_0);
				files = global::System.IO.Directory.GetFiles(global::System.IO.Path.GetDirectoryName(A_0), fileName + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䵦", a_));
				i = 0;
				num = (short)400621572;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000758C File Offset: 0x0000578C
		private void a(string A_0)
		{
			int a_ = 17;
			short num = (short)1737162755;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.IO.StreamWriter streamWriter;
				switch (num2)
				{
				case 0:
					goto IL_24F;
				case 1:
					if (!global::System.IO.Directory.Exists(A_0))
					{
						num = (short)270860290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24F;
				case 2:
					goto IL_17B;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 4:
					goto IL_65;
				case 5:
					try
					{
						streamWriter.WriteLine(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⡤٦੨ͪѬŮᑰ㵲ᑴ᩶ᱸ䅺嵼⑾婢뎂\uda86", a_), global::System.Environment.MachineName);
						streamWriter.WriteLine(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⩤㑦㽨๪Ὤᱮᡰᱲ᭴䵶奸⁺ټ佾ﲀ\ude82", a_), global::System.Environment.OSVersion);
						streamWriter.WriteLine(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("つᑦ౨ᥪ⍬๮ᱰᙲ佴坶≸z䵼ɾ\udc80", a_), global::System.Environment.UserName);
						streamWriter.WriteLine(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("♤⭦㭨䭪㭬੮Ͱrᱴᡶ᝸䅺嵼⑾婢뎂\uda86", a_), global::System.Environment.Version);
						streamWriter.WriteLine(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("♤ቦ᭨ᥪ࡬Ůհ㝲ᱴնᱸ᡺ॼၾ廒뾄Ꞇ튈붌첐", a_), global::System.Environment.CurrentDirectory);
						return;
					}
					finally
					{
						num = (short)485752833;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)streamWriter).Dispose();
								num = (short)988217346;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_143;
								}
								continue;
							case 2:
								goto IL_178;
							}
							IL_143:
							if (streamWriter == null)
							{
								break;
							}
							num = (short)1731723264;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_178:;
					}
					goto IL_17B;
				}
				IL_46:
				if (string.IsNullOrEmpty(A_0))
				{
					num = (short)1652752388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1708064769;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17B:
				num = (short)683016192;
				short num3 = num;
				global::System.IO.Directory.CreateDirectory(A_0);
				num = (short)1876609364;
				short num4 = num;
				num = (short)850184532;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1877147648;
					if (num != 0)
					{
					}
					num = (short)217513984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_24F:
				streamWriter = new global::System.IO.StreamWriter(global::System.IO.Path.Combine(A_0, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("d०Ὠ䕪Ŭnᙰ", a_)), false);
				num = (short)839909381;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_65:
			num = (short)429719553;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00007830 File Offset: 0x00005A30
		private string a(global::Motorola.Common.LogUtility.LoggingEventArgs A_0)
		{
			int a_ = 9;
			while (A_0 != null)
			{
				short num = (short)2061369344;
				short num2 = num;
				num = (short)627126239;
				short num3 = num;
				num = (short)717631455;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1597636608;
					if (num != 0)
					{
					}
					num = (short)2056323073;
					if (num != 0)
					{
					}
					return this.a(this.RootLogFolderPath, this.FileName, A_0.FileNameSuffix);
				}
			}
			throw new global::System.ArgumentNullException(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㡜", a_));
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007914 File Offset: 0x00005B14
		private string a(string A_0, string A_1, string A_2)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					string directoryName = global::System.IO.Path.GetDirectoryName(A_1);
					string fileNameWithoutExtension = global::System.IO.Path.GetFileNameWithoutExtension(A_1);
					string extension = global::System.IO.Path.GetExtension(A_1);
					text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("╝偟ὡ䩣ᵥ奧ᝩ䉫ᕭ䉯ཱ", a_), fileNameWithoutExtension, A_2.Replace(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("灝", a_), string.Empty), extension.Replace(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("灝", a_), string.Empty));
					text = global::System.IO.Path.Combine(directoryName, text);
					num2 = (short)50593797;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_17F;
				case 2:
					return text;
				case 3:
					goto IL_A9;
				case 4:
					if (!string.IsNullOrEmpty(A_2))
					{
						num2 = (short)397869056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13E;
				case 5:
					goto IL_13E;
				case 6:
				{
					if (!string.IsNullOrEmpty(global::System.IO.Path.GetDirectoryName(text)))
					{
						num2 = (short)1871446019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1296975161;
					short num3 = num2;
					num2 = (short)1057965369;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17F;
					default:
						goto IL_1DC;
					}
					break;
				}
				}
				goto IL_35;
				IL_17F:
				if (global::System.IO.Path.IsPathRooted(text))
				{
					num2 = (short)1297678338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)358678534;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_13E:
				num2 = (short)1895890944;
				short num4 = num2;
				num2 = (short)1727528961;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A9:
			return global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(A_0, text));
			IL_1DC:
			num2 = (short)821493760;
			if (num2 != 0)
			{
			}
			num2 = (short)1430847489;
			if (num2 != 0)
			{
			}
			return global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(global::Motorola.Common.LogUtility.LoggerUtil.GetCurrentLogFolderPath(A_0), text));
			IL_35:
			text = A_1;
			num2 = (short)916848644;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007B4C File Offset: 0x00005D4C
		public void Dispose()
		{
			short num = (short)85364164;
			short num2 = num;
			num = (short)1718521284;
			switch (num2 == num)
			{
			}
			num = (short)30146560;
			short num3 = num;
			num = (short)1715994625;
			if (num != 0)
			{
			}
			num = (short)520552448;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007C00 File Offset: 0x00005E00
		protected virtual void Dispose(bool disposing)
		{
			while (!this.k)
			{
				short num = (short)310771712;
				short num2 = num;
				num = (short)1725984180;
				short num3 = num;
				num = (short)1336372660;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1773731840;
					if (num != 0)
					{
					}
					num = (short)635174913;
					if (num != 0)
					{
					}
					this.k = true;
					return;
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007CBC File Offset: 0x00005EBC
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1598626804;
				short num2 = num;
				num = (short)1593318388;
				switch (num2 == num)
				{
				}
				num = (short)1988952065;
				if (num != 0)
				{
				}
				num = (short)2145189888;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)458424320;
			short num3 = num;
		}

		// Token: 0x04000021 RID: 33
		private string a = string.Empty;

		// Token: 0x04000022 RID: 34
		private string b;

		// Token: 0x04000023 RID: 35
		private string c;

		// Token: 0x04000024 RID: 36
		private const string d = "Application";

		// Token: 0x04000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int g;

		// Token: 0x04000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int h;

		// Token: 0x04000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> i;

		// Token: 0x0400002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string j;

		// Token: 0x0400002B RID: 43
		private bool k;

		// Token: 0x0200000C RID: 12
		private class CompareFileByIndex : global::System.Collections.IComparer
		{
			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00007D88 File Offset: 0x00005F88
			// (set) Token: 0x06000064 RID: 100 RVA: 0x00007E38 File Offset: 0x00006038
			private string CurrFileName
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)1837817676;
					short num2 = num;
					num = (short)1891950412;
					switch (num2 == num)
					{
					}
					num = (short)1647575040;
					short num3 = num;
					num = (short)708247552;
					if (num != 0)
					{
					}
					num = (short)1223360513;
					if (num != 0)
					{
					}
					return this.a;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)442988957;
					short num2 = num;
					num = (short)445544861;
					switch (num2 == num)
					{
					}
					num = (short)2031419392;
					short num3 = num;
					num = (short)1830813696;
					if (num != 0)
					{
					}
					num = (short)1439432705;
					if (num != 0)
					{
					}
					this.a = value;
				}
			}

			// Token: 0x06000065 RID: 101 RVA: 0x00007EE8 File Offset: 0x000060E8
			public CompareFileByIndex(string currFileName)
			{
				this.CurrFileName = currFileName;
			}

			// Token: 0x06000066 RID: 102 RVA: 0x00007F04 File Offset: 0x00006104
			public int Compare(object x, object y)
			{
				short num = (short)1250932854;
				short num2 = num;
				num = (short)1502328950;
				switch (num2 == num)
				{
				}
				num = (short)1303904256;
				short num3 = num;
				num = (short)825098240;
				if (num != 0)
				{
				}
				num = (short)927334401;
				if (num != 0)
				{
				}
				int num4 = this.a(x.ToString());
				int num5 = this.a(y.ToString());
				return num4 - num5;
			}

			// Token: 0x06000067 RID: 103 RVA: 0x00007FC8 File Offset: 0x000061C8
			private int a(string A_0)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				int result;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						if (global::System.IO.Path.GetFileName(A_0).Equals(this.CurrFileName))
						{
							num2 = (short)2105999360;
							short num3 = num2;
							num2 = (short)107151363;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = int.Parse(global::System.IO.Path.GetExtension(A_0).Remove(0, 1), global::System.Globalization.CultureInfo.InvariantCulture);
						num2 = (short)1333395458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return result;
					case 3:
					{
						num2 = (short)1480382251;
						short num4 = num2;
						num2 = (short)1685903147;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num2 = (short)2010906624;
							if (num2 != 0)
							{
							}
							result = int.MaxValue;
							num2 = (short)104136704;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_20;
				}
				return result;
				IL_20:
				result = 0;
				num2 = (short)568197121;
				if (num2 != 0)
				{
				}
				num2 = (short)81199105;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x0400002C RID: 44
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private string a;
		}
	}
}
