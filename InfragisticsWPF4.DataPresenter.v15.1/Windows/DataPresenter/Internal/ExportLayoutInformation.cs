using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x02000306 RID: 774
	public class ExportLayoutInformation
	{
		// Token: 0x06002567 RID: 9575 RVA: 0x000A60C8 File Offset: 0x000A42C8
		public ExportLayoutInformation(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool header)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout, "fieldLayout");
			this._header = header;
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

		// Token: 0x06002568 RID: 9576 RVA: 0x000A62EC File Offset: 0x000A44EC
		public double[] GetColumnWidths()
		{
			return this._columnWidths;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x000A62F4 File Offset: 0x000A44F4
		public double[] GetRowHeights()
		{
			return this._rowHeights;
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x000A62FC File Offset: 0x000A44FC
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

		// Token: 0x0600256B RID: 9579 RVA: 0x000A6338 File Offset: 0x000A4538
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

		// Token: 0x0600256C RID: 9580 RVA: 0x000A63A8 File Offset: 0x000A45A8
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

		// Token: 0x0600256D RID: 9581 RVA: 0x000A63E4 File Offset: 0x000A45E4
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

		// Token: 0x0600256E RID: 9582 RVA: 0x000A644C File Offset: 0x000A464C
		private static bool IsZero(double dbl)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(0.0, dbl);
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x000A6460 File Offset: 0x000A4660
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

		// Token: 0x040012A2 RID: 4770
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040012A3 RID: 4771
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FieldPosition> _labelPositions;

		// Token: 0x040012A4 RID: 4772
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FieldPosition> _cellPositions;

		// Token: 0x040012A5 RID: 4773
		private double[] _columnWidths;

		// Token: 0x040012A6 RID: 4774
		private double[] _rowHeights;

		// Token: 0x040012A7 RID: 4775
		internal readonly bool _header;
	}
}
