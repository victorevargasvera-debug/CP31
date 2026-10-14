using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001BD RID: 445
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TrPr : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrBase
	{
		// Token: 0x060010F2 RID: 4338 RVA: 0x00038178 File Offset: 0x00036378
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr ct_TrPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ins")
				{
					ct_TrPr.ins = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_TrPr.del = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "trPrChange")
				{
					ct_TrPr.trPrChange = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gridBefore")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.gridBefore);
				}
				else if (xmlNode.LocalName == "cantSplit")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cantSplit);
				}
				else if (xmlNode.LocalName == "cnfStyle")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cnfStyle);
				}
				else if (xmlNode.LocalName == "divId")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.divId);
				}
				else if (xmlNode.LocalName == "gridAfter")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.gridAfter);
				}
				else if (xmlNode.LocalName == "trHeight")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.trHeight);
				}
				else if (xmlNode.LocalName == "hidden")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.hidden);
				}
				else if (xmlNode.LocalName == "tblCellSpacing")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblCellSpacing);
				}
				else if (xmlNode.LocalName == "tblHeader")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblHeader);
				}
				else if (xmlNode.LocalName == "jc")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.jc);
				}
				else if (xmlNode.LocalName == "wAfter")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.wAfter);
				}
				else if (xmlNode.LocalName == "wBefore")
				{
					ct_TrPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager));
					ct_TrPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.wBefore);
				}
			}
			return ct_TrPr;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x000384D4 File Offset: 0x000366D4
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.ins != null)
			{
				this.ins.Write(sw, "ins");
			}
			if (this.del != null)
			{
				this.del.Write(sw, "del");
			}
			if (this.trPrChange != null)
			{
				this.trPrChange.Write(sw, "trPrChange");
			}
			for (int i = 0; i < base.Items.Count; i++)
			{
				object obj = base.Items[i];
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.gridBefore)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber)obj).Write(sw, "gridBefore");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cantSplit)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff)obj).Write(sw, "cantSplit");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cnfStyle)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf)obj).Write(sw, "cnfStyle");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.divId)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber)obj).Write(sw, "divId");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.gridAfter)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber)obj).Write(sw, "gridAfter");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.trHeight)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height)obj).Write(sw, "trHeight");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.hidden)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff)obj).Write(sw, "hidden");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblCellSpacing)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth)obj).Write(sw, "tblCellSpacing");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblHeader)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff)obj).Write(sw, "tblHeader");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.jc)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc)obj).Write(sw, "jc");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.wAfter)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth)obj).Write(sw, "wAfter");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth && base.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.wBefore)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth)obj).Write(sw, "wBefore");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00038792 File Offset: 0x00036992
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x0003879A File Offset: 0x0003699A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange ins
		{
			get
			{
				return this.insField;
			}
			set
			{
				this.insField = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x000387A3 File Offset: 0x000369A3
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x000387AB File Offset: 0x000369AB
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange del
		{
			get
			{
				return this.delField;
			}
			set
			{
				this.delField = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x000387B4 File Offset: 0x000369B4
		// (set) Token: 0x060010F9 RID: 4345 RVA: 0x000387BC File Offset: 0x000369BC
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrChange trPrChange
		{
			get
			{
				return this.trPrChangeField;
			}
			set
			{
				this.trPrChangeField = value;
			}
		}

		// Token: 0x04000D59 RID: 3417
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange insField;

		// Token: 0x04000D5A RID: 3418
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange delField;

		// Token: 0x04000D5B RID: 3419
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrChange trPrChangeField;
	}
}
