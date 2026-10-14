using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000161 RID: 353
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PBdr
	{
		// Token: 0x06000AC0 RID: 2752 RVA: 0x00025A70 File Offset: 0x00023C70
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr ct_PBdr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "top")
				{
					ct_PBdr.top = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "left")
				{
					ct_PBdr.left = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bottom")
				{
					ct_PBdr.bottom = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "right")
				{
					ct_PBdr.right = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "between")
				{
					ct_PBdr.between = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bar")
				{
					ct_PBdr.bar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PBdr;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00025BA0 File Offset: 0x00023DA0
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
			if (this.between != null)
			{
				this.between.Write(sw, "between");
			}
			if (this.bar != null)
			{
				this.bar.Write(sw, "bar");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00025C70 File Offset: 0x00023E70
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00025C78 File Offset: 0x00023E78
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00025C81 File Offset: 0x00023E81
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00025C89 File Offset: 0x00023E89
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

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00025C92 File Offset: 0x00023E92
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00025C9A File Offset: 0x00023E9A
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

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00025CA3 File Offset: 0x00023EA3
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00025CAB File Offset: 0x00023EAB
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

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00025CB4 File Offset: 0x00023EB4
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x00025CBC File Offset: 0x00023EBC
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border between
		{
			get
			{
				return this.betweenField;
			}
			set
			{
				this.betweenField = value;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00025CC5 File Offset: 0x00023EC5
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x00025CCD File Offset: 0x00023ECD
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bar
		{
			get
			{
				return this.barField;
			}
			set
			{
				this.barField = value;
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00025CD6 File Offset: 0x00023ED6
		public bool IsSetTop()
		{
			return this.topField != null && this.topField.val != global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none && this.topField.val > global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.nil;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00025CFE File Offset: 0x00023EFE
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewTop()
		{
			if (this.topField == null)
			{
				this.topField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.topField;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00025D19 File Offset: 0x00023F19
		public void UnsetTop()
		{
			this.topField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00025D26 File Offset: 0x00023F26
		public bool IsSetBottom()
		{
			return this.bottomField != null && this.bottomField.val != global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none && this.bottomField.val > global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.nil;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00025D4E File Offset: 0x00023F4E
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewBottom()
		{
			if (this.bottomField == null)
			{
				this.bottomField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.bottomField;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00025D69 File Offset: 0x00023F69
		public void UnsetBottom()
		{
			this.bottomField = null;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00025D72 File Offset: 0x00023F72
		public bool IsSetRight()
		{
			return this.rightField != null && this.rightField.val != global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none && this.rightField.val > global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.nil;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00025D9A File Offset: 0x00023F9A
		public void UnsetRight()
		{
			this.rightField = null;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00025DA3 File Offset: 0x00023FA3
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewRight()
		{
			if (this.rightField == null)
			{
				this.rightField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.rightField;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00025DBE File Offset: 0x00023FBE
		public bool IsSetBetween()
		{
			return this.betweenField != null && this.betweenField.val != global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none && this.betweenField.val > global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.nil;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00025DE6 File Offset: 0x00023FE6
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewBetween()
		{
			if (this.betweenField == null)
			{
				this.betweenField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.betweenField;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00025E01 File Offset: 0x00024001
		public void UnsetBetween()
		{
			this.betweenField = null;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00025E0A File Offset: 0x0002400A
		public bool IsSetLeft()
		{
			return this.leftField != null && this.leftField.val != global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none && this.leftField.val > global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.nil;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00025E32 File Offset: 0x00024032
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border AddNewLeft()
		{
			if (this.leftField == null)
			{
				this.leftField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			}
			return this.leftField;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00025E4D File Offset: 0x0002404D
		public void UnsetLeft()
		{
			this.leftField = null;
		}

		// Token: 0x04000A12 RID: 2578
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border topField;

		// Token: 0x04000A13 RID: 2579
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border leftField;

		// Token: 0x04000A14 RID: 2580
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bottomField;

		// Token: 0x04000A15 RID: 2581
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border rightField;

		// Token: 0x04000A16 RID: 2582
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border betweenField;

		// Token: 0x04000A17 RID: 2583
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border barField;
	}
}
