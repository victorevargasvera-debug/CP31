using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003FD RID: 1021
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LegendEntry
	{
		// Token: 0x060028DC RID: 10460 RVA: 0x00066E60 File Offset: 0x00065060
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendEntry Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendEntry ct_LegendEntry = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendEntry();
			ct_LegendEntry.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_LegendEntry.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "Item")
				{
					ct_LegendEntry.Item = new object();
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_LegendEntry.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_LegendEntry;
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x00066F30 File Offset: 0x00065130
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.idx != null)
			{
				this.idx.Write(sw, "idx");
			}
			if (this.Item != null)
			{
				sw.Write("<Item/>");
			}
			if (this.extLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
				{
					ct_Extension.Write(sw, "extLst");
				}
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x060028DE RID: 10462 RVA: 0x00066FE8 File Offset: 0x000651E8
		// (set) Token: 0x060028DF RID: 10463 RVA: 0x00066FF0 File Offset: 0x000651F0
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idx
		{
			get
			{
				return this.idxField;
			}
			set
			{
				this.idxField = value;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x060028E0 RID: 10464 RVA: 0x00066FF9 File Offset: 0x000651F9
		// (set) Token: 0x060028E1 RID: 10465 RVA: 0x00067001 File Offset: 0x00065201
		[global::System.Xml.Serialization.XmlElement("delete", typeof(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("txPr", typeof(global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x060028E2 RID: 10466 RVA: 0x0006700A File Offset: 0x0006520A
		// (set) Token: 0x060028E3 RID: 10467 RVA: 0x00067012 File Offset: 0x00065212
		[global::System.Xml.Serialization.XmlArray(Order = 2)]
		[global::System.Xml.Serialization.XmlArrayItem("ext", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLst
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

		// Token: 0x04001D9F RID: 7583
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001DA0 RID: 7584
		private object itemField;

		// Token: 0x04001DA1 RID: 7585
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
