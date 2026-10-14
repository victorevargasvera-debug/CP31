using System;
using System.ComponentModel;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000072 RID: 114
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NumericDayInput : global::DevComponents.WpfEditors.Primitives.EditorIntegerInput, global::DevComponents.WpfEditors.Primitives.IDateTimePartInput
	{
		// Token: 0x06000758 RID: 1880 RVA: 0x000994F0 File Offset: 0x000976F0
		public NumericDayInput()
		{
			base.MinValue = 1;
			base.MaxValue = 31;
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00099514 File Offset: 0x00097714
		public global::DevComponents.WpfEditors.Primitives.eDateTimePart Part
		{
			get
			{
				short num = (short)1579941889;
				if (num != 0)
				{
				}
				num = (short)388235264;
				short num2 = num;
				num = (short)87720008;
				short num3 = num;
				num = (short)515014728;
				switch (num3 == num)
				{
				}
				num = (short)1337196544;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.Primitives.eDateTimePart.Day;
			}
		}
	}
}
