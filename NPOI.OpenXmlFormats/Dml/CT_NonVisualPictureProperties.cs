using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002FC RID: 764
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NonVisualPictureProperties
	{
		// Token: 0x06001DCC RID: 7628 RVA: 0x00050BA8 File Offset: 0x0004EDA8
		public static global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties ct_NonVisualPictureProperties = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualPictureProperties();
			ct_NonVisualPictureProperties.preferRelativeResize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["preferRelativeResize"], true);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "picLocks")
				{
					ct_NonVisualPictureProperties.picLocks = global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_NonVisualPictureProperties.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NonVisualPictureProperties;
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00050C64 File Offset: 0x0004EE64
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<pic:{0}", nodeName));
			if (!this.preferRelativeResize)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "preferRelativeResize", this.preferRelativeResize);
			}
			sw.Write(">");
			if (this.picLocks != null)
			{
				this.picLocks.Write(sw, "picLocks");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</pic:{0}>", nodeName));
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00050CF8 File Offset: 0x0004EEF8
		public global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking AddNewPicLocks()
		{
			this.picLocksField = new global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking();
			return this.picLocksField;
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00050D0B File Offset: 0x0004EF0B
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x00050D13 File Offset: 0x0004EF13
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking picLocks
		{
			get
			{
				return this.picLocksField;
			}
			set
			{
				this.picLocksField = value;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00050D1C File Offset: 0x0004EF1C
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x00050D24 File Offset: 0x0004EF24
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

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00050D2D File Offset: 0x0004EF2D
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x00050D35 File Offset: 0x0004EF35
		[global::System.Xml.Serialization.XmlAttribute]
		public bool preferRelativeResize
		{
			get
			{
				return this.preferRelativeResizeField;
			}
			set
			{
				this.preferRelativeResizeField = value;
			}
		}

		// Token: 0x040017B2 RID: 6066
		private global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking picLocksField;

		// Token: 0x040017B3 RID: 6067
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040017B4 RID: 6068
		private bool preferRelativeResizeField = true;
	}
}
