using System;
using CommonResources;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x02000082 RID: 130
	public class RadioFeatureSetRecset : global::SpecialFeatures.Flashport.Recordset
	{
		// Token: 0x06000A33 RID: 2611 RVA: 0x00002C13 File Offset: 0x00000E13
		public RadioFeatureSetRecset() : base(global::CommonResources.AppResources.Codeplug_Feature_Set)
		{
			this.SetValues();
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000BBD04 File Offset: 0x000B9F04
		public override global::SpecialFeatures.Flashport.FeatureNode CreateDefaultRecord()
		{
			short num = (short)183909203;
			short num2 = num;
			num = (short)1118452563;
			switch (num2 == num)
			{
			}
			num = (short)275447809;
			if (num != 0)
			{
			}
			num = (short)279379968;
			if (num != 0)
			{
			}
			num = (short)938934272;
			short num3 = num;
			return new global::SpecialFeatures.RadioFeatureSet.RadioFeatureSet(this);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000BBDB0 File Offset: 0x000B9FB0
		internal void SetValues()
		{
			short num = (short)2093205783;
			short num2 = num;
			num = (short)369740055;
			switch (num2 == num)
			{
			}
			num = (short)291110912;
			if (num != 0)
			{
			}
			num = (short)447086593;
			if (num != 0)
			{
			}
			num = (short)700841984;
			short num3 = num;
			base.Id = 41;
			base.UIName = global::CommonResources.AppResources.Codeplug_Feature_Set;
		}
	}
}
