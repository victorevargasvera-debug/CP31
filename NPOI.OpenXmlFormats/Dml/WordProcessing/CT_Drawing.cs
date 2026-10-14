using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x0200034B RID: 843
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Drawing
	{
		// Token: 0x0600212D RID: 8493 RVA: 0x00057528 File Offset: 0x00055728
		public static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing ct_Drawing = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing();
			ct_Drawing.anchor = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Anchor>();
			ct_Drawing.inline = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "anchor")
				{
					ct_Drawing.anchor.Add(global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Anchor.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "inline")
				{
					ct_Drawing.inline.Add(global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Drawing;
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x000575E8 File Offset: 0x000557E8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.anchor != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Anchor ct_Anchor in this.anchor)
				{
					ct_Anchor.Write(sw, "anchor");
				}
			}
			if (this.inline != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline ct_Inline in this.inline)
				{
					ct_Inline.Write(sw, "inline");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x000576C0 File Offset: 0x000558C0
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x000576C8 File Offset: 0x000558C8
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Anchor> anchor
		{
			get
			{
				return this.anchorField;
			}
			set
			{
				this.anchorField = value;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000576D1 File Offset: 0x000558D1
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x000576D9 File Offset: 0x000558D9
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline> inline
		{
			get
			{
				return this.inlineField;
			}
			set
			{
				this.inlineField = value;
			}
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x000576E4 File Offset: 0x000558E4
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline AddNewInline()
		{
			global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline ct_Inline = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline();
			if (this.inlineField == null)
			{
				this.inlineField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline>();
			}
			this.inlineField.Add(ct_Inline);
			return ct_Inline;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00057717 File Offset: 0x00055917
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Anchor> GetAnchorList()
		{
			return this.anchor;
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x0005771F File Offset: 0x0005591F
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline> GetInlineList()
		{
			return this.inline;
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00057728 File Offset: 0x00055928
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline GetInlineArray(int p)
		{
			global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline result;
			lock (this)
			{
				result = this.inline[p];
			}
			return result;
		}

		// Token: 0x0400197B RID: 6523
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Anchor> anchorField;

		// Token: 0x0400197C RID: 6524
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Inline> inlineField;
	}
}
