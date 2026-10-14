using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using AcpBusinessLayer;
using AcpCommonLib;
using Common;
using CommonResources;
using CommonUtility;
using ConstraintHelper;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.PackExec;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using PreEmptive.SoS.Runtime;
using SpecialFeatures.CloneWizard;
using SpecialFeatures.Comms;
using SpecialFeatures.DVRSFiles;
using SpecialFeatures.DVRSXML;
using SpecialFeatures.Flashport;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.RadioLanguagePack;
using SpecialFeatures.ReadWritePassword;
using SpecialFeatures.ReadWriteTlsPsk;
using SpecialFeatures.SystemCertificates;
using SpecialFeatures.Utilities;
using SpecialFeatures.VoiceAnnouncements;

namespace MackinawCPS.CommandLineCPS
{
	// Token: 0x02000094 RID: 148
	public class Cruncher : global::System.IDisposable
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000ED84C File Offset: 0x000EBA4C
		internal static global::MackinawCPS.CommandLineCPS.Cruncher Instance
		{
			get
			{
				short num = (short)178430611;
				short num2 = num;
				num = (short)1318429331;
				switch (num2 == num)
				{
				}
				num = (short)1878589440;
				short num3 = num;
				num = (short)1265827841;
				if (num != 0)
				{
				}
				num = (short)1158610944;
				if (num != 0)
				{
				}
				return global::MackinawCPS.CommandLineCPS.Cruncher.theInstance;
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000ED8FC File Offset: 0x000EBAFC
		private Cruncher()
		{
			int a_ = 13;
			this.locker = new object();
			base..ctor();
			this.InitLogging();
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䨂欄愆昈礊怌渎攐稒稔礖䐘䀚弜稞䘠䨢䬤稦爨株弬娮弰倲崴制䬸ጺ帼䬾⹀ㅂ汄ᩆ", a_));
			this.legalCommandLine = true;
			this.tempSender = null;
			this.tempArgs = null;
			this.operation = new global::MackinawCPS.CommandLineCPS.CruncherOperation();
			this.folderName = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꃬ胮藰鳲蟴飶闸髺ꇼ뻾焀笂䌄昆搈戊愌瘎刐䌒䘔䬖娘椚栜焞䈠䬢䀤唦", a_));
			if (!global::System.IO.Directory.Exists(this.folderName))
			{
				global::System.IO.Directory.CreateDirectory(this.folderName);
			}
			this._readWritePasswordApp = global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.GetInstance();
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䨂欄愆昈礊怌渎攐稒稔礖䐘䀚堜焞䔠縢縤搦嬨帪䌬䰮夰嘲䜴ἶ娸伺刼䴾桀Ṃ", a_));
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000ED9BC File Offset: 0x000EBBBC
		private void InitLogging()
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.LoggingSwitch.Enabled)
					{
						num2 = (short)1131610114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					num2 = (short)1596020746;
					short num3 = num2;
					num2 = (short)754079754;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1719664640;
						short num4 = num2;
						num2 = (short)854523904;
						if (num2 != 0)
						{
						}
						string fileName = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꃢ꣤ꏦ쓨", a_) + global::System.Guid.NewGuid().ToString();
						this.traceListener = new global::System.Diagnostics.TextWriterTraceListener(fileName);
						global::System.Diagnostics.Trace.Listeners.Add(this.traceListener);
						num2 = (short)1972830209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_25;
			}
			return;
			IL_25:
			this.LoggingSwitch = new global::System.Diagnostics.BooleanSwitch(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꃢ諤諦蓨諪菬诮뷰髲鯴鋶뛸诺飼跾怀眂氄栆月", a_), global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꛢ诤蛦诨蟪裬샮뗰髲蛴零鯸韺飼\udffe洀氂戄怆怈攊樌⼎縐甒㔔琖瘘瘚瀜縞传䜢Ԥ䬦䀨䔪䠬༮到䌲䘴᜶嘸䬺堼䴾⁀㝂ⱄ⡆❈", a_));
			num2 = (short)1001652225;
			if (num2 != 0)
			{
			}
			num2 = (short)567017472;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000EDB4C File Offset: 0x000EBD4C
		private void CloseLogging()
		{
			short num = (short)1888747523;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					global::System.Diagnostics.Trace.Flush();
					this.traceListener.Flush();
					this.traceListener.Close();
					num = (short)1570504710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1620639749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.traceListener != null)
					{
						goto IL_BB;
					}
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 4:
				{
					num = (short)846282144;
					short num3 = num;
					num = (short)497630624;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BB;
					default:
						num = (short)1051000832;
						if (num != 0)
						{
						}
						num = (short)1854472194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (this.LoggingSwitch.Enabled)
					{
						num = (short)630718465;
						if (num != 0)
						{
						}
						num = (short)1862336516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					return;
				}
				IL_40:
				if (this.LoggingSwitch != null)
				{
					num = (short)547946497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_BB:
				num = (short)831848448;
				short num4 = num;
				num = (short)739115008;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000EDD0C File Offset: 0x000EBF0C
		private void Report(string message)
		{
			int a_ = 14;
			short num = (short)1702494208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Diagnostics.Trace.WriteLine(message);
				try
				{
					object obj = this.locker;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						string text;
						for (;;)
						{
							IL_43:
							switch (num2)
							{
							case 0:
								goto IL_1A9;
							case 1:
								if (!global::System.IO.Directory.Exists(text))
								{
									num = (short)1495728132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A9;
							case 2:
								goto IL_265;
							case 3:
								try
								{
									global::System.IO.StreamWriter streamWriter;
									streamWriter.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗭", a_) + global::System.DateTime.Now.ToString(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("韭觯诱跳\udbf5뗷럹퇻髽擿∁䰃丅㈇有愋㐍挏愑㐓瀕縗簙", a_)) + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("돭﷯", a_) + message);
									streamWriter.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쏭\uddef\udff1\ud9f3\udbf5헷ퟹ퇻폽ⷿ⼁⤃⬅┇✉ℋ⌍㴏㼑㤓㬕㔗㜙ㄛ㌝ട༡णଥԧܩī̭ᴯἱᤳᬵᔷ᜹ᄻ", a_));
									goto IL_24D;
								}
								finally
								{
									num = (short)942669824;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.IO.StreamWriter streamWriter;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_16D;
											}
											continue;
										case 1:
											goto IL_1A6;
										case 2:
											((global::System.IDisposable)streamWriter).Dispose();
											num = (short)1778647041;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_16D:
										if (streamWriter == null)
										{
											break;
										}
										num = (short)1141440514;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1A6:;
								}
								goto IL_1A9;
							case 4:
								global::System.IO.Directory.CreateDirectory(text);
								num = (short)1607401472;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5E;
							IL_1A9:
							num = (short)591751838;
							short num3 = num;
							num = (short)755657374;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_24D:
								num = (short)510132226;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
							{
								num = (short)564396032;
								if (num != 0)
								{
								}
								global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(global::System.IO.Path.Combine(text, global::System.DateTime.Now.ToString(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("韭觯诱跳\udbf5뗷럹퇻髽擿", a_)) + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("샭鳯鷱鏳", a_)), true);
								num = (short)804847619;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							}
						}
						IL_265:
						goto IL_2D3;
						IL_5E:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						text = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꏭ鿯蛱鯳蓵韷雹鷻ꋽ䏿洁椃欅朇搉伋帍䌏丑堓礕缗䘙", a_));
						num = (short)145686529;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_43;
					}
					finally
					{
						num = (short)769916928;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_29A;
								}
								continue;
							case 1:
								goto IL_2D0;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1093861377;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_29A:
							if (!flag)
							{
								break;
							}
							num = (short)936640514;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2D0:;
					}
					IL_2D3:;
				}
				catch (global::System.Exception)
				{
				}
				num = (short)1756364801;
				if (num != 0)
				{
				}
				num = (short)1789984768;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000EE090 File Offset: 0x000EC290
		private void FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error errCode)
		{
			int a_ = 13;
			short num = (short)96800946;
			short num2 = num;
			num = (short)1126568114;
			switch (num2 == num)
			{
			}
			num = (short)124846080;
			short num3 = num;
			num = (short)107216896;
			if (num != 0)
			{
			}
			num = (short)1013317633;
			if (num != 0)
			{
			}
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䘂眄甆昈礊倌后圐稒朔爖尘椚漜瀞匠縢ἤܦ", a_) + errCode.ToString());
			this.CloseLogging();
			((global::MackinawCPS.App)global::System.Windows.Application.Current).Shutdown((int)errCode);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000EE180 File Offset: 0x000EC380
		private void CreateErrorOutput(string inputFile, int errorCode = 22001)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_2CC;
				case 1:
					if (this.operation.cruncherData == null)
					{
						num2 = (short)1533870083;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CC;
				case 2:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_B9;
						}
						for (;;)
						{
							IL_87:
							switch (num)
							{
							case 0:
								if (this.operation.targetFile != null)
								{
									num2 = (short)1217003524;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_278;
							case 1:
								if (global::System.IO.File.Exists(this.operation.sourceFile))
								{
									num2 = (short)765591560;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_20D;
							case 2:
								goto IL_278;
							case 3:
								goto IL_290;
							case 4:
								num2 = (short)2138898442;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								global::System.IO.File.Delete(this.operation.targetFile);
								num2 = (short)889454594;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
							{
								num2 = (short)1515859936;
								short num3 = num2;
								num2 = (short)1502883808;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_24F;
								default:
									num2 = (short)2026635264;
									if (num2 != 0)
									{
									}
									if (this.operation.sourceFile != null)
									{
										num2 = (short)1867120647;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_20D;
								}
								break;
							}
							case 7:
								num2 = (short)1579548673;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 8:
								goto IL_24F;
							case 9:
								goto IL_20D;
							case 10:
								if (global::System.IO.File.Exists(this.operation.targetFile))
								{
									num2 = (short)860946437;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_278;
							}
							goto IL_B9;
							IL_20D:
							num2 = (short)768475136;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_24F:
							global::System.IO.File.Delete(this.operation.sourceFile);
							num2 = (short)228261897;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_278:
							num2 = (short)1178599427;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_290:
						goto IL_384;
						IL_B9:
						global::MackinawCPS.CommandLineCPS.ObjectSerializer.DataContract_SerializeToFile(inputFile, this.operation.cruncherData);
						num2 = (short)550436870;
						num = (int)((global::System.IntPtr)num2);
						goto IL_87;
					}
					catch (global::System.Exception ex)
					{
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냪껬鷮蓰鷲雴鿶鳸觺ꃼ꓾䐀笂昄戆礈缊搌怎缐丒且吖欘縚簜欞䐠昢圤唦䘨太戬娮䔰䌲䀴䌶ᐸ਺怼Ծ慀", a_) + ex.Message);
						this.CreateErrorOutput(22003);
						this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.File);
						goto IL_384;
					}
					goto IL_2CC;
				case 3:
				{
					num2 = (short)1984036864;
					short num4 = num2;
					this.operation.cruncherData = new global::Motorola.CommonCPS.Server.EntityModel.CruncherData();
					num2 = (short)229703681;
					if (num2 != 0)
					{
					}
					num2 = (short)768606208;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_29;
				IL_2CC:
				new global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob();
				this.operation.cruncherData.ErrorCode = new int?(errorCode);
				num2 = (short)1305804802;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_384:
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냪껬鷮蓰鷲雴鿶鳸觺ꃼ꓾䠀洂挄栆笈昊氌笎砐簒笔䨖䈘帚猜笞簠砢昤唦䰨䨪夬䨮琰䄲䜴堶䬸琺䠼䬾ㅀ㙂ㅄ橆硈ᙊ", a_));
			return;
			IL_29:
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냪껬鷮蓰鷲雴鿶鳸觺ꃼ꓾䠀洂挄栆笈昊氌笎砐簒笔䨖䈘多砜砞䠠䴢砤簦樨太䠬丮䔰嘲瀴䔶䬸吺似瀾㑀㝂㕄㉆㵈晊籌቎", a_));
			num2 = (short)104923137;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000EE544 File Offset: 0x000EC744
		private void CreateErrorOutput(int errorCode = 22003)
		{
			int a_ = 3;
			short num;
			for (;;)
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꛤ闦鳨藪軬蟮铰臲ꣴ곶냸闺鯼郾猀渂搄猆怈搊挌刎䨐儒瀔瀖瀘甚䀜䐞戠儢䀤䘦崨个栬崮䌰尲䜴砶䰸伺䴼䨾㕀湂睄ᩆ", a_));
				new global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob();
				int id = global::System.Diagnostics.Process.GetCurrentProcess().Id;
				this.operation.cruncherData.ErrorCode = new int?(errorCode);
				try
				{
					global::MackinawCPS.CommandLineCPS.ObjectSerializer.DataContract_SerializeToFile(global::System.IO.Path.Combine(this.folderName, id.ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("췢蛤闦鳨藪軬蟮铰臲", a_)), this.operation.cruncherData);
				}
				catch (global::System.Exception ex)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꛤ闦鳨藪軬蟮铰臲ꣴ곶본菺黼髾焀眂氄栆月嘊嘌䰎挐瘒琔挖簘帚漜洞丠儢樤刦崨嬪堬嬮ᰰĲ栴ശᤸ", a_) + ex.Message);
					this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.File);
				}
				num = (short)1074065620;
				short num2 = num;
				num = (short)1792405716;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_DD;
				}
			}
			IL_DD:
			num = (short)574226432;
			short num3 = num;
			num = (short)2015166465;
			if (num != 0)
			{
			}
			num = (short)1371013120;
			if (num != 0)
			{
			}
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꛤ闦鳨藪軬蟮铰臲ꣴ곶냸闺鯼郾猀渂搄猆怈搊挌刎䨐嘒笔猖䐘䀚帜洞䐠䈢儤䈦氨太弬䀮䌰簲䀴䌶䤸为䤼ሾ獀Ṃ", a_));
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000EE6B8 File Offset: 0x000EC8B8
		internal bool IsCommandLineCPS(string[] args)
		{
			int a_ = 4;
			int num;
			short num2;
			global::System.Windows.Application application;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_220;
					case 1:
						num2 = (short)1342373890;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (application != null)
						{
							num2 = (short)1324351488;
							short num3 = num2;
							num2 = (short)1633615878;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_222;
					case 3:
						goto IL_182;
					case 4:
						if (string.Compare(args[0], global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쯣藥髧鿩苫跭飯韱蛳", a_), true) == 0)
						{
							num2 = (short)1524891649;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1439039493;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (application != null)
						{
							num2 = (short)2142896135;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_222;
					case 6:
					{
						num2 = (short)1663779681;
						short num4 = num2;
						num2 = (short)1217479521;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_53;
						default:
							num2 = (short)1323892737;
							if (num2 != 0)
							{
							}
							num2 = (short)1811939328;
							if (num2 != 0)
							{
							}
							application.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟣觥藧蟩跫胭铯뻱鷳飵鷷맹곻귽", a_)] = true;
							num2 = (short)159711235;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 7:
						application.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟣觥藧蟩跫胭铯뻱鷳飵鷷맹곻귽", a_)] = false;
						num2 = (short)496631808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_39;
				}
				IL_182:
				IL_220:
				IL_222:
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뿣ꗥ髧鿩苫跭飯韱蛳꯵ꏷ돹鋻飽濿瀁椃朅簇按挋怍䴏䤑儓砕簗䜙䜛圝匟愡䬣䬥䔧䬩䈫䨭簯嬱娳匵笷樹漻挽稿扁", a_) + ((bool)application.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟣觥藧蟩跫胭铯뻱鷳飵鷷맹곻귽", a_)]).ToString());
				return (bool)application.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟣觥藧蟩跫胭铯뻱鷳飵鷷맹곻귽", a_)];
			}
			IL_39:
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뿣ꗥ髧鿩苫跭飯韱蛳꯵ꏷ돹鋻飽濿瀁椃朅簇按挋怍䴏䤑嘓猕缗猙爛䌝笟次圣攥䜧䜩䄫伭帯嘱砳張嘷弹缻渽ጿὁ", a_));
			application = global::System.Windows.Application.Current;
			IL_53:
			num2 = (short)899481604;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000EE944 File Offset: 0x000ECB44
		public bool ParseCommandLineParameters(string[] args)
		{
			int a_ = 0;
			short num = (short)477560832;
			short num2 = num;
			num = (short)899350528;
			switch (num)
			{
			default:
				num = (short)168034305;
				if (num != 0)
				{
				}
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍刏眑猓缕瘗䜙䜛丝䄟倡圣䌥欧䔩䄫䌭儯就倳稵儷吹夻渽ℿぁ╃⭅ⵇ㹉⥋㱍⍏ད", a_));
				this.legalCommandLine = true;
				try
				{
					num = (short)1754333309;
					int num3 = (int)((global::System.IntPtr)num);
					bool flag;
					for (;;)
					{
						global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData;
						int? num4;
						int num5;
						global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware;
						global::System.Collections.Generic.List<byte[]> list2;
						int? num7;
						global::System.Guid? fileUuid;
						int? num8;
						int? num9;
						switch (num3)
						{
						case 0:
						{
							int? changeIndicator;
							if (changeIndicator == null)
							{
								num = (short)1939406969;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8B6;
						}
						case 1:
						{
							if (cruncherData.pbaFile == null)
							{
								num = (short)713621533;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.operation.targetArchive = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟迡蟣", a_));
							global::System.IO.FileStream fileStream = global::System.IO.File.Create(this.operation.targetArchive);
							num = (short)1244069960;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)410452026;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (!(num4.GetValueOrDefault() == num5 & num4 != null))
							{
								num = (short)490143768;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_161D;
						case 4:
							flag = (this.legalCommandLine = false);
							flag = flag;
							num = (short)2125725738;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_B83;
						case 6:
							if (num4 != null)
							{
								num = (short)1870332015;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_161D;
						case 7:
							goto IL_195A;
						case 8:
							goto IL_195A;
						case 9:
							num = (short)270663779;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (this.operation.inputFile != null)
							{
								num = (short)714211438;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F65;
						case 11:
						{
							this.operation.Type = global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.ARCHIVECLONE;
							this.operation.targetArchive = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟迡蟣", a_));
							global::System.IO.FileStream fileStream2 = global::System.IO.File.Create(this.operation.targetArchive);
							num = (short)1617166459;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							if (cruncherData != null)
							{
								num = (short)955973679;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16B0;
						case 13:
							if (string.Compare(args[1], global::PreEmptive.SoS.Runtime.FixedLengthStream.b("鋟蟡藣若", a_), true) == 0)
							{
								num = (short)2046296105;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_105B;
						case 14:
							this.operation.Type = global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.WRITE;
							num = (short)1855848499;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_6F1;
						case 16:
							if (string.Compare(args[1], global::PreEmptive.SoS.Runtime.FixedLengthStream.b("雟蟡難闥臧藩苫", a_), true) == 0)
							{
								num = (short)330301484;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1130;
						case 17:
							if (global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus_enhanced(cruncherData.pbaFile))
							{
								num = (short)1334378609;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵諷裹鏻賽巿夁吃朅稇礉椋䴍缏缑礓眕瘗縙倛眝丟䜡琣䜥娧䬩䄫䬭䐯圱䘳䔵攷愹欻䰽⤿㙁⅃ᭅ片橉ो⁍㍏㵑こ㽕㙗㵙籛㭝቟ၡୣᑥ", a_));
							this.legalCommandLine = false;
							this.operation.targetFile = null;
							num = (short)1440153660;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (cruncherData.Codeplug is global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)
							{
								num = (short)261947423;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1530;
						case 19:
							if (this.operation.cruncherData.arvFile == null)
							{
								num = (short)972947559;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C6F;
						case 20:
							num = (short)1665663071;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							goto IL_1470;
						case 22:
							if (this.operation.cruncherData.pbaFile == null)
							{
								num = (short)1287323673;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A6B;
						case 23:
							if (string.Compare(args[1], global::PreEmptive.SoS.Runtime.FixedLengthStream.b("韟郡跣鋥跧", a_), true) == 0)
							{
								num = (short)424476686;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_BDC;
						case 24:
							goto IL_D7A;
						case 25:
						{
							this.operation.sourceFile = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟迡蟣", a_));
							global::System.IO.FileStream fileStream3 = global::System.IO.File.Create(this.operation.sourceFile);
							num = (short)2014904365;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 26:
							num = (short)1813250071;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							if (cruncherData.Codeplug != null)
							{
								num = (short)519503949;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A6B;
						case 28:
							goto IL_6F1;
						case 29:
						{
							this.operation.sourceFile = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟迡蟣", a_));
							global::System.IO.FileStream fileStream4 = global::System.IO.File.Create(this.operation.sourceFile);
							num = (short)1774649425;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
							if (global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus_enhanced(cruncherData.pbaFile))
							{
								num = (short)521863222;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵諷裹鏻賽巿夁吃朅稇礉椋䴍缏缑礓眕瘗縙倛眝丟䜡琣䜥娧䬩䄫䬭䐯圱䘳䔵攷愹渻嬽ℿ♁᥃籅桇ཉ≋ⵍ㽏㙑㵓㡕㽗穙㥛ⱝ቟ൡᙣ", a_));
							this.legalCommandLine = false;
							this.operation.targetFile = null;
							num = (short)1066139676;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							astrofirmware = (cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).ASTROFirmware;
							num = (short)918749304;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							if (global::System.IO.File.Exists(this.operation.inputFile))
							{
								num = (short)1206321237;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F65;
						case 33:
							goto IL_18D6;
						case 34:
							try
							{
								global::System.IO.FileStream fileStream5;
								global::System.Collections.Generic.List<byte[]> list;
								fileStream5.Write(list[0], 0, list[0].Length);
								goto IL_195A;
							}
							finally
							{
								num = (short)1673330690;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream5;
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)fileStream5).Dispose();
										num = (short)1551826945;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_5D6;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_59F;
										}
										continue;
									}
									IL_59F:
									if (fileStream5 == null)
									{
										break;
									}
									num = (short)123797504;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_5D6:;
							}
							goto IL_5D9;
						case 35:
							this.operation.inputFile = args[2];
							num = (short)2018639888;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							goto IL_17A3;
						case 37:
							this.createSerialNumber = args[3];
							num = (short)557121643;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 38:
							try
							{
								global::System.IO.FileStream fileStream6;
								fileStream6.Write(list2[0], 0, list2[0].Length);
								goto IL_6F1;
							}
							finally
							{
								num = (short)362414081;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream6;
									switch (num3)
									{
									case 0:
										goto IL_827;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_7F0;
										}
										continue;
									case 2:
										((global::System.IDisposable)fileStream6).Dispose();
										num = (short)896794624;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_7F0:
									if (fileStream6 == null)
									{
										break;
									}
									num = (short)1492189186;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_827:;
							}
							goto Block_11;
						case 39:
							goto IL_6F1;
						case 40:
						{
							int? changeIndicator = cruncherData.Codeplug.ChangeIndicator;
							num = (short)910819328;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 41:
							this.operation.Type = global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.READ;
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍䀏猑易攕紗夙猛猝䴟䌡䨣䈥搧䌩䈫䬭怯匱䘳圵唷弹䠻嬽㈿ㅁ᥃ᵅᩇ⽉ⵋ⩍൏桑瑓ᅕ㵗⹙籛㩝՟ᑡൣե൧䩩իmᙯᵱٳ᭵᥷๹ᕻᅽ", a_));
							num = (short)2126577694;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
							goto IL_179E;
						case 43:
							num = (short)783417442;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ClientVersion clientVersion = global::SpecialFeatures.Utilities.RMVersioningUtilities.GetClientVersion();
							global::MackinawCPS.CommandLineCPS.ObjectSerializer.DataContract_SerializeToFile(this.operation.inputFile, clientVersion);
							global::System.Environment.Exit(0);
							num = (short)21758026;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 45:
						{
							try
							{
								global::System.IO.FileStream fileStream3;
								fileStream3.Write(this.operation.cruncherData.arvFile, 0, this.operation.cruncherData.arvFile.Length);
								goto IL_1CCB;
							}
							finally
							{
								num = (short)1401683969;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									num = (short)299715849;
									short num6 = num;
									num = (short)1939885321;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_F00;
									default:
									{
										num = (short)541196288;
										if (num != 0)
										{
										}
										global::System.IO.FileStream fileStream3;
										switch (num3)
										{
										case 0:
											goto IL_F00;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_EC5;
											}
											continue;
										case 2:
											((global::System.IDisposable)fileStream3).Dispose();
											num = (short)1302724608;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_EC5:
										if (fileStream3 == null)
										{
											goto IL_F02;
										}
										num = (short)1236598786;
										num3 = (int)((global::System.IntPtr)num);
										break;
									}
									}
								}
								IL_F00:
								IL_F02:;
							}
							goto IL_F03;
							IL_1CCB:
							this.operation.targetArchive = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟迡蟣", a_));
							global::System.IO.FileStream fileStream7 = global::System.IO.File.Create(this.operation.targetArchive);
							num = (short)359923808;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 46:
						{
							try
							{
								global::System.Collections.Generic.List<byte[]> list3;
								this.operation.IsEncryptedPwd = global::SpecialFeatures.Comms.ParseDataHelper.ReadEncryptPasswordFlag(global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(list3[0], false));
								goto IL_1BBD;
							}
							catch
							{
								goto IL_1BBD;
							}
							goto IL_1130;
							IL_1BBD:
							this.operation.targetFile = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟髡铣蓥觧", a_));
							global::System.IO.FileStream fileStream8 = global::System.IO.File.Create(this.operation.targetFile);
							num = (short)424673341;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 47:
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍䀏猑易攕紗夙猛猝䴟䌡䨣䈥搧䌩䈫䬭怯匱䘳圵唷弹䠻嬽㈿ㅁ᥃籅桇᥉㡋⽍≏♑㵓㡕㽗穙୛ⱝय़ᙡţ䙥≧թ๫", a_));
							this.operation.Type = global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.WRITE;
							this.operation.cruncherData = cruncherData;
							num = (short)1014431852;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 48:
							num = (short)667353101;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 49:
						{
							this.operation.sourceFile = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟迡蟣", a_));
							global::System.IO.FileStream fileStream9 = global::System.IO.File.Create(this.operation.sourceFile);
							num = (short)1139933313;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 50:
							num = (short)1854341253;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 51:
							if (cruncherData.Codeplug != null)
							{
								num = (short)1790705755;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵諷裹鏻賽巿夁吃朅稇礉椋䴍缏缑礓眕瘗縙倛眝丟䜡琣䜥娧䬩䄫䬭䐯圱䘳䔵攷愹欻䰽⤿㙁⅃ᭅ片橉Ջ⁍♏㍑㡓㽕㱗穙㍛⹝՟ၡգብŧթɫ乭ͯᵱųѵ᭷ό屻᡽", a_));
							this.operation.sourceFile = null;
							this.legalCommandLine = false;
							num = (short)205062199;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
							this.SetupVirtualDevice(this.operation.targetFile, this.operation.deviceInfo);
							num = (short)1233387583;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 53:
							if (this.operation.sourceFile != null)
							{
								num = (short)1193148427;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.legalCommandLine = false;
							this.operation.targetFile = null;
							num = (short)267976743;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 54:
							goto IL_F03;
						case 55:
							goto IL_157D;
						case 56:
							if (this.operation.Type != global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.UPGRADE)
							{
								num = (short)2062286868;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10C7;
						case 57:
							num7 = null;
							num = (short)583991426;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 58:
							if (this.operation.cruncherData.arvFile != null)
							{
								num = (short)1839267972;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A6B;
						case 59:
							goto IL_5D9;
						case 60:
							goto IL_6F1;
						case 61:
							goto IL_82A;
						case 62:
							if (string.Compare(args[1], global::PreEmptive.SoS.Runtime.FixedLengthStream.b("觟迡铣觥髧黩", a_), true) == 0)
							{
								num = (short)1771503731;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F37;
						case 63:
							goto IL_16B0;
						case 64:
							if (this.operation.Type != global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.READ)
							{
								num = (short)524157040;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10C7;
						case 65:
							num = (short)1442578451;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 66:
							goto IL_1A19;
						case 67:
							if (this.operation.cruncherData.pbaFile != null)
							{
								num = (short)1318846580;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C6F;
						case 68:
							if (fileUuid != null)
							{
								num = (short)1227620456;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C6A;
						case 69:
							num = (short)360841308;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 70:
							goto IL_16B0;
						case 71:
						{
							int? changeIndicator;
							if (changeIndicator == null)
							{
								num = (short)197525561;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)385941626;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 72:
							try
							{
								global::System.IO.FileStream fileStream;
								fileStream.Write(cruncherData.arvFile, 0, cruncherData.arvFile.Length);
								goto IL_157D;
							}
							finally
							{
								num = (short)1460142080;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1434;
										}
										continue;
									case 1:
										goto IL_146D;
									case 2:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)723255297;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1434:
									if (fileStream == null)
									{
										break;
									}
									num = (short)293797890;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_146D:;
							}
							goto IL_1470;
						case 73:
							goto IL_10C7;
						case 74:
							goto IL_1130;
						case 75:
							if (cruncherData.pbaFile != null)
							{
								num = (short)1164312581;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍䀏猑易攕紗夙猛猝䴟䌡䨣䈥搧䌩䈫䬭怯匱䘳圵唷弹䠻嬽㈿ㅁ᥃ᵅ὇㡉╋㩍㕏ད湓癕ᅗ㵙㉛ㅝ቟ݡ䑣ɥ൧ᱩի൭ᕯ剱ᵳᡵṷᕹ๻፽", a_));
							num = (short)283836469;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 76:
							goto IL_16B0;
						case 77:
							num = (short)769589328;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 78:
							num = (short)844628085;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 79:
							num = (short)704512056;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 80:
							if (cruncherData.Template != null)
							{
								num = (short)639303682;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A6B;
						case 81:
							try
							{
								global::System.IO.FileStream fileStream4;
								fileStream4.Write(cruncherData.ctFile, 0, cruncherData.ctFile.Length);
								goto IL_157D;
							}
							finally
							{
								num = (short)435421184;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream4;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_189B;
										}
										continue;
									case 1:
										goto IL_18D3;
									case 2:
										((global::System.IDisposable)fileStream4).Dispose();
										num = (short)1103364097;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_189B:
									if (fileStream4 == null)
									{
										break;
									}
									num = (short)1682636802;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_18D3:;
							}
							goto IL_18D6;
						case 82:
							num = (short)1713504349;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 83:
						{
							this.operation.targetFile = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟髡铣蓥觧", a_));
							global::System.Collections.Generic.List<byte[]> list = global::Motorola.Common.CommonLib.CombineTool.Decode(this.operation.cruncherData.pbaFile);
							this.operation.deviceInfo = (global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo)global::Motorola.Common.CommonLib.CombineTool.ByteArrayToObject(list[1]);
							global::System.IO.FileStream fileStream5 = global::System.IO.File.Create(this.operation.targetFile);
							num = (short)596967458;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 84:
							goto IL_2124;
						case 85:
							this.CreateErrorOutput(this.operation.inputFile, 22004);
							num = (short)1880817723;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 86:
							if (this.legalCommandLine)
							{
								num = (short)863502418;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6F1;
						case 87:
							goto IL_3D8;
						case 88:
							goto IL_6F1;
						case 89:
							goto IL_213C;
						case 90:
							if (num4.GetValueOrDefault() == num5 & num4 != null)
							{
								num = (short)480968744;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D7A;
						case 91:
							num4 = cruncherData.Codeplug.ChangeIndicator;
							num = (short)437190662;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 92:
							if (this.operation.deviceInfo != null)
							{
								num = (short)1336016948;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AD7;
						case 93:
							if (string.Compare(args[1], global::PreEmptive.SoS.Runtime.FixedLengthStream.b("菟郡臣蟥鳧迩", a_), true) == 0)
							{
								num = (short)271515726;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6F1;
						case 94:
							if (!this.legalCommandLine)
							{
								num = (short)2070478914;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2124;
						case 95:
							if (this.operation.Type == global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.CREATE)
							{
								num = (short)574816329;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16B0;
						case 96:
							try
							{
								global::System.IO.FileStream fileStream7;
								fileStream7.Write(this.operation.cruncherData.arvFile, 0, this.operation.cruncherData.arvFile.Length);
								goto IL_197F;
							}
							finally
							{
								num = (short)622133248;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream7;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_20C0;
										}
										continue;
									case 1:
										goto IL_20F9;
									case 2:
										((global::System.IDisposable)fileStream7).Dispose();
										num = (short)669515777;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_20C0:
									if (fileStream7 == null)
									{
										break;
									}
									num = (short)712310786;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_20F9:;
							}
							goto IL_20FC;
							IL_197F:
							this.operation.deviceInfo = new global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo();
							this.operation.targetFile = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟髡铣蓥觧", a_));
							this.legalCommandLine = true;
							num = (short)42598408;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 97:
							this.legalCommandLine = false;
							num = (short)617545764;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 98:
							if (this.operation.targetFile != null)
							{
								num = (short)1199702085;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AD7;
						case 99:
							if (cruncherData.Codeplug != null)
							{
								num = (short)1147863105;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C6F;
						case 100:
							if (!global::System.IO.File.Exists(this.operation.inputFile))
							{
								num = (short)732889185;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17A3;
						case 101:
							goto IL_195A;
						case 102:
							if (global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus_enhanced(this.operation.cruncherData.pbaFile))
							{
								num = (short)304480339;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵諷裹鏻賽巿夁吃朅稇礉椋䴍缏缑礓眕瘗縙倛眝丟䜡琣䜥娧䬩䄫䬭䐯圱䘳䔵攷愹缻䰽┿⍁ぃ⍅ᕇ灉汋୍㹏ㅑ㭓㉕ㅗ㑙㭛繝՟ၡᙣ॥ᩧ", a_));
							this.legalCommandLine = false;
							this.operation.targetFile = null;
							num = (short)1624244325;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 103:
							num = (short)1883832387;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 104:
						{
							global::MackinawCPS.CommandLineCPS.CruncherOperation cruncherOperation = this.operation;
							fileUuid = astrofirmware.FileUuid;
							cruncherOperation.fwPackagePath = fileUuid.Value.ToString();
							num = (short)564068483;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 105:
							goto IL_5D9;
						case 106:
							if (this.legalCommandLine)
							{
								num = (short)1040646192;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_105B;
						case 107:
							goto IL_C1D;
						case 108:
							if (this.legalCommandLine)
							{
								num = (short)1314127898;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_BDC;
						case 109:
							num8 = num7;
							goto IL_1B33;
						case 110:
							num = (short)1363017760;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 111:
						{
							int? changeIndicator = cruncherData.Codeplug.ChangeIndicator;
							num = (short)636092487;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 112:
							num = (short)1030684790;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 113:
						{
							global::System.Collections.Generic.List<byte[]> list3 = global::Motorola.Common.CommonLib.CombineTool.Decode(cruncherData.pbaFile);
							this.operation.deviceInfo = (global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo)global::Motorola.Common.CommonLib.CombineTool.ByteArrayToObject(list3[1]);
							num = (short)1663107118;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 114:
							if (this.legalCommandLine)
							{
								num = (short)701562923;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AD7;
						case 115:
							this.operation.Type = global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.IMPORT;
							this.operation.targetFile = args[3];
							num = (short)1108410492;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 116:
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍䀏猑易攕紗夙猛猝䴟䌡䨣䈥搧䌩䈫䬭怯匱䘳圵唷弹䠻嬽㈿ㅁ᥃ᵅେ㡉⥋⽍⑏㝑॓汕硗ᥙ⹛㭝şᙡţ䙥≧թ๫乭Ὧᱱ味♵㩷㭹", a_));
							num = (short)1051525222;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 117:
							if (args.Length >= 4)
							{
								num = (short)1912406053;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C1D;
						case 118:
							if (this.operation.Type != global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.WRITE)
							{
								num = (short)2012545103;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10C7;
						case 119:
						{
							try
							{
								this.operation.IsEncryptedPwd = global::SpecialFeatures.Comms.ParseDataHelper.ReadEncryptPasswordFlag(global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(list2[0], false));
								goto IL_1F08;
							}
							catch
							{
								goto IL_1F08;
							}
							goto IL_1A19;
							IL_1F08:
							global::System.IO.FileStream fileStream6 = global::System.IO.File.Create(this.operation.targetFile);
							num = (short)870514726;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 120:
							if (astrofirmware != null)
							{
								num = (short)1113128993;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C75;
						case 121:
							goto IL_20FC;
						case 122:
						{
							int? changeIndicator;
							num9 = new int?(changeIndicator.GetValueOrDefault() & 16);
							goto IL_165D;
						}
						case 123:
							try
							{
								global::System.IO.FileStream fileStream2;
								fileStream2.Write(cruncherData.arvFile, 0, cruncherData.arvFile.Length);
								goto IL_367;
							}
							finally
							{
								num = (short)300220417;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream2;
									switch (num3)
									{
									case 0:
										goto IL_1058;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_101F;
										}
										continue;
									case 2:
										((global::System.IDisposable)fileStream2).Dispose();
										num = (short)239796224;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_101F:
									if (fileStream2 == null)
									{
										break;
									}
									num = (short)1116602370;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1058:;
							}
							goto IL_105B;
							IL_367:
							this.operation.deviceInfo = new global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo();
							this.operation.targetFile = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟髡铣蓥觧", a_));
							this.legalCommandLine = true;
							num = (short)814088280;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 124:
							goto IL_3D8;
						case 125:
							switch (0)
							{
							case 0:
								goto IL_2D9;
							}
							continue;
						case 126:
						{
							int? changeIndicator;
							num8 = new int?(changeIndicator.GetValueOrDefault() & 2);
							goto IL_1B33;
						}
						case 127:
							if (this.legalCommandLine)
							{
								num = (short)971309077;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F37;
						case 128:
							if (args.Length >= 3)
							{
								num = (short)1738997795;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.legalCommandLine = false;
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵諷裹鏻賽巿夁吃朅稇礉椋䴍缏缑礓眕瘗縙倛眝丟䜡琣䜥娧䬩䄫䬭䐯圱䘳䔵攷9᰻眽⸿㑁╃⩅ⅇ⹉汋ⵍ㽏㽑㥓㝕㙗㹙", a_));
							num = (short)2052653126;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 129:
							try
							{
								global::System.IO.FileStream fileStream9;
								fileStream9.Write(cruncherData.ctFile, 0, cruncherData.ctFile.Length);
								goto IL_161D;
							}
							finally
							{
								num = (short)64815105;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream9;
									switch (num3)
									{
									case 0:
										goto IL_B80;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_B48;
										}
										continue;
									case 2:
										((global::System.IDisposable)fileStream9).Dispose();
										num = (short)1744044032;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_B48:
									if (fileStream9 == null)
									{
										break;
									}
									num = (short)689307650;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_B80:;
							}
							goto IL_B83;
						case 130:
							num9 = num7;
							goto IL_165D;
						case 131:
							this.operation.fwPackageDesc = astrofirmware;
							num = (short)321585202;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 132:
							num = (short)83755030;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 133:
							if (cruncherData.pbaFile == null)
							{
								num = (short)1078460465;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_161D;
						case 134:
							if (cruncherData != null)
							{
								num = (short)1701314569;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C6F;
						}
						IL_2D9:
						if (!this.IsCommandLineCPS(args))
						{
							num = (short)1874919428;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)352125056;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3D8:
						num = (short)927465572;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_5D9:
						this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Parameter);
						num = (short)2144534612;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_6F1:
						num = (short)1517027392;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						Block_11:
						try
						{
							IL_82A:
							global::System.Collections.Generic.List<byte[]> list3;
							global::System.IO.FileStream fileStream8;
							fileStream8.Write(list3[0], 0, list3[0].Length);
							goto IL_6F1;
						}
						finally
						{
							num = (short)1661468673;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.IO.FileStream fileStream8;
								switch (num3)
								{
								case 0:
									goto IL_8B3;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_87B;
									}
									continue;
								case 2:
									((global::System.IDisposable)fileStream8).Dispose();
									num = (short)607322112;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_87B:
								if (fileStream8 == null)
								{
									break;
								}
								num = (short)197197826;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_8B3:;
						}
						IL_8B6:
						num = (short)395640958;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A6B:
						num = (short)1788149894;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_AD7:
						this.legalCommandLine = false;
						num = (short)683278412;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B83:
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍䀏猑易攕紗夙猛猝䴟䌡䨣䈥搧䌩䈫䬭怯匱䘳圵唷弹䠻嬽㈿ㅁ᥃ᵅ὇㡉╋㩍㕏ད湓癕ὗ㽙⡛繝џݡባཥ୧ཀྵ䱫ݭṯᑱ᭳ѵᕷ᭹ࡻ᝽", a_));
						num = (short)2027290641;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_BDC:
						num = (short)185270378;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C1D:
						this.operation.Type = global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.CREATE;
						num = (short)1965948955;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D7A:
						this.operation.Type = global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.UPGRADE;
						num = (short)641269778;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F03:
						this.operation.targetFile = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("컟髡铣蓥觧", a_));
						list2 = global::Motorola.Common.CommonLib.CombineTool.Decode(cruncherData.pbaFile);
						this.operation.deviceInfo = (global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo)global::Motorola.Common.CommonLib.CombineTool.ByteArrayToObject(list2[1]);
						num = (short)1195638903;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_105B:
						num = (short)38862934;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_10C7:
						num = (short)1490747506;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1130:
						cruncherData = null;
						num = (short)238354559;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1470:
						num = (short)2098135102;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_157D:
						num = (short)1912275019;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_161D:
						num = (short)2059206657;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_165D:
						num4 = num9;
						num5 = 0;
						num = (short)96469082;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_16B0:
						num = (short)372375646;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_17A3:
						num = (short)1254293516;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_18D6:
						fileUuid = astrofirmware.FileUuid;
						num = (short)477429828;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_195A:
						bool flag2 = this.legalCommandLine;
						num = (short)195493903;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A19:
						num = (short)35848202;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B33:
						num4 = num8;
						num5 = 0;
						num = (short)1437859843;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1C6F:
						this.legalCommandLine = false;
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵諷裹鏻賽巿夁吃朅稇礉椋䴍缏缑礓眕瘗縙倛眝丟䜡琣䜥娧䬩䄫䬭䐯圱䘳䔵攷9᰻眽⸿㑁╃⩅ⅇ⹉汋ݍ㹏≑⅓≕", a_));
						this.operation.Type = global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.NONE;
						this.operation.targetFile = null;
						this.operation.sourceFile = null;
						num = (short)96272391;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F37:
						cruncherData = global::MackinawCPS.CommandLineCPS.ObjectSerializer.DataContract_DeserializeFromFile<global::Motorola.CommonCPS.Server.EntityModel.CruncherData>(this.operation.inputFile);
						num = (short)2055798871;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F65:
						this.CreateErrorOutput(22002);
						num = (short)809631849;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_20FC:
						num7 = null;
						num = (short)1326907501;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2124:
						num = (short)1744633945;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_C6A:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AstroCruncherUpgradeFail);
					IL_C75:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AstroCruncherUpgradeFail);
					IL_1530:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AstroCruncherUpgradeFail);
					IL_179E:
					return flag;
					IL_213C:;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					this.legalCommandLine = false;
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵胷駹駻軽瓿欁欃栅唇儉尋漍戏愑焓唕眗眙焛缝丟䘡栣伥䘧伩簫伭䈯匱夳匵䰷弹主䴽ᴿ硁摃", a_) + ex.Message);
					if (this.operation.inputFile != null)
					{
						this.CreateErrorOutput(this.operation.inputFile, (int)ex.ErrorCode);
					}
					else
					{
						this.CreateErrorOutput(22002);
					}
					this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Parameter);
				}
				catch (global::System.Exception ex2)
				{
					this.legalCommandLine = false;
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵胷駹駻軽瓿欁欃栅唇儉尋漍戏愑焓唕眗眙焛缝丟䘡栣伥䘧伩簫伭䈯匱夳匵䰷弹主䴽ᴿ硁摃", a_) + ex2.Message);
					if (this.operation.inputFile != null)
					{
						this.CreateErrorOutput(this.operation.inputFile, 22011);
					}
					else
					{
						this.CreateErrorOutput(22002);
					}
					this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Parameter);
				}
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍唏簑瀓䬕䌗䨙紛氝匟䜡朣䤥䔧䜩䴫䀭启縱崳堵崷樹崻䰽ℿ⽁⅃㉅ⵇ㡉㽋ፍ橏牑", a_) + this.legalCommandLine.ToString());
				return this.legalCommandLine;
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000F0CC8 File Offset: 0x000EEEC8
		internal void LaunchOperations(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation type;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_CF;
				case 1:
					if (!this.legalCommandLine)
					{
						goto IL_B8;
					}
					goto IL_299;
				case 2:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_104;
						}
						for (;;)
						{
							IL_DE:
							switch (num)
							{
							case 0:
								goto IL_268;
							case 1:
								num2 = (short)2053439494;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (type)
								{
								case global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.READ:
									this.CruncherRead(this.operation.inputFile);
									num2 = (short)1130364935;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.WRITE:
								case global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.ARCHIVECLONE:
								case global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.NONECLONEWRITE:
								case global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.UPGRADE:
									this.CruncherWrite(this.operation.inputFile);
									num2 = (short)1995702275;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.CREATE:
									this.CruncherCreate(this.operation.inputFile);
									num2 = (short)1094189061;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.IMPORT:
									this.CruncherImport(this.operation);
									num2 = (short)1245904900;
									num = (int)((global::System.IntPtr)num2);
									continue;
								default:
									num2 = (short)470286337;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 3:
								goto IL_23F;
							case 4:
								goto IL_23F;
							case 5:
								goto IL_23F;
							case 6:
								goto IL_23F;
							case 7:
								goto IL_23F;
							}
							goto IL_104;
							IL_23F:
							this.EndExecuteCommand(this.operation.cruncherData);
							num2 = (short)1287913472;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_268:
						goto IL_373;
						IL_104:
						this.BeginExecuteCommand(this.operation.cruncherData);
						type = this.operation.Type;
						num2 = (short)79429634;
						num = (int)((global::System.IntPtr)num2);
						goto IL_DE;
					}
					catch (global::System.Exception ex)
					{
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䘂約搆氈笊礌明縐紒䠔䰖唘稚栜焞䈠䬢樤圦䰨太䰬嬮堰尲嬴䐶搸ĺᴼ", a_) + ex.Message);
						this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Fail);
						goto IL_373;
					}
					goto IL_299;
				}
				goto IL_25;
				IL_B8:
				num2 = (short)282066944;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_299:
				this.tempSender = sender;
				this.tempArgs = e;
				num2 = (short)565928543;
				short num3 = num2;
				num2 = (short)1456562783;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B8;
				default:
				{
					num2 = (short)1889665024;
					short num4 = num2;
					num2 = (short)682819584;
					if (num2 != 0)
					{
					}
					num2 = (short)1964113921;
					if (num2 != 0)
					{
					}
					num2 = (short)770244610;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
				}
			}
			IL_CF:
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䘂眄甆昈礊倌后崐爒怔礖稘猚刜漞䐠儢䐤匦䀨䐪䌬尮氰लᔴ縶圸䴺尼匾⡀❂敄⑆♈♊⁌⹎㽐㝒", a_));
			return;
			IL_373:
			string[] array = new string[5];
			array[0] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䨂欄愆昈礊怌渎攐稒稔礖䐘䀚堜焞䔠縢縤欦䠨帪䌬䰮夰簲䔴制䬸娺䤼嘾⹀ⵂ㙄ᩆ獈歊ᙌ", a_);
			array[1] = global::System.DateTime.Now.ToString();
			array[2] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("췬싮퇰", a_);
			int num5 = 3;
			type = this.operation.Type;
			array[num5] = type.ToString();
			array[4] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냬", a_);
			this.Report(string.Concat(array));
			this.CloseLogging();
			((global::MackinawCPS.App)global::System.Windows.Application.Current).Shutdown();
			return;
			IL_25:
			string[] array2 = new string[5];
			array2[0] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䨂欄愆昈礊怌渎攐稒稔礖䐘䀚弜稞䘠䨢䬤稦爨未䰬娮弰倲崴砶䤸帺似帾㕀⩂⩄⥆㩈ᙊ睌潎੐", a_);
			array2[1] = global::System.DateTime.Now.ToString();
			array2[2] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("췬싮퇰", a_);
			int num6 = 3;
			type = this.operation.Type;
			array2[num6] = type.ToString();
			array2[4] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냬", a_);
			this.Report(string.Concat(array2));
			num2 = (short)596705281;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000F10EC File Offset: 0x000EF2EC
		private bool SetupVirtualDevice(string deviceFile, global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo deviceInfo)
		{
			int a_ = 10;
			short num = (short)1896546304;
			short num2 = num;
			num = (short)5291490;
			short num3 = num;
			num = (short)1488960994;
			switch (num3 == num)
			{
			}
			num = (short)213778433;
			if (num != 0)
			{
			}
			num = (short)1518469120;
			if (num != 0)
			{
			}
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뇩꿫鳭藯鳱音黵鷷裹ꇻꗽ䧿氁戃椅稇有洋稍礏紑稓䬕䌗堙礛礝䤟䰡礣紥笧伩堫嬭䀯搱崳䐵䰷伹崻刽п❁㉃⽅⭇⽉ᅋ", a_));
			bool flag = global::SpecialFeatures.Comms.FileProxyFactory.Instance.SetupVirtualProxy(deviceFile, deviceInfo);
			if (flag)
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뇩꿫鳭藯鳱音黵鷷裹ꇻꗽ叿省會攅洇礉缋匍䬏䄑焓戕洗標䨛眝刟嘡儣䜥䐧温䤫堭夯儱儳欵ȷᨹ漻䬽⌿⅁⅃㕅㭇", a_));
			}
			else
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뇩꿫鳭藯鳱音黵鷷裹ꇻꗽ䗿瀁瘃椅稇圉國崍甏昑愓昕丗猙減樝唟䌡䠣戥䴧尩䔫䴭唯漱ำᘵ縷嬹唻刽┿♁", a_));
			}
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뇩꿫鳭藯鳱音黵鷷裹ꇻꗽ䧿氁戃椅稇有洋稍礏紑稓䬕䌗弙爛稝紟礡眣䌥尧弩尫砭夯䀱䀳䌵夷嘹砻嬽㘿⭁❃⍅ᕇ", a_));
			return flag;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000F1204 File Offset: 0x000EF404
		private bool CruncherImport(global::MackinawCPS.CommandLineCPS.CruncherOperation operation)
		{
			int a_ = 0;
			short num = (short)1364525056;
			switch (num)
			{
			default:
				for (;;)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍刏眑猓缕瘗䜙䜛崝刟圡䨣䔥䀧伩師札崯䈱嬳䐵䰷朹", a_));
					global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData = new global::Motorola.CommonCPS.Server.EntityModel.CruncherData();
					bool result;
					try
					{
						num = (short)86507523;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide dvrswide = global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
								num = (short)1264648198;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_2E4;
							case 2:
								this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵諷裹鏻賽巿夁䜃琅紇搉漋昍甏怑崓笕栗甙減樝紟ᠡУ", a_) + operation.inputFile);
								cruncherData.ErrorCode = new int?(22018);
								this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Fail);
								result = false;
								num = (short)1884553223;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_12F;
								}
								continue;
							case 4:
								goto IL_324;
							case 5:
							{
								uint num3 = new global::SpecialFeatures.DVRSXML.DvrsMsuDataSync().CalculateHashCode();
								global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide dvrswide;
								dvrswide.General.DVRSWideLabtoolDVRSSyncFieldsHash_A41811.SetValue((long)((ulong)num3));
								num = (short)1136590849;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide dvrswide;
								if (dvrswide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
								{
									num = (short)2092433413;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2E4;
							}
							case 7:
								goto IL_1D3;
							case 8:
								if (!global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UiHasFields)
								{
									num = (short)479461376;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_173;
							}
							IL_12F:
							global::MackinawCPS.WindowMain windowMain = (global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow;
							string empty = string.Empty;
							if (!windowMain.OpenCodeplug(global::System.IO.Path.GetFullPath(operation.inputFile), ref empty, false))
							{
								num = (short)772997122;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							(global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralCodeplugVersion_A7683.Value = global::AcpCommonLib.AppInfoManager.AppVersion;
							num = (short)1500708872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2E4:
							this.PackImportXPBA(ref cruncherData);
							cruncherData.ErrorCode = null;
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳ꗵ跷駹鿻鯽珿焁夃崅䬇砉礋怍猏稑焓搕儗眙氛焝刟嘡礣ᰥࠧ欩師䴭堯嬱䈳匵ᠷ猹儻丽⼿ぁぃ晅⭇╉⅋㹍㱏㝑⁓㍕㱗", a_));
							num = (short)769589252;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_173:
						throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_The_codeplug_contains_invalid_fields));
						IL_1D3:
						return result;
						IL_324:
						goto IL_47;
					}
					catch (global::Motorola.Common.CustomException.CommonException ex)
					{
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵胷駹駻軽瓿欁欃栅唇儉伋簍攏簑眓縕紗栙唛猝借䴡嘣別甧ဩఫ", a_) + ex.Message);
						cruncherData.ErrorCode = new int?((int)ex.ErrorCode);
						this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Fail);
						goto IL_47;
					}
					catch (global::System.Exception ex2)
					{
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵胷駹駻軽瓿欁欃栅唇儉伋簍攏簑眓縕紗栙唛猝借䴡嘣別甧ဩఫ", a_) + ex2.Message);
						cruncherData.ErrorCode = new int?(22017);
						this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Fail);
						goto IL_47;
					}
					finally
					{
						global::MackinawCPS.CommandLineCPS.ObjectSerializer.DataContract_SerializeToFile(operation.targetFile, cruncherData);
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍唏簑瀓䬕䌗夙減欝丟䄡䰣䌥娧挩䄫席弯䀱䀳欵", a_));
					}
					return result;
					IL_47:
					num = (short)517341184;
					short num4 = num;
					num = (short)2038268104;
					short num5 = num;
					num = (short)1379565768;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A5;
					}
				}
				IL_A5:
				num = (short)483917825;
				if (num != 0)
				{
				}
				num = (short)478674944;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000F1628 File Offset: 0x000EF828
		private void DeleteTempFile(string filePath)
		{
			int a_ = 3;
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)587333633;
						if (num2 != 0)
						{
						}
						if (!global::System.IO.File.Exists(filePath))
						{
							goto IL_177;
						}
						num2 = (short)568400156;
						short num3 = num2;
						num2 = (short)2137594140;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3D;
						default:
							num2 = (short)1480851456;
							if (num2 != 0)
							{
							}
							num2 = (short)955711490;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_CA;
					case 2:
						try
						{
							global::System.IO.File.Delete(filePath);
							goto IL_177;
						}
						catch (global::System.Exception ex)
						{
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꛤ闦鳨藪軬蟮铰臲ꣴ곶본菺黼髾焀眂氄栆月嘊嘌䬎琐缒瀔挖簘会砜爞儠攢䰤䬦䰨瘪ᜬ༮", a_) + ex.Message);
							goto IL_177;
						}
						goto IL_CA;
					case 3:
						if (filePath != null)
						{
							num2 = (short)1044250624;
							short num4 = num2;
							num2 = (short)1213399041;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_177;
					}
					goto IL_29;
					IL_CA:
					num2 = (short)1574961152;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_177:
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꛤ闦鳨藪軬蟮铰臲ꣴ곶냸闺鯼郾猀渂搄猆怈搊挌刎䨐嘒笔猖䐘䀚夜稞䴠䘢儤䈦紨个䀬弮眰娲头制搸", a_));
				return;
			}
			IL_29:
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꛤ闦鳨藪軬蟮铰臲ꣴ곶냸闺鯼郾猀渂搄猆怈搊挌刎䨐儒瀔瀖瀘甚䀜䐞攠䘢䤤䈦崨个礬䨮尰䌲猴帶唸帺怼", a_));
			IL_3D:
			num2 = (short)652476419;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000F17D0 File Offset: 0x000EF9D0
		private bool CruncherWrite(string inputFile)
		{
			int a_ = 1;
			short num = (short)352452608;
			switch (num)
			{
			default:
			{
				num = (short)65404929;
				if (num != 0)
				{
				}
				num = (short)1896349696;
				short num2 = num;
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뫠ꃢ韤鋦蟨裪藬諮菰껲껴뻶韸鷺鋼跾氀戂焄渆昈攊倌后匐瘒爔縖眘䘚䘜尞匠嘢䬤䐦䄨个弬砮䌰娲䄴制搸", a_));
				string text = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쿠転蛤", a_));
				try
				{
					num = (short)895680516;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						long num4;
						switch (num3)
						{
						case 0:
							num4 = this.WriteJobProcess_RestoreJob();
							num = (short)1522270210;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_167;
						case 2:
							goto IL_167;
						case 3:
							goto IL_1F9;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_FB;
							}
							continue;
						}
						IL_FB:
						if (this.operation.cruncherData.IsRestoreJob)
						{
							num = (short)1532952576;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = this.WriteJobProcess_OtherTypesOfJob(inputFile, text);
						num = (short)2042429441;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_167:
						this.operation.cruncherData.pbaFile = global::Motorola.Common.CommonLib.CombineTool.Encode(this.operation.targetFile, (int)num4, this.operation.deviceInfo);
						this.operation.cruncherData.ErrorCode = null;
						this.EndExecuteCommand(this.operation.cruncherData);
						global::MackinawCPS.CommandLineCPS.ObjectSerializer.DataContract_SerializeToFile(inputFile, this.operation.cruncherData);
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뫠ꃢ韤鋦蟨裪藬諮菰껲껴ꓶ賸飺黼髾爀瀂堄将䨈礊砌愎爐笒瀔攖丘椚琜欞䐠縢ἤܦ樨䜪䈬䄮吰ጲ䜴嘶崸刺刼Ἶ⑀㭂㕄㕆ⱈ㡊㹌潎㉐㱒㡔❖㕘㹚⥜㩞ՠ", a_));
						num = (short)57081859;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1F9:;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					if (!(ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write))
					{
						num = (short)1583317312;
						short num5 = num;
						num = (short)225608000;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1216151552;
							if (num != 0)
							{
							}
							this.CreateErrorOutput(inputFile, (int)ex.ErrorCode);
							goto IL_27C;
						}
					}
					this.CreateErrorOutput(inputFile, 22024);
					IL_27C:;
				}
				catch (global::System.Exception ex2)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뫠ꃢ韤鋦蟨裪藬諮菰껲껴닶臸飺飼迾甀樂樄椆合倊丌紎搐紒瘔编簘椚䨜洞䠠圢䀤稦ጨପ", a_) + ex2.Message);
					if (ex2.Message == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟠苢賤详賨迪췬鯮黰폲铴蟶觸韺蓼\udffe戀氂愄戆礈朊砌栎ㄐ瀒稔笖氘瘚猜氞", a_))
					{
						this.CreateErrorOutput(inputFile, 22010);
					}
					else if (ex2.Message == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟠苢賤详賨迪췬鯮黰폲髴蟶鳸闺\uddfc课搀渂甄欆栈缊栌⼎瀐愒瘔编瀘洚砜", a_))
					{
						this.CreateErrorOutput(inputFile, 22012);
					}
					else if (ex2.Message == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋠ賢裤韦裨鿪蓬跮飰鿲鳴菶胸\udbfa飼跾猀氂眄⤆", a_))
					{
						this.CreateErrorOutput(inputFile, 22023);
					}
					else if (ex2.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
					{
						this.CreateErrorOutput(inputFile, 22024);
					}
					else
					{
						this.CreateErrorOutput(inputFile, 22005);
					}
					this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Fail);
				}
				finally
				{
					this.DeleteTempFile(text);
					this.DeleteTempFile(this.operation.sourceFile);
					this.DeleteTempFile(this.operation.targetFile);
					this.DeleteTempFile(this.operation.targetArchive);
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뫠ꃢ韤鋦蟨裪藬諮菰껲껴뻶韸鷺鋼跾氀戂焄渆昈攊倌后吐紒焔䨖䈘堚漜樞传䀢䴤䈦嬨簪弬䘮䔰嘲栴", a_));
				}
				return true;
			}
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000F1BE4 File Offset: 0x000EFDE4
		private long WriteJobProcess_RestoreJob()
		{
			int a_ = 18;
			short num = (short)1338114048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject2;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_108;
					case 1:
					{
						num = (short)1079105707;
						short num3 = num;
						num = (short)1602082987;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_108;
						case 1:
							break;
						default:
						{
							num = (short)1471217664;
							short num4 = num;
							break;
						}
						}
						num = (short)927989760;
						if (num != 0)
						{
						}
						if (pbaObject.ValidationInfos == null)
						{
							num = (short)306118659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23F;
					}
					case 2:
						goto IL_157;
					case 3:
						pbaObject.ValidationInfos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo>();
						num = (short)440598530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!this.ReadMC(this.operation.targetArchive))
						{
							num = (short)75956224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> validationFields = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateWriteValidationFields(pbaObject2);
						this.UpdatePasswordValidationFields(validationFields);
						pbaObject.ValidationFields = validationFields;
						this.HandleLP(pbaObject2, pbaObject);
						num = (short)267649025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4B;
				}
				IL_108:
				num = (short)263782401;
				if (num != 0)
				{
				}
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("등闳鿵铷鿹飻\udefd瓿洁␃椅砇漉戋⸍搏眑礓昕琗笙栛笝\u001f䌡嘣䔥䀧䌩娫䬭", a_));
				IL_157:
				IL_23F:
				global::Motorola.CommonCPS.Server.EntityModel.Codeplug lastCodeplug;
				pbaObject.ValidationInfos.Add(new global::Motorola.Common.Communication.Pba.ValidationInfo(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇱ鯳郵賷跹鷻賽旿吁愃琅笇按挋怍", a_), lastCodeplug.FirmwareVersion, global::Motorola.Common.Communication.Pba.ValidationMethod.Equal));
				pbaObject.IsRetoreJob = true;
				return pbaObject.Serialize(this.operation.targetFile);
				IL_4B:
				global::System.Collections.Generic.List<byte[]> list = global::Motorola.Common.CommonLib.CombineTool.Decode(this.operation.cruncherData.RestoreTargetPbaFile);
				global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo = (global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo)global::Motorola.Common.CommonLib.CombineTool.ByteArrayToObject(list[1]);
				pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(list[0], false);
				global::System.Collections.Generic.List<byte[]> list2 = global::Motorola.Common.CommonLib.CombineTool.Decode(this.operation.cruncherData.pbaFile);
				global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo2 = (global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo)global::Motorola.Common.CommonLib.CombineTool.ByteArrayToObject(list2[1]);
				pbaObject2 = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(list2[0], false);
				lastCodeplug = this.operation.cruncherData.LastCodeplug;
				num = (short)765984772;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000F1E70 File Offset: 0x000F0070
		private void UpdatePasswordValidationFields(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> validationFields)
		{
			short num = (short)1181351936;
			switch (num)
			{
			default:
			{
				num = (short)1576140801;
				if (num != 0)
				{
				}
				num = (short)1151729679;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> list2;
					byte[] array;
					int num5;
					byte b;
					switch (num2)
					{
					case 0:
						text = string.Empty;
						goto IL_3B4;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> list = validationFields.Where(delegate(global::Motorola.Common.Communication.Pba.ValidationField a)
						{
							short num7 = (short)1740111875;
							int num8 = (int)((global::System.IntPtr)num7);
							for (;;)
							{
								switch (num8)
								{
								case 0:
									goto IL_13D;
								case 1:
								{
									num7 = (short)2054160384;
									short num9 = num7;
									num7 = (short)1240208754;
									short num10 = num7;
									num7 = (short)510793074;
									switch ((num10 == num7) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_14;
									default:
										num7 = (short)512557056;
										if (num7 != 0)
										{
										}
										num7 = (short)1213136898;
										num8 = (int)((global::System.IntPtr)num7);
										continue;
									}
									break;
								}
								case 2:
									if (a.OffsetInBits == 16U)
									{
										num7 = (short)1570242560;
										num8 = (int)((global::System.IntPtr)num7);
										continue;
									}
									return false;
								case 3:
									goto IL_14;
								}
								goto IL_5C;
								IL_14:
								num7 = (short)896466945;
								if (num7 != 0)
								{
								}
								switch (0)
								{
								case 0:
									IL_5C:
									if (a.BlockType != 1029)
									{
										return false;
									}
									num7 = (short)2128674817;
									num8 = (int)((global::System.IntPtr)num7);
									break;
								}
							}
							IL_13D:
							return a.LengthInBits == 528U;
						}).ToList<global::Motorola.Common.Communication.Pba.ValidationField>();
						text = (this.operation.cruncherData.Radio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).ReadPassword;
						num = (short)104857609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_146;
					case 3:
						num = (short)104267792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_186;
					case 5:
						if (list2 != null)
						{
							num = (short)811008003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA;
					case 6:
					{
						int num3;
						if (1 == num3 >> 6)
						{
							num = (short)163315722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
						goto IL_FA;
					case 8:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> list;
						list[0].ErrorToThrow = global::Motorola.Common.CustomException.CommonErrorCode.PasswordValidationFails;
						list[0].Content = array;
						num = (short)2037907470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						if (string.IsNullOrEmpty(text))
						{
							num = (short)816119808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1761280000;
						short num4 = num;
						text = new global::SpecialFeatures.ReadWritePassword.ReadWriteUtil().encryptMesg(text);
						num = (short)1837760516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)1416560641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_146;
					case 12:
						goto IL_186;
					case 13:
						if (num5 >= array.Length)
						{
							num = (short)1741422600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num5] = b;
						num5++;
						num = (short)1310523403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_AF;
						}
						continue;
					case 16:
					{
						if (list2.Count == 0)
						{
							num = (short)828637191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3 = (int)(list2[0].Content[0] & 64);
						num = (short)588578822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_AF;
					IL_146:
					num = (short)425459725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_186:
					array = new byte[66];
					byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(text);
					bytes.CopyTo(array, 0);
					b = 0;
					num5 = bytes.Length;
					num = (short)2021654530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AF:
					list2 = validationFields.Where(delegate(global::Motorola.Common.Communication.Pba.ValidationField a)
					{
						short num7 = (short)780861443;
						int num8 = (int)((global::System.IntPtr)num7);
						for (;;)
						{
							switch (num8)
							{
							case 0:
								goto IL_13C;
							case 1:
							{
								num7 = (short)561264341;
								short num9 = num7;
								num7 = (short)923416277;
								switch ((num9 == num7) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_14;
								default:
									num7 = (short)1527185408;
									if (num7 != 0)
									{
									}
									num7 = (short)318504962;
									num8 = (int)((global::System.IntPtr)num7);
									continue;
								}
								break;
							}
							case 2:
								num7 = (short)569114625;
								if (num7 != 0)
								{
								}
								if (a.OffsetInBits == 9U)
								{
									num7 = (short)654245888;
									num8 = (int)((global::System.IntPtr)num7);
									continue;
								}
								return false;
							case 3:
								goto IL_14;
							}
							goto IL_34;
							IL_14:
							switch (0)
							{
							case 0:
								IL_34:
								if (a.BlockType != 1029)
								{
									return false;
								}
								num7 = (short)344326145;
								num8 = (int)((global::System.IntPtr)num7);
								break;
							}
						}
						IL_13C:
						num7 = (short)1474297856;
						short num10 = num7;
						return a.LengthInBits == 1U;
					}).ToList<global::Motorola.Common.Communication.Pba.ValidationField>();
					num = (short)1285816325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B4:
					num = (short)545652748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FA:
					num = (short)1174036071;
					short num6 = num;
					num = (short)1104830055;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B4;
					default:
						goto IL_12F;
					}
				}
				IL_12F:
				num = (short)761397248;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000F227C File Offset: 0x000F047C
		private long WriteJobProcess_OtherTypesOfJob(string inputFile, string outputArchive)
		{
			int a_ = 1;
			short num = (short)360972288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_197;
				}
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
				string text;
				global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo;
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject3;
				for (;;)
				{
					IL_30:
					int? changeIndicator;
					int? num4;
					int num5;
					global::SpecialFeatures.Flashport.FlashRadio.FlashCodeplug flashCodeplug;
					string modelNumber;
					string text2;
					bool flag3;
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject2;
					global::System.IO.FileStream fileStream;
					int? num6;
					int? num8;
					global::SpecialFeatures.Comms.RadioIdInfo tempRadioIds;
					global::SpecialFeatures.CloneWizard.PageCloneWizard pageCloneWizard;
					global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio upgradeRadio;
					int? num10;
					bool flag5;
					string postFlashCodeplugFields;
					switch (num2)
					{
					case 0:
						num = (short)2040987711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1045430313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_D73;
					case 3:
					{
						bool? flag;
						bool flag2;
						if (!(flag.GetValueOrDefault() == flag2 & flag != null))
						{
							num = (short)1815019557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8B2;
					}
					case 4:
						if (pbaObject == null)
						{
							num = (short)781058067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_982;
					case 5:
						goto IL_3EB;
					case 6:
					{
						int num3;
						if (num3 != -1)
						{
							num = (short)1882914829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114D;
					}
					case 7:
						if (changeIndicator == null)
						{
							num = (short)700514360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1901396010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1088487469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						(global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralSerialNumber_A9122.SetValue(text);
						num = (short)1594294288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!(num4.GetValueOrDefault() == num5 & num4 != null))
						{
							num = (short)1407516753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BD2;
					case 11:
					{
						bool isModelNumberUpgrade;
						if (!flashCodeplug.UpgradeCodeplug(modelNumber, text2, isModelNumberUpgrade, false, null))
						{
							num = (short)767361077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BD2;
					}
					case 12:
						goto IL_D2D;
					case 13:
					{
						int num3;
						string text4;
						string text3 = text3.Substring(num3 + text4.Length);
						num = (short)2113798213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (global::SpecialFeatures.Flashport.FlashDataManager.FlashDoc != null)
						{
							num = (short)397082651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_476;
					case 15:
						goto IL_583;
					case 16:
						goto IL_ECF;
					case 17:
						if (!flag3)
						{
							num = (short)1619525675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pbaObject2.ValidationFields = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateWriteValidationFields(pbaObject);
						num = (short)1992818775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1258029113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFrom(this.operation.targetFile);
						num = (short)618987570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (this.operation.Type == global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.UPGRADE)
						{
							num = (short)1797783616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C1C;
					case 21:
						if (this.operation.Type == global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.UPGRADE)
						{
							num = (short)133038140;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13AB;
					case 22:
						if (changeIndicator == null)
						{
							num = (short)1042481207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)733806622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						this.SetupVirtualDevice(this.operation.targetFile, this.operation.deviceInfo);
						num = (short)1090977807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						try
						{
							this.operation.cruncherData.arvFile = new byte[fileStream.Length];
							fileStream.Read(this.operation.cruncherData.arvFile, 0, this.operation.cruncherData.arvFile.Length);
						}
						finally
						{
							num = (short)1154285570;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)1998979073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1241;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1208;
									}
									continue;
								}
								IL_1208:
								if (fileStream == null)
								{
									break;
								}
								num = (short)1506344960;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1241:;
						}
						astroDeviceInfo = null;
						num = (short)768868373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_13AB;
					case 26:
						if (this.operation.Type == global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.UPGRADE)
						{
							num = (short)1696989222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2D;
					case 27:
						global::SpecialFeatures.Flashport.FlashDataManager.FlashDoc.Clear();
						num = (short)1818492963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (num4 == null)
						{
							num = (short)1421213725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pbaObject3 = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFrom(this.operation.targetFile);
						this.HandleLP(pbaObject, pbaObject3);
						this.UpdatePasswordValidationFields(pbaObject3.ValidationFields);
						num = (short)1884422222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_13FB;
					case 30:
						num6 = new int?(changeIndicator.GetValueOrDefault() & 2);
						goto IL_723;
					case 31:
						num = (short)878116926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_C1C;
					case 33:
					{
						int? num7 = null;
						num = (short)169541697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						goto IL_E56;
					case 35:
						goto IL_476;
					case 36:
					{
						int? num7;
						num8 = num7;
						goto IL_AEA;
					}
					case 37:
					{
						bool? flag = this.operation.fwPackageDesc.IsOMAPFirmwareUpgradeFile;
						bool flag2 = true;
						num = (short)839319598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						tempRadioIds.IsManagedUpgrade = true;
						num = (short)556335116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (!this.ReadMC(this.operation.targetArchive))
						{
							num = (short)1868496950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pageCloneWizard = new global::SpecialFeatures.CloneWizard.PageCloneWizard();
						global::SpecialFeatures.Comms.CloneParameters.CloneWriteType = global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE;
						tempRadioIds = this.ApplyCodeplugAndDeviceColumnsInWrite(this.operation.cruncherData.Radio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio, this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, this.operation.cruncherData.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
						num = (short)1450967066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_90A;
					case 41:
						if (this.operation.Type != global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.ARCHIVECLONE)
						{
							num = (short)1974337567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E56;
					case 42:
						num8 = new int?(changeIndicator.GetValueOrDefault() & 16);
						goto IL_AEA;
					case 43:
						pbaObject2.ValidationFields = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateUpgradeValidationFields(pbaObject);
						num = (short)619380804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						goto IL_104C;
					case 45:
					{
						if (!this.ReadMC(this.operation.sourceFile))
						{
							num = (short)202637363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
						radioInformation.General.RadInfoGeneralSerialNumber_A9122.SetValue(this.operation.cruncherData.Radio.SerialNumber);
						this.operation.deviceInfo.CodeplugVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
						this.operation.deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
						this.operation.deviceInfo.ModelNumber = radioInformation.General.RadInfoGeneralModelNumber_A8539.Value;
						this.operation.deviceInfo.SerialNumber = global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(radioInformation.General.RadInfoGeneralSerialNumber_A9122.Value));
						this.operation.deviceInfo.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
						this.operation.deviceInfo.ConnectionInfo.UniqueAddress = dataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.UIValue;
						this.operation.deviceInfo.SoftwareVersion = radioInformation.General.RadInfoGeneralFirmwareVersion_A8124.Value;
						this.operation.deviceInfo.ESN = global::Common.AESCryptoUtil.CIPHER_DEF_KEY;
						text = radioInformation.General.RadInfoGeneralSerialNumber_A9122Value;
						num = (short)1359216641;
						if (num != 0)
						{
						}
						num = (short)355663931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1785462842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						upgradeRadio.IsRadioTakesBBF = false;
						num = (short)102236246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_1018;
					case 48:
						changeIndicator = this.operation.cruncherData.Codeplug.ChangeIndicator;
						num = (short)997261334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						bool flag4;
						if (flag4)
						{
							num = (short)662831187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_104C;
					}
					case 50:
						goto IL_982;
					case 51:
						goto IL_221;
					case 52:
					{
						bool flag4;
						if (!flag4)
						{
							num = (short)394461256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1161;
					}
					case 53:
						goto IL_BBC;
					case 54:
						goto IL_C60;
					case 55:
					{
						int? num7 = null;
						num = (short)494075989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
					{
						int? num7 = null;
						num = (short)1911750692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
						if (this.operation.deviceInfo != null)
						{
							num = (short)352714775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56F;
					case 58:
						goto IL_8B2;
					case 59:
						if (!this.SaveXPBA(this.operation.targetFile))
						{
							num = (short)515964933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow).CloseFile();
						num = (short)1592590350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						num = (short)1271726080;
						short num9 = num;
						pbaObject2 = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFrom(this.operation.targetFile);
						num = (short)1211301905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
						if (this.operation.Type != global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.WRITE)
						{
							num = (short)332333057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E56;
					case 62:
					{
						if (this.operation.Type == global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.UPGRADE)
						{
							num = (short)1027145762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag4 = false;
						num = (short)1304035372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
						if (this.operation.targetFile != null)
						{
							num = (short)1807679506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56F;
					case 64:
					{
						upgradeRadio.fileHostVersion = this.operation.fwPackageDesc.SoftwareVersion;
						bool? flag = this.operation.fwPackageDesc.IsFreonFirmwareUpgradeFile;
						bool flag2 = true;
						num = (short)1005387779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 65:
					{
						int? num7;
						num10 = num7;
						goto IL_634;
					}
					case 66:
						if (num4.GetValueOrDefault() == num5 & num4 != null)
						{
							num = (short)1304756272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)900005958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						try
						{
							bool flag4 = pageCloneWizard.CommandLineCPSCloneProcedure();
						}
						catch (global::System.Exception ex)
						{
							if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
							{
								num = (short)1483997695;
								short num11 = num;
								num = (short)250085887;
								switch ((num11 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)537395200;
									if (num != 0)
									{
									}
									global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
									throw new global::System.ApplicationException(global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write);
								}
							}
						}
						num = (short)318963761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_134C;
					case 69:
					{
						string text3;
						if (pageCloneWizard.StatusOfClone.Contains(text3))
						{
							num = (short)536936519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1161;
					}
					case 70:
						flag5 = false;
						goto IL_774;
					case 71:
						goto IL_1137;
					case 72:
					{
						string text3 = global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio;
						string text4 = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("髠폢飤", a_);
						int num3 = text3.IndexOf(text4);
						num = (short)1747124230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 73:
						if (this.operation.Type == global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.ARCHIVECLONE)
						{
							num = (short)1224540168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					case 74:
						if (this.legalCommandLine)
						{
							num = (short)1541865472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56F;
					case 75:
						if (text != null)
						{
							num = (short)266600457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ECF;
					case 76:
						num10 = new int?(changeIndicator.GetValueOrDefault() & 16);
						goto IL_634;
					case 77:
					{
						if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.HasFields)
						{
							num = (short)513736706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag4 = false;
						num = (short)1999568957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 78:
						goto IL_144A;
					case 79:
						flag5 = !(num4.GetValueOrDefault() == num5 & num4 != null);
						goto IL_774;
					case 80:
					{
						global::MackinawCPS.WindowMain windowMain = (global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow;
						windowMain.CloseFile();
						if (global::SpecialFeatures.Flashport.FlashDataManager.FlashDoc != null)
						{
							global::SpecialFeatures.Flashport.FlashDataManager.FlashDoc.Clear();
						}
						if (!windowMain.CruncherReadRadio(0, true))
						{
							num = (short)1432420399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_104C;
					}
					case 81:
					{
						byte[] astroPurchasedFlashCode = (this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AstroPurchasedFlashCode;
						text2 = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(astroPurchasedFlashCode, astroPurchasedFlashCode.Length);
						postFlashCodeplugFields = (this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).iButtonSerialNumber;
						num = (short)1443954699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 82:
						if (changeIndicator == null)
						{
							num = (short)1763704865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1970470988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						num = (short)1737293904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
					{
						try
						{
							modelNumber = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539Value;
						}
						catch (global::System.Exception)
						{
						}
						upgradeRadio.PreUpgradeCodeplugHandler();
						this.SetRequiredFirmwareVersion(this.operation, upgradeRadio);
						text2 = "";
						bool isModelNumberUpgrade = false;
						postFlashCodeplugFields = "";
						changeIndicator = this.operation.cruncherData.Codeplug.ChangeIndicator;
						num = (short)1433993223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
					{
						int? num7;
						num6 = num7;
						goto IL_723;
					}
					case 86:
						goto IL_90A;
					case 87:
						goto IL_134C;
					}
					goto IL_197;
					IL_476:
					num = (short)1938686026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_583:
					pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFrom(this.operation.targetFile);
					changeIndicator = this.operation.cruncherData.Codeplug.ChangeIndicator;
					num = (short)368902226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_634:
					num4 = num10;
					num5 = 0;
					num = (short)1670250562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_723:
					num4 = num6;
					num5 = 0;
					num = (short)100794447;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_774:
					flag3 = flag5;
					upgradeRadio = new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio(null, flag3, this.operation.deviceInfo, this.operation.fwPackageDesc, this.operation.fwPackagePath);
					num = (short)586874900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8B2:
					upgradeRadio.BBFBundleVersion = this.operation.fwPackageDesc.BPSoftwareVersion;
					upgradeRadio.IsRadioTakesBBF = true;
					num = (short)1012662312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_90A:
					upgradeRadio.RadioHostVersion = this.operation.deviceInfo.SoftwareVersion;
					num = (short)1674641412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_982:
					upgradeRadio.Connect();
					upgradeRadio.BeginFlashUpgrade();
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioCodeplug = upgradeRadio.ReadCodeplug();
					global::AcpCommonLib.AppInfoManager.DragOperation = true;
					((global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow).DocumentOperations.InitDocument();
					((global::MackinawCPS.App)global::System.Windows.Application.Current).TheDocument.FileNew();
					upgradeRadio.UnpackCodeplug(radioCodeplug);
					flashCodeplug = new global::SpecialFeatures.Flashport.FlashRadio.FlashCodeplug();
					flashCodeplug.postCodeplugInitialization();
					modelNumber = "";
					num = (short)1323434068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AEA:
					num4 = num8;
					num5 = 0;
					num = (short)924581898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BD2:
					upgradeRadio.PostUpgradeCodeplugHandler(text2);
					upgradeRadio.ApplyModelTiering();
					global::AcpCommonLib.ConstraintManager.Suspend();
					flashCodeplug.SetPostFlashCodeplugFields(postFlashCodeplugFields);
					this.SaveXPBA(this.operation.targetFile);
					num = (short)1770979360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C1C:
					num = (short)1856569383;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D2D:
					pageCloneWizard.SaveRadioIdsInCruncher(tempRadioIds);
					num = (short)1904214093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E56:
					num = (short)2128216139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ECF:
					num = (short)722731075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_104C:
					num = (short)1476198452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1161:
					this.SaveMC(outputArchive);
					fileStream = global::System.IO.File.OpenRead(outputArchive);
					num = (short)1616445464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_134C:
					pbaObject2.ValidationInfos = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateUpgradeValidationInfos(pbaObject, this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, flag3);
					pbaObject2.UpdateData = upgradeRadio.BuildUpdateDataForCruncher(out astroDeviceInfo);
					pbaObject2.Serialize(this.operation.targetFile);
					num = (short)1563295769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13AB:
					num4 = this.operation.cruncherData.Codeplug.ChangeIndicator;
					num = (short)1223688220;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_221:
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟠苢賤详賨迪췬鯮黰폲髴蟶鳸闺\uddfc课搀渂甄欆栈缊栌⼎瀐愒瘔编瀘洚砜", a_));
				IL_3EB:
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛠釢賤鏦賨쯪苬鷮퇰냲駴飶韸黺\uddfc跾怀朂氄栆⤈洊氌明紐瘒焔", a_));
				IL_56F:
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟠苢賤详賨迪췬鯮黰폲髴蟶鳸闺\uddfc课搀渂甄欆栈缊栌⼎瀐愒瘔编瀘洚砜", a_));
				IL_BBC:
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋠ賢臤苦駨蟪飬裮퇰蛲藴郶诸髺駼髾℀攂搄渆攈渊椌ℎ", a_));
				IL_C60:
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟠苢賤详賨迪췬鯮黰폲髴蟶鳸闺\uddfc课搀渂甄欆栈缊栌⼎瀐愒瘔编瀘洚砜", a_));
				IL_D73:
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟠苢賤详賨迪췬鯮黰폲铴蟶觸韺蓼\udffe戀氂愄戆礈朊砌栎ㄐ瀒稔笖氘瘚猜氞", a_));
				IL_1018:
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋠ苢诤触蛨鿪췬鷮铰鋲釴ퟶ跸鏺飼\udffe焀愂搄✆漈戊愌樎", a_));
				IL_1137:
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋠ賢裤韦裨鿪蓬跮飰鿲鳴菶胸\udbfa飼跾猀氂眄⤆", a_));
				IL_114D:
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛠釢賤鏦賨쯪苬鷮퇰냲駴飶韸黺\uddfc跾怀朂氄栆⤈洊氌明紐瘒焔", a_));
				IL_13FB:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AstroCruncherInputfileError);
				IL_144A:
				long result = pbaObject3.Serialize(this.operation.targetFile);
				if (astroDeviceInfo != null)
				{
					this.operation.deviceInfo = astroDeviceInfo;
				}
				if (pbaObject != null)
				{
					this.operation.deviceInfo.ConnectionInfo.SessionID = pbaObject.CodeplugData.ArchiveSessionID;
				}
				global::MackinawCPS.CommonUtility.PopulatecpAndDeviceColumnsFromDatabaseLayerForCruncherWrite(this.operation.cruncherData, this.operation.Type);
				return result;
				IL_197:
				text = null;
				num = (short)534052937;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x000F3764 File Offset: 0x000F1964
		public void SetRequiredFirmwareVersion(global::MackinawCPS.CommandLineCPS.CruncherOperation operation, global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio upgrade)
		{
			int a_ = 15;
			short num;
			try
			{
				num = (short)1016922112;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					for (;;)
					{
						IL_31:
						int? num4;
						int? num6;
						int num7;
						switch (num2)
						{
						case 0:
							if (operation != null)
							{
								num = (short)1081737222;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_31D;
						case 1:
						{
							int? changeIndicator;
							if (changeIndicator == null)
							{
								num = (short)571867146;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1102905352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							int? changeIndicator = operation.cruncherData.Codeplug.ChangeIndicator;
							num = (short)2142240769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (upgrade != null)
							{
								num = (short)2085224450;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_31D;
						case 4:
							num = (short)865730576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo = null;
							num = (short)2095185932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_198;
						case 7:
						{
							num = (short)1264755782;
							short num3 = num;
							num = (short)1776919622;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_198;
							default:
								goto IL_36B;
							}
							break;
						}
						case 8:
						{
							int? changeIndicator;
							num4 = new int?(changeIndicator.GetValueOrDefault() & 2);
							goto IL_246;
						}
						case 9:
							num = (short)407109643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							int? num5 = null;
							num = (short)1080492047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							if (operation.fwPackageDesc != null)
							{
								num = (short)799342596;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_31D;
						case 12:
						{
							global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo;
							if (upgrade.BuildUpdateDataForCruncher(out astroDeviceInfo).MemoryImages.Any<global::Motorola.Common.Communication.Pba.RadioImage>())
							{
								num = (short)652214285;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_31D;
						}
						case 13:
							radioWide.Labtool.RadioWideReqFWVersion_A42872.SetValue(operation.fwPackageDesc.SoftwareVersion);
							num = (short)183369742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_31D;
						case 15:
						{
							int? num5;
							num4 = num5;
							goto IL_246;
						}
						case 16:
							if (!string.IsNullOrEmpty(operation.fwPackageDesc.SoftwareVersion))
							{
								num = (short)927072261;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_31D;
						case 17:
							if (!(num6.GetValueOrDefault() == num7 & num6 != null))
							{
								num = (short)120061961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_31D;
						}
						goto IL_80;
						IL_198:
						num = (short)1562247171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_246:
						num6 = num4;
						num7 = 0;
						num = (short)1424556049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_31D:
						num = (short)206176263;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_36B:
					num = (short)666894336;
					if (num != 0)
					{
					}
					break;
					IL_80:
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					radioWide.Labtool.RadioWideReqFWVersion_A42872.SetValue("");
					num = (short)150470656;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::System.Exception)
			{
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꧮ郰髲駴鋶鷸\udbfa觼郾℀瀂怄猆⤈夊栌縎搐稒朔爖紘㬚嬜瘞匠丢判䘦嬨个ബ礮吰䄲䘴帶嘸唺ጼ", a_));
			}
			num = (short)1434779648;
			short num8 = num;
			num = (short)1702690817;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000F3B78 File Offset: 0x000F1D78
		private void HandleLP(global::Motorola.Common.Communication.Pba.PbaObject oldPBAObject, global::Motorola.Common.Communication.Pba.PbaObject pbaObject_HandleLP)
		{
			short num = (short)638976000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C2;
				}
				int? changeIndicator;
				bool flag;
				global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.IsRadioUpgradeHostGreaterThan_7_12(this.operation.cruncherData.LastCodeplug.FirmwareVersion, this.operation.fwPackageDesc.SoftwareVersion))
						{
							num = (short)508624901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_720;
					case 1:
						num = (short)1372782592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_28A;
					case 3:
						goto IL_60A;
					case 4:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = (this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).ASTROLanguagePack;
						num = (short)122683419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						pbaObject_HandleLP.ValidationInfos.AddRange(global::SpecialFeatures.Comms.RadioOperationValidator.PopulateLPValidationInfos(oldPBAObject, this.operation.cruncherData.LastCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug));
						num = (short)327710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)1286144000;
						short num3 = num;
						int value = changeIndicator.Value;
						global::System.Guid? guid = null;
						if ((value & 8) != 0 || flag)
						{
							num = (short)883294212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)119144476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (this.operation.Type != global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.UPGRADE)
						{
							num = (short)1186856973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_269;
					case 8:
						if (this.operation.Type != global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.WRITE)
						{
							num = (short)566099986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_677;
					case 9:
						goto IL_7D4;
					case 10:
						goto IL_33E;
					case 11:
						goto IL_5B9;
					case 12:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
						global::System.Guid? guid = astrolanguagePack.FileUuid;
						num = (short)1661992962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)1762394120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::System.Guid? guid;
						if (guid == null)
						{
							num = (short)1646198801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_557;
					}
					case 15:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
						if (astrolanguagePack != null)
						{
							num = (short)1836580880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_557;
					}
					case 16:
						this.ValidateLanguageSetting(oldPBAObject, pbaObject_HandleLP);
						num = (short)1272315915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)176422927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						num = (short)871873095;
						short num4 = num;
						num = (short)1375386183;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4DD;
						default:
							num = (short)68878336;
							if (num != 0)
							{
							}
							num = (short)140640275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 19:
						if (this.operation.Type == global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.ARCHIVECLONE)
						{
							num = (short)713490463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_269;
					case 20:
						goto IL_3BD;
					case 21:
						goto IL_4DD;
					case 22:
						pbaObject_HandleLP.GenerateDifferetialCodeplug(oldPBAObject);
						pbaObject_HandleLP.CodeplugData.ArchiveSessionID = oldPBAObject.CodeplugData.ArchiveSessionID;
						num = (short)1579745290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						global::System.Guid? guid;
						if (guid != null)
						{
							num = (short)1023410205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1133379598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_239;
					case 25:
						languagePackData.ModelType = (global::ConstraintHelper.UtilityMack.IsPortablePro ? global::Motorola.Common.Communication.CommonUtil.ModelType.Portable : global::Motorola.Common.Communication.CommonUtil.ModelType.Mobile);
						num = (short)2094989346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_285;
					case 27:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
						if (astrolanguagePack != null)
						{
							num = (short)1152122892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28A;
					}
					case 28:
						if (oldPBAObject != null)
						{
							num = (short)379387926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pbaObject_HandleLP.CodeplugData.ArchiveSessionID = 0;
						num = (short)1863319572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						pbaObject_HandleLP.ValidationInfos = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateLPValidationInfos(oldPBAObject, this.operation.cruncherData.LastCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
						global::System.Guid? guid;
						languagePackData.LanguagePacks.Add(new global::Motorola.Common.Communication.Pba.AstroFilePackInfo
						{
							sourceFilePath = guid.Value.ToString(),
							isFlashPortUpgradeLP = false
						});
						num = (short)1347616777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						global::System.Guid? guid;
						if (guid != null)
						{
							num = (short)895221795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					}
					case 31:
						goto IL_677;
					case 32:
						if (oldPBAObject != null)
						{
							num = (short)1301807137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pbaObject_HandleLP.CodeplugData.ArchiveSessionID = 0;
						num = (short)677904408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						pbaObject_HandleLP.GenerateDifferetialCodeplug(oldPBAObject);
						pbaObject_HandleLP.CodeplugData.ArchiveSessionID = oldPBAObject.CodeplugData.ArchiveSessionID;
						num = (short)1994260501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (this.operation.Type == global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.UPGRADE)
						{
							num = (short)2021720065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_720;
					case 35:
					{
						global::System.Guid? guid;
						languagePackData.LanguagePacks.Add(new global::Motorola.Common.Communication.Pba.AstroFilePackInfo
						{
							sourceFilePath = guid.Value.ToString(),
							isFlashPortUpgradeLP = true
						});
						num = (short)398458883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						goto IL_593;
					}
					goto IL_C2;
					IL_239:
					languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
					num = (short)1284767769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DD:
					num = (short)546373633;
					if (num != 0)
					{
					}
					goto IL_239;
					IL_269:
					languagePackData = null;
					num = (short)199295002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28A:
					num = (short)1895432224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_557:
					languagePackData.LanguagePacks.Add(new global::Motorola.Common.Communication.Pba.AstroFilePackInfo
					{
						sourceFilePath = string.Empty,
						isFlashPortUpgradeLP = false
					});
					num = (short)1923809316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_677:
					num = (short)1129119767;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_720:
					num = (short)869859335;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_285:
				goto IL_390;
				IL_33E:
				goto IL_7D9;
				IL_390:
				pbaObject_HandleLP.LanguagePackData = languagePackData;
				return;
				IL_3BD:
				goto IL_7D9;
				IL_593:
				IL_5B9:
				IL_60A:
				IL_7D4:
				goto IL_390;
				IL_7D9:
				pbaObject_HandleLP.LanguagePackData = null;
				this.ValidateLanguageSetting(oldPBAObject, pbaObject_HandleLP);
				return;
				IL_C2:
				flag = (this.operation.cruncherData.pbaFile == null);
				changeIndicator = this.operation.cruncherData.Codeplug.ChangeIndicator;
				num = (short)1210449926;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000F4370 File Offset: 0x000F2570
		private void ValidateLanguageSetting(global::Motorola.Common.Communication.Pba.PbaObject oldPBAObject, global::Motorola.Common.Communication.Pba.PbaObject pbaObject_HandleLP)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.Pba.ValidationField validationField;
			int? languageIndex;
			for (;;)
			{
				IL_13:
				string firmwareVersion;
				switch (num)
				{
				case 0:
					num2 = (short)1283325964;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1409286144;
					short num3 = num2;
					if (validationField != null)
					{
						num2 = (short)1244659715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					num2 = (short)1720516609;
					if (num2 != 0)
					{
					}
					if (languageIndex.Value != 0)
					{
						num2 = (short)1068040200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					num2 = (short)732430345;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (new global::System.Text.RegularExpressions.Regex(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쇨럪觬쓮귰\uddf2꧴鏶틸ꟺ폼ꏾ攀⠂Ⰴ", a_)).Match(firmwareVersion).Success)
					{
						num2 = (short)883556352;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					goto IL_237;
				case 6:
					goto IL_2A8;
				case 7:
					validationField = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateLanguageSettingValidationField(oldPBAObject);
					num2 = (short)294977537;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1195245573;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (pbaObject_HandleLP.ValidationFields != null)
					{
						num2 = (short)559546378;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					pbaObject_HandleLP.ValidationFields = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField>();
					pbaObject_HandleLP.ValidationFields.Add(validationField);
					num2 = (short)1234567179;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_108;
				case 11:
					return;
				case 12:
					if (global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.IsNeedBindingServerLanguagePack(firmwareVersion))
					{
						num2 = (short)1290928135;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 13:
				{
					num2 = (short)1201398579;
					short num4 = num2;
					num2 = (short)1991762739;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_237;
					default:
						num2 = (short)668336128;
						if (num2 != 0)
						{
						}
						pbaObject_HandleLP.ValidationInfos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo>();
						num2 = (short)1393229830;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_51;
				IL_237:
				if (pbaObject_HandleLP.ValidationInfos == null)
				{
					num2 = (short)1443233805;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_2A8:
				pbaObject_HandleLP.ValidationInfos.AddRange(global::SpecialFeatures.Comms.RadioOperationValidator.PopulateValidationInfosForRegularWrite(oldPBAObject, this.operation.cruncherData.LastCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug));
				firmwareVersion = (this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).FirmwareVersion;
				num2 = (short)643694596;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_108:
			pbaObject_HandleLP.ValidationFields.Add(validationField);
			return;
			IL_51:
			languageIndex = (this.operation.cruncherData.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).LanguageIndex;
			num2 = (short)1183449090;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000F46BC File Offset: 0x000F28BC
		private bool CruncherCreate(string inputFile)
		{
			int a_ = 9;
			short num = (short)24576001;
			if (num != 0)
			{
			}
			num = (short)1074987008;
			short num2 = num;
			num = (short)1082261504;
			switch (num)
			{
			default:
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("단꣪鿬髮鿰郲鷴鋶诸꛺꛼뛾漀攂樄甆搈樊礌明縐紒䠔䰖嬘縚稜瘞传縢縤搦嬨帪䌬䰮夰嘲䜴琶䬸帺尼䬾⑀Ṃ", a_));
				string text = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쟨蛪軬", a_));
				try
				{
					num = (short)640286726;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
						global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles[] array4;
						global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates[] array5;
						global::System.IO.FileStream fileStream;
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
						global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement[] array6;
						string firmwareVersion;
						switch (num3)
						{
						case 0:
							num = (short)284885024;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							radioInformation.General.RadInfoGeneralSerialNumber_A9122.Value = this.createSerialNumber;
							num = (short)955187227;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!this.SaveXPBA(this.operation.targetFile))
							{
								num = (short)301072446;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)745799701;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_E08;
						case 4:
							global::SpecialFeatures.Flashport.FlashDataManager.FlashDoc.Clear();
							num = (short)1341980721;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							int num4;
							global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles[] array;
							if (num4 >= array.Length)
							{
								num = (short)728629286;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles item = array[num4];
							apxtemplate.ASTRODVRSFiles.Add(item);
							num4++;
							num = (short)1843068963;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_1F5;
							}
							continue;
						case 7:
						{
							int num4;
							global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates[] array2;
							if (num4 >= array2.Length)
							{
								num = (short)1002504248;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates item2 = array2[num4];
							apxtemplate.ASTROCACertificates.Add(item2);
							num4++;
							num = (short)947585063;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							if (this.operation.targetFile.EndsWith(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쟨鏪鷬跮郰", a_)))
							{
								num = (short)510197804;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CA7;
						case 9:
							num = (short)1909063747;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (apxtemplate.ASTROCACertificates == null)
							{
								num = (short)939917359;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							apxtemplate.ASTROCACertificates.Clear();
							num = (short)842793017;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_A4A;
						case 12:
							num = (short)1688862779;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (this.operation.cruncherData.Radio == null)
							{
								num = (short)1246953532;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C46;
						case 14:
							num = (short)1298202632;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_B63;
						case 16:
						{
							int num4;
							global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement[] array3;
							if (num4 >= array3.Length)
							{
								num = (short)362610705;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement item3 = array3[num4];
							apxtemplate.ASTROVoiceAnnouncements.Add(item3);
							num4++;
							num = (short)99549238;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							goto IL_DC5;
						case 18:
							goto IL_D16;
						case 19:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles[] array = array4;
							int num4 = 0;
							num = (short)1852506145;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
							goto IL_79A;
						case 21:
							if (global::SpecialFeatures.Flashport.FlashDataManager.FlashDoc != null)
							{
								num = (short)598343684;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_95F;
						case 22:
							apxtemplate.ASTROVoiceAnnouncements = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>();
							num = (short)597688375;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							if (this.createSerialNumber != null)
							{
								num = (short)1534132225;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4CC;
						case 24:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates[] array2 = array5;
							int num4 = 0;
							num = (short)64946194;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							try
							{
								this.operation.cruncherData.arvFile = new byte[fileStream.Length];
								fileStream.Read(this.operation.cruncherData.arvFile, 0, this.operation.cruncherData.arvFile.Length);
								goto IL_89B;
							}
							finally
							{
								num = (short)1642856449;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_6FC;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_6C5;
										}
										continue;
									case 2:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)194445312;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_6C5:
									if (fileStream == null)
									{
										break;
									}
									num = (short)454623234;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_6FC:;
							}
							goto IL_6FF;
							IL_89B:
							apxcodeplug = (this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
							num = (short)889520141;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							if (apxcodeplug.ASTROFirmware.RMFile.Url != null)
							{
								num = (short)592248880;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_79A;
						case 27:
							goto IL_4CC;
						case 28:
							if (array4 != null)
							{
								num = (short)1804730387;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F4E;
						case 29:
							if (this.operation.targetFile != null)
							{
								num = (short)1816133646;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CA7;
						case 30:
						{
							num = (short)1664811633;
							short num5 = num;
							num = (short)2014052977;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_9E5;
							default:
								num = (short)833880064;
								if (num != 0)
								{
								}
								goto IL_2A6;
							}
							break;
						}
						case 31:
							goto IL_C46;
						case 32:
							if (apxtemplate.ASTROLanguagePack.RMFile.Url != null)
							{
								num = (short)1825308684;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9C0;
						case 33:
							goto IL_E5A;
						case 34:
							goto IL_9C0;
						case 35:
							goto IL_E5A;
						case 36:
							goto IL_CA7;
						case 37:
							if (apxtemplate != null)
							{
								num = (short)1889140776;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9C0;
						case 38:
							goto IL_F4E;
						case 39:
							goto IL_D16;
						case 40:
							num = (short)1005912125;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
							global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.ParseLanguagePackage(apxtemplate.ASTROLanguagePack.RMFile.Url);
							num = (short)880738338;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
							num = (short)250347546;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 43:
							goto IL_F8C;
						case 44:
							((global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow).CruncherReadRadio(0, false);
							num = (short)1401684004;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 45:
							if (array6 != null)
							{
								num = (short)886767666;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DC5;
						case 46:
							if (array5 != null)
							{
								num = (short)1380581400;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_364;
						case 47:
							apxtemplate.ASTROCACertificates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>();
							num = (short)1736441907;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 48:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware = apxcodeplug.ASTROFirmware;
							global::MackinawCPS.RMCWnd.AnalysisFirmwarePackage(apxcodeplug.ASTROFirmware.RMFile.Url, ref astrofirmware);
							apxcodeplug.FirmwareVersion = firmwareVersion;
							global::Motorola.Common.Communication.Pba.PbaObject pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFrom(this.operation.targetFile);
							pbaObject.ValidationFields = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateUpgradeValidationFields(pbaObject);
							pbaObject.ValidationInfos = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateUpgradeValidationInfos(pbaObject, this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, true);
							pbaObject.Serialize(this.operation.targetFile);
							num = (short)603979796;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 49:
							goto IL_95F;
						case 50:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement[] array3 = array6;
							int num4 = 0;
							num = (short)1227358238;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 51:
							goto IL_AC2;
						case 52:
							goto IL_B63;
						case 53:
							if (apxcodeplug.ASTROFirmware != null)
							{
								num = (short)1353121834;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_79A;
						case 54:
							goto IL_2A6;
						case 55:
							goto IL_E08;
						case 56:
							goto IL_364;
						case 57:
							goto IL_AC2;
						case 58:
							goto IL_6FF;
						case 59:
							if (global::System.IO.File.Exists(apxtemplate.ASTROLanguagePack.RMFile.Url))
							{
								num = (short)32505897;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9C0;
						case 60:
							this.operation.cruncherData.Radio = new global::Motorola.CommonCPS.Server.EntityModel.APXRadio();
							num = (short)1033043999;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 61:
							if (apxtemplate.ASTROLanguagePack != null)
							{
								num = (short)663093248;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9C0;
						case 62:
							goto IL_60D;
						case 63:
							num = (short)1764491330;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 64:
							if (apxtemplate.ASTROVoiceAnnouncements == null)
							{
								goto IL_9E5;
							}
							apxtemplate.ASTROVoiceAnnouncements.Clear();
							num = (short)1907490819;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 65:
							if (apxtemplate.ASTRODVRSFiles == null)
							{
								num = (short)548143162;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							apxtemplate.ASTRODVRSFiles.Clear();
							num = (short)1956315151;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 66:
							if (this.operation.targetArchive.EndsWith(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쟨蛪軬", a_)))
							{
								num = (short)849018889;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D59;
						case 67:
							if (!this.ReadMC(this.operation.targetArchive))
							{
								num = (short)2127691787;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CA7;
						}
						IL_1F5:
						if (this.operation.targetArchive != null)
						{
							num = (short)1962999871;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D59;
						IL_2A6:
						num = (short)516685840;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_364:
						num = (short)1788739649;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_4CC:
						this.operation.deviceInfo.CodeplugVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
						this.operation.deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
						this.operation.deviceInfo.ModelNumber = radioInformation.General.RadInfoGeneralModelNumber_A8539.Value;
						this.operation.deviceInfo.SerialNumber = global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(radioInformation.General.RadInfoGeneralSerialNumber_A9122.Value));
						this.operation.deviceInfo.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
						this.operation.deviceInfo.ConnectionInfo.UniqueAddress = dataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.UIValue;
						this.operation.deviceInfo.SoftwareVersion = radioInformation.General.RadInfoGeneralFirmwareVersion_A8124.Value;
						this.operation.deviceInfo.ESN = global::System.Text.Encoding.ASCII.GetBytes(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꣨ꧪ껬꯮샰쇲웴쏶", a_));
						num = (short)738918402;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_6FF:
						apxtemplate.ASTRODVRSFiles = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>();
						num = (short)245104692;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_79A:
						byte[] pbaBytes = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.DecryptAndUnzipByteArray(global::System.IO.File.ReadAllBytes(this.operation.targetFile));
						this.operation.cruncherData.pbaFile = global::Motorola.Common.CommonLib.CombineTool.Encode(pbaBytes, this.operation.deviceInfo);
						apxtemplate = (this.operation.cruncherData.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
						num = (short)850788389;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_95F:
						this.SaveMC(text);
						fileStream = global::System.IO.File.OpenRead(text);
						num = (short)998572057;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_9C0:
						num = (short)1447231552;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_9E5:
						num = (short)10944534;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_AC2:
						array5 = global::SpecialFeatures.SystemCertificates.CACertificatesHelper.GenerateNewCACertificatePackageData(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>().ToArray(), this.folderName);
						num = (short)291897390;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B63:
						array4 = global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.GenerateNewDVRSFilePackageData(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>().ToArray(), this.folderName);
						num = (short)13500444;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C46:
						global::Motorola.CommonCPS.Server.EntityModel.Radio radio = this.operation.cruncherData.Radio;
						firmwareVersion = apxcodeplug.FirmwareVersion;
						global::MackinawCPS.CommonUtility.PopulatecpAndDeviceColumnsFromDatabaseLayer(apxcodeplug, radio, global::MackinawCPS.PopulateOpeartion.Import);
						num = (short)637861941;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CA7:
						radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
						dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
						num = (short)691142679;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D16:
						num = (short)1251147783;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D59:
						num = (short)392888349;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_DC5:
						num = (short)1061683210;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_E08:
						array6 = global::SpecialFeatures.VoiceAnnouncements.VAHelper.GenerateNewVAPackageData(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>().ToArray(), this.folderName);
						num = (short)32505901;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_E5A:
						num = (short)1228931077;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F4E:
						global::MackinawCPS.CommandLineCPS.ObjectSerializer.DataContract_SerializeToFile(inputFile, this.operation.cruncherData);
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("단꣪鿬髮鿰郲鷴鋶诸꛺꛼곾琀怂昄戆稈砊倌后刐愒怔礖稘猚砜洞戠儢䀤䘦崨个瀬ᔮᄰ瀲头堶圸帺ᴼ䴾⁀❂ⱄ⡆楈⹊㕌㽎⍐㙒♔⑖祘㡚㉜㉞ᅠརd፦౨ཪ", a_));
						num = (short)1821704235;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_60D:
					throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뻨駪蓬鯮铰폲髴藶\ud9f8룺釼郾漀昂┄甆栈漊搌怎ㄐ甒琔縖甘縚礜", a_));
					IL_A4A:
					throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꿨諪蓬菮铰韲헴菶雸\udbfa鋼迾搀洂┄猆氈昊紌挎瀐朒瀔㜖砘椚縜眞䠠唢䀤", a_));
					IL_F8C:;
				}
				catch (global::System.Exception ex)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("단꣪鿬髮鿰郲鷴鋶诸꛺꛼뫾礀怂怄眆紈戊戌愎䰐䠒嘔攖氘甚縜眞䐠儢昤唦䰨䨪夬䨮氰लᔴ", a_) + ex.Message);
					if (ex.Message == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꿨諪蓬菮铰韲헴菶雸\udbfa鳼迾焀漂簄✆樈搊椌樎愐缒怔瀖㤘砚爜猞吠丢䬤否", a_))
					{
						this.CreateErrorOutput(inputFile, 22010);
					}
					else if (ex.Message == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꿨諪蓬菮铰韲헴菶雸\udbfa鋼迾搀洂┄猆氈昊紌挎瀐朒瀔㜖砘椚縜眞䠠唢䀤", a_))
					{
						this.CreateErrorOutput(inputFile, 22012);
					}
					else
					{
						this.CreateErrorOutput(inputFile, 22005);
					}
					this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Fail);
				}
				finally
				{
					this.DeleteTempFile(text);
					this.DeleteTempFile(this.operation.sourceFile);
					this.DeleteTempFile(this.operation.targetFile);
					this.DeleteTempFile(this.operation.targetArchive);
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("단꣪鿬髮鿰郲鷴鋶诸꛺꛼뛾漀攂樄甆搈樊礌明縐紒䠔䰖尘甚礜䈞稠怢圤刦䜨䠪䔬䨮䌰瀲䜴制堸伺堼戾", a_));
				}
				return true;
			}
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000F5788 File Offset: 0x000F3988
		private global::SpecialFeatures.Comms.RadioIdInfo ApplyCodeplugAndDeviceColumnsInWrite(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug currentcp, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate currentTpl)
		{
			int a_ = 13;
			short num = (short)1675493376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䨂欄愆昈礊怌渎攐稒稔礖䐘䀚弜稞䘠䨢䬤稦爨横崬弮崰䨲瘴堶崸帺䴼匾㑀⑂ф⥆ⵈཊ⡌㥎㡐げごᑖ㙘㝚⡜㉞འၢⱤ०㹨ᥪѬ᭮ᑰ⹲", a_));
				global::SpecialFeatures.Comms.RadioIdInfo result = default(global::SpecialFeatures.Comms.RadioIdInfo);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_261;
					}
					int? num4;
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
					for (;;)
					{
						IL_4E:
						string a;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
						int num3;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
						bool flag;
						bool? flag2;
						byte[] pbaBytes;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] array;
						bool flag3;
						bool flag4;
						bool flag5;
						int num5;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array2;
						int num7;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array3;
						int num8;
						int num9;
						bool flag8;
						int num11;
						string text;
						switch (num2)
						{
						case 0:
							goto IL_AAD;
						case 1:
							a = null;
							goto IL_1AB7;
						case 2:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
							if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
							{
								num = (short)1728970855;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							systemSubType = apxradioSystem.SystemSubType;
							astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.MDC;
							num = (short)941686899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_19B9;
						case 4:
						{
							num3 = 0;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType = apxradioSystem.SystemSubType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.ASTRO;
							num = (short)2074738690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingSystemRecset.GetEnumerator();
							num = (short)702087237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							flag = false;
							goto IL_1ADE;
						case 7:
							num3 = 1;
							num = (short)1049821301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (flag2 != null)
							{
								num = (short)22413349;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_963;
						case 9:
						{
							global::Motorola.Common.Communication.Pba.PbaObject pba = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(pbaBytes, false);
							result.IsEncryptedPwd = global::SpecialFeatures.Comms.ParseDataHelper.ReadEncryptPasswordFlag(pba);
							num = (short)1500250228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							int value = radioWide.General.RadWideGeneralOwnerWACNID_A38656.Value;
							num4 = currentcp.OwnerWacnId;
							if (!(value == num4.GetValueOrDefault() & num4 != null))
							{
								num = (short)959840324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7A6;
						}
						case 11:
							goto IL_1009;
						case 12:
							if (!string.IsNullOrEmpty(num4.ToString()))
							{
								num = (short)2129068098;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19B9;
						case 13:
							goto IL_B63;
						case 14:
						{
							int value2 = radioWide.General.RadWideGeneralOwnerSystemID_A37153.Value;
							num4 = currentcp.HomeSystemId;
							if (!(value2 == num4.GetValueOrDefault() & num4 != null))
							{
								num = (short)550109202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_885;
						}
						case 15:
							goto IL_EFB;
						case 16:
							result.TrkSysIds = new global::System.Collections.Generic.Dictionary<string, int[]>();
							result.CnvSysIds = new global::System.Collections.Generic.Dictionary<string, int[]>();
							result.AstroOtarRadioIds = new global::System.Collections.Generic.Dictionary<string, int>();
							result.DataProfIps = new global::SpecialFeatures.Comms.DataProfIP[array.Length];
							num = (short)496238716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							flag3 = false;
							goto IL_1A4B;
						case 18:
						{
							global::AcpBusinessLayer.AcpField<int> radWideGeneralOwnerSystemID_A = radioWide.General.RadWideGeneralOwnerSystemID_A37153;
							num4 = currentcp.HomeSystemId;
							radWideGeneralOwnerSystemID_A.SetValue(num4.Value);
							num = (short)800718937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							goto IL_FE9;
						case 20:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> apxotarProfiles = currentcp.APXOtarProfiles;
							if (apxotarProfiles == null)
							{
								num = (short)1249247249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag3 = (apxotarProfiles.Count == 1);
							goto IL_1A4B;
						}
						case 21:
							num = (short)1405943837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							global::AcpBusinessLayer.AcpField<bool> radWideGeneralASKRequired_A = radioWide.General.RadWideGeneralASKRequired_A37152;
							flag2 = currentcp.AskRequired;
							radWideGeneralASKRequired_A.SetValue(flag2.Value);
							num = (short)190578798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							if (currentcp.APXDataProfiles.Count > 0)
							{
								num = (short)96338045;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B63;
						case 24:
							if (!string.IsNullOrEmpty(currentcp.BluetoothDUNPeerIP))
							{
								num = (short)571474034;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_43F;
						case 25:
							if (!flag4)
							{
								num = (short)67633192;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19B9;
						case 26:
							if (num4 != null)
							{
								num = (short)415039616;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19B9;
						case 27:
						{
							global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2055);
							num = (short)709885972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
							num = (short)1484128383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							flag5 = currentcp.APXOtarProfiles.Any<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>();
							goto IL_1825;
						case 30:
							goto IL_1769;
						case 31:
							num = (short)1346306100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
						{
							if (num5 >= array2.Length)
							{
								num = (short)9371679;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							apxradioSystem = array2[num5];
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = apxradioSystem.SystemType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
							num = (short)1935802466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 33:
							goto IL_1749;
						case 34:
						{
							bool value3 = radioWide.General.RadWideGeneralASKRequired_A37152.Value;
							flag2 = currentcp.AskRequired;
							if (!(value3 == flag2.GetValueOrDefault() & flag2 != null))
							{
								num = (short)1727791126;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_963;
						}
						case 35:
							if (pbaBytes != null)
							{
								num = (short)789577737;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result.IsEncryptedPwd = radioWide.Labtool.RadWideLabtoolEncryptPassword_A41695.Value;
							num = (short)1907490911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							if (flag2 != null)
							{
								num = (short)695140380;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5E6;
						case 37:
							num = (short)1876033570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 38:
						{
							global::AcpBusinessLayer.AcpField<int> dvrswideLabtoolVrId_A = (global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.DVRSWideLabtoolVrId_A43727;
							num4 = currentcp.VRID;
							int value4;
							if (num4 == null)
							{
								value4 = 0;
							}
							else
							{
								num4 = currentcp.VRID;
								value4 = num4.Value;
							}
							dvrswideLabtoolVrId_A.Value = value4;
							num = (short)644874317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 39:
							array = currentcp.APXDataProfiles.OrderBy(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile prf)
							{
								short num15 = (short)584033295;
								short num16 = num15;
								num15 = (short)361473039;
								switch (num16 == num15)
								{
								}
								num15 = (short)2052063233;
								if (num15 != 0)
								{
								}
								num15 = (short)1328414720;
								short num17 = num15;
								num15 = (short)285802496;
								if (num15 != 0)
								{
								}
								return prf.OrderId;
							}).ToArray<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>();
							num = (short)636420109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 40:
						{
							global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2055);
							int num6 = 0;
							num = (short)473104426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 41:
							goto IL_197B;
						case 42:
							goto IL_197B;
						case 43:
							num = (short)356712502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							num3 = 2;
							num = (short)811139178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 45:
						{
							global::AcpCommonLib.IAcpRecordset feature;
							if (num7 >= feature.Count)
							{
								num = (short)308281393;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)495976519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 46:
							if (num4 != null)
							{
								num = (short)993329216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7A6;
						case 47:
							goto IL_15CA;
						case 48:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
							if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
							{
								num = (short)2082013251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							systemSubType = apxradioSystem.SystemSubType;
							astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.ASTRO25;
							num = (short)653918270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 49:
							goto IL_1BC7;
						case 50:
							goto IL_11FF;
						case 51:
							dataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.SetValue(global::System.Net.IPAddress.Parse(currentcp.SubscriberIP).Address);
							num = (short)1355677779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
							if (currentcp.APXOtarProfiles != null)
							{
								num = (short)97845269;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)841285736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 53:
							dataWide.General.DataWideGeneralPeerIPAddress1_A8524.SetValue(global::System.Net.IPAddress.Parse(currentcp.PeerIP).Address);
							num = (short)1806827646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 54:
							array3 = currentcp.APXRadioSystems.OrderBy(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem sys)
							{
								short num15 = (short)856506318;
								short num16 = num15;
								num15 = (short)1418215374;
								switch (num16 == num15)
								{
								}
								num15 = (short)340983808;
								if (num15 != 0)
								{
								}
								num15 = (short)1115553792;
								short num17 = num15;
								num15 = (short)1875509249;
								if (num15 != 0)
								{
								}
								return sys.OrderId;
							}).ToArray<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
							num = (short)1105461248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 55:
						{
							global::SpecialFeatures.Utilities.RMUtilities.PopulateAstroCpsASKProgrammingHistoryRecset(currentcp.AstroSysKeyLog);
							global::AcpCommonLib.IAcpRecordset feature3 = global::AcpCommonLib.FeatureManager.GetFeature(2054);
							num8 = 0;
							num = (short)175439883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 56:
							if (array.Length > num8)
							{
								num = (short)53346362;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_FE9;
						case 57:
							goto IL_5E6;
						case 58:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
							global::SpecialFeatures.Utilities.RMUtilities.PopulateAstroCpsTrunkingGroupIDs(ref dataProfiles, array[num8].TrunkingGroupIds);
							num = (short)1172176915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 59:
							goto IL_1769;
						case 60:
							goto IL_1CD0;
						case 61:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> apxotarProfiles2 = currentcp.APXOtarProfiles;
							if (apxotarProfiles2 == null)
							{
								num = (short)444465153;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							a = apxotarProfiles2[0].Profile;
							goto IL_1AB7;
						}
						case 62:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
							if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
							{
								num = (short)2017132618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16FE;
						}
						case 63:
							if (global::ConstraintHelper.UtilityMack.IsAPXNextOrAloha)
							{
								num = (short)1255604353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9EB;
						case 64:
							num = (short)1061224458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 65:
							goto IL_1009;
						case 66:
							num = (short)215089177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 67:
							num9 = 2;
							num = (short)1353384066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 68:
						{
							global::AcpBusinessLayer.AcpField<int> radWideGeneralOwnerWACNID_A = radioWide.General.RadWideGeneralOwnerWACNID_A38656;
							num4 = currentcp.OwnerWacnId;
							radWideGeneralOwnerWACNID_A.SetValue(num4.Value);
							num = (short)1225719878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 69:
							try
							{
								num = (short)1231224840;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
										global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem2;
										if (trunkingSystem.General.TrkSysGeneralKeyofTrunkingSystem_A12658.Value == apxradioSystem2.SystemName)
										{
											num = (short)825425924;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1287127045;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
										goto IL_CB9;
									}
									case 2:
										goto IL_E50;
									case 3:
										goto IL_E6A;
									case 4:
										num = (short)1974009866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_E50;
									case 6:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
										global::AcpBusinessLayer.AcpField<bool> trkSysTypeIIChannelSetupShuffledBandPlan_A = trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128;
										global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem2;
										flag2 = apxradioSystem2.ShuffeledBandPlan;
										bool flag6 = true;
										trkSysTypeIIChannelSetupShuffledBandPlan_A.SetValue(flag2.GetValueOrDefault() == flag6 & flag2 != null);
										num = (short)1688338434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										num = (short)1554579465;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										switch (0)
										{
										case 0:
											goto IL_C5C;
										}
										continue;
									case 9:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
										bool flag7 = trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128;
										global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem2;
										flag2 = apxradioSystem2.ShuffeledBandPlan;
										if (flag7 == flag2.GetValueOrDefault() & flag2 != null)
										{
											goto IL_E50;
										}
										num = (short)1243360967;
										short num10 = num;
										num = (short)1477062343;
										switch ((num10 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_CB9;
										default:
											num = (short)118226944;
											if (num != 0)
											{
											}
											num = (short)761069574;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
										if (trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128.IsVisible(trunkingSystem.TypeIIChannelSetup))
										{
											num = (short)639041543;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									goto IL_C5C;
									IL_CB9:
									num = (short)944963584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_D5F:
									num = (short)1795686401;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_C5C:
									goto IL_D5F;
									IL_E50:
									num = (short)961871875;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_E6A:;
							}
							finally
							{
								num = (short)59572224;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_EA0;
										}
										continue;
									case 1:
										goto IL_ED8;
									case 2:
										enumerator.Dispose();
										num = (short)2086141953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_EA0:
									if (enumerator == null)
									{
										break;
									}
									num = (short)533331970;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_ED8:;
							}
							goto IL_EDB;
						case 70:
							goto IL_7A6;
						case 71:
						{
							global::System.Collections.Generic.Dictionary<string, int> astroOtarRadioIds = result.AstroOtarRadioIds;
							global::AcpCommonLib.IAcpRecordset feature;
							string key = (feature[num7] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile).ASTROOTARInformation.SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663;
							num4 = currentcp.APXOtarProfiles[flag8 ? 0 : num7].OtarID;
							astroOtarRadioIds.Add(key, num4.Value);
							num7++;
							num = (short)1697579130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 72:
							goto IL_6C5;
						case 73:
							goto IL_43F;
						case 74:
							num9 = 3;
							num = (short)940114005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 75:
						{
							int value5 = radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.Value;
							num4 = currentcp.OwnerAdvKeyType;
							if (!(value5 == num4.GetValueOrDefault() & num4 != null))
							{
								num = (short)1831600248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6C5;
						}
						case 76:
							if (!string.IsNullOrEmpty(currentcp.BluetoothDUNSubscriberIP))
							{
								num = (short)273481810;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4BA;
						case 77:
							if (this.operation.deviceInfo.ESN != null)
							{
								num = (short)1596194907;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11FF;
						case 78:
							currentcp.UserPIN = string.Empty;
							currentcp.UserPIN = global::Common.AESCryptoUtil.AESEncryptWithDefKey(currentcp.UserPIN);
							num = (short)1546780793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 79:
							num = (short)60162123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 80:
							if (string.IsNullOrEmpty(currentcp.UserPIN))
							{
								num = (short)747634766;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1329;
						case 81:
							goto IL_1D27;
						case 82:
							dataWide.General.DataWideGeneralBTDUNSUIPAddress_A41120.SetValue(global::System.Net.IPAddress.Parse(currentcp.BluetoothDUNSubscriberIP).Address);
							num = (short)235995232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 83:
							goto IL_3C4;
						case 84:
							num = (short)1127874574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 85:
							goto IL_16FE;
						case 86:
						{
							global::AcpBusinessLayer.AcpField<bool> advancedExternalMicOnly = radioWide.Depot.AdvancedExternalMicOnly;
							flag2 = currentcp.DisableWriteProtect;
							advancedExternalMicOnly.SetValue(flag2.Value);
							num = (short)1928200249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 87:
							num = (short)937230417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 88:
						{
							global::AcpCommonLib.IAcpRecordset feature3;
							if (num8 >= feature3.Count)
							{
								num = (short)572653584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = feature3[num8] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
							num = (short)1947467832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 89:
							goto IL_885;
						case 90:
							if (currentcp.APXRadioSystems.Count > 0)
							{
								num = (short)1523122219;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AAD;
						case 91:
							result.ESerialNumber = new byte[this.operation.deviceInfo.ESN.Length];
							global::System.Array.Copy(this.operation.deviceInfo.ESN, result.ESerialNumber, this.operation.deviceInfo.ESN.Length);
							num = (short)1507721266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 92:
							goto IL_1749;
						case 93:
							if (flag4)
							{
								num = (short)375521307;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BC7;
						case 94:
							if (num11 >= array.Length)
							{
								num = (short)651755607;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result.DataProfIps[num11].DataProfName = array[num11].Name;
							result.DataProfIps[num11].PeerIP = global::System.Net.IPAddress.Parse(array[num11].PeerIP);
							result.DataProfIps[num11].SubIP = global::System.Net.IPAddress.Parse(array[num11].SubscriberIP);
							result.DataProfIps[num11].SubAirInterfaceIP = global::System.Net.IPAddress.Parse(array[num11].AirInterfaceAddress);
							result.DataProfIps[num11].BTPeerIP = global::System.Net.IPAddress.Parse(array[num11].AstroBluetoothDunPeerIp);
							result.DataProfIps[num11].BTSubIP = global::System.Net.IPAddress.Parse(array[num11].AstroBluetoothDunSubscriberIp);
							num11++;
							num = (short)903282793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 95:
							goto IL_12B1;
						case 96:
							goto IL_4BA;
						case 97:
							num = (short)1211433021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 98:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
							if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
							{
								num = (short)588316676;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num9 = 0;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType = apxradioSystem.SystemSubType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.TYPEII;
							num = (short)1212219440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 99:
							if (num4 != null)
							{
								num = (short)1360592980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_885;
						case 100:
							if (!string.IsNullOrEmpty(currentcp.SubscriberIP))
							{
								num = (short)1627783219;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C4;
						case 101:
							goto IL_9EB;
						case 102:
							result.BluetoothFriendlyName = ((currentcp.BluetoothFriendlyName != null) ? currentcp.BluetoothFriendlyName : string.Empty);
							num = (short)199098406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 103:
							num3 = 0;
							num = (short)1359151151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 104:
							flag5 = false;
							goto IL_1825;
						case 105:
							goto IL_1CD0;
						case 106:
							goto IL_15CA;
						case 107:
							result.SoftIds = new string[]
							{
								(currentcp.UserName != null) ? currentcp.UserName : string.Empty,
								(text.Length > 4) ? text.Substring(0, 4) : text.Substring(0, text.Length),
								(text.Length > 4) ? text.Substring(4) : "",
								(currentcp.UserLoginUnitID != null) ? currentcp.UserLoginUnitID : string.Empty
							};
							array2 = array3;
							num5 = 0;
							num = (short)1758396475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 108:
						{
							global::AcpCommonLib.IAcpRecordset feature2;
							int num6;
							if (num6 >= feature2.Count)
							{
								num = (short)625410051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.Dictionary<string, int> astroOtarRadioIds2 = result.AstroOtarRadioIds;
							string key2 = (feature2[num6] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile).ASTROOTARInformation.SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663;
							num4 = currentcp.OtarID;
							astroOtarRadioIds2.Add(key2, num4.Value);
							num6++;
							num = (short)1499856937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 109:
							goto IL_EFB;
						case 110:
							goto IL_963;
						case 111:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
							if (!(systemType.GetValueOrDefault() == astroSystemType & systemType != null))
							{
								num = (short)955187205;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EDB;
						}
						case 112:
							if (!string.IsNullOrEmpty(currentcp.PeerIP))
							{
								num = (short)1457782837;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_34B;
						case 113:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
							if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
							{
								num = (short)1820459052;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15CA;
						}
						case 114:
							dataWide.General.DataWideGeneralBTDUNPeerIPAddress_A41123.SetValue(global::System.Net.IPAddress.Parse(currentcp.BluetoothDUNPeerIP).Address);
							num = (short)246415433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 115:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
							if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
							{
								num = (short)526319623;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							systemSubType = apxradioSystem.SystemSubType;
							astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.DVRS;
							num = (short)1474429041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 116:
							goto IL_12B1;
						case 117:
							goto IL_15CA;
						case 118:
						{
							if (num5 >= array2.Length)
							{
								num = (short)1011679287;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem2 = array2[num5];
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = apxradioSystem2.SystemType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
							num = (short)697958511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 119:
							if (num4 != null)
							{
								num = (short)766246991;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6C5;
						case 120:
						{
							global::AcpBusinessLayer.AcpField<int> radWideGeneralOwnerAdvancedKeyType_A = radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663;
							num4 = currentcp.OwnerAdvKeyType;
							radWideGeneralOwnerAdvancedKeyType_A.SetValue(num4.Value);
							num = (short)1810104392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 121:
							goto IL_1329;
						case 122:
							goto IL_1B87;
						case 123:
							goto IL_1B87;
						case 124:
							result.RadioAlias = ((currentcp.RadioAlias != null) ? currentcp.RadioAlias : string.Empty);
							num = (short)205324390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 125:
							num = (short)1961558055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 126:
							goto IL_34B;
						case 127:
						{
							bool value6 = radioWide.Depot.AdvancedExternalMicOnly.Value;
							flag2 = currentcp.DisableWriteProtect;
							if (!(value6 == flag2.GetValueOrDefault() & flag2 != null))
							{
								num = (short)478675030;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5E6;
						}
						case 128:
							num4 = currentcp.OtarID;
							num = (short)1983250444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 129:
							radioWide.Labtool.RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.SetValue(global::System.Guid.NewGuid().ToString(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꏬ", a_)).ToUpper());
							num = (short)1972174949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 130:
							goto IL_16FE;
						}
						goto IL_261;
						IL_34B:
						num = (short)602865764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3C4:
						num = (short)955449368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_43F:
						num = (short)723451980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4BA:
						this.ApplyPasswordToBLDoc(currentcp);
						this.SetOOBEFieldToFalse();
						global::SpecialFeatures.ReadWriteTlsPsk.ReadWriteTlsPskHelper.SetTlsPskFromCodeplugPassword();
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䨂欄愆昈礊怌渎攐稒稔礖䐘䀚弜稞䘠䨢䬤稦爨横崬弮崰䨲瘴堶崸帺䴼匾㑀⑂ф⥆ⵈཊ⡌㥎㡐げごᑖ㙘㝚⡜㉞འၢⱤ०㹨ᥪѬ᭮ᑰ⹲啴㑶ᅸṺṼᑾꆀꞆ떔ﾚ붜ﺞ토펢즤\udea6覨ﮬﶮ鎲펴\udeb6햸\udeba鶼쮾껀蛄꣆귈껊뷌ꏎꓐ듒", a_));
						global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.ApplyDVRSFileDataFromTemplateUsingCruncherData(currentTpl, this.operation.cruncherData);
						radioWide = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)global::AcpCommonLib.FeatureManager.GetFeature(2045)[0];
						flag2 = currentcp.DisableWriteProtect;
						num = (short)1389559844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5E6:
						num4 = currentcp.OwnerAdvKeyType;
						num = (short)1483407479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6C5:
						num4 = currentcp.OwnerWacnId;
						num = (short)1333002286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7A6:
						num4 = currentcp.HomeSystemId;
						num = (short)977272931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_885:
						flag2 = currentcp.AskRequired;
						num = (short)52756488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_963:
						num = (short)1958084671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9EB:
						trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
						array3 = new global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[0];
						num = (short)1605107802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_AAD:
						array = new global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[0];
						num = (short)2037645335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B63:
						array2 = array3;
						num5 = 0;
						num = (short)1089142893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_EDB:
						num5++;
						num = (short)761724943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_EFB:
						num = (short)1300430966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_FE9:
						num8++;
						num = 65;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1009:
						num = (short)276365400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_11FF:
						pbaBytes = this.GetPbaBytes(this.operation.cruncherData);
						num = (short)191889443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_12B1:
						num = (short)1958608976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1329:
						text = global::Common.AESCryptoUtil.AESDecryptWithDefKey(currentcp.UserPIN);
						result.EncryptedPwd = currentcp.UserPIN;
						num = (short)178651243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_15CA:
						global::System.Collections.Generic.Dictionary<string, int[]> cnvSysIds = result.CnvSysIds;
						string systemName = apxradioSystem.SystemName;
						int[] array4 = new int[2];
						array4[0] = num3;
						int num12 = 1;
						num4 = apxradioSystem.RadioId;
						array4[num12] = num4.Value;
						cnvSysIds.Add(systemName, array4);
						num = (short)731578401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_16FE:
						global::System.Collections.Generic.Dictionary<string, int[]> trkSysIds = result.TrkSysIds;
						string systemName2 = apxradioSystem.SystemName;
						int[] array5 = new int[2];
						array5[0] = num9;
						int num13 = 1;
						num4 = apxradioSystem.RadioId;
						array5[num13] = num4.Value;
						trkSysIds.Add(systemName2, array5);
						num = (short)889127004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1749:
						num5++;
						num = (short)1881341982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1769:
						num = (short)1874591776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1825:
						flag4 = flag5;
						num4 = currentcp.OtarID;
						num = (short)1254490138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_197B:
						num = (short)1834942572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_19B9:
						num = (short)764346461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A4B:
						if (flag3)
						{
							num = (short)1881145441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)954073094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1ADE:
						flag8 = flag;
						num7 = 0;
						num = (short)1321730171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1AB7:
						flag = (a == string.Empty);
						goto IL_1ADE;
						IL_1B87:
						num = (short)1846738989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BC7:
						num11 = 0;
						num = (short)1072431164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1CD0:
						num = (short)1965424734;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1D27:
					goto IL_1D5F;
					IL_261:
					(global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralSerialNumber_A9122.Value = radio.SerialNumber;
					global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced advanced = (global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu).Advanced;
					num4 = currentTpl.LanguageIndex;
					advanced.DispMenuAdvancedLanguageSelection_A8386Value = num4.Value;
					dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
					num = (short)2101674096;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4E;
				}
				catch (global::System.Exception ex)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䘂約搆氈笊礌明縐紒䠔䰖堘欚洜猞堠怢䨤䌦䰨嬪䄬娮嘰爲嬴匶紸帺䬼嘾≀♂ل⡆╈㹊⁌ⅎ≐ᩒ㭔V⭘㉚⥜㩞㱠奢䕤", a_) + ex.Message);
					throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯬軮飰鿲郴鏶\ud9f8迺鋼\udffe怀猂甄欆瀈⬊渌怎甐瘒攔笖氘簚㴜簞丠伢値䨦䜨堪", a_));
				}
				IL_1D5F:
				num = (short)525402112;
				short num14 = num;
				num = (short)864681985;
				if (num != 0)
				{
				}
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛬곮菰蛲鯴银釸黺迼ꋾ娀䨂欄愆昈礊怌渎攐稒稔礖䐘䀚堜焞䔠縢縤昦夨嬪䄬嘮爰尲儴制䤸场䠼堾@ⵂ⅄͆ⱈ㵊⑌ⱎ㑐ၒ㩔㭖ⱘ㙚㍜ⱞ⡠ൢ㉤ᕦhὪ࡬㉮", a_));
				return result;
			}
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000F7590 File Offset: 0x000F5790
		private void ApplyPasswordToBLDoc(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug codeplug)
		{
			short num = (short)1283784704;
			switch (num)
			{
			default:
			{
				num = (short)842792962;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				global::AcpBusinessLayer.AcpStringField radWideGeneralTlsPsk_;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)global::AcpCommonLib.FeatureManager.GetFeature(2045)[0];
						bool flag;
						radioWide.Labtool.RadWideLabtoolRadioReadPasswordEnable_A8869.SetValue(flag);
						bool flag2;
						radioWide.Labtool.RadWideLabtoolRadioWritePasswordEnable_A8889.SetValue(flag2);
						bool flag3;
						radioWide.Labtool.RadWideLabtoolArchiveReadPasswordEnable_A7462.SetValue(flag3);
						text = ((!flag && !flag2 && !flag3) ? string.Empty : codeplug.CodeplugPassword);
						string value = string.IsNullOrEmpty(text) ? string.Empty : new global::SpecialFeatures.ReadWritePassword.ReadWriteUtil().encryptMesg(text);
						radioWide.Labtool.RadWideLabtoolRadioPassword_A8837.SetValue(value);
						radWideGeneralTlsPsk_ = radioWide.General.RadWideGeneralTlsPsk_44841;
						num = (short)100270084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_279;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 3:
						goto IL_D0;
					case 4:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1029439489;
							if (num != 0)
							{
							}
							num = (short)2019295238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1908146177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_250;
					case 6:
						num = (short)537788421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					if (!codeplug.PasswordPerDevice)
					{
						num = (short)8414590;
						short num3 = num;
						num = (short)182084990;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1424293888;
							if (num != 0)
							{
							}
							num = (short)1852702723;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy passwordPolicy = codeplug.PasswordPolicy;
						bool flag = (passwordPolicy & global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Read) > global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None;
						bool flag2 = (passwordPolicy & global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Write) > global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None;
						bool flag3 = (passwordPolicy & global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Open) > global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None;
						num = (short)974716928;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_D0:
				num = (short)1776615424;
				short num4 = num;
				return;
				IL_250:
				string text2 = global::CommonUtility.TlsPskHashManager.Hash(text, 4000, 16);
				goto IL_282;
				IL_279:
				text2 = radWideGeneralTlsPsk_.DefaultValue;
				IL_282:
				string value2 = text2;
				radWideGeneralTlsPsk_.SetValue(value2);
				return;
			}
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000F782C File Offset: 0x000F5A2C
		private void SetOOBEFieldToFalse()
		{
			short num = (short)900383166;
			short num2 = num;
			num = (short)485671358;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1867776000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1253638145;
			if (num != 0)
			{
			}
			num = (short)2051276800;
			if (num != 0)
			{
			}
			(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolSeamlessUpdateOutOfBoxExperience.Value = false;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000F78F8 File Offset: 0x000F5AF8
		private bool CruncherRead(string inputFile)
		{
			int a_ = 14;
			short num = (short)2029191169;
			if (num != 0)
			{
			}
			num = (short)1340669952;
			short num2 = num;
			num = (short)1690304512;
			switch (num)
			{
			default:
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗭돯胱至飵鯷鋹駻賽巿夁䴃栅渇攉縋挍焏昑紓礕瘗䜙䜛尝䔟䔡䴣䠥甧焩漫尭䔯就圳帵崷䠹渻嬽ℿ♁᥃", a_));
				string text = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("샭鷯釱", a_));
				try
				{
					num = (short)559939609;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string bbfbundleVersion;
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles> existingPackageData;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates> existPackageData;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement> existPackageData2;
						switch (num3)
						{
						case 0:
							goto IL_2DA;
						case 1:
							goto IL_1C5;
						case 2:
						{
							try
							{
								switch (0)
								{
								case 0:
									goto IL_B1E;
								}
								global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
								int dispMenuAdvancedLanguageSelection_A8386Value;
								global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo;
								for (;;)
								{
									IL_ACF:
									switch (num3)
									{
									case 0:
										if (pbaObject.LanguagePackData != null)
										{
											num = (short)391905295;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_E80;
									case 1:
										num = (short)1117388807;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										if (pbaObject.LanguagePackData.LanguagePacks != null)
										{
											num = (short)1566572552;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_E80;
									case 3:
										if (dispMenuAdvancedLanguageSelection_A8386Value != 0)
										{
											num = (short)629866505;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_FB4;
									case 4:
										if (dispMenuAdvancedLanguageSelection_A8386Value != 0)
										{
											num = (short)1194590209;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_BF4;
									case 5:
										try
										{
											num = (short)11502580;
											short num4 = num;
											num = (short)1270186996;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												IL_D02:
												num = (short)1852506113;
												num3 = (int)((global::System.IntPtr)num);
												break;
											default:
												num = (short)1476263936;
												if (num != 0)
												{
												}
												num = (short)720633856;
												num3 = (int)((global::System.IntPtr)num);
												break;
											}
											for (;;)
											{
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_D00;
													}
													continue;
												case 1:
												{
													global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
													if (!enumerator.MoveNext())
													{
														num = (short)1487732739;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::Motorola.Common.Communication.Pba.LanguagePackBase package = enumerator.Current;
													this.ApplyLanguagePack(package, astroDeviceInfo, this.operation.cruncherData.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate, this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
													num = (short)2057371650;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													num = (short)1607532548;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
													goto IL_DAB;
												}
												break;
											}
											IL_D00:
											goto IL_D02;
											IL_DAB:
											goto IL_FB4;
										}
										finally
										{
											global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
											((global::System.IDisposable)enumerator).Dispose();
										}
										goto IL_DBE;
									case 6:
										if (pbaObject.LanguagePackData.LanguagePacks.Count > 0)
										{
											num = (short)594149386;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_E80;
									case 7:
										if (!global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.IsFirmwareLPCompatible(astroDeviceInfo.SoftwareVersion, dispMenuAdvancedLanguageSelection_A8386Value))
										{
											num = (short)283246603;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_F0C;
									case 8:
										num = (short)90243078;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = global::CommonUtility.ASTROLanguageUtility.Instance.CreateFakeLanguagePackage(dispMenuAdvancedLanguageSelection_A8386Value.ToString());
										(this.operation.cruncherData.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).ASTROLanguagePack = astrolanguagePack;
										(this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).ASTROLanguagePack = astrolanguagePack;
										num = (short)967770126;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator = pbaObject.LanguagePackData.LanguagePacks.GetEnumerator();
										num = (short)830275589;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										goto IL_BF4;
									case 12:
										num = (short)321585155;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
										goto IL_F0C;
									case 14:
										goto IL_FB4;
									case 15:
										goto IL_DBE;
									case 16:
										if (pbaObject.LanguagePackData == null)
										{
											num = (short)1824718860;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_FB4;
									case 17:
										goto IL_FCC;
									}
									goto IL_B1E;
									IL_BF4:
									pbaObject.LanguagePackData = null;
									string text2 = global::System.IO.Path.Combine(this.folderName, global::System.Guid.NewGuid().ToString() + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("샭裯英雳韵", a_));
									long num5 = pbaObject.Serialize(text2);
									this.operation.cruncherData.pbaFile = global::Motorola.Common.CommonLib.CombineTool.Encode(text2, (int)num5, astroDeviceInfo);
									global::System.IO.File.Delete(text2);
									num = (short)1332084749;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_DBE:
									num = (short)384892930;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_E80:
									num = (short)2132410384;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_F0C:
									num = (short)281739264;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_FB4:
									num = (short)862126097;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_FCC:
								goto IL_655;
								IL_B1E:
								global::System.Collections.Generic.List<byte[]> list = global::Motorola.Common.CommonLib.CombineTool.Decode(this.operation.cruncherData.pbaFile);
								astroDeviceInfo = (global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo)global::Motorola.Common.CommonLib.CombineTool.ByteArrayToObject(list[1]);
								pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(list[0], false);
								bbfbundleVersion = astroDeviceInfo.RadioBBFSuiteVersion;
								dispMenuAdvancedLanguageSelection_A8386Value = (global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu).Advanced.DispMenuAdvancedLanguageSelection_A8386Value;
								num = (short)1422065668;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_ACF;
							}
							catch
							{
								goto IL_655;
							}
							goto IL_FD7;
							IL_655:
							global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(text);
							num = (short)1577189380;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_116B;
						case 4:
							try
							{
								global::System.IO.FileStream fileStream;
								this.operation.cruncherData.arvFile = new byte[fileStream.Length];
								fileStream.Read(this.operation.cruncherData.arvFile, 0, this.operation.cruncherData.arvFile.Length);
								goto IL_10A9;
							}
							finally
							{
								num = (short)282787840;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_386;
										}
										continue;
									case 1:
										goto IL_3C0;
									case 2:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)1663893505;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_386:
									if (fileStream == null)
									{
										break;
									}
									num = (short)1600716802;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_3C0:;
							}
							goto Block_7;
							IL_10A9:
							num = (short)98238501;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_11D2;
						case 6:
							if (apxtemplate.ASTROVoiceAnnouncements == null)
							{
								num = (short)555679780;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							apxtemplate.ASTROVoiceAnnouncements.Clear();
							num = (short)690618377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (existingPackageData != null)
							{
								num = (short)2032795670;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20F;
						case 8:
							goto IL_10A7;
						case 9:
							goto IL_8D8;
						case 10:
							if (this.operation.cruncherData.Codeplug == null)
							{
								num = (short)615448611;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C5;
						case 11:
							goto IL_116B;
						case 12:
							goto IL_950;
						case 13:
						{
							global::MackinawCPS.WindowMain windowMain = (global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow;
							string readPassword = (this.operation.cruncherData.Radio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).ReadPassword;
							windowMain.CruncherReadRadio(0, false);
							num = (short)2102460455;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							goto IL_8D8;
						case 15:
							goto IL_3C3;
						case 16:
							apxtemplate.ASTROCACertificates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>();
							num = (short)552992802;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (apxtemplate.ASTROCACertificates == null)
							{
								num = (short)1551106064;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							apxtemplate.ASTROCACertificates.Clear();
							num = (short)2017919016;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (apxtemplate.ASTRODVRSFiles == null)
							{
								num = (short)820576286;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							apxtemplate.ASTRODVRSFiles.Clear();
							num = (short)1841627147;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							goto IL_129B;
						case 20:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>.Enumerator enumerator2 = existPackageData.GetEnumerator();
							num = (short)1390215183;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
						{
							string readPassword;
							if (readPassword == string.Empty)
							{
								num = (short)1257570312;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗭돯胱至飵鯷鋹駻賽巿夁䴃栅渇攉縋挍焏昑紓礕瘗䜙䜛崝刟圡䨣䔥䀧伩師簭唯匱倳欵挷氹崻刽⤿♁╃㉅ⵇՉ݋ᩍ㽏ݑ❓㍕⩗ਖ਼㵛ⵝ፟ᕡୣᑥ౧㝩", a_));
							string radInfoGeneralSerialNumber_A9122Value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralSerialNumber_A9122Value;
							num = (short)291045399;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator3 = existingPackageData.GetEnumerator();
							num = (short)1371602985;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
						{
							string readPassword;
							string radInfoGeneralSerialNumber_A9122Value;
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
							if (!this._readWritePasswordApp.ValidateOKToUserPassword(readPassword, radioWide.Labtool.RadWideLabtoolRadioPassword_A8837Value, radInfoGeneralSerialNumber_A9122Value))
							{
								num = (short)303104000;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5CF;
						}
						case 24:
							if (existPackageData2 != null)
							{
								num = (short)787480603;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_748;
						case 25:
							switch (0)
							{
							case 0:
								goto IL_193;
							}
							continue;
						case 26:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
							if (radioWide.Labtool.RadWideLabtoolRadioReadPasswordEnable_A8869Value)
							{
								num = (short)1533018145;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5CF;
						}
						case 27:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>.Enumerator enumerator4 = existPackageData2.GetEnumerator();
							num = (short)118947882;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
							num = (short)1535246362;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 29:
							this.operation.cruncherData.Radio = new global::Motorola.CommonCPS.Server.EntityModel.APXRadio();
							num = (short)1715535877;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							apxtemplate.ASTRODVRSFiles = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>();
							num = (short)566689795;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							if (this.operation.cruncherData.Template == null)
							{
								num = (short)2123890726;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_950;
						case 32:
							if (existPackageData != null)
							{
								num = (short)1044578324;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_877;
						case 33:
							num = (short)1958477845;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							goto IL_FD7;
						case 35:
							this.operation.cruncherData.Codeplug = new global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug();
							num = (short)1454833665;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							apxtemplate.ASTROVoiceAnnouncements = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>();
							num = (short)852951054;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							if (this.operation.cruncherData.Radio == null)
							{
								num = (short)544997405;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11D2;
						case 38:
							goto IL_490;
						case 39:
							if (!this.operation.cruncherData.IsMigrationJob)
							{
								num = (short)504037404;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5CF;
						case 40:
							goto IL_FD7;
						case 41:
							try
							{
								num = (short)1232535552;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_6B5;
										}
										continue;
									case 2:
										num = (short)1310720004;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator3;
										if (!enumerator3.MoveNext())
										{
											num = (short)1003749378;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles item = enumerator3.Current;
										apxtemplate.ASTRODVRSFiles.Add(item);
										num = (short)1583153153;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_735;
									}
									IL_6E4:
									num = (short)801570819;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_6B5:
									goto IL_6E4;
								}
								IL_735:
								goto IL_20F;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator3;
								((global::System.IDisposable)enumerator3).Dispose();
							}
							goto IL_748;
						case 42:
							try
							{
								num = (short)1595998208;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_7E6;
										}
										continue;
									case 1:
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>.Enumerator enumerator4;
										if (!enumerator4.MoveNext())
										{
											num = (short)90898435;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement item2 = enumerator4.Current;
										apxtemplate.ASTROVoiceAnnouncements.Add(item2);
										num = (short)557580290;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)787021828;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_864;
									}
									IL_7E8:
									num = (short)930938881;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_7E6:
									goto IL_7E8;
								}
								IL_864:
								goto IL_748;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>.Enumerator enumerator4;
								((global::System.IDisposable)enumerator4).Dispose();
							}
							goto IL_877;
						}
						IL_193:
						if (this.operation.cruncherData.Radio != null)
						{
							num = (short)185860109;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CF;
						IL_1C5:
						num = (short)338034719;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_20F:
						global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData = this.operation.cruncherData;
						global::Motorola.CommonCPS.Server.EntityModel.Package[] dvrsfilesPackages;
						global::Motorola.CommonCPS.Server.EntityModel.Package[] array = global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.GenerateNewDVRSFilePackageData(dvrsfilesPackages, this.folderName);
						cruncherData.DVRSFilesPackages = array;
						bbfbundleVersion = string.Empty;
						num = (short)725221378;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_490:
						this.operation.cruncherData.Codeplug.Template = new global::Motorola.CommonCPS.Server.EntityModel.APXTemplate();
						this.operation.cruncherData.Template = this.operation.cruncherData.Codeplug.Template;
						num = (short)519241740;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						Block_7:
						try
						{
							IL_3C3:
							num = (short)160235521;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3FD;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)154402820;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates item3 = enumerator2.Current;
									apxtemplate.ASTROCACertificates.Add(item3);
									num = (short)1411186688;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_47D;
								case 4:
									num = (short)2063335427;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_42D:
								num = (short)793837570;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_3FD:
								goto IL_42D;
							}
							IL_47D:
							goto IL_877;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_490;
						IL_5CF:
						this.operation.sourceFile = text;
						this.SaveMC(text);
						num = (short)204931082;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_748:
						global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData2 = this.operation.cruncherData;
						global::Motorola.CommonCPS.Server.EntityModel.Package[] vapackages;
						array = global::SpecialFeatures.VoiceAnnouncements.VAHelper.GenerateNewVAPackageData(vapackages, this.folderName);
						cruncherData2.VAPackages = array;
						num = (short)2008350737;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_877:
						global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData3 = this.operation.cruncherData;
						global::Motorola.CommonCPS.Server.EntityModel.Package[] cacertificatePackages;
						array = global::SpecialFeatures.SystemCertificates.CACertificatesHelper.GenerateNewCACertificatePackageData(cacertificatePackages, this.folderName);
						cruncherData3.CACertificatePackages = array;
						num = (short)1128202258;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_8D8:
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
						apxcodeplug.ASTROVoiceAnnouncements = apxtemplate.ASTROVoiceAnnouncements;
						vapackages = this.operation.cruncherData.VAPackages;
						existPackageData2 = global::SpecialFeatures.VoiceAnnouncements.VAHelper.GetExistPackageData(vapackages);
						num = (short)1063387160;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_950:
						apxtemplate = (this.operation.cruncherData.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
						num = (short)2128740358;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_FD7:
						apxcodeplug.ASTROCACertificates = apxtemplate.ASTROCACertificates;
						cacertificatePackages = this.operation.cruncherData.CACertificatePackages;
						existPackageData = global::SpecialFeatures.SystemCertificates.CACertificatesHelper.GetExistPackageData(cacertificatePackages);
						num = (short)1855651872;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_116B:
						apxcodeplug.ASTRODVRSFiles = apxtemplate.ASTRODVRSFiles;
						dvrsfilesPackages = this.operation.cruncherData.DVRSFilesPackages;
						existingPackageData = global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.GetExistingPackageData(dvrsfilesPackages);
						num = (short)343474183;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_11D2:
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug2 = this.operation.cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio = this.operation.cruncherData.Radio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio;
						this.UpdateAPXRRadioType(apxradio);
						global::MackinawCPS.CommonUtility.PopulatecpAndDeviceColumnsFromDatabaseLayerForCruncherRead(apxcodeplug2, apxradio);
						apxcodeplug2.UpgradeAbility = new bool?(true);
						apxcodeplug2.BBFBundleVersion = bbfbundleVersion;
						apxcodeplug2.Template.BBFBundleVersion = bbfbundleVersion;
						global::MackinawCPS.CommonUtility.SetFeatureSet(this.operation.cruncherData.Radio, apxradio.Uuid);
						this.operation.cruncherData.ErrorCode = null;
						this.EndExecuteCommand(this.operation.cruncherData);
						global::MackinawCPS.CommandLineCPS.ObjectSerializer.DataContract_SerializeToFile(inputFile, this.operation.cruncherData);
						num = (short)1394081811;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2DA:
					global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗭돯胱至飵鯷鋹駻賽巿夁䄃縅欇漉簋稍礏紑稓䬕䌗夙減欝丟䄡䰣䌥娧砩䤫伭启漱ำᘵ渷嬹倻圽␿⍁ぃ⍅݇ŉᡋ⅍Տ⅑ㅓ⑕ࡗ㭙⽛ⵝ᝟ൡᙣɥ䡧౩൫ݭᱯ", a_));
					throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볭闯鏱郳\ud9f5꿷裹闻諽旿∁球朅笇礉笋愍戏瘑㐓怕礗瘙甛稝䄟嘡䴣䤥䘧਩䨫伭夯帱儳刵", a_));
					IL_10A7:
					global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗭돯胱至飵鯷鋹駻賽巿夁䄃縅欇漉簋稍礏紑稓䬕䌗夙減欝丟䄡䰣䌥娧砩䤫伭启漱ำᘵ䴷䤹夻䰽怿㉁╃㕅㭇㵉⍋㱍㑏牑㵓╕硗㽙ㅛ⹝ᑟ᭡", a_));
					throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볭闯鏱郳\ud9f5꿷裹闻諽旿∁球朅笇礉笋愍戏瘑㐓怕礗瘙甛稝䄟嘡䴣䤥䘧਩䨫伭夯帱儳刵", a_));
					IL_129B:;
				}
				catch (global::System.Exception ex)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗭돯胱至飵鯷鋹駻賽巿夁䄃縅欇漉簋稍礏紑稓䬕䌗夙減欝丟䄡䰣䌥娧砩䤫伭启漱ำᘵ", a_) + ex.Message);
					if (ex.Message == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뻭鿯英至髵駷軹駻\udefd揿洁怃挅砇昉礋植』猑稓爕㠗縙礛栝䤟䄡䄣إ䬧䔩䀫嬭崯就䜳ᘵ帷嬹唻刽㌿", a_))
					{
						this.CreateErrorOutput(inputFile, 22008);
					}
					else if (ex.Message == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("귭釯鳱髳駵賷\udaf9軻鯽懿昁␃爅怇漉Ⰻ縍爏猑㐓瀕焗瘙礛", a_))
					{
						this.CreateErrorOutput(inputFile, 22009);
					}
					else if (ex.Message == global::CommonResources.AppResources.The_radio_being_read_is_INHIBITED)
					{
						this.CreateErrorOutput(inputFile, 22021);
					}
					else if (ex.Message == global::CommonResources.AppResources.The_radio_being_read_is_KILLED)
					{
						this.CreateErrorOutput(inputFile, 22022);
					}
					else if (ex.Message == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볭闯鏱郳\ud9f5꿷裹闻諽旿∁球朅笇礉笋愍戏瘑㐓怕礗瘙甛稝䄟嘡䴣䤥䘧਩䨫伭夯帱儳刵", a_))
					{
						this.CreateErrorOutput(inputFile, 22013);
					}
					else
					{
						this.CreateErrorOutput(inputFile, 22006);
					}
					this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Fail);
				}
				finally
				{
					this.DeleteTempFile(text);
					this.DeleteTempFile(this.operation.targetFile);
					this._readWritePasswordApp.ClearCachedPasswordValidation();
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗭돯胱至飵鯷鋹駻賽巿夁䴃栅渇攉縋挍焏昑紓礕瘗䜙䜛嬝丟䘡礣紥欧堩夫䀭匯娱儳䐵樷弹崻娽ᴿ", a_));
				}
				return true;
			}
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000F8DB4 File Offset: 0x000F6FB4
		private void UpdateAPXRRadioType(global::Motorola.CommonCPS.Server.EntityModel.APXRadio dev)
		{
			short num = (short)1534281642;
			short num2 = num;
			num = (short)1240418218;
			switch (num2 == num)
			{
			}
			num = (short)949223425;
			if (num != 0)
			{
			}
			num = (short)1444872192;
			short num3 = num;
			num = (short)1202454528;
			if (num != 0)
			{
			}
			dev.APXRadioType = new global::Motorola.CommonCPS.Server.CommonDBConstants.APXRadioType?(global::ConstraintHelper.UtilityMack.IsPortable() ? global::Motorola.CommonCPS.Server.CommonDBConstants.APXRadioType.Portable : global::Motorola.CommonCPS.Server.CommonDBConstants.APXRadioType.Mobile);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000F8E78 File Offset: 0x000F7078
		private void ApplyLanguagePack(global::Motorola.Common.Communication.Pba.LanguagePackBase package, global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo deviceInfo, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug codeplug)
		{
			short num = (short)2063663104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						num = (short)144834560;
						short num3 = num;
						string text;
						string packageVersion;
						if (global::CommonUtility.ASTROLanguageUtility.Instance.ParseLanguageIDAndVersion(astroFilePackInfo.radioFilePath, out text, out packageVersion))
						{
							num = (short)1406533636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
						goto IL_125;
					case 2:
						return;
					case 3:
						if (string.IsNullOrEmpty(astroFilePackInfo.radioFilePath))
						{
							num = (short)1160708098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1677656064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = new global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack();
						astrolanguagePack.PackageName = string.Empty;
						string text;
						astrolanguagePack.LpID = text;
						string packageVersion;
						astrolanguagePack.PackageVersion = packageVersion;
						global::Motorola.CommonCPS.Server.EntityModel.Package package2 = astrolanguagePack;
						global::Motorola.CommonCPS.Server.EntityModel.Package package3 = astrolanguagePack;
						global::System.DateTime? dateTime = new global::System.DateTime?(global::System.DateTime.UtcNow);
						package3.CreatedDate = dateTime;
						package2.ModifiedDate = dateTime;
						astrolanguagePack.PackageLanguage = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(text.Replace('-', '_'), null);
						astrolanguagePack.CompatibleVersion = deviceInfo.SoftwareVersion;
						template.LanguagePackUuid = new global::System.Guid?(astrolanguagePack.Uuid);
						template.ASTROLanguagePack = (codeplug.ASTROLanguagePack = astrolanguagePack);
						num = (short)551682049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_44;
				}
				return;
				IL_125:
				num = (short)1219952641;
				if (num != 0)
				{
				}
				num = (short)1647028288;
				short num4 = num;
				num = (short)754165824;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)601948160;
					if (num != 0)
					{
					}
					break;
				}
				return;
				IL_44:
				astroFilePackInfo = (package as global::Motorola.Common.Communication.Pba.AstroFilePackInfo);
				num = (short)39649283;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000F9098 File Offset: 0x000F7298
		private bool ParseLanguageIDAndVersion(string source, out string packID, out string version)
		{
			int a_ = 16;
			if (global::PreEmptive.SoS.Runtime.FixedLengthStream.b("铯鏱胳꧵", a_) == source.Substring(0, 4))
			{
				short num = (short)399629764;
				short num2 = num;
				num = (short)1131797956;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1561395200;
					if (num != 0)
					{
					}
					num = (short)884080641;
					if (num != 0)
					{
					}
					num = (short)1507196928;
					short num3 = num;
					break;
				}
				}
				source = source.Substring(4);
				packID = source.Substring(0, source.IndexOf('_'));
				source = source.Substring(source.IndexOf('_') + 1);
				version = source.Substring(0, source.LastIndexOf('.'));
				return true;
			}
			packID = string.Empty;
			version = string.Empty;
			return false;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000F91BC File Offset: 0x000F73BC
		private bool ReadMC(string fileName)
		{
			int a_ = 7;
			short num;
			for (;;)
			{
				num = (short)1005387777;
				if (num != 0)
				{
				}
				num = (short)515375104;
				short num2 = num;
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볦ꫨ駪飬臮鋰鯲郴藶ꓸꃺ듼釾最氂眄樆栈缊搌怎缐丒且唖簘簚琜焞簠砢眤䈦䠨伪怬氮氰", a_));
				bool result;
				try
				{
					num = (short)1287716866;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볦ꫨ駪飬臮鋰鯲郴藶ꓸꃺ룼跾猀氂眄娆刈夊栌渎甐帒嘔䨖⌘㬚", a_) + fileName);
							result = false;
							num = (short)498335745;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_16B;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_104;
							}
							continue;
						case 3:
							goto IL_1A9;
						}
						IL_104:
						if (!((global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow).OpenCodeplug(global::System.IO.Path.GetFullPath(fileName), null, null))
						{
							num = (short)401342464;
							num3 = (int)((global::System.IntPtr)num);
						}
						else
						{
							global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.Clear();
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볦ꫨ駪飬臮鋰鯲郴藶ꓸꃺ껼諾戀怂怄理稈嘊嘌崎琐爒焔娖娘䘚✜㼞", a_) + fileName);
							num = (short)569114627;
							num3 = (int)((global::System.IntPtr)num);
						}
					}
					IL_16B:
					return result;
					IL_1A9:
					goto IL_6E;
				}
				catch (global::System.Exception ex)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꓦ鯨黪菬賮駰雲蟴꫶ꋸ뻺藼鳾搀猂焄渆昈攊倌后䌐瘒琔猖吘堚䀜┞Ġ", a_) + ex.Message);
					this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Fail);
					goto IL_6E;
				}
				return result;
				IL_6E:
				num = (short)926989636;
				short num4 = num;
				num = (short)1633271108;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A2;
				}
			}
			IL_A2:
			num = (short)1374814208;
			if (num != 0)
			{
			}
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볦ꫨ駪飬臮鋰鯲郴藶ꓸꃺ듼釾最氂眄樆栈缊搌怎缐丒且刖眘缚䀜䐞猠䘢䐤䌦搨株瀬", a_));
			return true;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000F93B4 File Offset: 0x000F75B4
		private bool SaveMC(string fileName)
		{
			int a_ = 16;
			short num;
			bool result;
			for (;;)
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯯뇱蛳菵雷駹铻鯽狿弁弃伅昇氉挋簍紏猑怓缕眗琙䄛䔝戟䜡䌣伥䘧眩眫紭儯䐱儳笵笷朹", a_));
				try
				{
					num = (short)2133131266;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							global::System.IO.File.Create(fileName).Close();
							num = (short)1700397057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_11F;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_E0;
							}
							continue;
						case 3:
							goto IL_19B;
						}
						IL_E0:
						if (!global::System.IO.File.Exists(fileName))
						{
							num = (short)2098855936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_11F:
						global::MackinawCPS.App app = (global::MackinawCPS.App)global::System.Windows.Application.Current;
						app.TheDocument.docFileName = global::System.IO.Path.GetFileName(fileName);
						app.TheDocument.docFilePath = global::System.IO.Path.GetFullPath(fileName);
						((global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow).OnAppMenuSave(this.tempSender, this.tempArgs);
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯯뇱蛳菵雷駹铻鯽狿弁弃唅紇椉漋欍挏愑䤓䴕䬗笙樛笝洟愡礣ᰥࠧ", a_) + fileName);
						num = (short)888602627;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_19B:
					goto IL_22;
				}
				catch (global::System.Exception ex)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯯뇱蛳菵雷駹铻鯽狿弁弃䌅瀇椉椋縍搏笑笓砕䔗䄙伛缝嘟䜡椣攥甧ဩఫ", a_) + ex.Message);
					result = false;
				}
				goto IL_1C4;
				IL_22:
				num = (short)1446248448;
				short num3 = num;
				num = (short)785412986;
				short num4 = num;
				num = (short)1290367866;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_80;
				}
			}
			IL_80:
			num = (short)613613568;
			if (num != 0)
			{
			}
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯯뇱蛳菵雷駹铻鯽狿弁弃伅昇氉挋簍紏猑怓缕眗琙䄛䔝攟䰡䀣笥猧礩䴫堭唯缱眳欵", a_));
			return true;
			IL_1C4:
			num = (short)729677825;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000F95BC File Offset: 0x000F77BC
		private bool ReadXPBA(string fileName)
		{
			int a_ = 15;
			short num;
			for (;;)
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("듮닰臲胴駶髸鏺飼跾尀堂䰄椆漈搊缌戎瀐朒簔砖眘䘚䘜崞䐠䐢䰤䤦琨瀪缬䨮倰圲洴朶笸稺怼", a_));
				bool result;
				try
				{
					num = (short)1734082562;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("듮닰臲胴駶髸鏺飼跾尀堂䀄甆笈搊缌刎䨐䄒瀔瘖紘䌚䴜崞怠縢ἤܦ", a_) + fileName);
							result = false;
							num = (short)2136408065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_16D;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_108;
							}
							continue;
						case 3:
							goto IL_1A0;
						}
						IL_108:
						if (!((global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow).OpenCodeplug(global::System.IO.Path.GetFullPath(fileName), null, null))
						{
							num = (short)1641414656;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("듮닰臲胴駶髸鏺飼跾尀堂嘄爆樈栊栌簎成丒且䔖簘稚礜䜞焠愢搤稦ጨପ", a_) + fileName);
							num = (short)403898371;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_16D:
					return result;
					IL_1A0:
					goto IL_22;
				}
				catch (global::System.Exception ex)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("듮닰臲胴駶髸鏺飼跾尀堂䀄缆樈渊紌笎砐簒笔䨖䈘䤚砜縞䔠笢甤攦栨瘪ᜬ༮", a_) + ex.Message);
					this.FireError(global::MackinawCPS.CommandLineCPS.Cruncher.Error.Fail);
					goto IL_22;
				}
				return result;
				IL_22:
				num = (short)1896153088;
				short num3 = num;
				num = (short)1481113601;
				if (num != 0)
				{
				}
				num = (short)11840536;
				short num4 = num;
				num = (short)1097378840;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A7;
				}
			}
			IL_A7:
			num = (short)1873477632;
			if (num != 0)
			{
			}
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("듮닰臲胴駶髸鏺飼跾尀堂䰄椆漈搊缌戎瀐朒簔砖眘䘚䘜娞传䜢砤簦笨个䰬䬮椰挲眴瘶搸", a_));
			return true;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x000F97AC File Offset: 0x000F79AC
		private bool SaveXPBA(string fileName)
		{
			int a_ = 0;
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍刏眑猓缕瘗䜙䜛䴝䄟吡䄣縥砧栩洫猭", a_));
			short num;
			bool result;
			try
			{
				num = (short)904724482;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)446110253;
					short num3 = num;
					num = (short)1149114925;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)779485184;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							global::System.IO.File.Create(fileName).Close();
							num = (short)215744513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_124;
						case 2:
							goto IL_73;
						case 3:
							goto IL_196;
						}
						goto IL_E0;
					}
					IL_73:
					switch (0)
					{
					case 0:
						IL_E0:
						if (global::System.IO.File.Exists(fileName))
						{
							goto IL_124;
						}
						num = (short)807206912;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_124:
					global::MackinawCPS.App app = (global::MackinawCPS.App)global::System.Windows.Application.Current;
					app.TheDocument.docFileName = fileName;
					app.TheDocument.docFilePath = fileName;
					((global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow).OnAppMenuSave(this.tempSender, this.tempArgs);
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳ꗵ跷駹鿻鯽珿焁夃崅嬇欉程欍䠏䈑嘓圕䔗’㰛", a_) + fileName);
					num = (short)1579548675;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_196:
				goto IL_1F;
			}
			catch (global::System.Exception ex)
			{
				if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
				{
					num = (short)1253376001;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write);
				}
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳돵胷駹駻軽瓿欁欃栅唇儉弋漍昏眑䰓䘕娗嬙䄛␝\u001f", a_) + ex.Message);
				result = false;
			}
			return result;
			IL_1F:
			num = (short)1829306368;
			short num4 = num;
			this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믟ꇡ難鏥蛧觩蓫语苯꿱꿳뿵雷鳹鏻賽淿持瀃漅朇搉儋唍唏簑瀓䬕䌗䤙紛栝䔟稡琣搥椧眩", a_));
			return true;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x000F99DC File Offset: 0x000F7BDC
		internal bool UnpackXPBA(byte[] pbaByte, string modelNumber = "")
		{
			int a_ = 7;
			short num = (short)1855127552;
			switch (num)
			{
			default:
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볦ꫨ駪飬臮鋰鯲郴藶ꓸꃺ듼釾最氂眄樆栈缊搌怎缐丒且唖簘簚琜焞簠砢瀤䤦夨䨪丬䐮椰挲眴瘶ᐸ਺怼", a_));
				bool result;
				try
				{
					num = (short)1394647868;
					short num2 = num;
					num = (short)1941939004;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1777729536;
						if (num != 0)
						{
						}
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = global::MackinawCPS.CommandLineCPS.ObjectSerializer.XmlDeserialize<global::Motorola.Common.Communication.Pba.PbaObject>(pbaByte).GetCodeplugInIshItemCollection();
						global::SpecialFeatures.Comms.Comms comms = new global::SpecialFeatures.Comms.Comms();
						try
						{
							num = (short)1566113794;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									comms.m_readRadioParams = new global::SpecialFeatures.Comms.RadioParams
									{
										ModelNumber = modelNumber
									};
									num = (short)973078529;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_12F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E7;
									}
									continue;
								case 3:
									goto IL_14B;
								}
								IL_E7:
								if (!string.IsNullOrEmpty(modelNumber))
								{
									num = (short)661192704;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12F:
								comms.unpackFromRadio(codeplugInIshItemCollection);
								num = (short)467861507;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_14B:;
						}
						finally
						{
							num = (short)2048393217;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									((global::System.IDisposable)comms).Dispose();
									num = (short)478412802;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_17F;
									}
									continue;
								case 2:
									goto IL_1B4;
								}
								IL_17F:
								if (comms == null)
								{
									break;
								}
								num = (short)487260160;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1B4:;
						}
						break;
					}
					}
					goto IL_3D;
				}
				catch (global::System.Exception ex)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볦ꫨ駪飬臮鋰鯲郴藶ꓸꃺ룼蟾戀昂甄猆怈搊挌刎䨐䘒笔朖砘砚瘜䜞焠愢搤稦ጨପ", a_) + ex.Message);
					result = false;
				}
				goto IL_1E0;
				IL_3D:
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("볦ꫨ駪飬臮鋰鯲郴藶ꓸꃺ듼釾最氂眄樆栈缊搌怎缐丒且刖眘缚䀜䐞琠䴢唤䘦䨨䀪甬缮猰爲ᠴض搸", a_));
				return true;
				IL_1E0:
				num = (short)306839552;
				short num4 = num;
				num = (short)2000617473;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000F9C50 File Offset: 0x000F7E50
		private string GetModelNumber(byte[] partitionArr)
		{
			short num = (short)163010178;
			short num2 = num;
			num = (short)490952322;
			switch (num2 == num)
			{
			}
			num = (short)2131558400;
			if (num != 0)
			{
			}
			num = (short)266076160;
			short num3 = num;
			num = (short)1030488065;
			if (num != 0)
			{
			}
			int num4 = partitionArr.Length;
			int num5 = 0;
			num5++;
			num5 += 22;
			string @string = global::System.Text.Encoding.BigEndianUnicode.GetString(partitionArr, num5, 34);
			int length = @string.IndexOf('\0');
			return @string.Substring(0, length);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000F9D28 File Offset: 0x000F7F28
		public bool UnpackXPBA(string fileName)
		{
			int a_ = 6;
			short num = (short)1798701056;
			switch (num)
			{
			default:
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뷥ꯧ飩駫胭鏯髱釳蓵ꗷꇹ뗻都替洁瘃欅椇縉攋愍縏休伓吕紗紙甛瀝紟礡焣䠥堧䬩伫䔭栯戱瘳眵ᔷ࠹愻", a_));
				bool result;
				try
				{
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFrom(global::System.IO.Path.GetFullPath(fileName));
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaObject.GetCodeplugInIshItemCollection();
					global::SpecialFeatures.Comms.Comms comms = new global::SpecialFeatures.Comms.Comms();
					try
					{
						using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = pbaObject.CodeplugData.DataPartitions.GetEnumerator())
						{
							num = (short)190251010;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)1916731394;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1255407619;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												comms.m_readRadioParams = new global::SpecialFeatures.Comms.RadioParams();
												global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
												comms.m_readRadioParams.ModelNumber = this.GetModelNumber(dataBlock.PacketValue);
												comms.unpackFromRadio(codeplugInIshItemCollection);
												num = (short)1897857028;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_15C;
												}
												continue;
											case 3:
												goto IL_244;
											case 5:
											{
												global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)195690496;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator2.Current;
												num = (short)1947009030;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
											{
												global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
												if (dataBlock.BlockType == 900)
												{
													num = (short)741015553;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_1EB:
											num = (short)104398853;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_15C:
											goto IL_1EB;
										}
										IL_244:
										break;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_254;
								case 1:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2 = dataPartition.DataBlocks.GetEnumerator();
									num = (short)1922564096;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_115;
									}
									continue;
								case 3:
									goto IL_321;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)780599301;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_254;
								case 5:
									num = (short)1691680771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (dataPartition.PartitionID == 212)
									{
										num = (short)1325793281;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								goto IL_115;
								IL_254:
								dataPartition = enumerator.Current;
								num = (short)1442381830;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_29F:
								num = (short)79298564;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_115:
								goto IL_29F;
							}
							IL_321:;
						}
					}
					finally
					{
						num = (short)1319829506;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_3F0;
							case 1:
							{
								num = (short)1705019176;
								short num3 = num;
								num = (short)1126270760;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1816526848;
									if (num != 0)
									{
									}
									((global::System.IDisposable)comms).Dispose();
									break;
								}
								num = (short)424738816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_369;
								}
								continue;
							}
							IL_369:
							if (comms == null)
							{
								break;
							}
							num = (short)2033713153;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3F0:;
					}
					goto IL_3E;
				}
				catch (global::System.Exception ex)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뷥ꯧ飩駫胭鏯髱釳蓵ꗷꇹ맻蛽揿朁球爅愇攉戋匍䬏䜑稓昕礗礙眛䘝瀟怡攣笥ሧ਩", a_) + ex.Message);
					result = false;
				}
				return result;
				IL_3E:
				num = (short)1281949697;
				if (num != 0)
				{
				}
				num = (short)1759903744;
				short num4 = num;
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뷥ꯧ飩駫胭鏯髱釳蓵ꗷꇹ뗻都替洁瘃欅椇縉攋愍縏休伓匕瘗縙䄛䔝生䰡吣䜥䬧䄩琫縭爯猱ᤳе攷", a_));
				return true;
			}
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000FA1BC File Offset: 0x000F83BC
		internal bool PackXPBA(string fileName, string modelNumber)
		{
			int a_ = 3;
			short num = (short)731054081;
			if (num != 0)
			{
			}
			num = (short)709296128;
			switch (num)
			{
			default:
			{
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꛤ闦鳨藪軬蟮铰臲ꣴ곶냸闺鯼郾猀渂搄猆怈搊挌刎䨐儒瀔瀖瀘甚䀜䐞焠䈢䘤䰦焨笪漬渮氰", a_));
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
				bool result;
				try
				{
					new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor().PrePackHandler();
					global::SpecialFeatures.Comms.Comms comms = new global::SpecialFeatures.Comms.Comms();
					try
					{
						comms.m_readRadioParams = new global::SpecialFeatures.Comms.RadioParams();
						comms.m_readRadioParams.ModelNumber = modelNumber;
						codeplug = comms.packToCodeplug();
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
						pbaObject.SetCodeplug(codeplug);
						try
						{
							pbaObject.ValidationFields = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateWriteValidationFields(pbaObject);
						}
						catch
						{
						}
						pbaObject.CodeplugData.CPVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
						pbaObject.Serialize(global::System.IO.Path.GetFullPath(fileName));
					}
					finally
					{
						num = (short)678494210;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1D2;
							case 1:
							{
								num = (short)826136129;
								short num3 = num;
								num = (short)623826497;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)742064128;
									if (num != 0)
									{
									}
									((global::System.IDisposable)comms).Dispose();
									break;
								}
								num = (short)1333460992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_14C;
								}
								continue;
							}
							IL_14C:
							if (comms == null)
							{
								break;
							}
							num = (short)2060255233;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1D2:;
					}
					goto IL_69;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.CustomException.CommonException ex2 = ex as global::Motorola.Common.CustomException.CommonException;
					if (ex2 != null && ex2.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
					{
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
						this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꛤ闦鳨藪軬蟮铰臲ꣴ곶본菺黼髾焀眂氄栆月嘊嘌弎瀐瀒縔伖䤘多尜䈞ᬠ̢", a_) + ex.Message);
						throw new global::Motorola.Common.CustomException.CommonException(global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write);
					}
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꛤ闦鳨藪軬蟮铰臲ꣴ곶본菺黼髾焀眂氄栆月嘊嘌弎瀐瀒縔伖䤘多尜䈞ᬠ̢", a_) + ex.Message);
					result = false;
				}
				return result;
				IL_69:
				num = (short)438697984;
				short num4 = num;
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("룢ꛤ闦鳨藪軬蟮铰臲ꣴ곶냸闺鯼郾猀渂搄猆怈搊挌刎䨐嘒笔猖䐘䀚䴜縞䈠䠢紤眦欨横瀬", a_));
				return true;
			}
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000FA474 File Offset: 0x000F8674
		internal void PackImportXPBA(ref global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData)
		{
			int a_ = 4;
			short num = (short)245694464;
			switch (num)
			{
			default:
			{
				num = (short)988610561;
				if (num != 0)
				{
				}
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뿣ꗥ髧鿩苫跭飯韱蛳꯵ꏷ돹鋻飽濿瀁椃朅簇按挋怍䴏䤑嘓猕缗猙爛䌝笟爡䔣䔥䌧挩䄫席弯䀱䀳渵样砹紻挽", a_));
				global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo = this.CreateDeviceInfo();
				string tempFileName = global::System.IO.Path.GetTempFileName();
				try
				{
					new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor().PrePackHandler();
					global::SpecialFeatures.Comms.Comms comms = new global::SpecialFeatures.Comms.Comms();
					try
					{
						comms.m_readRadioParams = new global::SpecialFeatures.Comms.RadioParams();
						comms.m_readRadioParams.ModelNumber = astroDeviceInfo.ModelNumber;
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = comms.packToCodeplug();
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
						pbaObject.SetCodeplug(codeplug);
						try
						{
							pbaObject.ValidationFields = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateWriteValidationFields(pbaObject);
						}
						catch
						{
						}
						pbaObject.CodeplugData.CPVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
						long num2 = pbaObject.Serialize(global::System.IO.Path.GetFullPath(tempFileName));
						cruncherData.arvFile = global::Motorola.Common.CommonLib.CombineTool.Encode(tempFileName, (int)num2, astroDeviceInfo);
					}
					finally
					{
						num = (short)1624440834;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_1B9;
							case 1:
							{
								num = (short)1051301682;
								short num4 = num;
								num = (short)1285527346;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1458307072;
									if (num != 0)
									{
									}
									((global::System.IDisposable)comms).Dispose();
									break;
								}
								num = (short)1281949696;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_132;
								}
								continue;
							}
							IL_132:
							if (comms == null)
							{
								break;
							}
							num = (short)1420230657;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1B9:;
					}
				}
				catch (global::System.Exception ex)
				{
					this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뿣ꗥ髧鿩苫跭飯韱蛳꯵ꏷ뿹蓻鷽旿爁瀃漅朇搉儋唍䀏猑眓紕儗眙氛焝刟嘡簣瘥樧欩焫ᐭု", a_) + ex.Message);
					throw;
				}
				finally
				{
					num = (short)1596260354;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_252;
						case 1:
							global::System.IO.File.Delete(tempFileName);
							num = (short)134086656;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_217;
							}
							continue;
						}
						IL_217:
						if (!global::System.IO.File.Exists(tempFileName))
						{
							break;
						}
						num = (short)1791098881;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_252:;
				}
				num = (short)720699392;
				short num5 = num;
				this.Report(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뿣ꗥ髧鿩苫跭飯韱蛳꯵ꏷ돹鋻飽濿瀁椃朅簇按挋怍䴏䤑儓砕簗䜙䜛丝䄟䄡伣漥䔧娩䌫尭䐯樱搳琵礷朹", a_));
				return;
			}
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000FA778 File Offset: 0x000F8978
		private global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo CreateDeviceInfo()
		{
			short num = (short)1139511683;
			short num2 = num;
			num = (short)927633795;
			switch (num2 == num)
			{
			}
			num = (short)1728708609;
			if (num != 0)
			{
			}
			num = (short)1463222272;
			short num3 = num;
			num = (short)303693824;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo = new global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo();
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2010)[0];
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			astroDeviceInfo.CodeplugVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
			astroDeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
			astroDeviceInfo.ModelNumber = radioInformation.General.RadInfoGeneralModelNumber_A8539.Value;
			astroDeviceInfo.SerialNumber = global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(radioInformation.General.RadInfoGeneralSerialNumber_A9122.Value));
			astroDeviceInfo.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
			astroDeviceInfo.ConnectionInfo.UniqueAddress = dataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.UIValue;
			astroDeviceInfo.SoftwareVersion = radioInformation.General.RadInfoGeneralFirmwareVersion_A8124.Value;
			astroDeviceInfo.ESN = global::Common.AESCryptoUtil.CIPHER_DEF_KEY;
			return astroDeviceInfo;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000FA8F4 File Offset: 0x000F8AF4
		private byte[] GetPbaBytes(global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			byte[] result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus_enhanced(cruncherData.pbaFile))
					{
						num2 = (short)257490944;
						short num3 = num2;
						num2 = (short)1602289665;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					result = global::Motorola.Common.CommonLib.CombineTool.Decode(cruncherData.pbaFile)[0];
					num2 = (short)225574915;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)965410817;
					if (num2 != 0)
					{
					}
					num2 = (short)1017774080;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
				{
					if (cruncherData.pbaFile == null)
					{
						return result;
					}
					num2 = (short)604100678;
					short num4 = num2;
					num2 = (short)1325258822;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1814233088;
						if (num2 != 0)
						{
						}
						num2 = (short)140443650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)148439044;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000FAA6C File Offset: 0x000F8C6C
		private void EndExecuteCommand(global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData)
		{
			short num = (short)911212545;
			if (num != 0)
			{
			}
			num = (short)963903492;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (cruncherData.Codeplug != null)
					{
						goto IL_10F;
					}
					return;
				case 1:
					cruncherData.Codeplug.Template = null;
					num = (short)257097731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)834666496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				IL_62:
				if (cruncherData == null)
				{
					break;
				}
				num = (short)1315257955;
				short num3 = num;
				num = (short)740965987;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)594935808;
					if (num != 0)
					{
					}
					num = (short)2116026370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_10F:
				num = (short)524288;
				short num4 = num;
				num = (short)1726545921;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000FABD0 File Offset: 0x000F8DD0
		private void BeginExecuteCommand(global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData)
		{
			short num = (short)1623195652;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1277886465;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (cruncherData.Codeplug != null)
					{
						goto IL_117;
					}
					return;
				case 1:
					cruncherData.Codeplug.Template = cruncherData.Template;
					num = (short)1861025795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1397096448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				IL_62:
				if (cruncherData == null)
				{
					break;
				}
				num = (short)1844251633;
				short num3 = num;
				num = (short)892079089;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)971374592;
					if (num != 0)
					{
					}
					num = (short)2086273026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_117:
				num = (short)1888944128;
				short num4 = num;
				num = (short)2145124353;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000FAD38 File Offset: 0x000F8F38
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)299696129;
			if (num != 0)
			{
			}
			num = (short)475004932;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.traceListener != null)
					{
						goto IL_112;
					}
					return;
				case 1:
					this.traceListener.Dispose();
					this.traceListener = null;
					num = (short)1141047299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)749993984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				}
				IL_5F:
				if (!disposing)
				{
					break;
				}
				num = (short)1762135409;
				short num3 = num;
				num = (short)1456541041;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)408616960;
					if (num != 0)
					{
					}
					num = (short)980811778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_112:
				num = (short)1895497728;
				short num4 = num;
				num = (short)1763966977;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000FAEA0 File Offset: 0x000F90A0
		public void Dispose()
		{
			short num = (short)1922216613;
			short num2 = num;
			num = (short)614838949;
			switch (num2 == num)
			{
			}
			num = (short)1510473729;
			if (num != 0)
			{
			}
			num = (short)1116143616;
			short num3 = num;
			num = (short)418447360;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000FAF58 File Offset: 0x000F9158
		// Note: this type is marked as 'beforefieldinit'.
		static Cruncher()
		{
			short num = (short)649447557;
			short num2 = num;
			num = (short)787466373;
			switch (num2 == num)
			{
			}
			num = (short)250085377;
			if (num != 0)
			{
			}
			num = (short)72744960;
			short num3 = num;
			num = (short)1289682944;
			if (num != 0)
			{
			}
			global::MackinawCPS.CommandLineCPS.Cruncher.theInstance = new global::MackinawCPS.CommandLineCPS.Cruncher();
		}

		// Token: 0x0400038C RID: 908
		private static global::MackinawCPS.CommandLineCPS.Cruncher theInstance;

		// Token: 0x0400038D RID: 909
		private readonly global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp _readWritePasswordApp;

		// Token: 0x0400038E RID: 910
		private global::MackinawCPS.CommandLineCPS.CruncherOperation operation;

		// Token: 0x0400038F RID: 911
		private object tempSender;

		// Token: 0x04000390 RID: 912
		private global::System.Windows.RoutedEventArgs tempArgs;

		// Token: 0x04000391 RID: 913
		private string folderName;

		// Token: 0x04000392 RID: 914
		private const string archiveExtention = ".mc";

		// Token: 0x04000393 RID: 915
		private const string pbaExtention = ".xpba";

		// Token: 0x04000394 RID: 916
		private bool legalCommandLine;

		// Token: 0x04000395 RID: 917
		private global::System.Diagnostics.TextWriterTraceListener traceListener;

		// Token: 0x04000396 RID: 918
		private global::System.Diagnostics.BooleanSwitch LoggingSwitch;

		// Token: 0x04000397 RID: 919
		private string createSerialNumber;

		// Token: 0x04000398 RID: 920
		private object locker;

		// Token: 0x04000399 RID: 921
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;

		// Token: 0x02000095 RID: 149
		private enum Error
		{
			// Token: 0x0400039B RID: 923
			Fail = 1,
			// Token: 0x0400039C RID: 924
			Parameter,
			// Token: 0x0400039D RID: 925
			File,
			// Token: 0x0400039E RID: 926
			Device,
			// Token: 0x0400039F RID: 927
			ColumnObject,
			// Token: 0x040003A0 RID: 928
			Clone
		}
	}
}
