using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005AF RID: 1455
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_IgnoredError
	{
		// Token: 0x06004019 RID: 16409 RVA: 0x0009B7F4 File Offset: 0x000999F4
		public CT_IgnoredError()
		{
			this.sqrefField = new global::System.Collections.Generic.List<string>();
			this.evalErrorField = false;
			this.twoDigitTextYearField = false;
			this.numberStoredAsTextField = false;
			this.formulaField = false;
			this.formulaRangeField = false;
			this.unlockedFormulaField = false;
			this.emptyCellReferenceField = false;
			this.listDataValidationField = false;
			this.calculatedColumnField = false;
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x0009B854 File Offset: 0x00099A54
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError ct_IgnoredError = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError();
			ct_IgnoredError.evalError = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["evalError"]);
			ct_IgnoredError.twoDigitTextYear = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["twoDigitTextYear"]);
			ct_IgnoredError.numberStoredAsText = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["numberStoredAsText"]);
			ct_IgnoredError.formula = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["formula"]);
			ct_IgnoredError.formulaRange = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["formulaRange"]);
			ct_IgnoredError.unlockedFormula = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["unlockedFormula"]);
			ct_IgnoredError.emptyCellReference = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["emptyCellReference"]);
			ct_IgnoredError.listDataValidation = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["listDataValidation"]);
			ct_IgnoredError.calculatedColumn = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["calculatedColumn"]);
			string text = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sqref"]);
			if (text != null)
			{
				ct_IgnoredError.sqref.AddRange(text.Split(new char[]
				{
					' '
				}));
			}
			return ct_IgnoredError;
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x0009B998 File Offset: 0x00099B98
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sqref", string.Join(" ", this.sqref));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "evalError", this.evalError, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "twoDigitTextYear", this.twoDigitTextYear, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "numberStoredAsText", this.numberStoredAsText, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "formula", this.formula, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "formulaRange", this.formulaRange, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "unlockedFormula", this.unlockedFormula, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "emptyCellReference", this.emptyCellReference, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "listDataValidation", this.listDataValidation, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "calculatedColumn", this.calculatedColumn, false);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x0009BA8F File Offset: 0x00099C8F
		// (set) Token: 0x0600401D RID: 16413 RVA: 0x0009BA97 File Offset: 0x00099C97
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.Collections.Generic.List<string> sqref
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

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x0600401E RID: 16414 RVA: 0x0009BAA0 File Offset: 0x00099CA0
		// (set) Token: 0x0600401F RID: 16415 RVA: 0x0009BAA8 File Offset: 0x00099CA8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool evalError
		{
			get
			{
				return this.evalErrorField;
			}
			set
			{
				this.evalErrorField = value;
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06004020 RID: 16416 RVA: 0x0009BAB1 File Offset: 0x00099CB1
		// (set) Token: 0x06004021 RID: 16417 RVA: 0x0009BAB9 File Offset: 0x00099CB9
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool twoDigitTextYear
		{
			get
			{
				return this.twoDigitTextYearField;
			}
			set
			{
				this.twoDigitTextYearField = value;
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x0009BAC2 File Offset: 0x00099CC2
		// (set) Token: 0x06004023 RID: 16419 RVA: 0x0009BACA File Offset: 0x00099CCA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool numberStoredAsText
		{
			get
			{
				return this.numberStoredAsTextField;
			}
			set
			{
				this.numberStoredAsTextField = value;
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06004024 RID: 16420 RVA: 0x0009BAD3 File Offset: 0x00099CD3
		// (set) Token: 0x06004025 RID: 16421 RVA: 0x0009BADB File Offset: 0x00099CDB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool formula
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

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06004026 RID: 16422 RVA: 0x0009BAE4 File Offset: 0x00099CE4
		// (set) Token: 0x06004027 RID: 16423 RVA: 0x0009BAEC File Offset: 0x00099CEC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool formulaRange
		{
			get
			{
				return this.formulaRangeField;
			}
			set
			{
				this.formulaRangeField = value;
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06004028 RID: 16424 RVA: 0x0009BAF5 File Offset: 0x00099CF5
		// (set) Token: 0x06004029 RID: 16425 RVA: 0x0009BAFD File Offset: 0x00099CFD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool unlockedFormula
		{
			get
			{
				return this.unlockedFormulaField;
			}
			set
			{
				this.unlockedFormulaField = value;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x0009BB06 File Offset: 0x00099D06
		// (set) Token: 0x0600402B RID: 16427 RVA: 0x0009BB0E File Offset: 0x00099D0E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool emptyCellReference
		{
			get
			{
				return this.emptyCellReferenceField;
			}
			set
			{
				this.emptyCellReferenceField = value;
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x0600402C RID: 16428 RVA: 0x0009BB17 File Offset: 0x00099D17
		// (set) Token: 0x0600402D RID: 16429 RVA: 0x0009BB1F File Offset: 0x00099D1F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool listDataValidation
		{
			get
			{
				return this.listDataValidationField;
			}
			set
			{
				this.listDataValidationField = value;
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x0600402E RID: 16430 RVA: 0x0009BB28 File Offset: 0x00099D28
		// (set) Token: 0x0600402F RID: 16431 RVA: 0x0009BB30 File Offset: 0x00099D30
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool calculatedColumn
		{
			get
			{
				return this.calculatedColumnField;
			}
			set
			{
				this.calculatedColumnField = value;
			}
		}

		// Token: 0x040028B3 RID: 10419
		private global::System.Collections.Generic.List<string> sqrefField;

		// Token: 0x040028B4 RID: 10420
		private bool evalErrorField;

		// Token: 0x040028B5 RID: 10421
		private bool twoDigitTextYearField;

		// Token: 0x040028B6 RID: 10422
		private bool numberStoredAsTextField;

		// Token: 0x040028B7 RID: 10423
		private bool formulaField;

		// Token: 0x040028B8 RID: 10424
		private bool formulaRangeField;

		// Token: 0x040028B9 RID: 10425
		private bool unlockedFormulaField;

		// Token: 0x040028BA RID: 10426
		private bool emptyCellReferenceField;

		// Token: 0x040028BB RID: 10427
		private bool listDataValidationField;

		// Token: 0x040028BC RID: 10428
		private bool calculatedColumnField;
	}
}
