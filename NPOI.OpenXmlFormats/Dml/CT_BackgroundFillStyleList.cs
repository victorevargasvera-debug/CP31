using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000285 RID: 645
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BackgroundFillStyleList
	{
		// Token: 0x06001AAA RID: 6826 RVA: 0x000485A0 File Offset: 0x000467A0
		public static global::NPOI.OpenXmlFormats.Dml.CT_BackgroundFillStyleList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_BackgroundFillStyleList ct_BackgroundFillStyleList = new global::NPOI.OpenXmlFormats.Dml.CT_BackgroundFillStyleList();
			ct_BackgroundFillStyleList.blipFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties>();
			ct_BackgroundFillStyleList.gradFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties>();
			ct_BackgroundFillStyleList.grpFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties>();
			ct_BackgroundFillStyleList.noFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties>();
			ct_BackgroundFillStyleList.pattFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties>();
			ct_BackgroundFillStyleList.solidFill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "blipFill")
				{
					ct_BackgroundFillStyleList.blipFill.Add(global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "gradFill")
				{
					ct_BackgroundFillStyleList.gradFill.Add(global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "grpFill")
				{
					ct_BackgroundFillStyleList.grpFill.Add(new global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties());
				}
				else if (xmlNode.LocalName == "noFill")
				{
					ct_BackgroundFillStyleList.noFill.Add(new global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties());
				}
				else if (xmlNode.LocalName == "pattFill")
				{
					ct_BackgroundFillStyleList.pattFill.Add(global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "solidFill")
				{
					ct_BackgroundFillStyleList.solidFill.Add(global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_BackgroundFillStyleList;
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00048738 File Offset: 0x00046938
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
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
			if (this.blipFill != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties ct_BlipFillProperties in this.blipFill)
				{
					ct_BlipFillProperties.Write(sw, "a:blipFill");
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
					sw.Write("<noFill/>");
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

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x00048948 File Offset: 0x00046B48
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x00048950 File Offset: 0x00046B50
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

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x00048959 File Offset: 0x00046B59
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x00048961 File Offset: 0x00046B61
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

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x0004896A File Offset: 0x00046B6A
		// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x00048972 File Offset: 0x00046B72
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

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x0004897B File Offset: 0x00046B7B
		// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x00048983 File Offset: 0x00046B83
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

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0004898C File Offset: 0x00046B8C
		// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x00048994 File Offset: 0x00046B94
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

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x0004899D File Offset: 0x00046B9D
		// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x000489A5 File Offset: 0x00046BA5
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

		// Token: 0x040013D5 RID: 5077
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties> blipFillField;

		// Token: 0x040013D6 RID: 5078
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties> gradFillField;

		// Token: 0x040013D7 RID: 5079
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties> grpFillField;

		// Token: 0x040013D8 RID: 5080
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties> noFillField;

		// Token: 0x040013D9 RID: 5081
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties> pattFillField;

		// Token: 0x040013DA RID: 5082
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties> solidFillField;
	}
}
