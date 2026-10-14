using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005F4 RID: 1524
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Schema
	{
		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x0009FBF4 File Offset: 0x0009DDF4
		// (set) Token: 0x060042EB RID: 17131 RVA: 0x0009FBFC File Offset: 0x0009DDFC
		[global::System.Xml.Serialization.XmlAnyElement]
		public global::System.Xml.XmlElement Any
		{
			get
			{
				return this.anyField;
			}
			set
			{
				this.anyField = value;
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x0009FC05 File Offset: 0x0009DE05
		// (set) Token: 0x060042ED RID: 17133 RVA: 0x0009FC0D File Offset: 0x0009DE0D
		[global::System.Xml.Serialization.XmlAttribute]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x0009FC16 File Offset: 0x0009DE16
		// (set) Token: 0x060042EF RID: 17135 RVA: 0x0009FC1E File Offset: 0x0009DE1E
		[global::System.Xml.Serialization.XmlAttribute]
		public string SchemaRef
		{
			get
			{
				return this.schemaRefField;
			}
			set
			{
				this.schemaRefField = value;
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x0009FC27 File Offset: 0x0009DE27
		[global::System.Xml.Serialization.XmlIgnore]
		public bool SchemaRefSpecified
		{
			get
			{
				return this.schemaRefField != null;
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x060042F1 RID: 17137 RVA: 0x0009FC32 File Offset: 0x0009DE32
		// (set) Token: 0x060042F2 RID: 17138 RVA: 0x0009FC3A File Offset: 0x0009DE3A
		[global::System.Xml.Serialization.XmlAttribute]
		public string Namespace
		{
			get
			{
				return this.namespaceField;
			}
			set
			{
				this.namespaceField = value;
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060042F3 RID: 17139 RVA: 0x0009FC43 File Offset: 0x0009DE43
		[global::System.Xml.Serialization.XmlIgnore]
		public bool NamespaceSpecified
		{
			get
			{
				return this.namespaceField != null;
			}
		}

		// Token: 0x04002A48 RID: 10824
		private global::System.Xml.XmlElement anyField;

		// Token: 0x04002A49 RID: 10825
		private string idField = string.Empty;

		// Token: 0x04002A4A RID: 10826
		private string schemaRefField;

		// Token: 0x04002A4B RID: 10827
		private string namespaceField;

		// Token: 0x04002A4C RID: 10828
		public string InnerXml;
	}
}
