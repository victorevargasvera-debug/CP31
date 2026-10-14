using System;
using CommonResources;

namespace SpecialFeatures.Flashport.RadioConfiguration
{
	// Token: 0x020000D0 RID: 208
	public class RadioConfigurationRecset : global::SpecialFeatures.Flashport.Recordset
	{
		// Token: 0x06000CC7 RID: 3271 RVA: 0x00002F52 File Offset: 0x00001152
		public RadioConfigurationRecset() : base(global::CommonResources.AppResources.Radio_Configuration)
		{
			this.SetValues();
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0010735C File Offset: 0x0010555C
		public override global::SpecialFeatures.Flashport.FeatureNode CreateDefaultRecord()
		{
			short num = (short)816755212;
			short num2 = num;
			num = (short)1516876300;
			switch (num2 == num)
			{
			}
			num = (short)651427840;
			if (num != 0)
			{
			}
			num = (short)1163132929;
			if (num != 0)
			{
			}
			num = (short)1915748352;
			short num3 = num;
			return new global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfiguration(this);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0010740C File Offset: 0x0010560C
		internal void SetValues()
		{
			short num = (short)521666561;
			if (num != 0)
			{
			}
			num = (short)572351972;
			short num2 = num;
			num = (short)286877156;
			switch (num2 == num)
			{
			}
			num = (short)1298530304;
			if (num != 0)
			{
			}
			num = (short)1291452416;
			short num3 = num;
			base.Id = 21;
			base.UIName = global::CommonResources.AppResources.Radio_Configuration;
		}
	}
}
