using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200026D RID: 621
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextAutonumberBullet
	{
		// Token: 0x06001979 RID: 6521 RVA: 0x000459E8 File Offset: 0x00043BE8
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextAutonumberBullet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextAutonumberBullet ct_TextAutonumberBullet = new global::NPOI.OpenXmlFormats.Dml.CT_TextAutonumberBullet();
			if (node.Attributes["type"] != null)
			{
				ct_TextAutonumberBullet.type = (global::NPOI.OpenXmlFormats.Dml.ST_TextAutonumberScheme)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextAutonumberScheme), node.Attributes["type"].Value);
			}
			ct_TextAutonumberBullet.startAt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["startAt"]);
			return ct_TextAutonumberBullet;
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00045A60 File Offset: 0x00043C60
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "startAt", this.startAt);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00045ACA File Offset: 0x00043CCA
		public CT_TextAutonumberBullet()
		{
			this.startAtField = 1;
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00045AD9 File Offset: 0x00043CD9
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x00045AE1 File Offset: 0x00043CE1
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextAutonumberScheme type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x00045AEA File Offset: 0x00043CEA
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x00045AF2 File Offset: 0x00043CF2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x00045AFB File Offset: 0x00043CFB
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x00045B03 File Offset: 0x00043D03
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(1)]
		public int startAt
		{
			get
			{
				return this.startAtField;
			}
			set
			{
				this.startAtField = value;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x00045B0C File Offset: 0x00043D0C
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x00045B14 File Offset: 0x00043D14
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startAtSpecified
		{
			get
			{
				return this.startAtFieldSpecified;
			}
			set
			{
				this.startAtFieldSpecified = value;
			}
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00045B1D File Offset: 0x00043D1D
		public bool IsSetStartAt()
		{
			return this.startAtField >= 1;
		}

		// Token: 0x0400131D RID: 4893
		private global::NPOI.OpenXmlFormats.Dml.ST_TextAutonumberScheme typeField;

		// Token: 0x0400131E RID: 4894
		private bool typeFieldSpecified;

		// Token: 0x0400131F RID: 4895
		private int startAtField;

		// Token: 0x04001320 RID: 4896
		private bool startAtFieldSpecified;
	}
}
