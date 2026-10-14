using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000141 RID: 321
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class SessionPropertyXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00022C34 File Offset: 0x00020E34
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00022C3C File Offset: 0x00020E3C
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x00022C50 File Offset: 0x00020E50
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00022C58 File Offset: 0x00020E58
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00022C6C File Offset: 0x00020E6C
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00022C74 File Offset: 0x00020E74
		[global::System.Xml.Serialization.XmlAttribute]
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("value");
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000D31 RID: 3377 RVA: 0x00022C88 File Offset: 0x00020E88
		// (remove) Token: 0x06000D32 RID: 3378 RVA: 0x00022CC4 File Offset: 0x00020EC4
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000D33 RID: 3379 RVA: 0x00022D00 File Offset: 0x00020F00
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400040E RID: 1038
		private string idField;

		// Token: 0x0400040F RID: 1039
		private string nameField;

		// Token: 0x04000410 RID: 1040
		private string valueField;
	}
}
