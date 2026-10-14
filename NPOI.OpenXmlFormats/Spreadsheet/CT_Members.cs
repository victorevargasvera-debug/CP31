using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004DB RID: 1243
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Members
	{
		// Token: 0x060033F5 RID: 13301 RVA: 0x000826EC File Offset: 0x000808EC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Members Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Members ct_Members = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Members();
			if (node.Attributes["count"] != null)
			{
				ct_Members.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			if (node.Attributes["level"] != null)
			{
				ct_Members.level = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["level"]);
			}
			ct_Members.member = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Member>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "member")
				{
					ct_Members.member.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Member.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Members;
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x000827D4 File Offset: 0x000809D4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "level", this.level, false);
			sw.Write(">");
			if (this.member != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Member ct_Member in this.member)
				{
					ct_Member.Write(sw, "member");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00082884 File Offset: 0x00080A84
		public CT_Members()
		{
			this.memberField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Member>();
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x060033F8 RID: 13304 RVA: 0x00082897 File Offset: 0x00080A97
		// (set) Token: 0x060033F9 RID: 13305 RVA: 0x0008289F File Offset: 0x00080A9F
		[global::System.Xml.Serialization.XmlElement("member", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Member> member
		{
			get
			{
				return this.memberField;
			}
			set
			{
				this.memberField = value;
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x060033FA RID: 13306 RVA: 0x000828A8 File Offset: 0x00080AA8
		// (set) Token: 0x060033FB RID: 13307 RVA: 0x000828B0 File Offset: 0x00080AB0
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x060033FC RID: 13308 RVA: 0x000828B9 File Offset: 0x00080AB9
		// (set) Token: 0x060033FD RID: 13309 RVA: 0x000828C1 File Offset: 0x00080AC1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x000828CA File Offset: 0x00080ACA
		// (set) Token: 0x060033FF RID: 13311 RVA: 0x000828D2 File Offset: 0x00080AD2
		[global::System.Xml.Serialization.XmlAttribute]
		public uint level
		{
			get
			{
				return this.levelField;
			}
			set
			{
				this.levelField = value;
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06003400 RID: 13312 RVA: 0x000828DB File Offset: 0x00080ADB
		// (set) Token: 0x06003401 RID: 13313 RVA: 0x000828E3 File Offset: 0x00080AE3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool levelSpecified
		{
			get
			{
				return this.levelFieldSpecified;
			}
			set
			{
				this.levelFieldSpecified = value;
			}
		}

		// Token: 0x04002289 RID: 8841
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Member> memberField;

		// Token: 0x0400228A RID: 8842
		private uint countField;

		// Token: 0x0400228B RID: 8843
		private bool countFieldSpecified;

		// Token: 0x0400228C RID: 8844
		private uint levelField;

		// Token: 0x0400228D RID: 8845
		private bool levelFieldSpecified;
	}
}
