using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200048B RID: 1163
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_CacheField
	{
		// Token: 0x06002EB7 RID: 11959 RVA: 0x00075474 File Offset: 0x00073674
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField ct_CacheField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheField();
			ct_CacheField.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_CacheField.caption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["caption"]);
			ct_CacheField.propertyName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["propertyName"]);
			if (node.Attributes["serverField"] != null)
			{
				ct_CacheField.serverField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["serverField"]);
			}
			if (node.Attributes["uniqueList"] != null)
			{
				ct_CacheField.uniqueList = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["uniqueList"]);
			}
			if (node.Attributes["numFmtId"] != null)
			{
				ct_CacheField.numFmtId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["numFmtId"]);
			}
			ct_CacheField.formula = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["formula"]);
			if (node.Attributes["sqlType"] != null)
			{
				ct_CacheField.sqlType = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["sqlType"]);
			}
			if (node.Attributes["hierarchy"] != null)
			{
				ct_CacheField.hierarchy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["hierarchy"]);
			}
			if (node.Attributes["level"] != null)
			{
				ct_CacheField.level = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["level"]);
			}
			if (node.Attributes["databaseField"] != null)
			{
				ct_CacheField.databaseField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["databaseField"]);
			}
			if (node.Attributes["mappingCount"] != null)
			{
				ct_CacheField.mappingCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["mappingCount"]);
			}
			if (node.Attributes["memberPropertyField"] != null)
			{
				ct_CacheField.memberPropertyField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["memberPropertyField"]);
			}
			ct_CacheField.mpMap = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sharedItems")
				{
					ct_CacheField.sharedItems = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedItems.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fieldGroup")
				{
					ct_CacheField.fieldGroup = global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldGroup.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_CacheField.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mpMap")
				{
					ct_CacheField.mpMap.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_X.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CacheField;
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x0007576C File Offset: 0x0007396C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "caption", this.caption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "propertyName", this.propertyName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "serverField", this.serverField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uniqueList", this.uniqueList);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "numFmtId", this.numFmtId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "formula", this.formula);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sqlType", this.sqlType);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hierarchy", this.hierarchy);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "level", this.level, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "databaseField", this.databaseField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "mappingCount", this.mappingCount, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "memberPropertyField", this.memberPropertyField);
			sw.Write(">");
			if (this.sharedItems != null)
			{
				this.sharedItems.Write(sw, "sharedItems");
			}
			if (this.fieldGroup != null)
			{
				this.fieldGroup.Write(sw, "fieldGroup");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.mpMap != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_X ct_X in this.mpMap)
				{
					ct_X.Write(sw, "mpMap");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x00075924 File Offset: 0x00073B24
		public CT_CacheField()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.mpMapField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			this.fieldGroupField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldGroup();
			this.sharedItemsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedItems();
			this.serverFieldField = false;
			this.uniqueListField = true;
			this.sqlTypeField = 0;
			this.hierarchyField = 0;
			this.levelField = 0U;
			this.databaseFieldField = true;
			this.memberPropertyFieldField = false;
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06002EBA RID: 11962 RVA: 0x00075994 File Offset: 0x00073B94
		// (set) Token: 0x06002EBB RID: 11963 RVA: 0x0007599C File Offset: 0x00073B9C
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedItems sharedItems
		{
			get
			{
				return this.sharedItemsField;
			}
			set
			{
				this.sharedItemsField = value;
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x000759A5 File Offset: 0x00073BA5
		// (set) Token: 0x06002EBD RID: 11965 RVA: 0x000759AD File Offset: 0x00073BAD
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldGroup fieldGroup
		{
			get
			{
				return this.fieldGroupField;
			}
			set
			{
				this.fieldGroupField = value;
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x000759B6 File Offset: 0x00073BB6
		// (set) Token: 0x06002EBF RID: 11967 RVA: 0x000759BE File Offset: 0x00073BBE
		[global::System.Xml.Serialization.XmlElement("mpMap", Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X> mpMap
		{
			get
			{
				return this.mpMapField;
			}
			set
			{
				this.mpMapField = value;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x000759C7 File Offset: 0x00073BC7
		// (set) Token: 0x06002EC1 RID: 11969 RVA: 0x000759CF File Offset: 0x00073BCF
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x000759D8 File Offset: 0x00073BD8
		// (set) Token: 0x06002EC3 RID: 11971 RVA: 0x000759E0 File Offset: 0x00073BE0
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

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x000759E9 File Offset: 0x00073BE9
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x000759F1 File Offset: 0x00073BF1
		[global::System.Xml.Serialization.XmlAttribute]
		public string caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x000759FA File Offset: 0x00073BFA
		// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x00075A02 File Offset: 0x00073C02
		[global::System.Xml.Serialization.XmlAttribute]
		public string propertyName
		{
			get
			{
				return this.propertyNameField;
			}
			set
			{
				this.propertyNameField = value;
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x00075A0B File Offset: 0x00073C0B
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x00075A13 File Offset: 0x00073C13
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool serverField
		{
			get
			{
				return this.serverFieldField;
			}
			set
			{
				this.serverFieldField = value;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x00075A1C File Offset: 0x00073C1C
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x00075A24 File Offset: 0x00073C24
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool uniqueList
		{
			get
			{
				return this.uniqueListField;
			}
			set
			{
				this.uniqueListField = value;
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x00075A2D File Offset: 0x00073C2D
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x00075A35 File Offset: 0x00073C35
		[global::System.Xml.Serialization.XmlAttribute]
		public uint numFmtId
		{
			get
			{
				return this.numFmtIdField;
			}
			set
			{
				this.numFmtIdField = value;
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x00075A3E File Offset: 0x00073C3E
		// (set) Token: 0x06002ECF RID: 11983 RVA: 0x00075A46 File Offset: 0x00073C46
		[global::System.Xml.Serialization.XmlIgnore]
		public bool numFmtIdSpecified
		{
			get
			{
				return this.numFmtIdFieldSpecified;
			}
			set
			{
				this.numFmtIdFieldSpecified = value;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x00075A4F File Offset: 0x00073C4F
		// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x00075A57 File Offset: 0x00073C57
		[global::System.Xml.Serialization.XmlAttribute]
		public string formula
		{
			get
			{
				return this.formulaField;
			}
			set
			{
				this.formulaField = value;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x00075A60 File Offset: 0x00073C60
		// (set) Token: 0x06002ED3 RID: 11987 RVA: 0x00075A68 File Offset: 0x00073C68
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int sqlType
		{
			get
			{
				return this.sqlTypeField;
			}
			set
			{
				this.sqlTypeField = value;
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x00075A71 File Offset: 0x00073C71
		// (set) Token: 0x06002ED5 RID: 11989 RVA: 0x00075A79 File Offset: 0x00073C79
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int hierarchy
		{
			get
			{
				return this.hierarchyField;
			}
			set
			{
				this.hierarchyField = value;
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x00075A82 File Offset: 0x00073C82
		// (set) Token: 0x06002ED7 RID: 11991 RVA: 0x00075A8A File Offset: 0x00073C8A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint level
		{
			get
			{
				return this.levelField;
			}
			set
			{
				this.levelField = value;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06002ED8 RID: 11992 RVA: 0x00075A93 File Offset: 0x00073C93
		// (set) Token: 0x06002ED9 RID: 11993 RVA: 0x00075A9B File Offset: 0x00073C9B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool databaseField
		{
			get
			{
				return this.databaseFieldField;
			}
			set
			{
				this.databaseFieldField = value;
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x00075AA4 File Offset: 0x00073CA4
		// (set) Token: 0x06002EDB RID: 11995 RVA: 0x00075AAC File Offset: 0x00073CAC
		[global::System.Xml.Serialization.XmlAttribute]
		public uint mappingCount
		{
			get
			{
				return this.mappingCountField;
			}
			set
			{
				this.mappingCountField = value;
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x00075AB5 File Offset: 0x00073CB5
		// (set) Token: 0x06002EDD RID: 11997 RVA: 0x00075ABD File Offset: 0x00073CBD
		[global::System.Xml.Serialization.XmlIgnore]
		public bool mappingCountSpecified
		{
			get
			{
				return this.mappingCountFieldSpecified;
			}
			set
			{
				this.mappingCountFieldSpecified = value;
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06002EDE RID: 11998 RVA: 0x00075AC6 File Offset: 0x00073CC6
		// (set) Token: 0x06002EDF RID: 11999 RVA: 0x00075ACE File Offset: 0x00073CCE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool memberPropertyField
		{
			get
			{
				return this.memberPropertyFieldField;
			}
			set
			{
				this.memberPropertyFieldField = value;
			}
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x00075AD7 File Offset: 0x00073CD7
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedItems AddNewSharedItems()
		{
			this.sharedItemsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedItems();
			return this.sharedItemsField;
		}

		// Token: 0x04002026 RID: 8230
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedItems sharedItemsField;

		// Token: 0x04002027 RID: 8231
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldGroup fieldGroupField;

		// Token: 0x04002028 RID: 8232
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X> mpMapField;

		// Token: 0x04002029 RID: 8233
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x0400202A RID: 8234
		private string nameField;

		// Token: 0x0400202B RID: 8235
		private string captionField;

		// Token: 0x0400202C RID: 8236
		private string propertyNameField;

		// Token: 0x0400202D RID: 8237
		private bool serverFieldField;

		// Token: 0x0400202E RID: 8238
		private bool uniqueListField;

		// Token: 0x0400202F RID: 8239
		private uint numFmtIdField;

		// Token: 0x04002030 RID: 8240
		private bool numFmtIdFieldSpecified;

		// Token: 0x04002031 RID: 8241
		private string formulaField;

		// Token: 0x04002032 RID: 8242
		private int sqlTypeField;

		// Token: 0x04002033 RID: 8243
		private int hierarchyField;

		// Token: 0x04002034 RID: 8244
		private uint levelField;

		// Token: 0x04002035 RID: 8245
		private bool databaseFieldField;

		// Token: 0x04002036 RID: 8246
		private uint mappingCountField;

		// Token: 0x04002037 RID: 8247
		private bool mappingCountFieldSpecified;

		// Token: 0x04002038 RID: 8248
		private bool memberPropertyFieldField;
	}
}
