using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000280 RID: 640
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EffectStyleItem
	{
		// Token: 0x06001A7B RID: 6779 RVA: 0x00047BB8 File Offset: 0x00045DB8
		public static global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleItem Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleItem ct_EffectStyleItem = new global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleItem();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "effectLst")
				{
					ct_EffectStyleItem.effectLst = global::NPOI.OpenXmlFormats.Dml.CT_EffectList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effectDag")
				{
					ct_EffectStyleItem.effectDag = global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "scene3d")
				{
					ct_EffectStyleItem.scene3d = global::NPOI.OpenXmlFormats.Dml.CT_Scene3D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sp3d")
				{
					ct_EffectStyleItem.sp3d = global::NPOI.OpenXmlFormats.Dml.CT_Shape3D.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_EffectStyleItem;
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00047CA0 File Offset: 0x00045EA0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.effectLst != null)
			{
				this.effectLst.Write(sw, "effectLst");
			}
			if (this.effectDag != null)
			{
				this.effectDag.Write(sw, "effectDag");
			}
			if (this.scene3d != null)
			{
				this.scene3d.Write(sw, "scene3d");
			}
			if (this.sp3d != null)
			{
				this.sp3d.Write(sw, "sp3d");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x00047D3E File Offset: 0x00045F3E
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x00047D46 File Offset: 0x00045F46
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLst
		{
			get
			{
				return this.effectLstField;
			}
			set
			{
				this.effectLstField = value;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x00047D4F File Offset: 0x00045F4F
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x00047D57 File Offset: 0x00045F57
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDag
		{
			get
			{
				return this.effectDagField;
			}
			set
			{
				this.effectDagField = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00047D60 File Offset: 0x00045F60
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x00047D68 File Offset: 0x00045F68
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3d
		{
			get
			{
				return this.scene3dField;
			}
			set
			{
				this.scene3dField = value;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00047D71 File Offset: 0x00045F71
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x00047D79 File Offset: 0x00045F79
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3d
		{
			get
			{
				return this.sp3dField;
			}
			set
			{
				this.sp3dField = value;
			}
		}

		// Token: 0x040013C5 RID: 5061
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLstField;

		// Token: 0x040013C6 RID: 5062
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDagField;

		// Token: 0x040013C7 RID: 5063
		private global::NPOI.OpenXmlFormats.Dml.CT_Scene3D scene3dField;

		// Token: 0x040013C8 RID: 5064
		private global::NPOI.OpenXmlFormats.Dml.CT_Shape3D sp3dField;
	}
}
