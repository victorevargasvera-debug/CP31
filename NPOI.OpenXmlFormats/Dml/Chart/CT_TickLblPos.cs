using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200041B RID: 1051
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TickLblPos
	{
		// Token: 0x060029F8 RID: 10744 RVA: 0x0006995D File Offset: 0x00067B5D
		public CT_TickLblPos()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickLblPos.nextTo;
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x0006996C File Offset: 0x00067B6C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos ct_TickLblPos = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos();
			if (node.Attributes["val"] != null)
			{
				ct_TickLblPos.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickLblPos)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickLblPos), node.Attributes["val"].Value);
			}
			return ct_TickLblPos;
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000699C8 File Offset: 0x00067BC8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x00069A10 File Offset: 0x00067C10
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x00069A18 File Offset: 0x00067C18
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickLblPos.nextTo)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickLblPos val
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

		// Token: 0x04001E0D RID: 7693
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickLblPos valField;
	}
}
