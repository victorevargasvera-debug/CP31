using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000B3 RID: 179
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumPr
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPr ct_NumPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ilvl")
				{
					ct_NumPr.ilvl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numId")
				{
					ct_NumPr.numId = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numberingChange")
				{
					ct_NumPr.numberingChange = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangeNumbering.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_NumPr.ins = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NumPr;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.ilvl != null)
			{
				this.ilvl.Write(sw, "ilvl");
			}
			if (this.numId != null)
			{
				this.numId.Write(sw, "numId");
			}
			if (this.numberingChange != null)
			{
				this.numberingChange.Write(sw, "numberingChange");
			}
			if (this.ins != null)
			{
				this.ins.Write(sw, "ins");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000E06A File Offset: 0x0000C26A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber AddNewIlvl()
		{
			this.ilvlField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			return this.ilvlField;
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x0000E07D File Offset: 0x0000C27D
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x0000E085 File Offset: 0x0000C285
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber ilvl
		{
			get
			{
				return this.ilvlField;
			}
			set
			{
				this.ilvlField = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0000E08E File Offset: 0x0000C28E
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x0000E096 File Offset: 0x0000C296
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber numId
		{
			get
			{
				return this.numIdField;
			}
			set
			{
				this.numIdField = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0000E09F File Offset: 0x0000C29F
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x0000E0A7 File Offset: 0x0000C2A7
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangeNumbering numberingChange
		{
			get
			{
				return this.numberingChangeField;
			}
			set
			{
				this.numberingChangeField = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0000E0B0 File Offset: 0x0000C2B0
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000E0C1 File Offset: 0x0000C2C1
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber AddNewNumId()
		{
			this.numId = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			return this.numId;
		}

		// Token: 0x0400046C RID: 1132
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber ilvlField;

		// Token: 0x0400046D RID: 1133
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber numIdField;

		// Token: 0x0400046E RID: 1134
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangeNumbering numberingChangeField;

		// Token: 0x0400046F RID: 1135
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange insField;
	}
}
