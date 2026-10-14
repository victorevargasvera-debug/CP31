using System;
using System.ComponentModel;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000076 RID: 118
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NumericMinuteInput : global::DevComponents.WpfEditors.Primitives.EditorIntegerInput, global::DevComponents.WpfEditors.Primitives.IDateTimePartInput
	{
		// Token: 0x06000766 RID: 1894 RVA: 0x0009A040 File Offset: 0x00098240
		public NumericMinuteInput()
		{
			base.MinValue = 0;
			base.MaxValue = 59;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x0009A064 File Offset: 0x00098264
		global::DevComponents.WpfEditors.Primitives.eDateTimePart global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.Part
		{
			get
			{
				short num = (short)1322285901;
				short num2 = num;
				num = (short)1013021517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2143223808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)424083456;
				if (num != 0)
				{
				}
				num = (short)78708737;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.Primitives.eDateTimePart.Minute;
			}
		}
	}
}
