using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000441 RID: 1089
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Period
	{
		// Token: 0x06002BA4 RID: 11172 RVA: 0x0006D8D8 File Offset: 0x0006BAD8
		public CT_Period()
		{
			this.valField = 2;
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x0006D8E8 File Offset: 0x0006BAE8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Period Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Period ct_Period = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Period();
			if (node.Attributes["val"] != null)
			{
				ct_Period.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["val"]);
			}
			return ct_Period;
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x0006D92E File Offset: 0x0006BB2E
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x0006D96E File Offset: 0x0006BB6E
		// (set) Token: 0x06002BA8 RID: 11176 RVA: 0x0006D976 File Offset: 0x0006BB76
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

		// Token: 0x04001EE5 RID: 7909
		private byte valField;
	}
}
