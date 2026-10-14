using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000423 RID: 1059
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LblOffset
	{
		// Token: 0x06002A4A RID: 10826 RVA: 0x0006A521 File Offset: 0x00068721
		public CT_LblOffset()
		{
			this.valField = 100;
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x0006A534 File Offset: 0x00068734
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblOffset Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblOffset ct_LblOffset = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblOffset();
			if (node.Attributes["val"] != null)
			{
				ct_LblOffset.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUShort(node.Attributes["val"]);
			}
			return ct_LblOffset;
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x0006A57A File Offset: 0x0006877A
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x0006A5BA File Offset: 0x000687BA
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x0006A5C2 File Offset: 0x000687C2
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

		// Token: 0x04001E36 RID: 7734
		private ushort valField;
	}
}
