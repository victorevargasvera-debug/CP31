using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200045D RID: 1117
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Perspective
	{
		// Token: 0x06002C99 RID: 11417 RVA: 0x00070CC3 File Offset: 0x0006EEC3
		public CT_Perspective()
		{
			this.valField = 30;
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x00070CD4 File Offset: 0x0006EED4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Perspective Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Perspective ct_Perspective = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Perspective();
			if (node.Attributes["val"] != null)
			{
				ct_Perspective.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["val"]);
			}
			return ct_Perspective;
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x00070D1C File Offset: 0x0006EF1C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			if (this.val != 30)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			}
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x00070D71 File Offset: 0x0006EF71
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x00070D79 File Offset: 0x0006EF79
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "30")]
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

		// Token: 0x04001F52 RID: 8018
		private byte valField;
	}
}
