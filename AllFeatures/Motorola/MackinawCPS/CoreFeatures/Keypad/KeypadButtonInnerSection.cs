using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.Keypad
{
	// Token: 0x02000304 RID: 772
	[global::System.Serializable]
	public class KeypadButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007ADB RID: 31451 RVA: 0x00700060 File Offset: 0x006FE260
		public KeypadButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x0070007C File Offset: 0x006FE27C
		protected KeypadButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x00700094 File Offset: 0x006FE294
		public override void Init()
		{
			int a_ = 10;
			short num = (short)834656768;
			short num2 = num;
			num = (short)1010293248;
			switch (num2 == num)
			{
			}
			num = (short)439615489;
			if (num != 0)
			{
			}
			num = (short)1835728896;
			short num3 = num;
			num = (short)287768576;
			if (num != 0)
			{
			}
			this.radErgCtrlKeypadGeneralKeypadButtonName_A41069 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ZERO0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔铖귘꧚뇜铞蓠髢闤蛦跨곪裬臮铰臲铴鯶닸黺蓼迾怀朂䜄爆紈缊戌愎弐爒研爖䘘娚⤜⸞ᄠᔢᰤ", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.DataTransferOrder = -1;
			this.radErgCtrlKeypadGeneralKeypadBCO_A41070 = new global::AcpBusinessLayer.AcpSparseLOVField(48, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.indexRadErgCtrlKeypadGeneralKeypadBCO_A41070LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.idRadErgCtrlKeypadGeneralKeypadBCO_A41070LovStrs), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔铖귘꧚뇜铞蓠髢闤蛦跨곪裬臮铰臲铴鯶닸黺蓼迾怀朂䜄䐆䘈吊䰌㬎‐⌒∔✖", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.RadErgCtrlKeypadGeneralKeypadBCO_A41070LovStrs);
			this.radErgCtrlKeypadGeneralKeypadBCO_A41070.IgnoreOnCompare = true;
			this.radErgCtrlKeypadGeneralKeypadBCO_A41070.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgCtrlKeypadGeneralKeypadBCO_A41070.DataTransferOrder = -1;
			this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071 = new global::AcpBusinessLayer.AcpSparseLOVField(34, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.indexRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.idRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071LovStrs), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔铖귘꧚뇜铞蓠髢闤蛦跨곪裬臮铰臲铴鯶닸黺蓼迾怀朂䜄爆紈缊戌愎圐瘒琔挖氘椚砜䀞怠ᜢᐤᜦḨᨪ", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071LovStrs);
			this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.DataTransferOrder = 2;
			this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.ValidateAcrossRecset = true;
			this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔铖귘꧚뇜铞蓠髢闤蛦跨곪裬臮铰臲铴鯶닸黺蓼迾怀朂䜄爆紈缊戌愎堐紒焔爖愘䐚⤜⸞ᔠሢဤ", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.DataTransferOrder = 3;
			this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胊꣌뛎ꇐ닒뇔鯘껚꧜ꯞ軠跢", a_);
			base.Id = 10709;
			base.UIName = global::CommonResources.AcgResources.ID_KEYPADBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x007002C4 File Offset: 0x006FE4C4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)413138953;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgCtrlKeypadGeneralKeypadButtonName_A41069 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ZERO0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋ跍꓏ꃑ룓鷕뷗ꏙ곛뿝蓟ꗡ臣裥跧飩跫苭믯韱跳蛵駷黹뻻诽瓿瘁欃栅䘇欉愋欍伏匑–✕⠗Ⱉ┛", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.DataTransferOrder = -1;
					num = (short)1283063811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1140654084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.radErgCtrlKeypadGeneralKeypadBCO_A41070 = new global::AcpBusinessLayer.AcpSparseLOVField(48, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.indexRadErgCtrlKeypadGeneralKeypadBCO_A41070LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.idRadErgCtrlKeypadGeneralKeypadBCO_A41070LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋ跍꓏ꃑ룓鷕뷗ꏙ곛뿝蓟ꗡ臣裥跧飩跫苭믯韱跳蛵駷黹뻻뷽俿崁䔃㈅㤇㨉㬋㸍", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.RadErgCtrlKeypadGeneralKeypadBCO_A41070LovStrs);
					this.radErgCtrlKeypadGeneralKeypadBCO_A41070.IgnoreOnCompare = true;
					this.radErgCtrlKeypadGeneralKeypadBCO_A41070.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgCtrlKeypadGeneralKeypadBCO_A41070.DataTransferOrder = -1;
					num = (short)895221774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1557603077;
					short num3 = num;
					num = (short)1328292613;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1FA;
					default:
						num = (short)741801984;
						if (num != 0)
						{
						}
						goto IL_348;
					}
					break;
				}
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋ跍꓏ꃑ룓鷕뷗ꏙ곛뿝蓟ꗡ臣裥跧飩跫苭믯韱跳蛵駷黹뻻诽瓿瘁欃栅䘇欉愋欍伏匑–✕⠗Ⱉ┛", a_)))
					{
						num = (short)1816199168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_348;
				case 5:
					goto IL_1FA;
				case 6:
					if (producerFields != null)
					{
						num = (short)1499201537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43D;
				case 7:
					this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071 = new global::AcpBusinessLayer.AcpSparseLOVField(34, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.indexRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.idRadErgCtrlKeypadGeneralKeypadButtonFeature_A41071LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋ跍꓏ꃑ룓鷕뷗ꏙ곛뿝蓟ꗡ臣裥跧飩跫苭믯韱跳蛵駷黹뻻诽瓿瘁欃栅万漉洋稍攏怑焓䤕夗⸙ⴛ⸝ᜟጡ", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071LovStrs);
					this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.DataTransferOrder = 2;
					this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.ValidateAcrossRecset = true;
					num = (short)1999503365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋ跍꓏ꃑ룓鷕뷗ꏙ곛뿝蓟ꗡ臣裥跧飩跫苭믯韱跳蛵駷黹뻻诽瓿瘁欃栅䄇搉栋欍栏䴑–✕Ⱇ⬙⤛", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.DataTransferOrder = 3;
					this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.ValidateAcrossRecset = true;
					num = (short)1317994509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 10:
					num = (short)1279721478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋ跍꓏ꃑ룓鷕뷗ꏙ곛뿝蓟ꗡ臣裥跧飩跫苭믯韱跳蛵駷黹뻻诽瓿瘁欃栅䄇搉栋欍栏䴑–✕Ⱇ⬙⤛", a_)))
					{
						num = (short)1441202184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43D;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋ跍꓏ꃑ룓鷕뷗ꏙ곛뿝蓟ꗡ臣裥跧飩跫苭믯韱跳蛵駷黹뻻诽瓿瘁欃栅万漉洋稍攏怑焓䤕夗⸙ⴛ⸝ᜟጡ", a_)))
					{
						num = (short)2004811783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FA;
				case 13:
					goto IL_343;
				case 14:
					goto IL_283;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋ跍꓏ꃑ룓鷕뷗ꏙ곛뿝蓟ꗡ臣裥跧飩跫苭믯韱跳蛵駷黹뻻뷽俿崁䔃㈅㤇㨉㬋㸍", a_)))
					{
						num = (short)1049100290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_283;
				}
				IL_6E:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)430112768;
					short num4 = num;
					num = (short)1433600010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1FA:
				num = (short)1833959435;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_283:
				num = (short)931201036;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_348:
				num = (short)480641039;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_343:
			IL_43D:
			num = (short)1294467073;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("见ꇃ뿅룇ꯉ꣋鋏ꟑꃓꋕ럗듙", a_);
			base.Id = 10709;
			base.UIName = global::CommonResources.AcgResources.ID_KEYPADBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x00700768 File Offset: 0x006FE968
		public override void PopulateReferences()
		{
			short num = (short)628222825;
			short num2 = num;
			num = (short)15461225;
			switch (num2 == num)
			{
			}
			num = (short)715522048;
			if (num != 0)
			{
			}
			num = (short)502988800;
			short num3 = num;
			num = (short)238092289;
			if (num != 0)
			{
			}
			this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.SetRecset(this.a(2045)[0][10604].EmbeddedRecset);
		}

		// Token: 0x06007AE0 RID: 31456 RVA: 0x0070083C File Offset: 0x006FEA3C
		public override void DropReferences()
		{
			short num = (short)766817071;
			short num2 = num;
			num = (short)1134080815;
			switch (num2 == num)
			{
			}
			num = (short)1241513985;
			if (num != 0)
			{
			}
			num = (short)823590912;
			short num3 = num;
			num = (short)1699610624;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x007008E8 File Offset: 0x006FEAE8
		public override void SetConstraints()
		{
			short num = (short)630755912;
			short num2 = num;
			num = (short)2122093128;
			switch (num2 == num)
			{
			}
			num = (short)1867186176;
			if (num != 0)
			{
			}
			num = (short)942538752;
			short num3 = num;
			num = (short)872677377;
			if (num != 0)
			{
			}
			this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.ValidateAcrossRecset = true;
			this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadConstraints.ConIsKeypadFeatureValidity);
			this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadConstraints.ConSyncKeypadtoShepherd);
			this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.ValidateAcrossRecset = true;
			this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadConstraints.ConIsKeypadIndexApplicable);
			this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadConstraints.ConIsKeypadIndexValid);
			this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadConstraints.ConValueSetKeypadToDirLightingButtonsIndex);
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x00700A38 File Offset: 0x006FEC38
		public override void SetupDependencies()
		{
			short num = (short)53273336;
			short num2 = num;
			num = (short)1967448824;
			switch (num2 == num)
			{
			}
			num = (short)1519124480;
			if (num != 0)
			{
			}
			num = (short)1927020544;
			short num3 = num;
			num = (short)1378091009;
			if (num != 0)
			{
			}
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071);
			this.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071);
			this.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenHiLoAirhornTones_A8200.AddDependentObject(this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415);
			this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.AddDependentObject(this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415);
		}

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x06007AE3 RID: 31459 RVA: 0x00700BA0 File Offset: 0x006FEDA0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner GeneralLightbarPatternInnerSectionForRadErgCtrlKeypadGeneralKeypadButtonIndex_41415
		{
			get
			{
				short num = (short)765698453;
				short num2 = num;
				num = (short)878223765;
				switch (num2 == num)
				{
				}
				num = (short)1532624897;
				if (num != 0)
				{
				}
				num = (short)1330380800;
				short num3 = num;
				num = (short)971309056;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner;
			}
		}

		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x06007AE4 RID: 31460 RVA: 0x00700C58 File Offset: 0x006FEE58
		public bool HasDiffs
		{
			get
			{
				short num = (short)1652022811;
				short num2 = num;
				num = (short)608624155;
				switch (num2 == num)
				{
				}
				num = (short)1437073408;
				if (num != 0)
				{
				}
				num = (short)345505792;
				short num3 = num;
				num = (short)644546561;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x06007AE5 RID: 31461 RVA: 0x00700D04 File Offset: 0x006FEF04
		// (set) Token: 0x06007AE6 RID: 31462 RVA: 0x00700DBC File Offset: 0x006FEFBC
		public string RadErgCtrlKeypadGeneralKeypadButtonName_A41069Value
		{
			get
			{
				short num = (short)1695416068;
				short num2 = num;
				num = (short)823131908;
				switch (num2 == num)
				{
				}
				num = (short)704512001;
				if (num != 0)
				{
				}
				num = (short)1184956416;
				short num3 = num;
				num = (short)1154613248;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Value;
			}
			set
			{
				short num = (short)479614722;
				short num2 = num;
				num = (short)546562;
				switch (num2 == num)
				{
				}
				num = (short)895877121;
				if (num != 0)
				{
				}
				num = (short)765722624;
				short num3 = num;
				num = (short)1036320768;
				if (num != 0)
				{
				}
				this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Value = value;
			}
		}

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x06007AE7 RID: 31463 RVA: 0x00700E74 File Offset: 0x006FF074
		public global::AcpBusinessLayer.AcpField<string> RadErgCtrlKeypadGeneralKeypadButtonName_A41069
		{
			get
			{
				short num = (short)2744354;
				short num2 = num;
				num = (short)277536802;
				switch (num2 == num)
				{
				}
				num = (short)270729216;
				if (num != 0)
				{
				}
				num = (short)339869696;
				short num3 = num;
				num = (short)1005715457;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069;
			}
		}

		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x06007AE8 RID: 31464 RVA: 0x00700F24 File Offset: 0x006FF124
		// (set) Token: 0x06007AE9 RID: 31465 RVA: 0x00700FD8 File Offset: 0x006FF1D8
		public string RadErgCtrlKeypadGeneralKeypadButtonName_A41069_UIValue
		{
			get
			{
				short num = (short)1947009025;
				if (num != 0)
				{
				}
				num = (short)1547387018;
				short num2 = num;
				num = (short)1588084874;
				switch (num2 == num)
				{
				}
				num = (short)2062024704;
				short num3 = num;
				num = (short)713097216;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Value;
			}
			set
			{
				short num = (short)1036648449;
				if (num != 0)
				{
				}
				num = (short)1176854925;
				short num2 = num;
				num = (short)862937485;
				switch (num2 == num)
				{
				}
				num = (short)2075197440;
				short num3 = num;
				num = (short)1472397312;
				if (num != 0)
				{
				}
				this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Value = value;
			}
		}

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x06007AEA RID: 31466 RVA: 0x00701090 File Offset: 0x006FF290
		// (set) Token: 0x06007AEB RID: 31467 RVA: 0x00701148 File Offset: 0x006FF348
		public bool RadErgCtrlKeypadGeneralKeypadButtonName_A41069_Applicable
		{
			get
			{
				short num = (short)1113062636;
				short num2 = num;
				num = (short)1047723244;
				switch (num2 == num)
				{
				}
				num = (short)2122645505;
				if (num != 0)
				{
				}
				num = (short)629211136;
				short num3 = num;
				num = (short)208142336;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Applicable;
			}
			set
			{
				short num = (short)959951815;
				short num2 = num;
				num = (short)55292871;
				switch (num2 == num)
				{
				}
				num = (short)463863808;
				if (num != 0)
				{
				}
				num = (short)377749504;
				short num3 = num;
				num = (short)147193857;
				if (num != 0)
				{
				}
				this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Applicable = value;
			}
		}

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x06007AEC RID: 31468 RVA: 0x007011FC File Offset: 0x006FF3FC
		// (set) Token: 0x06007AED RID: 31469 RVA: 0x007012B4 File Offset: 0x006FF4B4
		public bool RadErgCtrlKeypadGeneralKeypadButtonName_A41069_Valid
		{
			get
			{
				short num = (short)1066130573;
				short num2 = num;
				num = (short)2006310029;
				switch (num2 == num)
				{
				}
				num = (short)531431424;
				if (num != 0)
				{
				}
				num = (short)200343552;
				short num3 = num;
				num = (short)109182977;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Valid;
			}
			set
			{
				short num = (short)572248639;
				short num2 = num;
				num = (short)1242550847;
				switch (num2 == num)
				{
				}
				num = (short)1156382721;
				if (num != 0)
				{
				}
				num = (short)1961558016;
				short num3 = num;
				num = (short)105775104;
				if (num != 0)
				{
				}
				this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Valid = value;
			}
		}

		// Token: 0x17003F11 RID: 16145
		// (get) Token: 0x06007AEE RID: 31470 RVA: 0x00701368 File Offset: 0x006FF568
		// (set) Token: 0x06007AEF RID: 31471 RVA: 0x0070141C File Offset: 0x006FF61C
		public bool RadErgCtrlKeypadGeneralKeypadButtonName_A41069_Visible
		{
			get
			{
				short num = (short)1130954753;
				if (num != 0)
				{
				}
				num = (short)961024749;
				short num2 = num;
				num = (short)1262228205;
				switch (num2 == num)
				{
				}
				num = (short)1700790272;
				short num3 = num;
				num = (short)1457848320;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Visible;
			}
			set
			{
				short num = (short)230086511;
				short num2 = num;
				num = (short)1787811695;
				switch (num2 == num)
				{
				}
				num = (short)712638465;
				if (num != 0)
				{
				}
				num = (short)1803157504;
				short num3 = num;
				num = (short)1534984192;
				if (num != 0)
				{
				}
				this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Visible = value;
			}
		}

		// Token: 0x17003F12 RID: 16146
		// (get) Token: 0x06007AF0 RID: 31472 RVA: 0x007014D0 File Offset: 0x006FF6D0
		// (set) Token: 0x06007AF1 RID: 31473 RVA: 0x00701584 File Offset: 0x006FF784
		public bool RadErgCtrlKeypadGeneralKeypadButtonName_A41069_Editable
		{
			get
			{
				short num = (short)1736638465;
				if (num != 0)
				{
				}
				num = (short)576779316;
				short num2 = num;
				num = (short)843117620;
				switch (num2 == num)
				{
				}
				num = (short)298319872;
				short num3 = num;
				num = (short)1206714368;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Editable;
			}
			set
			{
				short num = (short)1119774856;
				short num2 = num;
				num = (short)317614216;
				switch (num2 == num)
				{
				}
				num = (short)2025062401;
				if (num != 0)
				{
				}
				num = (short)348061696;
				short num3 = num;
				num = (short)598540288;
				if (num != 0)
				{
				}
				this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.Editable = value;
			}
		}

		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x06007AF2 RID: 31474 RVA: 0x00701638 File Offset: 0x006FF838
		internal string RadErgCtrlKeypadGeneralKeypadButtonName_A41069_UILabel
		{
			get
			{
				short num = (short)224460801;
				if (num != 0)
				{
				}
				num = (short)351261050;
				short num2 = num;
				num = (short)1902104954;
				switch (num2 == num)
				{
				}
				num = (short)1046413312;
				short num3 = num;
				num = (short)1749745664;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.UIName;
			}
		}

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x06007AF3 RID: 31475 RVA: 0x007016EC File Offset: 0x006FF8EC
		// (set) Token: 0x06007AF4 RID: 31476 RVA: 0x007017A0 File Offset: 0x006FF9A0
		internal bool RadErgCtrlKeypadGeneralKeypadButtonName_A41069_HiddenStatic
		{
			get
			{
				short num = (short)1188346617;
				short num2 = num;
				num = (short)580762361;
				switch (num2 == num)
				{
				}
				num = (short)630259713;
				if (num != 0)
				{
				}
				num = (short)1898381312;
				short num3 = num;
				num = (short)1006043136;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.HiddenStatic;
			}
			set
			{
				short num = (short)808923138;
				short num2 = num;
				num = (short)824586242;
				switch (num2 == num)
				{
				}
				num = (short)1530855424;
				if (num != 0)
				{
				}
				num = (short)686686209;
				if (num != 0)
				{
				}
				num = (short)856096768;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.HiddenStatic = value;
			}
		}

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x06007AF5 RID: 31477 RVA: 0x00701858 File Offset: 0x006FFA58
		// (set) Token: 0x06007AF6 RID: 31478 RVA: 0x0070190C File Offset: 0x006FFB0C
		internal bool RadErgCtrlKeypadGeneralKeypadButtonName_A41069_HiddenDynamic
		{
			get
			{
				short num = (short)601865313;
				short num2 = num;
				num = (short)1099086945;
				switch (num2 == num)
				{
				}
				num = (short)1799225345;
				if (num != 0)
				{
				}
				num = (short)287375360;
				if (num != 0)
				{
				}
				num = (short)1000865792;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.HiddenDynamic;
			}
			set
			{
				short num = (short)1180719025;
				short num2 = num;
				num = (short)357717937;
				switch (num2 == num)
				{
				}
				num = (short)1632108544;
				if (num != 0)
				{
				}
				num = (short)1708720129;
				if (num != 0)
				{
				}
				num = (short)49610752;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonName_A41069.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x06007AF7 RID: 31479 RVA: 0x007019C0 File Offset: 0x006FFBC0
		public bool RadErgCtrlKeypadGeneralKeypadButtonName_A41069_HasDiffs
		{
			get
			{
				short num = (short)341500378;
				short num2 = num;
				num = (short)1077469658;
				switch (num2 == num)
				{
				}
				num = (short)1034092544;
				if (num != 0)
				{
				}
				num = (short)834338817;
				if (num != 0)
				{
				}
				num = (short)414515200;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonName_A41069._HasDiffs;
			}
		}

		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x06007AF8 RID: 31480 RVA: 0x00701A70 File Offset: 0x006FFC70
		// (set) Token: 0x06007AF9 RID: 31481 RVA: 0x00701B28 File Offset: 0x006FFD28
		public int RadErgCtrlKeypadGeneralKeypadBCO_A41070Value
		{
			get
			{
				short num = (short)700802530;
				short num2 = num;
				num = (short)484599266;
				switch (num2 == num)
				{
				}
				num = (short)1669464065;
				if (num != 0)
				{
				}
				num = (short)784924672;
				if (num != 0)
				{
				}
				num = (short)68354048;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070.Value;
			}
			set
			{
				short num = (short)553582593;
				if (num != 0)
				{
				}
				num = (short)1363630607;
				short num2 = num;
				num = (short)855005711;
				switch (num2 == num)
				{
				}
				num = (short)286851072;
				if (num != 0)
				{
				}
				num = (short)318111744;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadBCO_A41070.Value = value;
			}
		}

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x06007AFA RID: 31482 RVA: 0x00701BDC File Offset: 0x006FFDDC
		// (set) Token: 0x06007AFB RID: 31483 RVA: 0x00701C94 File Offset: 0x006FFE94
		public string RadErgCtrlKeypadGeneralKeypadBCO_A41070_UIValue
		{
			get
			{
				short num = (short)1708019638;
				short num2 = num;
				num = (short)2120175542;
				switch (num2 == num)
				{
				}
				num = (short)1647509505;
				if (num != 0)
				{
				}
				num = (short)1300103168;
				if (num != 0)
				{
				}
				num = (short)1861222400;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070.UIValue;
			}
			set
			{
				short num = (short)491576878;
				short num2 = num;
				num = (short)851369518;
				switch (num2 == num)
				{
				}
				num = (short)1922367488;
				if (num != 0)
				{
				}
				num = (short)770899969;
				if (num != 0)
				{
				}
				num = (short)118095872;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadBCO_A41070.UIValue = value;
			}
		}

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x06007AFC RID: 31484 RVA: 0x00701D4C File Offset: 0x006FFF4C
		public global::AcpBusinessLayer.AcpListField RadErgCtrlKeypadGeneralKeypadBCO_A41070
		{
			get
			{
				short num = (short)563404279;
				short num2 = num;
				num = (short)1300749815;
				switch (num2 == num)
				{
				}
				num = (short)1259864065;
				if (num != 0)
				{
				}
				num = (short)473563136;
				if (num != 0)
				{
				}
				num = (short)1360134144;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070;
			}
		}

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x06007AFD RID: 31485 RVA: 0x00701DFC File Offset: 0x006FFFFC
		// (set) Token: 0x06007AFE RID: 31486 RVA: 0x00701EB0 File Offset: 0x007000B0
		public bool RadErgCtrlKeypadGeneralKeypadBCO_A41070_Applicable
		{
			get
			{
				short num = (short)1002282810;
				short num2 = num;
				num = (short)759603002;
				switch (num2 == num)
				{
				}
				num = (short)1913782272;
				if (num != 0)
				{
				}
				num = (short)1240465409;
				if (num != 0)
				{
				}
				num = (short)1842741248;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070.Applicable;
			}
			set
			{
				short num = (short)817894028;
				short num2 = num;
				num = (short)1532367500;
				switch (num2 == num)
				{
				}
				num = (short)2056650753;
				if (num != 0)
				{
				}
				num = (short)118620160;
				if (num != 0)
				{
				}
				num = (short)1107623936;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadBCO_A41070.Applicable = value;
			}
		}

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x06007AFF RID: 31487 RVA: 0x00701F68 File Offset: 0x00700168
		// (set) Token: 0x06007B00 RID: 31488 RVA: 0x0070201C File Offset: 0x0070021C
		public bool RadErgCtrlKeypadGeneralKeypadBCO_A41070_Valid
		{
			get
			{
				short num = (short)1167065089;
				if (num != 0)
				{
				}
				num = (short)1269634151;
				short num2 = num;
				num = (short)994579559;
				switch (num2 == num)
				{
				}
				num = (short)2015952896;
				if (num != 0)
				{
				}
				num = (short)1011417088;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070.Valid;
			}
			set
			{
				short num = (short)401526880;
				short num2 = num;
				num = (short)98816096;
				switch (num2 == num)
				{
				}
				num = (short)1730281473;
				if (num != 0)
				{
				}
				num = (short)1178402816;
				if (num != 0)
				{
				}
				num = (short)72613888;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadBCO_A41070.Valid = value;
			}
		}

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x06007B01 RID: 31489 RVA: 0x007020D4 File Offset: 0x007002D4
		// (set) Token: 0x06007B02 RID: 31490 RVA: 0x00702188 File Offset: 0x00700388
		public bool RadErgCtrlKeypadGeneralKeypadBCO_A41070_Visible
		{
			get
			{
				short num = (short)561420541;
				short num2 = num;
				num = (short)1298700541;
				switch (num2 == num)
				{
				}
				num = (short)1507393537;
				if (num != 0)
				{
				}
				num = (short)600637440;
				if (num != 0)
				{
				}
				num = (short)1886388224;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070.Visible;
			}
			set
			{
				short num = (short)1962253360;
				short num2 = num;
				num = (short)544185392;
				switch (num2 == num)
				{
				}
				num = (short)801243137;
				if (num != 0)
				{
				}
				num = (short)1538654208;
				if (num != 0)
				{
				}
				num = (short)1023541248;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadBCO_A41070.Visible = value;
			}
		}

		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x06007B03 RID: 31491 RVA: 0x0070223C File Offset: 0x0070043C
		// (set) Token: 0x06007B04 RID: 31492 RVA: 0x007022F0 File Offset: 0x007004F0
		public bool RadErgCtrlKeypadGeneralKeypadBCO_A41070_Editable
		{
			get
			{
				short num = (short)1776484353;
				if (num != 0)
				{
				}
				num = (short)1058791272;
				short num2 = num;
				num = (short)1141170024;
				switch (num2 == num)
				{
				}
				num = (short)1319567360;
				if (num != 0)
				{
				}
				num = (short)1272184832;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070.Editable;
			}
			set
			{
				short num = (short)1031578991;
				short num2 = num;
				num = (short)50570607;
				switch (num2 == num)
				{
				}
				num = (short)2034761728;
				if (num != 0)
				{
				}
				num = (short)1074200577;
				if (num != 0)
				{
				}
				num = (short)458227712;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadBCO_A41070.Editable = value;
			}
		}

		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x06007B05 RID: 31493 RVA: 0x007023A8 File Offset: 0x007005A8
		internal string RadErgCtrlKeypadGeneralKeypadBCO_A41070_UILabel
		{
			get
			{
				short num = (short)828528740;
				short num2 = num;
				num = (short)1089886308;
				switch (num2 == num)
				{
				}
				num = (short)1161953280;
				if (num != 0)
				{
				}
				num = (short)176291841;
				if (num != 0)
				{
				}
				num = (short)738131968;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070.UIName;
			}
		}

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x06007B06 RID: 31494 RVA: 0x0070245C File Offset: 0x0070065C
		// (set) Token: 0x06007B07 RID: 31495 RVA: 0x00702510 File Offset: 0x00700710
		internal bool RadErgCtrlKeypadGeneralKeypadBCO_A41070_HiddenStatic
		{
			get
			{
				short num = (short)1323834386;
				short num2 = num;
				num = (short)366418962;
				switch (num2 == num)
				{
				}
				num = (short)2117468161;
				if (num != 0)
				{
				}
				num = (short)46006272;
				if (num != 0)
				{
				}
				num = (short)996868096;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070.HiddenStatic;
			}
			set
			{
				short num = (short)1554904342;
				short num2 = num;
				num = (short)1079899414;
				switch (num2 == num)
				{
				}
				num = (short)1785266177;
				if (num != 0)
				{
				}
				num = (short)1252786176;
				if (num != 0)
				{
				}
				num = (short)68616192;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadBCO_A41070.HiddenStatic = value;
			}
		}

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x06007B08 RID: 31496 RVA: 0x007025C0 File Offset: 0x007007C0
		// (set) Token: 0x06007B09 RID: 31497 RVA: 0x00702674 File Offset: 0x00700874
		internal bool RadErgCtrlKeypadGeneralKeypadBCO_A41070_HiddenDynamic
		{
			get
			{
				short num = (short)1210903865;
				short num2 = num;
				num = (short)210169145;
				switch (num2 == num)
				{
				}
				num = (short)1234173953;
				if (num != 0)
				{
				}
				num = (short)1160118272;
				if (num != 0)
				{
				}
				num = (short)1870987264;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070.HiddenDynamic;
			}
			set
			{
				short num = (short)739573761;
				if (num != 0)
				{
				}
				num = (short)696365007;
				short num2 = num;
				num = (short)1871032271;
				switch (num2 == num)
				{
				}
				num = (short)77201408;
				if (num != 0)
				{
				}
				num = (short)685047808;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadBCO_A41070.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x06007B0A RID: 31498 RVA: 0x00702728 File Offset: 0x00700928
		public bool RadErgCtrlKeypadGeneralKeypadBCO_A41070_HasDiffs
		{
			get
			{
				short num = (short)924670223;
				short num2 = num;
				num = (short)2011388175;
				switch (num2 == num)
				{
				}
				num = (short)697434112;
				if (num != 0)
				{
				}
				num = (short)1001717761;
				if (num != 0)
				{
				}
				num = (short)1619722240;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadBCO_A41070._HasDiffs;
			}
		}

		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x06007B0B RID: 31499 RVA: 0x007027DC File Offset: 0x007009DC
		// (set) Token: 0x06007B0C RID: 31500 RVA: 0x00702890 File Offset: 0x00700A90
		public int RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value
		{
			get
			{
				short num = (short)1770250844;
				short num2 = num;
				num = (short)1124262492;
				switch (num2 == num)
				{
				}
				num = (short)704118785;
				if (num != 0)
				{
				}
				num = (short)1935147008;
				if (num != 0)
				{
				}
				num = (short)1124204544;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Value;
			}
			set
			{
				short num = (short)1813186398;
				short num2 = num;
				num = (short)40044382;
				switch (num2 == num)
				{
				}
				num = (short)1659043841;
				if (num != 0)
				{
				}
				num = (short)634191872;
				if (num != 0)
				{
				}
				num = (short)312934400;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Value = value;
			}
		}

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x06007B0D RID: 31501 RVA: 0x00702948 File Offset: 0x00700B48
		// (set) Token: 0x06007B0E RID: 31502 RVA: 0x00702A00 File Offset: 0x00700C00
		public string RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_UIValue
		{
			get
			{
				short num = (short)99549185;
				if (num != 0)
				{
				}
				num = (short)1704023353;
				short num2 = num;
				num = (short)747853113;
				switch (num2 == num)
				{
				}
				num = (short)1340866560;
				if (num != 0)
				{
				}
				num = (short)333185024;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.UIValue;
			}
			set
			{
				short num = (short)839888709;
				short num2 = num;
				num = (short)1367977797;
				switch (num2 == num)
				{
				}
				num = (short)23592961;
				if (num != 0)
				{
				}
				num = (short)436797440;
				if (num != 0)
				{
				}
				num = (short)1582432256;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.UIValue = value;
			}
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x06007B0F RID: 31503 RVA: 0x00702AB4 File Offset: 0x00700CB4
		public global::AcpBusinessLayer.AcpListField RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071
		{
			get
			{
				short num = (short)36802319;
				short num2 = num;
				num = (short)96046863;
				switch (num2 == num)
				{
				}
				num = (short)1720385537;
				if (num != 0)
				{
				}
				num = (short)1953431552;
				if (num != 0)
				{
				}
				num = (short)1344667648;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071;
			}
		}

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x06007B10 RID: 31504 RVA: 0x00702B64 File Offset: 0x00700D64
		// (set) Token: 0x06007B11 RID: 31505 RVA: 0x00702C1C File Offset: 0x00700E1C
		public bool RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_Applicable
		{
			get
			{
				short num = (short)1702478913;
				short num2 = num;
				num = (short)1152697409;
				switch (num2 == num)
				{
				}
				num = (short)662175745;
				if (num != 0)
				{
				}
				num = (short)994181120;
				if (num != 0)
				{
				}
				num = (short)1297743872;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Applicable;
			}
			set
			{
				short num = (short)2121425646;
				short num2 = num;
				num = (short)241394414;
				switch (num2 == num)
				{
				}
				num = (short)1244921857;
				if (num != 0)
				{
				}
				num = (short)2085093376;
				if (num != 0)
				{
				}
				num = (short)477102080;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Applicable = value;
			}
		}

		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x06007B12 RID: 31506 RVA: 0x00702CD4 File Offset: 0x00700ED4
		// (set) Token: 0x06007B13 RID: 31507 RVA: 0x00702D88 File Offset: 0x00700F88
		public bool RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_Valid
		{
			get
			{
				short num = (short)790304013;
				short num2 = num;
				num = (short)1142953229;
				switch (num2 == num)
				{
				}
				num = (short)600047616;
				if (num != 0)
				{
				}
				num = (short)1558970369;
				if (num != 0)
				{
				}
				num = (short)1416429568;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Valid;
			}
			set
			{
				short num = (short)1370641100;
				short num2 = num;
				num = (short)718820044;
				switch (num2 == num)
				{
				}
				num = (short)721223681;
				if (num != 0)
				{
				}
				num = (short)2098790400;
				if (num != 0)
				{
				}
				num = (short)1048379392;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Valid = value;
			}
		}

		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x06007B14 RID: 31508 RVA: 0x00702E40 File Offset: 0x00701040
		// (set) Token: 0x06007B15 RID: 31509 RVA: 0x00702EF4 File Offset: 0x007010F4
		public bool RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_Visible
		{
			get
			{
				short num = (short)143722629;
				short num2 = num;
				num = (short)846465157;
				switch (num2 == num)
				{
				}
				num = (short)1673986049;
				if (num != 0)
				{
				}
				num = (short)508297216;
				if (num != 0)
				{
				}
				num = (short)946536448;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Visible;
			}
			set
			{
				short num = (short)1053779979;
				short num2 = num;
				num = (short)209872907;
				switch (num2 == num)
				{
				}
				num = (short)764805121;
				if (num != 0)
				{
				}
				num = (short)1954217984;
				if (num != 0)
				{
				}
				num = (short)1442971648;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Visible = value;
			}
		}

		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x06007B16 RID: 31510 RVA: 0x00702FAC File Offset: 0x007011AC
		// (set) Token: 0x06007B17 RID: 31511 RVA: 0x00703060 File Offset: 0x00701260
		public bool RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_Editable
		{
			get
			{
				short num = (short)1435351911;
				short num2 = num;
				num = (short)1762179943;
				switch (num2 == num)
				{
				}
				num = (short)1812987905;
				if (num != 0)
				{
				}
				num = (short)2057437184;
				if (num != 0)
				{
				}
				num = (short)115605504;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Editable;
			}
			set
			{
				short num = (short)1816852173;
				short num2 = num;
				num = (short)1855780557;
				switch (num2 == num)
				{
				}
				num = (short)2046296065;
				if (num != 0)
				{
				}
				num = (short)1777467392;
				if (num != 0)
				{
				}
				num = (short)1399455744;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Editable = value;
			}
		}

		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x06007B18 RID: 31512 RVA: 0x00703114 File Offset: 0x00701314
		internal string RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_UILabel
		{
			get
			{
				short num = (short)921975447;
				short num2 = num;
				num = (short)973879959;
				switch (num2 == num)
				{
				}
				num = (short)2098987008;
				if (num != 0)
				{
				}
				num = (short)1788870657;
				if (num != 0)
				{
				}
				num = (short)1138098176;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.UIName;
			}
		}

		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x06007B19 RID: 31513 RVA: 0x007031C8 File Offset: 0x007013C8
		// (set) Token: 0x06007B1A RID: 31514 RVA: 0x0070327C File Offset: 0x0070147C
		internal bool RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_HiddenStatic
		{
			get
			{
				short num = (short)807862558;
				short num2 = num;
				num = (short)601555230;
				switch (num2 == num)
				{
				}
				num = (short)711000064;
				if (num != 0)
				{
				}
				num = (short)1405288449;
				if (num != 0)
				{
				}
				num = (short)796262400;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic;
			}
			set
			{
				short num = (short)327826355;
				short num2 = num;
				num = (short)523254707;
				switch (num2 == num)
				{
				}
				num = (short)811073537;
				if (num != 0)
				{
				}
				num = (short)606339072;
				if (num != 0)
				{
				}
				num = (short)1275265024;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic = value;
			}
		}

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x06007B1B RID: 31515 RVA: 0x00703330 File Offset: 0x00701530
		// (set) Token: 0x06007B1C RID: 31516 RVA: 0x007033E4 File Offset: 0x007015E4
		internal bool RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_HiddenDynamic
		{
			get
			{
				short num = (short)179602444;
				short num2 = num;
				num = (short)355501068;
				switch (num2 == num)
				{
				}
				num = (short)577896448;
				if (num != 0)
				{
				}
				num = (short)848429057;
				if (num != 0)
				{
				}
				num = (short)1938030592;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenDynamic;
			}
			set
			{
				short num = (short)1945546573;
				short num2 = num;
				num = (short)19902285;
				switch (num2 == num)
				{
				}
				num = (short)783613953;
				if (num != 0)
				{
				}
				num = (short)239075328;
				if (num != 0)
				{
				}
				num = (short)306118656;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x06007B1D RID: 31517 RVA: 0x00703498 File Offset: 0x00701698
		public bool RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071_HasDiffs
		{
			get
			{
				short num = (short)1264285908;
				short num2 = num;
				num = (short)1368815828;
				switch (num2 == num)
				{
				}
				num = (short)132382721;
				if (num != 0)
				{
				}
				num = (short)1925709824;
				if (num != 0)
				{
				}
				num = (short)950009856;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonFeature_A41071._HasDiffs;
			}
		}

		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x06007B1E RID: 31518 RVA: 0x0070354C File Offset: 0x0070174C
		// (set) Token: 0x06007B1F RID: 31519 RVA: 0x00703600 File Offset: 0x00701800
		public int RadErgCtrlKeypadGeneralKeypadButtonIndex_41415Value
		{
			get
			{
				short num = (short)1101464107;
				short num2 = num;
				num = (short)1871446571;
				switch (num2 == num)
				{
				}
				num = (short)2141650945;
				if (num != 0)
				{
				}
				num = (short)1877409792;
				if (num != 0)
				{
				}
				num = (short)974979072;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.Value;
			}
			set
			{
				short num = (short)767861072;
				short num2 = num;
				num = (short)1539940688;
				switch (num2 == num)
				{
				}
				num = (short)27721729;
				if (num != 0)
				{
				}
				num = (short)1901920256;
				if (num != 0)
				{
				}
				num = (short)1340932096;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.Value = value;
			}
		}

		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x06007B20 RID: 31520 RVA: 0x007036B4 File Offset: 0x007018B4
		// (set) Token: 0x06007B21 RID: 31521 RVA: 0x0070376C File Offset: 0x0070196C
		public string RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue
		{
			get
			{
				short num = (short)1313165057;
				short num2 = num;
				num = (short)1513246465;
				switch (num2 == num)
				{
				}
				num = (short)68288513;
				if (num != 0)
				{
				}
				num = (short)1418133504;
				if (num != 0)
				{
				}
				num = (short)2074738688;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.UIValue;
			}
			set
			{
				short num = (short)625993861;
				short num2 = num;
				num = (short)88598661;
				switch (num2 == num)
				{
				}
				num = (short)977862657;
				if (num != 0)
				{
				}
				num = (short)344457216;
				if (num != 0)
				{
				}
				num = (short)53215232;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.UIValue = value;
			}
		}

		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x06007B22 RID: 31522 RVA: 0x00703824 File Offset: 0x00701A24
		public global::AcpBusinessLayer.AcpRecRefField RadErgCtrlKeypadGeneralKeypadButtonIndex_41415
		{
			get
			{
				short num = (short)2101666662;
				short num2 = num;
				num = (short)1133372262;
				switch (num2 == num)
				{
				}
				num = (short)1207173121;
				if (num != 0)
				{
				}
				num = (short)32702464;
				if (num != 0)
				{
				}
				num = (short)2088173568;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415;
			}
		}

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x06007B23 RID: 31523 RVA: 0x007038D0 File Offset: 0x00701AD0
		// (set) Token: 0x06007B24 RID: 31524 RVA: 0x00703988 File Offset: 0x00701B88
		public bool RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_Applicable
		{
			get
			{
				short num = (short)1976517520;
				short num2 = num;
				num = (short)1557021584;
				switch (num2 == num)
				{
				}
				num = (short)680329217;
				if (num != 0)
				{
				}
				num = (short)1812463616;
				if (num != 0)
				{
				}
				num = (short)1219756032;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.Applicable;
			}
			set
			{
				short num = (short)1347040783;
				short num2 = num;
				num = (short)1961440783;
				switch (num2 == num)
				{
				}
				num = (short)114688001;
				if (num != 0)
				{
				}
				num = (short)1144717312;
				if (num != 0)
				{
				}
				num = (short)230359040;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.Applicable = value;
			}
		}

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x06007B25 RID: 31525 RVA: 0x00703A40 File Offset: 0x00701C40
		// (set) Token: 0x06007B26 RID: 31526 RVA: 0x00703AF4 File Offset: 0x00701CF4
		public bool RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_Valid
		{
			get
			{
				short num = (short)1829057412;
				short num2 = num;
				num = (short)2015245188;
				switch (num2 == num)
				{
				}
				num = (short)334757888;
				if (num != 0)
				{
				}
				num = (short)1827012609;
				if (num != 0)
				{
				}
				num = (short)195362816;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.Valid;
			}
			set
			{
				short num = (short)978596351;
				short num2 = num;
				num = (short)1209872895;
				switch (num2 == num)
				{
				}
				num = (short)1101529088;
				if (num != 0)
				{
				}
				num = (short)757202945;
				if (num != 0)
				{
				}
				num = (short)535691264;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.Valid = value;
			}
		}

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x06007B27 RID: 31527 RVA: 0x00703BAC File Offset: 0x00701DAC
		// (set) Token: 0x06007B28 RID: 31528 RVA: 0x00703C60 File Offset: 0x00701E60
		public bool RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_Visible
		{
			get
			{
				short num = (short)822844367;
				short num2 = num;
				num = (short)604543951;
				switch (num2 == num)
				{
				}
				num = (short)870645761;
				if (num != 0)
				{
				}
				num = (short)1189937152;
				if (num != 0)
				{
				}
				num = (short)206897152;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.Visible;
			}
			set
			{
				short num = (short)1048379393;
				if (num != 0)
				{
				}
				num = (short)1469926517;
				short num2 = num;
				num = (short)1888767093;
				switch (num2 == num)
				{
				}
				num = (short)2140405760;
				if (num != 0)
				{
				}
				num = (short)725942272;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.Visible = value;
			}
		}

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x06007B29 RID: 31529 RVA: 0x00703D18 File Offset: 0x00701F18
		// (set) Token: 0x06007B2A RID: 31530 RVA: 0x00703DCC File Offset: 0x00701FCC
		public bool RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_Editable
		{
			get
			{
				short num = (short)415947875;
				short num2 = num;
				num = (short)1081334883;
				switch (num2 == num)
				{
				}
				num = (short)1209532417;
				if (num != 0)
				{
				}
				num = (short)531038208;
				if (num != 0)
				{
				}
				num = (short)613744640;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.Editable;
			}
			set
			{
				short num = (short)1644023232;
				short num2 = num;
				num = (short)1530383808;
				switch (num2 == num)
				{
				}
				num = (short)322502656;
				if (num != 0)
				{
				}
				num = (short)1409744897;
				if (num != 0)
				{
				}
				num = (short)2043150336;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.Editable = value;
			}
		}

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x06007B2B RID: 31531 RVA: 0x00703E84 File Offset: 0x00702084
		internal string RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_UILabel
		{
			get
			{
				short num = (short)1896251442;
				short num2 = num;
				num = (short)849838130;
				switch (num2 == num)
				{
				}
				num = (short)830275584;
				if (num != 0)
				{
				}
				num = (short)883949569;
				if (num != 0)
				{
				}
				num = (short)1287913472;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.UIName;
			}
		}

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x06007B2C RID: 31532 RVA: 0x00703F38 File Offset: 0x00702138
		// (set) Token: 0x06007B2D RID: 31533 RVA: 0x00703FEC File Offset: 0x007021EC
		internal bool RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_HiddenStatic
		{
			get
			{
				short num = (short)268133202;
				short num2 = num;
				num = (short)698573650;
				switch (num2 == num)
				{
				}
				num = (short)1414004737;
				if (num != 0)
				{
				}
				num = (short)200540160;
				if (num != 0)
				{
				}
				num = (short)2060582912;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.HiddenStatic;
			}
			set
			{
				short num = (short)1693414740;
				short num2 = num;
				num = (short)1702065492;
				switch (num2 == num)
				{
				}
				num = (short)1146093569;
				if (num != 0)
				{
				}
				num = (short)1604780032;
				if (num != 0)
				{
				}
				num = (short)666107904;
				short num3 = num;
				this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.HiddenStatic = value;
			}
		}

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x06007B2E RID: 31534 RVA: 0x007040A0 File Offset: 0x007022A0
		// (set) Token: 0x06007B2F RID: 31535 RVA: 0x00704154 File Offset: 0x00702354
		internal bool RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_HiddenDynamic
		{
			get
			{
				short num = (short)1140513403;
				short num2 = num;
				num = (short)1643108987;
				switch (num2 == num)
				{
				}
				num = (short)395116545;
				if (num != 0)
				{
				}
				num = (short)2092957696;
				if (num != 0)
				{
				}
				num = (short)378208256;
				short num3 = num;
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.HiddenDynamic;
			}
			set
			{
				short num = (short)475594753;
				if (num != 0)
				{
				}
				num = (short)211554473;
				short num2 = num;
				num = (short)1165234345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270467072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1755185152;
				if (num != 0)
				{
				}
				this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x06007B30 RID: 31536 RVA: 0x00704208 File Offset: 0x00702408
		public bool RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_HasDiffs
		{
			get
			{
				short num = (short)456567497;
				short num2 = num;
				num = (short)1693231817;
				switch (num2 == num)
				{
				}
				num = (short)1907163136;
				short num3 = num;
				num = (short)314834945;
				if (num != 0)
				{
				}
				num = (short)244449280;
				if (num != 0)
				{
				}
				return this.radErgCtrlKeypadGeneralKeypadButtonIndex_41415._HasDiffs;
			}
		}

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x06007B31 RID: 31537 RVA: 0x007042BC File Offset: 0x007024BC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)172998823;
				short num2 = num;
				num = (short)2129707175;
				switch (num2 == num)
				{
				}
				num = (short)38141952;
				short num3 = num;
				num = (short)1572798465;
				if (num != 0)
				{
				}
				num = (short)2052587520;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x06007B32 RID: 31538 RVA: 0x00704378 File Offset: 0x00702578
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)1909070317;
				short num2 = num;
				num = (short)144316909;
				switch (num2 == num)
				{
				}
				num = (short)480772096;
				short num3 = num;
				num = (short)1559429121;
				if (num != 0)
				{
				}
				num = (short)438763520;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x00704434 File Offset: 0x00702634
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					num2 = (short)240451585;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1654325248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1573223176;
					short num3 = num2;
					num2 = (short)1753512712;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_46;
					default:
						num2 = (short)1414791168;
						if (num2 != 0)
						{
						}
						num2 = (short)791347201;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
				{
					num2 = (short)2017787904;
					short num4 = num2;
					num2 = (short)2025455618;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (base.ParentRecset != null)
					{
						goto IL_46;
					}
					return result;
				}
				goto IL_24;
				IL_46:
				num2 = (short)50790403;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)463929348;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040035E5 RID: 13797
		private global::AcpBusinessLayer.AcpField<string> radErgCtrlKeypadGeneralKeypadButtonName_A41069;

		// Token: 0x040035E6 RID: 13798
		private global::AcpBusinessLayer.AcpListField radErgCtrlKeypadGeneralKeypadBCO_A41070;

		// Token: 0x040035E7 RID: 13799
		private global::AcpBusinessLayer.AcpListField radErgCtrlKeypadGeneralKeypadButtonFeature_A41071;

		// Token: 0x040035E8 RID: 13800
		private global::AcpBusinessLayer.AcpRecRefField radErgCtrlKeypadGeneralKeypadButtonIndex_41415;
	}
}
