using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000379 RID: 889
	[global::System.Serializable]
	public class O9NavigationControlsTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008385 RID: 33669 RVA: 0x007A4ECC File Offset: 0x007A30CC
		public O9NavigationControlsTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008386 RID: 33670 RVA: 0x007A4EE8 File Offset: 0x007A30E8
		protected O9NavigationControlsTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008387 RID: 33671 RVA: 0x007A4F00 File Offset: 0x007A3100
		public override void Init()
		{
			int a_ = 12;
			short num = (short)1075405666;
			short num2 = num;
			num = (short)1819698018;
			switch (num2 == num)
			{
			}
			num = (short)224329729;
			if (num != 0)
			{
			}
			num = (short)2134048768;
			if (num != 0)
			{
			}
			num = (short)418709504;
			short num3 = num;
			this.radErgoControlO9NaviControlName_A41370 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚닜뇞闠釢諤详ꛨ틪ꏬ軮蟰髲뛴飶韸迺迼郾洀䴂搄樆氈吊䰌㬎‐‒∔✖", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgoControlO9NaviControlName_A41370.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlO9NaviControlName_A41370.DataTransferOrder = -1;
			this.radErgoControlO9NaviControlFeature_A41371 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgoControlO9NaviControlFeature_A41371LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgoControlO9NaviControlFeature_A41371LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚닜뇞闠釢諤详ꛨ틪ꏬ軮蟰髲뛴飶韸迺迼郾洀䔂怄昆紈縊缌樎丐划℔☖⨘ⰚⰜ", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgoControlO9NaviControlFeature_A41371LovStrs);
			this.radErgoControlO9NaviControlFeature_A41371.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlO9NaviControlFeature_A41371.DataTransferOrder = 20;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菌껎Ꟑ뫒닔뛖귘닚닜뇞쇠ꃢ諤触鷨駪苬菮苰", a_);
			base.Id = 10734;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 12;
		}

		// Token: 0x06008388 RID: 33672 RVA: 0x007A5070 File Offset: 0x007A3270
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)1063256069;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_208;
				case 1:
					this.radErgoControlO9NaviControlFeature_A41371 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgoControlO9NaviControlFeature_A41371LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgoControlO9NaviControlFeature_A41371LovStrs), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒雔룖럘꿚꿜냞跠곢\udce4ꧦ裨鷪蓬곮黰鷲致藶雸韺민髾怀眂瀄甆氈吊䰌㬎‐‒∔☖", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgoControlO9NaviControlFeature_A41371LovStrs);
					this.radErgoControlO9NaviControlFeature_A41371.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlO9NaviControlFeature_A41371.DataTransferOrder = 20;
					num = (short)1463746560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.radErgoControlO9NaviControlName_A41370 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒雔룖럘꿚꿜냞跠곢\udce4ꧦ裨鷪蓬곮黰鷲致藶雸韺돼黾氀昂娄䘆㴈㨊㸌㠎ℐ", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgoControlO9NaviControlName_A41370.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlO9NaviControlName_A41370.DataTransferOrder = -1;
					num = (short)558628872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_273;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒雔룖럘꿚꿜냞跠곢\udce4ꧦ裨鷪蓬곮黰鷲致藶雸韺민髾怀眂瀄甆氈吊䰌㬎‐‒∔☖", a_)))
					{
						num = (short)473628673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A9;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 6:
					num = (short)1923809287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1967784486;
					short num3 = num;
					num = (short)129106470;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_273;
					default:
						num = (short)533135360;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)564592649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A9;
					}
					break;
				}
				case 8:
					goto IL_78;
				case 9:
					num = (short)1513750531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1736245254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2A9;
				IL_78:
				num = (short)262602756;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_273:
				if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒雔룖럘꿚꿜냞跠곢\udce4ꧦ裨鷪蓬곮黰鷲致藶雸韺돼黾氀昂娄䘆㴈㨊㸌㠎ℐ", a_)))
				{
					goto IL_78;
				}
				num = (short)1968570370;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_208:
			num = (short)1127874561;
			if (num != 0)
			{
			}
			num = (short)1407582208;
			short num4 = num;
			IL_2A9:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("视꣈뷊꓌꣎냐꟒볔룖럘ﯚ黜냞迠韢韤裦藨飪", a_);
			base.Id = 10734;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 12;
		}

		// Token: 0x06008389 RID: 33673 RVA: 0x007A5358 File Offset: 0x007A3558
		public override void PopulateReferences()
		{
			short num = (short)1758602460;
			short num2 = num;
			num = (short)384181468;
			switch (num2 == num)
			{
			}
			num = (short)1013448705;
			if (num != 0)
			{
			}
			num = (short)1595277312;
			if (num != 0)
			{
			}
			num = (short)949420032;
			short num3 = num;
		}

		// Token: 0x0600838A RID: 33674 RVA: 0x007A5400 File Offset: 0x007A3600
		public override void DropReferences()
		{
			short num = (short)1445920769;
			if (num != 0)
			{
			}
			num = (short)1698230546;
			short num2 = num;
			num = (short)911864082;
			switch (num2 == num)
			{
			}
			num = (short)1517813760;
			if (num != 0)
			{
			}
			num = (short)2093219840;
			short num3 = num;
		}

		// Token: 0x0600838B RID: 33675 RVA: 0x007A54AC File Offset: 0x007A36AC
		public override void SetConstraints()
		{
			short num = (short)488177665;
			if (num != 0)
			{
			}
			num = (short)433320497;
			short num2 = num;
			num = (short)799142449;
			switch (num2 == num)
			{
			}
			num = (short)783745024;
			if (num != 0)
			{
			}
			num = (short)260046848;
			short num3 = num;
			this.radErgoControlO9NaviControlName_A41370.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoControlO9NaviControlFeature_A41371.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.radErgoControlO9NaviControlFeature_A41371.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.conDownButtonApplicable);
			this.radErgoControlO9NaviControlFeature_A41371.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConSyncUpDownBtnFeature);
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x007A55B0 File Offset: 0x007A37B0
		public override void SetupDependencies()
		{
			short num = (short)1106886370;
			short num2 = num;
			num = (short)2055519970;
			switch (num2 == num)
			{
			}
			num = (short)1947598848;
			if (num != 0)
			{
			}
			num = (short)993787905;
			if (num != 0)
			{
			}
			num = (short)1462304768;
			short num3 = num;
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoControlO9NaviControlFeature_A41371);
		}

		// Token: 0x170042FB RID: 17147
		// (get) Token: 0x0600838D RID: 33677 RVA: 0x007A5678 File Offset: 0x007A3878
		public bool HasDiffs
		{
			get
			{
				short num = (short)1801160020;
				short num2 = num;
				num = (short)842171732;
				switch (num2 == num)
				{
				}
				num = (short)325058561;
				if (num != 0)
				{
				}
				num = (short)1298530304;
				if (num != 0)
				{
				}
				num = (short)869728256;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170042FC RID: 17148
		// (get) Token: 0x0600838E RID: 33678 RVA: 0x007A5728 File Offset: 0x007A3928
		// (set) Token: 0x0600838F RID: 33679 RVA: 0x007A57DC File Offset: 0x007A39DC
		public string RadErgoControlO9NaviControlName_A41370Value
		{
			get
			{
				short num = (short)148766721;
				if (num != 0)
				{
				}
				num = (short)223642997;
				short num2 = num;
				num = (short)1038910837;
				switch (num2 == num)
				{
				}
				num = (short)535953408;
				if (num != 0)
				{
				}
				num = (short)71434240;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370.Value;
			}
			set
			{
				short num = (short)522147831;
				short num2 = num;
				num = (short)602560503;
				switch (num2 == num)
				{
				}
				num = (short)982384641;
				if (num != 0)
				{
				}
				num = (short)1714946048;
				if (num != 0)
				{
				}
				num = (short)71630848;
				short num3 = num;
				this.radErgoControlO9NaviControlName_A41370.Value = value;
			}
		}

		// Token: 0x170042FD RID: 17149
		// (get) Token: 0x06008390 RID: 33680 RVA: 0x007A5890 File Offset: 0x007A3A90
		public global::AcpBusinessLayer.AcpField<string> RadErgoControlO9NaviControlName_A41370
		{
			get
			{
				short num = (short)220850074;
				short num2 = num;
				num = (short)285599642;
				switch (num2 == num)
				{
				}
				num = (short)1329856512;
				if (num != 0)
				{
				}
				num = (short)1240924161;
				if (num != 0)
				{
				}
				num = (short)1198063616;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370;
			}
		}

		// Token: 0x170042FE RID: 17150
		// (get) Token: 0x06008391 RID: 33681 RVA: 0x007A5940 File Offset: 0x007A3B40
		// (set) Token: 0x06008392 RID: 33682 RVA: 0x007A59F4 File Offset: 0x007A3BF4
		public string RadErgoControlO9NaviControlName_A41370_UIValue
		{
			get
			{
				short num = (short)705425143;
				short num2 = num;
				num = (short)2099769079;
				switch (num2 == num)
				{
				}
				num = (short)529989632;
				if (num != 0)
				{
				}
				num = (short)801112065;
				if (num != 0)
				{
				}
				num = (short)1193345024;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370.Value;
			}
			set
			{
				short num = (short)40694029;
				short num2 = num;
				num = (short)927658253;
				switch (num2 == num)
				{
				}
				num = (short)42467328;
				if (num != 0)
				{
				}
				num = (short)899153921;
				if (num != 0)
				{
				}
				num = (short)299368448;
				short num3 = num;
				this.radErgoControlO9NaviControlName_A41370.Value = value;
			}
		}

		// Token: 0x170042FF RID: 17151
		// (get) Token: 0x06008393 RID: 33683 RVA: 0x007A5AA8 File Offset: 0x007A3CA8
		// (set) Token: 0x06008394 RID: 33684 RVA: 0x007A5B5C File Offset: 0x007A3D5C
		public bool RadErgoControlO9NaviControlName_A41370_Applicable
		{
			get
			{
				short num = (short)630128641;
				if (num != 0)
				{
				}
				num = (short)1310829099;
				short num2 = num;
				num = (short)691841579;
				switch (num2 == num)
				{
				}
				num = (short)726925312;
				if (num != 0)
				{
				}
				num = (short)1311834112;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370.Applicable;
			}
			set
			{
				short num = (short)453203577;
				short num2 = num;
				num = (short)1280792185;
				switch (num2 == num)
				{
				}
				num = (short)2135359488;
				if (num != 0)
				{
				}
				num = (short)1385496577;
				if (num != 0)
				{
				}
				num = (short)436469760;
				short num3 = num;
				this.radErgoControlO9NaviControlName_A41370.Applicable = value;
			}
		}

		// Token: 0x17004300 RID: 17152
		// (get) Token: 0x06008395 RID: 33685 RVA: 0x007A5C14 File Offset: 0x007A3E14
		// (set) Token: 0x06008396 RID: 33686 RVA: 0x007A5CC8 File Offset: 0x007A3EC8
		public bool RadErgoControlO9NaviControlName_A41370_Valid
		{
			get
			{
				short num = (short)819504583;
				short num2 = num;
				num = (short)2007410119;
				switch (num2 == num)
				{
				}
				num = (short)687865856;
				if (num != 0)
				{
				}
				num = (short)1566572545;
				if (num != 0)
				{
				}
				num = (short)248184832;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370.Valid;
			}
			set
			{
				short num = (short)1867275516;
				short num2 = num;
				num = (short)1044339964;
				switch (num2 == num)
				{
				}
				num = (short)1925644289;
				if (num != 0)
				{
				}
				num = (short)14483456;
				if (num != 0)
				{
				}
				num = (short)1273757696;
				short num3 = num;
				this.radErgoControlO9NaviControlName_A41370.Valid = value;
			}
		}

		// Token: 0x17004301 RID: 17153
		// (get) Token: 0x06008397 RID: 33687 RVA: 0x007A5D80 File Offset: 0x007A3F80
		// (set) Token: 0x06008398 RID: 33688 RVA: 0x007A5E34 File Offset: 0x007A4034
		public bool RadErgoControlO9NaviControlName_A41370_Visible
		{
			get
			{
				short num = (short)1426971675;
				short num2 = num;
				num = (short)505469979;
				switch (num2 == num)
				{
				}
				num = (short)1540161536;
				if (num != 0)
				{
				}
				num = (short)883490817;
				if (num != 0)
				{
				}
				num = (short)493027328;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370.Visible;
			}
			set
			{
				short num = (short)756691375;
				short num2 = num;
				num = (short)1113797039;
				switch (num2 == num)
				{
				}
				num = (short)1628766209;
				if (num != 0)
				{
				}
				num = (short)486932480;
				if (num != 0)
				{
				}
				num = (short)677838848;
				short num3 = num;
				this.radErgoControlO9NaviControlName_A41370.Visible = value;
			}
		}

		// Token: 0x17004302 RID: 17154
		// (get) Token: 0x06008399 RID: 33689 RVA: 0x007A5EEC File Offset: 0x007A40EC
		// (set) Token: 0x0600839A RID: 33690 RVA: 0x007A5FA4 File Offset: 0x007A41A4
		public bool RadErgoControlO9NaviControlName_A41370_Editable
		{
			get
			{
				short num = (short)176060321;
				short num2 = num;
				num = (short)1440511905;
				switch (num2 == num)
				{
				}
				num = (short)1134755840;
				if (num != 0)
				{
				}
				num = (short)1429733377;
				if (num != 0)
				{
				}
				num = (short)848691200;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370.Editable;
			}
			set
			{
				short num = (short)853766071;
				short num2 = num;
				num = (short)469135287;
				switch (num2 == num)
				{
				}
				num = (short)878510080;
				if (num != 0)
				{
				}
				num = (short)3538945;
				if (num != 0)
				{
				}
				num = (short)1929641984;
				short num3 = num;
				this.radErgoControlO9NaviControlName_A41370.Editable = value;
			}
		}

		// Token: 0x17004303 RID: 17155
		// (get) Token: 0x0600839B RID: 33691 RVA: 0x007A6058 File Offset: 0x007A4258
		internal string RadErgoControlO9NaviControlName_A41370_UILabel
		{
			get
			{
				short num = (short)1711548187;
				short num2 = num;
				num = (short)845817627;
				switch (num2 == num)
				{
				}
				num = (short)1852047361;
				if (num != 0)
				{
				}
				num = (short)177537024;
				if (num != 0)
				{
				}
				num = (short)757989376;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370.UIName;
			}
		}

		// Token: 0x17004304 RID: 17156
		// (get) Token: 0x0600839C RID: 33692 RVA: 0x007A610C File Offset: 0x007A430C
		// (set) Token: 0x0600839D RID: 33693 RVA: 0x007A61C0 File Offset: 0x007A43C0
		internal bool RadErgoControlO9NaviControlName_A41370_HiddenStatic
		{
			get
			{
				short num = (short)1495457137;
				short num2 = num;
				num = (short)80797041;
				switch (num2 == num)
				{
				}
				num = (short)177537024;
				if (num != 0)
				{
				}
				num = (short)190775297;
				if (num != 0)
				{
				}
				num = (short)2021195776;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370.HiddenStatic;
			}
			set
			{
				short num = (short)53346305;
				if (num != 0)
				{
				}
				num = (short)896740328;
				short num2 = num;
				num = (short)518859752;
				switch (num2 == num)
				{
				}
				num = (short)1489240064;
				if (num != 0)
				{
				}
				num = (short)927465472;
				short num3 = num;
				this.radErgoControlO9NaviControlName_A41370.HiddenStatic = value;
			}
		}

		// Token: 0x17004305 RID: 17157
		// (get) Token: 0x0600839E RID: 33694 RVA: 0x007A6274 File Offset: 0x007A4474
		// (set) Token: 0x0600839F RID: 33695 RVA: 0x007A6328 File Offset: 0x007A4528
		internal bool RadErgoControlO9NaviControlName_A41370_HiddenDynamic
		{
			get
			{
				short num = (short)1282474799;
				short num2 = num;
				num = (short)1551893295;
				switch (num2 == num)
				{
				}
				num = (short)1067384833;
				if (num != 0)
				{
				}
				num = (short)544669696;
				if (num != 0)
				{
				}
				num = (short)1304559616;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370.HiddenDynamic;
			}
			set
			{
				short num = (short)1084872478;
				short num2 = num;
				num = (short)961140510;
				switch (num2 == num)
				{
				}
				num = (short)205127681;
				if (num != 0)
				{
				}
				num = (short)898301952;
				if (num != 0)
				{
				}
				num = (short)1052114944;
				short num3 = num;
				this.radErgoControlO9NaviControlName_A41370.HiddenDynamic = value;
			}
		}

		// Token: 0x17004306 RID: 17158
		// (get) Token: 0x060083A0 RID: 33696 RVA: 0x007A63E0 File Offset: 0x007A45E0
		public bool RadErgoControlO9NaviControlName_A41370_HasDiffs
		{
			get
			{
				short num = (short)380846203;
				short num2 = num;
				num = (short)413483131;
				switch (num2 == num)
				{
				}
				num = (short)1188036609;
				if (num != 0)
				{
				}
				num = (short)395837440;
				if (num != 0)
				{
				}
				num = (short)504627200;
				short num3 = num;
				return this.radErgoControlO9NaviControlName_A41370._HasDiffs;
			}
		}

		// Token: 0x17004307 RID: 17159
		// (get) Token: 0x060083A1 RID: 33697 RVA: 0x007A6494 File Offset: 0x007A4694
		// (set) Token: 0x060083A2 RID: 33698 RVA: 0x007A6548 File Offset: 0x007A4748
		public int RadErgoControlO9NaviControlFeature_A41371Value
		{
			get
			{
				short num = (short)1909537002;
				short num2 = num;
				num = (short)1190279402;
				switch (num2 == num)
				{
				}
				num = (short)2145583105;
				if (num != 0)
				{
				}
				num = (short)1377304576;
				if (num != 0)
				{
				}
				num = (short)1527906304;
				short num3 = num;
				return this.radErgoControlO9NaviControlFeature_A41371.Value;
			}
			set
			{
				short num = (short)466288641;
				if (num != 0)
				{
				}
				num = (short)1402917847;
				short num2 = num;
				num = (short)1721422807;
				switch (num2 == num)
				{
				}
				num = (short)2126446592;
				if (num != 0)
				{
				}
				num = (short)1789132800;
				short num3 = num;
				this.radErgoControlO9NaviControlFeature_A41371.Value = value;
			}
		}

		// Token: 0x17004308 RID: 17160
		// (get) Token: 0x060083A3 RID: 33699 RVA: 0x007A65FC File Offset: 0x007A47FC
		// (set) Token: 0x060083A4 RID: 33700 RVA: 0x007A66B0 File Offset: 0x007A48B0
		public string RadErgoControlO9NaviControlFeature_A41371_UIValue
		{
			get
			{
				short num = (short)1938140403;
				short num2 = num;
				num = (short)435072243;
				switch (num2 == num)
				{
				}
				num = (short)2028470272;
				if (num != 0)
				{
				}
				num = (short)2044461057;
				if (num != 0)
				{
				}
				num = (short)861470720;
				short num3 = num;
				return this.radErgoControlO9NaviControlFeature_A41371.UIValue;
			}
			set
			{
				short num = (short)1993362148;
				short num2 = num;
				num = (short)2034911972;
				switch (num2 == num)
				{
				}
				num = (short)960430081;
				if (num != 0)
				{
				}
				num = (short)1344274432;
				if (num != 0)
				{
				}
				num = (short)347013120;
				short num3 = num;
				this.radErgoControlO9NaviControlFeature_A41371.UIValue = value;
			}
		}

		// Token: 0x17004309 RID: 17161
		// (get) Token: 0x060083A5 RID: 33701 RVA: 0x007A6764 File Offset: 0x007A4964
		public global::AcpBusinessLayer.AcpListField RadErgoControlO9NaviControlFeature_A41371
		{
			get
			{
				short num = (short)1957888001;
				if (num != 0)
				{
				}
				num = (short)2107783120;
				short num2 = num;
				num = (short)1895118800;
				switch (num2 == num)
				{
				}
				num = (short)789512192;
				if (num != 0)
				{
				}
				num = (short)187170816;
				short num3 = num;
				return this.radErgoControlO9NaviControlFeature_A41371;
			}
		}

		// Token: 0x1700430A RID: 17162
		// (get) Token: 0x060083A6 RID: 33702 RVA: 0x007A6818 File Offset: 0x007A4A18
		// (set) Token: 0x060083A7 RID: 33703 RVA: 0x007A68CC File Offset: 0x007A4ACC
		public bool RadErgoControlO9NaviControlFeature_A41371_Applicable
		{
			get
			{
				short num = (short)316223738;
				short num2 = num;
				num = (short)943730938;
				switch (num2 == num)
				{
				}
				num = (short)517275649;
				if (num != 0)
				{
				}
				num = (short)178323456;
				if (num != 0)
				{
				}
				num = (short)296353792;
				short num3 = num;
				return this.radErgoControlO9NaviControlFeature_A41371.Applicable;
			}
			set
			{
				short num = (short)462422335;
				short num2 = num;
				num = (short)1959919935;
				switch (num2 == num)
				{
				}
				num = (short)1667694593;
				if (num != 0)
				{
				}
				num = (short)2136735744;
				if (num != 0)
				{
				}
				num = (short)2002780160;
				short num3 = num;
				this.radErgoControlO9NaviControlFeature_A41371.Applicable = value;
			}
		}

		// Token: 0x1700430B RID: 17163
		// (get) Token: 0x060083A8 RID: 33704 RVA: 0x007A6984 File Offset: 0x007A4B84
		// (set) Token: 0x060083A9 RID: 33705 RVA: 0x007A6A3C File Offset: 0x007A4C3C
		public bool RadErgoControlO9NaviControlFeature_A41371_Valid
		{
			get
			{
				short num = (short)1107433893;
				short num2 = num;
				num = (short)2073368997;
				switch (num2 == num)
				{
				}
				num = (short)1151139841;
				if (num != 0)
				{
				}
				num = (short)2072248320;
				if (num != 0)
				{
				}
				num = (short)1448017920;
				short num3 = num;
				return this.radErgoControlO9NaviControlFeature_A41371.Valid;
			}
			set
			{
				short num = (short)835229342;
				short num2 = num;
				num = (short)1127978654;
				switch (num2 == num)
				{
				}
				num = (short)80478208;
				if (num != 0)
				{
				}
				num = (short)221315073;
				if (num != 0)
				{
				}
				num = (short)62849024;
				short num3 = num;
				this.radErgoControlO9NaviControlFeature_A41371.Valid = value;
			}
		}

		// Token: 0x1700430C RID: 17164
		// (get) Token: 0x060083AA RID: 33706 RVA: 0x007A6AF4 File Offset: 0x007A4CF4
		// (set) Token: 0x060083AB RID: 33707 RVA: 0x007A6BA8 File Offset: 0x007A4DA8
		public bool RadErgoControlO9NaviControlFeature_A41371_Visible
		{
			get
			{
				short num = (short)1587391277;
				short num2 = num;
				num = (short)1956752173;
				switch (num2 == num)
				{
				}
				num = (short)1375666176;
				if (num != 0)
				{
				}
				num = (short)166789121;
				if (num != 0)
				{
				}
				num = (short)333316096;
				short num3 = num;
				return this.radErgoControlO9NaviControlFeature_A41371.Visible;
			}
			set
			{
				short num = (short)1528102913;
				if (num != 0)
				{
				}
				num = (short)2006028937;
				short num2 = num;
				num = (short)1281331849;
				switch (num2 == num)
				{
				}
				num = (short)648085504;
				if (num != 0)
				{
				}
				num = (short)1016201216;
				short num3 = num;
				this.radErgoControlO9NaviControlFeature_A41371.Visible = value;
			}
		}

		// Token: 0x1700430D RID: 17165
		// (get) Token: 0x060083AC RID: 33708 RVA: 0x007A6C5C File Offset: 0x007A4E5C
		// (set) Token: 0x060083AD RID: 33709 RVA: 0x007A6D10 File Offset: 0x007A4F10
		public bool RadErgoControlO9NaviControlFeature_A41371_Editable
		{
			get
			{
				short num = (short)1635961693;
				short num2 = num;
				num = (short)402770781;
				switch (num2 == num)
				{
				}
				num = (short)2089025537;
				if (num != 0)
				{
				}
				num = (short)168361984;
				if (num != 0)
				{
				}
				num = (short)411369472;
				short num3 = num;
				return this.radErgoControlO9NaviControlFeature_A41371.Editable;
			}
			set
			{
				short num = (short)1076005035;
				short num2 = num;
				num = (short)554010795;
				switch (num2 == num)
				{
				}
				num = (short)381419521;
				if (num != 0)
				{
				}
				num = (short)1769472000;
				if (num != 0)
				{
				}
				num = (short)1144586240;
				short num3 = num;
				this.radErgoControlO9NaviControlFeature_A41371.Editable = value;
			}
		}

		// Token: 0x1700430E RID: 17166
		// (get) Token: 0x060083AE RID: 33710 RVA: 0x007A6DC8 File Offset: 0x007A4FC8
		internal string RadErgoControlO9NaviControlFeature_A41371_UILabel
		{
			get
			{
				short num = (short)1186028041;
				short num2 = num;
				num = (short)1326340617;
				switch (num2 == num)
				{
				}
				num = (short)2111111168;
				if (num != 0)
				{
				}
				num = (short)918421505;
				if (num != 0)
				{
				}
				num = (short)1257963520;
				short num3 = num;
				return this.radErgoControlO9NaviControlFeature_A41371.UIName;
			}
		}

		// Token: 0x1700430F RID: 17167
		// (get) Token: 0x060083AF RID: 33711 RVA: 0x007A6E80 File Offset: 0x007A5080
		// (set) Token: 0x060083B0 RID: 33712 RVA: 0x007A6F34 File Offset: 0x007A5134
		internal bool RadErgoControlO9NaviControlFeature_A41371_HiddenStatic
		{
			get
			{
				short num = (short)427956737;
				short num2 = num;
				num = (short)1184438785;
				switch (num2 == num)
				{
				}
				num = (short)33488897;
				if (num != 0)
				{
				}
				num = (short)938737664;
				if (num != 0)
				{
				}
				num = (short)215482368;
				short num3 = num;
				return this.radErgoControlO9NaviControlFeature_A41371.HiddenStatic;
			}
			set
			{
				short num = (short)1842463277;
				short num2 = num;
				num = (short)1891156525;
				switch (num2 == num)
				{
				}
				num = (short)1081409536;
				if (num != 0)
				{
				}
				num = (short)1051131905;
				if (num != 0)
				{
				}
				num = (short)486342656;
				short num3 = num;
				this.radErgoControlO9NaviControlFeature_A41371.HiddenStatic = value;
			}
		}

		// Token: 0x17004310 RID: 17168
		// (get) Token: 0x060083B1 RID: 33713 RVA: 0x007A6FEC File Offset: 0x007A51EC
		// (set) Token: 0x060083B2 RID: 33714 RVA: 0x007A70A0 File Offset: 0x007A52A0
		internal bool RadErgoControlO9NaviControlFeature_A41371_HiddenDynamic
		{
			get
			{
				short num = (short)376669075;
				short num2 = num;
				num = (short)701268883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2063859712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)143917057;
				if (num != 0)
				{
				}
				num = (short)1184497664;
				if (num != 0)
				{
				}
				return this.radErgoControlO9NaviControlFeature_A41371.HiddenDynamic;
			}
			set
			{
				short num = (short)971571200;
				short num2 = num;
				num = (short)1275494837;
				short num3 = num;
				num = (short)867598773;
				switch (num3 == num)
				{
				}
				num = (short)147390464;
				if (num != 0)
				{
				}
				num = (short)47906817;
				if (num != 0)
				{
				}
				this.radErgoControlO9NaviControlFeature_A41371.HiddenDynamic = value;
			}
		}

		// Token: 0x17004311 RID: 17169
		// (get) Token: 0x060083B3 RID: 33715 RVA: 0x007A7158 File Offset: 0x007A5358
		public bool RadErgoControlO9NaviControlFeature_A41371_HasDiffs
		{
			get
			{
				short num = (short)1861287936;
				short num2 = num;
				num = (short)1762514469;
				short num3 = num;
				num = (short)220452389;
				switch (num3 == num)
				{
				}
				num = (short)1547894785;
				if (num != 0)
				{
				}
				num = (short)571736064;
				if (num != 0)
				{
				}
				return this.radErgoControlO9NaviControlFeature_A41371._HasDiffs;
			}
		}

		// Token: 0x17004312 RID: 17170
		// (get) Token: 0x060083B4 RID: 33716 RVA: 0x007A7208 File Offset: 0x007A5408
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1082261504;
				short num2 = num;
				num = (short)2105148689;
				short num3 = num;
				num = (short)17433873;
				switch (num3 == num)
				{
				}
				num = (short)522387457;
				if (num != 0)
				{
				}
				num = (short)1445462016;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x060083B5 RID: 33717 RVA: 0x007A72C8 File Offset: 0x007A54C8
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
				{
					if (base.ParentRecset == null)
					{
						goto IL_13C;
					}
					num2 = (short)1693450241;
					if (num2 != 0)
					{
					}
					num2 = (short)1914258197;
					short num3 = num2;
					num2 = (short)1786856213;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13C;
					default:
						num2 = (short)2110717952;
						if (num2 != 0)
						{
						}
						num2 = (short)1517748225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)1563099140;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_FB;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)150994946;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1492910083;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				}
				goto IL_24;
			}
			IL_FB:
			IL_13C:
			num2 = (short)802029568;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)89128960;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003E5F RID: 15967
		private global::AcpBusinessLayer.AcpField<string> radErgoControlO9NaviControlName_A41370;

		// Token: 0x04003E60 RID: 15968
		private global::AcpBusinessLayer.AcpListField radErgoControlO9NaviControlFeature_A41371;
	}
}
