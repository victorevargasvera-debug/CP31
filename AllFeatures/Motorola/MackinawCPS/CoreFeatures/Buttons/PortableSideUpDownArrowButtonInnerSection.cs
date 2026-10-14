using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000418 RID: 1048
	[global::System.Serializable]
	public class PortableSideUpDownArrowButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008F84 RID: 36740 RVA: 0x00875394 File Offset: 0x00873594
		public PortableSideUpDownArrowButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008F85 RID: 36741 RVA: 0x008753B0 File Offset: 0x008735B0
		protected PortableSideUpDownArrowButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x008753C8 File Offset: 0x008735C8
		public override void Init()
		{
			int a_ = 4;
			short num = (short)952218875;
			short num2 = num;
			num = (short)1692447995;
			switch (num2 == num)
			{
			}
			num = (short)498991105;
			if (num != 0)
			{
			}
			num = (short)1468858368;
			short num3 = num;
			num = (short)1586036736;
			if (num != 0)
			{
			}
			this.btnSideArrowButtonName_A41567 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPARROW, this, global::AllFeatures.CodeplugGuid.b("蟄돆ꟈ飊꓌ꯎ듐鋒꟔ꗖ뛘곚鿜꫞闠韢諤触꟨諪胬諮껰닲쇴웶쳸췺쫼", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.btnSideArrowButtonName_A41567.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnSideArrowButtonName_A41567.DataTransferOrder = -1;
			this.btnSideUpDownArrowButtonPrimaryFunction_A41568 = new global::AcpBusinessLayer.AcpSparseLOVField(64, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnSideUpDownArrowButtonPrimaryFunction_A41568LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnSideUpDownArrowButtonPrimaryFunction_A41568LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟄돆ꟈ飊꓌ꯎ듐蛒ꗔ鏖뛘곚돜點鏠釢諤郦ꯨ黪駬鯮黰鷲ꗴ藶郸雺鳼跾砀䔂瀄椆樈缊搌怎缐䰒吔⌖⠘⸚⬜✞", a_), global::CommonResources.AcgResources.ID_PRIMARYFUNCTION, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnSideUpDownArrowButtonPrimaryFunction_A41568LovStrs);
			this.btnSideUpDownArrowButtonPrimaryFunction_A41568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnSideUpDownArrowButtonPrimaryFunction_A41568.DataTransferOrder = 155;
			this.btnSideUpDownArrowButtonPrimaryFunction_A41568.ValidateAcrossRecset = true;
			this.btnSideUpDownArrowButtonSecondaryFunction_A41592 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnSideUpDownArrowButtonSecondaryFunction_A41592LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnSideUpDownArrowButtonSecondaryFunction_A41592LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟄돆ꟈ飊꓌ꯎ듐蛒ꗔ鏖뛘곚돜點鏠釢諤郦ꯨ黪駬鯮黰鷲꛴鋶髸铺鏼鯾怀焂簄䄆簈攊渌笎砐簒笔䠖堘⼚Ⱌ⨞ᠠᄢ", a_), global::CommonResources.AcgResources.ID_SECONDARYFUNCTION, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnSideUpDownArrowButtonSecondaryFunction_A41592LovStrs);
			this.btnSideUpDownArrowButtonSecondaryFunction_A41592.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnSideUpDownArrowButtonSecondaryFunction_A41592.DataTransferOrder = 157;
			this.btnSideUpDownArrowButtonSecondaryFunction_A41592.ValidateAcrossRecset = true;
			this.btnSideUpDownArrowButtonMFBBCO_A41633 = new global::AcpBusinessLayer.AcpSparseLOVField(99, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnSideUpDownArrowButtonMFBBCO_A41633LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnSideUpDownArrowButtonMFBBCO_A41633LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟄돆ꟈ飊꓌ꯎ듐蛒ꗔ鏖뛘곚돜點鏠釢諤郦ꯨ黪駬鯮黰鷲룴뇶미맺뻼냾帀䈂㄄㘆㼈㠊㸌", a_), global::CommonResources.AcgResources.ID_MFBBCO, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnSideUpDownArrowButtonMFBBCO_A41633LovStrs);
			this.btnSideUpDownArrowButtonMFBBCO_A41633.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.btnSideUpDownArrowButtonMFBBCO_A41633.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闄꣆믈뿊곌귎뷐뛒蓖냘뿚룜￞든鏢엤ꏦ蛨鳪菬쿮냰臲蟴飶軸\udbfa뿼諾甀眂樄椆", a_);
			base.Id = 10746;
			base.UIName = global::CommonResources.AcgResources.ID_PORTABLESIDEUPDOWNARROWBUTTON;
			base.DataTransferOrder = 153;
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x008755F8 File Offset: 0x008737F8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)860028933;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.btnSideUpDownArrowButtonSecondaryFunction_A41592 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnSideUpDownArrowButtonSecondaryFunction_A41592LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnSideUpDownArrowButtonSecondaryFunction_A41592LovStrs), this, global::AllFeatures.CodeplugGuid.b("郑ꃓ룕诗동룛믝뗟鋡ꃣ觥鿧蓩귫鳭苯鷱菳듵跷軹裻釽滿儁愃攅朇搉栋漍戏欑刓挕瘗礙栛眝伟䰡笣朥ᰧᬩᤫᜭȯ", a_), global::CommonResources.AcgResources.ID_SECONDARYFUNCTION, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnSideUpDownArrowButtonSecondaryFunction_A41592LovStrs);
					this.btnSideUpDownArrowButtonSecondaryFunction_A41592.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnSideUpDownArrowButtonSecondaryFunction_A41592.DataTransferOrder = 157;
					this.btnSideUpDownArrowButtonSecondaryFunction_A41592.ValidateAcrossRecset = true;
					num = (short)1910571009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1FB;
				case 2:
					goto IL_284;
				case 3:
					num = (short)1035862027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_339;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				case 6:
					if (producerFields != null)
					{
						num = (short)1899298819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_456;
				case 7:
				{
					num = (short)1040920190;
					short num3 = num;
					num = (short)759639678;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)815071232;
						if (num != 0)
						{
						}
						num = (short)642252801;
						if (num != 0)
						{
						}
						this.btnSideUpDownArrowButtonPrimaryFunction_A41568 = new global::AcpBusinessLayer.AcpSparseLOVField(64, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnSideUpDownArrowButtonPrimaryFunction_A41568LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnSideUpDownArrowButtonPrimaryFunction_A41568LovStrs), this, global::AllFeatures.CodeplugGuid.b("郑ꃓ룕诗동룛믝뗟鋡ꃣ觥鿧蓩귫鳭苯鷱菳듵跷軹裻釽滿刁瘃漅攇欉縋眍嘏朑稓甕気猙猛瀝缟挡ဣᜥᴧᰩᐫ", a_), global::CommonResources.AcgResources.ID_PRIMARYFUNCTION, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnSideUpDownArrowButtonPrimaryFunction_A41568LovStrs);
						this.btnSideUpDownArrowButtonPrimaryFunction_A41568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.btnSideUpDownArrowButtonPrimaryFunction_A41568.DataTransferOrder = 155;
						this.btnSideUpDownArrowButtonPrimaryFunction_A41568.ValidateAcrossRecset = true;
						num = (short)450953218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					goto IL_334;
				case 9:
					num = (short)1939668998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郑ꃓ룕诗동룛믝뗟鋡ꃣ觥鿧蓩귫鳭苯鷱菳듵跷軹裻釽滿儁愃攅朇搉栋漍戏欑刓挕瘗礙栛眝伟䰡笣朥ᰧᬩᤫᜭȯ", a_)))
					{
						num = (short)898891776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郑ꃓ룕诗동룛믝ꇟ郡難觥鿧꣩駫髭蓯鷱髳룵駷韹駻ꇽ䇿㘁㔃㌅㸇㴉", a_)))
					{
						num = (short)967245836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_339;
				case 12:
					this.btnSideArrowButtonName_A41567 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPARROW, this, global::AllFeatures.CodeplugGuid.b("郑ꃓ룕诗동룛믝ꇟ郡難觥鿧꣩駫髭蓯鷱髳룵駷韹駻ꇽ䇿㘁㔃㌅㸇㴉", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.btnSideArrowButtonName_A41567.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnSideArrowButtonName_A41567.DataTransferOrder = -1;
					num = (short)2055208964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郑ꃓ룕诗동룛믝뗟鋡ꃣ觥鿧蓩귫鳭苯鷱菳듵跷軹裻釽滿刁瘃漅攇欉縋眍嘏朑稓甕気猙猛瀝缟挡ဣᜥᴧᰩᐫ", a_)))
					{
						num = (short)1256718343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_284;
				case 14:
					this.btnSideUpDownArrowButtonMFBBCO_A41633 = new global::AcpBusinessLayer.AcpSparseLOVField(99, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnSideUpDownArrowButtonMFBBCO_A41633LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnSideUpDownArrowButtonMFBBCO_A41633LovStrs), this, global::AllFeatures.CodeplugGuid.b("郑ꃓ룕诗동룛믝뗟鋡ꃣ觥鿧蓩귫鳭苯鷱菳듵跷軹裻釽滿企䈃䐅䨇䤉䌋儍儏☑┓―⬗⤙", a_), global::CommonResources.AcgResources.ID_MFBBCO, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnSideUpDownArrowButtonMFBBCO_A41633LovStrs);
					this.btnSideUpDownArrowButtonMFBBCO_A41633.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.btnSideUpDownArrowButtonMFBBCO_A41633.DataTransferOrder = -1;
					num = (short)2029322248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郑ꃓ룕诗동룛믝뗟鋡ꃣ觥鿧蓩귫鳭苯鷱菳듵跷軹裻釽滿企䈃䐅䨇䤉䌋儍儏☑┓―⬗⤙", a_)))
					{
						num = (short)1004208142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_456;
				}
				IL_6F:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)734134281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1FB:
				num = (short)510590991;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_284:
				num = (short)1379401738;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_339:
				num = (short)16580608;
				short num4 = num;
				num = (short)478412813;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_334:
			IL_456:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苑믓ꓕ곗믙뻛닝藟싡럣迥賧迩쳫믭胯틱냳駵迷铹\udcfb뿽狿瀁欃焅⠇䠉礋稍搏紑稓", a_);
			base.Id = 10746;
			base.UIName = global::CommonResources.AcgResources.ID_PORTABLESIDEUPDOWNARROWBUTTON;
			base.DataTransferOrder = 153;
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x00875A90 File Offset: 0x00873C90
		public override void PopulateReferences()
		{
			short num = (short)664010752;
			short num2 = num;
			num = (short)4325377;
			if (num != 0)
			{
			}
			num = (short)1285304355;
			short num3 = num;
			num = (short)1996304419;
			switch (num3 == num)
			{
			}
			num = (short)1166475264;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x00875B38 File Offset: 0x00873D38
		public override void DropReferences()
		{
			short num = (short)1150812160;
			short num2 = num;
			num = (short)871769599;
			short num3 = num;
			num = (short)1774593535;
			switch (num3 == num)
			{
			}
			num = (short)1785069569;
			if (num != 0)
			{
			}
			num = (short)1312292864;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x00875BE4 File Offset: 0x00873DE4
		public override void SetConstraints()
		{
			short num = (short)695795712;
			short num2 = num;
			num = (short)1638631573;
			short num3 = num;
			num = (short)280332437;
			switch (num3 == num)
			{
			}
			num = (short)1129381888;
			if (num != 0)
			{
			}
			num = (short)1522991105;
			if (num != 0)
			{
			}
			this.btnSideArrowButtonName_A41567.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.btnSideUpDownArrowButtonPrimaryFunction_A41568.ValidateAcrossRecset = true;
			this.btnSideUpDownArrowButtonPrimaryFunction_A41568.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.ConSideArrowButtonPrimaryIsValid);
			this.btnSideUpDownArrowButtonPrimaryFunction_A41568.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.ConSideArrowDownButtonIsEdit);
			this.btnSideUpDownArrowButtonPrimaryFunction_A41568.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.conSetSideArrowButtonPrimaryFunctionDownButton);
			this.btnSideUpDownArrowButtonSecondaryFunction_A41592.ValidateAcrossRecset = true;
			this.btnSideUpDownArrowButtonSecondaryFunction_A41592.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.ConSideArrowButtonSecondaryIsValid);
			this.btnSideUpDownArrowButtonSecondaryFunction_A41592.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.ConSideArrowDownButtonIsEdit);
			this.btnSideUpDownArrowButtonSecondaryFunction_A41592.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.conSetSideArrowButtonSecondaryFunction);
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x00875D48 File Offset: 0x00873F48
		public override void SetupDependencies()
		{
			short num = (short)98172928;
			short num2 = num;
			num = (short)716177409;
			if (num != 0)
			{
			}
			num = (short)523250880;
			short num3 = num;
			num = (short)933899456;
			switch (num3 == num)
			{
			}
			num = (short)1698693120;
			if (num != 0)
			{
			}
			this.btnSideUpDownArrowButtonSecondaryFunction_A41592.AddDependentObject(this.btnSideUpDownArrowButtonPrimaryFunction_A41568);
			this.btnSideUpDownArrowButtonPrimaryFunction_A41568.AddDependentObject(this.btnSideUpDownArrowButtonSecondaryFunction_A41592);
		}

		// Token: 0x1700487B RID: 18555
		// (get) Token: 0x06008F8C RID: 36748 RVA: 0x00875E18 File Offset: 0x00874018
		public bool HasDiffs
		{
			get
			{
				short num = (short)826736640;
				short num2 = num;
				num = (short)1364204928;
				short num3 = num;
				num = (short)724639104;
				switch (num3 == num)
				{
				}
				num = (short)1960837121;
				if (num != 0)
				{
				}
				num = (short)245170176;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700487C RID: 18556
		// (get) Token: 0x06008F8D RID: 36749 RVA: 0x00875EC8 File Offset: 0x008740C8
		// (set) Token: 0x06008F8E RID: 36750 RVA: 0x00875F7C File Offset: 0x0087417C
		public string BtnSideArrowButtonName_A41567Value
		{
			get
			{
				short num = (short)1941766144;
				short num2 = num;
				num = (short)1889470551;
				short num3 = num;
				num = (short)1705773143;
				switch (num3 == num)
				{
				}
				num = (short)899678209;
				if (num != 0)
				{
				}
				num = (short)704184320;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567.Value;
			}
			set
			{
				short num = (short)1342767104;
				short num2 = num;
				num = (short)499771388;
				short num3 = num;
				num = (short)22079484;
				switch (num3 == num)
				{
				}
				num = (short)1492320257;
				if (num != 0)
				{
				}
				num = (short)869793792;
				if (num != 0)
				{
				}
				this.btnSideArrowButtonName_A41567.Value = value;
			}
		}

		// Token: 0x1700487D RID: 18557
		// (get) Token: 0x06008F8F RID: 36751 RVA: 0x00876034 File Offset: 0x00874234
		public global::AcpBusinessLayer.AcpField<string> BtnSideArrowButtonName_A41567
		{
			get
			{
				short num = (short)1381761024;
				short num2 = num;
				num = (short)1554236703;
				short num3 = num;
				num = (short)940492063;
				switch (num3 == num)
				{
				}
				num = (short)981008385;
				if (num != 0)
				{
				}
				num = (short)1798569984;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567;
			}
		}

		// Token: 0x1700487E RID: 18558
		// (get) Token: 0x06008F90 RID: 36752 RVA: 0x008760E4 File Offset: 0x008742E4
		// (set) Token: 0x06008F91 RID: 36753 RVA: 0x00876198 File Offset: 0x00874398
		public string BtnSideArrowButtonName_A41567_UIValue
		{
			get
			{
				short num = (short)1363017728;
				short num2 = num;
				num = (short)1595664724;
				short num3 = num;
				num = (short)1766517076;
				switch (num3 == num)
				{
				}
				num = (short)1583415296;
				if (num != 0)
				{
				}
				num = (short)586874881;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567.Value;
			}
			set
			{
				short num = (short)1123745792;
				short num2 = num;
				num = (short)1122238465;
				if (num != 0)
				{
				}
				num = (short)2103590504;
				short num3 = num;
				num = (short)2114862696;
				switch (num3 == num)
				{
				}
				num = (short)1758593024;
				if (num != 0)
				{
				}
				this.btnSideArrowButtonName_A41567.Value = value;
			}
		}

		// Token: 0x1700487F RID: 18559
		// (get) Token: 0x06008F92 RID: 36754 RVA: 0x0087624C File Offset: 0x0087444C
		// (set) Token: 0x06008F93 RID: 36755 RVA: 0x00876300 File Offset: 0x00874500
		public bool BtnSideArrowButtonName_A41567_Applicable
		{
			get
			{
				short num = (short)1003094016;
				short num2 = num;
				num = (short)1820139280;
				short num3 = num;
				num = (short)1145446160;
				switch (num3 == num)
				{
				}
				num = (short)816578561;
				if (num != 0)
				{
				}
				num = (short)858456064;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567.Applicable;
			}
			set
			{
				short num = (short)1929510912;
				short num2 = num;
				num = (short)1647057217;
				short num3 = num;
				num = (short)2120292673;
				switch (num3 == num)
				{
				}
				num = (short)1861615616;
				if (num != 0)
				{
				}
				num = (short)706412545;
				if (num != 0)
				{
				}
				this.btnSideArrowButtonName_A41567.Applicable = value;
			}
		}

		// Token: 0x17004880 RID: 18560
		// (get) Token: 0x06008F94 RID: 36756 RVA: 0x008763B4 File Offset: 0x008745B4
		// (set) Token: 0x06008F95 RID: 36757 RVA: 0x00876468 File Offset: 0x00874668
		public bool BtnSideArrowButtonName_A41567_Valid
		{
			get
			{
				short num = (short)402391040;
				short num2 = num;
				num = (short)363954112;
				short num3 = num;
				num = (short)980320192;
				switch (num3 == num)
				{
				}
				num = (short)1377304577;
				if (num != 0)
				{
				}
				num = (short)1612644352;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567.Valid;
			}
			set
			{
				short num = (short)1817247744;
				short num2 = num;
				num = (short)1883308033;
				if (num != 0)
				{
				}
				num = (short)141692375;
				short num3 = num;
				num = (short)493227479;
				switch (num3 == num)
				{
				}
				num = (short)1695219712;
				if (num != 0)
				{
				}
				this.btnSideArrowButtonName_A41567.Valid = value;
			}
		}

		// Token: 0x17004881 RID: 18561
		// (get) Token: 0x06008F96 RID: 36758 RVA: 0x00876520 File Offset: 0x00874720
		// (set) Token: 0x06008F97 RID: 36759 RVA: 0x008765D4 File Offset: 0x008747D4
		public bool BtnSideArrowButtonName_A41567_Visible
		{
			get
			{
				short num = (short)19136512;
				short num2 = num;
				num = (short)1288407560;
				short num3 = num;
				num = (short)193038856;
				switch (num3 == num)
				{
				}
				num = (short)1104412673;
				if (num != 0)
				{
				}
				num = (short)64421888;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567.Visible;
			}
			set
			{
				short num = (short)1089077248;
				short num2 = num;
				num = (short)154787286;
				short num3 = num;
				num = (short)1983569366;
				switch (num3 == num)
				{
				}
				num = (short)482213889;
				if (num != 0)
				{
				}
				num = (short)682033152;
				if (num != 0)
				{
				}
				this.btnSideArrowButtonName_A41567.Visible = value;
			}
		}

		// Token: 0x17004882 RID: 18562
		// (get) Token: 0x06008F98 RID: 36760 RVA: 0x0087668C File Offset: 0x0087488C
		// (set) Token: 0x06008F99 RID: 36761 RVA: 0x00876744 File Offset: 0x00874944
		public bool BtnSideArrowButtonName_A41567_Editable
		{
			get
			{
				short num = (short)2135293952;
				short num2 = num;
				num = (short)520721709;
				short num3 = num;
				num = (short)2086573357;
				switch (num3 == num)
				{
				}
				num = (short)1406861313;
				if (num != 0)
				{
				}
				num = (short)1476067328;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567.Editable;
			}
			set
			{
				short num = (short)1026424832;
				short num2 = num;
				num = (short)1923088385;
				if (num != 0)
				{
				}
				num = (short)1145074554;
				short num3 = num;
				num = (short)1101230970;
				switch (num3 == num)
				{
				}
				num = (short)156893184;
				if (num != 0)
				{
				}
				this.btnSideArrowButtonName_A41567.Editable = value;
			}
		}

		// Token: 0x17004883 RID: 18563
		// (get) Token: 0x06008F9A RID: 36762 RVA: 0x008767FC File Offset: 0x008749FC
		internal string BtnSideArrowButtonName_A41567_UILabel
		{
			get
			{
				short num = (short)297861120;
				short num2 = num;
				num = (short)1448009884;
				short num3 = num;
				num = (short)395174044;
				switch (num3 == num)
				{
				}
				num = (short)1285685248;
				if (num != 0)
				{
				}
				num = (short)50528257;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567.UIName;
			}
		}

		// Token: 0x17004884 RID: 18564
		// (get) Token: 0x06008F9B RID: 36763 RVA: 0x008768B4 File Offset: 0x00874AB4
		// (set) Token: 0x06008F9C RID: 36764 RVA: 0x00876968 File Offset: 0x00874B68
		internal bool BtnSideArrowButtonName_A41567_HiddenStatic
		{
			get
			{
				short num = (short)1380712448;
				short num2 = num;
				num = (short)752928250;
				short num3 = num;
				num = (short)1234617850;
				switch (num3 == num)
				{
				}
				num = (short)1511129089;
				if (num != 0)
				{
				}
				num = (short)952631296;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567.HiddenStatic;
			}
			set
			{
				short num = (short)419102720;
				short num2 = num;
				num = (short)557195433;
				short num3 = num;
				num = (short)95166633;
				switch (num3 == num)
				{
				}
				num = (short)318701569;
				if (num != 0)
				{
				}
				num = (short)1455882240;
				if (num != 0)
				{
				}
				this.btnSideArrowButtonName_A41567.HiddenStatic = value;
			}
		}

		// Token: 0x17004885 RID: 18565
		// (get) Token: 0x06008F9D RID: 36765 RVA: 0x00876A20 File Offset: 0x00874C20
		// (set) Token: 0x06008F9E RID: 36766 RVA: 0x00876AD4 File Offset: 0x00874CD4
		internal bool BtnSideArrowButtonName_A41567_HiddenDynamic
		{
			get
			{
				short num = (short)425263104;
				short num2 = num;
				num = (short)1163965090;
				short num3 = num;
				num = (short)42906274;
				switch (num3 == num)
				{
				}
				num = (short)366084097;
				if (num != 0)
				{
				}
				num = (short)1315438592;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567.HiddenDynamic;
			}
			set
			{
				short num = (short)1923874816;
				short num2 = num;
				num = (short)1795212525;
				short num3 = num;
				num = (short)1071826157;
				switch (num3 == num)
				{
				}
				num = (short)1385103361;
				if (num != 0)
				{
				}
				num = (short)1832648704;
				if (num != 0)
				{
				}
				this.btnSideArrowButtonName_A41567.HiddenDynamic = value;
			}
		}

		// Token: 0x17004886 RID: 18566
		// (get) Token: 0x06008F9F RID: 36767 RVA: 0x00876B88 File Offset: 0x00874D88
		public bool BtnSideArrowButtonName_A41567_HasDiffs
		{
			get
			{
				short num = (short)980746240;
				short num2 = num;
				num = (short)1730941234;
				short num3 = num;
				num = (short)636227890;
				switch (num3 == num)
				{
				}
				num = (short)199491585;
				if (num != 0)
				{
				}
				num = (short)1836449792;
				if (num != 0)
				{
				}
				return this.btnSideArrowButtonName_A41567._HasDiffs;
			}
		}

		// Token: 0x17004887 RID: 18567
		// (get) Token: 0x06008FA0 RID: 36768 RVA: 0x00876C3C File Offset: 0x00874E3C
		// (set) Token: 0x06008FA1 RID: 36769 RVA: 0x00876CF4 File Offset: 0x00874EF4
		public int BtnSideUpDownArrowButtonPrimaryFunction_A41568Value
		{
			get
			{
				short num = (short)458358784;
				short num2 = num;
				num = (short)2000397518;
				short num3 = num;
				num = (short)2075763918;
				switch (num3 == num)
				{
				}
				num = (short)102498304;
				if (num != 0)
				{
				}
				num = (short)425984001;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568.Value;
			}
			set
			{
				short num = (short)1650655232;
				short num2 = num;
				num = (short)1701249025;
				if (num != 0)
				{
				}
				num = (short)285530938;
				short num3 = num;
				num = (short)174316346;
				switch (num3 == num)
				{
				}
				num = (short)776470528;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonPrimaryFunction_A41568.Value = value;
			}
		}

		// Token: 0x17004888 RID: 18568
		// (get) Token: 0x06008FA2 RID: 36770 RVA: 0x00876DAC File Offset: 0x00874FAC
		// (set) Token: 0x06008FA3 RID: 36771 RVA: 0x00876E60 File Offset: 0x00875060
		public string BtnSideUpDownArrowButtonPrimaryFunction_A41568_UIValue
		{
			get
			{
				short num = (short)1418395648;
				short num2 = num;
				num = (short)482403694;
				short num3 = num;
				num = (short)1620043118;
				switch (num3 == num)
				{
				}
				num = (short)1473970176;
				if (num != 0)
				{
				}
				num = (short)1125842945;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568.UIValue;
			}
			set
			{
				short num = (short)1266483200;
				short num2 = num;
				num = (short)243712288;
				short num3 = num;
				num = (short)896712992;
				switch (num3 == num)
				{
				}
				num = (short)756088833;
				if (num != 0)
				{
				}
				num = (short)1050083328;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonPrimaryFunction_A41568.UIValue = value;
			}
		}

		// Token: 0x17004889 RID: 18569
		// (get) Token: 0x06008FA4 RID: 36772 RVA: 0x00876F14 File Offset: 0x00875114
		public global::AcpBusinessLayer.AcpListField BtnSideUpDownArrowButtonPrimaryFunction_A41568
		{
			get
			{
				short num = (short)1687945216;
				short num2 = num;
				num = (short)1281884161;
				if (num != 0)
				{
				}
				num = (short)1689459061;
				short num3 = num;
				num = (short)1441339765;
				switch (num3 == num)
				{
				}
				num = (short)875495424;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568;
			}
		}

		// Token: 0x1700488A RID: 18570
		// (get) Token: 0x06008FA5 RID: 36773 RVA: 0x00876FC4 File Offset: 0x008751C4
		// (set) Token: 0x06008FA6 RID: 36774 RVA: 0x00877078 File Offset: 0x00875278
		public bool BtnSideUpDownArrowButtonPrimaryFunction_A41568_Applicable
		{
			get
			{
				short num = (short)138412032;
				short num2 = num;
				num = (short)1056324620;
				short num3 = num;
				num = (short)1185496076;
				switch (num3 == num)
				{
				}
				num = (short)915800064;
				if (num != 0)
				{
				}
				num = (short)356384769;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568.Applicable;
			}
			set
			{
				short num = (short)1352531968;
				short num2 = num;
				num = (short)932184065;
				if (num != 0)
				{
				}
				num = (short)1459837578;
				short num3 = num;
				num = (short)2050316938;
				switch (num3 == num)
				{
				}
				num = (short)1519321088;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonPrimaryFunction_A41568.Applicable = value;
			}
		}

		// Token: 0x1700488B RID: 18571
		// (get) Token: 0x06008FA7 RID: 36775 RVA: 0x00877130 File Offset: 0x00875330
		// (set) Token: 0x06008FA8 RID: 36776 RVA: 0x008771E4 File Offset: 0x008753E4
		public bool BtnSideUpDownArrowButtonPrimaryFunction_A41568_Valid
		{
			get
			{
				short num = (short)1552613376;
				short num2 = num;
				num = (short)171375766;
				short num3 = num;
				num = (short)273022102;
				switch (num3 == num)
				{
				}
				num = (short)264110080;
				if (num != 0)
				{
				}
				num = (short)1129906177;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568.Valid;
			}
			set
			{
				short num = (short)482541568;
				short num2 = num;
				num = (short)2027942316;
				short num3 = num;
				num = (short)1525281196;
				switch (num3 == num)
				{
				}
				num = (short)654573568;
				if (num != 0)
				{
				}
				num = (short)559677441;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonPrimaryFunction_A41568.Valid = value;
			}
		}

		// Token: 0x1700488C RID: 18572
		// (get) Token: 0x06008FA9 RID: 36777 RVA: 0x0087729C File Offset: 0x0087549C
		// (set) Token: 0x06008FAA RID: 36778 RVA: 0x00877354 File Offset: 0x00875554
		public bool BtnSideUpDownArrowButtonPrimaryFunction_A41568_Visible
		{
			get
			{
				short num = (short)152829952;
				short num2 = num;
				num = (short)105015614;
				short num3 = num;
				num = (short)435185982;
				switch (num3 == num)
				{
				}
				num = (short)1145962497;
				if (num != 0)
				{
				}
				num = (short)1653866496;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568.Visible;
			}
			set
			{
				short num = (short)1596850176;
				short num2 = num;
				num = (short)633655351;
				short num3 = num;
				num = (short)1135530039;
				switch (num3 == num)
				{
				}
				num = (short)637403137;
				if (num != 0)
				{
				}
				num = (short)1280180224;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonPrimaryFunction_A41568.Visible = value;
			}
		}

		// Token: 0x1700488D RID: 18573
		// (get) Token: 0x06008FAB RID: 36779 RVA: 0x0087740C File Offset: 0x0087560C
		// (set) Token: 0x06008FAC RID: 36780 RVA: 0x008774C0 File Offset: 0x008756C0
		public bool BtnSideUpDownArrowButtonPrimaryFunction_A41568_Editable
		{
			get
			{
				short num = (short)2110259200;
				short num2 = num;
				num = (short)824197553;
				short num3 = num;
				num = (short)1453212081;
				switch (num3 == num)
				{
				}
				num = (short)1774977025;
				if (num != 0)
				{
				}
				num = (short)1177419776;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568.Editable;
			}
			set
			{
				short num = (short)1434583040;
				short num2 = num;
				num = (short)2090163348;
				short num3 = num;
				num = (short)2087083156;
				switch (num3 == num)
				{
				}
				num = (short)1512767488;
				if (num != 0)
				{
				}
				num = (short)1687945217;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonPrimaryFunction_A41568.Editable = value;
			}
		}

		// Token: 0x1700488E RID: 18574
		// (get) Token: 0x06008FAD RID: 36781 RVA: 0x00877574 File Offset: 0x00875774
		internal string BtnSideUpDownArrowButtonPrimaryFunction_A41568_UILabel
		{
			get
			{
				short num = (short)118292480;
				short num2 = num;
				num = (short)1225966916;
				short num3 = num;
				num = (short)1301464388;
				switch (num3 == num)
				{
				}
				num = (short)2099249153;
				if (num != 0)
				{
				}
				num = (short)1183973376;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568.UIName;
			}
		}

		// Token: 0x1700488F RID: 18575
		// (get) Token: 0x06008FAE RID: 36782 RVA: 0x0087762C File Offset: 0x0087582C
		// (set) Token: 0x06008FAF RID: 36783 RVA: 0x008776E0 File Offset: 0x008758E0
		internal bool BtnSideUpDownArrowButtonPrimaryFunction_A41568_HiddenStatic
		{
			get
			{
				short num = (short)738263040;
				short num2 = num;
				num = (short)1696268509;
				short num3 = num;
				num = (short)1610612957;
				switch (num3 == num)
				{
				}
				num = (short)1912537089;
				if (num != 0)
				{
				}
				num = (short)118620160;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568.HiddenStatic;
			}
			set
			{
				short num = (short)2130116608;
				short num2 = num;
				num = (short)1803182068;
				short num3 = num;
				num = (short)1952473076;
				switch (num3 == num)
				{
				}
				num = (short)1213267969;
				if (num != 0)
				{
				}
				num = (short)966983680;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonPrimaryFunction_A41568.HiddenStatic = value;
			}
		}

		// Token: 0x17004890 RID: 18576
		// (get) Token: 0x06008FB0 RID: 36784 RVA: 0x00877798 File Offset: 0x00875998
		// (set) Token: 0x06008FB1 RID: 36785 RVA: 0x00877850 File Offset: 0x00875A50
		internal bool BtnSideUpDownArrowButtonPrimaryFunction_A41568_HiddenDynamic
		{
			get
			{
				short num = (short)1804075008;
				short num2 = num;
				num = (short)1443248294;
				short num3 = num;
				num = (short)812595366;
				switch (num3 == num)
				{
				}
				num = (short)1090322433;
				if (num != 0)
				{
				}
				num = (short)1798176768;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568.HiddenDynamic;
			}
			set
			{
				short num = (short)1564475392;
				short num2 = num;
				num = (short)660257446;
				short num3 = num;
				num = (short)671464102;
				switch (num3 == num)
				{
				}
				num = (short)156303361;
				if (num != 0)
				{
				}
				num = (short)1175977984;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonPrimaryFunction_A41568.HiddenDynamic = value;
			}
		}

		// Token: 0x17004891 RID: 18577
		// (get) Token: 0x06008FB2 RID: 36786 RVA: 0x00877904 File Offset: 0x00875B04
		public bool BtnSideUpDownArrowButtonPrimaryFunction_A41568_HasDiffs
		{
			get
			{
				short num = (short)633602048;
				short num2 = num;
				num = (short)590001003;
				short num3 = num;
				num = (short)945402731;
				switch (num3 == num)
				{
				}
				num = (short)1380450305;
				if (num != 0)
				{
				}
				num = (short)1887305728;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonPrimaryFunction_A41568._HasDiffs;
			}
		}

		// Token: 0x17004892 RID: 18578
		// (get) Token: 0x06008FB3 RID: 36787 RVA: 0x008779B8 File Offset: 0x00875BB8
		// (set) Token: 0x06008FB4 RID: 36788 RVA: 0x00877A70 File Offset: 0x00875C70
		public int BtnSideUpDownArrowButtonSecondaryFunction_A41592Value
		{
			get
			{
				short num = (short)2144010240;
				short num2 = num;
				num = (short)1502719538;
				short num3 = num;
				num = (short)625847858;
				switch (num3 == num)
				{
				}
				num = (short)1843658753;
				if (num != 0)
				{
				}
				num = (short)1322778624;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592.Value;
			}
			set
			{
				short num = (short)1030034258;
				short num2 = num;
				num = (short)856298322;
				switch (num2 == num)
				{
				}
				num = (short)88408064;
				if (num != 0)
				{
				}
				num = (short)1774387200;
				short num3 = num;
				num = (short)2145452033;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonSecondaryFunction_A41592.Value = value;
			}
		}

		// Token: 0x17004893 RID: 18579
		// (get) Token: 0x06008FB5 RID: 36789 RVA: 0x00877B24 File Offset: 0x00875D24
		// (set) Token: 0x06008FB6 RID: 36790 RVA: 0x00877BD8 File Offset: 0x00875DD8
		public string BtnSideUpDownArrowButtonSecondaryFunction_A41592_UIValue
		{
			get
			{
				short num = (short)123513983;
				short num2 = num;
				num = (short)644525183;
				switch (num2 == num)
				{
				}
				num = (short)772538369;
				if (num != 0)
				{
				}
				num = (short)608108544;
				short num3 = num;
				num = (short)1173094400;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592.UIValue;
			}
			set
			{
				short num = (short)151212843;
				short num2 = num;
				num = (short)1536971563;
				switch (num2 == num)
				{
				}
				num = (short)1210777600;
				if (num != 0)
				{
				}
				num = (short)1194524672;
				short num3 = num;
				num = (short)808255489;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonSecondaryFunction_A41592.UIValue = value;
			}
		}

		// Token: 0x17004894 RID: 18580
		// (get) Token: 0x06008FB7 RID: 36791 RVA: 0x00877C8C File Offset: 0x00875E8C
		public global::AcpBusinessLayer.AcpListField BtnSideUpDownArrowButtonSecondaryFunction_A41592
		{
			get
			{
				short num = (short)457179137;
				if (num != 0)
				{
				}
				num = (short)1459022989;
				short num2 = num;
				num = (short)520940685;
				switch (num2 == num)
				{
				}
				num = (short)306380800;
				short num3 = num;
				num = (short)1747320832;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592;
			}
		}

		// Token: 0x17004895 RID: 18581
		// (get) Token: 0x06008FB8 RID: 36792 RVA: 0x00877D38 File Offset: 0x00875F38
		// (set) Token: 0x06008FB9 RID: 36793 RVA: 0x00877DEC File Offset: 0x00875FEC
		public bool BtnSideUpDownArrowButtonSecondaryFunction_A41592_Applicable
		{
			get
			{
				short num = (short)450176806;
				short num2 = num;
				num = (short)733816614;
				switch (num2 == num)
				{
				}
				num = (short)106758144;
				if (num != 0)
				{
				}
				num = (short)1512505344;
				short num3 = num;
				num = (short)1453391873;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592.Applicable;
			}
			set
			{
				short num = (short)1223530184;
				short num2 = num;
				num = (short)1748145864;
				switch (num2 == num)
				{
				}
				num = (short)1133772801;
				if (num != 0)
				{
				}
				num = (short)219938816;
				short num3 = num;
				num = (short)1269432320;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonSecondaryFunction_A41592.Applicable = value;
			}
		}

		// Token: 0x17004896 RID: 18582
		// (get) Token: 0x06008FBA RID: 36794 RVA: 0x00877EA0 File Offset: 0x008760A0
		// (set) Token: 0x06008FBB RID: 36795 RVA: 0x00877F50 File Offset: 0x00876150
		public bool BtnSideUpDownArrowButtonSecondaryFunction_A41592_Valid
		{
			get
			{
				short num = (short)638197529;
				short num2 = num;
				num = (short)1053171481;
				switch (num2 == num)
				{
				}
				num = (short)2107768833;
				if (num != 0)
				{
				}
				num = (short)308936704;
				short num3 = num;
				num = (short)789774336;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592.Valid;
			}
			set
			{
				short num = (short)2055998383;
				short num2 = num;
				num = (short)1577913263;
				switch (num2 == num)
				{
				}
				num = (short)59834368;
				if (num != 0)
				{
				}
				num = (short)866648064;
				short num3 = num;
				num = (short)120520705;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonSecondaryFunction_A41592.Valid = value;
			}
		}

		// Token: 0x17004897 RID: 18583
		// (get) Token: 0x06008FBC RID: 36796 RVA: 0x00878004 File Offset: 0x00876204
		// (set) Token: 0x06008FBD RID: 36797 RVA: 0x008780B8 File Offset: 0x008762B8
		public bool BtnSideUpDownArrowButtonSecondaryFunction_A41592_Visible
		{
			get
			{
				short num = (short)1378260054;
				short num2 = num;
				num = (short)151098454;
				switch (num2 == num)
				{
				}
				num = (short)366870529;
				if (num != 0)
				{
				}
				num = (short)74907648;
				short num3 = num;
				num = (short)44302336;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592.Visible;
			}
			set
			{
				short num = (short)497282817;
				short num2 = num;
				num = (short)1436413697;
				switch (num2 == num)
				{
				}
				num = (short)1310130177;
				if (num != 0)
				{
				}
				num = (short)1469251584;
				short num3 = num;
				num = (short)1296367616;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonSecondaryFunction_A41592.Visible = value;
			}
		}

		// Token: 0x17004898 RID: 18584
		// (get) Token: 0x06008FBE RID: 36798 RVA: 0x0087816C File Offset: 0x0087636C
		// (set) Token: 0x06008FBF RID: 36799 RVA: 0x00878220 File Offset: 0x00876420
		public bool BtnSideUpDownArrowButtonSecondaryFunction_A41592_Editable
		{
			get
			{
				short num = (short)1162546645;
				short num2 = num;
				num = (short)738725333;
				switch (num2 == num)
				{
				}
				num = (short)857210880;
				if (num != 0)
				{
				}
				num = (short)1293942784;
				short num3 = num;
				num = (short)1907818497;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592.Editable;
			}
			set
			{
				short num = (short)2111405440;
				short num2 = num;
				num = (short)528907648;
				switch (num2 == num)
				{
				}
				num = (short)1720320001;
				if (num != 0)
				{
				}
				num = (short)967376896;
				short num3 = num;
				num = (short)728760320;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonSecondaryFunction_A41592.Editable = value;
			}
		}

		// Token: 0x17004899 RID: 18585
		// (get) Token: 0x06008FC0 RID: 36800 RVA: 0x008782D4 File Offset: 0x008764D4
		internal string BtnSideUpDownArrowButtonSecondaryFunction_A41592_UILabel
		{
			get
			{
				short num = (short)1097687313;
				short num2 = num;
				num = (short)865427729;
				switch (num2 == num)
				{
				}
				num = (short)2147352577;
				if (num != 0)
				{
				}
				num = (short)867041280;
				short num3 = num;
				num = (short)106954752;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592.UIName;
			}
		}

		// Token: 0x1700489A RID: 18586
		// (get) Token: 0x06008FC1 RID: 36801 RVA: 0x00878388 File Offset: 0x00876588
		// (set) Token: 0x06008FC2 RID: 36802 RVA: 0x00878438 File Offset: 0x00876638
		internal bool BtnSideUpDownArrowButtonSecondaryFunction_A41592_HiddenStatic
		{
			get
			{
				short num = (short)1831040866;
				short num2 = num;
				num = (short)322336610;
				switch (num2 == num)
				{
				}
				num = (short)1973092353;
				if (num != 0)
				{
				}
				num = (short)1480196096;
				short num3 = num;
				num = (short)602800128;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592.HiddenStatic;
			}
			set
			{
				short num = (short)1894877169;
				short num2 = num;
				num = (short)1878362097;
				switch (num2 == num)
				{
				}
				num = (short)621740033;
				if (num != 0)
				{
				}
				num = (short)2134704128;
				short num3 = num;
				num = (short)1281359872;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonSecondaryFunction_A41592.HiddenStatic = value;
			}
		}

		// Token: 0x1700489B RID: 18587
		// (get) Token: 0x06008FC3 RID: 36803 RVA: 0x008784EC File Offset: 0x008766EC
		// (set) Token: 0x06008FC4 RID: 36804 RVA: 0x008785A0 File Offset: 0x008767A0
		internal bool BtnSideUpDownArrowButtonSecondaryFunction_A41592_HiddenDynamic
		{
			get
			{
				short num = (short)1921270341;
				short num2 = num;
				num = (short)1788297797;
				switch (num2 == num)
				{
				}
				num = (short)2094661633;
				if (num != 0)
				{
				}
				num = (short)434307072;
				short num3 = num;
				num = (short)1286733824;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592.HiddenDynamic;
			}
			set
			{
				short num = (short)1296311016;
				short num2 = num;
				num = (short)1455235816;
				switch (num2 == num)
				{
				}
				num = (short)1347420161;
				if (num != 0)
				{
				}
				num = (short)484442112;
				short num3 = num;
				num = (short)1638662144;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonSecondaryFunction_A41592.HiddenDynamic = value;
			}
		}

		// Token: 0x1700489C RID: 18588
		// (get) Token: 0x06008FC5 RID: 36805 RVA: 0x00878654 File Offset: 0x00876854
		public bool BtnSideUpDownArrowButtonSecondaryFunction_A41592_HasDiffs
		{
			get
			{
				short num = (short)2136614619;
				short num2 = num;
				num = (short)1521690331;
				switch (num2 == num)
				{
				}
				num = (short)2117992448;
				if (num != 0)
				{
				}
				num = (short)1933312000;
				short num3 = num;
				num = (short)1523843073;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonSecondaryFunction_A41592._HasDiffs;
			}
		}

		// Token: 0x1700489D RID: 18589
		// (get) Token: 0x06008FC6 RID: 36806 RVA: 0x00878708 File Offset: 0x00876908
		// (set) Token: 0x06008FC7 RID: 36807 RVA: 0x008787BC File Offset: 0x008769BC
		public int BtnSideUpDownArrowButtonMFBBCO_A41633Value
		{
			get
			{
				short num = (short)1235332009;
				short num2 = num;
				num = (short)1158261673;
				switch (num2 == num)
				{
				}
				num = (short)754188289;
				if (num != 0)
				{
				}
				num = (short)1067646976;
				short num3 = num;
				num = (short)1661337600;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633.Value;
			}
			set
			{
				short num = (short)940113921;
				if (num != 0)
				{
				}
				num = (short)1409854791;
				short num2 = num;
				num = (short)2075831623;
				switch (num2 == num)
				{
				}
				num = (short)1367474176;
				short num3 = num;
				num = (short)996147200;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonMFBBCO_A41633.Value = value;
			}
		}

		// Token: 0x1700489E RID: 18590
		// (get) Token: 0x06008FC8 RID: 36808 RVA: 0x00878874 File Offset: 0x00876A74
		// (set) Token: 0x06008FC9 RID: 36809 RVA: 0x00878928 File Offset: 0x00876B28
		public string BtnSideUpDownArrowButtonMFBBCO_A41633_UIValue
		{
			get
			{
				short num = (short)1880817665;
				if (num != 0)
				{
				}
				num = (short)1645863902;
				short num2 = num;
				num = (short)1860690910;
				switch (num2 == num)
				{
				}
				num = (short)619184128;
				short num3 = num;
				num = (short)1060831232;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633.UIValue;
			}
			set
			{
				short num = (short)518070906;
				short num2 = num;
				num = (short)477438586;
				switch (num2 == num)
				{
				}
				num = (short)718471169;
				if (num != 0)
				{
				}
				num = (short)548995072;
				short num3 = num;
				num = (short)1234698240;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonMFBBCO_A41633.UIValue = value;
			}
		}

		// Token: 0x1700489F RID: 18591
		// (get) Token: 0x06008FCA RID: 36810 RVA: 0x008789DC File Offset: 0x00876BDC
		public global::AcpBusinessLayer.AcpListField BtnSideUpDownArrowButtonMFBBCO_A41633
		{
			get
			{
				short num = (short)1646919681;
				if (num != 0)
				{
				}
				num = (short)1330063253;
				short num2 = num;
				num = (short)782116757;
				switch (num2 == num)
				{
				}
				num = (short)175439872;
				short num3 = num;
				num = (short)40894464;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633;
			}
		}

		// Token: 0x170048A0 RID: 18592
		// (get) Token: 0x06008FCB RID: 36811 RVA: 0x00878A90 File Offset: 0x00876C90
		// (set) Token: 0x06008FCC RID: 36812 RVA: 0x00878B48 File Offset: 0x00876D48
		public bool BtnSideUpDownArrowButtonMFBBCO_A41633_Applicable
		{
			get
			{
				short num = (short)208797697;
				if (num != 0)
				{
				}
				num = (short)1254364802;
				short num2 = num;
				num = (short)76879490;
				switch (num2 == num)
				{
				}
				num = (short)810614784;
				short num3 = num;
				num = (short)93061120;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633.Applicable;
			}
			set
			{
				short num = (short)1599159711;
				short num2 = num;
				num = (short)616512927;
				switch (num2 == num)
				{
				}
				num = (short)1560018945;
				if (num != 0)
				{
				}
				num = (short)633274368;
				short num3 = num;
				num = (short)1791426560;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonMFBBCO_A41633.Applicable = value;
			}
		}

		// Token: 0x170048A1 RID: 18593
		// (get) Token: 0x06008FCD RID: 36813 RVA: 0x00878BFC File Offset: 0x00876DFC
		// (set) Token: 0x06008FCE RID: 36814 RVA: 0x00878CB4 File Offset: 0x00876EB4
		public bool BtnSideUpDownArrowButtonMFBBCO_A41633_Valid
		{
			get
			{
				short num = (short)619661398;
				short num2 = num;
				num = (short)1932281942;
				switch (num2 == num)
				{
				}
				num = (short)1787756545;
				if (num != 0)
				{
				}
				num = (short)1085669376;
				short num3 = num;
				num = (short)1140588544;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633.Valid;
			}
			set
			{
				short num = (short)2051375425;
				short num2 = num;
				num = (short)1357611329;
				switch (num2 == num)
				{
				}
				num = (short)2076770305;
				if (num != 0)
				{
				}
				num = (short)562298880;
				short num3 = num;
				num = (short)1894645760;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonMFBBCO_A41633.Valid = value;
			}
		}

		// Token: 0x170048A2 RID: 18594
		// (get) Token: 0x06008FCF RID: 36815 RVA: 0x00878D6C File Offset: 0x00876F6C
		// (set) Token: 0x06008FD0 RID: 36816 RVA: 0x00878E20 File Offset: 0x00877020
		public bool BtnSideUpDownArrowButtonMFBBCO_A41633_Visible
		{
			get
			{
				short num = (short)1189793769;
				short num2 = num;
				num = (short)1714474985;
				switch (num2 == num)
				{
				}
				num = (short)390332417;
				if (num != 0)
				{
				}
				num = (short)1934163968;
				short num3 = num;
				num = (short)1726021632;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633.Visible;
			}
			set
			{
				short num = (short)265187997;
				short num2 = num;
				num = (short)2025812637;
				switch (num2 == num)
				{
				}
				num = (short)1388314624;
				if (num != 0)
				{
				}
				num = (short)1360592896;
				short num3 = num;
				num = (short)617086977;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonMFBBCO_A41633.Visible = value;
			}
		}

		// Token: 0x170048A3 RID: 18595
		// (get) Token: 0x06008FD1 RID: 36817 RVA: 0x00878ED4 File Offset: 0x008770D4
		// (set) Token: 0x06008FD2 RID: 36818 RVA: 0x00878F88 File Offset: 0x00877188
		public bool BtnSideUpDownArrowButtonMFBBCO_A41633_Editable
		{
			get
			{
				short num = (short)863404200;
				short num2 = num;
				num = (short)1056735400;
				switch (num2 == num)
				{
				}
				num = (short)633995265;
				if (num != 0)
				{
				}
				num = (short)69009408;
				short num3 = num;
				num = (short)2111963136;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633.Editable;
			}
			set
			{
				short num = (short)19107155;
				short num2 = num;
				num = (short)1274711379;
				switch (num2 == num)
				{
				}
				num = (short)1738014721;
				if (num != 0)
				{
				}
				num = (short)1170079744;
				short num3 = num;
				num = (short)293273600;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonMFBBCO_A41633.Editable = value;
			}
		}

		// Token: 0x170048A4 RID: 18596
		// (get) Token: 0x06008FD3 RID: 36819 RVA: 0x00879040 File Offset: 0x00877240
		internal string BtnSideUpDownArrowButtonMFBBCO_A41633_UILabel
		{
			get
			{
				short num = (short)526476802;
				short num2 = num;
				num = (short)1125475842;
				switch (num2 == num)
				{
				}
				num = (short)1864695808;
				if (num != 0)
				{
				}
				num = (short)688914432;
				short num3 = num;
				num = (short)391643137;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633.UIName;
			}
		}

		// Token: 0x170048A5 RID: 18597
		// (get) Token: 0x06008FD4 RID: 36820 RVA: 0x008790F4 File Offset: 0x008772F4
		// (set) Token: 0x06008FD5 RID: 36821 RVA: 0x008791A8 File Offset: 0x008773A8
		internal bool BtnSideUpDownArrowButtonMFBBCO_A41633_HiddenStatic
		{
			get
			{
				short num = (short)1301086006;
				short num2 = num;
				num = (short)115015478;
				switch (num2 == num)
				{
				}
				num = (short)891879424;
				if (num != 0)
				{
				}
				num = (short)566820864;
				short num3 = num;
				num = (short)918618113;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633.HiddenStatic;
			}
			set
			{
				short num = (short)237901499;
				short num2 = num;
				num = (short)1396709051;
				switch (num2 == num)
				{
				}
				num = (short)1679622145;
				if (num != 0)
				{
				}
				num = (short)1179713536;
				short num3 = num;
				num = (short)1849819136;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonMFBBCO_A41633.HiddenStatic = value;
			}
		}

		// Token: 0x170048A6 RID: 18598
		// (get) Token: 0x06008FD6 RID: 36822 RVA: 0x0087925C File Offset: 0x0087745C
		// (set) Token: 0x06008FD7 RID: 36823 RVA: 0x00879310 File Offset: 0x00877510
		internal bool BtnSideUpDownArrowButtonMFBBCO_A41633_HiddenDynamic
		{
			get
			{
				short num = (short)1086127584;
				short num2 = num;
				num = (short)1176829408;
				switch (num2 == num)
				{
				}
				num = (short)394919937;
				if (num != 0)
				{
				}
				num = (short)1979645952;
				short num3 = num;
				num = (short)740753408;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633.HiddenDynamic;
			}
			set
			{
				short num = (short)1218705487;
				short num2 = num;
				num = (short)149485647;
				switch (num2 == num)
				{
				}
				num = (short)1982595072;
				short num3 = num;
				num = (short)1414463489;
				if (num != 0)
				{
				}
				num = (short)1129250816;
				if (num != 0)
				{
				}
				this.btnSideUpDownArrowButtonMFBBCO_A41633.HiddenDynamic = value;
			}
		}

		// Token: 0x170048A7 RID: 18599
		// (get) Token: 0x06008FD8 RID: 36824 RVA: 0x008793C4 File Offset: 0x008775C4
		public bool BtnSideUpDownArrowButtonMFBBCO_A41633_HasDiffs
		{
			get
			{
				short num = (short)1116995585;
				if (num != 0)
				{
				}
				num = (short)1465026575;
				short num2 = num;
				num = (short)1200326671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1393033216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)230490112;
				if (num != 0)
				{
				}
				return this.btnSideUpDownArrowButtonMFBBCO_A41633._HasDiffs;
			}
		}

		// Token: 0x06008FD9 RID: 36825 RVA: 0x00879478 File Offset: 0x00877678
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
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1070202880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1797912801;
					short num3 = num2;
					num2 = (short)728496353;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)2062614529;
						if (num2 != 0)
						{
						}
						num2 = (short)30474240;
						if (num2 != 0)
						{
						}
						num2 = (short)1740111875;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1302331393;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					num2 = (short)1585446912;
					short num4 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)1067188226;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1779499012;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400478A RID: 18314
		private global::AcpBusinessLayer.AcpField<string> btnSideArrowButtonName_A41567;

		// Token: 0x0400478B RID: 18315
		private global::AcpBusinessLayer.AcpListField btnSideUpDownArrowButtonPrimaryFunction_A41568;

		// Token: 0x0400478C RID: 18316
		private global::AcpBusinessLayer.AcpListField btnSideUpDownArrowButtonSecondaryFunction_A41592;

		// Token: 0x0400478D RID: 18317
		private global::AcpBusinessLayer.AcpListField btnSideUpDownArrowButtonMFBBCO_A41633;
	}
}
