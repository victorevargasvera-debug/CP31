using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000014 RID: 20
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType
	{
		// Token: 0x0400008C RID: 140
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:bool")]
		@bool,
		// Token: 0x0400008D RID: 141
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:bstr")]
		bstr,
		// Token: 0x0400008E RID: 142
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:cy")]
		cy,
		// Token: 0x0400008F RID: 143
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:date")]
		date,
		// Token: 0x04000090 RID: 144
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:decimal")]
		@decimal,
		// Token: 0x04000091 RID: 145
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:error")]
		error,
		// Token: 0x04000092 RID: 146
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i1")]
		i1,
		// Token: 0x04000093 RID: 147
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i2")]
		i2,
		// Token: 0x04000094 RID: 148
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i4")]
		i4,
		// Token: 0x04000095 RID: 149
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:int")]
		@int,
		// Token: 0x04000096 RID: 150
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:r4")]
		r4,
		// Token: 0x04000097 RID: 151
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:r8")]
		r8,
		// Token: 0x04000098 RID: 152
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui1")]
		ui1,
		// Token: 0x04000099 RID: 153
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui2")]
		ui2,
		// Token: 0x0400009A RID: 154
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui4")]
		ui4,
		// Token: 0x0400009B RID: 155
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:uint")]
		@uint,
		// Token: 0x0400009C RID: 156
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:variant")]
		variant
	}
}
