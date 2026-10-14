using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000622 RID: 1570
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_WorkbookProtection
	{
		// Token: 0x0600444B RID: 17483 RVA: 0x000A24BC File Offset: 0x000A06BC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookProtection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorkbookProtection
			{
				workbookPassword = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["workbookPassword"]),
				revisionsPassword = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["revisionsPassword"]),
				lockStructure = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["lockStructure"]),
				lockWindows = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["lockWindows"]),
				lockRevision = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["lockRevision"])
			};
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x000A255C File Offset: 0x000A075C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "workbookPassword", this.workbookPassword);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "revisionsPassword", this.revisionsPassword);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lockStructure", this.lockStructure);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lockWindows", this.lockWindows);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lockRevision", this.lockRevision);
			sw.Write("/>");
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x000A25DA File Offset: 0x000A07DA
		public CT_WorkbookProtection()
		{
			this.lockStructureField = false;
			this.lockWindowsField = false;
			this.lockRevisionField = false;
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x000A25F7 File Offset: 0x000A07F7
		// (set) Token: 0x0600444F RID: 17487 RVA: 0x000A25FF File Offset: 0x000A07FF
		[global::System.Xml.Serialization.XmlAttribute]
		public byte[] workbookPassword
		{
			get
			{
				return this.workbookPasswordField;
			}
			set
			{
				this.workbookPasswordField = value;
			}
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06004450 RID: 17488 RVA: 0x000A2608 File Offset: 0x000A0808
		// (set) Token: 0x06004451 RID: 17489 RVA: 0x000A2610 File Offset: 0x000A0810
		[global::System.Xml.Serialization.XmlAttribute]
		public byte[] revisionsPassword
		{
			get
			{
				return this.revisionsPasswordField;
			}
			set
			{
				this.revisionsPasswordField = value;
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x000A2619 File Offset: 0x000A0819
		// (set) Token: 0x06004453 RID: 17491 RVA: 0x000A2621 File Offset: 0x000A0821
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool lockStructure
		{
			get
			{
				return this.lockStructureField;
			}
			set
			{
				this.lockStructureField = value;
			}
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06004454 RID: 17492 RVA: 0x000A262A File Offset: 0x000A082A
		// (set) Token: 0x06004455 RID: 17493 RVA: 0x000A2632 File Offset: 0x000A0832
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool lockWindows
		{
			get
			{
				return this.lockWindowsField;
			}
			set
			{
				this.lockWindowsField = value;
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06004456 RID: 17494 RVA: 0x000A263B File Offset: 0x000A083B
		// (set) Token: 0x06004457 RID: 17495 RVA: 0x000A2643 File Offset: 0x000A0843
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool lockRevision
		{
			get
			{
				return this.lockRevisionField;
			}
			set
			{
				this.lockRevisionField = value;
			}
		}

		// Token: 0x04002AE5 RID: 10981
		private byte[] workbookPasswordField;

		// Token: 0x04002AE6 RID: 10982
		private byte[] revisionsPasswordField;

		// Token: 0x04002AE7 RID: 10983
		private bool lockStructureField;

		// Token: 0x04002AE8 RID: 10984
		private bool lockWindowsField;

		// Token: 0x04002AE9 RID: 10985
		private bool lockRevisionField;
	}
}
