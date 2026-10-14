using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200048E RID: 1166
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_X
	{
		// Token: 0x06002EFF RID: 12031 RVA: 0x00075F7C File Offset: 0x0007417C
		public CT_X()
		{
			this.vField = 0;
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x00075F8B File Offset: 0x0007418B
		// (set) Token: 0x06002F01 RID: 12033 RVA: 0x00075F93 File Offset: 0x00074193
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00075F9C File Offset: 0x0007419C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_X Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_X ct_X = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_X();
			if (node.Attributes["v"] != null)
			{
				ct_X.v = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["v"]);
			}
			return ct_X;
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00075FE2 File Offset: 0x000741E2
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v", this.v);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002045 RID: 8261
		private int vField;
	}
}
