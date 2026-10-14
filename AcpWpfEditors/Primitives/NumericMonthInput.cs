using System;
using System.ComponentModel;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000077 RID: 119
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NumericMonthInput : global::DevComponents.WpfEditors.Primitives.EditorIntegerInput, global::DevComponents.WpfEditors.Primitives.IDateTimePartInput
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x0009A110 File Offset: 0x00098310
		public NumericMonthInput()
		{
			base.MinValue = 1;
			base.MaxValue = 12;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0009A134 File Offset: 0x00098334
		global::DevComponents.WpfEditors.Primitives.eDateTimePart global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.Part
		{
			get
			{
				short num = (short)1656485890;
				short num2 = num;
				num = (short)1327364098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1948778496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1368522753;
				if (num != 0)
				{
				}
				num = (short)327614464;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.Primitives.eDateTimePart.Month;
			}
		}
	}
}
