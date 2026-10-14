using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200013D RID: 317
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class SessionFileXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x000228C4 File Offset: 0x00020AC4
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x000228CC File Offset: 0x00020ACC
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

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x000228E0 File Offset: 0x00020AE0
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x000228E8 File Offset: 0x00020AE8
		[global::System.Xml.Serialization.XmlAttribute]
		public long sequence
		{
			get
			{
				return this.sequenceField;
			}
			set
			{
				this.sequenceField = value;
				this.RaisePropertyChanged("sequence");
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x000228FC File Offset: 0x00020AFC
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x00022904 File Offset: 0x00020B04
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

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06000D0B RID: 3339 RVA: 0x00022918 File Offset: 0x00020B18
		// (remove) Token: 0x06000D0C RID: 3340 RVA: 0x00022954 File Offset: 0x00020B54
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000D0D RID: 3341 RVA: 0x00022990 File Offset: 0x00020B90
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040003F8 RID: 1016
		private string idField;

		// Token: 0x040003F9 RID: 1017
		private long sequenceField;

		// Token: 0x040003FA RID: 1018
		private long versionField;
	}
}
