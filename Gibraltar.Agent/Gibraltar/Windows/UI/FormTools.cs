using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Gibraltar.Windows.UI
{
	// Token: 0x020000CD RID: 205
	internal static class FormTools
	{
		// Token: 0x06000885 RID: 2181 RVA: 0x000128BC File Offset: 0x00010ABC
		static FormTools()
		{
			using (global::System.Drawing.Text.InstalledFontCollection installedFontCollection = new global::System.Drawing.Text.InstalledFontCollection())
			{
				global::System.Collections.Generic.Dictionary<string, global::System.Drawing.FontFamily> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Drawing.FontFamily>(installedFontCollection.Families.Length, global::System.StringComparer.OrdinalIgnoreCase);
				foreach (global::System.Drawing.FontFamily fontFamily in installedFontCollection.Families)
				{
					try
					{
						if (!dictionary.ContainsKey(fontFamily.Name))
						{
							dictionary.Add(fontFamily.Name, fontFamily);
						}
					}
					catch (global::System.Exception ex)
					{
						global::System.Diagnostics.Trace.TraceWarning("Unable to add font family to candidate font list due to {0}\r\nWe will skip the font family {1}.\r\n{2}", new object[]
						{
							ex,
							fontFamily.Name,
							ex.Message
						});
					}
				}
				global::System.Drawing.FontFamily fontFamily2;
				if ((!dictionary.TryGetValue("Consolas", out fontFamily2) || !fontFamily2.IsStyleAvailable(global::System.Drawing.FontStyle.Regular)) && (!dictionary.TryGetValue("Lucida Console", out fontFamily2) || !fontFamily2.IsStyleAvailable(global::System.Drawing.FontStyle.Regular)))
				{
					fontFamily2 = dictionary["Courier New"];
				}
				global::Gibraltar.Windows.UI.FormTools.s_FixedWidthFont = new global::System.Drawing.Font(fontFamily2, 8f, global::System.Drawing.GraphicsUnit.Point);
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000129E4 File Offset: 0x00010BE4
		public static void ApplyOSFont(global::System.Windows.Forms.Form form)
		{
			form.Font = global::Gibraltar.Windows.UI.FormTools.MergeFont(form.Font);
			foreach (object obj in form.Controls)
			{
				global::Gibraltar.Windows.UI.FormTools.ApplyOSFont((global::System.Windows.Forms.Control)obj);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00012A54 File Offset: 0x00010C54
		public static void ApplyOSFont(global::System.Windows.Forms.Control control)
		{
			global::System.Drawing.Font font = global::Gibraltar.Windows.UI.FormTools.MergeFont(control.Font);
			if (font != control.Font)
			{
				control.Font = font;
			}
			foreach (object obj in control.Controls)
			{
				global::Gibraltar.Windows.UI.FormTools.ApplyOSFont((global::System.Windows.Forms.Control)obj);
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00012AD4 File Offset: 0x00010CD4
		public static global::System.Drawing.Font MergeFont(global::System.Drawing.Font originalFont)
		{
			if (originalFont == null)
			{
				return global::Gibraltar.Windows.UI.FormTools.OSFont;
			}
			if (global::Gibraltar.Windows.UI.FormTools.OSFont.Name.Equals(originalFont.Name))
			{
				return originalFont;
			}
			return new global::System.Drawing.Font(global::Gibraltar.Windows.UI.FormTools.OSFont.Name, originalFont.Size, originalFont.Style, global::Gibraltar.Windows.UI.FormTools.OSFont.Unit);
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x00012B34 File Offset: 0x00010D34
		public static global::System.Drawing.Font OSFont
		{
			get
			{
				return global::System.Drawing.SystemFonts.MessageBoxFont;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00012B3C File Offset: 0x00010D3C
		public static global::System.Drawing.Font FixedWidthFont
		{
			get
			{
				return global::Gibraltar.Windows.UI.FormTools.s_FixedWidthFont;
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00012B44 File Offset: 0x00010D44
		public static void FixHelpProviderPath(global::System.Windows.Forms.HelpProvider provider)
		{
			if (provider == null)
			{
				return;
			}
			string location = global::System.Reflection.Assembly.GetExecutingAssembly().Location;
			if (string.IsNullOrEmpty(location))
			{
				location = global::System.Reflection.Assembly.GetEntryAssembly().Location;
			}
			if (string.IsNullOrEmpty(location))
			{
				return;
			}
			string directoryName = global::System.IO.Path.GetDirectoryName(location);
			if (!global::System.IO.File.Exists(provider.HelpNamespace))
			{
				provider.HelpNamespace = global::System.IO.Path.Combine(directoryName, provider.HelpNamespace);
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00012BB4 File Offset: 0x00010DB4
		public static global::System.Drawing.Image ScaleIcon(global::System.Drawing.Icon icon, global::System.Drawing.Size imageSize)
		{
			if (icon == null)
			{
				return null;
			}
			global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Icon(icon, imageSize).ToBitmap();
			if (bitmap.Size != imageSize)
			{
				global::System.Drawing.Bitmap bitmap2 = new global::System.Drawing.Bitmap(imageSize.Width, imageSize.Height, global::System.Drawing.Imaging.PixelFormat.Format32bppArgb);
				using (global::System.Drawing.Graphics graphics = global::System.Drawing.Graphics.FromImage(bitmap2))
				{
					graphics.SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
					graphics.CompositingQuality = global::System.Drawing.Drawing2D.CompositingQuality.HighQuality;
					graphics.InterpolationMode = global::System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
					graphics.DrawImage(bitmap, 0, 0, bitmap2.Width, bitmap2.Height);
				}
				bitmap = bitmap2;
			}
			return bitmap;
		}

		// Token: 0x040001DB RID: 475
		private static readonly global::System.Drawing.Font s_FixedWidthFont;
	}
}
