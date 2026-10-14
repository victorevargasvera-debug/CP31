using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000523 RID: 1315
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_DefinedName
	{
		// Token: 0x060039CD RID: 14797 RVA: 0x0008F990 File Offset: 0x0008DB90
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]),
				comment = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["comment"]),
				customMenu = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["customMenu"]),
				description = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["description"]),
				help = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["help"]),
				statusBar = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["statusBar"]),
				localSheetId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["localSheetId"]),
				localSheetIdFieldSpecified = (node.Attributes["localSheetId"] != null),
				hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"]),
				function = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["function"]),
				vbProcedure = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["vbProcedure"]),
				xlm = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["xlm"]),
				functionGroupId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["functionGroupId"]),
				shortcutKey = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["shortcutKey"]),
				publishToServer = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["publishToServer"]),
				workbookParameter = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["workbookParameter"]),
				Value = node.InnerText
			};
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x0008FB64 File Offset: 0x0008DD64
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "comment", this.comment);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "customMenu", this.customMenu);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "description", this.description);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "help", this.help);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "statusBar", this.statusBar);
			if (this.localSheetIdFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "localSheetId", this.localSheetId, true);
			}
			if (this.hidden)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden);
			}
			if (this.function)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "function", this.function);
			}
			if (this.vbProcedure)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "vbProcedure", this.vbProcedure);
			}
			if (this.xlm)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xlm", this.xlm);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "functionGroupId", this.functionGroupId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "shortcutKey", this.shortcutKey);
			if (this.publishToServerField)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "publishToServer", this.publishToServer);
			}
			if (this.workbookParameterField)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "workbookParameter", this.workbookParameter);
			}
			sw.Write(">");
			sw.Write(string.Format("<![CDATA[{0}]]>", this.Value));
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x0008FCEE File Offset: 0x0008DEEE
		public CT_DefinedName()
		{
			this.hiddenField = false;
			this.functionField = false;
			this.vbProcedureField = false;
			this.xlmField = false;
			this.publishToServerField = false;
			this.workbookParameterField = false;
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x0008FD20 File Offset: 0x0008DF20
		// (set) Token: 0x060039D1 RID: 14801 RVA: 0x0008FD28 File Offset: 0x0008DF28
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

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x0008FD31 File Offset: 0x0008DF31
		// (set) Token: 0x060039D3 RID: 14803 RVA: 0x0008FD39 File Offset: 0x0008DF39
		[global::System.Xml.Serialization.XmlAttribute]
		public string comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x060039D4 RID: 14804 RVA: 0x0008FD42 File Offset: 0x0008DF42
		// (set) Token: 0x060039D5 RID: 14805 RVA: 0x0008FD4A File Offset: 0x0008DF4A
		[global::System.Xml.Serialization.XmlAttribute]
		public string customMenu
		{
			get
			{
				return this.customMenuField;
			}
			set
			{
				this.customMenuField = value;
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x060039D6 RID: 14806 RVA: 0x0008FD53 File Offset: 0x0008DF53
		// (set) Token: 0x060039D7 RID: 14807 RVA: 0x0008FD5B File Offset: 0x0008DF5B
		[global::System.Xml.Serialization.XmlAttribute]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x060039D8 RID: 14808 RVA: 0x0008FD64 File Offset: 0x0008DF64
		// (set) Token: 0x060039D9 RID: 14809 RVA: 0x0008FD6C File Offset: 0x0008DF6C
		[global::System.Xml.Serialization.XmlAttribute]
		public string help
		{
			get
			{
				return this.helpField;
			}
			set
			{
				this.helpField = value;
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x060039DA RID: 14810 RVA: 0x0008FD75 File Offset: 0x0008DF75
		// (set) Token: 0x060039DB RID: 14811 RVA: 0x0008FD7D File Offset: 0x0008DF7D
		[global::System.Xml.Serialization.XmlAttribute]
		public string statusBar
		{
			get
			{
				return this.statusBarField;
			}
			set
			{
				this.statusBarField = value;
			}
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x0008FD86 File Offset: 0x0008DF86
		public bool IsSetLocalSheetId()
		{
			return this.localSheetIdFieldSpecified;
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x0008FD8E File Offset: 0x0008DF8E
		public void UnsetLocalSheetId()
		{
			this.localSheetIdFieldSpecified = false;
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x060039DE RID: 14814 RVA: 0x0008FD97 File Offset: 0x0008DF97
		// (set) Token: 0x060039DF RID: 14815 RVA: 0x0008FD9F File Offset: 0x0008DF9F
		[global::System.Xml.Serialization.XmlAttribute]
		public uint localSheetId
		{
			get
			{
				return this.localSheetIdField;
			}
			set
			{
				this.localSheetIdField = value;
				this.localSheetIdFieldSpecified = true;
			}
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x0008FD86 File Offset: 0x0008DF86
		// (set) Token: 0x060039E1 RID: 14817 RVA: 0x0008FDAF File Offset: 0x0008DFAF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool localSheetIdSpecified
		{
			get
			{
				return this.localSheetIdFieldSpecified;
			}
			set
			{
				this.localSheetIdFieldSpecified = value;
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x0008FDB8 File Offset: 0x0008DFB8
		// (set) Token: 0x060039E3 RID: 14819 RVA: 0x0008FDC0 File Offset: 0x0008DFC0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x060039E4 RID: 14820 RVA: 0x0008FDC9 File Offset: 0x0008DFC9
		// (set) Token: 0x060039E5 RID: 14821 RVA: 0x0008FDD1 File Offset: 0x0008DFD1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool function
		{
			get
			{
				return this.functionField;
			}
			set
			{
				this.functionField = value;
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x0008FDDA File Offset: 0x0008DFDA
		// (set) Token: 0x060039E7 RID: 14823 RVA: 0x0008FDE2 File Offset: 0x0008DFE2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool vbProcedure
		{
			get
			{
				return this.vbProcedureField;
			}
			set
			{
				this.vbProcedureField = value;
			}
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x060039E8 RID: 14824 RVA: 0x0008FDEB File Offset: 0x0008DFEB
		// (set) Token: 0x060039E9 RID: 14825 RVA: 0x0008FDF3 File Offset: 0x0008DFF3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool xlm
		{
			get
			{
				return this.xlmField;
			}
			set
			{
				this.xlmField = value;
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x060039EA RID: 14826 RVA: 0x0008FDFC File Offset: 0x0008DFFC
		// (set) Token: 0x060039EB RID: 14827 RVA: 0x0008FE04 File Offset: 0x0008E004
		[global::System.Xml.Serialization.XmlAttribute]
		public uint functionGroupId
		{
			get
			{
				return this.functionGroupIdField;
			}
			set
			{
				this.functionGroupIdField = value;
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x060039EC RID: 14828 RVA: 0x0008FE0D File Offset: 0x0008E00D
		// (set) Token: 0x060039ED RID: 14829 RVA: 0x0008FE15 File Offset: 0x0008E015
		[global::System.Xml.Serialization.XmlIgnore]
		public bool functionGroupIdSpecified
		{
			get
			{
				return this.functionGroupIdFieldSpecified;
			}
			set
			{
				this.functionGroupIdFieldSpecified = value;
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x060039EE RID: 14830 RVA: 0x0008FE1E File Offset: 0x0008E01E
		// (set) Token: 0x060039EF RID: 14831 RVA: 0x0008FE26 File Offset: 0x0008E026
		[global::System.Xml.Serialization.XmlAttribute]
		public string shortcutKey
		{
			get
			{
				return this.shortcutKeyField;
			}
			set
			{
				this.shortcutKeyField = value;
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x060039F0 RID: 14832 RVA: 0x0008FE2F File Offset: 0x0008E02F
		// (set) Token: 0x060039F1 RID: 14833 RVA: 0x0008FE37 File Offset: 0x0008E037
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool publishToServer
		{
			get
			{
				return this.publishToServerField;
			}
			set
			{
				this.publishToServerField = value;
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x060039F2 RID: 14834 RVA: 0x0008FE40 File Offset: 0x0008E040
		// (set) Token: 0x060039F3 RID: 14835 RVA: 0x0008FE48 File Offset: 0x0008E048
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool workbookParameter
		{
			get
			{
				return this.workbookParameterField;
			}
			set
			{
				this.workbookParameterField = value;
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x060039F4 RID: 14836 RVA: 0x0008FE51 File Offset: 0x0008E051
		// (set) Token: 0x060039F5 RID: 14837 RVA: 0x0008FE59 File Offset: 0x0008E059
		[global::System.Xml.Serialization.XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x040024F1 RID: 9457
		private string nameField;

		// Token: 0x040024F2 RID: 9458
		private string commentField;

		// Token: 0x040024F3 RID: 9459
		private string customMenuField;

		// Token: 0x040024F4 RID: 9460
		private string descriptionField;

		// Token: 0x040024F5 RID: 9461
		private string helpField;

		// Token: 0x040024F6 RID: 9462
		private string statusBarField;

		// Token: 0x040024F7 RID: 9463
		private uint localSheetIdField;

		// Token: 0x040024F8 RID: 9464
		private bool localSheetIdFieldSpecified;

		// Token: 0x040024F9 RID: 9465
		private bool hiddenField;

		// Token: 0x040024FA RID: 9466
		private bool functionField;

		// Token: 0x040024FB RID: 9467
		private bool vbProcedureField;

		// Token: 0x040024FC RID: 9468
		private bool xlmField;

		// Token: 0x040024FD RID: 9469
		private uint functionGroupIdField;

		// Token: 0x040024FE RID: 9470
		private bool functionGroupIdFieldSpecified;

		// Token: 0x040024FF RID: 9471
		private string shortcutKeyField;

		// Token: 0x04002500 RID: 9472
		private bool publishToServerField;

		// Token: 0x04002501 RID: 9473
		private bool workbookParameterField;

		// Token: 0x04002502 RID: 9474
		private string valueField;
	}
}
