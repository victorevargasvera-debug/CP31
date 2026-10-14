using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004FD RID: 1277
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellProtection
	{
		// Token: 0x0600365B RID: 13915 RVA: 0x000878B1 File Offset: 0x00085AB1
		public bool IsSetHidden()
		{
			return this.hiddenField;
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x000878B9 File Offset: 0x00085AB9
		public bool IsSetLocked()
		{
			return this.lockedField;
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x000878C4 File Offset: 0x00085AC4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellProtection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellProtection
			{
				locked = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["locked"]),
				hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"])
			};
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00087914 File Offset: 0x00085B14
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "locked", this.locked);
			if (this.hidden)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden);
			}
			sw.Write("/>");
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x0600365F RID: 13919 RVA: 0x000878B9 File Offset: 0x00085AB9
		// (set) Token: 0x06003660 RID: 13920 RVA: 0x00087967 File Offset: 0x00085B67
		[global::System.Xml.Serialization.XmlAttribute]
		public bool locked
		{
			get
			{
				return this.lockedField;
			}
			set
			{
				this.lockedField = value;
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06003661 RID: 13921 RVA: 0x000878B1 File Offset: 0x00085AB1
		// (set) Token: 0x06003662 RID: 13922 RVA: 0x00087970 File Offset: 0x00085B70
		[global::System.Xml.Serialization.XmlAttribute]
		public bool hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
			}
		}

		// Token: 0x040023D3 RID: 9171
		private bool lockedField;

		// Token: 0x040023D4 RID: 9172
		private bool hiddenField;
	}
}
