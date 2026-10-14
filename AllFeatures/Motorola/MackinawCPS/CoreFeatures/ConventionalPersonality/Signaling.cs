using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.ToneSignalingList;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005CD RID: 1485
	[global::System.Serializable]
	public class Signaling : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CC50 RID: 52304 RVA: 0x00BE6364 File Offset: 0x00BE4564
		public Signaling(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600CC51 RID: 52305 RVA: 0x00BE6380 File Offset: 0x00BE4580
		protected Signaling(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CC52 RID: 52306 RVA: 0x00BE6398 File Offset: 0x00BE4598
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1685570405;
			short num2 = num;
			num = (short)218547045;
			switch (num2 == num)
			{
			}
			num = (short)1182728193;
			if (num != 0)
			{
			}
			num = (short)227082240;
			short num3 = num;
			num = (short)1790443520;
			if (num != 0)
			{
			}
			this.cnvPerSignalingASTROSystem_A7498 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮냰ꃲꇴꗶ뛸꣺蓼賾甀昂栄堆䠈㰊㤌㘎⤐", a_), global::CommonResources.AcgResources.ID_ASTROASTROSYSTEM, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.cnvPerSignalingASTROSystem_A7498.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerSignalingASTROSystem_A7498.DataTransferOrder = 42;
			this.cnvPerSignalingASTROSystem_A7498.EvaluateRecRefs = true;
			this.cnvPerSignalingDigitalModulatorType_A7857 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerSignalingDigitalModulatorType_A7857LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerSignalingDigitalModulatorType_A7857LovStrs), this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮뗰髲鋴黶跸髺釼닾渀朂瀄欆栈缊戌紎䔐樒攔爖䘘娚⨜✞ᐠᐢ", a_), global::CommonResources.AcgResources.ID_ASTRODIGITALMODULATORTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSignalingDigitalModulatorType_A7857LovStrs);
			this.cnvPerSignalingDigitalModulatorType_A7857.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerSignalingDigitalModulatorType_A7857.DataTransferOrder = 30;
			this.cnvPerSignalingEmergencyPTTID_A7944 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮듰黲郴藶黸黺鏼鳾砀匂億匆䀈伊刌与☐⨒℔⌖", a_), global::CommonResources.AcgResources.ID_NONASTROEMERGENCYPTTID);
			this.cnvPerSignalingEmergencyPTTID_A7944.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSignalingEmergencyPTTID_A7944.DataTransferOrder = 109;
			this.cnvPerSignalingLateEntryFastUnmute_A8423 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮뷰鋲致鋶본闺觼跾砀䔂搄理紈帊挌戎搐朒瀔䠖堘⌚⤜ⴞሠ", a_), global::CommonResources.AcgResources.ID_ASTROLATEENTRYFASTUNMUTE);
			this.cnvPerSignalingLateEntryFastUnmute_A8423.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerSignalingLateEntryFastUnmute_A8423.DataTransferOrder = 76;
			this.cnvPerSignalingPTTID_A8770 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꇰꟲꇴ뻶뷸ꓺ볼쟾㘀㐂㔄", a_), global::CommonResources.AcgResources.ID_NONASTROPTTID);
			this.cnvPerSignalingPTTID_A8770.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSignalingPTTID_A8770.DataTransferOrder = 95;
			this.cnvPerSignalingRevertType_A8953 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerSignalingRevertType_A8953LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerSignalingRevertType_A8953LovStrs), this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꏰ雲菴鋶诸迺ꧼ蛾焀昂娄䘆ㄈ㈊㠌㰎", a_), global::CommonResources.AcgResources.ID_EMERGENCYREVERTREVERTTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSignalingRevertType_A8953LovStrs);
			this.cnvPerSignalingRevertType_A8953.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSignalingRevertType_A8953.DataTransferOrder = 34;
			this.cnvPerSignalingASTRORxUnmuteRule_A9042 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮냰ꃲꇴꗶ뛸ꧺ藼꫾漀渂瀄猆氈夊砌挎琐䰒吔⸖⤘⼚⼜", a_), global::CommonResources.AcgResources.ID_ASTROASTRORXUNMUTERULE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSignalingASTRORxUnmuteRule_A9042LovStrs);
			this.cnvPerSignalingASTRORxUnmuteRule_A9042.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSignalingASTRORxUnmuteRule_A9042.DataTransferOrder = 120;
			this.cnvPerSignalingSignalingType_A9129 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerSignalingSignalingType_A9129LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerSignalingSignalingType_A9129LovStrs), this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꋰ髲鋴駶飸韺铼釾昀圂簄眆氈吊䰌㘎‐ℒⰔ", a_), global::CommonResources.AcgResources.ID_NONASTROSIGNALINGTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSignalingSignalingType_A9129LovStrs);
			this.cnvPerSignalingSignalingType_A9129.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerSignalingSignalingType_A9129.DataTransferOrder = 4;
			this.cnvPerSignalingSystemNumber_A9243 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꋰ諲蛴菶鳸雺돼諾氀愂怄甆嘈䨊㐌㴎┐‒", a_), global::CommonResources.AcgResources.ID_NONASTROSYSTEMNUMBER, null, null, true, false);
			this.cnvPerSignalingSystemNumber_A9243.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerSignalingSystemNumber_A9243.DataTransferOrder = 10;
			this.cnvPerSignalingRevertZone_A13269 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꏰ雲菴鋶诸迺ꟼ郾漀昂娄䘆㠈㠊㼌㤎⠐", a_), global::CommonResources.AcgResources.ID_EMERGENCYREVERTREVERTZONE, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.cnvPerSignalingRevertZone_A13269.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSignalingRevertZone_A13269.DataTransferOrder = 107;
			this.cnvPerSignalingRevertChannel_A13267 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꏰ雲菴鋶诸迺뻼韾怀洂欄戆攈吊䰌㸎∐ℒ⌔‖", a_), global::CommonResources.AcgResources.ID_EMERGENCYREVERTREVERTCHANNEL, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.cnvPerSignalingRevertChannel_A13267.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSignalingRevertChannel_A13267.DataTransferOrder = 127;
			this.cnvPerSignalingRevertTGWACNID_A40150 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꏰ雲菴鋶诸迺ꧼ룾嘀䈂䘄䤆䀈伊刌与┐⌒␔∖⤘", a_), global::CommonResources.AcgResources.ID_REVERTTALKGROUPREVERTTGWACNID, 0, 1048574, 1, null, null);
			this.cnvPerSignalingRevertTGWACNID_A40150.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerSignalingRevertTGWACNID_A40150.DataTransferOrder = -1;
			this.cnvPerSignalingRevertTGWACNID_A40150.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
			this.cnvPerSignalingRevertTGWACNID_A40150.ShowHexValue = true;
			this.cnvPerSignalingRevertTGWACNID_A40150.ShowLeadingZeros = true;
			this.cnvPerSignalingRevertTGSYSID_A40151 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꏰ雲菴鋶诸迺ꧼ룾刀娂嘄丆䴈吊䰌㬎ℐ−—☖", a_), global::CommonResources.AcgResources.ID_REVERTTALKGROUPREVERTTGSYSTEMID, 0, 4094, 1, null, null);
			this.cnvPerSignalingRevertTGSYSID_A40151.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerSignalingRevertTGSYSID_A40151.DataTransferOrder = -1;
			this.cnvPerSignalingRevertTGSYSID_A40151.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
			this.cnvPerSignalingRevertTGSYSID_A40151.ShowHexValue = true;
			this.cnvPerSignalingRevertTGSYSID_A40151.ShowLeadingZeros = true;
			this.cnvPerSignalingRevertTG_A40152 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꏰ雲菴鋶诸迺ꧼ룾帀䈂㄄㜆㠈㸊㼌", a_), global::CommonResources.AcgResources.ID_REVERTTALKGROUPREVERTTALKGROUP, 1, 65534, null, null, 0, 1);
			this.cnvPerSignalingRevertTG_A40152.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSignalingRevertTG_A40152.DataTransferOrder = 133;
			this.cnvPerSignalingRevertTG_A40152.ShowHexValue = true;
			this.cnvPerSignalingRevertTGSecClearStrap_A40153 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꏰ雲菴鋶诸迺ꧼ룾刀昂昄䐆攈渊氌紎䈐朒朔瘖椘䐚尜⬞ᄠሢဤᐦ", a_), global::CommonResources.AcgResources.ID_REVERTTALKGROUPREVERTTGSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSignalingRevertTGSecClearStrap_A40153LovStrs);
			this.cnvPerSignalingRevertTGSecClearStrap_A40153.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSignalingRevertTGSecClearStrap_A40153.DataTransferOrder = 134;
			this.cnvPerSignalingRevertTGKeySel_A40154 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜賞裠蓢诤蛦藨苪菬裮ꏰ雲菴鋶诸迺ꧼ룾䨀昂簄吆氈朊刌与┐⌒␔∖ⴘ", a_), global::CommonResources.AcgResources.ID_REVERTTALKGROUPREVERTTGKEYSELECT, null, null, true, false);
			this.cnvPerSignalingRevertTGKeySel_A40154.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSignalingRevertTGKeySel_A40154.DataTransferOrder = 135;
			this.cnvPerFeaturesAstroAlertingToneTable = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜駞蓠苢釤鋦鯨軪黬껮苰蟲蟴飶룸韺飼跾甀樂欄怆崈搊挌樎䔐爒眔笖簘", a_), global::CommonResources.AcgResources.ID_TONESIGNALINGLIST, new string[]
			{
				global::CommonResources.AcgResources.ID_TONESIGNALINGDISABLED
			}, new int[1], true, false, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LegacyTitles.CnvPerFeaturesAstroAlertingToneTableLegacyTitles);
			this.cnvPerFeaturesAstroAlertingToneTable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerFeaturesAstroAlertingToneTable.DataTransferOrder = 82;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胒볔냖럘뫚뇜뛞迠蓢", a_);
			base.Id = 10144;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALING;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600CC53 RID: 52307 RVA: 0x00BE6974 File Offset: 0x00BE4B74
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)867631114;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvPerSignalingSystemNumber_A9243 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢뛤黦髨鿪裬苮뿰蛲飴闶鳸觺ꋼ뻾㠀㄂㄄㐆", a_), global::CommonResources.AcgResources.ID_NONASTROSYSTEMNUMBER, null, null, true, false);
					this.cnvPerSignalingSystemNumber_A9243.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerSignalingSystemNumber_A9243.DataTransferOrder = 10;
					num = (short)769916960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.cnvPerSignalingRevertTGSecClearStrap_A40153 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ듲꛴鋶髸룺釼髾怀焂嘄猆笈樊紌倎倐✒└☖Ⱈ⠚", a_), global::CommonResources.AcgResources.ID_REVERTTALKGROUPREVERTTGSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSignalingRevertTGSecClearStrap_A40153LovStrs);
					this.cnvPerSignalingRevertTGSecClearStrap_A40153.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSignalingRevertTGSecClearStrap_A40153.DataTransferOrder = 134;
					num = (short)279642160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_A69;
				case 3:
					this.cnvPerSignalingLateEntryFastUnmute_A8423 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢ꧤ蛦鷨軪꣬臮藰臲賴뇶飸裺觼꫾漀渂瀄猆氈吊䰌㜎┐ℒ☔", a_), global::CommonResources.AcgResources.ID_ASTROLATEENTRYFASTUNMUTE);
					this.cnvPerSignalingLateEntryFastUnmute_A8423.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerSignalingLateEntryFastUnmute_A8423.DataTransferOrder = 76;
					num = (short)722141186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.cnvPerSignalingDigitalModulatorType_A7857 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerSignalingDigitalModulatorType_A7857LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerSignalingDigitalModulatorType_A7857LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢ꇤ軦軨苪駬軮鷰뻲髴鏶賸韺鳼课渀焂億縆礈渊刌与☐⬒—‖", a_), global::CommonResources.AcgResources.ID_ASTRODIGITALMODULATORTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSignalingDigitalModulatorType_A7857LovStrs);
					this.cnvPerSignalingDigitalModulatorType_A7857.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerSignalingDigitalModulatorType_A7857.DataTransferOrder = 30;
					num = (short)2129002522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.cnvPerSignalingRevertTGWACNID_A40150 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ듲ꋴ뛶뫸뗺듼믾帀䈂㄄㜆㠈㸊㴌", a_), global::CommonResources.AcgResources.ID_REVERTTALKGROUPREVERTTGWACNID, null, null);
					this.cnvPerSignalingRevertTGWACNID_A40150.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvPerSignalingRevertTGWACNID_A40150.DataTransferOrder = -1;
					this.cnvPerSignalingRevertTGWACNID_A40150.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
					this.cnvPerSignalingRevertTGWACNID_A40150.ShowHexValue = true;
					this.cnvPerSignalingRevertTGWACNID_A40150.ShowLeadingZeros = true;
					num = (short)1431306254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1659437098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢뛤黦髨鿪裬苮뿰蛲飴闶鳸觺ꋼ뻾㠀㄂㄄㐆", a_)))
					{
						num = (short)2038693888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B0;
				case 8:
					goto IL_C93;
				case 9:
					goto IL_541;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_10A;
					}
					continue;
				case 11:
					this.cnvPerSignalingRevertType_A8953 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerSignalingRevertType_A8953LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerSignalingRevertType_A8953LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ諲藴鋶꛸뫺염웾㐀。", a_), global::CommonResources.AcgResources.ID_EMERGENCYREVERTREVERTTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSignalingRevertType_A8953LovStrs);
					this.cnvPerSignalingRevertType_A8953.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSignalingRevertType_A8953.DataTransferOrder = 34;
					num = (short)789381129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_87D;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ듲ꫴ뛶췸쯺쳼쫾㌀", a_)))
					{
						num = (short)1497497630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C93;
				case 14:
					goto IL_CE1;
				case 15:
					goto IL_8CC;
				case 16:
					this.cnvPerSignalingASTRORxUnmuteRule_A9042 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢ꓤ듦뷨맪ꋬ뷮觰꛲鯴髶賸迺飼귾琀漂怄堆䠈㈊㴌㬎⌐", a_), global::CommonResources.AcgResources.ID_ASTROASTRORXUNMUTERULE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSignalingASTRORxUnmuteRule_A9042LovStrs);
					this.cnvPerSignalingASTRORxUnmuteRule_A9042.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSignalingASTRORxUnmuteRule_A9042.DataTransferOrder = 120;
					num = (short)799932428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_1FD;
				case 18:
					goto IL_53C;
				case 19:
					this.cnvPerSignalingRevertTGKeySel_A40154 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ듲뻴鋶胸꣺飼鏾帀䈂㄄㜆㠈㸊㤌", a_), global::CommonResources.AcgResources.ID_REVERTTALKGROUPREVERTTGKEYSELECT, null, null, true, false);
					this.cnvPerSignalingRevertTGKeySel_A40154.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSignalingRevertTGKeySel_A40154.DataTransferOrder = 135;
					num = (short)1092812854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)1231880193;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢ꓤ듦뷨맪ꋬ뷮觰꛲鯴髶賸迺飼귾琀漂怄堆䠈㈊㴌㬎⌐", a_)))
					{
						num = (short)187695120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_87D;
				case 21:
					this.cnvPerSignalingRevertChannel_A13267 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮닰鯲铴駶韸黺釼ꃾ䀀㈂㘄㔆㼈㰊", a_), global::CommonResources.AcgResources.ID_EMERGENCYREVERTREVERTCHANNEL, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.cnvPerSignalingRevertChannel_A13267.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSignalingRevertChannel_A13267.DataTransferOrder = 127;
					num = (short)601292845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
				{
					num = (short)663224320;
					short num3 = num;
					this.cnvPerSignalingEmergencyPTTID_A7944 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢ꃤ諦賨駪諬諮鿰郲賴ꟶ그꿺듼믾帀䈂㈄㸆㴈㼊", a_), global::CommonResources.AcgResources.ID_NONASTROEMERGENCYPTTID);
					this.cnvPerSignalingEmergencyPTTID_A7944.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSignalingEmergencyPTTID_A7944.DataTransferOrder = 109;
					num = (short)1124270097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ諲藴鋶꛸뫺염웾㐀。", a_)))
					{
						num = (short)907083787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_541;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮닰鯲铴駶韸黺釼ꃾ䀀㈂㘄㔆㼈㰊", a_)))
					{
						num = (short)954597397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31D;
				case 25:
					num = (short)1455161372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_66E;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ듲꛴껶꫸닺맼ꃾ䀀㜂㔄㘆㰈㨊", a_)))
					{
						num = (short)735182892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9B1;
				case 28:
					if (producerFields != null)
					{
						num = (short)2076835846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF4;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢ꇤ軦軨苪駬軮鷰뻲髴鏶賸韺鳼课渀焂億縆礈渊刌与☐⬒—‖", a_)))
					{
						num = (short)2006646788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66E;
				case 30:
					this.cnvPerSignalingRevertTG_A40152 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ듲ꫴ뛶췸쯺쳼쫾㌀", a_), global::CommonResources.AcgResources.ID_REVERTTALKGROUPREVERTTALKGROUP, null, null, 0, 1);
					this.cnvPerSignalingRevertTG_A40152.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSignalingRevertTG_A40152.DataTransferOrder = 133;
					this.cnvPerSignalingRevertTG_A40152.ShowHexValue = true;
					num = (short)2065825800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					this.cnvPerSignalingRevertZone_A13269 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮꯰鳲鯴鋶꛸뫺쳼쳾㌀㔂㰄", a_), global::CommonResources.AcgResources.ID_EMERGENCYREVERTREVERTZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.cnvPerSignalingRevertZone_A13269.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSignalingRevertZone_A13269.DataTransferOrder = 107;
					num = (short)77004815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_1B0;
				case 33:
					IL_DEF:
					goto IL_965;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ듲꛴鋶髸룺釼髾怀焂嘄猆笈樊紌倎倐✒└☖Ⱈ⠚", a_)))
					{
						num = (short)503250945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_710;
				case 35:
					this.cnvPerSignalingSignalingType_A9129 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerSignalingSignalingType_A9129LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerSignalingSignalingType_A9129LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢뛤軦軨藪賬菮飰鷲鋴ꏶ胸诺飼ꃾ䀀㨂㐄㔆〈", a_), global::CommonResources.AcgResources.ID_NONASTROSIGNALINGTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSignalingSignalingType_A9129LovStrs);
					this.cnvPerSignalingSignalingType_A9129.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerSignalingSignalingType_A9129.DataTransferOrder = 4;
					num = (short)845021236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					goto IL_918;
				case 37:
					this.cnvPerFeaturesAstroAlertingToneTable = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ闒냔뛖귘껚꿜뫞鋠ꋢ雤鏦鯨蓪곬菮铰臲致黶韸鳺ꧼ郾漀昂億昆欈朊栌", a_), global::CommonResources.AcgResources.ID_TONESIGNALINGLIST, new string[]
					{
						global::CommonResources.AcgResources.ID_TONESIGNALINGDISABLED
					}, new int[1], true, false, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LegacyTitles.CnvPerFeaturesAstroAlertingToneTableLegacyTitles);
					this.cnvPerFeaturesAstroAlertingToneTable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerFeaturesAstroAlertingToneTable.DataTransferOrder = 82;
					num = (short)2052259858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_9B1;
				case 39:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢뛤軦軨藪賬菮飰鷲鋴ꏶ胸诺飼ꃾ䀀㨂㐄㔆〈", a_)))
					{
						num = (short)1256783907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C45;
				case 40:
					this.cnvPerSignalingPTTID_A8770 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢뗤돦뷨ꋪꧬ냮냰쯲싴샶째", a_), global::CommonResources.AcgResources.ID_NONASTROPTTID);
					this.cnvPerSignalingPTTID_A8770.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSignalingPTTID_A8770.DataTransferOrder = 95;
					num = (short)1123352612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢ꧤ蛦鷨軪꣬臮藰臲賴뇶飸裺觼꫾漀渂瀄猆氈吊䰌㜎┐ℒ☔", a_)))
					{
						num = (short)145752067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A69;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢ꓤ듦뷨맪ꋬ볮裰胲致鋶铸ꓺ볼죾㔀㨂㴄", a_)))
					{
						num = (short)6619183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_965;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢뗤돦뷨ꋪꧬ냮냰쯲싴샶째", a_)))
					{
						num = (short)262275112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_918;
				case 44:
					this.cnvPerSignalingRevertTGSYSID_A40151 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ듲꛴껶꫸닺맼ꃾ䀀㜂㔄㘆㰈㨊", a_), global::CommonResources.AcgResources.ID_REVERTTALKGROUPREVERTTGSYSTEMID, null, null);
					this.cnvPerSignalingRevertTGSYSID_A40151.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvPerSignalingRevertTGSYSID_A40151.DataTransferOrder = -1;
					this.cnvPerSignalingRevertTGSYSID_A40151.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
					this.cnvPerSignalingRevertTGSYSID_A40151.ShowHexValue = true;
					this.cnvPerSignalingRevertTGSYSID_A40151.ShowLeadingZeros = true;
					num = (short)681115686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					goto IL_31D;
				case 46:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢ꃤ諦賨駪諬諮鿰郲賴ꟶ그꿺듼믾帀䈂㈄㸆㴈㼊", a_)))
					{
						num = (short)401997846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FD;
				case 47:
					this.cnvPerSignalingASTROSystem_A7498 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢ꓤ듦뷨맪ꋬ볮裰胲致鋶铸ꓺ볼죾㔀㨂㴄", a_), global::CommonResources.AcgResources.ID_ASTROASTROSYSTEM, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.cnvPerSignalingASTROSystem_A7498.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerSignalingASTROSystem_A7498.DataTransferOrder = 42;
					this.cnvPerSignalingASTROSystem_A7498.EvaluateRecRefs = true;
					num = (short)1390673953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					goto IL_710;
				case 49:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ듲ꋴ뛶뫸뗺듼믾帀䈂㄄㜆㠈㸊㴌", a_)))
					{
						num = (short)1789394949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CE1;
				case 50:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮ꗰ듲뻴鋶胸꣺飼鏾帀䈂㄄㜆㠈㸊㤌", a_)))
					{
						num = (short)1457717267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D2E;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ闒냔뛖귘껚꿜뫞鋠ꋢ雤鏦鯨蓪곬菮铰臲致黶韸鳺ꧼ郾漀昂億昆欈朊栌", a_)))
					{
						num = (short)2051735589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF4;
				case 52:
					goto IL_C45;
				case 53:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊鷌꫎ꏐ胒볔냖럘뫚뇜뛞迠蓢럤苦鿨軪鿬鯮꯰鳲鯴鋶꛸뫺쳼쳾㌀㔂㰄", a_)))
					{
						num = (short)538902559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8CC;
				case 54:
					goto IL_D2E;
				}
				IL_10A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2140143641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1B0:
				num = (short)620101685;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FD:
				num = (short)1882521641;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_31D:
				num = (short)1765146673;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_541:
				num = (short)1471021076;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_66E:
				num = (short)1158676526;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_710:
				num = (short)910162887;
				short num4 = num;
				num = (short)2033056711;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_DEF;
				default:
					num = (short)1032781824;
					if (num != 0)
					{
					}
					num = (short)806092850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_87D:
				num = (short)1760559143;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8CC:
				num = (short)1070858264;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_918:
				num = (short)690225175;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_965:
				num = (short)773718045;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9B1:
				num = (short)515899405;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A69:
				num = (short)1450311723;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C45:
				num = (short)221773831;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C93:
				num = (short)613941282;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CE1:
				num = (short)765526043;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D2E:
				num = (short)978124851;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_53C:
			IL_DF4:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铆ꃈ곊ꏌ껎뷐뫒믔냖", a_);
			base.Id = 10144;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALING;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600CC54 RID: 52308 RVA: 0x00BE77A8 File Offset: 0x00BE59A8
		public override void PopulateReferences()
		{
			short num = (short)42824853;
			short num2 = num;
			num = (short)547189909;
			switch (num2 == num)
			{
			default:
			{
				num = (short)925761536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2074083328;
			if (num != 0)
			{
			}
			num = (short)2087845889;
			if (num != 0)
			{
			}
			this.cnvPerSignalingASTROSystem_A7498.SetRecset(this.a(2053));
			this.cnvPerSignalingSystemNumber_A9243.SetRecset(this.a(2053));
			this.cnvPerSignalingRevertZone_A13269.SetRecset(this.a(2051));
			global::AcpCommonLib.IAcpRecordset recset = this.c();
			this.cnvPerSignalingRevertTGKeySel_A40154.SetRecset(recset);
			this.cnvPerFeaturesAstroAlertingToneTable.SetRecset(this.a(4156));
			this.cnvPerSignalingRevertZone_A13269.AddSlaveField(this.cnvPerSignalingRevertChannel_A13267, 10114);
			this.b();
		}

		// Token: 0x0600CC55 RID: 52309 RVA: 0x00BE78D4 File Offset: 0x00BE5AD4
		private global::AcpCommonLib.IAcpRecordset c()
		{
			short num = (short)875298816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				for (;;)
				{
					IL_28:
					bool? flag;
					bool flag2;
					bool? flag4;
					switch (num2)
					{
					case 0:
						if (base.ParentRecset.ParentSection.Parent != null)
						{
							num = (short)445448196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 1:
						if (base.ParentRecset != null)
						{
							num = (short)1085865993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 2:
						goto IL_2D5;
					case 3:
						return embeddedRecset;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure secure = base.Parent[10142] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure;
						num = (short)1196163082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						embeddedRecset = secureKMFProfile.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
						num = (short)2064908291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)860946440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)536281093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 8:
					{
						num = (short)1752396930;
						short num3 = num;
						num = (short)1957393538;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2D5;
						default:
						{
							num = (short)303300608;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = secureKMFProfile.General;
							if (general == null)
							{
								bool? flag3 = null;
								num = (short)1717829644;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag4 = new bool?(general.SecKmfProfGenIndependentKeyList_43597.Value);
							goto IL_300;
						}
						}
						break;
					}
					case 9:
						num = (short)26804237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure secure;
						if (secure.CnvPerSecureKMFProfileIndex_A8381.Value > 0)
						{
							num = (short)1460404238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					}
					case 11:
					{
						num = (short)390725633;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)1452081158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					}
					case 12:
					{
						bool? flag3;
						flag4 = flag3;
						goto IL_300;
					}
					case 13:
						if (base.ParentRecset.ParentSection != null)
						{
							num = (short)1736507394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure secure;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = secure.CnvPerSecureKMFProfileIndex_A8381.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)1282408459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6B;
					IL_2D5:
					num = (short)596574208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_300:
					flag = flag4;
					flag2 = true;
					num = (short)1817116672;
					short num4 = num;
					num = (short)1242234887;
					num2 = (int)((global::System.IntPtr)num);
				}
				return embeddedRecset;
				IL_6B:
				embeddedRecset = this.a(2021)[0][10040].EmbeddedRecset;
				num = (short)2032992257;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600CC56 RID: 52310 RVA: 0x00BE7C5C File Offset: 0x00BE5E5C
		public override void DropReferences()
		{
			short num = (short)2034003840;
			short num2 = num;
			num = (short)757493632;
			switch (num2 == num)
			{
			default:
			{
				num = (short)493158400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)277544960;
			if (num != 0)
			{
			}
			num = (short)72876033;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x00BE7D08 File Offset: 0x00BE5F08
		public override void SetConstraints()
		{
			short num = (short)807134909;
			short num2 = num;
			num = (short)1843259069;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1759576064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1139146753;
			if (num != 0)
			{
			}
			num = (short)2134245376;
			if (num != 0)
			{
			}
			this.cnvPerSignalingASTROSystem_A7498.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvRxSigIsNotNonAstro);
			this.cnvPerSignalingASTROSystem_A7498.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAstroSystemRecrefIsValid);
			this.cnvPerSignalingASTROSystem_A7498.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.cnvPerSignalingASTROSystem_A7498.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConDirTlkgrdFalseOnRSISys);
			this.cnvPerSignalingDigitalModulatorType_A7857.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvRxSigIsNotNonAstro);
			this.cnvPerSignalingDigitalModulatorType_A7857.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvRxSigIsNotNon900Mhz);
			this.cnvPerSignalingEmergencyPTTID_A7944.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerTypeIsMDCAndRxSigTypeIsNotAstroAndCnvRxOnlyDisableAndMdcSysEmerIsAlarmCall);
			this.cnvPerSignalingLateEntryFastUnmute_A8423.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvRxSigIsNotNonAstro);
			this.cnvPerSignalingPTTID_A8770.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSigTypeIsMdcOrDtmfAndCnvPerNotRxOnlyAndCnvSigTypeIsNotAstro);
			this.cnvPerSignalingRevertType_A8953.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConVoiceTxModIsAstroAndRxSigEnableOrSigTypeIsMDCAndRxVoiceSigTypeIsNotAstro);
			this.cnvPerSignalingRevertType_A8953.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRevertTypeNotSelectedChanOrSelectedChanNotRxOnly);
			this.cnvPerSignalingASTRORxUnmuteRule_A9042.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvRxSigIsNotNonAstro);
			this.cnvPerSignalingASTRORxUnmuteRule_A9042.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsAstroRxUnmuteRuleValid);
			this.cnvPerSignalingSignalingType_A9129.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxSignalingTypeIsNotAstro);
			this.cnvPerSignalingSignalingType_A9129.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSignalingIsNoneOrAnalogFlatAudioDisabled);
			this.cnvPerSignalingSignalingType_A9129.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.cnvPerSignalingSignalingType_A9129.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conMdcRunMdcDemodulatorIsEnabled);
			this.cnvPerSignalingSystemNumber_A9243.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvSigIsNotNoneAndRxSigTypeIsNotAstro);
			this.cnvPerSignalingSystemNumber_A9243.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSysNumRecrefIsValid);
			this.cnvPerSignalingSystemNumber_A9243.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConUpdateCnvSysSelectCallInCallValue);
			this.cnvPerSignalingRevertZone_A13269.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRevertTypeIsRevertChannel);
			this.cnvPerSignalingRevertZone_A13269.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConZoneReferencedIsNormalOrDynamicOneBased);
			this.cnvPerSignalingRevertZone_A13269.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRevertTypeIsRevertChannelEditabilty);
			this.cnvPerSignalingRevertChannel_A13267.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRevertTypeIsRevertChannelAndNonDynamicZone);
			this.cnvPerSignalingRevertChannel_A13267.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCheckForCorrectPersonalityTypeChanVal);
			this.cnvPerSignalingRevertChannel_A13267.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRevertTypeIsRevertChannelEditabilty);
			this.cnvPerSignalingRevertTGWACNID_A40150.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerSysTypeIsDVRSWithEmerAndProfTalkgrpEn);
			this.cnvPerSignalingRevertTGWACNID_A40150.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsDVRS);
			this.cnvPerSignalingRevertTGSYSID_A40151.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerSysTypeIsDVRSWithEmerAndProfTalkgrpEn);
			this.cnvPerSignalingRevertTGSYSID_A40151.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsDVRS);
			this.cnvPerSignalingRevertTG_A40152.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerSysTypeIsDVRSWithEmerAndProfTalkgrpEn);
			this.cnvPerSignalingRevertTG_A40152.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsDVRS);
			this.cnvPerSignalingRevertTGSecClearStrap_A40153.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerSysTypeIsDVRSWithEmerAndSecOpt);
			this.cnvPerSignalingRevertTGSecClearStrap_A40153.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsDVRS);
			this.cnvPerSignalingRevertTGKeySel_A40154.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerSysTypeIsDVRSWithEmerAndSecStrap);
			this.cnvPerSignalingRevertTGKeySel_A40154.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRevertTgKeySelValid);
			this.cnvPerSignalingRevertTGKeySel_A40154.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsDVRS);
			this.cnvPerFeaturesAstroAlertingToneTable.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConToneSignalingApp);
			this.cnvPerFeaturesAstroAlertingToneTable.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConToneSignalingValid);
		}

		// Token: 0x0600CC58 RID: 52312 RVA: 0x00BE8130 File Offset: 0x00BE6330
		public override void SetupDependencies()
		{
			short num = (short)2076690820;
			short num2 = num;
			num = (short)2119354756;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1565917184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1900740608;
			if (num != 0)
			{
			}
			num = (short)1926889473;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingASTROSystem_A7498);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSignalingASTROSystem_A7498);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvPerSignalingASTROSystem_A7498);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvPerSignalingASTROSystem_A7498);
			conventionalPersonality.Secure.CnvPerSecureASTROOTAR_A7493.AddDependentObject(this.cnvPerSignalingASTROSystem_A7498);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.cnvPerSignalingASTROSystem_A7498);
			conventionalPersonality.General.CnvPerFeaturesDVRSProf_A41794.AddDependentObject(this.cnvPerSignalingASTROSystem_A7498);
			this.RefRadioWide.Labtool.RadioWideDVRSTrunkingStatusCapability_A42772.AddDependentObject(this.cnvPerSignalingASTROSystem_A7498);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerSignalingASTROSystem_A7498);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvPerSignalingASTROSystem_A7498);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingDigitalModulatorType_A7857);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548.AddDependentObject(this.cnvPerSignalingDigitalModulatorType_A7857);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingEmergencyPTTID_A7944);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerSignalingEmergencyPTTID_A7944);
			this.cnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerSignalingEmergencyPTTID_A7944);
			this.cnvPerSignalingSystemNumber_A9243.AddDependentObject(this.cnvPerSignalingEmergencyPTTID_A7944);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingLateEntryFastUnmute_A8423);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingPTTID_A8770);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerSignalingPTTID_A8770);
			this.cnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerSignalingPTTID_A8770);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerSignalingRevertType_A8953);
			this.cnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSignalingRevertType_A8953);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSignalingRevertType_A8953);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingRevertType_A8953);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerSignalingRevertType_A8953);
			this.cnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerSignalingRevertType_A8953);
			this.cnvPerSignalingSystemNumber_A9243.AddDependentObject(this.cnvPerSignalingRevertType_A8953);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingASTRORxUnmuteRule_A9042);
			conventionalPersonality.ASTROCall.CnvPerASTROCallSelectiveCallRxTx_A9114.AddDependentObject(this.cnvPerSignalingASTRORxUnmuteRule_A9042);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSignalingASTRORxUnmuteRule_A9042);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingSignalingType_A9129);
			conventionalPersonality.Labtool.ConPerMDCRunMDCDemodulator_A8494.AddDependentObject(this.cnvPerSignalingSignalingType_A9129);
			conventionalPersonality.Advanced.CnvPerAdvancedAnalogFlatAudio_A7443.AddDependentObject(this.cnvPerSignalingSignalingType_A9129);
			this.cnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerSignalingSystemNumber_A9243);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingSystemNumber_A9243);
			conventionalPersonality.General.CnvPerFeaturesDVRSProf_A41794.AddDependentObject(this.cnvPerSignalingSystemNumber_A9243);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.cnvPerSignalingSystemNumber_A9243);
			this.RefRadioWide.Labtool.RadioWideDVRSTrunkingStatusCapability_A42772.AddDependentObject(this.cnvPerSignalingSystemNumber_A9243);
			this.cnvPerSignalingRevertType_A8953.AddDependentObject(this.cnvPerSignalingRevertZone_A13269);
			this.cnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerSignalingRevertZone_A13269);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerSignalingRevertZone_A13269);
			this.cnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSignalingRevertZone_A13269);
			this.cnvPerSignalingSystemNumber_A9243.AddDependentObject(this.cnvPerSignalingRevertZone_A13269);
			this.cnvPerSignalingRevertChannel_A13267.AddDependentObject(this.cnvPerSignalingRevertZone_A13269);
			this.cnvPerSignalingRevertType_A8953.AddDependentObject(this.cnvPerSignalingRevertChannel_A13267);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerSignalingRevertChannel_A13267);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerSignalingRevertChannel_A13267);
			this.cnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerSignalingRevertChannel_A13267);
			this.cnvPerSignalingSystemNumber_A9243.AddDependentObject(this.cnvPerSignalingRevertChannel_A13267);
			this.cnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSignalingRevertChannel_A13267);
			this.RefRadioWide.Labtool.RadWideLabtoolEmergencyRevertCapable_A41918.AddDependentObject(this.cnvPerSignalingRevertChannel_A13267);
			this.cnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSignalingRevertTGWACNID_A40150);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSignalingRevertTGWACNID_A40150);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingRevertTGWACNID_A40150);
			this.cnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSignalingRevertTGSYSID_A40151);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSignalingRevertTGSYSID_A40151);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingRevertTGSYSID_A40151);
			this.cnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSignalingRevertTG_A40152);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSignalingRevertTG_A40152);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingRevertTG_A40152);
			this.cnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSignalingRevertTGSecClearStrap_A40153);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingRevertTGSecClearStrap_A40153);
			this.cnvPerSignalingRevertType_A8953.AddDependentObject(this.cnvPerSignalingRevertTGSecClearStrap_A40153);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSignalingRevertTGSecClearStrap_A40153);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSignalingRevertTGSecClearStrap_A40153);
			this.cnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			conventionalPersonality.Secure.CnvPerSecureASTROOTAR_A7493.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			conventionalPersonality.Features.CnvPerFeaturesTacticalRekeyEnable_A19309.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			conventionalPersonality.Secure.CnvPerSecureKMFProfileIndex_A8381.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			this.cnvPerSignalingRevertTGSecClearStrap_A40153.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			this.cnvPerSignalingRevertType_A8953.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSignalingRevertTGKeySel_A40154);
			conventionalPersonality.RAC.CnvPerRACSingletone_A43073.AddDependentObject(this.cnvPerFeaturesAstroAlertingToneTable);
			this.RefCnvSys.QuikCallII.CnvSysQCIIDecode.AddDependentObject(this.cnvPerFeaturesAstroAlertingToneTable);
		}

		// Token: 0x170066B3 RID: 26291
		// (get) Token: 0x0600CC59 RID: 52313 RVA: 0x00BE88F4 File Offset: 0x00BE6AF4
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem ConventionalSystemForCnvPerSignalingASTROSystem_A7498
		{
			get
			{
				short num = (short)1656722187;
				short num2 = num;
				num = (short)1141543691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1053097984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1415839745;
				if (num != 0)
				{
				}
				num = (short)1350696960;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			}
		}

		// Token: 0x170066B4 RID: 26292
		// (get) Token: 0x0600CC5A RID: 52314 RVA: 0x00BE89AC File Offset: 0x00BE6BAC
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem ConventionalSystemForCnvPerSignalingSystemNumber_A9243
		{
			get
			{
				short num = (short)365428737;
				if (num != 0)
				{
				}
				num = (short)1256194048;
				short num2 = num;
				num = (short)13985879;
				short num3 = num;
				num = (short)815294551;
				switch (num3 == num)
				{
				}
				num = (short)606928896;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			}
		}

		// Token: 0x170066B5 RID: 26293
		// (get) Token: 0x0600CC5B RID: 52315 RVA: 0x00BE8A64 File Offset: 0x00BE6C64
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForCnvPerSignalingRevertZone_A13269
		{
			get
			{
				short num = (short)703800942;
				short num2 = num;
				num = (short)1048651374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1161363456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1122828289;
				if (num != 0)
				{
				}
				num = (short)565313536;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x170066B6 RID: 26294
		// (get) Token: 0x0600CC5C RID: 52316 RVA: 0x00BE8B1C File Offset: 0x00BE6D1C
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForCnvPerSignalingRevertChannel_A13267
		{
			get
			{
				short num = (short)1059599949;
				short num2 = num;
				num = (short)1438004813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)978911232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)562233345;
				if (num != 0)
				{
				}
				num = (short)1753874432;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x170066B7 RID: 26295
		// (get) Token: 0x0600CC5D RID: 52317 RVA: 0x00BE8BD4 File Offset: 0x00BE6DD4
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForCnvPerSignalingRevertTGKeySel_A40154
		{
			get
			{
				short num = (short)1415051305;
				short num2 = num;
				num = (short)190969897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1768488960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)414711809;
				if (num != 0)
				{
				}
				num = (short)1088487424;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x170066B8 RID: 26296
		// (get) Token: 0x0600CC5E RID: 52318 RVA: 0x00BE8C8C File Offset: 0x00BE6E8C
		public global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList ToneSignalingListForCnvPerFeaturesAstroAlertingToneTable
		{
			get
			{
				short num = (short)2066403556;
				short num2 = num;
				num = (short)1799213284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1617690624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)708182016;
				if (num != 0)
				{
				}
				num = (short)1703936001;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList;
			}
		}

		// Token: 0x170066B9 RID: 26297
		// (get) Token: 0x0600CC5F RID: 52319 RVA: 0x00BE8D44 File Offset: 0x00BE6F44
		public bool HasDiffs
		{
			get
			{
				short num = (short)612594611;
				short num2 = num;
				num = (short)1475703731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1338376192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1008009217;
				if (num != 0)
				{
				}
				num = (short)1617887232;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170066BA RID: 26298
		// (get) Token: 0x0600CC60 RID: 52320 RVA: 0x00BE8DF0 File Offset: 0x00BE6FF0
		// (set) Token: 0x0600CC61 RID: 52321 RVA: 0x00BE8EA4 File Offset: 0x00BE70A4
		public int CnvPerSignalingASTROSystem_A7498Value
		{
			get
			{
				short num = (short)1653563850;
				short num2 = num;
				num = (short)392389066;
				switch (num2 == num)
				{
				default:
				{
					num = (short)37879808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)146472960;
				if (num != 0)
				{
				}
				num = (short)846987265;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498.Value;
			}
			set
			{
				short num = (short)1044638520;
				short num2 = num;
				num = (short)1568271160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)606273536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)484376576;
				if (num != 0)
				{
				}
				num = (short)592904193;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTROSystem_A7498.Value = value;
			}
		}

		// Token: 0x170066BB RID: 26299
		// (get) Token: 0x0600CC62 RID: 52322 RVA: 0x00BE8F5C File Offset: 0x00BE715C
		// (set) Token: 0x0600CC63 RID: 52323 RVA: 0x00BE9010 File Offset: 0x00BE7210
		public string CnvPerSignalingASTROSystem_A7498_UIValue
		{
			get
			{
				short num = (short)1346917788;
				short num2 = num;
				num = (short)1262704028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881655808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1530658817;
				if (num != 0)
				{
				}
				num = (short)1863385088;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498.UIValue;
			}
			set
			{
				short num = (short)643740140;
				short num2 = num;
				num = (short)1176744428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2097545216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)620167169;
				if (num != 0)
				{
				}
				num = (short)887422976;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTROSystem_A7498.UIValue = value;
			}
		}

		// Token: 0x170066BC RID: 26300
		// (get) Token: 0x0600CC64 RID: 52324 RVA: 0x00BE90C8 File Offset: 0x00BE72C8
		public global::AcpBusinessLayer.AcpRecRefField CnvPerSignalingASTROSystem_A7498
		{
			get
			{
				short num = (short)1170079745;
				if (num != 0)
				{
				}
				num = (short)898301952;
				short num2 = num;
				num = (short)410097499;
				short num3 = num;
				num = (short)2002032475;
				switch (num3 == num)
				{
				}
				num = (short)1306198016;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498;
			}
		}

		// Token: 0x170066BD RID: 26301
		// (get) Token: 0x0600CC65 RID: 52325 RVA: 0x00BE9178 File Offset: 0x00BE7378
		// (set) Token: 0x0600CC66 RID: 52326 RVA: 0x00BE9230 File Offset: 0x00BE7430
		public bool CnvPerSignalingASTROSystem_A7498_Applicable
		{
			get
			{
				short num = (short)919449610;
				short num2 = num;
				num = (short)1521922058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270336000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1418461185;
				if (num != 0)
				{
				}
				num = (short)1909063680;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498.Applicable;
			}
			set
			{
				short num = (short)305522014;
				short num2 = num;
				num = (short)1039263070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562705920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1637875713;
				if (num != 0)
				{
				}
				num = (short)1180368896;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTROSystem_A7498.Applicable = value;
			}
		}

		// Token: 0x170066BE RID: 26302
		// (get) Token: 0x0600CC67 RID: 52327 RVA: 0x00BE92E8 File Offset: 0x00BE74E8
		// (set) Token: 0x0600CC68 RID: 52328 RVA: 0x00BE93A0 File Offset: 0x00BE75A0
		public bool CnvPerSignalingASTROSystem_A7498_Valid
		{
			get
			{
				short num = (short)258265787;
				short num2 = num;
				num = (short)1874580155;
				switch (num2 == num)
				{
				}
				num = (short)195428352;
				short num3 = num;
				num = (short)983367681;
				if (num != 0)
				{
				}
				num = (short)518062080;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498.Valid;
			}
			set
			{
				short num = (short)1182531585;
				if (num != 0)
				{
				}
				num = (short)938218700;
				short num2 = num;
				num = (short)2031949004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)364183552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)355139584;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTROSystem_A7498.Valid = value;
			}
		}

		// Token: 0x170066BF RID: 26303
		// (get) Token: 0x0600CC69 RID: 52329 RVA: 0x00BE9454 File Offset: 0x00BE7654
		// (set) Token: 0x0600CC6A RID: 52330 RVA: 0x00BE9504 File Offset: 0x00BE7704
		public bool CnvPerSignalingASTROSystem_A7498_Visible
		{
			get
			{
				short num = (short)629001185;
				short num2 = num;
				num = (short)731368417;
				switch (num2 == num)
				{
				}
				num = (short)263061504;
				short num3 = num;
				num = (short)982122496;
				if (num != 0)
				{
				}
				num = (short)1810563073;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498.Visible;
			}
			set
			{
				short num = (short)936769631;
				short num2 = num;
				num = (short)401995871;
				switch (num2 == num)
				{
				}
				num = (short)596836352;
				short num3 = num;
				num = (short)1294794753;
				if (num != 0)
				{
				}
				num = (short)857538560;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTROSystem_A7498.Visible = value;
			}
		}

		// Token: 0x170066C0 RID: 26304
		// (get) Token: 0x0600CC6B RID: 52331 RVA: 0x00BE95BC File Offset: 0x00BE77BC
		// (set) Token: 0x0600CC6C RID: 52332 RVA: 0x00BE9670 File Offset: 0x00BE7870
		public bool CnvPerSignalingASTROSystem_A7498_Editable
		{
			get
			{
				short num = (short)695394213;
				short num2 = num;
				num = (short)329441189;
				switch (num2 == num)
				{
				}
				num = (short)1680015360;
				short num3 = num;
				num = (short)1586364417;
				if (num != 0)
				{
				}
				num = (short)1995898880;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498.Editable;
			}
			set
			{
				short num = (short)1707187199;
				short num2 = num;
				num = (short)2098109439;
				switch (num2 == num)
				{
				}
				num = (short)761462784;
				short num3 = num;
				num = (short)1862795265;
				if (num != 0)
				{
				}
				num = (short)1804009472;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTROSystem_A7498.Editable = value;
			}
		}

		// Token: 0x170066C1 RID: 26305
		// (get) Token: 0x0600CC6D RID: 52333 RVA: 0x00BE9724 File Offset: 0x00BE7924
		internal string CnvPerSignalingASTROSystem_A7498_UILabel
		{
			get
			{
				short num = (short)1629157886;
				short num2 = num;
				num = (short)920451582;
				switch (num2 == num)
				{
				}
				num = (short)1307246592;
				short num3 = num;
				num = (short)701366273;
				if (num != 0)
				{
				}
				num = (short)1891368960;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498.UIName;
			}
		}

		// Token: 0x170066C2 RID: 26306
		// (get) Token: 0x0600CC6E RID: 52334 RVA: 0x00BE97D8 File Offset: 0x00BE79D8
		// (set) Token: 0x0600CC6F RID: 52335 RVA: 0x00BE9890 File Offset: 0x00BE7A90
		internal bool CnvPerSignalingASTROSystem_A7498_HiddenStatic
		{
			get
			{
				short num = (short)1210951266;
				short num2 = num;
				num = (short)1373087330;
				switch (num2 == num)
				{
				}
				num = (short)508166144;
				short num3 = num;
				num = (short)297205761;
				if (num != 0)
				{
				}
				num = (short)261685248;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498.HiddenStatic;
			}
			set
			{
				short num = (short)1838016137;
				short num2 = num;
				num = (short)918218377;
				switch (num2 == num)
				{
				}
				num = (short)1848836096;
				short num3 = num;
				num = (short)1836056577;
				if (num != 0)
				{
				}
				num = (short)1750925312;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTROSystem_A7498.HiddenStatic = value;
			}
		}

		// Token: 0x170066C3 RID: 26307
		// (get) Token: 0x0600CC70 RID: 52336 RVA: 0x00BE9948 File Offset: 0x00BE7B48
		// (set) Token: 0x0600CC71 RID: 52337 RVA: 0x00BE99FC File Offset: 0x00BE7BFC
		internal bool CnvPerSignalingASTROSystem_A7498_HiddenDynamic
		{
			get
			{
				short num = (short)1118052436;
				short num2 = num;
				num = (short)1110712404;
				switch (num2 == num)
				{
				}
				num = (short)723714048;
				short num3 = num;
				num = (short)520224769;
				if (num != 0)
				{
				}
				num = (short)892928000;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498.HiddenDynamic;
			}
			set
			{
				short num = (short)1703770124;
				short num2 = num;
				num = (short)905279500;
				switch (num2 == num)
				{
				}
				num = (short)1559560192;
				short num3 = num;
				num = (short)1813774337;
				if (num != 0)
				{
				}
				num = (short)1161232384;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTROSystem_A7498.HiddenDynamic = value;
			}
		}

		// Token: 0x170066C4 RID: 26308
		// (get) Token: 0x0600CC72 RID: 52338 RVA: 0x00BE9AB0 File Offset: 0x00BE7CB0
		public bool CnvPerSignalingASTROSystem_A7498_HasDiffs
		{
			get
			{
				short num = (short)1502410118;
				short num2 = num;
				num = (short)413201798;
				switch (num2 == num)
				{
				}
				num = (short)195756032;
				short num3 = num;
				num = (short)609091584;
				if (num != 0)
				{
				}
				num = (short)1671626753;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTROSystem_A7498._HasDiffs;
			}
		}

		// Token: 0x170066C5 RID: 26309
		// (get) Token: 0x0600CC73 RID: 52339 RVA: 0x00BE9B68 File Offset: 0x00BE7D68
		// (set) Token: 0x0600CC74 RID: 52340 RVA: 0x00BE9C1C File Offset: 0x00BE7E1C
		public int CnvPerSignalingDigitalModulatorType_A7857Value
		{
			get
			{
				short num = (short)792723457;
				if (num != 0)
				{
				}
				num = (short)1861466001;
				short num2 = num;
				num = (short)897431441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1416298496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1538719744;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857.Value;
			}
			set
			{
				short num = (short)287340896;
				short num2 = num;
				num = (short)1626569056;
				switch (num2 == num)
				{
				}
				num = (short)811335680;
				short num3 = num;
				num = (short)618594305;
				if (num != 0)
				{
				}
				num = (short)1620377600;
				if (num != 0)
				{
				}
				this.cnvPerSignalingDigitalModulatorType_A7857.Value = value;
			}
		}

		// Token: 0x170066C6 RID: 26310
		// (get) Token: 0x0600CC75 RID: 52341 RVA: 0x00BE9CD0 File Offset: 0x00BE7ED0
		// (set) Token: 0x0600CC76 RID: 52342 RVA: 0x00BE9D88 File Offset: 0x00BE7F88
		public string CnvPerSignalingDigitalModulatorType_A7857_UIValue
		{
			get
			{
				short num = (short)1716786896;
				short num2 = num;
				num = (short)54531792;
				switch (num2 == num)
				{
				}
				num = (short)1668022272;
				short num3 = num;
				num = (short)206635009;
				if (num != 0)
				{
				}
				num = (short)424607744;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857.UIValue;
			}
			set
			{
				short num = (short)393264434;
				short num2 = num;
				num = (short)912440626;
				switch (num2 == num)
				{
				}
				num = (short)900857856;
				short num3 = num;
				num = (short)1989738496;
				if (num != 0)
				{
				}
				num = (short)254738433;
				if (num != 0)
				{
				}
				this.cnvPerSignalingDigitalModulatorType_A7857.UIValue = value;
			}
		}

		// Token: 0x170066C7 RID: 26311
		// (get) Token: 0x0600CC77 RID: 52343 RVA: 0x00BE9E3C File Offset: 0x00BE803C
		public global::AcpBusinessLayer.AcpListField CnvPerSignalingDigitalModulatorType_A7857
		{
			get
			{
				short num = (short)2100559873;
				if (num != 0)
				{
				}
				num = (short)1893868908;
				short num2 = num;
				num = (short)894707052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1202585600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)134283264;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857;
			}
		}

		// Token: 0x170066C8 RID: 26312
		// (get) Token: 0x0600CC78 RID: 52344 RVA: 0x00BE9EEC File Offset: 0x00BE80EC
		// (set) Token: 0x0600CC79 RID: 52345 RVA: 0x00BE9FA0 File Offset: 0x00BE81A0
		public bool CnvPerSignalingDigitalModulatorType_A7857_Applicable
		{
			get
			{
				short num = (short)1583546369;
				if (num != 0)
				{
				}
				num = (short)383850762;
				short num2 = num;
				num = (short)1051072778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1851195392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1621164032;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857.Applicable;
			}
			set
			{
				short num = (short)271525763;
				short num2 = num;
				num = (short)356263811;
				switch (num2 == num)
				{
				}
				num = (short)1051262976;
				short num3 = num;
				num = (short)785514496;
				if (num != 0)
				{
				}
				num = (short)1578762241;
				if (num != 0)
				{
				}
				this.cnvPerSignalingDigitalModulatorType_A7857.Applicable = value;
			}
		}

		// Token: 0x170066C9 RID: 26313
		// (get) Token: 0x0600CC7A RID: 52346 RVA: 0x00BEA054 File Offset: 0x00BE8254
		// (set) Token: 0x0600CC7B RID: 52347 RVA: 0x00BEA108 File Offset: 0x00BE8308
		public bool CnvPerSignalingDigitalModulatorType_A7857_Valid
		{
			get
			{
				short num = (short)1277910468;
				short num2 = num;
				num = (short)1912626628;
				switch (num2 == num)
				{
				}
				num = (short)1381236736;
				short num3 = num;
				num = (short)22413313;
				if (num != 0)
				{
				}
				num = (short)1504575488;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857.Valid;
			}
			set
			{
				short num = (short)1032691121;
				short num2 = num;
				num = (short)1857658289;
				switch (num2 == num)
				{
				}
				num = (short)1916207104;
				short num3 = num;
				num = (short)590348288;
				if (num != 0)
				{
				}
				num = (short)328466433;
				if (num != 0)
				{
				}
				this.cnvPerSignalingDigitalModulatorType_A7857.Valid = value;
			}
		}

		// Token: 0x170066CA RID: 26314
		// (get) Token: 0x0600CC7C RID: 52348 RVA: 0x00BEA1BC File Offset: 0x00BE83BC
		// (set) Token: 0x0600CC7D RID: 52349 RVA: 0x00BEA274 File Offset: 0x00BE8474
		public bool CnvPerSignalingDigitalModulatorType_A7857_Visible
		{
			get
			{
				short num = (short)1068734147;
				short num2 = num;
				num = (short)1941804739;
				switch (num2 == num)
				{
				}
				num = (short)1366228992;
				short num3 = num;
				num = (short)1336410112;
				if (num != 0)
				{
				}
				num = (short)1602158593;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857.Visible;
			}
			set
			{
				short num = (short)787087361;
				if (num != 0)
				{
				}
				num = (short)1866600320;
				short num2 = num;
				num = (short)1288114048;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1604386816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1475936256;
				if (num != 0)
				{
				}
				this.cnvPerSignalingDigitalModulatorType_A7857.Visible = value;
			}
		}

		// Token: 0x170066CB RID: 26315
		// (get) Token: 0x0600CC7E RID: 52350 RVA: 0x00BEA328 File Offset: 0x00BE8528
		// (set) Token: 0x0600CC7F RID: 52351 RVA: 0x00BEA3DC File Offset: 0x00BE85DC
		public bool CnvPerSignalingDigitalModulatorType_A7857_Editable
		{
			get
			{
				short num = (short)1347795096;
				short num2 = num;
				num = (short)1279637656;
				switch (num2 == num)
				{
				}
				num = (short)642252800;
				short num3 = num;
				num = (short)1083310080;
				if (num != 0)
				{
				}
				num = (short)354287617;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857.Editable;
			}
			set
			{
				short num = (short)2116402863;
				short num2 = num;
				num = (short)1421524655;
				switch (num2 == num)
				{
				}
				num = (short)1474625536;
				short num3 = num;
				num = (short)1454833664;
				if (num != 0)
				{
				}
				num = (short)1328873473;
				if (num != 0)
				{
				}
				this.cnvPerSignalingDigitalModulatorType_A7857.Editable = value;
			}
		}

		// Token: 0x170066CC RID: 26316
		// (get) Token: 0x0600CC80 RID: 52352 RVA: 0x00BEA490 File Offset: 0x00BE8690
		internal string CnvPerSignalingDigitalModulatorType_A7857_UILabel
		{
			get
			{
				short num = (short)133721695;
				short num2 = num;
				num = (short)226127455;
				switch (num2 == num)
				{
				}
				num = (short)1883045888;
				short num3 = num;
				num = (short)1327759360;
				if (num != 0)
				{
				}
				num = (short)96010241;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857.UIName;
			}
		}

		// Token: 0x170066CD RID: 26317
		// (get) Token: 0x0600CC81 RID: 52353 RVA: 0x00BEA544 File Offset: 0x00BE8744
		// (set) Token: 0x0600CC82 RID: 52354 RVA: 0x00BEA5F8 File Offset: 0x00BE87F8
		internal bool CnvPerSignalingDigitalModulatorType_A7857_HiddenStatic
		{
			get
			{
				short num = (short)1294126414;
				short num2 = num;
				num = (short)1635962190;
				switch (num2 == num)
				{
				}
				num = (short)1294008320;
				short num3 = num;
				num = (short)2083323904;
				if (num != 0)
				{
				}
				num = (short)408748033;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857.HiddenStatic;
			}
			set
			{
				short num = (short)412952417;
				short num2 = num;
				num = (short)1772169057;
				switch (num2 == num)
				{
				}
				num = (short)1814233088;
				short num3 = num;
				num = (short)1327038464;
				if (num != 0)
				{
				}
				num = (short)1409941505;
				if (num != 0)
				{
				}
				this.cnvPerSignalingDigitalModulatorType_A7857.HiddenStatic = value;
			}
		}

		// Token: 0x170066CE RID: 26318
		// (get) Token: 0x0600CC83 RID: 52355 RVA: 0x00BEA6AC File Offset: 0x00BE88AC
		// (set) Token: 0x0600CC84 RID: 52356 RVA: 0x00BEA760 File Offset: 0x00BE8960
		internal bool CnvPerSignalingDigitalModulatorType_A7857_HiddenDynamic
		{
			get
			{
				short num = (short)1518973664;
				short num2 = num;
				num = (short)2039198432;
				switch (num2 == num)
				{
				}
				num = (short)1877671936;
				short num3 = num;
				num = (short)301924353;
				if (num != 0)
				{
				}
				num = (short)768999424;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857.HiddenDynamic;
			}
			set
			{
				short num = (short)1684775726;
				short num2 = num;
				num = (short)1605542702;
				switch (num2 == num)
				{
				}
				num = (short)1164378112;
				short num3 = num;
				num = (short)1418002433;
				if (num != 0)
				{
				}
				num = (short)1469775872;
				if (num != 0)
				{
				}
				this.cnvPerSignalingDigitalModulatorType_A7857.HiddenDynamic = value;
			}
		}

		// Token: 0x170066CF RID: 26319
		// (get) Token: 0x0600CC85 RID: 52357 RVA: 0x00BEA814 File Offset: 0x00BE8A14
		public bool CnvPerSignalingDigitalModulatorType_A7857_HasDiffs
		{
			get
			{
				short num = (short)1202060458;
				short num2 = num;
				num = (short)90373290;
				switch (num2 == num)
				{
				}
				num = (short)1989804032;
				short num3 = num;
				num = (short)1267728384;
				if (num != 0)
				{
				}
				num = (short)501481473;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingDigitalModulatorType_A7857._HasDiffs;
			}
		}

		// Token: 0x170066D0 RID: 26320
		// (get) Token: 0x0600CC86 RID: 52358 RVA: 0x00BEA8C8 File Offset: 0x00BE8AC8
		// (set) Token: 0x0600CC87 RID: 52359 RVA: 0x00BEA97C File Offset: 0x00BE8B7C
		public bool CnvPerSignalingEmergencyPTTID_A7944Value
		{
			get
			{
				short num = (short)1257197749;
				short num2 = num;
				num = (short)1179537589;
				switch (num2 == num)
				{
				}
				num = (short)1338966016;
				short num3 = num;
				num = (short)1662713857;
				if (num != 0)
				{
				}
				num = (short)1451884544;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944.Value;
			}
			set
			{
				short num = (short)361324443;
				short num2 = num;
				num = (short)1880514459;
				switch (num2 == num)
				{
				}
				num = (short)810745856;
				short num3 = num;
				num = (short)2071724033;
				if (num != 0)
				{
				}
				num = (short)1601175552;
				if (num != 0)
				{
				}
				this.cnvPerSignalingEmergencyPTTID_A7944.Value = value;
			}
		}

		// Token: 0x170066D1 RID: 26321
		// (get) Token: 0x0600CC88 RID: 52360 RVA: 0x00BEAA30 File Offset: 0x00BE8C30
		public global::AcpBusinessLayer.AcpField<bool> CnvPerSignalingEmergencyPTTID_A7944
		{
			get
			{
				short num = (short)163525552;
				short num2 = num;
				num = (short)1925395376;
				switch (num2 == num)
				{
				}
				num = (short)1106837504;
				short num3 = num;
				num = (short)692125697;
				if (num != 0)
				{
				}
				num = (short)2058813440;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944;
			}
		}

		// Token: 0x170066D2 RID: 26322
		// (get) Token: 0x0600CC89 RID: 52361 RVA: 0x00BEAAE0 File Offset: 0x00BE8CE0
		// (set) Token: 0x0600CC8A RID: 52362 RVA: 0x00BEAB94 File Offset: 0x00BE8D94
		public bool CnvPerSignalingEmergencyPTTID_A7944_UIValue
		{
			get
			{
				short num = (short)1282277377;
				if (num != 0)
				{
				}
				num = (short)533459113;
				short num2 = num;
				num = (short)694481065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)840171520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1688535040;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944.Value;
			}
			set
			{
				short num = (short)1281419003;
				short num2 = num;
				num = (short)1256580859;
				switch (num2 == num)
				{
				}
				num = (short)1792278528;
				short num3 = num;
				num = (short)1174470657;
				if (num != 0)
				{
				}
				num = (short)20905984;
				if (num != 0)
				{
				}
				this.cnvPerSignalingEmergencyPTTID_A7944.Value = value;
			}
		}

		// Token: 0x170066D3 RID: 26323
		// (get) Token: 0x0600CC8B RID: 52363 RVA: 0x00BEAC48 File Offset: 0x00BE8E48
		// (set) Token: 0x0600CC8C RID: 52364 RVA: 0x00BEACF8 File Offset: 0x00BE8EF8
		public bool CnvPerSignalingEmergencyPTTID_A7944_Applicable
		{
			get
			{
				short num = (short)120193025;
				if (num != 0)
				{
				}
				num = (short)65054900;
				short num2 = num;
				num = (short)28944564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)984547328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)429522944;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944.Applicable;
			}
			set
			{
				short num = (short)1627356194;
				short num2 = num;
				num = (short)861961250;
				switch (num2 == num)
				{
				}
				num = (short)2113404928;
				short num3 = num;
				num = (short)2094268416;
				if (num != 0)
				{
				}
				num = (short)194576385;
				if (num != 0)
				{
				}
				this.cnvPerSignalingEmergencyPTTID_A7944.Applicable = value;
			}
		}

		// Token: 0x170066D4 RID: 26324
		// (get) Token: 0x0600CC8D RID: 52365 RVA: 0x00BEADAC File Offset: 0x00BE8FAC
		// (set) Token: 0x0600CC8E RID: 52366 RVA: 0x00BEAE64 File Offset: 0x00BE9064
		public bool CnvPerSignalingEmergencyPTTID_A7944_Valid
		{
			get
			{
				short num = (short)235638747;
				short num2 = num;
				num = (short)1715113947;
				switch (num2 == num)
				{
				}
				num = (short)219611136;
				short num3 = num;
				num = (short)1518993409;
				if (num != 0)
				{
				}
				num = (short)2134441984;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944.Valid;
			}
			set
			{
				short num = (short)1101351614;
				short num2 = num;
				num = (short)1321487038;
				switch (num2 == num)
				{
				}
				num = (short)1033895936;
				short num3 = num;
				num = (short)1719009280;
				if (num != 0)
				{
				}
				num = (short)99287041;
				if (num != 0)
				{
				}
				this.cnvPerSignalingEmergencyPTTID_A7944.Valid = value;
			}
		}

		// Token: 0x170066D5 RID: 26325
		// (get) Token: 0x0600CC8F RID: 52367 RVA: 0x00BEAF18 File Offset: 0x00BE9118
		// (set) Token: 0x0600CC90 RID: 52368 RVA: 0x00BEAFC8 File Offset: 0x00BE91C8
		public bool CnvPerSignalingEmergencyPTTID_A7944_Visible
		{
			get
			{
				short num = (short)293588870;
				short num2 = num;
				num = (short)1690095494;
				switch (num2 == num)
				{
				}
				num = (short)1110441984;
				short num3 = num;
				num = (short)933167105;
				if (num != 0)
				{
				}
				num = (short)97517568;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944.Visible;
			}
			set
			{
				short num = (short)1745022121;
				short num2 = num;
				num = (short)1963257001;
				switch (num2 == num)
				{
				}
				num = (short)310050816;
				short num3 = num;
				num = (short)1544880129;
				if (num != 0)
				{
				}
				num = (short)895090688;
				if (num != 0)
				{
				}
				this.cnvPerSignalingEmergencyPTTID_A7944.Visible = value;
			}
		}

		// Token: 0x170066D6 RID: 26326
		// (get) Token: 0x0600CC91 RID: 52369 RVA: 0x00BEB080 File Offset: 0x00BE9280
		// (set) Token: 0x0600CC92 RID: 52370 RVA: 0x00BEB134 File Offset: 0x00BE9334
		public bool CnvPerSignalingEmergencyPTTID_A7944_Editable
		{
			get
			{
				short num = (short)2054980045;
				short num2 = num;
				num = (short)1342734797;
				switch (num2 == num)
				{
				}
				num = (short)1030291456;
				short num3 = num;
				num = (short)1855193088;
				if (num != 0)
				{
				}
				num = (short)766115841;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944.Editable;
			}
			set
			{
				short num = (short)542441473;
				if (num != 0)
				{
				}
				num = (short)2134443545;
				short num2 = num;
				num = (short)1589839385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)864681984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1458044928;
				if (num != 0)
				{
				}
				this.cnvPerSignalingEmergencyPTTID_A7944.Editable = value;
			}
		}

		// Token: 0x170066D7 RID: 26327
		// (get) Token: 0x0600CC93 RID: 52371 RVA: 0x00BEB1EC File Offset: 0x00BE93EC
		internal string CnvPerSignalingEmergencyPTTID_A7944_UILabel
		{
			get
			{
				short num = (short)2054143552;
				short num2 = num;
				num = (short)577027648;
				switch (num2 == num)
				{
				}
				num = (short)1382023168;
				short num3 = num;
				num = (short)1797324800;
				if (num != 0)
				{
				}
				num = (short)970260481;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944.UIName;
			}
		}

		// Token: 0x170066D8 RID: 26328
		// (get) Token: 0x0600CC94 RID: 52372 RVA: 0x00BEB2A4 File Offset: 0x00BE94A4
		// (set) Token: 0x0600CC95 RID: 52373 RVA: 0x00BEB358 File Offset: 0x00BE9558
		internal bool CnvPerSignalingEmergencyPTTID_A7944_HiddenStatic
		{
			get
			{
				short num = (short)1737556643;
				short num2 = num;
				num = (short)1575289507;
				switch (num2 == num)
				{
				}
				num = (short)1020067840;
				short num3 = num;
				num = (short)944373761;
				if (num != 0)
				{
				}
				num = (short)1003814912;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944.HiddenStatic;
			}
			set
			{
				short num = (short)18815314;
				short num2 = num;
				num = (short)829299026;
				switch (num2 == num)
				{
				}
				num = (short)1327366144;
				short num3 = num;
				num = (short)292683776;
				if (num != 0)
				{
				}
				num = (short)850591745;
				if (num != 0)
				{
				}
				this.cnvPerSignalingEmergencyPTTID_A7944.HiddenStatic = value;
			}
		}

		// Token: 0x170066D9 RID: 26329
		// (get) Token: 0x0600CC96 RID: 52374 RVA: 0x00BEB40C File Offset: 0x00BE960C
		// (set) Token: 0x0600CC97 RID: 52375 RVA: 0x00BEB4C0 File Offset: 0x00BE96C0
		internal bool CnvPerSignalingEmergencyPTTID_A7944_HiddenDynamic
		{
			get
			{
				short num = (short)896662099;
				short num2 = num;
				num = (short)91290195;
				switch (num2 == num)
				{
				}
				num = (short)689176576;
				short num3 = num;
				num = (short)78839809;
				if (num != 0)
				{
				}
				num = (short)1020723200;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944.HiddenDynamic;
			}
			set
			{
				short num = (short)1904757497;
				short num2 = num;
				num = (short)996559609;
				switch (num2 == num)
				{
				}
				num = (short)1136066560;
				short num3 = num;
				num = (short)1669005313;
				if (num != 0)
				{
				}
				num = (short)366149632;
				if (num != 0)
				{
				}
				this.cnvPerSignalingEmergencyPTTID_A7944.HiddenDynamic = value;
			}
		}

		// Token: 0x170066DA RID: 26330
		// (get) Token: 0x0600CC98 RID: 52376 RVA: 0x00BEB574 File Offset: 0x00BE9774
		public bool CnvPerSignalingEmergencyPTTID_A7944_HasDiffs
		{
			get
			{
				short num = (short)1525755398;
				short num2 = num;
				num = (short)315043334;
				switch (num2 == num)
				{
				}
				num = (short)759431168;
				short num3 = num;
				num = (short)2079719425;
				if (num != 0)
				{
				}
				num = (short)920977408;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingEmergencyPTTID_A7944._HasDiffs;
			}
		}

		// Token: 0x170066DB RID: 26331
		// (get) Token: 0x0600CC99 RID: 52377 RVA: 0x00BEB62C File Offset: 0x00BE982C
		// (set) Token: 0x0600CC9A RID: 52378 RVA: 0x00BEB6E0 File Offset: 0x00BE98E0
		public bool CnvPerSignalingLateEntryFastUnmute_A8423Value
		{
			get
			{
				short num = (short)1916284975;
				short num2 = num;
				num = (short)1181298735;
				switch (num2 == num)
				{
				}
				num = (short)843186176;
				short num3 = num;
				num = (short)1255669761;
				if (num != 0)
				{
				}
				num = (short)1340932096;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423.Value;
			}
			set
			{
				short num = (short)175937761;
				short num2 = num;
				num = (short)1096259809;
				switch (num2 == num)
				{
				}
				num = (short)1480523776;
				short num3 = num;
				num = (short)288423937;
				if (num != 0)
				{
				}
				num = (short)794099712;
				if (num != 0)
				{
				}
				this.cnvPerSignalingLateEntryFastUnmute_A8423.Value = value;
			}
		}

		// Token: 0x170066DC RID: 26332
		// (get) Token: 0x0600CC9B RID: 52379 RVA: 0x00BEB794 File Offset: 0x00BE9994
		public global::AcpBusinessLayer.AcpField<bool> CnvPerSignalingLateEntryFastUnmute_A8423
		{
			get
			{
				short num = (short)635662296;
				short num2 = num;
				num = (short)1232629720;
				switch (num2 == num)
				{
				}
				num = (short)668139520;
				short num3 = num;
				num = (short)211222529;
				if (num != 0)
				{
				}
				num = (short)2044985344;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423;
			}
		}

		// Token: 0x170066DD RID: 26333
		// (get) Token: 0x0600CC9C RID: 52380 RVA: 0x00BEB844 File Offset: 0x00BE9A44
		// (set) Token: 0x0600CC9D RID: 52381 RVA: 0x00BEB8F8 File Offset: 0x00BE9AF8
		public bool CnvPerSignalingLateEntryFastUnmute_A8423_UIValue
		{
			get
			{
				short num = (short)1290293829;
				short num2 = num;
				num = (short)864113221;
				switch (num2 == num)
				{
				}
				num = (short)1204879360;
				short num3 = num;
				num = (short)1270546432;
				if (num != 0)
				{
				}
				num = (short)1176043521;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423.Value;
			}
			set
			{
				short num = (short)445663148;
				short num2 = num;
				num = (short)960710572;
				switch (num2 == num)
				{
				}
				num = (short)2054291456;
				short num3 = num;
				num = (short)951451649;
				if (num != 0)
				{
				}
				num = (short)471597056;
				if (num != 0)
				{
				}
				this.cnvPerSignalingLateEntryFastUnmute_A8423.Value = value;
			}
		}

		// Token: 0x170066DE RID: 26334
		// (get) Token: 0x0600CC9E RID: 52382 RVA: 0x00BEB9B0 File Offset: 0x00BE9BB0
		// (set) Token: 0x0600CC9F RID: 52383 RVA: 0x00BEBA64 File Offset: 0x00BE9C64
		public bool CnvPerSignalingLateEntryFastUnmute_A8423_Applicable
		{
			get
			{
				short num = (short)1133788152;
				short num2 = num;
				num = (short)267729912;
				switch (num2 == num)
				{
				}
				num = (short)1274413056;
				short num3 = num;
				num = (short)394657793;
				if (num != 0)
				{
				}
				num = (short)1876623360;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423.Applicable;
			}
			set
			{
				short num = (short)445841409;
				if (num != 0)
				{
				}
				num = (short)596575564;
				short num2 = num;
				num = (short)713885004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)293339136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1552416768;
				if (num != 0)
				{
				}
				this.cnvPerSignalingLateEntryFastUnmute_A8423.Applicable = value;
			}
		}

		// Token: 0x170066DF RID: 26335
		// (get) Token: 0x0600CCA0 RID: 52384 RVA: 0x00BEBB1C File Offset: 0x00BE9D1C
		// (set) Token: 0x0600CCA1 RID: 52385 RVA: 0x00BEBBD0 File Offset: 0x00BE9DD0
		public bool CnvPerSignalingLateEntryFastUnmute_A8423_Valid
		{
			get
			{
				short num = (short)628621313;
				if (num != 0)
				{
				}
				num = (short)1875907400;
				short num2 = num;
				num = (short)990712648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2088501248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1046609920;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423.Valid;
			}
			set
			{
				short num = (short)1227307439;
				short num2 = num;
				num = (short)842021295;
				switch (num2 == num)
				{
				}
				num = (short)1225064448;
				short num3 = num;
				num = (short)105381889;
				if (num != 0)
				{
				}
				num = (short)1319305216;
				if (num != 0)
				{
				}
				this.cnvPerSignalingLateEntryFastUnmute_A8423.Valid = value;
			}
		}

		// Token: 0x170066E0 RID: 26336
		// (get) Token: 0x0600CCA2 RID: 52386 RVA: 0x00BEBC88 File Offset: 0x00BE9E88
		// (set) Token: 0x0600CCA3 RID: 52387 RVA: 0x00BEBD3C File Offset: 0x00BE9F3C
		public bool CnvPerSignalingLateEntryFastUnmute_A8423_Visible
		{
			get
			{
				short num = (short)34013184;
				short num2 = num;
				num = (short)2049732934;
				short num3 = num;
				num = (short)1161130310;
				switch (num3 == num)
				{
				}
				num = (short)819134465;
				if (num != 0)
				{
				}
				num = (short)375455744;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423.Visible;
			}
			set
			{
				short num = (short)1923284992;
				short num2 = num;
				num = (short)802541232;
				short num3 = num;
				num = (short)1602801328;
				switch (num3 == num)
				{
				}
				num = (short)1155923969;
				if (num != 0)
				{
				}
				num = (short)775225344;
				if (num != 0)
				{
				}
				this.cnvPerSignalingLateEntryFastUnmute_A8423.Visible = value;
			}
		}

		// Token: 0x170066E1 RID: 26337
		// (get) Token: 0x0600CCA4 RID: 52388 RVA: 0x00BEBDF0 File Offset: 0x00BE9FF0
		// (set) Token: 0x0600CCA5 RID: 52389 RVA: 0x00BEBEA4 File Offset: 0x00BEA0A4
		public bool CnvPerSignalingLateEntryFastUnmute_A8423_Editable
		{
			get
			{
				short num = (short)1407975424;
				short num2 = num;
				num = (short)941413020;
				short num3 = num;
				num = (short)1572393628;
				switch (num3 == num)
				{
				}
				num = (short)852230145;
				if (num != 0)
				{
				}
				num = (short)324730880;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423.Editable;
			}
			set
			{
				short num = (short)1016266752;
				short num2 = num;
				num = (short)329970562;
				short num3 = num;
				num = (short)898823042;
				switch (num3 == num)
				{
				}
				num = (short)969932801;
				if (num != 0)
				{
				}
				num = (short)722665472;
				if (num != 0)
				{
				}
				this.cnvPerSignalingLateEntryFastUnmute_A8423.Editable = value;
			}
		}

		// Token: 0x170066E2 RID: 26338
		// (get) Token: 0x0600CCA6 RID: 52390 RVA: 0x00BEBF5C File Offset: 0x00BEA15C
		internal string CnvPerSignalingLateEntryFastUnmute_A8423_UILabel
		{
			get
			{
				short num = (short)359333888;
				short num2 = num;
				num = (short)44581723;
				short num3 = num;
				num = (short)412959579;
				switch (num3 == num)
				{
				}
				num = (short)767754240;
				if (num != 0)
				{
				}
				num = (short)1894580225;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423.UIName;
			}
		}

		// Token: 0x170066E3 RID: 26339
		// (get) Token: 0x0600CCA7 RID: 52391 RVA: 0x00BEC014 File Offset: 0x00BEA214
		// (set) Token: 0x0600CCA8 RID: 52392 RVA: 0x00BEC0CC File Offset: 0x00BEA2CC
		internal bool CnvPerSignalingLateEntryFastUnmute_A8423_HiddenStatic
		{
			get
			{
				short num = (short)89980928;
				short num2 = num;
				num = (short)1396843433;
				short num3 = num;
				num = (short)1579033513;
				switch (num3 == num)
				{
				}
				num = (short)684457985;
				if (num != 0)
				{
				}
				num = (short)2093088768;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423.HiddenStatic;
			}
			set
			{
				short num = (short)987299840;
				short num2 = num;
				num = (short)1897660417;
				if (num != 0)
				{
				}
				num = (short)1468933974;
				short num3 = num;
				num = (short)84682582;
				switch (num3 == num)
				{
				}
				num = (short)1536163840;
				if (num != 0)
				{
				}
				this.cnvPerSignalingLateEntryFastUnmute_A8423.HiddenStatic = value;
			}
		}

		// Token: 0x170066E4 RID: 26340
		// (get) Token: 0x0600CCA9 RID: 52393 RVA: 0x00BEC180 File Offset: 0x00BEA380
		// (set) Token: 0x0600CCAA RID: 52394 RVA: 0x00BEC238 File Offset: 0x00BEA438
		internal bool CnvPerSignalingLateEntryFastUnmute_A8423_HiddenDynamic
		{
			get
			{
				short num = (short)918618112;
				short num2 = num;
				num = (short)862229994;
				short num3 = num;
				num = (short)839423466;
				switch (num3 == num)
				{
				}
				num = (short)2140602369;
				if (num != 0)
				{
				}
				num = (short)124387328;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423.HiddenDynamic;
			}
			set
			{
				short num = (short)653393920;
				short num2 = num;
				num = (short)347636705;
				short num3 = num;
				num = (short)2051113953;
				switch (num3 == num)
				{
				}
				num = (short)1852506113;
				if (num != 0)
				{
				}
				num = (short)728629248;
				if (num != 0)
				{
				}
				this.cnvPerSignalingLateEntryFastUnmute_A8423.HiddenDynamic = value;
			}
		}

		// Token: 0x170066E5 RID: 26341
		// (get) Token: 0x0600CCAB RID: 52395 RVA: 0x00BEC2EC File Offset: 0x00BEA4EC
		public bool CnvPerSignalingLateEntryFastUnmute_A8423_HasDiffs
		{
			get
			{
				short num = (short)899416064;
				short num2 = num;
				num = (short)1470466230;
				short num3 = num;
				num = (short)1697089718;
				switch (num3 == num)
				{
				}
				num = (short)644481025;
				if (num != 0)
				{
				}
				num = (short)1731395584;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingLateEntryFastUnmute_A8423._HasDiffs;
			}
		}

		// Token: 0x170066E6 RID: 26342
		// (get) Token: 0x0600CCAC RID: 52396 RVA: 0x00BEC3A0 File Offset: 0x00BEA5A0
		// (set) Token: 0x0600CCAD RID: 52397 RVA: 0x00BEC454 File Offset: 0x00BEA654
		public bool CnvPerSignalingPTTID_A8770Value
		{
			get
			{
				short num = (short)1571487744;
				short num2 = num;
				num = (short)136064981;
				short num3 = num;
				num = (short)1589391317;
				switch (num3 == num)
				{
				}
				num = (short)352452609;
				if (num != 0)
				{
				}
				num = (short)2131165184;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770.Value;
			}
			set
			{
				short num = (short)1030094848;
				short num2 = num;
				num = (short)1134761085;
				short num3 = num;
				num = (short)1506677885;
				switch (num3 == num)
				{
				}
				num = (short)1100546049;
				if (num != 0)
				{
				}
				num = (short)40239104;
				if (num != 0)
				{
				}
				this.cnvPerSignalingPTTID_A8770.Value = value;
			}
		}

		// Token: 0x170066E7 RID: 26343
		// (get) Token: 0x0600CCAE RID: 52398 RVA: 0x00BEC50C File Offset: 0x00BEA70C
		public global::AcpBusinessLayer.AcpField<bool> CnvPerSignalingPTTID_A8770
		{
			get
			{
				short num = (short)1043202048;
				short num2 = num;
				num = (short)11512138;
				short num3 = num;
				num = (short)182167882;
				switch (num3 == num)
				{
				}
				num = (short)1479933953;
				if (num != 0)
				{
				}
				num = (short)342294528;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770;
			}
		}

		// Token: 0x170066E8 RID: 26344
		// (get) Token: 0x0600CCAF RID: 52399 RVA: 0x00BEC5B8 File Offset: 0x00BEA7B8
		// (set) Token: 0x0600CCB0 RID: 52400 RVA: 0x00BEC66C File Offset: 0x00BEA86C
		public bool CnvPerSignalingPTTID_A8770_UIValue
		{
			get
			{
				short num = (short)839385088;
				short num2 = num;
				num = (short)1317112111;
				short num3 = num;
				num = (short)1981253935;
				switch (num3 == num)
				{
				}
				num = (short)212467712;
				if (num != 0)
				{
				}
				num = (short)1873346561;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770.Value;
			}
			set
			{
				short num = (short)2004942848;
				short num2 = num;
				num = (short)1421073605;
				short num3 = num;
				num = (short)702405829;
				switch (num3 == num)
				{
				}
				num = (short)819724288;
				if (num != 0)
				{
				}
				num = (short)592445441;
				if (num != 0)
				{
				}
				this.cnvPerSignalingPTTID_A8770.Value = value;
			}
		}

		// Token: 0x170066E9 RID: 26345
		// (get) Token: 0x0600CCB1 RID: 52401 RVA: 0x00BEC724 File Offset: 0x00BEA924
		// (set) Token: 0x0600CCB2 RID: 52402 RVA: 0x00BEC7DC File Offset: 0x00BEA9DC
		public bool CnvPerSignalingPTTID_A8770_Applicable
		{
			get
			{
				short num = (short)1091829760;
				short num2 = num;
				num = (short)1024429630;
				short num3 = num;
				num = (short)681741886;
				switch (num3 == num)
				{
				}
				num = (short)1811939328;
				if (num != 0)
				{
				}
				num = (short)757465089;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770.Applicable;
			}
			set
			{
				short num = (short)1968701440;
				short num2 = num;
				num = (short)313962760;
				short num3 = num;
				num = (short)1050980616;
				switch (num3 == num)
				{
				}
				num = (short)197656577;
				if (num != 0)
				{
				}
				num = (short)698875904;
				if (num != 0)
				{
				}
				this.cnvPerSignalingPTTID_A8770.Applicable = value;
			}
		}

		// Token: 0x170066EA RID: 26346
		// (get) Token: 0x0600CCB3 RID: 52403 RVA: 0x00BEC890 File Offset: 0x00BEAA90
		// (set) Token: 0x0600CCB4 RID: 52404 RVA: 0x00BEC944 File Offset: 0x00BEAB44
		public bool CnvPerSignalingPTTID_A8770_Valid
		{
			get
			{
				short num = (short)310312960;
				short num2 = num;
				num = (short)436933877;
				short num3 = num;
				num = (short)370611445;
				switch (num3 == num)
				{
				}
				num = (short)297992192;
				if (num != 0)
				{
				}
				num = (short)1260978177;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770.Valid;
			}
			set
			{
				short num = (short)1042677760;
				short num2 = num;
				num = (short)1035798887;
				short num3 = num;
				num = (short)107153767;
				switch (num3 == num)
				{
				}
				num = (short)1327235072;
				if (num != 0)
				{
				}
				num = (short)555876353;
				if (num != 0)
				{
				}
				this.cnvPerSignalingPTTID_A8770.Valid = value;
			}
		}

		// Token: 0x170066EB RID: 26347
		// (get) Token: 0x0600CCB5 RID: 52405 RVA: 0x00BEC9FC File Offset: 0x00BEABFC
		// (set) Token: 0x0600CCB6 RID: 52406 RVA: 0x00BECAB0 File Offset: 0x00BEACB0
		public bool CnvPerSignalingPTTID_A8770_Visible
		{
			get
			{
				short num = (short)1306198016;
				short num2 = num;
				num = (short)1457781335;
				short num3 = num;
				num = (short)1388771927;
				switch (num3 == num)
				{
				}
				num = (short)1635713024;
				if (num != 0)
				{
				}
				num = (short)1044578305;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770.Visible;
			}
			set
			{
				short num = (short)1642725376;
				short num2 = num;
				num = (short)1449966604;
				short num3 = num;
				num = (short)1378204684;
				switch (num3 == num)
				{
				}
				num = (short)1151598593;
				if (num != 0)
				{
				}
				num = (short)763428864;
				if (num != 0)
				{
				}
				this.cnvPerSignalingPTTID_A8770.Visible = value;
			}
		}

		// Token: 0x170066EC RID: 26348
		// (get) Token: 0x0600CCB7 RID: 52407 RVA: 0x00BECB68 File Offset: 0x00BEAD68
		// (set) Token: 0x0600CCB8 RID: 52408 RVA: 0x00BECC20 File Offset: 0x00BEAE20
		public bool CnvPerSignalingPTTID_A8770_Editable
		{
			get
			{
				short num = (short)252116992;
				short num2 = num;
				num = (short)1142226945;
				if (num != 0)
				{
				}
				num = (short)65361164;
				short num3 = num;
				num = (short)1916425484;
				switch (num3 == num)
				{
				}
				num = (short)1704394752;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770.Editable;
			}
			set
			{
				short num = (short)1284636672;
				short num2 = num;
				num = (short)1246286587;
				short num3 = num;
				num = (short)877253371;
				switch (num3 == num)
				{
				}
				num = (short)391970817;
				if (num != 0)
				{
				}
				num = (short)461504512;
				if (num != 0)
				{
				}
				this.cnvPerSignalingPTTID_A8770.Editable = value;
			}
		}

		// Token: 0x170066ED RID: 26349
		// (get) Token: 0x0600CCB9 RID: 52409 RVA: 0x00BECCD8 File Offset: 0x00BEAED8
		internal string CnvPerSignalingPTTID_A8770_UILabel
		{
			get
			{
				short num = (short)265158656;
				short num2 = num;
				num = (short)2067389543;
				short num3 = num;
				num = (short)624614503;
				switch (num3 == num)
				{
				}
				num = (short)165609473;
				if (num != 0)
				{
				}
				num = (short)910884864;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770.UIName;
			}
		}

		// Token: 0x170066EE RID: 26350
		// (get) Token: 0x0600CCBA RID: 52410 RVA: 0x00BECD8C File Offset: 0x00BEAF8C
		// (set) Token: 0x0600CCBB RID: 52411 RVA: 0x00BECE3C File Offset: 0x00BEB03C
		internal bool CnvPerSignalingPTTID_A8770_HiddenStatic
		{
			get
			{
				short num = (short)2006319104;
				short num2 = num;
				num = (short)808682713;
				short num3 = num;
				num = (short)797934809;
				switch (num3 == num)
				{
				}
				num = (short)1076428801;
				if (num != 0)
				{
				}
				num = (short)544407552;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770.HiddenStatic;
			}
			set
			{
				short num = (short)1325072384;
				short num2 = num;
				num = (short)600929023;
				short num3 = num;
				num = (short)1101165311;
				switch (num3 == num)
				{
				}
				num = (short)1460535296;
				if (num != 0)
				{
				}
				num = (short)403767297;
				if (num != 0)
				{
				}
				this.cnvPerSignalingPTTID_A8770.HiddenStatic = value;
			}
		}

		// Token: 0x170066EF RID: 26351
		// (get) Token: 0x0600CCBC RID: 52412 RVA: 0x00BECEF0 File Offset: 0x00BEB0F0
		// (set) Token: 0x0600CCBD RID: 52413 RVA: 0x00BECFA8 File Offset: 0x00BEB1A8
		internal bool CnvPerSignalingPTTID_A8770_HiddenDynamic
		{
			get
			{
				short num = (short)116523008;
				short num2 = num;
				num = (short)1078813641;
				short num3 = num;
				num = (short)857301961;
				switch (num3 == num)
				{
				}
				num = (short)334430209;
				if (num != 0)
				{
				}
				num = (short)867827712;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770.HiddenDynamic;
			}
			set
			{
				short num = (short)488964096;
				short num2 = num;
				num = (short)404742365;
				short num3 = num;
				num = (short)708436189;
				switch (num3 == num)
				{
				}
				num = (short)1155989504;
				if (num != 0)
				{
				}
				num = (short)1407254529;
				if (num != 0)
				{
				}
				this.cnvPerSignalingPTTID_A8770.HiddenDynamic = value;
			}
		}

		// Token: 0x170066F0 RID: 26352
		// (get) Token: 0x0600CCBE RID: 52414 RVA: 0x00BED060 File Offset: 0x00BEB260
		public bool CnvPerSignalingPTTID_A8770_HasDiffs
		{
			get
			{
				short num = (short)1228472320;
				short num2 = num;
				num = (short)153029974;
				short num3 = num;
				num = (short)951520598;
				switch (num3 == num)
				{
				}
				num = (short)520224769;
				if (num != 0)
				{
				}
				num = (short)1137508352;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingPTTID_A8770._HasDiffs;
			}
		}

		// Token: 0x170066F1 RID: 26353
		// (get) Token: 0x0600CCBF RID: 52415 RVA: 0x00BED114 File Offset: 0x00BEB314
		// (set) Token: 0x0600CCC0 RID: 52416 RVA: 0x00BED1C8 File Offset: 0x00BEB3C8
		public int CnvPerSignalingRevertType_A8953Value
		{
			get
			{
				short num = (short)863240192;
				short num2 = num;
				num = (short)941419523;
				short num3 = num;
				num = (short)1888939011;
				switch (num3 == num)
				{
				}
				num = (short)1401749504;
				if (num != 0)
				{
				}
				num = (short)1913061377;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953.Value;
			}
			set
			{
				short num = (short)470941696;
				short num2 = num;
				num = (short)640529584;
				short num3 = num;
				num = (short)917550256;
				switch (num3 == num)
				{
				}
				num = (short)2053767169;
				if (num != 0)
				{
				}
				num = (short)856358912;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertType_A8953.Value = value;
			}
		}

		// Token: 0x170066F2 RID: 26354
		// (get) Token: 0x0600CCC1 RID: 52417 RVA: 0x00BED27C File Offset: 0x00BEB47C
		// (set) Token: 0x0600CCC2 RID: 52418 RVA: 0x00BED330 File Offset: 0x00BEB530
		public string CnvPerSignalingRevertType_A8953_UIValue
		{
			get
			{
				short num = (short)597164032;
				short num2 = num;
				num = (short)1505681839;
				short num3 = num;
				num = (short)624222639;
				switch (num3 == num)
				{
				}
				num = (short)1625423873;
				if (num != 0)
				{
				}
				num = (short)1006370816;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953.UIValue;
			}
			set
			{
				short num = (short)209649664;
				short num2 = num;
				num = (short)1252655105;
				if (num != 0)
				{
				}
				num = (short)1187222891;
				short num3 = num;
				num = (short)1719899499;
				switch (num3 == num)
				{
				}
				num = (short)709099520;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertType_A8953.UIValue = value;
			}
		}

		// Token: 0x170066F3 RID: 26355
		// (get) Token: 0x0600CCC3 RID: 52419 RVA: 0x00BED3E4 File Offset: 0x00BEB5E4
		public global::AcpBusinessLayer.AcpListField CnvPerSignalingRevertType_A8953
		{
			get
			{
				short num = (short)37486592;
				short num2 = num;
				num = (short)1062158962;
				short num3 = num;
				num = (short)1059865202;
				switch (num3 == num)
				{
				}
				num = (short)432078849;
				if (num != 0)
				{
				}
				num = (short)1313996800;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953;
			}
		}

		// Token: 0x170066F4 RID: 26356
		// (get) Token: 0x0600CCC4 RID: 52420 RVA: 0x00BED494 File Offset: 0x00BEB694
		// (set) Token: 0x0600CCC5 RID: 52421 RVA: 0x00BED54C File Offset: 0x00BEB74C
		public bool CnvPerSignalingRevertType_A8953_Applicable
		{
			get
			{
				short num = (short)810680320;
				short num2 = num;
				num = (short)761405076;
				short num3 = num;
				num = (short)217587348;
				switch (num3 == num)
				{
				}
				num = (short)649461760;
				if (num != 0)
				{
				}
				num = (short)1795686401;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953.Applicable;
			}
			set
			{
				short num = (short)1108213760;
				short num2 = num;
				num = (short)1833663501;
				short num3 = num;
				num = (short)849837069;
				switch (num3 == num)
				{
				}
				num = (short)1709441025;
				if (num != 0)
				{
				}
				num = (short)397279232;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertType_A8953.Applicable = value;
			}
		}

		// Token: 0x170066F5 RID: 26357
		// (get) Token: 0x0600CCC6 RID: 52422 RVA: 0x00BED604 File Offset: 0x00BEB804
		// (set) Token: 0x0600CCC7 RID: 52423 RVA: 0x00BED6B8 File Offset: 0x00BEB8B8
		public bool CnvPerSignalingRevertType_A8953_Valid
		{
			get
			{
				short num = (short)753270784;
				short num2 = num;
				num = (short)1250884841;
				short num3 = num;
				num = (short)235928809;
				switch (num3 == num)
				{
				}
				num = (short)767492096;
				if (num != 0)
				{
				}
				num = (short)884146177;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953.Valid;
			}
			set
			{
				short num = (short)1067188224;
				short num2 = num;
				num = (short)105642279;
				short num3 = num;
				num = (short)1768093991;
				switch (num3 == num)
				{
				}
				num = (short)1844248576;
				if (num != 0)
				{
				}
				num = (short)2085945345;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertType_A8953.Valid = value;
			}
		}

		// Token: 0x170066F6 RID: 26358
		// (get) Token: 0x0600CCC8 RID: 52424 RVA: 0x00BED76C File Offset: 0x00BEB96C
		// (set) Token: 0x0600CCC9 RID: 52425 RVA: 0x00BED820 File Offset: 0x00BEBA20
		public bool CnvPerSignalingRevertType_A8953_Visible
		{
			get
			{
				short num = (short)994246656;
				short num2 = num;
				num = (short)1570963457;
				if (num != 0)
				{
				}
				num = (short)536493682;
				short num3 = num;
				num = (short)1996242546;
				switch (num3 == num)
				{
				}
				num = (short)1746206720;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953.Visible;
			}
			set
			{
				short num = (short)466092032;
				short num2 = num;
				num = (short)1387127407;
				short num3 = num;
				num = (short)112452207;
				switch (num3 == num)
				{
				}
				num = (short)1951465473;
				if (num != 0)
				{
				}
				num = (short)465895424;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertType_A8953.Visible = value;
			}
		}

		// Token: 0x170066F7 RID: 26359
		// (get) Token: 0x0600CCCA RID: 52426 RVA: 0x00BED8D4 File Offset: 0x00BEBAD4
		// (set) Token: 0x0600CCCB RID: 52427 RVA: 0x00BED988 File Offset: 0x00BEBB88
		public bool CnvPerSignalingRevertType_A8953_Editable
		{
			get
			{
				short num = (short)284950528;
				short num2 = num;
				num = (short)432838378;
				short num3 = num;
				num = (short)1806669546;
				switch (num3 == num)
				{
				}
				num = (short)425590784;
				if (num != 0)
				{
				}
				num = (short)399179777;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953.Editable;
			}
			set
			{
				short num = (short)1103626240;
				short num2 = num;
				num = (short)1983802552;
				short num3 = num;
				num = (short)1134783672;
				switch (num3 == num)
				{
				}
				num = (short)592510976;
				if (num != 0)
				{
				}
				num = (short)542703617;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertType_A8953.Editable = value;
			}
		}

		// Token: 0x170066F8 RID: 26360
		// (get) Token: 0x0600CCCC RID: 52428 RVA: 0x00BEDA3C File Offset: 0x00BEBC3C
		internal string CnvPerSignalingRevertType_A8953_UILabel
		{
			get
			{
				short num = (short)1615790080;
				short num2 = num;
				num = (short)1867617649;
				short num3 = num;
				num = (short)325096817;
				switch (num3 == num)
				{
				}
				num = (short)1838350337;
				if (num != 0)
				{
				}
				num = (short)11796480;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953.UIName;
			}
		}

		// Token: 0x170066F9 RID: 26361
		// (get) Token: 0x0600CCCD RID: 52429 RVA: 0x00BEDAF0 File Offset: 0x00BEBCF0
		// (set) Token: 0x0600CCCE RID: 52430 RVA: 0x00BEDBA8 File Offset: 0x00BEBDA8
		internal bool CnvPerSignalingRevertType_A8953_HiddenStatic
		{
			get
			{
				short num = (short)502530048;
				short num2 = num;
				num = (short)313458689;
				if (num != 0)
				{
				}
				num = (short)335966620;
				short num3 = num;
				num = (short)2065068444;
				switch (num3 == num)
				{
				}
				num = (short)1313079296;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953.HiddenStatic;
			}
			set
			{
				short num = (short)1611595776;
				short num2 = num;
				num = (short)1439177507;
				short num3 = num;
				num = (short)1400380195;
				switch (num3 == num)
				{
				}
				num = (short)690028544;
				if (num != 0)
				{
				}
				num = (short)294912001;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertType_A8953.HiddenStatic = value;
			}
		}

		// Token: 0x170066FA RID: 26362
		// (get) Token: 0x0600CCCF RID: 52431 RVA: 0x00BEDC5C File Offset: 0x00BEBE5C
		// (set) Token: 0x0600CCD0 RID: 52432 RVA: 0x00BEDD10 File Offset: 0x00BEBF10
		internal bool CnvPerSignalingRevertType_A8953_HiddenDynamic
		{
			get
			{
				short num = (short)944308224;
				short num2 = num;
				num = (short)663034248;
				short num3 = num;
				num = (short)390928776;
				switch (num3 == num)
				{
				}
				num = (short)1791492097;
				if (num != 0)
				{
				}
				num = (short)1986265088;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953.HiddenDynamic;
			}
			set
			{
				short num = (short)1846411264;
				short num2 = num;
				num = (short)1393067748;
				short num3 = num;
				num = (short)1361151716;
				switch (num3 == num)
				{
				}
				num = (short)1732116481;
				if (num != 0)
				{
				}
				num = (short)1789067264;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertType_A8953.HiddenDynamic = value;
			}
		}

		// Token: 0x170066FB RID: 26363
		// (get) Token: 0x0600CCD1 RID: 52433 RVA: 0x00BEDDC8 File Offset: 0x00BEBFC8
		public bool CnvPerSignalingRevertType_A8953_HasDiffs
		{
			get
			{
				short num = (short)124583936;
				short num2 = num;
				num = (short)1246498737;
				short num3 = num;
				num = (short)90574769;
				switch (num3 == num)
				{
				}
				num = (short)1063911425;
				if (num != 0)
				{
				}
				num = (short)2035875840;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertType_A8953._HasDiffs;
			}
		}

		// Token: 0x170066FC RID: 26364
		// (get) Token: 0x0600CCD2 RID: 52434 RVA: 0x00BEDE7C File Offset: 0x00BEC07C
		// (set) Token: 0x0600CCD3 RID: 52435 RVA: 0x00BEDF34 File Offset: 0x00BEC134
		public int CnvPerSignalingASTRORxUnmuteRule_A9042Value
		{
			get
			{
				short num = (short)607846400;
				short num2 = num;
				num = (short)1614385939;
				short num3 = num;
				num = (short)907645715;
				switch (num3 == num)
				{
				}
				num = (short)1720844289;
				if (num != 0)
				{
				}
				num = (short)156303360;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042.Value;
			}
			set
			{
				short num = (short)2002452480;
				short num2 = num;
				num = (short)75678726;
				short num3 = num;
				num = (short)1285145606;
				switch (num3 == num)
				{
				}
				num = (short)486408192;
				if (num != 0)
				{
				}
				num = (short)515964929;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTRORxUnmuteRule_A9042.Value = value;
			}
		}

		// Token: 0x170066FD RID: 26365
		// (get) Token: 0x0600CCD4 RID: 52436 RVA: 0x00BEDFE8 File Offset: 0x00BEC1E8
		// (set) Token: 0x0600CCD5 RID: 52437 RVA: 0x00BEE09C File Offset: 0x00BEC29C
		public string CnvPerSignalingASTRORxUnmuteRule_A9042_UIValue
		{
			get
			{
				short num = (short)909547172;
				short num2 = num;
				num = (short)1491244708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)401276928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2062221313;
				if (num != 0)
				{
				}
				num = (short)879755264;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042.UIValue;
			}
			set
			{
				short num = (short)1575364355;
				short num2 = num;
				num = (short)428353283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977352192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1244725249;
				if (num != 0)
				{
				}
				num = (short)794558464;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTRORxUnmuteRule_A9042.UIValue = value;
			}
		}

		// Token: 0x170066FE RID: 26366
		// (get) Token: 0x0600CCD6 RID: 52438 RVA: 0x00BEE150 File Offset: 0x00BEC350
		public global::AcpBusinessLayer.AcpListField CnvPerSignalingASTRORxUnmuteRule_A9042
		{
			get
			{
				short num = (short)417595393;
				if (num != 0)
				{
				}
				num = (short)1674182656;
				short num2 = num;
				num = (short)56294372;
				short num3 = num;
				num = (short)922090468;
				switch (num3 == num)
				{
				}
				num = (short)726138880;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042;
			}
		}

		// Token: 0x170066FF RID: 26367
		// (get) Token: 0x0600CCD7 RID: 52439 RVA: 0x00BEE200 File Offset: 0x00BEC400
		// (set) Token: 0x0600CCD8 RID: 52440 RVA: 0x00BEE2B4 File Offset: 0x00BEC4B4
		public bool CnvPerSignalingASTRORxUnmuteRule_A9042_Applicable
		{
			get
			{
				short num = (short)74252289;
				if (num != 0)
				{
				}
				num = (short)1590493184;
				short num2 = num;
				num = (short)880351473;
				short num3 = num;
				num = (short)502012145;
				switch (num3 == num)
				{
				}
				num = (short)1537277952;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042.Applicable;
			}
			set
			{
				short num = (short)668499363;
				short num2 = num;
				num = (short)1588362659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1695940608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)30015488;
				if (num != 0)
				{
				}
				num = (short)571342849;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTRORxUnmuteRule_A9042.Applicable = value;
			}
		}

		// Token: 0x17006700 RID: 26368
		// (get) Token: 0x0600CCD9 RID: 52441 RVA: 0x00BEE36C File Offset: 0x00BEC56C
		// (set) Token: 0x0600CCDA RID: 52442 RVA: 0x00BEE420 File Offset: 0x00BEC620
		public bool CnvPerSignalingASTRORxUnmuteRule_A9042_Valid
		{
			get
			{
				short num = (short)1916673081;
				short num2 = num;
				num = (short)91888697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)664862720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2078343169;
				if (num != 0)
				{
				}
				num = (short)679936000;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042.Valid;
			}
			set
			{
				short num = (short)1118371841;
				if (num != 0)
				{
				}
				num = (short)2132279296;
				short num2 = num;
				num = (short)662043573;
				short num3 = num;
				num = (short)1937636277;
				switch (num3 == num)
				{
				}
				num = (short)1943601152;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTRORxUnmuteRule_A9042.Valid = value;
			}
		}

		// Token: 0x17006701 RID: 26369
		// (get) Token: 0x0600CCDB RID: 52443 RVA: 0x00BEE4D4 File Offset: 0x00BEC6D4
		// (set) Token: 0x0600CCDC RID: 52444 RVA: 0x00BEE588 File Offset: 0x00BEC788
		public bool CnvPerSignalingASTRORxUnmuteRule_A9042_Visible
		{
			get
			{
				short num = (short)489354805;
				short num2 = num;
				num = (short)1219819061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1184694272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)478609409;
				if (num != 0)
				{
				}
				num = (short)1949237248;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042.Visible;
			}
			set
			{
				short num = (short)597164033;
				if (num != 0)
				{
				}
				num = (short)420675584;
				short num2 = num;
				num = (short)117272232;
				short num3 = num;
				num = (short)276852392;
				switch (num3 == num)
				{
				}
				num = (short)1309671424;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTRORxUnmuteRule_A9042.Visible = value;
			}
		}

		// Token: 0x17006702 RID: 26370
		// (get) Token: 0x0600CCDD RID: 52445 RVA: 0x00BEE640 File Offset: 0x00BEC840
		// (set) Token: 0x0600CCDE RID: 52446 RVA: 0x00BEE6F4 File Offset: 0x00BEC8F4
		public bool CnvPerSignalingASTRORxUnmuteRule_A9042_Editable
		{
			get
			{
				short num = (short)1573847041;
				if (num != 0)
				{
				}
				num = (short)21889024;
				short num2 = num;
				num = (short)1203490908;
				short num3 = num;
				num = (short)554422364;
				switch (num3 == num)
				{
				}
				num = (short)731971584;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042.Editable;
			}
			set
			{
				short num = (short)1339555841;
				if (num != 0)
				{
				}
				num = (short)1090715648;
				short num2 = num;
				num = (short)47497184;
				short num3 = num;
				num = (short)1984806880;
				switch (num3 == num)
				{
				}
				num = (short)340852736;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTRORxUnmuteRule_A9042.Editable = value;
			}
		}

		// Token: 0x17006703 RID: 26371
		// (get) Token: 0x0600CCDF RID: 52447 RVA: 0x00BEE7A8 File Offset: 0x00BEC9A8
		internal string CnvPerSignalingASTRORxUnmuteRule_A9042_UILabel
		{
			get
			{
				short num = (short)1460618873;
				short num2 = num;
				num = (short)1631340153;
				switch (num2 == num)
				{
				default:
				{
					num = (short)546308096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)827129857;
				if (num != 0)
				{
				}
				num = (short)636420096;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042.UIName;
			}
		}

		// Token: 0x17006704 RID: 26372
		// (get) Token: 0x0600CCE0 RID: 52448 RVA: 0x00BEE85C File Offset: 0x00BECA5C
		// (set) Token: 0x0600CCE1 RID: 52449 RVA: 0x00BEE914 File Offset: 0x00BECB14
		internal bool CnvPerSignalingASTRORxUnmuteRule_A9042_HiddenStatic
		{
			get
			{
				short num = (short)1788446868;
				short num2 = num;
				num = (short)255821972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)299761664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1905000449;
				if (num != 0)
				{
				}
				num = (short)1699282944;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042.HiddenStatic;
			}
			set
			{
				short num = (short)1296537565;
				short num2 = num;
				num = (short)38049757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)330432512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)407961600;
				if (num != 0)
				{
				}
				num = (short)2111700993;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTRORxUnmuteRule_A9042.HiddenStatic = value;
			}
		}

		// Token: 0x17006705 RID: 26373
		// (get) Token: 0x0600CCE2 RID: 52450 RVA: 0x00BEE9CC File Offset: 0x00BECBCC
		// (set) Token: 0x0600CCE3 RID: 52451 RVA: 0x00BEEA80 File Offset: 0x00BECC80
		internal bool CnvPerSignalingASTRORxUnmuteRule_A9042_HiddenDynamic
		{
			get
			{
				short num = (short)1531565061;
				short num2 = num;
				num = (short)1992938501;
				switch (num2 == num)
				{
				default:
				{
					num = (short)281477120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)566886400;
				if (num != 0)
				{
				}
				num = (short)37027841;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042.HiddenDynamic;
			}
			set
			{
				short num = (short)1779256870;
				short num2 = num;
				num = (short)1273384486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)606208000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)46465025;
				if (num != 0)
				{
				}
				num = (short)388890624;
				if (num != 0)
				{
				}
				this.cnvPerSignalingASTRORxUnmuteRule_A9042.HiddenDynamic = value;
			}
		}

		// Token: 0x17006706 RID: 26374
		// (get) Token: 0x0600CCE4 RID: 52452 RVA: 0x00BEEB34 File Offset: 0x00BECD34
		public bool CnvPerSignalingASTRORxUnmuteRule_A9042_HasDiffs
		{
			get
			{
				short num = (short)94732050;
				short num2 = num;
				num = (short)1410236178;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1182531584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1306001409;
				if (num != 0)
				{
				}
				num = (short)347734016;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingASTRORxUnmuteRule_A9042._HasDiffs;
			}
		}

		// Token: 0x17006707 RID: 26375
		// (get) Token: 0x0600CCE5 RID: 52453 RVA: 0x00BEEBE8 File Offset: 0x00BECDE8
		// (set) Token: 0x0600CCE6 RID: 52454 RVA: 0x00BEEC9C File Offset: 0x00BECE9C
		public int CnvPerSignalingSignalingType_A9129Value
		{
			get
			{
				short num = (short)2056480471;
				short num2 = num;
				num = (short)1753114327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1281097728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1493565441;
				if (num != 0)
				{
				}
				num = (short)1355546624;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129.Value;
			}
			set
			{
				short num = (short)798976666;
				short num2 = num;
				num = (short)1748724378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)119275520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)287899648;
				if (num != 0)
				{
				}
				num = (short)908918785;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSignalingType_A9129.Value = value;
			}
		}

		// Token: 0x17006708 RID: 26376
		// (get) Token: 0x0600CCE7 RID: 52455 RVA: 0x00BEED54 File Offset: 0x00BECF54
		// (set) Token: 0x0600CCE8 RID: 52456 RVA: 0x00BEEE08 File Offset: 0x00BED008
		public string CnvPerSignalingSignalingType_A9129_UIValue
		{
			get
			{
				short num = (short)909140152;
				short num2 = num;
				num = (short)1518887096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)426770432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1862860801;
				if (num != 0)
				{
				}
				num = (short)1625489408;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129.UIValue;
			}
			set
			{
				short num = (short)576950613;
				short num2 = num;
				num = (short)1844744533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1899692032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1474625536;
				if (num != 0)
				{
				}
				num = (short)258801665;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSignalingType_A9129.UIValue = value;
			}
		}

		// Token: 0x17006709 RID: 26377
		// (get) Token: 0x0600CCE9 RID: 52457 RVA: 0x00BEEEBC File Offset: 0x00BED0BC
		public global::AcpBusinessLayer.AcpListField CnvPerSignalingSignalingType_A9129
		{
			get
			{
				short num = (short)981579745;
				short num2 = num;
				num = (short)817674209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)933756928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2037055489;
				if (num != 0)
				{
				}
				num = (short)1845428224;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129;
			}
		}

		// Token: 0x1700670A RID: 26378
		// (get) Token: 0x0600CCEA RID: 52458 RVA: 0x00BEEF6C File Offset: 0x00BED16C
		// (set) Token: 0x0600CCEB RID: 52459 RVA: 0x00BEF024 File Offset: 0x00BED224
		public bool CnvPerSignalingSignalingType_A9129_Applicable
		{
			get
			{
				short num = (short)94295682;
				short num2 = num;
				num = (short)490591874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1226899456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)974192640;
				if (num != 0)
				{
				}
				num = (short)637927425;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129.Applicable;
			}
			set
			{
				short num = (short)318121719;
				short num2 = num;
				num = (short)1533355767;
				switch (num2 == num)
				{
				default:
				{
					num = (short)986972160;
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
				num = (short)236847104;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSignalingType_A9129.Applicable = value;
			}
		}

		// Token: 0x1700670B RID: 26379
		// (get) Token: 0x0600CCEC RID: 52460 RVA: 0x00BEF0DC File Offset: 0x00BED2DC
		// (set) Token: 0x0600CCED RID: 52461 RVA: 0x00BEF190 File Offset: 0x00BED390
		public bool CnvPerSignalingSignalingType_A9129_Valid
		{
			get
			{
				short num = (short)487220077;
				short num2 = num;
				num = (short)249783149;
				switch (num2 == num)
				{
				default:
				{
					num = (short)924319744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)206569473;
				if (num != 0)
				{
				}
				num = (short)1677524992;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129.Valid;
			}
			set
			{
				short num = (short)149376852;
				short num2 = num;
				num = (short)1327714132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)340918272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1728577537;
				if (num != 0)
				{
				}
				num = (short)604372992;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSignalingType_A9129.Valid = value;
			}
		}

		// Token: 0x1700670C RID: 26380
		// (get) Token: 0x0600CCEE RID: 52462 RVA: 0x00BEF244 File Offset: 0x00BED444
		// (set) Token: 0x0600CCEF RID: 52463 RVA: 0x00BEF2FC File Offset: 0x00BED4FC
		public bool CnvPerSignalingSignalingType_A9129_Visible
		{
			get
			{
				short num = (short)1639301019;
				short num2 = num;
				num = (short)936296347;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1636827136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869742080;
				if (num != 0)
				{
				}
				num = (short)813891585;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129.Visible;
			}
			set
			{
				short num = (short)1749705054;
				short num2 = num;
				num = (short)227893598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)501415936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)941293569;
				if (num != 0)
				{
				}
				num = (short)1111097344;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSignalingType_A9129.Visible = value;
			}
		}

		// Token: 0x1700670D RID: 26381
		// (get) Token: 0x0600CCF0 RID: 52464 RVA: 0x00BEF3B4 File Offset: 0x00BED5B4
		// (set) Token: 0x0600CCF1 RID: 52465 RVA: 0x00BEF464 File Offset: 0x00BED664
		public bool CnvPerSignalingSignalingType_A9129_Editable
		{
			get
			{
				short num = (short)342278467;
				short num2 = num;
				num = (short)1772536131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)18546688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1136394241;
				if (num != 0)
				{
				}
				num = (short)1727922176;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129.Editable;
			}
			set
			{
				short num = (short)916220753;
				short num2 = num;
				num = (short)1155361617;
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
				num = (short)1957625856;
				if (num != 0)
				{
				}
				num = (short)465960961;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSignalingType_A9129.Editable = value;
			}
		}

		// Token: 0x1700670E RID: 26382
		// (get) Token: 0x0600CCF2 RID: 52466 RVA: 0x00BEF518 File Offset: 0x00BED718
		internal string CnvPerSignalingSignalingType_A9129_UILabel
		{
			get
			{
				short num = (short)1423174682;
				short num2 = num;
				num = (short)1385753626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1631453184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2140340225;
				if (num != 0)
				{
				}
				num = (short)1043464192;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129.UIName;
			}
		}

		// Token: 0x1700670F RID: 26383
		// (get) Token: 0x0600CCF3 RID: 52467 RVA: 0x00BEF5D0 File Offset: 0x00BED7D0
		// (set) Token: 0x0600CCF4 RID: 52468 RVA: 0x00BEF684 File Offset: 0x00BED884
		internal bool CnvPerSignalingSignalingType_A9129_HiddenStatic
		{
			get
			{
				short num = (short)719934488;
				short num2 = num;
				num = (short)96228376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)239009792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1441595392;
				if (num != 0)
				{
				}
				num = (short)1727463425;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129.HiddenStatic;
			}
			set
			{
				short num = (short)90918345;
				short num2 = num;
				num = (short)1678462409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)860618752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1946222593;
				if (num != 0)
				{
				}
				num = (short)45416448;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSignalingType_A9129.HiddenStatic = value;
			}
		}

		// Token: 0x17006710 RID: 26384
		// (get) Token: 0x0600CCF5 RID: 52469 RVA: 0x00BEF73C File Offset: 0x00BED93C
		// (set) Token: 0x0600CCF6 RID: 52470 RVA: 0x00BEF7EC File Offset: 0x00BED9EC
		internal bool CnvPerSignalingSignalingType_A9129_HiddenDynamic
		{
			get
			{
				short num = (short)1347766607;
				short num2 = num;
				num = (short)1468090703;
				switch (num2 == num)
				{
				default:
				{
					num = (short)489422848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1622736897;
				if (num != 0)
				{
				}
				num = (short)1059520512;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129.HiddenDynamic;
			}
			set
			{
				short num = (short)1300780383;
				short num2 = num;
				num = (short)625038687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881590272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1928134657;
				if (num != 0)
				{
				}
				num = (short)499384320;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSignalingType_A9129.HiddenDynamic = value;
			}
		}

		// Token: 0x17006711 RID: 26385
		// (get) Token: 0x0600CCF7 RID: 52471 RVA: 0x00BEF8A0 File Offset: 0x00BEDAA0
		public bool CnvPerSignalingSignalingType_A9129_HasDiffs
		{
			get
			{
				short num = (short)401247661;
				short num2 = num;
				num = (short)1332972973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1388511232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1421148160;
				if (num != 0)
				{
				}
				num = (short)674824193;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSignalingType_A9129._HasDiffs;
			}
		}

		// Token: 0x17006712 RID: 26386
		// (get) Token: 0x0600CCF8 RID: 52472 RVA: 0x00BEF954 File Offset: 0x00BEDB54
		// (set) Token: 0x0600CCF9 RID: 52473 RVA: 0x00BEFA08 File Offset: 0x00BEDC08
		public int CnvPerSignalingSystemNumber_A9243Value
		{
			get
			{
				short num = (short)2555905;
				if (num != 0)
				{
				}
				num = (short)220463104;
				short num2 = num;
				num = (short)1439229386;
				short num3 = num;
				num = (short)18605514;
				switch (num3 == num)
				{
				}
				num = (short)2752512;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243.Value;
			}
			set
			{
				short num = (short)626949242;
				short num2 = num;
				num = (short)467434618;
				switch (num2 == num)
				{
				default:
				{
					num = (short)393019392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)11272192;
				if (num != 0)
				{
				}
				num = (short)1457717249;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSystemNumber_A9243.Value = value;
			}
		}

		// Token: 0x17006713 RID: 26387
		// (get) Token: 0x0600CCFA RID: 52474 RVA: 0x00BEFAC0 File Offset: 0x00BEDCC0
		// (set) Token: 0x0600CCFB RID: 52475 RVA: 0x00BEFB74 File Offset: 0x00BEDD74
		public string CnvPerSignalingSystemNumber_A9243_UIValue
		{
			get
			{
				short num = (short)56476879;
				short num2 = num;
				num = (short)704365775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)642318336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1689780225;
				if (num != 0)
				{
				}
				num = (short)1717043200;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243.UIValue;
			}
			set
			{
				short num = (short)839516763;
				short num2 = num;
				num = (short)1656095323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)472121344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1147535361;
				if (num != 0)
				{
				}
				num = (short)2034827264;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSystemNumber_A9243.UIValue = value;
			}
		}

		// Token: 0x17006714 RID: 26388
		// (get) Token: 0x0600CCFC RID: 52476 RVA: 0x00BEFC28 File Offset: 0x00BEDE28
		public global::AcpBusinessLayer.AcpRecRefField CnvPerSignalingSystemNumber_A9243
		{
			get
			{
				short num = (short)618299479;
				short num2 = num;
				num = (short)82280535;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1802108928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)477429761;
				if (num != 0)
				{
				}
				num = (short)1020002304;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243;
			}
		}

		// Token: 0x17006715 RID: 26389
		// (get) Token: 0x0600CCFD RID: 52477 RVA: 0x00BEFCDC File Offset: 0x00BEDEDC
		// (set) Token: 0x0600CCFE RID: 52478 RVA: 0x00BEFD90 File Offset: 0x00BEDF90
		public bool CnvPerSignalingSystemNumber_A9243_Applicable
		{
			get
			{
				short num = (short)1515587251;
				short num2 = num;
				num = (short)356255411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1871773696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1001848833;
				if (num != 0)
				{
				}
				num = (short)682819584;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243.Applicable;
			}
			set
			{
				short num = (short)1916045950;
				short num2 = num;
				num = (short)1199737470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1615331328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1692401664;
				if (num != 0)
				{
				}
				num = (short)1418592257;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSystemNumber_A9243.Applicable = value;
			}
		}

		// Token: 0x17006716 RID: 26390
		// (get) Token: 0x0600CCFF RID: 52479 RVA: 0x00BEFE44 File Offset: 0x00BEE044
		// (set) Token: 0x0600CD00 RID: 52480 RVA: 0x00BEFEF8 File Offset: 0x00BEE0F8
		public bool CnvPerSignalingSystemNumber_A9243_Valid
		{
			get
			{
				short num = (short)511836161;
				if (num != 0)
				{
				}
				num = (short)1080229888;
				short num2 = num;
				num = (short)1617194518;
				short num3 = num;
				num = (short)1702391318;
				switch (num3 == num)
				{
				}
				num = (short)1918959616;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243.Valid;
			}
			set
			{
				short num = (short)1239360143;
				short num2 = num;
				num = (short)719856271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)701693952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1404043265;
				if (num != 0)
				{
				}
				num = (short)268894208;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSystemNumber_A9243.Valid = value;
			}
		}

		// Token: 0x17006717 RID: 26391
		// (get) Token: 0x0600CD01 RID: 52481 RVA: 0x00BEFFAC File Offset: 0x00BEE1AC
		// (set) Token: 0x0600CD02 RID: 52482 RVA: 0x00BF0060 File Offset: 0x00BEE260
		public bool CnvPerSignalingSystemNumber_A9243_Visible
		{
			get
			{
				short num = (short)198987888;
				short num2 = num;
				num = (short)1409044592;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1558315008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847314945;
				if (num != 0)
				{
				}
				num = (short)1734279168;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243.Visible;
			}
			set
			{
				short num = (short)1427825700;
				short num2 = num;
				num = (short)335733796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)248512512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)908263425;
				if (num != 0)
				{
				}
				num = (short)1423441920;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSystemNumber_A9243.Visible = value;
			}
		}

		// Token: 0x17006718 RID: 26392
		// (get) Token: 0x0600CD03 RID: 52483 RVA: 0x00BF0118 File Offset: 0x00BEE318
		// (set) Token: 0x0600CD04 RID: 52484 RVA: 0x00BF01CC File Offset: 0x00BEE3CC
		public bool CnvPerSignalingSystemNumber_A9243_Editable
		{
			get
			{
				short num = (short)2022571411;
				short num2 = num;
				num = (short)1266941331;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1650130944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1613299713;
				if (num != 0)
				{
				}
				num = (short)627900416;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243.Editable;
			}
			set
			{
				short num = (short)41983383;
				short num2 = num;
				num = (short)131571095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2102001664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)905641985;
				if (num != 0)
				{
				}
				num = (short)567607296;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSystemNumber_A9243.Editable = value;
			}
		}

		// Token: 0x17006719 RID: 26393
		// (get) Token: 0x0600CD05 RID: 52485 RVA: 0x00BF0280 File Offset: 0x00BEE480
		internal string CnvPerSignalingSystemNumber_A9243_UILabel
		{
			get
			{
				short num = (short)2010369276;
				short num2 = num;
				num = (short)204721404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)650444800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1510342656;
				if (num != 0)
				{
				}
				num = (short)92274689;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243.UIName;
			}
		}

		// Token: 0x1700671A RID: 26394
		// (get) Token: 0x0600CD06 RID: 52486 RVA: 0x00BF0338 File Offset: 0x00BEE538
		// (set) Token: 0x0600CD07 RID: 52487 RVA: 0x00BF03F0 File Offset: 0x00BEE5F0
		internal bool CnvPerSignalingSystemNumber_A9243_HiddenStatic
		{
			get
			{
				short num = (short)336042614;
				short num2 = num;
				num = (short)1297259126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2033909760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)382730240;
				if (num != 0)
				{
				}
				num = (short)1747058689;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243.HiddenStatic;
			}
			set
			{
				short num = (short)2126192652;
				short num2 = num;
				num = (short)980033548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)641531904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)317259776;
				if (num != 0)
				{
				}
				num = (short)197066753;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSystemNumber_A9243.HiddenStatic = value;
			}
		}

		// Token: 0x1700671B RID: 26395
		// (get) Token: 0x0600CD08 RID: 52488 RVA: 0x00BF04A4 File Offset: 0x00BEE6A4
		// (set) Token: 0x0600CD09 RID: 52489 RVA: 0x00BF055C File Offset: 0x00BEE75C
		internal bool CnvPerSignalingSystemNumber_A9243_HiddenDynamic
		{
			get
			{
				short num = (short)552510742;
				short num2 = num;
				num = (short)989504790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1528037376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1010892801;
				if (num != 0)
				{
				}
				num = (short)318439424;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243.HiddenDynamic;
			}
			set
			{
				short num = (short)848376411;
				short num2 = num;
				num = (short)952578651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)304283648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)399835137;
				if (num != 0)
				{
				}
				num = (short)1335623680;
				if (num != 0)
				{
				}
				this.cnvPerSignalingSystemNumber_A9243.HiddenDynamic = value;
			}
		}

		// Token: 0x1700671C RID: 26396
		// (get) Token: 0x0600CD0A RID: 52490 RVA: 0x00BF0614 File Offset: 0x00BEE814
		public bool CnvPerSignalingSystemNumber_A9243_HasDiffs
		{
			get
			{
				short num = (short)922956465;
				short num2 = num;
				num = (short)712127153;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2009464832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1279918080;
				if (num != 0)
				{
				}
				num = (short)1659109377;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingSystemNumber_A9243._HasDiffs;
			}
		}

		// Token: 0x1700671D RID: 26397
		// (get) Token: 0x0600CD0B RID: 52491 RVA: 0x00BF06C8 File Offset: 0x00BEE8C8
		// (set) Token: 0x0600CD0C RID: 52492 RVA: 0x00BF0780 File Offset: 0x00BEE980
		public int CnvPerSignalingRevertZone_A13269Value
		{
			get
			{
				short num = (short)398909122;
				short num2 = num;
				num = (short)157474498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954859520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)903413761;
				if (num != 0)
				{
				}
				num = (short)2027945984;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269.Value;
			}
			set
			{
				short num = (short)1878347904;
				short num2 = num;
				num = (short)461459584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2126708736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1691877376;
				if (num != 0)
				{
				}
				num = (short)546766849;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertZone_A13269.Value = value;
			}
		}

		// Token: 0x1700671E RID: 26398
		// (get) Token: 0x0600CD0D RID: 52493 RVA: 0x00BF0838 File Offset: 0x00BEEA38
		// (set) Token: 0x0600CD0E RID: 52494 RVA: 0x00BF08F0 File Offset: 0x00BEEAF0
		public string CnvPerSignalingRevertZone_A13269_UIValue
		{
			get
			{
				short num = (short)1620366573;
				short num2 = num;
				num = (short)1813370093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)928514048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1202913281;
				if (num != 0)
				{
				}
				num = (short)1289551872;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269.UIValue;
			}
			set
			{
				short num = (short)1278981507;
				short num2 = num;
				num = (short)1310700931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2044067840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1594163200;
				if (num != 0)
				{
				}
				num = (short)1437335553;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertZone_A13269.UIValue = value;
			}
		}

		// Token: 0x1700671F RID: 26399
		// (get) Token: 0x0600CD0F RID: 52495 RVA: 0x00BF09A8 File Offset: 0x00BEEBA8
		public global::AcpBusinessLayer.AcpRecRefField CnvPerSignalingRevertZone_A13269
		{
			get
			{
				short num = (short)1972317775;
				short num2 = num;
				num = (short)943926863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1190985728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)235536385;
				if (num != 0)
				{
				}
				num = (short)2090205184;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269;
			}
		}

		// Token: 0x17006720 RID: 26400
		// (get) Token: 0x0600CD10 RID: 52496 RVA: 0x00BF0A58 File Offset: 0x00BEEC58
		// (set) Token: 0x0600CD11 RID: 52497 RVA: 0x00BF0B0C File Offset: 0x00BEED0C
		public bool CnvPerSignalingRevertZone_A13269_Applicable
		{
			get
			{
				short num = (short)2108906654;
				short num2 = num;
				num = (short)1664048286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1267269632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2101673985;
				if (num != 0)
				{
				}
				num = (short)1334378496;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269.Applicable;
			}
			set
			{
				short num = (short)1588435543;
				short num2 = num;
				num = (short)1855363671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1461256192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)73728001;
				if (num != 0)
				{
				}
				num = (short)2095185920;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertZone_A13269.Applicable = value;
			}
		}

		// Token: 0x17006721 RID: 26401
		// (get) Token: 0x0600CD12 RID: 52498 RVA: 0x00BF0BC0 File Offset: 0x00BEEDC0
		// (set) Token: 0x0600CD13 RID: 52499 RVA: 0x00BF0C74 File Offset: 0x00BEEE74
		public bool CnvPerSignalingRevertZone_A13269_Valid
		{
			get
			{
				short num = (short)1118516465;
				short num2 = num;
				num = (short)1814246641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1973878784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2026700800;
				if (num != 0)
				{
				}
				num = (short)108855297;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269.Valid;
			}
			set
			{
				short num = (short)1086128129;
				if (num != 0)
				{
				}
				num = (short)2077360128;
				short num2 = num;
				num = (short)1631912791;
				short num3 = num;
				num = (short)423166807;
				switch (num3 == num)
				{
				}
				num = (short)1052377088;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertZone_A13269.Valid = value;
			}
		}

		// Token: 0x17006722 RID: 26402
		// (get) Token: 0x0600CD14 RID: 52500 RVA: 0x00BF0D2C File Offset: 0x00BEEF2C
		// (set) Token: 0x0600CD15 RID: 52501 RVA: 0x00BF0DE4 File Offset: 0x00BEEFE4
		public bool CnvPerSignalingRevertZone_A13269_Visible
		{
			get
			{
				short num = (short)302244930;
				short num2 = num;
				num = (short)1921180738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)297402368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1605435392;
				if (num != 0)
				{
				}
				num = (short)1784348673;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269.Visible;
			}
			set
			{
				short num = (short)1017080776;
				short num2 = num;
				num = (short)413166536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)241303552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)407699457;
				if (num != 0)
				{
				}
				num = (short)687603712;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertZone_A13269.Visible = value;
			}
		}

		// Token: 0x17006723 RID: 26403
		// (get) Token: 0x0600CD16 RID: 52502 RVA: 0x00BF0E98 File Offset: 0x00BEF098
		// (set) Token: 0x0600CD17 RID: 52503 RVA: 0x00BF0F4C File Offset: 0x00BEF14C
		public bool CnvPerSignalingRevertZone_A13269_Editable
		{
			get
			{
				short num = (short)1272838319;
				short num2 = num;
				num = (short)1153431727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1184169984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)938606593;
				if (num != 0)
				{
				}
				num = (short)243990528;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269.Editable;
			}
			set
			{
				short num = (short)244858692;
				short num2 = num;
				num = (short)1314537284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)684523520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2054225920;
				if (num != 0)
				{
				}
				num = (short)769589249;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertZone_A13269.Editable = value;
			}
		}

		// Token: 0x17006724 RID: 26404
		// (get) Token: 0x0600CD18 RID: 52504 RVA: 0x00BF1004 File Offset: 0x00BEF204
		internal string CnvPerSignalingRevertZone_A13269_UILabel
		{
			get
			{
				short num = (short)289996801;
				if (num != 0)
				{
				}
				num = (short)30932992;
				short num2 = num;
				num = (short)1709851261;
				short num3 = num;
				num = (short)1352811133;
				switch (num3 == num)
				{
				}
				num = (short)1952972800;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269.UIName;
			}
		}

		// Token: 0x17006725 RID: 26405
		// (get) Token: 0x0600CD19 RID: 52505 RVA: 0x00BF10B8 File Offset: 0x00BEF2B8
		// (set) Token: 0x0600CD1A RID: 52506 RVA: 0x00BF116C File Offset: 0x00BEF36C
		internal bool CnvPerSignalingRevertZone_A13269_HiddenStatic
		{
			get
			{
				short num = (short)383272536;
				short num2 = num;
				num = (short)1087194712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927399936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1562509312;
				if (num != 0)
				{
				}
				num = (short)1510604801;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269.HiddenStatic;
			}
			set
			{
				short num = (short)376438785;
				if (num != 0)
				{
				}
				num = (short)773849088;
				short num2 = num;
				num = (short)404711516;
				short num3 = num;
				num = (short)1697409116;
				switch (num3 == num)
				{
				}
				num = (short)1564868608;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertZone_A13269.HiddenStatic = value;
			}
		}

		// Token: 0x17006726 RID: 26406
		// (get) Token: 0x0600CD1B RID: 52507 RVA: 0x00BF1220 File Offset: 0x00BEF420
		// (set) Token: 0x0600CD1C RID: 52508 RVA: 0x00BF12D4 File Offset: 0x00BEF4D4
		internal bool CnvPerSignalingRevertZone_A13269_HiddenDynamic
		{
			get
			{
				short num = (short)2063139479;
				short num2 = num;
				num = (short)1884422807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1612775424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1001914369;
				if (num != 0)
				{
				}
				num = (short)2037645312;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269.HiddenDynamic;
			}
			set
			{
				short num = (short)2073731592;
				short num2 = num;
				num = (short)602055176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1943601152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270598145;
				if (num != 0)
				{
				}
				num = (short)1906180096;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertZone_A13269.HiddenDynamic = value;
			}
		}

		// Token: 0x17006727 RID: 26407
		// (get) Token: 0x0600CD1D RID: 52509 RVA: 0x00BF138C File Offset: 0x00BEF58C
		public bool CnvPerSignalingRevertZone_A13269_HasDiffs
		{
			get
			{
				short num = (short)1914267711;
				short num2 = num;
				num = (short)1925146687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1295187968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1838219265;
				if (num != 0)
				{
				}
				num = (short)548864000;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertZone_A13269._HasDiffs;
			}
		}

		// Token: 0x17006728 RID: 26408
		// (get) Token: 0x0600CD1E RID: 52510 RVA: 0x00BF1440 File Offset: 0x00BEF640
		// (set) Token: 0x0600CD1F RID: 52511 RVA: 0x00BF14F4 File Offset: 0x00BEF6F4
		public int CnvPerSignalingRevertChannel_A13267Value
		{
			get
			{
				short num = (short)836296800;
				short num2 = num;
				num = (short)214294624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)615579648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1322188801;
				if (num != 0)
				{
				}
				num = (short)452263936;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267.Value;
			}
			set
			{
				short num = (short)2133101217;
				short num2 = num;
				num = (short)1434618529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)442499072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)238223361;
				if (num != 0)
				{
				}
				num = (short)1785528320;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertChannel_A13267.Value = value;
			}
		}

		// Token: 0x17006729 RID: 26409
		// (get) Token: 0x0600CD20 RID: 52512 RVA: 0x00BF15AC File Offset: 0x00BEF7AC
		// (set) Token: 0x0600CD21 RID: 52513 RVA: 0x00BF1660 File Offset: 0x00BEF860
		public string CnvPerSignalingRevertChannel_A13267_UIValue
		{
			get
			{
				short num = (short)873999714;
				short num2 = num;
				num = (short)230501730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1264254976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1396703233;
				if (num != 0)
				{
				}
				num = (short)782827520;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267.UIValue;
			}
			set
			{
				short num = (short)1313040492;
				short num2 = num;
				num = (short)452946028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)280887296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)62783488;
				if (num != 0)
				{
				}
				num = (short)1998913537;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertChannel_A13267.UIValue = value;
			}
		}

		// Token: 0x1700672A RID: 26410
		// (get) Token: 0x0600CD22 RID: 52514 RVA: 0x00BF1714 File Offset: 0x00BEF914
		public global::AcpBusinessLayer.AcpRecRefField CnvPerSignalingRevertChannel_A13267
		{
			get
			{
				short num = (short)97845249;
				if (num != 0)
				{
				}
				num = (short)1916469248;
				short num2 = num;
				num = (short)1820525672;
				short num3 = num;
				num = (short)923927656;
				switch (num3 == num)
				{
				}
				num = (short)312279040;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267;
			}
		}

		// Token: 0x1700672B RID: 26411
		// (get) Token: 0x0600CD23 RID: 52515 RVA: 0x00BF17C4 File Offset: 0x00BEF9C4
		// (set) Token: 0x0600CD24 RID: 52516 RVA: 0x00BF187C File Offset: 0x00BEFA7C
		public bool CnvPerSignalingRevertChannel_A13267_Applicable
		{
			get
			{
				short num = (short)1022431996;
				short num2 = num;
				num = (short)1900090108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)786956288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1918959617;
				if (num != 0)
				{
				}
				num = (short)1350893568;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267.Applicable;
			}
			set
			{
				short num = (short)1142620161;
				if (num != 0)
				{
				}
				num = (short)1137704960;
				short num2 = num;
				num = (short)1892182832;
				short num3 = num;
				num = (short)1858104112;
				switch (num3 == num)
				{
				}
				num = (short)1297547264;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertChannel_A13267.Applicable = value;
			}
		}

		// Token: 0x1700672C RID: 26412
		// (get) Token: 0x0600CD25 RID: 52517 RVA: 0x00BF1930 File Offset: 0x00BEFB30
		// (set) Token: 0x0600CD26 RID: 52518 RVA: 0x00BF19E8 File Offset: 0x00BEFBE8
		public bool CnvPerSignalingRevertChannel_A13267_Valid
		{
			get
			{
				short num = (short)487178759;
				short num2 = num;
				num = (short)1828176391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)336003072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2118516737;
				if (num != 0)
				{
				}
				num = (short)1204879360;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267.Valid;
			}
			set
			{
				short num = (short)1386726343;
				short num2 = num;
				num = (short)478135239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1384448000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284033025;
				if (num != 0)
				{
				}
				num = (short)1232863232;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertChannel_A13267.Valid = value;
			}
		}

		// Token: 0x1700672D RID: 26413
		// (get) Token: 0x0600CD27 RID: 52519 RVA: 0x00BF1A9C File Offset: 0x00BEFC9C
		// (set) Token: 0x0600CD28 RID: 52520 RVA: 0x00BF1B50 File Offset: 0x00BEFD50
		public bool CnvPerSignalingRevertChannel_A13267_Visible
		{
			get
			{
				short num = (short)470807623;
				short num2 = num;
				num = (short)2099246151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1561657344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)60424193;
				if (num != 0)
				{
				}
				num = (short)867303424;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267.Visible;
			}
			set
			{
				short num = (short)590020609;
				if (num != 0)
				{
				}
				num = (short)44433408;
				short num2 = num;
				num = (short)588501211;
				short num3 = num;
				num = (short)2001785051;
				switch (num3 == num)
				{
				}
				num = (short)1138819072;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertChannel_A13267.Visible = value;
			}
		}

		// Token: 0x1700672E RID: 26414
		// (get) Token: 0x0600CD29 RID: 52521 RVA: 0x00BF1C08 File Offset: 0x00BEFE08
		// (set) Token: 0x0600CD2A RID: 52522 RVA: 0x00BF1CC0 File Offset: 0x00BEFEC0
		public bool CnvPerSignalingRevertChannel_A13267_Editable
		{
			get
			{
				short num = (short)741329933;
				short num2 = num;
				num = (short)2076298253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)669646848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024196609;
				if (num != 0)
				{
				}
				num = (short)487653376;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267.Editable;
			}
			set
			{
				short num = (short)933867265;
				short num2 = num;
				num = (short)1073917697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)380895232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340080129;
				if (num != 0)
				{
				}
				num = (short)232062976;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertChannel_A13267.Editable = value;
			}
		}

		// Token: 0x1700672F RID: 26415
		// (get) Token: 0x0600CD2B RID: 52523 RVA: 0x00BF1D78 File Offset: 0x00BEFF78
		internal string CnvPerSignalingRevertChannel_A13267_UILabel
		{
			get
			{
				short num = (short)466288641;
				if (num != 0)
				{
				}
				num = (short)1036779520;
				short num2 = num;
				num = (short)2137135982;
				short num3 = num;
				num = (short)1643453294;
				switch (num3 == num)
				{
				}
				num = (short)1958477824;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267.UIName;
			}
		}

		// Token: 0x17006730 RID: 26416
		// (get) Token: 0x0600CD2C RID: 52524 RVA: 0x00BF1E30 File Offset: 0x00BF0030
		// (set) Token: 0x0600CD2D RID: 52525 RVA: 0x00BF1EE4 File Offset: 0x00BF00E4
		internal bool CnvPerSignalingRevertChannel_A13267_HiddenStatic
		{
			get
			{
				short num = (short)133437086;
				short num2 = num;
				num = (short)262870686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1190133760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40566785;
				if (num != 0)
				{
				}
				num = (short)466616320;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267.HiddenStatic;
			}
			set
			{
				short num = (short)1503985665;
				if (num != 0)
				{
				}
				num = (short)317325312;
				short num2 = num;
				num = (short)716273308;
				short num3 = num;
				num = (short)90273436;
				switch (num3 == num)
				{
				}
				num = (short)725417984;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertChannel_A13267.HiddenStatic = value;
			}
		}

		// Token: 0x17006731 RID: 26417
		// (get) Token: 0x0600CD2E RID: 52526 RVA: 0x00BF1F9C File Offset: 0x00BF019C
		// (set) Token: 0x0600CD2F RID: 52527 RVA: 0x00BF2054 File Offset: 0x00BF0254
		internal bool CnvPerSignalingRevertChannel_A13267_HiddenDynamic
		{
			get
			{
				short num = (short)1228144641;
				if (num != 0)
				{
				}
				num = (short)480837632;
				short num2 = num;
				num = (short)865025324;
				short num3 = num;
				num = (short)979516716;
				switch (num3 == num)
				{
				}
				num = (short)1617887232;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267.HiddenDynamic;
			}
			set
			{
				short num = (short)1856704732;
				short num2 = num;
				num = (short)1487605980;
				switch (num2 == num)
				{
				default:
				{
					num = (short)997326848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1203961857;
				if (num != 0)
				{
				}
				num = (short)1099628544;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertChannel_A13267.HiddenDynamic = value;
			}
		}

		// Token: 0x17006732 RID: 26418
		// (get) Token: 0x0600CD30 RID: 52528 RVA: 0x00BF2108 File Offset: 0x00BF0308
		public bool CnvPerSignalingRevertChannel_A13267_HasDiffs
		{
			get
			{
				short num = (short)1121058817;
				if (num != 0)
				{
				}
				num = (short)959643648;
				short num2 = num;
				num = (short)274843383;
				short num3 = num;
				num = (short)1548928759;
				switch (num3 == num)
				{
				}
				num = (short)626720768;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertChannel_A13267._HasDiffs;
			}
		}

		// Token: 0x17006733 RID: 26419
		// (get) Token: 0x0600CD31 RID: 52529 RVA: 0x00BF21C0 File Offset: 0x00BF03C0
		// (set) Token: 0x0600CD32 RID: 52530 RVA: 0x00BF2274 File Offset: 0x00BF0474
		public int CnvPerSignalingRevertTGWACNID_A40150Value
		{
			get
			{
				short num = (short)900595713;
				if (num != 0)
				{
				}
				num = (short)2038824960;
				short num2 = num;
				num = (short)1835177600;
				short num3 = num;
				num = (short)606901888;
				switch (num3 == num)
				{
				}
				num = (short)893648896;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.Value;
			}
			set
			{
				short num = (short)1569783809;
				if (num != 0)
				{
				}
				num = (short)1006174208;
				short num2 = num;
				num = (short)284927420;
				short num3 = num;
				num = (short)1274652092;
				switch (num3 == num)
				{
				}
				num = (short)1469775872;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.Value = value;
			}
		}

		// Token: 0x17006734 RID: 26420
		// (get) Token: 0x0600CD33 RID: 52531 RVA: 0x00BF2328 File Offset: 0x00BF0528
		public global::AcpBusinessLayer.AcpCustomRangeField CnvPerSignalingRevertTGWACNID_A40150
		{
			get
			{
				short num = (short)1307305472;
				short num2 = num;
				num = (short)1540220416;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2133065728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1534263296;
				if (num != 0)
				{
				}
				num = (short)1803288577;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150;
			}
		}

		// Token: 0x17006735 RID: 26421
		// (get) Token: 0x0600CD34 RID: 52532 RVA: 0x00BF23D4 File Offset: 0x00BF05D4
		// (set) Token: 0x0600CD35 RID: 52533 RVA: 0x00BF2484 File Offset: 0x00BF0684
		public string CnvPerSignalingRevertTGWACNID_A40150_UIValue
		{
			get
			{
				short num = (short)1752682946;
				short num2 = num;
				num = (short)583586242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)756809728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1258487808;
				if (num != 0)
				{
				}
				num = (short)190251009;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.UIValue;
			}
			set
			{
				short num = (short)1651017511;
				short num2 = num;
				num = (short)166430503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1906442240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)494141440;
				if (num != 0)
				{
				}
				num = (short)945094657;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.UIValue = value;
			}
		}

		// Token: 0x17006736 RID: 26422
		// (get) Token: 0x0600CD36 RID: 52534 RVA: 0x00BF253C File Offset: 0x00BF073C
		// (set) Token: 0x0600CD37 RID: 52535 RVA: 0x00BF25F0 File Offset: 0x00BF07F0
		public string CnvPerSignalingRevertTGWACNID_A40150_HexUIValue
		{
			get
			{
				short num = (short)1953532372;
				short num2 = num;
				num = (short)719948244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1844314112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1712324609;
				if (num != 0)
				{
				}
				num = (short)18350080;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.HexUIValue;
			}
			set
			{
				short num = (short)364164807;
				short num2 = num;
				num = (short)1391507143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)670367744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1272905729;
				if (num != 0)
				{
				}
				num = (short)343670784;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.HexUIValue = value;
			}
		}

		// Token: 0x17006737 RID: 26423
		// (get) Token: 0x0600CD38 RID: 52536 RVA: 0x00BF26AC File Offset: 0x00BF08AC
		// (set) Token: 0x0600CD39 RID: 52537 RVA: 0x00BF2760 File Offset: 0x00BF0960
		internal int CnvPerSignalingRevertTGWACNID_A40150Min
		{
			get
			{
				short num = (short)1718419456;
				short num2 = num;
				num = (short)1385037825;
				if (num != 0)
				{
				}
				num = (short)1581471681;
				short num3 = num;
				num = (short)1801607105;
				switch (num3 == num)
				{
				}
				num = (short)1264320512;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.Min;
			}
			set
			{
				short num = (short)1818820608;
				short num2 = num;
				num = (short)570664159;
				short num3 = num;
				num = (short)707241183;
				switch (num3 == num)
				{
				}
				num = (short)2064449536;
				if (num != 0)
				{
				}
				num = (short)433782785;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.Min = value;
			}
		}

		// Token: 0x17006738 RID: 26424
		// (get) Token: 0x0600CD3A RID: 52538 RVA: 0x00BF2814 File Offset: 0x00BF0A14
		// (set) Token: 0x0600CD3B RID: 52539 RVA: 0x00BF28CC File Offset: 0x00BF0ACC
		internal int CnvPerSignalingRevertTGWACNID_A40150Max
		{
			get
			{
				short num = (short)1278803968;
				short num2 = num;
				num = (short)391428885;
				short num3 = num;
				num = (short)144161557;
				switch (num3 == num)
				{
				}
				num = (short)1937178625;
				if (num != 0)
				{
				}
				num = (short)1299382272;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.Max;
			}
			set
			{
				short num = (short)1121714176;
				short num2 = num;
				num = (short)445404990;
				short num3 = num;
				num = (short)1960924990;
				switch (num3 == num)
				{
				}
				num = (short)311427073;
				if (num != 0)
				{
				}
				num = (short)647692288;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.Max = value;
			}
		}

		// Token: 0x17006739 RID: 26425
		// (get) Token: 0x0600CD3C RID: 52540 RVA: 0x00BF2984 File Offset: 0x00BF0B84
		// (set) Token: 0x0600CD3D RID: 52541 RVA: 0x00BF2A38 File Offset: 0x00BF0C38
		internal int CnvPerSignalingRevertTGWACNID_A40150Step
		{
			get
			{
				short num = (short)987496448;
				short num2 = num;
				num = (short)1600939168;
				short num3 = num;
				num = (short)233923744;
				switch (num3 == num)
				{
				}
				num = (short)1332346881;
				if (num != 0)
				{
				}
				num = (short)1283522560;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.StepSize;
			}
			set
			{
				short num = (short)518914048;
				short num2 = num;
				num = (short)1442289630;
				short num3 = num;
				num = (short)1686607838;
				switch (num3 == num)
				{
				}
				num = (short)375324673;
				if (num != 0)
				{
				}
				num = (short)1353515008;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.StepSize = value;
			}
		}

		// Token: 0x1700673A RID: 26426
		// (get) Token: 0x0600CD3E RID: 52542 RVA: 0x00BF2AEC File Offset: 0x00BF0CEC
		// (set) Token: 0x0600CD3F RID: 52543 RVA: 0x00BF2BA4 File Offset: 0x00BF0DA4
		public bool CnvPerSignalingRevertTGWACNID_A40150_Applicable
		{
			get
			{
				short num = (short)1085472768;
				short num2 = num;
				num = (short)849247748;
				short num3 = num;
				num = (short)398163460;
				switch (num3 == num)
				{
				}
				num = (short)1033043969;
				if (num != 0)
				{
				}
				num = (short)692912128;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.Applicable;
			}
			set
			{
				short num = (short)1500250112;
				short num2 = num;
				num = (short)1331232769;
				if (num != 0)
				{
				}
				num = (short)820657366;
				short num3 = num;
				num = (short)49036502;
				switch (num3 == num)
				{
				}
				num = (short)733872128;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.Applicable = value;
			}
		}

		// Token: 0x1700673B RID: 26427
		// (get) Token: 0x0600CD40 RID: 52544 RVA: 0x00BF2C5C File Offset: 0x00BF0E5C
		// (set) Token: 0x0600CD41 RID: 52545 RVA: 0x00BF2D10 File Offset: 0x00BF0F10
		public bool CnvPerSignalingRevertTGWACNID_A40150_Valid
		{
			get
			{
				short num = (short)171245568;
				short num2 = num;
				num = (short)1904824827;
				short num3 = num;
				num = (short)714297851;
				switch (num3 == num)
				{
				}
				num = (short)1025179649;
				if (num != 0)
				{
				}
				num = (short)710082560;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.Valid;
			}
			set
			{
				short num = (short)765263872;
				short num2 = num;
				num = (short)758622223;
				short num3 = num;
				num = (short)1218488335;
				switch (num3 == num)
				{
				}
				num = (short)1196949505;
				if (num != 0)
				{
				}
				num = (short)336789504;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.Valid = value;
			}
		}

		// Token: 0x1700673C RID: 26428
		// (get) Token: 0x0600CD42 RID: 52546 RVA: 0x00BF2DC8 File Offset: 0x00BF0FC8
		// (set) Token: 0x0600CD43 RID: 52547 RVA: 0x00BF2E7C File Offset: 0x00BF107C
		public bool CnvPerSignalingRevertTGWACNID_A40150_Visible
		{
			get
			{
				short num = (short)34930688;
				short num2 = num;
				num = (short)1980170241;
				if (num != 0)
				{
				}
				num = (short)2073407839;
				short num3 = num;
				num = (short)1106489695;
				switch (num3 == num)
				{
				}
				num = (short)2110390272;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.Visible;
			}
			set
			{
				short num = (short)228392960;
				short num2 = num;
				num = (short)2120017940;
				short num3 = num;
				num = (short)1892804628;
				switch (num3 == num)
				{
				}
				num = (short)175702016;
				if (num != 0)
				{
				}
				num = (short)214564865;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.Visible = value;
			}
		}

		// Token: 0x1700673D RID: 26429
		// (get) Token: 0x0600CD44 RID: 52548 RVA: 0x00BF2F34 File Offset: 0x00BF1134
		// (set) Token: 0x0600CD45 RID: 52549 RVA: 0x00BF2FE8 File Offset: 0x00BF11E8
		public bool CnvPerSignalingRevertTGWACNID_A40150_Editable
		{
			get
			{
				short num = (short)374865920;
				short num2 = num;
				num = (short)764858501;
				short num3 = num;
				num = (short)239587461;
				switch (num3 == num)
				{
				}
				num = (short)1926168577;
				if (num != 0)
				{
				}
				num = (short)1335492608;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.Editable;
			}
			set
			{
				short num = (short)586678272;
				short num2 = num;
				num = (short)1729143430;
				short num3 = num;
				num = (short)877503110;
				switch (num3 == num)
				{
				}
				num = (short)451739649;
				if (num != 0)
				{
				}
				num = (short)857604096;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.Editable = value;
			}
		}

		// Token: 0x1700673E RID: 26430
		// (get) Token: 0x0600CD46 RID: 52550 RVA: 0x00BF30A0 File Offset: 0x00BF12A0
		internal string CnvPerSignalingRevertTGWACNID_A40150_UILabel
		{
			get
			{
				short num = (short)949092352;
				short num2 = num;
				num = (short)1579336478;
				short num3 = num;
				num = (short)1125696286;
				switch (num3 == num)
				{
				}
				num = (short)1181417473;
				if (num != 0)
				{
				}
				num = (short)1860960256;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.UIName;
			}
		}

		// Token: 0x1700673F RID: 26431
		// (get) Token: 0x0600CD47 RID: 52551 RVA: 0x00BF3154 File Offset: 0x00BF1354
		// (set) Token: 0x0600CD48 RID: 52552 RVA: 0x00BF3208 File Offset: 0x00BF1408
		internal bool CnvPerSignalingRevertTGWACNID_A40150_HiddenStatic
		{
			get
			{
				short num = (short)13369344;
				short num2 = num;
				num = (short)329554583;
				short num3 = num;
				num = (short)1840290455;
				switch (num3 == num)
				{
				}
				num = (short)2116878336;
				if (num != 0)
				{
				}
				num = (short)789184513;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.HiddenStatic;
			}
			set
			{
				short num = (short)1190133760;
				short num2 = num;
				num = (short)82509825;
				if (num != 0)
				{
				}
				num = (short)1038210703;
				short num3 = num;
				num = (short)99538575;
				switch (num3 == num)
				{
				}
				num = (short)854982656;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.HiddenStatic = value;
			}
		}

		// Token: 0x17006740 RID: 26432
		// (get) Token: 0x0600CD49 RID: 52553 RVA: 0x00BF32BC File Offset: 0x00BF14BC
		// (set) Token: 0x0600CD4A RID: 52554 RVA: 0x00BF3374 File Offset: 0x00BF1574
		internal bool CnvPerSignalingRevertTGWACNID_A40150_HiddenDynamic
		{
			get
			{
				short num = (short)375586816;
				short num2 = num;
				num = (short)922550273;
				if (num != 0)
				{
				}
				num = (short)1759199402;
				short num3 = num;
				num = (short)1562788010;
				switch (num3 == num)
				{
				}
				num = (short)210305024;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150.HiddenDynamic;
			}
			set
			{
				short num = (short)1794375680;
				short num2 = num;
				num = (short)1920401409;
				if (num != 0)
				{
				}
				num = (short)506540668;
				short num3 = num;
				num = (short)1581593212;
				switch (num3 == num)
				{
				}
				num = (short)192479232;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGWACNID_A40150.HiddenDynamic = value;
			}
		}

		// Token: 0x17006741 RID: 26433
		// (get) Token: 0x0600CD4B RID: 52555 RVA: 0x00BF342C File Offset: 0x00BF162C
		public bool CnvPerSignalingRevertTGWACNID_A40150_HasDiffs
		{
			get
			{
				short num = (short)1775370240;
				short num2 = num;
				num = (short)589633588;
				short num3 = num;
				num = (short)2019432500;
				switch (num3 == num)
				{
				}
				num = (short)1064763393;
				if (num != 0)
				{
				}
				num = (short)1205272576;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGWACNID_A40150._HasDiffs;
			}
		}

		// Token: 0x17006742 RID: 26434
		// (get) Token: 0x0600CD4C RID: 52556 RVA: 0x00BF34E4 File Offset: 0x00BF16E4
		// (set) Token: 0x0600CD4D RID: 52557 RVA: 0x00BF3598 File Offset: 0x00BF1798
		public int CnvPerSignalingRevertTGSYSID_A40151Value
		{
			get
			{
				short num = (short)777650176;
				short num2 = num;
				num = (short)1638448326;
				short num3 = num;
				num = (short)91733190;
				switch (num3 == num)
				{
				}
				num = (short)968884224;
				if (num != 0)
				{
				}
				num = (short)323420161;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.Value;
			}
			set
			{
				short num = (short)1231749120;
				short num2 = num;
				num = (short)1611586881;
				short num3 = num;
				num = (short)1624104257;
				switch (num3 == num)
				{
				}
				num = (short)1073938433;
				if (num != 0)
				{
				}
				num = (short)1412431872;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.Value = value;
			}
		}

		// Token: 0x17006743 RID: 26435
		// (get) Token: 0x0600CD4E RID: 52558 RVA: 0x00BF364C File Offset: 0x00BF184C
		public global::AcpBusinessLayer.AcpCustomRangeField CnvPerSignalingRevertTGSYSID_A40151
		{
			get
			{
				short num = (short)381353984;
				short num2 = num;
				num = (short)522266790;
				short num3 = num;
				num = (short)122431654;
				switch (num3 == num)
				{
				}
				num = (short)838336513;
				if (num != 0)
				{
				}
				num = (short)1853358080;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151;
			}
		}

		// Token: 0x17006744 RID: 26436
		// (get) Token: 0x0600CD4F RID: 52559 RVA: 0x00BF36F8 File Offset: 0x00BF18F8
		// (set) Token: 0x0600CD50 RID: 52560 RVA: 0x00BF37B0 File Offset: 0x00BF19B0
		public string CnvPerSignalingRevertTGSYSID_A40151_UIValue
		{
			get
			{
				short num = (short)1784610816;
				short num2 = num;
				num = (short)1824456705;
				if (num != 0)
				{
				}
				num = (short)886426593;
				short num3 = num;
				num = (short)724749281;
				switch (num3 == num)
				{
				}
				num = (short)540016640;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.UIValue;
			}
			set
			{
				short num = (short)1517027328;
				short num2 = num;
				num = (short)637602091;
				short num3 = num;
				num = (short)816843051;
				switch (num3 == num)
				{
				}
				num = (short)1993211904;
				if (num != 0)
				{
				}
				num = (short)890306561;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.UIValue = value;
			}
		}

		// Token: 0x17006745 RID: 26437
		// (get) Token: 0x0600CD51 RID: 52561 RVA: 0x00BF3868 File Offset: 0x00BF1A68
		// (set) Token: 0x0600CD52 RID: 52562 RVA: 0x00BF391C File Offset: 0x00BF1B1C
		public string CnvPerSignalingRevertTGSYSID_A40151_HexUIValue
		{
			get
			{
				short num = (short)890568704;
				short num2 = num;
				num = (short)1522292607;
				short num3 = num;
				num = (short)1779259263;
				switch (num3 == num)
				{
				}
				num = (short)1423572993;
				if (num != 0)
				{
				}
				num = (short)994639872;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.HexUIValue;
			}
			set
			{
				short num = (short)1238564864;
				short num2 = num;
				num = (short)188103584;
				short num3 = num;
				num = (short)1609710496;
				switch (num3 == num)
				{
				}
				num = (short)1938554881;
				if (num != 0)
				{
				}
				num = (short)66584576;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.HexUIValue = value;
			}
		}

		// Token: 0x17006746 RID: 26438
		// (get) Token: 0x0600CD53 RID: 52563 RVA: 0x00BF39D0 File Offset: 0x00BF1BD0
		// (set) Token: 0x0600CD54 RID: 52564 RVA: 0x00BF3A88 File Offset: 0x00BF1C88
		internal int CnvPerSignalingRevertTGSYSID_A40151Min
		{
			get
			{
				short num = (short)447545344;
				short num2 = num;
				num = (short)282984449;
				if (num != 0)
				{
				}
				num = (short)2044595080;
				short num3 = num;
				num = (short)2100235144;
				switch (num3 == num)
				{
				}
				num = (short)623312896;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.Min;
			}
			set
			{
				short num = (short)1330970624;
				short num2 = num;
				num = (short)1665188482;
				short num3 = num;
				num = (short)455983746;
				switch (num3 == num)
				{
				}
				num = (short)1905262593;
				if (num != 0)
				{
				}
				num = (short)1675952128;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.Min = value;
			}
		}

		// Token: 0x17006747 RID: 26439
		// (get) Token: 0x0600CD55 RID: 52565 RVA: 0x00BF3B3C File Offset: 0x00BF1D3C
		// (set) Token: 0x0600CD56 RID: 52566 RVA: 0x00BF3BF0 File Offset: 0x00BF1DF0
		internal int CnvPerSignalingRevertTGSYSID_A40151Max
		{
			get
			{
				short num = (short)628359168;
				short num2 = num;
				num = (short)1329855071;
				short num3 = num;
				num = (short)1384315487;
				switch (num3 == num)
				{
				}
				num = (short)593952769;
				if (num != 0)
				{
				}
				num = (short)1540816896;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.Max;
			}
			set
			{
				short num = (short)1657929728;
				short num2 = num;
				num = (short)1986509023;
				short num3 = num;
				num = (short)840677599;
				switch (num3 == num)
				{
				}
				num = (short)1016528897;
				if (num != 0)
				{
				}
				num = (short)1782513664;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.Max = value;
			}
		}

		// Token: 0x17006748 RID: 26440
		// (get) Token: 0x0600CD57 RID: 52567 RVA: 0x00BF3CA8 File Offset: 0x00BF1EA8
		// (set) Token: 0x0600CD58 RID: 52568 RVA: 0x00BF3D5C File Offset: 0x00BF1F5C
		internal int CnvPerSignalingRevertTGSYSID_A40151Step
		{
			get
			{
				short num = (short)1486553088;
				short num2 = num;
				num = (short)420324923;
				short num3 = num;
				num = (short)1787405883;
				switch (num3 == num)
				{
				}
				num = (short)403832832;
				if (num != 0)
				{
				}
				num = (short)1307049985;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.StepSize;
			}
			set
			{
				short num = (short)484966400;
				short num2 = num;
				num = (short)171171480;
				short num3 = num;
				num = (short)583917208;
				switch (num3 == num)
				{
				}
				num = (short)1308819457;
				if (num != 0)
				{
				}
				num = (short)2052653056;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.StepSize = value;
			}
		}

		// Token: 0x17006749 RID: 26441
		// (get) Token: 0x0600CD59 RID: 52569 RVA: 0x00BF3E10 File Offset: 0x00BF2010
		// (set) Token: 0x0600CD5A RID: 52570 RVA: 0x00BF3EC8 File Offset: 0x00BF20C8
		public bool CnvPerSignalingRevertTGSYSID_A40151_Applicable
		{
			get
			{
				short num = (short)1634205696;
				short num2 = num;
				num = (short)1929399713;
				short num3 = num;
				num = (short)227495329;
				switch (num3 == num)
				{
				}
				num = (short)1009975296;
				if (num != 0)
				{
				}
				num = (short)1130823681;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.Applicable;
			}
			set
			{
				short num = (short)775094272;
				short num2 = num;
				num = (short)427146043;
				short num3 = num;
				num = (short)2028059451;
				switch (num3 == num)
				{
				}
				num = (short)1247412225;
				if (num != 0)
				{
				}
				num = (short)927858688;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.Applicable = value;
			}
		}

		// Token: 0x1700674A RID: 26442
		// (get) Token: 0x0600CD5B RID: 52571 RVA: 0x00BF3F7C File Offset: 0x00BF217C
		// (set) Token: 0x0600CD5C RID: 52572 RVA: 0x00BF4034 File Offset: 0x00BF2234
		public bool CnvPerSignalingRevertTGSYSID_A40151_Valid
		{
			get
			{
				short num = (short)1251475456;
				short num2 = num;
				num = (short)758171216;
				short num3 = num;
				num = (short)2118305360;
				switch (num3 == num)
				{
				}
				num = (short)385941505;
				if (num != 0)
				{
				}
				num = (short)1168310272;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.Valid;
			}
			set
			{
				short num = (short)1041694720;
				short num2 = num;
				num = (short)482281201;
				short num3 = num;
				num = (short)181208817;
				switch (num3 == num)
				{
				}
				num = (short)1057292289;
				if (num != 0)
				{
				}
				num = (short)1011613696;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.Valid = value;
			}
		}

		// Token: 0x1700674B RID: 26443
		// (get) Token: 0x0600CD5D RID: 52573 RVA: 0x00BF40EC File Offset: 0x00BF22EC
		// (set) Token: 0x0600CD5E RID: 52574 RVA: 0x00BF41A0 File Offset: 0x00BF23A0
		public bool CnvPerSignalingRevertTGSYSID_A40151_Visible
		{
			get
			{
				short num = (short)2003173376;
				short num2 = num;
				num = (short)298282120;
				short num3 = num;
				num = (short)1924951176;
				switch (num3 == num)
				{
				}
				num = (short)646905856;
				if (num != 0)
				{
				}
				num = (short)872480769;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.Visible;
			}
			set
			{
				short num = (short)926613504;
				short num2 = num;
				num = (short)1416036353;
				if (num != 0)
				{
				}
				num = (short)689475495;
				short num3 = num;
				num = (short)119771047;
				switch (num3 == num)
				{
				}
				num = (short)1478557696;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.Visible = value;
			}
		}

		// Token: 0x1700674C RID: 26444
		// (get) Token: 0x0600CD5F RID: 52575 RVA: 0x00BF4254 File Offset: 0x00BF2454
		// (set) Token: 0x0600CD60 RID: 52576 RVA: 0x00BF4310 File Offset: 0x00BF2510
		public bool CnvPerSignalingRevertTGSYSID_A40151_Editable
		{
			get
			{
				short num = (short)1356791808;
				short num2 = num;
				num = (short)1302214908;
				short num3 = num;
				num = (short)538523900;
				switch (num3 == num)
				{
				}
				num = (short)472842240;
				if (num != 0)
				{
				}
				num = (short)147062785;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.Editable;
			}
			set
			{
				short num = (short)886702080;
				short num2 = num;
				num = (short)273960456;
				short num3 = num;
				num = (short)1204964872;
				switch (num3 == num)
				{
				}
				num = (short)750452736;
				if (num != 0)
				{
				}
				num = (short)998440961;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.Editable = value;
			}
		}

		// Token: 0x1700674D RID: 26445
		// (get) Token: 0x0600CD61 RID: 52577 RVA: 0x00BF43C4 File Offset: 0x00BF25C4
		internal string CnvPerSignalingRevertTGSYSID_A40151_UILabel
		{
			get
			{
				short num = (short)1322450944;
				short num2 = num;
				num = (short)139555371;
				short num3 = num;
				num = (short)591884843;
				switch (num3 == num)
				{
				}
				num = (short)1961820161;
				if (num != 0)
				{
				}
				num = (short)1201864704;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.UIName;
			}
		}

		// Token: 0x1700674E RID: 26446
		// (get) Token: 0x0600CD62 RID: 52578 RVA: 0x00BF4478 File Offset: 0x00BF2678
		// (set) Token: 0x0600CD63 RID: 52579 RVA: 0x00BF452C File Offset: 0x00BF272C
		internal bool CnvPerSignalingRevertTGSYSID_A40151_HiddenStatic
		{
			get
			{
				short num = (short)1800863744;
				short num2 = num;
				num = (short)1504102771;
				short num3 = num;
				num = (short)648333683;
				switch (num3 == num)
				{
				}
				num = (short)1831010304;
				if (num != 0)
				{
				}
				num = (short)1448869889;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.HiddenStatic;
			}
			set
			{
				short num = (short)205520896;
				short num2 = num;
				num = (short)1978297998;
				short num3 = num;
				num = (short)1837264526;
				switch (num3 == num)
				{
				}
				num = (short)264110080;
				if (num != 0)
				{
				}
				num = (short)1412956161;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.HiddenStatic = value;
			}
		}

		// Token: 0x1700674F RID: 26447
		// (get) Token: 0x0600CD64 RID: 52580 RVA: 0x00BF45E4 File Offset: 0x00BF27E4
		// (set) Token: 0x0600CD65 RID: 52581 RVA: 0x00BF4698 File Offset: 0x00BF2898
		internal bool CnvPerSignalingRevertTGSYSID_A40151_HiddenDynamic
		{
			get
			{
				short num = (short)1948123136;
				short num2 = num;
				num = (short)335332669;
				short num3 = num;
				num = (short)445826365;
				switch (num3 == num)
				{
				}
				num = (short)1400897536;
				if (num != 0)
				{
				}
				num = (short)225181697;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151.HiddenDynamic;
			}
			set
			{
				short num = (short)6750208;
				short num2 = num;
				num = (short)486539265;
				if (num != 0)
				{
				}
				num = (short)1490507032;
				short num3 = num;
				num = (short)1185502488;
				switch (num3 == num)
				{
				}
				num = (short)803274752;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSYSID_A40151.HiddenDynamic = value;
			}
		}

		// Token: 0x17006750 RID: 26448
		// (get) Token: 0x0600CD66 RID: 52582 RVA: 0x00BF474C File Offset: 0x00BF294C
		public bool CnvPerSignalingRevertTGSYSID_A40151_HasDiffs
		{
			get
			{
				short num = (short)753401856;
				short num2 = num;
				num = (short)151404631;
				short num3 = num;
				num = (short)1957773399;
				switch (num3 == num)
				{
				}
				num = (short)1792671744;
				if (num != 0)
				{
				}
				num = (short)1581776897;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSYSID_A40151._HasDiffs;
			}
		}

		// Token: 0x17006751 RID: 26449
		// (get) Token: 0x0600CD67 RID: 52583 RVA: 0x00BF4800 File Offset: 0x00BF2A00
		// (set) Token: 0x0600CD68 RID: 52584 RVA: 0x00BF48B4 File Offset: 0x00BF2AB4
		public int CnvPerSignalingRevertTG_A40152Value
		{
			get
			{
				short num = (short)941228032;
				short num2 = num;
				num = (short)1522803824;
				short num3 = num;
				num = (short)669459568;
				switch (num3 == num)
				{
				}
				num = (short)983040;
				if (num != 0)
				{
				}
				num = (short)710475777;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.Value;
			}
			set
			{
				short num = (short)636420096;
				short num2 = num;
				num = (short)710464353;
				short num3 = num;
				num = (short)398775137;
				switch (num3 == num)
				{
				}
				num = (short)839516160;
				if (num != 0)
				{
				}
				num = (short)83558401;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.Value = value;
			}
		}

		// Token: 0x17006752 RID: 26450
		// (get) Token: 0x0600CD69 RID: 52585 RVA: 0x00BF496C File Offset: 0x00BF2B6C
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvPerSignalingRevertTG_A40152
		{
			get
			{
				short num = (short)378208256;
				short num2 = num;
				num = (short)2145651493;
				short num3 = num;
				num = (short)706546469;
				switch (num3 == num)
				{
				}
				num = (short)474939393;
				if (num != 0)
				{
				}
				num = (short)1459945472;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152;
			}
		}

		// Token: 0x17006753 RID: 26451
		// (get) Token: 0x0600CD6A RID: 52586 RVA: 0x00BF4A1C File Offset: 0x00BF2C1C
		// (set) Token: 0x0600CD6B RID: 52587 RVA: 0x00BF4AD0 File Offset: 0x00BF2CD0
		public string CnvPerSignalingRevertTG_A40152_UIValue
		{
			get
			{
				short num = (short)1374420992;
				short num2 = num;
				num = (short)1176047472;
				short num3 = num;
				num = (short)516099952;
				switch (num3 == num)
				{
				}
				num = (short)250150912;
				if (num != 0)
				{
				}
				num = (short)1328218113;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.UIValue;
			}
			set
			{
				short num = (short)1710424064;
				short num2 = num;
				num = (short)1193251096;
				short num3 = num;
				num = (short)454267160;
				switch (num3 == num)
				{
				}
				num = (short)1862533120;
				if (num != 0)
				{
				}
				num = (short)2089746433;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.UIValue = value;
			}
		}

		// Token: 0x17006754 RID: 26452
		// (get) Token: 0x0600CD6C RID: 52588 RVA: 0x00BF4B84 File Offset: 0x00BF2D84
		// (set) Token: 0x0600CD6D RID: 52589 RVA: 0x00BF4C38 File Offset: 0x00BF2E38
		public string CnvPerSignalingRevertTG_A40152_HexUIValue
		{
			get
			{
				short num = (short)1125056512;
				short num2 = num;
				num = (short)1153193131;
				short num3 = num;
				num = (short)729896107;
				switch (num3 == num)
				{
				}
				num = (short)1056440321;
				if (num != 0)
				{
				}
				num = (short)1887961088;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.HexUIValue;
			}
			set
			{
				short num = (short)1302855680;
				short num2 = num;
				num = (short)1557331969;
				if (num != 0)
				{
				}
				num = (short)20607391;
				short num3 = num;
				num = (short)2094297503;
				switch (num3 == num)
				{
				}
				num = (short)1556611072;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.HexUIValue = value;
			}
		}

		// Token: 0x17006755 RID: 26453
		// (get) Token: 0x0600CD6E RID: 52590 RVA: 0x00BF4CF0 File Offset: 0x00BF2EF0
		// (set) Token: 0x0600CD6F RID: 52591 RVA: 0x00BF4DA4 File Offset: 0x00BF2FA4
		internal int CnvPerSignalingRevertTG_A40152Min
		{
			get
			{
				short num = (short)207028224;
				short num2 = num;
				num = (short)1754266113;
				short num3 = num;
				num = (short)238352897;
				switch (num3 == num)
				{
				}
				num = (short)2124349441;
				if (num != 0)
				{
				}
				num = (short)1701314560;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.Min;
			}
			set
			{
				short num = (short)1276510208;
				short num2 = num;
				num = (short)1909095039;
				short num3 = num;
				num = (short)838302335;
				switch (num3 == num)
				{
				}
				num = (short)1220214785;
				if (num != 0)
				{
				}
				num = (short)1715339264;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.Min = value;
			}
		}

		// Token: 0x17006756 RID: 26454
		// (get) Token: 0x0600CD70 RID: 52592 RVA: 0x00BF4E5C File Offset: 0x00BF305C
		// (set) Token: 0x0600CD71 RID: 52593 RVA: 0x00BF4F10 File Offset: 0x00BF3110
		internal int CnvPerSignalingRevertTG_A40152Max
		{
			get
			{
				short num = (short)1148649472;
				short num2 = num;
				num = (short)832666680;
				short num3 = num;
				num = (short)1473150008;
				switch (num3 == num)
				{
				}
				num = (short)1646460929;
				if (num != 0)
				{
				}
				num = (short)929562624;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.Max;
			}
			set
			{
				short num = (short)601948160;
				short num2 = num;
				num = (short)1965420340;
				short num3 = num;
				num = (short)731639604;
				switch (num3 == num)
				{
				}
				num = (short)1121845249;
				if (num != 0)
				{
				}
				num = (short)1207697408;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.Max = value;
			}
		}

		// Token: 0x17006757 RID: 26455
		// (get) Token: 0x0600CD72 RID: 52594 RVA: 0x00BF4FC4 File Offset: 0x00BF31C4
		// (set) Token: 0x0600CD73 RID: 52595 RVA: 0x00BF5078 File Offset: 0x00BF3278
		internal int CnvPerSignalingRevertTG_A40152Step
		{
			get
			{
				short num = (short)1077673984;
				short num2 = num;
				num = (short)740445715;
				short num3 = num;
				num = (short)565202451;
				switch (num3 == num)
				{
				}
				num = (short)187498497;
				if (num != 0)
				{
				}
				num = (short)388825088;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.StepSize;
			}
			set
			{
				short num = (short)679804928;
				short num2 = num;
				num = (short)677052417;
				if (num != 0)
				{
				}
				num = (short)1256459552;
				short num3 = num;
				num = (short)637668640;
				switch (num3 == num)
				{
				}
				num = (short)1309081600;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.StepSize = value;
			}
		}

		// Token: 0x17006758 RID: 26456
		// (get) Token: 0x0600CD74 RID: 52596 RVA: 0x00BF5130 File Offset: 0x00BF3330
		// (set) Token: 0x0600CD75 RID: 52597 RVA: 0x00BF51E8 File Offset: 0x00BF33E8
		public bool CnvPerSignalingRevertTG_A40152_Applicable
		{
			get
			{
				short num = (short)2096889856;
				short num2 = num;
				num = (short)36199485;
				short num3 = num;
				num = (short)2008505405;
				switch (num3 == num)
				{
				}
				num = (short)1433862145;
				if (num != 0)
				{
				}
				num = (short)1981612032;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.Applicable;
			}
			set
			{
				short num = (short)1187643392;
				short num2 = num;
				num = (short)1684042363;
				short num3 = num;
				num = (short)1382773371;
				switch (num3 == num)
				{
				}
				num = (short)2082603009;
				if (num != 0)
				{
				}
				num = (short)468451328;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.Applicable = value;
			}
		}

		// Token: 0x17006759 RID: 26457
		// (get) Token: 0x0600CD76 RID: 52598 RVA: 0x00BF529C File Offset: 0x00BF349C
		// (set) Token: 0x0600CD77 RID: 52599 RVA: 0x00BF5354 File Offset: 0x00BF3554
		public bool CnvPerSignalingRevertTG_A40152_Valid
		{
			get
			{
				short num = (short)123600896;
				short num2 = num;
				num = (short)738818643;
				short num3 = num;
				num = (short)1653176915;
				switch (num3 == num)
				{
				}
				num = (short)243859457;
				if (num != 0)
				{
				}
				num = (short)1582825472;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.Valid;
			}
			set
			{
				short num = (short)643782555;
				short num2 = num;
				num = (short)257709979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2010644480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)818413568;
				if (num != 0)
				{
				}
				num = (short)1063911425;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.Valid = value;
			}
		}

		// Token: 0x1700675A RID: 26458
		// (get) Token: 0x0600CD78 RID: 52600 RVA: 0x00BF5408 File Offset: 0x00BF3608
		// (set) Token: 0x0600CD79 RID: 52601 RVA: 0x00BF54BC File Offset: 0x00BF36BC
		public bool CnvPerSignalingRevertTG_A40152_Visible
		{
			get
			{
				short num = (short)1822359553;
				if (num != 0)
				{
				}
				num = (short)1553334272;
				short num2 = num;
				num = (short)711061296;
				short num3 = num;
				num = (short)899739440;
				switch (num3 == num)
				{
				}
				num = (short)793903104;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.Visible;
			}
			set
			{
				short num = (short)2100169508;
				short num2 = num;
				num = (short)178916132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1692991488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1047855105;
				if (num != 0)
				{
				}
				num = (short)490864640;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.Visible = value;
			}
		}

		// Token: 0x1700675B RID: 26459
		// (get) Token: 0x0600CD7A RID: 52602 RVA: 0x00BF5570 File Offset: 0x00BF3770
		// (set) Token: 0x0600CD7B RID: 52603 RVA: 0x00BF5624 File Offset: 0x00BF3824
		public bool CnvPerSignalingRevertTG_A40152_Editable
		{
			get
			{
				short num = (short)1282935164;
				short num2 = num;
				num = (short)844106108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)141688832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)539361281;
				if (num != 0)
				{
				}
				num = (short)890044416;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.Editable;
			}
			set
			{
				short num = (short)344097508;
				short num2 = num;
				num = (short)59343588;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1440415744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1221984256;
				if (num != 0)
				{
				}
				num = (short)2029256705;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.Editable = value;
			}
		}

		// Token: 0x1700675C RID: 26460
		// (get) Token: 0x0600CD7C RID: 52604 RVA: 0x00BF56D8 File Offset: 0x00BF38D8
		internal string CnvPerSignalingRevertTG_A40152_UILabel
		{
			get
			{
				short num = (short)542697291;
				short num2 = num;
				num = (short)642508619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1764032512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)577634304;
				if (num != 0)
				{
				}
				num = (short)1879572481;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.UIName;
			}
		}

		// Token: 0x1700675D RID: 26461
		// (get) Token: 0x0600CD7D RID: 52605 RVA: 0x00BF578C File Offset: 0x00BF398C
		// (set) Token: 0x0600CD7E RID: 52606 RVA: 0x00BF5844 File Offset: 0x00BF3A44
		internal bool CnvPerSignalingRevertTG_A40152_HiddenStatic
		{
			get
			{
				short num = (short)845348865;
				if (num != 0)
				{
				}
				num = (short)415170560;
				short num2 = num;
				num = (short)781188302;
				short num3 = num;
				num = (short)219348174;
				switch (num3 == num)
				{
				}
				num = (short)1239416832;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.HiddenStatic;
			}
			set
			{
				short num = (short)1949143973;
				short num2 = num;
				num = (short)1445565349;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1158545408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379256833;
				if (num != 0)
				{
				}
				num = (short)1361182720;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.HiddenStatic = value;
			}
		}

		// Token: 0x1700675E RID: 26462
		// (get) Token: 0x0600CD7F RID: 52607 RVA: 0x00BF58F8 File Offset: 0x00BF3AF8
		// (set) Token: 0x0600CD80 RID: 52608 RVA: 0x00BF59AC File Offset: 0x00BF3BAC
		internal bool CnvPerSignalingRevertTG_A40152_HiddenDynamic
		{
			get
			{
				short num = (short)1066625543;
				short num2 = num;
				num = (short)1672309255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1721565184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)149487617;
				if (num != 0)
				{
				}
				num = (short)676134912;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152.HiddenDynamic;
			}
			set
			{
				short num = (short)1942552577;
				if (num != 0)
				{
				}
				num = (short)1986265088;
				short num2 = num;
				num = (short)1833152771;
				short num3 = num;
				num = (short)1531621635;
				switch (num3 == num)
				{
				}
				num = (short)385810432;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTG_A40152.HiddenDynamic = value;
			}
		}

		// Token: 0x1700675F RID: 26463
		// (get) Token: 0x0600CD81 RID: 52609 RVA: 0x00BF5A64 File Offset: 0x00BF3C64
		public bool CnvPerSignalingRevertTG_A40152_HasDiffs
		{
			get
			{
				short num = (short)2036529535;
				short num2 = num;
				num = (short)1915419007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2081161216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1695612929;
				if (num != 0)
				{
				}
				num = (short)1062600704;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTG_A40152._HasDiffs;
			}
		}

		// Token: 0x17006760 RID: 26464
		// (get) Token: 0x0600CD82 RID: 52610 RVA: 0x00BF5B1C File Offset: 0x00BF3D1C
		// (set) Token: 0x0600CD83 RID: 52611 RVA: 0x00BF5BD0 File Offset: 0x00BF3DD0
		public int CnvPerSignalingRevertTGSecClearStrap_A40153Value
		{
			get
			{
				short num = (short)843565611;
				short num2 = num;
				num = (short)1921042987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2049507328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2099249153;
				if (num != 0)
				{
				}
				num = (short)112132096;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153.Value;
			}
			set
			{
				short num = (short)361908890;
				short num2 = num;
				num = (short)1044728474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)963510272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2136276993;
				if (num != 0)
				{
				}
				num = (short)1987575808;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSecClearStrap_A40153.Value = value;
			}
		}

		// Token: 0x17006761 RID: 26465
		// (get) Token: 0x0600CD84 RID: 52612 RVA: 0x00BF5C84 File Offset: 0x00BF3E84
		// (set) Token: 0x0600CD85 RID: 52613 RVA: 0x00BF5D38 File Offset: 0x00BF3F38
		public string CnvPerSignalingRevertTGSecClearStrap_A40153_UIValue
		{
			get
			{
				short num = (short)493556686;
				short num2 = num;
				num = (short)1002968014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945422336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1350500352;
				if (num != 0)
				{
				}
				num = (short)631177217;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153.UIValue;
			}
			set
			{
				short num = (short)1954789912;
				short num2 = num;
				num = (short)1162525208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1255407616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1477181441;
				if (num != 0)
				{
				}
				num = (short)1170014208;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSecClearStrap_A40153.UIValue = value;
			}
		}

		// Token: 0x17006762 RID: 26466
		// (get) Token: 0x0600CD86 RID: 52614 RVA: 0x00BF5DEC File Offset: 0x00BF3FEC
		public global::AcpBusinessLayer.AcpListField CnvPerSignalingRevertTGSecClearStrap_A40153
		{
			get
			{
				short num = (short)2083454977;
				if (num != 0)
				{
				}
				num = (short)1486225408;
				short num2 = num;
				num = (short)794035876;
				short num3 = num;
				num = (short)424740516;
				switch (num3 == num)
				{
				}
				num = (short)1538719744;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153;
			}
		}

		// Token: 0x17006763 RID: 26467
		// (get) Token: 0x0600CD87 RID: 52615 RVA: 0x00BF5E98 File Offset: 0x00BF4098
		// (set) Token: 0x0600CD88 RID: 52616 RVA: 0x00BF5F4C File Offset: 0x00BF414C
		public bool CnvPerSignalingRevertTGSecClearStrap_A40153_Applicable
		{
			get
			{
				short num = (short)1542108178;
				short num2 = num;
				num = (short)833467410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2026635264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)948109313;
				if (num != 0)
				{
				}
				num = (short)846594048;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153.Applicable;
			}
			set
			{
				short num = (short)1051662120;
				short num2 = num;
				num = (short)1007687464;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2049507328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)285474816;
				if (num != 0)
				{
				}
				num = (short)400949249;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSecClearStrap_A40153.Applicable = value;
			}
		}

		// Token: 0x17006764 RID: 26468
		// (get) Token: 0x0600CD89 RID: 52617 RVA: 0x00BF6004 File Offset: 0x00BF4204
		// (set) Token: 0x0600CD8A RID: 52618 RVA: 0x00BF60BC File Offset: 0x00BF42BC
		public bool CnvPerSignalingRevertTGSecClearStrap_A40153_Valid
		{
			get
			{
				short num = (short)1341986608;
				short num2 = num;
				num = (short)285284144;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2086535168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)24969216;
				if (num != 0)
				{
				}
				num = (short)2145386497;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153.Valid;
			}
			set
			{
				short num = (short)1912748071;
				short num2 = num;
				num = (short)1776498727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)844955648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1339621377;
				if (num != 0)
				{
				}
				num = (short)25231360;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSecClearStrap_A40153.Valid = value;
			}
		}

		// Token: 0x17006765 RID: 26469
		// (get) Token: 0x0600CD8B RID: 52619 RVA: 0x00BF6174 File Offset: 0x00BF4374
		// (set) Token: 0x0600CD8C RID: 52620 RVA: 0x00BF6228 File Offset: 0x00BF4428
		public bool CnvPerSignalingRevertTGSecClearStrap_A40153_Visible
		{
			get
			{
				short num = (short)242333533;
				short num2 = num;
				num = (short)847886173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)294518784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1139081217;
				if (num != 0)
				{
				}
				num = (short)305266688;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153.Visible;
			}
			set
			{
				short num = (short)675212014;
				short num2 = num;
				num = (short)331737838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1601699840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)522059776;
				if (num != 0)
				{
				}
				num = (short)1955069953;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSecClearStrap_A40153.Visible = value;
			}
		}

		// Token: 0x17006766 RID: 26470
		// (get) Token: 0x0600CD8D RID: 52621 RVA: 0x00BF62E0 File Offset: 0x00BF44E0
		// (set) Token: 0x0600CD8E RID: 52622 RVA: 0x00BF6398 File Offset: 0x00BF4598
		public bool CnvPerSignalingRevertTGSecClearStrap_A40153_Editable
		{
			get
			{
				short num = (short)730605510;
				short num2 = num;
				num = (short)862726086;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1021771776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)882573312;
				if (num != 0)
				{
				}
				num = (short)328400897;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153.Editable;
			}
			set
			{
				short num = (short)1466126735;
				short num2 = num;
				num = (short)1686589839;
				switch (num2 == num)
				{
				default:
				{
					num = (short)136314880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166920193;
				if (num != 0)
				{
				}
				num = (short)1533345792;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSecClearStrap_A40153.Editable = value;
			}
		}

		// Token: 0x17006767 RID: 26471
		// (get) Token: 0x0600CD8F RID: 52623 RVA: 0x00BF6450 File Offset: 0x00BF4650
		internal string CnvPerSignalingRevertTGSecClearStrap_A40153_UILabel
		{
			get
			{
				short num = (short)401239288;
				short num2 = num;
				num = (short)1428122872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1685979136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)560726017;
				if (num != 0)
				{
				}
				num = (short)786432;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153.UIName;
			}
		}

		// Token: 0x17006768 RID: 26472
		// (get) Token: 0x0600CD90 RID: 52624 RVA: 0x00BF6508 File Offset: 0x00BF4708
		// (set) Token: 0x0600CD91 RID: 52625 RVA: 0x00BF65C0 File Offset: 0x00BF47C0
		internal bool CnvPerSignalingRevertTGSecClearStrap_A40153_HiddenStatic
		{
			get
			{
				short num = (short)1740329887;
				short num2 = num;
				num = (short)1541362591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)655818752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)344391681;
				if (num != 0)
				{
				}
				num = (short)61079552;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153.HiddenStatic;
			}
			set
			{
				short num = (short)1389035521;
				if (num != 0)
				{
				}
				num = (short)819724288;
				short num2 = num;
				num = (short)964116667;
				short num3 = num;
				num = (short)1949778107;
				switch (num3 == num)
				{
				}
				num = (short)1283391488;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSecClearStrap_A40153.HiddenStatic = value;
			}
		}

		// Token: 0x17006769 RID: 26473
		// (get) Token: 0x0600CD92 RID: 52626 RVA: 0x00BF6674 File Offset: 0x00BF4874
		// (set) Token: 0x0600CD93 RID: 52627 RVA: 0x00BF672C File Offset: 0x00BF492C
		internal bool CnvPerSignalingRevertTGSecClearStrap_A40153_HiddenDynamic
		{
			get
			{
				short num = (short)151734808;
				short num2 = num;
				num = (short)1742686744;
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
				num = (short)932118528;
				if (num != 0)
				{
				}
				num = (short)737476609;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153.HiddenDynamic;
			}
			set
			{
				short num = (short)1479088060;
				short num2 = num;
				num = (short)957355964;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1345847296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1979580416;
				if (num != 0)
				{
				}
				num = (short)536412161;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGSecClearStrap_A40153.HiddenDynamic = value;
			}
		}

		// Token: 0x1700676A RID: 26474
		// (get) Token: 0x0600CD94 RID: 52628 RVA: 0x00BF67E4 File Offset: 0x00BF49E4
		public bool CnvPerSignalingRevertTGSecClearStrap_A40153_HasDiffs
		{
			get
			{
				short num = (short)1200365172;
				short num2 = num;
				num = (short)1927749236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)157220864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1249247233;
				if (num != 0)
				{
				}
				num = (short)1616052224;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGSecClearStrap_A40153._HasDiffs;
			}
		}

		// Token: 0x1700676B RID: 26475
		// (get) Token: 0x0600CD95 RID: 52629 RVA: 0x00BF6898 File Offset: 0x00BF4A98
		// (set) Token: 0x0600CD96 RID: 52630 RVA: 0x00BF6950 File Offset: 0x00BF4B50
		public int CnvPerSignalingRevertTGKeySel_A40154Value
		{
			get
			{
				short num = (short)2063958662;
				short num2 = num;
				num = (short)1825276550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)506593280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1952251904;
				if (num != 0)
				{
				}
				num = (short)1991376897;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154.Value;
			}
			set
			{
				short num = (short)1822350526;
				short num2 = num;
				num = (short)1677647038;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1019805696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1235091457;
				if (num != 0)
				{
				}
				num = (short)112787456;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGKeySel_A40154.Value = value;
			}
		}

		// Token: 0x1700676C RID: 26476
		// (get) Token: 0x0600CD97 RID: 52631 RVA: 0x00BF6A08 File Offset: 0x00BF4C08
		// (set) Token: 0x0600CD98 RID: 52632 RVA: 0x00BF6ABC File Offset: 0x00BF4CBC
		public string CnvPerSignalingRevertTGKeySel_A40154_UIValue
		{
			get
			{
				short num = (short)1626594189;
				short num2 = num;
				num = (short)915659661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1198194688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1699610625;
				if (num != 0)
				{
				}
				num = (short)1756758016;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154.UIValue;
			}
			set
			{
				short num = (short)1345714135;
				short num2 = num;
				num = (short)964294615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)255197184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1942880257;
				if (num != 0)
				{
				}
				num = (short)1286340608;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGKeySel_A40154.UIValue = value;
			}
		}

		// Token: 0x1700676D RID: 26477
		// (get) Token: 0x0600CD99 RID: 52633 RVA: 0x00BF6B74 File Offset: 0x00BF4D74
		public global::AcpBusinessLayer.AcpRecRefField CnvPerSignalingRevertTGKeySel_A40154
		{
			get
			{
				short num = (short)2042232833;
				if (num != 0)
				{
				}
				num = (short)873529344;
				short num2 = num;
				num = (short)1962897879;
				short num3 = num;
				num = (short)1479111127;
				switch (num3 == num)
				{
				}
				num = (short)910622720;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154;
			}
		}

		// Token: 0x1700676E RID: 26478
		// (get) Token: 0x0600CD9A RID: 52634 RVA: 0x00BF6C24 File Offset: 0x00BF4E24
		// (set) Token: 0x0600CD9B RID: 52635 RVA: 0x00BF6CD8 File Offset: 0x00BF4ED8
		public bool CnvPerSignalingRevertTGKeySel_A40154_Applicable
		{
			get
			{
				short num = (short)394297181;
				short num2 = num;
				num = (short)919895901;
				switch (num2 == num)
				{
				default:
				{
					num = (short)976093184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)283443200;
				if (num != 0)
				{
				}
				num = (short)1848311809;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154.Applicable;
			}
			set
			{
				short num = (short)291093016;
				short num2 = num;
				num = (short)581614104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1168769024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1093009409;
				if (num != 0)
				{
				}
				num = (short)1690566656;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGKeySel_A40154.Applicable = value;
			}
		}

		// Token: 0x1700676F RID: 26479
		// (get) Token: 0x0600CD9C RID: 52636 RVA: 0x00BF6D8C File Offset: 0x00BF4F8C
		// (set) Token: 0x0600CD9D RID: 52637 RVA: 0x00BF6E40 File Offset: 0x00BF5040
		public bool CnvPerSignalingRevertTGKeySel_A40154_Valid
		{
			get
			{
				short num = (short)1895582620;
				short num2 = num;
				num = (short)151014300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1202061312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)113311745;
				if (num != 0)
				{
				}
				num = (short)1928593408;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154.Valid;
			}
			set
			{
				short num = (short)339459443;
				short num2 = num;
				num = (short)1707064691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)773914624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)290783232;
				if (num != 0)
				{
				}
				num = (short)1358626817;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGKeySel_A40154.Valid = value;
			}
		}

		// Token: 0x17006770 RID: 26480
		// (get) Token: 0x0600CD9E RID: 52638 RVA: 0x00BF6EF4 File Offset: 0x00BF50F4
		// (set) Token: 0x0600CD9F RID: 52639 RVA: 0x00BF6FAC File Offset: 0x00BF51AC
		public bool CnvPerSignalingRevertTGKeySel_A40154_Visible
		{
			get
			{
				short num = (short)326253860;
				short num2 = num;
				num = (short)705707300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)746848256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2056192000;
				if (num != 0)
				{
				}
				num = (short)255655937;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154.Visible;
			}
			set
			{
				short num = (short)316266130;
				short num2 = num;
				num = (short)965990034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660289024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)723320832;
				if (num != 0)
				{
				}
				num = (short)1183580161;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGKeySel_A40154.Visible = value;
			}
		}

		// Token: 0x17006771 RID: 26481
		// (get) Token: 0x0600CDA0 RID: 52640 RVA: 0x00BF7064 File Offset: 0x00BF5264
		// (set) Token: 0x0600CDA1 RID: 52641 RVA: 0x00BF7118 File Offset: 0x00BF5318
		public bool CnvPerSignalingRevertTGKeySel_A40154_Editable
		{
			get
			{
				short num = (short)1088583551;
				short num2 = num;
				num = (short)2134865791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1195114496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)203161601;
				if (num != 0)
				{
				}
				num = (short)71041024;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154.Editable;
			}
			set
			{
				short num = (short)60597609;
				short num2 = num;
				num = (short)1028892009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282066944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2081751041;
				if (num != 0)
				{
				}
				num = (short)671154176;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGKeySel_A40154.Editable = value;
			}
		}

		// Token: 0x17006772 RID: 26482
		// (get) Token: 0x0600CDA2 RID: 52642 RVA: 0x00BF71CC File Offset: 0x00BF53CC
		internal string CnvPerSignalingRevertTGKeySel_A40154_UILabel
		{
			get
			{
				short num = (short)954654741;
				short num2 = num;
				num = (short)335601685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1553596416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)844562433;
				if (num != 0)
				{
				}
				num = (short)1276706816;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154.UIName;
			}
		}

		// Token: 0x17006773 RID: 26483
		// (get) Token: 0x0600CDA3 RID: 52643 RVA: 0x00BF7280 File Offset: 0x00BF5480
		// (set) Token: 0x0600CDA4 RID: 52644 RVA: 0x00BF7334 File Offset: 0x00BF5534
		internal bool CnvPerSignalingRevertTGKeySel_A40154_HiddenStatic
		{
			get
			{
				short num = (short)392321835;
				short num2 = num;
				num = (short)132471595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1516109824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)430112769;
				if (num != 0)
				{
				}
				num = (short)404619264;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154.HiddenStatic;
			}
			set
			{
				short num = (short)588425075;
				short num2 = num;
				num = (short)1949869939;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1832845312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2071920640;
				if (num != 0)
				{
				}
				num = (short)869269505;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGKeySel_A40154.HiddenStatic = value;
			}
		}

		// Token: 0x17006774 RID: 26484
		// (get) Token: 0x0600CDA5 RID: 52645 RVA: 0x00BF73E8 File Offset: 0x00BF55E8
		// (set) Token: 0x0600CDA6 RID: 52646 RVA: 0x00BF749C File Offset: 0x00BF569C
		internal bool CnvPerSignalingRevertTGKeySel_A40154_HiddenDynamic
		{
			get
			{
				short num = (short)1911730022;
				short num2 = num;
				num = (short)1734192998;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1814102016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)17956864;
				if (num != 0)
				{
				}
				num = (short)2072969217;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154.HiddenDynamic;
			}
			set
			{
				short num = (short)987129521;
				short num2 = num;
				num = (short)1776838321;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1375535104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1385299968;
				if (num != 0)
				{
				}
				num = (short)147980289;
				if (num != 0)
				{
				}
				this.cnvPerSignalingRevertTGKeySel_A40154.HiddenDynamic = value;
			}
		}

		// Token: 0x17006775 RID: 26485
		// (get) Token: 0x0600CDA7 RID: 52647 RVA: 0x00BF7554 File Offset: 0x00BF5754
		public bool CnvPerSignalingRevertTGKeySel_A40154_HasDiffs
		{
			get
			{
				short num = (short)1481359904;
				short num2 = num;
				num = (short)1533592096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1694040064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)514850816;
				if (num != 0)
				{
				}
				num = (short)722468865;
				if (num != 0)
				{
				}
				return this.cnvPerSignalingRevertTGKeySel_A40154._HasDiffs;
			}
		}

		// Token: 0x17006776 RID: 26486
		// (get) Token: 0x0600CDA8 RID: 52648 RVA: 0x00BF7608 File Offset: 0x00BF5808
		// (set) Token: 0x0600CDA9 RID: 52649 RVA: 0x00BF76BC File Offset: 0x00BF58BC
		public int CnvPerFeaturesAstroAlertingToneTableValue
		{
			get
			{
				short num = (short)1263665153;
				if (num != 0)
				{
				}
				num = (short)646578176;
				short num2 = num;
				num = (short)887220368;
				short num3 = num;
				num = (short)1603856528;
				switch (num3 == num)
				{
				}
				num = (short)723845120;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable.Value;
			}
			set
			{
				short num = (short)368810496;
				short num2 = num;
				num = (short)782998016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1560805376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)458752000;
				if (num != 0)
				{
				}
				num = (short)175570945;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesAstroAlertingToneTable.Value = value;
			}
		}

		// Token: 0x17006777 RID: 26487
		// (get) Token: 0x0600CDAA RID: 52650 RVA: 0x00BF7770 File Offset: 0x00BF5970
		// (set) Token: 0x0600CDAB RID: 52651 RVA: 0x00BF7828 File Offset: 0x00BF5A28
		public string CnvPerFeaturesAstroAlertingToneTable_UIValue
		{
			get
			{
				short num = (short)166721015;
				short num2 = num;
				num = (short)922482167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1361248256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1495728129;
				if (num != 0)
				{
				}
				num = (short)1664876544;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable.UIValue;
			}
			set
			{
				short num = (short)228738317;
				short num2 = num;
				num = (short)1375487245;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1119879168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2080636929;
				if (num != 0)
				{
				}
				num = (short)910229504;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesAstroAlertingToneTable.UIValue = value;
			}
		}

		// Token: 0x17006778 RID: 26488
		// (get) Token: 0x0600CDAC RID: 52652 RVA: 0x00BF78E0 File Offset: 0x00BF5AE0
		public global::AcpBusinessLayer.AcpRecRefField CnvPerFeaturesAstroAlertingToneTable
		{
			get
			{
				short num = (short)935279188;
				short num2 = num;
				num = (short)1703623252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)131399680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)183697409;
				if (num != 0)
				{
				}
				num = (short)1428881408;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable;
			}
		}

		// Token: 0x17006779 RID: 26489
		// (get) Token: 0x0600CDAD RID: 52653 RVA: 0x00BF7990 File Offset: 0x00BF5B90
		// (set) Token: 0x0600CDAE RID: 52654 RVA: 0x00BF7A44 File Offset: 0x00BF5C44
		public bool CnvPerFeaturesAstroAlertingToneTable_Applicable
		{
			get
			{
				short num = (short)579977974;
				short num2 = num;
				num = (short)1343079158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)759693312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)915472385;
				if (num != 0)
				{
				}
				num = (short)1410990080;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable.Applicable;
			}
			set
			{
				short num = (short)747203756;
				short num2 = num;
				num = (short)65629356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)274464768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1227423744;
				if (num != 0)
				{
				}
				num = (short)702021633;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesAstroAlertingToneTable.Applicable = value;
			}
		}

		// Token: 0x1700677A RID: 26490
		// (get) Token: 0x0600CDAF RID: 52655 RVA: 0x00BF7AF8 File Offset: 0x00BF5CF8
		// (set) Token: 0x0600CDB0 RID: 52656 RVA: 0x00BF7BAC File Offset: 0x00BF5DAC
		public bool CnvPerFeaturesAstroAlertingToneTable_Valid
		{
			get
			{
				short num = (short)1609942889;
				short num2 = num;
				num = (short)1743898473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030305280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)704380929;
				if (num != 0)
				{
				}
				num = (short)94371840;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable.Valid;
			}
			set
			{
				short num = (short)262453652;
				short num2 = num;
				num = (short)567392660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1755709440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1642659840;
				if (num != 0)
				{
				}
				num = (short)1248329729;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesAstroAlertingToneTable.Valid = value;
			}
		}

		// Token: 0x1700677B RID: 26491
		// (get) Token: 0x0600CDB1 RID: 52657 RVA: 0x00BF7C60 File Offset: 0x00BF5E60
		// (set) Token: 0x0600CDB2 RID: 52658 RVA: 0x00BF7D14 File Offset: 0x00BF5F14
		public bool CnvPerFeaturesAstroAlertingToneTable_Visible
		{
			get
			{
				short num = (short)114753537;
				if (num != 0)
				{
				}
				num = (short)315817984;
				short num2 = num;
				num = (short)622042243;
				short num3 = num;
				num = (short)170368131;
				switch (num3 == num)
				{
				}
				num = (short)168624128;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable.Visible;
			}
			set
			{
				short num = (short)615198532;
				short num2 = num;
				num = (short)1108881220;
				switch (num2 == num)
				{
				default:
				{
					num = (short)787939328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)49217537;
				if (num != 0)
				{
				}
				num = (short)1415643136;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesAstroAlertingToneTable.Visible = value;
			}
		}

		// Token: 0x1700677C RID: 26492
		// (get) Token: 0x0600CDB3 RID: 52659 RVA: 0x00BF7DC8 File Offset: 0x00BF5FC8
		// (set) Token: 0x0600CDB4 RID: 52660 RVA: 0x00BF7E7C File Offset: 0x00BF607C
		public bool CnvPerFeaturesAstroAlertingToneTable_Editable
		{
			get
			{
				short num = (short)462595727;
				short num2 = num;
				num = (short)2035525263;
				switch (num2 == num)
				{
				default:
				{
					num = (short)528416768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008875009;
				if (num != 0)
				{
				}
				num = (short)332595200;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable.Editable;
			}
			set
			{
				short num = (short)436581046;
				short num2 = num;
				num = (short)1373024950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508035072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545863169;
				if (num != 0)
				{
				}
				num = (short)1724973056;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesAstroAlertingToneTable.Editable = value;
			}
		}

		// Token: 0x1700677D RID: 26493
		// (get) Token: 0x0600CDB5 RID: 52661 RVA: 0x00BF7F30 File Offset: 0x00BF6130
		internal string CnvPerFeaturesAstroAlertingToneTable_UILabel
		{
			get
			{
				short num = (short)118979561;
				short num2 = num;
				num = (short)1754561513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2049441792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1366884353;
				if (num != 0)
				{
				}
				num = (short)1120927744;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable.UIName;
			}
		}

		// Token: 0x1700677E RID: 26494
		// (get) Token: 0x0600CDB6 RID: 52662 RVA: 0x00BF7FE8 File Offset: 0x00BF61E8
		// (set) Token: 0x0600CDB7 RID: 52663 RVA: 0x00BF809C File Offset: 0x00BF629C
		internal bool CnvPerFeaturesAstroAlertingToneTable_HiddenStatic
		{
			get
			{
				short num = (short)849693586;
				short num2 = num;
				num = (short)467815314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1866792960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1348599809;
				if (num != 0)
				{
				}
				num = (short)962330624;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable.HiddenStatic;
			}
			set
			{
				short num = (short)213385217;
				if (num != 0)
				{
				}
				num = (short)755826688;
				short num2 = num;
				num = (short)705048188;
				short num3 = num;
				num = (short)425864828;
				switch (num3 == num)
				{
				}
				num = (short)1530527744;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesAstroAlertingToneTable.HiddenStatic = value;
			}
		}

		// Token: 0x1700677F RID: 26495
		// (get) Token: 0x0600CDB8 RID: 52664 RVA: 0x00BF8154 File Offset: 0x00BF6354
		// (set) Token: 0x0600CDB9 RID: 52665 RVA: 0x00BF820C File Offset: 0x00BF640C
		internal bool CnvPerFeaturesAstroAlertingToneTable_HiddenDynamic
		{
			get
			{
				short num = (short)599792832;
				short num2 = num;
				num = (short)767630528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1235288064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1638203392;
				if (num != 0)
				{
				}
				num = (short)697237505;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable.HiddenDynamic;
			}
			set
			{
				short num = (short)1808199326;
				short num2 = num;
				num = (short)1509289630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1096482816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1105133568;
				if (num != 0)
				{
				}
				num = (short)2146762753;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesAstroAlertingToneTable.HiddenDynamic = value;
			}
		}

		// Token: 0x17006780 RID: 26496
		// (get) Token: 0x0600CDBA RID: 52666 RVA: 0x00BF82C0 File Offset: 0x00BF64C0
		public bool CnvPerFeaturesAstroAlertingToneTable_HasDiffs
		{
			get
			{
				short num = (short)1937527491;
				short num2 = num;
				num = (short)550589123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)538247168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1765408768;
				if (num != 0)
				{
				}
				num = (short)1059258369;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesAstroAlertingToneTable._HasDiffs;
			}
		}

		// Token: 0x17006781 RID: 26497
		// (get) Token: 0x0600CDBB RID: 52667 RVA: 0x00BF8374 File Offset: 0x00BF6574
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1940693494;
				short num2 = num;
				num = (short)429826550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)842989568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)119603201;
				if (num != 0)
				{
				}
				num = (short)1259536384;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x17006782 RID: 26498
		// (get) Token: 0x0600CDBC RID: 52668 RVA: 0x00BF8430 File Offset: 0x00BF6630
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)118504122;
				short num2 = num;
				num = (short)2072787642;
				switch (num2 == num)
				{
				default:
				{
					num = (short)174260224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1821966336;
				if (num != 0)
				{
				}
				num = (short)1480392705;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x17006783 RID: 26499
		// (get) Token: 0x0600CDBD RID: 52669 RVA: 0x00BF84F0 File Offset: 0x00BF66F0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)416238731;
				short num2 = num;
				num = (short)1707560075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101070336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2095448065;
				if (num != 0)
				{
				}
				num = (short)822870016;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17006784 RID: 26500
		// (get) Token: 0x0600CDBE RID: 52670 RVA: 0x00BF85B0 File Offset: 0x00BF67B0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)427819009;
				if (num != 0)
				{
				}
				num = (short)920715264;
				short num2 = num;
				num = (short)1382574198;
				short num3 = num;
				num = (short)1786275958;
				switch (num3 == num)
				{
				}
				num = (short)1292697600;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x17006785 RID: 26501
		// (get) Token: 0x0600CDBF RID: 52671 RVA: 0x00BF8670 File Offset: 0x00BF6870
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem RefCnvSys
		{
			get
			{
				short num = (short)1608276404;
				short num2 = num;
				num = (short)1592809908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)43974656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1594949632;
				if (num != 0)
				{
				}
				num = (short)1294270465;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2053)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			}
		}

		// Token: 0x0600CDC0 RID: 52672 RVA: 0x00BF872C File Offset: 0x00BF692C
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
					num2 = (short)1505099777;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1550712835;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1913257984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)409600001;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1816002564;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_D4;
				}
				break;
			}
			IL_24:
			result = null;
			num2 = (short)1131534859;
			short num3 = num2;
			num2 = (short)1400822283;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D4:
				num2 = (short)1266548736;
				short num4 = num2;
				break;
			}
			default:
			{
				num2 = (short)179240960;
				if (num2 != 0)
				{
				}
				num2 = (short)1060306946;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x00BF88A4 File Offset: 0x00BF6AA4
		private void b()
		{
			short num = (short)463692180;
			short num2 = num;
			num = (short)2133287316;
			switch (num2 == num)
			{
			default:
			{
				num = (short)11665408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1782513665;
			if (num != 0)
			{
			}
			num = (short)1198784512;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x00BF8954 File Offset: 0x00BF6B54
		private void a()
		{
			short num = (short)771883020;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			global::AcpCommonLib.IAcpRecordset feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (num3 >= feature.Count)
					{
						num = (short)49807376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1790574596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, base.Parent.Permissions))
					{
						num = (short)994443267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)741277702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2053);
					num3 = 0;
					num = (short)228851723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, feature[num3].Permissions))
					{
						num = (short)139132947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3++;
					num = (short)172752916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)912654337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
					{
						num = (short)312147989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					num = (short)1477574665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)2089222158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (base.Parent.Parent.ContainerDoc != null)
					{
						num = (short)644284434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					num = (short)1924202509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_155;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 13:
					if (base.Parent.Parent.ContainerDoc.DocType != global::AcpCommonLib.DocumentType.Comparator)
					{
						num = (short)1107623941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 14:
					if (base.Parent.Parent != null)
					{
						num = (short)1599995911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 15:
					if (base.Parent.Parent.ContainerDoc.IsOpen)
					{
						num = (short)1163395082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 16:
					goto IL_1DC;
				case 17:
					if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
					{
						num = (short)18677762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 18:
					num = (short)1876885519;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1785200657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_155;
				case 21:
					goto IL_25F;
				}
				IL_7C:
				if (base.Parent != null)
				{
					num = (short)570687496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_155:
				num = (short)1039810525;
				short num4 = num;
				num = (short)1550729181;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7C;
				default:
					num = (short)969539584;
					if (num != 0)
					{
					}
					num = (short)543031296;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1DC:
			return;
			IL_25F:
			num = (short)621019136;
			short num5 = num;
			num = (short)1594753025;
			if (num != 0)
			{
			}
			this.CnvPerSignalingSystemNumber_A9243.UIValue = feature[num3].ReferenceKey;
		}

		// Token: 0x040064F0 RID: 25840
		private global::AcpBusinessLayer.AcpRecRefField cnvPerSignalingASTROSystem_A7498;

		// Token: 0x040064F1 RID: 25841
		private global::AcpBusinessLayer.AcpListField cnvPerSignalingDigitalModulatorType_A7857;

		// Token: 0x040064F2 RID: 25842
		private global::AcpBusinessLayer.AcpField<bool> cnvPerSignalingEmergencyPTTID_A7944;

		// Token: 0x040064F3 RID: 25843
		private global::AcpBusinessLayer.AcpField<bool> cnvPerSignalingLateEntryFastUnmute_A8423;

		// Token: 0x040064F4 RID: 25844
		private global::AcpBusinessLayer.AcpField<bool> cnvPerSignalingPTTID_A8770;

		// Token: 0x040064F5 RID: 25845
		private global::AcpBusinessLayer.AcpListField cnvPerSignalingRevertType_A8953;

		// Token: 0x040064F6 RID: 25846
		private global::AcpBusinessLayer.AcpListField cnvPerSignalingASTRORxUnmuteRule_A9042;

		// Token: 0x040064F7 RID: 25847
		private global::AcpBusinessLayer.AcpListField cnvPerSignalingSignalingType_A9129;

		// Token: 0x040064F8 RID: 25848
		private global::AcpBusinessLayer.AcpRecRefField cnvPerSignalingSystemNumber_A9243;

		// Token: 0x040064F9 RID: 25849
		private global::AcpBusinessLayer.AcpRecRefField cnvPerSignalingRevertZone_A13269;

		// Token: 0x040064FA RID: 25850
		private global::AcpBusinessLayer.AcpRecRefField cnvPerSignalingRevertChannel_A13267;

		// Token: 0x040064FB RID: 25851
		private global::AcpBusinessLayer.AcpCustomRangeField cnvPerSignalingRevertTGWACNID_A40150;

		// Token: 0x040064FC RID: 25852
		private global::AcpBusinessLayer.AcpCustomRangeField cnvPerSignalingRevertTGSYSID_A40151;

		// Token: 0x040064FD RID: 25853
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvPerSignalingRevertTG_A40152;

		// Token: 0x040064FE RID: 25854
		private global::AcpBusinessLayer.AcpListField cnvPerSignalingRevertTGSecClearStrap_A40153;

		// Token: 0x040064FF RID: 25855
		private global::AcpBusinessLayer.AcpRecRefField cnvPerSignalingRevertTGKeySel_A40154;

		// Token: 0x04006500 RID: 25856
		private global::AcpBusinessLayer.AcpRecRefField cnvPerFeaturesAstroAlertingToneTable;
	}
}
