using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000223 RID: 547
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Relation
	{
		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000429A0 File Offset: 0x00040BA0
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x000429A8 File Offset: 0x00040BA8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x000429B1 File Offset: 0x00040BB1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x000429BC File Offset: 0x00040BBC
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x000429C4 File Offset: 0x00040BC4
		[global::System.Xml.Serialization.XmlAttribute]
		public string idsrc
		{
			get
			{
				return this.idsrcField;
			}
			set
			{
				this.idsrcField = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x000429CD File Offset: 0x00040BCD
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x000429D5 File Offset: 0x00040BD5
		[global::System.Xml.Serialization.XmlAttribute]
		public string iddest
		{
			get
			{
				return this.iddestField;
			}
			set
			{
				this.iddestField = value;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x000429DE File Offset: 0x00040BDE
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x000429E6 File Offset: 0x00040BE6
		[global::System.Xml.Serialization.XmlAttribute]
		public string idcntr
		{
			get
			{
				return this.idcntrField;
			}
			set
			{
				this.idcntrField = value;
			}
		}

		// Token: 0x04001192 RID: 4498
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x04001193 RID: 4499
		private string idsrcField;

		// Token: 0x04001194 RID: 4500
		private string iddestField;

		// Token: 0x04001195 RID: 4501
		private string idcntrField;
	}
}
