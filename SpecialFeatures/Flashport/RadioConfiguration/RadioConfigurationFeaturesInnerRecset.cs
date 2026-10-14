using System;
using CommonResources;

namespace SpecialFeatures.Flashport.RadioConfiguration
{
	// Token: 0x020000CD RID: 205
	public class RadioConfigurationFeaturesInnerRecset : global::SpecialFeatures.Flashport.Recordset
	{
		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002F2A File Offset: 0x0000112A
		public RadioConfigurationFeaturesInnerRecset() : base(global::CommonResources.AppResources.FLASHcode_Features)
		{
			this.SetValues();
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00105F00 File Offset: 0x00104100
		public override global::SpecialFeatures.Flashport.FeatureNode CreateDefaultRecord()
		{
			short num = (short)686019537;
			short num2 = num;
			num = (short)1462162385;
			switch (num2 == num)
			{
			}
			num = (short)1937047553;
			if (num != 0)
			{
			}
			num = (short)1188036608;
			if (num != 0)
			{
			}
			num = (short)1847590912;
			short num3 = num;
			return new global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInner(this);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00105FB0 File Offset: 0x001041B0
		internal void SetValues()
		{
			short num = (short)722665473;
			if (num != 0)
			{
			}
			num = (short)1988100423;
			short num2 = num;
			num = (short)1993408839;
			switch (num2 == num)
			{
			}
			num = (short)1094385664;
			if (num != 0)
			{
			}
			num = (short)322371584;
			short num3 = num;
			base.Id = 20;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AppResources.FLASHcode_Features;
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00106074 File Offset: 0x00104274
		public override int Max
		{
			get
			{
				short num = (short)384783171;
				short num2 = num;
				num = (short)1718506307;
				switch (num2 == num)
				{
				}
				num = (short)343801856;
				if (num != 0)
				{
				}
				num = (short)178257921;
				if (num != 0)
				{
				}
				num = (short)1012203520;
				short num3 = num;
				return 100;
			}
		}
	}
}
