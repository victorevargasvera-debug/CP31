using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200029E RID: 670
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Scene3D
	{
		// Token: 0x06001B45 RID: 6981 RVA: 0x00049D68 File Offset: 0x00047F68
		public static global::NPOI.OpenXmlFormats.Dml.CT_Scene3D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_Scene3D ct_Scene3D = new global::NPOI.OpenXmlFormats.Dml.CT_Scene3D();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "camera")
				{
					ct_Scene3D.camera = global::NPOI.OpenXmlFormats.Dml.CT_Camera.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lightRig")
				{
					ct_Scene3D.lightRig = global::NPOI.OpenXmlFormats.Dml.CT_LightRig.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "backdrop")
				{
					ct_Scene3D.backdrop = global::NPOI.OpenXmlFormats.Dml.CT_Backdrop.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Scene3D.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Scene3D;
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00049E50 File Offset: 0x00048050
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.camera != null)
			{
				this.camera.Write(sw, "camera");
			}
			if (this.lightRig != null)
			{
				this.lightRig.Write(sw, "lightRig");
			}
			if (this.backdrop != null)
			{
				this.backdrop.Write(sw, "backdrop");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00049EEE File Offset: 0x000480EE
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x00049EF6 File Offset: 0x000480F6
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Camera camera
		{
			get
			{
				return this.cameraField;
			}
			set
			{
				this.cameraField = value;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00049EFF File Offset: 0x000480FF
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x00049F07 File Offset: 0x00048107
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LightRig lightRig
		{
			get
			{
				return this.lightRigField;
			}
			set
			{
				this.lightRigField = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00049F10 File Offset: 0x00048110
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x00049F18 File Offset: 0x00048118
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Backdrop backdrop
		{
			get
			{
				return this.backdropField;
			}
			set
			{
				this.backdropField = value;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00049F21 File Offset: 0x00048121
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x00049F29 File Offset: 0x00048129
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x04001468 RID: 5224
		private global::NPOI.OpenXmlFormats.Dml.CT_Camera cameraField;

		// Token: 0x04001469 RID: 5225
		private global::NPOI.OpenXmlFormats.Dml.CT_LightRig lightRigField;

		// Token: 0x0400146A RID: 5226
		private global::NPOI.OpenXmlFormats.Dml.CT_Backdrop backdropField;

		// Token: 0x0400146B RID: 5227
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
