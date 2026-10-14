using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001A7 RID: 423
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblGrid : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridBase
	{
		// Token: 0x06000FEB RID: 4075 RVA: 0x000343A0 File Offset: 0x000325A0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGrid Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGrid ct_TblGrid = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGrid();
			ct_TblGrid.gridCol = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tblGridChange")
				{
					ct_TblGrid.tblGridChange = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gridCol")
				{
					ct_TblGrid.gridCol.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_TblGrid;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00034450 File Offset: 0x00032650
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.tblGridChange != null)
			{
				this.tblGridChange.Write(sw, "tblGridChange");
			}
			if (base.gridCol != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol ct_TblGridCol in base.gridCol)
				{
					ct_TblGridCol.Write(sw, "gridCol");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x000344F4 File Offset: 0x000326F4
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x000344FC File Offset: 0x000326FC
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridChange tblGridChange
		{
			get
			{
				return this.tblGridChangeField;
			}
			set
			{
				this.tblGridChangeField = value;
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00034508 File Offset: 0x00032708
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol AddNewGridCol()
		{
			if (base.gridCol == null)
			{
				base.gridCol = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol>();
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol ct_TblGridCol = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol();
			base.gridCol.Add(ct_TblGridCol);
			return ct_TblGridCol;
		}

		// Token: 0x04000CD8 RID: 3288
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridChange tblGridChangeField;
	}
}
