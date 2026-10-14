using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000585 RID: 1413
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellFormula
	{
		// Token: 0x06003DE7 RID: 15847 RVA: 0x000963E0 File Offset: 0x000945E0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula ct_CellFormula = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula();
			if (node.Attributes["t"] != null)
			{
				ct_CellFormula.t = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType), node.Attributes["t"].Value);
			}
			else
			{
				ct_CellFormula.t = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType.normal;
			}
			ct_CellFormula.aca = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["aca"]);
			ct_CellFormula.@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]);
			ct_CellFormula.dt2D = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dt2D"]);
			ct_CellFormula.dtr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dtr"]);
			ct_CellFormula.del1 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["del1"]);
			ct_CellFormula.del2 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["del2"]);
			ct_CellFormula.r1 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r1"]);
			ct_CellFormula.r2 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r2"]);
			ct_CellFormula.ca = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["ca"]);
			ct_CellFormula.si = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["si"]);
			ct_CellFormula.bx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["bx"]);
			ct_CellFormula.Value = node.InnerText.Replace("\r", "");
			return ct_CellFormula;
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x00096588 File Offset: 0x00094788
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.t != global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType.normal)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "t", this.t.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "aca", this.aca, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dt2D", this.dt2D, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dtr", this.dtr, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "del1", this.del1, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "del2", this.del2, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r1", this.r1);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r2", this.r2);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ca", this.ca, false);
			if (this.t != global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType.normal)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "si", this.si, true);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bx", this.bx, false);
			if (!string.IsNullOrEmpty(this.valueField))
			{
				sw.Write(">");
				sw.Write(global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.valueField).Replace("&quot;", "\""));
				sw.Write(string.Format("</{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x000966ED File Offset: 0x000948ED
		public CT_CellFormula()
		{
			this.tField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType.normal;
			this.acaField = false;
			this.dt2DField = false;
			this.dtrField = false;
			this.del1Field = false;
			this.del2Field = false;
			this.caField = false;
			this.bxField = false;
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x0009672D File Offset: 0x0009492D
		public bool isSetRef()
		{
			return this.refField != null;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x00096738 File Offset: 0x00094938
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula Copy()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula
			{
				acaField = this.acaField,
				bxField = this.bxField,
				caField = this.caField,
				del1Field = this.del1Field,
				del2Field = this.del2Field,
				dt2DField = this.dt2DField,
				dtrField = this.dtrField,
				r1Field = this.r1Field,
				r2Field = this.r2Field,
				refField = this.refField,
				siField = this.siField,
				siFieldSpecified = this.siFieldSpecified,
				tField = this.tField,
				valueField = this.valueField
			};
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06003DEC RID: 15852 RVA: 0x000967F2 File Offset: 0x000949F2
		// (set) Token: 0x06003DED RID: 15853 RVA: 0x000967FA File Offset: 0x000949FA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType.normal)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType t
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

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06003DEE RID: 15854 RVA: 0x00096803 File Offset: 0x00094A03
		// (set) Token: 0x06003DEF RID: 15855 RVA: 0x0009680B File Offset: 0x00094A0B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool aca
		{
			get
			{
				return this.acaField;
			}
			set
			{
				this.acaField = value;
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x00096814 File Offset: 0x00094A14
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x0009681C File Offset: 0x00094A1C
		[global::System.Xml.Serialization.XmlAttribute]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x00096825 File Offset: 0x00094A25
		// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x0009682D File Offset: 0x00094A2D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool dt2D
		{
			get
			{
				return this.dt2DField;
			}
			set
			{
				this.dt2DField = value;
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06003DF4 RID: 15860 RVA: 0x00096836 File Offset: 0x00094A36
		// (set) Token: 0x06003DF5 RID: 15861 RVA: 0x0009683E File Offset: 0x00094A3E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool dtr
		{
			get
			{
				return this.dtrField;
			}
			set
			{
				this.dtrField = value;
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x00096847 File Offset: 0x00094A47
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x0009684F File Offset: 0x00094A4F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool del1
		{
			get
			{
				return this.del1Field;
			}
			set
			{
				this.del1Field = value;
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06003DF8 RID: 15864 RVA: 0x00096858 File Offset: 0x00094A58
		// (set) Token: 0x06003DF9 RID: 15865 RVA: 0x00096860 File Offset: 0x00094A60
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool del2
		{
			get
			{
				return this.del2Field;
			}
			set
			{
				this.del2Field = value;
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06003DFA RID: 15866 RVA: 0x00096869 File Offset: 0x00094A69
		// (set) Token: 0x06003DFB RID: 15867 RVA: 0x00096871 File Offset: 0x00094A71
		[global::System.Xml.Serialization.XmlAttribute]
		public string r1
		{
			get
			{
				return this.r1Field;
			}
			set
			{
				this.r1Field = value;
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06003DFC RID: 15868 RVA: 0x0009687A File Offset: 0x00094A7A
		// (set) Token: 0x06003DFD RID: 15869 RVA: 0x00096882 File Offset: 0x00094A82
		[global::System.Xml.Serialization.XmlAttribute]
		public string r2
		{
			get
			{
				return this.r2Field;
			}
			set
			{
				this.r2Field = value;
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x0009688B File Offset: 0x00094A8B
		// (set) Token: 0x06003DFF RID: 15871 RVA: 0x00096893 File Offset: 0x00094A93
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ca
		{
			get
			{
				return this.caField;
			}
			set
			{
				this.caField = value;
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06003E00 RID: 15872 RVA: 0x0009689C File Offset: 0x00094A9C
		// (set) Token: 0x06003E01 RID: 15873 RVA: 0x000968A4 File Offset: 0x00094AA4
		[global::System.Xml.Serialization.XmlAttribute]
		public uint si
		{
			get
			{
				return this.siField;
			}
			set
			{
				this.siField = value;
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x000968AD File Offset: 0x00094AAD
		// (set) Token: 0x06003E03 RID: 15875 RVA: 0x000968B5 File Offset: 0x00094AB5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool siSpecified
		{
			get
			{
				return this.siFieldSpecified;
			}
			set
			{
				this.siFieldSpecified = value;
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x000968BE File Offset: 0x00094ABE
		// (set) Token: 0x06003E05 RID: 15877 RVA: 0x000968C6 File Offset: 0x00094AC6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool bx
		{
			get
			{
				return this.bxField;
			}
			set
			{
				this.bxField = value;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x000968CF File Offset: 0x00094ACF
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x000968D7 File Offset: 0x00094AD7
		[global::System.Xml.Serialization.XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x04002764 RID: 10084
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType tField;

		// Token: 0x04002765 RID: 10085
		private bool acaField;

		// Token: 0x04002766 RID: 10086
		private string refField;

		// Token: 0x04002767 RID: 10087
		private bool dt2DField;

		// Token: 0x04002768 RID: 10088
		private bool dtrField;

		// Token: 0x04002769 RID: 10089
		private bool del1Field;

		// Token: 0x0400276A RID: 10090
		private bool del2Field;

		// Token: 0x0400276B RID: 10091
		private string r1Field;

		// Token: 0x0400276C RID: 10092
		private string r2Field;

		// Token: 0x0400276D RID: 10093
		private bool caField;

		// Token: 0x0400276E RID: 10094
		private uint siField;

		// Token: 0x0400276F RID: 10095
		private bool siFieldSpecified;

		// Token: 0x04002770 RID: 10096
		private bool bxField;

		// Token: 0x04002771 RID: 10097
		private string valueField;
	}
}
