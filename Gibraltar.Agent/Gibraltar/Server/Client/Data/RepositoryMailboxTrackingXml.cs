using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200014C RID: 332
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class RepositoryMailboxTrackingXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x000238FC File Offset: 0x00021AFC
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x00023904 File Offset: 0x00021B04
		public string statusMessage
		{
			get
			{
				return this.statusMessageField;
			}
			set
			{
				this.statusMessageField = value;
				this.RaisePropertyChanged("statusMessage");
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00023918 File Offset: 0x00021B18
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x00023920 File Offset: 0x00021B20
		public global::Gibraltar.Server.Client.Data.DateTimeOffsetXml lastContactDt
		{
			get
			{
				return this.lastContactDtField;
			}
			set
			{
				this.lastContactDtField = value;
				this.RaisePropertyChanged("lastContactDt");
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x00023934 File Offset: 0x00021B34
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x0002393C File Offset: 0x00021B3C
		public global::Gibraltar.Server.Client.Data.DateTimeOffsetXml updatedDt
		{
			get
			{
				return this.updatedDtField;
			}
			set
			{
				this.updatedDtField = value;
				this.RaisePropertyChanged("updatedDt");
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x00023950 File Offset: 0x00021B50
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x00023958 File Offset: 0x00021B58
		[global::System.Xml.Serialization.XmlAttribute]
		public bool inError
		{
			get
			{
				return this.inErrorField;
			}
			set
			{
				this.inErrorField = value;
				this.RaisePropertyChanged("inError");
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06000DEB RID: 3563 RVA: 0x0002396C File Offset: 0x00021B6C
		// (remove) Token: 0x06000DEC RID: 3564 RVA: 0x000239A8 File Offset: 0x00021BA8
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000DED RID: 3565 RVA: 0x000239E4 File Offset: 0x00021BE4
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400047D RID: 1149
		private string statusMessageField;

		// Token: 0x0400047E RID: 1150
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml lastContactDtField;

		// Token: 0x0400047F RID: 1151
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml updatedDtField;

		// Token: 0x04000480 RID: 1152
		private bool inErrorField;
	}
}
