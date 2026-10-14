using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000213 RID: 531
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Lock
	{
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x0004158A File Offset: 0x0003F78A
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x00041592 File Offset: 0x0003F792
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x0004159B File Offset: 0x0003F79B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x000415A6 File Offset: 0x0003F7A6
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x000415AE File Offset: 0x0003F7AE
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse position
		{
			get
			{
				return this.positionField;
			}
			set
			{
				this.positionField = value;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x000415B7 File Offset: 0x0003F7B7
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x000415BF File Offset: 0x0003F7BF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool positionSpecified
		{
			get
			{
				return this.positionFieldSpecified;
			}
			set
			{
				this.positionFieldSpecified = value;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x000415C8 File Offset: 0x0003F7C8
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x000415D0 File Offset: 0x0003F7D0
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse selection
		{
			get
			{
				return this.selectionField;
			}
			set
			{
				this.selectionField = value;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x000415D9 File Offset: 0x0003F7D9
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x000415E1 File Offset: 0x0003F7E1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool selectionSpecified
		{
			get
			{
				return this.selectionFieldSpecified;
			}
			set
			{
				this.selectionFieldSpecified = value;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x000415EA File Offset: 0x0003F7EA
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x000415F2 File Offset: 0x0003F7F2
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse grouping
		{
			get
			{
				return this.groupingField;
			}
			set
			{
				this.groupingField = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x000415FB File Offset: 0x0003F7FB
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x00041603 File Offset: 0x0003F803
		[global::System.Xml.Serialization.XmlIgnore]
		public bool groupingSpecified
		{
			get
			{
				return this.groupingFieldSpecified;
			}
			set
			{
				this.groupingFieldSpecified = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x0004160C File Offset: 0x0003F80C
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x00041614 File Offset: 0x0003F814
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse ungrouping
		{
			get
			{
				return this.ungroupingField;
			}
			set
			{
				this.ungroupingField = value;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x0004161D File Offset: 0x0003F81D
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x00041625 File Offset: 0x0003F825
		[global::System.Xml.Serialization.XmlIgnore]
		public bool ungroupingSpecified
		{
			get
			{
				return this.ungroupingFieldSpecified;
			}
			set
			{
				this.ungroupingFieldSpecified = value;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x0004162E File Offset: 0x0003F82E
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x00041636 File Offset: 0x0003F836
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse rotation
		{
			get
			{
				return this.rotationField;
			}
			set
			{
				this.rotationField = value;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x0004163F File Offset: 0x0003F83F
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x00041647 File Offset: 0x0003F847
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rotationSpecified
		{
			get
			{
				return this.rotationFieldSpecified;
			}
			set
			{
				this.rotationFieldSpecified = value;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00041650 File Offset: 0x0003F850
		// (set) Token: 0x060015B3 RID: 5555 RVA: 0x00041658 File Offset: 0x0003F858
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse cropping
		{
			get
			{
				return this.croppingField;
			}
			set
			{
				this.croppingField = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00041661 File Offset: 0x0003F861
		// (set) Token: 0x060015B5 RID: 5557 RVA: 0x00041669 File Offset: 0x0003F869
		[global::System.Xml.Serialization.XmlIgnore]
		public bool croppingSpecified
		{
			get
			{
				return this.croppingFieldSpecified;
			}
			set
			{
				this.croppingFieldSpecified = value;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x00041672 File Offset: 0x0003F872
		// (set) Token: 0x060015B7 RID: 5559 RVA: 0x0004167A File Offset: 0x0003F87A
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse verticies
		{
			get
			{
				return this.verticiesField;
			}
			set
			{
				this.verticiesField = value;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x00041683 File Offset: 0x0003F883
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x0004168B File Offset: 0x0003F88B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool verticiesSpecified
		{
			get
			{
				return this.verticiesFieldSpecified;
			}
			set
			{
				this.verticiesFieldSpecified = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00041694 File Offset: 0x0003F894
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x0004169C File Offset: 0x0003F89C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse adjusthandles
		{
			get
			{
				return this.adjusthandlesField;
			}
			set
			{
				this.adjusthandlesField = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x000416A5 File Offset: 0x0003F8A5
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x000416AD File Offset: 0x0003F8AD
		[global::System.Xml.Serialization.XmlIgnore]
		public bool adjusthandlesSpecified
		{
			get
			{
				return this.adjusthandlesFieldSpecified;
			}
			set
			{
				this.adjusthandlesFieldSpecified = value;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x000416B6 File Offset: 0x0003F8B6
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x000416BE File Offset: 0x0003F8BE
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x000416C7 File Offset: 0x0003F8C7
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x000416CF File Offset: 0x0003F8CF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool textSpecified
		{
			get
			{
				return this.textFieldSpecified;
			}
			set
			{
				this.textFieldSpecified = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x000416D8 File Offset: 0x0003F8D8
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x000416E0 File Offset: 0x0003F8E0
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse aspectratio
		{
			get
			{
				return this.aspectratioField;
			}
			set
			{
				this.aspectratioField = value;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x000416E9 File Offset: 0x0003F8E9
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x000416F1 File Offset: 0x0003F8F1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool aspectratioSpecified
		{
			get
			{
				return this.aspectratioFieldSpecified;
			}
			set
			{
				this.aspectratioFieldSpecified = value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x000416FA File Offset: 0x0003F8FA
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x00041702 File Offset: 0x0003F902
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse shapetype
		{
			get
			{
				return this.shapetypeField;
			}
			set
			{
				this.shapetypeField = value;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x0004170B File Offset: 0x0003F90B
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x00041713 File Offset: 0x0003F913
		[global::System.Xml.Serialization.XmlIgnore]
		public bool shapetypeSpecified
		{
			get
			{
				return this.shapetypeFieldSpecified;
			}
			set
			{
				this.shapetypeFieldSpecified = value;
			}
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0004171C File Offset: 0x0003F91C
		public static global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock ct_Lock = new global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock();
			if (node.Attributes["v:ext"] != null)
			{
				ct_Lock.ext = (global::NPOI.OpenXmlFormats.Vml.ST_Ext)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_Ext), node.Attributes["v:ext"].Value);
			}
			if (node.Attributes["position"] != null)
			{
				ct_Lock.position = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["position"]);
			}
			if (node.Attributes["selection"] != null)
			{
				ct_Lock.selection = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["selection"]);
			}
			if (node.Attributes["grouping"] != null)
			{
				ct_Lock.grouping = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["grouping"]);
			}
			if (node.Attributes["ungrouping"] != null)
			{
				ct_Lock.ungrouping = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["ungrouping"]);
			}
			if (node.Attributes["rotation"] != null)
			{
				ct_Lock.rotation = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["rotation"]);
			}
			if (node.Attributes["cropping"] != null)
			{
				ct_Lock.cropping = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["cropping"]);
			}
			if (node.Attributes["verticies"] != null)
			{
				ct_Lock.verticies = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["verticies"]);
			}
			if (node.Attributes["adjusthandles"] != null)
			{
				ct_Lock.adjusthandles = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["adjusthandles"]);
			}
			if (node.Attributes["text"] != null)
			{
				ct_Lock.text = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["text"]);
			}
			if (node.Attributes["aspectratio"] != null)
			{
				ct_Lock.aspectratio = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["aspectratio"]);
			}
			if (node.Attributes["shapetype"] != null)
			{
				ct_Lock.shapetype = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse(node.Attributes["shapetype"]);
			}
			return ct_Lock;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00041968 File Offset: 0x0003FB68
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<o:{0}", nodeName));
			if (this.ext != global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v:ext", this.ext.ToString());
			}
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "position", this.position);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "selection", this.selection);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "grouping", this.grouping);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "ungrouping", this.ungrouping);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "rotation", this.rotation);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "cropping", this.cropping);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "verticies", this.verticies);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "adjusthandles", this.adjusthandles);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "text", this.text);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "aspectratio", this.aspectratio);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "shapetype", this.shapetype);
			sw.Write("/>");
		}

		// Token: 0x0400112D RID: 4397
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x0400112E RID: 4398
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse positionField;

		// Token: 0x0400112F RID: 4399
		private bool positionFieldSpecified;

		// Token: 0x04001130 RID: 4400
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse selectionField;

		// Token: 0x04001131 RID: 4401
		private bool selectionFieldSpecified;

		// Token: 0x04001132 RID: 4402
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse groupingField;

		// Token: 0x04001133 RID: 4403
		private bool groupingFieldSpecified;

		// Token: 0x04001134 RID: 4404
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse ungroupingField;

		// Token: 0x04001135 RID: 4405
		private bool ungroupingFieldSpecified;

		// Token: 0x04001136 RID: 4406
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse rotationField;

		// Token: 0x04001137 RID: 4407
		private bool rotationFieldSpecified;

		// Token: 0x04001138 RID: 4408
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse croppingField;

		// Token: 0x04001139 RID: 4409
		private bool croppingFieldSpecified;

		// Token: 0x0400113A RID: 4410
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse verticiesField;

		// Token: 0x0400113B RID: 4411
		private bool verticiesFieldSpecified;

		// Token: 0x0400113C RID: 4412
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse adjusthandlesField;

		// Token: 0x0400113D RID: 4413
		private bool adjusthandlesFieldSpecified;

		// Token: 0x0400113E RID: 4414
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse textField;

		// Token: 0x0400113F RID: 4415
		private bool textFieldSpecified;

		// Token: 0x04001140 RID: 4416
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse aspectratioField;

		// Token: 0x04001141 RID: 4417
		private bool aspectratioFieldSpecified;

		// Token: 0x04001142 RID: 4418
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse shapetypeField;

		// Token: 0x04001143 RID: 4419
		private bool shapetypeFieldSpecified;
	}
}
