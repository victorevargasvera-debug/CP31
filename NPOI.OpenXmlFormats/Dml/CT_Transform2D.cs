using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002C0 RID: 704
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Transform2D
	{
		// Token: 0x06001BE4 RID: 7140 RVA: 0x0004CDAC File Offset: 0x0004AFAC
		public static global::NPOI.OpenXmlFormats.Dml.CT_Transform2D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_Transform2D ct_Transform2D = new global::NPOI.OpenXmlFormats.Dml.CT_Transform2D();
			ct_Transform2D.rot = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["rot"]);
			ct_Transform2D.flipH = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["flipH"]);
			ct_Transform2D.flipV = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["flipV"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "off")
				{
					ct_Transform2D.off = global::NPOI.OpenXmlFormats.Dml.CT_Point2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ext")
				{
					ct_Transform2D.ext = global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Transform2D;
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0004CE9C File Offset: 0x0004B09C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rot", this.rot);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "flipH", this.flipH, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "flipV", this.flipV, false);
			sw.Write(">");
			if (this.off != null)
			{
				this.off.Write(sw, "off");
			}
			if (this.ext != null)
			{
				this.ext.Write(sw, "a:ext");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0004CF3D File Offset: 0x0004B13D
		public global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D AddNewExt()
		{
			this.extField = new global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D();
			return this.extField;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0004CF50 File Offset: 0x0004B150
		public global::NPOI.OpenXmlFormats.Dml.CT_Point2D AddNewOff()
		{
			this.offField = new global::NPOI.OpenXmlFormats.Dml.CT_Point2D();
			return this.offField;
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x0004CF63 File Offset: 0x0004B163
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0004CF6B File Offset: 0x0004B16B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Point2D off
		{
			get
			{
				return this.offField;
			}
			set
			{
				this.offField = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x0004CF74 File Offset: 0x0004B174
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x0004CF7C File Offset: 0x0004B17C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x0004CF85 File Offset: 0x0004B185
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x0004CFA1 File Offset: 0x0004B1A1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int rot
		{
			get
			{
				if (this.rotField != null)
				{
					return this.rotField.Value;
				}
				return 0;
			}
			set
			{
				this.rotField = new int?(value);
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x0004CFAF File Offset: 0x0004B1AF
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0004CFCB File Offset: 0x0004B1CB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool flipH
		{
			get
			{
				return this.flipHField != null && this.flipHField.Value;
			}
			set
			{
				this.flipHField = new bool?(value);
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x0004CFD9 File Offset: 0x0004B1D9
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x0004CFF5 File Offset: 0x0004B1F5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool flipV
		{
			get
			{
				return this.flipVField != null && this.flipVField.Value;
			}
			set
			{
				this.flipVField = new bool?(value);
			}
		}

		// Token: 0x040015E2 RID: 5602
		private global::NPOI.OpenXmlFormats.Dml.CT_Point2D offField;

		// Token: 0x040015E3 RID: 5603
		private global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D extField;

		// Token: 0x040015E4 RID: 5604
		private int? rotField;

		// Token: 0x040015E5 RID: 5605
		private bool? flipHField;

		// Token: 0x040015E6 RID: 5606
		private bool? flipVField;
	}
}
