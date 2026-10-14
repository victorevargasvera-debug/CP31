using System;
using System.Globalization;
using Infragistics.Windows.DataPresenter;

namespace Motorola.CommonCPS.UI.CellRangeFill.Constraints
{
	// Token: 0x02000032 RID: 50
	public class Int32CellValueRangeConstraint : global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.CellValueRangeConstraint<int>
	{
		// Token: 0x06000119 RID: 281 RVA: 0x0000FD50 File Offset: 0x0000DF50
		public Int32CellValueRangeConstraint() : this(int.MinValue, int.MaxValue)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000FD70 File Offset: 0x0000DF70
		public Int32CellValueRangeConstraint(int minValue, int maxValue)
		{
			int a_ = 12;
			base..ctor(minValue, maxValue);
			if (maxValue < minValue)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("뻒듔꿖还뫚뇜꫞蓠", a_));
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000FDA8 File Offset: 0x0000DFA8
		public override bool IsValid(global::Infragistics.Windows.DataPresenter.Cell cell, out string message)
		{
			int a_ = 2;
			short num = (short)364904452;
			int num2 = (int)((global::System.IntPtr)num);
			int value;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1BA;
				case 1:
					goto IL_60;
				case 2:
					if (!int.TryParse(cell.Value.ToString(), out value))
					{
						num = (short)2019098629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BF;
				case 3:
					if (cell.Value == null)
					{
						num = (short)1536622593;
						if (num != 0)
						{
						}
						num = (short)1140850688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1054932994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 5:
					goto IL_A2;
				}
				IL_46:
				if (cell == null)
				{
					num = (short)1918631937;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)63438851;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_60:
			message = string.Empty;
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("꫈껊ꇌꏎ", a_));
			IL_A2:
			num = (short)993198080;
			short num3 = num;
			num = (short)976951835;
			short num4 = num;
			num = (short)758651419;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_60;
			default:
				num = (short)412942336;
				if (num != 0)
				{
				}
				message = global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("鳈ꗊ곌귎뷐뛒ꏖ뛘ﯚ규뻞鏠郢胤쟦鿨諪臬髮铰폲鏴藶雸雺\uddfc鳾搀漂椄", a_);
				return false;
			}
			IL_1BA:
			message = global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("諈껊ꇌꏎꗒ듔믖곘뻚﷜뛞鋠쏢诤鋦藨蟪", a_);
			return false;
			IL_1BF:
			return this.IsValid(value, out message);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000FF7C File Offset: 0x0000E17C
		public override bool IsValid(int value, out string message)
		{
			int a_ = 5;
			short num = (short)648937474;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)121430000;
				short num3 = num;
				num = (short)201580528;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)771424256;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)407764995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_152;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 3:
						if (value > base.MaxValue)
						{
							goto IL_EB;
						}
						goto IL_157;
					}
					IL_89:
					if (value >= base.MinValue)
					{
						num = (short)1030815744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				}
				IL_EB:
				num = (short)2093154305;
				if (num != 0)
				{
				}
				num = (short)292356096;
				short num4 = num;
				num = (short)1955069953;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A9:
			message = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("髋꿍볏ꟑ뇓ꏗꇛﻝ觟釡쓣觥鷧黩쳫臭雯틱蛳韵雷鷹駻", a_), value);
			return false;
			IL_152:
			goto IL_A9;
			IL_157:
			message = string.Empty;
			return true;
		}
	}
}
