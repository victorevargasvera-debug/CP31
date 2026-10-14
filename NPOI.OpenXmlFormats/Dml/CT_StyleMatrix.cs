using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000286 RID: 646
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_StyleMatrix
	{
		// Token: 0x06001AB9 RID: 6841 RVA: 0x000489B0 File Offset: 0x00046BB0
		public static global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrix Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrix ct_StyleMatrix = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrix();
			ct_StyleMatrix.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "fillStyleLst")
				{
					ct_StyleMatrix.fillStyleLst = global::NPOI.OpenXmlFormats.Dml.CT_FillStyleList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bgFillStyleLst")
				{
					ct_StyleMatrix.bgFillStyleLst = global::NPOI.OpenXmlFormats.Dml.CT_BackgroundFillStyleList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lnStyleLst")
				{
					ct_StyleMatrix.lnStyleLst = global::NPOI.OpenXmlFormats.Dml.CT_LineStyleList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effectStyleLst")
				{
					ct_StyleMatrix.effectStyleLst = global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_StyleMatrix;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x00048AB4 File Offset: 0x00046CB4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			sw.Write(">");
			if (this.fillStyleLst != null)
			{
				this.fillStyleLst.Write(sw, "fillStyleLst");
			}
			if (this.lnStyleLst != null)
			{
				this.lnStyleLst.Write(sw, "lnStyleLst");
			}
			if (this.effectStyleLst != null)
			{
				this.effectStyleLst.Write(sw, "effectStyleLst");
			}
			if (this.bgFillStyleLst != null)
			{
				this.bgFillStyleLst.Write(sw, "bgFillStyleLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00048B63 File Offset: 0x00046D63
		public CT_StyleMatrix()
		{
			this.nameField = "";
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00048B76 File Offset: 0x00046D76
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x00048B7E File Offset: 0x00046D7E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FillStyleList fillStyleLst
		{
			get
			{
				return this.fillStyleLstField;
			}
			set
			{
				this.fillStyleLstField = value;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00048B87 File Offset: 0x00046D87
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x00048B8F File Offset: 0x00046D8F
		[global::System.Xml.Serialization.XmlArray(Order = 1)]
		[global::System.Xml.Serialization.XmlArrayItem("ln", IsNullable = false)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineStyleList lnStyleLst
		{
			get
			{
				return this.lnStyleLstField;
			}
			set
			{
				this.lnStyleLstField = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x00048B98 File Offset: 0x00046D98
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x00048BA0 File Offset: 0x00046DA0
		[global::System.Xml.Serialization.XmlArray(Order = 2)]
		[global::System.Xml.Serialization.XmlArrayItem("effectStyle", IsNullable = false)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleList effectStyleLst
		{
			get
			{
				return this.effectStyleLstField;
			}
			set
			{
				this.effectStyleLstField = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x00048BA9 File Offset: 0x00046DA9
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x00048BB1 File Offset: 0x00046DB1
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_BackgroundFillStyleList bgFillStyleLst
		{
			get
			{
				return this.bgFillStyleLstField;
			}
			set
			{
				this.bgFillStyleLstField = value;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x00048BBA File Offset: 0x00046DBA
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x00048BC2 File Offset: 0x00046DC2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
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

		// Token: 0x040013DB RID: 5083
		private global::NPOI.OpenXmlFormats.Dml.CT_FillStyleList fillStyleLstField;

		// Token: 0x040013DC RID: 5084
		private global::NPOI.OpenXmlFormats.Dml.CT_LineStyleList lnStyleLstField;

		// Token: 0x040013DD RID: 5085
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleList effectStyleLstField;

		// Token: 0x040013DE RID: 5086
		private global::NPOI.OpenXmlFormats.Dml.CT_BackgroundFillStyleList bgFillStyleLstField;

		// Token: 0x040013DF RID: 5087
		private string nameField;
	}
}
