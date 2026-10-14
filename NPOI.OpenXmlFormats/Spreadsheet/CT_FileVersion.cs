using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200061B RID: 1563
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_FileVersion
	{
		// Token: 0x0600440B RID: 17419 RVA: 0x000A1CD0 File Offset: 0x0009FED0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileVersion Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileVersion
			{
				appName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["appName"]),
				lastEdited = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["lastEdited"]),
				lowestEdited = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["lowestEdited"]),
				rupBuild = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["rupBuild"]),
				codeName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["codeName"])
			};
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x000A1D70 File Offset: 0x0009FF70
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "appName", this.appName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lastEdited", this.lastEdited);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lowestEdited", this.lowestEdited);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rupBuild", this.rupBuild);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "codeName", this.codeName);
			sw.Write("/>");
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x000A1DEE File Offset: 0x0009FFEE
		// (set) Token: 0x0600440E RID: 17422 RVA: 0x000A1DF6 File Offset: 0x0009FFF6
		[global::System.Xml.Serialization.XmlAttribute]
		public string appName
		{
			get
			{
				return this.appNameField;
			}
			set
			{
				this.appNameField = value;
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x0600440F RID: 17423 RVA: 0x000A1DFF File Offset: 0x0009FFFF
		// (set) Token: 0x06004410 RID: 17424 RVA: 0x000A1E07 File Offset: 0x000A0007
		[global::System.Xml.Serialization.XmlAttribute]
		public string lastEdited
		{
			get
			{
				return this.lastEditedField;
			}
			set
			{
				this.lastEditedField = value;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x000A1E10 File Offset: 0x000A0010
		// (set) Token: 0x06004412 RID: 17426 RVA: 0x000A1E18 File Offset: 0x000A0018
		[global::System.Xml.Serialization.XmlAttribute]
		public string lowestEdited
		{
			get
			{
				return this.lowestEditedField;
			}
			set
			{
				this.lowestEditedField = value;
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x000A1E21 File Offset: 0x000A0021
		// (set) Token: 0x06004414 RID: 17428 RVA: 0x000A1E29 File Offset: 0x000A0029
		[global::System.Xml.Serialization.XmlAttribute]
		public string rupBuild
		{
			get
			{
				return this.rupBuildField;
			}
			set
			{
				this.rupBuildField = value;
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x000A1E32 File Offset: 0x000A0032
		// (set) Token: 0x06004416 RID: 17430 RVA: 0x000A1E3A File Offset: 0x000A003A
		[global::System.Xml.Serialization.XmlAttribute]
		public string codeName
		{
			get
			{
				return this.codeNameField;
			}
			set
			{
				this.codeNameField = value;
			}
		}

		// Token: 0x04002AC0 RID: 10944
		private string appNameField;

		// Token: 0x04002AC1 RID: 10945
		private string lastEditedField;

		// Token: 0x04002AC2 RID: 10946
		private string lowestEditedField;

		// Token: 0x04002AC3 RID: 10947
		private string rupBuildField;

		// Token: 0x04002AC4 RID: 10948
		private string codeNameField;
	}
}
