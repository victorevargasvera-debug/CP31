using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000270 RID: 624
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextBlipBullet
	{
		// Token: 0x0600198A RID: 6538 RVA: 0x00045BA4 File Offset: 0x00043DA4
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextBlipBullet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextBlipBullet ct_TextBlipBullet = new global::NPOI.OpenXmlFormats.Dml.CT_TextBlipBullet();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "blip")
				{
					ct_TextBlipBullet.blip = global::NPOI.OpenXmlFormats.Dml.CT_Blip.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TextBlipBullet;
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00045C24 File Offset: 0x00043E24
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.blip != null)
			{
				this.blip.Write(sw, "blip");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00045C77 File Offset: 0x00043E77
		public CT_TextBlipBullet()
		{
			this.blipField = new global::NPOI.OpenXmlFormats.Dml.CT_Blip();
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00045C8A File Offset: 0x00043E8A
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x00045C92 File Offset: 0x00043E92
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Blip blip
		{
			get
			{
				return this.blipField;
			}
			set
			{
				this.blipField = value;
			}
		}

		// Token: 0x0400134C RID: 4940
		private global::NPOI.OpenXmlFormats.Dml.CT_Blip blipField;
	}
}
