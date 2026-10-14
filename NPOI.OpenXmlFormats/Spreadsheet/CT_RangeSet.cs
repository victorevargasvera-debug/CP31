using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000484 RID: 1156
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_RangeSet
	{
		// Token: 0x06002E42 RID: 11842 RVA: 0x000742C8 File Offset: 0x000724C8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSet ct_RangeSet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSet();
			if (node.Attributes["i1"] != null)
			{
				ct_RangeSet.i1 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["i1"]);
			}
			if (node.Attributes["i2"] != null)
			{
				ct_RangeSet.i2 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["i2"]);
			}
			if (node.Attributes["i3"] != null)
			{
				ct_RangeSet.i3 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["i3"]);
			}
			if (node.Attributes["i4"] != null)
			{
				ct_RangeSet.i4 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["i4"]);
			}
			ct_RangeSet.@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]);
			ct_RangeSet.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_RangeSet.sheet = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sheet"]);
			ct_RangeSet.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			return ct_RangeSet;
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x00074404 File Offset: 0x00072604
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "i1", this.i1, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "i2", this.i2, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "i3", this.i3, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "i4", this.i4, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sheet", this.sheet);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x000744CA File Offset: 0x000726CA
		// (set) Token: 0x06002E45 RID: 11845 RVA: 0x000744D2 File Offset: 0x000726D2
		[global::System.Xml.Serialization.XmlAttribute]
		public uint i1
		{
			get
			{
				return this.i1Field;
			}
			set
			{
				this.i1Field = value;
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x000744DB File Offset: 0x000726DB
		// (set) Token: 0x06002E47 RID: 11847 RVA: 0x000744E3 File Offset: 0x000726E3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool i1Specified
		{
			get
			{
				return this.i1FieldSpecified;
			}
			set
			{
				this.i1FieldSpecified = value;
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x000744EC File Offset: 0x000726EC
		// (set) Token: 0x06002E49 RID: 11849 RVA: 0x000744F4 File Offset: 0x000726F4
		[global::System.Xml.Serialization.XmlAttribute]
		public uint i2
		{
			get
			{
				return this.i2Field;
			}
			set
			{
				this.i2Field = value;
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x000744FD File Offset: 0x000726FD
		// (set) Token: 0x06002E4B RID: 11851 RVA: 0x00074505 File Offset: 0x00072705
		[global::System.Xml.Serialization.XmlIgnore]
		public bool i2Specified
		{
			get
			{
				return this.i2FieldSpecified;
			}
			set
			{
				this.i2FieldSpecified = value;
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06002E4C RID: 11852 RVA: 0x0007450E File Offset: 0x0007270E
		// (set) Token: 0x06002E4D RID: 11853 RVA: 0x00074516 File Offset: 0x00072716
		[global::System.Xml.Serialization.XmlAttribute]
		public uint i3
		{
			get
			{
				return this.i3Field;
			}
			set
			{
				this.i3Field = value;
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x0007451F File Offset: 0x0007271F
		// (set) Token: 0x06002E4F RID: 11855 RVA: 0x00074527 File Offset: 0x00072727
		[global::System.Xml.Serialization.XmlIgnore]
		public bool i3Specified
		{
			get
			{
				return this.i3FieldSpecified;
			}
			set
			{
				this.i3FieldSpecified = value;
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x00074530 File Offset: 0x00072730
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x00074538 File Offset: 0x00072738
		[global::System.Xml.Serialization.XmlAttribute]
		public uint i4
		{
			get
			{
				return this.i4Field;
			}
			set
			{
				this.i4Field = value;
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x00074541 File Offset: 0x00072741
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x00074549 File Offset: 0x00072749
		[global::System.Xml.Serialization.XmlIgnore]
		public bool i4Specified
		{
			get
			{
				return this.i4FieldSpecified;
			}
			set
			{
				this.i4FieldSpecified = value;
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x00074552 File Offset: 0x00072752
		// (set) Token: 0x06002E55 RID: 11861 RVA: 0x0007455A File Offset: 0x0007275A
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

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06002E56 RID: 11862 RVA: 0x00074563 File Offset: 0x00072763
		// (set) Token: 0x06002E57 RID: 11863 RVA: 0x0007456B File Offset: 0x0007276B
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06002E58 RID: 11864 RVA: 0x00074574 File Offset: 0x00072774
		// (set) Token: 0x06002E59 RID: 11865 RVA: 0x0007457C File Offset: 0x0007277C
		[global::System.Xml.Serialization.XmlAttribute]
		public string sheet
		{
			get
			{
				return this.sheetField;
			}
			set
			{
				this.sheetField = value;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06002E5A RID: 11866 RVA: 0x00074585 File Offset: 0x00072785
		// (set) Token: 0x06002E5B RID: 11867 RVA: 0x0007458D File Offset: 0x0007278D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x04001FF1 RID: 8177
		private uint i1Field;

		// Token: 0x04001FF2 RID: 8178
		private bool i1FieldSpecified;

		// Token: 0x04001FF3 RID: 8179
		private uint i2Field;

		// Token: 0x04001FF4 RID: 8180
		private bool i2FieldSpecified;

		// Token: 0x04001FF5 RID: 8181
		private uint i3Field;

		// Token: 0x04001FF6 RID: 8182
		private bool i3FieldSpecified;

		// Token: 0x04001FF7 RID: 8183
		private uint i4Field;

		// Token: 0x04001FF8 RID: 8184
		private bool i4FieldSpecified;

		// Token: 0x04001FF9 RID: 8185
		private string refField;

		// Token: 0x04001FFA RID: 8186
		private string nameField;

		// Token: 0x04001FFB RID: 8187
		private string sheetField;

		// Token: 0x04001FFC RID: 8188
		private string idField;
	}
}
