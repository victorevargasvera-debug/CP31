using System;
using System.ComponentModel;

namespace Infragistics.Windows
{
	// Token: 0x0200011B RID: 283
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DeviceUnitSizeConverter))]
	public struct DeviceUnitSize : global::System.IEquatable<global::Infragistics.Windows.DeviceUnitSize>
	{
		// Token: 0x06000A6B RID: 2667 RVA: 0x00022ACD File Offset: 0x00020CCD
		public DeviceUnitSize(double width, double height)
		{
			this = new global::Infragistics.Windows.DeviceUnitSize(width, height, global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00022AD8 File Offset: 0x00020CD8
		public DeviceUnitSize(double width, double height, global::Infragistics.Windows.DeviceUnitType type)
		{
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(width);
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(height);
			this._width = width;
			this._height = height;
			this._unit = type;
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00022AFB File Offset: 0x00020CFB
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x00022B03 File Offset: 0x00020D03
		public double Width
		{
			get
			{
				return this._width;
			}
			set
			{
				global::Infragistics.Windows.DeviceUnitSize.SetValue(ref this._width, value);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00022B11 File Offset: 0x00020D11
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00022B19 File Offset: 0x00020D19
		public double Height
		{
			get
			{
				return this._height;
			}
			set
			{
				global::Infragistics.Windows.DeviceUnitSize.SetValue(ref this._height, value);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00022B27 File Offset: 0x00020D27
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00022B2F File Offset: 0x00020D2F
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

		// Token: 0x06000A73 RID: 2675 RVA: 0x00022B38 File Offset: 0x00020D38
		public global::Infragistics.Windows.DeviceUnitSize ConvertToUnitType(global::Infragistics.Windows.DeviceUnitType unitType)
		{
			if (this.UnitType == unitType)
			{
				return this;
			}
			return new global::Infragistics.Windows.DeviceUnitSize(global::Infragistics.Windows.DeviceUnitLength.ConvertFromTwips(global::Infragistics.Windows.DeviceUnitLength.ConvertToTwips(this._width, this._unit), unitType), global::Infragistics.Windows.DeviceUnitLength.ConvertFromTwips(global::Infragistics.Windows.DeviceUnitLength.ConvertToTwips(this._height, this._unit), unitType), unitType);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00022B89 File Offset: 0x00020D89
		private static void SetValue(ref double member, double newValue)
		{
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(newValue);
			member = newValue;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00022B94 File Offset: 0x00020D94
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DeviceUnitSize && this.Equals((global::Infragistics.Windows.DeviceUnitSize)obj);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00022BAC File Offset: 0x00020DAC
		public override int GetHashCode()
		{
			return this._unit.GetHashCode() ^ this._width.GetHashCode() ^ this._height.GetHashCode();
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00022BD6 File Offset: 0x00020DD6
		public static bool operator ==(global::Infragistics.Windows.DeviceUnitSize length1, global::Infragistics.Windows.DeviceUnitSize length2)
		{
			return length1._unit == length2._unit && length1._width.Equals(length2._width) && length1._height.Equals(length2._height);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00022C12 File Offset: 0x00020E12
		public static bool operator !=(global::Infragistics.Windows.DeviceUnitSize length1, global::Infragistics.Windows.DeviceUnitSize length2)
		{
			return !(length1 == length2);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00022C1E File Offset: 0x00020E1E
		public bool Equals(global::Infragistics.Windows.DeviceUnitSize other)
		{
			return this == other;
		}

		// Token: 0x04000484 RID: 1156
		private double _width;

		// Token: 0x04000485 RID: 1157
		private double _height;

		// Token: 0x04000486 RID: 1158
		private global::Infragistics.Windows.DeviceUnitType _unit;
	}
}
