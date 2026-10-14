using System;
using System.Collections.Generic;
using System.Linq;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Selection;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls.UiHelpers
{
	// Token: 0x02000128 RID: 296
	public static class ExtensionMethods
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x000982D4 File Offset: 0x000964D4
		public static global::System.Collections.Generic.IEnumerable<T> GetDataItemsFromSelectedCellsOrRecords<T>(this global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder itemHolder) where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			short num = (short)358350848;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			int num3;
			global::System.Collections.Generic.List<T> list;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					if (itemHolder.Cells.Count > 0)
					{
						num = (short)532152322;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)402849796;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return list;
				case 2:
				{
					num = (short)897167867;
					short num4 = num;
					num = (short)822850043;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)633536512;
						if (num != 0)
						{
						}
						num = (short)641335299;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					list.AddRange(itemHolder.Cells.Cast<global::Infragistics.Windows.DataPresenter.Cell>().Where(new global::System.Func<global::Infragistics.Windows.DataPresenter.Cell, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.ExtensionMethods.<>c__0<T>.<>9.a)).Select(new global::System.Func<global::Infragistics.Windows.DataPresenter.Cell, T>(global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.ExtensionMethods.<>c__0<T>.<>9.b)).Distinct<T>());
					num = (short)1274478593;
					if (num != 0)
					{
					}
					num = (short)1625620481;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					list.AddRange(itemHolder.Cast<global::Infragistics.Windows.DataPresenter.DataRecord>().Where(new global::System.Func<global::Infragistics.Windows.DataPresenter.DataRecord, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.ExtensionMethods.<>c__0<T>.<>9.a)).Select(new global::System.Func<global::Infragistics.Windows.DataPresenter.DataRecord, T>(global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.ExtensionMethods.<>c__0<T>.<>9.b)));
					num = (short)323944453;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return list;
				}
				goto IL_51;
			}
			return list;
			IL_51:
			list = new global::System.Collections.Generic.List<T>();
			num = (short)605159424;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0009850C File Offset: 0x0009670C
		public static void FocusActiveItem(this global::Infragistics.Windows.DataPresenter.DataPresenterBase dpBase)
		{
			short num = (short)684261378;
			int num2 = (int)((global::System.IntPtr)num);
			global::Infragistics.Windows.DataPresenter.Cell cell;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (dpBase.SelectedItems.Any<global::Infragistics.Windows.Selection.ISelectableItem>())
					{
						num = (short)1633681415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_1F0;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 3:
					return;
				case 4:
				{
					num = (short)220592828;
					short num3 = num;
					num = (short)1127676604;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14A;
					default:
					{
						num = (short)1209270272;
						if (num != 0)
						{
						}
						num = (short)952893440;
						short num4 = num;
						if (cell != null)
						{
							num = (short)1515585537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 5:
					num = (short)153681928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					global::Infragistics.Windows.DataPresenter.Record record = dpBase.SelectedItems.Cast<global::Infragistics.Windows.DataPresenter.Record>().FirstOrDefault(new global::System.Func<global::Infragistics.Windows.DataPresenter.Record, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.ExtensionMethods.<>c.<>9.a));
					num = (short)1833500681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					num = (short)1791688710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					cell = dpBase.SelectedItems.Cast<global::Infragistics.Windows.DataPresenter.Cell>().FirstOrDefault(new global::System.Func<global::Infragistics.Windows.DataPresenter.Cell, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.ExtensionMethods.<>c.<>9.a));
					goto IL_14A;
				case 9:
				{
					global::Infragistics.Windows.DataPresenter.Record record;
					if (record != null)
					{
						num = (short)1249771530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 10:
				{
					global::Infragistics.Windows.DataPresenter.Record record;
					global::Infragistics.Windows.DataPresenter.RecordPresenter.FromRecord(record).Focus();
					num = (short)448921603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_50:
				num = (short)1795620865;
				if (num != 0)
				{
				}
				if (dpBase.SelectedItems.Cells.Count > 0)
				{
					num = (short)1967194117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)852951040;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A:
				num = (short)616235012;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F0:
			global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(cell).Focus();
		}
	}
}
