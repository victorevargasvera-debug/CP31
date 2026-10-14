using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000258 RID: 600
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableStyle
	{
		// Token: 0x06001859 RID: 6233 RVA: 0x00043B0C File Offset: 0x00041D0C
		public CT_TableStyle()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
			this.nwCellField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.neCellField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.firstRowField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.swCellField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.seCellField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.lastRowField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.firstColField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.lastColField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.band2VField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.band1VField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.band2HField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.band1HField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.wholeTblField = new global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle();
			this.tblBgField = new global::NPOI.OpenXmlFormats.Dml.CT_TableBackgroundStyle();
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00043BC4 File Offset: 0x00041DC4
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x00043BCC File Offset: 0x00041DCC
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TableBackgroundStyle tblBg
		{
			get
			{
				return this.tblBgField;
			}
			set
			{
				this.tblBgField = value;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x00043BD5 File Offset: 0x00041DD5
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x00043BDD File Offset: 0x00041DDD
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle wholeTbl
		{
			get
			{
				return this.wholeTblField;
			}
			set
			{
				this.wholeTblField = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x00043BE6 File Offset: 0x00041DE6
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x00043BEE File Offset: 0x00041DEE
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle band1H
		{
			get
			{
				return this.band1HField;
			}
			set
			{
				this.band1HField = value;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x00043BF7 File Offset: 0x00041DF7
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x00043BFF File Offset: 0x00041DFF
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle band2H
		{
			get
			{
				return this.band2HField;
			}
			set
			{
				this.band2HField = value;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x00043C08 File Offset: 0x00041E08
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x00043C10 File Offset: 0x00041E10
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle band1V
		{
			get
			{
				return this.band1VField;
			}
			set
			{
				this.band1VField = value;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x00043C19 File Offset: 0x00041E19
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x00043C21 File Offset: 0x00041E21
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle band2V
		{
			get
			{
				return this.band2VField;
			}
			set
			{
				this.band2VField = value;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x00043C2A File Offset: 0x00041E2A
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x00043C32 File Offset: 0x00041E32
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle lastCol
		{
			get
			{
				return this.lastColField;
			}
			set
			{
				this.lastColField = value;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x00043C3B File Offset: 0x00041E3B
		// (set) Token: 0x06001869 RID: 6249 RVA: 0x00043C43 File Offset: 0x00041E43
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle firstCol
		{
			get
			{
				return this.firstColField;
			}
			set
			{
				this.firstColField = value;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x00043C4C File Offset: 0x00041E4C
		// (set) Token: 0x0600186B RID: 6251 RVA: 0x00043C54 File Offset: 0x00041E54
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle lastRow
		{
			get
			{
				return this.lastRowField;
			}
			set
			{
				this.lastRowField = value;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x00043C5D File Offset: 0x00041E5D
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x00043C65 File Offset: 0x00041E65
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle seCell
		{
			get
			{
				return this.seCellField;
			}
			set
			{
				this.seCellField = value;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x00043C6E File Offset: 0x00041E6E
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x00043C76 File Offset: 0x00041E76
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle swCell
		{
			get
			{
				return this.swCellField;
			}
			set
			{
				this.swCellField = value;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x00043C7F File Offset: 0x00041E7F
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x00043C87 File Offset: 0x00041E87
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle firstRow
		{
			get
			{
				return this.firstRowField;
			}
			set
			{
				this.firstRowField = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00043C90 File Offset: 0x00041E90
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x00043C98 File Offset: 0x00041E98
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle neCell
		{
			get
			{
				return this.neCellField;
			}
			set
			{
				this.neCellField = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00043CA1 File Offset: 0x00041EA1
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x00043CA9 File Offset: 0x00041EA9
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle nwCell
		{
			get
			{
				return this.nwCellField;
			}
			set
			{
				this.nwCellField = value;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00043CB2 File Offset: 0x00041EB2
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x00043CBA File Offset: 0x00041EBA
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
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

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x00043CC3 File Offset: 0x00041EC3
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x00043CCB File Offset: 0x00041ECB
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string styleId
		{
			get
			{
				return this.styleIdField;
			}
			set
			{
				this.styleIdField = value;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00043CD4 File Offset: 0x00041ED4
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x00043CDC File Offset: 0x00041EDC
		[global::System.Xml.Serialization.XmlAttribute]
		public string styleName
		{
			get
			{
				return this.styleNameField;
			}
			set
			{
				this.styleNameField = value;
			}
		}

		// Token: 0x040012AE RID: 4782
		private global::NPOI.OpenXmlFormats.Dml.CT_TableBackgroundStyle tblBgField;

		// Token: 0x040012AF RID: 4783
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle wholeTblField;

		// Token: 0x040012B0 RID: 4784
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle band1HField;

		// Token: 0x040012B1 RID: 4785
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle band2HField;

		// Token: 0x040012B2 RID: 4786
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle band1VField;

		// Token: 0x040012B3 RID: 4787
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle band2VField;

		// Token: 0x040012B4 RID: 4788
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle lastColField;

		// Token: 0x040012B5 RID: 4789
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle firstColField;

		// Token: 0x040012B6 RID: 4790
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle lastRowField;

		// Token: 0x040012B7 RID: 4791
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle seCellField;

		// Token: 0x040012B8 RID: 4792
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle swCellField;

		// Token: 0x040012B9 RID: 4793
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle firstRowField;

		// Token: 0x040012BA RID: 4794
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle neCellField;

		// Token: 0x040012BB RID: 4795
		private global::NPOI.OpenXmlFormats.Dml.CT_TablePartStyle nwCellField;

		// Token: 0x040012BC RID: 4796
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040012BD RID: 4797
		private string styleIdField;

		// Token: 0x040012BE RID: 4798
		private string styleNameField;
	}
}
