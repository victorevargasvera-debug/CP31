using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002F7 RID: 759
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PictureLocking
	{
		// Token: 0x06001D79 RID: 7545 RVA: 0x0004FED8 File Offset: 0x0004E0D8
		public CT_PictureLocking()
		{
			this.noGrpField = false;
			this.noSelectField = false;
			this.noRotField = false;
			this.noChangeAspectField = false;
			this.noMoveField = false;
			this.noResizeField = false;
			this.noEditPointsField = false;
			this.noAdjustHandlesField = false;
			this.noChangeArrowheadsField = false;
			this.noChangeShapeTypeField = false;
			this.noCropField = false;
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0004FF38 File Offset: 0x0004E138
		public static global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking ct_PictureLocking = new global::NPOI.OpenXmlFormats.Dml.CT_PictureLocking();
			ct_PictureLocking.noGrp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noGrp"]);
			ct_PictureLocking.noSelect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noSelect"]);
			ct_PictureLocking.noRot = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noRot"]);
			ct_PictureLocking.noChangeAspect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeAspect"]);
			ct_PictureLocking.noMove = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noMove"]);
			ct_PictureLocking.noResize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noResize"]);
			ct_PictureLocking.noEditPoints = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noEditPoints"]);
			ct_PictureLocking.noAdjustHandles = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noAdjustHandles"]);
			ct_PictureLocking.noChangeArrowheads = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeArrowheads"]);
			ct_PictureLocking.noChangeShapeType = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeShapeType"]);
			ct_PictureLocking.noCrop = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noCrop"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_PictureLocking.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PictureLocking;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x000500E0 File Offset: 0x0004E2E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			if (this.noGrp)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noGrp", this.noGrp);
			}
			if (this.noSelect)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noSelect", this.noSelect);
			}
			if (this.noRot)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noRot", this.noRot);
			}
			if (this.noChangeAspect)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noChangeAspect", this.noChangeAspect);
			}
			if (this.noMove)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noMove", this.noMove);
			}
			if (this.noResize)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noResize", this.noResize);
			}
			if (this.noEditPoints)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noEditPoints", this.noEditPoints);
			}
			if (this.noAdjustHandles)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noAdjustHandles", this.noAdjustHandles);
			}
			if (this.noChangeArrowheads)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noChangeArrowheads", this.noChangeArrowheads);
			}
			if (this.noChangeShapeType)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noChangeShapeType", this.noChangeShapeType);
			}
			if (this.noCrop)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noCrop", this.noCrop);
			}
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00050246 File Offset: 0x0004E446
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0005024E File Offset: 0x0004E44E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
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

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00050257 File Offset: 0x0004E457
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0005025F File Offset: 0x0004E45F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noGrp
		{
			get
			{
				return this.noGrpField;
			}
			set
			{
				this.noGrpField = value;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00050268 File Offset: 0x0004E468
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x00050270 File Offset: 0x0004E470
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noSelect
		{
			get
			{
				return this.noSelectField;
			}
			set
			{
				this.noSelectField = value;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x00050279 File Offset: 0x0004E479
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x00050281 File Offset: 0x0004E481
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noRot
		{
			get
			{
				return this.noRotField;
			}
			set
			{
				this.noRotField = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x0005028A File Offset: 0x0004E48A
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x00050292 File Offset: 0x0004E492
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noChangeAspect
		{
			get
			{
				return this.noChangeAspectField;
			}
			set
			{
				this.noChangeAspectField = value;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x0005029B File Offset: 0x0004E49B
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x000502A3 File Offset: 0x0004E4A3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noMove
		{
			get
			{
				return this.noMoveField;
			}
			set
			{
				this.noMoveField = value;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x000502AC File Offset: 0x0004E4AC
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x000502B4 File Offset: 0x0004E4B4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noResize
		{
			get
			{
				return this.noResizeField;
			}
			set
			{
				this.noResizeField = value;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x000502BD File Offset: 0x0004E4BD
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x000502C5 File Offset: 0x0004E4C5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noEditPoints
		{
			get
			{
				return this.noEditPointsField;
			}
			set
			{
				this.noEditPointsField = value;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x000502CE File Offset: 0x0004E4CE
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x000502D6 File Offset: 0x0004E4D6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noAdjustHandles
		{
			get
			{
				return this.noAdjustHandlesField;
			}
			set
			{
				this.noAdjustHandlesField = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x000502DF File Offset: 0x0004E4DF
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x000502E7 File Offset: 0x0004E4E7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noChangeArrowheads
		{
			get
			{
				return this.noChangeArrowheadsField;
			}
			set
			{
				this.noChangeArrowheadsField = value;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x000502F0 File Offset: 0x0004E4F0
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x000502F8 File Offset: 0x0004E4F8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noChangeShapeType
		{
			get
			{
				return this.noChangeShapeTypeField;
			}
			set
			{
				this.noChangeShapeTypeField = value;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x00050301 File Offset: 0x0004E501
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x00050309 File Offset: 0x0004E509
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noCrop
		{
			get
			{
				return this.noCropField;
			}
			set
			{
				this.noCropField = value;
			}
		}

		// Token: 0x04001791 RID: 6033
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001792 RID: 6034
		private bool noGrpField;

		// Token: 0x04001793 RID: 6035
		private bool noSelectField;

		// Token: 0x04001794 RID: 6036
		private bool noRotField;

		// Token: 0x04001795 RID: 6037
		private bool noChangeAspectField;

		// Token: 0x04001796 RID: 6038
		private bool noMoveField;

		// Token: 0x04001797 RID: 6039
		private bool noResizeField;

		// Token: 0x04001798 RID: 6040
		private bool noEditPointsField;

		// Token: 0x04001799 RID: 6041
		private bool noAdjustHandlesField;

		// Token: 0x0400179A RID: 6042
		private bool noChangeArrowheadsField;

		// Token: 0x0400179B RID: 6043
		private bool noChangeShapeTypeField;

		// Token: 0x0400179C RID: 6044
		private bool noCropField;
	}
}
