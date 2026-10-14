using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000121 RID: 289
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DataPresenter.FieldLengthConverter))]
	public struct FieldLength : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.FieldLength>
	{
		// Token: 0x06001120 RID: 4384 RVA: 0x0004C054 File Offset: 0x0004A254
		static FieldLength()
		{
			global::Infragistics.Windows.DataPresenter.FieldLength._empty._value = -1.0;
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0004C0B0 File Offset: 0x0004A2B0
		public FieldLength(double pixels)
		{
			this = new global::Infragistics.Windows.DataPresenter.FieldLength(pixels, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Pixel);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0004C0BC File Offset: 0x0004A2BC
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

		// Token: 0x06001123 RID: 4387 RVA: 0x0004C12B File Offset: 0x0004A32B
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DataPresenter.FieldLength && this.Equals((global::Infragistics.Windows.DataPresenter.FieldLength)obj);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0004C143 File Offset: 0x0004A343
		public override int GetHashCode()
		{
			return this._unit.GetHashCode() | this._value.GetHashCode();
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0004C161 File Offset: 0x0004A361
		public override string ToString()
		{
			return global::Infragistics.Windows.DataPresenter.FieldLengthConverter.ToString(this, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0004C173 File Offset: 0x0004A373
		public static bool operator ==(global::Infragistics.Windows.DataPresenter.FieldLength length1, global::Infragistics.Windows.DataPresenter.FieldLength length2)
		{
			return length1._unit == length2._unit && length1._value.Equals(length2._value);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0004C19A File Offset: 0x0004A39A
		public static bool operator !=(global::Infragistics.Windows.DataPresenter.FieldLength length1, global::Infragistics.Windows.DataPresenter.FieldLength length2)
		{
			return !(length1 == length2);
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x0004C1A6 File Offset: 0x0004A3A6
		public static global::Infragistics.Windows.DataPresenter.FieldLength Auto
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.FieldLength._auto;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0004C1AD File Offset: 0x0004A3AD
		internal static global::Infragistics.Windows.DataPresenter.FieldLength Empty
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.FieldLength._empty;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x0004C1B4 File Offset: 0x0004A3B4
		public static global::Infragistics.Windows.DataPresenter.FieldLength InitialAuto
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.FieldLength._initialAuto;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0004C1BB File Offset: 0x0004A3BB
		public bool IsAbsolute
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Pixel;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x0004C1C6 File Offset: 0x0004A3C6
		public bool IsAuto
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Auto && this._value != -1.0;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x0004C1E6 File Offset: 0x0004A3E6
		internal bool IsAnyAuto
		{
			get
			{
				return this.IsAuto || this.IsInitialAuto;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0004C1F8 File Offset: 0x0004A3F8
		public bool IsInitialAuto
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.InitialAuto;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0004C203 File Offset: 0x0004A403
		internal bool IsEmpty
		{
			get
			{
				return this == global::Infragistics.Windows.DataPresenter.FieldLength._empty;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0004C215 File Offset: 0x0004A415
		public bool IsStar
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Star;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0004C220 File Offset: 0x0004A420
		public global::Infragistics.Windows.DataPresenter.FieldLengthUnitType UnitType
		{
			get
			{
				return this._unit;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0004C228 File Offset: 0x0004A428
		public double Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0004C230 File Offset: 0x0004A430
		public bool Equals(global::Infragistics.Windows.DataPresenter.FieldLength other)
		{
			return this == other;
		}

		// Token: 0x040006F5 RID: 1781
		private const double EmptyValue = -1.0;

		// Token: 0x040006F6 RID: 1782
		private double _value;

		// Token: 0x040006F7 RID: 1783
		private global::Infragistics.Windows.DataPresenter.FieldLengthUnitType _unit;

		// Token: 0x040006F8 RID: 1784
		private static global::Infragistics.Windows.DataPresenter.FieldLength _auto = new global::Infragistics.Windows.DataPresenter.FieldLength(1.0, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Auto);

		// Token: 0x040006F9 RID: 1785
		private static global::Infragistics.Windows.DataPresenter.FieldLength _initialAuto = new global::Infragistics.Windows.DataPresenter.FieldLength(1.0, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.InitialAuto);

		// Token: 0x040006FA RID: 1786
		private static global::Infragistics.Windows.DataPresenter.FieldLength _empty = new global::Infragistics.Windows.DataPresenter.FieldLength(1.0, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Auto);
	}
}
