using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000662 RID: 1634
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Func
	{
		// Token: 0x0600460E RID: 17934 RVA: 0x000A8208 File Offset: 0x000A6408
		public static global::NPOI.OpenXmlFormats.Shared.CT_Func Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Func ct_Func = new global::NPOI.OpenXmlFormats.Shared.CT_Func();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "funcPr")
				{
					ct_Func.funcPr = global::NPOI.OpenXmlFormats.Shared.CT_FuncPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fName")
				{
					ct_Func.fName = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_Func.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Func;
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x000A82C8 File Offset: 0x000A64C8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.funcPr != null)
			{
				this.funcPr.Write(sw, "funcPr");
			}
			if (this.fName != null)
			{
				this.fName.Write(sw, "fName");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06004610 RID: 17936 RVA: 0x000A834D File Offset: 0x000A654D
		// (set) Token: 0x06004611 RID: 17937 RVA: 0x000A8355 File Offset: 0x000A6555
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_FuncPr funcPr
		{
			get
			{
				return this.funcPrField;
			}
			set
			{
				this.funcPrField = value;
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x000A835E File Offset: 0x000A655E
		// (set) Token: 0x06004613 RID: 17939 RVA: 0x000A8366 File Offset: 0x000A6566
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArg fName
		{
			get
			{
				return this.fNameField;
			}
			set
			{
				this.fNameField = value;
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x000A836F File Offset: 0x000A656F
		// (set) Token: 0x06004615 RID: 17941 RVA: 0x000A8377 File Offset: 0x000A6577
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArg e
		{
			get
			{
				return this.eField;
			}
			set
			{
				this.eField = value;
			}
		}

		// Token: 0x04002BFA RID: 11258
		private global::NPOI.OpenXmlFormats.Shared.CT_FuncPr funcPrField;

		// Token: 0x04002BFB RID: 11259
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg fNameField;

		// Token: 0x04002BFC RID: 11260
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;
	}
}
