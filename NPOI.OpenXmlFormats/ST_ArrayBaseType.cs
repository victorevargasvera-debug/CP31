using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000008 RID: 8
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
	[global::System.Serializable]
	public enum ST_ArrayBaseType
	{
		// Token: 0x04000013 RID: 19
		variant,
		// Token: 0x04000014 RID: 20
		i1,
		// Token: 0x04000015 RID: 21
		i2,
		// Token: 0x04000016 RID: 22
		i4,
		// Token: 0x04000017 RID: 23
		@int,
		// Token: 0x04000018 RID: 24
		ui1,
		// Token: 0x04000019 RID: 25
		ui2,
		// Token: 0x0400001A RID: 26
		ui4,
		// Token: 0x0400001B RID: 27
		@uint,
		// Token: 0x0400001C RID: 28
		r4,
		// Token: 0x0400001D RID: 29
		r8,
		// Token: 0x0400001E RID: 30
		@decimal,
		// Token: 0x0400001F RID: 31
		bstr,
		// Token: 0x04000020 RID: 32
		date,
		// Token: 0x04000021 RID: 33
		@bool,
		// Token: 0x04000022 RID: 34
		cy,
		// Token: 0x04000023 RID: 35
		error
	}
}
