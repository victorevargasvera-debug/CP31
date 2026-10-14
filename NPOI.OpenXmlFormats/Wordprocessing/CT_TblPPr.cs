using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001AE RID: 430
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblPPr
	{
		// Token: 0x06001033 RID: 4147 RVA: 0x00034F10 File Offset: 0x00033110
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPPr ct_TblPPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPPr();
			ct_TblPPr.leftFromText = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:leftFromText"]);
			ct_TblPPr.rightFromText = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:rightFromText"]);
			ct_TblPPr.topFromText = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:topFromText"]);
			ct_TblPPr.bottomFromText = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:bottomFromText"]);
			if (node.Attributes["w:vertAnchor"] != null)
			{
				ct_TblPPr.vertAnchor = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_VAnchor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_VAnchor), node.Attributes["w:vertAnchor"].Value);
			}
			if (node.Attributes["w:horzAnchor"] != null)
			{
				ct_TblPPr.horzAnchor = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_HAnchor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HAnchor), node.Attributes["w:horzAnchor"].Value);
			}
			if (node.Attributes["w:tblpXSpec"] != null)
			{
				ct_TblPPr.tblpXSpec = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_XAlign)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_XAlign), node.Attributes["w:tblpXSpec"].Value);
			}
			ct_TblPPr.tblpX = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:tblpX"]);
			if (node.Attributes["w:tblpYSpec"] != null)
			{
				ct_TblPPr.tblpYSpec = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_YAlign)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_YAlign), node.Attributes["w:tblpYSpec"].Value);
			}
			ct_TblPPr.tblpY = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:tblpY"]);
			return ct_TblPPr;
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000350D0 File Offset: 0x000332D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:leftFromText", this.leftFromText);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rightFromText", this.rightFromText);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:topFromText", this.topFromText);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:bottomFromText", this.bottomFromText);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:vertAnchor", this.vertAnchor.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:horzAnchor", this.horzAnchor.ToString());
			if (this.tblpXSpecFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:tblpXSpec", this.tblpXSpec.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:tblpX", this.tblpX);
			if (this.tblpYSpecFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:tblpYSpec", this.tblpYSpec.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:tblpY", this.tblpY);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x00035204 File Offset: 0x00033404
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x0003520C File Offset: 0x0003340C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong leftFromText
		{
			get
			{
				return this.leftFromTextField;
			}
			set
			{
				this.leftFromTextField = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x00035215 File Offset: 0x00033415
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x0003521D File Offset: 0x0003341D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool leftFromTextSpecified
		{
			get
			{
				return this.leftFromTextFieldSpecified;
			}
			set
			{
				this.leftFromTextFieldSpecified = value;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x00035226 File Offset: 0x00033426
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x0003522E File Offset: 0x0003342E
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong rightFromText
		{
			get
			{
				return this.rightFromTextField;
			}
			set
			{
				this.rightFromTextField = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x00035237 File Offset: 0x00033437
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x0003523F File Offset: 0x0003343F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rightFromTextSpecified
		{
			get
			{
				return this.rightFromTextFieldSpecified;
			}
			set
			{
				this.rightFromTextFieldSpecified = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00035248 File Offset: 0x00033448
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x00035250 File Offset: 0x00033450
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong topFromText
		{
			get
			{
				return this.topFromTextField;
			}
			set
			{
				this.topFromTextField = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x00035259 File Offset: 0x00033459
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x00035261 File Offset: 0x00033461
		[global::System.Xml.Serialization.XmlIgnore]
		public bool topFromTextSpecified
		{
			get
			{
				return this.topFromTextFieldSpecified;
			}
			set
			{
				this.topFromTextFieldSpecified = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x0003526A File Offset: 0x0003346A
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x00035272 File Offset: 0x00033472
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong bottomFromText
		{
			get
			{
				return this.bottomFromTextField;
			}
			set
			{
				this.bottomFromTextField = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0003527B File Offset: 0x0003347B
		// (set) Token: 0x06001044 RID: 4164 RVA: 0x00035283 File Offset: 0x00033483
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bottomFromTextSpecified
		{
			get
			{
				return this.bottomFromTextFieldSpecified;
			}
			set
			{
				this.bottomFromTextFieldSpecified = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x0003528C File Offset: 0x0003348C
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x00035294 File Offset: 0x00033494
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_VAnchor vertAnchor
		{
			get
			{
				return this.vertAnchorField;
			}
			set
			{
				this.vertAnchorField = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0003529D File Offset: 0x0003349D
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x000352A5 File Offset: 0x000334A5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool vertAnchorSpecified
		{
			get
			{
				return this.vertAnchorFieldSpecified;
			}
			set
			{
				this.vertAnchorFieldSpecified = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x000352AE File Offset: 0x000334AE
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x000352B6 File Offset: 0x000334B6
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_HAnchor horzAnchor
		{
			get
			{
				return this.horzAnchorField;
			}
			set
			{
				this.horzAnchorField = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x000352BF File Offset: 0x000334BF
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x000352C7 File Offset: 0x000334C7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool horzAnchorSpecified
		{
			get
			{
				return this.horzAnchorFieldSpecified;
			}
			set
			{
				this.horzAnchorFieldSpecified = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x000352D0 File Offset: 0x000334D0
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x000352D8 File Offset: 0x000334D8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_XAlign tblpXSpec
		{
			get
			{
				return this.tblpXSpecField;
			}
			set
			{
				this.tblpXSpecFieldSpecified = true;
				this.tblpXSpecField = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x000352E8 File Offset: 0x000334E8
		// (set) Token: 0x06001050 RID: 4176 RVA: 0x000352F0 File Offset: 0x000334F0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool tblpXSpecSpecified
		{
			get
			{
				return this.tblpXSpecFieldSpecified;
			}
			set
			{
				this.tblpXSpecFieldSpecified = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x000352F9 File Offset: 0x000334F9
		// (set) Token: 0x06001052 RID: 4178 RVA: 0x00035301 File Offset: 0x00033501
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string tblpX
		{
			get
			{
				return this.tblpXField;
			}
			set
			{
				this.tblpXField = value;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x0003530A File Offset: 0x0003350A
		// (set) Token: 0x06001054 RID: 4180 RVA: 0x00035312 File Offset: 0x00033512
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_YAlign tblpYSpec
		{
			get
			{
				return this.tblpYSpecField;
			}
			set
			{
				this.tblpYSpecFieldSpecified = true;
				this.tblpYSpecField = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00035322 File Offset: 0x00033522
		// (set) Token: 0x06001056 RID: 4182 RVA: 0x0003532A File Offset: 0x0003352A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool tblpYSpecSpecified
		{
			get
			{
				return this.tblpYSpecFieldSpecified;
			}
			set
			{
				this.tblpYSpecFieldSpecified = value;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00035333 File Offset: 0x00033533
		// (set) Token: 0x06001058 RID: 4184 RVA: 0x0003533B File Offset: 0x0003353B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string tblpY
		{
			get
			{
				return this.tblpYField;
			}
			set
			{
				this.tblpYField = value;
			}
		}

		// Token: 0x04000CF7 RID: 3319
		private ulong leftFromTextField;

		// Token: 0x04000CF8 RID: 3320
		private bool leftFromTextFieldSpecified;

		// Token: 0x04000CF9 RID: 3321
		private ulong rightFromTextField;

		// Token: 0x04000CFA RID: 3322
		private bool rightFromTextFieldSpecified;

		// Token: 0x04000CFB RID: 3323
		private ulong topFromTextField;

		// Token: 0x04000CFC RID: 3324
		private bool topFromTextFieldSpecified;

		// Token: 0x04000CFD RID: 3325
		private ulong bottomFromTextField;

		// Token: 0x04000CFE RID: 3326
		private bool bottomFromTextFieldSpecified;

		// Token: 0x04000CFF RID: 3327
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_VAnchor vertAnchorField;

		// Token: 0x04000D00 RID: 3328
		private bool vertAnchorFieldSpecified;

		// Token: 0x04000D01 RID: 3329
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_HAnchor horzAnchorField;

		// Token: 0x04000D02 RID: 3330
		private bool horzAnchorFieldSpecified;

		// Token: 0x04000D03 RID: 3331
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_XAlign tblpXSpecField;

		// Token: 0x04000D04 RID: 3332
		private bool tblpXSpecFieldSpecified;

		// Token: 0x04000D05 RID: 3333
		private string tblpXField;

		// Token: 0x04000D06 RID: 3334
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_YAlign tblpYSpecField;

		// Token: 0x04000D07 RID: 3335
		private bool tblpYSpecFieldSpecified;

		// Token: 0x04000D08 RID: 3336
		private string tblpYField;
	}
}
