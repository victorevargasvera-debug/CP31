using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200021A RID: 538
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RegroupTable
	{
		// Token: 0x06001620 RID: 5664 RVA: 0x00041F74 File Offset: 0x00040174
		public static global::NPOI.OpenXmlFormats.Vml.Office.CT_RegroupTable Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Office.CT_RegroupTable ct_RegroupTable = new global::NPOI.OpenXmlFormats.Vml.Office.CT_RegroupTable();
			if (node.Attributes["v:ext"] != null)
			{
				ct_RegroupTable.ext = (global::NPOI.OpenXmlFormats.Vml.ST_Ext)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_Ext), node.Attributes["v:ext"].Value);
			}
			ct_RegroupTable.entry = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_Entry>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "entry")
				{
					ct_RegroupTable.entry.Add(global::NPOI.OpenXmlFormats.Vml.Office.CT_Entry.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_RegroupTable;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00042044 File Offset: 0x00040244
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<o:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v:ext", this.ext.ToString());
			sw.Write(">");
			if (this.entry != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Office.CT_Entry ct_Entry in this.entry)
				{
					ct_Entry.Write(sw, "entry");
				}
			}
			sw.Write(string.Format("</o:{0}>", nodeName));
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x000420F0 File Offset: 0x000402F0
		// (set) Token: 0x06001623 RID: 5667 RVA: 0x000420F8 File Offset: 0x000402F8
		[global::System.Xml.Serialization.XmlElement("entry")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_Entry> entry
		{
			get
			{
				return this.entryField;
			}
			set
			{
				this.entryField = value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x00042101 File Offset: 0x00040301
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x00042109 File Offset: 0x00040309
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00042112 File Offset: 0x00040312
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x04001165 RID: 4453
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_Entry> entryField;

		// Token: 0x04001166 RID: 4454
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;
	}
}
