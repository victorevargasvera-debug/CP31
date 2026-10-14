using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200019A RID: 410
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Caption
	{
		// Token: 0x06000F63 RID: 3939 RVA: 0x00032484 File Offset: 0x00030684
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Caption Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Caption ct_Caption = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Caption();
			ct_Caption.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:name"]);
			if (node.Attributes["w:pos"] != null)
			{
				ct_Caption.pos = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_CaptionPos)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_CaptionPos), node.Attributes["w:pos"].Value);
			}
			if (node.Attributes["w:chapNum"] != null)
			{
				ct_Caption.chapNum = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:chapNum"].Value, true);
			}
			ct_Caption.heading = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:heading"]);
			if (node.Attributes["w:noLabel"] != null)
			{
				ct_Caption.noLabel = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:noLabel"].Value, true);
			}
			if (node.Attributes["w:numFmt"] != null)
			{
				ct_Caption.numFmt = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat), node.Attributes["w:numFmt"].Value);
			}
			if (node.Attributes["w:sep"] != null)
			{
				ct_Caption.sep = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ChapterSep)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ChapterSep), node.Attributes["w:sep"].Value);
			}
			return ct_Caption;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0003261C File Offset: 0x0003081C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:pos", this.pos.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:chapNum", this.chapNum.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:heading", this.heading);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:noLabel", this.noLabel.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:numFmt", this.numFmt.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:sep", this.sep.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00032713 File Offset: 0x00030913
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x0003271B File Offset: 0x0003091B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00032724 File Offset: 0x00030924
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x0003272C File Offset: 0x0003092C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_CaptionPos pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00032735 File Offset: 0x00030935
		// (set) Token: 0x06000F6A RID: 3946 RVA: 0x0003273D File Offset: 0x0003093D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool posSpecified
		{
			get
			{
				return this.posFieldSpecified;
			}
			set
			{
				this.posFieldSpecified = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00032746 File Offset: 0x00030946
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x0003274E File Offset: 0x0003094E
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff chapNum
		{
			get
			{
				return this.chapNumField;
			}
			set
			{
				this.chapNumField = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x00032757 File Offset: 0x00030957
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x0003275F File Offset: 0x0003095F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool chapNumSpecified
		{
			get
			{
				return this.chapNumFieldSpecified;
			}
			set
			{
				this.chapNumFieldSpecified = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00032768 File Offset: 0x00030968
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00032770 File Offset: 0x00030970
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string heading
		{
			get
			{
				return this.headingField;
			}
			set
			{
				this.headingField = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x00032779 File Offset: 0x00030979
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x00032781 File Offset: 0x00030981
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff noLabel
		{
			get
			{
				return this.noLabelField;
			}
			set
			{
				this.noLabelField = value;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x0003278A File Offset: 0x0003098A
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00032792 File Offset: 0x00030992
		[global::System.Xml.Serialization.XmlIgnore]
		public bool noLabelSpecified
		{
			get
			{
				return this.noLabelFieldSpecified;
			}
			set
			{
				this.noLabelFieldSpecified = value;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x0003279B File Offset: 0x0003099B
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x000327A3 File Offset: 0x000309A3
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat numFmt
		{
			get
			{
				return this.numFmtField;
			}
			set
			{
				this.numFmtField = value;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x000327AC File Offset: 0x000309AC
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x000327B4 File Offset: 0x000309B4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool numFmtSpecified
		{
			get
			{
				return this.numFmtFieldSpecified;
			}
			set
			{
				this.numFmtFieldSpecified = value;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x000327BD File Offset: 0x000309BD
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x000327C5 File Offset: 0x000309C5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ChapterSep sep
		{
			get
			{
				return this.sepField;
			}
			set
			{
				this.sepField = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x000327CE File Offset: 0x000309CE
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x000327D6 File Offset: 0x000309D6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool sepSpecified
		{
			get
			{
				return this.sepFieldSpecified;
			}
			set
			{
				this.sepFieldSpecified = value;
			}
		}

		// Token: 0x04000C94 RID: 3220
		private string nameField;

		// Token: 0x04000C95 RID: 3221
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_CaptionPos posField;

		// Token: 0x04000C96 RID: 3222
		private bool posFieldSpecified;

		// Token: 0x04000C97 RID: 3223
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff chapNumField;

		// Token: 0x04000C98 RID: 3224
		private bool chapNumFieldSpecified;

		// Token: 0x04000C99 RID: 3225
		private string headingField;

		// Token: 0x04000C9A RID: 3226
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff noLabelField;

		// Token: 0x04000C9B RID: 3227
		private bool noLabelFieldSpecified;

		// Token: 0x04000C9C RID: 3228
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat numFmtField;

		// Token: 0x04000C9D RID: 3229
		private bool numFmtFieldSpecified;

		// Token: 0x04000C9E RID: 3230
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ChapterSep sepField;

		// Token: 0x04000C9F RID: 3231
		private bool sepFieldSpecified;
	}
}
