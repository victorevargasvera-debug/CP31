using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000333 RID: 819
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EffectContainer
	{
		// Token: 0x06002091 RID: 8337 RVA: 0x000562EF File Offset: 0x000544EF
		public CT_EffectContainer()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
			this.typeField = global::NPOI.OpenXmlFormats.Dml.ST_EffectContainerType.sib;
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x0005630C File Offset: 0x0005450C
		public static global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer ct_EffectContainer = new global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer();
			if (node.Attributes["type"] != null)
			{
				ct_EffectContainer.type = (global::NPOI.OpenXmlFormats.Dml.ST_EffectContainerType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_EffectContainerType), node.Attributes["type"].Value);
			}
			ct_EffectContainer.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			return ct_EffectContainer;
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00056384 File Offset: 0x00054584
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x000563EE File Offset: 0x000545EE
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x000563F6 File Offset: 0x000545F6
		[global::System.Xml.Serialization.XmlElement("alphaBiLevel", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaBiLevelEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaCeiling", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaCeilingEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaFloor", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaFloorEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaInv", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaInverseEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaMod", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaModulateEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaModFix", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaModulateFixedEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaOutset", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaOutsetEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("alphaRepl", typeof(global::NPOI.OpenXmlFormats.Dml.CT_AlphaReplaceEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("biLevel", typeof(global::NPOI.OpenXmlFormats.Dml.CT_BiLevelEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("blend", typeof(global::NPOI.OpenXmlFormats.Dml.CT_BlendEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("blur", typeof(global::NPOI.OpenXmlFormats.Dml.CT_BlurEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("clrChange", typeof(global::NPOI.OpenXmlFormats.Dml.CT_ColorChangeEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("clrRepl", typeof(global::NPOI.OpenXmlFormats.Dml.CT_ColorReplaceEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("cont", typeof(global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("duotone", typeof(global::NPOI.OpenXmlFormats.Dml.CT_DuotoneEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("effect", typeof(global::NPOI.OpenXmlFormats.Dml.CT_EffectReference), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("fill", typeof(global::NPOI.OpenXmlFormats.Dml.CT_FillEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("fillOverlay", typeof(global::NPOI.OpenXmlFormats.Dml.CT_FillOverlayEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("glow", typeof(global::NPOI.OpenXmlFormats.Dml.CT_GlowEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("grayscl", typeof(global::NPOI.OpenXmlFormats.Dml.CT_GrayscaleEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("hsl", typeof(global::NPOI.OpenXmlFormats.Dml.CT_HSLEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("innerShdw", typeof(global::NPOI.OpenXmlFormats.Dml.CT_InnerShadowEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("lum", typeof(global::NPOI.OpenXmlFormats.Dml.CT_LuminanceEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("outerShdw", typeof(global::NPOI.OpenXmlFormats.Dml.CT_OuterShadowEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("prstShdw", typeof(global::NPOI.OpenXmlFormats.Dml.CT_PresetShadowEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("reflection", typeof(global::NPOI.OpenXmlFormats.Dml.CT_ReflectionEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("relOff", typeof(global::NPOI.OpenXmlFormats.Dml.CT_RelativeOffsetEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("softEdge", typeof(global::NPOI.OpenXmlFormats.Dml.CT_SoftEdgesEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("tint", typeof(global::NPOI.OpenXmlFormats.Dml.CT_TintEffect), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("xfrm", typeof(global::NPOI.OpenXmlFormats.Dml.CT_TransformEffect), Order = 0)]
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

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x000563FF File Offset: 0x000545FF
		// (set) Token: 0x06002097 RID: 8343 RVA: 0x00056407 File Offset: 0x00054607
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_EffectContainerType.sib)]
		public global::NPOI.OpenXmlFormats.Dml.ST_EffectContainerType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x00056410 File Offset: 0x00054610
		// (set) Token: 0x06002099 RID: 8345 RVA: 0x00056418 File Offset: 0x00054618
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
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

		// Token: 0x04001936 RID: 6454
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04001937 RID: 6455
		private global::NPOI.OpenXmlFormats.Dml.ST_EffectContainerType typeField;

		// Token: 0x04001938 RID: 6456
		private string nameField;
	}
}
