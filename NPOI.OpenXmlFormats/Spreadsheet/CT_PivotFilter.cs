using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004DF RID: 1247
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PivotFilter
	{
		// Token: 0x06003427 RID: 13351 RVA: 0x00082D70 File Offset: 0x00080F70
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilter Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilter ct_PivotFilter = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilter();
			if (node.Attributes["fld"] != null)
			{
				ct_PivotFilter.fld = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["fld"]);
			}
			if (node.Attributes["mpFld"] != null)
			{
				ct_PivotFilter.mpFld = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["mpFld"]);
			}
			if (node.Attributes["type"] != null)
			{
				ct_PivotFilter.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_PivotFilterType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PivotFilterType), node.Attributes["type"].Value);
			}
			if (node.Attributes["evalOrder"] != null)
			{
				ct_PivotFilter.evalOrder = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["evalOrder"]);
			}
			if (node.Attributes["id"] != null)
			{
				ct_PivotFilter.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["id"]);
			}
			if (node.Attributes["iMeasureHier"] != null)
			{
				ct_PivotFilter.iMeasureHier = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["iMeasureHier"]);
			}
			if (node.Attributes["iMeasureFld"] != null)
			{
				ct_PivotFilter.iMeasureFld = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["iMeasureFld"]);
			}
			ct_PivotFilter.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_PivotFilter.description = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["description"]);
			ct_PivotFilter.stringValue1 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["stringValue1"]);
			ct_PivotFilter.stringValue2 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["stringValue2"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "autoFilter")
				{
					ct_PivotFilter.autoFilter = global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_PivotFilter.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PivotFilter;
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00082FCC File Offset: 0x000811CC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fld", this.fld, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "mpFld", this.mpFld, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "evalOrder", this.evalOrder);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "iMeasureHier", this.iMeasureHier, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "iMeasureFld", this.iMeasureFld, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "description", this.description);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stringValue1", this.stringValue1);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stringValue2", this.stringValue2);
			sw.Write(">");
			if (this.autoFilter != null)
			{
				this.autoFilter.Write(sw, "autoFilter");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00083106 File Offset: 0x00081306
		public CT_PivotFilter()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.autoFilterField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter();
			this.evalOrderField = 0;
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x0600342A RID: 13354 RVA: 0x0008312B File Offset: 0x0008132B
		// (set) Token: 0x0600342B RID: 13355 RVA: 0x00083133 File Offset: 0x00081333
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter autoFilter
		{
			get
			{
				return this.autoFilterField;
			}
			set
			{
				this.autoFilterField = value;
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x0008313C File Offset: 0x0008133C
		// (set) Token: 0x0600342D RID: 13357 RVA: 0x00083144 File Offset: 0x00081344
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x0008314D File Offset: 0x0008134D
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x00083155 File Offset: 0x00081355
		[global::System.Xml.Serialization.XmlAttribute]
		public uint fld
		{
			get
			{
				return this.fldField;
			}
			set
			{
				this.fldField = value;
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x0008315E File Offset: 0x0008135E
		// (set) Token: 0x06003431 RID: 13361 RVA: 0x00083166 File Offset: 0x00081366
		[global::System.Xml.Serialization.XmlAttribute]
		public uint mpFld
		{
			get
			{
				return this.mpFldField;
			}
			set
			{
				this.mpFldField = value;
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06003432 RID: 13362 RVA: 0x0008316F File Offset: 0x0008136F
		// (set) Token: 0x06003433 RID: 13363 RVA: 0x00083177 File Offset: 0x00081377
		[global::System.Xml.Serialization.XmlIgnore]
		public bool mpFldSpecified
		{
			get
			{
				return this.mpFldFieldSpecified;
			}
			set
			{
				this.mpFldFieldSpecified = value;
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06003434 RID: 13364 RVA: 0x00083180 File Offset: 0x00081380
		// (set) Token: 0x06003435 RID: 13365 RVA: 0x00083188 File Offset: 0x00081388
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_PivotFilterType type
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

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x00083191 File Offset: 0x00081391
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x00083199 File Offset: 0x00081399
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int evalOrder
		{
			get
			{
				return this.evalOrderField;
			}
			set
			{
				this.evalOrderField = value;
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x000831A2 File Offset: 0x000813A2
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x000831AA File Offset: 0x000813AA
		[global::System.Xml.Serialization.XmlAttribute]
		public uint id
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

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x000831B3 File Offset: 0x000813B3
		// (set) Token: 0x0600343B RID: 13371 RVA: 0x000831BB File Offset: 0x000813BB
		[global::System.Xml.Serialization.XmlAttribute]
		public uint iMeasureHier
		{
			get
			{
				return this.iMeasureHierField;
			}
			set
			{
				this.iMeasureHierField = value;
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x0600343C RID: 13372 RVA: 0x000831C4 File Offset: 0x000813C4
		// (set) Token: 0x0600343D RID: 13373 RVA: 0x000831CC File Offset: 0x000813CC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool iMeasureHierSpecified
		{
			get
			{
				return this.iMeasureHierFieldSpecified;
			}
			set
			{
				this.iMeasureHierFieldSpecified = value;
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x000831D5 File Offset: 0x000813D5
		// (set) Token: 0x0600343F RID: 13375 RVA: 0x000831DD File Offset: 0x000813DD
		[global::System.Xml.Serialization.XmlAttribute]
		public uint iMeasureFld
		{
			get
			{
				return this.iMeasureFldField;
			}
			set
			{
				this.iMeasureFldField = value;
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06003440 RID: 13376 RVA: 0x000831E6 File Offset: 0x000813E6
		// (set) Token: 0x06003441 RID: 13377 RVA: 0x000831EE File Offset: 0x000813EE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool iMeasureFldSpecified
		{
			get
			{
				return this.iMeasureFldFieldSpecified;
			}
			set
			{
				this.iMeasureFldFieldSpecified = value;
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06003442 RID: 13378 RVA: 0x000831F7 File Offset: 0x000813F7
		// (set) Token: 0x06003443 RID: 13379 RVA: 0x000831FF File Offset: 0x000813FF
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x00083208 File Offset: 0x00081408
		// (set) Token: 0x06003445 RID: 13381 RVA: 0x00083210 File Offset: 0x00081410
		[global::System.Xml.Serialization.XmlAttribute]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x00083219 File Offset: 0x00081419
		// (set) Token: 0x06003447 RID: 13383 RVA: 0x00083221 File Offset: 0x00081421
		[global::System.Xml.Serialization.XmlAttribute]
		public string stringValue1
		{
			get
			{
				return this.stringValue1Field;
			}
			set
			{
				this.stringValue1Field = value;
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x0008322A File Offset: 0x0008142A
		// (set) Token: 0x06003449 RID: 13385 RVA: 0x00083232 File Offset: 0x00081432
		[global::System.Xml.Serialization.XmlAttribute]
		public string stringValue2
		{
			get
			{
				return this.stringValue2Field;
			}
			set
			{
				this.stringValue2Field = value;
			}
		}

		// Token: 0x0400229C RID: 8860
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter autoFilterField;

		// Token: 0x0400229D RID: 8861
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x0400229E RID: 8862
		private uint fldField;

		// Token: 0x0400229F RID: 8863
		private uint mpFldField;

		// Token: 0x040022A0 RID: 8864
		private bool mpFldFieldSpecified;

		// Token: 0x040022A1 RID: 8865
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_PivotFilterType typeField;

		// Token: 0x040022A2 RID: 8866
		private int evalOrderField;

		// Token: 0x040022A3 RID: 8867
		private uint idField;

		// Token: 0x040022A4 RID: 8868
		private uint iMeasureHierField;

		// Token: 0x040022A5 RID: 8869
		private bool iMeasureHierFieldSpecified;

		// Token: 0x040022A6 RID: 8870
		private uint iMeasureFldField;

		// Token: 0x040022A7 RID: 8871
		private bool iMeasureFldFieldSpecified;

		// Token: 0x040022A8 RID: 8872
		private string nameField;

		// Token: 0x040022A9 RID: 8873
		private string descriptionField;

		// Token: 0x040022AA RID: 8874
		private string stringValue1Field;

		// Token: 0x040022AB RID: 8875
		private string stringValue2Field;
	}
}
