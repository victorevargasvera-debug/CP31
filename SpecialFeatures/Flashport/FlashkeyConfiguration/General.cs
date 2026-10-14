using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
	// Token: 0x0200010D RID: 269
	public sealed class General : global::SpecialFeatures.Flashport.FeatureSection
	{
		// Token: 0x06000EA7 RID: 3751 RVA: 0x00003345 File Offset: 0x00001545
		internal General(global::SpecialFeatures.Flashport.FeatureNode parent) : base(parent)
		{
			this.Init();
			this.a();
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00149C54 File Offset: 0x00147E54
		private void a()
		{
			int a_ = 17;
			short num = (short)2079175657;
			short num2 = num;
			num = (short)804959209;
			switch (num2 == num)
			{
			default:
			{
				num = (short)154271744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)140771329;
			if (num != 0)
			{
			}
			num = (short)1397424128;
			if (num != 0)
			{
			}
			this.a.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꒓ꚕꢗꪙ놛꺝邟銡钣讥颧骩鲫麭肯", a_);
			this.b.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첓캕삗슙쒛욝瑱ﲣﺥ", a_);
			this.c.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첓캕삗슙쒛욝瑱ﲣﺥ", a_);
			this.d.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꒓ꚕꢗꪙ겛꺝趟銡钣隥颧骩鲫莭肯", a_);
			this.e.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꒓ꚕꢗꪙ겛꺝趟銡钣隥颧骩鲫莭肯", a_);
			this.f.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꒓", a_);
			this.g.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꒓", a_);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00149DB8 File Offset: 0x00147FB8
		public override void Init()
		{
			int a_ = 15;
			short num = (short)536710862;
			short num2 = num;
			num = (short)158043854;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1176436736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)451411969;
			if (num != 0)
			{
			}
			num = (short)1822556160;
			if (num != 0)
			{
			}
			this.a = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.Factory_Order_Number, true);
			this.b = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.Model_Number, true);
			this.c = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.New_Model_Number, true);
			this.d = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.Current_FLASHcode, true);
			this.e = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.New_FLASHcode, true);
			this.f = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.Upgrades_Purchased, true);
			this.g = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.Upgrades_Remaining, true);
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햑ﶗﶛ", a_);
			base.Id = 5;
			base.UIName = global::CommonResources.AppResources.General_Id;
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x00149F08 File Offset: 0x00148108
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x00149FB8 File Offset: 0x001481B8
		public string FkeyConfigFactoryOrderNumberValue
		{
			get
			{
				short num = (short)131094724;
				short num2 = num;
				num = (short)2138986692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1882914816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1735065601;
				if (num != 0)
				{
				}
				num = (short)1339752448;
				if (num != 0)
				{
				}
				return this.a.Value;
			}
			set
			{
				short num = (short)527071588;
				short num2 = num;
				num = (short)300710244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)318111744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1137311745;
				if (num != 0)
				{
				}
				num = (short)990904320;
				if (num != 0)
				{
				}
				this.a.Value = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0014A074 File Offset: 0x00148274
		public global::SpecialFeatures.Flashport.Field FkeyConfigFactoryOrderNumber
		{
			get
			{
				short num = (short)2130972015;
				short num2 = num;
				num = (short)190582127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)336789504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)258211840;
				if (num != 0)
				{
				}
				num = (short)1486880769;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0014A124 File Offset: 0x00148324
		public bool FkeyConfigFactoryOrderNumber_Applicable
		{
			get
			{
				short num = (short)2112286423;
				short num2 = num;
				num = (short)592965335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)91553792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)775618561;
				if (num != 0)
				{
				}
				num = (short)1858469888;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0014A1D0 File Offset: 0x001483D0
		public bool FkeyConfigFactoryOrderNumber_Valid
		{
			get
			{
				short num = (short)547552697;
				short num2 = num;
				num = (short)166067641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)486277120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1112014849;
				if (num != 0)
				{
				}
				num = (short)914882560;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0014A27C File Offset: 0x0014847C
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x0014A330 File Offset: 0x00148530
		public bool FkeyConfigFactoryOrderNumber_Visible
		{
			get
			{
				short num = (short)2107653980;
				short num2 = num;
				num = (short)1775255388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536360448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1442381825;
				if (num != 0)
				{
				}
				num = (short)476184576;
				if (num != 0)
				{
				}
				return this.a.Visible;
			}
			set
			{
				short num = (short)1175715841;
				if (num != 0)
				{
				}
				num = (short)525991936;
				short num2 = num;
				num = (short)1095111289;
				short num3 = num;
				num = (short)1187975801;
				switch (num3 == num)
				{
				}
				num = (short)131137536;
				if (num != 0)
				{
				}
				this.a.Visible = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0014A3E4 File Offset: 0x001485E4
		public bool FkeyConfigFactoryOrderNumber_Editable
		{
			get
			{
				short num = (short)136178205;
				short num2 = num;
				num = (short)2065689117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)956760064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1322057728;
				if (num != 0)
				{
				}
				num = (short)1206386689;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0014A490 File Offset: 0x00148690
		public string FkeyConfigFactoryOrderNumber_UILabel
		{
			get
			{
				short num = (short)2125660161;
				if (num != 0)
				{
				}
				num = (short)846397440;
				short num2 = num;
				num = (short)1473588698;
				short num3 = num;
				num = (short)1849961946;
				switch (num3 == num)
				{
				}
				num = (short)1660354560;
				if (num != 0)
				{
				}
				return this.a.UIName;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0014A544 File Offset: 0x00148744
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x0014A5F8 File Offset: 0x001487F8
		public string FkeyConfigCurrentModelNumberValue
		{
			get
			{
				short num = (short)860880897;
				if (num != 0)
				{
				}
				num = (short)1564606464;
				short num2 = num;
				num = (short)1186704982;
				short num3 = num;
				num = (short)119909974;
				switch (num3 == num)
				{
				}
				num = (short)412811264;
				if (num != 0)
				{
				}
				return this.b.Value;
			}
			set
			{
				short num = (short)1095859337;
				short num2 = num;
				num = (short)200768649;
				switch (num2 == num)
				{
				default:
				{
					num = (short)811728896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1299316736;
				if (num != 0)
				{
				}
				num = (short)1089011713;
				if (num != 0)
				{
				}
				this.b.Value = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0014A6B0 File Offset: 0x001488B0
		public global::SpecialFeatures.Flashport.Field FkeyConfigCurrentModelNumber
		{
			get
			{
				short num = (short)437016797;
				short num2 = num;
				num = (short)1174624477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1959460864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)835452928;
				if (num != 0)
				{
				}
				num = (short)1979711489;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0014A760 File Offset: 0x00148960
		public bool FkeyConfigCurrentModelNumber_Applicable
		{
			get
			{
				short num = (short)347606359;
				short num2 = num;
				num = (short)381685079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)145031168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)679804929;
				if (num != 0)
				{
				}
				num = (short)1214316544;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0014A80C File Offset: 0x00148A0C
		public bool FkeyConfigCurrentModelNumber_Valid
		{
			get
			{
				short num = (short)2018246657;
				if (num != 0)
				{
				}
				num = (short)506789888;
				short num2 = num;
				num = (short)440768417;
				short num3 = num;
				num = (short)653498273;
				switch (num3 == num)
				{
				}
				num = (short)2129788928;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0014A8B8 File Offset: 0x00148AB8
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x0014A96C File Offset: 0x00148B6C
		public bool FkeyConfigCurrentModelNumber_Visible
		{
			get
			{
				short num = (short)148567846;
				short num2 = num;
				num = (short)817035046;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2027290624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1606680576;
				if (num != 0)
				{
				}
				num = (short)1872232449;
				if (num != 0)
				{
				}
				return this.b.Visible;
			}
			set
			{
				short num = (short)1965694964;
				short num2 = num;
				num = (short)719658996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)345571328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1751777280;
				if (num != 0)
				{
				}
				num = (short)120455169;
				if (num != 0)
				{
				}
				this.b.Visible = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0014AA20 File Offset: 0x00148C20
		public bool FkeyConfigCurrentModelNumber_Editable
		{
			get
			{
				short num = (short)384696321;
				if (num != 0)
				{
				}
				num = (short)1481768960;
				short num2 = num;
				num = (short)700787943;
				short num3 = num;
				num = (short)856960231;
				switch (num3 == num)
				{
				}
				num = (short)755957760;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0014AACC File Offset: 0x00148CCC
		public string FkeyConfigCurrentModelNumber_UILabel
		{
			get
			{
				short num = (short)324819913;
				short num2 = num;
				num = (short)362240969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1472135168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1291059201;
				if (num != 0)
				{
				}
				num = (short)561250304;
				if (num != 0)
				{
				}
				return this.b.UIName;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0014AB84 File Offset: 0x00148D84
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x0014AC38 File Offset: 0x00148E38
		public string FkeyConfigNewModelNumberValue
		{
			get
			{
				short num = (short)428602466;
				short num2 = num;
				num = (short)1729229922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1792278528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1442447360;
				if (num != 0)
				{
				}
				num = (short)933232641;
				if (num != 0)
				{
				}
				return this.c.Value;
			}
			set
			{
				short num = (short)921965421;
				short num2 = num;
				num = (short)1559630701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)150142976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1950154752;
				if (num != 0)
				{
				}
				num = (short)1980760065;
				if (num != 0)
				{
				}
				this.c.Value = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0014ACEC File Offset: 0x00148EEC
		public global::SpecialFeatures.Flashport.Field FkeyConfigNewModelNumber
		{
			get
			{
				short num = (short)277897511;
				short num2 = num;
				num = (short)1777295655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1550254080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)593690625;
				if (num != 0)
				{
				}
				num = (short)624885760;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0014AD9C File Offset: 0x00148F9C
		public bool FkeyConfigNewModelNumber_Applicable
		{
			get
			{
				short num = (short)237681479;
				short num2 = num;
				num = (short)1999223623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)81985536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)234029057;
				if (num != 0)
				{
				}
				num = (short)1790115840;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0014AE44 File Offset: 0x00149044
		public bool FkeyConfigNewModelNumber_Valid
		{
			get
			{
				short num = (short)1469044893;
				short num2 = num;
				num = (short)368040093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1695744000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)307691521;
				if (num != 0)
				{
				}
				num = (short)1580007424;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0014AEEC File Offset: 0x001490EC
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x0014AFA0 File Offset: 0x001491A0
		public bool FkeyConfigNewModelNumber_Visible
		{
			get
			{
				short num = (short)1959827557;
				short num2 = num;
				num = (short)264345701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1979383808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1812856832;
				if (num != 0)
				{
				}
				num = (short)966852609;
				if (num != 0)
				{
				}
				return this.c.Visible;
			}
			set
			{
				short num = (short)586238046;
				short num2 = num;
				num = (short)1339181150;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1565720576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)478478337;
				if (num != 0)
				{
				}
				num = (short)918880256;
				if (num != 0)
				{
				}
				this.c.Visible = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0014B05C File Offset: 0x0014925C
		public bool FkeyConfigNewModelNumber_Editable
		{
			get
			{
				short num = (short)279773185;
				if (num != 0)
				{
				}
				num = (short)932642816;
				short num2 = num;
				num = (short)25731134;
				short num3 = num;
				num = (short)1892720702;
				switch (num3 == num)
				{
				}
				num = (short)1274347520;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0014B104 File Offset: 0x00149304
		public string FkeyConfigNewModelNumber_UILabel
		{
			get
			{
				short num = (short)1396392615;
				short num2 = num;
				num = (short)2116502183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)851771392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)955777024;
				if (num != 0)
				{
				}
				num = (short)357957633;
				if (num != 0)
				{
				}
				return this.c.UIName;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0014B1B4 File Offset: 0x001493B4
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x0014B268 File Offset: 0x00149468
		public string FkeyConfigCurrentFlashcodeValue
		{
			get
			{
				short num = (short)1677416343;
				short num2 = num;
				num = (short)1480611735;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1331232768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1184825344;
				if (num != 0)
				{
				}
				num = (short)1549729793;
				if (num != 0)
				{
				}
				return this.d.Value;
			}
			set
			{
				short num = (short)1693432637;
				short num2 = num;
				num = (short)1288485693;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2126643200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)434503680;
				if (num != 0)
				{
				}
				num = (short)1405091841;
				if (num != 0)
				{
				}
				this.d.Value = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0014B320 File Offset: 0x00149520
		public global::SpecialFeatures.Flashport.Field FkeyConfigCurrentFlashcode
		{
			get
			{
				short num = (short)2023777864;
				short num2 = num;
				num = (short)1853908552;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1306198016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1353973761;
				if (num != 0)
				{
				}
				num = (short)397082624;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0014B3D0 File Offset: 0x001495D0
		public bool FkeyConfigCurrentFlashcode_Applicable
		{
			get
			{
				short num = (short)1317794913;
				short num2 = num;
				num = (short)484373601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2068250624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)123273217;
				if (num != 0)
				{
				}
				num = (short)1561395200;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0014B478 File Offset: 0x00149678
		public bool FkeyConfigCurrentFlashcode_Valid
		{
			get
			{
				short num = (short)1992409110;
				short num2 = num;
				num = (short)1125367830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1403715584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)691077120;
				if (num != 0)
				{
				}
				num = (short)1664679937;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0014B524 File Offset: 0x00149724
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x0014B5DC File Offset: 0x001497DC
		public bool FkeyConfigCurrentFlashcode_Visible
		{
			get
			{
				short num = (short)2075302036;
				short num2 = num;
				num = (short)130324628;
				switch (num2 == num)
				{
				default:
				{
					num = (short)162398208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1266155521;
				if (num != 0)
				{
				}
				num = (short)2060845056;
				if (num != 0)
				{
				}
				return this.d.Visible;
			}
			set
			{
				short num = (short)1683654914;
				short num2 = num;
				num = (short)1687193858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1731395584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1940848641;
				if (num != 0)
				{
				}
				num = (short)4653056;
				if (num != 0)
				{
				}
				this.d.Visible = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0014B694 File Offset: 0x00149894
		public bool FkeyConfigCurrentFlashcode_Editable
		{
			get
			{
				short num = (short)96010241;
				if (num != 0)
				{
				}
				num = (short)1564147712;
				short num2 = num;
				num = (short)690180145;
				short num3 = num;
				num = (short)2130268209;
				switch (num3 == num)
				{
				}
				num = (short)837943296;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0014B73C File Offset: 0x0014993C
		public string FkeyConfigCurrentFlashcode_UILabel
		{
			get
			{
				short num = (short)1693515777;
				if (num != 0)
				{
				}
				num = (short)1224605696;
				short num2 = num;
				num = (short)605527559;
				short num3 = num;
				num = (short)1150721543;
				switch (num3 == num)
				{
				}
				num = (short)1960902656;
				if (num != 0)
				{
				}
				return this.d.UIName;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0014B7F4 File Offset: 0x001499F4
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x0014B8AC File Offset: 0x00149AAC
		public string FkeyConfigNewFlashcodeValue
		{
			get
			{
				short num = (short)349855172;
				short num2 = num;
				num = (short)502095300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)133890048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)849084416;
				if (num != 0)
				{
				}
				num = (short)1157627905;
				if (num != 0)
				{
				}
				return this.e.Value;
			}
			set
			{
				short num = (short)1346302413;
				short num2 = num;
				num = (short)642970061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)161218560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)547291136;
				if (num != 0)
				{
				}
				num = (short)1951989761;
				if (num != 0)
				{
				}
				this.e.Value = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0014B960 File Offset: 0x00149B60
		public global::SpecialFeatures.Flashport.Field FkeyConfigNewFlashcode
		{
			get
			{
				short num = (short)865751686;
				short num2 = num;
				num = (short)2107396742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1192427520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1800536065;
				if (num != 0)
				{
				}
				num = (short)324861952;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0014BA10 File Offset: 0x00149C10
		public bool FkeyConfigNewFlashcode_Applicable
		{
			get
			{
				short num = (short)639598397;
				short num2 = num;
				num = (short)511344445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1336737792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1188954113;
				if (num != 0)
				{
				}
				num = (short)1904934912;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0014BAB8 File Offset: 0x00149CB8
		public bool FkeyConfigNewFlashcode_Valid
		{
			get
			{
				short num = (short)388802174;
				short num2 = num;
				num = (short)1356637822;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1100808192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)314310657;
				if (num != 0)
				{
				}
				num = (short)1734344704;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0014BB64 File Offset: 0x00149D64
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x0014BC18 File Offset: 0x00149E18
		public bool FkeyConfigNewFlashcode_Visible
		{
			get
			{
				short num = (short)987424904;
				short num2 = num;
				num = (short)197912712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1326055424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1159593984;
				if (num != 0)
				{
				}
				num = (short)1048576001;
				if (num != 0)
				{
				}
				return this.e.Visible;
			}
			set
			{
				short num = (short)1813512141;
				short num2 = num;
				num = (short)1591869389;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1600126976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1669267457;
				if (num != 0)
				{
				}
				num = (short)392888320;
				if (num != 0)
				{
				}
				this.e.Visible = value;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0014BCCC File Offset: 0x00149ECC
		public bool FkeyConfigNewFlashcode_Editable
		{
			get
			{
				short num = (short)1382051506;
				short num2 = num;
				num = (short)1507159730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1218641920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1831337985;
				if (num != 0)
				{
				}
				num = (short)107151360;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0014BD78 File Offset: 0x00149F78
		public string FkeyConfigNewFlashcode_UILabel
		{
			get
			{
				short num = (short)1904368406;
				short num2 = num;
				num = (short)836393750;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660026880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)575471616;
				if (num != 0)
				{
				}
				num = (short)2008678401;
				if (num != 0)
				{
				}
				return this.e.UIName;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x0014BE2C File Offset: 0x0014A02C
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x0014BEE4 File Offset: 0x0014A0E4
		public string FkeyConfigUpgradesPurchasedValue
		{
			get
			{
				short num = (short)315031553;
				if (num != 0)
				{
				}
				num = (short)1416096494;
				short num2 = num;
				num = (short)2105797358;
				switch (num2 == num)
				{
				}
				num = (short)1167458304;
				short num3 = num;
				num = (short)1558773760;
				if (num != 0)
				{
				}
				return this.f.Value;
			}
			set
			{
				short num = (short)1621346669;
				short num2 = num;
				num = (short)441174381;
				switch (num2 == num)
				{
				}
				num = (short)250216448;
				if (num != 0)
				{
				}
				num = (short)384565248;
				short num3 = num;
				num = (short)326369281;
				if (num != 0)
				{
				}
				this.f.Value = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0014BF98 File Offset: 0x0014A198
		public global::SpecialFeatures.Flashport.Field FkeyConfigUpgradesPurchased
		{
			get
			{
				short num = (short)87594071;
				short num2 = num;
				num = (short)713331799;
				switch (num2 == num)
				{
				}
				num = (short)767164416;
				if (num != 0)
				{
				}
				num = (short)677183488;
				short num3 = num;
				num = (short)1174077441;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x0014C048 File Offset: 0x0014A248
		public bool FkeyConfigUpgradesPurchased_Applicable
		{
			get
			{
				short num = (short)1602280336;
				short num2 = num;
				num = (short)2039798672;
				switch (num2 == num)
				{
				}
				num = (short)100990977;
				if (num != 0)
				{
				}
				num = (short)21299200;
				short num3 = num;
				num = (short)1231618048;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0014C0F4 File Offset: 0x0014A2F4
		public bool FkeyConfigUpgradesPurchased_Valid
		{
			get
			{
				short num = (short)319302448;
				short num2 = num;
				num = (short)479472432;
				switch (num2 == num)
				{
				}
				num = (short)758251520;
				if (num != 0)
				{
				}
				num = (short)571801600;
				short num3 = num;
				num = (short)125960193;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0014C1A0 File Offset: 0x0014A3A0
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x0014C258 File Offset: 0x0014A458
		public bool FkeyConfigUpgradesPurchased_Visible
		{
			get
			{
				short num = (short)490031912;
				short num2 = num;
				num = (short)1182223144;
				switch (num2 == num)
				{
				}
				num = (short)925892609;
				if (num != 0)
				{
				}
				num = (short)965476352;
				short num3 = num;
				num = (short)727384064;
				if (num != 0)
				{
				}
				return this.f.Visible;
			}
			set
			{
				short num = (short)945242774;
				short num2 = num;
				num = (short)1296974486;
				switch (num2 == num)
				{
				}
				num = (short)2000027649;
				if (num != 0)
				{
				}
				num = (short)2075066368;
				short num3 = num;
				num = (short)1930166272;
				if (num != 0)
				{
				}
				this.f.Visible = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x0014C30C File Offset: 0x0014A50C
		public bool FkeyConfigUpgradesPurchased_Editable
		{
			get
			{
				short num = (short)542678152;
				short num2 = num;
				num = (short)1736940680;
				switch (num2 == num)
				{
				}
				num = (short)546570241;
				if (num != 0)
				{
				}
				num = (short)672464896;
				short num3 = num;
				num = (short)1272053760;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0014C3B8 File Offset: 0x0014A5B8
		public string FkeyConfigUpgradesPurchased_UILabel
		{
			get
			{
				short num = (short)1903468667;
				short num2 = num;
				num = (short)1454678139;
				switch (num2 == num)
				{
				}
				num = (short)913440769;
				if (num != 0)
				{
				}
				num = (short)187891712;
				short num3 = num;
				num = (short)427950080;
				if (num != 0)
				{
				}
				return this.f.UIName;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0014C46C File Offset: 0x0014A66C
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x0014C524 File Offset: 0x0014A724
		public string FkeyConfigUpgradesRemainingValue
		{
			get
			{
				short num = (short)2136997889;
				if (num != 0)
				{
				}
				num = (short)1190931879;
				short num2 = num;
				num = (short)1059663271;
				switch (num2 == num)
				{
				}
				num = (short)426901504;
				short num3 = num;
				num = (short)285212672;
				if (num != 0)
				{
				}
				return this.g.Value;
			}
			set
			{
				short num = (short)1759944061;
				short num2 = num;
				num = (short)294231421;
				switch (num2 == num)
				{
				}
				num = (short)299040769;
				if (num != 0)
				{
				}
				num = (short)294912000;
				short num3 = num;
				num = (short)1159004160;
				if (num != 0)
				{
				}
				this.g.Value = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0014C5DC File Offset: 0x0014A7DC
		public global::SpecialFeatures.Flashport.Field FkeyConfigUpgradesRemaining
		{
			get
			{
				short num = (short)1423220935;
				short num2 = num;
				num = (short)221225159;
				switch (num2 == num)
				{
				}
				num = (short)1646788609;
				if (num != 0)
				{
				}
				num = (short)508166144;
				short num3 = num;
				num = (short)1878458368;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x0014C688 File Offset: 0x0014A888
		public bool FkeyConfigUpgradesRemaining_Applicable
		{
			get
			{
				short num = (short)1615426826;
				short num2 = num;
				num = (short)638612746;
				switch (num2 == num)
				{
				}
				num = (short)2074869760;
				if (num != 0)
				{
				}
				num = (short)1197801472;
				short num3 = num;
				num = (short)373817345;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0014C734 File Offset: 0x0014A934
		public bool FkeyConfigUpgradesRemaining_Valid
		{
			get
			{
				short num = (short)219784825;
				short num2 = num;
				num = (short)1404413561;
				switch (num2 == num)
				{
				}
				num = (short)1225392128;
				if (num != 0)
				{
				}
				num = (short)88408064;
				short num3 = num;
				num = (short)1136525313;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0014C7E0 File Offset: 0x0014A9E0
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x0014C894 File Offset: 0x0014AA94
		public bool FkeyConfigUpgradesRemaining_Visible
		{
			get
			{
				short num = (short)1394105722;
				short num2 = num;
				num = (short)1540709754;
				switch (num2 == num)
				{
				}
				num = (short)381550593;
				if (num != 0)
				{
				}
				num = (short)1473183744;
				short num3 = num;
				num = (short)935460864;
				if (num != 0)
				{
				}
				return this.g.Visible;
			}
			set
			{
				short num = (short)899087541;
				short num2 = num;
				num = (short)917634229;
				switch (num2 == num)
				{
				}
				num = (short)765067265;
				if (num != 0)
				{
				}
				num = (short)346882048;
				short num3 = num;
				num = (short)1465974784;
				if (num != 0)
				{
				}
				this.g.Visible = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0014C948 File Offset: 0x0014AB48
		public bool FkeyConfigUpgradesRemaining_Editable
		{
			get
			{
				short num = (short)761707233;
				short num2 = num;
				num = (short)934722273;
				switch (num2 == num)
				{
				}
				num = (short)886112257;
				if (num != 0)
				{
				}
				num = (short)1756626944;
				short num3 = num;
				num = (short)705757184;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0014C9F4 File Offset: 0x0014ABF4
		public string FkeyConfigUpgradesRemaining_UILabel
		{
			get
			{
				short num = (short)547040991;
				short num2 = num;
				num = (short)1599680223;
				switch (num2 == num)
				{
				}
				num = (short)7667712;
				if (num != 0)
				{
				}
				num = (short)265486336;
				short num3 = num;
				num = (short)650641409;
				if (num != 0)
				{
				}
				return this.g.UIName;
			}
		}

		// Token: 0x040007C5 RID: 1989
		private global::SpecialFeatures.Flashport.Field a;

		// Token: 0x040007C6 RID: 1990
		private global::SpecialFeatures.Flashport.Field b;

		// Token: 0x040007C7 RID: 1991
		private global::SpecialFeatures.Flashport.Field c;

		// Token: 0x040007C8 RID: 1992
		private global::SpecialFeatures.Flashport.Field d;

		// Token: 0x040007C9 RID: 1993
		private global::SpecialFeatures.Flashport.Field e;

		// Token: 0x040007CA RID: 1994
		private global::SpecialFeatures.Flashport.Field f;

		// Token: 0x040007CB RID: 1995
		private global::SpecialFeatures.Flashport.Field g;
	}
}
