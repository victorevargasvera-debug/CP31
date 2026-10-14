using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
	// Token: 0x0200010A RID: 266
	public sealed partial class FlashkeyConfigurationFeaturesInnerSection : FeatureSection
	{
		// Token: 0x06000E81 RID: 3713 RVA: 0x0000331D File Offset: 0x0000151D
		internal FlashkeyConfigurationFeaturesInnerSection(FeatureNode parent) : base(parent)
		{
			this.Init();
			this.a();
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x001481AC File Offset: 0x001463AC
		private void a()
		{
			short num = (short)59179008;
			short num2 = num;
			num = (short)739160829;
			short num3 = num;
			num = (short)571257597;
			switch (num3 == num)
			{
			}
			num = (short)1842872320;
			if (num != 0)
			{
			}
			num = (short)714801153;
			if (num != 0)
			{
			}
			this.a.Value = AppResources.N_A;
			this.b.Value = AppResources.N_A;
			this.c.Value = AppResources.N_A;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00148288 File Offset: 0x00146488
		public override void Init()
		{
			int a_ = 16;
			short num = (short)286457856;
			short num2 = num;
			num = (short)1448528997;
			short num3 = num;
			num = (short)1572064357;
			switch (num3 == num)
			{
			}
			num = (short)1209008129;
			if (num != 0)
			{
			}
			num = (short)1205862400;
			if (num != 0)
			{
			}
			this.a = new Field(AppResources.FLASHcode_Information, true);
			this.b = new Field(AppResources.Current_Id, true);
			this.c = new Field(AppResources.New_Id, true);
			base.FeatureSectionName = RptMgrErrorHandler.b("햒\ud994횖쪘펚ﺜ얠욢薤첨쪪\ud9ac\udaae쎰횲운", a_);
			base.Id = 6;
			base.UIName = AppResources.FLASHcode_Features;
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00148394 File Offset: 0x00146594
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00148448 File Offset: 0x00146648
		public string FkeyConfigFeatureNameValue
		{
			get
			{
				short num = (short)1950810112;
				short num2 = num;
				num = (short)626209740;
				short num3 = num;
				num = (short)2060465100;
				switch (num3 == num)
				{
				}
				num = (short)1012989953;
				if (num != 0)
				{
				}
				num = (short)1450967040;
				if (num != 0)
				{
				}
				return this.a.Value;
			}
			set
			{
				short num = (short)636485632;
				short num2 = num;
				num = (short)1711341569;
				if (num != 0)
				{
				}
				num = (short)750184686;
				short num3 = num;
				num = (short)1289414894;
				switch (num3 == num)
				{
				}
				num = (short)93978624;
				if (num != 0)
				{
				}
				this.a.Value = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x001484FC File Offset: 0x001466FC
		public Field FkeyConfigFeatureName
		{
			get
			{
				short num = (short)1048379392;
				short num2 = num;
				num = (short)1783756197;
				short num3 = num;
				num = (short)773584293;
				switch (num3 == num)
				{
				}
				num = (short)157679616;
				if (num != 0)
				{
				}
				num = (short)1569914881;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x001485AC File Offset: 0x001467AC
		public bool FkeyConfigFeatureName_Applicable
		{
			get
			{
				short num = (short)577503232;
				short num2 = num;
				num = (short)135753734;
				short num3 = num;
				num = (short)1506701318;
				switch (num3 == num)
				{
				}
				num = (short)117047296;
				if (num != 0)
				{
				}
				num = (short)392232961;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00148654 File Offset: 0x00146854
		public bool FkeyConfigFeatureName_Valid
		{
			get
			{
				short num = (short)1098711040;
				short num2 = num;
				num = (short)206670889;
				short num3 = num;
				num = (short)1796967465;
				switch (num3 == num)
				{
				}
				num = (short)1721565185;
				if (num != 0)
				{
				}
				num = (short)720896000;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00148700 File Offset: 0x00146900
		// (set) Token: 0x06000E8A RID: 3722 RVA: 0x001487B0 File Offset: 0x001469B0
		public bool FkeyConfigFeatureName_Visible
		{
			get
			{
				short num = (short)1229717504;
				short num2 = num;
				num = (short)1199994627;
				short num3 = num;
				num = (short)538670851;
				switch (num3 == num)
				{
				}
				num = (short)1666842625;
				if (num != 0)
				{
				}
				num = (short)1894776832;
				if (num != 0)
				{
				}
				return this.a.Visible;
			}
			set
			{
				short num = (short)1440940032;
				short num2 = num;
				num = (short)361852576;
				short num3 = num;
				num = (short)463761056;
				switch (num3 == num)
				{
				}
				num = (short)1442840576;
				if (num != 0)
				{
				}
				num = (short)1496645633;
				if (num != 0)
				{
				}
				this.a.Visible = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x00148864 File Offset: 0x00146A64
		public bool FkeyConfigFeatureName_Editable
		{
			get
			{
				short num = (short)247005184;
				short num2 = num;
				num = (short)182200911;
				short num3 = num;
				num = (short)1999055439;
				switch (num3 == num)
				{
				}
				num = (short)889520128;
				if (num != 0)
				{
				}
				num = (short)65929217;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00148910 File Offset: 0x00146B10
		public string FkeyConfigFeatureName_UILabel
		{
			get
			{
				short num = (short)105250816;
				short num2 = num;
				num = (short)1522402914;
				short num3 = num;
				num = (short)125503074;
				switch (num3 == num)
				{
				}
				num = (short)1021575169;
				if (num != 0)
				{
				}
				num = (short)1348403200;
				if (num != 0)
				{
				}
				return this.a.UIName;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x001489C8 File Offset: 0x00146BC8
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00148A7C File Offset: 0x00146C7C
		public string FkeyConfigCurrentFlashcodeValueValue
		{
			get
			{
				short num = (short)1723072512;
				short num2 = num;
				num = (short)1554907137;
				if (num != 0)
				{
				}
				num = (short)903863896;
				short num3 = num;
				num = (short)763551320;
				switch (num3 == num)
				{
				}
				num = (short)2125856768;
				if (num != 0)
				{
				}
				return this.b.Value;
			}
			set
			{
				short num = (short)1000341504;
				short num2 = num;
				num = (short)627675841;
				short num3 = num;
				num = (short)2112721601;
				switch (num3 == num)
				{
				}
				num = (short)1418133505;
				if (num != 0)
				{
				}
				num = (short)389939200;
				if (num != 0)
				{
				}
				this.b.Value = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00148B30 File Offset: 0x00146D30
		public Field FkeyConfigCurrentFlashcodeValue
		{
			get
			{
				short num = (short)846725120;
				short num2 = num;
				num = (short)1838481409;
				if (num != 0)
				{
				}
				num = (short)1486770433;
				short num3 = num;
				num = (short)274813185;
				switch (num3 == num)
				{
				}
				num = (short)1545797632;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00148BE0 File Offset: 0x00146DE0
		public bool FkeyConfigCurrentFlashcodeValue_Applicable
		{
			get
			{
				short num = (short)246087680;
				short num2 = num;
				num = (short)331762814;
				short num3 = num;
				num = (short)459164798;
				switch (num3 == num)
				{
				}
				num = (short)1400307712;
				if (num != 0)
				{
				}
				num = (short)563281921;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x00148C8C File Offset: 0x00146E8C
		public bool FkeyConfigCurrentFlashcodeValue_Valid
		{
			get
			{
				short num = (short)1333592064;
				short num2 = num;
				num = (short)1930303441;
				short num3 = num;
				num = (short)312612817;
				switch (num3 == num)
				{
				}
				num = (short)1774321665;
				if (num != 0)
				{
				}
				num = (short)2143748096;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00148D38 File Offset: 0x00146F38
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00148DF0 File Offset: 0x00146FF0
		public bool FkeyConfigCurrentFlashcodeValue_Visible
		{
			get
			{
				short num = (short)115081216;
				short num2 = num;
				num = (short)595241206;
				short num3 = num;
				num = (short)476489974;
				switch (num3 == num)
				{
				}
				num = (short)1608843265;
				if (num != 0)
				{
				}
				num = (short)728236032;
				if (num != 0)
				{
				}
				return this.b.Visible;
			}
			set
			{
				short num = (short)462028800;
				short num2 = num;
				num = (short)353507179;
				short num3 = num;
				num = (short)1427576683;
				switch (num3 == num)
				{
				}
				num = (short)1294467073;
				if (num != 0)
				{
				}
				num = (short)1425932288;
				if (num != 0)
				{
				}
				this.b.Visible = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00148EA4 File Offset: 0x001470A4
		public bool FkeyConfigCurrentFlashcodeValue_Editable
		{
			get
			{
				short num = (short)681574400;
				short num2 = num;
				num = (short)94399284;
				short num3 = num;
				num = (short)162753332;
				switch (num3 == num)
				{
				}
				num = (short)750911488;
				if (num != 0)
				{
				}
				num = (short)251592705;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x00148F4C File Offset: 0x0014714C
		public string FkeyConfigCurrentFlashcodeValue_UILabel
		{
			get
			{
				short num = (short)850460672;
				short num2 = num;
				num = (short)59826341;
				short num3 = num;
				num = (short)718397605;
				switch (num3 == num)
				{
				}
				num = (short)2090663937;
				if (num != 0)
				{
				}
				num = (short)1532690432;
				if (num != 0)
				{
				}
				return this.b.UIName;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00149004 File Offset: 0x00147204
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x001490B8 File Offset: 0x001472B8
		public string FkeyConfigNewFlashcodeValueValue
		{
			get
			{
				short num = (short)1664614400;
				short num2 = num;
				num = (short)2104447039;
				short num3 = num;
				num = (short)456085567;
				switch (num3 == num)
				{
				}
				num = (short)1464795136;
				if (num != 0)
				{
				}
				num = (short)407109633;
				if (num != 0)
				{
				}
				return this.c.Value;
			}
			set
			{
				short num = (short)1519517696;
				short num2 = num;
				num = (short)1662189569;
				if (num != 0)
				{
				}
				num = (short)1409007258;
				short num3 = num;
				num = (short)1043381914;
				switch (num3 == num)
				{
				}
				num = (short)1834221568;
				if (num != 0)
				{
				}
				this.c.Value = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00149170 File Offset: 0x00147370
		public Field FkeyConfigNewFlashcodeValue
		{
			get
			{
				short num = (short)2114519040;
				short num2 = num;
				num = (short)1987295479;
				short num3 = num;
				num = (short)1401272567;
				switch (num3 == num)
				{
				}
				num = (short)1540423681;
				if (num != 0)
				{
				}
				num = (short)1701642240;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00149220 File Offset: 0x00147420
		public bool FkeyConfigNewFlashcodeValue_Applicable
		{
			get
			{
				short num = (short)793247744;
				short num2 = num;
				num = (short)1486017189;
				short num3 = num;
				num = (short)1404293797;
				switch (num3 == num)
				{
				}
				num = (short)2053439488;
				if (num != 0)
				{
				}
				num = (short)1685258241;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x001492CC File Offset: 0x001474CC
		public bool FkeyConfigNewFlashcodeValue_Valid
		{
			get
			{
				short num = (short)2090205184;
				short num2 = num;
				num = (short)1226583463;
				short num3 = num;
				num = (short)422849959;
				switch (num3 == num)
				{
				}
				num = (short)2001534977;
				if (num != 0)
				{
				}
				num = (short)1830944768;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x00149378 File Offset: 0x00147578
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x00149430 File Offset: 0x00147630
		public bool FkeyConfigNewFlashcodeValue_Visible
		{
			get
			{
				short num = (short)1277820928;
				short num2 = num;
				num = (short)1872698632;
				short num3 = num;
				num = (short)405085448;
				switch (num3 == num)
				{
				}
				num = (short)459866113;
				if (num != 0)
				{
				}
				num = (short)1144651776;
				if (num != 0)
				{
				}
				return this.c.Visible;
			}
			set
			{
				short num = (short)1289617408;
				short num2 = num;
				num = (short)469424032;
				short num3 = num;
				num = (short)2057164704;
				switch (num3 == num)
				{
				}
				num = (short)296943616;
				if (num != 0)
				{
				}
				num = (short)1859846145;
				if (num != 0)
				{
				}
				this.c.Visible = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x001494E4 File Offset: 0x001476E4
		public bool FkeyConfigNewFlashcodeValue_Editable
		{
			get
			{
				short num = (short)993853440;
				short num2 = num;
				num = (short)2071741387;
				short num3 = num;
				num = (short)731726795;
				switch (num3 == num)
				{
				}
				num = (short)1272643584;
				if (num != 0)
				{
				}
				num = (short)790167553;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00149590 File Offset: 0x00147790
		public string FkeyConfigNewFlashcodeValue_UILabel
		{
			get
			{
				short num = (short)1380646912;
				short num2 = num;
				num = (short)1050083329;
				if (num != 0)
				{
				}
				num = (short)348444356;
				short num3 = num;
				num = (short)1569838788;
				switch (num3 == num)
				{
				}
				num = (short)2102394880;
				if (num != 0)
				{
				}
				return this.c.UIName;
			}
		}

		// Token: 0x040007B9 RID: 1977
		private Field a;

		// Token: 0x040007BA RID: 1978
		private Field b;

		// Token: 0x040007BB RID: 1979
		private Field c;
	}
}
