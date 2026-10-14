using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.RadioConfiguration
{
	// Token: 0x020000D1 RID: 209
	public sealed class General : global::SpecialFeatures.Flashport.FeatureSection
	{
		// Token: 0x06000CCA RID: 3274 RVA: 0x00002F65 File Offset: 0x00001165
		internal General(global::SpecialFeatures.Flashport.FeatureNode parent) : base(parent)
		{
			this.Init();
			this.a();
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x001074C8 File Offset: 0x001056C8
		private void a()
		{
			int a_ = 5;
			short num = (short)1336499722;
			short num2 = num;
			num = (short)1699175946;
			switch (num2 == num)
			{
			}
			num = (short)2043215872;
			if (num != 0)
			{
			}
			num = (short)2133131265;
			if (num != 0)
			{
			}
			num = (short)1196752896;
			short num3 = num;
			this.a.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킇튉풋획좏쪑첓캕삗슙쒛욝瑱ﲣﺥ", a_);
			this.b.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢇몉벋뺍ꂏꊑ릓ꚕꢗꪙ겛꺝邟辡钣", a_);
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x001075AC File Offset: 0x001057AC
		public override void Init()
		{
			int a_ = 3;
			short num = (short)1066469729;
			short num2 = num;
			num = (short)2073233761;
			switch (num2 == num)
			{
			}
			num = (short)160301057;
			if (num != 0)
			{
			}
			num = (short)987365376;
			if (num != 0)
			{
			}
			num = (short)742260736;
			short num3 = num;
			this.a = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.Model_Number, true);
			this.b = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.FLASHcode_Id, true);
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솅ﲍﺑ", a_);
			base.Id = 2;
			base.UIName = global::CommonResources.AppResources.General_Id;
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x001076A4 File Offset: 0x001058A4
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x00107758 File Offset: 0x00105958
		public string RadioConfigCurrentModelNumberValue
		{
			get
			{
				short num = (short)827200451;
				short num2 = num;
				num = (short)1083446211;
				switch (num2 == num)
				{
				}
				num = (short)1350631425;
				if (num != 0)
				{
				}
				num = (short)1733033984;
				if (num != 0)
				{
				}
				num = (short)163381248;
				short num3 = num;
				return this.a.Value;
			}
			set
			{
				short num = (short)2063622045;
				short num2 = num;
				num = (short)1229217693;
				switch (num2 == num)
				{
				}
				num = (short)1829240833;
				if (num != 0)
				{
				}
				num = (short)287309824;
				if (num != 0)
				{
				}
				num = (short)958595072;
				short num3 = num;
				this.a.Value = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00107810 File Offset: 0x00105A10
		public global::SpecialFeatures.Flashport.Field RadioConfigCurrentModelNumber
		{
			get
			{
				short num = (short)1500215902;
				short num2 = num;
				num = (short)1225357918;
				switch (num2 == num)
				{
				}
				num = (short)194248705;
				if (num != 0)
				{
				}
				num = (short)566755328;
				if (num != 0)
				{
				}
				num = (short)1334837248;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x001078C0 File Offset: 0x00105AC0
		public bool RadioConfigCurrentModelNumber_Applicable
		{
			get
			{
				short num = (short)364027816;
				short num2 = num;
				num = (short)1775411112;
				switch (num2 == num)
				{
				}
				num = (short)1727660033;
				if (num != 0)
				{
				}
				num = (short)1235615744;
				if (num != 0)
				{
				}
				num = (short)1546977280;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x0010796C File Offset: 0x00105B6C
		public bool RadioConfigCurrentModelNumber_Valid
		{
			get
			{
				short num = (short)1366447095;
				short num2 = num;
				num = (short)1758614519;
				switch (num2 == num)
				{
				}
				num = (short)1267138561;
				if (num != 0)
				{
				}
				num = (short)1069285376;
				if (num != 0)
				{
				}
				num = (short)200278016;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00107A18 File Offset: 0x00105C18
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00107ACC File Offset: 0x00105CCC
		public bool RadioConfigCurrentModelNumber_Visible
		{
			get
			{
				short num = (short)911509180;
				short num2 = num;
				num = (short)1130268348;
				switch (num2 == num)
				{
				}
				num = (short)1506541569;
				if (num != 0)
				{
				}
				num = (short)1801584640;
				if (num != 0)
				{
				}
				num = (short)367460352;
				short num3 = num;
				return this.a.Visible;
			}
			set
			{
				short num = (short)1003220771;
				short num2 = num;
				num = (short)206499619;
				switch (num2 == num)
				{
				}
				num = (short)753139713;
				if (num != 0)
				{
				}
				num = (short)628555776;
				if (num != 0)
				{
				}
				num = (short)116654080;
				short num3 = num;
				this.a.Visible = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00107B80 File Offset: 0x00105D80
		public bool RadioConfigCurrentModelNumber_Editable
		{
			get
			{
				short num = (short)1901776837;
				short num2 = num;
				num = (short)1345769413;
				switch (num2 == num)
				{
				}
				num = (short)1907556352;
				if (num != 0)
				{
				}
				num = (short)2028273665;
				if (num != 0)
				{
				}
				num = (short)170983424;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00107C2C File Offset: 0x00105E2C
		public string RadioConfigCurrentModelNumber_UILabel
		{
			get
			{
				short num = (short)1560573084;
				short num2 = num;
				num = (short)344945820;
				switch (num2 == num)
				{
				}
				num = (short)1233715201;
				if (num != 0)
				{
				}
				num = (short)1845755904;
				if (num != 0)
				{
				}
				num = (short)1677656064;
				short num3 = num;
				return this.a.UIName;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00107CE0 File Offset: 0x00105EE0
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00107D98 File Offset: 0x00105F98
		public string RadioConfigCurrentFlashcodeValue
		{
			get
			{
				short num = (short)1727385008;
				short num2 = num;
				num = (short)1729940912;
				switch (num2 == num)
				{
				}
				num = (short)437125121;
				if (num != 0)
				{
				}
				num = (short)203292672;
				if (num != 0)
				{
				}
				num = (short)1530068992;
				short num3 = num;
				return this.b.Value;
			}
			set
			{
				short num = (short)574788475;
				short num2 = num;
				num = (short)1757123451;
				switch (num2 == num)
				{
				}
				num = (short)950665216;
				if (num != 0)
				{
				}
				num = (short)1368064000;
				short num3 = num;
				num = (short)1973420033;
				if (num != 0)
				{
				}
				this.b.Value = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00107E50 File Offset: 0x00106050
		public global::SpecialFeatures.Flashport.Field RadioConfigCurrentFlashcode
		{
			get
			{
				short num = (short)905261650;
				short num2 = num;
				num = (short)183120466;
				switch (num2 == num)
				{
				}
				num = (short)1606287361;
				if (num != 0)
				{
				}
				num = (short)1562705920;
				short num3 = num;
				num = (short)1356398592;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x00107F00 File Offset: 0x00106100
		public bool RadioConfigCurrentFlashcode_Applicable
		{
			get
			{
				short num = (short)1765277697;
				if (num != 0)
				{
				}
				num = (short)1068640758;
				short num2 = num;
				num = (short)474098166;
				switch (num2 == num)
				{
				}
				num = (short)758317056;
				short num3 = num;
				num = (short)1210449920;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00107FA8 File Offset: 0x001061A8
		public bool RadioConfigCurrentFlashcode_Valid
		{
			get
			{
				short num = (short)1588179622;
				short num2 = num;
				num = (short)579973798;
				switch (num2 == num)
				{
				}
				num = (short)1629093888;
				if (num != 0)
				{
				}
				num = (short)1752432640;
				short num3 = num;
				num = (short)1041170433;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00108054 File Offset: 0x00106254
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00108108 File Offset: 0x00106308
		public bool RadioConfigCurrentFlashcode_Visible
		{
			get
			{
				short num = (short)2124905864;
				short num2 = num;
				num = (short)2063039880;
				switch (num2 == num)
				{
				}
				num = (short)1764098049;
				if (num != 0)
				{
				}
				num = (short)2049966080;
				short num3 = num;
				num = (short)816381952;
				if (num != 0)
				{
				}
				return this.b.Visible;
			}
			set
			{
				short num = (short)1737641170;
				short num2 = num;
				num = (short)1689341138;
				switch (num2 == num)
				{
				}
				num = (short)985071616;
				if (num != 0)
				{
				}
				num = (short)1889009664;
				short num3 = num;
				num = (short)344522753;
				if (num != 0)
				{
				}
				this.b.Visible = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x001081C0 File Offset: 0x001063C0
		public bool RadioConfigCurrentFlashcode_Editable
		{
			get
			{
				short num = (short)445911955;
				short num2 = num;
				num = (short)742724499;
				switch (num2 == num)
				{
				}
				num = (short)252313600;
				if (num != 0)
				{
				}
				num = (short)2123825152;
				short num3 = num;
				num = (short)489947137;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0010826C File Offset: 0x0010646C
		public string RadioConfigCurrentFlashcode_UILabel
		{
			get
			{
				short num = (short)1051641686;
				short num2 = num;
				num = (short)832620374;
				switch (num2 == num)
				{
				}
				num = (short)428474369;
				if (num != 0)
				{
				}
				num = (short)54198272;
				short num3 = num;
				num = (short)875233280;
				if (num != 0)
				{
				}
				return this.b.UIName;
			}
		}

		// Token: 0x04000637 RID: 1591
		private global::SpecialFeatures.Flashport.Field a;

		// Token: 0x04000638 RID: 1592
		private global::SpecialFeatures.Flashport.Field b;
	}
}
