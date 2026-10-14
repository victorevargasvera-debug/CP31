using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200042B RID: 1067
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DispUnits
	{
		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x0006B1E6 File Offset: 0x000693E6
		// (set) Token: 0x06002AA7 RID: 10919 RVA: 0x0006B1EE File Offset: 0x000693EE
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_BuiltInUnit builtInUnit
		{
			get
			{
				return this.builtInUnitField;
			}
			set
			{
				this.builtInUnitField = value;
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x0006B1F7 File Offset: 0x000693F7
		// (set) Token: 0x06002AA9 RID: 10921 RVA: 0x0006B1FF File Offset: 0x000693FF
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double custUnit
		{
			get
			{
				return this.custUnitField;
			}
			set
			{
				this.custUnitField = value;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x0006B208 File Offset: 0x00069408
		// (set) Token: 0x06002AAB RID: 10923 RVA: 0x0006B210 File Offset: 0x00069410
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispUnitsLbl dispUnitsLbl
		{
			get
			{
				return this.dispUnitsLblField;
			}
			set
			{
				this.dispUnitsLblField = value;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06002AAC RID: 10924 RVA: 0x0006B219 File Offset: 0x00069419
		// (set) Token: 0x06002AAD RID: 10925 RVA: 0x0006B221 File Offset: 0x00069421
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLst
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

		// Token: 0x06002AAE RID: 10926 RVA: 0x000024E5 File Offset: 0x000006E5
		internal static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispUnits Parse(global::System.Xml.XmlNode childNode, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000024E5 File Offset: 0x000006E5
		internal void Write(global::System.IO.StreamWriter sw, string p)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04001E63 RID: 7779
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispUnitsLbl dispUnitsLblField;

		// Token: 0x04001E64 RID: 7780
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;

		// Token: 0x04001E65 RID: 7781
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_BuiltInUnit builtInUnitField;

		// Token: 0x04001E66 RID: 7782
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double custUnitField;
	}
}
