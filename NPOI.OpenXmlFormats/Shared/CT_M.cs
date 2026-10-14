using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200066E RID: 1646
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_M
	{
		// Token: 0x0600466C RID: 18028 RVA: 0x000A9138 File Offset: 0x000A7338
		public static global::NPOI.OpenXmlFormats.Shared.CT_M Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_M ct_M = new global::NPOI.OpenXmlFormats.Shared.CT_M();
			ct_M.mr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "mPr")
				{
					ct_M.mPr = global::NPOI.OpenXmlFormats.Shared.CT_MPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mr")
				{
					ct_M.mr.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_M;
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x000A91E8 File Offset: 0x000A73E8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.mPr != null)
			{
				this.mPr.Write(sw, "mPr");
			}
			if (this.mr != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Shared.CT_OMathArg ct_OMathArg in this.mr)
				{
					ct_OMathArg.Write(sw, "mr");
				}
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x000A928C File Offset: 0x000A748C
		// (set) Token: 0x0600466F RID: 18031 RVA: 0x000A9294 File Offset: 0x000A7494
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_MPr mPr
		{
			get
			{
				return this.mPrField;
			}
			set
			{
				this.mPrField = value;
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06004670 RID: 18032 RVA: 0x000A929D File Offset: 0x000A749D
		// (set) Token: 0x06004671 RID: 18033 RVA: 0x000A92A5 File Offset: 0x000A74A5
		[global::System.Xml.Serialization.XmlArray(Order = 1)]
		[global::System.Xml.Serialization.XmlArrayItem("e", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathArg), IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg> mr
		{
			get
			{
				return this.mrField;
			}
			set
			{
				this.mrField = value;
			}
		}

		// Token: 0x04002C19 RID: 11289
		private global::NPOI.OpenXmlFormats.Shared.CT_MPr mPrField;

		// Token: 0x04002C1A RID: 11290
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg> mrField;
	}
}
