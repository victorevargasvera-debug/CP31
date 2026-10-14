using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Picture;
using NPOI.OpenXmlFormats.Vml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200012C RID: 300
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Picture : global::NPOI.OpenXmlFormats.Wordprocessing.CT_PictureBase
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0001B738 File Offset: 0x00019938
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x0001B740 File Offset: 0x00019940
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel movie
		{
			get
			{
				return this.movieField;
			}
			set
			{
				this.movieField = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x0001B749 File Offset: 0x00019949
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x0001B751 File Offset: 0x00019951
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Control control
		{
			get
			{
				return this.controlField;
			}
			set
			{
				this.controlField = value;
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000024E5 File Offset: 0x000006E5
		public global::NPOI.OpenXmlFormats.Dml.Picture.CT_PictureNonVisual AddNewNvPicPr()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000024E5 File Offset: 0x000006E5
		public global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties AddNewBlipFill()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000024E5 File Offset: 0x000006E5
		public global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties AddNewSpPr()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0001B75C File Offset: 0x0001995C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture ct_Picture = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "movie")
				{
					ct_Picture.movie = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "control")
				{
					ct_Picture.control = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Control.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.Prefix == "o")
				{
					ct_Picture.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType9.office);
					ct_Picture.Items.Add(xmlNode);
				}
				else if (xmlNode.Prefix == "v")
				{
					ct_Picture.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType9.vml);
					ct_Picture.Items.Add(xmlNode);
				}
			}
			return ct_Picture;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0001B858 File Offset: 0x00019A58
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}>", nodeName));
			if (this.movie != null)
			{
				this.movie.Write(sw, "movie");
			}
			if (this.control != null)
			{
				this.control.Write(sw, "control");
			}
			foreach (object obj in base.Items)
			{
				if (obj is global::System.Xml.XmlNode)
				{
					sw.Write(((global::System.Xml.XmlNode)obj).OuterXml);
				}
				else if (obj is global::NPOI.OpenXmlFormats.Vml.CT_Shape)
				{
					((global::NPOI.OpenXmlFormats.Vml.CT_Shape)obj).Write(sw, "shape");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Vml.CT_Shapetype)
				{
					((global::NPOI.OpenXmlFormats.Vml.CT_Shapetype)obj).Write(sw, "shapetype");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x0400073A RID: 1850
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel movieField;

		// Token: 0x0400073B RID: 1851
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Control controlField;
	}
}
