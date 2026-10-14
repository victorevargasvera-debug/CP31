using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.DEK;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x02000218 RID: 536
	[global::System.Serializable]
	public class Advanced : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600604A RID: 24650 RVA: 0x00569D88 File Offset: 0x00567F88
		public Advanced(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x00569DA4 File Offset: 0x00567FA4
		protected Advanced(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x00569DBC File Offset: 0x00567FBC
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1470973653;
			short num2 = num;
			num = (short)2055554773;
			switch (num2 == num)
			{
			}
			num = (short)742588416;
			if (num != 0)
			{
			}
			num = (short)1959854080;
			short num3 = num;
			num = (short)614203393;
			if (num != 0)
			{
			}
			this.radErgoWideAdvancedLogicalSwitch2_A7756 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨質蓬賮郰鿲꛴胶郸迺黼韾㌀専䐄〆㸈㸊㬌", a_), global::CommonResources.AcgResources.ID_LOGICALSWITCH2, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedLogicalSwitch2_A7756LovStrs);
			this.radErgoWideAdvancedLogicalSwitch2_A7756.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedLogicalSwitch2_A7756.DataTransferOrder = 48;
			this.radErgoWideMOSCADDataEnable_A8545 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔髖雘裚黜點ꗠ꟢蓤鏦裨껪菬軮鏰鿲郴ꣶ룸쏺주쯾㐀", a_), global::CommonResources.AcgResources.ID_MOSCADDATAENABLE);
			this.radErgoWideMOSCADDataEnable_A8545.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideMOSCADDataEnable_A8545.DataTransferOrder = 121;
			this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤럦蛨鳪裬鷮ꓰ菲뫴駶뗸髺軼课刀昂椄戆樈缊栌欎䬐簒笔爖砘甚礜尞䤠䈢䬤䤦䰨䜪爬渮रвഴ6", a_), global::CommonResources.AcgResources.ID_POWERUPONLASTSELECTEDZONEANDCHANNEL);
			this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.DataTransferOrder = 35;
			this.radErgoWideAdvancedRotarySwitchLockEnable_A8987 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤뗦蛨鿪賬鷮裰ꃲ苴黶跸飺闼돾渀怂渄䈆月樊漌挎琐䰒吔⼖‘⌚⨜", a_), global::CommonResources.AcgResources.ID_ROTARYSWITCHLOCKENABLE);
			this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.DataTransferOrder = 15;
			this.radErgoWideAdvancedSoftPowerOff_A9170 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.indexRadErgoWideAdvancedSoftPowerOff_A9170LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.idRadErgoWideAdvancedSoftPowerOff_A9170LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦蛨跪駬뿮黰蓲郴藶뛸鷺鯼ꃾ䀀㨂㐄〆㤈", a_), global::CommonResources.AcgResources.ID_SOFTPOWEROFF, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedSoftPowerOff_A9170LovStrs);
			this.radErgoWideAdvancedSoftPowerOff_A9170.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedSoftPowerOff_A9170.DataTransferOrder = 25;
			this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤뇦蛨蟪飬苮铰냲髴駶跸觺鋼鏾䴀氂昄氆昈縊礌堎砐朒純䔖䨘嘚东稞䴠䘢䘤匦䀨䐪䌬瀮瀰ĲܴԶസ༺", a_), global::CommonResources.AcgResources.ID_VOLUMECONTROLLOCKOUTWITHRSM, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244LovStrs);
			this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.DataTransferOrder = 50;
			this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꓦ臨諪菬臮铰鿲뛴飶韸迺迼郾洀伂樄搆戈搊砌笎䘐稒愔编䬘䠚倜䰞䐠伢䀤䐦崨䈪䈬䄮渰爲ܴԶସ༺࠼", a_), global::CommonResources.AcgResources.ID_CHANNELCONTROLLOCKOUTWITHRSM, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245LovStrs);
			this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.DataTransferOrder = 51;
			this.radioErgoCfgExternalAccessoryEnable_A36198 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ車뿌꣎뻐郒돔냖鳘ꏚ꧜뫞鏠跢蓤详꣨裪軬諮苰胲髴藶胸뻺鏼黾挀漂怄堆䠈㠊㬌㸎⠐⬒", a_), global::CommonResources.AcgResources.ID_EXTERNALACCESSORYENABLE);
			this.radioErgoCfgExternalAccessoryEnable_A36198.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radioErgoCfgExternalAccessoryEnable_A36198.DataTransferOrder = 52;
			this.radioErgoCfgFatalError_A36202 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ車뿌꣎뻐郒돔냖鿘뫚꧜뻞跠ꛢ韤闦蛨駪달껮싰엲쟴쟶쯸", a_), global::CommonResources.AcgResources.ID_FATALERROR);
			this.radioErgoCfgFatalError_A36202.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioErgoCfgFatalError_A36202.DataTransferOrder = 53;
			this.radErgoWideAdvancedToggleSwitchLockEnable_43773 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤돦蛨質諬菮铰ꃲ苴黶跸飺闼돾渀怂渄䈆月樊漌挎琐䰒℔␖⸘Ⱊ⸜", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHLOCKENABLE);
			this.radErgoWideAdvancedToggleSwitchLockEnable_43773.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedToggleSwitchLockEnable_43773.DataTransferOrder = 161;
			this.radErgoWideAdvancedFixedVolumeEnable_A37218 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꇦ胨鏪裬诮꟰鳲駴苶铸黺룼釾怀愂椄戆嘈䨊㸌㠎⌐−ⴔ", a_), global::CommonResources.AcgResources.ID_FIXEDVOLUMEENABLE);
			this.radErgoWideAdvancedFixedVolumeEnable_A37218.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedFixedVolumeEnable_A37218.DataTransferOrder = 57;
			this.radErgoWideAdvancedFixedVolumeLevel_A37219 = new global::AcpBusinessLayer.AcpSimpleRangeField(150, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꇦ胨鏪裬诮꟰鳲駴苶铸黺뇼髾眀昂椄堆䠈㠊㨌㴎‐⨒", a_), global::CommonResources.AcgResources.ID_FIXEDVOLUMELEVEL, 0, 255, null, null, 0, 1);
			this.radErgoWideAdvancedFixedVolumeLevel_A37219.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedFixedVolumeLevel_A37219.DataTransferOrder = 58;
			this.radErgoWideAdvancedFixedVolumeLevel_A37219.ShowHexValue = false;
			this.radErgoWideAdvancedDefaultCHHubState_A37222 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꏦ賨跪賬髮鷰蟲뛴뿶뇸軺鿼곾甀戂焄戆嘈䨊㸌㠎⌐ℒ✔", a_), global::CommonResources.AcgResources.ID_DEFAULTCONTROLHEADHUBSTATE, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedDefaultCHHubState_A37222LovStrs);
			this.radErgoWideAdvancedDefaultCHHubState_A37222.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedDefaultCHHubState_A37222.DataTransferOrder = 66;
			this.radErgoWideAdvancedConsoletteEnable_A37231 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꓦ蛨藪黬胮鷰雲致菶鳸뻺鏼黾挀漂怄堆䠈㠊㨌㴎∐−", a_), global::CommonResources.AcgResources.ID_CONSOLETTEENABLE);
			this.radErgoWideAdvancedConsoletteEnable_A37231.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedConsoletteEnable_A37231.DataTransferOrder = 56;
			this.radErgoWideAdvancedConsoletteFatalError_A37233 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꓦ蛨藪黬胮鷰雲致菶鳸뷺鳼课怀漂䀄甆笈搊缌倎倐‒∔┖⨘⠚", a_), global::CommonResources.AcgResources.ID_CONSOLETTEFATALERROR);
			this.radErgoWideAdvancedConsoletteFatalError_A37233.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoWideAdvancedConsoletteFatalError_A37233.DataTransferOrder = -1;
			this.radErgoWideAdvancedNumberofZoneBanks_A37256 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꧦ鳨蛪迬諮菰鳲鏴귶雸闺飼뷾怀洂渄理嘈䨊㸌㠎⌐☒⌔", a_), global::CommonResources.AcgResources.ID_NUMBEROFZONEBANKS, 3, 25, null, null, 0, 1);
			this.radErgoWideAdvancedNumberofZoneBanks_A37256.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedNumberofZoneBanks_A37256.DataTransferOrder = 55;
			this.radErgoWideAdvancedNumberofZoneBanks_A37256.ShowHexValue = false;
			this.radErgoWideAdvancedZoneBankOperation_A37543 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.indexRadErgoWideAdvancedZoneBankOperation_A37543LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.idRadErgoWideAdvancedZoneBankOperation_A37543LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤뷦蛨藪裬귮郰鷲黴룶觸黺迼黾甀樂樄椆嘈䨊㸌㠎␐✒☔", a_), global::CommonResources.AcgResources.ID_ZONEBANKOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedZoneBankOperation_A37543LovStrs);
			this.radErgoWideAdvancedZoneBankOperation_A37543.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedZoneBankOperation_A37543.DataTransferOrder = 54;
			this.radErgoWideAdvancedShortKeypressDurationms_A9125 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦臨蓪鿬鯮뫰雲賴蟶诸黺軼賾䔀瘂眄昆紈戊戌愎簐怒䨔嘖‘⨚⼜⨞", a_), global::CommonResources.AcgResources.ID_SHORTKEYPRESSDURATIONMS, 0, 124, null, null, 0, 50);
			this.radErgoWideAdvancedShortKeypressDurationms_A9125.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedShortKeypressDurationms_A9125.DataTransferOrder = 36;
			this.radErgoWideAdvancedShortKeypressDurationms_A9125.ShowHexValue = false;
			this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦臨蓪鿬鯮뫰雲賴蟶诸黺軼賾䔀瘂眄昆紈戊戌愎眐簒朔刖琘縚漜砞䐠䴢䘤带䐨堪爬渮࠰ȲܴĶ", a_), global::CommonResources.AcgResources.ID_SHORTKEYPRESSDURATIONFOREMERGENCYMS, 1, 124, null, null, 0, 50);
			this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.DataTransferOrder = 80;
			this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.ShowHexValue = false;
			this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨藪諬ꓮ铰諲藴藶鳸裺軼믾琀焂搄猆怈搊挌椎縐愒倔稖簘椚稜稞传䀢尤䨦娨琪氬ᜮ԰زд", a_), global::CommonResources.AcgResources.ID_LONGKEYPRESSDURATIONFOREMERGENCYMS, 0, 255, null, null, 0, 250);
			this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.DataTransferOrder = 90;
			this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.ShowHexValue = false;
			this.radErgoWideAdvancedLongKeypressDurationms_A8450 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨藪諬ꓮ铰諲藴藶鳸裺軼믾琀焂搄猆怈搊挌戎成䰒吔⼖ⴘ⸚ⴜ", a_), global::CommonResources.AcgResources.ID_LONGKEYPRESSDURATIONMS, 1, 25, null, null, 0, 250);
			this.radErgoWideAdvancedLongKeypressDurationms_A8450.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedLongKeypressDurationms_A8450.DataTransferOrder = 17;
			this.radErgoWideAdvancedLongKeypressDurationms_A8450.ShowHexValue = false;
			this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦臨蓪鿬鯮뫰雲賴蟶诸黺軼賾䔀瘂眄昆紈戊戌愎眐簒朔娖弘倚䈜帞ሠᬢဤᜦᰨ", a_), global::CommonResources.AcgResources.ID_SHORTKEYPRESSDURATIONFORMFKMS, 1, 124, null, null, 0, 50);
			this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.DataTransferOrder = 68;
			this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.ShowHexValue = false;
			this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨藪諬ꓮ铰諲藴藶鳸裺軼믾琀焂搄猆怈搊挌椎縐愒堔儖刘䐚尜Ⱎᤠᘢᔤᄦ", a_), global::CommonResources.AcgResources.ID_LONGKEYPRESSDURATIONFORMFKMS, 4, 25, null, null, 0, 250);
			this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.DataTransferOrder = 69;
			this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.ShowHexValue = false;
			this.radErgoWideAdvancedMFKInactivityTimeout_A38507 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꫦ꿨ꃪꓬ臮郰郲致黶迸鋺觼蛾唀樂栄戆昈縊礌倎倐‒ⴔ∖⤘Ⱊ", a_), global::CommonResources.AcgResources.ID_MFKINACTIVITYTIMEOUTSEC, 5, 120, null, null, 0, 1);
			this.radErgoWideAdvancedMFKInactivityTimeout_A38507.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideAdvancedMFKInactivityTimeout_A38507.DataTransferOrder = 70;
			this.radErgoWideAdvancedMFKInactivityTimeout_A38507.ShowHexValue = false;
			this.radErgoWideAdvancedSideButtonsLockEnable_A38725 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦胨迪裬귮蓰蟲致飶韸裺뇼郾戀栂䀄椆栈椊愌樎丐划☔⼖⸘⤚⠜", a_), global::CommonResources.AcgResources.ID_SIDEBUTTONSLOCKENABLE);
			this.radErgoWideAdvancedSideButtonsLockEnable_A38725.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedSideButtonsLockEnable_A38725.DataTransferOrder = 75;
			this.radErgoWideAdvancedActiveMicForRadioPTT_A38766 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼귾怀朂氄栆夈弊夌倎倐‒ⴔ‖⼘ⴚ", a_), global::CommonResources.AcgResources.ID_ACTIVEMICFORRADIOPTT, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedActiveMicForRadioPTT_A38766LovStrs);
			this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.DataTransferOrder = 129;
			this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ裨飪駬볮铰鿲郴银跸黺駼볾椀戂欄椆氈朊崌樎挐䤒稔礖簘䐚尜⬞ဠጢሤᐦ", a_), global::CommonResources.AcgResources.ID_LASTSELECTEDCHANNELPERZONEENABLE);
			this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.DataTransferOrder = 21;
			this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565 = new global::AcpBusinessLayer.AcpRangeField<int, int>(6, null, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔蓖냘뿚룜點藠闢蓤触諨軪觬ꋮ런뇲보駶飸飺觼雾眀樂焄縆崈戊怌樎縐昒愔䠖堘⼚Ⱌ⨞ᜠᘢ", a_), global::CommonResources.AcgResources.ID_MULTIFUNCTIONBUTTONINACTIVITYTIMEOUTSEC, 5, 120, 1);
			this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.DataTransferOrder = 154;
			this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.ShowHexValue = false;
			this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤곦賨鋪鷬軮闰냲髴駶跸觺鋼鏾爀伂樄搆戈䀊栌瘎䄐愒瀔搖樘会搜漞䐠簢搤ጦᠨḪᬬᘮ", a_), global::CommonResources.AcgResources.ID_KEYPADCONTROLSLOCKKEYPRESSTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569LovStrs);
			this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.DataTransferOrder = 160;
			this.radWideNVGBacklightBrightnessLevel_A41616 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌臎蟐铒韔뛖뫘냚뇜뛞蛠询釤ꗦ鯨苪諬蟮藰鷲郴蓶諸럺飼觾搀漂娄䘆㴈㨊㬌㸎✐", a_), global::CommonResources.AcgResources.ID_NIGHTVISIONGOGGLESBACKLIGHTBRIGHTNESSLEVEL, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadWideNVGBacklightBrightnessLevel_A41616LovStrs);
			this.radWideNVGBacklightBrightnessLevel_A41616.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideNVGBacklightBrightnessLevel_A41616.DataTransferOrder = 46;
			this.radErgoWideAdvancedPowerOffKeypressDuration_42489 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤럦蛨鳪裬鷮뻰闲鏴볶鳸苺跼跾搀瀂瘄䌆簈礊氌笎砐簒笔䠖ⴘ⤚⤜✞ᠠ", a_), global::CommonResources.AcgResources.ID_POWEROFFKEYPRESSDURATIONMS, 0, 10, null, null, 0, 500);
			this.radErgoWideAdvancedPowerOffKeypressDuration_42489.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedPowerOffKeypressDuration_42489.DataTransferOrder = 73;
			this.radErgoWideAdvancedPowerOffKeypressDuration_42489.ShowHexValue = false;
			this.radErgoWideAdvancedActiveMicForRSMPTT_43050 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼귾刀丂唄匆崈吊㤌㰎ℐ☒└", a_), global::CommonResources.AcgResources.ID_ACTIVEMICFORRSMPTT, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedActiveMicForRSMPTT_43050LovStrs);
			this.radErgoWideAdvancedActiveMicForRSMPTT_43050.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedActiveMicForRSMPTT_43050.DataTransferOrder = 130;
			this.radErgoWideAdvancedActiveMicForBTPTT_43051 = new global::AcpBusinessLayer.AcpListField(3, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼뷾唀匂億匆嘈㼊㸌㼎␐−", a_), global::CommonResources.AcgResources.ID_ACTIVEMICFORBLUETOOTHPTT, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedActiveMicForBTPTT_43051LovStrs);
			this.radErgoWideAdvancedActiveMicForBTPTT_43051.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedActiveMicForBTPTT_43051.DataTransferOrder = 131;
			this.radErgoWideAdvancedBTReceiveAudio_43052 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꗦ뷨맪裬賮铰髲菴鋶룸軺駼雾渀専㄄㐆㤈㸊㼌", a_), global::CommonResources.AcgResources.ID_BLUETOOTHRECEIVEAUDIO, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedBTReceiveAudio_43052LovStrs);
			this.radErgoWideAdvancedBTReceiveAudio_43052.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedBTReceiveAudio_43052.DataTransferOrder = 132;
			this.radErgoWideAdvancedActiveMicForIndirectPTT_44816 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼뛾漀朂氄甆氈栊礌弎䔐䜒䨔⌖ⴘ⌚Ⱌ⤞", a_), global::CommonResources.AcgResources.ID_ACTIVEMICFORINDIRECTPTT, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedActiveMicForIndirectPTT_44816LovStrs);
			this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.DataTransferOrder = 133;
			this.radErgoWideAdvancedTouchScreenLockEnable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤돦蛨黪軬蟮ꋰ郲蟴鋶鳸闺뇼郾戀栂䀄椆栈椊愌樎", a_), global::CommonResources.AcgResources.ID_TOUCH_SCREEN_LOCK_ENABLE);
			this.radErgoWideAdvancedTouchScreenLockEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideAdvancedTouchScreenLockEnable.DataTransferOrder = 71;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胀Ꟃ도ꛆꟈ꣊꣌ꯎ", a_);
			base.Id = 10075;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCED;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x0056A804 File Offset: 0x00568A04
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)630980706;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꧦ鳨蛪迬諮菰鳲鏴귶雸闺飼뷾怀洂渄理嘈䨊㸌㠎⌐☒⌔", a_)))
					{
						num = (short)102629412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_130A;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꗦ뷨맪裬賮铰髲菴鋶룸軺駼雾渀専㄄㐆㤈㸊㼌", a_)))
					{
						num = (short)905838623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AAD;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ車뿌꣎뻐郒돔냖鿘뫚꧜뻞跠ꛢ韤闦蛨駪달껮싰엲쟴쟶쯸", a_)))
					{
						num = (short)767688731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AC3;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꇦ胨鏪裬诮꟰鳲駴苶铸黺룼釾怀愂椄戆嘈䨊㸌㠎⌐−ⴔ", a_)))
					{
						num = (short)1084489743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8D5;
				case 4:
					goto IL_730;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤럦蛨鳪裬鷮ꓰ菲뫴駶뗸髺軼课刀昂椄戆樈缊栌欎䬐簒笔爖砘甚礜尞䤠䈢䬤䤦䰨䜪爬渮रвഴ6", a_)))
					{
						num = (short)366608427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13C0;
				case 6:
					this.radErgoWideAdvancedActiveMicForRadioPTT_A38766 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼귾怀朂氄栆夈弊夌倎倐‒ⴔ‖⼘ⴚ", a_), global::CommonResources.AcgResources.ID_ACTIVEMICFORRADIOPTT, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedActiveMicForRadioPTT_A38766LovStrs);
					this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.DataTransferOrder = 129;
					num = (short)1116602397;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_349;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꫦ꿨ꃪꓬ臮郰郲致黶迸鋺觼蛾唀樂栄戆昈縊礌倎倐‒ⴔ∖⤘Ⱊ", a_)))
					{
						num = (short)891027468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_396;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌臎蟐铒韔뛖뫘냚뇜뛞蛠询釤ꗦ鯨苪諬蟮藰鷲郴蓶諸럺飼觾搀漂娄䘆㴈㨊㬌㸎✐", a_)))
					{
						num = (short)836304955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10F9;
				case 10:
					this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨藪諬ꓮ铰諲藴藶鳸裺軼믾琀焂搄猆怈搊挌椎縐愒倔稖簘椚稜稞传䀢尤䨦娨琪氬ᜮ԰زд", a_), global::CommonResources.AcgResources.ID_LONGKEYPRESSDURATIONFOREMERGENCYMS, null, null, 0, 250);
					this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.DataTransferOrder = 90;
					this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.ShowHexValue = false;
					num = (short)487587870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_14AF;
				case 12:
					this.radErgoWideAdvancedMFKInactivityTimeout_A38507 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꫦ꿨ꃪꓬ臮郰郲致黶迸鋺觼蛾唀樂栄戆昈縊礌倎倐‒ⴔ∖⤘Ⱊ", a_), global::CommonResources.AcgResources.ID_MFKINACTIVITYTIMEOUTSEC, null, null, 0, 1);
					this.radErgoWideAdvancedMFKInactivityTimeout_A38507.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideAdvancedMFKInactivityTimeout_A38507.DataTransferOrder = 70;
					this.radErgoWideAdvancedMFKInactivityTimeout_A38507.ShowHexValue = false;
					num = (short)671088674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤뗦蛨鿪賬鷮裰ꃲ苴黶跸飺闼돾渀怂渄䈆月樊漌挎琐䰒吔⼖‘⌚⨜", a_)))
					{
						num = (short)527564865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_349;
				case 14:
					goto IL_4D4;
				case 15:
					this.radErgoWideAdvancedFixedVolumeEnable_A37218 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꇦ胨鏪裬诮꟰鳲駴苶铸黺룼釾怀愂椄戆嘈䨊㸌㠎⌐−ⴔ", a_), global::CommonResources.AcgResources.ID_FIXEDVOLUMEENABLE);
					this.radErgoWideAdvancedFixedVolumeEnable_A37218.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedFixedVolumeEnable_A37218.DataTransferOrder = 57;
					num = (short)1525874746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
				{
					num = (short)106168320;
					short num3 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔髖雘裚黜點ꗠ꟢蓤鏦裨껪菬軮鏰鿲郴ꣶ룸쏺주쯾㐀", a_)))
					{
						num = (short)209649710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FBA;
				}
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨藪諬ꓮ铰諲藴藶鳸裺軼믾琀焂搄猆怈搊挌椎縐愒倔稖簘椚稜稞传䀢尤䨦娨琪氬ᜮ԰زд", a_)))
					{
						num = (short)665452554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꏦ賨跪賬髮鷰蟲뛴뿶뇸軺鿼곾甀戂焄戆嘈䨊㸌㠎⌐ℒ✔", a_)))
					{
						num = (short)1103036460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16C2;
				case 19:
					this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ裨飪駬볮铰鿲郴银跸黺駼볾椀戂欄椆氈朊崌樎挐䤒稔礖簘䐚尜⬞ဠጢሤᐦ", a_), global::CommonResources.AcgResources.ID_LASTSELECTEDCHANNELPERZONEENABLE);
					this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.DataTransferOrder = 21;
					num = (short)1350303843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_68F;
				case 21:
					this.radErgoWideAdvancedSideButtonsLockEnable_A38725 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦胨迪裬귮蓰蟲致飶韸裺뇼郾戀栂䀄椆栈椊愌樎丐划☔⼖⸘⤚⠜", a_), global::CommonResources.AcgResources.ID_SIDEBUTTONSLOCKENABLE);
					this.radErgoWideAdvancedSideButtonsLockEnable_A38725.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedSideButtonsLockEnable_A38725.DataTransferOrder = 75;
					num = (short)2117402717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_77E;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔蓖냘뿚룜點藠闢蓤触諨軪觬ꋮ런뇲보駶飸飺觼雾眀樂焄縆崈戊怌樎縐昒愔䠖堘⼚Ⱌ⨞ᜠᘢ", a_)))
					{
						num = (short)1379991602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_77E;
				case 24:
					goto IL_522;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤뷦蛨藪裬귮郰鷲黴룶觸黺迼黾甀樂樄椆嘈䨊㸌㠎␐✒☔", a_)))
					{
						num = (short)469762096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14AF;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼뛾漀朂氄甆氈栊礌弎䔐䜒䨔⌖ⴘ⌚Ⱌ⤞", a_)))
					{
						num = (short)1726349414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56E;
				case 27:
					this.radioErgoCfgFatalError_A36202 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ車뿌꣎뻐郒돔냖鿘뫚꧜뻞跠ꛢ韤闦蛨駪달껮싰엲쟴쟶쯸", a_), global::CommonResources.AcgResources.ID_FATALERROR);
					this.radioErgoCfgFatalError_A36202.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioErgoCfgFatalError_A36202.DataTransferOrder = 53;
					num = (short)438960235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ車뿌꣎뻐郒돔냖鳘ꏚ꧜뫞鏠跢蓤详꣨裪軬諮苰胲髴藶胸뻺鏼黾挀漂怄堆䠈㠊㬌㸎⠐⬒", a_)))
					{
						num = (short)971702305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D4;
				case 29:
					goto IL_1145;
				case 30:
					goto IL_261;
				case 31:
					this.radErgoWideAdvancedBTReceiveAudio_43052 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꗦ뷨맪裬賮铰髲菴鋶룸軺駼雾渀専㄄㐆㤈㸊㼌", a_), global::CommonResources.AcgResources.ID_BLUETOOTHRECEIVEAUDIO, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedBTReceiveAudio_43052LovStrs);
					this.radErgoWideAdvancedBTReceiveAudio_43052.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedBTReceiveAudio_43052.DataTransferOrder = 132;
					num = (short)263782484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤곦賨鋪鷬軮闰냲髴駶跸觺鋼鏾爀伂樄搆戈䀊栌瘎䄐愒瀔搖樘会搜漞䐠簢搤ጦᠨḪᬬᘮ", a_)))
					{
						num = (short)1015480405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FC;
				case 33:
				{
					num = (short)1406634703;
					short num4 = num;
					num = (short)1551600335;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_145D;
					default:
						num = (short)1296695296;
						if (num != 0)
						{
						}
						this.radioErgoCfgExternalAccessoryEnable_A36198 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ車뿌꣎뻐郒돔냖鳘ꏚ꧜뫞鏠跢蓤详꣨裪軬諮苰胲髴藶胸뻺鏼黾挀漂怄堆䠈㠊㬌㸎⠐⬒", a_), global::CommonResources.AcgResources.ID_EXTERNALACCESSORYENABLE);
						this.radioErgoCfgExternalAccessoryEnable_A36198.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.radioErgoCfgExternalAccessoryEnable_A36198.DataTransferOrder = 52;
						num = (short)1396113422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 34:
					goto IL_396;
				case 35:
					num = (short)213319681;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦胨迪裬귮蓰蟲致飶韸裺뇼郾戀栂䀄椆栈椊愌樎丐划☔⼖⸘⤚⠜", a_)))
					{
						num = (short)2081292309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_213;
				case 36:
					this.radErgoWideAdvancedNumberofZoneBanks_A37256 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꧦ鳨蛪迬諮菰鳲鏴귶雸闺飼뷾怀洂渄理嘈䨊㸌㠎⌐☒⌔", a_), global::CommonResources.AcgResources.ID_NUMBEROFZONEBANKS, null, null, 0, 1);
					this.radErgoWideAdvancedNumberofZoneBanks_A37256.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedNumberofZoneBanks_A37256.DataTransferOrder = 55;
					this.radErgoWideAdvancedNumberofZoneBanks_A37256.ShowHexValue = false;
					num = (short)985071686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					goto IL_1462;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꓦ蛨藪黬胮鷰雲致菶鳸뷺鳼课怀漂䀄甆笈搊缌倎倐‒∔┖⨘⠚", a_)))
					{
						num = (short)270139445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5BC;
				case 39:
					goto IL_1566;
				case 40:
					this.radErgoWideAdvancedLongKeypressDurationms_A8450 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨藪諬ꓮ铰諲藴藶鳸裺軼믾琀焂搄猆怈搊挌戎成䰒吔⼖ⴘ⸚ⴜ", a_), global::CommonResources.AcgResources.ID_LONGKEYPRESSDURATIONMS, null, null, 0, 250);
					this.radErgoWideAdvancedLongKeypressDurationms_A8450.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideAdvancedLongKeypressDurationms_A8450.DataTransferOrder = 17;
					this.radErgoWideAdvancedLongKeypressDurationms_A8450.ShowHexValue = false;
					num = (short)1649934373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					goto IL_2AD;
				case 42:
					if (producerFields != null)
					{
						num = (short)90177636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AF9;
				case 43:
					this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤럦蛨鳪裬鷮ꓰ菲뫴駶뗸髺軼课刀昂椄戆樈缊栌欎䬐簒笔爖砘甚礜尞䤠䈢䬤䤦䰨䜪爬渮रвഴ6", a_), global::CommonResources.AcgResources.ID_POWERUPONLASTSELECTEDZONEANDCHANNEL);
					this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.DataTransferOrder = 35;
					num = (short)516554829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					this.radErgoWideAdvancedDefaultCHHubState_A37222 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꏦ賨跪賬髮鷰蟲뛴뿶뇸軺鿼곾甀戂焄戆嘈䨊㸌㠎⌐ℒ✔", a_), global::CommonResources.AcgResources.ID_DEFAULTCONTROLHEADHUBSTATE, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedDefaultCHHubState_A37222LovStrs);
					this.radErgoWideAdvancedDefaultCHHubState_A37222.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedDefaultCHHubState_A37222.DataTransferOrder = 66;
					num = (short)2035482676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦臨蓪鿬鯮뫰雲賴蟶诸黺軼賾䔀瘂眄昆紈戊戌愎眐簒朔娖弘倚䈜帞ሠᬢဤᜦᰨ", a_), global::CommonResources.AcgResources.ID_SHORTKEYPRESSDURATIONFORMFKMS, null, null, 0, 50);
					this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.DataTransferOrder = 68;
					this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.ShowHexValue = false;
					num = (short)1203241027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					this.radErgoWideMOSCADDataEnable_A8545 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔髖雘裚黜點ꗠ꟢蓤鏦裨껪菬軮鏰鿲郴ꣶ룸쏺주쯾㐀", a_), global::CommonResources.AcgResources.ID_MOSCADDATAENABLE);
					this.radErgoWideMOSCADDataEnable_A8545.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideMOSCADDataEnable_A8545.DataTransferOrder = 121;
					num = (short)336265288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤돦蛨質諬菮铰ꃲ苴黶跸飺闼돾渀怂渄䈆月樊漌挎琐䰒℔␖⸘Ⱊ⸜", a_)))
					{
						num = (short)1976827984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A1E;
				case 48:
					this.radErgoWideAdvancedZoneBankOperation_A37543 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.indexRadErgoWideAdvancedZoneBankOperation_A37543LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.idRadErgoWideAdvancedZoneBankOperation_A37543LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤뷦蛨藪裬귮郰鷲黴룶觸黺迼黾甀樂樄椆嘈䨊㸌㠎␐✒☔", a_), global::CommonResources.AcgResources.ID_ZONEBANKOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedZoneBankOperation_A37543LovStrs);
					this.radErgoWideAdvancedZoneBankOperation_A37543.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedZoneBankOperation_A37543.DataTransferOrder = 54;
					num = (short)1893924875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					num = (short)1619066922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565 = new global::AcpBusinessLayer.AcpRangeField<int, int>(6, null, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔蓖냘뿚룜點藠闢蓤触諨軪觬ꋮ런뇲보駶飸飺觼雾眀樂焄縆崈戊怌樎縐昒愔䠖堘⼚Ⱌ⨞ᜠᘢ", a_), global::CommonResources.AcgResources.ID_MULTIFUNCTIONBUTTONINACTIVITYTIMEOUTSEC);
					this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.DataTransferOrder = 154;
					this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.ShowHexValue = false;
					num = (short)1631584278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꓦ臨諪菬臮铰鿲뛴飶韸迺迼郾洀伂樄搆戈搊砌笎䘐稒愔编䬘䠚倜䰞䐠伢䀤䐦崨䈪䈬䄮渰爲ܴԶସ༺࠼", a_), global::CommonResources.AcgResources.ID_CHANNELCONTROLLOCKOUTWITHRSM, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245LovStrs);
					this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.DataTransferOrder = 51;
					num = (short)1087242281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 52:
					goto IL_16C2;
				case 53:
					this.radErgoWideAdvancedConsoletteFatalError_A37233 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꓦ蛨藪黬胮鷰雲致菶鳸뷺鳼课怀漂䀄甆笈搊缌倎倐‒∔┖⨘⠚", a_), global::CommonResources.AcgResources.ID_CONSOLETTEFATALERROR);
					this.radErgoWideAdvancedConsoletteFatalError_A37233.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoWideAdvancedConsoletteFatalError_A37233.DataTransferOrder = -1;
					num = (short)110493788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					this.radErgoWideAdvancedSoftPowerOff_A9170 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.indexRadErgoWideAdvancedSoftPowerOff_A9170LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.idRadErgoWideAdvancedSoftPowerOff_A9170LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦蛨跪駬뿮黰蓲郴藶뛸鷺鯼ꃾ䀀㨂㐄〆㤈", a_), global::CommonResources.AcgResources.ID_SOFTPOWEROFF, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedSoftPowerOff_A9170LovStrs);
					this.radErgoWideAdvancedSoftPowerOff_A9170.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedSoftPowerOff_A9170.DataTransferOrder = 25;
					num = (short)362151956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					goto IL_56E;
				case 56:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼귾刀丂唄匆崈吊㤌㰎ℐ☒└", a_)))
					{
						num = (short)514195538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_730;
				case 57:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤럦蛨鳪裬鷮뻰闲鏴볶鳸苺跼跾搀瀂瘄䌆簈礊氌笎砐簒笔䠖ⴘ⤚⤜✞ᠠ", a_)))
					{
						num = (short)1358757997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_522;
				case 58:
					goto IL_8D5;
				case 59:
					this.radWideNVGBacklightBrightnessLevel_A41616 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌臎蟐铒韔뛖뫘냚뇜뛞蛠询釤ꗦ鯨苪諬蟮藰鷲郴蓶諸럺飼觾搀漂娄䘆㴈㨊㬌㸎✐", a_), global::CommonResources.AcgResources.ID_NIGHTVISIONGOGGLESBACKLIGHTBRIGHTNESSLEVEL, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadWideNVGBacklightBrightnessLevel_A41616LovStrs);
					this.radWideNVGBacklightBrightnessLevel_A41616.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideNVGBacklightBrightnessLevel_A41616.DataTransferOrder = 46;
					num = (short)1992163419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦蛨跪駬뿮黰蓲郴藶뛸鷺鯼ꃾ䀀㨂㐄〆㤈", a_)))
					{
						num = (short)1089667126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_68F;
				case 61:
					goto IL_1061;
				case 62:
					this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨藪諬ꓮ铰諲藴藶鳸裺軼믾琀焂搄猆怈搊挌椎縐愒堔儖刘䐚尜Ⱎᤠᘢᔤᄦ", a_), global::CommonResources.AcgResources.ID_LONGKEYPRESSDURATIONFORMFKMS, null, null, 0, 250);
					this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.DataTransferOrder = 69;
					this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.ShowHexValue = false;
					num = (short)1965359165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 63:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦臨蓪鿬鯮뫰雲賴蟶诸黺軼賾䔀瘂眄昆紈戊戌愎簐怒䨔嘖‘⨚⼜⨞", a_)))
					{
						num = (short)1586167898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1566;
				case 64:
					goto IL_642;
				case 65:
					this.radErgoWideAdvancedRotarySwitchLockEnable_A8987 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤뗦蛨鿪賬鷮裰ꃲ苴黶跸飺闼돾渀怂渄䈆月樊漌挎琐䰒吔⼖‘⌚⨜", a_), global::CommonResources.AcgResources.ID_ROTARYSWITCHLOCKENABLE);
					this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.DataTransferOrder = 15;
					num = (short)1585446919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 66:
					goto IL_19B2;
				case 67:
					goto IL_15B2;
				case 68:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨質蓬賮郰鿲꛴胶郸迺黼韾㌀専䐄〆㸈㸊㬌", a_)))
					{
						num = (short)892403807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_187E;
				case 69:
					this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦臨蓪鿬鯮뫰雲賴蟶诸黺軼賾䔀瘂眄昆紈戊戌愎眐簒朔刖琘縚漜砞䐠䴢䘤带䐨堪爬渮࠰ȲܴĶ", a_), global::CommonResources.AcgResources.ID_SHORTKEYPRESSDURATIONFOREMERGENCYMS, null, null, 0, 50);
					this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.DataTransferOrder = 80;
					this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.ShowHexValue = false;
					num = (short)235208770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 70:
					goto IL_130A;
				case 71:
					goto IL_11FB;
				case 72:
					goto IL_FBA;
				case 73:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦臨蓪鿬鯮뫰雲賴蟶诸黺軼賾䔀瘂眄昆紈戊戌愎眐簒朔刖琘縚漜砞䐠䴢䘤带䐨堪爬渮࠰ȲܴĶ", a_)))
					{
						num = (short)772603973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19B2;
				case 74:
					goto IL_81D;
				case 75:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼귾怀朂氄栆夈弊夌倎倐‒ⴔ‖⼘ⴚ", a_)))
					{
						num = (short)645791750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1145;
				case 76:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼뷾唀匂億匆嘈㼊㸌㼎␐−", a_)))
					{
						num = (short)52035695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11FB;
				case 77:
					goto IL_13C0;
				case 78:
					goto IL_1AAB;
				case 79:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨藪諬ꓮ铰諲藴藶鳸裺軼믾琀焂搄猆怈搊挌椎縐愒堔儖刘䐚尜Ⱎᤠᘢᔤᄦ", a_)))
					{
						num = (short)1936785470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1061;
				case 80:
					this.radErgoWideAdvancedToggleSwitchLockEnable_43773 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤돦蛨質諬菮铰ꃲ苴黶跸飺闼돾渀怂渄䈆月樊漌挎琐䰒℔␖⸘Ⱊ⸜", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHLOCKENABLE);
					this.radErgoWideAdvancedToggleSwitchLockEnable_43773.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedToggleSwitchLockEnable_43773.DataTransferOrder = 161;
					num = (short)1633026153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 81:
					this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤뇦蛨蟪飬苮铰냲髴駶跸觺鋼鏾䴀氂昄氆昈縊礌堎砐朒純䔖䨘嘚东稞䴠䘢䘤匦䀨䐪䌬瀮瀰ĲܴԶസ༺", a_), global::CommonResources.AcgResources.ID_VOLUMECONTROLLOCKOUTWITHRSM, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244LovStrs);
					this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.DataTransferOrder = 50;
					num = (short)707788864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 82:
					this.radErgoWideAdvancedActiveMicForRSMPTT_43050 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼귾刀丂唄匆崈吊㤌㰎ℐ☒└", a_), global::CommonResources.AcgResources.ID_ACTIVEMICFORRSMPTT, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedActiveMicForRSMPTT_43050LovStrs);
					this.radErgoWideAdvancedActiveMicForRSMPTT_43050.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedActiveMicForRSMPTT_43050.DataTransferOrder = 130;
					num = (short)785711108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 83:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤돦蛨黪軬蟮ꋰ郲蟴鋶鳸闺뇼郾戀栂䀄椆栈椊愌樎", a_)))
					{
						num = (short)1854406759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AF9;
				case 84:
					goto IL_1AAD;
				case 85:
					this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤곦賨鋪鷬軮闰냲髴駶跸觺鋼鏾爀伂樄搆戈䀊栌瘎䄐愒瀔搖樘会搜漞䐠簢搤ጦᠨḪᬬᘮ", a_), global::CommonResources.AcgResources.ID_KEYPADCONTROLSLOCKKEYPRESSTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569LovStrs);
					this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.DataTransferOrder = 160;
					num = (short)896073834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 86:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꓦ臨諪菬臮铰鿲뛴飶韸迺迼郾洀伂樄搆戈搊砌笎䘐稒愔编䬘䠚倜䰞䐠伢䀤䐦崨䈪䈬䄮渰爲ܴԶସ༺࠼", a_)))
					{
						num = (short)1807286323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AD;
				case 87:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦臨蓪鿬鯮뫰雲賴蟶诸黺軼賾䔀瘂眄昆紈戊戌愎眐簒朔娖弘倚䈜帞ሠᬢဤᜦᰨ", a_)))
					{
						num = (short)1107230765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15B2;
				case 88:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꇦ胨鏪裬诮꟰鳲駴苶铸黺뇼髾眀昂椄堆䠈㠊㨌㴎‐⨒", a_)))
					{
						num = (short)1636761710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10AD;
				case 89:
					this.radErgoWideAdvancedConsoletteEnable_A37231 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꓦ蛨藪黬胮鷰雲致菶鳸뻺鏼黾挀漂怄堆䠈㠊㨌㴎∐−", a_), global::CommonResources.AcgResources.ID_CONSOLETTEENABLE);
					this.radErgoWideAdvancedConsoletteEnable_A37231.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedConsoletteEnable_A37231.DataTransferOrder = 56;
					num = (short)1750401098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 90:
					this.radErgoWideAdvancedShortKeypressDurationms_A9125 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤듦臨蓪鿬鯮뫰雲賴蟶诸黺軼賾䔀瘂眄昆紈戊戌愎簐怒䨔嘖‘⨚⼜⨞", a_), global::CommonResources.AcgResources.ID_SHORTKEYPRESSDURATIONMS, null, null, 0, 50);
					this.radErgoWideAdvancedShortKeypressDurationms_A9125.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideAdvancedShortKeypressDurationms_A9125.DataTransferOrder = 36;
					this.radErgoWideAdvancedShortKeypressDurationms_A9125.ShowHexValue = false;
					num = (short)1067581479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 91:
					goto IL_10F9;
				case 92:
					goto IL_5BC;
				case 93:
					goto IL_213;
				case 94:
					goto IL_10AD;
				case 95:
					this.radErgoWideAdvancedLogicalSwitch2_A7756 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨質蓬賮郰鿲꛴胶郸迺黼韾㌀専䐄〆㸈㸊㬌", a_), global::CommonResources.AcgResources.ID_LOGICALSWITCH2, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedLogicalSwitch2_A7756LovStrs);
					this.radErgoWideAdvancedLogicalSwitch2_A7756.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedLogicalSwitch2_A7756.DataTransferOrder = 48;
					num = (short)1930821728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 96:
					goto IL_187E;
				case 97:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꓦ蛨藪黬胮鷰雲致菶鳸뻺鏼黾挀漂怄堆䠈㠊㨌㴎∐−", a_)))
					{
						num = (short)609026137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_81D;
				case 98:
					switch (0)
					{
					case 0:
						goto IL_1ED;
					}
					continue;
				case 99:
					goto IL_145D;
				case 100:
					num = (short)2028011588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 101:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ蛨藪諬ꓮ铰諲藴藶鳸裺軼믾琀焂搄猆怈搊挌戎成䰒吔⼖ⴘ⸚ⴜ", a_)))
					{
						num = (short)110559272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1462;
				case 102:
					this.radErgoWideAdvancedActiveMicForIndirectPTT_44816 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼뛾漀朂氄甆氈栊礌弎䔐䜒䨔⌖ⴘ⌚Ⱌ⤞", a_), global::CommonResources.AcgResources.ID_ACTIVEMICFORINDIRECTPTT, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedActiveMicForIndirectPTT_44816LovStrs);
					this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.DataTransferOrder = 133;
					num = (short)1801322551;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 103:
					this.radErgoWideAdvancedTouchScreenLockEnable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤돦蛨黪軬蟮ꋰ郲蟴鋶鳸闺뇼郾戀栂䀄椆栈椊愌樎", a_), global::CommonResources.AcgResources.ID_TOUCH_SCREEN_LOCK_ENABLE);
					this.radErgoWideAdvancedTouchScreenLockEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideAdvancedTouchScreenLockEnable.DataTransferOrder = 71;
					num = (short)898826318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 104:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤뇦蛨蟪飬苮铰냲髴駶跸觺鋼鏾䴀氂昄氆昈縊礌堎砐朒純䔖䨘嘚东稞䴠䘢䘤匦䀨䐪䌬瀮瀰ĲܴԶസ༺", a_)))
					{
						num = (short)1138557009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_642;
				case 105:
					goto IL_A1E;
				case 106:
					goto IL_2FC;
				case 107:
					goto IL_AC3;
				case 108:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꯦ裨飪駬볮铰鿲郴银跸黺駼볾椀戂欄椆氈朊崌樎挐䤒稔礖簘䐚尜⬞ဠጢሤᐦ", a_)))
					{
						num = (short)1274413075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C94;
				case 109:
					this.radErgoWideAdvancedPowerOffKeypressDuration_42489 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤럦蛨鳪裬鷮뻰闲鏴볶鳸苺跼跾搀瀂瘄䌆簈礊氌笎砐簒笔䠖ⴘ⤚⤜✞ᠠ", a_), global::CommonResources.AcgResources.ID_POWEROFFKEYPRESSDURATIONMS, null, null, 0, 500);
					this.radErgoWideAdvancedPowerOffKeypressDuration_42489.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideAdvancedPowerOffKeypressDuration_42489.DataTransferOrder = 73;
					this.radErgoWideAdvancedPowerOffKeypressDuration_42489.ShowHexValue = false;
					num = (short)470024216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 110:
					this.radErgoWideAdvancedFixedVolumeLevel_A37219 = new global::AcpBusinessLayer.AcpSimpleRangeField(150, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꇦ胨鏪裬诮꟰鳲駴苶铸黺뇼髾眀昂椄堆䠈㠊㨌㴎‐⨒", a_), global::CommonResources.AcgResources.ID_FIXEDVOLUMELEVEL, null, null, 0, 1);
					this.radErgoWideAdvancedFixedVolumeLevel_A37219.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedFixedVolumeLevel_A37219.DataTransferOrder = 58;
					this.radErgoWideAdvancedFixedVolumeLevel_A37219.ShowHexValue = false;
					num = (short)1712652382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 111:
					this.radErgoWideAdvancedActiveMicForBTPTT_43051 = new global::AcpBusinessLayer.AcpListField(3, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔雖뷘귚볜뇞苠蛢臤ꛦ諨鿪蓬駮铰뻲鳴银뿸铺迼뷾唀匂億匆嘈㼊㸌㼎␐−", a_), global::CommonResources.AcgResources.ID_ACTIVEMICFORBLUETOOTHPTT, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideAdvancedActiveMicForBTPTT_43051LovStrs);
					this.radErgoWideAdvancedActiveMicForBTPTT_43051.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideAdvancedActiveMicForBTPTT_43051.DataTransferOrder = 131;
					num = (short)1610547271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1ED:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)967049265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_213:
				num = (short)203620427;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_261:
				num = (short)1718550629;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AD:
				num = (short)367460380;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2FC:
				num = (short)1631649801;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_349:
				num = (short)726597692;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_396:
				num = (short)807469091;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4D4:
				num = (short)615186434;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_522:
				num = (short)105185336;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_56E:
				num = (short)2098397267;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5BC:
				num = (short)909377536;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_642:
				num = (short)1337720918;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_68F:
				num = (short)1275330664;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_730:
				num = (short)1692401740;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_77E:
				num = (short)1642266656;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_81D:
				num = (short)814284838;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8D5:
				num = (short)1403387992;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A1E:
				num = (short)2053111811;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AC3:
				num = (short)516751407;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C94:
				num = (short)252575767;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_145D:
				goto IL_C94;
				IL_FBA:
				num = (short)100073477;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1061:
				num = (short)610205704;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10AD:
				num = (short)1488781330;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10F9:
				num = (short)848166969;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1145:
				num = (short)1159069804;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11FB:
				num = (short)1050345473;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_130A:
				num = (short)29687833;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13C0:
				num = (short)1358954509;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1462:
				num = (short)407896151;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14AF:
				num = (short)1137049663;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1566:
				num = (short)473890889;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15B2:
				num = (short)1769734223;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16C2:
				num = (short)868941921;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_187E:
				num = (short)16384016;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19B2:
				num = (short)105906193;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AAD:
				num = (short)373882906;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1AAB:
			IL_1AF9:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胀Ꟃ도ꛆꟈ꣊꣌ꯎ", a_);
			base.Id = 10075;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCED;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x0056C33C File Offset: 0x0056A53C
		public override void PopulateReferences()
		{
			short num = (short)1193549234;
			short num2 = num;
			num = (short)1843404210;
			switch (num2 == num)
			{
			}
			num = (short)463142912;
			if (num != 0)
			{
			}
			num = (short)1022296064;
			short num3 = num;
			num = (short)2009923585;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x0056C3E4 File Offset: 0x0056A5E4
		public override void DropReferences()
		{
			short num = (short)20326316;
			short num2 = num;
			num = (short)2113152940;
			switch (num2 == num)
			{
			}
			num = (short)1644036097;
			if (num != 0)
			{
			}
			num = (short)1178337280;
			short num3 = num;
			num = (short)570621952;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x0056C48C File Offset: 0x0056A68C
		public override void SetConstraints()
		{
			short num = (short)1445958908;
			short num2 = num;
			num = (short)821597436;
			switch (num2 == num)
			{
			}
			num = (short)1438515201;
			if (num != 0)
			{
			}
			num = (short)1675165696;
			short num3 = num;
			num = (short)1511522304;
			if (num != 0)
			{
			}
			this.radErgoWideAdvancedLogicalSwitch2_A7756.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConToSyncLogicalSwitch2ToPosAInTrkAndCnv);
			this.radErgoWideMOSCADDataEnable_A8545.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conMOSCADDataApp);
			this.radErgoWideMOSCADDataEnable_A8545.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conMOSCADDataValid);
			this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadWideLastSelChanIsEnabled);
			this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadWidePowerUpOnLastZoneChanIsValid);
			this.radioErgoCfgExternalAccessoryEnable_A36198.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConDualRadioSystemIsNOTSecondaryApp);
			this.radErgoWideAdvancedFixedVolumeLevel_A37219.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conFixedVolumeIsEn);
			this.radErgoWideAdvancedConsoletteEnable_A37231.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConDVRSIsEnAndConsoletteApp);
			this.radErgoWideAdvancedConsoletteEnable_A37231.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConDVRSIsEnAndConsoletteValid);
			this.radErgoWideAdvancedNumberofZoneBanks_A37256.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conZoneBankOperationIsEnhanced);
			this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadEmerKeyPressEditability);
			this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conIsShortKeypressDurEmergencyValid);
			this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conIsLongKeypressDurEmergencyValid);
			this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadEmerKeyPressEditability);
			this.radErgoWideAdvancedLongKeypressDurationms_A8450.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadWideLongPressDurIsValid);
			this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConMKFPressBehaviorIsNOTEmergencyANDSecondaryRadio);
			this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConMKFPressBehaviorIsNOTEmergency);
			this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conIsLongKeypressDurForMFKValid);
			this.radErgoWideAdvancedMFKInactivityTimeout_A38507.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConMKFPressBehaviorIsNOTEmergencyANDSecondaryRadio);
			this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConSetPowerUpOnLastZoneChan);
			this.radErgoWideAdvancedActiveMicForBTPTT_43051.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConBluetoothEnableIsEnabled);
			this.radErgoWideAdvancedActiveMicForBTPTT_43051.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConSyncNewToActiveRSMInternalMicIfNoBTMic);
			this.radErgoWideAdvancedBTReceiveAudio_43052.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConBluetoothEnableIsEnabled);
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x0056C748 File Offset: 0x0056A948
		public override void SetupDependencies()
		{
			short num = (short)324151284;
			short num2 = num;
			num = (short)447424500;
			switch (num2 == num)
			{
			}
			num = (short)2003959808;
			if (num != 0)
			{
			}
			num = (short)1621295104;
			short num3 = num;
			num = (short)476774401;
			if (num != 0)
			{
			}
			this.RefRadioWide.Features.RadWideAdvancedRFModem_A8972.AddDependentObject(this.radErgoWideMOSCADDataEnable_A8545);
			this.RefDEK.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.radErgoWideMOSCADDataEnable_A8545);
			this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.AddDependentObject(this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radioErgoCfgExternalAccessoryEnable_A36198);
			this.radErgoWideAdvancedFixedVolumeEnable_A37218.AddDependentObject(this.radErgoWideAdvancedFixedVolumeLevel_A37219);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.radErgoWideAdvancedConsoletteEnable_A37231);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideAdvancedConsoletteEnable_A37231);
			this.radErgoWideAdvancedZoneBankOperation_A37543.AddDependentObject(this.radErgoWideAdvancedNumberofZoneBanks_A37256);
			this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.AddDependentObject(this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451);
			this.RefEmergencyWide.General.EmerWideGeneralKeepAlive_A8360.AddDependentObject(this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451);
			this.radErgoWideAdvancedShortKeypressDurationms_A9125.AddDependentObject(this.radErgoWideAdvancedLongKeypressDurationms_A8450);
			this.RefControlHeadO2.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.AddDependentObject(this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505);
			this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.AddDependentObject(this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506);
			this.RefControlHeadO2.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.AddDependentObject(this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506);
			this.RefControlHeadO2.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.AddDependentObject(this.radErgoWideAdvancedMFKInactivityTimeout_A38507);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideAdvancedMFKInactivityTimeout_A38507);
			this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.AddDependentObject(this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073);
			this.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radErgoWideAdvancedActiveMicForBTPTT_43051);
			this.RefRadioWide.Labtool.RadWideLabtoolActiveMicForBTPTTCapable_43053.AddDependentObject(this.radErgoWideAdvancedActiveMicForBTPTT_43051);
			this.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radErgoWideAdvancedBTReceiveAudio_43052);
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x06006052 RID: 24658 RVA: 0x0056C9F8 File Offset: 0x0056ABF8
		public bool HasDiffs
		{
			get
			{
				short num = (short)285696264;
				short num2 = num;
				num = (short)1330340104;
				switch (num2 == num)
				{
				}
				num = (short)1944256512;
				if (num != 0)
				{
				}
				num = (short)1129447424;
				short num3 = num;
				num = (short)205586433;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x06006053 RID: 24659 RVA: 0x0056CAA8 File Offset: 0x0056ACA8
		// (set) Token: 0x06006054 RID: 24660 RVA: 0x0056CB60 File Offset: 0x0056AD60
		public int RadErgoWideAdvancedLogicalSwitch2_A7756Value
		{
			get
			{
				short num = (short)763781924;
				short num2 = num;
				num = (short)1719952164;
				switch (num2 == num)
				{
				}
				num = (short)2127626240;
				if (num != 0)
				{
				}
				num = (short)1141374976;
				short num3 = num;
				num = (short)1089929217;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756.Value;
			}
			set
			{
				short num = (short)827457537;
				if (num != 0)
				{
				}
				num = (short)407784935;
				short num2 = num;
				num = (short)709447143;
				switch (num2 == num)
				{
				}
				num = (short)983367680;
				short num3 = num;
				num = (short)747110400;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLogicalSwitch2_A7756.Value = value;
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x06006055 RID: 24661 RVA: 0x0056CC18 File Offset: 0x0056AE18
		// (set) Token: 0x06006056 RID: 24662 RVA: 0x0056CCCC File Offset: 0x0056AECC
		public string RadErgoWideAdvancedLogicalSwitch2_A7756_UIValue
		{
			get
			{
				short num = (short)1939307847;
				short num2 = num;
				num = (short)1554021703;
				switch (num2 == num)
				{
				}
				num = (short)2042036224;
				if (num != 0)
				{
				}
				num = (short)51773440;
				short num3 = num;
				num = (short)548274177;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756.UIValue;
			}
			set
			{
				short num = (short)1654773326;
				short num2 = num;
				num = (short)1639372366;
				switch (num2 == num)
				{
				}
				num = (short)111607809;
				if (num != 0)
				{
				}
				num = (short)1692008448;
				short num3 = num;
				num = (short)2026110976;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLogicalSwitch2_A7756.UIValue = value;
			}
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x06006057 RID: 24663 RVA: 0x0056CD88 File Offset: 0x0056AF88
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedLogicalSwitch2_A7756
		{
			get
			{
				short num = (short)782808060;
				short num2 = num;
				num = (short)1710076924;
				switch (num2 == num)
				{
				}
				num = (short)549781505;
				if (num != 0)
				{
				}
				num = (short)1704984576;
				short num3 = num;
				num = (short)231276544;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756;
			}
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x06006058 RID: 24664 RVA: 0x0056CE3C File Offset: 0x0056B03C
		// (set) Token: 0x06006059 RID: 24665 RVA: 0x0056CEEC File Offset: 0x0056B0EC
		public bool RadErgoWideAdvancedLogicalSwitch2_A7756_Applicable
		{
			get
			{
				short num = (short)1933345802;
				short num2 = num;
				num = (short)1417184266;
				switch (num2 == num)
				{
				}
				num = (short)14745600;
				if (num != 0)
				{
				}
				num = (short)1923022848;
				short num3 = num;
				num = (short)749535233;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756.Applicable;
			}
			set
			{
				short num = (short)1501655095;
				short num2 = num;
				num = (short)33845303;
				switch (num2 == num)
				{
				}
				num = (short)195493888;
				if (num != 0)
				{
				}
				num = (short)1729953792;
				short num3 = num;
				num = (short)1412694017;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLogicalSwitch2_A7756.Applicable = value;
			}
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600605A RID: 24666 RVA: 0x0056CFA4 File Offset: 0x0056B1A4
		// (set) Token: 0x0600605B RID: 24667 RVA: 0x0056D05C File Offset: 0x0056B25C
		public bool RadErgoWideAdvancedLogicalSwitch2_A7756_Valid
		{
			get
			{
				short num = (short)1144809170;
				short num2 = num;
				num = (short)341206738;
				switch (num2 == num)
				{
				}
				num = (short)353632257;
				if (num != 0)
				{
				}
				num = (short)1168179200;
				short num3 = num;
				num = (short)1146093568;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756.Valid;
			}
			set
			{
				short num = (short)101364243;
				short num2 = num;
				num = (short)584299027;
				switch (num2 == num)
				{
				}
				num = (short)582483969;
				if (num != 0)
				{
				}
				num = (short)1634009088;
				short num3 = num;
				num = (short)414253056;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLogicalSwitch2_A7756.Valid = value;
			}
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600605C RID: 24668 RVA: 0x0056D114 File Offset: 0x0056B314
		// (set) Token: 0x0600605D RID: 24669 RVA: 0x0056D1C8 File Offset: 0x0056B3C8
		public bool RadErgoWideAdvancedLogicalSwitch2_A7756_Visible
		{
			get
			{
				short num = (short)2032008644;
				short num2 = num;
				num = (short)1560739268;
				switch (num2 == num)
				{
				}
				num = (short)882114561;
				if (num != 0)
				{
				}
				num = (short)1500119040;
				short num3 = num;
				num = (short)1191968768;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756.Visible;
			}
			set
			{
				short num = (short)1358280449;
				short num2 = num;
				num = (short)1468053249;
				switch (num2 == num)
				{
				}
				num = (short)761069568;
				if (num != 0)
				{
				}
				num = (short)2145779712;
				short num3 = num;
				num = (short)483328001;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLogicalSwitch2_A7756.Visible = value;
			}
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600605E RID: 24670 RVA: 0x0056D280 File Offset: 0x0056B480
		// (set) Token: 0x0600605F RID: 24671 RVA: 0x0056D338 File Offset: 0x0056B538
		public bool RadErgoWideAdvancedLogicalSwitch2_A7756_Editable
		{
			get
			{
				short num = (short)1546256385;
				if (num != 0)
				{
				}
				num = (short)1518946990;
				short num2 = num;
				num = (short)251087534;
				switch (num2 == num)
				{
				}
				num = (short)1639055360;
				short num3 = num;
				num = (short)1831665664;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756.Editable;
			}
			set
			{
				short num = (short)330289325;
				short num2 = num;
				num = (short)60281005;
				switch (num2 == num)
				{
				}
				num = (short)2130968577;
				if (num != 0)
				{
				}
				num = (short)1334378496;
				short num3 = num;
				num = (short)1831534592;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLogicalSwitch2_A7756.Editable = value;
			}
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x06006060 RID: 24672 RVA: 0x0056D3EC File Offset: 0x0056B5EC
		internal string RadErgoWideAdvancedLogicalSwitch2_A7756_UILabel
		{
			get
			{
				short num = (short)1224423291;
				short num2 = num;
				num = (short)491534203;
				switch (num2 == num)
				{
				}
				num = (short)1986789377;
				if (num != 0)
				{
				}
				num = (short)150142976;
				short num3 = num;
				num = (short)2121072640;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756.UIName;
			}
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x06006061 RID: 24673 RVA: 0x0056D4A0 File Offset: 0x0056B6A0
		// (set) Token: 0x06006062 RID: 24674 RVA: 0x0056D554 File Offset: 0x0056B754
		internal bool RadErgoWideAdvancedLogicalSwitch2_A7756_HiddenStatic
		{
			get
			{
				short num = (short)289464885;
				short num2 = num;
				num = (short)1459806773;
				switch (num2 == num)
				{
				}
				num = (short)1860370432;
				if (num != 0)
				{
				}
				num = (short)1529479168;
				short num3 = num;
				num = (short)2147024897;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756.HiddenStatic;
			}
			set
			{
				short num = (short)1231980207;
				short num2 = num;
				num = (short)1261668015;
				switch (num2 == num)
				{
				}
				num = (short)1966735361;
				if (num != 0)
				{
				}
				num = (short)2109997056;
				short num3 = num;
				num = (short)961478656;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLogicalSwitch2_A7756.HiddenStatic = value;
			}
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x06006063 RID: 24675 RVA: 0x0056D60C File Offset: 0x0056B80C
		// (set) Token: 0x06006064 RID: 24676 RVA: 0x0056D6C0 File Offset: 0x0056B8C0
		internal bool RadErgoWideAdvancedLogicalSwitch2_A7756_HiddenDynamic
		{
			get
			{
				short num = (short)1506392567;
				short num2 = num;
				num = (short)52673015;
				switch (num2 == num)
				{
				}
				num = (short)479789056;
				if (num != 0)
				{
				}
				num = (short)2006253568;
				short num3 = num;
				num = (short)394526721;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756.HiddenDynamic;
			}
			set
			{
				short num = (short)1782676310;
				short num2 = num;
				num = (short)1626241878;
				switch (num2 == num)
				{
				}
				num = (short)1568735232;
				if (num != 0)
				{
				}
				num = (short)37027840;
				short num3 = num;
				num = (short)1414791169;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLogicalSwitch2_A7756.HiddenDynamic = value;
			}
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x06006065 RID: 24677 RVA: 0x0056D778 File Offset: 0x0056B978
		public bool RadErgoWideAdvancedLogicalSwitch2_A7756_HasDiffs
		{
			get
			{
				short num = (short)1763360810;
				short num2 = num;
				num = (short)1488306218;
				switch (num2 == num)
				{
				}
				num = (short)750387200;
				if (num != 0)
				{
				}
				num = (short)1958477824;
				short num3 = num;
				num = (short)1845821441;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLogicalSwitch2_A7756._HasDiffs;
			}
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x06006066 RID: 24678 RVA: 0x0056D82C File Offset: 0x0056BA2C
		// (set) Token: 0x06006067 RID: 24679 RVA: 0x0056D8E0 File Offset: 0x0056BAE0
		public bool RadErgoWideMOSCADDataEnable_A8545Value
		{
			get
			{
				short num = (short)534202118;
				short num2 = num;
				num = (short)750929670;
				switch (num2 == num)
				{
				}
				num = (short)1175584769;
				if (num != 0)
				{
				}
				num = (short)1196032000;
				short num3 = num;
				num = (short)1867186176;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545.Value;
			}
			set
			{
				short num = (short)1398065146;
				short num2 = num;
				num = (short)1039386618;
				switch (num2 == num)
				{
				}
				num = (short)798425089;
				if (num != 0)
				{
				}
				num = (short)802029568;
				short num3 = num;
				num = (short)1633615872;
				if (num != 0)
				{
				}
				this.radErgoWideMOSCADDataEnable_A8545.Value = value;
			}
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x0056D998 File Offset: 0x0056BB98
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideMOSCADDataEnable_A8545
		{
			get
			{
				short num = (short)1781727233;
				if (num != 0)
				{
				}
				num = (short)129792512;
				short num2 = num;
				num = (short)1154120192;
				switch (num2 == num)
				{
				}
				num = (short)1277624320;
				short num3 = num;
				num = (short)1003487232;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545;
			}
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x06006069 RID: 24681 RVA: 0x0056DA4C File Offset: 0x0056BC4C
		// (set) Token: 0x0600606A RID: 24682 RVA: 0x0056DB04 File Offset: 0x0056BD04
		public bool RadErgoWideMOSCADDataEnable_A8545_UIValue
		{
			get
			{
				short num = (short)1018620659;
				short num2 = num;
				num = (short)217311987;
				switch (num2 == num)
				{
				}
				num = (short)2023751681;
				if (num != 0)
				{
				}
				num = (short)1607335936;
				short num3 = num;
				num = (short)914161664;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545.Value;
			}
			set
			{
				short num = (short)1292946442;
				short num2 = num;
				num = (short)173853706;
				switch (num2 == num)
				{
				}
				num = (short)1623064577;
				if (num != 0)
				{
				}
				num = (short)2048065536;
				short num3 = num;
				num = (short)66387968;
				if (num != 0)
				{
				}
				this.radErgoWideMOSCADDataEnable_A8545.Value = value;
			}
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600606B RID: 24683 RVA: 0x0056DBBC File Offset: 0x0056BDBC
		// (set) Token: 0x0600606C RID: 24684 RVA: 0x0056DC70 File Offset: 0x0056BE70
		public bool RadErgoWideMOSCADDataEnable_A8545_Applicable
		{
			get
			{
				short num = (short)1872297985;
				if (num != 0)
				{
				}
				num = (short)1218134778;
				short num2 = num;
				num = (short)1594114810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1056112640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)917831680;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545.Applicable;
			}
			set
			{
				short num = (short)15689598;
				short num2 = num;
				num = (short)1203398526;
				switch (num2 == num)
				{
				}
				num = (short)1583677440;
				short num3 = num;
				num = (short)1820721152;
				if (num != 0)
				{
				}
				num = (short)649920513;
				if (num != 0)
				{
				}
				this.radErgoWideMOSCADDataEnable_A8545.Applicable = value;
			}
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600606D RID: 24685 RVA: 0x0056DD24 File Offset: 0x0056BF24
		// (set) Token: 0x0600606E RID: 24686 RVA: 0x0056DDD8 File Offset: 0x0056BFD8
		public bool RadErgoWideMOSCADDataEnable_A8545_Valid
		{
			get
			{
				short num = (short)833683457;
				if (num != 0)
				{
				}
				num = (short)2067479746;
				short num2 = num;
				num = (short)1084505282;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1612972032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1691156480;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545.Valid;
			}
			set
			{
				short num = (short)1095238817;
				short num2 = num;
				num = (short)1820329121;
				switch (num2 == num)
				{
				}
				num = (short)568000512;
				short num3 = num;
				num = (short)394592256;
				if (num != 0)
				{
				}
				num = (short)2094399489;
				if (num != 0)
				{
				}
				this.radErgoWideMOSCADDataEnable_A8545.Valid = value;
			}
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x0056DE8C File Offset: 0x0056C08C
		// (set) Token: 0x06006070 RID: 24688 RVA: 0x0056DF44 File Offset: 0x0056C144
		public bool RadErgoWideMOSCADDataEnable_A8545_Visible
		{
			get
			{
				short num = (short)1856968970;
				short num2 = num;
				num = (short)1344018698;
				switch (num2 == num)
				{
				}
				num = (short)1160249344;
				short num3 = num;
				num = (short)84869121;
				if (num != 0)
				{
				}
				num = (short)1647312896;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545.Visible;
			}
			set
			{
				short num = (short)1089286588;
				short num2 = num;
				num = (short)2045129148;
				switch (num2 == num)
				{
				}
				num = (short)1750007808;
				short num3 = num;
				num = (short)558235649;
				if (num != 0)
				{
				}
				num = (short)1053884416;
				if (num != 0)
				{
				}
				this.radErgoWideMOSCADDataEnable_A8545.Visible = value;
			}
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x06006071 RID: 24689 RVA: 0x0056DFFC File Offset: 0x0056C1FC
		// (set) Token: 0x06006072 RID: 24690 RVA: 0x0056E0B0 File Offset: 0x0056C2B0
		public bool RadErgoWideMOSCADDataEnable_A8545_Editable
		{
			get
			{
				short num = (short)787754456;
				short num2 = num;
				num = (short)1522937304;
				switch (num2 == num)
				{
				}
				num = (short)234684416;
				short num3 = num;
				num = (short)1269366785;
				if (num != 0)
				{
				}
				num = (short)1991245824;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545.Editable;
			}
			set
			{
				short num = (short)4856031;
				short num2 = num;
				num = (short)380901599;
				switch (num2 == num)
				{
				}
				num = (short)459407360;
				short num3 = num;
				num = (short)539557889;
				if (num != 0)
				{
				}
				num = (short)919142400;
				if (num != 0)
				{
				}
				this.radErgoWideMOSCADDataEnable_A8545.Editable = value;
			}
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x06006073 RID: 24691 RVA: 0x0056E164 File Offset: 0x0056C364
		internal string RadErgoWideMOSCADDataEnable_A8545_UILabel
		{
			get
			{
				short num = (short)832667358;
				short num2 = num;
				num = (short)1243184862;
				switch (num2 == num)
				{
				}
				num = (short)7667712;
				short num3 = num;
				num = (short)291438592;
				if (num != 0)
				{
				}
				num = (short)907804673;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545.UIName;
			}
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x06006074 RID: 24692 RVA: 0x0056E218 File Offset: 0x0056C418
		// (set) Token: 0x06006075 RID: 24693 RVA: 0x0056E2CC File Offset: 0x0056C4CC
		internal bool RadErgoWideMOSCADDataEnable_A8545_HiddenStatic
		{
			get
			{
				short num = (short)1823170352;
				short num2 = num;
				num = (short)1910267696;
				switch (num2 == num)
				{
				}
				num = (short)832962560;
				short num3 = num;
				num = (short)2095251457;
				if (num != 0)
				{
				}
				num = (short)2100363264;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545.HiddenStatic;
			}
			set
			{
				short num = (short)1670791775;
				short num2 = num;
				num = (short)1132741215;
				switch (num2 == num)
				{
				}
				num = (short)510525440;
				short num3 = num;
				num = (short)702283777;
				if (num != 0)
				{
				}
				num = (short)1603207168;
				if (num != 0)
				{
				}
				this.radErgoWideMOSCADDataEnable_A8545.HiddenStatic = value;
			}
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x06006076 RID: 24694 RVA: 0x0056E384 File Offset: 0x0056C584
		// (set) Token: 0x06006077 RID: 24695 RVA: 0x0056E438 File Offset: 0x0056C638
		internal bool RadErgoWideMOSCADDataEnable_A8545_HiddenDynamic
		{
			get
			{
				short num = (short)115237853;
				short num2 = num;
				num = (short)1673946077;
				switch (num2 == num)
				{
				}
				num = (short)597622784;
				short num3 = num;
				num = (short)857276417;
				if (num != 0)
				{
				}
				num = (short)1190920192;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545.HiddenDynamic;
			}
			set
			{
				short num = (short)1984427875;
				short num2 = num;
				num = (short)1999304547;
				switch (num2 == num)
				{
				}
				num = (short)545783808;
				short num3 = num;
				num = (short)1834876928;
				if (num != 0)
				{
				}
				num = (short)727449601;
				if (num != 0)
				{
				}
				this.radErgoWideMOSCADDataEnable_A8545.HiddenDynamic = value;
			}
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x06006078 RID: 24696 RVA: 0x0056E4EC File Offset: 0x0056C6EC
		public bool RadErgoWideMOSCADDataEnable_A8545_HasDiffs
		{
			get
			{
				short num = (short)1202258231;
				short num2 = num;
				num = (short)490406199;
				switch (num2 == num)
				{
				}
				num = (short)720109568;
				short num3 = num;
				num = (short)484900865;
				if (num != 0)
				{
				}
				num = (short)2140930048;
				if (num != 0)
				{
				}
				return this.radErgoWideMOSCADDataEnable_A8545._HasDiffs;
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x06006079 RID: 24697 RVA: 0x0056E5A0 File Offset: 0x0056C7A0
		// (set) Token: 0x0600607A RID: 24698 RVA: 0x0056E654 File Offset: 0x0056C854
		public bool RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787Value
		{
			get
			{
				short num = (short)1132585830;
				short num2 = num;
				num = (short)1901257574;
				switch (num2 == num)
				{
				}
				num = (short)1502281728;
				short num3 = num;
				num = (short)2073821185;
				if (num != 0)
				{
				}
				num = (short)1318060032;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Value;
			}
			set
			{
				short num = (short)1553199739;
				short num2 = num;
				num = (short)1420685947;
				switch (num2 == num)
				{
				}
				num = (short)2012217344;
				short num3 = num;
				num = (short)1729888257;
				if (num != 0)
				{
				}
				num = (short)692781056;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Value = value;
			}
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600607B RID: 24699 RVA: 0x0056E70C File Offset: 0x0056C90C
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787
		{
			get
			{
				short num = (short)2081730203;
				short num2 = num;
				num = (short)1090170523;
				switch (num2 == num)
				{
				}
				num = (short)411959296;
				short num3 = num;
				num = (short)1236992000;
				if (num != 0)
				{
				}
				num = (short)135135233;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787;
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600607C RID: 24700 RVA: 0x0056E7BC File Offset: 0x0056C9BC
		// (set) Token: 0x0600607D RID: 24701 RVA: 0x0056E870 File Offset: 0x0056CA70
		public bool RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_UIValue
		{
			get
			{
				short num = (short)924262453;
				short num2 = num;
				num = (short)1367089205;
				switch (num2 == num)
				{
				}
				num = (short)1383989248;
				short num3 = num;
				num = (short)1444216833;
				if (num != 0)
				{
				}
				num = (short)669843456;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Value;
			}
			set
			{
				short num = (short)890852809;
				short num2 = num;
				num = (short)605181385;
				switch (num2 == num)
				{
				}
				num = (short)793837568;
				short num3 = num;
				num = (short)883490817;
				if (num != 0)
				{
				}
				num = (short)132579328;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Value = value;
			}
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600607E RID: 24702 RVA: 0x0056E928 File Offset: 0x0056CB28
		// (set) Token: 0x0600607F RID: 24703 RVA: 0x0056E9E0 File Offset: 0x0056CBE0
		public bool RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_Applicable
		{
			get
			{
				short num = (short)1199682202;
				short num2 = num;
				num = (short)1821487770;
				switch (num2 == num)
				{
				}
				num = (short)272564224;
				short num3 = num;
				num = (short)591855616;
				if (num != 0)
				{
				}
				num = (short)1018167297;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Applicable;
			}
			set
			{
				short num = (short)1966792334;
				short num2 = num;
				num = (short)1495654030;
				switch (num2 == num)
				{
				}
				num = (short)1868038144;
				short num3 = num;
				num = (short)1686896641;
				if (num != 0)
				{
				}
				num = (short)377421824;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Applicable = value;
			}
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x06006080 RID: 24704 RVA: 0x0056EA94 File Offset: 0x0056CC94
		// (set) Token: 0x06006081 RID: 24705 RVA: 0x0056EB48 File Offset: 0x0056CD48
		public bool RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_Valid
		{
			get
			{
				short num = (short)1030072831;
				short num2 = num;
				num = (short)360753663;
				switch (num2 == num)
				{
				}
				num = (short)23396352;
				short num3 = num;
				num = (short)1869676545;
				if (num != 0)
				{
				}
				num = (short)1871511552;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Valid;
			}
			set
			{
				short num = (short)911791478;
				short num2 = num;
				num = (short)1384895862;
				switch (num2 == num)
				{
				}
				num = (short)1640562688;
				short num3 = num;
				num = (short)1404895233;
				if (num != 0)
				{
				}
				num = (short)1179648;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Valid = value;
			}
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x06006082 RID: 24706 RVA: 0x0056EBFC File Offset: 0x0056CDFC
		// (set) Token: 0x06006083 RID: 24707 RVA: 0x0056ECB4 File Offset: 0x0056CEB4
		public bool RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_Visible
		{
			get
			{
				short num = (short)1728909323;
				short num2 = num;
				num = (short)2046365707;
				switch (num2 == num)
				{
				}
				num = (short)1937899520;
				short num3 = num;
				num = (short)53673985;
				if (num != 0)
				{
				}
				num = (short)14286848;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Visible;
			}
			set
			{
				short num = (short)416965792;
				short num2 = num;
				num = (short)926901408;
				switch (num2 == num)
				{
				}
				num = (short)1489371136;
				short num3 = num;
				num = (short)467206144;
				if (num != 0)
				{
				}
				num = (short)597098497;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Visible = value;
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x06006084 RID: 24708 RVA: 0x0056ED6C File Offset: 0x0056CF6C
		// (set) Token: 0x06006085 RID: 24709 RVA: 0x0056EE1C File Offset: 0x0056D01C
		public bool RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_Editable
		{
			get
			{
				short num = (short)2125005855;
				short num2 = num;
				num = (short)1087702047;
				switch (num2 == num)
				{
				}
				num = (short)605814784;
				short num3 = num;
				num = (short)1350565888;
				if (num != 0)
				{
				}
				num = (short)1348272129;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Editable;
			}
			set
			{
				short num = (short)346907579;
				short num2 = num;
				num = (short)1854170043;
				switch (num2 == num)
				{
				}
				num = (short)2057961472;
				short num3 = num;
				num = (short)1446379520;
				if (num != 0)
				{
				}
				num = (short)320077825;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Editable = value;
			}
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x06006086 RID: 24710 RVA: 0x0056EED0 File Offset: 0x0056D0D0
		internal string RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_UILabel
		{
			get
			{
				short num = (short)1929948246;
				short num2 = num;
				num = (short)2008722518;
				switch (num2 == num)
				{
				}
				num = (short)640942080;
				short num3 = num;
				num = (short)364838913;
				if (num != 0)
				{
				}
				num = (short)1347289088;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.UIName;
			}
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x06006087 RID: 24711 RVA: 0x0056EF84 File Offset: 0x0056D184
		// (set) Token: 0x06006088 RID: 24712 RVA: 0x0056F038 File Offset: 0x0056D238
		internal bool RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_HiddenStatic
		{
			get
			{
				short num = (short)1978193105;
				short num2 = num;
				num = (short)1097389265;
				switch (num2 == num)
				{
				}
				num = (short)857997312;
				short num3 = num;
				num = (short)1101660160;
				if (num != 0)
				{
				}
				num = (short)73728001;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.HiddenStatic;
			}
			set
			{
				short num = (short)314892525;
				short num2 = num;
				num = (short)882696429;
				switch (num2 == num)
				{
				}
				num = (short)122552320;
				short num3 = num;
				num = (short)1680998400;
				if (num != 0)
				{
				}
				num = (short)1212022785;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.HiddenStatic = value;
			}
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x06006089 RID: 24713 RVA: 0x0056F0F4 File Offset: 0x0056D2F4
		// (set) Token: 0x0600608A RID: 24714 RVA: 0x0056F1AC File Offset: 0x0056D3AC
		internal bool RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_HiddenDynamic
		{
			get
			{
				short num = (short)401447182;
				short num2 = num;
				num = (short)914659598;
				switch (num2 == num)
				{
				}
				num = (short)1261240320;
				short num3 = num;
				num = (short)1282408448;
				if (num != 0)
				{
				}
				num = (short)2122842113;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.HiddenDynamic;
			}
			set
			{
				short num = (short)2092230947;
				short num2 = num;
				num = (short)443214115;
				switch (num2 == num)
				{
				}
				num = (short)765788160;
				short num3 = num;
				num = (short)475070464;
				if (num != 0)
				{
				}
				num = (short)1831337985;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.HiddenDynamic = value;
			}
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600608B RID: 24715 RVA: 0x0056F264 File Offset: 0x0056D464
		public bool RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_HasDiffs
		{
			get
			{
				short num = (short)401629939;
				short num2 = num;
				num = (short)393437939;
				switch (num2 == num)
				{
				}
				num = (short)43319296;
				short num3 = num;
				num = (short)1765933057;
				if (num != 0)
				{
				}
				num = (short)1031995392;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787._HasDiffs;
			}
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600608C RID: 24716 RVA: 0x0056F31C File Offset: 0x0056D51C
		// (set) Token: 0x0600608D RID: 24717 RVA: 0x0056F3D4 File Offset: 0x0056D5D4
		public bool RadErgoWideAdvancedRotarySwitchLockEnable_A8987Value
		{
			get
			{
				short num = (short)631812412;
				short num2 = num;
				num = (short)1100591420;
				switch (num2 == num)
				{
				}
				num = (short)1463615488;
				short num3 = num;
				num = (short)1087963137;
				if (num != 0)
				{
				}
				num = (short)1554907136;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Value;
			}
			set
			{
				short num = (short)781947731;
				short num2 = num;
				num = (short)522621779;
				switch (num2 == num)
				{
				}
				num = (short)2105344000;
				short num3 = num;
				num = (short)1053753345;
				if (num != 0)
				{
				}
				num = (short)1403518976;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Value = value;
			}
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600608E RID: 24718 RVA: 0x0056F48C File Offset: 0x0056D68C
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideAdvancedRotarySwitchLockEnable_A8987
		{
			get
			{
				short num = (short)2087013501;
				short num2 = num;
				num = (short)364203133;
				switch (num2 == num)
				{
				}
				num = (short)1711800320;
				short num3 = num;
				num = (short)1857224705;
				if (num != 0)
				{
				}
				num = (short)1112080384;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987;
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600608F RID: 24719 RVA: 0x0056F538 File Offset: 0x0056D738
		// (set) Token: 0x06006090 RID: 24720 RVA: 0x0056F5F0 File Offset: 0x0056D7F0
		public bool RadErgoWideAdvancedRotarySwitchLockEnable_A8987_UIValue
		{
			get
			{
				short num = (short)1179469640;
				short num2 = num;
				num = (short)2128955208;
				switch (num2 == num)
				{
				}
				num = (short)134152192;
				short num3 = num;
				num = (short)1543897088;
				if (num != 0)
				{
				}
				num = (short)1277689857;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Value;
			}
			set
			{
				short num = (short)783051670;
				short num2 = num;
				num = (short)390556566;
				switch (num2 == num)
				{
				}
				num = (short)1820983296;
				short num3 = num;
				num = (short)2083127296;
				if (num != 0)
				{
				}
				num = (short)940769281;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Value = value;
			}
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x06006091 RID: 24721 RVA: 0x0056F6A4 File Offset: 0x0056D8A4
		// (set) Token: 0x06006092 RID: 24722 RVA: 0x0056F758 File Offset: 0x0056D958
		public bool RadErgoWideAdvancedRotarySwitchLockEnable_A8987_Applicable
		{
			get
			{
				short num = (short)1944341959;
				short num2 = num;
				num = (short)94391751;
				switch (num2 == num)
				{
				}
				num = (short)1302331392;
				short num3 = num;
				num = (short)1398996993;
				if (num != 0)
				{
				}
				num = (short)55902208;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Applicable;
			}
			set
			{
				short num = (short)189530113;
				if (num != 0)
				{
				}
				num = (short)2078376023;
				short num2 = num;
				num = (short)1656324183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1794637824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1102708736;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Applicable = value;
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x06006093 RID: 24723 RVA: 0x0056F810 File Offset: 0x0056DA10
		// (set) Token: 0x06006094 RID: 24724 RVA: 0x0056F8C4 File Offset: 0x0056DAC4
		public bool RadErgoWideAdvancedRotarySwitchLockEnable_A8987_Valid
		{
			get
			{
				short num = (short)103743489;
				if (num != 0)
				{
				}
				num = (short)1057083372;
				short num2 = num;
				num = (short)982700012;
				switch (num2 == num)
				{
				default:
				{
					num = (short)756416512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2093875200;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Valid;
			}
			set
			{
				short num = (short)1566678562;
				short num2 = num;
				num = (short)256351778;
				switch (num2 == num)
				{
				}
				num = (short)1836843008;
				short num3 = num;
				num = (short)2128805889;
				if (num != 0)
				{
				}
				num = (short)341508096;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Valid = value;
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x06006095 RID: 24725 RVA: 0x0056F97C File Offset: 0x0056DB7C
		// (set) Token: 0x06006096 RID: 24726 RVA: 0x0056FA30 File Offset: 0x0056DC30
		public bool RadErgoWideAdvancedRotarySwitchLockEnable_A8987_Visible
		{
			get
			{
				short num = (short)1472462849;
				if (num != 0)
				{
				}
				num = (short)1985792975;
				short num2 = num;
				num = (short)1298320335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)855179264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2140012544;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Visible;
			}
			set
			{
				short num = (short)413990913;
				if (num != 0)
				{
				}
				num = (short)1137668477;
				short num2 = num;
				num = (short)277639549;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2021654528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1593507840;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Visible = value;
			}
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x06006097 RID: 24727 RVA: 0x0056FAE8 File Offset: 0x0056DCE8
		// (set) Token: 0x06006098 RID: 24728 RVA: 0x0056FBA0 File Offset: 0x0056DDA0
		public bool RadErgoWideAdvancedRotarySwitchLockEnable_A8987_Editable
		{
			get
			{
				short num = (short)120190235;
				short num2 = num;
				num = (short)1506604315;
				switch (num2 == num)
				{
				}
				num = (short)1040121856;
				short num3 = num;
				num = (short)283639808;
				if (num != 0)
				{
				}
				num = (short)1297940481;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Editable;
			}
			set
			{
				short num = (short)2045148759;
				short num2 = num;
				num = (short)1266318935;
				switch (num2 == num)
				{
				}
				num = (short)92209152;
				short num3 = num;
				num = (short)2064449537;
				if (num != 0)
				{
				}
				num = (short)763822080;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.Editable = value;
			}
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x06006099 RID: 24729 RVA: 0x0056FC54 File Offset: 0x0056DE54
		internal string RadErgoWideAdvancedRotarySwitchLockEnable_A8987_UILabel
		{
			get
			{
				short num = (short)1755877196;
				short num2 = num;
				num = (short)811372364;
				switch (num2 == num)
				{
				}
				num = (short)1109524480;
				short num3 = num;
				num = (short)93192193;
				if (num != 0)
				{
				}
				num = (short)140509184;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.UIName;
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600609A RID: 24730 RVA: 0x0056FD08 File Offset: 0x0056DF08
		// (set) Token: 0x0600609B RID: 24731 RVA: 0x0056FDBC File Offset: 0x0056DFBC
		internal bool RadErgoWideAdvancedRotarySwitchLockEnable_A8987_HiddenStatic
		{
			get
			{
				short num = (short)1585100991;
				short num2 = num;
				num = (short)1728624831;
				switch (num2 == num)
				{
				}
				num = (short)1626996736;
				short num3 = num;
				num = (short)2046099456;
				if (num != 0)
				{
				}
				num = (short)1480654849;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.HiddenStatic;
			}
			set
			{
				short num = (short)2123667439;
				short num2 = num;
				num = (short)1909233647;
				switch (num2 == num)
				{
				}
				num = (short)1936850944;
				short num3 = num;
				num = (short)889192449;
				if (num != 0)
				{
				}
				num = (short)911147008;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.HiddenStatic = value;
			}
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600609C RID: 24732 RVA: 0x0056FE74 File Offset: 0x0056E074
		// (set) Token: 0x0600609D RID: 24733 RVA: 0x0056FF28 File Offset: 0x0056E128
		internal bool RadErgoWideAdvancedRotarySwitchLockEnable_A8987_HiddenDynamic
		{
			get
			{
				short num = (short)1012256175;
				short num2 = num;
				num = (short)1687866799;
				switch (num2 == num)
				{
				}
				num = (short)810352640;
				short num3 = num;
				num = (short)176947201;
				if (num != 0)
				{
				}
				num = (short)1318256640;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.HiddenDynamic;
			}
			set
			{
				short num = (short)1646106730;
				short num2 = num;
				num = (short)1814272106;
				switch (num2 == num)
				{
				}
				num = (short)2125266944;
				short num3 = num;
				num = (short)459079681;
				if (num != 0)
				{
				}
				num = (short)1891500032;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedRotarySwitchLockEnable_A8987.HiddenDynamic = value;
			}
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600609E RID: 24734 RVA: 0x0056FFE0 File Offset: 0x0056E1E0
		public bool RadErgoWideAdvancedRotarySwitchLockEnable_A8987_HasDiffs
		{
			get
			{
				short num = (short)812885956;
				short num2 = num;
				num = (short)602646468;
				switch (num2 == num)
				{
				}
				num = (short)1109393408;
				short num3 = num;
				num = (short)948699136;
				if (num != 0)
				{
				}
				num = (short)1980760065;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedRotarySwitchLockEnable_A8987._HasDiffs;
			}
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600609F RID: 24735 RVA: 0x00570094 File Offset: 0x0056E294
		// (set) Token: 0x060060A0 RID: 24736 RVA: 0x00570148 File Offset: 0x0056E348
		public int RadErgoWideAdvancedSoftPowerOff_A9170Value
		{
			get
			{
				short num = (short)1277699126;
				short num2 = num;
				num = (short)1735337014;
				switch (num2 == num)
				{
				}
				num = (short)781647872;
				short num3 = num;
				num = (short)802553857;
				if (num != 0)
				{
				}
				num = (short)965607424;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170.Value;
			}
			set
			{
				short num = (short)695285849;
				short num2 = num;
				num = (short)792016985;
				switch (num2 == num)
				{
				}
				num = (short)616628225;
				if (num != 0)
				{
				}
				num = (short)947847168;
				short num3 = num;
				num = (short)2083586048;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSoftPowerOff_A9170.Value = value;
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x060060A1 RID: 24737 RVA: 0x00570204 File Offset: 0x0056E404
		// (set) Token: 0x060060A2 RID: 24738 RVA: 0x005702B8 File Offset: 0x0056E4B8
		public string RadErgoWideAdvancedSoftPowerOff_A9170_UIValue
		{
			get
			{
				short num = (short)487648636;
				short num2 = num;
				num = (short)1274735996;
				switch (num2 == num)
				{
				}
				num = (short)1825570816;
				if (num != 0)
				{
				}
				num = (short)1193869312;
				short num3 = num;
				num = (short)1635254273;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170.UIValue;
			}
			set
			{
				short num = (short)617322747;
				short num2 = num;
				num = (short)485202171;
				switch (num2 == num)
				{
				}
				num = (short)1378353153;
				if (num != 0)
				{
				}
				num = (short)854851584;
				short num3 = num;
				num = (short)1769865216;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSoftPowerOff_A9170.UIValue = value;
			}
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x060060A3 RID: 24739 RVA: 0x0057036C File Offset: 0x0056E56C
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedSoftPowerOff_A9170
		{
			get
			{
				short num = (short)773231112;
				short num2 = num;
				num = (short)690197000;
				switch (num2 == num)
				{
				}
				num = (short)998440961;
				if (num != 0)
				{
				}
				num = (short)738656256;
				short num3 = num;
				num = (short)540737536;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170;
			}
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x060060A4 RID: 24740 RVA: 0x0057041C File Offset: 0x0056E61C
		// (set) Token: 0x060060A5 RID: 24741 RVA: 0x005704D4 File Offset: 0x0056E6D4
		public bool RadErgoWideAdvancedSoftPowerOff_A9170_Applicable
		{
			get
			{
				short num = (short)1902652599;
				short num2 = num;
				num = (short)1720069303;
				switch (num2 == num)
				{
				}
				num = (short)516423681;
				if (num != 0)
				{
				}
				num = (short)614268928;
				short num3 = num;
				num = (short)1262944256;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170.Applicable;
			}
			set
			{
				short num = (short)667353089;
				if (num != 0)
				{
				}
				num = (short)870227968;
				short num2 = num;
				num = (short)895787008;
				switch (num2 == num)
				{
				}
				num = (short)805240832;
				short num3 = num;
				num = (short)531431424;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSoftPowerOff_A9170.Applicable = value;
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x060060A6 RID: 24742 RVA: 0x00570588 File Offset: 0x0056E788
		// (set) Token: 0x060060A7 RID: 24743 RVA: 0x00570638 File Offset: 0x0056E838
		public bool RadErgoWideAdvancedSoftPowerOff_A9170_Valid
		{
			get
			{
				short num = (short)1640240362;
				short num2 = num;
				num = (short)1894782186;
				switch (num2 == num)
				{
				}
				num = (short)1018626048;
				if (num != 0)
				{
				}
				num = (short)1621164032;
				short num3 = num;
				num = (short)1085800449;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170.Valid;
			}
			set
			{
				short num = (short)1360383488;
				short num2 = num;
				num = (short)969657856;
				switch (num2 == num)
				{
				}
				num = (short)514260993;
				if (num != 0)
				{
				}
				num = (short)2108227584;
				short num3 = num;
				num = (short)859176960;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSoftPowerOff_A9170.Valid = value;
			}
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x060060A8 RID: 24744 RVA: 0x005706EC File Offset: 0x0056E8EC
		// (set) Token: 0x060060A9 RID: 24745 RVA: 0x005707A0 File Offset: 0x0056E9A0
		public bool RadErgoWideAdvancedSoftPowerOff_A9170_Visible
		{
			get
			{
				short num = (short)2112258433;
				short num2 = num;
				num = (short)1159889281;
				switch (num2 == num)
				{
				}
				num = (short)975634433;
				if (num != 0)
				{
				}
				num = (short)2048786432;
				short num3 = num;
				num = (short)615055360;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170.Visible;
			}
			set
			{
				short num = (short)1158759437;
				short num2 = num;
				num = (short)200557581;
				switch (num2 == num)
				{
				}
				num = (short)567083009;
				if (num != 0)
				{
				}
				num = (short)878051328;
				short num3 = num;
				num = (short)1775763456;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSoftPowerOff_A9170.Visible = value;
			}
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x060060AA RID: 24746 RVA: 0x00570854 File Offset: 0x0056EA54
		// (set) Token: 0x060060AB RID: 24747 RVA: 0x0057090C File Offset: 0x0056EB0C
		public bool RadErgoWideAdvancedSoftPowerOff_A9170_Editable
		{
			get
			{
				short num = (short)1324326385;
				short num2 = num;
				num = (short)722968049;
				switch (num2 == num)
				{
				}
				num = (short)870907905;
				if (num != 0)
				{
				}
				num = (short)2105737216;
				short num3 = num;
				num = (short)1344077824;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170.Editable;
			}
			set
			{
				short num = (short)865256993;
				short num2 = num;
				num = (short)955434529;
				switch (num2 == num)
				{
				}
				num = (short)1162739713;
				if (num != 0)
				{
				}
				num = (short)63832064;
				short num3 = num;
				num = (short)725745664;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSoftPowerOff_A9170.Editable = value;
			}
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x060060AC RID: 24748 RVA: 0x005709C4 File Offset: 0x0056EBC4
		internal string RadErgoWideAdvancedSoftPowerOff_A9170_UILabel
		{
			get
			{
				short num = (short)542136636;
				short num2 = num;
				num = (short)1488542012;
				switch (num2 == num)
				{
				}
				num = (short)1706295297;
				if (num != 0)
				{
				}
				num = (short)1010827264;
				short num3 = num;
				num = (short)26869760;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170.UIName;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x060060AD RID: 24749 RVA: 0x00570A7C File Offset: 0x0056EC7C
		// (set) Token: 0x060060AE RID: 24750 RVA: 0x00570B30 File Offset: 0x0056ED30
		internal bool RadErgoWideAdvancedSoftPowerOff_A9170_HiddenStatic
		{
			get
			{
				short num = (short)351797481;
				short num2 = num;
				num = (short)222691561;
				switch (num2 == num)
				{
				}
				num = (short)1487273985;
				if (num != 0)
				{
				}
				num = (short)1850081280;
				short num3 = num;
				num = (short)1410793472;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170.HiddenStatic;
			}
			set
			{
				short num = (short)268125734;
				short num2 = num;
				num = (short)1037714982;
				switch (num2 == num)
				{
				}
				num = (short)1711865857;
				if (num != 0)
				{
				}
				num = (short)1133051904;
				short num3 = num;
				num = (short)1991507968;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSoftPowerOff_A9170.HiddenStatic = value;
			}
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x060060AF RID: 24751 RVA: 0x00570BE4 File Offset: 0x0056EDE4
		// (set) Token: 0x060060B0 RID: 24752 RVA: 0x00570C98 File Offset: 0x0056EE98
		internal bool RadErgoWideAdvancedSoftPowerOff_A9170_HiddenDynamic
		{
			get
			{
				short num = (short)1084911076;
				short num2 = num;
				num = (short)1311731172;
				switch (num2 == num)
				{
				}
				num = (short)920387584;
				if (num != 0)
				{
				}
				num = (short)1742471168;
				short num3 = num;
				num = (short)414777345;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170.HiddenDynamic;
			}
			set
			{
				short num = (short)1840879336;
				short num2 = num;
				num = (short)1448908520;
				switch (num2 == num)
				{
				}
				num = (short)1838481408;
				if (num != 0)
				{
				}
				num = (short)1917779968;
				short num3 = num;
				num = (short)115212289;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSoftPowerOff_A9170.HiddenDynamic = value;
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x060060B1 RID: 24753 RVA: 0x00570D4C File Offset: 0x0056EF4C
		public bool RadErgoWideAdvancedSoftPowerOff_A9170_HasDiffs
		{
			get
			{
				short num = (short)596028210;
				short num2 = num;
				num = (short)1836755762;
				switch (num2 == num)
				{
				}
				num = (short)877854721;
				if (num != 0)
				{
				}
				num = (short)498401280;
				short num3 = num;
				num = (short)1615134720;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSoftPowerOff_A9170._HasDiffs;
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x060060B2 RID: 24754 RVA: 0x00570E04 File Offset: 0x0056F004
		// (set) Token: 0x060060B3 RID: 24755 RVA: 0x00570EB8 File Offset: 0x0056F0B8
		public int RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244Value
		{
			get
			{
				short num = (short)1769685765;
				short num2 = num;
				num = (short)189285125;
				switch (num2 == num)
				{
				}
				num = (short)1977679872;
				if (num != 0)
				{
				}
				num = (short)1522860032;
				short num3 = num;
				num = (short)754319361;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.Value;
			}
			set
			{
				short num = (short)1815204461;
				short num2 = num;
				num = (short)1847906925;
				switch (num2 == num)
				{
				}
				num = (short)909180929;
				if (num != 0)
				{
				}
				num = (short)995033088;
				short num3 = num;
				num = (short)1283063808;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.Value = value;
			}
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x060060B4 RID: 24756 RVA: 0x00570F6C File Offset: 0x0056F16C
		// (set) Token: 0x060060B5 RID: 24757 RVA: 0x00571020 File Offset: 0x0056F220
		public string RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244_UIValue
		{
			get
			{
				short num = (short)1704711538;
				short num2 = num;
				num = (short)107074930;
				switch (num2 == num)
				{
				}
				num = (short)450363393;
				if (num != 0)
				{
				}
				num = (short)987561984;
				short num3 = num;
				num = (short)1336213504;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.UIValue;
			}
			set
			{
				short num = (short)172483246;
				short num2 = num;
				num = (short)636674734;
				switch (num2 == num)
				{
				}
				num = (short)769589248;
				if (num != 0)
				{
				}
				num = (short)1707540480;
				short num3 = num;
				num = (short)952107009;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.UIValue = value;
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x060060B6 RID: 24758 RVA: 0x005710D8 File Offset: 0x0056F2D8
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244
		{
			get
			{
				short num = (short)92160108;
				short num2 = num;
				num = (short)198459500;
				switch (num2 == num)
				{
				}
				num = (short)1919156224;
				if (num != 0)
				{
				}
				num = (short)272236544;
				short num3 = num;
				num = (short)1430650881;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244;
			}
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x060060B7 RID: 24759 RVA: 0x00571188 File Offset: 0x0056F388
		// (set) Token: 0x060060B8 RID: 24760 RVA: 0x0057123C File Offset: 0x0056F43C
		public bool RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244_Applicable
		{
			get
			{
				short num = (short)1997856303;
				short num2 = num;
				num = (short)681500207;
				switch (num2 == num)
				{
				}
				num = (short)569442305;
				if (num != 0)
				{
				}
				num = (short)105709568;
				short num3 = num;
				num = (short)878444544;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.Applicable;
			}
			set
			{
				short num = (short)813851641;
				short num2 = num;
				num = (short)1900831737;
				switch (num2 == num)
				{
				}
				num = (short)1862008833;
				if (num != 0)
				{
				}
				num = (short)1634795520;
				short num3 = num;
				num = (short)1671561216;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.Applicable = value;
			}
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x060060B9 RID: 24761 RVA: 0x005712F4 File Offset: 0x0056F4F4
		// (set) Token: 0x060060BA RID: 24762 RVA: 0x005713A8 File Offset: 0x0056F5A8
		public bool RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244_Valid
		{
			get
			{
				short num = (short)955194095;
				short num2 = num;
				num = (short)1601575663;
				switch (num2 == num)
				{
				}
				num = (short)246480897;
				if (num != 0)
				{
				}
				num = (short)132513792;
				short num3 = num;
				num = (short)543490048;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.Valid;
			}
			set
			{
				short num = (short)381806152;
				short num2 = num;
				num = (short)624092744;
				switch (num2 == num)
				{
				}
				num = (short)1761542144;
				if (num != 0)
				{
				}
				num = (short)1118896128;
				short num3 = num;
				num = (short)155189249;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.Valid = value;
			}
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x060060BB RID: 24763 RVA: 0x0057145C File Offset: 0x0056F65C
		// (set) Token: 0x060060BC RID: 24764 RVA: 0x00571510 File Offset: 0x0056F710
		public bool RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244_Visible
		{
			get
			{
				short num = (short)1056470227;
				short num2 = num;
				num = (short)36402387;
				switch (num2 == num)
				{
				}
				num = (short)133103617;
				if (num != 0)
				{
				}
				num = (short)1095827456;
				short num3 = num;
				num = (short)1954283520;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.Visible;
			}
			set
			{
				short num = (short)589365249;
				if (num != 0)
				{
				}
				num = (short)424258299;
				short num2 = num;
				num = (short)704424699;
				switch (num2 == num)
				{
				}
				num = (short)1604255744;
				short num3 = num;
				num = (short)1714683904;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.Visible = value;
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x060060BD RID: 24765 RVA: 0x005715C4 File Offset: 0x0056F7C4
		// (set) Token: 0x060060BE RID: 24766 RVA: 0x00571678 File Offset: 0x0056F878
		public bool RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244_Editable
		{
			get
			{
				short num = (short)268440679;
				short num2 = num;
				num = (short)857740391;
				switch (num2 == num)
				{
				}
				num = (short)166658048;
				if (num != 0)
				{
				}
				num = (short)1615396864;
				short num3 = num;
				num = (short)255131649;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.Editable;
			}
			set
			{
				short num = (short)410191650;
				short num2 = num;
				num = (short)1236010786;
				switch (num2 == num)
				{
				}
				num = (short)1380777985;
				if (num != 0)
				{
				}
				num = (short)1350107136;
				short num3 = num;
				num = (short)1264123904;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.Editable = value;
			}
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x060060BF RID: 24767 RVA: 0x0057172C File Offset: 0x0056F92C
		internal string RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244_UILabel
		{
			get
			{
				short num = (short)1884702850;
				short num2 = num;
				num = (short)165890178;
				switch (num2 == num)
				{
				}
				num = (short)1344798721;
				if (num != 0)
				{
				}
				num = (short)974389248;
				short num3 = num;
				num = (short)1126170624;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.UIName;
			}
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x060060C0 RID: 24768 RVA: 0x005717E0 File Offset: 0x0056F9E0
		// (set) Token: 0x060060C1 RID: 24769 RVA: 0x00571898 File Offset: 0x0056FA98
		internal bool RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244_HiddenStatic
		{
			get
			{
				short num = (short)940241225;
				short num2 = num;
				num = (short)2126836041;
				switch (num2 == num)
				{
				}
				num = (short)519241728;
				if (num != 0)
				{
				}
				num = (short)224788480;
				short num3 = num;
				num = (short)1608646657;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.HiddenStatic;
			}
			set
			{
				short num = (short)1557775596;
				short num2 = num;
				num = (short)213304556;
				switch (num2 == num)
				{
				}
				num = (short)1070465025;
				if (num != 0)
				{
				}
				num = (short)1945174016;
				short num3 = num;
				num = (short)1686962176;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.HiddenStatic = value;
			}
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x060060C2 RID: 24770 RVA: 0x00571950 File Offset: 0x0056FB50
		// (set) Token: 0x060060C3 RID: 24771 RVA: 0x00571A04 File Offset: 0x0056FC04
		internal bool RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244_HiddenDynamic
		{
			get
			{
				short num = (short)1366698650;
				short num2 = num;
				num = (short)2076519066;
				switch (num2 == num)
				{
				}
				num = (short)1489502209;
				if (num != 0)
				{
				}
				num = (short)1329659904;
				short num3 = num;
				num = (short)565248000;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.HiddenDynamic;
			}
			set
			{
				short num = (short)19776448;
				short num2 = num;
				num = (short)1837220800;
				switch (num2 == num)
				{
				}
				num = (short)1860763649;
				if (num != 0)
				{
				}
				num = (short)958988288;
				short num3 = num;
				num = (short)699924480;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244.HiddenDynamic = value;
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x060060C4 RID: 24772 RVA: 0x00571AB8 File Offset: 0x0056FCB8
		public bool RadErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244_HasDiffs
		{
			get
			{
				short num = (short)1043003991;
				short num2 = num;
				num = (short)212597335;
				switch (num2 == num)
				{
				}
				num = (short)324009984;
				if (num != 0)
				{
				}
				num = (short)1343684608;
				short num3 = num;
				num = (short)767361025;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244._HasDiffs;
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x060060C5 RID: 24773 RVA: 0x00571B6C File Offset: 0x0056FD6C
		// (set) Token: 0x060060C6 RID: 24774 RVA: 0x00571C20 File Offset: 0x0056FE20
		public int RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245Value
		{
			get
			{
				short num = (short)1826470517;
				short num2 = num;
				num = (short)2091301493;
				switch (num2 == num)
				{
				}
				num = (short)1387855872;
				if (num != 0)
				{
				}
				num = (short)1293025280;
				short num3 = num;
				num = (short)1266155521;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.Value;
			}
			set
			{
				short num = (short)1266621073;
				short num2 = num;
				num = (short)883497617;
				switch (num2 == num)
				{
				}
				num = (short)1349648385;
				if (num != 0)
				{
				}
				num = (short)611188736;
				short num3 = num;
				num = (short)1375076352;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.Value = value;
			}
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x060060C7 RID: 24775 RVA: 0x00571CD4 File Offset: 0x0056FED4
		// (set) Token: 0x060060C8 RID: 24776 RVA: 0x00571D8C File Offset: 0x0056FF8C
		public string RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245_UIValue
		{
			get
			{
				short num = (short)1761594261;
				short num2 = num;
				num = (short)903728021;
				switch (num2 == num)
				{
				}
				num = (short)678625280;
				if (num != 0)
				{
				}
				num = (short)1779761152;
				short num3 = num;
				num = (short)830144513;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.UIValue;
			}
			set
			{
				short num = (short)1887647964;
				short num2 = num;
				num = (short)365181148;
				switch (num2 == num)
				{
				}
				num = (short)1427243008;
				if (num != 0)
				{
				}
				num = (short)1023410176;
				short num3 = num;
				num = (short)855113729;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.UIValue = value;
			}
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x060060C9 RID: 24777 RVA: 0x00571E40 File Offset: 0x00570040
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245
		{
			get
			{
				short num = (short)1549513302;
				short num2 = num;
				num = (short)1593094742;
				switch (num2 == num)
				{
				}
				num = (short)526581761;
				if (num != 0)
				{
				}
				num = (short)317849600;
				short num3 = num;
				num = (short)674955264;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245;
			}
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x060060CA RID: 24778 RVA: 0x00571EEC File Offset: 0x005700EC
		// (set) Token: 0x060060CB RID: 24779 RVA: 0x00571FA0 File Offset: 0x005701A0
		public bool RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245_Applicable
		{
			get
			{
				short num = (short)1442008682;
				short num2 = num;
				num = (short)950161002;
				switch (num2 == num)
				{
				}
				num = (short)1859846144;
				if (num != 0)
				{
				}
				num = (short)1360592896;
				short num3 = num;
				num = (short)409403393;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.Applicable;
			}
			set
			{
				short num = (short)1153718804;
				short num2 = num;
				num = (short)159865364;
				switch (num2 == num)
				{
				}
				num = (short)1171390464;
				if (num != 0)
				{
				}
				num = (short)119734272;
				short num3 = num;
				num = (short)1920073729;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.Applicable = value;
			}
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x060060CC RID: 24780 RVA: 0x00572058 File Offset: 0x00570258
		// (set) Token: 0x060060CD RID: 24781 RVA: 0x0057210C File Offset: 0x0057030C
		public bool RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245_Valid
		{
			get
			{
				short num = (short)2135567837;
				short num2 = num;
				num = (short)94645725;
				switch (num2 == num)
				{
				}
				num = (short)1252786176;
				if (num != 0)
				{
				}
				num = (short)1926823936;
				short num3 = num;
				num = (short)332791809;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.Valid;
			}
			set
			{
				short num = (short)107850587;
				short num2 = num;
				num = (short)589146971;
				switch (num2 == num)
				{
				}
				num = (short)591790081;
				if (num != 0)
				{
				}
				num = (short)343605248;
				short num3 = num;
				num = (short)1671495680;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.Valid = value;
			}
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x060060CE RID: 24782 RVA: 0x005721C0 File Offset: 0x005703C0
		// (set) Token: 0x060060CF RID: 24783 RVA: 0x00572274 File Offset: 0x00570474
		public bool RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245_Visible
		{
			get
			{
				short num = (short)348888031;
				short num2 = num;
				num = (short)2126748639;
				switch (num2 == num)
				{
				}
				num = (short)554172417;
				if (num != 0)
				{
				}
				num = (short)1025572864;
				short num3 = num;
				num = (short)1132265472;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.Visible;
			}
			set
			{
				short num = (short)1162116461;
				short num2 = num;
				num = (short)208305517;
				switch (num2 == num)
				{
				}
				num = (short)473628672;
				if (num != 0)
				{
				}
				num = (short)591069184;
				short num3 = num;
				num = (short)2031157249;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.Visible = value;
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x060060D0 RID: 24784 RVA: 0x00572328 File Offset: 0x00570528
		// (set) Token: 0x060060D1 RID: 24785 RVA: 0x005723DC File Offset: 0x005705DC
		public bool RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245_Editable
		{
			get
			{
				short num = (short)464079141;
				short num2 = num;
				num = (short)851003685;
				switch (num2 == num)
				{
				}
				num = (short)416808961;
				if (num != 0)
				{
				}
				num = (short)304545792;
				short num3 = num;
				num = (short)1130102784;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.Editable;
			}
			set
			{
				short num = (short)1929707521;
				if (num != 0)
				{
				}
				num = (short)533940955;
				short num2 = num;
				num = (short)1160596187;
				switch (num2 == num)
				{
				}
				num = (short)1818361856;
				short num3 = num;
				num = (short)1866268672;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.Editable = value;
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x060060D2 RID: 24786 RVA: 0x00572494 File Offset: 0x00570694
		internal string RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245_UILabel
		{
			get
			{
				short num = (short)1224212743;
				short num2 = num;
				num = (short)309461255;
				switch (num2 == num)
				{
				}
				num = (short)1955201024;
				short num3 = num;
				num = (short)584253441;
				if (num != 0)
				{
				}
				num = (short)790429696;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.UIName;
			}
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x060060D3 RID: 24787 RVA: 0x00572548 File Offset: 0x00570748
		// (set) Token: 0x060060D4 RID: 24788 RVA: 0x005725FC File Offset: 0x005707FC
		internal bool RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245_HiddenStatic
		{
			get
			{
				short num = (short)966402684;
				short num2 = num;
				num = (short)1549476476;
				switch (num2 == num)
				{
				}
				num = (short)1450639360;
				short num3 = num;
				num = (short)431489025;
				if (num != 0)
				{
				}
				num = (short)2057568256;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.HiddenStatic;
			}
			set
			{
				short num = (short)735139173;
				short num2 = num;
				num = (short)2065847653;
				switch (num2 == num)
				{
				}
				num = (short)1854472192;
				short num3 = num;
				num = (short)1803616257;
				if (num != 0)
				{
				}
				num = (short)1105002496;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.HiddenStatic = value;
			}
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x060060D5 RID: 24789 RVA: 0x005726B0 File Offset: 0x005708B0
		// (set) Token: 0x060060D6 RID: 24790 RVA: 0x00572760 File Offset: 0x00570960
		internal bool RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245_HiddenDynamic
		{
			get
			{
				short num = (short)1159910743;
				short num2 = num;
				num = (short)1761138007;
				switch (num2 == num)
				{
				}
				num = (short)1308164096;
				short num3 = num;
				num = (short)256442369;
				if (num != 0)
				{
				}
				num = (short)681246720;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.HiddenDynamic;
			}
			set
			{
				short num = (short)1595559620;
				short num2 = num;
				num = (short)430657220;
				switch (num2 == num)
				{
				}
				num = (short)264437760;
				short num3 = num;
				num = (short)2023817217;
				if (num != 0)
				{
				}
				num = (short)1178075136;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245.HiddenDynamic = value;
			}
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x060060D7 RID: 24791 RVA: 0x00572814 File Offset: 0x00570A14
		public bool RadErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245_HasDiffs
		{
			get
			{
				short num = (short)1397839274;
				short num2 = num;
				num = (short)695752106;
				switch (num2 == num)
				{
				}
				num = (short)300417024;
				short num3 = num;
				num = (short)1550254081;
				if (num != 0)
				{
				}
				num = (short)1770586112;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245._HasDiffs;
			}
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x060060D8 RID: 24792 RVA: 0x005728C8 File Offset: 0x00570AC8
		// (set) Token: 0x060060D9 RID: 24793 RVA: 0x00572980 File Offset: 0x00570B80
		public bool RadioErgoCfgExternalAccessoryEnable_A36198Value
		{
			get
			{
				short num = (short)1559298049;
				if (num != 0)
				{
				}
				num = (short)942779663;
				short num2 = num;
				num = (short)1315679503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1540292608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)698548224;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198.Value;
			}
			set
			{
				short num = (short)1200077515;
				short num2 = num;
				num = (short)176732875;
				switch (num2 == num)
				{
				}
				num = (short)2082471936;
				short num3 = num;
				num = (short)981270528;
				if (num != 0)
				{
				}
				num = (short)1833304065;
				if (num != 0)
				{
				}
				this.radioErgoCfgExternalAccessoryEnable_A36198.Value = value;
			}
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x060060DA RID: 24794 RVA: 0x00572A38 File Offset: 0x00570C38
		public global::AcpBusinessLayer.AcpField<bool> RadioErgoCfgExternalAccessoryEnable_A36198
		{
			get
			{
				short num = (short)1714302479;
				short num2 = num;
				num = (short)1795763727;
				switch (num2 == num)
				{
				}
				num = (short)1008664576;
				short num3 = num;
				num = (short)1691090945;
				if (num != 0)
				{
				}
				num = (short)326238208;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198;
			}
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x060060DB RID: 24795 RVA: 0x00572AE8 File Offset: 0x00570CE8
		// (set) Token: 0x060060DC RID: 24796 RVA: 0x00572B9C File Offset: 0x00570D9C
		public bool RadioErgoCfgExternalAccessoryEnable_A36198_UIValue
		{
			get
			{
				short num = (short)204018119;
				short num2 = num;
				num = (short)263328199;
				switch (num2 == num)
				{
				}
				num = (short)438894592;
				short num3 = num;
				num = (short)1913192448;
				if (num != 0)
				{
				}
				num = (short)26083329;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198.Value;
			}
			set
			{
				short num = (short)1575860664;
				short num2 = num;
				num = (short)21543352;
				switch (num2 == num)
				{
				}
				num = (short)1683554304;
				short num3 = num;
				num = (short)808976385;
				if (num != 0)
				{
				}
				num = (short)1635188736;
				if (num != 0)
				{
				}
				this.radioErgoCfgExternalAccessoryEnable_A36198.Value = value;
			}
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x060060DD RID: 24797 RVA: 0x00572C54 File Offset: 0x00570E54
		// (set) Token: 0x060060DE RID: 24798 RVA: 0x00572D04 File Offset: 0x00570F04
		public bool RadioErgoCfgExternalAccessoryEnable_A36198_Applicable
		{
			get
			{
				short num = (short)1259405313;
				if (num != 0)
				{
				}
				num = (short)1568972823;
				short num2 = num;
				num = (short)1104846871;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1799684096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1893859328;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198.Applicable;
			}
			set
			{
				short num = (short)1027023621;
				short num2 = num;
				num = (short)125117189;
				switch (num2 == num)
				{
				}
				num = (short)1628897280;
				short num3 = num;
				num = (short)1475149825;
				if (num != 0)
				{
				}
				num = (short)361168896;
				if (num != 0)
				{
				}
				this.radioErgoCfgExternalAccessoryEnable_A36198.Applicable = value;
			}
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x060060DF RID: 24799 RVA: 0x00572DB8 File Offset: 0x00570FB8
		// (set) Token: 0x060060E0 RID: 24800 RVA: 0x00572E70 File Offset: 0x00571070
		public bool RadioErgoCfgExternalAccessoryEnable_A36198_Valid
		{
			get
			{
				short num = (short)2113432858;
				short num2 = num;
				num = (short)1759800602;
				switch (num2 == num)
				{
				}
				num = (short)2060320768;
				short num3 = num;
				num = (short)1667497985;
				if (num != 0)
				{
				}
				num = (short)338034688;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198.Valid;
			}
			set
			{
				short num = (short)1682636801;
				if (num != 0)
				{
				}
				num = (short)970800363;
				short num2 = num;
				num = (short)770391275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1706557440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931870208;
				if (num != 0)
				{
				}
				this.radioErgoCfgExternalAccessoryEnable_A36198.Valid = value;
			}
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x060060E1 RID: 24801 RVA: 0x00572F24 File Offset: 0x00571124
		// (set) Token: 0x060060E2 RID: 24802 RVA: 0x00572FD8 File Offset: 0x005711D8
		public bool RadioErgoCfgExternalAccessoryEnable_A36198_Visible
		{
			get
			{
				short num = (short)1371231598;
				short num2 = num;
				num = (short)1628984686;
				switch (num2 == num)
				{
				}
				num = (short)2019426304;
				short num3 = num;
				num = (short)2048262144;
				if (num != 0)
				{
				}
				num = (short)1135804417;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198.Visible;
			}
			set
			{
				short num = (short)1312085208;
				short num2 = num;
				num = (short)1897714904;
				switch (num2 == num)
				{
				}
				num = (short)1235025920;
				short num3 = num;
				num = (short)132710400;
				if (num != 0)
				{
				}
				num = (short)2141847553;
				if (num != 0)
				{
				}
				this.radioErgoCfgExternalAccessoryEnable_A36198.Visible = value;
			}
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x060060E3 RID: 24803 RVA: 0x00573090 File Offset: 0x00571290
		// (set) Token: 0x060060E4 RID: 24804 RVA: 0x00573144 File Offset: 0x00571344
		public bool RadioErgoCfgExternalAccessoryEnable_A36198_Editable
		{
			get
			{
				short num = (short)710710351;
				short num2 = num;
				num = (short)1269273679;
				switch (num2 == num)
				{
				}
				num = (short)1739980800;
				short num3 = num;
				num = (short)1131610113;
				if (num != 0)
				{
				}
				num = (short)1463353344;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198.Editable;
			}
			set
			{
				short num = (short)8967759;
				short num2 = num;
				num = (short)357684815;
				switch (num2 == num)
				{
				}
				num = (short)430637056;
				short num3 = num;
				num = (short)144572417;
				if (num != 0)
				{
				}
				num = (short)436011008;
				if (num != 0)
				{
				}
				this.radioErgoCfgExternalAccessoryEnable_A36198.Editable = value;
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x060060E5 RID: 24805 RVA: 0x005731FC File Offset: 0x005713FC
		internal string RadioErgoCfgExternalAccessoryEnable_A36198_UILabel
		{
			get
			{
				short num = (short)75989606;
				short num2 = num;
				num = (short)1442808422;
				switch (num2 == num)
				{
				}
				num = (short)710148096;
				short num3 = num;
				num = (short)1448280065;
				if (num != 0)
				{
				}
				num = (short)1112670208;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198.UIName;
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x060060E6 RID: 24806 RVA: 0x005732B0 File Offset: 0x005714B0
		// (set) Token: 0x060060E7 RID: 24807 RVA: 0x00573368 File Offset: 0x00571568
		internal bool RadioErgoCfgExternalAccessoryEnable_A36198_HiddenStatic
		{
			get
			{
				short num = (short)1853322124;
				short num2 = num;
				num = (short)1786147724;
				switch (num2 == num)
				{
				}
				num = (short)1093533696;
				short num3 = num;
				num = (short)1598029824;
				if (num != 0)
				{
				}
				num = (short)2063794177;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198.HiddenStatic;
			}
			set
			{
				short num = (short)381091841;
				if (num != 0)
				{
				}
				num = (short)645586034;
				short num2 = num;
				num = (short)1817959538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1017774080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1385627648;
				if (num != 0)
				{
				}
				this.radioErgoCfgExternalAccessoryEnable_A36198.HiddenStatic = value;
			}
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x060060E8 RID: 24808 RVA: 0x0057341C File Offset: 0x0057161C
		// (set) Token: 0x060060E9 RID: 24809 RVA: 0x005734D0 File Offset: 0x005716D0
		internal bool RadioErgoCfgExternalAccessoryEnable_A36198_HiddenDynamic
		{
			get
			{
				short num = (short)184062113;
				short num2 = num;
				num = (short)495489185;
				switch (num2 == num)
				{
				}
				num = (short)458031104;
				short num3 = num;
				num = (short)941948929;
				if (num != 0)
				{
				}
				num = (short)1188757504;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198.HiddenDynamic;
			}
			set
			{
				short num = (short)1395392513;
				if (num != 0)
				{
				}
				num = (short)612398959;
				short num2 = num;
				num = (short)1699444591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1160708096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1747451904;
				if (num != 0)
				{
				}
				this.radioErgoCfgExternalAccessoryEnable_A36198.HiddenDynamic = value;
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x060060EA RID: 24810 RVA: 0x00573588 File Offset: 0x00571788
		public bool RadioErgoCfgExternalAccessoryEnable_A36198_HasDiffs
		{
			get
			{
				short num = (short)335845776;
				short num2 = num;
				num = (short)801741200;
				switch (num2 == num)
				{
				}
				num = (short)1443364864;
				short num3 = num;
				num = (short)1252524032;
				if (num != 0)
				{
				}
				num = (short)1392050177;
				if (num != 0)
				{
				}
				return this.radioErgoCfgExternalAccessoryEnable_A36198._HasDiffs;
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x060060EB RID: 24811 RVA: 0x0057363C File Offset: 0x0057183C
		// (set) Token: 0x060060EC RID: 24812 RVA: 0x005736F0 File Offset: 0x005718F0
		public bool RadioErgoCfgFatalError_A36202Value
		{
			get
			{
				short num = (short)2142044161;
				if (num != 0)
				{
				}
				num = (short)338371356;
				short num2 = num;
				num = (short)992224028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1907884032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1428881408;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202.Value;
			}
			set
			{
				short num = (short)933794883;
				short num2 = num;
				num = (short)1953862723;
				switch (num2 == num)
				{
				}
				num = (short)651558912;
				short num3 = num;
				num = (short)905379841;
				if (num != 0)
				{
				}
				num = (short)1255276544;
				if (num != 0)
				{
				}
				this.radioErgoCfgFatalError_A36202.Value = value;
			}
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x060060ED RID: 24813 RVA: 0x005737A4 File Offset: 0x005719A4
		public global::AcpBusinessLayer.AcpField<bool> RadioErgoCfgFatalError_A36202
		{
			get
			{
				short num = (short)106233857;
				if (num != 0)
				{
				}
				num = (short)503178839;
				short num2 = num;
				num = (short)1826416215;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1329201152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1410859008;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202;
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x060060EE RID: 24814 RVA: 0x00573854 File Offset: 0x00571A54
		// (set) Token: 0x060060EF RID: 24815 RVA: 0x0057390C File Offset: 0x00571B0C
		public bool RadioErgoCfgFatalError_A36202_UIValue
		{
			get
			{
				short num = (short)1671802962;
				short num2 = num;
				num = (short)1953607762;
				switch (num2 == num)
				{
				}
				num = (short)1885274112;
				short num3 = num;
				num = (short)1981349888;
				if (num != 0)
				{
				}
				num = (short)1086324737;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202.Value;
			}
			set
			{
				short num = (short)1306310813;
				short num2 = num;
				num = (short)505526429;
				switch (num2 == num)
				{
				}
				num = (short)1222574080;
				short num3 = num;
				num = (short)1426784257;
				if (num != 0)
				{
				}
				num = (short)1379663872;
				if (num != 0)
				{
				}
				this.radioErgoCfgFatalError_A36202.Value = value;
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x060060F0 RID: 24816 RVA: 0x005739C0 File Offset: 0x00571BC0
		// (set) Token: 0x060060F1 RID: 24817 RVA: 0x00573A74 File Offset: 0x00571C74
		public bool RadioErgoCfgFatalError_A36202_Applicable
		{
			get
			{
				short num = (short)1672118031;
				short num2 = num;
				num = (short)579632911;
				switch (num2 == num)
				{
				}
				num = (short)1335623680;
				short num3 = num;
				num = (short)988610561;
				if (num != 0)
				{
				}
				num = (short)1784020992;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202.Applicable;
			}
			set
			{
				short num = (short)582445274;
				short num2 = num;
				num = (short)338520282;
				switch (num2 == num)
				{
				}
				num = (short)1401552896;
				short num3 = num;
				num = (short)739770368;
				if (num != 0)
				{
				}
				num = (short)1730281473;
				if (num != 0)
				{
				}
				this.radioErgoCfgFatalError_A36202.Applicable = value;
			}
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x060060F2 RID: 24818 RVA: 0x00573B28 File Offset: 0x00571D28
		// (set) Token: 0x060060F3 RID: 24819 RVA: 0x00573BDC File Offset: 0x00571DDC
		public bool RadioErgoCfgFatalError_A36202_Valid
		{
			get
			{
				short num = (short)1985282049;
				if (num != 0)
				{
				}
				num = (short)574761902;
				short num2 = num;
				num = (short)997469102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)592117760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)719978496;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202.Valid;
			}
			set
			{
				short num = (short)1271816224;
				short num2 = num;
				num = (short)1295933472;
				switch (num2 == num)
				{
				}
				num = (short)219086848;
				short num3 = num;
				num = (short)207159296;
				if (num != 0)
				{
				}
				num = (short)1450770433;
				if (num != 0)
				{
				}
				this.radioErgoCfgFatalError_A36202.Valid = value;
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x060060F4 RID: 24820 RVA: 0x00573C90 File Offset: 0x00571E90
		// (set) Token: 0x060060F5 RID: 24821 RVA: 0x00573D48 File Offset: 0x00571F48
		public bool RadioErgoCfgFatalError_A36202_Visible
		{
			get
			{
				short num = (short)289210369;
				if (num != 0)
				{
				}
				num = (short)1045762912;
				short num2 = num;
				num = (short)781128544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)759234560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)259522560;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202.Visible;
			}
			set
			{
				short num = (short)437707941;
				short num2 = num;
				num = (short)744613029;
				switch (num2 == num)
				{
				}
				num = (short)1951203328;
				short num3 = num;
				num = (short)130613248;
				if (num != 0)
				{
				}
				num = (short)971964417;
				if (num != 0)
				{
				}
				this.radioErgoCfgFatalError_A36202.Visible = value;
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x060060F6 RID: 24822 RVA: 0x00573E00 File Offset: 0x00572000
		// (set) Token: 0x060060F7 RID: 24823 RVA: 0x00573EB4 File Offset: 0x005720B4
		public bool RadioErgoCfgFatalError_A36202_Editable
		{
			get
			{
				short num = (short)643625757;
				short num2 = num;
				num = (short)252900125;
				switch (num2 == num)
				{
				}
				num = (short)1932394496;
				short num3 = num;
				num = (short)871170049;
				if (num != 0)
				{
				}
				num = (short)587464704;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202.Editable;
			}
			set
			{
				short num = (short)56826866;
				short num2 = num;
				num = (short)454826994;
				switch (num2 == num)
				{
				}
				num = (short)1763508224;
				short num3 = num;
				num = (short)1278738433;
				if (num != 0)
				{
				}
				num = (short)1264713728;
				if (num != 0)
				{
				}
				this.radioErgoCfgFatalError_A36202.Editable = value;
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x060060F8 RID: 24824 RVA: 0x00573F6C File Offset: 0x0057216C
		internal string RadioErgoCfgFatalError_A36202_UILabel
		{
			get
			{
				short num = (short)711489064;
				short num2 = num;
				num = (short)1463842344;
				switch (num2 == num)
				{
				}
				num = (short)744161280;
				short num3 = num;
				num = (short)403832832;
				if (num != 0)
				{
				}
				num = (short)974127105;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202.UIName;
			}
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x060060F9 RID: 24825 RVA: 0x00574024 File Offset: 0x00572224
		// (set) Token: 0x060060FA RID: 24826 RVA: 0x005740D8 File Offset: 0x005722D8
		internal bool RadioErgoCfgFatalError_A36202_HiddenStatic
		{
			get
			{
				short num = (short)1714487297;
				if (num != 0)
				{
				}
				num = (short)445830383;
				short num2 = num;
				num = (short)1959253231;
				switch (num2 == num)
				{
				}
				num = (short)653590528;
				short num3 = num;
				num = (short)33882112;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202.HiddenStatic;
			}
			set
			{
				short num = (short)1148524208;
				short num2 = num;
				num = (short)1475810992;
				switch (num2 == num)
				{
				}
				num = (short)1042808833;
				if (num != 0)
				{
				}
				num = (short)1217593344;
				short num3 = num;
				num = (short)1561722880;
				if (num != 0)
				{
				}
				this.radioErgoCfgFatalError_A36202.HiddenStatic = value;
			}
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x060060FB RID: 24827 RVA: 0x00574190 File Offset: 0x00572390
		// (set) Token: 0x060060FC RID: 24828 RVA: 0x00574244 File Offset: 0x00572444
		internal bool RadioErgoCfgFatalError_A36202_HiddenDynamic
		{
			get
			{
				short num = (short)918421505;
				if (num != 0)
				{
				}
				num = (short)575225740;
				short num2 = num;
				num = (short)1322663820;
				switch (num2 == num)
				{
				}
				num = (short)1682898944;
				short num3 = num;
				num = (short)1056112640;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202.HiddenDynamic;
			}
			set
			{
				short num = (short)433818726;
				short num2 = num;
				num = (short)1964608614;
				switch (num2 == num)
				{
				}
				num = (short)496828417;
				if (num != 0)
				{
				}
				num = (short)831913984;
				short num3 = num;
				num = (short)645726208;
				if (num != 0)
				{
				}
				this.radioErgoCfgFatalError_A36202.HiddenDynamic = value;
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x060060FD RID: 24829 RVA: 0x005742FC File Offset: 0x005724FC
		public bool RadioErgoCfgFatalError_A36202_HasDiffs
		{
			get
			{
				short num = (short)1727793353;
				short num2 = num;
				num = (short)2066876617;
				switch (num2 == num)
				{
				}
				num = (short)985726977;
				if (num != 0)
				{
				}
				num = (short)2069102592;
				short num3 = num;
				num = (short)872546304;
				if (num != 0)
				{
				}
				return this.radioErgoCfgFatalError_A36202._HasDiffs;
			}
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x060060FE RID: 24830 RVA: 0x005743B0 File Offset: 0x005725B0
		// (set) Token: 0x060060FF RID: 24831 RVA: 0x00574464 File Offset: 0x00572664
		public bool RadErgoWideAdvancedFixedVolumeEnable_A37218Value
		{
			get
			{
				short num = (short)453054941;
				short num2 = num;
				num = (short)1303581149;
				switch (num2 == num)
				{
				}
				num = (short)917045249;
				if (num != 0)
				{
				}
				num = (short)2097283072;
				short num3 = num;
				num = (short)1127415808;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218.Value;
			}
			set
			{
				short num = (short)83794117;
				short num2 = num;
				num = (short)795646149;
				switch (num2 == num)
				{
				}
				num = (short)291373056;
				if (num != 0)
				{
				}
				num = (short)325189632;
				short num3 = num;
				num = (short)866648065;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeEnable_A37218.Value = value;
			}
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x06006100 RID: 24832 RVA: 0x00574518 File Offset: 0x00572718
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideAdvancedFixedVolumeEnable_A37218
		{
			get
			{
				short num = (short)2054459216;
				short num2 = num;
				num = (short)105942864;
				switch (num2 == num)
				{
				}
				num = (short)2076966913;
				if (num != 0)
				{
				}
				num = (short)1074003968;
				short num3 = num;
				num = (short)1050607616;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218;
			}
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x06006101 RID: 24833 RVA: 0x005745C8 File Offset: 0x005727C8
		// (set) Token: 0x06006102 RID: 24834 RVA: 0x0057467C File Offset: 0x0057287C
		public bool RadErgoWideAdvancedFixedVolumeEnable_A37218_UIValue
		{
			get
			{
				short num = (short)607576400;
				short num2 = num;
				num = (short)1508237648;
				switch (num2 == num)
				{
				}
				num = (short)717291521;
				if (num != 0)
				{
				}
				num = (short)517144576;
				short num3 = num;
				num = (short)1848442880;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218.Value;
			}
			set
			{
				short num = (short)2046958888;
				short num2 = num;
				num = (short)1156390184;
				switch (num2 == num)
				{
				}
				num = (short)903479297;
				if (num != 0)
				{
				}
				num = (short)305070080;
				short num3 = num;
				num = (short)1029373952;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeEnable_A37218.Value = value;
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x06006103 RID: 24835 RVA: 0x00574734 File Offset: 0x00572934
		// (set) Token: 0x06006104 RID: 24836 RVA: 0x005747E8 File Offset: 0x005729E8
		public bool RadErgoWideAdvancedFixedVolumeEnable_A37218_Applicable
		{
			get
			{
				short num = (short)2043412481;
				if (num != 0)
				{
				}
				num = (short)2090391663;
				short num2 = num;
				num = (short)1678170223;
				switch (num2 == num)
				{
				}
				num = (short)515702784;
				short num3 = num;
				num = (short)1229717504;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218.Applicable;
			}
			set
			{
				short num = (short)234804866;
				short num2 = num;
				num = (short)982439554;
				switch (num2 == num)
				{
				}
				num = (short)1776484352;
				if (num != 0)
				{
				}
				num = (short)1755119616;
				short num3 = num;
				num = (short)1805123585;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeEnable_A37218.Applicable = value;
			}
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x06006105 RID: 24837 RVA: 0x0057489C File Offset: 0x00572A9C
		// (set) Token: 0x06006106 RID: 24838 RVA: 0x00574950 File Offset: 0x00572B50
		public bool RadErgoWideAdvancedFixedVolumeEnable_A37218_Valid
		{
			get
			{
				short num = (short)1767049103;
				short num2 = num;
				num = (short)1326516111;
				switch (num2 == num)
				{
				}
				num = (short)1242365952;
				if (num != 0)
				{
				}
				num = (short)1103364096;
				short num3 = num;
				num = (short)1417347073;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218.Valid;
			}
			set
			{
				short num = (short)1463002910;
				short num2 = num;
				num = (short)1951573790;
				switch (num2 == num)
				{
				}
				num = (short)536477697;
				if (num != 0)
				{
				}
				num = (short)1867513856;
				short num3 = num;
				num = (short)1640235008;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeEnable_A37218.Valid = value;
			}
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x06006107 RID: 24839 RVA: 0x00574A08 File Offset: 0x00572C08
		// (set) Token: 0x06006108 RID: 24840 RVA: 0x00574ABC File Offset: 0x00572CBC
		public bool RadErgoWideAdvancedFixedVolumeEnable_A37218_Visible
		{
			get
			{
				short num = (short)13616830;
				short num2 = num;
				num = (short)258393790;
				switch (num2 == num)
				{
				}
				num = (short)772210689;
				if (num != 0)
				{
				}
				num = (short)532807680;
				short num3 = num;
				num = (short)995098624;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218.Visible;
			}
			set
			{
				short num = (short)1833228111;
				short num2 = num;
				num = (short)2072041295;
				switch (num2 == num)
				{
				}
				num = (short)1272840193;
				if (num != 0)
				{
				}
				num = (short)1976696832;
				short num3 = num;
				num = (short)1969750016;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeEnable_A37218.Visible = value;
			}
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x06006109 RID: 24841 RVA: 0x00574B70 File Offset: 0x00572D70
		// (set) Token: 0x0600610A RID: 24842 RVA: 0x00574C24 File Offset: 0x00572E24
		public bool RadErgoWideAdvancedFixedVolumeEnable_A37218_Editable
		{
			get
			{
				short num = (short)1693590676;
				short num2 = num;
				num = (short)1052779668;
				switch (num2 == num)
				{
				}
				num = (short)795934721;
				if (num != 0)
				{
				}
				num = (short)635043840;
				short num3 = num;
				num = (short)864813056;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218.Editable;
			}
			set
			{
				short num = (short)1427608027;
				short num2 = num;
				num = (short)1890030043;
				switch (num2 == num)
				{
				}
				num = (short)1232338945;
				if (num != 0)
				{
				}
				num = (short)1273888768;
				short num3 = num;
				num = (short)1687814144;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeEnable_A37218.Editable = value;
			}
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600610B RID: 24843 RVA: 0x00574CDC File Offset: 0x00572EDC
		internal string RadErgoWideAdvancedFixedVolumeEnable_A37218_UILabel
		{
			get
			{
				short num = (short)262594037;
				short num2 = num;
				num = (short)1180687861;
				switch (num2 == num)
				{
				}
				num = (short)340066305;
				if (num != 0)
				{
				}
				num = (short)120324096;
				short num3 = num;
				num = (short)1948778496;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218.UIName;
			}
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600610C RID: 24844 RVA: 0x00574D90 File Offset: 0x00572F90
		// (set) Token: 0x0600610D RID: 24845 RVA: 0x00574E48 File Offset: 0x00573048
		internal bool RadErgoWideAdvancedFixedVolumeEnable_A37218_HiddenStatic
		{
			get
			{
				short num = (short)1689533382;
				short num2 = num;
				num = (short)1048984518;
				switch (num2 == num)
				{
				}
				num = (short)1155596289;
				if (num != 0)
				{
				}
				num = (short)1235091456;
				short num3 = num;
				num = (short)1269301248;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218.HiddenStatic;
			}
			set
			{
				short num = (short)1771973543;
				short num2 = num;
				num = (short)1192242087;
				switch (num2 == num)
				{
				}
				num = (short)196609;
				if (num != 0)
				{
				}
				num = (short)594477056;
				short num3 = num;
				num = (short)846331904;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeEnable_A37218.HiddenStatic = value;
			}
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600610E RID: 24846 RVA: 0x00574F00 File Offset: 0x00573100
		// (set) Token: 0x0600610F RID: 24847 RVA: 0x00574FB8 File Offset: 0x005731B8
		internal bool RadErgoWideAdvancedFixedVolumeEnable_A37218_HiddenDynamic
		{
			get
			{
				short num = (short)389071206;
				short num2 = num;
				num = (short)1160298854;
				switch (num2 == num)
				{
				}
				num = (short)1611988993;
				if (num != 0)
				{
				}
				num = (short)252641280;
				short num3 = num;
				num = (short)64749568;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218.HiddenDynamic;
			}
			set
			{
				short num = (short)1518192311;
				short num2 = num;
				num = (short)529843895;
				switch (num2 == num)
				{
				}
				num = (short)891944960;
				if (num != 0)
				{
				}
				num = (short)244776960;
				short num3 = num;
				num = (short)924909569;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeEnable_A37218.HiddenDynamic = value;
			}
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x06006110 RID: 24848 RVA: 0x0057506C File Offset: 0x0057326C
		public bool RadErgoWideAdvancedFixedVolumeEnable_A37218_HasDiffs
		{
			get
			{
				short num = (short)1422524417;
				if (num != 0)
				{
				}
				num = (short)2094860921;
				short num2 = num;
				num = (short)252447353;
				switch (num2 == num)
				{
				}
				num = (short)1793720320;
				short num3 = num;
				num = (short)1693646848;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeEnable_A37218._HasDiffs;
			}
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x06006111 RID: 24849 RVA: 0x00575120 File Offset: 0x00573320
		// (set) Token: 0x06006112 RID: 24850 RVA: 0x005751D4 File Offset: 0x005733D4
		public bool RadErgoWideAdvancedToggleSwitchLockEnable_43773Value
		{
			get
			{
				short num = (short)1095660913;
				short num2 = num;
				num = (short)995063153;
				switch (num2 == num)
				{
				}
				num = (short)244514816;
				if (num != 0)
				{
				}
				num = (short)523173888;
				short num3 = num;
				num = (short)405733377;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Value;
			}
			set
			{
				short num = (short)1322947256;
				short num2 = num;
				num = (short)682726072;
				switch (num2 == num)
				{
				}
				num = (short)1052901377;
				if (num != 0)
				{
				}
				num = (short)154533888;
				short num3 = num;
				num = (short)1247477760;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Value = value;
			}
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x06006113 RID: 24851 RVA: 0x00575288 File Offset: 0x00573488
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideAdvancedToggleSwitchLockEnable_43773
		{
			get
			{
				short num = (short)1994412253;
				short num2 = num;
				num = (short)479809757;
				switch (num2 == num)
				{
				}
				num = (short)549191681;
				if (num != 0)
				{
				}
				num = (short)1846542336;
				short num3 = num;
				num = (short)1968963584;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773;
			}
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x06006114 RID: 24852 RVA: 0x00575334 File Offset: 0x00573534
		// (set) Token: 0x06006115 RID: 24853 RVA: 0x005753E4 File Offset: 0x005735E4
		public bool RadErgoWideAdvancedToggleSwitchLockEnable_43773_UIValue
		{
			get
			{
				short num = (short)803566696;
				short num2 = num;
				num = (short)1827763304;
				switch (num2 == num)
				{
				}
				num = (short)1304887296;
				if (num != 0)
				{
				}
				num = (short)808845312;
				short num3 = num;
				num = (short)1287847937;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Value;
			}
			set
			{
				short num = (short)349684453;
				short num2 = num;
				num = (short)1626129125;
				switch (num2 == num)
				{
				}
				num = (short)1408958465;
				if (num != 0)
				{
				}
				num = (short)87293952;
				short num3 = num;
				num = (short)24117248;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Value = value;
			}
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x06006116 RID: 24854 RVA: 0x00575498 File Offset: 0x00573698
		// (set) Token: 0x06006117 RID: 24855 RVA: 0x0057554C File Offset: 0x0057374C
		public bool RadErgoWideAdvancedToggleSwitchLockEnable_43773_Applicable
		{
			get
			{
				short num = (short)255285690;
				short num2 = num;
				num = (short)595089850;
				switch (num2 == num)
				{
				}
				num = (short)1841627137;
				if (num != 0)
				{
				}
				num = (short)608501760;
				short num3 = num;
				num = (short)919076864;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Applicable;
			}
			set
			{
				short num = (short)1679775814;
				short num2 = num;
				num = (short)534730822;
				switch (num2 == num)
				{
				}
				num = (short)444989441;
				if (num != 0)
				{
				}
				num = (short)539164672;
				short num3 = num;
				num = (short)905904128;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Applicable = value;
			}
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x06006118 RID: 24856 RVA: 0x00575600 File Offset: 0x00573800
		// (set) Token: 0x06006119 RID: 24857 RVA: 0x005756B8 File Offset: 0x005738B8
		public bool RadErgoWideAdvancedToggleSwitchLockEnable_43773_Valid
		{
			get
			{
				short num = (short)1559913040;
				short num2 = num;
				num = (short)1290429008;
				switch (num2 == num)
				{
				}
				num = (short)1915224065;
				if (num != 0)
				{
				}
				num = (short)102563840;
				short num3 = num;
				num = (short)1276116992;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Valid;
			}
			set
			{
				short num = (short)774944998;
				short num2 = num;
				num = (short)1665186022;
				switch (num2 == num)
				{
				}
				num = (short)1119551489;
				if (num != 0)
				{
				}
				num = (short)235470848;
				short num3 = num;
				num = (short)1613627392;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Valid = value;
			}
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600611A RID: 24858 RVA: 0x0057576C File Offset: 0x0057396C
		// (set) Token: 0x0600611B RID: 24859 RVA: 0x00575820 File Offset: 0x00573A20
		public bool RadErgoWideAdvancedToggleSwitchLockEnable_43773_Visible
		{
			get
			{
				short num = (short)715857447;
				short num2 = num;
				num = (short)692133415;
				switch (num2 == num)
				{
				}
				num = (short)941359105;
				if (num != 0)
				{
				}
				num = (short)1514536960;
				short num3 = num;
				num = (short)659750912;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Visible;
			}
			set
			{
				short num = (short)1106379103;
				short num2 = num;
				num = (short)308281695;
				switch (num2 == num)
				{
				}
				num = (short)1303904257;
				if (num != 0)
				{
				}
				num = (short)220069888;
				short num3 = num;
				num = (short)827260928;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Visible = value;
			}
		}

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600611C RID: 24860 RVA: 0x005758D0 File Offset: 0x00573AD0
		// (set) Token: 0x0600611D RID: 24861 RVA: 0x00575984 File Offset: 0x00573B84
		public bool RadErgoWideAdvancedToggleSwitchLockEnable_43773_Editable
		{
			get
			{
				short num = (short)625503157;
				short num2 = num;
				num = (short)356608949;
				switch (num2 == num)
				{
				}
				num = (short)1322188800;
				if (num != 0)
				{
				}
				num = (short)1084358656;
				short num3 = num;
				num = (short)544735233;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Editable;
			}
			set
			{
				short num = (short)1967731712;
				short num2 = num;
				num = (short)1010119680;
				switch (num2 == num)
				{
				}
				num = (short)746455041;
				if (num != 0)
				{
				}
				num = (short)1528889344;
				short num3 = num;
				num = (short)1656029184;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedToggleSwitchLockEnable_43773.Editable = value;
			}
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600611E RID: 24862 RVA: 0x00575A38 File Offset: 0x00573C38
		internal string RadErgoWideAdvancedToggleSwitchLockEnable_43773_UILabel
		{
			get
			{
				short num = (short)401428491;
				short num2 = num;
				num = (short)1370902539;
				switch (num2 == num)
				{
				}
				num = (short)557514753;
				if (num != 0)
				{
				}
				num = (short)1584201728;
				short num3 = num;
				num = (short)943718400;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773.UIName;
			}
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600611F RID: 24863 RVA: 0x00575AEC File Offset: 0x00573CEC
		// (set) Token: 0x06006120 RID: 24864 RVA: 0x00575BA0 File Offset: 0x00573DA0
		internal bool RadErgoWideAdvancedToggleSwitchLockEnable_43773_HiddenStatic
		{
			get
			{
				short num = (short)1276282840;
				short num2 = num;
				num = (short)308971480;
				switch (num2 == num)
				{
				}
				num = (short)1051131904;
				if (num != 0)
				{
				}
				num = (short)2121924608;
				short num3 = num;
				num = (short)1849163777;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773.HiddenStatic;
			}
			set
			{
				short num = (short)836199826;
				short num2 = num;
				num = (short)1607886226;
				switch (num2 == num)
				{
				}
				num = (short)1632960513;
				if (num != 0)
				{
				}
				num = (short)1670578176;
				short num3 = num;
				num = (short)288292864;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedToggleSwitchLockEnable_43773.HiddenStatic = value;
			}
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x06006121 RID: 24865 RVA: 0x00575C54 File Offset: 0x00573E54
		// (set) Token: 0x06006122 RID: 24866 RVA: 0x00575D08 File Offset: 0x00573F08
		internal bool RadErgoWideAdvancedToggleSwitchLockEnable_43773_HiddenDynamic
		{
			get
			{
				short num = (short)750911690;
				short num2 = num;
				num = (short)1052115146;
				switch (num2 == num)
				{
				}
				num = (short)169345024;
				if (num != 0)
				{
				}
				num = (short)888406016;
				short num3 = num;
				num = (short)180355073;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773.HiddenDynamic;
			}
			set
			{
				short num = (short)1398903755;
				short num2 = num;
				num = (short)2125304779;
				switch (num2 == num)
				{
				}
				num = (short)428670977;
				if (num != 0)
				{
				}
				num = (short)1391525888;
				short num3 = num;
				num = (short)398131200;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedToggleSwitchLockEnable_43773.HiddenDynamic = value;
			}
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x06006123 RID: 24867 RVA: 0x00575DC0 File Offset: 0x00573FC0
		public bool RadErgoWideAdvancedToggleSwitchLockEnable_43773_HasDiffs
		{
			get
			{
				short num = (short)1727594497;
				if (num != 0)
				{
				}
				num = (short)167293683;
				short num2 = num;
				num = (short)731820787;
				switch (num2 == num)
				{
				}
				num = (short)1773993984;
				short num3 = num;
				num = (short)751435776;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedToggleSwitchLockEnable_43773._HasDiffs;
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x06006124 RID: 24868 RVA: 0x00575E74 File Offset: 0x00574074
		// (set) Token: 0x06006125 RID: 24869 RVA: 0x00575F2C File Offset: 0x0057412C
		public int RadErgoWideAdvancedFixedVolumeLevel_A37219Value
		{
			get
			{
				short num = (short)781306159;
				short num2 = num;
				num = (short)1054198063;
				switch (num2 == num)
				{
				}
				num = (short)2122317825;
				if (num != 0)
				{
				}
				num = (short)1477836800;
				short num3 = num;
				num = (short)1383727104;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.Value;
			}
			set
			{
				short num = (short)734058466;
				short num2 = num;
				num = (short)1266866146;
				switch (num2 == num)
				{
				}
				num = (short)612106241;
				if (num != 0)
				{
				}
				num = (short)345047040;
				short num3 = num;
				num = (short)1907294208;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.Value = value;
			}
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x06006126 RID: 24870 RVA: 0x00575FE4 File Offset: 0x005741E4
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAdvancedFixedVolumeLevel_A37219
		{
			get
			{
				short num = (short)1729225243;
				short num2 = num;
				num = (short)871031323;
				switch (num2 == num)
				{
				}
				num = (short)1864105984;
				if (num != 0)
				{
				}
				num = (short)934805504;
				short num3 = num;
				num = (short)732233729;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219;
			}
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x06006127 RID: 24871 RVA: 0x00576094 File Offset: 0x00574294
		// (set) Token: 0x06006128 RID: 24872 RVA: 0x00576148 File Offset: 0x00574348
		public string RadErgoWideAdvancedFixedVolumeLevel_A37219_UIValue
		{
			get
			{
				short num = (short)1745713024;
				short num2 = num;
				num = (short)420575104;
				switch (num2 == num)
				{
				}
				num = (short)140378113;
				if (num != 0)
				{
				}
				num = (short)1847263232;
				short num3 = num;
				num = (short)169541632;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.UIValue;
			}
			set
			{
				short num = (short)1188217276;
				short num2 = num;
				num = (short)124436924;
				switch (num2 == num)
				{
				}
				num = (short)1152450561;
				if (num != 0)
				{
				}
				num = (short)1675493376;
				short num3 = num;
				num = (short)1962672128;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.UIValue = value;
			}
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x06006129 RID: 24873 RVA: 0x005761FC File Offset: 0x005743FC
		// (set) Token: 0x0600612A RID: 24874 RVA: 0x005762B0 File Offset: 0x005744B0
		internal int RadErgoWideAdvancedFixedVolumeLevel_A37219Min
		{
			get
			{
				short num = (short)1639802095;
				short num2 = num;
				num = (short)72836335;
				switch (num2 == num)
				{
				}
				num = (short)81133569;
				if (num != 0)
				{
				}
				num = (short)955842560;
				short num3 = num;
				num = (short)5505024;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.Min;
			}
			set
			{
				short num = (short)38701265;
				short num2 = num;
				num = (short)1871939793;
				switch (num2 == num)
				{
				}
				num = (short)590807040;
				if (num != 0)
				{
				}
				num = (short)376635392;
				short num3 = num;
				num = (short)1012596737;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.Min = value;
			}
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600612B RID: 24875 RVA: 0x00576364 File Offset: 0x00574564
		// (set) Token: 0x0600612C RID: 24876 RVA: 0x00576418 File Offset: 0x00574618
		internal int RadErgoWideAdvancedFixedVolumeLevel_A37219Max
		{
			get
			{
				short num = (short)381939403;
				short num2 = num;
				num = (short)1206644427;
				switch (num2 == num)
				{
				}
				num = (short)1942880257;
				if (num != 0)
				{
				}
				num = (short)1109524480;
				short num3 = num;
				num = (short)862191616;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.Max;
			}
			set
			{
				short num = (short)1449611977;
				short num2 = num;
				num = (short)1773097673;
				switch (num2 == num)
				{
				}
				num = (short)1485045761;
				if (num != 0)
				{
				}
				num = (short)1820196864;
				short num3 = num;
				num = (short)63832064;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.Max = value;
			}
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600612D RID: 24877 RVA: 0x005764D0 File Offset: 0x005746D0
		// (set) Token: 0x0600612E RID: 24878 RVA: 0x00576580 File Offset: 0x00574780
		internal int RadErgoWideAdvancedFixedVolumeLevel_A37219Step
		{
			get
			{
				short num = (short)2078348583;
				short num2 = num;
				num = (short)947590439;
				switch (num2 == num)
				{
				}
				num = (short)1862270976;
				if (num != 0)
				{
				}
				num = (short)534577152;
				short num3 = num;
				num = (short)270204929;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.StepSize;
			}
			set
			{
				short num = (short)101441580;
				short num2 = num;
				num = (short)701685804;
				switch (num2 == num)
				{
				}
				num = (short)431292416;
				if (num != 0)
				{
				}
				num = (short)330629120;
				short num3 = num;
				num = (short)1747189761;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.StepSize = value;
			}
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600612F RID: 24879 RVA: 0x00576634 File Offset: 0x00574834
		// (set) Token: 0x06006130 RID: 24880 RVA: 0x005766E8 File Offset: 0x005748E8
		public bool RadErgoWideAdvancedFixedVolumeLevel_A37219_Applicable
		{
			get
			{
				short num = (short)135875200;
				short num2 = num;
				num = (short)7621248;
				switch (num2 == num)
				{
				}
				num = (short)1722417152;
				if (num != 0)
				{
				}
				num = (short)571604992;
				short num3 = num;
				num = (short)176553985;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.Applicable;
			}
			set
			{
				short num = (short)70587273;
				short num2 = num;
				num = (short)1344607113;
				switch (num2 == num)
				{
				}
				num = (short)70582273;
				if (num != 0)
				{
				}
				num = (short)1469579264;
				short num3 = num;
				num = (short)1894187008;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.Applicable = value;
			}
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x06006131 RID: 24881 RVA: 0x005767A0 File Offset: 0x005749A0
		// (set) Token: 0x06006132 RID: 24882 RVA: 0x00576858 File Offset: 0x00574A58
		public bool RadErgoWideAdvancedFixedVolumeLevel_A37219_Valid
		{
			get
			{
				short num = (short)1470648312;
				short num2 = num;
				num = (short)1904300024;
				switch (num2 == num)
				{
				}
				num = (short)1735917569;
				if (num != 0)
				{
				}
				num = (short)1440219136;
				short num3 = num;
				num = (short)754581504;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.Valid;
			}
			set
			{
				short num = (short)1966997505;
				if (num != 0)
				{
				}
				num = (short)631452946;
				short num2 = num;
				num = (short)1864054034;
				switch (num2 == num)
				{
				}
				num = (short)1172373504;
				short num3 = num;
				num = (short)242483200;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.Valid = value;
			}
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x06006133 RID: 24883 RVA: 0x00576910 File Offset: 0x00574B10
		// (set) Token: 0x06006134 RID: 24884 RVA: 0x005769C4 File Offset: 0x00574BC4
		public bool RadErgoWideAdvancedFixedVolumeLevel_A37219_Visible
		{
			get
			{
				short num = (short)201135861;
				short num2 = num;
				num = (short)334632693;
				switch (num2 == num)
				{
				}
				num = (short)328007680;
				if (num != 0)
				{
				}
				num = (short)196608;
				short num3 = num;
				num = (short)413990913;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.Visible;
			}
			set
			{
				short num = (short)1992390161;
				short num2 = num;
				num = (short)642348561;
				switch (num2 == num)
				{
				}
				num = (short)26804225;
				if (num != 0)
				{
				}
				num = (short)223281152;
				short num3 = num;
				num = (short)2011037696;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.Visible = value;
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x06006135 RID: 24885 RVA: 0x00576A78 File Offset: 0x00574C78
		// (set) Token: 0x06006136 RID: 24886 RVA: 0x00576B2C File Offset: 0x00574D2C
		public bool RadErgoWideAdvancedFixedVolumeLevel_A37219_Editable
		{
			get
			{
				short num = (short)222150911;
				short num2 = num;
				num = (short)603963647;
				switch (num2 == num)
				{
				}
				num = (short)1460797440;
				if (num != 0)
				{
				}
				num = (short)753795073;
				if (num != 0)
				{
				}
				num = (short)986841088;
				short num3 = num;
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.Editable;
			}
			set
			{
				short num = (short)1378690141;
				short num2 = num;
				num = (short)145433693;
				switch (num2 == num)
				{
				}
				num = (short)984088576;
				if (num != 0)
				{
				}
				num = (short)1848442881;
				if (num != 0)
				{
				}
				num = (short)311230464;
				short num3 = num;
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.Editable = value;
			}
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x06006137 RID: 24887 RVA: 0x00576BE4 File Offset: 0x00574DE4
		internal string RadErgoWideAdvancedFixedVolumeLevel_A37219_UILabel
		{
			get
			{
				short num = (short)1515520001;
				if (num != 0)
				{
				}
				num = (short)445566059;
				short num2 = num;
				num = (short)237882475;
				switch (num2 == num)
				{
				}
				num = (short)1937047552;
				if (num != 0)
				{
				}
				num = (short)1688010752;
				short num3 = num;
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.UIName;
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x06006138 RID: 24888 RVA: 0x00576C98 File Offset: 0x00574E98
		// (set) Token: 0x06006139 RID: 24889 RVA: 0x00576D50 File Offset: 0x00574F50
		internal bool RadErgoWideAdvancedFixedVolumeLevel_A37219_HiddenStatic
		{
			get
			{
				short num = (short)703891349;
				short num2 = num;
				num = (short)1454999445;
				switch (num2 == num)
				{
				}
				num = (short)291635200;
				if (num != 0)
				{
				}
				num = (short)1353711617;
				if (num != 0)
				{
				}
				num = (short)1209794560;
				short num3 = num;
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.HiddenStatic;
			}
			set
			{
				short num = (short)1301726434;
				short num2 = num;
				num = (short)1137820898;
				switch (num2 == num)
				{
				}
				num = (short)327286785;
				if (num != 0)
				{
				}
				num = (short)1909587968;
				if (num != 0)
				{
				}
				num = (short)872480768;
				short num3 = num;
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.HiddenStatic = value;
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600613A RID: 24890 RVA: 0x00576E04 File Offset: 0x00575004
		// (set) Token: 0x0600613B RID: 24891 RVA: 0x00576EB8 File Offset: 0x005750B8
		internal bool RadErgoWideAdvancedFixedVolumeLevel_A37219_HiddenDynamic
		{
			get
			{
				short num = (short)1872393758;
				short num2 = num;
				num = (short)1648719390;
				switch (num2 == num)
				{
				}
				num = (short)1267924993;
				if (num != 0)
				{
				}
				num = (short)25755648;
				if (num != 0)
				{
				}
				num = (short)142868480;
				short num3 = num;
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219.HiddenDynamic;
			}
			set
			{
				short num = (short)354164124;
				short num2 = num;
				num = (short)1223368092;
				switch (num2 == num)
				{
				}
				num = (short)729219073;
				if (num != 0)
				{
				}
				num = (short)403374080;
				if (num != 0)
				{
				}
				num = (short)800587776;
				short num3 = num;
				this.radErgoWideAdvancedFixedVolumeLevel_A37219.HiddenDynamic = value;
			}
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600613C RID: 24892 RVA: 0x00576F6C File Offset: 0x0057516C
		public bool RadErgoWideAdvancedFixedVolumeLevel_A37219_HasDiffs
		{
			get
			{
				short num = (short)1456859496;
				short num2 = num;
				num = (short)1990388072;
				switch (num2 == num)
				{
				}
				num = (short)348848129;
				if (num != 0)
				{
				}
				num = (short)1451819008;
				if (num != 0)
				{
				}
				num = (short)984743936;
				short num3 = num;
				return this.radErgoWideAdvancedFixedVolumeLevel_A37219._HasDiffs;
			}
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600613D RID: 24893 RVA: 0x00577020 File Offset: 0x00575220
		// (set) Token: 0x0600613E RID: 24894 RVA: 0x005770D4 File Offset: 0x005752D4
		public int RadErgoWideAdvancedDefaultCHHubState_A37222Value
		{
			get
			{
				short num = (short)1000646078;
				short num2 = num;
				num = (short)1682613694;
				switch (num2 == num)
				{
				}
				num = (short)307888128;
				if (num != 0)
				{
				}
				num = (short)1824718849;
				if (num != 0)
				{
				}
				num = (short)1778515968;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222.Value;
			}
			set
			{
				short num = (short)1393580809;
				short num2 = num;
				num = (short)720526089;
				switch (num2 == num)
				{
				}
				num = (short)1662713857;
				if (num != 0)
				{
				}
				num = (short)718274560;
				if (num != 0)
				{
				}
				num = (short)462684160;
				short num3 = num;
				this.radErgoWideAdvancedDefaultCHHubState_A37222.Value = value;
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600613F RID: 24895 RVA: 0x0057718C File Offset: 0x0057538C
		// (set) Token: 0x06006140 RID: 24896 RVA: 0x00577244 File Offset: 0x00575444
		public string RadErgoWideAdvancedDefaultCHHubState_A37222_UIValue
		{
			get
			{
				short num = (short)2129699662;
				short num2 = num;
				num = (short)605201230;
				switch (num2 == num)
				{
				}
				num = (short)496369665;
				if (num != 0)
				{
				}
				num = (short)2064580608;
				if (num != 0)
				{
				}
				num = (short)1635188736;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222.UIValue;
			}
			set
			{
				short num = (short)2054608008;
				short num2 = num;
				num = (short)368497800;
				switch (num2 == num)
				{
				}
				num = (short)1435435008;
				if (num != 0)
				{
				}
				num = (short)690814977;
				if (num != 0)
				{
				}
				num = (short)200867840;
				short num3 = num;
				this.radErgoWideAdvancedDefaultCHHubState_A37222.UIValue = value;
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x06006141 RID: 24897 RVA: 0x005772F8 File Offset: 0x005754F8
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedDefaultCHHubState_A37222
		{
			get
			{
				short num = (short)1510410755;
				short num2 = num;
				num = (short)861604355;
				switch (num2 == num)
				{
				}
				num = (short)1454178305;
				if (num != 0)
				{
				}
				num = (short)1531772928;
				if (num != 0)
				{
				}
				num = (short)234553344;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222;
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x06006142 RID: 24898 RVA: 0x005773A8 File Offset: 0x005755A8
		// (set) Token: 0x06006143 RID: 24899 RVA: 0x0057745C File Offset: 0x0057565C
		public bool RadErgoWideAdvancedDefaultCHHubState_A37222_Applicable
		{
			get
			{
				short num = (short)1629976675;
				short num2 = num;
				num = (short)2127198307;
				switch (num2 == num)
				{
				}
				num = (short)613744641;
				if (num != 0)
				{
				}
				num = (short)277676032;
				if (num != 0)
				{
				}
				num = (short)842858496;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222.Applicable;
			}
			set
			{
				short num = (short)1715288827;
				short num2 = num;
				num = (short)1112226555;
				switch (num2 == num)
				{
				}
				num = (short)977403905;
				if (num != 0)
				{
				}
				num = (short)880934912;
				if (num != 0)
				{
				}
				num = (short)509607936;
				short num3 = num;
				this.radErgoWideAdvancedDefaultCHHubState_A37222.Applicable = value;
			}
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x06006144 RID: 24900 RVA: 0x00577514 File Offset: 0x00575714
		// (set) Token: 0x06006145 RID: 24901 RVA: 0x005775C8 File Offset: 0x005757C8
		public bool RadErgoWideAdvancedDefaultCHHubState_A37222_Valid
		{
			get
			{
				short num = (short)974428124;
				short num2 = num;
				num = (short)844339164;
				switch (num2 == num)
				{
				}
				num = (short)48037888;
				if (num != 0)
				{
				}
				num = (short)9961473;
				if (num != 0)
				{
				}
				num = (short)233897984;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222.Valid;
			}
			set
			{
				short num = (short)261361267;
				short num2 = num;
				num = (short)725290611;
				switch (num2 == num)
				{
				}
				num = (short)1164967937;
				if (num != 0)
				{
				}
				num = (short)1345388544;
				if (num != 0)
				{
				}
				num = (short)719257600;
				short num3 = num;
				this.radErgoWideAdvancedDefaultCHHubState_A37222.Valid = value;
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x06006146 RID: 24902 RVA: 0x0057767C File Offset: 0x0057587C
		// (set) Token: 0x06006147 RID: 24903 RVA: 0x00577734 File Offset: 0x00575934
		public bool RadErgoWideAdvancedDefaultCHHubState_A37222_Visible
		{
			get
			{
				short num = (short)558628232;
				short num2 = num;
				num = (short)1307049352;
				switch (num2 == num)
				{
				}
				num = (short)1105526785;
				if (num != 0)
				{
				}
				num = (short)2075918336;
				if (num != 0)
				{
				}
				num = (short)2041708544;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222.Visible;
			}
			set
			{
				short num = (short)1848717974;
				short num2 = num;
				num = (short)581186198;
				switch (num2 == num)
				{
				}
				num = (short)542965761;
				if (num != 0)
				{
				}
				num = (short)431226880;
				if (num != 0)
				{
				}
				num = (short)1853030400;
				short num3 = num;
				this.radErgoWideAdvancedDefaultCHHubState_A37222.Visible = value;
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x06006148 RID: 24904 RVA: 0x005777E8 File Offset: 0x005759E8
		// (set) Token: 0x06006149 RID: 24905 RVA: 0x005778A0 File Offset: 0x00575AA0
		public bool RadErgoWideAdvancedDefaultCHHubState_A37222_Editable
		{
			get
			{
				short num = (short)439456597;
				short num2 = num;
				num = (short)1424659285;
				switch (num2 == num)
				{
				}
				num = (short)997851136;
				if (num != 0)
				{
				}
				num = (short)2078605313;
				if (num != 0)
				{
				}
				num = (short)1454309376;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222.Editable;
			}
			set
			{
				short num = (short)1009916728;
				short num2 = num;
				num = (short)1063000888;
				switch (num2 == num)
				{
				}
				num = (short)2818048;
				if (num != 0)
				{
				}
				num = (short)996999169;
				if (num != 0)
				{
				}
				num = (short)415760384;
				short num3 = num;
				this.radErgoWideAdvancedDefaultCHHubState_A37222.Editable = value;
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600614A RID: 24906 RVA: 0x00577958 File Offset: 0x00575B58
		internal string RadErgoWideAdvancedDefaultCHHubState_A37222_UILabel
		{
			get
			{
				short num = (short)1239846689;
				short num2 = num;
				num = (short)80121633;
				switch (num2 == num)
				{
				}
				num = (short)1332412417;
				if (num != 0)
				{
				}
				num = (short)253624320;
				if (num != 0)
				{
				}
				num = (short)588185600;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222.UIName;
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600614B RID: 24907 RVA: 0x00577A0C File Offset: 0x00575C0C
		// (set) Token: 0x0600614C RID: 24908 RVA: 0x00577AC0 File Offset: 0x00575CC0
		internal bool RadErgoWideAdvancedDefaultCHHubState_A37222_HiddenStatic
		{
			get
			{
				short num = (short)1765937017;
				short num2 = num;
				num = (short)390532985;
				switch (num2 == num)
				{
				}
				num = (short)1541734401;
				if (num != 0)
				{
				}
				num = (short)1846935552;
				if (num != 0)
				{
				}
				num = (short)607387648;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222.HiddenStatic;
			}
			set
			{
				short num = (short)1150106131;
				short num2 = num;
				num = (short)333330963;
				switch (num2 == num)
				{
				}
				num = (short)121110528;
				if (num != 0)
				{
				}
				num = (short)374996993;
				if (num != 0)
				{
				}
				num = (short)247332864;
				short num3 = num;
				this.radErgoWideAdvancedDefaultCHHubState_A37222.HiddenStatic = value;
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600614D RID: 24909 RVA: 0x00577B74 File Offset: 0x00575D74
		// (set) Token: 0x0600614E RID: 24910 RVA: 0x00577C28 File Offset: 0x00575E28
		internal bool RadErgoWideAdvancedDefaultCHHubState_A37222_HiddenDynamic
		{
			get
			{
				short num = (short)1344105198;
				short num2 = num;
				num = (short)1787980526;
				switch (num2 == num)
				{
				}
				num = (short)1006174208;
				if (num != 0)
				{
				}
				num = (short)1546256385;
				if (num != 0)
				{
				}
				num = (short)1434255360;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222.HiddenDynamic;
			}
			set
			{
				short num = (short)961414524;
				short num2 = num;
				num = (short)35259772;
				switch (num2 == num)
				{
				}
				num = (short)1424949249;
				if (num != 0)
				{
				}
				num = (short)1366097920;
				if (num != 0)
				{
				}
				num = (short)167641088;
				short num3 = num;
				this.radErgoWideAdvancedDefaultCHHubState_A37222.HiddenDynamic = value;
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600614F RID: 24911 RVA: 0x00577CDC File Offset: 0x00575EDC
		public bool RadErgoWideAdvancedDefaultCHHubState_A37222_HasDiffs
		{
			get
			{
				short num = (short)82660648;
				short num2 = num;
				num = (short)636636456;
				switch (num2 == num)
				{
				}
				num = (short)553648129;
				if (num != 0)
				{
				}
				num = (short)1532166144;
				if (num != 0)
				{
				}
				num = (short)1811152896;
				short num3 = num;
				return this.radErgoWideAdvancedDefaultCHHubState_A37222._HasDiffs;
			}
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x06006150 RID: 24912 RVA: 0x00577D90 File Offset: 0x00575F90
		// (set) Token: 0x06006151 RID: 24913 RVA: 0x00577E48 File Offset: 0x00576048
		public bool RadErgoWideAdvancedConsoletteEnable_A37231Value
		{
			get
			{
				short num = (short)410048698;
				short num2 = num;
				num = (short)126671034;
				switch (num2 == num)
				{
				}
				num = (short)128974849;
				if (num != 0)
				{
				}
				num = (short)1843265536;
				if (num != 0)
				{
				}
				num = (short)853475328;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231.Value;
			}
			set
			{
				short num = (short)2054607782;
				short num2 = num;
				num = (short)1455149990;
				switch (num2 == num)
				{
				}
				num = (short)1438056449;
				if (num != 0)
				{
				}
				num = (short)1771241472;
				if (num != 0)
				{
				}
				num = (short)903086080;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteEnable_A37231.Value = value;
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x06006152 RID: 24914 RVA: 0x00577EFC File Offset: 0x005760FC
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideAdvancedConsoletteEnable_A37231
		{
			get
			{
				short num = (short)1379397078;
				short num2 = num;
				num = (short)1255927254;
				switch (num2 == num)
				{
				}
				num = (short)551419904;
				if (num != 0)
				{
				}
				num = (short)658964481;
				if (num != 0)
				{
				}
				num = (short)14942208;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231;
			}
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x06006153 RID: 24915 RVA: 0x00577FB0 File Offset: 0x005761B0
		// (set) Token: 0x06006154 RID: 24916 RVA: 0x00578064 File Offset: 0x00576264
		public bool RadErgoWideAdvancedConsoletteEnable_A37231_UIValue
		{
			get
			{
				short num = (short)1423055804;
				short num2 = num;
				num = (short)1275599804;
				switch (num2 == num)
				{
				}
				num = (short)34734081;
				if (num != 0)
				{
				}
				num = (short)1682571264;
				if (num != 0)
				{
				}
				num = (short)185270272;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231.Value;
			}
			set
			{
				short num = (short)1265172205;
				short num2 = num;
				num = (short)1891958509;
				switch (num2 == num)
				{
				}
				num = (short)1656356865;
				if (num != 0)
				{
				}
				num = (short)1228275712;
				if (num != 0)
				{
				}
				num = (short)366739456;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteEnable_A37231.Value = value;
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x06006155 RID: 24917 RVA: 0x00578118 File Offset: 0x00576318
		// (set) Token: 0x06006156 RID: 24918 RVA: 0x005781D0 File Offset: 0x005763D0
		public bool RadErgoWideAdvancedConsoletteEnable_A37231_Applicable
		{
			get
			{
				short num = (short)1333410070;
				short num2 = num;
				num = (short)583678230;
				switch (num2 == num)
				{
				}
				num = (short)940376064;
				if (num != 0)
				{
				}
				num = (short)1524367361;
				if (num != 0)
				{
				}
				num = (short)432013312;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231.Applicable;
			}
			set
			{
				short num = (short)446894534;
				short num2 = num;
				num = (short)1500975558;
				switch (num2 == num)
				{
				}
				num = (short)497942529;
				if (num != 0)
				{
				}
				num = (short)978845696;
				if (num != 0)
				{
				}
				num = (short)1190592512;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteEnable_A37231.Applicable = value;
			}
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x06006157 RID: 24919 RVA: 0x00578288 File Offset: 0x00576488
		// (set) Token: 0x06006158 RID: 24920 RVA: 0x0057833C File Offset: 0x0057653C
		public bool RadErgoWideAdvancedConsoletteEnable_A37231_Valid
		{
			get
			{
				short num = (short)838444178;
				short num2 = num;
				num = (short)1855300754;
				switch (num2 == num)
				{
				}
				num = (short)114688001;
				if (num != 0)
				{
				}
				num = (short)2046689280;
				if (num != 0)
				{
				}
				num = (short)208338944;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231.Valid;
			}
			set
			{
				short num = (short)1367605249;
				if (num != 0)
				{
				}
				num = (short)1965743213;
				short num2 = num;
				num = (short)909761645;
				switch (num2 == num)
				{
				}
				num = (short)150536192;
				if (num != 0)
				{
				}
				num = (short)862584832;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteEnable_A37231.Valid = value;
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x06006159 RID: 24921 RVA: 0x005783F4 File Offset: 0x005765F4
		// (set) Token: 0x0600615A RID: 24922 RVA: 0x005784A8 File Offset: 0x005766A8
		public bool RadErgoWideAdvancedConsoletteEnable_A37231_Visible
		{
			get
			{
				short num = (short)1720174431;
				short num2 = num;
				num = (short)704628575;
				switch (num2 == num)
				{
				}
				num = (short)1790509057;
				if (num != 0)
				{
				}
				num = (short)1037369344;
				if (num != 0)
				{
				}
				num = (short)375390208;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231.Visible;
			}
			set
			{
				short num = (short)591932254;
				short num2 = num;
				num = (short)1879583582;
				switch (num2 == num)
				{
				}
				num = (short)2041118721;
				if (num != 0)
				{
				}
				num = (short)1511325696;
				if (num != 0)
				{
				}
				num = (short)1565655040;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteEnable_A37231.Visible = value;
			}
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600615B RID: 24923 RVA: 0x0057855C File Offset: 0x0057675C
		// (set) Token: 0x0600615C RID: 24924 RVA: 0x00578610 File Offset: 0x00576810
		public bool RadErgoWideAdvancedConsoletteEnable_A37231_Editable
		{
			get
			{
				short num = (short)435684428;
				short num2 = num;
				num = (short)223675468;
				switch (num2 == num)
				{
				}
				num = (short)1700134912;
				if (num != 0)
				{
				}
				num = (short)716177409;
				if (num != 0)
				{
				}
				num = (short)4784128;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231.Editable;
			}
			set
			{
				short num = (short)1717920195;
				short num2 = num;
				num = (short)1985700291;
				switch (num2 == num)
				{
				}
				num = (short)1280966657;
				if (num != 0)
				{
				}
				num = (short)1313210368;
				if (num != 0)
				{
				}
				num = (short)1129971712;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteEnable_A37231.Editable = value;
			}
		}

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600615D RID: 24925 RVA: 0x005786C4 File Offset: 0x005768C4
		internal string RadErgoWideAdvancedConsoletteEnable_A37231_UILabel
		{
			get
			{
				short num = (short)1935852671;
				short num2 = num;
				num = (short)1470350463;
				switch (num2 == num)
				{
				}
				num = (short)1735655425;
				if (num != 0)
				{
				}
				num = (short)1796276224;
				if (num != 0)
				{
				}
				num = (short)1838546944;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231.UIName;
			}
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600615E RID: 24926 RVA: 0x00578778 File Offset: 0x00576978
		// (set) Token: 0x0600615F RID: 24927 RVA: 0x0057882C File Offset: 0x00576A2C
		internal bool RadErgoWideAdvancedConsoletteEnable_A37231_HiddenStatic
		{
			get
			{
				short num = (short)1082691095;
				short num2 = num;
				num = (short)785813015;
				switch (num2 == num)
				{
				}
				num = (short)1808269313;
				if (num != 0)
				{
				}
				num = (short)193134592;
				if (num != 0)
				{
				}
				num = (short)1229324288;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231.HiddenStatic;
			}
			set
			{
				short num = (short)1717115901;
				short num2 = num;
				num = (short)1130306557;
				switch (num2 == num)
				{
				}
				num = (short)193134593;
				if (num != 0)
				{
				}
				num = (short)1404829696;
				if (num != 0)
				{
				}
				num = (short)798687232;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteEnable_A37231.HiddenStatic = value;
			}
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x06006160 RID: 24928 RVA: 0x005788E0 File Offset: 0x00576AE0
		// (set) Token: 0x06006161 RID: 24929 RVA: 0x00578998 File Offset: 0x00576B98
		internal bool RadErgoWideAdvancedConsoletteEnable_A37231_HiddenDynamic
		{
			get
			{
				short num = (short)247728614;
				short num2 = num;
				num = (short)1679624678;
				switch (num2 == num)
				{
				}
				num = (short)59637761;
				if (num != 0)
				{
				}
				num = (short)1286340608;
				if (num != 0)
				{
				}
				num = (short)1052704768;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231.HiddenDynamic;
			}
			set
			{
				short num = (short)2119689602;
				short num2 = num;
				num = (short)1876747650;
				switch (num2 == num)
				{
				}
				num = (short)1929117697;
				if (num != 0)
				{
				}
				num = (short)1467678720;
				if (num != 0)
				{
				}
				num = (short)1706754048;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteEnable_A37231.HiddenDynamic = value;
			}
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x06006162 RID: 24930 RVA: 0x00578A4C File Offset: 0x00576C4C
		public bool RadErgoWideAdvancedConsoletteEnable_A37231_HasDiffs
		{
			get
			{
				short num = (short)1679432259;
				short num2 = num;
				num = (short)1239095875;
				switch (num2 == num)
				{
				}
				num = (short)535560193;
				if (num != 0)
				{
				}
				num = (short)316080128;
				if (num != 0)
				{
				}
				num = (short)265093120;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteEnable_A37231._HasDiffs;
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x06006163 RID: 24931 RVA: 0x00578AFC File Offset: 0x00576CFC
		// (set) Token: 0x06006164 RID: 24932 RVA: 0x00578BB4 File Offset: 0x00576DB4
		public bool RadErgoWideAdvancedConsoletteFatalError_A37233Value
		{
			get
			{
				short num = (short)258885829;
				short num2 = num;
				num = (short)1896040645;
				switch (num2 == num)
				{
				}
				num = (short)404160513;
				if (num != 0)
				{
				}
				num = (short)17432576;
				if (num != 0)
				{
				}
				num = (short)842334208;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteFatalError_A37233.Value;
			}
			set
			{
				short num = (short)1996463300;
				short num2 = num;
				num = (short)1357421764;
				switch (num2 == num)
				{
				}
				num = (short)760545281;
				if (num != 0)
				{
				}
				num = (short)2127495168;
				if (num != 0)
				{
				}
				num = (short)1403256832;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteFatalError_A37233.Value = value;
			}
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x06006165 RID: 24933 RVA: 0x00578C68 File Offset: 0x00576E68
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideAdvancedConsoletteFatalError_A37233
		{
			get
			{
				short num = (short)1589945648;
				short num2 = num;
				num = (short)147629360;
				switch (num2 == num)
				{
				}
				num = (short)1712717825;
				if (num != 0)
				{
				}
				num = (short)1929904128;
				if (num != 0)
				{
				}
				num = (short)1068302336;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteFatalError_A37233;
			}
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x06006166 RID: 24934 RVA: 0x00578D18 File Offset: 0x00576F18
		// (set) Token: 0x06006167 RID: 24935 RVA: 0x00578DCC File Offset: 0x00576FCC
		public bool RadErgoWideAdvancedConsoletteFatalError_A37233_UIValue
		{
			get
			{
				short num = (short)1471787684;
				short num2 = num;
				num = (short)1463136932;
				switch (num2 == num)
				{
				}
				num = (short)498860032;
				if (num != 0)
				{
				}
				num = (short)23920641;
				if (num != 0)
				{
				}
				num = (short)2102722560;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteFatalError_A37233.Value;
			}
			set
			{
				short num = (short)1239810049;
				if (num != 0)
				{
				}
				num = (short)907347221;
				short num2 = num;
				num = (short)1053623573;
				switch (num2 == num)
				{
				}
				num = (short)1802305536;
				if (num != 0)
				{
				}
				num = (short)9109504;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteFatalError_A37233.Value = value;
			}
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x06006168 RID: 24936 RVA: 0x00578E80 File Offset: 0x00577080
		// (set) Token: 0x06006169 RID: 24937 RVA: 0x00578F34 File Offset: 0x00577134
		public bool RadErgoWideAdvancedConsoletteFatalError_A37233_Applicable
		{
			get
			{
				short num = (short)1427111937;
				if (num != 0)
				{
				}
				num = (short)1786925679;
				short num2 = num;
				num = (short)1384927855;
				switch (num2 == num)
				{
				}
				num = (short)650248192;
				if (num != 0)
				{
				}
				num = (short)1359347712;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteFatalError_A37233.Applicable;
			}
			set
			{
				short num = (short)737739387;
				short num2 = num;
				num = (short)444269179;
				switch (num2 == num)
				{
				}
				num = (short)2075590657;
				if (num != 0)
				{
				}
				num = (short)2091384832;
				if (num != 0)
				{
				}
				num = (short)2088173568;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteFatalError_A37233.Applicable = value;
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600616A RID: 24938 RVA: 0x00578FE8 File Offset: 0x005771E8
		// (set) Token: 0x0600616B RID: 24939 RVA: 0x0057909C File Offset: 0x0057729C
		public bool RadErgoWideAdvancedConsoletteFatalError_A37233_Valid
		{
			get
			{
				short num = (short)422806431;
				short num2 = num;
				num = (short)163283871;
				switch (num2 == num)
				{
				}
				num = (short)397934592;
				if (num != 0)
				{
				}
				num = (short)1114177537;
				if (num != 0)
				{
				}
				num = (short)1485635584;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteFatalError_A37233.Valid;
			}
			set
			{
				short num = (short)871652057;
				short num2 = num;
				num = (short)1163221721;
				switch (num2 == num)
				{
				}
				num = (short)2146762753;
				if (num != 0)
				{
				}
				num = (short)1541079040;
				if (num != 0)
				{
				}
				num = (short)2091646976;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteFatalError_A37233.Valid = value;
			}
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600616C RID: 24940 RVA: 0x00579150 File Offset: 0x00577350
		// (set) Token: 0x0600616D RID: 24941 RVA: 0x00579204 File Offset: 0x00577404
		public bool RadErgoWideAdvancedConsoletteFatalError_A37233_Visible
		{
			get
			{
				short num = (short)247869918;
				short num2 = num;
				num = (short)1055142366;
				switch (num2 == num)
				{
				}
				num = (short)454230017;
				if (num != 0)
				{
				}
				num = (short)1629880320;
				if (num != 0)
				{
				}
				num = (short)789118976;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteFatalError_A37233.Visible;
			}
			set
			{
				short num = (short)778310884;
				short num2 = num;
				num = (short)50468068;
				switch (num2 == num)
				{
				}
				num = (short)465436673;
				if (num != 0)
				{
				}
				num = (short)2011955200;
				if (num != 0)
				{
				}
				num = (short)700448768;
				short num3 = num;
				this.radErgoWideAdvancedConsoletteFatalError_A37233.Visible = value;
			}
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600616E RID: 24942 RVA: 0x005792BC File Offset: 0x005774BC
		// (set) Token: 0x0600616F RID: 24943 RVA: 0x00579370 File Offset: 0x00577570
		public bool RadErgoWideAdvancedConsoletteFatalError_A37233_Editable
		{
			get
			{
				short num = (short)483590145;
				if (num != 0)
				{
				}
				num = (short)1440846423;
				short num2 = num;
				num = (short)1981387351;
				switch (num2 == num)
				{
				}
				num = (short)354353152;
				if (num != 0)
				{
				}
				num = (short)1263468544;
				short num3 = num;
				return this.radErgoWideAdvancedConsoletteFatalError_A37233.Editable;
			}
			set
			{
				short num = (short)1144659110;
				short num2 = num;
				num = (short)1494293670;
				switch (num2 == num)
				{
				}
				num = (short)1050476544;
				if (num != 0)
				{
				}
				num = (short)746061824;
				short num3 = num;
				num = (short)1410924545;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedConsoletteFatalError_A37233.Editable = value;
			}
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x06006170 RID: 24944 RVA: 0x00579420 File Offset: 0x00577620
		internal string RadErgoWideAdvancedConsoletteFatalError_A37233_UILabel
		{
			get
			{
				short num = (short)460898149;
				short num2 = num;
				num = (short)1682489189;
				switch (num2 == num)
				{
				}
				num = (short)323158016;
				if (num != 0)
				{
				}
				num = (short)1291255808;
				short num3 = num;
				num = (short)1512308737;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedConsoletteFatalError_A37233.UIName;
			}
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x06006171 RID: 24945 RVA: 0x005794D4 File Offset: 0x005776D4
		// (set) Token: 0x06006172 RID: 24946 RVA: 0x00579588 File Offset: 0x00577788
		internal bool RadErgoWideAdvancedConsoletteFatalError_A37233_HiddenStatic
		{
			get
			{
				short num = (short)547956982;
				short num2 = num;
				num = (short)515320054;
				switch (num2 == num)
				{
				}
				num = (short)2085945345;
				if (num != 0)
				{
				}
				num = (short)1051066368;
				short num3 = num;
				num = (short)2075262976;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedConsoletteFatalError_A37233.HiddenStatic;
			}
			set
			{
				short num = (short)1546059777;
				if (num != 0)
				{
				}
				num = (short)1199981793;
				short num2 = num;
				num = (short)748111073;
				switch (num2 == num)
				{
				}
				num = (short)1072365568;
				short num3 = num;
				num = (short)1938817024;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedConsoletteFatalError_A37233.HiddenStatic = value;
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x06006173 RID: 24947 RVA: 0x0057963C File Offset: 0x0057783C
		// (set) Token: 0x06006174 RID: 24948 RVA: 0x005796F0 File Offset: 0x005778F0
		internal bool RadErgoWideAdvancedConsoletteFatalError_A37233_HiddenDynamic
		{
			get
			{
				short num = (short)1022694850;
				short num2 = num;
				num = (short)2001540546;
				switch (num2 == num)
				{
				}
				num = (short)2140078081;
				if (num != 0)
				{
				}
				num = (short)1184497664;
				short num3 = num;
				num = (short)614596608;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedConsoletteFatalError_A37233.HiddenDynamic;
			}
			set
			{
				short num = (short)1453195265;
				if (num != 0)
				{
				}
				num = (short)1575663592;
				short num2 = num;
				num = (short)583383016;
				switch (num2 == num)
				{
				}
				num = (short)1048117248;
				short num3 = num;
				num = (short)1610416128;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedConsoletteFatalError_A37233.HiddenDynamic = value;
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x06006175 RID: 24949 RVA: 0x005797A8 File Offset: 0x005779A8
		public bool RadErgoWideAdvancedConsoletteFatalError_A37233_HasDiffs
		{
			get
			{
				short num = (short)395984716;
				short num2 = num;
				num = (short)1601716044;
				switch (num2 == num)
				{
				}
				num = (short)448397313;
				if (num != 0)
				{
				}
				num = (short)605814784;
				short num3 = num;
				num = (short)810090496;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedConsoletteFatalError_A37233._HasDiffs;
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x06006176 RID: 24950 RVA: 0x0057985C File Offset: 0x00577A5C
		// (set) Token: 0x06006177 RID: 24951 RVA: 0x00579910 File Offset: 0x00577B10
		public int RadErgoWideAdvancedNumberofZoneBanks_A37256Value
		{
			get
			{
				short num = (short)2120655969;
				short num2 = num;
				num = (short)153724001;
				switch (num2 == num)
				{
				}
				num = (short)852754432;
				if (num != 0)
				{
				}
				num = (short)127795200;
				short num3 = num;
				num = (short)1447034881;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.Value;
			}
			set
			{
				short num = (short)1241972737;
				if (num != 0)
				{
				}
				num = (short)1731894130;
				short num2 = num;
				num = (short)210213746;
				switch (num2 == num)
				{
				}
				num = (short)1116405760;
				short num3 = num;
				num = (short)1115947008;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.Value = value;
			}
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x06006178 RID: 24952 RVA: 0x005799C4 File Offset: 0x00577BC4
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAdvancedNumberofZoneBanks_A37256
		{
			get
			{
				short num = (short)1517549628;
				short num2 = num;
				num = (short)1944451132;
				switch (num2 == num)
				{
				}
				num = (short)1167392768;
				if (num != 0)
				{
				}
				num = (short)175636480;
				short num3 = num;
				num = (short)120782849;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256;
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x06006179 RID: 24953 RVA: 0x00579A78 File Offset: 0x00577C78
		// (set) Token: 0x0600617A RID: 24954 RVA: 0x00579B2C File Offset: 0x00577D2C
		public string RadErgoWideAdvancedNumberofZoneBanks_A37256_UIValue
		{
			get
			{
				short num = (short)923915217;
				short num2 = num;
				num = (short)669438929;
				switch (num2 == num)
				{
				}
				num = (short)702021632;
				if (num != 0)
				{
				}
				num = (short)80805888;
				short num3 = num;
				num = (short)108789761;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.UIValue;
			}
			set
			{
				short num = (short)1300258445;
				short num2 = num;
				num = (short)1410358925;
				switch (num2 == num)
				{
				}
				num = (short)1384972289;
				if (num != 0)
				{
				}
				num = (short)1521942528;
				short num3 = num;
				num = (short)1218314240;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.UIValue = value;
			}
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600617B RID: 24955 RVA: 0x00579BE4 File Offset: 0x00577DE4
		// (set) Token: 0x0600617C RID: 24956 RVA: 0x00579C98 File Offset: 0x00577E98
		internal int RadErgoWideAdvancedNumberofZoneBanks_A37256Min
		{
			get
			{
				short num = (short)462344316;
				short num2 = num;
				num = (short)1688850556;
				switch (num2 == num)
				{
				}
				num = (short)628752385;
				if (num != 0)
				{
				}
				num = (short)2078474240;
				short num3 = num;
				num = (short)429195264;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.Min;
			}
			set
			{
				short num = (short)779550721;
				if (num != 0)
				{
				}
				num = (short)645718804;
				short num2 = num;
				num = (short)897377044;
				switch (num2 == num)
				{
				}
				num = (short)64684032;
				short num3 = num;
				num = (short)1679228928;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.Min = value;
			}
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600617D RID: 24957 RVA: 0x00579D4C File Offset: 0x00577F4C
		// (set) Token: 0x0600617E RID: 24958 RVA: 0x00579E00 File Offset: 0x00578000
		internal int RadErgoWideAdvancedNumberofZoneBanks_A37256Max
		{
			get
			{
				short num = (short)1253898556;
				short num2 = num;
				num = (short)439351612;
				switch (num2 == num)
				{
				}
				num = (short)946470913;
				if (num != 0)
				{
				}
				num = (short)961150976;
				short num3 = num;
				num = (short)2035875840;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.Max;
			}
			set
			{
				short num = (short)2030239745;
				if (num != 0)
				{
				}
				num = (short)326357203;
				short num2 = num;
				num = (short)2077413587;
				switch (num2 == num)
				{
				}
				num = (short)213843968;
				short num3 = num;
				num = (short)669908992;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.Max = value;
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600617F RID: 24959 RVA: 0x00579EB8 File Offset: 0x005780B8
		// (set) Token: 0x06006180 RID: 24960 RVA: 0x00579F6C File Offset: 0x0057816C
		internal int RadErgoWideAdvancedNumberofZoneBanks_A37256Step
		{
			get
			{
				short num = (short)361942742;
				short num2 = num;
				num = (short)1963642582;
				switch (num2 == num)
				{
				}
				num = (short)2071330817;
				if (num != 0)
				{
				}
				num = (short)2098790400;
				short num3 = num;
				num = (short)787152896;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.StepSize;
			}
			set
			{
				short num = (short)168135968;
				short num2 = num;
				num = (short)1608551712;
				switch (num2 == num)
				{
				}
				num = (short)829751297;
				if (num != 0)
				{
				}
				num = (short)1683488768;
				short num3 = num;
				num = (short)1100939264;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.StepSize = value;
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x06006181 RID: 24961 RVA: 0x0057A024 File Offset: 0x00578224
		// (set) Token: 0x06006182 RID: 24962 RVA: 0x0057A0DC File Offset: 0x005782DC
		public bool RadErgoWideAdvancedNumberofZoneBanks_A37256_Applicable
		{
			get
			{
				short num = (short)972226561;
				if (num != 0)
				{
				}
				num = (short)1943434020;
				short num2 = num;
				num = (short)114914084;
				switch (num2 == num)
				{
				}
				num = (short)391970816;
				short num3 = num;
				num = (short)462225408;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.Applicable;
			}
			set
			{
				short num = (short)813236225;
				if (num != 0)
				{
				}
				num = (short)1420035474;
				short num2 = num;
				num = (short)871105938;
				switch (num2 == num)
				{
				}
				num = (short)650641408;
				short num3 = num;
				num = (short)731185152;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.Applicable = value;
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x06006183 RID: 24963 RVA: 0x0057A198 File Offset: 0x00578398
		// (set) Token: 0x06006184 RID: 24964 RVA: 0x0057A250 File Offset: 0x00578450
		public bool RadErgoWideAdvancedNumberofZoneBanks_A37256_Valid
		{
			get
			{
				short num = (short)1686262929;
				short num2 = num;
				num = (short)1885754513;
				switch (num2 == num)
				{
				}
				num = (short)97976320;
				if (num != 0)
				{
				}
				num = (short)1319960576;
				short num3 = num;
				num = (short)1031667713;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.Valid;
			}
			set
			{
				short num = (short)1907511467;
				short num2 = num;
				num = (short)1525567659;
				switch (num2 == num)
				{
				}
				num = (short)1353777153;
				if (num != 0)
				{
				}
				num = (short)40435712;
				short num3 = num;
				num = (short)227016704;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.Valid = value;
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x06006185 RID: 24965 RVA: 0x0057A308 File Offset: 0x00578508
		// (set) Token: 0x06006186 RID: 24966 RVA: 0x0057A3BC File Offset: 0x005785BC
		public bool RadErgoWideAdvancedNumberofZoneBanks_A37256_Visible
		{
			get
			{
				short num = (short)2034416822;
				short num2 = num;
				num = (short)1111932086;
				switch (num2 == num)
				{
				}
				num = (short)82837505;
				if (num != 0)
				{
				}
				num = (short)24641536;
				short num3 = num;
				num = (short)1425866752;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.Visible;
			}
			set
			{
				short num = (short)719761508;
				short num2 = num;
				num = (short)1166585956;
				switch (num2 == num)
				{
				}
				num = (short)2072838145;
				if (num != 0)
				{
				}
				num = (short)1781202944;
				short num3 = num;
				num = (short)1090977792;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.Visible = value;
			}
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x06006187 RID: 24967 RVA: 0x0057A470 File Offset: 0x00578670
		// (set) Token: 0x06006188 RID: 24968 RVA: 0x0057A528 File Offset: 0x00578728
		public bool RadErgoWideAdvancedNumberofZoneBanks_A37256_Editable
		{
			get
			{
				short num = (short)2140798977;
				if (num != 0)
				{
				}
				num = (short)2032808841;
				short num2 = num;
				num = (short)1137587081;
				switch (num2 == num)
				{
				}
				num = (short)1242955776;
				short num3 = num;
				num = (short)1966080;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.Editable;
			}
			set
			{
				short num = (short)1607606530;
				short num2 = num;
				num = (short)1738219778;
				switch (num2 == num)
				{
				}
				num = (short)893976576;
				if (num != 0)
				{
				}
				num = (short)1748172800;
				short num3 = num;
				num = (short)1261699073;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.Editable = value;
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x06006189 RID: 24969 RVA: 0x0057A5E0 File Offset: 0x005787E0
		internal string RadErgoWideAdvancedNumberofZoneBanks_A37256_UILabel
		{
			get
			{
				short num = (short)1817045184;
				short num2 = num;
				num = (short)1461184704;
				switch (num2 == num)
				{
				}
				num = (short)1373437952;
				if (num != 0)
				{
				}
				num = (short)880476160;
				short num3 = num;
				num = (short)1670578177;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.UIName;
			}
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600618A RID: 24970 RVA: 0x0057A690 File Offset: 0x00578890
		// (set) Token: 0x0600618B RID: 24971 RVA: 0x0057A744 File Offset: 0x00578944
		internal bool RadErgoWideAdvancedNumberofZoneBanks_A37256_HiddenStatic
		{
			get
			{
				short num = (short)1246349645;
				short num2 = num;
				num = (short)614189389;
				switch (num2 == num)
				{
				}
				num = (short)2141192193;
				if (num != 0)
				{
				}
				num = (short)1413939200;
				short num3 = num;
				num = (short)915931136;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.HiddenStatic;
			}
			set
			{
				short num = (short)983105537;
				if (num != 0)
				{
				}
				num = (short)322567282;
				short num2 = num;
				num = (short)727448690;
				switch (num2 == num)
				{
				}
				num = (short)535429120;
				short num3 = num;
				num = (short)2083454976;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.HiddenStatic = value;
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600618C RID: 24972 RVA: 0x0057A7FC File Offset: 0x005789FC
		// (set) Token: 0x0600618D RID: 24973 RVA: 0x0057A8B0 File Offset: 0x00578AB0
		internal bool RadErgoWideAdvancedNumberofZoneBanks_A37256_HiddenDynamic
		{
			get
			{
				short num = (short)1629205878;
				short num2 = num;
				num = (short)2098705782;
				switch (num2 == num)
				{
				}
				num = (short)718536704;
				if (num != 0)
				{
				}
				num = (short)847642624;
				short num3 = num;
				num = (short)766902273;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256.HiddenDynamic;
			}
			set
			{
				short num = (short)535625729;
				if (num != 0)
				{
				}
				num = (short)503494381;
				short num2 = num;
				num = (short)306427629;
				switch (num2 == num)
				{
				}
				num = (short)259391488;
				short num3 = num;
				num = (short)1138360320;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedNumberofZoneBanks_A37256.HiddenDynamic = value;
			}
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600618E RID: 24974 RVA: 0x0057A968 File Offset: 0x00578B68
		public bool RadErgoWideAdvancedNumberofZoneBanks_A37256_HasDiffs
		{
			get
			{
				short num = (short)2130116609;
				if (num != 0)
				{
				}
				num = (short)1177842356;
				short num2 = num;
				num = (short)1643147956;
				switch (num2 == num)
				{
				}
				num = (short)1636958208;
				short num3 = num;
				num = (short)2070478848;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedNumberofZoneBanks_A37256._HasDiffs;
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600618F RID: 24975 RVA: 0x0057AA1C File Offset: 0x00578C1C
		// (set) Token: 0x06006190 RID: 24976 RVA: 0x0057AACC File Offset: 0x00578CCC
		public int RadErgoWideAdvancedZoneBankOperation_A37543Value
		{
			get
			{
				short num = (short)1120847753;
				short num2 = num;
				num = (short)1647429513;
				switch (num2 == num)
				{
				}
				num = (short)1559166977;
				if (num != 0)
				{
				}
				num = (short)683343872;
				short num3 = num;
				num = (short)1385168896;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543.Value;
			}
			set
			{
				short num = (short)1788622088;
				short num2 = num;
				num = (short)1451177224;
				switch (num2 == num)
				{
				}
				num = (short)1450835969;
				if (num != 0)
				{
				}
				num = (short)1092091904;
				short num3 = num;
				num = (short)35061760;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedZoneBankOperation_A37543.Value = value;
			}
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x06006191 RID: 24977 RVA: 0x0057AB84 File Offset: 0x00578D84
		// (set) Token: 0x06006192 RID: 24978 RVA: 0x0057AC3C File Offset: 0x00578E3C
		public string RadErgoWideAdvancedZoneBankOperation_A37543_UIValue
		{
			get
			{
				short num = (short)1839009463;
				short num2 = num;
				num = (short)1854541495;
				switch (num2 == num)
				{
				}
				num = (short)1490747393;
				if (num != 0)
				{
				}
				num = (short)1651638272;
				short num3 = num;
				num = (short)77332480;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543.UIValue;
			}
			set
			{
				short num = (short)2078670849;
				if (num != 0)
				{
				}
				num = (short)1434141926;
				short num2 = num;
				num = (short)1189823718;
				switch (num2 == num)
				{
				}
				num = (short)626393088;
				short num3 = num;
				num = (short)1746468864;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedZoneBankOperation_A37543.UIValue = value;
			}
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x06006193 RID: 24979 RVA: 0x0057ACF4 File Offset: 0x00578EF4
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedZoneBankOperation_A37543
		{
			get
			{
				short num = (short)749025485;
				short num2 = num;
				num = (short)64501965;
				switch (num2 == num)
				{
				}
				num = (short)1614348289;
				if (num != 0)
				{
				}
				num = (short)940965888;
				short num3 = num;
				num = (short)906887168;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543;
			}
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x06006194 RID: 24980 RVA: 0x0057ADA4 File Offset: 0x00578FA4
		// (set) Token: 0x06006195 RID: 24981 RVA: 0x0057AE58 File Offset: 0x00579058
		public bool RadErgoWideAdvancedZoneBankOperation_A37543_Applicable
		{
			get
			{
				short num = (short)1110867869;
				short num2 = num;
				num = (short)1157005213;
				switch (num2 == num)
				{
				}
				num = (short)1423704065;
				if (num != 0)
				{
				}
				num = (short)314245120;
				short num3 = num;
				num = (short)215941120;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543.Applicable;
			}
			set
			{
				short num = (short)2062841941;
				short num2 = num;
				num = (short)727349333;
				switch (num2 == num)
				{
				}
				num = (short)1075904513;
				if (num != 0)
				{
				}
				num = (short)1631518720;
				short num3 = num;
				num = (short)975044608;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedZoneBankOperation_A37543.Applicable = value;
			}
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x06006196 RID: 24982 RVA: 0x0057AF0C File Offset: 0x0057910C
		// (set) Token: 0x06006197 RID: 24983 RVA: 0x0057AFC0 File Offset: 0x005791C0
		public bool RadErgoWideAdvancedZoneBankOperation_A37543_Valid
		{
			get
			{
				short num = (short)158950421;
				short num2 = num;
				num = (short)38691861;
				switch (num2 == num)
				{
				}
				num = (short)617676801;
				if (num != 0)
				{
				}
				num = (short)656867328;
				short num3 = num;
				num = (short)1545207808;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543.Valid;
			}
			set
			{
				short num = (short)994429593;
				short num2 = num;
				num = (short)328190617;
				switch (num2 == num)
				{
				}
				num = (short)1792016384;
				if (num != 0)
				{
				}
				num = (short)371523584;
				short num3 = num;
				num = (short)722403329;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedZoneBankOperation_A37543.Valid = value;
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x06006198 RID: 24984 RVA: 0x0057B074 File Offset: 0x00579274
		// (set) Token: 0x06006199 RID: 24985 RVA: 0x0057B128 File Offset: 0x00579328
		public bool RadErgoWideAdvancedZoneBankOperation_A37543_Visible
		{
			get
			{
				short num = (short)1732526369;
				short num2 = num;
				num = (short)168640801;
				switch (num2 == num)
				{
				}
				num = (short)1040777217;
				if (num != 0)
				{
				}
				num = (short)1897005056;
				short num3 = num;
				num = (short)694026240;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543.Visible;
			}
			set
			{
				short num = (short)1781759696;
				short num2 = num;
				num = (short)1781038800;
				switch (num2 == num)
				{
				}
				num = (short)83165185;
				if (num != 0)
				{
				}
				num = (short)848232448;
				short num3 = num;
				num = (short)1047527424;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedZoneBankOperation_A37543.Visible = value;
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600619A RID: 24986 RVA: 0x0057B1DC File Offset: 0x005793DC
		// (set) Token: 0x0600619B RID: 24987 RVA: 0x0057B290 File Offset: 0x00579490
		public bool RadErgoWideAdvancedZoneBankOperation_A37543_Editable
		{
			get
			{
				short num = (short)1459900553;
				short num2 = num;
				num = (short)686837897;
				switch (num2 == num)
				{
				}
				num = (short)1109590017;
				if (num != 0)
				{
				}
				num = (short)1040580608;
				short num3 = num;
				num = (short)983760896;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543.Editable;
			}
			set
			{
				short num = (short)1574488307;
				short num2 = num;
				num = (short)1285474547;
				switch (num2 == num)
				{
				}
				num = (short)548864001;
				if (num != 0)
				{
				}
				num = (short)440860672;
				short num3 = num;
				num = (short)341180416;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedZoneBankOperation_A37543.Editable = value;
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600619C RID: 24988 RVA: 0x0057B348 File Offset: 0x00579548
		internal string RadErgoWideAdvancedZoneBankOperation_A37543_UILabel
		{
			get
			{
				short num = (short)889800355;
				short num2 = num;
				num = (short)1483753123;
				switch (num2 == num)
				{
				}
				num = (short)1084817408;
				if (num != 0)
				{
				}
				num = (short)1248002048;
				short num3 = num;
				num = (short)343539713;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543.UIName;
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600619D RID: 24989 RVA: 0x0057B400 File Offset: 0x00579600
		// (set) Token: 0x0600619E RID: 24990 RVA: 0x0057B4B4 File Offset: 0x005796B4
		internal bool RadErgoWideAdvancedZoneBankOperation_A37543_HiddenStatic
		{
			get
			{
				short num = (short)323674664;
				short num2 = num;
				num = (short)2037703208;
				switch (num2 == num)
				{
				}
				num = (short)2055929857;
				if (num != 0)
				{
				}
				num = (short)797573120;
				short num3 = num;
				num = (short)1441660928;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543.HiddenStatic;
			}
			set
			{
				short num = (short)816513025;
				if (num != 0)
				{
				}
				num = (short)480190977;
				short num2 = num;
				num = (short)210117121;
				switch (num2 == num)
				{
				}
				num = (short)1178402816;
				short num3 = num;
				num = (short)734199808;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedZoneBankOperation_A37543.HiddenStatic = value;
			}
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600619F RID: 24991 RVA: 0x0057B568 File Offset: 0x00579768
		// (set) Token: 0x060061A0 RID: 24992 RVA: 0x0057B618 File Offset: 0x00579818
		internal bool RadErgoWideAdvancedZoneBankOperation_A37543_HiddenDynamic
		{
			get
			{
				short num = (short)65624371;
				short num2 = num;
				num = (short)507926835;
				switch (num2 == num)
				{
				}
				num = (short)434962433;
				if (num != 0)
				{
				}
				num = (short)1928003584;
				short num3 = num;
				num = (short)1508704256;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543.HiddenDynamic;
			}
			set
			{
				short num = (short)1602564520;
				short num2 = num;
				num = (short)1242444200;
				switch (num2 == num)
				{
				}
				num = (short)1948778497;
				if (num != 0)
				{
				}
				num = (short)1730281472;
				short num3 = num;
				num = (short)1239941120;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedZoneBankOperation_A37543.HiddenDynamic = value;
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x060061A1 RID: 24993 RVA: 0x0057B6D0 File Offset: 0x005798D0
		public bool RadErgoWideAdvancedZoneBankOperation_A37543_HasDiffs
		{
			get
			{
				short num = (short)981185736;
				short num2 = num;
				num = (short)343127240;
				switch (num2 == num)
				{
				}
				num = (short)595853313;
				if (num != 0)
				{
				}
				num = (short)1664679936;
				short num3 = num;
				num = (short)456261632;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedZoneBankOperation_A37543._HasDiffs;
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x060061A2 RID: 24994 RVA: 0x0057B788 File Offset: 0x00579988
		// (set) Token: 0x060061A3 RID: 24995 RVA: 0x0057B83C File Offset: 0x00579A3C
		public int RadErgoWideAdvancedShortKeypressDurationms_A9125Value
		{
			get
			{
				short num = (short)1000525240;
				short num2 = num;
				num = (short)1965608376;
				switch (num2 == num)
				{
				}
				num = (short)1201078272;
				if (num != 0)
				{
				}
				num = (short)1353449472;
				short num3 = num;
				num = (short)1065222145;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.Value;
			}
			set
			{
				short num = (short)791527098;
				short num2 = num;
				num = (short)798408378;
				switch (num2 == num)
				{
				}
				num = (short)1633419265;
				if (num != 0)
				{
				}
				num = (short)578813952;
				short num3 = num;
				num = (short)204800000;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.Value = value;
			}
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x060061A4 RID: 24996 RVA: 0x0057B8F4 File Offset: 0x00579AF4
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAdvancedShortKeypressDurationms_A9125
		{
			get
			{
				short num = (short)1338445649;
				short num2 = num;
				num = (short)17043281;
				switch (num2 == num)
				{
				}
				num = (short)1718878209;
				if (num != 0)
				{
				}
				num = (short)2004615168;
				short num3 = num;
				num = (short)1206190080;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125;
			}
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x060061A5 RID: 24997 RVA: 0x0057B9A8 File Offset: 0x00579BA8
		// (set) Token: 0x060061A6 RID: 24998 RVA: 0x0057BA5C File Offset: 0x00579C5C
		public string RadErgoWideAdvancedShortKeypressDurationms_A9125_UIValue
		{
			get
			{
				short num = (short)283721158;
				short num2 = num;
				num = (short)1773419974;
				switch (num2 == num)
				{
				}
				num = (short)1832058881;
				if (num != 0)
				{
				}
				num = (short)835911680;
				short num3 = num;
				num = (short)2139029504;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.UIValue;
			}
			set
			{
				short num = (short)1422838779;
				short num2 = num;
				num = (short)1945160699;
				switch (num2 == num)
				{
				}
				num = (short)1684602881;
				if (num != 0)
				{
				}
				num = (short)1095827456;
				short num3 = num;
				num = (short)5636096;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.UIValue = value;
			}
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x060061A7 RID: 24999 RVA: 0x0057BB10 File Offset: 0x00579D10
		// (set) Token: 0x060061A8 RID: 25000 RVA: 0x0057BBC4 File Offset: 0x00579DC4
		internal int RadErgoWideAdvancedShortKeypressDurationms_A9125Min
		{
			get
			{
				short num = (short)234488495;
				short num2 = num;
				num = (short)439812783;
				switch (num2 == num)
				{
				}
				num = (short)1203044353;
				if (num != 0)
				{
				}
				num = (short)1395654656;
				short num3 = num;
				num = (short)1958674432;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.Min;
			}
			set
			{
				short num = (short)1740863634;
				short num2 = num;
				num = (short)227965074;
				switch (num2 == num)
				{
				}
				num = (short)1388511233;
				if (num != 0)
				{
				}
				num = (short)417267712;
				short num3 = num;
				num = (short)940769280;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.Min = value;
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x060061A9 RID: 25001 RVA: 0x0057BC7C File Offset: 0x00579E7C
		// (set) Token: 0x060061AA RID: 25002 RVA: 0x0057BD30 File Offset: 0x00579F30
		internal int RadErgoWideAdvancedShortKeypressDurationms_A9125Max
		{
			get
			{
				short num = (short)1522728961;
				if (num != 0)
				{
				}
				num = (short)842862936;
				short num2 = num;
				num = (short)1064702296;
				switch (num2 == num)
				{
				}
				num = (short)1296433152;
				short num3 = num;
				num = (short)1000341504;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.Max;
			}
			set
			{
				short num = (short)1513419967;
				short num2 = num;
				num = (short)304280767;
				switch (num2 == num)
				{
				}
				num = (short)1372979200;
				if (num != 0)
				{
				}
				num = (short)1722089472;
				short num3 = num;
				num = (short)538968065;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.Max = value;
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x060061AB RID: 25003 RVA: 0x0057BDE4 File Offset: 0x00579FE4
		// (set) Token: 0x060061AC RID: 25004 RVA: 0x0057BE98 File Offset: 0x0057A098
		internal int RadErgoWideAdvancedShortKeypressDurationms_A9125Step
		{
			get
			{
				short num = (short)627494695;
				short num2 = num;
				num = (short)1578225447;
				switch (num2 == num)
				{
				}
				num = (short)190840833;
				if (num != 0)
				{
				}
				num = (short)549650432;
				short num3 = num;
				num = (short)1592262656;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.StepSize;
			}
			set
			{
				short num = (short)66256897;
				if (num != 0)
				{
				}
				num = (short)1245148671;
				short num2 = num;
				num = (short)2123789823;
				switch (num2 == num)
				{
				}
				num = (short)1308753920;
				short num3 = num;
				num = (short)1349320704;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.StepSize = value;
			}
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x060061AD RID: 25005 RVA: 0x0057BF4C File Offset: 0x0057A14C
		// (set) Token: 0x060061AE RID: 25006 RVA: 0x0057C000 File Offset: 0x0057A200
		public bool RadErgoWideAdvancedShortKeypressDurationms_A9125_Applicable
		{
			get
			{
				short num = (short)725133295;
				short num2 = num;
				num = (short)106801135;
				switch (num2 == num)
				{
				}
				num = (short)828571648;
				if (num != 0)
				{
				}
				num = (short)1852440576;
				short num3 = num;
				num = (short)435552257;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.Applicable;
			}
			set
			{
				short num = (short)1301472764;
				short num2 = num;
				num = (short)156952060;
				switch (num2 == num)
				{
				}
				num = (short)100401153;
				if (num != 0)
				{
				}
				num = (short)1961951232;
				short num3 = num;
				num = (short)1296891904;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.Applicable = value;
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x060061AF RID: 25007 RVA: 0x0057C0B8 File Offset: 0x0057A2B8
		// (set) Token: 0x060061B0 RID: 25008 RVA: 0x0057C16C File Offset: 0x0057A36C
		public bool RadErgoWideAdvancedShortKeypressDurationms_A9125_Valid
		{
			get
			{
				short num = (short)1183859023;
				short num2 = num;
				num = (short)388120911;
				switch (num2 == num)
				{
				}
				num = (short)2064449536;
				if (num != 0)
				{
				}
				num = (short)977600512;
				short num3 = num;
				num = (short)394526721;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.Valid;
			}
			set
			{
				short num = (short)1581408540;
				short num2 = num;
				num = (short)751722780;
				switch (num2 == num)
				{
				}
				num = (short)737017856;
				if (num != 0)
				{
				}
				num = (short)1489174528;
				short num3 = num;
				num = (short)2042560513;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.Valid = value;
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x060061B1 RID: 25009 RVA: 0x0057C220 File Offset: 0x0057A420
		// (set) Token: 0x060061B2 RID: 25010 RVA: 0x0057C2D4 File Offset: 0x0057A4D4
		public bool RadErgoWideAdvancedShortKeypressDurationms_A9125_Visible
		{
			get
			{
				short num = (short)704091908;
				short num2 = num;
				num = (short)1229821700;
				switch (num2 == num)
				{
				}
				num = (short)1180237824;
				if (num != 0)
				{
				}
				num = (short)601948160;
				short num3 = num;
				num = (short)100073473;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.Visible;
			}
			set
			{
				short num = (short)467311476;
				short num2 = num;
				num = (short)582327156;
				switch (num2 == num)
				{
				}
				num = (short)540672001;
				if (num != 0)
				{
				}
				num = (short)2026504192;
				short num3 = num;
				num = (short)1631191040;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.Visible = value;
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x060061B3 RID: 25011 RVA: 0x0057C388 File Offset: 0x0057A588
		// (set) Token: 0x060061B4 RID: 25012 RVA: 0x0057C43C File Offset: 0x0057A63C
		public bool RadErgoWideAdvancedShortKeypressDurationms_A9125_Editable
		{
			get
			{
				short num = (short)2101990493;
				short num2 = num;
				num = (short)240833629;
				switch (num2 == num)
				{
				}
				num = (short)653328385;
				if (num != 0)
				{
				}
				num = (short)26738688;
				short num3 = num;
				num = (short)293339136;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.Editable;
			}
			set
			{
				short num = (short)1457697877;
				short num2 = num;
				num = (short)1467266133;
				switch (num2 == num)
				{
				}
				num = (short)557318145;
				if (num != 0)
				{
				}
				num = (short)790036480;
				short num3 = num;
				num = (short)1470562304;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.Editable = value;
			}
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x060061B5 RID: 25013 RVA: 0x0057C4F4 File Offset: 0x0057A6F4
		internal string RadErgoWideAdvancedShortKeypressDurationms_A9125_UILabel
		{
			get
			{
				short num = (short)1219926022;
				short num2 = num;
				num = (short)120494086;
				switch (num2 == num)
				{
				}
				num = (short)1046937601;
				if (num != 0)
				{
				}
				num = (short)190513152;
				short num3 = num;
				num = (short)1586692096;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.UIName;
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x060061B6 RID: 25014 RVA: 0x0057C5A4 File Offset: 0x0057A7A4
		// (set) Token: 0x060061B7 RID: 25015 RVA: 0x0057C658 File Offset: 0x0057A858
		internal bool RadErgoWideAdvancedShortKeypressDurationms_A9125_HiddenStatic
		{
			get
			{
				short num = (short)1492209465;
				short num2 = num;
				num = (short)528699193;
				switch (num2 == num)
				{
				}
				num = (short)684982273;
				if (num != 0)
				{
				}
				num = (short)879558656;
				short num3 = num;
				num = (short)1576599552;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.HiddenStatic;
			}
			set
			{
				short num = (short)74842113;
				if (num != 0)
				{
				}
				num = (short)1635652811;
				short num2 = num;
				num = (short)909776075;
				switch (num2 == num)
				{
				}
				num = (short)1748369408;
				short num3 = num;
				num = (short)1251934208;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.HiddenStatic = value;
			}
		}

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x060061B8 RID: 25016 RVA: 0x0057C710 File Offset: 0x0057A910
		// (set) Token: 0x060061B9 RID: 25017 RVA: 0x0057C7C4 File Offset: 0x0057A9C4
		internal bool RadErgoWideAdvancedShortKeypressDurationms_A9125_HiddenDynamic
		{
			get
			{
				short num = (short)1558449934;
				short num2 = num;
				num = (short)226430734;
				switch (num2 == num)
				{
				}
				num = (short)806813696;
				if (num != 0)
				{
				}
				num = (short)601358336;
				short num3 = num;
				num = (short)1595342849;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125.HiddenDynamic;
			}
			set
			{
				short num = (short)70990585;
				short num2 = num;
				num = (short)117324537;
				switch (num2 == num)
				{
				}
				num = (short)1202454529;
				if (num != 0)
				{
				}
				num = (short)1147273216;
				short num3 = num;
				num = (short)1874788352;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationms_A9125.HiddenDynamic = value;
			}
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x060061BA RID: 25018 RVA: 0x0057C878 File Offset: 0x0057AA78
		public bool RadErgoWideAdvancedShortKeypressDurationms_A9125_HasDiffs
		{
			get
			{
				short num = (short)779228016;
				short num2 = num;
				num = (short)2081559408;
				switch (num2 == num)
				{
				}
				num = (short)449314817;
				if (num != 0)
				{
				}
				num = (short)303104000;
				short num3 = num;
				num = (short)360841216;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationms_A9125._HasDiffs;
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x060061BB RID: 25019 RVA: 0x0057C92C File Offset: 0x0057AB2C
		// (set) Token: 0x060061BC RID: 25020 RVA: 0x0057C9E0 File Offset: 0x0057ABE0
		public int RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126Value
		{
			get
			{
				short num = (short)2055721435;
				short num2 = num;
				num = (short)103076315;
				switch (num2 == num)
				{
				}
				num = (short)1203634176;
				if (num != 0)
				{
				}
				num = (short)486735872;
				short num3 = num;
				num = (short)36110337;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Value;
			}
			set
			{
				short num = (short)151912449;
				if (num != 0)
				{
				}
				num = (short)791505965;
				short num2 = num;
				num = (short)682912813;
				switch (num2 == num)
				{
				}
				num = (short)1758199808;
				short num3 = num;
				num = (short)1285226496;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Value = value;
			}
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x060061BD RID: 25021 RVA: 0x0057CA94 File Offset: 0x0057AC94
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126
		{
			get
			{
				short num = (short)773449584;
				short num2 = num;
				num = (short)1336207216;
				switch (num2 == num)
				{
				}
				num = (short)1760624641;
				if (num != 0)
				{
				}
				num = (short)1814822912;
				short num3 = num;
				num = (short)1299316736;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126;
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x060061BE RID: 25022 RVA: 0x0057CB48 File Offset: 0x0057AD48
		// (set) Token: 0x060061BF RID: 25023 RVA: 0x0057CBF8 File Offset: 0x0057ADF8
		public string RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_UIValue
		{
			get
			{
				short num = (short)1004863489;
				if (num != 0)
				{
				}
				num = (short)722267366;
				short num2 = num;
				num = (short)1402072294;
				switch (num2 == num)
				{
				}
				num = (short)30670848;
				short num3 = num;
				num = (short)2134048768;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.UIValue;
			}
			set
			{
				short num = (short)1690189529;
				short num2 = num;
				num = (short)569589465;
				switch (num2 == num)
				{
				}
				num = (short)53084161;
				if (num != 0)
				{
				}
				num = (short)180617216;
				short num3 = num;
				num = (short)1257832448;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.UIValue = value;
			}
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x060061C0 RID: 25024 RVA: 0x0057CCAC File Offset: 0x0057AEAC
		// (set) Token: 0x060061C1 RID: 25025 RVA: 0x0057CD60 File Offset: 0x0057AF60
		internal int RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126Min
		{
			get
			{
				short num = (short)280807103;
				short num2 = num;
				num = (short)129353407;
				switch (num2 == num)
				{
				}
				num = (short)481492992;
				if (num != 0)
				{
				}
				num = (short)1615527936;
				short num3 = num;
				num = (short)1119420417;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Min;
			}
			set
			{
				short num = (short)567898137;
				short num2 = num;
				num = (short)2051108889;
				switch (num2 == num)
				{
				}
				num = (short)1758461953;
				if (num != 0)
				{
				}
				num = (short)962854912;
				short num3 = num;
				num = (short)527761408;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Min = value;
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x060061C2 RID: 25026 RVA: 0x0057CE18 File Offset: 0x0057B018
		// (set) Token: 0x060061C3 RID: 25027 RVA: 0x0057CECC File Offset: 0x0057B0CC
		internal int RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126Max
		{
			get
			{
				short num = (short)2031536841;
				short num2 = num;
				num = (short)479578825;
				switch (num2 == num)
				{
				}
				num = (short)1836843009;
				if (num != 0)
				{
				}
				num = (short)1105723392;
				short num3 = num;
				num = (short)147128320;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Max;
			}
			set
			{
				short num = (short)2131951789;
				short num2 = num;
				num = (short)522256557;
				switch (num2 == num)
				{
				}
				num = (short)2080768001;
				if (num != 0)
				{
				}
				num = (short)1952645120;
				short num3 = num;
				num = (short)948764672;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Max = value;
			}
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x060061C4 RID: 25028 RVA: 0x0057CF84 File Offset: 0x0057B184
		// (set) Token: 0x060061C5 RID: 25029 RVA: 0x0057D038 File Offset: 0x0057B238
		internal int RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126Step
		{
			get
			{
				short num = (short)970123573;
				short num2 = num;
				num = (short)1630136629;
				switch (num2 == num)
				{
				}
				num = (short)745078785;
				if (num != 0)
				{
				}
				num = (short)1584398336;
				short num3 = num;
				num = (short)1893400576;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.StepSize;
			}
			set
			{
				short num = (short)2136781817;
				short num2 = num;
				num = (short)1706734585;
				switch (num2 == num)
				{
				}
				num = (short)898760705;
				if (num != 0)
				{
				}
				num = (short)2074214400;
				short num3 = num;
				num = (short)187629568;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.StepSize = value;
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x060061C6 RID: 25030 RVA: 0x0057D0EC File Offset: 0x0057B2EC
		// (set) Token: 0x060061C7 RID: 25031 RVA: 0x0057D1A0 File Offset: 0x0057B3A0
		public bool RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_Applicable
		{
			get
			{
				short num = (short)879427585;
				if (num != 0)
				{
				}
				num = (short)1147516983;
				short num2 = num;
				num = (short)772651063;
				switch (num2 == num)
				{
				}
				num = (short)1601175552;
				short num3 = num;
				num = (short)1389559808;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Applicable;
			}
			set
			{
				short num = (short)310507329;
				short num2 = num;
				num = (short)2105210689;
				switch (num2 == num)
				{
				}
				num = (short)1614020608;
				if (num != 0)
				{
				}
				num = (short)216662016;
				short num3 = num;
				num = (short)1649737729;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Applicable = value;
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x060061C8 RID: 25032 RVA: 0x0057D254 File Offset: 0x0057B454
		// (set) Token: 0x060061C9 RID: 25033 RVA: 0x0057D308 File Offset: 0x0057B508
		public bool RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_Valid
		{
			get
			{
				short num = (short)1314865851;
				short num2 = num;
				num = (short)1827750587;
				switch (num2 == num)
				{
				}
				num = (short)1097990144;
				if (num != 0)
				{
				}
				num = (short)627965952;
				short num3 = num;
				num = (short)789512193;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Valid;
			}
			set
			{
				short num = (short)654000695;
				short num2 = num;
				num = (short)839205431;
				switch (num2 == num)
				{
				}
				num = (short)90701825;
				if (num != 0)
				{
				}
				num = (short)2131951616;
				short num3 = num;
				num = (short)1989935104;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Valid = value;
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x060061CA RID: 25034 RVA: 0x0057D3BC File Offset: 0x0057B5BC
		// (set) Token: 0x060061CB RID: 25035 RVA: 0x0057D470 File Offset: 0x0057B670
		public bool RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_Visible
		{
			get
			{
				short num = (short)2098643003;
				short num2 = num;
				num = (short)881836091;
				switch (num2 == num)
				{
				}
				num = (short)1787428865;
				if (num != 0)
				{
				}
				num = (short)244383744;
				short num3 = num;
				num = (short)986513408;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Visible;
			}
			set
			{
				short num = (short)1225588737;
				if (num != 0)
				{
				}
				num = (short)127888964;
				short num2 = num;
				num = (short)1176792644;
				switch (num2 == num)
				{
				}
				num = (short)1554776064;
				short num3 = num;
				num = (short)1513750528;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Visible = value;
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x060061CC RID: 25036 RVA: 0x0057D528 File Offset: 0x0057B728
		// (set) Token: 0x060061CD RID: 25037 RVA: 0x0057D5DC File Offset: 0x0057B7DC
		public bool RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_Editable
		{
			get
			{
				short num = (short)1265009557;
				short num2 = num;
				num = (short)846365589;
				switch (num2 == num)
				{
				}
				num = (short)313917441;
				if (num != 0)
				{
				}
				num = (short)489357312;
				short num3 = num;
				num = (short)1380646912;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Editable;
			}
			set
			{
				short num = (short)1059427565;
				short num2 = num;
				num = (short)1825936621;
				switch (num2 == num)
				{
				}
				num = (short)1876623360;
				if (num != 0)
				{
				}
				num = (short)1266024448;
				short num3 = num;
				num = (short)1033568257;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.Editable = value;
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x060061CE RID: 25038 RVA: 0x0057D690 File Offset: 0x0057B890
		internal string RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_UILabel
		{
			get
			{
				short num = (short)1979864218;
				short num2 = num;
				num = (short)1188123802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1663434752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)541589504;
				if (num != 0)
				{
				}
				num = (short)2035548161;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.UIName;
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x060061CF RID: 25039 RVA: 0x0057D748 File Offset: 0x0057B948
		// (set) Token: 0x060061D0 RID: 25040 RVA: 0x0057D7FC File Offset: 0x0057B9FC
		internal bool RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_HiddenStatic
		{
			get
			{
				short num = (short)2002426162;
				short num2 = num;
				num = (short)1060411698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)146800640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1981022209;
				if (num != 0)
				{
				}
				num = (short)1608253440;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.HiddenStatic;
			}
			set
			{
				short num = (short)531601620;
				short num2 = num;
				num = (short)1235196116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1093337088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2110521345;
				if (num != 0)
				{
				}
				num = (short)1683750912;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.HiddenStatic = value;
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x060061D1 RID: 25041 RVA: 0x0057D8B0 File Offset: 0x0057BAB0
		// (set) Token: 0x060061D2 RID: 25042 RVA: 0x0057D964 File Offset: 0x0057BB64
		internal bool RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_HiddenDynamic
		{
			get
			{
				short num = (short)709300025;
				short num2 = num;
				num = (short)1789202233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)230096896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)48562177;
				if (num != 0)
				{
				}
				num = (short)1865285632;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.HiddenDynamic;
			}
			set
			{
				short num = (short)165963734;
				short num2 = num;
				num = (short)576284630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)191365120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)593428481;
				if (num != 0)
				{
				}
				num = (short)185663488;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126.HiddenDynamic = value;
			}
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x060061D3 RID: 25043 RVA: 0x0057DA1C File Offset: 0x0057BC1C
		public bool RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_HasDiffs
		{
			get
			{
				short num = (short)264875934;
				short num2 = num;
				num = (short)901427102;
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
				num = (short)919076864;
				if (num != 0)
				{
				}
				num = (short)1284374529;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126._HasDiffs;
			}
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x060061D4 RID: 25044 RVA: 0x0057DAD0 File Offset: 0x0057BCD0
		// (set) Token: 0x060061D5 RID: 25045 RVA: 0x0057DB84 File Offset: 0x0057BD84
		public int RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451Value
		{
			get
			{
				short num = (short)728254132;
				short num2 = num;
				num = (short)758597300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1043202048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)993525760;
				if (num != 0)
				{
				}
				num = (short)239665153;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Value;
			}
			set
			{
				short num = (short)361647523;
				short num2 = num;
				num = (short)1471958435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1026424832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1217069057;
				if (num != 0)
				{
				}
				num = (short)807010304;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Value = value;
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x060061D6 RID: 25046 RVA: 0x0057DC3C File Offset: 0x0057BE3C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451
		{
			get
			{
				short num = (short)1241228509;
				short num2 = num;
				num = (short)1108321501;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1503002624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1181024257;
				if (num != 0)
				{
				}
				num = (short)799997952;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451;
			}
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x060061D7 RID: 25047 RVA: 0x0057DCF0 File Offset: 0x0057BEF0
		// (set) Token: 0x060061D8 RID: 25048 RVA: 0x0057DDA4 File Offset: 0x0057BFA4
		public string RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_UIValue
		{
			get
			{
				short num = (short)2028575138;
				short num2 = num;
				num = (short)653302178;
				switch (num2 == num)
				{
				default:
				{
					num = (short)184352768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1168900096;
				if (num != 0)
				{
				}
				num = (short)1335099393;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.UIValue;
			}
			set
			{
				short num = (short)515964929;
				if (num != 0)
				{
				}
				num = (short)394133504;
				short num2 = num;
				num = (short)2077910415;
				short num3 = num;
				num = (short)1691379087;
				switch (num3 == num)
				{
				}
				num = (short)1420361728;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.UIValue = value;
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x060061D9 RID: 25049 RVA: 0x0057DE58 File Offset: 0x0057C058
		// (set) Token: 0x060061DA RID: 25050 RVA: 0x0057DF10 File Offset: 0x0057C110
		internal int RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451Min
		{
			get
			{
				short num = (short)1864612077;
				short num2 = num;
				num = (short)183744749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)537722880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1927938048;
				if (num != 0)
				{
				}
				num = (short)1574961153;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Min;
			}
			set
			{
				short num = (short)517582763;
				short num2 = num;
				num = (short)1785507755;
				switch (num2 == num)
				{
				default:
				{
					num = (short)377749504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)299433984;
				if (num != 0)
				{
				}
				num = (short)925564929;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Min = value;
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x0057DFC4 File Offset: 0x0057C1C4
		// (set) Token: 0x060061DC RID: 25052 RVA: 0x0057E074 File Offset: 0x0057C274
		internal int RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451Max
		{
			get
			{
				short num = (short)1014486104;
				short num2 = num;
				num = (short)1918686296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1694236672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1544749057;
				if (num != 0)
				{
				}
				num = (short)752943104;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Max;
			}
			set
			{
				short num = (short)1742940757;
				short num2 = num;
				num = (short)2079599189;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1017446400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)167247873;
				if (num != 0)
				{
				}
				num = (short)1661337600;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Max = value;
			}
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x060061DD RID: 25053 RVA: 0x0057E128 File Offset: 0x0057C328
		// (set) Token: 0x060061DE RID: 25054 RVA: 0x0057E1DC File Offset: 0x0057C3DC
		internal int RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451Step
		{
			get
			{
				short num = (short)1785854496;
				short num2 = num;
				num = (short)79034912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1820983296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)307232769;
				if (num != 0)
				{
				}
				num = (short)1133445120;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.StepSize;
			}
			set
			{
				short num = (short)121083521;
				short num2 = num;
				num = (short)382965377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)433324032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)483590145;
				if (num != 0)
				{
				}
				num = (short)111869952;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.StepSize = value;
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x060061DF RID: 25055 RVA: 0x0057E290 File Offset: 0x0057C490
		// (set) Token: 0x060061E0 RID: 25056 RVA: 0x0057E344 File Offset: 0x0057C544
		public bool RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_Applicable
		{
			get
			{
				short num = (short)2103415073;
				short num2 = num;
				num = (short)843157793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)848887808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1744502784;
				if (num != 0)
				{
				}
				num = (short)574619649;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Applicable;
			}
			set
			{
				short num = (short)1324885106;
				short num2 = num;
				num = (short)1051272306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)328794112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1380581376;
				if (num != 0)
				{
				}
				num = (short)581107713;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Applicable = value;
			}
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x060061E1 RID: 25057 RVA: 0x0057E3FC File Offset: 0x0057C5FC
		// (set) Token: 0x060061E2 RID: 25058 RVA: 0x0057E4B0 File Offset: 0x0057C6B0
		public bool RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_Valid
		{
			get
			{
				short num = (short)375502309;
				short num2 = num;
				num = (short)1335145957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)87097344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1914241025;
				if (num != 0)
				{
				}
				num = (short)398131200;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Valid;
			}
			set
			{
				short num = (short)429262952;
				short num2 = num;
				num = (short)229902440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1761411072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1176764417;
				if (num != 0)
				{
				}
				num = (short)1999896576;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Valid = value;
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x060061E3 RID: 25059 RVA: 0x0057E568 File Offset: 0x0057C768
		// (set) Token: 0x060061E4 RID: 25060 RVA: 0x0057E61C File Offset: 0x0057C81C
		public bool RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_Visible
		{
			get
			{
				short num = (short)547227109;
				short num2 = num;
				num = (short)1353123301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)271712256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1534525441;
				if (num != 0)
				{
				}
				num = (short)186646528;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Visible;
			}
			set
			{
				short num = (short)1272700197;
				short num2 = num;
				num = (short)1743641893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1431240704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)545783809;
				if (num != 0)
				{
				}
				num = (short)688914432;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Visible = value;
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x060061E5 RID: 25061 RVA: 0x0057E6D0 File Offset: 0x0057C8D0
		// (set) Token: 0x060061E6 RID: 25062 RVA: 0x0057E780 File Offset: 0x0057C980
		public bool RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_Editable
		{
			get
			{
				short num = (short)1941628238;
				short num2 = num;
				num = (short)2014569806;
				switch (num2 == num)
				{
				default:
				{
					num = (short)421134336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)398262273;
				if (num != 0)
				{
				}
				num = (short)1191116800;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Editable;
			}
			set
			{
				short num = (short)133912602;
				short num2 = num;
				num = (short)491280410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1610809344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)297140225;
				if (num != 0)
				{
				}
				num = (short)214302720;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.Editable = value;
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x060061E7 RID: 25063 RVA: 0x0057E834 File Offset: 0x0057CA34
		internal string RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_UILabel
		{
			get
			{
				short num = (short)1161276706;
				short num2 = num;
				num = (short)1635167522;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1483210752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567607297;
				if (num != 0)
				{
				}
				num = (short)1340538880;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.UIName;
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x060061E8 RID: 25064 RVA: 0x0057E8E8 File Offset: 0x0057CAE8
		// (set) Token: 0x060061E9 RID: 25065 RVA: 0x0057E9A0 File Offset: 0x0057CBA0
		internal bool RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_HiddenStatic
		{
			get
			{
				short num = (short)956161741;
				short num2 = num;
				num = (short)1174527693;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1579745280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)918355968;
				if (num != 0)
				{
				}
				num = (short)394657793;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.HiddenStatic;
			}
			set
			{
				short num = (short)849126450;
				short num2 = num;
				num = (short)1724752946;
				switch (num2 == num)
				{
				default:
				{
					num = (short)997130240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)3342337;
				if (num != 0)
				{
				}
				num = (short)1910046720;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.HiddenStatic = value;
			}
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x060061EA RID: 25066 RVA: 0x0057EA58 File Offset: 0x0057CC58
		// (set) Token: 0x060061EB RID: 25067 RVA: 0x0057EB0C File Offset: 0x0057CD0C
		internal bool RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_HiddenDynamic
		{
			get
			{
				short num = (short)370119073;
				short num2 = num;
				num = (short)806719905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1158086656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)445579265;
				if (num != 0)
				{
				}
				num = (short)2128871424;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.HiddenDynamic;
			}
			set
			{
				short num = (short)667447838;
				short num2 = num;
				num = (short)1539600926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)937099264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284360704;
				if (num != 0)
				{
				}
				num = (short)869203969;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451.HiddenDynamic = value;
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x060061EC RID: 25068 RVA: 0x0057EBC4 File Offset: 0x0057CDC4
		public bool RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_HasDiffs
		{
			get
			{
				short num = (short)325375947;
				short num2 = num;
				num = (short)232773579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1378942976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1549729793;
				if (num != 0)
				{
				}
				num = (short)1873739776;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451._HasDiffs;
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x060061ED RID: 25069 RVA: 0x0057EC78 File Offset: 0x0057CE78
		// (set) Token: 0x060061EE RID: 25070 RVA: 0x0057ED2C File Offset: 0x0057CF2C
		public int RadErgoWideAdvancedLongKeypressDurationms_A8450Value
		{
			get
			{
				short num = (short)1810948340;
				short num2 = num;
				num = (short)1798168820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1111949312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1068105729;
				if (num != 0)
				{
				}
				num = (short)1916338176;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.Value;
			}
			set
			{
				short num = (short)732205365;
				short num2 = num;
				num = (short)1227657525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1420558336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1589837825;
				if (num != 0)
				{
				}
				num = (short)1710948352;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.Value = value;
			}
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x060061EF RID: 25071 RVA: 0x0057EDE0 File Offset: 0x0057CFE0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAdvancedLongKeypressDurationms_A8450
		{
			get
			{
				short num = (short)2105768481;
				short num2 = num;
				num = (short)391936545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)314048512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1800142848;
				if (num != 0)
				{
				}
				num = (short)2036662273;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450;
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x060061F0 RID: 25072 RVA: 0x0057EE90 File Offset: 0x0057D090
		// (set) Token: 0x060061F1 RID: 25073 RVA: 0x0057EF44 File Offset: 0x0057D144
		public string RadErgoWideAdvancedLongKeypressDurationms_A8450_UIValue
		{
			get
			{
				short num = (short)217376351;
				short num2 = num;
				num = (short)1560536671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1800077312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1224474625;
				if (num != 0)
				{
				}
				num = (short)2033254400;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.UIValue;
			}
			set
			{
				short num = (short)1708392449;
				if (num != 0)
				{
				}
				num = (short)1605500928;
				short num2 = num;
				num = (short)224361022;
				short num3 = num;
				num = (short)142834238;
				switch (num3 == num)
				{
				}
				num = (short)363528192;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.UIValue = value;
			}
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x060061F2 RID: 25074 RVA: 0x0057EFF8 File Offset: 0x0057D1F8
		// (set) Token: 0x060061F3 RID: 25075 RVA: 0x0057F0AC File Offset: 0x0057D2AC
		internal int RadErgoWideAdvancedLongKeypressDurationms_A8450Min
		{
			get
			{
				short num = (short)1682585862;
				short num2 = num;
				num = (short)1584478470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1633550336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)56229889;
				if (num != 0)
				{
				}
				num = (short)1402470400;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.Min;
			}
			set
			{
				short num = (short)341138675;
				short num2 = num;
				num = (short)697588979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)967376896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1875378177;
				if (num != 0)
				{
				}
				num = (short)115998720;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.Min = value;
			}
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x060061F4 RID: 25076 RVA: 0x0057F164 File Offset: 0x0057D364
		// (set) Token: 0x060061F5 RID: 25077 RVA: 0x0057F218 File Offset: 0x0057D418
		internal int RadErgoWideAdvancedLongKeypressDurationms_A8450Max
		{
			get
			{
				short num = (short)1229225882;
				short num2 = num;
				num = (short)645234586;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1653473280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1156382720;
				if (num != 0)
				{
				}
				num = (short)1144651777;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.Max;
			}
			set
			{
				short num = (short)1507655681;
				if (num != 0)
				{
				}
				num = (short)594280448;
				short num2 = num;
				num = (short)579878215;
				short num3 = num;
				num = (short)1410809159;
				switch (num3 == num)
				{
				}
				num = (short)1163264000;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.Max = value;
			}
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x060061F6 RID: 25078 RVA: 0x0057F2D0 File Offset: 0x0057D4D0
		// (set) Token: 0x060061F7 RID: 25079 RVA: 0x0057F384 File Offset: 0x0057D584
		internal int RadErgoWideAdvancedLongKeypressDurationms_A8450Step
		{
			get
			{
				short num = (short)1680668709;
				short num2 = num;
				num = (short)1751185445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1902182400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)856752129;
				if (num != 0)
				{
				}
				num = (short)1244921856;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.StepSize;
			}
			set
			{
				short num = (short)96499995;
				short num2 = num;
				num = (short)858880283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)244121600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2066415617;
				if (num != 0)
				{
				}
				num = (short)1096744960;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.StepSize = value;
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x060061F8 RID: 25080 RVA: 0x0057F43C File Offset: 0x0057D63C
		// (set) Token: 0x060061F9 RID: 25081 RVA: 0x0057F4F0 File Offset: 0x0057D6F0
		public bool RadErgoWideAdvancedLongKeypressDurationms_A8450_Applicable
		{
			get
			{
				short num = (short)897960764;
				short num2 = num;
				num = (short)1058589500;
				switch (num2 == num)
				{
				default:
				{
					num = (short)253689856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1237647361;
				if (num != 0)
				{
				}
				num = (short)2042101760;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.Applicable;
			}
			set
			{
				short num = (short)576532775;
				short num2 = num;
				num = (short)327102759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1589510144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1689255937;
				if (num != 0)
				{
				}
				num = (short)1787101184;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.Applicable = value;
			}
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x060061FA RID: 25082 RVA: 0x0057F5A4 File Offset: 0x0057D7A4
		// (set) Token: 0x060061FB RID: 25083 RVA: 0x0057F658 File Offset: 0x0057D858
		public bool RadErgoWideAdvancedLongKeypressDurationms_A8450_Valid
		{
			get
			{
				short num = (short)676436766;
				short num2 = num;
				num = (short)2129435422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)123731968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)25952257;
				if (num != 0)
				{
				}
				num = (short)1983119360;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.Valid;
			}
			set
			{
				short num = (short)912207943;
				short num2 = num;
				num = (short)1966747719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1027080192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1892024321;
				if (num != 0)
				{
				}
				num = (short)963510272;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.Valid = value;
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x060061FC RID: 25084 RVA: 0x0057F70C File Offset: 0x0057D90C
		// (set) Token: 0x060061FD RID: 25085 RVA: 0x0057F7C0 File Offset: 0x0057D9C0
		public bool RadErgoWideAdvancedLongKeypressDurationms_A8450_Visible
		{
			get
			{
				short num = (short)1143407694;
				short num2 = num;
				num = (short)1036584014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2051407872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1557921793;
				if (num != 0)
				{
				}
				num = (short)969146368;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.Visible;
			}
			set
			{
				short num = (short)2029642719;
				short num2 = num;
				num = (short)972743647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)283049984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)577830912;
				if (num != 0)
				{
				}
				num = (short)137625601;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.Visible = value;
			}
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x060061FE RID: 25086 RVA: 0x0057F878 File Offset: 0x0057DA78
		// (set) Token: 0x060061FF RID: 25087 RVA: 0x0057F930 File Offset: 0x0057DB30
		public bool RadErgoWideAdvancedLongKeypressDurationms_A8450_Editable
		{
			get
			{
				short num = (short)864734444;
				short num2 = num;
				num = (short)1962659052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1957429248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)645660673;
				if (num != 0)
				{
				}
				num = (short)2060517376;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.Editable;
			}
			set
			{
				short num = (short)224217243;
				short num2 = num;
				num = (short)165628059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)110886912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)505544705;
				if (num != 0)
				{
				}
				num = (short)1920204800;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.Editable = value;
			}
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x06006200 RID: 25088 RVA: 0x0057F9E4 File Offset: 0x0057DBE4
		internal string RadErgoWideAdvancedLongKeypressDurationms_A8450_UILabel
		{
			get
			{
				short num = (short)892731393;
				if (num != 0)
				{
				}
				num = (short)1839267840;
				short num2 = num;
				num = (short)134261685;
				short num3 = num;
				num = (short)1772006325;
				switch (num3 == num)
				{
				}
				num = (short)634454016;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.UIName;
			}
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x06006201 RID: 25089 RVA: 0x0057FA98 File Offset: 0x0057DC98
		// (set) Token: 0x06006202 RID: 25090 RVA: 0x0057FB4C File Offset: 0x0057DD4C
		internal bool RadErgoWideAdvancedLongKeypressDurationms_A8450_HiddenStatic
		{
			get
			{
				short num = (short)1225535257;
				short num2 = num;
				num = (short)1388457753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)731512832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)349372417;
				if (num != 0)
				{
				}
				num = (short)2047213568;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.HiddenStatic;
			}
			set
			{
				short num = (short)1736507393;
				if (num != 0)
				{
				}
				num = (short)1737818112;
				short num2 = num;
				num = (short)1842760146;
				short num3 = num;
				num = (short)254822866;
				switch (num3 == num)
				{
				}
				num = (short)513736704;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.HiddenStatic = value;
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x06006203 RID: 25091 RVA: 0x0057FC00 File Offset: 0x0057DE00
		// (set) Token: 0x06006204 RID: 25092 RVA: 0x0057FCB0 File Offset: 0x0057DEB0
		internal bool RadErgoWideAdvancedLongKeypressDurationms_A8450_HiddenDynamic
		{
			get
			{
				short num = (short)4718593;
				if (num != 0)
				{
				}
				num = (short)2066350080;
				short num2 = num;
				num = (short)888262063;
				short num3 = num;
				num = (short)316853679;
				switch (num3 == num)
				{
				}
				num = (short)1368915968;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450.HiddenDynamic;
			}
			set
			{
				short num = (short)319065221;
				short num2 = num;
				num = (short)1414171781;
				switch (num2 == num)
				{
				default:
				{
					num = (short)21495808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1927282689;
				if (num != 0)
				{
				}
				num = (short)1852899328;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLongKeypressDurationms_A8450.HiddenDynamic = value;
			}
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x06006205 RID: 25093 RVA: 0x0057FD68 File Offset: 0x0057DF68
		public bool RadErgoWideAdvancedLongKeypressDurationms_A8450_HasDiffs
		{
			get
			{
				short num = (short)1550339764;
				short num2 = num;
				num = (short)1917537972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)639696896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1146617857;
				if (num != 0)
				{
				}
				num = (short)2074738688;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLongKeypressDurationms_A8450._HasDiffs;
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x06006206 RID: 25094 RVA: 0x0057FE1C File Offset: 0x0057E01C
		// (set) Token: 0x06006207 RID: 25095 RVA: 0x0057FED4 File Offset: 0x0057E0D4
		public int RadErgoWideAdvancedShortKeypressDurationforMFK_A38505Value
		{
			get
			{
				short num = (short)1861794828;
				short num2 = num;
				num = (short)887208972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)6553600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1495138305;
				if (num != 0)
				{
				}
				num = (short)1022492672;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Value;
			}
			set
			{
				short num = (short)1486140293;
				short num2 = num;
				num = (short)910603141;
				switch (num2 == num)
				{
				default:
				{
					num = (short)811139072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)873660417;
				if (num != 0)
				{
				}
				num = (short)2087583744;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Value = value;
			}
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x06006208 RID: 25096 RVA: 0x0057FF88 File Offset: 0x0057E188
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAdvancedShortKeypressDurationforMFK_A38505
		{
			get
			{
				short num = (short)982759199;
				short num2 = num;
				num = (short)746174239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)933953536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)899940352;
				if (num != 0)
				{
				}
				num = (short)302317569;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505;
			}
		}

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x06006209 RID: 25097 RVA: 0x00580038 File Offset: 0x0057E238
		// (set) Token: 0x0600620A RID: 25098 RVA: 0x005800F0 File Offset: 0x0057E2F0
		public string RadErgoWideAdvancedShortKeypressDurationforMFK_A38505_UIValue
		{
			get
			{
				short num = (short)747420339;
				short num2 = num;
				num = (short)1143519923;
				switch (num2 == num)
				{
				}
				num = (short)170000385;
				if (num != 0)
				{
				}
				num = (short)1368064000;
				if (num != 0)
				{
				}
				num = (short)1173749760;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.UIValue;
			}
			set
			{
				short num = (short)780652753;
				short num2 = num;
				num = (short)1141821649;
				switch (num2 == num)
				{
				}
				num = (short)413270017;
				if (num != 0)
				{
				}
				num = (short)984285184;
				if (num != 0)
				{
				}
				num = (short)300154880;
				short num3 = num;
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.UIValue = value;
			}
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600620B RID: 25099 RVA: 0x005801A4 File Offset: 0x0057E3A4
		// (set) Token: 0x0600620C RID: 25100 RVA: 0x00580258 File Offset: 0x0057E458
		internal int RadErgoWideAdvancedShortKeypressDurationforMFK_A38505Min
		{
			get
			{
				short num = (short)1625989761;
				short num2 = num;
				num = (short)609264257;
				switch (num2 == num)
				{
				}
				num = (short)1502609409;
				if (num != 0)
				{
				}
				num = (short)1123287040;
				if (num != 0)
				{
				}
				num = (short)1163919360;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Min;
			}
			set
			{
				short num = (short)120110081;
				short num2 = num;
				num = (short)616872961;
				switch (num2 == num)
				{
				}
				num = (short)638976001;
				if (num != 0)
				{
				}
				num = (short)1905983488;
				if (num != 0)
				{
				}
				num = (short)765001728;
				short num3 = num;
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Min = value;
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x00580310 File Offset: 0x0057E510
		// (set) Token: 0x0600620E RID: 25102 RVA: 0x005803C4 File Offset: 0x0057E5C4
		internal int RadErgoWideAdvancedShortKeypressDurationforMFK_A38505Max
		{
			get
			{
				short num = (short)2100245182;
				short num2 = num;
				num = (short)745026238;
				switch (num2 == num)
				{
				}
				num = (short)513933313;
				if (num != 0)
				{
				}
				num = (short)607125504;
				if (num != 0)
				{
				}
				num = (short)1583415296;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Max;
			}
			set
			{
				short num = (short)760660439;
				short num2 = num;
				num = (short)165265879;
				switch (num2 == num)
				{
				}
				num = (short)539557889;
				if (num != 0)
				{
				}
				num = (short)1226047488;
				if (num != 0)
				{
				}
				num = (short)1275461632;
				short num3 = num;
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Max = value;
			}
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600620F RID: 25103 RVA: 0x00580478 File Offset: 0x0057E678
		// (set) Token: 0x06006210 RID: 25104 RVA: 0x0058052C File Offset: 0x0057E72C
		internal int RadErgoWideAdvancedShortKeypressDurationforMFK_A38505Step
		{
			get
			{
				short num = (short)1359250586;
				short num2 = num;
				num = (short)957121690;
				switch (num2 == num)
				{
				}
				num = (short)1717829632;
				if (num != 0)
				{
				}
				num = (short)1588658177;
				if (num != 0)
				{
				}
				num = (short)1971453952;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.StepSize;
			}
			set
			{
				short num = (short)573384631;
				short num2 = num;
				num = (short)1777608631;
				switch (num2 == num)
				{
				}
				num = (short)250281985;
				if (num != 0)
				{
				}
				num = (short)1676804096;
				if (num != 0)
				{
				}
				num = (short)1147142144;
				short num3 = num;
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.StepSize = value;
			}
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x06006211 RID: 25105 RVA: 0x005805E4 File Offset: 0x0057E7E4
		// (set) Token: 0x06006212 RID: 25106 RVA: 0x00580698 File Offset: 0x0057E898
		public bool RadErgoWideAdvancedShortKeypressDurationforMFK_A38505_Applicable
		{
			get
			{
				short num = (short)362741761;
				if (num != 0)
				{
				}
				num = (short)997471625;
				short num2 = num;
				num = (short)1404384649;
				switch (num2 == num)
				{
				}
				num = (short)1761738752;
				if (num != 0)
				{
				}
				num = (short)199294976;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Applicable;
			}
			set
			{
				short num = (short)265809401;
				short num2 = num;
				num = (short)205909497;
				switch (num2 == num)
				{
				}
				num = (short)861995008;
				if (num != 0)
				{
				}
				num = (short)1060306945;
				if (num != 0)
				{
				}
				num = (short)1534984192;
				short num3 = num;
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Applicable = value;
			}
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x0058074C File Offset: 0x0057E94C
		// (set) Token: 0x06006214 RID: 25108 RVA: 0x00580800 File Offset: 0x0057EA00
		public bool RadErgoWideAdvancedShortKeypressDurationforMFK_A38505_Valid
		{
			get
			{
				short num = (short)1991880727;
				short num2 = num;
				num = (short)1613082647;
				switch (num2 == num)
				{
				}
				num = (short)1198784513;
				if (num != 0)
				{
				}
				num = (short)448724992;
				if (num != 0)
				{
				}
				num = (short)1082523648;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Valid;
			}
			set
			{
				short num = (short)1388757273;
				short num2 = num;
				num = (short)918470937;
				switch (num2 == num)
				{
				}
				num = (short)1780678657;
				if (num != 0)
				{
				}
				num = (short)2062352384;
				if (num != 0)
				{
				}
				num = (short)72155136;
				short num3 = num;
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Valid = value;
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x06006215 RID: 25109 RVA: 0x005808B4 File Offset: 0x0057EAB4
		// (set) Token: 0x06006216 RID: 25110 RVA: 0x00580968 File Offset: 0x0057EB68
		public bool RadErgoWideAdvancedShortKeypressDurationforMFK_A38505_Visible
		{
			get
			{
				short num = (short)1960851853;
				short num2 = num;
				num = (short)671299981;
				switch (num2 == num)
				{
				}
				num = (short)518127616;
				if (num != 0)
				{
				}
				num = (short)596312065;
				if (num != 0)
				{
				}
				num = (short)1232928768;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Visible;
			}
			set
			{
				short num = (short)845549958;
				short num2 = num;
				num = (short)1118835078;
				switch (num2 == num)
				{
				}
				num = (short)1019019264;
				if (num != 0)
				{
				}
				num = (short)246874113;
				if (num != 0)
				{
				}
				num = (short)909180928;
				short num3 = num;
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Visible = value;
			}
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x06006217 RID: 25111 RVA: 0x00580A1C File Offset: 0x0057EC1C
		// (set) Token: 0x06006218 RID: 25112 RVA: 0x00580AD0 File Offset: 0x0057ECD0
		public bool RadErgoWideAdvancedShortKeypressDurationforMFK_A38505_Editable
		{
			get
			{
				short num = (short)2142037802;
				short num2 = num;
				num = (short)1995826986;
				switch (num2 == num)
				{
				}
				num = (short)1996292096;
				if (num != 0)
				{
				}
				num = (short)1867186177;
				if (num != 0)
				{
				}
				num = (short)294453248;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Editable;
			}
			set
			{
				short num = (short)73186751;
				short num2 = num;
				num = (short)906804671;
				switch (num2 == num)
				{
				}
				num = (short)1507131392;
				if (num != 0)
				{
				}
				num = (short)1573978113;
				if (num != 0)
				{
				}
				num = (short)1697972224;
				short num3 = num;
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.Editable = value;
			}
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x06006219 RID: 25113 RVA: 0x00580B88 File Offset: 0x0057ED88
		internal string RadErgoWideAdvancedShortKeypressDurationforMFK_A38505_UILabel
		{
			get
			{
				short num = (short)503382017;
				if (num != 0)
				{
				}
				num = (short)1772392268;
				short num2 = num;
				num = (short)843288396;
				switch (num2 == num)
				{
				}
				num = (short)1021378560;
				if (num != 0)
				{
				}
				num = (short)1927544832;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.UIName;
			}
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600621A RID: 25114 RVA: 0x00580C3C File Offset: 0x0057EE3C
		// (set) Token: 0x0600621B RID: 25115 RVA: 0x00580CF0 File Offset: 0x0057EEF0
		internal bool RadErgoWideAdvancedShortKeypressDurationforMFK_A38505_HiddenStatic
		{
			get
			{
				short num = (short)1938766505;
				short num2 = num;
				num = (short)1319385769;
				switch (num2 == num)
				{
				}
				num = (short)1562509313;
				if (num != 0)
				{
				}
				num = (short)514916352;
				if (num != 0)
				{
				}
				num = (short)1885798400;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.HiddenStatic;
			}
			set
			{
				short num = (short)298691581;
				short num2 = num;
				num = (short)1475390461;
				switch (num2 == num)
				{
				}
				num = (short)1070792705;
				if (num != 0)
				{
				}
				num = (short)2019753984;
				if (num != 0)
				{
				}
				num = (short)1886912512;
				short num3 = num;
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.HiddenStatic = value;
			}
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600621C RID: 25116 RVA: 0x00580DA4 File Offset: 0x0057EFA4
		// (set) Token: 0x0600621D RID: 25117 RVA: 0x00580E58 File Offset: 0x0057F058
		internal bool RadErgoWideAdvancedShortKeypressDurationforMFK_A38505_HiddenDynamic
		{
			get
			{
				short num = (short)1577470512;
				short num2 = num;
				num = (short)1721977392;
				switch (num2 == num)
				{
				}
				num = (short)1008336897;
				if (num != 0)
				{
				}
				num = (short)80084992;
				if (num != 0)
				{
				}
				num = (short)258998272;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.HiddenDynamic;
			}
			set
			{
				short num = (short)273491922;
				short num2 = num;
				num = (short)482158546;
				switch (num2 == num)
				{
				}
				num = (short)1667104769;
				if (num != 0)
				{
				}
				num = (short)1313931264;
				if (num != 0)
				{
				}
				num = (short)1095827456;
				short num3 = num;
				this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505.HiddenDynamic = value;
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600621E RID: 25118 RVA: 0x00580F10 File Offset: 0x0057F110
		public bool RadErgoWideAdvancedShortKeypressDurationforMFK_A38505_HasDiffs
		{
			get
			{
				short num = (short)268675284;
				short num2 = num;
				num = (short)641968340;
				switch (num2 == num)
				{
				}
				num = (short)144048128;
				if (num != 0)
				{
				}
				num = (short)879296513;
				if (num != 0)
				{
				}
				num = (short)1098383360;
				short num3 = num;
				return this.radErgoWideAdvancedShortKeypressDurationforMFK_A38505._HasDiffs;
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600621F RID: 25119 RVA: 0x00580FC4 File Offset: 0x0057F1C4
		// (set) Token: 0x06006220 RID: 25120 RVA: 0x00581078 File Offset: 0x0057F278
		public int RadErgoWideAdvancedLongKeypressDurationforMFK_A38506Value
		{
			get
			{
				short num = (short)311950061;
				short num2 = num;
				num = (short)1749023469;
				switch (num2 == num)
				{
				}
				num = (short)1987444736;
				if (num != 0)
				{
				}
				num = (short)1137639425;
				if (num != 0)
				{
				}
				num = (short)1728118784;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Value;
			}
			set
			{
				short num = (short)300799814;
				short num2 = num;
				num = (short)1527895878;
				switch (num2 == num)
				{
				}
				num = (short)23461889;
				if (num != 0)
				{
				}
				num = (short)1087963136;
				if (num != 0)
				{
				}
				num = (short)1517092864;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Value = value;
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x06006221 RID: 25121 RVA: 0x00581130 File Offset: 0x0057F330
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAdvancedLongKeypressDurationforMFK_A38506
		{
			get
			{
				short num = (short)1646283013;
				short num2 = num;
				num = (short)2106804485;
				switch (num2 == num)
				{
				}
				num = (short)850132993;
				if (num != 0)
				{
				}
				num = (short)1246035968;
				if (num != 0)
				{
				}
				num = (short)779485184;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506;
			}
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x06006222 RID: 25122 RVA: 0x005811E0 File Offset: 0x0057F3E0
		// (set) Token: 0x06006223 RID: 25123 RVA: 0x00581298 File Offset: 0x0057F498
		public string RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_UIValue
		{
			get
			{
				short num = (short)579061353;
				short num2 = num;
				num = (short)2021639785;
				switch (num2 == num)
				{
				}
				num = (short)1422917632;
				if (num != 0)
				{
				}
				num = (short)1646460929;
				if (num != 0)
				{
				}
				num = (short)48365568;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.UIValue;
			}
			set
			{
				short num = (short)1029417137;
				short num2 = num;
				num = (short)1774495921;
				switch (num2 == num)
				{
				}
				num = (short)657653760;
				if (num != 0)
				{
				}
				num = (short)1072365569;
				if (num != 0)
				{
				}
				num = (short)899481600;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.UIValue = value;
			}
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x06006224 RID: 25124 RVA: 0x00581350 File Offset: 0x0057F550
		// (set) Token: 0x06006225 RID: 25125 RVA: 0x00581404 File Offset: 0x0057F604
		internal int RadErgoWideAdvancedLongKeypressDurationforMFK_A38506Min
		{
			get
			{
				short num = (short)786890753;
				if (num != 0)
				{
				}
				num = (short)1004508962;
				short num2 = num;
				num = (short)222730018;
				switch (num2 == num)
				{
				}
				num = (short)875823104;
				if (num != 0)
				{
				}
				num = (short)1878130688;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Min;
			}
			set
			{
				short num = (short)523944838;
				short num2 = num;
				num = (short)1367327622;
				switch (num2 == num)
				{
				}
				num = (short)697106433;
				if (num != 0)
				{
				}
				num = (short)2070937600;
				if (num != 0)
				{
				}
				num = (short)966918144;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Min = value;
			}
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x06006226 RID: 25126 RVA: 0x005814B8 File Offset: 0x0057F6B8
		// (set) Token: 0x06006227 RID: 25127 RVA: 0x00581570 File Offset: 0x0057F770
		internal int RadErgoWideAdvancedLongKeypressDurationforMFK_A38506Max
		{
			get
			{
				short num = (short)560393628;
				short num2 = num;
				num = (short)1531309468;
				switch (num2 == num)
				{
				}
				num = (short)1496055809;
				if (num != 0)
				{
				}
				num = (short)1990459392;
				if (num != 0)
				{
				}
				num = (short)992870400;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Max;
			}
			set
			{
				short num = (short)93650945;
				if (num != 0)
				{
				}
				num = (short)1850054570;
				short num2 = num;
				num = (short)36673450;
				switch (num2 == num)
				{
				}
				num = (short)1602879488;
				if (num != 0)
				{
				}
				num = (short)270663680;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Max = value;
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x06006228 RID: 25128 RVA: 0x00581624 File Offset: 0x0057F824
		// (set) Token: 0x06006229 RID: 25129 RVA: 0x005816D8 File Offset: 0x0057F8D8
		internal int RadErgoWideAdvancedLongKeypressDurationforMFK_A38506Step
		{
			get
			{
				short num = (short)141606449;
				short num2 = num;
				num = (short)1256832561;
				switch (num2 == num)
				{
				}
				num = (short)229048320;
				if (num != 0)
				{
				}
				num = (short)1027670017;
				if (num != 0)
				{
				}
				num = (short)228982784;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.StepSize;
			}
			set
			{
				short num = (short)767788417;
				short num2 = num;
				num = (short)266175873;
				switch (num2 == num)
				{
				}
				num = (short)1157890048;
				if (num != 0)
				{
				}
				num = (short)288948225;
				if (num != 0)
				{
				}
				num = (short)960167936;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.StepSize = value;
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600622A RID: 25130 RVA: 0x0058178C File Offset: 0x0057F98C
		// (set) Token: 0x0600622B RID: 25131 RVA: 0x00581840 File Offset: 0x0057FA40
		public bool RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_Applicable
		{
			get
			{
				short num = (short)2041292244;
				short num2 = num;
				num = (short)738698708;
				switch (num2 == num)
				{
				}
				num = (short)316014592;
				if (num != 0)
				{
				}
				num = (short)244514817;
				if (num != 0)
				{
				}
				num = (short)1225392128;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Applicable;
			}
			set
			{
				short num = (short)709018855;
				short num2 = num;
				num = (short)1164166375;
				switch (num2 == num)
				{
				}
				num = (short)1748238337;
				if (num != 0)
				{
				}
				num = (short)351076352;
				if (num != 0)
				{
				}
				num = (short)493551616;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Applicable = value;
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600622C RID: 25132 RVA: 0x005818F4 File Offset: 0x0057FAF4
		// (set) Token: 0x0600622D RID: 25133 RVA: 0x005819AC File Offset: 0x0057FBAC
		public bool RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_Valid
		{
			get
			{
				short num = (short)245394549;
				short num2 = num;
				num = (short)892497013;
				switch (num2 == num)
				{
				}
				num = (short)319291392;
				if (num != 0)
				{
				}
				num = (short)136380417;
				if (num != 0)
				{
				}
				num = (short)348192768;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Valid;
			}
			set
			{
				short num = (short)173364644;
				short num2 = num;
				num = (short)174020004;
				switch (num2 == num)
				{
				}
				num = (short)773259265;
				if (num != 0)
				{
				}
				num = (short)1387659264;
				if (num != 0)
				{
				}
				num = (short)254017536;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Valid = value;
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600622E RID: 25134 RVA: 0x00581A64 File Offset: 0x0057FC64
		// (set) Token: 0x0600622F RID: 25135 RVA: 0x00581B18 File Offset: 0x0057FD18
		public bool RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_Visible
		{
			get
			{
				short num = (short)1191755033;
				short num2 = num;
				num = (short)868531481;
				switch (num2 == num)
				{
				}
				num = (short)1129185280;
				if (num != 0)
				{
				}
				num = (short)453050369;
				if (num != 0)
				{
				}
				num = (short)1368326144;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Visible;
			}
			set
			{
				short num = (short)263297149;
				short num2 = num;
				num = (short)655792253;
				switch (num2 == num)
				{
				}
				num = (short)1885208576;
				if (num != 0)
				{
				}
				num = (short)1885667329;
				if (num != 0)
				{
				}
				num = (short)1034158080;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Visible = value;
			}
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x06006230 RID: 25136 RVA: 0x00581BD0 File Offset: 0x0057FDD0
		// (set) Token: 0x06006231 RID: 25137 RVA: 0x00581C84 File Offset: 0x0057FE84
		public bool RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_Editable
		{
			get
			{
				short num = (short)1650982913;
				if (num != 0)
				{
				}
				num = (short)421621584;
				short num2 = num;
				num = (short)1914269520;
				switch (num2 == num)
				{
				}
				num = (short)1572798464;
				if (num != 0)
				{
				}
				num = (short)1655767040;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Editable;
			}
			set
			{
				short num = (short)2141460099;
				short num2 = num;
				num = (short)107878019;
				switch (num2 == num)
				{
				}
				num = (short)1466564608;
				if (num != 0)
				{
				}
				num = (short)1009254401;
				if (num != 0)
				{
				}
				num = (short)1307705344;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.Editable = value;
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x06006232 RID: 25138 RVA: 0x00581D38 File Offset: 0x0057FF38
		internal string RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_UILabel
		{
			get
			{
				short num = (short)347998352;
				short num2 = num;
				num = (short)1588332688;
				switch (num2 == num)
				{
				}
				num = (short)765853697;
				if (num != 0)
				{
				}
				num = (short)843579392;
				if (num != 0)
				{
				}
				num = (short)1663893504;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.UIName;
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x06006233 RID: 25139 RVA: 0x00581DF0 File Offset: 0x0057FFF0
		// (set) Token: 0x06006234 RID: 25140 RVA: 0x00581EA4 File Offset: 0x005800A4
		internal bool RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_HiddenStatic
		{
			get
			{
				short num = (short)1135791812;
				short num2 = num;
				num = (short)1513803460;
				switch (num2 == num)
				{
				}
				num = (short)1037631489;
				if (num != 0)
				{
				}
				num = (short)1132331008;
				if (num != 0)
				{
				}
				num = (short)1498742784;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.HiddenStatic;
			}
			set
			{
				short num = (short)2075850213;
				short num2 = num;
				num = (short)1952314853;
				switch (num2 == num)
				{
				}
				num = (short)390070272;
				if (num != 0)
				{
				}
				num = (short)338624513;
				if (num != 0)
				{
				}
				num = (short)1018822656;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.HiddenStatic = value;
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x06006235 RID: 25141 RVA: 0x00581F58 File Offset: 0x00580158
		// (set) Token: 0x06006236 RID: 25142 RVA: 0x0058200C File Offset: 0x0058020C
		internal bool RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_HiddenDynamic
		{
			get
			{
				short num = (short)356981972;
				short num2 = num;
				num = (short)471801044;
				switch (num2 == num)
				{
				}
				num = (short)888602625;
				if (num != 0)
				{
				}
				num = (short)1235288064;
				if (num != 0)
				{
				}
				num = (short)2039218176;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.HiddenDynamic;
			}
			set
			{
				short num = (short)1294925825;
				if (num != 0)
				{
				}
				num = (short)243435394;
				short num2 = num;
				num = (short)2014218114;
				switch (num2 == num)
				{
				}
				num = (short)2009661440;
				if (num != 0)
				{
				}
				num = (short)38600704;
				short num3 = num;
				this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506.HiddenDynamic = value;
			}
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x06006237 RID: 25143 RVA: 0x005820C4 File Offset: 0x005802C4
		public bool RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_HasDiffs
		{
			get
			{
				short num = (short)22704679;
				short num2 = num;
				num = (short)1242329639;
				switch (num2 == num)
				{
				}
				num = (short)179175425;
				if (num != 0)
				{
				}
				num = (short)1098842112;
				if (num != 0)
				{
				}
				num = (short)671154176;
				short num3 = num;
				return this.radErgoWideAdvancedLongKeypressDurationforMFK_A38506._HasDiffs;
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x06006238 RID: 25144 RVA: 0x00582178 File Offset: 0x00580378
		// (set) Token: 0x06006239 RID: 25145 RVA: 0x00582228 File Offset: 0x00580428
		public int RadErgoWideAdvancedMFKInactivityTimeout_A38507Value
		{
			get
			{
				short num = (short)1584733587;
				short num2 = num;
				num = (short)934878611;
				switch (num2 == num)
				{
				}
				num = (short)274923521;
				if (num != 0)
				{
				}
				num = (short)783941632;
				if (num != 0)
				{
				}
				num = (short)146800640;
				short num3 = num;
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Value;
			}
			set
			{
				short num = (short)459104935;
				short num2 = num;
				num = (short)1710252711;
				switch (num2 == num)
				{
				}
				num = (short)122028033;
				if (num != 0)
				{
				}
				num = (short)1528102912;
				if (num != 0)
				{
				}
				num = (short)1458700288;
				short num3 = num;
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Value = value;
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600623A RID: 25146 RVA: 0x005822E0 File Offset: 0x005804E0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAdvancedMFKInactivityTimeout_A38507
		{
			get
			{
				short num = (short)253693935;
				short num2 = num;
				num = (short)547557359;
				switch (num2 == num)
				{
				}
				num = (short)646447105;
				if (num != 0)
				{
				}
				num = (short)1479737344;
				if (num != 0)
				{
				}
				num = (short)2103640064;
				short num3 = num;
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507;
			}
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600623B RID: 25147 RVA: 0x00582390 File Offset: 0x00580590
		// (set) Token: 0x0600623C RID: 25148 RVA: 0x00582444 File Offset: 0x00580644
		public string RadErgoWideAdvancedMFKInactivityTimeout_A38507_UIValue
		{
			get
			{
				short num = (short)124190009;
				short num2 = num;
				num = (short)1404566841;
				switch (num2 == num)
				{
				}
				num = (short)372703233;
				if (num != 0)
				{
				}
				num = (short)568852480;
				if (num != 0)
				{
				}
				num = (short)1602289664;
				short num3 = num;
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.UIValue;
			}
			set
			{
				short num = (short)1499599882;
				short num2 = num;
				num = (short)903943178;
				switch (num2 == num)
				{
				}
				num = (short)255000576;
				if (num != 0)
				{
				}
				num = (short)819658753;
				if (num != 0)
				{
				}
				num = (short)1772879872;
				short num3 = num;
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.UIValue = value;
			}
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600623D RID: 25149 RVA: 0x005824F8 File Offset: 0x005806F8
		// (set) Token: 0x0600623E RID: 25150 RVA: 0x005825AC File Offset: 0x005807AC
		internal int RadErgoWideAdvancedMFKInactivityTimeout_A38507Min
		{
			get
			{
				short num = (short)1524961295;
				short num2 = num;
				num = (short)1643253775;
				switch (num2 == num)
				{
				}
				num = (short)1081606144;
				if (num != 0)
				{
				}
				num = (short)2010251265;
				if (num != 0)
				{
				}
				num = (short)460128256;
				short num3 = num;
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Min;
			}
			set
			{
				short num = (short)326068564;
				short num2 = num;
				num = (short)252471636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)148701184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1637482497;
				if (num != 0)
				{
				}
				num = (short)1831337984;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Min = value;
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600623F RID: 25151 RVA: 0x00582660 File Offset: 0x00580860
		// (set) Token: 0x06006240 RID: 25152 RVA: 0x00582718 File Offset: 0x00580918
		internal int RadErgoWideAdvancedMFKInactivityTimeout_A38507Max
		{
			get
			{
				short num = (short)1284476749;
				short num2 = num;
				num = (short)957452109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1155989504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1769406465;
				if (num != 0)
				{
				}
				num = (short)888340480;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Max;
			}
			set
			{
				short num = (short)611127775;
				short num2 = num;
				num = (short)715592159;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1167065088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1388904449;
				if (num != 0)
				{
				}
				num = (short)1646264320;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Max = value;
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x06006241 RID: 25153 RVA: 0x005827CC File Offset: 0x005809CC
		// (set) Token: 0x06006242 RID: 25154 RVA: 0x00582884 File Offset: 0x00580A84
		internal int RadErgoWideAdvancedMFKInactivityTimeout_A38507Step
		{
			get
			{
				short num = (short)2122503651;
				short num2 = num;
				num = (short)415225315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1855651840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2029780993;
				if (num != 0)
				{
				}
				num = (short)278790144;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.StepSize;
			}
			set
			{
				short num = (short)934726459;
				short num2 = num;
				num = (short)689621819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)581238784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2000420865;
				if (num != 0)
				{
				}
				num = (short)817168384;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.StepSize = value;
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x06006243 RID: 25155 RVA: 0x0058293C File Offset: 0x00580B3C
		// (set) Token: 0x06006244 RID: 25156 RVA: 0x005829F4 File Offset: 0x00580BF4
		public bool RadErgoWideAdvancedMFKInactivityTimeout_A38507_Applicable
		{
			get
			{
				short num = (short)1135440635;
				short num2 = num;
				num = (short)1557558011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)435748864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1951334401;
				if (num != 0)
				{
				}
				num = (short)59441152;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Applicable;
			}
			set
			{
				short num = (short)269315157;
				short num2 = num;
				num = (short)1518955605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)721289216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1262092289;
				if (num != 0)
				{
				}
				num = (short)1078919168;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Applicable = value;
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x06006245 RID: 25157 RVA: 0x00582AAC File Offset: 0x00580CAC
		// (set) Token: 0x06006246 RID: 25158 RVA: 0x00582B60 File Offset: 0x00580D60
		public bool RadErgoWideAdvancedMFKInactivityTimeout_A38507_Valid
		{
			get
			{
				short num = (short)354883877;
				short num2 = num;
				num = (short)1091377445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)299958272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1668874241;
				if (num != 0)
				{
				}
				num = (short)1068630016;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Valid;
			}
			set
			{
				short num = (short)1670770039;
				short num2 = num;
				num = (short)541846903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1177681920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)679608321;
				if (num != 0)
				{
				}
				num = (short)965672960;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Valid = value;
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x06006247 RID: 25159 RVA: 0x00582C14 File Offset: 0x00580E14
		// (set) Token: 0x06006248 RID: 25160 RVA: 0x00582CCC File Offset: 0x00580ECC
		public bool RadErgoWideAdvancedMFKInactivityTimeout_A38507_Visible
		{
			get
			{
				short num = (short)1031758896;
				short num2 = num;
				num = (short)851665968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1054277632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2123956225;
				if (num != 0)
				{
				}
				num = (short)600309760;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Visible;
			}
			set
			{
				short num = (short)1709262829;
				short num2 = num;
				num = (short)1457866733;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1137901568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1838546945;
				if (num != 0)
				{
				}
				num = (short)249626624;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Visible = value;
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x06006249 RID: 25161 RVA: 0x00582D84 File Offset: 0x00580F84
		// (set) Token: 0x0600624A RID: 25162 RVA: 0x00582E38 File Offset: 0x00581038
		public bool RadErgoWideAdvancedMFKInactivityTimeout_A38507_Editable
		{
			get
			{
				short num = (short)2020103758;
				short num2 = num;
				num = (short)1795839566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)83361792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1341915136;
				if (num != 0)
				{
				}
				num = (short)555548673;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Editable;
			}
			set
			{
				short num = (short)250278373;
				short num2 = num;
				num = (short)432206309;
				switch (num2 == num)
				{
				default:
				{
					num = (short)758644736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)221970432;
				if (num != 0)
				{
				}
				num = (short)1952579585;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.Editable = value;
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600624B RID: 25163 RVA: 0x00582EEC File Offset: 0x005810EC
		internal string RadErgoWideAdvancedMFKInactivityTimeout_A38507_UILabel
		{
			get
			{
				short num = (short)196295575;
				short num2 = num;
				num = (short)1791966103;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1592000512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)994902017;
				if (num != 0)
				{
				}
				num = (short)1380057088;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.UIName;
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600624C RID: 25164 RVA: 0x00582FA4 File Offset: 0x005811A4
		// (set) Token: 0x0600624D RID: 25165 RVA: 0x00583058 File Offset: 0x00581258
		internal bool RadErgoWideAdvancedMFKInactivityTimeout_A38507_HiddenStatic
		{
			get
			{
				short num = (short)626496441;
				short num2 = num;
				num = (short)485725113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)491323392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)424017921;
				if (num != 0)
				{
				}
				num = (short)193134592;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.HiddenStatic;
			}
			set
			{
				short num = (short)1641742337;
				if (num != 0)
				{
				}
				num = (short)56754176;
				short num2 = num;
				num = (short)468995231;
				short num3 = num;
				num = (short)1807109279;
				switch (num3 == num)
				{
				}
				num = (short)1958543360;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.HiddenStatic = value;
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600624E RID: 25166 RVA: 0x0058310C File Offset: 0x0058130C
		// (set) Token: 0x0600624F RID: 25167 RVA: 0x005831C4 File Offset: 0x005813C4
		internal bool RadErgoWideAdvancedMFKInactivityTimeout_A38507_HiddenDynamic
		{
			get
			{
				short num = (short)1894283957;
				short num2 = num;
				num = (short)1728019125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1950547968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)419495936;
				if (num != 0)
				{
				}
				num = (short)278790145;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507.HiddenDynamic;
			}
			set
			{
				short num = (short)123562011;
				short num2 = num;
				num = (short)481585179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030501888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)366084097;
				if (num != 0)
				{
				}
				num = (short)1572536320;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedMFKInactivityTimeout_A38507.HiddenDynamic = value;
			}
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x06006250 RID: 25168 RVA: 0x00583278 File Offset: 0x00581478
		public bool RadErgoWideAdvancedMFKInactivityTimeout_A38507_HasDiffs
		{
			get
			{
				short num = (short)1300943410;
				short num2 = num;
				num = (short)406180402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)908394496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2124480513;
				if (num != 0)
				{
				}
				num = (short)231407616;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedMFKInactivityTimeout_A38507._HasDiffs;
			}
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x06006251 RID: 25169 RVA: 0x0058332C File Offset: 0x0058152C
		// (set) Token: 0x06006252 RID: 25170 RVA: 0x005833E0 File Offset: 0x005815E0
		public bool RadErgoWideAdvancedSideButtonsLockEnable_A38725Value
		{
			get
			{
				short num = (short)569221676;
				short num2 = num;
				num = (short)102867500;
				switch (num2 == num)
				{
				default:
				{
					num = (short)451936256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1790640129;
				if (num != 0)
				{
				}
				num = (short)2089484288;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Value;
			}
			set
			{
				short num = (short)1872379052;
				short num2 = num;
				num = (short)1781218476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)54591488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)327680001;
				if (num != 0)
				{
				}
				num = (short)1438121984;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Value = value;
			}
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x06006253 RID: 25171 RVA: 0x00583498 File Offset: 0x00581698
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideAdvancedSideButtonsLockEnable_A38725
		{
			get
			{
				short num = (short)133837740;
				short num2 = num;
				num = (short)2006987692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1163526144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)496697345;
				if (num != 0)
				{
				}
				num = (short)2063269888;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725;
			}
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x06006254 RID: 25172 RVA: 0x00583548 File Offset: 0x00581748
		// (set) Token: 0x06006255 RID: 25173 RVA: 0x005835FC File Offset: 0x005817FC
		public bool RadErgoWideAdvancedSideButtonsLockEnable_A38725_UIValue
		{
			get
			{
				short num = (short)207888193;
				short num2 = num;
				num = (short)1301946177;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1920073728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1182793728;
				if (num != 0)
				{
				}
				num = (short)1309278209;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Value;
			}
			set
			{
				short num = (short)157473295;
				short num2 = num;
				num = (short)1647237647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)103219200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)454754305;
				if (num != 0)
				{
				}
				num = (short)148963328;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Value = value;
			}
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x06006256 RID: 25174 RVA: 0x005836B0 File Offset: 0x005818B0
		// (set) Token: 0x06006257 RID: 25175 RVA: 0x00583760 File Offset: 0x00581960
		public bool RadErgoWideAdvancedSideButtonsLockEnable_A38725_Applicable
		{
			get
			{
				short num = (short)531890177;
				if (num != 0)
				{
				}
				num = (short)960626688;
				short num2 = num;
				num = (short)601949448;
				short num3 = num;
				num = (short)511182088;
				switch (num3 == num)
				{
				}
				num = (short)403570688;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Applicable;
			}
			set
			{
				short num = (short)1093778033;
				short num2 = num;
				num = (short)236763761;
				switch (num2 == num)
				{
				default:
				{
					num = (short)418119680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1245380609;
				if (num != 0)
				{
				}
				num = (short)1048641536;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Applicable = value;
			}
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x06006258 RID: 25176 RVA: 0x00583814 File Offset: 0x00581A14
		// (set) Token: 0x06006259 RID: 25177 RVA: 0x005838C8 File Offset: 0x00581AC8
		public bool RadErgoWideAdvancedSideButtonsLockEnable_A38725_Valid
		{
			get
			{
				short num = (short)90489219;
				short num2 = num;
				num = (short)847102339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1098055680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1457258497;
				if (num != 0)
				{
				}
				num = (short)248381440;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Valid;
			}
			set
			{
				short num = (short)493179969;
				short num2 = num;
				num = (short)1547850817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1905917952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1506279425;
				if (num != 0)
				{
				}
				num = (short)1489698816;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Valid = value;
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600625A RID: 25178 RVA: 0x0058397C File Offset: 0x00581B7C
		// (set) Token: 0x0600625B RID: 25179 RVA: 0x00583A2C File Offset: 0x00581C2C
		public bool RadErgoWideAdvancedSideButtonsLockEnable_A38725_Visible
		{
			get
			{
				short num = (short)985697053;
				short num2 = num;
				num = (short)1313508125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)312279040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2069430273;
				if (num != 0)
				{
				}
				num = (short)562364416;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Visible;
			}
			set
			{
				short num = (short)1171731579;
				short num2 = num;
				num = (short)650392699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1328218112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)115998720;
				if (num != 0)
				{
				}
				num = (short)725155841;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Visible = value;
			}
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600625C RID: 25180 RVA: 0x00583AE4 File Offset: 0x00581CE4
		// (set) Token: 0x0600625D RID: 25181 RVA: 0x00583B98 File Offset: 0x00581D98
		public bool RadErgoWideAdvancedSideButtonsLockEnable_A38725_Editable
		{
			get
			{
				short num = (short)457814934;
				short num2 = num;
				num = (short)1686549398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)749469696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)979828737;
				if (num != 0)
				{
				}
				num = (short)781123584;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Editable;
			}
			set
			{
				short num = (short)787279971;
				short num2 = num;
				num = (short)1385033827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)909377536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)528220160;
				if (num != 0)
				{
				}
				num = (short)113049601;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSideButtonsLockEnable_A38725.Editable = value;
			}
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600625E RID: 25182 RVA: 0x00583C50 File Offset: 0x00581E50
		internal string RadErgoWideAdvancedSideButtonsLockEnable_A38725_UILabel
		{
			get
			{
				short num = (short)1640137632;
				short num2 = num;
				num = (short)1541309344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)949420032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)807272449;
				if (num != 0)
				{
				}
				num = (short)1932787712;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725.UIName;
			}
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600625F RID: 25183 RVA: 0x00583D04 File Offset: 0x00581F04
		// (set) Token: 0x06006260 RID: 25184 RVA: 0x00583DBC File Offset: 0x00581FBC
		internal bool RadErgoWideAdvancedSideButtonsLockEnable_A38725_HiddenStatic
		{
			get
			{
				short num = (short)2117578274;
				short num2 = num;
				num = (short)2026221090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1894055936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1862860800;
				if (num != 0)
				{
				}
				num = (short)1687486465;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725.HiddenStatic;
			}
			set
			{
				short num = (short)296098860;
				short num2 = num;
				num = (short)6298668;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1039007744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1473576961;
				if (num != 0)
				{
				}
				num = (short)2096627712;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSideButtonsLockEnable_A38725.HiddenStatic = value;
			}
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x06006261 RID: 25185 RVA: 0x00583E70 File Offset: 0x00582070
		// (set) Token: 0x06006262 RID: 25186 RVA: 0x00583F24 File Offset: 0x00582124
		internal bool RadErgoWideAdvancedSideButtonsLockEnable_A38725_HiddenDynamic
		{
			get
			{
				short num = (short)1614086145;
				if (num != 0)
				{
				}
				num = (short)1197146112;
				short num2 = num;
				num = (short)1968838278;
				short num3 = num;
				num = (short)53352070;
				switch (num3 == num)
				{
				}
				num = (short)2121203712;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725.HiddenDynamic;
			}
			set
			{
				short num = (short)1902424839;
				short num2 = num;
				num = (short)1159639815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1946222592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1855979521;
				if (num != 0)
				{
				}
				num = (short)204210176;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedSideButtonsLockEnable_A38725.HiddenDynamic = value;
			}
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x06006263 RID: 25187 RVA: 0x00583FD8 File Offset: 0x005821D8
		public bool RadErgoWideAdvancedSideButtonsLockEnable_A38725_HasDiffs
		{
			get
			{
				short num = (short)1223136914;
				short num2 = num;
				num = (short)680171154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1363083264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)125304832;
				if (num != 0)
				{
				}
				num = (short)325582849;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedSideButtonsLockEnable_A38725._HasDiffs;
			}
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x06006264 RID: 25188 RVA: 0x0058408C File Offset: 0x0058228C
		// (set) Token: 0x06006265 RID: 25189 RVA: 0x00584144 File Offset: 0x00582344
		public int RadErgoWideAdvancedActiveMicForRadioPTT_A38766Value
		{
			get
			{
				short num = (short)1423835137;
				if (num != 0)
				{
				}
				num = (short)2095906816;
				short num2 = num;
				num = (short)868190824;
				short num3 = num;
				num = (short)2034993768;
				switch (num3 == num)
				{
				}
				num = (short)23789568;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.Value;
			}
			set
			{
				short num = (short)945637917;
				short num2 = num;
				num = (short)1192446493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1533542400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)447741953;
				if (num != 0)
				{
				}
				num = (short)359202816;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.Value = value;
			}
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x06006266 RID: 25190 RVA: 0x005841F8 File Offset: 0x005823F8
		// (set) Token: 0x06006267 RID: 25191 RVA: 0x005842AC File Offset: 0x005824AC
		public string RadErgoWideAdvancedActiveMicForRadioPTT_A38766_UIValue
		{
			get
			{
				short num = (short)901251073;
				if (num != 0)
				{
				}
				num = (short)1362362368;
				short num2 = num;
				num = (short)953101351;
				short num3 = num;
				num = (short)1560095783;
				switch (num3 == num)
				{
				}
				num = (short)1706033152;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.UIValue;
			}
			set
			{
				short num = (short)1309103658;
				short num2 = num;
				num = (short)605050410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667353088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1062469633;
				if (num != 0)
				{
				}
				num = (short)1532035072;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.UIValue = value;
			}
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x06006268 RID: 25192 RVA: 0x00584364 File Offset: 0x00582564
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedActiveMicForRadioPTT_A38766
		{
			get
			{
				short num = (short)322699265;
				if (num != 0)
				{
				}
				num = (short)834535424;
				short num2 = num;
				num = (short)1598171403;
				short num3 = num;
				num = (short)82716939;
				switch (num3 == num)
				{
				}
				num = (short)1494220800;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766;
			}
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x06006269 RID: 25193 RVA: 0x00584414 File Offset: 0x00582614
		// (set) Token: 0x0600626A RID: 25194 RVA: 0x005844CC File Offset: 0x005826CC
		public bool RadErgoWideAdvancedActiveMicForRadioPTT_A38766_Applicable
		{
			get
			{
				short num = (short)1003660383;
				short num2 = num;
				num = (short)1822467167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)706215936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262733825;
				if (num != 0)
				{
				}
				num = (short)1216937984;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.Applicable;
			}
			set
			{
				short num = (short)1161332439;
				short num2 = num;
				num = (short)1033537239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1349320704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)120455168;
				if (num != 0)
				{
				}
				num = (short)302448641;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.Applicable = value;
			}
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600626B RID: 25195 RVA: 0x00584584 File Offset: 0x00582784
		// (set) Token: 0x0600626C RID: 25196 RVA: 0x00584638 File Offset: 0x00582838
		public bool RadErgoWideAdvancedActiveMicForRadioPTT_A38766_Valid
		{
			get
			{
				short num = (short)350003095;
				short num2 = num;
				num = (short)1329962903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)130613248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1364459521;
				if (num != 0)
				{
				}
				num = (short)1295253504;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.Valid;
			}
			set
			{
				short num = (short)630663919;
				short num2 = num;
				num = (short)282536687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)747241472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1500971008;
				if (num != 0)
				{
				}
				num = (short)463405057;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.Valid = value;
			}
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600626D RID: 25197 RVA: 0x005846F0 File Offset: 0x005828F0
		// (set) Token: 0x0600626E RID: 25198 RVA: 0x005847A8 File Offset: 0x005829A8
		public bool RadErgoWideAdvancedActiveMicForRadioPTT_A38766_Visible
		{
			get
			{
				short num = (short)424954858;
				short num2 = num;
				num = (short)1995131882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2116419584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)345374720;
				if (num != 0)
				{
				}
				num = (short)364314625;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.Visible;
			}
			set
			{
				short num = (short)757390958;
				short num2 = num;
				num = (short)1950211694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2052128768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51904512;
				if (num != 0)
				{
				}
				num = (short)434765825;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.Visible = value;
			}
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600626F RID: 25199 RVA: 0x0058485C File Offset: 0x00582A5C
		// (set) Token: 0x06006270 RID: 25200 RVA: 0x00584914 File Offset: 0x00582B14
		public bool RadErgoWideAdvancedActiveMicForRadioPTT_A38766_Editable
		{
			get
			{
				short num = (short)408408307;
				short num2 = num;
				num = (short)447009011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)110428160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)943390721;
				if (num != 0)
				{
				}
				num = (short)267583488;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.Editable;
			}
			set
			{
				short num = (short)964421618;
				short num2 = num;
				num = (short)1689511922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1027407872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2131689473;
				if (num != 0)
				{
				}
				num = (short)18350080;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.Editable = value;
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x06006271 RID: 25201 RVA: 0x005849CC File Offset: 0x00582BCC
		internal string RadErgoWideAdvancedActiveMicForRadioPTT_A38766_UILabel
		{
			get
			{
				short num = (short)511223763;
				short num2 = num;
				num = (short)940812243;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1703411712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)675479553;
				if (num != 0)
				{
				}
				num = (short)625934336;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.UIName;
			}
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x06006272 RID: 25202 RVA: 0x00584A84 File Offset: 0x00582C84
		// (set) Token: 0x06006273 RID: 25203 RVA: 0x00584B38 File Offset: 0x00582D38
		internal bool RadErgoWideAdvancedActiveMicForRadioPTT_A38766_HiddenStatic
		{
			get
			{
				short num = (short)1353132806;
				short num2 = num;
				num = (short)891235078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)221708288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2029912065;
				if (num != 0)
				{
				}
				num = (short)768212992;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.HiddenStatic;
			}
			set
			{
				short num = (short)1930719710;
				short num2 = num;
				num = (short)1723298270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)520355840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1099497473;
				if (num != 0)
				{
				}
				num = (short)1625686016;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.HiddenStatic = value;
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x06006274 RID: 25204 RVA: 0x00584BEC File Offset: 0x00582DEC
		// (set) Token: 0x06006275 RID: 25205 RVA: 0x00584CA0 File Offset: 0x00582EA0
		internal bool RadErgoWideAdvancedActiveMicForRadioPTT_A38766_HiddenDynamic
		{
			get
			{
				short num = (short)1643631458;
				short num2 = num;
				num = (short)972280674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)35848192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)814809089;
				if (num != 0)
				{
				}
				num = (short)1138556928;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.HiddenDynamic;
			}
			set
			{
				short num = (short)2084044801;
				if (num != 0)
				{
				}
				num = (short)1868038144;
				short num2 = num;
				num = (short)1749431719;
				short num3 = num;
				num = (short)1078343079;
				switch (num3 == num)
				{
				}
				num = (short)507641856;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRadioPTT_A38766.HiddenDynamic = value;
			}
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x06006276 RID: 25206 RVA: 0x00584D58 File Offset: 0x00582F58
		public bool RadErgoWideAdvancedActiveMicForRadioPTT_A38766_HasDiffs
		{
			get
			{
				short num = (short)1060859916;
				short num2 = num;
				num = (short)214069260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)86769664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1331429376;
				if (num != 0)
				{
				}
				num = (short)890372097;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRadioPTT_A38766._HasDiffs;
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x06006277 RID: 25207 RVA: 0x00584E0C File Offset: 0x0058300C
		// (set) Token: 0x06006278 RID: 25208 RVA: 0x00584EC0 File Offset: 0x005830C0
		public bool RadErgoWideAdvancedLastSelectedChannelPerZone_A41073Value
		{
			get
			{
				short num = (short)1061289985;
				if (num != 0)
				{
				}
				num = (short)362035151;
				short num2 = num;
				num = (short)839661519;
				switch (num2 == num)
				{
				}
				num = (short)425984000;
				short num3 = num;
				num = (short)1862467584;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Value;
			}
			set
			{
				short num = (short)1184354523;
				short num2 = num;
				num = (short)379703515;
				switch (num2 == num)
				{
				}
				num = (short)120324097;
				if (num != 0)
				{
				}
				num = (short)1424162816;
				short num3 = num;
				num = (short)22347776;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Value = value;
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x06006279 RID: 25209 RVA: 0x00584F74 File Offset: 0x00583174
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideAdvancedLastSelectedChannelPerZone_A41073
		{
			get
			{
				short num = (short)894374090;
				short num2 = num;
				num = (short)1045893322;
				switch (num2 == num)
				{
				}
				num = (short)589299713;
				if (num != 0)
				{
				}
				num = (short)1104871424;
				short num3 = num;
				num = (short)439681024;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073;
			}
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600627A RID: 25210 RVA: 0x00585020 File Offset: 0x00583220
		// (set) Token: 0x0600627B RID: 25211 RVA: 0x005850D8 File Offset: 0x005832D8
		public bool RadErgoWideAdvancedLastSelectedChannelPerZone_A41073_UIValue
		{
			get
			{
				short num = (short)981840248;
				short num2 = num;
				num = (short)412594552;
				switch (num2 == num)
				{
				}
				num = (short)779288576;
				if (num != 0)
				{
				}
				num = (short)1017446400;
				short num3 = num;
				num = (short)1301938177;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Value;
			}
			set
			{
				short num = (short)260898817;
				if (num != 0)
				{
				}
				num = (short)1805391892;
				short num2 = num;
				num = (short)778180628;
				switch (num2 == num)
				{
				}
				num = (short)1225916416;
				short num3 = num;
				num = (short)53673984;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Value = value;
			}
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600627C RID: 25212 RVA: 0x00585190 File Offset: 0x00583390
		// (set) Token: 0x0600627D RID: 25213 RVA: 0x00585248 File Offset: 0x00583448
		public bool RadErgoWideAdvancedLastSelectedChannelPerZone_A41073_Applicable
		{
			get
			{
				short num = (short)1982369288;
				short num2 = num;
				num = (short)1754631688;
				switch (num2 == num)
				{
				}
				num = (short)888471553;
				if (num != 0)
				{
				}
				num = (short)1753677824;
				short num3 = num;
				num = (short)751828992;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Applicable;
			}
			set
			{
				short num = (short)214546684;
				short num2 = num;
				num = (short)1302903036;
				switch (num2 == num)
				{
				}
				num = (short)332136448;
				if (num != 0)
				{
				}
				num = (short)1970339840;
				short num3 = num;
				num = (short)689766401;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Applicable = value;
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600627E RID: 25214 RVA: 0x00585304 File Offset: 0x00583504
		// (set) Token: 0x0600627F RID: 25215 RVA: 0x005853B4 File Offset: 0x005835B4
		public bool RadErgoWideAdvancedLastSelectedChannelPerZone_A41073_Valid
		{
			get
			{
				short num = (short)263958682;
				short num2 = num;
				num = (short)794800282;
				switch (num2 == num)
				{
				}
				num = (short)463732737;
				if (num != 0)
				{
				}
				num = (short)1893072896;
				short num3 = num;
				num = (short)716570624;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Valid;
			}
			set
			{
				short num = (short)1655265162;
				short num2 = num;
				num = (short)684283786;
				switch (num2 == num)
				{
				}
				num = (short)1616052224;
				if (num != 0)
				{
				}
				num = (short)385024000;
				short num3 = num;
				num = (short)579272705;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Valid = value;
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x06006280 RID: 25216 RVA: 0x0058546C File Offset: 0x0058366C
		// (set) Token: 0x06006281 RID: 25217 RVA: 0x00585520 File Offset: 0x00583720
		public bool RadErgoWideAdvancedLastSelectedChannelPerZone_A41073_Visible
		{
			get
			{
				short num = (short)516674222;
				short num2 = num;
				num = (short)1429590702;
				switch (num2 == num)
				{
				}
				num = (short)1874788353;
				if (num != 0)
				{
				}
				num = (short)1467482112;
				short num3 = num;
				num = (short)687341568;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Visible;
			}
			set
			{
				short num = (short)897532867;
				short num2 = num;
				num = (short)1120420803;
				switch (num2 == num)
				{
				}
				num = (short)763101184;
				if (num != 0)
				{
				}
				num = (short)1310654464;
				short num3 = num;
				num = (short)725286913;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Visible = value;
			}
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x06006282 RID: 25218 RVA: 0x005855D4 File Offset: 0x005837D4
		// (set) Token: 0x06006283 RID: 25219 RVA: 0x00585688 File Offset: 0x00583888
		public bool RadErgoWideAdvancedLastSelectedChannelPerZone_A41073_Editable
		{
			get
			{
				short num = (short)1369907051;
				short num2 = num;
				num = (short)1296965483;
				switch (num2 == num)
				{
				}
				num = (short)465240064;
				if (num != 0)
				{
				}
				num = (short)810352640;
				short num3 = num;
				num = (short)1043464193;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Editable;
			}
			set
			{
				short num = (short)143589377;
				if (num != 0)
				{
				}
				num = (short)882933043;
				short num2 = num;
				num = (short)142441779;
				switch (num2 == num)
				{
				}
				num = (short)232456192;
				short num3 = num;
				num = (short)1700265984;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.Editable = value;
			}
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x06006284 RID: 25220 RVA: 0x0058573C File Offset: 0x0058393C
		internal string RadErgoWideAdvancedLastSelectedChannelPerZone_A41073_UILabel
		{
			get
			{
				short num = (short)261921175;
				short num2 = num;
				num = (short)859478423;
				switch (num2 == num)
				{
				}
				num = (short)193462272;
				if (num != 0)
				{
				}
				num = (short)516096000;
				short num3 = num;
				num = (short)1977942017;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.UIName;
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x06006285 RID: 25221 RVA: 0x005857F4 File Offset: 0x005839F4
		// (set) Token: 0x06006286 RID: 25222 RVA: 0x005858A8 File Offset: 0x00583AA8
		internal bool RadErgoWideAdvancedLastSelectedChannelPerZone_A41073_HiddenStatic
		{
			get
			{
				short num = (short)339410945;
				if (num != 0)
				{
				}
				num = (short)1848435746;
				short num2 = num;
				num = (short)2103043106;
				switch (num2 == num)
				{
				}
				num = (short)225640448;
				short num3 = num;
				num = (short)1159528448;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.HiddenStatic;
			}
			set
			{
				short num = (short)1579015603;
				short num2 = num;
				num = (short)2104942003;
				switch (num2 == num)
				{
				}
				num = (short)1639186433;
				if (num != 0)
				{
				}
				num = (short)436076544;
				short num3 = num;
				num = (short)16515072;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.HiddenStatic = value;
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x06006287 RID: 25223 RVA: 0x0058595C File Offset: 0x00583B5C
		// (set) Token: 0x06006288 RID: 25224 RVA: 0x00585A10 File Offset: 0x00583C10
		internal bool RadErgoWideAdvancedLastSelectedChannelPerZone_A41073_HiddenDynamic
		{
			get
			{
				short num = (short)813402132;
				short num2 = num;
				num = (short)1823115284;
				switch (num2 == num)
				{
				}
				num = (short)1494614017;
				if (num != 0)
				{
				}
				num = (short)1999306752;
				short num3 = num;
				num = (short)1822490624;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.HiddenDynamic;
			}
			set
			{
				short num = (short)1175156228;
				short num2 = num;
				num = (short)349468164;
				switch (num2 == num)
				{
				}
				num = (short)1154744321;
				if (num != 0)
				{
				}
				num = (short)1020198912;
				short num3 = num;
				num = (short)1612644352;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073.HiddenDynamic = value;
			}
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x06006289 RID: 25225 RVA: 0x00585AC4 File Offset: 0x00583CC4
		public bool RadErgoWideAdvancedLastSelectedChannelPerZone_A41073_HasDiffs
		{
			get
			{
				short num = (short)131655297;
				short num2 = num;
				num = (short)173401729;
				switch (num2 == num)
				{
				}
				num = (short)476119040;
				if (num != 0)
				{
				}
				num = (short)943587328;
				short num3 = num;
				num = (short)1974206465;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedLastSelectedChannelPerZone_A41073._HasDiffs;
			}
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600628A RID: 25226 RVA: 0x00585B78 File Offset: 0x00583D78
		// (set) Token: 0x0600628B RID: 25227 RVA: 0x00585C30 File Offset: 0x00583E30
		public int RadErgoWideSideAdvancedMFBInactivityTimeout_A41565Value
		{
			get
			{
				short num = (short)818940577;
				short num2 = num;
				num = (short)965216929;
				switch (num2 == num)
				{
				}
				num = (short)52166657;
				if (num != 0)
				{
				}
				num = (short)414973952;
				short num3 = num;
				num = (short)585236480;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Value;
			}
			set
			{
				short num = (short)525499105;
				short num2 = num;
				num = (short)1163295457;
				switch (num2 == num)
				{
				}
				num = (short)463142913;
				if (num != 0)
				{
				}
				num = (short)2093547520;
				short num3 = num;
				num = (short)714473472;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Value = value;
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600628C RID: 25228 RVA: 0x00585CE4 File Offset: 0x00583EE4
		public global::AcpBusinessLayer.AcpRangeField<int, int> RadErgoWideSideAdvancedMFBInactivityTimeout_A41565
		{
			get
			{
				short num = (short)1690915640;
				short num2 = num;
				num = (short)942232376;
				switch (num2 == num)
				{
				}
				num = (short)1206059009;
				if (num != 0)
				{
				}
				num = (short)1997537280;
				short num3 = num;
				num = (short)1519910912;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565;
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600628D RID: 25229 RVA: 0x00585D98 File Offset: 0x00583F98
		// (set) Token: 0x0600628E RID: 25230 RVA: 0x00585E4C File Offset: 0x0058404C
		public int RadErgoWideSideAdvancedMFBInactivityTimeout_A41565_UIValue
		{
			get
			{
				short num = (short)659318128;
				short num2 = num;
				num = (short)685073776;
				switch (num2 == num)
				{
				}
				num = (short)764215296;
				if (num != 0)
				{
				}
				num = (short)1519386624;
				short num3 = num;
				num = (short)1985478657;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.UIValue;
			}
			set
			{
				short num = (short)1257672578;
				short num2 = num;
				num = (short)1602785154;
				switch (num2 == num)
				{
				}
				num = (short)1825505281;
				if (num != 0)
				{
				}
				num = (short)1493499904;
				short num3 = num;
				num = (short)1010827264;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.UIValue = value;
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600628F RID: 25231 RVA: 0x00585F00 File Offset: 0x00584100
		// (set) Token: 0x06006290 RID: 25232 RVA: 0x00585FB4 File Offset: 0x005841B4
		internal int RadErgoWideSideAdvancedMFBInactivityTimeout_A41565Min
		{
			get
			{
				short num = (short)1118074265;
				short num2 = num;
				num = (short)1904113049;
				switch (num2 == num)
				{
				}
				num = (short)591921153;
				if (num != 0)
				{
				}
				num = (short)1532755968;
				short num3 = num;
				num = (short)1576665088;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Min;
			}
			set
			{
				short num = (short)629044691;
				short num2 = num;
				num = (short)1533834707;
				switch (num2 == num)
				{
				}
				num = (short)722862081;
				if (num != 0)
				{
				}
				num = (short)1208221696;
				short num3 = num;
				num = (short)1224605696;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Min = value;
			}
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x06006291 RID: 25233 RVA: 0x00586068 File Offset: 0x00584268
		// (set) Token: 0x06006292 RID: 25234 RVA: 0x00586120 File Offset: 0x00584320
		internal int RadErgoWideSideAdvancedMFBInactivityTimeout_A41565Max
		{
			get
			{
				short num = (short)1574877738;
				short num2 = num;
				num = (short)1135721002;
				switch (num2 == num)
				{
				}
				num = (short)2133721088;
				if (num != 0)
				{
				}
				num = (short)2047606784;
				short num3 = num;
				num = (short)1707016193;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Max;
			}
			set
			{
				short num = (short)2122206344;
				short num2 = num;
				num = (short)1566067848;
				switch (num2 == num)
				{
				}
				num = (short)1174863873;
				if (num != 0)
				{
				}
				num = (short)1680408576;
				short num3 = num;
				num = (short)539295744;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Max = value;
			}
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x06006293 RID: 25235 RVA: 0x005861D4 File Offset: 0x005843D4
		// (set) Token: 0x06006294 RID: 25236 RVA: 0x0058628C File Offset: 0x0058448C
		internal int RadErgoWideSideAdvancedMFBInactivityTimeout_A41565Step
		{
			get
			{
				short num = (short)1542458307;
				short num2 = num;
				num = (short)119999427;
				switch (num2 == num)
				{
				}
				num = (short)819593217;
				if (num != 0)
				{
				}
				num = (short)1132331008;
				short num3 = num;
				num = (short)1085079552;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.StepSize;
			}
			set
			{
				short num = (short)1503839580;
				short num2 = num;
				num = (short)710985052;
				switch (num2 == num)
				{
				}
				num = (short)1481048065;
				if (num != 0)
				{
				}
				num = (short)57540608;
				short num3 = num;
				num = (short)1387659264;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.StepSize = value;
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x06006295 RID: 25237 RVA: 0x00586340 File Offset: 0x00584540
		// (set) Token: 0x06006296 RID: 25238 RVA: 0x005863F4 File Offset: 0x005845F4
		public bool RadErgoWideSideAdvancedMFBInactivityTimeout_A41565_Applicable
		{
			get
			{
				short num = (short)1404178882;
				short num2 = num;
				num = (short)186323394;
				switch (num2 == num)
				{
				}
				num = (short)635502592;
				if (num != 0)
				{
				}
				num = (short)1164378112;
				short num3 = num;
				num = (short)2883585;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Applicable;
			}
			set
			{
				short num = (short)693099199;
				short num2 = num;
				num = (short)241425087;
				switch (num2 == num)
				{
				}
				num = (short)2053898241;
				if (num != 0)
				{
				}
				num = (short)67502080;
				short num3 = num;
				num = (short)2134966272;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Applicable = value;
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x06006297 RID: 25239 RVA: 0x005864AC File Offset: 0x005846AC
		// (set) Token: 0x06006298 RID: 25240 RVA: 0x00586564 File Offset: 0x00584764
		public bool RadErgoWideSideAdvancedMFBInactivityTimeout_A41565_Valid
		{
			get
			{
				short num = (short)1826088580;
				short num2 = num;
				num = (short)1402070660;
				switch (num2 == num)
				{
				}
				num = (short)301400065;
				if (num != 0)
				{
				}
				num = (short)1356201984;
				short num3 = num;
				num = (short)1857552384;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Valid;
			}
			set
			{
				short num = (short)1711515258;
				short num2 = num;
				num = (short)1052419706;
				switch (num2 == num)
				{
				}
				num = (short)1767243777;
				if (num != 0)
				{
				}
				num = (short)1735065600;
				short num3 = num;
				num = (short)1751973888;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Valid = value;
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x06006299 RID: 25241 RVA: 0x00586618 File Offset: 0x00584818
		// (set) Token: 0x0600629A RID: 25242 RVA: 0x005866C8 File Offset: 0x005848C8
		public bool RadErgoWideSideAdvancedMFBInactivityTimeout_A41565_Visible
		{
			get
			{
				short num = (short)1670544184;
				short num2 = num;
				num = (short)1919318840;
				switch (num2 == num)
				{
				}
				num = (short)703201281;
				if (num != 0)
				{
				}
				num = (short)793116672;
				short num3 = num;
				num = (short)1811611648;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Visible;
			}
			set
			{
				short num = (short)157140406;
				short num2 = num;
				num = (short)1650574774;
				switch (num2 == num)
				{
				}
				num = (short)489684993;
				if (num != 0)
				{
				}
				num = (short)955121664;
				short num3 = num;
				num = (short)991690752;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Visible = value;
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600629B RID: 25243 RVA: 0x0058677C File Offset: 0x0058497C
		// (set) Token: 0x0600629C RID: 25244 RVA: 0x00586830 File Offset: 0x00584A30
		public bool RadErgoWideSideAdvancedMFBInactivityTimeout_A41565_Editable
		{
			get
			{
				short num = (short)297630110;
				short num2 = num;
				num = (short)1812232606;
				switch (num2 == num)
				{
				}
				num = (short)885260289;
				if (num != 0)
				{
				}
				num = (short)1738473472;
				short num3 = num;
				num = (short)1270087680;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Editable;
			}
			set
			{
				short num = (short)2069534885;
				short num2 = num;
				num = (short)1426954405;
				switch (num2 == num)
				{
				}
				num = (short)1452343296;
				if (num != 0)
				{
				}
				num = (short)976355328;
				short num3 = num;
				num = (short)366870529;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.Editable = value;
			}
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600629D RID: 25245 RVA: 0x005868E0 File Offset: 0x00584AE0
		internal string RadErgoWideSideAdvancedMFBInactivityTimeout_A41565_UILabel
		{
			get
			{
				short num = (short)417797139;
				short num2 = num;
				num = (short)2063471635;
				switch (num2 == num)
				{
				}
				num = (short)230621184;
				if (num != 0)
				{
				}
				num = (short)260898816;
				short num3 = num;
				num = (short)2074542081;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.UIName;
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600629E RID: 25246 RVA: 0x00586994 File Offset: 0x00584B94
		// (set) Token: 0x0600629F RID: 25247 RVA: 0x00586A4C File Offset: 0x00584C4C
		internal bool RadErgoWideSideAdvancedMFBInactivityTimeout_A41565_HiddenStatic
		{
			get
			{
				short num = (short)1486159873;
				if (num != 0)
				{
				}
				num = (short)282052642;
				short num2 = num;
				num = (short)1389938722;
				switch (num2 == num)
				{
				}
				num = (short)1179058176;
				short num3 = num;
				num = (short)1445134336;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.HiddenStatic;
			}
			set
			{
				short num = (short)112160783;
				short num2 = num;
				num = (short)1280471055;
				switch (num2 == num)
				{
				}
				num = (short)1607729153;
				if (num != 0)
				{
				}
				num = (short)542572544;
				short num3 = num;
				num = (short)1604190208;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.HiddenStatic = value;
			}
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x060062A0 RID: 25248 RVA: 0x00586B00 File Offset: 0x00584D00
		// (set) Token: 0x060062A1 RID: 25249 RVA: 0x00586BB4 File Offset: 0x00584DB4
		internal bool RadErgoWideSideAdvancedMFBInactivityTimeout_A41565_HiddenDynamic
		{
			get
			{
				short num = (short)715518917;
				short num2 = num;
				num = (short)103347141;
				switch (num2 == num)
				{
				}
				num = (short)1087766529;
				if (num != 0)
				{
				}
				num = (short)2107506688;
				short num3 = num;
				num = (short)597229568;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.HiddenDynamic;
			}
			set
			{
				short num = (short)1679425537;
				if (num != 0)
				{
				}
				num = (short)197209932;
				short num2 = num;
				num = (short)1495347020;
				switch (num2 == num)
				{
				}
				num = (short)868024320;
				short num3 = num;
				num = (short)1281294336;
				if (num != 0)
				{
				}
				this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565.HiddenDynamic = value;
			}
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x060062A2 RID: 25250 RVA: 0x00586C6C File Offset: 0x00584E6C
		public bool RadErgoWideSideAdvancedMFBInactivityTimeout_A41565_HasDiffs
		{
			get
			{
				short num = (short)1650314473;
				short num2 = num;
				num = (short)1895222505;
				switch (num2 == num)
				{
				}
				num = (short)1215037441;
				if (num != 0)
				{
				}
				num = (short)567279616;
				short num3 = num;
				num = (short)1983315968;
				if (num != 0)
				{
				}
				return this.radErgoWideSideAdvancedMFBInactivityTimeout_A41565._HasDiffs;
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x00586D24 File Offset: 0x00584F24
		// (set) Token: 0x060062A4 RID: 25252 RVA: 0x00586DD8 File Offset: 0x00584FD8
		public int RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569Value
		{
			get
			{
				short num = (short)36890411;
				short num2 = num;
				num = (short)1080026923;
				switch (num2 == num)
				{
				}
				num = (short)29491201;
				if (num != 0)
				{
				}
				num = (short)1519124480;
				short num3 = num;
				num = (short)201654272;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.Value;
			}
			set
			{
				short num = (short)1479814271;
				short num2 = num;
				num = (short)2053975167;
				switch (num2 == num)
				{
				}
				num = (short)1815609344;
				if (num != 0)
				{
				}
				num = (short)816316416;
				short num3 = num;
				num = (short)2108162049;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.Value = value;
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x060062A5 RID: 25253 RVA: 0x00586E8C File Offset: 0x0058508C
		// (set) Token: 0x060062A6 RID: 25254 RVA: 0x00586F40 File Offset: 0x00585140
		public string RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569_UIValue
		{
			get
			{
				short num = (short)1410425146;
				short num2 = num;
				num = (short)839606586;
				switch (num2 == num)
				{
				}
				num = (short)1707999232;
				if (num != 0)
				{
				}
				num = (short)1819213824;
				short num3 = num;
				num = (short)1077346305;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.UIValue;
			}
			set
			{
				short num = (short)1070151515;
				short num2 = num;
				num = (short)457389915;
				switch (num2 == num)
				{
				}
				num = (short)1360134145;
				if (num != 0)
				{
				}
				num = (short)1664090112;
				short num3 = num;
				num = (short)1158152192;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.UIValue = value;
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x060062A7 RID: 25255 RVA: 0x00586FF8 File Offset: 0x005851F8
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569
		{
			get
			{
				short num = (short)1754399695;
				short num2 = num;
				num = (short)1566835663;
				switch (num2 == num)
				{
				}
				num = (short)1356333057;
				if (num != 0)
				{
				}
				num = (short)1138622464;
				short num3 = num;
				num = (short)886571008;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569;
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x060062A8 RID: 25256 RVA: 0x005870AC File Offset: 0x005852AC
		// (set) Token: 0x060062A9 RID: 25257 RVA: 0x00587160 File Offset: 0x00585360
		public bool RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569_Applicable
		{
			get
			{
				short num = (short)1154744321;
				if (num != 0)
				{
				}
				num = (short)1537133088;
				short num2 = num;
				num = (short)1170000416;
				switch (num2 == num)
				{
				}
				num = (short)1419902976;
				short num3 = num;
				num = (short)376569856;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.Applicable;
			}
			set
			{
				short num = (short)1347396338;
				short num2 = num;
				num = (short)854172402;
				switch (num2 == num)
				{
				}
				num = (short)645201921;
				if (num != 0)
				{
				}
				num = (short)1125711872;
				if (num != 0)
				{
				}
				num = (short)889847808;
				short num3 = num;
				this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.Applicable = value;
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x060062AA RID: 25258 RVA: 0x00587214 File Offset: 0x00585414
		// (set) Token: 0x060062AB RID: 25259 RVA: 0x005872C4 File Offset: 0x005854C4
		public bool RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569_Valid
		{
			get
			{
				short num = (short)902036441;
				short num2 = num;
				num = (short)1376189401;
				switch (num2 == num)
				{
				}
				num = (short)1203896320;
				if (num != 0)
				{
				}
				num = (short)1103101953;
				if (num != 0)
				{
				}
				num = (short)1579286528;
				short num3 = num;
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.Valid;
			}
			set
			{
				short num = (short)534703329;
				short num2 = num;
				num = (short)802614497;
				switch (num2 == num)
				{
				}
				num = (short)1021050881;
				if (num != 0)
				{
				}
				num = (short)1827078144;
				if (num != 0)
				{
				}
				num = (short)1432158208;
				short num3 = num;
				this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.Valid = value;
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x060062AC RID: 25260 RVA: 0x00587378 File Offset: 0x00585578
		// (set) Token: 0x060062AD RID: 25261 RVA: 0x0058742C File Offset: 0x0058562C
		public bool RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569_Visible
		{
			get
			{
				short num = (short)961620742;
				short num2 = num;
				num = (short)2112105222;
				switch (num2 == num)
				{
				}
				num = (short)696057857;
				if (num != 0)
				{
				}
				num = (short)558759936;
				if (num != 0)
				{
				}
				num = (short)1478819840;
				short num3 = num;
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.Visible;
			}
			set
			{
				short num = (short)764867882;
				short num2 = num;
				num = (short)821228842;
				switch (num2 == num)
				{
				}
				num = (short)1581187073;
				if (num != 0)
				{
				}
				num = (short)548405248;
				if (num != 0)
				{
				}
				num = (short)422051840;
				short num3 = num;
				this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.Visible = value;
			}
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x060062AE RID: 25262 RVA: 0x005874E4 File Offset: 0x005856E4
		// (set) Token: 0x060062AF RID: 25263 RVA: 0x00587598 File Offset: 0x00585798
		public bool RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569_Editable
		{
			get
			{
				short num = (short)1707926679;
				short num2 = num;
				num = (short)1283777687;
				switch (num2 == num)
				{
				}
				num = (short)1067253761;
				if (num != 0)
				{
				}
				num = (short)162463744;
				if (num != 0)
				{
				}
				num = (short)874643456;
				short num3 = num;
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.Editable;
			}
			set
			{
				short num = (short)1679780715;
				short num2 = num;
				num = (short)682322795;
				switch (num2 == num)
				{
				}
				num = (short)1887305729;
				if (num != 0)
				{
				}
				num = (short)2000879616;
				if (num != 0)
				{
				}
				num = (short)1477312512;
				short num3 = num;
				this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.Editable = value;
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x060062B0 RID: 25264 RVA: 0x00587650 File Offset: 0x00585850
		internal string RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569_UILabel
		{
			get
			{
				short num = (short)83919175;
				short num2 = num;
				num = (short)1530102087;
				switch (num2 == num)
				{
				}
				num = (short)2062090240;
				if (num != 0)
				{
				}
				num = (short)104595457;
				if (num != 0)
				{
				}
				num = (short)2122383360;
				short num3 = num;
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.UIName;
			}
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x060062B1 RID: 25265 RVA: 0x00587704 File Offset: 0x00585904
		// (set) Token: 0x060062B2 RID: 25266 RVA: 0x005877B8 File Offset: 0x005859B8
		internal bool RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569_HiddenStatic
		{
			get
			{
				short num = (short)1848982495;
				short num2 = num;
				num = (short)2044148703;
				switch (num2 == num)
				{
				}
				num = (short)1091764225;
				if (num != 0)
				{
				}
				num = (short)1839595520;
				if (num != 0)
				{
				}
				num = (short)1138294784;
				short num3 = num;
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.HiddenStatic;
			}
			set
			{
				short num = (short)940614208;
				short num2 = num;
				num = (short)2077467200;
				switch (num2 == num)
				{
				}
				num = (short)1003421697;
				if (num != 0)
				{
				}
				num = (short)1338900480;
				if (num != 0)
				{
				}
				num = (short)1681391616;
				short num3 = num;
				this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.HiddenStatic = value;
			}
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x060062B3 RID: 25267 RVA: 0x00587870 File Offset: 0x00585A70
		// (set) Token: 0x060062B4 RID: 25268 RVA: 0x00587928 File Offset: 0x00585B28
		internal bool RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569_HiddenDynamic
		{
			get
			{
				short num = (short)637850590;
				short num2 = num;
				num = (short)826004446;
				switch (num2 == num)
				{
				}
				num = (short)374996993;
				if (num != 0)
				{
				}
				num = (short)1210712064;
				if (num != 0)
				{
				}
				num = (short)1554710528;
				short num3 = num;
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.HiddenDynamic;
			}
			set
			{
				short num = (short)832072820;
				short num2 = num;
				num = (short)2091805812;
				switch (num2 == num)
				{
				}
				num = (short)1841168385;
				if (num != 0)
				{
				}
				num = (short)503447552;
				if (num != 0)
				{
				}
				num = (short)166854656;
				short num3 = num;
				this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569.HiddenDynamic = value;
			}
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x060062B5 RID: 25269 RVA: 0x005879DC File Offset: 0x00585BDC
		public bool RadErgoWideAdvancedKeypadControlsLockKeyPressType_A41569_HasDiffs
		{
			get
			{
				short num = (short)255960278;
				short num2 = num;
				num = (short)1756931286;
				switch (num2 == num)
				{
				}
				num = (short)866254848;
				if (num != 0)
				{
				}
				num = (short)1082654721;
				if (num != 0)
				{
				}
				num = (short)1507065856;
				short num3 = num;
				return this.radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569._HasDiffs;
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x060062B6 RID: 25270 RVA: 0x00587A90 File Offset: 0x00585C90
		// (set) Token: 0x060062B7 RID: 25271 RVA: 0x00587B44 File Offset: 0x00585D44
		public int RadWideNVGBacklightBrightnessLevel_A41616Value
		{
			get
			{
				short num = (short)494272513;
				if (num != 0)
				{
				}
				num = (short)295146030;
				short num2 = num;
				num = (short)563188270;
				switch (num2 == num)
				{
				}
				num = (short)1350631424;
				if (num != 0)
				{
				}
				num = (short)1094778880;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616.Value;
			}
			set
			{
				short num = (short)273465580;
				short num2 = num;
				num = (short)675397868;
				switch (num2 == num)
				{
				}
				num = (short)1497300992;
				if (num != 0)
				{
				}
				num = (short)1311834113;
				if (num != 0)
				{
				}
				num = (short)840302592;
				short num3 = num;
				this.radWideNVGBacklightBrightnessLevel_A41616.Value = value;
			}
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x060062B8 RID: 25272 RVA: 0x00587BF8 File Offset: 0x00585DF8
		// (set) Token: 0x060062B9 RID: 25273 RVA: 0x00587CAC File Offset: 0x00585EAC
		public string RadWideNVGBacklightBrightnessLevel_A41616_UIValue
		{
			get
			{
				short num = (short)2013948164;
				short num2 = num;
				num = (short)1396467972;
				switch (num2 == num)
				{
				}
				num = (short)2041839617;
				if (num != 0)
				{
				}
				num = (short)1586888704;
				if (num != 0)
				{
				}
				num = (short)2059468800;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616.UIValue;
			}
			set
			{
				short num = (short)1321548006;
				short num2 = num;
				num = (short)774781158;
				switch (num2 == num)
				{
				}
				num = (short)1167458305;
				if (num != 0)
				{
				}
				num = (short)1662517248;
				if (num != 0)
				{
				}
				num = (short)50790400;
				short num3 = num;
				this.radWideNVGBacklightBrightnessLevel_A41616.UIValue = value;
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x060062BA RID: 25274 RVA: 0x00587D64 File Offset: 0x00585F64
		public global::AcpBusinessLayer.AcpListField RadWideNVGBacklightBrightnessLevel_A41616
		{
			get
			{
				short num = (short)1675220664;
				short num2 = num;
				num = (short)777574072;
				switch (num2 == num)
				{
				}
				num = (short)1015808000;
				if (num != 0)
				{
				}
				num = (short)2129395713;
				if (num != 0)
				{
				}
				num = (short)380305408;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616;
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x060062BB RID: 25275 RVA: 0x00587E14 File Offset: 0x00586014
		// (set) Token: 0x060062BC RID: 25276 RVA: 0x00587EC8 File Offset: 0x005860C8
		public bool RadWideNVGBacklightBrightnessLevel_A41616_Applicable
		{
			get
			{
				short num = (short)581115487;
				short num2 = num;
				num = (short)1394744927;
				switch (num2 == num)
				{
				}
				num = (short)1440153601;
				if (num != 0)
				{
				}
				num = (short)1746599936;
				if (num != 0)
				{
				}
				num = (short)1654128640;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616.Applicable;
			}
			set
			{
				short num = (short)75767404;
				short num2 = num;
				num = (short)282926700;
				switch (num2 == num)
				{
				}
				num = (short)534773761;
				if (num != 0)
				{
				}
				num = (short)76480512;
				if (num != 0)
				{
				}
				num = (short)1990328320;
				short num3 = num;
				this.radWideNVGBacklightBrightnessLevel_A41616.Applicable = value;
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x060062BD RID: 25277 RVA: 0x00587F80 File Offset: 0x00586180
		// (set) Token: 0x060062BE RID: 25278 RVA: 0x00588034 File Offset: 0x00586234
		public bool RadWideNVGBacklightBrightnessLevel_A41616_Valid
		{
			get
			{
				short num = (short)1027670017;
				if (num != 0)
				{
				}
				num = (short)875521044;
				short num2 = num;
				num = (short)135881748;
				switch (num2 == num)
				{
				}
				num = (short)657784832;
				if (num != 0)
				{
				}
				num = (short)717815808;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616.Valid;
			}
			set
			{
				short num = (short)1859448686;
				short num2 = num;
				num = (short)1682763630;
				switch (num2 == num)
				{
				}
				num = (short)1144717313;
				if (num != 0)
				{
				}
				num = (short)1683226624;
				if (num != 0)
				{
				}
				num = (short)1368326144;
				short num3 = num;
				this.radWideNVGBacklightBrightnessLevel_A41616.Valid = value;
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x060062BF RID: 25279 RVA: 0x005880E8 File Offset: 0x005862E8
		// (set) Token: 0x060062C0 RID: 25280 RVA: 0x0058819C File Offset: 0x0058639C
		public bool RadWideNVGBacklightBrightnessLevel_A41616_Visible
		{
			get
			{
				short num = (short)1199202800;
				short num2 = num;
				num = (short)1292001776;
				switch (num2 == num)
				{
				}
				num = (short)1055522817;
				if (num != 0)
				{
				}
				num = (short)52690944;
				if (num != 0)
				{
				}
				num = (short)695402496;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616.Visible;
			}
			set
			{
				short num = (short)990060127;
				short num2 = num;
				num = (short)1632575071;
				switch (num2 == num)
				{
				}
				num = (short)753074176;
				if (num != 0)
				{
				}
				num = (short)1193476097;
				if (num != 0)
				{
				}
				num = (short)1857945600;
				short num3 = num;
				this.radWideNVGBacklightBrightnessLevel_A41616.Visible = value;
			}
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x060062C1 RID: 25281 RVA: 0x00588258 File Offset: 0x00586458
		// (set) Token: 0x060062C2 RID: 25282 RVA: 0x00588310 File Offset: 0x00586510
		public bool RadWideNVGBacklightBrightnessLevel_A41616_Editable
		{
			get
			{
				short num = (short)1095408274;
				short num2 = num;
				num = (short)111909522;
				switch (num2 == num)
				{
				}
				num = (short)711983105;
				if (num != 0)
				{
				}
				num = (short)90243072;
				if (num != 0)
				{
				}
				num = (short)772210688;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616.Editable;
			}
			set
			{
				short num = (short)1105985537;
				if (num != 0)
				{
				}
				num = (short)816219931;
				short num2 = num;
				num = (short)2080605979;
				switch (num2 == num)
				{
				}
				num = (short)1949040640;
				if (num != 0)
				{
				}
				num = (short)1464664064;
				short num3 = num;
				this.radWideNVGBacklightBrightnessLevel_A41616.Editable = value;
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x060062C3 RID: 25283 RVA: 0x005883C4 File Offset: 0x005865C4
		internal string RadWideNVGBacklightBrightnessLevel_A41616_UILabel
		{
			get
			{
				short num = (short)369566699;
				short num2 = num;
				num = (short)1881547755;
				switch (num2 == num)
				{
				}
				num = (short)223346689;
				if (num != 0)
				{
				}
				num = (short)1574830080;
				if (num != 0)
				{
				}
				num = (short)494862336;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616.UIName;
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x060062C4 RID: 25284 RVA: 0x0058847C File Offset: 0x0058667C
		// (set) Token: 0x060062C5 RID: 25285 RVA: 0x00588530 File Offset: 0x00586730
		internal bool RadWideNVGBacklightBrightnessLevel_A41616_HiddenStatic
		{
			get
			{
				short num = (short)3577991;
				short num2 = num;
				num = (short)571775111;
				switch (num2 == num)
				{
				}
				num = (short)1327235073;
				if (num != 0)
				{
				}
				num = (short)150470656;
				if (num != 0)
				{
				}
				num = (short)237502464;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616.HiddenStatic;
			}
			set
			{
				short num = (short)973645910;
				short num2 = num;
				num = (short)1127262294;
				switch (num2 == num)
				{
				}
				num = (short)1511981057;
				if (num != 0)
				{
				}
				num = (short)527826944;
				if (num != 0)
				{
				}
				num = (short)2025193472;
				short num3 = num;
				this.radWideNVGBacklightBrightnessLevel_A41616.HiddenStatic = value;
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x060062C6 RID: 25286 RVA: 0x005885E8 File Offset: 0x005867E8
		// (set) Token: 0x060062C7 RID: 25287 RVA: 0x0058869C File Offset: 0x0058689C
		internal bool RadWideNVGBacklightBrightnessLevel_A41616_HiddenDynamic
		{
			get
			{
				short num = (short)322717977;
				short num2 = num;
				num = (short)1474054425;
				switch (num2 == num)
				{
				}
				num = (short)974651392;
				if (num != 0)
				{
				}
				num = (short)13107201;
				if (num != 0)
				{
				}
				num = (short)937033728;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616.HiddenDynamic;
			}
			set
			{
				short num = (short)434705560;
				short num2 = num;
				num = (short)597365912;
				switch (num2 == num)
				{
				}
				num = (short)691601408;
				if (num != 0)
				{
				}
				num = (short)961544193;
				if (num != 0)
				{
				}
				num = (short)1868300288;
				short num3 = num;
				this.radWideNVGBacklightBrightnessLevel_A41616.HiddenDynamic = value;
			}
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x060062C8 RID: 25288 RVA: 0x0058874C File Offset: 0x0058694C
		public bool RadWideNVGBacklightBrightnessLevel_A41616_HasDiffs
		{
			get
			{
				short num = (short)1763148494;
				short num2 = num;
				num = (short)487883470;
				switch (num2 == num)
				{
				}
				num = (short)534446081;
				if (num != 0)
				{
				}
				num = (short)1789132800;
				if (num != 0)
				{
				}
				num = (short)1181745152;
				short num3 = num;
				return this.radWideNVGBacklightBrightnessLevel_A41616._HasDiffs;
			}
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x060062C9 RID: 25289 RVA: 0x00588800 File Offset: 0x00586A00
		// (set) Token: 0x060062CA RID: 25290 RVA: 0x005888B4 File Offset: 0x00586AB4
		public int RadErgoWideAdvancedPowerOffKeypressDuration_42489Value
		{
			get
			{
				short num = (short)280494081;
				if (num != 0)
				{
				}
				num = (short)520439993;
				short num2 = num;
				num = (short)1543456953;
				switch (num2 == num)
				{
				}
				num = (short)1118896128;
				if (num != 0)
				{
				}
				num = (short)984940544;
				short num3 = num;
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Value;
			}
			set
			{
				short num = (short)1261986;
				short num2 = num;
				num = (short)712524194;
				switch (num2 == num)
				{
				}
				num = (short)105512961;
				if (num != 0)
				{
				}
				num = (short)968687616;
				if (num != 0)
				{
				}
				num = (short)1981939712;
				short num3 = num;
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Value = value;
			}
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x060062CB RID: 25291 RVA: 0x00588968 File Offset: 0x00586B68
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAdvancedPowerOffKeypressDuration_42489
		{
			get
			{
				short num = (short)1409163882;
				short num2 = num;
				num = (short)526000746;
				switch (num2 == num)
				{
				}
				num = (short)972226560;
				if (num != 0)
				{
				}
				num = (short)901578753;
				if (num != 0)
				{
				}
				num = (short)1188298752;
				short num3 = num;
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489;
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x060062CC RID: 25292 RVA: 0x00588A18 File Offset: 0x00586C18
		// (set) Token: 0x060062CD RID: 25293 RVA: 0x00588ACC File Offset: 0x00586CCC
		public string RadErgoWideAdvancedPowerOffKeypressDuration_42489_UIValue
		{
			get
			{
				short num = (short)468260328;
				short num2 = num;
				num = (short)1485641192;
				switch (num2 == num)
				{
				}
				num = (short)2093613056;
				if (num != 0)
				{
				}
				num = (short)466747393;
				if (num != 0)
				{
				}
				num = (short)1638989824;
				short num3 = num;
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.UIValue;
			}
			set
			{
				short num = (short)448720350;
				short num2 = num;
				num = (short)596897246;
				switch (num2 == num)
				{
				}
				num = (short)842334208;
				if (num != 0)
				{
				}
				num = (short)414384129;
				if (num != 0)
				{
				}
				num = (short)1319501824;
				short num3 = num;
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.UIValue = value;
			}
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x060062CE RID: 25294 RVA: 0x00588B80 File Offset: 0x00586D80
		// (set) Token: 0x060062CF RID: 25295 RVA: 0x00588C38 File Offset: 0x00586E38
		internal int RadErgoWideAdvancedPowerOffKeypressDuration_42489Min
		{
			get
			{
				short num = (short)1769716605;
				short num2 = num;
				num = (short)262650749;
				switch (num2 == num)
				{
				}
				num = (short)230162432;
				if (num != 0)
				{
				}
				num = (short)1188102145;
				if (num != 0)
				{
				}
				num = (short)277872640;
				short num3 = num;
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Min;
			}
			set
			{
				short num = (short)117682512;
				short num2 = num;
				num = (short)338735440;
				switch (num2 == num)
				{
				}
				num = (short)1283784704;
				if (num != 0)
				{
				}
				num = (short)896401409;
				if (num != 0)
				{
				}
				num = (short)540147712;
				short num3 = num;
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Min = value;
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x060062D0 RID: 25296 RVA: 0x00588CEC File Offset: 0x00586EEC
		// (set) Token: 0x060062D1 RID: 25297 RVA: 0x00588DA0 File Offset: 0x00586FA0
		internal int RadErgoWideAdvancedPowerOffKeypressDuration_42489Max
		{
			get
			{
				short num = (short)23369377;
				short num2 = num;
				num = (short)851941025;
				switch (num2 == num)
				{
				}
				num = (short)167706624;
				if (num != 0)
				{
				}
				num = (short)1992294401;
				if (num != 0)
				{
				}
				num = (short)1745682432;
				short num3 = num;
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Max;
			}
			set
			{
				short num = (short)1150048843;
				short num2 = num;
				num = (short)1347115595;
				switch (num2 == num)
				{
				}
				num = (short)1558904833;
				if (num != 0)
				{
				}
				num = (short)869138432;
				if (num != 0)
				{
				}
				num = (short)103546880;
				short num3 = num;
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Max = value;
			}
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x060062D2 RID: 25298 RVA: 0x00588E54 File Offset: 0x00587054
		// (set) Token: 0x060062D3 RID: 25299 RVA: 0x00588F0C File Offset: 0x0058710C
		internal int RadErgoWideAdvancedPowerOffKeypressDuration_42489Step
		{
			get
			{
				short num = (short)114882646;
				short num2 = num;
				num = (short)259520598;
				switch (num2 == num)
				{
				}
				num = (short)618594305;
				if (num != 0)
				{
				}
				num = (short)531103744;
				if (num != 0)
				{
				}
				num = (short)869990400;
				short num3 = num;
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.StepSize;
			}
			set
			{
				short num = (short)435707078;
				short num2 = num;
				num = (short)516775110;
				switch (num2 == num)
				{
				}
				num = (short)1739653121;
				if (num != 0)
				{
				}
				num = (short)6619136;
				if (num != 0)
				{
				}
				num = (short)1521025024;
				short num3 = num;
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.StepSize = value;
			}
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x060062D4 RID: 25300 RVA: 0x00588FC4 File Offset: 0x005871C4
		// (set) Token: 0x060062D5 RID: 25301 RVA: 0x00589078 File Offset: 0x00587278
		public bool RadErgoWideAdvancedPowerOffKeypressDuration_42489_Applicable
		{
			get
			{
				short num = (short)801272274;
				short num2 = num;
				num = (short)359166418;
				switch (num2 == num)
				{
				}
				num = (short)1419051009;
				if (num != 0)
				{
				}
				num = (short)569573376;
				if (num != 0)
				{
				}
				num = (short)2100822016;
				short num3 = num;
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Applicable;
			}
			set
			{
				short num = (short)916059204;
				short num2 = num;
				num = (short)682619972;
				switch (num2 == num)
				{
				}
				num = (short)1049034752;
				if (num != 0)
				{
				}
				num = (short)396361729;
				if (num != 0)
				{
				}
				num = (short)1128529920;
				short num3 = num;
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Applicable = value;
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x060062D6 RID: 25302 RVA: 0x00589130 File Offset: 0x00587330
		// (set) Token: 0x060062D7 RID: 25303 RVA: 0x005891E4 File Offset: 0x005873E4
		public bool RadErgoWideAdvancedPowerOffKeypressDuration_42489_Valid
		{
			get
			{
				short num = (short)1141834650;
				short num2 = num;
				num = (short)297337754;
				switch (num2 == num)
				{
				}
				num = (short)1577648128;
				if (num != 0)
				{
				}
				num = (short)665649153;
				if (num != 0)
				{
				}
				num = (short)652869632;
				short num3 = num;
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Valid;
			}
			set
			{
				short num = (short)814305006;
				short num2 = num;
				num = (short)2015252206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)177078272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)245760001;
				if (num != 0)
				{
				}
				num = (short)1293746176;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Valid = value;
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x060062D8 RID: 25304 RVA: 0x0058929C File Offset: 0x0058749C
		// (set) Token: 0x060062D9 RID: 25305 RVA: 0x00589350 File Offset: 0x00587550
		public bool RadErgoWideAdvancedPowerOffKeypressDuration_42489_Visible
		{
			get
			{
				short num = (short)1128373534;
				short num2 = num;
				num = (short)1559928094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1344143360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)442695680;
				if (num != 0)
				{
				}
				num = (short)377683969;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Visible;
			}
			set
			{
				short num = (short)927599613;
				short num2 = num;
				num = (short)952503293;
				switch (num2 == num)
				{
				default:
				{
					num = (short)540934144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)9043968;
				if (num != 0)
				{
				}
				num = (short)232128513;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Visible = value;
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x00589408 File Offset: 0x00587608
		// (set) Token: 0x060062DB RID: 25307 RVA: 0x005894BC File Offset: 0x005876BC
		public bool RadErgoWideAdvancedPowerOffKeypressDuration_42489_Editable
		{
			get
			{
				short num = (short)1518960167;
				short num2 = num;
				num = (short)1059159591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)208011264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2140798976;
				if (num != 0)
				{
				}
				num = (short)1884618753;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Editable;
			}
			set
			{
				short num = (short)1473901464;
				short num2 = num;
				num = (short)290976664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1324810240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1432027137;
				if (num != 0)
				{
				}
				num = (short)425394176;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.Editable = value;
			}
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x060062DC RID: 25308 RVA: 0x00589570 File Offset: 0x00587770
		internal string RadErgoWideAdvancedPowerOffKeypressDuration_42489_UILabel
		{
			get
			{
				short num = (short)1476037250;
				short num2 = num;
				num = (short)1191742082;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1663696896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)636289024;
				if (num != 0)
				{
				}
				num = (short)780664833;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.UIName;
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x060062DD RID: 25309 RVA: 0x00589628 File Offset: 0x00587828
		// (set) Token: 0x060062DE RID: 25310 RVA: 0x005896DC File Offset: 0x005878DC
		internal bool RadErgoWideAdvancedPowerOffKeypressDuration_42489_HiddenStatic
		{
			get
			{
				short num = (short)590289148;
				short num2 = num;
				num = (short)1727207676;
				switch (num2 == num)
				{
				default:
				{
					num = (short)956301312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1502806017;
				if (num != 0)
				{
				}
				num = (short)637009920;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.HiddenStatic;
			}
			set
			{
				short num = (short)573367650;
				short num2 = num;
				num = (short)1303962978;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1247543296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420492800;
				if (num != 0)
				{
				}
				num = (short)908460033;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.HiddenStatic = value;
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x060062DF RID: 25311 RVA: 0x00589790 File Offset: 0x00587990
		// (set) Token: 0x060062E0 RID: 25312 RVA: 0x00589844 File Offset: 0x00587A44
		internal bool RadErgoWideAdvancedPowerOffKeypressDuration_42489_HiddenDynamic
		{
			get
			{
				short num = (short)2070413313;
				if (num != 0)
				{
				}
				num = (short)2127822848;
				short num2 = num;
				num = (short)1838048779;
				short num3 = num;
				num = (short)612722187;
				switch (num3 == num)
				{
				}
				num = (short)1746796544;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489.HiddenDynamic;
			}
			set
			{
				short num = (short)1174405121;
				if (num != 0)
				{
				}
				num = (short)818741248;
				short num2 = num;
				num = (short)1733407619;
				short num3 = num;
				num = (short)233157507;
				switch (num3 == num)
				{
				}
				num = (short)1841758208;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedPowerOffKeypressDuration_42489.HiddenDynamic = value;
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x060062E1 RID: 25313 RVA: 0x005898F8 File Offset: 0x00587AF8
		public bool RadErgoWideAdvancedPowerOffKeypressDuration_42489_HasDiffs
		{
			get
			{
				short num = (short)350919144;
				short num2 = num;
				num = (short)1178376680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)735510528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)332398593;
				if (num != 0)
				{
				}
				num = (short)1474166784;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedPowerOffKeypressDuration_42489._HasDiffs;
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x060062E2 RID: 25314 RVA: 0x005899AC File Offset: 0x00587BAC
		// (set) Token: 0x060062E3 RID: 25315 RVA: 0x00589A60 File Offset: 0x00587C60
		public int RadErgoWideAdvancedActiveMicForRSMPTT_43050Value
		{
			get
			{
				short num = (short)1294585473;
				short num2 = num;
				num = (short)1513606785;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1763311616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284819457;
				if (num != 0)
				{
				}
				num = (short)2023489536;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050.Value;
			}
			set
			{
				short num = (short)494243956;
				short num2 = num;
				num = (short)1779929204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2062090240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1819869185;
				if (num != 0)
				{
				}
				num = (short)1240072192;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRSMPTT_43050.Value = value;
			}
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x060062E4 RID: 25316 RVA: 0x00589B18 File Offset: 0x00587D18
		// (set) Token: 0x060062E5 RID: 25317 RVA: 0x00589BCC File Offset: 0x00587DCC
		public string RadErgoWideAdvancedActiveMicForRSMPTT_43050_UIValue
		{
			get
			{
				short num = (short)168848910;
				short num2 = num;
				num = (short)1275293198;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1126301696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)331874305;
				if (num != 0)
				{
				}
				num = (short)2025390080;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050.UIValue;
			}
			set
			{
				short num = (short)742441131;
				short num2 = num;
				num = (short)1135263915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)166789120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1266745345;
				if (num != 0)
				{
				}
				num = (short)774897664;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRSMPTT_43050.UIValue = value;
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x060062E6 RID: 25318 RVA: 0x00589C84 File Offset: 0x00587E84
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedActiveMicForRSMPTT_43050
		{
			get
			{
				short num = (short)769315555;
				short num2 = num;
				num = (short)362271459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1058013184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1537867777;
				if (num != 0)
				{
				}
				num = (short)2133917696;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050;
			}
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x060062E7 RID: 25319 RVA: 0x00589D34 File Offset: 0x00587F34
		// (set) Token: 0x060062E8 RID: 25320 RVA: 0x00589DE8 File Offset: 0x00587FE8
		public bool RadErgoWideAdvancedActiveMicForRSMPTT_43050_Applicable
		{
			get
			{
				short num = (short)1548933361;
				short num2 = num;
				num = (short)1598675185;
				switch (num2 == num)
				{
				default:
				{
					num = (short)256835584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1335754753;
				if (num != 0)
				{
				}
				num = (short)131203072;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050.Applicable;
			}
			set
			{
				short num = (short)903869125;
				short num2 = num;
				num = (short)1856303813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1765670912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)506265601;
				if (num != 0)
				{
				}
				num = (short)1157955584;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRSMPTT_43050.Applicable = value;
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x060062E9 RID: 25321 RVA: 0x00589E9C File Offset: 0x0058809C
		// (set) Token: 0x060062EA RID: 25322 RVA: 0x00589F50 File Offset: 0x00588150
		public bool RadErgoWideAdvancedActiveMicForRSMPTT_43050_Valid
		{
			get
			{
				short num = (short)658017704;
				short num2 = num;
				num = (short)316378536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2000355328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1032323073;
				if (num != 0)
				{
				}
				num = (short)1310392320;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050.Valid;
			}
			set
			{
				short num = (short)2130903041;
				if (num != 0)
				{
				}
				num = (short)716111872;
				short num2 = num;
				num = (short)1969901839;
				short num3 = num;
				num = (short)1131041039;
				switch (num3 == num)
				{
				}
				num = (short)1432748032;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRSMPTT_43050.Valid = value;
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x060062EB RID: 25323 RVA: 0x0058A008 File Offset: 0x00588208
		// (set) Token: 0x060062EC RID: 25324 RVA: 0x0058A0BC File Offset: 0x005882BC
		public bool RadErgoWideAdvancedActiveMicForRSMPTT_43050_Visible
		{
			get
			{
				short num = (short)1626612666;
				short num2 = num;
				num = (short)1433936826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1893400576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2049048577;
				if (num != 0)
				{
				}
				num = (short)216662016;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050.Visible;
			}
			set
			{
				short num = (short)1867866932;
				short num2 = num;
				num = (short)1789289268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)542900224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1988886529;
				if (num != 0)
				{
				}
				num = (short)896794624;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRSMPTT_43050.Visible = value;
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x060062ED RID: 25325 RVA: 0x0058A170 File Offset: 0x00588370
		// (set) Token: 0x060062EE RID: 25326 RVA: 0x0058A224 File Offset: 0x00588424
		public bool RadErgoWideAdvancedActiveMicForRSMPTT_43050_Editable
		{
			get
			{
				short num = (short)787677185;
				if (num != 0)
				{
				}
				num = (short)1988558848;
				short num2 = num;
				num = (short)1584885700;
				short num3 = num;
				num = (short)168390596;
				switch (num3 == num)
				{
				}
				num = (short)1209466880;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050.Editable;
			}
			set
			{
				short num = (short)1549052675;
				short num2 = num;
				num = (short)1638640387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2111897600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)879099904;
				if (num != 0)
				{
				}
				num = (short)857669633;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRSMPTT_43050.Editable = value;
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x060062EF RID: 25327 RVA: 0x0058A2DC File Offset: 0x005884DC
		internal string RadErgoWideAdvancedActiveMicForRSMPTT_43050_UILabel
		{
			get
			{
				short num = (short)1242528549;
				short num2 = num;
				num = (short)1817410341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1108017152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)967966721;
				if (num != 0)
				{
				}
				num = (short)61407232;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050.UIName;
			}
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x060062F0 RID: 25328 RVA: 0x0058A390 File Offset: 0x00588590
		// (set) Token: 0x060062F1 RID: 25329 RVA: 0x0058A444 File Offset: 0x00588644
		internal bool RadErgoWideAdvancedActiveMicForRSMPTT_43050_HiddenStatic
		{
			get
			{
				short num = (short)1364688232;
				short num2 = num;
				num = (short)1483111784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)52822016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)993525760;
				if (num != 0)
				{
				}
				num = (short)1607729153;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050.HiddenStatic;
			}
			set
			{
				short num = (short)335422824;
				short num2 = num;
				num = (short)1161176424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1797849088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)942538753;
				if (num != 0)
				{
				}
				num = (short)405078016;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRSMPTT_43050.HiddenStatic = value;
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x060062F2 RID: 25330 RVA: 0x0058A4FC File Offset: 0x005886FC
		// (set) Token: 0x060062F3 RID: 25331 RVA: 0x0058A5B0 File Offset: 0x005887B0
		internal bool RadErgoWideAdvancedActiveMicForRSMPTT_43050_HiddenDynamic
		{
			get
			{
				short num = (short)428902334;
				short num2 = num;
				num = (short)1649248190;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2080964608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)738263040;
				if (num != 0)
				{
				}
				num = (short)875692033;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050.HiddenDynamic;
			}
			set
			{
				short num = (short)1139852320;
				short num2 = num;
				num = (short)791331872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1104019456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1041170433;
				if (num != 0)
				{
				}
				num = (short)1184563200;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForRSMPTT_43050.HiddenDynamic = value;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x060062F4 RID: 25332 RVA: 0x0058A664 File Offset: 0x00588864
		public bool RadErgoWideAdvancedActiveMicForRSMPTT_43050_HasDiffs
		{
			get
			{
				short num = (short)1596746686;
				short num2 = num;
				num = (short)426404798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1472266240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2033778689;
				if (num != 0)
				{
				}
				num = (short)1641676800;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForRSMPTT_43050._HasDiffs;
			}
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x060062F5 RID: 25333 RVA: 0x0058A718 File Offset: 0x00588918
		// (set) Token: 0x060062F6 RID: 25334 RVA: 0x0058A7CC File Offset: 0x005889CC
		public int RadErgoWideAdvancedActiveMicForBTPTT_43051Value
		{
			get
			{
				short num = (short)1740018344;
				short num2 = num;
				num = (short)285840040;
				switch (num2 == num)
				{
				default:
				{
					num = (short)879820800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1704394752;
				if (num != 0)
				{
				}
				num = (short)2001666049;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051.Value;
			}
			set
			{
				short num = (short)1227751425;
				if (num != 0)
				{
				}
				num = (short)53542912;
				short num2 = num;
				num = (short)1867116573;
				short num3 = num;
				num = (short)1441460253;
				switch (num3 == num)
				{
				}
				num = (short)1773207552;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForBTPTT_43051.Value = value;
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x060062F7 RID: 25335 RVA: 0x0058A880 File Offset: 0x00588A80
		// (set) Token: 0x060062F8 RID: 25336 RVA: 0x0058A938 File Offset: 0x00588B38
		public string RadErgoWideAdvancedActiveMicForBTPTT_43051_UIValue
		{
			get
			{
				short num = (short)1897267201;
				if (num != 0)
				{
				}
				num = (short)1760231424;
				short num2 = num;
				num = (short)1505176090;
				short num3 = num;
				num = (short)1467623962;
				switch (num3 == num)
				{
				}
				num = (short)734527488;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051.UIValue;
			}
			set
			{
				short num = (short)1395824375;
				short num2 = num;
				num = (short)1021417207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)870776832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)697630721;
				if (num != 0)
				{
				}
				num = (short)1308098560;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForBTPTT_43051.UIValue = value;
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x060062F9 RID: 25337 RVA: 0x0058A9F0 File Offset: 0x00588BF0
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedActiveMicForBTPTT_43051
		{
			get
			{
				short num = (short)583743532;
				short num2 = num;
				num = (short)82130988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1205010432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1605173248;
				if (num != 0)
				{
				}
				num = (short)436600833;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051;
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x060062FA RID: 25338 RVA: 0x0058AAA4 File Offset: 0x00588CA4
		// (set) Token: 0x060062FB RID: 25339 RVA: 0x0058AB58 File Offset: 0x00588D58
		public bool RadErgoWideAdvancedActiveMicForBTPTT_43051_Applicable
		{
			get
			{
				short num = (short)438601421;
				short num2 = num;
				num = (short)1356498637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2008350720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1645543425;
				if (num != 0)
				{
				}
				num = (short)1250951168;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051.Applicable;
			}
			set
			{
				short num = (short)755731593;
				short num2 = num;
				num = (short)1266060425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)585302016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)258473985;
				if (num != 0)
				{
				}
				num = (short)83755008;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForBTPTT_43051.Applicable = value;
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x060062FC RID: 25340 RVA: 0x0058AC10 File Offset: 0x00588E10
		// (set) Token: 0x060062FD RID: 25341 RVA: 0x0058ACC4 File Offset: 0x00588EC4
		public bool RadErgoWideAdvancedActiveMicForBTPTT_43051_Valid
		{
			get
			{
				short num = (short)1929914926;
				short num2 = num;
				num = (short)867838510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)101187584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)794755073;
				if (num != 0)
				{
				}
				num = (short)970784768;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051.Valid;
			}
			set
			{
				short num = (short)1526683008;
				short num2 = num;
				num = (short)693523840;
				switch (num2 == num)
				{
				default:
				{
					num = (short)332726272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)477954049;
				if (num != 0)
				{
				}
				num = (short)1234894848;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForBTPTT_43051.Valid = value;
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x060062FE RID: 25342 RVA: 0x0058AD78 File Offset: 0x00588F78
		// (set) Token: 0x060062FF RID: 25343 RVA: 0x0058AE30 File Offset: 0x00589030
		public bool RadErgoWideAdvancedActiveMicForBTPTT_43051_Visible
		{
			get
			{
				short num = (short)165120533;
				short num2 = num;
				num = (short)31033877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1430257664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1633288192;
				if (num != 0)
				{
				}
				num = (short)126287873;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051.Visible;
			}
			set
			{
				short num = (short)174850049;
				if (num != 0)
				{
				}
				num = (short)571670528;
				short num2 = num;
				num = (short)1590192593;
				short num3 = num;
				num = (short)1625844177;
				switch (num3 == num)
				{
				}
				num = (short)1470038016;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForBTPTT_43051.Visible = value;
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x06006300 RID: 25344 RVA: 0x0058AEE8 File Offset: 0x005890E8
		// (set) Token: 0x06006301 RID: 25345 RVA: 0x0058AF9C File Offset: 0x0058919C
		public bool RadErgoWideAdvancedActiveMicForBTPTT_43051_Editable
		{
			get
			{
				short num = (short)538075990;
				short num2 = num;
				num = (short)327312214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)952303616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1313275905;
				if (num != 0)
				{
				}
				num = (short)335020032;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051.Editable;
			}
			set
			{
				short num = (short)722787223;
				short num2 = num;
				num = (short)1079434135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)57344000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)961282049;
				if (num != 0)
				{
				}
				num = (short)1178402816;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForBTPTT_43051.Editable = value;
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x06006302 RID: 25346 RVA: 0x0058B054 File Offset: 0x00589254
		internal string RadErgoWideAdvancedActiveMicForBTPTT_43051_UILabel
		{
			get
			{
				short num = (short)1860005606;
				short num2 = num;
				num = (short)1940221670;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1112342528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1684144128;
				if (num != 0)
				{
				}
				num = (short)674758657;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051.UIName;
			}
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x06006303 RID: 25347 RVA: 0x0058B10C File Offset: 0x0058930C
		// (set) Token: 0x06006304 RID: 25348 RVA: 0x0058B1C4 File Offset: 0x005893C4
		internal bool RadErgoWideAdvancedActiveMicForBTPTT_43051_HiddenStatic
		{
			get
			{
				short num = (short)790854655;
				short num2 = num;
				num = (short)32865279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)964231168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1912471552;
				if (num != 0)
				{
				}
				num = (short)574029825;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051.HiddenStatic;
			}
			set
			{
				short num = (short)45096796;
				short num2 = num;
				num = (short)1799429980;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1307967488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)188481537;
				if (num != 0)
				{
				}
				num = (short)673447936;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForBTPTT_43051.HiddenStatic = value;
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x06006305 RID: 25349 RVA: 0x0058B278 File Offset: 0x00589478
		// (set) Token: 0x06006306 RID: 25350 RVA: 0x0058B32C File Offset: 0x0058952C
		internal bool RadErgoWideAdvancedActiveMicForBTPTT_43051_HiddenDynamic
		{
			get
			{
				short num = (short)1466968841;
				short num2 = num;
				num = (short)384903945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)399114240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)985137153;
				if (num != 0)
				{
				}
				num = (short)80019456;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051.HiddenDynamic;
			}
			set
			{
				short num = (short)1072382785;
				short num2 = num;
				num = (short)219890497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2114781184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1555234817;
				if (num != 0)
				{
				}
				num = (short)1070530560;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForBTPTT_43051.HiddenDynamic = value;
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x06006307 RID: 25351 RVA: 0x0058B3E0 File Offset: 0x005895E0
		public bool RadErgoWideAdvancedActiveMicForBTPTT_43051_HasDiffs
		{
			get
			{
				short num = (short)1684133365;
				short num2 = num;
				num = (short)323606005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)590151680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)672923649;
				if (num != 0)
				{
				}
				num = (short)797376512;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForBTPTT_43051._HasDiffs;
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x06006308 RID: 25352 RVA: 0x0058B498 File Offset: 0x00589698
		// (set) Token: 0x06006309 RID: 25353 RVA: 0x0058B54C File Offset: 0x0058974C
		public int RadErgoWideAdvancedBTReceiveAudio_43052Value
		{
			get
			{
				short num = (short)562823169;
				if (num != 0)
				{
				}
				num = (short)623050752;
				short num2 = num;
				num = (short)384796519;
				short num3 = num;
				num = (short)269453159;
				switch (num3 == num)
				{
				}
				num = (short)1406074880;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052.Value;
			}
			set
			{
				short num = (short)877993829;
				short num2 = num;
				num = (short)1141186405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)815005696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)675217409;
				if (num != 0)
				{
				}
				num = (short)2099445760;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedBTReceiveAudio_43052.Value = value;
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600630A RID: 25354 RVA: 0x0058B604 File Offset: 0x00589804
		// (set) Token: 0x0600630B RID: 25355 RVA: 0x0058B6BC File Offset: 0x005898BC
		public string RadErgoWideAdvancedBTReceiveAudio_43052_UIValue
		{
			get
			{
				short num = (short)1005808128;
				short num2 = num;
				num = (short)751266304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1560346624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2020671489;
				if (num != 0)
				{
				}
				num = (short)1477640192;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052.UIValue;
			}
			set
			{
				short num = (short)532735018;
				short num2 = num;
				num = (short)711648298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)225050624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1532624896;
				if (num != 0)
				{
				}
				num = (short)2006122497;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedBTReceiveAudio_43052.UIValue = value;
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600630C RID: 25356 RVA: 0x0058B770 File Offset: 0x00589970
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedBTReceiveAudio_43052
		{
			get
			{
				short num = (short)2074387252;
				short num2 = num;
				num = (short)2094834484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1535574016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)815857665;
				if (num != 0)
				{
				}
				num = (short)1998323712;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052;
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600630D RID: 25357 RVA: 0x0058B824 File Offset: 0x00589A24
		// (set) Token: 0x0600630E RID: 25358 RVA: 0x0058B8D8 File Offset: 0x00589AD8
		public bool RadErgoWideAdvancedBTReceiveAudio_43052_Applicable
		{
			get
			{
				short num = (short)462938080;
				short num2 = num;
				num = (short)1057480672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)182910976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1921515521;
				if (num != 0)
				{
				}
				num = (short)317652992;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052.Applicable;
			}
			set
			{
				short num = (short)1285483450;
				short num2 = num;
				num = (short)1209461690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1578172416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1060110336;
				if (num != 0)
				{
				}
				num = (short)391774209;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedBTReceiveAudio_43052.Applicable = value;
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600630F RID: 25359 RVA: 0x0058B990 File Offset: 0x00589B90
		// (set) Token: 0x06006310 RID: 25360 RVA: 0x0058BA44 File Offset: 0x00589C44
		public bool RadErgoWideAdvancedBTReceiveAudio_43052_Valid
		{
			get
			{
				short num = (short)1191325018;
				short num2 = num;
				num = (short)1091579226;
				switch (num2 == num)
				{
				default:
				{
					num = (short)144179200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)865861632;
				if (num != 0)
				{
				}
				num = (short)1371078657;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052.Valid;
			}
			set
			{
				short num = (short)1101029625;
				short num2 = num;
				num = (short)601252089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)970588160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370737152;
				if (num != 0)
				{
				}
				num = (short)1691353089;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedBTReceiveAudio_43052.Valid = value;
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x06006311 RID: 25361 RVA: 0x0058BAFC File Offset: 0x00589CFC
		// (set) Token: 0x06006312 RID: 25362 RVA: 0x0058BBB0 File Offset: 0x00589DB0
		public bool RadErgoWideAdvancedBTReceiveAudio_43052_Visible
		{
			get
			{
				short num = (short)1574699778;
				short num2 = num;
				num = (short)523109122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)284426240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1847132161;
				if (num != 0)
				{
				}
				num = (short)1078460416;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052.Visible;
			}
			set
			{
				short num = (short)2034464304;
				short num2 = num;
				num = (short)689600048;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1206845440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)540344321;
				if (num != 0)
				{
				}
				num = (short)452329472;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedBTReceiveAudio_43052.Visible = value;
			}
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x06006313 RID: 25363 RVA: 0x0058BC64 File Offset: 0x00589E64
		// (set) Token: 0x06006314 RID: 25364 RVA: 0x0058BD1C File Offset: 0x00589F1C
		public bool RadErgoWideAdvancedBTReceiveAudio_43052_Editable
		{
			get
			{
				short num = (short)999908634;
				short num2 = num;
				num = (short)897148186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)22216704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)865140736;
				if (num != 0)
				{
				}
				num = (short)1691549697;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052.Editable;
			}
			set
			{
				short num = (short)2132382013;
				short num2 = num;
				num = (short)347705661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1974206464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)950534145;
				if (num != 0)
				{
				}
				num = (short)2089549824;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedBTReceiveAudio_43052.Editable = value;
			}
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x06006315 RID: 25365 RVA: 0x0058BDD4 File Offset: 0x00589FD4
		internal string RadErgoWideAdvancedBTReceiveAudio_43052_UILabel
		{
			get
			{
				short num = (short)860496194;
				short num2 = num;
				num = (short)852500802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)550371328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1147142145;
				if (num != 0)
				{
				}
				num = (short)238747648;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052.UIName;
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x06006316 RID: 25366 RVA: 0x0058BE8C File Offset: 0x0058A08C
		// (set) Token: 0x06006317 RID: 25367 RVA: 0x0058BF40 File Offset: 0x0058A140
		internal bool RadErgoWideAdvancedBTReceiveAudio_43052_HiddenStatic
		{
			get
			{
				short num = (short)1382283853;
				short num2 = num;
				num = (short)902298189;
				switch (num2 == num)
				{
				}
				num = (short)1686437888;
				short num3 = num;
				num = (short)1165426689;
				if (num != 0)
				{
				}
				num = (short)791216128;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052.HiddenStatic;
			}
			set
			{
				short num = (short)441647105;
				if (num != 0)
				{
				}
				num = (short)1909268699;
				short num2 = num;
				num = (short)1588404443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)365559808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2020737024;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedBTReceiveAudio_43052.HiddenStatic = value;
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x06006318 RID: 25368 RVA: 0x0058BFF4 File Offset: 0x0058A1F4
		// (set) Token: 0x06006319 RID: 25369 RVA: 0x0058C0A8 File Offset: 0x0058A2A8
		internal bool RadErgoWideAdvancedBTReceiveAudio_43052_HiddenDynamic
		{
			get
			{
				short num = (short)1553181130;
				short num2 = num;
				num = (short)1357425098;
				switch (num2 == num)
				{
				}
				num = (short)218628096;
				short num3 = num;
				num = (short)276824065;
				if (num != 0)
				{
				}
				num = (short)1806827520;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052.HiddenDynamic;
			}
			set
			{
				short num = (short)29074534;
				short num2 = num;
				num = (short)1700963430;
				switch (num2 == num)
				{
				}
				num = (short)611123200;
				short num3 = num;
				num = (short)5963777;
				if (num != 0)
				{
				}
				num = (short)731119616;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedBTReceiveAudio_43052.HiddenDynamic = value;
			}
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600631A RID: 25370 RVA: 0x0058C160 File Offset: 0x0058A360
		public bool RadErgoWideAdvancedBTReceiveAudio_43052_HasDiffs
		{
			get
			{
				short num = (short)377159681;
				if (num != 0)
				{
				}
				num = (short)2131097981;
				short num2 = num;
				num = (short)267057533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1352466432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1009057792;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedBTReceiveAudio_43052._HasDiffs;
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600631B RID: 25371 RVA: 0x0058C214 File Offset: 0x0058A414
		// (set) Token: 0x0600631C RID: 25372 RVA: 0x0058C2CC File Offset: 0x0058A4CC
		public int RadErgoWideAdvancedActiveMicForIndirectPTT_44816Value
		{
			get
			{
				short num = (short)1248736737;
				short num2 = num;
				num = (short)618935777;
				switch (num2 == num)
				{
				}
				num = (short)1372848128;
				short num3 = num;
				num = (short)1358495745;
				if (num != 0)
				{
				}
				num = (short)1648951296;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.Value;
			}
			set
			{
				short num = (short)462240222;
				short num2 = num;
				num = (short)1586706910;
				switch (num2 == num)
				{
				}
				num = (short)1660157952;
				short num3 = num;
				num = (short)1819738112;
				if (num != 0)
				{
				}
				num = (short)2069692417;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.Value = value;
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600631D RID: 25373 RVA: 0x0058C380 File Offset: 0x0058A580
		// (set) Token: 0x0600631E RID: 25374 RVA: 0x0058C434 File Offset: 0x0058A634
		public string RadErgoWideAdvancedActiveMicForIndirectPTT_44816_UIValue
		{
			get
			{
				short num = (short)185419353;
				short num2 = num;
				num = (short)1969440345;
				switch (num2 == num)
				{
				}
				num = (short)511311872;
				short num3 = num;
				num = (short)292749312;
				if (num != 0)
				{
				}
				num = (short)1175388161;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.UIValue;
			}
			set
			{
				short num = (short)374058690;
				short num2 = num;
				num = (short)1916579522;
				switch (num2 == num)
				{
				}
				num = (short)639500288;
				short num3 = num;
				num = (short)1396113408;
				if (num != 0)
				{
				}
				num = (short)1262813185;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.UIValue = value;
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600631F RID: 25375 RVA: 0x0058C4EC File Offset: 0x0058A6EC
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedActiveMicForIndirectPTT_44816
		{
			get
			{
				short num = (short)353435649;
				if (num != 0)
				{
				}
				num = (short)81698116;
				short num2 = num;
				num = (short)1925291332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)333709312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)169017344;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816;
			}
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x06006320 RID: 25376 RVA: 0x0058C59C File Offset: 0x0058A79C
		// (set) Token: 0x06006321 RID: 25377 RVA: 0x0058C654 File Offset: 0x0058A854
		public bool RadErgoWideAdvancedActiveMicForIndirectPTT_44816_Applicable
		{
			get
			{
				short num = (short)1808925586;
				short num2 = num;
				num = (short)1484456850;
				switch (num2 == num)
				{
				}
				num = (short)294060032;
				short num3 = num;
				num = (short)1760034816;
				if (num != 0)
				{
				}
				num = (short)1298661377;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.Applicable;
			}
			set
			{
				short num = (short)801243137;
				if (num != 0)
				{
				}
				num = (short)861267774;
				short num2 = num;
				num = (short)613082942;
				switch (num2 == num)
				{
				default:
				{
					num = (short)955383808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1457848320;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.Applicable = value;
			}
		}

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x06006322 RID: 25378 RVA: 0x0058C708 File Offset: 0x0058A908
		// (set) Token: 0x06006323 RID: 25379 RVA: 0x0058C7BC File Offset: 0x0058A9BC
		public bool RadErgoWideAdvancedActiveMicForIndirectPTT_44816_Valid
		{
			get
			{
				short num = (short)999276643;
				short num2 = num;
				num = (short)1297596515;
				switch (num2 == num)
				{
				}
				num = (short)1565786112;
				short num3 = num;
				num = (short)581107712;
				if (num != 0)
				{
				}
				num = (short)282918913;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.Valid;
			}
			set
			{
				short num = (short)1558380545;
				if (num != 0)
				{
				}
				num = (short)1851230109;
				short num2 = num;
				num = (short)284854173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1323761664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1607008256;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.Valid = value;
			}
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x06006324 RID: 25380 RVA: 0x0058C870 File Offset: 0x0058AA70
		// (set) Token: 0x06006325 RID: 25381 RVA: 0x0058C924 File Offset: 0x0058AB24
		public bool RadErgoWideAdvancedActiveMicForIndirectPTT_44816_Visible
		{
			get
			{
				short num = (short)474808321;
				if (num != 0)
				{
				}
				num = (short)848167133;
				short num2 = num;
				num = (short)1523908829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)590938112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)220397568;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.Visible;
			}
			set
			{
				short num = (short)1600192513;
				if (num != 0)
				{
				}
				num = (short)1260662531;
				short num2 = num;
				num = (short)2014260995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1719664640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1365049344;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.Visible = value;
			}
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x06006326 RID: 25382 RVA: 0x0058C9DC File Offset: 0x0058ABDC
		// (set) Token: 0x06006327 RID: 25383 RVA: 0x0058CA90 File Offset: 0x0058AC90
		public bool RadErgoWideAdvancedActiveMicForIndirectPTT_44816_Editable
		{
			get
			{
				short num = (short)332922881;
				if (num != 0)
				{
				}
				num = (short)1636260809;
				short num2 = num;
				num = (short)310598601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1779040256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)656605184;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.Editable;
			}
			set
			{
				short num = (short)841699935;
				short num2 = num;
				num = (short)1851871839;
				switch (num2 == num)
				{
				}
				num = (short)1050017792;
				short num3 = num;
				num = (short)1665204225;
				if (num != 0)
				{
				}
				num = (short)356581376;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.Editable = value;
			}
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x06006328 RID: 25384 RVA: 0x0058CB44 File Offset: 0x0058AD44
		internal string RadErgoWideAdvancedActiveMicForIndirectPTT_44816_UILabel
		{
			get
			{
				short num = (short)1216406054;
				short num2 = num;
				num = (short)307028518;
				switch (num2 == num)
				{
				}
				num = (short)1633419264;
				short num3 = num;
				num = (short)2040004608;
				if (num != 0)
				{
				}
				num = (short)1908146177;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.UIName;
			}
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x06006329 RID: 25385 RVA: 0x0058CBFC File Offset: 0x0058ADFC
		// (set) Token: 0x0600632A RID: 25386 RVA: 0x0058CCB4 File Offset: 0x0058AEB4
		internal bool RadErgoWideAdvancedActiveMicForIndirectPTT_44816_HiddenStatic
		{
			get
			{
				short num = (short)1124970953;
				short num2 = num;
				num = (short)294564297;
				switch (num2 == num)
				{
				}
				num = (short)1283850240;
				short num3 = num;
				num = (short)1729822721;
				if (num != 0)
				{
				}
				num = (short)2083586048;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.HiddenStatic;
			}
			set
			{
				short num = (short)1908686009;
				short num2 = num;
				num = (short)1611218105;
				switch (num2 == num)
				{
				}
				num = (short)1797455872;
				short num3 = num;
				num = (short)1329922049;
				if (num != 0)
				{
				}
				num = (short)1315307520;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.HiddenStatic = value;
			}
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600632B RID: 25387 RVA: 0x0058CD6C File Offset: 0x0058AF6C
		// (set) Token: 0x0600632C RID: 25388 RVA: 0x0058CE20 File Offset: 0x0058B020
		internal bool RadErgoWideAdvancedActiveMicForIndirectPTT_44816_HiddenDynamic
		{
			get
			{
				short num = (short)1055870041;
				short num2 = num;
				num = (short)1820740697;
				switch (num2 == num)
				{
				}
				num = (short)713555968;
				short num3 = num;
				num = (short)2080899073;
				if (num != 0)
				{
				}
				num = (short)1102512128;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.HiddenDynamic;
			}
			set
			{
				short num = (short)840444071;
				short num2 = num;
				num = (short)1836066983;
				switch (num2 == num)
				{
				}
				num = (short)712835072;
				short num3 = num;
				num = (short)412221440;
				if (num != 0)
				{
				}
				num = (short)1914306561;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedActiveMicForIndirectPTT_44816.HiddenDynamic = value;
			}
		}

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600632D RID: 25389 RVA: 0x0058CED8 File Offset: 0x0058B0D8
		public bool RadErgoWideAdvancedActiveMicForIndirectPTT_44816_HasDiffs
		{
			get
			{
				short num = (short)627245057;
				if (num != 0)
				{
				}
				num = (short)1976372211;
				short num2 = num;
				num = (short)812977139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)579403776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2058551296;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedActiveMicForIndirectPTT_44816._HasDiffs;
			}
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600632E RID: 25390 RVA: 0x0058CF8C File Offset: 0x0058B18C
		// (set) Token: 0x0600632F RID: 25391 RVA: 0x0058D040 File Offset: 0x0058B240
		public bool RadErgoWideAdvancedTouchScreenLockEnableValue
		{
			get
			{
				short num = (short)1954186982;
				short num2 = num;
				num = (short)89360102;
				switch (num2 == num)
				{
				}
				num = (short)673054720;
				short num3 = num;
				num = (short)1459159041;
				if (num != 0)
				{
				}
				num = (short)999096320;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable.Value;
			}
			set
			{
				short num = (short)2083108630;
				short num2 = num;
				num = (short)1562097430;
				switch (num2 == num)
				{
				}
				num = (short)1592328192;
				short num3 = num;
				num = (short)1758330880;
				if (num != 0)
				{
				}
				num = (short)25034753;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedTouchScreenLockEnable.Value = value;
			}
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x06006330 RID: 25392 RVA: 0x0058D0F8 File Offset: 0x0058B2F8
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideAdvancedTouchScreenLockEnable
		{
			get
			{
				short num = (short)316080129;
				if (num != 0)
				{
				}
				num = (short)637029490;
				short num2 = num;
				num = (short)1666272370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1907294208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)145293312;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable;
			}
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x06006331 RID: 25393 RVA: 0x0058D1AC File Offset: 0x0058B3AC
		// (set) Token: 0x06006332 RID: 25394 RVA: 0x0058D260 File Offset: 0x0058B460
		public bool RadErgoWideAdvancedTouchScreenLockEnable_UIValue
		{
			get
			{
				short num = (short)1252678002;
				short num2 = num;
				num = (short)21191026;
				switch (num2 == num)
				{
				}
				num = (short)1145176064;
				short num3 = num;
				num = (short)2096955393;
				if (num != 0)
				{
				}
				num = (short)259522560;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable.Value;
			}
			set
			{
				short num = (short)232663952;
				short num2 = num;
				num = (short)1686842256;
				switch (num2 == num)
				{
				}
				num = (short)566427648;
				short num3 = num;
				num = (short)267583489;
				if (num != 0)
				{
				}
				num = (short)635437056;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedTouchScreenLockEnable.Value = value;
			}
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x06006333 RID: 25395 RVA: 0x0058D318 File Offset: 0x0058B518
		// (set) Token: 0x06006334 RID: 25396 RVA: 0x0058D3D0 File Offset: 0x0058B5D0
		public bool RadErgoWideAdvancedTouchScreenLockEnable_Applicable
		{
			get
			{
				short num = (short)2067922945;
				if (num != 0)
				{
				}
				num = (short)1702176556;
				short num2 = num;
				num = (short)740697900;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1675362304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931149312;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable.Applicable;
			}
			set
			{
				short num = (short)878239568;
				short num2 = num;
				num = (short)647683920;
				switch (num2 == num)
				{
				}
				num = (short)529858560;
				short num3 = num;
				num = (short)78512128;
				if (num != 0)
				{
				}
				num = (short)72941569;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedTouchScreenLockEnable.Applicable = value;
			}
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x06006335 RID: 25397 RVA: 0x0058D488 File Offset: 0x0058B688
		// (set) Token: 0x06006336 RID: 25398 RVA: 0x0058D53C File Offset: 0x0058B73C
		public bool RadErgoWideAdvancedTouchScreenLockEnable_Valid
		{
			get
			{
				short num = (short)120136955;
				short num2 = num;
				num = (short)1526277371;
				switch (num2 == num)
				{
				}
				num = (short)813432832;
				short num3 = num;
				num = (short)1221197824;
				if (num != 0)
				{
				}
				num = (short)980549633;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable.Valid;
			}
			set
			{
				short num = (short)186767507;
				short num2 = num;
				num = (short)23386259;
				switch (num2 == num)
				{
				}
				num = (short)670105600;
				short num3 = num;
				num = (short)820510721;
				if (num != 0)
				{
				}
				num = (short)480641024;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedTouchScreenLockEnable.Valid = value;
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x06006337 RID: 25399 RVA: 0x0058D5F4 File Offset: 0x0058B7F4
		// (set) Token: 0x06006338 RID: 25400 RVA: 0x0058D6A8 File Offset: 0x0058B8A8
		public bool RadErgoWideAdvancedTouchScreenLockEnable_Visible
		{
			get
			{
				short num = (short)538574849;
				if (num != 0)
				{
				}
				num = (short)1661551124;
				short num2 = num;
				num = (short)420561428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)868483072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)511770624;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable.Visible;
			}
			set
			{
				short num = (short)2033836362;
				short num2 = num;
				num = (short)204792138;
				switch (num2 == num)
				{
				}
				num = (short)2016083968;
				short num3 = num;
				num = (short)1207042048;
				if (num != 0)
				{
				}
				num = (short)656211969;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedTouchScreenLockEnable.Visible = value;
			}
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x06006339 RID: 25401 RVA: 0x0058D75C File Offset: 0x0058B95C
		// (set) Token: 0x0600633A RID: 25402 RVA: 0x0058D814 File Offset: 0x0058BA14
		public bool RadErgoWideAdvancedTouchScreenLockEnable_Editable
		{
			get
			{
				short num = (short)2083409419;
				short num2 = num;
				num = (short)30166539;
				switch (num2 == num)
				{
				}
				num = (short)732823552;
				short num3 = num;
				num = (short)773324800;
				if (num != 0)
				{
				}
				num = (short)399966209;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable.Editable;
			}
			set
			{
				short num = (short)1590022709;
				short num2 = num;
				num = (short)120705589;
				switch (num2 == num)
				{
				}
				num = (short)260898816;
				short num3 = num;
				num = (short)93454337;
				if (num != 0)
				{
				}
				num = (short)1361182720;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedTouchScreenLockEnable.Editable = value;
			}
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600633B RID: 25403 RVA: 0x0058D8C8 File Offset: 0x0058BAC8
		internal string RadErgoWideAdvancedTouchScreenLockEnable_UILabel
		{
			get
			{
				short num = (short)205421301;
				short num2 = num;
				num = (short)14908149;
				switch (num2 == num)
				{
				}
				num = (short)1881473024;
				short num3 = num;
				num = (short)338624513;
				if (num != 0)
				{
				}
				num = (short)891092992;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable.UIName;
			}
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600633C RID: 25404 RVA: 0x0058D97C File Offset: 0x0058BB7C
		// (set) Token: 0x0600633D RID: 25405 RVA: 0x0058DA30 File Offset: 0x0058BC30
		internal bool RadErgoWideAdvancedTouchScreenLockEnable_HiddenStatic
		{
			get
			{
				short num = (short)153235851;
				short num2 = num;
				num = (short)793784715;
				switch (num2 == num)
				{
				}
				num = (short)193724416;
				short num3 = num;
				num = (short)1468203009;
				if (num != 0)
				{
				}
				num = (short)1465188352;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable.HiddenStatic;
			}
			set
			{
				short num = (short)1363086687;
				short num2 = num;
				num = (short)2043350367;
				switch (num2 == num)
				{
				}
				num = (short)157417472;
				short num3 = num;
				num = (short)26869760;
				if (num != 0)
				{
				}
				num = (short)1267269633;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedTouchScreenLockEnable.HiddenStatic = value;
			}
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600633E RID: 25406 RVA: 0x0058DAE8 File Offset: 0x0058BCE8
		// (set) Token: 0x0600633F RID: 25407 RVA: 0x0058DB98 File Offset: 0x0058BD98
		internal bool RadErgoWideAdvancedTouchScreenLockEnable_HiddenDynamic
		{
			get
			{
				short num = (short)1449303062;
				short num2 = num;
				num = (short)1780325398;
				switch (num2 == num)
				{
				}
				num = (short)145883136;
				short num3 = num;
				num = (short)1915420672;
				if (num != 0)
				{
				}
				num = (short)615514113;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable.HiddenDynamic;
			}
			set
			{
				short num = (short)1173504269;
				short num2 = num;
				num = (short)541475085;
				switch (num2 == num)
				{
				}
				num = (short)1212940288;
				short num3 = num;
				num = (short)1592786945;
				if (num != 0)
				{
				}
				num = (short)349569024;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedTouchScreenLockEnable.HiddenDynamic = value;
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x06006340 RID: 25408 RVA: 0x0058DC50 File Offset: 0x0058BE50
		public bool RadErgoWideAdvancedTouchScreenLockEnable_HasDiffs
		{
			get
			{
				short num = (short)1296199842;
				short num2 = num;
				num = (short)422801570;
				switch (num2 == num)
				{
				}
				num = (short)1674575872;
				short num3 = num;
				num = (short)1313406977;
				if (num != 0)
				{
				}
				num = (short)572850176;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedTouchScreenLockEnable._HasDiffs;
			}
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x06006341 RID: 25409 RVA: 0x0058DD08 File Offset: 0x0058BF08
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1255407617;
				if (num != 0)
				{
				}
				num = (short)59165884;
				short num2 = num;
				num = (short)446090428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)794689536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)343146496;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x06006342 RID: 25410 RVA: 0x0058DDC8 File Offset: 0x0058BFC8
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK RefDEK
		{
			get
			{
				short num = (short)2093875201;
				if (num != 0)
				{
				}
				num = (short)45342872;
				short num2 = num;
				num = (short)321183896;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1673134080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1668153344;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2129)[0] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK;
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x06006343 RID: 25411 RVA: 0x0058DE88 File Offset: 0x0058C088
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1658633206;
				short num2 = num;
				num = (short)1680522230;
				switch (num2 == num)
				{
				}
				num = (short)135856128;
				short num3 = num;
				num = (short)558301185;
				if (num != 0)
				{
				}
				num = (short)245825536;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x06006344 RID: 25412 RVA: 0x0058DF48 File Offset: 0x0058C148
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)947789692;
				short num2 = num;
				num = (short)857153404;
				switch (num2 == num)
				{
				}
				num = (short)297205761;
				if (num != 0)
				{
				}
				num = (short)1818099712;
				short num3 = num;
				num = (short)1446248448;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x06006345 RID: 25413 RVA: 0x0058E004 File Offset: 0x0058C204
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2 RefControlHeadO2
		{
			get
			{
				short num = (short)1852400669;
				short num2 = num;
				num = (short)1052140573;
				switch (num2 == num)
				{
				}
				num = (short)1609039872;
				if (num != 0)
				{
				}
				num = (short)534118400;
				short num3 = num;
				num = (short)73924609;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4115)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2;
			}
		}

		// Token: 0x06006346 RID: 25414 RVA: 0x0058E0C0 File Offset: 0x0058C2C0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_6E;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1832987772;
				short num2 = num;
				num = (short)1441279100;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6E;
				default:
					num = (short)1780154368;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)751632385;
						if (num != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)2142175234;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)700383233;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (base.ParentRecset != null)
						{
							num = (short)718929924;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
					{
						num = (short)1146617856;
						short num4 = num;
						num = (short)151519232;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6E;
				}
			}
			return result;
			IL_6E:
			result = null;
			num = (short)836501507;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04002603 RID: 9731
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedLogicalSwitch2_A7756;

		// Token: 0x04002604 RID: 9732
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideMOSCADDataEnable_A8545;

		// Token: 0x04002605 RID: 9733
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787;

		// Token: 0x04002606 RID: 9734
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideAdvancedRotarySwitchLockEnable_A8987;

		// Token: 0x04002607 RID: 9735
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedSoftPowerOff_A9170;

		// Token: 0x04002608 RID: 9736
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedVolumeControlLockoutWithRSMSelection_A22244;

		// Token: 0x04002609 RID: 9737
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedChannelControlLockoutWithRSMSelection_A22245;

		// Token: 0x0400260A RID: 9738
		private global::AcpBusinessLayer.AcpField<bool> radioErgoCfgExternalAccessoryEnable_A36198;

		// Token: 0x0400260B RID: 9739
		private global::AcpBusinessLayer.AcpField<bool> radioErgoCfgFatalError_A36202;

		// Token: 0x0400260C RID: 9740
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideAdvancedFixedVolumeEnable_A37218;

		// Token: 0x0400260D RID: 9741
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideAdvancedToggleSwitchLockEnable_43773;

		// Token: 0x0400260E RID: 9742
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedFixedVolumeLevel_A37219;

		// Token: 0x0400260F RID: 9743
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedDefaultCHHubState_A37222;

		// Token: 0x04002610 RID: 9744
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideAdvancedConsoletteEnable_A37231;

		// Token: 0x04002611 RID: 9745
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideAdvancedConsoletteFatalError_A37233;

		// Token: 0x04002612 RID: 9746
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedNumberofZoneBanks_A37256;

		// Token: 0x04002613 RID: 9747
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedZoneBankOperation_A37543;

		// Token: 0x04002614 RID: 9748
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedShortKeypressDurationms_A9125;

		// Token: 0x04002615 RID: 9749
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126;

		// Token: 0x04002616 RID: 9750
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451;

		// Token: 0x04002617 RID: 9751
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedLongKeypressDurationms_A8450;

		// Token: 0x04002618 RID: 9752
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedShortKeypressDurationforMFK_A38505;

		// Token: 0x04002619 RID: 9753
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedLongKeypressDurationforMFK_A38506;

		// Token: 0x0400261A RID: 9754
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedMFKInactivityTimeout_A38507;

		// Token: 0x0400261B RID: 9755
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideAdvancedSideButtonsLockEnable_A38725;

		// Token: 0x0400261C RID: 9756
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedActiveMicForRadioPTT_A38766;

		// Token: 0x0400261D RID: 9757
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideAdvancedLastSelectedChannelPerZone_A41073;

		// Token: 0x0400261E RID: 9758
		private global::AcpBusinessLayer.AcpRangeField<int, int> radErgoWideSideAdvancedMFBInactivityTimeout_A41565;

		// Token: 0x0400261F RID: 9759
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedKeypadControlsLockKeyPressType_A41569;

		// Token: 0x04002620 RID: 9760
		private global::AcpBusinessLayer.AcpListField radWideNVGBacklightBrightnessLevel_A41616;

		// Token: 0x04002621 RID: 9761
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedPowerOffKeypressDuration_42489;

		// Token: 0x04002622 RID: 9762
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedActiveMicForRSMPTT_43050;

		// Token: 0x04002623 RID: 9763
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedActiveMicForBTPTT_43051;

		// Token: 0x04002624 RID: 9764
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedBTReceiveAudio_43052;

		// Token: 0x04002625 RID: 9765
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedActiveMicForIndirectPTT_44816;

		// Token: 0x04002626 RID: 9766
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideAdvancedTouchScreenLockEnable;
	}
}
