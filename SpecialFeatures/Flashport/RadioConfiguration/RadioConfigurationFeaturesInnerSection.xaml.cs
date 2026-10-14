using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.RadioConfiguration
{
	// Token: 0x020000CE RID: 206
	public sealed partial class RadioConfigurationFeaturesInnerSection : FeatureSection
	{
		// Token: 0x06000CAD RID: 3245 RVA: 0x00002F3D File Offset: 0x0000113D
		internal RadioConfigurationFeaturesInnerSection(FeatureNode parent) : base(parent)
		{
			this.Init();
			this.a();
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0010611C File Offset: 0x0010431C
		private void a()
		{
			short num = (short)958324994;
			short num2 = num;
			num = (short)647028994;
			switch (num2 == num)
			{
			}
			num = (short)2047737857;
			if (num != 0)
			{
			}
			num = (short)547225600;
			if (num != 0)
			{
			}
			num = (short)1338572800;
			short num3 = num;
			this.a.Value = AppResources.N_A;
			this.b.Value = AppResources.N_A;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x001061E4 File Offset: 0x001043E4
		public override void Init()
		{
			int a_ = 13;
			short num = (short)223023564;
			short num2 = num;
			num = (short)1683821004;
			switch (num2 == num)
			{
			}
			num = (short)1246232577;
			if (num != 0)
			{
			}
			num = (short)1530527744;
			if (num != 0)
			{
			}
			num = (short)2118123520;
			short num3 = num;
			this.a = new Field(AppResources.FLASHcode_Information, true);
			this.b = new Field(AppResources.Current_Id, true);
			base.FeatureSectionName = RptMgrErrorHandler.b("횏\ude91햓얕킗蓮瞧얟芡쎥즧\udea9\ud9ab\udcad햯솱", a_);
			base.Id = 3;
			base.UIName = AppResources.FLASHcode_Features;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x001062E0 File Offset: 0x001044E0
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00106398 File Offset: 0x00104598
		public string RadioConfigFeatureNameValue
		{
			get
			{
				short num = (short)175088482;
				short num2 = num;
				num = (short)385065826;
				switch (num2 == num)
				{
				}
				num = (short)316932097;
				if (num != 0)
				{
				}
				num = (short)870645760;
				if (num != 0)
				{
				}
				num = (short)137887744;
				short num3 = num;
				return this.a.Value;
			}
			set
			{
				short num = (short)323755601;
				short num2 = num;
				num = (short)993533521;
				switch (num2 == num)
				{
				}
				num = (short)1963851776;
				if (num != 0)
				{
				}
				num = (short)2122252289;
				if (num != 0)
				{
				}
				num = (short)62324736;
				short num3 = num;
				this.a.Value = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0010644C File Offset: 0x0010464C
		public Field RadioConfigFeatureName
		{
			get
			{
				short num = (short)1521722664;
				short num2 = num;
				num = (short)1397269800;
				switch (num2 == num)
				{
				}
				num = (short)391249921;
				if (num != 0)
				{
				}
				num = (short)187301888;
				if (num != 0)
				{
				}
				num = (short)229572608;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x001064F8 File Offset: 0x001046F8
		public bool RadioConfigFeatureName_Applicable
		{
			get
			{
				short num = (short)846016711;
				short num2 = num;
				num = (short)552808647;
				switch (num2 == num)
				{
				}
				num = (short)1593114625;
				if (num != 0)
				{
				}
				num = (short)1871642624;
				if (num != 0)
				{
				}
				num = (short)1766653952;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x001065A4 File Offset: 0x001047A4
		public bool RadioConfigFeatureName_Valid
		{
			get
			{
				short num = (short)924294421;
				short num2 = num;
				num = (short)133209365;
				switch (num2 == num)
				{
				}
				num = (short)1810497537;
				if (num != 0)
				{
				}
				num = (short)1455357952;
				if (num != 0)
				{
				}
				num = (short)1571160064;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00106650 File Offset: 0x00104850
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00106704 File Offset: 0x00104904
		public bool RadioConfigFeatureName_Visible
		{
			get
			{
				short num = (short)32374785;
				if (num != 0)
				{
				}
				num = (short)675781042;
				short num2 = num;
				num = (short)475437490;
				switch (num2 == num)
				{
				}
				num = (short)927334400;
				if (num != 0)
				{
				}
				num = (short)624885760;
				short num3 = num;
				return this.a.Visible;
			}
			set
			{
				short num = (short)395280603;
				short num2 = num;
				num = (short)484933851;
				switch (num2 == num)
				{
				}
				num = (short)1632108544;
				if (num != 0)
				{
				}
				num = (short)1113194497;
				if (num != 0)
				{
				}
				num = (short)1546256384;
				short num3 = num;
				this.a.Visible = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x001067B8 File Offset: 0x001049B8
		public bool RadioConfigFeatureName_Editable
		{
			get
			{
				short num = (short)1305949943;
				short num2 = num;
				num = (short)396310263;
				switch (num2 == num)
				{
				}
				num = (short)555548672;
				if (num != 0)
				{
				}
				num = (short)1870921729;
				if (num != 0)
				{
				}
				num = (short)282918912;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00106860 File Offset: 0x00104A60
		internal string RadioConfigFeatureName_UILabel
		{
			get
			{
				short num = (short)1352065439;
				short num2 = num;
				num = (short)1415111071;
				switch (num2 == num)
				{
				}
				num = (short)2057240576;
				if (num != 0)
				{
				}
				num = (short)65732609;
				if (num != 0)
				{
				}
				num = (short)1674706944;
				short num3 = num;
				return this.a.UIName;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00106918 File Offset: 0x00104B18
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x001069CC File Offset: 0x00104BCC
		public string RadioConfigCurrentFlashcodeValueValue
		{
			get
			{
				short num = (short)1629596344;
				short num2 = num;
				num = (short)635677368;
				switch (num2 == num)
				{
				}
				num = (short)214171649;
				if (num != 0)
				{
				}
				num = (short)723845120;
				if (num != 0)
				{
				}
				num = (short)749666304;
				short num3 = num;
				return this.b.Value;
			}
			set
			{
				short num = (short)1079286899;
				short num2 = num;
				num = (short)699243635;
				switch (num2 == num)
				{
				}
				num = (short)1170276352;
				if (num != 0)
				{
				}
				num = (short)609419265;
				if (num != 0)
				{
				}
				num = (short)1866268672;
				short num3 = num;
				this.b.Value = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00106A84 File Offset: 0x00104C84
		public Field RadioConfigCurrentFlashcodeValue
		{
			get
			{
				short num = (short)196436841;
				short num2 = num;
				num = (short)1049715561;
				switch (num2 == num)
				{
				}
				num = (short)2049114113;
				if (num != 0)
				{
				}
				num = (short)1889206272;
				if (num != 0)
				{
				}
				num = (short)987234304;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00106B34 File Offset: 0x00104D34
		public bool RadioConfigCurrentFlashcodeValue_Applicable
		{
			get
			{
				short num = (short)595653231;
				short num2 = num;
				num = (short)542700143;
				switch (num2 == num)
				{
				}
				num = (short)1644298241;
				if (num != 0)
				{
				}
				num = (short)2001141760;
				if (num != 0)
				{
				}
				num = (short)846790656;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00106BE0 File Offset: 0x00104DE0
		public bool RadioConfigCurrentFlashcodeValue_Valid
		{
			get
			{
				short num = (short)1380200160;
				short num2 = num;
				num = (short)1884237536;
				switch (num2 == num)
				{
				}
				num = (short)1732050945;
				if (num != 0)
				{
				}
				num = (short)185860096;
				if (num != 0)
				{
				}
				num = (short)228065280;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00106C8C File Offset: 0x00104E8C
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x00106D40 File Offset: 0x00104F40
		public bool RadioConfigCurrentFlashcodeValue_Visible
		{
			get
			{
				short num = (short)1191506685;
				short num2 = num;
				num = (short)740225789;
				switch (num2 == num)
				{
				}
				num = (short)1913126913;
				if (num != 0)
				{
				}
				num = (short)330432512;
				if (num != 0)
				{
				}
				num = (short)223870976;
				short num3 = num;
				return this.b.Visible;
			}
			set
			{
				short num = (short)557221192;
				short num2 = num;
				num = (short)177243464;
				switch (num2 == num)
				{
				}
				num = (short)1722089473;
				if (num != 0)
				{
				}
				num = (short)157941760;
				if (num != 0)
				{
				}
				num = (short)658898944;
				short num3 = num;
				this.b.Visible = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00106DF8 File Offset: 0x00104FF8
		public bool RadioConfigCurrentFlashcodeValue_Editable
		{
			get
			{
				short num = (short)709427201;
				if (num != 0)
				{
				}
				num = (short)2128994515;
				short num2 = num;
				num = (short)768401619;
				switch (num2 == num)
				{
				}
				num = (short)716177408;
				if (num != 0)
				{
				}
				num = (short)748814336;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00106EA4 File Offset: 0x001050A4
		internal string RadioConfigCurrentFlashcodeValue_UILabel
		{
			get
			{
				short num = (short)2001295940;
				short num2 = num;
				num = (short)1383684676;
				switch (num2 == num)
				{
				}
				num = (short)1144520705;
				if (num != 0)
				{
				}
				num = (short)1141702656;
				if (num != 0)
				{
				}
				num = (short)1514012672;
				short num3 = num;
				return this.b.UIName;
			}
		}

		// Token: 0x04000630 RID: 1584
		private Field a;

		// Token: 0x04000631 RID: 1585
		private Field b;
	}
}
