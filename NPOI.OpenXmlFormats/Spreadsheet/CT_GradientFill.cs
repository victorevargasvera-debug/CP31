using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000544 RID: 1348
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_GradientFill
	{
		// Token: 0x06003ADF RID: 15071 RVA: 0x00091868 File Offset: 0x0008FA68
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientFill Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientFill ct_GradientFill = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientFill();
			if (node.Attributes["type"] != null)
			{
				ct_GradientFill.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_GradientType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_GradientType), node.Attributes["type"].Value);
			}
			ct_GradientFill.degree = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["degree"]);
			ct_GradientFill.left = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["left"]);
			ct_GradientFill.right = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["right"]);
			ct_GradientFill.top = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["top"]);
			ct_GradientFill.bottom = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["bottom"]);
			ct_GradientFill.stop = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientStop>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "stop")
				{
					ct_GradientFill.stop.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientStop.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_GradientFill;
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x000919C0 File Offset: 0x0008FBC0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "degree", this.degree);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "left", this.left);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "right", this.right);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "top", this.top);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bottom", this.bottom);
			sw.Write(">");
			if (this.stop != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientStop ct_GradientStop in this.stop)
				{
					ct_GradientStop.Write(sw, "stop");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x00091AC0 File Offset: 0x0008FCC0
		// (set) Token: 0x06003AE2 RID: 15074 RVA: 0x00091AC8 File Offset: 0x0008FCC8
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientStop> stop
		{
			get
			{
				return this.stopField;
			}
			set
			{
				this.stopField = value;
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x00091AD1 File Offset: 0x0008FCD1
		// (set) Token: 0x06003AE4 RID: 15076 RVA: 0x00091AE3 File Offset: 0x0008FCE3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_GradientType.linear)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_GradientType type
		{
			get
			{
				if (this.typeField != global::NPOI.OpenXmlFormats.Spreadsheet.ST_GradientType.NONE)
				{
					return this.typeField;
				}
				return global::NPOI.OpenXmlFormats.Spreadsheet.ST_GradientType.linear;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06003AE5 RID: 15077 RVA: 0x00091AEC File Offset: 0x0008FCEC
		// (set) Token: 0x06003AE6 RID: 15078 RVA: 0x00091AF4 File Offset: 0x0008FCF4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0.0)]
		public double degree
		{
			get
			{
				return this.degreeField;
			}
			set
			{
				this.degreeField = value;
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x00091AFD File Offset: 0x0008FCFD
		// (set) Token: 0x06003AE8 RID: 15080 RVA: 0x00091B05 File Offset: 0x0008FD05
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0.0)]
		public double left
		{
			get
			{
				return this.leftField;
			}
			set
			{
				this.leftField = value;
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06003AE9 RID: 15081 RVA: 0x00091B0E File Offset: 0x0008FD0E
		// (set) Token: 0x06003AEA RID: 15082 RVA: 0x00091B16 File Offset: 0x0008FD16
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0.0)]
		public double right
		{
			get
			{
				return this.rightField;
			}
			set
			{
				this.rightField = value;
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06003AEB RID: 15083 RVA: 0x00091B1F File Offset: 0x0008FD1F
		// (set) Token: 0x06003AEC RID: 15084 RVA: 0x00091B27 File Offset: 0x0008FD27
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0.0)]
		public double top
		{
			get
			{
				return this.topField;
			}
			set
			{
				this.topField = value;
			}
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06003AED RID: 15085 RVA: 0x00091B30 File Offset: 0x0008FD30
		// (set) Token: 0x06003AEE RID: 15086 RVA: 0x00091B38 File Offset: 0x0008FD38
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0.0)]
		public double bottom
		{
			get
			{
				return this.bottomField;
			}
			set
			{
				this.bottomField = value;
			}
		}

		// Token: 0x040025BA RID: 9658
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientStop> stopField;

		// Token: 0x040025BB RID: 9659
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_GradientType typeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_GradientType.linear;

		// Token: 0x040025BC RID: 9660
		private double degreeField;

		// Token: 0x040025BD RID: 9661
		private double leftField;

		// Token: 0x040025BE RID: 9662
		private double rightField;

		// Token: 0x040025BF RID: 9663
		private double topField;

		// Token: 0x040025C0 RID: 9664
		private double bottomField;
	}
}
