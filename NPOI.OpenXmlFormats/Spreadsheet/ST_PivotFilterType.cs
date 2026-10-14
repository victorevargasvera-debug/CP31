using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004E0 RID: 1248
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public enum ST_PivotFilterType
	{
		// Token: 0x040022AD RID: 8877
		unknown,
		// Token: 0x040022AE RID: 8878
		count,
		// Token: 0x040022AF RID: 8879
		percent,
		// Token: 0x040022B0 RID: 8880
		sum,
		// Token: 0x040022B1 RID: 8881
		captionEqual,
		// Token: 0x040022B2 RID: 8882
		captionNotEqual,
		// Token: 0x040022B3 RID: 8883
		captionBeginsWith,
		// Token: 0x040022B4 RID: 8884
		captionNotBeginsWith,
		// Token: 0x040022B5 RID: 8885
		captionEndsWith,
		// Token: 0x040022B6 RID: 8886
		captionNotEndsWith,
		// Token: 0x040022B7 RID: 8887
		captionContains,
		// Token: 0x040022B8 RID: 8888
		captionNotContains,
		// Token: 0x040022B9 RID: 8889
		captionGreaterThan,
		// Token: 0x040022BA RID: 8890
		captionGreaterThanOrEqual,
		// Token: 0x040022BB RID: 8891
		captionLessThan,
		// Token: 0x040022BC RID: 8892
		captionLessThanOrEqual,
		// Token: 0x040022BD RID: 8893
		captionBetween,
		// Token: 0x040022BE RID: 8894
		captionNotBetween,
		// Token: 0x040022BF RID: 8895
		valueEqual,
		// Token: 0x040022C0 RID: 8896
		valueNotEqual,
		// Token: 0x040022C1 RID: 8897
		valueGreaterThan,
		// Token: 0x040022C2 RID: 8898
		valueGreaterThanOrEqual,
		// Token: 0x040022C3 RID: 8899
		valueLessThan,
		// Token: 0x040022C4 RID: 8900
		valueLessThanOrEqual,
		// Token: 0x040022C5 RID: 8901
		valueBetween,
		// Token: 0x040022C6 RID: 8902
		valueNotBetween,
		// Token: 0x040022C7 RID: 8903
		dateEqual,
		// Token: 0x040022C8 RID: 8904
		dateNotEqual,
		// Token: 0x040022C9 RID: 8905
		dateOlderThan,
		// Token: 0x040022CA RID: 8906
		dateOlderThanOrEqual,
		// Token: 0x040022CB RID: 8907
		dateNewerThan,
		// Token: 0x040022CC RID: 8908
		dateNewerThanOrEqual,
		// Token: 0x040022CD RID: 8909
		dateBetween,
		// Token: 0x040022CE RID: 8910
		dateNotBetween,
		// Token: 0x040022CF RID: 8911
		tomorrow,
		// Token: 0x040022D0 RID: 8912
		today,
		// Token: 0x040022D1 RID: 8913
		yesterday,
		// Token: 0x040022D2 RID: 8914
		nextWeek,
		// Token: 0x040022D3 RID: 8915
		thisWeek,
		// Token: 0x040022D4 RID: 8916
		lastWeek,
		// Token: 0x040022D5 RID: 8917
		nextMonth,
		// Token: 0x040022D6 RID: 8918
		thisMonth,
		// Token: 0x040022D7 RID: 8919
		lastMonth,
		// Token: 0x040022D8 RID: 8920
		nextQuarter,
		// Token: 0x040022D9 RID: 8921
		thisQuarter,
		// Token: 0x040022DA RID: 8922
		lastQuarter,
		// Token: 0x040022DB RID: 8923
		nextYear,
		// Token: 0x040022DC RID: 8924
		thisYear,
		// Token: 0x040022DD RID: 8925
		lastYear,
		// Token: 0x040022DE RID: 8926
		yearToDate,
		// Token: 0x040022DF RID: 8927
		Q1,
		// Token: 0x040022E0 RID: 8928
		Q2,
		// Token: 0x040022E1 RID: 8929
		Q3,
		// Token: 0x040022E2 RID: 8930
		Q4,
		// Token: 0x040022E3 RID: 8931
		M1,
		// Token: 0x040022E4 RID: 8932
		M2,
		// Token: 0x040022E5 RID: 8933
		M3,
		// Token: 0x040022E6 RID: 8934
		M4,
		// Token: 0x040022E7 RID: 8935
		M5,
		// Token: 0x040022E8 RID: 8936
		M6,
		// Token: 0x040022E9 RID: 8937
		M7,
		// Token: 0x040022EA RID: 8938
		M8,
		// Token: 0x040022EB RID: 8939
		M9,
		// Token: 0x040022EC RID: 8940
		M10,
		// Token: 0x040022ED RID: 8941
		M11,
		// Token: 0x040022EE RID: 8942
		M12
	}
}
