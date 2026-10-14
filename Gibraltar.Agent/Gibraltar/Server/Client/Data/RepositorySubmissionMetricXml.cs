using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200013C RID: 316
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class RepositorySubmissionMetricXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00022754 File Offset: 0x00020954
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x0002275C File Offset: 0x0002095C
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

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00022770 File Offset: 0x00020970
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00022778 File Offset: 0x00020978
		[global::System.Xml.Serialization.XmlAttribute(DataType = "date")]
		public global::System.DateTime date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("date");
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0002278C File Offset: 0x0002098C
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00022794 File Offset: 0x00020994
		[global::System.Xml.Serialization.XmlAttribute]
		public int sessions
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

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x000227A8 File Offset: 0x000209A8
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x000227B0 File Offset: 0x000209B0
		[global::System.Xml.Serialization.XmlAttribute]
		public int criticalSessions
		{
			get
			{
				return this.criticalSessionsField;
			}
			set
			{
				this.criticalSessionsField = value;
				this.RaisePropertyChanged("criticalSessions");
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x000227C4 File Offset: 0x000209C4
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x000227CC File Offset: 0x000209CC
		[global::System.Xml.Serialization.XmlAttribute]
		public int errorSessions
		{
			get
			{
				return this.errorSessionsField;
			}
			set
			{
				this.errorSessionsField = value;
				this.RaisePropertyChanged("errorSessions");
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x000227E0 File Offset: 0x000209E0
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x000227E8 File Offset: 0x000209E8
		[global::System.Xml.Serialization.XmlAttribute]
		public int uniqueHosts
		{
			get
			{
				return this.uniqueHostsField;
			}
			set
			{
				this.uniqueHostsField = value;
				this.RaisePropertyChanged("uniqueHosts");
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x000227FC File Offset: 0x000209FC
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00022804 File Offset: 0x00020A04
		[global::System.Xml.Serialization.XmlAttribute]
		public long bytesReceived
		{
			get
			{
				return this.bytesReceivedField;
			}
			set
			{
				this.bytesReceivedField = value;
				this.RaisePropertyChanged("bytesReceived");
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06000D01 RID: 3329 RVA: 0x00022818 File Offset: 0x00020A18
		// (remove) Token: 0x06000D02 RID: 3330 RVA: 0x00022854 File Offset: 0x00020A54
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000D03 RID: 3331 RVA: 0x00022890 File Offset: 0x00020A90
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040003F0 RID: 1008
		private string idField;

		// Token: 0x040003F1 RID: 1009
		private global::System.DateTime dateField;

		// Token: 0x040003F2 RID: 1010
		private int sessionsField;

		// Token: 0x040003F3 RID: 1011
		private int criticalSessionsField;

		// Token: 0x040003F4 RID: 1012
		private int errorSessionsField;

		// Token: 0x040003F5 RID: 1013
		private int uniqueHostsField;

		// Token: 0x040003F6 RID: 1014
		private long bytesReceivedField;
	}
}
