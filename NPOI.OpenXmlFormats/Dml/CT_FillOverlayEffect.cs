using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200031D RID: 797
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FillOverlayEffect
	{
		// Token: 0x06001FB9 RID: 8121 RVA: 0x00054B84 File Offset: 0x00052D84
		public static global::NPOI.OpenXmlFormats.Dml.CT_FillOverlayEffect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_FillOverlayEffect ct_FillOverlayEffect = new global::NPOI.OpenXmlFormats.Dml.CT_FillOverlayEffect();
			if (node.Attributes["blend"] != null)
			{
				ct_FillOverlayEffect.blend = (global::NPOI.OpenXmlFormats.Dml.ST_BlendMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_BlendMode), node.Attributes["blend"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "noFill")
				{
					ct_FillOverlayEffect.noFill = new global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties();
				}
				else if (xmlNode.LocalName == "solidFill")
				{
					ct_FillOverlayEffect.solidFill = global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gradFill")
				{
					ct_FillOverlayEffect.gradFill = global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "blipFill")
				{
					ct_FillOverlayEffect.blipFill = global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pattFill")
				{
					ct_FillOverlayEffect.pattFill = global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grpFill")
				{
					ct_FillOverlayEffect.grpFill = new global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties();
				}
			}
			return ct_FillOverlayEffect;
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00054CF0 File Offset: 0x00052EF0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "blend", this.blend.ToString());
			sw.Write(">");
			if (this.noFill != null)
			{
				sw.Write("<a:noFill/>");
			}
			if (this.gradFill != null)
			{
				this.gradFill.Write(sw, "gradFill");
			}
			if (this.solidFill != null)
			{
				this.solidFill.Write(sw, "solidFill");
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

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x00054DD3 File Offset: 0x00052FD3
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00054DDB File Offset: 0x00052FDB
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x00054DE4 File Offset: 0x00052FE4
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x00054DEC File Offset: 0x00052FEC
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x00054DF5 File Offset: 0x00052FF5
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x00054DFD File Offset: 0x00052FFD
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00054E06 File Offset: 0x00053006
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x00054E0E File Offset: 0x0005300E
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x00054E17 File Offset: 0x00053017
		// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x00054E1F File Offset: 0x0005301F
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x00054E28 File Offset: 0x00053028
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x00054E30 File Offset: 0x00053030
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00054E39 File Offset: 0x00053039
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x00054E41 File Offset: 0x00053041
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_BlendMode blend
		{
			get
			{
				return this.blendField;
			}
			set
			{
				this.blendField = value;
			}
		}

		// Token: 0x040018A0 RID: 6304
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x040018A1 RID: 6305
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x040018A2 RID: 6306
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x040018A3 RID: 6307
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x040018A4 RID: 6308
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x040018A5 RID: 6309
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;

		// Token: 0x040018A6 RID: 6310
		private global::NPOI.OpenXmlFormats.Dml.ST_BlendMode blendField;
	}
}
