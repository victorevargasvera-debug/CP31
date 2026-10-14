using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002FA RID: 762
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NonVisualDrawingShapeProps
	{
		// Token: 0x06001DB8 RID: 7608 RVA: 0x0005086C File Offset: 0x0004EA6C
		public static global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingShapeProps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingShapeProps ct_NonVisualDrawingShapeProps = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualDrawingShapeProps();
			ct_NonVisualDrawingShapeProps.txBox = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["txBox"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "spLocks")
				{
					ct_NonVisualDrawingShapeProps.spLocks = global::NPOI.OpenXmlFormats.Dml.CT_ShapeLocking.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_NonVisualDrawingShapeProps.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NonVisualDrawingShapeProps;
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00050928 File Offset: 0x0004EB28
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "txBox", this.txBox, false);
			sw.Write(">");
			if (this.spLocks != null)
			{
				this.spLocks.Write(sw, "spLocks");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x000509A6 File Offset: 0x0004EBA6
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x000509AE File Offset: 0x0004EBAE
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ShapeLocking spLocks
		{
			get
			{
				return this.spLocksField;
			}
			set
			{
				this.spLocksField = value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x000509B7 File Offset: 0x0004EBB7
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x000509BF File Offset: 0x0004EBBF
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

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x000509C8 File Offset: 0x0004EBC8
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x000509D0 File Offset: 0x0004EBD0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool txBox
		{
			get
			{
				return this.txBoxField;
			}
			set
			{
				this.txBoxField = value;
			}
		}

		// Token: 0x040017AB RID: 6059
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeLocking spLocksField;

		// Token: 0x040017AC RID: 6060
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040017AD RID: 6061
		private bool txBoxField;
	}
}
