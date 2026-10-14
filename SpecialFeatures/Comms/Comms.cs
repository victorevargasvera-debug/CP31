using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using AcpBusinessLayer;
using AcpCommonLib;
using Common;
using CommonResources;
using ConstraintHelper;
using Motorola.Acp.PackUnpack.Ish;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.PackExec;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Programming;
using SpecialFeatures.RadioFeatureSet;
using SpecialFeatures.RadioLanguagePack;
using SpecialFeatures.Security;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000168 RID: 360
	public class Comms : global::System.IDisposable
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06001222 RID: 4642 RVA: 0x0018A310 File Offset: 0x00188510
		// (remove) Token: 0x06001223 RID: 4643 RVA: 0x0018A440 File Offset: 0x00188640
		public static event global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus updateStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1534471090;
				short num2 = num;
				num = (short)1489513394;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_6C:
					num = (short)2021785601;
					if (num != 0)
					{
					}
					num = (short)698286080;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1951006720;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					break;
				}
				global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus displayUpdateStatus;
				for (;;)
				{
					global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus displayUpdateStatus2;
					switch (num3)
					{
					case 0:
						goto IL_AA;
					case 1:
						if (displayUpdateStatus == displayUpdateStatus2)
						{
							num = (short)1375076354;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA;
					case 2:
						goto IL_F9;
					}
					goto IL_66;
					IL_AA:
					displayUpdateStatus2 = displayUpdateStatus;
					global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus value2 = (global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus)global::System.Delegate.Combine(displayUpdateStatus2, value);
					displayUpdateStatus = global::System.Threading.Interlocked.CompareExchange<global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus>(ref global::SpecialFeatures.Comms.Comms.a, value2, displayUpdateStatus2);
					num = (short)1046216705;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_F9:
				num = (short)188612608;
				short num4 = num;
				return;
				IL_66:
				displayUpdateStatus = global::SpecialFeatures.Comms.Comms.a;
				goto IL_6C;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1089914962;
				short num2 = num;
				num = (short)356042834;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_93:
					num = (short)1475936256;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)727252992;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus displayUpdateStatus;
				for (;;)
				{
					global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus displayUpdateStatus2;
					switch (num3)
					{
					case 0:
						goto IL_AB;
					case 1:
						if (displayUpdateStatus == displayUpdateStatus2)
						{
							num = (short)631373826;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB;
					case 2:
						goto IL_FA;
					}
					goto IL_67;
					IL_AB:
					displayUpdateStatus2 = displayUpdateStatus;
					global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus value2 = (global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus)global::System.Delegate.Remove(displayUpdateStatus2, value);
					displayUpdateStatus = global::System.Threading.Interlocked.CompareExchange<global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus>(ref global::SpecialFeatures.Comms.Comms.a, value2, displayUpdateStatus2);
					num = (short)1092878337;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FA:
				num = (short)1741225984;
				short num4 = num;
				return;
				IL_67:
				num = (short)962068481;
				if (num != 0)
				{
				}
				displayUpdateStatus = global::SpecialFeatures.Comms.Comms.a;
				goto IL_93;
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06001224 RID: 4644 RVA: 0x0018A574 File Offset: 0x00188774
		// (remove) Token: 0x06001225 RID: 4645 RVA: 0x0018A6A0 File Offset: 0x001888A0
		public static event global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI displayCBI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)602740228;
				short num2 = num;
				num = (short)2035553796;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_92:
					num = (short)1806303232;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1496449025;
					if (num != 0)
					{
					}
					num = (short)1705443328;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8C;
					}
					break;
				}
				global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI mainUIDisplayCBI;
				for (;;)
				{
					global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI mainUIDisplayCBI2;
					switch (num3)
					{
					case 0:
						goto IL_A9;
					case 1:
						if (mainUIDisplayCBI == mainUIDisplayCBI2)
						{
							num = (short)602079234;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A9;
					case 2:
						goto IL_F3;
					}
					goto IL_8C;
					IL_A9:
					mainUIDisplayCBI2 = mainUIDisplayCBI;
					global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI value2 = (global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI)global::System.Delegate.Combine(mainUIDisplayCBI2, value);
					mainUIDisplayCBI = global::System.Threading.Interlocked.CompareExchange<global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI>(ref global::SpecialFeatures.Comms.Comms.b, value2, mainUIDisplayCBI2);
					num = (short)1858142209;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_F3:
				num = (short)900661248;
				short num4 = num;
				return;
				IL_8C:
				mainUIDisplayCBI = global::SpecialFeatures.Comms.Comms.b;
				goto IL_92;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1234806080;
				short num2 = num;
				num = (short)1901634880;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1935343616;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					int num3;
					global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI mainUIDisplayCBI;
					for (;;)
					{
						IL_54:
						global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI mainUIDisplayCBI2;
						switch (num3)
						{
						case 0:
							goto IL_F6;
						case 1:
							num = (short)884998145;
							if (num != 0)
							{
							}
							if (mainUIDisplayCBI == mainUIDisplayCBI2)
							{
								num = (short)106168320;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_82;
						case 2:
							goto IL_82;
						}
						break;
						IL_82:
						mainUIDisplayCBI2 = mainUIDisplayCBI;
						global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI value2 = (global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI)global::System.Delegate.Remove(mainUIDisplayCBI2, value);
						mainUIDisplayCBI = global::System.Threading.Interlocked.CompareExchange<global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI>(ref global::SpecialFeatures.Comms.Comms.b, value2, mainUIDisplayCBI2);
						num = (short)361037825;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_66:
					mainUIDisplayCBI = global::SpecialFeatures.Comms.Comms.b;
					num = (short)1565327362;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_54;
				}
				}
				IL_F6:
				num = (short)1285292032;
				short num4 = num;
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06001226 RID: 4646 RVA: 0x0018A7D0 File Offset: 0x001889D0
		// (remove) Token: 0x06001227 RID: 4647 RVA: 0x0018A904 File Offset: 0x00188B04
		public static event global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP displayOTAP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1639770462;
				short num2 = num;
				num = (short)743893342;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)171573248;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					int num3;
					global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP mainUIDisplayOTAP;
					for (;;)
					{
						IL_55:
						global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP mainUIDisplayOTAP2;
						switch (num3)
						{
						case 0:
							goto IL_F9;
						case 1:
							if (mainUIDisplayOTAP == mainUIDisplayOTAP2)
							{
								num = (short)682295296;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AA;
						case 2:
							goto IL_AA;
						}
						break;
						IL_AA:
						mainUIDisplayOTAP2 = mainUIDisplayOTAP;
						global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP value2 = (global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP)global::System.Delegate.Combine(mainUIDisplayOTAP2, value);
						mainUIDisplayOTAP = global::System.Threading.Interlocked.CompareExchange<global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP>(ref global::SpecialFeatures.Comms.Comms.c, value2, mainUIDisplayOTAP2);
						num = (short)1830682625;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_67:
					mainUIDisplayOTAP = global::SpecialFeatures.Comms.Comms.c;
					num = (short)108199937;
					if (num != 0)
					{
					}
					num = (short)949026818;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_55;
				}
				}
				IL_F9:
				num = (short)53936128;
				short num4 = num;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1518809134;
				short num2 = num;
				num = (short)200683566;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)438894592;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					int num3;
					global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP mainUIDisplayOTAP;
					for (;;)
					{
						IL_57:
						global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP mainUIDisplayOTAP2;
						switch (num3)
						{
						case 0:
							goto IL_CE;
						case 1:
							if (mainUIDisplayOTAP == mainUIDisplayOTAP2)
							{
								num = (short)305201152;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_85;
						case 2:
							goto IL_85;
						}
						break;
						IL_85:
						mainUIDisplayOTAP2 = mainUIDisplayOTAP;
						global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP value2 = (global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP)global::System.Delegate.Remove(mainUIDisplayOTAP2, value);
						mainUIDisplayOTAP = global::System.Threading.Interlocked.CompareExchange<global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP>(ref global::SpecialFeatures.Comms.Comms.c, value2, mainUIDisplayOTAP2);
						num = (short)1895038977;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_69:
					mainUIDisplayOTAP = global::SpecialFeatures.Comms.Comms.c;
					num = (short)994050050;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_57;
				}
				}
				IL_CE:
				num = (short)84279297;
				if (num != 0)
				{
				}
				num = (short)1418526720;
				short num4 = num;
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0018AA30 File Offset: 0x00188C30
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadRadio(global::SpecialFeatures.Comms.COMMS_OP readType, object lastCommsUserState)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (lastCommsUserState != null)
					{
						num2 = (short)624230403;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_64;
				case 1:
					goto IL_80;
				case 2:
					num2 = (short)2033975296;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1357943226;
					short num3 = num2;
					num2 = (short)710185402;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						num2 = (short)1011613696;
						if (num2 != 0)
						{
						}
						this.d = (lastCommsUserState as global::SpecialFeatures.Programming.OTAPProgrammingParameters);
						num2 = (short)1185939460;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_D2;
				case 5:
					if (readType == global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
					{
						num2 = (short)1344077826;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_187;
				}
				goto IL_28;
				IL_64:
				this.d = null;
				num2 = (short)719126529;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_80:
			num2 = (short)1520369664;
			short num4 = num2;
			goto IL_187;
			IL_D2:
			num2 = (short)1911685121;
			if (num2 != 0)
			{
			}
			IL_187:
			string empty = string.Empty;
			return this.ReadRadio(readType, ref empty, false, false);
			IL_28:
			this.m_readRadioParams = null;
			num2 = (short)1855979525;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0018ABD8 File Offset: 0x00188DD8
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadRadio(global::SpecialFeatures.Comms.COMMS_OP readType, ref string errorMsg, bool isCruncherWriteCheckPBA = false, bool isCruncherMode = false)
		{
			int a_ = 3;
			short num = (short)1105854464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				bool flag;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection result;
				global::SpecialFeatures.Comms.RadioParams radioParams;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_15B;
							}
							global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
							for (;;)
							{
								IL_E8:
								global::Motorola.Common.Communication.Pba.PbaObject pbaObject2;
								switch (num2)
								{
								case 0:
									goto IL_3D5;
								case 1:
									this.m_CustomerId = global::SpecialFeatures.Comms.ParseDataHelper.ReadCustomerID(pbaObject);
									num = (short)575537165;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)27787283;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)353042437;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (this.m_readRadioParams.ModelNumber.Equals(global::CommonResources.AppResources.Txm_3000_Model_Number))
									{
										num = (short)140378115;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D5;
								case 5:
									if (!isCruncherMode)
									{
										num = (short)1588068376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D5;
								case 6:
									global::SpecialFeatures.Comms.Comms.a(1.0, global::CommonResources.AppResources.Read_Radio_Info_Complete);
									num = (short)2017525764;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									errorMsg = global::CommonResources.AppResources.The_radio_being_read_is_KILLED;
									global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, errorMsg);
									global::SpecialFeatures.Comms.Comms.a(0.0, errorMsg);
									flag = false;
									num = (short)2092433420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									result = pbaObject2.GetCodeplugInIshItemCollection();
									this.m_RadioSystemIds = global::SpecialFeatures.Comms.ParseDataHelper.ReadRadioTrkSystemNamesTypesAndUnitIds(pbaObject2.GetCodeplugInIshItemCollection());
									this.m_RadioCnvSysIds = global::SpecialFeatures.Comms.ParseDataHelper.ReadConvSysIds(pbaObject2);
									this.m_AstroOtarRadioIds = global::SpecialFeatures.Comms.ParseDataHelper.ReadAstroOtarRadioIds(pbaObject2);
									num = (short)717422618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
									radioInformation.General.RadInfoGeneralInstalledTxmCertificate_UIValue = global::CommonResources.AcgResources.ID_NONE;
									num = (short)655622158;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (pbaObject2 != null)
									{
										num = (short)1917714440;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_440;
								case 11:
									if (flag)
									{
										num = (short)1370685446;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_69F;
								case 12:
									goto IL_626;
								case 13:
									if (!global::SpecialFeatures.Security.RadioAccessValidator.CheckIfCustomerIDIsInACK(this.c()))
									{
										num = (short)1611726855;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_626;
								case 14:
									goto IL_3D5;
								case 15:
									if (flag)
									{
										num = (short)78250006;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_546;
								case 16:
									if (this.d() && flag)
									{
										num = (short)2359297;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_626;
								case 17:
									goto IL_6B8;
								case 18:
									errorMsg = global::CommonResources.AppResources.The_radio_being_read_is_INHIBITED;
									global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, errorMsg);
									global::SpecialFeatures.Comms.Comms.a(0.0, errorMsg);
									flag = false;
									num = (short)1220935700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									if (this.e())
									{
										num = (short)543162386;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_256;
								case 20:
									goto IL_256;
								case 21:
									goto IL_546;
								case 22:
									flag = this.a(readType, radioParams.SerialNumber);
									num = (short)1483210773;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									if (!isCruncherWriteCheckPBA)
									{
										num = (short)1795751938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_256;
								case 24:
								{
									string path = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦅ쮇욉얋쮍\ude8f욑쮓햕\udd97좙좛놝瑱殮ﺫ節龯", a_);
									string text = this.h.QueryTxmCertificate(this.m_readRadioParams, path);
									global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
									num = (short)104202265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
								{
									string text;
									if (text == null)
									{
										num = (short)18677769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
									radioInformation.General.RadInfoGeneralInstalledTxmCertificate_UIValue = text;
									num = (short)1016922112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
									goto IL_69F;
								}
								goto IL_15B;
								IL_256:
								num = (short)944766992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3D5:
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.ReadRadio_Reading_codeplug_from_radio);
								pbaObject2 = this.h.Read(radioParams, new global::System.ComponentModel.ProgressChangedEventHandler(this.b));
								num = (short)1969422346;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_546:
								num = (short)192151563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_626:
								num = (short)494993423;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_69F:
								num = (short)311033873;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_440:
							throw new global::System.Exception(global::CommonResources.AppResources.Read_radio_PBA_is_null);
							IL_6B8:
							return result;
							IL_15B:
							global::SpecialFeatures.Comms.Comms.a(1.0, global::CommonResources.AppResources.Open_Port_Complete);
							global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Read_Radio_Info);
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
							global::Motorola.Common.Communication.CommonUtil.IshHeader item = new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1026, 0);
							list.Add(item);
							item = new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1029, 0);
							list.Add(item);
							item = new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1030, 0);
							list.Add(item);
							pbaObject = this.h.ReadBlock(radioParams, list, new global::System.ComponentModel.ProgressChangedEventHandler(this.b));
							this.m_RadioInhibitedTrunking = global::SpecialFeatures.Comms.ParseDataHelper.IsRadioInhibitedTrunking(pbaObject);
							this.m_RadioKilled = global::SpecialFeatures.Comms.ParseDataHelper.IsRadioKilled(pbaObject);
							this.a(pbaObject);
							num = (short)1279655959;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_E8;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							global::SpecialFeatures.Comms.Comms.a(0.0, ex.Message);
							return result;
						}
						catch (global::System.Exception ex2)
						{
							if (!string.IsNullOrEmpty(ex2.Message))
							{
								global::SpecialFeatures.Comms.Comms.a(0.0, ex2.Message);
							}
							else
							{
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Failed_to_communicate_with_the_radio);
							}
							global::System.Exception innerException = ex2.InnerException;
							global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
							{
								global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd85", a_),
								global::System.DateTime.Now.ToString(),
								global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚅꖇꪉ", a_),
								ex2.Message,
								global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb85", a_)
							}));
							return result;
						}
						finally
						{
							num = (short)1841758210;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_84E;
								case 1:
								{
									num = (short)1021960266;
									short num3 = num;
									num = (short)1613226058;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_7CA;
									default:
										num = (short)94830592;
										if (num != 0)
										{
										}
										global::System.Threading.Thread.Sleep(500);
										num = (short)1358233600;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7C3;
									}
									continue;
								}
								goto IL_7C3;
								IL_7CA:
								num = (short)1118371841;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7C3:
								if (readType == global::SpecialFeatures.Comms.COMMS_OP.USB_READ_WRITE)
								{
									goto IL_7CA;
								}
								break;
							}
							IL_84E:
							this.a();
						}
						goto IL_857;
					case 1:
						goto IL_857;
					case 2:
					{
						num = (short)896401408;
						short num4 = num;
						if (flag)
						{
							num = (short)1256128513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A5;
					}
					}
					goto IL_43;
					IL_857:
					num = (short)1461780481;
					if (num != 0)
					{
					}
					this.m_readRadioParams = radioParams;
					num = (short)1951137792;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_8A5:
				global::SpecialFeatures.Comms.Logger.Log(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd85", a_) + global::System.DateTime.Now.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚅꖇꪉ\ude8b뒓聯ﺙ肟쒡얣쾥쒧쾩좫肭", a_));
				return null;
				IL_43:
				result = null;
				flag = false;
				radioParams = null;
				global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Opening_Port);
				flag = this.a(readType, ref radioParams, true, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read, 0, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚅ꚇ몉ꊋ뺍뺏ꊑ", a_));
				num = (short)632946690;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0018B50C File Offset: 0x0018970C
		private void b(object A_0, global::System.ComponentModel.ProgressChangedEventArgs A_1)
		{
			short num = (short)1496317953;
			if (num != 0)
			{
			}
			if (A_1.ProgressPercentage == 100)
			{
				num = (short)1626580689;
				short num2 = num;
				num = (short)1275766481;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1374420992;
					short num3 = num;
					num = (short)279838720;
					if (num != 0)
					{
					}
					break;
				}
				}
				global::SpecialFeatures.Comms.Comms.a(1.0, global::CommonResources.AppResources.ReadRadio_Calling_End_Read_Radio);
				return;
			}
			global::SpecialFeatures.Comms.Comms.a((double)A_1.ProgressPercentage * 0.01, global::CommonResources.AppResources.Reading_radio_codeplug_);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0018B600 File Offset: 0x00189800
		public bool WriteRadio(global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioCodeplug, global::SpecialFeatures.Comms.COMMS_OP WriteType, global::SpecialFeatures.Comms.RadioParams codeplgParams, object lastCommsUserState, bool inbatchMode = false)
		{
			short num = (short)213188613;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1179320321;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_9C;
				case 1:
					goto IL_EF;
				case 2:
					if (lastCommsUserState != null)
					{
						num = (short)2144862212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.d = null;
					num = (short)1180237824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1879113730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					this.d = (lastCommsUserState as global::SpecialFeatures.Programming.OTAPProgrammingParameters);
					num = (short)1585053696;
					short num3 = num;
					num = (short)865665025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				IL_62:
				if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
				{
					break;
				}
				num = (short)1372454915;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9C:
			IL_EF:
			num = (short)5574934;
			short num4 = num;
			num = (short)1344147734;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_EF;
			default:
				num = (short)1398210560;
				if (num != 0)
				{
				}
				return this.WriteRadio(radioCodeplug, WriteType, codeplgParams, inbatchMode);
			}
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0018B790 File Offset: 0x00189990
		public bool WriteRadio(global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioCodeplug, global::SpecialFeatures.Comms.COMMS_OP WriteType, global::SpecialFeatures.Comms.RadioParams codeplgParams, bool inbatchMode = false)
		{
			int a_ = 4;
			short num = (short)18153472;
			switch (num)
			{
			default:
			{
				num = (short)1231486976;
				short num2 = num;
				num = (short)1521352705;
				if (num != 0)
				{
				}
				bool result = false;
				bool flag = false;
				try
				{
					num = (short)1207304206;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1335604986;
						short num4 = num;
						num = (short)801748730;
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)723976192;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								if (!this.h.CurrentRadioIsConnected)
								{
									num = (short)592445448;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_151;
							case 1:
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.LP_Cannot_Determine_Host_Version);
								num = (short)33226763;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_2F0;
							case 3:
								goto IL_26A;
							case 4:
								goto IL_3AA;
							case 5:
								goto IL_392;
							case 6:
								goto IL_19C;
							case 7:
								num = (short)1231814656;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_357;
							case 9:
								if (!global::ConstraintHelper.UtilityMack.IsAPXNextOrAloha)
								{
									num = (short)625213442;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_19C;
							case 10:
								if (string.IsNullOrEmpty(this.m_readRadioParams.HostVersion))
								{
									num = (short)838139905;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)483459081;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								goto IL_19C;
							case 12:
								try
								{
									this.a();
									goto IL_392;
								}
								catch
								{
									result = false;
									flag = true;
									throw;
								}
								goto IL_2F0;
							case 13:
								if (this.m_readRadioParams != null)
								{
									num = (short)197001219;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Unable_to_read_Radio_Parameters);
								num = (short)669122565;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								switch (0)
								{
								case 0:
									goto IL_12C;
								}
								continue;
							}
							IL_12C:
							if (this.h != null)
							{
								num = (short)620232711;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_151:
							num = (short)1418461197;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_19C:
							global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.WriteRadio_Writing_codeplug_to_radio);
							this.h.Write(this.m_readRadioParams, pbaObject, new global::System.ComponentModel.ProgressChangedEventHandler(this.a));
							result = true;
							num = (short)2105671692;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_2F0:
							this.b(inbatchMode);
							num = (short)344981510;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_392:
							num = (short)2131623940;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_26A:
						pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
						pbaObject.SetCodeplug(radioCodeplug);
						pbaObject.CodeplugData.CPVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
						pbaObject.ValidationFields = this.i;
						num = (short)1261371402;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_357:
					throw new global::System.Exception(global::CommonResources.AppResources.Could_not_find_a_radio_connected_to_a_USB_port);
					IL_3AA:;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					global::SpecialFeatures.Comms.Comms.a(0.0, ex.Message);
					global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
					{
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc86", a_),
						global::System.DateTime.Now.ToString(),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("Ꞇꒈꮊ", a_),
						ex.Message,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda86", a_)
					}));
				}
				catch (global::System.Exception ex2)
				{
					if (string.IsNullOrEmpty(ex2.Message))
					{
						global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Failed_to_communicate_with_the_radio);
					}
					else
					{
						global::SpecialFeatures.Comms.Comms.a(0.0, ex2.Message);
					}
					global::System.Exception innerException = ex2.InnerException;
					global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
					{
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc86", a_),
						global::System.DateTime.Now.ToString(),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("Ꞇꒈꮊ", a_),
						ex2.Message,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda86", a_)
					}));
				}
				finally
				{
					num = (short)1379794946;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							this.a();
							num = (short)706478081;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_544;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_50D;
							}
							continue;
						}
						IL_50D:
						if (flag)
						{
							break;
						}
						num = (short)1602682880;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_544:;
				}
				return result;
			}
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0018BD4C File Offset: 0x00189F4C
		private void b(bool A_0)
		{
			int a_ = 9;
			short num = (short)46858241;
			if (num != 0)
			{
			}
			num = (short)481165312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8D;
				}
				int value;
				bool isPortablePro;
				for (;;)
				{
					IL_5A:
					switch (num2)
					{
					case 0:
						goto IL_218;
					case 1:
					{
						num = (short)459286180;
						short num3 = num;
						num = (short)1459824292;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_338;
						default:
						{
							num = (short)519372800;
							if (num != 0)
							{
							}
							global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.LP_Begin_Language_Pack_Update);
							global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.BuildWriteLanguageData(this.m_readRadioParams.HostVersion, false);
							num = (short)1319174152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						if (!string.IsNullOrEmpty(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.warningOTAPMessage))
						{
							num = (short)670564356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						global::SpecialFeatures.Comms.Comms.a(0.0, global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.warningOTAPMessage);
						num = (short)2050228229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_338;
					case 5:
						return;
					case 6:
						if (global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.IsFirmwareLPCompatible(this.m_readRadioParams.HostVersion, ref this.m_LastLPKUserState, value, isPortablePro))
						{
							num = (short)1219166208;
							short num4 = num;
							num = (short)1485701121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B3;
					case 7:
						if (A_0)
						{
							num = (short)109248515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
					{
						global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData;
						languagePackData.ModelType = (isPortablePro ? global::Motorola.Common.Communication.CommonUtil.ModelType.Portable : global::Motorola.Common.Communication.CommonUtil.ModelType.Mobile);
						this.h.WriteLanguagePack(this.m_readRadioParams, languagePackData, new global::System.ComponentModel.ProgressChangedEventHandler(this.a));
						num = (short)1038876674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1680080902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!(bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾋ﶏﾑﲗ횙얟", a_)])
						{
							num = (short)926744585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B3;
					}
					goto IL_8D;
					IL_1B3:
					global::SpecialFeatures.Comms.Comms.a(0.0, this.m_LastLPKUserState);
					global::SpecialFeatures.Comms.Logger.Log(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힋", a_) + global::System.DateTime.Now.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겋ꎍ낏작望얟킡킣쎥첧誩ﺭﮯ銱솳욵\udfb7좹\uddbb\udabdꖿꛃꟅ믇꿉꣋뿏병郕迗龎ꫛ믝鋟釡跣觥蛧럩", a_));
					num = (short)1400307712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_338:
					this.m_LastLPKUserState = global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.warningOTAPMessage;
					num = (short)1643184135;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_218:
				return;
				IL_8D:
				value = (global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu).Advanced.DispMenuAdvancedLanguageSelection_A8386.Value;
				isPortablePro = global::ConstraintHelper.UtilityMack.IsPortablePro;
				this.m_LastLPKUserState = null;
				num = (short)541917194;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0018C0D8 File Offset: 0x0018A2D8
		private void a(object A_0, global::System.ComponentModel.ProgressChangedEventArgs A_1)
		{
			int a_ = 1;
			short num = (short)1813250060;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_1.UserState.ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펃ﺉ춍삏횑ﮓﶗ", a_)))
					{
						num = (short)321781766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)410583048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_2D2;
				case 2:
					goto IL_37D;
				case 3:
					if (A_1.UserState.ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펃ﺉ\ude91ﾗﶛ劣얟톡", a_)))
					{
						num = (short)1684930567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::SpecialFeatures.Comms.Comms.a((double)A_1.ProgressPercentage * 0.01, global::CommonResources.AppResources.Writing_radio_codeplug);
					num = (short)1722417156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_22F;
				case 5:
					num = (short)1176698891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_329;
				case 7:
					goto IL_1F3;
				case 8:
				{
					if (!A_1.UserState.ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솃黎춍삏횑ﮓﶗ", a_)))
					{
						return;
					}
					num = (short)736418854;
					short num3 = num;
					num = (short)1391254566;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_365;
					default:
						num = (short)1028390912;
						if (num != 0)
						{
						}
						num = (short)1654325249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					if (A_1.UserState.ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솃黎톑쒓", a_)))
					{
						goto IL_365;
					}
					num = (short)918224899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_1A0;
				case 11:
					if (A_1.UserState.ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펃ﺉ슍ﲑ聯ﶙ鍊춡쪣쎥", a_)))
					{
						num = (short)378601482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1483014144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				IL_62:
				num = (short)2105147392;
				short num4 = num;
				if (A_1.ProgressPercentage == 100)
				{
					num = (short)666435585;
					if (num != 0)
					{
					}
					num = (short)1296039941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1672871945;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_365:
				num = (short)2818050;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A0:
			global::SpecialFeatures.Comms.Comms.a(1.0, global::CommonResources.AppResources.LP_Language_Pack_Update_Success);
			return;
			IL_1F3:
			global::SpecialFeatures.Comms.Comms.a((double)A_1.ProgressPercentage * 0.01, global::CommonResources.AppResources.LP_Begin_Language_Pack_Update);
			return;
			IL_22F:
			return;
			IL_2D2:
			global::SpecialFeatures.Comms.Comms.a(1.0, global::CommonResources.AppResources.Radio_Erasing_CP_Completed);
			return;
			IL_329:
			global::SpecialFeatures.Comms.Comms.a(1.0, global::CommonResources.AppResources.Writing_radio_codeplug_completed);
			return;
			IL_37D:
			global::SpecialFeatures.Comms.Comms.a((double)A_1.ProgressPercentage * 0.01, global::CommonResources.AppResources.Radio_Erase_in_Progress_please_wait);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0018C480 File Offset: 0x0018A680
		public bool LoadTxmCertificate(string fileName, global::SpecialFeatures.Comms.COMMS_OP WriteType, bool inbatchMode = false)
		{
			short num = (short)464715779;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
				{
					num = (short)1372595406;
					short num3 = num;
					num = (short)900146382;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A7;
					case 1:
						break;
					default:
					{
						num = (short)683081728;
						short num4 = num;
						break;
					}
					}
					num = (short)2011430912;
					if (num != 0)
					{
					}
					if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.USB_READ_WRITE)
					{
						num = (short)1295908866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 2:
					goto IL_180;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				global::SpecialFeatures.Comms.RadioParams radioParams;
				if (!this.VerifyTxmRadio(WriteType, out radioParams))
				{
					num = (short)610598912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A7:
				num = (short)1657339905;
				if (num != 0)
				{
				}
				this.m_readRadioParams = radioParams;
				num = (short)1263140865;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_180:
			try
			{
				global::SpecialFeatures.Comms.RadioParams radioParams;
				this.a(radioParams, global::Motorola.Common.Communication.CommonUtil.RadioOperation.FileUpdate);
				goto IL_56;
			}
			catch (global::System.Exception)
			{
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
				global::AcpCommonLib.StatusMsgType type = global::AcpCommonLib.StatusMsgType.Error;
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(type, global::CommonResources.AppResources.Load_Txm_Cert_Failed);
				return false;
			}
			return false;
			IL_56:
			bool result = this.h.LoadTxmCertificate(this.m_readRadioParams, fileName);
			this.a();
			return result;
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0018C624 File Offset: 0x0018A824
		public bool blockRadioWrite(global::SpecialFeatures.Comms.COMMS_OP WriteType, object lastCommsUserState, int Headless = 0, string HeadlessAddr = "0.0.0.0", bool WriteProtecWriteProtectedRadio = false, bool otapBatchProgramming = false)
		{
			short num = (short)250281987;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1769406464;
				short num3 = num;
				switch (num2)
				{
				case 0:
					this.d = (lastCommsUserState as global::SpecialFeatures.Programming.OTAPProgrammingParameters);
					num = (short)541458433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_B3;
				case 2:
					num = (short)1135542276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					continue;
				case 4:
					if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
					{
						num = (short)1613430790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BC;
				case 5:
				{
					num = (short)2026821651;
					short num4 = num;
					num = (short)830593043;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1A5;
					}
					break;
				}
				case 6:
					goto IL_B8;
				case 7:
					if (lastCommsUserState != null)
					{
						num = (short)1905721344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.d = null;
					num = (short)1823014917;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_72:
				if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
				{
					num = (short)1122500610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B8:
				num = (short)1782513665;
				if (num != 0)
				{
				}
				num = (short)1831337991;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B3:
			goto IL_1BC;
			IL_1A5:
			num = (short)73596928;
			if (num != 0)
			{
			}
			IL_1BC:
			return this.blockRadioWrite(WriteType, Headless, HeadlessAddr, WriteProtecWriteProtectedRadio, otapBatchProgramming, false);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0018C7FC File Offset: 0x0018A9FC
		public bool VerifyTxmRadio(global::SpecialFeatures.Comms.COMMS_OP WriteType, out global::SpecialFeatures.Comms.RadioParams currentRadioParams)
		{
			int a_ = 10;
			short num = (short)1279524864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1573464673;
				short num3 = num;
				num = (short)1702111841;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1904082944;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_98;
					}
					int a_2;
					string a_3;
					for (;;)
					{
						IL_79:
						switch (num2)
						{
						case 0:
							goto IL_138;
						case 1:
							if (!this.a(WriteType, ref currentRadioParams, false, global::Motorola.Common.Communication.CommonUtil.RadioOperation.FileUpdate, a_2, a_3))
							{
								num = (short)2068643842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)827457540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_F1;
						case 3:
							goto IL_22E;
						case 4:
							if (!currentRadioParams.ModelNumber.Equals(global::CommonResources.AppResources.Txm_3000_Model_Number))
							{
								num = (short)716046339;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1635057669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (!global::AcpBusinessLayer.AcpDocument.ValidCodeplugVersion(currentRadioParams.CodeplugVersion))
							{
								num = (short)277807104;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						goto IL_98;
					}
					IL_F1:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
					global::AcpCommonLib.StatusMsgType type = global::AcpCommonLib.StatusMsgType.Error;
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(type, global::CommonResources.AppResources.Could_not_find_a_radio_connected_to_a_USB_port);
					return false;
					IL_138:
					num = (short)380895232;
					short num4 = num;
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
					string newer_CPS_Version_Required = global::CommonResources.AppResources.Newer_CPS_Version_Required;
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, newer_CPS_Version_Required);
					return false;
					IL_98:
					currentRadioParams = new global::SpecialFeatures.Comms.RadioParams();
					a_2 = 0;
					a_3 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌ꆎꆐ붒ꖔ릖ꦘ", a_);
					num = (short)698810369;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_79;
				}
				}
				IL_22E:
				num = (short)1969553409;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
				global::AcpCommonLib.StatusMsgType type2 = global::AcpCommonLib.StatusMsgType.Error;
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(type2, global::CommonResources.AppResources.Txm_Not_Connected_Error_Message);
				return false;
			}
			}
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0018CA40 File Offset: 0x0018AC40
		public bool blockRadioWrite(global::SpecialFeatures.Comms.COMMS_OP WriteType, int Headless = 0, string HeadlessAddr = "0.0.0.0", bool WriteProtecWriteProtectedRadio = false, bool otapBatchProgramming = false, bool updateWriteProtect = false)
		{
			int a_ = 1;
			short num = (short)690683904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				global::SpecialFeatures.Comms.RadioParams radioParams;
				bool flag;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_46D9;
					case 1:
						this.m_readRadioParams = radioParams;
						num = (short)338558978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)192086354;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
								string stat12;
								global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.TrkSysBandPlan> radioTrkShuffledBandPlans;
								string stat27;
								global::SpecialFeatures.Security.RadioSecurityData radioSecurityData;
								string stat30;
								global::SpecialFeatures.Comms.RadioParams radioParams2;
								switch (num2)
								{
								case 0:
									goto IL_2DA0;
								case 1:
									num = (short)1855717574;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_159A;
								case 3:
									if (!flag)
									{
										num = (short)1017708711;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A75;
								case 4:
									goto IL_896;
								case 5:
									goto IL_1B0D;
								case 6:
									num = (short)1806434357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_4380;
								case 8:
									num = (short)1245774149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									string stat = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.APX6000_P25_Radio);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat);
									flag = true;
									num = (short)712769796;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsUserSelectablePLEnhancementUsed())
									{
										num = (short)2099511658;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BB9;
								case 11:
								{
									string stat2 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_UCLCONTACTSLIMITATIONENHANCEMENT);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat2);
									flag = true;
									num = (short)713162918;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									num = (short)25887001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									string stat3 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_ACTIVEMICFORBLUETOOTHPTTCAPABLE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat3);
									flag = true;
									num = (short)775553049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									if (!flag)
									{
										num = (short)146538808;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3AD1;
								case 15:
									num = (short)560726060;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									if (!flag)
									{
										num = (short)895615033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F3E;
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
									if (radioWide.Labtool.RadWideLabtoolMaritimeRadioSoftware_A42191.Value)
									{
										num = (short)32636943;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1755;
								}
								case 18:
									if (!flag)
									{
										num = (short)398065812;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_43E0;
								case 19:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAllowPSUSecureUsed())
									{
										num = (short)712179819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3AD1;
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
									if (radioWide.Labtool.RadWideLabtoolMaritimeRadioSoftware_A42191 != null)
									{
										num = (short)1605239123;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1755;
								}
								case 21:
									if (this.b())
									{
										num = (short)608763928;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B30;
								case 22:
									if (this.b(pbaObject))
									{
										num = (short)2014707825;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F0E;
								case 23:
									goto IL_336F;
								case 24:
									num = (short)1751187516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									goto IL_2CCA;
								case 26:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsBeaconRoutingUsed())
									{
										num = (short)752877738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_43E0;
								case 27:
									goto IL_27F3;
								case 28:
								{
									global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc83", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲃ", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶃ", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺃ", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꞃ", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("것", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꾃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂃ", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("궃", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊃ", a_));
									list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆃ", a_));
									string item = global::SpecialFeatures.Comms.ParseDataHelper.GetRadioFlashcodeFromFBD(global::SpecialFeatures.Comms.ParseDataHelper.GetFDB(pbaObject))[7].ToString();
									string stat4 = string.Empty;
									if (!list.Contains(item))
									{
										num = (short)1869152492;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_336F;
								}
								case 29:
								{
									bool ishItemPCICapable = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 2, 32);
									num = (short)1512505461;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 30:
									num = (short)1593049291;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									if (!flag)
									{
										num = (short)1532428358;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3041;
								case 32:
									num = (short)1134035065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									if (!global::SpecialFeatures.Comms.SerialNumberValidator.IsCBISerialNumber(radioParams.SerialNumber))
									{
										num = (short)1044447496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_168A;
								case 34:
								{
									int num3;
									int num4;
									if (num3 < num4)
									{
										num = (short)1274413063;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F3E;
								}
								case 35:
									if (!flag)
									{
										num = (short)1587806351;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2090;
								case 36:
									if (!flag)
									{
										goto IL_31A7;
									}
									this.a();
									num = (short)2144403715;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
								{
									string stat5 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONSENHANCEMENT);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat5);
									flag = true;
									num = (short)1488388366;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 38:
									if (!flag)
									{
										num = (short)1690501293;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BAE;
								case 39:
									if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
									{
										num = (short)319225997;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3E70;
								case 40:
								{
									string stat6 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_APXSINGLETONECAPABLE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat6);
									flag = true;
									num = (short)328073458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 41:
									num = (short)428540059;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									if (!flag)
									{
										num = (short)1256456222;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_85A;
								case 43:
									num = (short)1755906394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
								{
									bool ishItemPCICapable2;
									if (!ishItemPCICapable2)
									{
										num = (short)627704163;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1755;
								}
								case 45:
									if (!flag)
									{
										num = (short)1918173342;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_81C;
								case 46:
									if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
									{
										num = (short)7274546;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4497;
								case 47:
									if (!global::SpecialFeatures.Security.RadioAccessValidator.CheckIfCustomerIDIsInACK(this.c()))
									{
										num = (short)731119961;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_324D;
								case 48:
									num = (short)869138453;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 49:
								{
									bool ishItemPCICapable3 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 5, 128);
									num = (short)1240465615;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 50:
									num = (short)2128019649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 51:
								{
									string stat7 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_AUDIBLEEMERGENCYBEACONROUTING);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat7);
									flag = true;
									num = (short)1659961653;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 52:
									num = (short)268959790;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
								{
									bool ishItemPCICapable3;
									if (!ishItemPCICapable3)
									{
										num = (short)250806565;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1E11;
								}
								case 54:
								{
									string stat8 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_AUDIOENHANCEMENT);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat8);
									flag = true;
									num = (short)748814447;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 55:
								{
									bool ishItemPCICapable4 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 6, 128);
									num = (short)2038563046;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 56:
								{
									bool flag2;
									if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).FrequencyRanges.RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Value != flag2)
									{
										num = (short)864485444;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F79;
								}
								case 57:
								{
									string appVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
									num = (short)893321466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 58:
									if (!flag)
									{
										num = (short)470876324;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1C49;
								case 59:
								{
									bool ishItemPCICapable5;
									if (!ishItemPCICapable5)
									{
										num = (short)533528737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_26B2;
								}
								case 60:
									if (global::SpecialFeatures.Comms.RadioOperationValidator.Is800MHzBandEnabledInRadio(radioParams, pbaObject))
									{
										num = (short)487587986;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B30;
								case 61:
								{
									bool ishItemPCICapable6;
									if (!ishItemPCICapable6)
									{
										num = (short)2110259350;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_23E4;
								}
								case 62:
									if (!flag)
									{
										num = (short)1746927700;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_342D;
								case 63:
									goto IL_342D;
								case 64:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsActiveMicForPTTUsed())
									{
										num = (short)946143602;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CCA;
								case 65:
									num = (short)753992049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 66:
									num = (short)166461499;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 67:
								{
									string stat9 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_EMERGENCYCALLONLYWITHHOTMICCAPABLE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat9);
									flag = true;
									num = (short)1164836864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 68:
								{
									string stat10 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.Extended_UHFR1480MHz_Capable);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat10);
									flag = true;
									num = (short)1416364121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 69:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAPXSingletoneCapableUsed())
									{
										num = (short)1969750118;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_15D7;
								case 70:
								{
									bool ishItemPCICapable7 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 3, 32);
									num = (short)720306321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 71:
								{
									bool ishItemPCICapable8;
									if (!ishItemPCICapable8)
									{
										num = (short)1219166333;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D95;
								}
								case 72:
								{
									bool ishItemPCICapable5 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 6, 4);
									num = (short)1925578961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 73:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool labtool = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10093] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool;
									num = (short)1455947855;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 74:
									num = (short)744620242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 75:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsDVRSRangeExtUsed())
									{
										num = (short)1794441384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_395E;
								case 76:
								{
									bool ishItemPCICapable9 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 4, 2);
									num = (short)1888485440;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 77:
									if (!flag)
									{
										num = (short)245104989;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_13D0;
								case 78:
									goto IL_26B2;
								case 79:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool labtool;
									if (labtool != null)
									{
										num = (short)2081882215;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_164F;
								}
								case 80:
									num = (short)919077170;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 81:
									num = (short)324599980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 82:
									goto IL_4497;
								case 83:
								{
									string stat11 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.Ultra_Low_Power_Capable);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat11);
									flag = true;
									num = (short)69796083;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 84:
									flag = !this.a(WriteType, radioParams.SerialNumber);
									num = (short)377487423;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 85:
									goto IL_168A;
								case 86:
									num = (short)1525481804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 87:
									goto IL_2090;
								case 88:
									goto IL_81C;
								case 89:
									goto IL_3F79;
								case 90:
									goto IL_3289;
								case 91:
									if (!flag)
									{
										num = (short)1223819544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_23E4;
								case 92:
								{
									bool ishItemPCICapable10;
									if (!ishItemPCICapable10)
									{
										num = (short)1480130891;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_FAA;
								}
								case 93:
									num = (short)979960028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 94:
									goto IL_EB9;
								case 95:
									if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
									{
										num = (short)774701064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1890;
								case 96:
									if (!flag)
									{
										num = (short)1566114060;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_159A;
								case 97:
									if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
									{
										num = (short)1425145908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4497;
								case 98:
									goto IL_F6F;
								case 99:
									goto IL_324D;
								case 100:
									if (!flag)
									{
										num = (short)2060386676;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BB9;
								case 101:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsMFKEmergencyAccessUsed())
									{
										num = (short)634585129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_441C;
								case 102:
									num = (short)1681195243;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 103:
									num = (short)2018246907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 104:
									num = (short)1182531833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 105:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsEmergencyCallOnlywithHotMicCapableUsed())
									{
										num = (short)530186252;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DA0;
								case 106:
									if (!flag)
									{
										num = (short)1065812266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_164F;
								case 107:
									num = (short)1756037358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 108:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsIPSCapableUsed())
									{
										num = (short)692584541;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2090;
								case 109:
								{
									bool ishItemPCICapable11 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 4, 128);
									num = (short)1289158787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 110:
									num = (short)1289289997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 111:
									goto IL_18F2;
								case 112:
									if (!flag)
									{
										num = (short)778174646;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_17CF;
								case 113:
									stat12 = string.Empty;
									num = (short)1201012831;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 114:
								{
									bool ishItemPCICapable12 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 5, 8);
									bool ishItemPCICapable13 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 5, 16);
									bool flag2 = ishItemPCICapable12 && ishItemPCICapable13;
									num = (short)1308622904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 115:
									goto IL_1E11;
								case 116:
									if (!flag)
									{
										num = (short)1085014227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3188;
								case 117:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAudibleEmergencyBeaconUsed())
									{
										num = (short)799735894;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B0D;
								case 118:
								{
									string stat13 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.Audible_Emergency_Beacon_ID);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat13);
									flag = true;
									num = (short)220463109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 119:
									if (radioParams.ModelNumber != null)
									{
										num = (short)1271660866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_457D;
								case 120:
								{
									bool ishItemPCICapable11;
									if (!ishItemPCICapable11)
									{
										num = (short)339673284;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18B4;
								}
								case 121:
								{
									bool ishItemPCICapable7;
									if (!ishItemPCICapable7)
									{
										num = (short)546373880;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3041;
								}
								case 122:
								{
									bool ishItemPCICapable14 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 7, 1);
									num = (short)668663941;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 123:
									goto IL_2B30;
								case 124:
								{
									string stat14 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_MANDOWNEMERGENCYPROFILECONFIGURABILITY);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat14);
									flag = true;
									num = (short)299630744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 125:
								{
									string stat15 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_ANALOGWIDEBANDDATAPCI);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat15);
									flag = true;
									num = (short)191299767;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 126:
									goto IL_1F0E;
								case 127:
								{
									string stat16 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.Expanded_MDC_ID_Capable);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat16);
									flag = true;
									num = (short)683147291;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 128:
									goto IL_1890;
								case 129:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsZoneCloneCapableUsed())
									{
										num = (short)304218439;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1C49;
								case 130:
									goto IL_3E70;
								case 131:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsEmergencyCallTerminationCapableUsed())
									{
										num = (short)661651755;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18B4;
								case 132:
								{
									string stat17 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_DISABLEENCRYPTION);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat17);
									flag = true;
									num = (short)1488715914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 133:
								{
									bool ishItemPCICapable14;
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsADPUsedInHighOrMidTierDevice() && ishItemPCICapable14)
									{
										num = (short)1297219840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_336F;
								}
								case 134:
									num = (short)1410466097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 135:
									goto IL_38A0;
								case 136:
								{
									bool ishItemPCICapable10 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 3, 16);
									num = (short)1700593823;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 137:
								{
									bool ishItemPCICapable2 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 2, 4);
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
									num = (short)449446117;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 138:
									goto IL_85A;
								case 139:
								{
									bool ishItemPCICapable15;
									if (!ishItemPCICapable15)
									{
										num = (short)1312358665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A75;
								}
								case 140:
									num = (short)1572012052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 141:
									num = (short)1691877696;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 142:
									goto IL_3188;
								case 143:
								{
									bool ishItemPCICapable16 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 4, 64);
									num = (short)1034027116;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 144:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAnalogWidebandDataPCIRoutingUsed())
									{
										num = (short)1167327383;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D95;
								case 145:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsPersonnelAccountabilityAlertUsed())
									{
										num = (short)617218080;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3041;
								case 146:
									radioTrkShuffledBandPlans = global::SpecialFeatures.Comms.ParseDataHelper.GetRadioTrkSystemShuffledBandPlans(pbaObject);
									num = (short)546898043;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 147:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsRemoteMountO3Capable())
									{
										num = (short)2037186633;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_164F;
								case 148:
								{
									bool ishItemPCICapable17 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 1, 32);
									num = (short)2113536026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 149:
									goto IL_18B4;
								case 150:
								{
									string stat18 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.Disable_Emergency_Call_Indications_Capable);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat18);
									flag = true;
									num = (short)643367099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 151:
									num = (short)533135431;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 152:
									goto IL_3726;
								case 153:
									if (!flag)
									{
										num = (short)363659472;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29B2;
								case 154:
									goto IL_EB9;
								case 155:
								{
									bool ishItemPCICapable18;
									if (!ishItemPCICapable18)
									{
										num = (short)395509950;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_441C;
								}
								case 156:
									num = (short)465830203;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 157:
									goto IL_F6F;
								case 158:
								{
									bool ishItemPCICapable19 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 3, 8);
									num = (short)569704733;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 159:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsMOSCADIsUsed())
									{
										num = (short)1380778188;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_FAA;
								case 160:
									num = (short)935002400;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 161:
								{
									string stat19 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_INDIRECTPTTAUDIOROUTINGPCI);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat19);
									flag = true;
									num = (short)1610809422;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 162:
								{
									string stat20 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_USERSELECTABLEPLENHANCEMENT);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat20);
									flag = true;
									num = (short)780009754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 163:
									goto IL_FAA;
								case 164:
								{
									bool ishItemPCICapable20 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 4, 32);
									num = (short)987955329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 165:
								{
									bool ishItemPCICapable17;
									if (!ishItemPCICapable17)
									{
										num = (short)1168310323;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_43E0;
								}
								case 166:
									goto IL_19B5;
								case 167:
								{
									bool ishItemPCICapable15 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 4, 1);
									num = (short)1767506122;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 168:
									num = (short)653525192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 169:
								{
									string stat21 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_DYNAMICZONESCANCAPABILITY);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat21);
									flag = true;
									num = (short)961806552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 170:
									num = (short)355860645;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 171:
									if (!flag)
									{
										num = (short)1017970797;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18B4;
								case 172:
								{
									bool ishItemPCICapable4;
									if (!ishItemPCICapable4)
									{
										num = (short)2037710859;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_19B5;
								}
								case 173:
								{
									bool ishItemPCICapable21 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 1, 8);
									num = (short)177864878;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 174:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsMulitEmergencyRevertUsed())
									{
										num = (short)1630798042;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BAE;
								case 175:
								{
									bool ishItemPCICapable22;
									if (!ishItemPCICapable22)
									{
										num = (short)442105893;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_13D0;
								}
								case 176:
								{
									bool ishItemPCICapable23 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 2, 8);
									num = (short)851509471;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 177:
								{
									string stat22 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.DVRS_Trunking_Status_ID);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat22);
									flag = true;
									num = (short)2090991704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 178:
									if (!flag)
									{
										num = (short)1029964060;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_15D7;
								case 179:
									goto IL_441C;
								case 180:
								{
									int num5 = (int)global::System.Convert.ToInt16(radioParams.CodeplugVersion.Substring(1, 2), 10);
									string appVersion;
									int num6 = (int)global::System.Convert.ToInt16(appVersion.Substring(1, 2), 10);
									int num4 = (int)global::System.Convert.ToInt16(radioParams.CodeplugVersion.Substring(4, 2), 10);
									int num3 = (int)global::System.Convert.ToInt16(appVersion.Substring(4, 2), 10);
									num = (short)1519059161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 181:
								{
									bool ishItemPCICapable24 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 4, 16);
									num = (short)81264745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 182:
									num = (short)1140850998;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 183:
									goto IL_D95;
								case 184:
								{
									string stat23 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.Emergency_Revert_Capable);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat23);
									flag = true;
									num = (short)1124991248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 185:
									if (!flag)
									{
										num = (short)1996816680;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27F3;
								case 186:
									if (!flag)
									{
										num = (short)729153865;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18F2;
								case 187:
									goto IL_23E4;
								case 188:
									if (!flag)
									{
										num = (short)972619890;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F79;
								case 189:
									num = (short)118554819;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 190:
								{
									string stat24 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_MFKEMERGENCYACCESS);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat24);
									flag = true;
									num = (short)645464243;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 191:
								{
									bool ishItemPCICapable25;
									if (!ishItemPCICapable25)
									{
										num = (short)1700987244;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21E8;
								}
								case 192:
									goto IL_1A3D;
								case 193:
									if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_CLONE)
									{
										num = (short)1792933970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_159A;
								case 194:
									this.m_CustomerId = global::SpecialFeatures.Comms.ParseDataHelper.ReadCustomerID(pbaObject);
									num = (short)1782710319;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 195:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide2;
									if (!radioWide2.Labtool.RadWideLabtoolDisableEncryption_43371.Value)
									{
										num = (short)1554317444;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_85A;
								}
								case 196:
								{
									string stat25 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_EMERGENCYCALLTERMINATION);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat25);
									flag = true;
									num = (short)1582432405;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 197:
									if (!flag)
									{
										num = (short)1829306433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BB4;
								case 198:
									if (!flag)
									{
										num = (short)1170604226;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_324D;
								case 199:
								{
									string stat26 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_DVRSRANGEEXT);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat26);
									flag = true;
									num = (short)1147797790;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 200:
								{
									bool ishItemPCICapable26;
									if (!ishItemPCICapable26)
									{
										num = (short)851509447;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_395E;
								}
								case 201:
								{
									bool ishItemPCICapable27;
									if ((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Value != ishItemPCICapable27)
									{
										num = (short)394854483;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29B2;
								}
								case 202:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsLimitedISSIDVRSOperationCapableUsed())
									{
										num = (short)1369964797;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A75;
								case 203:
								{
									bool ishItemPCICapable28 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 5, 1);
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide2 = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
									if (ishItemPCICapable28)
									{
										num = (short)1273692349;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_85A;
								}
								case 204:
									num = (short)416022620;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 205:
								{
									global::Motorola.Common.Communication.Pba.PbaObject pbaObject2;
									this.oldSecurityPartition = pbaObject2.CodeplugData.DataPartitions.Find(delegate(global::Motorola.Common.Communication.Pba.DataPartition s)
									{
										short num10 = (short)1456600206;
										short num11 = num10;
										num10 = (short)1190065294;
										switch (num11 == num10)
										{
										default:
										{
											num10 = (short)1368522752;
											short num12 = num10;
											break;
										}
										case true:
											break;
										}
										num10 = (short)508035072;
										if (num10 != 0)
										{
										}
										num10 = (short)326107137;
										if (num10 != 0)
										{
										}
										return s.PartitionID == 212;
									});
									num = (short)1986986319;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 206:
								{
									bool ishItemPCICapable29 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 3, 1);
									num = (short)1773142372;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 207:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsRadioLockExtensionCapableUsed())
									{
										num = (short)1897005062;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1E11;
								case 208:
								{
									bool ishItemPCICapable27 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 1, 4);
									num = (short)982843593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 209:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsIndirectPTTAudioRoutingUsed())
									{
										num = (short)2009595970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_26B2;
								case 210:
									if (radioParams != null)
									{
										num = (short)1338114411;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_457D;
								case 211:
									stat27 = null;
									radioSecurityData = global::SpecialFeatures.Comms.ParseDataHelper.GetRadioSecurityData(radioParams, pbaObject);
									num = (short)1422852438;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 212:
								{
									int num7 = global::SpecialFeatures.Comms.ParseDataHelper.ReadProgrammingPathValue(pbaObject);
									num = (short)2049310954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 213:
								{
									string stat28 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.Emergency_Hot_Aux_Mic_ID);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat28);
									flag = true;
									num = (short)659882238;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 214:
									if (!flag)
									{
										num = (short)1230045396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F6F;
								case 215:
									num = (short)1554120879;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 216:
									goto IL_EF6;
								case 217:
								{
									int num5;
									int num6;
									if (num6 >= num5)
									{
										num = (short)461439136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4380;
								}
								case 218:
									num = (short)23724308;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 219:
								{
									string stat29 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_ENHANCEDARS);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat29);
									flag = true;
									num = (short)639303872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 220:
								{
									bool ishItemPCICapable16;
									if (!ishItemPCICapable16)
									{
										num = (short)557515075;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2090;
								}
								case 221:
								{
									bool ishItemPCICapable30;
									if (!ishItemPCICapable30)
									{
										num = (short)1188954166;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18F2;
								}
								case 222:
									goto IL_3041;
								case 223:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsEmergencyHotMicUsed())
									{
										num = (short)632291462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_33AC;
								case 224:
									global::SpecialFeatures.Comms.Comms.a(0.0, stat30);
									num = (short)472186882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 225:
									goto IL_200E;
								case 226:
									global::SpecialFeatures.Comms.Comms.a(0.0, stat27);
									num = (short)1611202702;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 227:
									if (this.e())
									{
										num = (short)256704744;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3289;
								case 228:
								{
									bool ishItemPCICapable18 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 2, 16);
									num = (short)1387200613;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 229:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
									if (radioWide != null)
									{
										num = (short)1166082128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1755;
								}
								case 230:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsUCLContactsLimitationEnhancementUsed())
									{
										num = (short)888668241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_19B5;
								case 231:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsEnhancedARSUsed())
									{
										num = (short)462881013;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A3D;
								case 232:
								{
									string the_radio_being_written_to_is_INHIBITED = global::CommonResources.AppResources.The_radio_being_written_to_is_INHIBITED;
									global::SpecialFeatures.Comms.Comms.a(0.0, the_radio_being_written_to_is_INHIBITED);
									flag = true;
									num = (short)654639194;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 233:
									if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).FrequencyRanges.RadInfoFrequencyRangesExtendedUHFR1Capable_A41443.Value)
									{
										num = (short)535232819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21E8;
								case 234:
								{
									int num7;
									if (num7 != -1)
									{
										num = (short)1650852098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F6F;
								}
								case 235:
								{
									bool ishItemPCICapable31;
									if (!ishItemPCICapable31)
									{
										num = (short)25821224;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_15D7;
								}
								case 236:
								{
									string stat4 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_ADPCLONINGINCOMPATIBILITY);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat4);
									flag = true;
									num = (short)446365719;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 237:
									if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_CLONE)
									{
										num = (short)411500674;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_32D4;
								case 238:
								{
									bool ishItemPCICapable32;
									if (!ishItemPCICapable32)
									{
										num = (short)159645997;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3AD1;
								}
								case 239:
									goto IL_21E8;
								case 240:
									if (!flag)
									{
										num = (short)1080885424;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_33AC;
								case 241:
								{
									bool ishItemPCICapable33;
									if (!ishItemPCICapable33)
									{
										num = (short)278397052;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3726;
								}
								case 242:
									goto IL_15D7;
								case 243:
									goto IL_29B2;
								case 244:
									num = (short)2030436717;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 245:
									num = (short)1582039337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 246:
								{
									bool ishItemPCICapable9;
									if (!ishItemPCICapable9)
									{
										num = (short)1549860877;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CCA;
								}
								case 247:
									if (!global::SpecialFeatures.Security.RadioAccessValidator.IsCpgConvOnly())
									{
										num = (short)1472856112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B30;
								case 248:
								{
									string stat31 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYALERTCAPABLE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat31);
									flag = true;
									num = (short)1662648542;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 249:
								{
									bool ishItemPCICapable19;
									if (!ishItemPCICapable19)
									{
										num = (short)873398449;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_81C;
								}
								case 250:
								{
									string appVersion;
									if (appVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃", a_)))
									{
										num = (short)660930740;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F3E;
								}
								case 251:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool labtool;
									bool ishItemPCICapable34;
									if (ishItemPCICapable34 != labtool.RadWideLabtoolSupportO3ControlHeadPCIBit_Value)
									{
										num = (short)1564213588;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_164F;
								}
								case 252:
								{
									bool ishItemPCICapable35 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 3, 4);
									num = (short)1919811892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 253:
									num = (short)1115816075;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 254:
									goto IL_33AC;
								case 255:
									if (!flag)
									{
										num = (short)1913520204;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CCA;
								case 256:
									num = (short)945618972;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 257:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsPassAlarmFilterUsed())
									{
										num = (short)506003566;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_200E;
								case 258:
								{
									num = (short)35791265;
									short num8 = num;
									num = (short)2115248545;
									switch ((num8 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_31A7;
									default:
										num = (short)847446016;
										if (num != 0)
										{
										}
										num = (short)676200751;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 259:
									goto IL_457D;
								case 260:
									goto IL_17CF;
								case 261:
									if (!flag)
									{
										num = (short)667746426;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_336F;
								case 262:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAudioEnhacementUsed())
									{
										num = (short)611451153;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18F2;
								case 263:
									if (!flag)
									{
										num = (short)349896733;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B0D;
								case 264:
									global::SpecialFeatures.Comms.RadioOperationValidator.CompareRadioParams(radioParams2, radioParams, WriteType);
									num = (short)1323892821;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 265:
								{
									string stat32 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_LIMITEDISSIDVRSOPERATIONCAPABLE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat32);
									flag = true;
									num = (short)530383198;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 266:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.DisableEmergencyCallIndicationsExcised())
									{
										num = (short)1667760486;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_23E4;
								case 267:
								{
									string stat33 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_PASSALARMFILTERCAPABLE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat33);
									flag = true;
									num = (short)781189345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 268:
									num = (short)2060386401;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 269:
								{
									bool ishItemPCICapable36;
									if (!ishItemPCICapable36)
									{
										num = (short)1829634315;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_200E;
								}
								case 270:
									goto IL_13D0;
								case 271:
									if ((bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잃\ude91ﶓﶗ\ud999첛춝", a_)])
									{
										num = (short)1559757168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.i = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField>();
									num = (short)1854407015;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 272:
									goto IL_3BAE;
								case 273:
									num = (short)1786708189;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 274:
								{
									string stat34 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_ZONECLONECAPABLE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat34);
									flag = true;
									num = (short)416547182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 275:
									global::System.Threading.Thread.Sleep(1000);
									num = (short)62324740;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 276:
								{
									bool ishItemPCICapable21;
									if (!ishItemPCICapable21)
									{
										num = (short)1468203192;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BAE;
								}
								case 277:
									if (!flag)
									{
										num = (short)879296764;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_EF6;
								case 278:
								{
									bool ishItemPCICapable33 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 1, 64);
									num = (short)1979908448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 279:
									num = (short)2100822257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 280:
								{
									bool ishItemPCICapable6 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 2, 2);
									num = (short)1481244938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 281:
								{
									bool ishItemPCICapable24;
									if (!ishItemPCICapable24)
									{
										num = (short)1500512323;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DA0;
								}
								case 282:
									goto IL_BB9;
								case 283:
									if (!flag)
									{
										num = (short)1733886001;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1E11;
								case 284:
								{
									bool ishItemPCICapable31 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 4, 4);
									num = (short)1430585413;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 285:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsDVRSTRKStatusCapabilityUsed())
									{
										num = (short)1884946536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_81C;
								case 286:
									goto IL_395E;
								case 287:
									goto IL_4597;
								case 288:
								{
									int num5;
									int num6;
									if (num6 == num5)
									{
										num = (short)1784742206;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F3E;
								}
								case 289:
									if (!flag)
									{
										num = (short)220463382;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3726;
								case 290:
									goto IL_164F;
								case 291:
									if (!flag)
									{
										num = (short)1310392457;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1755;
								case 292:
									if (!flag)
									{
										num = (short)1365835957;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DA0;
								case 293:
								{
									string stat35 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_RADIOLOCKPASSWORDEXTENSIONCAPABLE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat35);
									flag = true;
									num = (short)1484324979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 294:
									if (flag)
									{
										num = (short)1706426594;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3188;
								case 295:
								{
									bool ishItemPCICapable8 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 6, 2);
									num = (short)1603862672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 296:
								{
									bool ishItemPCICapable37 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 1, 16);
									num = (short)2008088878;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 297:
								{
									bool ishItemPCICapable38;
									if (!ishItemPCICapable38)
									{
										num = (short)295108827;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A3D;
								}
								case 298:
								{
									bool ishItemPCICapable34 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 7, 2);
									num = (short)523960467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 299:
									num = (short)352977016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 300:
									if (!flag)
									{
										num = (short)1378615591;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D95;
								case 301:
								{
									string stat36 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_ALLOWPSUSECURE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat36);
									flag = true;
									num = (short)1799946564;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 302:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.ExpandedMDC1200Excised())
									{
										num = (short)1538982044;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27F3;
								case 303:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide3 = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
									if (radioWide3 == null)
									{
										num = (short)894304584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.General general = radioWide3.General;
									if (general == null)
									{
										num = (short)1769570;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpListField radWideGeneralProgrammingPath_ = general.RadWideGeneralProgrammingPath_44845;
									if (radWideGeneralProgrammingPath_ == null)
									{
										num = (short)1795424573;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num7;
									radWideGeneralProgrammingPath_.SetValue(num7);
									num = (short)1029177501;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 304:
								{
									bool ishItemPCICapable20;
									if (!ishItemPCICapable20)
									{
										num = (short)670630162;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1C49;
								}
								case 305:
								{
									bool ishItemPCICapable23;
									if (!ishItemPCICapable23)
									{
										num = (short)605880533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_33AC;
								}
								case 306:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
									if (radioWide.Labtool != null)
									{
										num = (short)997589132;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1755;
								}
								case 307:
									num = (short)2046296255;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 308:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsDynamicZoneScanCapabilityUsed())
									{
										num = (short)1402470644;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_EF6;
								case 309:
									goto IL_43E0;
								case 310:
								{
									bool ishItemPCICapable39 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 2, 1);
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide4 = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
									if (ishItemPCICapable39 != radioWide4.Labtool.RadWideLabtoolAPX6000P25Radio_A42121.Value)
									{
										num = (short)1214709769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_17CF;
								}
								case 311:
									goto IL_2BB4;
								case 312:
								{
									bool ishItemPCICapable32 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 6, 32);
									num = (short)408092691;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 313:
									if (!flag)
									{
										num = (short)1843462216;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_26B2;
								case 314:
								{
									bool ishItemPCICapable26 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 6, 64);
									num = (short)1443889227;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 315:
								{
									bool ishItemPCICapable37;
									if (!ishItemPCICapable37)
									{
										num = (short)267452543;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27F3;
								}
								case 316:
									if (!flag)
									{
										num = (short)139067528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_FAA;
								case 317:
									goto IL_F6F;
								case 318:
									num = (short)553058338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 319:
									if (!flag)
									{
										num = (short)1823539554;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A3D;
								case 320:
									if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
									{
										num = (short)130613578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3E70;
								case 321:
									if (this.d())
									{
										num = (short)1590427649;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_324D;
								case 322:
									this.m_EncryptPasswordFlag = global::SpecialFeatures.Comms.ParseDataHelper.ReadEncryptPasswordFlag(pbaObject);
									num = (short)323551271;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 323:
								{
									string stat37 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_INTELLIGENTPRIORITYSCANCAPABLE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat37);
									flag = true;
									num = (short)1497104471;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 324:
									goto IL_3AD1;
								case 325:
									if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
									{
										num = (short)1966014507;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1890;
								case 326:
								{
									bool ishItemPCICapable36 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 2, 64);
									num = (short)1999438081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 327:
									num = (short)337183024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 328:
									goto IL_F6F;
								case 329:
								{
									bool ishItemPCICapable30 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 3, 2);
									num = (short)1650196742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 330:
									num = (short)1508442349;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 331:
								{
									string stat38 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_MOSCADACE3600CAPABLE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat38);
									flag = true;
									num = (short)2098725027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 332:
								{
									bool ishItemPCICapable;
									if (!ishItemPCICapable)
									{
										num = (short)675348598;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B0D;
								}
								case 333:
									radioTrkShuffledBandPlans = null;
									num = (short)1917714679;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 334:
									if (!flag)
									{
										num = (short)2040135735;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_19B5;
								case 335:
									goto IL_457D;
								case 336:
									if (!flag)
									{
										num = (short)132645092;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_441C;
								case 337:
									goto IL_B1F;
								case 338:
									switch (0)
									{
									case 0:
										goto IL_6DC;
									}
									continue;
								case 339:
									num = (short)127926289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 340:
								{
									string stat39 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_REMOTEMOUNTO3CH);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat39);
									flag = true;
									num = (short)1114636578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 341:
									if (!flag)
									{
										num = (short)1055392058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_395E;
								case 342:
									if (radioSecurityData != null)
									{
										num = (short)1642201421;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									stat27 = global::CommonResources.AppResources.Could_not_retrieve_Radio_Securtiry_Information;
									flag = true;
									num = (short)373620890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 343:
									if (!flag)
									{
										num = (short)86638959;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21E8;
								case 344:
									if (!flag)
									{
										num = (short)287768902;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_200E;
								case 345:
								{
									string the_radio_being_written_to_is_KILLED = global::CommonResources.AppResources.The_radio_being_written_to_is_KILLED;
									global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, the_radio_being_written_to_is_KILLED);
									global::SpecialFeatures.Comms.Comms.a(0.0, the_radio_being_written_to_is_KILLED);
									flag = true;
									num = (short)807207011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 346:
									if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_CLONE)
									{
										num = (short)295829632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									stat12 = global::CommonResources.AppResources.Write_Between_SoldierMAC_FCC_And_RTTE_Cpg;
									num = (short)48038023;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 347:
									goto IL_38A0;
								case 348:
								{
									bool ishItemPCICapable40;
									if (!ishItemPCICapable40)
									{
										num = (short)1571881122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BB9;
								}
								case 349:
								{
									bool ishItemPCICapable22 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 3, 64);
									num = (short)219545961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 350:
									goto IL_2A75;
								case 351:
									if (pbaObject == null)
									{
										num = (short)701563217;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Read_Radio_Info);
									global::SpecialFeatures.Comms.RadioOperationValidator.RadioFlashCodeCheck(pbaObject, WriteType);
									num = (short)1472266273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 352:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsManDownPerCfgCapUsed())
									{
										num = (short)51249431;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3726;
								case 353:
									goto IL_32D4;
								case 354:
								{
									bool ishItemPCICapable38 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 4, 8);
									num = (short)874447079;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 355:
								{
									string stat40 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AcgResources.ID_MARITIMERADIOSOFTWARE);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat40);
									flag = true;
									num = (short)78578024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 356:
								{
									bool ishItemPCICapable29;
									if ((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolAPXDualKnobs_A42537.Value != ishItemPCICapable29)
									{
										num = (short)1350631795;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BB4;
								}
								case 357:
									if (flag)
									{
										num = (short)1787822304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_159A;
								case 358:
									num = (short)1380384829;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 359:
									goto IL_457D;
								case 360:
									goto IL_1755;
								case 361:
									if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsConsolidatedActionsEnhancementUsed())
									{
										num = (short)225247447;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_13D0;
								case 362:
									num = (short)1569522012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 363:
									num = (short)777191543;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 364:
								{
									string stat41 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.Extended_UHF_R1_Capable);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat41);
									flag = true;
									num = (short)1874788591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 365:
								{
									bool ishItemPCICapable35;
									if (!ishItemPCICapable35)
									{
										num = (short)996606121;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_EF6;
								}
								case 366:
									goto IL_1C49;
								case 367:
								{
									bool ishItemPCICapable25 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 1, 2);
									num = (short)1983840489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 368:
								{
									this.i = global::SpecialFeatures.Comms.RadioOperationValidator.PopulateWriteValidationFields(pbaObject);
									this.SetCodeplugVersions(radioParams);
									global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
									string radioFlashcodeFromFBD = global::SpecialFeatures.Comms.ParseDataHelper.GetRadioFlashcodeFromFBD(global::SpecialFeatures.Comms.ParseDataHelper.GetFDB(pbaObject));
									radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132.SetValue(radioFlashcodeFromFBD);
									global::Motorola.Common.Communication.Pba.PbaObject pbaObject2 = this.h.Read(null, null);
									num = (short)841416909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 369:
									if (!global::ConstraintHelper.UtilityMack.IsAPX900Radio)
									{
										num = (short)378470606;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BB4;
								case 370:
									num = (short)883949814;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 371:
								{
									string stat42 = string.Format(global::CommonResources.AppResources.PCI_Compatibility_Error_For_Clone_Write_Radio, global::CommonResources.AppResources.WWP_2_Knobs_Capable);
									global::SpecialFeatures.Comms.Comms.a(0.0, stat42);
									flag = true;
									num = (short)1974403383;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 372:
								{
									bool ishItemPCICapable40 = global::SpecialFeatures.Comms.ParseDataHelper.GetIshItemPCICapable(pbaObject, 3, 128);
									num = (short)1823539210;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 373:
									goto IL_3F3E;
								}
								IL_6DC:
								if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
								{
									num = (short)1124008211;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_896;
								IL_81C:
								num = (short)2058420540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_85A:
								num = (short)497549347;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_896:
								radioParams2 = new global::SpecialFeatures.Comms.RadioParams();
								radioParams2.ModelNumber = this.g();
								radioParams2.SerialNumber = this.f();
								radioParams2.FlashCode = global::SpecialFeatures.Comms.ParseDataHelper.getCodeplugFlashCode();
								global::SpecialFeatures.Comms.Comms.a(1.0, global::CommonResources.AppResources.Open_Port_Complete);
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1080, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1026, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1076, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 3868, ushort.MaxValue));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(212, 901, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1029, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(212, 903, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1062, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1093, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1028, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1146, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1084, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 3859, ushort.MaxValue));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 3923, ushort.MaxValue));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1073, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1027, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 3852, ushort.MaxValue));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1137, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1025, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(212, 900, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1030, 0));
								list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1150, 0));
								global::SpecialFeatures.Comms.RadioOperationValidator.CheckAndReviseBlockList(list2);
								pbaObject = this.h.ReadBlock(radioParams, list2, null);
								num = (short)457834847;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BB9:
								num = (short)80937037;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D95:
								num = (short)1059914062;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EB9:
								num = (short)967901478;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EF6:
								num = (short)1878458413;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F6F:
								num = (short)832176244;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FAA:
								num = (short)1540358175;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13D0:
								num = (short)1351090179;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_159A:
								num = (short)557777110;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_15D7:
								num = (short)1755251007;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_164F:
								num = (short)672006158;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_168A:
								this.a(pbaObject);
								num = (short)1082982422;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1755:
								num = (short)475005040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_17CF:
								num = (short)1810104656;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1890:
								stat12 = global::CommonResources.AppResources.Clone_Between_SoldierMAC_FCC_And_RTTE_Cpg;
								num = (short)800784731;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18B4:
								num = (short)683933979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18F2:
								num = (short)1057358101;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19B5:
								num = (short)322502762;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A3D:
								num = (short)1211367716;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B0D:
								num = (short)847577285;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C49:
								num = (short)1332609066;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E11:
								num = (short)1363804473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F0E:
								this.m_RadioInhibitedTrunking = global::SpecialFeatures.Comms.ParseDataHelper.IsRadioInhibitedTrunking(pbaObject);
								num = (short)90308835;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_200E:
								num = (short)1511915538;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2090:
								num = (short)76742827;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_21E8:
								num = (short)1397227708;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_23E4:
								num = (short)614727718;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_26B2:
								num = (short)466354476;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_27F3:
								num = (short)1010696283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_29B2:
								num = (short)797966521;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A75:
								num = (short)1198194943;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B30:
								global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioASKProgrammingHistoryList = global::SpecialFeatures.Comms.ParseDataHelper.GetRadioASKProgrammingHistoryList(pbaObject);
								flag = !global::SpecialFeatures.Security.RadioAccessValidator.RadioWriteSecurityCheck(WriteType, radioSecurityData, radioASKProgrammingHistoryList, radioTrkShuffledBandPlans, out stat27, WriteProtecWriteProtectedRadio, otapBatchProgramming, updateWriteProtect);
								num = (short)1574699102;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2BB4:
								num = (short)983826618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2CCA:
								num = (short)7405746;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2DA0:
								num = (short)1974140986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3041:
								num = (short)1694105700;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3188:
								num = (short)2048065572;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_31A7:
								num = (short)1862008906;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_324D:
								num = (short)2004222295;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3289:
								this.m_RadioKilled = global::SpecialFeatures.Comms.ParseDataHelper.IsRadioKilled(pbaObject);
								num = (short)1791492417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_32D4:
								num = (short)490471695;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_336F:
								num = (short)587530256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_33AC:
								num = (short)1320812807;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_342D:
								num = (short)910164064;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3726:
								num = (short)146473304;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_38A0:
								global::SpecialFeatures.Comms.Comms.a(0.0, stat12);
								flag = true;
								num = (short)1681784958;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_395E:
								num = (short)2115567877;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3AD1:
								num = (short)718012757;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3BAE:
								num = (short)1916010785;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3E70:
								this.m_RadioSystemIds = global::SpecialFeatures.Comms.ParseDataHelper.ReadRadioTrkSystemNamesTypesAndUnitIds(pbaObject.GetCodeplugInIshItemCollection());
								this.m_RadioCnvSysIds = global::SpecialFeatures.Comms.ParseDataHelper.ReadConvSysIds(pbaObject);
								this.m_AstroOtarRadioIds = global::SpecialFeatures.Comms.ParseDataHelper.ReadAstroOtarRadioIds(pbaObject);
								this.m_RadioDataProfIPs = global::SpecialFeatures.Comms.ParseDataHelper.ReadDataProfIPaddr(pbaObject);
								this.m_SoftIds = global::SpecialFeatures.Comms.ParseDataHelper.ReadSoftId(pbaObject);
								this.m_BluetoothFriendlyName = global::SpecialFeatures.Comms.ParseDataHelper.ReadBluetoothFriendlyName(pbaObject);
								this.m_EncryptPassword = global::SpecialFeatures.Comms.ParseDataHelper.ReadEncryptPassword(pbaObject);
								num = (short)43975009;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3F3E:
								num = (short)2073821246;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3F79:
								num = (short)2042232985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4380:
								string codeplug_version_is_older_than_radio_codeplug_version = global::CommonResources.AppResources.Codeplug_version_is_older_than_radio_codeplug_version;
								global::SpecialFeatures.Comms.Comms.a(0.0, codeplug_version_is_older_than_radio_codeplug_version);
								flag = true;
								num = (short)919404917;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_43E0:
								num = (short)712900899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_441C:
								num = (short)894107888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4497:
								stat30 = "";
								flag = !global::SpecialFeatures.Comms.RadioOperationValidator.PerformCompatibilityChecks(pbaObject, radioParams2.ModelNumber, radioParams.ModelNumber, ref stat30);
								num = (short)1707802981;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_457D:
								num = (short)232653087;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B1F:
							throw new global::System.Exception(global::CommonResources.AppResources.Read_block_failed);
							IL_4597:
							goto IL_46D9;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							global::SpecialFeatures.Comms.Comms.a(0.0, ex.Message);
							global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
							{
								global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf83", a_),
								global::System.DateTime.Now.ToString(),
								global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꒃꮅꢇ", a_),
								ex.Message,
								global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud983", a_)
							}));
							flag = true;
							this.a();
							goto IL_46D9;
						}
						catch (global::System.Exception ex2)
						{
							global::SpecialFeatures.Comms.Comms.a(0.0, ex2.Message);
							global::System.Exception innerException = ex2.InnerException;
							flag = true;
							this.a();
							goto IL_46D9;
						}
						goto IL_4654;
					case 3:
						if (this.a(WriteType, ref radioParams, false, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program, Headless, HeadlessAddr))
						{
							num = (short)289341441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = true;
						num = (short)1185087488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1600913409;
						if (num != 0)
						{
						}
						goto IL_4654;
					case 5:
						goto IL_4684;
					case 6:
						if (!flag)
						{
							num = (short)2144862212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					goto IL_54;
					IL_4654:
					global::SpecialFeatures.Comms.Comms.a(1.0, global::CommonResources.AppResources.Read_Radio_Info_Complete);
					num = (short)777584645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46D9:
					num = (short)1482358790;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4684:
				num = (short)2111700992;
				short num9 = num;
				return flag;
				IL_54:
				flag = false;
				radioParams = null;
				this.m_readRadioParams = null;
				global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Opening_Port);
				num = (short)320798723;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x001911BC File Offset: 0x0018F3BC
		private bool b(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_49;
				}
				short num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_0A:
					num = (short)602341376;
					short num2 = num;
					int num3;
					switch (num3)
					{
					case 0:
						return true;
					case 1:
						if (global::SpecialFeatures.Comms.ParseDataHelper.ReadTxPowerLevelsCFGType(A_0) != radioWide.TransmitPowerLevels.RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Value)
						{
							num = (short)66650112;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						num = (short)82247681;
						if (num != 0)
						{
						}
						num = (short)426573825;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolProductModelIdentifier_A37178.Value == 8)
						{
							num = (short)536281090;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				IL_49:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)1034007646;
				short num4 = num;
				num = (short)1542435934;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1042612224;
					if (num != 0)
					{
					}
					num = (short)1811677187;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
			}
			return false;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00191340 File Offset: 0x0018F540
		private string g()
		{
			short num = (short)1486487552;
			short num2 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			if (radioInformation == null)
			{
				num = (short)31733426;
				short num3 = num;
				num = (short)845166258;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1395589121;
					if (num != 0)
					{
					}
					num = (short)1423638528;
					if (num != 0)
					{
					}
					return string.Empty;
				}
			}
			return radioInformation.General.RadInfoGeneralModelNumber_A8539.ToString();
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0019141C File Offset: 0x0018F61C
		private string f()
		{
			short num = (short)389388437;
			short num2 = num;
			num = (short)439589013;
			string text;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)396230656;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				int num3;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_56:
					switch (num3)
					{
					case 0:
						goto IL_114;
					case 1:
					{
						num = (short)1462239232;
						short num4 = num;
						text = radioInformation.General.RadInfoGeneralSerialNumber_A9122.ToString();
						text = global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(text));
						num = (short)805896192;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (radioInformation != null)
						{
							num = (short)1062141953;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_116;
					}
					goto IL_68;
				}
				IL_114:
				break;
				IL_68:
				text = "";
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)1197998082;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			}
			IL_116:
			num = (short)1219428353;
			if (num != 0)
			{
			}
			return text;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00191568 File Offset: 0x0018F768
		private bool e()
		{
			int a_ = 6;
			short num = (short)1670503217;
			short num2 = num;
			num = (short)750836529;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1219624960;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				int num3;
				for (;;)
				{
					IL_5C:
					switch (num3)
					{
					case 0:
						goto IL_12B;
					case 1:
						this.m_RadioInhibitedTrunking.TryGetValue(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud988ﾌﮎﲔꚚ꾜꾞馠辢薤킨\udbaa좬銮肰莲螴膶閸鮺﮾ﳀ胈ꗊ꧌꫎꧐", a_), out result);
						num = (short)107937792;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.m_RadioInhibitedTrunking != null)
						{
							num = (short)579010560;
							short num4 = num;
							num = (short)325386241;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_6E;
				}
				IL_12B:
				break;
				IL_6E:
				result = false;
				num = (short)1100808193;
				if (num != 0)
				{
				}
				num = (short)935395330;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5C;
			}
			}
			return result;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x001916A4 File Offset: 0x0018F8A4
		private bool d()
		{
			int a_ = 5;
			short num = (short)2041475375;
			short num2 = num;
			num = (short)90468655;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1232338944;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_71;
				}
				int num3;
				for (;;)
				{
					IL_5F:
					switch (num3)
					{
					case 0:
						goto IL_12F;
					case 1:
					{
						num = (short)1010892800;
						short num4 = num;
						num = (short)1017774081;
						if (num != 0)
						{
						}
						this.m_RadioKilled.TryGetValue(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud887ﺋ揄憐ﶓ秊ꞙ꺛꺝颟躡蒣톧\udaa9즫鎭膯花蚳肵钷骹諾ﶿ臇꓉꣋ꯍ꣏", a_), out result);
						num = (short)1777532928;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (this.m_RadioKilled != null)
						{
							num = (short)1096286209;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_71;
				}
				IL_12F:
				break;
				IL_71:
				result = false;
				num = (short)2142502914;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5F;
			}
			}
			return result;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x001917E4 File Offset: 0x0018F9E4
		private int c()
		{
			int a_ = 3;
			short num = (short)995557377;
			if (num != 0)
			{
			}
			num = (short)1440429945;
			short num2 = num;
			num = (short)1606956921;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2038104064;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				int num3;
				for (;;)
				{
					IL_85:
					switch (num3)
					{
					case 0:
						goto IL_128;
					case 1:
						this.m_CustomerId.TryGetValue(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횅ﮑﮓꖗꢙ겛ꚝ貟芡\udfa5\ud8a7쾩醫龭肯膱蒳骵颷莽迅ꛇ껉꧋뛍", a_), out result);
						num = (short)747831296;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.m_RadioInhibitedTrunking != null)
						{
							num = (short)719847424;
							short num4 = num;
							num = (short)1998323713;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_97;
				}
				IL_128:
				break;
				IL_97:
				result = 0;
				num = (short)1575878658;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_85;
			}
			}
			return result;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0019191C File Offset: 0x0018FB1C
		private bool a(global::SpecialFeatures.Comms.COMMS_OP A_0, ref global::SpecialFeatures.Comms.RadioParams A_1, bool A_2, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_3 = global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program, int A_4 = 0, string A_5 = "0.0.0.0")
		{
			int a_ = 15;
			short num = (short)1721106432;
			short num2 = num;
			num = (short)2038234756;
			short num3 = num;
			num = (short)794295940;
			bool flag4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1045954561;
				if (num != 0)
				{
				}
				num = (short)63897600;
				if (num != 0)
				{
				}
				num = (short)659292160;
				switch (num)
				{
				default:
				{
					bool flag = false;
					bool? flag2 = null;
					global::SpecialFeatures.SpecialFeaturesSettings specialFeaturesSettings = new global::SpecialFeatures.SpecialFeaturesSettings();
					global::System.Threading.Semaphore semaphore = null;
					try
					{
						num = (short)1469579302;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::SpecialFeatures.Programming.OTAPPrescenceResult otapprescenceResult;
							global::SpecialFeatures.Programming.ProgrammingOperation progOp;
							switch (num4)
							{
							case 0:
								goto IL_669;
							case 1:
								if (flag)
								{
									num = (short)1774583814;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1100;
							case 2:
								if (string.IsNullOrEmpty(A_1.ConnectionInfo.UniqueAddress))
								{
									num = (short)1683423240;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1100;
							case 3:
								goto IL_5F1;
							case 4:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_7CC;
									}
									for (;;)
									{
										IL_7B5:
										switch (num4)
										{
										case 0:
											flag = true;
											num = (short)2143551490;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											if (A_1 != null)
											{
												num = (short)130809856;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_879;
										case 2:
											goto IL_879;
										case 3:
											goto IL_893;
										}
										goto IL_7CC;
										IL_879:
										num = (short)369098755;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_893:
									goto IL_1100;
									IL_7CC:
									this.h = this.a(new global::SpecialFeatures.Comms.RadioParams
									{
										Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
										ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo(),
										ConnectionInfo = 
										{
											ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth,
											UniqueAddress = this.GetBluetoothPANIPAddress(A_0)
										}
									}, A_3);
									A_1 = this.h.ReadExtendedDeviceInfo();
									num = (short)284295169;
									num4 = (int)((global::System.IntPtr)num);
									goto IL_7B5;
								}
								catch (global::Motorola.Common.CustomException.CommonException ex)
								{
									flag = false;
									global::SpecialFeatures.Comms.Comms.a(0.0, ex.Message);
									global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
									{
										global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즑", a_),
										global::System.DateTime.Now.ToString(),
										global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑릓뚕", a_),
										ex.Message,
										global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾑", a_)
									}));
									this.a();
									goto IL_1100;
								}
								catch (global::System.Exception ex2)
								{
									global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
									{
										global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즑", a_),
										global::System.DateTime.Now.ToString(),
										global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑릓뚕", a_),
										ex2.Message,
										global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾑", a_)
									}));
									global::SpecialFeatures.Comms.Comms.a(0.0, ex2.Message);
									global::System.Exception innerException = ex2.InnerException;
									flag = false;
									this.a();
									goto IL_1100;
								}
								goto Block_19;
							case 5:
								if (!(bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﮓﮕﮙ瞧쮡쪣쎥睊ﾫ", a_)])
								{
									num = (short)1898643495;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F1F;
							case 6:
								num = (short)1482555394;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_5F1;
							case 8:
								flag = false;
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Could_not_find_a_radio_connected_to_a_USB_port);
								num = (short)2070609934;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								if (otapprescenceResult.DevicePrescence != global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_PRESENT)
								{
									num = (short)1838678032;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_78C;
							case 10:
								if (A_4 == 8)
								{
									num = (short)969146419;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1100;
							case 11:
							{
								bool? flag3;
								if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
								{
									num = (short)271319086;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_26C;
							}
							case 12:
								if (A_0 == global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
								{
									num = (short)768933888;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_FEE;
							case 13:
								num = (short)209322032;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								goto IL_1100;
							case 15:
								goto IL_D34;
							case 16:
								num = (short)196870184;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 17:
								if (flag2 != null)
								{
									num = (short)448921619;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_26C;
							case 18:
								if (A_0 != global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_CLONE)
								{
									num = (short)253034527;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4FF;
							case 19:
							{
								bool? flag3 = flag2;
								flag4 = true;
								num = (short)598343691;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 20:
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.The_application_could_not_communicate_with_the_Automatic_Registration_Server_ARS);
								flag = false;
								num = (short)1501888556;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 21:
								if (A_0 != global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
								{
									num = (short)1808728113;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_669;
							case 22:
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.The_radio_is_not_on_the_network);
								flag = false;
								num = (short)731119650;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 23:
								if (otapprescenceResult.DevicePrescence == global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_TIMEOUT)
								{
									num = (short)597622804;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
								{
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즑", a_),
									global::System.DateTime.Now.ToString(),
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑릓뚕", a_),
									global::CommonResources.AppResources.The_radio_network_address_could_not_be_determined,
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾑", a_)
								}));
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.The_radio_network_address_could_not_be_determined);
								flag = false;
								num = (short)940376107;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 24:
								goto IL_78C;
							case 25:
								goto IL_C2C;
							case 26:
								goto IL_1100;
							case 27:
								if (A_2)
								{
									num = (short)111083550;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								progOp = global::SpecialFeatures.Programming.ProgrammingOperation.PROGRAMMING_OPERATION_WRITE;
								num = (short)1273233415;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 28:
								if (A_0 == global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_READ_WRITE)
								{
									num = (short)300220445;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)200081418;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 29:
								goto IL_4FF;
							case 30:
								progOp = global::SpecialFeatures.Programming.ProgrammingOperation.PROGRAMMING_OPERATION_READ;
								num = (short)790429699;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 31:
								num = (short)1398734876;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 32:
								goto IL_76C;
							case 33:
								num = (short)1027211306;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 34:
								goto IL_1100;
							case 35:
								goto IL_9AE;
							case 36:
								if (A_0 != global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
								{
									num = (short)1010040845;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2B6;
							case 37:
								goto IL_2B6;
							case 38:
								switch (0)
								{
								case 0:
									goto IL_1CF;
								}
								continue;
							case 39:
								semaphore = global::System.Threading.Semaphore.OpenExisting(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91삓힕좗\ude99킟캡얣\udfa5ﾧ쮩얫\udaad", a_));
								semaphore.WaitOne();
								num = (short)542113839;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 40:
								if (otapprescenceResult.DevicePrescence == global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_USER_ENTERED)
								{
									num = (short)1408892952;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)543359026;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 41:
								if (A_4 == 0)
								{
									num = (short)1386807341;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_FEE;
							case 42:
								if (A_0 == global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
								{
									num = (short)1426260000;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1574305833;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 43:
								goto IL_1100;
							case 44:
								goto IL_1100;
							case 45:
								num = (short)1916207125;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 46:
								num = (short)390070281;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 47:
								goto IL_F1F;
							case 48:
								if (A_0 == global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
								{
									num = (short)558891045;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1100;
							case 49:
								num = (short)1527185420;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 50:
								if (otapprescenceResult.DevicePrescence == global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_ABSENT)
								{
									num = (short)461045782;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)538705943;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 51:
								num = (short)1730478116;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 52:
								goto IL_111B;
							}
							IL_1CF:
							if (A_0 != global::SpecialFeatures.Comms.COMMS_OP.USB_READ_WRITE)
							{
								num = (short)1092026401;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_76C;
							Block_21:
							try
							{
								IL_D34:
								switch (0)
								{
								case 0:
									goto IL_D55;
								}
								for (;;)
								{
									IL_D3E:
									switch (num4)
									{
									case 0:
										flag = true;
										num = (short)1312161794;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (A_1 != null)
										{
											num = (short)2108096512;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_DEB;
									case 2:
										goto IL_DEB;
									case 3:
										goto IL_E04;
									}
									goto IL_D55;
									IL_DEB:
									num = (short)197591043;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_E04:
								goto IL_230;
								IL_D55:
								this.h = this.a(new global::SpecialFeatures.Comms.RadioParams
								{
									Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
									ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo(),
									ConnectionInfo = 
									{
										ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter
									}
								}, A_3);
								A_1 = this.h.ReadExtendedDeviceInfo();
								num = (short)62914561;
								num4 = (int)((global::System.IntPtr)num);
								goto IL_D3E;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex3)
							{
								flag = false;
								global::SpecialFeatures.Comms.Comms.a(0.0, ex3.Message);
								global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
								{
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즑", a_),
									global::System.DateTime.Now.ToString(),
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑릓뚕", a_),
									ex3.Message,
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾑", a_)
								}));
								this.a();
								goto IL_230;
							}
							catch (global::System.Exception ex4)
							{
								global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
								{
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즑", a_),
									global::System.DateTime.Now.ToString(),
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑릓뚕", a_),
									ex4.Message,
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾑", a_)
								}));
								global::SpecialFeatures.Comms.Comms.a(0.0, ex4.Message);
								global::System.Exception innerException2 = ex4.InnerException;
								flag = false;
								this.a();
								goto IL_230;
							}
							goto IL_F1F;
							IL_230:
							num = (short)1570766849;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							Block_20:
							try
							{
								IL_C2C:
								this.h = this.a(new global::SpecialFeatures.Comms.RadioParams
								{
									Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
									ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo(),
									ConnectionInfo = 
									{
										UniqueAddress = A_5,
										ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap
									}
								}, A_3);
								A_1 = this.h.ReadExtendedDeviceInfo();
								flag = true;
								goto IL_1100;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex5)
							{
								flag = false;
								global::SpecialFeatures.Comms.Comms.a(0.0, ex5.Message);
								global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
								{
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즑", a_),
									global::System.DateTime.Now.ToString(),
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑릓뚕", a_),
									ex5.Message,
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾑", a_)
								}));
								this.a();
								goto IL_1100;
							}
							catch (global::System.Exception)
							{
								flag = false;
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.The_radio_network_address_could_not_be_determined);
								this.a();
								goto IL_1100;
							}
							goto Block_21;
							Block_19:
							try
							{
								IL_9AE:
								switch (0)
								{
								case 0:
									goto IL_9D7;
								}
								int num5;
								for (;;)
								{
									IL_9B8:
									switch (num4)
									{
									case 0:
										num = (short)940638210;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_A7E;
									case 2:
										if (num5 < 1)
										{
											num = (short)1671168004;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_A7E;
									case 3:
										if (num5 <= 4)
										{
											num = (short)115015680;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_A16;
									case 4:
										goto IL_A16;
									case 5:
										goto IL_B13;
									}
									goto IL_9D7;
									IL_A16:
									num5 = 3;
									specialFeaturesSettings.OTAP_CPS_SESSION_INACTIVITY_TIMER = num5.ToString();
									specialFeaturesSettings.Save();
									num = (short)685637633;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_A7E:
									this.h = this.a(new global::SpecialFeatures.Comms.RadioParams
									{
										Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
										ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo(),
										ConnectionInfo = 
										{
											UniqueAddress = otapprescenceResult.DeviceIPAddress,
											ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap,
											InactivityTimeout = num5 * 60
										}
									}, A_3);
									A_1 = this.h.ReadExtendedDeviceInfo();
									A_1.ConnectionInfo.InactivityTimeout = num5 * 60;
									flag = true;
									num = (short)1463812101;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_B13:
								goto IL_1100;
								IL_9D7:
								num5 = (int)global::System.Convert.ToInt16(specialFeaturesSettings.OTAP_CPS_SESSION_INACTIVITY_TIMER);
								num = (short)2101411843;
								num4 = (int)((global::System.IntPtr)num);
								goto IL_9B8;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex6)
							{
								flag = false;
								global::SpecialFeatures.Comms.Comms.a(0.0, ex6.Message);
								global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
								{
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즑", a_),
									global::System.DateTime.Now.ToString(),
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑릓뚕", a_),
									ex6.Message,
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾑", a_)
								}));
								this.a();
								goto IL_1100;
							}
							catch (global::System.Exception ex7)
							{
								global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
								{
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즑", a_),
									global::System.DateTime.Now.ToString(),
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑릓뚕", a_),
									ex7.Message,
									global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾑", a_)
								}));
								flag = false;
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.The_radio_network_address_could_not_be_determined);
								this.a();
								global::System.Exception innerException3 = ex7.InnerException;
								goto IL_1100;
							}
							goto Block_20;
							IL_26C:
							flag = false;
							global::SpecialFeatures.Comms.Comms.a(0.0, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑", a_) + global::CommonResources.AppResources.POP25_operation_was_aborted);
							num = (short)832897050;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_2B6:
							num = (short)1727660057;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_4FF:
							num = (short)621412356;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_5F1:
							global::SpecialFeatures.Comms.Comms.c(progOp, this.d, new global::SpecialFeatures.Comms.Comms.RadioOTAPObject(this.OTAPRadioResult));
							num = (short)247005189;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_669:
							otapprescenceResult = null;
							num = (short)491257883;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_76C:
							num = (short)757989391;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_78C:
							num = (short)2099904547;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_F1F:
							flag2 = this.e;
							otapprescenceResult = this.f;
							num = (short)603979793;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_FEE:
							num = (short)1312620562;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_1100:
							flag4 = flag;
							num = (short)958529588;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_111B:;
					}
					catch (global::System.Exception ex8)
					{
						global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
						{
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즑", a_),
							global::System.DateTime.Now.ToString(),
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑릓뚕", a_),
							ex8.Message,
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾑", a_)
						}));
						if (global::SpecialFeatures.Comms.Comms.a != null)
						{
							global::SpecialFeatures.Comms.Comms.a(0.0, ex8.Message);
						}
						this.a();
						flag4 = false;
					}
					finally
					{
						num = (short)509673472;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_11E3;
								}
								continue;
							case 1:
								goto IL_121A;
							case 2:
								semaphore.Dispose();
								num = (short)806879233;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_11E3:
							if (semaphore == null)
							{
								break;
							}
							num = (short)1814298626;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_121A:;
					}
					break;
				}
				}
				break;
			}
			return flag4;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00192C3C File Offset: 0x00190E3C
		public void OTAPRadioResult(bool? otapDialogResult, global::SpecialFeatures.Programming.OTAPProgrammingParameters RadioProgrammingParameters, global::SpecialFeatures.Programming.OTAPPrescenceResult RadioPrescenceResult)
		{
			short num = (short)417631877;
			short num2 = num;
			num = (short)1335463557;
			switch (num2 == num)
			{
			}
			num = (short)1311637505;
			if (num != 0)
			{
			}
			num = (short)2086338560;
			short num3 = num;
			num = (short)1812398080;
			if (num != 0)
			{
			}
			this.e = otapDialogResult;
			this.d = RadioProgrammingParameters;
			this.f = RadioPrescenceResult;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00192CFC File Offset: 0x00190EFC
		public void GetReadWritePassword(ref bool read, ref bool write, ref bool archive, ref string password)
		{
			short num = (short)2110420216;
			short num2 = num;
			num = (short)749565176;
			switch (num2 == num)
			{
			}
			num = (short)1050017793;
			if (num != 0)
			{
			}
			num = (short)1575485440;
			short num3 = num;
			num = (short)884736000;
			if (num != 0)
			{
			}
			read = this.j;
			write = this.k;
			archive = this.l;
			password = this.m;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00192DC4 File Offset: 0x00190FC4
		private void a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num;
			int num2;
			for (;;)
			{
				num = (short)1937571840;
				num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1138018651;
					short num3 = num;
					num = (short)626575707;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_54;
					}
					break;
				}
				}
			}
			IL_54:
			num = (short)990576641;
			if (num != 0)
			{
			}
			num = (short)1206059008;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_AE;
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
			for (;;)
			{
				IL_9B:
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
				switch (num2)
				{
				case 0:
				{
					num = (short)142802944;
					short num4 = num;
					if (codeplugInIshItemCollection.Count > 0)
					{
						num = (short)496762882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 1:
					try
					{
						num = (short)2040659968;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_15D;
								}
								continue;
							case 1:
							{
								global::Motorola.Common.Communication.CommonUtil.IshHeader key;
								if (key.IshType == 1029)
								{
									num = (short)865402885;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_2B3;
							case 3:
								goto IL_296;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)833028102;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
								global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
								num = (short)818020353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
								this.m = global::System.Text.Encoding.ASCII.GetString(keyValuePair.Value.Data, 2, 32).Trim(new char[1]);
								this.j = ((keyValuePair.Value.Data[1] & 128) > 0);
								this.k = ((keyValuePair.Value.Data[1] & 64) > 0);
								this.l = ((keyValuePair.Value.Data[1] & 32) > 0);
								num = (short)1940193283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								num = (short)154075138;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_162:
							num = (short)1841496068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_15D:
							goto IL_162;
						}
						IL_296:
						IL_2B3:
						return;
					}
					finally
					{
						num = (short)1017970688;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2EB;
								}
								continue;
							case 1:
								goto IL_320;
							case 2:
								enumerator.Dispose();
								num = (short)2621441;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2EB:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1838612482;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_320:;
					}
					goto IL_323;
				case 2:
					goto IL_323;
				}
				goto IL_AE;
				IL_323:
				enumerator = codeplugInIshItemCollection.GetEnumerator();
				num = (short)1886715905;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_AE:
			codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
			num = (short)1175715840;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_9B;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00193138 File Offset: 0x00191338
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection packToCodeplug()
		{
			short num = (short)1391198208;
			short num2 = num;
			num = (short)1819775934;
			short num3 = num;
			num = (short)2081788862;
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1607139328;
				if (num != 0)
				{
				}
				num = (short)333709312;
				switch (num)
				{
				default:
				{
					bool flag = true;
					global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream> dictionary = new global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream>();
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = null;
					global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor packUnpackExecutor = new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor();
					global::Motorola.Acp.PackUnpack.Ish.Codeplug codeplug = null;
					global::Motorola.Acp.PackUnpack.Ish.Codeplug codeplug2;
					codeplug = (codeplug2 = new global::Motorola.Acp.PackUnpack.Ish.Codeplug());
					try
					{
						try
						{
							codeplug = packUnpackExecutor.Pack(this.m_readRadioParams.ModelNumber);
						}
						catch (global::System.Exception ex)
						{
							if (global::SpecialFeatures.Comms.Comms.a != null)
							{
								global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Pack_Failure_During_Write);
							}
							global::System.Exception innerException = ex.InnerException;
							if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
							{
								throw new global::Motorola.Common.CustomException.CommonException(global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write);
							}
							flag = false;
						}
						num = (short)2060582913;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator;
							switch (num4)
							{
							case 0:
								try
								{
									num = (short)132251649;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											num = (short)812122114;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_1CC;
											}
											continue;
										case 2:
											goto IL_274;
										case 3:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)846069760;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.Acp.PackUnpack.Ish.Partition partition = enumerator.Current;
											global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(partition.Image.GetBuffer());
											memoryStream.SetLength(partition.Image.Length);
											dictionary.Add((int)partition.PartitionType, memoryStream);
											num = (short)336592900;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_220:
										num = (short)990707715;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_1CC:
										goto IL_220;
									}
									IL_274:
									goto IL_16C;
								}
								finally
								{
									num = (short)2038497280;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_2AC;
											}
											continue;
										case 1:
											goto IL_2E4;
										case 2:
											enumerator.Dispose();
											num = (short)293404673;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_2AC:
										if (enumerator == null)
										{
											break;
										}
										num = (short)737083394;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_2E4:;
								}
								goto IL_2E7;
								IL_16C:
								ishItemCollection = new global::SpecialFeatures.Comms.CodeplugFormatConverter().Convert(dictionary);
								num = (short)578289667;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_14C;
								}
								continue;
							case 2:
								goto IL_32D;
							case 3:
								goto IL_312;
							case 4:
								goto IL_2E7;
							}
							IL_14C:
							if (flag)
							{
								num = (short)131399684;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_312;
							IL_2E7:
							enumerator = codeplug.Partitions.GetEnumerator();
							num = (short)544014336;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_312:
							result = ishItemCollection;
							num = (short)1475477506;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_32D:;
					}
					finally
					{
						num = (short)2105606144;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_361;
								}
								continue;
							case 1:
								goto IL_399;
							case 2:
								((global::System.IDisposable)codeplug2).Dispose();
								num = (short)696188929;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_361:
							if (codeplug2 == null)
							{
								break;
							}
							num = (short)210567170;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_399:;
					}
					break;
				}
				}
				break;
			}
			num = (short)1263730689;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00193558 File Offset: 0x00191758
		public void unpackFromRadio(global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioCodeplug)
		{
			short num = (short)895614976;
			switch (num)
			{
			default:
			{
				num = (short)950665217;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<int, byte[]> dictionary = new global::System.Collections.Generic.Dictionary<int, byte[]>();
				using (global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream>.Enumerator enumerator = new global::SpecialFeatures.Comms.CodeplugFormatConverter().Convert(radioCodeplug).GetEnumerator())
				{
					num = (short)329646081;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_D9;
						case 2:
							goto IL_1EE;
						case 3:
						{
							num = (short)1764277334;
							short num3 = num;
							num = (short)765312086;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D9;
							default:
								num = (short)949223424;
								if (num != 0)
								{
								}
								num = (short)811270146;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1989738499;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<int, global::System.IO.MemoryStream> keyValuePair = enumerator.Current;
							byte[] value = new byte[keyValuePair.Value.Length];
							value = keyValuePair.Value.GetBuffer();
							dictionary.Add(keyValuePair.Key, value);
							num = (short)110428160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_FE;
						IL_D9:
						switch (0)
						{
						case 0:
							IL_FE:
							goto IL_100;
						}
						continue;
						IL_100:
						num = (short)1549074436;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1EE:
					goto IL_98;
				}
				return;
				for (;;)
				{
					IL_98:
					num = (short)59244544;
					short num4 = num;
					try
					{
						new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor().Unpack(dictionary, this.m_readRadioParams.ModelNumber);
						break;
					}
					catch (global::System.Exception ex)
					{
						global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Unpack_failure_during_read);
						global::System.Exception innerException = ex.InnerException;
						throw;
					}
				}
				return;
			}
			}
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0019379C File Offset: 0x0019199C
		private bool a(global::SpecialFeatures.Comms.COMMS_OP A_0, string A_1)
		{
			int a_ = 19;
			bool result = true;
			global::System.Threading.Semaphore semaphore = null;
			short num;
			try
			{
				num = (short)55443457;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)39387146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					case 2:
						num = (short)517275662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_296;
					case 4:
						num = (short)1017774086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1E4;
					case 6:
						if (A_0 != global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
						{
							num = (short)1143406599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EC;
					case 7:
						num = (short)1254359058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_3EA;
					case 9:
						if (A_0 != global::SpecialFeatures.Comms.COMMS_OP.USB_READ_WRITE)
						{
							num = (short)13238276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EC;
					case 10:
						if (global::SpecialFeatures.Comms.SerialNumberValidator.IsCBISerialNumber(A_1))
						{
							num = (short)1171456011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D2;
					case 11:
					{
						num = (short)1258118109;
						short num3 = num;
						num = (short)1087134685;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_296;
						default:
							num = (short)940179456;
							if (num != 0)
							{
							}
							result = false;
							num = (short)1180893193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						if (this.g != "")
						{
							num = (short)490012674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D2;
					case 13:
						goto IL_3D2;
					case 14:
						if (this.h.UpdateSN(this.m_readRadioParams, this.g))
						{
							num = (short)1966735380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8;
					case 15:
						goto IL_2EC;
					case 16:
						if (!(bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햕ﾝ캟욡쾥욧쾩ﺭ", a_)])
						{
							num = (short)1373569041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E4;
					case 17:
						semaphore = global::System.Threading.Semaphore.OpenExisting(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햕\uda97펙\ud89b펟튡좣장톧ﶩ춫잭쒯", a_));
						semaphore.WaitOne();
						num = (short)5046277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (A_0 == global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_READ_WRITE)
						{
							num = (short)1023082511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Read_CBI_Initialized_Radio_First);
						num = (short)1917255683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_3D2;
					case 20:
						global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Radio_Serial_Number_updated);
						num = (short)2136342541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_88:
					if (!string.IsNullOrEmpty(A_1))
					{
						num = (short)42336256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Failed_Radio_Serial_Number_read);
					result = false;
					num = (short)532676627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E4:
					num = (short)334037004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EC:
					global::SpecialFeatures.Comms.Comms.b(new global::SpecialFeatures.Comms.Comms.CBIReturn(this.CbiReturnSN));
					num = (short)347537424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D2:
					num = (short)1460928520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_296:
					goto IL_3D2;
				}
				IL_E8:
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Radio_Serial_Number_update_failed);
				IL_3EA:;
			}
			catch (global::System.Exception)
			{
				result = false;
				global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Radio_Serial_Number_update_failed);
			}
			finally
			{
				num = (short)689242113;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						semaphore.Dispose();
						num = (short)1628504066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_43C;
						}
						continue;
					case 2:
						goto IL_471;
					}
					IL_43C:
					if (semaphore == null)
					{
						break;
					}
					num = (short)2093088768;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_471:;
			}
			num = (short)997588992;
			short num4 = num;
			num = (short)1044316161;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00193CA4 File Offset: 0x00191EA4
		public void CbiReturnSN(string RadioSN)
		{
			short num = (short)1253965824;
			short num2 = num;
			num = (short)1469944916;
			short num3 = num;
			num = (short)1963430996;
			switch (num3 == num)
			{
			}
			num = (short)102170625;
			if (num != 0)
			{
			}
			num = (short)763625472;
			if (num != 0)
			{
			}
			this.g = RadioSN;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00193D50 File Offset: 0x00191F50
		public global::SpecialFeatures.Comms.RadioParams GetRadioParams()
		{
			short num = (short)1311571968;
			short num2 = num;
			num = (short)596312065;
			if (num != 0)
			{
			}
			num = (short)1329084244;
			short num3 = num;
			num = (short)1708210004;
			switch (num3 == num)
			{
			}
			num = (short)1786642432;
			if (num != 0)
			{
			}
			return this.m_readRadioParams;
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00193E00 File Offset: 0x00192000
		public object GetLastCommsOTAPUserState()
		{
			short num = (short)2131296256;
			short num2 = num;
			num = (short)456484678;
			short num3 = num;
			num = (short)1999136582;
			switch (num3 == num)
			{
			}
			num = (short)703463425;
			if (num != 0)
			{
			}
			num = (short)363331584;
			if (num != 0)
			{
			}
			return this.d;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00193EB0 File Offset: 0x001920B0
		public bool SetCodeplugVersions(global::SpecialFeatures.Comms.RadioParams radioVersions)
		{
			switch (0)
			{
			case 0:
				goto IL_70;
			}
			int num;
			short num2;
			string radInfoGeneralSerialNumber_A9122Value;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				string text;
				string radInfoGeneralElectronicSerialNumber_A41744Value;
				switch (num)
				{
				case 0:
					if (!string.IsNullOrEmpty(radioVersions.MaceHardwareVersion))
					{
						num2 = (short)881000470;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
				{
					num2 = (short)91981074;
					short num3 = num2;
					num2 = (short)1503888658;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1212809216;
						if (num2 != 0)
						{
						}
						if (radioVersions.ESerialNumber == null)
						{
							num2 = (short)1242103814;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					num2 = (short)2025062402;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)252051471;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!string.IsNullOrEmpty(radioVersions.MaceHardwareType))
					{
						num2 = (short)395444233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FF;
				case 4:
					goto IL_173;
				case 5:
					radioInformation.OptionExpansionBoard.RadInfoOptionExpansionBoardBoardName_A37549Value = radioVersions.OptBoardName;
					num2 = (short)1974992904;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)767229953;
					if (num2 != 0)
					{
					}
					text = string.Empty;
					goto IL_3C5;
				case 7:
					radioInformation.OptionExpansionBoard.RadInfoOptionExpansionBoardBoardType_A37049Value = radioVersions.OptBrdHardwareType;
					num2 = (short)240123917;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_12E;
				case 9:
					radioInformation.General.RadInfoGeneralSecureHardwareTypeValue = radioVersions.MaceHardwareType;
					num2 = (short)27918353;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (!string.IsNullOrEmpty(radioVersions.MaceFlashVersion))
					{
						num2 = (short)712179730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_173;
				case 11:
					radioInformation.General.RadInfoGeneralModelNumber_A8539Value = radioVersions.ModelNumber;
					radioInformation.General.RadInfoGeneralSerialNumber_A9122Value = radInfoGeneralSerialNumber_A9122Value;
					radioInformation.General.RadInfoGeneralElectronicSerialNumber_A41744Value = radInfoGeneralElectronicSerialNumber_A41744Value;
					radioInformation.General.RadInfoGeneralFirmwareVersion_A8124Value = radioVersions.HostVersion;
					radioInformation.General.RadInfoGeneralDSPVersion_A7892Value = radioVersions.DspVersion;
					num2 = (short)409403402;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (!string.IsNullOrEmpty(radioVersions.OptBrdHardwareType))
					{
						num2 = (short)949026823;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_416;
				case 13:
					goto IL_416;
				case 14:
				{
					num2 = (short)1414332416;
					short num4 = num2;
					radioInformation.OptionExpansionBoard.RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048Value = radioVersions.OptBrdHwHostVersion;
					num2 = (short)590217232;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 15:
					text = global::Common.AESCryptoUtil.HEXString(radioVersions.ESerialNumber);
					goto IL_3C5;
				case 16:
					goto IL_47D;
				case 17:
					goto IL_1FF;
				case 18:
					radioInformation.General.RadInfoGeneralUCMVersion_A9591Value = radioVersions.MaceFlashVersion;
					num2 = (short)1357774852;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (!string.IsNullOrEmpty(radioVersions.OptBoardName))
					{
						num2 = (short)504496133;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12E;
				case 20:
					if (!string.IsNullOrEmpty(radioVersions.OptBrdHwHostVersion))
					{
						num2 = (short)497090574;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_47D;
				case 21:
					return true;
				case 22:
					radioInformation.General.RadInfoGeneralSecureHardwareVersionValue = radioVersions.MaceHardwareVersion;
					num2 = (short)1540554773;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (radioInformation != null)
					{
						num2 = (short)1884487691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_70;
				IL_12E:
				num2 = (short)623902723;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_173:
				radioInformation.General.RadInfoGeneralPSDTVersion_A8768Value = radioVersions.PsdtVersion;
				radioInformation.General.RadInfoGeneralBootloaderVersion_A7567Value = radioVersions.BootAppVersion;
				radioInformation.General.RadInfoGeneralCodeplugVersion_A7683Value = radioVersions.CodeplugVersion.ToString();
				radioInformation.General.RadInfoGeneralTuningVersion_A9509Value = radioVersions.TuneVersion;
				num2 = (short)775749644;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1FF:
				num2 = (short)1153236992;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3C5:
				radInfoGeneralElectronicSerialNumber_A41744Value = text;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num2 = (short)1316618263;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_416:
				num2 = (short)2078801940;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_47D:
				num2 = (short)2031288339;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_70:
			radInfoGeneralSerialNumber_A9122Value = global::SpecialFeatures.Comms.ParseDataHelper.RadioSNToString(radioVersions.SerialNumber);
			num2 = (short)219021313;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x001943D8 File Offset: 0x001925D8
		public void ForceClose()
		{
			short num = (short)612237312;
			short num2 = num;
			num = (short)155558274;
			short num3 = num;
			num = (short)1322492290;
			switch (num3 == num)
			{
			}
			num = (short)133496833;
			if (num != 0)
			{
			}
			num = (short)224657408;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00194488 File Offset: 0x00192688
		public static void DispalyUpdateStatusChanged(double n, string status)
		{
			short num = (short)656998400;
			short num2 = num;
			num = (short)693347858;
			short num3 = num;
			num = (short)2067179026;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)20643840;
				if (num != 0)
				{
				}
				num = (short)263389185;
				if (num != 0)
				{
				}
				num = (short)1249378305;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					global::SpecialFeatures.Comms.Comms.a(n, status);
					num = (short)1508704258;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				case 2:
					return;
				}
				IL_CD:
				if (global::SpecialFeatures.Comms.Comms.a == null)
				{
					break;
				}
				num = (short)1953824768;
				num4 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x001945A4 File Offset: 0x001927A4
		protected string GetRadioAlias()
		{
			short num;
			for (;;)
			{
				num = (short)1989279744;
				short num2 = num;
				num = (short)1270743040;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)1767440385;
					if (num != 0)
					{
					}
					num = (short)781233349;
					short num4 = num;
					num = (short)1263185093;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A1;
					}
					break;
				}
				}
			}
			IL_A1:
			num = (short)1968504832;
			if (num != 0)
			{
			}
			string result = string.Empty;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			global::Motorola.Common.Communication.CommonUtil.IshHeader item = new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 1026, 0);
			list.Add(item);
			try
			{
				switch (0)
				{
				case 0:
					goto IL_FE;
				}
				int num3;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_E7:
					switch (num3)
					{
					case 0:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)381353986;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32B;
					case 1:
						goto IL_344;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
						num = (short)2081554435;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						try
						{
							num = (short)664666112;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1B5;
									}
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1858469893;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)541982726;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_2BB;
								case 3:
									goto IL_2A3;
								case 4:
								{
									int index = 59;
									int count = 34;
									char[] trimChars = new char[]
									{
										'\0',
										' ',
										'\r',
										'\n'
									};
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									result = global::System.Text.Encoding.BigEndianUnicode.GetString(keyValuePair.Value.Data, index, count).TrimEnd(trimChars);
									num = (short)1837432835;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_2A3;
								case 6:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 1026)
									{
										num = (short)2111111172;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1B7:
								num = (short)734986241;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B5:
								goto IL_1B7;
								IL_2A3:
								num = (short)575471618;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_2BB:;
						}
						finally
						{
							num = (short)1112211457;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
								switch (num3)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1428291586;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2EF;
									}
									continue;
								case 2:
									goto IL_328;
								}
								IL_2EF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)869269504;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_328:;
						}
						goto IL_32B;
					}
					goto IL_FE;
					IL_32B:
					num = (short)1284112385;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_344:
				return result;
				IL_FE:
				codeplugInIshItemCollection = this.h.ReadBlock(this.m_readRadioParams, list, null).GetCodeplugInIshItemCollection();
				num = (short)1462239232;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_E7;
			}
			catch
			{
				this.a();
			}
			return result;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00194938 File Offset: 0x00192B38
		public void UpdatePINPasswordBeforeWrite()
		{
			short num = (short)1619263488;
			short num2 = num;
			num = (short)852360711;
			short num3 = num;
			num = (short)1080360455;
			switch (num3 == num)
			{
			}
			num = (short)406913024;
			if (num != 0)
			{
			}
			num = (short)1236074497;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			string value = radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.Value;
			radioWide.Labtool.RadWideLabtoolEncryptedPINPassword_A41702.SetValue(value);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00194A14 File Offset: 0x00192C14
		private bool b()
		{
			short num = (short)1586626560;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
			bool result;
			for (;;)
			{
				IL_32:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num3)
				{
				case 0:
					goto IL_238;
				case 1:
					if (trunkingSystemRecset != null)
					{
						num = (short)311164928;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					try
					{
						num = (short)1292184043;
						short num4 = num;
						num = (short)1154689515;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_195:
							num = (short)1896939524;
							num3 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1600913408;
							if (num != 0)
							{
							}
							num = (short)923926528;
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
									goto IL_118;
								}
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)745013253;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1528037379;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1CA;
							case 3:
								if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current).General.TrkSysGeneralSystemType_A9252Value == 2)
								{
									num = (short)1943863302;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								goto IL_1AC;
							case 5:
								num = (short)1034092546;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_191;
							}
							IL_11A:
							num = (short)1809645569;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_118:
							goto IL_11A;
						}
						IL_191:
						result = true;
						goto IL_195;
						IL_1AC:
						IL_1CA:
						return result;
					}
					finally
					{
						num = (short)1298464769;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)464715778;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_201;
								}
								continue;
							case 2:
								goto IL_235;
							}
							IL_201:
							if (enumerator == null)
							{
								break;
							}
							num = (short)408092672;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_235:;
					}
					goto IL_238;
				}
				goto IL_44;
				IL_238:
				num = (short)1183973377;
				if (num != 0)
				{
				}
				enumerator = trunkingSystemRecset.GetEnumerator();
				num = (short)1159069698;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_44:
			result = false;
			trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
			num = (short)2082996225;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00194CC4 File Offset: 0x00192EC4
		private global::SpecialFeatures.Comms.IDeviceProxy a(global::SpecialFeatures.Comms.RadioParams A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_1)
		{
			short num = (short)1922301955;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1342111745;
					if (num != 0)
					{
					}
					if (!this.h.CurrentRadioIsConnected)
					{
						num = (short)392495109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_186;
				case 1:
					num = (short)1532821506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_161;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					num = (short)1715339264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)595283414;
					short num3 = num;
					num = (short)1035029974;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_161;
					default:
						goto IL_12F;
					}
					break;
				}
				}
				IL_3C:
				if (this.h != null)
				{
					num = (short)1588527105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_161:
				if (this.h == null)
				{
					goto IL_186;
				}
				num = (short)612040708;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5E:
			num = (short)1361248256;
			short num4 = num;
			return global::SpecialFeatures.Comms.DeviceManagerSingleTon.Instance.CreateDeviceProxy(A_0, A_1);
			IL_12F:
			num = (short)383057920;
			if (num != 0)
			{
			}
			goto IL_5E;
			IL_186:
			return this.h;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00194E60 File Offset: 0x00193060
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1857790027;
				short num2 = num;
				num = (short)506503243;
				switch (num2 == num)
				{
				}
				num = (short)1279197184;
				if (num != 0)
				{
				}
				this.a(false);
			}
			finally
			{
				num = (short)1311309825;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)1911554048;
			short num3 = num;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00194F28 File Offset: 0x00193128
		public void Dispose()
		{
			short num = (short)643337721;
			short num2 = num;
			num = (short)266571257;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1713831936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)69468161;
			if (num != 0)
			{
			}
			num = (short)1633222656;
			if (num != 0)
			{
			}
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00194FDC File Offset: 0x001931DC
		private void a(bool A_0)
		{
			short num = (short)467206147;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_57;
				case 2:
					if (this.h != null)
					{
						num = (short)1548746756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					this.h.Dispose();
					num = (short)2066939909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1806565377;
					if (num != 0)
					{
					}
					num = (short)1993964663;
					short num3 = num;
					num = (short)1946451063;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_57;
					default:
					{
						num = (short)1289158656;
						short num4 = num;
						num = (short)947257344;
						if (num != 0)
						{
						}
						goto IL_5C;
					}
					}
					break;
				}
				}
				IL_3C:
				if (A_0)
				{
					num = (short)1381498881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_57:
				num = (short)1327955970;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5C:
				this.h = null;
				num = (short)1623130112;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00195164 File Offset: 0x00193364
		private void a()
		{
			short num = (short)277020672;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)837915226;
					short num3 = num;
					num = (short)1671467610;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1399717888;
						if (num != 0)
						{
						}
						num = (short)872677376;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_10D;
				case 2:
					num = (short)1089863681;
					if (num != 0)
					{
					}
					this.h.Dispose();
					num = (short)1968766977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A7:
				if (this.h == null)
				{
					break;
				}
				num = (short)1078853634;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10D:
			this.h = null;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00195288 File Offset: 0x00193488
		public string GetBluetoothPANIPAddress(global::SpecialFeatures.Comms.COMMS_OP WriteType)
		{
			short num = (short)621150209;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_99;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_129;
				case 3:
				{
					num = (short)705298432;
					short num3 = num;
					num = (short)950861825;
					if (num != 0)
					{
					}
					if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_READ_WRITE)
					{
						num = (short)1692401666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_134;
				}
				}
				IL_34:
				num = (short)56110331;
				short num4 = num;
				num = (short)409218299;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_134;
				default:
					num = (short)2107441152;
					if (num != 0)
					{
					}
					if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_CLONE)
					{
						num = (short)103743488;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)820969475;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_99:
			return global::SpecialFeatures.Comms.BluetoothPANProgramming.BluetoothPANIPForClone;
			IL_129:
			return global::SpecialFeatures.Comms.BluetoothPANProgramming.BluetoothPANIPForWR;
			IL_134:
			return null;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x001953CC File Offset: 0x001935CC
		private bool a(global::SpecialFeatures.Comms.COMMS_OP A_0, ref global::SpecialFeatures.Comms.RadioParams A_1, bool A_2, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_3 = global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
		{
			int a_ = 3;
			short num;
			for (;;)
			{
				num = (short)249888768;
				switch (num)
				{
				default:
				{
					num = (short)2005309197;
					short num2 = num;
					num = (short)116102925;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_5C;
					}
					break;
				}
				}
			}
			IL_5C:
			num = (short)395247616;
			if (num != 0)
			{
			}
			bool flag = false;
			bool flag4;
			try
			{
				num = (short)175702049;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::SpecialFeatures.Programming.OTAPProgrammingWindow otapprogrammingWindow;
					bool? flag3;
					global::SpecialFeatures.Programming.ProgrammingOperation operation;
					switch (num3)
					{
					case 0:
						num = (short)1317535754;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (otapprogrammingWindow.PrescenceResult.DevicePrescence == global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_ABSENT)
						{
							num = (short)1619853343;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)654770181;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_753;
					case 3:
						goto IL_183;
					case 4:
						goto IL_7C8;
					case 5:
						if (otapprogrammingWindow.PrescenceResult.DevicePrescence == global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_TIMEOUT)
						{
							num = (short)1410531336;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B7;
					case 6:
						if (flag)
						{
							num = (short)1924464658;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C8;
					case 7:
						if (string.IsNullOrEmpty(A_1.ConnectionInfo.UniqueAddress))
						{
							num = (short)364511243;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C8;
					case 8:
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.The_application_could_not_communicate_with_the_Automatic_Registration_Server_ARS);
						flag = false;
						num = (short)1665007633;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						bool? flag2 = flag3;
						flag4 = true;
						num = (short)469893132;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (A_0 == global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
						{
							num = (short)1184432130;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)956694563;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						flag = false;
						global::SpecialFeatures.Comms.Comms.a(0.0, global::CommonResources.AppResources.Could_not_find_a_radio_connected_to_a_USB_port);
						num = (short)772734992;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						bool? flag2;
						if (flag2.GetValueOrDefault() == flag4 & flag2 != null)
						{
							num = (short)1932918806;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BB;
					}
					case 13:
						num = (short)1338310686;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_6E6;
					case 15:
						if (A_2)
						{
							num = (short)2098003995;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						operation = global::SpecialFeatures.Programming.ProgrammingOperation.PROGRAMMING_OPERATION_WRITE;
						num = (short)2010578958;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_7C8;
					case 17:
						goto IL_7C8;
					case 18:
						num = (short)1475674119;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_7C8;
					case 20:
						if (flag3 != null)
						{
							num = (short)1918500873;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BB;
					case 21:
						num = (short)1256783906;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						this.d = otapprogrammingWindow.OTAPProgrammingLastState;
						num = (short)1129709596;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_6E6;
					case 24:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_5E5;
							}
							for (;;)
							{
								IL_5CE:
								switch (num3)
								{
								case 0:
									flag = true;
									num = (short)1970864131;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (A_1 != null)
									{
										num = (short)1630208000;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_677;
								case 2:
									goto IL_68F;
								case 3:
									goto IL_677;
								}
								goto IL_5E5;
								IL_677:
								num = (short)653983746;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_68F:
							goto IL_377;
							IL_5E5:
							this.h = this.a(new global::SpecialFeatures.Comms.RadioParams
							{
								Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
								ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo(),
								ConnectionInfo = 
								{
									ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter
								}
							}, A_3);
							A_1 = this.h.ReadExtendedDeviceInfo();
							num = (short)903610369;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_5CE;
						}
						catch (global::System.Exception ex)
						{
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.Radio_Caught_exception_while_locating_radio_IP_Address);
							global::System.Exception innerException = ex.InnerException;
							flag = false;
							this.a();
							goto IL_377;
						}
						goto IL_6B7;
						IL_377:
						num = (short)1969487878;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_2FE;
					case 26:
						goto IL_7C8;
					case 27:
						goto IL_4F8;
					case 28:
						if (otapprogrammingWindow.PrescenceResult.DevicePrescence != global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_PRESENT)
						{
							num = (short)1059782669;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 29:
						goto IL_7E2;
					case 30:
						if (otapprogrammingWindow.PrescenceResult.DevicePrescence == global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_USER_ENTERED)
						{
							num = (short)1733689347;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2039808001;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.The_radio_is_not_on_the_network);
						flag = false;
						num = (short)2008285203;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						try
						{
							this.h = this.a(new global::SpecialFeatures.Comms.RadioParams
							{
								Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
								ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo(),
								ConnectionInfo = 
								{
									UniqueAddress = otapprogrammingWindow.PrescenceResult.DeviceIPAddress,
									ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap
								}
							}, A_3);
							A_1 = this.h.ReadExtendedDeviceInfo();
							flag = true;
							goto IL_7C8;
						}
						catch (global::System.Exception ex2)
						{
							this.a();
							flag = false;
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.The_radio_network_address_could_not_be_determined);
							global::System.Exception innerException2 = ex2.InnerException;
							goto IL_7C8;
						}
						goto IL_4F8;
					case 33:
						switch (0)
						{
						case 0:
							goto IL_12D;
						}
						continue;
					case 34:
						if (A_0 == global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
						{
							num = (short)114884633;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C8;
					case 35:
						if (A_0 != global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
						{
							num = (short)8454165;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FE;
					}
					IL_12D:
					if (A_0 != global::SpecialFeatures.Comms.COMMS_OP.USB_READ_WRITE)
					{
						num = (short)570163200;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_753;
					IL_183:
					num = (short)215023648;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BB:
					flag = false;
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚅ", a_) + global::CommonResources.AppResources.POP25_Operation_Aborted);
					num = (short)450756634;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FE:
					num = (short)1116995599;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F8:
					operation = global::SpecialFeatures.Programming.ProgrammingOperation.PROGRAMMING_OPERATION_READ;
					num = (short)674037783;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B7:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.The_radio_network_address_could_not_be_determined);
					flag = false;
					num = (short)591462404;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E6:
					otapprogrammingWindow = new global::SpecialFeatures.Programming.OTAPProgrammingWindow(operation, this.d);
					global::System.Windows.Window mainWindow = global::System.Windows.Application.Current.MainWindow;
					otapprogrammingWindow.Owner = mainWindow;
					flag3 = otapprogrammingWindow.ShowDialog();
					num = (short)684458004;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_753:
					num = (short)1453850648;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_7C8:
					num = (short)1702494237;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_7E2:
				return flag;
			}
			catch
			{
				this.a();
				flag4 = false;
			}
			num = (short)1634795521;
			if (num != 0)
			{
			}
			num = (short)979501056;
			short num4 = num;
			return flag4;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00195C6C File Offset: 0x00193E6C
		public bool CbiProgram(global::SpecialFeatures.Comms.COMMS_OP readType)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			short num2;
			bool flag;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_86;
				case 1:
					num2 = (short)853475329;
					if (num2 != 0)
					{
					}
					try
					{
						switch (0)
						{
						case 0:
							goto IL_E6;
						}
						for (;;)
						{
							IL_D0:
							switch (num)
							{
							case 0:
								global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, global::CommonResources.AppResources.Radio_CBI_Program_Successfully);
								num2 = (short)572391427;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								if (flag)
								{
									num2 = (short)1626275840;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_149;
							case 2:
								goto IL_16C;
							case 3:
								num2 = (short)405471234;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_E6;
						}
						IL_149:
						throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Radio_Serial_Number_update_failed);
						IL_16C:
						return flag;
						IL_E6:
						global::SpecialFeatures.Comms.RadioParams radioPara;
						flag = this.h.CBIProgram(radioPara);
						num2 = (short)70385665;
						num = (int)((global::System.IntPtr)num2);
						goto IL_D0;
					}
					catch (global::System.Exception)
					{
						flag = false;
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.Radio_CBI_Program_failed);
						return flag;
					}
					finally
					{
						this.a();
					}
					goto IL_18D;
				case 2:
					goto IL_18D;
				}
				goto IL_25;
				IL_18D:
				num2 = (short)534052864;
				short num3 = num2;
				flag = false;
				num2 = (short)1925251073;
				num = (int)((global::System.IntPtr)num2);
			}
			return flag;
			IL_25:
			num2 = (short)278803944;
			short num4 = num2;
			num2 = (short)1310733800;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_86:
				global::SpecialFeatures.Comms.RadioParams radioPara;
				if (this.a(readType, ref radioPara, true, global::Motorola.Common.Communication.CommonUtil.RadioOperation.CBIProgram, 0, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌ꆎꆐ붒ꖔ릖ꦘ", a_)))
				{
					num2 = (short)85852162;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				return false;
			}
			default:
			{
				num2 = (short)976289792;
				if (num2 != 0)
				{
				}
				global::SpecialFeatures.Comms.RadioParams radioPara = null;
				num2 = (short)1552941056;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00195E98 File Offset: 0x00194098
		public bool WriteRadioForDepot(global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioCodeplug, global::SpecialFeatures.Comms.COMMS_OP WriteType, global::SpecialFeatures.Comms.RadioParams codeplgParams, object lastCommsUserState)
		{
			short num = (short)288358403;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_78;
				case 1:
					goto IL_58;
				case 2:
					if (lastCommsUserState != null)
					{
						num = (short)794230788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.d = null;
					num = (short)1111162880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					this.d = (lastCommsUserState as global::SpecialFeatures.Programming.OTAPProgrammingParameters);
					num = (short)428605445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)47904141;
					short num3 = num;
					num = (short)491910541;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_58;
					default:
						goto IL_FE;
					}
					break;
				}
				}
				IL_3C:
				if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
				{
					num = (short)767295489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_17D;
				IL_58:
				num = (short)167772162;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_78:
			num = (short)1481965569;
			if (num != 0)
			{
			}
			goto IL_17D;
			IL_FE:
			num = (short)1094909952;
			short num4 = num;
			num = (short)1712783360;
			if (num != 0)
			{
			}
			IL_17D:
			return this.WriteRadioForDepot(radioCodeplug, WriteType, codeplgParams);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0019602C File Offset: 0x0019422C
		public bool WriteRadioForDepot(global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioCodeplug, global::SpecialFeatures.Comms.COMMS_OP WriteType, global::SpecialFeatures.Comms.RadioParams codeplgParams)
		{
			int a_ = 13;
			short num = (short)1790050304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						global::SpecialFeatures.Comms.RadioParams radioPara;
						if (!this.a(WriteType, ref radioPara, false, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program))
						{
							num = (short)1053556738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F1;
					}
					case 1:
						try
						{
							num = (short)1545666561;
							if (num != 0)
							{
							}
							global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
							pbaObject.SetCodeplug(radioCodeplug);
							global::SpecialFeatures.Comms.RadioParams radioPara;
							this.h.ForceWrite(radioPara, pbaObject, null);
							bool result = true;
							global::System.Threading.Thread.Sleep(500);
							return result;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							global::SpecialFeatures.Comms.Comms.a(0.0, ex.Message);
							global::SpecialFeatures.Comms.Logger.Log(string.Concat(new string[]
							{
								global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮏", a_),
								global::System.DateTime.Now.ToString(),
								global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("낏뾑뒓", a_),
								ex.Message,
								global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춏", a_)
							}));
							bool result;
							return result;
						}
						catch (global::System.Exception ex2)
						{
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex2.Message);
							global::System.Exception innerException = ex2.InnerException;
							bool result;
							return result;
						}
						finally
						{
							this.a();
						}
						goto IL_1F1;
					case 2:
						goto IL_CF;
					}
					goto IL_43;
					IL_1F1:
					num = (short)1360265217;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CF:
				num = (short)696385536;
				short num3 = num;
				return false;
				IL_43:
				num = (short)811020021;
				short num4 = num;
				num = (short)47918837;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					bool result;
					return result;
				}
				default:
				{
					num = (short)1112276992;
					if (num != 0)
					{
					}
					bool result = false;
					global::SpecialFeatures.Comms.RadioParams radioPara = null;
					num = (short)1092222976;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
				break;
			}
			}
		}

		// Token: 0x040009DD RID: 2525
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::SpecialFeatures.Comms.Comms.DisplayUpdateStatus a;

		// Token: 0x040009DE RID: 2526
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::SpecialFeatures.Comms.Comms.MainUIDisplayCBI b;

		// Token: 0x040009DF RID: 2527
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::SpecialFeatures.Comms.Comms.MainUIDisplayOTAP c;

		// Token: 0x040009E0 RID: 2528
		public global::SpecialFeatures.Comms.RadioParams m_readRadioParams;

		// Token: 0x040009E1 RID: 2529
		protected global::Motorola.Common.Communication.Pba.DataPartition oldSecurityPartition;

		// Token: 0x040009E2 RID: 2530
		protected global::System.Collections.Generic.Dictionary<string, int[]> m_RadioSystemIds;

		// Token: 0x040009E3 RID: 2531
		protected global::System.Collections.Generic.Dictionary<string, int[]> m_RadioCnvSysIds;

		// Token: 0x040009E4 RID: 2532
		protected global::System.Collections.Generic.Dictionary<string, int> m_AstroOtarRadioIds;

		// Token: 0x040009E5 RID: 2533
		protected global::System.Collections.Generic.Dictionary<string, int> m_CustomerId;

		// Token: 0x040009E6 RID: 2534
		protected global::System.Collections.Generic.Dictionary<string, bool> m_RadioInhibitedTrunking;

		// Token: 0x040009E7 RID: 2535
		protected global::System.Collections.Generic.Dictionary<string, bool> m_RadioKilled;

		// Token: 0x040009E8 RID: 2536
		protected global::SpecialFeatures.Comms.DataProfIP[] m_RadioDataProfIPs;

		// Token: 0x040009E9 RID: 2537
		protected string[] m_SoftIds;

		// Token: 0x040009EA RID: 2538
		protected string m_BluetoothFriendlyName;

		// Token: 0x040009EB RID: 2539
		protected bool m_EncryptPasswordFlag;

		// Token: 0x040009EC RID: 2540
		protected string m_EncryptPassword;

		// Token: 0x040009ED RID: 2541
		protected string m_FwVerInRadio = "";

		// Token: 0x040009EE RID: 2542
		private global::SpecialFeatures.Programming.OTAPProgrammingParameters d;

		// Token: 0x040009EF RID: 2543
		private bool? e;

		// Token: 0x040009F0 RID: 2544
		private global::SpecialFeatures.Programming.OTAPPrescenceResult f;

		// Token: 0x040009F1 RID: 2545
		private string g = "";

		// Token: 0x040009F2 RID: 2546
		public string m_LastLPKUserState;

		// Token: 0x040009F3 RID: 2547
		private global::SpecialFeatures.Comms.IDeviceProxy h;

		// Token: 0x040009F4 RID: 2548
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> i;

		// Token: 0x040009F5 RID: 2549
		private bool j;

		// Token: 0x040009F6 RID: 2550
		private bool k;

		// Token: 0x040009F7 RID: 2551
		private bool l;

		// Token: 0x040009F8 RID: 2552
		private string m;

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x06001255 RID: 4693
		public delegate void MainUIDisplayCBI(global::SpecialFeatures.Comms.Comms.CBIReturn CbiSN);

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x06001259 RID: 4697
		public delegate void CBIReturn(string radioSN);

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x0600125D RID: 4701
		public delegate void DisplayUpdateStatus(double n, string stat);

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x06001261 RID: 4705
		public delegate void MainUIDisplayOTAP(global::SpecialFeatures.Programming.ProgrammingOperation ProgOp, global::SpecialFeatures.Programming.OTAPProgrammingParameters LastCommsOTAPUserState, global::SpecialFeatures.Comms.Comms.RadioOTAPObject radioObject);

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x06001265 RID: 4709
		public delegate void RadioOTAPObject(bool? otapDialogResult, global::SpecialFeatures.Programming.OTAPProgrammingParameters RadioProgrammingParameters, global::SpecialFeatures.Programming.OTAPPrescenceResult RadioPrescenceResult);

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x06001269 RID: 4713
		public delegate void WriteRadioQuery(global::SpecialFeatures.Comms.Comms.RadioRtn info);

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x0600126D RID: 4717
		public delegate void RadioRtn(global::System.Windows.MessageBoxResult RadioRtn);
	}
}
