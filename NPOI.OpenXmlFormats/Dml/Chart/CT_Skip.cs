using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200041F RID: 1055
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Skip
	{
		// Token: 0x06002A02 RID: 10754 RVA: 0x00069AEC File Offset: 0x00067CEC
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip ct_Skip = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip();
			if (node.Attributes["val"] != null)
			{
				ct_Skip.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUShort(node.Attributes["val"]);
			}
			return ct_Skip;
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00069B32 File Offset: 0x00067D32
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x00069B72 File Offset: 0x00067D72
		// (set) Token: 0x06002A05 RID: 10757 RVA: 0x00069B7A File Offset: 0x00067D7A
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x04001E18 RID: 7704
		private ushort valField;
	}
}
