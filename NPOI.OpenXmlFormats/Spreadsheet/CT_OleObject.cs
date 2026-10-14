using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005B3 RID: 1459
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_OleObject
	{
		// Token: 0x06004049 RID: 16457 RVA: 0x0009BF8C File Offset: 0x0009A18C
		public CT_OleObject()
		{
			this.dvAspectField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DvAspect.DVASPECT_CONTENT;
			this.autoLoadField = false;
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x0009BFA2 File Offset: 0x0009A1A2
		// (set) Token: 0x0600404B RID: 16459 RVA: 0x0009BFAA File Offset: 0x0009A1AA
		public string progId
		{
			get
			{
				return this.progIdField;
			}
			set
			{
				this.progIdField = value;
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x0009BFB3 File Offset: 0x0009A1B3
		// (set) Token: 0x0600404D RID: 16461 RVA: 0x0009BFBB File Offset: 0x0009A1BB
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DvAspect.DVASPECT_CONTENT)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_DvAspect dvAspect
		{
			get
			{
				return this.dvAspectField;
			}
			set
			{
				this.dvAspectField = value;
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x0600404E RID: 16462 RVA: 0x0009BFC4 File Offset: 0x0009A1C4
		// (set) Token: 0x0600404F RID: 16463 RVA: 0x0009BFCC File Offset: 0x0009A1CC
		public string link
		{
			get
			{
				return this.linkField;
			}
			set
			{
				this.linkField = value;
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06004050 RID: 16464 RVA: 0x0009BFD5 File Offset: 0x0009A1D5
		// (set) Token: 0x06004051 RID: 16465 RVA: 0x0009BFDD File Offset: 0x0009A1DD
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_OleUpdate oleUpdate
		{
			get
			{
				return this.oleUpdateField;
			}
			set
			{
				this.oleUpdateField = value;
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x0009BFE6 File Offset: 0x0009A1E6
		// (set) Token: 0x06004053 RID: 16467 RVA: 0x0009BFEE File Offset: 0x0009A1EE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool oleUpdateSpecified
		{
			get
			{
				return this.oleUpdateFieldSpecified;
			}
			set
			{
				this.oleUpdateFieldSpecified = value;
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06004054 RID: 16468 RVA: 0x0009BFF7 File Offset: 0x0009A1F7
		// (set) Token: 0x06004055 RID: 16469 RVA: 0x0009BFFF File Offset: 0x0009A1FF
		[global::System.ComponentModel.DefaultValue(false)]
		public bool autoLoad
		{
			get
			{
				return this.autoLoadField;
			}
			set
			{
				this.autoLoadField = value;
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x0009C008 File Offset: 0x0009A208
		// (set) Token: 0x06004057 RID: 16471 RVA: 0x0009C010 File Offset: 0x0009A210
		public uint shapeId
		{
			get
			{
				return this.shapeIdField;
			}
			set
			{
				this.shapeIdField = value;
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x0009C019 File Offset: 0x0009A219
		// (set) Token: 0x06004059 RID: 16473 RVA: 0x0009C021 File Offset: 0x0009A221
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

		// Token: 0x0600405A RID: 16474 RVA: 0x0009C02C File Offset: 0x0009A22C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject ct_OleObject = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject();
			ct_OleObject.progId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["progId"]);
			if (node.Attributes["dvAspect"] != null)
			{
				ct_OleObject.dvAspect = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_DvAspect)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DvAspect), node.Attributes["dvAspect"].Value);
			}
			ct_OleObject.link = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["link"]);
			if (node.Attributes["oleUpdate"] != null)
			{
				ct_OleObject.oleUpdate = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_OleUpdate)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_OleUpdate), node.Attributes["oleUpdate"].Value);
			}
			ct_OleObject.autoLoad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoLoad"]);
			ct_OleObject.shapeId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["shapeId"]);
			ct_OleObject.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"]);
			return ct_OleObject;
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x0009C154 File Offset: 0x0009A354
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "progId", this.progId);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dvAspect", this.dvAspect.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "link", this.link);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "oleUpdate", this.oleUpdate.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoLoad", this.autoLoad);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "shapeId", this.shapeId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write("/>");
		}

		// Token: 0x040028C5 RID: 10437
		private string progIdField;

		// Token: 0x040028C6 RID: 10438
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_DvAspect dvAspectField;

		// Token: 0x040028C7 RID: 10439
		private string linkField;

		// Token: 0x040028C8 RID: 10440
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_OleUpdate oleUpdateField;

		// Token: 0x040028C9 RID: 10441
		private bool oleUpdateFieldSpecified;

		// Token: 0x040028CA RID: 10442
		private bool autoLoadField;

		// Token: 0x040028CB RID: 10443
		private uint shapeIdField;

		// Token: 0x040028CC RID: 10444
		private string idField;
	}
}
