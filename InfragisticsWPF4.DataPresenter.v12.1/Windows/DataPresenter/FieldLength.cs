using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000105 RID: 261
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DataPresenter.FieldLengthConverter))]
	public struct FieldLength : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.FieldLength>
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x0003B594 File Offset: 0x00039794
		static FieldLength()
		{
			global::Infragistics.Windows.DataPresenter.FieldLength._empty._value = -1.0;
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0003B5F0 File Offset: 0x000397F0
		public FieldLength(double pixels)
		{
			this = new global::Infragistics.Windows.DataPresenter.FieldLength(pixels, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Pixel);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0003B5FC File Offset: 0x000397FC
		public FieldLength(double value, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType type)
		{
			if (double.IsNaN(value))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Resources.GetString("LE_ValueCannotBeNan"));
			}
			if (double.IsInfinity(value))
			{
				throw new global::System.ArgumentException("");
			}
			if (value < 0.0)
			{
				throw new global::System.ArgumentException("");
			}
			this._value = ((type == global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Auto || type == global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.InitialAuto) ? 1.0 : value);
			this._unit = type;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0003B66B File Offset: 0x0003986B
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DataPresenter.FieldLength && this.Equals((global::Infragistics.Windows.DataPresenter.FieldLength)obj);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0003B683 File Offset: 0x00039883
		public override int GetHashCode()
		{
			return this._unit.GetHashCode() | this._value.GetHashCode();
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0003B6A1 File Offset: 0x000398A1
		public override string ToString()
		{
			return global::Infragistics.Windows.DataPresenter.FieldLengthConverter.ToString(this, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0003B6B3 File Offset: 0x000398B3
		public static bool operator ==(global::Infragistics.Windows.DataPresenter.FieldLength length1, global::Infragistics.Windows.DataPresenter.FieldLength length2)
		{
			return length1._unit == length2._unit && length1._value.Equals(length2._value);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0003B6DA File Offset: 0x000398DA
		public static bool operator !=(global::Infragistics.Windows.DataPresenter.FieldLength length1, global::Infragistics.Windows.DataPresenter.FieldLength length2)
		{
			return !(length1 == length2);
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0003B6E6 File Offset: 0x000398E6
		public static global::Infragistics.Windows.DataPresenter.FieldLength Auto
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.FieldLength._auto;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x0003B6ED File Offset: 0x000398ED
		internal static global::Infragistics.Windows.DataPresenter.FieldLength Empty
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.FieldLength._empty;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x0003B6F4 File Offset: 0x000398F4
		public static global::Infragistics.Windows.DataPresenter.FieldLength InitialAuto
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.FieldLength._initialAuto;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x0003B6FB File Offset: 0x000398FB
		public bool IsAbsolute
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Pixel;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x0003B706 File Offset: 0x00039906
		public bool IsAuto
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Auto && this._value != -1.0;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x0003B726 File Offset: 0x00039926
		internal bool IsAnyAuto
		{
			get
			{
				return this.IsAuto || this.IsInitialAuto;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x0003B738 File Offset: 0x00039938
		public bool IsInitialAuto
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.InitialAuto;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0003B743 File Offset: 0x00039943
		internal bool IsEmpty
		{
			get
			{
				return this == global::Infragistics.Windows.DataPresenter.FieldLength._empty;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x0003B755 File Offset: 0x00039955
		public bool IsStar
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Star;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0003B760 File Offset: 0x00039960
		public global::Infragistics.Windows.DataPresenter.FieldLengthUnitType UnitType
		{
			get
			{
				return this._unit;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0003B768 File Offset: 0x00039968
		public double Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0003B770 File Offset: 0x00039970
		public bool Equals(global::Infragistics.Windows.DataPresenter.FieldLength other)
		{
			return this == other;
		}

		// Token: 0x04000556 RID: 1366
		private const double EmptyValue = -1.0;

		// Token: 0x04000557 RID: 1367
		private double _value;

		// Token: 0x04000558 RID: 1368
		private global::Infragistics.Windows.DataPresenter.FieldLengthUnitType _unit;

		// Token: 0x04000559 RID: 1369
		private static global::Infragistics.Windows.DataPresenter.FieldLength _auto = new global::Infragistics.Windows.DataPresenter.FieldLength(1.0, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Auto);

		// Token: 0x0400055A RID: 1370
		private static global::Infragistics.Windows.DataPresenter.FieldLength _initialAuto = new global::Infragistics.Windows.DataPresenter.FieldLength(1.0, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.InitialAuto);

		// Token: 0x0400055B RID: 1371
		private static global::Infragistics.Windows.DataPresenter.FieldLength _empty = new global::Infragistics.Windows.DataPresenter.FieldLength(1.0, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Auto);
	}
}
