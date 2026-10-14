using System;
using System.ComponentModel;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000078 RID: 120
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NumericSecondInput : global::DevComponents.WpfEditors.Primitives.EditorIntegerInput, global::DevComponents.WpfEditors.Primitives.IDateTimePartInput
	{
		// Token: 0x0600076A RID: 1898 RVA: 0x0009A1DC File Offset: 0x000983DC
		public NumericSecondInput()
		{
			base.MinValue = 0;
			base.MaxValue = 59;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0009A200 File Offset: 0x00098400
		global::DevComponents.WpfEditors.Primitives.eDateTimePart global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.Part
		{
			get
			{
				short num = (short)375640522;
				short num2 = num;
				num = (short)318951882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)74317824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)331087873;
				if (num != 0)
				{
				}
				num = (short)1517682688;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.Primitives.eDateTimePart.Second;
			}
		}
	}
}
