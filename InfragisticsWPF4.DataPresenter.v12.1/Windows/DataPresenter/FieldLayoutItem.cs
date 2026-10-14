using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200016B RID: 363
	internal class FieldLayoutItem : global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
	{
		// Token: 0x0600152F RID: 5423 RVA: 0x00060EC4 File Offset: 0x0005F0C4
		internal FieldLayoutItem(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel) : base(field, isLabel)
		{
			this._sizes = new double[6];
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x00060EE1 File Offset: 0x0005F0E1
		internal global::Infragistics.Windows.DataPresenter.GridBagConstraint CellPresenterConstraint
		{
			get
			{
				if (this._gc == null)
				{
					this._gc = new global::Infragistics.Windows.DataPresenter.GridBagConstraint();
					this.InitializeGC();
				}
				this.VerifyVersion();
				return this._gc;
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00060F08 File Offset: 0x0005F108
		internal static void AdjustPositionForCellPresenter(global::Infragistics.Windows.DataPresenter.CellContentAlignment alignment, bool isLabel, ref int column, ref int row, ref int rowSpan, ref int columnSpan, ref global::System.Windows.Thickness margin)
		{
			column *= 2;
			row *= 2;
			switch (alignment)
			{
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly:
				rowSpan *= 2;
				columnSpan *= 2;
				return;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignLeft:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignCenter:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignRight:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch:
				columnSpan *= 2;
				if (!isLabel)
				{
					row += rowSpan;
				}
				if (isLabel)
				{
					margin.Bottom = 0.0;
					return;
				}
				margin.Top = 0.0;
				return;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignLeft:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignCenter:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignRight:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueStretch:
				columnSpan *= 2;
				if (isLabel)
				{
					row += rowSpan;
				}
				if (isLabel)
				{
					margin.Top = 0.0;
					return;
				}
				margin.Bottom = 0.0;
				return;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignTop:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignMiddle:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignBottom:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueStretch:
				rowSpan *= 2;
				if (!isLabel)
				{
					column += columnSpan;
				}
				if (isLabel)
				{
					margin.Right = 0.0;
					return;
				}
				margin.Left = 0.0;
				return;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignTop:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignMiddle:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignBottom:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueStretch:
				rowSpan *= 2;
				if (isLabel)
				{
					column += columnSpan;
				}
				if (isLabel)
				{
					margin.Left = 0.0;
					return;
				}
				margin.Right = 0.0;
				return;
			default:
				return;
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0006105E File Offset: 0x0005F25E
		private double GetDefaultSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size)
		{
			if (global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.ShouldSynchronize(size, this.Field))
			{
				return global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetSynchronizedSize(size, this.Field);
			}
			if (this.IsLabel)
			{
				return global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetDefaultLabelSize(size, this.Field);
			}
			return global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetDefaultCellSize(size, this.Field);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0006109C File Offset: 0x0005F29C
		internal void VerifyVersion()
		{
			int layoutItemVersion = this.Field.LayoutItemVersion;
			if (this._version != layoutItemVersion)
			{
				this.VerifyVersionImpl(layoutItemVersion);
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000610C8 File Offset: 0x0005F2C8
		private void VerifyVersionImpl(int fieldVersion)
		{
			this._version = fieldVersion;
			for (int i = 0; i < 6; i++)
			{
				this._sizes[i] = this.GetDefaultSize((global::Infragistics.Windows.DataPresenter.LayoutItemSize)i);
			}
			this._sizeTypeHeight = this.Field.GetResizeSize(this.IsLabel, false).Type;
			this._sizeTypeWidth = this.Field.GetResizeSize(this.IsLabel, true).Type;
			double val = 6.0;
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Field.Owner;
			bool flag = owner != null && owner.UseCellPresenters;
			if (this.IsLabel && flag)
			{
				val = 0.0;
			}
			this._sizes[0] = global::System.Math.Min(this._sizes[2], global::System.Math.Max(val, this._sizes[0]));
			this._sizes[3] = global::System.Math.Min(this._sizes[5], global::System.Math.Max(val, this._sizes[3]));
			this._visibility = (this.Field.IsVisibleInCellArea ? this.Field.VisibilityResolved : global::System.Windows.Visibility.Collapsed);
			if (this._gc != null)
			{
				this.InitializeGC();
			}
			if (this._visibility != global::System.Windows.Visibility.Collapsed)
			{
				global::System.Windows.Visibility visibility = flag ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Hidden;
				bool flag2 = false;
				switch (this.Field.CellContentAlignmentResolved)
				{
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly:
					if (!this.IsLabel)
					{
						this._visibility = visibility;
						flag2 = true;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly:
					if (this.IsLabel)
					{
						this._visibility = visibility;
						flag2 = true;
					}
					break;
				}
				if (owner != null && flag2 && this._visibility == global::System.Windows.Visibility.Hidden)
				{
					if (!owner.IsHorizontal)
					{
						this._sizes[3] = 0.0;
						this._sizes[4] = 0.0;
						this._sizes[5] = double.PositiveInfinity;
						return;
					}
					this._sizes[0] = 0.0;
					this._sizes[1] = 0.0;
					this._sizes[2] = double.PositiveInfinity;
				}
			}
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000612C0 File Offset: 0x0005F4C0
		private void InitializeGC()
		{
			if (this._gc != null)
			{
				global::Infragistics.Windows.DataPresenter.GridBagConstraint layoutConstraint = this.Field.LayoutConstraint;
				int column = layoutConstraint.Column;
				int row = layoutConstraint.Row;
				int rowSpan = layoutConstraint.RowSpan;
				int columnSpan = layoutConstraint.ColumnSpan;
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Field.Owner;
				global::System.Windows.Thickness margin = (owner != null) ? owner.TemplateDataRecordCache.GetCellPresenterMargin(this.Field) : default(global::System.Windows.Thickness);
				global::Infragistics.Windows.DataPresenter.FieldLayoutItem.AdjustPositionForCellPresenter(this.Field.CellContentAlignmentResolved, this.IsLabel, ref column, ref row, ref rowSpan, ref columnSpan, ref margin);
				this._gc.Column = column;
				this._gc.Row = row;
				this._gc.RowSpan = rowSpan;
				this._gc.ColumnSpan = columnSpan;
				this._gc.Margin = margin;
				global::Infragistics.Windows.DataPresenter.AutoFitMode autoFitMode = (owner != null) ? owner.AutoFitModeResolved : global::Infragistics.Windows.DataPresenter.AutoFitMode.Never;
				this._gc.ColumnWeight = this.Field.GetAutoFitWeight(!this.IsLabel, true, autoFitMode);
				this._gc.RowWeight = this.Field.GetAutoFitWeight(!this.IsLabel, false, autoFitMode);
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000613E4 File Offset: 0x0005F5E4
		public sealed override double GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size)
		{
			this.VerifyVersion();
			return this._sizes[(int)size];
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000613F4 File Offset: 0x0005F5F4
		protected override global::System.Windows.Visibility GetVisibility()
		{
			this.VerifyVersion();
			return this._visibility;
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x00061402 File Offset: 0x0005F602
		public override global::Infragistics.Windows.DataPresenter.DataRecordSizingMode RecordSizingMode
		{
			get
			{
				return this.Field.Owner.DataRecordSizingModeResolved;
			}
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00061414 File Offset: 0x0005F614
		public override void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this._sizes[4] = value;
			bool syncCellLabelHeight = this.Field.SyncCellLabelHeight;
			global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo explicitResizeInfo = this.Field.ExplicitResizeInfo;
			if (this.IsLabel || syncCellLabelHeight)
			{
				explicitResizeInfo.SetSize(true, false, new global::Infragistics.Windows.DataPresenter.FieldSize(value, type));
			}
			if (!this.IsLabel || syncCellLabelHeight)
			{
				explicitResizeInfo.SetSize(false, false, new global::Infragistics.Windows.DataPresenter.FieldSize(value, type));
			}
			base.OnHeightChanged();
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0006147C File Offset: 0x0005F67C
		public override void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this._sizes[1] = value;
			bool syncCellLabelWidth = this.Field.SyncCellLabelWidth;
			global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo explicitResizeInfo = this.Field.ExplicitResizeInfo;
			if (this.IsLabel || syncCellLabelWidth)
			{
				explicitResizeInfo.SetSize(true, true, new global::Infragistics.Windows.DataPresenter.FieldSize(value, type));
			}
			if (!this.IsLabel || syncCellLabelWidth)
			{
				explicitResizeInfo.SetSize(false, true, new global::Infragistics.Windows.DataPresenter.FieldSize(value, type));
			}
			base.OnWidthChanged();
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x000614E4 File Offset: 0x0005F6E4
		public override global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeHeight
		{
			get
			{
				this.VerifyVersion();
				return this._sizeTypeHeight;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000614F2 File Offset: 0x0005F6F2
		public override global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeWidth
		{
			get
			{
				this.VerifyVersion();
				return this._sizeTypeWidth;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x00061500 File Offset: 0x0005F700
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
		{
			get
			{
				return this.CellPresenterConstraint.Column;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0006150D File Offset: 0x0005F70D
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
		{
			get
			{
				return this.CellPresenterConstraint.ColumnSpan;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x0006151A File Offset: 0x0005F71A
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
		{
			get
			{
				return this.CellPresenterConstraint.ColumnWeight;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00061527 File Offset: 0x0005F727
		global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
		{
			get
			{
				return this.CellPresenterConstraint.HorizontalAlignment;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00061534 File Offset: 0x0005F734
		global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
		{
			get
			{
				return this.CellPresenterConstraint.Margin;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00061541 File Offset: 0x0005F741
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
		{
			get
			{
				return this.CellPresenterConstraint.Row;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0006154E File Offset: 0x0005F74E
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
		{
			get
			{
				return this.CellPresenterConstraint.RowSpan;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0006155B File Offset: 0x0005F75B
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
		{
			get
			{
				return this.CellPresenterConstraint.RowWeight;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x00061568 File Offset: 0x0005F768
		global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
		{
			get
			{
				return this.CellPresenterConstraint.VerticalAlignment;
			}
		}

		// Token: 0x0400086D RID: 2157
		internal const int CellPresenterFactor = 2;

		// Token: 0x0400086E RID: 2158
		internal const int MinimumExtent = 6;

		// Token: 0x0400086F RID: 2159
		private double[] _sizes;

		// Token: 0x04000870 RID: 2160
		private int _version = -1;

		// Token: 0x04000871 RID: 2161
		private global::System.Windows.Visibility _visibility;

		// Token: 0x04000872 RID: 2162
		private global::Infragistics.Windows.DataPresenter.GridBagConstraint _gc;

		// Token: 0x04000873 RID: 2163
		private global::Infragistics.Windows.DataPresenter.ItemSizeType _sizeTypeWidth;

		// Token: 0x04000874 RID: 2164
		private global::Infragistics.Windows.DataPresenter.ItemSizeType _sizeTypeHeight;
	}
}
