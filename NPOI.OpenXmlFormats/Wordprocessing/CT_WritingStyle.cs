using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200017B RID: 379
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_WritingStyle
	{
		// Token: 0x06000DC0 RID: 3520 RVA: 0x0002E6D4 File Offset: 0x0002C8D4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_WritingStyle Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_WritingStyle ct_WritingStyle = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_WritingStyle();
			ct_WritingStyle.lang = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:lang"]);
			ct_WritingStyle.vendorID = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:vendorID"]);
			ct_WritingStyle.dllVersion = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:dllVersion"]);
			if (node.Attributes["w:nlCheck"] != null)
			{
				ct_WritingStyle.nlCheck = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:nlCheck"].Value, true);
			}
			if (node.Attributes["w:checkStyle"] != null)
			{
				ct_WritingStyle.checkStyle = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:checkStyle"].Value, true);
			}
			ct_WritingStyle.appName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:appName"]);
			return ct_WritingStyle;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0002E7E0 File Offset: 0x0002C9E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:lang", this.lang);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:vendorID", this.vendorID);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:dllVersion", this.dllVersion);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:nlCheck", this.nlCheck.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:checkStyle", this.checkStyle.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:appName", this.appName);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0002E89C File Offset: 0x0002CA9C
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x0002E8A4 File Offset: 0x0002CAA4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				this.langField = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0002E8AD File Offset: 0x0002CAAD
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x0002E8B5 File Offset: 0x0002CAB5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string vendorID
		{
			get
			{
				return this.vendorIDField;
			}
			set
			{
				this.vendorIDField = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0002E8BE File Offset: 0x0002CABE
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x0002E8C6 File Offset: 0x0002CAC6
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string dllVersion
		{
			get
			{
				return this.dllVersionField;
			}
			set
			{
				this.dllVersionField = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x0002E8CF File Offset: 0x0002CACF
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x0002E8D7 File Offset: 0x0002CAD7
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff nlCheck
		{
			get
			{
				return this.nlCheckField;
			}
			set
			{
				this.nlCheckField = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x0002E8E0 File Offset: 0x0002CAE0
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x0002E8E8 File Offset: 0x0002CAE8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool nlCheckSpecified
		{
			get
			{
				return this.nlCheckFieldSpecified;
			}
			set
			{
				this.nlCheckFieldSpecified = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x0002E8F1 File Offset: 0x0002CAF1
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x0002E8F9 File Offset: 0x0002CAF9
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff checkStyle
		{
			get
			{
				return this.checkStyleField;
			}
			set
			{
				this.checkStyleField = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0002E902 File Offset: 0x0002CB02
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x0002E90A File Offset: 0x0002CB0A
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string appName
		{
			get
			{
				return this.appNameField;
			}
			set
			{
				this.appNameField = value;
			}
		}

		// Token: 0x04000BA4 RID: 2980
		private string langField;

		// Token: 0x04000BA5 RID: 2981
		private string vendorIDField;

		// Token: 0x04000BA6 RID: 2982
		private string dllVersionField;

		// Token: 0x04000BA7 RID: 2983
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff nlCheckField;

		// Token: 0x04000BA8 RID: 2984
		private bool nlCheckFieldSpecified;

		// Token: 0x04000BA9 RID: 2985
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff checkStyleField;

		// Token: 0x04000BAA RID: 2986
		private string appNameField;
	}
}
