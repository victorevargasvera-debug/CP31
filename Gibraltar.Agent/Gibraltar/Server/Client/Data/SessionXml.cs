using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000147 RID: 327
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class SessionXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x000233C8 File Offset: 0x000215C8
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x000233D0 File Offset: 0x000215D0
		public global::Gibraltar.Server.Client.Data.SessionDetailXml sessionDetail
		{
			get
			{
				return this.sessionDetailField;
			}
			set
			{
				this.sessionDetailField = value;
				this.RaisePropertyChanged("sessionDetail");
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x000233E4 File Offset: 0x000215E4
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x000233EC File Offset: 0x000215EC
		[global::System.Xml.Serialization.XmlArrayItem("file", IsNullable = false)]
		public global::Gibraltar.Server.Client.Data.SessionFileXml[] files
		{
			get
			{
				return this.filesField;
			}
			set
			{
				this.filesField = value;
				this.RaisePropertyChanged("files");
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x00023400 File Offset: 0x00021600
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x00023408 File Offset: 0x00021608
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0002341C File Offset: 0x0002161C
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x00023424 File Offset: 0x00021624
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

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00023438 File Offset: 0x00021638
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x00023440 File Offset: 0x00021640
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

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00023454 File Offset: 0x00021654
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x0002345C File Offset: 0x0002165C
		[global::System.Xml.Serialization.XmlAttribute]
		public bool isComplete
		{
			get
			{
				return this.isCompleteField;
			}
			set
			{
				this.isCompleteField = value;
				this.RaisePropertyChanged("isComplete");
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00023470 File Offset: 0x00021670
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x00023478 File Offset: 0x00021678
		[global::System.Xml.Serialization.XmlIgnore]
		public bool isCompleteSpecified
		{
			get
			{
				return this.isCompleteFieldSpecified;
			}
			set
			{
				this.isCompleteFieldSpecified = value;
				this.RaisePropertyChanged("isCompleteSpecified");
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06000DB3 RID: 3507 RVA: 0x0002348C File Offset: 0x0002168C
		// (remove) Token: 0x06000DB4 RID: 3508 RVA: 0x000234C8 File Offset: 0x000216C8
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00023504 File Offset: 0x00021704
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400045E RID: 1118
		private global::Gibraltar.Server.Client.Data.SessionDetailXml sessionDetailField;

		// Token: 0x0400045F RID: 1119
		private global::Gibraltar.Server.Client.Data.SessionFileXml[] filesField;

		// Token: 0x04000460 RID: 1120
		private string idField;

		// Token: 0x04000461 RID: 1121
		private long versionField;

		// Token: 0x04000462 RID: 1122
		private bool deletedField;

		// Token: 0x04000463 RID: 1123
		private bool isCompleteField;

		// Token: 0x04000464 RID: 1124
		private bool isCompleteFieldSpecified;
	}
}
