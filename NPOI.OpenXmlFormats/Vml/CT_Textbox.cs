using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001E4 RID: 484
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Textbox
	{
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x0003E2C8 File Offset: 0x0003C4C8
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x0003E2D0 File Offset: 0x0003C4D0
		public string ItemXml
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x0003E2D9 File Offset: 0x0003C4D9
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x0003E2E1 File Offset: 0x0003C4E1
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
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0003E2EA File Offset: 0x0003C4EA
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x0003E2F2 File Offset: 0x0003C4F2
		[global::System.Xml.Serialization.XmlAttribute]
		public string style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x0003E2FB File Offset: 0x0003C4FB
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x0003E303 File Offset: 0x0003C503
		[global::System.Xml.Serialization.XmlAttribute]
		public string inset
		{
			get
			{
				return this.insetField;
			}
			set
			{
				this.insetField = value;
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0003E30C File Offset: 0x0003C50C
		public static global::NPOI.OpenXmlFormats.Vml.CT_Textbox Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Vml.CT_Textbox
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]),
				style = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["style"]),
				inset = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["inset"]),
				ItemXml = node.InnerXml
			};
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0003E380 File Offset: 0x0003C580
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "style", this.style);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "inset", this.inset);
			sw.Write(">");
			if (this.ItemXml != null)
			{
				sw.Write(this.ItemXml);
			}
			sw.Write(string.Format("</v:{0}>", nodeName));
		}

		// Token: 0x04000EA2 RID: 3746
		private string itemField;

		// Token: 0x04000EA3 RID: 3747
		private string idField;

		// Token: 0x04000EA4 RID: 3748
		private string styleField;

		// Token: 0x04000EA5 RID: 3749
		private string insetField;
	}
}
