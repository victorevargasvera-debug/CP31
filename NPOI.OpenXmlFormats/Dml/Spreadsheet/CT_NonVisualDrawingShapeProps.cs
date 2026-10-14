using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000363 RID: 867
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NonVisualDrawingShapeProps
	{
		// Token: 0x0600225C RID: 8796 RVA: 0x00059A94 File Offset: 0x00057C94
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingShapeProps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingShapeProps ct_NonVisualDrawingShapeProps = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingShapeProps();
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

		// Token: 0x0600225D RID: 8797 RVA: 0x00059B50 File Offset: 0x00057D50
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
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
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x00059BCE File Offset: 0x00057DCE
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x00059BD6 File Offset: 0x00057DD6
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

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x00059BDF File Offset: 0x00057DDF
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x00059BE7 File Offset: 0x00057DE7
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

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x00059BF0 File Offset: 0x00057DF0
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x00059BF8 File Offset: 0x00057DF8
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

		// Token: 0x04001A12 RID: 6674
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeLocking spLocksField;

		// Token: 0x04001A13 RID: 6675
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001A14 RID: 6676
		private bool txBoxField;
	}
}
