using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200015A RID: 346
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class StoredCredentialsListXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x00024668 File Offset: 0x00022868
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x00024670 File Offset: 0x00022870
		[global::System.Xml.Serialization.XmlElement("credential")]
		public global::Gibraltar.Server.Client.Data.StoredCredentialXml[] credential
		{
			get
			{
				return this.credentialField;
			}
			set
			{
				this.credentialField = value;
				this.RaisePropertyChanged("credential");
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06000E7D RID: 3709 RVA: 0x00024684 File Offset: 0x00022884
		// (remove) Token: 0x06000E7E RID: 3710 RVA: 0x000246C0 File Offset: 0x000228C0
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E7F RID: 3711 RVA: 0x000246FC File Offset: 0x000228FC
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040004CA RID: 1226
		private global::Gibraltar.Server.Client.Data.StoredCredentialXml[] credentialField;
	}
}
