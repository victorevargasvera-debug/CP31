using System;
using System.ComponentModel;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000073 RID: 115
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NumericDayOfYearInput : global::DevComponents.WpfEditors.Primitives.EditorIntegerInput, global::DevComponents.WpfEditors.Primitives.IDateTimePartInput
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x000995C0 File Offset: 0x000977C0
		public NumericDayOfYearInput()
		{
			base.MinValue = 1;
			base.MaxValue = 366;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x000995E8 File Offset: 0x000977E8
		global::DevComponents.WpfEditors.Primitives.eDateTimePart global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.Part
		{
			get
			{
				short num = (short)889935539;
				short num2 = num;
				num = (short)1294685875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)812843008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)887685121;
				if (num != 0)
				{
				}
				num = (short)423100416;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.Primitives.eDateTimePart.DayOfYear;
			}
		}
	}
}
