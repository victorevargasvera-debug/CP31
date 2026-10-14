using System;
using CommonResources;

namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
	// Token: 0x0200010C RID: 268
	public class FlashkeyConfigurationRecset : global::SpecialFeatures.Flashport.Recordset
	{
		// Token: 0x06000EA4 RID: 3748 RVA: 0x00003332 File Offset: 0x00001532
		public FlashkeyConfigurationRecset() : base(global::CommonResources.AppResources.FLASHkey_Configuration)
		{
			this.SetValues();
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00149AE8 File Offset: 0x00147CE8
		public override global::SpecialFeatures.Flashport.FeatureNode CreateDefaultRecord()
		{
			short num = (short)983998048;
			short num2 = num;
			num = (short)2121965152;
			switch (num2 == num)
			{
			default:
			{
				num = (short)4653056;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)862846976;
			if (num != 0)
			{
			}
			num = (short)1362362369;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfiguration(this);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00149B98 File Offset: 0x00147D98
		internal void SetValues()
		{
			short num = (short)1398706410;
			short num2 = num;
			num = (short)1142329578;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2054750208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1503985665;
			if (num != 0)
			{
			}
			num = (short)1518534656;
			if (num != 0)
			{
			}
			base.Id = 23;
			base.UIName = global::CommonResources.AppResources.FLASHkey_Configuration;
		}
	}
}
