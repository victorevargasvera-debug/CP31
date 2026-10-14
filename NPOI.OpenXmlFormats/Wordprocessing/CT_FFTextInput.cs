using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000099 RID: 153
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FFTextInput
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x0000CABE File Offset: 0x0000ACBE
		public CT_FFTextInput()
		{
			this.formatField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
			this.maxLengthField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			this.defaultField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
			this.typeField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextType();
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000CAF2 File Offset: 0x0000ACF2
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x0000CAFA File Offset: 0x0000ACFA
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextType type
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

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0000CB03 File Offset: 0x0000AD03
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x0000CB0B File Offset: 0x0000AD0B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String @default
		{
			get
			{
				return this.defaultField;
			}
			set
			{
				this.defaultField = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0000CB14 File Offset: 0x0000AD14
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x0000CB1C File Offset: 0x0000AD1C
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber maxLength
		{
			get
			{
				return this.maxLengthField;
			}
			set
			{
				this.maxLengthField = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0000CB25 File Offset: 0x0000AD25
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x0000CB2D File Offset: 0x0000AD2D
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000CB38 File Offset: 0x0000AD38
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextInput Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextInput ct_FFTextInput = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextInput();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "type")
				{
					ct_FFTextInput.typeField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "default")
				{
					ct_FFTextInput.defaultField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "format")
				{
					ct_FFTextInput.formatField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "maxLength")
				{
					ct_FFTextInput.maxLengthField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_FFTextInput;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000CC20 File Offset: 0x0000AE20
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}>", nodeName));
			if (this.typeField == null)
			{
				this.typeField.Write(sw, "type");
			}
			if (this.defaultField != null)
			{
				this.defaultField.Write(sw, "default");
			}
			if (this.formatField != null)
			{
				this.formatField.Write(sw, "format");
			}
			if (this.maxLengthField != null)
			{
				this.maxLengthField.Write(sw, "maxLength");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x040003B1 RID: 945
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextType typeField;

		// Token: 0x040003B2 RID: 946
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String defaultField;

		// Token: 0x040003B3 RID: 947
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber maxLengthField;

		// Token: 0x040003B4 RID: 948
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String formatField;
	}
}
