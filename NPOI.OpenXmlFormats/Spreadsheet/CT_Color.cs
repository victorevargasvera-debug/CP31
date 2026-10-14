using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000503 RID: 1283
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("color", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Color
	{
		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600369C RID: 13980 RVA: 0x00088225 File Offset: 0x00086425
		// (set) Token: 0x0600369D RID: 13981 RVA: 0x0008822D File Offset: 0x0008642D
		[global::System.Xml.Serialization.XmlAttribute]
		public bool auto
		{
			get
			{
				return this.autoField;
			}
			set
			{
				this.autoField = value;
				this.autoSpecified = true;
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x0600369E RID: 13982 RVA: 0x0008823D File Offset: 0x0008643D
		// (set) Token: 0x0600369F RID: 13983 RVA: 0x00088245 File Offset: 0x00086445
		[global::System.Xml.Serialization.XmlIgnore]
		public bool autoSpecified
		{
			get
			{
				return this.autoSpecifiedField;
			}
			set
			{
				this.autoSpecifiedField = value;
			}
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0008823D File Offset: 0x0008643D
		public bool IsSetAuto()
		{
			return this.autoSpecifiedField;
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x0008824E File Offset: 0x0008644E
		// (set) Token: 0x060036A2 RID: 13986 RVA: 0x00088256 File Offset: 0x00086456
		[global::System.Xml.Serialization.XmlAttribute]
		public uint indexed
		{
			get
			{
				return this.indexedField;
			}
			set
			{
				this.indexedField = value;
				this.indexedSpecifiedField = true;
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x060036A3 RID: 13987 RVA: 0x00088266 File Offset: 0x00086466
		// (set) Token: 0x060036A4 RID: 13988 RVA: 0x0008826E File Offset: 0x0008646E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool indexedSpecified
		{
			get
			{
				return this.indexedSpecifiedField;
			}
			set
			{
				this.indexedSpecifiedField = value;
			}
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00088277 File Offset: 0x00086477
		public bool IsSetIndexed()
		{
			return this.indexedSpecified;
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x0008827F File Offset: 0x0008647F
		// (set) Token: 0x060036A7 RID: 13991 RVA: 0x00088287 File Offset: 0x00086487
		[global::System.Xml.Serialization.XmlAttribute(DataType = "hexBinary")]
		public byte[] rgb
		{
			get
			{
				return this.rgbField;
			}
			set
			{
				this.rgbField = value;
				this.rgbSpecified = true;
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x00088297 File Offset: 0x00086497
		// (set) Token: 0x060036A9 RID: 13993 RVA: 0x0008829F File Offset: 0x0008649F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rgbSpecified
		{
			get
			{
				return this.rgbSpecifiedField;
			}
			set
			{
				this.rgbSpecifiedField = value;
			}
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x000882A8 File Offset: 0x000864A8
		public void SetRgb(byte R, byte G, byte B)
		{
			this.rgbField = new byte[3];
			this.rgbField[0] = R;
			this.rgbField[1] = G;
			this.rgbField[2] = B;
			this.rgbSpecified = true;
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x000882D8 File Offset: 0x000864D8
		public bool IsSetRgb()
		{
			return this.rgbSpecified;
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x000882E0 File Offset: 0x000864E0
		public void SetRgb(byte[] rgb)
		{
			this.rgbField = new byte[rgb.Length];
			global::System.Array.Copy(rgb, this.rgbField, rgb.Length);
			this.rgbSpecified = true;
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x00088308 File Offset: 0x00086508
		public byte[] GetRgb()
		{
			if (this.rgbField == null)
			{
				return null;
			}
			byte[] array = new byte[this.rgbField.Length];
			global::System.Array.Copy(this.rgbField, array, this.rgbField.Length);
			return array;
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x060036AE RID: 13998 RVA: 0x00088342 File Offset: 0x00086542
		// (set) Token: 0x060036AF RID: 13999 RVA: 0x0008834A File Offset: 0x0008654A
		[global::System.Xml.Serialization.XmlAttribute]
		public uint theme
		{
			get
			{
				return this.themeField;
			}
			set
			{
				this.themeField = value;
				this.themeSpecifiedField = true;
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x0008835A File Offset: 0x0008655A
		// (set) Token: 0x060036B1 RID: 14001 RVA: 0x00088362 File Offset: 0x00086562
		[global::System.Xml.Serialization.XmlIgnore]
		public bool themeSpecified
		{
			get
			{
				return this.themeSpecifiedField;
			}
			set
			{
				this.themeSpecifiedField = value;
			}
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x0008836B File Offset: 0x0008656B
		public bool IsSetTheme()
		{
			return this.themeSpecified;
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x00088373 File Offset: 0x00086573
		// (set) Token: 0x060036B4 RID: 14004 RVA: 0x0008837B File Offset: 0x0008657B
		[global::System.ComponentModel.DefaultValue(0.0)]
		[global::System.Xml.Serialization.XmlAttribute]
		public double tint
		{
			get
			{
				return this.tintField;
			}
			set
			{
				this.tintField = value;
				this.tintSpecified = true;
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x0008838B File Offset: 0x0008658B
		// (set) Token: 0x060036B6 RID: 14006 RVA: 0x00088393 File Offset: 0x00086593
		[global::System.Xml.Serialization.XmlIgnore]
		public bool tintSpecified
		{
			get
			{
				return this.tintSpecifiedField;
			}
			set
			{
				this.tintSpecifiedField = value;
			}
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x0008839C File Offset: 0x0008659C
		public bool IsSetTint()
		{
			return this.tintSpecified;
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x000883A4 File Offset: 0x000865A4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color
			{
				auto = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["auto"]),
				autoSpecified = (node.Attributes["auto"] != null),
				indexed = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["indexed"]),
				indexedSpecified = (node.Attributes["indexed"] != null),
				rgb = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["rgb"]),
				rgbSpecified = (node.Attributes["rgb"] != null),
				theme = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["theme"]),
				themeSpecified = (node.Attributes["theme"] != null),
				tint = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["tint"]),
				tintSpecified = (node.Attributes["tint"] != null)
			};
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x000884C0 File Offset: 0x000866C0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "auto", this.auto, false);
			if (this.indexedSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "indexed", this.indexed, true);
			}
			if (this.rgbSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rgb", this.rgb);
			}
			if (this.themeSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "theme", this.theme, true);
			}
			if (this.tintSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tint", this.tint);
			}
			sw.Write("/>");
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00088564 File Offset: 0x00086764
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color Copy()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color
			{
				autoField = this.autoField,
				indexedField = this.indexedField,
				indexedSpecified = this.indexedSpecified,
				rgbField = ((this.rgbField == null) ? null : ((byte[])this.rgbField.Clone())),
				rgbSpecified = this.rgbSpecified,
				themeField = this.themeField,
				themeSpecified = this.themeSpecified,
				tintField = this.tintField,
				tintSpecified = this.tintSpecified
			};
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x000885F7 File Offset: 0x000867F7
		public void UnsetIndexed()
		{
			this.indexedField = 0U;
			this.indexedSpecifiedField = false;
		}

		// Token: 0x040023E9 RID: 9193
		private bool autoField;

		// Token: 0x040023EA RID: 9194
		private uint indexedField;

		// Token: 0x040023EB RID: 9195
		private byte[] rgbField;

		// Token: 0x040023EC RID: 9196
		private uint themeField;

		// Token: 0x040023ED RID: 9197
		private double tintField;

		// Token: 0x040023EE RID: 9198
		private bool autoSpecifiedField;

		// Token: 0x040023EF RID: 9199
		private bool indexedSpecifiedField;

		// Token: 0x040023F0 RID: 9200
		private bool rgbSpecifiedField;

		// Token: 0x040023F1 RID: 9201
		private bool themeSpecifiedField;

		// Token: 0x040023F2 RID: 9202
		private bool tintSpecifiedField;
	}
}
