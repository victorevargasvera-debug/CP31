using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000460 RID: 1120
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_HPercent
	{
		// Token: 0x06002CA8 RID: 11432 RVA: 0x00070EC8 File Offset: 0x0006F0C8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_HPercent Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_HPercent
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUShort(node.Attributes["val"])
			};
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x00070EEF File Offset: 0x0006F0EF
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x00070F2F File Offset: 0x0006F12F
		public CT_HPercent()
		{
			this.valField = 100;
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x00070F3F File Offset: 0x0006F13F
		// (set) Token: 0x06002CAC RID: 11436 RVA: 0x00070F47 File Offset: 0x0006F147
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

		// Token: 0x04001F55 RID: 8021
		private ushort valField;
	}
}
