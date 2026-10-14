using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200008B RID: 139
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FontSig
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0000B3FA File Offset: 0x000095FA
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0000B402 File Offset: 0x00009602
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] usb0
		{
			get
			{
				return this.usb0Field;
			}
			set
			{
				this.usb0Field = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0000B40B File Offset: 0x0000960B
		// (set) Token: 0x060003CB RID: 971 RVA: 0x0000B413 File Offset: 0x00009613
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] usb1
		{
			get
			{
				return this.usb1Field;
			}
			set
			{
				this.usb1Field = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0000B41C File Offset: 0x0000961C
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0000B424 File Offset: 0x00009624
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] usb2
		{
			get
			{
				return this.usb2Field;
			}
			set
			{
				this.usb2Field = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000B42D File Offset: 0x0000962D
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0000B435 File Offset: 0x00009635
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] usb3
		{
			get
			{
				return this.usb3Field;
			}
			set
			{
				this.usb3Field = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0000B43E File Offset: 0x0000963E
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0000B446 File Offset: 0x00009646
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] csb0
		{
			get
			{
				return this.csb0Field;
			}
			set
			{
				this.csb0Field = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0000B44F File Offset: 0x0000964F
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0000B457 File Offset: 0x00009657
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] csb1
		{
			get
			{
				return this.csb1Field;
			}
			set
			{
				this.csb1Field = value;
			}
		}

		// Token: 0x04000371 RID: 881
		private byte[] usb0Field;

		// Token: 0x04000372 RID: 882
		private byte[] usb1Field;

		// Token: 0x04000373 RID: 883
		private byte[] usb2Field;

		// Token: 0x04000374 RID: 884
		private byte[] usb3Field;

		// Token: 0x04000375 RID: 885
		private byte[] csb0Field;

		// Token: 0x04000376 RID: 886
		private byte[] csb1Field;
	}
}
