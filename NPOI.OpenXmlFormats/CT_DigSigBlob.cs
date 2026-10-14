using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000010 RID: 16
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DigSigBlob
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00002BDC File Offset: 0x00000DDC
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002BE4 File Offset: 0x00000DE4
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", DataType = "base64Binary")]
		public byte[] blob
		{
			get
			{
				return this.blobField;
			}
			set
			{
				this.blobField = value;
			}
		}

		// Token: 0x04000078 RID: 120
		private byte[] blobField;
	}
}
