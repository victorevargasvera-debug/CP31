using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AutoUpdate;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.RMDiscoveryServiceInterface;

namespace IncompatibilityHandler
{
	// Token: 0x02000003 RID: 3
	public class IncompatibilityHandlerHelper
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public bool DetectAndHandleIncompatibility()
		{
			int a_ = 7;
			short num = (short)999424000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				bool result;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						num = (short)605159428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_F5;
					case 2:
						return result;
					case 3:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AutoUpdate != null)
						{
							num = (short)1897594880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F7;
					case 4:
						num = (short)1647443969;
						if (num != 0)
						{
						}
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AutoUpdate.Equals(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("䥷", a_)))
						{
							num = (short)527826945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F7;
					}
					goto IL_4C;
					IL_F7:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("⭷ό๻ࡽꒃﾋ랏뒓튟횡蒣장\udda7\udea9쎫\udbad삯횱햳습\uddb7钹", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
					global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Client_Server_Not_Compatible_But_Server_NotSupport_Autoupdate, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					num = (short)1068433408;
					short num3 = num;
					num = (short)1847853058;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F5:
				try
				{
					num = (short)670629888;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1B0;
							}
							continue;
						case 1:
						{
							string svcType;
							global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement channel = global::AutoUpdate.AutoUpdateHelper.GetChannel(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("ͷ䉹䡻䩽뉿쎁솃쎅놇꞉쾋뢍ꆏꊑ릓ꊕ\ude97\udf99\ude9b뎝颟鞡鎣醥薧颩閫馭螯足躵﮷貹﮽뿁", a_), global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort, svcType, global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("㥷⥹⡻ⱽ콿", a_), global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword, false, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.JwtToken);
							string componentName = global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("㭷⩹⽻", a_);
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
							{
								componentName = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ComponentName_RMC;
							}
							else
							{
								if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template)
								{
									goto IL_342;
								}
								componentName = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ComponentName_CPS;
							}
							global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement discoveryClient = channel;
							this.DownloadAndRunInstaller(componentName, discoveryClient);
							result = true;
							num = (short)1015545864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_3DC;
						case 3:
							goto IL_3F4;
						case 4:
						{
							global::AutoUpdate.AutoUpdateHelper.DeleteAutoUpdateOutdatedFiles(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.OffsetHoursToDelete);
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("⡷ࡹ᥻๽ꚅﲇ겋ﾏﲑ望ﮗ벛쾟芡삣쾥\udba7즩쎫\ud8ad햯삱춳隵쮷\udfb9캻좽ꖿ냁ꃅꟇ룉꿍ꗏꛑ믓귗꫙룛뿝铟蟡쫣", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							string svcType = global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("⩷㝹㡻᝽\udd8d", a_);
							num = (short)2110618678;
							short num4 = num;
							num = (short)1406565430;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)1547042816;
								if (num != 0)
								{
								}
								num = (short)1992294401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_3DC;
						case 6:
							if (this.a())
							{
								num = (short)1178140676;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("⵷ॹ᥻౽ꁿ黎꺍望ﶗ벛좟쮡좣쎥袧얩\ud8ab욭햯삱钳\udfb5횷즹좻\udfbd꺿ꇁꇃ뗅ꗉ꫋꓏뫑뷓ꗕ裙釛鷝샟諡藣郥跧쫩軫语闯鳱퓳鋵鷷軹駻鷽瓿朁怃⨅⠇渉攋簍甏焑怓稕愗㨙笛焝\u001f䀡䔣䔥䌧਩堫䄭ု䄱儳䈵䰷匹刻夽怿♁ⵃ❅⑇╉⭋恍", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num = (short)461635589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("⵷ॹ᥻౽ꁿﺋ뒓몙ﾛ캟횡춣좥\udda7쾩貫\udbad삯햱욳ힵ\udcb7펹튻\ud9bd", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num = (short)832831494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_3DC;
						}
						IL_1B0:
						if (global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.SERVER_CLIENT_VERSION_INCOMPATIBLE, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Confirm))
						{
							num = (short)1301413895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("⵷ॹ᥻౽ꁿﶍ낏ﲑﮓ뢗뺝햟튡쎣풥즧캩즫芭邯욱\udcb3펵횷骹\ud8bbힽ늿ꟁꟃ닅꓇돉꧍뿏뛓럕믗뇙ﳛꫝ迟싡韣菥鳧黩藫胭韯틱郳鿵駷雹鏻駽⻿", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
						num = (short)1727004674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3DC:
						num = (short)315359235;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_342:
					throw new global::System.Exception(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("㙷ᕹࡻ幽꺍ﶏ﶑뚗", a_));
					IL_3F4:;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogExpToFilenEvent(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventError, global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("㱷όࡻ᭽얃슉ﺑ\udf95蓮킟쎡킣쾥쪧쎩삫잭쒯쮱", a_));
					global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(ex, true, false);
				}
				catch (global::System.Exception ex2)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogExpToFilenEvent(ex2, global::Motorola.Common.LogUtility.LoggingLevel.EventError, global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("㱷όࡻ᭽얃슉ﺑ\udf95蓮킟쎡킣쾥쪧쎩삫잭쒯쮱", a_));
					global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(ex2, true, false);
				}
				return result;
				IL_4C:
				result = false;
				num = (short)1279131651;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002594 File Offset: 0x00000794
		private bool a()
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("풀ꦈﺐ랖ﺚ\ud8a0莢튤쾦삨잪좬辮\udeb0잲\uddb4튶쮸鮺풼톾닀럂꓄꧆꫈껊뻌뻐뗒ꏖ뇘닚껜￞돠껢ꛤ쟦臨諪鯬諮퇰釲郴鋶韸\udbfa駼髾甀昂昄猆氈漊", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
					num2 = (short)835452930;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					goto IL_1DD;
				case 3:
					goto IL_1DD;
				case 4:
					try
					{
						num2 = (short)1924792321;
						if (num2 != 0)
						{
						}
						int num3 = global::AutoUpdate.AutoUpdateHelper.DetectAllOtherInstancesOfCurrentProcess();
						goto IL_127;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogExpToFilenEvent(e, global::Motorola.Common.LogUtility.LoggingLevel.EventError, global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("얀ﾊ첌\udb92練ﶘ횞쾠삢쪤쪦\ud9a8쪪\ud9ac욮펰\udab2\ud9b4\udeb6춸슺", a_));
						int num3 = 1;
						goto IL_127;
					}
					goto IL_1AD;
					IL_127:
					num2 = (short)1839464455;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("캀ﮈꮊ練滛ﺚ뾞캠얢薤펦솨슪\udeac辮ﺲ鞶톸\udaba쮼\udabeꇂꃄꋆꟈ꧌꫎ꗐ뛒뛔ꏖ볘뿚", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
					num2 = (short)445644806;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)1113019921;
					short num4 = num2;
					num2 = (short)1368479249;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1742929920;
						if (num2 != 0)
						{
						}
						if (global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowRetryDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.OtherInstancesAreRunning, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Confirm))
						{
							num2 = (short)826933248;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1AD;
					}
					break;
				}
				case 7:
				{
					int num3;
					if (num3 > 0)
					{
						num2 = (short)51970053;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_39;
				IL_1AD:
				result = false;
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("풀ꦈﺐ랖滛漢ﲞ쒠쾢薤킦솨슪솬쪮醰\udcb2솴\udfb6\udcb8즺鶼횾꿀냂뇄ꛆꟈ꣊꣌볎볒돔귘돚드곞쇠뇢꣤ꓦ짨菪賬駮铰폲韴鋶鳸闺\uddfc鯾搀眂怄搆紈渊椌", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
				num2 = (short)384303105;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1DD:
				num2 = (short)1678639108;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_39:
			result = true;
			num2 = (short)1715339264;
			short num5 = num2;
			num2 = (short)1443954691;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000027DC File Offset: 0x000009DC
		public void DownloadAndRunInstaller(string componentName, global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement discoveryClient)
		{
			int a_ = 16;
			short num = (short)962396160;
			switch (num)
			{
			default:
			{
				num = (short)9633793;
				if (num != 0)
				{
				}
				num = (short)1513488384;
				short num2 = num;
				global::IncompatibilityHandler.IncompatibilityHandlerHelper.a a = new global::IncompatibilityHandler.IncompatibilityHandlerHelper.a();
				a.b = this;
				a.c = componentName;
				a.d = discoveryClient;
				a.a = new global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext
				{
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.Downloading_Title,
					CancellationToken = new global::System.Threading.CancellationTokenSource()
				};
				a.e = new global::System.Progress<global::AutoUpdate.DownloadStatus>(new global::System.Action<global::AutoUpdate.DownloadStatus>(a.f));
				try
				{
					global::System.Threading.Tasks.Task<global::AutoUpdate.AutoUpgradeFile> task = global::System.Threading.Tasks.Task.Run<global::AutoUpdate.AutoUpgradeFile>(new global::System.Func<global::System.Threading.Tasks.Task<global::AutoUpdate.AutoUpgradeFile>>(a.f));
					global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowProgressDialog(a.a);
					try
					{
						global::AutoUpdate.AutoUpgradeFile result = task.GetAwaiter().GetResult();
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("쎀力搜ﾐ떔뾞슠첢좤힦얨캪\ud9ac쪮햰鎲운슶\udab8\ud8ba\ud8bc첾닀ꗂ냄ꯆꗈ닊", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
						this.InitializeInstallation(result);
					}
					catch (global::System.OperationCanceledException)
					{
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("쎀力搜ﾐ떔뾞즠슢횤螦쮨캪좬솮醰킲풴\ud9b6\udab8\udeba톼\udabeꗀ", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
					}
					catch (global::Motorola.Common.CustomException.CommonException ex)
					{
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(ex.Message, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogExpToFilenEvent(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventError, "");
					}
				}
				finally
				{
					num = (short)1956167110;
					short num3 = num;
					num = (short)1988869574;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)74776576;
						if (num != 0)
						{
						}
						num = (short)1442512897;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								goto IL_23D;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1E4;
								}
								continue;
							case 2:
								a.a.Rate = 100.0;
								num = (short)1713831936;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1E4:
							if (a.a.Rate >= 100.0)
							{
								break;
							}
							num = (short)623050754;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_23D:
						break;
					}
					}
				}
				return;
			}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002A54 File Offset: 0x00000C54
		public void InitializeInstallation(global::AutoUpdate.AutoUpgradeFile autoUpgradeFile)
		{
			int a_ = 3;
			short num;
			try
			{
				num = (short)1590362112;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					string filePath;
					bool flag;
					for (;;)
					{
						IL_32:
						string text;
						string text2;
						switch (num2)
						{
						case 0:
						{
							string extension = global::System.IO.Path.GetExtension(filePath);
							if (extension == null)
							{
								num = (short)1405157381;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = extension.ToLowerInvariant();
							goto IL_2B5;
						}
						case 1:
							if (text2 == global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("婳፵wό", a_))
							{
								num = (short)1601634315;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15E;
						case 2:
							goto IL_1CC;
						case 3:
							goto IL_1CC;
						case 4:
							goto IL_407;
						case 5:
							text = null;
							goto IL_2B5;
						case 6:
							if (global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowRetryDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.OtherInstallersAreRunning, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Confirm))
							{
								num = (short)1309474832;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("ⅳյᵷࡹ屻ᵽꪉﺏ歹뢗첟잡蒣즥\udca7슩즫\udcad邯\udbb1\udab3억첷\udbb9킻튽ꆿ뛁귃꧅ꛇ볋볍뿏뇑뇓ꗕꯗ龎듛뿝鏟싡蛣菥跧蓩쳫諭闯蛱釳闵賷鿹飻", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num = (short)1132331022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_1CC;
						case 8:
							if (text2 == global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("婳౵ᅷ੹", a_))
							{
								num = (short)668598287;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1328807937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (!global::AutoUpdate.AutoUpdateHelper.CheckIfOtherInstallationIsInProgress())
							{
								num = (short)979042321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("㭳ɵၷό๻幽ﮑﮓ뢗쎟잡힣향袧쎩\udfab躭\ud9af\udcb1钳욵쪷햹\udbbb첽ꖿ뇁럃", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num = (short)1773404166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_3A8;
						case 11:
						{
							string filePath2 = filePath;
							num = (short)165347335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							if (flag)
							{
								num = (short)478412813;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A8;
						case 13:
						{
							num = (short)829369042;
							short num3 = num;
							num = (short)1546922706;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3EE;
							default:
							{
								num = (short)1906769920;
								if (num != 0)
								{
								}
								string filePath2;
								global::AutoUpdate.AutoUpdateHelper.StartCpsInstallation(filePath2, autoUpgradeFile.CommandLineArguments);
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("♳㭵㭷婹ᵻ୽낏晴뢗鍊ﮝ캟芡힣튥즧\ud8a9\ud8ab쮭풯銱햳\ud8b5\udcb7骹좻횽ꖿꟃ독뫇룉꧋ꃍ꓏蛓鯕鯗龎ꯛ럝賟軡쓣韥鷧菩飫컭黯鷱菳\ud8f5", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
								num = (short)1048313866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 14:
							goto IL_304;
						case 15:
						{
							string filePath2 = global::IncompatibilityHandler.IncompatibilityHandlerHelper.a(filePath, autoUpgradeFile.ExecutableFileName);
							num = (short)1824653315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("ⅳյᵷࡹ屻ᵽꪉﺋ뚕얟芡쮣튥삧쾩\udeab躭\ud9af\udcb1잳습\ud9b7횹킻\udfbd뒿ꯁꯃꣅ뫉뻋ꇍ돏럑ꟓꗕ닙뷛귝샟胡臣菥蛧쫩裫语蓯韱音苵鷷黹", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num = (short)1315831810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							goto IL_304;
						}
						goto IL_81;
						IL_1CC:
						num = (short)1261895689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B5:
						text2 = text;
						num = (short)258539528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_304:
						num = (short)94371852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3EE:
						num = (short)367722500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A8:
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("⁳ṵᵷ婹ቻ᭽ꊁ慎ﲉﲍ낏劣肟쪡얣향袧좩즫쮭\udeaf銱잳ힵ캷\udfb9\ud8bb麽ꦿ곁독믇꿉뻋ꏏ럑ꃓꋕ뇗듙믛샟꟡鳣迥鳧쫩飫蛭闯틱音菵諷裹駻都瓿∁攃瘅砇昉攋洍焏昑紓礕瘗㐙", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
						global::System.Diagnostics.Process.GetCurrentProcess().Kill();
						goto IL_3EE;
					}
					IL_15E:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Generic_File_Does_NOT_Exist, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.Generic_File_Does_NOT_Exist.ToString(), null));
					IL_407:
					break;
					IL_81:
					flag = true;
					filePath = autoUpgradeFile.FilePath;
					num = (short)327090176;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogExpToFilenEvent(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventError, "");
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(ex, true, false);
			}
			num = (short)1441726465;
			if (num != 0)
			{
			}
			num = (short)1128398848;
			short num4 = num;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002EF0 File Offset: 0x000010F0
		private static string a(string A_0, string A_1)
		{
			short num = (short)1965490176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string text = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(A_0), global::System.Guid.NewGuid().ToString());
				string text2 = global::System.IO.Path.Combine(text, A_1);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					for (;;)
					{
						IL_52:
						switch (num2)
						{
						case 0:
							num = (short)1176502273;
							if (num != 0)
							{
							}
							try
							{
								global::System.IO.File.Delete(A_0);
							}
							catch (global::System.Exception e)
							{
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogExpToFilenEvent(e, global::Motorola.Common.LogUtility.LoggingLevel.EventError, "");
							}
							num = (short)580517890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (!global::System.IO.File.Exists(text2))
							{
								num = (short)1705639939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1665602153;
							short num3 = num;
							num = (short)468718185;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A3;
							default:
								num = (short)389742592;
								if (num != 0)
								{
								}
								num = (short)973340672;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_184;
						case 3:
							goto IL_A3;
						}
						goto IL_69;
					}
					IL_A3:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Generic_File_Does_NOT_Exist, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.Generic_File_Does_NOT_Exist.ToString(), null));
					IL_184:
					goto IL_19C;
					IL_69:
					global::System.IO.Compression.ZipFile.ExtractToDirectory(A_0, text);
					num = (short)1578237953;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_52;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogExpToFilenEvent(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventError, "");
					global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(ex, true, false);
				}
				IL_19C:
				num = (short)1361575936;
				short num4 = num;
				return text2;
			}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000030F8 File Offset: 0x000012F8
		public string ConvertDownloadStatusObjectToStringFormat(global::AutoUpdate.DownloadStatus downloadStatus)
		{
			short num = (short)1129185281;
			if (num != 0)
			{
			}
			num = (short)1698165469;
			short num2 = num;
			num = (short)217248477;
			switch (num2 == num)
			{
			}
			num = (short)1558773760;
			if (num != 0)
			{
			}
			num = (short)640221184;
			short num3 = num;
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.AutoupdateDownloadProgressDesc, new object[]
			{
				(double)downloadStatus.DownloadedSize / 1024.0 / 1024.0,
				(double)downloadStatus.TotalSize / 1024.0 / 1024.0,
				(int)downloadStatus.EstimateRemainingTime.TotalMinutes,
				(int)downloadStatus.EstimateRemainingTime.TotalSeconds % 60,
				downloadStatus.Speed
			});
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003248 File Offset: 0x00001448
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1440230089 + A_1) + (global::System.IntPtr)10 + (global::System.IntPtr)6 + (global::System.IntPtr)62 + (global::System.IntPtr)43 + (global::System.IntPtr)46);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x04000003 RID: 3
		private const string a = "{8442AEE9-C610-4FEB-8577-2977C98C6DE2}";

		// Token: 0x02000004 RID: 4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600000D RID: 13 RVA: 0x000032E8 File Offset: 0x000014E8
			internal void f(global::AutoUpdate.DownloadStatus A_0)
			{
				short num = (short)249045312;
				short num2 = num;
				num = (short)1894129984;
				switch (num2 == num)
				{
				}
				num = (short)1630011393;
				if (num != 0)
				{
				}
				num = (short)155648000;
				if (num != 0)
				{
				}
				num = (short)856489984;
				short num3 = num;
				this.a.Rate = (double)A_0.GetPercentage();
				this.a.Description = this.b.ConvertDownloadStatusObjectToStringFormat(A_0);
			}

			// Token: 0x0600000E RID: 14 RVA: 0x000033BC File Offset: 0x000015BC
			internal global::System.Threading.Tasks.Task<global::AutoUpdate.AutoUpgradeFile> f()
			{
				int a_ = 6;
				short num = (short)1825984309;
				short num2 = num;
				num = (short)1423593269;
				switch (num2 == num)
				{
				}
				num = (short)623116288;
				if (num != 0)
				{
				}
				num = (short)646643713;
				if (num != 0)
				{
				}
				num = (short)447545344;
				short num3 = num;
				return global::AutoUpdate.AutoUpdateHelper.GetFile(this.c, global::IncompatibilityHandler.IncompatibilityHandlerHelper.b("㙶⩸⽺⽼ま", a_), this.d, this.a.CancellationToken, this.e);
			}

			// Token: 0x04000004 RID: 4
			public global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext a;

			// Token: 0x04000005 RID: 5
			public global::IncompatibilityHandler.IncompatibilityHandlerHelper b;

			// Token: 0x04000006 RID: 6
			public string c;

			// Token: 0x04000007 RID: 7
			public global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement d;

			// Token: 0x04000008 RID: 8
			public global::System.Progress<global::AutoUpdate.DownloadStatus> e;
		}
	}
}
