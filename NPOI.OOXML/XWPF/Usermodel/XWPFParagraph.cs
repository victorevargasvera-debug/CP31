using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.OpenXmlFormats.Shared;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.Util;
using NPOI.WP.UserModel;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000042 RID: 66
	public class XWPFParagraph : global::NPOI.XWPF.UserModel.IBodyElement, global::NPOI.XWPF.UserModel.IRunBody, global::NPOI.XWPF.UserModel.ISDTContents, global::NPOI.WP.UserModel.IParagraph
	{
		// Token: 0x0600024F RID: 591 RVA: 0x00008A10 File Offset: 0x00006C10
		public XWPFParagraph(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P prgrph, global::NPOI.XWPF.UserModel.IBody part)
		{
			this.paragraph = prgrph;
			this.part = part;
			this.document = part.GetXWPFDocument();
			if (this.document == null)
			{
				throw new global::System.NullReferenceException();
			}
			this.runs = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFRun>();
			this.iRuns = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IRunElement>();
			this.BuildRunsInOrderFromXml(this.paragraph.Items);
			this.oMaths = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFOMath>();
			this.BuildOMathsInOrderFromXml(this.paragraph.Items);
			foreach (global::NPOI.XWPF.UserModel.XWPFRun xwpfrun in this.runs)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ctr = xwpfrun.GetCTR();
				if (this.document != null)
				{
					for (int i = 0; i < ctr.Items.Count; i++)
					{
						object obj = ctr.Items[i];
						if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef)
						{
							global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef ct_FtnEdnRef = (global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef)obj;
							this.footnoteText.Append("[").Append(ct_FtnEdnRef.id).Append(": ");
							global::NPOI.XWPF.UserModel.XWPFFootnote xwpffootnote;
							if (ctr.ItemsElementName.Count > i && ctr.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.endnoteReference)
							{
								xwpffootnote = this.document.GetEndnoteByID(int.Parse(ct_FtnEdnRef.id));
								if (xwpffootnote == null)
								{
									xwpffootnote = this.document.GetFootnoteByID(int.Parse(ct_FtnEdnRef.id));
								}
							}
							else
							{
								xwpffootnote = this.document.GetFootnoteByID(int.Parse(ct_FtnEdnRef.id));
								if (xwpffootnote == null)
								{
									xwpffootnote = this.document.GetEndnoteByID(int.Parse(ct_FtnEdnRef.id));
								}
							}
							if (xwpffootnote != null)
							{
								bool flag = true;
								foreach (global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph in xwpffootnote.Paragraphs)
								{
									if (!flag)
									{
										this.footnoteText.Append("\n");
										flag = false;
									}
									this.footnoteText.Append(xwpfparagraph.Text);
								}
							}
							this.footnoteText.Append("]");
						}
					}
				}
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00008C78 File Offset: 0x00006E78
		private void BuildRunsInOrderFromXml(global::System.Collections.ArrayList items)
		{
			foreach (object obj in items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_R)
				{
					global::NPOI.XWPF.UserModel.XWPFRun item = new global::NPOI.XWPF.UserModel.XWPFRun((global::NPOI.OpenXmlFormats.Wordprocessing.CT_R)obj, this);
					this.runs.Add(item);
					this.iRuns.Add(item);
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1)
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1 ct_Hyperlink = (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1)obj;
					foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_R run in ct_Hyperlink.GetRList())
					{
						global::NPOI.XWPF.UserModel.XWPFHyperlinkRun item2 = new global::NPOI.XWPF.UserModel.XWPFHyperlinkRun(ct_Hyperlink, run, this);
						this.runs.Add(item2);
						this.iRuns.Add(item2);
					}
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField)
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField ct_SimpleField = (global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField)obj;
					foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_R run2 in ct_SimpleField.GetRList())
					{
						global::NPOI.XWPF.UserModel.XWPFFieldRun item3 = new global::NPOI.XWPF.UserModel.XWPFFieldRun(ct_SimpleField, run2, this);
						this.runs.Add(item3);
						this.iRuns.Add(item3);
					}
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)
				{
					global::NPOI.XWPF.UserModel.XWPFSDT item4 = new global::NPOI.XWPF.UserModel.XWPFSDT((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)obj, this.part);
					this.iRuns.Add(item4);
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun)
				{
					global::NPOI.XWPF.UserModel.XWPFSDT item5 = new global::NPOI.XWPF.UserModel.XWPFSDT((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun)obj, this.part);
					this.iRuns.Add(item5);
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_R r in ((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).GetRList())
					{
						global::NPOI.XWPF.UserModel.XWPFRun item6 = new global::NPOI.XWPF.UserModel.XWPFRun(r, this);
						this.runs.Add(item6);
						this.iRuns.Add(item6);
					}
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagRun)
				{
					this.BuildRunsInOrderFromXml((obj as global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagRun).Items);
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange ct_RunTrackChange in ((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).GetInsList())
					{
						foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_R r2 in ct_RunTrackChange.GetRList())
						{
							global::NPOI.XWPF.UserModel.XWPFRun item7 = new global::NPOI.XWPF.UserModel.XWPFRun(r2, this);
							this.runs.Add(item7);
							this.iRuns.Add(item7);
						}
					}
				}
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00008F9C File Offset: 0x0000719C
		private void BuildOMathsInOrderFromXml(global::System.Collections.ArrayList items)
		{
			foreach (object obj in items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMath)
				{
					this.oMaths.Add(new global::NPOI.XWPF.UserModel.XWPFOMath(obj as global::NPOI.OpenXmlFormats.Shared.CT_OMath, this));
				}
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00009004 File Offset: 0x00007204
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_P GetCTP()
		{
			return this.paragraph;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000900C File Offset: 0x0000720C
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFRun> Runs
		{
			get
			{
				return this.runs.AsReadOnly();
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00009019 File Offset: 0x00007219
		public global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IRunElement> IRuns
		{
			get
			{
				return this.iRuns;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00009021 File Offset: 0x00007221
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFOMath> OMaths
		{
			get
			{
				return this.oMaths.AsReadOnly();
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000902E File Offset: 0x0000722E
		public bool IsEmpty
		{
			get
			{
				return this.paragraph.Items.Count == 0 && (this.paragraph.pPr == null || this.paragraph.pPr.IsEmpty);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00009063 File Offset: 0x00007263
		public global::NPOI.XWPF.UserModel.XWPFDocument Document
		{
			get
			{
				return this.document;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000906C File Offset: 0x0000726C
		public string Text
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				foreach (global::NPOI.XWPF.UserModel.IRunElement runElement in this.iRuns)
				{
					if (runElement is global::NPOI.XWPF.UserModel.XWPFRun)
					{
						global::NPOI.XWPF.UserModel.XWPFRun xwpfrun = (global::NPOI.XWPF.UserModel.XWPFRun)runElement;
						if (xwpfrun.GetCTR().GetDelTextList().Count == 0)
						{
							stringBuilder.Append(xwpfrun.ToString());
						}
					}
					else if (runElement is global::NPOI.XWPF.UserModel.XWPFSDT)
					{
						stringBuilder.Append(((global::NPOI.XWPF.UserModel.XWPFSDT)runElement).Content.Text);
					}
					else
					{
						stringBuilder.Append(runElement.ToString());
					}
				}
				stringBuilder.Append(this.footnoteText);
				return stringBuilder.ToString();
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00009130 File Offset: 0x00007330
		public string StyleID
		{
			get
			{
				if (this.paragraph.pPr != null && this.paragraph.pPr.pStyle != null && this.paragraph.pPr.pStyle.val != null)
				{
					return this.paragraph.pPr.pStyle.val;
				}
				return null;
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000918C File Offset: 0x0000738C
		public string GetNumID()
		{
			if (this.paragraph.pPr != null && this.paragraph.pPr.numPr != null && this.paragraph.pPr.numPr.numId != null)
			{
				return this.paragraph.pPr.numPr.numId.val;
			}
			return null;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000091EC File Offset: 0x000073EC
		public void SetNumILvl(string iLvl)
		{
			if (this.paragraph.pPr == null)
			{
				this.paragraph.AddNewPPr();
			}
			if (this.paragraph.pPr.numPr == null)
			{
				this.paragraph.pPr.AddNewNumPr();
			}
			if (this.paragraph.pPr.numPr.ilvl == null)
			{
				this.paragraph.pPr.numPr.AddNewIlvl();
			}
			this.paragraph.pPr.numPr.ilvl.val = iLvl;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00009280 File Offset: 0x00007480
		public string GetNumIlvl()
		{
			if (this.paragraph.pPr != null && this.paragraph.pPr.numPr != null && this.paragraph.pPr.numPr.ilvl != null)
			{
				return this.paragraph.pPr.numPr.ilvl.val;
			}
			return null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000092E0 File Offset: 0x000074E0
		public string GetNumFmt()
		{
			string numID = this.GetNumID();
			global::NPOI.XWPF.UserModel.XWPFNumbering numbering = this.document.GetNumbering();
			if (numID != null && numbering != null)
			{
				global::NPOI.XWPF.UserModel.XWPFNum num = numbering.GetNum(numID);
				if (num != null)
				{
					string numIlvl = this.GetNumIlvl();
					string val = num.GetCTNum().abstractNumId.val;
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum abstractNum = numbering.GetAbstractNum(val).GetAbstractNum();
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl ct_Lvl = null;
					for (int i = 0; i < abstractNum.lvl.Count; i++)
					{
						global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl ct_Lvl2 = abstractNum.lvl[i];
						if (ct_Lvl2.ilvl.Equals(numIlvl))
						{
							ct_Lvl = ct_Lvl2;
							break;
						}
					}
					if (ct_Lvl != null && ct_Lvl.numFmt != null)
					{
						return ct_Lvl.numFmt.val.ToString();
					}
				}
			}
			return null;
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000093B0 File Offset: 0x000075B0
		public string NumLevelText
		{
			get
			{
				string numID = this.GetNumID();
				global::NPOI.XWPF.UserModel.XWPFNumbering xwpfnumbering = this.document.CreateNumbering();
				if (numID != null && xwpfnumbering != null)
				{
					global::NPOI.XWPF.UserModel.XWPFNum num = xwpfnumbering.GetNum(numID);
					if (num != null)
					{
						string numIlvl = this.GetNumIlvl();
						global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ctnum = num.GetCTNum();
						if (ctnum == null)
						{
							return null;
						}
						global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber abstractNumId = ctnum.abstractNumId;
						if (abstractNumId == null)
						{
							return null;
						}
						string val = abstractNumId.val;
						if (val == null)
						{
							return null;
						}
						global::NPOI.XWPF.UserModel.XWPFAbstractNum abstractNum = xwpfnumbering.GetAbstractNum(val);
						if (abstractNum == null)
						{
							return null;
						}
						global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum ctabstractNum = abstractNum.GetCTAbstractNum();
						if (ctabstractNum == null)
						{
							return null;
						}
						global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl ct_Lvl = null;
						for (int i = 0; i < ctabstractNum.SizeOfLvlArray(); i++)
						{
							global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl lvlArray = ctabstractNum.GetLvlArray(i);
							if (lvlArray != null && lvlArray.ilvl != null && lvlArray.ilvl.Equals(numIlvl))
							{
								ct_Lvl = lvlArray;
								break;
							}
						}
						if (ct_Lvl != null && ct_Lvl.lvlText != null && ct_Lvl.lvlText.val != null)
						{
							return ct_Lvl.lvlText.val.ToString();
						}
					}
				}
				return null;
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000094B0 File Offset: 0x000076B0
		public string GetNumStartOverride()
		{
			string numID = this.GetNumID();
			global::NPOI.XWPF.UserModel.XWPFNumbering xwpfnumbering = this.document.CreateNumbering();
			if (numID != null && xwpfnumbering != null)
			{
				global::NPOI.XWPF.UserModel.XWPFNum num = xwpfnumbering.GetNum(numID);
				if (num != null)
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ctnum = num.GetCTNum();
					if (ctnum == null)
					{
						return null;
					}
					string numIlvl = this.GetNumIlvl();
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl ct_NumLvl = null;
					for (int i = 0; i < ctnum.SizeOfLvlOverrideArray(); i++)
					{
						global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl lvlOverrideArray = ctnum.GetLvlOverrideArray(i);
						if (lvlOverrideArray != null && lvlOverrideArray.ilvl != null && lvlOverrideArray.ilvl.Equals(numIlvl))
						{
							ct_NumLvl = lvlOverrideArray;
							break;
						}
					}
					if (ct_NumLvl != null && ct_NumLvl.startOverride != null)
					{
						return ct_NumLvl.startOverride.val;
					}
				}
			}
			return null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00009558 File Offset: 0x00007758
		public void SetNumID(string numId)
		{
			if (this.paragraph.pPr == null)
			{
				this.paragraph.AddNewPPr();
			}
			if (this.paragraph.pPr.numPr == null)
			{
				this.paragraph.pPr.AddNewNumPr();
			}
			if (this.paragraph.pPr.numPr.numId == null)
			{
				this.paragraph.pPr.numPr.AddNewNumId();
			}
			this.paragraph.pPr.numPr.ilvl = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			this.paragraph.pPr.numPr.ilvl.val = "0";
			this.paragraph.pPr.numPr.numId.val = numId;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00009624 File Offset: 0x00007824
		public void SetNumID(string numId, string ilvl)
		{
			if (this.paragraph.pPr == null)
			{
				this.paragraph.AddNewPPr();
			}
			if (this.paragraph.pPr.numPr == null)
			{
				this.paragraph.pPr.AddNewNumPr();
			}
			if (this.paragraph.pPr.numPr.numId == null)
			{
				this.paragraph.pPr.numPr.AddNewNumId();
			}
			this.paragraph.pPr.numPr.ilvl = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			this.paragraph.pPr.numPr.ilvl.val = ilvl;
			this.paragraph.pPr.numPr.numId.val = numId;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000096EC File Offset: 0x000078EC
		public string ParagraphText
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				foreach (global::NPOI.XWPF.UserModel.XWPFRun xwpfrun in this.runs)
				{
					stringBuilder.Append(xwpfrun.ToString());
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00009754 File Offset: 0x00007954
		public string PictureText
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				foreach (global::NPOI.XWPF.UserModel.XWPFRun xwpfrun in this.runs)
				{
					stringBuilder.Append(xwpfrun.PictureText);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000097BC File Offset: 0x000079BC
		public string FootnoteText
		{
			get
			{
				return this.footnoteText.ToString();
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000097CC File Offset: 0x000079CC
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00009800 File Offset: 0x00007A00
		public global::NPOI.XWPF.UserModel.ParagraphAlignment Alignment
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
				if (ctppr != null && ctppr.IsSetJc())
				{
					return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.ParagraphAlignment, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc>(ctppr.jc.val);
				}
				return global::NPOI.XWPF.UserModel.ParagraphAlignment.LEFT;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
				(ctppr.IsSetJc() ? ctppr.jc : ctppr.AddNewJc()).val = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc, global::NPOI.XWPF.UserModel.ParagraphAlignment>(value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00009835 File Offset: 0x00007A35
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0000983D File Offset: 0x00007A3D
		public int FontAlignment
		{
			get
			{
				return (int)this.Alignment;
			}
			set
			{
				this.Alignment = (global::NPOI.XWPF.UserModel.ParagraphAlignment)value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00009848 File Offset: 0x00007A48
		// (set) Token: 0x0600026A RID: 618 RVA: 0x0000987C File Offset: 0x00007A7C
		public global::NPOI.XWPF.UserModel.TextAlignment VerticalAlignment
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
				if (ctppr != null && ctppr.IsSetTextAlignment())
				{
					return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.TextAlignment, global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextAlignment>(ctppr.textAlignment.val);
				}
				return global::NPOI.XWPF.UserModel.TextAlignment.AUTO;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
				(ctppr.IsSetTextAlignment() ? ctppr.textAlignment : ctppr.AddNewTextAlignment()).val = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextAlignment, global::NPOI.XWPF.UserModel.TextAlignment>(value);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000098B4 File Offset: 0x00007AB4
		// (set) Token: 0x0600026C RID: 620 RVA: 0x000098E8 File Offset: 0x00007AE8
		public global::NPOI.XWPF.UserModel.Borders BorderTop
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ctpbrd = this.GetCTPBrd(false);
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = null;
				if (ctpbrd != null)
				{
					ct_Border = ctpbrd.top;
				}
				return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.Borders, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border>((ct_Border != null) ? ct_Border.val : global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ctpbrd = this.GetCTPBrd(true);
				if (ctpbrd == null)
				{
					throw new global::NPOI.Util.RuntimeException("invalid paragraph state");
				}
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = ctpbrd.IsSetTop() ? ctpbrd.top : ctpbrd.AddNewTop();
				if (value == global::NPOI.XWPF.UserModel.Borders.None)
				{
					ctpbrd.UnsetTop();
					return;
				}
				ct_Border.val = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border, global::NPOI.XWPF.UserModel.Borders>(value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000993C File Offset: 0x00007B3C
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00009970 File Offset: 0x00007B70
		public global::NPOI.XWPF.UserModel.Borders BorderBottom
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ctpbrd = this.GetCTPBrd(false);
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = null;
				if (ctpbrd != null)
				{
					ct_Border = ctpbrd.bottom;
				}
				return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.Borders, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border>((ct_Border != null) ? ct_Border.val : global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ctpbrd = this.GetCTPBrd(true);
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = ctpbrd.IsSetBottom() ? ctpbrd.bottom : ctpbrd.AddNewBottom();
				if (value == global::NPOI.XWPF.UserModel.Borders.None)
				{
					ctpbrd.UnsetBottom();
					return;
				}
				ct_Border.val = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border, global::NPOI.XWPF.UserModel.Borders>(value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600026F RID: 623 RVA: 0x000099B4 File Offset: 0x00007BB4
		// (set) Token: 0x06000270 RID: 624 RVA: 0x000099E8 File Offset: 0x00007BE8
		public global::NPOI.XWPF.UserModel.Borders BorderLeft
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ctpbrd = this.GetCTPBrd(false);
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = null;
				if (ctpbrd != null)
				{
					ct_Border = ctpbrd.left;
				}
				return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.Borders, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border>((ct_Border != null) ? ct_Border.val : global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ctpbrd = this.GetCTPBrd(true);
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = ctpbrd.IsSetLeft() ? ctpbrd.left : ctpbrd.AddNewLeft();
				if (value == global::NPOI.XWPF.UserModel.Borders.None)
				{
					ctpbrd.UnsetLeft();
					return;
				}
				ct_Border.val = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border, global::NPOI.XWPF.UserModel.Borders>(value);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00009A2C File Offset: 0x00007C2C
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00009A60 File Offset: 0x00007C60
		public global::NPOI.XWPF.UserModel.Borders BorderRight
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ctpbrd = this.GetCTPBrd(false);
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = null;
				if (ctpbrd != null)
				{
					ct_Border = ctpbrd.right;
				}
				return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.Borders, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border>((ct_Border != null) ? ct_Border.val : global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ctpbrd = this.GetCTPBrd(true);
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = ctpbrd.IsSetRight() ? ctpbrd.right : ctpbrd.AddNewRight();
				if (value == global::NPOI.XWPF.UserModel.Borders.None)
				{
					ctpbrd.UnsetRight();
					return;
				}
				ct_Border.val = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border, global::NPOI.XWPF.UserModel.Borders>(value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00009AA3 File Offset: 0x00007CA3
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00009AC4 File Offset: 0x00007CC4
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Shd FillPattern
		{
			get
			{
				if (!this.GetCTPPr().IsSetShd())
				{
					return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Shd.nil;
				}
				return this.GetCTPPr().shd.val;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd ct_Shd;
				if (!this.GetCTPPr().IsSetShd())
				{
					ct_Shd = this.GetCTPPr().AddNewShd();
				}
				else
				{
					ct_Shd = this.GetCTPPr().shd;
				}
				ct_Shd.val = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00009B01 File Offset: 0x00007D01
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00009B24 File Offset: 0x00007D24
		public string FillBackgroundColor
		{
			get
			{
				if (!this.GetCTPPr().IsSetShd())
				{
					return null;
				}
				return this.GetCTPPr().shd.fill;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd ct_Shd;
				if (!this.GetCTPPr().IsSetShd())
				{
					ct_Shd = this.GetCTPPr().AddNewShd();
				}
				else
				{
					ct_Shd = this.GetCTPPr().shd;
				}
				ct_Shd.color = "auto";
				ct_Shd.fill = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00009B6C File Offset: 0x00007D6C
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00009BA0 File Offset: 0x00007DA0
		public global::NPOI.XWPF.UserModel.Borders BorderBetween
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ctpbrd = this.GetCTPBrd(false);
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = null;
				if (ctpbrd != null)
				{
					ct_Border = ctpbrd.between;
				}
				return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.Borders, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border>((ct_Border != null) ? ct_Border.val : global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ctpbrd = this.GetCTPBrd(true);
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = ctpbrd.IsSetBetween() ? ctpbrd.between : ctpbrd.AddNewBetween();
				if (value == global::NPOI.XWPF.UserModel.Borders.None)
				{
					ctpbrd.UnsetBetween();
					return;
				}
				ct_Border.val = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border, global::NPOI.XWPF.UserModel.Borders>(value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00009BE4 File Offset: 0x00007DE4
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00009C18 File Offset: 0x00007E18
		public bool IsPageBreak
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff = ctppr.IsSetPageBreakBefore() ? ctppr.pageBreakBefore : null;
				return ct_OnOff != null && ct_OnOff.val;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
				(ctppr.IsSetPageBreakBefore() ? ctppr.pageBreakBefore : ctppr.AddNewPageBreakBefore()).val = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00009C48 File Offset: 0x00007E48
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00009C7C File Offset: 0x00007E7C
		public int SpacingAfter
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing ctspacing = this.GetCTSpacing(false);
				if (ctspacing == null || !ctspacing.IsSetAfter())
				{
					return -1;
				}
				return (int)ctspacing.after.Value;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing ctspacing = this.GetCTSpacing(true);
				if (ctspacing != null)
				{
					ctspacing.after = new ulong?((ulong)((long)value));
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00009CA4 File Offset: 0x00007EA4
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00009CD1 File Offset: 0x00007ED1
		public int SpacingAfterLines
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing ctspacing = this.GetCTSpacing(false);
				if (ctspacing == null || !ctspacing.IsSetAfterLines())
				{
					return -1;
				}
				return int.Parse(ctspacing.afterLines);
			}
			set
			{
				this.GetCTSpacing(true).afterLines = value.ToString();
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00009CE8 File Offset: 0x00007EE8
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00009D19 File Offset: 0x00007F19
		public int SpacingBefore
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing ctspacing = this.GetCTSpacing(false);
				if (ctspacing == null || !ctspacing.IsSetBefore())
				{
					return -1;
				}
				return (int)ctspacing.before.Value;
			}
			set
			{
				this.GetCTSpacing(true).before = new ulong?((ulong)((long)value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00009D30 File Offset: 0x00007F30
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00009D5D File Offset: 0x00007F5D
		public int SpacingBeforeLines
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing ctspacing = this.GetCTSpacing(false);
				if (ctspacing == null || !ctspacing.IsSetBeforeLines())
				{
					return -1;
				}
				return int.Parse(ctspacing.beforeLines);
			}
			set
			{
				this.GetCTSpacing(true).beforeLines = value.ToString();
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00009D74 File Offset: 0x00007F74
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00009DA1 File Offset: 0x00007FA1
		public global::NPOI.XWPF.UserModel.LineSpacingRule SpacingLineRule
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing ctspacing = this.GetCTSpacing(false);
				if (ctspacing == null || !ctspacing.IsSetLineRule())
				{
					return global::NPOI.XWPF.UserModel.LineSpacingRule.AUTO;
				}
				return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.LineSpacingRule, global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineSpacingRule>(ctspacing.lineRule);
			}
			set
			{
				this.GetCTSpacing(true).lineRule = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineSpacingRule, global::NPOI.XWPF.UserModel.LineSpacingRule>(value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00009DB5 File Offset: 0x00007FB5
		public double SpacingBetween
		{
			set
			{
				this.setSpacingBetween(value, global::NPOI.XWPF.UserModel.LineSpacingRule.AUTO);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00009DC0 File Offset: 0x00007FC0
		public void setSpacingBetween(double spacing, global::NPOI.XWPF.UserModel.LineSpacingRule rule)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing ctspacing = this.GetCTSpacing(true);
			if (rule == global::NPOI.XWPF.UserModel.LineSpacingRule.AUTO)
			{
				ctspacing.line = global::System.Math.Round(spacing * 240.0).ToString();
			}
			else
			{
				ctspacing.line = global::System.Math.Round(spacing * 20.0).ToString();
			}
			ctspacing.lineRule = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineSpacingRule, global::NPOI.XWPF.UserModel.LineSpacingRule>(rule);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00009E24 File Offset: 0x00008024
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00009E51 File Offset: 0x00008051
		public int IndentationLeft
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind ctind = this.GetCTInd(false);
				if (ctind == null || !ctind.IsSetLeft())
				{
					return -1;
				}
				return int.Parse(ctind.left);
			}
			set
			{
				this.GetCTInd(true).left = value.ToString();
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00009E68 File Offset: 0x00008068
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00009E95 File Offset: 0x00008095
		public int IndentationRight
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind ctind = this.GetCTInd(false);
				if (ctind == null || !ctind.IsSetRight())
				{
					return -1;
				}
				return int.Parse(ctind.right);
			}
			set
			{
				this.GetCTInd(true).right = value.ToString();
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00009EAC File Offset: 0x000080AC
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00009ED5 File Offset: 0x000080D5
		public int IndentationHanging
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind ctind = this.GetCTInd(false);
				if (ctind == null || !ctind.IsSetHanging())
				{
					return -1;
				}
				return (int)ctind.hanging;
			}
			set
			{
				this.GetCTInd(true).hanging = (ulong)((long)value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00009EE8 File Offset: 0x000080E8
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00009F11 File Offset: 0x00008111
		public int IndentationFirstLine
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind ctind = this.GetCTInd(false);
				if (ctind == null || !ctind.IsSetFirstLine())
				{
					return -1;
				}
				return (int)ctind.firstLine;
			}
			set
			{
				this.GetCTInd(true).firstLine = (long)value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00009F21 File Offset: 0x00008121
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00009F29 File Offset: 0x00008129
		public int IndentFromLeft
		{
			get
			{
				return this.IndentationLeft;
			}
			set
			{
				this.IndentationLeft = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00009F32 File Offset: 0x00008132
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00009F3A File Offset: 0x0000813A
		public int IndentFromRight
		{
			get
			{
				return this.IndentationRight;
			}
			set
			{
				this.IndentationRight = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00009F43 File Offset: 0x00008143
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00009F4B File Offset: 0x0000814B
		public int FirstLineIndent
		{
			get
			{
				return this.IndentationFirstLine;
			}
			set
			{
				this.IndentationFirstLine = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00009F54 File Offset: 0x00008154
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00009F88 File Offset: 0x00008188
		public bool IsWordWrapped
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff = this.GetCTPPr().IsSetWordWrap() ? this.GetCTPPr().wordWrap : null;
				return ct_OnOff != null && ct_OnOff.val;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff = this.GetCTPPr().IsSetWordWrap() ? this.GetCTPPr().wordWrap : this.GetCTPPr().AddNewWordWrap();
				if (value)
				{
					ct_OnOff.val = true;
					return;
				}
				ct_OnOff.UnSetVal();
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00009FCC File Offset: 0x000081CC
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00009FD4 File Offset: 0x000081D4
		[global::System.Obsolete]
		public bool IsWordWrap
		{
			get
			{
				return this.IsWordWrapped;
			}
			set
			{
				this.IsWordWrapped = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00009FE0 File Offset: 0x000081E0
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0000A014 File Offset: 0x00008214
		public string Style
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_String ct_String = ctppr.IsSetPStyle() ? ctppr.pStyle : null;
				if (ct_String == null)
				{
					return null;
				}
				return ct_String.val;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
				((ctppr.pStyle != null) ? ctppr.pStyle : ctppr.AddNewPStyle()).val = value;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000A044 File Offset: 0x00008244
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr GetCTPBrd(bool create)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ct_PBdr = ctppr.IsSetPBdr() ? ctppr.pBdr : null;
			if (create && ct_PBdr == null)
			{
				ct_PBdr = ctppr.AddNewPBdr();
			}
			return ct_PBdr;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000A078 File Offset: 0x00008278
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing GetCTSpacing(bool create)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing ct_Spacing = (ctppr.spacing == null) ? null : ctppr.spacing;
			if (create && ct_Spacing == null)
			{
				ct_Spacing = ctppr.AddNewSpacing();
			}
			return ct_Spacing;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000A0AC File Offset: 0x000082AC
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind GetCTInd(bool create)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ctppr = this.GetCTPPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind ct_Ind = (ctppr.ind == null) ? null : ctppr.ind;
			if (create && ct_Ind == null)
			{
				ct_Ind = ctppr.AddNewInd();
			}
			return ct_Ind;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000A0E0 File Offset: 0x000082E0
		internal global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr GetCTPPr()
		{
			if (this.paragraph.pPr != null)
			{
				return this.paragraph.pPr;
			}
			return this.paragraph.AddNewPPr();
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000A108 File Offset: 0x00008308
		protected internal void AddRun(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R run)
		{
			int count = this.paragraph.GetRList().Count;
			this.paragraph.AddNewR();
			this.paragraph.SetRArray(count, run);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000A140 File Offset: 0x00008340
		public void ReplaceText(string oldText, string newText)
		{
			if (string.IsNullOrEmpty(oldText))
			{
				throw new global::System.ArgumentNullException("oldText should not be null");
			}
			global::NPOI.XWPF.UserModel.TextSegment textSegment = this.SearchText(oldText, new global::NPOI.XWPF.UserModel.PositionInParagraph
			{
				Run = 0
			});
			if (textSegment == null)
			{
				return;
			}
			if (textSegment.BeginRun == textSegment.EndRun)
			{
				this.runs[textSegment.BeginRun].ReplaceText(oldText, newText);
				return;
			}
			this.runs[textSegment.BeginRun].ReplaceText(this.runs[textSegment.BeginRun].Text.Substring(textSegment.BeginChar), newText);
			this.runs[textSegment.EndRun].ReplaceText(this.runs[textSegment.EndRun].Text.Substring(0, textSegment.EndChar + 1), "");
			for (int i = textSegment.EndRun - 1; i > textSegment.BeginRun; i--)
			{
				this.RemoveRun(i);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000A238 File Offset: 0x00008438
		public global::NPOI.XWPF.UserModel.TextSegment SearchText(string searched, global::NPOI.XWPF.UserModel.PositionInParagraph startPos)
		{
			int run = startPos.Run;
			int text = startPos.Text;
			int @char = startPos.Char;
			int beginRun = 0;
			int beginText = 0;
			int beginChar = 0;
			int num = 0;
			bool flag = false;
			for (int i = run; i < this.paragraph.GetRList().Count; i++)
			{
				int num2 = 0;
				foreach (object obj in this.paragraph.GetRList()[i].Items)
				{
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)
					{
						if (num2 >= text)
						{
							string value = ((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)obj).Value;
							int j;
							if (i == run)
							{
								j = @char;
							}
							else
							{
								j = 0;
							}
							while (j < value.Length)
							{
								if (value[j] == searched[0] && num == 0)
								{
									beginText = num2;
									beginChar = j;
									beginRun = i;
									flag = true;
								}
								if (value[j] == searched[num])
								{
									if (num + 1 < searched.Length)
									{
										num++;
									}
									else if (flag)
									{
										return new global::NPOI.XWPF.UserModel.TextSegment
										{
											BeginRun = beginRun,
											BeginText = beginText,
											BeginChar = beginChar,
											EndRun = i,
											EndText = num2,
											EndChar = j
										};
									}
								}
								else
								{
									num = 0;
								}
								j++;
							}
						}
						num2++;
					}
					else if (!(obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr) && !(obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr))
					{
						num = 0;
					}
				}
			}
			return null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000A3F4 File Offset: 0x000085F4
		public global::NPOI.XWPF.UserModel.XWPFRun CreateRun()
		{
			global::NPOI.XWPF.UserModel.XWPFRun xwpfrun = new global::NPOI.XWPF.UserModel.XWPFRun(this.paragraph.AddNewR(), this);
			this.runs.Add(xwpfrun);
			this.iRuns.Add(xwpfrun);
			return xwpfrun;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000A42C File Offset: 0x0000862C
		public global::NPOI.XWPF.UserModel.XWPFOMath CreateOMath()
		{
			global::NPOI.XWPF.UserModel.XWPFOMath xwpfomath = new global::NPOI.XWPF.UserModel.XWPFOMath(this.paragraph.AddNewOMath(), this);
			this.oMaths.Add(xwpfomath);
			return xwpfomath;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000A458 File Offset: 0x00008658
		public global::NPOI.XWPF.UserModel.XWPFRun InsertNewRun(int pos)
		{
			if (pos >= 0 && pos <= this.runs.Count)
			{
				int num = 0;
				for (int i = 0; i < pos; i++)
				{
					global::NPOI.XWPF.UserModel.XWPFRun xwpfrun = this.runs[i];
					if (!(xwpfrun is global::NPOI.XWPF.UserModel.XWPFHyperlinkRun) && !(xwpfrun is global::NPOI.XWPF.UserModel.XWPFFieldRun))
					{
						num++;
					}
				}
				global::NPOI.XWPF.UserModel.XWPFRun xwpfrun2 = new global::NPOI.XWPF.UserModel.XWPFRun(this.paragraph.InsertNewR(num), this);
				int index = this.iRuns.Count;
				if (pos < this.runs.Count)
				{
					global::NPOI.XWPF.UserModel.XWPFRun item = this.runs[pos];
					int num2 = this.iRuns.IndexOf(item);
					if (num2 != -1)
					{
						index = num2;
					}
				}
				this.iRuns.Insert(index, xwpfrun2);
				this.runs.Insert(pos, xwpfrun2);
				return xwpfrun2;
			}
			return null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000A520 File Offset: 0x00008720
		public string GetText(global::NPOI.XWPF.UserModel.TextSegment segment)
		{
			int beginRun = segment.BeginRun;
			int beginText = segment.BeginText;
			int beginChar = segment.BeginChar;
			int endRun = segment.EndRun;
			int endText = segment.EndText;
			int endChar = segment.EndChar;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = beginRun; i <= endRun; i++)
			{
				int num = 0;
				int num2 = this.paragraph.GetRList()[i].GetTList().Count - 1;
				if (i == beginRun)
				{
					num = beginText;
				}
				if (i == endRun)
				{
					num2 = endText;
				}
				for (int j = num; j <= num2; j++)
				{
					string value = this.paragraph.GetRList()[i].GetTArray(j).Value;
					int num3 = 0;
					int num4 = value.Length - 1;
					if (j == beginText && i == beginRun)
					{
						num3 = beginChar;
					}
					if (j == endText && i == endRun)
					{
						num4 = endChar;
					}
					stringBuilder.Append(value.Substring(num3, num4 - num3 + 1));
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000A628 File Offset: 0x00008828
		public bool RemoveRun(int pos)
		{
			if (pos < 0 || pos >= this.runs.Count)
			{
				return false;
			}
			global::NPOI.XWPF.UserModel.XWPFRun xwpfrun = this.runs[pos];
			if (xwpfrun is global::NPOI.XWPF.UserModel.XWPFHyperlinkRun || xwpfrun is global::NPOI.XWPF.UserModel.XWPFFieldRun)
			{
				throw new global::System.ArgumentException("Removing Field or Hyperlink runs not yet supported");
			}
			this.runs.RemoveAt(pos);
			this.iRuns.Remove(xwpfrun);
			int num = 0;
			for (int i = 0; i < pos; i++)
			{
				global::NPOI.XWPF.UserModel.XWPFRun xwpfrun2 = this.runs[i];
				if (!(xwpfrun2 is global::NPOI.XWPF.UserModel.XWPFHyperlinkRun) && !(xwpfrun2 is global::NPOI.XWPF.UserModel.XWPFFieldRun))
				{
					num++;
				}
			}
			this.GetCTP().RemoveR(pos);
			return true;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00006FBA File Offset: 0x000051BA
		public global::NPOI.XWPF.UserModel.BodyElementType ElementType
		{
			get
			{
				return global::NPOI.XWPF.UserModel.BodyElementType.PARAGRAPH;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000A6C9 File Offset: 0x000088C9
		public global::NPOI.XWPF.UserModel.IBody Body
		{
			get
			{
				return this.part;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000A6D1 File Offset: 0x000088D1
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				if (this.part != null)
				{
					return this.part.Part;
				}
				return null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000A6E8 File Offset: 0x000088E8
		public global::NPOI.XWPF.UserModel.BodyType PartType
		{
			get
			{
				return this.part.PartType;
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000A6F5 File Offset: 0x000088F5
		public void AddRun(global::NPOI.XWPF.UserModel.XWPFRun r)
		{
			if (!this.runs.Contains(r))
			{
				this.runs.Add(r);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000A714 File Offset: 0x00008914
		public global::NPOI.XWPF.UserModel.XWPFRun GetRun(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R r)
		{
			for (int i = 0; i < this.runs.Count; i++)
			{
				if (this.runs[i].GetCTR() == r)
				{
					return this.runs[i];
				}
			}
			return null;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000A75C File Offset: 0x0000895C
		public global::NPOI.XWPF.UserModel.XWPFHyperlinkRun CreateHyperlinkRun(string rId)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_R();
			ct_R.AddNewRPr().rStyle = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String
			{
				val = "Hyperlink"
			};
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1 ct_Hyperlink = this.paragraph.AddNewHyperlink();
			ct_Hyperlink.history = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.on;
			ct_Hyperlink.id = rId;
			ct_Hyperlink.Items.Add(ct_R);
			global::NPOI.XWPF.UserModel.XWPFHyperlinkRun xwpfhyperlinkRun = new global::NPOI.XWPF.UserModel.XWPFHyperlinkRun(ct_Hyperlink, ct_R, this);
			this.runs.Add(xwpfhyperlinkRun);
			this.iRuns.Add(xwpfhyperlinkRun);
			return xwpfhyperlinkRun;
		}

		// Token: 0x040001E4 RID: 484
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_P paragraph;

		// Token: 0x040001E5 RID: 485
		protected global::NPOI.XWPF.UserModel.IBody part;

		// Token: 0x040001E6 RID: 486
		protected global::NPOI.XWPF.UserModel.XWPFDocument document;

		// Token: 0x040001E7 RID: 487
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFRun> runs;

		// Token: 0x040001E8 RID: 488
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IRunElement> iRuns;

		// Token: 0x040001E9 RID: 489
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFOMath> oMaths;

		// Token: 0x040001EA RID: 490
		private global::System.Text.StringBuilder footnoteText = new global::System.Text.StringBuilder();
	}
}
