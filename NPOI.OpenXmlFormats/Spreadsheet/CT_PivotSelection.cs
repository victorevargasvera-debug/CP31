using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200057E RID: 1406
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PivotSelection
	{
		// Token: 0x06003D49 RID: 15689 RVA: 0x00094DF8 File Offset: 0x00092FF8
		public CT_PivotSelection()
		{
			this.pivotAreaField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea();
			this.paneField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane.topLeft;
			this.showHeaderField = false;
			this.labelField = false;
			this.dataField = false;
			this.extendableField = false;
			this.countField = 0U;
			this.dimensionField = 0U;
			this.startField = 0U;
			this.minField = 0U;
			this.maxField = 0U;
			this.activeRowField = 0U;
			this.activeColField = 0U;
			this.previousRowField = 0U;
			this.previousColField = 0U;
			this.clickField = 0U;
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x00094E80 File Offset: 0x00093080
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotSelection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotSelection ct_PivotSelection = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotSelection();
			if (node.Attributes["pane"] != null)
			{
				ct_PivotSelection.pane = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane), node.Attributes["pane"].Value);
			}
			ct_PivotSelection.showHeader = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showHeader"]);
			ct_PivotSelection.label = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["label"]);
			ct_PivotSelection.data = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["data"]);
			ct_PivotSelection.extendable = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["extendable"]);
			ct_PivotSelection.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			if (node.Attributes["axis"] != null)
			{
				ct_PivotSelection.axis = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis), node.Attributes["axis"].Value);
			}
			ct_PivotSelection.dimension = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dimension"]);
			ct_PivotSelection.start = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["start"]);
			ct_PivotSelection.min = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["min"]);
			ct_PivotSelection.max = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["max"]);
			ct_PivotSelection.activeRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["activeRow"]);
			ct_PivotSelection.activeCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["activeCol"]);
			ct_PivotSelection.previousRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["previousRow"]);
			ct_PivotSelection.previousCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["previousCol"]);
			ct_PivotSelection.click = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["click"]);
			ct_PivotSelection.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pivotArea")
				{
					ct_PivotSelection.pivotArea = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PivotSelection;
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x0009511C File Offset: 0x0009331C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pane", this.pane.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showHeader", this.showHeader);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "label", this.label);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "data", this.data);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "extendable", this.extendable);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "axis", this.axis.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dimension", this.dimension, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "start", this.start, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "min", this.min, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "max", this.max, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "activeRow", this.activeRow, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "activeCol", this.activeCol, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "previousRow", this.previousRow, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "previousCol", this.previousCol, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "click", this.click, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			if (this.pivotArea != null)
			{
				this.pivotArea.Write(sw, "pivotArea");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x000952B6 File Offset: 0x000934B6
		// (set) Token: 0x06003D4D RID: 15693 RVA: 0x000952BE File Offset: 0x000934BE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea pivotArea
		{
			get
			{
				return this.pivotAreaField;
			}
			set
			{
				this.pivotAreaField = value;
			}
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x000952C7 File Offset: 0x000934C7
		// (set) Token: 0x06003D4F RID: 15695 RVA: 0x000952CF File Offset: 0x000934CF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane.topLeft)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane pane
		{
			get
			{
				return this.paneField;
			}
			set
			{
				this.paneField = value;
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06003D50 RID: 15696 RVA: 0x000952D8 File Offset: 0x000934D8
		// (set) Token: 0x06003D51 RID: 15697 RVA: 0x000952E0 File Offset: 0x000934E0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool showHeader
		{
			get
			{
				return this.showHeaderField;
			}
			set
			{
				this.showHeaderField = value;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06003D52 RID: 15698 RVA: 0x000952E9 File Offset: 0x000934E9
		// (set) Token: 0x06003D53 RID: 15699 RVA: 0x000952F1 File Offset: 0x000934F1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool label
		{
			get
			{
				return this.labelField;
			}
			set
			{
				this.labelField = value;
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06003D54 RID: 15700 RVA: 0x000952FA File Offset: 0x000934FA
		// (set) Token: 0x06003D55 RID: 15701 RVA: 0x00095302 File Offset: 0x00093502
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06003D56 RID: 15702 RVA: 0x0009530B File Offset: 0x0009350B
		// (set) Token: 0x06003D57 RID: 15703 RVA: 0x00095313 File Offset: 0x00093513
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool extendable
		{
			get
			{
				return this.extendableField;
			}
			set
			{
				this.extendableField = value;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06003D58 RID: 15704 RVA: 0x0009531C File Offset: 0x0009351C
		// (set) Token: 0x06003D59 RID: 15705 RVA: 0x00095324 File Offset: 0x00093524
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06003D5A RID: 15706 RVA: 0x0009532D File Offset: 0x0009352D
		// (set) Token: 0x06003D5B RID: 15707 RVA: 0x00095335 File Offset: 0x00093535
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis axis
		{
			get
			{
				return this.axisField;
			}
			set
			{
				this.axisField = value;
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06003D5C RID: 15708 RVA: 0x0009533E File Offset: 0x0009353E
		// (set) Token: 0x06003D5D RID: 15709 RVA: 0x00095346 File Offset: 0x00093546
		[global::System.Xml.Serialization.XmlIgnore]
		public bool axisSpecified
		{
			get
			{
				return this.axisFieldSpecified;
			}
			set
			{
				this.axisFieldSpecified = value;
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06003D5E RID: 15710 RVA: 0x0009534F File Offset: 0x0009354F
		// (set) Token: 0x06003D5F RID: 15711 RVA: 0x00095357 File Offset: 0x00093557
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint dimension
		{
			get
			{
				return this.dimensionField;
			}
			set
			{
				this.dimensionField = value;
			}
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06003D60 RID: 15712 RVA: 0x00095360 File Offset: 0x00093560
		// (set) Token: 0x06003D61 RID: 15713 RVA: 0x00095368 File Offset: 0x00093568
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06003D62 RID: 15714 RVA: 0x00095371 File Offset: 0x00093571
		// (set) Token: 0x06003D63 RID: 15715 RVA: 0x00095379 File Offset: 0x00093579
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint min
		{
			get
			{
				return this.minField;
			}
			set
			{
				this.minField = value;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06003D64 RID: 15716 RVA: 0x00095382 File Offset: 0x00093582
		// (set) Token: 0x06003D65 RID: 15717 RVA: 0x0009538A File Offset: 0x0009358A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint max
		{
			get
			{
				return this.maxField;
			}
			set
			{
				this.maxField = value;
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06003D66 RID: 15718 RVA: 0x00095393 File Offset: 0x00093593
		// (set) Token: 0x06003D67 RID: 15719 RVA: 0x0009539B File Offset: 0x0009359B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint activeRow
		{
			get
			{
				return this.activeRowField;
			}
			set
			{
				this.activeRowField = value;
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06003D68 RID: 15720 RVA: 0x000953A4 File Offset: 0x000935A4
		// (set) Token: 0x06003D69 RID: 15721 RVA: 0x000953AC File Offset: 0x000935AC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint activeCol
		{
			get
			{
				return this.activeColField;
			}
			set
			{
				this.activeColField = value;
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x000953B5 File Offset: 0x000935B5
		// (set) Token: 0x06003D6B RID: 15723 RVA: 0x000953BD File Offset: 0x000935BD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint previousRow
		{
			get
			{
				return this.previousRowField;
			}
			set
			{
				this.previousRowField = value;
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06003D6C RID: 15724 RVA: 0x000953C6 File Offset: 0x000935C6
		// (set) Token: 0x06003D6D RID: 15725 RVA: 0x000953CE File Offset: 0x000935CE
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint previousCol
		{
			get
			{
				return this.previousColField;
			}
			set
			{
				this.previousColField = value;
			}
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06003D6E RID: 15726 RVA: 0x000953D7 File Offset: 0x000935D7
		// (set) Token: 0x06003D6F RID: 15727 RVA: 0x000953DF File Offset: 0x000935DF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint click
		{
			get
			{
				return this.clickField;
			}
			set
			{
				this.clickField = value;
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06003D70 RID: 15728 RVA: 0x000953E8 File Offset: 0x000935E8
		// (set) Token: 0x06003D71 RID: 15729 RVA: 0x000953F0 File Offset: 0x000935F0
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

		// Token: 0x04002719 RID: 10009
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea pivotAreaField;

		// Token: 0x0400271A RID: 10010
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Pane paneField;

		// Token: 0x0400271B RID: 10011
		private bool showHeaderField;

		// Token: 0x0400271C RID: 10012
		private bool labelField;

		// Token: 0x0400271D RID: 10013
		private bool dataField;

		// Token: 0x0400271E RID: 10014
		private bool extendableField;

		// Token: 0x0400271F RID: 10015
		private uint countField;

		// Token: 0x04002720 RID: 10016
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis axisField;

		// Token: 0x04002721 RID: 10017
		private bool axisFieldSpecified;

		// Token: 0x04002722 RID: 10018
		private uint dimensionField;

		// Token: 0x04002723 RID: 10019
		private uint startField;

		// Token: 0x04002724 RID: 10020
		private uint minField;

		// Token: 0x04002725 RID: 10021
		private uint maxField;

		// Token: 0x04002726 RID: 10022
		private uint activeRowField;

		// Token: 0x04002727 RID: 10023
		private uint activeColField;

		// Token: 0x04002728 RID: 10024
		private uint previousRowField;

		// Token: 0x04002729 RID: 10025
		private uint previousColField;

		// Token: 0x0400272A RID: 10026
		private uint clickField;

		// Token: 0x0400272B RID: 10027
		private string idField;
	}
}
