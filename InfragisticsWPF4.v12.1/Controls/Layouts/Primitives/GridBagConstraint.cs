using System;
using System.Text;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x0200003B RID: 59
	public class GridBagConstraint : global::Infragistics.PropertyChangeNotifier, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint, global::System.ICloneable
	{
		// Token: 0x0600025E RID: 606 RVA: 0x0000A8F6 File Offset: 0x00008AF6
		public GridBagConstraint() : this(-1, -1, 1, 1)
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000A902 File Offset: 0x00008B02
		public GridBagConstraint(int column, int row, int columnSpan, int rowSpan)
		{
			this._column = column;
			this._row = row;
			this._columnSpan = columnSpan;
			this._rowSpan = rowSpan;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000A935 File Offset: 0x00008B35
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000A93D File Offset: 0x00008B3D
		public global::System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return this._horizontalAlignment;
			}
			set
			{
				if (value != this._horizontalAlignment)
				{
					this._horizontalAlignment = value;
					base.RaisePropertyChangedEvent("HorizontalAlignment");
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000A95A File Offset: 0x00008B5A
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0000A962 File Offset: 0x00008B62
		public int Column
		{
			get
			{
				return this._column;
			}
			set
			{
				if (value == this._column)
				{
					return;
				}
				if (value < 0 && -1 != value)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint.ThrowArgumentOutOfRange("Column", value, "LE_GridBag_InvalidRowColumn");
				}
				this._column = value;
				base.RaisePropertyChangedEvent("Column");
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000A99D File Offset: 0x00008B9D
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0000A9A5 File Offset: 0x00008BA5
		public int ColumnSpan
		{
			get
			{
				return this._columnSpan;
			}
			set
			{
				if (value == this._columnSpan)
				{
					return;
				}
				if (value < 1 && value != 0 && -1 != value)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint.ThrowArgumentOutOfRange("ColumnSpan", value, "LE_GridBag_InvalidSpan");
				}
				this._columnSpan = value;
				base.RaisePropertyChangedEvent("ColumnSpan");
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000A9E3 File Offset: 0x00008BE3
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0000A9EB File Offset: 0x00008BEB
		public float ColumnWeight
		{
			get
			{
				return this._columnWeight;
			}
			set
			{
				if (value == this.ColumnWeight)
				{
					return;
				}
				if (value < 0f)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint.ThrowArgumentOutOfRange("ColumnWeight", value, "LE_GridBag_InvalidWeight");
				}
				this._columnWeight = value;
				base.RaisePropertyChangedEvent("ColumnWeight");
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000AA26 File Offset: 0x00008C26
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000AA2E File Offset: 0x00008C2E
		public global::System.Windows.Thickness Margin
		{
			get
			{
				return this._margin;
			}
			set
			{
				if (this._margin == value)
				{
					return;
				}
				this._margin = value;
				base.RaisePropertyChangedEvent("Insets");
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000AA51 File Offset: 0x00008C51
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000AA59 File Offset: 0x00008C59
		public int Row
		{
			get
			{
				return this._row;
			}
			set
			{
				if (value == this._row)
				{
					return;
				}
				if (value < 0 && -1 != value)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint.ThrowArgumentOutOfRange("Row", value, "LE_GridBag_InvalidRowColumn");
				}
				this._row = value;
				base.RaisePropertyChangedEvent("Row");
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000AA94 File Offset: 0x00008C94
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0000AA9C File Offset: 0x00008C9C
		public int RowSpan
		{
			get
			{
				return this._rowSpan;
			}
			set
			{
				if (value == this._rowSpan)
				{
					return;
				}
				if (value < 1 && value != 0 && -1 != value)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint.ThrowArgumentOutOfRange("RowSpan", value, "LE_GridBag_InvalidSpan");
				}
				this._rowSpan = value;
				base.RaisePropertyChangedEvent("RowSpan");
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000AADA File Offset: 0x00008CDA
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0000AAE2 File Offset: 0x00008CE2
		public float RowWeight
		{
			get
			{
				return this._rowWeight;
			}
			set
			{
				if (value == this._rowWeight)
				{
					return;
				}
				if (value < 0f)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint.ThrowArgumentOutOfRange("RowWeight", value, "LE_GridBag_InvalidWeight");
				}
				this._rowWeight = value;
				base.RaisePropertyChangedEvent("RowWeight");
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000AB1D File Offset: 0x00008D1D
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0000AB25 File Offset: 0x00008D25
		public global::System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return this._verticalAlignment;
			}
			set
			{
				if (value != this._verticalAlignment)
				{
					this._verticalAlignment = value;
					base.RaisePropertyChangedEvent("VerticalAlignment");
				}
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000AB44 File Offset: 0x00008D44
		public object Clone()
		{
			return (global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint)base.MemberwiseClone();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000AB5E File Offset: 0x00008D5E
		public void ResetColumn()
		{
			this.Column = -1;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000AB67 File Offset: 0x00008D67
		public void ResetColumnSpan()
		{
			this.ColumnSpan = 1;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000AB70 File Offset: 0x00008D70
		public void ResetColumnWeight()
		{
			this.ColumnWeight = 0f;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000AB7D File Offset: 0x00008D7D
		public void ResetHorizontalAlignment()
		{
			this.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000AB86 File Offset: 0x00008D86
		public void ResetMargin()
		{
			this._margin = default(global::System.Windows.Thickness);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000AB94 File Offset: 0x00008D94
		public void ResetRow()
		{
			this.Row = -1;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000AB9D File Offset: 0x00008D9D
		public void ResetRowSpan()
		{
			this.RowSpan = 1;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000ABA6 File Offset: 0x00008DA6
		public void ResetRowWeight()
		{
			this.RowWeight = 0f;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000ABB3 File Offset: 0x00008DB3
		public void ResetVerticalAlignment()
		{
			this.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000ABBC File Offset: 0x00008DBC
		public void Reset()
		{
			this.ResetHorizontalAlignment();
			this.ResetVerticalAlignment();
			this.ResetMargin();
			this.ResetColumn();
			this.ResetRow();
			this.ResetColumnSpan();
			this.ResetRowSpan();
			this.ResetColumnWeight();
			this.ResetRowWeight();
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000ABF4 File Offset: 0x00008DF4
		public bool ShouldSerialize()
		{
			return this.ShouldSerializeHorizontalAlignment() || this.ShouldSerializeVerticalAlignment() || this.ShouldSerializeMargin() || this.ShouldSerializeColumn() || this.ShouldSerializeRow() || this.ShouldSerializeColumnSpan() || this.ShouldSerializeRowSpan() || this.ShouldSerializeColumnWeight() || this.ShouldSerializeRowWeight();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000AC4C File Offset: 0x00008E4C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (this.ShouldSerializeColumn() || this.ShouldSerializeRow())
			{
				stringBuilder.AppendFormat("Origin={0}, {1}", this.Column, this.Row);
			}
			if (this.ShouldSerializeColumnSpan() || this.ShouldSerializeRowSpan())
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append("; ");
				}
				stringBuilder.AppendFormat("Span={0}, {1}", this.ColumnSpan, this.RowSpan);
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append("; ");
			}
			stringBuilder.AppendFormat("; Horiz Align={0}", this.HorizontalAlignment);
			stringBuilder.AppendFormat("; Vert Align={0}", this.VerticalAlignment);
			return stringBuilder.ToString();
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000AD21 File Offset: 0x00008F21
		protected bool ShouldSerializeColumn()
		{
			return -1 != this._column;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000AD2F File Offset: 0x00008F2F
		protected bool ShouldSerializeColumnSpan()
		{
			return 1 != this._columnSpan;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000AD3D File Offset: 0x00008F3D
		protected bool ShouldSerializeColumnWeight()
		{
			return 0f != this._columnWeight;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000AD4F File Offset: 0x00008F4F
		protected bool ShouldSerializeHorizontalAlignment()
		{
			return global::System.Windows.HorizontalAlignment.Center != this._horizontalAlignment;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000AD60 File Offset: 0x00008F60
		protected bool ShouldSerializeMargin()
		{
			return 0.0 != this._margin.Left || 0.0 != this._margin.Top || 0.0 != this._margin.Right || 0.0 != this._margin.Bottom;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000ADCA File Offset: 0x00008FCA
		protected bool ShouldSerializeRow()
		{
			return -1 != this._row;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000ADD8 File Offset: 0x00008FD8
		protected bool ShouldSerializeRowSpan()
		{
			return 1 != this._rowSpan;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000ADE6 File Offset: 0x00008FE6
		protected bool ShouldSerializeRowWeight()
		{
			return 0f != this._rowWeight;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000ADF8 File Offset: 0x00008FF8
		protected bool ShouldSerializeVerticalAlignment()
		{
			return global::System.Windows.VerticalAlignment.Center != this._verticalAlignment;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000AE06 File Offset: 0x00009006
		private static void ThrowArgumentOutOfRange(string property, object value, string errorResource)
		{
			throw new global::System.ArgumentOutOfRangeException(property, value, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GetString(errorResource));
		}

		// Token: 0x04000095 RID: 149
		private global::System.Windows.HorizontalAlignment _horizontalAlignment = global::System.Windows.HorizontalAlignment.Center;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.VerticalAlignment _verticalAlignment = global::System.Windows.VerticalAlignment.Center;

		// Token: 0x04000097 RID: 151
		private int _column;

		// Token: 0x04000098 RID: 152
		private int _row;

		// Token: 0x04000099 RID: 153
		private int _columnSpan;

		// Token: 0x0400009A RID: 154
		private int _rowSpan;

		// Token: 0x0400009B RID: 155
		private float _columnWeight;

		// Token: 0x0400009C RID: 156
		private float _rowWeight;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Thickness _margin;
	}
}
