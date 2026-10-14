using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200028A RID: 650
	public struct RowHeight
	{
		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x0004DFAC File Offset: 0x0004C1AC
		public static global::Infragistics.Controls.Grids.RowHeight SizeToLargestCell
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowHeight._sizeToLargestCell;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x0004DFB3 File Offset: 0x0004C1B3
		public static global::Infragistics.Controls.Grids.RowHeight Dynamic
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowHeight._dynamic;
			}
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0004DFBA File Offset: 0x0004C1BA
		private RowHeight(double value, global::Infragistics.Controls.Grids.RowHeightType type)
		{
			if (value < 0.0)
			{
				value = 0.0;
			}
			this._value = value;
			this._type = type;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0004DFE1 File Offset: 0x0004C1E1
		public RowHeight(double value)
		{
			this = new global::Infragistics.Controls.Grids.RowHeight(value, global::Infragistics.Controls.Grids.RowHeightType.Numeric);
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x0004DFEB File Offset: 0x0004C1EB
		public double Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x0004DFF3 File Offset: 0x0004C1F3
		public global::Infragistics.Controls.Grids.RowHeightType HeightType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x0400066F RID: 1647
		private static global::Infragistics.Controls.Grids.RowHeight _dynamic = new global::Infragistics.Controls.Grids.RowHeight(1.0, global::Infragistics.Controls.Grids.RowHeightType.Dynamic);

		// Token: 0x04000670 RID: 1648
		private static global::Infragistics.Controls.Grids.RowHeight _sizeToLargestCell = new global::Infragistics.Controls.Grids.RowHeight(1.0, global::Infragistics.Controls.Grids.RowHeightType.SizeToLargestCell);

		// Token: 0x04000671 RID: 1649
		private double _value;

		// Token: 0x04000672 RID: 1650
		private global::Infragistics.Controls.Grids.RowHeightType _type;
	}
}
