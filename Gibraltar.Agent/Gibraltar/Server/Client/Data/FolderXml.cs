using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200014A RID: 330
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class FolderXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x000236E0 File Offset: 0x000218E0
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x000236E8 File Offset: 0x000218E8
		public global::Gibraltar.Server.Client.Data.FolderDetailXml folderDetail
		{
			get
			{
				return this.folderDetailField;
			}
			set
			{
				this.folderDetailField = value;
				this.RaisePropertyChanged("folderDetail");
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x000236FC File Offset: 0x000218FC
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00023704 File Offset: 0x00021904
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

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00023718 File Offset: 0x00021918
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00023720 File Offset: 0x00021920
		[global::System.Xml.Serialization.XmlAttribute]
		public long version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00023734 File Offset: 0x00021934
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x0002373C File Offset: 0x0002193C
		[global::System.Xml.Serialization.XmlAttribute]
		public bool deleted
		{
			get
			{
				return this.deletedField;
			}
			set
			{
				this.deletedField = value;
				this.RaisePropertyChanged("deleted");
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06000DD5 RID: 3541 RVA: 0x00023750 File Offset: 0x00021950
		// (remove) Token: 0x06000DD6 RID: 3542 RVA: 0x0002378C File Offset: 0x0002198C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000237C8 File Offset: 0x000219C8
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000474 RID: 1140
		private global::Gibraltar.Server.Client.Data.FolderDetailXml folderDetailField;

		// Token: 0x04000475 RID: 1141
		private string idField;

		// Token: 0x04000476 RID: 1142
		private long versionField;

		// Token: 0x04000477 RID: 1143
		private bool deletedField;
	}
}
