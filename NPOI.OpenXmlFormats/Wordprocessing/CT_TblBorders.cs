using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001B4 RID: 436
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblBorders
	{
		// Token: 0x06001081 RID: 4225 RVA: 0x00035C24 File Offset: 0x00033E24
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders ct_TblBorders = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "top")
				{
					ct_TblBorders.top = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "left")
				{
					ct_TblBorders.left = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bottom")
				{
					ct_TblBorders.bottom = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "right")
				{
					ct_TblBorders.right = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "insideH")
				{
					ct_TblBorders.insideH = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "insideV")
				{
					ct_TblBorders.insideV = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TblBorders;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00035D54 File Offset: 0x00033F54
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
			if (this.insideH != null)
			{
				this.insideH.Write(sw, "insideH");
			}
			if (this.insideV != null)
			{
				this.insideV.Write(sw, "insideV");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x00035E24 File Offset: 0x00034024
		// (set) Token: 0x06001084 RID: 4228 RVA: 0x00035E2C File Offset: 0x0003402C
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border top
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

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x00035E35 File Offset: 0x00034035
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x00035E3D File Offset: 0x0003403D
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border left
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

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00035E46 File Offset: 0x00034046
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x00035E4E File Offset: 0x0003404E
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bottom
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

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x00035E57 File Offset: 0x00034057
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x00035E5F File Offset: 0x0003405F
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border right
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

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00035E68 File Offset: 0x00034068
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00035E70 File Offset: 0x00034070
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border insideH
		{
			get
			{
				return this.insideHField;
			}
			set
			{
				this.insideHField = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x00035E79 File Offset: 0x00034079
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x00035E81 File Offset: 0x00034081
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border insideV
		{
			get
			{
				return this.insideVField;
			}
			set
			{
				this.insideVField = value;
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00035E8A File Offset: 0x0003408A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewBottom()
		{
			if (this.bottomField == null)
			{
				this.bottomField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.bottomField;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00035EA5 File Offset: 0x000340A5
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewLeft()
		{
			if (this.leftField == null)
			{
				this.leftField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.leftField;
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00035EC0 File Offset: 0x000340C0
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewRight()
		{
			if (this.rightField == null)
			{
				this.rightField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.rightField;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00035EDB File Offset: 0x000340DB
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewTop()
		{
			if (this.topField == null)
			{
				this.topField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.topField;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00035EF6 File Offset: 0x000340F6
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewInsideH()
		{
			if (this.insideHField == null)
			{
				this.insideHField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.insideHField;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00035F11 File Offset: 0x00034111
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewInsideV()
		{
			if (this.insideVField == null)
			{
				this.insideVField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.insideVField;
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00035F2C File Offset: 0x0003412C
		public bool IsSetInsideH()
		{
			return this.insideH != null;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00035F37 File Offset: 0x00034137
		public bool IsSetInsideV()
		{
			return this.insideV != null;
		}

		// Token: 0x04000D23 RID: 3363
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border topField;

		// Token: 0x04000D24 RID: 3364
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border leftField;

		// Token: 0x04000D25 RID: 3365
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bottomField;

		// Token: 0x04000D26 RID: 3366
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border rightField;

		// Token: 0x04000D27 RID: 3367
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border insideHField;

		// Token: 0x04000D28 RID: 3368
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border insideVField;
	}
}
