using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200024C RID: 588
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableRow
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x000434A8 File Offset: 0x000416A8
		public CT_TableRow()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
			this.tcField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableCell>();
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x000434C6 File Offset: 0x000416C6
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x000434CE File Offset: 0x000416CE
		[global::System.Xml.Serialization.XmlElement("tc", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableCell> tc
		{
			get
			{
				return this.tcField;
			}
			set
			{
				this.tcField = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x000434D7 File Offset: 0x000416D7
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x000434DF File Offset: 0x000416DF
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x000434E8 File Offset: 0x000416E8
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x000434F0 File Offset: 0x000416F0
		[global::System.Xml.Serialization.XmlAttribute]
		public long h
		{
			get
			{
				return this.hField;
			}
			set
			{
				this.hField = value;
			}
		}

		// Token: 0x04001266 RID: 4710
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableCell> tcField;

		// Token: 0x04001267 RID: 4711
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001268 RID: 4712
		private long hField;
	}
}
