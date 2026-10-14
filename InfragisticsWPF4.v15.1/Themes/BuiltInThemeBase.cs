using System;

namespace Infragistics.Themes
{
	// Token: 0x020001C7 RID: 455
	public abstract class BuiltInThemeBase : global::Infragistics.Themes.ThemeBase
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00034001 File Offset: 0x00032201
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00034009 File Offset: 0x00032209
		public bool StyleMicrosoftControls
		{
			get
			{
				return this._styleMsControls;
			}
			set
			{
				if (this._styleMsControls != value)
				{
					this._styleMsControls = value;
					global::Infragistics.Themes.ThemeManager.UpdateStylingMsControlsForTheme(this);
				}
			}
		}

		// Token: 0x0400085D RID: 2141
		private bool _styleMsControls = true;
	}
}
