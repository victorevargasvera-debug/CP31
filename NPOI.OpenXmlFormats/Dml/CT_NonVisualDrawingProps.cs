using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002F9 RID: 761
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NonVisualDrawingProps
	{
		// Token: 0x06001DA5 RID: 7589 RVA: 0x000505B8 File Offset: 0x0004E7B8
		public static global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps ct_NonVisualDrawingProps = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingProps();
			ct_NonVisualDrawingProps.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["id"]);
			ct_NonVisualDrawingProps.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_NonVisualDrawingProps.descr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["descr"]);
			ct_NonVisualDrawingProps.hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "hlinkClick")
				{
					ct_NonVisualDrawingProps.hlinkClick = global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hlinkHover")
				{
					ct_NonVisualDrawingProps.hlinkHover = global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_NonVisualDrawingProps.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NonVisualDrawingProps;
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x000506E4 File Offset: 0x0004E8E4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<pic:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "descr", this.descr);
			if (this.hidden)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden);
			}
			sw.Write(">");
			if (this.hlinkClick != null)
			{
				this.hlinkClick.Write(sw, "hlinkClick");
			}
			if (this.hlinkHover != null)
			{
				this.hlinkHover.Write(sw, "hlinkHover");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</pic:{0}>", nodeName));
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x000507B6 File Offset: 0x0004E9B6
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x000507BE File Offset: 0x0004E9BE
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkClick
		{
			get
			{
				return this.hlinkClickField;
			}
			set
			{
				this.hlinkClickField = value;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x000507C7 File Offset: 0x0004E9C7
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x000507CF File Offset: 0x0004E9CF
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkHover
		{
			get
			{
				return this.hlinkHoverField;
			}
			set
			{
				this.hlinkHoverField = value;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x000507D8 File Offset: 0x0004E9D8
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x000507E0 File Offset: 0x0004E9E0
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x000507E9 File Offset: 0x0004E9E9
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x000507F1 File Offset: 0x0004E9F1
		[global::System.Xml.Serialization.XmlAttribute]
		public uint id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x000507FA File Offset: 0x0004E9FA
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00050802 File Offset: 0x0004EA02
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

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0005080B File Offset: 0x0004EA0B
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x00050821 File Offset: 0x0004EA21
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string descr
		{
			get
			{
				if (this.descrField != null)
				{
					return this.descrField;
				}
				return "";
			}
			set
			{
				this.descrField = value;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0005082A File Offset: 0x0004EA2A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool descrSpecified
		{
			get
			{
				return this.descrField != null;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x00050835 File Offset: 0x0004EA35
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x00050851 File Offset: 0x0004EA51
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hidden
		{
			get
			{
				return this.hiddenField != null && this.hiddenField.Value;
			}
			set
			{
				this.hiddenField = new bool?(value);
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x0005085F File Offset: 0x0004EA5F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hiddenSpecified
		{
			get
			{
				return this.hiddenField != null;
			}
		}

		// Token: 0x040017A4 RID: 6052
		private global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkClickField;

		// Token: 0x040017A5 RID: 6053
		private global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkHoverField;

		// Token: 0x040017A6 RID: 6054
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040017A7 RID: 6055
		private uint idField;

		// Token: 0x040017A8 RID: 6056
		private string nameField;

		// Token: 0x040017A9 RID: 6057
		private string descrField;

		// Token: 0x040017AA RID: 6058
		private bool? hiddenField;
	}
}
