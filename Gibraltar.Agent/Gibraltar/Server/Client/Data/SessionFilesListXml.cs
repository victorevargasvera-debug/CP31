using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000153 RID: 339
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class SessionFilesListXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00023F50 File Offset: 0x00022150
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x00023F58 File Offset: 0x00022158
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

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00023F6C File Offset: 0x0002216C
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x00023F74 File Offset: 0x00022174
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

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00023F88 File Offset: 0x00022188
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00023F90 File Offset: 0x00022190
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x00023FA4 File Offset: 0x000221A4
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x00023FAC File Offset: 0x000221AC
		[global::System.Xml.Serialization.XmlAttribute]
		public bool singleStreamOnly
		{
			get
			{
				return this.singleStreamOnlyField;
			}
			set
			{
				this.singleStreamOnlyField = value;
				this.RaisePropertyChanged("singleStreamOnly");
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06000E33 RID: 3635 RVA: 0x00023FC0 File Offset: 0x000221C0
		// (remove) Token: 0x06000E34 RID: 3636 RVA: 0x00023FFC File Offset: 0x000221FC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E35 RID: 3637 RVA: 0x00024038 File Offset: 0x00022238
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040004A4 RID: 1188
		private global::Gibraltar.Server.Client.Data.SessionFileXml[] filesField;

		// Token: 0x040004A5 RID: 1189
		private string idField;

		// Token: 0x040004A6 RID: 1190
		private long versionField;

		// Token: 0x040004A7 RID: 1191
		private bool singleStreamOnlyField;
	}
}
