using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200014B RID: 331
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class LiveStreamServerXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x000237FC File Offset: 0x000219FC
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x00023804 File Offset: 0x00021A04
		[global::System.Xml.Serialization.XmlAttribute]
		public int agentPort
		{
			get
			{
				return this.agentPortField;
			}
			set
			{
				this.agentPortField = value;
				this.RaisePropertyChanged("agentPort");
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00023818 File Offset: 0x00021A18
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x00023820 File Offset: 0x00021A20
		[global::System.Xml.Serialization.XmlAttribute]
		public int clientPort
		{
			get
			{
				return this.clientPortField;
			}
			set
			{
				this.clientPortField = value;
				this.RaisePropertyChanged("clientPort");
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00023834 File Offset: 0x00021A34
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x0002383C File Offset: 0x00021A3C
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

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06000DDF RID: 3551 RVA: 0x00023850 File Offset: 0x00021A50
		// (remove) Token: 0x06000DE0 RID: 3552 RVA: 0x0002388C File Offset: 0x00021A8C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000238C8 File Offset: 0x00021AC8
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000479 RID: 1145
		private int agentPortField;

		// Token: 0x0400047A RID: 1146
		private int clientPortField;

		// Token: 0x0400047B RID: 1147
		private bool useSslField;
	}
}
