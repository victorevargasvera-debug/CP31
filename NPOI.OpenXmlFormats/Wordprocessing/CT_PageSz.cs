using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000C3 RID: 195
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PageSz
	{
		// Token: 0x06000587 RID: 1415 RVA: 0x0000F750 File Offset: 0x0000D950
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageSz Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageSz ct_PageSz = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageSz();
			ct_PageSz.w = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:w"]);
			ct_PageSz.h = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:h"]);
			if (node.Attributes["w:orient"] != null)
			{
				ct_PageSz.orient = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageOrientation)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageOrientation), node.Attributes["w:orient"].Value);
			}
			ct_PageSz.code = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:code"]);
			return ct_PageSz;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:w", this.w);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:h", this.h);
			if (this.orientField != global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageOrientation.portrait)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:orient", this.orient.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:code", this.code);
			sw.Write("/>");
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0000F883 File Offset: 0x0000DA83
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0000F88B File Offset: 0x0000DA8B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0000F894 File Offset: 0x0000DA94
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0000F89C File Offset: 0x0000DA9C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool wSpecified
		{
			get
			{
				return this.wFieldSpecified;
			}
			set
			{
				this.wFieldSpecified = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0000F8A5 File Offset: 0x0000DAA5
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0000F8AD File Offset: 0x0000DAAD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong h
		{
			get
			{
				return this.hField;
			}
			set
			{
				this.hField = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0000F8B6 File Offset: 0x0000DAB6
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0000F8BE File Offset: 0x0000DABE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hSpecified
		{
			get
			{
				return this.hFieldSpecified;
			}
			set
			{
				this.hFieldSpecified = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0000F8C7 File Offset: 0x0000DAC7
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0000F8CF File Offset: 0x0000DACF
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageOrientation orient
		{
			get
			{
				return this.orientField;
			}
			set
			{
				this.orientField = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool orientSpecified
		{
			get
			{
				return this.orientFieldSpecified;
			}
			set
			{
				this.orientFieldSpecified = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0000F8E9 File Offset: 0x0000DAE9
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0000F8F1 File Offset: 0x0000DAF1
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
			}
		}

		// Token: 0x040004BC RID: 1212
		private ulong wField;

		// Token: 0x040004BD RID: 1213
		private bool wFieldSpecified;

		// Token: 0x040004BE RID: 1214
		private ulong hField;

		// Token: 0x040004BF RID: 1215
		private bool hFieldSpecified;

		// Token: 0x040004C0 RID: 1216
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageOrientation orientField;

		// Token: 0x040004C1 RID: 1217
		private bool orientFieldSpecified;

		// Token: 0x040004C2 RID: 1218
		private string codeField;
	}
}
