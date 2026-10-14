using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200014D RID: 333
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class RepositoryMailboxXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000DEF RID: 3567 RVA: 0x00023A18 File Offset: 0x00021C18
		public RepositoryMailboxXml()
		{
			this.portField = 0;
			this.useSslField = false;
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00023A30 File Offset: 0x00021C30
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x00023A38 File Offset: 0x00021C38
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

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00023A4C File Offset: 0x00021C4C
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x00023A54 File Offset: 0x00021C54
		public global::Gibraltar.Server.Client.Data.RepositoryMailboxTrackingXml tracking
		{
			get
			{
				return this.trackingField;
			}
			set
			{
				this.trackingField = value;
				this.RaisePropertyChanged("tracking");
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x00023A68 File Offset: 0x00021C68
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x00023A70 File Offset: 0x00021C70
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

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x00023A84 File Offset: 0x00021C84
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x00023A8C File Offset: 0x00021C8C
		[global::System.Xml.Serialization.XmlAttribute]
		public string server
		{
			get
			{
				return this.serverField;
			}
			set
			{
				this.serverField = value;
				this.RaisePropertyChanged("server");
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x00023AA0 File Offset: 0x00021CA0
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x00023AA8 File Offset: 0x00021CA8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int port
		{
			get
			{
				return this.portField;
			}
			set
			{
				this.portField = value;
				this.RaisePropertyChanged("port");
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x00023ABC File Offset: 0x00021CBC
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x00023AC4 File Offset: 0x00021CC4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool useSsl
		{
			get
			{
				return this.useSslField;
			}
			set
			{
				this.useSslField = value;
				this.RaisePropertyChanged("useSsl");
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00023AD8 File Offset: 0x00021CD8
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x00023AE0 File Offset: 0x00021CE0
		[global::System.Xml.Serialization.XmlAttribute]
		public string userName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
				this.RaisePropertyChanged("userName");
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00023AF4 File Offset: 0x00021CF4
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x00023AFC File Offset: 0x00021CFC
		[global::System.Xml.Serialization.XmlAttribute]
		public string password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
				this.RaisePropertyChanged("password");
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06000E00 RID: 3584 RVA: 0x00023B10 File Offset: 0x00021D10
		// (remove) Token: 0x06000E01 RID: 3585 RVA: 0x00023B4C File Offset: 0x00021D4C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E02 RID: 3586 RVA: 0x00023B88 File Offset: 0x00021D88
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000482 RID: 1154
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml updatedDtField;

		// Token: 0x04000483 RID: 1155
		private global::Gibraltar.Server.Client.Data.RepositoryMailboxTrackingXml trackingField;

		// Token: 0x04000484 RID: 1156
		private string idField;

		// Token: 0x04000485 RID: 1157
		private string serverField;

		// Token: 0x04000486 RID: 1158
		private int portField;

		// Token: 0x04000487 RID: 1159
		private bool useSslField;

		// Token: 0x04000488 RID: 1160
		private string userNameField;

		// Token: 0x04000489 RID: 1161
		private string passwordField;
	}
}
