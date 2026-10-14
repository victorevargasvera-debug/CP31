using System;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000005 RID: 5
	public class CellEditabilityResolver : global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000026EC File Offset: 0x000008EC
		public bool CanEdit(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			int a_ = 10;
			short num = (short)1835597829;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile astrootarProfile;
				switch (num2)
				{
				case 0:
				{
					if (cell.Field.Name == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᑚ⥜㹞፠⩢Ⅴ", a_))
					{
						num = (short)343932932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					bool result = false;
					num = (short)1509097472;
					short num3 = num;
					num = (short)1624371054;
					short num4 = num;
					num = (short)1304620910;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48;
					default:
						num = (short)1860763648;
						if (num != 0)
						{
						}
						num = (short)1080164353;
						if (num != 0)
						{
						}
						num = (short)262209539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
				{
					bool result;
					return result;
				}
				case 2:
					goto IL_5D;
				case 3:
				{
					bool result;
					return result;
				}
				case 4:
				{
					bool result = astrootarProfile.IsOtarIDEditable;
					num = (short)1469710337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				goto IL_45;
				IL_48:
				num = (short)2119499778;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45:
				if (cell == null)
				{
					goto IL_48;
				}
				astrootarProfile = (cell.Record.DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile);
				num = (short)953810944;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5D:
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("㡚㡜㍞ൠ", a_));
		}
	}
}
