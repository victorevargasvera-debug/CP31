using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000013 RID: 19
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
	[global::System.Serializable]
	public class CT_Array
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00002CDD File Offset: 0x00000EDD
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002CE5 File Offset: 0x00000EE5
		[global::System.Xml.Serialization.XmlElement("bool", typeof(bool))]
		[global::System.Xml.Serialization.XmlElement("bstr", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("cy", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("date", typeof(global::System.DateTime))]
		[global::System.Xml.Serialization.XmlElement("decimal", typeof(decimal))]
		[global::System.Xml.Serialization.XmlElement("error", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("i1", typeof(sbyte))]
		[global::System.Xml.Serialization.XmlElement("i2", typeof(short))]
		[global::System.Xml.Serialization.XmlElement("i4", typeof(int))]
		[global::System.Xml.Serialization.XmlElement("int", typeof(int))]
		[global::System.Xml.Serialization.XmlElement("r4", typeof(float))]
		[global::System.Xml.Serialization.XmlElement("r8", typeof(double))]
		[global::System.Xml.Serialization.XmlElement("ui1", typeof(byte))]
		[global::System.Xml.Serialization.XmlElement("ui2", typeof(ushort))]
		[global::System.Xml.Serialization.XmlElement("ui4", typeof(uint))]
		[global::System.Xml.Serialization.XmlElement("uint", typeof(uint))]
		[global::System.Xml.Serialization.XmlElement("variant", typeof(global::NPOI.OpenXmlFormats.CT_Variant))]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002CEE File Offset: 0x00000EEE
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002CF6 File Offset: 0x00000EF6
		[global::System.Xml.Serialization.XmlIgnore]
		public global::NPOI.OpenXmlFormats.ItemsChoiceType[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002CFF File Offset: 0x00000EFF
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002D07 File Offset: 0x00000F07
		[global::System.Xml.Serialization.XmlAttribute]
		public int lBounds
		{
			get
			{
				return this.lBoundsField;
			}
			set
			{
				this.lBoundsField = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002D10 File Offset: 0x00000F10
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002D18 File Offset: 0x00000F18
		[global::System.Xml.Serialization.XmlAttribute]
		public int uBounds
		{
			get
			{
				return this.uBoundsField;
			}
			set
			{
				this.uBoundsField = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002D21 File Offset: 0x00000F21
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002D29 File Offset: 0x00000F29
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.ST_ArrayBaseType baseType
		{
			get
			{
				return this.baseTypeField;
			}
			set
			{
				this.baseTypeField = value;
			}
		}

		// Token: 0x04000086 RID: 134
		private object[] itemsField;

		// Token: 0x04000087 RID: 135
		private global::NPOI.OpenXmlFormats.ItemsChoiceType[] itemsElementNameField;

		// Token: 0x04000088 RID: 136
		private int lBoundsField;

		// Token: 0x04000089 RID: 137
		private int uBoundsField;

		// Token: 0x0400008A RID: 138
		private global::NPOI.OpenXmlFormats.ST_ArrayBaseType baseTypeField;
	}
}
