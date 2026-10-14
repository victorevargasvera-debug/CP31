using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000457 RID: 1111
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Shape
	{
		// Token: 0x06002C4C RID: 11340 RVA: 0x0006F667 File Offset: 0x0006D867
		public CT_Shape()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_Shape.box;
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x0006F678 File Offset: 0x0006D878
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Shape Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Shape ct_Shape = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Shape();
			if (node.Attributes["val"] != null)
			{
				ct_Shape.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_Shape)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_Shape), node.Attributes["val"].Value);
			}
			return ct_Shape;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x0006F6D4 File Offset: 0x0006D8D4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x0006F72D File Offset: 0x0006D92D
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x0006F735 File Offset: 0x0006D935
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_Shape.box)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_Shape val
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

		// Token: 0x04001F2C RID: 7980
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_Shape valField;
	}
}
