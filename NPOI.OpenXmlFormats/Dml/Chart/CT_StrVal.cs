using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000417 RID: 1047
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_StrVal
	{
		// Token: 0x060029E5 RID: 10725 RVA: 0x000696B4 File Offset: 0x000678B4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal ct_StrVal = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal();
			ct_StrVal.idx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["idx"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "v")
				{
					ct_StrVal.v = xmlNode.InnerText;
				}
			}
			return ct_StrVal;
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x0006974C File Offset: 0x0006794C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "idx", this.idx, true);
			sw.Write(">");
			if (this.v != null)
			{
				sw.Write(string.Format("<c:v>{0}</c:v>", this.v));
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x000697B6 File Offset: 0x000679B6
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x000697BE File Offset: 0x000679BE
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public string v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x000697C7 File Offset: 0x000679C7
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x000697CF File Offset: 0x000679CF
		[global::System.Xml.Serialization.XmlAttribute]
		public uint idx
		{
			get
			{
				return this.idxField;
			}
			set
			{
				this.idxField = value;
			}
		}

		// Token: 0x04001E03 RID: 7683
		private string vField;

		// Token: 0x04001E04 RID: 7684
		private uint idxField;
	}
}
