using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000589 RID: 1417
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SheetProtection
	{
		// Token: 0x06003E0D RID: 15885 RVA: 0x00096958 File Offset: 0x00094B58
		public CT_SheetProtection()
		{
			this.formatCellsField = true;
			this.formatColumnsField = true;
			this.formatRowsField = true;
			this.insertColumnsField = true;
			this.insertRowsField = true;
			this.insertHyperlinksField = true;
			this.deleteColumnsField = true;
			this.deleteRowsField = true;
			this.selectLockedCellsField = false;
			this.sortField = true;
			this.autoFilterField = true;
			this.pivotTablesField = true;
			this.selectUnlockedCellsField = false;
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06003E0E RID: 15886 RVA: 0x000969C6 File Offset: 0x00094BC6
		// (set) Token: 0x06003E0F RID: 15887 RVA: 0x000969CE File Offset: 0x00094BCE
		public string algorithmName { get; set; }

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x000969D7 File Offset: 0x00094BD7
		// (set) Token: 0x06003E11 RID: 15889 RVA: 0x000969DF File Offset: 0x00094BDF
		public string hashValue { get; set; }

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x000969E8 File Offset: 0x00094BE8
		// (set) Token: 0x06003E13 RID: 15891 RVA: 0x000969F0 File Offset: 0x00094BF0
		public string saltValue { get; set; }

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x000969F9 File Offset: 0x00094BF9
		// (set) Token: 0x06003E15 RID: 15893 RVA: 0x00096A01 File Offset: 0x00094C01
		public string spinCount { get; set; }

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06003E16 RID: 15894 RVA: 0x00096A0A File Offset: 0x00094C0A
		// (set) Token: 0x06003E17 RID: 15895 RVA: 0x00096A12 File Offset: 0x00094C12
		[global::System.Xml.Serialization.XmlAttribute]
		public string password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x00096A1B File Offset: 0x00094C1B
		// (set) Token: 0x06003E19 RID: 15897 RVA: 0x00096A23 File Offset: 0x00094C23
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool sheet
		{
			get
			{
				return this.sheetField;
			}
			set
			{
				this.sheetField = value;
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x00096A2C File Offset: 0x00094C2C
		// (set) Token: 0x06003E1B RID: 15899 RVA: 0x00096A34 File Offset: 0x00094C34
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool objects
		{
			get
			{
				return this.objectsField;
			}
			set
			{
				this.objectsField = value;
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06003E1C RID: 15900 RVA: 0x00096A3D File Offset: 0x00094C3D
		// (set) Token: 0x06003E1D RID: 15901 RVA: 0x00096A45 File Offset: 0x00094C45
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool scenarios
		{
			get
			{
				return this.scenariosField;
			}
			set
			{
				this.scenariosField = value;
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x00096A4E File Offset: 0x00094C4E
		// (set) Token: 0x06003E1F RID: 15903 RVA: 0x00096A56 File Offset: 0x00094C56
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool formatCells
		{
			get
			{
				return this.formatCellsField;
			}
			set
			{
				this.formatCellsField = value;
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x00096A5F File Offset: 0x00094C5F
		// (set) Token: 0x06003E21 RID: 15905 RVA: 0x00096A67 File Offset: 0x00094C67
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool formatColumns
		{
			get
			{
				return this.formatColumnsField;
			}
			set
			{
				this.formatColumnsField = value;
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x00096A70 File Offset: 0x00094C70
		// (set) Token: 0x06003E23 RID: 15907 RVA: 0x00096A78 File Offset: 0x00094C78
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool formatRows
		{
			get
			{
				return this.formatRowsField;
			}
			set
			{
				this.formatRowsField = value;
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x00096A81 File Offset: 0x00094C81
		// (set) Token: 0x06003E25 RID: 15909 RVA: 0x00096A89 File Offset: 0x00094C89
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool insertColumns
		{
			get
			{
				return this.insertColumnsField;
			}
			set
			{
				this.insertColumnsField = value;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x00096A92 File Offset: 0x00094C92
		// (set) Token: 0x06003E27 RID: 15911 RVA: 0x00096A9A File Offset: 0x00094C9A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool insertRows
		{
			get
			{
				return this.insertRowsField;
			}
			set
			{
				this.insertRowsField = value;
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06003E28 RID: 15912 RVA: 0x00096AA3 File Offset: 0x00094CA3
		// (set) Token: 0x06003E29 RID: 15913 RVA: 0x00096AAB File Offset: 0x00094CAB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool insertHyperlinks
		{
			get
			{
				return this.insertHyperlinksField;
			}
			set
			{
				this.insertHyperlinksField = value;
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06003E2A RID: 15914 RVA: 0x00096AB4 File Offset: 0x00094CB4
		// (set) Token: 0x06003E2B RID: 15915 RVA: 0x00096ABC File Offset: 0x00094CBC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool deleteColumns
		{
			get
			{
				return this.deleteColumnsField;
			}
			set
			{
				this.deleteColumnsField = value;
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06003E2C RID: 15916 RVA: 0x00096AC5 File Offset: 0x00094CC5
		// (set) Token: 0x06003E2D RID: 15917 RVA: 0x00096ACD File Offset: 0x00094CCD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool deleteRows
		{
			get
			{
				return this.deleteRowsField;
			}
			set
			{
				this.deleteRowsField = value;
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06003E2E RID: 15918 RVA: 0x00096AD6 File Offset: 0x00094CD6
		// (set) Token: 0x06003E2F RID: 15919 RVA: 0x00096ADE File Offset: 0x00094CDE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool selectLockedCells
		{
			get
			{
				return this.selectLockedCellsField;
			}
			set
			{
				this.selectLockedCellsField = value;
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06003E30 RID: 15920 RVA: 0x00096AE7 File Offset: 0x00094CE7
		// (set) Token: 0x06003E31 RID: 15921 RVA: 0x00096AEF File Offset: 0x00094CEF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool sort
		{
			get
			{
				return this.sortField;
			}
			set
			{
				this.sortField = value;
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06003E32 RID: 15922 RVA: 0x00096AF8 File Offset: 0x00094CF8
		// (set) Token: 0x06003E33 RID: 15923 RVA: 0x00096B00 File Offset: 0x00094D00
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool autoFilter
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

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06003E34 RID: 15924 RVA: 0x00096B09 File Offset: 0x00094D09
		// (set) Token: 0x06003E35 RID: 15925 RVA: 0x00096B11 File Offset: 0x00094D11
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool pivotTables
		{
			get
			{
				return this.pivotTablesField;
			}
			set
			{
				this.pivotTablesField = value;
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06003E36 RID: 15926 RVA: 0x00096B1A File Offset: 0x00094D1A
		// (set) Token: 0x06003E37 RID: 15927 RVA: 0x00096B22 File Offset: 0x00094D22
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool selectUnlockedCells
		{
			get
			{
				return this.selectUnlockedCellsField;
			}
			set
			{
				this.selectUnlockedCellsField = value;
			}
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x00096B2C File Offset: 0x00094D2C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection ct_SheetProtection = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection();
			ct_SheetProtection.password = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["password"]);
			ct_SheetProtection.sheet = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["sheet"]);
			ct_SheetProtection.objects = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["objects"]);
			ct_SheetProtection.scenarios = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["scenarios"]);
			ct_SheetProtection.formatCells = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["formatCells"], true);
			ct_SheetProtection.formatColumns = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["formatColumns"], true);
			ct_SheetProtection.formatRows = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["formatRows"], true);
			ct_SheetProtection.insertColumns = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["insertColumns"], true);
			ct_SheetProtection.insertRows = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["insertRows"], true);
			ct_SheetProtection.insertHyperlinks = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["insertHyperlinks"], true);
			ct_SheetProtection.deleteColumns = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["deleteColumns"], true);
			ct_SheetProtection.deleteRows = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["deleteRows"], true);
			ct_SheetProtection.selectLockedCells = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["selectLockedCells"]);
			ct_SheetProtection.sort = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["sort"], true);
			ct_SheetProtection.autoFilter = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoFilter"], true);
			ct_SheetProtection.pivotTables = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["pivotTables"], true);
			ct_SheetProtection.selectUnlockedCells = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["selectUnlockedCells"]);
			ct_SheetProtection.algorithmName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["algorithmName"]);
			if (ct_SheetProtection.algorithmName != null)
			{
				ct_SheetProtection.hashValue = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["hashValue"]);
				ct_SheetProtection.saltValue = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["saltValue"]);
				ct_SheetProtection.spinCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["spinCount"]);
			}
			return ct_SheetProtection;
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x00096D8F File Offset: 0x00094F8F
		internal bool IsSetObjects()
		{
			return this.objects;
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x00096D97 File Offset: 0x00094F97
		internal bool IsSetScenarios()
		{
			return this.scenarios;
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x00096D9F File Offset: 0x00094F9F
		internal bool IsSetSheet()
		{
			return this.sheet;
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x00096DA8 File Offset: 0x00094FA8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.algorithmName != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "algorithmName", this.algorithmName);
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hashValue", this.hashValue);
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "saltValue", this.saltValue);
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "spinCount", this.spinCount);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "password", this.password);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sheet", this.sheet);
			if (this.objects)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "objects", this.objects);
			}
			if (this.scenarios)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "scenarios", this.scenarios);
			}
			if (!this.formatCells)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "formatCells", this.formatCells);
			}
			if (!this.formatColumns)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "formatColumns", this.formatColumns);
			}
			if (!this.formatRows)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "formatRows", this.formatRows);
			}
			if (!this.insertColumns)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "insertColumns", this.insertColumns);
			}
			if (!this.insertRows)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "insertRows", this.insertRows);
			}
			if (!this.insertHyperlinks)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "insertHyperlinks", this.insertHyperlinks);
			}
			if (!this.deleteColumns)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "deleteColumns", this.deleteColumns);
			}
			if (!this.deleteRows)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "deleteRows", this.deleteRows);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "selectLockedCells", this.selectLockedCells, false);
			if (!this.sort)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sort", this.sort);
			}
			if (!this.autoFilter)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoFilter", this.autoFilter);
			}
			if (!this.pivotTables)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pivotTables", this.pivotTables);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "selectUnlockedCells", this.selectUnlockedCells, false);
			sw.Write("/>");
		}

		// Token: 0x0400277F RID: 10111
		private string passwordField;

		// Token: 0x04002780 RID: 10112
		private bool sheetField;

		// Token: 0x04002781 RID: 10113
		private bool objectsField;

		// Token: 0x04002782 RID: 10114
		private bool scenariosField;

		// Token: 0x04002783 RID: 10115
		private bool formatCellsField;

		// Token: 0x04002784 RID: 10116
		private bool formatColumnsField;

		// Token: 0x04002785 RID: 10117
		private bool formatRowsField;

		// Token: 0x04002786 RID: 10118
		private bool insertColumnsField;

		// Token: 0x04002787 RID: 10119
		private bool insertRowsField;

		// Token: 0x04002788 RID: 10120
		private bool insertHyperlinksField;

		// Token: 0x04002789 RID: 10121
		private bool deleteColumnsField;

		// Token: 0x0400278A RID: 10122
		private bool deleteRowsField;

		// Token: 0x0400278B RID: 10123
		private bool selectLockedCellsField;

		// Token: 0x0400278C RID: 10124
		private bool sortField;

		// Token: 0x0400278D RID: 10125
		private bool autoFilterField;

		// Token: 0x0400278E RID: 10126
		private bool pivotTablesField;

		// Token: 0x0400278F RID: 10127
		private bool selectUnlockedCellsField;
	}
}
