using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000522 RID: 1314
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ExternalReferences
	{
		// Token: 0x060039C8 RID: 14792 RVA: 0x0008F860 File Offset: 0x0008DA60
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReferences Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReferences ct_ExternalReferences = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReferences();
			ct_ExternalReferences.externalReference = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReference>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "externalReference")
				{
					ct_ExternalReferences.externalReference.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReference.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ExternalReferences;
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x0008F8F0 File Offset: 0x0008DAF0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.externalReference != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReference ct_ExternalReference in this.externalReference)
				{
					ct_ExternalReference.Write(sw, "externalReference");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x060039CB RID: 14795 RVA: 0x0008F97C File Offset: 0x0008DB7C
		// (set) Token: 0x060039CC RID: 14796 RVA: 0x0008F984 File Offset: 0x0008DB84
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReference> externalReference
		{
			get
			{
				return this.externalReferenceField;
			}
			set
			{
				this.externalReferenceField = value;
			}
		}

		// Token: 0x040024F0 RID: 9456
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReference> externalReferenceField;
	}
}
