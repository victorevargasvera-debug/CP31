using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003CC RID: 972
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SizeRepresents
	{
		// Token: 0x0600264D RID: 9805 RVA: 0x0005F76E File Offset: 0x0005D96E
		public CT_SizeRepresents()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_SizeRepresents.area;
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x0005F780 File Offset: 0x0005D980
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_SizeRepresents Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_SizeRepresents ct_SizeRepresents = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_SizeRepresents();
			if (node.Attributes["val"] != null)
			{
				ct_SizeRepresents.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_SizeRepresents)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_SizeRepresents), node.Attributes["val"].Value);
			}
			return ct_SizeRepresents;
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x0005F7DC File Offset: 0x0005D9DC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x0005F835 File Offset: 0x0005DA35
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x0005F83D File Offset: 0x0005DA3D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_SizeRepresents.area)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_SizeRepresents val
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

		// Token: 0x04001C8A RID: 7306
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_SizeRepresents valField;
	}
}
