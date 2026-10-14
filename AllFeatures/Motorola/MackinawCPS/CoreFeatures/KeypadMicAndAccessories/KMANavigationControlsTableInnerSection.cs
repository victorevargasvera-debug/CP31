using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x0200031C RID: 796
	[global::System.Serializable]
	public class KMANavigationControlsTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007C44 RID: 31812 RVA: 0x0071FB44 File Offset: 0x0071DD44
		public KMANavigationControlsTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007C45 RID: 31813 RVA: 0x0071FB60 File Offset: 0x0071DD60
		protected KMANavigationControlsTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007C46 RID: 31814 RVA: 0x0071FB78 File Offset: 0x0071DD78
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1541165357;
			short num2 = num;
			num = (short)1958236461;
			switch (num2 == num)
			{
			}
			num = (short)451805185;
			if (num != 0)
			{
			}
			num = (short)300351488;
			short num3 = num;
			num = (short)1224802304;
			if (num != 0)
			{
			}
			this.radErgoControlKMANaviControlName_41759 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎뻐뷒ꇔꗖ뛘럚雜鋞ꃠ귢蓤釦胨꣪苬臮藰臲髴鯶럸髺郼髾帀㜂㐄〆㰈㈊", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgoControlKMANaviControlName_41759.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlKMANaviControlName_41759.DataTransferOrder = -1;
			this.radErgoControlKMAUpDownButton_41760 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoControlKMAUpDownButton_41760LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoControlKMAUpDownButton_41760LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎뻐뷒ꇔꗖ뛘럚雜鋞ꃠ뛢闤ꏦ蛨鳪菬귮蓰蟲致飶韸ꓺ짼컾㘀㔂㔄", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoControlKMAUpDownButton_41760LovStrs);
			this.radErgoControlKMAUpDownButton_41760.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlKMAUpDownButton_41760.DataTransferOrder = 44;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迀ꋂ도껆껈꫊만ꛎ뻐뷒铖뛘뗚꧜귞軠迢雤", a_);
			base.Id = 10754;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06007C47 RID: 31815 RVA: 0x0071FCEC File Offset: 0x0071DEEC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)700252164;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgoControlKMANaviControlName_41759 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뛘뗚꧜귞軠迢껤ꫦ꣨ꗪ賬駮飰냲髴駶跸觺鋼鏾伀戂栄戆嘈㼊㰌㠎␐⨒", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgoControlKMANaviControlName_41759.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlKMANaviControlName_41759.DataTransferOrder = -1;
					num = (short)1770717191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1487405056;
					short num3 = num;
					num = (short)837025795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					num = (short)1857104560;
					short num4 = num;
					num = (short)47917744;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1484783616;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뛘뗚꧜귞軠迢껤ꫦ꣨뻪鷬꯮黰蓲鯴뗶賸迺觼郾漀専㄄㘆㸈㴊㴌", a_)))
						{
							num = (short)1149698053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AE;
					}
					break;
				}
				case 3:
					if (producerFields != null)
					{
						num = (short)987365384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AE;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 5:
					this.radErgoControlKMAUpDownButton_41760 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoControlKMAUpDownButton_41760LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoControlKMAUpDownButton_41760LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뛘뗚꧜귞軠迢껤ꫦ꣨뻪鷬꯮黰蓲鯴뗶賸迺觼郾漀専㄄㘆㸈㴊㴌", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoControlKMAUpDownButton_41760LovStrs);
					this.radErgoControlKMAUpDownButton_41760.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlKMAUpDownButton_41760.DataTransferOrder = 44;
					num = (short)663683078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_25D;
				case 7:
					num = (short)1887764481;
					if (num != 0)
					{
					}
					goto IL_A3;
				case 8:
					num = (short)891944969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뛘뗚꧜귞軠迢껤ꫦ꣨ꗪ賬駮飰냲髴駶跸觺鋼鏾伀戂栄戆嘈㼊㰌㠎␐⨒", a_)))
					{
						num = (short)2085945344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)730988545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A3:
				num = (short)2027552770;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_25D:
			IL_2AE:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟈꫊믌ꛎ뛐닒ꇔ뻖뛘뗚﷜鳞軠跢釤闦蛨蟪黬", a_);
			base.Id = 10754;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x0071FFD8 File Offset: 0x0071E1D8
		public override void PopulateReferences()
		{
			short num = (short)649134080;
			short num2 = num;
			num = (short)748158977;
			if (num != 0)
			{
			}
			num = (short)994848996;
			short num3 = num;
			num = (short)651047140;
			switch (num3 == num)
			{
			}
			num = (short)1576861696;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x00720080 File Offset: 0x0071E280
		public override void DropReferences()
		{
			short num = (short)186318848;
			short num2 = num;
			num = (short)1787332112;
			short num3 = num;
			num = (short)1058244112;
			switch (num3 == num)
			{
			}
			num = (short)1468923904;
			if (num != 0)
			{
			}
			num = (short)228720641;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x00720128 File Offset: 0x0071E328
		public override void SetConstraints()
		{
			short num = (short)1065746432;
			short num2 = num;
			num = (short)127534329;
			short num3 = num;
			num = (short)856818937;
			switch (num3 == num)
			{
			}
			num = (short)843382785;
			if (num != 0)
			{
			}
			num = (short)1247281152;
			if (num != 0)
			{
			}
			this.radErgoControlKMANaviControlName_41759.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoControlKMAUpDownButton_41760.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.conDownButtonApplicable);
			this.radErgoControlKMAUpDownButton_41760.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConSyncUpDownBtnFeature);
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x00720218 File Offset: 0x0071E418
		public override void SetupDependencies()
		{
			short num = (short)1719074816;
			short num2 = num;
			num = (short)2049236922;
			short num3 = num;
			num = (short)487776186;
			switch (num3 == num)
			{
			}
			num = (short)2119499776;
			if (num != 0)
			{
			}
			num = (short)1014890497;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003FA8 RID: 16296
		// (get) Token: 0x06007C4C RID: 31820 RVA: 0x007202C4 File Offset: 0x0071E4C4
		public bool HasDiffs
		{
			get
			{
				short num = (short)703791104;
				short num2 = num;
				num = (short)585229023;
				short num3 = num;
				num = (short)1829429983;
				switch (num3 == num)
				{
				}
				num = (short)1183907840;
				if (num != 0)
				{
				}
				num = (short)954335233;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003FA9 RID: 16297
		// (get) Token: 0x06007C4D RID: 31821 RVA: 0x00720370 File Offset: 0x0071E570
		// (set) Token: 0x06007C4E RID: 31822 RVA: 0x00720428 File Offset: 0x0071E628
		public string RadErgoControlKMANaviControlName_41759Value
		{
			get
			{
				short num = (short)1768685568;
				short num2 = num;
				num = (short)2034217251;
				short num3 = num;
				num = (short)475377955;
				switch (num3 == num)
				{
				}
				num = (short)2074869761;
				if (num != 0)
				{
				}
				num = (short)1226964992;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759.Value;
			}
			set
			{
				short num = (short)786235392;
				short num2 = num;
				num = (short)1465055457;
				short num3 = num;
				num = (short)2134767841;
				switch (num3 == num)
				{
				}
				num = (short)173080577;
				if (num != 0)
				{
				}
				num = (short)1787297792;
				if (num != 0)
				{
				}
				this.radErgoControlKMANaviControlName_41759.Value = value;
			}
		}

		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x06007C4F RID: 31823 RVA: 0x007204E0 File Offset: 0x0071E6E0
		public global::AcpBusinessLayer.AcpField<string> RadErgoControlKMANaviControlName_41759
		{
			get
			{
				short num = (short)1908080640;
				short num2 = num;
				num = (short)1204455817;
				short num3 = num;
				num = (short)2021296521;
				switch (num3 == num)
				{
				}
				num = (short)166920193;
				if (num != 0)
				{
				}
				num = (short)1172176896;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759;
			}
		}

		// Token: 0x17003FAB RID: 16299
		// (get) Token: 0x06007C50 RID: 31824 RVA: 0x00720590 File Offset: 0x0071E790
		// (set) Token: 0x06007C51 RID: 31825 RVA: 0x00720644 File Offset: 0x0071E844
		public string RadErgoControlKMANaviControlName_41759_UIValue
		{
			get
			{
				short num = (short)1668022272;
				short num2 = num;
				num = (short)1188112119;
				short num3 = num;
				num = (short)752232183;
				switch (num3 == num)
				{
				}
				num = (short)1319436288;
				if (num != 0)
				{
				}
				num = (short)1855062017;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759.Value;
			}
			set
			{
				short num = (short)281149440;
				short num2 = num;
				num = (short)1610423015;
				short num3 = num;
				num = (short)1035279079;
				switch (num3 == num)
				{
				}
				num = (short)702218241;
				if (num != 0)
				{
				}
				num = (short)2118647808;
				if (num != 0)
				{
				}
				this.radErgoControlKMANaviControlName_41759.Value = value;
			}
		}

		// Token: 0x17003FAC RID: 16300
		// (get) Token: 0x06007C52 RID: 31826 RVA: 0x007206FC File Offset: 0x0071E8FC
		// (set) Token: 0x06007C53 RID: 31827 RVA: 0x007207B0 File Offset: 0x0071E9B0
		public bool RadErgoControlKMANaviControlName_41759_Applicable
		{
			get
			{
				short num = (short)342294528;
				short num2 = num;
				num = (short)936474761;
				short num3 = num;
				num = (short)2018408585;
				switch (num3 == num)
				{
				}
				num = (short)683081728;
				if (num != 0)
				{
				}
				num = (short)1523777537;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759.Applicable;
			}
			set
			{
				short num = (short)1044643840;
				short num2 = num;
				num = (short)3123986;
				short num3 = num;
				num = (short)1129098002;
				switch (num3 == num)
				{
				}
				num = (short)94568449;
				if (num != 0)
				{
				}
				num = (short)2080768000;
				if (num != 0)
				{
				}
				this.radErgoControlKMANaviControlName_41759.Applicable = value;
			}
		}

		// Token: 0x17003FAD RID: 16301
		// (get) Token: 0x06007C54 RID: 31828 RVA: 0x00720864 File Offset: 0x0071EA64
		// (set) Token: 0x06007C55 RID: 31829 RVA: 0x00720918 File Offset: 0x0071EB18
		public bool RadErgoControlKMANaviControlName_41759_Valid
		{
			get
			{
				short num = (short)802947072;
				short num2 = num;
				num = (short)1614066494;
				short num3 = num;
				num = (short)697217854;
				switch (num3 == num)
				{
				}
				num = (short)1172897793;
				if (num != 0)
				{
				}
				num = (short)1853882368;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759.Valid;
			}
			set
			{
				short num = (short)1760821248;
				short num2 = num;
				num = (short)1813459009;
				short num3 = num;
				num = (short)1496592449;
				switch (num3 == num)
				{
				}
				num = (short)42795008;
				if (num != 0)
				{
				}
				num = (short)1599471617;
				if (num != 0)
				{
				}
				this.radErgoControlKMANaviControlName_41759.Valid = value;
			}
		}

		// Token: 0x17003FAE RID: 16302
		// (get) Token: 0x06007C56 RID: 31830 RVA: 0x007209D0 File Offset: 0x0071EBD0
		// (set) Token: 0x06007C57 RID: 31831 RVA: 0x00720A80 File Offset: 0x0071EC80
		public bool RadErgoControlKMANaviControlName_41759_Visible
		{
			get
			{
				short num = (short)196149248;
				short num2 = num;
				num = (short)1547975665;
				short num3 = num;
				num = (short)893926385;
				switch (num3 == num)
				{
				}
				num = (short)1713963008;
				if (num != 0)
				{
				}
				num = (short)1201799169;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759.Visible;
			}
			set
			{
				short num = (short)2070257333;
				short num2 = num;
				num = (short)764649141;
				switch (num2 == num)
				{
				}
				num = (short)765001728;
				if (num != 0)
				{
				}
				num = (short)290521088;
				short num3 = num;
				num = (short)2013265921;
				if (num != 0)
				{
				}
				this.radErgoControlKMANaviControlName_41759.Visible = value;
			}
		}

		// Token: 0x17003FAF RID: 16303
		// (get) Token: 0x06007C58 RID: 31832 RVA: 0x00720B34 File Offset: 0x0071ED34
		// (set) Token: 0x06007C59 RID: 31833 RVA: 0x00720BE8 File Offset: 0x0071EDE8
		public bool RadErgoControlKMANaviControlName_41759_Editable
		{
			get
			{
				short num = (short)1501323205;
				short num2 = num;
				num = (short)767057861;
				switch (num2 == num)
				{
				}
				num = (short)2017132545;
				if (num != 0)
				{
				}
				num = (short)2097741824;
				short num3 = num;
				num = (short)765591552;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759.Editable;
			}
			set
			{
				short num = (short)1654887134;
				short num2 = num;
				num = (short)1756664542;
				switch (num2 == num)
				{
				}
				num = (short)1899233281;
				if (num != 0)
				{
				}
				num = (short)1549074432;
				short num3 = num;
				num = (short)1427505152;
				if (num != 0)
				{
				}
				this.radErgoControlKMANaviControlName_41759.Editable = value;
			}
		}

		// Token: 0x17003FB0 RID: 16304
		// (get) Token: 0x06007C5A RID: 31834 RVA: 0x00720CA0 File Offset: 0x0071EEA0
		internal string RadErgoControlKMANaviControlName_41759_UILabel
		{
			get
			{
				short num = (short)1341574502;
				short num2 = num;
				num = (short)746114406;
				switch (num2 == num)
				{
				}
				num = (short)961347584;
				if (num != 0)
				{
				}
				num = (short)1554907136;
				short num3 = num;
				num = (short)1774190593;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759.UIName;
			}
		}

		// Token: 0x17003FB1 RID: 16305
		// (get) Token: 0x06007C5B RID: 31835 RVA: 0x00720D54 File Offset: 0x0071EF54
		// (set) Token: 0x06007C5C RID: 31836 RVA: 0x00720E08 File Offset: 0x0071F008
		internal bool RadErgoControlKMANaviControlName_41759_HiddenStatic
		{
			get
			{
				short num = (short)1443207856;
				short num2 = num;
				num = (short)1711053488;
				switch (num2 == num)
				{
				}
				num = (short)1561395201;
				if (num != 0)
				{
				}
				num = (short)329908224;
				short num3 = num;
				num = (short)1659961344;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759.HiddenStatic;
			}
			set
			{
				short num = (short)747934555;
				short num2 = num;
				num = (short)1382847323;
				switch (num2 == num)
				{
				}
				num = (short)1346437120;
				if (num != 0)
				{
				}
				num = (short)2025324544;
				short num3 = num;
				num = (short)1350631425;
				if (num != 0)
				{
				}
				this.radErgoControlKMANaviControlName_41759.HiddenStatic = value;
			}
		}

		// Token: 0x17003FB2 RID: 16306
		// (get) Token: 0x06007C5D RID: 31837 RVA: 0x00720EC0 File Offset: 0x0071F0C0
		// (set) Token: 0x06007C5E RID: 31838 RVA: 0x00720F78 File Offset: 0x0071F178
		internal bool RadErgoControlKMANaviControlName_41759_HiddenDynamic
		{
			get
			{
				short num = (short)1082160101;
				short num2 = num;
				num = (short)1981182949;
				switch (num2 == num)
				{
				}
				num = (short)543162369;
				if (num != 0)
				{
				}
				num = (short)827719680;
				short num3 = num;
				num = (short)1771372544;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759.HiddenDynamic;
			}
			set
			{
				short num = (short)761180216;
				short num2 = num;
				num = (short)565096504;
				switch (num2 == num)
				{
				}
				num = (short)954662913;
				if (num != 0)
				{
				}
				num = (short)1311178752;
				short num3 = num;
				num = (short)1525350400;
				if (num != 0)
				{
				}
				this.radErgoControlKMANaviControlName_41759.HiddenDynamic = value;
			}
		}

		// Token: 0x17003FB3 RID: 16307
		// (get) Token: 0x06007C5F RID: 31839 RVA: 0x0072102C File Offset: 0x0071F22C
		public bool RadErgoControlKMANaviControlName_41759_HasDiffs
		{
			get
			{
				short num = (short)983286760;
				short num2 = num;
				num = (short)360170472;
				switch (num2 == num)
				{
				}
				num = (short)1724710913;
				if (num != 0)
				{
				}
				num = (short)905052160;
				short num3 = num;
				num = (short)1305083904;
				if (num != 0)
				{
				}
				return this.radErgoControlKMANaviControlName_41759._HasDiffs;
			}
		}

		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x06007C60 RID: 31840 RVA: 0x007210E0 File Offset: 0x0071F2E0
		// (set) Token: 0x06007C61 RID: 31841 RVA: 0x00721194 File Offset: 0x0071F394
		public int RadErgoControlKMAUpDownButton_41760Value
		{
			get
			{
				short num = (short)1169672067;
				short num2 = num;
				num = (short)651085699;
				switch (num2 == num)
				{
				}
				num = (short)1516568577;
				if (num != 0)
				{
				}
				num = (short)1903689728;
				short num3 = num;
				num = (short)1709047808;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760.Value;
			}
			set
			{
				short num = (short)1649017453;
				short num2 = num;
				num = (short)1958085229;
				switch (num2 == num)
				{
				}
				num = (short)1934098432;
				if (num != 0)
				{
				}
				num = (short)452329472;
				short num3 = num;
				num = (short)242483201;
				if (num != 0)
				{
				}
				this.radErgoControlKMAUpDownButton_41760.Value = value;
			}
		}

		// Token: 0x17003FB5 RID: 16309
		// (get) Token: 0x06007C62 RID: 31842 RVA: 0x00721248 File Offset: 0x0071F448
		// (set) Token: 0x06007C63 RID: 31843 RVA: 0x00721300 File Offset: 0x0071F500
		public string RadErgoControlKMAUpDownButton_41760_UIValue
		{
			get
			{
				short num = (short)224177534;
				short num2 = num;
				num = (short)1948036478;
				switch (num2 == num)
				{
				}
				num = (short)1558577152;
				if (num != 0)
				{
				}
				num = (short)1962409984;
				short num3 = num;
				num = (short)434241537;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760.UIValue;
			}
			set
			{
				short num = (short)1980301313;
				if (num != 0)
				{
				}
				num = (short)1126478052;
				short num2 = num;
				num = (short)1025028324;
				switch (num2 == num)
				{
				}
				num = (short)1248788480;
				short num3 = num;
				num = (short)6225920;
				if (num != 0)
				{
				}
				this.radErgoControlKMAUpDownButton_41760.UIValue = value;
			}
		}

		// Token: 0x17003FB6 RID: 16310
		// (get) Token: 0x06007C64 RID: 31844 RVA: 0x007213B4 File Offset: 0x0071F5B4
		public global::AcpBusinessLayer.AcpListField RadErgoControlKMAUpDownButton_41760
		{
			get
			{
				short num = (short)1950414982;
				short num2 = num;
				num = (short)1794832518;
				switch (num2 == num)
				{
				}
				num = (short)1544093697;
				if (num != 0)
				{
				}
				num = (short)1639383040;
				short num3 = num;
				num = (short)1237123072;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760;
			}
		}

		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x06007C65 RID: 31845 RVA: 0x00721464 File Offset: 0x0071F664
		// (set) Token: 0x06007C66 RID: 31846 RVA: 0x0072151C File Offset: 0x0071F71C
		public bool RadErgoControlKMAUpDownButton_41760_Applicable
		{
			get
			{
				short num = (short)1654012396;
				short num2 = num;
				num = (short)404175340;
				switch (num2 == num)
				{
				}
				num = (short)347013120;
				if (num != 0)
				{
				}
				num = (short)1644494848;
				short num3 = num;
				num = (short)85065729;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760.Applicable;
			}
			set
			{
				short num = (short)1806514958;
				short num2 = num;
				num = (short)1272920846;
				switch (num2 == num)
				{
				}
				num = (short)1891696641;
				if (num != 0)
				{
				}
				num = (short)1063452672;
				short num3 = num;
				num = (short)1819475968;
				if (num != 0)
				{
				}
				this.radErgoControlKMAUpDownButton_41760.Applicable = value;
			}
		}

		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x06007C67 RID: 31847 RVA: 0x007215D0 File Offset: 0x0071F7D0
		// (set) Token: 0x06007C68 RID: 31848 RVA: 0x00721684 File Offset: 0x0071F884
		public bool RadErgoControlKMAUpDownButton_41760_Valid
		{
			get
			{
				short num = (short)170608565;
				short num2 = num;
				num = (short)1292715957;
				switch (num2 == num)
				{
				}
				num = (short)1071710208;
				if (num != 0)
				{
				}
				num = (short)909049856;
				short num3 = num;
				num = (short)2029322241;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760.Valid;
			}
			set
			{
				short num = (short)900071425;
				if (num != 0)
				{
				}
				num = (short)11643497;
				short num2 = num;
				num = (short)1230416489;
				switch (num2 == num)
				{
				}
				num = (short)1958019072;
				short num3 = num;
				num = (short)872349696;
				if (num != 0)
				{
				}
				this.radErgoControlKMAUpDownButton_41760.Valid = value;
			}
		}

		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x06007C69 RID: 31849 RVA: 0x0072173C File Offset: 0x0071F93C
		// (set) Token: 0x06007C6A RID: 31850 RVA: 0x007217EC File Offset: 0x0071F9EC
		public bool RadErgoControlKMAUpDownButton_41760_Visible
		{
			get
			{
				short num = (short)1737174893;
				short num2 = num;
				num = (short)640364397;
				switch (num2 == num)
				{
				}
				num = (short)88014848;
				if (num != 0)
				{
				}
				num = (short)2037514240;
				short num3 = num;
				num = (short)989790209;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760.Visible;
			}
			set
			{
				short num = (short)1636967858;
				short num2 = num;
				num = (short)1712989618;
				switch (num2 == num)
				{
				}
				num = (short)784531457;
				if (num != 0)
				{
				}
				num = (short)1642397696;
				short num3 = num;
				num = (short)550567936;
				if (num != 0)
				{
				}
				this.radErgoControlKMAUpDownButton_41760.Visible = value;
			}
		}

		// Token: 0x17003FBA RID: 16314
		// (get) Token: 0x06007C6B RID: 31851 RVA: 0x007218A4 File Offset: 0x0071FAA4
		// (set) Token: 0x06007C6C RID: 31852 RVA: 0x0072195C File Offset: 0x0071FB5C
		public bool RadErgoControlKMAUpDownButton_41760_Editable
		{
			get
			{
				short num = (short)1701990618;
				short num2 = num;
				num = (short)1386238170;
				switch (num2 == num)
				{
				}
				num = (short)1060241408;
				if (num != 0)
				{
				}
				num = (short)1153695744;
				short num3 = num;
				num = (short)1540161537;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760.Editable;
			}
			set
			{
				short num = (short)899402664;
				short num2 = num;
				num = (short)8113064;
				switch (num2 == num)
				{
				}
				num = (short)1860567040;
				short num3 = num;
				num = (short)566165504;
				if (num != 0)
				{
				}
				num = (short)1740570625;
				if (num != 0)
				{
				}
				this.radErgoControlKMAUpDownButton_41760.Editable = value;
			}
		}

		// Token: 0x17003FBB RID: 16315
		// (get) Token: 0x06007C6D RID: 31853 RVA: 0x00721A10 File Offset: 0x0071FC10
		internal string RadErgoControlKMAUpDownButton_41760_UILabel
		{
			get
			{
				short num = (short)765691406;
				short num2 = num;
				num = (short)675448334;
				switch (num2 == num)
				{
				}
				num = (short)1625358336;
				short num3 = num;
				num = (short)841744385;
				if (num != 0)
				{
				}
				num = (short)1842675712;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760.UIName;
			}
		}

		// Token: 0x17003FBC RID: 16316
		// (get) Token: 0x06007C6E RID: 31854 RVA: 0x00721AC4 File Offset: 0x0071FCC4
		// (set) Token: 0x06007C6F RID: 31855 RVA: 0x00721B78 File Offset: 0x0071FD78
		internal bool RadErgoControlKMAUpDownButton_41760_HiddenStatic
		{
			get
			{
				short num = (short)87915003;
				short num2 = num;
				num = (short)1439988219;
				switch (num2 == num)
				{
				}
				num = (short)964296704;
				short num3 = num;
				num = (short)258211841;
				if (num != 0)
				{
				}
				num = (short)647823360;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760.HiddenStatic;
			}
			set
			{
				short num = (short)993731315;
				short num2 = num;
				num = (short)1097212659;
				switch (num2 == num)
				{
				}
				num = (short)1792802816;
				short num3 = num;
				num = (short)261357568;
				if (num != 0)
				{
				}
				num = (short)40370177;
				if (num != 0)
				{
				}
				this.radErgoControlKMAUpDownButton_41760.HiddenStatic = value;
			}
		}

		// Token: 0x17003FBD RID: 16317
		// (get) Token: 0x06007C70 RID: 31856 RVA: 0x00721C2C File Offset: 0x0071FE2C
		// (set) Token: 0x06007C71 RID: 31857 RVA: 0x00721CE0 File Offset: 0x0071FEE0
		internal bool RadErgoControlKMAUpDownButton_41760_HiddenDynamic
		{
			get
			{
				short num = (short)258449663;
				short num2 = num;
				num = (short)1160159487;
				switch (num2 == num)
				{
				}
				num = (short)924188672;
				short num3 = num;
				num = (short)1360396288;
				if (num != 0)
				{
				}
				num = (short)849674241;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760.HiddenDynamic;
			}
			set
			{
				short num = (short)1793139209;
				short num2 = num;
				num = (short)1257447945;
				switch (num2 == num)
				{
				}
				num = (short)1735655424;
				short num3 = num;
				num = (short)1561133057;
				if (num != 0)
				{
				}
				num = (short)1145372672;
				if (num != 0)
				{
				}
				this.radErgoControlKMAUpDownButton_41760.HiddenDynamic = value;
			}
		}

		// Token: 0x17003FBE RID: 16318
		// (get) Token: 0x06007C72 RID: 31858 RVA: 0x00721D98 File Offset: 0x0071FF98
		public bool RadErgoControlKMAUpDownButton_41760_HasDiffs
		{
			get
			{
				short num = (short)185583137;
				short num2 = num;
				num = (short)2109654561;
				switch (num2 == num)
				{
				}
				num = (short)2033254400;
				short num3 = num;
				num = (short)826408960;
				if (num != 0)
				{
				}
				num = (short)857866241;
				if (num != 0)
				{
				}
				return this.radErgoControlKMAUpDownButton_41760._HasDiffs;
			}
		}

		// Token: 0x06007C73 RID: 31859 RVA: 0x00721E4C File Offset: 0x0072004C
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
					goto IL_F5;
				case 1:
					num2 = (short)274006017;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)1665335298;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				case 2:
					num2 = (short)1750794243;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)2143813636;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				case 4:
					for (;;)
					{
						num2 = (short)1665452316;
						short num3 = num2;
						num2 = (short)950847772;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B7;
						}
					}
					IL_B7:
					num2 = (short)392691712;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1388183552;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_F5:
			IL_138:
			num2 = (short)92536832;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)879427585;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040037C8 RID: 14280
		private global::AcpBusinessLayer.AcpField<string> radErgoControlKMANaviControlName_41759;

		// Token: 0x040037C9 RID: 14281
		private global::AcpBusinessLayer.AcpListField radErgoControlKMAUpDownButton_41760;
	}
}
