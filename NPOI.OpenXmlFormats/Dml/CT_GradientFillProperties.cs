using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000320 RID: 800
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GradientFillProperties
	{
		// Token: 0x06001FE7 RID: 8167 RVA: 0x00055134 File Offset: 0x00053334
		public static global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties ct_GradientFillProperties = new global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties();
			if (node.Attributes["flip"] != null)
			{
				ct_GradientFillProperties.flip = (global::NPOI.OpenXmlFormats.Dml.ST_TileFlipMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TileFlipMode), node.Attributes["flip"].Value);
			}
			ct_GradientFillProperties.rotWithShape = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["rotWithShape"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "gsLst")
				{
					ct_GradientFillProperties.gsLst = global::NPOI.OpenXmlFormats.Dml.CT_GradientStopList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lin")
				{
					ct_GradientFillProperties.lin = global::NPOI.OpenXmlFormats.Dml.CT_LinearShadeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "path")
				{
					ct_GradientFillProperties.path = global::NPOI.OpenXmlFormats.Dml.CT_PathShadeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tileRect")
				{
					ct_GradientFillProperties.tileRect = global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GradientFillProperties;
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00055278 File Offset: 0x00053478
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			if (this.flip != global::NPOI.OpenXmlFormats.Dml.ST_TileFlipMode.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "flip", this.flip.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rotWithShape", this.rotWithShape);
			sw.Write(">");
			if (this.gsLst != null)
			{
				this.gsLst.Write(sw, "gsLst");
			}
			if (this.lin != null)
			{
				this.lin.Write(sw, "lin");
			}
			if (this.path != null)
			{
				this.path.Write(sw, "path");
			}
			if (this.tileRect != null)
			{
				this.tileRect.Write(sw, "tileRect");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0005534E File Offset: 0x0005354E
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x00055356 File Offset: 0x00053556
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GradientStopList gsLst
		{
			get
			{
				return this.gsLstField;
			}
			set
			{
				this.gsLstField = value;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x0005535F File Offset: 0x0005355F
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x00055367 File Offset: 0x00053567
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LinearShadeProperties lin
		{
			get
			{
				return this.linField;
			}
			set
			{
				this.linField = value;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x00055370 File Offset: 0x00053570
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x00055378 File Offset: 0x00053578
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PathShadeProperties path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x00055381 File Offset: 0x00053581
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x00055389 File Offset: 0x00053589
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect tileRect
		{
			get
			{
				return this.tileRectField;
			}
			set
			{
				this.tileRectField = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x00055392 File Offset: 0x00053592
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x0005539A File Offset: 0x0005359A
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TileFlipMode flip
		{
			get
			{
				return this.flipField;
			}
			set
			{
				this.flipField = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x000553A3 File Offset: 0x000535A3
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x000553AB File Offset: 0x000535AB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool flipSpecified
		{
			get
			{
				return this.flipFieldSpecified;
			}
			set
			{
				this.flipFieldSpecified = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x000553B4 File Offset: 0x000535B4
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x000553BC File Offset: 0x000535BC
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

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x000553C5 File Offset: 0x000535C5
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x000553CD File Offset: 0x000535CD
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

		// Token: 0x040018AD RID: 6317
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientStopList gsLstField;

		// Token: 0x040018AE RID: 6318
		private global::NPOI.OpenXmlFormats.Dml.CT_LinearShadeProperties linField;

		// Token: 0x040018AF RID: 6319
		private global::NPOI.OpenXmlFormats.Dml.CT_PathShadeProperties pathField;

		// Token: 0x040018B0 RID: 6320
		private global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect tileRectField;

		// Token: 0x040018B1 RID: 6321
		private global::NPOI.OpenXmlFormats.Dml.ST_TileFlipMode flipField;

		// Token: 0x040018B2 RID: 6322
		private bool flipFieldSpecified;

		// Token: 0x040018B3 RID: 6323
		private bool rotWithShapeField;

		// Token: 0x040018B4 RID: 6324
		private bool rotWithShapeFieldSpecified;
	}
}
