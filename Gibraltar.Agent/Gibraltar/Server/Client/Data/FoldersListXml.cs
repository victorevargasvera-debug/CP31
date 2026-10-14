using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000151 RID: 337
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class FoldersListXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000E1B RID: 3611 RVA: 0x00023D78 File Offset: 0x00021F78
		public FoldersListXml()
		{
			this.versionField = 0L;
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00023D88 File Offset: 0x00021F88
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00023D90 File Offset: 0x00021F90
		[global::System.Xml.Serialization.XmlArrayItem("folder", IsNullable = false)]
		public global::Gibraltar.Server.Client.Data.FolderXml[] folders
		{
			get
			{
				return this.foldersField;
			}
			set
			{
				this.foldersField = value;
				this.RaisePropertyChanged("folders");
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00023DA4 File Offset: 0x00021FA4
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00023DAC File Offset: 0x00021FAC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
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

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06000E20 RID: 3616 RVA: 0x00023DC0 File Offset: 0x00021FC0
		// (remove) Token: 0x06000E21 RID: 3617 RVA: 0x00023DFC File Offset: 0x00021FFC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E22 RID: 3618 RVA: 0x00023E38 File Offset: 0x00022038
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400049E RID: 1182
		private global::Gibraltar.Server.Client.Data.FolderXml[] foldersField;

		// Token: 0x0400049F RID: 1183
		private long versionField;
	}
}
