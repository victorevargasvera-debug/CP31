using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001C2 RID: 450
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TcBorders
	{
		// Token: 0x06001113 RID: 4371 RVA: 0x00038FB8 File Offset: 0x000371B8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcBorders Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcBorders ct_TcBorders = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcBorders();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "top")
				{
					ct_TcBorders.top = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "left")
				{
					ct_TcBorders.left = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bottom")
				{
					ct_TcBorders.bottom = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "right")
				{
					ct_TcBorders.right = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "insideH")
				{
					ct_TcBorders.insideH = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "insideV")
				{
					ct_TcBorders.insideV = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tl2br")
				{
					ct_TcBorders.tl2br = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tr2bl")
				{
					ct_TcBorders.tr2bl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TcBorders;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0003913C File Offset: 0x0003733C
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
			if (this.tl2br != null)
			{
				this.tl2br.Write(sw, "tl2br");
			}
			if (this.tr2bl != null)
			{
				this.tr2bl.Write(sw, "tr2bl");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0003923E File Offset: 0x0003743E
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x00039246 File Offset: 0x00037446
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

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0003924F File Offset: 0x0003744F
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x00039257 File Offset: 0x00037457
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

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x00039260 File Offset: 0x00037460
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x00039268 File Offset: 0x00037468
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

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00039271 File Offset: 0x00037471
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x00039279 File Offset: 0x00037479
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

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x00039282 File Offset: 0x00037482
		// (set) Token: 0x0600111F RID: 4383 RVA: 0x0003928A File Offset: 0x0003748A
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

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x00039293 File Offset: 0x00037493
		// (set) Token: 0x06001121 RID: 4385 RVA: 0x0003929B File Offset: 0x0003749B
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

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x000392A4 File Offset: 0x000374A4
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x000392AC File Offset: 0x000374AC
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border tl2br
		{
			get
			{
				return this.tl2brField;
			}
			set
			{
				this.tl2brField = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x000392B5 File Offset: 0x000374B5
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x000392BD File Offset: 0x000374BD
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border tr2bl
		{
			get
			{
				return this.tr2blField;
			}
			set
			{
				this.tr2blField = value;
			}
		}

		// Token: 0x04000D67 RID: 3431
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border topField;

		// Token: 0x04000D68 RID: 3432
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border leftField;

		// Token: 0x04000D69 RID: 3433
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bottomField;

		// Token: 0x04000D6A RID: 3434
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border rightField;

		// Token: 0x04000D6B RID: 3435
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border insideHField;

		// Token: 0x04000D6C RID: 3436
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border insideVField;

		// Token: 0x04000D6D RID: 3437
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border tl2brField;

		// Token: 0x04000D6E RID: 3438
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border tr2blField;
	}
}
