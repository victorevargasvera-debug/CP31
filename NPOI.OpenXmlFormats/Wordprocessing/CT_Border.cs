using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000158 RID: 344
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Border
	{
		// Token: 0x0600099B RID: 2459 RVA: 0x000215FD File Offset: 0x0001F7FD
		public CT_Border()
		{
			this.themeColor = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0002160C File Offset: 0x0001F80C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			if (node.Attributes["w:val"] != null)
			{
				ct_Border.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border), node.Attributes["w:val"].Value);
			}
			ct_Border.color = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:color"]);
			if (node.Attributes["w:themeColor"] != null)
			{
				ct_Border.themeColor = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor), node.Attributes["w:themeColor"].Value);
			}
			ct_Border.themeTint = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeTint"]);
			ct_Border.themeShade = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeShade"]);
			if (node.Attributes["w:sz"] != null)
			{
				ct_Border.sz = new ulong?(global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:sz"]));
			}
			if (node.Attributes["w:space"] != null)
			{
				ct_Border.space = new ulong?(global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:space"]));
			}
			if (node.Attributes["w:shadow"] != null)
			{
				ct_Border.shadow = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:shadow"].Value, true);
			}
			if (node.Attributes["w:frame"] != null)
			{
				ct_Border.frame = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:frame"].Value, true);
			}
			return ct_Border;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000217E0 File Offset: 0x0001F9E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:color", this.color);
			if (this.sz != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:sz", this.sz.Value, true);
			}
			if (this.space != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:space", this.space.Value, true);
			}
			if (this.themeColor != global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeColor", this.themeColor.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeTint", this.themeTint);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeShade", this.themeShade);
			if (this.shadow != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:shadow", this.shadow.ToString());
			}
			if (this.frame != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:frame", this.frame.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00021928 File Offset: 0x0001FB28
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x00021930 File Offset: 0x0001FB30
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00021939 File Offset: 0x0001FB39
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00021941 File Offset: 0x0001FB41
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0002194A File Offset: 0x0001FB4A
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x00021952 File Offset: 0x0001FB52
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor themeColor
		{
			get
			{
				return this.themeColorField;
			}
			set
			{
				this.themeColorField = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0002195B File Offset: 0x0001FB5B
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00021963 File Offset: 0x0001FB63
		[global::System.Xml.Serialization.XmlIgnore]
		public bool themeColorSpecified
		{
			get
			{
				return this.themeColorFieldSpecified;
			}
			set
			{
				this.themeColorFieldSpecified = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0002196C File Offset: 0x0001FB6C
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00021974 File Offset: 0x0001FB74
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] themeTint
		{
			get
			{
				return this.themeTintField;
			}
			set
			{
				this.themeTintField = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0002197D File Offset: 0x0001FB7D
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00021985 File Offset: 0x0001FB85
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] themeShade
		{
			get
			{
				return this.themeShadeField;
			}
			set
			{
				this.themeShadeField = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0002198E File Offset: 0x0001FB8E
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00021996 File Offset: 0x0001FB96
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong? sz
		{
			get
			{
				return this.szField;
			}
			set
			{
				this.szField = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0002199F File Offset: 0x0001FB9F
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x000219A7 File Offset: 0x0001FBA7
		public ulong? space
		{
			get
			{
				return this.spaceField;
			}
			set
			{
				this.spaceField = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x000219B0 File Offset: 0x0001FBB0
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x000219B8 File Offset: 0x0001FBB8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff shadow
		{
			get
			{
				return this.shadowField;
			}
			set
			{
				this.shadowField = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x000219C1 File Offset: 0x0001FBC1
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x000219C9 File Offset: 0x0001FBC9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool shadowSpecified
		{
			get
			{
				return this.shadowFieldSpecified;
			}
			set
			{
				this.shadowFieldSpecified = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x000219D2 File Offset: 0x0001FBD2
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x000219DA File Offset: 0x0001FBDA
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff frame
		{
			get
			{
				return this.frameField;
			}
			set
			{
				this.frameField = value;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x000219E3 File Offset: 0x0001FBE3
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x000219EB File Offset: 0x0001FBEB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool frameSpecified
		{
			get
			{
				return this.frameFieldSpecified;
			}
			set
			{
				this.frameFieldSpecified = value;
			}
		}

		// Token: 0x040008BA RID: 2234
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border valField;

		// Token: 0x040008BB RID: 2235
		private string colorField;

		// Token: 0x040008BC RID: 2236
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor themeColorField;

		// Token: 0x040008BD RID: 2237
		private bool themeColorFieldSpecified;

		// Token: 0x040008BE RID: 2238
		private byte[] themeTintField;

		// Token: 0x040008BF RID: 2239
		private byte[] themeShadeField;

		// Token: 0x040008C0 RID: 2240
		private ulong? szField;

		// Token: 0x040008C1 RID: 2241
		private ulong? spaceField;

		// Token: 0x040008C2 RID: 2242
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff shadowField;

		// Token: 0x040008C3 RID: 2243
		private bool shadowFieldSpecified;

		// Token: 0x040008C4 RID: 2244
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff frameField;

		// Token: 0x040008C5 RID: 2245
		private bool frameFieldSpecified;
	}
}
