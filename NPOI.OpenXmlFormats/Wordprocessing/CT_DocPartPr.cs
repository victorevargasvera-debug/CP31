using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000076 RID: 118
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocPartPr
	{
		// Token: 0x06000374 RID: 884 RVA: 0x0000AF8E File Offset: 0x0000918E
		public CT_DocPartPr()
		{
			this.itemsElementNameField = new global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType11[0];
			this.itemsField = new object[0];
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0000AFAE File Offset: 0x000091AE
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0000AFB6 File Offset: 0x000091B6
		[global::System.Xml.Serialization.XmlElement("behaviors", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartBehaviors), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("category", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartCategory), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("description", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_String), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("guid", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Guid), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("name", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartName), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("style", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_String), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("types", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartTypes), Order = 0)]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public object[] Items
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000AFBF File Offset: 0x000091BF
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000AFC7 File Offset: 0x000091C7
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType11[] ItemsElementName
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

		// Token: 0x04000304 RID: 772
		private object[] itemsField;

		// Token: 0x04000305 RID: 773
		private global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType11[] itemsElementNameField;
	}
}
