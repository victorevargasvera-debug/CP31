using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x020002C7 RID: 711
	public class ExportLayoutInformation
	{
		// Token: 0x060021D3 RID: 8659 RVA: 0x00092FE4 File Offset: 0x000911E4
		public ExportLayoutInformation(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool header)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout, "fieldLayout");
			this._fieldLayout = fieldLayout;
			fieldLayout.TemplateDataRecordCache.Verify();
			global::Infragistics.Windows.DataPresenter.LayoutManagerType type = header ? global::Infragistics.Windows.DataPresenter.LayoutManagerType.Header : global::Infragistics.Windows.DataPresenter.LayoutManagerType.Record;
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = global::Infragistics.Windows.DataPresenter.GridUtilities.CreateGridBagLayoutManager(fieldLayout, type);
			fieldGridBagLayoutManager.VerifyLayout();
			fieldGridBagLayoutManager.CalculatePreferredSize();
			this._columnWidths = (fieldGridBagLayoutManager.ColumnWidths ?? new double[0]);
			this._rowHeights = (fieldGridBagLayoutManager.RowHeights ?? new double[0]);
			this._cellPositions = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FieldPosition>();
			this._labelPositions = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FieldPosition>();
			int[] deltas = global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation.GetDeltas(this._columnWidths);
			int[] deltas2 = global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation.GetDeltas(this._rowHeights);
			new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase, global::Infragistics.Windows.DataPresenter.FieldPosition>();
			if (fieldLayout.HasStarFields(true))
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase dataPresenterExportControlBase = fieldLayout.DataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase;
				if (dataPresenterExportControlBase != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase sourceDataPresenter = dataPresenterExportControlBase.SourceDataPresenter;
					if (sourceDataPresenter != null)
					{
						global::Infragistics.Windows.DataPresenter.FieldRectsLayoutContainer layoutContainer = new global::Infragistics.Windows.DataPresenter.FieldRectsLayoutContainer();
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection layoutItemDimensionsCached = fieldGridBagLayoutManager.GetLayoutItemDimensionsCached(layoutContainer, new global::System.Windows.Rect(sourceDataPresenter.RenderSize));
						double[] columnDims = layoutItemDimensionsCached.ColumnDims;
						for (int i = 1; i < columnDims.Length; i++)
						{
							this._columnWidths[i - 1] = columnDims[i] - columnDims[i - 1];
						}
					}
				}
			}
			foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)fieldGridBagLayoutManager.LayoutItems))
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = layoutItem as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase;
				if (fieldLayoutItemBase != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = fieldLayoutItemBase.Field;
					global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gc = (global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)fieldGridBagLayoutManager.LayoutItems.GetConstraint(layoutItem);
					if (layoutItem.Visibility != global::System.Windows.Visibility.Collapsed)
					{
						global::Infragistics.Windows.DataPresenter.FieldPosition? position = global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation.GetPosition(gc, ref this._columnWidths, ref this._rowHeights, ref deltas, ref deltas2);
						if (position != null)
						{
							if (fieldLayoutItemBase.IsLabel)
							{
								this._labelPositions[field] = position.Value;
							}
							else
							{
								this._cellPositions[field] = position.Value;
							}
						}
					}
				}
			}
			this._columnWidths = this.RemoveZeroWidths(this._columnWidths);
			this._rowHeights = this.RemoveZeroWidths(this._rowHeights);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00093200 File Offset: 0x00091400
		public double[] GetColumnWidths()
		{
			return this._columnWidths;
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00093208 File Offset: 0x00091408
		public double[] GetRowHeights()
		{
			return this._rowHeights;
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00093210 File Offset: 0x00091410
		public global::Infragistics.Windows.DataPresenter.FieldPosition? GetFieldPosition(global::Infragistics.Windows.DataPresenter.Field field, bool label)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FieldPosition> dictionary = label ? this._labelPositions : this._cellPositions;
			global::Infragistics.Windows.DataPresenter.FieldPosition value;
			if (!dictionary.TryGetValue(field, out value))
			{
				return null;
			}
			return new global::Infragistics.Windows.DataPresenter.FieldPosition?(value);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0009324C File Offset: 0x0009144C
		private static bool AdjustOriginAndSpan(ref int origin, ref int span, ref double[] extents, ref int[] deltas)
		{
			if (span <= 0)
			{
				return false;
			}
			int i = origin;
			int num = global::System.Math.Min(extents.Length, origin + span);
			while (i < num)
			{
				if (global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation.IsZero(extents[i]))
				{
					if (i == origin)
					{
						origin++;
					}
					span--;
					if (span <= 0)
					{
						return false;
					}
				}
				i++;
			}
			int num2 = (origin >= 0 && origin < deltas.Length) ? deltas[origin] : 0;
			origin += num2;
			return true;
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x000932BC File Offset: 0x000914BC
		private static int[] GetDeltas(double[] extents)
		{
			int num = 0;
			int[] array = new int[extents.Length];
			for (int i = 0; i < extents.Length; i++)
			{
				if (global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation.IsZero(extents[i]))
				{
					num--;
				}
				array[i] = num;
			}
			return array;
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000932F8 File Offset: 0x000914F8
		private static global::Infragistics.Windows.DataPresenter.FieldPosition? GetPosition(global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gc, ref double[] columns, ref double[] rows, ref int[] colDeltas, ref int[] rowDeltas)
		{
			int column = gc.Column;
			int row = gc.Row;
			int columnSpan = gc.ColumnSpan;
			int rowSpan = gc.RowSpan;
			if (!global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation.AdjustOriginAndSpan(ref column, ref columnSpan, ref columns, ref colDeltas))
			{
				return null;
			}
			if (!global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation.AdjustOriginAndSpan(ref row, ref rowSpan, ref rows, ref rowDeltas))
			{
				return null;
			}
			return new global::Infragistics.Windows.DataPresenter.FieldPosition?(new global::Infragistics.Windows.DataPresenter.FieldPosition(column, row, columnSpan, rowSpan));
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00093360 File Offset: 0x00091560
		private static bool IsZero(double dbl)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(0.0, dbl);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00093374 File Offset: 0x00091574
		private double[] RemoveZeroWidths(double[] extents)
		{
			global::System.Collections.Generic.List<double> list = new global::System.Collections.Generic.List<double>();
			foreach (double num in extents)
			{
				if (!global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation.IsZero(num))
				{
					list.Add(num);
				}
			}
			return list.ToArray();
		}

		// Token: 0x0400108F RID: 4239
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04001090 RID: 4240
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FieldPosition> _labelPositions;

		// Token: 0x04001091 RID: 4241
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FieldPosition> _cellPositions;

		// Token: 0x04001092 RID: 4242
		private double[] _columnWidths;

		// Token: 0x04001093 RID: 4243
		private double[] _rowHeights;
	}
}
