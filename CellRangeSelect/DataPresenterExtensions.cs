using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using Infragistics.Windows.DataPresenter;

namespace Motorola.CommonCPS.UI.CellRangeSelect
{
	// Token: 0x0200000E RID: 14
	public static class DataPresenterExtensions
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00009FD4 File Offset: 0x000081D4
		public static global::Infragistics.Windows.DataPresenter.Cell GetUnderlyingCell(this global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter, global::System.Windows.Point point)
		{
			short num = (short)1675034625;
			if (num != 0)
			{
			}
			num = (short)219136250;
			short num2 = num;
			num = (short)821739770;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BF;
			case 1:
				break;
			default:
			{
				num = (short)69074944;
				short num3 = num;
				break;
			}
			}
			num = (short)448790528;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.CellValuePresenter underlyingCellValuePresenter = dataPresenter.GetUnderlyingCellValuePresenter(point);
			if (underlyingCellValuePresenter != null)
			{
				return underlyingCellValuePresenter.Record.Cells[underlyingCellValuePresenter.Field];
			}
			IL_BF:
			return null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000A0A4 File Offset: 0x000082A4
		public static global::Infragistics.Windows.DataPresenter.CellValuePresenter GetUnderlyingCellValuePresenter(this global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter, global::System.Windows.Point point)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::System.Windows.Media.HitTestResult hitTestResult;
			short num2;
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_190;
				case 1:
				{
					global::System.Windows.DependencyObject dependencyObject = hitTestResult.VisualHit;
					num2 = (short)2077425665;
					if (num2 != 0)
					{
					}
					num2 = (short)2015952900;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_C5;
				case 3:
				{
					global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
					num2 = (short)1094516736;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_190;
				case 5:
					return cellValuePresenter;
				case 6:
				{
					global::System.Windows.DependencyObject dependencyObject;
					if (dependencyObject == null)
					{
						num2 = (short)1706491909;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					cellValuePresenter = (dependencyObject as global::Infragistics.Windows.DataPresenter.CellValuePresenter);
					num2 = (short)1449525255;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					if (cellValuePresenter == null)
					{
						num2 = (short)1801453571;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return cellValuePresenter;
				}
				goto IL_30;
				IL_190:
				num2 = (short)1719992326;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C5:
			if (hitTestResult != null)
			{
				goto IL_CB;
			}
			return cellValuePresenter;
			IL_30:
			num2 = (short)1919877420;
			short num3 = num2;
			num2 = (short)360317228;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CB:
				num2 = (short)20971521;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)1739063296;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)2066808832;
			if (num2 != 0)
			{
			}
			cellValuePresenter = null;
			hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(dataPresenter, point);
			num2 = (short)2128740354;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000A27C File Offset: 0x0000847C
		public static void SelectCellRange(this global::Infragistics.Windows.DataPresenter.DataRecordCollection records, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range)
		{
			int a_ = 2;
			short num = (short)1166016512;
			switch (num)
			{
			default:
			{
				num = (short)267255812;
				int num2 = (int)((global::System.IntPtr)num);
				global::Infragistics.Windows.DataPresenter.Cell[] array;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1CA;
					case 1:
						goto IL_194;
					case 2:
						goto IL_C1;
					case 3:
						goto IL_296;
					case 4:
						num = (short)1656029185;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_9E;
						}
						continue;
					case 5:
					{
						int num3;
						int height;
						if (num3 >= height)
						{
							num = (short)283181056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)824049664;
						short num4 = num;
						int num5;
						int startColumn;
						array[num3] = records[num5].Cells[startColumn];
						num5++;
						num3++;
						num = (short)2099904518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_194;
					case 7:
						num = (short)682557448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (range.Height == 0)
						{
							num = (short)1754333187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = new global::Infragistics.Windows.DataPresenter.Cell[range.Height];
						int num5 = range.StartRow;
						int startColumn = range.StartColumn;
						int height = range.Height;
						int num3 = 0;
						num = (short)1127118921;
						short num6 = num;
						num = (short)1504475209;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1079705600;
							if (num != 0)
							{
							}
							num = (short)166330369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						if (!range.IsEmpty)
						{
							num = (short)622854151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_9E:
					if (!range.IsSingleColumnRange)
					{
						num = (short)559808514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1336999945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_194:
					num = (short)303431685;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C1:
				throw new global::System.ArgumentException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("䰀瘂椄猆怈☊渌怎紐昒研礖㤘椚簜焞䘠䘢嘤ܦ䜨䐪夬༮䈰䘲䔴䜶嘸䤺䤼娾╀", a_), global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("猀戂欄怆氈", a_));
				IL_1CA:
				records.DataPresenter.SelectedItems.Cells.Clear();
				records.DataPresenter.SelectedItems.Cells.AddRange(array);
				return;
				IL_296:
				return;
			}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000A550 File Offset: 0x00008750
		public static global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange GetSelectionRange(this global::Infragistics.Windows.DataPresenter.SelectedCellCollection selectedCells)
		{
			short num = (short)324206592;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)760188398;
				short num3 = num;
				num = (short)2134150638;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_15C;
				default:
				{
					num = (short)2068709376;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 1:
						goto IL_15C;
					case 2:
						goto IL_EF;
					}
					IL_7A:
					num = (short)978780160;
					short num4 = num;
					if (selectedCells.Count == 0)
					{
						num = (short)1986723841;
						if (num != 0)
						{
						}
						num = (short)361037826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_12E:
				global::Infragistics.Windows.DataPresenter.Cell cell = selectedCells[0];
				global::Infragistics.Windows.DataPresenter.Cell cell2 = selectedCells[selectedCells.Count - 1];
				num = (short)1225916417;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15C:
				try
				{
					return new global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange(cell.Record.Index, cell2.Record.Index, cell.Field.Index, cell2.Field.Index);
				}
				catch
				{
					return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange.Empty;
				}
				goto IL_12E;
			}
			IL_EF:
			return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange.Empty;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000A6D4 File Offset: 0x000088D4
		public static global::System.Collections.Generic.List<int> GetSelectionIndexes(this global::Infragistics.Windows.DataPresenter.SelectedCellCollection selectedCells)
		{
			global::System.Collections.Generic.List<int> list;
			short num;
			for (;;)
			{
				list = new global::System.Collections.Generic.List<int>();
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator = selectedCells.GetEnumerator();
				try
				{
					num = (short)970784768;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_48;
							}
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1188495363;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.Cell cell = enumerator.Current;
							list.Add(cell.Record.Index);
							num = (short)1186463748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_C1;
						case 3:
							num = (short)976486402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_78:
						num = (short)357433345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_48:
						goto IL_78;
					}
					IL_C1:;
				}
				finally
				{
					num = (short)822870016;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							continue;
						case 1:
							goto IL_12A;
						case 2:
							enumerator.Dispose();
							num = (short)2017525761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_F4:
						if (enumerator == null)
						{
							break;
						}
						num = (short)416677890;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_12A:;
				}
				num = (short)1454702592;
				short num3 = num;
				num = (short)286731265;
				short num4 = num;
				num = (short)1275866113;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_18B;
				}
			}
			IL_18B:
			num = (short)1311506433;
			if (num != 0)
			{
			}
			num = (short)206766080;
			if (num != 0)
			{
			}
			return list;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000A8BC File Offset: 0x00008ABC
		public static global::System.Windows.Rect GetBounds(this global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			short num = (short)966105195;
			short num2 = num;
			num = (short)76978283;
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1397948416;
				short num3 = num;
				num = (short)560988161;
				if (num != 0)
				{
				}
				num = (short)1467744256;
				if (num != 0)
				{
				}
				cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(cell);
				if (cellValuePresenter == null)
				{
					return global::System.Windows.Rect.Empty;
				}
				break;
			}
			}
			return cellValuePresenter.GetBounds();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000A97C File Offset: 0x00008B7C
		public static global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition GetCellPosition(this global::Infragistics.Windows.DataPresenter.CellValuePresenter presenter)
		{
			short num = (short)1597287903;
			short num2 = num;
			num = (short)42970591;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1358168064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)388235265;
			if (num != 0)
			{
			}
			num = (short)136577024;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition(presenter.Record.Index, presenter.Field.Index);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000AA40 File Offset: 0x00008C40
		public static global::System.Windows.Rect GetBounds(this global::Infragistics.Windows.DataPresenter.CellValuePresenter presenter)
		{
			short num = (short)1723372864;
			short num2 = num;
			num = (short)1988728128;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1826750464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)361103360;
			if (num != 0)
			{
			}
			num = (short)308150273;
			if (num != 0)
			{
			}
			global::System.Windows.Rect descendantBounds = global::System.Windows.Media.VisualTreeHelper.GetDescendantBounds(presenter);
			global::System.Windows.Point point = presenter.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), presenter.DataPresenter);
			descendantBounds.Offset(point.X, point.Y);
			return descendantBounds;
		}
	}
}
