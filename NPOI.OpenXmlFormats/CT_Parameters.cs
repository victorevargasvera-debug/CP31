using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200003A RID: 58
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Parameters
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00003B16 File Offset: 0x00001D16
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00003B1E File Offset: 0x00001D1E
		[global::System.Xml.Serialization.XmlElement("parameter")]
		public global::NPOI.OpenXmlFormats.CT_Parameter[] parameter
		{
			get
			{
				return this.parameterField;
			}
			set
			{
				this.parameterField = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00003B27 File Offset: 0x00001D27
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00003B2F File Offset: 0x00001D2F
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00003B38 File Offset: 0x00001D38
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00003B40 File Offset: 0x00001D40
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x04000186 RID: 390
		private global::NPOI.OpenXmlFormats.CT_Parameter[] parameterField;

		// Token: 0x04000187 RID: 391
		private uint countField;

		// Token: 0x04000188 RID: 392
		private bool countFieldSpecified;
	}
}
