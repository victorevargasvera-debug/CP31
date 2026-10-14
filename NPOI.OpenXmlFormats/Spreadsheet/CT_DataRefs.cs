using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200058F RID: 1423
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_DataRefs
	{
		// Token: 0x06003E84 RID: 16004 RVA: 0x00097995 File Offset: 0x00095B95
		public CT_DataRefs()
		{
			this.dataRefField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRef>();
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06003E85 RID: 16005 RVA: 0x000979A8 File Offset: 0x00095BA8
		// (set) Token: 0x06003E86 RID: 16006 RVA: 0x000979B0 File Offset: 0x00095BB0
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRef> dataRef
		{
			get
			{
				return this.dataRefField;
			}
			set
			{
				this.dataRefField = value;
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06003E87 RID: 16007 RVA: 0x000979B9 File Offset: 0x00095BB9
		// (set) Token: 0x06003E88 RID: 16008 RVA: 0x000979C1 File Offset: 0x00095BC1
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x000979CA File Offset: 0x00095BCA
		// (set) Token: 0x06003E8A RID: 16010 RVA: 0x000979D2 File Offset: 0x00095BD2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x000979DC File Offset: 0x00095BDC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRefs Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRefs ct_DataRefs = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRefs();
			ct_DataRefs.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_DataRefs.dataRef = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRef>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dataRef")
				{
					ct_DataRefs.dataRef.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRef.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DataRefs;
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x00097A84 File Offset: 0x00095C84
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.dataRef != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRef ct_DataRef in this.dataRef)
				{
					ct_DataRef.Write(sw, "dataRef");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040027B1 RID: 10161
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRef> dataRefField;

		// Token: 0x040027B2 RID: 10162
		private uint countField;

		// Token: 0x040027B3 RID: 10163
		private bool countFieldSpecified;
	}
}
