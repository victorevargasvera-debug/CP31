using System;
using System.ComponentModel;
using System.Windows.Media;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000201 RID: 513
	public class WashGroup
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00047C51 File Offset: 0x00045E51
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x00047C59 File Offset: 0x00045E59
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

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00047C62 File Offset: 0x00045E62
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x00047C6C File Offset: 0x00045E6C
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

		// Token: 0x06001373 RID: 4979 RVA: 0x00047CB2 File Offset: 0x00045EB2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWashColor()
		{
			return this._washColor != null;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00047CBF File Offset: 0x00045EBF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWashColor()
		{
			this._washColor = null;
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00047CCD File Offset: 0x00045ECD
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x00047CD5 File Offset: 0x00045ED5
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

		// Token: 0x06001377 RID: 4983 RVA: 0x00047CDE File Offset: 0x00045EDE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWashMode()
		{
			return this._washMode != null;
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00047CEB File Offset: 0x00045EEB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWashMode()
		{
			this._washMode = null;
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x00047CF9 File Offset: 0x00045EF9
		internal float Hue
		{
			get
			{
				return this._hue;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x00047D01 File Offset: 0x00045F01
		internal float Saturation
		{
			get
			{
				return this._saturation;
			}
		}

		// Token: 0x040009F8 RID: 2552
		private string _name;

		// Token: 0x040009F9 RID: 2553
		private global::System.Windows.Media.Color? _washColor = null;

		// Token: 0x040009FA RID: 2554
		private float _hue;

		// Token: 0x040009FB RID: 2555
		private float _saturation;

		// Token: 0x040009FC RID: 2556
		private global::Infragistics.Windows.Themes.WashMode? _washMode = null;
	}
}
