using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005AE RID: 1454
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_IgnoredErrors
	{
		// Token: 0x06004011 RID: 16401 RVA: 0x0009B630 File Offset: 0x00099830
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredErrors Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredErrors ct_IgnoredErrors = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredErrors();
			ct_IgnoredErrors.ignoredError = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_IgnoredErrors.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ignoredError")
				{
					ct_IgnoredErrors.ignoredError.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_IgnoredErrors;
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x0009B6E0 File Offset: 0x000998E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.ignoredError != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError ct_IgnoredError in this.ignoredError)
				{
					ct_IgnoredError.Write(sw, "ignoredError");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x0009B784 File Offset: 0x00099984
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError AddNewIgnoredError()
		{
			if (this.ignoredError == null)
			{
				this.ignoredError = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError ct_IgnoredError = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError();
			this.ignoredError.Add(ct_IgnoredError);
			return ct_IgnoredError;
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x0009B7B7 File Offset: 0x000999B7
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError GetIgnoredErrorArray(int v)
		{
			if (this.ignoredError == null)
			{
				return null;
			}
			return this.ignoredErrorField[v];
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06004015 RID: 16405 RVA: 0x0009B7CF File Offset: 0x000999CF
		// (set) Token: 0x06004016 RID: 16406 RVA: 0x0009B7D7 File Offset: 0x000999D7
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError> ignoredError
		{
			get
			{
				return this.ignoredErrorField;
			}
			set
			{
				this.ignoredErrorField = value;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06004017 RID: 16407 RVA: 0x0009B7E0 File Offset: 0x000999E0
		// (set) Token: 0x06004018 RID: 16408 RVA: 0x0009B7E8 File Offset: 0x000999E8
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

		// Token: 0x040028B1 RID: 10417
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError> ignoredErrorField;

		// Token: 0x040028B2 RID: 10418
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
