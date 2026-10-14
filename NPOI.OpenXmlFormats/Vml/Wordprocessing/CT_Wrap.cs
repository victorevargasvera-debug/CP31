using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Vml.Wordprocessing
{
	// Token: 0x020001FC RID: 508
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:word")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:word", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Wrap
	{
		// Token: 0x06001495 RID: 5269 RVA: 0x00040170 File Offset: 0x0003E370
		public static global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap ct_Wrap = new global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap();
			if (node.Attributes["type"] != null)
			{
				ct_Wrap.type = (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_WrapType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_WrapType), node.Attributes["type"].Value);
			}
			if (node.Attributes["side"] != null)
			{
				ct_Wrap.side = (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_WrapSide)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_WrapSide), node.Attributes["side"].Value);
			}
			if (node.Attributes["anchorx"] != null)
			{
				ct_Wrap.anchorx = (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_HorizontalAnchor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_HorizontalAnchor), node.Attributes["anchorx"].Value);
			}
			if (node.Attributes["anchory"] != null)
			{
				ct_Wrap.anchory = (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_VerticalAnchor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_VerticalAnchor), node.Attributes["anchory"].Value);
			}
			return ct_Wrap;
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00040290 File Offset: 0x0003E490
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.type != global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_WrapType.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "side", this.side.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "anchorx", this.anchorx.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "anchory", this.anchory.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0004034F File Offset: 0x0003E54F
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00040357 File Offset: 0x0003E557
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_WrapType type
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

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00040360 File Offset: 0x0003E560
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x00040368 File Offset: 0x0003E568
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00040371 File Offset: 0x0003E571
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x00040379 File Offset: 0x0003E579
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_WrapSide side
		{
			get
			{
				return this.sideField;
			}
			set
			{
				this.sideField = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x00040382 File Offset: 0x0003E582
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0004038A File Offset: 0x0003E58A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool sideSpecified
		{
			get
			{
				return this.sideFieldSpecified;
			}
			set
			{
				this.sideFieldSpecified = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x00040393 File Offset: 0x0003E593
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0004039B File Offset: 0x0003E59B
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_HorizontalAnchor anchorx
		{
			get
			{
				return this.anchorxField;
			}
			set
			{
				this.anchorxField = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x000403A4 File Offset: 0x0003E5A4
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x000403AC File Offset: 0x0003E5AC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool anchorxSpecified
		{
			get
			{
				return this.anchorxFieldSpecified;
			}
			set
			{
				this.anchorxFieldSpecified = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x000403B5 File Offset: 0x0003E5B5
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x000403BD File Offset: 0x0003E5BD
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_VerticalAnchor anchory
		{
			get
			{
				return this.anchoryField;
			}
			set
			{
				this.anchoryField = value;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x000403C6 File Offset: 0x0003E5C6
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x000403CE File Offset: 0x0003E5CE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool anchorySpecified
		{
			get
			{
				return this.anchoryFieldSpecified;
			}
			set
			{
				this.anchoryFieldSpecified = value;
			}
		}

		// Token: 0x04000FE4 RID: 4068
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_WrapType typeField;

		// Token: 0x04000FE5 RID: 4069
		private bool typeFieldSpecified;

		// Token: 0x04000FE6 RID: 4070
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_WrapSide sideField;

		// Token: 0x04000FE7 RID: 4071
		private bool sideFieldSpecified;

		// Token: 0x04000FE8 RID: 4072
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_HorizontalAnchor anchorxField;

		// Token: 0x04000FE9 RID: 4073
		private bool anchorxFieldSpecified;

		// Token: 0x04000FEA RID: 4074
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_VerticalAnchor anchoryField;

		// Token: 0x04000FEB RID: 4075
		private bool anchoryFieldSpecified;
	}
}
