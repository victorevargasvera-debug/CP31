using System;
using System.ComponentModel;

namespace Infragistics.Windows
{
	// Token: 0x0200011D RID: 285
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DeviceUnitThicknessConverter))]
	public struct DeviceUnitThickness : global::System.IEquatable<global::Infragistics.Windows.DeviceUnitThickness>
	{
		// Token: 0x06000A7F RID: 2687 RVA: 0x00022E7E File Offset: 0x0002107E
		public DeviceUnitThickness(double uniformLength)
		{
			this = new global::Infragistics.Windows.DeviceUnitThickness(uniformLength, global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00022E88 File Offset: 0x00021088
		public DeviceUnitThickness(double uniformLength, global::Infragistics.Windows.DeviceUnitType type)
		{
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(uniformLength);
			this._bottom = uniformLength;
			this._top = uniformLength;
			this._right = uniformLength;
			this._left = uniformLength;
			this._unit = type;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00022EC4 File Offset: 0x000210C4
		public DeviceUnitThickness(double left, double top, double right, double bottom, global::Infragistics.Windows.DeviceUnitType type)
		{
			this._unit = type;
			this._left = (this._top = (this._right = (this._bottom = 0.0)));
			this.Left = left;
			this.Top = top;
			this.Bottom = bottom;
			this.Right = right;
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00022F20 File Offset: 0x00021120
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x00022F28 File Offset: 0x00021128
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

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x00022F36 File Offset: 0x00021136
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x00022F3E File Offset: 0x0002113E
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

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00022F4C File Offset: 0x0002114C
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x00022F54 File Offset: 0x00021154
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

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x00022F62 File Offset: 0x00021162
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x00022F6A File Offset: 0x0002116A
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

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00022F78 File Offset: 0x00021178
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00022F80 File Offset: 0x00021180
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

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00022F89 File Offset: 0x00021189
		internal bool IsUniform
		{
			get
			{
				return global::Infragistics.CoreUtilities.AreClose(this._left, this._top) && global::Infragistics.CoreUtilities.AreClose(this._left, this._right) && global::Infragistics.CoreUtilities.AreClose(this._left, this._bottom);
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00022FC4 File Offset: 0x000211C4
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

		// Token: 0x06000A8E RID: 2702 RVA: 0x00023055 File Offset: 0x00021255
		private static void SetValue(ref double member, double newValue)
		{
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(newValue);
			member = newValue;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00023060 File Offset: 0x00021260
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DeviceUnitThickness && this.Equals((global::Infragistics.Windows.DeviceUnitThickness)obj);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00023078 File Offset: 0x00021278
		public override int GetHashCode()
		{
			return this._unit.GetHashCode() ^ this._left.GetHashCode() ^ this._right.GetHashCode() ^ this._top.GetHashCode() ^ this._bottom.GetHashCode();
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000230C8 File Offset: 0x000212C8
		public static bool operator ==(global::Infragistics.Windows.DeviceUnitThickness length1, global::Infragistics.Windows.DeviceUnitThickness length2)
		{
			return length1._unit == length2._unit && length1._left.Equals(length2._left) && length1._right.Equals(length2._right) && length1._top.Equals(length2._top) && length1._bottom.Equals(length2._bottom);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00023139 File Offset: 0x00021339
		public static bool operator !=(global::Infragistics.Windows.DeviceUnitThickness length1, global::Infragistics.Windows.DeviceUnitThickness length2)
		{
			return !(length1 == length2);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00023145 File Offset: 0x00021345
		public bool Equals(global::Infragistics.Windows.DeviceUnitThickness other)
		{
			return this == other;
		}

		// Token: 0x04000487 RID: 1159
		private double _left;

		// Token: 0x04000488 RID: 1160
		private double _top;

		// Token: 0x04000489 RID: 1161
		private double _right;

		// Token: 0x0400048A RID: 1162
		private double _bottom;

		// Token: 0x0400048B RID: 1163
		private global::Infragistics.Windows.DeviceUnitType _unit;
	}
}
