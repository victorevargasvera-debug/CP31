using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000276 RID: 630
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextUnderlineFillGroupWrapper
	{
		// Token: 0x060019A6 RID: 6566 RVA: 0x00045F68 File Offset: 0x00044168
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineFillGroupWrapper Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineFillGroupWrapper ct_TextUnderlineFillGroupWrapper = new global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineFillGroupWrapper();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "noFill")
				{
					ct_TextUnderlineFillGroupWrapper.noFill = new global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties();
				}
				else if (xmlNode.LocalName == "solidFill")
				{
					ct_TextUnderlineFillGroupWrapper.solidFill = global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gradFill")
				{
					ct_TextUnderlineFillGroupWrapper.gradFill = global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "blipFill")
				{
					ct_TextUnderlineFillGroupWrapper.blipFill = global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pattFill")
				{
					ct_TextUnderlineFillGroupWrapper.pattFill = global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grpFill")
				{
					ct_TextUnderlineFillGroupWrapper.grpFill = new global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties();
				}
			}
			return ct_TextUnderlineFillGroupWrapper;
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00046094 File Offset: 0x00044294
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.noFill != null)
			{
				sw.Write("<a:noFill/>");
			}
			if (this.solidFill != null)
			{
				this.solidFill.Write(sw, "solidFill");
			}
			if (this.gradFill != null)
			{
				this.gradFill.Write(sw, "gradFill");
			}
			if (this.blipFill != null)
			{
				this.blipFill.Write(sw, "a:blipFill");
			}
			if (this.pattFill != null)
			{
				this.pattFill.Write(sw, "pattFill");
			}
			if (this.grpFill != null)
			{
				sw.Write("<a:grpFill/>");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x00046158 File Offset: 0x00044358
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x00046160 File Offset: 0x00044360
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFill
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

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x00046169 File Offset: 0x00044369
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x00046171 File Offset: 0x00044371
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFill
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

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x0004617A File Offset: 0x0004437A
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x00046182 File Offset: 0x00044382
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFill
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

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x0004618B File Offset: 0x0004438B
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x00046193 File Offset: 0x00044393
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFill
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x0004619C File Offset: 0x0004439C
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x000461A4 File Offset: 0x000443A4
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFill
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

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x000461AD File Offset: 0x000443AD
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x000461B5 File Offset: 0x000443B5
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFill
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

		// Token: 0x04001353 RID: 4947
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x04001354 RID: 4948
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;

		// Token: 0x04001355 RID: 4949
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x04001356 RID: 4950
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x04001357 RID: 4951
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x04001358 RID: 4952
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;
	}
}
