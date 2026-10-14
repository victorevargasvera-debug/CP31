using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005A7 RID: 1447
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DataValidation
	{
		// Token: 0x06003FE2 RID: 16354 RVA: 0x0009AEC4 File Offset: 0x000990C4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation ct_DataValidation = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation();
			if (node.Attributes["type"] != null)
			{
				ct_DataValidation.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType), node.Attributes["type"].Value);
			}
			if (node.Attributes["errorStyle"] != null)
			{
				ct_DataValidation.errorStyle = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle), node.Attributes["errorStyle"].Value);
			}
			if (node.Attributes["imeMode"] != null)
			{
				ct_DataValidation.imeMode = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationImeMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationImeMode), node.Attributes["imeMode"].Value);
			}
			if (node.Attributes["operator"] != null)
			{
				ct_DataValidation.@operator = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator), node.Attributes["operator"].Value);
			}
			ct_DataValidation.allowBlank = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["allowBlank"]);
			ct_DataValidation.showDropDown = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showDropDown"]);
			ct_DataValidation.showInputMessage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showInputMessage"]);
			ct_DataValidation.showErrorMessage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showErrorMessage"]);
			ct_DataValidation.errorTitle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["errorTitle"]);
			ct_DataValidation.error = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["error"]);
			ct_DataValidation.promptTitle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["promptTitle"]);
			ct_DataValidation.prompt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["prompt"]);
			ct_DataValidation.sqref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sqref"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "formula1")
				{
					ct_DataValidation.formula1 = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "formula2")
				{
					ct_DataValidation.formula2 = xmlNode.InnerText;
				}
			}
			return ct_DataValidation;
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x0009B158 File Offset: 0x00099358
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "errorStyle", this.errorStyle.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "imeMode", this.imeMode.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "operator", this.@operator.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "allowBlank", this.allowBlank);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showDropDown", this.showDropDown);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showInputMessage", this.showInputMessage);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showErrorMessage", this.showErrorMessage);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "errorTitle", this.errorTitle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "error", this.error);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "promptTitle", this.promptTitle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "prompt", this.prompt);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sqref", this.sqref);
			sw.Write(">");
			if (this.formula1 != null)
			{
				sw.Write(string.Format("<formula1><![CDATA[{0}]]></formula1>", this.formula1));
			}
			if (this.formula2 != null)
			{
				sw.Write(string.Format("<formula2><![CDATA[{0}]]></formula2>", this.formula2));
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x0009B2E3 File Offset: 0x000994E3
		public CT_DataValidation()
		{
			this.typeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.none;
			this.errorStyleField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle.stop;
			this.imeModeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationImeMode.noControl;
			this.operatorField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.between;
			this.allowBlankField = false;
			this.showDropDownField = false;
			this.showInputMessageField = false;
			this.showErrorMessageField = false;
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x0009B324 File Offset: 0x00099524
		public void Set(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation obj)
		{
			this.formula1Field = obj.formula1Field;
			this.formula2Field = obj.formula2Field;
			this.typeField = obj.typeField;
			this.errorStyleField = obj.errorStyleField;
			this.imeModeField = obj.imeModeField;
			this.operatorField = obj.operatorField;
			this.allowBlankField = obj.allowBlankField;
			this.showDropDownField = obj.showDropDownField;
			this.showInputMessageField = obj.showInputMessageField;
			this.showErrorMessageField = obj.showErrorMessageField;
			this.errorTitleField = obj.errorTitleField;
			this.errorField = obj.errorField;
			this.promptTitleField = obj.promptTitleField;
			this.promptField = obj.promptField;
			this.sqrefField = obj.sqrefField;
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06003FE6 RID: 16358 RVA: 0x0009B3E5 File Offset: 0x000995E5
		// (set) Token: 0x06003FE7 RID: 16359 RVA: 0x0009B3ED File Offset: 0x000995ED
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public string formula1
		{
			get
			{
				return this.formula1Field;
			}
			set
			{
				this.formula1Field = value;
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06003FE8 RID: 16360 RVA: 0x0009B3F6 File Offset: 0x000995F6
		// (set) Token: 0x06003FE9 RID: 16361 RVA: 0x0009B3FE File Offset: 0x000995FE
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public string formula2
		{
			get
			{
				return this.formula2Field;
			}
			set
			{
				this.formula2Field = value;
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06003FEA RID: 16362 RVA: 0x0009B407 File Offset: 0x00099607
		// (set) Token: 0x06003FEB RID: 16363 RVA: 0x0009B40F File Offset: 0x0009960F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.none)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType type
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

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06003FEC RID: 16364 RVA: 0x0009B418 File Offset: 0x00099618
		// (set) Token: 0x06003FED RID: 16365 RVA: 0x0009B420 File Offset: 0x00099620
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle.stop)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle errorStyle
		{
			get
			{
				return this.errorStyleField;
			}
			set
			{
				this.errorStyleField = value;
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06003FEE RID: 16366 RVA: 0x0009B429 File Offset: 0x00099629
		// (set) Token: 0x06003FEF RID: 16367 RVA: 0x0009B431 File Offset: 0x00099631
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationImeMode.noControl)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationImeMode imeMode
		{
			get
			{
				return this.imeModeField;
			}
			set
			{
				this.imeModeField = value;
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06003FF0 RID: 16368 RVA: 0x0009B43A File Offset: 0x0009963A
		// (set) Token: 0x06003FF1 RID: 16369 RVA: 0x0009B442 File Offset: 0x00099642
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.between)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator @operator
		{
			get
			{
				return this.operatorField;
			}
			set
			{
				this.operatorField = value;
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x0009B44B File Offset: 0x0009964B
		// (set) Token: 0x06003FF3 RID: 16371 RVA: 0x0009B453 File Offset: 0x00099653
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool allowBlank
		{
			get
			{
				return this.allowBlankField;
			}
			set
			{
				this.allowBlankField = value;
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06003FF4 RID: 16372 RVA: 0x0009B45C File Offset: 0x0009965C
		// (set) Token: 0x06003FF5 RID: 16373 RVA: 0x0009B464 File Offset: 0x00099664
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showDropDown
		{
			get
			{
				return this.showDropDownField;
			}
			set
			{
				this.showDropDownField = value;
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06003FF6 RID: 16374 RVA: 0x0009B46D File Offset: 0x0009966D
		// (set) Token: 0x06003FF7 RID: 16375 RVA: 0x0009B475 File Offset: 0x00099675
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showInputMessage
		{
			get
			{
				return this.showInputMessageField;
			}
			set
			{
				this.showInputMessageField = value;
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06003FF8 RID: 16376 RVA: 0x0009B47E File Offset: 0x0009967E
		// (set) Token: 0x06003FF9 RID: 16377 RVA: 0x0009B486 File Offset: 0x00099686
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showErrorMessage
		{
			get
			{
				return this.showErrorMessageField;
			}
			set
			{
				this.showErrorMessageField = value;
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06003FFA RID: 16378 RVA: 0x0009B48F File Offset: 0x0009968F
		// (set) Token: 0x06003FFB RID: 16379 RVA: 0x0009B497 File Offset: 0x00099697
		[global::System.Xml.Serialization.XmlAttribute]
		public string errorTitle
		{
			get
			{
				return this.errorTitleField;
			}
			set
			{
				this.errorTitleField = value;
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06003FFC RID: 16380 RVA: 0x0009B4A0 File Offset: 0x000996A0
		// (set) Token: 0x06003FFD RID: 16381 RVA: 0x0009B4A8 File Offset: 0x000996A8
		[global::System.Xml.Serialization.XmlAttribute]
		public string error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06003FFE RID: 16382 RVA: 0x0009B4B1 File Offset: 0x000996B1
		// (set) Token: 0x06003FFF RID: 16383 RVA: 0x0009B4B9 File Offset: 0x000996B9
		[global::System.Xml.Serialization.XmlAttribute]
		public string promptTitle
		{
			get
			{
				return this.promptTitleField;
			}
			set
			{
				this.promptTitleField = value;
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06004000 RID: 16384 RVA: 0x0009B4C2 File Offset: 0x000996C2
		// (set) Token: 0x06004001 RID: 16385 RVA: 0x0009B4CA File Offset: 0x000996CA
		[global::System.Xml.Serialization.XmlAttribute]
		public string prompt
		{
			get
			{
				return this.promptField;
			}
			set
			{
				this.promptField = value;
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06004002 RID: 16386 RVA: 0x0009B4D3 File Offset: 0x000996D3
		// (set) Token: 0x06004003 RID: 16387 RVA: 0x0009B4DB File Offset: 0x000996DB
		[global::System.Xml.Serialization.XmlAttribute]
		public string sqref
		{
			get
			{
				return this.sqrefField;
			}
			set
			{
				this.sqrefField = value;
			}
		}

		// Token: 0x0400287D RID: 10365
		private string formula1Field;

		// Token: 0x0400287E RID: 10366
		private string formula2Field;

		// Token: 0x0400287F RID: 10367
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType typeField;

		// Token: 0x04002880 RID: 10368
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle errorStyleField;

		// Token: 0x04002881 RID: 10369
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationImeMode imeModeField;

		// Token: 0x04002882 RID: 10370
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator operatorField;

		// Token: 0x04002883 RID: 10371
		private bool allowBlankField;

		// Token: 0x04002884 RID: 10372
		private bool showDropDownField;

		// Token: 0x04002885 RID: 10373
		private bool showInputMessageField;

		// Token: 0x04002886 RID: 10374
		private bool showErrorMessageField;

		// Token: 0x04002887 RID: 10375
		private string errorTitleField;

		// Token: 0x04002888 RID: 10376
		private string errorField;

		// Token: 0x04002889 RID: 10377
		private string promptTitleField;

		// Token: 0x0400288A RID: 10378
		private string promptField;

		// Token: 0x0400288B RID: 10379
		private string sqrefField;
	}
}
