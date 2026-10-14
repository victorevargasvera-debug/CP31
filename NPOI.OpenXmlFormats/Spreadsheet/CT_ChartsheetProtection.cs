using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005C0 RID: 1472
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ChartsheetProtection
	{
		// Token: 0x060040CA RID: 16586 RVA: 0x0009D3B7 File Offset: 0x0009B5B7
		public CT_ChartsheetProtection()
		{
			this.contentField = false;
			this.objectsField = false;
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x0009D3CD File Offset: 0x0009B5CD
		// (set) Token: 0x060040CC RID: 16588 RVA: 0x0009D3D5 File Offset: 0x0009B5D5
		public byte[] password
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

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x060040CD RID: 16589 RVA: 0x0009D3DE File Offset: 0x0009B5DE
		// (set) Token: 0x060040CE RID: 16590 RVA: 0x0009D3E6 File Offset: 0x0009B5E6
		[global::System.ComponentModel.DefaultValue(false)]
		public bool content
		{
			get
			{
				return this.contentField;
			}
			set
			{
				this.contentField = value;
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x060040CF RID: 16591 RVA: 0x0009D3EF File Offset: 0x0009B5EF
		// (set) Token: 0x060040D0 RID: 16592 RVA: 0x0009D3F7 File Offset: 0x0009B5F7
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

		// Token: 0x060040D1 RID: 16593 RVA: 0x0009D400 File Offset: 0x0009B600
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetProtection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetProtection ct_ChartsheetProtection = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetProtection();
			if (node.Attributes["password"] != null)
			{
				ct_ChartsheetProtection.password = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["password"]);
			}
			if (node.Attributes["content"] != null)
			{
				ct_ChartsheetProtection.content = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["content"]);
			}
			if (node.Attributes["objects"] != null)
			{
				ct_ChartsheetProtection.objects = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["objects"]);
			}
			return ct_ChartsheetProtection;
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x0009D4A0 File Offset: 0x0009B6A0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "password", this.password);
			if (this.content)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "content", this.content);
			}
			if (this.objects)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "objects", this.objects);
			}
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002905 RID: 10501
		private byte[] passwordField;

		// Token: 0x04002906 RID: 10502
		private bool contentField;

		// Token: 0x04002907 RID: 10503
		private bool objectsField;
	}
}
