using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002F1 RID: 753
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PresetTextShape
	{
		// Token: 0x06001D17 RID: 7447 RVA: 0x0004EFA4 File Offset: 0x0004D1A4
		public static global::NPOI.OpenXmlFormats.Dml.CT_PresetTextShape Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_PresetTextShape ct_PresetTextShape = new global::NPOI.OpenXmlFormats.Dml.CT_PresetTextShape();
			if (node.Attributes["prst"] != null)
			{
				ct_PresetTextShape.prst = (global::NPOI.OpenXmlFormats.Dml.ST_TextShapeType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextShapeType), node.Attributes["prst"].Value);
			}
			ct_PresetTextShape.avLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "avLst")
				{
					ct_PresetTextShape.avLst.Add(global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PresetTextShape;
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0004F074 File Offset: 0x0004D274
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "prst", this.prst.ToString());
			sw.Write(">");
			if (this.avLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide ct_GeomGuide in this.avLst)
				{
					ct_GeomGuide.Write(sw, "avLst");
				}
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0004F120 File Offset: 0x0004D320
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0004F128 File Offset: 0x0004D328
		[global::System.Xml.Serialization.XmlArray(Order = 0)]
		[global::System.Xml.Serialization.XmlArrayItem("gd", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide> avLst
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

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x0004F131 File Offset: 0x0004D331
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0004F139 File Offset: 0x0004D339
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextShapeType prst
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

		// Token: 0x0400176C RID: 5996
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide> avLstField;

		// Token: 0x0400176D RID: 5997
		private global::NPOI.OpenXmlFormats.Dml.ST_TextShapeType prstField;
	}
}
