using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200021C RID: 540
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Rules
	{
		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00042240 File Offset: 0x00040440
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x00042248 File Offset: 0x00040448
		[global::System.Xml.Serialization.XmlElement("r")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_R> r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00042251 File Offset: 0x00040451
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x00042259 File Offset: 0x00040459
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

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x00042262 File Offset: 0x00040462
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00042270 File Offset: 0x00040470
		public static global::NPOI.OpenXmlFormats.Vml.Office.CT_Rules Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Office.CT_Rules ct_Rules = new global::NPOI.OpenXmlFormats.Vml.Office.CT_Rules();
			if (node.Attributes["v:ext"] != null)
			{
				ct_Rules.ext = (global::NPOI.OpenXmlFormats.Vml.ST_Ext)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_Ext), node.Attributes["v:ext"].Value);
			}
			ct_Rules.r = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_R>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "r")
				{
					ct_Rules.r.Add(global::NPOI.OpenXmlFormats.Vml.Office.CT_R.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Rules;
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00042340 File Offset: 0x00040540
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<o:{0}", nodeName));
			if (this.ext != global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v:ext", this.ext.ToString());
			}
			sw.Write(">");
			if (this.r != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Office.CT_R ct_R in this.r)
				{
					ct_R.Write(sw, "r");
				}
			}
			sw.Write(string.Format("</o:{0}>", nodeName));
		}

		// Token: 0x04001169 RID: 4457
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_R> rField;

		// Token: 0x0400116A RID: 4458
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;
	}
}
