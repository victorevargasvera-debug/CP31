using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x0200035E RID: 862
	public class CT_WrapTopBottom
	{
		// Token: 0x0600220F RID: 8719 RVA: 0x00058F88 File Offset: 0x00057188
		public CT_WrapTopBottom()
		{
			this.effectExtentField = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent();
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x00058F9B File Offset: 0x0005719B
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x00058FA3 File Offset: 0x000571A3
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent effectExtent
		{
			get
			{
				return this.effectExtentField;
			}
			set
			{
				this.effectExtentField = value;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x00058FAC File Offset: 0x000571AC
		// (set) Token: 0x06002213 RID: 8723 RVA: 0x00058FB4 File Offset: 0x000571B4
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distT
		{
			get
			{
				return this.distTField;
			}
			set
			{
				this.distTField = value;
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x00058FBD File Offset: 0x000571BD
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x00058FC5 File Offset: 0x000571C5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distTSpecified
		{
			get
			{
				return this.distTFieldSpecified;
			}
			set
			{
				this.distTFieldSpecified = value;
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x00058FCE File Offset: 0x000571CE
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x00058FD6 File Offset: 0x000571D6
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distB
		{
			get
			{
				return this.distBField;
			}
			set
			{
				this.distBField = value;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x00058FDF File Offset: 0x000571DF
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x00058FE7 File Offset: 0x000571E7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distBSpecified
		{
			get
			{
				return this.distBFieldSpecified;
			}
			set
			{
				this.distBFieldSpecified = value;
			}
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00058FF0 File Offset: 0x000571F0
		internal static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapTopBottom Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapTopBottom
			{
				distB = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["distB"]),
				distT = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["distT"])
			};
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00059040 File Offset: 0x00057240
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "distT", this.distT, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "distB", this.distB, false);
			sw.Write("/>");
		}

		// Token: 0x040019FC RID: 6652
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent effectExtentField;

		// Token: 0x040019FD RID: 6653
		private uint distTField;

		// Token: 0x040019FE RID: 6654
		private bool distTFieldSpecified;

		// Token: 0x040019FF RID: 6655
		private uint distBField;

		// Token: 0x04001A00 RID: 6656
		private bool distBFieldSpecified;
	}
}
