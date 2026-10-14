using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x02000350 RID: 848
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EffectExtent
	{
		// Token: 0x06002177 RID: 8567 RVA: 0x00057FE4 File Offset: 0x000561E4
		public static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent
			{
				l = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["l"]),
				t = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["t"]),
				r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["r"]),
				b = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["b"])
			};
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00058068 File Offset: 0x00056268
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "l", (double)this.l, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "t", (double)this.t, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", (double)this.r, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "b", (double)this.b, true);
			sw.Write("/>");
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000580DD File Offset: 0x000562DD
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x000580E5 File Offset: 0x000562E5
		[global::System.Xml.Serialization.XmlAttribute]
		public long l
		{
			get
			{
				return this.lField;
			}
			set
			{
				this.lField = value;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x000580EE File Offset: 0x000562EE
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x000580F6 File Offset: 0x000562F6
		[global::System.Xml.Serialization.XmlAttribute]
		public long t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x000580FF File Offset: 0x000562FF
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x00058107 File Offset: 0x00056307
		[global::System.Xml.Serialization.XmlAttribute]
		public long r
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

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x00058110 File Offset: 0x00056310
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x00058118 File Offset: 0x00056318
		[global::System.Xml.Serialization.XmlAttribute]
		public long b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
			}
		}

		// Token: 0x04001995 RID: 6549
		private long lField;

		// Token: 0x04001996 RID: 6550
		private long tField;

		// Token: 0x04001997 RID: 6551
		private long rField;

		// Token: 0x04001998 RID: 6552
		private long bField;
	}
}
