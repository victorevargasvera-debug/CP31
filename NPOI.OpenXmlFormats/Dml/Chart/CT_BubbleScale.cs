using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003CE RID: 974
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BubbleScale
	{
		// Token: 0x06002652 RID: 9810 RVA: 0x0005F846 File Offset: 0x0005DA46
		public CT_BubbleScale()
		{
			this.valField = 100U;
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x0005F858 File Offset: 0x0005DA58
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleScale Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleScale ct_BubbleScale = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleScale();
			if (node.Attributes["val"] != null)
			{
				ct_BubbleScale.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["val"]);
			}
			return ct_BubbleScale;
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x0005F8A0 File Offset: 0x0005DAA0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val, false);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x0005F8EC File Offset: 0x0005DAEC
		// (set) Token: 0x06002656 RID: 9814 RVA: 0x0005F8F4 File Offset: 0x0005DAF4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "100")]
		public uint val
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

		// Token: 0x04001C8E RID: 7310
		private uint valField;
	}
}
