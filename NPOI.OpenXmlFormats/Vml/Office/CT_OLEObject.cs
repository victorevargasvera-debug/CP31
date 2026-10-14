using System;
using System.ComponentModel;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000224 RID: 548
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OLEObject
	{
		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x000429EF File Offset: 0x00040BEF
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x000429F7 File Offset: 0x00040BF7
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_OLELinkType LinkType
		{
			get
			{
				return this.linkTypeField;
			}
			set
			{
				this.linkTypeField = value;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x00042A00 File Offset: 0x00040C00
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x00042A08 File Offset: 0x00040C08
		[global::System.Xml.Serialization.XmlIgnore]
		public bool LinkTypeSpecified
		{
			get
			{
				return this.linkTypeFieldSpecified;
			}
			set
			{
				this.linkTypeFieldSpecified = value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x00042A11 File Offset: 0x00040C11
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x00042A19 File Offset: 0x00040C19
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank LockedField
		{
			get
			{
				return this.lockedFieldField;
			}
			set
			{
				this.lockedFieldField = value;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x00042A22 File Offset: 0x00040C22
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x00042A2A File Offset: 0x00040C2A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool LockedFieldSpecified
		{
			get
			{
				return this.lockedFieldFieldSpecified;
			}
			set
			{
				this.lockedFieldFieldSpecified = value;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x00042A33 File Offset: 0x00040C33
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x00042A3B File Offset: 0x00040C3B
		public string FieldCodes
		{
			get
			{
				return this.fieldCodesField;
			}
			set
			{
				this.fieldCodesField = value;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x00042A44 File Offset: 0x00040C44
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x00042A4C File Offset: 0x00040C4C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_OLEType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x00042A55 File Offset: 0x00040C55
		// (set) Token: 0x06001693 RID: 5779 RVA: 0x00042A5D File Offset: 0x00040C5D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool TypeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x00042A66 File Offset: 0x00040C66
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x00042A6E File Offset: 0x00040C6E
		[global::System.Xml.Serialization.XmlAttribute]
		public string ProgID
		{
			get
			{
				return this.progIDField;
			}
			set
			{
				this.progIDField = value;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x00042A77 File Offset: 0x00040C77
		// (set) Token: 0x06001697 RID: 5783 RVA: 0x00042A7F File Offset: 0x00040C7F
		[global::System.Xml.Serialization.XmlAttribute]
		public string ShapeID
		{
			get
			{
				return this.shapeIDField;
			}
			set
			{
				this.shapeIDField = value;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x00042A88 File Offset: 0x00040C88
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x00042A90 File Offset: 0x00040C90
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_OLEDrawAspect DrawAspect
		{
			get
			{
				return this.drawAspectField;
			}
			set
			{
				this.drawAspectField = value;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x00042A99 File Offset: 0x00040C99
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x00042AA1 File Offset: 0x00040CA1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool DrawAspectSpecified
		{
			get
			{
				return this.drawAspectFieldSpecified;
			}
			set
			{
				this.drawAspectFieldSpecified = value;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x00042AAA File Offset: 0x00040CAA
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x00042AB2 File Offset: 0x00040CB2
		[global::System.Xml.Serialization.XmlAttribute]
		public string ObjectID
		{
			get
			{
				return this.objectIDField;
			}
			set
			{
				this.objectIDField = value;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x00042ABB File Offset: 0x00040CBB
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x00042AC3 File Offset: 0x00040CC3
		[global::System.Xml.Serialization.XmlAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x00042ACC File Offset: 0x00040CCC
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x00042AD4 File Offset: 0x00040CD4
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_OLEUpdateMode UpdateMode
		{
			get
			{
				return this.updateModeField;
			}
			set
			{
				this.updateModeField = value;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x00042ADD File Offset: 0x00040CDD
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x00042AE5 File Offset: 0x00040CE5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool UpdateModeSpecified
		{
			get
			{
				return this.updateModeFieldSpecified;
			}
			set
			{
				this.updateModeFieldSpecified = value;
			}
		}

		// Token: 0x04001196 RID: 4502
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_OLELinkType linkTypeField;

		// Token: 0x04001197 RID: 4503
		private bool linkTypeFieldSpecified;

		// Token: 0x04001198 RID: 4504
		private global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank lockedFieldField;

		// Token: 0x04001199 RID: 4505
		private bool lockedFieldFieldSpecified;

		// Token: 0x0400119A RID: 4506
		private string fieldCodesField;

		// Token: 0x0400119B RID: 4507
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_OLEType typeField;

		// Token: 0x0400119C RID: 4508
		private bool typeFieldSpecified;

		// Token: 0x0400119D RID: 4509
		private string progIDField;

		// Token: 0x0400119E RID: 4510
		private string shapeIDField;

		// Token: 0x0400119F RID: 4511
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_OLEDrawAspect drawAspectField;

		// Token: 0x040011A0 RID: 4512
		private bool drawAspectFieldSpecified;

		// Token: 0x040011A1 RID: 4513
		private string objectIDField;

		// Token: 0x040011A2 RID: 4514
		private string idField;

		// Token: 0x040011A3 RID: 4515
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_OLEUpdateMode updateModeField;

		// Token: 0x040011A4 RID: 4516
		private bool updateModeFieldSpecified;
	}
}
