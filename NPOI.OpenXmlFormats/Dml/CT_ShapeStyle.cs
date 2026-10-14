using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002F5 RID: 757
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ShapeStyle
	{
		// Token: 0x06001D51 RID: 7505 RVA: 0x0004F920 File Offset: 0x0004DB20
		public static global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle ct_ShapeStyle = new global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "lnRef")
				{
					ct_ShapeStyle.lnRef = global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fillRef")
				{
					ct_ShapeStyle.fillRef = global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effectRef")
				{
					ct_ShapeStyle.effectRef = global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fontRef")
				{
					ct_ShapeStyle.fontRef = global::NPOI.OpenXmlFormats.Dml.CT_FontReference.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ShapeStyle;
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x0004FA08 File Offset: 0x0004DC08
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.lnRef != null)
			{
				this.lnRef.Write(sw, "lnRef");
			}
			if (this.fillRef != null)
			{
				this.fillRef.Write(sw, "fillRef");
			}
			if (this.effectRef != null)
			{
				this.effectRef.Write(sw, "effectRef");
			}
			if (this.fontRef != null)
			{
				this.fontRef.Write(sw, "fontRef");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x0004FAA6 File Offset: 0x0004DCA6
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference AddNewFillRef()
		{
			this.fillRefField = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference();
			return this.fillRefField;
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x0004FAB9 File Offset: 0x0004DCB9
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference AddNewLnRef()
		{
			this.lnRefField = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference();
			return this.lnRefField;
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x0004FACC File Offset: 0x0004DCCC
		public global::NPOI.OpenXmlFormats.Dml.CT_FontReference AddNewFontRef()
		{
			this.fontRefField = new global::NPOI.OpenXmlFormats.Dml.CT_FontReference();
			return this.fontRefField;
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x0004FADF File Offset: 0x0004DCDF
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference AddNewEffectRef()
		{
			this.effectRefField = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference();
			return this.effectRefField;
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x0004FAF2 File Offset: 0x0004DCF2
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x0004FAFA File Offset: 0x0004DCFA
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference lnRef
		{
			get
			{
				return this.lnRefField;
			}
			set
			{
				this.lnRefField = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0004FB03 File Offset: 0x0004DD03
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x0004FB0B File Offset: 0x0004DD0B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference fillRef
		{
			get
			{
				return this.fillRefField;
			}
			set
			{
				this.fillRefField = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x0004FB14 File Offset: 0x0004DD14
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x0004FB1C File Offset: 0x0004DD1C
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference effectRef
		{
			get
			{
				return this.effectRefField;
			}
			set
			{
				this.effectRefField = value;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x0004FB25 File Offset: 0x0004DD25
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x0004FB2D File Offset: 0x0004DD2D
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FontReference fontRef
		{
			get
			{
				return this.fontRefField;
			}
			set
			{
				this.fontRefField = value;
			}
		}

		// Token: 0x04001782 RID: 6018
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference lnRefField;

		// Token: 0x04001783 RID: 6019
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference fillRefField;

		// Token: 0x04001784 RID: 6020
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference effectRefField;

		// Token: 0x04001785 RID: 6021
		private global::NPOI.OpenXmlFormats.Dml.CT_FontReference fontRefField;
	}
}
