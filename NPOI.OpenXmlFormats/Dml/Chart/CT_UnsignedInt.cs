using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003FE RID: 1022
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_UnsignedInt
	{
		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x0006701B File Offset: 0x0006521B
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x00067023 File Offset: 0x00065223
		[global::System.Xml.Serialization.XmlAttribute]
		public uint val
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

		// Token: 0x060028E6 RID: 10470 RVA: 0x0006702C File Offset: 0x0006522C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["val"])
			};
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00067053 File Offset: 0x00065253
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val, true);
			sw.Write("/>");
		}

		// Token: 0x04001DA2 RID: 7586
		private uint valField;
	}
}
