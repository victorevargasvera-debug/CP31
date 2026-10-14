using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200014E RID: 334
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class ClientRepositoryXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00023BB4 File Offset: 0x00021DB4
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x00023BBC File Offset: 0x00021DBC
		public global::Gibraltar.Server.Client.Data.DateTimeOffsetXml addedDt
		{
			get
			{
				return this.addedDtField;
			}
			set
			{
				this.addedDtField = value;
				this.RaisePropertyChanged("addedDt");
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00023BD0 File Offset: 0x00021DD0
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x00023BD8 File Offset: 0x00021DD8
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

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00023BEC File Offset: 0x00021DEC
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x00023BF4 File Offset: 0x00021DF4
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

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00023C08 File Offset: 0x00021E08
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00023C10 File Offset: 0x00021E10
		[global::System.Xml.Serialization.XmlAttribute]
		public string hostName
		{
			get
			{
				return this.hostNameField;
			}
			set
			{
				this.hostNameField = value;
				this.RaisePropertyChanged("hostName");
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00023C24 File Offset: 0x00021E24
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00023C2C File Offset: 0x00021E2C
		[global::System.Xml.Serialization.XmlAttribute]
		public string computerKey
		{
			get
			{
				return this.computerKeyField;
			}
			set
			{
				this.computerKeyField = value;
				this.RaisePropertyChanged("computerKey");
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00023C40 File Offset: 0x00021E40
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00023C48 File Offset: 0x00021E48
		[global::System.Xml.Serialization.XmlAttribute]
		public long currentSessionsVersion
		{
			get
			{
				return this.currentSessionsVersionField;
			}
			set
			{
				this.currentSessionsVersionField = value;
				this.RaisePropertyChanged("currentSessionsVersion");
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00023C5C File Offset: 0x00021E5C
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00023C64 File Offset: 0x00021E64
		[global::System.Xml.Serialization.XmlIgnore]
		public bool currentSessionsVersionSpecified
		{
			get
			{
				return this.currentSessionsVersionFieldSpecified;
			}
			set
			{
				this.currentSessionsVersionFieldSpecified = value;
				this.RaisePropertyChanged("currentSessionsVersionSpecified");
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00023C78 File Offset: 0x00021E78
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00023C80 File Offset: 0x00021E80
		[global::System.Xml.Serialization.XmlAttribute]
		public string publicKey
		{
			get
			{
				return this.publicKeyField;
			}
			set
			{
				this.publicKeyField = value;
				this.RaisePropertyChanged("publicKey");
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00023C94 File Offset: 0x00021E94
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x00023C9C File Offset: 0x00021E9C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Gibraltar.Server.Client.Data.ClientRepositoryStatusXml status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				this.RaisePropertyChanged("status");
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00023CB0 File Offset: 0x00021EB0
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x00023CB8 File Offset: 0x00021EB8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool statusSpecified
		{
			get
			{
				return this.statusFieldSpecified;
			}
			set
			{
				this.statusFieldSpecified = value;
				this.RaisePropertyChanged("statusSpecified");
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06000E17 RID: 3607 RVA: 0x00023CCC File Offset: 0x00021ECC
		// (remove) Token: 0x06000E18 RID: 3608 RVA: 0x00023D08 File Offset: 0x00021F08
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E19 RID: 3609 RVA: 0x00023D44 File Offset: 0x00021F44
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400048B RID: 1163
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml addedDtField;

		// Token: 0x0400048C RID: 1164
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml lastContactDtField;

		// Token: 0x0400048D RID: 1165
		private string idField;

		// Token: 0x0400048E RID: 1166
		private string hostNameField;

		// Token: 0x0400048F RID: 1167
		private string computerKeyField;

		// Token: 0x04000490 RID: 1168
		private long currentSessionsVersionField;

		// Token: 0x04000491 RID: 1169
		private bool currentSessionsVersionFieldSpecified;

		// Token: 0x04000492 RID: 1170
		private string publicKeyField;

		// Token: 0x04000493 RID: 1171
		private global::Gibraltar.Server.Client.Data.ClientRepositoryStatusXml statusField;

		// Token: 0x04000494 RID: 1172
		private bool statusFieldSpecified;
	}
}
