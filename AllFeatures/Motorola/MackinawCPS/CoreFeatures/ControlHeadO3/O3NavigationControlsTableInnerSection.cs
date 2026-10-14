using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003D1 RID: 977
	[global::System.Serializable]
	public class O3NavigationControlsTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008B29 RID: 35625 RVA: 0x00820B50 File Offset: 0x0081ED50
		public O3NavigationControlsTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008B2A RID: 35626 RVA: 0x00820B6C File Offset: 0x0081ED6C
		protected O3NavigationControlsTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008B2B RID: 35627 RVA: 0x00820B84 File Offset: 0x0081ED84
		public override void Init()
		{
			int a_ = 10;
			short num = (short)429850659;
			short num2 = num;
			num = (short)651296803;
			switch (num2 == num)
			{
			}
			num = (short)596967424;
			short num3 = num;
			num = (short)88604672;
			if (num != 0)
			{
			}
			num = (short)1565196289;
			if (num != 0)
			{
			}
			this.radErgoControlO3NaviControlName_A41374 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖高듚돜ꯞ鏠賢觤꣦\udae8ꗪ賬駮飰냲髴駶跸觺鋼鏾伀戂栄戆嘈䨊㤌㸎∐␒℔", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgoControlO3NaviControlName_A41374.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlO3NaviControlName_A41374.DataTransferOrder = -1;
			this.radErgoControlO3NaviControlFeature_A41375 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexRadErgoControlO3NaviControlFeature_A41375LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idRadErgoControlO3NaviControlFeature_A41375LovStrs), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖高듚돜ꯞ鏠賢觤꣦\udae8ꗪ賬駮飰냲髴駶跸觺鋼鏾䜀昂搄猆簈礊栌倎倐✒␔␖⸘⸚", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.RadErgoControlO3NaviControlFeature_A41375LovStrs);
			this.radErgoControlO3NaviControlFeature_A41375.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlO3NaviControlFeature_A41375.DataTransferOrder = 6;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藊곌많룐듒듔ꏖ냘듚돜￞ꋠ賢诤鏦鯨蓪臬鳮", a_);
			base.Id = 10733;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 20;
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x00820CF8 File Offset: 0x0081EEF8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1860829184;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 1:
					if (producerFields != null)
					{
						num = (short)1004208130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A8;
				case 2:
					num = (short)1818689543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈車뿌꣎뻐郒뫔맖귘꧚닜돞껠탢ꯤ蛦鿨苪껬胮鿰蟲蟴飶闸뷺飼黾甀瘂眄戆嘈䨊㤌㸎∐␒—", a_)))
					{
						num = (short)1428226054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A8;
				case 4:
					goto IL_231;
				case 5:
					goto IL_7B;
				case 6:
					this.radErgoControlO3NaviControlFeature_A41375 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexRadErgoControlO3NaviControlFeature_A41375LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idRadErgoControlO3NaviControlFeature_A41375LovStrs), this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈車뿌꣎뻐郒뫔맖귘꧚닜돞껠탢ꯤ蛦鿨苪껬胮鿰蟲蟴飶闸뷺飼黾甀瘂眄戆嘈䨊㤌㸎∐␒—", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.RadErgoControlO3NaviControlFeature_A41375LovStrs);
					this.radErgoControlO3NaviControlFeature_A41375.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlO3NaviControlFeature_A41375.DataTransferOrder = 6;
					num = (short)2098003972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈車뿌꣎뻐郒뫔맖귘꧚닜돞껠탢ꯤ蛦鿨苪껬胮鿰蟲蟴飶闸뗺鳼鋾搀専䐄㌆㠈㠊㨌㬎", a_)))
					{
						num = (short)1439432712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
				case 8:
				{
					num = (short)553422896;
					short num3 = num;
					num = (short)365334576;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7B;
					default:
						num = (short)1273954305;
						if (num != 0)
						{
						}
						num = (short)430112768;
						if (num != 0)
						{
						}
						this.radErgoControlO3NaviControlName_A41374 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈車뿌꣎뻐郒뫔맖귘꧚닜돞껠탢ꯤ蛦鿨苪껬胮鿰蟲蟴飶闸뗺鳼鋾搀専䐄㌆㠈㠊㨌㬎", a_), global::CommonResources.AcgResources.ID_NAME, 100);
						this.radErgoControlO3NaviControlName_A41374.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.radErgoControlO3NaviControlName_A41374.DataTransferOrder = -1;
						num = (short)340328453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					num = (short)1135935489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1792933897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2A8;
				IL_7B:
				num = (short)721289219;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_231:
			num = (short)1568997376;
			short num4 = num;
			IL_2A8:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("评ꛆ뿈ꋊ꫌껎ꗐ뫒뫔맖律飚닜뇞闠釢諤详髨", a_);
			base.Id = 10733;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 20;
		}

		// Token: 0x06008B2D RID: 35629 RVA: 0x00820FE0 File Offset: 0x0081F1E0
		public override void PopulateReferences()
		{
			short num = (short)1443889152;
			short num2 = num;
			num = (short)1217301218;
			short num3 = num;
			num = (short)318147298;
			switch (num3 == num)
			{
			}
			num = (short)365297665;
			if (num != 0)
			{
			}
			num = (short)1167458304;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008B2E RID: 35630 RVA: 0x0082108C File Offset: 0x0081F28C
		public override void DropReferences()
		{
			short num = (short)119799808;
			short num2 = num;
			num = (short)1429675753;
			short num3 = num;
			num = (short)1541086953;
			switch (num3 == num)
			{
			}
			num = (short)630194177;
			if (num != 0)
			{
			}
			num = (short)1563557888;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008B2F RID: 35631 RVA: 0x00821138 File Offset: 0x0081F338
		public override void SetConstraints()
		{
			short num = (short)387252224;
			short num2 = num;
			num = (short)1798863425;
			short num3 = num;
			num = (short)1755150913;
			switch (num3 == num)
			{
			}
			num = (short)1197670401;
			if (num != 0)
			{
			}
			num = (short)779026432;
			if (num != 0)
			{
			}
			this.radErgoControlO3NaviControlName_A41374.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoControlO3NaviControlFeature_A41375.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConStandaloneRadioSystemEnableApp);
			this.radErgoControlO3NaviControlFeature_A41375.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.conDownButtonApplicable);
			this.radErgoControlO3NaviControlFeature_A41375.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConSyncUpDownBtnFeature);
		}

		// Token: 0x06008B30 RID: 35632 RVA: 0x0082123C File Offset: 0x0081F43C
		public override void SetupDependencies()
		{
			short num = (short)1513881600;
			short num2 = num;
			num = (short)1290207233;
			if (num != 0)
			{
			}
			num = (short)2142410291;
			short num3 = num;
			num = (short)188651059;
			switch (num3 == num)
			{
			}
			num = (short)2015166464;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoControlO3NaviControlFeature_A41375);
		}

		// Token: 0x17004693 RID: 18067
		// (get) Token: 0x06008B31 RID: 35633 RVA: 0x00821304 File Offset: 0x0081F504
		public bool HasDiffs
		{
			get
			{
				short num = (short)271384576;
				short num2 = num;
				num = (short)347362830;
				short num3 = num;
				num = (short)1931302414;
				switch (num3 == num)
				{
				}
				num = (short)343736320;
				if (num != 0)
				{
				}
				num = (short)1971847169;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004694 RID: 18068
		// (get) Token: 0x06008B32 RID: 35634 RVA: 0x008213B4 File Offset: 0x0081F5B4
		// (set) Token: 0x06008B33 RID: 35635 RVA: 0x00821464 File Offset: 0x0081F664
		public string RadErgoControlO3NaviControlName_A41374Value
		{
			get
			{
				short num = (short)1025507328;
				short num2 = num;
				num = (short)164294178;
				short num3 = num;
				num = (short)1945103906;
				switch (num3 == num)
				{
				}
				num = (short)1880883200;
				if (num != 0)
				{
				}
				num = (short)294518785;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374.Value;
			}
			set
			{
				short num = (short)623575040;
				short num2 = num;
				num = (short)421153078;
				short num3 = num;
				num = (short)1892829494;
				switch (num3 == num)
				{
				}
				num = (short)1956118528;
				if (num != 0)
				{
				}
				num = (short)1699151873;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlName_A41374.Value = value;
			}
		}

		// Token: 0x17004695 RID: 18069
		// (get) Token: 0x06008B34 RID: 35636 RVA: 0x00821518 File Offset: 0x0081F718
		public global::AcpBusinessLayer.AcpField<string> RadErgoControlO3NaviControlName_A41374
		{
			get
			{
				short num = (short)1742143488;
				short num2 = num;
				num = (short)1468867206;
				short num3 = num;
				num = (short)668082822;
				switch (num3 == num)
				{
				}
				num = (short)1075052545;
				if (num != 0)
				{
				}
				num = (short)40763392;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374;
			}
		}

		// Token: 0x17004696 RID: 18070
		// (get) Token: 0x06008B35 RID: 35637 RVA: 0x008215CC File Offset: 0x0081F7CC
		// (set) Token: 0x06008B36 RID: 35638 RVA: 0x00821680 File Offset: 0x0081F880
		public string RadErgoControlO3NaviControlName_A41374_UIValue
		{
			get
			{
				short num = (short)1842675712;
				short num2 = num;
				num = (short)1482353695;
				short num3 = num;
				num = (short)1197861919;
				switch (num3 == num)
				{
				}
				num = (short)806223873;
				if (num != 0)
				{
				}
				num = (short)371261440;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374.Value;
			}
			set
			{
				short num = (short)244449280;
				short num2 = num;
				num = (short)226272251;
				short num3 = num;
				num = (short)828417019;
				switch (num3 == num)
				{
				}
				num = (short)895877121;
				if (num != 0)
				{
				}
				num = (short)770113536;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlName_A41374.Value = value;
			}
		}

		// Token: 0x17004697 RID: 18071
		// (get) Token: 0x06008B37 RID: 35639 RVA: 0x00821734 File Offset: 0x0081F934
		// (set) Token: 0x06008B38 RID: 35640 RVA: 0x008217E8 File Offset: 0x0081F9E8
		public bool RadErgoControlO3NaviControlName_A41374_Applicable
		{
			get
			{
				short num = (short)1429667840;
				short num2 = num;
				num = (short)125763585;
				if (num != 0)
				{
				}
				num = (short)1345808197;
				short num3 = num;
				num = (short)1991075653;
				switch (num3 == num)
				{
				}
				num = (short)901775360;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374.Applicable;
			}
			set
			{
				short num = (short)821231616;
				short num2 = num;
				num = (short)1284633003;
				short num3 = num;
				num = (short)678293931;
				switch (num3 == num)
				{
				}
				num = (short)701759489;
				if (num != 0)
				{
				}
				num = (short)2147287040;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlName_A41374.Applicable = value;
			}
		}

		// Token: 0x17004698 RID: 18072
		// (get) Token: 0x06008B39 RID: 35641 RVA: 0x008218A0 File Offset: 0x0081FAA0
		// (set) Token: 0x06008B3A RID: 35642 RVA: 0x00821954 File Offset: 0x0081FB54
		public bool RadErgoControlO3NaviControlName_A41374_Valid
		{
			get
			{
				short num = (short)22609920;
				short num2 = num;
				num = (short)2112495417;
				short num3 = num;
				num = (short)262610745;
				switch (num3 == num)
				{
				}
				num = (short)739115009;
				if (num != 0)
				{
				}
				num = (short)860684288;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374.Valid;
			}
			set
			{
				short num = (short)1285160960;
				short num2 = num;
				num = (short)1738602289;
				short num3 = num;
				num = (short)1359804209;
				switch (num3 == num)
				{
				}
				num = (short)1850802176;
				if (num != 0)
				{
				}
				num = (short)1137115137;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlName_A41374.Valid = value;
			}
		}

		// Token: 0x17004699 RID: 18073
		// (get) Token: 0x06008B3B RID: 35643 RVA: 0x00821A08 File Offset: 0x0081FC08
		// (set) Token: 0x06008B3C RID: 35644 RVA: 0x00821ABC File Offset: 0x0081FCBC
		public bool RadErgoControlO3NaviControlName_A41374_Visible
		{
			get
			{
				short num = (short)668139520;
				short num2 = num;
				num = (short)1735000065;
				if (num != 0)
				{
				}
				num = (short)1987814730;
				short num3 = num;
				num = (short)2074715466;
				switch (num3 == num)
				{
				}
				num = (short)1279262720;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374.Visible;
			}
			set
			{
				short num = (short)1649541120;
				short num2 = num;
				num = (short)1524614296;
				short num3 = num;
				num = (short)1114555544;
				switch (num3 == num)
				{
				}
				num = (short)1619984384;
				if (num != 0)
				{
				}
				num = (short)1495465985;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlName_A41374.Visible = value;
			}
		}

		// Token: 0x1700469A RID: 18074
		// (get) Token: 0x06008B3D RID: 35645 RVA: 0x00821B70 File Offset: 0x0081FD70
		// (set) Token: 0x06008B3E RID: 35646 RVA: 0x00821C24 File Offset: 0x0081FE24
		public bool RadErgoControlO3NaviControlName_A41374_Editable
		{
			get
			{
				short num = (short)142802944;
				short num2 = num;
				num = (short)1522652671;
				short num3 = num;
				num = (short)1740297727;
				switch (num3 == num)
				{
				}
				num = (short)1226899457;
				if (num != 0)
				{
				}
				num = (short)2108882944;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374.Editable;
			}
			set
			{
				short num = (short)764805120;
				short num2 = num;
				num = (short)1359106160;
				short num3 = num;
				num = (short)1611747440;
				switch (num3 == num)
				{
				}
				num = (short)439287809;
				if (num != 0)
				{
				}
				num = (short)442499072;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlName_A41374.Editable = value;
			}
		}

		// Token: 0x1700469B RID: 18075
		// (get) Token: 0x06008B3F RID: 35647 RVA: 0x00821CD8 File Offset: 0x0081FED8
		internal string RadErgoControlO3NaviControlName_A41374_UILabel
		{
			get
			{
				short num = (short)1619787776;
				short num2 = num;
				num = (short)1629552641;
				if (num != 0)
				{
				}
				num = (short)796794376;
				short num3 = num;
				num = (short)495590920;
				switch (num3 == num)
				{
				}
				num = (short)1143209984;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374.UIName;
			}
		}

		// Token: 0x1700469C RID: 18076
		// (get) Token: 0x06008B40 RID: 35648 RVA: 0x00821D8C File Offset: 0x0081FF8C
		// (set) Token: 0x06008B41 RID: 35649 RVA: 0x00821E40 File Offset: 0x00820040
		internal bool RadErgoControlO3NaviControlName_A41374_HiddenStatic
		{
			get
			{
				short num = (short)488177664;
				short num2 = num;
				num = (short)782630913;
				if (num != 0)
				{
				}
				num = (short)951911244;
				short num3 = num;
				num = (short)1258160972;
				switch (num3 == num)
				{
				}
				num = (short)1690304512;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374.HiddenStatic;
			}
			set
			{
				short num = (short)1708785664;
				short num2 = num;
				num = (short)2086334694;
				short num3 = num;
				num = (short)1942810854;
				switch (num3 == num)
				{
				}
				num = (short)1192951809;
				if (num != 0)
				{
				}
				num = (short)609681408;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlName_A41374.HiddenStatic = value;
			}
		}

		// Token: 0x1700469D RID: 18077
		// (get) Token: 0x06008B42 RID: 35650 RVA: 0x00821EF8 File Offset: 0x008200F8
		// (set) Token: 0x06008B43 RID: 35651 RVA: 0x00821FB0 File Offset: 0x008201B0
		internal bool RadErgoControlO3NaviControlName_A41374_HiddenDynamic
		{
			get
			{
				short num = (short)542769152;
				short num2 = num;
				num = (short)894284816;
				short num3 = num;
				num = (short)1256961040;
				switch (num3 == num)
				{
				}
				num = (short)483393536;
				if (num != 0)
				{
				}
				num = (short)1674182657;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374.HiddenDynamic;
			}
			set
			{
				short num = (short)544145408;
				short num2 = num;
				num = (short)1279666009;
				short num3 = num;
				num = (short)490350425;
				switch (num3 == num)
				{
				}
				num = (short)119996416;
				if (num != 0)
				{
				}
				num = (short)562626561;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlName_A41374.HiddenDynamic = value;
			}
		}

		// Token: 0x1700469E RID: 18078
		// (get) Token: 0x06008B44 RID: 35652 RVA: 0x00822068 File Offset: 0x00820268
		public bool RadErgoControlO3NaviControlName_A41374_HasDiffs
		{
			get
			{
				short num = (short)1591803904;
				short num2 = num;
				num = (short)1569738727;
				short num3 = num;
				num = (short)1878740967;
				switch (num3 == num)
				{
				}
				num = (short)923074561;
				if (num != 0)
				{
				}
				num = (short)1301086208;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlName_A41374._HasDiffs;
			}
		}

		// Token: 0x1700469F RID: 18079
		// (get) Token: 0x06008B45 RID: 35653 RVA: 0x0082211C File Offset: 0x0082031C
		// (set) Token: 0x06008B46 RID: 35654 RVA: 0x008221CC File Offset: 0x008203CC
		public int RadErgoControlO3NaviControlFeature_A41375Value
		{
			get
			{
				short num = (short)955187200;
				short num2 = num;
				num = (short)270900850;
				short num3 = num;
				num = (short)1468571250;
				switch (num3 == num)
				{
				}
				num = (short)2069889025;
				if (num != 0)
				{
				}
				num = (short)791871488;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375.Value;
			}
			set
			{
				short num = (short)1160052736;
				short num2 = num;
				num = (short)427425793;
				if (num != 0)
				{
				}
				num = (short)1177015846;
				short num3 = num;
				num = (short)1352521254;
				switch (num3 == num)
				{
				}
				num = (short)1153040384;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlFeature_A41375.Value = value;
			}
		}

		// Token: 0x170046A0 RID: 18080
		// (get) Token: 0x06008B47 RID: 35655 RVA: 0x00822280 File Offset: 0x00820480
		// (set) Token: 0x06008B48 RID: 35656 RVA: 0x00822334 File Offset: 0x00820534
		public string RadErgoControlO3NaviControlFeature_A41375_UIValue
		{
			get
			{
				short num = (short)538574848;
				short num2 = num;
				num = (short)219626266;
				short num3 = num;
				num = (short)1941650202;
				switch (num3 == num)
				{
				}
				num = (short)258408448;
				if (num != 0)
				{
				}
				num = (short)484507649;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375.UIValue;
			}
			set
			{
				short num = (short)967507968;
				short num2 = num;
				num = (short)837353473;
				if (num != 0)
				{
				}
				num = (short)1843370073;
				short num3 = num;
				num = (short)1426036825;
				switch (num3 == num)
				{
				}
				num = (short)168951808;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlFeature_A41375.UIValue = value;
			}
		}

		// Token: 0x170046A1 RID: 18081
		// (get) Token: 0x06008B49 RID: 35657 RVA: 0x008223E8 File Offset: 0x008205E8
		public global::AcpBusinessLayer.AcpListField RadErgoControlO3NaviControlFeature_A41375
		{
			get
			{
				short num = (short)463929344;
				short num2 = num;
				num = (short)69966415;
				short num3 = num;
				num = (short)1779735119;
				switch (num3 == num)
				{
				}
				num = (short)1517289472;
				if (num != 0)
				{
				}
				num = (short)1921449985;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375;
			}
		}

		// Token: 0x170046A2 RID: 18082
		// (get) Token: 0x06008B4A RID: 35658 RVA: 0x00822498 File Offset: 0x00820698
		// (set) Token: 0x06008B4B RID: 35659 RVA: 0x00822550 File Offset: 0x00820750
		public bool RadErgoControlO3NaviControlFeature_A41375_Applicable
		{
			get
			{
				short num = (short)417792000;
				short num2 = num;
				num = (short)1534330495;
				short num3 = num;
				num = (short)331155071;
				switch (num3 == num)
				{
				}
				num = (short)1249247232;
				if (num != 0)
				{
				}
				num = (short)2030043137;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375.Applicable;
			}
			set
			{
				short num = (short)577110016;
				short num2 = num;
				num = (short)40196127;
				short num3 = num;
				num = (short)2094290975;
				switch (num3 == num)
				{
				}
				num = (short)461963265;
				if (num != 0)
				{
				}
				num = (short)954728448;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlFeature_A41375.Applicable = value;
			}
		}

		// Token: 0x170046A3 RID: 18083
		// (get) Token: 0x06008B4C RID: 35660 RVA: 0x00822608 File Offset: 0x00820808
		// (set) Token: 0x06008B4D RID: 35661 RVA: 0x008226BC File Offset: 0x008208BC
		public bool RadErgoControlO3NaviControlFeature_A41375_Valid
		{
			get
			{
				short num = (short)1188167680;
				short num2 = num;
				num = (short)1886388225;
				if (num != 0)
				{
				}
				num = (short)1850691408;
				short num3 = num;
				num = (short)230707024;
				switch (num3 == num)
				{
				}
				num = (short)42139648;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375.Valid;
			}
			set
			{
				short num = (short)1391853568;
				short num2 = num;
				num = (short)1948239117;
				short num3 = num;
				num = (short)1587397901;
				switch (num3 == num)
				{
				}
				num = (short)813498369;
				if (num != 0)
				{
				}
				num = (short)658505728;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlFeature_A41375.Valid = value;
			}
		}

		// Token: 0x170046A4 RID: 18084
		// (get) Token: 0x06008B4E RID: 35662 RVA: 0x00822774 File Offset: 0x00820974
		// (set) Token: 0x06008B4F RID: 35663 RVA: 0x0082282C File Offset: 0x00820A2C
		public bool RadErgoControlO3NaviControlFeature_A41375_Visible
		{
			get
			{
				short num = (short)177537024;
				short num2 = num;
				num = (short)517071026;
				short num3 = num;
				num = (short)1904795826;
				switch (num3 == num)
				{
				}
				num = (short)1130823680;
				if (num != 0)
				{
				}
				num = (short)814874625;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375.Visible;
			}
			set
			{
				short num = (short)1785266176;
				short num2 = num;
				num = (short)925958145;
				if (num != 0)
				{
				}
				num = (short)338456991;
				short num3 = num;
				num = (short)1881108895;
				switch (num3 == num)
				{
				}
				num = (short)1653604352;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlFeature_A41375.Visible = value;
			}
		}

		// Token: 0x170046A5 RID: 18085
		// (get) Token: 0x06008B50 RID: 35664 RVA: 0x008228E4 File Offset: 0x00820AE4
		// (set) Token: 0x06008B51 RID: 35665 RVA: 0x00822998 File Offset: 0x00820B98
		public bool RadErgoControlO3NaviControlFeature_A41375_Editable
		{
			get
			{
				short num = (short)1192689664;
				short num2 = num;
				num = (short)390660097;
				if (num != 0)
				{
				}
				num = (short)772282357;
				short num3 = num;
				num = (short)1133778933;
				switch (num3 == num)
				{
				}
				num = (short)1224278016;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375.Editable;
			}
			set
			{
				short num = (short)598736896;
				short num2 = num;
				num = (short)2064978316;
				short num3 = num;
				num = (short)1629032844;
				switch (num3 == num)
				{
				}
				num = (short)272105473;
				if (num != 0)
				{
				}
				num = (short)1614675968;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlFeature_A41375.Editable = value;
			}
		}

		// Token: 0x170046A6 RID: 18086
		// (get) Token: 0x06008B52 RID: 35666 RVA: 0x00822A4C File Offset: 0x00820C4C
		internal string RadErgoControlO3NaviControlFeature_A41375_UILabel
		{
			get
			{
				short num = (short)438370304;
				short num2 = num;
				num = (short)1106615074;
				short num3 = num;
				num = (short)906664738;
				switch (num3 == num)
				{
				}
				num = (short)458162177;
				if (num != 0)
				{
				}
				num = (short)584712192;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375.UIName;
			}
		}

		// Token: 0x170046A7 RID: 18087
		// (get) Token: 0x06008B53 RID: 35667 RVA: 0x00822B04 File Offset: 0x00820D04
		// (set) Token: 0x06008B54 RID: 35668 RVA: 0x00822BB8 File Offset: 0x00820DB8
		internal bool RadErgoControlO3NaviControlFeature_A41375_HiddenStatic
		{
			get
			{
				short num = (short)1975123968;
				short num2 = num;
				num = (short)1684081673;
				short num3 = num;
				num = (short)980945929;
				switch (num3 == num)
				{
				}
				num = (short)601686017;
				if (num != 0)
				{
				}
				num = (short)855244800;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375.HiddenStatic;
			}
			set
			{
				short num = (short)906035200;
				short num2 = num;
				num = (short)456203228;
				short num3 = num;
				num = (short)2012421084;
				switch (num3 == num)
				{
				}
				num = (short)1075970048;
				if (num != 0)
				{
				}
				num = (short)1996292097;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlFeature_A41375.HiddenStatic = value;
			}
		}

		// Token: 0x170046A8 RID: 18088
		// (get) Token: 0x06008B55 RID: 35669 RVA: 0x00822C70 File Offset: 0x00820E70
		// (set) Token: 0x06008B56 RID: 35670 RVA: 0x00822D24 File Offset: 0x00820F24
		internal bool RadErgoControlO3NaviControlFeature_A41375_HiddenDynamic
		{
			get
			{
				short num = (short)1794179072;
				short num2 = num;
				num = (short)1892504468;
				short num3 = num;
				num = (short)1878414228;
				switch (num3 == num)
				{
				}
				num = (short)1864302593;
				if (num != 0)
				{
				}
				num = (short)1059061760;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375.HiddenDynamic;
			}
			set
			{
				short num = (short)1858404352;
				short num2 = num;
				num = (short)1231720774;
				short num3 = num;
				num = (short)100962630;
				switch (num3 == num)
				{
				}
				num = (short)1973157889;
				if (num != 0)
				{
				}
				num = (short)124190720;
				if (num != 0)
				{
				}
				this.radErgoControlO3NaviControlFeature_A41375.HiddenDynamic = value;
			}
		}

		// Token: 0x170046A9 RID: 18089
		// (get) Token: 0x06008B57 RID: 35671 RVA: 0x00822DD8 File Offset: 0x00820FD8
		public bool RadErgoControlO3NaviControlFeature_A41375_HasDiffs
		{
			get
			{
				short num = (short)339804160;
				short num2 = num;
				num = (short)1787625473;
				if (num != 0)
				{
				}
				num = (short)2140625603;
				short num3 = num;
				num = (short)1534679747;
				switch (num3 == num)
				{
				}
				num = (short)800456704;
				if (num != 0)
				{
				}
				return this.radErgoControlO3NaviControlFeature_A41375._HasDiffs;
			}
		}

		// Token: 0x170046AA RID: 18090
		// (get) Token: 0x06008B58 RID: 35672 RVA: 0x00822E8C File Offset: 0x0082108C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)749993984;
				short num2 = num;
				num = (short)200147541;
				short num3 = num;
				num = (short)1413939797;
				switch (num3 == num)
				{
				}
				num = (short)783810561;
				if (num != 0)
				{
				}
				num = (short)1600782336;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06008B59 RID: 35673 RVA: 0x00822F48 File Offset: 0x00821148
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
					if (base.ParentRecset != null)
					{
						num2 = (short)385155074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1568866308;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)688652288;
					short num3 = num2;
					num2 = (short)1752498179;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1644822529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				case 4:
					goto IL_D7;
				}
				goto IL_24;
			}
			IL_D7:
			IL_116:
			num2 = (short)612949353;
			short num4 = num2;
			num2 = (short)1593892201;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_24:
				result = null;
				num2 = (short)1071644673;
				if (num2 != 0)
				{
				}
				num2 = (short)167444480;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)1827930112;
				if (num2 != 0)
				{
				}
				return result;
			}
		}

		// Token: 0x040042E2 RID: 17122
		private global::AcpBusinessLayer.AcpField<string> radErgoControlO3NaviControlName_A41374;

		// Token: 0x040042E3 RID: 17123
		private global::AcpBusinessLayer.AcpListField radErgoControlO3NaviControlFeature_A41375;
	}
}
