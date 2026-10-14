using System;
using System.ComponentModel;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x0200001B RID: 27
	public static class DescriptionAttributeHelper
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0000A530 File Offset: 0x00008730
		static DescriptionAttributeHelper()
		{
			short num = (short)1482558120;
			short num2 = num;
			num = (short)1973750440;
			switch (num2 == num)
			{
			}
			num = (short)1560412160;
			short num3 = num;
			num = (short)1059127296;
			if (num != 0)
			{
			}
			num = (short)1483014145;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000A5D8 File Offset: 0x000087D8
		public static string GetDescription(global::System.Enum value)
		{
			global::System.ComponentModel.DescriptionAttribute[] array = (global::System.ComponentModel.DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(global::System.ComponentModel.DescriptionAttribute), false);
			short num;
			if (array.Length == 0)
			{
				num = (short)387403788;
				short num2 = num;
				num = (short)311250956;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)978059264;
					if (num != 0)
					{
					}
					num = (short)633667585;
					if (num != 0)
					{
					}
					break;
				}
				return value.ToString();
			}
			num = (short)2082799616;
			short num3 = num;
			return array[0].Description;
		}
	}
}
