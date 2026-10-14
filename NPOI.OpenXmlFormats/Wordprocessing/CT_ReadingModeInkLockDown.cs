using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200019D RID: 413
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ReadingModeInkLockDown
	{
		// Token: 0x06000F85 RID: 3973 RVA: 0x000328B0 File Offset: 0x00030AB0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_ReadingModeInkLockDown Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_ReadingModeInkLockDown ct_ReadingModeInkLockDown = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_ReadingModeInkLockDown();
			if (node.Attributes["w:actualPg"] != null)
			{
				ct_ReadingModeInkLockDown.actualPg = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:actualPg"].Value, true);
			}
			ct_ReadingModeInkLockDown.w = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:w"]);
			ct_ReadingModeInkLockDown.h = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:h"]);
			ct_ReadingModeInkLockDown.fontSz = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:fontSz"]);
			return ct_ReadingModeInkLockDown;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0003295C File Offset: 0x00030B5C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:actualPg", this.actualPg.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:w", this.w);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:h", this.h);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:fontSz", this.fontSz);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000329EC File Offset: 0x00030BEC
		// (set) Token: 0x06000F88 RID: 3976 RVA: 0x000329F4 File Offset: 0x00030BF4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff actualPg
		{
			get
			{
				return this.actualPgField;
			}
			set
			{
				this.actualPgField = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x000329FD File Offset: 0x00030BFD
		// (set) Token: 0x06000F8A RID: 3978 RVA: 0x00032A05 File Offset: 0x00030C05
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

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00032A0E File Offset: 0x00030C0E
		// (set) Token: 0x06000F8C RID: 3980 RVA: 0x00032A16 File Offset: 0x00030C16
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

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00032A1F File Offset: 0x00030C1F
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x00032A27 File Offset: 0x00030C27
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string fontSz
		{
			get
			{
				return this.fontSzField;
			}
			set
			{
				this.fontSzField = value;
			}
		}

		// Token: 0x04000CA7 RID: 3239
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff actualPgField;

		// Token: 0x04000CA8 RID: 3240
		private ulong wField;

		// Token: 0x04000CA9 RID: 3241
		private ulong hField;

		// Token: 0x04000CAA RID: 3242
		private string fontSzField;
	}
}
