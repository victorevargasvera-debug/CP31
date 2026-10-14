using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000214 RID: 532
	[global::System.Serializable]
	public sealed class UclContactAstroCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001B25 RID: 6949 RVA: 0x00003DF9 File Offset: 0x00001FF9
		internal UclContactAstroCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			base.EmbeddedRecset = this.astroCallListRecset;
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x00230290 File Offset: 0x0022E490
		internal global::SpecialFeatures.Ucl.Contact.AstroCallListRecset AstroCallListRecset
		{
			get
			{
				short num = (short)131082491;
				short num2 = num;
				num = (short)602941691;
				switch (num2 == num)
				{
				}
				num = (short)1471676417;
				if (num != 0)
				{
				}
				num = (short)739770368;
				if (num != 0)
				{
				}
				num = (short)182124544;
				short num3 = num;
				return this.astroCallListRecset;
			}
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00230340 File Offset: 0x0022E540
		public override void PopulateReferences()
		{
			short num = (short)796279598;
			short num2 = num;
			num = (short)1001276206;
			switch (num2 == num)
			{
			}
			num = (short)1533476864;
			if (num != 0)
			{
			}
			num = (short)165937153;
			if (num != 0)
			{
			}
			num = (short)1994260480;
			short num3 = num;
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x002303EC File Offset: 0x0022E5EC
		public override void DropReferences()
		{
			short num = (short)2031199909;
			short num2 = num;
			num = (short)782673573;
			switch (num2 == num)
			{
			}
			num = (short)285016065;
			if (num != 0)
			{
			}
			num = (short)2119958528;
			if (num != 0)
			{
			}
			num = (short)1496907776;
			short num3 = num;
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x00230498 File Offset: 0x0022E698
		public override void SetupDependencies()
		{
			short num = (short)2107442686;
			short num2 = num;
			num = (short)486016510;
			switch (num2 == num)
			{
			}
			num = (short)1216872449;
			if (num != 0)
			{
			}
			num = (short)461570048;
			if (num != 0)
			{
			}
			num = (short)1181417472;
			short num3 = num;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x00230540 File Offset: 0x0022E740
		public override void SetConstraints()
		{
			short num = (short)2043193731;
			short num2 = num;
			num = (short)1974184323;
			switch (num2 == num)
			{
			}
			num = (short)141426688;
			if (num != 0)
			{
			}
			num = (short)255000577;
			if (num != 0)
			{
			}
			num = (short)1754988544;
			short num3 = num;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x002305EC File Offset: 0x0022E7EC
		public override void Init()
		{
			int a_ = 4;
			short num = (short)914423809;
			if (num != 0)
			{
			}
			num = (short)1597288880;
			short num2 = num;
			num = (short)2099818928;
			switch (num2 == num)
			{
			}
			num = (short)25100288;
			if (num != 0)
			{
			}
			num = (short)1601961984;
			short num3 = num;
			this.astroCallListRecset = new global::SpecialFeatures.Ucl.Contact.AstroCallListRecset();
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욆\uda88\udf8a\udf8c삎놐킒杖練ﺚ좠첢쮤욦얨讪", a_);
			base.UIName = global::CommonResources.AppResources.Astro_Conventional_ID;
			base.Id = 10403;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x002306D8 File Offset: 0x0022E8D8
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)899924322;
			short num2 = num;
			num = (short)1877590370;
			switch (num2 == num)
			{
			}
			num = (short)1556676608;
			if (num != 0)
			{
			}
			num = (short)1779171329;
			if (num != 0)
			{
			}
			num = (short)382533632;
			short num3 = num;
			base.GetObjectData(info, context);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00230788 File Offset: 0x0022E988
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)420151298;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E9;
				case 1:
				{
					num = (short)1514668032;
					short num3 = num;
					num = (short)247120057;
					short num4 = num;
					num = (short)1318961337;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)353894400;
						if (num != 0)
						{
						}
						num = (short)2033844224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)139722753;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E9:
			num = (short)715325441;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튒요쎖쮘풚붜\udc9e캠춢펤슦잨\udfaa쒬삮\udfb0튲\ud9b4鞶ﾺ", a_);
			base.UIName = global::CommonResources.AppResources.Astro_Conventional_ID;
			base.Id = 10403;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclContactAstroCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x002308DC File Offset: 0x0022EADC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1497005229;
				short num2 = num;
				num = (short)132938925;
				switch (num2 == num)
				{
				}
				num = (short)406519809;
				if (num != 0)
				{
				}
				num = (short)1615200256;
				if (num != 0)
				{
				}
				num = (short)1368588288;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x04000CCC RID: 3276
		private global::SpecialFeatures.Ucl.Contact.AstroCallListRecset astroCallListRecset;
	}
}
