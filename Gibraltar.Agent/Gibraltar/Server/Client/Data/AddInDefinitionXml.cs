using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x0200013B RID: 315
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class AddInDefinitionXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00022600 File Offset: 0x00020800
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00022608 File Offset: 0x00020808
		[global::System.Xml.Serialization.XmlAttribute]
		public string typeName
		{
			get
			{
				return this.typeNameField;
			}
			set
			{
				this.typeNameField = value;
				this.RaisePropertyChanged("typeName");
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0002261C File Offset: 0x0002081C
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00022624 File Offset: 0x00020824
		[global::System.Xml.Serialization.XmlAttribute]
		public bool enabled
		{
			get
			{
				return this.enabledField;
			}
			set
			{
				this.enabledField = value;
				this.RaisePropertyChanged("enabled");
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00022638 File Offset: 0x00020838
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00022640 File Offset: 0x00020840
		[global::System.Xml.Serialization.XmlAttribute]
		public string caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
				this.RaisePropertyChanged("caption");
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00022654 File Offset: 0x00020854
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x0002265C File Offset: 0x0002085C
		[global::System.Xml.Serialization.XmlAttribute]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("description");
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00022670 File Offset: 0x00020870
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00022678 File Offset: 0x00020878
		[global::System.Xml.Serialization.XmlAttribute]
		public string version
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

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0002268C File Offset: 0x0002088C
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00022694 File Offset: 0x00020894
		[global::System.Xml.Serialization.XmlAttribute]
		public string source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
				this.RaisePropertyChanged("source");
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06000CEF RID: 3311 RVA: 0x000226A8 File Offset: 0x000208A8
		// (remove) Token: 0x06000CF0 RID: 3312 RVA: 0x000226E4 File Offset: 0x000208E4
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00022720 File Offset: 0x00020920
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040003E9 RID: 1001
		private string typeNameField;

		// Token: 0x040003EA RID: 1002
		private bool enabledField;

		// Token: 0x040003EB RID: 1003
		private string captionField;

		// Token: 0x040003EC RID: 1004
		private string descriptionField;

		// Token: 0x040003ED RID: 1005
		private string versionField;

		// Token: 0x040003EE RID: 1006
		private string sourceField;
	}
}
