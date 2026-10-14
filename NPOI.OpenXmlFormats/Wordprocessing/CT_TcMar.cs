using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001C3 RID: 451
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TcMar
	{
		// Token: 0x06001127 RID: 4391 RVA: 0x000392C8 File Offset: 0x000374C8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcMar Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcMar ct_TcMar = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcMar();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "top")
				{
					ct_TcMar.top = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "left")
				{
					ct_TcMar.left = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bottom")
				{
					ct_TcMar.bottom = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "right")
				{
					ct_TcMar.right = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TcMar;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x000393B0 File Offset: 0x000375B0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.top != null)
			{
				this.top.Write(sw, "top");
			}
			if (this.left != null)
			{
				this.left.Write(sw, "left");
			}
			if (this.bottom != null)
			{
				this.bottom.Write(sw, "bottom");
			}
			if (this.right != null)
			{
				this.right.Write(sw, "right");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0003944E File Offset: 0x0003764E
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x00039456 File Offset: 0x00037656
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth top
		{
			get
			{
				return this.topField;
			}
			set
			{
				this.topField = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0003945F File Offset: 0x0003765F
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x00039467 File Offset: 0x00037667
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth left
		{
			get
			{
				return this.leftField;
			}
			set
			{
				this.leftField = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00039470 File Offset: 0x00037670
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x00039478 File Offset: 0x00037678
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth bottom
		{
			get
			{
				return this.bottomField;
			}
			set
			{
				this.bottomField = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x00039481 File Offset: 0x00037681
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x00039489 File Offset: 0x00037689
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth right
		{
			get
			{
				return this.rightField;
			}
			set
			{
				this.rightField = value;
			}
		}

		// Token: 0x04000D6F RID: 3439
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth topField;

		// Token: 0x04000D70 RID: 3440
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth leftField;

		// Token: 0x04000D71 RID: 3441
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth bottomField;

		// Token: 0x04000D72 RID: 3442
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth rightField;
	}
}
