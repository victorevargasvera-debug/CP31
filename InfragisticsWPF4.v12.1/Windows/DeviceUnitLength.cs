using System;
using System.ComponentModel;

namespace Infragistics.Windows
{
	// Token: 0x020000FB RID: 251
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DeviceUnitLengthConverter))]
	public struct DeviceUnitLength : global::System.IEquatable<global::Infragistics.Windows.DeviceUnitLength>
	{
		// Token: 0x0600094F RID: 2383 RVA: 0x0001E955 File Offset: 0x0001CB55
		public DeviceUnitLength(double value)
		{
			this = new global::Infragistics.Windows.DeviceUnitLength(value, global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0001E95F File Offset: 0x0001CB5F
		public DeviceUnitLength(double value, global::Infragistics.Windows.DeviceUnitType type)
		{
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(value);
			this._value = value;
			this._unit = type;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0001E978 File Offset: 0x0001CB78
		public double ConvertToUnitType(global::Infragistics.Windows.DeviceUnitType unitType)
		{
			if (this.UnitType == unitType)
			{
				return this.Value;
			}
			double twips = global::Infragistics.Windows.DeviceUnitLength.ConvertToTwips(this.Value, this.UnitType);
			return global::Infragistics.Windows.DeviceUnitLength.ConvertFromTwips(twips, unitType);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0001E9B0 File Offset: 0x0001CBB0
		internal static double ConvertFromTwips(double twips, global::Infragistics.Windows.DeviceUnitType targetUnit)
		{
			switch (targetUnit)
			{
			case global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit:
				return twips / 1440.0 * 96.0;
			case global::Infragistics.Windows.DeviceUnitType.Pixel:
			{
				double num = twips / 1440.0 * 96.0;
				return global::Infragistics.Windows.Utilities.GetDeviceMatrix(true, null).M22 * num;
			}
			case global::Infragistics.Windows.DeviceUnitType.Point:
				return twips / 20.0;
			case global::Infragistics.Windows.DeviceUnitType.Twip:
				return twips;
			case global::Infragistics.Windows.DeviceUnitType.Centimeter:
				return twips / 1440.0 * 2.54;
			case global::Infragistics.Windows.DeviceUnitType.Inch:
				return twips / 1440.0;
			default:
				return twips;
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0001EA50 File Offset: 0x0001CC50
		internal static double ConvertToTwips(double value, global::Infragistics.Windows.DeviceUnitType sourceUnit)
		{
			switch (sourceUnit)
			{
			case global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit:
				return value / 96.0 * 1440.0;
			case global::Infragistics.Windows.DeviceUnitType.Pixel:
				value = global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, null).M11 * value;
				return value / 96.0 * 1440.0;
			case global::Infragistics.Windows.DeviceUnitType.Point:
				return value * 20.0;
			case global::Infragistics.Windows.DeviceUnitType.Twip:
				return value;
			case global::Infragistics.Windows.DeviceUnitType.Centimeter:
				return value / 2.54 * 1440.0;
			case global::Infragistics.Windows.DeviceUnitType.Inch:
				return value * 1440.0;
			default:
				return value;
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0001EAEF File Offset: 0x0001CCEF
		internal static void ValidateUnitLengthValue(double value)
		{
			global::Infragistics.CoreUtilities.ValidateIsNotNan(value);
			global::Infragistics.CoreUtilities.ValidateIsNotInfinity(value);
			global::Infragistics.CoreUtilities.ValidateIsNotNegative(value);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0001EB03 File Offset: 0x0001CD03
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DeviceUnitLength && this.Equals((global::Infragistics.Windows.DeviceUnitLength)obj);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0001EB1B File Offset: 0x0001CD1B
		public override int GetHashCode()
		{
			return this._unit.GetHashCode() | this._value.GetHashCode();
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0001EB39 File Offset: 0x0001CD39
		public static bool operator ==(global::Infragistics.Windows.DeviceUnitLength length1, global::Infragistics.Windows.DeviceUnitLength length2)
		{
			return length1._unit == length2._unit && length1._value.Equals(length2._value);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0001EB60 File Offset: 0x0001CD60
		public static bool operator !=(global::Infragistics.Windows.DeviceUnitLength length1, global::Infragistics.Windows.DeviceUnitLength length2)
		{
			return !(length1 == length2);
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0001EB6C File Offset: 0x0001CD6C
		public bool IsDeviceIndependentUnit
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0001EB77 File Offset: 0x0001CD77
		public bool IsPixel
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DeviceUnitType.Pixel;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0001EB82 File Offset: 0x0001CD82
		public bool IsPoint
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DeviceUnitType.Point;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0001EB8D File Offset: 0x0001CD8D
		public bool IsTwip
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DeviceUnitType.Twip;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0001EB98 File Offset: 0x0001CD98
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x0001EBA0 File Offset: 0x0001CDA0
		public global::Infragistics.Windows.DeviceUnitType UnitType
		{
			get
			{
				return this._unit;
			}
			set
			{
				this._unit = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0001EBA9 File Offset: 0x0001CDA9
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x0001EBB1 File Offset: 0x0001CDB1
		public double Value
		{
			get
			{
				return this._value;
			}
			set
			{
				global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(value);
				this._value = value;
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0001EBC0 File Offset: 0x0001CDC0
		public bool Equals(global::Infragistics.Windows.DeviceUnitLength other)
		{
			return this == other;
		}

		// Token: 0x040003CA RID: 970
		private const int TwipsPerInch = 1440;

		// Token: 0x040003CB RID: 971
		private const int LogicalDpi = 96;

		// Token: 0x040003CC RID: 972
		private const double CentimetersPerInch = 2.54;

		// Token: 0x040003CD RID: 973
		private const int TwipsPerPoint = 20;

		// Token: 0x040003CE RID: 974
		private double _value;

		// Token: 0x040003CF RID: 975
		private global::Infragistics.Windows.DeviceUnitType _unit;
	}
}
