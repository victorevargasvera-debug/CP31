using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000456 RID: 1110
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GapAmount
	{
		// Token: 0x06002C47 RID: 11335 RVA: 0x0006F5BA File Offset: 0x0006D7BA
		public CT_GapAmount()
		{
			this.valField = 150;
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x0006F5D0 File Offset: 0x0006D7D0
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount ct_GapAmount = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount();
			if (node.Attributes["val"] != null)
			{
				ct_GapAmount.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUShort(node.Attributes["val"]);
			}
			return ct_GapAmount;
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x0006F616 File Offset: 0x0006D816
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x0006F656 File Offset: 0x0006D856
		// (set) Token: 0x06002C4B RID: 11339 RVA: 0x0006F65E File Offset: 0x0006D85E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(ushort), "150")]
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

		// Token: 0x04001F2B RID: 7979
		private ushort valField;
	}
}
