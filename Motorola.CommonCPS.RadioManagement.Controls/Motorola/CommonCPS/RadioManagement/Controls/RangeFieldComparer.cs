using System;
using System.Collections;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200008A RID: 138
	internal class RangeFieldComparer : global::System.Collections.IComparer
	{
		// Token: 0x06000347 RID: 839 RVA: 0x00036C34 File Offset: 0x00034E34
		public int Compare(object x, object y)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RangeField rangeField;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RangeField rangeField2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_142;
				case 1:
				{
					num2 = (short)662225823;
					short num3 = num2;
					num2 = (short)543605663;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_49;
					default:
						num2 = (short)490078208;
						if (num2 != 0)
						{
						}
						num2 = (short)19595265;
						if (num2 != 0)
						{
						}
						num2 = (short)398983170;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (rangeField != null)
					{
						num2 = (short)1323499520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_147;
				case 3:
					if (rangeField2 != null)
					{
						goto IL_49;
					}
					goto IL_147;
				}
				goto IL_20;
				IL_49:
				num2 = (short)1367539713;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_142:
			num2 = (short)1533739008;
			short num4 = num2;
			return rangeField2.Value.CompareTo(rangeField.Value);
			IL_147:
			return string.Compare(x.ToString(), y.ToString(), global::System.StringComparison.CurrentCulture);
			IL_20:
			rangeField2 = (x as global::Motorola.CommonCPS.RadioManagement.UIModels.RangeField);
			rangeField = (y as global::Motorola.CommonCPS.RadioManagement.UIModels.RangeField);
			num2 = (short)690356227;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
