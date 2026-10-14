using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000139 RID: 313
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class DateTimeOffsetXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x0002241C File Offset: 0x0002061C
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x00022424 File Offset: 0x00020624
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.DateTime DateTime
		{
			get
			{
				return this.dateTimeField;
			}
			set
			{
				this.dateTimeField = value;
				this.RaisePropertyChanged("DateTime");
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00022438 File Offset: 0x00020638
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00022440 File Offset: 0x00020640
		[global::System.Xml.Serialization.XmlAttribute]
		public int Offset
		{
			get
			{
				return this.offsetField;
			}
			set
			{
				this.offsetField = value;
				this.RaisePropertyChanged("Offset");
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000CD5 RID: 3285 RVA: 0x00022454 File Offset: 0x00020654
		// (remove) Token: 0x06000CD6 RID: 3286 RVA: 0x00022490 File Offset: 0x00020690
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000224CC File Offset: 0x000206CC
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040003E2 RID: 994
		private global::System.DateTime dateTimeField;

		// Token: 0x040003E3 RID: 995
		private int offsetField;
	}
}
