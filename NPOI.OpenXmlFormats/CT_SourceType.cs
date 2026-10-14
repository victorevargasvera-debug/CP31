using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200001F RID: 31
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SourceType
	{
		// Token: 0x0600013C RID: 316 RVA: 0x0000321B File Offset: 0x0000141B
		public CT_SourceType()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.ItemsChoiceType1>();
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00003239 File Offset: 0x00001439
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00003241 File Offset: 0x00001441
		[global::System.Xml.Serialization.XmlElement("AbbreviatedCaseNumber", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("AlbumTitle", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Author", typeof(global::NPOI.OpenXmlFormats.CT_AuthorType))]
		[global::System.Xml.Serialization.XmlElement("BookTitle", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("BroadcastTitle", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Broadcaster", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("CaseNumber", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("ChapterNumber", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("City", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Comments", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("ConferenceName", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("CountryRegion", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Court", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Day", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("DayAccessed", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Department", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Distributor", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Edition", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Guid", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Institution", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("InternetSiteTitle", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Issue", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("JournalName", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("LCID", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Medium", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Month", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("MonthAccessed", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("NumberVolumes", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Pages", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("PatentNumber", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("PeriodicalTitle", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("ProductionCompany", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("PublicationTitle", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Publisher", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("RecordingNumber", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("RefOrder", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Reporter", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("ShortTitle", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("SourceType", typeof(global::NPOI.OpenXmlFormats.ST_SourceType))]
		[global::System.Xml.Serialization.XmlElement("StandardNumber", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("StateProvince", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Station", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Tag", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Theater", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("ThesisType", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Title", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Type", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("URL", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Version", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Volume", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("Year", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("YearAccessed", typeof(string))]
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000324A File Offset: 0x0000144A
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00003252 File Offset: 0x00001452
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.ItemsChoiceType1> ItemsElementName
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

		// Token: 0x040000CA RID: 202
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x040000CB RID: 203
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.ItemsChoiceType1> itemsElementNameField;
	}
}
