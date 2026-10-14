using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002F8 RID: 760
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GraphicalObjectFrameLocking
	{
		// Token: 0x06001D94 RID: 7572 RVA: 0x00050312 File Offset: 0x0004E512
		public CT_GraphicalObjectFrameLocking()
		{
			this.noGrpField = false;
			this.noDrilldownField = false;
			this.noSelectField = false;
			this.noChangeAspectField = false;
			this.noMoveField = false;
			this.noResizeField = false;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00050344 File Offset: 0x0004E544
		public static global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectFrameLocking Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectFrameLocking ct_GraphicalObjectFrameLocking = new global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectFrameLocking();
			ct_GraphicalObjectFrameLocking.noGrp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noGrp"]);
			ct_GraphicalObjectFrameLocking.noDrilldown = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noDrilldown"]);
			ct_GraphicalObjectFrameLocking.noSelect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noSelect"]);
			ct_GraphicalObjectFrameLocking.noChangeAspect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeAspect"]);
			ct_GraphicalObjectFrameLocking.noMove = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noMove"]);
			ct_GraphicalObjectFrameLocking.noResize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noResize"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_GraphicalObjectFrameLocking.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GraphicalObjectFrameLocking;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00050464 File Offset: 0x0004E664
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0} xmlns:a=\"http://schemas.openxmlformats.org/drawingml/2006/main\"", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noGrp", this.noGrp, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noDrilldown", this.noDrilldown, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noSelect", this.noSelect, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noChangeAspect", this.noChangeAspect, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noMove", this.noMove, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noResize", this.noResize, false);
			if (this.extLst != null && this.extLst.ext.Count != 0)
			{
				sw.Write(">");
				this.extLst.Write(sw, "extLst");
				sw.Write(string.Format("</a:{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00050541 File Offset: 0x0004E741
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x00050549 File Offset: 0x0004E749
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

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x00050552 File Offset: 0x0004E752
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x0005055A File Offset: 0x0004E75A
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

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00050563 File Offset: 0x0004E763
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0005056B File Offset: 0x0004E76B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noDrilldown
		{
			get
			{
				return this.noDrilldownField;
			}
			set
			{
				this.noDrilldownField = value;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x00050574 File Offset: 0x0004E774
		// (set) Token: 0x06001D9E RID: 7582 RVA: 0x0005057C File Offset: 0x0004E77C
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

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x00050585 File Offset: 0x0004E785
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0005058D File Offset: 0x0004E78D
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

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x00050596 File Offset: 0x0004E796
		// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x0005059E File Offset: 0x0004E79E
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

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x000505A7 File Offset: 0x0004E7A7
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x000505AF File Offset: 0x0004E7AF
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

		// Token: 0x0400179D RID: 6045
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x0400179E RID: 6046
		private bool noGrpField;

		// Token: 0x0400179F RID: 6047
		private bool noDrilldownField;

		// Token: 0x040017A0 RID: 6048
		private bool noSelectField;

		// Token: 0x040017A1 RID: 6049
		private bool noChangeAspectField;

		// Token: 0x040017A2 RID: 6050
		private bool noMoveField;

		// Token: 0x040017A3 RID: 6051
		private bool noResizeField;
	}
}
