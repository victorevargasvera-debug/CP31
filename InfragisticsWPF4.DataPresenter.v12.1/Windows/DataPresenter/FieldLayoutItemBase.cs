using System;
using System.Diagnostics;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200016A RID: 362
	internal abstract class FieldLayoutItemBase : global::Infragistics.Windows.DataPresenter.LayoutItem
	{
		// Token: 0x0600151E RID: 5406 RVA: 0x00060ABE File Offset: 0x0005ECBE
		protected FieldLayoutItemBase(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this.Field = field;
			this.IsLabel = isLabel;
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00060ADC File Offset: 0x0005ECDC
		public override string ToString()
		{
			return string.Format("Field={0}, IsLabel={1}, Fixed={2}, SizeTypeW={3}, SizeTypeH={4}", new object[]
			{
				this.Field,
				this.IsLabel,
				this.FixedLocation,
				this.SizeTypeWidth,
				this.SizeTypeHeight
			});
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x00060B3C File Offset: 0x0005ED3C
		public virtual global::Infragistics.Windows.DataPresenter.FixedFieldLocation FixedLocation
		{
			get
			{
				return this.Field.FixedLocation;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001521 RID: 5409
		public abstract global::Infragistics.Windows.DataPresenter.DataRecordSizingMode RecordSizingMode { get; }

		// Token: 0x06001522 RID: 5410
		public abstract override void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type);

		// Token: 0x06001523 RID: 5411
		public abstract override void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type);

		// Token: 0x06001524 RID: 5412 RVA: 0x00060B49 File Offset: 0x0005ED49
		protected void OnWidthChanged()
		{
			this.Field.BumpLayoutItemVersion();
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00060B56 File Offset: 0x0005ED56
		protected void OnHeightChanged()
		{
			this.Field.BumpLayoutItemVersion();
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00060B64 File Offset: 0x0005ED64
		internal static bool ShouldSynchronize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size, global::Infragistics.Windows.DataPresenter.Field field)
		{
			bool flag = global::Infragistics.Windows.DataPresenter.LayoutItem.IsWidth(size);
			return (flag && field.SyncCellLabelWidth) || (!flag && field.SyncCellLabelHeight);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00060B90 File Offset: 0x0005ED90
		internal static double CombineValues(bool sameColumn, global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase labelLayoutItem, global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase cellLayoutItem, global::Infragistics.Windows.DataPresenter.LayoutItemSize size)
		{
			double num = labelLayoutItem.GetSize(size);
			double size2 = cellLayoutItem.GetSize(size);
			bool flag = false;
			if (global::Infragistics.Windows.DataPresenter.LayoutItem.IsWidth(size))
			{
				flag = true;
			}
			else
			{
				size -= 3;
			}
			switch (size)
			{
			default:
				if (sameColumn != flag)
				{
					int num2 = flag ? 0 : 3;
					double size3 = labelLayoutItem.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxWidth + num2);
					double size4 = labelLayoutItem.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth + num2);
					num = global::System.Math.Max(num, global::System.Math.Min(size3, size4));
					return num + size2;
				}
				return global::System.Math.Max(num, size2);
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth:
			{
				if (sameColumn != flag)
				{
					return num + size2;
				}
				global::Infragistics.Windows.DataPresenter.LayoutItemSize size5 = flag ? global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxWidth : global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxHeight;
				return global::System.Math.Min(cellLayoutItem.GetSize(size5), global::System.Math.Min(labelLayoutItem.GetSize(size5), global::System.Math.Max(num, size2)));
			}
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxWidth:
				if (sameColumn == flag)
				{
					return global::System.Math.Min(num, size2);
				}
				if (double.IsPositiveInfinity(num) || double.IsPositiveInfinity(size2))
				{
					return double.PositiveInfinity;
				}
				return num + size2;
			}
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00060C74 File Offset: 0x0005EE74
		internal static double GetSynchronizedSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.LayoutItemSize layoutItemSize = size;
			bool flag = false;
			if (global::Infragistics.Windows.DataPresenter.LayoutItem.IsWidth(size))
			{
				flag = true;
			}
			else
			{
				layoutItemSize -= 3;
			}
			global::Infragistics.Windows.DataPresenter.LayoutItemSize size2 = flag ? global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinWidth : global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinHeight;
			double num = global::System.Math.Max(global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetDefaultLabelSize(size2, field), global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetDefaultCellSize(size2, field));
			global::Infragistics.Windows.DataPresenter.LayoutItemSize size3 = flag ? global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxWidth : global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxHeight;
			double num2 = global::System.Math.Min(global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetDefaultLabelSize(size3, field), global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetDefaultCellSize(size3, field));
			num = global::System.Math.Min(num2, global::System.Math.Max(6.0, num));
			if (layoutItemSize == global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinWidth)
			{
				return num;
			}
			if (layoutItemSize == global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxWidth)
			{
				return global::System.Math.Max(num2, num);
			}
			double defaultCellSize = global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetDefaultCellSize(size, field);
			double defaultLabelSize = global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetDefaultLabelSize(size, field);
			double val;
			if (double.IsNaN(defaultCellSize))
			{
				val = defaultLabelSize;
			}
			else if (double.IsNaN(defaultLabelSize))
			{
				val = defaultCellSize;
			}
			else
			{
				val = global::System.Math.Max(defaultLabelSize, defaultCellSize);
			}
			return global::System.Math.Max(global::System.Math.Min(val, num2), num);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00060D44 File Offset: 0x0005EF44
		internal static double GetDefaultCellSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size, global::Infragistics.Windows.DataPresenter.Field field)
		{
			switch (size)
			{
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinWidth:
				return field.CellMinWidthResolved;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth:
				return field.GetCellWidthResolvedHelper(true);
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxWidth:
				return field.CellMaxWidthResolved;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinHeight:
				return field.CellMinHeightResolved;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight:
				return field.GetCellHeightResolvedHelper(true);
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxHeight:
				return field.CellMaxHeightResolved;
			default:
				return double.NaN;
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00060DA8 File Offset: 0x0005EFA8
		internal static double GetDefaultCellPresenterSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (owner != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutItem labelLayoutItem = field.LabelLayoutItem;
				global::Infragistics.Windows.DataPresenter.FieldLayoutItem cellLayoutItem = field.CellLayoutItem;
				switch (field.CellContentAlignmentResolved)
				{
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly:
					return labelLayoutItem.GetSize(size);
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly:
					return cellLayoutItem.GetSize(size);
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignLeft:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignCenter:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignRight:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignLeft:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignCenter:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignRight:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueStretch:
					return global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.CombineValues(true, labelLayoutItem, cellLayoutItem, size);
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignTop:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignMiddle:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignBottom:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueStretch:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignTop:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignMiddle:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignBottom:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueStretch:
					return global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.CombineValues(false, labelLayoutItem, cellLayoutItem, size);
				}
			}
			return double.NaN;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00060E58 File Offset: 0x0005F058
		internal static double GetDefaultLabelSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size, global::Infragistics.Windows.DataPresenter.Field field)
		{
			switch (size)
			{
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinWidth:
				return field.LabelMinWidthResolved;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth:
				return field.GetLabelWidthResolvedHelper(true, true);
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxWidth:
				return field.LabelMaxWidthResolved;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinHeight:
				return field.LabelMinHeightResolved;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight:
				return field.GetLabelHeightResolvedHelper(true, true);
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxHeight:
				return field.LabelMaxHeightResolved;
			default:
				return double.NaN;
			}
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00060EBE File Offset: 0x0005F0BE
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal static void DebugSizeInfo(object value, string category)
		{
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00060EC0 File Offset: 0x0005F0C0
		[global::System.Diagnostics.Conditional("DEBUG")]
		protected static void DebugItemSizeInfo(object value, string category)
		{
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00060EC2 File Offset: 0x0005F0C2
		[global::System.Diagnostics.Conditional("DEBUG_SIZECHANGES")]
		private static void DebugSizeInfoImpl(object value, string category)
		{
		}

		// Token: 0x0400086B RID: 2155
		public readonly global::Infragistics.Windows.DataPresenter.Field Field;

		// Token: 0x0400086C RID: 2156
		public readonly bool IsLabel;
	}
}
