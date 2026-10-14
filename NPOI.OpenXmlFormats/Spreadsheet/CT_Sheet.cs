using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000512 RID: 1298
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("sheet", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Sheet
	{
		// Token: 0x06003804 RID: 14340 RVA: 0x0008B8F0 File Offset: 0x00089AF0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet ct_Sheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet();
			ct_Sheet.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_Sheet.sheetId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["sheetId"]);
			if (node.Attributes["state"] != null)
			{
				ct_Sheet.state = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState), node.Attributes["state"].Value);
			}
			ct_Sheet.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"]);
			return ct_Sheet;
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x0008B9A0 File Offset: 0x00089BA0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sheetId", this.sheetId, false);
			if (this.state != global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState.visible)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "state", this.state.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x0008BA35 File Offset: 0x00089C35
		public CT_Sheet()
		{
			this.stateField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState.visible;
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x0008BA44 File Offset: 0x00089C44
		public void Set(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet sheet)
		{
			this.nameField = sheet.nameField;
			this.sheetIdField = sheet.sheetIdField;
			this.stateField = sheet.stateField;
			this.idField = sheet.idField;
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x0008BA76 File Offset: 0x00089C76
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet Copy()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet
			{
				idField = this.idField,
				sheetIdField = this.sheetIdField,
				nameField = this.nameField,
				stateField = this.stateField
			};
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x0008BAAD File Offset: 0x00089CAD
		// (set) Token: 0x0600380A RID: 14346 RVA: 0x0008BAB5 File Offset: 0x00089CB5
		[global::System.Xml.Serialization.XmlAttribute("name")]
		public string name
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

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x0008BABE File Offset: 0x00089CBE
		// (set) Token: 0x0600380C RID: 14348 RVA: 0x0008BAC6 File Offset: 0x00089CC6
		[global::System.Xml.Serialization.XmlAttribute("sheetId")]
		public uint sheetId
		{
			get
			{
				return this.sheetIdField;
			}
			set
			{
				this.sheetIdField = value;
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x0008BACF File Offset: 0x00089CCF
		// (set) Token: 0x0600380E RID: 14350 RVA: 0x0008BAD7 File Offset: 0x00089CD7
		[global::System.Xml.Serialization.XmlAttribute("state")]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState.visible)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x0008BAE0 File Offset: 0x00089CE0
		// (set) Token: 0x06003810 RID: 14352 RVA: 0x0008BAE8 File Offset: 0x00089CE8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x04002443 RID: 9283
		private string nameField;

		// Token: 0x04002444 RID: 9284
		private uint sheetIdField;

		// Token: 0x04002445 RID: 9285
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_SheetState stateField;

		// Token: 0x04002446 RID: 9286
		private string idField;
	}
}
