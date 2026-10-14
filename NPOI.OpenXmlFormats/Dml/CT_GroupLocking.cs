using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000300 RID: 768
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GroupLocking
	{
		// Token: 0x06001DFF RID: 7679 RVA: 0x0005139C File Offset: 0x0004F59C
		public CT_GroupLocking()
		{
			this.noGrpField = false;
			this.noUngrpField = false;
			this.noSelectField = false;
			this.noRotField = false;
			this.noChangeAspectField = false;
			this.noMoveField = false;
			this.noResizeField = false;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x000513D8 File Offset: 0x0004F5D8
		public static global::NPOI.OpenXmlFormats.Dml.CT_GroupLocking Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_GroupLocking ct_GroupLocking = new global::NPOI.OpenXmlFormats.Dml.CT_GroupLocking();
			ct_GroupLocking.noGrp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noGrp"]);
			ct_GroupLocking.noUngrp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noUngrp"]);
			ct_GroupLocking.noSelect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noSelect"]);
			ct_GroupLocking.noRot = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noRot"]);
			ct_GroupLocking.noChangeAspect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noChangeAspect"]);
			ct_GroupLocking.noMove = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noMove"]);
			ct_GroupLocking.noResize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noResize"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_GroupLocking.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GroupLocking;
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00051514 File Offset: 0x0004F714
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			if (this.noGrp)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noGrp", this.noGrp);
			}
			if (this.noUngrp)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noUngrp", this.noUngrp);
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
			sw.Write("/>");
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x000515EC File Offset: 0x0004F7EC
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x000515F4 File Offset: 0x0004F7F4
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

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x000515FD File Offset: 0x0004F7FD
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x00051605 File Offset: 0x0004F805
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

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x0005160E File Offset: 0x0004F80E
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x00051616 File Offset: 0x0004F816
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool noUngrp
		{
			get
			{
				return this.noUngrpField;
			}
			set
			{
				this.noUngrpField = value;
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x0005161F File Offset: 0x0004F81F
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x00051627 File Offset: 0x0004F827
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

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x00051630 File Offset: 0x0004F830
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x00051638 File Offset: 0x0004F838
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

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x00051641 File Offset: 0x0004F841
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x00051649 File Offset: 0x0004F849
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

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x00051652 File Offset: 0x0004F852
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x0005165A File Offset: 0x0004F85A
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

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x00051663 File Offset: 0x0004F863
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x0005166B File Offset: 0x0004F86B
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

		// Token: 0x040017C5 RID: 6085
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040017C6 RID: 6086
		private bool noGrpField;

		// Token: 0x040017C7 RID: 6087
		private bool noUngrpField;

		// Token: 0x040017C8 RID: 6088
		private bool noSelectField;

		// Token: 0x040017C9 RID: 6089
		private bool noRotField;

		// Token: 0x040017CA RID: 6090
		private bool noChangeAspectField;

		// Token: 0x040017CB RID: 6091
		private bool noMoveField;

		// Token: 0x040017CC RID: 6092
		private bool noResizeField;
	}
}
