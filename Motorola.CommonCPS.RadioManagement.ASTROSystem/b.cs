using System;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x02000005 RID: 5
	internal class b : global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000025EC File Offset: 0x000007EC
		public bool CanEdit(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			int a_ = 0;
			short num = (short)2020737028;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool result;
				switch (num2)
				{
				case 0:
					goto IL_153;
				case 1:
					goto IL_5D;
				case 2:
				{
					num = (short)795803648;
					short num3 = num;
					num = (short)594838539;
					short num4 = num;
					num = (short)1106084875;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_153;
					default:
						num = (short)507838464;
						if (num != 0)
						{
						}
						if (cell.Field.Name == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("삑햛\uda9d", a_))
						{
							num = (short)977338368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)711852033;
						if (num != 0)
						{
						}
						num = (short)484769795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					return result;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 5:
					return result;
				}
				IL_46:
				if (cell == null)
				{
					num = (short)118751233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem astroSystem = cell.Record.DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem;
				num = (short)955318274;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_153:
				result = astroSystem.IsRadioIDEditable;
				num = (short)586416133;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5D:
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("歹", a_));
		}
	}
}
