using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000603 RID: 1539
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExternalDefinedName
	{
		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x0600436F RID: 17263 RVA: 0x000A0608 File Offset: 0x0009E808
		// (set) Token: 0x06004370 RID: 17264 RVA: 0x000A0610 File Offset: 0x0009E810
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

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x06004371 RID: 17265 RVA: 0x000A0619 File Offset: 0x0009E819
		// (set) Token: 0x06004372 RID: 17266 RVA: 0x000A0621 File Offset: 0x0009E821
		[global::System.Xml.Serialization.XmlAttribute]
		public string refersTo
		{
			get
			{
				return this.refersToField;
			}
			set
			{
				this.refersToField = value;
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06004373 RID: 17267 RVA: 0x000A062A File Offset: 0x0009E82A
		// (set) Token: 0x06004374 RID: 17268 RVA: 0x000A0632 File Offset: 0x0009E832
		[global::System.Xml.Serialization.XmlAttribute]
		public uint sheetId
		{
			get
			{
				return this.sheetIdField;
			}
			set
			{
				this.sheetIdFieldSpecified = true;
				this.sheetIdField = value;
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06004375 RID: 17269 RVA: 0x000A0642 File Offset: 0x0009E842
		// (set) Token: 0x06004376 RID: 17270 RVA: 0x000A064A File Offset: 0x0009E84A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool sheetIdSpecified
		{
			get
			{
				return this.sheetIdFieldSpecified;
			}
			set
			{
				this.sheetIdFieldSpecified = value;
			}
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x000A0653 File Offset: 0x0009E853
		public bool IsSetSheetId()
		{
			return this.sheetIdFieldSpecified && this.sheetIdField > 0U;
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x000A0668 File Offset: 0x0009E868
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName ct_ExternalDefinedName = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName();
			ct_ExternalDefinedName.nameField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_ExternalDefinedName.refersToField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["refersTo"]);
			ct_ExternalDefinedName.sheetIdFieldSpecified = (node.Attributes["sheetId"] != null);
			if (ct_ExternalDefinedName.sheetIdFieldSpecified)
			{
				ct_ExternalDefinedName.sheetIdField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["sheetId"]);
			}
			return ct_ExternalDefinedName;
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x000A06F0 File Offset: 0x0009E8F0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.nameField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "refersTo", this.refersToField);
			if (this.sheetIdFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sheetId", this.sheetIdField, false);
			}
			sw.Write("/>");
		}

		// Token: 0x04002A85 RID: 10885
		private string nameField;

		// Token: 0x04002A86 RID: 10886
		private string refersToField;

		// Token: 0x04002A87 RID: 10887
		private uint sheetIdField;

		// Token: 0x04002A88 RID: 10888
		private bool sheetIdFieldSpecified;
	}
}
