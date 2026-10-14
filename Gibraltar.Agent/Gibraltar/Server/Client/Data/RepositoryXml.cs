using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000154 RID: 340
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class RepositoryXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0002406C File Offset: 0x0002226C
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00024074 File Offset: 0x00022274
		[global::System.Xml.Serialization.XmlElement("folders")]
		public global::Gibraltar.Server.Client.Data.FoldersListXml[] folders
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

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00024088 File Offset: 0x00022288
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x00024090 File Offset: 0x00022290
		[global::System.Xml.Serialization.XmlElement("sessions")]
		public global::Gibraltar.Server.Client.Data.SessionsListXml[] sessions
		{
			get
			{
				return this.sessionsField;
			}
			set
			{
				this.sessionsField = value;
				this.RaisePropertyChanged("sessions");
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06000E3B RID: 3643 RVA: 0x000240A4 File Offset: 0x000222A4
		// (remove) Token: 0x06000E3C RID: 3644 RVA: 0x000240E0 File Offset: 0x000222E0
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E3D RID: 3645 RVA: 0x0002411C File Offset: 0x0002231C
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040004A9 RID: 1193
		private global::Gibraltar.Server.Client.Data.FoldersListXml[] foldersField;

		// Token: 0x040004AA RID: 1194
		private global::Gibraltar.Server.Client.Data.SessionsListXml[] sessionsField;
	}
}
