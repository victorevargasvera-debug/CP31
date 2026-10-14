using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005FD RID: 1533
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DdeItem
	{
		// Token: 0x06004348 RID: 17224 RVA: 0x000A02EA File Offset: 0x0009E4EA
		public CT_DdeItem()
		{
			this.nameField = "0";
			this.oleField = false;
			this.adviseField = false;
			this.preferPicField = false;
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06004349 RID: 17225 RVA: 0x000A0312 File Offset: 0x0009E512
		// (set) Token: 0x0600434A RID: 17226 RVA: 0x000A031A File Offset: 0x0009E51A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeValues values
		{
			get
			{
				return this.valuesField;
			}
			set
			{
				this.valuesField = value;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x0600434B RID: 17227 RVA: 0x000A0323 File Offset: 0x0009E523
		// (set) Token: 0x0600434C RID: 17228 RVA: 0x000A032B File Offset: 0x0009E52B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("0")]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x000A0334 File Offset: 0x0009E534
		// (set) Token: 0x0600434E RID: 17230 RVA: 0x000A033C File Offset: 0x0009E53C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ole
		{
			get
			{
				return this.oleField;
			}
			set
			{
				this.oleField = value;
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x000A0345 File Offset: 0x0009E545
		// (set) Token: 0x06004350 RID: 17232 RVA: 0x000A034D File Offset: 0x0009E54D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool advise
		{
			get
			{
				return this.adviseField;
			}
			set
			{
				this.adviseField = value;
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x000A0356 File Offset: 0x0009E556
		// (set) Token: 0x06004352 RID: 17234 RVA: 0x000A035E File Offset: 0x0009E55E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool preferPic
		{
			get
			{
				return this.preferPicField;
			}
			set
			{
				this.preferPicField = value;
			}
		}

		// Token: 0x04002A70 RID: 10864
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeValues valuesField;

		// Token: 0x04002A71 RID: 10865
		private string nameField;

		// Token: 0x04002A72 RID: 10866
		private bool oleField;

		// Token: 0x04002A73 RID: 10867
		private bool adviseField;

		// Token: 0x04002A74 RID: 10868
		private bool preferPicField;
	}
}
