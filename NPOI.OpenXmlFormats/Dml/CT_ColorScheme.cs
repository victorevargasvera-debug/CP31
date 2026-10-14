using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200027B RID: 635
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorScheme
	{
		// Token: 0x06001A35 RID: 6709 RVA: 0x000470F8 File Offset: 0x000452F8
		public static global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme ct_ColorScheme = new global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme();
			ct_ColorScheme.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dk1")
				{
					ct_ColorScheme.dk1 = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lt1")
				{
					ct_ColorScheme.lt1 = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dk2")
				{
					ct_ColorScheme.dk2 = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lt2")
				{
					ct_ColorScheme.lt2 = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "accent1")
				{
					ct_ColorScheme.accent1 = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "accent2")
				{
					ct_ColorScheme.accent2 = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "accent3")
				{
					ct_ColorScheme.accent3 = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "accent4")
				{
					ct_ColorScheme.accent4 = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "accent5")
				{
					ct_ColorScheme.accent5 = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "accent6")
				{
					ct_ColorScheme.accent6 = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hlink")
				{
					ct_ColorScheme.hlink = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "folHlink")
				{
					ct_ColorScheme.folHlink = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ColorScheme.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ColorScheme;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0004734C File Offset: 0x0004554C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			sw.Write(">");
			if (this.dk1 != null)
			{
				this.dk1.Write(sw, "dk1");
			}
			if (this.lt1 != null)
			{
				this.lt1.Write(sw, "lt1");
			}
			if (this.dk2 != null)
			{
				this.dk2.Write(sw, "dk2");
			}
			if (this.lt2 != null)
			{
				this.lt2.Write(sw, "lt2");
			}
			if (this.accent1 != null)
			{
				this.accent1.Write(sw, "accent1");
			}
			if (this.accent2 != null)
			{
				this.accent2.Write(sw, "accent2");
			}
			if (this.accent3 != null)
			{
				this.accent3.Write(sw, "accent3");
			}
			if (this.accent4 != null)
			{
				this.accent4.Write(sw, "accent4");
			}
			if (this.accent5 != null)
			{
				this.accent5.Write(sw, "accent5");
			}
			if (this.accent6 != null)
			{
				this.accent6.Write(sw, "accent6");
			}
			if (this.hlink != null)
			{
				this.hlink.Write(sw, "hlink");
			}
			if (this.folHlink != null)
			{
				this.folHlink.Write(sw, "folHlink");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x000474DC File Offset: 0x000456DC
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x000474E4 File Offset: 0x000456E4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color dk1
		{
			get
			{
				return this.dk1Field;
			}
			set
			{
				this.dk1Field = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x000474ED File Offset: 0x000456ED
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x000474F5 File Offset: 0x000456F5
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color lt1
		{
			get
			{
				return this.lt1Field;
			}
			set
			{
				this.lt1Field = value;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x000474FE File Offset: 0x000456FE
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x00047506 File Offset: 0x00045706
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color dk2
		{
			get
			{
				return this.dk2Field;
			}
			set
			{
				this.dk2Field = value;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x0004750F File Offset: 0x0004570F
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x00047517 File Offset: 0x00045717
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color lt2
		{
			get
			{
				return this.lt2Field;
			}
			set
			{
				this.lt2Field = value;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x00047520 File Offset: 0x00045720
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x00047528 File Offset: 0x00045728
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color accent1
		{
			get
			{
				return this.accent1Field;
			}
			set
			{
				this.accent1Field = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x00047531 File Offset: 0x00045731
		// (set) Token: 0x06001A42 RID: 6722 RVA: 0x00047539 File Offset: 0x00045739
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color accent2
		{
			get
			{
				return this.accent2Field;
			}
			set
			{
				this.accent2Field = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00047542 File Offset: 0x00045742
		// (set) Token: 0x06001A44 RID: 6724 RVA: 0x0004754A File Offset: 0x0004574A
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color accent3
		{
			get
			{
				return this.accent3Field;
			}
			set
			{
				this.accent3Field = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00047553 File Offset: 0x00045753
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x0004755B File Offset: 0x0004575B
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color accent4
		{
			get
			{
				return this.accent4Field;
			}
			set
			{
				this.accent4Field = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x00047564 File Offset: 0x00045764
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0004756C File Offset: 0x0004576C
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color accent5
		{
			get
			{
				return this.accent5Field;
			}
			set
			{
				this.accent5Field = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x00047575 File Offset: 0x00045775
		// (set) Token: 0x06001A4A RID: 6730 RVA: 0x0004757D File Offset: 0x0004577D
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color accent6
		{
			get
			{
				return this.accent6Field;
			}
			set
			{
				this.accent6Field = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x00047586 File Offset: 0x00045786
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x0004758E File Offset: 0x0004578E
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color hlink
		{
			get
			{
				return this.hlinkField;
			}
			set
			{
				this.hlinkField = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x00047597 File Offset: 0x00045797
		// (set) Token: 0x06001A4E RID: 6734 RVA: 0x0004759F File Offset: 0x0004579F
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color folHlink
		{
			get
			{
				return this.folHlinkField;
			}
			set
			{
				this.folHlinkField = value;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x000475A8 File Offset: 0x000457A8
		// (set) Token: 0x06001A50 RID: 6736 RVA: 0x000475B0 File Offset: 0x000457B0
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x000475B9 File Offset: 0x000457B9
		// (set) Token: 0x06001A52 RID: 6738 RVA: 0x000475C1 File Offset: 0x000457C1
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x040013A8 RID: 5032
		private global::NPOI.OpenXmlFormats.Dml.CT_Color dk1Field;

		// Token: 0x040013A9 RID: 5033
		private global::NPOI.OpenXmlFormats.Dml.CT_Color lt1Field;

		// Token: 0x040013AA RID: 5034
		private global::NPOI.OpenXmlFormats.Dml.CT_Color dk2Field;

		// Token: 0x040013AB RID: 5035
		private global::NPOI.OpenXmlFormats.Dml.CT_Color lt2Field;

		// Token: 0x040013AC RID: 5036
		private global::NPOI.OpenXmlFormats.Dml.CT_Color accent1Field;

		// Token: 0x040013AD RID: 5037
		private global::NPOI.OpenXmlFormats.Dml.CT_Color accent2Field;

		// Token: 0x040013AE RID: 5038
		private global::NPOI.OpenXmlFormats.Dml.CT_Color accent3Field;

		// Token: 0x040013AF RID: 5039
		private global::NPOI.OpenXmlFormats.Dml.CT_Color accent4Field;

		// Token: 0x040013B0 RID: 5040
		private global::NPOI.OpenXmlFormats.Dml.CT_Color accent5Field;

		// Token: 0x040013B1 RID: 5041
		private global::NPOI.OpenXmlFormats.Dml.CT_Color accent6Field;

		// Token: 0x040013B2 RID: 5042
		private global::NPOI.OpenXmlFormats.Dml.CT_Color hlinkField;

		// Token: 0x040013B3 RID: 5043
		private global::NPOI.OpenXmlFormats.Dml.CT_Color folHlinkField;

		// Token: 0x040013B4 RID: 5044
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040013B5 RID: 5045
		private string nameField;
	}
}
