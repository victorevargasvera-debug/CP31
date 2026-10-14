using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000459 RID: 1113
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Overlap
	{
		// Token: 0x06002C51 RID: 11345 RVA: 0x0006F740 File Offset: 0x0006D940
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Overlap Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Overlap ct_Overlap = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Overlap();
			if (node.Attributes["val"] != null)
			{
				ct_Overlap.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadSByte(node.Attributes["val"]);
			}
			return ct_Overlap;
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x0006F786 File Offset: 0x0006D986
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x0006F7C6 File Offset: 0x0006D9C6
		public CT_Overlap()
		{
			this.valField = 0;
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x0006F7D5 File Offset: 0x0006D9D5
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x0006F7DD File Offset: 0x0006D9DD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(sbyte), "0")]
		public sbyte val
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

		// Token: 0x04001F34 RID: 7988
		private sbyte valField;
	}
}
