using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000510 RID: 1296
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_MergeCell
	{
		// Token: 0x060037CF RID: 14287 RVA: 0x0008B232 File Offset: 0x00089432
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell
			{
				@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"])
			};
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x0008B259 File Offset: 0x00089459
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			sw.Write("/>");
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x060037D1 RID: 14289 RVA: 0x0008B288 File Offset: 0x00089488
		// (set) Token: 0x060037D2 RID: 14290 RVA: 0x0008B290 File Offset: 0x00089490
		[global::System.Xml.Serialization.XmlAttribute]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x04002433 RID: 9267
		private string refField;
	}
}
