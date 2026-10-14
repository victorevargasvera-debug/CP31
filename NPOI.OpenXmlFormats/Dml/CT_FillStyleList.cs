using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000282 RID: 642
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FillStyleList
	{
		// Token: 0x06001A92 RID: 6802 RVA: 0x00047F3C File Offset: 0x0004613C
		public static global::NPOI.OpenXmlFormats.Dml.CT_FillStyleList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_FillStyleList ct_FillStyleList = new global::NPOI.OpenXmlFormats.Dml.CT_FillStyleList();
			ct_FillStyleList.blipFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties>();
			ct_FillStyleList.gradFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties>();
			ct_FillStyleList.grpFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties>();
			ct_FillStyleList.noFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties>();
			ct_FillStyleList.pattFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties>();
			ct_FillStyleList.solidFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "solidFill")
				{
					ct_FillStyleList.solidFill.Add(global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "blipFill")
				{
					ct_FillStyleList.blipFill.Add(global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "gradFill")
				{
					ct_FillStyleList.gradFill.Add(global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "grpFill")
				{
					ct_FillStyleList.grpFill.Add(new global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties());
				}
				else if (xmlNode.LocalName == "noFill")
				{
					ct_FillStyleList.noFill.Add(new global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties());
				}
				else if (xmlNode.LocalName == "pattFill")
				{
					ct_FillStyleList.pattFill.Add(global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_FillStyleList;
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000480D4 File Offset: 0x000462D4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.blipFill != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties ct_BlipFillProperties in this.blipFill)
				{
					ct_BlipFillProperties.Write(sw, "a:blipFill");
				}
			}
			if (this.solidFill != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties ct_SolidColorFillProperties in this.solidFill)
				{
					ct_SolidColorFillProperties.Write(sw, "solidFill");
				}
			}
			if (this.gradFill != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties ct_GradientFillProperties in this.gradFill)
				{
					ct_GradientFillProperties.Write(sw, "gradFill");
				}
			}
			if (this.grpFill != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties ct_GroupFillProperties in this.grpFill)
				{
					sw.Write("<a:grpFill/>");
				}
			}
			if (this.noFill != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties ct_NoFillProperties in this.noFill)
				{
					sw.Write("<a:noFill/>");
				}
			}
			if (this.pattFill != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties ct_PatternFillProperties in this.pattFill)
				{
					ct_PatternFillProperties.Write(sw, "pattFill");
				}
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x000482E4 File Offset: 0x000464E4
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x000482EC File Offset: 0x000464EC
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties> blipFill
		{
			get
			{
				return this.blipFillField;
			}
			set
			{
				this.blipFillField = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x000482F5 File Offset: 0x000464F5
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x000482FD File Offset: 0x000464FD
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties> gradFill
		{
			get
			{
				return this.gradFillField;
			}
			set
			{
				this.gradFillField = value;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x00048306 File Offset: 0x00046506
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x0004830E File Offset: 0x0004650E
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties> grpFill
		{
			get
			{
				return this.grpFillField;
			}
			set
			{
				this.grpFillField = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x00048317 File Offset: 0x00046517
		// (set) Token: 0x06001A9B RID: 6811 RVA: 0x0004831F File Offset: 0x0004651F
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties> noFill
		{
			get
			{
				return this.noFillField;
			}
			set
			{
				this.noFillField = value;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x00048328 File Offset: 0x00046528
		// (set) Token: 0x06001A9D RID: 6813 RVA: 0x00048330 File Offset: 0x00046530
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties> pattFill
		{
			get
			{
				return this.pattFillField;
			}
			set
			{
				this.pattFillField = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x00048339 File Offset: 0x00046539
		// (set) Token: 0x06001A9F RID: 6815 RVA: 0x00048341 File Offset: 0x00046541
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties> solidFill
		{
			get
			{
				return this.solidFillField;
			}
			set
			{
				this.solidFillField = value;
			}
		}

		// Token: 0x040013CD RID: 5069
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties> blipFillField;

		// Token: 0x040013CE RID: 5070
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties> gradFillField;

		// Token: 0x040013CF RID: 5071
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties> grpFillField;

		// Token: 0x040013D0 RID: 5072
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties> noFillField;

		// Token: 0x040013D1 RID: 5073
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties> pattFillField;

		// Token: 0x040013D2 RID: 5074
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties> solidFillField;
	}
}
