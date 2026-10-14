using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000435 RID: 1077
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PictureOptions
	{
		// Token: 0x06002B22 RID: 11042 RVA: 0x0006C354 File Offset: 0x0006A554
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions ct_PictureOptions = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "applyToFront")
				{
					ct_PictureOptions.applyToFront = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "applyToSides")
				{
					ct_PictureOptions.applyToSides = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "applyToEnd")
				{
					ct_PictureOptions.applyToEnd = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pictureFormat")
				{
					ct_PictureOptions.pictureFormat = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureFormat.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pictureStackUnit")
				{
					ct_PictureOptions.pictureStackUnit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureStackUnit.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PictureOptions;
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x0006C460 File Offset: 0x0006A660
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.applyToFront != null)
			{
				this.applyToFront.Write(sw, "applyToFront");
			}
			if (this.applyToSides != null)
			{
				this.applyToSides.Write(sw, "applyToSides");
			}
			if (this.applyToEnd != null)
			{
				this.applyToEnd.Write(sw, "applyToEnd");
			}
			if (this.pictureFormat != null)
			{
				this.pictureFormat.Write(sw, "pictureFormat");
			}
			if (this.pictureStackUnit != null)
			{
				this.pictureStackUnit.Write(sw, "pictureStackUnit");
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x0006C517 File Offset: 0x0006A717
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x0006C51F File Offset: 0x0006A71F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean applyToFront
		{
			get
			{
				return this.applyToFrontField;
			}
			set
			{
				this.applyToFrontField = value;
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x0006C528 File Offset: 0x0006A728
		// (set) Token: 0x06002B27 RID: 11047 RVA: 0x0006C530 File Offset: 0x0006A730
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean applyToSides
		{
			get
			{
				return this.applyToSidesField;
			}
			set
			{
				this.applyToSidesField = value;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x0006C539 File Offset: 0x0006A739
		// (set) Token: 0x06002B29 RID: 11049 RVA: 0x0006C541 File Offset: 0x0006A741
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean applyToEnd
		{
			get
			{
				return this.applyToEndField;
			}
			set
			{
				this.applyToEndField = value;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x0006C54A File Offset: 0x0006A74A
		// (set) Token: 0x06002B2B RID: 11051 RVA: 0x0006C552 File Offset: 0x0006A752
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureFormat pictureFormat
		{
			get
			{
				return this.pictureFormatField;
			}
			set
			{
				this.pictureFormatField = value;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x0006C55B File Offset: 0x0006A75B
		// (set) Token: 0x06002B2D RID: 11053 RVA: 0x0006C563 File Offset: 0x0006A763
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureStackUnit pictureStackUnit
		{
			get
			{
				return this.pictureStackUnitField;
			}
			set
			{
				this.pictureStackUnitField = value;
			}
		}

		// Token: 0x04001E9C RID: 7836
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean applyToFrontField;

		// Token: 0x04001E9D RID: 7837
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean applyToSidesField;

		// Token: 0x04001E9E RID: 7838
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean applyToEndField;

		// Token: 0x04001E9F RID: 7839
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureFormat pictureFormatField;

		// Token: 0x04001EA0 RID: 7840
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureStackUnit pictureStackUnitField;
	}
}
