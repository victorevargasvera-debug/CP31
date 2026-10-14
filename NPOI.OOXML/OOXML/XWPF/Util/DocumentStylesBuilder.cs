using System;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.UserModel;

namespace NPOI.OOXML.XWPF.Util
{
	// Token: 0x0200000D RID: 13
	public class DocumentStylesBuilder
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00004178 File Offset: 0x00002378
		public DocumentStylesBuilder()
		{
			this.documentStyles = new global::NPOI.XWPF.UserModel.XWPFStyles();
			this.ctStyles = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004196 File Offset: 0x00002396
		public DocumentStylesBuilder(global::NPOI.XWPF.UserModel.XWPFDocument docxDocument)
		{
			this.documentStyles = docxDocument.CreateStyles();
			this.ctStyles = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000041B8 File Offset: 0x000023B8
		public void AddDefaultStyle()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.ctStyles.AddNewDocDefaults().AddNewRPrDefault().AddNewRPr();
			ct_RPr.AddNewSz().val = 24UL;
			ct_RPr.AddNewSzCs().val = 24UL;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts ct_Fonts = ct_RPr.AddNewRFonts();
			ct_Fonts.asciiTheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme.minorAscii);
			ct_Fonts.cstheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme.minorBidi);
			ct_Fonts.eastAsiaTheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme.minorHAnsi);
			ct_Fonts.hAnsiTheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme.minorHAnsi);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000422C File Offset: 0x0000242C
		public void AddCustomHeadingStyle(string name, int headingLevel, int outlineLevel, int ptSize = 12)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style ct_Style = this.ctStyles.AddNewStyle();
			ct_Style.styleId = name;
			ct_Style.name = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String
			{
				val = name
			};
			ct_Style.uiPriority = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber
			{
				val = headingLevel.ToString()
			};
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			ct_Style.unhideWhenUsed = ct_OnOff;
			ct_Style.qFormat = ct_OnOff;
			ct_Style.pPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr
			{
				outlineLvl = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber
				{
					val = outlineLevel.ToString()
				}
			};
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr();
			ct_RPr.AddNewSz().val = (ulong)((long)ptSize * 2L);
			ct_Style.rPr = ct_RPr;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000042D2 File Offset: 0x000024D2
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles Build()
		{
			this.documentStyles.SetStyles(this.ctStyles);
			return this.ctStyles;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000042EC File Offset: 0x000024EC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles BuildStylesForTOC(global::NPOI.XWPF.UserModel.XWPFDocument doc = null)
		{
			global::NPOI.OOXML.XWPF.Util.DocumentStylesBuilder documentStylesBuilder;
			if (doc != null)
			{
				documentStylesBuilder = new global::NPOI.OOXML.XWPF.Util.DocumentStylesBuilder(doc);
			}
			else
			{
				documentStylesBuilder = new global::NPOI.OOXML.XWPF.Util.DocumentStylesBuilder();
			}
			documentStylesBuilder.AddDefaultStyle();
			documentStylesBuilder.AddCustomHeadingStyle("TOCHeading", 1, 9, 12);
			documentStylesBuilder.AddCustomHeadingStyle("TOC1", 2, 0, 12);
			documentStylesBuilder.AddCustomHeadingStyle("TOC2", 3, 0, 12);
			documentStylesBuilder.AddCustomHeadingStyle("Heading1", 4, 0, 12);
			documentStylesBuilder.AddCustomHeadingStyle("Heading2", 5, 1, 12);
			return documentStylesBuilder.Build();
		}

		// Token: 0x04000022 RID: 34
		private global::NPOI.XWPF.UserModel.XWPFStyles documentStyles;

		// Token: 0x04000023 RID: 35
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles ctStyles;
	}
}
