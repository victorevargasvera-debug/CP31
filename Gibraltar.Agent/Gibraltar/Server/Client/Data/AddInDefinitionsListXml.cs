using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000159 RID: 345
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot("AddInDefinitionListXml", Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class AddInDefinitionsListXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x000245A0 File Offset: 0x000227A0
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x000245A8 File Offset: 0x000227A8
		[global::System.Xml.Serialization.XmlArrayItem("definition", IsNullable = false)]
		public global::Gibraltar.Server.Client.Data.AddInDefinitionXml[] definitions
		{
			get
			{
				return this.definitionsField;
			}
			set
			{
				this.definitionsField = value;
				this.RaisePropertyChanged("definitions");
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06000E77 RID: 3703 RVA: 0x000245BC File Offset: 0x000227BC
		// (remove) Token: 0x06000E78 RID: 3704 RVA: 0x000245F8 File Offset: 0x000227F8
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E79 RID: 3705 RVA: 0x00024634 File Offset: 0x00022834
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040004C8 RID: 1224
		private global::Gibraltar.Server.Client.Data.AddInDefinitionXml[] definitionsField;
	}
}
