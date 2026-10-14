using System;
using System.Text;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200002B RID: 43
	public class TOC
	{
		// Token: 0x06000148 RID: 328 RVA: 0x0000518F File Offset: 0x0000338F
		public TOC() : this(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock())
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000519C File Offset: 0x0000339C
		public TOC(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock block)
		{
			this.block = block;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr ct_SdtPr = block.AddNewSdtPr();
			ct_SdtPr.AddNewId().val = "4844945";
			ct_SdtPr.AddNewDocPartObj().AddNewDocPartGallery().val = "Table of Contents";
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts ct_Fonts = block.AddNewSdtEndPr().AddNewRPr().AddNewRFonts();
			ct_Fonts.asciiTheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme.minorHAnsi);
			ct_Fonts.eastAsiaTheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme.minorHAnsi);
			ct_Fonts.hAnsiTheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme.minorHAnsi);
			ct_Fonts.cstheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme.minorBidi);
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentBlock ct_SdtContentBlock = block.AddNewSdtContent();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_P ct_P = ct_SdtContentBlock.AddNewP();
			byte[] bytes = global::System.Text.Encoding.Unicode.GetBytes("00EF7E24");
			ct_P.rsidR = bytes;
			ct_P.rsidRDefault = bytes;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ct_PPr = ct_P.AddNewPPr();
			ct_PPr.AddNewPStyle().val = "TOCHeading";
			ct_PPr.AddNewJc().val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.center;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R = ct_P.AddNewR();
			ct_R.AddNewRPr().AddNewSz().val = 48UL;
			ct_R.AddNewT().Value = "Table of Contents";
			ct_R.AddNewBr().type = global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrType.textWrapping;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_P ct_P2 = ct_SdtContentBlock.AddNewP();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ct_PPr2 = ct_P2.AddNewPPr();
			ct_PPr2.AddNewPStyle().val = "TOC1";
			ct_PPr2.AddNewRPr().AddNewNoProof();
			ct_P2.AddNewR().AddNewFldChar().fldCharType = global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType.begin;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text ct_Text = ct_P2.AddNewR().AddNewInstrText();
			ct_Text.space = "preserve";
			ct_Text.Value = " TOC \\h \\z ";
			ct_P2.AddNewR().AddNewFldChar().fldCharType = global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType.separate;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00005304 File Offset: 0x00003504
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock GetBlock()
		{
			return this.block;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000530C File Offset: 0x0000350C
		public void AddRow(int level, string title, int page, string bookmarkRef)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_P ct_P = this.block.sdtContent.AddNewP();
			byte[] bytes = global::System.Text.Encoding.Unicode.GetBytes("00EF7E24");
			ct_P.rsidR = bytes;
			ct_P.rsidRDefault = bytes;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ct_PPr = ct_P.AddNewPPr();
			ct_PPr.AddNewPStyle().val = "TOC" + level.ToString();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop ct_TabStop = ct_PPr.AddNewTabs().AddNewTab();
			ct_TabStop.val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabJc.right;
			ct_TabStop.leader = global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabTlc.dot;
			ct_TabStop.pos = "8290";
			ct_PPr.AddNewRPr().AddNewNoProof();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R = ct_P.AddNewR();
			ct_R.AddNewRPr().AddNewNoProof();
			ct_R.AddNewT().Value = title;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R2 = ct_P.AddNewR();
			ct_R2.AddNewRPr().AddNewNoProof();
			ct_R2.AddNewTab();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R3 = ct_P.AddNewR();
			ct_R3.AddNewRPr().AddNewNoProof();
			ct_R3.AddNewFldChar().fldCharType = global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType.begin;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R4 = ct_P.AddNewR();
			ct_R4.AddNewRPr().AddNewNoProof();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text ct_Text = ct_R4.AddNewInstrText();
			ct_Text.space = "preserve";
			ct_Text.Value = " PAGEREF _Toc" + bookmarkRef + " \\h ";
			ct_P.AddNewR().AddNewRPr().AddNewNoProof();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R5 = ct_P.AddNewR();
			ct_R5.AddNewRPr().AddNewNoProof();
			ct_R5.AddNewFldChar().fldCharType = global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType.separate;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R6 = ct_P.AddNewR();
			ct_R6.AddNewRPr().AddNewNoProof();
			ct_R6.AddNewT().Value = page.ToString();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R7 = ct_P.AddNewR();
			ct_R7.AddNewRPr().AddNewNoProof();
			ct_R7.AddNewFldChar().fldCharType = global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType.end;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005488 File Offset: 0x00003688
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock Build()
		{
			if (!this.isBuilt)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R = this.block.sdtContent.AddNewP().AddNewR();
				ct_R.AddNewRPr().AddNewNoProof();
				ct_R.AddNewFldChar().fldCharType = global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType.end;
				this.isBuilt = true;
			}
			return this.block;
		}

		// Token: 0x04000152 RID: 338
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock block;

		// Token: 0x04000153 RID: 339
		private bool isBuilt;
	}
}
