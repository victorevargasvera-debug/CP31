using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000138 RID: 312
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class HubConfigurationXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0002215C File Offset: 0x0002035C
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00022164 File Offset: 0x00020364
		public global::Gibraltar.Server.Client.Data.DateTimeOffsetXml expirationDt
		{
			get
			{
				return this.expirationDtField;
			}
			set
			{
				this.expirationDtField = value;
				this.RaisePropertyChanged("expirationDt");
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00022178 File Offset: 0x00020378
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00022180 File Offset: 0x00020380
		public global::Gibraltar.Server.Client.Data.RepositoryMailboxXml mailbox
		{
			get
			{
				return this.mailboxField;
			}
			set
			{
				this.mailboxField = value;
				this.RaisePropertyChanged("mailbox");
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00022194 File Offset: 0x00020394
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x0002219C File Offset: 0x0002039C
		[global::System.Xml.Serialization.XmlArrayItem("clientRepository", IsNullable = false)]
		public global::Gibraltar.Server.Client.Data.ClientRepositoryXml[] clientRepositories
		{
			get
			{
				return this.clientRepositoriesField;
			}
			set
			{
				this.clientRepositoriesField = value;
				this.RaisePropertyChanged("clientRepositories");
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x000221B0 File Offset: 0x000203B0
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x000221B8 File Offset: 0x000203B8
		public string publicKey
		{
			get
			{
				return this.publicKeyField;
			}
			set
			{
				this.publicKeyField = value;
				this.RaisePropertyChanged("publicKey");
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x000221CC File Offset: 0x000203CC
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x000221D4 File Offset: 0x000203D4
		public global::Gibraltar.Server.Client.Data.LiveStreamServerXml liveStream
		{
			get
			{
				return this.liveStreamField;
			}
			set
			{
				this.liveStreamField = value;
				this.RaisePropertyChanged("liveStream");
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x000221E8 File Offset: 0x000203E8
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x000221F0 File Offset: 0x000203F0
		[global::System.Xml.Serialization.XmlAttribute]
		public bool redirectRequested
		{
			get
			{
				return this.redirectRequestedField;
			}
			set
			{
				this.redirectRequestedField = value;
				this.RaisePropertyChanged("redirectRequested");
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00022204 File Offset: 0x00020404
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x0002220C File Offset: 0x0002040C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Gibraltar.Server.Client.Data.HubStatusXml status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				this.RaisePropertyChanged("status");
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00022220 File Offset: 0x00020420
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00022228 File Offset: 0x00020428
		[global::System.Xml.Serialization.XmlAttribute]
		public int timeToLive
		{
			get
			{
				return this.timeToLiveField;
			}
			set
			{
				this.timeToLiveField = value;
				this.RaisePropertyChanged("timeToLive");
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0002223C File Offset: 0x0002043C
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00022244 File Offset: 0x00020444
		[global::System.Xml.Serialization.XmlAttribute]
		public string protocolVersion
		{
			get
			{
				return this.protocolVersionField;
			}
			set
			{
				this.protocolVersionField = value;
				this.RaisePropertyChanged("protocolVersion");
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00022258 File Offset: 0x00020458
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x00022260 File Offset: 0x00020460
		[global::System.Xml.Serialization.XmlAttribute]
		public bool redirectUseGibraltarSds
		{
			get
			{
				return this.redirectUseGibraltarSdsField;
			}
			set
			{
				this.redirectUseGibraltarSdsField = value;
				this.RaisePropertyChanged("redirectUseGibraltarSds");
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00022274 File Offset: 0x00020474
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x0002227C File Offset: 0x0002047C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool redirectUseGibraltarSdsSpecified
		{
			get
			{
				return this.redirectUseGibraltarSdsFieldSpecified;
			}
			set
			{
				this.redirectUseGibraltarSdsFieldSpecified = value;
				this.RaisePropertyChanged("redirectUseGibraltarSdsSpecified");
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00022290 File Offset: 0x00020490
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x00022298 File Offset: 0x00020498
		[global::System.Xml.Serialization.XmlAttribute]
		public string redirectCustomerName
		{
			get
			{
				return this.redirectCustomerNameField;
			}
			set
			{
				this.redirectCustomerNameField = value;
				this.RaisePropertyChanged("redirectCustomerName");
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x000222AC File Offset: 0x000204AC
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x000222B4 File Offset: 0x000204B4
		[global::System.Xml.Serialization.XmlAttribute]
		public string redirectHostName
		{
			get
			{
				return this.redirectHostNameField;
			}
			set
			{
				this.redirectHostNameField = value;
				this.RaisePropertyChanged("redirectHostName");
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x000222C8 File Offset: 0x000204C8
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x000222D0 File Offset: 0x000204D0
		[global::System.Xml.Serialization.XmlAttribute]
		public int redirectPort
		{
			get
			{
				return this.redirectPortField;
			}
			set
			{
				this.redirectPortField = value;
				this.RaisePropertyChanged("redirectPort");
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000222E4 File Offset: 0x000204E4
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x000222EC File Offset: 0x000204EC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool redirectPortSpecified
		{
			get
			{
				return this.redirectPortFieldSpecified;
			}
			set
			{
				this.redirectPortFieldSpecified = value;
				this.RaisePropertyChanged("redirectPortSpecified");
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00022300 File Offset: 0x00020500
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x00022308 File Offset: 0x00020508
		[global::System.Xml.Serialization.XmlAttribute]
		public bool redirectUseSsl
		{
			get
			{
				return this.redirectUseSslField;
			}
			set
			{
				this.redirectUseSslField = value;
				this.RaisePropertyChanged("redirectUseSsl");
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0002231C File Offset: 0x0002051C
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x00022324 File Offset: 0x00020524
		[global::System.Xml.Serialization.XmlIgnore]
		public bool redirectUseSslSpecified
		{
			get
			{
				return this.redirectUseSslFieldSpecified;
			}
			set
			{
				this.redirectUseSslFieldSpecified = value;
				this.RaisePropertyChanged("redirectUseSslSpecified");
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00022338 File Offset: 0x00020538
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00022340 File Offset: 0x00020540
		[global::System.Xml.Serialization.XmlAttribute]
		public string redirectApplicationBaseDirectory
		{
			get
			{
				return this.redirectApplicationBaseDirectoryField;
			}
			set
			{
				this.redirectApplicationBaseDirectoryField = value;
				this.RaisePropertyChanged("redirectApplicationBaseDirectory");
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00022354 File Offset: 0x00020554
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x0002235C File Offset: 0x0002055C
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

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06000CCD RID: 3277 RVA: 0x00022370 File Offset: 0x00020570
		// (remove) Token: 0x06000CCE RID: 3278 RVA: 0x000223AC File Offset: 0x000205AC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000CCF RID: 3279 RVA: 0x000223E8 File Offset: 0x000205E8
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040003CE RID: 974
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml expirationDtField;

		// Token: 0x040003CF RID: 975
		private global::Gibraltar.Server.Client.Data.RepositoryMailboxXml mailboxField;

		// Token: 0x040003D0 RID: 976
		private global::Gibraltar.Server.Client.Data.ClientRepositoryXml[] clientRepositoriesField;

		// Token: 0x040003D1 RID: 977
		private string publicKeyField;

		// Token: 0x040003D2 RID: 978
		private global::Gibraltar.Server.Client.Data.LiveStreamServerXml liveStreamField;

		// Token: 0x040003D3 RID: 979
		private bool redirectRequestedField;

		// Token: 0x040003D4 RID: 980
		private global::Gibraltar.Server.Client.Data.HubStatusXml statusField;

		// Token: 0x040003D5 RID: 981
		private int timeToLiveField;

		// Token: 0x040003D6 RID: 982
		private string protocolVersionField;

		// Token: 0x040003D7 RID: 983
		private bool redirectUseGibraltarSdsField;

		// Token: 0x040003D8 RID: 984
		private bool redirectUseGibraltarSdsFieldSpecified;

		// Token: 0x040003D9 RID: 985
		private string redirectCustomerNameField;

		// Token: 0x040003DA RID: 986
		private string redirectHostNameField;

		// Token: 0x040003DB RID: 987
		private int redirectPortField;

		// Token: 0x040003DC RID: 988
		private bool redirectPortFieldSpecified;

		// Token: 0x040003DD RID: 989
		private bool redirectUseSslField;

		// Token: 0x040003DE RID: 990
		private bool redirectUseSslFieldSpecified;

		// Token: 0x040003DF RID: 991
		private string redirectApplicationBaseDirectoryField;

		// Token: 0x040003E0 RID: 992
		private string idField;
	}
}
