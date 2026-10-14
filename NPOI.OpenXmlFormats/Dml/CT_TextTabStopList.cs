using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000260 RID: 608
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextTabStopList
	{
		// Token: 0x060018AE RID: 6318 RVA: 0x000442E5 File Offset: 0x000424E5
		public CT_TextTabStopList()
		{
			this.tabField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop>();
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x000442F8 File Offset: 0x000424F8
		// (set) Token: 0x060018B0 RID: 6320 RVA: 0x00044300 File Offset: 0x00042500
		[global::System.Xml.Serialization.XmlElement("tab", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop> tab
		{
			get
			{
				return this.tabField;
			}
			set
			{
				this.tabField = value;
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0004430C File Offset: 0x0004250C
		internal void Write(global::System.IO.StreamWriter sw, string p)
		{
			sw.Write("<a:{0}>", p);
			if (this.tab != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop ct_TextTabStop in this.tab)
				{
					ct_TextTabStop.Write(sw, "tab");
				}
			}
			sw.Write("</a:{0}>", p);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00044384 File Offset: 0x00042584
		internal static global::NPOI.OpenXmlFormats.Dml.CT_TextTabStopList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_TextTabStopList ct_TextTabStopList = new global::NPOI.OpenXmlFormats.Dml.CT_TextTabStopList();
			ct_TextTabStopList.tab = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop>();
			foreach (object obj in node)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tab")
				{
					ct_TextTabStopList.tab.Add(global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_TextTabStopList;
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00044408 File Offset: 0x00042608
		public global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop AddNewTab()
		{
			this.tabField.Add(new global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop());
			return this.tabField[this.tabField.Count - 1];
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00044432 File Offset: 0x00042632
		public int SizeOfTabArray()
		{
			return this.tabField.Count;
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0004443F File Offset: 0x0004263F
		public global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop GetTabArray(int idx)
		{
			return this.tabField[idx];
		}

		// Token: 0x040012D5 RID: 4821
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextTabStop> tabField;
	}
}
