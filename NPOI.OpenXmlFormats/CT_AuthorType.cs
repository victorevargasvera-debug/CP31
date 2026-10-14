using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000021 RID: 33
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AuthorType
	{
		// Token: 0x06000141 RID: 321 RVA: 0x0000325B File Offset: 0x0000145B
		public CT_AuthorType()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.ItemsChoiceType>();
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00003279 File Offset: 0x00001479
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00003281 File Offset: 0x00001481
		[global::System.Xml.Serialization.XmlElement("Artist", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Author", typeof(global::NPOI.OpenXmlFormats.CT_NameOrCorporateType))]
		[global::System.Xml.Serialization.XmlElement("BookAuthor", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Compiler", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Composer", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Conductor", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Counsel", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Director", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Editor", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Interviewee", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Interviewer", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Inventor", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Performer", typeof(global::NPOI.OpenXmlFormats.CT_NameOrCorporateType))]
		[global::System.Xml.Serialization.XmlElement("ProducerName", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Translator", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
		[global::System.Xml.Serialization.XmlElement("Writer", typeof(global::NPOI.OpenXmlFormats.CT_NameType))]
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000328A File Offset: 0x0000148A
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00003292 File Offset: 0x00001492
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.ItemsChoiceType> ItemsElementName
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

		// Token: 0x04000101 RID: 257
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04000102 RID: 258
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.ItemsChoiceType> itemsElementNameField;
	}
}
