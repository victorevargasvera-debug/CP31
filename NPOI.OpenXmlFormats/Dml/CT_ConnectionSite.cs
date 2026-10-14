using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002E4 RID: 740
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ConnectionSite
	{
		// Token: 0x06001CD7 RID: 7383 RVA: 0x0004E7AC File Offset: 0x0004C9AC
		public static global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSite Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSite ct_ConnectionSite = new global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSite();
			ct_ConnectionSite.ang = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ang"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pos")
				{
					ct_ConnectionSite.pos = global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ConnectionSite;
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0004E844 File Offset: 0x0004CA44
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ang", this.ang);
			sw.Write(">");
			if (this.pos != null)
			{
				this.pos.Write(sw, "pos");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x0004E8A8 File Offset: 0x0004CAA8
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x0004E8B0 File Offset: 0x0004CAB0
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x0004E8B9 File Offset: 0x0004CAB9
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x0004E8C1 File Offset: 0x0004CAC1
		[global::System.Xml.Serialization.XmlAttribute]
		public string ang
		{
			get
			{
				return this.angField;
			}
			set
			{
				this.angField = value;
			}
		}

		// Token: 0x0400174A RID: 5962
		private global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D posField;

		// Token: 0x0400174B RID: 5963
		private string angField;
	}
}
