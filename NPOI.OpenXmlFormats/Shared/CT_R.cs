using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Dml.WordProcessing;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200064D RID: 1613
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_R
	{
		// Token: 0x0600454A RID: 17738 RVA: 0x000A45FA File Offset: 0x000A27FA
		public CT_R()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x0600454B RID: 17739 RVA: 0x000A4618 File Offset: 0x000A2818
		// (set) Token: 0x0600454C RID: 17740 RVA: 0x000A4620 File Offset: 0x000A2820
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_RPR rPr
		{
			get
			{
				return this.rPrField;
			}
			set
			{
				this.rPrField = value;
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x000A4629 File Offset: 0x000A2829
		// (set) Token: 0x0600454E RID: 17742 RVA: 0x000A4631 File Offset: 0x000A2831
		[global::System.Xml.Serialization.XmlElement("rPr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr1
		{
			get
			{
				return this.rPr1Field;
			}
			set
			{
				this.rPr1Field = value;
			}
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x000A463C File Offset: 0x000A283C
		public static global::NPOI.OpenXmlFormats.Shared.CT_R Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_R ct_R = new global::NPOI.OpenXmlFormats.Shared.CT_R();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "endnoteReference")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.endnoteReference);
				}
				else if (xmlNode.LocalName == "drawing")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.drawing);
				}
				else if (xmlNode.LocalName == "tab")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.tab);
				}
				else if (xmlNode.LocalName == "dayLong")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.dayLong);
				}
				else if (xmlNode.LocalName == "t")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Text1.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.t);
				}
				else if (xmlNode.LocalName == "dayShort")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.dayShort);
				}
				else if (xmlNode.LocalName == "annotationRef")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.annotationRef);
				}
				else if (xmlNode.LocalName == "endnoteRef")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.endnoteRef);
				}
				else if (xmlNode.LocalName == "fldChar")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.fldChar);
				}
				else if (xmlNode.LocalName == "lastRenderedPageBreak")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.lastRenderedPageBreak);
				}
				else if (xmlNode.LocalName == "footnoteReference")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.footnoteReference);
				}
				else if (xmlNode.LocalName == "delInstrText")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.delInstrText);
				}
				else if (xmlNode.LocalName == "delText")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.delText);
				}
				else if (xmlNode.LocalName == "commentReference")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.commentReference);
				}
				else if (xmlNode.LocalName == "monthLong")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.monthLong);
				}
				else if (xmlNode.LocalName == "monthShort")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.monthShort);
				}
				else if (xmlNode.LocalName == "continuationSeparator")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.continuationSeparator);
				}
				else if (xmlNode.LocalName == "cr")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.cr);
				}
				else if (xmlNode.LocalName == "noBreakHyphen")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.noBreakHyphen);
				}
				else if (xmlNode.LocalName == "object")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.@object);
				}
				else if (xmlNode.LocalName == "br")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.br);
				}
				else if (xmlNode.LocalName == "pgNum")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.pgNum);
				}
				else if (xmlNode.LocalName == "pict")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.pict);
				}
				else if (xmlNode.LocalName == "ptab")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.ptab);
				}
				else if (xmlNode.LocalName == "ruby")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.ruby);
				}
				else if (xmlNode.LocalName == "separator")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.separator);
				}
				else if (xmlNode.LocalName == "softHyphen")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.softHyphen);
				}
				else if (xmlNode.LocalName == "sym")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Sym.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.sym);
				}
				else if (xmlNode.LocalName == "t")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Text1.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.t);
				}
				else if (xmlNode.LocalName == "yearLong")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.yearLong);
				}
				else if (xmlNode.LocalName == "yearShort")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.yearShort);
				}
				else if (xmlNode.LocalName == "instrText")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.instrText);
				}
				else if (xmlNode.LocalName == "footnoteRef")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.footnoteRef);
				}
				else if (xmlNode.LocalName == "rPr" && xmlNode.Prefix == "m")
				{
					ct_R.rPr = global::NPOI.OpenXmlFormats.Shared.CT_RPR.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rPr" && xmlNode.Prefix == "w")
				{
					ct_R.rPr1 = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_R;
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x000A4DF8 File Offset: 0x000A2FF8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			if (this.rPr1 != null)
			{
				this.rPr1.Write(sw, "rPr");
			}
			for (int i = 0; i < this.Items.Count; i++)
			{
				object obj = this.Items[i];
				global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6 itemsChoiceType = this.ItemsElementName[i];
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.endnoteReference)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef)obj).Write(sw, "endnoteReference");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing)
				{
					((global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing)obj).Write(sw, "drawing");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.tab)
				{
					sw.Write("<tab/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.dayLong)
				{
					sw.Write("<dayLong/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Text1 && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.t)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Text1)obj).Write(sw, "t");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.dayShort)
				{
					sw.Write("<dayShort/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.annotationRef)
				{
					sw.Write("<annotationRef/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.endnoteRef)
				{
					sw.Write("<endnoteRef/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar)obj).Write(sw, "fldChar");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.lastRenderedPageBreak)
				{
					sw.Write("<lastRenderedPageBreak/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.footnoteReference)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef)obj).Write(sw, "footnoteReference");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.delInstrText)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)obj).Write(sw, "delInstrText");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.delText)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)obj).Write(sw, "delText");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.commentReference)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "commentReference");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.monthLong)
				{
					sw.Write("<monthLong/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.monthShort)
				{
					sw.Write("<monthShort/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.continuationSeparator)
				{
					sw.Write("<continuationSeparator/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.cr)
				{
					sw.Write("<cr/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.noBreakHyphen)
				{
					sw.Write("<noBreakHyphen/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object)obj).Write(sw, "object");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br)obj).Write(sw, "br");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.pgNum)
				{
					sw.Write("<pgNum/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture)obj).Write(sw, "pict");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab)obj).Write(sw, "ptab");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby)obj).Write(sw, "ruby");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.separator)
				{
					sw.Write("<separator/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.softHyphen)
				{
					sw.Write("<softHyphen/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Sym)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Sym)obj).Write(sw, "sym");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.t)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)obj).Write(sw, "t");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.yearLong)
				{
					sw.Write("<yearLong/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.yearShort)
				{
					sw.Write("<yearShort/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.instrText)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)obj).Write(sw, "instrText");
				}
				else if (obj is global::NPOI.OpenXmlFormats.CT_Empty && itemsChoiceType == global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.footnoteRef)
				{
					sw.Write("<footnoteRef/>");
				}
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x000A5273 File Offset: 0x000A3473
		public global::NPOI.OpenXmlFormats.Shared.CT_Text1 AddNewT()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Shared.CT_Text1>(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.t);
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x000A527C File Offset: 0x000A347C
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6 type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x000A52D8 File Offset: 0x000A34D8
		public int SizeOfTArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.t);
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x000A52E4 File Offset: 0x000A34E4
		private int SizeOfArray(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6 type)
		{
			int result;
			lock (this)
			{
				int num = 0;
				for (int i = 0; i < this.itemsElementNameField.Count; i++)
				{
					if (this.itemsElementNameField[i] == type)
					{
						num++;
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x000A534C File Offset: 0x000A354C
		public global::NPOI.OpenXmlFormats.Shared.CT_Text1 GetTArray(int pos)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Shared.CT_Text1>(pos, global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6.t);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x000A5358 File Offset: 0x000A3558
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6 type) where T : class
		{
			T t;
			lock (this)
			{
				int objectIndex = this.GetObjectIndex(type, p);
				if (objectIndex < 0 || objectIndex >= this.itemsField.Count)
				{
					t = default(T);
					t = t;
				}
				else
				{
					t = (this.itemsField[objectIndex] as T);
				}
			}
			return t;
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x000A53CC File Offset: 0x000A35CC
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6 type, int p)
		{
			int result = -1;
			int num = 0;
			for (int i = 0; i < this.itemsElementNameField.Count; i++)
			{
				if (this.itemsElementNameField[i] == type)
				{
					if (num == p)
					{
						result = i;
						break;
					}
					num++;
				}
			}
			return result;
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x000A540F File Offset: 0x000A360F
		public bool IsSetRPr1()
		{
			return this.rPr1Field != null;
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x000A541A File Offset: 0x000A361A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr AddNewRPr1()
		{
			if (this.rPr1Field == null)
			{
				this.rPr1Field = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr();
			}
			return this.rPr1Field;
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x0600455A RID: 17754 RVA: 0x000A5435 File Offset: 0x000A3635
		// (set) Token: 0x0600455B RID: 17755 RVA: 0x000A543D File Offset: 0x000A363D
		[global::System.Xml.Serialization.XmlElement("t", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Text1), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("annotationRef", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("br", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("commentReference", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("continuationSeparator", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("cr", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("dayLong", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("dayShort", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("delInstrText", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("delText", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("drawing", typeof(global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("endnoteRef", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("endnoteReference", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("fldChar", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("footnoteRef", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("footnoteReference", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("instrText", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("lastRenderedPageBreak", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("monthLong", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("monthShort", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("noBreakHyphen", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("object", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("pgNum", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("pict", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("ptab", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("ruby", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("separator", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("softHyphen", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("sym", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Sym), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("t", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("tab", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("yearLong", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("yearShort", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 2)]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public global::System.Collections.ArrayList Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x000A5446 File Offset: 0x000A3646
		// (set) Token: 0x0600455D RID: 17757 RVA: 0x000A544E File Offset: 0x000A364E
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 3)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6> ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		// Token: 0x04002B6D RID: 11117
		private global::NPOI.OpenXmlFormats.Shared.CT_RPR rPrField;

		// Token: 0x04002B6E RID: 11118
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr1Field;

		// Token: 0x04002B6F RID: 11119
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x04002B70 RID: 11120
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType6> itemsElementNameField;
	}
}
