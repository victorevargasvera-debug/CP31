using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace NPOI.SS
{
	// Token: 0x0200000B RID: 11
	public class HtmlDocumentFacade
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002548 File Offset: 0x00000748
		public HtmlDocumentFacade(global::System.Xml.XmlDocument document)
		{
			this.document = document;
			this.html = document.CreateElement("html");
			document.AppendChild(this.html);
			this.body = document.CreateElement("body");
			this.head = document.CreateElement("head");
			this.stylesheetElement = document.CreateElement("style");
			this.stylesheetElement.SetAttribute("type", "text/css");
			this.html.AppendChild(this.head);
			this.html.AppendChild(this.body);
			this.head.AppendChild(this.stylesheetElement);
			this.AddCharset();
			this.AddStyleClass(this.body, "b", "white-space-collapsing:preserve;");
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002628 File Offset: 0x00000828
		public void AddCharset()
		{
			global::System.Xml.XmlElement xmlElement = this.document.CreateElement("meta");
			xmlElement.SetAttribute("http-equiv", "Content-Type");
			xmlElement.SetAttribute("content", "text/html; charset=UTF-8");
			this.head.AppendChild(xmlElement);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002673 File Offset: 0x00000873
		public void AddAuthor(string value)
		{
			this.AddMeta("author", value);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002681 File Offset: 0x00000881
		public void AddDescription(string value)
		{
			this.AddMeta("description", value);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000268F File Offset: 0x0000088F
		public void AddKeywords(string value)
		{
			this.AddMeta("keywords", value);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000026A0 File Offset: 0x000008A0
		public void AddMeta(string name, string value)
		{
			global::System.Xml.XmlElement xmlElement = this.document.CreateElement("meta");
			xmlElement.SetAttribute("name", name);
			xmlElement.SetAttribute("content", value);
			this.head.AppendChild(xmlElement);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000026E4 File Offset: 0x000008E4
		public void AddStyleClass(global::System.Xml.XmlElement element, string classNamePrefix, string style)
		{
			string attribute = element.GetAttribute("class");
			string orCreateCssClass = this.GetOrCreateCssClass(element.Name, classNamePrefix, style);
			string namespaceURI = string.IsNullOrEmpty(attribute) ? orCreateCssClass : (attribute + " " + orCreateCssClass);
			element.GetAttribute("class", namespaceURI);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002731 File Offset: 0x00000931
		public global::System.Xml.XmlElement CreateBlock()
		{
			return this.document.CreateElement("div");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002743 File Offset: 0x00000943
		public global::System.Xml.XmlElement CreateBookmark(string name)
		{
			global::System.Xml.XmlElement xmlElement = this.document.CreateElement("a");
			xmlElement.SetAttribute("name", name);
			return xmlElement;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002761 File Offset: 0x00000961
		public global::System.Xml.XmlElement CreateHeader1()
		{
			return this.document.CreateElement("h1");
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002773 File Offset: 0x00000973
		public global::System.Xml.XmlElement CreateHeader2()
		{
			return this.document.CreateElement("h2");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002785 File Offset: 0x00000985
		public global::System.Xml.XmlElement CreateHyperlink(string internalDestination)
		{
			global::System.Xml.XmlElement xmlElement = this.document.CreateElement("a");
			xmlElement.SetAttribute("href", internalDestination);
			return xmlElement;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000027A3 File Offset: 0x000009A3
		public global::System.Xml.XmlElement CreateImage(string src)
		{
			global::System.Xml.XmlElement xmlElement = this.document.CreateElement("img");
			xmlElement.SetAttribute("src", src);
			return xmlElement;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000027C1 File Offset: 0x000009C1
		public global::System.Xml.XmlElement CreateLineBreak()
		{
			return this.document.CreateElement("br");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000027D3 File Offset: 0x000009D3
		public global::System.Xml.XmlElement CreateListItem()
		{
			return this.document.CreateElement("li");
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000027E5 File Offset: 0x000009E5
		public global::System.Xml.XmlElement CreateParagraph()
		{
			return this.document.CreateElement("p");
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000027F7 File Offset: 0x000009F7
		public global::System.Xml.XmlElement CreateTable()
		{
			return this.document.CreateElement("table");
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002809 File Offset: 0x00000A09
		public global::System.Xml.XmlElement CreateTableBody()
		{
			return this.document.CreateElement("tbody");
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000281B File Offset: 0x00000A1B
		public global::System.Xml.XmlElement CreateTableCell()
		{
			return this.document.CreateElement("td");
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000282D File Offset: 0x00000A2D
		public global::System.Xml.XmlElement CreateTableColumn()
		{
			return this.document.CreateElement("col");
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000283F File Offset: 0x00000A3F
		public global::System.Xml.XmlElement CreateTableColumnGroup()
		{
			return this.document.CreateElement("colgroup");
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002851 File Offset: 0x00000A51
		public global::System.Xml.XmlElement CreateTableHeader()
		{
			return this.document.CreateElement("thead");
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002863 File Offset: 0x00000A63
		public global::System.Xml.XmlElement CreateTableHeaderCell()
		{
			return this.document.CreateElement("th");
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002875 File Offset: 0x00000A75
		public global::System.Xml.XmlElement CreateTableRow()
		{
			return this.document.CreateElement("tr");
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002887 File Offset: 0x00000A87
		public global::System.Xml.XmlText CreateText(string data)
		{
			return this.document.CreateTextNode(data);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002895 File Offset: 0x00000A95
		public global::System.Xml.XmlElement CreateUnorderedList()
		{
			return this.document.CreateElement("ul");
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000028A7 File Offset: 0x00000AA7
		public global::System.Xml.XmlElement Body
		{
			get
			{
				return this.body;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000028AF File Offset: 0x00000AAF
		public global::System.Xml.XmlDocument Document
		{
			get
			{
				return this.document;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000028B7 File Offset: 0x00000AB7
		public global::System.Xml.XmlElement Head
		{
			get
			{
				return this.head;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000028C0 File Offset: 0x00000AC0
		public string GetOrCreateCssClass(string tagName, string classNamePrefix, string style)
		{
			if (!this.stylesheet.ContainsKey(tagName))
			{
				this.stylesheet.Add(tagName, new global::System.Collections.Generic.Dictionary<string, string>(1));
			}
			global::System.Collections.Generic.Dictionary<string, string> dictionary = this.stylesheet[tagName];
			if (dictionary.ContainsKey(style))
			{
				return dictionary[style];
			}
			string text = classNamePrefix + (dictionary.Count + 1).ToString();
			dictionary.Add(style, text);
			return text;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000292B File Offset: 0x00000B2B
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002944 File Offset: 0x00000B44
		public string Title
		{
			get
			{
				if (this.title == null)
				{
					return null;
				}
				return this.titleText.InnerText;
			}
			set
			{
				if (string.IsNullOrEmpty(value) && this.title != null)
				{
					this.head.RemoveChild(this.title);
					this.title = null;
					this.titleText = null;
				}
				if (this.title == null)
				{
					this.title = this.document.CreateElement("title");
					this.titleText = this.document.CreateTextNode(value);
					this.title.AppendChild(this.titleText);
					this.head.AppendChild(this.title);
				}
				this.titleText.InnerText = value;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000029E4 File Offset: 0x00000BE4
		public void UpdateStylesheet()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.Dictionary<string, string>> keyValuePair in this.stylesheet)
			{
				string key = keyValuePair.Key;
				foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
				{
					string key2 = keyValuePair2.Key;
					string value = keyValuePair2.Value;
					stringBuilder.Append(string.Concat(new string[]
					{
						key,
						".",
						value,
						"{",
						key2,
						"}\n"
					}));
				}
			}
			this.stylesheetElement.InnerText = stringBuilder.ToString();
		}

		// Token: 0x04000009 RID: 9
		protected global::System.Xml.XmlElement body;

		// Token: 0x0400000A RID: 10
		protected global::System.Xml.XmlDocument document;

		// Token: 0x0400000B RID: 11
		protected global::System.Xml.XmlElement head;

		// Token: 0x0400000C RID: 12
		protected global::System.Xml.XmlElement html;

		// Token: 0x0400000D RID: 13
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>> stylesheet = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>();

		// Token: 0x0400000E RID: 14
		private global::System.Xml.XmlElement stylesheetElement;

		// Token: 0x0400000F RID: 15
		protected global::System.Xml.XmlElement title;

		// Token: 0x04000010 RID: 16
		protected global::System.Xml.XmlText titleText;
	}
}
