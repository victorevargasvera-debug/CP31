using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200052F RID: 1327
	public class CT_FilterColumn
	{
		// Token: 0x06003A58 RID: 14936 RVA: 0x00090DA4 File Offset: 0x0008EFA4
		public CT_FilterColumn()
		{
			this.hiddenButtonField = false;
			this.showButtonField = true;
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x00090DBA File Offset: 0x0008EFBA
		// (set) Token: 0x06003A5A RID: 14938 RVA: 0x00090DC2 File Offset: 0x0008EFC2
		[global::System.Xml.Serialization.XmlAttribute]
		public uint colId
		{
			get
			{
				return this.colIdField;
			}
			set
			{
				this.colIdField = value;
			}
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x00090DCB File Offset: 0x0008EFCB
		// (set) Token: 0x06003A5C RID: 14940 RVA: 0x00090DD3 File Offset: 0x0008EFD3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hiddenButton
		{
			get
			{
				return this.hiddenButtonField;
			}
			set
			{
				this.hiddenButtonField = value;
			}
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06003A5D RID: 14941 RVA: 0x00090DDC File Offset: 0x0008EFDC
		// (set) Token: 0x06003A5E RID: 14942 RVA: 0x00090DE4 File Offset: 0x0008EFE4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showButton
		{
			get
			{
				return this.showButtonField;
			}
			set
			{
				this.showButtonField = value;
			}
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x00090DF0 File Offset: 0x0008EFF0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FilterColumn Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FilterColumn
			{
				colId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["colId"]),
				hiddenButton = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hiddenButton"]),
				showButton = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showButton"])
			};
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00090E58 File Offset: 0x0008F058
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "colId", this.colId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hiddenButton", this.hiddenButton);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showButton", this.showButton);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0400252F RID: 9519
		private uint colIdField;

		// Token: 0x04002530 RID: 9520
		private bool hiddenButtonField;

		// Token: 0x04002531 RID: 9521
		private bool showButtonField;
	}
}
