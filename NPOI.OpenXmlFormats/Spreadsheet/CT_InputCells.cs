using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200058D RID: 1421
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_InputCells
	{
		// Token: 0x06003E6A RID: 15978 RVA: 0x000975C0 File Offset: 0x000957C0
		public CT_InputCells()
		{
			this.deletedField = false;
			this.undoneField = false;
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x000975D6 File Offset: 0x000957D6
		// (set) Token: 0x06003E6C RID: 15980 RVA: 0x000975DE File Offset: 0x000957DE
		public string r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06003E6D RID: 15981 RVA: 0x000975E7 File Offset: 0x000957E7
		// (set) Token: 0x06003E6E RID: 15982 RVA: 0x000975EF File Offset: 0x000957EF
		[global::System.ComponentModel.DefaultValue(false)]
		public bool deleted
		{
			get
			{
				return this.deletedField;
			}
			set
			{
				this.deletedField = value;
			}
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x000975F8 File Offset: 0x000957F8
		// (set) Token: 0x06003E70 RID: 15984 RVA: 0x00097600 File Offset: 0x00095800
		[global::System.ComponentModel.DefaultValue(false)]
		public bool undone
		{
			get
			{
				return this.undoneField;
			}
			set
			{
				this.undoneField = value;
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06003E71 RID: 15985 RVA: 0x00097609 File Offset: 0x00095809
		// (set) Token: 0x06003E72 RID: 15986 RVA: 0x00097611 File Offset: 0x00095811
		public string val
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

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06003E73 RID: 15987 RVA: 0x0009761A File Offset: 0x0009581A
		// (set) Token: 0x06003E74 RID: 15988 RVA: 0x00097622 File Offset: 0x00095822
		public uint numFmtId
		{
			get
			{
				return this.numFmtIdField;
			}
			set
			{
				this.numFmtIdField = value;
			}
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x0009762C File Offset: 0x0009582C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_InputCells Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_InputCells
			{
				r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r"]),
				deleted = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["deleted"]),
				undone = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["undone"]),
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["val"]),
				numFmtId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["numFmtId"])
			};
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x000976CC File Offset: 0x000958CC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.r);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "deleted", this.deleted);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "undone", this.undone);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "numFmtId", this.numFmtId, true);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040027A6 RID: 10150
		private string rField;

		// Token: 0x040027A7 RID: 10151
		private bool deletedField;

		// Token: 0x040027A8 RID: 10152
		private bool undoneField;

		// Token: 0x040027A9 RID: 10153
		private string valField;

		// Token: 0x040027AA RID: 10154
		private uint numFmtIdField;

		// Token: 0x040027AB RID: 10155
		private bool numFmtIdFieldSpecified;
	}
}
