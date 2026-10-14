using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004DF RID: 1247
	[global::System.Serializable]
	public class ExternalDataModem : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A353 RID: 41811 RVA: 0x00989CE4 File Offset: 0x00987EE4
		public ExternalDataModem(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600A354 RID: 41812 RVA: 0x00989D24 File Offset: 0x00987F24
		protected ExternalDataModem(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.b(info, context);
		}

		// Token: 0x0600A355 RID: 41813 RVA: 0x00989D44 File Offset: 0x00987F44
		public override void Init()
		{
			int a_ = 9;
			short num = (short)1528561664;
			short num2 = num;
			num = (short)2140078081;
			if (num != 0)
			{
			}
			num = (short)570189194;
			short num3 = num;
			num = (short)166946186;
			switch (num3 == num)
			{
			}
			num = (short)203948032;
			if (num != 0)
			{
			}
			this.dataWideExternalDataModemType_42843 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹ꣻ蟽烿朁嬃㈅㨇㈉㠋㴍", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMTYPE, true, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideExternalDataModemType_42843LovStrs);
			this.dataWideExternalDataModemType_42843.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemType_42843.DataTransferOrder = 71;
			this.dataWideDataModemPassword_A42848 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("﯉跋ﻍ髛퓟퓡퇣훥\udfe7껩헫ퟭ쏯쏱쓳쟵볷쿹쿻쫽㗿䄁䄃䌅㬇䬉下䴍嘏圑ℓ―Ⱇ∙帛弝᤟ᐡᄣ急ဧ欩ᴫᠭ焯ı焳瀵笷礹฻砽ؿ煁瑃畅็ࡉ畋", a_), new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemPasswordEncryptDecryptConverter(), this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗黙뷛ꫝ臟꿡诣若跧蟩볫迭華臱菳駵諷黹ꏻ뿽㓿、㰃㈅〇", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMPASSWORD);
			this.dataWideDataModemPassword_A42848.IgnoreOnCompare = true;
			this.dataWideDataModemPassword_A42848.IsMasked = false;
			this.dataWideDataModemPassword_A42848.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideDataModemPassword_A42848.DataTransferOrder = -1;
			this.dataWideExternalDataModemPort_42851 = new global::AcpBusinessLayer.AcpSimpleRangeField(2332, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹곻釽狿瘁嬃㈅㨇㈉㤋㼍", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMPORT, 0, 65535, null, null, 0, 1);
			this.dataWideExternalDataModemPort_42851.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemPort_42851.DataTransferOrder = 72;
			this.dataWideExternalDataModemPort_42851.ShowHexValue = false;
			this.dataWideExternalDataModemOutOfRangeThreshold_42853 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹돻诽瓿䴁戃吅椇搉欋欍䐏稑易猕欗爙猛爝䐟紡ဣᐥဧἩἫ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMOUTOFRANGETHRESHOLDSEC, 60, 3600, null, null, 0, 1);
			this.dataWideExternalDataModemOutOfRangeThreshold_42853.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemOutOfRangeThreshold_42853.DataTransferOrder = 74;
			this.dataWideExternalDataModemOutOfRangeThreshold_42853.ShowHexValue = false;
			this.dataWideExternalDataModemPowerupMaxGuardTime_42855 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹곻釽矿朁瘃猅砇䜉洋瘍圏朑甓搕簗丙甛猝䔟紡ဣᐥဧἩᤫ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMPOWERUPMAXGUARDTIMESEC, 1, 300, null, null, 0, 1);
			this.dataWideExternalDataModemPowerupMaxGuardTime_42855.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemPowerupMaxGuardTime_42855.DataTransferOrder = 75;
			this.dataWideExternalDataModemPowerupMaxGuardTime_42855.ShowHexValue = false;
			this.dataWideExternalDataModemOpenMaxGuardTime_42856 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹돻軽旿氁䤃朅瀇䴉礋漍戏瘑䀓缕甗缙䌛⨝ሟᨡᄣဥ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMOPENMAXGUARDTIMESEC, 1, 255, null, null, 0, 1);
			this.dataWideExternalDataModemOpenMaxGuardTime_42856.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemOpenMaxGuardTime_42856.DataTransferOrder = 76;
			this.dataWideExternalDataModemOpenMaxGuardTime_42856.ShowHexValue = false;
			this.dataWideExternalDataModemVPNTunnel_43024 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹꫻껽仿嘁焃栅昇漉怋儍␏ℑ␓␕Ⱇ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMVPNTUNNEL, 1, 5, null, null, 0, 1);
			this.dataWideExternalDataModemVPNTunnel_43024.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemVPNTunnel_43024.DataTransferOrder = 78;
			this.dataWideExternalDataModemVPNTunnel_43024.ShowHexValue = false;
			this.modemConnectionType_43350 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟉ꏋ꫍뗏뿑韓맕뛗듙맛뷝铟诡诣裥볧鏩鳫语꿯웱쟳엵췷쫹", a_), global::CommonResources.AcgResources.ID_MODEMCONNECTIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.ModemConnectionType_43350LovStrs);
			this.modemConnectionType_43350.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.modemConnectionType_43350.DataTransferOrder = 1;
			this.dataWideExternalDataModemWifiPowerupGuardTime = new global::AcpBusinessLayer.AcpSimpleRangeField(120, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹꯻韽替欁吃椅缇漉縋笍怏唑愓眕樗縙䠛眝䴟䜡", a_), global::CommonResources.AcgResources.ID_WIRELESSPOWERUPMAXGUARDTIMESEC, 1, 300, null, null, 0, 1);
			this.dataWideExternalDataModemWifiPowerupGuardTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemWifiPowerupGuardTime.DataTransferOrder = 3;
			this.dataWideExternalDataModemWifiPowerupGuardTime.ShowHexValue = false;
			this.dataWideExternalDataModemVPNFriendlyName_43774 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹꫻껽仿䐁瘃漅洇搉栋戍椏少甓笕紗䔙⠛ⴝᜟᔡဣ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONVPNFRIENDLYNAME, 128);
			this.dataWideExternalDataModemVPNFriendlyName_43774.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemVPNFriendlyName_43774.DataTransferOrder = 83;
			this.dataWideExternalDataModemLTEFriendlyName_43775 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("蛉飋词", a_), this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹냻꫽䗿䐁瘃漅洇搉栋戍椏少甓笕紗䔙⠛ⴝᜟᔡᄣ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMLTEFRIENDLYNAME, 128);
			this.dataWideExternalDataModemLTEFriendlyName_43775.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemLTEFriendlyName_43775.DataTransferOrder = 89;
			this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("駉跋髍", a_), this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹뇻맽㧿㈁圃朅簇漉怋戍礏昑焓倕樗猙礛瀝䐟両崣栥䤧䜩䤫焭Яı̳ĵื", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMG90SATELLITEFRIENDLYNAME, 128);
			this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.DataTransferOrder = 91;
			this.dataWideExternalDataModemMG90SatelliteEnabled_43777 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏藑뷓닕뷗鿙ꓛꫝ藟郡諣蟥蓧껩跫髭釯뿱鯳鋵鷷韹뇻맽㧿㈁圃朅簇漉怋戍礏昑焓匕瘗笙縛爝䔟䘡笣ሥᬧᴩᬫ᤭", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMG90SATELLITEENABLED);
			this.dataWideExternalDataModemMG90SatelliteEnabled_43777.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemMG90SatelliteEnabled_43777.DataTransferOrder = 90;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迉듋뫍뗏ꃑ뫓럕듗龎飛뿝铟菡쓣ꯥ蟧軩觫菭", a_);
			base.Id = 10849;
			base.UIName = global::CommonResources.AcgResources.ID_EXTERNALDATAMODEM;
			base.DataTransferOrder = 12;
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x0098A1F8 File Offset: 0x009883F8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1719795747;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.dataWideExternalDataModemWifiPowerupGuardTime = new global::AcpBusinessLayer.AcpSimpleRangeField(120, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼ꣾ栀攂氄圆昈簊栌紎搐挒刔或砘椚礜䬞䠠丢䀤", a_), global::CommonResources.AcgResources.ID_WIRELESSPOWERUPMAXGUARDTIMESEC, null, null, 0, 1);
					this.dataWideExternalDataModemWifiPowerupGuardTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemWifiPowerupGuardTime.DataTransferOrder = 3;
					this.dataWideExternalDataModemWifiPowerupGuardTime.ShowHexValue = false;
					num = (short)1511915522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.dataWideExternalDataModemPowerupMaxGuardTime_42855 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼꿾渀琂怄甆簈笊䀌渎椐吒怔瘖欘缚䤜瘞䰠䘢稤ጦᬨጪᠬᨮ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMPOWERUPMAXGUARDTIMESEC, null, null, 0, 1);
					this.dataWideExternalDataModemPowerupMaxGuardTime_42855.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemPowerupMaxGuardTime_42855.DataTransferOrder = 75;
					this.dataWideExternalDataModemPowerupMaxGuardTime_42855.ShowHexValue = false;
					num = (short)608239625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_31C;
				case 3:
					goto IL_551;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("背ꃎ뗐뛒룔铖뛘뗚돜뫞苠韢賤裦蟨뿪铬鿮铰곲쇴쓶쫸컺췼", a_)))
					{
						num = (short)852230149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A95;
				case 5:
					this.modemConnectionType_43350 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("背ꃎ뗐뛒룔铖뛘뗚돜뫞苠韢賤裦蟨뿪铬鿮铰곲쇴쓶쫸컺췼", a_), global::CommonResources.AcgResources.ID_MODEMCONNECTIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.ModemConnectionType_43350LovStrs);
					this.modemConnectionType_43350.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.modemConnectionType_43350.DataTransferOrder = 1;
					num = (short)316211240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼ꧾ儀䴂䌄甆怈渊挌欎紐樒嬔瘖琘縚䈜⬞ሠᐢሤጦ", a_)))
					{
						num = (short)1217789962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_74E;
				case 7:
					goto IL_9B0;
				case 8:
					goto IL_962;
				case 9:
					goto IL_7FB;
				case 10:
					this.dataWideExternalDataModemVPNFriendlyName_43774 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼ꧾ儀䴂䌄甆怈渊挌欎紐樒嬔瘖琘縚䈜⬞ሠᐢሤጦ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONVPNFRIENDLYNAME, 128);
					this.dataWideExternalDataModemVPNFriendlyName_43774.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemVPNFriendlyName_43774.DataTransferOrder = 83;
					num = (short)1730281496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("黌軎藐", a_), this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼닾䘀㨂㔄吆栈缊栌挎紐稒愔爖弘椚琜稞传䜢䤤带木䨪䀬䨮渰ܲش6ุഺ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMG90SATELLITEFRIENDLYNAME, 128);
					this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.DataTransferOrder = 91;
					num = (short)795017216;
					short num3 = num;
					num = (short)1635713031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_2CE;
				case 13:
					goto IL_4B3;
				case 14:
					if (producerFields != null)
					{
						num = (short)294256677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AE2;
				case 15:
					goto IL_1CD;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼닾䘀㨂㔄吆栈缊栌挎紐稒愔爖弘椚琜稞传䜢䤤带木䨪䀬䨮渰ܲش6ุഺ", a_)))
					{
						goto IL_4E4;
					}
					goto IL_9B0;
				case 17:
					this.dataWideExternalDataModemOpenMaxGuardTime_42856 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼냾焀昂欄䨆栈猊䨌税瀐愒焔䌖瀘瘚砜䀞ᔠᄢᴤሦἨ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMOPENMAXGUARDTIMESEC, null, null, 0, 1);
					this.dataWideExternalDataModemOpenMaxGuardTime_42856.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemOpenMaxGuardTime_42856.DataTransferOrder = 76;
					this.dataWideExternalDataModemOpenMaxGuardTime_42856.ShowHexValue = false;
					num = (short)468254739;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼꿾渀琂怄甆簈笊䀌渎椐吒怔瘖欘缚䤜瘞䰠䘢稤ጦᬨጪᠬᨮ", a_)))
					{
						num = (short)585498625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7FB;
				case 19:
					goto IL_3FD;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼ꧾ儀䴂億爆月攊栌挎丐✒☔✖⬘⼚", a_)))
					{
						num = (short)933691434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A4C;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼닾䘀㨂㔄吆栈缊栌挎紐稒愔爖尘甚簜紞䴠䘢䄤砦ᴨᠪᨬᠮذ", a_)))
					{
						num = (short)1824522278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AE2;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼냾琀眂䨄愆嬈樊挌栎琐䜒純攖簘栚甜瀞䴠䜢稤ጦᬨጪᠬᰮ", a_)))
					{
						num = (short)976748567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_962;
				case 23:
					this.dataWideExternalDataModemOutOfRangeThreshold_42853 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼냾琀眂䨄愆嬈樊挌栎琐䜒純攖簘栚甜瀞䴠䜢稤ጦᬨጪᠬᰮ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMOUTOFRANGETHRESHOLDSEC, null, null, 0, 1);
					this.dataWideExternalDataModemOutOfRangeThreshold_42853.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemOutOfRangeThreshold_42853.DataTransferOrder = 74;
					this.dataWideExternalDataModemOutOfRangeThreshold_42853.ShowHexValue = false;
					num = (short)263913480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_74E;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼냾焀昂欄䨆栈猊䨌税瀐愒焔䌖瀘瘚砜䀞ᔠᄢᴤሦἨ", a_)))
					{
						num = (short)548143121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3FD;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚駜뻞闠苢꣤裦跨軪胬뿮郰胲蛴胶雸觺駼ꃾ䀀㜂㜄㼆㴈㌊", a_)))
					{
						num = (short)487129121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CD;
				case 27:
				{
					num = (short)2129214430;
					short num4 = num;
					num = (short)90586078;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4E4;
					default:
						num = (short)980746240;
						if (num != 0)
						{
						}
						this.dataWideExternalDataModemLTEFriendlyName_43775 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("臌鯎铐", a_), this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼돾唀䘂䌄甆怈渊挌欎紐樒嬔瘖琘縚䈜⬞ሠᐢሤሦ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMLTEFRIENDLYNAME, 128);
						this.dataWideExternalDataModemLTEFriendlyName_43775.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.dataWideExternalDataModemLTEFriendlyName_43775.DataTransferOrder = 89;
						num = (short)39780365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼꿾渀焂焄堆㴈㤊㔌㨎‐", a_)))
					{
						num = (short)1146224674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_676;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼ꣾ栀攂氄圆昈簊栌紎搐挒刔或砘椚礜䬞䠠丢䀤", a_)))
					{
						num = (short)1622278144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31C;
				case 30:
					num = (short)730202126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					goto IL_A4C;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼꯾砀猂怄堆㴈㤊㔌㬎∐", a_)))
					{
						num = (short)1757741097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CE;
				case 33:
					this.dataWideDataModemPassword_A42848 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("ﳌ軎駞\ud9e0ퟢ폤틦\ud9e8\udceaꧬ훮죰샲쓴쟶죸뿺주쳾㔀㘂䘄䈆䰈㠊䰌䴎刐唒倔∖⼘⼚├崞怠ᨢጤሦ漨ጪ氬Ḯܰ爲ش父缸砺縼ാ݀Ղ癄睆穈ൊཌ癎", a_), new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemPasswordEncryptDecryptConverter(), this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚駜뻞闠苢꣤裦跨軪胬뿮郰胲蛴胶雸觺駼ꃾ䀀㜂㜄㼆㴈㌊", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMPASSWORD);
					this.dataWideDataModemPassword_A42848.IgnoreOnCompare = true;
					this.dataWideDataModemPassword_A42848.IsMasked = false;
					this.dataWideDataModemPassword_A42848.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideDataModemPassword_A42848.DataTransferOrder = -1;
					num = (short)801964047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					this.dataWideExternalDataModemPort_42851 = new global::AcpBusinessLayer.AcpSimpleRangeField(2332, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼꿾渀焂焄堆㴈㤊㔌㨎‐", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMPORT, null, null, 0, 1);
					this.dataWideExternalDataModemPort_42851.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemPort_42851.DataTransferOrder = 72;
					this.dataWideExternalDataModemPort_42851.ShowHexValue = false;
					num = (short)840368164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					switch (0)
					{
					case 0:
						goto IL_DB;
					}
					continue;
				case 36:
					goto IL_676;
				case 37:
					num = (short)794624032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					this.dataWideExternalDataModemMG90SatelliteEnabled_43777 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼닾䘀㨂㔄吆栈缊栌挎紐稒愔爖尘甚簜紞䴠䘢䄤砦ᴨᠪᨬᠮذ", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMG90SATELLITEENABLED);
					this.dataWideExternalDataModemMG90SatelliteEnabled_43777.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemMG90SatelliteEnabled_43777.DataTransferOrder = 90;
					num = (short)601227267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼돾唀䘂䌄甆怈渊挌欎紐樒嬔瘖琘縚䈜⬞ሠᐢሤሦ", a_)))
					{
						num = (short)2059665435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B3;
				case 40:
					goto IL_A95;
				case 41:
					this.dataWideExternalDataModemType_42843 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼꯾砀猂怄堆㴈㤊㔌㬎∐", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMTYPE, true, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideExternalDataModemType_42843LovStrs);
					this.dataWideExternalDataModemType_42843.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemType_42843.DataTransferOrder = 71;
					num = (short)1216086028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					this.dataWideExternalDataModemVPNTunnel_43024 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚飜꟞闠蛢韤触裨蟪ꧬ軮藰鋲룴飶鷸黺郼ꧾ儀䴂億爆月攊栌挎丐✒☔✖⬘⼚", a_), global::CommonResources.AcgResources.ID_WIREDMODEMCONFIGURATIONMODEMVPNTUNNEL, null, null, 0, 1);
					this.dataWideExternalDataModemVPNTunnel_43024.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemVPNTunnel_43024.DataTransferOrder = 78;
					this.dataWideExternalDataModemVPNTunnel_43024.ShowHexValue = false;
					num = (short)2046623775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DB:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1824194590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1CD:
				num = (short)358744092;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CE:
				num = (short)999620634;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_31C:
				num = (short)1113653254;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3FD:
				num = (short)868417556;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B3:
				num = (short)243925008;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4E4:
				num = (short)1624375307;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_676:
				num = (short)1052180481;
				if (num != 0)
				{
				}
				num = (short)581369878;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_74E:
				num = (short)740229159;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7FB:
				num = (short)1173815321;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_962:
				num = (short)1104871442;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9B0:
				num = (short)1263665173;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A4C:
				num = (short)2014052356;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A95:
				num = (short)282722333;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_551:
			IL_AE2:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裌럎ꗐ뛒꟔맖룘럚﷜鯞胠韢蓤쟦ꓨ蓪觬諮鳰", a_);
			base.Id = 10849;
			base.UIName = global::CommonResources.AcgResources.ID_EXTERNALDATAMODEM;
			base.DataTransferOrder = 12;
		}

		// Token: 0x0600A357 RID: 41815 RVA: 0x0098AD1C File Offset: 0x00988F1C
		public override void PopulateReferences()
		{
			short num = (short)158400512;
			short num2 = num;
			num = (short)160698645;
			short num3 = num;
			num = (short)676466965;
			switch (num3 == num)
			{
			}
			num = (short)1797521409;
			if (num != 0)
			{
			}
			num = (short)1747714048;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A358 RID: 41816 RVA: 0x0098ADC4 File Offset: 0x00988FC4
		public override void DropReferences()
		{
			short num = (short)289144832;
			short num2 = num;
			num = (short)407759065;
			short num3 = num;
			num = (short)60942553;
			switch (num3 == num)
			{
			}
			num = (short)947912704;
			if (num != 0)
			{
			}
			num = (short)1484521473;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x0098AE70 File Offset: 0x00989070
		public override void SetConstraints()
		{
			short num = (short)1119092736;
			short num2 = num;
			num = (short)56156841;
			short num3 = num;
			num = (short)472638121;
			switch (num3 == num)
			{
			}
			num = (short)1565130752;
			if (num != 0)
			{
			}
			num = (short)1453522945;
			if (num != 0)
			{
			}
			this.dataWideExternalDataModemType_42843.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemWired);
			this.dataWideDataModemPassword_A42848.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConModemTypeIsSierralWirelessGXESLSSeries);
			this.dataWideDataModemPassword_A42848.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDataModemPasswordIsValid);
			this.dataWideExternalDataModemPort_42851.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConModemTypeIsSierralWirelessGXESLSSeriesOrMG90);
			this.dataWideExternalDataModemOutOfRangeThreshold_42853.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDataModemIsEnabledAndNotSierraWirelessMG90Modem);
			this.dataWideExternalDataModemPowerupMaxGuardTime_42855.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDataModemIsEnabled);
			this.dataWideExternalDataModemOpenMaxGuardTime_42856.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDataModemIsEnabled);
			this.dataWideExternalDataModemVPNTunnel_43024.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConModemTypeIsSierralWirelessGXESLSSeries);
			this.modemConnectionType_43350.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.IsDataModemConnectionTypeValid);
			this.modemConnectionType_43350.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ModemConnectionTypeChanged);
			this.dataWideExternalDataModemWifiPowerupGuardTime.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType);
			this.dataWideExternalDataModemVPNFriendlyName_43774.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiredModeAndModemTypeIsSierraWirelessMG90);
			this.dataWideExternalDataModemVPNFriendlyName_43774.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConModemVPNFriendlyNameIsValid);
			this.dataWideExternalDataModemLTEFriendlyName_43775.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiredModeAndModemTypeIsSierraWirelessMG90);
			this.dataWideExternalDataModemLTEFriendlyName_43775.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConModemLTEFriendlyNameIsValid);
			this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConMG90SatelliteEnabledAndWiredModeAndModemTypeIsSierraWirelessMG90);
			this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConMG90SatelliteFriendlyNameIsValid);
			this.dataWideExternalDataModemMG90SatelliteEnabled_43777.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiredModeAndModemTypeIsSierraWirelessMG90);
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x0098B0B8 File Offset: 0x009892B8
		public override void SetupDependencies()
		{
			short num = (short)832241664;
			short num2 = num;
			num = (short)1760849391;
			short num3 = num;
			num = (short)1778675183;
			switch (num3 == num)
			{
			}
			num = (short)111542273;
			if (num != 0)
			{
			}
			num = (short)1651834880;
			if (num != 0)
			{
			}
			this.dataWideExternalDataModemType_42843.AddDependentObject(this.dataWideDataModemPassword_A42848);
			this.dataWideExternalDataModemType_42843.AddDependentObject(this.dataWideExternalDataModemPort_42851);
			this.dataWideExternalDataModemType_42843.AddDependentObject(this.dataWideExternalDataModemOutOfRangeThreshold_42853);
			this.dataWideExternalDataModemType_42843.AddDependentObject(this.dataWideExternalDataModemPowerupMaxGuardTime_42855);
			this.dataWideExternalDataModemType_42843.AddDependentObject(this.dataWideExternalDataModemOpenMaxGuardTime_42856);
			this.dataWideExternalDataModemType_42843.AddDependentObject(this.dataWideExternalDataModemVPNTunnel_43024);
			this.dataWideExternalDataModemType_42843.AddDependentObject(this.dataWideExternalDataModemVPNFriendlyName_43774);
			this.dataWideExternalDataModemType_42843.AddDependentObject(this.dataWideExternalDataModemLTEFriendlyName_43775);
			this.dataWideExternalDataModemType_42843.AddDependentObject(this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776);
			this.dataWideExternalDataModemType_42843.AddDependentObject(this.dataWideExternalDataModemMG90SatelliteEnabled_43777);
		}

		// Token: 0x170051C8 RID: 20936
		// (get) Token: 0x0600A35B RID: 41819 RVA: 0x0098B214 File Offset: 0x00989414
		public bool HasDiffs
		{
			get
			{
				short num = (short)311492608;
				short num2 = num;
				num = (short)1262677178;
				short num3 = num;
				num = (short)1449520314;
				switch (num3 == num)
				{
				}
				num = (short)337641472;
				if (num != 0)
				{
				}
				num = (short)1203830785;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170051C9 RID: 20937
		// (get) Token: 0x0600A35C RID: 41820 RVA: 0x0098B2C0 File Offset: 0x009894C0
		// (set) Token: 0x0600A35D RID: 41821 RVA: 0x0098B378 File Offset: 0x00989578
		public int DataWideExternalDataModemType_42843Value
		{
			get
			{
				short num = (short)706805760;
				short num2 = num;
				num = (short)692795921;
				short num3 = num;
				num = (short)770652689;
				switch (num3 == num)
				{
				}
				num = (short)188612609;
				if (num != 0)
				{
				}
				num = (short)676790272;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843.Value;
			}
			set
			{
				short num = (short)1078722560;
				short num2 = num;
				num = (short)732264462;
				short num3 = num;
				num = (short)1167161358;
				switch (num3 == num)
				{
				}
				num = (short)215285761;
				if (num != 0)
				{
				}
				num = (short)676331520;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemType_42843.Value = value;
			}
		}

		// Token: 0x170051CA RID: 20938
		// (get) Token: 0x0600A35E RID: 41822 RVA: 0x0098B430 File Offset: 0x00989630
		// (set) Token: 0x0600A35F RID: 41823 RVA: 0x0098B4E8 File Offset: 0x009896E8
		public string DataWideExternalDataModemType_42843_UIValue
		{
			get
			{
				short num = (short)842465280;
				short num2 = num;
				num = (short)63318267;
				short num3 = num;
				num = (short)192293115;
				switch (num3 == num)
				{
				}
				num = (short)478347264;
				if (num != 0)
				{
				}
				num = (short)484507649;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843.UIValue;
			}
			set
			{
				short num = (short)27262976;
				short num2 = num;
				num = (short)210902584;
				short num3 = num;
				num = (short)232463928;
				switch (num3 == num)
				{
				}
				num = (short)279576576;
				if (num != 0)
				{
				}
				num = (short)1857093633;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemType_42843.UIValue = value;
			}
		}

		// Token: 0x170051CB RID: 20939
		// (get) Token: 0x0600A360 RID: 41824 RVA: 0x0098B59C File Offset: 0x0098979C
		public global::AcpBusinessLayer.AcpListField DataWideExternalDataModemType_42843
		{
			get
			{
				short num = (short)476774400;
				short num2 = num;
				num = (short)30474241;
				if (num != 0)
				{
				}
				num = (short)681940842;
				short num3 = num;
				num = (short)1080792938;
				switch (num3 == num)
				{
				}
				num = (short)934739968;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843;
			}
		}

		// Token: 0x170051CC RID: 20940
		// (get) Token: 0x0600A361 RID: 41825 RVA: 0x0098B650 File Offset: 0x00989850
		// (set) Token: 0x0600A362 RID: 41826 RVA: 0x0098B704 File Offset: 0x00989904
		public bool DataWideExternalDataModemType_42843_Applicable
		{
			get
			{
				short num = (short)1119879168;
				short num2 = num;
				num = (short)1964876050;
				short num3 = num;
				num = (short)12427538;
				switch (num3 == num)
				{
				}
				num = (short)2014707712;
				if (num != 0)
				{
				}
				num = (short)1550843905;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843.Applicable;
			}
			set
			{
				short num = (short)954793984;
				short num2 = num;
				num = (short)1893531649;
				if (num != 0)
				{
				}
				num = (short)1760659766;
				short num3 = num;
				num = (short)1315342646;
				switch (num3 == num)
				{
				}
				num = (short)1724448768;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemType_42843.Applicable = value;
			}
		}

		// Token: 0x170051CD RID: 20941
		// (get) Token: 0x0600A363 RID: 41827 RVA: 0x0098B7BC File Offset: 0x009899BC
		// (set) Token: 0x0600A364 RID: 41828 RVA: 0x0098B870 File Offset: 0x00989A70
		public bool DataWideExternalDataModemType_42843_Valid
		{
			get
			{
				short num = (short)1940324352;
				short num2 = num;
				num = (short)590488615;
				short num3 = num;
				num = (short)1507861543;
				switch (num3 == num)
				{
				}
				num = (short)1062862849;
				if (num != 0)
				{
				}
				num = (short)903675904;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843.Valid;
			}
			set
			{
				short num = (short)1594228736;
				short num2 = num;
				num = (short)1260934749;
				short num3 = num;
				num = (short)1959941725;
				switch (num3 == num)
				{
				}
				num = (short)1162084353;
				if (num != 0)
				{
				}
				num = (short)1788936192;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemType_42843.Valid = value;
			}
		}

		// Token: 0x170051CE RID: 20942
		// (get) Token: 0x0600A365 RID: 41829 RVA: 0x0098B924 File Offset: 0x00989B24
		// (set) Token: 0x0600A366 RID: 41830 RVA: 0x0098B9D8 File Offset: 0x00989BD8
		public bool DataWideExternalDataModemType_42843_Visible
		{
			get
			{
				short num = (short)714932224;
				short num2 = num;
				num = (short)1125492911;
				short num3 = num;
				num = (short)135047343;
				switch (num3 == num)
				{
				}
				num = (short)2065891328;
				if (num != 0)
				{
				}
				num = (short)1538654209;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843.Visible;
			}
			set
			{
				short num = (short)256311296;
				short num2 = num;
				num = (short)2142220771;
				short num3 = num;
				num = (short)744141283;
				switch (num3 == num)
				{
				}
				num = (short)617086976;
				if (num != 0)
				{
				}
				num = (short)1686962177;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemType_42843.Visible = value;
			}
		}

		// Token: 0x170051CF RID: 20943
		// (get) Token: 0x0600A367 RID: 41831 RVA: 0x0098BA8C File Offset: 0x00989C8C
		// (set) Token: 0x0600A368 RID: 41832 RVA: 0x0098BB40 File Offset: 0x00989D40
		public bool DataWideExternalDataModemType_42843_Editable
		{
			get
			{
				short num = (short)1220870144;
				short num2 = num;
				num = (short)1637602781;
				short num3 = num;
				num = (short)1042666973;
				switch (num3 == num)
				{
				}
				num = (short)2135687169;
				if (num != 0)
				{
				}
				num = (short)37814272;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843.Editable;
			}
			set
			{
				short num = (short)976683008;
				short num2 = num;
				num = (short)559022081;
				if (num != 0)
				{
				}
				num = (short)865519480;
				short num3 = num;
				num = (short)778749816;
				switch (num3 == num)
				{
				}
				num = (short)808058880;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemType_42843.Editable = value;
			}
		}

		// Token: 0x170051D0 RID: 20944
		// (get) Token: 0x0600A369 RID: 41833 RVA: 0x0098BBF4 File Offset: 0x00989DF4
		internal string DataWideExternalDataModemType_42843_UILabel
		{
			get
			{
				short num = (short)244691189;
				short num2 = num;
				num = (short)443592949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)877395968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007878145;
				if (num != 0)
				{
				}
				num = (short)1651245056;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843.UIName;
			}
		}

		// Token: 0x170051D1 RID: 20945
		// (get) Token: 0x0600A36A RID: 41834 RVA: 0x0098BCA8 File Offset: 0x00989EA8
		// (set) Token: 0x0600A36B RID: 41835 RVA: 0x0098BD5C File Offset: 0x00989F5C
		internal bool DataWideExternalDataModemType_42843_HiddenStatic
		{
			get
			{
				short num = (short)1817069771;
				short num2 = num;
				num = (short)1266043083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1936261120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)75431937;
				if (num != 0)
				{
				}
				num = (short)108789760;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843.HiddenStatic;
			}
			set
			{
				short num = (short)1318687231;
				short num2 = num;
				num = (short)1549570559;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1852768256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)499843072;
				if (num != 0)
				{
				}
				num = (short)347340801;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemType_42843.HiddenStatic = value;
			}
		}

		// Token: 0x170051D2 RID: 20946
		// (get) Token: 0x0600A36C RID: 41836 RVA: 0x0098BE10 File Offset: 0x0098A010
		// (set) Token: 0x0600A36D RID: 41837 RVA: 0x0098BEC8 File Offset: 0x0098A0C8
		internal bool DataWideExternalDataModemType_42843_HiddenDynamic
		{
			get
			{
				short num = (short)354942977;
				if (num != 0)
				{
				}
				num = (short)1075970048;
				short num2 = num;
				num = (short)525953201;
				short num3 = num;
				num = (short)2108254385;
				switch (num3 == num)
				{
				}
				num = (short)905183232;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843.HiddenDynamic;
			}
			set
			{
				short num = (short)321715557;
				short num2 = num;
				num = (short)386727269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)107347968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1327366145;
				if (num != 0)
				{
				}
				num = (short)1736900608;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemType_42843.HiddenDynamic = value;
			}
		}

		// Token: 0x170051D3 RID: 20947
		// (get) Token: 0x0600A36E RID: 41838 RVA: 0x0098BF7C File Offset: 0x0098A17C
		public bool DataWideExternalDataModemType_42843_HasDiffs
		{
			get
			{
				short num = (short)288011968;
				short num2 = num;
				num = (short)356562624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1747058688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1253834753;
				if (num != 0)
				{
				}
				num = (short)462553088;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemType_42843._HasDiffs;
			}
		}

		// Token: 0x170051D4 RID: 20948
		// (get) Token: 0x0600A36F RID: 41839 RVA: 0x0098C034 File Offset: 0x0098A234
		// (set) Token: 0x0600A370 RID: 41840 RVA: 0x0098C0E8 File Offset: 0x0098A2E8
		public string DataWideDataModemPassword_A42848Value
		{
			get
			{
				short num = (short)550602593;
				short num2 = num;
				num = (short)146442081;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1313800192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)790495233;
				if (num != 0)
				{
				}
				num = (short)1295450112;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848.Value;
			}
			set
			{
				short num = (short)1520070343;
				short num2 = num;
				num = (short)29519559;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1781989376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)670105600;
				if (num != 0)
				{
				}
				num = (short)1557856257;
				if (num != 0)
				{
				}
				this.dataWideDataModemPassword_A42848.Value = value;
			}
		}

		// Token: 0x170051D5 RID: 20949
		// (get) Token: 0x0600A371 RID: 41841 RVA: 0x0098C1A0 File Offset: 0x0098A3A0
		public global::AcpBusinessLayer.AcpFieldX<string, string> DataWideDataModemPassword_A42848
		{
			get
			{
				short num = (short)385090077;
				short num2 = num;
				num = (short)631570973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)989200384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024262145;
				if (num != 0)
				{
				}
				num = (short)8781824;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848;
			}
		}

		// Token: 0x170051D6 RID: 20950
		// (get) Token: 0x0600A372 RID: 41842 RVA: 0x0098C250 File Offset: 0x0098A450
		// (set) Token: 0x0600A373 RID: 41843 RVA: 0x0098C304 File Offset: 0x0098A504
		public string DataWideDataModemPassword_A42848_UIValue
		{
			get
			{
				short num = (short)1036773420;
				short num2 = num;
				num = (short)679864364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)596180992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1976107008;
				if (num != 0)
				{
				}
				num = (short)441188353;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848.UIValue;
			}
			set
			{
				short num = (short)431073263;
				short num2 = num;
				num = (short)584820719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)192741376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1231093760;
				if (num != 0)
				{
				}
				num = (short)1505034241;
				if (num != 0)
				{
				}
				this.dataWideDataModemPassword_A42848.UIValue = value;
			}
		}

		// Token: 0x170051D7 RID: 20951
		// (get) Token: 0x0600A374 RID: 41844 RVA: 0x0098C3BC File Offset: 0x0098A5BC
		// (set) Token: 0x0600A375 RID: 41845 RVA: 0x0098C470 File Offset: 0x0098A670
		public bool DataWideDataModemPassword_A42848_Applicable
		{
			get
			{
				short num = (short)731302127;
				short num2 = num;
				num = (short)88721647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1083572224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)23855105;
				if (num != 0)
				{
				}
				num = (short)956760064;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848.Applicable;
			}
			set
			{
				short num = (short)1522686333;
				short num2 = num;
				num = (short)1981634941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660551168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)843776000;
				if (num != 0)
				{
				}
				num = (short)144703489;
				if (num != 0)
				{
				}
				this.dataWideDataModemPassword_A42848.Applicable = value;
			}
		}

		// Token: 0x170051D8 RID: 20952
		// (get) Token: 0x0600A376 RID: 41846 RVA: 0x0098C524 File Offset: 0x0098A724
		// (set) Token: 0x0600A377 RID: 41847 RVA: 0x0098C5DC File Offset: 0x0098A7DC
		public bool DataWideDataModemPassword_A42848_Valid
		{
			get
			{
				short num = (short)504622904;
				short num2 = num;
				num = (short)2116742968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640417792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1131610113;
				if (num != 0)
				{
				}
				num = (short)235929600;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848.Valid;
			}
			set
			{
				short num = (short)90379038;
				short num2 = num;
				num = (short)1933447966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)272433152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1944322048;
				if (num != 0)
				{
				}
				num = (short)1677328385;
				if (num != 0)
				{
				}
				this.dataWideDataModemPassword_A42848.Valid = value;
			}
		}

		// Token: 0x170051D9 RID: 20953
		// (get) Token: 0x0600A378 RID: 41848 RVA: 0x0098C690 File Offset: 0x0098A890
		// (set) Token: 0x0600A379 RID: 41849 RVA: 0x0098C744 File Offset: 0x0098A944
		public bool DataWideDataModemPassword_A42848_Visible
		{
			get
			{
				short num = (short)969606438;
				short num2 = num;
				num = (short)618661158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1952382976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1628176385;
				if (num != 0)
				{
				}
				num = (short)1034551296;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848.Visible;
			}
			set
			{
				short num = (short)1976919036;
				short num2 = num;
				num = (short)2059625468;
				switch (num2 == num)
				{
				default:
				{
					num = (short)83034112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1926365184;
				if (num != 0)
				{
				}
				num = (short)163446785;
				if (num != 0)
				{
				}
				this.dataWideDataModemPassword_A42848.Visible = value;
			}
		}

		// Token: 0x170051DA RID: 20954
		// (get) Token: 0x0600A37A RID: 41850 RVA: 0x0098C7F8 File Offset: 0x0098A9F8
		// (set) Token: 0x0600A37B RID: 41851 RVA: 0x0098C8AC File Offset: 0x0098AAAC
		public bool DataWideDataModemPassword_A42848_Editable
		{
			get
			{
				short num = (short)1802724293;
				short num2 = num;
				num = (short)2084856773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1669332992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1504444416;
				if (num != 0)
				{
				}
				num = (short)893255681;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848.Editable;
			}
			set
			{
				short num = (short)1780592718;
				short num2 = num;
				num = (short)1531490382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1986527232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1566507009;
				if (num != 0)
				{
				}
				num = (short)105971712;
				if (num != 0)
				{
				}
				this.dataWideDataModemPassword_A42848.Editable = value;
			}
		}

		// Token: 0x170051DB RID: 20955
		// (get) Token: 0x0600A37C RID: 41852 RVA: 0x0098C960 File Offset: 0x0098AB60
		internal string DataWideDataModemPassword_A42848_UILabel
		{
			get
			{
				short num = (short)1203716332;
				short num2 = num;
				num = (short)800801004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1137246208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)841220097;
				if (num != 0)
				{
				}
				num = (short)1515782144;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848.UIName;
			}
		}

		// Token: 0x170051DC RID: 20956
		// (get) Token: 0x0600A37D RID: 41853 RVA: 0x0098CA14 File Offset: 0x0098AC14
		// (set) Token: 0x0600A37E RID: 41854 RVA: 0x0098CAC8 File Offset: 0x0098ACC8
		internal bool DataWideDataModemPassword_A42848_HiddenStatic
		{
			get
			{
				short num = (short)1386061071;
				short num2 = num;
				num = (short)1627954447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)845676544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1768947713;
				if (num != 0)
				{
				}
				num = (short)1527840768;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848.HiddenStatic;
			}
			set
			{
				short num = (short)1587866389;
				short num2 = num;
				num = (short)1276504853;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2112225280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)515112961;
				if (num != 0)
				{
				}
				num = (short)997654528;
				if (num != 0)
				{
				}
				this.dataWideDataModemPassword_A42848.HiddenStatic = value;
			}
		}

		// Token: 0x170051DD RID: 20957
		// (get) Token: 0x0600A37F RID: 41855 RVA: 0x0098CB80 File Offset: 0x0098AD80
		// (set) Token: 0x0600A380 RID: 41856 RVA: 0x0098CC34 File Offset: 0x0098AE34
		internal bool DataWideDataModemPassword_A42848_HiddenDynamic
		{
			get
			{
				short num = (short)990969857;
				if (num != 0)
				{
				}
				num = (short)2069364736;
				short num2 = num;
				num = (short)597318267;
				short num3 = num;
				num = (short)1177180795;
				switch (num3 == num)
				{
				}
				num = (short)1161232384;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848.HiddenDynamic;
			}
			set
			{
				short num = (short)891708426;
				short num2 = num;
				num = (short)1069573130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1528299520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)911736833;
				if (num != 0)
				{
				}
				num = (short)2069168128;
				if (num != 0)
				{
				}
				this.dataWideDataModemPassword_A42848.HiddenDynamic = value;
			}
		}

		// Token: 0x170051DE RID: 20958
		// (get) Token: 0x0600A381 RID: 41857 RVA: 0x0098CCE8 File Offset: 0x0098AEE8
		public bool DataWideDataModemPassword_A42848_HasDiffs
		{
			get
			{
				short num = (short)1138226479;
				short num2 = num;
				num = (short)1806365999;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1534001152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1690828801;
				if (num != 0)
				{
				}
				num = (short)343539712;
				if (num != 0)
				{
				}
				return this.dataWideDataModemPassword_A42848._HasDiffs;
			}
		}

		// Token: 0x170051DF RID: 20959
		// (get) Token: 0x0600A382 RID: 41858 RVA: 0x0098CD9C File Offset: 0x0098AF9C
		// (set) Token: 0x0600A383 RID: 41859 RVA: 0x0098CE50 File Offset: 0x0098B050
		public int DataWideExternalDataModemPort_42851Value
		{
			get
			{
				short num = (short)576978945;
				if (num != 0)
				{
				}
				num = (short)373489664;
				short num2 = num;
				num = (short)914440549;
				short num3 = num;
				num = (short)1887388005;
				switch (num3 == num)
				{
				}
				num = (short)1045823488;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.Value;
			}
			set
			{
				short num = (short)453111724;
				short num2 = num;
				num = (short)118550444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)156041216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1190461441;
				if (num != 0)
				{
				}
				num = (short)1149370368;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.Value = value;
			}
		}

		// Token: 0x170051E0 RID: 20960
		// (get) Token: 0x0600A384 RID: 41860 RVA: 0x0098CF04 File Offset: 0x0098B104
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataModemPort_42851
		{
			get
			{
				short num = (short)534404654;
				short num2 = num;
				num = (short)473390638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1769603072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)356843520;
				if (num != 0)
				{
				}
				num = (short)1663107073;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851;
			}
		}

		// Token: 0x170051E1 RID: 20961
		// (get) Token: 0x0600A385 RID: 41861 RVA: 0x0098CFB0 File Offset: 0x0098B1B0
		// (set) Token: 0x0600A386 RID: 41862 RVA: 0x0098D064 File Offset: 0x0098B264
		public string DataWideExternalDataModemPort_42851_UIValue
		{
			get
			{
				short num = (short)1522204673;
				if (num != 0)
				{
				}
				num = (short)991297536;
				short num2 = num;
				num = (short)167597949;
				short num3 = num;
				num = (short)1952143229;
				switch (num3 == num)
				{
				}
				num = (short)1620836352;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.UIValue;
			}
			set
			{
				short num = (short)1125083289;
				short num2 = num;
				num = (short)279996569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)140509184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074855937;
				if (num != 0)
				{
				}
				num = (short)500498432;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.UIValue = value;
			}
		}

		// Token: 0x170051E2 RID: 20962
		// (get) Token: 0x0600A387 RID: 41863 RVA: 0x0098D11C File Offset: 0x0098B31C
		// (set) Token: 0x0600A388 RID: 41864 RVA: 0x0098D1D0 File Offset: 0x0098B3D0
		internal int DataWideExternalDataModemPort_42851Min
		{
			get
			{
				short num = (short)1857704009;
				short num2 = num;
				num = (short)224219209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2099642368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1154023425;
				if (num != 0)
				{
				}
				num = (short)698482688;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.Min;
			}
			set
			{
				short num = (short)1128397296;
				short num2 = num;
				num = (short)899545584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)838008832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)927531009;
				if (num != 0)
				{
				}
				num = (short)1229455360;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.Min = value;
			}
		}

		// Token: 0x170051E3 RID: 20963
		// (get) Token: 0x0600A389 RID: 41865 RVA: 0x0098D288 File Offset: 0x0098B488
		// (set) Token: 0x0600A38A RID: 41866 RVA: 0x0098D340 File Offset: 0x0098B540
		internal int DataWideExternalDataModemPort_42851Max
		{
			get
			{
				short num = (short)1367904549;
				short num2 = num;
				num = (short)1646956837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964048384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)468254721;
				if (num != 0)
				{
				}
				num = (short)562692096;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.Max;
			}
			set
			{
				short num = (short)1739313824;
				short num2 = num;
				num = (short)704238240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1893072896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2102198273;
				if (num != 0)
				{
				}
				num = (short)1887633408;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.Max = value;
			}
		}

		// Token: 0x170051E4 RID: 20964
		// (get) Token: 0x0600A38B RID: 41867 RVA: 0x0098D3F4 File Offset: 0x0098B5F4
		// (set) Token: 0x0600A38C RID: 41868 RVA: 0x0098D4A8 File Offset: 0x0098B6A8
		internal int DataWideExternalDataModemPort_42851Step
		{
			get
			{
				short num = (short)1389504614;
				short num2 = num;
				num = (short)2032740454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)606928896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2140864513;
				if (num != 0)
				{
				}
				num = (short)671612928;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.StepSize;
			}
			set
			{
				short num = (short)1052056766;
				short num2 = num;
				num = (short)535436478;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1491795968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)595329025;
				if (num != 0)
				{
				}
				num = (short)1392836608;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.StepSize = value;
			}
		}

		// Token: 0x170051E5 RID: 20965
		// (get) Token: 0x0600A38D RID: 41869 RVA: 0x0098D560 File Offset: 0x0098B760
		// (set) Token: 0x0600A38E RID: 41870 RVA: 0x0098D614 File Offset: 0x0098B814
		public bool DataWideExternalDataModemPort_42851_Applicable
		{
			get
			{
				short num = (short)1226680799;
				short num2 = num;
				num = (short)1463134687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)859832320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307377665;
				if (num != 0)
				{
				}
				num = (short)782368768;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.Applicable;
			}
			set
			{
				short num = (short)92776548;
				short num2 = num;
				num = (short)552970340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872756736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)573898753;
				if (num != 0)
				{
				}
				num = (short)1674575872;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.Applicable = value;
			}
		}

		// Token: 0x170051E6 RID: 20966
		// (get) Token: 0x0600A38F RID: 41871 RVA: 0x0098D6C8 File Offset: 0x0098B8C8
		// (set) Token: 0x0600A390 RID: 41872 RVA: 0x0098D77C File Offset: 0x0098B97C
		public bool DataWideExternalDataModemPort_42851_Valid
		{
			get
			{
				short num = (short)2096950131;
				short num2 = num;
				num = (short)1867115379;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1919614976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1499987969;
				if (num != 0)
				{
				}
				num = (short)1365770240;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.Valid;
			}
			set
			{
				short num = (short)797518825;
				short num2 = num;
				num = (short)1697262569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26542080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1072103425;
				if (num != 0)
				{
				}
				num = (short)964820992;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.Valid = value;
			}
		}

		// Token: 0x170051E7 RID: 20967
		// (get) Token: 0x0600A391 RID: 41873 RVA: 0x0098D834 File Offset: 0x0098BA34
		// (set) Token: 0x0600A392 RID: 41874 RVA: 0x0098D8E8 File Offset: 0x0098BAE8
		public bool DataWideExternalDataModemPort_42851_Visible
		{
			get
			{
				short num = (short)1604386817;
				if (num != 0)
				{
				}
				num = (short)664535040;
				short num2 = num;
				num = (short)1159063181;
				short num3 = num;
				num = (short)14804621;
				switch (num3 == num)
				{
				}
				num = (short)1476657152;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.Visible;
			}
			set
			{
				short num = (short)1221328897;
				if (num != 0)
				{
				}
				num = (short)782958592;
				short num2 = num;
				num = (short)146701810;
				short num3 = num;
				num = (short)1956085234;
				switch (num3 == num)
				{
				}
				num = (short)928907264;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.Visible = value;
			}
		}

		// Token: 0x170051E8 RID: 20968
		// (get) Token: 0x0600A393 RID: 41875 RVA: 0x0098D9A0 File Offset: 0x0098BBA0
		// (set) Token: 0x0600A394 RID: 41876 RVA: 0x0098DA54 File Offset: 0x0098BC54
		public bool DataWideExternalDataModemPort_42851_Editable
		{
			get
			{
				short num = (short)1082851329;
				if (num != 0)
				{
				}
				num = (short)647036928;
				short num2 = num;
				num = (short)101529588;
				short num3 = num;
				num = (short)1570125812;
				switch (num3 == num)
				{
				}
				num = (short)1555431424;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.Editable;
			}
			set
			{
				short num = (short)766480353;
				short num2 = num;
				num = (short)1409126369;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093613056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1979056129;
				if (num != 0)
				{
				}
				num = (short)1545535488;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.Editable = value;
			}
		}

		// Token: 0x170051E9 RID: 20969
		// (get) Token: 0x0600A395 RID: 41877 RVA: 0x0098DB08 File Offset: 0x0098BD08
		internal string DataWideExternalDataModemPort_42851_UILabel
		{
			get
			{
				short num = (short)189628684;
				short num2 = num;
				num = (short)1047232780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1653014528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1454374912;
				if (num != 0)
				{
				}
				num = (short)1138163713;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.UIName;
			}
		}

		// Token: 0x170051EA RID: 20970
		// (get) Token: 0x0600A396 RID: 41878 RVA: 0x0098DBBC File Offset: 0x0098BDBC
		// (set) Token: 0x0600A397 RID: 41879 RVA: 0x0098DC70 File Offset: 0x0098BE70
		internal bool DataWideExternalDataModemPort_42851_HiddenStatic
		{
			get
			{
				short num = (short)1228821833;
				short num2 = num;
				num = (short)1919964489;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1400242176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)658898945;
				if (num != 0)
				{
				}
				num = (short)204079104;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.HiddenStatic;
			}
			set
			{
				short num = (short)1627733485;
				short num2 = num;
				num = (short)987905517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)575012864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1417412609;
				if (num != 0)
				{
				}
				num = (short)936443904;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.HiddenStatic = value;
			}
		}

		// Token: 0x170051EB RID: 20971
		// (get) Token: 0x0600A398 RID: 41880 RVA: 0x0098DD24 File Offset: 0x0098BF24
		// (set) Token: 0x0600A399 RID: 41881 RVA: 0x0098DDDC File Offset: 0x0098BFDC
		internal bool DataWideExternalDataModemPort_42851_HiddenDynamic
		{
			get
			{
				short num = (short)599372250;
				short num2 = num;
				num = (short)794014170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1878327296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)89063425;
				if (num != 0)
				{
				}
				num = (short)1309605888;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851.HiddenDynamic;
			}
			set
			{
				short num = (short)1281127960;
				short num2 = num;
				num = (short)1464170008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)516161536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1827995649;
				if (num != 0)
				{
				}
				num = (short)1084096512;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPort_42851.HiddenDynamic = value;
			}
		}

		// Token: 0x170051EC RID: 20972
		// (get) Token: 0x0600A39A RID: 41882 RVA: 0x0098DE90 File Offset: 0x0098C090
		public bool DataWideExternalDataModemPort_42851_HasDiffs
		{
			get
			{
				short num = (short)1174675201;
				short num2 = num;
				num = (short)166076161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1911291904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1925251073;
				if (num != 0)
				{
				}
				num = (short)1338900480;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPort_42851._HasDiffs;
			}
		}

		// Token: 0x170051ED RID: 20973
		// (get) Token: 0x0600A39B RID: 41883 RVA: 0x0098DF44 File Offset: 0x0098C144
		// (set) Token: 0x0600A39C RID: 41884 RVA: 0x0098DFF8 File Offset: 0x0098C1F8
		public int DataWideExternalDataModemOutOfRangeThreshold_42853Value
		{
			get
			{
				short num = (short)1525084769;
				short num2 = num;
				num = (short)1413411425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)38535168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)795607040;
				if (num != 0)
				{
				}
				num = (short)1659961345;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.Value;
			}
			set
			{
				short num = (short)1839202305;
				if (num != 0)
				{
				}
				num = (short)540213248;
				short num2 = num;
				num = (short)161105129;
				short num3 = num;
				num = (short)1107182825;
				switch (num3 == num)
				{
				}
				num = (short)1937244160;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.Value = value;
			}
		}

		// Token: 0x170051EE RID: 20974
		// (get) Token: 0x0600A39D RID: 41885 RVA: 0x0098E0B0 File Offset: 0x0098C2B0
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataModemOutOfRangeThreshold_42853
		{
			get
			{
				short num = (short)1094713749;
				short num2 = num;
				num = (short)1860305301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1902575616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)738787329;
				if (num != 0)
				{
				}
				num = (short)1695612928;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853;
			}
		}

		// Token: 0x170051EF RID: 20975
		// (get) Token: 0x0600A39E RID: 41886 RVA: 0x0098E160 File Offset: 0x0098C360
		// (set) Token: 0x0600A39F RID: 41887 RVA: 0x0098E218 File Offset: 0x0098C418
		public string DataWideExternalDataModemOutOfRangeThreshold_42853_UIValue
		{
			get
			{
				short num = (short)1728615664;
				short num2 = num;
				num = (short)1539675376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)850067456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1641086976;
				if (num != 0)
				{
				}
				num = (short)241958913;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.UIValue;
			}
			set
			{
				short num = (short)654060136;
				short num2 = num;
				num = (short)941238888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)914948096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2055536640;
				if (num != 0)
				{
				}
				num = (short)656867329;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.UIValue = value;
			}
		}

		// Token: 0x170051F0 RID: 20976
		// (get) Token: 0x0600A3A0 RID: 41888 RVA: 0x0098E2CC File Offset: 0x0098C4CC
		// (set) Token: 0x0600A3A1 RID: 41889 RVA: 0x0098E380 File Offset: 0x0098C580
		internal int DataWideExternalDataModemOutOfRangeThreshold_42853Min
		{
			get
			{
				short num = (short)125304833;
				if (num != 0)
				{
				}
				num = (short)1547239424;
				short num2 = num;
				num = (short)2079704544;
				short num3 = num;
				num = (short)1849869792;
				switch (num3 == num)
				{
				}
				num = (short)875233280;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.Min;
			}
			set
			{
				short num = (short)481750608;
				short num2 = num;
				num = (short)1687940688;
				switch (num2 == num)
				{
				default:
				{
					num = (short)46071808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)649396225;
				if (num != 0)
				{
				}
				num = (short)1555103744;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.Min = value;
			}
		}

		// Token: 0x170051F1 RID: 20977
		// (get) Token: 0x0600A3A2 RID: 41890 RVA: 0x0098E434 File Offset: 0x0098C634
		// (set) Token: 0x0600A3A3 RID: 41891 RVA: 0x0098E4E8 File Offset: 0x0098C6E8
		internal int DataWideExternalDataModemOutOfRangeThreshold_42853Max
		{
			get
			{
				short num = (short)552676852;
				short num2 = num;
				num = (short)1839934964;
				switch (num2 == num)
				{
				}
				num = (short)217776129;
				if (num != 0)
				{
				}
				num = (short)205979648;
				short num3 = num;
				num = (short)2017329152;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.Max;
			}
			set
			{
				short num = (short)1901884290;
				short num2 = num;
				num = (short)1697018754;
				switch (num2 == num)
				{
				}
				num = (short)800063489;
				if (num != 0)
				{
				}
				num = (short)877002752;
				short num3 = num;
				num = (short)500891648;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.Max = value;
			}
		}

		// Token: 0x170051F2 RID: 20978
		// (get) Token: 0x0600A3A4 RID: 41892 RVA: 0x0098E5A0 File Offset: 0x0098C7A0
		// (set) Token: 0x0600A3A5 RID: 41893 RVA: 0x0098E654 File Offset: 0x0098C854
		internal int DataWideExternalDataModemOutOfRangeThreshold_42853Step
		{
			get
			{
				short num = (short)1815460863;
				short num2 = num;
				num = (short)2145500159;
				switch (num2 == num)
				{
				}
				num = (short)217448449;
				if (num != 0)
				{
				}
				num = (short)1331429376;
				short num3 = num;
				num = (short)1804337152;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.StepSize;
			}
			set
			{
				short num = (short)958580499;
				short num2 = num;
				num = (short)1885128467;
				switch (num2 == num)
				{
				}
				num = (short)68026368;
				if (num != 0)
				{
				}
				num = (short)1111949312;
				short num3 = num;
				num = (short)655491073;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.StepSize = value;
			}
		}

		// Token: 0x170051F3 RID: 20979
		// (get) Token: 0x0600A3A6 RID: 41894 RVA: 0x0098E708 File Offset: 0x0098C908
		// (set) Token: 0x0600A3A7 RID: 41895 RVA: 0x0098E7BC File Offset: 0x0098C9BC
		public bool DataWideExternalDataModemOutOfRangeThreshold_42853_Applicable
		{
			get
			{
				short num = (short)690170162;
				short num2 = num;
				num = (short)1639655730;
				switch (num2 == num)
				{
				}
				num = (short)1467219969;
				if (num != 0)
				{
				}
				num = (short)1512898560;
				short num3 = num;
				num = (short)1036845056;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.Applicable;
			}
			set
			{
				short num = (short)488183626;
				short num2 = num;
				num = (short)400234314;
				switch (num2 == num)
				{
				}
				num = (short)189988865;
				if (num != 0)
				{
				}
				num = (short)2047868928;
				short num3 = num;
				num = (short)37093376;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.Applicable = value;
			}
		}

		// Token: 0x170051F4 RID: 20980
		// (get) Token: 0x0600A3A8 RID: 41896 RVA: 0x0098E874 File Offset: 0x0098CA74
		// (set) Token: 0x0600A3A9 RID: 41897 RVA: 0x0098E928 File Offset: 0x0098CB28
		public bool DataWideExternalDataModemOutOfRangeThreshold_42853_Valid
		{
			get
			{
				short num = (short)1755971585;
				if (num != 0)
				{
				}
				num = (short)946182531;
				short num2 = num;
				num = (short)2022480259;
				switch (num2 == num)
				{
				}
				num = (short)1081409536;
				short num3 = num;
				num = (short)1203372032;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.Valid;
			}
			set
			{
				short num = (short)2020972515;
				short num2 = num;
				num = (short)440637411;
				switch (num2 == num)
				{
				}
				num = (short)866713601;
				if (num != 0)
				{
				}
				num = (short)1270546432;
				short num3 = num;
				num = (short)1317732352;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.Valid = value;
			}
		}

		// Token: 0x170051F5 RID: 20981
		// (get) Token: 0x0600A3AA RID: 41898 RVA: 0x0098E9E0 File Offset: 0x0098CBE0
		// (set) Token: 0x0600A3AB RID: 41899 RVA: 0x0098EA94 File Offset: 0x0098CC94
		public bool DataWideExternalDataModemOutOfRangeThreshold_42853_Visible
		{
			get
			{
				short num = (short)1913433598;
				short num2 = num;
				num = (short)698854910;
				switch (num2 == num)
				{
				}
				num = (short)2042036225;
				if (num != 0)
				{
				}
				num = (short)1244200960;
				short num3 = num;
				num = (short)412090368;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.Visible;
			}
			set
			{
				short num = (short)1743665097;
				short num2 = num;
				num = (short)1997879241;
				switch (num2 == num)
				{
				}
				num = (short)1488388097;
				if (num != 0)
				{
				}
				num = (short)41287680;
				short num3 = num;
				num = (short)1379139584;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.Visible = value;
			}
		}

		// Token: 0x170051F6 RID: 20982
		// (get) Token: 0x0600A3AC RID: 41900 RVA: 0x0098EB48 File Offset: 0x0098CD48
		// (set) Token: 0x0600A3AD RID: 41901 RVA: 0x0098EBFC File Offset: 0x0098CDFC
		public bool DataWideExternalDataModemOutOfRangeThreshold_42853_Editable
		{
			get
			{
				short num = (short)9864924;
				short num2 = num;
				num = (short)1843955420;
				switch (num2 == num)
				{
				}
				num = (short)1895497729;
				if (num != 0)
				{
				}
				num = (short)1075511296;
				short num3 = num;
				num = (short)967442432;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.Editable;
			}
			set
			{
				short num = (short)1087555282;
				short num2 = num;
				num = (short)201705170;
				switch (num2 == num)
				{
				}
				num = (short)1783824385;
				if (num != 0)
				{
				}
				num = (short)1793785856;
				short num3 = num;
				num = (short)1887502336;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.Editable = value;
			}
		}

		// Token: 0x170051F7 RID: 20983
		// (get) Token: 0x0600A3AE RID: 41902 RVA: 0x0098ECB4 File Offset: 0x0098CEB4
		internal string DataWideExternalDataModemOutOfRangeThreshold_42853_UILabel
		{
			get
			{
				short num = (short)1753609823;
				short num2 = num;
				num = (short)1751316063;
				switch (num2 == num)
				{
				}
				num = (short)2026110977;
				if (num != 0)
				{
				}
				num = (short)454164480;
				short num3 = num;
				num = (short)1067646976;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.UIName;
			}
		}

		// Token: 0x170051F8 RID: 20984
		// (get) Token: 0x0600A3AF RID: 41903 RVA: 0x0098ED68 File Offset: 0x0098CF68
		// (set) Token: 0x0600A3B0 RID: 41904 RVA: 0x0098EE1C File Offset: 0x0098D01C
		internal bool DataWideExternalDataModemOutOfRangeThreshold_42853_HiddenStatic
		{
			get
			{
				short num = (short)177953606;
				short num2 = num;
				num = (short)1702124358;
				switch (num2 == num)
				{
				}
				num = (short)534315009;
				if (num != 0)
				{
				}
				num = (short)1115619328;
				short num3 = num;
				num = (short)1798307840;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.HiddenStatic;
			}
			set
			{
				short num = (short)1541585816;
				short num2 = num;
				num = (short)1806941080;
				switch (num2 == num)
				{
				}
				num = (short)764936193;
				if (num != 0)
				{
				}
				num = (short)862846976;
				short num3 = num;
				num = (short)158334976;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.HiddenStatic = value;
			}
		}

		// Token: 0x170051F9 RID: 20985
		// (get) Token: 0x0600A3B1 RID: 41905 RVA: 0x0098EED4 File Offset: 0x0098D0D4
		// (set) Token: 0x0600A3B2 RID: 41906 RVA: 0x0098EF88 File Offset: 0x0098D188
		internal bool DataWideExternalDataModemOutOfRangeThreshold_42853_HiddenDynamic
		{
			get
			{
				short num = (short)500922450;
				short num2 = num;
				num = (short)284784722;
				switch (num2 == num)
				{
				}
				num = (short)159514625;
				if (num != 0)
				{
				}
				num = (short)1759313920;
				short num3 = num;
				num = (short)1093140480;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853.HiddenDynamic;
			}
			set
			{
				short num = (short)1748862052;
				short num2 = num;
				num = (short)24478820;
				switch (num2 == num)
				{
				}
				num = (short)1289093121;
				if (num != 0)
				{
				}
				num = (short)784334848;
				short num3 = num;
				num = (short)1682309120;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOutOfRangeThreshold_42853.HiddenDynamic = value;
			}
		}

		// Token: 0x170051FA RID: 20986
		// (get) Token: 0x0600A3B3 RID: 41907 RVA: 0x0098F040 File Offset: 0x0098D240
		public bool DataWideExternalDataModemOutOfRangeThreshold_42853_HasDiffs
		{
			get
			{
				short num = (short)526932574;
				short num2 = num;
				num = (short)1600608862;
				switch (num2 == num)
				{
				}
				num = (short)283836417;
				if (num != 0)
				{
				}
				num = (short)202899456;
				short num3 = num;
				num = (short)624951296;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOutOfRangeThreshold_42853._HasDiffs;
			}
		}

		// Token: 0x170051FB RID: 20987
		// (get) Token: 0x0600A3B4 RID: 41908 RVA: 0x0098F0F4 File Offset: 0x0098D2F4
		// (set) Token: 0x0600A3B5 RID: 41909 RVA: 0x0098F1A8 File Offset: 0x0098D3A8
		public int DataWideExternalDataModemPowerupMaxGuardTime_42855Value
		{
			get
			{
				short num = (short)1675427841;
				if (num != 0)
				{
				}
				num = (short)1594695453;
				short num2 = num;
				num = (short)984162077;
				switch (num2 == num)
				{
				}
				num = (short)1160642560;
				short num3 = num;
				num = (short)218693632;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Value;
			}
			set
			{
				short num = (short)233485088;
				short num2 = num;
				num = (short)1331933984;
				switch (num2 == num)
				{
				}
				num = (short)1013252097;
				if (num != 0)
				{
				}
				num = (short)244973568;
				short num3 = num;
				num = (short)1802043392;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Value = value;
			}
		}

		// Token: 0x170051FC RID: 20988
		// (get) Token: 0x0600A3B6 RID: 41910 RVA: 0x0098F260 File Offset: 0x0098D460
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataModemPowerupMaxGuardTime_42855
		{
			get
			{
				short num = (short)1676528281;
				short num2 = num;
				num = (short)1829358233;
				switch (num2 == num)
				{
				}
				num = (short)364118017;
				if (num != 0)
				{
				}
				num = (short)1020723200;
				short num3 = num;
				num = (short)1133314048;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855;
			}
		}

		// Token: 0x170051FD RID: 20989
		// (get) Token: 0x0600A3B7 RID: 41911 RVA: 0x0098F310 File Offset: 0x0098D510
		// (set) Token: 0x0600A3B8 RID: 41912 RVA: 0x0098F3C4 File Offset: 0x0098D5C4
		public string DataWideExternalDataModemPowerupMaxGuardTime_42855_UIValue
		{
			get
			{
				short num = (short)786227966;
				short num2 = num;
				num = (short)1174725374;
				switch (num2 == num)
				{
				}
				num = (short)879951873;
				if (num != 0)
				{
				}
				num = (short)91947008;
				short num3 = num;
				num = (short)1468465152;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.UIValue;
			}
			set
			{
				short num = (short)152870885;
				short num2 = num;
				num = (short)2028904421;
				switch (num2 == num)
				{
				}
				num = (short)1010761728;
				if (num != 0)
				{
				}
				num = (short)507183104;
				short num3 = num;
				num = (short)1676541953;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.UIValue = value;
			}
		}

		// Token: 0x170051FE RID: 20990
		// (get) Token: 0x0600A3B9 RID: 41913 RVA: 0x0098F478 File Offset: 0x0098D678
		// (set) Token: 0x0600A3BA RID: 41914 RVA: 0x0098F52C File Offset: 0x0098D72C
		internal int DataWideExternalDataModemPowerupMaxGuardTime_42855Min
		{
			get
			{
				short num = (short)743768952;
				short num2 = num;
				num = (short)1156187000;
				switch (num2 == num)
				{
				}
				num = (short)883621888;
				if (num != 0)
				{
				}
				num = (short)50855936;
				short num3 = num;
				num = (short)333053953;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Min;
			}
			set
			{
				short num = (short)2029993426;
				short num2 = num;
				num = (short)938950098;
				switch (num2 == num)
				{
				}
				num = (short)74645505;
				if (num != 0)
				{
				}
				num = (short)1586626560;
				short num3 = num;
				num = (short)1574043648;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Min = value;
			}
		}

		// Token: 0x170051FF RID: 20991
		// (get) Token: 0x0600A3BB RID: 41915 RVA: 0x0098F5E0 File Offset: 0x0098D7E0
		// (set) Token: 0x0600A3BC RID: 41916 RVA: 0x0098F694 File Offset: 0x0098D894
		internal int DataWideExternalDataModemPowerupMaxGuardTime_42855Max
		{
			get
			{
				short num = (short)1840637973;
				short num2 = num;
				num = (short)1171646485;
				switch (num2 == num)
				{
				}
				num = (short)878706689;
				if (num != 0)
				{
				}
				num = (short)1037959168;
				short num3 = num;
				num = (short)58720256;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Max;
			}
			set
			{
				short num = (short)821115003;
				short num2 = num;
				num = (short)1713911931;
				switch (num2 == num)
				{
				}
				num = (short)492830720;
				if (num != 0)
				{
				}
				num = (short)539295744;
				short num3 = num;
				num = (short)1563688961;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Max = value;
			}
		}

		// Token: 0x17005200 RID: 20992
		// (get) Token: 0x0600A3BD RID: 41917 RVA: 0x0098F74C File Offset: 0x0098D94C
		// (set) Token: 0x0600A3BE RID: 41918 RVA: 0x0098F800 File Offset: 0x0098DA00
		internal int DataWideExternalDataModemPowerupMaxGuardTime_42855Step
		{
			get
			{
				short num = (short)110720568;
				short num2 = num;
				num = (short)1554478648;
				switch (num2 == num)
				{
				}
				num = (short)729088001;
				if (num != 0)
				{
				}
				num = (short)949420032;
				short num3 = num;
				num = (short)836501504;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.StepSize;
			}
			set
			{
				short num = (short)1848642399;
				short num2 = num;
				num = (short)891095903;
				switch (num2 == num)
				{
				}
				num = (short)2056060929;
				if (num != 0)
				{
				}
				num = (short)403308544;
				short num3 = num;
				num = (short)1776877568;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.StepSize = value;
			}
		}

		// Token: 0x17005201 RID: 20993
		// (get) Token: 0x0600A3BF RID: 41919 RVA: 0x0098F8B4 File Offset: 0x0098DAB4
		// (set) Token: 0x0600A3C0 RID: 41920 RVA: 0x0098F968 File Offset: 0x0098DB68
		public bool DataWideExternalDataModemPowerupMaxGuardTime_42855_Applicable
		{
			get
			{
				short num = (short)662698075;
				short num2 = num;
				num = (short)498464859;
				switch (num2 == num)
				{
				}
				num = (short)1622212609;
				if (num != 0)
				{
				}
				num = (short)1315373056;
				short num3 = num;
				num = (short)275513344;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Applicable;
			}
			set
			{
				short num = (short)1328217140;
				short num2 = num;
				num = (short)428604468;
				switch (num2 == num)
				{
				}
				num = (short)157286400;
				if (num != 0)
				{
				}
				num = (short)1096351744;
				short num3 = num;
				num = (short)163643393;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Applicable = value;
			}
		}

		// Token: 0x17005202 RID: 20994
		// (get) Token: 0x0600A3C1 RID: 41921 RVA: 0x0098FA20 File Offset: 0x0098DC20
		// (set) Token: 0x0600A3C2 RID: 41922 RVA: 0x0098FAD8 File Offset: 0x0098DCD8
		public bool DataWideExternalDataModemPowerupMaxGuardTime_42855_Valid
		{
			get
			{
				short num = (short)33335351;
				short num2 = num;
				num = (short)2112727095;
				switch (num2 == num)
				{
				}
				num = (short)512294913;
				if (num != 0)
				{
				}
				num = (short)600178688;
				short num3 = num;
				num = (short)1310064640;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Valid;
			}
			set
			{
				short num = (short)784138241;
				if (num != 0)
				{
				}
				num = (short)1317692037;
				short num2 = num;
				num = (short)243491461;
				switch (num2 == num)
				{
				}
				num = (short)1672740864;
				short num3 = num;
				num = (short)53215232;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Valid = value;
			}
		}

		// Token: 0x17005203 RID: 20995
		// (get) Token: 0x0600A3C3 RID: 41923 RVA: 0x0098FB90 File Offset: 0x0098DD90
		// (set) Token: 0x0600A3C4 RID: 41924 RVA: 0x0098FC48 File Offset: 0x0098DE48
		public bool DataWideExternalDataModemPowerupMaxGuardTime_42855_Visible
		{
			get
			{
				short num = (short)2081697389;
				short num2 = num;
				num = (short)1295396461;
				switch (num2 == num)
				{
				}
				num = (short)1853030401;
				if (num != 0)
				{
				}
				num = (short)1907294208;
				short num3 = num;
				num = (short)1745813504;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Visible;
			}
			set
			{
				short num = (short)1502641131;
				short num2 = num;
				num = (short)1612413931;
				switch (num2 == num)
				{
				}
				num = (short)1295384576;
				if (num != 0)
				{
				}
				num = (short)453115904;
				short num3 = num;
				num = (short)876937217;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Visible = value;
			}
		}

		// Token: 0x17005204 RID: 20996
		// (get) Token: 0x0600A3C5 RID: 41925 RVA: 0x0098FD00 File Offset: 0x0098DF00
		// (set) Token: 0x0600A3C6 RID: 41926 RVA: 0x0098FDB4 File Offset: 0x0098DFB4
		public bool DataWideExternalDataModemPowerupMaxGuardTime_42855_Editable
		{
			get
			{
				short num = (short)1313354978;
				short num2 = num;
				num = (short)62928098;
				switch (num2 == num)
				{
				}
				num = (short)1996095489;
				if (num != 0)
				{
				}
				num = (short)1884422144;
				short num3 = num;
				num = (short)48824320;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Editable;
			}
			set
			{
				short num = (short)37367667;
				short num2 = num;
				num = (short)755773299;
				switch (num2 == num)
				{
				}
				num = (short)1202126848;
				if (num != 0)
				{
				}
				num = (short)1596719104;
				short num3 = num;
				num = (short)1333460993;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.Editable = value;
			}
		}

		// Token: 0x17005205 RID: 20997
		// (get) Token: 0x0600A3C7 RID: 41927 RVA: 0x0098FE68 File Offset: 0x0098E068
		internal string DataWideExternalDataModemPowerupMaxGuardTime_42855_UILabel
		{
			get
			{
				short num = (short)1067345109;
				short num2 = num;
				num = (short)871130325;
				switch (num2 == num)
				{
				}
				num = (short)770310144;
				if (num != 0)
				{
				}
				num = (short)287506432;
				short num3 = num;
				num = (short)1734541313;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.UIName;
			}
		}

		// Token: 0x17005206 RID: 20998
		// (get) Token: 0x0600A3C8 RID: 41928 RVA: 0x0098FF20 File Offset: 0x0098E120
		// (set) Token: 0x0600A3C9 RID: 41929 RVA: 0x0098FFD4 File Offset: 0x0098E1D4
		internal bool DataWideExternalDataModemPowerupMaxGuardTime_42855_HiddenStatic
		{
			get
			{
				short num = (short)1335082331;
				short num2 = num;
				num = (short)147307867;
				switch (num2 == num)
				{
				}
				num = (short)584515585;
				if (num != 0)
				{
				}
				num = (short)352976896;
				short num3 = num;
				num = (short)1192558592;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.HiddenStatic;
			}
			set
			{
				short num = (short)477193895;
				short num2 = num;
				num = (short)1926456999;
				switch (num2 == num)
				{
				}
				num = (short)1665335297;
				if (num != 0)
				{
				}
				num = (short)223674368;
				short num3 = num;
				num = (short)674103296;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.HiddenStatic = value;
			}
		}

		// Token: 0x17005207 RID: 20999
		// (get) Token: 0x0600A3CA RID: 41930 RVA: 0x00990088 File Offset: 0x0098E288
		// (set) Token: 0x0600A3CB RID: 41931 RVA: 0x00990140 File Offset: 0x0098E340
		internal bool DataWideExternalDataModemPowerupMaxGuardTime_42855_HiddenDynamic
		{
			get
			{
				short num = (short)482778736;
				short num2 = num;
				num = (short)351772272;
				switch (num2 == num)
				{
				}
				num = (short)1258815488;
				if (num != 0)
				{
				}
				num = (short)267059200;
				short num3 = num;
				num = (short)1826553857;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855.HiddenDynamic;
			}
			set
			{
				short num = (short)1923151870;
				short num2 = num;
				num = (short)329185278;
				switch (num2 == num)
				{
				}
				num = (short)533331969;
				if (num != 0)
				{
				}
				num = (short)806027264;
				short num3 = num;
				num = (short)349831168;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemPowerupMaxGuardTime_42855.HiddenDynamic = value;
			}
		}

		// Token: 0x17005208 RID: 21000
		// (get) Token: 0x0600A3CC RID: 41932 RVA: 0x009901F4 File Offset: 0x0098E3F4
		public bool DataWideExternalDataModemPowerupMaxGuardTime_42855_HasDiffs
		{
			get
			{
				short num = (short)1833751309;
				short num2 = num;
				num = (short)1809896205;
				switch (num2 == num)
				{
				}
				num = (short)580976641;
				if (num != 0)
				{
				}
				num = (short)1019281408;
				short num3 = num;
				num = (short)400097280;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemPowerupMaxGuardTime_42855._HasDiffs;
			}
		}

		// Token: 0x17005209 RID: 21001
		// (get) Token: 0x0600A3CD RID: 41933 RVA: 0x009902A8 File Offset: 0x0098E4A8
		// (set) Token: 0x0600A3CE RID: 41934 RVA: 0x0099035C File Offset: 0x0098E55C
		public int DataWideExternalDataModemOpenMaxGuardTime_42856Value
		{
			get
			{
				short num = (short)1209270273;
				if (num != 0)
				{
				}
				num = (short)1641291136;
				short num2 = num;
				num = (short)944446848;
				switch (num2 == num)
				{
				}
				num = (short)756547584;
				short num3 = num;
				num = (short)1356333056;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.Value;
			}
			set
			{
				short num = (short)1987229456;
				short num2 = num;
				num = (short)1576122128;
				switch (num2 == num)
				{
				}
				num = (short)2107965441;
				if (num != 0)
				{
				}
				num = (short)1375141888;
				short num3 = num;
				num = (short)16711680;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.Value = value;
			}
		}

		// Token: 0x1700520A RID: 21002
		// (get) Token: 0x0600A3CF RID: 41935 RVA: 0x00990414 File Offset: 0x0098E614
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataModemOpenMaxGuardTime_42856
		{
			get
			{
				short num = (short)358607624;
				short num2 = num;
				num = (short)929557256;
				switch (num2 == num)
				{
				}
				num = (short)539361280;
				if (num != 0)
				{
				}
				num = (short)2004942848;
				short num3 = num;
				num = (short)1087766529;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856;
			}
		}

		// Token: 0x1700520B RID: 21003
		// (get) Token: 0x0600A3D0 RID: 41936 RVA: 0x009904C4 File Offset: 0x0098E6C4
		// (set) Token: 0x0600A3D1 RID: 41937 RVA: 0x00990578 File Offset: 0x0098E778
		public string DataWideExternalDataModemOpenMaxGuardTime_42856_UIValue
		{
			get
			{
				short num = (short)1223262137;
				short num2 = num;
				num = (short)580419513;
				switch (num2 == num)
				{
				}
				num = (short)247332864;
				if (num != 0)
				{
				}
				num = (short)1240399872;
				short num3 = num;
				num = (short)1529741313;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.UIValue;
			}
			set
			{
				short num = (short)1766507451;
				short num2 = num;
				num = (short)1725481915;
				switch (num2 == num)
				{
				}
				num = (short)342163457;
				if (num != 0)
				{
				}
				num = (short)760479744;
				short num3 = num;
				num = (short)889847808;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.UIValue = value;
			}
		}

		// Token: 0x1700520C RID: 21004
		// (get) Token: 0x0600A3D2 RID: 41938 RVA: 0x0099062C File Offset: 0x0098E82C
		// (set) Token: 0x0600A3D3 RID: 41939 RVA: 0x009906E0 File Offset: 0x0098E8E0
		internal int DataWideExternalDataModemOpenMaxGuardTime_42856Min
		{
			get
			{
				short num = (short)1994274504;
				short num2 = num;
				num = (short)184301256;
				switch (num2 == num)
				{
				}
				num = (short)1517092865;
				if (num != 0)
				{
				}
				num = (short)1018953728;
				short num3 = num;
				num = (short)849215488;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.Min;
			}
			set
			{
				short num = (short)1185270934;
				short num2 = num;
				num = (short)1181863062;
				switch (num2 == num)
				{
				}
				num = (short)1043791872;
				if (num != 0)
				{
				}
				num = (short)1765539840;
				short num3 = num;
				num = (short)1166344193;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.Min = value;
			}
		}

		// Token: 0x1700520D RID: 21005
		// (get) Token: 0x0600A3D4 RID: 41940 RVA: 0x00990798 File Offset: 0x0098E998
		// (set) Token: 0x0600A3D5 RID: 41941 RVA: 0x0099084C File Offset: 0x0098EA4C
		internal int DataWideExternalDataModemOpenMaxGuardTime_42856Max
		{
			get
			{
				short num = (short)949452080;
				short num2 = num;
				num = (short)350911792;
				switch (num2 == num)
				{
				}
				num = (short)1590689792;
				if (num != 0)
				{
				}
				num = (short)495058944;
				short num3 = num;
				num = (short)1013383169;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.Max;
			}
			set
			{
				short num = (short)2136997888;
				short num2 = num;
				num = (short)21379729;
				short num3 = num;
				num = (short)1364408977;
				switch (num3 == num)
				{
				}
				num = (short)962396161;
				if (num != 0)
				{
				}
				num = (short)1543110656;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.Max = value;
			}
		}

		// Token: 0x1700520E RID: 21006
		// (get) Token: 0x0600A3D6 RID: 41942 RVA: 0x00990900 File Offset: 0x0098EB00
		// (set) Token: 0x0600A3D7 RID: 41943 RVA: 0x009909B4 File Offset: 0x0098EBB4
		internal int DataWideExternalDataModemOpenMaxGuardTime_42856Step
		{
			get
			{
				short num = (short)836370432;
				short num2 = num;
				num = (short)571280203;
				short num3 = num;
				num = (short)753929035;
				switch (num3 == num)
				{
				}
				num = (short)542310400;
				if (num != 0)
				{
				}
				num = (short)138936321;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.StepSize;
			}
			set
			{
				short num = (short)255328256;
				short num2 = num;
				num = (short)1272255168;
				short num3 = num;
				num = (short)840372928;
				switch (num3 == num)
				{
				}
				num = (short)1507721217;
				if (num != 0)
				{
				}
				num = (short)1970929664;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.StepSize = value;
			}
		}

		// Token: 0x1700520F RID: 21007
		// (get) Token: 0x0600A3D8 RID: 41944 RVA: 0x00990A6C File Offset: 0x0098EC6C
		// (set) Token: 0x0600A3D9 RID: 41945 RVA: 0x00990B20 File Offset: 0x0098ED20
		public bool DataWideExternalDataModemOpenMaxGuardTime_42856_Applicable
		{
			get
			{
				short num = (short)887816192;
				short num2 = num;
				num = (short)1476404151;
				short num3 = num;
				num = (short)1604461495;
				switch (num3 == num)
				{
				}
				num = (short)2057306112;
				if (num != 0)
				{
				}
				num = (short)1150287873;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.Applicable;
			}
			set
			{
				short num = (short)1765212160;
				short num2 = num;
				num = (short)1476919297;
				if (num != 0)
				{
				}
				num = (short)1987529461;
				short num3 = num;
				num = (short)140659445;
				switch (num3 == num)
				{
				}
				num = (short)1745420288;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.Applicable = value;
			}
		}

		// Token: 0x17005210 RID: 21008
		// (get) Token: 0x0600A3DA RID: 41946 RVA: 0x00990BD4 File Offset: 0x0098EDD4
		// (set) Token: 0x0600A3DB RID: 41947 RVA: 0x00990C88 File Offset: 0x0098EE88
		public bool DataWideExternalDataModemOpenMaxGuardTime_42856_Valid
		{
			get
			{
				short num = (short)1514602496;
				short num2 = num;
				num = (short)448648092;
				short num3 = num;
				num = (short)278057884;
				switch (num3 == num)
				{
				}
				num = (short)2049835008;
				if (num != 0)
				{
				}
				num = (short)763035649;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.Valid;
			}
			set
			{
				short num = (short)1942028288;
				short num2 = num;
				num = (short)701085831;
				short num3 = num;
				num = (short)226801799;
				switch (num3 == num)
				{
				}
				num = (short)1883176961;
				if (num != 0)
				{
				}
				num = (short)1934688256;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.Valid = value;
			}
		}

		// Token: 0x17005211 RID: 21009
		// (get) Token: 0x0600A3DC RID: 41948 RVA: 0x00990D3C File Offset: 0x0098EF3C
		// (set) Token: 0x0600A3DD RID: 41949 RVA: 0x00990DF4 File Offset: 0x0098EFF4
		public bool DataWideExternalDataModemOpenMaxGuardTime_42856_Visible
		{
			get
			{
				short num = (short)103350272;
				short num2 = num;
				num = (short)1395689793;
				short num3 = num;
				num = (short)1553434945;
				switch (num3 == num)
				{
				}
				num = (short)509476865;
				if (num != 0)
				{
				}
				num = (short)1821835264;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.Visible;
			}
			set
			{
				short num = (short)476119040;
				short num2 = num;
				num = (short)1905475869;
				short num3 = num;
				num = (short)727466269;
				switch (num3 == num)
				{
				}
				num = (short)718274560;
				if (num != 0)
				{
				}
				num = (short)428736513;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.Visible = value;
			}
		}

		// Token: 0x17005212 RID: 21010
		// (get) Token: 0x0600A3DE RID: 41950 RVA: 0x00990EA8 File Offset: 0x0098F0A8
		// (set) Token: 0x0600A3DF RID: 41951 RVA: 0x00990F5C File Offset: 0x0098F15C
		public bool DataWideExternalDataModemOpenMaxGuardTime_42856_Editable
		{
			get
			{
				short num = (short)681377792;
				short num2 = num;
				num = (short)566550222;
				short num3 = num;
				num = (short)1197006542;
				switch (num3 == num)
				{
				}
				num = (short)1983250432;
				if (num != 0)
				{
				}
				num = (short)252968961;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.Editable;
			}
			set
			{
				short num = (short)222429184;
				short num2 = num;
				num = (short)1358963531;
				short num3 = num;
				num = (short)957948747;
				switch (num3 == num)
				{
				}
				num = (short)1986396160;
				if (num != 0)
				{
				}
				num = (short)1200947201;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.Editable = value;
			}
		}

		// Token: 0x17005213 RID: 21011
		// (get) Token: 0x0600A3E0 RID: 41952 RVA: 0x00991010 File Offset: 0x0098F210
		internal string DataWideExternalDataModemOpenMaxGuardTime_42856_UILabel
		{
			get
			{
				short num = (short)1871052800;
				short num2 = num;
				num = (short)1420951553;
				if (num != 0)
				{
				}
				num = (short)744852611;
				short num3 = num;
				num = (short)186354819;
				switch (num3 == num)
				{
				}
				num = (short)1459552256;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.UIName;
			}
		}

		// Token: 0x17005214 RID: 21012
		// (get) Token: 0x0600A3E1 RID: 41953 RVA: 0x009910C4 File Offset: 0x0098F2C4
		// (set) Token: 0x0600A3E2 RID: 41954 RVA: 0x0099117C File Offset: 0x0098F37C
		internal bool DataWideExternalDataModemOpenMaxGuardTime_42856_HiddenStatic
		{
			get
			{
				short num = (short)1723924480;
				short num2 = num;
				num = (short)13153699;
				short num3 = num;
				num = (short)320386467;
				switch (num3 == num)
				{
				}
				num = (short)410976256;
				if (num != 0)
				{
				}
				num = (short)559415297;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.HiddenStatic;
			}
			set
			{
				short num = (short)1534590976;
				short num2 = num;
				num = (short)589839252;
				short num3 = num;
				num = (short)723008404;
				switch (num3 == num)
				{
				}
				num = (short)708247553;
				if (num != 0)
				{
				}
				num = (short)16711680;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.HiddenStatic = value;
			}
		}

		// Token: 0x17005215 RID: 21013
		// (get) Token: 0x0600A3E3 RID: 41955 RVA: 0x00991234 File Offset: 0x0098F434
		// (set) Token: 0x0600A3E4 RID: 41956 RVA: 0x009912E4 File Offset: 0x0098F4E4
		internal bool DataWideExternalDataModemOpenMaxGuardTime_42856_HiddenDynamic
		{
			get
			{
				short num = (short)2080374784;
				short num2 = num;
				num = (short)2129518245;
				short num3 = num;
				num = (short)227860133;
				switch (num3 == num)
				{
				}
				num = (short)584253440;
				if (num != 0)
				{
				}
				num = (short)2133000193;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856.HiddenDynamic;
			}
			set
			{
				short num = (short)1434910720;
				short num2 = num;
				num = (short)1816749132;
				short num3 = num;
				num = (short)7365708;
				switch (num3 == num)
				{
				}
				num = (short)731250689;
				if (num != 0)
				{
				}
				num = (short)1071841280;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenMaxGuardTime_42856.HiddenDynamic = value;
			}
		}

		// Token: 0x17005216 RID: 21014
		// (get) Token: 0x0600A3E5 RID: 41957 RVA: 0x0099139C File Offset: 0x0098F59C
		public bool DataWideExternalDataModemOpenMaxGuardTime_42856_HasDiffs
		{
			get
			{
				short num = (short)1881276416;
				short num2 = num;
				num = (short)778895361;
				if (num != 0)
				{
				}
				num = (short)1245825009;
				short num3 = num;
				num = (short)1817692145;
				switch (num3 == num)
				{
				}
				num = (short)1331167232;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenMaxGuardTime_42856._HasDiffs;
			}
		}

		// Token: 0x17005217 RID: 21015
		// (get) Token: 0x0600A3E6 RID: 41958 RVA: 0x00991450 File Offset: 0x0098F650
		// (set) Token: 0x0600A3E7 RID: 41959 RVA: 0x00991504 File Offset: 0x0098F704
		public int DataWideExternalDataModemVPNTunnel_43024Value
		{
			get
			{
				short num = (short)1753153536;
				short num2 = num;
				num = (short)1315561306;
				short num3 = num;
				num = (short)1119280986;
				switch (num3 == num)
				{
				}
				num = (short)1391919105;
				if (num != 0)
				{
				}
				num = (short)425066496;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.Value;
			}
			set
			{
				short num = (short)1980497920;
				short num2 = num;
				num = (short)1768457910;
				short num3 = num;
				num = (short)69830326;
				switch (num3 == num)
				{
				}
				num = (short)470417408;
				if (num != 0)
				{
				}
				num = (short)1280180225;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.Value = value;
			}
		}

		// Token: 0x17005218 RID: 21016
		// (get) Token: 0x0600A3E8 RID: 41960 RVA: 0x009915BC File Offset: 0x0098F7BC
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataModemVPNTunnel_43024
		{
			get
			{
				short num = (short)1780613120;
				short num2 = num;
				num = (short)868894942;
				short num3 = num;
				num = (short)1950632158;
				switch (num3 == num)
				{
				}
				num = (short)981991425;
				if (num != 0)
				{
				}
				num = (short)2138832896;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024;
			}
		}

		// Token: 0x17005219 RID: 21017
		// (get) Token: 0x0600A3E9 RID: 41961 RVA: 0x0099166C File Offset: 0x0098F86C
		// (set) Token: 0x0600A3EA RID: 41962 RVA: 0x00991720 File Offset: 0x0098F920
		public string DataWideExternalDataModemVPNTunnel_43024_UIValue
		{
			get
			{
				short num = (short)985137152;
				short num2 = num;
				num = (short)801709967;
				short num3 = num;
				num = (short)2108891023;
				switch (num3 == num)
				{
				}
				num = (short)1303052289;
				if (num != 0)
				{
				}
				num = (short)1157562368;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.UIValue;
			}
			set
			{
				short num = (short)770244608;
				short num2 = num;
				num = (short)539401475;
				short num3 = num;
				num = (short)760192259;
				switch (num3 == num)
				{
				}
				num = (short)914423808;
				if (num != 0)
				{
				}
				num = (short)1202126849;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.UIValue = value;
			}
		}

		// Token: 0x1700521A RID: 21018
		// (get) Token: 0x0600A3EB RID: 41963 RVA: 0x009917D8 File Offset: 0x0098F9D8
		// (set) Token: 0x0600A3EC RID: 41964 RVA: 0x0099188C File Offset: 0x0098FA8C
		internal int DataWideExternalDataModemVPNTunnel_43024Min
		{
			get
			{
				short num = (short)1907752960;
				short num2 = num;
				num = (short)1266202741;
				short num3 = num;
				num = (short)990886005;
				switch (num3 == num)
				{
				}
				num = (short)533266433;
				if (num != 0)
				{
				}
				num = (short)1972633600;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.Min;
			}
			set
			{
				short num = (short)1549139968;
				short num2 = num;
				num = (short)1091703983;
				short num3 = num;
				num = (short)923473071;
				switch (num3 == num)
				{
				}
				num = (short)1872166913;
				if (num != 0)
				{
				}
				num = (short)1141964800;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.Min = value;
			}
		}

		// Token: 0x1700521B RID: 21019
		// (get) Token: 0x0600A3ED RID: 41965 RVA: 0x00991944 File Offset: 0x0098FB44
		// (set) Token: 0x0600A3EE RID: 41966 RVA: 0x009919F8 File Offset: 0x0098FBF8
		internal int DataWideExternalDataModemVPNTunnel_43024Max
		{
			get
			{
				short num = (short)129171456;
				short num2 = num;
				num = (short)198431386;
				short num3 = num;
				num = (short)1152701082;
				switch (num3 == num)
				{
				}
				num = (short)175898625;
				if (num != 0)
				{
				}
				num = (short)2124414976;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.Max;
			}
			set
			{
				short num = (short)918290432;
				short num2 = num;
				num = (short)225054704;
				short num3 = num;
				num = (short)462819312;
				switch (num3 == num)
				{
				}
				num = (short)1095892993;
				if (num != 0)
				{
				}
				num = (short)1911029760;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.Max = value;
			}
		}

		// Token: 0x1700521C RID: 21020
		// (get) Token: 0x0600A3EF RID: 41967 RVA: 0x00991AB0 File Offset: 0x0098FCB0
		// (set) Token: 0x0600A3F0 RID: 41968 RVA: 0x00991B64 File Offset: 0x0098FD64
		internal int DataWideExternalDataModemVPNTunnel_43024Step
		{
			get
			{
				short num = (short)1966735360;
				short num2 = num;
				num = (short)896303717;
				short num3 = num;
				num = (short)532578917;
				switch (num3 == num)
				{
				}
				num = (short)594280449;
				if (num != 0)
				{
				}
				num = (short)135266304;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.StepSize;
			}
			set
			{
				short num = (short)1687158784;
				short num2 = num;
				num = (short)1780632680;
				short num3 = num;
				num = (short)968182888;
				switch (num3 == num)
				{
				}
				num = (short)748158977;
				if (num != 0)
				{
				}
				num = (short)1038024704;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.StepSize = value;
			}
		}

		// Token: 0x1700521D RID: 21021
		// (get) Token: 0x0600A3F1 RID: 41969 RVA: 0x00991C18 File Offset: 0x0098FE18
		// (set) Token: 0x0600A3F2 RID: 41970 RVA: 0x00991CCC File Offset: 0x0098FECC
		public bool DataWideExternalDataModemVPNTunnel_43024_Applicable
		{
			get
			{
				short num = (short)1702756352;
				short num2 = num;
				num = (short)201020106;
				short num3 = num;
				num = (short)1296126666;
				switch (num3 == num)
				{
				}
				num = (short)691863553;
				if (num != 0)
				{
				}
				num = (short)1868496896;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.Applicable;
			}
			set
			{
				short num = (short)1540751360;
				short num2 = num;
				num = (short)764045404;
				short num3 = num;
				num = (short)1669228636;
				switch (num3 == num)
				{
				}
				num = (short)348717056;
				if (num != 0)
				{
				}
				num = (short)460259329;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.Applicable = value;
			}
		}

		// Token: 0x1700521E RID: 21022
		// (get) Token: 0x0600A3F3 RID: 41971 RVA: 0x00991D80 File Offset: 0x0098FF80
		// (set) Token: 0x0600A3F4 RID: 41972 RVA: 0x00991E34 File Offset: 0x00990034
		public bool DataWideExternalDataModemVPNTunnel_43024_Valid
		{
			get
			{
				short num = (short)1021444096;
				short num2 = num;
				num = (short)1435858112;
				short num3 = num;
				num = (short)1118729408;
				switch (num3 == num)
				{
				}
				num = (short)45219841;
				if (num != 0)
				{
				}
				num = (short)960430080;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.Valid;
			}
			set
			{
				short num = (short)581500928;
				short num2 = num;
				num = (short)1016610671;
				short num3 = num;
				num = (short)493567855;
				switch (num3 == num)
				{
				}
				num = (short)405471232;
				if (num != 0)
				{
				}
				num = (short)1147666433;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.Valid = value;
			}
		}

		// Token: 0x1700521F RID: 21023
		// (get) Token: 0x0600A3F5 RID: 41973 RVA: 0x00991EEC File Offset: 0x009900EC
		// (set) Token: 0x0600A3F6 RID: 41974 RVA: 0x00991FA0 File Offset: 0x009901A0
		public bool DataWideExternalDataModemVPNTunnel_43024_Visible
		{
			get
			{
				short num = (short)494534656;
				short num2 = num;
				num = (short)794246856;
				short num3 = num;
				num = (short)969686728;
				switch (num3 == num)
				{
				}
				num = (short)1031798785;
				if (num != 0)
				{
				}
				num = (short)783810560;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.Visible;
			}
			set
			{
				short num = (short)577830912;
				short num2 = num;
				num = (short)474184491;
				short num3 = num;
				num = (short)1431206699;
				switch (num3 == num)
				{
				}
				num = (short)27721729;
				if (num != 0)
				{
				}
				num = (short)1557266432;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.Visible = value;
			}
		}

		// Token: 0x17005220 RID: 21024
		// (get) Token: 0x0600A3F7 RID: 41975 RVA: 0x00992058 File Offset: 0x00990258
		// (set) Token: 0x0600A3F8 RID: 41976 RVA: 0x0099210C File Offset: 0x0099030C
		public bool DataWideExternalDataModemVPNTunnel_43024_Editable
		{
			get
			{
				short num = (short)1281097728;
				short num2 = num;
				num = (short)2025701794;
				short num3 = num;
				num = (short)88719778;
				switch (num3 == num)
				{
				}
				num = (short)1778974721;
				if (num != 0)
				{
				}
				num = (short)1062273024;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.Editable;
			}
			set
			{
				short num = (short)1296498688;
				short num2 = num;
				num = (short)380148971;
				short num3 = num;
				num = (short)99261675;
				switch (num3 == num)
				{
				}
				num = (short)1306525697;
				if (num != 0)
				{
				}
				num = (short)1511915520;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.Editable = value;
			}
		}

		// Token: 0x17005221 RID: 21025
		// (get) Token: 0x0600A3F9 RID: 41977 RVA: 0x009921C0 File Offset: 0x009903C0
		internal string DataWideExternalDataModemVPNTunnel_43024_UILabel
		{
			get
			{
				short num = (short)1106116608;
				short num2 = num;
				num = (short)25644997;
				short num3 = num;
				num = (short)1727549381;
				switch (num3 == num)
				{
				}
				num = (short)1739718657;
				if (num != 0)
				{
				}
				num = (short)872939520;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.UIName;
			}
		}

		// Token: 0x17005222 RID: 21026
		// (get) Token: 0x0600A3FA RID: 41978 RVA: 0x00992274 File Offset: 0x00990474
		// (set) Token: 0x0600A3FB RID: 41979 RVA: 0x00992328 File Offset: 0x00990528
		internal bool DataWideExternalDataModemVPNTunnel_43024_HiddenStatic
		{
			get
			{
				short num = (short)634126336;
				short num2 = num;
				num = (short)1679428278;
				short num3 = num;
				num = (short)826477238;
				switch (num3 == num)
				{
				}
				num = (short)664141825;
				if (num != 0)
				{
				}
				num = (short)259260416;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.HiddenStatic;
			}
			set
			{
				short num = (short)250806272;
				short num2 = num;
				num = (short)688992502;
				short num3 = num;
				num = (short)758460662;
				switch (num3 == num)
				{
				}
				num = (short)1180499968;
				if (num != 0)
				{
				}
				num = (short)490536961;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.HiddenStatic = value;
			}
		}

		// Token: 0x17005223 RID: 21027
		// (get) Token: 0x0600A3FC RID: 41980 RVA: 0x009923DC File Offset: 0x009905DC
		// (set) Token: 0x0600A3FD RID: 41981 RVA: 0x00992490 File Offset: 0x00990690
		internal bool DataWideExternalDataModemVPNTunnel_43024_HiddenDynamic
		{
			get
			{
				short num = (short)1454964736;
				short num2 = num;
				num = (short)1865572677;
				short num3 = num;
				num = (short)786063685;
				switch (num3 == num)
				{
				}
				num = (short)1225916416;
				if (num != 0)
				{
				}
				num = (short)1369767937;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024.HiddenDynamic;
			}
			set
			{
				short num = (short)1367801856;
				short num2 = num;
				num = (short)2013492972;
				short num3 = num;
				num = (short)589919980;
				switch (num3 == num)
				{
				}
				num = (short)408485889;
				if (num != 0)
				{
				}
				num = (short)596377600;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNTunnel_43024.HiddenDynamic = value;
			}
		}

		// Token: 0x17005224 RID: 21028
		// (get) Token: 0x0600A3FE RID: 41982 RVA: 0x0099254C File Offset: 0x0099074C
		public bool DataWideExternalDataModemVPNTunnel_43024_HasDiffs
		{
			get
			{
				short num = (short)1173422080;
				short num2 = num;
				num = (short)1215093652;
				short num3 = num;
				num = (short)314432404;
				switch (num3 == num)
				{
				}
				num = (short)7536641;
				if (num != 0)
				{
				}
				num = (short)469172224;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNTunnel_43024._HasDiffs;
			}
		}

		// Token: 0x17005225 RID: 21029
		// (get) Token: 0x0600A3FF RID: 41983 RVA: 0x00992600 File Offset: 0x00990800
		// (set) Token: 0x0600A400 RID: 41984 RVA: 0x009926B8 File Offset: 0x009908B8
		public int ModemConnectionType_43350Value
		{
			get
			{
				short num = (short)1272446976;
				short num2 = num;
				num = (short)10714174;
				short num3 = num;
				num = (short)1972927550;
				switch (num3 == num)
				{
				}
				num = (short)718995456;
				if (num != 0)
				{
				}
				num = (short)1508966401;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350.Value;
			}
			set
			{
				short num = (short)856883200;
				short num2 = num;
				num = (short)488540120;
				short num3 = num;
				num = (short)1658685400;
				switch (num3 == num)
				{
				}
				num = (short)1217789953;
				if (num != 0)
				{
				}
				num = (short)517799936;
				if (num != 0)
				{
				}
				this.modemConnectionType_43350.Value = value;
			}
		}

		// Token: 0x17005226 RID: 21030
		// (get) Token: 0x0600A401 RID: 41985 RVA: 0x0099276C File Offset: 0x0099096C
		// (set) Token: 0x0600A402 RID: 41986 RVA: 0x0099281C File Offset: 0x00990A1C
		public string ModemConnectionType_43350_UIValue
		{
			get
			{
				short num = (short)1940258816;
				short num2 = num;
				num = (short)1128364837;
				short num3 = num;
				num = (short)270170917;
				switch (num3 == num)
				{
				}
				num = (short)859439105;
				if (num != 0)
				{
				}
				num = (short)1720057856;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350.UIValue;
			}
			set
			{
				short num = (short)184680448;
				short num2 = num;
				num = (short)1652321147;
				short num3 = num;
				num = (short)281635707;
				switch (num3 == num)
				{
				}
				num = (short)956956673;
				if (num != 0)
				{
				}
				num = (short)440795136;
				if (num != 0)
				{
				}
				this.modemConnectionType_43350.UIValue = value;
			}
		}

		// Token: 0x17005227 RID: 21031
		// (get) Token: 0x0600A403 RID: 41987 RVA: 0x009928D4 File Offset: 0x00990AD4
		public global::AcpBusinessLayer.AcpListField ModemConnectionType_43350
		{
			get
			{
				short num = (short)287375360;
				short num2 = num;
				num = (short)119676266;
				short num3 = num;
				num = (short)944971114;
				switch (num3 == num)
				{
				}
				num = (short)986120193;
				if (num != 0)
				{
				}
				num = (short)938999808;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350;
			}
		}

		// Token: 0x17005228 RID: 21032
		// (get) Token: 0x0600A404 RID: 41988 RVA: 0x00992984 File Offset: 0x00990B84
		// (set) Token: 0x0600A405 RID: 41989 RVA: 0x00992A38 File Offset: 0x00990C38
		public bool ModemConnectionType_43350_Applicable
		{
			get
			{
				short num = (short)1125253120;
				short num2 = num;
				num = (short)1300423147;
				short num3 = num;
				num = (short)1277485547;
				switch (num3 == num)
				{
				}
				num = (short)470810625;
				if (num != 0)
				{
				}
				num = (short)144441344;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350.Applicable;
			}
			set
			{
				short num = (short)460128256;
				short num2 = num;
				num = (short)258529386;
				short num3 = num;
				num = (short)1169741930;
				switch (num3 == num)
				{
				}
				num = (short)1514733568;
				if (num != 0)
				{
				}
				num = (short)657915905;
				if (num != 0)
				{
				}
				this.modemConnectionType_43350.Applicable = value;
			}
		}

		// Token: 0x17005229 RID: 21033
		// (get) Token: 0x0600A406 RID: 41990 RVA: 0x00992AEC File Offset: 0x00990CEC
		// (set) Token: 0x0600A407 RID: 41991 RVA: 0x00992BA0 File Offset: 0x00990DA0
		public bool ModemConnectionType_43350_Valid
		{
			get
			{
				short num = (short)1968242688;
				short num2 = num;
				num = (short)21006011;
				short num3 = num;
				num = (short)952010427;
				switch (num3 == num)
				{
				}
				num = (short)1314783233;
				if (num != 0)
				{
				}
				num = (short)789708800;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350.Valid;
			}
			set
			{
				short num = (short)2035548160;
				short num2 = num;
				num = (short)1526511560;
				short num3 = num;
				num = (short)1212594120;
				switch (num3 == num)
				{
				}
				num = (short)1675886592;
				if (num != 0)
				{
				}
				num = (short)1310523393;
				if (num != 0)
				{
				}
				this.modemConnectionType_43350.Valid = value;
			}
		}

		// Token: 0x1700522A RID: 21034
		// (get) Token: 0x0600A408 RID: 41992 RVA: 0x00992C54 File Offset: 0x00990E54
		// (set) Token: 0x0600A409 RID: 41993 RVA: 0x00992D08 File Offset: 0x00990F08
		public bool ModemConnectionType_43350_Visible
		{
			get
			{
				short num = (short)1909325824;
				short num2 = num;
				num = (short)1591403616;
				short num3 = num;
				num = (short)468575328;
				switch (num3 == num)
				{
				}
				num = (short)1666842624;
				if (num != 0)
				{
				}
				num = (short)378470401;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350.Visible;
			}
			set
			{
				short num = (short)1812070400;
				short num2 = num;
				num = (short)1202171922;
				short num3 = num;
				num = (short)1052225554;
				switch (num3 == num)
				{
				}
				num = (short)1193738241;
				if (num != 0)
				{
				}
				num = (short)1362427904;
				if (num != 0)
				{
				}
				this.modemConnectionType_43350.Visible = value;
			}
		}

		// Token: 0x1700522B RID: 21035
		// (get) Token: 0x0600A40A RID: 41994 RVA: 0x00992DC0 File Offset: 0x00990FC0
		// (set) Token: 0x0600A40B RID: 41995 RVA: 0x00992E70 File Offset: 0x00991070
		public bool ModemConnectionType_43350_Editable
		{
			get
			{
				short num = (short)1555858360;
				short num2 = num;
				num = (short)1931379640;
				switch (num2 == num)
				{
				}
				num = (short)598016001;
				if (num != 0)
				{
				}
				num = (short)265682944;
				short num3 = num;
				num = (short)1838350336;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350.Editable;
			}
			set
			{
				short num = (short)1039097248;
				short num2 = num;
				num = (short)1481792928;
				switch (num2 == num)
				{
				}
				num = (short)341966849;
				if (num != 0)
				{
				}
				num = (short)1393885184;
				short num3 = num;
				num = (short)1829044224;
				if (num != 0)
				{
				}
				this.modemConnectionType_43350.Editable = value;
			}
		}

		// Token: 0x1700522C RID: 21036
		// (get) Token: 0x0600A40C RID: 41996 RVA: 0x00992F28 File Offset: 0x00991128
		internal string ModemConnectionType_43350_UILabel
		{
			get
			{
				short num = (short)1577295246;
				short num2 = num;
				num = (short)374119822;
				switch (num2 == num)
				{
				}
				num = (short)2102394881;
				if (num != 0)
				{
				}
				num = (short)373686272;
				short num3 = num;
				num = (short)81264640;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350.UIName;
			}
		}

		// Token: 0x1700522D RID: 21037
		// (get) Token: 0x0600A40D RID: 41997 RVA: 0x00992FDC File Offset: 0x009911DC
		// (set) Token: 0x0600A40E RID: 41998 RVA: 0x00993098 File Offset: 0x00991298
		internal bool ModemConnectionType_43350_HiddenStatic
		{
			get
			{
				short num = (short)1583895254;
				short num2 = num;
				num = (short)1722438358;
				switch (num2 == num)
				{
				}
				num = (short)143982593;
				if (num != 0)
				{
				}
				num = (short)963969024;
				short num3 = num;
				num = (short)1083703296;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350.HiddenStatic;
			}
			set
			{
				short num = (short)60227585;
				if (num != 0)
				{
				}
				num = (short)874970640;
				short num2 = num;
				num = (short)448658960;
				switch (num2 == num)
				{
				}
				num = (short)1036320768;
				short num3 = num;
				num = (short)847052800;
				if (num != 0)
				{
				}
				this.modemConnectionType_43350.HiddenStatic = value;
			}
		}

		// Token: 0x1700522E RID: 21038
		// (get) Token: 0x0600A40F RID: 41999 RVA: 0x00993150 File Offset: 0x00991350
		// (set) Token: 0x0600A410 RID: 42000 RVA: 0x00993204 File Offset: 0x00991404
		internal bool ModemConnectionType_43350_HiddenDynamic
		{
			get
			{
				short num = (short)1367757084;
				short num2 = num;
				num = (short)1430343964;
				switch (num2 == num)
				{
				}
				num = (short)142737409;
				if (num != 0)
				{
				}
				num = (short)1539112960;
				short num3 = num;
				num = (short)176422912;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350.HiddenDynamic;
			}
			set
			{
				short num = (short)775043844;
				short num2 = num;
				num = (short)1436105476;
				switch (num2 == num)
				{
				}
				num = (short)332267520;
				if (num != 0)
				{
				}
				num = (short)969146368;
				short num3 = num;
				num = (short)1234108417;
				if (num != 0)
				{
				}
				this.modemConnectionType_43350.HiddenDynamic = value;
			}
		}

		// Token: 0x1700522F RID: 21039
		// (get) Token: 0x0600A411 RID: 42001 RVA: 0x009932BC File Offset: 0x009914BC
		public bool ModemConnectionType_43350_HasDiffs
		{
			get
			{
				short num = (short)288161793;
				if (num != 0)
				{
				}
				num = (short)894980406;
				short num2 = num;
				num = (short)1015632182;
				switch (num2 == num)
				{
				}
				num = (short)1803943936;
				short num3 = num;
				num = (short)1814626304;
				if (num != 0)
				{
				}
				return this.modemConnectionType_43350._HasDiffs;
			}
		}

		// Token: 0x17005230 RID: 21040
		// (get) Token: 0x0600A412 RID: 42002 RVA: 0x00993374 File Offset: 0x00991574
		// (set) Token: 0x0600A413 RID: 42003 RVA: 0x00993428 File Offset: 0x00991628
		public int DataWideExternalDataModemWifiPowerupGuardTimeValue
		{
			get
			{
				short num = (short)913665054;
				short num2 = num;
				num = (short)551775262;
				switch (num2 == num)
				{
				}
				num = (short)302317569;
				if (num != 0)
				{
				}
				num = (short)1859911680;
				short num3 = num;
				num = (short)937426944;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.Value;
			}
			set
			{
				short num = (short)885260289;
				if (num != 0)
				{
				}
				num = (short)412038774;
				short num2 = num;
				num = (short)1809266294;
				switch (num2 == num)
				{
				}
				num = (short)1582891008;
				short num3 = num;
				num = (short)425132032;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.Value = value;
			}
		}

		// Token: 0x17005231 RID: 21041
		// (get) Token: 0x0600A414 RID: 42004 RVA: 0x009934DC File Offset: 0x009916DC
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataModemWifiPowerupGuardTime
		{
			get
			{
				short num = (short)394395649;
				if (num != 0)
				{
				}
				num = (short)1075173568;
				short num2 = num;
				num = (short)1477302464;
				switch (num2 == num)
				{
				}
				num = (short)2032336896;
				short num3 = num;
				num = (short)1993539584;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime;
			}
		}

		// Token: 0x17005232 RID: 21042
		// (get) Token: 0x0600A415 RID: 42005 RVA: 0x0099358C File Offset: 0x0099178C
		// (set) Token: 0x0600A416 RID: 42006 RVA: 0x00993644 File Offset: 0x00991844
		public string DataWideExternalDataModemWifiPowerupGuardTime_UIValue
		{
			get
			{
				short num = (short)1207134734;
				short num2 = num;
				num = (short)1211722254;
				switch (num2 == num)
				{
				}
				num = (short)1450377217;
				if (num != 0)
				{
				}
				num = (short)1685651456;
				short num3 = num;
				num = (short)1180237824;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.UIValue;
			}
			set
			{
				short num = (short)1070654427;
				short num2 = num;
				num = (short)1730077659;
				switch (num2 == num)
				{
				}
				num = (short)1022754816;
				if (num != 0)
				{
				}
				num = (short)40108032;
				short num3 = num;
				num = (short)1091960833;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.UIValue = value;
			}
		}

		// Token: 0x17005233 RID: 21043
		// (get) Token: 0x0600A417 RID: 42007 RVA: 0x009936FC File Offset: 0x009918FC
		// (set) Token: 0x0600A418 RID: 42008 RVA: 0x009937B0 File Offset: 0x009919B0
		internal int DataWideExternalDataModemWifiPowerupGuardTimeMin
		{
			get
			{
				short num = (short)705973690;
				short num2 = num;
				num = (short)1089359290;
				switch (num2 == num)
				{
				}
				num = (short)520290305;
				if (num != 0)
				{
				}
				num = (short)437714944;
				short num3 = num;
				num = (short)1698037760;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.Min;
			}
			set
			{
				short num = (short)1715550840;
				short num2 = num;
				num = (short)2040609400;
				switch (num2 == num)
				{
				}
				num = (short)1448476673;
				if (num != 0)
				{
				}
				num = (short)185663488;
				short num3 = num;
				num = (short)777977856;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.Min = value;
			}
		}

		// Token: 0x17005234 RID: 21044
		// (get) Token: 0x0600A419 RID: 42009 RVA: 0x00993864 File Offset: 0x00991A64
		// (set) Token: 0x0600A41A RID: 42010 RVA: 0x00993918 File Offset: 0x00991B18
		internal int DataWideExternalDataModemWifiPowerupGuardTimeMax
		{
			get
			{
				short num = (short)1644167169;
				if (num != 0)
				{
				}
				num = (short)105282033;
				short num2 = num;
				num = (short)473856497;
				switch (num2 == num)
				{
				}
				num = (short)473890816;
				short num3 = num;
				num = (short)506920960;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.Max;
			}
			set
			{
				short num = (short)505889209;
				short num2 = num;
				num = (short)761872825;
				switch (num2 == num)
				{
				}
				num = (short)705626113;
				if (num != 0)
				{
				}
				num = (short)1116930048;
				short num3 = num;
				num = (short)1322778624;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.Max = value;
			}
		}

		// Token: 0x17005235 RID: 21045
		// (get) Token: 0x0600A41B RID: 42011 RVA: 0x009939D0 File Offset: 0x00991BD0
		// (set) Token: 0x0600A41C RID: 42012 RVA: 0x00993A84 File Offset: 0x00991C84
		internal int DataWideExternalDataModemWifiPowerupGuardTimeStep
		{
			get
			{
				short num = (short)1961432199;
				short num2 = num;
				num = (short)1695159431;
				switch (num2 == num)
				{
				}
				num = (short)1833762816;
				if (num != 0)
				{
				}
				num = (short)192610304;
				short num3 = num;
				num = (short)1869545473;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.StepSize;
			}
			set
			{
				short num = (short)820559162;
				short num2 = num;
				num = (short)1402453306;
				switch (num2 == num)
				{
				}
				num = (short)609550337;
				if (num != 0)
				{
				}
				num = (short)2120744960;
				short num3 = num;
				num = (short)759234560;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.StepSize = value;
			}
		}

		// Token: 0x17005236 RID: 21046
		// (get) Token: 0x0600A41D RID: 42013 RVA: 0x00993B38 File Offset: 0x00991D38
		// (set) Token: 0x0600A41E RID: 42014 RVA: 0x00993BEC File Offset: 0x00991DEC
		public bool DataWideExternalDataModemWifiPowerupGuardTime_Applicable
		{
			get
			{
				short num = (short)200191588;
				short num2 = num;
				num = (short)1834724964;
				switch (num2 == num)
				{
				}
				num = (short)515506176;
				if (num != 0)
				{
				}
				num = (short)143065088;
				short num3 = num;
				num = (short)1262616577;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.Applicable;
			}
			set
			{
				short num = (short)1439114608;
				short num2 = num;
				num = (short)1234838896;
				switch (num2 == num)
				{
				}
				num = (short)1692532737;
				if (num != 0)
				{
				}
				num = (short)2146959360;
				short num3 = num;
				num = (short)85000192;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.Applicable = value;
			}
		}

		// Token: 0x17005237 RID: 21047
		// (get) Token: 0x0600A41F RID: 42015 RVA: 0x00993CA4 File Offset: 0x00991EA4
		// (set) Token: 0x0600A420 RID: 42016 RVA: 0x00993D58 File Offset: 0x00991F58
		public bool DataWideExternalDataModemWifiPowerupGuardTime_Valid
		{
			get
			{
				short num = (short)514129921;
				if (num != 0)
				{
				}
				num = (short)1283248626;
				short num2 = num;
				num = (short)1861931506;
				switch (num2 == num)
				{
				}
				num = (short)721682432;
				short num3 = num;
				num = (short)1008664576;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.Valid;
			}
			set
			{
				short num = (short)1161249787;
				short num2 = num;
				num = (short)1291928571;
				switch (num2 == num)
				{
				}
				num = (short)466419713;
				if (num != 0)
				{
				}
				num = (short)389218304;
				short num3 = num;
				num = (short)1673854976;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.Valid = value;
			}
		}

		// Token: 0x17005238 RID: 21048
		// (get) Token: 0x0600A421 RID: 42017 RVA: 0x00993E0C File Offset: 0x0099200C
		// (set) Token: 0x0600A422 RID: 42018 RVA: 0x00993EC0 File Offset: 0x009920C0
		public bool DataWideExternalDataModemWifiPowerupGuardTime_Visible
		{
			get
			{
				short num = (short)547684353;
				if (num != 0)
				{
				}
				num = (short)369565893;
				short num2 = num;
				num = (short)556540101;
				switch (num2 == num)
				{
				}
				num = (short)755367936;
				short num3 = num;
				num = (short)1865940992;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.Visible;
			}
			set
			{
				short num = (short)413216924;
				short num2 = num;
				num = (short)326709404;
				switch (num2 == num)
				{
				}
				num = (short)2137128960;
				if (num != 0)
				{
				}
				num = (short)394854400;
				short num3 = num;
				num = (short)1156055041;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.Visible = value;
			}
		}

		// Token: 0x17005239 RID: 21049
		// (get) Token: 0x0600A423 RID: 42019 RVA: 0x00993F78 File Offset: 0x00992178
		// (set) Token: 0x0600A424 RID: 42020 RVA: 0x0099402C File Offset: 0x0099222C
		public bool DataWideExternalDataModemWifiPowerupGuardTime_Editable
		{
			get
			{
				short num = (short)1748474249;
				short num2 = num;
				num = (short)1205508489;
				switch (num2 == num)
				{
				}
				num = (short)901251073;
				if (num != 0)
				{
				}
				num = (short)1039532032;
				short num3 = num;
				num = (short)310771712;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.Editable;
			}
			set
			{
				short num = (short)386295583;
				short num2 = num;
				num = (short)1131702047;
				switch (num2 == num)
				{
				}
				num = (short)748748801;
				if (num != 0)
				{
				}
				num = (short)710475776;
				short num3 = num;
				num = (short)600702976;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.Editable = value;
			}
		}

		// Token: 0x1700523A RID: 21050
		// (get) Token: 0x0600A425 RID: 42021 RVA: 0x009940E0 File Offset: 0x009922E0
		internal string DataWideExternalDataModemWifiPowerupGuardTime_UILabel
		{
			get
			{
				short num = (short)1560801926;
				short num2 = num;
				num = (short)1032254086;
				switch (num2 == num)
				{
				}
				num = (short)1734082561;
				if (num != 0)
				{
				}
				num = (short)1035337728;
				short num3 = num;
				num = (short)713031680;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.UIName;
			}
		}

		// Token: 0x1700523B RID: 21051
		// (get) Token: 0x0600A426 RID: 42022 RVA: 0x00994194 File Offset: 0x00992394
		// (set) Token: 0x0600A427 RID: 42023 RVA: 0x00994248 File Offset: 0x00992448
		internal bool DataWideExternalDataModemWifiPowerupGuardTime_HiddenStatic
		{
			get
			{
				short num = (short)2035261562;
				short num2 = num;
				num = (short)610639994;
				switch (num2 == num)
				{
				}
				num = (short)1436876801;
				if (num != 0)
				{
				}
				num = (short)76218368;
				short num3 = num;
				num = (short)997588992;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.HiddenStatic;
			}
			set
			{
				short num = (short)1044804605;
				short num2 = num;
				num = (short)899445757;
				switch (num2 == num)
				{
				}
				num = (short)1900019713;
				if (num != 0)
				{
				}
				num = (short)2094137344;
				short num3 = num;
				num = (short)1619460096;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.HiddenStatic = value;
			}
		}

		// Token: 0x1700523C RID: 21052
		// (get) Token: 0x0600A428 RID: 42024 RVA: 0x00994300 File Offset: 0x00992500
		// (set) Token: 0x0600A429 RID: 42025 RVA: 0x009943B8 File Offset: 0x009925B8
		internal bool DataWideExternalDataModemWifiPowerupGuardTime_HiddenDynamic
		{
			get
			{
				short num = (short)282840079;
				short num2 = num;
				num = (short)562220047;
				switch (num2 == num)
				{
				}
				num = (short)1108541440;
				if (num != 0)
				{
				}
				num = (short)1559298048;
				short num3 = num;
				num = (short)1226899457;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1578545300;
				short num2 = num;
				num = (short)1529720980;
				switch (num2 == num)
				{
				}
				num = (short)1866858496;
				if (num != 0)
				{
				}
				num = (short)1732968448;
				short num3 = num;
				num = (short)2064252929;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemWifiPowerupGuardTime.HiddenDynamic = value;
			}
		}

		// Token: 0x1700523D RID: 21053
		// (get) Token: 0x0600A42A RID: 42026 RVA: 0x0099446C File Offset: 0x0099266C
		public bool DataWideExternalDataModemWifiPowerupGuardTime_HasDiffs
		{
			get
			{
				short num = (short)1996984415;
				short num2 = num;
				num = (short)245928031;
				switch (num2 == num)
				{
				}
				num = (short)1998979073;
				if (num != 0)
				{
				}
				num = (short)517472256;
				short num3 = num;
				num = (short)1628635136;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemWifiPowerupGuardTime._HasDiffs;
			}
		}

		// Token: 0x1700523E RID: 21054
		// (get) Token: 0x0600A42B RID: 42027 RVA: 0x00994524 File Offset: 0x00992724
		// (set) Token: 0x0600A42C RID: 42028 RVA: 0x009945D8 File Offset: 0x009927D8
		public string DataWideExternalDataModemVPNFriendlyName_43774Value
		{
			get
			{
				short num = (short)1618841436;
				short num2 = num;
				num = (short)1532333916;
				switch (num2 == num)
				{
				}
				num = (short)688783361;
				if (num != 0)
				{
				}
				num = (short)1997864960;
				short num3 = num;
				num = (short)140247040;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774.Value;
			}
			set
			{
				short num = (short)367901456;
				short num2 = num;
				num = (short)1982053136;
				switch (num2 == num)
				{
				}
				num = (short)1377828865;
				if (num != 0)
				{
				}
				num = (short)1587544064;
				short num3 = num;
				num = (short)864419840;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNFriendlyName_43774.Value = value;
			}
		}

		// Token: 0x1700523F RID: 21055
		// (get) Token: 0x0600A42D RID: 42029 RVA: 0x0099468C File Offset: 0x0099288C
		public global::AcpBusinessLayer.AcpField<string> DataWideExternalDataModemVPNFriendlyName_43774
		{
			get
			{
				short num = (short)438312330;
				short num2 = num;
				num = (short)964173194;
				switch (num2 == num)
				{
				}
				num = (short)1403584513;
				if (num != 0)
				{
				}
				num = (short)440139776;
				short num3 = num;
				num = (short)1440546816;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774;
			}
		}

		// Token: 0x17005240 RID: 21056
		// (get) Token: 0x0600A42E RID: 42030 RVA: 0x0099473C File Offset: 0x0099293C
		// (set) Token: 0x0600A42F RID: 42031 RVA: 0x009947F4 File Offset: 0x009929F4
		public string DataWideExternalDataModemVPNFriendlyName_43774_UIValue
		{
			get
			{
				short num = (short)1572470785;
				if (num != 0)
				{
				}
				num = (short)264643604;
				short num2 = num;
				num = (short)584655892;
				switch (num2 == num)
				{
				}
				num = (short)327811072;
				short num3 = num;
				num = (short)1544093696;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774.Value;
			}
			set
			{
				short num = (short)1742359061;
				short num2 = num;
				num = (short)1488538133;
				switch (num2 == num)
				{
				}
				num = (short)1551433729;
				if (num != 0)
				{
				}
				num = (short)783548416;
				short num3 = num;
				num = (short)2092105728;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNFriendlyName_43774.Value = value;
			}
		}

		// Token: 0x17005241 RID: 21057
		// (get) Token: 0x0600A430 RID: 42032 RVA: 0x009948AC File Offset: 0x00992AAC
		// (set) Token: 0x0600A431 RID: 42033 RVA: 0x00994964 File Offset: 0x00992B64
		public bool DataWideExternalDataModemVPNFriendlyName_43774_Applicable
		{
			get
			{
				short num = (short)1991332276;
				short num2 = num;
				num = (short)1260016052;
				switch (num2 == num)
				{
				}
				num = (short)2061434881;
				if (num != 0)
				{
				}
				num = (short)1703608320;
				short num3 = num;
				num = (short)1731198976;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774.Applicable;
			}
			set
			{
				short num = (short)1605304321;
				if (num != 0)
				{
				}
				num = (short)1221638553;
				short num2 = num;
				num = (short)59685273;
				switch (num2 == num)
				{
				}
				num = (short)721944576;
				short num3 = num;
				num = (short)2003173376;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNFriendlyName_43774.Applicable = value;
			}
		}

		// Token: 0x17005242 RID: 21058
		// (get) Token: 0x0600A432 RID: 42034 RVA: 0x00994A1C File Offset: 0x00992C1C
		// (set) Token: 0x0600A433 RID: 42035 RVA: 0x00994AD4 File Offset: 0x00992CD4
		public bool DataWideExternalDataModemVPNFriendlyName_43774_Valid
		{
			get
			{
				short num = (short)549713393;
				short num2 = num;
				num = (short)1886385649;
				switch (num2 == num)
				{
				}
				num = (short)950796289;
				if (num != 0)
				{
				}
				num = (short)531890176;
				short num3 = num;
				num = (short)453050368;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774.Valid;
			}
			set
			{
				short num = (short)754454543;
				short num2 = num;
				num = (short)1068175375;
				switch (num2 == num)
				{
				}
				num = (short)513343489;
				if (num != 0)
				{
				}
				num = (short)777781248;
				short num3 = num;
				num = (short)184942592;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNFriendlyName_43774.Valid = value;
			}
		}

		// Token: 0x17005243 RID: 21059
		// (get) Token: 0x0600A434 RID: 42036 RVA: 0x00994B88 File Offset: 0x00992D88
		// (set) Token: 0x0600A435 RID: 42037 RVA: 0x00994C3C File Offset: 0x00992E3C
		public bool DataWideExternalDataModemVPNFriendlyName_43774_Visible
		{
			get
			{
				short num = (short)397413069;
				short num2 = num;
				num = (short)590154445;
				switch (num2 == num)
				{
				}
				num = (short)1758330880;
				if (num != 0)
				{
				}
				num = (short)2034630656;
				short num3 = num;
				num = (short)448135169;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774.Visible;
			}
			set
			{
				short num = (short)1136502045;
				short num2 = num;
				num = (short)171746589;
				switch (num2 == num)
				{
				}
				num = (short)610926593;
				if (num != 0)
				{
				}
				num = (short)1597767680;
				short num3 = num;
				num = (short)1808007168;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNFriendlyName_43774.Visible = value;
			}
		}

		// Token: 0x17005244 RID: 21060
		// (get) Token: 0x0600A436 RID: 42038 RVA: 0x00994CF0 File Offset: 0x00992EF0
		// (set) Token: 0x0600A437 RID: 42039 RVA: 0x00994DA4 File Offset: 0x00992FA4
		public bool DataWideExternalDataModemVPNFriendlyName_43774_Editable
		{
			get
			{
				short num = (short)1492689789;
				short num2 = num;
				num = (short)1702994813;
				switch (num2 == num)
				{
				}
				num = (short)1302003713;
				if (num != 0)
				{
				}
				num = (short)1693712384;
				short num3 = num;
				num = (short)1283981312;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774.Editable;
			}
			set
			{
				short num = (short)29629898;
				short num2 = num;
				num = (short)303898058;
				switch (num2 == num)
				{
				}
				num = (short)1986527233;
				if (num != 0)
				{
				}
				num = (short)635174912;
				short num3 = num;
				num = (short)1419116544;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNFriendlyName_43774.Editable = value;
			}
		}

		// Token: 0x17005245 RID: 21061
		// (get) Token: 0x0600A438 RID: 42040 RVA: 0x00994E58 File Offset: 0x00993058
		internal string DataWideExternalDataModemVPNFriendlyName_43774_UILabel
		{
			get
			{
				short num = (short)1966446410;
				short num2 = num;
				num = (short)1208588106;
				switch (num2 == num)
				{
				}
				num = (short)211812353;
				if (num != 0)
				{
				}
				num = (short)67502080;
				short num3 = num;
				num = (short)470810624;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774.UIName;
			}
		}

		// Token: 0x17005246 RID: 21062
		// (get) Token: 0x0600A439 RID: 42041 RVA: 0x00994F0C File Offset: 0x0099310C
		// (set) Token: 0x0600A43A RID: 42042 RVA: 0x00994FC0 File Offset: 0x009931C0
		internal bool DataWideExternalDataModemVPNFriendlyName_43774_HiddenStatic
		{
			get
			{
				short num = (short)1239883200;
				short num2 = num;
				num = (short)39460288;
				switch (num2 == num)
				{
				}
				num = (short)1639251969;
				if (num != 0)
				{
				}
				num = (short)1658650624;
				short num3 = num;
				num = (short)36503552;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774.HiddenStatic;
			}
			set
			{
				short num = (short)1007346418;
				short num2 = num;
				num = (short)747037426;
				switch (num2 == num)
				{
				}
				num = (short)923140096;
				if (num != 0)
				{
				}
				num = (short)767164416;
				short num3 = num;
				num = (short)254017537;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNFriendlyName_43774.HiddenStatic = value;
			}
		}

		// Token: 0x17005247 RID: 21063
		// (get) Token: 0x0600A43B RID: 42043 RVA: 0x00995074 File Offset: 0x00993274
		// (set) Token: 0x0600A43C RID: 42044 RVA: 0x00995128 File Offset: 0x00993328
		internal bool DataWideExternalDataModemVPNFriendlyName_43774_HiddenDynamic
		{
			get
			{
				short num = (short)750741497;
				short num2 = num;
				num = (short)999712761;
				switch (num2 == num)
				{
				}
				num = (short)2015232001;
				if (num != 0)
				{
				}
				num = (short)877723648;
				short num3 = num;
				num = (short)1123745792;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774.HiddenDynamic;
			}
			set
			{
				short num = (short)1212257969;
				short num2 = num;
				num = (short)747280049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1413611520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1796014081;
				if (num != 0)
				{
				}
				num = (short)563281920;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemVPNFriendlyName_43774.HiddenDynamic = value;
			}
		}

		// Token: 0x17005248 RID: 21064
		// (get) Token: 0x0600A43D RID: 42045 RVA: 0x009951DC File Offset: 0x009933DC
		public bool DataWideExternalDataModemVPNFriendlyName_43774_HasDiffs
		{
			get
			{
				short num = (short)2116710963;
				short num2 = num;
				num = (short)1234858547;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1028390912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)901971969;
				if (num != 0)
				{
				}
				num = (short)1393819648;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemVPNFriendlyName_43774._HasDiffs;
			}
		}

		// Token: 0x17005249 RID: 21065
		// (get) Token: 0x0600A43E RID: 42046 RVA: 0x00995290 File Offset: 0x00993490
		// (set) Token: 0x0600A43F RID: 42047 RVA: 0x00995344 File Offset: 0x00993544
		public string DataWideExternalDataModemLTEFriendlyName_43775Value
		{
			get
			{
				short num = (short)868941825;
				if (num != 0)
				{
				}
				num = (short)1560608768;
				short num2 = num;
				num = (short)1094384269;
				short num3 = num;
				num = (short)844036749;
				switch (num3 == num)
				{
				}
				num = (short)1260322816;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775.Value;
			}
			set
			{
				short num = (short)335413249;
				if (num != 0)
				{
				}
				num = (short)376635392;
				short num2 = num;
				num = (short)2307580;
				short num3 = num;
				num = (short)1148532220;
				switch (num3 == num)
				{
				}
				num = (short)1571553280;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemLTEFriendlyName_43775.Value = value;
			}
		}

		// Token: 0x1700524A RID: 21066
		// (get) Token: 0x0600A440 RID: 42048 RVA: 0x009953FC File Offset: 0x009935FC
		public global::AcpBusinessLayer.AcpField<string> DataWideExternalDataModemLTEFriendlyName_43775
		{
			get
			{
				short num = (short)496929442;
				short num2 = num;
				num = (short)708741794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1242562560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)657850369;
				if (num != 0)
				{
				}
				num = (short)549519360;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775;
			}
		}

		// Token: 0x1700524B RID: 21067
		// (get) Token: 0x0600A441 RID: 42049 RVA: 0x009954AC File Offset: 0x009936AC
		// (set) Token: 0x0600A442 RID: 42050 RVA: 0x00995560 File Offset: 0x00993760
		public string DataWideExternalDataModemLTEFriendlyName_43775_UIValue
		{
			get
			{
				short num = (short)1545122246;
				short num2 = num;
				num = (short)501854662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)934019072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)209059841;
				if (num != 0)
				{
				}
				num = (short)2122579968;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775.Value;
			}
			set
			{
				short num = (short)882049025;
				if (num != 0)
				{
				}
				num = (short)832241664;
				short num2 = num;
				num = (short)2091129253;
				short num3 = num;
				num = (short)1512708517;
				switch (num3 == num)
				{
				}
				num = (short)1608122368;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemLTEFriendlyName_43775.Value = value;
			}
		}

		// Token: 0x1700524C RID: 21068
		// (get) Token: 0x0600A443 RID: 42051 RVA: 0x00995618 File Offset: 0x00993818
		// (set) Token: 0x0600A444 RID: 42052 RVA: 0x009956CC File Offset: 0x009938CC
		public bool DataWideExternalDataModemLTEFriendlyName_43775_Applicable
		{
			get
			{
				short num = (short)1841462472;
				short num2 = num;
				num = (short)102989000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)609222656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1459486721;
				if (num != 0)
				{
				}
				num = (short)255131648;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775.Applicable;
			}
			set
			{
				short num = (short)900670009;
				short num2 = num;
				num = (short)1059660345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1810169856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)540278785;
				if (num != 0)
				{
				}
				num = (short)881852416;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemLTEFriendlyName_43775.Applicable = value;
			}
		}

		// Token: 0x1700524D RID: 21069
		// (get) Token: 0x0600A445 RID: 42053 RVA: 0x00995784 File Offset: 0x00993984
		// (set) Token: 0x0600A446 RID: 42054 RVA: 0x0099583C File Offset: 0x00993A3C
		public bool DataWideExternalDataModemLTEFriendlyName_43775_Valid
		{
			get
			{
				short num = (short)185361542;
				short num2 = num;
				num = (short)2136499334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1823473664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337131009;
				if (num != 0)
				{
				}
				num = (short)1220739072;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775.Valid;
			}
			set
			{
				short num = (short)1010368513;
				if (num != 0)
				{
				}
				num = (short)1279655936;
				short num2 = num;
				num = (short)1990322685;
				short num3 = num;
				num = (short)646834685;
				switch (num3 == num)
				{
				}
				num = (short)2018246656;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemLTEFriendlyName_43775.Valid = value;
			}
		}

		// Token: 0x1700524E RID: 21070
		// (get) Token: 0x0600A447 RID: 42055 RVA: 0x009958F0 File Offset: 0x00993AF0
		// (set) Token: 0x0600A448 RID: 42056 RVA: 0x009959A4 File Offset: 0x00993BA4
		public bool DataWideExternalDataModemLTEFriendlyName_43775_Visible
		{
			get
			{
				short num = (short)2088716414;
				short num2 = num;
				num = (short)1529825406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1211957248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)693174273;
				if (num != 0)
				{
				}
				num = (short)1317666816;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775.Visible;
			}
			set
			{
				short num = (short)762753211;
				short num2 = num;
				num = (short)386314427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)170131456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)286064640;
				if (num != 0)
				{
				}
				num = (short)403111937;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemLTEFriendlyName_43775.Visible = value;
			}
		}

		// Token: 0x1700524F RID: 21071
		// (get) Token: 0x0600A449 RID: 42057 RVA: 0x00995A5C File Offset: 0x00993C5C
		// (set) Token: 0x0600A44A RID: 42058 RVA: 0x00995B10 File Offset: 0x00993D10
		public bool DataWideExternalDataModemLTEFriendlyName_43775_Editable
		{
			get
			{
				short num = (short)1327497217;
				if (num != 0)
				{
				}
				num = (short)609615872;
				short num2 = num;
				num = (short)1224341537;
				short num3 = num;
				num = (short)157022241;
				switch (num3 == num)
				{
				}
				num = (short)136773632;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775.Editable;
			}
			set
			{
				short num = (short)1924792321;
				if (num != 0)
				{
				}
				num = (short)773586944;
				short num2 = num;
				num = (short)795109991;
				short num3 = num;
				num = (short)1101228647;
				switch (num3 == num)
				{
				}
				num = (short)2012413952;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemLTEFriendlyName_43775.Editable = value;
			}
		}

		// Token: 0x17005250 RID: 21072
		// (get) Token: 0x0600A44B RID: 42059 RVA: 0x00995BCC File Offset: 0x00993DCC
		internal string DataWideExternalDataModemLTEFriendlyName_43775_UILabel
		{
			get
			{
				short num = (short)2017525761;
				if (num != 0)
				{
				}
				num = (short)723517440;
				short num2 = num;
				num = (short)1475160108;
				short num3 = num;
				num = (short)1057237036;
				switch (num3 == num)
				{
				}
				num = (short)349241344;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775.UIName;
			}
		}

		// Token: 0x17005251 RID: 21073
		// (get) Token: 0x0600A44C RID: 42060 RVA: 0x00995C80 File Offset: 0x00993E80
		// (set) Token: 0x0600A44D RID: 42061 RVA: 0x00995D34 File Offset: 0x00993F34
		internal bool DataWideExternalDataModemLTEFriendlyName_43775_HiddenStatic
		{
			get
			{
				short num = (short)1238489519;
				short num2 = num;
				num = (short)34920879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)361431040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1526267905;
				if (num != 0)
				{
				}
				num = (short)1389428736;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775.HiddenStatic;
			}
			set
			{
				short num = (short)751916158;
				short num2 = num;
				num = (short)280122494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)416677888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039925249;
				if (num != 0)
				{
				}
				num = (short)935854080;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemLTEFriendlyName_43775.HiddenStatic = value;
			}
		}

		// Token: 0x17005252 RID: 21074
		// (get) Token: 0x0600A44E RID: 42062 RVA: 0x00995DEC File Offset: 0x00993FEC
		// (set) Token: 0x0600A44F RID: 42063 RVA: 0x00995EA4 File Offset: 0x009940A4
		internal bool DataWideExternalDataModemLTEFriendlyName_43775_HiddenDynamic
		{
			get
			{
				short num = (short)1819841193;
				short num2 = num;
				num = (short)787583657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1726676992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1699414017;
				if (num != 0)
				{
				}
				num = (short)501612544;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775.HiddenDynamic;
			}
			set
			{
				short num = (short)1030036717;
				short num2 = num;
				num = (short)796269805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)868810752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1528430592;
				if (num != 0)
				{
				}
				num = (short)1227685889;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemLTEFriendlyName_43775.HiddenDynamic = value;
			}
		}

		// Token: 0x17005253 RID: 21075
		// (get) Token: 0x0600A450 RID: 42064 RVA: 0x00995F58 File Offset: 0x00994158
		public bool DataWideExternalDataModemLTEFriendlyName_43775_HasDiffs
		{
			get
			{
				short num = (short)356537821;
				short num2 = num;
				num = (short)140662237;
				switch (num2 == num)
				{
				default:
				{
					num = (short)72220672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1432223744;
				if (num != 0)
				{
				}
				num = (short)525271041;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemLTEFriendlyName_43775._HasDiffs;
			}
		}

		// Token: 0x17005254 RID: 21076
		// (get) Token: 0x0600A451 RID: 42065 RVA: 0x0099600C File Offset: 0x0099420C
		// (set) Token: 0x0600A452 RID: 42066 RVA: 0x009960C0 File Offset: 0x009942C0
		public string DataWideExternalDataModemMG90SatelliteFriendlyName_43776Value
		{
			get
			{
				short num = (short)1915090852;
				short num2 = num;
				num = (short)1298003876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745616896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)967442432;
				if (num != 0)
				{
				}
				num = (short)543293441;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Value;
			}
			set
			{
				short num = (short)1335083730;
				short num2 = num;
				num = (short)174768850;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1381105664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)54460417;
				if (num != 0)
				{
				}
				num = (short)1501954048;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Value = value;
			}
		}

		// Token: 0x17005255 RID: 21077
		// (get) Token: 0x0600A453 RID: 42067 RVA: 0x00996178 File Offset: 0x00994378
		public global::AcpBusinessLayer.AcpField<string> DataWideExternalDataModemMG90SatelliteFriendlyName_43776
		{
			get
			{
				short num = (short)1180828576;
				short num2 = num;
				num = (short)456590240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1317404672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1559101441;
				if (num != 0)
				{
				}
				num = (short)1606877184;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776;
			}
		}

		// Token: 0x17005256 RID: 21078
		// (get) Token: 0x0600A454 RID: 42068 RVA: 0x00996228 File Offset: 0x00994428
		// (set) Token: 0x0600A455 RID: 42069 RVA: 0x009962DC File Offset: 0x009944DC
		public string DataWideExternalDataModemMG90SatelliteFriendlyName_43776_UIValue
		{
			get
			{
				short num = (short)345290867;
				short num2 = num;
				num = (short)927709299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)586940416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391263745;
				if (num != 0)
				{
				}
				num = (short)604831744;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Value;
			}
			set
			{
				short num = (short)231544160;
				short num2 = num;
				num = (short)916723040;
				switch (num2 == num)
				{
				default:
				{
					num = (short)130220032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625868801;
				if (num != 0)
				{
				}
				num = (short)566624256;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Value = value;
			}
		}

		// Token: 0x17005257 RID: 21079
		// (get) Token: 0x0600A456 RID: 42070 RVA: 0x00996390 File Offset: 0x00994590
		// (set) Token: 0x0600A457 RID: 42071 RVA: 0x00996444 File Offset: 0x00994644
		public bool DataWideExternalDataModemMG90SatelliteFriendlyName_43776_Applicable
		{
			get
			{
				short num = (short)2127808292;
				short num2 = num;
				num = (short)757647140;
				switch (num2 == num)
				{
				default:
				{
					num = (short)693108736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526057473;
				if (num != 0)
				{
				}
				num = (short)746258432;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Applicable;
			}
			set
			{
				short num = (short)2113183454;
				short num2 = num;
				num = (short)429235934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1191116800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1647902720;
				if (num != 0)
				{
				}
				num = (short)93716481;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Applicable = value;
			}
		}

		// Token: 0x17005258 RID: 21080
		// (get) Token: 0x0600A458 RID: 42072 RVA: 0x009964F8 File Offset: 0x009946F8
		// (set) Token: 0x0600A459 RID: 42073 RVA: 0x009965AC File Offset: 0x009947AC
		public bool DataWideExternalDataModemMG90SatelliteFriendlyName_43776_Valid
		{
			get
			{
				short num = (short)736525640;
				short num2 = num;
				num = (short)496336200;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2033254400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)874512385;
				if (num != 0)
				{
				}
				num = (short)1694826496;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Valid;
			}
			set
			{
				short num = (short)1077547730;
				short num2 = num;
				num = (short)1519981266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)541523968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)502923265;
				if (num != 0)
				{
				}
				num = (short)1122107392;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Valid = value;
			}
		}

		// Token: 0x17005259 RID: 21081
		// (get) Token: 0x0600A45A RID: 42074 RVA: 0x00996664 File Offset: 0x00994864
		// (set) Token: 0x0600A45B RID: 42075 RVA: 0x00996718 File Offset: 0x00994918
		public bool DataWideExternalDataModemMG90SatelliteFriendlyName_43776_Visible
		{
			get
			{
				short num = (short)1555169855;
				short num2 = num;
				num = (short)2013332031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)750452736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)922812417;
				if (num != 0)
				{
				}
				num = (short)291373056;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Visible;
			}
			set
			{
				short num = (short)1624787294;
				short num2 = num;
				num = (short)462113118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)602865664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1939931137;
				if (num != 0)
				{
				}
				num = (short)2068774912;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Visible = value;
			}
		}

		// Token: 0x1700525A RID: 21082
		// (get) Token: 0x0600A45C RID: 42076 RVA: 0x009967CC File Offset: 0x009949CC
		// (set) Token: 0x0600A45D RID: 42077 RVA: 0x00996884 File Offset: 0x00994A84
		public bool DataWideExternalDataModemMG90SatelliteFriendlyName_43776_Editable
		{
			get
			{
				short num = (short)640683923;
				short num2 = num;
				num = (short)2021330835;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1626996736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)580911105;
				if (num != 0)
				{
				}
				num = (short)663486464;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Editable;
			}
			set
			{
				short num = (short)815675521;
				short num2 = num;
				num = (short)373176449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588854784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1756364801;
				if (num != 0)
				{
				}
				num = (short)1414332416;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.Editable = value;
			}
		}

		// Token: 0x1700525B RID: 21083
		// (get) Token: 0x0600A45E RID: 42078 RVA: 0x00996938 File Offset: 0x00994B38
		internal string DataWideExternalDataModemMG90SatelliteFriendlyName_43776_UILabel
		{
			get
			{
				short num = (short)1468980556;
				short num2 = num;
				num = (short)764206412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)159252480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1591083008;
				if (num != 0)
				{
				}
				num = (short)1544880129;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.UIName;
			}
		}

		// Token: 0x1700525C RID: 21084
		// (get) Token: 0x0600A45F RID: 42079 RVA: 0x009969F0 File Offset: 0x00994BF0
		// (set) Token: 0x0600A460 RID: 42080 RVA: 0x00996AA0 File Offset: 0x00994CA0
		internal bool DataWideExternalDataModemMG90SatelliteFriendlyName_43776_HiddenStatic
		{
			get
			{
				short num = (short)849828316;
				short num2 = num;
				num = (short)134175196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)171638784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)208404481;
				if (num != 0)
				{
				}
				num = (short)813629440;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.HiddenStatic;
			}
			set
			{
				short num = (short)2050471430;
				short num2 = num;
				num = (short)693089798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1215299584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)263716864;
				if (num != 0)
				{
				}
				num = (short)367394817;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.HiddenStatic = value;
			}
		}

		// Token: 0x1700525D RID: 21085
		// (get) Token: 0x0600A461 RID: 42081 RVA: 0x00996B54 File Offset: 0x00994D54
		// (set) Token: 0x0600A462 RID: 42082 RVA: 0x00996C08 File Offset: 0x00994E08
		internal bool DataWideExternalDataModemMG90SatelliteFriendlyName_43776_HiddenDynamic
		{
			get
			{
				short num = (short)759978595;
				short num2 = num;
				num = (short)2078235235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1896284160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1423900673;
				if (num != 0)
				{
				}
				num = (short)744620032;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.HiddenDynamic;
			}
			set
			{
				short num = (short)1830683833;
				short num2 = num;
				num = (short)840107193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)789774336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661716993;
				if (num != 0)
				{
				}
				num = (short)164298752;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776.HiddenDynamic = value;
			}
		}

		// Token: 0x1700525E RID: 21086
		// (get) Token: 0x0600A463 RID: 42083 RVA: 0x00996CC0 File Offset: 0x00994EC0
		public bool DataWideExternalDataModemMG90SatelliteFriendlyName_43776_HasDiffs
		{
			get
			{
				short num = (short)721553738;
				short num2 = num;
				num = (short)1022691658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)716242944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1916076032;
				if (num != 0)
				{
				}
				num = (short)648675329;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteFriendlyName_43776._HasDiffs;
			}
		}

		// Token: 0x1700525F RID: 21087
		// (get) Token: 0x0600A464 RID: 42084 RVA: 0x00996D70 File Offset: 0x00994F70
		// (set) Token: 0x0600A465 RID: 42085 RVA: 0x00996E24 File Offset: 0x00995024
		public bool DataWideExternalDataModemMG90SatelliteEnabled_43777Value
		{
			get
			{
				short num = (short)1510802404;
				short num2 = num;
				num = (short)607847396;
				switch (num2 == num)
				{
				default:
				{
					num = (short)373686272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1504837633;
				if (num != 0)
				{
				}
				num = (short)1480982528;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Value;
			}
			set
			{
				short num = (short)1775347532;
				short num2 = num;
				num = (short)170501964;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2048917504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)281346049;
				if (num != 0)
				{
				}
				num = (short)195952640;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Value = value;
			}
		}

		// Token: 0x17005260 RID: 21088
		// (get) Token: 0x0600A466 RID: 42086 RVA: 0x00996ED8 File Offset: 0x009950D8
		public global::AcpBusinessLayer.AcpField<bool> DataWideExternalDataModemMG90SatelliteEnabled_43777
		{
			get
			{
				short num = (short)1783179227;
				short num2 = num;
				num = (short)2012227547;
				switch (num2 == num)
				{
				default:
				{
					num = (short)156368896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)675414017;
				if (num != 0)
				{
				}
				num = (short)1830158336;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777;
			}
		}

		// Token: 0x17005261 RID: 21089
		// (get) Token: 0x0600A467 RID: 42087 RVA: 0x00996F88 File Offset: 0x00995188
		// (set) Token: 0x0600A468 RID: 42088 RVA: 0x0099703C File Offset: 0x0099523C
		public bool DataWideExternalDataModemMG90SatelliteEnabled_43777_UIValue
		{
			get
			{
				short num = (short)1763962158;
				short num2 = num;
				num = (short)163507502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)332201984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1228275712;
				if (num != 0)
				{
				}
				num = (short)557056001;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Value;
			}
			set
			{
				short num = (short)2054553601;
				if (num != 0)
				{
				}
				num = (short)777977856;
				short num2 = num;
				num = (short)955568028;
				short num3 = num;
				num = (short)124833692;
				switch (num3 == num)
				{
				}
				num = (short)1873149952;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Value = value;
			}
		}

		// Token: 0x17005262 RID: 21090
		// (get) Token: 0x0600A469 RID: 42089 RVA: 0x009970F0 File Offset: 0x009952F0
		// (set) Token: 0x0600A46A RID: 42090 RVA: 0x009971A4 File Offset: 0x009953A4
		public bool DataWideExternalDataModemMG90SatelliteEnabled_43777_Applicable
		{
			get
			{
				short num = (short)407285106;
				short num2 = num;
				num = (short)1069460850;
				switch (num2 == num)
				{
				default:
				{
					num = (short)379584512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)222625793;
				if (num != 0)
				{
				}
				num = (short)2095251456;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Applicable;
			}
			set
			{
				short num = (short)1156538196;
				short num2 = num;
				num = (short)613048148;
				switch (num2 == num)
				{
				default:
				{
					num = (short)162463744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)362676224;
				if (num != 0)
				{
				}
				num = (short)1369767937;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Applicable = value;
			}
		}

		// Token: 0x17005263 RID: 21091
		// (get) Token: 0x0600A46B RID: 42091 RVA: 0x00997258 File Offset: 0x00995458
		// (set) Token: 0x0600A46C RID: 42092 RVA: 0x0099730C File Offset: 0x0099550C
		public bool DataWideExternalDataModemMG90SatelliteEnabled_43777_Valid
		{
			get
			{
				short num = (short)183833260;
				short num2 = num;
				num = (short)1648562860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1672740864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2069823488;
				if (num != 0)
				{
				}
				num = (short)1940783105;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Valid;
			}
			set
			{
				short num = (short)785791670;
				short num2 = num;
				num = (short)1734949558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)951058432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1436483585;
				if (num != 0)
				{
				}
				num = (short)1052770304;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Valid = value;
			}
		}

		// Token: 0x17005264 RID: 21092
		// (get) Token: 0x0600A46D RID: 42093 RVA: 0x009973C0 File Offset: 0x009955C0
		// (set) Token: 0x0600A46E RID: 42094 RVA: 0x00997478 File Offset: 0x00995678
		public bool DataWideExternalDataModemMG90SatelliteEnabled_43777_Visible
		{
			get
			{
				short num = (short)1671330640;
				short num2 = num;
				num = (short)1024031568;
				switch (num2 == num)
				{
				default:
				{
					num = (short)750977024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1149501441;
				if (num != 0)
				{
				}
				num = (short)199557120;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Visible;
			}
			set
			{
				short num = (short)1651459098;
				short num2 = num;
				num = (short)398410778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1435828224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1667629056;
				if (num != 0)
				{
				}
				num = (short)50200577;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Visible = value;
			}
		}

		// Token: 0x17005265 RID: 21093
		// (get) Token: 0x0600A46F RID: 42095 RVA: 0x00997530 File Offset: 0x00995730
		// (set) Token: 0x0600A470 RID: 42096 RVA: 0x009975E4 File Offset: 0x009957E4
		public bool DataWideExternalDataModemMG90SatelliteEnabled_43777_Editable
		{
			get
			{
				short num = (short)1560822475;
				short num2 = num;
				num = (short)583156427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)760414208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784596992;
				if (num != 0)
				{
				}
				num = (short)1405485057;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Editable;
			}
			set
			{
				short num = (short)1131318039;
				short num2 = num;
				num = (short)328698647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1578500096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1018822657;
				if (num != 0)
				{
				}
				num = (short)1463615488;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteEnabled_43777.Editable = value;
			}
		}

		// Token: 0x17005266 RID: 21094
		// (get) Token: 0x0600A471 RID: 42097 RVA: 0x00997698 File Offset: 0x00995898
		internal string DataWideExternalDataModemMG90SatelliteEnabled_43777_UILabel
		{
			get
			{
				short num = (short)1408026116;
				short num2 = num;
				num = (short)2090190340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)51052544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1160249344;
				if (num != 0)
				{
				}
				num = (short)850722817;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777.UIName;
			}
		}

		// Token: 0x17005267 RID: 21095
		// (get) Token: 0x0600A472 RID: 42098 RVA: 0x00997750 File Offset: 0x00995950
		// (set) Token: 0x0600A473 RID: 42099 RVA: 0x00997804 File Offset: 0x00995A04
		internal bool DataWideExternalDataModemMG90SatelliteEnabled_43777_HiddenStatic
		{
			get
			{
				short num = (short)881922588;
				short num2 = num;
				num = (short)2123960860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)195821568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)215351297;
				if (num != 0)
				{
				}
				num = (short)1939931136;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777.HiddenStatic;
			}
			set
			{
				short num = (short)1452973836;
				short num2 = num;
				num = (short)573611788;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1134100480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1306460160;
				if (num != 0)
				{
				}
				num = (short)115867649;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteEnabled_43777.HiddenStatic = value;
			}
		}

		// Token: 0x17005268 RID: 21096
		// (get) Token: 0x0600A474 RID: 42100 RVA: 0x009978BC File Offset: 0x00995ABC
		// (set) Token: 0x0600A475 RID: 42101 RVA: 0x00997970 File Offset: 0x00995B70
		internal bool DataWideExternalDataModemMG90SatelliteEnabled_43777_HiddenDynamic
		{
			get
			{
				short num = (short)1180479328;
				short num2 = num;
				num = (short)1232187232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)857538560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1062010881;
				if (num != 0)
				{
				}
				num = (short)2095185920;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777.HiddenDynamic;
			}
			set
			{
				short num = (short)1477441260;
				short num2 = num;
				num = (short)699463404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1952382976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)321716225;
				if (num != 0)
				{
				}
				num = (short)1354563584;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemMG90SatelliteEnabled_43777.HiddenDynamic = value;
			}
		}

		// Token: 0x17005269 RID: 21097
		// (get) Token: 0x0600A476 RID: 42102 RVA: 0x00997A24 File Offset: 0x00995C24
		public bool DataWideExternalDataModemMG90SatelliteEnabled_43777_HasDiffs
		{
			get
			{
				short num = (short)202669448;
				short num2 = num;
				num = (short)1437760904;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1272643584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)289996801;
				if (num != 0)
				{
				}
				num = (short)1696333824;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemMG90SatelliteEnabled_43777._HasDiffs;
			}
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x00997AD8 File Offset: 0x00995CD8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1445658624;
					short num3 = num2;
					num2 = (short)120455169;
					if (num2 != 0)
					{
					}
					num2 = (short)126615555;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_FD;
				case 2:
					goto IL_163;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)851509250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1941110784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_FD:
			return result;
			IL_163:
			goto IL_D2;
			IL_24:
			result = null;
			num2 = (short)2067821890;
			short num4 = num2;
			num2 = (short)228291906;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D2:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)248119297;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)483524608;
				if (num2 != 0)
				{
				}
				num2 = (short)1615986692;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x00997C50 File Offset: 0x00995E50
		private void b(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)304409250;
			short num2 = num;
			num = (short)566880930;
			switch (num2 == num)
			{
			default:
			{
				num = (short)607322112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1731002369;
			if (num != 0)
			{
			}
			num = (short)17629184;
			if (num != 0)
			{
			}
			this.a(A_0, A_1);
		}

		// Token: 0x0600A479 RID: 42105 RVA: 0x00997D04 File Offset: 0x00995F04
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)1226309634;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					base.EmbeddedRecset = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset();
					num = (short)2113798144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				for (;;)
				{
					IL_30:
					num = (short)660013056;
					short num3 = num;
					if (base.EmbeddedRecset != null)
					{
						return;
					}
					num = (short)958429895;
					short num4 = num;
					num = (short)1847098055;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9A;
					}
				}
				IL_9A:
				num = (short)1458110465;
				if (num != 0)
				{
				}
				num = (short)999555072;
				if (num != 0)
				{
				}
				num = (short)532480001;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x040050FA RID: 20730
		private global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset innerRecset;

		// Token: 0x040050FB RID: 20731
		private global::AcpBusinessLayer.AcpListField dataWideExternalDataModemType_42843;

		// Token: 0x040050FC RID: 20732
		private global::AcpBusinessLayer.AcpFieldX<string, string> dataWideDataModemPassword_A42848;

		// Token: 0x040050FD RID: 20733
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataModemPort_42851;

		// Token: 0x040050FE RID: 20734
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataModemOutOfRangeThreshold_42853;

		// Token: 0x040050FF RID: 20735
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataModemPowerupMaxGuardTime_42855;

		// Token: 0x04005100 RID: 20736
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataModemOpenMaxGuardTime_42856;

		// Token: 0x04005101 RID: 20737
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataModemVPNTunnel_43024;

		// Token: 0x04005102 RID: 20738
		private global::AcpBusinessLayer.AcpListField modemConnectionType_43350;

		// Token: 0x04005103 RID: 20739
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataModemWifiPowerupGuardTime;

		// Token: 0x04005104 RID: 20740
		private global::AcpBusinessLayer.AcpField<string> dataWideExternalDataModemVPNFriendlyName_43774;

		// Token: 0x04005105 RID: 20741
		private global::AcpBusinessLayer.AcpField<string> dataWideExternalDataModemLTEFriendlyName_43775;

		// Token: 0x04005106 RID: 20742
		private global::AcpBusinessLayer.AcpField<string> dataWideExternalDataModemMG90SatelliteFriendlyName_43776;

		// Token: 0x04005107 RID: 20743
		private global::AcpBusinessLayer.AcpField<bool> dataWideExternalDataModemMG90SatelliteEnabled_43777;
	}
}
