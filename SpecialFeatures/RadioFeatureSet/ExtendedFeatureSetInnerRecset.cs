using System;
using CommonResources;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x02000074 RID: 116
	public class ExtendedFeatureSetInnerRecset : global::SpecialFeatures.Flashport.Recordset
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x00002B39 File Offset: 0x00000D39
		public ExtendedFeatureSetInnerRecset() : base(global::CommonResources.AppResources.Extended_Feature_Set)
		{
			this.SetValues();
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000A8804 File Offset: 0x000A6A04
		public override global::SpecialFeatures.Flashport.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1618876736;
			short num2 = num;
			num = (short)495065408;
			switch (num2 == num)
			{
			}
			num = (short)1116471297;
			if (num != 0)
			{
			}
			num = (short)84869120;
			if (num != 0)
			{
			}
			num = (short)578027520;
			short num3 = num;
			return new global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInner(this);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000A88B0 File Offset: 0x000A6AB0
		internal void SetValues()
		{
			short num = (short)819070278;
			short num2 = num;
			num = (short)1040975174;
			switch (num2 == num)
			{
			}
			num = (short)1164050433;
			if (num != 0)
			{
			}
			num = (short)944570368;
			if (num != 0)
			{
			}
			num = (short)1918435328;
			short num3 = num;
			base.Id = 42;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AppResources.Extended_Feature_Set;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x000A8974 File Offset: 0x000A6B74
		public override int Max
		{
			get
			{
				short num = (short)283432610;
				short num2 = num;
				num = (short)1648744098;
				switch (num2 == num)
				{
				}
				num = (short)462618624;
				if (num != 0)
				{
				}
				num = (short)233373697;
				if (num != 0)
				{
				}
				num = (short)1075380224;
				short num3 = num;
				return 100;
			}
		}
	}
}
