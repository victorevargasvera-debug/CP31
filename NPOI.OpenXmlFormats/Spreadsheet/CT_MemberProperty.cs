using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004DA RID: 1242
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_MemberProperty
	{
		// Token: 0x060033D8 RID: 13272 RVA: 0x0008237C File Offset: 0x0008057C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperty Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperty ct_MemberProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MemberProperty();
			ct_MemberProperty.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			if (node.Attributes["showCell"] != null)
			{
				ct_MemberProperty.showCell = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showCell"]);
			}
			if (node.Attributes["showTip"] != null)
			{
				ct_MemberProperty.showTip = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showTip"]);
			}
			if (node.Attributes["showAsCaption"] != null)
			{
				ct_MemberProperty.showAsCaption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showAsCaption"]);
			}
			if (node.Attributes["nameLen"] != null)
			{
				ct_MemberProperty.nameLen = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["nameLen"]);
			}
			if (node.Attributes["pPos"] != null)
			{
				ct_MemberProperty.pPos = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["pPos"]);
			}
			if (node.Attributes["pLen"] != null)
			{
				ct_MemberProperty.pLen = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["pLen"]);
			}
			if (node.Attributes["level"] != null)
			{
				ct_MemberProperty.level = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["level"]);
			}
			if (node.Attributes["field"] != null)
			{
				ct_MemberProperty.field = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["field"]);
			}
			return ct_MemberProperty;
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x00082518 File Offset: 0x00080718
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showCell", this.showCell);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showTip", this.showTip);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showAsCaption", this.showAsCaption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "nameLen", this.nameLen, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pPos", this.pPos, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pLen", this.pLen, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "level", this.level, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "field", this.field, false);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x000825F0 File Offset: 0x000807F0
		public CT_MemberProperty()
		{
			this.showCellField = false;
			this.showTipField = false;
			this.showAsCaptionField = false;
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x0008260D File Offset: 0x0008080D
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x00082615 File Offset: 0x00080815
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x0008261E File Offset: 0x0008081E
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x00082626 File Offset: 0x00080826
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showCell
		{
			get
			{
				return this.showCellField;
			}
			set
			{
				this.showCellField = value;
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x0008262F File Offset: 0x0008082F
		// (set) Token: 0x060033E0 RID: 13280 RVA: 0x00082637 File Offset: 0x00080837
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showTip
		{
			get
			{
				return this.showTipField;
			}
			set
			{
				this.showTipField = value;
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x060033E1 RID: 13281 RVA: 0x00082640 File Offset: 0x00080840
		// (set) Token: 0x060033E2 RID: 13282 RVA: 0x00082648 File Offset: 0x00080848
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showAsCaption
		{
			get
			{
				return this.showAsCaptionField;
			}
			set
			{
				this.showAsCaptionField = value;
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x00082651 File Offset: 0x00080851
		// (set) Token: 0x060033E4 RID: 13284 RVA: 0x00082659 File Offset: 0x00080859
		[global::System.Xml.Serialization.XmlAttribute]
		public uint nameLen
		{
			get
			{
				return this.nameLenField;
			}
			set
			{
				this.nameLenField = value;
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x00082662 File Offset: 0x00080862
		// (set) Token: 0x060033E6 RID: 13286 RVA: 0x0008266A File Offset: 0x0008086A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool nameLenSpecified
		{
			get
			{
				return this.nameLenFieldSpecified;
			}
			set
			{
				this.nameLenFieldSpecified = value;
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x00082673 File Offset: 0x00080873
		// (set) Token: 0x060033E8 RID: 13288 RVA: 0x0008267B File Offset: 0x0008087B
		[global::System.Xml.Serialization.XmlAttribute]
		public uint pPos
		{
			get
			{
				return this.pPosField;
			}
			set
			{
				this.pPosField = value;
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x00082684 File Offset: 0x00080884
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x0008268C File Offset: 0x0008088C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool pPosSpecified
		{
			get
			{
				return this.pPosFieldSpecified;
			}
			set
			{
				this.pPosFieldSpecified = value;
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x00082695 File Offset: 0x00080895
		// (set) Token: 0x060033EC RID: 13292 RVA: 0x0008269D File Offset: 0x0008089D
		[global::System.Xml.Serialization.XmlAttribute]
		public uint pLen
		{
			get
			{
				return this.pLenField;
			}
			set
			{
				this.pLenField = value;
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x000826A6 File Offset: 0x000808A6
		// (set) Token: 0x060033EE RID: 13294 RVA: 0x000826AE File Offset: 0x000808AE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool pLenSpecified
		{
			get
			{
				return this.pLenFieldSpecified;
			}
			set
			{
				this.pLenFieldSpecified = value;
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x000826B7 File Offset: 0x000808B7
		// (set) Token: 0x060033F0 RID: 13296 RVA: 0x000826BF File Offset: 0x000808BF
		[global::System.Xml.Serialization.XmlAttribute]
		public uint level
		{
			get
			{
				return this.levelField;
			}
			set
			{
				this.levelField = value;
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x060033F1 RID: 13297 RVA: 0x000826C8 File Offset: 0x000808C8
		// (set) Token: 0x060033F2 RID: 13298 RVA: 0x000826D0 File Offset: 0x000808D0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool levelSpecified
		{
			get
			{
				return this.levelFieldSpecified;
			}
			set
			{
				this.levelFieldSpecified = value;
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x060033F3 RID: 13299 RVA: 0x000826D9 File Offset: 0x000808D9
		// (set) Token: 0x060033F4 RID: 13300 RVA: 0x000826E1 File Offset: 0x000808E1
		[global::System.Xml.Serialization.XmlAttribute]
		public uint field
		{
			get
			{
				return this.fieldField;
			}
			set
			{
				this.fieldField = value;
			}
		}

		// Token: 0x0400227C RID: 8828
		private string nameField;

		// Token: 0x0400227D RID: 8829
		private bool showCellField;

		// Token: 0x0400227E RID: 8830
		private bool showTipField;

		// Token: 0x0400227F RID: 8831
		private bool showAsCaptionField;

		// Token: 0x04002280 RID: 8832
		private uint nameLenField;

		// Token: 0x04002281 RID: 8833
		private bool nameLenFieldSpecified;

		// Token: 0x04002282 RID: 8834
		private uint pPosField;

		// Token: 0x04002283 RID: 8835
		private bool pPosFieldSpecified;

		// Token: 0x04002284 RID: 8836
		private uint pLenField;

		// Token: 0x04002285 RID: 8837
		private bool pLenFieldSpecified;

		// Token: 0x04002286 RID: 8838
		private uint levelField;

		// Token: 0x04002287 RID: 8839
		private bool levelFieldSpecified;

		// Token: 0x04002288 RID: 8840
		private uint fieldField;
	}
}
