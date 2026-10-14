using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000284 RID: 644
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EffectStyleList
	{
		// Token: 0x06001AA5 RID: 6821 RVA: 0x00048478 File Offset: 0x00046678
		public CT_EffectStyleList()
		{
			this.effectStyleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleItem>();
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0004848B File Offset: 0x0004668B
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x00048493 File Offset: 0x00046693
		[global::System.Xml.Serialization.XmlElement("effectStyle", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleItem> effectStyle
		{
			get
			{
				return this.effectStyleField;
			}
			set
			{
				this.effectStyleField = value;
			}
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0004849C File Offset: 0x0004669C
		public static global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleList ct_EffectStyleList = new global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleList();
			ct_EffectStyleList.effectStyle = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleItem>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj;
				ct_EffectStyleList.effectStyle.Add(global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleItem.Parse(node2, namespaceManager));
			}
			return ct_EffectStyleList;
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00048518 File Offset: 0x00046718
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}>", nodeName));
			if (this.effectStyle.Count > 0)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleItem ct_EffectStyleItem in this.effectStyle)
				{
					ct_EffectStyleItem.Write(sw, "effectStyle");
				}
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x040013D4 RID: 5076
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_EffectStyleItem> effectStyleField;
	}
}
