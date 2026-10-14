using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000BD RID: 189
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LsdException
	{
		// Token: 0x06000555 RID: 1365 RVA: 0x0000F01E File Offset: 0x0000D21E
		public CT_LsdException()
		{
			this.semiHidden = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off;
			this.unhideWhenUsed = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off;
			this.locked = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000F03C File Offset: 0x0000D23C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException ex = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException();
			ex.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:name"]);
			if (node.Attributes["w:locked"] != null)
			{
				ex.locked = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:locked"].Value, true);
			}
			ex.uiPriority = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:uiPriority"]);
			if (node.Attributes["w:semiHidden"] != null)
			{
				ex.semiHidden = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:semiHidden"].Value, true);
			}
			if (node.Attributes["w:unhideWhenUsed"] != null)
			{
				ex.unhideWhenUsed = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:unhideWhenUsed"].Value, true);
			}
			if (node.Attributes["w:qFormat"] != null)
			{
				ex.qFormat = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:qFormat"].Value, true);
			}
			return ex;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000F194 File Offset: 0x0000D394
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:name", this.name);
			if (this.locked != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:locked", this.locked.ToString());
			}
			if (this.semiHidden == global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.on)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:semiHidden", "1");
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:uiPriority", this.uiPriority);
			if (this.unhideWhenUsed == global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.on)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:unhideWhenUsed", "1");
			}
			if (this.qFormat != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:qFormat", "1");
			}
			sw.Write("/>");
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0000F250 File Offset: 0x0000D450
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x0000F258 File Offset: 0x0000D458
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

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0000F261 File Offset: 0x0000D461
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0000F269 File Offset: 0x0000D469
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff locked
		{
			get
			{
				return this.lockedField;
			}
			set
			{
				this.lockedField = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0000F272 File Offset: 0x0000D472
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x0000F27A File Offset: 0x0000D47A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool lockedSpecified
		{
			get
			{
				return this.lockedFieldSpecified;
			}
			set
			{
				this.lockedFieldSpecified = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0000F283 File Offset: 0x0000D483
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x0000F28B File Offset: 0x0000D48B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string uiPriority
		{
			get
			{
				return this.uiPriorityField;
			}
			set
			{
				this.uiPriorityField = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0000F294 File Offset: 0x0000D494
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x0000F29C File Offset: 0x0000D49C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff semiHidden
		{
			get
			{
				return this.semiHiddenField;
			}
			set
			{
				this.semiHiddenField = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0000F2A5 File Offset: 0x0000D4A5
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x0000F2AD File Offset: 0x0000D4AD
		[global::System.Xml.Serialization.XmlIgnore]
		public bool semiHiddenSpecified
		{
			get
			{
				return this.semiHiddenFieldSpecified;
			}
			set
			{
				this.semiHiddenFieldSpecified = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0000F2B6 File Offset: 0x0000D4B6
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x0000F2BE File Offset: 0x0000D4BE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff unhideWhenUsed
		{
			get
			{
				return this.unhideWhenUsedField;
			}
			set
			{
				this.unhideWhenUsedField = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0000F2C7 File Offset: 0x0000D4C7
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0000F2CF File Offset: 0x0000D4CF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool unhideWhenUsedSpecified
		{
			get
			{
				return this.unhideWhenUsedFieldSpecified;
			}
			set
			{
				this.unhideWhenUsedFieldSpecified = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0000F2D8 File Offset: 0x0000D4D8
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x0000F2E0 File Offset: 0x0000D4E0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff qFormat
		{
			get
			{
				return this.qFormatField;
			}
			set
			{
				this.qFormatField = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0000F2E9 File Offset: 0x0000D4E9
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x0000F2F1 File Offset: 0x0000D4F1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool qFormatSpecified
		{
			get
			{
				return this.qFormatFieldSpecified;
			}
			set
			{
				this.qFormatFieldSpecified = value;
			}
		}

		// Token: 0x0400049C RID: 1180
		private string nameField;

		// Token: 0x0400049D RID: 1181
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff lockedField;

		// Token: 0x0400049E RID: 1182
		private bool lockedFieldSpecified;

		// Token: 0x0400049F RID: 1183
		private string uiPriorityField;

		// Token: 0x040004A0 RID: 1184
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff semiHiddenField;

		// Token: 0x040004A1 RID: 1185
		private bool semiHiddenFieldSpecified;

		// Token: 0x040004A2 RID: 1186
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff unhideWhenUsedField;

		// Token: 0x040004A3 RID: 1187
		private bool unhideWhenUsedFieldSpecified;

		// Token: 0x040004A4 RID: 1188
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff qFormatField;

		// Token: 0x040004A5 RID: 1189
		private bool qFormatFieldSpecified;
	}
}
