using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpKeyValidatorLib;
using AcpUtility;
using CommonResources;
using CommonUtility;
using ConstraintHelper;
using Motorola.Acp.PackUnpack.Ish;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.PackExec;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.ToneSignalingList;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;
using SpecialFeatures.Comms.Util;
using SpecialFeatures.DepotLabtool;
using SpecialFeatures.Flashport.FlashkeyLib;
using SpecialFeatures.Model_Configuration;
using SpecialFeatures.RadioLanguagePack;
using SpecialFeatures.ReadWriteTlsPsk;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000E6 RID: 230
	public sealed class UpgradeRadio
	{
		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x0011BA24 File Offset: 0x00119C24
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x0011BAD4 File Offset: 0x00119CD4
		public string fileHostVersion
		{
			get
			{
				short num = (short)182064793;
				short num2 = num;
				num = (short)1609045657;
				switch (num2 == num)
				{
				}
				num = (short)1735196673;
				if (num != 0)
				{
				}
				num = (short)1847590912;
				short num3 = num;
				num = (short)311427072;
				if (num != 0)
				{
				}
				return this.s;
			}
			set
			{
				short num = (short)66229222;
				short num2 = num;
				num = (short)1024168934;
				switch (num2 == num)
				{
				}
				num = (short)369491969;
				if (num != 0)
				{
				}
				num = (short)1361444864;
				short num3 = num;
				num = (short)1204092928;
				if (num != 0)
				{
				}
				this.s = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x0011BB84 File Offset: 0x00119D84
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x0011BC34 File Offset: 0x00119E34
		public string BBFBundleVersion
		{
			get
			{
				short num = (short)326483348;
				short num2 = num;
				num = (short)1653980564;
				switch (num2 == num)
				{
				}
				num = (short)1005846528;
				if (num != 0)
				{
				}
				num = (short)550305792;
				short num3 = num;
				num = (short)372506625;
				if (num != 0)
				{
				}
				return this.u;
			}
			set
			{
				short num = (short)1217032408;
				short num2 = num;
				num = (short)509898968;
				switch (num2 == num)
				{
				}
				num = (short)698023937;
				if (num != 0)
				{
				}
				num = (short)134414336;
				short num3 = num;
				num = (short)2047082496;
				if (num != 0)
				{
				}
				this.u = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x0011BCE8 File Offset: 0x00119EE8
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x0011BD98 File Offset: 0x00119F98
		public string RadioHostVersion
		{
			get
			{
				short num = (short)346261910;
				short num2 = num;
				num = (short)1069713814;
				switch (num2 == num)
				{
				}
				num = (short)263585793;
				if (num != 0)
				{
				}
				num = (short)1937833984;
				short num3 = num;
				num = (short)1257504768;
				if (num != 0)
				{
				}
				return this.v;
			}
			set
			{
				short num = (short)1940579895;
				short num2 = num;
				num = (short)927589943;
				switch (num2 == num)
				{
				}
				num = (short)124518401;
				if (num != 0)
				{
				}
				num = (short)1391132672;
				short num3 = num;
				num = (short)1622081536;
				if (num != 0)
				{
				}
				this.v = value;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0011BE48 File Offset: 0x0011A048
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
		public bool IsRadioTakesBBF
		{
			get
			{
				short num = (short)360525091;
				short num2 = num;
				num = (short)1598172451;
				switch (num2 == num)
				{
				}
				num = (short)754778112;
				if (num != 0)
				{
				}
				num = (short)793247744;
				short num3 = num;
				num = (short)218169345;
				if (num != 0)
				{
				}
				return this.t;
			}
			set
			{
				short num = (short)1991180289;
				if (num != 0)
				{
				}
				num = (short)629765004;
				short num2 = num;
				num = (short)1743025036;
				switch (num2 == num)
				{
				}
				num = (short)1973223424;
				short num3 = num;
				num = (short)1381826560;
				if (num != 0)
				{
				}
				this.t = value;
			}
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0011BFA8 File Offset: 0x0011A1A8
		public UpgradeRadio()
		{
			int a_ = 4;
			this.p = string.Empty;
			this.q = string.Concat(new object[]
			{
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆歷", a_),
				global::System.IO.Path.DirectorySeparatorChar,
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆ﾊﶎﺐﾒ", a_),
				global::System.IO.Path.DirectorySeparatorChar
			});
			this.s = string.Empty;
			this.u = string.Empty;
			this.v = string.Empty;
			base..ctor();
			this.a = "";
			this.b = "";
			this.c = "";
			this.d = null;
			this.e = null;
			this.f = null;
			this.g = null;
			this.h = false;
			this.i = false;
			this.j = false;
			this.n = 1;
			this.r = true;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0011C0A0 File Offset: 0x0011A2A0
		internal UpgradeRadio(global::System.ComponentModel.BackgroundWorker worker, bool IsRefresh)
		{
			int a_ = 11;
			this.p = string.Empty;
			this.q = string.Concat(new object[]
			{
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8dﾏ聯鍊", a_),
				global::System.IO.Path.DirectorySeparatorChar,
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍ﾏﮓﶛ", a_),
				global::System.IO.Path.DirectorySeparatorChar
			});
			this.s = string.Empty;
			this.u = string.Empty;
			this.v = string.Empty;
			base..ctor();
			this.a = "";
			this.b = "";
			this.c = "";
			this.d = null;
			this.e = null;
			this.f = worker;
			this.g = new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio.ProgressCallback(this.f, 0, 0);
			this.h = IsRefresh;
			this.i = false;
			this.j = false;
			this.n = 1;
			this.r = true;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x000030F9 File Offset: 0x000012F9
		public UpgradeRadio(global::System.ComponentModel.BackgroundWorker worker, bool IsRefresh, string modelNumber, string radioHostVersion, string hostVersion, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astroFirmware) : this(worker, IsRefresh)
		{
			this.a = modelNumber;
			this.fileHostVersion = hostVersion;
			this.RadioHostVersion = radioHostVersion;
			this.x = astroFirmware;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0011C1A4 File Offset: 0x0011A3A4
		public UpgradeRadio(global::System.ComponentModel.BackgroundWorker worker, bool IsRefresh, global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astrodeviceinfo, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofwPackageDesc, string astrofwPackagePath)
		{
			int a_ = 12;
			this.p = string.Empty;
			this.q = string.Concat(new object[]
			{
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8eﺐ", a_),
				global::System.IO.Path.DirectorySeparatorChar,
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슎ﺐ杖ﲜ", a_),
				global::System.IO.Path.DirectorySeparatorChar
			});
			this.s = string.Empty;
			this.u = string.Empty;
			this.v = string.Empty;
			base..ctor();
			this.a = "";
			this.b = "";
			this.c = "";
			this.d = null;
			this.e = null;
			this.f = worker;
			this.g = new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio.ProgressCallback(this.f, 0, 0);
			this.h = IsRefresh;
			this.i = false;
			this.j = false;
			this.n = 1;
			this.r = true;
			this.w = astrodeviceinfo;
			this.x = astrofwPackageDesc;
			this.y = astrofwPackagePath;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0011C2BC File Offset: 0x0011A4BC
		internal void FlashRadio(string upgradeFile)
		{
			short num = (short)1108344832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1552220161;
				if (num != 0)
				{
				}
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = true;
				string empty = string.Empty;
				string text = string.Empty;
				string text2 = string.Empty;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_3CA;
					}
					for (;;)
					{
						IL_6F:
						string text3;
						string postFlashCodeplugFields;
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioCodeplug;
						global::SpecialFeatures.Flashport.FlashRadio.FlashCodeplug flashCodeplug;
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection a_;
						global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
						bool flag8;
						switch (num2)
						{
						case 0:
							goto IL_214E;
						case 1:
						{
							bool flag5;
							if (flag5)
							{
								num = (short)688979991;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_218E;
						}
						case 2:
							goto IL_BF9;
						case 3:
							num = (short)629145782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!string.IsNullOrEmpty(this.k.ConBrdHardwareType))
							{
								num = (short)159711283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25E9;
						case 5:
							if (this.f != null)
							{
								num = (short)1776812108;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_FB5;
						case 6:
							if (this.e == null)
							{
								num = (short)1899561015;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2363;
						case 7:
							goto IL_19E0;
						case 8:
							text3 = global::CommonResources.AppResources.FLASHport_Upgrade_Completed_Successfully;
							num = (short)96403639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.ConnectDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.ReadRadInfoStart, global::CommonResources.AppResources.Reading_and_validating_radio_parameters);
							global::System.ComponentModel.BackgroundWorker backgroundWorker = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker.ReportProgress(num3, userState);
							num = (short)755761232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							if (!this.e.ValidateKey())
							{
								num = (short)1162608763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_185E;
						case 11:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState2 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Validating_user_parameters);
							global::System.ComponentModel.BackgroundWorker backgroundWorker2 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker2.ReportProgress(num3, userState2);
							num = (short)227278990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState3 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.ReadRadInfoDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Validating_user_parameters);
							global::System.ComponentModel.BackgroundWorker backgroundWorker3 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker3.ReportProgress(num3, userState3);
							string serial = global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.convertSerialNumberToAscii(this.b);
							global::SpecialFeatures.Flashport.FlashRadio.RadioInfoParams userState4 = new global::SpecialFeatures.Flashport.FlashRadio.RadioInfoParams(this.a, serial, this.c);
							this.f.ReportProgress(this.n, userState4);
							num = (short)112328751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							string text4;
							if (!string.IsNullOrEmpty(text4))
							{
								num = (short)1251999906;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_271F;
						}
						case 14:
							goto IL_271F;
						case 15:
							if (!global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio.checkPCIFieldsValue(this.a, this.fileHostVersion, this.c))
							{
								num = (short)1323106391;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1926;
						case 16:
							if (!this.h)
							{
								num = (short)968556572;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F17;
						case 17:
							num = (short)1455685751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (this.f != null)
							{
								num = (short)1496973333;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2629;
						case 19:
							if (!this.h)
							{
								num = (short)415760461;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_271F;
						case 20:
							num = (short)93323321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState5 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.LP_Begin_Language_Pack_Update);
							global::System.ComponentModel.BackgroundWorker backgroundWorker4 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker4.ReportProgress(num3, userState5);
							num = (short)973209679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							string text5 = this.a;
							bool flag6 = this.e.IsModelUpgradeKey();
							num = (short)1462042756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							num = (short)2008875067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							this.g.MaxSteps = 8;
							this.g.CurrentStep = this.n;
							num = (short)1488846894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							goto IL_161C;
						case 26:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState6 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, text2);
							this.f.ReportProgress(100, userState6);
							num = (short)1208615008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 27:
						{
							bool flag7;
							if (flag7)
							{
								num = (short)1677525153;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)10354689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
							postFlashCodeplugFields = this.e();
							num = (short)14745650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
						{
							bool flag5 = false;
							bool flag7 = false;
							text3 = global::CommonResources.AppResources.Radio_Refresh_Completed_Successfully;
							num = (short)270794896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
						{
							string text6 = global::CommonResources.AppResources.Disconnect_Radio_but_do_not_turn_off.AcpStringFormat(new object[]
							{
								text3
							});
							num = (short)70254731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 31:
							goto IL_218E;
						case 32:
							text3 = global::CommonResources.AppResources.Upgrade_Completed_Successfully_Exception_AB_No_AB_SW;
							num = (short)63439008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							if (!this.j)
							{
								num = (short)1786904675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25E9;
						case 34:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState7 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.ConnectStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Find_valid_device);
							global::System.ComponentModel.BackgroundWorker backgroundWorker5 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker5.ReportProgress(num3, userState7);
							num = (short)1952514227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 35:
							this.g.MaxSteps = 8;
							this.g.CurrentStep = this.n;
							num = (short)647757995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							goto IL_218E;
						case 37:
						{
							string text6;
							text3 = text6;
							num = (short)1645674496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 38:
							if (this.f != null)
							{
								num = (short)662700066;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_55E;
						case 39:
							if (!string.IsNullOrEmpty(text2))
							{
								num = (short)1464467482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_277A;
						case 40:
							if (!this.h)
							{
								num = (short)751042622;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)431489217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
							this.BeginFlashUpgrade();
							num = (short)1741947032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
							if (this.f != null)
							{
								num = (short)1476001804;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D32;
						case 43:
							if (this.f != null)
							{
								num = (short)120062074;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1AFA;
						case 44:
							if (this.r)
							{
								num = (short)991952926;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_214E;
						case 45:
							num = (short)1967915026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
							goto IL_F08;
						case 47:
							goto IL_1D32;
						case 48:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker6 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker6.ReportProgress(num3, global::CommonResources.AppResources.Packing_The_Radio_Codeplug_Suspension_Points);
							num = (short)978649141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 49:
							goto IL_7BC;
						case 50:
							goto IL_1F17;
						case 51:
							num = (short)736296993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
							num = (short)1996882112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 53:
							goto IL_2312;
						case 54:
							num = (short)733544574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 55:
							this.e = new global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager();
							num = (short)63570057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 56:
							if (global::ConstraintHelper.UtilityMack.IsPortable())
							{
								num = (short)1898119185;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_218E;
						case 57:
							if (!this.h)
							{
								num = (short)30539930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text3 = global::CommonResources.AppResources.Refresh_Completed_Successfully_Exception_OE_No_OE_SW;
							num = (short)1977745511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 58:
							num = (short)851509263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 59:
							if (!this.h)
							{
								num = (short)629669989;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text3 = global::CommonResources.AppResources.Refresh_Completed_Successfully_Exception_OE_No_OE_SW;
							num = (short)912064642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 60:
							if (this.f != null)
							{
								num = (short)1710227663;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_773;
						case 61:
							goto IL_1E20;
						case 62:
							num = (short)933888176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 63:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_1177;
								}
								for (;;)
								{
									IL_1158:
									switch (num2)
									{
									case 0:
										goto IL_120E;
									case 1:
										goto IL_1227;
									case 2:
										if (empty.Equals(global::CommonResources.AppResources.LP_Write_Radio_After_Flashport_To_Update_Language_Pack))
										{
											num = (short)667811843;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_120E;
									case 3:
										text2 = empty;
										num = (short)704380928;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (this.f != null)
										{
											num = (short)520224773;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_120E;
									case 5:
										num = (short)368574466;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1177;
									IL_120E:
									num = (short)1386414081;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1227:
								goto IL_49A;
								IL_1177:
								this.a(ref empty);
								num = (short)2080309252;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1158;
							}
							catch (global::System.Exception)
							{
								if (this.f != null)
								{
									global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState8 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentError, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.LP_Error_Updating_Language_Pack);
									this.f.ReportProgress(this.n, userState8);
								}
								throw;
							}
							goto IL_125E;
							IL_49A:
							this.n = 32;
							num = (short)1070989481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 64:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker7 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker7.ReportProgress(num3, global::CommonResources.AppResources.UpgradeRadio_Ucd);
							num = (short)1719795828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 65:
							if (!this.h)
							{
								num = (short)259129398;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D47;
						case 66:
							radioCodeplug = this.ReadCodeplug();
							num = (short)1605959866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 67:
							num = (short)788201660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 68:
							goto IL_A69;
						case 69:
							goto IL_773;
						case 70:
							this.h();
							num = (short)480510036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 71:
							if (!this.h)
							{
								num = (short)329187515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_125E;
						case 72:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState9 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Flashing_radio_software);
							global::System.ComponentModel.BackgroundWorker backgroundWorker8 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker8.ReportProgress(num3, userState9);
							num = (short)1457127567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 73:
							goto IL_25E9;
						case 74:
							goto IL_24DA;
						case 75:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker9 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker9.ReportProgress(num3);
							num = (short)1818951754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 76:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker10 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker10.ReportProgress(num3, global::CommonResources.AppResources.Upgrading_codeplug);
							num = (short)830603355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 77:
							num = (short)101974222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 78:
							if (!this.i)
							{
								num = (short)960233675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E20;
						case 79:
							goto IL_2629;
						case 80:
							goto IL_1361;
						case 81:
							if (this.g != null)
							{
								num = (short)1328939113;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19C2;
						case 82:
							num = (short)1899954385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 83:
							this.t = true;
							num = (short)1305739472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 84:
							goto IL_1A8D;
						case 85:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker11 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker11.ReportProgress(num3);
							num = (short)2000814129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 86:
							if (!this.h)
							{
								num = (short)605225066;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D7B;
						case 87:
							goto IL_DD6;
						case 88:
							goto IL_1DBB;
						case 89:
							text = this.c;
							num = (short)1866989675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 90:
							goto IL_1F12;
						case 91:
							goto IL_FB5;
						case 92:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker12 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker12.ReportProgress(num3);
							num = (short)1027801234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 93:
							goto IL_2794;
						case 94:
							goto IL_218E;
						case 95:
							goto IL_19C2;
						case 96:
							goto IL_277A;
						case 97:
							this.f();
							num = (short)1136852999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 98:
							if (this.f != null)
							{
								num = (short)2090926155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24DA;
						case 99:
						{
							bool flag7 = true;
							num = (short)746913865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 100:
							goto IL_C3F;
						case 101:
							text3 = global::CommonResources.AppResources.Upgrade_Completed_Successfully_Exception_OE_No_OE_SW;
							num = (short)589561892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 102:
							if (!this.h)
							{
								num = (short)1715732550;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A8D;
						case 103:
							goto IL_218E;
						case 104:
						{
							bool flag5;
							bool flag7;
							if (flag5 && flag7)
							{
								num = (short)2032402514;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1599078427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 105:
							this.g.MaxSteps = 65;
							this.g.CurrentStep = this.n;
							num = (short)1369636959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 106:
							num = (short)1945108627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 107:
							goto IL_8D2;
						case 108:
							num = (short)2026569873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 109:
							if (!this.h)
							{
								num = (short)802750516;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19E0;
						case 110:
							goto IL_66A;
						case 111:
						{
							bool flag6;
							if (flashCodeplug.UpgradeCodeplug(this.a, text, flag6, true, null))
							{
								num = (short)861536380;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_553;
						}
						case 112:
							if (this.f != null)
							{
								num = (short)1756299437;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1DBB;
						case 113:
							goto IL_FB0;
						case 114:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker13 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker13.ReportProgress(num3, global::CommonResources.AppResources.Unpacking_the_radio_codeplug);
							num = (short)1877934215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 115:
							if (!this.h)
							{
								num = (short)1656619040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text3 = global::CommonResources.AppResources.Refresh_Completed_Successfully_Exception_AB_No_AB_SW;
							num = (short)570163338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 116:
							goto IL_1CBB;
						case 117:
							if (!this.h)
							{
								num = (short)532742166;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_161C;
						case 118:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker14 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker14.ReportProgress(num3);
							num = (short)386662500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 119:
							if (!this.k.OptBrdHwNotPresentFlag)
							{
								num = (short)473301059;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_218E;
						case 120:
							if (this.f != null)
							{
								num = (short)1807745138;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2219;
						case 121:
							goto IL_17BA;
						case 122:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState10 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.CodeplugDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Validating_user_parameters);
							global::System.ComponentModel.BackgroundWorker backgroundWorker15 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker15.ReportProgress(num3, userState10);
							num = (short)1657471129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 123:
							goto IL_153D;
						case 124:
							flag = true;
							num = (short)781844505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 125:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState11 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FinalValidationDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Validation_Complete);
							this.f.ReportProgress(100, userState11);
							num = (short)1395327133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 126:
							if ((int)this.e.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesRemaining) <= 0)
							{
								num = (short)1779826690;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D47;
						case 127:
							if (!this.t)
							{
								num = (short)576520195;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_218E;
						case 128:
						{
							string str = string.Format(global::CommonResources.AppResources.FLASHport_FCC_Warning, '\n');
							string text4 = text3 + str;
							num = (short)1624637453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 129:
							if (!this.aa)
							{
								num = (short)784597058;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							radioCodeplug = this.ReadTestCodeplug();
							num = (short)267255980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 130:
							goto IL_218E;
						case 131:
							if (!this.e.ValidateKey())
							{
								num = (short)1152385114;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_125E;
						case 132:
						{
							bool flag6;
							if (flag6)
							{
								num = (short)145686641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1414987781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 133:
							if (this.h)
							{
								num = (short)960299116;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DD6;
						case 134:
							text = (string)this.e.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeNew);
							num = (short)863633518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 135:
							goto IL_2219;
						case 136:
							try
							{
								num = (short)254410754;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_20CD;
									case 1:
										this.c(a_);
										num = (short)261619716;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2055;
										}
										continue;
									case 3:
										goto IL_20B4;
									case 4:
										goto IL_20B4;
									}
									IL_2055:
									if (!this.aa)
									{
										num = (short)139001857;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.b(a_);
									num = (short)1655046147;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_20B4:
									num = (short)1011941376;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_20CD:
								goto IL_6D8;
							}
							catch (global::System.Exception)
							{
								if (this.f != null)
								{
									num = (short)1815756125;
									short num4 = num;
									num = (short)1683897693;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)379453440;
										if (num != 0)
										{
										}
										break;
									}
									global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState12 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentError, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Flashing_radio_software);
									this.f.ReportProgress(this.n, userState12);
								}
								throw;
							}
							goto IL_214E;
							IL_6D8:
							this.n = 98;
							num = (short)1204420776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 137:
							goto IL_2363;
						case 138:
							goto IL_218E;
						case 139:
						{
							string text6;
							if (!string.IsNullOrEmpty(text6))
							{
								num = (short)690618405;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_214E;
						}
						case 140:
							if (this.k.RadioBBFSuiteVersion != null)
							{
								num = (short)87425107;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D02;
						case 141:
							if (!string.IsNullOrEmpty(this.k.OptBrdHardwareType))
							{
								num = (short)278003906;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E20;
						case 142:
							goto IL_1469;
						case 143:
							goto IL_BFE;
						case 144:
							if (!this.h)
							{
								num = (short)496107528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BBE;
						case 145:
							if (!flag4)
							{
								num = (short)364838970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DD6;
						case 146:
							goto IL_1321;
						case 147:
							if (!this.e.FindFlashkey(this.a, this.c, global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindExactMatch))
							{
								num = (short)1628242100;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D7B;
						case 148:
							if (this.g != null)
							{
								num = (short)1254948899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_26DD;
						case 149:
							if (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioValidator.IsCPSVersionLowerThanFirmwareUpgradeVersion(this.fileHostVersion, global::AcpCommonLib.AppInfoManager.AppVersion))
							{
								num = (short)1097138244;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)873594945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 150:
							text3 = global::CommonResources.AppResources.Upgrade_Completed_Successfully_Exception_AB_OE_No_SW;
							num = (short)73990175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 151:
							if (text == string.Empty)
							{
								num = (short)147325017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8D2;
						case 152:
							goto IL_2565;
						case 153:
							goto IL_1AFA;
						case 154:
							text3 = global::CommonResources.AppResources.Upgrade_Completed_Successfully_Exception_OE_No_OE_SW;
							num = (short)301859016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 155:
							num = (short)2100101309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 156:
							if (!this.h)
							{
								num = (short)329908358;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_66A;
						case 157:
							goto IL_CBE;
						case 158:
							if (!this.aa)
							{
								num = (short)1541406895;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1542;
						case 159:
							if (this.f != null)
							{
								num = (short)1575682120;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_BFE;
						case 160:
							goto IL_218E;
						case 161:
							num = (short)327942259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 162:
						{
							string text4;
							text3 = text4;
							num = (short)1662648334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 163:
							if (this.f != null)
							{
								num = (short)729678020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A19;
						case 164:
							this.i();
							num = (short)1452277961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 165:
							goto IL_A6E;
						case 166:
							try
							{
								modelTiering.UpdateUtilityMackModelType();
								goto IL_23A5;
							}
							finally
							{
								num = (short)1479278592;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1B83;
										}
										continue;
									case 1:
										((global::System.IDisposable)modelTiering).Dispose();
										num = (short)551092226;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_1BBB;
									}
									IL_1B83:
									if (modelTiering == null)
									{
										break;
									}
									num = (short)1805254657;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1BBB:;
							}
							goto IL_1BBE;
							IL_23A5:
							this.g();
							num = (short)199098410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 167:
							if (!this.aa)
							{
								num = (short)1050607801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A6E;
						case 168:
							if (this.f != null)
							{
								num = (short)260046859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1469;
						case 169:
							goto IL_10CB;
						case 170:
							if (!this.h)
							{
								num = (short)724041883;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1427;
						case 171:
							goto IL_26DD;
						case 172:
							goto IL_1FAE;
						case 173:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState13 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FinalValidationStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Validating_Update);
							global::System.ComponentModel.BackgroundWorker backgroundWorker16 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker16.ReportProgress(num3, userState13);
							num = (short)733872216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 174:
							goto IL_13FF;
						case 175:
							try
							{
								this.k();
								goto IL_1542;
							}
							catch (global::System.Exception)
							{
								if (this.f != null)
								{
									global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState14 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FinalValidationError, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, "");
									this.f.ReportProgress(this.n, userState14);
								}
								throw;
							}
							goto IL_185E;
						case 176:
							flag8 = !flag4;
							goto IL_13E0;
						case 177:
							goto IL_A19;
						case 178:
							if (this.f != null)
							{
								num = (short)121372764;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1321;
						case 179:
							goto IL_55E;
						case 180:
							goto IL_EB5;
						case 181:
							num = (short)728629258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 182:
							if (global::ConstraintHelper.UtilityMack.IsMobile())
							{
								num = (short)356253898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)559677496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 183:
							goto IL_1BBE;
						case 184:
							if (this.f != null)
							{
								num = (short)1708195849;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1361;
						case 185:
							this.Connect();
							num = (short)1859387557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 186:
							goto IL_1FAE;
						case 187:
							num = (short)1335623811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 188:
							if (!this.i)
							{
								num = (short)1665728532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_218E;
						case 189:
							if (!this.e.ValidateKey())
							{
								num = (short)1422393465;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1427;
						case 190:
							if (!this.h)
							{
								num = (short)55574692;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AF4;
						case 191:
							if (this.f != null)
							{
								num = (short)69009533;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CBE;
						case 192:
							if (flag2 || flag)
							{
								num = (short)725352545;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19E0;
						case 193:
							flag8 = false;
							goto IL_13E0;
						case 194:
							num = (short)1297743950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 195:
							if (this.f != null)
							{
								num = (short)154927222;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C3F;
						case 196:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker17 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker17.ReportProgress(num3);
							num = (short)1172308145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 197:
							if (!this.aa)
							{
								num = (short)1993408553;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2565;
						case 198:
							if (!this.h)
							{
								num = (short)1530265781;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_185E;
						case 199:
							if (this.f != null)
							{
								num = (short)1361248320;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CBB;
						case 200:
							goto IL_218E;
						case 201:
							goto IL_AF4;
						case 202:
							num = (short)478085261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 203:
						{
							bool flag5 = true;
							num = (short)1054081085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 204:
							if (this.g != null)
							{
								num = (short)2067464216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F08;
						case 205:
							if (this.r)
							{
								num = (short)2146697261;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10CB;
						case 206:
							if (this.a(this.c, text))
							{
								num = (short)1733820544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_271F;
						case 207:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState15 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.CodeplugStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Reading_the_radio_codeplug_);
							global::System.ComponentModel.BackgroundWorker backgroundWorker18 = this.f;
							int num3 = this.n;
							this.n = num3 + 1;
							backgroundWorker18.ReportProgress(num3, userState15);
							num = (short)1215430725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 208:
							goto IL_1D02;
						case 209:
							if (!this.h)
							{
								num = (short)1106116758;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text3 = global::CommonResources.AppResources.Refresh_Completed_Successfully_Exception_AB_OE_No_SW;
							num = (short)1675952222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 210:
							if (this.f != null)
							{
								num = (short)308674589;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_277A;
						case 211:
							if (this.f != null)
							{
								num = (short)1465319509;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7BC;
						case 212:
							if (this.f != null)
							{
								num = (short)1800536112;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2312;
						}
						goto IL_3CA;
						IL_55E:
						num = (short)1985413287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_66A:
						num = (short)159055989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_773:
						this.n = 10;
						num = (short)318832788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7BC:
						num = (short)954859622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8D2:
						this.RadioHostVersion = this.k.HostVersion;
						this.PostUpgradeCodeplugHandler(text);
						global::SpecialFeatures.ReadWriteTlsPsk.ReadWriteTlsPskHelper.SetTlsPskFromCodeplugPassword();
						this.ApplyModelTiering();
						global::AcpCommonLib.ConstraintManager.Suspend();
						postFlashCodeplugFields = null;
						num = (short)483852304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A19:
						flag4 = this.a(ref flag3);
						num = (short)1541931157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A6E:
						num = (short)629014712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_AF4:
						num = (short)1696989395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_BFE:
						num = (short)1929969745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C3F:
						num = (short)1084096702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_CBE:
						num = (short)933953746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D47:
						num = (short)1217396834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DD6:
						num = (short)1421541416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_F08:
						num = (short)1063649343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_FB5:
						num = (short)1574240367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_10CB:
						num = (short)719913119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_125E:
						num = (short)396034243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1321:
						num = (short)1642987606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1361:
						num = (short)306905285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_13E0:
						if (flag8 && flag3)
						{
							num = (short)1540292782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2036793500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1427:
						num = (short)1865351277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1469:
						num = (short)2130772138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1542:
						num = (short)1128857791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_161C:
						num = (short)918814919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_185E:
						num = (short)2045640909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_19C2:
						num = (short)192413832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_19E0:
						num = (short)869793904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A8D:
						num = (short)1568735292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1AFA:
						num = (short)1601568966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BBE:
						num = (short)1340539007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1CBB:
						num = (short)397344919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D02:
						modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(this.a, "");
						num = (short)1695088806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D32:
						this.b(upgradeFile);
						num = (short)79757318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D7B:
						num = (short)761397411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1DBB:
						num = (short)1592000670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E20:
						num = (short)853803012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F17:
						flashCodeplug.SetPostFlashCodeplugFields(postFlashCodeplugFields);
						this.a();
						num = (short)1556218068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1FAE:
						this.n = 18;
						num = (short)1263861880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_214E:
						num = (short)1517682707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_218E:
						num = (short)703004716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2219:
						this.UnpackCodeplug(radioCodeplug);
						flashCodeplug = new global::SpecialFeatures.Flashport.FlashRadio.FlashCodeplug();
						flashCodeplug.postCodeplugInitialization();
						this.PreUpgradeCodeplugHandler();
						this.SetRequiredFirmwareVersionField();
						global::SpecialFeatures.LastSetJobUuidHelper.SetLastSetJobUuidField(null);
						((global::AcpBusinessLayer.AcpDocument)global::AcpCommonLib.FeatureManager.ActiveDocument).Initialized(true);
						num = (short)48824453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2312:
						a_ = this.d();
						this.n = 23;
						num = (short)1722941483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2363:
						num = (short)1190265010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_24DA:
						num = (short)1733951559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2565:
						num = (short)425197708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_25E9:
						num = (short)690028648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2629:
						num = (short)1693909196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_26DD:
						num = (short)1187119233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_271F:
						global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState16 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FinalValidationDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, text3);
						this.f.ReportProgress(100, userState16);
						num = (short)1725169703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_277A:
						num = (short)787284061;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_553:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Codeplug_upgrade_failed);
					IL_A69:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_Flash_radio_Need_Latest_CPS);
					IL_BF9:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.There_are_no_upgrades_left_on_the_FLASHkey);
					IL_EB5:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_find_a_valid_FLASHkey_for_this_radio);
					IL_FB0:
					throw new global::System.NotImplementedException(global::CommonResources.AppResources.Model_Number_Upgrades);
					IL_13FF:
					goto IL_1926;
					IL_153D:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.FLASHkey_Validation_failed);
					IL_17BA:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.FLASHkey_Validation_failed);
					IL_1926:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.The_version_of_software);
					IL_1F12:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.FLASHkey_Validation_failed);
					IL_2794:
					goto IL_285E;
					IL_3CA:
					global::AcpCommonLib.AppInfoManager.DragOperation = true;
					num = (short)1763377190;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_6F;
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Communication_with_radio_failed_Please_cycle_radio_power_and_check_connections);
				}
				catch (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException)
				{
					throw;
				}
				catch (global::System.Exception ex)
				{
					if (ex.Message != null)
					{
						throw;
					}
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Communication_with_radio_failed_Please_cycle_radio_power_and_check_connections);
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_27DB;
					}
					for (;;)
					{
						IL_27C8:
						switch (num2)
						{
						case 0:
							if (this.l != null)
							{
								num = (short)1179451393;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_285D;
						case 1:
							this.l.Dispose();
							this.l = null;
							num = (short)383385602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_285B;
						}
						goto IL_27DB;
					}
					IL_285B:
					IL_285D:
					goto EndFinally_104;
					IL_27DB:
					global::AcpCommonLib.AppInfoManager.DragOperation = false;
					this.a(this.o);
					this.a(this.p);
					num = (short)1483014144;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27C8;
					EndFinally_104:;
				}
				IL_285E:
				num = (short)1765015552;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0011EC14 File Offset: 0x0011CE14
		public void PreUpgradeCodeplugHandler()
		{
			short num = (short)226981637;
			short num2 = num;
			num = (short)1061058309;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1056636928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)893190144;
			if (num != 0)
			{
			}
			num = (short)811532289;
			if (num != 0)
			{
			}
			this.SetProductModelIdentifierField();
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0011ECC4 File Offset: 0x0011CEC4
		public void SetDeviceInfoField()
		{
			int a_ = 2;
			short num;
			try
			{
				num = (short)898301953;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string radInfoOptionExpansionBoardBoardType_A37049Value;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					switch (num2)
					{
					case 0:
					{
						num = (short)1754430162;
						short num3 = num;
						num = (short)1568438994;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_24C;
						default:
							num = (short)1274413056;
							if (num != 0)
							{
							}
							if (!string.IsNullOrEmpty(radInfoOptionExpansionBoardBoardType_A37049Value))
							{
								num = (short)746258435;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_478;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_8E;
						}
						continue;
					case 2:
						goto IL_ED;
					case 3:
						num = (short)787152903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!string.IsNullOrEmpty(this.x.OptBrdHwHostVersion))
						{
							num = (short)1383464965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_478;
					case 5:
						radioInformation.OptionExpansionBoard.RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048.SetValue(this.x.OptBrdHwHostVersion);
						num = (short)554172432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_182;
					case 7:
						if (radInfoOptionExpansionBoardBoardType_A37049Value == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즄펆첈", a_))
						{
							num = (short)975634454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_339;
					case 8:
						goto IL_42E;
					case 9:
						radioInformation.General.RadInfoGeneralPSDTVersion_A8768.SetValue(this.x.PsdtVersion);
						num = (short)1015939074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						radioInformation.OptionExpansionBoard.RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048.SetValue(this.x.LTEOptBrdHwHostVersion);
						num = (short)660799505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)459603972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!string.IsNullOrEmpty(this.x.MaceFlashVersion))
						{
							num = (short)1224605716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42E;
					case 13:
						radioInformation.General.RadInfoGeneralDSPVersion_A7892.SetValue(this.x.DspVersion);
						num = (short)279314438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!string.IsNullOrEmpty(this.x.DspVersion))
						{
							num = (short)428408845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					case 15:
						if (!string.IsNullOrEmpty(this.x.LTEOptBrdHwHostVersion))
						{
							num = (short)729808906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_339;
					case 16:
						goto IL_478;
					case 17:
						goto IL_478;
					case 18:
						if (radInfoOptionExpansionBoardBoardType_A37049Value != global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즄펆첈", a_))
						{
							num = (short)1783693323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_478;
					case 19:
						radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
						num = (short)1186529294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						radioInformation.General.RadInfoGeneralUCMVersion_A9591.SetValue(this.x.MaceFlashVersion);
						num = (short)1945763848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_490;
					case 22:
						goto IL_24C;
					case 23:
						if (!string.IsNullOrEmpty(this.x.PsdtVersion))
						{
							num = (short)562757641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					}
					IL_8E:
					if (this.x != null)
					{
						num = (short)252968979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_478;
					IL_ED:
					radInfoOptionExpansionBoardBoardType_A37049Value = radioInformation.OptionExpansionBoard.RadInfoOptionExpansionBoardBoardType_A37049Value;
					num = (short)588316672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_182:
					num = (short)1946615820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24C:
					num = (short)939327503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_339:
					num = (short)1081671698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42E:
					num = (short)1564737559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_478:
					num = (short)793640981;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_490:;
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1901068288;
			short num4 = num;
			num = (short)202571777;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0011F1D4 File Offset: 0x0011D3D4
		public void PostUpgradeCodeplugHandler(string newFlashCode)
		{
			short num = (short)1720562176;
			short num2 = num;
			num = (short)631616000;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1740046336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)641597441;
			if (num != 0)
			{
			}
			num = (short)1078001664;
			if (num != 0)
			{
			}
			this.SetCodeplugFields(newFlashCode);
			this.r();
			this.q();
			this.p();
			this.y();
			this.b(this.fileHostVersion, newFlashCode);
			this.SetActionTypeAfterUpgrade();
			this.SyncActiveMicForBTPTT();
			this.RefreshAESFields();
			this.n();
			this.x();
			this.u();
			this.w();
			this.v();
			this.o();
			global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio.SetWindNoiseReductionLevelForAccessories();
			this.aa();
			this.z();
			this.ad();
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0011F2F4 File Offset: 0x0011D4F4
		private void ad()
		{
			int a_ = 15;
			short num = (short)151453696;
			switch (num)
			{
			default:
			{
				num = (short)2120024066;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpBusinessLayer.AcpFieldX<string, string> acpFieldX;
				string value;
				string value2;
				for (;;)
				{
					bool? flag2;
					global::AcpBusinessLayer.AcpFieldX<string, string> acpFieldX2;
					switch (num2)
					{
					case 0:
					{
						num = (short)1137107974;
						short num3 = num;
						num = (short)1818682374;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11E;
						default:
							goto IL_28D;
						}
						break;
					}
					case 1:
					{
						if (acpFieldX == null)
						{
							num = (short)1757609988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊑ꒓", a_);
						value2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊑꖓ", a_);
						bool? flag = flag2;
						bool flag3 = true;
						num = (short)1150746627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 3:
					{
						bool? flag;
						bool flag3;
						if (flag.GetValueOrDefault() == flag3 & flag != null)
						{
							num = (short)390791168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AC;
					}
					case 4:
						return;
					case 5:
						num = (short)113442817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						acpFieldX2 = null;
						goto IL_179;
					case 7:
						if (flag2 != null)
						{
							num = (short)1364328453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						goto IL_11E;
					}
					IL_72:
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
					bool? flag4;
					if (radioInformation == null)
					{
						bool? flag = null;
						flag4 = flag;
					}
					else
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = radioInformation.Labtool;
						if (labtool == null)
						{
							bool? flag = null;
							flag4 = flag;
						}
						else
						{
							global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_ = labtool.RadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771;
							if (radInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_ == null)
							{
								bool? flag = null;
								flag4 = flag;
							}
							else
							{
								flag4 = new bool?(radInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_.Value);
							}
						}
					}
					flag2 = flag4;
					if (radioInformation == null)
					{
						num = (short)2034237446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general = radioInformation.General;
					if (general == null)
					{
						num = (short)907083784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					acpFieldX2 = general.RadInfoGeneralWiFiRegulatoryRegion_A43772;
					IL_179:
					acpFieldX = acpFieldX2;
					num = (short)470745095;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11E:
					num = (short)1971388417;
					if (num != 0)
					{
					}
					num = (short)1132855296;
					short num4 = num;
					acpFieldX2 = null;
					goto IL_179;
				}
				return;
				IL_28D:
				num = (short)2043478016;
				if (num != 0)
				{
				}
				acpFieldX.Value = value2;
				return;
				IL_2AC:
				acpFieldX.Value = value;
				return;
			}
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0011F5B4 File Offset: 0x0011D7B4
		private global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles ac()
		{
			short num = (short)1711693913;
			short num2 = num;
			num = (short)1693409369;
			switch (num2 == num)
			{
			}
			num = (short)18939904;
			short num3 = num;
			num = (short)1685585921;
			if (num != 0)
			{
			}
			num = (short)516423680;
			if (num != 0)
			{
			}
			return global::AcpCommonLib.FeatureManager.GetFeature(2075)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0011F674 File Offset: 0x0011D874
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles ab()
		{
			short num = (short)664690485;
			short num2 = num;
			num = (short)1525505845;
			switch (num2 == num)
			{
			}
			num = (short)1202978816;
			short num3 = num;
			num = (short)2029584385;
			if (num != 0)
			{
			}
			num = (short)67502080;
			if (num != 0)
			{
			}
			return global::AcpCommonLib.FeatureManager.GetFeature(2076)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0011F734 File Offset: 0x0011D934
		private void aa()
		{
			short num = (short)1215868385;
			short num2 = num;
			num = (short)1689431521;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)843644929;
				if (num != 0)
				{
				}
				num = (short)1897332736;
				if (num != 0)
				{
				}
				num = (short)2011037698;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.ac().General.CnvEmerProfGeneralTxPeriodsec2_A43600.SetValue(this.ac().General.CnvEmerProfGeneralTxPeriodsec1_A8212 * 10);
						num = (short)2127298561;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_106;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					}
					IL_A1:
					if (this.ac() == null)
					{
						return;
					}
					num = (short)946077696;
					num3 = (int)((global::System.IntPtr)num);
				}
				break;
			}
			}
			IL_106:
			num = (short)1127612416;
			short num4 = num;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0011F874 File Offset: 0x0011DA74
		private void z()
		{
			short num = (short)1643601276;
			short num2 = num;
			num = (short)796286332;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1715601408;
				if (num != 0)
				{
				}
				num = (short)1522270210;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.ab().General.TrkEmerProfGeneralTxPeriodsec2_A43601.SetValue(this.ab().General.TrkEmerProfGeneralTxPeriodsec1_A7939 * 10);
						num = (short)2017460225;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_102;
					case 2:
						num = (short)1503068161;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						continue;
					}
					IL_A0:
					if (this.ab() == null)
					{
						return;
					}
					num = (short)1450508288;
					num3 = (int)((global::System.IntPtr)num);
				}
				break;
			}
			}
			IL_102:
			num = (short)584581120;
			short num4 = num;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0011F9B0 File Offset: 0x0011DBB0
		private void y()
		{
			int a_ = 8;
			short num = (short)1095761920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C6;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				int value;
				for (;;)
				{
					IL_32:
					num = (short)1596912899;
					short num3 = num;
					num = (short)1875178755;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)646578176;
						if (num != 0)
						{
						}
						bool flag;
						object obj;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset txPowerLevelsByFrequencyRangeInnerRecset;
						bool flag2;
						switch (num2)
						{
						case 0:
						{
							global::SpecialFeatures.Comms.Util.HostVersion hostVersion;
							flag = hostVersion.EqualTo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊벌뢎뾐ꊒꖔ릖ꦘꮚ", a_));
							goto IL_230;
						}
						case 1:
							if (radioInformation == null)
							{
								num = (short)440270854;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)304742414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							obj = null;
							goto IL_336;
						case 3:
							if (txPowerLevelsByFrequencyRangeInnerRecset == null)
							{
								goto IL_359;
							}
							num = (short)1682505737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							return;
						case 5:
							if (flag2)
							{
								num = (short)313458699;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2AA;
						case 6:
							return;
						case 7:
						{
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10103];
							if (acpFeatureSection == null)
							{
								num = (short)271908866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							obj = acpFeatureSection.EmbeddedRecset;
							goto IL_336;
						}
						case 8:
							num = (short)1203634176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							acpFeatureNode = txPowerLevelsByFrequencyRangeInnerRecset[3];
							if (acpFeatureNode == null)
							{
								num = (short)293994508;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3B6;
						case 10:
							return;
						case 11:
							value = 96000000;
							num = (short)330039309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_3B3;
						case 13:
							goto IL_2AA;
						case 14:
						{
							if (!radioInformation.FrequencyRanges.RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Value)
							{
								num = (short)1484652554;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							value = 94000000;
							global::SpecialFeatures.Comms.Util.HostVersion hostVersion = global::SpecialFeatures.Comms.Util.HostVersion.Parse(this.fileHostVersion);
							num = (short)1712128016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							flag = true;
							goto IL_230;
						case 16:
						{
							global::SpecialFeatures.Comms.Util.HostVersion hostVersion;
							if (!hostVersion.GreaterThan(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊벌뢎뾐ꊒꖔ릖ꦘꮚ", a_)))
							{
								num = (short)2043805704;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)714539009;
							if (num != 0)
							{
							}
							num = (short)612630543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_C6;
						IL_230:
						flag2 = flag;
						radioInformation.FrequencyRanges.RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Value = flag2;
						radioInformation.FrequencyRanges.RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Value = flag2;
						num = (short)911212549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2AA:
						num = (short)1516765184;
						short num4 = num;
						num = (short)780075015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_336:
						txPowerLevelsByFrequencyRangeInnerRecset = (obj as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset);
						num = (short)1410269187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_359:
					num = (short)89980932;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3B3:
				object obj2 = null;
				goto IL_3C2;
				IL_3B6:
				obj2 = acpFeatureNode[10104];
				IL_3C2:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection = obj2 as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection;
				if (txPowerLevelsByFrequencyRangeInnerSection == null)
				{
					return;
				}
				txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(value);
				return;
				IL_C6:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)142409729;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0011FD98 File Offset: 0x0011DF98
		private void x()
		{
			int a_ = 19;
			short num = (short)1547698176;
			switch (num)
			{
			default:
			{
				num = (short)1864368130;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
					switch (num2)
					{
					case 0:
					{
						num = (short)392560640;
						short num3 = num;
						try
						{
							num = (short)1658978305;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
								int num4;
								switch (num2)
								{
								case 0:
									radioProfiles.AudioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386Value = true;
									num = (short)818151432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_EF;
									}
									continue;
								case 2:
									if (num4.Equals(3))
									{
										num = (short)1638531082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1D6;
								case 3:
									if (num4.Equals(3))
									{
										num = (short)1461387264;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_14E;
								case 5:
								{
									string text;
									string text2;
									if (text != text2)
									{
										num = (short)1396441094;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1D6;
								}
								case 6:
									radioProfiles.AudioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382Value = true;
									num = (short)1467285508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_2C7;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)398393355;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									radioProfiles = (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles)enumerator.Current;
									num4 = radioProfiles.AudioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292Value;
									num = (short)791019522;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									num = (short)648871941;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									num = (short)918458959;
									short num5 = num;
									num = (short)879333967;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_14E;
									default:
										num = (short)739311616;
										if (num != 0)
										{
										}
										num = (short)1599471623;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_F1:
								num = (short)2072510473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EF:
								goto IL_F1;
								IL_1D6:
								num4 = radioProfiles.AudioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291Value;
								num = (short)1324154883;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_14E:
								goto IL_1D6;
							}
							IL_2C7:
							goto IL_4B9;
						}
						finally
						{
							num = (short)1456340994;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)606404609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_335;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2FE;
									}
									continue;
								}
								IL_2FE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)610861056;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_335:;
						}
						goto IL_338;
					}
					case 1:
						num = (short)265617412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 3:
						goto IL_338;
					case 4:
					{
						int num6;
						int num7;
						if (num6 < num7)
						{
							num = (short)848363523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B9;
					}
					case 5:
					{
						int num8 = int.Parse(this.fileHostVersion.Substring(1, 2));
						int num7 = 13;
						string text = this.a.Substring(0, 3);
						string text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95궗ꎙ", a_);
						if (num8 >= num7)
						{
							num = (short)450297857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B9;
					}
					case 6:
					{
						int num6 = int.Parse(this.RadioHostVersion.Substring(1, 2));
						num = (short)334036997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)149159936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)1411514369;
						if (num != 0)
						{
						}
						if (radioProfilesRecset != null)
						{
							num = (short)1342177287;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B9;
					}
					IL_71:
					if (this.RadioHostVersion != null)
					{
						num = (short)646709254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_338:
					radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
					num = (short)1066991624;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4B9:
				this.m();
				return;
			}
			}
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00120280 File Offset: 0x0011E480
		private void w()
		{
			short num = (short)1074331648;
			switch (num)
			{
			default:
			{
				num = (short)978124802;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					switch (num2)
					{
					case 0:
					{
						num = (short)1987051520;
						short num3 = num;
						try
						{
							num = (short)1700921346;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_467;
								case 1:
									goto IL_411;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_D7;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = frequencyOptionsInnerRecset.GetEnumerator();
									num = (short)731250695;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									if (frequencyOptionsInnerRecset != null)
									{
										num = (short)151126019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									frequencyOptionsInnerRecset = (conventionalPersonality.Features.Parent[10148].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset);
									if (conventionalPersonality != null)
									{
										num = (short)624295937;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1165164552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1181286405;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									try
									{
										num = (short)2063204352;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_1F7;
												}
												continue;
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.SetValue(7);
												goto IL_2E1;
											}
											case 3:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Value == 0)
												{
													num = (short)1212547081;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1248395269;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner)enumerator.Current;
												num = (short)483196936;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												num = (short)1385686453;
												short num4 = num;
												num = (short)1529144757;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_2E1;
												default:
													num = (short)319160320;
													if (num != 0)
													{
													}
													num = (short)880869382;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
												goto IL_3A0;
											case 7:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Value)
												{
													num = (short)561774593;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 8:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												if (frequencyOptionsInner != null)
												{
													num = (short)960299018;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 9:
												num = (short)1192886279;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
												num = (short)2045771779;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_1F7;
											IL_2E1:
											num = (short)2100035586;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2FC:
											num = (short)1419902980;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1F7:
											goto IL_2FC;
										}
										IL_3A0:
										break;
									}
									finally
									{
										num = (short)2126118914;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)748093441;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_40E;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_3D7;
												}
												continue;
											}
											IL_3D7:
											if (enumerator == null)
											{
												break;
											}
											num = (short)830472192;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_40E:;
									}
									goto IL_411;
								case 8:
									num = (short)730464256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_DC:
								num = (short)1194852358;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D7:
								goto IL_DC;
								IL_411:
								num = (short)1093795844;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_467:
							return;
						}
						finally
						{
							num = (short)45678594;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)754843649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4D6;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_49E;
									}
									continue;
								}
								IL_49E:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)134610944;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4D6:;
						}
						goto IL_4D9;
					}
					case 1:
						num = (short)1256128516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_67;
						}
						continue;
					case 3:
						goto IL_4D9;
					case 4:
					{
						int num5;
						int num6;
						if (num5 < num6)
						{
							num = (short)686227459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
					{
						int num7 = int.Parse(this.fileHostVersion.Substring(1, 2));
						int num6 = 15;
						if (num7 >= num6)
						{
							num = (short)658374657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
					{
						int num5 = int.Parse(this.RadioHostVersion.Substring(1, 2));
						num = (short)1074724869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = conventionalPersonalityRecset.GetEnumerator();
						num = (short)619642881;
						if (num != 0)
						{
						}
						num = (short)56754176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1315241991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_67:
					if (this.RadioHostVersion != null)
					{
						num = (short)1984692230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_4D9:
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					frequencyOptionsInnerRecset = null;
					num = (short)540540936;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x001208FC File Offset: 0x0011EAFC
		private void v()
		{
			short num = (short)467468288;
			switch (num)
			{
			default:
			{
				num = (short)2000420872;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset toneSignalingListRecset;
					bool value;
					switch (num2)
					{
					case 0:
					{
						int num3 = int.Parse(this.RadioHostVersion.Substring(1, 2));
						num = (short)2020540422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (toneSignalingListRecset != null)
						{
							num = (short)468975619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						num = (short)1601830913;
						if (num != 0)
						{
						}
						int num3;
						int num4;
						if (num3 < num4)
						{
							num = (short)1087307783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
					{
						num = (short)956104704;
						short num5 = num;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = toneSignalingListRecset.GetEnumerator();
						num = (short)1588658180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						try
						{
							num = (short)672595978;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList;
									toneSignalingList.AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.SetValue(0);
									num = (short)1191182343;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1302659078;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (!value)
									{
										num = (short)1948647424;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2061500417;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList;
									num = (short)698941448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)794230793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1687617538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_229;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList;
									if (toneSignalingList != null)
									{
										num = (short)667156484;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList;
									if (toneSignalingList.AstroAlertingToneListExpander != null)
									{
										num = (short)1336934405;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									switch (0)
									{
									case 0:
										goto IL_E2;
									}
									continue;
								}
								IL_E4:
								num = (short)697106435;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E2:
								goto IL_E4;
							}
							IL_229:
							return;
						}
						finally
						{
							num = (short)1945960450;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2E4;
								case 1:
									enumerator.Dispose();
									num = (short)92602368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)1655944022;
									short num6 = num;
									num = (short)215659350;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)984875008;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_2AB;
										}
										continue;
									}
									break;
								}
								}
								IL_2AB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1465647105;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E4:;
						}
						goto IL_2E7;
					case 5:
						num = (short)51576834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						int num7 = int.Parse(this.fileHostVersion.Substring(1, 2));
						int num4 = 15;
						if (num7 >= num4)
						{
							num = (short)1237516293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
						goto IL_2E7;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					}
					IL_69:
					if (this.RadioHostVersion != null)
					{
						num = (short)1815412736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_2E7:
					value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolAstroAlertingOperHOption.Value;
					toneSignalingListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4156) as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset);
					num = (short)249430017;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00120D90 File Offset: 0x0011EF90
		private void u()
		{
			short num = (short)1023213568;
			switch (num)
			{
			default:
			{
				num = (short)1833762827;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)217448456;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
								switch (num2)
								{
								case 0:
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 != 4)
									{
										num = (short)1756037130;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D2;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1676804099;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									dataProfiles = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
									num = (short)1276313606;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)2124546053;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)2092826624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_405;
								case 6:
									if (dataProfiles.LTE.DataProfLTEEnabled_A42075.Value)
									{
										num = (short)1498546185;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									goto IL_2D2;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_24E;
									}
									continue;
								case 9:
									num = (short)897974284;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)687341579;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 == 2)
									{
										num = (short)302186503;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 12:
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 != 3)
									{
										num = (short)2011037700;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D2;
								}
								IL_290:
								num = (short)1864695809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_24E:
								goto IL_290;
								IL_2D2:
								dataProfiles.LTE.DataProfBroadbandSource_A42858.SetValue(1);
								num = (short)716963842;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_405:
							return;
						}
						finally
						{
							num = (short)123666434;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_4C1;
								case 1:
									enumerator.Dispose();
									num = (short)1914765312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)2109299941;
									short num3 = num;
									num = (short)1137925349;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)301727744;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_489;
										}
										continue;
									}
									break;
								}
								}
								IL_489:
								if (enumerator == null)
								{
									break;
								}
								num = (short)88473601;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4C1:;
						}
						goto IL_4C4;
					case 1:
					{
						int num4;
						int num5;
						if (num4 < num5)
						{
							num = (short)2109734921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
						if (dataProfilesRecset != null && flag)
						{
							num = (short)1680080899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)1358430208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)101711873;
						if (num != 0)
						{
						}
						int num4 = int.Parse(this.RadioHostVersion.Substring(1, 2));
						num = (short)1354825733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int num6 = int.Parse(this.fileHostVersion.Substring(1, 2));
						int num5 = 15;
						if (num6 >= num5)
						{
							num = (short)703660032;
							short num7 = num;
							num = (short)1990852616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
						if (radioInformation != null)
						{
							num = (short)1619329031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8;
					case 7:
						goto IL_4C4;
					case 8:
						num = (short)1859321857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset;
						flag = false;
						num = (short)2058616838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_E8;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_76;
						}
						continue;
					}
					IL_76:
					if (this.RadioHostVersion != null)
					{
						num = (short)1081278468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_E8:
					num = (short)39845890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C4:
					flag = radioInformation.Labtool.RadInfoLabtoolLTEOperation_A41923.Value;
					num = (short)252444682;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00121314 File Offset: 0x0011F514
		private void b(string A_0, string A_1)
		{
			short num = (short)1760821248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> list;
				global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)542638080;
						short num3 = num;
						try
						{
							num = (short)713621508;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_11B;
								case 1:
									num = (short)476905472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1898512385;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, bool> a_ = enumerator.Current;
									this.a(a_);
									num = (short)852099075;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_A2;
									}
									continue;
								}
								IL_A4:
								num = (short)840499202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A2:
								goto IL_A4;
							}
							IL_11B:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_12E;
					}
					case 1:
						if (list != null)
						{
							num = (short)945815554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_24E;
					case 3:
						try
						{
							list = modelTiering.GetPCIBitsToBeSet(A_0);
							goto IL_12E;
						}
						finally
						{
							num = (short)2133065730;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_24B;
								case 1:
									((global::System.IDisposable)modelTiering).Dispose();
									num = (short)1103757313;
									if (num != 0)
									{
									}
									num = (short)1828978688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)2020633428;
									short num4 = num;
									num = (short)568683348;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)1178009600;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_1F0;
										}
										continue;
									}
									break;
								}
								}
								IL_1F0:
								if (modelTiering == null)
								{
									break;
								}
								num = (short)914489345;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_24B:;
						}
						goto IL_24E;
					}
					goto IL_3E;
					IL_12E:
					num = (short)574226433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24E:
					enumerator = list.GetEnumerator();
					num = (short)122552320;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3E:
				list = null;
				modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(this.a, A_1);
				num = (short)1034485763;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x001215D8 File Offset: 0x0011F7D8
		public static bool checkPCIFieldsValue(string modelNumber, string upgradeFileVersion, string flashcode = "")
		{
			short num = (short)1823145984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)656605184;
				short num3 = num;
				num = (short)1845624833;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				bool result2;
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> list;
				global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
				for (;;)
				{
					IL_7B:
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_1C7;
					case 1:
						try
						{
							num = (short)1221525510;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.KeyValuePair<string, bool> keyValuePair;
									if (!global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio.b(keyValuePair.Key, true))
									{
										num = (short)1144979460;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_115;
								case 2:
									goto IL_1B7;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1477443589;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, bool> keyValuePair = enumerator.Current;
									num = (short)1525940224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									result = false;
									num = (short)2145386497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1752629250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_FA;
									}
									continue;
								}
								IL_163:
								num = (short)1215758339;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FA:
								goto IL_163;
							}
							IL_115:
							return result;
							IL_1B7:
							return result2;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1C7;
					case 2:
						if (list != null)
						{
							num = (short)1302265856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result2;
					case 3:
						try
						{
							list = modelTiering.GetPCIBitsToBeSet(upgradeFileVersion);
						}
						finally
						{
							num = (short)1884749826;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2AE;
								case 1:
									((global::System.IDisposable)modelTiering).Dispose();
									num = (short)865337344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)775549305;
									short num4 = num;
									num = (short)1773662585;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)549322752;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_277;
										}
										continue;
									}
									break;
								}
								}
								IL_277:
								if (modelTiering == null)
								{
									break;
								}
								num = (short)683409409;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2AE:;
						}
						num = (short)1849556994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_92;
					IL_1C7:
					enumerator = list.GetEnumerator();
					num = (short)754384897;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result2;
				IL_92:
				list = null;
				result2 = true;
				modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(modelNumber, flashcode);
				num = (short)245497859;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_7B;
			}
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00121908 File Offset: 0x0011FB08
		private void a(global::System.Collections.Generic.KeyValuePair<string, bool> A_0)
		{
			int a_ = 3;
			short num = (short)163577856;
			short num2 = num;
			num = (short)1265041408;
			switch (num)
			{
			default:
			{
				num = (short)1269366785;
				if (num != 0)
				{
				}
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
				try
				{
					num = (short)577175554;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)522780678;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
							num = (short)1954611204;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = acpRecordset[0].FeatureSectionsCollection.GetEnumerator();
							num = (short)1519124483;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C7;
							}
							continue;
						case 3:
							try
							{
								num = (short)692912129;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
									switch (num3)
									{
									case 0:
										num = (short)2012938249;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1D1;
										}
										continue;
									case 2:
										acpFeatureNode = acpFeatureSection.EmbeddedRecset[0];
										num = (short)487653381;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_8D8;
									case 4:
										goto IL_8F1;
									case 5:
										if (acpFeatureNode != null)
										{
											num = (short)12910599;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_69D;
									case 6:
										try
										{
											num = (short)20447235;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
												{
													if (!enumerator3.MoveNext())
													{
														num = (short)736296962;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpField acpField = enumerator3.Current;
													num = (short)320536585;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 1:
													goto IL_781;
												case 2:
													num = (short)21626884;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													switch (0)
													{
													case 0:
														goto IL_714;
													}
													continue;
												case 4:
													goto IL_864;
												case 5:
												{
													if (A_0.Value)
													{
														num = (short)794427398;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpField acpField;
													acpField.ParseValueFrom(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾋ", a_));
													num = (short)203554817;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
												{
													global::AcpCommonLib.IAcpField acpField;
													acpField.ParseValueFrom(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("慎ﾉ", a_));
													num = (short)2022309895;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 7:
													goto IL_808;
												case 8:
													num = (short)1103364101;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 9:
												{
													global::AcpCommonLib.IAcpField acpField;
													if (acpField.Name.Equals(A_0.Key))
													{
														num = (short)862126088;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												}
												IL_80D:
												num = (short)423821312;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_714:
												goto IL_80D;
											}
											IL_781:
											IL_808:
											return;
											IL_864:
											break;
										}
										finally
										{
											num = (short)1164247040;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_89C;
													}
													continue;
												case 1:
													goto IL_8D5;
												case 2:
													enumerator3.Dispose();
													num = (short)1095237633;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_89C:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)1421541378;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_8D5:;
										}
										goto IL_8D8;
									case 7:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator4 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
										num = (short)962985995;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1511849987;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureSection = enumerator2.Current;
										num = (short)1301872650;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										if (acpFeatureSection.HasEmbeddedRecset)
										{
											num = (short)156565506;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_69D;
									case 10:
										if (acpFeatureSection.EmbeddedRecset != null)
										{
											num = (short)1833828352;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_69D;
									case 11:
										try
										{
											num = (short)29556737;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator4;
												switch (num3)
												{
												case 0:
													if (!enumerator4.MoveNext())
													{
														num = (short)1627258884;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_593;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_347;
													}
													continue;
												case 2:
													try
													{
														num = (short)1719861251;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																goto IL_4D1;
															case 1:
															{
																global::AcpCommonLib.IAcpField acpField2;
																if (acpField2.Name.Equals(A_0.Key))
																{
																	num = (short)266141705;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 2:
																goto IL_504;
															case 3:
																switch (0)
																{
																case 0:
																	goto IL_3D3;
																}
																continue;
															case 4:
																goto IL_522;
															case 5:
															{
																if (A_0.Value)
																{
																	num = (short)306184198;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpCommonLib.IAcpField acpField2;
																acpField2.ParseValueFrom(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾋ", a_));
																num = (short)2071658498;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 6:
															{
																global::AcpCommonLib.IAcpField acpField2;
																acpField2.ParseValueFrom(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("慎ﾉ", a_));
																num = (short)231079936;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 7:
																num = (short)463601668;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 8:
															{
																if (!enumerator3.MoveNext())
																{
																	num = (short)1025179655;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpCommonLib.IAcpField acpField2 = enumerator3.Current;
																num = (short)2095251457;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 9:
																num = (short)574947333;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_469:
															num = (short)1281097736;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_3D3:
															goto IL_469;
														}
														IL_4D1:
														IL_504:
														return;
														IL_522:
														break;
													}
													finally
													{
														num = (short)1195769856;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_559;
																}
																continue;
															case 1:
																goto IL_590;
															case 2:
																enumerator3.Dispose();
																num = (short)1983315969;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_559:
															if (enumerator3 == null)
															{
																break;
															}
															num = (short)1927675906;
															num3 = (int)((global::System.IntPtr)num);
														}
														IL_590:;
													}
													goto IL_593;
												case 3:
													goto IL_5DB;
												case 4:
													num = (short)1180827651;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_349:
												num = (short)787218432;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_347:
												goto IL_349;
												IL_593:
												enumerator3 = enumerator4.Current.FieldsCollection.GetEnumerator();
												num = (short)429719554;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_5DB:;
										}
										finally
										{
											num = (short)1255604224;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator4;
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_613;
													}
													continue;
												case 1:
													goto IL_69A;
												case 2:
												{
													enumerator4.Dispose();
													num = (short)695246193;
													short num4 = num;
													num = (short)1202101617;
													switch ((num4 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														break;
													default:
														num = (short)1732378624;
														if (num != 0)
														{
														}
														num = (short)888799233;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												}
												IL_613:
												if (enumerator4 == null)
												{
													break;
												}
												num = (short)829554690;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_69A:;
										}
										goto IL_69D;
									}
									IL_219:
									num = (short)459997192;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1D1:
									goto IL_219;
									IL_69D:
									enumerator3 = acpFeatureSection.FieldsCollection.GetEnumerator();
									num = (short)888799238;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_8D8:
									num = (short)2028470276;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_8F1:
								break;
							}
							finally
							{
								num = (short)1396703232;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_929;
										}
										continue;
									case 1:
										goto IL_961;
									case 2:
										enumerator2.Dispose();
										num = (short)1433600001;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_929:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1248657410;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_961:;
							}
							goto IL_964;
						case 4:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							if (acpRecordset != null)
							{
								num = (short)1313144833;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_97D;
						case 6:
							goto IL_964;
						}
						IL_F9:
						num = (short)902430720;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C7:
						goto IL_F9;
						IL_964:
						num = (short)1503002629;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_97D:;
				}
				finally
				{
					num = (short)1673003008;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_9B1;
							}
							continue;
						case 1:
							goto IL_9E8;
						case 2:
							enumerator.Dispose();
							num = (short)226033665;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_9B1:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1266745346;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_9E8:;
				}
				return;
			}
			}
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0012237C File Offset: 0x0012057C
		private static bool b(string A_0, bool A_1)
		{
			short num = (short)1370554369;
			if (num != 0)
			{
			}
			num = (short)1671430144;
			switch (num)
			{
			default:
			{
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = null;
				bool result = true;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
				bool result2;
				try
				{
					num = (short)1955397634;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
							num = (short)604372998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (acpFeatureNode != null)
							{
								num = (short)596705280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A3;
							}
							continue;
						case 3:
							goto IL_90B;
						case 4:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							if (acpRecordset != null)
							{
								num = (short)1641873413;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							acpFeatureNode = acpRecordset[0];
							num = (short)1053818881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							try
							{
								num = (short)1736507393;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4;
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3 = acpFeatureNode2.FeatureSectionsCollection.GetEnumerator();
										num = (short)1450377224;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_13D;
										}
										continue;
									case 2:
										acpFeatureNode2 = acpFeatureSection.EmbeddedRecset[0];
										num = (short)1004666890;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										if (acpFeatureSection.EmbeddedRecset != null)
										{
											num = (short)1473052683;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_798;
									case 4:
										goto IL_7DB;
									case 5:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)970457095;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureSection = enumerator2.Current;
										num = (short)363003907;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										goto IL_57B;
									case 7:
										num = (short)1605632004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										try
										{
											num = (short)1938751489;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3;
												switch (num2)
												{
												case 0:
													try
													{
														num = (short)585433090;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
																goto IL_3F6;
															case 1:
																result2 = false;
																num = (short)1923350528;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_307;
																}
																continue;
															case 3:
																goto IL_414;
															case 4:
															{
																if (!enumerator4.MoveNext())
																{
																	num = (short)1220673541;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpCommonLib.IAcpField acpField = enumerator4.Current;
																num = (short)1307246600;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 5:
																num = (short)710868995;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 6:
															{
																global::AcpCommonLib.IAcpField acpField;
																if (acpField.ToString() != A_1.ToString())
																{
																	num = (short)687603713;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 7:
																num = (short)773914630;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 8:
															{
																global::AcpCommonLib.IAcpField acpField;
																if (acpField.Name.Equals(A_0))
																{
																	num = (short)1161428999;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															}
															IL_309:
															num = (short)17039364;
															num2 = (int)((global::System.IntPtr)num);
															continue;
															IL_307:
															goto IL_309;
														}
														IL_3F6:
														goto IL_97C;
														IL_414:
														break;
													}
													finally
													{
														num = (short)676724737;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
																enumerator4.Dispose();
																num = (short)361299970;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 1:
																switch (0)
																{
																case 0:
																	goto IL_44B;
																}
																continue;
															case 2:
																goto IL_482;
															}
															IL_44B:
															if (enumerator4 == null)
															{
																break;
															}
															num = (short)387121152;
															num2 = (int)((global::System.IntPtr)num);
														}
														IL_482:;
													}
													goto IL_485;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_2B7;
													}
													continue;
												case 2:
													num = (short)1964507139;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													goto IL_509;
												case 4:
													if (!enumerator3.MoveNext())
													{
														num = (short)79495170;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_485;
												}
												goto IL_2B7;
												IL_485:
												enumerator4 = enumerator3.Current.FieldsCollection.GetEnumerator();
												num = (short)1707999232;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_4B5:
												num = (short)2116354052;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_2B7:
												goto IL_4B5;
											}
											IL_509:
											goto IL_798;
										}
										finally
										{
											num = (short)2128609281;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3;
												switch (num2)
												{
												case 0:
													enumerator3.Dispose();
													num = (short)1031995394;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_541;
													}
													continue;
												case 2:
													goto IL_578;
												}
												IL_541:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)1067450368;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_578:;
										}
										goto Block_11;
									case 9:
										if (acpFeatureSection.HasEmbeddedRecset)
										{
											num = (short)1064632322;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_798;
									case 10:
										if (acpFeatureNode2 != null)
										{
											num = (short)528220160;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_798;
									case 11:
										num = (short)36503561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_142:
									num = (short)1863909381;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									Block_11:
									try
									{
										IL_57B:
										num = (short)1967849479;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_5E3;
											case 1:
											{
												global::AcpCommonLib.IAcpField acpField2;
												if (acpField2.Name.Equals(A_0))
												{
													num = (short)851705859;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
												goto IL_6D5;
											case 3:
												num = (short)1821638661;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												if (!enumerator4.MoveNext())
												{
													num = (short)972816392;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpField acpField2 = enumerator4.Current;
												num = (short)2059927553;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::AcpCommonLib.IAcpField acpField2;
												if (acpField2.ToString() != A_1.ToString())
												{
													num = (short)1877016582;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
												result2 = false;
												num = (short)1497890816;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												switch (0)
												{
												case 0:
													goto IL_5C6;
												}
												continue;
											case 8:
												num = (short)494141442;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_67D:
											num = (short)366804996;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_5C6:
											goto IL_67D;
										}
										IL_5E3:
										goto IL_97C;
										IL_6D5:
										goto IL_142;
									}
									finally
									{
										num = (short)1688797185;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												enumerator4.Dispose();
												num = (short)1438392632;
												short num3 = num;
												num = (short)1744380216;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													continue;
												default:
													num = (short)451870720;
													if (num != 0)
													{
													}
													num = (short)1043595266;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 1:
												switch (0)
												{
												case 0:
													goto IL_70D;
												}
												continue;
											case 2:
												goto IL_795;
											}
											IL_70D:
											if (enumerator4 == null)
											{
												break;
											}
											num = (short)2071199744;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_795:;
									}
									goto IL_798;
									IL_13D:
									goto IL_142;
									IL_798:
									enumerator4 = acpFeatureSection.FieldsCollection.GetEnumerator();
									num = (short)1796734982;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_7DB:;
							}
							finally
							{
								num = (short)1414463489;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1299644418;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_80F;
										}
										continue;
									case 2:
										goto IL_846;
									}
									IL_80F:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)900136960;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_846:;
							}
							break;
						case 7:
							num = (short)837419011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1555103751;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
							num = (short)2133458948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_849:
						num = (short)1188691976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A3:
						goto IL_849;
					}
					IL_90B:
					return result;
				}
				finally
				{
					num = (short)1402601473;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)555876354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_942;
							}
							continue;
						case 2:
							goto IL_979;
						}
						IL_942:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1774714880;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_979:;
				}
				IL_97C:
				num = (short)20774912;
				short num4 = num;
				return result2;
			}
			}
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00122DB0 File Offset: 0x00120FB0
		public void SetCodeplugFields(string flashcode)
		{
			int a_ = 1;
			short num = (short)1568079872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						num = (short)1162149896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)11993094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1568210945;
						if (num != 0)
						{
						}
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)608698368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						radioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551Value = true;
						radioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552Value = true;
						num = (short)1889468420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return;
					case 5:
					{
						num = (short)1559232512;
						short num3 = num;
						if (dataProfilesRecset != null)
						{
							num = (short)580190209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_368;
					}
					case 6:
						try
						{
							num = (short)735772679;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num4;
								switch (num2)
								{
								case 0:
									if (num4.Equals(0))
									{
										num = (short)2039611401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									goto IL_171;
								case 2:
								{
									num = (short)1828252517;
									short num5 = num;
									num = (short)1473047397;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_171;
									default:
										goto IL_2E4;
									}
									break;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									dataProfiles.Features.DataProfFeaturesARSMode_A7465.SetValue(0);
									num = (short)1091305478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)918814722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1776222212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num4 = dataProfiles.General.DataProfGeneralDataProfileType_A21320Value;
									num = (short)477167617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_13E;
									}
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									num4 = dataProfiles.General.DataProfGeneralPacketDataMode_A8689Value;
									num = (short)1010237440;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									num4 = dataProfiles.Features.DataProfFeaturesARSMode_A7465Value;
									num = (short)465764362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (num4.Equals(3))
									{
										num = (short)524746755;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								goto IL_13E;
								IL_171:
								if (num4.Equals(0))
								{
									num = (short)575209480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1DF:
								num = (short)278134789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13E:
								goto IL_1DF;
							}
							IL_2E4:
							num = (short)100925440;
							if (num != 0)
							{
							}
						}
						finally
						{
							num = (short)1498677249;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1252392962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_32F;
									}
									continue;
								case 2:
									goto IL_365;
								}
								IL_32F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1385365504;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_365:;
						}
						goto IL_368;
					case 7:
						try
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0];
							((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInner)(((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)[10636] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplit).EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset)[2]).FCCNarrowBandingFrequencySplitInnerSection.RadWideLabtoolFCCNarrowBandEndFrequency_A38271.SetValue(94000000);
						}
						catch (global::System.Exception)
						{
						}
						num = (short)1065680898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
						flashcodeTable.InitTable(true, this.a, false);
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						bool flag = false;
						string name = global::ConstraintHelper.UtilityMack.IsPortable() ? global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃입뢇몉릋릍ꂏ", a_) : global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉뾋뺍ꚏ", a_);
						if (flashcodeTable.IsOptionEnabledInFlashcode(name, flashcode, ref flag))
						{
							radioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481Value = true;
						}
						bool flag2 = false;
						name = (global::ConstraintHelper.UtilityMack.IsPortable() ? global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃입뢇몉릋릍ꆏ", a_) : global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉뾋몍ꆏ", a_));
						if (flashcodeTable.IsOptionEnabledInFlashcode(name, flashcode, ref flag2))
						{
							radioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504Value = true;
						}
						bool flag3 = false;
						name = (global::ConstraintHelper.UtilityMack.IsPortable() ? global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃입뢇몉릋릍ꊏ", a_) : global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉뾋몍ꖏ", a_));
						if (flashcodeTable.IsOptionEnabledInFlashcode(name, flashcode, ref flag3))
						{
							radioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507Value = true;
						}
						bool flag4 = false;
						name = (global::ConstraintHelper.UtilityMack.IsPortable() ? global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃입뢇몉릋뢍ꦏ", a_) : global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉뺋몍꒏", a_));
						if (flashcodeTable.IsOptionEnabledInFlashcode(name, flashcode, ref flag4))
						{
							num = (short)1986002947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					goto IL_5B;
					IL_368:
					num = (short)655294471;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5B:
				dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
				num = (short)275316741;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x001233EC File Offset: 0x001215EC
		private int t()
		{
			short num = (short)1584231065;
			short num2 = num;
			num = (short)1063744153;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)268959744;
				if (num != 0)
				{
				}
				num = (short)904724481;
				if (num != 0)
				{
				}
				result = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					for (;;)
					{
						IL_7F:
						switch (num3)
						{
						case 0:
							goto IL_16E;
						case 1:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue;
							result = int.Parse(radInfoGeneralCodeplugVersion_A7683_UIValue.Substring(1, 2).ToString());
							num = (short)1546256389;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							if (radioInformation != null)
							{
								num = (short)226295811;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_157;
						case 3:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue;
							num = (short)998113284;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue;
							if (radInfoGeneralCodeplugVersion_A7683_UIValue.Length > 2)
							{
								num = (short)239009793;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_157;
						}
						case 5:
							goto IL_157;
						}
						goto IL_9D;
						IL_157:
						num = (short)1614479360;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_16E:
					break;
					IL_9D:
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)566755330;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_7F;
				}
				catch
				{
				}
				break;
			}
			num = (short)17563648;
			short num4 = num;
			return result;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x001235A8 File Offset: 0x001217A8
		private int s()
		{
			short num = (short)1933836289;
			if (num != 0)
			{
			}
			num = (short)1884314006;
			short num2 = num;
			num = (short)1177508246;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1084162048;
				if (num != 0)
				{
				}
				result = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A0;
					}
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					for (;;)
					{
						IL_82:
						switch (num3)
						{
						case 0:
							goto IL_16F;
						case 1:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue;
							result = int.Parse(radInfoGeneralCodeplugVersion_A7683_UIValue.Substring(4, 2).ToString());
							num = (short)468254725;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							if (radioInformation != null)
							{
								num = (short)1485504515;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_158;
						case 3:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue;
							num = (short)142802948;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue;
							if (radInfoGeneralCodeplugVersion_A7683_UIValue.Length > 5)
							{
								num = (short)353566721;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_158;
						}
						case 5:
							goto IL_158;
						}
						goto IL_A0;
						IL_158:
						num = (short)1932722176;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_16F:
					break;
					IL_A0:
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)1543045122;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_82;
				}
				catch
				{
				}
				break;
			}
			num = (short)766246912;
			short num4 = num;
			return result;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00123764 File Offset: 0x00121964
		private void r()
		{
			short num = (short)1307508736;
			switch (num)
			{
			default:
			{
				num = (short)76677125;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
					switch (num2)
					{
					case 0:
						num = (short)896794632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)444792834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.t() == 13)
						{
							num = (short)1754595328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_402;
					case 4:
						try
						{
							num = (short)801308674;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_33E;
								case 1:
									num = (short)1821704192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F4;
									}
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)1563295745;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2F8;
								case 4:
									try
									{
										num = (short)962592771;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings != null)
												{
													num = (short)1597112326;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 1:
												goto IL_269;
											case 2:
												goto IL_288;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_177;
												}
												continue;
											case 4:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)2061107205;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
												num = (short)1776353280;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												num = (short)1261109250;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.NoiseReductionGroupSettingRadio_42584.Value = 4;
												audioSettings.NoiseReductionGroupSettingAccessory_42585.Value = 4;
												audioSettings.GainSensitivityGroupSettingRadio_42608.Value = 4;
												audioSettings.GainSensitivityGroupSettingAccessory_42610.Value = 4;
												audioSettings.AudioEqualizationGroupSettingRadio_42604.Value = 4;
												audioSettings.AudioEqualizationGroupSettingAccessory_42605.Value = 4;
												audioSettings.AudioEqualizationGroupSettingRadio_42613.Value = 4;
												audioSettings.AudioEqualizationGroupSettingAccessory_42614.Value = 4;
												num = (short)664928257;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_179:
											num = (short)1152974852;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_177:
											goto IL_179;
										}
										IL_269:
										IL_288:
										break;
									}
									finally
									{
										num = (short)1557725185;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)1908408322;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_2BF;
												}
												continue;
											case 2:
												goto IL_2F5;
											}
											IL_2BF:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1341980672;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2F5:;
									}
									goto IL_2F8;
								}
								IL_F9:
								num = (short)1328676867;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F4:
								goto IL_F9;
								IL_2F8:
								enumerator2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current).FeatureSectionsCollection.GetEnumerator();
								num = (short)359858180;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_33E:
							return;
						}
						finally
						{
							num = (short)1341587457;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
								{
									enumerator.Dispose();
									num = (short)111180607;
									short num3 = num;
									num = (short)2092727103;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_401;
									default:
										num = (short)757202944;
										if (num != 0)
										{
										}
										num = (short)262012930;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_376;
									}
									continue;
								case 2:
									goto IL_3FF;
								}
								IL_376:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1433337856;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3FF:
							IL_401:;
						}
						goto IL_402;
					case 5:
					{
						num = (short)2071527424;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					}
					case 6:
						if (radioProfilesRecset != null)
						{
							num = (short)1042415623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)1842610177;
						if (num != 0)
						{
						}
						num = (short)711786500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (this.s() < 1)
						{
							num = (short)1486159875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_93:
					if (this.t() >= 13)
					{
						num = (short)747962369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_402:
					radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
					num = (short)1633550342;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00123CC4 File Offset: 0x00121EC4
		private void q()
		{
			short num = (short)389152768;
			switch (num)
			{
			default:
			{
				num = (short)1328480264;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
					switch (num2)
					{
					case 0:
						num = (short)1097728003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)450363392;
						short num3 = num;
						num = (short)2041315332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_581;
					case 3:
						num = (short)55508993;
						if (num != 0)
						{
						}
						if (this.s() < 1)
						{
							num = (short)1132527618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (this.t() == 13)
						{
							num = (short)77135872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						if (radioProfilesRecset != null)
						{
							num = (short)1534918662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)1479737351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						try
						{
							num = (short)1792933897;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA labtoolRAD_PROF_CDA;
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
								switch (num2)
								{
								case 0:
									goto IL_3A4;
								case 1:
									if (labtoolRAD_PROF_CDA != null)
									{
										num = (short)1154875392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1820131334;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									audioSettings = null;
									labtoolRAD_PROF_CDA = null;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
									num = (short)565051395;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									try
									{
										num = (short)2098069513;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)6946824;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1116995584;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator2.Current;
												num = (short)1178992642;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												if (acpFeatureSection.GetType().Equals(typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings)))
												{
													num = (short)1032912902;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_21F;
											}
											case 4:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												labtoolRAD_PROF_CDA = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA);
												num = (short)288423939;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												if (acpFeatureSection.GetType().Equals(typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA)))
												{
													num = (short)1186332676;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
											{
												IL_1F9:
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												audioSettings = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
												num = (short)1564147719;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
												goto IL_21F;
											case 8:
												goto IL_332;
											case 9:
												switch (0)
												{
												case 0:
													goto IL_1A9;
												}
												continue;
											}
											goto IL_1A9;
											IL_21F:
											num = (short)2054051461;
											short num4 = num;
											num = (short)1995658885;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_1F9;
											default:
												num = (short)1234239488;
												if (num != 0)
												{
												}
												num = (short)1138294789;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_2B6:
											num = (short)805765121;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1A9:
											goto IL_2B6;
										}
										IL_332:
										goto IL_11D;
									}
									finally
									{
										num = (short)731381762;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)1191116801;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_3A1;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_36A;
												}
												continue;
											}
											IL_36A:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1749811200;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3A1:;
									}
									goto IL_3A4;
									IL_11D:
									num = (short)307167239;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)61997057;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)486604808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (audioSettings != null)
									{
										num = (short)850132997;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
									goto IL_50F;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_DC;
									}
									continue;
								}
								IL_E1:
								num = (short)1040908290;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DC:
								goto IL_E1;
								IL_3A4:
								audioSettings.AGCGainControlOutputAccessory_42644.Value = audioSettings.RadProfAudioSettingsOutput_A8679.Value;
								audioSettings.AGCGainControlTotalAccessory_42645.Value = audioSettings.RadProfAudioSettingsTotal_A9394.Value;
								audioSettings.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661.Value = audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715.Value;
								audioSettings.AnalogHighFrequencyBandAccessory_42650.Value = audioSettings.RadProfAudioSettingsAnalog_A7438.Value;
								audioSettings.DigitalHighFrequencyBandAccessory_42655.Value = audioSettings.RadProfAudioSettingsDigital_A7850.Value;
								audioSettings.SecurenetHighFrequencyBandAccessory_42660.Value = audioSettings.RadProfAudioSettingsSecurenet_A9097.Value;
								audioSettings.AnalogLowFrequencyBandAccessory_42647.Value = labtoolRAD_PROF_CDA.RadProfLabtoolAnalogBassControl_A19506.Value;
								audioSettings.DigitalLowFrequencyBandAccessory_42652.Value = labtoolRAD_PROF_CDA.RadProfLabtoolDigitalBassControl_A19507.Value;
								audioSettings.SecurenetLowFrequencyBandAccessory_42657.Value = labtoolRAD_PROF_CDA.RadProfLabtoolSecurenetBassControl_A19508.Value;
								num = (short)625803268;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_50F:
							return;
						}
						finally
						{
							num = (short)1646526466;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1790574593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_57E;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_547;
									}
									continue;
								}
								IL_547:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1636761600;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_57E:;
						}
						goto IL_581;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_67;
						}
						continue;
					}
					IL_67:
					if (this.t() >= 13)
					{
						num = (short)2017591297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_581:
					radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
					num = (short)338886661;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x001243CC File Offset: 0x001225CC
		private void p()
		{
			int a_ = 0;
			short num = (short)1005912064;
			switch (num)
			{
			default:
			{
				num = (short)1301086218;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						string radInfoGeneralModelNumber_A8539Value = radioInformation.General.RadInfoGeneralModelNumber_A8539Value;
						num = (short)1042808838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)243990529;
						if (num != 0)
						{
						}
						string radInfoGeneralModelNumber_A8539Value;
						if (radInfoGeneralModelNumber_A8539Value.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾂뚄랆", a_)))
						{
							num = (short)1047592964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (radioInformation != null)
						{
							num = (short)110034944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
						try
						{
							num = (short)371982340;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1193279489;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current).FeatureSectionsCollection.GetEnumerator();
									num = (short)764477442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_882;
								case 2:
									try
									{
										num = (short)1225261078;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1905721370;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
												num = (short)53411849;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.NoiseReductionGroupSettingAccessory_42585.Value = 4;
												num = (short)1153171460;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_62B;
											case 3:
												num = (short)1611399188;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_499;
											case 5:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.NoiseReductionGroupSettingRadio_42584.Value = 4;
												num = (short)544473104;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num = (short)1326186506;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511.Value == 0)
												{
													num = (short)883884033;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_499;
											}
											case 8:
												num = (short)2145714207;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings != null)
												{
													num = (short)1799553056;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 10:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (!audioSettings.RadProfAudioSettingsAnalogAGC2_A7439.Value)
												{
													num = (short)1515126796;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 11:
												goto IL_5B9;
											case 12:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.GainSensitivityGroupSettingAccessory_42610.Value = 4;
												num = (short)2012413965;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 14:
												num = (short)1417412637;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 15:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingRadio_42584.Value != 2)
												{
													num = (short)1468989443;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_39F;
											}
											case 16:
												goto IL_428;
											case 17:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.GainSensitivityGroupSettingRadio_42608.Value == 0)
												{
													num = (short)1404960776;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_4E0;
											}
											case 18:
												goto IL_39F;
											case 19:
												goto IL_811;
											case 20:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingRadio_42584.Value == 3)
												{
													num = (short)960888850;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_428;
											}
											case 21:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.GainSensitivityGroupSettingAccessory_42610.Value == 0)
												{
													num = (short)2142896134;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 22:
												switch (0)
												{
												case 0:
													goto IL_326;
												}
												continue;
											case 23:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.GainSensitivityGroupSettingRadio_42608.Value = 4;
												num = (short)1802174497;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 24:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value == 3)
												{
													num = (short)76939275;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_499;
											}
											case 25:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingRadio_42584.Value != 0)
												{
													num = (short)275972098;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_39F;
											}
											case 26:
												num = (short)1717960723;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 27:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194.Value == 0)
												{
													num = (short)108724229;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_428;
											}
											case 28:
												num = (short)1052114968;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 29:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value != 2)
												{
													num = (short)278790172;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5B9;
											}
											case 30:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value != 0)
												{
													num = (short)1725956110;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5B9;
											}
											case 31:
											{
												num = (short)526480246;
												short num3 = num;
												num = (short)236614518;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_62B;
												default:
												{
													num = (short)725942272;
													if (num != 0)
													{
													}
													global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
													if (!audioSettings.RadProfAudioSettingsAnalogAGC1_A7440.Value)
													{
														num = (short)476643351;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_4E0;
												}
												}
												break;
											}
											case 32:
												num = (short)1484914713;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 33:
												goto IL_4E0;
											}
											goto IL_326;
											IL_39F:
											num = (short)68485147;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_428:
											num = (short)798162961;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_499:
											num = (short)1073086485;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4E0:
											num = (short)1421082654;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_5B9:
											num = (short)1019871239;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_62B:
											num = (short)1659961359;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_78E:
											num = (short)1458438144;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_326:
											goto IL_78E;
										}
										IL_811:
										break;
									}
									finally
									{
										num = (short)185270274;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)1752825857;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_87F;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_848;
												}
												continue;
											}
											IL_848:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1872887808;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_87F:;
									}
									goto IL_882;
								case 3:
									goto IL_89B;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_20F;
									}
									continue;
								}
								IL_23D:
								num = (short)232718336;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20F:
								goto IL_23D;
								IL_882:
								num = (short)948502531;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_89B:
							return;
						}
						finally
						{
							num = (short)870645762;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)339410945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_90A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_8D2;
									}
									continue;
								}
								IL_8D2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1148715008;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_90A:;
						}
						goto IL_90D;
					case 4:
					{
						num = (short)37748736;
						short num4 = num;
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset;
						num = (short)630652935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_90D;
					case 6:
					{
						string radInfoGeneralModelNumber_A8539Value;
						if (radInfoGeneralModelNumber_A8539Value != null)
						{
							num = (short)611057669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
						if (radioProfilesRecset != null)
						{
							num = (short)1663238152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)801243139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						num = (short)2024603650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					}
					IL_7A:
					if (this.t() < 15)
					{
						num = (short)792657929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_90D:
					num = (short)366215169;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00124D90 File Offset: 0x00122F90
		private void o()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)917438464;
					short num3 = num2;
					num2 = (short)1131216900;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)1795948547;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)863436801;
					if (num2 != 0)
					{
					}
					if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799)
					{
						num2 = (short)1632763905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsProtectedZonePassword_A8766 == string.Empty)
					{
						num2 = (short)1592393728;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (radioWide.Features.ZnChanCfgFPPProtectionFPPEnable_A8142)
					{
						num2 = (short)703135749;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					radioWide.Features.ZnChanCfgFPPProtectionFPPEnable_A8142.Value = false;
					num2 = (short)1509228550;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_EB;
				}
				goto IL_2C;
			}
			IL_EB:
			num2 = (short)634628425;
			short num4 = num2;
			num2 = (short)1396484425;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_2C:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
				num2 = (short)683409410;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)1813577728;
				if (num2 != 0)
				{
				}
				break;
			}
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00124F9C File Offset: 0x0012319C
		public static void SetWindNoiseReductionLevelForAccessories()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					goto IL_209;
				case 1:
				{
					num2 = (short)23189612;
					short num3 = num2;
					num2 = (short)1121114220;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)609550337;
						if (num2 != 0)
						{
						}
						num2 = (short)1198325760;
						if (num2 != 0)
						{
						}
						break;
					}
					num2 = (short)153485316;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (radioWide != null)
					{
						num2 = (short)1594228737;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (radioProfilesRecset != null)
					{
						num2 = (short)949288960;
						short num4 = num2;
						num2 = (short)32571392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					if (radioWide.Labtool.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548Value)
					{
						num2 = (short)1086521349;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
					num2 = (short)990380035;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					try
					{
						num2 = (short)1468989440;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_11F;
								}
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num2 = (short)435814404;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles)enumerator.Current).AudioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511.SetValue(0);
								num2 = (short)986841091;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_19E;
							case 4:
								num2 = (short)1844969474;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_121:
							num2 = (short)1831403521;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_11F:
							goto IL_121;
						}
						IL_19E:
						return;
					}
					finally
					{
						num2 = (short)833945600;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1D3;
								}
								continue;
							case 1:
								goto IL_206;
							case 2:
								enumerator.Dispose();
								num2 = (short)1476722689;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_1D3:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1871904770;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_206:;
					}
					goto IL_209;
				}
				goto IL_2C;
				IL_209:
				enumerator = radioProfilesRecset.GetEnumerator();
				num2 = (short)827981830;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1887305730;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00125298 File Offset: 0x00123498
		public void SetActionTypeAfterUpgrade()
		{
			short num = (short)87621632;
			switch (num)
			{
			default:
			{
				num = (short)1778122764;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
					bool flag3;
					switch (num2)
					{
					case 0:
						flag = false;
						flag2 = false;
						radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
						num = (short)486408205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (radioWide != null)
						{
							num = (short)741474313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					case 2:
						if (radioInformation != null)
						{
							num = (short)1870135299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					case 3:
						num = (short)399376389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (actionConsolidationRecset != null)
						{
							num = (short)838926336;
							short num3 = num;
							num = (short)2016673802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						if (radioWide.Labtool.RadWideLabtoolPAAlertCapability_A42944.Value)
						{
							num = (short)1662124046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1795817479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)1660813319;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
									if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value == 0)
									{
										num = (short)724369413;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_364;
								case 4:
									if (flag2)
									{
										num = (short)1250820107;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1204617225;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)468189188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)229638147;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_1EC;
									}
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
									actionConsolidation.General.RadioErgoConfigACActionType_A42871.SetValue(3);
									num = (short)979959809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									if (flag)
									{
										num = (short)36569096;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)876806150;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation = (global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation)enumerator.Current;
									num = (short)361824258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
									actionConsolidation.General.RadioErgoConfigACActionType_A42871.SetValue(1);
									num = (short)1851719680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_2DF:
								num = (short)1647181834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1EC:
								goto IL_2DF;
							}
							IL_364:
							return;
						}
						finally
						{
							num = (short)981008384;
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
										goto IL_39C;
									}
									continue;
								case 1:
									goto IL_3D3;
								case 2:
									enumerator.Dispose();
									num = (short)555745281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_39C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)16384002;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3D3:;
						}
						goto IL_3D6;
					case 7:
						goto IL_13D;
					case 8:
						goto IL_AC;
					case 9:
						num = (short)1218641922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = actionConsolidationRecset.GetEnumerator();
						num = (short)1633288198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						num = (short)1366501026;
						short num4 = num;
						num = (short)504309410;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13D;
						default:
							num = (short)1460797441;
							if (num != 0)
							{
							}
							num = (short)1005256704;
							if (num != 0)
							{
							}
							flag3 = radioInformation.Labtool.RadInfoLabtoolQ445FiregroundSupport_A8796.Value;
							goto IL_405;
						}
						break;
					}
					case 12:
						switch (0)
						{
						case 0:
							goto IL_87;
						}
						continue;
					case 13:
						if (radioInformation != null)
						{
							num = (short)1299382287;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143;
					case 14:
						num = (short)801832971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_3D6;
					case 16:
						goto IL_143;
					}
					IL_87:
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num = (short)832307200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_AC:
					actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
					num = (short)1605435396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_143:
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)1192034305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D6:
					flag2 = radioInformation.Labtool.RadInfoLabtoolMissionCriticalGeofencing_A43013.Value;
					num = (short)1947992080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_405:
					flag = flag3;
					num = (short)1947402248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13D:
					flag3 = false;
					goto IL_405;
				}
				return;
			}
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00125888 File Offset: 0x00123A88
		public void SyncActiveMicForBTPTT()
		{
			short num = (short)366149636;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (!radioWide.Labtool.RadWideLabtoolActiveMicForBTPTTCapable_43053.Value)
					{
						goto IL_20A;
					}
					num = (short)198728655;
					short num3 = num;
					num = (short)1776966607;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20A;
					default:
						num = (short)1011154944;
						if (num != 0)
						{
						}
						num = (short)1913520131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (radioWide.Bluetooth.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Value)
					{
						num = (short)2018312200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.SetValue(3);
					num = (short)83951617;
					if (num != 0)
					{
					}
					num = (short)1436811271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)36044806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1759707137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
					radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
					num = (short)1609629696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (this.t() < 15)
					{
						num = (short)1715208197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20A;
				case 7:
					goto IL_14A;
				case 8:
					goto IL_BA;
				}
				IL_48:
				if (!global::ConstraintHelper.UtilityMack.IsPortable())
				{
					goto IL_20A;
				}
				num = (short)2027290626;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BA:
			radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.SetValue(2);
			return;
			IL_14A:
			IL_20A:
			num = (short)739377152;
			short num4 = num;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00125AC8 File Offset: 0x00123CC8
		public void RefreshAESFields()
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			string value;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1304166406;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
					{
						num2 = (short)203292680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_227;
				}
				case 2:
					num2 = (short)891879431;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_225;
				case 4:
					if (value != null)
					{
						num2 = (short)831258626;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_227;
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
					num2 = (short)1688207361;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (int.Parse(value.Substring(1, 2)) < 16)
					{
						num2 = (short)571867141;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_227;
				case 7:
					if (value.Length > 3)
					{
						num2 = (short)1226833920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_227;
				case 8:
				{
					num2 = (short)1653866497;
					if (num2 != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
					secureWide.General.SecureWideADPAlgorithmEnable_43200.SetValue(true);
					secureWide.General.SecureWideKeyloadingSource_43204.SetValue(0);
					num2 = (short)2112761493;
					short num3 = num2;
					num2 = (short)1036136085;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_227;
					default:
						num2 = (short)1752629248;
						if (num2 != 0)
						{
						}
						num2 = (short)2116157443;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_34;
			}
			IL_225:
			IL_227:
			num2 = (short)1365377024;
			short num4 = num2;
			return;
			IL_34:
			value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralCodeplugVersion_A7683.Value;
			num2 = (short)673185796;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00125D24 File Offset: 0x00123F24
		private void n()
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_94;
			}
			short num;
			int num3;
			bool flag;
			for (;;)
			{
				IL_13:
				num = (short)1078243361;
				short num2 = num;
				num = (short)2057416737;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)721420288;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_1BF;
					case 1:
						num = (short)1671888907;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1903165449;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_113;
					case 4:
						radioWide.Features.RadWideFeaturePreAmpUHF_A42962.SetValue(radioWide.Features.RadWideAdvancedPreAmp_A8733.Value);
						num = (short)1562705930;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (radioWide.Features.RadWideAdvancedPreAmp_A8733.Value != radioWide.Features.RadWideFeaturePreAmpUHF_A42962.Value)
						{
							num = (short)529465348;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E9;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
						if (radioInformation.Labtool.RadInfoLabtoolW12Preamp_A9671.Value)
						{
							num = (short)928579585;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E9;
					}
					case 7:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)630652930;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E9;
					case 8:
						num = (short)2134900742;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (!flag)
						{
							num = (short)319619080;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E9;
					case 10:
						goto IL_235;
					case 11:
						if (radioWide.Features.RadWideAdvancedPreAmp_A8733.Value != radioWide.Features.RadWideFeaturePreAmpVHF_A42960.Value)
						{
							num = (short)1944256512;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_113;
					}
					goto IL_94;
					IL_113:
					num = (short)1707802629;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1BF:
				radioWide.Features.RadWideFeaturePreAmpVHF_A42960.SetValue(radioWide.Features.RadWideAdvancedPreAmp_A8733.Value);
				num = (short)1071382531;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_235:
			IL_2E9:
			num = (short)1589051393;
			if (num != 0)
			{
			}
			return;
			IL_94:
			flag = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮉\udc8b획ꢏꞑ꒓ꚕ", a_));
			num = (short)367591424;
			short num4 = num;
			num = (short)1341915143;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00126044 File Offset: 0x00124244
		private void m()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset feature;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!(feature[0][10093] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool).RadWideLabtoolAudioEnhancement_A42736.Value)
					{
						num2 = (short)617152514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_DA;
				case 2:
					(feature[0][10101] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions).RadWideAudioConfigurationLevel_42740.Value = 0;
					num2 = (short)1115488257;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_DA:
			num2 = (short)256374644;
			short num3 = num2;
			num2 = (short)1137637236;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num2 = (short)446627840;
				if (num2 != 0)
				{
				}
				num2 = (short)1062076416;
				short num4 = num2;
				break;
			}
			}
			return;
			IL_1C:
			num2 = (short)1634467841;
			if (num2 != 0)
			{
			}
			feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
			num2 = (short)223739904;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x001261A0 File Offset: 0x001243A0
		public void ApplyModelTiering()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					try
					{
						modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(this.a, global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.FLASHPORT, global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.ALL, false);
						goto IL_3A;
					}
					catch (global::System.Exception)
					{
						global::System.Windows.Forms.MessageBox.Show(global::CommonResources.AppResources.Internal_Error_Critical_File_Mis_Crpt_0xFCF01);
						global::System.Environment.Exit(1036033);
						goto IL_3A;
					}
					goto IL_9F;
					IL_3A:
					num2 = (short)1091698690;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_74;
				case 2:
					if (!modelTiering.FindModel(this.a))
					{
						num2 = (short)1900740609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_159;
				}
				goto IL_1C;
			}
			IL_74:
			IL_9F:
			num2 = (short)871038977;
			if (num2 != 0)
			{
			}
			num2 = (short)211422477;
			short num3 = num2;
			num2 = (short)1169755405;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_159:
				global::AcpCommonLib.ConstraintManager.Suspend();
				modelTiering.ApplyTiering(true);
				global::AcpCommonLib.ConstraintManager.Resume();
				return;
			default:
			{
				num2 = (short)1639120896;
				if (num2 != 0)
				{
				}
				num2 = (short)1068957696;
				short num4 = num2;
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Not_Found_In_Model_Tiering_Database.AcpStringFormat(new object[]
				{
					this.a
				}));
			}
			}
			IL_1C:
			string empty = string.Empty;
			modelTiering = null;
			num2 = (short)578355200;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00126328 File Offset: 0x00124528
		internal void DepotFlashRadio(string upgradeFile, string newFlashCode)
		{
			short num = (short)687472640;
			short num2 = num;
			num = (short)197263360;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)403636225;
				if (num != 0)
				{
				}
				string empty = string.Empty;
				string text = string.Empty;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_27A;
					}
					for (;;)
					{
						IL_87:
						global::AcpBusinessLayer.AcpDocument acpDocument;
						string text2;
						global::SpecialFeatures.Flashport.FlashRadio.FlashCodeplug flashCodeplug;
						global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
						switch (num3)
						{
						case 0:
							num = (short)2080899180;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_4CF;
						case 2:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_1255;
								}
								for (;;)
								{
									IL_1236:
									switch (num3)
									{
									case 0:
										num = (short)1252786178;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (this.f != null)
										{
											num = (short)1460535296;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_12EC;
									case 2:
										if (empty.Equals(global::CommonResources.AppResources.LP_Write_Radio_After_Flashport_To_Update_Language_Pack))
										{
											num = (short)706347011;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_12EC;
									case 3:
										text = empty;
										num = (short)848232452;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_12EC;
									case 5:
										goto IL_1305;
									}
									goto IL_1255;
									IL_12EC:
									num = (short)65732613;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1305:
								goto IL_767;
								IL_1255:
								this.a(ref empty);
								num = (short)125304833;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_1236;
							}
							catch (global::System.Exception)
							{
								if (this.f != null)
								{
									global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentError, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.LP_Error_Updating_Language_Pack);
									this.f.ReportProgress(this.n, userState);
								}
								throw;
							}
							goto IL_133C;
							IL_767:
							this.n = 32;
							acpDocument.Initialized(false);
							num = (short)118685800;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_527;
						case 4:
							if (this.f != null)
							{
								num = (short)135004173;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_172B;
						case 5:
						{
							bool flag = true;
							num = (short)586809361;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)1360920658;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (!this.h)
							{
								num = (short)82771992;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							text2 = global::CommonResources.AppResources.Refresh_Completed_Successfully_Exception_AB_OE_No_SW;
							num = (short)1449132133;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)1305542681;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (this.f != null)
							{
								num = (short)1106182232;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E58;
						case 10:
							if (this.f != null)
							{
								num = (short)1601962050;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_640;
						case 11:
							goto IL_930;
						case 12:
							goto IL_16EB;
						case 13:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker = this.f;
							int num4 = this.n;
							this.n = num4 + 1;
							backgroundWorker.ReportProgress(num4, global::CommonResources.AppResources.Upgrading_codeplug);
							num = (short)2057437286;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							if (this.g != null)
							{
								num = (short)857735206;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_527;
						case 15:
						{
							bool flag;
							bool flag2;
							if (flag && flag2)
							{
								num = (short)2022637661;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1825308779;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
						{
							string text3 = global::CommonResources.AppResources.Disconnect_Radio_but_do_not_turn_off.AcpStringFormat(new object[]
							{
								text2
							});
							num = (short)1442775132;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							goto IL_133C;
						case 18:
						{
							string str = string.Format(global::CommonResources.AppResources.FLASHport_FCC_Warning, '\n');
							string text4 = text2 + str;
							num = (short)176619616;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							goto IL_16EB;
						case 20:
							if (this.f != null)
							{
								num = (short)1631060085;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DF4;
						case 21:
							goto IL_F5D;
						case 22:
							if (this.f != null)
							{
								num = (short)975568922;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_80C;
						case 23:
							if (!string.IsNullOrEmpty(this.k.OptBrdHardwareType))
							{
								num = (short)1702101000;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_133C;
						case 24:
							text2 = global::CommonResources.AppResources.Upgrade_Completed_Successfully_Exception_AB_OE_No_SW;
							num = (short)914489429;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							if (!this.i)
							{
								num = (short)1942749189;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_133C;
						case 26:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker2 = this.f;
							int num4 = this.n;
							this.n = num4 + 1;
							backgroundWorker2.ReportProgress(num4, global::CommonResources.AppResources.Unpacking_the_radio_codeplug);
							num = (short)1482555482;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 27:
						{
							bool flag = false;
							bool flag2 = false;
							text2 = global::CommonResources.AppResources.Radio_Refresh_Completed_Successfully;
							num = (short)1454964831;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
							goto IL_DF4;
						case 29:
							if (this.f != null)
							{
								num = (short)2101870670;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_181A;
						case 30:
							goto IL_C08;
						case 31:
							goto IL_16EB;
						case 32:
							if (!this.h)
							{
								num = (short)596770884;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2E8;
						case 33:
							if (this.f != null)
							{
								num = (short)615710829;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8E8;
						case 34:
							goto IL_1940;
						case 35:
							if (!this.t)
							{
								num = (short)790954031;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16EB;
						case 36:
						{
							string text3;
							text2 = text3;
							num = (short)509607957;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 37:
							if (!flashCodeplug.UpgradeCodeplug(this.a, newFlashCode, false, true, null))
							{
								num = (short)339279936;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2E8;
						case 38:
							this.g.MaxSteps = 15;
							this.g.CurrentStep = this.n;
							num = (short)820707331;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 39:
							text2 = global::CommonResources.AppResources.FLASHport_Upgrade_Completed_Successfully;
							num = (short)274595951;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 40:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState2 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.LP_Begin_Language_Pack_Update);
							global::System.ComponentModel.BackgroundWorker backgroundWorker3 = this.f;
							int num4 = this.n;
							this.n = num4 + 1;
							backgroundWorker3.ReportProgress(num4, userState2);
							num = (short)1075511359;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 41:
							if (this.g != null)
							{
								num = (short)1322057785;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_156F;
						case 42:
							if (this.f != null)
							{
								num = (short)1321795646;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_158E;
						case 43:
							if (!this.h)
							{
								num = (short)1025638451;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							text2 = global::CommonResources.AppResources.Refresh_Completed_Successfully_Exception_OE_No_OE_SW;
							num = (short)1868103736;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							num = (short)148176939;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 45:
							if (this.f != null)
							{
								num = (short)735969320;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C4A;
						case 46:
							if (this.r)
							{
								num = (short)422510608;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F5D;
						case 47:
							num = (short)1464991862;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 48:
							goto IL_CD3;
						case 49:
							text2 = global::CommonResources.AppResources.Upgrade_Completed_Successfully_Exception_OE_No_OE_SW;
							num = (short)968949772;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 50:
							goto IL_8E8;
						case 51:
							text2 = global::CommonResources.AppResources.Upgrade_Completed_Successfully_Exception_OE_No_OE_SW;
							num = (short)1441923103;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
							goto IL_156F;
						case 53:
							if (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio.checkPCIFieldsValue(this.a, this.fileHostVersion, this.c))
							{
								num = (short)1353646177;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1796;
						case 54:
							this.g.MaxSteps = 65;
							this.g.CurrentStep = this.n;
							num = (short)1858011137;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 55:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
							radioInformation.Tracking.RadInfoTrackingCodeplugVersion_A7688_UIValue = global::AcpCommonLib.AppInfoManager.AppVersion;
							radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue = global::AcpCommonLib.AppInfoManager.AppVersion;
							radioInformation.Labtool.RadInfoLabtoolSecurePartitionVersionNumber_A9076_UIValue = global::AcpCommonLib.AppInfoManager.AppVersion;
							radioInformation.Labtool.RadInfoLabtoolOriginalSecurePartitionVersion_A8626_UIValue = global::AcpCommonLib.AppInfoManager.AppVersion;
							radioInformation.Tracking.RadInfoTrackingSource2_A8625_UIValue = global::CommonResources.AppResources.Depot_ID;
							radioInformation.Tracking.RadInfoTrackingSource1_A9171_UIValue = global::CommonResources.AppResources.Depot_ID;
							string radInfoFLASHportFLASHcode_A8132Value = null;
							global::SpecialFeatures.Flashport.FlashRadio.FlashcodeGenerator.CalculateFlashcode(ref radInfoFLASHportFLASHcode_A8132Value, this.a);
							if (radInfoFLASHportFLASHcode_A8132Value != newFlashCode)
							{
								goto Block_4;
							}
							(global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).FLASHport.RadInfoFLASHportFLASHcode_A8132Value = radInfoFLASHportFLASHcode_A8132Value;
							if (this.f != null)
							{
								global::System.ComponentModel.BackgroundWorker backgroundWorker4 = this.f;
								int num4 = this.n;
								this.n = num4 + 1;
								backgroundWorker4.ReportProgress(num4, global::CommonResources.AppResources.UpgradeRadio_Ucd);
							}
							this.RadioHostVersion = this.k.HostVersion;
							this.PostUpgradeCodeplugHandler(newFlashCode);
							this.ApplyModelTiering();
							global::AcpCommonLib.ConstraintManager.Suspend();
							global::AcpKeyValidatorLib.AcpKeyValidator acpKeyValidator = new global::AcpKeyValidatorLib.AcpKeyValidator();
							if (!acpKeyValidator.IsDepotKeyAttached())
							{
								goto Block_13;
							}
							string depotKeySerialNum = new global::SpecialFeatures.DepotLabtool.DepotCommon().GetDepotKeySerialNum(acpKeyValidator);
							radioInformation.DepotKeyInfo.RadInfoDepotKeySerialNumber_42793.SetValue(depotKeySerialNum);
							global::Motorola.Common.Communication.CommonUtil.IshItemCollection a_ = this.d();
							this.n = 30;
							num = (short)715522120;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 56:
							goto IL_16EB;
						case 57:
							this.g.MaxSteps = 8;
							this.g.CurrentStep = this.n;
							num = (short)514981940;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 58:
							try
							{
								modelTiering.UpdateUtilityMackModelType();
								goto IL_B82;
							}
							finally
							{
								num = (short)1357512704;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									num = (short)1538723625;
									short num5 = num;
									num = (short)891096873;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)930742272;
										if (num != 0)
										{
										}
										switch (num3)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_491;
											}
											continue;
										case 1:
											goto IL_4CC;
										case 2:
											((global::System.IDisposable)modelTiering).Dispose();
											num = (short)127401985;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									IL_491:
									if (modelTiering == null)
									{
										break;
									}
									num = (short)42139650;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_4CC:;
							}
							goto IL_4CF;
							IL_B82:
							this.g();
							num = (short)1703346209;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 59:
							num = (short)887619649;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 60:
							if (this.f != null)
							{
								num = (short)758972443;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1927;
						case 61:
							num = (short)1995702325;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 62:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState3 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.ConnectDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.ReadRadInfoStart, global::CommonResources.AppResources.Reading_and_validating_radio_parameters);
							global::System.ComponentModel.BackgroundWorker backgroundWorker5 = this.f;
							int num4 = this.n;
							this.n = num4 + 1;
							backgroundWorker5.ReportProgress(num4, userState3);
							num = (short)1600847991;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 63:
							goto IL_C4A;
						case 64:
							goto IL_1770;
						case 65:
							if (!this.h)
							{
								num = (short)1894776881;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							text2 = global::CommonResources.AppResources.Refresh_Completed_Successfully_Exception_OE_No_OE_SW;
							num = (short)794689642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 66:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState4 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Flashing_radio_software);
							global::System.ComponentModel.BackgroundWorker backgroundWorker6 = this.f;
							int num4 = this.n;
							this.n = num4 + 1;
							backgroundWorker6.ReportProgress(num4, userState4);
							num = (short)36372555;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 67:
							if (!this.i)
							{
								num = (short)154206267;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16EB;
						case 68:
							num = (short)444137476;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 69:
							if (global::ConstraintHelper.UtilityMack.IsPortable())
							{
								num = (short)1360003156;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16EB;
						case 70:
							if (!this.h)
							{
								num = (short)1277034590;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							text2 = global::CommonResources.AppResources.Refresh_Completed_Successfully_Exception_AB_No_AB_SW;
							num = (short)1733492755;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 71:
							if (!string.IsNullOrEmpty(this.k.ConBrdHardwareType))
							{
								num = (short)1920204886;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CD3;
						case 72:
							if (this.f != null)
							{
								num = (short)2017591377;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_930;
						case 73:
							num = (short)753795139;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 74:
							try
							{
								this.k();
								goto IL_17D8;
							}
							catch (global::System.Exception)
							{
								if (this.f != null)
								{
									global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState5 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FinalValidationError, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, "");
									this.f.ReportProgress(this.n, userState5);
								}
								throw;
							}
							goto IL_16EB;
							IL_17D8:
							num = (short)280494100;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 75:
							goto IL_640;
						case 76:
						{
							bool flag2 = true;
							num = (short)1923285040;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 77:
							goto IL_EB6;
						case 78:
						{
							global::System.ComponentModel.BackgroundWorker backgroundWorker7 = this.f;
							int num4 = this.n;
							this.n = num4 + 1;
							backgroundWorker7.ReportProgress(num4);
							num = (short)1663500387;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 79:
							if (!this.j)
							{
								num = (short)1156382796;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CD3;
						case 80:
							if (!this.h)
							{
								num = (short)585957382;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D98;
						case 81:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState6 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.CodeplugDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Validating_user_parameters);
							global::System.ComponentModel.BackgroundWorker backgroundWorker8 = this.f;
							int num4 = this.n;
							this.n = num4 + 1;
							backgroundWorker8.ReportProgress(num4, userState6);
							num = (short)1519976459;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 82:
							if (this.a(this.c, newFlashCode))
							{
								num = (short)740294674;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D98;
						case 83:
							this.t = true;
							num = (short)1854668877;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 84:
							num = (short)997982297;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 85:
							goto IL_16EB;
						case 86:
							num = (short)811728975;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 87:
							goto IL_D98;
						case 88:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState7 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FinalValidationStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Validating_Update);
							global::System.ComponentModel.BackgroundWorker backgroundWorker9 = this.f;
							int num4 = this.n;
							this.n = num4 + 1;
							backgroundWorker9.ReportProgress(num4, userState7);
							num = (short)704053346;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 89:
							if (!this.k.OptBrdHwNotPresentFlag)
							{
								num = (short)1309474889;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16EB;
						case 90:
							goto IL_80C;
						case 91:
							if (this.k.RadioBBFSuiteVersion != null)
							{
								num = (short)1021575251;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EB6;
						case 92:
						{
							string text3;
							if (!string.IsNullOrEmpty(text3))
							{
								num = (short)130809892;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F5D;
						}
						case 93:
							num = (short)1161822215;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 94:
							text2 = global::CommonResources.AppResources.Upgrade_Completed_Successfully_Exception_AB_No_AB_SW;
							num = (short)698220664;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 95:
							if (!this.h)
							{
								num = (short)1401618471;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AF7;
						case 96:
						{
							string text4;
							if (!string.IsNullOrEmpty(text4))
							{
								num = (short)653328494;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D98;
						}
						case 97:
							goto IL_734;
						case 98:
							goto IL_E58;
						case 99:
							goto IL_181A;
						case 100:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState8 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, text);
							this.f.ReportProgress(100, userState8);
							num = (short)1974665329;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 101:
							goto IL_16EB;
						case 102:
							goto IL_172B;
						case 103:
						{
							bool flag;
							if (flag)
							{
								num = (short)1984167980;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16EB;
						}
						case 104:
							goto IL_AB7;
						case 105:
							num = (short)1321926701;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 106:
							goto IL_16EB;
						case 107:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)1883439134;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)364314727;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 108:
							if (this.h)
							{
								num = (short)720502845;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1796;
						case 109:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState9 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.ReadRadInfoDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Validating_user_parameters);
							global::System.ComponentModel.BackgroundWorker backgroundWorker10 = this.f;
							int num4 = this.n;
							this.n = num4 + 1;
							backgroundWorker10.ReportProgress(num4, userState9);
							string serial = global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.convertSerialNumberToAscii(this.b);
							global::SpecialFeatures.Flashport.FlashRadio.RadioInfoParams userState10 = new global::SpecialFeatures.Flashport.FlashRadio.RadioInfoParams(this.a, serial, this.c);
							this.f.ReportProgress(this.n, userState10);
							num = (short)406913074;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 110:
						{
							string text4;
							text2 = text4;
							num = (short)1568211031;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 111:
							goto IL_AF7;
						case 112:
							if (!string.IsNullOrEmpty(text))
							{
								num = (short)405733476;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1927;
						case 113:
							goto IL_1927;
						case 114:
							num = (short)252248087;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 115:
							if (this.g != null)
							{
								num = (short)857079862;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4CF;
						case 116:
							try
							{
								global::Motorola.Common.Communication.CommonUtil.IshItemCollection a_;
								this.c(a_);
								goto IL_574;
							}
							catch (global::System.Exception)
							{
								if (this.f != null)
								{
									global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState11 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentError, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Flashing_radio_software);
									this.f.ReportProgress(this.n, userState11);
								}
								throw;
							}
							goto IL_C08;
							IL_574:
							this.n = 98;
							num = (short)1409089545;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 117:
						{
							global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState12 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FinalValidationDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Validation_Complete);
							this.f.ReportProgress(100, userState12);
							num = (short)728891420;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 118:
							if (global::ConstraintHelper.UtilityMack.IsMobile())
							{
								num = (short)1967784050;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)236781637;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 119:
							goto IL_158E;
						case 120:
							goto IL_16EB;
						case 121:
							if (!this.c())
							{
								num = (short)40828928;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1796;
						case 122:
							if (this.r)
							{
								num = (short)511967337;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AB7;
						}
						goto IL_27A;
						IL_2E8:
						num = (short)754843703;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_4CF:
						num = (short)530776180;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_527:
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioCodeplug = this.ReadCodeplug();
						this.n = 25;
						num = (short)1671036950;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_640:
						num = (short)1370685555;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_80C:
						this.UnpackCodeplug(radioCodeplug);
						flashCodeplug = new global::SpecialFeatures.Flashport.FlashRadio.FlashCodeplug();
						flashCodeplug.postCodeplugInitialization();
						this.PreUpgradeCodeplugHandler();
						acpDocument = (global::AcpBusinessLayer.AcpDocument)global::AcpCommonLib.FeatureManager.ActiveDocument;
						acpDocument.Initialized(true);
						num = (short)907804793;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_8E8:
						this.b(upgradeFile);
						num = (short)1510342685;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_930:
						num = (short)1580138618;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_AB7:
						num = (short)229703690;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_AF7:
						num = (short)2012807203;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C08:
						num = (short)377815110;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C4A:
						num = (short)1456865321;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CD3:
						num = (short)1819541519;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D98:
						global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState13 = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FinalValidationDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, text2);
						this.f.ReportProgress(100, userState13);
						num = (short)1799487600;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_DF4:
						num = (short)932315196;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_E58:
						num = (short)210698314;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_EB6:
						modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(this.a, "");
						num = (short)1262223418;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F5D:
						num = (short)1075773520;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_133C:
						num = (short)1160052807;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_156F:
						num = (short)2140798978;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_158E:
						this.BeginFlashUpgrade();
						num = (short)505413723;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_16EB:
						num = (short)886177838;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_172B:
						num = (short)1515061285;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1796:
						num = (short)468582432;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_181A:
						this.b();
						num = (short)1590951950;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1927:
						num = (short)1862402082;
						num3 = (int)((global::System.IntPtr)num);
					}
					Block_4:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Codeplug_upgrade_failed);
					IL_734:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.The_version_current_radio_matches_in_upgrade_file_No_upgrade_needed);
					Block_13:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.This_function_can_only_be_accessed);
					IL_1770:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Codeplug_upgrade_failed);
					IL_1940:
					return;
					IL_27A:
					global::AcpCommonLib.AppInfoManager.DragOperation = true;
					this.Connect();
					num = (short)1012334634;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_87;
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Communication_with_radio_failed_Please_cycle_radio_power_and_check_connections);
				}
				catch (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException)
				{
					throw;
				}
				catch (global::System.Exception ex)
				{
					if (ex.Message != null)
					{
						throw;
					}
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Communication_with_radio_failed_Please_cycle_radio_power_and_check_connections);
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1987;
					}
					for (;;)
					{
						IL_1974:
						switch (num3)
						{
						case 0:
							if (this.l != null)
							{
								num = (short)380043265;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A08;
						case 1:
							this.l.Dispose();
							this.l = null;
							num = (short)851836930;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1A06;
						}
						goto IL_1987;
					}
					IL_1A06:
					IL_1A08:
					goto EndFinally_71;
					IL_1987:
					global::AcpCommonLib.AppInfoManager.DragOperation = false;
					this.a(this.o);
					this.a(this.p);
					num = (short)1038024704;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_1974;
					EndFinally_71:;
				}
				return;
			}
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00127E04 File Offset: 0x00126004
		private bool a(string A_0, string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			short num;
			int num2;
			bool result;
			byte b;
			for (;;)
			{
				IL_0A:
				num = (short)1208614913;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)1800011779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
				{
					byte flashcodeIntValue = (byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(A_1[7]);
					int flashcodeIntValue2 = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(A_0[7]);
					if ((flashcodeIntValue & b) == b)
					{
						num = (short)1182334976;
						short num3 = num;
						num = (short)405012480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				case 3:
				{
					int flashcodeIntValue2;
					if ((flashcodeIntValue2 & (int)b) != (int)b)
					{
						num = (short)65994756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				case 4:
				{
					num = (short)1578062653;
					short num4 = num;
					num = (short)525947709;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)255197184;
						if (num != 0)
						{
						}
						result = true;
						break;
					}
					num = (short)861143041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_4A;
			}
			return result;
			IL_4A:
			result = false;
			b = 8;
			num = (short)1250623490;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00127F7C File Offset: 0x0012617C
		private byte[] a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)1535377408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				byte[] result;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_DA;
					case 1:
						goto IL_2AC;
					case 2:
						try
						{
							num = (short)1526398980;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)316014593;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)1499201538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)178388997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 901)
									{
										num = (short)75563011;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									result = keyValuePair.Value.Data;
									num = (short)1330446342;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_148;
									}
									continue;
								case 5:
									goto IL_213;
								case 6:
									goto IL_1F5;
								}
								IL_14A:
								num = (short)1256521728;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_148:
								goto IL_14A;
							}
							IL_1F5:
							IL_213:
							return result;
						}
						finally
						{
							num = (short)918093824;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_24C;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1666711554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_281;
								}
								IL_24C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1190330369;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_281:
							num = (short)1636630529;
							if (num != 0)
							{
							}
						}
						goto IL_2AC;
					}
					break;
					IL_2AC:
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)1788870658;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3B:
				result = new byte[0];
				codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				num = (short)864904735;
				short num3 = num;
				num = (short)621504031;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_DA:
					if (codeplugInIshItemCollection.Count > 0)
					{
						num = (short)30736385;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_28;
					}
					break;
				default:
				{
					num = (short)1215168512;
					if (num != 0)
					{
					}
					num = (short)1147600896;
					short num4 = num;
					num = (short)1398145024;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
				return result;
			}
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00128278 File Offset: 0x00126478
		private void b(string A_0)
		{
			int a_ = 19;
			short num = (short)784007168;
			switch (num)
			{
			default:
			{
				num = (short)1423245339;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.FileAttributes fileAttributes;
					string text;
					switch (num2)
					{
					case 0:
						this.d = new global::SpecialFeatures.Flashport.FlashportUpgradeFile(this.o);
						num = (short)1596588036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_53F;
					case 2:
					{
						num = (short)1179648;
						short num3 = num;
						string extension = global::System.IO.Path.GetExtension(A_0);
						num = (short)780140562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_431;
					case 4:
						goto IL_17C;
					case 5:
						goto IL_2E6;
					case 6:
						fileAttributes &= ~global::System.IO.FileAttributes.ReadOnly;
						global::System.IO.File.SetAttributes(this.o, fileAttributes);
						num = (short)309460995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (global::CommonUtility.BundleNameUtility.IsBBFFile(this.o))
						{
							num = (short)398786572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(this.d, A_0, this.a);
						num = (short)425590808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!global::CommonUtility.BundleNameUtility.IsMegaBundle(this.d.GetFileTargetModelNumberForBBF()))
						{
							num = (short)1811611670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.d = this.a(this.d, text, A_0, this.a);
						num = (short)672727069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_4A8;
					case 10:
						num = (short)937623567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (global::System.IO.File.Exists(A_0))
						{
							num = (short)45088770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_682;
					case 12:
					{
						bool flag = false;
						num = (short)2052128785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (this.d == null)
						{
							num = (short)1572864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17C;
					case 14:
						global::System.IO.File.Delete(this.o);
						num = (short)1252458517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						string extension;
						if (!global::CommonUtility.BundleNameUtility.IsCVNFile(extension))
						{
							num = (short)1200160773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124;
					}
					case 16:
					{
						bool flag;
						if (!flag)
						{
							num = (short)606601225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1767178248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						bool flag2 = this.d.verifyBBFMagicNumber();
						if (flag2)
						{
							bool flag = this.d.verifyChecksum();
						}
						if (flag2)
						{
							num = (short)2142699545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_544;
					}
					case 18:
					{
						string extension;
						if (!global::CommonUtility.BundleNameUtility.IsBBFFile(extension))
						{
							num = (short)467402762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124;
					}
					case 19:
						goto IL_17A;
					case 20:
						if ((fileAttributes & global::System.IO.FileAttributes.ReadOnly) == global::System.IO.FileAttributes.ReadOnly)
						{
							num = (short)1773010950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_431;
					case 21:
						goto IL_1F9;
					case 22:
						goto IL_3E3;
					case 23:
					{
						if (!global::System.IO.Directory.Exists(text))
						{
							num = (short)1110573075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num4 = (ushort)new global::System.Random().Next(0, 65535);
						string extension2 = global::System.IO.Path.GetExtension(A_0);
						string path = num4.ToString() + extension2;
						this.o = global::System.IO.Path.Combine(text, path);
						num = (short)1637679132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						num = (short)469760413;
						short num5 = num;
						num = (short)479132061;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13F;
						default:
							goto IL_5BD;
						}
						break;
					}
					case 25:
						num = (short)1806696464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_114;
					case 27:
						num = (short)529268737;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_EC;
						}
						continue;
					case 28:
						if (global::System.IO.File.Exists(this.o))
						{
							num = (short)1290797070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F9;
					case 29:
						if (global::CommonUtility.BundleNameUtility.IsBBFFile(this.d.UpgradeFilePath))
						{
							num = (short)229834753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_356;
					}
					IL_EC:
					if (string.IsNullOrEmpty(this.a))
					{
						num = (short)1424621594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1790050315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13F:
					num = (short)628097047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_124:
					text = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb95쾟캡얣瘟\udaa9풫톯\udfb1\uddb3\udab5솷惡鲿臁ꯃꯅꗇꗉꋋ", a_));
					goto IL_13F;
					IL_17C:
					num = (short)696123399;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F9:
					global::System.IO.File.Copy(A_0, this.o);
					fileAttributes = global::System.IO.File.GetAttributes(this.o);
					num = (short)2134245396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_431:
					num = (short)775225357;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_114:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_validate_upgrade_file);
				IL_17A:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Upgrade_Folder_Not_Exist);
				IL_2E6:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFinvftp);
				IL_356:
				this.a(this.d, A_0, this.a);
				return;
				IL_3E3:
				this.b(this.d, A_0, this.a);
				return;
				IL_4A8:
				goto IL_544;
				IL_53F:
				this.b(this.d, A_0, this.a);
				return;
				IL_544:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFcanv.AcpStringFormat(new object[]
				{
					A_0
				}));
				IL_5BD:
				num = (short)530251776;
				if (num != 0)
				{
				}
				return;
				IL_682:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFdne);
			}
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00128914 File Offset: 0x00126B14
		private global::SpecialFeatures.Flashport.FlashportUpgradeFile a(global::SpecialFeatures.Flashport.FlashportUpgradeFile A_0, string A_1, string A_2, string A_3)
		{
			int a_ = 3;
			short num = (short)70123520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A7;
				}
				string text;
				for (;;)
				{
					IL_30:
					bool flag;
					global::System.Collections.Generic.Dictionary<string, byte[]> dictionary;
					switch (num2)
					{
					case 0:
						num = (short)1034616853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (text[0] != 'H')
						{
							num = (short)743702536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43B;
					case 2:
						if (flag)
						{
							num = (short)1672019969;
							if (num != 0)
							{
							}
							num = (short)689176593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A7;
					case 3:
						num = (short)786759706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_210;
					case 5:
						goto IL_132;
					case 6:
						if (text[0] == 'H')
						{
							num = (short)1187184653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A7;
					case 7:
						dictionary = A_0.GetTargetSectionsData(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺏ", a_));
						num = (short)1748041740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						dictionary = A_0.GetTargetSectionsData(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("黎ﾏ", a_));
						num = (short)1414856727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (dictionary != null)
						{
							num = (short)1190264832;
							short num3 = num;
							num = (short)1043857408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AA;
					case 10:
						if (!flag)
						{
							num = (short)1175453699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_210;
					case 11:
						num = (short)1585643547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_210;
					case 13:
						dictionary = A_0.GetTargetSectionsData(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("黎ﺍﾏ", a_));
						num = (short)2046623748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (flag)
						{
							num = (short)1430519828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43B;
					case 15:
						goto IL_4F3;
					case 16:
						if (!flag)
						{
							num = (short)1835859979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
					case 17:
						num = (short)523173894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_1C7;
					case 19:
						goto IL_210;
					case 20:
						num = (short)536936449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						if (dictionary.Keys.Count != 1)
						{
							num = (short)788594693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.Dictionary<string, byte[]>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator();
						num = (short)1692139538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						dictionary = A_0.GetTargetSectionsData(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺏ", a_));
						num = (short)78315539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_210;
					case 24:
						text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮅", a_) + text.Remove(0, 1);
						num = (short)1987837967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (text[0] != 'H')
						{
							num = (short)300351512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F3;
					case 26:
						if (text[0] != 'H')
						{
							num = (short)249167879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_210;
					case 27:
						if (text[0] == 'H')
						{
							num = (short)1797783574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
					}
					goto IL_A7;
					IL_137:
					num = (short)1065746442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_210:
					num = (short)1610088457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A7:
					num = (short)272171022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43B:
					num = (short)189792272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F3:
					dictionary = null;
					flag = global::ConstraintHelper.UtilityMack.IsFreonCodeplug(this.a);
					num = (short)1761935362;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_132:
				goto IL_5AA;
				IL_1C7:
				try
				{
					num = (short)703725570;
					num2 = (int)((global::System.IntPtr)num);
					global::SpecialFeatures.Flashport.FlashportUpgradeFile result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1584889911;
							short num4 = num;
							num = (short)1475313719;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3A3;
							default:
							{
								num = (short)1772093440;
								if (num != 0)
								{
								}
								global::System.Collections.Generic.Dictionary<string, byte[]>.KeyCollection.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1485438977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text2 = enumerator.Current;
								this.p = global::System.IO.Path.Combine(A_1, text2);
								global::System.Collections.Generic.Dictionary<string, byte[]> dictionary;
								global::System.IO.File.WriteAllBytes(this.p, dictionary[text2]);
								result = new global::SpecialFeatures.Flashport.FlashportUpgradeFile(this.p);
								num = (short)795738115;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							goto IL_3A3;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_31E;
							}
							continue;
						case 3:
							goto IL_3F4;
						case 4:
							goto IL_411;
						}
						IL_31E:
						num = (short)1846673408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A3:
						num = (short)985202692;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3F4:
					return result;
					IL_411:;
				}
				finally
				{
					global::System.Collections.Generic.Dictionary<string, byte[]>.KeyCollection.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFcanv.AcpStringFormat(new object[]
				{
					A_2
				}));
				IL_5AA:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFcanv.AcpStringFormat(new object[]
				{
					A_2
				}));
				IL_A7:
				text = A_3;
				num = (short)1183580185;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00128FAC File Offset: 0x001271AC
		private void b(global::SpecialFeatures.Flashport.FlashportUpgradeFile A_0, string A_1, string A_2)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			int num;
			short num2;
			bool flag2;
			for (;;)
			{
				IL_13:
				bool flag;
				switch (num)
				{
				case 0:
					goto IL_1D9;
				case 1:
					num2 = (short)1349517316;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)697630738;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					string text;
					if (text[0] != 'H')
					{
						num2 = (short)167641089;
						if (num2 != 0)
						{
						}
						num2 = (short)1440284687;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CF;
				}
				case 4:
				{
					if (!flag)
					{
						num2 = (short)7667720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string text = A_2;
					num2 = (short)553910275;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (!flag2)
					{
						num2 = (short)391315458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A7;
				case 6:
					goto IL_CF;
				case 7:
					num2 = (short)1564868619;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)1753172851;
					short num3 = num2;
					num2 = (short)101927795;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3C2;
					default:
						goto IL_305;
					}
					break;
				}
				case 9:
				{
					string text;
					if (!A_0.CheckFileDestinatioInfoValidForBBF(text))
					{
						goto IL_3C2;
					}
					return;
				}
				case 10:
				{
					bool flag3 = A_0.verifyBBFMagicNumber();
					if (flag3)
					{
						flag = A_0.verifyChecksum();
					}
					if (flag3)
					{
						num2 = (short)1673330689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_388;
				}
				case 11:
					if (global::CommonUtility.BundleNameUtility.IsBBFFile(global::System.IO.Path.GetExtension(A_0.UpgradeFilePath)))
					{
						num2 = (short)736296976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D9;
				case 12:
					goto IL_1F1;
				case 13:
					num2 = (short)1539506185;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (flag2)
					{
						num2 = (short)1239154695;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_151;
				case 15:
				{
					string text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb95", a_) + text.Remove(0, 1);
					num2 = (short)102825990;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 16:
					goto IL_151;
				case 17:
					goto IL_3D9;
				case 18:
					if (!global::CommonUtility.BundleNameUtility.IsCVNFile(global::System.IO.Path.GetExtension(A_0.UpgradeFilePath)))
					{
						num2 = (short)1917517824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A7;
				case 19:
					if (global::CommonUtility.BundleNameUtility.IsBBFBundle(A_0.GetFileTargetModelNumberForBBF()))
					{
						num2 = (short)1588330509;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1CE;
				}
				goto IL_69;
				IL_A7:
				flag = false;
				num2 = (short)1500577802;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_CF:
				num2 = (short)1730281491;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_151:
				num2 = (short)1927282693;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1D9:
				num2 = (short)372572172;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3C2:
				num2 = (short)1813643281;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1CE:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFinvftp);
			IL_1F1:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFinvftp);
			IL_305:
			num2 = (short)1065091072;
			if (num2 != 0)
			{
			}
			IL_388:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFcanv.AcpStringFormat(new object[]
			{
				A_1
			}));
			IL_3D9:
			num2 = (short)1573847040;
			short num4 = num2;
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFinvftp);
			IL_69:
			flag2 = global::ConstraintHelper.UtilityMack.IsFreonCodeplug(A_2);
			num2 = (short)1035141134;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00129398 File Offset: 0x00127598
		private void a(global::SpecialFeatures.Flashport.FlashportUpgradeFile A_0, string A_1, string A_2)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_5D;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)792022123;
					short num3 = num2;
					num2 = (short)659180651;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DC;
					default:
						num2 = (short)1031995392;
						if (num2 != 0)
						{
						}
						num2 = (short)1443692548;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					if (!A_0.CheckFileContentsValid())
					{
						num2 = (short)1281818638;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)849018880;
					short num4 = num2;
					string text = A_2;
					num2 = (short)1491861513;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					string text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즃", a_) + text.Remove(0, 1);
					num2 = (short)284491792;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_120;
				case 4:
					if (global::CommonUtility.BundleNameUtility.IsBBFFile(global::System.IO.Path.GetExtension(A_0.UpgradeFilePath)))
					{
						num2 = (short)1968635914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_36A;
				case 5:
					num2 = (short)987430913;
					if (num2 != 0)
					{
					}
					if (A_0.OpenUpgradeFile())
					{
						num2 = (short)1824522255;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D7;
				case 6:
				{
					string text;
					if (!A_0.CheckFileDestinatioInfoValid(text))
					{
						num2 = (short)1325596679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 7:
					goto IL_326;
				case 8:
					if (!flag)
					{
						num2 = (short)2063204365;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F1;
				case 9:
				{
					string text;
					if (text[0] != 'H')
					{
						num2 = (short)1063452674;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2ED;
				}
				case 10:
					goto IL_130;
				case 11:
					if (flag)
					{
						num2 = (short)809828352;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_130;
				case 12:
					if (!global::CommonUtility.BundleNameUtility.IsCVNFile(global::System.IO.Path.GetExtension(A_0.UpgradeFilePath)))
					{
						num2 = (short)87687171;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F1;
				case 13:
					goto IL_DC;
				case 14:
					goto IL_365;
				case 15:
					num2 = (short)1645805569;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_2ED;
				}
				goto IL_5D;
				IL_DC:
				num2 = (short)1318191116;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_130:
				num2 = (short)290324488;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F1:
				num2 = (short)115081221;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2ED:
				num2 = (short)1976958982;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_120:
			goto IL_36A;
			IL_1D7:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
			{
				A_1
			}));
			IL_326:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFinvftp);
			IL_365:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFcanv);
			IL_36A:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.UpgradeRadio_UFinvftp);
			IL_5D:
			flag = global::ConstraintHelper.UtilityMack.IsFreonCodeplug(A_2);
			num2 = (short)1884225547;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0012971C File Offset: 0x0012791C
		private bool l()
		{
			int a_ = 3;
			short num = (short)1043294971;
			short num2 = num;
			num = (short)1902078715;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1794965504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)583598081;
			if (num != 0)
			{
			}
			num = (short)357957632;
			if (num != 0)
			{
			}
			return this.k.HostVersion.Substring(1, this.k.HostVersion.Length - 1).CompareTo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풅릇뾉ꊋ뺍ꂏ벑꒓ꚕ", a_).Substring(1, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풅릇뾉ꊋ뺍ꂏ벑꒓ꚕ", a_).Length - 1)) >= 0;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00129824 File Offset: 0x00127A24
		private void c(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0)
		{
			short num;
			try
			{
				num = (short)2050791004;
				short num2 = num;
				num = (short)1982043740;
				switch (num2 == num)
				{
				}
				num = (short)812318720;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				pbaObject.SetCodeplug(A_0);
				pbaObject.CodeplugData.CPVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
				pbaObject.UpdateData = this.j();
				this.l.UpdateDevice(this.k, pbaObject, new global::System.ComponentModel.ProgressChangedEventHandler(this.g.UpdateRadioProgress));
				global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData = pbaObject.UpdateData;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Radio_Update_Failed);
			}
			num = (short)82706433;
			if (num != 0)
			{
			}
			num = (short)1138229248;
			short num3 = num;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00129940 File Offset: 0x00127B40
		private void b(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0)
		{
			short num;
			try
			{
				num = (short)1843670727;
				short num2 = num;
				num = (short)1807232711;
				switch (num2 == num)
				{
				}
				num = (short)761200640;
				if (num != 0)
				{
				}
				num = (short)1888878593;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				pbaObject.SetCodeplug(A_0);
				pbaObject.CodeplugData.CPVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
				pbaObject.UpdateData = this.j();
				this.z = pbaObject;
				global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData = pbaObject.UpdateData;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Radio_Update_Failed);
			}
			num = (short)920977408;
			short num3 = num;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00129A40 File Offset: 0x00127C40
		private void a(ref string A_0)
		{
			int value = (global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu).Advanced.DispMenuAdvancedLanguageSelection_A8386.Value;
			short num;
			try
			{
				num = (short)392298508;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1E5;
					case 1:
						if (global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.IsRadioUpgradeHostGreaterThan_7_12(this.k.HostVersion, this.fileHostVersion))
						{
							num = (short)15007746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC;
					case 2:
					{
						global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.BuildWriteLanguageData(this.k.HostVersion, true);
						num = (short)226295817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_348;
					case 4:
						num = (short)569769994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1148321793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_348;
					case 7:
					{
						num = (short)1872916047;
						short num3 = num;
						num = (short)781020751;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_360;
						default:
							num = (short)705232896;
							if (num != 0)
							{
							}
							A_0 = global::CommonResources.AppResources.LP_Write_Radio_After_Flashport_To_Update_Language_Pack;
							num = (short)1405353997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_360;
					case 9:
					{
						global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData;
						languagePackData.ModelType = (global::ConstraintHelper.UtilityMack.IsPortablePro ? global::Motorola.Common.Communication.CommonUtil.ModelType.Portable : global::Motorola.Common.Communication.CommonUtil.ModelType.Mobile);
						this.l.WriteLanguagePack(this.k, languagePackData, new global::System.ComponentModel.ProgressChangedEventHandler(this.g.UpdateRadioProgress));
						A_0 = global::CommonResources.AppResources.LP_Language_Pack_Update_Success;
						num = (short)1447493635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (string.IsNullOrEmpty(this.k.HostVersion))
						{
							num = (short)2024341504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2069299216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.IsRadioUpgradeHostLessThan_7_12(this.k.HostVersion, this.fileHostVersion))
						{
							num = (short)1420689415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_177;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					case 13:
						goto IL_348;
					case 14:
						goto IL_348;
					case 15:
						num = (short)956235787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (value != 0)
						{
							num = (short)1572732933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC;
					case 17:
						if (value != 0)
						{
							num = (short)1339686927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_177;
					}
					IL_93:
					if (!string.IsNullOrEmpty(this.fileHostVersion))
					{
						num = (short)430833668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E5;
					IL_BC:
					num = (short)984743953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_177:
					A_0 = global::CommonResources.AppResources.LP_No_Language_Pack_Update_Needed;
					num = (short)164233230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E5:
					A_0 = global::CommonResources.AppResources.LP_Cannot_Determine_Host_Version;
					num = (short)832438278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_348:
					num = (short)125632520;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_360:;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.LP_Error_Updating_Language_Pack);
			}
			num = (short)1962868736;
			short num4 = num;
			num = (short)26017793;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00129E28 File Offset: 0x00128028
		private void a(string A_0)
		{
			short num;
			try
			{
				num = (short)1122631685;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)423100418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						for (;;)
						{
							global::System.IO.File.Delete(A_0);
							num = (short)441996212;
							short num3 = num;
							num = (short)116151220;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_93;
							}
						}
						IL_93:
						num = (short)323616768;
						if (num != 0)
						{
						}
						num = (short)506134531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (global::System.IO.File.Exists(A_0))
						{
							num = (short)1807810561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC;
					case 3:
						goto IL_FC;
					case 4:
						goto IL_113;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					}
					IL_3C:
					if (A_0 != null)
					{
						num = (short)1828782080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_FC:
					num = (short)123011076;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_113:;
			}
			catch (global::System.Exception)
			{
			}
			num = (short)214106113;
			if (num != 0)
			{
			}
			num = (short)248184832;
			short num4 = num;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00129FBC File Offset: 0x001281BC
		private void k()
		{
			short num;
			try
			{
				num = (short)412286979;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_D1;
					case 1:
						this.l.ValidateUpdate(this.k, null);
						num = (short)371392512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_E8;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_36;
						}
						continue;
					}
					IL_36:
					if (this.k != null)
					{
						num = (short)36602231;
						short num3 = num;
						num = (short)666206583;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)2003828736;
							if (num != 0)
							{
							}
							num = (short)1239285761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
					}
					IL_D1:
					num = (short)1410334722;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E8:;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Validation_Failed);
			}
			num = (short)208994305;
			if (num != 0)
			{
			}
			num = (short)993984512;
			short num4 = num;
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0012A120 File Offset: 0x00128320
		private global::Motorola.Common.Communication.Pba.UpdateDeviceData j()
		{
			int a_ = 0;
			short num = (short)1594294272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				global::Motorola.Common.Communication.Pba.UpdateDeviceData updateDeviceData;
				for (;;)
				{
					IL_30:
					num = (short)1517813761;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1417936896;
						short num3 = num;
						string empty = string.Empty;
						string radioBBFSuiteVersion = this.k.RadioBBFSuiteVersion;
						num = (short)268304386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage item = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHTOFILESYSTEM, this.d.UpgradeFilePath);
						updateDeviceData.MemoryImages.Add(item);
						num = (short)1878261764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						string radioBBFSuiteVersion;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(this.d.GetBBFSuiteVersion(), radioBBFSuiteVersion) > 0)
						{
							num = (short)829620225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return updateDeviceData;
					}
					case 3:
						try
						{
							num = (short)1679818781;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string version5;
								string version6;
								string componentName;
								string componentName2;
								string componentName3;
								string componentName4;
								bool flag2;
								switch (num2)
								{
								case 0:
									goto IL_766;
								case 1:
								{
									bool flag = this.d.ComponentPresent(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮂쎄킆\uda88", a_));
									string text = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮂쎄킆좈", a_), true);
									string version = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잂쎄킆좈", a_), true);
									string text2 = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삂쎄킆삈", a_), true);
									string version2 = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펂솄펆좈", a_), true);
									string version3 = string.Empty;
									string version4 = string.Empty;
									version5 = string.Empty;
									version6 = string.Empty;
									string empty2 = string.Empty;
									string empty3 = string.Empty;
									string empty4 = string.Empty;
									componentName = string.Empty;
									componentName2 = string.Empty;
									componentName3 = string.Empty;
									componentName4 = string.Empty;
									global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캂力쾒풔\udd9aﲜ좠쾢\udca4令\udeb0\udeb2\ud8b4\ud8b6ힸ", a_));
									new global::System.Random().Next(0, 65535);
									if (flag)
									{
										num = (short)1337982979;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.r = false;
									num = (short)1835597829;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									string version;
									string version4;
									if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(version4, version) <= 0)
									{
										num = (short)192544789;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_22E;
								}
								case 3:
								{
									this.r = true;
									string version3 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮂쎄킆\uda88", a_), true);
									string version4 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잂쎄킆춈", a_), true);
									componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮂쎄킆\uda88", a_);
									componentName2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잂쎄킆춈", a_);
									num = (short)654573591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1063124993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									string text;
									if (text.Substring(1, 2) == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뎂뒄", a_))
									{
										num = (short)1098579990;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string version3 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮂쎄킆쪈", a_), true);
									string version4 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잂쎄킆쪈", a_), true);
									componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮂쎄킆쪈", a_);
									componentName2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잂쎄킆쪈", a_);
									num = (short)543424519;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1974599689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_379;
								case 8:
									goto IL_379;
								case 9:
								{
									string version2;
									if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(version6, version2) > 0)
									{
										num = (short)1842675727;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_766;
								}
								case 10:
								{
									global::Motorola.Common.Communication.Pba.AstroMemoryImage item2 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST, this.d.UpgradeFilePath, componentName);
									updateDeviceData.MemoryImages.Add(item2);
									global::Motorola.Common.Communication.Pba.AstroMemoryImage item3 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP, this.d.UpgradeFilePath, componentName2);
									updateDeviceData.MemoryImages.Add(item3);
									num = (short)1537802251;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									goto IL_766;
								case 12:
								{
									string text2;
									if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(version5, text2) > 0)
									{
										num = (short)325779482;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8C3;
								}
								case 13:
									num = (short)2107441164;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									string empty3;
									if (this.IsConsoletteBoardFlashUpdateNeeded(ref empty3))
									{
										num = (short)995885073;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)85458969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									goto IL_22E;
								case 16:
								{
									string text2;
									if (!string.IsNullOrEmpty(text2))
									{
										num = (short)1263337485;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8C3;
								}
								case 17:
								{
									string empty3;
									global::Motorola.Common.Communication.Pba.AstroMemoryImage item4 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY, this.d.UpgradeFilePath, empty3);
									updateDeviceData.MemoryImages.Add(item4);
									num = (short)175702040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
								{
									string empty2;
									global::Motorola.Common.Communication.Pba.AstroMemoryImage item5 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION, this.d.UpgradeFilePath, empty2);
									updateDeviceData.MemoryImages.Add(item5);
									num = (short)158990356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
								{
									string empty2;
									if (this.IsOptionBoardFlashUpdateNeeded(ref empty2, ref flag2))
									{
										num = (short)1767047186;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_312;
								}
								case 20:
									goto IL_312;
								case 21:
									num = (short)1975582747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
								{
									string version3 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮂쎄킆좈", a_), true);
									string version4 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잂쎄킆좈", a_), true);
									componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮂쎄킆좈", a_);
									componentName2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잂쎄킆좈", a_);
									num = (short)1881473032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
								{
									num = (short)545497305;
									short num4 = num;
									num = (short)849912025;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_792;
									default:
									{
										num = (short)992083968;
										if (num != 0)
										{
										}
										string text;
										string version3;
										if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(version3, text) > 0)
										{
											num = (short)1623457802;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_766;
									}
									}
									break;
								}
								case 24:
									goto IL_229;
								case 25:
									goto IL_925;
								case 26:
								{
									global::Motorola.Common.Communication.Pba.AstroMemoryImage item6 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE, this.d.UpgradeFilePath, componentName3);
									updateDeviceData.MemoryImages.Add(item6);
									num = (short)859766812;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 27:
								{
									string text;
									string version3;
									if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(version3, text) <= 0)
									{
										num = (short)1396572166;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_22E;
								}
								case 28:
									goto IL_8C3;
								case 29:
									switch (0)
									{
									case 0:
										goto IL_181;
									}
									continue;
								}
								IL_181:
								if (this.d.OpenUpgradeFile())
								{
									num = (short)774897668;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_355;
								IL_22E:
								global::Motorola.Common.Communication.Pba.AstroMemoryImage item7 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST, this.d.UpgradeFilePath, componentName);
								updateDeviceData.MemoryImages.Add(item7);
								global::Motorola.Common.Communication.Pba.AstroMemoryImage item8 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP, this.d.UpgradeFilePath, componentName2);
								updateDeviceData.MemoryImages.Add(item8);
								global::Motorola.Common.Communication.Pba.AstroMemoryImage item9 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT, this.d.UpgradeFilePath, componentName4);
								updateDeviceData.MemoryImages.Add(item9);
								num = (short)1764491264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_312:
								num = (short)66912270;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_379:
								version6 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펂솄펆좈", a_), true);
								componentName4 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펂솄펆좈", a_);
								num = (short)572063746;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_792:
								num = (short)31129616;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_766:
								version5 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삂쎄킆삈", a_), true);
								componentName3 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삂쎄킆삈", a_);
								goto IL_792;
								IL_8C3:
								flag2 = true;
								num = (short)1176502291;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_229:
							return updateDeviceData;
							IL_355:
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
							{
								this.d.UpgradeFilePath
							}));
							IL_925:
							return updateDeviceData;
						}
						finally
						{
							this.d = null;
							global::System.GC.Collect();
						}
						goto IL_937;
					case 4:
						return updateDeviceData;
					case 5:
						if (this.t)
						{
							num = (short)1520369664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_937;
					}
					goto IL_76;
					IL_937:
					num = (short)1006501891;
					num2 = (int)((global::System.IntPtr)num);
				}
				return updateDeviceData;
				IL_76:
				updateDeviceData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
				num = (short)1809973253;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0012AB3C File Offset: 0x00128D3C
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData BuildUpdateDataForCruncher(out global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo updatedDeviceInfo)
		{
			int a_ = 19;
			short num = (short)1394868224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_14F;
				}
				global::Motorola.Common.Communication.Pba.UpdateDeviceData updateDeviceData;
				global::System.IO.MemoryStream memoryStream;
				for (;;)
				{
					IL_30:
					string softwareVersion;
					string text;
					string componentName;
					string componentName2;
					string text4;
					string dspVersion;
					string psdtVersion;
					int? hfwsFlag;
					int num4;
					string componentName3;
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(this.y))
						{
							num = (short)1726218283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						updateDeviceData = null;
						num = (short)1990590492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						string maceFlashVersion;
						string maceFlashVersion2;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(maceFlashVersion, maceFlashVersion2) > 0)
						{
							num = (short)678101027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79E;
					}
					case 2:
						goto IL_1B6;
					case 3:
					{
						string softwareVersion2;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(softwareVersion, softwareVersion2) <= 0)
						{
							num = (short)729939989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A6F;
					}
					case 4:
						if (string.IsNullOrEmpty(this.w.OptionBoardHardwareType))
						{
							num = (short)485949440;
							short num3 = num;
							num = (short)1531052087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 5:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1587871766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DA;
					case 6:
					{
						string lteoptBrdHwHostVersion;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(lteoptBrdHwHostVersion, text) > 0)
						{
							num = (short)243400751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EE1;
					}
					case 7:
					{
						string text2;
						if (text2 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud995\uda97ꪙ꺛", a_))
						{
							num = (short)766050364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EE1;
					}
					case 8:
						if (!this.w.OptionBoardHardwareNotPresentFlag)
						{
							num = (short)869990452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 9:
					{
						string text2;
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)767361065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EE1;
					}
					case 10:
						if (!string.IsNullOrEmpty(this.w.ConsoletteBoardHardwareType))
						{
							num = (short)1379598349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E1;
					case 11:
						return updateDeviceData;
					case 12:
					{
						string text2 = this.w.OptionBoardHardwareType;
						num = (short)987562022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						string text3 = this.w.ConsoletteBoardHardwareType;
						num = (short)1695088655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95\ude97춙\udd9b", a_);
						componentName2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튕\ude97춙\udd9b", a_);
						num = (short)216989733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_7E1;
					case 16:
						if (text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕횗쪙캛톝", a_))
						{
							num = (short)924123199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_172;
					case 17:
						if (!string.IsNullOrEmpty(text4))
						{
							num = (short)1891565634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_66C;
					case 18:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage item = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST, this.y, componentName);
						updateDeviceData.MemoryImages.Add(item);
						updatedDeviceInfo.SoftwareVersion = softwareVersion;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage item2 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP, this.y, componentName2);
						updateDeviceData.MemoryImages.Add(item2);
						updatedDeviceInfo.DspVersion = dspVersion;
						num = (short)1337589821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_172;
					case 20:
					{
						string text2;
						if (text2 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud995\uda97ꪙ궛", a_))
						{
							num = (short)1002373185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1081737223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						num = (short)1974665242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)1713504272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						string dspVersion2;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(dspVersion, dspVersion2) <= 0)
						{
							num = (short)1830223939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A6F;
					}
					case 24:
						num = (short)543752193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						string text3;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage item3 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY, this.y, text3);
						updateDeviceData.MemoryImages.Add(item3);
						string conBrdHwHostVersion;
						updatedDeviceInfo.ConsoletteBoardHardwareHostVersion = conBrdHwHostVersion;
						num = (short)485425206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						string psdtVersion2;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(psdtVersion, psdtVersion2) > 0)
						{
							num = (short)597295149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					}
					case 27:
					{
						if (this.IsRadioTakesBBF)
						{
							num = (short)1220739108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string softwareVersion2 = this.w.SoftwareVersion;
						string dspVersion2 = this.w.DspVersion;
						string maceFlashVersion2 = this.w.MaceFlashVersion;
						string psdtVersion2 = this.w.PsdtVersion;
						text = this.w.OptionBoardHardwareHostVersion;
						text4 = this.w.ConsoletteBoardHardwareHostVersion;
						string optionBoardHardwareType = this.w.OptionBoardHardwareType;
						string consoletteBoardHardwareType = this.w.ConsoletteBoardHardwareType;
						softwareVersion = this.x.SoftwareVersion;
						dspVersion = this.x.DspVersion;
						string maceFlashVersion = this.x.MaceFlashVersion;
						psdtVersion = this.x.PsdtVersion;
						string optBrdHwHostVersion = this.x.OptBrdHwHostVersion;
						string lteoptBrdHwHostVersion = this.x.LTEOptBrdHwHostVersion;
						string conBrdHwHostVersion = this.x.ConBrdHwHostVersion;
						string text2 = string.Empty;
						string text3 = string.Empty;
						num = (short)838729736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						return updateDeviceData;
					case 29:
						num = (short)401473594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						string maceFlashVersion2;
						if (!string.IsNullOrEmpty(maceFlashVersion2))
						{
							num = (short)543948824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79E;
					}
					case 31:
						if (!(hfwsFlag.GetValueOrDefault() == num4 & hfwsFlag != null))
						{
							num = (short)2125332522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1474822178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						string optBrdHwHostVersion;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(optBrdHwHostVersion, text) > 0)
						{
							num = (short)1090584616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EE1;
					}
					case 33:
						goto IL_308;
					case 34:
					{
						string softwareVersion2;
						if (softwareVersion2.Substring(1, 2) == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚕꦗ", a_))
						{
							num = (short)1945108494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95\ude97춙\udf9b", a_);
						componentName2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튕\ude97춙\udf9b", a_);
						num = (short)1235157031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage item4 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE, this.y, componentName3);
						updateDeviceData.MemoryImages.Add(item4);
						string maceFlashVersion;
						updatedDeviceInfo.MaceFlashVersion = maceFlashVersion;
						updatedDeviceInfo.MaceSecureHardwareVersion = maceFlashVersion;
						num = (short)467402808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
					{
						string version = string.Empty;
						string empty = string.Empty;
						string radioBBFSuiteVersion = this.w.RadioBBFSuiteVersion;
						string softwareVersion3 = this.w.SoftwareVersion;
						version = this.x.BPSoftwareVersion;
						num = (short)42270779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						goto IL_B46;
					case 38:
						goto IL_622;
					case 39:
						goto IL_B46;
					case 40:
					{
						string text2;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage item5 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION, this.y, text2);
						updateDeviceData.MemoryImages.Add(item5);
						string optBrdHwHostVersion;
						updatedDeviceInfo.OptionBoardHardwareHostVersion = optBrdHwHostVersion;
						num = (short)499777593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						num = (short)1850212372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95\ude97춙쾛", a_);
						componentName2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튕\ude97춙\ud89b", a_);
						num = (short)719585328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num = (short)861732891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
					{
						string text3;
						if (!string.IsNullOrEmpty(text3))
						{
							num = (short)418906137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return updateDeviceData;
					}
					case 45:
						goto IL_A6F;
					case 46:
						goto IL_EE1;
					case 47:
					{
						string text2;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage item6 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION, this.y, text2);
						updateDeviceData.MemoryImages.Add(item6);
						num = (short)526581806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
					{
						string softwareVersion2;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(softwareVersion, softwareVersion2) > 0)
						{
							num = (short)415891474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					}
					case 49:
						num = (short)313655340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
					{
						string conBrdHwHostVersion;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(conBrdHwHostVersion, text4) > 0)
						{
							num = (short)2014183473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return updateDeviceData;
					}
					case 51:
						goto IL_66C;
					case 52:
						goto IL_573;
					case 53:
						if (!this.w.OptionBoardHardwareNotPresentFlag)
						{
							num = (short)367525900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_622;
					case 54:
						return updateDeviceData;
					case 55:
					{
						string text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud995\uda97ꪙ궛", a_);
						num = (short)460521540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						goto IL_79E;
					case 57:
						goto IL_EE1;
					case 58:
					{
						string version;
						string radioBBFSuiteVersion;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(version, radioBBFSuiteVersion) > 0)
						{
							num = (short)231145536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return updateDeviceData;
					}
					case 59:
					{
						string softwareVersion3;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(this.x.SoftwareVersion, softwareVersion3) <= 0)
						{
							num = (short)1815543837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E8;
					}
					case 60:
						num = (short)1100349446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						goto IL_1B6;
					case 62:
						if (text4 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕횗쪙캛톝", a_))
						{
							num = (short)1139802163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					case 63:
						goto IL_2DA;
					case 64:
						goto IL_5E8;
					case 65:
						num = (short)2041511968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						num = (short)976683070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)1467416579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_622;
					case 69:
						try
						{
							global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
							binaryFormatter.Serialize(memoryStream, this.w);
							memoryStream.Position = 0L;
							updatedDeviceInfo = (binaryFormatter.Deserialize(memoryStream) as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo);
							goto IL_CB0;
						}
						finally
						{
							num = (short)69074944;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4E8;
									}
									continue;
								case 1:
									goto IL_570;
								case 2:
								{
									num = (short)142234648;
									short num5 = num;
									num = (short)1240028184;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)768999424;
										if (num != 0)
										{
										}
										((global::System.IDisposable)memoryStream).Dispose();
										num = (short)1902182401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_4E8:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)181010434;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_570:;
						}
						goto IL_573;
						IL_CB0:
						updateDeviceData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
						num = (short)1987969024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
					IL_172:
					num = (short)369295369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B6:
					componentName3 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햕\ude97춙햛", a_);
					num = (short)471793665;
					if (num != 0)
					{
					}
					num = (short)1252261918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DA:
					text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒕ꢗꪙ늛꺝邟財钣隥", a_);
					num = (short)2036072467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_308:
					num = (short)1436876850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_396:
					num = (short)599654453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_573:
					num = (short)1329463300;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E8:
					global::Motorola.Common.Communication.Pba.AstroMemoryImage item7 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHTOFILESYSTEM, this.y);
					updateDeviceData.MemoryImages.Add(item7);
					num = (short)618921995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_622:
					num = (short)30474250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66C:
					text4 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒕ꢗꪙ늛꺝邟財钣隥", a_);
					num = (short)674496545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_79E:
					num = (short)1464139781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E1:
					componentName = string.Empty;
					componentName2 = string.Empty;
					componentName3 = string.Empty;
					string componentName4 = string.Empty;
					hfwsFlag = this.x.HfwsFlag;
					num4 = 0;
					num = (short)1794703391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A6F:
					global::Motorola.Common.Communication.Pba.AstroMemoryImage item8 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST, this.y, componentName);
					updateDeviceData.MemoryImages.Add(item8);
					updatedDeviceInfo.SoftwareVersion = softwareVersion;
					global::Motorola.Common.Communication.Pba.AstroMemoryImage item9 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP, this.y, componentName2);
					updateDeviceData.MemoryImages.Add(item9);
					updatedDeviceInfo.DspVersion = dspVersion;
					global::Motorola.Common.Communication.Pba.AstroMemoryImage item10 = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT, this.y, componentName4);
					updateDeviceData.MemoryImages.Add(item10);
					updatedDeviceInfo.PsdtVersion = psdtVersion;
					num = (short)370671618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B46:
					componentName4 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕\udc97캙\udd9b", a_);
					num = (short)1279721495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EE1:
					num = (short)841941009;
					num2 = (int)((global::System.IntPtr)num);
				}
				return updateDeviceData;
				IL_14F:
				memoryStream = new global::System.IO.MemoryStream();
				num = (short)308740165;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0012BACC File Offset: 0x00129CCC
		public void Connect()
		{
			short num;
			try
			{
				num = (short)1951709619;
				short num2 = num;
				num = (short)40417715;
				switch (num2 == num)
				{
				}
				num = (short)1160577025;
				if (num != 0)
				{
				}
				num = (short)638386176;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Comms.RadioParams radioParams = new global::SpecialFeatures.Comms.RadioParams();
				radioParams.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
				radioParams.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
				radioParams.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter;
				this.l = global::SpecialFeatures.Comms.DeviceManagerSingleTon.Instance.CreateDeviceProxy(radioParams, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Connect_Failed);
			}
			num = (short)1315438592;
			short num3 = num;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0012BBCC File Offset: 0x00129DCC
		public void BeginFlashUpgrade()
		{
			short num;
			try
			{
				num = (short)2137794705;
				short num2 = num;
				num = (short)1205217425;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1302921216;
					if (num != 0)
					{
					}
					num = (short)1491861504;
					num3 = (int)num;
					switch (num3)
					{
					}
					break;
				}
				switch (0)
				{
				case 0:
					goto IL_A0;
				}
				string codeplugVersion;
				for (;;)
				{
					IL_71:
					switch (num3)
					{
					case 0:
						num = (short)54394881;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						string maceHardwareType;
						if (maceHardwareType == global::CommonResources.AppResources.Secure_Hardware_Type)
						{
							num = (short)1117454345;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20F;
					}
					case 2:
						goto IL_281;
					case 3:
					{
						string maceHardwareType;
						if (maceHardwareType != null)
						{
							num = (short)513409024;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20F;
					}
					case 4:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
						list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(212, 901, 0));
						global::Motorola.Common.Communication.Pba.PbaObject a_ = this.l.ReadBlock(this.k, list, null);
						this.a = this.k.ModelNumber;
						this.b = this.k.SerialNumber;
						this.c = this.a(this.a(a_));
						num = (short)600702983;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						string maceHardwareType = this.k.MaceHardwareType;
						num = (short)1323237379;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (this.k != null)
						{
							num = (short)484048901;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					case 7:
						goto IL_267;
					case 8:
						if (global::AcpBusinessLayer.AcpDocument.ValidCodeplugVersion(codeplugVersion))
						{
							num = (short)425721860;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12E;
					case 9:
						goto IL_129;
					}
					goto IL_A0;
					IL_20F:
					codeplugVersion = this.k.CodeplugVersion;
					num = (short)1748434952;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_267:
					num = (short)1058668546;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_129:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Flashport_Blocked_For_uMACE_Radio);
				IL_12E:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_flash_radio_Requires_CPS_version.AcpStringFormat(new object[]
				{
					codeplugVersion
				}));
				IL_281:
				goto IL_292;
				IL_A0:
				this.k = this.l.ReadExtendedDeviceInfo();
				num = (short)1954021382;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_71;
			}
			catch (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_read_radio_codeplug_parameters);
			}
			IL_292:
			num = (short)1791229953;
			if (num != 0)
			{
			}
			num = (short)1473904640;
			short num4 = num;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0012BEF0 File Offset: 0x0012A0F0
		private void i()
		{
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0012C074 File Offset: 0x0012A274
		private void h()
		{
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0012C288 File Offset: 0x0012A488
		private void g()
		{
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0012C3E8 File Offset: 0x0012A5E8
		private void f()
		{
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0012C4B0 File Offset: 0x0012A6B0
		private string e()
		{
			return "20231231FA01";
			try
			{
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Unable_to_get_valid_Flashkey_Id);
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0012C718 File Offset: 0x0012A918
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadCodeplug()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					try
					{
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
						switch (0)
						{
						case 0:
							break;
						default:
							for (;;)
							{
								IL_CB:
								switch (num)
								{
								case 0:
									if (pbaObject != null)
									{
										num2 = (short)814219267;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_1A2;
								case 1:
									goto IL_1BA;
								case 2:
									goto IL_1A2;
								case 3:
								{
									num2 = (short)1891244533;
									short num3 = num2;
									num2 = (short)280304117;
									switch ((num3 == num2) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_104;
									default:
										num2 = (short)1521090560;
										if (num2 != 0)
										{
										}
										ishItemCollection = pbaObject.GetCodeplugInIshItemCollection();
										num2 = (short)1799946242;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								}
								goto IL_E1;
								IL_1A2:
								num2 = (short)1805910017;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_1BA:
							goto IL_3B;
						}
						IL_E1:
						pbaObject = this.l.Read(this.k, new global::System.ComponentModel.ProgressChangedEventHandler(this.g.UpdateRadioProgress));
						IL_104:
						num2 = (short)592838656;
						num = (int)((global::System.IntPtr)num2);
						goto IL_CB;
					}
					catch (global::System.Exception)
					{
						throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_read_the_radio_codeplug);
					}
					goto IL_1CB;
					IL_3B:
					num2 = (short)1781858306;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_BC;
				case 2:
				{
					num2 = (short)407240704;
					short num4 = num2;
					num2 = (short)2094071809;
					if (num2 != 0)
					{
					}
					if (ishItemCollection == null)
					{
						num2 = (short)1830944769;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return ishItemCollection;
				}
				}
				goto IL_1C;
			}
			IL_BC:
			IL_1CB:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_read_the_radio_codeplug);
			IL_1C:
			ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			num2 = (short)5832704;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0012C90C File Offset: 0x0012AB0C
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadTestCodeplug()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (ishItemCollection == null)
					{
						num2 = (short)1403715586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_108;
				case 1:
				{
					try
					{
						ishItemCollection = this.z.GetCodeplugInIshItemCollection();
						goto IL_3B;
					}
					catch (global::System.Exception)
					{
						throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_read_the_radio_codeplug);
					}
					goto IL_FD;
					IL_3B:
					num2 = (short)543736350;
					short num3 = num2;
					num2 = (short)829997598;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)952369153;
						if (num2 != 0)
						{
						}
						num2 = (short)264306688;
						if (num2 != 0)
						{
						}
						num2 = (short)2036858880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_DE;
				}
				goto IL_1C;
			}
			IL_DE:
			IL_FD:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_read_the_radio_codeplug);
			IL_108:
			num2 = (short)1681391616;
			short num4 = num2;
			return ishItemCollection;
			IL_1C:
			ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			num2 = (short)1365835777;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0012CA5C File Offset: 0x0012AC5C
		public void UnpackCodeplug(global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioCodeplug)
		{
			short num = (short)175439872;
			switch (num)
			{
			default:
			{
				num = (short)1729822721;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)50790402;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1391329281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1BA;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_115;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)444399616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<int, global::System.IO.MemoryStream> keyValuePair = enumerator.Current;
									byte[] value = new byte[keyValuePair.Value.Length];
									value = keyValuePair.Value.GetBuffer();
									global::System.Collections.Generic.Dictionary<int, byte[]> dictionary;
									dictionary.Add(keyValuePair.Key, value);
									num = (short)2020474884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_117:
								num = (short)1361313795;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_115:
								goto IL_117;
							}
							IL_1BA:
							goto IL_96;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1CD;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_53;
						}
						continue;
					case 2:
					{
						num = (short)70057985;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.Dictionary<int, byte[]> dictionary = new global::System.Collections.Generic.Dictionary<int, byte[]>();
						global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream>.Enumerator enumerator = new global::SpecialFeatures.Comms.CodeplugFormatConverter().Convert(radioCodeplug).GetEnumerator();
						num = (short)663158784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						try
						{
							global::System.Collections.Generic.Dictionary<int, byte[]> dictionary;
							new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor().Unpack(dictionary, this.a);
							goto IL_234;
						}
						catch (global::System.Exception)
						{
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_unpack_the_radio_codeplug);
						}
						goto IL_96;
						IL_234:
						num = (short)341123200;
						short num3 = num;
						num = (short)548675712;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_269;
						}
						break;
					}
					}
					IL_53:
					if (radioCodeplug != null)
					{
						num = (short)1265172482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_96:
					num = (short)1264844800;
					short num4 = num;
					num = (short)1220280323;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1CD:
				throw new global::System.ArgumentNullException(global::CommonResources.AppResources.collection_of_codeplug_items_is_null);
				IL_269:
				num = (short)1331429376;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0012CD04 File Offset: 0x0012AF04
		private global::Motorola.Common.Communication.CommonUtil.IshItemCollection d()
		{
			short num = (short)1652228096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::Motorola.Acp.PackUnpack.Ish.Codeplug codeplug;
				global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor packUnpackExecutor;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (codeplug != null)
						{
							num = (short)570818562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_130;
					case 1:
						try
						{
							codeplug = packUnpackExecutor.Pack(this.a);
							goto IL_84;
						}
						catch (global::System.Exception ex)
						{
							if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
							{
								global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
								throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write);
							}
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_pack_the_radio_codeplug);
						}
						goto IL_130;
						IL_84:
						num = (short)395706369;
						if (num != 0)
						{
						}
						num = (short)1082654720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_E3;
					}
					goto IL_3B;
				}
				IL_E3:
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection result;
				try
				{
					num = (short)1011418972;
					short num3 = num;
					num = (short)568723292;
					global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream> dictionary;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1015545856;
						if (num != 0)
						{
						}
						dictionary = new global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream>();
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = codeplug.Partitions.GetEnumerator();
						try
						{
							num = (short)2049048578;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1592000516;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.Partition partition = enumerator.Current;
									global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(partition.Image.GetBuffer());
									memoryStream.SetLength(partition.Image.Length);
									dictionary.Add((int)partition.PartitionType, memoryStream);
									num = (short)1730347011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_284;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1D7;
									}
									continue;
								case 4:
									num = (short)1448017921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_22F:
								num = (short)1796931584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D7:
								goto IL_22F;
							}
							IL_284:;
						}
						finally
						{
							num = (short)1051525121;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1214644226;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2B8;
									}
									continue;
								case 2:
									goto IL_2F0;
								}
								IL_2B8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1362821120;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F0:;
						}
						break;
					}
					}
					result = new global::SpecialFeatures.Comms.CodeplugFormatConverter().Convert(dictionary);
				}
				catch (global::System.Exception)
				{
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_pack_the_radio_codeplug);
				}
				return result;
				IL_130:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_pack_the_radio_codeplug);
				IL_3B:
				num = (short)1135869952;
				short num4 = num;
				codeplug = null;
				result = null;
				packUnpackExecutor = new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor();
				num = (short)671547393;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0012D06C File Offset: 0x0012B26C
		private void a(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0)
		{
			while (A_0 != null)
			{
				short num;
				try
				{
					num = (short)253362177;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					pbaObject.SetCodeplug(A_0);
					this.l.Write(this.k, pbaObject, null);
				}
				catch (global::System.Exception)
				{
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_program_the_radio_codeplug);
				}
				num = (short)23789568;
				short num2 = num;
				num = (short)1171261623;
				short num3 = num;
				num = (short)563284151;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1429536768;
					if (num != 0)
					{
					}
					return;
				}
			}
			throw new global::System.ArgumentNullException(global::CommonResources.AppResources.Codeplug_Object_is_null);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0012D168 File Offset: 0x0012B368
		private string a(byte[] A_0)
		{
			short num = (short)692781059;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] array;
			for (;;)
			{
				int sourceIndex;
				switch (num2)
				{
				case 0:
					goto IL_170;
				case 1:
					if (A_0.Length == 16)
					{
						num = (short)664731653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Array.Copy(A_0, sourceIndex, array, 0, 24);
					num = (short)26935296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_80;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
					goto IL_F4;
				case 5:
				{
					global::System.Array.Copy(A_0, sourceIndex, array, 0, 12);
					num = (short)1317079961;
					short num3 = num;
					num = (short)1065290649;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_109;
					default:
						num = (short)1100611584;
						if (num != 0)
						{
						}
						num = (short)276299780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_3D:
				if (A_0 == null)
				{
					num = (short)1938161664;
					short num4 = num;
					num = (short)1943273474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				sourceIndex = 2;
				array = global::System.Linq.Enumerable.Repeat<byte>(0, 24).ToArray<byte>();
				IL_109:
				num = (short)855703553;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_80:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_Radio_Codeplug_Data);
			IL_F4:
			goto IL_19B;
			IL_170:
			num = (short)526778369;
			if (num != 0)
			{
			}
			IL_19B:
			return global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(array, array.Length);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0012D31C File Offset: 0x0012B51C
		private bool a(ref bool A_0)
		{
			int a_ = 19;
			short num;
			for (;;)
			{
				num = (short)2059599872;
				switch (num)
				{
				default:
				{
					num = (short)410270135;
					short num2 = num;
					num = (short)728775095;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_5B;
					}
					break;
				}
				}
			}
			IL_5B:
			num = (short)1753350144;
			short num3 = num;
			num = (short)522780672;
			if (num != 0)
			{
			}
			bool result = true;
			A_0 = false;
			try
			{
				num = (short)49479681;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					string text;
					string fileComponentVersion;
					bool flag3;
					switch (num4)
					{
					case 0:
						if (!flag)
						{
							num = (short)1830748167;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_849;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_18D;
						}
						continue;
					case 2:
					{
						string version;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(text, version) >= 0)
						{
							num = (short)467140631;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_953;
					}
					case 3:
					{
						string text2;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(fileComponentVersion, text2) < 0)
						{
							num = (short)1576665113;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_972;
					}
					case 4:
					{
						if (this.d.ComponentPresent(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95\ude97춙쾛", a_)))
						{
							num = (short)991756304;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95\ude97춙\udd9b", a_), true);
						string version2 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튕\ude97춙\udd9b", a_), true);
						string version3 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕\udc97캙\udd9b", a_), true);
						num = (short)962658325;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1589379072;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						string text2;
						if (string.IsNullOrEmpty(text2))
						{
							num = (short)345767970;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F6;
					}
					case 7:
						num = (short)586678307;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_1B1;
					case 9:
						num = (short)298778665;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						string version2;
						string text3;
						if (version2 == text3)
						{
							num = (short)1538392069;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F6;
					}
					case 11:
					{
						string text4 = string.Empty;
						string radioBBFSuiteVersion = this.k.RadioBBFSuiteVersion;
						text4 = this.d.GetBBFSuiteVersion();
						this.fileHostVersion = text4;
						num = (short)912588848;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)923533345;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						string version3;
						string text5;
						if (version3 == text5)
						{
							num = (short)691732509;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F6;
					}
					case 14:
					{
						string value;
						if (!string.IsNullOrEmpty(value))
						{
							num = (short)24969228;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1876885549;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)512163850;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						text = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95\ude97춙쾛", a_), true);
						string text3;
						string version2 = text3;
						string text5;
						string version3 = text5;
						num = (short)254214171;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (this.d.OpenUpgradeFile())
						{
							num = (short)1708785686;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36E;
					case 18:
						result = false;
						num = (short)1348861999;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1969487916;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						result = false;
						A_0 = true;
						num = (short)2127167524;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_73A;
					case 22:
					{
						text = string.Empty;
						string version2 = string.Empty;
						string version3 = string.Empty;
						string empty = string.Empty;
						string empty2 = string.Empty;
						string version = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95\ude97춙\udd9b", a_), true);
						string text3 = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튕\ude97춙\udd9b", a_), true);
						string text2 = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햕\ude97춙햛", a_), true);
						string text5 = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕\udc97캙\udd9b", a_), true);
						string value = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕킗\ud899캛\uda9dﮡ", a_), true);
						this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕킗\ud899캛\uda9d", a_), true);
						num = (short)467927044;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)1733427246;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)1536884742;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_953;
					case 26:
					{
						string text6;
						bool flag2;
						if (!this.IsOptionBoardFlashUpdateNeeded(ref text6, ref flag2))
						{
							num = (short)1258946590;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_972;
					}
					case 27:
						goto IL_73A;
					case 28:
						if (this.t)
						{
							num = (short)1976893451;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1343881233;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						string text6 = "";
						bool flag2 = false;
						num = (short)1733951514;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						num = (short)571211813;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						result = false;
						num = (short)391315499;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_98B;
					case 33:
					{
						string value;
						flag3 = (value == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햗\udb99\udf9b\udb9d", a_));
						goto IL_502;
					}
					case 34:
						goto IL_849;
					case 35:
					{
						string text2;
						if (!(fileComponentVersion == text2))
						{
							num = (short)908656664;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_849;
					}
					case 36:
						goto IL_972;
					case 37:
					{
						string text6;
						if (!this.IsConsoletteBoardFlashUpdateNeeded(ref text6))
						{
							num = (short)387710994;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_972;
					}
					case 38:
						goto IL_972;
					case 39:
					{
						string version;
						if (text == version)
						{
							num = (short)1396965391;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F6;
					}
					case 40:
					{
						string text4;
						string radioBBFSuiteVersion;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(text4, radioBBFSuiteVersion) < 0)
						{
							num = (short)1142161428;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_972;
					}
					case 41:
						if (!flag)
						{
							num = (short)1334902826;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_972;
					case 42:
						num = (short)797310979;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_972;
					case 44:
					{
						string version3;
						string text5;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(version3, text5) >= 0)
						{
							num = (short)903938057;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_953;
					}
					case 45:
						flag3 = false;
						goto IL_502;
					case 46:
					{
						string version2;
						string text3;
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(version2, text3) >= 0)
						{
							num = (short)175505427;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_953;
					}
					case 47:
						goto IL_972;
					case 48:
					{
						string text4;
						string radioBBFSuiteVersion;
						if (text4 == radioBBFSuiteVersion)
						{
							num = (short)1651441695;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)171900968;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_18D:
					if (this.d == null)
					{
						num = (short)2139881480;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1240989724;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_502:
					flag = flag3;
					num = (short)1843331111;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F6:
					num = (short)1019150338;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_73A:
					this.fileHostVersion = text;
					fileComponentVersion = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햕\ude97춙햛", a_), true);
					num = (short)1460076558;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_849:
					num = (short)368312333;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_953:
					result = false;
					A_0 = true;
					num = (short)1928921126;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_972:
					num = (short)1932328992;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1B1:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_upgrade_file, new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶙﾝ쒟잡쾥쒧쾩", a_)));
				IL_36E:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					this.d.UpgradeFilePath
				}));
				IL_98B:;
			}
			catch (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_determine_if_upgrade_is_needed);
			}
			num = (short)1322778625;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0012DD24 File Offset: 0x0012BF24
		private bool c()
		{
			int a_ = 11;
			short num = (short)2116091905;
			if (num != 0)
			{
			}
			num = (short)1792016384;
			short num2 = num;
			num = (short)1111098213;
			short num3 = num;
			num = (short)1362166629;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)104267776;
				if (num != 0)
				{
				}
				num = (short)1098317824;
				switch (num)
				{
				default:
					result = true;
					try
					{
						num = (short)618266639;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							string fileHostVersion;
							string fileComponentVersion;
							switch (num4)
							{
							case 0:
								goto IL_603;
							case 1:
							{
								string text;
								if (fileHostVersion == text)
								{
									num = (short)372244492;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6EB;
							}
							case 2:
							{
								string text2;
								string radioBBFSuiteVersion;
								if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(text2, radioBBFSuiteVersion) < 0)
								{
									num = (short)66256904;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6EB;
							}
							case 3:
							{
								fileHostVersion = string.Empty;
								string text3 = string.Empty;
								string text4 = string.Empty;
								string empty = string.Empty;
								string empty2 = string.Empty;
								string text = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍횏양햓", a_), true);
								string text5 = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪍횏양햓", a_), true);
								string value = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춍횏양\udd93", a_), true);
								string text6 = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8d풏욑햓", a_), true);
								num = (short)1913585680;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								string text2 = string.Empty;
								string radioBBFSuiteVersion = this.k.RadioBBFSuiteVersion;
								text2 = this.d.GetBBFSuiteVersion();
								this.fileHostVersion = text2;
								num = (short)1409875985;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								string text7;
								bool flag;
								if (!this.IsOptionBoardFlashUpdateNeeded(ref text7, ref flag))
								{
									num = (short)871432214;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6EB;
							}
							case 6:
								goto IL_603;
							case 7:
								num = (short)442761243;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								result = false;
								num = (short)436797471;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								goto IL_540;
							case 10:
							{
								string value;
								if (string.IsNullOrEmpty(value))
								{
									num = (short)1275330569;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6EB;
							}
							case 11:
								goto IL_6EB;
							case 12:
								num = (short)906493982;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								if (this.d.OpenUpgradeFile())
								{
									num = (short)1247346691;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3A7;
							case 14:
							{
								string text7;
								if (!this.IsConsoletteBoardFlashUpdateNeeded(ref text7))
								{
									num = (short)1725104149;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6EB;
							}
							case 15:
								switch (0)
								{
								case 0:
									goto IL_16F;
								}
								continue;
							case 16:
							{
								if (this.d.ComponentPresent(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍횏양잓", a_)))
								{
									num = (short)231931933;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								fileHostVersion = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍횏양햓", a_), true);
								string text3 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪍횏양햓", a_), true);
								string text4 = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8d풏욑햓", a_), true);
								num = (short)1750728710;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 17:
							{
								string text2;
								string radioBBFSuiteVersion;
								if (text2 == radioBBFSuiteVersion)
								{
									num = (short)631504922;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1839726594;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 18:
								goto IL_6EB;
							case 19:
								if (this.t)
								{
									num = (short)1062404100;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)532283405;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 20:
								goto IL_703;
							case 21:
								result = false;
								num = (short)98762770;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 22:
								num = (short)995885070;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 23:
								num = (short)1905852426;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 24:
							{
								string text7 = "";
								bool flag = false;
								num = (short)1702559749;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 25:
								goto IL_192;
							case 26:
								result = false;
								num = (short)192937995;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 27:
							{
								string value;
								if (!(fileComponentVersion == value))
								{
									num = (short)1908867095;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_540;
							}
							case 28:
							{
								string text4;
								string text6;
								if (text4 == text6)
								{
									num = (short)519045144;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6EB;
							}
							case 29:
							{
								fileHostVersion = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍횏양잓", a_), true);
								string text5;
								string text3 = text5;
								string text6;
								string text4 = text6;
								num = (short)1339883520;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 30:
							{
								string text3;
								string text5;
								if (text3 == text5)
								{
									num = (short)1673396231;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6EB;
							}
							case 31:
								goto IL_6EB;
							}
							IL_16F:
							if (this.d == null)
							{
								num = (short)1129906201;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)472055827;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_540:
							num = (short)1267335196;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_603:
							this.fileHostVersion = fileHostVersion;
							fileComponentVersion = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춍횏양\udd93", a_), true);
							num = (short)93257729;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_6EB:
							num = (short)469368852;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_192:
						throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_upgrade_file, new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮍﲗﾙ\uda9b첟잡", a_)));
						IL_3A7:
						throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
						{
							this.d.UpgradeFilePath
						}));
						IL_703:;
					}
					catch (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException)
					{
						throw;
					}
					catch (global::System.Exception)
					{
						throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_determine_if_upgrade_is_needed);
					}
					break;
				}
				break;
			}
			return result;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0012E47C File Offset: 0x0012C67C
		private void b()
		{
			int a_ = 10;
			short num;
			try
			{
				num = (short)1970470918;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string fileHostVersion;
					switch (num2)
					{
					case 0:
					{
						num = (short)928186369;
						if (num != 0)
						{
						}
						this.fileHostVersion = this.d.GetBBFSuiteVersion();
						num = (short)1902870348;
						short num3 = num;
						num = (short)1064927052;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_138;
						default:
							num = (short)1012072448;
							if (num != 0)
							{
							}
							num = (short)448069636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						fileHostVersion = string.Empty;
						string empty = string.Empty;
						string empty2 = string.Empty;
						string empty3 = string.Empty;
						string empty4 = string.Empty;
						this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얌즎욐튒", a_), true);
						string text = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌즎욐튒", a_), true);
						this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌즎욐\uda92", a_), true);
						string text2 = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8c쮎얐튒", a_), true);
						num = (short)164233227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1A4;
					case 3:
						goto IL_34B;
					case 4:
						goto IL_34B;
					case 5:
						fileHostVersion = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얌즎욐삒", a_), true);
						num = (short)1142423562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 7:
						goto IL_7E;
					case 8:
						if (this.t)
						{
							num = (short)1299578880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1432289292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_363;
					case 10:
						goto IL_1A4;
					case 11:
						if (this.d.ComponentPresent(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얌즎욐삒", a_)))
						{
							num = (short)736428037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fileHostVersion = this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얌즎욐튒", a_), true);
						this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌즎욐튒", a_), true);
						this.d.GetFileComponentVersion(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8c쮎얐튒", a_), true);
						goto IL_138;
					case 12:
						if (this.d.OpenUpgradeFile())
						{
							num = (short)1535377409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34B;
					}
					IL_62:
					if (this.d == null)
					{
						num = (short)420806663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)946405384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_138:
					num = (short)1455030274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A4:
					this.fileHostVersion = fileHostVersion;
					num = (short)1613168643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34B:
					num = (short)177864713;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7E:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_upgrade_file, new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾎﲘ\udd9a쒠", a_)));
				IL_363:;
			}
			catch (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_determine_if_upgrade_is_needed);
			}
			num = (short)1649016832;
			short num4 = num;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0012E85C File Offset: 0x0012CA5C
		internal bool IsOptionBoardFlashUpdateNeeded(ref string optBrdType, ref bool bComponentFound)
		{
			int a_ = 5;
			short num = (short)1792016384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BC;
				}
				string text2;
				string text3;
				bool result;
				for (;;)
				{
					IL_30:
					num = (short)980746240;
					short num3 = num;
					string text;
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1375272980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					case 1:
						text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잇좉벋뾍", a_);
						text3 = this.d.GetFileComponentVersion(text2, true);
						num = (short)1746403346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_33A;
					case 3:
						goto IL_33A;
					case 4:
					{
						if (this.k.OptBrdHwNotPresentFlag)
						{
							goto IL_2F7;
						}
						num = (short)1343532379;
						short num4 = num;
						num = (short)977907035;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_468;
						default:
							num = (short)1647771648;
							if (num != 0)
							{
							}
							num = (short)1039335438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						text = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잇\uda89\ud88b첍", a_), true);
						num = (short)73859072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.d.OpenUpgradeFile())
						{
							num = (short)517079056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27B;
					case 7:
						if (string.IsNullOrEmpty(this.k.OptBrdHardwareType))
						{
							num = (short)1979121665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F7;
					case 8:
						goto IL_35A;
					case 9:
						if (text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87쒉\udc8b\udc8d\udf8f햑", a_))
						{
							num = (short)1153892362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_237;
					case 10:
						goto IL_133;
					case 11:
						result = true;
						num = (short)1547370504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(text3, text) > 0)
						{
							num = (short)316997643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35A;
					case 13:
						goto IL_445;
					case 14:
						num = (short)1946157063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						text2 = this.k.OptBrdHardwareType;
						text3 = this.d.GetFileComponentVersion(text2, true);
						num = (short)1958477837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)435945476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_237;
					case 18:
						goto IL_445;
					case 19:
						return result;
					case 20:
						num = (short)1459159049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!string.IsNullOrEmpty(text3))
						{
							goto IL_468;
						}
						bComponentFound = false;
						this.i = false;
						num = (short)846331905;
						if (num != 0)
						{
						}
						num = (short)1500184578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (!this.k.OptBrdHwNotPresentFlag)
						{
							num = (short)981794831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_445;
					}
					goto IL_BC;
					IL_133:
					text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda87몉벋ꂍꂏꊑ몓ꚕꢗ", a_);
					num = (short)1854078993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_237:
					num = (short)1916403724;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F7:
					num = (short)777519126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33A:
					optBrdType = text2;
					num = (short)624951315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35A:
					this.i = true;
					num = (short)2004090883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_445:
					num = (short)284164117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_468:
					num = (short)286654469;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_27B:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					this.d.UpgradeFilePath
				}));
				IL_BC:
				text2 = string.Empty;
				text3 = string.Empty;
				result = false;
				bComponentFound = true;
				num = (short)119275526;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0012ED40 File Offset: 0x0012CF40
		internal bool IsConsoletteBoardFlashUpdateNeeded(ref string ConBrdType)
		{
			int a_ = 5;
			short num = (short)83820544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7C;
				}
				string text;
				bool result;
				string text3;
				for (;;)
				{
					IL_31:
					string text2;
					switch (num2)
					{
					case 0:
					{
						num = (short)1184824718;
						short num3 = num;
						num = (short)1145634190;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1346699264;
							if (num != 0)
							{
							}
							goto IL_291;
						}
						break;
					}
					case 1:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)989528069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.j = false;
						num = (short)969211917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (text2 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87쒉\udc8b\udc8d\udf8f햑", a_))
						{
							num = (short)221904896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E;
					case 3:
						goto IL_F9;
					case 4:
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)1806696463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_291;
					case 5:
						text2 = this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮇얉슋즍", a_), true);
						num = (short)511836164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						result = true;
						num = (short)2026307587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)309854217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_11E;
					case 9:
						if (!string.IsNullOrEmpty(this.k.ConBrdHardwareType))
						{
							num = (short)167247888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BA;
					case 10:
						if (this.d.OpenUpgradeFile())
						{
							num = (short)39452679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26D;
					case 11:
						goto IL_1BA;
					case 12:
						if (global::SpecialFeatures.Flashport.FlashRadio.VersionComparator.CompareVersions(text, text2) > 0)
						{
							num = (short)727056390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F9;
					case 13:
						goto IL_1BA;
					case 14:
						return result;
					case 15:
						num = (short)1330315266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1428160513;
						if (num != 0)
						{
						}
						text3 = this.k.ConBrdHardwareType;
						text = this.d.GetFileComponentVersion(text3, true);
						num = (short)1246691329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C;
					IL_F9:
					this.j = true;
					num = (short)352059403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11E:
					num = (short)1440219148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BA:
					ConBrdType = text3;
					num = (short)2069823502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_291:
					text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda87몉벋ꂍꂏꊑ몓ꚕꢗ", a_);
					num = (short)142147592;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_26D:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					this.d.UpgradeFilePath
				}));
				IL_7C:
				text3 = string.Empty;
				text = string.Empty;
				result = false;
				num = (short)1663631360;
				short num4 = num;
				num = (short)1564540938;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0012F114 File Offset: 0x0012D314
		private string a(string A_0, bool A_1 = true)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_13D;
			}
			int num;
			string text;
			short num2;
			uint num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return text;
				case 1:
					num2 = (short)1859911700;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_8F2;
				case 3:
					num2 = (short)1682374664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					text = text.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖊ", a_), "");
					num2 = (short)279445504;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!(A_0 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a얌춎쎐힒쎔튖쮘", a_)))
					{
						num2 = (short)1338638337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = this.k.MaceHardwareVersion;
					num2 = (short)928776235;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (this.k.MaceFlashVersion == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8a쎌\udf8e쎐\udc92튔", a_))
					{
						num2 = (short)848494650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = this.k.MaceFlashVersion;
					num2 = (short)1693974585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)2105475105;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (num3 != 3547647176U)
					{
						num2 = (short)401014805;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)111411215;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (num3 <= 657194699U)
					{
						num2 = (short)1502740536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1190920244;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (num3 != 3600565351U)
					{
						num2 = (short)251461699;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)209911821;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (num3 != 4175259642U)
					{
						num2 = (short)881131579;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)427032636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_850;
				case 13:
					if (!(A_0 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊쮌\ud88e킐", a_)))
					{
						num2 = (short)462159912;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = this.k.HostVersion;
					num2 = (short)1217331228;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_9D9;
				case 15:
				{
					num2 = (short)1641383233;
					short num4 = num2;
					num2 = (short)1643676993;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9D9;
					default:
						num2 = (short)146735104;
						if (num2 != 0)
						{
						}
						if (!(A_0 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒊\udd8c\udb8e펐", a_)))
						{
							num2 = (short)687079442;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						text = this.k.OptBrdHwHostVersion;
						num2 = (short)679411714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 16:
					goto IL_8F2;
				case 17:
					num2 = (short)1978597377;
					if (num2 != 0)
					{
					}
					if (!(A_0 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좊슌솎횐", a_)))
					{
						num2 = (short)1379991618;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = this.k.ConBrdHwHostVersion;
					num2 = (short)1015152667;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
				{
					num2 = (short)1519190016;
					short num5 = num2;
					num2 = (short)1636827191;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 19:
					num2 = (short)1933443084;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					goto IL_850;
				case 21:
					num2 = (short)1882521639;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (num3 != 412253508U)
					{
						num2 = (short)812580899;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1402208273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (num3 != 352972488U)
					{
						num2 = (short)1407582232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)472711219;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)456065046;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (num3 != 4034671331U)
					{
						num2 = (short)1327497278;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1394802734;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					goto IL_8F2;
				case 27:
					goto IL_8F2;
				case 28:
					goto IL_8F2;
				case 29:
					num2 = (short)243400753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					goto IL_850;
				case 31:
					num2 = (short)1073283102;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					if (num3 <= 412253508U)
					{
						num2 = (short)1680474165;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1940193341;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					goto IL_850;
				case 34:
					num2 = (short)2067136584;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					num2 = (short)1862729742;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					num2 = (short)483393578;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					goto IL_850;
				case 38:
					goto IL_850;
				case 39:
					goto IL_850;
				case 40:
					num2 = (short)2081292326;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					num2 = (short)1649737791;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					if (num3 != 3452354091U)
					{
						num2 = (short)1583611907;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1434517558;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					goto IL_8F2;
				case 44:
				{
					text = text.TrimEnd(global::System.Array.Empty<char>());
					char[] trimChars = new char[]
					{
						'\0',
						' ',
						'\r',
						'\n'
					};
					text = text.TrimEnd(trimChars);
					num2 = (short)610795588;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 45:
					if (!(A_0 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒊쾌뾎ꎐ", a_)))
					{
						num2 = (short)1039794207;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = this.k.LTEOptBrdHwHostVersion;
					num2 = (short)1689452570;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					if (!(A_0 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a얌춎쎐힒솔캖즘", a_)))
					{
						num2 = (short)601030675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = this.k.MaceHardwareType;
					num2 = (short)109903920;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					goto IL_8F2;
				case 48:
					goto IL_8F2;
				case 49:
					goto IL_850;
				case 50:
					goto IL_8F2;
				case 51:
					if (!(A_0 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좊쮌\ud88e\ud890", a_)))
					{
						num2 = (short)1288962112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)248971270;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 52:
					if (num3 <= 3547647176U)
					{
						num2 = (short)131792932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1811677194;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 53:
					num2 = (short)453050391;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 54:
					if (!(A_0 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊쮌\ud88e킐", a_)))
					{
						num2 = (short)446300194;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = this.k.DspVersion;
					num2 = (short)1183711248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 55:
					goto IL_850;
				case 56:
					num2 = (short)1098252320;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 57:
					goto IL_8F2;
				case 58:
					text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a붌뾎뾐ꎒꖔ릖ꦘꮚ", a_);
					num2 = (short)503578671;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 59:
					num2 = (short)1555431494;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 60:
					if (!(A_0 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8a즌\udb8e킐", a_)))
					{
						num2 = (short)909246471;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = this.k.PsdtVersion;
					num2 = (short)1217593394;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 61:
					if (num3 != 516698970U)
					{
						num2 = (short)174719017;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)975568941;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 62:
					num2 = (short)1989738507;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 63:
					if (num3 != 657194699U)
					{
						num2 = (short)909049885;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1594490885;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 64:
					num2 = (short)1115815973;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 65:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)2001076268;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 66:
					num2 = (short)1833959495;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 67:
					num2 = (short)860749849;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 68:
					if (A_1)
					{
						num2 = (short)439812100;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 69:
					goto IL_8F2;
				case 70:
					goto IL_850;
				case 71:
					goto IL_850;
				case 72:
					goto IL_850;
				}
				goto IL_13D;
				IL_850:
				text = string.Empty;
				num2 = (short)1452277829;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_9D9:
				goto IL_850;
				IL_8F2:
				num2 = (short)1650327617;
				num = (int)((global::System.IntPtr)num2);
			}
			return text;
			IL_13D:
			text = string.Empty;
			num3 = global::<PrivateImplementationDetails>.ComputeStringHash(A_0);
			num2 = (short)1929510921;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0012FD08 File Offset: 0x0012DF08
		public void SetProductModelIdentifierField()
		{
			int a_ = 18;
			short num;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_91;
				}
				int num3;
				string radInfoGeneralModelNumber_A8539Value;
				int num4;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_13:
					num = (short)1620104843;
					short num2 = num;
					num = (short)991942283;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)528744448;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (radInfoGeneralModelNumber_A8539Value.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud894꒖ꦘ", a_)))
							{
								num = (short)516554761;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21D;
						case 1:
							if (num4 != 0)
							{
								num = (short)30408710;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21D;
						case 2:
							if (radInfoGeneralModelNumber_A8539Value.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd94꺖꺘", a_)))
							{
								num = (short)637599751;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_144;
						case 3:
							goto IL_21D;
						case 4:
							goto IL_21B;
						case 5:
							num4 = 1;
							radioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178.SetValue(num4);
							num = (short)1901854724;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num4 = 0;
							radioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178.SetValue(num4);
							num = (short)1719468035;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1722548232;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (num4 != 1)
							{
								num = (short)848363525;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_144;
						case 9:
							num = (short)2008743937;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_241;
						}
						goto IL_91;
						IL_144:
						num = (short)1203306496;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_21D:
					global::ConstraintHelper.UtilityMack.ProductModelId = num4.ToString();
					num = (short)1149370378;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_21B:
					goto IL_21D;
				}
				IL_241:
				goto IL_246;
				IL_91:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num4 = radioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178Value;
				radInfoGeneralModelNumber_A8539Value = radioInformation.General.RadInfoGeneralModelNumber_A8539Value;
				num = (short)773914626;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			catch (global::System.Exception)
			{
			}
			IL_246:
			num = (short)2068971520;
			short num5 = num;
			num = (short)1721171969;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0012FFCC File Offset: 0x0012E1CC
		public void SetRequiredFirmwareVersionField()
		{
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_BB;
					case 1:
						if (!string.IsNullOrEmpty(radioWide.Labtool.RadioWideReqFWVersion_A42872Value))
						{
							num2 = (short)493158403;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_12F;
					case 2:
					{
						num2 = (short)1814716440;
						short num3 = num2;
						num2 = (short)1314349080;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BB;
						default:
							num2 = (short)1806565376;
							if (num2 != 0)
							{
							}
							if (radioWide != null)
							{
								num2 = (short)494665728;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_12F;
						}
						break;
					}
					case 3:
						radioWide.Labtool.RadioWideReqFWVersion_A42872.SetValue("");
						num2 = (short)364183556;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_12F;
					case 5:
						goto IL_146;
					}
					goto IL_28;
					IL_BB:
					num2 = (short)1741750273;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_12F:
					num2 = (short)2007367685;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_146:
				goto IL_154;
				IL_28:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)26017794;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Codeplug_upgrade_failed);
			}
			IL_154:
			num2 = (short)583073792;
			short num4 = num2;
			num2 = (short)954662913;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0013019C File Offset: 0x0012E39C
		private void a()
		{
			short num = (short)380696262;
			short num2 = num;
			num = (short)1898182;
			switch (num2 == num)
			{
			default:
			{
				num = (short)214564864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)73662465;
			if (num != 0)
			{
			}
			num = (short)953679872;
			if (num != 0)
			{
			}
			(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolSeamlessUpdateOutOfBoxExperience.Value = false;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0013026C File Offset: 0x0012E46C
		public global::Motorola.Common.Communication.Pba.PbaObject FlashRadioWithPba(global::Motorola.Common.Communication.CommonUtil.DeviceInfo codeplugDeviceInfo, string upgradeFile, global::Motorola.Common.Communication.Pba.PbaObject codeplugPba)
		{
			short num;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			try
			{
				num = (short)1933406646;
				short num2 = num;
				num = (short)733114806;
				switch (num2 == num)
				{
				}
				num = (short)174522368;
				if (num != 0)
				{
				}
				this.aa = true;
				this.h = true;
				this.z = codeplugPba;
				this.a = codeplugDeviceInfo.ModelNumber;
				this.b = codeplugDeviceInfo.SerialNumber;
				this.c = this.a(this.a(codeplugPba));
				this.k = new global::SpecialFeatures.Comms.RadioParams();
				this.k.ModelNumber = this.a;
				this.k.SerialNumber = this.b;
				this.k.FlashCode = this.c;
				this.FlashRadio(upgradeFile);
				result = this.z;
			}
			finally
			{
				num = (short)978124801;
				if (num != 0)
				{
				}
				this.aa = false;
				this.h = false;
			}
			num = (short)1764163584;
			short num3 = num;
			return result;
		}

		// Token: 0x040006FF RID: 1791
		private string a;

		// Token: 0x04000700 RID: 1792
		private string b;

		// Token: 0x04000701 RID: 1793
		private string c;

		// Token: 0x04000702 RID: 1794
		private global::SpecialFeatures.Flashport.FlashportUpgradeFile d;

		// Token: 0x04000703 RID: 1795
		private global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager e;

		// Token: 0x04000704 RID: 1796
		private global::System.ComponentModel.BackgroundWorker f;

		// Token: 0x04000705 RID: 1797
		private global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio.ProgressCallback g;

		// Token: 0x04000706 RID: 1798
		private bool h;

		// Token: 0x04000707 RID: 1799
		private bool i;

		// Token: 0x04000708 RID: 1800
		private bool j;

		// Token: 0x04000709 RID: 1801
		private global::SpecialFeatures.Comms.RadioParams k;

		// Token: 0x0400070A RID: 1802
		private global::SpecialFeatures.Comms.IDeviceProxy l;

		// Token: 0x0400070B RID: 1803
		private const int m = 901;

		// Token: 0x0400070C RID: 1804
		private int n;

		// Token: 0x0400070D RID: 1805
		private string o;

		// Token: 0x0400070E RID: 1806
		private string p;

		// Token: 0x0400070F RID: 1807
		private string q;

		// Token: 0x04000710 RID: 1808
		private bool r;

		// Token: 0x04000711 RID: 1809
		private string s;

		// Token: 0x04000712 RID: 1810
		private bool t;

		// Token: 0x04000713 RID: 1811
		private string u;

		// Token: 0x04000714 RID: 1812
		private string v;

		// Token: 0x04000715 RID: 1813
		private global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo w;

		// Token: 0x04000716 RID: 1814
		private global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x;

		// Token: 0x04000717 RID: 1815
		private string y;

		// Token: 0x04000718 RID: 1816
		private global::Motorola.Common.Communication.Pba.PbaObject z;

		// Token: 0x04000719 RID: 1817
		private bool aa;

		// Token: 0x020000E7 RID: 231
		private class ProgressCallback : global::SpecialFeatures.Comms.DeviceServiceHandler
		{
			// Token: 0x170004A6 RID: 1190
			// (get) Token: 0x06000DCB RID: 3531 RVA: 0x001303C4 File Offset: 0x0012E5C4
			// (set) Token: 0x06000DCC RID: 3532 RVA: 0x00130474 File Offset: 0x0012E674
			public int MaxSteps
			{
				get
				{
					short num = (short)770208065;
					short num2 = num;
					num = (short)392851777;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1846673408;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)1008730113;
					if (num != 0)
					{
					}
					num = (short)518848512;
					if (num != 0)
					{
					}
					return this.b;
				}
				set
				{
					short num = (short)172577277;
					short num2 = num;
					num = (short)791106045;
					switch (num2 == num)
					{
					default:
					{
						num = (short)404226048;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)1904476161;
					if (num != 0)
					{
					}
					num = (short)2090860544;
					if (num != 0)
					{
					}
					this.b = value;
				}
			}

			// Token: 0x170004A7 RID: 1191
			// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00130528 File Offset: 0x0012E728
			// (set) Token: 0x06000DCE RID: 3534 RVA: 0x001305DC File Offset: 0x0012E7DC
			public int CurrentStep
			{
				get
				{
					short num = (short)1071961292;
					short num2 = num;
					num = (short)539219148;
					switch (num2 == num)
					{
					default:
					{
						num = (short)931201024;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)1641480192;
					if (num != 0)
					{
					}
					num = (short)2090598401;
					if (num != 0)
					{
					}
					return this.c;
				}
				set
				{
					short num = (short)319062122;
					short num2 = num;
					num = (short)1383759978;
					switch (num2 == num)
					{
					default:
					{
						num = (short)303366144;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)1993474048;
					if (num != 0)
					{
					}
					num = (short)625803265;
					if (num != 0)
					{
					}
					this.c = value;
				}
			}

			// Token: 0x06000DCF RID: 3535 RVA: 0x00003122 File Offset: 0x00001322
			public ProgressCallback(global::System.ComponentModel.BackgroundWorker worker, int steps, int currStep)
			{
				this.a = worker;
				this.b = steps;
				this.c = currStep;
			}

			// Token: 0x06000DD0 RID: 3536 RVA: 0x0013068C File Offset: 0x0012E88C
			public void ProgressUpdate(double progress, string status)
			{
				short num = (short)621346816;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)903011388;
						short num3 = num;
						num = (short)667999292;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CE;
						case 1:
							break;
						default:
						{
							num = (short)236847104;
							short num4 = num;
							break;
						}
						}
						num = (short)597753857;
						if (num != 0)
						{
						}
						num = (short)1530003456;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CE;
						}
						continue;
					}
					case 1:
						this.a.ReportProgress((int)((double)this.c + progress * (double)this.b), status);
						num = (short)1218838530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					IL_CE:
					if (this.a == null)
					{
						break;
					}
					num = (short)1003814913;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x06000DD1 RID: 3537 RVA: 0x001307BC File Offset: 0x0012E9BC
			public void UpdateRadioProgress(object sender, global::System.ComponentModel.ProgressChangedEventArgs e)
			{
				short num = (short)656670722;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_5D;
					case 1:
						goto IL_62;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 3:
						if (num3 >= this.b)
						{
							num = (short)1833631749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62;
					case 4:
					{
						num = (short)2053647054;
						short num4 = num;
						num = (short)383003342;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5D;
						default:
							goto IL_118;
						}
						break;
					}
					case 5:
						num3 /= this.b;
						num = (short)446365697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3D:
					if (this.a != null)
					{
						num = (short)570359808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_5D:
					num3 = e.ProgressPercentage;
					num = (short)17498115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62:
					num = (short)1599995904;
					short num5 = num;
					this.a.ReportProgress(this.c + num3, e.UserState);
					num = (short)958988289;
					if (num != 0)
					{
					}
					num = (short)1347026948;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_118:
				num = (short)1378156544;
				if (num != 0)
				{
				}
			}

			// Token: 0x0400071A RID: 1818
			private global::System.ComponentModel.BackgroundWorker a;

			// Token: 0x0400071B RID: 1819
			private int b;

			// Token: 0x0400071C RID: 1820
			private int c;
		}
	}
}
