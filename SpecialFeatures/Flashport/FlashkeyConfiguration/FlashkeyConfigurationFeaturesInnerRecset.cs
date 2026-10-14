using System;
using CommonResources;

namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
	// Token: 0x02000109 RID: 265
	public class FlashkeyConfigurationFeaturesInnerRecset : global::SpecialFeatures.Flashport.Recordset
	{
		// Token: 0x06000E7D RID: 3709 RVA: 0x0000330A File Offset: 0x0000150A
		public FlashkeyConfigurationFeaturesInnerRecset() : base(global::CommonResources.AppResources.FLASHcode_Features)
		{
			this.SetValues();
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00147F8C File Offset: 0x0014618C
		public override global::SpecialFeatures.Flashport.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2026700800;
			short num2 = num;
			num = (short)900238120;
			short num3 = num;
			num = (short)1848347432;
			switch (num3 == num)
			{
			}
			num = (short)1362886657;
			if (num != 0)
			{
			}
			num = (short)92209152;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInner(this);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0014803C File Offset: 0x0014623C
		internal void SetValues()
		{
			short num = (short)1272512512;
			short num2 = num;
			num = (short)1392184716;
			short num3 = num;
			num = (short)527306124;
			switch (num3 == num)
			{
			}
			num = (short)503119873;
			if (num != 0)
			{
			}
			num = (short)1521418240;
			if (num != 0)
			{
			}
			base.Id = 22;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AppResources.FLASHcode_Features;
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00148100 File Offset: 0x00146300
		public override int Max
		{
			get
			{
				short num = (short)741867520;
				short num2 = num;
				num = (short)336440328;
				short num3 = num;
				num = (short)223259656;
				switch (num3 == num)
				{
				}
				num = (short)463208449;
				if (num != 0)
				{
				}
				num = (short)558497792;
				if (num != 0)
				{
				}
				return 100;
			}
		}
	}
}
