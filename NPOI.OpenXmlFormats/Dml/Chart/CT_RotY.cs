using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200045F RID: 1119
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RotY
	{
		// Token: 0x06002CA3 RID: 11427 RVA: 0x00070E41 File Offset: 0x0006F041
		public CT_RotY()
		{
			this.valField = 0;
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x00070E50 File Offset: 0x0006F050
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_RotY Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_RotY
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUShort(node.Attributes["val"])
			};
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x00070E77 File Offset: 0x0006F077
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x00070EB7 File Offset: 0x0006F0B7
		// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x00070EBF File Offset: 0x0006F0BF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(ushort), "0")]
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

		// Token: 0x04001F54 RID: 8020
		private ushort valField;
	}
}
