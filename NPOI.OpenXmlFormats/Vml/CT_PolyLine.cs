using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml.Presentation;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using NPOI.OpenXmlFormats.Vml.Wordprocessing;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001EF RID: 495
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PolyLine
	{
		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x0003FF1C File Offset: 0x0003E11C
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x0003FF29 File Offset: 0x0003E129
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

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0003FF46 File Offset: 0x0003E146
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x0003FF53 File Offset: 0x0003E153
		[global::System.Xml.Serialization.XmlElement("ItemsElementName")]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType3[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField.ToArray();
			}
			set
			{
				if (value == null)
				{
					this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType3>();
					return;
				}
				this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType3>(value);
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0003FF70 File Offset: 0x0003E170
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x0003FF78 File Offset: 0x0003E178
		[global::System.Xml.Serialization.XmlAttribute]
		public string points
		{
			get
			{
				return this.pointsField;
			}
			set
			{
				this.pointsField = value;
			}
		}

		// Token: 0x04000F55 RID: 3925
		private global::System.Collections.Generic.List<object> itemsField = new global::System.Collections.Generic.List<object>();

		// Token: 0x04000F56 RID: 3926
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType3> itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType3>();

		// Token: 0x04000F57 RID: 3927
		private string pointsField;
	}
}
