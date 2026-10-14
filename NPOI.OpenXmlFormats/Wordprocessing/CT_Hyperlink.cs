using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Dml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200010D RID: 269
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Serializable]
	public class CT_Hyperlink
	{
		// Token: 0x06000735 RID: 1845 RVA: 0x000161F0 File Offset: 0x000143F0
		public CT_Hyperlink()
		{
			this.invalidUrlField = "";
			this.actionField = "";
			this.tgtFrameField = "";
			this.tooltipField = "";
			this.historyField = true;
			this.highlightClickField = false;
			this.endSndField = false;
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00016244 File Offset: 0x00014444
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x0001624C File Offset: 0x0001444C
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EmbeddedWAVAudioFile snd
		{
			get
			{
				return this.sndField;
			}
			set
			{
				this.sndField = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00016255 File Offset: 0x00014455
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0001625D File Offset: 0x0001445D
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00016266 File Offset: 0x00014466
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0001626E File Offset: 0x0001446E
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00016277 File Offset: 0x00014477
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x0001627F File Offset: 0x0001447F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string invalidUrl
		{
			get
			{
				return this.invalidUrlField;
			}
			set
			{
				this.invalidUrlField = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00016288 File Offset: 0x00014488
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00016290 File Offset: 0x00014490
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00016299 File Offset: 0x00014499
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x000162A1 File Offset: 0x000144A1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string tgtFrame
		{
			get
			{
				return this.tgtFrameField;
			}
			set
			{
				this.tgtFrameField = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x000162AA File Offset: 0x000144AA
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x000162B2 File Offset: 0x000144B2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string tooltip
		{
			get
			{
				return this.tooltipField;
			}
			set
			{
				this.tooltipField = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x000162BB File Offset: 0x000144BB
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x000162C3 File Offset: 0x000144C3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool history
		{
			get
			{
				return this.historyField;
			}
			set
			{
				this.historyField = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000162CC File Offset: 0x000144CC
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000162D4 File Offset: 0x000144D4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool highlightClick
		{
			get
			{
				return this.highlightClickField;
			}
			set
			{
				this.highlightClickField = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000162DD File Offset: 0x000144DD
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x000162E5 File Offset: 0x000144E5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool endSnd
		{
			get
			{
				return this.endSndField;
			}
			set
			{
				this.endSndField = value;
			}
		}

		// Token: 0x0400066A RID: 1642
		private global::NPOI.OpenXmlFormats.Dml.CT_EmbeddedWAVAudioFile sndField;

		// Token: 0x0400066B RID: 1643
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x0400066C RID: 1644
		private string idField;

		// Token: 0x0400066D RID: 1645
		private string invalidUrlField;

		// Token: 0x0400066E RID: 1646
		private string actionField;

		// Token: 0x0400066F RID: 1647
		private string tgtFrameField;

		// Token: 0x04000670 RID: 1648
		private string tooltipField;

		// Token: 0x04000671 RID: 1649
		private bool historyField;

		// Token: 0x04000672 RID: 1650
		private bool highlightClickField;

		// Token: 0x04000673 RID: 1651
		private bool endSndField;
	}
}
