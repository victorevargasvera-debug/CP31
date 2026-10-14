using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000613 RID: 1555
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_UnderlineProperty
	{
		// Token: 0x060043EA RID: 17386 RVA: 0x000A193A File Offset: 0x0009FB3A
		public CT_UnderlineProperty()
		{
			this.valField = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues?(global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues.single);
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x000A1950 File Offset: 0x0009FB50
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty ct_UnderlineProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty();
			if (node.Attributes["val"] != null)
			{
				ct_UnderlineProperty.val = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues), node.Attributes["val"].Value);
			}
			return ct_UnderlineProperty;
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x000A19AC File Offset: 0x0009FBAC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x060043ED RID: 17389 RVA: 0x000A19F4 File Offset: 0x0009FBF4
		// (set) Token: 0x060043EE RID: 17390 RVA: 0x000A1A10 File Offset: 0x0009FC10
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues.single)]
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues val
		{
			get
			{
				if (this.valField != null)
				{
					return this.valField.Value;
				}
				return global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues.single;
			}
			set
			{
				this.valField = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues?(value);
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x000A1A1E File Offset: 0x0009FC1E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valbSpecified
		{
			get
			{
				return this.valField != null;
			}
		}

		// Token: 0x04002AB0 RID: 10928
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues? valField;
	}
}
