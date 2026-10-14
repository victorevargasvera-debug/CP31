using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000171 RID: 369
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_TblStyleOverrideType
	{
		// Token: 0x04000B0C RID: 2828
		wholeTable,
		// Token: 0x04000B0D RID: 2829
		firstRow,
		// Token: 0x04000B0E RID: 2830
		lastRow,
		// Token: 0x04000B0F RID: 2831
		firstCol,
		// Token: 0x04000B10 RID: 2832
		lastCol,
		// Token: 0x04000B11 RID: 2833
		band1Vert,
		// Token: 0x04000B12 RID: 2834
		band2Vert,
		// Token: 0x04000B13 RID: 2835
		band1Horz,
		// Token: 0x04000B14 RID: 2836
		band2Horz,
		// Token: 0x04000B15 RID: 2837
		neCell,
		// Token: 0x04000B16 RID: 2838
		nwCell,
		// Token: 0x04000B17 RID: 2839
		seCell,
		// Token: 0x04000B18 RID: 2840
		swCell
	}
}
