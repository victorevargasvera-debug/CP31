using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200002A RID: 42
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DbPr
	{
		// Token: 0x06000192 RID: 402 RVA: 0x0000359A File Offset: 0x0000179A
		public CT_DbPr()
		{
			this.commandTypeField = 2U;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000035A9 File Offset: 0x000017A9
		// (set) Token: 0x06000194 RID: 404 RVA: 0x000035B1 File Offset: 0x000017B1
		[global::System.Xml.Serialization.XmlAttribute]
		public string connection
		{
			get
			{
				return this.connectionField;
			}
			set
			{
				this.connectionField = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000035BA File Offset: 0x000017BA
		// (set) Token: 0x06000196 RID: 406 RVA: 0x000035C2 File Offset: 0x000017C2
		[global::System.Xml.Serialization.XmlAttribute]
		public string command
		{
			get
			{
				return this.commandField;
			}
			set
			{
				this.commandField = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000035CB File Offset: 0x000017CB
		// (set) Token: 0x06000198 RID: 408 RVA: 0x000035D3 File Offset: 0x000017D3
		[global::System.Xml.Serialization.XmlAttribute]
		public string serverCommand
		{
			get
			{
				return this.serverCommandField;
			}
			set
			{
				this.serverCommandField = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000035DC File Offset: 0x000017DC
		// (set) Token: 0x0600019A RID: 410 RVA: 0x000035E4 File Offset: 0x000017E4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "2")]
		public uint commandType
		{
			get
			{
				return this.commandTypeField;
			}
			set
			{
				this.commandTypeField = value;
			}
		}

		// Token: 0x04000137 RID: 311
		private string connectionField;

		// Token: 0x04000138 RID: 312
		private string commandField;

		// Token: 0x04000139 RID: 313
		private string serverCommandField;

		// Token: 0x0400013A RID: 314
		private uint commandTypeField;
	}
}
