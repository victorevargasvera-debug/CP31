using System;
using System.ComponentModel;
using System.Windows.Media;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000231 RID: 561
	public class WashGroup
	{
		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x0004D99D File Offset: 0x0004BB9D
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x0004D9A5 File Offset: 0x0004BBA5
		[global::System.ComponentModel.DefaultValue(null)]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x0004D9AE File Offset: 0x0004BBAE
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x0004D9B8 File Offset: 0x0004BBB8
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.Media.Color>))]
		public global::System.Windows.Media.Color? WashColor
		{
			get
			{
				return this._washColor;
			}
			set
			{
				this._washColor = value;
				global::System.Windows.Media.Color color = value ?? global::System.Windows.Media.Colors.Transparent;
				this._hue = global::Infragistics.Windows.Themes.ResourceWasher.GetHue(color);
				this._saturation = global::Infragistics.Windows.Themes.ResourceWasher.GetSaturation(color);
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0004D9FE File Offset: 0x0004BBFE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWashColor()
		{
			return this._washColor != null;
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0004DA0B File Offset: 0x0004BC0B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWashColor()
		{
			this._washColor = null;
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x0004DA19 File Offset: 0x0004BC19
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x0004DA21 File Offset: 0x0004BC21
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Themes.WashMode>))]
		public global::Infragistics.Windows.Themes.WashMode? WashMode
		{
			get
			{
				return this._washMode;
			}
			set
			{
				this._washMode = value;
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0004DA2A File Offset: 0x0004BC2A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWashMode()
		{
			return this._washMode != null;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0004DA37 File Offset: 0x0004BC37
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWashMode()
		{
			this._washMode = null;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x0004DA45 File Offset: 0x0004BC45
		internal float Hue
		{
			get
			{
				return this._hue;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x0004DA4D File Offset: 0x0004BC4D
		internal float Saturation
		{
			get
			{
				return this._saturation;
			}
		}

		// Token: 0x04000B43 RID: 2883
		private string _name;

		// Token: 0x04000B44 RID: 2884
		private global::System.Windows.Media.Color? _washColor = null;

		// Token: 0x04000B45 RID: 2885
		private float _hue;

		// Token: 0x04000B46 RID: 2886
		private float _saturation;

		// Token: 0x04000B47 RID: 2887
		private global::Infragistics.Windows.Themes.WashMode? _washMode = null;
	}
}
