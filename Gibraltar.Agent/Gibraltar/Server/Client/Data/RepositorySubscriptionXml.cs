using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000156 RID: 342
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class RepositorySubscriptionXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00024218 File Offset: 0x00022418
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00024220 File Offset: 0x00022420
		public global::Gibraltar.Server.Client.Data.DateTimeOffsetXml addedDt
		{
			get
			{
				return this.addedDtField;
			}
			set
			{
				this.addedDtField = value;
				this.RaisePropertyChanged("addedDt");
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00024234 File Offset: 0x00022434
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x0002423C File Offset: 0x0002243C
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

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00024250 File Offset: 0x00022450
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x00024258 File Offset: 0x00022458
		[global::System.Xml.Serialization.XmlAttribute]
		public string serverRepositoryId
		{
			get
			{
				return this.serverRepositoryIdField;
			}
			set
			{
				this.serverRepositoryIdField = value;
				this.RaisePropertyChanged("serverRepositoryId");
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0002426C File Offset: 0x0002246C
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x00024274 File Offset: 0x00022474
		[global::System.Xml.Serialization.XmlAttribute]
		public string computerKey
		{
			get
			{
				return this.computerKeyField;
			}
			set
			{
				this.computerKeyField = value;
				this.RaisePropertyChanged("computerKey");
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00024288 File Offset: 0x00022488
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00024290 File Offset: 0x00022490
		[global::System.Xml.Serialization.XmlAttribute]
		public bool useGibraltarSds
		{
			get
			{
				return this.useGibraltarSdsField;
			}
			set
			{
				this.useGibraltarSdsField = value;
				this.RaisePropertyChanged("useGibraltarSds");
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x000242A4 File Offset: 0x000224A4
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x000242AC File Offset: 0x000224AC
		[global::System.Xml.Serialization.XmlAttribute]
		public string customerName
		{
			get
			{
				return this.customerNameField;
			}
			set
			{
				this.customerNameField = value;
				this.RaisePropertyChanged("customerName");
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x000242C0 File Offset: 0x000224C0
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x000242C8 File Offset: 0x000224C8
		[global::System.Xml.Serialization.XmlAttribute]
		public string hostName
		{
			get
			{
				return this.hostNameField;
			}
			set
			{
				this.hostNameField = value;
				this.RaisePropertyChanged("hostName");
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x000242DC File Offset: 0x000224DC
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x000242E4 File Offset: 0x000224E4
		[global::System.Xml.Serialization.XmlAttribute]
		public int port
		{
			get
			{
				return this.portField;
			}
			set
			{
				this.portField = value;
				this.RaisePropertyChanged("port");
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x000242F8 File Offset: 0x000224F8
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00024300 File Offset: 0x00022500
		[global::System.Xml.Serialization.XmlIgnore]
		public bool portSpecified
		{
			get
			{
				return this.portFieldSpecified;
			}
			set
			{
				this.portFieldSpecified = value;
				this.RaisePropertyChanged("portSpecified");
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00024314 File Offset: 0x00022514
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x0002431C File Offset: 0x0002251C
		[global::System.Xml.Serialization.XmlAttribute]
		public bool useSsl
		{
			get
			{
				return this.useSslField;
			}
			set
			{
				this.useSslField = value;
				this.RaisePropertyChanged("useSsl");
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00024330 File Offset: 0x00022530
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00024338 File Offset: 0x00022538
		[global::System.Xml.Serialization.XmlIgnore]
		public bool useSslSpecified
		{
			get
			{
				return this.useSslFieldSpecified;
			}
			set
			{
				this.useSslFieldSpecified = value;
				this.RaisePropertyChanged("useSslSpecified");
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0002434C File Offset: 0x0002254C
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x00024354 File Offset: 0x00022554
		[global::System.Xml.Serialization.XmlAttribute]
		public string applicationBaseDirectory
		{
			get
			{
				return this.applicationBaseDirectoryField;
			}
			set
			{
				this.applicationBaseDirectoryField = value;
				this.RaisePropertyChanged("applicationBaseDirectory");
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00024368 File Offset: 0x00022568
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00024370 File Offset: 0x00022570
		[global::System.Xml.Serialization.XmlAttribute]
		public string repository
		{
			get
			{
				return this.repositoryField;
			}
			set
			{
				this.repositoryField = value;
				this.RaisePropertyChanged("repository");
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00024384 File Offset: 0x00022584
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x0002438C File Offset: 0x0002258C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Gibraltar.Server.Client.Data.SessionSynchronizationModeXml syncMode
		{
			get
			{
				return this.syncModeField;
			}
			set
			{
				this.syncModeField = value;
				this.RaisePropertyChanged("syncMode");
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x000243A0 File Offset: 0x000225A0
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x000243A8 File Offset: 0x000225A8
		[global::System.Xml.Serialization.XmlAttribute]
		public bool useApiKey
		{
			get
			{
				return this.useApiKeyField;
			}
			set
			{
				this.useApiKeyField = value;
				this.RaisePropertyChanged("useApiKey");
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x000243BC File Offset: 0x000225BC
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x000243C4 File Offset: 0x000225C4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool useApiKeySpecified
		{
			get
			{
				return this.useApiKeyFieldSpecified;
			}
			set
			{
				this.useApiKeyFieldSpecified = value;
				this.RaisePropertyChanged("useApiKeySpecified");
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x000243D8 File Offset: 0x000225D8
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x000243E0 File Offset: 0x000225E0
		[global::System.Xml.Serialization.XmlAttribute]
		public string userName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
				this.RaisePropertyChanged("userName");
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06000E67 RID: 3687 RVA: 0x000243F4 File Offset: 0x000225F4
		// (remove) Token: 0x06000E68 RID: 3688 RVA: 0x00024430 File Offset: 0x00022630
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E69 RID: 3689 RVA: 0x0002446C File Offset: 0x0002266C
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040004AE RID: 1198
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml addedDtField;

		// Token: 0x040004AF RID: 1199
		private string idField;

		// Token: 0x040004B0 RID: 1200
		private string serverRepositoryIdField;

		// Token: 0x040004B1 RID: 1201
		private string computerKeyField;

		// Token: 0x040004B2 RID: 1202
		private bool useGibraltarSdsField;

		// Token: 0x040004B3 RID: 1203
		private string customerNameField;

		// Token: 0x040004B4 RID: 1204
		private string hostNameField;

		// Token: 0x040004B5 RID: 1205
		private int portField;

		// Token: 0x040004B6 RID: 1206
		private bool portFieldSpecified;

		// Token: 0x040004B7 RID: 1207
		private bool useSslField;

		// Token: 0x040004B8 RID: 1208
		private bool useSslFieldSpecified;

		// Token: 0x040004B9 RID: 1209
		private string applicationBaseDirectoryField;

		// Token: 0x040004BA RID: 1210
		private string repositoryField;

		// Token: 0x040004BB RID: 1211
		private global::Gibraltar.Server.Client.Data.SessionSynchronizationModeXml syncModeField;

		// Token: 0x040004BC RID: 1212
		private bool useApiKeyField;

		// Token: 0x040004BD RID: 1213
		private bool useApiKeyFieldSpecified;

		// Token: 0x040004BE RID: 1214
		private string userNameField;
	}
}
