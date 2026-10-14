using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002F0 RID: 752
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PresetGeometry2D
	{
		// Token: 0x06001D0F RID: 7439 RVA: 0x0004EE34 File Offset: 0x0004D034
		public global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList AddNewAvLst()
		{
			this.avLstField = new global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList();
			return this.avLstField;
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0004EE48 File Offset: 0x0004D048
		public static global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D ct_PresetGeometry2D = new global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D();
			if (node.Attributes["prst"] != null)
			{
				ct_PresetGeometry2D.prst = (global::NPOI.OpenXmlFormats.Dml.ST_ShapeType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ShapeType), node.Attributes["prst"].Value);
			}
			if (node.ChildNodes != null)
			{
				foreach (object obj in node.ChildNodes)
				{
					global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
					if (xmlNode.LocalName == "avLst")
					{
						ct_PresetGeometry2D.avLstField = global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList.Parse(xmlNode, namespaceManager);
					}
				}
			}
			return ct_PresetGeometry2D;
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0004EF10 File Offset: 0x0004D110
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "prst", this.prst.ToString());
			sw.Write(">");
			if (this.avLst != null)
			{
				this.avLst.Write(sw, "avLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x0004EF82 File Offset: 0x0004D182
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x0004EF8A File Offset: 0x0004D18A
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

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x0004EF93 File Offset: 0x0004D193
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x0004EF9B File Offset: 0x0004D19B
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ShapeType prst
		{
			get
			{
				return this.prstField;
			}
			set
			{
				this.prstField = value;
			}
		}

		// Token: 0x0400176A RID: 5994
		private global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList avLstField;

		// Token: 0x0400176B RID: 5995
		private global::NPOI.OpenXmlFormats.Dml.ST_ShapeType prstField;
	}
}
