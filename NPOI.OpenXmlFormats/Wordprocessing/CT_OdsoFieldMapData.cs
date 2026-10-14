using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200018A RID: 394
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OdsoFieldMapData
	{
		// Token: 0x06000E2B RID: 3627 RVA: 0x0002F770 File Offset: 0x0002D970
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_OdsoFieldMapData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_OdsoFieldMapData ct_OdsoFieldMapData = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OdsoFieldMapData();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "type")
				{
					ct_OdsoFieldMapData.type = global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeOdsoFMDFieldType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "name")
				{
					ct_OdsoFieldMapData.name = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mappedName")
				{
					ct_OdsoFieldMapData.mappedName = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "column")
				{
					ct_OdsoFieldMapData.column = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lid")
				{
					ct_OdsoFieldMapData.lid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lang.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dynamicAddress")
				{
					ct_OdsoFieldMapData.dynamicAddress = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_OdsoFieldMapData;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0002F8A0 File Offset: 0x0002DAA0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.type != null)
			{
				this.type.Write(sw, "type");
			}
			if (this.name != null)
			{
				this.name.Write(sw, "name");
			}
			if (this.mappedName != null)
			{
				this.mappedName.Write(sw, "mappedName");
			}
			if (this.column != null)
			{
				this.column.Write(sw, "column");
			}
			if (this.lid != null)
			{
				this.lid.Write(sw, "lid");
			}
			if (this.dynamicAddress != null)
			{
				this.dynamicAddress.Write(sw, "dynamicAddress");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x0002F970 File Offset: 0x0002DB70
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x0002F978 File Offset: 0x0002DB78
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeOdsoFMDFieldType type
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

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0002F981 File Offset: 0x0002DB81
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x0002F989 File Offset: 0x0002DB89
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x0002F992 File Offset: 0x0002DB92
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x0002F99A File Offset: 0x0002DB9A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String mappedName
		{
			get
			{
				return this.mappedNameField;
			}
			set
			{
				this.mappedNameField = value;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x0002F9A3 File Offset: 0x0002DBA3
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x0002F9AB File Offset: 0x0002DBAB
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber column
		{
			get
			{
				return this.columnField;
			}
			set
			{
				this.columnField = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x0002F9B4 File Offset: 0x0002DBB4
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x0002F9BC File Offset: 0x0002DBBC
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lang lid
		{
			get
			{
				return this.lidField;
			}
			set
			{
				this.lidField = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0002F9C5 File Offset: 0x0002DBC5
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x0002F9CD File Offset: 0x0002DBCD
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff dynamicAddress
		{
			get
			{
				return this.dynamicAddressField;
			}
			set
			{
				this.dynamicAddressField = value;
			}
		}

		// Token: 0x04000BF0 RID: 3056
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeOdsoFMDFieldType typeField;

		// Token: 0x04000BF1 RID: 3057
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String nameField;

		// Token: 0x04000BF2 RID: 3058
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String mappedNameField;

		// Token: 0x04000BF3 RID: 3059
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber columnField;

		// Token: 0x04000BF4 RID: 3060
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lang lidField;

		// Token: 0x04000BF5 RID: 3061
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff dynamicAddressField;
	}
}
