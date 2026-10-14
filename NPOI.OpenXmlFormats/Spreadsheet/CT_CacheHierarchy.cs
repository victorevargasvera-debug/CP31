using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004A3 RID: 1187
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_CacheHierarchy
	{
		// Token: 0x06003057 RID: 12375 RVA: 0x00079358 File Offset: 0x00077558
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchy Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchy ct_CacheHierarchy = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CacheHierarchy();
			ct_CacheHierarchy.uniqueName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uniqueName"]);
			ct_CacheHierarchy.caption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["caption"]);
			if (node.Attributes["measure"] != null)
			{
				ct_CacheHierarchy.measure = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["measure"]);
			}
			if (node.Attributes["set"] != null)
			{
				ct_CacheHierarchy.set = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["set"]);
			}
			if (node.Attributes["parentSet"] != null)
			{
				ct_CacheHierarchy.parentSet = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["parentSet"]);
			}
			if (node.Attributes["iconSet"] != null)
			{
				ct_CacheHierarchy.iconSet = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["iconSet"]);
			}
			if (node.Attributes["attribute"] != null)
			{
				ct_CacheHierarchy.attribute = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["attribute"]);
			}
			if (node.Attributes["time"] != null)
			{
				ct_CacheHierarchy.time = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["time"]);
			}
			if (node.Attributes["keyAttribute"] != null)
			{
				ct_CacheHierarchy.keyAttribute = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["keyAttribute"]);
			}
			ct_CacheHierarchy.defaultMemberUniqueName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["defaultMemberUniqueName"]);
			ct_CacheHierarchy.allUniqueName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["allUniqueName"]);
			ct_CacheHierarchy.allCaption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["allCaption"]);
			ct_CacheHierarchy.dimensionUniqueName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["dimensionUniqueName"]);
			ct_CacheHierarchy.displayFolder = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["displayFolder"]);
			ct_CacheHierarchy.measureGroup = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["measureGroup"]);
			if (node.Attributes["measures"] != null)
			{
				ct_CacheHierarchy.measures = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["measures"]);
			}
			if (node.Attributes["count"] != null)
			{
				ct_CacheHierarchy.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			if (node.Attributes["oneField"] != null)
			{
				ct_CacheHierarchy.oneField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["oneField"]);
			}
			if (node.Attributes["memberValueDatatype"] != null)
			{
				ct_CacheHierarchy.memberValueDatatype = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUShort(node.Attributes["memberValueDatatype"]);
			}
			if (node.Attributes["unbalanced"] != null)
			{
				ct_CacheHierarchy.unbalanced = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["unbalanced"]);
			}
			if (node.Attributes["unbalancedGroup"] != null)
			{
				ct_CacheHierarchy.unbalancedGroup = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["unbalancedGroup"]);
			}
			if (node.Attributes["hidden"] != null)
			{
				ct_CacheHierarchy.hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "fieldsUsage")
				{
					ct_CacheHierarchy.fieldsUsage = global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldsUsage.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "groupLevels")
				{
					ct_CacheHierarchy.groupLevels = global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevels.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_CacheHierarchy.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CacheHierarchy;
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x00079768 File Offset: 0x00077968
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "caption", this.caption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "measure", this.measure);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "set", this.set);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "parentSet", this.parentSet, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "iconSet", this.iconSet);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "attribute", this.attribute);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "time", this.time);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "keyAttribute", this.keyAttribute);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defaultMemberUniqueName", this.defaultMemberUniqueName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "allUniqueName", this.allUniqueName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "allCaption", this.allCaption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dimensionUniqueName", this.dimensionUniqueName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "displayFolder", this.displayFolder);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "measureGroup", this.measureGroup);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "measures", this.measures);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "oneField", this.oneField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "memberValueDatatype", (int)this.memberValueDatatype);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "unbalanced", this.unbalanced);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "unbalancedGroup", this.unbalancedGroup);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden);
			sw.Write(">");
			if (this.fieldsUsage != null)
			{
				this.fieldsUsage.Write(sw, "fieldsUsage");
			}
			if (this.groupLevels != null)
			{
				this.groupLevels.Write(sw, "groupLevels");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x00079968 File Offset: 0x00077B68
		public CT_CacheHierarchy()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.groupLevelsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevels();
			this.fieldsUsageField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldsUsage();
			this.measureField = false;
			this.setField = false;
			this.iconSetField = 0;
			this.attributeField = false;
			this.timeField = false;
			this.keyAttributeField = false;
			this.measuresField = false;
			this.oneFieldField = false;
			this.hiddenField = false;
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x000799DB File Offset: 0x00077BDB
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x000799E3 File Offset: 0x00077BE3
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldsUsage fieldsUsage
		{
			get
			{
				return this.fieldsUsageField;
			}
			set
			{
				this.fieldsUsageField = value;
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x000799EC File Offset: 0x00077BEC
		// (set) Token: 0x0600305D RID: 12381 RVA: 0x000799F4 File Offset: 0x00077BF4
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevels groupLevels
		{
			get
			{
				return this.groupLevelsField;
			}
			set
			{
				this.groupLevelsField = value;
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x0600305E RID: 12382 RVA: 0x000799FD File Offset: 0x00077BFD
		// (set) Token: 0x0600305F RID: 12383 RVA: 0x00079A05 File Offset: 0x00077C05
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x00079A0E File Offset: 0x00077C0E
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x00079A16 File Offset: 0x00077C16
		[global::System.Xml.Serialization.XmlAttribute]
		public string uniqueName
		{
			get
			{
				return this.uniqueNameField;
			}
			set
			{
				this.uniqueNameField = value;
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x00079A1F File Offset: 0x00077C1F
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x00079A27 File Offset: 0x00077C27
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

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x00079A30 File Offset: 0x00077C30
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x00079A38 File Offset: 0x00077C38
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool measure
		{
			get
			{
				return this.measureField;
			}
			set
			{
				this.measureField = value;
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x00079A41 File Offset: 0x00077C41
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x00079A49 File Offset: 0x00077C49
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool set
		{
			get
			{
				return this.setField;
			}
			set
			{
				this.setField = value;
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06003068 RID: 12392 RVA: 0x00079A52 File Offset: 0x00077C52
		// (set) Token: 0x06003069 RID: 12393 RVA: 0x00079A5A File Offset: 0x00077C5A
		[global::System.Xml.Serialization.XmlAttribute]
		public uint parentSet
		{
			get
			{
				return this.parentSetField;
			}
			set
			{
				this.parentSetField = value;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x00079A63 File Offset: 0x00077C63
		// (set) Token: 0x0600306B RID: 12395 RVA: 0x00079A6B File Offset: 0x00077C6B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool parentSetSpecified
		{
			get
			{
				return this.parentSetFieldSpecified;
			}
			set
			{
				this.parentSetFieldSpecified = value;
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600306C RID: 12396 RVA: 0x00079A74 File Offset: 0x00077C74
		// (set) Token: 0x0600306D RID: 12397 RVA: 0x00079A7C File Offset: 0x00077C7C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int iconSet
		{
			get
			{
				return this.iconSetField;
			}
			set
			{
				this.iconSetField = value;
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x0600306E RID: 12398 RVA: 0x00079A85 File Offset: 0x00077C85
		// (set) Token: 0x0600306F RID: 12399 RVA: 0x00079A8D File Offset: 0x00077C8D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool attribute
		{
			get
			{
				return this.attributeField;
			}
			set
			{
				this.attributeField = value;
			}
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x00079A96 File Offset: 0x00077C96
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x00079A9E File Offset: 0x00077C9E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool time
		{
			get
			{
				return this.timeField;
			}
			set
			{
				this.timeField = value;
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x00079AA7 File Offset: 0x00077CA7
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x00079AAF File Offset: 0x00077CAF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool keyAttribute
		{
			get
			{
				return this.keyAttributeField;
			}
			set
			{
				this.keyAttributeField = value;
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06003074 RID: 12404 RVA: 0x00079AB8 File Offset: 0x00077CB8
		// (set) Token: 0x06003075 RID: 12405 RVA: 0x00079AC0 File Offset: 0x00077CC0
		[global::System.Xml.Serialization.XmlAttribute]
		public string defaultMemberUniqueName
		{
			get
			{
				return this.defaultMemberUniqueNameField;
			}
			set
			{
				this.defaultMemberUniqueNameField = value;
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x00079AC9 File Offset: 0x00077CC9
		// (set) Token: 0x06003077 RID: 12407 RVA: 0x00079AD1 File Offset: 0x00077CD1
		[global::System.Xml.Serialization.XmlAttribute]
		public string allUniqueName
		{
			get
			{
				return this.allUniqueNameField;
			}
			set
			{
				this.allUniqueNameField = value;
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x00079ADA File Offset: 0x00077CDA
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x00079AE2 File Offset: 0x00077CE2
		[global::System.Xml.Serialization.XmlAttribute]
		public string allCaption
		{
			get
			{
				return this.allCaptionField;
			}
			set
			{
				this.allCaptionField = value;
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x00079AEB File Offset: 0x00077CEB
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x00079AF3 File Offset: 0x00077CF3
		[global::System.Xml.Serialization.XmlAttribute]
		public string dimensionUniqueName
		{
			get
			{
				return this.dimensionUniqueNameField;
			}
			set
			{
				this.dimensionUniqueNameField = value;
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x0600307C RID: 12412 RVA: 0x00079AFC File Offset: 0x00077CFC
		// (set) Token: 0x0600307D RID: 12413 RVA: 0x00079B04 File Offset: 0x00077D04
		[global::System.Xml.Serialization.XmlAttribute]
		public string displayFolder
		{
			get
			{
				return this.displayFolderField;
			}
			set
			{
				this.displayFolderField = value;
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600307E RID: 12414 RVA: 0x00079B0D File Offset: 0x00077D0D
		// (set) Token: 0x0600307F RID: 12415 RVA: 0x00079B15 File Offset: 0x00077D15
		[global::System.Xml.Serialization.XmlAttribute]
		public string measureGroup
		{
			get
			{
				return this.measureGroupField;
			}
			set
			{
				this.measureGroupField = value;
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06003080 RID: 12416 RVA: 0x00079B1E File Offset: 0x00077D1E
		// (set) Token: 0x06003081 RID: 12417 RVA: 0x00079B26 File Offset: 0x00077D26
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool measures
		{
			get
			{
				return this.measuresField;
			}
			set
			{
				this.measuresField = value;
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x00079B2F File Offset: 0x00077D2F
		// (set) Token: 0x06003083 RID: 12419 RVA: 0x00079B37 File Offset: 0x00077D37
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06003084 RID: 12420 RVA: 0x00079B40 File Offset: 0x00077D40
		// (set) Token: 0x06003085 RID: 12421 RVA: 0x00079B48 File Offset: 0x00077D48
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool oneField
		{
			get
			{
				return this.oneFieldField;
			}
			set
			{
				this.oneFieldField = value;
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06003086 RID: 12422 RVA: 0x00079B51 File Offset: 0x00077D51
		// (set) Token: 0x06003087 RID: 12423 RVA: 0x00079B59 File Offset: 0x00077D59
		[global::System.Xml.Serialization.XmlAttribute]
		public ushort memberValueDatatype
		{
			get
			{
				return this.memberValueDatatypeField;
			}
			set
			{
				this.memberValueDatatypeField = value;
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x00079B62 File Offset: 0x00077D62
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x00079B6A File Offset: 0x00077D6A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool memberValueDatatypeSpecified
		{
			get
			{
				return this.memberValueDatatypeFieldSpecified;
			}
			set
			{
				this.memberValueDatatypeFieldSpecified = value;
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x00079B73 File Offset: 0x00077D73
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x00079B7B File Offset: 0x00077D7B
		[global::System.Xml.Serialization.XmlAttribute]
		public bool unbalanced
		{
			get
			{
				return this.unbalancedField;
			}
			set
			{
				this.unbalancedField = value;
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x00079B84 File Offset: 0x00077D84
		// (set) Token: 0x0600308D RID: 12429 RVA: 0x00079B8C File Offset: 0x00077D8C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool unbalancedSpecified
		{
			get
			{
				return this.unbalancedFieldSpecified;
			}
			set
			{
				this.unbalancedFieldSpecified = value;
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x00079B95 File Offset: 0x00077D95
		// (set) Token: 0x0600308F RID: 12431 RVA: 0x00079B9D File Offset: 0x00077D9D
		[global::System.Xml.Serialization.XmlAttribute]
		public bool unbalancedGroup
		{
			get
			{
				return this.unbalancedGroupField;
			}
			set
			{
				this.unbalancedGroupField = value;
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06003090 RID: 12432 RVA: 0x00079BA6 File Offset: 0x00077DA6
		// (set) Token: 0x06003091 RID: 12433 RVA: 0x00079BAE File Offset: 0x00077DAE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool unbalancedGroupSpecified
		{
			get
			{
				return this.unbalancedGroupFieldSpecified;
			}
			set
			{
				this.unbalancedGroupFieldSpecified = value;
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06003092 RID: 12434 RVA: 0x00079BB7 File Offset: 0x00077DB7
		// (set) Token: 0x06003093 RID: 12435 RVA: 0x00079BBF File Offset: 0x00077DBF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
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

		// Token: 0x040020DC RID: 8412
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldsUsage fieldsUsageField;

		// Token: 0x040020DD RID: 8413
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevels groupLevelsField;

		// Token: 0x040020DE RID: 8414
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040020DF RID: 8415
		private string uniqueNameField;

		// Token: 0x040020E0 RID: 8416
		private string captionField;

		// Token: 0x040020E1 RID: 8417
		private bool measureField;

		// Token: 0x040020E2 RID: 8418
		private bool setField;

		// Token: 0x040020E3 RID: 8419
		private uint parentSetField;

		// Token: 0x040020E4 RID: 8420
		private bool parentSetFieldSpecified;

		// Token: 0x040020E5 RID: 8421
		private int iconSetField;

		// Token: 0x040020E6 RID: 8422
		private bool attributeField;

		// Token: 0x040020E7 RID: 8423
		private bool timeField;

		// Token: 0x040020E8 RID: 8424
		private bool keyAttributeField;

		// Token: 0x040020E9 RID: 8425
		private string defaultMemberUniqueNameField;

		// Token: 0x040020EA RID: 8426
		private string allUniqueNameField;

		// Token: 0x040020EB RID: 8427
		private string allCaptionField;

		// Token: 0x040020EC RID: 8428
		private string dimensionUniqueNameField;

		// Token: 0x040020ED RID: 8429
		private string displayFolderField;

		// Token: 0x040020EE RID: 8430
		private string measureGroupField;

		// Token: 0x040020EF RID: 8431
		private bool measuresField;

		// Token: 0x040020F0 RID: 8432
		private uint countField;

		// Token: 0x040020F1 RID: 8433
		private bool oneFieldField;

		// Token: 0x040020F2 RID: 8434
		private ushort memberValueDatatypeField;

		// Token: 0x040020F3 RID: 8435
		private bool memberValueDatatypeFieldSpecified;

		// Token: 0x040020F4 RID: 8436
		private bool unbalancedField;

		// Token: 0x040020F5 RID: 8437
		private bool unbalancedFieldSpecified;

		// Token: 0x040020F6 RID: 8438
		private bool unbalancedGroupField;

		// Token: 0x040020F7 RID: 8439
		private bool unbalancedGroupFieldSpecified;

		// Token: 0x040020F8 RID: 8440
		private bool hiddenField;
	}
}
