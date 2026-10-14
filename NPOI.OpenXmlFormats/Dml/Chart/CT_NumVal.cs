using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200044C RID: 1100
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumVal
	{
		// Token: 0x06002BF2 RID: 11250 RVA: 0x0006E644 File Offset: 0x0006C844
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal ct_NumVal = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal();
			if (node.Attributes["idx"] != null)
			{
				ct_NumVal.idx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["idx"]);
			}
			ct_NumVal.formatCode = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["formatCode"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "v")
				{
					ct_NumVal.v = xmlNode.InnerText;
				}
			}
			return ct_NumVal;
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0006E708 File Offset: 0x0006C908
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "idx", this.idx, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "formatCode", this.formatCode);
			sw.Write(">");
			if (this.v != null)
			{
				sw.Write(string.Format("<c:v>{0}</c:v>", this.v));
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x0006E783 File Offset: 0x0006C983
		// (set) Token: 0x06002BF5 RID: 11253 RVA: 0x0006E78B File Offset: 0x0006C98B
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

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x0006E794 File Offset: 0x0006C994
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x0006E79C File Offset: 0x0006C99C
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

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x0006E7A5 File Offset: 0x0006C9A5
		// (set) Token: 0x06002BF9 RID: 11257 RVA: 0x0006E7AD File Offset: 0x0006C9AD
		[global::System.Xml.Serialization.XmlAttribute]
		public string formatCode
		{
			get
			{
				return this.formatCodeField;
			}
			set
			{
				this.formatCodeField = value;
			}
		}

		// Token: 0x04001F0B RID: 7947
		private string vField;

		// Token: 0x04001F0C RID: 7948
		private uint idxField;

		// Token: 0x04001F0D RID: 7949
		private string formatCodeField;
	}
}
