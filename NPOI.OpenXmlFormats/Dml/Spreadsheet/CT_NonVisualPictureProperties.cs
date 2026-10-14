using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x0200036B RID: 875
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_NonVisualPictureProperties
	{
		// Token: 0x060022C0 RID: 8896 RVA: 0x0005AA44 File Offset: 0x00058C44
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualPictureProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualPictureProperties ct_NonVisualPictureProperties = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualPictureProperties();
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

		// Token: 0x060022C1 RID: 8897 RVA: 0x0005AB00 File Offset: 0x00058D00
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
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
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0005AB94 File Offset: 0x00058D94
		public global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking AddNewPicLocks()
		{
			this.picLocksField = new global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking();
			return this.picLocksField;
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x0005ABA7 File Offset: 0x00058DA7
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x0005ABAF File Offset: 0x00058DAF
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

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0005ABB8 File Offset: 0x00058DB8
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x0005ABC0 File Offset: 0x00058DC0
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

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x0005ABC9 File Offset: 0x00058DC9
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x0005ABD1 File Offset: 0x00058DD1
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

		// Token: 0x04001A32 RID: 6706
		private global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking picLocksField;

		// Token: 0x04001A33 RID: 6707
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001A34 RID: 6708
		private bool preferRelativeResizeField = true;
	}
}
