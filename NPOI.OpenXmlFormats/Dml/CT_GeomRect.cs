using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002E1 RID: 737
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GeomRect
	{
		// Token: 0x06001CAE RID: 7342 RVA: 0x0004E588 File Offset: 0x0004C788
		public static global::NPOI.OpenXmlFormats.Dml.CT_GeomRect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_GeomRect
			{
				l = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["l"]),
				t = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["t"]),
				r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r"]),
				b = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["b"])
			};
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0004E60C File Offset: 0x0004C80C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "l", this.l);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "t", this.t);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.r);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "b", this.b);
			sw.Write("/>");
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0004E679 File Offset: 0x0004C879
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x0004E681 File Offset: 0x0004C881
		[global::System.Xml.Serialization.XmlAttribute]
		public string l
		{
			get
			{
				return this.lField;
			}
			set
			{
				this.lField = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0004E68A File Offset: 0x0004C88A
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x0004E692 File Offset: 0x0004C892
		[global::System.Xml.Serialization.XmlAttribute]
		public string t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x0004E69B File Offset: 0x0004C89B
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0004E6A3 File Offset: 0x0004C8A3
		[global::System.Xml.Serialization.XmlAttribute]
		public string r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0004E6AC File Offset: 0x0004C8AC
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x0004E6B4 File Offset: 0x0004C8B4
		[global::System.Xml.Serialization.XmlAttribute]
		public string b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
			}
		}

		// Token: 0x04001738 RID: 5944
		private string lField;

		// Token: 0x04001739 RID: 5945
		private string tField;

		// Token: 0x0400173A RID: 5946
		private string rField;

		// Token: 0x0400173B RID: 5947
		private string bField;
	}
}
