using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000193 RID: 403
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SaveThroughXslt
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x00030480 File Offset: 0x0002E680
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SaveThroughXslt Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SaveThroughXslt
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]),
				solutionID = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:solutionID"])
			};
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x000304D0 File Offset: 0x0002E6D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:solutionID", this.solutionID);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x0003052C File Offset: 0x0002E72C
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x00030534 File Offset: 0x0002E734
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
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

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0003053D File Offset: 0x0002E73D
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x00030545 File Offset: 0x0002E745
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string solutionID
		{
			get
			{
				return this.solutionIDField;
			}
			set
			{
				this.solutionIDField = value;
			}
		}

		// Token: 0x04000C26 RID: 3110
		private string idField;

		// Token: 0x04000C27 RID: 3111
		private string solutionIDField;
	}
}
