using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000467 RID: 1127
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Style
	{
		// Token: 0x06002D0C RID: 11532 RVA: 0x00071F07 File Offset: 0x00070107
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Style Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Style
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["val"])
			};
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x00071F2E File Offset: 0x0007012E
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x00071F6E File Offset: 0x0007016E
		// (set) Token: 0x06002D0F RID: 11535 RVA: 0x00071F76 File Offset: 0x00070176
		[global::System.Xml.Serialization.XmlAttribute]
		public byte val
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

		// Token: 0x04001F79 RID: 8057
		private byte valField;
	}
}
