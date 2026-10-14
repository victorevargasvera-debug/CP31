using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000448 RID: 1096
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ErrValType
	{
		// Token: 0x06002BD7 RID: 11223 RVA: 0x0006E175 File Offset: 0x0006C375
		public CT_ErrValType()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrValType.fixedVal;
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x0006E184 File Offset: 0x0006C384
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrValType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrValType ct_ErrValType = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrValType();
			if (node.Attributes["val"] != null)
			{
				ct_ErrValType.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrValType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrValType), node.Attributes["val"].Value);
			}
			return ct_ErrValType;
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x0006E1E0 File Offset: 0x0006C3E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x0006E239 File Offset: 0x0006C439
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x0006E241 File Offset: 0x0006C441
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrValType.fixedVal)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrValType val
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

		// Token: 0x04001EFE RID: 7934
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_ErrValType valField;
	}
}
