using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000148 RID: 328
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class FolderDetailXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00023538 File Offset: 0x00021738
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x00023540 File Offset: 0x00021740
		public global::Gibraltar.Server.Client.Data.DateTimeOffsetXml updatedDt
		{
			get
			{
				return this.updatedDtField;
			}
			set
			{
				this.updatedDtField = value;
				this.RaisePropertyChanged("updatedDt");
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00023554 File Offset: 0x00021754
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x0002355C File Offset: 0x0002175C
		[global::System.Xml.Serialization.XmlArrayItem("session", IsNullable = false)]
		public global::Gibraltar.Server.Client.Data.SessionXml[] sessions
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

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x00023570 File Offset: 0x00021770
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x00023578 File Offset: 0x00021778
		[global::System.Xml.Serialization.XmlArrayItem("session", IsNullable = false)]
		public global::Gibraltar.Server.Client.Data.SessionXml[] addedSessions
		{
			get
			{
				return this.addedSessionsField;
			}
			set
			{
				this.addedSessionsField = value;
				this.RaisePropertyChanged("addedSessions");
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x0002358C File Offset: 0x0002178C
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x00023594 File Offset: 0x00021794
		[global::System.Xml.Serialization.XmlArrayItem("session", IsNullable = false)]
		public global::Gibraltar.Server.Client.Data.SessionXml[] removedSessions
		{
			get
			{
				return this.removedSessionsField;
			}
			set
			{
				this.removedSessionsField = value;
				this.RaisePropertyChanged("removedSessions");
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x000235A8 File Offset: 0x000217A8
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x000235B0 File Offset: 0x000217B0
		public string selectionCriteriaXml
		{
			get
			{
				return this.selectionCriteriaXmlField;
			}
			set
			{
				this.selectionCriteriaXmlField = value;
				this.RaisePropertyChanged("selectionCriteriaXml");
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x000235C4 File Offset: 0x000217C4
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x000235CC File Offset: 0x000217CC
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("name");
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x000235E0 File Offset: 0x000217E0
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x000235E8 File Offset: 0x000217E8
		[global::System.Xml.Serialization.XmlAttribute]
		public string parentFolderId
		{
			get
			{
				return this.parentFolderIdField;
			}
			set
			{
				this.parentFolderIdField = value;
				this.RaisePropertyChanged("parentFolderId");
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x000235FC File Offset: 0x000217FC
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00023604 File Offset: 0x00021804
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Gibraltar.Server.Client.Data.FolderTypeXml folderType
		{
			get
			{
				return this.folderTypeField;
			}
			set
			{
				this.folderTypeField = value;
				this.RaisePropertyChanged("folderType");
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00023618 File Offset: 0x00021818
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00023620 File Offset: 0x00021820
		[global::System.Xml.Serialization.XmlAttribute]
		public string updateUser
		{
			get
			{
				return this.updateUserField;
			}
			set
			{
				this.updateUserField = value;
				this.RaisePropertyChanged("updateUser");
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06000DC9 RID: 3529 RVA: 0x00023634 File Offset: 0x00021834
		// (remove) Token: 0x06000DCA RID: 3530 RVA: 0x00023670 File Offset: 0x00021870
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000DCB RID: 3531 RVA: 0x000236AC File Offset: 0x000218AC
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000466 RID: 1126
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml updatedDtField;

		// Token: 0x04000467 RID: 1127
		private global::Gibraltar.Server.Client.Data.SessionXml[] sessionsField;

		// Token: 0x04000468 RID: 1128
		private global::Gibraltar.Server.Client.Data.SessionXml[] addedSessionsField;

		// Token: 0x04000469 RID: 1129
		private global::Gibraltar.Server.Client.Data.SessionXml[] removedSessionsField;

		// Token: 0x0400046A RID: 1130
		private string selectionCriteriaXmlField;

		// Token: 0x0400046B RID: 1131
		private string nameField;

		// Token: 0x0400046C RID: 1132
		private string parentFolderIdField;

		// Token: 0x0400046D RID: 1133
		private global::Gibraltar.Server.Client.Data.FolderTypeXml folderTypeField;

		// Token: 0x0400046E RID: 1134
		private string updateUserField;
	}
}
