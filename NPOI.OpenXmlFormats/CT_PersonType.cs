using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000023 RID: 35
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PersonType
	{
		// Token: 0x06000149 RID: 329 RVA: 0x000032BF File Offset: 0x000014BF
		public CT_PersonType()
		{
			this.middleField = new global::System.Collections.Generic.List<string>();
			this.firstField = new global::System.Collections.Generic.List<string>();
			this.lastField = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000032E8 File Offset: 0x000014E8
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000032F0 File Offset: 0x000014F0
		[global::System.Xml.Serialization.XmlElement("Last")]
		public global::System.Collections.Generic.List<string> Last
		{
			get
			{
				return this.lastField;
			}
			set
			{
				this.lastField = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000032F9 File Offset: 0x000014F9
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00003301 File Offset: 0x00001501
		[global::System.Xml.Serialization.XmlElement("First")]
		public global::System.Collections.Generic.List<string> First
		{
			get
			{
				return this.firstField;
			}
			set
			{
				this.firstField = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000330A File Offset: 0x0000150A
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00003312 File Offset: 0x00001512
		[global::System.Xml.Serialization.XmlElement("Middle")]
		public global::System.Collections.Generic.List<string> Middle
		{
			get
			{
				return this.middleField;
			}
			set
			{
				this.middleField = value;
			}
		}

		// Token: 0x04000104 RID: 260
		private global::System.Collections.Generic.List<string> lastField;

		// Token: 0x04000105 RID: 261
		private global::System.Collections.Generic.List<string> firstField;

		// Token: 0x04000106 RID: 262
		private global::System.Collections.Generic.List<string> middleField;
	}
}
