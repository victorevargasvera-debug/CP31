using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200048A RID: 1162
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_SharedItems
	{
		// Token: 0x06002E8C RID: 11916 RVA: 0x00074CD0 File Offset: 0x00072ED0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedItems Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedItems ct_SharedItems = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedItems();
			if (node.Attributes["containsSemiMixedTypes"] != null)
			{
				ct_SharedItems.containsSemiMixedTypes = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["containsSemiMixedTypes"]);
			}
			if (node.Attributes["containsNonDate"] != null)
			{
				ct_SharedItems.containsNonDate = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["containsNonDate"]);
			}
			if (node.Attributes["containsDate"] != null)
			{
				ct_SharedItems.containsDate = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["containsDate"]);
			}
			if (node.Attributes["containsString"] != null)
			{
				ct_SharedItems.containsString = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["containsString"]);
			}
			if (node.Attributes["containsBlank"] != null)
			{
				ct_SharedItems.containsBlank = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["containsBlank"]);
			}
			if (node.Attributes["containsMixedTypes"] != null)
			{
				ct_SharedItems.containsMixedTypes = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["containsMixedTypes"]);
			}
			if (node.Attributes["containsNumber"] != null)
			{
				ct_SharedItems.containsNumber = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["containsNumber"]);
			}
			if (node.Attributes["containsInteger"] != null)
			{
				ct_SharedItems.containsInteger = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["containsInteger"]);
			}
			if (node.Attributes["minValue"] != null)
			{
				ct_SharedItems.minValue = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["minValue"]);
			}
			if (node.Attributes["maxValue"] != null)
			{
				ct_SharedItems.maxValue = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["maxValue"]);
			}
			if (node.Attributes["minDate"] != null)
			{
				ct_SharedItems.minDate = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDateTime(node.Attributes["minDate"]);
			}
			if (node.Attributes["maxDate"] != null)
			{
				ct_SharedItems.maxDate = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDateTime(node.Attributes["maxDate"]);
			}
			if (node.Attributes["count"] != null)
			{
				ct_SharedItems.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			if (node.Attributes["longText"] != null)
			{
				ct_SharedItems.longText = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["longText"]);
			}
			ct_SharedItems.Items = new global::System.Collections.Generic.List<object>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "n")
				{
					ct_SharedItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "b")
				{
					ct_SharedItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "d")
				{
					ct_SharedItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_SharedItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "m")
				{
					ct_SharedItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "s")
				{
					ct_SharedItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_String.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SharedItems;
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x000750AC File Offset: 0x000732AC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "containsSemiMixedTypes", this.containsSemiMixedTypes);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "containsNonDate", this.containsNonDate);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "containsDate", this.containsDate);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "containsString", this.containsString);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "containsBlank", this.containsBlank);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "containsMixedTypes", this.containsMixedTypes);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "containsNumber", this.containsNumber);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "containsInteger", this.containsInteger);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "minValue", this.minValue);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "maxValue", this.maxValue);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "minDate", this.minDate);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "maxDate", this.maxDate);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "longText", this.longText);
			sw.Write(">");
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number)obj).Write(sw, "n");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean)obj).Write(sw, "b");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime)obj).Write(sw, "d");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error)obj).Write(sw, "e");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing)obj).Write(sw, "m");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_String)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_String)obj).Write(sw, "s");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x000752C0 File Offset: 0x000734C0
		public CT_SharedItems()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
			this.containsSemiMixedTypesField = true;
			this.containsNonDateField = true;
			this.containsDateField = false;
			this.containsStringField = true;
			this.containsBlankField = false;
			this.containsMixedTypesField = false;
			this.containsNumberField = false;
			this.containsIntegerField = false;
			this.longTextField = false;
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06002E8F RID: 11919 RVA: 0x0007531D File Offset: 0x0007351D
		// (set) Token: 0x06002E90 RID: 11920 RVA: 0x00075325 File Offset: 0x00073525
		[global::System.Xml.Serialization.XmlElement("b", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("d", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("e", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("m", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("n", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("s", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_String), Order = 0)]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x0007532E File Offset: 0x0007352E
		// (set) Token: 0x06002E92 RID: 11922 RVA: 0x00075336 File Offset: 0x00073536
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool containsSemiMixedTypes
		{
			get
			{
				return this.containsSemiMixedTypesField;
			}
			set
			{
				this.containsSemiMixedTypesField = value;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06002E93 RID: 11923 RVA: 0x0007533F File Offset: 0x0007353F
		// (set) Token: 0x06002E94 RID: 11924 RVA: 0x00075347 File Offset: 0x00073547
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool containsNonDate
		{
			get
			{
				return this.containsNonDateField;
			}
			set
			{
				this.containsNonDateField = value;
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x00075350 File Offset: 0x00073550
		// (set) Token: 0x06002E96 RID: 11926 RVA: 0x00075358 File Offset: 0x00073558
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool containsDate
		{
			get
			{
				return this.containsDateField;
			}
			set
			{
				this.containsDateField = value;
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x00075361 File Offset: 0x00073561
		// (set) Token: 0x06002E98 RID: 11928 RVA: 0x00075369 File Offset: 0x00073569
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool containsString
		{
			get
			{
				return this.containsStringField;
			}
			set
			{
				this.containsStringField = value;
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x00075372 File Offset: 0x00073572
		// (set) Token: 0x06002E9A RID: 11930 RVA: 0x0007537A File Offset: 0x0007357A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool containsBlank
		{
			get
			{
				return this.containsBlankField;
			}
			set
			{
				this.containsBlankField = value;
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x00075383 File Offset: 0x00073583
		// (set) Token: 0x06002E9C RID: 11932 RVA: 0x0007538B File Offset: 0x0007358B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool containsMixedTypes
		{
			get
			{
				return this.containsMixedTypesField;
			}
			set
			{
				this.containsMixedTypesField = value;
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x00075394 File Offset: 0x00073594
		// (set) Token: 0x06002E9E RID: 11934 RVA: 0x0007539C File Offset: 0x0007359C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool containsNumber
		{
			get
			{
				return this.containsNumberField;
			}
			set
			{
				this.containsNumberField = value;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x000753A5 File Offset: 0x000735A5
		// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x000753AD File Offset: 0x000735AD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool containsInteger
		{
			get
			{
				return this.containsIntegerField;
			}
			set
			{
				this.containsIntegerField = value;
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x000753B6 File Offset: 0x000735B6
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x000753BE File Offset: 0x000735BE
		[global::System.Xml.Serialization.XmlAttribute]
		public double minValue
		{
			get
			{
				return this.minValueField;
			}
			set
			{
				this.minValueField = value;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x000753C7 File Offset: 0x000735C7
		// (set) Token: 0x06002EA4 RID: 11940 RVA: 0x000753CF File Offset: 0x000735CF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool minValueSpecified
		{
			get
			{
				return this.minValueFieldSpecified;
			}
			set
			{
				this.minValueFieldSpecified = value;
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x000753D8 File Offset: 0x000735D8
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x000753E0 File Offset: 0x000735E0
		[global::System.Xml.Serialization.XmlAttribute]
		public double maxValue
		{
			get
			{
				return this.maxValueField;
			}
			set
			{
				this.maxValueField = value;
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x000753E9 File Offset: 0x000735E9
		// (set) Token: 0x06002EA8 RID: 11944 RVA: 0x000753F1 File Offset: 0x000735F1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool maxValueSpecified
		{
			get
			{
				return this.maxValueFieldSpecified;
			}
			set
			{
				this.maxValueFieldSpecified = value;
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x000753FA File Offset: 0x000735FA
		// (set) Token: 0x06002EAA RID: 11946 RVA: 0x00075402 File Offset: 0x00073602
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.DateTime? minDate
		{
			get
			{
				return this.minDateField;
			}
			set
			{
				this.minDateField = value;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x0007540B File Offset: 0x0007360B
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00075413 File Offset: 0x00073613
		[global::System.Xml.Serialization.XmlIgnore]
		public bool minDateSpecified
		{
			get
			{
				return this.minDateFieldSpecified;
			}
			set
			{
				this.minDateFieldSpecified = value;
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x0007541C File Offset: 0x0007361C
		// (set) Token: 0x06002EAE RID: 11950 RVA: 0x00075424 File Offset: 0x00073624
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.DateTime? maxDate
		{
			get
			{
				return this.maxDateField;
			}
			set
			{
				this.maxDateField = value;
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x0007542D File Offset: 0x0007362D
		// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00075435 File Offset: 0x00073635
		[global::System.Xml.Serialization.XmlIgnore]
		public bool maxDateSpecified
		{
			get
			{
				return this.maxDateFieldSpecified;
			}
			set
			{
				this.maxDateFieldSpecified = value;
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06002EB1 RID: 11953 RVA: 0x0007543E File Offset: 0x0007363E
		// (set) Token: 0x06002EB2 RID: 11954 RVA: 0x00075446 File Offset: 0x00073646
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

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x0007544F File Offset: 0x0007364F
		// (set) Token: 0x06002EB4 RID: 11956 RVA: 0x00075457 File Offset: 0x00073657
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x00075460 File Offset: 0x00073660
		// (set) Token: 0x06002EB6 RID: 11958 RVA: 0x00075468 File Offset: 0x00073668
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool longText
		{
			get
			{
				return this.longTextField;
			}
			set
			{
				this.longTextField = value;
			}
		}

		// Token: 0x04002012 RID: 8210
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04002013 RID: 8211
		private bool containsSemiMixedTypesField;

		// Token: 0x04002014 RID: 8212
		private bool containsNonDateField;

		// Token: 0x04002015 RID: 8213
		private bool containsDateField;

		// Token: 0x04002016 RID: 8214
		private bool containsStringField;

		// Token: 0x04002017 RID: 8215
		private bool containsBlankField;

		// Token: 0x04002018 RID: 8216
		private bool containsMixedTypesField;

		// Token: 0x04002019 RID: 8217
		private bool containsNumberField;

		// Token: 0x0400201A RID: 8218
		private bool containsIntegerField;

		// Token: 0x0400201B RID: 8219
		private double minValueField;

		// Token: 0x0400201C RID: 8220
		private bool minValueFieldSpecified;

		// Token: 0x0400201D RID: 8221
		private double maxValueField;

		// Token: 0x0400201E RID: 8222
		private bool maxValueFieldSpecified;

		// Token: 0x0400201F RID: 8223
		private global::System.DateTime? minDateField;

		// Token: 0x04002020 RID: 8224
		private bool minDateFieldSpecified;

		// Token: 0x04002021 RID: 8225
		private global::System.DateTime? maxDateField;

		// Token: 0x04002022 RID: 8226
		private bool maxDateFieldSpecified;

		// Token: 0x04002023 RID: 8227
		private uint countField;

		// Token: 0x04002024 RID: 8228
		private bool countFieldSpecified;

		// Token: 0x04002025 RID: 8229
		private bool longTextField;
	}
}
