using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000187 RID: 391
	internal class FieldLayoutItem : global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
	{
		// Token: 0x060018A9 RID: 6313 RVA: 0x00072EA0 File Offset: 0x000710A0
		internal FieldLayoutItem(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel) : base(field, isLabel)
		{
			this._sizes = new double[6];
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00072EC0 File Offset: 0x000710C0
		private FieldLayoutItem(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldLayoutItem source) : base(field, source)
		{
			this._sizes = new double[source._sizes.Length];
			source._sizes.CopyTo(this._sizes, 0);
			this._version = source._version;
			this._visibility = source._visibility;
			this._gc = source._gc;
			this._sizeTypeWidth = source._sizeTypeWidth;
			this._sizeTypeHeight = source._sizeTypeHeight;
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00072F3D File Offset: 0x0007113D
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

		// Token: 0x060018AC RID: 6316 RVA: 0x00072F64 File Offset: 0x00071164
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

		// Token: 0x060018AD RID: 6317 RVA: 0x000730BA File Offset: 0x000712BA
		private double GetDefaultSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size)
		{
			if (global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.ShouldSynchronize(size, this.FieldForPositioning))
			{
				return global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetSynchronizedSize(size, this.FieldForPositioning);
			}
			if (this.IsLabel)
			{
				return global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetDefaultLabelSize(size, this.FieldForPositioning);
			}
			return global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.GetDefaultCellSize(size, this.FieldForPositioning);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x000730F8 File Offset: 0x000712F8
		internal void VerifyVersion()
		{
			int layoutItemVersion = this.Field.LayoutItemVersion;
			if (this._version != layoutItemVersion)
			{
				this.VerifyVersionImpl(layoutItemVersion);
			}
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00073124 File Offset: 0x00071324
		private void VerifyVersionImpl(int fieldVersion)
		{
			this._version = fieldVersion;
			for (int i = 0; i < 6; i++)
			{
				this._sizes[i] = this.GetDefaultSize((global::Infragistics.Windows.DataPresenter.LayoutItemSize)i);
			}
			this._sizeTypeHeight = this.FieldForPositioning.GetResizeSize(this.IsLabel, false).Type;
			this._sizeTypeWidth = this.FieldForPositioning.GetResizeSize(this.IsLabel, true).Type;
			double val = 6.0;
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.FieldForPositioning.Owner;
			bool flag = owner != null && owner.UseCellPresenters;
			if (this.IsLabel && flag)
			{
				val = 0.0;
			}
			this._sizes[0] = global::System.Math.Min(this._sizes[2], global::System.Math.Max(val, this._sizes[0]));
			this._sizes[3] = global::System.Math.Min(this._sizes[5], global::System.Math.Max(val, this._sizes[3]));
			this._visibility = (this.FieldForPositioning.IsVisibleInCellArea ? this.FieldForPositioning.VisibilityResolved : global::System.Windows.Visibility.Collapsed);
			if (this._gc != null)
			{
				this.InitializeGC();
			}
			if (this._visibility != global::System.Windows.Visibility.Collapsed)
			{
				global::System.Windows.Visibility visibility = flag ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Hidden;
				bool flag2 = false;
				switch (this.FieldForPositioning.CellContentAlignmentResolved)
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

		// Token: 0x060018B0 RID: 6320 RVA: 0x0007331C File Offset: 0x0007151C
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
				this._gc.ColumnWeight = this.FieldForPositioning.GetAutoFitWeight(!this.IsLabel, true, autoFitMode);
				this._gc.RowWeight = this.FieldForPositioning.GetAutoFitWeight(!this.IsLabel, false, autoFitMode);
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00073440 File Offset: 0x00071640
		private void SetWidthOrHeight(bool isWidth, double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this.SetWidthOrHeightHelper(isWidth, value, type);
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this.Field.GetMappedFields(true))
			{
				global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = this.IsLabel ? field.Owner.LabelLayoutManager : field.Owner.CellLayoutManager;
				global::Infragistics.Windows.DataPresenter.FieldLayoutItem fieldLayoutItem = fieldGridBagLayoutManager.GetLayoutItem(field, this.IsLabel) as global::Infragistics.Windows.DataPresenter.FieldLayoutItem;
				if (fieldLayoutItem != null)
				{
					fieldLayoutItem.SetWidthOrHeightHelper(isWidth, value, type);
				}
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000734D8 File Offset: 0x000716D8
		private void SetWidthOrHeightHelper(bool isWidth, double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			bool flag = isWidth ? this.Field.SyncCellLabelWidth : this.Field.SyncCellLabelHeight;
			if (isWidth)
			{
				this._sizes[1] = value;
			}
			else
			{
				this._sizes[4] = value;
			}
			global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo explicitResizeInfo = this.FieldForPositioning.ExplicitResizeInfo;
			if (this.IsLabel || flag)
			{
				explicitResizeInfo.SetSize(true, isWidth, new global::Infragistics.Windows.DataPresenter.FieldSize(value, type));
			}
			if (!this.IsLabel || flag)
			{
				explicitResizeInfo.SetSize(false, isWidth, new global::Infragistics.Windows.DataPresenter.FieldSize(value, type));
			}
			if (isWidth)
			{
				base.OnWidthChanged();
				return;
			}
			base.OnHeightChanged();
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00073568 File Offset: 0x00071768
		internal override global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase Clone(global::Infragistics.Windows.DataPresenter.Field newField)
		{
			return new global::Infragistics.Windows.DataPresenter.FieldLayoutItem(newField, this);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00073571 File Offset: 0x00071771
		public sealed override double GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size)
		{
			this.VerifyVersion();
			return this._sizes[(int)size];
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00073581 File Offset: 0x00071781
		protected override global::System.Windows.Visibility GetVisibility()
		{
			this.VerifyVersion();
			return this._visibility;
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x0007358F File Offset: 0x0007178F
		public override global::Infragistics.Windows.DataPresenter.DataRecordSizingMode RecordSizingMode
		{
			get
			{
				return this.FieldForPositioning.Owner.DataRecordSizingModeResolved;
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000735A1 File Offset: 0x000717A1
		public override void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this.SetWidthOrHeight(false, value, type);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000735AC File Offset: 0x000717AC
		public override void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this.SetWidthOrHeight(true, value, type);
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x000735B7 File Offset: 0x000717B7
		public override global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeHeight
		{
			get
			{
				this.VerifyVersion();
				return this._sizeTypeHeight;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x000735C5 File Offset: 0x000717C5
		public override global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeWidth
		{
			get
			{
				this.VerifyVersion();
				return this._sizeTypeWidth;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x000735D3 File Offset: 0x000717D3
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
		{
			get
			{
				return this.CellPresenterConstraint.Column;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x000735E0 File Offset: 0x000717E0
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
		{
			get
			{
				return this.CellPresenterConstraint.ColumnSpan;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x000735ED File Offset: 0x000717ED
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
		{
			get
			{
				return this.CellPresenterConstraint.ColumnWeight;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x000735FA File Offset: 0x000717FA
		global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
		{
			get
			{
				return this.CellPresenterConstraint.HorizontalAlignment;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x00073607 File Offset: 0x00071807
		global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
		{
			get
			{
				return this.CellPresenterConstraint.Margin;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x00073614 File Offset: 0x00071814
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
		{
			get
			{
				return this.CellPresenterConstraint.Row;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x00073621 File Offset: 0x00071821
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
		{
			get
			{
				return this.CellPresenterConstraint.RowSpan;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x0007362E File Offset: 0x0007182E
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
		{
			get
			{
				return this.CellPresenterConstraint.RowWeight;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x0007363B File Offset: 0x0007183B
		global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
		{
			get
			{
				return this.CellPresenterConstraint.VerticalAlignment;
			}
		}

		// Token: 0x04000A23 RID: 2595
		internal const int CellPresenterFactor = 2;

		// Token: 0x04000A24 RID: 2596
		internal const int MinimumExtent = 6;

		// Token: 0x04000A25 RID: 2597
		private double[] _sizes;

		// Token: 0x04000A26 RID: 2598
		private int _version = -1;

		// Token: 0x04000A27 RID: 2599
		private global::System.Windows.Visibility _visibility;

		// Token: 0x04000A28 RID: 2600
		private global::Infragistics.Windows.DataPresenter.GridBagConstraint _gc;

		// Token: 0x04000A29 RID: 2601
		private global::Infragistics.Windows.DataPresenter.ItemSizeType _sizeTypeWidth;

		// Token: 0x04000A2A RID: 2602
		private global::Infragistics.Windows.DataPresenter.ItemSizeType _sizeTypeHeight;
	}
}
