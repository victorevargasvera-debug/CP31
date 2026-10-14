using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000155 RID: 341
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd", IsNullable = false)]
	[global::System.Serializable]
	internal class RepositorySubmissionMetricsXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00024150 File Offset: 0x00022350
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x00024158 File Offset: 0x00022358
		[global::System.Xml.Serialization.XmlElement("metric")]
		public global::Gibraltar.Server.Client.Data.RepositorySubmissionMetricXml[] metric
		{
			get
			{
				return this.metricField;
			}
			set
			{
				this.metricField = value;
				this.RaisePropertyChanged("metric");
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06000E41 RID: 3649 RVA: 0x0002416C File Offset: 0x0002236C
		// (remove) Token: 0x06000E42 RID: 3650 RVA: 0x000241A8 File Offset: 0x000223A8
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000E43 RID: 3651 RVA: 0x000241E4 File Offset: 0x000223E4
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040004AC RID: 1196
		private global::Gibraltar.Server.Client.Data.RepositorySubmissionMetricXml[] metricField;
	}
}
