using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200050A RID: 1290
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Cell
	{
		// Token: 0x06003751 RID: 14161 RVA: 0x0008A114 File Offset: 0x00088314
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell ct_Cell = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell();
			ct_Cell.r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r"]);
			ct_Cell.s = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["s"]);
			if (node.Attributes["t"] != null)
			{
				ct_Cell.t = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType), node.Attributes["t"].Value);
			}
			ct_Cell.cm = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["cm"]);
			ct_Cell.vm = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["vm"]);
			ct_Cell.ph = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["ph"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "f")
				{
					ct_Cell.f = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "v")
				{
					ct_Cell.v = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "is")
				{
					ct_Cell.@is = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Cell.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Cell;
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x0008A2C4 File Offset: 0x000884C4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.r);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "s", this.s, false);
			if (this.t != global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "t", this.t.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cm", this.cm, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "vm", this.vm, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ph", this.ph, false);
			if (this.f == null && this.v == null && this.@is == null && this.extLstField == null)
			{
				sw.Write("/>");
				return;
			}
			sw.Write(">");
			if (this.f != null)
			{
				this.f.Write(sw, "f");
			}
			if (!string.IsNullOrEmpty(this.v))
			{
				sw.Write(string.Format("<v>{0}</v>", global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.v)));
			}
			else
			{
				sw.Write("<v/>");
			}
			if (this.@is != null)
			{
				this.@is.Write(sw, "is");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x0008A42C File Offset: 0x0008862C
		public void Set(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell cell)
		{
			this.fField = cell.fField;
			this.vField = cell.vField;
			this.isField = cell.isField;
			this.extLstField = cell.extLstField;
			this.rField = cell.rField;
			this.sField = cell.sField;
			this.tField = cell.tField;
			this.cmField = cell.cmField;
			this.vmField = cell.vmField;
			this.phField = cell.phField;
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x0008A4B4 File Offset: 0x000886B4
		public bool IsSetT()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType? st_CellType = this.tField;
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType st_CellType2 = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n;
			return !(st_CellType.GetValueOrDefault() == st_CellType2 & st_CellType != null);
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x0008A4E0 File Offset: 0x000886E0
		public bool IsSetS()
		{
			uint? num = this.sField;
			uint num2 = 0U;
			return !(num.GetValueOrDefault() == num2 & num != null);
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x0008A50B File Offset: 0x0008870B
		public bool IsSetF()
		{
			return this.fField != null;
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x0008A516 File Offset: 0x00088716
		public bool IsSetV()
		{
			return this.vField != null;
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x0008A521 File Offset: 0x00088721
		public bool IsSetIs()
		{
			return this.isField != null;
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x0008A52C File Offset: 0x0008872C
		public bool IsSetR()
		{
			return this.rField != null;
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x0008A537 File Offset: 0x00088737
		public void unsetF()
		{
			this.fField = null;
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x0008A540 File Offset: 0x00088740
		public void unsetV()
		{
			this.vField = null;
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x0008A549 File Offset: 0x00088749
		public void unsetS()
		{
			this.sField = new uint?(0U);
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x0008A557 File Offset: 0x00088757
		public void unsetT()
		{
			this.tField = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType?(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n);
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x0008A565 File Offset: 0x00088765
		public void unsetIs()
		{
			this.isField = null;
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x0008A56E File Offset: 0x0008876E
		public void unsetR()
		{
			this.rField = null;
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06003760 RID: 14176 RVA: 0x0008A577 File Offset: 0x00088777
		// (set) Token: 0x06003761 RID: 14177 RVA: 0x0008A57F File Offset: 0x0008877F
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula f
		{
			get
			{
				return this.fField;
			}
			set
			{
				this.fField = value;
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06003762 RID: 14178 RVA: 0x0008A588 File Offset: 0x00088788
		// (set) Token: 0x06003763 RID: 14179 RVA: 0x0008A590 File Offset: 0x00088790
		[global::System.Xml.Serialization.XmlElement]
		public string v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06003764 RID: 14180 RVA: 0x0008A599 File Offset: 0x00088799
		// (set) Token: 0x06003765 RID: 14181 RVA: 0x0008A5A1 File Offset: 0x000887A1
		[global::System.Xml.Serialization.XmlElement("is")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst @is
		{
			get
			{
				return this.isField;
			}
			set
			{
				this.isField = value;
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06003766 RID: 14182 RVA: 0x0008A5AA File Offset: 0x000887AA
		// (set) Token: 0x06003767 RID: 14183 RVA: 0x0008A5B2 File Offset: 0x000887B2
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06003768 RID: 14184 RVA: 0x0008A5BB File Offset: 0x000887BB
		// (set) Token: 0x06003769 RID: 14185 RVA: 0x0008A5C3 File Offset: 0x000887C3
		[global::System.Xml.Serialization.XmlAttribute]
		public string r
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

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600376A RID: 14186 RVA: 0x0008A5CC File Offset: 0x000887CC
		// (set) Token: 0x0600376B RID: 14187 RVA: 0x0008A5E8 File Offset: 0x000887E8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint s
		{
			get
			{
				if (this.sField != null)
				{
					return this.sField.Value;
				}
				return 0U;
			}
			set
			{
				this.sField = new uint?(value);
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x0600376C RID: 14188 RVA: 0x0008A5F6 File Offset: 0x000887F6
		// (set) Token: 0x0600376D RID: 14189 RVA: 0x0008A612 File Offset: 0x00088812
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType t
		{
			get
			{
				if (this.tField != null)
				{
					return this.tField.Value;
				}
				return global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType.n;
			}
			set
			{
				this.tField = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType?(value);
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x0600376E RID: 14190 RVA: 0x0008A620 File Offset: 0x00088820
		// (set) Token: 0x0600376F RID: 14191 RVA: 0x0008A63C File Offset: 0x0008883C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint cm
		{
			get
			{
				if (this.cmField != null)
				{
					return this.cmField.Value;
				}
				return 0U;
			}
			set
			{
				this.cmField = new uint?(value);
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x0008A64A File Offset: 0x0008884A
		// (set) Token: 0x06003771 RID: 14193 RVA: 0x0008A666 File Offset: 0x00088866
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint vm
		{
			get
			{
				if (this.vmField != null)
				{
					return this.vmField.Value;
				}
				return 0U;
			}
			set
			{
				this.vmField = new uint?(value);
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x0008A674 File Offset: 0x00088874
		// (set) Token: 0x06003773 RID: 14195 RVA: 0x0008A690 File Offset: 0x00088890
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ph
		{
			get
			{
				return this.phField != null && this.phField.Value;
			}
			set
			{
				this.phField = new bool?(value);
			}
		}

		// Token: 0x04002410 RID: 9232
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula fField;

		// Token: 0x04002411 RID: 9233
		private string vField;

		// Token: 0x04002412 RID: 9234
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst isField;

		// Token: 0x04002413 RID: 9235
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002414 RID: 9236
		private string rField;

		// Token: 0x04002415 RID: 9237
		private uint? sField;

		// Token: 0x04002416 RID: 9238
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellType? tField;

		// Token: 0x04002417 RID: 9239
		private uint? cmField;

		// Token: 0x04002418 RID: 9240
		private uint? vmField;

		// Token: 0x04002419 RID: 9241
		private bool? phField;
	}
}
