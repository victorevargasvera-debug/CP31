using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004C2 RID: 1218
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_RowFields
	{
		// Token: 0x060032F0 RID: 13040 RVA: 0x0007F9B4 File Offset: 0x0007DBB4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowFields Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowFields ct_RowFields = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RowFields();
			if (node.Attributes["count"] != null)
			{
				ct_RowFields.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_RowFields.field = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "field")
				{
					ct_RowFields.field.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_RowFields;
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x0007FA70 File Offset: 0x0007DC70
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

		// Token: 0x060032F2 RID: 13042 RVA: 0x0007FB10 File Offset: 0x0007DD10
		public CT_RowFields()
		{
			this.fieldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field>();
			this.countField = 0U;
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x060032F3 RID: 13043 RVA: 0x0007FB2A File Offset: 0x0007DD2A
		// (set) Token: 0x060032F4 RID: 13044 RVA: 0x0007FB32 File Offset: 0x0007DD32
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

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x0007FB3B File Offset: 0x0007DD3B
		// (set) Token: 0x060032F6 RID: 13046 RVA: 0x0007FB43 File Offset: 0x0007DD43
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

		// Token: 0x060032F7 RID: 13047 RVA: 0x0007FB4C File Offset: 0x0007DD4C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field AddNewField()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field ct_Field = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field();
			this.fieldField.Add(ct_Field);
			return ct_Field;
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x0007FB6C File Offset: 0x0007DD6C
		public uint SizeOfFieldArray()
		{
			return (uint)this.fieldField.Count;
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x0007FB2A File Offset: 0x0007DD2A
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field> GetFieldArray()
		{
			return this.fieldField;
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x0007FB79 File Offset: 0x0007DD79
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field GetFieldArray(int p)
		{
			return this.fieldField[p];
		}

		// Token: 0x04002213 RID: 8723
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Field> fieldField;

		// Token: 0x04002214 RID: 8724
		private uint countField;
	}
}
