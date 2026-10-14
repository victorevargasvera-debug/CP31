using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003E3 RID: 995
	[global::System.Serializable]
	public class O2MultiFunctionKnob : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008C1F RID: 35871 RVA: 0x00831C64 File Offset: 0x0082FE64
		public O2MultiFunctionKnob(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008C20 RID: 35872 RVA: 0x00831CA4 File Offset: 0x0082FEA4
		protected O2MultiFunctionKnob(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008C21 RID: 35873 RVA: 0x00831CBC File Offset: 0x0082FEBC
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1784459285;
			short num2 = num;
			num = (short)955297813;
			switch (num2 == num)
			{
			}
			num = (short)944177153;
			if (num != 0)
			{
			}
			num = (short)1822031872;
			short num3 = num;
			num = (short)504692736;
			if (num != 0)
			{
			}
			this.radErgoControlO2MFKButtonPress_A42217 = new global::AcpBusinessLayer.AcpSparseLOVField(215, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.indexRadErgoControlO2MFKButtonPress_A42217LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.idRadErgoControlO2MFKButtonPress_A42217LovStrs), this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ跡諣鋥髧藩胫ꇭ싯뿱닳뷵뫷迹裻諽濿氁吃琅洇礉缋儍儏☑☓␕⤗ⴙ", a_), global::CommonResources.AcgResources.ID_MFKPRESSBEHAVIOR, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.RadErgoControlO2MFKButtonPress_A42217LovStrs);
			this.radErgoControlO2MFKButtonPress_A42217.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoControlO2MFKButtonPress_A42217.DataTransferOrder = 18;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿑ꇓ뫕곗동飝闟賡蟣鋥臧藩苫컭믯鳱鯳铵", a_);
			base.Id = 10721;
			base.UIName = global::CommonResources.AcgResources.ID_MULTIFUNCTIONKNOB;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x00831DF0 File Offset: 0x0082FFF0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)1685192710;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields != null)
					{
						num = (short)589299715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AE;
				case 1:
					num = (short)1191444481;
					if (num != 0)
					{
					}
					goto IL_1AE;
				case 2:
				{
					num = (short)593428480;
					short num3 = num;
					this.radErgoControlO2MFKButtonPress_A42217 = new global::AcpBusinessLayer.AcpSparseLOVField(215, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.indexRadErgoControlO2MFKButtonPress_A42217LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.idRadErgoControlO2MFKButtonPress_A42217LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鿛뇝軟雡難觥蓧ꗩ\udeebꏭ뛯맱뛳菵賷軹鏻都僿瀁愃甅笇唉䴋㨍∏‑┓ℕ", a_), global::CommonResources.AcgResources.ID_MFKPRESSBEHAVIOR, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.RadErgoControlO2MFKButtonPress_A42217LovStrs);
					this.radErgoControlO2MFKButtonPress_A42217.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoControlO2MFKButtonPress_A42217.DataTransferOrder = 18;
					num = (short)1701445633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					num = (short)975372293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1736507392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鿛뇝軟雡難觥蓧ꗩ\udeebꏭ뛯맱뛳菵賷軹鏻都僿瀁愃甅笇唉䴋㨍∏‑┓ℕ", a_)))
					{
						num = (short)331153410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AE;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				}
				goto IL_4B;
				IL_55:
				num = (short)1288568836;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AE:
				num = (short)1881661224;
				short num4 = num;
				num = (short)1757470504;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_55;
				default:
					goto IL_1E2;
				}
				IL_4B:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_55;
				}
				goto IL_1AE;
			}
			IL_1E2:
			num = (short)1150353408;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菍ꗏ뻑ꃓ뿕鳙꧛냝菟雡跣觥蛧쫩꟫胭鿯郱", a_);
			base.Id = 10721;
			base.UIName = global::CommonResources.AcgResources.ID_MULTIFUNCTIONKNOB;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06008C23 RID: 35875 RVA: 0x00832028 File Offset: 0x00830228
		public override void PopulateReferences()
		{
			short num = (short)2122252975;
			short num2 = num;
			num = (short)2121073327;
			switch (num2 == num)
			{
			}
			num = (short)448921601;
			if (num != 0)
			{
			}
			num = (short)911736832;
			short num3 = num;
			num = (short)1534525440;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008C24 RID: 35876 RVA: 0x008320D4 File Offset: 0x008302D4
		public override void DropReferences()
		{
			short num = (short)475231687;
			short num2 = num;
			num = (short)281179591;
			switch (num2 == num)
			{
			}
			num = (short)1782513665;
			if (num != 0)
			{
			}
			num = (short)2104098816;
			short num3 = num;
			num = (short)2135031808;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x00832180 File Offset: 0x00830380
		public override void SetConstraints()
		{
			short num = (short)430324997;
			short num2 = num;
			num = (short)537279749;
			switch (num2 == num)
			{
			}
			num = (short)1657405441;
			if (num != 0)
			{
			}
			num = (short)1215102976;
			short num3 = num;
			num = (short)823656448;
			if (num != 0)
			{
			}
			this.radErgoControlO2MFKButtonPress_A42217.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.ConStandaloneRadioSystemEnableApp);
			this.radErgoControlO2MFKButtonPress_A42217.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.ConMFKButtonBehaviorToShepherds);
		}

		// Token: 0x06008C26 RID: 35878 RVA: 0x00832258 File Offset: 0x00830458
		public override void SetupDependencies()
		{
			short num = (short)712344409;
			short num2 = num;
			num = (short)904758105;
			switch (num2 == num)
			{
			}
			num = (short)1393491969;
			if (num != 0)
			{
			}
			num = (short)655884288;
			short num3 = num;
			num = (short)1158479872;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoControlO2MFKButtonPress_A42217);
			this.RefControlHeadO7.O7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218.AddDependentObject(this.radErgoControlO2MFKButtonPress_A42217);
			this.RefRadioWide.Labtool.RadWideLabtoolMFKEmergencyAccess_A42216.AddDependentObject(this.radErgoControlO2MFKButtonPress_A42217);
		}

		// Token: 0x170046F7 RID: 18167
		// (get) Token: 0x06008C27 RID: 35879 RVA: 0x00832358 File Offset: 0x00830558
		public bool HasDiffs
		{
			get
			{
				short num = (short)1734213633;
				if (num != 0)
				{
				}
				num = (short)1277011418;
				short num2 = num;
				num = (short)403219930;
				switch (num2 == num)
				{
				}
				num = (short)747175936;
				short num3 = num;
				num = (short)142868480;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170046F8 RID: 18168
		// (get) Token: 0x06008C28 RID: 35880 RVA: 0x00832404 File Offset: 0x00830604
		// (set) Token: 0x06008C29 RID: 35881 RVA: 0x008324B8 File Offset: 0x008306B8
		public int RadErgoControlO2MFKButtonPress_A42217Value
		{
			get
			{
				short num = (short)339872830;
				short num2 = num;
				num = (short)1713376318;
				switch (num2 == num)
				{
				}
				num = (short)883425280;
				if (num != 0)
				{
				}
				num = (short)1272578048;
				short num3 = num;
				num = (short)1231028225;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217.Value;
			}
			set
			{
				short num = (short)221621844;
				short num2 = num;
				num = (short)1401663060;
				switch (num2 == num)
				{
				}
				num = (short)1424424961;
				if (num != 0)
				{
				}
				num = (short)1650065408;
				short num3 = num;
				num = (short)1141309440;
				if (num != 0)
				{
				}
				this.radErgoControlO2MFKButtonPress_A42217.Value = value;
			}
		}

		// Token: 0x170046F9 RID: 18169
		// (get) Token: 0x06008C2A RID: 35882 RVA: 0x0083256C File Offset: 0x0083076C
		// (set) Token: 0x06008C2B RID: 35883 RVA: 0x00832620 File Offset: 0x00830820
		public string RadErgoControlO2MFKButtonPress_A42217_UIValue
		{
			get
			{
				short num = (short)411165367;
				short num2 = num;
				num = (short)376234679;
				switch (num2 == num)
				{
				}
				num = (short)381288449;
				if (num != 0)
				{
				}
				num = (short)734003200;
				short num3 = num;
				num = (short)1026752512;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217.UIValue;
			}
			set
			{
				short num = (short)678250896;
				short num2 = num;
				num = (short)1071663504;
				switch (num2 == num)
				{
				}
				num = (short)1391001601;
				if (num != 0)
				{
				}
				num = (short)423821312;
				short num3 = num;
				num = (short)128778240;
				if (num != 0)
				{
				}
				this.radErgoControlO2MFKButtonPress_A42217.UIValue = value;
			}
		}

		// Token: 0x170046FA RID: 18170
		// (get) Token: 0x06008C2C RID: 35884 RVA: 0x008326D4 File Offset: 0x008308D4
		public global::AcpBusinessLayer.AcpListField RadErgoControlO2MFKButtonPress_A42217
		{
			get
			{
				short num = (short)1028404547;
				short num2 = num;
				num = (short)498152771;
				switch (num2 == num)
				{
				}
				num = (short)2135949313;
				if (num != 0)
				{
				}
				num = (short)1605959680;
				short num3 = num;
				num = (short)1735524352;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217;
			}
		}

		// Token: 0x170046FB RID: 18171
		// (get) Token: 0x06008C2D RID: 35885 RVA: 0x00832784 File Offset: 0x00830984
		// (set) Token: 0x06008C2E RID: 35886 RVA: 0x00832838 File Offset: 0x00830A38
		public bool RadErgoControlO2MFKButtonPress_A42217_Applicable
		{
			get
			{
				short num = (short)1859614721;
				short num2 = num;
				num = (short)384792577;
				switch (num2 == num)
				{
				}
				num = (short)822214657;
				if (num != 0)
				{
				}
				num = (short)476905472;
				short num3 = num;
				num = (short)1482948608;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217.Applicable;
			}
			set
			{
				short num = (short)1258202417;
				short num2 = num;
				num = (short)855745841;
				switch (num2 == num)
				{
				}
				num = (short)1652162560;
				if (num != 0)
				{
				}
				num = (short)56819712;
				short num3 = num;
				num = (short)1123418113;
				if (num != 0)
				{
				}
				this.radErgoControlO2MFKButtonPress_A42217.Applicable = value;
			}
		}

		// Token: 0x170046FC RID: 18172
		// (get) Token: 0x06008C2F RID: 35887 RVA: 0x008328EC File Offset: 0x00830AEC
		// (set) Token: 0x06008C30 RID: 35888 RVA: 0x008329A0 File Offset: 0x00830BA0
		public bool RadErgoControlO2MFKButtonPress_A42217_Valid
		{
			get
			{
				short num = (short)1477050369;
				if (num != 0)
				{
				}
				num = (short)1322114714;
				short num2 = num;
				num = (short)1778966170;
				switch (num2 == num)
				{
				}
				num = (short)1992622080;
				short num3 = num;
				num = (short)912326656;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217.Valid;
			}
			set
			{
				short num = (short)1978051545;
				short num2 = num;
				num = (short)477998041;
				switch (num2 == num)
				{
				}
				num = (short)1813577729;
				if (num != 0)
				{
				}
				num = (short)136904704;
				short num3 = num;
				num = (short)802160640;
				if (num != 0)
				{
				}
				this.radErgoControlO2MFKButtonPress_A42217.Valid = value;
			}
		}

		// Token: 0x170046FD RID: 18173
		// (get) Token: 0x06008C31 RID: 35889 RVA: 0x00832A58 File Offset: 0x00830C58
		// (set) Token: 0x06008C32 RID: 35890 RVA: 0x00832B10 File Offset: 0x00830D10
		public bool RadErgoControlO2MFKButtonPress_A42217_Visible
		{
			get
			{
				short num = (short)2034539988;
				short num2 = num;
				num = (short)180919764;
				switch (num2 == num)
				{
				}
				num = (short)1704394752;
				if (num != 0)
				{
				}
				num = (short)1479999488;
				short num3 = num;
				num = (short)83558401;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217.Visible;
			}
			set
			{
				short num = (short)612603921;
				short num2 = num;
				num = (short)1881380881;
				switch (num2 == num)
				{
				}
				num = (short)1047789569;
				if (num != 0)
				{
				}
				num = (short)321650688;
				short num3 = num;
				num = (short)2005270528;
				if (num != 0)
				{
				}
				this.radErgoControlO2MFKButtonPress_A42217.Visible = value;
			}
		}

		// Token: 0x170046FE RID: 18174
		// (get) Token: 0x06008C33 RID: 35891 RVA: 0x00832BC4 File Offset: 0x00830DC4
		// (set) Token: 0x06008C34 RID: 35892 RVA: 0x00832C7C File Offset: 0x00830E7C
		public bool RadErgoControlO2MFKButtonPress_A42217_Editable
		{
			get
			{
				short num = (short)1012944975;
				short num2 = num;
				num = (short)136859727;
				switch (num2 == num)
				{
				}
				num = (short)1617297409;
				if (num != 0)
				{
				}
				num = (short)832765952;
				short num3 = num;
				num = (short)1413021696;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217.Editable;
			}
			set
			{
				short num = (short)710978593;
				short num2 = num;
				num = (short)2048764961;
				switch (num2 == num)
				{
				}
				num = (short)797769728;
				if (num != 0)
				{
				}
				num = (short)1751711744;
				short num3 = num;
				num = (short)1222180865;
				if (num != 0)
				{
				}
				this.radErgoControlO2MFKButtonPress_A42217.Editable = value;
			}
		}

		// Token: 0x170046FF RID: 18175
		// (get) Token: 0x06008C35 RID: 35893 RVA: 0x00832D34 File Offset: 0x00830F34
		internal string RadErgoControlO2MFKButtonPress_A42217_UILabel
		{
			get
			{
				short num = (short)1669863161;
				short num2 = num;
				num = (short)875632377;
				switch (num2 == num)
				{
				}
				num = (short)2034434048;
				if (num != 0)
				{
				}
				num = (short)1956184064;
				short num3 = num;
				num = (short)674758657;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217.UIName;
			}
		}

		// Token: 0x17004700 RID: 18176
		// (get) Token: 0x06008C36 RID: 35894 RVA: 0x00832DE8 File Offset: 0x00830FE8
		// (set) Token: 0x06008C37 RID: 35895 RVA: 0x00832E9C File Offset: 0x0083109C
		internal bool RadErgoControlO2MFKButtonPress_A42217_HiddenStatic
		{
			get
			{
				short num = (short)1583951138;
				short num2 = num;
				num = (short)940256546;
				switch (num2 == num)
				{
				}
				num = (short)276496385;
				if (num != 0)
				{
				}
				num = (short)862584832;
				short num3 = num;
				num = (short)1981546496;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217.HiddenStatic;
			}
			set
			{
				short num = (short)1397454267;
				short num2 = num;
				num = (short)1293120955;
				switch (num2 == num)
				{
				}
				num = (short)1490092033;
				if (num != 0)
				{
				}
				num = (short)1131937792;
				short num3 = num;
				num = (short)701693952;
				if (num != 0)
				{
				}
				this.radErgoControlO2MFKButtonPress_A42217.HiddenStatic = value;
			}
		}

		// Token: 0x17004701 RID: 18177
		// (get) Token: 0x06008C38 RID: 35896 RVA: 0x00832F50 File Offset: 0x00831150
		// (set) Token: 0x06008C39 RID: 35897 RVA: 0x00833004 File Offset: 0x00831204
		internal bool RadErgoControlO2MFKButtonPress_A42217_HiddenDynamic
		{
			get
			{
				short num = (short)163148087;
				short num2 = num;
				num = (short)1586917687;
				switch (num2 == num)
				{
				}
				num = (short)1360723969;
				if (num != 0)
				{
				}
				num = (short)794296320;
				short num3 = num;
				num = (short)1413808128;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217.HiddenDynamic;
			}
			set
			{
				short num = (short)702314335;
				short num2 = num;
				num = (short)267548511;
				switch (num2 == num)
				{
				}
				num = (short)980877312;
				if (num != 0)
				{
				}
				num = (short)839319552;
				short num3 = num;
				num = (short)1298006017;
				if (num != 0)
				{
				}
				this.radErgoControlO2MFKButtonPress_A42217.HiddenDynamic = value;
			}
		}

		// Token: 0x17004702 RID: 18178
		// (get) Token: 0x06008C3A RID: 35898 RVA: 0x008330BC File Offset: 0x008312BC
		public bool RadErgoControlO2MFKButtonPress_A42217_HasDiffs
		{
			get
			{
				short num = (short)1524736472;
				short num2 = num;
				num = (short)194486744;
				switch (num2 == num)
				{
				}
				num = (short)1869611009;
				if (num != 0)
				{
				}
				num = (short)388169728;
				short num3 = num;
				num = (short)1281622016;
				if (num != 0)
				{
				}
				return this.radErgoControlO2MFKButtonPress_A42217._HasDiffs;
			}
		}

		// Token: 0x17004703 RID: 18179
		// (get) Token: 0x06008C3B RID: 35899 RVA: 0x00833170 File Offset: 0x00831370
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1230807617;
				short num2 = num;
				num = (short)244556353;
				switch (num2 == num)
				{
				}
				num = (short)1315766272;
				if (num != 0)
				{
				}
				num = (short)1794113536;
				short num3 = num;
				num = (short)919470081;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17004704 RID: 18180
		// (get) Token: 0x06008C3C RID: 35900 RVA: 0x00833230 File Offset: 0x00831430
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7 RefControlHeadO7
		{
			get
			{
				short num = (short)819576904;
				short num2 = num;
				num = (short)1448460360;
				switch (num2 == num)
				{
				}
				num = (short)189530113;
				if (num != 0)
				{
				}
				num = (short)29097984;
				short num3 = num;
				num = (short)533200896;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4114)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7;
			}
		}

		// Token: 0x06008C3D RID: 35901 RVA: 0x008332F0 File Offset: 0x008314F0
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
					IL_C8:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)67633153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F2;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)2071789569;
					if (num2 != 0)
					{
					}
					num2 = (short)1020592131;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1862991872;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_F2;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)184745986;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F2;
				}
				goto IL_24;
				IL_F2:
				num2 = (short)1254562215;
				short num3 = num2;
				num2 = (short)1307253159;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C8;
				default:
					goto IL_128;
				}
			}
			IL_128:
			num2 = (short)1131610112;
			if (num2 != 0)
			{
			}
			num2 = (short)704905216;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)1038680068;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040043EB RID: 17387
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset innerRecset;

		// Token: 0x040043EC RID: 17388
		private global::AcpBusinessLayer.AcpListField radErgoControlO2MFKButtonPress_A42217;
	}
}
