using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Picture;
using NPOI.OpenXmlFormats.Dml.WordProcessing;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.Util;
using NPOI.WP.UserModel;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000047 RID: 71
	public class XWPFRun : global::NPOI.XWPF.UserModel.ISDTContents, global::NPOI.XWPF.UserModel.IRunElement, global::NPOI.WP.UserModel.ICharacterRun
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x0000AFA0 File Offset: 0x000091A0
		public XWPFRun(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R r, global::NPOI.XWPF.UserModel.IRunBody p)
		{
			this.run = r;
			this.parent = p;
			global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing> drawingList = r.GetDrawingList();
			foreach (global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing ct_Drawing in drawingList)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Anchor ct_Anchor in ct_Drawing.GetAnchorList())
				{
					if (ct_Anchor.docPr != null)
					{
						this.Document.DrawingIdManager.Reserve((long)((ulong)ct_Anchor.docPr.id));
					}
				}
				foreach (global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline ct_Inline in ct_Drawing.GetInlineList())
				{
					if (ct_Inline.docPr != null)
					{
						this.Document.DrawingIdManager.Reserve((long)((ulong)ct_Inline.docPr.id));
					}
				}
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture item in r.GetPictList())
			{
				list.Add(item);
			}
			foreach (global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing item2 in drawingList)
			{
				list.Add(item2);
			}
			this.pictureText = stringBuilder.ToString();
			this.pictures = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPicture>();
			foreach (object o in list)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture ctPic in this.GetCTPictures(o))
				{
					global::NPOI.XWPF.UserModel.XWPFPicture item3 = new global::NPOI.XWPF.UserModel.XWPFPicture(ctPic, this);
					this.pictures.Add(item3);
				}
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000B1F8 File Offset: 0x000093F8
		[global::System.Obsolete("Use XWPFRun(CTR, IRunBody)")]
		public XWPFRun(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R r, global::NPOI.XWPF.UserModel.XWPFParagraph p) : this(r, p)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000B204 File Offset: 0x00009404
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture> GetCTPictures(object o)
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture> result = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture>();
			if (o is global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing)
			{
				global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing ct_Drawing = o as global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing;
				if (ct_Drawing.inline == null)
				{
					return result;
				}
				using (global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline>.Enumerator enumerator = ct_Drawing.inline.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline ct_Inline = enumerator.Current;
						this.GetPictures(ct_Inline.graphic.graphicData, result);
					}
					return result;
				}
			}
			if (o is global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData)
			{
				this.GetPictures(o as global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData, result);
			}
			return result;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000B298 File Offset: 0x00009498
		private void GetPictures(global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData god, global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture> pictures)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture));
			foreach (string text in god.Any)
			{
				if (text.IndexOf("pic:pic") >= 0)
				{
					global::System.IO.StringReader input = new global::System.IO.StringReader(text);
					global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture item = xmlSerializer.Deserialize(global::System.Xml.XmlReader.Create(input)) as global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture;
					pictures.Add(item);
				}
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000B324 File Offset: 0x00009524
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_R GetCTR()
		{
			return this.run;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000B32C File Offset: 0x0000952C
		public global::NPOI.XWPF.UserModel.IRunBody Parent
		{
			get
			{
				return this.parent;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000B334 File Offset: 0x00009534
		public global::NPOI.XWPF.UserModel.XWPFParagraph Paragraph
		{
			get
			{
				if (this.parent is global::NPOI.XWPF.UserModel.XWPFParagraph)
				{
					return (global::NPOI.XWPF.UserModel.XWPFParagraph)this.parent;
				}
				return null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000B350 File Offset: 0x00009550
		public global::NPOI.XWPF.UserModel.XWPFDocument Document
		{
			get
			{
				if (this.parent != null)
				{
					return this.parent.Document;
				}
				return null;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00004B3B File Offset: 0x00002D3B
		private bool IsCTOnOff(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff onoff)
		{
			return !onoff.IsSetVal() || onoff.val;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000B368 File Offset: 0x00009568
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0000B39C File Offset: 0x0000959C
		public bool IsBold
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				return rPr != null && rPr.IsSetB() && this.IsCTOnOff(rPr.b);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetB() ? ct_RPr.b : ct_RPr.AddNewB()).val = value;
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000B3EC File Offset: 0x000095EC
		public string GetColor()
		{
			string result = null;
			if (this.run.IsSetRPr())
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				if (rPr.IsSetColor())
				{
					result = rPr.color.val;
				}
			}
			return result;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000B42C File Offset: 0x0000962C
		public void SetColor(string rgbStr)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
			(ct_RPr.IsSetColor() ? ct_RPr.color : ct_RPr.AddNewColor()).val = rgbStr;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000B47B File Offset: 0x0000967B
		public string GetText(int pos)
		{
			if (this.run.SizeOfTArray() != 0)
			{
				return this.run.GetTArray(pos).Value;
			}
			return null;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000B49D File Offset: 0x0000969D
		public string PictureText
		{
			get
			{
				return this.pictureText;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000B4A8 File Offset: 0x000096A8
		public void ReplaceText(string oldText, string newText)
		{
			string text = this.Text.Replace(oldText, newText);
			this.SetText(text);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000B4CA File Offset: 0x000096CA
		public void SetText(string value)
		{
			this.SetText(value, 0);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000B4D4 File Offset: 0x000096D4
		public void AppendText(string value)
		{
			this.SetText(value, this.run.GetTList().Count);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000B4F0 File Offset: 0x000096F0
		public void SetText(string value, int pos)
		{
			int num = this.run.SizeOfTArray();
			if (pos > num)
			{
				throw new global::System.IndexOutOfRangeException("Value too large for the parameter position");
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text ct_Text = (pos < num && pos >= 0) ? this.run.GetTArray(pos) : this.run.AddNewT();
			ct_Text.Value = value;
			global::NPOI.XWPF.UserModel.XWPFRun.preserveSpaces(ct_Text);
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000B548 File Offset: 0x00009748
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0000B57C File Offset: 0x0000977C
		public bool IsItalic
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				return rPr != null && rPr.IsSetI() && this.IsCTOnOff(rPr.i);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetI() ? ct_RPr.i : ct_RPr.AddNewI()).val = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000B5CC File Offset: 0x000097CC
		public global::NPOI.XWPF.UserModel.UnderlinePatterns Underline
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				if (rPr != null && rPr.IsSetU())
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.ST_Underline val = rPr.u.val;
					return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.UnderlinePatterns, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Underline>(rPr.u.val);
				}
				return global::NPOI.XWPF.UserModel.UnderlinePatterns.None;
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000B611 File Offset: 0x00009811
		internal void InsertText(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text text, int textIndex)
		{
			this.run.GetTList().Insert(textIndex, text);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000B628 File Offset: 0x00009828
		public void InsertText(string text, int startIndex)
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text> tlist = this.run.GetTList();
			int num = 0;
			for (int i = 0; i < tlist.Count; i++)
			{
				int num2 = num;
				num += tlist[i].Value.Length;
				if (num > startIndex)
				{
					tlist[i].Value = tlist[i].Value.Insert(startIndex - num2, text);
					return;
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000B694 File Offset: 0x00009894
		public string Text
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				for (int i = 0; i < this.run.Items.Count; i++)
				{
					object obj = this.run.Items[i];
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text && this.run.ItemsElementName[i] != global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.instrText)
					{
						stringBuilder.Append(((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)obj).Value);
					}
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar)
					{
						global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar ct_FldChar = (global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar)obj;
						if (ct_FldChar.fldCharType == global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType.begin && ct_FldChar.ffData != null)
						{
							using (global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFCheckBox>.Enumerator enumerator = ct_FldChar.ffData.GetCheckBoxList().GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									if (enumerator.Current.@default.val)
									{
										stringBuilder.Append("|X|");
									}
									else
									{
										stringBuilder.Append("|_|");
									}
								}
							}
						}
					}
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab)
					{
						stringBuilder.Append("\t");
					}
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br)
					{
						stringBuilder.Append("\n");
					}
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty)
					{
						if (this.run.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.tab)
						{
							stringBuilder.Append("\t");
						}
						if (this.run.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.br)
						{
							stringBuilder.Append("\n");
						}
						if (this.run.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.cr)
						{
							stringBuilder.Append("\n");
						}
					}
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef)
					{
						global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef ct_FtnEdnRef = (global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef)obj;
						string value = ct_FtnEdnRef.DomNode.LocalName.Equals("footnoteReference") ? ("[footnoteRef:" + ct_FtnEdnRef.id + "]") : ("[endnoteRef:" + ct_FtnEdnRef.id + "]");
						stringBuilder.Append(value);
					}
				}
				if (this.pictureText != null && this.pictureText.Length > 0)
				{
					stringBuilder.Append("\n").Append(this.pictureText);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		public void SetUnderline(global::NPOI.XWPF.UserModel.UnderlinePatterns value)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
			((ct_RPr.u == null) ? ct_RPr.AddNewU() : ct_RPr.u).val = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_Underline, global::NPOI.XWPF.UserModel.UnderlinePatterns>(value);
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000B90C File Offset: 0x00009B0C
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0000B940 File Offset: 0x00009B40
		public bool IsStrikeThrough
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				return rPr != null && rPr.IsSetStrike() && this.IsCTOnOff(rPr.strike);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetStrike() ? ct_RPr.strike : ct_RPr.AddNewStrike()).val = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000B98F File Offset: 0x00009B8F
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000B997 File Offset: 0x00009B97
		[global::System.Obsolete]
		public bool IsStrike
		{
			get
			{
				return this.IsStrikeThrough;
			}
			set
			{
				this.IsStrikeThrough = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		public bool IsDoubleStrikeThrough
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				return rPr != null && rPr.IsSetDstrike() && this.IsCTOnOff(rPr.dstrike);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetDstrike() ? ct_RPr.dstrike : ct_RPr.AddNewDstrike()).val = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000BA24 File Offset: 0x00009C24
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000BA58 File Offset: 0x00009C58
		public bool IsSmallCaps
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				return rPr != null && rPr.IsSetSmallCaps() && this.IsCTOnOff(rPr.smallCaps);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetSmallCaps() ? ct_RPr.smallCaps : ct_RPr.AddNewSmallCaps()).val = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0000BADC File Offset: 0x00009CDC
		public bool IsCapitalized
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				return rPr != null && rPr.IsSetCaps() && this.IsCTOnOff(rPr.caps);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetCaps() ? ct_RPr.caps : ct_RPr.AddNewCaps()).val = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000BB2C File Offset: 0x00009D2C
		// (set) Token: 0x060002EA RID: 746 RVA: 0x0000BB60 File Offset: 0x00009D60
		public bool IsShadowed
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				return rPr != null && rPr.IsSetShadow() && this.IsCTOnOff(rPr.shadow);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetShadow() ? ct_RPr.shadow : ct_RPr.AddNewShadow()).val = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		public bool IsImprinted
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				return rPr != null && rPr.IsSetImprint() && this.IsCTOnOff(rPr.imprint);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetImprint() ? ct_RPr.imprint : ct_RPr.AddNewImprint()).val = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000BC34 File Offset: 0x00009E34
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000BC68 File Offset: 0x00009E68
		public bool IsEmbossed
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				return rPr != null && rPr.IsSetEmboss() && this.IsCTOnOff(rPr.emboss);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetEmboss() ? ct_RPr.emboss : ct_RPr.AddNewEmboss()).val = value;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[global::System.Obsolete]
		public void SetStrike(bool value)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
			(ct_RPr.IsSetStrike() ? ct_RPr.strike : ct_RPr.AddNewStrike()).val = value;
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000BD08 File Offset: 0x00009F08
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x0000BD40 File Offset: 0x00009F40
		public global::NPOI.XWPF.UserModel.VerticalAlign Subscript
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				if (rPr == null || !rPr.IsSetVertAlign())
				{
					return global::NPOI.XWPF.UserModel.VerticalAlign.BASELINE;
				}
				return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.VerticalAlign, global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalAlignRun>(rPr.vertAlign.val);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetVertAlign() ? ct_RPr.vertAlign : ct_RPr.AddNewVertAlign()).val = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalAlignRun, global::NPOI.XWPF.UserModel.VerticalAlign>(value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000BD94 File Offset: 0x00009F94
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		public int Kerning
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				if (rPr == null || !rPr.IsSetKern())
				{
					return 0;
				}
				return (int)rPr.kern.val;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetKern() ? ct_RPr.kern : ct_RPr.AddNewKern()).val = (ulong)((long)value);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000BE18 File Offset: 0x0000A018
		public bool IsHighlighted
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				return rPr != null && rPr.IsSetHighlight() && rPr.highlight.val != global::NPOI.OpenXmlFormats.Wordprocessing.ST_HighlightColor.none;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000BE50 File Offset: 0x0000A050
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000BE88 File Offset: 0x0000A088
		public int CharacterSpacing
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				if (rPr == null || !rPr.IsSetSpacing())
				{
					return 0;
				}
				return int.Parse(rPr.spacing.val);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetSpacing() ? ct_RPr.spacing : ct_RPr.AddNewSpacing()).val = value.ToString();
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000BEDD File Offset: 0x0000A0DD
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0000BEE6 File Offset: 0x0000A0E6
		public string FontFamily
		{
			get
			{
				return this.GetFontFamily(global::NPOI.XWPF.UserModel.FontCharRange.None);
			}
			set
			{
				this.SetFontFamily(value, global::NPOI.XWPF.UserModel.FontCharRange.None);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
		public string FontName
		{
			get
			{
				return this.FontFamily;
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		public string GetFontFamily(global::NPOI.XWPF.UserModel.FontCharRange fcr)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
			if (rPr == null || !rPr.IsSetRFonts())
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts rFonts = rPr.rFonts;
			switch ((fcr == global::NPOI.XWPF.UserModel.FontCharRange.None) ? global::NPOI.XWPF.UserModel.FontCharRange.Ascii : fcr)
			{
			default:
				return rFonts.ascii;
			case global::NPOI.XWPF.UserModel.FontCharRange.CS:
				return rFonts.cs;
			case global::NPOI.XWPF.UserModel.FontCharRange.EastAsia:
				return rFonts.eastAsia;
			case global::NPOI.XWPF.UserModel.FontCharRange.HAnsi:
				return rFonts.hAnsi;
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000BF60 File Offset: 0x0000A160
		public void SetFontFamily(string fontFamily, global::NPOI.XWPF.UserModel.FontCharRange fcr)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts ct_Fonts = ct_RPr.IsSetRFonts() ? ct_RPr.rFonts : ct_RPr.AddNewRFonts();
			if (fcr == global::NPOI.XWPF.UserModel.FontCharRange.None)
			{
				ct_Fonts.ascii = fontFamily;
				if (!ct_Fonts.IsSetHAnsi())
				{
					ct_Fonts.hAnsi = fontFamily;
				}
				if (!ct_Fonts.IsSetCs())
				{
					ct_Fonts.cs = fontFamily;
				}
				if (!ct_Fonts.IsSetEastAsia())
				{
					ct_Fonts.eastAsia = fontFamily;
					return;
				}
			}
			else
			{
				switch (fcr)
				{
				case global::NPOI.XWPF.UserModel.FontCharRange.Ascii:
					ct_Fonts.ascii = fontFamily;
					return;
				case global::NPOI.XWPF.UserModel.FontCharRange.CS:
					ct_Fonts.cs = fontFamily;
					return;
				case global::NPOI.XWPF.UserModel.FontCharRange.EastAsia:
					ct_Fonts.eastAsia = fontFamily;
					return;
				case global::NPOI.XWPF.UserModel.FontCharRange.HAnsi:
					ct_Fonts.hAnsi = fontFamily;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000C01C File Offset: 0x0000A21C
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0000C064 File Offset: 0x0000A264
		public double FontSize
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				if (rPr == null || !rPr.IsSetSz())
				{
					return -1.0;
				}
				return rPr.sz.val / 2.0;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetSz() ? ct_RPr.sz : ct_RPr.AddNewSz()).val = (ulong)(value * 2.0);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0000C0F8 File Offset: 0x0000A2F8
		public int TextPosition
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr;
				if (rPr == null || !rPr.IsSetPosition())
				{
					return -1;
				}
				return int.Parse(rPr.position.val);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr() ? this.run.rPr : this.run.AddNewRPr();
				(ct_RPr.IsSetPosition() ? ct_RPr.position : ct_RPr.AddNewPosition()).val = value.ToString();
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000029BF File Offset: 0x00000BBF
		public void RemoveBreak()
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000C14D File Offset: 0x0000A34D
		public void AddBreak()
		{
			this.run.AddNewBr();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000C15B File Offset: 0x0000A35B
		public void AddBreak(global::NPOI.XWPF.UserModel.BreakType type)
		{
			this.run.AddNewBr().type = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrType, global::NPOI.XWPF.UserModel.BreakType>(type);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000C173 File Offset: 0x0000A373
		public void AddBreak(global::NPOI.XWPF.UserModel.BreakClear Clear)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br ct_Br = this.run.AddNewBr();
			ct_Br.type = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrType, global::NPOI.XWPF.UserModel.BreakType>(global::NPOI.XWPF.UserModel.BreakType.TEXTWRAPPING);
			ct_Br.clear = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_BrClear, global::NPOI.XWPF.UserModel.BreakClear>(Clear);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000C197 File Offset: 0x0000A397
		public void AddTab()
		{
			this.run.AddNewTab();
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000029BF File Offset: 0x00000BBF
		public void RemoveTab()
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000C1A5 File Offset: 0x0000A3A5
		public void AddCarriageReturn()
		{
			this.run.AddNewCr();
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000065E4 File Offset: 0x000047E4
		public void RemoveCarriageReturn(int i)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		private global::NPOI.XWPF.UserModel.XWPFPicture AddPicture(global::System.IO.Stream pictureData, int pictureType, string filename, int width, int height, global::System.Action<global::NPOI.XWPF.UserModel.XWPFDocument, global::NPOI.OpenXmlFormats.Dml.CT_Blip> extAct)
		{
			global::NPOI.XWPF.UserModel.XWPFDocument xwpfdocument = null;
			global::NPOI.XWPF.UserModel.XWPFPictureData xwpfpictureData;
			if (this.parent.Part is global::NPOI.XWPF.UserModel.XWPFHeaderFooter)
			{
				global::NPOI.XWPF.UserModel.XWPFHeaderFooter xwpfheaderFooter = (global::NPOI.XWPF.UserModel.XWPFHeaderFooter)this.parent.Part;
				string id = xwpfheaderFooter.AddPictureData(pictureData, pictureType);
				xwpfpictureData = (global::NPOI.XWPF.UserModel.XWPFPictureData)xwpfheaderFooter.GetRelationById(id);
			}
			else
			{
				xwpfdocument = this.parent.Document;
				string id = xwpfdocument.AddPictureData(pictureData, pictureType);
				xwpfpictureData = (global::NPOI.XWPF.UserModel.XWPFPictureData)xwpfdocument.GetRelationById(id);
			}
			global::NPOI.XWPF.UserModel.XWPFPicture result;
			try
			{
				global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline ct_Inline = this.run.AddNewDrawing().AddNewInline();
				ct_Inline.graphic = new global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject();
				ct_Inline.graphic.graphicData = new global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData();
				ct_Inline.graphic.graphicData.uri = "http://schemas.openxmlformats.org/drawingml/2006/picture";
				ct_Inline.distT = 0U;
				ct_Inline.distR = 0U;
				ct_Inline.distB = 0U;
				ct_Inline.distL = 0U;
				global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps ct_NonVisualDrawingProps = ct_Inline.AddNewDocPr();
				long num = this.parent.Document.DrawingIdManager.ReserveNew();
				ct_NonVisualDrawingProps.id = (uint)num;
				ct_NonVisualDrawingProps.name = "Drawing " + num.ToString();
				ct_NonVisualDrawingProps.descr = filename;
				global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D ct_PositiveSize2D = ct_Inline.AddNewExtent();
				ct_PositiveSize2D.cx = (long)width;
				ct_PositiveSize2D.cy = (long)height;
				global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture ct_Picture = new global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture();
				global::NPOI.OpenXmlFormats.Dml.Picture.CT_PictureNonVisual ct_PictureNonVisual = ct_Picture.AddNewNvPicPr();
				global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps ct_NonVisualDrawingProps2 = ct_PictureNonVisual.AddNewCNvPr();
				ct_NonVisualDrawingProps2.id = 0U;
				ct_NonVisualDrawingProps2.name = "Picture " + num.ToString();
				ct_NonVisualDrawingProps2.descr = filename;
				ct_PictureNonVisual.AddNewCNvPicPr().AddNewPicLocks().noChangeAspect = true;
				global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties ct_BlipFillProperties = ct_Picture.AddNewBlipFill();
				global::NPOI.OpenXmlFormats.Dml.CT_Blip ct_Blip = ct_BlipFillProperties.AddNewBlip();
				ct_Blip.embed = xwpfpictureData.GetPackageRelationship().Id;
				if (xwpfdocument != null)
				{
					extAct(xwpfdocument, ct_Blip);
				}
				ct_BlipFillProperties.AddNewStretch().AddNewFillRect();
				global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties ct_ShapeProperties = ct_Picture.AddNewSpPr();
				global::NPOI.OpenXmlFormats.Dml.CT_Transform2D ct_Transform2D = ct_ShapeProperties.AddNewXfrm();
				global::NPOI.OpenXmlFormats.Dml.CT_Point2D ct_Point2D = ct_Transform2D.AddNewOff();
				ct_Point2D.x = 0L;
				ct_Point2D.y = 0L;
				global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ct_PositiveSize2D2 = ct_Transform2D.AddNewExt();
				ct_PositiveSize2D2.cx = (long)width;
				ct_PositiveSize2D2.cy = (long)height;
				global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D ct_PresetGeometry2D = ct_ShapeProperties.AddNewPrstGeom();
				ct_PresetGeometry2D.prst = global::NPOI.OpenXmlFormats.Dml.ST_ShapeType.rect;
				ct_PresetGeometry2D.AddNewAvLst();
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(memoryStream);
					ct_Picture.Write(streamWriter, "pic:pic");
					streamWriter.Flush();
					memoryStream.Position = 0L;
					string el = new global::System.IO.StreamReader(memoryStream).ReadToEnd();
					ct_Inline.graphic.graphicData.AddPicElement(el);
				}
				global::NPOI.XWPF.UserModel.XWPFPicture xwpfpicture = new global::NPOI.XWPF.UserModel.XWPFPicture(ct_Picture, this);
				this.pictures.Add(xwpfpicture);
				result = xwpfpicture;
			}
			catch (global::System.Xml.XmlException innerException)
			{
				throw new global::System.InvalidOperationException("XWPFRun.Addpicture error", innerException);
			}
			return result;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000C460 File Offset: 0x0000A660
		public global::NPOI.XWPF.UserModel.XWPFPicture AddSvg(global::System.IO.Stream svgData, global::System.IO.Stream altPictureData, int altPictureType, string filename, int width, int height)
		{
			return this.AddPicture(altPictureData, altPictureType, filename, width, height, delegate(global::NPOI.XWPF.UserModel.XWPFDocument doc, global::NPOI.OpenXmlFormats.Dml.CT_Blip blip)
			{
				string id = doc.AddPictureData(svgData, 13);
				global::NPOI.XWPF.UserModel.XWPFPictureData xwpfpictureData = (global::NPOI.XWPF.UserModel.XWPFPictureData)doc.GetRelationById(id);
				global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList ct_OfficeArtExtensionList = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
				global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtension ct_OfficeArtExtension = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtension();
				ct_OfficeArtExtension.uri = "{96DAC541-7B7A-43D3-8B79-37D633B846F1}";
				ct_OfficeArtExtension.Any = "<asvg:svgBlip xmlns:asvg=\"http://schemas.microsoft.com/office/drawing/2016/SVG/main\" r:embed=\"" + xwpfpictureData.GetPackageRelationship().Id + "\"/>";
				ct_OfficeArtExtensionList.ext.Add(ct_OfficeArtExtension);
				blip.extLst = ct_OfficeArtExtensionList;
			});
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000C494 File Offset: 0x0000A694
		public global::NPOI.XWPF.UserModel.XWPFPicture AddPicture(global::System.IO.Stream pictureData, int pictureType, string filename, int width, int height)
		{
			return this.AddPicture(pictureData, pictureType, filename, width, height, delegate(global::NPOI.XWPF.UserModel.XWPFDocument doc, global::NPOI.OpenXmlFormats.Dml.CT_Blip blip)
			{
			});
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000C4C2 File Offset: 0x0000A6C2
		public global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPicture> GetEmbeddedPictures()
		{
			return this.pictures;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000C4CC File Offset: 0x0000A6CC
		public void SetStyle(string styleId)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.GetCTR().rPr;
			if (ct_RPr == null)
			{
				ct_RPr = this.GetCTR().AddNewRPr();
			}
			((ct_RPr.rStyle != null) ? ct_RPr.rStyle : ct_RPr.AddNewRStyle()).val = styleId;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000C510 File Offset: 0x0000A710
		public string GetStyle()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.GetCTR().rPr;
			if (rPr == null)
			{
				return "";
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_String rStyle = rPr.rStyle;
			if (rStyle == null)
			{
				return "";
			}
			return rStyle.val;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000C548 File Offset: 0x0000A748
		private static void preserveSpaces(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text xs)
		{
			string value = xs.Value;
			if (value != null && value.Length >= 1 && (value.StartsWith(" ") || value.EndsWith(" ")))
			{
				xs.space = "preserve";
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000C58D File Offset: 0x0000A78D
		public override string ToString()
		{
			return this.Text;
		}

		// Token: 0x04000215 RID: 533
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_R run;

		// Token: 0x04000216 RID: 534
		private string pictureText;

		// Token: 0x04000217 RID: 535
		private global::NPOI.XWPF.UserModel.IRunBody parent;

		// Token: 0x04000218 RID: 536
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPicture> pictures;
	}
}
