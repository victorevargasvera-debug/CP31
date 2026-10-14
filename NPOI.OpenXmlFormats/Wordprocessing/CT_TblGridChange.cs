using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001A4 RID: 420
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblGridChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup
	{
		// Token: 0x06000FDC RID: 4060 RVA: 0x000341A4 File Offset: 0x000323A4
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridChange ct_TblGridChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridChange();
			ct_TblGridChange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			ct_TblGridChange.tblGrid = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tblGrid")
				{
					ct_TblGridChange.tblGrid.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_TblGridChange;
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x0003424C File Offset: 0x0003244C
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", base.id);
			sw.Write(">");
			if (this.tblGrid != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol ct_TblGridCol in this.tblGrid)
				{
					ct_TblGridCol.Write(sw, "tblGrid");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x000342E8 File Offset: 0x000324E8
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x000342F0 File Offset: 0x000324F0
		[global::System.Xml.Serialization.XmlArray(Order = 0)]
		[global::System.Xml.Serialization.XmlArrayItem("gridCol", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol> tblGrid
		{
			get
			{
				return this.tblGridField;
			}
			set
			{
				this.tblGridField = value;
			}
		}

		// Token: 0x04000CD4 RID: 3284
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol> tblGridField;
	}
}
