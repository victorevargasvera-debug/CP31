using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200013A RID: 314
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class StoredCredentialXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x00022500 File Offset: 0x00020700
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x00022508 File Offset: 0x00020708
		[global::System.Xml.Serialization.XmlAttribute]
		public string key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				this.keyField = value;
				this.RaisePropertyChanged("key");
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0002251C File Offset: 0x0002071C
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00022524 File Offset: 0x00020724
		[global::System.Xml.Serialization.XmlAttribute]
		public string account
		{
			get
			{
				return this.accountField;
			}
			set
			{
				this.accountField = value;
				this.RaisePropertyChanged("account");
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00022538 File Offset: 0x00020738
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x00022540 File Offset: 0x00020740
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

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06000CDF RID: 3295 RVA: 0x00022554 File Offset: 0x00020754
		// (remove) Token: 0x06000CE0 RID: 3296 RVA: 0x00022590 File Offset: 0x00020790
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000225CC File Offset: 0x000207CC
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040003E5 RID: 997
		private string keyField;

		// Token: 0x040003E6 RID: 998
		private string accountField;

		// Token: 0x040003E7 RID: 999
		private string passwordField;
	}
}
