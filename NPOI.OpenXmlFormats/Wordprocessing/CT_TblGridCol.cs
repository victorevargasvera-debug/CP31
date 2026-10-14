using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001A5 RID: 421
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblGridCol
	{
		// Token: 0x06000FE0 RID: 4064 RVA: 0x000342F9 File Offset: 0x000324F9
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol
			{
				w = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:w"])
			};
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00034320 File Offset: 0x00032520
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:w", this.w);
			sw.Write("/>");
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00034351 File Offset: 0x00032551
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00034359 File Offset: 0x00032559
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

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00034362 File Offset: 0x00032562
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0003436A File Offset: 0x0003256A
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

		// Token: 0x04000CD5 RID: 3285
		private ulong wField;

		// Token: 0x04000CD6 RID: 3286
		private bool wFieldSpecified;
	}
}
