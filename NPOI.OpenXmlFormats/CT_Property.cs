using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000007 RID: 7
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Property
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000024D4 File Offset: 0x000006D4
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000024DC File Offset: 0x000006DC
		[global::System.Xml.Serialization.XmlElement("array", typeof(global::NPOI.OpenXmlFormats.CT_Array), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("blob", typeof(byte[]), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", DataType = "base64Binary")]
		[global::System.Xml.Serialization.XmlElement("bool", typeof(bool), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("bstr", typeof(string), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("cf", typeof(global::NPOI.OpenXmlFormats.CT_Cf), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("clsid", typeof(string), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("cy", typeof(string), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("date", typeof(global::System.DateTime), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("decimal", typeof(decimal), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("empty", typeof(global::NPOI.OpenXmlFormats.CT_Empty), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("error", typeof(string), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("filetime", typeof(global::System.DateTime), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("i1", typeof(sbyte), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("i2", typeof(short), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("i4", typeof(int), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("i8", typeof(long), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("int", typeof(int), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("lpstr", typeof(string), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("lpwstr", typeof(string), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("null", typeof(global::NPOI.OpenXmlFormats.CT_Null), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("oblob", typeof(byte[]), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", DataType = "base64Binary")]
		[global::System.Xml.Serialization.XmlElement("ostorage", typeof(byte[]), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", DataType = "base64Binary")]
		[global::System.Xml.Serialization.XmlElement("ostream", typeof(byte[]), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", DataType = "base64Binary")]
		[global::System.Xml.Serialization.XmlElement("r4", typeof(float), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("r8", typeof(double), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("storage", typeof(byte[]), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", DataType = "base64Binary")]
		[global::System.Xml.Serialization.XmlElement("stream", typeof(byte[]), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", DataType = "base64Binary")]
		[global::System.Xml.Serialization.XmlElement("ui1", typeof(byte), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("ui2", typeof(ushort), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("ui4", typeof(uint), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("ui8", typeof(ulong), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("uint", typeof(uint), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("vector", typeof(global::NPOI.OpenXmlFormats.CT_Vector), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlElement("vstream", typeof(global::NPOI.OpenXmlFormats.CT_Vstream), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemElementName")]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetFiletime()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetBool()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetBool()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetI1()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetI1()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetI2()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetI2()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetI4()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetFiletime()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetI4()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetUi1()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetUi1()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetUi2()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetUi4()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetUi8()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetUint()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetUint()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetR4()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetR8()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetR8()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000024E5 File Offset: 0x000006E5
		public string GetR4()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetUi8()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetDecimal()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000024E5 File Offset: 0x000006E5
		public decimal? GetDecimal()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetUi4()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetUi2()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetI8()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetI8()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetInt()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetInt()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000024E5 File Offset: 0x000006E5
		public object GetDate()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetDate()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000024E5 File Offset: 0x000006E5
		public string GetLpstr()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetLpstr()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000024E5 File Offset: 0x000006E5
		public string GetLpwstr()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000024F4 File Offset: 0x000006F4
		[global::System.Xml.Serialization.XmlIgnore]
		public global::NPOI.OpenXmlFormats.ItemChoiceType ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000024FD File Offset: 0x000006FD
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002505 File Offset: 0x00000705
		[global::System.Xml.Serialization.XmlAttribute]
		public string fmtid
		{
			get
			{
				return this.fmtidField;
			}
			set
			{
				this.fmtidField = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000250E File Offset: 0x0000070E
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002516 File Offset: 0x00000716
		[global::System.Xml.Serialization.XmlAttribute]
		public int pid
		{
			get
			{
				return this.pidField;
			}
			set
			{
				this.pidField = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000251F File Offset: 0x0000071F
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002527 File Offset: 0x00000727
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002530 File Offset: 0x00000730
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002538 File Offset: 0x00000738
		[global::System.Xml.Serialization.XmlAttribute]
		public string linkTarget
		{
			get
			{
				return this.linkTargetField;
			}
			set
			{
				this.linkTargetField = value;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002544 File Offset: 0x00000744
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.OpenXmlFormats.CT_Property))
			{
				return false;
			}
			global::NPOI.OpenXmlFormats.CT_Property ct_Property = (global::NPOI.OpenXmlFormats.CT_Property)obj;
			return !(ct_Property.fmtidField != this.fmtidField) && ct_Property.itemElementNameField == this.itemElementNameField && ct_Property.itemField == this.itemField && !(ct_Property.linkTargetField != this.linkTargetField) && !(ct_Property.nameField != this.nameField) && ct_Property.pidField == this.pidField;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000025C8 File Offset: 0x000007C8
		public override int GetHashCode()
		{
			return this.pidField.GetHashCode();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000025D5 File Offset: 0x000007D5
		public override string ToString()
		{
			return string.Format("[CT_Property][pid={0},name={1}]", this.pidField, this.nameField);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetLpwstr()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0400000C RID: 12
		private object itemField;

		// Token: 0x0400000D RID: 13
		private global::NPOI.OpenXmlFormats.ItemChoiceType itemElementNameField;

		// Token: 0x0400000E RID: 14
		private string fmtidField;

		// Token: 0x0400000F RID: 15
		private int pidField;

		// Token: 0x04000010 RID: 16
		private string nameField;

		// Token: 0x04000011 RID: 17
		private string linkTargetField;
	}
}
