using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200007A RID: 122
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocPartCategory
	{
		// Token: 0x0600037F RID: 895 RVA: 0x0000B005 File Offset: 0x00009205
		public CT_DocPartCategory()
		{
			this.galleryField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartGallery();
			this.nameField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000B023 File Offset: 0x00009223
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0000B02B File Offset: 0x0000922B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000B034 File Offset: 0x00009234
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0000B03C File Offset: 0x0000923C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartGallery gallery
		{
			get
			{
				return this.galleryField;
			}
			set
			{
				this.galleryField = value;
			}
		}

		// Token: 0x0400030C RID: 780
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String nameField;

		// Token: 0x0400030D RID: 781
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocPartGallery galleryField;
	}
}
