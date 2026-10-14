using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001E5 RID: 485
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextPath
	{
		// Token: 0x06001342 RID: 4930 RVA: 0x0003E404 File Offset: 0x0003C604
		public static global::NPOI.OpenXmlFormats.Vml.CT_TextPath Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_TextPath ct_TextPath = new global::NPOI.OpenXmlFormats.Vml.CT_TextPath();
			ct_TextPath.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			ct_TextPath.style = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["style"]);
			if (node.Attributes["on"] != null)
			{
				ct_TextPath.on = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["on"]);
			}
			if (node.Attributes["fitshape"] != null)
			{
				ct_TextPath.fitshape = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["fitshape"]);
			}
			if (node.Attributes["fitpath"] != null)
			{
				ct_TextPath.fitpath = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["fitpath"]);
			}
			if (node.Attributes["trim"] != null)
			{
				ct_TextPath.trim = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["trim"]);
			}
			if (node.Attributes["xscale"] != null)
			{
				ct_TextPath.xscale = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["xscale"]);
			}
			ct_TextPath.@string = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["string"]);
			return ct_TextPath;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0003E550 File Offset: 0x0003C750
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "style", this.style);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "on", this.on);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "fitshape", this.fitshape);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "fitpath", this.fitpath);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "trim", this.trim);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "xscale", this.xscale);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "string", this.@string);
			sw.Write(">");
			sw.Write(string.Format("</v:{0}>", nodeName));
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0003E612 File Offset: 0x0003C812
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x0003E61A File Offset: 0x0003C81A
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

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x0003E623 File Offset: 0x0003C823
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x0003E62B File Offset: 0x0003C82B
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

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0003E634 File Offset: 0x0003C834
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x0003E63C File Offset: 0x0003C83C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse on
		{
			get
			{
				return this.onField;
			}
			set
			{
				this.onField = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0003E645 File Offset: 0x0003C845
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x0003E64D File Offset: 0x0003C84D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool onSpecified
		{
			get
			{
				return this.onFieldSpecified;
			}
			set
			{
				this.onFieldSpecified = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x0003E656 File Offset: 0x0003C856
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x0003E65E File Offset: 0x0003C85E
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse fitshape
		{
			get
			{
				return this.fitshapeField;
			}
			set
			{
				this.fitshapeField = value;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x0003E667 File Offset: 0x0003C867
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x0003E66F File Offset: 0x0003C86F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fitshapeSpecified
		{
			get
			{
				return this.fitshapeFieldSpecified;
			}
			set
			{
				this.fitshapeFieldSpecified = value;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x0003E678 File Offset: 0x0003C878
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x0003E680 File Offset: 0x0003C880
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse fitpath
		{
			get
			{
				return this.fitpathField;
			}
			set
			{
				this.fitpathField = value;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x0003E689 File Offset: 0x0003C889
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x0003E691 File Offset: 0x0003C891
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fitpathSpecified
		{
			get
			{
				return this.fitpathFieldSpecified;
			}
			set
			{
				this.fitpathFieldSpecified = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x0003E69A File Offset: 0x0003C89A
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x0003E6A2 File Offset: 0x0003C8A2
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse trim
		{
			get
			{
				return this.trimField;
			}
			set
			{
				this.trimField = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x0003E6AB File Offset: 0x0003C8AB
		// (set) Token: 0x06001357 RID: 4951 RVA: 0x0003E6B3 File Offset: 0x0003C8B3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool trimSpecified
		{
			get
			{
				return this.trimFieldSpecified;
			}
			set
			{
				this.trimFieldSpecified = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x0003E6BC File Offset: 0x0003C8BC
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x0003E6C4 File Offset: 0x0003C8C4
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse xscale
		{
			get
			{
				return this.xscaleField;
			}
			set
			{
				this.xscaleField = value;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x0003E6CD File Offset: 0x0003C8CD
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x0003E6D5 File Offset: 0x0003C8D5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool xscaleSpecified
		{
			get
			{
				return this.xscaleFieldSpecified;
			}
			set
			{
				this.xscaleFieldSpecified = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0003E6DE File Offset: 0x0003C8DE
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x0003E6E6 File Offset: 0x0003C8E6
		[global::System.Xml.Serialization.XmlAttribute]
		public string @string
		{
			get
			{
				return this.stringField;
			}
			set
			{
				this.stringField = value;
			}
		}

		// Token: 0x04000EA6 RID: 3750
		private string idField;

		// Token: 0x04000EA7 RID: 3751
		private string styleField;

		// Token: 0x04000EA8 RID: 3752
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse onField;

		// Token: 0x04000EA9 RID: 3753
		private bool onFieldSpecified;

		// Token: 0x04000EAA RID: 3754
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse fitshapeField;

		// Token: 0x04000EAB RID: 3755
		private bool fitshapeFieldSpecified;

		// Token: 0x04000EAC RID: 3756
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse fitpathField;

		// Token: 0x04000EAD RID: 3757
		private bool fitpathFieldSpecified;

		// Token: 0x04000EAE RID: 3758
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse trimField;

		// Token: 0x04000EAF RID: 3759
		private bool trimFieldSpecified;

		// Token: 0x04000EB0 RID: 3760
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse xscaleField;

		// Token: 0x04000EB1 RID: 3761
		private bool xscaleFieldSpecified;

		// Token: 0x04000EB2 RID: 3762
		private string stringField;
	}
}
