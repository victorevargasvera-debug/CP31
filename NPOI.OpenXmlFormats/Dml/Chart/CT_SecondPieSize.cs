using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000453 RID: 1107
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SecondPieSize
	{
		// Token: 0x06002C3D RID: 11325 RVA: 0x0006F43C File Offset: 0x0006D63C
		public CT_SecondPieSize()
		{
			this.valField = 75;
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x0006F44C File Offset: 0x0006D64C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_SecondPieSize Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_SecondPieSize ct_SecondPieSize = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_SecondPieSize();
			if (node.Attributes["val"] != null)
			{
				ct_SecondPieSize.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUShort(node.Attributes["val"]);
			}
			return ct_SecondPieSize;
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x0006F492 File Offset: 0x0006D692
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06002C40 RID: 11328 RVA: 0x0006F4D2 File Offset: 0x0006D6D2
		// (set) Token: 0x06002C41 RID: 11329 RVA: 0x0006F4DA File Offset: 0x0006D6DA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(ushort), "75")]
		public ushort val
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

		// Token: 0x04001F23 RID: 7971
		private ushort valField;
	}
}
