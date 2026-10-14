using System;
using System.ComponentModel;

namespace Infragistics.Windows
{
	// Token: 0x020000FF RID: 255
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DeviceUnitThicknessConverter))]
	public struct DeviceUnitThickness : global::System.IEquatable<global::Infragistics.Windows.DeviceUnitThickness>
	{
		// Token: 0x06000980 RID: 2432 RVA: 0x0001F2B6 File Offset: 0x0001D4B6
		public DeviceUnitThickness(double uniformLength)
		{
			this = new global::Infragistics.Windows.DeviceUnitThickness(uniformLength, global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0001F2C0 File Offset: 0x0001D4C0
		public DeviceUnitThickness(double uniformLength, global::Infragistics.Windows.DeviceUnitType type)
		{
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(uniformLength);
			this._bottom = uniformLength;
			this._top = uniformLength;
			this._right = uniformLength;
			this._left = uniformLength;
			this._unit = type;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0001F2FC File Offset: 0x0001D4FC
		public DeviceUnitThickness(double left, double top, double right, double bottom, global::Infragistics.Windows.DeviceUnitType type)
		{
			this._unit = type;
			this._left = (this._top = (this._right = (this._bottom = 0.0)));
			this.Left = left;
			this.Top = top;
			this.Bottom = bottom;
			this.Right = right;
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0001F358 File Offset: 0x0001D558
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x0001F360 File Offset: 0x0001D560
		public double Bottom
		{
			get
			{
				return this._bottom;
			}
			set
			{
				global::Infragistics.Windows.DeviceUnitThickness.SetValue(ref this._bottom, value);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0001F36E File Offset: 0x0001D56E
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x0001F376 File Offset: 0x0001D576
		public double Left
		{
			get
			{
				return this._left;
			}
			set
			{
				global::Infragistics.Windows.DeviceUnitThickness.SetValue(ref this._left, value);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0001F384 File Offset: 0x0001D584
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x0001F38C File Offset: 0x0001D58C
		public double Right
		{
			get
			{
				return this._right;
			}
			set
			{
				global::Infragistics.Windows.DeviceUnitThickness.SetValue(ref this._right, value);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0001F39A File Offset: 0x0001D59A
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x0001F3A2 File Offset: 0x0001D5A2
		public double Top
		{
			get
			{
				return this._top;
			}
			set
			{
				global::Infragistics.Windows.DeviceUnitThickness.SetValue(ref this._top, value);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0001F3B0 File Offset: 0x0001D5B0
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x0001F3B8 File Offset: 0x0001D5B8
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

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0001F3C1 File Offset: 0x0001D5C1
		internal bool IsUniform
		{
			get
			{
				return global::Infragistics.CoreUtilities.AreClose(this._left, this._top) && global::Infragistics.CoreUtilities.AreClose(this._left, this._right) && global::Infragistics.CoreUtilities.AreClose(this._left, this._bottom);
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0001F3FC File Offset: 0x0001D5FC
		public global::Infragistics.Windows.DeviceUnitThickness ConvertToUnitType(global::Infragistics.Windows.DeviceUnitType unitType)
		{
			if (this.UnitType == unitType)
			{
				return this;
			}
			double num = global::Infragistics.Windows.DeviceUnitLength.ConvertFromTwips(global::Infragistics.Windows.DeviceUnitLength.ConvertToTwips(this._left, this._unit), unitType);
			if (this.IsUniform)
			{
				return new global::Infragistics.Windows.DeviceUnitThickness(num, unitType);
			}
			return new global::Infragistics.Windows.DeviceUnitThickness(num, global::Infragistics.Windows.DeviceUnitLength.ConvertFromTwips(global::Infragistics.Windows.DeviceUnitLength.ConvertToTwips(this._top, this._unit), unitType), global::Infragistics.Windows.DeviceUnitLength.ConvertFromTwips(global::Infragistics.Windows.DeviceUnitLength.ConvertToTwips(this._right, this._unit), unitType), global::Infragistics.Windows.DeviceUnitLength.ConvertFromTwips(global::Infragistics.Windows.DeviceUnitLength.ConvertToTwips(this._bottom, this._unit), unitType), unitType);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0001F48D File Offset: 0x0001D68D
		private static void SetValue(ref double member, double newValue)
		{
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(newValue);
			member = newValue;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0001F498 File Offset: 0x0001D698
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DeviceUnitThickness && this.Equals((global::Infragistics.Windows.DeviceUnitThickness)obj);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0001F4B0 File Offset: 0x0001D6B0
		public override int GetHashCode()
		{
			return this._unit.GetHashCode() ^ this._left.GetHashCode() ^ this._right.GetHashCode() ^ this._top.GetHashCode() ^ this._bottom.GetHashCode();
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0001F500 File Offset: 0x0001D700
		public static bool operator ==(global::Infragistics.Windows.DeviceUnitThickness length1, global::Infragistics.Windows.DeviceUnitThickness length2)
		{
			return length1._unit == length2._unit && length1._left.Equals(length2._left) && length1._right.Equals(length2._right) && length1._top.Equals(length2._top) && length1._bottom.Equals(length2._bottom);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0001F571 File Offset: 0x0001D771
		public static bool operator !=(global::Infragistics.Windows.DeviceUnitThickness length1, global::Infragistics.Windows.DeviceUnitThickness length2)
		{
			return !(length1 == length2);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0001F57D File Offset: 0x0001D77D
		public bool Equals(global::Infragistics.Windows.DeviceUnitThickness other)
		{
			return this == other;
		}

		// Token: 0x040003D4 RID: 980
		private double _left;

		// Token: 0x040003D5 RID: 981
		private double _top;

		// Token: 0x040003D6 RID: 982
		private double _right;

		// Token: 0x040003D7 RID: 983
		private double _bottom;

		// Token: 0x040003D8 RID: 984
		private global::Infragistics.Windows.DeviceUnitType _unit;
	}
}
