using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000341 RID: 833
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EffectList
	{
		// Token: 0x060020CD RID: 8397 RVA: 0x000566CC File Offset: 0x000548CC
		public static global::NPOI.OpenXmlFormats.Dml.CT_EffectList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_EffectList ct_EffectList = new global::NPOI.OpenXmlFormats.Dml.CT_EffectList();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "blur")
				{
					ct_EffectList.blur = global::NPOI.OpenXmlFormats.Dml.CT_BlurEffect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fillOverlay")
				{
					ct_EffectList.fillOverlay = global::NPOI.OpenXmlFormats.Dml.CT_FillOverlayEffect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "glow")
				{
					ct_EffectList.glow = global::NPOI.OpenXmlFormats.Dml.CT_GlowEffect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "innerShdw")
				{
					ct_EffectList.innerShdw = global::NPOI.OpenXmlFormats.Dml.CT_InnerShadowEffect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "outerShdw")
				{
					ct_EffectList.outerShdw = global::NPOI.OpenXmlFormats.Dml.CT_OuterShadowEffect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstShdw")
				{
					ct_EffectList.prstShdw = global::NPOI.OpenXmlFormats.Dml.CT_PresetShadowEffect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "reflection")
				{
					ct_EffectList.reflection = global::NPOI.OpenXmlFormats.Dml.CT_ReflectionEffect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "softEdge")
				{
					ct_EffectList.softEdge = global::NPOI.OpenXmlFormats.Dml.CT_SoftEdgesEffect.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_EffectList;
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00056850 File Offset: 0x00054A50
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.blur != null)
			{
				this.blur.Write(sw, "blur");
			}
			if (this.fillOverlay != null)
			{
				this.fillOverlay.Write(sw, "fillOverlay");
			}
			if (this.glow != null)
			{
				this.glow.Write(sw, "glow");
			}
			if (this.innerShdw != null)
			{
				this.innerShdw.Write(sw, "innerShdw");
			}
			if (this.outerShdw != null)
			{
				this.outerShdw.Write(sw, "outerShdw");
			}
			if (this.prstShdw != null)
			{
				this.prstShdw.Write(sw, "prstShdw");
			}
			if (this.reflection != null)
			{
				this.reflection.Write(sw, "reflection");
			}
			if (this.softEdge != null)
			{
				this.softEdge.Write(sw, "softEdge");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x00056952 File Offset: 0x00054B52
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x0005695A File Offset: 0x00054B5A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_BlurEffect blur
		{
			get
			{
				return this.blurField;
			}
			set
			{
				this.blurField = value;
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x00056963 File Offset: 0x00054B63
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x0005696B File Offset: 0x00054B6B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FillOverlayEffect fillOverlay
		{
			get
			{
				return this.fillOverlayField;
			}
			set
			{
				this.fillOverlayField = value;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x00056974 File Offset: 0x00054B74
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x0005697C File Offset: 0x00054B7C
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GlowEffect glow
		{
			get
			{
				return this.glowField;
			}
			set
			{
				this.glowField = value;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x00056985 File Offset: 0x00054B85
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x0005698D File Offset: 0x00054B8D
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_InnerShadowEffect innerShdw
		{
			get
			{
				return this.innerShdwField;
			}
			set
			{
				this.innerShdwField = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x00056996 File Offset: 0x00054B96
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x0005699E File Offset: 0x00054B9E
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OuterShadowEffect outerShdw
		{
			get
			{
				return this.outerShdwField;
			}
			set
			{
				this.outerShdwField = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x000569A7 File Offset: 0x00054BA7
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x000569AF File Offset: 0x00054BAF
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetShadowEffect prstShdw
		{
			get
			{
				return this.prstShdwField;
			}
			set
			{
				this.prstShdwField = value;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x000569B8 File Offset: 0x00054BB8
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x000569C0 File Offset: 0x00054BC0
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ReflectionEffect reflection
		{
			get
			{
				return this.reflectionField;
			}
			set
			{
				this.reflectionField = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x000569C9 File Offset: 0x00054BC9
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x000569D1 File Offset: 0x00054BD1
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SoftEdgesEffect softEdge
		{
			get
			{
				return this.softEdgeField;
			}
			set
			{
				this.softEdgeField = value;
			}
		}

		// Token: 0x04001955 RID: 6485
		private global::NPOI.OpenXmlFormats.Dml.CT_BlurEffect blurField;

		// Token: 0x04001956 RID: 6486
		private global::NPOI.OpenXmlFormats.Dml.CT_FillOverlayEffect fillOverlayField;

		// Token: 0x04001957 RID: 6487
		private global::NPOI.OpenXmlFormats.Dml.CT_GlowEffect glowField;

		// Token: 0x04001958 RID: 6488
		private global::NPOI.OpenXmlFormats.Dml.CT_InnerShadowEffect innerShdwField;

		// Token: 0x04001959 RID: 6489
		private global::NPOI.OpenXmlFormats.Dml.CT_OuterShadowEffect outerShdwField;

		// Token: 0x0400195A RID: 6490
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetShadowEffect prstShdwField;

		// Token: 0x0400195B RID: 6491
		private global::NPOI.OpenXmlFormats.Dml.CT_ReflectionEffect reflectionField;

		// Token: 0x0400195C RID: 6492
		private global::NPOI.OpenXmlFormats.Dml.CT_SoftEdgesEffect softEdgeField;
	}
}
