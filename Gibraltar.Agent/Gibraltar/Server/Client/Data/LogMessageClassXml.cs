using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200013E RID: 318
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class LogMessageClassXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x000229C4 File Offset: 0x00020BC4
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x000229CC File Offset: 0x00020BCC
		[global::System.Xml.Serialization.XmlAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("id");
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x000229E0 File Offset: 0x00020BE0
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x000229E8 File Offset: 0x00020BE8
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Gibraltar.Server.Client.Data.LogMessageSeverityXml severity
		{
			get
			{
				return this.severityField;
			}
			set
			{
				this.severityField = value;
				this.RaisePropertyChanged("severity");
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x000229FC File Offset: 0x00020BFC
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00022A04 File Offset: 0x00020C04
		[global::System.Xml.Serialization.XmlAttribute]
		public string @class
		{
			get
			{
				return this.classField;
			}
			set
			{
				this.classField = value;
				this.RaisePropertyChanged("class");
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00022A18 File Offset: 0x00020C18
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00022A20 File Offset: 0x00020C20
		[global::System.Xml.Serialization.XmlAttribute]
		public string caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
				this.RaisePropertyChanged("caption");
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00022A34 File Offset: 0x00020C34
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00022A3C File Offset: 0x00020C3C
		[global::System.Xml.Serialization.XmlAttribute]
		public int messageCount
		{
			get
			{
				return this.messageCountField;
			}
			set
			{
				this.messageCountField = value;
				this.RaisePropertyChanged("messageCount");
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000D19 RID: 3353 RVA: 0x00022A50 File Offset: 0x00020C50
		// (remove) Token: 0x06000D1A RID: 3354 RVA: 0x00022A8C File Offset: 0x00020C8C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000D1B RID: 3355 RVA: 0x00022AC8 File Offset: 0x00020CC8
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040003FC RID: 1020
		private string idField;

		// Token: 0x040003FD RID: 1021
		private global::Gibraltar.Server.Client.Data.LogMessageSeverityXml severityField;

		// Token: 0x040003FE RID: 1022
		private string classField;

		// Token: 0x040003FF RID: 1023
		private string captionField;

		// Token: 0x04000400 RID: 1024
		private int messageCountField;
	}
}
