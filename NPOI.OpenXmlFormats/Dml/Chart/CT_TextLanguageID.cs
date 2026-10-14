using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000468 RID: 1128
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextLanguageID
	{
		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x00071F7F File Offset: 0x0007017F
		// (set) Token: 0x06002D12 RID: 11538 RVA: 0x00071F87 File Offset: 0x00070187
		[global::System.Xml.Serialization.XmlAttribute]
		public string val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00071F90 File Offset: 0x00070190
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextLanguageID Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextLanguageID
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["val"])
			};
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00071FB7 File Offset: 0x000701B7
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x04001F7A RID: 8058
		private string valField;
	}
}
