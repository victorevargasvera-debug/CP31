using System;
using System.Collections.Generic;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000045 RID: 69
	public class XWPFRelation : global::NPOI.POIXMLRelation
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x0000AB9F File Offset: 0x00008D9F
		private XWPFRelation(string type, string rel, string defaultName, global::System.Type cls) : base(type, rel, defaultName, cls)
		{
			if (global::NPOI.XWPF.UserModel.XWPFRelation._table.ContainsKey(rel))
			{
				global::NPOI.XWPF.UserModel.XWPFRelation._table[rel] = this;
				return;
			}
			global::NPOI.XWPF.UserModel.XWPFRelation._table.Add(rel, this);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000ABD2 File Offset: 0x00008DD2
		public static global::NPOI.XWPF.UserModel.XWPFRelation GetInstance(string rel)
		{
			if (global::NPOI.XWPF.UserModel.XWPFRelation._table.ContainsKey(rel))
			{
				return global::NPOI.XWPF.UserModel.XWPFRelation._table[rel];
			}
			return null;
		}

		// Token: 0x040001F0 RID: 496
		private static global::System.Collections.Generic.Dictionary<string, global::NPOI.XWPF.UserModel.XWPFRelation> _table = new global::System.Collections.Generic.Dictionary<string, global::NPOI.XWPF.UserModel.XWPFRelation>();

		// Token: 0x040001F1 RID: 497
		public static global::NPOI.XWPF.UserModel.XWPFRelation DOCUMENT = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", "/word/document.xml", null);

		// Token: 0x040001F2 RID: 498
		public static global::NPOI.XWPF.UserModel.XWPFRelation TEMPLATE = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", "/word/document.xml", null);

		// Token: 0x040001F3 RID: 499
		public static global::NPOI.XWPF.UserModel.XWPFRelation MACRO_DOCUMENT = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.ms-word.document.macroEnabled.main+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", "/word/document.xml", null);

		// Token: 0x040001F4 RID: 500
		public static global::NPOI.XWPF.UserModel.XWPFRelation MACRO_TEMPLATE_DOCUMENT = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.ms-word.template.macroEnabledTemplate.main+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", "/word/document.xml", null);

		// Token: 0x040001F5 RID: 501
		public static global::NPOI.XWPF.UserModel.XWPFRelation GLOSSARY_DOCUMENT = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.document.glossary+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument", "/word/glossary/document.xml", null);

		// Token: 0x040001F6 RID: 502
		public static global::NPOI.XWPF.UserModel.XWPFRelation NUMBERING = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.numbering+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering", "/word/numbering.xml", typeof(global::NPOI.XWPF.UserModel.XWPFNumbering));

		// Token: 0x040001F7 RID: 503
		public static global::NPOI.XWPF.UserModel.XWPFRelation FONT_TABLE = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable", "/word/fontTable.xml", null);

		// Token: 0x040001F8 RID: 504
		public static global::NPOI.XWPF.UserModel.XWPFRelation SETTINGS = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings", "/word/settings.xml", typeof(global::NPOI.XWPF.UserModel.XWPFSettings));

		// Token: 0x040001F9 RID: 505
		public static global::NPOI.XWPF.UserModel.XWPFRelation STYLES = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles", "/word/styles.xml", typeof(global::NPOI.XWPF.UserModel.XWPFStyles));

		// Token: 0x040001FA RID: 506
		public static global::NPOI.XWPF.UserModel.XWPFRelation WEB_SETTINGS = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.webSettings+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings", "/word/webSettings.xml", null);

		// Token: 0x040001FB RID: 507
		public static global::NPOI.XWPF.UserModel.XWPFRelation HEADER = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header", "/word/header#.xml", typeof(global::NPOI.XWPF.UserModel.XWPFHeader));

		// Token: 0x040001FC RID: 508
		public static global::NPOI.XWPF.UserModel.XWPFRelation FOOTER = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer", "/word/footer#.xml", typeof(global::NPOI.XWPF.UserModel.XWPFFooter));

		// Token: 0x040001FD RID: 509
		public static global::NPOI.XWPF.UserModel.XWPFRelation THEME = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.theme+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", "/word/theme/theme#.xml", null);

		// Token: 0x040001FE RID: 510
		public static global::NPOI.XWPF.UserModel.XWPFRelation HYPERLINK = new global::NPOI.XWPF.UserModel.XWPFRelation(null, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink", null, null);

		// Token: 0x040001FF RID: 511
		public static global::NPOI.XWPF.UserModel.XWPFRelation COMMENT = new global::NPOI.XWPF.UserModel.XWPFRelation(null, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments", null, null);

		// Token: 0x04000200 RID: 512
		public static global::NPOI.XWPF.UserModel.XWPFRelation FOOTNOTE = new global::NPOI.XWPF.UserModel.XWPFRelation("application/vnd.openxmlformats-officedocument.wordprocessingml.footnotes+xml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes", "/word/footnotes.xml", typeof(global::NPOI.XWPF.UserModel.XWPFFootnotes));

		// Token: 0x04000201 RID: 513
		public static global::NPOI.XWPF.UserModel.XWPFRelation ENDNOTE = new global::NPOI.XWPF.UserModel.XWPFRelation(null, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes", null, null);

		// Token: 0x04000202 RID: 514
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_EMF = new global::NPOI.XWPF.UserModel.XWPFRelation("image/x-emf", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.emf", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x04000203 RID: 515
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_WMF = new global::NPOI.XWPF.UserModel.XWPFRelation("image/x-wmf", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.wmf", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x04000204 RID: 516
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_PICT = new global::NPOI.XWPF.UserModel.XWPFRelation("image/pict", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.pict", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x04000205 RID: 517
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_JPEG = new global::NPOI.XWPF.UserModel.XWPFRelation("image/jpeg", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.jpeg", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x04000206 RID: 518
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_PNG = new global::NPOI.XWPF.UserModel.XWPFRelation("image/png", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.png", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x04000207 RID: 519
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_DIB = new global::NPOI.XWPF.UserModel.XWPFRelation("image/dib", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.dib", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x04000208 RID: 520
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_GIF = new global::NPOI.XWPF.UserModel.XWPFRelation("image/gif", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.gif", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x04000209 RID: 521
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_TIFF = new global::NPOI.XWPF.UserModel.XWPFRelation("image/tiff", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.tiff", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x0400020A RID: 522
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_EPS = new global::NPOI.XWPF.UserModel.XWPFRelation("image/x-eps", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.eps", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x0400020B RID: 523
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_BMP = new global::NPOI.XWPF.UserModel.XWPFRelation("image/x-ms-bmp", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.bmp", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x0400020C RID: 524
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_WPG = new global::NPOI.XWPF.UserModel.XWPFRelation("image/x-wpg", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.wpg", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x0400020D RID: 525
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGE_SVG = new global::NPOI.XWPF.UserModel.XWPFRelation("image/svg", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", "/word/media/image#.svg", typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));

		// Token: 0x0400020E RID: 526
		public static global::NPOI.XWPF.UserModel.XWPFRelation IMAGES = new global::NPOI.XWPF.UserModel.XWPFRelation(null, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", null, typeof(global::NPOI.XWPF.UserModel.XWPFPictureData));
	}
}
