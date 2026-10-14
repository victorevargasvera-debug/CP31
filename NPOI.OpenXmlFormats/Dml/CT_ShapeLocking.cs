using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002FF RID: 767
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ShapeLocking
	{
		// Token: 0x06001DE4 RID: 7652 RVA: 0x00050FA0 File Offset: 0x0004F1A0
		public static global::NPOI.OpenXmlFormats.Dml.CT_ShapeLocking Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ShapeLocking ct_ShapeLocking = new global::NPOI.OpenXmlFormats.Dml.CT_ShapeLocking();
			ct_ShapeLocking.noGrp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noGrp"]);
			ct_ShapeLocking.noSelect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noSelect"]);
			ct_ShapeLocking.noRot = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noRot"]);
			ct_ShapeLocking.noChangeAspect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeAspect"]);
			ct_ShapeLocking.noMove = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noMove"]);
			ct_ShapeLocking.noResize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noResize"]);
			ct_ShapeLocking.noEditPoints = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noEditPoints"]);
			ct_ShapeLocking.noAdjustHandles = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noAdjustHandles"]);
			ct_ShapeLocking.noChangeArrowheads = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeArrowheads"]);
			ct_ShapeLocking.noChangeShapeType = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeShapeType"]);
			ct_ShapeLocking.noTextEdit = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noTextEdit"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_ShapeLocking.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ShapeLocking;
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00051148 File Offset: 0x0004F348
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noGrp", this.noGrp, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noSelect", this.noSelect, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noRot", this.noRot, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noChangeAspect", this.noChangeAspect, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noMove", this.noMove, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noResize", this.noResize, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noEditPoints", this.noEditPoints, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noAdjustHandles", this.noAdjustHandles, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noChangeArrowheads", this.noChangeArrowheads, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noChangeShapeType", this.noChangeShapeType, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noTextEdit", this.noTextEdit, false);
			if (this.extLst == null)
			{
				sw.Write("/>");
				return;
			}
			sw.Write(">");
			this.extLst.Write(sw, "extLst");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00051270 File Offset: 0x0004F470
		public CT_ShapeLocking()
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
			this.noTextEditField = false;
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000512D0 File Offset: 0x0004F4D0
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x000512D8 File Offset: 0x0004F4D8
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

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x000512E1 File Offset: 0x0004F4E1
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x000512E9 File Offset: 0x0004F4E9
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

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x000512F2 File Offset: 0x0004F4F2
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x000512FA File Offset: 0x0004F4FA
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

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x00051303 File Offset: 0x0004F503
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x0005130B File Offset: 0x0004F50B
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

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00051314 File Offset: 0x0004F514
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x0005131C File Offset: 0x0004F51C
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

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00051325 File Offset: 0x0004F525
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x0005132D File Offset: 0x0004F52D
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

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x00051336 File Offset: 0x0004F536
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x0005133E File Offset: 0x0004F53E
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

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x00051347 File Offset: 0x0004F547
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x0005134F File Offset: 0x0004F54F
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

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00051358 File Offset: 0x0004F558
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x00051360 File Offset: 0x0004F560
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

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00051369 File Offset: 0x0004F569
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x00051371 File Offset: 0x0004F571
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

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x0005137A File Offset: 0x0004F57A
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x00051382 File Offset: 0x0004F582
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

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0005138B File Offset: 0x0004F58B
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x00051393 File Offset: 0x0004F593
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noTextEdit
		{
			get
			{
				return this.noTextEditField;
			}
			set
			{
				this.noTextEditField = value;
			}
		}

		// Token: 0x040017B9 RID: 6073
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040017BA RID: 6074
		private bool noGrpField;

		// Token: 0x040017BB RID: 6075
		private bool noSelectField;

		// Token: 0x040017BC RID: 6076
		private bool noRotField;

		// Token: 0x040017BD RID: 6077
		private bool noChangeAspectField;

		// Token: 0x040017BE RID: 6078
		private bool noMoveField;

		// Token: 0x040017BF RID: 6079
		private bool noResizeField;

		// Token: 0x040017C0 RID: 6080
		private bool noEditPointsField;

		// Token: 0x040017C1 RID: 6081
		private bool noAdjustHandlesField;

		// Token: 0x040017C2 RID: 6082
		private bool noChangeArrowheadsField;

		// Token: 0x040017C3 RID: 6083
		private bool noChangeShapeTypeField;

		// Token: 0x040017C4 RID: 6084
		private bool noTextEditField;
	}
}
