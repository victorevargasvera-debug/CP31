using System;
using System.ComponentModel;

namespace Infragistics.Windows
{
	// Token: 0x02000119 RID: 281
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DeviceUnitLengthConverter))]
	public struct DeviceUnitLength : global::System.IEquatable<global::Infragistics.Windows.DeviceUnitLength>
	{
		// Token: 0x06000A4E RID: 2638 RVA: 0x0002251D File Offset: 0x0002071D
		public DeviceUnitLength(double value)
		{
			this = new global::Infragistics.Windows.DeviceUnitLength(value, global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00022527 File Offset: 0x00020727
		public DeviceUnitLength(double value, global::Infragistics.Windows.DeviceUnitType type)
		{
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(value);
			this._value = value;
			this._unit = type;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00022540 File Offset: 0x00020740
		public double ConvertToUnitType(global::Infragistics.Windows.DeviceUnitType unitType)
		{
			if (this.UnitType == unitType)
			{
				return this.Value;
			}
			double twips = global::Infragistics.Windows.DeviceUnitLength.ConvertToTwips(this.Value, this.UnitType);
			return global::Infragistics.Windows.DeviceUnitLength.ConvertFromTwips(twips, unitType);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00022578 File Offset: 0x00020778
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

		// Token: 0x06000A52 RID: 2642 RVA: 0x00022618 File Offset: 0x00020818
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

		// Token: 0x06000A53 RID: 2643 RVA: 0x000226B7 File Offset: 0x000208B7
		internal static void ValidateUnitLengthValue(double value)
		{
			global::Infragistics.CoreUtilities.ValidateIsNotNan(value);
			global::Infragistics.CoreUtilities.ValidateIsNotInfinity(value);
			global::Infragistics.CoreUtilities.ValidateIsNotNegative(value);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000226CB File Offset: 0x000208CB
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DeviceUnitLength && this.Equals((global::Infragistics.Windows.DeviceUnitLength)obj);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000226E3 File Offset: 0x000208E3
		public override int GetHashCode()
		{
			return this._unit.GetHashCode() | this._value.GetHashCode();
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00022701 File Offset: 0x00020901
		public static bool operator ==(global::Infragistics.Windows.DeviceUnitLength length1, global::Infragistics.Windows.DeviceUnitLength length2)
		{
			return length1._unit == length2._unit && length1._value.Equals(length2._value);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00022728 File Offset: 0x00020928
		public static bool operator !=(global::Infragistics.Windows.DeviceUnitLength length1, global::Infragistics.Windows.DeviceUnitLength length2)
		{
			return !(length1 == length2);
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00022734 File Offset: 0x00020934
		public bool IsDeviceIndependentUnit
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002273F File Offset: 0x0002093F
		public bool IsPixel
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DeviceUnitType.Pixel;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0002274A File Offset: 0x0002094A
		public bool IsPoint
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DeviceUnitType.Point;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00022755 File Offset: 0x00020955
		public bool IsTwip
		{
			get
			{
				return this._unit == global::Infragistics.Windows.DeviceUnitType.Twip;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00022760 File Offset: 0x00020960
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00022768 File Offset: 0x00020968
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00022771 File Offset: 0x00020971
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00022779 File Offset: 0x00020979
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

		// Token: 0x06000A60 RID: 2656 RVA: 0x00022788 File Offset: 0x00020988
		public bool Equals(global::Infragistics.Windows.DeviceUnitLength other)
		{
			return this == other;
		}

		// Token: 0x0400047D RID: 1149
		private const int TwipsPerInch = 1440;

		// Token: 0x0400047E RID: 1150
		private const int LogicalDpi = 96;

		// Token: 0x0400047F RID: 1151
		private const double CentimetersPerInch = 2.54;

		// Token: 0x04000480 RID: 1152
		private const int TwipsPerPoint = 20;

		// Token: 0x04000481 RID: 1153
		private double _value;

		// Token: 0x04000482 RID: 1154
		private global::Infragistics.Windows.DeviceUnitType _unit;
	}
}
