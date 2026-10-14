using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000152 RID: 338
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class SessionsListXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000E23 RID: 3619 RVA: 0x00023E64 File Offset: 0x00022064
		public SessionsListXml()
		{
			this.versionField = 0L;
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x00023E74 File Offset: 0x00022074
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00023E7C File Offset: 0x0002207C
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

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00023E90 File Offset: 0x00022090
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00023E98 File Offset: 0x00022098
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

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06000E28 RID: 3624 RVA: 0x00023EAC File Offset: 0x000220AC
		// (remove) Token: 0x06000E29 RID: 3625 RVA: 0x00023EE8 File Offset: 0x000220E8
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E2A RID: 3626 RVA: 0x00023F24 File Offset: 0x00022124
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040004A1 RID: 1185
		private global::Gibraltar.Server.Client.Data.SessionXml[] sessionsField;

		// Token: 0x040004A2 RID: 1186
		private long versionField;
	}
}
