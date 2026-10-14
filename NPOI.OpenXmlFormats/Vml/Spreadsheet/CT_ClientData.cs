using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;

namespace NPOI.OpenXmlFormats.Vml.Spreadsheet
{
	// Token: 0x02000202 RID: 514
	[global::System.ComponentModel.DesignerCategory("code")]
	public class CT_ClientData
	{
		// Token: 0x060014A9 RID: 5289 RVA: 0x000403D7 File Offset: 0x0003E5D7
		public CT_ClientData()
		{
			this.rowField = new global::System.Collections.Generic.List<int>();
			this.columnField = new global::System.Collections.Generic.List<int>();
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x000403F8 File Offset: 0x0003E5F8
		public static global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData ct_ClientData = new global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData();
			if (node.Attributes["ObjectType"] != null)
			{
				ct_ClientData.ObjectType = (global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_ObjectType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_ObjectType), node.Attributes["ObjectType"].Value);
			}
			ct_ClientData.column = new global::System.Collections.Generic.List<int>();
			ct_ClientData.row = new global::System.Collections.Generic.List<int>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "Anchor")
				{
					ct_ClientData.anchor = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "AutoFill")
				{
					ct_ClientData.autoFill = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalseBlank(xmlNode.InnerText);
				}
				else if (xmlNode.LocalName == "Visible")
				{
					ct_ClientData.visible = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalseBlank(xmlNode.InnerText);
				}
				else if (xmlNode.LocalName == "MoveWithCells")
				{
					ct_ClientData.moveWithCells = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalseBlank(xmlNode.InnerText);
				}
				else if (xmlNode.LocalName == "SizeWithCells")
				{
					ct_ClientData.sizeWithCells = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalseBlank(xmlNode.InnerText);
				}
				else if (xmlNode.LocalName == "Column")
				{
					ct_ClientData.column.Add(int.Parse(xmlNode.InnerText));
				}
				else if (xmlNode.LocalName == "Row")
				{
					ct_ClientData.row.Add(int.Parse(xmlNode.InnerText));
				}
			}
			return ct_ClientData;
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x000405D0 File Offset: 0x0003E7D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<x:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ObjectType", this.ObjectType.ToString());
			sw.Write(">");
			if (this.moveWithCells == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.t || this.moveWithCells == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@true)
			{
				sw.Write(string.Format("<x:MoveWithCells/>", this.moveWithCells));
			}
			if (this.sizeWithCells == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.t || this.sizeWithCells == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@true)
			{
				sw.Write(string.Format("<x:SizeWithCells/>", this.sizeWithCells));
			}
			if (this.anchor != null)
			{
				sw.Write(string.Format("<x:Anchor>{0}</x:Anchor>", this.anchor));
			}
			if (this.autoFill != global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE)
			{
				sw.Write(string.Format("<x:AutoFill>{0}</x:AutoFill>", this.autoFill));
			}
			if (this.visible != global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE)
			{
				sw.Write(string.Format("<x:Visible>{0}</x:Visible>", this.visible));
			}
			if (this.row != null)
			{
				foreach (int num in this.row)
				{
					sw.Write(string.Format("<x:Row>{0}</x:Row>", num));
				}
			}
			if (this.column != null)
			{
				foreach (int num2 in this.column)
				{
					sw.Write(string.Format("<x:Column>{0}</x:Column>", num2));
				}
			}
			sw.Write(string.Format("</x:{0}>", nodeName));
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x000407A0 File Offset: 0x0003E9A0
		public void AddNewRow(int rowNum)
		{
			if (this.rowField != null)
			{
				this.rowField.Add(rowNum);
			}
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x000407B6 File Offset: 0x0003E9B6
		public void AddNewColumn(int columnNum)
		{
			if (this.columnField != null)
			{
				this.columnField.Add(columnNum);
			}
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x000407CC File Offset: 0x0003E9CC
		public void AddNewMoveWithCells()
		{
			this.moveWithCellsField = global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.t;
			this.moveWithCellsFieldSpecified = true;
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x000407DC File Offset: 0x0003E9DC
		public void AddNewSizeWithCells()
		{
			this.sizeWithCellsField = global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.t;
			this.sizeWithCellsFieldSpecified = true;
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x000407EC File Offset: 0x0003E9EC
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x000407F4 File Offset: 0x0003E9F4
		[global::System.Xml.Serialization.XmlElement(ElementName = "Anchor")]
		public string anchor
		{
			get
			{
				return this.anchorField;
			}
			set
			{
				this.anchorField = value;
			}
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x000407F4 File Offset: 0x0003E9F4
		public void AddNewAnchor(string name)
		{
			this.anchorField = name;
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x000407FD File Offset: 0x0003E9FD
		public void AddNewAutoFill(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank value)
		{
			this.autoFillField = value;
			this.autoFillFieldSpecified = true;
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0004080D File Offset: 0x0003EA0D
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x00040815 File Offset: 0x0003EA15
		[global::System.Xml.Serialization.XmlElement(ElementName = "AutoFill")]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE)]
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank autoFill
		{
			get
			{
				return this.autoFillField;
			}
			set
			{
				this.autoFillField = value;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0004081E File Offset: 0x0003EA1E
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x00040826 File Offset: 0x0003EA26
		[global::System.Xml.Serialization.XmlIgnore]
		public bool autoFillSpecified
		{
			get
			{
				return this.autoFillFieldSpecified;
			}
			set
			{
				this.autoFillFieldSpecified = value;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0004082F File Offset: 0x0003EA2F
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x00040837 File Offset: 0x0003EA37
		[global::System.Xml.Serialization.XmlElement(ElementName = "Visible")]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE)]
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank visible
		{
			get
			{
				return this.visibleField;
			}
			set
			{
				this.visibleField = value;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x00040840 File Offset: 0x0003EA40
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x00040848 File Offset: 0x0003EA48
		[global::System.Xml.Serialization.XmlIgnore]
		public bool visibleSpecified
		{
			get
			{
				return this.visibleFieldSpecified;
			}
			set
			{
				this.visibleFieldSpecified = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x00040851 File Offset: 0x0003EA51
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x00040859 File Offset: 0x0003EA59
		[global::System.Xml.Serialization.XmlElement(ElementName = "MoveWithCells")]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE)]
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank moveWithCells
		{
			get
			{
				return this.moveWithCellsField;
			}
			set
			{
				this.moveWithCellsField = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x00040862 File Offset: 0x0003EA62
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x0004086A File Offset: 0x0003EA6A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool moveWithCellsSpecified
		{
			get
			{
				return this.moveWithCellsFieldSpecified;
			}
			set
			{
				this.moveWithCellsFieldSpecified = value;
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00040873 File Offset: 0x0003EA73
		public int SizeOfMoveWithCellsArray()
		{
			if (!this.moveWithCellsSpecified)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00040880 File Offset: 0x0003EA80
		public int SizeOfSizeWithCellsArray()
		{
			if (!this.sizeWithCellsFieldSpecified)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0004088D File Offset: 0x0003EA8D
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x00040895 File Offset: 0x0003EA95
		[global::System.Xml.Serialization.XmlElement(ElementName = "SizeWithCells")]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE)]
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank sizeWithCells
		{
			get
			{
				return this.sizeWithCellsField;
			}
			set
			{
				this.sizeWithCellsField = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0004089E File Offset: 0x0003EA9E
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x000408A6 File Offset: 0x0003EAA6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool sizeWithCellsSpecified
		{
			get
			{
				return this.sizeWithCellsFieldSpecified;
			}
			set
			{
				this.sizeWithCellsFieldSpecified = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x000408AF File Offset: 0x0003EAAF
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x000408B7 File Offset: 0x0003EAB7
		[global::System.Xml.Serialization.XmlElement(ElementName = "Column")]
		public global::System.Collections.Generic.List<int> column
		{
			get
			{
				return this.columnField;
			}
			set
			{
				this.columnField = value;
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x000408C0 File Offset: 0x0003EAC0
		public int GetColumnArray(int index)
		{
			return this.columnField[index];
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x000408CE File Offset: 0x0003EACE
		public void SetColumnArray(int index, int value)
		{
			this.columnField[index] = value;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000408DD File Offset: 0x0003EADD
		public void SetRowArray(int index, int value)
		{
			this.rowField[index] = value;
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000408EC File Offset: 0x0003EAEC
		public void SetAnchorArray(int index, string value)
		{
			this.AddNewAnchor(value);
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x000408F5 File Offset: 0x0003EAF5
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x000408FD File Offset: 0x0003EAFD
		[global::System.Xml.Serialization.XmlElement(ElementName = "Row")]
		public global::System.Collections.Generic.List<int> row
		{
			get
			{
				return this.rowField;
			}
			set
			{
				this.rowField = value;
			}
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00040906 File Offset: 0x0003EB06
		public int GetRowArray(int index)
		{
			return this.rowField[index];
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00040914 File Offset: 0x0003EB14
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0004091C File Offset: 0x0003EB1C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_ObjectType ObjectType
		{
			get
			{
				return this.objectTypeField;
			}
			set
			{
				this.objectTypeField = value;
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00040925 File Offset: 0x0003EB25
		public string GetAnchorArray(int p)
		{
			return this.anchor;
		}

		// Token: 0x04001001 RID: 4097
		private global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_ObjectType objectTypeField;

		// Token: 0x04001002 RID: 4098
		private static global::System.Xml.XmlQualifiedName MOVEWITHCELLS = new global::System.Xml.XmlQualifiedName("MoveWithCells", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001003 RID: 4099
		private static global::System.Xml.XmlQualifiedName SIZEWITHCELLS = new global::System.Xml.XmlQualifiedName("SizeWithCells", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001004 RID: 4100
		private static global::System.Xml.XmlQualifiedName ANCHOR = new global::System.Xml.XmlQualifiedName("Anchor", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001005 RID: 4101
		private static global::System.Xml.XmlQualifiedName LOCKED = new global::System.Xml.XmlQualifiedName("Locked", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001006 RID: 4102
		private static global::System.Xml.XmlQualifiedName DEFAULTSIZE = new global::System.Xml.XmlQualifiedName("DefaultSize", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001007 RID: 4103
		private static global::System.Xml.XmlQualifiedName PRINTOBJECT = new global::System.Xml.XmlQualifiedName("PrintObject", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001008 RID: 4104
		private static global::System.Xml.XmlQualifiedName DISABLED = new global::System.Xml.XmlQualifiedName("Disabled", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001009 RID: 4105
		private static global::System.Xml.XmlQualifiedName AUTOFILL = new global::System.Xml.XmlQualifiedName("AutoFill", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400100A RID: 4106
		private static global::System.Xml.XmlQualifiedName AUTOLINE = new global::System.Xml.XmlQualifiedName("AutoLine", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400100B RID: 4107
		private static global::System.Xml.XmlQualifiedName AUTOPICT = new global::System.Xml.XmlQualifiedName("AutoPict", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400100C RID: 4108
		private static global::System.Xml.XmlQualifiedName FMLAMACRO = new global::System.Xml.XmlQualifiedName("FmlaMacro", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400100D RID: 4109
		private static global::System.Xml.XmlQualifiedName TEXTHALIGN = new global::System.Xml.XmlQualifiedName("TextHAlign", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400100E RID: 4110
		private static global::System.Xml.XmlQualifiedName TEXTVALIGN = new global::System.Xml.XmlQualifiedName("TextVAlign", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400100F RID: 4111
		private static global::System.Xml.XmlQualifiedName LOCKTEXT = new global::System.Xml.XmlQualifiedName("LockText", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001010 RID: 4112
		private static global::System.Xml.XmlQualifiedName JUSTLASTX = new global::System.Xml.XmlQualifiedName("JustLastX", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001011 RID: 4113
		private static global::System.Xml.XmlQualifiedName SECRETEDIT = new global::System.Xml.XmlQualifiedName("SecretEdit", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001012 RID: 4114
		private static global::System.Xml.XmlQualifiedName DEFAULT = new global::System.Xml.XmlQualifiedName("Default", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001013 RID: 4115
		private static global::System.Xml.XmlQualifiedName HELP = new global::System.Xml.XmlQualifiedName("Help", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001014 RID: 4116
		private static global::System.Xml.XmlQualifiedName CANCEL = new global::System.Xml.XmlQualifiedName("Cancel", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001015 RID: 4117
		private static global::System.Xml.XmlQualifiedName DISMISS = new global::System.Xml.XmlQualifiedName("Dismiss", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001016 RID: 4118
		private static global::System.Xml.XmlQualifiedName ACCEL = new global::System.Xml.XmlQualifiedName("Accel", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001017 RID: 4119
		private static global::System.Xml.XmlQualifiedName ACCEL2 = new global::System.Xml.XmlQualifiedName("Accel2", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001018 RID: 4120
		private static global::System.Xml.XmlQualifiedName ROW = new global::System.Xml.XmlQualifiedName("Row", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001019 RID: 4121
		private static global::System.Xml.XmlQualifiedName COLUMN = new global::System.Xml.XmlQualifiedName("Column", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400101A RID: 4122
		private static global::System.Xml.XmlQualifiedName VISIBLE = new global::System.Xml.XmlQualifiedName("Visible", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400101B RID: 4123
		private static global::System.Xml.XmlQualifiedName ROWHIDDEN = new global::System.Xml.XmlQualifiedName("RowHidden", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400101C RID: 4124
		private static global::System.Xml.XmlQualifiedName COLHIDDEN = new global::System.Xml.XmlQualifiedName("ColHidden", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400101D RID: 4125
		private static global::System.Xml.XmlQualifiedName VTEDIT = new global::System.Xml.XmlQualifiedName("VTEdit", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400101E RID: 4126
		private static global::System.Xml.XmlQualifiedName MULTILINE = new global::System.Xml.XmlQualifiedName("MultiLine", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400101F RID: 4127
		private static global::System.Xml.XmlQualifiedName VSCROLL = new global::System.Xml.XmlQualifiedName("VScroll", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001020 RID: 4128
		private static global::System.Xml.XmlQualifiedName VALIDIDS = new global::System.Xml.XmlQualifiedName("ValidIds", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001021 RID: 4129
		private static global::System.Xml.XmlQualifiedName FMLARANGE = new global::System.Xml.XmlQualifiedName("FmlaRange", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001022 RID: 4130
		private static global::System.Xml.XmlQualifiedName WIDTHMIN = new global::System.Xml.XmlQualifiedName("WidthMin", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001023 RID: 4131
		private static global::System.Xml.XmlQualifiedName SEL = new global::System.Xml.XmlQualifiedName("Sel", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001024 RID: 4132
		private static global::System.Xml.XmlQualifiedName NOTHREED2 = new global::System.Xml.XmlQualifiedName("NoThreeD2", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001025 RID: 4133
		private static global::System.Xml.XmlQualifiedName SELTYPE = new global::System.Xml.XmlQualifiedName("SelType", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001026 RID: 4134
		private static global::System.Xml.XmlQualifiedName MULTISEL = new global::System.Xml.XmlQualifiedName("MultiSel", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001027 RID: 4135
		private static global::System.Xml.XmlQualifiedName LCT = new global::System.Xml.XmlQualifiedName("LCT", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001028 RID: 4136
		private static global::System.Xml.XmlQualifiedName LISTITEM = new global::System.Xml.XmlQualifiedName("ListItem", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001029 RID: 4137
		private static global::System.Xml.XmlQualifiedName DROPSTYLE = new global::System.Xml.XmlQualifiedName("DropStyle", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400102A RID: 4138
		private static global::System.Xml.XmlQualifiedName COLORED = new global::System.Xml.XmlQualifiedName("Colored", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400102B RID: 4139
		private static global::System.Xml.XmlQualifiedName DROPLINES = new global::System.Xml.XmlQualifiedName("DropLines", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400102C RID: 4140
		private static global::System.Xml.XmlQualifiedName CHECKED = new global::System.Xml.XmlQualifiedName("Checked", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400102D RID: 4141
		private static global::System.Xml.XmlQualifiedName FMLALINK = new global::System.Xml.XmlQualifiedName("FmlaLink", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400102E RID: 4142
		private static global::System.Xml.XmlQualifiedName FMLAPICT = new global::System.Xml.XmlQualifiedName("FmlaPict", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400102F RID: 4143
		private static global::System.Xml.XmlQualifiedName NOTHREED = new global::System.Xml.XmlQualifiedName("NoThreeD", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001030 RID: 4144
		private static global::System.Xml.XmlQualifiedName FIRSTBUTTON = new global::System.Xml.XmlQualifiedName("FirstButton", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001031 RID: 4145
		private static global::System.Xml.XmlQualifiedName FMLAGROUP = new global::System.Xml.XmlQualifiedName("FmlaGroup", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001032 RID: 4146
		private static global::System.Xml.XmlQualifiedName VAL = new global::System.Xml.XmlQualifiedName("Val", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001033 RID: 4147
		private static global::System.Xml.XmlQualifiedName MIN = new global::System.Xml.XmlQualifiedName("Min", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001034 RID: 4148
		private static global::System.Xml.XmlQualifiedName MAX = new global::System.Xml.XmlQualifiedName("Max", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001035 RID: 4149
		private static global::System.Xml.XmlQualifiedName INC = new global::System.Xml.XmlQualifiedName("Inc", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001036 RID: 4150
		private static global::System.Xml.XmlQualifiedName PAGE = new global::System.Xml.XmlQualifiedName("Page", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001037 RID: 4151
		private static global::System.Xml.XmlQualifiedName HORIZ = new global::System.Xml.XmlQualifiedName("Horiz", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001038 RID: 4152
		private static global::System.Xml.XmlQualifiedName DX = new global::System.Xml.XmlQualifiedName("Dx", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001039 RID: 4153
		private static global::System.Xml.XmlQualifiedName MAPOCX = new global::System.Xml.XmlQualifiedName("MapOCX", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400103A RID: 4154
		private static global::System.Xml.XmlQualifiedName CF = new global::System.Xml.XmlQualifiedName("CF", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400103B RID: 4155
		private static global::System.Xml.XmlQualifiedName CAMERA = new global::System.Xml.XmlQualifiedName("Camera", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400103C RID: 4156
		private static global::System.Xml.XmlQualifiedName RECALCALWAYS = new global::System.Xml.XmlQualifiedName("RecalcAlways", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400103D RID: 4157
		private static global::System.Xml.XmlQualifiedName AUTOSCALE = new global::System.Xml.XmlQualifiedName("AutoScale", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400103E RID: 4158
		private static global::System.Xml.XmlQualifiedName DDE = new global::System.Xml.XmlQualifiedName("DDE", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x0400103F RID: 4159
		private static global::System.Xml.XmlQualifiedName UIOBJ = new global::System.Xml.XmlQualifiedName("UIObj", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001040 RID: 4160
		private static global::System.Xml.XmlQualifiedName SCRIPTTEXT = new global::System.Xml.XmlQualifiedName("ScriptText", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001041 RID: 4161
		private static global::System.Xml.XmlQualifiedName SCRIPTEXTENDED = new global::System.Xml.XmlQualifiedName("ScriptExtended", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001042 RID: 4162
		private static global::System.Xml.XmlQualifiedName SCRIPTLANGUAGE = new global::System.Xml.XmlQualifiedName("ScriptLanguage", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001043 RID: 4163
		private static global::System.Xml.XmlQualifiedName SCRIPTLOCATION = new global::System.Xml.XmlQualifiedName("ScriptLocation", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001044 RID: 4164
		private static global::System.Xml.XmlQualifiedName FMLATXBX = new global::System.Xml.XmlQualifiedName("FmlaTxbx", "urn:schemas-microsoft-com:office:excel");

		// Token: 0x04001045 RID: 4165
		private static global::System.Xml.XmlQualifiedName OBJECTTYPE = new global::System.Xml.XmlQualifiedName("ObjectType", "");

		// Token: 0x04001046 RID: 4166
		private string anchorField;

		// Token: 0x04001047 RID: 4167
		private global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank autoFillField;

		// Token: 0x04001048 RID: 4168
		private bool autoFillFieldSpecified;

		// Token: 0x04001049 RID: 4169
		private global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank visibleField;

		// Token: 0x0400104A RID: 4170
		private bool visibleFieldSpecified;

		// Token: 0x0400104B RID: 4171
		private global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank moveWithCellsField;

		// Token: 0x0400104C RID: 4172
		private bool moveWithCellsFieldSpecified;

		// Token: 0x0400104D RID: 4173
		private global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank sizeWithCellsField;

		// Token: 0x0400104E RID: 4174
		private bool sizeWithCellsFieldSpecified;

		// Token: 0x0400104F RID: 4175
		private global::System.Collections.Generic.List<int> columnField;

		// Token: 0x04001050 RID: 4176
		private global::System.Collections.Generic.List<int> rowField;
	}
}
