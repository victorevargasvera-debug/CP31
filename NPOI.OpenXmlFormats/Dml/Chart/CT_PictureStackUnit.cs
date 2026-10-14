using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000438 RID: 1080
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PictureStackUnit
	{
		// Token: 0x06002B33 RID: 11059 RVA: 0x0006C632 File Offset: 0x0006A832
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureStackUnit Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureStackUnit
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["val"])
			};
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x0006C659 File Offset: 0x0006A859
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x0006C699 File Offset: 0x0006A899
		// (set) Token: 0x06002B36 RID: 11062 RVA: 0x0006C6A1 File Offset: 0x0006A8A1
		[global::System.Xml.Serialization.XmlAttribute]
		public double val
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

		// Token: 0x04001EA6 RID: 7846
		private double valField;
	}
}
