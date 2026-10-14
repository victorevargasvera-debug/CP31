using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200030E RID: 782
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("blip", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Blip
	{
		// Token: 0x06001F05 RID: 7941 RVA: 0x000534E5 File Offset: 0x000516E5
		public CT_Blip()
		{
			this.embedField = "";
			this.linkField = "";
			this.cstateField = global::NPOI.OpenXmlFormats.Dml.ST_BlipCompression.none;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0005350C File Offset: 0x0005170C
		public static global::NPOI.OpenXmlFormats.Dml.CT_Blip Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_Blip ct_Blip = new global::NPOI.OpenXmlFormats.Dml.CT_Blip();
			ct_Blip.embed = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:embed"]);
			ct_Blip.link = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:link"]);
			if (node.Attributes["cstate"] != null)
			{
				ct_Blip.cstate = (global::NPOI.OpenXmlFormats.Dml.ST_BlipCompression)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_BlipCompression), node.Attributes["cstate"].Value);
			}
			ct_Blip.Items = new global::System.Collections.Generic.List<object>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_Blip.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Blip;
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x0005360C File Offset: 0x0005180C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0} xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\"", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:embed", this.embed);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:link", this.link);
			if (this.cstate != global::NPOI.OpenXmlFormats.Dml.ST_BlipCompression.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cstate", this.cstate.ToString());
			}
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x000536A9 File Offset: 0x000518A9
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x000536B1 File Offset: 0x000518B1
		[global::System.Xml.Serialization.XmlElement("alphaBiLevel", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaBiLevelEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaCeiling", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaCeilingEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaFloor", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaFloorEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaInv", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaInverseEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaMod", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaModulateEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaModFix", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaModulateFixedEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaRepl", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaReplaceEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("biLevel", typeof(global::NPOI.OpenXmlFormats.Dml.CT_BiLevelEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("blur", typeof(global::NPOI.OpenXmlFormats.Dml.CT_BlurEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("clrChange", typeof(global::NPOI.OpenXmlFormats.Dml.CT_ColorChangeEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("clrRepl", typeof(global::NPOI.OpenXmlFormats.Dml.CT_ColorReplaceEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("duotone", typeof(global::NPOI.OpenXmlFormats.Dml.CT_DuotoneEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("fillOverlay", typeof(global::NPOI.OpenXmlFormats.Dml.CT_FillOverlayEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("grayscl", typeof(global::NPOI.OpenXmlFormats.Dml.CT_GrayscaleEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("hsl", typeof(global::NPOI.OpenXmlFormats.Dml.CT_HSLEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("lum", typeof(global::NPOI.OpenXmlFormats.Dml.CT_LuminanceEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("tint", typeof(global::NPOI.OpenXmlFormats.Dml.CT_TintEffect), Order = 0)]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000536BA File Offset: 0x000518BA
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x000536C2 File Offset: 0x000518C2
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000536CB File Offset: 0x000518CB
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x000536D3 File Offset: 0x000518D3
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		[global::System.ComponentModel.DefaultValue("")]
		public string embed
		{
			get
			{
				return this.embedField;
			}
			set
			{
				this.embedField = value;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000536DC File Offset: 0x000518DC
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x000536E4 File Offset: 0x000518E4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		[global::System.ComponentModel.DefaultValue("")]
		public string link
		{
			get
			{
				return this.linkField;
			}
			set
			{
				this.linkField = value;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x000536ED File Offset: 0x000518ED
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x000536F5 File Offset: 0x000518F5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_BlipCompression.none)]
		public global::NPOI.OpenXmlFormats.Dml.ST_BlipCompression cstate
		{
			get
			{
				return this.cstateField;
			}
			set
			{
				this.cstateField = value;
			}
		}

		// Token: 0x0400183F RID: 6207
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04001840 RID: 6208
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001841 RID: 6209
		private string embedField;

		// Token: 0x04001842 RID: 6210
		private string linkField;

		// Token: 0x04001843 RID: 6211
		private global::NPOI.OpenXmlFormats.Dml.ST_BlipCompression cstateField;
	}
}
