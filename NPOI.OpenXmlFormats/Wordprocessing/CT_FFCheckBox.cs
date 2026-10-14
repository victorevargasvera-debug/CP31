using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000094 RID: 148
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FFCheckBox
	{
		// Token: 0x0600041D RID: 1053 RVA: 0x0000C4F5 File Offset: 0x0000A6F5
		public CT_FFCheckBox()
		{
			this.checkedField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.defaultField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0000C513 File Offset: 0x0000A713
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x0000C51B File Offset: 0x0000A71B
		[global::System.Xml.Serialization.XmlElement("size", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sizeAuto", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff), Order = 0)]
		public object Item
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

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000C524 File Offset: 0x0000A724
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x0000C52C File Offset: 0x0000A72C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff @default
		{
			get
			{
				return this.defaultField;
			}
			set
			{
				this.defaultField = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000C535 File Offset: 0x0000A735
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x0000C53D File Offset: 0x0000A73D
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff @checked
		{
			get
			{
				return this.checkedField;
			}
			set
			{
				this.checkedField = value;
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000C548 File Offset: 0x0000A748
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFCheckBox Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFCheckBox ct_FFCheckBox = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFCheckBox();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "checked")
				{
					ct_FFCheckBox.checkedField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "default")
				{
					ct_FFCheckBox.defaultField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "size")
				{
					ct_FFCheckBox.itemField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sizeAuto")
				{
					ct_FFCheckBox.itemField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_FFCheckBox;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000C630 File Offset: 0x0000A830
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}>", nodeName));
			if (this.defaultField != null)
			{
				this.defaultField.Write(sw, "default");
			}
			if (this.checkedField != null)
			{
				this.checkedField.Write(sw, "checked");
			}
			if (this.itemField != null)
			{
				if (this.itemField is global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff)
				{
					(this.itemField as global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff).Write(sw, "sizeAuto");
				}
				else
				{
					(this.itemField as global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure).Write(sw, "size");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x040003A2 RID: 930
		private object itemField;

		// Token: 0x040003A3 RID: 931
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff defaultField;

		// Token: 0x040003A4 RID: 932
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff checkedField;
	}
}
