using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000AE RID: 174
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumPicBullet
	{
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000DC46 File Offset: 0x0000BE46
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000DC4E File Offset: 0x0000BE4E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture pict
		{
			get
			{
				return this.pictField;
			}
			set
			{
				this.pictField = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0000DC57 File Offset: 0x0000BE57
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x0000DC5F File Offset: 0x0000BE5F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string numPicBulletId
		{
			get
			{
				return this.numPicBulletIdField;
			}
			set
			{
				this.numPicBulletIdField = value;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000DC68 File Offset: 0x0000BE68
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPicBullet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPicBullet ct_NumPicBullet = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPicBullet();
			ct_NumPicBullet.numPicBulletId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:numPicBulletId"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pict")
				{
					ct_NumPicBullet.pict = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NumPicBullet;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000DD00 File Offset: 0x0000BF00
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:numPicBulletId", this.numPicBulletId);
			sw.Write(">");
			if (this.pict != null)
			{
				this.pict.Write(sw, "pict");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x04000427 RID: 1063
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture pictField;

		// Token: 0x04000428 RID: 1064
		private string numPicBulletIdField;
	}
}
