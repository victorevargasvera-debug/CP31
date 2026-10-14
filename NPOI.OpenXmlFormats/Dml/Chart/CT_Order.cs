using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000440 RID: 1088
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Order
	{
		// Token: 0x06002B9F RID: 11167 RVA: 0x0006D824 File Offset: 0x0006BA24
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Order Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Order ct_Order = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Order();
			if (node.Attributes["val"] != null)
			{
				ct_Order.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["val"]);
			}
			return ct_Order;
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x0006D86C File Offset: 0x0006BA6C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val, true);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x0006D8B8 File Offset: 0x0006BAB8
		public CT_Order()
		{
			this.valField = 2;
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x0006D8C7 File Offset: 0x0006BAC7
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x0006D8CF File Offset: 0x0006BACF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "2")]
		public byte val
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

		// Token: 0x04001EE4 RID: 7908
		private byte valField;
	}
}
