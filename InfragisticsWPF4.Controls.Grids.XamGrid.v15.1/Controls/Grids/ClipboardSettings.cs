using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000010 RID: 16
	public class ClipboardSettings : global::Infragistics.Controls.Grids.SettingsBase
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000080BA File Offset: 0x000062BA
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000080CC File Offset: 0x000062CC
		public bool AllowCopy
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ClipboardSettings.AllowCopyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ClipboardSettings.AllowCopyProperty, value);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000080DF File Offset: 0x000062DF
		private static void AllowCopyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000080E1 File Offset: 0x000062E1
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000080F3 File Offset: 0x000062F3
		public global::Infragistics.Controls.Grids.GridClipboardCopyOptions CopyOptions
		{
			get
			{
				return (global::Infragistics.Controls.Grids.GridClipboardCopyOptions)base.GetValue(global::Infragistics.Controls.Grids.ClipboardSettings.CopyOptionsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ClipboardSettings.CopyOptionsProperty, value);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00008106 File Offset: 0x00006306
		private static void CopyOptionsChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00008108 File Offset: 0x00006308
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000811A File Offset: 0x0000631A
		public global::Infragistics.Controls.Grids.GridClipboardCopyType CopyType
		{
			get
			{
				return (global::Infragistics.Controls.Grids.GridClipboardCopyType)base.GetValue(global::Infragistics.Controls.Grids.ClipboardSettings.CopyTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ClipboardSettings.CopyTypeProperty, value);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000812D File Offset: 0x0000632D
		private static void CopyTypeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000812F File Offset: 0x0000632F
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00008141 File Offset: 0x00006341
		public bool AllowPaste
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ClipboardSettings.AllowPasteProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ClipboardSettings.AllowPasteProperty, value);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00008154 File Offset: 0x00006354
		private static void AllowPasteChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x0400003C RID: 60
		public static readonly global::System.Windows.DependencyProperty AllowCopyProperty = global::System.Windows.DependencyProperty.Register("AllowCopy", typeof(bool), typeof(global::Infragistics.Controls.Grids.ClipboardSettings), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ClipboardSettings.AllowCopyChanged)));

		// Token: 0x0400003D RID: 61
		public static readonly global::System.Windows.DependencyProperty CopyOptionsProperty = global::System.Windows.DependencyProperty.Register("CopyOptions", typeof(global::Infragistics.Controls.Grids.GridClipboardCopyOptions), typeof(global::Infragistics.Controls.Grids.ClipboardSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.GridClipboardCopyOptions.IncludeHeaders, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ClipboardSettings.CopyOptionsChanged)));

		// Token: 0x0400003E RID: 62
		public static readonly global::System.Windows.DependencyProperty CopyTypeProperty = global::System.Windows.DependencyProperty.Register("CopyType", typeof(global::Infragistics.Controls.Grids.GridClipboardCopyType), typeof(global::Infragistics.Controls.Grids.ClipboardSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.GridClipboardCopyType.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ClipboardSettings.CopyTypeChanged)));

		// Token: 0x0400003F RID: 63
		public static readonly global::System.Windows.DependencyProperty AllowPasteProperty = global::System.Windows.DependencyProperty.Register("AllowPaste", typeof(bool), typeof(global::Infragistics.Controls.Grids.ClipboardSettings), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ClipboardSettings.AllowPasteChanged)));
	}
}
