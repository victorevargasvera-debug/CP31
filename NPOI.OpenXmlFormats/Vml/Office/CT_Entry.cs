using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200021B RID: 539
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Entry
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x0004211D File Offset: 0x0004031D
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x0004212A File Offset: 0x0004032A
		[global::System.Xml.Serialization.XmlAttribute]
		public int @new
		{
			get
			{
				return this.newField.Value;
			}
			set
			{
				this.newField = new int?(value);
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00042138 File Offset: 0x00040338
		[global::System.Xml.Serialization.XmlIgnore]
		public bool newSpecified
		{
			get
			{
				return this.newField != null;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x00042145 File Offset: 0x00040345
		// (set) Token: 0x0600162C RID: 5676 RVA: 0x00042152 File Offset: 0x00040352
		[global::System.Xml.Serialization.XmlAttribute]
		public int old
		{
			get
			{
				return this.oldField.Value;
			}
			set
			{
				this.oldField = new int?(value);
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x00042160 File Offset: 0x00040360
		[global::System.Xml.Serialization.XmlIgnore]
		public bool oldSpecified
		{
			get
			{
				return this.oldField != null;
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00042170 File Offset: 0x00040370
		public static global::NPOI.OpenXmlFormats.Vml.Office.CT_Entry Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Office.CT_Entry ct_Entry = new global::NPOI.OpenXmlFormats.Vml.Office.CT_Entry();
			if (node.Attributes["new"] != null)
			{
				ct_Entry.@new = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["new"]);
			}
			if (node.Attributes["old"] != null)
			{
				ct_Entry.old = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["old"]);
			}
			return ct_Entry;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000421E4 File Offset: 0x000403E4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<o:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "new", this.@new);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "old", this.old);
			sw.Write(">");
			sw.Write(string.Format("</o:{0}>", nodeName));
		}

		// Token: 0x04001167 RID: 4455
		private int? newField;

		// Token: 0x04001168 RID: 4456
		private int? oldField;
	}
}
