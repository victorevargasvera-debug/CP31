using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000550 RID: 1360
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B5AD RID: 46509 RVA: 0x00A85058 File Offset: 0x00A83258
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B5AE RID: 46510 RVA: 0x00A85074 File Offset: 0x00A83274
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B5AF RID: 46511 RVA: 0x00A8508C File Offset: 0x00A8328C
		public override void Init()
		{
			int a_ = 5;
			short num = (short)313293917;
			short num2 = num;
			num = (short)875068509;
			switch (num2 == num)
			{
			}
			num = (short)1309147136;
			short num3 = num;
			num = (short)843317249;
			if (num != 0)
			{
			}
			num = (short)429457408;
			if (num != 0)
			{
			}
			this.cnvWideGeneralDirectFrequency_A7860 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鯋ꟍ듏럑鏓돕뛗뿙껛뿝賟ꛡ跣铥跧觩飫꣭苯韱藳菵鷷铹鿻蟽忿䌁㌃㸅㸇㨉", a_), global::CommonResources.AcgResources.ID_DIRECTFREQUENCYENABLE);
			this.cnvWideGeneralDirectFrequency_A7860.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvWideGeneralDirectFrequency_A7860.DataTransferOrder = 27;
			this.cnvWideGeneralHUBDefeatsPL_A8215 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鯋ꟍ듏럑鏓돕뛗뿙껛뿝賟ꫡ뇣ꓥ곧迩諫语釯蛱蟳꛵듷ꗹ뷻웽㋿㌁㄃", a_), global::CommonResources.AcgResources.ID_HUBDEFEATSPL);
			this.cnvWideGeneralHUBDefeatsPL_A8215.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideGeneralHUBDefeatsPL_A8215.DataTransferOrder = 4;
			this.cnvWideGeneralLatchEnableTime_A8421 = new global::AcpBusinessLayer.AcpCustomRangeField(4, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.UnpackAndpackRangeValueToLogicalIndexForLatchEnTime(), this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鯋ꟍ듏럑鏓돕뛗뿙껛뿝賟껡藣鋥诧苩ꧫ胭釯郱飳鏵곷鏹釻鯽忿䌁㰃㈅㨇㬉", a_), global::CommonResources.AcgResources.ID_LATCHENABLETIMESEC, 0, 12, 1, global::CommonResources.AcgResources.ID_DISABLED, null);
			this.cnvWideGeneralLatchEnableTime_A8421.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideGeneralLatchEnableTime_A8421.DataTransferOrder = 23;
			this.cnvWideGeneralLatchEnableTime_A8421.ShowHexValue = false;
			this.cnvWideGeneralLatchEnableTone_A8422 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鯋ꟍ듏럑鏓돕뛗뿙껛뿝賟껡藣鋥诧苩ꧫ胭釯郱飳鏵곷闹鋻鯽忿䌁㰃㈅㨇㠉", a_), global::CommonResources.AcgResources.ID_LATCHENABLETONE);
			this.cnvWideGeneralLatchEnableTone_A8422.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideGeneralLatchEnableTone_A8422.DataTransferOrder = 5;
			this.cnvWideGeneralMonitorType_A8544 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鯋ꟍ듏럑鏓돕뛗뿙껛뿝賟꿡诣裥臧黩菫鳭ꓯ诱蓳鏵ꟷ믹쓻쯽㓿㘁", a_), global::CommonResources.AcgResources.ID_MONITORTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.LOVs.CnvWideGeneralMonitorType_A8544LovStrs);
			this.cnvWideGeneralMonitorType_A8544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideGeneralMonitorType_A8544.DataTransferOrder = 6;
			this.cnvWideGeneralSquelchPerPersonality_A19313 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鯋ꟍ듏럑鏓돕뛗뿙껛뿝賟뇡闣鏥跧蛩迫蛭ꃯ韱蛳꛵鷷裹迻釽滿持栃漅簇猉匋伍ℏ⬑✓✕⬗", a_), global::CommonResources.AcgResources.ID_SQUELCHPERPERSONALITY);
			this.cnvWideGeneralSquelchPerPersonality_A19313.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideGeneralSquelchPerPersonality_A19313.DataTransferOrder = 9;
			this.cnvWideGeneralMplRecallMode_A41698 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鯋ꟍ듏럑鏓돕뛗뿙껛뿝賟꿡铣諥뫧迩迫迭鳯黱맳駵鳷鿹ꏻ뿽㓿㌁㈃㼅〇", a_), global::CommonResources.AcgResources.ID_MPLRECALLMODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.LOVs.CnvWideGeneralMplRecallMode_A41698LovStrs);
			this.cnvWideGeneralMplRecallMode_A41698.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideGeneralMplRecallMode_A41698.DataTransferOrder = 24;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臅귇꓉꧋볍뇏뻑", a_);
			base.Id = 10052;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600B5B0 RID: 46512 RVA: 0x00A85320 File Offset: 0x00A83520
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1924005909;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩ꓫ믭닯뛱釳郵鷷鯹裻跽僿丁嬃䜅〇㠉㴋㬍", a_)))
					{
						goto IL_3F5;
					}
					goto IL_583;
				case 1:
					goto IL_45E;
				case 2:
					this.cnvWideGeneralMplRecallMode_A41698 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩ꇫ黭鳯ꃱ釳闵駷雹郻돽濿昁愃夅䤇㸉㴋㠍⤏⨑", a_), global::CommonResources.AcgResources.ID_MPLRECALLMODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.LOVs.CnvWideGeneralMplRecallMode_A41698LovStrs);
					this.cnvWideGeneralMplRecallMode_A41698.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideGeneralMplRecallMode_A41698.DataTransferOrder = 24;
					num = (short)1891434519;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)987168775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.cnvWideGeneralLatchEnableTime_A8421 = new global::AcpBusinessLayer.AcpCustomRangeField(4, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.UnpackAndpackRangeValueToLogicalIndexForLatchEnTime(), this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩ꃫ迭蓯釱鳳돵雷鯹黻鋽旿嘁洃欅洇唉䴋㘍␏‑┓", a_), global::CommonResources.AcgResources.ID_LATCHENABLETIMESEC, global::CommonResources.AcgResources.ID_DISABLED, null);
					this.cnvWideGeneralLatchEnableTime_A8421.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideGeneralLatchEnableTime_A8421.DataTransferOrder = 23;
					this.cnvWideGeneralLatchEnableTime_A8421.ShowHexValue = false;
					num = (short)475463702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩꣫蟭苯韱音苵뻷裹駻追痿朁樃攅焇唉䴋㤍⠏␑␓", a_)))
					{
						num = (short)824770577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C5;
				case 6:
				{
					num = (short)215875584;
					short num3 = num;
					num = (short)199688193;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩ꇫ臭黯鯱胳駵諷껹藻軽旿崁䔃㸅㴇㸉㠋", a_)))
					{
						num = (short)482279439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45E;
				}
				case 7:
					if (producerFields != null)
					{
						num = (short)1568800787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_61A;
				case 8:
					goto IL_411;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩ꃫ迭蓯釱鳳돵雷鯹黻鋽旿嘁洃欅洇唉䴋㘍␏‑┓", a_)))
					{
						num = (short)905707524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5CE;
				case 10:
					goto IL_583;
				case 11:
					goto IL_261;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩ꇫ黭鳯ꃱ釳闵駷雹郻돽濿昁愃夅䤇㸉㴋㠍⤏⨑", a_)))
					{
						num = (short)1895301122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_61A;
				case 13:
					goto IL_3C5;
				case 14:
					this.cnvWideGeneralLatchEnableTone_A8422 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩ꃫ迭蓯釱鳳돵雷鯹黻鋽旿嘁欃栅洇唉䴋㘍␏‑☓", a_), global::CommonResources.AcgResources.ID_LATCHENABLETONE);
					this.cnvWideGeneralLatchEnableTone_A8422.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideGeneralLatchEnableTone_A8422.DataTransferOrder = 5;
					num = (short)377749515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.cnvWideGeneralMonitorType_A8544 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩ꇫ臭黯鯱胳駵諷껹藻軽旿崁䔃㸅㴇㸉㠋", a_), global::CommonResources.AcgResources.ID_MONITORTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.LOVs.CnvWideGeneralMonitorType_A8544LovStrs);
					this.cnvWideGeneralMonitorType_A8544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideGeneralMonitorType_A8544.DataTransferOrder = 6;
					num = (short)1730805761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
				{
					num = (short)1521335395;
					short num4 = num;
					num = (short)980728931;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3F5;
					default:
						num = (short)2144927744;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩뿫鿭藯韱飳闵郷꫹駻賽僿朁瘃甅朇搉洋戍礏昑洓䤕夗⬙┛ⴝᄟᄡ", a_)))
						{
							num = (short)1752039442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_411;
					}
					break;
				}
				case 17:
					this.cnvWideGeneralDirectFrequency_A7860 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩꣫蟭苯韱音苵뻷裹駻追痿朁樃攅焇唉䴋㤍⠏␑␓", a_), global::CommonResources.AcgResources.ID_DIRECTFREQUENCYENABLE);
					this.cnvWideGeneralDirectFrequency_A7860.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvWideGeneralDirectFrequency_A7860.DataTransferOrder = 27;
					num = (short)620298253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					this.cnvWideGeneralSquelchPerPersonality_A19313 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩뿫鿭藯韱飳闵郷꫹駻賽僿朁瘃甅朇搉洋戍礏昑洓䤕夗⬙┛ⴝᄟᄡ", a_), global::CommonResources.AcgResources.ID_SQUELCHPERPERSONALITY);
					this.cnvWideGeneralSquelchPerPersonality_A19313.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideGeneralSquelchPerPersonality_A19313.DataTransferOrder = 9;
					num = (short)227082248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1037959173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.cnvWideGeneralHUBDefeatsPL_A8215 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩ꓫ믭닯뛱釳郵鷷鯹裻跽僿丁嬃䜅〇㠉㴋㬍", a_), global::CommonResources.AcgResources.ID_HUBDEFEATSPL);
					this.cnvWideGeneralHUBDefeatsPL_A8215.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideGeneralHUBDefeatsPL_A8215.DataTransferOrder = 4;
					num = (short)1091174410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 22:
					goto IL_5CE;
				case 23:
					goto IL_353;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ臕뇗뻙맛駝藟賡臣铥觧蛩ꃫ迭蓯釱鳳돵雷鯹黻鋽旿嘁欃栅洇唉䴋㘍␏‑☓", a_)))
					{
						num = (short)1205141518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				}
				IL_92:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1427177475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_261:
				num = (short)1532166150;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C5:
				num = (short)977731584;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F5:
				num = (short)461111316;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_411:
				num = (short)324206604;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45E:
				num = (short)1499987984;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_583:
				num = (short)1529937929;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5CE:
				num = (short)2105212952;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_353:
			IL_61A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韏럑뫓돕꫗믙냛", a_);
			base.Id = 10052;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600B5B1 RID: 46513 RVA: 0x00A85978 File Offset: 0x00A83B78
		public override void PopulateReferences()
		{
			short num = (short)1165081379;
			short num2 = num;
			num = (short)978041635;
			switch (num2 == num)
			{
			}
			num = (short)1645477888;
			short num3 = num;
			num = (short)1540227073;
			if (num != 0)
			{
			}
			num = (short)848822272;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B5B2 RID: 46514 RVA: 0x00A85A24 File Offset: 0x00A83C24
		public override void DropReferences()
		{
			short num = (short)1229924865;
			short num2 = num;
			num = (short)1365125633;
			switch (num2 == num)
			{
			}
			num = (short)501153792;
			short num3 = num;
			num = (short)849281025;
			if (num != 0)
			{
			}
			num = (short)599261184;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x00A85ACC File Offset: 0x00A83CCC
		public override void SetConstraints()
		{
			short num = (short)1740764708;
			short num2 = num;
			num = (short)2103768612;
			switch (num2 == num)
			{
			}
			num = (short)1313472512;
			short num3 = num;
			num = (short)241762305;
			if (num != 0)
			{
			}
			num = (short)390397952;
			if (num != 0)
			{
			}
			this.cnvWideGeneralDirectFrequency_A7860.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideConstraints.ConDirectFreqEnableIsValid);
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x00A85B8C File Offset: 0x00A83D8C
		public override void SetupDependencies()
		{
			short num = (short)605735726;
			short num2 = num;
			num = (short)907529006;
			switch (num2 == num)
			{
			}
			num = (short)2106851328;
			short num3 = num;
			num = (short)1870594049;
			if (num != 0)
			{
			}
			num = (short)364314624;
			if (num != 0)
			{
			}
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.cnvWideGeneralDirectFrequency_A7860);
		}

		// Token: 0x17005B0D RID: 23309
		// (get) Token: 0x0600B5B5 RID: 46517 RVA: 0x00A85C50 File Offset: 0x00A83E50
		public bool HasDiffs
		{
			get
			{
				short num = (short)1763839613;
				short num2 = num;
				num = (short)1909722749;
				switch (num2 == num)
				{
				}
				num = (short)230621184;
				short num3 = num;
				num = (short)14155776;
				if (num != 0)
				{
				}
				num = (short)681705473;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005B0E RID: 23310
		// (get) Token: 0x0600B5B6 RID: 46518 RVA: 0x00A85D00 File Offset: 0x00A83F00
		// (set) Token: 0x0600B5B7 RID: 46519 RVA: 0x00A85DB4 File Offset: 0x00A83FB4
		public bool CnvWideGeneralDirectFrequency_A7860Value
		{
			get
			{
				short num = (short)937295873;
				if (num != 0)
				{
				}
				num = (short)1349231712;
				short num2 = num;
				num = (short)1127588960;
				switch (num2 == num)
				{
				default:
				{
					num = (short)864550912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526974976;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralDirectFrequency_A7860.Value;
			}
			set
			{
				short num = (short)837156865;
				if (num != 0)
				{
				}
				num = (short)876989670;
				short num2 = num;
				num = (short)768789734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1107230720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1975255040;
				if (num != 0)
				{
				}
				this.cnvWideGeneralDirectFrequency_A7860.Value = value;
			}
		}

		// Token: 0x17005B0F RID: 23311
		// (get) Token: 0x0600B5B8 RID: 46520 RVA: 0x00A85E6C File Offset: 0x00A8406C
		public global::AcpBusinessLayer.AcpField<bool> CnvWideGeneralDirectFrequency_A7860
		{
			get
			{
				short num = (short)574277433;
				short num2 = num;
				num = (short)1725220665;
				switch (num2 == num)
				{
				}
				num = (short)1137704960;
				short num3 = num;
				num = (short)593690624;
				if (num != 0)
				{
				}
				num = (short)1666580481;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralDirectFrequency_A7860;
			}
		}

		// Token: 0x17005B10 RID: 23312
		// (get) Token: 0x0600B5B9 RID: 46521 RVA: 0x00A85F1C File Offset: 0x00A8411C
		// (set) Token: 0x0600B5BA RID: 46522 RVA: 0x00A85FD0 File Offset: 0x00A841D0
		public bool CnvWideGeneralDirectFrequency_A7860_UIValue
		{
			get
			{
				short num = (short)1383613961;
				short num2 = num;
				num = (short)1809663497;
				switch (num2 == num)
				{
				}
				num = (short)223870976;
				short num3 = num;
				num = (short)472252417;
				if (num != 0)
				{
				}
				num = (short)2063335424;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralDirectFrequency_A7860.Value;
			}
			set
			{
				short num = (short)2079093310;
				short num2 = num;
				num = (short)1379496510;
				switch (num2 == num)
				{
				}
				num = (short)593756160;
				short num3 = num;
				num = (short)1083637761;
				if (num != 0)
				{
				}
				num = (short)1185415168;
				if (num != 0)
				{
				}
				this.cnvWideGeneralDirectFrequency_A7860.Value = value;
			}
		}

		// Token: 0x17005B11 RID: 23313
		// (get) Token: 0x0600B5BB RID: 46523 RVA: 0x00A86084 File Offset: 0x00A84284
		// (set) Token: 0x0600B5BC RID: 46524 RVA: 0x00A8613C File Offset: 0x00A8433C
		public bool CnvWideGeneralDirectFrequency_A7860_Applicable
		{
			get
			{
				short num = (short)640463290;
				short num2 = num;
				num = (short)91271610;
				switch (num2 == num)
				{
				}
				num = (short)1766260736;
				short num3 = num;
				num = (short)1364262912;
				if (num != 0)
				{
				}
				num = (short)956432385;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralDirectFrequency_A7860.Applicable;
			}
			set
			{
				short num = (short)1063955481;
				short num2 = num;
				num = (short)753839129;
				switch (num2 == num)
				{
				}
				num = (short)541458432;
				short num3 = num;
				num = (short)1875116033;
				if (num != 0)
				{
				}
				num = (short)553320448;
				if (num != 0)
				{
				}
				this.cnvWideGeneralDirectFrequency_A7860.Applicable = value;
			}
		}

		// Token: 0x17005B12 RID: 23314
		// (get) Token: 0x0600B5BD RID: 46525 RVA: 0x00A861F0 File Offset: 0x00A843F0
		// (set) Token: 0x0600B5BE RID: 46526 RVA: 0x00A862A4 File Offset: 0x00A844A4
		public bool CnvWideGeneralDirectFrequency_A7860_Valid
		{
			get
			{
				short num = (short)1023929143;
				short num2 = num;
				num = (short)262400823;
				switch (num2 == num)
				{
				}
				num = (short)1365180416;
				short num3 = num;
				num = (short)463667201;
				if (num != 0)
				{
				}
				num = (short)1891368960;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralDirectFrequency_A7860.Valid;
			}
			set
			{
				short num = (short)1408565249;
				if (num != 0)
				{
				}
				num = (short)1069883763;
				short num2 = num;
				num = (short)1580802419;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1539309568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1053884416;
				if (num != 0)
				{
				}
				this.cnvWideGeneralDirectFrequency_A7860.Valid = value;
			}
		}

		// Token: 0x17005B13 RID: 23315
		// (get) Token: 0x0600B5BF RID: 46527 RVA: 0x00A8635C File Offset: 0x00A8455C
		// (set) Token: 0x0600B5C0 RID: 46528 RVA: 0x00A86414 File Offset: 0x00A84614
		public bool CnvWideGeneralDirectFrequency_A7860_Visible
		{
			get
			{
				short num = (short)1733069486;
				short num2 = num;
				num = (short)104958638;
				switch (num2 == num)
				{
				}
				num = (short)1024655360;
				short num3 = num;
				num = (short)1271070721;
				if (num != 0)
				{
				}
				num = (short)1760755712;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralDirectFrequency_A7860.Visible;
			}
			set
			{
				short num = (short)484395203;
				short num2 = num;
				num = (short)109725891;
				switch (num2 == num)
				{
				}
				num = (short)865140736;
				short num3 = num;
				num = (short)266928129;
				if (num != 0)
				{
				}
				num = (short)927793152;
				if (num != 0)
				{
				}
				this.cnvWideGeneralDirectFrequency_A7860.Visible = value;
			}
		}

		// Token: 0x17005B14 RID: 23316
		// (get) Token: 0x0600B5C1 RID: 46529 RVA: 0x00A864C8 File Offset: 0x00A846C8
		// (set) Token: 0x0600B5C2 RID: 46530 RVA: 0x00A8657C File Offset: 0x00A8477C
		public bool CnvWideGeneralDirectFrequency_A7860_Editable
		{
			get
			{
				short num = (short)1840398011;
				short num2 = num;
				num = (short)393952955;
				switch (num2 == num)
				{
				}
				num = (short)807665664;
				if (num != 0)
				{
				}
				num = (short)751173633;
				if (num != 0)
				{
				}
				num = (short)1218314240;
				short num3 = num;
				return this.cnvWideGeneralDirectFrequency_A7860.Editable;
			}
			set
			{
				short num = (short)337233426;
				short num2 = num;
				num = (short)2042873362;
				switch (num2 == num)
				{
				}
				num = (short)793182209;
				if (num != 0)
				{
				}
				num = (short)1619394560;
				if (num != 0)
				{
				}
				num = (short)1809121280;
				short num3 = num;
				this.cnvWideGeneralDirectFrequency_A7860.Editable = value;
			}
		}

		// Token: 0x17005B15 RID: 23317
		// (get) Token: 0x0600B5C3 RID: 46531 RVA: 0x00A86634 File Offset: 0x00A84834
		internal string CnvWideGeneralDirectFrequency_A7860_UILabel
		{
			get
			{
				short num = (short)1579243079;
				short num2 = num;
				num = (short)1693800007;
				switch (num2 == num)
				{
				}
				num = (short)1397161984;
				if (num != 0)
				{
				}
				num = (short)1912864769;
				if (num != 0)
				{
				}
				num = (short)995622912;
				short num3 = num;
				return this.cnvWideGeneralDirectFrequency_A7860.UIName;
			}
		}

		// Token: 0x17005B16 RID: 23318
		// (get) Token: 0x0600B5C4 RID: 46532 RVA: 0x00A866E8 File Offset: 0x00A848E8
		// (set) Token: 0x0600B5C5 RID: 46533 RVA: 0x00A867A4 File Offset: 0x00A849A4
		internal bool CnvWideGeneralDirectFrequency_A7860_HiddenStatic
		{
			get
			{
				short num = (short)1773373216;
				short num2 = num;
				num = (short)341739296;
				switch (num2 == num)
				{
				}
				num = (short)473169920;
				if (num != 0)
				{
				}
				num = (short)1000407041;
				if (num != 0)
				{
				}
				num = (short)1320943616;
				short num3 = num;
				return this.cnvWideGeneralDirectFrequency_A7860.HiddenStatic;
			}
			set
			{
				short num = (short)1069655596;
				short num2 = num;
				num = (short)586262060;
				switch (num2 == num)
				{
				}
				num = (short)1163657217;
				if (num != 0)
				{
				}
				num = (short)1228668928;
				if (num != 0)
				{
				}
				num = (short)318701568;
				short num3 = num;
				this.cnvWideGeneralDirectFrequency_A7860.HiddenStatic = value;
			}
		}

		// Token: 0x17005B17 RID: 23319
		// (get) Token: 0x0600B5C6 RID: 46534 RVA: 0x00A8685C File Offset: 0x00A84A5C
		// (set) Token: 0x0600B5C7 RID: 46535 RVA: 0x00A86910 File Offset: 0x00A84B10
		internal bool CnvWideGeneralDirectFrequency_A7860_HiddenDynamic
		{
			get
			{
				short num = (short)2134490300;
				short num2 = num;
				num = (short)1676197052;
				switch (num2 == num)
				{
				}
				num = (short)1072824320;
				if (num != 0)
				{
				}
				num = (short)1673789441;
				if (num != 0)
				{
				}
				num = (short)1464991744;
				short num3 = num;
				return this.cnvWideGeneralDirectFrequency_A7860.HiddenDynamic;
			}
			set
			{
				short num = (short)568186139;
				short num2 = num;
				num = (short)906548507;
				switch (num2 == num)
				{
				}
				num = (short)289079297;
				if (num != 0)
				{
				}
				num = (short)1390477312;
				if (num != 0)
				{
				}
				num = (short)259260416;
				short num3 = num;
				this.cnvWideGeneralDirectFrequency_A7860.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B18 RID: 23320
		// (get) Token: 0x0600B5C8 RID: 46536 RVA: 0x00A869C4 File Offset: 0x00A84BC4
		public bool CnvWideGeneralDirectFrequency_A7860_HasDiffs
		{
			get
			{
				short num = (short)40711105;
				short num2 = num;
				num = (short)42218433;
				switch (num2 == num)
				{
				}
				num = (short)740950017;
				if (num != 0)
				{
				}
				num = (short)805765120;
				if (num != 0)
				{
				}
				num = (short)863371264;
				short num3 = num;
				return this.cnvWideGeneralDirectFrequency_A7860._HasDiffs;
			}
		}

		// Token: 0x17005B19 RID: 23321
		// (get) Token: 0x0600B5C9 RID: 46537 RVA: 0x00A86A78 File Offset: 0x00A84C78
		// (set) Token: 0x0600B5CA RID: 46538 RVA: 0x00A86B2C File Offset: 0x00A84D2C
		public bool CnvWideGeneralHUBDefeatsPL_A8215Value
		{
			get
			{
				short num = (short)1117066894;
				short num2 = num;
				num = (short)1006638734;
				switch (num2 == num)
				{
				}
				num = (short)1313669120;
				if (num != 0)
				{
				}
				num = (short)268632065;
				if (num != 0)
				{
				}
				num = (short)2059337728;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215.Value;
			}
			set
			{
				short num = (short)759758849;
				if (num != 0)
				{
				}
				num = (short)1751428182;
				short num2 = num;
				num = (short)868592726;
				switch (num2 == num)
				{
				}
				num = (short)2097479680;
				if (num != 0)
				{
				}
				num = (short)153944064;
				short num3 = num;
				this.cnvWideGeneralHUBDefeatsPL_A8215.Value = value;
			}
		}

		// Token: 0x17005B1A RID: 23322
		// (get) Token: 0x0600B5CB RID: 46539 RVA: 0x00A86BE0 File Offset: 0x00A84DE0
		public global::AcpBusinessLayer.AcpField<bool> CnvWideGeneralHUBDefeatsPL_A8215
		{
			get
			{
				short num = (short)1918042113;
				if (num != 0)
				{
				}
				num = (short)2047632945;
				short num2 = num;
				num = (short)1804428849;
				switch (num2 == num)
				{
				}
				num = (short)1703280640;
				if (num != 0)
				{
				}
				num = (short)1242693632;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215;
			}
		}

		// Token: 0x17005B1B RID: 23323
		// (get) Token: 0x0600B5CC RID: 46540 RVA: 0x00A86C8C File Offset: 0x00A84E8C
		// (set) Token: 0x0600B5CD RID: 46541 RVA: 0x00A86D40 File Offset: 0x00A84F40
		public bool CnvWideGeneralHUBDefeatsPL_A8215_UIValue
		{
			get
			{
				short num = (short)2007523159;
				short num2 = num;
				num = (short)564551511;
				switch (num2 == num)
				{
				}
				num = (short)1203503104;
				if (num != 0)
				{
				}
				num = (short)2062286849;
				if (num != 0)
				{
				}
				num = (short)1624637440;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215.Value;
			}
			set
			{
				short num = (short)129814121;
				short num2 = num;
				num = (short)1081986665;
				switch (num2 == num)
				{
				}
				num = (short)1502871553;
				if (num != 0)
				{
				}
				num = (short)561840128;
				if (num != 0)
				{
				}
				num = (short)1996357632;
				short num3 = num;
				this.cnvWideGeneralHUBDefeatsPL_A8215.Value = value;
			}
		}

		// Token: 0x17005B1C RID: 23324
		// (get) Token: 0x0600B5CE RID: 46542 RVA: 0x00A86DF4 File Offset: 0x00A84FF4
		// (set) Token: 0x0600B5CF RID: 46543 RVA: 0x00A86EA8 File Offset: 0x00A850A8
		public bool CnvWideGeneralHUBDefeatsPL_A8215_Applicable
		{
			get
			{
				short num = (short)1762214629;
				short num2 = num;
				num = (short)891306725;
				switch (num2 == num)
				{
				}
				num = (short)288751617;
				if (num != 0)
				{
				}
				num = (short)2011168768;
				if (num != 0)
				{
				}
				num = (short)1873805312;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215.Applicable;
			}
			set
			{
				short num = (short)1056763814;
				short num2 = num;
				num = (short)1959128998;
				switch (num2 == num)
				{
				}
				num = (short)789905409;
				if (num != 0)
				{
				}
				num = (short)1451425792;
				if (num != 0)
				{
				}
				num = (short)1502216192;
				short num3 = num;
				this.cnvWideGeneralHUBDefeatsPL_A8215.Applicable = value;
			}
		}

		// Token: 0x17005B1D RID: 23325
		// (get) Token: 0x0600B5D0 RID: 46544 RVA: 0x00A86F5C File Offset: 0x00A8515C
		// (set) Token: 0x0600B5D1 RID: 46545 RVA: 0x00A87014 File Offset: 0x00A85214
		public bool CnvWideGeneralHUBDefeatsPL_A8215_Valid
		{
			get
			{
				short num = (short)17135301;
				short num2 = num;
				num = (short)595031749;
				switch (num2 == num)
				{
				}
				num = (short)2040070144;
				if (num != 0)
				{
				}
				num = (short)385351681;
				if (num != 0)
				{
				}
				num = (short)1370816512;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215.Valid;
			}
			set
			{
				short num = (short)1738619420;
				short num2 = num;
				num = (short)629094940;
				switch (num2 == num)
				{
				}
				num = (short)108724225;
				if (num != 0)
				{
				}
				num = (short)1843134464;
				if (num != 0)
				{
				}
				num = (short)1036648448;
				short num3 = num;
				this.cnvWideGeneralHUBDefeatsPL_A8215.Valid = value;
			}
		}

		// Token: 0x17005B1E RID: 23326
		// (get) Token: 0x0600B5D2 RID: 46546 RVA: 0x00A870C8 File Offset: 0x00A852C8
		// (set) Token: 0x0600B5D3 RID: 46547 RVA: 0x00A8717C File Offset: 0x00A8537C
		public bool CnvWideGeneralHUBDefeatsPL_A8215_Visible
		{
			get
			{
				short num = (short)1914774744;
				short num2 = num;
				num = (short)982852824;
				switch (num2 == num)
				{
				}
				num = (short)1195442177;
				if (num != 0)
				{
				}
				num = (short)80674816;
				if (num != 0)
				{
				}
				num = (short)1016659968;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215.Visible;
			}
			set
			{
				short num = (short)597947557;
				short num2 = num;
				num = (short)1070789797;
				switch (num2 == num)
				{
				}
				num = (short)2087911425;
				if (num != 0)
				{
				}
				num = (short)805765120;
				if (num != 0)
				{
				}
				num = (short)1249574912;
				short num3 = num;
				this.cnvWideGeneralHUBDefeatsPL_A8215.Visible = value;
			}
		}

		// Token: 0x17005B1F RID: 23327
		// (get) Token: 0x0600B5D4 RID: 46548 RVA: 0x00A87230 File Offset: 0x00A85430
		// (set) Token: 0x0600B5D5 RID: 46549 RVA: 0x00A872E4 File Offset: 0x00A854E4
		public bool CnvWideGeneralHUBDefeatsPL_A8215_Editable
		{
			get
			{
				short num = (short)152360830;
				short num2 = num;
				num = (short)1681381246;
				switch (num2 == num)
				{
				}
				num = (short)1559494657;
				if (num != 0)
				{
				}
				num = (short)1951334400;
				if (num != 0)
				{
				}
				num = (short)422838272;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215.Editable;
			}
			set
			{
				short num = (short)1742976744;
				short num2 = num;
				num = (short)1937225448;
				switch (num2 == num)
				{
				}
				num = (short)770637824;
				if (num != 0)
				{
				}
				num = (short)61341697;
				if (num != 0)
				{
				}
				num = (short)228851712;
				short num3 = num;
				this.cnvWideGeneralHUBDefeatsPL_A8215.Editable = value;
			}
		}

		// Token: 0x17005B20 RID: 23328
		// (get) Token: 0x0600B5D6 RID: 46550 RVA: 0x00A8739C File Offset: 0x00A8559C
		internal string CnvWideGeneralHUBDefeatsPL_A8215_UILabel
		{
			get
			{
				short num = (short)134283265;
				if (num != 0)
				{
				}
				num = (short)626004331;
				short num2 = num;
				num = (short)23859563;
				switch (num2 == num)
				{
				}
				num = (short)162791424;
				if (num != 0)
				{
				}
				num = (short)684916736;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215.UIName;
			}
		}

		// Token: 0x17005B21 RID: 23329
		// (get) Token: 0x0600B5D7 RID: 46551 RVA: 0x00A87454 File Offset: 0x00A85654
		// (set) Token: 0x0600B5D8 RID: 46552 RVA: 0x00A87508 File Offset: 0x00A85708
		internal bool CnvWideGeneralHUBDefeatsPL_A8215_HiddenStatic
		{
			get
			{
				short num = (short)1999286791;
				short num2 = num;
				num = (short)572961287;
				switch (num2 == num)
				{
				}
				num = (short)803471360;
				if (num != 0)
				{
				}
				num = (short)622985217;
				if (num != 0)
				{
				}
				num = (short)1163198464;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215.HiddenStatic;
			}
			set
			{
				short num = (short)60353816;
				short num2 = num;
				num = (short)551087384;
				switch (num2 == num)
				{
				}
				num = (short)1088028673;
				if (num != 0)
				{
				}
				num = (short)914030592;
				if (num != 0)
				{
				}
				num = (short)1118699520;
				short num3 = num;
				this.cnvWideGeneralHUBDefeatsPL_A8215.HiddenStatic = value;
			}
		}

		// Token: 0x17005B22 RID: 23330
		// (get) Token: 0x0600B5D9 RID: 46553 RVA: 0x00A875BC File Offset: 0x00A857BC
		// (set) Token: 0x0600B5DA RID: 46554 RVA: 0x00A87670 File Offset: 0x00A85870
		internal bool CnvWideGeneralHUBDefeatsPL_A8215_HiddenDynamic
		{
			get
			{
				short num = (short)49862790;
				short num2 = num;
				num = (short)508745862;
				switch (num2 == num)
				{
				}
				num = (short)1350696961;
				if (num != 0)
				{
				}
				num = (short)1783169024;
				if (num != 0)
				{
				}
				num = (short)579272704;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215.HiddenDynamic;
			}
			set
			{
				short num = (short)611468706;
				short num2 = num;
				num = (short)1690191266;
				switch (num2 == num)
				{
				}
				num = (short)6356992;
				if (num != 0)
				{
				}
				num = (short)516423681;
				if (num != 0)
				{
				}
				num = (short)877854720;
				short num3 = num;
				this.cnvWideGeneralHUBDefeatsPL_A8215.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B23 RID: 23331
		// (get) Token: 0x0600B5DB RID: 46555 RVA: 0x00A87728 File Offset: 0x00A85928
		public bool CnvWideGeneralHUBDefeatsPL_A8215_HasDiffs
		{
			get
			{
				short num = (short)172357115;
				short num2 = num;
				num = (short)1413084667;
				switch (num2 == num)
				{
				}
				num = (short)1469120513;
				if (num != 0)
				{
				}
				num = (short)1948057600;
				if (num != 0)
				{
				}
				num = (short)548536320;
				short num3 = num;
				return this.cnvWideGeneralHUBDefeatsPL_A8215._HasDiffs;
			}
		}

		// Token: 0x17005B24 RID: 23332
		// (get) Token: 0x0600B5DC RID: 46556 RVA: 0x00A877DC File Offset: 0x00A859DC
		// (set) Token: 0x0600B5DD RID: 46557 RVA: 0x00A87890 File Offset: 0x00A85A90
		public int CnvWideGeneralLatchEnableTime_A8421Value
		{
			get
			{
				short num = (short)363955117;
				short num2 = num;
				num = (short)534610861;
				switch (num2 == num)
				{
				}
				num = (short)1950482432;
				if (num != 0)
				{
				}
				num = (short)38731777;
				if (num != 0)
				{
				}
				num = (short)1190330368;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.Value;
			}
			set
			{
				short num = (short)222030464;
				short num2 = num;
				num = (short)1466559104;
				switch (num2 == num)
				{
				}
				num = (short)672006144;
				if (num != 0)
				{
				}
				num = (short)1116930049;
				if (num != 0)
				{
				}
				num = (short)1260781568;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.Value = value;
			}
		}

		// Token: 0x17005B25 RID: 23333
		// (get) Token: 0x0600B5DE RID: 46558 RVA: 0x00A87948 File Offset: 0x00A85B48
		public global::AcpBusinessLayer.AcpCustomRangeField CnvWideGeneralLatchEnableTime_A8421
		{
			get
			{
				short num = (short)1584143174;
				short num2 = num;
				num = (short)1366629190;
				switch (num2 == num)
				{
				}
				num = (short)2140536832;
				if (num != 0)
				{
				}
				num = (short)2090008577;
				if (num != 0)
				{
				}
				num = (short)1728839680;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421;
			}
		}

		// Token: 0x17005B26 RID: 23334
		// (get) Token: 0x0600B5DF RID: 46559 RVA: 0x00A879FC File Offset: 0x00A85BFC
		// (set) Token: 0x0600B5E0 RID: 46560 RVA: 0x00A87AB0 File Offset: 0x00A85CB0
		public string CnvWideGeneralLatchEnableTime_A8421_UIValue
		{
			get
			{
				short num = (short)146338079;
				short num2 = num;
				num = (short)1045688607;
				switch (num2 == num)
				{
				}
				num = (short)1376387073;
				if (num != 0)
				{
				}
				num = (short)21233664;
				if (num != 0)
				{
				}
				num = (short)566099968;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.UIValue;
			}
			set
			{
				short num = (short)1746097690;
				short num2 = num;
				num = (short)1977570842;
				switch (num2 == num)
				{
				}
				num = (short)1787691009;
				if (num != 0)
				{
				}
				num = (short)782827520;
				if (num != 0)
				{
				}
				num = (short)1787559936;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.UIValue = value;
			}
		}

		// Token: 0x17005B27 RID: 23335
		// (get) Token: 0x0600B5E1 RID: 46561 RVA: 0x00A87B64 File Offset: 0x00A85D64
		// (set) Token: 0x0600B5E2 RID: 46562 RVA: 0x00A87C18 File Offset: 0x00A85E18
		internal int CnvWideGeneralLatchEnableTime_A8421Min
		{
			get
			{
				short num = (short)134501755;
				short num2 = num;
				num = (short)555242875;
				switch (num2 == num)
				{
				}
				num = (short)1361379329;
				if (num != 0)
				{
				}
				num = (short)483459072;
				if (num != 0)
				{
				}
				num = (short)2047803392;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.Min;
			}
			set
			{
				short num = (short)562298881;
				if (num != 0)
				{
				}
				num = (short)402738125;
				short num2 = num;
				num = (short)633686989;
				switch (num2 == num)
				{
				}
				num = (short)1107558400;
				if (num != 0)
				{
				}
				num = (short)1203437568;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.Min = value;
			}
		}

		// Token: 0x17005B28 RID: 23336
		// (get) Token: 0x0600B5E3 RID: 46563 RVA: 0x00A87CCC File Offset: 0x00A85ECC
		// (set) Token: 0x0600B5E4 RID: 46564 RVA: 0x00A87D80 File Offset: 0x00A85F80
		internal int CnvWideGeneralLatchEnableTime_A8421Max
		{
			get
			{
				short num = (short)1317339137;
				if (num != 0)
				{
				}
				num = (short)1688566813;
				short num2 = num;
				num = (short)618888221;
				switch (num2 == num)
				{
				}
				num = (short)1782513664;
				if (num != 0)
				{
				}
				num = (short)730398720;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.Max;
			}
			set
			{
				short num = (short)1135672020;
				short num2 = num;
				num = (short)915077844;
				switch (num2 == num)
				{
				}
				num = (short)40566785;
				if (num != 0)
				{
				}
				num = (short)722599936;
				if (num != 0)
				{
				}
				num = (short)1667694592;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.Max = value;
			}
		}

		// Token: 0x17005B29 RID: 23337
		// (get) Token: 0x0600B5E5 RID: 46565 RVA: 0x00A87E34 File Offset: 0x00A86034
		// (set) Token: 0x0600B5E6 RID: 46566 RVA: 0x00A87EE8 File Offset: 0x00A860E8
		internal int CnvWideGeneralLatchEnableTime_A8421Step
		{
			get
			{
				short num = (short)791479081;
				short num2 = num;
				num = (short)855442217;
				switch (num2 == num)
				{
				}
				num = (short)1036648449;
				if (num != 0)
				{
				}
				num = (short)268107776;
				if (num != 0)
				{
				}
				num = (short)525467648;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.StepSize;
			}
			set
			{
				short num = (short)1643509052;
				short num2 = num;
				num = (short)2010641724;
				switch (num2 == num)
				{
				}
				num = (short)454754305;
				if (num != 0)
				{
				}
				num = (short)2115895296;
				if (num != 0)
				{
				}
				num = (short)681902080;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.StepSize = value;
			}
		}

		// Token: 0x17005B2A RID: 23338
		// (get) Token: 0x0600B5E7 RID: 46567 RVA: 0x00A87F9C File Offset: 0x00A8619C
		// (set) Token: 0x0600B5E8 RID: 46568 RVA: 0x00A88050 File Offset: 0x00A86250
		public bool CnvWideGeneralLatchEnableTime_A8421_Applicable
		{
			get
			{
				short num = (short)1430591031;
				short num2 = num;
				num = (short)398792247;
				switch (num2 == num)
				{
				}
				num = (short)1614675968;
				if (num != 0)
				{
				}
				num = (short)2134114305;
				if (num != 0)
				{
				}
				num = (short)1261436928;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.Applicable;
			}
			set
			{
				short num = (short)598277734;
				short num2 = num;
				num = (short)1645215334;
				switch (num2 == num)
				{
				}
				num = (short)876871681;
				if (num != 0)
				{
				}
				num = (short)1193213952;
				if (num != 0)
				{
				}
				num = (short)272629760;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.Applicable = value;
			}
		}

		// Token: 0x17005B2B RID: 23339
		// (get) Token: 0x0600B5E9 RID: 46569 RVA: 0x00A88104 File Offset: 0x00A86304
		// (set) Token: 0x0600B5EA RID: 46570 RVA: 0x00A881B8 File Offset: 0x00A863B8
		public bool CnvWideGeneralLatchEnableTime_A8421_Valid
		{
			get
			{
				short num = (short)684348645;
				short num2 = num;
				num = (short)1875399909;
				switch (num2 == num)
				{
				}
				num = (short)1171587072;
				if (num != 0)
				{
				}
				num = (short)720633857;
				if (num != 0)
				{
				}
				num = (short)1982005248;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.Valid;
			}
			set
			{
				short num = (short)1299169890;
				short num2 = num;
				num = (short)382059106;
				switch (num2 == num)
				{
				}
				num = (short)2028404737;
				if (num != 0)
				{
				}
				num = (short)774176768;
				if (num != 0)
				{
				}
				num = (short)179699712;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.Valid = value;
			}
		}

		// Token: 0x17005B2C RID: 23340
		// (get) Token: 0x0600B5EB RID: 46571 RVA: 0x00A8826C File Offset: 0x00A8646C
		// (set) Token: 0x0600B5EC RID: 46572 RVA: 0x00A88320 File Offset: 0x00A86520
		public bool CnvWideGeneralLatchEnableTime_A8421_Visible
		{
			get
			{
				short num = (short)266384543;
				short num2 = num;
				num = (short)1804121247;
				switch (num2 == num)
				{
				}
				num = (short)1355481089;
				if (num != 0)
				{
				}
				num = (short)1954938880;
				if (num != 0)
				{
				}
				num = (short)716046336;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.Visible;
			}
			set
			{
				short num = (short)1976787494;
				short num2 = num;
				num = (short)270754342;
				switch (num2 == num)
				{
				}
				num = (short)275251200;
				if (num != 0)
				{
				}
				num = (short)2017329153;
				if (num != 0)
				{
				}
				num = (short)980025344;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.Visible = value;
			}
		}

		// Token: 0x17005B2D RID: 23341
		// (get) Token: 0x0600B5ED RID: 46573 RVA: 0x00A883D4 File Offset: 0x00A865D4
		// (set) Token: 0x0600B5EE RID: 46574 RVA: 0x00A88488 File Offset: 0x00A86688
		public bool CnvWideGeneralLatchEnableTime_A8421_Editable
		{
			get
			{
				short num = (short)1275068417;
				if (num != 0)
				{
				}
				num = (short)1740193326;
				short num2 = num;
				num = (short)1628323374;
				switch (num2 == num)
				{
				}
				num = (short)380633088;
				if (num != 0)
				{
				}
				num = (short)1278476288;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.Editable;
			}
			set
			{
				short num = (short)1303511041;
				if (num != 0)
				{
				}
				num = (short)1436642702;
				short num2 = num;
				num = (short)11038094;
				switch (num2 == num)
				{
				}
				num = (short)106823680;
				if (num != 0)
				{
				}
				num = (short)1132396544;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.Editable = value;
			}
		}

		// Token: 0x17005B2E RID: 23342
		// (get) Token: 0x0600B5EF RID: 46575 RVA: 0x00A88540 File Offset: 0x00A86740
		internal string CnvWideGeneralLatchEnableTime_A8421_UILabel
		{
			get
			{
				short num = (short)552859856;
				short num2 = num;
				num = (short)1143994576;
				switch (num2 == num)
				{
				}
				num = (short)691470337;
				if (num != 0)
				{
				}
				num = (short)537460736;
				if (num != 0)
				{
				}
				num = (short)1578106880;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.UIName;
			}
		}

		// Token: 0x17005B2F RID: 23343
		// (get) Token: 0x0600B5F0 RID: 46576 RVA: 0x00A885F4 File Offset: 0x00A867F4
		// (set) Token: 0x0600B5F1 RID: 46577 RVA: 0x00A886A8 File Offset: 0x00A868A8
		internal bool CnvWideGeneralLatchEnableTime_A8421_HiddenStatic
		{
			get
			{
				short num = (short)10879780;
				short num2 = num;
				num = (short)47186724;
				switch (num2 == num)
				{
				}
				num = (short)1303904256;
				if (num != 0)
				{
				}
				num = (short)1105854465;
				if (num != 0)
				{
				}
				num = (short)2001207296;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.HiddenStatic;
			}
			set
			{
				short num = (short)272138903;
				short num2 = num;
				num = (short)506495639;
				switch (num2 == num)
				{
				}
				num = (short)2032533504;
				if (num != 0)
				{
				}
				num = (short)1087635457;
				if (num != 0)
				{
				}
				num = (short)677969920;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.HiddenStatic = value;
			}
		}

		// Token: 0x17005B30 RID: 23344
		// (get) Token: 0x0600B5F2 RID: 46578 RVA: 0x00A8875C File Offset: 0x00A8695C
		// (set) Token: 0x0600B5F3 RID: 46579 RVA: 0x00A88810 File Offset: 0x00A86A10
		internal bool CnvWideGeneralLatchEnableTime_A8421_HiddenDynamic
		{
			get
			{
				short num = (short)60570356;
				short num2 = num;
				num = (short)1173764852;
				switch (num2 == num)
				{
				}
				num = (short)1691222016;
				if (num != 0)
				{
				}
				num = (short)769130497;
				if (num != 0)
				{
				}
				num = (short)1586888704;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421.HiddenDynamic;
			}
			set
			{
				short num = (short)1376350716;
				short num2 = num;
				num = (short)1105031676;
				switch (num2 == num)
				{
				}
				num = (short)1862729728;
				if (num != 0)
				{
				}
				num = (short)1620836353;
				if (num != 0)
				{
				}
				num = (short)1448804352;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTime_A8421.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B31 RID: 23345
		// (get) Token: 0x0600B5F4 RID: 46580 RVA: 0x00A888C4 File Offset: 0x00A86AC4
		public bool CnvWideGeneralLatchEnableTime_A8421_HasDiffs
		{
			get
			{
				short num = (short)1598735967;
				short num2 = num;
				num = (short)33539679;
				switch (num2 == num)
				{
				}
				num = (short)252968960;
				if (num != 0)
				{
				}
				num = (short)1737293825;
				if (num != 0)
				{
				}
				num = (short)669974528;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTime_A8421._HasDiffs;
			}
		}

		// Token: 0x17005B32 RID: 23346
		// (get) Token: 0x0600B5F5 RID: 46581 RVA: 0x00A88978 File Offset: 0x00A86B78
		// (set) Token: 0x0600B5F6 RID: 46582 RVA: 0x00A88A2C File Offset: 0x00A86C2C
		public bool CnvWideGeneralLatchEnableTone_A8422Value
		{
			get
			{
				short num = (short)1213344974;
				short num2 = num;
				num = (short)643116238;
				switch (num2 == num)
				{
				}
				num = (short)2074935297;
				if (num != 0)
				{
				}
				num = (short)1006698496;
				if (num != 0)
				{
				}
				num = (short)841154560;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTone_A8422.Value;
			}
			set
			{
				short num = (short)1005499184;
				short num2 = num;
				num = (short)303018800;
				switch (num2 == num)
				{
				}
				num = (short)1087373312;
				if (num != 0)
				{
				}
				num = (short)1995636737;
				if (num != 0)
				{
				}
				num = (short)1099497472;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTone_A8422.Value = value;
			}
		}

		// Token: 0x17005B33 RID: 23347
		// (get) Token: 0x0600B5F7 RID: 46583 RVA: 0x00A88AE4 File Offset: 0x00A86CE4
		public global::AcpBusinessLayer.AcpField<bool> CnvWideGeneralLatchEnableTone_A8422
		{
			get
			{
				short num = (short)622825946;
				short num2 = num;
				num = (short)443453914;
				switch (num2 == num)
				{
				}
				num = (short)1745027073;
				if (num != 0)
				{
				}
				num = (short)862060544;
				if (num != 0)
				{
				}
				num = (short)1711472640;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTone_A8422;
			}
		}

		// Token: 0x17005B34 RID: 23348
		// (get) Token: 0x0600B5F8 RID: 46584 RVA: 0x00A88B94 File Offset: 0x00A86D94
		// (set) Token: 0x0600B5F9 RID: 46585 RVA: 0x00A88C48 File Offset: 0x00A86E48
		public bool CnvWideGeneralLatchEnableTone_A8422_UIValue
		{
			get
			{
				short num = (short)70790480;
				short num2 = num;
				num = (short)478817616;
				switch (num2 == num)
				{
				}
				num = (short)1041956864;
				if (num != 0)
				{
				}
				num = (short)1819148289;
				if (num != 0)
				{
				}
				num = (short)324403200;
				short num3 = num;
				return this.cnvWideGeneralLatchEnableTone_A8422.Value;
			}
			set
			{
				short num = (short)1857885195;
				short num2 = num;
				num = (short)1509561355;
				switch (num2 == num)
				{
				}
				num = (short)2052325377;
				if (num != 0)
				{
				}
				num = (short)1414987776;
				if (num != 0)
				{
				}
				num = (short)805240832;
				short num3 = num;
				this.cnvWideGeneralLatchEnableTone_A8422.Value = value;
			}
		}

		// Token: 0x17005B35 RID: 23349
		// (get) Token: 0x0600B5FA RID: 46586 RVA: 0x00A88D00 File Offset: 0x00A86F00
		// (set) Token: 0x0600B5FB RID: 46587 RVA: 0x00A88DB4 File Offset: 0x00A86FB4
		public bool CnvWideGeneralLatchEnableTone_A8422_Applicable
		{
			get
			{
				short num = (short)400976174;
				short num2 = num;
				num = (short)1829595438;
				switch (num2 == num)
				{
				}
				num = (short)717553665;
				if (num != 0)
				{
				}
				num = (short)1660223488;
				short num3 = num;
				num = (short)1692008448;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralLatchEnableTone_A8422.Applicable;
			}
			set
			{
				short num = (short)253210266;
				short num2 = num;
				num = (short)690007706;
				switch (num2 == num)
				{
				}
				num = (short)1602879489;
				if (num != 0)
				{
				}
				num = (short)1420099584;
				short num3 = num;
				num = (short)1209204736;
				if (num != 0)
				{
				}
				this.cnvWideGeneralLatchEnableTone_A8422.Applicable = value;
			}
		}

		// Token: 0x17005B36 RID: 23350
		// (get) Token: 0x0600B5FC RID: 46588 RVA: 0x00A88E6C File Offset: 0x00A8706C
		// (set) Token: 0x0600B5FD RID: 46589 RVA: 0x00A88F20 File Offset: 0x00A87120
		public bool CnvWideGeneralLatchEnableTone_A8422_Valid
		{
			get
			{
				short num = (short)914317450;
				short num2 = num;
				num = (short)1937465482;
				switch (num2 == num)
				{
				}
				num = (short)1976107008;
				if (num != 0)
				{
				}
				num = (short)1317666816;
				short num3 = num;
				num = (short)2055471105;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralLatchEnableTone_A8422.Valid;
			}
			set
			{
				short num = (short)816250881;
				if (num != 0)
				{
				}
				num = (short)1617741505;
				short num2 = num;
				num = (short)1204602561;
				switch (num2 == num)
				{
				}
				num = (short)922091520;
				short num3 = num;
				num = (short)1660944384;
				if (num != 0)
				{
				}
				this.cnvWideGeneralLatchEnableTone_A8422.Valid = value;
			}
		}

		// Token: 0x17005B37 RID: 23351
		// (get) Token: 0x0600B5FE RID: 46590 RVA: 0x00A88FD4 File Offset: 0x00A871D4
		// (set) Token: 0x0600B5FF RID: 46591 RVA: 0x00A8908C File Offset: 0x00A8728C
		public bool CnvWideGeneralLatchEnableTone_A8422_Visible
		{
			get
			{
				short num = (short)1940541806;
				short num2 = num;
				num = (short)2089701742;
				switch (num2 == num)
				{
				}
				num = (short)118685697;
				if (num != 0)
				{
				}
				num = (short)698941440;
				short num3 = num;
				num = (short)1040056320;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralLatchEnableTone_A8422.Visible;
			}
			set
			{
				short num = (short)1771194689;
				short num2 = num;
				num = (short)639519041;
				switch (num2 == num)
				{
				}
				num = (short)639107072;
				if (num != 0)
				{
				}
				num = (short)551288832;
				short num3 = num;
				num = (short)35127297;
				if (num != 0)
				{
				}
				this.cnvWideGeneralLatchEnableTone_A8422.Visible = value;
			}
		}

		// Token: 0x17005B38 RID: 23352
		// (get) Token: 0x0600B600 RID: 46592 RVA: 0x00A89140 File Offset: 0x00A87340
		// (set) Token: 0x0600B601 RID: 46593 RVA: 0x00A891F8 File Offset: 0x00A873F8
		public bool CnvWideGeneralLatchEnableTone_A8422_Editable
		{
			get
			{
				short num = (short)377290753;
				if (num != 0)
				{
				}
				num = (short)1139997511;
				short num2 = num;
				num = (short)2015755079;
				switch (num2 == num)
				{
				}
				num = (short)809631744;
				short num3 = num;
				num = (short)1447624704;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralLatchEnableTone_A8422.Editable;
			}
			set
			{
				short num = (short)1341373239;
				short num2 = num;
				num = (short)711703351;
				switch (num2 == num)
				{
				}
				num = (short)87031808;
				if (num != 0)
				{
				}
				num = (short)1296302080;
				short num3 = num;
				num = (short)678494209;
				if (num != 0)
				{
				}
				this.cnvWideGeneralLatchEnableTone_A8422.Editable = value;
			}
		}

		// Token: 0x17005B39 RID: 23353
		// (get) Token: 0x0600B602 RID: 46594 RVA: 0x00A892B0 File Offset: 0x00A874B0
		internal string CnvWideGeneralLatchEnableTone_A8422_UILabel
		{
			get
			{
				short num = (short)1054806038;
				short num2 = num;
				num = (short)1466961942;
				switch (num2 == num)
				{
				}
				num = (short)1158152193;
				if (num != 0)
				{
				}
				num = (short)1264713728;
				short num3 = num;
				num = (short)480313344;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralLatchEnableTone_A8422.UIName;
			}
		}

		// Token: 0x17005B3A RID: 23354
		// (get) Token: 0x0600B603 RID: 46595 RVA: 0x00A89364 File Offset: 0x00A87564
		// (set) Token: 0x0600B604 RID: 46596 RVA: 0x00A89418 File Offset: 0x00A87618
		internal bool CnvWideGeneralLatchEnableTone_A8422_HiddenStatic
		{
			get
			{
				short num = (short)1714489820;
				short num2 = num;
				num = (short)218434012;
				switch (num2 == num)
				{
				}
				num = (short)240910337;
				if (num != 0)
				{
				}
				num = (short)1376714752;
				short num3 = num;
				num = (short)1186922496;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralLatchEnableTone_A8422.HiddenStatic;
			}
			set
			{
				short num = (short)1612415643;
				short num2 = num;
				num = (short)333808283;
				switch (num2 == num)
				{
				}
				num = (short)965672961;
				if (num != 0)
				{
				}
				num = (short)2011889664;
				short num3 = num;
				num = (short)2055012352;
				if (num != 0)
				{
				}
				this.cnvWideGeneralLatchEnableTone_A8422.HiddenStatic = value;
			}
		}

		// Token: 0x17005B3B RID: 23355
		// (get) Token: 0x0600B605 RID: 46597 RVA: 0x00A894D0 File Offset: 0x00A876D0
		// (set) Token: 0x0600B606 RID: 46598 RVA: 0x00A89584 File Offset: 0x00A87784
		internal bool CnvWideGeneralLatchEnableTone_A8422_HiddenDynamic
		{
			get
			{
				short num = (short)1138214600;
				short num2 = num;
				num = (short)1014220488;
				switch (num2 == num)
				{
				}
				num = (short)380698625;
				if (num != 0)
				{
				}
				num = (short)489750528;
				short num3 = num;
				num = (short)1347551232;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralLatchEnableTone_A8422.HiddenDynamic;
			}
			set
			{
				short num = (short)660534481;
				short num2 = num;
				num = (short)1937175761;
				switch (num2 == num)
				{
				}
				num = (short)1825243137;
				if (num != 0)
				{
				}
				num = (short)1221197824;
				short num3 = num;
				num = (short)1494155264;
				if (num != 0)
				{
				}
				this.cnvWideGeneralLatchEnableTone_A8422.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B3C RID: 23356
		// (get) Token: 0x0600B607 RID: 46599 RVA: 0x00A89638 File Offset: 0x00A87838
		public bool CnvWideGeneralLatchEnableTone_A8422_HasDiffs
		{
			get
			{
				short num = (short)1182233500;
				short num2 = num;
				num = (short)212759452;
				switch (num2 == num)
				{
				}
				num = (short)54263809;
				if (num != 0)
				{
				}
				num = (short)201719808;
				short num3 = num;
				num = (short)1327693824;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralLatchEnableTone_A8422._HasDiffs;
			}
		}

		// Token: 0x17005B3D RID: 23357
		// (get) Token: 0x0600B608 RID: 46600 RVA: 0x00A896F0 File Offset: 0x00A878F0
		// (set) Token: 0x0600B609 RID: 46601 RVA: 0x00A897A4 File Offset: 0x00A879A4
		public int CnvWideGeneralMonitorType_A8544Value
		{
			get
			{
				short num = (short)861405185;
				if (num != 0)
				{
				}
				num = (short)715211999;
				short num2 = num;
				num = (short)1228686559;
				switch (num2 == num)
				{
				}
				num = (short)1416953856;
				short num3 = num;
				num = (short)241893376;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544.Value;
			}
			set
			{
				short num = (short)363859617;
				short num2 = num;
				num = (short)1198198433;
				switch (num2 == num)
				{
				}
				num = (short)1765081089;
				if (num != 0)
				{
				}
				num = (short)68288512;
				short num3 = num;
				num = (short)819789824;
				if (num != 0)
				{
				}
				this.cnvWideGeneralMonitorType_A8544.Value = value;
			}
		}

		// Token: 0x17005B3E RID: 23358
		// (get) Token: 0x0600B60A RID: 46602 RVA: 0x00A89858 File Offset: 0x00A87A58
		// (set) Token: 0x0600B60B RID: 46603 RVA: 0x00A8990C File Offset: 0x00A87B0C
		public string CnvWideGeneralMonitorType_A8544_UIValue
		{
			get
			{
				short num = (short)479458878;
				short num2 = num;
				num = (short)1250620990;
				switch (num2 == num)
				{
				}
				num = (short)1418526720;
				if (num != 0)
				{
				}
				num = (short)8978432;
				short num3 = num;
				num = (short)423952385;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544.UIValue;
			}
			set
			{
				short num = (short)1457750681;
				short num2 = num;
				num = (short)398099097;
				switch (num2 == num)
				{
				}
				num = (short)2090401792;
				if (num != 0)
				{
				}
				num = (short)1907752960;
				short num3 = num;
				num = (short)1854799873;
				if (num != 0)
				{
				}
				this.cnvWideGeneralMonitorType_A8544.UIValue = value;
			}
		}

		// Token: 0x17005B3F RID: 23359
		// (get) Token: 0x0600B60C RID: 46604 RVA: 0x00A899BC File Offset: 0x00A87BBC
		public global::AcpBusinessLayer.AcpListField CnvWideGeneralMonitorType_A8544
		{
			get
			{
				short num = (short)907277446;
				short num2 = num;
				num = (short)1161491590;
				switch (num2 == num)
				{
				}
				num = (short)1650589697;
				if (num != 0)
				{
				}
				num = (short)813760512;
				short num3 = num;
				num = (short)197132288;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544;
			}
		}

		// Token: 0x17005B40 RID: 23360
		// (get) Token: 0x0600B60D RID: 46605 RVA: 0x00A89A6C File Offset: 0x00A87C6C
		// (set) Token: 0x0600B60E RID: 46606 RVA: 0x00A89B20 File Offset: 0x00A87D20
		public bool CnvWideGeneralMonitorType_A8544_Applicable
		{
			get
			{
				short num = (short)529816780;
				short num2 = num;
				num = (short)2033736908;
				switch (num2 == num)
				{
				}
				num = (short)1368522753;
				if (num != 0)
				{
				}
				num = (short)1606025216;
				short num3 = num;
				num = (short)1064894464;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544.Applicable;
			}
			set
			{
				short num = (short)1322405856;
				short num2 = num;
				num = (short)164188128;
				switch (num2 == num)
				{
				}
				num = (short)1230241792;
				if (num != 0)
				{
				}
				num = (short)119996416;
				short num3 = num;
				num = (short)593756161;
				if (num != 0)
				{
				}
				this.cnvWideGeneralMonitorType_A8544.Applicable = value;
			}
		}

		// Token: 0x17005B41 RID: 23361
		// (get) Token: 0x0600B60F RID: 46607 RVA: 0x00A89BD8 File Offset: 0x00A87DD8
		// (set) Token: 0x0600B610 RID: 46608 RVA: 0x00A89C8C File Offset: 0x00A87E8C
		public bool CnvWideGeneralMonitorType_A8544_Valid
		{
			get
			{
				short num = (short)859221738;
				short num2 = num;
				num = (short)756920042;
				switch (num2 == num)
				{
				}
				num = (short)794492929;
				if (num != 0)
				{
				}
				num = (short)858587136;
				short num3 = num;
				num = (short)550043648;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544.Valid;
			}
			set
			{
				short num = (short)2121624311;
				short num2 = num;
				num = (short)1906535159;
				switch (num2 == num)
				{
				}
				num = (short)167575553;
				if (num != 0)
				{
				}
				num = (short)900792320;
				short num3 = num;
				num = (short)626065408;
				if (num != 0)
				{
				}
				this.cnvWideGeneralMonitorType_A8544.Valid = value;
			}
		}

		// Token: 0x17005B42 RID: 23362
		// (get) Token: 0x0600B611 RID: 46609 RVA: 0x00A89D40 File Offset: 0x00A87F40
		// (set) Token: 0x0600B612 RID: 46610 RVA: 0x00A89DF8 File Offset: 0x00A87FF8
		public bool CnvWideGeneralMonitorType_A8544_Visible
		{
			get
			{
				short num = (short)268061906;
				short num2 = num;
				num = (short)1025330386;
				switch (num2 == num)
				{
				}
				num = (short)532742145;
				if (num != 0)
				{
				}
				num = (short)302055424;
				short num3 = num;
				num = (short)3145728;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544.Visible;
			}
			set
			{
				short num = (short)1439167190;
				short num2 = num;
				num = (short)969405142;
				switch (num2 == num)
				{
				}
				num = (short)1227292672;
				if (num != 0)
				{
				}
				num = (short)624492544;
				short num3 = num;
				num = (short)95551489;
				if (num != 0)
				{
				}
				this.cnvWideGeneralMonitorType_A8544.Visible = value;
			}
		}

		// Token: 0x17005B43 RID: 23363
		// (get) Token: 0x0600B613 RID: 46611 RVA: 0x00A89EAC File Offset: 0x00A880AC
		// (set) Token: 0x0600B614 RID: 46612 RVA: 0x00A89F60 File Offset: 0x00A88160
		public bool CnvWideGeneralMonitorType_A8544_Editable
		{
			get
			{
				short num = (short)1356529941;
				short num2 = num;
				num = (short)274071829;
				switch (num2 == num)
				{
				}
				num = (short)177995777;
				if (num != 0)
				{
				}
				num = (short)1639448576;
				short num3 = num;
				num = (short)258408448;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544.Editable;
			}
			set
			{
				short num = (short)1171980289;
				if (num != 0)
				{
				}
				num = (short)734244747;
				short num2 = num;
				num = (short)1121890187;
				switch (num2 == num)
				{
				}
				num = (short)1718747136;
				short num3 = num;
				num = (short)579928064;
				if (num != 0)
				{
				}
				this.cnvWideGeneralMonitorType_A8544.Editable = value;
			}
		}

		// Token: 0x17005B44 RID: 23364
		// (get) Token: 0x0600B615 RID: 46613 RVA: 0x00A8A014 File Offset: 0x00A88214
		internal string CnvWideGeneralMonitorType_A8544_UILabel
		{
			get
			{
				short num = (short)319881217;
				if (num != 0)
				{
				}
				num = (short)457484618;
				short num2 = num;
				num = (short)985835850;
				switch (num2 == num)
				{
				}
				num = (short)593035264;
				short num3 = num;
				num = (short)1266024448;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544.UIName;
			}
		}

		// Token: 0x17005B45 RID: 23365
		// (get) Token: 0x0600B616 RID: 46614 RVA: 0x00A8A0C8 File Offset: 0x00A882C8
		// (set) Token: 0x0600B617 RID: 46615 RVA: 0x00A8A17C File Offset: 0x00A8837C
		internal bool CnvWideGeneralMonitorType_A8544_HiddenStatic
		{
			get
			{
				short num = (short)389753536;
				short num2 = num;
				num = (short)209464000;
				switch (num2 == num)
				{
				}
				num = (short)1760952321;
				if (num != 0)
				{
				}
				num = (short)529793024;
				short num3 = num;
				num = (short)1385889792;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544.HiddenStatic;
			}
			set
			{
				short num = (short)425732428;
				short num2 = num;
				num = (short)97528140;
				switch (num2 == num)
				{
				}
				num = (short)258736128;
				if (num != 0)
				{
				}
				num = (short)517079040;
				short num3 = num;
				num = (short)83230721;
				if (num != 0)
				{
				}
				this.cnvWideGeneralMonitorType_A8544.HiddenStatic = value;
			}
		}

		// Token: 0x17005B46 RID: 23366
		// (get) Token: 0x0600B618 RID: 46616 RVA: 0x00A8A230 File Offset: 0x00A88430
		// (set) Token: 0x0600B619 RID: 46617 RVA: 0x00A8A2E4 File Offset: 0x00A884E4
		internal bool CnvWideGeneralMonitorType_A8544_HiddenDynamic
		{
			get
			{
				short num = (short)1625596491;
				short num2 = num;
				num = (short)1556718155;
				switch (num2 == num)
				{
				}
				num = (short)1092026369;
				if (num != 0)
				{
				}
				num = (short)798752768;
				short num3 = num;
				num = (short)79233024;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544.HiddenDynamic;
			}
			set
			{
				short num = (short)1280424435;
				short num2 = num;
				num = (short)1644673523;
				switch (num2 == num)
				{
				}
				num = (short)160694273;
				if (num != 0)
				{
				}
				num = (short)969342976;
				short num3 = num;
				num = (short)227540992;
				if (num != 0)
				{
				}
				this.cnvWideGeneralMonitorType_A8544.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B47 RID: 23367
		// (get) Token: 0x0600B61A RID: 46618 RVA: 0x00A8A398 File Offset: 0x00A88598
		public bool CnvWideGeneralMonitorType_A8544_HasDiffs
		{
			get
			{
				short num = (short)2044919809;
				if (num != 0)
				{
				}
				num = (short)726093517;
				short num2 = num;
				num = (short)1488735949;
				switch (num2 == num)
				{
				}
				num = (short)657260544;
				short num3 = num;
				num = (short)1161035776;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralMonitorType_A8544._HasDiffs;
			}
		}

		// Token: 0x17005B48 RID: 23368
		// (get) Token: 0x0600B61B RID: 46619 RVA: 0x00A8A450 File Offset: 0x00A88650
		// (set) Token: 0x0600B61C RID: 46620 RVA: 0x00A8A504 File Offset: 0x00A88704
		public bool CnvWideGeneralSquelchPerPersonality_A19313Value
		{
			get
			{
				short num = (short)1754457801;
				short num2 = num;
				num = (short)1289610953;
				switch (num2 == num)
				{
				}
				num = (short)1324023808;
				if (num != 0)
				{
				}
				num = (short)1049755648;
				short num3 = num;
				num = (short)845479937;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralSquelchPerPersonality_A19313.Value;
			}
			set
			{
				short num = (short)1183881722;
				short num2 = num;
				num = (short)170170874;
				switch (num2 == num)
				{
				}
				num = (short)1826488321;
				if (num != 0)
				{
				}
				num = (short)501284864;
				short num3 = num;
				num = (short)489881600;
				if (num != 0)
				{
				}
				this.cnvWideGeneralSquelchPerPersonality_A19313.Value = value;
			}
		}

		// Token: 0x17005B49 RID: 23369
		// (get) Token: 0x0600B61D RID: 46621 RVA: 0x00A8A5B8 File Offset: 0x00A887B8
		public global::AcpBusinessLayer.AcpField<bool> CnvWideGeneralSquelchPerPersonality_A19313
		{
			get
			{
				short num = (short)1299531426;
				short num2 = num;
				num = (short)131024546;
				switch (num2 == num)
				{
				}
				num = (short)1332805633;
				if (num != 0)
				{
				}
				num = (short)1437663232;
				short num3 = num;
				num = (short)757530624;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralSquelchPerPersonality_A19313;
			}
		}

		// Token: 0x17005B4A RID: 23370
		// (get) Token: 0x0600B61E RID: 46622 RVA: 0x00A8A668 File Offset: 0x00A88868
		// (set) Token: 0x0600B61F RID: 46623 RVA: 0x00A8A71C File Offset: 0x00A8891C
		public bool CnvWideGeneralSquelchPerPersonality_A19313_UIValue
		{
			get
			{
				short num = (short)2083567020;
				short num2 = num;
				num = (short)1784788396;
				switch (num2 == num)
				{
				}
				num = (short)1415708672;
				if (num != 0)
				{
				}
				num = (short)248578048;
				short num3 = num;
				num = (short)2138177537;
				if (num != 0)
				{
				}
				return this.cnvWideGeneralSquelchPerPersonality_A19313.Value;
			}
			set
			{
				short num = (short)1046886308;
				short num2 = num;
				num = (short)686831524;
				switch (num2 == num)
				{
				}
				num = (short)1941700609;
				if (num != 0)
				{
				}
				num = (short)232783872;
				short num3 = num;
				num = (short)1675689984;
				if (num != 0)
				{
				}
				this.cnvWideGeneralSquelchPerPersonality_A19313.Value = value;
			}
		}

		// Token: 0x17005B4B RID: 23371
		// (get) Token: 0x0600B620 RID: 46624 RVA: 0x00A8A7D4 File Offset: 0x00A889D4
		// (set) Token: 0x0600B621 RID: 46625 RVA: 0x00A8A888 File Offset: 0x00A88A88
		public bool CnvWideGeneralSquelchPerPersonality_A19313_Applicable
		{
			get
			{
				short num = (short)994444151;
				short num2 = num;
				num = (short)1847329655;
				switch (num2 == num)
				{
				}
				num = (short)1839792129;
				if (num != 0)
				{
				}
				num = (short)110559232;
				if (num != 0)
				{
				}
				num = (short)1465778176;
				short num3 = num;
				return this.cnvWideGeneralSquelchPerPersonality_A19313.Applicable;
			}
			set
			{
				short num = (short)276986145;
				short num2 = num;
				num = (short)1998879009;
				switch (num2 == num)
				{
				}
				num = (short)297926656;
				if (num != 0)
				{
				}
				num = (short)1336934401;
				if (num != 0)
				{
				}
				num = (short)765132800;
				short num3 = num;
				this.cnvWideGeneralSquelchPerPersonality_A19313.Applicable = value;
			}
		}

		// Token: 0x17005B4C RID: 23372
		// (get) Token: 0x0600B622 RID: 46626 RVA: 0x00A8A93C File Offset: 0x00A88B3C
		// (set) Token: 0x0600B623 RID: 46627 RVA: 0x00A8A9F4 File Offset: 0x00A88BF4
		public bool CnvWideGeneralSquelchPerPersonality_A19313_Valid
		{
			get
			{
				short num = (short)754497880;
				short num2 = num;
				num = (short)1526774104;
				switch (num2 == num)
				{
				}
				num = (short)323485697;
				if (num != 0)
				{
				}
				num = (short)653524992;
				if (num != 0)
				{
				}
				num = (short)309329920;
				short num3 = num;
				return this.cnvWideGeneralSquelchPerPersonality_A19313.Valid;
			}
			set
			{
				short num = (short)946841327;
				short num2 = num;
				num = (short)2090313455;
				switch (num2 == num)
				{
				}
				num = (short)941883392;
				if (num != 0)
				{
				}
				num = (short)2115764225;
				if (num != 0)
				{
				}
				num = (short)1701511168;
				short num3 = num;
				this.cnvWideGeneralSquelchPerPersonality_A19313.Valid = value;
			}
		}

		// Token: 0x17005B4D RID: 23373
		// (get) Token: 0x0600B624 RID: 46628 RVA: 0x00A8AAAC File Offset: 0x00A88CAC
		// (set) Token: 0x0600B625 RID: 46629 RVA: 0x00A8AB60 File Offset: 0x00A88D60
		public bool CnvWideGeneralSquelchPerPersonality_A19313_Visible
		{
			get
			{
				short num = (short)861875736;
				short num2 = num;
				num = (short)624832024;
				switch (num2 == num)
				{
				}
				num = (short)1557725185;
				if (num != 0)
				{
				}
				num = (short)815267840;
				if (num != 0)
				{
				}
				num = (short)1193345024;
				short num3 = num;
				return this.cnvWideGeneralSquelchPerPersonality_A19313.Visible;
			}
			set
			{
				short num = (short)152724401;
				short num2 = num;
				num = (short)1451320241;
				switch (num2 == num)
				{
				}
				num = (short)1680867329;
				if (num != 0)
				{
				}
				num = (short)1312030720;
				if (num != 0)
				{
				}
				num = (short)37224448;
				short num3 = num;
				this.cnvWideGeneralSquelchPerPersonality_A19313.Visible = value;
			}
		}

		// Token: 0x17005B4E RID: 23374
		// (get) Token: 0x0600B626 RID: 46630 RVA: 0x00A8AC18 File Offset: 0x00A88E18
		// (set) Token: 0x0600B627 RID: 46631 RVA: 0x00A8ACCC File Offset: 0x00A88ECC
		public bool CnvWideGeneralSquelchPerPersonality_A19313_Editable
		{
			get
			{
				short num = (short)743274036;
				short num2 = num;
				num = (short)1534752308;
				switch (num2 == num)
				{
				}
				num = (short)503644160;
				if (num != 0)
				{
				}
				num = (short)846200833;
				if (num != 0)
				{
				}
				num = (short)786432;
				short num3 = num;
				return this.cnvWideGeneralSquelchPerPersonality_A19313.Editable;
			}
			set
			{
				short num = (short)2024029276;
				short num2 = num;
				num = (short)1988574300;
				switch (num2 == num)
				{
				}
				num = (short)1286799361;
				if (num != 0)
				{
				}
				num = (short)45023232;
				if (num != 0)
				{
				}
				num = (short)287113216;
				short num3 = num;
				this.cnvWideGeneralSquelchPerPersonality_A19313.Editable = value;
			}
		}

		// Token: 0x17005B4F RID: 23375
		// (get) Token: 0x0600B628 RID: 46632 RVA: 0x00A8AD84 File Offset: 0x00A88F84
		internal string CnvWideGeneralSquelchPerPersonality_A19313_UILabel
		{
			get
			{
				short num = (short)345738694;
				short num2 = num;
				num = (short)385322438;
				switch (num2 == num)
				{
				}
				num = (short)52363265;
				if (num != 0)
				{
				}
				num = (short)26738688;
				if (num != 0)
				{
				}
				num = (short)205062144;
				short num3 = num;
				return this.cnvWideGeneralSquelchPerPersonality_A19313.UIName;
			}
		}

		// Token: 0x17005B50 RID: 23376
		// (get) Token: 0x0600B629 RID: 46633 RVA: 0x00A8AE38 File Offset: 0x00A89038
		// (set) Token: 0x0600B62A RID: 46634 RVA: 0x00A8AEEC File Offset: 0x00A890EC
		internal bool CnvWideGeneralSquelchPerPersonality_A19313_HiddenStatic
		{
			get
			{
				short num = (short)254789464;
				short num2 = num;
				num = (short)1655949144;
				switch (num2 == num)
				{
				}
				num = (short)1158414337;
				if (num != 0)
				{
				}
				num = (short)1576206336;
				if (num != 0)
				{
				}
				num = (short)1648361472;
				short num3 = num;
				return this.cnvWideGeneralSquelchPerPersonality_A19313.HiddenStatic;
			}
			set
			{
				short num = (short)58797341;
				short num2 = num;
				num = (short)1214000413;
				switch (num2 == num)
				{
				}
				num = (short)2001403904;
				if (num != 0)
				{
				}
				num = (short)1298923521;
				if (num != 0)
				{
				}
				num = (short)1036779520;
				short num3 = num;
				this.cnvWideGeneralSquelchPerPersonality_A19313.HiddenStatic = value;
			}
		}

		// Token: 0x17005B51 RID: 23377
		// (get) Token: 0x0600B62B RID: 46635 RVA: 0x00A8AFA0 File Offset: 0x00A891A0
		// (set) Token: 0x0600B62C RID: 46636 RVA: 0x00A8B058 File Offset: 0x00A89258
		internal bool CnvWideGeneralSquelchPerPersonality_A19313_HiddenDynamic
		{
			get
			{
				short num = (short)758233022;
				short num2 = num;
				num = (short)1789966270;
				switch (num2 == num)
				{
				}
				num = (short)135397377;
				if (num != 0)
				{
				}
				num = (short)1982988288;
				if (num != 0)
				{
				}
				num = (short)650182656;
				short num3 = num;
				return this.cnvWideGeneralSquelchPerPersonality_A19313.HiddenDynamic;
			}
			set
			{
				short num = (short)433993359;
				short num2 = num;
				num = (short)510211727;
				switch (num2 == num)
				{
				}
				num = (short)2055536640;
				if (num != 0)
				{
				}
				num = (short)521404417;
				if (num != 0)
				{
				}
				num = (short)1733033984;
				short num3 = num;
				this.cnvWideGeneralSquelchPerPersonality_A19313.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B52 RID: 23378
		// (get) Token: 0x0600B62D RID: 46637 RVA: 0x00A8B10C File Offset: 0x00A8930C
		public bool CnvWideGeneralSquelchPerPersonality_A19313_HasDiffs
		{
			get
			{
				short num = (short)674115734;
				short num2 = num;
				num = (short)1837641878;
				switch (num2 == num)
				{
				}
				num = (short)2146631681;
				if (num != 0)
				{
				}
				num = (short)13303808;
				if (num != 0)
				{
				}
				num = (short)699334656;
				short num3 = num;
				return this.cnvWideGeneralSquelchPerPersonality_A19313._HasDiffs;
			}
		}

		// Token: 0x17005B53 RID: 23379
		// (get) Token: 0x0600B62E RID: 46638 RVA: 0x00A8B1C0 File Offset: 0x00A893C0
		// (set) Token: 0x0600B62F RID: 46639 RVA: 0x00A8B274 File Offset: 0x00A89474
		public int CnvWideGeneralMplRecallMode_A41698Value
		{
			get
			{
				short num = (short)1258724691;
				short num2 = num;
				num = (short)2046336339;
				switch (num2 == num)
				{
				}
				num = (short)800653313;
				if (num != 0)
				{
				}
				num = (short)806486016;
				if (num != 0)
				{
				}
				num = (short)220266496;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698.Value;
			}
			set
			{
				short num = (short)980603012;
				short num2 = num;
				num = (short)1484116100;
				switch (num2 == num)
				{
				}
				num = (short)711065601;
				if (num != 0)
				{
				}
				num = (short)745340928;
				if (num != 0)
				{
				}
				num = (short)9633792;
				short num3 = num;
				this.cnvWideGeneralMplRecallMode_A41698.Value = value;
			}
		}

		// Token: 0x17005B54 RID: 23380
		// (get) Token: 0x0600B630 RID: 46640 RVA: 0x00A8B328 File Offset: 0x00A89528
		// (set) Token: 0x0600B631 RID: 46641 RVA: 0x00A8B3DC File Offset: 0x00A895DC
		public string CnvWideGeneralMplRecallMode_A41698_UIValue
		{
			get
			{
				short num = (short)1868481578;
				short num2 = num;
				num = (short)1200145450;
				switch (num2 == num)
				{
				}
				num = (short)1176961025;
				if (num != 0)
				{
				}
				num = (short)597819392;
				if (num != 0)
				{
				}
				num = (short)1735393280;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698.UIValue;
			}
			set
			{
				short num = (short)1987361348;
				short num2 = num;
				num = (short)1949809220;
				switch (num2 == num)
				{
				}
				num = (short)1976762369;
				if (num != 0)
				{
				}
				num = (short)1184169984;
				if (num != 0)
				{
				}
				num = (short)2044919808;
				short num3 = num;
				this.cnvWideGeneralMplRecallMode_A41698.UIValue = value;
			}
		}

		// Token: 0x17005B55 RID: 23381
		// (get) Token: 0x0600B632 RID: 46642 RVA: 0x00A8B494 File Offset: 0x00A89694
		public global::AcpBusinessLayer.AcpListField CnvWideGeneralMplRecallMode_A41698
		{
			get
			{
				short num = (short)687817634;
				short num2 = num;
				num = (short)1260274594;
				switch (num2 == num)
				{
				}
				num = (short)410451968;
				if (num != 0)
				{
				}
				num = (short)1425539073;
				if (num != 0)
				{
				}
				num = (short)211353600;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698;
			}
		}

		// Token: 0x17005B56 RID: 23382
		// (get) Token: 0x0600B633 RID: 46643 RVA: 0x00A8B544 File Offset: 0x00A89744
		// (set) Token: 0x0600B634 RID: 46644 RVA: 0x00A8B5FC File Offset: 0x00A897FC
		public bool CnvWideGeneralMplRecallMode_A41698_Applicable
		{
			get
			{
				short num = (short)2087195576;
				short num2 = num;
				num = (short)412292024;
				switch (num2 == num)
				{
				}
				num = (short)1201602561;
				if (num != 0)
				{
				}
				num = (short)1062338560;
				if (num != 0)
				{
				}
				num = (short)1518927872;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698.Applicable;
			}
			set
			{
				short num = (short)1922683883;
				short num2 = num;
				num = (short)917623787;
				switch (num2 == num)
				{
				}
				num = (short)893124609;
				if (num != 0)
				{
				}
				num = (short)110952448;
				if (num != 0)
				{
				}
				num = (short)2013921280;
				short num3 = num;
				this.cnvWideGeneralMplRecallMode_A41698.Applicable = value;
			}
		}

		// Token: 0x17005B57 RID: 23383
		// (get) Token: 0x0600B635 RID: 46645 RVA: 0x00A8B6B4 File Offset: 0x00A898B4
		// (set) Token: 0x0600B636 RID: 46646 RVA: 0x00A8B768 File Offset: 0x00A89968
		public bool CnvWideGeneralMplRecallMode_A41698_Valid
		{
			get
			{
				short num = (short)1151488088;
				short num2 = num;
				num = (short)1831424088;
				switch (num2 == num)
				{
				}
				num = (short)1849229313;
				if (num != 0)
				{
				}
				num = (short)886571008;
				if (num != 0)
				{
				}
				num = (short)1722351616;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698.Valid;
			}
			set
			{
				short num = (short)964270517;
				short num2 = num;
				num = (short)678795701;
				switch (num2 == num)
				{
				}
				num = (short)504430592;
				if (num != 0)
				{
				}
				num = (short)14614529;
				if (num != 0)
				{
				}
				num = (short)1461321728;
				short num3 = num;
				this.cnvWideGeneralMplRecallMode_A41698.Valid = value;
			}
		}

		// Token: 0x17005B58 RID: 23384
		// (get) Token: 0x0600B637 RID: 46647 RVA: 0x00A8B81C File Offset: 0x00A89A1C
		// (set) Token: 0x0600B638 RID: 46648 RVA: 0x00A8B8D4 File Offset: 0x00A89AD4
		public bool CnvWideGeneralMplRecallMode_A41698_Visible
		{
			get
			{
				short num = (short)1285488641;
				if (num != 0)
				{
				}
				num = (short)1692881405;
				short num2 = num;
				num = (short)1908625917;
				switch (num2 == num)
				{
				}
				num = (short)419692544;
				if (num != 0)
				{
				}
				num = (short)878837760;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698.Visible;
			}
			set
			{
				short num = (short)536449143;
				short num2 = num;
				num = (short)716083319;
				switch (num2 == num)
				{
				}
				num = (short)1713438721;
				if (num != 0)
				{
				}
				num = (short)1770848256;
				if (num != 0)
				{
				}
				num = (short)1408303104;
				short num3 = num;
				this.cnvWideGeneralMplRecallMode_A41698.Visible = value;
			}
		}

		// Token: 0x17005B59 RID: 23385
		// (get) Token: 0x0600B639 RID: 46649 RVA: 0x00A8B988 File Offset: 0x00A89B88
		// (set) Token: 0x0600B63A RID: 46650 RVA: 0x00A8BA44 File Offset: 0x00A89C44
		public bool CnvWideGeneralMplRecallMode_A41698_Editable
		{
			get
			{
				short num = (short)627041993;
				short num2 = num;
				num = (short)834070217;
				switch (num2 == num)
				{
				}
				num = (short)335544320;
				if (num != 0)
				{
				}
				num = (short)1080033281;
				if (num != 0)
				{
				}
				num = (short)2046885888;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698.Editable;
			}
			set
			{
				short num = (short)846817168;
				short num2 = num;
				num = (short)145254288;
				switch (num2 == num)
				{
				}
				num = (short)1800470529;
				if (num != 0)
				{
				}
				num = (short)450494464;
				if (num != 0)
				{
				}
				num = (short)522452992;
				short num3 = num;
				this.cnvWideGeneralMplRecallMode_A41698.Editable = value;
			}
		}

		// Token: 0x17005B5A RID: 23386
		// (get) Token: 0x0600B63B RID: 46651 RVA: 0x00A8BAF8 File Offset: 0x00A89CF8
		internal string CnvWideGeneralMplRecallMode_A41698_UILabel
		{
			get
			{
				short num = (short)305659905;
				if (num != 0)
				{
				}
				num = (short)537839784;
				short num2 = num;
				num = (short)124897448;
				switch (num2 == num)
				{
				}
				num = (short)1288175616;
				if (num != 0)
				{
				}
				num = (short)370671616;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698.UIName;
			}
		}

		// Token: 0x17005B5B RID: 23387
		// (get) Token: 0x0600B63C RID: 46652 RVA: 0x00A8BBAC File Offset: 0x00A89DAC
		// (set) Token: 0x0600B63D RID: 46653 RVA: 0x00A8BC60 File Offset: 0x00A89E60
		internal bool CnvWideGeneralMplRecallMode_A41698_HiddenStatic
		{
			get
			{
				short num = (short)1447720954;
				short num2 = num;
				num = (short)1161263098;
				switch (num2 == num)
				{
				}
				num = (short)1175715841;
				if (num != 0)
				{
				}
				num = (short)361627648;
				if (num != 0)
				{
				}
				num = (short)203423744;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698.HiddenStatic;
			}
			set
			{
				short num = (short)1062669832;
				short num2 = num;
				num = (short)801705480;
				switch (num2 == num)
				{
				}
				num = (short)1179516929;
				if (num != 0)
				{
				}
				num = (short)463667200;
				if (num != 0)
				{
				}
				num = (short)542244864;
				short num3 = num;
				this.cnvWideGeneralMplRecallMode_A41698.HiddenStatic = value;
			}
		}

		// Token: 0x17005B5C RID: 23388
		// (get) Token: 0x0600B63E RID: 46654 RVA: 0x00A8BD18 File Offset: 0x00A89F18
		// (set) Token: 0x0600B63F RID: 46655 RVA: 0x00A8BDCC File Offset: 0x00A89FCC
		internal bool CnvWideGeneralMplRecallMode_A41698_HiddenDynamic
		{
			get
			{
				short num = (short)1132386722;
				short num2 = num;
				num = (short)56678818;
				switch (num2 == num)
				{
				}
				num = (short)634388480;
				if (num != 0)
				{
				}
				num = (short)246349825;
				if (num != 0)
				{
				}
				num = (short)1746468864;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698.HiddenDynamic;
			}
			set
			{
				short num = (short)149749309;
				short num2 = num;
				num = (short)1412234813;
				switch (num2 == num)
				{
				}
				num = (short)1458372608;
				if (num != 0)
				{
				}
				num = (short)107675649;
				if (num != 0)
				{
				}
				num = (short)1135869952;
				short num3 = num;
				this.cnvWideGeneralMplRecallMode_A41698.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B5D RID: 23389
		// (get) Token: 0x0600B640 RID: 46656 RVA: 0x00A8BE84 File Offset: 0x00A8A084
		public bool CnvWideGeneralMplRecallMode_A41698_HasDiffs
		{
			get
			{
				short num = (short)2135513332;
				short num2 = num;
				num = (short)1252546804;
				switch (num2 == num)
				{
				}
				num = (short)719716353;
				if (num != 0)
				{
				}
				num = (short)1992491008;
				if (num != 0)
				{
				}
				num = (short)1321730048;
				short num3 = num;
				return this.cnvWideGeneralMplRecallMode_A41698._HasDiffs;
			}
		}

		// Token: 0x17005B5E RID: 23390
		// (get) Token: 0x0600B641 RID: 46657 RVA: 0x00A8BF3C File Offset: 0x00A8A13C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1994505881;
				short num2 = num;
				num = (short)2123218585;
				switch (num2 == num)
				{
				}
				num = (short)781713409;
				if (num != 0)
				{
				}
				num = (short)899612672;
				if (num != 0)
				{
				}
				num = (short)1076101120;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600B642 RID: 46658 RVA: 0x00A8BFFC File Offset: 0x00A8A1FC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)389677060;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_140;
				case 2:
					num2 = (short)1631387649;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1833304066;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					goto IL_127;
				}
				goto IL_24;
			}
			IL_127:
			return result;
			IL_140:
			if (base.ParentRecset.ContainerDoc != null)
			{
				goto IL_14D;
			}
			return result;
			IL_24:
			num2 = (short)991395617;
			short num3 = num2;
			num2 = (short)1444118305;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_14D:
				num2 = (short)1612185600;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1003421696;
				if (num2 != 0)
				{
				}
				num2 = (short)969211905;
				if (num2 != 0)
				{
				}
				num2 = (short)489095168;
				short num4 = num2;
				result = null;
				num2 = (short)183042051;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x040058B4 RID: 22708
		private global::AcpBusinessLayer.AcpField<bool> cnvWideGeneralDirectFrequency_A7860;

		// Token: 0x040058B5 RID: 22709
		private global::AcpBusinessLayer.AcpField<bool> cnvWideGeneralHUBDefeatsPL_A8215;

		// Token: 0x040058B6 RID: 22710
		private global::AcpBusinessLayer.AcpCustomRangeField cnvWideGeneralLatchEnableTime_A8421;

		// Token: 0x040058B7 RID: 22711
		private global::AcpBusinessLayer.AcpField<bool> cnvWideGeneralLatchEnableTone_A8422;

		// Token: 0x040058B8 RID: 22712
		private global::AcpBusinessLayer.AcpListField cnvWideGeneralMonitorType_A8544;

		// Token: 0x040058B9 RID: 22713
		private global::AcpBusinessLayer.AcpField<bool> cnvWideGeneralSquelchPerPersonality_A19313;

		// Token: 0x040058BA RID: 22714
		private global::AcpBusinessLayer.AcpListField cnvWideGeneralMplRecallMode_A41698;
	}
}
