using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200047F RID: 1151
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("pivotCacheDefinition", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public class CT_PivotCacheDefinition
	{
		// Token: 0x06002DD8 RID: 11736 RVA: 0x00073220 File Offset: 0x00071420
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheDefinition Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheDefinition ct_PivotCacheDefinition = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheDefinition();
			ct_PivotCacheDefinition.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			if (node.Attributes["invalid"] != null)
			{
				ct_PivotCacheDefinition.invalid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["invalid"]);
			}
			if (node.Attributes["saveData"] != null)
			{
				ct_PivotCacheDefinition.saveData = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["saveData"]);
			}
			if (node.Attributes["refreshOnLoad"] != null)
			{
				ct_PivotCacheDefinition.refreshOnLoad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["refreshOnLoad"]);
			}
			if (node.Attributes["optimizeMemory"] != null)
			{
				ct_PivotCacheDefinition.optimizeMemory = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["optimizeMemory"]);
			}
			if (node.Attributes["enableRefresh"] != null)
			{
				ct_PivotCacheDefinition.enableRefresh = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["enableRefresh"]);
			}
			ct_PivotCacheDefinition.refreshedBy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["refreshedBy"]);
			if (node.Attributes["refreshedDate"] != null)
			{
				ct_PivotCacheDefinition.refreshedDate = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["refreshedDate"]);
			}
			if (node.Attributes["refreshedDateIso"] != null && node.Attributes["backgroundQuery"] != null)
			{
				ct_PivotCacheDefinition.backgroundQuery = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["backgroundQuery"]);
			}
			if (node.Attributes["missingItemsLimit"] != null)
			{
				ct_PivotCacheDefinition.missingItemsLimit = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["missingItemsLimit"]);
			}
			if (node.Attributes["createdVersion"] != null)
			{
				ct_PivotCacheDefinition.createdVersion = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["createdVersion"]);
			}
			if (node.Attributes["refreshedVersion"] != null)
			{
				ct_PivotCacheDefinition.refreshedVersion = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["refreshedVersion"]);
			}
			if (node.Attributes["minRefreshableVersion"] != null)
			{
				ct_PivotCacheDefinition.minRefreshableVersion = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["minRefreshableVersion"]);
			}
			if (node.Attributes["recordCount"] != null)
			{
				ct_PivotCacheDefinition.recordCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["recordCount"]);
			}
			if (node.Attributes["upgradeOnRefresh"] != null)
			{
				ct_PivotCacheDefinition.upgradeOnRefresh = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["upgradeOnRefresh"]);
			}
			if (node.Attributes["tupleCache1"] != null)
			{
				ct_PivotCacheDefinition.tupleCache1 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["tupleCache1"]);
			}
			if (node.Attributes["supportSubquery"] != null)
			{
				ct_PivotCacheDefinition.supportSubquery = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["supportSubquery"]);
			}
			if (node.Attributes["supportAdvancedDrill"] != null)
			{
				ct_PivotCacheDefinition.supportAdvancedDrill = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["supportAdvancedDrill"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cacheSource")
				{
					ct_PivotCacheDefinition.cacheSource = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cacheFields")
				{
					ct_PivotCacheDefinition.cacheFields = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheFields.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cacheHierarchies")
				{
					ct_PivotCacheDefinition.cacheHierarchies = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchies.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "kpis")
				{
					ct_PivotCacheDefinition.kpis = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPIs.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tupleCache")
				{
					ct_PivotCacheDefinition.tupleCache = global::NPOI.OpenXmlFormats.Spreadsheet.CT_TupleCache.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "calculatedItems")
				{
					ct_PivotCacheDefinition.calculatedItems = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItems.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "calculatedMembers")
				{
					ct_PivotCacheDefinition.calculatedMembers = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMembers.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dimensions")
				{
					ct_PivotCacheDefinition.dimensions = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dimensions.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "measureGroups")
				{
					ct_PivotCacheDefinition.measureGroups = global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroups.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "maps")
				{
					ct_PivotCacheDefinition.maps = global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMaps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_PivotCacheDefinition.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PivotCacheDefinition;
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00073728 File Offset: 0x00071928
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<pivotCacheDefinition xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" ");
			sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" ");
			sw.Write("xmlns:s=\"http://schemas.openxmlformats.org/officeDocument/2006/sharedTypes\" ");
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "invalid", this.invalid);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "saveData", this.saveData);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "refreshOnLoad", this.refreshOnLoad);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "optimizeMemory", this.optimizeMemory);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "enableRefresh", this.enableRefresh);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "refreshedBy", this.refreshedBy);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "refreshedDate", this.refreshedDate);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "refreshedDateIso", this.refreshedDateIso);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "backgroundQuery", this.backgroundQuery);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "missingItemsLimit", this.missingItemsLimit, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "createdVersion", (int)this.createdVersion);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "refreshedVersion", (int)this.refreshedVersion);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "minRefreshableVersion", (int)this.minRefreshableVersion);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "recordCount", this.recordCount, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "upgradeOnRefresh", this.upgradeOnRefresh);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tupleCache1", this.tupleCache1);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "supportSubquery", this.supportSubquery);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "supportAdvancedDrill", this.supportAdvancedDrill);
			sw.Write(">");
			if (this.cacheSource != null)
			{
				this.cacheSource.Write(sw, "cacheSource");
			}
			if (this.cacheFields != null)
			{
				this.cacheFields.Write(sw, "cacheFields");
			}
			if (this.cacheHierarchies != null)
			{
				this.cacheHierarchies.Write(sw, "cacheHierarchies");
			}
			if (this.kpis != null)
			{
				this.kpis.Write(sw, "kpis");
			}
			if (this.tupleCache != null)
			{
				this.tupleCache.Write(sw, "tupleCache");
			}
			if (this.calculatedItems != null)
			{
				this.calculatedItems.Write(sw, "calculatedItems");
			}
			if (this.calculatedMembers != null)
			{
				this.calculatedMembers.Write(sw, "calculatedMembers");
			}
			if (this.dimensions != null)
			{
				this.dimensions.Write(sw, "dimensions");
			}
			if (this.measureGroups != null)
			{
				this.measureGroups.Write(sw, "measureGroups");
			}
			if (this.maps != null)
			{
				this.maps.Write(sw, "maps");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</pivotCacheDefinition>", new object[0]));
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x000739DC File Offset: 0x00071BDC
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.Write(streamWriter);
			}
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00073A14 File Offset: 0x00071C14
		public CT_PivotCacheDefinition()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.mapsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMaps();
			this.measureGroupsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroups();
			this.dimensionsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dimensions();
			this.calculatedMembersField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMembers();
			this.calculatedItemsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItems();
			this.tupleCacheField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TupleCache();
			this.kpisField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPIs();
			this.cacheHierarchiesField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchies();
			this.cacheFieldsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheFields();
			this.cacheSourceField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheSource();
			this.invalidField = false;
			this.saveDataField = true;
			this.refreshOnLoadField = false;
			this.optimizeMemoryField = false;
			this.enableRefreshField = true;
			this.backgroundQueryField = false;
			this.createdVersionField = 0;
			this.refreshedVersionField = 0;
			this.minRefreshableVersionField = 0;
			this.upgradeOnRefreshField = false;
			this.tupleCache1Field = false;
			this.supportSubqueryField = false;
			this.supportAdvancedDrillField = false;
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x00073AFB File Offset: 0x00071CFB
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x00073B03 File Offset: 0x00071D03
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheSource cacheSource
		{
			get
			{
				return this.cacheSourceField;
			}
			set
			{
				this.cacheSourceField = value;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x00073B0C File Offset: 0x00071D0C
		// (set) Token: 0x06002DDF RID: 11743 RVA: 0x00073B14 File Offset: 0x00071D14
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheFields cacheFields
		{
			get
			{
				return this.cacheFieldsField;
			}
			set
			{
				this.cacheFieldsField = value;
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06002DE0 RID: 11744 RVA: 0x00073B1D File Offset: 0x00071D1D
		// (set) Token: 0x06002DE1 RID: 11745 RVA: 0x00073B25 File Offset: 0x00071D25
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchies cacheHierarchies
		{
			get
			{
				return this.cacheHierarchiesField;
			}
			set
			{
				this.cacheHierarchiesField = value;
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x00073B2E File Offset: 0x00071D2E
		// (set) Token: 0x06002DE3 RID: 11747 RVA: 0x00073B36 File Offset: 0x00071D36
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPIs kpis
		{
			get
			{
				return this.kpisField;
			}
			set
			{
				this.kpisField = value;
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06002DE4 RID: 11748 RVA: 0x00073B3F File Offset: 0x00071D3F
		// (set) Token: 0x06002DE5 RID: 11749 RVA: 0x00073B47 File Offset: 0x00071D47
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_TupleCache tupleCache
		{
			get
			{
				return this.tupleCacheField;
			}
			set
			{
				this.tupleCacheField = value;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06002DE6 RID: 11750 RVA: 0x00073B50 File Offset: 0x00071D50
		// (set) Token: 0x06002DE7 RID: 11751 RVA: 0x00073B58 File Offset: 0x00071D58
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItems calculatedItems
		{
			get
			{
				return this.calculatedItemsField;
			}
			set
			{
				this.calculatedItemsField = value;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x00073B61 File Offset: 0x00071D61
		// (set) Token: 0x06002DE9 RID: 11753 RVA: 0x00073B69 File Offset: 0x00071D69
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMembers calculatedMembers
		{
			get
			{
				return this.calculatedMembersField;
			}
			set
			{
				this.calculatedMembersField = value;
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06002DEA RID: 11754 RVA: 0x00073B72 File Offset: 0x00071D72
		// (set) Token: 0x06002DEB RID: 11755 RVA: 0x00073B7A File Offset: 0x00071D7A
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dimensions dimensions
		{
			get
			{
				return this.dimensionsField;
			}
			set
			{
				this.dimensionsField = value;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x00073B83 File Offset: 0x00071D83
		// (set) Token: 0x06002DED RID: 11757 RVA: 0x00073B8B File Offset: 0x00071D8B
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroups measureGroups
		{
			get
			{
				return this.measureGroupsField;
			}
			set
			{
				this.measureGroupsField = value;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06002DEE RID: 11758 RVA: 0x00073B94 File Offset: 0x00071D94
		// (set) Token: 0x06002DEF RID: 11759 RVA: 0x00073B9C File Offset: 0x00071D9C
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMaps maps
		{
			get
			{
				return this.mapsField;
			}
			set
			{
				this.mapsField = value;
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x00073BA5 File Offset: 0x00071DA5
		// (set) Token: 0x06002DF1 RID: 11761 RVA: 0x00073BAD File Offset: 0x00071DAD
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
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

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x00073BB6 File Offset: 0x00071DB6
		// (set) Token: 0x06002DF3 RID: 11763 RVA: 0x00073BBE File Offset: 0x00071DBE
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

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x00073BC7 File Offset: 0x00071DC7
		// (set) Token: 0x06002DF5 RID: 11765 RVA: 0x00073BCF File Offset: 0x00071DCF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool invalid
		{
			get
			{
				return this.invalidField;
			}
			set
			{
				this.invalidField = value;
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x00073BD8 File Offset: 0x00071DD8
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x00073BE0 File Offset: 0x00071DE0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool saveData
		{
			get
			{
				return this.saveDataField;
			}
			set
			{
				this.saveDataField = value;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x00073BE9 File Offset: 0x00071DE9
		// (set) Token: 0x06002DF9 RID: 11769 RVA: 0x00073BF1 File Offset: 0x00071DF1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool refreshOnLoad
		{
			get
			{
				return this.refreshOnLoadField;
			}
			set
			{
				this.refreshOnLoadField = value;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x00073BFA File Offset: 0x00071DFA
		// (set) Token: 0x06002DFB RID: 11771 RVA: 0x00073C02 File Offset: 0x00071E02
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool optimizeMemory
		{
			get
			{
				return this.optimizeMemoryField;
			}
			set
			{
				this.optimizeMemoryField = value;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x00073C0B File Offset: 0x00071E0B
		// (set) Token: 0x06002DFD RID: 11773 RVA: 0x00073C13 File Offset: 0x00071E13
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool enableRefresh
		{
			get
			{
				return this.enableRefreshField;
			}
			set
			{
				this.enableRefreshField = value;
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x00073C1C File Offset: 0x00071E1C
		// (set) Token: 0x06002DFF RID: 11775 RVA: 0x00073C24 File Offset: 0x00071E24
		[global::System.Xml.Serialization.XmlAttribute]
		public string refreshedBy
		{
			get
			{
				return this.refreshedByField;
			}
			set
			{
				this.refreshedByField = value;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x00073C2D File Offset: 0x00071E2D
		// (set) Token: 0x06002E01 RID: 11777 RVA: 0x00073C35 File Offset: 0x00071E35
		[global::System.Xml.Serialization.XmlAttribute]
		public double refreshedDate
		{
			get
			{
				return this.refreshedDateField;
			}
			set
			{
				this.refreshedDateField = value;
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x00073C3E File Offset: 0x00071E3E
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x00073C46 File Offset: 0x00071E46
		[global::System.Xml.Serialization.XmlIgnore]
		public bool refreshedDateSpecified
		{
			get
			{
				return this.refreshedDateFieldSpecified;
			}
			set
			{
				this.refreshedDateFieldSpecified = value;
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x00073C4F File Offset: 0x00071E4F
		// (set) Token: 0x06002E05 RID: 11781 RVA: 0x00073C57 File Offset: 0x00071E57
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.DateTime? refreshedDateIso
		{
			get
			{
				return this.refreshedDateIsoField;
			}
			set
			{
				this.refreshedDateIsoField = value;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x00073C60 File Offset: 0x00071E60
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x00073C68 File Offset: 0x00071E68
		[global::System.Xml.Serialization.XmlIgnore]
		public bool refreshedDateIsoSpecified
		{
			get
			{
				return this.refreshedDateIsoFieldSpecified;
			}
			set
			{
				this.refreshedDateIsoFieldSpecified = value;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x00073C71 File Offset: 0x00071E71
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x00073C79 File Offset: 0x00071E79
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool backgroundQuery
		{
			get
			{
				return this.backgroundQueryField;
			}
			set
			{
				this.backgroundQueryField = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06002E0A RID: 11786 RVA: 0x00073C82 File Offset: 0x00071E82
		// (set) Token: 0x06002E0B RID: 11787 RVA: 0x00073C8A File Offset: 0x00071E8A
		[global::System.Xml.Serialization.XmlAttribute]
		public uint missingItemsLimit
		{
			get
			{
				return this.missingItemsLimitField;
			}
			set
			{
				this.missingItemsLimitField = value;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06002E0C RID: 11788 RVA: 0x00073C93 File Offset: 0x00071E93
		// (set) Token: 0x06002E0D RID: 11789 RVA: 0x00073C9B File Offset: 0x00071E9B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool missingItemsLimitSpecified
		{
			get
			{
				return this.missingItemsLimitFieldSpecified;
			}
			set
			{
				this.missingItemsLimitFieldSpecified = value;
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x00073CA4 File Offset: 0x00071EA4
		// (set) Token: 0x06002E0F RID: 11791 RVA: 0x00073CAC File Offset: 0x00071EAC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		public byte createdVersion
		{
			get
			{
				return this.createdVersionField;
			}
			set
			{
				this.createdVersionField = value;
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x00073CB5 File Offset: 0x00071EB5
		// (set) Token: 0x06002E11 RID: 11793 RVA: 0x00073CBD File Offset: 0x00071EBD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		public byte refreshedVersion
		{
			get
			{
				return this.refreshedVersionField;
			}
			set
			{
				this.refreshedVersionField = value;
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x00073CC6 File Offset: 0x00071EC6
		// (set) Token: 0x06002E13 RID: 11795 RVA: 0x00073CCE File Offset: 0x00071ECE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		public byte minRefreshableVersion
		{
			get
			{
				return this.minRefreshableVersionField;
			}
			set
			{
				this.minRefreshableVersionField = value;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x00073CD7 File Offset: 0x00071ED7
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x00073CDF File Offset: 0x00071EDF
		[global::System.Xml.Serialization.XmlAttribute]
		public uint recordCount
		{
			get
			{
				return this.recordCountField;
			}
			set
			{
				this.recordCountField = value;
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x00073CE8 File Offset: 0x00071EE8
		// (set) Token: 0x06002E17 RID: 11799 RVA: 0x00073CF0 File Offset: 0x00071EF0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool recordCountSpecified
		{
			get
			{
				return this.recordCountFieldSpecified;
			}
			set
			{
				this.recordCountFieldSpecified = value;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x00073CF9 File Offset: 0x00071EF9
		// (set) Token: 0x06002E19 RID: 11801 RVA: 0x00073D01 File Offset: 0x00071F01
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool upgradeOnRefresh
		{
			get
			{
				return this.upgradeOnRefreshField;
			}
			set
			{
				this.upgradeOnRefreshField = value;
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x00073D0A File Offset: 0x00071F0A
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x00073D12 File Offset: 0x00071F12
		[global::System.Xml.Serialization.XmlAttribute("tupleCache")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool tupleCache1
		{
			get
			{
				return this.tupleCache1Field;
			}
			set
			{
				this.tupleCache1Field = value;
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x00073D1B File Offset: 0x00071F1B
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x00073D23 File Offset: 0x00071F23
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool supportSubquery
		{
			get
			{
				return this.supportSubqueryField;
			}
			set
			{
				this.supportSubqueryField = value;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x00073D2C File Offset: 0x00071F2C
		// (set) Token: 0x06002E1F RID: 11807 RVA: 0x00073D34 File Offset: 0x00071F34
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool supportAdvancedDrill
		{
			get
			{
				return this.supportAdvancedDrillField;
			}
			set
			{
				this.supportAdvancedDrillField = value;
			}
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00073D3D File Offset: 0x00071F3D
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheFields AddNewCacheFields()
		{
			this.cacheFieldsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheFields();
			return this.cacheFieldsField;
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00073D50 File Offset: 0x00071F50
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheSource AddNewCacheSource()
		{
			this.cacheSourceField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheSource();
			return this.cacheSourceField;
		}

		// Token: 0x04001FC5 RID: 8133
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheSource cacheSourceField;

		// Token: 0x04001FC6 RID: 8134
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheFields cacheFieldsField;

		// Token: 0x04001FC7 RID: 8135
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchies cacheHierarchiesField;

		// Token: 0x04001FC8 RID: 8136
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPIs kpisField;

		// Token: 0x04001FC9 RID: 8137
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_TupleCache tupleCacheField;

		// Token: 0x04001FCA RID: 8138
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItems calculatedItemsField;

		// Token: 0x04001FCB RID: 8139
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMembers calculatedMembersField;

		// Token: 0x04001FCC RID: 8140
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dimensions dimensionsField;

		// Token: 0x04001FCD RID: 8141
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroups measureGroupsField;

		// Token: 0x04001FCE RID: 8142
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMaps mapsField;

		// Token: 0x04001FCF RID: 8143
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04001FD0 RID: 8144
		private string idField;

		// Token: 0x04001FD1 RID: 8145
		private bool invalidField;

		// Token: 0x04001FD2 RID: 8146
		private bool saveDataField;

		// Token: 0x04001FD3 RID: 8147
		private bool refreshOnLoadField;

		// Token: 0x04001FD4 RID: 8148
		private bool optimizeMemoryField;

		// Token: 0x04001FD5 RID: 8149
		private bool enableRefreshField;

		// Token: 0x04001FD6 RID: 8150
		private string refreshedByField;

		// Token: 0x04001FD7 RID: 8151
		private double refreshedDateField;

		// Token: 0x04001FD8 RID: 8152
		private bool refreshedDateFieldSpecified;

		// Token: 0x04001FD9 RID: 8153
		private global::System.DateTime? refreshedDateIsoField;

		// Token: 0x04001FDA RID: 8154
		private bool refreshedDateIsoFieldSpecified;

		// Token: 0x04001FDB RID: 8155
		private bool backgroundQueryField;

		// Token: 0x04001FDC RID: 8156
		private uint missingItemsLimitField;

		// Token: 0x04001FDD RID: 8157
		private bool missingItemsLimitFieldSpecified;

		// Token: 0x04001FDE RID: 8158
		private byte createdVersionField;

		// Token: 0x04001FDF RID: 8159
		private byte refreshedVersionField;

		// Token: 0x04001FE0 RID: 8160
		private byte minRefreshableVersionField;

		// Token: 0x04001FE1 RID: 8161
		private uint recordCountField;

		// Token: 0x04001FE2 RID: 8162
		private bool recordCountFieldSpecified;

		// Token: 0x04001FE3 RID: 8163
		private bool upgradeOnRefreshField;

		// Token: 0x04001FE4 RID: 8164
		private bool tupleCache1Field;

		// Token: 0x04001FE5 RID: 8165
		private bool supportSubqueryField;

		// Token: 0x04001FE6 RID: 8166
		private bool supportAdvancedDrillField;
	}
}
