using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005F6 RID: 1526
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_DataBinding
	{
		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x0600430B RID: 17163 RVA: 0x0009FD16 File Offset: 0x0009DF16
		// (set) Token: 0x0600430C RID: 17164 RVA: 0x0009FD1E File Offset: 0x0009DF1E
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

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x0009FD27 File Offset: 0x0009DF27
		// (set) Token: 0x0600430E RID: 17166 RVA: 0x0009FD2F File Offset: 0x0009DF2F
		[global::System.Xml.Serialization.XmlAttribute]
		public string DataBindingName
		{
			get
			{
				return this.dataBindingNameField;
			}
			set
			{
				this.dataBindingNameField = value;
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x0600430F RID: 17167 RVA: 0x0009FD38 File Offset: 0x0009DF38
		[global::System.Xml.Serialization.XmlIgnore]
		public bool outlineSpecified
		{
			get
			{
				return this.dataBindingNameField != null;
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06004310 RID: 17168 RVA: 0x0009FD43 File Offset: 0x0009DF43
		// (set) Token: 0x06004311 RID: 17169 RVA: 0x0009FD5F File Offset: 0x0009DF5F
		[global::System.Xml.Serialization.XmlAttribute]
		public bool FileBinding
		{
			get
			{
				return this.fileBindingField != null && this.fileBindingField.Value;
			}
			set
			{
				this.fileBindingField = new bool?(value);
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x0009FD6D File Offset: 0x0009DF6D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool FileBindingSpecified
		{
			get
			{
				return this.fileBindingField != null;
			}
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06004313 RID: 17171 RVA: 0x0009FD7A File Offset: 0x0009DF7A
		// (set) Token: 0x06004314 RID: 17172 RVA: 0x0009FD96 File Offset: 0x0009DF96
		[global::System.Xml.Serialization.XmlAttribute]
		public uint ConnectionID
		{
			get
			{
				if (this.connectionIDField != null)
				{
					return this.connectionIDField.Value;
				}
				return 0U;
			}
			set
			{
				this.connectionIDField = new uint?(value);
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06004315 RID: 17173 RVA: 0x0009FDA4 File Offset: 0x0009DFA4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool ConnectionIDSpecified
		{
			get
			{
				return this.connectionIDField != null;
			}
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x0009FDB1 File Offset: 0x0009DFB1
		// (set) Token: 0x06004317 RID: 17175 RVA: 0x0009FDB9 File Offset: 0x0009DFB9
		[global::System.Xml.Serialization.XmlAttribute]
		public string FileBindingName
		{
			get
			{
				return this.fileBindingNameField;
			}
			set
			{
				this.fileBindingNameField = value;
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06004318 RID: 17176 RVA: 0x0009FDC2 File Offset: 0x0009DFC2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool FileBindingNameSpecified
		{
			get
			{
				return this.fileBindingNameField != null;
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06004319 RID: 17177 RVA: 0x0009FDCD File Offset: 0x0009DFCD
		// (set) Token: 0x0600431A RID: 17178 RVA: 0x0009FDD5 File Offset: 0x0009DFD5
		[global::System.Xml.Serialization.XmlAttribute]
		public uint DataBindingLoadMode
		{
			get
			{
				return this.dataBindingLoadModeField;
			}
			set
			{
				this.dataBindingLoadModeField = value;
			}
		}

		// Token: 0x04002A57 RID: 10839
		private global::System.Xml.XmlElement anyField;

		// Token: 0x04002A58 RID: 10840
		private string dataBindingNameField;

		// Token: 0x04002A59 RID: 10841
		private bool? fileBindingField;

		// Token: 0x04002A5A RID: 10842
		private uint? connectionIDField;

		// Token: 0x04002A5B RID: 10843
		private string fileBindingNameField;

		// Token: 0x04002A5C RID: 10844
		private uint dataBindingLoadModeField;
	}
}
