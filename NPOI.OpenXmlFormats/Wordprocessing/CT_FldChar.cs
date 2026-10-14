using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000092 RID: 146
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FldChar
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000B98C File Offset: 0x00009B8C
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0000B994 File Offset: 0x00009B94
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFData ffData
		{
			get
			{
				return this.ffDataField;
			}
			set
			{
				this.ffDataField = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0000B99D File Offset: 0x00009B9D
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0000B9A5 File Offset: 0x00009BA5
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text fldData
		{
			get
			{
				return this.fldDataField;
			}
			set
			{
				this.fldDataField = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000B9AE File Offset: 0x00009BAE
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0000B9B6 File Offset: 0x00009BB6
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangeNumbering numberingChange
		{
			get
			{
				return this.numberingChangeField;
			}
			set
			{
				this.numberingChangeField = value;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000B9C0 File Offset: 0x00009BC0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar ct_FldChar = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar();
			if (node.Attributes["w:fldCharType"] != null)
			{
				ct_FldChar.fldCharType = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType), node.Attributes["w:fldCharType"].Value);
			}
			if (node.Attributes["w:fldLock"] != null)
			{
				ct_FldChar.fldLock = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:fldLock"].Value, true);
			}
			if (node.Attributes["w:dirty"] != null)
			{
				ct_FldChar.dirty = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:dirty"].Value, true);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ffData")
				{
					ct_FldChar.ffDataField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFData.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fldData")
				{
					ct_FldChar.fldDataField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numberingChange")
				{
					ct_FldChar.numberingChangeField = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangeNumbering.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_FldChar;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000BB44 File Offset: 0x00009D44
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:fldCharType", this.fldCharType.ToString());
			if (this.fldLock != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:fldLock", this.fldLock.ToString());
			}
			if (this.dirty != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:dirty", this.dirty.ToString());
			}
			if (this.ffDataField == null && this.fldDataField == null && this.numberingChangeField == null)
			{
				sw.Write(string.Format("/>", nodeName));
				return;
			}
			sw.Write(">");
			if (this.ffDataField != null)
			{
				this.ffDataField.Write(sw, "ffData");
			}
			if (this.fldDataField != null)
			{
				this.fldDataField.Write(sw, "fldData");
			}
			if (this.numberingChangeField != null)
			{
				this.numberingChangeField.Write(sw, "numberingChange");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000BC60 File Offset: 0x00009E60
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x0000BC68 File Offset: 0x00009E68
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType fldCharType
		{
			get
			{
				return this.fldCharTypeField;
			}
			set
			{
				this.fldCharTypeField = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000BC71 File Offset: 0x00009E71
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0000BC79 File Offset: 0x00009E79
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff fldLock
		{
			get
			{
				return this.fldLockField;
			}
			set
			{
				this.fldLockField = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0000BC82 File Offset: 0x00009E82
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x0000BC8A File Offset: 0x00009E8A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fldLockSpecified
		{
			get
			{
				return this.fldLockFieldSpecified;
			}
			set
			{
				this.fldLockFieldSpecified = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000BC93 File Offset: 0x00009E93
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0000BC9B File Offset: 0x00009E9B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff dirty
		{
			get
			{
				return this.dirtyField;
			}
			set
			{
				this.dirtyField = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000BCA4 File Offset: 0x00009EA4
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000BCAC File Offset: 0x00009EAC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dirtySpecified
		{
			get
			{
				return this.dirtyFieldSpecified;
			}
			set
			{
				this.dirtyFieldSpecified = value;
			}
		}

		// Token: 0x04000397 RID: 919
		private object itemField;

		// Token: 0x04000398 RID: 920
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_FldCharType fldCharTypeField;

		// Token: 0x04000399 RID: 921
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff fldLockField;

		// Token: 0x0400039A RID: 922
		private bool fldLockFieldSpecified;

		// Token: 0x0400039B RID: 923
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff dirtyField;

		// Token: 0x0400039C RID: 924
		private bool dirtyFieldSpecified;

		// Token: 0x0400039D RID: 925
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFData ffDataField;

		// Token: 0x0400039E RID: 926
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text fldDataField;

		// Token: 0x0400039F RID: 927
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangeNumbering numberingChangeField;
	}
}
