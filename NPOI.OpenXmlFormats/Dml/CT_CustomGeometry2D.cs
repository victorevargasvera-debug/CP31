using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002F2 RID: 754
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CustomGeometry2D
	{
		// Token: 0x06001D1E RID: 7454 RVA: 0x0004F144 File Offset: 0x0004D344
		public static global::NPOI.OpenXmlFormats.Dml.CT_CustomGeometry2D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_CustomGeometry2D ct_CustomGeometry2D = new global::NPOI.OpenXmlFormats.Dml.CT_CustomGeometry2D();
			ct_CustomGeometry2D.ahLst = new global::System.Collections.Generic.List<object>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rect")
				{
					ct_CustomGeometry2D.rect = global::NPOI.OpenXmlFormats.Dml.CT_GeomRect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "avLst")
				{
					ct_CustomGeometry2D.avLst = global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gdLst")
				{
					ct_CustomGeometry2D.gdLst = global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cxnLst")
				{
					ct_CustomGeometry2D.cxnLst = global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSiteList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pathLst")
				{
					ct_CustomGeometry2D.pathLst = global::NPOI.OpenXmlFormats.Dml.CT_Path2DList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CustomGeometry2D;
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0004F25C File Offset: 0x0004D45C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.rect != null)
			{
				this.rect.Write(sw, "rect");
			}
			if (this.avLst != null)
			{
				this.avLst.Write(sw, "avLst");
			}
			if (this.gdLst != null)
			{
				this.gdLst.Write(sw, "gdLst");
			}
			if (this.cxnLst != null)
			{
				this.cxnLstField.Write(sw, "cxnLst");
			}
			if (this.pathLst != null)
			{
				this.pathLstField.Write(sw, "pathLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x0004F313 File Offset: 0x0004D513
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x0004F31B File Offset: 0x0004D51B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList avLst
		{
			get
			{
				return this.avLstField;
			}
			set
			{
				this.avLstField = value;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0004F324 File Offset: 0x0004D524
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x0004F32C File Offset: 0x0004D52C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList gdLst
		{
			get
			{
				return this.gdLstField;
			}
			set
			{
				this.gdLstField = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x0004F335 File Offset: 0x0004D535
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x0004F33D File Offset: 0x0004D53D
		[global::System.Xml.Serialization.XmlArray(Order = 2)]
		[global::System.Xml.Serialization.XmlArrayItem("ahPolar", typeof(global::NPOI.OpenXmlFormats.Dml.CT_PolarAdjustHandle), IsNullable = false)]
		[global::System.Xml.Serialization.XmlArrayItem("ahXY", typeof(global::NPOI.OpenXmlFormats.Dml.CT_XYAdjustHandle), IsNullable = false)]
		public global::System.Collections.Generic.List<object> ahLst
		{
			get
			{
				return this.ahLstField;
			}
			set
			{
				this.ahLstField = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0004F346 File Offset: 0x0004D546
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x0004F34E File Offset: 0x0004D54E
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSiteList cxnLst
		{
			get
			{
				return this.cxnLstField;
			}
			set
			{
				this.cxnLstField = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0004F357 File Offset: 0x0004D557
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x0004F35F File Offset: 0x0004D55F
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GeomRect rect
		{
			get
			{
				return this.rectField;
			}
			set
			{
				this.rectField = value;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0004F368 File Offset: 0x0004D568
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x0004F370 File Offset: 0x0004D570
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Path2DList pathLst
		{
			get
			{
				return this.pathLstField;
			}
			set
			{
				this.pathLstField = value;
			}
		}

		// Token: 0x0400176E RID: 5998
		private global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList avLstField;

		// Token: 0x0400176F RID: 5999
		private global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList gdLstField;

		// Token: 0x04001770 RID: 6000
		private global::System.Collections.Generic.List<object> ahLstField;

		// Token: 0x04001771 RID: 6001
		private global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSiteList cxnLstField;

		// Token: 0x04001772 RID: 6002
		private global::NPOI.OpenXmlFormats.Dml.CT_GeomRect rectField;

		// Token: 0x04001773 RID: 6003
		private global::NPOI.OpenXmlFormats.Dml.CT_Path2DList pathLstField;
	}
}
