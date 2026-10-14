using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200029F RID: 671
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Backdrop
	{
		// Token: 0x06001B50 RID: 6992 RVA: 0x00049F34 File Offset: 0x00048134
		public static global::NPOI.OpenXmlFormats.Dml.CT_Backdrop Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_Backdrop ct_Backdrop = new global::NPOI.OpenXmlFormats.Dml.CT_Backdrop();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "anchor")
				{
					ct_Backdrop.anchor = global::NPOI.OpenXmlFormats.Dml.CT_Point3D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "norm")
				{
					ct_Backdrop.norm = global::NPOI.OpenXmlFormats.Dml.CT_Vector3D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "up")
				{
					ct_Backdrop.up = global::NPOI.OpenXmlFormats.Dml.CT_Vector3D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Backdrop.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Backdrop;
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0004A01C File Offset: 0x0004821C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.anchor != null)
			{
				this.anchor.Write(sw, "anchor");
			}
			if (this.norm != null)
			{
				this.norm.Write(sw, "norm");
			}
			if (this.up != null)
			{
				this.up.Write(sw, "up");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0004A0BA File Offset: 0x000482BA
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0004A0C2 File Offset: 0x000482C2
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Point3D anchor
		{
			get
			{
				return this.anchorField;
			}
			set
			{
				this.anchorField = value;
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0004A0CB File Offset: 0x000482CB
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0004A0D3 File Offset: 0x000482D3
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Vector3D norm
		{
			get
			{
				return this.normField;
			}
			set
			{
				this.normField = value;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0004A0DC File Offset: 0x000482DC
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x0004A0E4 File Offset: 0x000482E4
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Vector3D up
		{
			get
			{
				return this.upField;
			}
			set
			{
				this.upField = value;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x0004A0ED File Offset: 0x000482ED
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x0004A0F5 File Offset: 0x000482F5
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

		// Token: 0x0400146C RID: 5228
		private global::NPOI.OpenXmlFormats.Dml.CT_Point3D anchorField;

		// Token: 0x0400146D RID: 5229
		private global::NPOI.OpenXmlFormats.Dml.CT_Vector3D normField;

		// Token: 0x0400146E RID: 5230
		private global::NPOI.OpenXmlFormats.Dml.CT_Vector3D upField;

		// Token: 0x0400146F RID: 5231
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
