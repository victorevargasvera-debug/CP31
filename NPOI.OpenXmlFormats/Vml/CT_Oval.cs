using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml.Presentation;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using NPOI.OpenXmlFormats.Vml.Wordprocessing;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001ED RID: 493
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Oval
	{
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0003FEAA File Offset: 0x0003E0AA
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x0003FEB7 File Offset: 0x0003E0B7
		[global::System.Xml.Serialization.XmlElement("ClientData", typeof(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData), Namespace = "urn:schemas-microsoft-com:office:excel")]
		[global::System.Xml.Serialization.XmlElement("textdata", typeof(global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel), Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
		[global::System.Xml.Serialization.XmlElement("anchorlock", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("borderbottom", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("borderleft", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("borderright", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("bordertop", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("wrap", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("fill", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Fill))]
		[global::System.Xml.Serialization.XmlElement("formulas", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Formulas))]
		[global::System.Xml.Serialization.XmlElement("handles", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Handles))]
		[global::System.Xml.Serialization.XmlElement("imagedata", typeof(global::NPOI.OpenXmlFormats.Vml.CT_ImageData))]
		[global::System.Xml.Serialization.XmlElement("path", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Path))]
		[global::System.Xml.Serialization.XmlElement("shadow", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Shadow))]
		[global::System.Xml.Serialization.XmlElement("stroke", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Stroke))]
		[global::System.Xml.Serialization.XmlElement("textbox", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Textbox))]
		[global::System.Xml.Serialization.XmlElement("textpath", typeof(global::NPOI.OpenXmlFormats.Vml.CT_TextPath))]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public object[] Items
		{
			get
			{
				return this.itemsField.ToArray();
			}
			set
			{
				if (value == null)
				{
					this.itemsField = new global::System.Collections.Generic.List<object>();
					return;
				}
				this.itemsField = new global::System.Collections.Generic.List<object>(value);
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0003FED4 File Offset: 0x0003E0D4
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x0003FEE1 File Offset: 0x0003E0E1
		[global::System.Xml.Serialization.XmlElement("ItemsElementName")]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType2[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField.ToArray();
			}
			set
			{
				if (value == null)
				{
					this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType2>();
					return;
				}
				this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType2>(value);
			}
		}

		// Token: 0x04000F41 RID: 3905
		private global::System.Collections.Generic.List<object> itemsField = new global::System.Collections.Generic.List<object>();

		// Token: 0x04000F42 RID: 3906
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType2> itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType2>();
	}
}
