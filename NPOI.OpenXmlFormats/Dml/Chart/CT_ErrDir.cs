using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000444 RID: 1092
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ErrDir
	{
		// Token: 0x06002BCD RID: 11213 RVA: 0x0006DFD8 File Offset: 0x0006C1D8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrDir Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrDir ct_ErrDir = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrDir();
			if (node.Attributes["val"] != null)
			{
				ct_ErrDir.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrDir)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrDir), node.Attributes["val"].Value);
			}
			return ct_ErrDir;
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x0006E034 File Offset: 0x0006C234
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x0006E08D File Offset: 0x0006C28D
		// (set) Token: 0x06002BD0 RID: 11216 RVA: 0x0006E095 File Offset: 0x0006C295
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrDir val
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

		// Token: 0x04001EF5 RID: 7925
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrDir valField;
	}
}
