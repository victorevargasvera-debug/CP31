using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004EE RID: 1262
	[global::System.Serializable]
	public class QuickTextMessageListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A983 RID: 43395 RVA: 0x009D4D40 File Offset: 0x009D2F40
		public QuickTextMessageListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A984 RID: 43396 RVA: 0x009D4D5C File Offset: 0x009D2F5C
		protected QuickTextMessageListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A985 RID: 43397 RVA: 0x009D4D74 File Offset: 0x009D2F74
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1206540520;
			short num2 = num;
			num = (short)2032294120;
			switch (num2 == num)
			{
			}
			num = (short)950992896;
			if (num != 0)
			{
			}
			num = (short)610664448;
			short num3 = num;
			num = (short)1639317505;
			if (num != 0)
			{
			}
			this.dataWideQuickTextMessageListQuickTextMessage_A8810 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_MESSAGE1, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟돡釣迥诧臩룫语裯蛱맳鏵请觹鷻駽旿丁洃甅簇嬉礋服猏礑䀓猕怗渙儛笝匟儡䔣䄥䴧甩洫ᘭ࠯̱г", a_), global::CommonResources.AcgResources.ID_QUICKTEXTMESSAGE, 50);
			this.dataWideQuickTextMessageListQuickTextMessage_A8810.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataWideQuickTextMessageListQuickTextMessage_A8810.DataTransferOrder = 16;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菑ꇓ뿕믗뇙ﳛ諝藟髡郣웥ꗧ迩鿫鷭釯闱釳훵듷鏹迻諽", a_);
			base.Id = 10072;
			base.UIName = global::CommonResources.AcgResources.ID_QUICKTEXTMESSAGELIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600A986 RID: 43398 RVA: 0x009D4E98 File Offset: 0x009D3098
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)446562304;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1185369448;
					short num3 = num;
					num = (short)1713458536;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E6;
					default:
						num = (short)1800732672;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					}
					break;
				}
				case 1:
					goto IL_10F;
				case 2:
					num = (short)750059521;
					if (num != 0)
					{
					}
					if (producerFields != null)
					{
						num = (short)396492800;
						short num4 = num;
						num = (short)2095972355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EB;
				case 3:
					goto IL_1E6;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎胐ꛒ볔듖님迚룜꟞闠껢胤铦髨諪諬諮뷰髲蛴菶꣸軺铼鳾樀圂怄缆紈䘊栌簎成爒爔爖䘘娚├✞ဠጢ", a_)))
					{
						num = (short)1111687173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EB;
				case 5:
					this.dataWideQuickTextMessageListQuickTextMessage_A8810 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_MESSAGE1, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎胐ꛒ볔듖님迚룜꟞闠껢胤铦髨諪諬諮뷰髲蛴菶꣸軺铼鳾樀圂怄缆紈䘊栌簎成爒爔爖䘘娚├✞ဠጢ", a_), global::CommonResources.AcgResources.ID_QUICKTEXTMESSAGE, 50);
					this.dataWideQuickTextMessageListQuickTextMessage_A8810.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataWideQuickTextMessageListQuickTextMessage_A8810.DataTransferOrder = 16;
					num = (short)2127036417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1227882498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_93:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1715863558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1E6:
				num = (short)490668036;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			IL_1EB:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郀뛂계꓆ꋈ駌꫎꧐꟒髖볘꣚껜뻞蛠蛢엤ꯦ胨飪駬", a_);
			base.Id = 10072;
			base.UIName = global::CommonResources.AcgResources.ID_QUICKTEXTMESSAGELIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600A987 RID: 43399 RVA: 0x009D50C4 File Offset: 0x009D32C4
		public override void PopulateReferences()
		{
			short num = (short)1766682508;
			short num2 = num;
			num = (short)1105358732;
			switch (num2 == num)
			{
			}
			num = (short)116064256;
			if (num != 0)
			{
			}
			num = (short)1152122880;
			short num3 = num;
			num = (short)1290338305;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A988 RID: 43400 RVA: 0x009D516C File Offset: 0x009D336C
		public override void DropReferences()
		{
			short num = (short)1048576112;
			short num2 = num;
			num = (short)776601712;
			switch (num2 == num)
			{
			}
			num = (short)741474305;
			if (num != 0)
			{
			}
			num = (short)1082523648;
			short num3 = num;
			num = (short)329515008;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x009D5214 File Offset: 0x009D3414
		public override void SetConstraints()
		{
			short num = (short)718340097;
			if (num != 0)
			{
			}
			num = (short)192878167;
			short num2 = num;
			num = (short)680597079;
			switch (num2 == num)
			{
			}
			num = (short)312344576;
			short num3 = num;
			num = (short)185663488;
			if (num != 0)
			{
			}
			this.dataWideQuickTextMessageListQuickTextMessage_A8810.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConIsTextLengthValid);
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x009D52D8 File Offset: 0x009D34D8
		public override void SetupDependencies()
		{
			short num = (short)2604668;
			short num2 = num;
			num = (short)1401994876;
			switch (num2 == num)
			{
			}
			num = (short)340262913;
			if (num != 0)
			{
			}
			num = (short)1225719808;
			short num3 = num;
			num = (short)894500864;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700551F RID: 21791
		// (get) Token: 0x0600A98B RID: 43403 RVA: 0x009D5380 File Offset: 0x009D3580
		public bool HasDiffs
		{
			get
			{
				short num = (short)2087656121;
				short num2 = num;
				num = (short)1343429305;
				switch (num2 == num)
				{
				}
				num = (short)254935041;
				if (num != 0)
				{
				}
				num = (short)1981349888;
				short num3 = num;
				num = (short)1879244800;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005520 RID: 21792
		// (get) Token: 0x0600A98C RID: 43404 RVA: 0x009D5430 File Offset: 0x009D3630
		// (set) Token: 0x0600A98D RID: 43405 RVA: 0x009D54E4 File Offset: 0x009D36E4
		public string DataWideQuickTextMessageListQuickTextMessage_A8810Value
		{
			get
			{
				short num = (short)1827212046;
				short num2 = num;
				num = (short)1844251406;
				switch (num2 == num)
				{
				}
				num = (short)1778319361;
				if (num != 0)
				{
				}
				num = (short)1110114304;
				short num3 = num;
				num = (short)847118336;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810.Value;
			}
			set
			{
				short num = (short)678947520;
				short num2 = num;
				num = (short)1469377216;
				switch (num2 == num)
				{
				}
				num = (short)331415553;
				if (num != 0)
				{
				}
				num = (short)921501696;
				short num3 = num;
				num = (short)699465728;
				if (num != 0)
				{
				}
				this.dataWideQuickTextMessageListQuickTextMessage_A8810.Value = value;
			}
		}

		// Token: 0x17005521 RID: 21793
		// (get) Token: 0x0600A98E RID: 43406 RVA: 0x009D5598 File Offset: 0x009D3798
		public global::AcpBusinessLayer.AcpField<string> DataWideQuickTextMessageListQuickTextMessage_A8810
		{
			get
			{
				short num = (short)754137498;
				short num2 = num;
				num = (short)251345306;
				switch (num2 == num)
				{
				}
				num = (short)1310261249;
				if (num != 0)
				{
				}
				num = (short)2053177344;
				short num3 = num;
				num = (short)1271922688;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810;
			}
		}

		// Token: 0x17005522 RID: 21794
		// (get) Token: 0x0600A98F RID: 43407 RVA: 0x009D5648 File Offset: 0x009D3848
		// (set) Token: 0x0600A990 RID: 43408 RVA: 0x009D56FC File Offset: 0x009D38FC
		public string DataWideQuickTextMessageListQuickTextMessage_A8810_UIValue
		{
			get
			{
				short num = (short)592718946;
				short num2 = num;
				num = (short)186723426;
				switch (num2 == num)
				{
				}
				num = (short)1369767937;
				if (num != 0)
				{
				}
				num = (short)830078976;
				short num3 = num;
				num = (short)1857093632;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810.Value;
			}
			set
			{
				short num = (short)1273445383;
				short num2 = num;
				num = (short)521354247;
				switch (num2 == num)
				{
				}
				num = (short)1250492416;
				if (num != 0)
				{
				}
				num = (short)23068672;
				short num3 = num;
				num = (short)350224385;
				if (num != 0)
				{
				}
				this.dataWideQuickTextMessageListQuickTextMessage_A8810.Value = value;
			}
		}

		// Token: 0x17005523 RID: 21795
		// (get) Token: 0x0600A991 RID: 43409 RVA: 0x009D57B0 File Offset: 0x009D39B0
		// (set) Token: 0x0600A992 RID: 43410 RVA: 0x009D5868 File Offset: 0x009D3A68
		public bool DataWideQuickTextMessageListQuickTextMessage_A8810_Applicable
		{
			get
			{
				short num = (short)1091568011;
				short num2 = num;
				num = (short)672530827;
				switch (num2 == num)
				{
				}
				num = (short)2111569920;
				if (num != 0)
				{
				}
				num = (short)111607808;
				short num3 = num;
				num = (short)1191706625;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810.Applicable;
			}
			set
			{
				short num = (short)881778306;
				short num2 = num;
				num = (short)1561124482;
				switch (num2 == num)
				{
				}
				num = (short)493289473;
				if (num != 0)
				{
				}
				num = (short)517144576;
				short num3 = num;
				num = (short)86245376;
				if (num != 0)
				{
				}
				this.dataWideQuickTextMessageListQuickTextMessage_A8810.Applicable = value;
			}
		}

		// Token: 0x17005524 RID: 21796
		// (get) Token: 0x0600A993 RID: 43411 RVA: 0x009D591C File Offset: 0x009D3B1C
		// (set) Token: 0x0600A994 RID: 43412 RVA: 0x009D59D0 File Offset: 0x009D3BD0
		public bool DataWideQuickTextMessageListQuickTextMessage_A8810_Valid
		{
			get
			{
				short num = (short)475368276;
				short num2 = num;
				num = (short)1854049108;
				switch (num2 == num)
				{
				}
				num = (short)132907008;
				if (num != 0)
				{
				}
				num = (short)1363804160;
				short num3 = num;
				num = (short)1546649601;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810.Valid;
			}
			set
			{
				short num = (short)2096911630;
				short num2 = num;
				num = (short)338318606;
				switch (num2 == num)
				{
				}
				num = (short)2032205824;
				if (num != 0)
				{
				}
				num = (short)817758208;
				short num3 = num;
				num = (short)225640449;
				if (num != 0)
				{
				}
				this.dataWideQuickTextMessageListQuickTextMessage_A8810.Valid = value;
			}
		}

		// Token: 0x17005525 RID: 21797
		// (get) Token: 0x0600A995 RID: 43413 RVA: 0x009D5A88 File Offset: 0x009D3C88
		// (set) Token: 0x0600A996 RID: 43414 RVA: 0x009D5B40 File Offset: 0x009D3D40
		public bool DataWideQuickTextMessageListQuickTextMessage_A8810_Visible
		{
			get
			{
				short num = (short)2080636929;
				if (num != 0)
				{
				}
				num = (short)2141948765;
				short num2 = num;
				num = (short)908757853;
				switch (num2 == num)
				{
				}
				num = (short)671285248;
				short num3 = num;
				num = (short)1077477376;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810.Visible;
			}
			set
			{
				short num = (short)1785978158;
				short num2 = num;
				num = (short)1026809134;
				switch (num2 == num)
				{
				}
				num = (short)1880227841;
				if (num != 0)
				{
				}
				num = (short)1313538048;
				short num3 = num;
				num = (short)155910144;
				if (num != 0)
				{
				}
				this.dataWideQuickTextMessageListQuickTextMessage_A8810.Visible = value;
			}
		}

		// Token: 0x17005526 RID: 21798
		// (get) Token: 0x0600A997 RID: 43415 RVA: 0x009D5BF8 File Offset: 0x009D3DF8
		// (set) Token: 0x0600A998 RID: 43416 RVA: 0x009D5CAC File Offset: 0x009D3EAC
		public bool DataWideQuickTextMessageListQuickTextMessage_A8810_Editable
		{
			get
			{
				short num = (short)1096260589;
				short num2 = num;
				num = (short)1211145197;
				switch (num2 == num)
				{
				}
				num = (short)562167808;
				if (num != 0)
				{
				}
				num = (short)441450496;
				short num3 = num;
				num = (short)81657857;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810.Editable;
			}
			set
			{
				short num = (short)928846517;
				short num2 = num;
				num = (short)3936949;
				switch (num2 == num)
				{
				}
				num = (short)204013569;
				if (num != 0)
				{
				}
				num = (short)1026424832;
				short num3 = num;
				num = (short)1319370752;
				if (num != 0)
				{
				}
				this.dataWideQuickTextMessageListQuickTextMessage_A8810.Editable = value;
			}
		}

		// Token: 0x17005527 RID: 21799
		// (get) Token: 0x0600A999 RID: 43417 RVA: 0x009D5D60 File Offset: 0x009D3F60
		internal string DataWideQuickTextMessageListQuickTextMessage_A8810_UILabel
		{
			get
			{
				short num = (short)211904350;
				short num2 = num;
				num = (short)1306027870;
				switch (num2 == num)
				{
				}
				num = (short)92340224;
				if (num != 0)
				{
				}
				num = (short)1557528576;
				short num3 = num;
				num = (short)1225785345;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810.UIName;
			}
		}

		// Token: 0x17005528 RID: 21800
		// (get) Token: 0x0600A99A RID: 43418 RVA: 0x009D5E14 File Offset: 0x009D4014
		// (set) Token: 0x0600A99B RID: 43419 RVA: 0x009D5EC8 File Offset: 0x009D40C8
		internal bool DataWideQuickTextMessageListQuickTextMessage_A8810_HiddenStatic
		{
			get
			{
				short num = (short)1040605690;
				short num2 = num;
				num = (short)940990970;
				switch (num2 == num)
				{
				}
				num = (short)1934360577;
				if (num != 0)
				{
				}
				num = (short)1816002560;
				short num3 = num;
				num = (short)2102657024;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810.HiddenStatic;
			}
			set
			{
				short num = (short)790865306;
				short num2 = num;
				num = (short)903194010;
				switch (num2 == num)
				{
				}
				num = (short)1906573312;
				if (num != 0)
				{
				}
				num = (short)1402798080;
				short num3 = num;
				num = (short)430768129;
				if (num != 0)
				{
				}
				this.dataWideQuickTextMessageListQuickTextMessage_A8810.HiddenStatic = value;
			}
		}

		// Token: 0x17005529 RID: 21801
		// (get) Token: 0x0600A99C RID: 43420 RVA: 0x009D5F7C File Offset: 0x009D417C
		// (set) Token: 0x0600A99D RID: 43421 RVA: 0x009D6034 File Offset: 0x009D4234
		internal bool DataWideQuickTextMessageListQuickTextMessage_A8810_HiddenDynamic
		{
			get
			{
				short num = (short)535101441;
				if (num != 0)
				{
				}
				num = (short)1958710365;
				short num2 = num;
				num = (short)1283820637;
				switch (num2 == num)
				{
				}
				num = (short)1260847104;
				short num3 = num;
				num = (short)561643520;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810.HiddenDynamic;
			}
			set
			{
				short num = (short)1159370900;
				short num2 = num;
				num = (short)869636244;
				switch (num2 == num)
				{
				}
				num = (short)366084097;
				if (num != 0)
				{
				}
				num = (short)1326776320;
				short num3 = num;
				num = (short)1197932544;
				if (num != 0)
				{
				}
				this.dataWideQuickTextMessageListQuickTextMessage_A8810.HiddenDynamic = value;
			}
		}

		// Token: 0x1700552A RID: 21802
		// (get) Token: 0x0600A99E RID: 43422 RVA: 0x009D60EC File Offset: 0x009D42EC
		public bool DataWideQuickTextMessageListQuickTextMessage_A8810_HasDiffs
		{
			get
			{
				short num = (short)1742305449;
				short num2 = num;
				num = (short)1975351465;
				switch (num2 == num)
				{
				}
				num = (short)383385600;
				if (num != 0)
				{
				}
				num = (short)1317601280;
				short num3 = num;
				num = (short)24117249;
				if (num != 0)
				{
				}
				return this.dataWideQuickTextMessageListQuickTextMessage_A8810._HasDiffs;
			}
		}

		// Token: 0x0600A99F RID: 43423 RVA: 0x009D61A4 File Offset: 0x009D43A4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)587988992;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
				{
					num = (short)1275017451;
					short num4 = num;
					num = (short)1952987371;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)1566638080;
						if (num != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1199767554;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)59375620;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1169686531;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				case 4:
					num = (short)355139584;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4E;
			}
			return result;
			IL_4E:
			num = (short)1158873089;
			if (num != 0)
			{
			}
			result = null;
			num = (short)1707474945;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x0400514A RID: 20810
		private global::AcpBusinessLayer.AcpField<string> dataWideQuickTextMessageListQuickTextMessage_A8810;
	}
}
