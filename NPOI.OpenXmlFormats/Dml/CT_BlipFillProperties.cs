using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000326 RID: 806
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BlipFillProperties
	{
		// Token: 0x0600201E RID: 8222 RVA: 0x000558B9 File Offset: 0x00053AB9
		public global::NPOI.OpenXmlFormats.Dml.CT_Blip AddNewBlip()
		{
			this.blipField = new global::NPOI.OpenXmlFormats.Dml.CT_Blip();
			return this.blipField;
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000558CC File Offset: 0x00053ACC
		public global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties AddNewStretch()
		{
			this.stretchField = new global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties();
			return this.stretchField;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x000558E0 File Offset: 0x00053AE0
		public static global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties ct_BlipFillProperties = new global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties();
			ct_BlipFillProperties.dpi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dpi"]);
			ct_BlipFillProperties.rotWithShape = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["rotWithShape"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "blip")
				{
					ct_BlipFillProperties.blip = global::NPOI.OpenXmlFormats.Dml.CT_Blip.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srcRect")
				{
					ct_BlipFillProperties.srcRect = global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tile")
				{
					ct_BlipFillProperties.tile = global::NPOI.OpenXmlFormats.Dml.CT_TileInfoProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "stretch")
				{
					ct_BlipFillProperties.stretch = global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_BlipFillProperties;
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x000559FC File Offset: 0x00053BFC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dpi", this.dpi, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rotWithShape", this.rotWithShape);
			sw.Write(">");
			if (this.blip != null)
			{
				this.blip.Write(sw, "blip");
			}
			if (this.srcRect != null)
			{
				this.srcRect.Write(sw, "srcRect");
			}
			if (this.tile != null)
			{
				this.tile.Write(sw, "tile");
			}
			if (this.stretch != null)
			{
				this.stretch.Write(sw, "stretch");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00055ABD File Offset: 0x00053CBD
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x00055AC5 File Offset: 0x00053CC5
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Blip blip
		{
			get
			{
				return this.blipField;
			}
			set
			{
				this.blipField = value;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x00055ACE File Offset: 0x00053CCE
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x00055AD6 File Offset: 0x00053CD6
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect srcRect
		{
			get
			{
				return this.srcRectField;
			}
			set
			{
				this.srcRectField = value;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x00055ADF File Offset: 0x00053CDF
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x00055AE7 File Offset: 0x00053CE7
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TileInfoProperties tile
		{
			get
			{
				return this.tileField;
			}
			set
			{
				this.tileField = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00055AF0 File Offset: 0x00053CF0
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x00055AF8 File Offset: 0x00053CF8
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties stretch
		{
			get
			{
				return this.stretchField;
			}
			set
			{
				this.stretchField = value;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x00055B01 File Offset: 0x00053D01
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x00055B09 File Offset: 0x00053D09
		[global::System.Xml.Serialization.XmlAttribute]
		public uint dpi
		{
			get
			{
				return this.dpiField;
			}
			set
			{
				this.dpiField = value;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x00055B12 File Offset: 0x00053D12
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x00055B1A File Offset: 0x00053D1A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dpiSpecified
		{
			get
			{
				return this.dpiFieldSpecified;
			}
			set
			{
				this.dpiFieldSpecified = value;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00055B23 File Offset: 0x00053D23
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x00055B2B File Offset: 0x00053D2B
		[global::System.Xml.Serialization.XmlAttribute]
		public bool rotWithShape
		{
			get
			{
				return this.rotWithShapeField;
			}
			set
			{
				this.rotWithShapeField = value;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x00055B34 File Offset: 0x00053D34
		// (set) Token: 0x06002031 RID: 8241 RVA: 0x00055B3C File Offset: 0x00053D3C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rotWithShapeSpecified
		{
			get
			{
				return this.rotWithShapeFieldSpecified;
			}
			set
			{
				this.rotWithShapeFieldSpecified = value;
			}
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00055B45 File Offset: 0x00053D45
		public bool IsSetBlip()
		{
			return this.blipField != null;
		}

		// Token: 0x040018CC RID: 6348
		private global::NPOI.OpenXmlFormats.Dml.CT_Blip blipField;

		// Token: 0x040018CD RID: 6349
		private global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect srcRectField;

		// Token: 0x040018CE RID: 6350
		private global::NPOI.OpenXmlFormats.Dml.CT_TileInfoProperties tileField;

		// Token: 0x040018CF RID: 6351
		private global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties stretchField;

		// Token: 0x040018D0 RID: 6352
		private uint dpiField;

		// Token: 0x040018D1 RID: 6353
		private bool dpiFieldSpecified;

		// Token: 0x040018D2 RID: 6354
		private bool rotWithShapeField;

		// Token: 0x040018D3 RID: 6355
		private bool rotWithShapeFieldSpecified;
	}
}
