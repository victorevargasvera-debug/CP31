using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000140 RID: 320
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class LogMessageCategoryXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00022AFC File Offset: 0x00020CFC
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x00022B04 File Offset: 0x00020D04
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00022B18 File Offset: 0x00020D18
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x00022B20 File Offset: 0x00020D20
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x00022B34 File Offset: 0x00020D34
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x00022B3C File Offset: 0x00020D3C
		[global::System.Xml.Serialization.XmlAttribute]
		public string category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
				this.RaisePropertyChanged("category");
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x00022B50 File Offset: 0x00020D50
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x00022B58 File Offset: 0x00020D58
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00022B6C File Offset: 0x00020D6C
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00022B74 File Offset: 0x00020D74
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

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000D27 RID: 3367 RVA: 0x00022B88 File Offset: 0x00020D88
		// (remove) Token: 0x06000D28 RID: 3368 RVA: 0x00022BC4 File Offset: 0x00020DC4
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000D29 RID: 3369 RVA: 0x00022C00 File Offset: 0x00020E00
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000408 RID: 1032
		private string idField;

		// Token: 0x04000409 RID: 1033
		private global::Gibraltar.Server.Client.Data.LogMessageSeverityXml severityField;

		// Token: 0x0400040A RID: 1034
		private string categoryField;

		// Token: 0x0400040B RID: 1035
		private string captionField;

		// Token: 0x0400040C RID: 1036
		private int messageCountField;
	}
}
