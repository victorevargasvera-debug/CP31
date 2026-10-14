using System;
using System.Diagnostics;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000186 RID: 390
	internal abstract class FieldLayoutItemBase : global::Infragistics.Windows.DataPresenter.LayoutItem
	{
		// Token: 0x06001896 RID: 6294 RVA: 0x00072A66 File Offset: 0x00070C66
		protected FieldLayoutItemBase(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this.Field = field;
			this.IsLabel = isLabel;
			this.FieldForPositioning = field;
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00072A89 File Offset: 0x00070C89
		protected FieldLayoutItemBase(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase source)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this.Field = field;
			this.IsLabel = source.IsLabel;
			this.FieldForPositioning = source.Field;
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00072AB8 File Offset: 0x00070CB8
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

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x00072B18 File Offset: 0x00070D18
		public virtual global::Infragistics.Windows.DataPresenter.FixedFieldLocation FixedLocation
		{
			get
			{
				return this.Field.FixedLocation;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600189A RID: 6298
		public abstract global::Infragistics.Windows.DataPresenter.DataRecordSizingMode RecordSizingMode { get; }

		// Token: 0x0600189B RID: 6299
		internal abstract global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase Clone(global::Infragistics.Windows.DataPresenter.Field newField);

		// Token: 0x0600189C RID: 6300
		public abstract override void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type);

		// Token: 0x0600189D RID: 6301
		public abstract override void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type);

		// Token: 0x0600189E RID: 6302 RVA: 0x00072B25 File Offset: 0x00070D25
		protected void OnWidthChanged()
		{
			this.Field.BumpLayoutItemVersion();
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00072B32 File Offset: 0x00070D32
		protected void OnHeightChanged()
		{
			this.Field.BumpLayoutItemVersion();
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00072B40 File Offset: 0x00070D40
		internal static bool ShouldSynchronize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size, global::Infragistics.Windows.DataPresenter.Field field)
		{
			bool flag = global::Infragistics.Windows.DataPresenter.LayoutItem.IsWidth(size);
			return (flag && field.SyncCellLabelWidth) || (!flag && field.SyncCellLabelHeight);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00072B6C File Offset: 0x00070D6C
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

		// Token: 0x060018A2 RID: 6306 RVA: 0x00072C50 File Offset: 0x00070E50
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

		// Token: 0x060018A3 RID: 6307 RVA: 0x00072D20 File Offset: 0x00070F20
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

		// Token: 0x060018A4 RID: 6308 RVA: 0x00072D84 File Offset: 0x00070F84
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

		// Token: 0x060018A5 RID: 6309 RVA: 0x00072E34 File Offset: 0x00071034
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

		// Token: 0x060018A6 RID: 6310 RVA: 0x00072E9A File Offset: 0x0007109A
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal static void DebugSizeInfo(object value, string category)
		{
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00072E9C File Offset: 0x0007109C
		[global::System.Diagnostics.Conditional("DEBUG")]
		protected static void DebugItemSizeInfo(object value, string category)
		{
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00072E9E File Offset: 0x0007109E
		[global::System.Diagnostics.Conditional("DEBUG_SIZECHANGES")]
		private static void DebugSizeInfoImpl(object value, string category)
		{
		}

		// Token: 0x04000A20 RID: 2592
		public readonly global::Infragistics.Windows.DataPresenter.Field Field;

		// Token: 0x04000A21 RID: 2593
		public readonly global::Infragistics.Windows.DataPresenter.Field FieldForPositioning;

		// Token: 0x04000A22 RID: 2594
		public readonly bool IsLabel;
	}
}
