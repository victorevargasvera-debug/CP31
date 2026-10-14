using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200012B RID: 299
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Background))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PictureBase
	{
		// Token: 0x06000819 RID: 2073 RVA: 0x0001B5AD File Offset: 0x000197AD
		public CT_PictureBase()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType9>();
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x0001B5CB File Offset: 0x000197CB
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x0001B5D3 File Offset: 0x000197D3
		[global::System.Xml.Serialization.XmlAnyElement(Namespace = "urn:schemas-microsoft-com:office:office", Order = 0)]
		[global::System.Xml.Serialization.XmlAnyElement(Namespace = "urn:schemas-microsoft-com:vml", Order = 0)]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x0001B5DC File Offset: 0x000197DC
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x0001B5E4 File Offset: 0x000197E4
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType9> ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0001B5F0 File Offset: 0x000197F0
		public void Set(object obj)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PictureBase obj2;
			if (obj is global::NPOI.OpenXmlFormats.Vml.CT_Group)
			{
				foreach (object item in ((global::NPOI.OpenXmlFormats.Vml.CT_Group)obj).Items)
				{
					obj2 = this;
					lock (obj2)
					{
						this.itemsField.Add(item);
						this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType9.vml);
					}
				}
				return;
			}
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(obj.GetType());
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Xml.XmlWriterSettings xmlWriterSettings = new global::System.Xml.XmlWriterSettings();
			xmlWriterSettings.Encoding = global::System.Text.Encoding.UTF8;
			xmlWriterSettings.OmitXmlDeclaration = true;
			global::System.Xml.Serialization.XmlSerializerNamespaces xmlSerializerNamespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
			xmlSerializerNamespaces.Add("v", "urn:schemas-microsoft-com:vml");
			xmlSerializerNamespaces.Add("o", "urn:schemas-microsoft-com:office:office");
			global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(stringBuilder, xmlWriterSettings);
			xmlSerializer.Serialize(xmlWriter, obj, xmlSerializerNamespaces);
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.LoadXml(stringBuilder.ToString());
			obj2 = this;
			lock (obj2)
			{
				this.itemsField.Add(xmlDocument.DocumentElement.CloneNode(true));
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType9.vml);
			}
		}

		// Token: 0x04000738 RID: 1848
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04000739 RID: 1849
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType9> itemsElementNameField;
	}
}
