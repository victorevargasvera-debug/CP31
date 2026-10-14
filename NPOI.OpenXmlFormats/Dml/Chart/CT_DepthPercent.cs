using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200045E RID: 1118
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DepthPercent
	{
		// Token: 0x06002C9E RID: 11422 RVA: 0x00070D82 File Offset: 0x0006EF82
		public CT_DepthPercent()
		{
			this.valField = 100;
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x00070D92 File Offset: 0x0006EF92
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x00070D9A File Offset: 0x0006EF9A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(ushort), "100")]
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

		// Token: 0x06002CA1 RID: 11425 RVA: 0x00070DA4 File Offset: 0x0006EFA4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DepthPercent Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DepthPercent ct_DepthPercent = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DepthPercent();
			if (node.Attributes["val"] != null)
			{
				ct_DepthPercent.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUShort(node.Attributes["val"]);
			}
			return ct_DepthPercent;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00070DEC File Offset: 0x0006EFEC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			if (this.valField != 100)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			}
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x04001F53 RID: 8019
		private ushort valField;
	}
}
