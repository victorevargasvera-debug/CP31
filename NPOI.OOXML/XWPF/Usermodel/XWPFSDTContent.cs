using System;
using System.Collections.Generic;
using System.Text;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200004A RID: 74
	public class XWPFSDTContent : global::NPOI.XWPF.UserModel.ISDTContent
	{
		// Token: 0x0600031A RID: 794 RVA: 0x0000C634 File Offset: 0x0000A834
		public XWPFSDTContent(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentRun sdtRun, global::NPOI.XWPF.UserModel.IBody part, global::NPOI.XWPF.UserModel.IRunBody parent)
		{
			foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_R r in sdtRun.GetRList())
			{
				global::NPOI.XWPF.UserModel.XWPFRun item = new global::NPOI.XWPF.UserModel.XWPFRun(r, parent);
				this.runs.Add(item);
				this.bodyElements.Add(item);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		public XWPFSDTContent(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentBlock block, global::NPOI.XWPF.UserModel.IBody part, global::NPOI.XWPF.UserModel.IRunBody parent)
		{
			foreach (object obj in block.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)
				{
					global::NPOI.XWPF.UserModel.XWPFParagraph item = new global::NPOI.XWPF.UserModel.XWPFParagraph((global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)obj, part);
					this.bodyElements.Add(item);
					this.paragraphs.Add(item);
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)
				{
					global::NPOI.XWPF.UserModel.XWPFTable item2 = new global::NPOI.XWPF.UserModel.XWPFTable((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)obj, part);
					this.bodyElements.Add(item2);
					this.tables.Add(item2);
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)
				{
					global::NPOI.XWPF.UserModel.XWPFSDT item3 = new global::NPOI.XWPF.UserModel.XWPFSDT((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)obj, part);
					this.bodyElements.Add(item3);
					this.contentControls.Add(item3);
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_R)
				{
					global::NPOI.XWPF.UserModel.XWPFRun item4 = new global::NPOI.XWPF.UserModel.XWPFRun((global::NPOI.OpenXmlFormats.Wordprocessing.CT_R)obj, parent);
					this.runs.Add(item4);
					this.bodyElements.Add(item4);
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000C830 File Offset: 0x0000AA30
		public string Text
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				bool flag = false;
				for (int i = 0; i < this.bodyElements.Count; i++)
				{
					object obj = this.bodyElements[i];
					if (obj is global::NPOI.XWPF.UserModel.XWPFParagraph)
					{
						this.AppendParagraph((global::NPOI.XWPF.UserModel.XWPFParagraph)obj, stringBuilder);
						flag = true;
					}
					else if (obj is global::NPOI.XWPF.UserModel.XWPFTable)
					{
						this.AppendTable((global::NPOI.XWPF.UserModel.XWPFTable)obj, stringBuilder);
						flag = true;
					}
					else if (obj is global::NPOI.XWPF.UserModel.XWPFSDT)
					{
						stringBuilder.Append(((global::NPOI.XWPF.UserModel.XWPFSDT)obj).Content.Text);
						flag = true;
					}
					else if (obj is global::NPOI.XWPF.UserModel.XWPFRun)
					{
						stringBuilder.Append(((global::NPOI.XWPF.UserModel.XWPFRun)obj).ToString());
						flag = false;
					}
					if (flag && i < this.bodyElements.Count - 1)
					{
						stringBuilder.Append("\n");
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000C904 File Offset: 0x0000AB04
		private void AppendTable(global::NPOI.XWPF.UserModel.XWPFTable table, global::System.Text.StringBuilder text)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFTableRow xwpftableRow in table.Rows)
			{
				global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.ICell> tableICells = xwpftableRow.GetTableICells();
				for (int i = 0; i < tableICells.Count; i++)
				{
					global::NPOI.XWPF.UserModel.ICell cell = tableICells[i];
					if (cell is global::NPOI.XWPF.UserModel.XWPFTableCell)
					{
						text.Append(((global::NPOI.XWPF.UserModel.XWPFTableCell)cell).GetTextRecursively());
					}
					else if (cell is global::NPOI.XWPF.UserModel.XWPFSDTCell)
					{
						text.Append(((global::NPOI.XWPF.UserModel.XWPFSDTCell)cell).Content.Text);
					}
					if (i < tableICells.Count - 1)
					{
						text.Append("\t");
					}
				}
				text.Append('\n');
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
		private void AppendParagraph(global::NPOI.XWPF.UserModel.XWPFParagraph paragraph, global::System.Text.StringBuilder text)
		{
			foreach (global::NPOI.XWPF.UserModel.IRunElement runElement in paragraph.Runs)
			{
				text.Append(runElement.ToString());
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000CA24 File Offset: 0x0000AC24
		public override string ToString()
		{
			return this.Text;
		}

		// Token: 0x0400021B RID: 539
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph> paragraphs = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph>();

		// Token: 0x0400021C RID: 540
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable> tables = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable>();

		// Token: 0x0400021D RID: 541
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFRun> runs = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFRun>();

		// Token: 0x0400021E RID: 542
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFSDT> contentControls = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFSDT>();

		// Token: 0x0400021F RID: 543
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.ISDTContents> bodyElements = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.ISDTContents>();
	}
}
