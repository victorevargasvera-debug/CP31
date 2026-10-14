using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004C6 RID: 1222
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_ColFields
	{
		// Token: 0x06003314 RID: 13076 RVA: 0x00080028 File Offset: 0x0007E228
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColFields Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColFields ct_ColFields = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColFields();
			if (node.Attributes["count"] != null)
			{
				ct_ColFields.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_ColFields.field = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "field")
				{
					ct_ColFields.field.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ColFields;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000800E4 File Offset: 0x0007E2E4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.field != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field ct_Field in this.field)
				{
					ct_Field.Write(sw, "field");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00080184 File Offset: 0x0007E384
		public CT_ColFields()
		{
			this.fieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field>();
			this.countField = 0U;
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06003317 RID: 13079 RVA: 0x0008019E File Offset: 0x0007E39E
		// (set) Token: 0x06003318 RID: 13080 RVA: 0x000801A6 File Offset: 0x0007E3A6
		[global::System.Xml.Serialization.XmlElement("field", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field> field
		{
			get
			{
				return this.fieldField;
			}
			set
			{
				this.fieldField = value;
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x000801AF File Offset: 0x0007E3AF
		// (set) Token: 0x0600331A RID: 13082 RVA: 0x000801B7 File Offset: 0x0007E3B7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
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

		// Token: 0x0600331B RID: 13083 RVA: 0x000801C0 File Offset: 0x0007E3C0
		public uint SizeOfFieldArray()
		{
			if (this.fieldField == null)
			{
				this.fieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field>();
			}
			return (uint)this.fieldField.Count;
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x000801E0 File Offset: 0x0007E3E0
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field AddNewField()
		{
			if (this.fieldField == null)
			{
				this.fieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field ct_Field = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field();
			this.fieldField.Add(ct_Field);
			return ct_Field;
		}

		// Token: 0x0400221D RID: 8733
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field> fieldField;

		// Token: 0x0400221E RID: 8734
		private uint countField;
	}
}
