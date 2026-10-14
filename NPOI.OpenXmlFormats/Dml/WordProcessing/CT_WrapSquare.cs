using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x02000359 RID: 857
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_WrapSquare
	{
		// Token: 0x060021D5 RID: 8661 RVA: 0x00058CFC File Offset: 0x00056EFC
		public CT_WrapSquare()
		{
			this.effectExtentField = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent();
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00058D0F File Offset: 0x00056F0F
		public static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapSquare Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapSquare
			{
				wrapText = (global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_WrapText)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_WrapText), node.Attributes["wrapText"].Value)
			};
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00058D4C File Offset: 0x00056F4C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "wrapText", this.wrapText.ToString(), true);
			sw.Write("/>");
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x00058D95 File Offset: 0x00056F95
		// (set) Token: 0x060021D9 RID: 8665 RVA: 0x00058D9D File Offset: 0x00056F9D
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

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x00058DA6 File Offset: 0x00056FA6
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x00058DAE File Offset: 0x00056FAE
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_WrapText wrapText
		{
			get
			{
				return this.wrapTextField;
			}
			set
			{
				this.wrapTextField = value;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x00058DB7 File Offset: 0x00056FB7
		// (set) Token: 0x060021DD RID: 8669 RVA: 0x00058DBF File Offset: 0x00056FBF
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

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x00058DC8 File Offset: 0x00056FC8
		// (set) Token: 0x060021DF RID: 8671 RVA: 0x00058DD0 File Offset: 0x00056FD0
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

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x00058DD9 File Offset: 0x00056FD9
		// (set) Token: 0x060021E1 RID: 8673 RVA: 0x00058DE1 File Offset: 0x00056FE1
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

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x00058DEA File Offset: 0x00056FEA
		// (set) Token: 0x060021E3 RID: 8675 RVA: 0x00058DF2 File Offset: 0x00056FF2
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

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x00058DFB File Offset: 0x00056FFB
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x00058E03 File Offset: 0x00057003
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distL
		{
			get
			{
				return this.distLField;
			}
			set
			{
				this.distLField = value;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x00058E0C File Offset: 0x0005700C
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x00058E14 File Offset: 0x00057014
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distLSpecified
		{
			get
			{
				return this.distLFieldSpecified;
			}
			set
			{
				this.distLFieldSpecified = value;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x00058E1D File Offset: 0x0005701D
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x00058E25 File Offset: 0x00057025
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distR
		{
			get
			{
				return this.distRField;
			}
			set
			{
				this.distRField = value;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x00058E2E File Offset: 0x0005702E
		// (set) Token: 0x060021EB RID: 8683 RVA: 0x00058E36 File Offset: 0x00057036
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distRSpecified
		{
			get
			{
				return this.distRFieldSpecified;
			}
			set
			{
				this.distRFieldSpecified = value;
			}
		}

		// Token: 0x040019DD RID: 6621
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent effectExtentField;

		// Token: 0x040019DE RID: 6622
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_WrapText wrapTextField;

		// Token: 0x040019DF RID: 6623
		private uint distTField;

		// Token: 0x040019E0 RID: 6624
		private bool distTFieldSpecified;

		// Token: 0x040019E1 RID: 6625
		private uint distBField;

		// Token: 0x040019E2 RID: 6626
		private bool distBFieldSpecified;

		// Token: 0x040019E3 RID: 6627
		private uint distLField;

		// Token: 0x040019E4 RID: 6628
		private bool distLFieldSpecified;

		// Token: 0x040019E5 RID: 6629
		private uint distRField;

		// Token: 0x040019E6 RID: 6630
		private bool distRFieldSpecified;
	}
}
