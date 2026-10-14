using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001D6 RID: 470
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Serializable]
	public class CT_F
	{
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x0003C4F8 File Offset: 0x0003A6F8
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x0003C500 File Offset: 0x0003A700
		[global::System.Xml.Serialization.XmlAttribute]
		public string eqn
		{
			get
			{
				return this.eqnField;
			}
			set
			{
				this.eqnField = value;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x0003C509 File Offset: 0x0003A709
		[global::System.Xml.Serialization.XmlIgnore]
		public bool eqnSpecified
		{
			get
			{
				return this.eqnField != null;
			}
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0003C514 File Offset: 0x0003A714
		public static global::NPOI.OpenXmlFormats.Vml.CT_F Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Vml.CT_F
			{
				eqn = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["eqn"])
			};
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0003C53B File Offset: 0x0003A73B
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "eqn", this.eqn);
			sw.Write("/>");
		}

		// Token: 0x04000E0F RID: 3599
		private string eqnField;
	}
}
