using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000A3 RID: 163
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FramePr
	{
		// Token: 0x06000475 RID: 1141 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FramePr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FramePr ct_FramePr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FramePr();
			if (node.Attributes["w:dropCap"] != null)
			{
				ct_FramePr.dropCap = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_DropCap)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DropCap), node.Attributes["w:dropCap"].Value);
			}
			ct_FramePr.lines = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:lines"]);
			ct_FramePr.w = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:w"]);
			ct_FramePr.h = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:h"]);
			ct_FramePr.vSpace = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:vSpace"]);
			ct_FramePr.hSpace = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:hSpace"]);
			if (node.Attributes["w:wrap"] != null)
			{
				ct_FramePr.wrap = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Wrap)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Wrap), node.Attributes["w:wrap"].Value);
			}
			if (node.Attributes["w:hAnchor"] != null)
			{
				ct_FramePr.hAnchor = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_HAnchor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HAnchor), node.Attributes["w:hAnchor"].Value);
			}
			if (node.Attributes["w:vAnchor"] != null)
			{
				ct_FramePr.vAnchor = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_VAnchor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_VAnchor), node.Attributes["w:vAnchor"].Value);
			}
			ct_FramePr.x = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:x"]);
			if (node.Attributes["w:xAlign"] != null)
			{
				ct_FramePr.xAlign = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_XAlign)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_XAlign), node.Attributes["w:xAlign"].Value);
			}
			ct_FramePr.y = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:y"]);
			if (node.Attributes["w:yAlign"] != null)
			{
				ct_FramePr.yAlign = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_YAlign)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_YAlign), node.Attributes["w:yAlign"].Value);
			}
			if (node.Attributes["w:hRule"] != null)
			{
				ct_FramePr.hRule = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_HeightRule)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HeightRule), node.Attributes["w:hRule"].Value);
			}
			if (node.Attributes["w:anchorLock"] != null)
			{
				ct_FramePr.anchorLock = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:anchorLock"].Value, true);
			}
			return ct_FramePr;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000D19C File Offset: 0x0000B39C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:dropCap", this.dropCap.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:lines", this.lines);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:w", this.w);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:h", this.h);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:vSpace", this.vSpace);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hSpace", this.hSpace);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:wrap", this.wrap.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hAnchor", this.hAnchor.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:vAnchor", this.vAnchor.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:x", this.x);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:xAlign", this.xAlign.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:y", this.y);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:yAlign", this.yAlign.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hRule", this.hRule.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:anchorLock", this.anchorLock.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0000D351 File Offset: 0x0000B551
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x0000D359 File Offset: 0x0000B559
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_DropCap dropCap
		{
			get
			{
				return this.dropCapField;
			}
			set
			{
				this.dropCapField = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0000D362 File Offset: 0x0000B562
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x0000D36A File Offset: 0x0000B56A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dropCapSpecified
		{
			get
			{
				return this.dropCapFieldSpecified;
			}
			set
			{
				this.dropCapFieldSpecified = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0000D373 File Offset: 0x0000B573
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0000D37B File Offset: 0x0000B57B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string lines
		{
			get
			{
				return this.linesField;
			}
			set
			{
				this.linesField = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0000D384 File Offset: 0x0000B584
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x0000D38C File Offset: 0x0000B58C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0000D395 File Offset: 0x0000B595
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x0000D39D File Offset: 0x0000B59D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool wSpecified
		{
			get
			{
				return this.wFieldSpecified;
			}
			set
			{
				this.wFieldSpecified = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0000D3A6 File Offset: 0x0000B5A6
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x0000D3AE File Offset: 0x0000B5AE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong h
		{
			get
			{
				return this.hField;
			}
			set
			{
				this.hField = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x0000D3B7 File Offset: 0x0000B5B7
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x0000D3BF File Offset: 0x0000B5BF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hSpecified
		{
			get
			{
				return this.hFieldSpecified;
			}
			set
			{
				this.hFieldSpecified = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong vSpace
		{
			get
			{
				return this.vSpaceField;
			}
			set
			{
				this.vSpaceField = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000D3D9 File Offset: 0x0000B5D9
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x0000D3E1 File Offset: 0x0000B5E1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool vSpaceSpecified
		{
			get
			{
				return this.vSpaceFieldSpecified;
			}
			set
			{
				this.vSpaceFieldSpecified = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0000D3EA File Offset: 0x0000B5EA
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x0000D3F2 File Offset: 0x0000B5F2
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong hSpace
		{
			get
			{
				return this.hSpaceField;
			}
			set
			{
				this.hSpaceField = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0000D3FB File Offset: 0x0000B5FB
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x0000D403 File Offset: 0x0000B603
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hSpaceSpecified
		{
			get
			{
				return this.hSpaceFieldSpecified;
			}
			set
			{
				this.hSpaceFieldSpecified = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0000D40C File Offset: 0x0000B60C
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x0000D414 File Offset: 0x0000B614
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Wrap wrap
		{
			get
			{
				return this.wrapField;
			}
			set
			{
				this.wrapField = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0000D41D File Offset: 0x0000B61D
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x0000D425 File Offset: 0x0000B625
		[global::System.Xml.Serialization.XmlIgnore]
		public bool wrapSpecified
		{
			get
			{
				return this.wrapFieldSpecified;
			}
			set
			{
				this.wrapFieldSpecified = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0000D42E File Offset: 0x0000B62E
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x0000D436 File Offset: 0x0000B636
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_HAnchor hAnchor
		{
			get
			{
				return this.hAnchorField;
			}
			set
			{
				this.hAnchorField = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0000D43F File Offset: 0x0000B63F
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x0000D447 File Offset: 0x0000B647
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hAnchorSpecified
		{
			get
			{
				return this.hAnchorFieldSpecified;
			}
			set
			{
				this.hAnchorFieldSpecified = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000D450 File Offset: 0x0000B650
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x0000D458 File Offset: 0x0000B658
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_VAnchor vAnchor
		{
			get
			{
				return this.vAnchorField;
			}
			set
			{
				this.vAnchorField = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0000D461 File Offset: 0x0000B661
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x0000D469 File Offset: 0x0000B669
		[global::System.Xml.Serialization.XmlIgnore]
		public bool vAnchorSpecified
		{
			get
			{
				return this.vAnchorFieldSpecified;
			}
			set
			{
				this.vAnchorFieldSpecified = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0000D472 File Offset: 0x0000B672
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x0000D47A File Offset: 0x0000B67A
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0000D483 File Offset: 0x0000B683
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x0000D48B File Offset: 0x0000B68B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_XAlign xAlign
		{
			get
			{
				return this.xAlignField;
			}
			set
			{
				this.xAlignField = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0000D494 File Offset: 0x0000B694
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0000D49C File Offset: 0x0000B69C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool xAlignSpecified
		{
			get
			{
				return this.xAlignFieldSpecified;
			}
			set
			{
				this.xAlignFieldSpecified = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0000D4A5 File Offset: 0x0000B6A5
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0000D4AD File Offset: 0x0000B6AD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string y
		{
			get
			{
				return this.yField;
			}
			set
			{
				this.yField = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0000D4B6 File Offset: 0x0000B6B6
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x0000D4BE File Offset: 0x0000B6BE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_YAlign yAlign
		{
			get
			{
				return this.yAlignField;
			}
			set
			{
				this.yAlignField = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0000D4C7 File Offset: 0x0000B6C7
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x0000D4CF File Offset: 0x0000B6CF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool yAlignSpecified
		{
			get
			{
				return this.yAlignFieldSpecified;
			}
			set
			{
				this.yAlignFieldSpecified = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_HeightRule hRule
		{
			get
			{
				return this.hRuleField;
			}
			set
			{
				this.hRuleField = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0000D4E9 File Offset: 0x0000B6E9
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0000D4F1 File Offset: 0x0000B6F1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hRuleSpecified
		{
			get
			{
				return this.hRuleFieldSpecified;
			}
			set
			{
				this.hRuleFieldSpecified = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0000D4FA File Offset: 0x0000B6FA
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x0000D502 File Offset: 0x0000B702
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff anchorLock
		{
			get
			{
				return this.anchorLockField;
			}
			set
			{
				this.anchorLockField = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000D50B File Offset: 0x0000B70B
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x0000D513 File Offset: 0x0000B713
		[global::System.Xml.Serialization.XmlIgnore]
		public bool anchorLockSpecified
		{
			get
			{
				return this.anchorLockFieldSpecified;
			}
			set
			{
				this.anchorLockFieldSpecified = value;
			}
		}

		// Token: 0x040003DE RID: 990
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_DropCap dropCapField;

		// Token: 0x040003DF RID: 991
		private bool dropCapFieldSpecified;

		// Token: 0x040003E0 RID: 992
		private string linesField;

		// Token: 0x040003E1 RID: 993
		private ulong wField;

		// Token: 0x040003E2 RID: 994
		private bool wFieldSpecified;

		// Token: 0x040003E3 RID: 995
		private ulong hField;

		// Token: 0x040003E4 RID: 996
		private bool hFieldSpecified;

		// Token: 0x040003E5 RID: 997
		private ulong vSpaceField;

		// Token: 0x040003E6 RID: 998
		private bool vSpaceFieldSpecified;

		// Token: 0x040003E7 RID: 999
		private ulong hSpaceField;

		// Token: 0x040003E8 RID: 1000
		private bool hSpaceFieldSpecified;

		// Token: 0x040003E9 RID: 1001
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Wrap wrapField;

		// Token: 0x040003EA RID: 1002
		private bool wrapFieldSpecified;

		// Token: 0x040003EB RID: 1003
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_HAnchor hAnchorField;

		// Token: 0x040003EC RID: 1004
		private bool hAnchorFieldSpecified;

		// Token: 0x040003ED RID: 1005
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_VAnchor vAnchorField;

		// Token: 0x040003EE RID: 1006
		private bool vAnchorFieldSpecified;

		// Token: 0x040003EF RID: 1007
		private string xField;

		// Token: 0x040003F0 RID: 1008
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_XAlign xAlignField;

		// Token: 0x040003F1 RID: 1009
		private bool xAlignFieldSpecified;

		// Token: 0x040003F2 RID: 1010
		private string yField;

		// Token: 0x040003F3 RID: 1011
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_YAlign yAlignField;

		// Token: 0x040003F4 RID: 1012
		private bool yAlignFieldSpecified;

		// Token: 0x040003F5 RID: 1013
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_HeightRule hRuleField;

		// Token: 0x040003F6 RID: 1014
		private bool hRuleFieldSpecified;

		// Token: 0x040003F7 RID: 1015
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff anchorLockField;

		// Token: 0x040003F8 RID: 1016
		private bool anchorLockFieldSpecified;
	}
}
