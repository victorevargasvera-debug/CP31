using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200061C RID: 1564
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_FileRecoveryPr
	{
		// Token: 0x06004418 RID: 17432 RVA: 0x000A1E44 File Offset: 0x000A0044
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileRecoveryPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileRecoveryPr
			{
				autoRecover = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoRecover"]),
				crashSave = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["crashSave"]),
				dataExtractLoad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dataExtractLoad"]),
				repairLoad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["repairLoad"])
			};
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x000A1EC8 File Offset: 0x000A00C8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoRecover", this.autoRecover);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "crashSave", this.crashSave);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataExtractLoad", this.dataExtractLoad);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "repairLoad", this.repairLoad);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x000A1F46 File Offset: 0x000A0146
		public CT_FileRecoveryPr()
		{
			this.autoRecoverField = true;
			this.crashSaveField = false;
			this.dataExtractLoadField = false;
			this.repairLoadField = false;
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x000A1F6A File Offset: 0x000A016A
		// (set) Token: 0x0600441C RID: 17436 RVA: 0x000A1F72 File Offset: 0x000A0172
		[global::System.ComponentModel.DefaultValue(true)]
		public bool autoRecover
		{
			get
			{
				return this.autoRecoverField;
			}
			set
			{
				this.autoRecoverField = value;
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x000A1F7B File Offset: 0x000A017B
		// (set) Token: 0x0600441E RID: 17438 RVA: 0x000A1F83 File Offset: 0x000A0183
		[global::System.ComponentModel.DefaultValue(false)]
		public bool crashSave
		{
			get
			{
				return this.crashSaveField;
			}
			set
			{
				this.crashSaveField = value;
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x000A1F8C File Offset: 0x000A018C
		// (set) Token: 0x06004420 RID: 17440 RVA: 0x000A1F94 File Offset: 0x000A0194
		[global::System.ComponentModel.DefaultValue(false)]
		public bool dataExtractLoad
		{
			get
			{
				return this.dataExtractLoadField;
			}
			set
			{
				this.dataExtractLoadField = value;
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06004421 RID: 17441 RVA: 0x000A1F9D File Offset: 0x000A019D
		// (set) Token: 0x06004422 RID: 17442 RVA: 0x000A1FA5 File Offset: 0x000A01A5
		[global::System.ComponentModel.DefaultValue(false)]
		public bool repairLoad
		{
			get
			{
				return this.repairLoadField;
			}
			set
			{
				this.repairLoadField = value;
			}
		}

		// Token: 0x04002AC5 RID: 10949
		private bool autoRecoverField;

		// Token: 0x04002AC6 RID: 10950
		private bool crashSaveField;

		// Token: 0x04002AC7 RID: 10951
		private bool dataExtractLoadField;

		// Token: 0x04002AC8 RID: 10952
		private bool repairLoadField;
	}
}
