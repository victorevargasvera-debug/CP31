using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000461 RID: 1121
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RotX
	{
		// Token: 0x06002CAD RID: 11437 RVA: 0x00070F50 File Offset: 0x0006F150
		public CT_RotX()
		{
			this.valField = 0;
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x00070F5F File Offset: 0x0006F15F
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_RotX Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_RotX
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadSByte(node.Attributes["val"])
			};
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x00070F86 File Offset: 0x0006F186
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x00070FC6 File Offset: 0x0006F1C6
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x00070FCE File Offset: 0x0006F1CE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(sbyte), "0")]
		public sbyte val
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

		// Token: 0x04001F56 RID: 8022
		private sbyte valField;
	}
}
