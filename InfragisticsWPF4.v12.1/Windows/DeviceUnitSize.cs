using System;
using System.ComponentModel;

namespace Infragistics.Windows
{
	// Token: 0x020000FD RID: 253
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DeviceUnitSizeConverter))]
	public struct DeviceUnitSize : global::System.IEquatable<global::Infragistics.Windows.DeviceUnitSize>
	{
		// Token: 0x0600096C RID: 2412 RVA: 0x0001EF05 File Offset: 0x0001D105
		public DeviceUnitSize(double width, double height)
		{
			this = new global::Infragistics.Windows.DeviceUnitSize(width, height, global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0001EF10 File Offset: 0x0001D110
		public DeviceUnitSize(double width, double height, global::Infragistics.Windows.DeviceUnitType type)
		{
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(width);
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(height);
			this._width = width;
			this._height = height;
			this._unit = type;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0001EF33 File Offset: 0x0001D133
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0001EF3B File Offset: 0x0001D13B
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

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0001EF49 File Offset: 0x0001D149
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x0001EF51 File Offset: 0x0001D151
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

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0001EF5F File Offset: 0x0001D15F
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0001EF67 File Offset: 0x0001D167
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

		// Token: 0x06000974 RID: 2420 RVA: 0x0001EF70 File Offset: 0x0001D170
		public global::Infragistics.Windows.DeviceUnitSize ConvertToUnitType(global::Infragistics.Windows.DeviceUnitType unitType)
		{
			if (this.UnitType == unitType)
			{
				return this;
			}
			return new global::Infragistics.Windows.DeviceUnitSize(global::Infragistics.Windows.DeviceUnitLength.ConvertFromTwips(global::Infragistics.Windows.DeviceUnitLength.ConvertToTwips(this._width, this._unit), unitType), global::Infragistics.Windows.DeviceUnitLength.ConvertFromTwips(global::Infragistics.Windows.DeviceUnitLength.ConvertToTwips(this._height, this._unit), unitType), unitType);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0001EFC1 File Offset: 0x0001D1C1
		private static void SetValue(ref double member, double newValue)
		{
			global::Infragistics.Windows.DeviceUnitLength.ValidateUnitLengthValue(newValue);
			member = newValue;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DeviceUnitSize && this.Equals((global::Infragistics.Windows.DeviceUnitSize)obj);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0001EFE4 File Offset: 0x0001D1E4
		public override int GetHashCode()
		{
			return this._unit.GetHashCode() ^ this._width.GetHashCode() ^ this._height.GetHashCode();
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0001F00E File Offset: 0x0001D20E
		public static bool operator ==(global::Infragistics.Windows.DeviceUnitSize length1, global::Infragistics.Windows.DeviceUnitSize length2)
		{
			return length1._unit == length2._unit && length1._width.Equals(length2._width) && length1._height.Equals(length2._height);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0001F04A File Offset: 0x0001D24A
		public static bool operator !=(global::Infragistics.Windows.DeviceUnitSize length1, global::Infragistics.Windows.DeviceUnitSize length2)
		{
			return !(length1 == length2);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0001F056 File Offset: 0x0001D256
		public bool Equals(global::Infragistics.Windows.DeviceUnitSize other)
		{
			return this == other;
		}

		// Token: 0x040003D1 RID: 977
		private double _width;

		// Token: 0x040003D2 RID: 978
		private double _height;

		// Token: 0x040003D3 RID: 979
		private global::Infragistics.Windows.DeviceUnitType _unit;
	}
}
