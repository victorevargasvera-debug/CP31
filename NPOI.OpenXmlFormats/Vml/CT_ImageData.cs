using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001D9 RID: 473
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ImageData
	{
		// Token: 0x06001265 RID: 4709 RVA: 0x0003C9BC File Offset: 0x0003ABBC
		public static global::NPOI.OpenXmlFormats.Vml.CT_ImageData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_ImageData ct_ImageData = new global::NPOI.OpenXmlFormats.Vml.CT_ImageData();
			ct_ImageData.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			ct_ImageData.src = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["src"]);
			ct_ImageData.cropleft = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["cropleft"]);
			ct_ImageData.croptop = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["croptop"]);
			ct_ImageData.cropright = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["cropright"]);
			ct_ImageData.cropbottom = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["cropbottom"]);
			ct_ImageData.gain = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["gain"]);
			ct_ImageData.blacklevel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["blacklevel"]);
			ct_ImageData.gamma = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["gamma"]);
			if (node.Attributes["grayscale"] != null)
			{
				ct_ImageData.grayscale = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["grayscale"]);
			}
			if (node.Attributes["bilevel"] != null)
			{
				ct_ImageData.bilevel = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["bilevel"]);
			}
			ct_ImageData.chromakey = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["chromakey"]);
			ct_ImageData.embosscolor = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["embosscolor"]);
			ct_ImageData.recolortarget = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["recolortarget"]);
			ct_ImageData.pict = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["pict"]);
			ct_ImageData.href = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:href"]);
			ct_ImageData.relid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["o:relid"]);
			ct_ImageData.title = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["o:title"]);
			ct_ImageData.movie = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["o:movie"]);
			ct_ImageData.oleid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["o:oleid"]);
			return ct_ImageData;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0003CC18 File Offset: 0x0003AE18
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "src", this.src);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cropleft", this.cropleft);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "croptop", this.croptop);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cropright", this.cropright);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cropbottom", this.cropbottom);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "gain", this.gain);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "blacklevel", this.blacklevel);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "gamma", this.gamma);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "grayscale", this.grayscale);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "bilevel", this.bilevel);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "chromakey", this.chromakey);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "embosscolor", this.embosscolor);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "recolortarget", this.recolortarget);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pict", this.pict);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:href", this.href);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "o:relid", this.relid);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "o:title", this.title);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "o:movie", this.movie);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "o:oleid", this.oleid);
			sw.Write("/>");
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x0003CD95 File Offset: 0x0003AF95
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x0003CD9D File Offset: 0x0003AF9D
		[global::System.Xml.Serialization.XmlAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x0003CDA6 File Offset: 0x0003AFA6
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x0003CDAE File Offset: 0x0003AFAE
		[global::System.Xml.Serialization.XmlAttribute]
		public string src
		{
			get
			{
				return this.srcField;
			}
			set
			{
				this.srcField = value;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0003CDB7 File Offset: 0x0003AFB7
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x0003CDBF File Offset: 0x0003AFBF
		[global::System.Xml.Serialization.XmlAttribute]
		public string cropleft
		{
			get
			{
				return this.cropleftField;
			}
			set
			{
				this.cropleftField = value;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0003CDC8 File Offset: 0x0003AFC8
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x0003CDD0 File Offset: 0x0003AFD0
		[global::System.Xml.Serialization.XmlAttribute]
		public string croptop
		{
			get
			{
				return this.croptopField;
			}
			set
			{
				this.croptopField = value;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x0003CDD9 File Offset: 0x0003AFD9
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x0003CDE1 File Offset: 0x0003AFE1
		[global::System.Xml.Serialization.XmlAttribute]
		public string cropright
		{
			get
			{
				return this.croprightField;
			}
			set
			{
				this.croprightField = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x0003CDEA File Offset: 0x0003AFEA
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x0003CDF2 File Offset: 0x0003AFF2
		[global::System.Xml.Serialization.XmlAttribute]
		public string cropbottom
		{
			get
			{
				return this.cropbottomField;
			}
			set
			{
				this.cropbottomField = value;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x0003CDFB File Offset: 0x0003AFFB
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x0003CE03 File Offset: 0x0003B003
		[global::System.Xml.Serialization.XmlAttribute]
		public string gain
		{
			get
			{
				return this.gainField;
			}
			set
			{
				this.gainField = value;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x0003CE0C File Offset: 0x0003B00C
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x0003CE14 File Offset: 0x0003B014
		[global::System.Xml.Serialization.XmlAttribute]
		public string blacklevel
		{
			get
			{
				return this.blacklevelField;
			}
			set
			{
				this.blacklevelField = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x0003CE1D File Offset: 0x0003B01D
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x0003CE25 File Offset: 0x0003B025
		[global::System.Xml.Serialization.XmlAttribute]
		public string gamma
		{
			get
			{
				return this.gammaField;
			}
			set
			{
				this.gammaField = value;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x0003CE2E File Offset: 0x0003B02E
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x0003CE36 File Offset: 0x0003B036
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse grayscale
		{
			get
			{
				return this.grayscaleField;
			}
			set
			{
				this.grayscaleField = value;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x0003CE3F File Offset: 0x0003B03F
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x0003CE47 File Offset: 0x0003B047
		[global::System.Xml.Serialization.XmlIgnore]
		public bool grayscaleSpecified
		{
			get
			{
				return this.grayscaleFieldSpecified;
			}
			set
			{
				this.grayscaleFieldSpecified = value;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x0003CE50 File Offset: 0x0003B050
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x0003CE58 File Offset: 0x0003B058
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse bilevel
		{
			get
			{
				return this.bilevelField;
			}
			set
			{
				this.bilevelField = value;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x0003CE61 File Offset: 0x0003B061
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x0003CE69 File Offset: 0x0003B069
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bilevelSpecified
		{
			get
			{
				return this.bilevelFieldSpecified;
			}
			set
			{
				this.bilevelFieldSpecified = value;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x0003CE72 File Offset: 0x0003B072
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x0003CE7A File Offset: 0x0003B07A
		[global::System.Xml.Serialization.XmlAttribute]
		public string chromakey
		{
			get
			{
				return this.chromakeyField;
			}
			set
			{
				this.chromakeyField = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x0003CE83 File Offset: 0x0003B083
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x0003CE8B File Offset: 0x0003B08B
		[global::System.Xml.Serialization.XmlAttribute]
		public string embosscolor
		{
			get
			{
				return this.embosscolorField;
			}
			set
			{
				this.embosscolorField = value;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0003CE94 File Offset: 0x0003B094
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x0003CE9C File Offset: 0x0003B09C
		[global::System.Xml.Serialization.XmlAttribute]
		public string recolortarget
		{
			get
			{
				return this.recolortargetField;
			}
			set
			{
				this.recolortargetField = value;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x0003CEA5 File Offset: 0x0003B0A5
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x0003CEAD File Offset: 0x0003B0AD
		[global::System.Xml.Serialization.XmlAttribute]
		public string pict
		{
			get
			{
				return this.pictField;
			}
			set
			{
				this.pictField = value;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0003CEB6 File Offset: 0x0003B0B6
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x0003CEBE File Offset: 0x0003B0BE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string href
		{
			get
			{
				return this.hrefField;
			}
			set
			{
				this.hrefField = value;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x0003CEC7 File Offset: 0x0003B0C7
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x0003CECF File Offset: 0x0003B0CF
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
		public string relid
		{
			get
			{
				return this.relidField;
			}
			set
			{
				this.relidField = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x0003CED8 File Offset: 0x0003B0D8
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x0003CEE0 File Offset: 0x0003B0E0
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0003CEE9 File Offset: 0x0003B0E9
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x0003CEF1 File Offset: 0x0003B0F1
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
		public string movie
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

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x0003CEFA File Offset: 0x0003B0FA
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x0003CF02 File Offset: 0x0003B102
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
		public string oleid
		{
			get
			{
				return this.oleidField;
			}
			set
			{
				this.oleidField = value;
			}
		}

		// Token: 0x04000E1D RID: 3613
		private string relidField;

		// Token: 0x04000E1E RID: 3614
		private string titleField;

		// Token: 0x04000E1F RID: 3615
		private string oleidField;

		// Token: 0x04000E20 RID: 3616
		private string movieField;

		// Token: 0x04000E21 RID: 3617
		private string idField;

		// Token: 0x04000E22 RID: 3618
		private string srcField;

		// Token: 0x04000E23 RID: 3619
		private string cropleftField;

		// Token: 0x04000E24 RID: 3620
		private string croptopField;

		// Token: 0x04000E25 RID: 3621
		private string croprightField;

		// Token: 0x04000E26 RID: 3622
		private string cropbottomField;

		// Token: 0x04000E27 RID: 3623
		private string gainField;

		// Token: 0x04000E28 RID: 3624
		private string blacklevelField;

		// Token: 0x04000E29 RID: 3625
		private string gammaField;

		// Token: 0x04000E2A RID: 3626
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse grayscaleField;

		// Token: 0x04000E2B RID: 3627
		private bool grayscaleFieldSpecified;

		// Token: 0x04000E2C RID: 3628
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse bilevelField;

		// Token: 0x04000E2D RID: 3629
		private bool bilevelFieldSpecified;

		// Token: 0x04000E2E RID: 3630
		private string chromakeyField;

		// Token: 0x04000E2F RID: 3631
		private string embosscolorField;

		// Token: 0x04000E30 RID: 3632
		private string recolortargetField;

		// Token: 0x04000E31 RID: 3633
		private string pictField;

		// Token: 0x04000E32 RID: 3634
		private string hrefField;
	}
}
