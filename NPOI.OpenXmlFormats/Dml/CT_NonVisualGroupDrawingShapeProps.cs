using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002FD RID: 765
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NonVisualGroupDrawingShapeProps
	{
		// Token: 0x06001DD6 RID: 7638 RVA: 0x00050D40 File Offset: 0x0004EF40
		public static global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps ct_NonVisualGroupDrawingShapeProps = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGroupDrawingShapeProps();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "grpSpLocks")
				{
					ct_NonVisualGroupDrawingShapeProps.grpSpLocks = global::NPOI.OpenXmlFormats.Dml.CT_GroupLocking.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_NonVisualGroupDrawingShapeProps.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NonVisualGroupDrawingShapeProps;
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00050DE0 File Offset: 0x0004EFE0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.grpSpLocks != null)
			{
				this.grpSpLocks.Write(sw, "grpSpLocks");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x00050E4C File Offset: 0x0004F04C
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x00050E54 File Offset: 0x0004F054
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupLocking grpSpLocks
		{
			get
			{
				return this.grpSpLocksField;
			}
			set
			{
				this.grpSpLocksField = value;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00050E5D File Offset: 0x0004F05D
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x00050E65 File Offset: 0x0004F065
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

		// Token: 0x040017B5 RID: 6069
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupLocking grpSpLocksField;

		// Token: 0x040017B6 RID: 6070
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
