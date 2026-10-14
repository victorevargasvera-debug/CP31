using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000414 RID: 1044
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Tx
	{
		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x00069124 File Offset: 0x00067324
		// (set) Token: 0x060029C6 RID: 10694 RVA: 0x0006912C File Offset: 0x0006732C
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef strRef
		{
			get
			{
				return this.strRefField;
			}
			set
			{
				this.strRefField = value;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x00069135 File Offset: 0x00067335
		// (set) Token: 0x060029C8 RID: 10696 RVA: 0x0006913D File Offset: 0x0006733D
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody rich
		{
			get
			{
				return this.richField;
			}
			set
			{
				this.richField = value;
			}
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00069148 File Offset: 0x00067348
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx ct_Tx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "strRef")
				{
					ct_Tx.strRef = global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rich")
				{
					ct_Tx.rich = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Tx;
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000691E8 File Offset: 0x000673E8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.strRef != null)
			{
				this.strRef.Write(sw, "strRef");
			}
			if (this.rich != null)
			{
				this.rich.Write(sw, "rich");
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00069254 File Offset: 0x00067454
		public bool IsSetStrRef()
		{
			return this.strRefField != null;
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x0006925F File Offset: 0x0006745F
		public void UnsetStrRef()
		{
			this.strRefField = null;
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00069268 File Offset: 0x00067468
		public bool IsSetRich()
		{
			return this.rich != null;
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00069273 File Offset: 0x00067473
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody AddNewRich()
		{
			this.richField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody();
			return this.richField;
		}

		// Token: 0x04001DFB RID: 7675
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef strRefField;

		// Token: 0x04001DFC RID: 7676
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody richField;
	}
}
