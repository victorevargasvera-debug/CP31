using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;
using NPOI.Util;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x020000A3 RID: 163
	public class XSSFTextParagraph : global::System.Collections.Generic.IEnumerator<global::NPOI.XSSF.UserModel.XSSFTextRun>, global::System.IDisposable, global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerable<global::NPOI.XSSF.UserModel.XSSFTextRun>, global::System.Collections.IEnumerable
	{
		// Token: 0x060009F0 RID: 2544 RVA: 0x00024544 File Offset: 0x00022744
		public XSSFTextParagraph(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph p, global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ctShape)
		{
			this._p = p;
			this._shape = ctShape;
			this._Runs = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTextRun>();
			foreach (object obj in this._p.r)
			{
				if (obj is global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun)
				{
					global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun r = (global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun)obj;
					this._Runs.Add(new global::NPOI.XSSF.UserModel.XSSFTextRun(r, this));
				}
				else if (obj is global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak)
				{
					global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak ct_TextLineBreak = (global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak)obj;
					global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun ct_RegularTextRun = new global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun();
					ct_RegularTextRun.rPr = ct_TextLineBreak.rPr;
					ct_RegularTextRun.t = "\n";
					this._Runs.Add(new global::NPOI.XSSF.UserModel.XSSFTextRun(ct_RegularTextRun, this));
				}
				else if (obj is global::NPOI.OpenXmlFormats.Dml.CT_TextField)
				{
					global::NPOI.OpenXmlFormats.Dml.CT_TextField ct_TextField = (global::NPOI.OpenXmlFormats.Dml.CT_TextField)obj;
					global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun ct_RegularTextRun2 = new global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun();
					ct_RegularTextRun2.rPr = ct_TextField.rPr;
					ct_RegularTextRun2.t = ct_TextField.t;
					this._Runs.Add(new global::NPOI.XSSF.UserModel.XSSFTextRun(ct_RegularTextRun2, this));
				}
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0002466C File Offset: 0x0002286C
		public string Text
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				foreach (global::NPOI.XSSF.UserModel.XSSFTextRun xssftextRun in this._Runs)
				{
					stringBuilder.Append(xssftextRun.Text);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000246D4 File Offset: 0x000228D4
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph GetXmlObject()
		{
			return this._p;
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000246DC File Offset: 0x000228DC
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ParentShape
		{
			get
			{
				return this._shape;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000246E4 File Offset: 0x000228E4
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTextRun> TextRuns
		{
			get
			{
				return this._Runs;
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000246EC File Offset: 0x000228EC
		public global::NPOI.XSSF.UserModel.XSSFTextRun AddNewTextRun()
		{
			global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun ct_RegularTextRun = this._p.AddNewR();
			ct_RegularTextRun.AddNewRPr().lang = "en-US";
			global::NPOI.XSSF.UserModel.XSSFTextRun xssftextRun = new global::NPOI.XSSF.UserModel.XSSFTextRun(ct_RegularTextRun, this);
			this._Runs.Add(xssftextRun);
			return xssftextRun;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00024728 File Offset: 0x00022928
		public global::NPOI.XSSF.UserModel.XSSFTextRun AddLineBreak()
		{
			global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties ct_TextCharacterProperties = this._p.AddNewBr().AddNewRPr();
			if (this._Runs.Count > 0)
			{
				ct_TextCharacterProperties = this._Runs[this._Runs.Count - 1].GetRPr();
			}
			global::NPOI.XSSF.UserModel.XSSFTextRun xssftextRun = new global::NPOI.XSSF.UserModel.XSSFLineBreak(new global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun
			{
				rPr = ct_TextCharacterProperties,
				t = "\n"
			}, this, ct_TextCharacterProperties);
			this._Runs.Add(xssftextRun);
			return xssftextRun;
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x000247A0 File Offset: 0x000229A0
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x000247E4 File Offset: 0x000229E4
		public global::NPOI.XSSF.UserModel.TextAlign TextAlign
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyTextAlignFetcher paragraphPropertyTextAlignFetcher = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyTextAlignFetcher(this.Level);
				this.fetchParagraphProperty(paragraphPropertyTextAlignFetcher);
				if (paragraphPropertyTextAlignFetcher.GetValue() != null)
				{
					return paragraphPropertyTextAlignFetcher.GetValue().Value;
				}
				return global::NPOI.XSSF.UserModel.TextAlign.LEFT;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				if (value == global::NPOI.XSSF.UserModel.TextAlign.None)
				{
					if (ct_TextParagraphProperties.IsSetAlgn())
					{
						ct_TextParagraphProperties.UnsetAlgn();
						return;
					}
				}
				else
				{
					ct_TextParagraphProperties.algn = (global::NPOI.OpenXmlFormats.Dml.ST_TextAlignType)(value - 1);
				}
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00024834 File Offset: 0x00022A34
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00024878 File Offset: 0x00022A78
		public global::NPOI.XSSF.UserModel.TextFontAlign TextFontAlign
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherTextFontAlign paragraphPropertyFetcherTextFontAlign = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherTextFontAlign(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherTextFontAlign);
				if (paragraphPropertyFetcherTextFontAlign.GetValue() != null)
				{
					return paragraphPropertyFetcherTextFontAlign.GetValue().Value;
				}
				return global::NPOI.XSSF.UserModel.TextFontAlign.BASELINE;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				if (value == global::NPOI.XSSF.UserModel.TextFontAlign.None)
				{
					if (ct_TextParagraphProperties.IsSetFontAlgn())
					{
						ct_TextParagraphProperties.UnsetFontAlgn();
						return;
					}
				}
				else
				{
					ct_TextParagraphProperties.fontAlgn = (global::NPOI.OpenXmlFormats.Dml.ST_TextFontAlignType)(value - 1);
				}
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x000248C8 File Offset: 0x00022AC8
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x000248F0 File Offset: 0x00022AF0
		public string BulletFont
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletFont paragraphPropertyFetcherBulletFont = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletFont(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherBulletFont);
				return paragraphPropertyFetcherBulletFont.GetValue();
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				(ct_TextParagraphProperties.IsSetBuFont() ? ct_TextParagraphProperties.buFont : ct_TextParagraphProperties.AddNewBuFont()).typeface = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00024940 File Offset: 0x00022B40
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00024968 File Offset: 0x00022B68
		public string BulletCharacter
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletCharacter paragraphPropertyFetcherBulletCharacter = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletCharacter(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherBulletCharacter);
				return paragraphPropertyFetcherBulletCharacter.GetValue();
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				(ct_TextParagraphProperties.IsSetBuChar() ? ct_TextParagraphProperties.buChar : ct_TextParagraphProperties.AddNewBuChar()).@char = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x000249B8 File Offset: 0x00022BB8
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x000249E0 File Offset: 0x00022BE0
		public global::System.Drawing.Color BulletFontColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletFontColor paragraphPropertyFetcherBulletFontColor = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletFontColor(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherBulletFontColor);
				return paragraphPropertyFetcherBulletFontColor.GetValue();
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				global::NPOI.OpenXmlFormats.Dml.CT_Color ct_Color = ct_TextParagraphProperties.IsSetBuClr() ? ct_TextParagraphProperties.buClr : ct_TextParagraphProperties.AddNewBuClr();
				(ct_Color.IsSetSrgbClr() ? ct_Color.srgbClr : ct_Color.AddNewSrgbClr()).val = new byte[]
				{
					value.R,
					value.G,
					value.B
				};
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00024A6C File Offset: 0x00022C6C
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00024AB8 File Offset: 0x00022CB8
		public double BulletFontSize
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletFontSize paragraphPropertyFetcherBulletFontSize = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletFontSize(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherBulletFontSize);
				if (paragraphPropertyFetcherBulletFontSize.GetValue() != null)
				{
					return paragraphPropertyFetcherBulletFontSize.GetValue().Value;
				}
				return 100.0;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				if (value >= 0.0)
				{
					(ct_TextParagraphProperties.IsSetBuSzPct() ? ct_TextParagraphProperties.buSzPct : ct_TextParagraphProperties.AddNewBuSzPct()).val = (int)(value * 1000.0);
					if (ct_TextParagraphProperties.IsSetBuSzPts())
					{
						ct_TextParagraphProperties.UnsetBuSzPts();
						return;
					}
				}
				else
				{
					(ct_TextParagraphProperties.IsSetBuSzPts() ? ct_TextParagraphProperties.buSzPts : ct_TextParagraphProperties.AddNewBuSzPts()).val = (int)(-value * 100.0);
					if (ct_TextParagraphProperties.IsSetBuSzPct())
					{
						ct_TextParagraphProperties.UnsetBuSzPct();
					}
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00024B64 File Offset: 0x00022D64
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00024B8C File Offset: 0x00022D8C
		public double Indent
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherIndent paragraphPropertyFetcherIndent = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherIndent(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherIndent);
				return paragraphPropertyFetcherIndent.GetValue();
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				if (value == -1.0)
				{
					if (ct_TextParagraphProperties.IsSetIndent())
					{
						ct_TextParagraphProperties.UnsetIndent();
						return;
					}
				}
				else
				{
					ct_TextParagraphProperties.indent = global::NPOI.Util.Units.ToEMU(value);
				}
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00024BE8 File Offset: 0x00022DE8
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00024C10 File Offset: 0x00022E10
		public double LeftMargin
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherLeftMargin paragraphPropertyFetcherLeftMargin = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherLeftMargin(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherLeftMargin);
				return paragraphPropertyFetcherLeftMargin.GetValue();
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				if (value == -1.0)
				{
					if (ct_TextParagraphProperties.IsSetMarL())
					{
						ct_TextParagraphProperties.UnsetMarL();
						return;
					}
				}
				else
				{
					ct_TextParagraphProperties.marL = global::NPOI.Util.Units.ToEMU(value);
				}
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x00024C6C File Offset: 0x00022E6C
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x00024C94 File Offset: 0x00022E94
		public double RightMargin
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherRightMargin paragraphPropertyFetcherRightMargin = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherRightMargin(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherRightMargin);
				return paragraphPropertyFetcherRightMargin.GetValue();
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				if (value == -1.0)
				{
					if (ct_TextParagraphProperties.IsSetMarR())
					{
						ct_TextParagraphProperties.UnsetMarR();
						return;
					}
				}
				else
				{
					ct_TextParagraphProperties.marR = global::NPOI.Util.Units.ToEMU(value);
				}
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00024CF0 File Offset: 0x00022EF0
		public double DefaultTabSize
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherDefaultTabSize paragraphPropertyFetcherDefaultTabSize = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherDefaultTabSize(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherDefaultTabSize);
				return paragraphPropertyFetcherDefaultTabSize.GetValue();
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00024D18 File Offset: 0x00022F18
		public double GetTabStop(int idx)
		{
			global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherTabStop paragraphPropertyFetcherTabStop = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherTabStop(this.Level, idx);
			this.fetchParagraphProperty(paragraphPropertyFetcherTabStop);
			return paragraphPropertyFetcherTabStop.GetValue();
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00024D40 File Offset: 0x00022F40
		public void AddTabStop(double value)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
			(ct_TextParagraphProperties.IsSetTabLst() ? ct_TextParagraphProperties.tabLst : ct_TextParagraphProperties.AddNewTabLst()).AddNewTab().pos = global::NPOI.Util.Units.ToEMU(value);
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00024D9C File Offset: 0x00022F9C
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x00024E30 File Offset: 0x00023030
		public double LineSpacing
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherLineSpacing paragraphPropertyFetcherLineSpacing = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherLineSpacing(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherLineSpacing);
				double num = (paragraphPropertyFetcherLineSpacing.GetValue() == null) ? 100.0 : paragraphPropertyFetcherLineSpacing.GetValue().Value;
				if (num > 0.0)
				{
					global::NPOI.OpenXmlFormats.Dml.CT_TextNormalAutofit normAutofit = this._shape.txBody.bodyPr.normAutofit;
					if (normAutofit != null)
					{
						double num2 = 1.0 - (double)normAutofit.lnSpcReduction / 100000.0;
						num *= num2;
					}
				}
				return num;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing ct_TextSpacing = new global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing();
				if (value >= 0.0)
				{
					ct_TextSpacing.AddNewSpcPct().val = (int)(value * 1000.0);
				}
				else
				{
					ct_TextSpacing.AddNewSpcPts().val = (int)(-value * 100.0);
				}
				ct_TextParagraphProperties.lnSpc = ct_TextSpacing;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00024EAC File Offset: 0x000230AC
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00024ED4 File Offset: 0x000230D4
		public double SpaceBefore
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherSpaceBefore paragraphPropertyFetcherSpaceBefore = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherSpaceBefore(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherSpaceBefore);
				return paragraphPropertyFetcherSpaceBefore.GetValue();
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing ct_TextSpacing = new global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing();
				if (value >= 0.0)
				{
					ct_TextSpacing.AddNewSpcPct().val = (int)(value * 1000.0);
				}
				else
				{
					ct_TextSpacing.AddNewSpcPts().val = (int)(-value * 100.0);
				}
				ct_TextParagraphProperties.spcBef = ct_TextSpacing;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00024F50 File Offset: 0x00023150
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00024F78 File Offset: 0x00023178
		public double SpaceAfter
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherSpaceAfter paragraphPropertyFetcherSpaceAfter = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherSpaceAfter(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherSpaceAfter);
				return paragraphPropertyFetcherSpaceAfter.GetValue();
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing ct_TextSpacing = new global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing();
				if (value >= 0.0)
				{
					ct_TextSpacing.AddNewSpcPct().val = (int)(value * 1000.0);
				}
				else
				{
					ct_TextSpacing.AddNewSpcPts().val = (int)(-value * 100.0);
				}
				ct_TextParagraphProperties.spcAft = ct_TextSpacing;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00024FF4 File Offset: 0x000231F4
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00025018 File Offset: 0x00023218
		public int Level
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties pPr = this._p.pPr;
				if (pPr == null)
				{
					return 0;
				}
				return pPr.lvl;
			}
			set
			{
				(this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr()).lvl = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00025048 File Offset: 0x00023248
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x0002508C File Offset: 0x0002328C
		public bool IsBullet
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBullet paragraphPropertyFetcherBullet = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBullet(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherBullet);
				return paragraphPropertyFetcherBullet.GetValue() != null && paragraphPropertyFetcherBullet.GetValue().Value;
			}
			set
			{
				if (this.IsBullet == value)
				{
					return;
				}
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
				if (!value)
				{
					ct_TextParagraphProperties.AddNewBuNone();
					if (ct_TextParagraphProperties.IsSetBuAutoNum())
					{
						ct_TextParagraphProperties.UnsetBuAutoNum();
					}
					if (ct_TextParagraphProperties.IsSetBuBlip())
					{
						ct_TextParagraphProperties.UnsetBuBlip();
					}
					if (ct_TextParagraphProperties.IsSetBuChar())
					{
						ct_TextParagraphProperties.UnsetBuChar();
					}
					if (ct_TextParagraphProperties.IsSetBuClr())
					{
						ct_TextParagraphProperties.UnsetBuClr();
					}
					if (ct_TextParagraphProperties.IsSetBuClrTx())
					{
						ct_TextParagraphProperties.UnsetBuClrTx();
					}
					if (ct_TextParagraphProperties.IsSetBuFont())
					{
						ct_TextParagraphProperties.UnsetBuFont();
					}
					if (ct_TextParagraphProperties.IsSetBuFontTx())
					{
						ct_TextParagraphProperties.UnsetBuFontTx();
					}
					if (ct_TextParagraphProperties.IsSetBuSzPct())
					{
						ct_TextParagraphProperties.UnsetBuSzPct();
					}
					if (ct_TextParagraphProperties.IsSetBuSzPts())
					{
						ct_TextParagraphProperties.UnsetBuSzPts();
					}
					if (ct_TextParagraphProperties.IsSetBuSzTx())
					{
						ct_TextParagraphProperties.UnsetBuSzTx();
						return;
					}
				}
				else
				{
					if (ct_TextParagraphProperties.IsSetBuNone())
					{
						ct_TextParagraphProperties.UnsetBuNone();
					}
					if (!ct_TextParagraphProperties.IsSetBuFont())
					{
						ct_TextParagraphProperties.AddNewBuFont().typeface = "Arial";
					}
					if (!ct_TextParagraphProperties.IsSetBuAutoNum())
					{
						ct_TextParagraphProperties.AddNewBuChar().@char = "•";
					}
				}
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000251A0 File Offset: 0x000233A0
		public void SetBullet(bool flag)
		{
			if (this.IsBullet == flag)
			{
				return;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
			if (!flag)
			{
				ct_TextParagraphProperties.AddNewBuNone();
				if (ct_TextParagraphProperties.IsSetBuAutoNum())
				{
					ct_TextParagraphProperties.UnsetBuAutoNum();
				}
				if (ct_TextParagraphProperties.IsSetBuBlip())
				{
					ct_TextParagraphProperties.UnsetBuBlip();
				}
				if (ct_TextParagraphProperties.IsSetBuChar())
				{
					ct_TextParagraphProperties.UnsetBuChar();
				}
				if (ct_TextParagraphProperties.IsSetBuClr())
				{
					ct_TextParagraphProperties.UnsetBuClr();
				}
				if (ct_TextParagraphProperties.IsSetBuClrTx())
				{
					ct_TextParagraphProperties.UnsetBuClrTx();
				}
				if (ct_TextParagraphProperties.IsSetBuFont())
				{
					ct_TextParagraphProperties.UnsetBuFont();
				}
				if (ct_TextParagraphProperties.IsSetBuFontTx())
				{
					ct_TextParagraphProperties.UnsetBuFontTx();
				}
				if (ct_TextParagraphProperties.IsSetBuSzPct())
				{
					ct_TextParagraphProperties.UnsetBuSzPct();
				}
				if (ct_TextParagraphProperties.IsSetBuSzPts())
				{
					ct_TextParagraphProperties.UnsetBuSzPts();
				}
				if (ct_TextParagraphProperties.IsSetBuSzTx())
				{
					ct_TextParagraphProperties.UnsetBuSzTx();
					return;
				}
			}
			else
			{
				if (ct_TextParagraphProperties.IsSetBuNone())
				{
					ct_TextParagraphProperties.UnsetBuNone();
				}
				if (!ct_TextParagraphProperties.IsSetBuFont())
				{
					ct_TextParagraphProperties.AddNewBuFont().typeface = "Arial";
				}
				if (!ct_TextParagraphProperties.IsSetBuAutoNum())
				{
					ct_TextParagraphProperties.AddNewBuChar().@char = "•";
				}
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000252B4 File Offset: 0x000234B4
		public void SetBullet(global::NPOI.XSSF.UserModel.ListAutoNumber scheme, int startAt)
		{
			if (startAt < 1)
			{
				throw new global::System.ArgumentException("Start Number must be greater or equal that 1");
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
			global::NPOI.OpenXmlFormats.Dml.CT_TextAutonumberBullet ct_TextAutonumberBullet = ct_TextParagraphProperties.IsSetBuAutoNum() ? ct_TextParagraphProperties.buAutoNum : ct_TextParagraphProperties.AddNewBuAutoNum();
			ct_TextAutonumberBullet.type = (global::NPOI.OpenXmlFormats.Dml.ST_TextAutonumberScheme)scheme;
			ct_TextAutonumberBullet.startAt = startAt;
			if (!ct_TextParagraphProperties.IsSetBuFont())
			{
				ct_TextParagraphProperties.AddNewBuFont().typeface = "Arial";
			}
			if (ct_TextParagraphProperties.IsSetBuNone())
			{
				ct_TextParagraphProperties.UnsetBuNone();
			}
			if (ct_TextParagraphProperties.IsSetBuBlip())
			{
				ct_TextParagraphProperties.UnsetBuBlip();
			}
			if (ct_TextParagraphProperties.IsSetBuChar())
			{
				ct_TextParagraphProperties.UnsetBuChar();
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0002535C File Offset: 0x0002355C
		public void SetBullet(global::NPOI.XSSF.UserModel.ListAutoNumber scheme)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties = this._p.IsSetPPr() ? this._p.pPr : this._p.AddNewPPr();
			(ct_TextParagraphProperties.IsSetBuAutoNum() ? ct_TextParagraphProperties.buAutoNum : ct_TextParagraphProperties.AddNewBuAutoNum()).type = (global::NPOI.OpenXmlFormats.Dml.ST_TextAutonumberScheme)scheme;
			if (!ct_TextParagraphProperties.IsSetBuFont())
			{
				ct_TextParagraphProperties.AddNewBuFont().typeface = "Arial";
			}
			if (ct_TextParagraphProperties.IsSetBuNone())
			{
				ct_TextParagraphProperties.UnsetBuNone();
			}
			if (ct_TextParagraphProperties.IsSetBuBlip())
			{
				ct_TextParagraphProperties.UnsetBuBlip();
			}
			if (ct_TextParagraphProperties.IsSetBuChar())
			{
				ct_TextParagraphProperties.UnsetBuChar();
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000253F0 File Offset: 0x000235F0
		public bool IsBulletAutoNumber
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherIsBulletAutoNumber paragraphPropertyFetcherIsBulletAutoNumber = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherIsBulletAutoNumber(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherIsBulletAutoNumber);
				return paragraphPropertyFetcherIsBulletAutoNumber.GetValue();
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00025418 File Offset: 0x00023618
		public int BulletAutoNumberStart
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletAutoNumberStart paragraphPropertyFetcherBulletAutoNumberStart = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletAutoNumberStart(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherBulletAutoNumberStart);
				return paragraphPropertyFetcherBulletAutoNumberStart.GetValue();
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00025440 File Offset: 0x00023640
		public global::NPOI.XSSF.UserModel.ListAutoNumber BulletAutoNumberScheme
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletAutoNumberScheme paragraphPropertyFetcherBulletAutoNumberScheme = new global::NPOI.XSSF.UserModel.XSSFTextParagraph.ParagraphPropertyFetcherBulletAutoNumberScheme(this.Level);
				this.fetchParagraphProperty(paragraphPropertyFetcherBulletAutoNumberScheme);
				if (paragraphPropertyFetcherBulletAutoNumberScheme.GetValue() != null)
				{
					return paragraphPropertyFetcherBulletAutoNumberScheme.GetValue().Value;
				}
				return global::NPOI.XSSF.UserModel.ListAutoNumber.ARABIC_PLAIN;
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00025484 File Offset: 0x00023684
		private bool fetchParagraphProperty(global::NPOI.XSSF.Model.ParagraphPropertyFetcher visitor)
		{
			bool flag = false;
			if (this._p.IsSetPPr())
			{
				flag = visitor.Fetch(this._p.pPr);
			}
			if (!flag)
			{
				flag = visitor.Fetch(this._shape);
			}
			return flag;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000254C3 File Offset: 0x000236C3
		public override string ToString()
		{
			return "[" + base.GetType().ToString() + "]" + this.Text;
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XSSF.UserModel.XSSFTextRun Current
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x000065E4 File Offset: 0x000047E4
		public void Dispose()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x000065E4 File Offset: 0x000047E4
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool MoveNext()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000065E4 File Offset: 0x000047E4
		public void Reset()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x000254E5 File Offset: 0x000236E5
		public global::System.Collections.Generic.IEnumerator<global::NPOI.XSSF.UserModel.XSSFTextRun> GetEnumerator()
		{
			return this._Runs.GetEnumerator();
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000254E5 File Offset: 0x000236E5
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._Runs.GetEnumerator();
		}

		// Token: 0x0400036F RID: 879
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph _p;

		// Token: 0x04000370 RID: 880
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape _shape;

		// Token: 0x04000371 RID: 881
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTextRun> _Runs;

		// Token: 0x0200012F RID: 303
		private class ParagraphPropertyTextAlignFetcher : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<global::NPOI.XSSF.UserModel.TextAlign?>
		{
			// Token: 0x06001000 RID: 4096 RVA: 0x000385FF File Offset: 0x000367FF
			public ParagraphPropertyTextAlignFetcher(int level) : base(level)
			{
			}

			// Token: 0x06001001 RID: 4097 RVA: 0x00038608 File Offset: 0x00036808
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetAlgn())
				{
					global::NPOI.XSSF.UserModel.TextAlign value = (global::NPOI.XSSF.UserModel.TextAlign)(props.algn + 1);
					base.SetValue(new global::NPOI.XSSF.UserModel.TextAlign?(value));
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000130 RID: 304
		private class ParagraphPropertyFetcherTextFontAlign : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<global::NPOI.XSSF.UserModel.TextFontAlign?>
		{
			// Token: 0x06001002 RID: 4098 RVA: 0x00038635 File Offset: 0x00036835
			public ParagraphPropertyFetcherTextFontAlign(int level) : base(level)
			{
			}

			// Token: 0x06001003 RID: 4099 RVA: 0x00038640 File Offset: 0x00036840
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetFontAlgn())
				{
					global::NPOI.XSSF.UserModel.TextFontAlign value = (global::NPOI.XSSF.UserModel.TextFontAlign)(props.fontAlgn + 1);
					base.SetValue(new global::NPOI.XSSF.UserModel.TextFontAlign?(value));
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000131 RID: 305
		private class ParagraphPropertyFetcherBulletFont : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<string>
		{
			// Token: 0x06001004 RID: 4100 RVA: 0x0003866D File Offset: 0x0003686D
			public ParagraphPropertyFetcherBulletFont(int level) : base(level)
			{
			}

			// Token: 0x06001005 RID: 4101 RVA: 0x00038676 File Offset: 0x00036876
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetBuFont())
				{
					base.SetValue(props.buFont.typeface);
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000132 RID: 306
		private class ParagraphPropertyFetcherBulletCharacter : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<string>
		{
			// Token: 0x06001006 RID: 4102 RVA: 0x0003866D File Offset: 0x0003686D
			public ParagraphPropertyFetcherBulletCharacter(int level) : base(level)
			{
			}

			// Token: 0x06001007 RID: 4103 RVA: 0x00038694 File Offset: 0x00036894
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetBuChar())
				{
					base.SetValue(props.buChar.@char);
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000133 RID: 307
		private class ParagraphPropertyFetcherBulletFontColor : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<global::System.Drawing.Color>
		{
			// Token: 0x06001008 RID: 4104 RVA: 0x000386B2 File Offset: 0x000368B2
			public ParagraphPropertyFetcherBulletFontColor(int level) : base(level)
			{
			}

			// Token: 0x06001009 RID: 4105 RVA: 0x000386BC File Offset: 0x000368BC
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetBuClr() && props.buClr.IsSetSrgbClr())
				{
					byte[] val = props.buClr.srgbClr.val;
					base.SetValue(global::System.Drawing.Color.FromArgb((int)(byte.MaxValue & val[0]), (int)(byte.MaxValue & val[1]), (int)(byte.MaxValue & val[2])));
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000134 RID: 308
		private class ParagraphPropertyFetcherBulletFontSize : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<double?>
		{
			// Token: 0x0600100A RID: 4106 RVA: 0x00038718 File Offset: 0x00036918
			public ParagraphPropertyFetcherBulletFontSize(int level) : base(level)
			{
			}

			// Token: 0x0600100B RID: 4107 RVA: 0x00038724 File Offset: 0x00036924
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetBuSzPct())
				{
					base.SetValue(new double?((double)props.buSzPct.val * 0.001));
					return true;
				}
				if (props.IsSetBuSzPts())
				{
					base.SetValue(new double?((double)(-(double)props.buSzPts.val) * 0.01));
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000135 RID: 309
		private class ParagraphPropertyFetcherIndent : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<double>
		{
			// Token: 0x0600100C RID: 4108 RVA: 0x00038789 File Offset: 0x00036989
			public ParagraphPropertyFetcherIndent(int level) : base(level)
			{
			}

			// Token: 0x0600100D RID: 4109 RVA: 0x00038792 File Offset: 0x00036992
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetIndent())
				{
					base.SetValue(global::NPOI.Util.Units.ToPoints((long)props.indent));
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000136 RID: 310
		private class ParagraphPropertyFetcherLeftMargin : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<double>
		{
			// Token: 0x0600100E RID: 4110 RVA: 0x00038789 File Offset: 0x00036989
			public ParagraphPropertyFetcherLeftMargin(int level) : base(level)
			{
			}

			// Token: 0x0600100F RID: 4111 RVA: 0x000387B4 File Offset: 0x000369B4
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetMarL())
				{
					double value = global::NPOI.Util.Units.ToPoints((long)props.marL);
					base.SetValue(value);
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000137 RID: 311
		private class ParagraphPropertyFetcherRightMargin : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<double>
		{
			// Token: 0x06001010 RID: 4112 RVA: 0x00038789 File Offset: 0x00036989
			public ParagraphPropertyFetcherRightMargin(int level) : base(level)
			{
			}

			// Token: 0x06001011 RID: 4113 RVA: 0x000387E0 File Offset: 0x000369E0
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetMarR())
				{
					double value = global::NPOI.Util.Units.ToPoints((long)props.marR);
					base.SetValue(value);
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000138 RID: 312
		private class ParagraphPropertyFetcherDefaultTabSize : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<double>
		{
			// Token: 0x06001012 RID: 4114 RVA: 0x00038789 File Offset: 0x00036989
			public ParagraphPropertyFetcherDefaultTabSize(int level) : base(level)
			{
			}

			// Token: 0x06001013 RID: 4115 RVA: 0x0003880C File Offset: 0x00036A0C
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetDefTabSz())
				{
					double value = global::NPOI.Util.Units.ToPoints((long)props.defTabSz);
					base.SetValue(value);
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000139 RID: 313
		private class ParagraphPropertyFetcherTabStop : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<double>
		{
			// Token: 0x06001014 RID: 4116 RVA: 0x00038838 File Offset: 0x00036A38
			public ParagraphPropertyFetcherTabStop(int level, int idx) : base(level)
			{
				this.idx = idx;
			}

			// Token: 0x06001015 RID: 4117 RVA: 0x00038848 File Offset: 0x00036A48
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetTabLst())
				{
					global::NPOI.OpenXmlFormats.Dml.CT_TextTabStopList tabLst = props.tabLst;
					if (this.idx < tabLst.SizeOfTabArray())
					{
						double value = global::NPOI.Util.Units.ToPoints((long)tabLst.GetTabArray(this.idx).pos);
						base.SetValue(value);
						return true;
					}
				}
				return false;
			}

			// Token: 0x04000513 RID: 1299
			private int idx;
		}

		// Token: 0x0200013A RID: 314
		private class ParagraphPropertyFetcherLineSpacing : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<double?>
		{
			// Token: 0x06001016 RID: 4118 RVA: 0x00038718 File Offset: 0x00036918
			public ParagraphPropertyFetcherLineSpacing(int level) : base(level)
			{
			}

			// Token: 0x06001017 RID: 4119 RVA: 0x00038894 File Offset: 0x00036A94
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetLnSpc())
				{
					global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing lnSpc = props.lnSpc;
					if (lnSpc.IsSetSpcPct())
					{
						base.SetValue(new double?((double)lnSpc.spcPct.val * 0.001));
					}
					else if (lnSpc.IsSetSpcPts())
					{
						base.SetValue(new double?((double)(-(double)lnSpc.spcPts.val) * 0.01));
					}
					return true;
				}
				return false;
			}
		}

		// Token: 0x0200013B RID: 315
		private class ParagraphPropertyFetcherSpaceBefore : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<double>
		{
			// Token: 0x06001018 RID: 4120 RVA: 0x00038789 File Offset: 0x00036989
			public ParagraphPropertyFetcherSpaceBefore(int level) : base(level)
			{
			}

			// Token: 0x06001019 RID: 4121 RVA: 0x00038908 File Offset: 0x00036B08
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetSpcBef())
				{
					global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing spcBef = props.spcBef;
					if (spcBef.IsSetSpcPct())
					{
						base.SetValue((double)spcBef.spcPct.val * 0.001);
					}
					else if (spcBef.IsSetSpcPts())
					{
						base.SetValue((double)(-(double)spcBef.spcPts.val) * 0.01);
					}
					return true;
				}
				return false;
			}
		}

		// Token: 0x0200013C RID: 316
		private class ParagraphPropertyFetcherSpaceAfter : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<double>
		{
			// Token: 0x0600101A RID: 4122 RVA: 0x00038789 File Offset: 0x00036989
			public ParagraphPropertyFetcherSpaceAfter(int level) : base(level)
			{
			}

			// Token: 0x0600101B RID: 4123 RVA: 0x00038974 File Offset: 0x00036B74
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetSpcAft())
				{
					global::NPOI.OpenXmlFormats.Dml.CT_TextSpacing spcAft = props.spcAft;
					if (spcAft.IsSetSpcPct())
					{
						base.SetValue((double)spcAft.spcPct.val * 0.001);
					}
					else if (spcAft.IsSetSpcPts())
					{
						base.SetValue((double)(-(double)spcAft.spcPts.val) * 0.01);
					}
					return true;
				}
				return false;
			}
		}

		// Token: 0x0200013D RID: 317
		private class ParagraphPropertyFetcherBullet : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<bool?>
		{
			// Token: 0x0600101C RID: 4124 RVA: 0x000389DE File Offset: 0x00036BDE
			public ParagraphPropertyFetcherBullet(int level) : base(level)
			{
			}

			// Token: 0x0600101D RID: 4125 RVA: 0x000389E7 File Offset: 0x00036BE7
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetBuNone())
				{
					base.SetValue(new bool?(false));
					return true;
				}
				if (props.IsSetBuFont() && (props.IsSetBuChar() || props.IsSetBuAutoNum()))
				{
					base.SetValue(new bool?(true));
					return true;
				}
				return false;
			}
		}

		// Token: 0x0200013E RID: 318
		private class ParagraphPropertyFetcherIsBulletAutoNumber : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<bool>
		{
			// Token: 0x0600101E RID: 4126 RVA: 0x00038A26 File Offset: 0x00036C26
			public ParagraphPropertyFetcherIsBulletAutoNumber(int level) : base(level)
			{
			}

			// Token: 0x0600101F RID: 4127 RVA: 0x00038A2F File Offset: 0x00036C2F
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetBuAutoNum())
				{
					base.SetValue(true);
					return true;
				}
				return false;
			}
		}

		// Token: 0x0200013F RID: 319
		private class ParagraphPropertyFetcherBulletAutoNumberStart : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<int>
		{
			// Token: 0x06001020 RID: 4128 RVA: 0x00038A43 File Offset: 0x00036C43
			public ParagraphPropertyFetcherBulletAutoNumberStart(int level) : base(level)
			{
			}

			// Token: 0x06001021 RID: 4129 RVA: 0x00038A4C File Offset: 0x00036C4C
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetBuAutoNum() && props.buAutoNum.IsSetStartAt())
				{
					base.SetValue(props.buAutoNum.startAt);
					return true;
				}
				return false;
			}
		}

		// Token: 0x02000140 RID: 320
		private class ParagraphPropertyFetcherBulletAutoNumberScheme : global::NPOI.XSSF.Model.ParagraphPropertyFetcher<global::NPOI.XSSF.UserModel.ListAutoNumber?>
		{
			// Token: 0x06001022 RID: 4130 RVA: 0x00038A77 File Offset: 0x00036C77
			public ParagraphPropertyFetcherBulletAutoNumberScheme(int level) : base(level)
			{
			}

			// Token: 0x06001023 RID: 4131 RVA: 0x00038A80 File Offset: 0x00036C80
			public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props)
			{
				if (props.IsSetBuAutoNum())
				{
					base.SetValue(new global::NPOI.XSSF.UserModel.ListAutoNumber?((global::NPOI.XSSF.UserModel.ListAutoNumber)props.buAutoNum.type));
					return true;
				}
				return false;
			}
		}
	}
}
