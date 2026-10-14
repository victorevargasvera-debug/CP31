using System;
using System.ComponentModel;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000242 RID: 578
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.ColumnWidthTypeConverter))]
	public struct ColumnWidth
	{
		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00043C2A File Offset: 0x00041E2A
		public static global::Infragistics.Controls.Grids.ColumnWidth SizeToHeader
		{
			get
			{
				return global::Infragistics.Controls.Grids.ColumnWidth._sizeToHeader;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00043C31 File Offset: 0x00041E31
		public static global::Infragistics.Controls.Grids.ColumnWidth SizeToCells
		{
			get
			{
				return global::Infragistics.Controls.Grids.ColumnWidth._sizeToCells;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00043C38 File Offset: 0x00041E38
		public static global::Infragistics.Controls.Grids.ColumnWidth Auto
		{
			get
			{
				return global::Infragistics.Controls.Grids.ColumnWidth._auto;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00043C3F File Offset: 0x00041E3F
		public static global::Infragistics.Controls.Grids.ColumnWidth InitialAuto
		{
			get
			{
				return global::Infragistics.Controls.Grids.ColumnWidth._initialAuto;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00043C46 File Offset: 0x00041E46
		public static global::Infragistics.Controls.Grids.ColumnWidth Star
		{
			get
			{
				return global::Infragistics.Controls.Grids.ColumnWidth._star;
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00043C4D File Offset: 0x00041E4D
		private ColumnWidth(double value, global::Infragistics.Controls.Grids.ColumnWidthType type)
		{
			if (value < 0.0)
			{
				value = 0.0;
			}
			this._value = value;
			this._type = type;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00043C74 File Offset: 0x00041E74
		public ColumnWidth(double value, bool isStar)
		{
			this = new global::Infragistics.Controls.Grids.ColumnWidth(value, isStar ? global::Infragistics.Controls.Grids.ColumnWidthType.Star : global::Infragistics.Controls.Grids.ColumnWidthType.Numeric);
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00043C84 File Offset: 0x00041E84
		public double Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x00043C8C File Offset: 0x00041E8C
		public global::Infragistics.Controls.Grids.ColumnWidthType WidthType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x040005B4 RID: 1460
		private static global::Infragistics.Controls.Grids.ColumnWidth _sizeToCells = new global::Infragistics.Controls.Grids.ColumnWidth(1.0, global::Infragistics.Controls.Grids.ColumnWidthType.SizeToCells);

		// Token: 0x040005B5 RID: 1461
		private static global::Infragistics.Controls.Grids.ColumnWidth _auto = new global::Infragistics.Controls.Grids.ColumnWidth(1.0, global::Infragistics.Controls.Grids.ColumnWidthType.Auto);

		// Token: 0x040005B6 RID: 1462
		private static global::Infragistics.Controls.Grids.ColumnWidth _initialAuto = new global::Infragistics.Controls.Grids.ColumnWidth(1.0, global::Infragistics.Controls.Grids.ColumnWidthType.InitialAuto);

		// Token: 0x040005B7 RID: 1463
		private static global::Infragistics.Controls.Grids.ColumnWidth _sizeToHeader = new global::Infragistics.Controls.Grids.ColumnWidth(1.0, global::Infragistics.Controls.Grids.ColumnWidthType.SizeToHeader);

		// Token: 0x040005B8 RID: 1464
		private static global::Infragistics.Controls.Grids.ColumnWidth _star = new global::Infragistics.Controls.Grids.ColumnWidth(1.0, global::Infragistics.Controls.Grids.ColumnWidthType.Star);

		// Token: 0x040005B9 RID: 1465
		private double _value;

		// Token: 0x040005BA RID: 1466
		private global::Infragistics.Controls.Grids.ColumnWidthType _type;
	}
}
