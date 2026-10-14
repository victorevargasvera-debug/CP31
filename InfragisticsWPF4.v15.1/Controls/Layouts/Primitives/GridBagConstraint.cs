using System;
using System.Text;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x0200004F RID: 79
	public class GridBagConstraint : global::Infragistics.PropertyChangeNotifier, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint, global::System.ICloneable
	{
		// Token: 0x060002EF RID: 751 RVA: 0x0000C382 File Offset: 0x0000A582
		public GridBagConstraint() : this(-1, -1, 1, 1)
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000C38E File Offset: 0x0000A58E
		public GridBagConstraint(int column, int row, int columnSpan, int rowSpan)
		{
			this._column = column;
			this._row = row;
			this._columnSpan = columnSpan;
			this._rowSpan = rowSpan;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000C3C1 File Offset: 0x0000A5C1
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000C3C9 File Offset: 0x0000A5C9
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000C3E6 File Offset: 0x0000A5E6
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0000C3EE File Offset: 0x0000A5EE
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000C429 File Offset: 0x0000A629
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000C431 File Offset: 0x0000A631
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000C46F File Offset: 0x0000A66F
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0000C477 File Offset: 0x0000A677
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000C4B2 File Offset: 0x0000A6B2
		// (set) Token: 0x060002FA RID: 762 RVA: 0x0000C4BA File Offset: 0x0000A6BA
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000C4DD File Offset: 0x0000A6DD
		// (set) Token: 0x060002FC RID: 764 RVA: 0x0000C4E5 File Offset: 0x0000A6E5
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0000C520 File Offset: 0x0000A720
		// (set) Token: 0x060002FE RID: 766 RVA: 0x0000C528 File Offset: 0x0000A728
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0000C566 File Offset: 0x0000A766
		// (set) Token: 0x06000300 RID: 768 RVA: 0x0000C56E File Offset: 0x0000A76E
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000C5A9 File Offset: 0x0000A7A9
		// (set) Token: 0x06000302 RID: 770 RVA: 0x0000C5B1 File Offset: 0x0000A7B1
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

		// Token: 0x06000303 RID: 771 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		public object Clone()
		{
			return (global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint)base.MemberwiseClone();
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000C5EA File Offset: 0x0000A7EA
		public void ResetColumn()
		{
			this.Column = -1;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000C5F3 File Offset: 0x0000A7F3
		public void ResetColumnSpan()
		{
			this.ColumnSpan = 1;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		public void ResetColumnWeight()
		{
			this.ColumnWeight = 0f;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000C609 File Offset: 0x0000A809
		public void ResetHorizontalAlignment()
		{
			this.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000C612 File Offset: 0x0000A812
		public void ResetMargin()
		{
			this._margin = default(global::System.Windows.Thickness);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000C620 File Offset: 0x0000A820
		public void ResetRow()
		{
			this.Row = -1;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000C629 File Offset: 0x0000A829
		public void ResetRowSpan()
		{
			this.RowSpan = 1;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000C632 File Offset: 0x0000A832
		public void ResetRowWeight()
		{
			this.RowWeight = 0f;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000C63F File Offset: 0x0000A83F
		public void ResetVerticalAlignment()
		{
			this.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000C648 File Offset: 0x0000A848
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

		// Token: 0x0600030E RID: 782 RVA: 0x0000C680 File Offset: 0x0000A880
		public bool ShouldSerialize()
		{
			return this.ShouldSerializeHorizontalAlignment() || this.ShouldSerializeVerticalAlignment() || this.ShouldSerializeMargin() || this.ShouldSerializeColumn() || this.ShouldSerializeRow() || this.ShouldSerializeColumnSpan() || this.ShouldSerializeRowSpan() || this.ShouldSerializeColumnWeight() || this.ShouldSerializeRowWeight();
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
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

		// Token: 0x06000310 RID: 784 RVA: 0x0000C7AD File Offset: 0x0000A9AD
		protected bool ShouldSerializeColumn()
		{
			return -1 != this._column;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000C7BB File Offset: 0x0000A9BB
		protected bool ShouldSerializeColumnSpan()
		{
			return 1 != this._columnSpan;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000C7C9 File Offset: 0x0000A9C9
		protected bool ShouldSerializeColumnWeight()
		{
			return 0f != this._columnWeight;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000C7DB File Offset: 0x0000A9DB
		protected bool ShouldSerializeHorizontalAlignment()
		{
			return global::System.Windows.HorizontalAlignment.Center != this._horizontalAlignment;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		protected bool ShouldSerializeMargin()
		{
			return 0.0 != this._margin.Left || 0.0 != this._margin.Top || 0.0 != this._margin.Right || 0.0 != this._margin.Bottom;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000C856 File Offset: 0x0000AA56
		protected bool ShouldSerializeRow()
		{
			return -1 != this._row;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000C864 File Offset: 0x0000AA64
		protected bool ShouldSerializeRowSpan()
		{
			return 1 != this._rowSpan;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000C872 File Offset: 0x0000AA72
		protected bool ShouldSerializeRowWeight()
		{
			return 0f != this._rowWeight;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000C884 File Offset: 0x0000AA84
		protected bool ShouldSerializeVerticalAlignment()
		{
			return global::System.Windows.VerticalAlignment.Center != this._verticalAlignment;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000C892 File Offset: 0x0000AA92
		private static void ThrowArgumentOutOfRange(string property, object value, string errorResource)
		{
			throw new global::System.ArgumentOutOfRangeException(property, value, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GetString(errorResource));
		}

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.HorizontalAlignment _horizontalAlignment = global::System.Windows.HorizontalAlignment.Center;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.VerticalAlignment _verticalAlignment = global::System.Windows.VerticalAlignment.Center;

		// Token: 0x040000F2 RID: 242
		private int _column;

		// Token: 0x040000F3 RID: 243
		private int _row;

		// Token: 0x040000F4 RID: 244
		private int _columnSpan;

		// Token: 0x040000F5 RID: 245
		private int _rowSpan;

		// Token: 0x040000F6 RID: 246
		private float _columnWeight;

		// Token: 0x040000F7 RID: 247
		private float _rowWeight;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Thickness _margin;
	}
}
