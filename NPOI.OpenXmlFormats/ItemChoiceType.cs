using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000009 RID: 9
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemChoiceType
	{
		// Token: 0x04000025 RID: 37
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:array")]
		array,
		// Token: 0x04000026 RID: 38
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:blob")]
		blob,
		// Token: 0x04000027 RID: 39
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:bool")]
		@bool,
		// Token: 0x04000028 RID: 40
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:bstr")]
		bstr,
		// Token: 0x04000029 RID: 41
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:cf")]
		cf,
		// Token: 0x0400002A RID: 42
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:clsid")]
		clsid,
		// Token: 0x0400002B RID: 43
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:cy")]
		cy,
		// Token: 0x0400002C RID: 44
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:date")]
		date,
		// Token: 0x0400002D RID: 45
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:decimal")]
		@decimal,
		// Token: 0x0400002E RID: 46
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:empty")]
		empty,
		// Token: 0x0400002F RID: 47
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:error")]
		error,
		// Token: 0x04000030 RID: 48
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:filetime")]
		filetime,
		// Token: 0x04000031 RID: 49
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i1")]
		i1,
		// Token: 0x04000032 RID: 50
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i2")]
		i2,
		// Token: 0x04000033 RID: 51
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i4")]
		i4,
		// Token: 0x04000034 RID: 52
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i8")]
		i8,
		// Token: 0x04000035 RID: 53
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:int")]
		@int,
		// Token: 0x04000036 RID: 54
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:lpstr")]
		lpstr,
		// Token: 0x04000037 RID: 55
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:lpwstr")]
		lpwstr,
		// Token: 0x04000038 RID: 56
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:null")]
		@null,
		// Token: 0x04000039 RID: 57
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:oblob")]
		oblob,
		// Token: 0x0400003A RID: 58
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ostorage")]
		ostorage,
		// Token: 0x0400003B RID: 59
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ostream")]
		ostream,
		// Token: 0x0400003C RID: 60
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:r4")]
		r4,
		// Token: 0x0400003D RID: 61
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:r8")]
		r8,
		// Token: 0x0400003E RID: 62
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:storage")]
		storage,
		// Token: 0x0400003F RID: 63
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:stream")]
		stream,
		// Token: 0x04000040 RID: 64
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui1")]
		ui1,
		// Token: 0x04000041 RID: 65
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui2")]
		ui2,
		// Token: 0x04000042 RID: 66
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui4")]
		ui4,
		// Token: 0x04000043 RID: 67
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui8")]
		ui8,
		// Token: 0x04000044 RID: 68
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:uint")]
		@uint,
		// Token: 0x04000045 RID: 69
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:vector")]
		vector,
		// Token: 0x04000046 RID: 70
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:vstream")]
		vstream
	}
}
