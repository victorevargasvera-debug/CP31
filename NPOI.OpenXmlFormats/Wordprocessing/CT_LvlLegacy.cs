using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000BC RID: 188
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LvlLegacy
	{
		// Token: 0x06000548 RID: 1352 RVA: 0x0000EEB8 File Offset: 0x0000D0B8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_LvlLegacy Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_LvlLegacy ct_LvlLegacy = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_LvlLegacy();
			if (node.Attributes["w:legacy"] != null)
			{
				ct_LvlLegacy.legacy = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:legacy"].Value, true);
			}
			ct_LvlLegacy.legacySpace = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:legacySpace"]);
			ct_LvlLegacy.legacyIndent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:legacyIndent"]);
			return ct_LvlLegacy;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000EF4C File Offset: 0x0000D14C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:legacy", this.legacy.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:legacySpace", this.legacySpace);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:legacyIndent", this.legacyIndent);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0000EFC9 File Offset: 0x0000D1C9
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x0000EFD1 File Offset: 0x0000D1D1
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff legacy
		{
			get
			{
				return this.legacyField;
			}
			set
			{
				this.legacyField = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0000EFDA File Offset: 0x0000D1DA
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x0000EFE2 File Offset: 0x0000D1E2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool legacySpecified
		{
			get
			{
				return this.legacyFieldSpecified;
			}
			set
			{
				this.legacyFieldSpecified = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0000EFEB File Offset: 0x0000D1EB
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x0000EFF3 File Offset: 0x0000D1F3
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong legacySpace
		{
			get
			{
				return this.legacySpaceField;
			}
			set
			{
				this.legacySpaceField = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x0000F004 File Offset: 0x0000D204
		[global::System.Xml.Serialization.XmlIgnore]
		public bool legacySpaceSpecified
		{
			get
			{
				return this.legacySpaceFieldSpecified;
			}
			set
			{
				this.legacySpaceFieldSpecified = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0000F00D File Offset: 0x0000D20D
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x0000F015 File Offset: 0x0000D215
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string legacyIndent
		{
			get
			{
				return this.legacyIndentField;
			}
			set
			{
				this.legacyIndentField = value;
			}
		}

		// Token: 0x04000497 RID: 1175
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff legacyField;

		// Token: 0x04000498 RID: 1176
		private bool legacyFieldSpecified;

		// Token: 0x04000499 RID: 1177
		private ulong legacySpaceField;

		// Token: 0x0400049A RID: 1178
		private bool legacySpaceFieldSpecified;

		// Token: 0x0400049B RID: 1179
		private string legacyIndentField;
	}
}
