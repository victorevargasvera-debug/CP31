using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x0200034C RID: 844
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot("inline", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = false)]
	[global::System.Serializable]
	public class CT_PositiveSize2D
	{
		// Token: 0x06002137 RID: 8503 RVA: 0x0005776C File Offset: 0x0005596C
		public static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D
			{
				cx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["cx"]),
				cy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["cy"])
			};
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x000577BC File Offset: 0x000559BC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cx", (double)this.cx, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cy", (double)this.cy, true);
			sw.Write("/>");
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x0005780B File Offset: 0x00055A0B
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x00057813 File Offset: 0x00055A13
		[global::System.Xml.Serialization.XmlAttribute]
		public long cx
		{
			get
			{
				return this.cxField;
			}
			set
			{
				this.cxField = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x0005781C File Offset: 0x00055A1C
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x00057824 File Offset: 0x00055A24
		[global::System.Xml.Serialization.XmlAttribute]
		public long cy
		{
			get
			{
				return this.cyField;
			}
			set
			{
				this.cyField = value;
			}
		}

		// Token: 0x0400197D RID: 6525
		private long cxField;

		// Token: 0x0400197E RID: 6526
		private long cyField;
	}
}
