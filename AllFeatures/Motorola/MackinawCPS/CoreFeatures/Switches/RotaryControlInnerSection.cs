using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002BC RID: 700
	[global::System.Serializable]
	public class RotaryControlInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600754B RID: 30027 RVA: 0x0069C63C File Offset: 0x0069A83C
		public RotaryControlInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x0069C658 File Offset: 0x0069A858
		protected RotaryControlInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x0069C670 File Offset: 0x0069A870
		public override void Init()
		{
			int a_ = 15;
			short num = (short)1952972801;
			if (num != 0)
			{
			}
			num = (short)1787941758;
			short num2 = num;
			num = (short)1605227390;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2102788096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1426718720;
			if (num != 0)
			{
			}
			this.switchGeneralRotaryControl_A8984 = new global::AcpBusinessLayer.AcpSparseLOVField(29, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchGeneralRotaryControl_A8984LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchGeneralRotaryControl_A8984LovStrs), this, global::AllFeatures.CodeplugGuid.b("菏ꗑ뷓ꋕ믗닙鯛믝軟蟡難蟥蓧룩菫髭釯胱跳뗵韷铹裻賽濿渁嬃䜅〇㌉㐋㨍", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchGeneralRotaryControl_A8984LovStrs);
			this.switchGeneralRotaryControl_A8984.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchGeneralRotaryControl_A8984.DataTransferOrder = 39;
			this.switchGeneralRotaryControl_A8984.ValidateAcrossRecset = true;
			this.switchRotaryControlButtonName_A22903 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ROTARYCONTROL, this, global::AllFeatures.CodeplugGuid.b("菏ꗑ뷓ꋕ믗닙軛뇝铟菡難鿥ꯧ藩苫髭苯鷱飳듵跷軹裻釽滿䰁攃欅洇唉䴋㰍∏⬑␓┕", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.switchRotaryControlButtonName_A22903.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchRotaryControlButtonName_A22903.DataTransferOrder = -1;
			this.switchRotaryControlButtonKey_A22905 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("菏ꗑ뷓ꋕ믗닙軛뇝铟菡難鿥ꯧ藩苫髭苯鷱飳듵跷軹裻釽滿䤁愃缅圇䬉㸋㰍⤏∑ℓ", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.switchRotaryControlButtonKey_A22905.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchRotaryControlButtonKey_A22905.DataTransferOrder = -1;
			this.switchRotaryControlButtonBCO_A22906 = new global::AcpBusinessLayer.AcpSparseLOVField(4, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchRotaryControlButtonBCO_A22906LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchRotaryControlButtonBCO_A22906LovStrs), this, global::AllFeatures.CodeplugGuid.b("菏ꗑ뷓ꋕ믗닙軛뇝铟菡難鿥ꯧ藩苫髭苯鷱飳듵跷軹裻釽滿䀁䜃䤅圇䬉㸋㰍⤏∑∓", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchRotaryControlButtonBCO_A22906LovStrs);
			this.switchRotaryControlButtonBCO_A22906.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchRotaryControlButtonBCO_A22906.DataTransferOrder = 3;
			this.switchRotaryControlShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("菏ꗑ뷓ꋕ믗닙軛뇝铟菡難鿥ꯧ藩苫髭苯鷱飳ꗵ郷闹軻諽僿瀁愃甅笇帉攋挍甏", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.switchRotaryControlShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchRotaryControlShortPressTime.DataTransferOrder = -1;
			this.switchRotaryControlShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.switchRotaryControlShortPressTime.ShowHexValue = false;
			this.switchRotaryControlShortPressTime.ValidateAcrossRecset = true;
			this.switchRotaryControlLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("菏ꗑ뷓ꋕ믗닙軛뇝铟菡難鿥ꯧ藩苫髭苯鷱飳뫵韷铹鯻껽狿朁眃甅將按愋欍", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.switchRotaryControlLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchRotaryControlLongPressTime.DataTransferOrder = -1;
			this.switchRotaryControlLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.switchRotaryControlLongPressTime.ShowHexValue = false;
			this.switchRotaryControlLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苏뷑ꃓ럕꫗ꏙﳛ鷝迟賡郣铥蟧蛩", a_);
			base.Id = 10082;
			base.UIName = global::CommonResources.AcgResources.ID_ROTARYCONTROL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x0069C958 File Offset: 0x0069AB58
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)2070216709;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜跞軠韢蓤闦部꣪苬臮藰臲髴鯶꫸鏺鋼跾甀匂眄戆稈砊夌明簐瘒", a_)))
					{
						num = (short)1395326996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EB;
				case 1:
					goto IL_51F;
				case 2:
					num = (short)628293646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.switchRotaryControlLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜跞軠韢蓤闦部꣪苬臮藰臲髴鯶뗸铺鏼飾儀焂怄理稈弊搌戎琐", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.switchRotaryControlLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchRotaryControlLongPressTime.DataTransferOrder = -1;
					this.switchRotaryControlLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.switchRotaryControlLongPressTime.ShowHexValue = false;
					this.switchRotaryControlLongPressTime.ValidateAcrossRecset = true;
					num = (short)1637613581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜跞軠韢蓤闦部꣪苬臮藰臲髴鯶미軺觼课渀洂䜄䐆䘈吊䰌㴎⌐⨒└№", a_)))
					{
						num = (short)1929510918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 6:
					this.switchRotaryControlButtonBCO_A22906 = new global::AcpBusinessLayer.AcpSparseLOVField(4, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchRotaryControlButtonBCO_A22906LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchRotaryControlButtonBCO_A22906LovStrs), this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜跞軠韢蓤闦部꣪苬臮藰臲髴鯶미軺觼课渀洂䜄䐆䘈吊䰌㴎⌐⨒└№", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchRotaryControlButtonBCO_A22906LovStrs);
					this.switchRotaryControlButtonBCO_A22906.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchRotaryControlButtonBCO_A22906.DataTransferOrder = 3;
					num = (short)1956511751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_A8;
				case 8:
					this.switchRotaryControlButtonName_A22903 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ROTARYCONTROL, this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜跞軠韢蓤闦部꣪苬臮藰臲髴鯶미軺觼课渀洂䬄昆搈渊刌与⌐ℒⰔ✖⨘", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.switchRotaryControlButtonName_A22903.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchRotaryControlButtonName_A22903.DataTransferOrder = -1;
					num = (short)1760231439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜飞蓠跢胤闦裨蟪뿬胮藰鋲蟴軶뫸铺鏼课猀氂椄堆䠈㌊㐌㜎┐", a_)))
					{
						num = (short)934674449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_442;
				case 10:
					goto IL_442;
				case 11:
					num = (short)19267593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜跞軠韢蓤闦部꣪苬臮藰臲髴鯶뗸铺鏼飾儀焂怄理稈弊搌戎琐", a_)))
					{
						goto IL_603;
					}
					num = (short)936310035;
					short num3 = num;
					num = (short)561968403;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A8;
					default:
						num = (short)329449472;
						if (num != 0)
						{
						}
						num = (short)1516765187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					goto IL_3C8;
				case 14:
					if (producerFields != null)
					{
						num = (short)401997835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_603;
				case 15:
					goto IL_3CD;
				case 16:
					num = (short)573571073;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜跞軠韢蓤闦部꣪苬臮藰臲髴鯶미軺觼课渀洂丄戆瀈吊䰌㴎⌐⨒└∖", a_)))
					{
						num = (short)1293484051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51F;
				case 17:
					this.switchGeneralRotaryControl_A8984 = new global::AcpBusinessLayer.AcpSparseLOVField(29, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchGeneralRotaryControl_A8984LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchGeneralRotaryControl_A8984LovStrs), this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜飞蓠跢胤闦裨蟪뿬胮藰鋲蟴軶뫸铺鏼课猀氂椄堆䠈㌊㐌㜎┐", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchGeneralRotaryControl_A8984LovStrs);
					this.switchGeneralRotaryControl_A8984.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchGeneralRotaryControl_A8984.DataTransferOrder = 39;
					this.switchGeneralRotaryControl_A8984.ValidateAcrossRecset = true;
					num = (short)36569098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_1EB;
				case 19:
				{
					num = (short)660275200;
					short num4 = num;
					this.switchRotaryControlButtonKey_A22905 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜跞軠韢蓤闦部꣪苬臮藰臲髴鯶미軺觼课渀洂丄戆瀈吊䰌㴎⌐⨒└∖", a_), global::CommonResources.AcgResources.ID_KEY, 14);
					this.switchRotaryControlButtonKey_A22905.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchRotaryControlButtonKey_A22905.DataTransferOrder = -1;
					num = (short)52690945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 20:
					this.switchRotaryControlShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜跞軠韢蓤闦部꣪苬臮藰臲髴鯶꫸鏺鋼跾甀匂眄戆稈砊夌明簐瘒", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.switchRotaryControlShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchRotaryControlShortPressTime.DataTransferOrder = -1;
					this.switchRotaryControlShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.switchRotaryControlShortPressTime.ShowHexValue = false;
					this.switchRotaryControlShortPressTime.ValidateAcrossRecset = true;
					num = (short)1285095442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜跞軠韢蓤闦部꣪苬臮藰臲髴鯶미軺觼课渀洂䬄昆搈渊刌与⌐ℒⰔ✖⨘", a_)))
					{
						num = (short)198180872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CD;
				}
				IL_85:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2008154114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A8:
				num = (short)1628766208;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EB:
				num = (short)320995340;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3CD:
				num = (short)1755054096;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_442:
				num = (short)510525461;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_51F:
				num = (short)2062811140;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3C8:
			IL_603:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臒뫔ꏖ룘꧚ꓜ￞ꋠ賢诤鏦鯨蓪臬", a_);
			base.Id = 10082;
			base.UIName = global::CommonResources.AcgResources.ID_ROTARYCONTROL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x0069CF9C File Offset: 0x0069B19C
		public override void PopulateReferences()
		{
			short num = (short)1973492522;
			short num2 = num;
			num = (short)1531321130;
			switch (num2 == num)
			{
			}
			num = (short)1604517889;
			if (num != 0)
			{
			}
			num = (short)2052325376;
			if (num != 0)
			{
			}
			num = (short)2049114112;
			short num3 = num;
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x0069D044 File Offset: 0x0069B244
		public override void DropReferences()
		{
			short num = (short)203159812;
			short num2 = num;
			num = (short)796195076;
			switch (num2 == num)
			{
			}
			num = (short)422510593;
			if (num != 0)
			{
			}
			num = (short)1415643136;
			if (num != 0)
			{
			}
			num = (short)1590951936;
			short num3 = num;
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x0069D0EC File Offset: 0x0069B2EC
		public override void SetConstraints()
		{
			short num = (short)928498414;
			short num2 = num;
			num = (short)358204142;
			switch (num2 == num)
			{
			}
			num = (short)1802698752;
			if (num != 0)
			{
			}
			num = (short)1758593025;
			if (num != 0)
			{
			}
			num = (short)798490624;
			short num3 = num;
			this.switchGeneralRotaryControl_A8984.ValidateAcrossRecset = true;
			this.switchGeneralRotaryControl_A8984.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conValidityRotaryControl);
			this.switchGeneralRotaryControl_A8984.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncRotaryControlFeature);
			this.switchRotaryControlButtonName_A22903.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x0069D1E8 File Offset: 0x0069B3E8
		public override void SetupDependencies()
		{
			short num = (short)2065288783;
			short num2 = num;
			num = (short)1760349775;
			switch (num2 == num)
			{
			}
			num = (short)1676410881;
			if (num != 0)
			{
			}
			num = (short)1079705600;
			if (num != 0)
			{
			}
			num = (short)822411264;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.switchGeneralRotaryControl_A8984);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.switchGeneralRotaryControl_A8984);
			this.RefRadioWide.Labtool.RadWideLabtoolZoneSelectorOnSwitch_A19550.AddDependentObject(this.switchGeneralRotaryControl_A8984);
			this.RefRadioWide.Labtool.RadWideLabtoolChannelSelectorOnSwitch_A19551.AddDependentObject(this.switchGeneralRotaryControl_A8984);
			this.switchGeneralRotaryControl_A8984.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.switchGeneralRotaryControl_A8984.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x06007553 RID: 30035 RVA: 0x0069D36C File Offset: 0x0069B56C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1132307865;
				short num2 = num;
				num = (short)1977263513;
				switch (num2 == num)
				{
				}
				num = (short)275775488;
				if (num != 0)
				{
				}
				num = (short)522911745;
				if (num != 0)
				{
				}
				num = (short)251658240;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x06007554 RID: 30036 RVA: 0x0069D41C File Offset: 0x0069B61C
		// (set) Token: 0x06007555 RID: 30037 RVA: 0x0069D4D0 File Offset: 0x0069B6D0
		public int SwitchGeneralRotaryControl_A8984Value
		{
			get
			{
				short num = (short)2107052363;
				short num2 = num;
				num = (short)198054219;
				switch (num2 == num)
				{
				}
				num = (short)231014401;
				if (num != 0)
				{
				}
				num = (short)711327744;
				if (num != 0)
				{
				}
				num = (short)80805888;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984.Value;
			}
			set
			{
				short num = (short)2113002141;
				short num2 = num;
				num = (short)552196765;
				switch (num2 == num)
				{
				}
				num = (short)1470038016;
				if (num != 0)
				{
				}
				num = (short)1326055425;
				if (num != 0)
				{
				}
				num = (short)572719104;
				short num3 = num;
				this.switchGeneralRotaryControl_A8984.Value = value;
			}
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x06007556 RID: 30038 RVA: 0x0069D588 File Offset: 0x0069B788
		// (set) Token: 0x06007557 RID: 30039 RVA: 0x0069D63C File Offset: 0x0069B83C
		public string SwitchGeneralRotaryControl_A8984_UIValue
		{
			get
			{
				short num = (short)240350144;
				short num2 = num;
				num = (short)809726912;
				switch (num2 == num)
				{
				}
				num = (short)254345217;
				if (num != 0)
				{
				}
				num = (short)32571392;
				if (num != 0)
				{
				}
				num = (short)1628700672;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984.UIValue;
			}
			set
			{
				short num = (short)1305872971;
				short num2 = num;
				num = (short)329648715;
				switch (num2 == num)
				{
				}
				num = (short)906428417;
				if (num != 0)
				{
				}
				num = (short)1637875712;
				if (num != 0)
				{
				}
				num = (short)178257920;
				short num3 = num;
				this.switchGeneralRotaryControl_A8984.UIValue = value;
			}
		}

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x06007558 RID: 30040 RVA: 0x0069D6F0 File Offset: 0x0069B8F0
		public global::AcpBusinessLayer.AcpListField SwitchGeneralRotaryControl_A8984
		{
			get
			{
				short num = (short)460650640;
				short num2 = num;
				num = (short)1523972240;
				switch (num2 == num)
				{
				}
				num = (short)1725497344;
				if (num != 0)
				{
				}
				num = (short)1336147969;
				if (num != 0)
				{
				}
				num = (short)220397568;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984;
			}
		}

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x06007559 RID: 30041 RVA: 0x0069D7A0 File Offset: 0x0069B9A0
		// (set) Token: 0x0600755A RID: 30042 RVA: 0x0069D858 File Offset: 0x0069BA58
		public bool SwitchGeneralRotaryControl_A8984_Applicable
		{
			get
			{
				short num = (short)135802570;
				short num2 = num;
				num = (short)254488266;
				switch (num2 == num)
				{
				}
				num = (short)1845166080;
				if (num != 0)
				{
				}
				num = (short)532021249;
				if (num != 0)
				{
				}
				num = (short)1560281088;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984.Applicable;
			}
			set
			{
				short num = (short)2061533011;
				short num2 = num;
				num = (short)742227795;
				switch (num2 == num)
				{
				}
				num = (short)471662593;
				if (num != 0)
				{
				}
				num = (short)645332992;
				if (num != 0)
				{
				}
				num = (short)179634176;
				short num3 = num;
				this.switchGeneralRotaryControl_A8984.Applicable = value;
			}
		}

		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x0600755B RID: 30043 RVA: 0x0069D90C File Offset: 0x0069BB0C
		// (set) Token: 0x0600755C RID: 30044 RVA: 0x0069D9C0 File Offset: 0x0069BBC0
		public bool SwitchGeneralRotaryControl_A8984_Valid
		{
			get
			{
				short num = (short)764633266;
				short num2 = num;
				num = (short)110452914;
				switch (num2 == num)
				{
				}
				num = (short)1765212160;
				if (num != 0)
				{
				}
				num = (short)1776680961;
				if (num != 0)
				{
				}
				num = (short)1714159616;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984.Valid;
			}
			set
			{
				short num = (short)1495072769;
				if (num != 0)
				{
				}
				num = (short)1755390462;
				short num2 = num;
				num = (short)100082174;
				switch (num2 == num)
				{
				}
				num = (short)1126367232;
				if (num != 0)
				{
				}
				num = (short)605618176;
				short num3 = num;
				this.switchGeneralRotaryControl_A8984.Valid = value;
			}
		}

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x0600755D RID: 30045 RVA: 0x0069DA74 File Offset: 0x0069BC74
		// (set) Token: 0x0600755E RID: 30046 RVA: 0x0069DB28 File Offset: 0x0069BD28
		public bool SwitchGeneralRotaryControl_A8984_Visible
		{
			get
			{
				short num = (short)1471753908;
				short num2 = num;
				num = (short)608382644;
				switch (num2 == num)
				{
				}
				num = (short)1517551617;
				if (num != 0)
				{
				}
				num = (short)695402496;
				if (num != 0)
				{
				}
				num = (short)2000879616;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984.Visible;
			}
			set
			{
				short num = (short)1356819194;
				short num2 = num;
				num = (short)489122554;
				switch (num2 == num)
				{
				}
				num = (short)2083454977;
				if (num != 0)
				{
				}
				num = (short)2132738048;
				if (num != 0)
				{
				}
				num = (short)471138304;
				short num3 = num;
				this.switchGeneralRotaryControl_A8984.Visible = value;
			}
		}

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x0600755F RID: 30047 RVA: 0x0069DBE0 File Offset: 0x0069BDE0
		// (set) Token: 0x06007560 RID: 30048 RVA: 0x0069DC94 File Offset: 0x0069BE94
		public bool SwitchGeneralRotaryControl_A8984_Editable
		{
			get
			{
				short num = (short)2129277640;
				short num2 = num;
				num = (short)1163473608;
				switch (num2 == num)
				{
				}
				num = (short)445513729;
				if (num != 0)
				{
				}
				num = (short)824573952;
				if (num != 0)
				{
				}
				num = (short)1612775424;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984.Editable;
			}
			set
			{
				short num = (short)974589785;
				short num2 = num;
				num = (short)1409486681;
				switch (num2 == num)
				{
				}
				num = (short)1123614721;
				if (num != 0)
				{
				}
				num = (short)972095488;
				if (num != 0)
				{
				}
				num = (short)1152057344;
				short num3 = num;
				this.switchGeneralRotaryControl_A8984.Editable = value;
			}
		}

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x06007561 RID: 30049 RVA: 0x0069DD48 File Offset: 0x0069BF48
		internal string SwitchGeneralRotaryControl_A8984_UILabel
		{
			get
			{
				short num = (short)1519852021;
				short num2 = num;
				num = (short)1237522933;
				switch (num2 == num)
				{
				}
				num = (short)636092417;
				if (num != 0)
				{
				}
				num = (short)1726218240;
				if (num != 0)
				{
				}
				num = (short)1826029568;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984.UIName;
			}
		}

		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x06007562 RID: 30050 RVA: 0x0069DE00 File Offset: 0x0069C000
		// (set) Token: 0x06007563 RID: 30051 RVA: 0x0069DEB8 File Offset: 0x0069C0B8
		internal bool SwitchGeneralRotaryControl_A8984_HiddenStatic
		{
			get
			{
				short num = (short)1102092769;
				short num2 = num;
				num = (short)1394121185;
				switch (num2 == num)
				{
				}
				num = (short)1679687681;
				if (num != 0)
				{
				}
				num = (short)1893466112;
				if (num != 0)
				{
				}
				num = (short)1228931072;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984.HiddenStatic;
			}
			set
			{
				short num = (short)965604707;
				short num2 = num;
				num = (short)1605170531;
				switch (num2 == num)
				{
				}
				num = (short)902430721;
				if (num != 0)
				{
				}
				num = (short)40960000;
				if (num != 0)
				{
				}
				num = (short)849346560;
				short num3 = num;
				this.switchGeneralRotaryControl_A8984.HiddenStatic = value;
			}
		}

		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x06007564 RID: 30052 RVA: 0x0069DF70 File Offset: 0x0069C170
		// (set) Token: 0x06007565 RID: 30053 RVA: 0x0069E028 File Offset: 0x0069C228
		internal bool SwitchGeneralRotaryControl_A8984_HiddenDynamic
		{
			get
			{
				short num = (short)462683147;
				short num2 = num;
				num = (short)514063371;
				switch (num2 == num)
				{
				}
				num = (short)47644672;
				if (num != 0)
				{
				}
				num = (short)528220161;
				if (num != 0)
				{
				}
				num = (short)2078343168;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984.HiddenDynamic;
			}
			set
			{
				short num = (short)1623207136;
				short num2 = num;
				num = (short)1394552032;
				switch (num2 == num)
				{
				}
				num = (short)1024655361;
				if (num != 0)
				{
				}
				num = (short)1508704256;
				if (num != 0)
				{
				}
				num = (short)1873608704;
				short num3 = num;
				this.switchGeneralRotaryControl_A8984.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x06007566 RID: 30054 RVA: 0x0069E0DC File Offset: 0x0069C2DC
		public bool SwitchGeneralRotaryControl_A8984_HasDiffs
		{
			get
			{
				short num = (short)1851667711;
				short num2 = num;
				num = (short)892351743;
				switch (num2 == num)
				{
				}
				num = (short)720961537;
				if (num != 0)
				{
				}
				num = (short)343277568;
				if (num != 0)
				{
				}
				num = (short)1804140544;
				short num3 = num;
				return this.switchGeneralRotaryControl_A8984._HasDiffs;
			}
		}

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x06007567 RID: 30055 RVA: 0x0069E190 File Offset: 0x0069C390
		// (set) Token: 0x06007568 RID: 30056 RVA: 0x0069E244 File Offset: 0x0069C444
		public string SwitchRotaryControlButtonName_A22903Value
		{
			get
			{
				short num = (short)2005187530;
				short num2 = num;
				num = (short)1550826442;
				switch (num2 == num)
				{
				}
				num = (short)445972481;
				if (num != 0)
				{
				}
				num = (short)1640562688;
				if (num != 0)
				{
				}
				num = (short)1655898112;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903.Value;
			}
			set
			{
				short num = (short)164990516;
				short num2 = num;
				num = (short)191991348;
				switch (num2 == num)
				{
				}
				num = (short)314114049;
				if (num != 0)
				{
				}
				num = (short)1842479104;
				if (num != 0)
				{
				}
				num = (short)105447424;
				short num3 = num;
				this.switchRotaryControlButtonName_A22903.Value = value;
			}
		}

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x06007569 RID: 30057 RVA: 0x0069E2F8 File Offset: 0x0069C4F8
		public global::AcpBusinessLayer.AcpField<string> SwitchRotaryControlButtonName_A22903
		{
			get
			{
				short num = (short)1693920857;
				short num2 = num;
				num = (short)844836441;
				switch (num2 == num)
				{
				}
				num = (short)1659699200;
				if (num != 0)
				{
				}
				num = (short)1828651009;
				if (num != 0)
				{
				}
				num = (short)1345978368;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903;
			}
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x0600756A RID: 30058 RVA: 0x0069E3A8 File Offset: 0x0069C5A8
		// (set) Token: 0x0600756B RID: 30059 RVA: 0x0069E460 File Offset: 0x0069C660
		public string SwitchRotaryControlButtonName_A22903_UIValue
		{
			get
			{
				short num = (short)620586894;
				short num2 = num;
				num = (short)1698588558;
				switch (num2 == num)
				{
				}
				num = (short)535887872;
				if (num != 0)
				{
				}
				num = (short)389414913;
				if (num != 0)
				{
				}
				num = (short)2084831232;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903.Value;
			}
			set
			{
				short num = (short)1139880511;
				short num2 = num;
				num = (short)1941451327;
				switch (num2 == num)
				{
				}
				num = (short)1287520257;
				if (num != 0)
				{
				}
				num = (short)1117650944;
				if (num != 0)
				{
				}
				num = (short)80740352;
				short num3 = num;
				this.switchRotaryControlButtonName_A22903.Value = value;
			}
		}

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x0600756C RID: 30060 RVA: 0x0069E514 File Offset: 0x0069C714
		// (set) Token: 0x0600756D RID: 30061 RVA: 0x0069E5C8 File Offset: 0x0069C7C8
		public bool SwitchRotaryControlButtonName_A22903_Applicable
		{
			get
			{
				short num = (short)1867531127;
				short num2 = num;
				num = (short)1231307639;
				switch (num2 == num)
				{
				}
				num = (short)1423966209;
				if (num != 0)
				{
				}
				num = (short)865533952;
				if (num != 0)
				{
				}
				num = (short)1655635968;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903.Applicable;
			}
			set
			{
				short num = (short)29360129;
				if (num != 0)
				{
				}
				num = (short)332807184;
				short num2 = num;
				num = (short)1159216144;
				switch (num2 == num)
				{
				}
				num = (short)1964572672;
				if (num != 0)
				{
				}
				num = (short)611188736;
				short num3 = num;
				this.switchRotaryControlButtonName_A22903.Applicable = value;
			}
		}

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x0600756E RID: 30062 RVA: 0x0069E680 File Offset: 0x0069C880
		// (set) Token: 0x0600756F RID: 30063 RVA: 0x0069E734 File Offset: 0x0069C934
		public bool SwitchRotaryControlButtonName_A22903_Valid
		{
			get
			{
				short num = (short)638117263;
				short num2 = num;
				num = (short)639034767;
				switch (num2 == num)
				{
				}
				num = (short)2116747264;
				if (num != 0)
				{
				}
				num = (short)1735655425;
				if (num != 0)
				{
				}
				num = (short)1869021184;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903.Valid;
			}
			set
			{
				short num = (short)1211090294;
				short num2 = num;
				num = (short)232113526;
				switch (num2 == num)
				{
				}
				num = (short)868417536;
				if (num != 0)
				{
				}
				num = (short)112132097;
				if (num != 0)
				{
				}
				num = (short)1219690496;
				short num3 = num;
				this.switchRotaryControlButtonName_A22903.Valid = value;
			}
		}

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x06007570 RID: 30064 RVA: 0x0069E7E8 File Offset: 0x0069C9E8
		// (set) Token: 0x06007571 RID: 30065 RVA: 0x0069E89C File Offset: 0x0069CA9C
		public bool SwitchRotaryControlButtonName_A22903_Visible
		{
			get
			{
				short num = (short)1521615815;
				short num2 = num;
				num = (short)401867719;
				switch (num2 == num)
				{
				}
				num = (short)260177921;
				if (num != 0)
				{
				}
				num = (short)1072693248;
				if (num != 0)
				{
				}
				num = (short)867172352;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903.Visible;
			}
			set
			{
				short num = (short)1231929217;
				short num2 = num;
				num = (short)166707073;
				switch (num2 == num)
				{
				}
				num = (short)649068545;
				if (num != 0)
				{
				}
				num = (short)1364983808;
				if (num != 0)
				{
				}
				num = (short)1587347456;
				short num3 = num;
				this.switchRotaryControlButtonName_A22903.Visible = value;
			}
		}

		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x06007572 RID: 30066 RVA: 0x0069E954 File Offset: 0x0069CB54
		// (set) Token: 0x06007573 RID: 30067 RVA: 0x0069EA08 File Offset: 0x0069CC08
		public bool SwitchRotaryControlButtonName_A22903_Editable
		{
			get
			{
				short num = (short)1091345671;
				short num2 = num;
				num = (short)551132423;
				switch (num2 == num)
				{
				}
				num = (short)309919744;
				if (num != 0)
				{
				}
				num = (short)1920139265;
				if (num != 0)
				{
				}
				num = (short)1138425856;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903.Editable;
			}
			set
			{
				short num = (short)622251987;
				short num2 = num;
				num = (short)914345939;
				switch (num2 == num)
				{
				}
				num = (short)877395968;
				if (num != 0)
				{
				}
				num = (short)1048313857;
				if (num != 0)
				{
				}
				num = (short)1153433600;
				short num3 = num;
				this.switchRotaryControlButtonName_A22903.Editable = value;
			}
		}

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x06007574 RID: 30068 RVA: 0x0069EABC File Offset: 0x0069CCBC
		internal string SwitchRotaryControlButtonName_A22903_UILabel
		{
			get
			{
				short num = (short)884627856;
				short num2 = num;
				num = (short)1099258256;
				switch (num2 == num)
				{
				}
				num = (short)1714159617;
				if (num != 0)
				{
				}
				num = (short)1410465792;
				if (num != 0)
				{
				}
				num = (short)324075520;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903.UIName;
			}
		}

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x06007575 RID: 30069 RVA: 0x0069EB70 File Offset: 0x0069CD70
		// (set) Token: 0x06007576 RID: 30070 RVA: 0x0069EC24 File Offset: 0x0069CE24
		internal bool SwitchRotaryControlButtonName_A22903_HiddenStatic
		{
			get
			{
				short num = (short)1609776715;
				short num2 = num;
				num = (short)697450059;
				switch (num2 == num)
				{
				}
				num = (short)1876623361;
				if (num != 0)
				{
				}
				num = (short)438501376;
				if (num != 0)
				{
				}
				num = (short)1160118272;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903.HiddenStatic;
			}
			set
			{
				short num = (short)705343683;
				short num2 = num;
				num = (short)678015171;
				switch (num2 == num)
				{
				}
				num = (short)41418753;
				if (num != 0)
				{
				}
				num = (short)579076096;
				if (num != 0)
				{
				}
				num = (short)244449280;
				short num3 = num;
				this.switchRotaryControlButtonName_A22903.HiddenStatic = value;
			}
		}

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x06007577 RID: 30071 RVA: 0x0069ECDC File Offset: 0x0069CEDC
		// (set) Token: 0x06007578 RID: 30072 RVA: 0x0069ED90 File Offset: 0x0069CF90
		internal bool SwitchRotaryControlButtonName_A22903_HiddenDynamic
		{
			get
			{
				short num = (short)1527084140;
				short num2 = num;
				num = (short)1816949868;
				switch (num2 == num)
				{
				}
				num = (short)930349056;
				if (num != 0)
				{
				}
				num = (short)1627848705;
				if (num != 0)
				{
				}
				num = (short)1457913856;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903.HiddenDynamic;
			}
			set
			{
				short num = (short)1227292673;
				if (num != 0)
				{
				}
				num = (short)575023909;
				short num2 = num;
				num = (short)87108389;
				switch (num2 == num)
				{
				}
				num = (short)21889024;
				if (num != 0)
				{
				}
				num = (short)1459027968;
				short num3 = num;
				this.switchRotaryControlButtonName_A22903.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x06007579 RID: 30073 RVA: 0x0069EE48 File Offset: 0x0069D048
		public bool SwitchRotaryControlButtonName_A22903_HasDiffs
		{
			get
			{
				short num = (short)996126255;
				short num2 = num;
				num = (short)1090498095;
				switch (num2 == num)
				{
				}
				num = (short)216399873;
				if (num != 0)
				{
				}
				num = (short)1469054976;
				if (num != 0)
				{
				}
				num = (short)79036416;
				short num3 = num;
				return this.switchRotaryControlButtonName_A22903._HasDiffs;
			}
		}

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x0600757A RID: 30074 RVA: 0x0069EEFC File Offset: 0x0069D0FC
		// (set) Token: 0x0600757B RID: 30075 RVA: 0x0069EFB4 File Offset: 0x0069D1B4
		public string SwitchRotaryControlButtonKey_A22905Value
		{
			get
			{
				short num = (short)584243878;
				short num2 = num;
				num = (short)339925670;
				switch (num2 == num)
				{
				}
				num = (short)514719745;
				if (num != 0)
				{
				}
				num = (short)169476096;
				if (num != 0)
				{
				}
				num = (short)1904082944;
				short num3 = num;
				return this.switchRotaryControlButtonKey_A22905.Value;
			}
			set
			{
				short num = (short)1566244864;
				short num2 = num;
				num = (short)402836885;
				short num3 = num;
				num = (short)2105003413;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1178271745;
					if (num != 0)
					{
					}
					num = (short)1498873856;
					if (num != 0)
					{
					}
					num = (short)1592655873;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							return;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_CD;
							}
							continue;
						case 2:
							this.switchRotaryControlButtonKey_A22905.Value = value;
							num = (short)270270464;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_CD:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							break;
						}
						num = (short)1212743682;
						num4 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
		}

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x0600757C RID: 30076 RVA: 0x0069F0D8 File Offset: 0x0069D2D8
		// (set) Token: 0x0600757D RID: 30077 RVA: 0x0069F18C File Offset: 0x0069D38C
		public string SwitchRotaryControlButtonKey_A22905_UIValue
		{
			get
			{
				short num = (short)1605194358;
				short num2 = num;
				num = (short)2116113014;
				switch (num2 == num)
				{
				}
				num = (short)1133182977;
				if (num != 0)
				{
				}
				num = (short)1593507840;
				if (num != 0)
				{
				}
				num = (short)1961492480;
				short num3 = num;
				return this.switchRotaryControlButtonKey_A22905.Value;
			}
			set
			{
				short num = (short)2009970488;
				short num2 = num;
				num = (short)629651256;
				switch (num2 == num)
				{
				}
				num = (short)872742913;
				if (num != 0)
				{
				}
				num = (short)1367146496;
				if (num != 0)
				{
				}
				num = (short)2114387968;
				short num3 = num;
				this.switchRotaryControlButtonKey_A22905.Value = value;
			}
		}

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x0600757E RID: 30078 RVA: 0x0069F240 File Offset: 0x0069D440
		public global::AcpBusinessLayer.AcpKeyField SwitchRotaryControlButtonKey_A22905
		{
			get
			{
				short num = (short)1998280718;
				short num2 = num;
				num = (short)877484046;
				switch (num2 == num)
				{
				}
				num = (short)1389428737;
				if (num != 0)
				{
				}
				num = (short)512032768;
				if (num != 0)
				{
				}
				num = (short)2019688448;
				short num3 = num;
				return this.switchRotaryControlButtonKey_A22905;
			}
		}

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x0600757F RID: 30079 RVA: 0x0069F2F0 File Offset: 0x0069D4F0
		// (set) Token: 0x06007580 RID: 30080 RVA: 0x0069F3A4 File Offset: 0x0069D5A4
		public bool SwitchRotaryControlButtonKey_A22905_Applicable
		{
			get
			{
				short num = (short)1078238084;
				short num2 = num;
				num = (short)1425251204;
				switch (num2 == num)
				{
				}
				num = (short)2124349441;
				if (num != 0)
				{
				}
				num = (short)15335424;
				if (num != 0)
				{
				}
				num = (short)494010368;
				short num3 = num;
				return this.switchRotaryControlButtonKey_A22905.Applicable;
			}
			set
			{
				short num = (short)2040938985;
				short num2 = num;
				num = (short)1635664361;
				switch (num2 == num)
				{
				}
				num = (short)373620737;
				if (num != 0)
				{
				}
				num = (short)384172032;
				if (num != 0)
				{
				}
				num = (short)1196359680;
				short num3 = num;
				this.switchRotaryControlButtonKey_A22905.Applicable = value;
			}
		}

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x06007581 RID: 30081 RVA: 0x0069F45C File Offset: 0x0069D65C
		// (set) Token: 0x06007582 RID: 30082 RVA: 0x0069F510 File Offset: 0x0069D710
		public bool SwitchRotaryControlButtonKey_A22905_Valid
		{
			get
			{
				short num = (short)416810040;
				short num2 = num;
				num = (short)1267008568;
				switch (num2 == num)
				{
				}
				num = (short)2004746241;
				if (num != 0)
				{
				}
				num = (short)963051520;
				if (num != 0)
				{
				}
				num = (short)1592524800;
				short num3 = num;
				return this.switchRotaryControlButtonKey_A22905.Valid;
			}
			set
			{
				short num = (short)286024748;
				short num2 = num;
				num = (short)1730962476;
				switch (num2 == num)
				{
				}
				num = (short)1648033792;
				if (num != 0)
				{
				}
				num = (short)922025985;
				if (num != 0)
				{
				}
				num = (short)217710592;
				short num3 = num;
				this.switchRotaryControlButtonKey_A22905.Valid = value;
			}
		}

		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x06007583 RID: 30083 RVA: 0x0069F5C8 File Offset: 0x0069D7C8
		// (set) Token: 0x06007584 RID: 30084 RVA: 0x0069F67C File Offset: 0x0069D87C
		public bool SwitchRotaryControlButtonKey_A22905_Visible
		{
			get
			{
				short num = (short)1821930071;
				short num2 = num;
				num = (short)1565028951;
				switch (num2 == num)
				{
				}
				num = (short)605683713;
				if (num != 0)
				{
				}
				num = (short)819003392;
				if (num != 0)
				{
				}
				num = (short)240058368;
				short num3 = num;
				return this.switchRotaryControlButtonKey_A22905.Visible;
			}
			set
			{
				short num = (short)83835292;
				short num2 = num;
				num = (short)193870236;
				switch (num2 == num)
				{
				}
				num = (short)587530241;
				if (num != 0)
				{
				}
				num = (short)787480576;
				if (num != 0)
				{
				}
				num = (short)2111242240;
				short num3 = num;
				this.switchRotaryControlButtonKey_A22905.Visible = value;
			}
		}

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x06007585 RID: 30085 RVA: 0x0069F734 File Offset: 0x0069D934
		// (set) Token: 0x06007586 RID: 30086 RVA: 0x0069F7EC File Offset: 0x0069D9EC
		public bool SwitchRotaryControlButtonKey_A22905_Editable
		{
			get
			{
				short num = (short)1984626689;
				if (num != 0)
				{
				}
				num = (short)1370161071;
				short num2 = num;
				num = (short)272039855;
				switch (num2 == num)
				{
				}
				num = (short)834273280;
				if (num != 0)
				{
				}
				num = (short)682164224;
				short num3 = num;
				return this.switchRotaryControlButtonKey_A22905.Editable;
			}
			set
			{
				short num = (short)684072734;
				short num2 = num;
				num = (short)632102686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)404422656;
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
				num = (short)1239023616;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonKey_A22905.Editable = value;
			}
		}

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x06007587 RID: 30087 RVA: 0x0069F8A4 File Offset: 0x0069DAA4
		internal string SwitchRotaryControlButtonKey_A22905_UILabel
		{
			get
			{
				short num = (short)88132643;
				short num2 = num;
				num = (short)933284899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)19660800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)67633153;
				if (num != 0)
				{
				}
				num = (short)648282112;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonKey_A22905.UIName;
			}
		}

		// Token: 0x17003C89 RID: 15497
		// (get) Token: 0x06007588 RID: 30088 RVA: 0x0069F958 File Offset: 0x0069DB58
		// (set) Token: 0x06007589 RID: 30089 RVA: 0x0069FA0C File Offset: 0x0069DC0C
		internal bool SwitchRotaryControlButtonKey_A22905_HiddenStatic
		{
			get
			{
				short num = (short)882085359;
				short num2 = num;
				num = (short)1982500335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1513226240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)762052609;
				if (num != 0)
				{
				}
				num = (short)1314586624;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonKey_A22905.HiddenStatic;
			}
			set
			{
				short num = (short)601292801;
				if (num != 0)
				{
				}
				num = (short)220659712;
				short num2 = num;
				num = (short)174854788;
				short num3 = num;
				num = (short)1873023620;
				switch (num3 == num)
				{
				}
				num = (short)1450573824;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonKey_A22905.HiddenStatic = value;
			}
		}

		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x0600758A RID: 30090 RVA: 0x0069FAC4 File Offset: 0x0069DCC4
		// (set) Token: 0x0600758B RID: 30091 RVA: 0x0069FB78 File Offset: 0x0069DD78
		internal bool SwitchRotaryControlButtonKey_A22905_HiddenDynamic
		{
			get
			{
				short num = (short)1671894884;
				short num2 = num;
				num = (short)1139939172;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431095808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1909456897;
				if (num != 0)
				{
				}
				num = (short)35717120;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonKey_A22905.HiddenDynamic;
			}
			set
			{
				short num = (short)1707401970;
				short num2 = num;
				num = (short)1749213938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1427308544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)439484417;
				if (num != 0)
				{
				}
				num = (short)984023040;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonKey_A22905.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x0600758C RID: 30092 RVA: 0x0069FC2C File Offset: 0x0069DE2C
		public bool SwitchRotaryControlButtonKey_A22905_HasDiffs
		{
			get
			{
				short num = (short)189166351;
				short num2 = num;
				num = (short)55145231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1282867200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1522663424;
				if (num != 0)
				{
				}
				num = (short)877199361;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonKey_A22905._HasDiffs;
			}
		}

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0600758D RID: 30093 RVA: 0x0069FCE4 File Offset: 0x0069DEE4
		// (set) Token: 0x0600758E RID: 30094 RVA: 0x0069FD98 File Offset: 0x0069DF98
		public int SwitchRotaryControlButtonBCO_A22906Value
		{
			get
			{
				short num = (short)896287105;
				short num2 = num;
				num = (short)32457089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)166395904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467140609;
				if (num != 0)
				{
				}
				num = (short)596770816;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906.Value;
			}
			set
			{
				short num = (short)2106246867;
				short num2 = num;
				num = (short)19121875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1780678656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1322975232;
				if (num != 0)
				{
				}
				num = (short)849674241;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonBCO_A22906.Value = value;
			}
		}

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x0600758F RID: 30095 RVA: 0x0069FE50 File Offset: 0x0069E050
		// (set) Token: 0x06007590 RID: 30096 RVA: 0x0069FF04 File Offset: 0x0069E104
		public string SwitchRotaryControlButtonBCO_A22906_UIValue
		{
			get
			{
				short num = (short)832224384;
				short num2 = num;
				num = (short)124828800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)615907328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)459079680;
				if (num != 0)
				{
				}
				num = (short)1414791169;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906.UIValue;
			}
			set
			{
				short num = (short)2060994874;
				short num2 = num;
				num = (short)1088112954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1972174848;
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
				num = (short)100597760;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonBCO_A22906.UIValue = value;
			}
		}

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x06007591 RID: 30097 RVA: 0x0069FFBC File Offset: 0x0069E1BC
		public global::AcpBusinessLayer.AcpListField SwitchRotaryControlButtonBCO_A22906
		{
			get
			{
				short num = (short)1872148957;
				short num2 = num;
				num = (short)1886108125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1942290432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)917569536;
				if (num != 0)
				{
				}
				num = (short)1254621185;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906;
			}
		}

		// Token: 0x17003C8F RID: 15503
		// (get) Token: 0x06007592 RID: 30098 RVA: 0x006A006C File Offset: 0x0069E26C
		// (set) Token: 0x06007593 RID: 30099 RVA: 0x006A0120 File Offset: 0x0069E320
		public bool SwitchRotaryControlButtonBCO_A22906_Applicable
		{
			get
			{
				short num = (short)1921735914;
				short num2 = num;
				num = (short)1708416234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)556597248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)227606529;
				if (num != 0)
				{
				}
				num = (short)396951552;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906.Applicable;
			}
			set
			{
				short num = (short)1600610940;
				short num2 = num;
				num = (short)2047369852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)731185152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1309999104;
				if (num != 0)
				{
				}
				num = (short)1344339969;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonBCO_A22906.Applicable = value;
			}
		}

		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x06007594 RID: 30100 RVA: 0x006A01D8 File Offset: 0x0069E3D8
		// (set) Token: 0x06007595 RID: 30101 RVA: 0x006A028C File Offset: 0x0069E48C
		public bool SwitchRotaryControlButtonBCO_A22906_Valid
		{
			get
			{
				short num = (short)1831899565;
				short num2 = num;
				num = (short)496931245;
				switch (num2 == num)
				{
				default:
				{
					num = (short)465829888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2142240769;
				if (num != 0)
				{
				}
				num = (short)699990016;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906.Valid;
			}
			set
			{
				short num = (short)2139200294;
				short num2 = num;
				num = (short)448961318;
				switch (num2 == num)
				{
				default:
				{
					num = (short)626720768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)11927553;
				if (num != 0)
				{
				}
				num = (short)2047344640;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonBCO_A22906.Valid = value;
			}
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x06007596 RID: 30102 RVA: 0x006A0340 File Offset: 0x0069E540
		// (set) Token: 0x06007597 RID: 30103 RVA: 0x006A03F8 File Offset: 0x0069E5F8
		public bool SwitchRotaryControlButtonBCO_A22906_Visible
		{
			get
			{
				short num = (short)2090654007;
				short num2 = num;
				num = (short)741792055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964769280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2102657024;
				if (num != 0)
				{
				}
				num = (short)510459905;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906.Visible;
			}
			set
			{
				short num = (short)1539494157;
				short num2 = num;
				num = (short)1576915213;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1269891072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1760624641;
				if (num != 0)
				{
				}
				num = (short)1727528960;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonBCO_A22906.Visible = value;
			}
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x06007598 RID: 30104 RVA: 0x006A04B0 File Offset: 0x0069E6B0
		// (set) Token: 0x06007599 RID: 30105 RVA: 0x006A0564 File Offset: 0x0069E764
		public bool SwitchRotaryControlButtonBCO_A22906_Editable
		{
			get
			{
				short num = (short)1681877298;
				short num2 = num;
				num = (short)461269298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)442564608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)802095105;
				if (num != 0)
				{
				}
				num = (short)1932132352;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906.Editable;
			}
			set
			{
				short num = (short)1104094580;
				short num2 = num;
				num = (short)69150068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2079522816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1053949952;
				if (num != 0)
				{
				}
				num = (short)1492451329;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonBCO_A22906.Editable = value;
			}
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x0600759A RID: 30106 RVA: 0x006A061C File Offset: 0x0069E81C
		internal string SwitchRotaryControlButtonBCO_A22906_UILabel
		{
			get
			{
				short num = (short)1323223613;
				short num2 = num;
				num = (short)1234356797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2147287040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)938475521;
				if (num != 0)
				{
				}
				num = (short)959512576;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906.UIName;
			}
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x0600759B RID: 30107 RVA: 0x006A06D0 File Offset: 0x0069E8D0
		// (set) Token: 0x0600759C RID: 30108 RVA: 0x006A0788 File Offset: 0x0069E988
		internal bool SwitchRotaryControlButtonBCO_A22906_HiddenStatic
		{
			get
			{
				short num = (short)439111132;
				short num2 = num;
				num = (short)1594641884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1803026432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)899153920;
				if (num != 0)
				{
				}
				num = (short)548077569;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906.HiddenStatic;
			}
			set
			{
				short num = (short)1707495994;
				short num2 = num;
				num = (short)2056081978;
				switch (num2 == num)
				{
				default:
				{
					num = (short)924647424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)380370944;
				if (num != 0)
				{
				}
				num = (short)218955777;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonBCO_A22906.HiddenStatic = value;
			}
		}

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x0600759D RID: 30109 RVA: 0x006A083C File Offset: 0x0069EA3C
		// (set) Token: 0x0600759E RID: 30110 RVA: 0x006A08F4 File Offset: 0x0069EAF4
		internal bool SwitchRotaryControlButtonBCO_A22906_HiddenDynamic
		{
			get
			{
				short num = (short)1076062057;
				short num2 = num;
				num = (short)832464745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2056912896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)131596289;
				if (num != 0)
				{
				}
				num = (short)1659174912;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906.HiddenDynamic;
			}
			set
			{
				short num = (short)35678548;
				short num2 = num;
				num = (short)705849684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1497300992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)564133889;
				if (num != 0)
				{
				}
				num = (short)200015872;
				if (num != 0)
				{
				}
				this.switchRotaryControlButtonBCO_A22906.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0600759F RID: 30111 RVA: 0x006A09AC File Offset: 0x0069EBAC
		public bool SwitchRotaryControlButtonBCO_A22906_HasDiffs
		{
			get
			{
				short num = (short)2110772988;
				short num2 = num;
				num = (short)732813052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1648164864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2028666880;
				if (num != 0)
				{
				}
				num = (short)1561985025;
				if (num != 0)
				{
				}
				return this.switchRotaryControlButtonBCO_A22906._HasDiffs;
			}
		}

		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x060075A0 RID: 30112 RVA: 0x006A0A60 File Offset: 0x0069EC60
		// (set) Token: 0x060075A1 RID: 30113 RVA: 0x006A0B18 File Offset: 0x0069ED18
		public int SwitchRotaryControlShortPressTimeValue
		{
			get
			{
				short num = (short)446420554;
				short num2 = num;
				num = (short)974050890;
				switch (num2 == num)
				{
				default:
				{
					num = (short)967442432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1022885889;
				if (num != 0)
				{
				}
				num = (short)136577024;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.Value;
			}
			set
			{
				short num = (short)54774793;
				short num2 = num;
				num = (short)1939262473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1444937728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)832569345;
				if (num != 0)
				{
				}
				num = (short)338427904;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.Value = value;
			}
		}

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x060075A2 RID: 30114 RVA: 0x006A0BCC File Offset: 0x0069EDCC
		// (set) Token: 0x060075A3 RID: 30115 RVA: 0x006A0C80 File Offset: 0x0069EE80
		public string SwitchRotaryControlShortPressTime_UIValue
		{
			get
			{
				short num = (short)816640085;
				short num2 = num;
				num = (short)974909525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1201537024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)845414401;
				if (num != 0)
				{
				}
				num = (short)773324800;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.UIValue;
			}
			set
			{
				short num = (short)2070953791;
				short num2 = num;
				num = (short)544030527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)102170624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1691353089;
				if (num != 0)
				{
				}
				num = (short)1242693632;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.UIValue = value;
			}
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x060075A4 RID: 30116 RVA: 0x006A0D38 File Offset: 0x0069EF38
		public global::AcpBusinessLayer.AcpSimpleRangeField SwitchRotaryControlShortPressTime
		{
			get
			{
				short num = (short)497473507;
				short num2 = num;
				num = (short)787535843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1099890688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1873674241;
				if (num != 0)
				{
				}
				num = (short)763035648;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime;
			}
		}

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x060075A5 RID: 30117 RVA: 0x006A0DEC File Offset: 0x0069EFEC
		// (set) Token: 0x060075A6 RID: 30118 RVA: 0x006A0EA0 File Offset: 0x0069F0A0
		internal int SwitchRotaryControlShortPressTimeMin
		{
			get
			{
				short num = (short)1827471361;
				if (num != 0)
				{
				}
				num = (short)1241120768;
				short num2 = num;
				num = (short)1856598840;
				short num3 = num;
				num = (short)588739384;
				switch (num3 == num)
				{
				}
				num = (short)1910177792;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.Min;
			}
			set
			{
				short num = (short)560630745;
				short num2 = num;
				num = (short)1097305049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)462684160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)612761601;
				if (num != 0)
				{
				}
				num = (short)768344064;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.Min = value;
			}
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x060075A7 RID: 30119 RVA: 0x006A0F54 File Offset: 0x0069F154
		// (set) Token: 0x060075A8 RID: 30120 RVA: 0x006A100C File Offset: 0x0069F20C
		internal int SwitchRotaryControlShortPressTimeMax
		{
			get
			{
				short num = (short)1840251928;
				short num2 = num;
				num = (short)359924760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)326369280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)528547841;
				if (num != 0)
				{
				}
				num = (short)1163984896;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.Max;
			}
			set
			{
				short num = (short)2063900771;
				short num2 = num;
				num = (short)921542755;
				switch (num2 == num)
				{
				default:
				{
					num = (short)20119552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1785135104;
				if (num != 0)
				{
				}
				num = (short)170786817;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.Max = value;
			}
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x060075A9 RID: 30121 RVA: 0x006A10C4 File Offset: 0x0069F2C4
		// (set) Token: 0x060075AA RID: 30122 RVA: 0x006A1178 File Offset: 0x0069F378
		internal int SwitchRotaryControlShortPressTimeStep
		{
			get
			{
				short num = (short)891277539;
				short num2 = num;
				num = (short)1562759395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1716649984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1028784128;
				if (num != 0)
				{
				}
				num = (short)1426128897;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.StepSize;
			}
			set
			{
				short num = (short)999506403;
				short num2 = num;
				num = (short)2113094115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)555614208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)783679489;
				if (num != 0)
				{
				}
				num = (short)1610481664;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.StepSize = value;
			}
		}

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x060075AB RID: 30123 RVA: 0x006A122C File Offset: 0x0069F42C
		// (set) Token: 0x060075AC RID: 30124 RVA: 0x006A12E0 File Offset: 0x0069F4E0
		public bool SwitchRotaryControlShortPressTime_Applicable
		{
			get
			{
				short num = (short)1052264204;
				short num2 = num;
				num = (short)1853900556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144337920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)393084929;
				if (num != 0)
				{
				}
				num = (short)1024262144;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.Applicable;
			}
			set
			{
				short num = (short)915013633;
				if (num != 0)
				{
				}
				num = (short)1481572352;
				short num2 = num;
				num = (short)2124228326;
				short num3 = num;
				num = (short)493299430;
				switch (num3 == num)
				{
				}
				num = (short)1191247872;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.Applicable = value;
			}
		}

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x060075AD RID: 30125 RVA: 0x006A1394 File Offset: 0x0069F594
		// (set) Token: 0x060075AE RID: 30126 RVA: 0x006A1448 File Offset: 0x0069F648
		public bool SwitchRotaryControlShortPressTime_Valid
		{
			get
			{
				short num = (short)1341128705;
				if (num != 0)
				{
				}
				num = (short)1800470528;
				short num2 = num;
				num = (short)1589956048;
				short num3 = num;
				num = (short)1086770640;
				switch (num3 == num)
				{
				}
				num = (short)1229062144;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.Valid;
			}
			set
			{
				short num = (short)427884892;
				short num2 = num;
				num = (short)1121911132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1192099840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1519058944;
				if (num != 0)
				{
				}
				num = (short)581042177;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.Valid = value;
			}
		}

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x060075AF RID: 30127 RVA: 0x006A1500 File Offset: 0x0069F700
		// (set) Token: 0x060075B0 RID: 30128 RVA: 0x006A15B8 File Offset: 0x0069F7B8
		public bool SwitchRotaryControlShortPressTime_Visible
		{
			get
			{
				short num = (short)183495076;
				short num2 = num;
				num = (short)671607204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)290652160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1925054465;
				if (num != 0)
				{
				}
				num = (short)697827328;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.Visible;
			}
			set
			{
				short num = (short)993716059;
				short num2 = num;
				num = (short)431482715;
				switch (num2 == num)
				{
				default:
				{
					num = (short)770703360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1704067073;
				if (num != 0)
				{
				}
				num = (short)257753088;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.Visible = value;
			}
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x060075B1 RID: 30129 RVA: 0x006A166C File Offset: 0x0069F86C
		// (set) Token: 0x060075B2 RID: 30130 RVA: 0x006A1724 File Offset: 0x0069F924
		public bool SwitchRotaryControlShortPressTime_Editable
		{
			get
			{
				short num = (short)252386853;
				short num2 = num;
				num = (short)881663525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616969728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1563688961;
				if (num != 0)
				{
				}
				num = (short)922025984;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.Editable;
			}
			set
			{
				short num = (short)905773057;
				if (num != 0)
				{
				}
				num = (short)567607296;
				short num2 = num;
				num = (short)1077970011;
				short num3 = num;
				num = (short)597918811;
				switch (num3 == num)
				{
				}
				num = (short)2119041024;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.Editable = value;
			}
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x060075B3 RID: 30131 RVA: 0x006A17D8 File Offset: 0x0069F9D8
		internal string SwitchRotaryControlShortPressTime_UILabel
		{
			get
			{
				short num = (short)2136905881;
				short num2 = num;
				num = (short)20289689;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1017839616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1160577024;
				if (num != 0)
				{
				}
				num = (short)1772290049;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.UIName;
			}
		}

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x060075B4 RID: 30132 RVA: 0x006A1888 File Offset: 0x0069FA88
		// (set) Token: 0x060075B5 RID: 30133 RVA: 0x006A193C File Offset: 0x0069FB3C
		internal bool SwitchRotaryControlShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)777322497;
				if (num != 0)
				{
				}
				num = (short)2139422720;
				short num2 = num;
				num = (short)1071693;
				short num3 = num;
				num = (short)18307661;
				switch (num3 == num)
				{
				}
				num = (short)1684733952;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)121632145;
				short num2 = num;
				num = (short)417133969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1414070272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1013710849;
				if (num != 0)
				{
				}
				num = (short)1193541632;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x060075B6 RID: 30134 RVA: 0x006A19F4 File Offset: 0x0069FBF4
		// (set) Token: 0x060075B7 RID: 30135 RVA: 0x006A1AA8 File Offset: 0x0069FCA8
		internal bool SwitchRotaryControlShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)941359105;
				if (num != 0)
				{
				}
				num = (short)142147584;
				short num2 = num;
				num = (short)31918551;
				short num3 = num;
				num = (short)2054687191;
				switch (num3 == num)
				{
				}
				num = (short)1821048832;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)610576066;
				short num2 = num;
				num = (short)538486466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)484835328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758841344;
				if (num != 0)
				{
				}
				num = (short)1957494785;
				if (num != 0)
				{
				}
				this.switchRotaryControlShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x060075B8 RID: 30136 RVA: 0x006A1B58 File Offset: 0x0069FD58
		public bool SwitchRotaryControlShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)1274555137;
				short num2 = num;
				num = (short)1476864769;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1494351872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)434962433;
				if (num != 0)
				{
				}
				num = (short)531038208;
				if (num != 0)
				{
				}
				return this.switchRotaryControlShortPressTime._HasDiffs;
			}
		}

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x060075B9 RID: 30137 RVA: 0x006A1C0C File Offset: 0x0069FE0C
		// (set) Token: 0x060075BA RID: 30138 RVA: 0x006A1CC0 File Offset: 0x0069FEC0
		public int SwitchRotaryControlLongPressTimeValue
		{
			get
			{
				short num = (short)2043150337;
				if (num != 0)
				{
				}
				num = (short)917045248;
				short num2 = num;
				num = (short)79729438;
				short num3 = num;
				num = (short)362844958;
				switch (num3 == num)
				{
				}
				num = (short)997457920;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.Value;
			}
			set
			{
				short num = (short)2085357860;
				short num2 = num;
				num = (short)2142112036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)446693376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)817233921;
				if (num != 0)
				{
				}
				num = (short)1340407808;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.Value = value;
			}
		}

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x060075BB RID: 30139 RVA: 0x006A1D78 File Offset: 0x0069FF78
		// (set) Token: 0x060075BC RID: 30140 RVA: 0x006A1E2C File Offset: 0x006A002C
		public string SwitchRotaryControlLongPressTime_UIValue
		{
			get
			{
				short num = (short)1140790311;
				short num2 = num;
				num = (short)945099815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217003520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2042953728;
				if (num != 0)
				{
				}
				num = (short)184549377;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.UIValue;
			}
			set
			{
				short num = (short)1718170994;
				short num2 = num;
				num = (short)369898866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1369767936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554055169;
				if (num != 0)
				{
				}
				num = (short)647233536;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x060075BD RID: 30141 RVA: 0x006A1EE0 File Offset: 0x006A00E0
		public global::AcpBusinessLayer.AcpSimpleRangeField SwitchRotaryControlLongPressTime
		{
			get
			{
				short num = (short)176214337;
				short num2 = num;
				num = (short)639357249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1149370368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1603207169;
				if (num != 0)
				{
				}
				num = (short)2006908928;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime;
			}
		}

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x060075BE RID: 30142 RVA: 0x006A1F90 File Offset: 0x006A0190
		// (set) Token: 0x060075BF RID: 30143 RVA: 0x006A2044 File Offset: 0x006A0244
		internal int SwitchRotaryControlLongPressTimeMin
		{
			get
			{
				short num = (short)1709406697;
				short num2 = num;
				num = (short)1683913193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)7733248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1834287105;
				if (num != 0)
				{
				}
				num = (short)2028142592;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.Min;
			}
			set
			{
				short num = (short)795092614;
				short num2 = num;
				num = (short)846341766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1779695616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1753284608;
				if (num != 0)
				{
				}
				num = (short)1855258625;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.Min = value;
			}
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x060075C0 RID: 30144 RVA: 0x006A20F8 File Offset: 0x006A02F8
		// (set) Token: 0x060075C1 RID: 30145 RVA: 0x006A21B0 File Offset: 0x006A03B0
		internal int SwitchRotaryControlLongPressTimeMax
		{
			get
			{
				short num = (short)1797368112;
				short num2 = num;
				num = (short)968403248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1818820608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2033582081;
				if (num != 0)
				{
				}
				num = (short)915996672;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.Max;
			}
			set
			{
				short num = (short)976765032;
				short num2 = num;
				num = (short)468074600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1112539136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1172307968;
				if (num != 0)
				{
				}
				num = (short)592379905;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.Max = value;
			}
		}

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x060075C2 RID: 30146 RVA: 0x006A2264 File Offset: 0x006A0464
		// (set) Token: 0x060075C3 RID: 30147 RVA: 0x006A2318 File Offset: 0x006A0518
		internal int SwitchRotaryControlLongPressTimeStep
		{
			get
			{
				short num = (short)1555696807;
				short num2 = num;
				num = (short)473238695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)148439040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)215941120;
				if (num != 0)
				{
				}
				num = (short)2070872065;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.StepSize;
			}
			set
			{
				short num = (short)476358406;
				short num2 = num;
				num = (short)1486006022;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1011351552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1428488193;
				if (num != 0)
				{
				}
				num = (short)1694760960;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.StepSize = value;
			}
		}

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x060075C4 RID: 30148 RVA: 0x006A23CC File Offset: 0x006A05CC
		// (set) Token: 0x060075C5 RID: 30149 RVA: 0x006A2480 File Offset: 0x006A0680
		public bool SwitchRotaryControlLongPressTime_Applicable
		{
			get
			{
				short num = (short)1889161515;
				short num2 = num;
				num = (short)1174819115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)978649088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1734148097;
				if (num != 0)
				{
				}
				num = (short)685768704;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.Applicable;
			}
			set
			{
				short num = (short)958039956;
				short num2 = num;
				num = (short)1129219988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2003959808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1277165569;
				if (num != 0)
				{
				}
				num = (short)287571968;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.Applicable = value;
			}
		}

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x060075C6 RID: 30150 RVA: 0x006A2538 File Offset: 0x006A0738
		// (set) Token: 0x060075C7 RID: 30151 RVA: 0x006A25EC File Offset: 0x006A07EC
		public bool SwitchRotaryControlLongPressTime_Valid
		{
			get
			{
				short num = (short)1095885980;
				short num2 = num;
				num = (short)2122966172;
				switch (num2 == num)
				{
				default:
				{
					num = (short)374603776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)816578561;
				if (num != 0)
				{
				}
				num = (short)1392246784;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.Valid;
			}
			set
			{
				short num = (short)688848897;
				if (num != 0)
				{
				}
				num = (short)156368896;
				short num2 = num;
				num = (short)1635833345;
				short num3 = num;
				num = (short)1146803713;
				switch (num3 == num)
				{
				}
				num = (short)1996029952;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.Valid = value;
			}
		}

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x060075C8 RID: 30152 RVA: 0x006A26A0 File Offset: 0x006A08A0
		// (set) Token: 0x060075C9 RID: 30153 RVA: 0x006A2754 File Offset: 0x006A0954
		public bool SwitchRotaryControlLongPressTime_Visible
		{
			get
			{
				short num = (short)183184900;
				short num2 = num;
				num = (short)979054084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1108934656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109838337;
				if (num != 0)
				{
				}
				num = (short)816185344;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.Visible;
			}
			set
			{
				short num = (short)1031887058;
				short num2 = num;
				num = (short)1055873234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1047724032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1017905153;
				if (num != 0)
				{
				}
				num = (short)1350238208;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.Visible = value;
			}
		}

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x060075CA RID: 30154 RVA: 0x006A280C File Offset: 0x006A0A0C
		// (set) Token: 0x060075CB RID: 30155 RVA: 0x006A28C4 File Offset: 0x006A0AC4
		public bool SwitchRotaryControlLongPressTime_Editable
		{
			get
			{
				short num = (short)1617543705;
				short num2 = num;
				num = (short)1243136537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)862846976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)884146176;
				if (num != 0)
				{
				}
				num = (short)624164865;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.Editable;
			}
			set
			{
				short num = (short)134856905;
				short num2 = num;
				num = (short)248955081;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1068892160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)401670145;
				if (num != 0)
				{
				}
				num = (short)779943936;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.Editable = value;
			}
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x060075CC RID: 30156 RVA: 0x006A297C File Offset: 0x006A0B7C
		internal string SwitchRotaryControlLongPressTime_UILabel
		{
			get
			{
				short num = (short)1455357953;
				if (num != 0)
				{
				}
				num = (short)318504960;
				short num2 = num;
				num = (short)1757174082;
				short num3 = num;
				num = (short)1168136514;
				switch (num3 == num)
				{
				}
				num = (short)700776448;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.UIName;
			}
		}

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x060075CD RID: 30157 RVA: 0x006A2A34 File Offset: 0x006A0C34
		// (set) Token: 0x060075CE RID: 30158 RVA: 0x006A2AE8 File Offset: 0x006A0CE8
		internal bool SwitchRotaryControlLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1082626602;
				short num2 = num;
				num = (short)1702793770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)796524544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1124270080;
				if (num != 0)
				{
				}
				num = (short)1848246273;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)2107288102;
				short num2 = num;
				num = (short)927050278;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2064515072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)465043457;
				if (num != 0)
				{
				}
				num = (short)2007891968;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x060075CF RID: 30159 RVA: 0x006A2B9C File Offset: 0x006A0D9C
		// (set) Token: 0x060075D0 RID: 30160 RVA: 0x006A2C54 File Offset: 0x006A0E54
		internal bool SwitchRotaryControlLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)943587329;
				if (num != 0)
				{
				}
				num = (short)2111045632;
				short num2 = num;
				num = (short)154311522;
				short num3 = num;
				num = (short)838835042;
				switch (num3 == num)
				{
				}
				num = (short)23789568;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1023550487;
				short num2 = num;
				num = (short)1466246167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)916717568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)305332224;
				if (num != 0)
				{
				}
				num = (short)603193345;
				if (num != 0)
				{
				}
				this.switchRotaryControlLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x060075D1 RID: 30161 RVA: 0x006A2D0C File Offset: 0x006A0F0C
		public bool SwitchRotaryControlLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)1981997208;
				short num2 = num;
				num = (short)1494081688;
				switch (num2 == num)
				{
				default:
				{
					num = (short)764608512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1166475264;
				if (num != 0)
				{
				}
				num = (short)119603201;
				if (num != 0)
				{
				}
				return this.switchRotaryControlLongPressTime._HasDiffs;
			}
		}

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x060075D2 RID: 30162 RVA: 0x006A2DC4 File Offset: 0x006A0FC4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)119629440;
				short num2 = num;
				num = (short)870672000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1736638464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751304705;
				if (num != 0)
				{
				}
				num = (short)481296384;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x006A2E84 File Offset: 0x006A1084
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)208928770;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1481716756;
					short num3 = num2;
					num2 = (short)1127625748;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_10D;
					}
					break;
				}
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)771227652;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1025638401;
						if (num2 != 0)
						{
						}
						num2 = (short)243204096;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)171900929;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_10D:
			num2 = (short)1639907328;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			num2 = (short)492109824;
			short num4 = num2;
			result = null;
			num2 = (short)853803011;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002F85 RID: 12165
		private global::AcpBusinessLayer.AcpListField switchGeneralRotaryControl_A8984;

		// Token: 0x04002F86 RID: 12166
		private global::AcpBusinessLayer.AcpField<string> switchRotaryControlButtonName_A22903;

		// Token: 0x04002F87 RID: 12167
		private global::AcpBusinessLayer.AcpKeyField switchRotaryControlButtonKey_A22905;

		// Token: 0x04002F88 RID: 12168
		private global::AcpBusinessLayer.AcpListField switchRotaryControlButtonBCO_A22906;

		// Token: 0x04002F89 RID: 12169
		private global::AcpBusinessLayer.AcpSimpleRangeField switchRotaryControlShortPressTime;

		// Token: 0x04002F8A RID: 12170
		private global::AcpBusinessLayer.AcpSimpleRangeField switchRotaryControlLongPressTime;
	}
}
