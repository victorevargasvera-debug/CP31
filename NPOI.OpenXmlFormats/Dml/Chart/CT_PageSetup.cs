using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003F5 RID: 1013
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PageSetup
	{
		// Token: 0x06002888 RID: 10376 RVA: 0x000660FC File Offset: 0x000642FC
		public CT_PageSetup()
		{
			this.paperSizeField = 1U;
			this.firstPageNumberField = 1U;
			this.orientationField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_PageSetupOrientation.@default;
			this.blackAndWhiteField = false;
			this.draftField = false;
			this.useFirstPageNumberField = false;
			this.horizontalDpiField = 600;
			this.verticalDpiField = 600;
			this.copiesField = 1U;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00066158 File Offset: 0x00064358
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageSetup Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageSetup ct_PageSetup = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageSetup();
			if (node.Attributes["paperSize"] != null)
			{
				ct_PageSetup.paperSize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["paperSize"]);
			}
			if (node.Attributes["firstPageNumber"] != null)
			{
				ct_PageSetup.firstPageNumber = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["firstPageNumber"]);
			}
			if (node.Attributes["orientation"] != null)
			{
				ct_PageSetup.orientation = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_PageSetupOrientation)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_PageSetupOrientation), node.Attributes["orientation"].Value);
			}
			if (node.Attributes["blackAndWhite"] != null)
			{
				ct_PageSetup.blackAndWhite = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["blackAndWhite"]);
			}
			if (node.Attributes["draft"] != null)
			{
				ct_PageSetup.draft = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["draft"]);
			}
			if (node.Attributes["useFirstPageNumber"] != null)
			{
				ct_PageSetup.useFirstPageNumber = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["useFirstPageNumber"]);
			}
			if (node.Attributes["horizontalDpi"] != null)
			{
				ct_PageSetup.horizontalDpi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["horizontalDpi"]);
			}
			if (node.Attributes["verticalDpi"] != null)
			{
				ct_PageSetup.verticalDpi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["verticalDpi"]);
			}
			if (node.Attributes["copies"] != null)
			{
				ct_PageSetup.copies = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["copies"]);
			}
			return ct_PageSetup;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x0006631C File Offset: 0x0006451C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "paperSize", this.paperSize, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "firstPageNumber", this.firstPageNumber, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "orientation", this.orientation.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "blackAndWhite", this.blackAndWhite);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "draft", this.draft);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "useFirstPageNumber", this.useFirstPageNumber);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "horizontalDpi", this.horizontalDpi);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "verticalDpi", this.verticalDpi);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "copies", this.copies, false);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x0600288B RID: 10379 RVA: 0x00066400 File Offset: 0x00064600
		// (set) Token: 0x0600288C RID: 10380 RVA: 0x00066408 File Offset: 0x00064608
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint paperSize
		{
			get
			{
				return this.paperSizeField;
			}
			set
			{
				this.paperSizeField = value;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x0600288D RID: 10381 RVA: 0x00066411 File Offset: 0x00064611
		// (set) Token: 0x0600288E RID: 10382 RVA: 0x00066419 File Offset: 0x00064619
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint firstPageNumber
		{
			get
			{
				return this.firstPageNumberField;
			}
			set
			{
				this.firstPageNumberField = value;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x00066422 File Offset: 0x00064622
		// (set) Token: 0x06002890 RID: 10384 RVA: 0x0006642A File Offset: 0x0006462A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_PageSetupOrientation.@default)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_PageSetupOrientation orientation
		{
			get
			{
				return this.orientationField;
			}
			set
			{
				this.orientationField = value;
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x00066433 File Offset: 0x00064633
		// (set) Token: 0x06002892 RID: 10386 RVA: 0x0006643B File Offset: 0x0006463B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool blackAndWhite
		{
			get
			{
				return this.blackAndWhiteField;
			}
			set
			{
				this.blackAndWhiteField = value;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x00066444 File Offset: 0x00064644
		// (set) Token: 0x06002894 RID: 10388 RVA: 0x0006644C File Offset: 0x0006464C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool draft
		{
			get
			{
				return this.draftField;
			}
			set
			{
				this.draftField = value;
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x00066455 File Offset: 0x00064655
		// (set) Token: 0x06002896 RID: 10390 RVA: 0x0006645D File Offset: 0x0006465D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool useFirstPageNumber
		{
			get
			{
				return this.useFirstPageNumberField;
			}
			set
			{
				this.useFirstPageNumberField = value;
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x00066466 File Offset: 0x00064666
		// (set) Token: 0x06002898 RID: 10392 RVA: 0x0006646E File Offset: 0x0006466E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(600)]
		public int horizontalDpi
		{
			get
			{
				return this.horizontalDpiField;
			}
			set
			{
				this.horizontalDpiField = value;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x00066477 File Offset: 0x00064677
		// (set) Token: 0x0600289A RID: 10394 RVA: 0x0006647F File Offset: 0x0006467F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(600)]
		public int verticalDpi
		{
			get
			{
				return this.verticalDpiField;
			}
			set
			{
				this.verticalDpiField = value;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x00066488 File Offset: 0x00064688
		// (set) Token: 0x0600289C RID: 10396 RVA: 0x00066490 File Offset: 0x00064690
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint copies
		{
			get
			{
				return this.copiesField;
			}
			set
			{
				this.copiesField = value;
			}
		}

		// Token: 0x04001D78 RID: 7544
		private uint paperSizeField;

		// Token: 0x04001D79 RID: 7545
		private uint firstPageNumberField;

		// Token: 0x04001D7A RID: 7546
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_PageSetupOrientation orientationField;

		// Token: 0x04001D7B RID: 7547
		private bool blackAndWhiteField;

		// Token: 0x04001D7C RID: 7548
		private bool draftField;

		// Token: 0x04001D7D RID: 7549
		private bool useFirstPageNumberField;

		// Token: 0x04001D7E RID: 7550
		private int horizontalDpiField;

		// Token: 0x04001D7F RID: 7551
		private int verticalDpiField;

		// Token: 0x04001D80 RID: 7552
		private uint copiesField;
	}
}
