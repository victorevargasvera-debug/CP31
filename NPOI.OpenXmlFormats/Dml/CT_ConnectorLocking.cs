using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002F6 RID: 758
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ConnectorLocking
	{
		// Token: 0x06001D60 RID: 7520 RVA: 0x0004FB38 File Offset: 0x0004DD38
		public static global::NPOI.OpenXmlFormats.Dml.CT_ConnectorLocking Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ConnectorLocking ct_ConnectorLocking = new global::NPOI.OpenXmlFormats.Dml.CT_ConnectorLocking();
			ct_ConnectorLocking.noGrp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noGrp"]);
			ct_ConnectorLocking.noSelect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noSelect"]);
			ct_ConnectorLocking.noRot = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noRot"]);
			ct_ConnectorLocking.noChangeAspect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeAspect"]);
			ct_ConnectorLocking.noMove = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noMove"]);
			ct_ConnectorLocking.noResize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noResize"]);
			ct_ConnectorLocking.noEditPoints = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noEditPoints"]);
			ct_ConnectorLocking.noAdjustHandles = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noAdjustHandles"]);
			ct_ConnectorLocking.noChangeArrowheads = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeArrowheads"]);
			ct_ConnectorLocking.noChangeShapeType = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeShapeType"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_ConnectorLocking.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ConnectorLocking;
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x0004FCC4 File Offset: 0x0004DEC4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noGrp", this.noGrp);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noSelect", this.noSelect);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noRot", this.noRot);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noChangeAspect", this.noChangeAspect);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noMove", this.noMove);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noResize", this.noResize);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noEditPoints", this.noEditPoints);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noAdjustHandles", this.noAdjustHandles);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noChangeArrowheads", this.noChangeArrowheads);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noChangeShapeType", this.noChangeShapeType);
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x0004FDC4 File Offset: 0x0004DFC4
		public CT_ConnectorLocking()
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
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x0004FE1D File Offset: 0x0004E01D
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x0004FE25 File Offset: 0x0004E025
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

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0004FE2E File Offset: 0x0004E02E
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x0004FE36 File Offset: 0x0004E036
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

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x0004FE3F File Offset: 0x0004E03F
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x0004FE47 File Offset: 0x0004E047
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

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x0004FE50 File Offset: 0x0004E050
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x0004FE58 File Offset: 0x0004E058
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

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x0004FE61 File Offset: 0x0004E061
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x0004FE69 File Offset: 0x0004E069
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

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0004FE72 File Offset: 0x0004E072
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x0004FE7A File Offset: 0x0004E07A
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

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x0004FE83 File Offset: 0x0004E083
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x0004FE8B File Offset: 0x0004E08B
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

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x0004FE94 File Offset: 0x0004E094
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x0004FE9C File Offset: 0x0004E09C
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

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0004FEA5 File Offset: 0x0004E0A5
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0004FEAD File Offset: 0x0004E0AD
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

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x0004FEB6 File Offset: 0x0004E0B6
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x0004FEBE File Offset: 0x0004E0BE
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

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x0004FEC7 File Offset: 0x0004E0C7
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x0004FECF File Offset: 0x0004E0CF
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

		// Token: 0x04001786 RID: 6022
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001787 RID: 6023
		private bool noGrpField;

		// Token: 0x04001788 RID: 6024
		private bool noSelectField;

		// Token: 0x04001789 RID: 6025
		private bool noRotField;

		// Token: 0x0400178A RID: 6026
		private bool noChangeAspectField;

		// Token: 0x0400178B RID: 6027
		private bool noMoveField;

		// Token: 0x0400178C RID: 6028
		private bool noResizeField;

		// Token: 0x0400178D RID: 6029
		private bool noEditPointsField;

		// Token: 0x0400178E RID: 6030
		private bool noAdjustHandlesField;

		// Token: 0x0400178F RID: 6031
		private bool noChangeArrowheadsField;

		// Token: 0x04001790 RID: 6032
		private bool noChangeShapeTypeField;
	}
}
