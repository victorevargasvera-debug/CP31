using System;
using CommonResources;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x0200007B RID: 123
	public class FeatureSetInnerRecset : global::SpecialFeatures.Flashport.Recordset
	{
		// Token: 0x060009BE RID: 2494 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public FeatureSetInnerRecset() : base(global::CommonResources.AppResources.Feature_Set)
		{
			this.SetValues();
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000ACE90 File Offset: 0x000AB090
		public override global::SpecialFeatures.Flashport.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2056516779;
			short num2 = num;
			num = (short)1844835499;
			switch (num2 == num)
			{
			}
			num = (short)204668928;
			if (num != 0)
			{
			}
			num = (short)1718026241;
			if (num != 0)
			{
			}
			num = (short)1604583424;
			short num3 = num;
			return new global::SpecialFeatures.RadioFeatureSet.FeatureSetInner(this);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000ACF40 File Offset: 0x000AB140
		internal void SetValues()
		{
			short num = (short)1740159415;
			short num2 = num;
			num = (short)1900132791;
			switch (num2 == num)
			{
			}
			num = (short)1375272961;
			if (num != 0)
			{
			}
			num = (short)1290993664;
			if (num != 0)
			{
			}
			num = (short)1711013888;
			short num3 = num;
			base.Id = 40;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AppResources.Feature_Set;
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x000AD004 File Offset: 0x000AB204
		public override int Max
		{
			get
			{
				short num = (short)2008753093;
				short num2 = num;
				num = (short)2127897541;
				switch (num2 == num)
				{
				}
				num = (short)2023489537;
				if (num != 0)
				{
				}
				num = (short)1311113216;
				if (num != 0)
				{
				}
				num = (short)666501120;
				short num3 = num;
				return 100;
			}
		}
	}
}
