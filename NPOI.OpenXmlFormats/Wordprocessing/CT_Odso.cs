using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000187 RID: 391
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Odso
	{
		// Token: 0x06000E14 RID: 3604 RVA: 0x0002F30C File Offset: 0x0002D50C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Odso Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Odso ct_Odso = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Odso();
			ct_Odso.fieldMapData = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OdsoFieldMapData>();
			ct_Odso.recipientData = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "udl")
				{
					ct_Odso.udl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "table")
				{
					ct_Odso.table = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "src")
				{
					ct_Odso.src = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "colDelim")
				{
					ct_Odso.colDelim = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "type")
				{
					ct_Odso.type = global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeSourceType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fHdr")
				{
					ct_Odso.fHdr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fieldMapData")
				{
					ct_Odso.fieldMapData.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OdsoFieldMapData.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "recipientData")
				{
					ct_Odso.recipientData.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Odso;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0002F4B0 File Offset: 0x0002D6B0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.udl != null)
			{
				this.udl.Write(sw, "udl");
			}
			if (this.table != null)
			{
				this.table.Write(sw, "table");
			}
			if (this.src != null)
			{
				this.src.Write(sw, "src");
			}
			if (this.colDelim != null)
			{
				this.colDelim.Write(sw, "colDelim");
			}
			if (this.type != null)
			{
				this.type.Write(sw, "type");
			}
			if (this.fHdr != null)
			{
				this.fHdr.Write(sw, "fHdr");
			}
			if (this.fieldMapData != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OdsoFieldMapData ct_OdsoFieldMapData in this.fieldMapData)
				{
					ct_OdsoFieldMapData.Write(sw, "fieldMapData");
				}
			}
			if (this.recipientData != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel ct_Rel in this.recipientData)
				{
					ct_Rel.Write(sw, "recipientData");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0002F620 File Offset: 0x0002D820
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x0002F628 File Offset: 0x0002D828
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String udl
		{
			get
			{
				return this.udlField;
			}
			set
			{
				this.udlField = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0002F631 File Offset: 0x0002D831
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x0002F639 File Offset: 0x0002D839
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String table
		{
			get
			{
				return this.tableField;
			}
			set
			{
				this.tableField = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0002F642 File Offset: 0x0002D842
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x0002F64A File Offset: 0x0002D84A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel src
		{
			get
			{
				return this.srcField;
			}
			set
			{
				this.srcField = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x0002F653 File Offset: 0x0002D853
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x0002F65B File Offset: 0x0002D85B
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber colDelim
		{
			get
			{
				return this.colDelimField;
			}
			set
			{
				this.colDelimField = value;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x0002F664 File Offset: 0x0002D864
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x0002F66C File Offset: 0x0002D86C
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeSourceType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0002F675 File Offset: 0x0002D875
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x0002F67D File Offset: 0x0002D87D
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff fHdr
		{
			get
			{
				return this.fHdrField;
			}
			set
			{
				this.fHdrField = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0002F686 File Offset: 0x0002D886
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x0002F68E File Offset: 0x0002D88E
		[global::System.Xml.Serialization.XmlElement("fieldMapData", Order = 6)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OdsoFieldMapData> fieldMapData
		{
			get
			{
				return this.fieldMapDataField;
			}
			set
			{
				this.fieldMapDataField = value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0002F697 File Offset: 0x0002D897
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x0002F69F File Offset: 0x0002D89F
		[global::System.Xml.Serialization.XmlElement("recipientData", Order = 7)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel> recipientData
		{
			get
			{
				return this.recipientDataField;
			}
			set
			{
				this.recipientDataField = value;
			}
		}

		// Token: 0x04000BDD RID: 3037
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String udlField;

		// Token: 0x04000BDE RID: 3038
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String tableField;

		// Token: 0x04000BDF RID: 3039
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel srcField;

		// Token: 0x04000BE0 RID: 3040
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber colDelimField;

		// Token: 0x04000BE1 RID: 3041
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeSourceType typeField;

		// Token: 0x04000BE2 RID: 3042
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff fHdrField;

		// Token: 0x04000BE3 RID: 3043
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OdsoFieldMapData> fieldMapDataField;

		// Token: 0x04000BE4 RID: 3044
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel> recipientDataField;
	}
}
