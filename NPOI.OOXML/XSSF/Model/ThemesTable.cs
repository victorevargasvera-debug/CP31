using System;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000E9 RID: 233
	public class ThemesTable : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000E7F RID: 3711 RVA: 0x000322B1 File Offset: 0x000304B1
		public ThemesTable()
		{
			this.theme = new global::NPOI.OpenXmlFormats.Spreadsheet.ThemeDocument();
			this.theme.AddNewTheme().AddNewThemeElements();
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000322D4 File Offset: 0x000304D4
		public ThemesTable(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			global::System.Xml.XmlDocument xmldoc = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(part.GetInputStream());
			try
			{
				this.theme = global::NPOI.OpenXmlFormats.Spreadsheet.ThemeDocument.Parse(xmldoc, global::NPOI.POIXMLDocumentPart.NamespaceManager);
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message, ex);
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00032328 File Offset: 0x00030528
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public ThemesTable(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00032331 File Offset: 0x00030531
		internal ThemesTable(global::NPOI.OpenXmlFormats.Spreadsheet.ThemeDocument theme)
		{
			this.theme = theme;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00032340 File Offset: 0x00030540
		public global::NPOI.XSSF.UserModel.XSSFColor GetThemeColor(int idx)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme clrScheme = this.theme.GetTheme().themeElements.clrScheme;
			global::NPOI.OpenXmlFormats.Dml.CT_Color ct_Color;
			switch (idx)
			{
			case 0:
				ct_Color = clrScheme.lt1;
				break;
			case 1:
				ct_Color = clrScheme.dk1;
				break;
			case 2:
				ct_Color = clrScheme.lt2;
				break;
			case 3:
				ct_Color = clrScheme.dk2;
				break;
			case 4:
				ct_Color = clrScheme.accent1;
				break;
			case 5:
				ct_Color = clrScheme.accent2;
				break;
			case 6:
				ct_Color = clrScheme.accent3;
				break;
			case 7:
				ct_Color = clrScheme.accent4;
				break;
			case 8:
				ct_Color = clrScheme.accent5;
				break;
			case 9:
				ct_Color = clrScheme.accent6;
				break;
			case 10:
				ct_Color = clrScheme.hlink;
				break;
			case 11:
				ct_Color = clrScheme.folHlink;
				break;
			default:
				return null;
			}
			byte[] rgb;
			if (ct_Color.IsSetSrgbClr())
			{
				rgb = ct_Color.srgbClr.val;
			}
			else
			{
				if (!ct_Color.IsSetSysClr())
				{
					return null;
				}
				rgb = ct_Color.sysClr.lastClr;
			}
			return new global::NPOI.XSSF.UserModel.XSSFColor(rgb);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00032444 File Offset: 0x00030644
		public void InheritFromThemeAsRequired(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			if (color == null)
			{
				return;
			}
			if (!color.GetCTColor().themeSpecified)
			{
				return;
			}
			global::NPOI.XSSF.UserModel.XSSFColor themeColor = this.GetThemeColor(color.Theme);
			color.GetCTColor().SetRgb(themeColor.GetCTColor().GetRgb());
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00032486 File Offset: 0x00030686
		public void writeTo(global::System.IO.Stream out1)
		{
			this.theme.Save(out1);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00032494 File Offset: 0x00030694
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.writeTo(outputStream);
			outputStream.Close();
		}

		// Token: 0x04000436 RID: 1078
		public const int THEME_LT1 = 0;

		// Token: 0x04000437 RID: 1079
		public const int THEME_DK1 = 1;

		// Token: 0x04000438 RID: 1080
		public const int THEME_LT2 = 2;

		// Token: 0x04000439 RID: 1081
		public const int THEME_DK2 = 3;

		// Token: 0x0400043A RID: 1082
		public const int THEME_ACCENT1 = 4;

		// Token: 0x0400043B RID: 1083
		public const int THEME_ACCENT2 = 5;

		// Token: 0x0400043C RID: 1084
		public const int THEME_ACCENT3 = 6;

		// Token: 0x0400043D RID: 1085
		public const int THEME_ACCENT4 = 7;

		// Token: 0x0400043E RID: 1086
		public const int THEME_ACCENT5 = 8;

		// Token: 0x0400043F RID: 1087
		public const int THEME_ACCENT6 = 9;

		// Token: 0x04000440 RID: 1088
		public const int THEME_HLINK = 10;

		// Token: 0x04000441 RID: 1089
		public const int THEME_FOLHLINK = 11;

		// Token: 0x04000442 RID: 1090
		private global::NPOI.OpenXmlFormats.Spreadsheet.ThemeDocument theme;
	}
}
