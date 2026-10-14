using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000199 RID: 409
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Captions
	{
		// Token: 0x06000F5D RID: 3933 RVA: 0x000322C8 File Offset: 0x000304C8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Captions Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Captions ct_Captions = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Captions();
			ct_Captions.caption = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Caption>();
			ct_Captions.autoCaptions = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AutoCaption>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "caption")
				{
					ct_Captions.caption.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Caption.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "autoCaptions")
				{
					ct_Captions.autoCaptions.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_AutoCaption.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Captions;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00032388 File Offset: 0x00030588
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.caption != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Caption ct_Caption in this.caption)
				{
					ct_Caption.Write(sw, "caption");
				}
			}
			if (this.autoCaptions != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_AutoCaption ct_AutoCaption in this.autoCaptions)
				{
					ct_AutoCaption.Write(sw, "autoCaptions");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00032460 File Offset: 0x00030660
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x00032468 File Offset: 0x00030668
		[global::System.Xml.Serialization.XmlElement("caption", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Caption> caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00032471 File Offset: 0x00030671
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x00032479 File Offset: 0x00030679
		[global::System.Xml.Serialization.XmlArray(Order = 1)]
		[global::System.Xml.Serialization.XmlArrayItem("autoCaption", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AutoCaption> autoCaptions
		{
			get
			{
				return this.autoCaptionsField;
			}
			set
			{
				this.autoCaptionsField = value;
			}
		}

		// Token: 0x04000C92 RID: 3218
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Caption> captionField;

		// Token: 0x04000C93 RID: 3219
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AutoCaption> autoCaptionsField;
	}
}
