using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000158 RID: 344
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class RepositorySubscriptionStateXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x000244A0 File Offset: 0x000226A0
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x000244A8 File Offset: 0x000226A8
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

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000244BC File Offset: 0x000226BC
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x000244C4 File Offset: 0x000226C4
		[global::System.Xml.Serialization.XmlAttribute]
		public long sessionsVersion
		{
			get
			{
				return this.sessionsVersionField;
			}
			set
			{
				this.sessionsVersionField = value;
				this.RaisePropertyChanged("sessionsVersion");
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x000244D8 File Offset: 0x000226D8
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x000244E0 File Offset: 0x000226E0
		[global::System.Xml.Serialization.XmlAttribute]
		public long sessionsDataVersion
		{
			get
			{
				return this.sessionsDataVersionField;
			}
			set
			{
				this.sessionsDataVersionField = value;
				this.RaisePropertyChanged("sessionsDataVersion");
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06000E71 RID: 3697 RVA: 0x000244F4 File Offset: 0x000226F4
		// (remove) Token: 0x06000E72 RID: 3698 RVA: 0x00024530 File Offset: 0x00022730
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E73 RID: 3699 RVA: 0x0002456C File Offset: 0x0002276C
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040004C4 RID: 1220
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml lastContactDtField;

		// Token: 0x040004C5 RID: 1221
		private long sessionsVersionField;

		// Token: 0x040004C6 RID: 1222
		private long sessionsDataVersionField;
	}
}
