using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000511 RID: 1297
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Row
	{
		// Token: 0x060037D4 RID: 14292 RVA: 0x0008B29C File Offset: 0x0008949C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row ct_Row = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row();
			ct_Row.r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["r"]);
			ct_Row.spans = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["spans"]);
			ct_Row.s = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["s"]);
			ct_Row.customFormat = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["customFormat"]);
			ct_Row.dyDescentField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["x14ac:dyDescent"]);
			if (node.Attributes["ht"] != null)
			{
				ct_Row.ht = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["ht"]);
			}
			ct_Row.hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"]);
			ct_Row.outlineLevel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["outlineLevel"]);
			ct_Row.customHeight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["customHeight"]);
			ct_Row.collapsed = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["collapsed"]);
			ct_Row.thickTop = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["thickTop"]);
			ct_Row.thickBot = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["thickBot"]);
			ct_Row.ph = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["ph"]);
			ct_Row.c = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_Row.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "c")
				{
					ct_Row.c.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Row;
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x0008B4BC File Offset: 0x000896BC
		public bool IsSetR()
		{
			return this.rField > 0U;
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x0008B4C8 File Offset: 0x000896C8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.r, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "spans", this.spans);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "s", this.s, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "customFormat", this.customFormat, false);
			if (this.ht >= 0.0)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ht", this.ht);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "customHeight", this.customHeight, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outlineLevel", (int)this.outlineLevel);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "collapsed", this.collapsed, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "thickTop", this.thickTop, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "thickBot", this.thickBot, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ph", this.ph, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "x14ac:dyDescent", this.dyDescentField, false);
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.c != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell ct_Cell in this.c)
				{
					ct_Cell.Write(sw, "c");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x0008B664 File Offset: 0x00089864
		public void Set(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row row)
		{
			this.cField = row.cField;
			this.extLstField = row.extLstField;
			this.rField = row.rField;
			this.spansField = row.spansField;
			this.sField = row.sField;
			this.customFormatField = row.customFormatField;
			this.htField = row.htField;
			this.hiddenField = row.hiddenField;
			this.customHeightField = row.customHeightField;
			this.outlineLevelField = row.outlineLevelField;
			this.collapsedField = row.collapsedField;
			this.thickTopField = row.thickTopField;
			this.thickBotField = row.thickBotField;
			this.phField = row.phField;
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x0008B71C File Offset: 0x0008991C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell AddNewC()
		{
			if (this.cField == null)
			{
				this.cField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell ct_Cell = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell();
			this.cField.Add(ct_Cell);
			return ct_Cell;
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x0008B74F File Offset: 0x0008994F
		public void UnsetCollapsed()
		{
			this.collapsedField = false;
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x0008B758 File Offset: 0x00089958
		public void UnsetS()
		{
			this.sField = 0U;
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x0008B761 File Offset: 0x00089961
		public void UnsetCustomFormat()
		{
			this.customFormatField = false;
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x0008B76A File Offset: 0x0008996A
		public bool IsSetHidden()
		{
			return this.hiddenField;
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x0008B772 File Offset: 0x00089972
		public bool IsSetCollapsed()
		{
			return this.collapsedField;
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x0008B77A File Offset: 0x0008997A
		public bool IsSetHt()
		{
			return this.htField >= 0.0;
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x0008B790 File Offset: 0x00089990
		public void UnsetHt()
		{
			this.htField = -1.0;
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x0008B7A1 File Offset: 0x000899A1
		public bool IsSetCustomHeight()
		{
			return this.customHeightField;
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x0008B7A9 File Offset: 0x000899A9
		public void UnsetCustomHeight()
		{
			this.customHeightField = false;
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x0008B7B2 File Offset: 0x000899B2
		public bool IsSetS()
		{
			return this.sField > 0U;
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x0008B7BD File Offset: 0x000899BD
		public void UnsetHidden()
		{
			this.hiddenField = false;
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x0008B7C6 File Offset: 0x000899C6
		public int SizeOfCArray()
		{
			if (this.cField != null)
			{
				return this.cField.Count;
			}
			return 0;
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x0008B7DD File Offset: 0x000899DD
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell GetCArray(int index)
		{
			if (this.cField != null)
			{
				return this.cField[index];
			}
			return null;
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x0008B7F5 File Offset: 0x000899F5
		public void SetCArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell[] array)
		{
			this.cField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell>(array);
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x0008B803 File Offset: 0x00089A03
		// (set) Token: 0x060037E8 RID: 14312 RVA: 0x0008B80B File Offset: 0x00089A0B
		[global::System.Xml.Serialization.XmlElement("c")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell> c
		{
			get
			{
				return this.cField;
			}
			set
			{
				this.cField = value;
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x060037E9 RID: 14313 RVA: 0x0008B814 File Offset: 0x00089A14
		// (set) Token: 0x060037EA RID: 14314 RVA: 0x0008B81C File Offset: 0x00089A1C
		[global::System.Xml.Serialization.XmlElement("extLst")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x060037EB RID: 14315 RVA: 0x0008B825 File Offset: 0x00089A25
		// (set) Token: 0x060037EC RID: 14316 RVA: 0x0008B82D File Offset: 0x00089A2D
		[global::System.Xml.Serialization.XmlAttribute("r")]
		public uint r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x0008B836 File Offset: 0x00089A36
		// (set) Token: 0x060037EE RID: 14318 RVA: 0x0008B83E File Offset: 0x00089A3E
		[global::System.Xml.Serialization.XmlAttribute]
		public string spans
		{
			get
			{
				return this.spansField;
			}
			set
			{
				this.spansField = value;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x0008B847 File Offset: 0x00089A47
		// (set) Token: 0x060037F0 RID: 14320 RVA: 0x0008B84F File Offset: 0x00089A4F
		[global::System.Xml.Serialization.XmlAttribute]
		public uint s
		{
			get
			{
				return this.sField;
			}
			set
			{
				this.sField = value;
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x0008B858 File Offset: 0x00089A58
		// (set) Token: 0x060037F2 RID: 14322 RVA: 0x0008B860 File Offset: 0x00089A60
		[global::System.Xml.Serialization.XmlAttribute]
		public bool customFormat
		{
			get
			{
				return this.customFormatField;
			}
			set
			{
				this.customFormatField = value;
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x0008B869 File Offset: 0x00089A69
		// (set) Token: 0x060037F4 RID: 14324 RVA: 0x0008B871 File Offset: 0x00089A71
		[global::System.Xml.Serialization.XmlAttribute]
		public double ht
		{
			get
			{
				return this.htField;
			}
			set
			{
				this.htField = value;
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x0008B76A File Offset: 0x0008996A
		// (set) Token: 0x060037F6 RID: 14326 RVA: 0x0008B87A File Offset: 0x00089A7A
		[global::System.Xml.Serialization.XmlAttribute]
		public bool hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x0008B7A1 File Offset: 0x000899A1
		// (set) Token: 0x060037F8 RID: 14328 RVA: 0x0008B883 File Offset: 0x00089A83
		[global::System.Xml.Serialization.XmlAttribute]
		public bool customHeight
		{
			get
			{
				return this.customHeightField;
			}
			set
			{
				this.customHeightField = value;
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x060037F9 RID: 14329 RVA: 0x0008B88C File Offset: 0x00089A8C
		// (set) Token: 0x060037FA RID: 14330 RVA: 0x0008B894 File Offset: 0x00089A94
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		[global::System.Xml.Serialization.XmlAttribute]
		public byte outlineLevel
		{
			get
			{
				return this.outlineLevelField;
			}
			set
			{
				this.outlineLevelField = value;
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x0008B772 File Offset: 0x00089972
		// (set) Token: 0x060037FC RID: 14332 RVA: 0x0008B89D File Offset: 0x00089A9D
		[global::System.Xml.Serialization.XmlAttribute]
		public bool collapsed
		{
			get
			{
				return this.collapsedField;
			}
			set
			{
				this.collapsedField = value;
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060037FD RID: 14333 RVA: 0x0008B8A6 File Offset: 0x00089AA6
		// (set) Token: 0x060037FE RID: 14334 RVA: 0x0008B8AE File Offset: 0x00089AAE
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool thickTop
		{
			get
			{
				return this.thickTopField;
			}
			set
			{
				this.thickTopField = value;
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x0008B8B7 File Offset: 0x00089AB7
		// (set) Token: 0x06003800 RID: 14336 RVA: 0x0008B8BF File Offset: 0x00089ABF
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool thickBot
		{
			get
			{
				return this.thickBotField;
			}
			set
			{
				this.thickBotField = value;
			}
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06003801 RID: 14337 RVA: 0x0008B8C8 File Offset: 0x00089AC8
		// (set) Token: 0x06003802 RID: 14338 RVA: 0x0008B8D0 File Offset: 0x00089AD0
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool ph
		{
			get
			{
				return this.phField;
			}
			set
			{
				this.phField = value;
			}
		}

		// Token: 0x04002434 RID: 9268
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell> cField;

		// Token: 0x04002435 RID: 9269
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002436 RID: 9270
		private uint rField;

		// Token: 0x04002437 RID: 9271
		private string spansField;

		// Token: 0x04002438 RID: 9272
		private uint sField;

		// Token: 0x04002439 RID: 9273
		private bool customFormatField;

		// Token: 0x0400243A RID: 9274
		private double htField = -1.0;

		// Token: 0x0400243B RID: 9275
		private bool hiddenField;

		// Token: 0x0400243C RID: 9276
		private bool customHeightField;

		// Token: 0x0400243D RID: 9277
		private byte outlineLevelField;

		// Token: 0x0400243E RID: 9278
		private bool collapsedField;

		// Token: 0x0400243F RID: 9279
		private bool thickTopField;

		// Token: 0x04002440 RID: 9280
		private bool thickBotField;

		// Token: 0x04002441 RID: 9281
		private bool phField;

		// Token: 0x04002442 RID: 9282
		private double dyDescentField;
	}
}
