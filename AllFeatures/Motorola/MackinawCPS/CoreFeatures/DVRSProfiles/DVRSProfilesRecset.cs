using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DVRSProfiles
{
	// Token: 0x020004B5 RID: 1205
	[global::System.Serializable]
	public class DVRSProfilesRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06009E57 RID: 40535 RVA: 0x0093DE50 File Offset: 0x0093C050
		public DVRSProfilesRecset() : base(global::CommonResources.AcgResources.ID_DVRSPROFILES, global::CommonResources.AcgResources.ID_PROFILE)
		{
			this.SetValues();
		}

		// Token: 0x06009E58 RID: 40536 RVA: 0x0093DE74 File Offset: 0x0093C074
		public DVRSProfilesRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004F81 RID: 20353
		// (get) Token: 0x06009E59 RID: 40537 RVA: 0x0093DEA0 File Offset: 0x0093C0A0
		public override int MaxPool
		{
			get
			{
				short num = (short)880179666;
				short num2 = num;
				num = (short)950106578;
				switch (num2 == num)
				{
				}
				num = (short)903020545;
				if (num != 0)
				{
				}
				num = (short)744095744;
				short num3 = num;
				num = (short)1579810816;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesRecset._MaxPool;
			}
		}

		// Token: 0x17004F82 RID: 20354
		// (get) Token: 0x06009E5A RID: 40538 RVA: 0x0093DF4C File Offset: 0x0093C14C
		// (set) Token: 0x06009E5B RID: 40539 RVA: 0x0093E010 File Offset: 0x0093C210
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)147521537;
					if (num != 0)
					{
					}
					num = (short)628287700;
					short num2 = num;
					num = (short)278980820;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)972619776;
						short num3 = num;
						break;
					}
					}
					num = (short)698744832;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)165182604;
				short num2 = num;
				num = (short)1925872780;
				switch (num2 == num)
				{
				}
				num = (short)1735393281;
				if (num != 0)
				{
				}
				num = (short)539951104;
				short num3 = num;
				num = (short)468516864;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004F83 RID: 20355
		// (get) Token: 0x06009E5C RID: 40540 RVA: 0x0093E0C0 File Offset: 0x0093C2C0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1202693039;
				short num2 = num;
				num = (short)626762671;
				switch (num2 == num)
				{
				}
				num = (short)1919418369;
				if (num != 0)
				{
				}
				num = (short)920059904;
				short num3 = num;
				num = (short)143982592;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004F84 RID: 20356
		// (get) Token: 0x06009E5D RID: 40541 RVA: 0x0093E170 File Offset: 0x0093C370
		// (set) Token: 0x06009E5E RID: 40542 RVA: 0x0093E21C File Offset: 0x0093C41C
		public override int Min
		{
			get
			{
				short num = (short)87162881;
				if (num != 0)
				{
				}
				num = (short)1657743108;
				short num2 = num;
				num = (short)792012548;
				switch (num2 == num)
				{
				}
				num = (short)1296498688;
				short num3 = num;
				num = (short)735182848;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesRecset._Min;
			}
			set
			{
				short num = (short)143933149;
				short num2 = num;
				num = (short)725171933;
				switch (num2 == num)
				{
				}
				num = (short)1382744065;
				if (num != 0)
				{
				}
				num = (short)695140352;
				short num3 = num;
				num = (short)1464139776;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesRecset._Min = value;
			}
		}

		// Token: 0x06009E5F RID: 40543 RVA: 0x0093E2CC File Offset: 0x0093C4CC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1347935768;
			short num2 = num;
			num = (short)1350688280;
			switch (num2 == num)
			{
			}
			num = (short)1013121025;
			if (num != 0)
			{
			}
			num = (short)936706048;
			short num3 = num;
			num = (short)528154624;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles(this);
		}

		// Token: 0x06009E60 RID: 40544 RVA: 0x0093E37C File Offset: 0x0093C57C
		internal void SetValues()
		{
			int a_ = 9;
			short num = (short)1134205126;
			short num2 = num;
			num = (short)42309830;
			switch (num2 == num)
			{
			}
			num = (short)79036417;
			if (num != 0)
			{
			}
			num = (short)647168000;
			short num3 = num;
			num = (short)2088960000;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 4143;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ雏럑뗓ꋕ귗꣙맛귝\udbdfꇡ诣该飧藩苫语黯蛱ꣳ답껷꣹꿻\udefd䏿洁樃怅愇洉礋簍焏昑紓礕瘗䘙堛䠝爟無У瘥娧䔩䨫䜭尯圱䜳樵簷氹渻洽ဿぁ⭃⁅ⅇ♉⥋㵍яけ㡓硕⁗㭙ㅛ㉝", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DVRSPROFILES;
			base.KeySeed = global::CommonResources.AcgResources.ID_PROFILE;
			base.DataTransferOrder = 52;
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x0093E480 File Offset: 0x0093C680
		// Note: this type is marked as 'beforefieldinit'.
		static DVRSProfilesRecset()
		{
			short num = (short)74396680;
			short num2 = num;
			num = (short)197407752;
			switch (num2 == num)
			{
			}
			num = (short)1106116609;
			if (num != 0)
			{
			}
			num = (short)128581632;
			short num3 = num;
			num = (short)14221312;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesRecset._Min = 1;
		}

		// Token: 0x04004DB4 RID: 19892
		public static int _MaxPool;

		// Token: 0x04004DB5 RID: 19893
		public static int _Max;

		// Token: 0x04004DB6 RID: 19894
		public int _DynMax;

		// Token: 0x04004DB7 RID: 19895
		public static int _Min;
	}
}
