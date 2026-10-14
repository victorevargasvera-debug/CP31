using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000024 RID: 36
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NameOrCorporateType
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000331B File Offset: 0x0000151B
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00003323 File Offset: 0x00001523
		[global::System.Xml.Serialization.XmlElement("Corporate", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("NameList", typeof(global::NPOI.OpenXmlFormats.CT_NameListType))]
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

		// Token: 0x04000107 RID: 263
		private object itemField;
	}
}
