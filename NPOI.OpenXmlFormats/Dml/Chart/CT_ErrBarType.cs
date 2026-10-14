using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000446 RID: 1094
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ErrBarType
	{
		// Token: 0x06002BD2 RID: 11218 RVA: 0x0006E0A0 File Offset: 0x0006C2A0
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBarType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBarType ct_ErrBarType = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBarType();
			if (node.Attributes["val"] != null)
			{
				ct_ErrBarType.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrBarType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrBarType), node.Attributes["val"].Value);
			}
			return ct_ErrBarType;
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x0006E0FC File Offset: 0x0006C2FC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x0006E155 File Offset: 0x0006C355
		public CT_ErrBarType()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrBarType.both;
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x0006E164 File Offset: 0x0006C364
		// (set) Token: 0x06002BD6 RID: 11222 RVA: 0x0006E16C File Offset: 0x0006C36C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrBarType.both)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrBarType val
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

		// Token: 0x04001EF9 RID: 7929
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrBarType valField;
	}
}
