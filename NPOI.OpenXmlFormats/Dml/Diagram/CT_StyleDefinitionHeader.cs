using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003C6 RID: 966
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("styleDefHdr", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_StyleDefinitionHeader
	{
		// Token: 0x060025F7 RID: 9719 RVA: 0x0005E974 File Offset: 0x0005CB74
		public CT_StyleDefinitionHeader()
		{
			this.catLstField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDCategory>();
			this.descField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDDescription>();
			this.titleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDName>();
			this.minVerField = "http://schemas.openxmlformats.org/drawingml/2006/diagram";
			this.resIdField = 0;
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x0005E9AF File Offset: 0x0005CBAF
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x0005E9B7 File Offset: 0x0005CBB7
		[global::System.Xml.Serialization.XmlElement("title", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDName> title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x0005E9C0 File Offset: 0x0005CBC0
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x0005E9C8 File Offset: 0x0005CBC8
		[global::System.Xml.Serialization.XmlElement("desc", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDDescription> desc
		{
			get
			{
				return this.descField;
			}
			set
			{
				this.descField = value;
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x0005E9D1 File Offset: 0x0005CBD1
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x0005E9D9 File Offset: 0x0005CBD9
		[global::System.Xml.Serialization.XmlArray(Order = 2)]
		[global::System.Xml.Serialization.XmlArrayItem("cat", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDCategory> catLst
		{
			get
			{
				return this.catLstField;
			}
			set
			{
				this.catLstField = value;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x0005E9E2 File Offset: 0x0005CBE2
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x0005E9EA File Offset: 0x0005CBEA
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x0005E9F3 File Offset: 0x0005CBF3
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x0005E9FB File Offset: 0x0005CBFB
		[global::System.Xml.Serialization.XmlAttribute]
		public string uniqueId
		{
			get
			{
				return this.uniqueIdField;
			}
			set
			{
				this.uniqueIdField = value;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x0005EA04 File Offset: 0x0005CC04
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x0005EA0C File Offset: 0x0005CC0C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("http://schemas.openxmlformats.org/drawingml/2006/diagram")]
		public string minVer
		{
			get
			{
				return this.minVerField;
			}
			set
			{
				this.minVerField = value;
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x0005EA15 File Offset: 0x0005CC15
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x0005EA1D File Offset: 0x0005CC1D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int resId
		{
			get
			{
				return this.resIdField;
			}
			set
			{
				this.resIdField = value;
			}
		}

		// Token: 0x04001C66 RID: 7270
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDName> titleField;

		// Token: 0x04001C67 RID: 7271
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDDescription> descField;

		// Token: 0x04001C68 RID: 7272
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDCategory> catLstField;

		// Token: 0x04001C69 RID: 7273
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001C6A RID: 7274
		private string uniqueIdField;

		// Token: 0x04001C6B RID: 7275
		private string minVerField;

		// Token: 0x04001C6C RID: 7276
		private int resIdField;
	}
}
