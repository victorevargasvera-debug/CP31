using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000492 RID: 1170
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Tuple
	{
		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06002F49 RID: 12105 RVA: 0x00076A18 File Offset: 0x00074C18
		// (set) Token: 0x06002F4A RID: 12106 RVA: 0x00076A20 File Offset: 0x00074C20
		[global::System.Xml.Serialization.XmlAttribute]
		public uint fld
		{
			get
			{
				return this.fldField;
			}
			set
			{
				this.fldField = value;
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06002F4B RID: 12107 RVA: 0x00076A29 File Offset: 0x00074C29
		// (set) Token: 0x06002F4C RID: 12108 RVA: 0x00076A31 File Offset: 0x00074C31
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fldSpecified
		{
			get
			{
				return this.fldFieldSpecified;
			}
			set
			{
				this.fldFieldSpecified = value;
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x00076A3A File Offset: 0x00074C3A
		// (set) Token: 0x06002F4E RID: 12110 RVA: 0x00076A42 File Offset: 0x00074C42
		[global::System.Xml.Serialization.XmlAttribute]
		public uint hier
		{
			get
			{
				return this.hierField;
			}
			set
			{
				this.hierField = value;
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x00076A4B File Offset: 0x00074C4B
		// (set) Token: 0x06002F50 RID: 12112 RVA: 0x00076A53 File Offset: 0x00074C53
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hierSpecified
		{
			get
			{
				return this.hierFieldSpecified;
			}
			set
			{
				this.hierFieldSpecified = value;
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06002F51 RID: 12113 RVA: 0x00076A5C File Offset: 0x00074C5C
		// (set) Token: 0x06002F52 RID: 12114 RVA: 0x00076A64 File Offset: 0x00074C64
		[global::System.Xml.Serialization.XmlAttribute]
		public uint item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00076A70 File Offset: 0x00074C70
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuple Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuple ct_Tuple = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuple();
			if (node.Attributes["fld"] != null)
			{
				ct_Tuple.fld = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["fld"]);
			}
			if (node.Attributes["hier"] != null)
			{
				ct_Tuple.hier = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["hier"]);
			}
			if (node.Attributes["item"] != null)
			{
				ct_Tuple.item = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["item"]);
			}
			return ct_Tuple;
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00076B10 File Offset: 0x00074D10
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fld", this.fld, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hier", this.hier, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "item", this.item, false);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002064 RID: 8292
		private uint fldField;

		// Token: 0x04002065 RID: 8293
		private bool fldFieldSpecified;

		// Token: 0x04002066 RID: 8294
		private uint hierField;

		// Token: 0x04002067 RID: 8295
		private bool hierFieldSpecified;

		// Token: 0x04002068 RID: 8296
		private uint itemField;
	}
}
