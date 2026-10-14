using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000430 RID: 1072
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DPt
	{
		// Token: 0x06002AF8 RID: 11000 RVA: 0x0006BC88 File Offset: 0x00069E88
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt ct_DPt = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt();
			ct_DPt.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_DPt.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "invertIfNegative")
				{
					ct_DPt.invertIfNegative = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "marker")
				{
					ct_DPt.marker = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bubble3D")
				{
					ct_DPt.bubble3D = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "explosion")
				{
					ct_DPt.explosion = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_DPt.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pictureOptions")
				{
					ct_DPt.pictureOptions = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_DPt.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DPt;
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0006BE1C File Offset: 0x0006A01C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.idx != null)
			{
				this.idx.Write(sw, "idx");
			}
			if (this.invertIfNegative != null)
			{
				this.invertIfNegative.Write(sw, "invertIfNegative");
			}
			if (this.marker != null)
			{
				this.marker.Write(sw, "marker");
			}
			if (this.bubble3D != null)
			{
				this.bubble3D.Write(sw, "bubble3D");
			}
			if (this.explosion != null)
			{
				this.explosion.Write(sw, "explosion");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.pictureOptions != null)
			{
				this.pictureOptions.Write(sw, "pictureOptions");
			}
			if (this.extLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
				{
					ct_Extension.Write(sw, "extLst");
				}
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x0006BF58 File Offset: 0x0006A158
		// (set) Token: 0x06002AFC RID: 11004 RVA: 0x0006BF60 File Offset: 0x0006A160
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idx
		{
			get
			{
				return this.idxField;
			}
			set
			{
				this.idxField = value;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x0006BF69 File Offset: 0x0006A169
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x0006BF71 File Offset: 0x0006A171
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean invertIfNegative
		{
			get
			{
				return this.invertIfNegativeField;
			}
			set
			{
				this.invertIfNegativeField = value;
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x0006BF7A File Offset: 0x0006A17A
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x0006BF82 File Offset: 0x0006A182
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker marker
		{
			get
			{
				return this.markerField;
			}
			set
			{
				this.markerField = value;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x0006BF8B File Offset: 0x0006A18B
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x0006BF93 File Offset: 0x0006A193
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean bubble3D
		{
			get
			{
				return this.bubble3DField;
			}
			set
			{
				this.bubble3DField = value;
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x0006BF9C File Offset: 0x0006A19C
		// (set) Token: 0x06002B04 RID: 11012 RVA: 0x0006BFA4 File Offset: 0x0006A1A4
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt explosion
		{
			get
			{
				return this.explosionField;
			}
			set
			{
				this.explosionField = value;
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x0006BFAD File Offset: 0x0006A1AD
		// (set) Token: 0x06002B06 RID: 11014 RVA: 0x0006BFB5 File Offset: 0x0006A1B5
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPr
		{
			get
			{
				return this.spPrField;
			}
			set
			{
				this.spPrField = value;
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x0006BFBE File Offset: 0x0006A1BE
		// (set) Token: 0x06002B08 RID: 11016 RVA: 0x0006BFC6 File Offset: 0x0006A1C6
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions pictureOptions
		{
			get
			{
				return this.pictureOptionsField;
			}
			set
			{
				this.pictureOptionsField = value;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x0006BFCF File Offset: 0x0006A1CF
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x0006BFD7 File Offset: 0x0006A1D7
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLst
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

		// Token: 0x04001E82 RID: 7810
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001E83 RID: 7811
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean invertIfNegativeField;

		// Token: 0x04001E84 RID: 7812
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker markerField;

		// Token: 0x04001E85 RID: 7813
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean bubble3DField;

		// Token: 0x04001E86 RID: 7814
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt explosionField;

		// Token: 0x04001E87 RID: 7815
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001E88 RID: 7816
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions pictureOptionsField;

		// Token: 0x04001E89 RID: 7817
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
