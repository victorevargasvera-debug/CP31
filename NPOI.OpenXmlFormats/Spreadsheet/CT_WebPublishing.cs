using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200052B RID: 1323
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_WebPublishing
	{
		// Token: 0x06003A20 RID: 14880 RVA: 0x0009057C File Offset: 0x0008E77C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishing Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishing ct_WebPublishing = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishing();
			ct_WebPublishing.css = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["css"]);
			ct_WebPublishing.thicket = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["thicket"]);
			ct_WebPublishing.longFileNames = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["longFileNames"]);
			ct_WebPublishing.vml = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["vml"]);
			ct_WebPublishing.allowPng = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["allowPng"]);
			if (node.Attributes["targetScreenSize"] != null)
			{
				ct_WebPublishing.targetScreenSize = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_TargetScreenSize)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_TargetScreenSize), node.Attributes["targetScreenSize"].Value);
			}
			ct_WebPublishing.dpi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dpi"]);
			ct_WebPublishing.codePage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["codePage"]);
			return ct_WebPublishing;
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00090694 File Offset: 0x0008E894
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "css", this.css);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "thicket", this.thicket);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "longFileNames", this.longFileNames);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "vml", this.vml);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "allowPng", this.allowPng);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "targetScreenSize", this.targetScreenSize.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dpi", this.dpi, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "codePage", this.codePage, false);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x00090766 File Offset: 0x0008E966
		public CT_WebPublishing()
		{
			this.cssField = true;
			this.thicketField = true;
			this.longFileNamesField = true;
			this.vmlField = false;
			this.allowPngField = false;
			this.targetScreenSizeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_TargetScreenSize.Item800x600;
			this.dpiField = 96U;
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06003A23 RID: 14883 RVA: 0x000907A0 File Offset: 0x0008E9A0
		// (set) Token: 0x06003A24 RID: 14884 RVA: 0x000907A8 File Offset: 0x0008E9A8
		[global::System.ComponentModel.DefaultValue(true)]
		public bool css
		{
			get
			{
				return this.cssField;
			}
			set
			{
				this.cssField = value;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06003A25 RID: 14885 RVA: 0x000907B1 File Offset: 0x0008E9B1
		// (set) Token: 0x06003A26 RID: 14886 RVA: 0x000907B9 File Offset: 0x0008E9B9
		[global::System.ComponentModel.DefaultValue(true)]
		public bool thicket
		{
			get
			{
				return this.thicketField;
			}
			set
			{
				this.thicketField = value;
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06003A27 RID: 14887 RVA: 0x000907C2 File Offset: 0x0008E9C2
		// (set) Token: 0x06003A28 RID: 14888 RVA: 0x000907CA File Offset: 0x0008E9CA
		[global::System.ComponentModel.DefaultValue(true)]
		public bool longFileNames
		{
			get
			{
				return this.longFileNamesField;
			}
			set
			{
				this.longFileNamesField = value;
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x000907D3 File Offset: 0x0008E9D3
		// (set) Token: 0x06003A2A RID: 14890 RVA: 0x000907DB File Offset: 0x0008E9DB
		[global::System.ComponentModel.DefaultValue(false)]
		public bool vml
		{
			get
			{
				return this.vmlField;
			}
			set
			{
				this.vmlField = value;
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x000907E4 File Offset: 0x0008E9E4
		// (set) Token: 0x06003A2C RID: 14892 RVA: 0x000907EC File Offset: 0x0008E9EC
		[global::System.ComponentModel.DefaultValue(false)]
		public bool allowPng
		{
			get
			{
				return this.allowPngField;
			}
			set
			{
				this.allowPngField = value;
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x000907F5 File Offset: 0x0008E9F5
		// (set) Token: 0x06003A2E RID: 14894 RVA: 0x000907FD File Offset: 0x0008E9FD
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_TargetScreenSize.Item800x600)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_TargetScreenSize targetScreenSize
		{
			get
			{
				return this.targetScreenSizeField;
			}
			set
			{
				this.targetScreenSizeField = value;
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06003A2F RID: 14895 RVA: 0x00090806 File Offset: 0x0008EA06
		// (set) Token: 0x06003A30 RID: 14896 RVA: 0x0009080E File Offset: 0x0008EA0E
		[global::System.ComponentModel.DefaultValue(typeof(uint), "96")]
		public uint dpi
		{
			get
			{
				return this.dpiField;
			}
			set
			{
				this.dpiField = value;
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06003A31 RID: 14897 RVA: 0x00090817 File Offset: 0x0008EA17
		// (set) Token: 0x06003A32 RID: 14898 RVA: 0x0009081F File Offset: 0x0008EA1F
		public uint codePage
		{
			get
			{
				return this.codePageField;
			}
			set
			{
				this.codePageField = value;
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06003A33 RID: 14899 RVA: 0x00090828 File Offset: 0x0008EA28
		// (set) Token: 0x06003A34 RID: 14900 RVA: 0x00090830 File Offset: 0x0008EA30
		[global::System.Xml.Serialization.XmlIgnore]
		public bool codePageSpecified
		{
			get
			{
				return this.codePageFieldSpecified;
			}
			set
			{
				this.codePageFieldSpecified = value;
			}
		}

		// Token: 0x04002519 RID: 9497
		private bool cssField;

		// Token: 0x0400251A RID: 9498
		private bool thicketField;

		// Token: 0x0400251B RID: 9499
		private bool longFileNamesField;

		// Token: 0x0400251C RID: 9500
		private bool vmlField;

		// Token: 0x0400251D RID: 9501
		private bool allowPngField;

		// Token: 0x0400251E RID: 9502
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_TargetScreenSize targetScreenSizeField;

		// Token: 0x0400251F RID: 9503
		private uint dpiField;

		// Token: 0x04002520 RID: 9504
		private uint codePageField;

		// Token: 0x04002521 RID: 9505
		private bool codePageFieldSpecified;
	}
}
