using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004F4 RID: 1268
	[global::System.Serializable]
	public class CT_Authors
	{
		// Token: 0x0600358F RID: 13711 RVA: 0x00085E15 File Offset: 0x00084015
		public int SizeOfAuthorArray()
		{
			if (this.authorField != null)
			{
				return this.authorField.Count;
			}
			return 0;
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00085E2C File Offset: 0x0008402C
		public string GetAuthorArray(int index)
		{
			if (this.authorField != null)
			{
				return this.authorField[index];
			}
			return null;
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00085E44 File Offset: 0x00084044
		public void Insert(int index, string author)
		{
			if (this.authorField == null)
			{
				this.authorField = new global::System.Collections.Generic.List<string>();
			}
			this.authorField.Insert(index, author);
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00085E66 File Offset: 0x00084066
		public void AddAuthor(string name)
		{
			if (this.authorField == null)
			{
				this.authorField = new global::System.Collections.Generic.List<string>();
			}
			this.authorField.Add(name);
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x00085E87 File Offset: 0x00084087
		// (set) Token: 0x06003594 RID: 13716 RVA: 0x00085E8F File Offset: 0x0008408F
		[global::System.Xml.Serialization.XmlElement("author")]
		public global::System.Collections.Generic.List<string> author
		{
			get
			{
				return this.authorField;
			}
			set
			{
				this.authorField = value;
			}
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x00085E98 File Offset: 0x00084098
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Authors Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Authors ct_Authors = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Authors();
			ct_Authors.author = new global::System.Collections.Generic.List<string>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "author")
				{
					ct_Authors.author.Add(xmlNode.InnerText);
				}
			}
			return ct_Authors;
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x00085F24 File Offset: 0x00084124
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}>", nodeName));
			if (this.author != null)
			{
				foreach (string xml in this.author)
				{
					sw.Write(string.Format("<author>{0}</author>", global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(xml)));
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002392 RID: 9106
		private global::System.Collections.Generic.List<string> authorField;
	}
}
