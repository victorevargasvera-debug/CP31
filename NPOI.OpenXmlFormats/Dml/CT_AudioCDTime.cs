using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000245 RID: 581
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AudioCDTime
	{
		// Token: 0x06001773 RID: 6003 RVA: 0x00043185 File Offset: 0x00041385
		public CT_AudioCDTime()
		{
			this.timeField = 0U;
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x00043194 File Offset: 0x00041394
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x0004319C File Offset: 0x0004139C
		[global::System.Xml.Serialization.XmlAttribute]
		public byte track
		{
			get
			{
				return this.trackField;
			}
			set
			{
				this.trackField = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x000431A5 File Offset: 0x000413A5
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x000431AD File Offset: 0x000413AD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint time
		{
			get
			{
				return this.timeField;
			}
			set
			{
				this.timeField = value;
			}
		}

		// Token: 0x04001240 RID: 4672
		private byte trackField;

		// Token: 0x04001241 RID: 4673
		private uint timeField;
	}
}
