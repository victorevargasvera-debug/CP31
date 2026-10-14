using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200004E RID: 78
	public class XWPFStyles : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000344 RID: 836 RVA: 0x0000CF92 File Offset: 0x0000B192
		public XWPFStyles(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000CFA6 File Offset: 0x0000B1A6
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public XWPFStyles(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000CFAF File Offset: 0x0000B1AF
		public XWPFStyles()
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000CFC4 File Offset: 0x0000B1C4
		internal override void OnDocumentRead()
		{
			global::System.IO.Stream inputStream = base.GetPackagePart().GetInputStream();
			try
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.StylesDocument stylesDocument = global::NPOI.OpenXmlFormats.Wordprocessing.StylesDocument.Parse(global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(inputStream), global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.SetStyles(stylesDocument.Styles);
				this.latentStyles = new global::NPOI.XWPF.UserModel.XWPFLatentStyles(this.ctStyles.latentStyles, this);
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::NPOI.POIXMLException("Unable to read styles", ex);
			}
			finally
			{
				inputStream.Close();
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000D044 File Offset: 0x0000B244
		protected internal override void Commit()
		{
			if (this.ctStyles == null)
			{
				throw new global::System.InvalidOperationException("Unable to write out styles that were never read in!");
			}
			using (global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream())
			{
				new global::NPOI.OpenXmlFormats.Wordprocessing.StylesDocument(this.ctStyles).Save(outputStream);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000D0A0 File Offset: 0x0000B2A0
		protected void EnsureDocDefaults()
		{
			if (!this.ctStyles.IsSetDocDefaults())
			{
				this.ctStyles.AddNewDocDefaults();
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocDefaults docDefaults = this.ctStyles.docDefaults;
			if (!docDefaults.IsSetPPrDefault())
			{
				docDefaults.AddNewPPrDefault();
			}
			if (!docDefaults.IsSetRPrDefault())
			{
				docDefaults.AddNewRPrDefault();
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrDefault pPrDefault = docDefaults.pPrDefault;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrDefault rPrDefault = docDefaults.rPrDefault;
			if (!pPrDefault.IsSetPPr())
			{
				pPrDefault.AddNewPPr();
			}
			if (!rPrDefault.IsSetRPr())
			{
				rPrDefault.AddNewRPr();
			}
			this.defaultRunStyle = new global::NPOI.XWPF.UserModel.XWPFDefaultRunStyle(rPrDefault.rPr);
			this.defaultParaStyle = new global::NPOI.XWPF.UserModel.XWPFDefaultParagraphStyle(pPrDefault.pPr);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000D140 File Offset: 0x0000B340
		public void SetStyles(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles styles)
		{
			this.ctStyles = styles;
			foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style style in this.ctStyles.GetStyleList())
			{
				this.listStyle.Add(new global::NPOI.XWPF.UserModel.XWPFStyle(style, this));
			}
			if (this.ctStyles.IsSetDocDefaults())
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocDefaults docDefaults = this.ctStyles.docDefaults;
				if (docDefaults.IsSetRPrDefault() && docDefaults.rPrDefault.IsSetRPr())
				{
					this.defaultRunStyle = new global::NPOI.XWPF.UserModel.XWPFDefaultRunStyle(docDefaults.rPrDefault.rPr);
				}
				if (docDefaults.IsSetPPrDefault() && docDefaults.pPrDefault.IsSetPPr())
				{
					this.defaultParaStyle = new global::NPOI.XWPF.UserModel.XWPFDefaultParagraphStyle(docDefaults.pPrDefault.pPr);
				}
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000D214 File Offset: 0x0000B414
		public bool StyleExist(string styleID)
		{
			using (global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFStyle>.Enumerator enumerator = this.listStyle.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.StyleId.Equals(styleID))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000D274 File Offset: 0x0000B474
		public void AddStyle(global::NPOI.XWPF.UserModel.XWPFStyle style)
		{
			this.listStyle.Add(style);
			this.ctStyles.AddNewStyle();
			int pos = this.ctStyles.GetStyleList().Count - 1;
			this.ctStyles.SetStyleArray(pos, style.GetCTStyle());
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		public global::NPOI.XWPF.UserModel.XWPFStyle GetStyle(string styleID)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFStyle xwpfstyle in this.listStyle)
			{
				if (xwpfstyle.StyleId.Equals(styleID))
				{
					return xwpfstyle;
				}
			}
			return null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000D324 File Offset: 0x0000B524
		public global::NPOI.XWPF.UserModel.XWPFStyle GetStyleWithName(string styleName)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFStyle xwpfstyle in this.listStyle)
			{
				if (xwpfstyle.Name == styleName)
				{
					return xwpfstyle;
				}
			}
			return null;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0000D388 File Offset: 0x0000B588
		public int NumberOfStyles
		{
			get
			{
				return this.listStyle.Count;
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000D398 File Offset: 0x0000B598
		public global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFStyle> GetUsedStyleList(global::NPOI.XWPF.UserModel.XWPFStyle style)
		{
			return this.GetUsedStyleList(style, new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFStyle>
			{
				style
			});
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFStyle> GetUsedStyleList(global::NPOI.XWPF.UserModel.XWPFStyle style, global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFStyle> usedStyleList)
		{
			string basisStyleID = style.BasisStyleID;
			global::NPOI.XWPF.UserModel.XWPFStyle style2 = this.GetStyle(basisStyleID);
			if (style2 != null && !usedStyleList.Contains(style2))
			{
				usedStyleList.Add(style2);
				this.GetUsedStyleList(style2, usedStyleList);
			}
			string linkStyleID = style.LinkStyleID;
			global::NPOI.XWPF.UserModel.XWPFStyle style3 = this.GetStyle(linkStyleID);
			if (style3 != null && !usedStyleList.Contains(style3))
			{
				usedStyleList.Add(style3);
				this.GetUsedStyleList(style3, usedStyleList);
			}
			string nextStyleID = style.NextStyleID;
			global::NPOI.XWPF.UserModel.XWPFStyle style4 = this.GetStyle(nextStyleID);
			if (style4 != null && !usedStyleList.Contains(style4))
			{
				usedStyleList.Add(style3);
				this.GetUsedStyleList(style3, usedStyleList);
			}
			return usedStyleList;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000D450 File Offset: 0x0000B650
		protected global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language GetCTLanguage()
		{
			this.EnsureDocDefaults();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language result;
			if (this.defaultRunStyle.GetRPr().IsSetLang())
			{
				result = this.defaultRunStyle.GetRPr().lang;
			}
			else
			{
				result = this.defaultRunStyle.GetRPr().AddNewLang();
			}
			return result;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000D49C File Offset: 0x0000B69C
		public void SetSpellingLanguage(string strSpellingLanguage)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language ctlanguage = this.GetCTLanguage();
			ctlanguage.val = strSpellingLanguage;
			ctlanguage.bidi = strSpellingLanguage;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000D4B1 File Offset: 0x0000B6B1
		public void SetEastAsia(string strEastAsia)
		{
			this.GetCTLanguage().eastAsia = strEastAsia;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000D4BF File Offset: 0x0000B6BF
		public void SetDefaultFonts(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts fonts)
		{
			this.EnsureDocDefaults();
			this.defaultRunStyle.GetRPr().rFonts = fonts;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
		public global::NPOI.XWPF.UserModel.XWPFStyle GetStyleWithSameName(global::NPOI.XWPF.UserModel.XWPFStyle style)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFStyle xwpfstyle in this.listStyle)
			{
				if (xwpfstyle.HasSameName(style))
				{
					return xwpfstyle;
				}
			}
			return null;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0000D534 File Offset: 0x0000B734
		public global::NPOI.XWPF.UserModel.XWPFDefaultRunStyle DefaultRunStyle
		{
			get
			{
				this.EnsureDocDefaults();
				return this.defaultRunStyle;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000D542 File Offset: 0x0000B742
		public global::NPOI.XWPF.UserModel.XWPFDefaultParagraphStyle DefaultParagraphStyle
		{
			get
			{
				this.EnsureDocDefaults();
				return this.defaultParaStyle;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000D550 File Offset: 0x0000B750
		public global::NPOI.XWPF.UserModel.XWPFLatentStyles LatentStyles
		{
			get
			{
				return this.latentStyles;
			}
		}

		// Token: 0x04000224 RID: 548
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles ctStyles;

		// Token: 0x04000225 RID: 549
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFStyle> listStyle = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFStyle>();

		// Token: 0x04000226 RID: 550
		private global::NPOI.XWPF.UserModel.XWPFLatentStyles latentStyles;

		// Token: 0x04000227 RID: 551
		private global::NPOI.XWPF.UserModel.XWPFDefaultRunStyle defaultRunStyle;

		// Token: 0x04000228 RID: 552
		private global::NPOI.XWPF.UserModel.XWPFDefaultParagraphStyle defaultParaStyle;
	}
}
