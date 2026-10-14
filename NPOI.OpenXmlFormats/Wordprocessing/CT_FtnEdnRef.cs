using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200012A RID: 298
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FtnEdnRef
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x0001B47D File Offset: 0x0001967D
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0001B485 File Offset: 0x00019685
		public global::System.Xml.XmlNode DomNode { get; set; }

		// Token: 0x06000810 RID: 2064 RVA: 0x0001B490 File Offset: 0x00019690
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef ct_FtnEdnRef = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef();
			if (node.Attributes["w:customMarkFollows"] != null)
			{
				ct_FtnEdnRef.customMarkFollows = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:customMarkFollows"].Value, true);
			}
			ct_FtnEdnRef.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"]);
			ct_FtnEdnRef.DomNode = node;
			return ct_FtnEdnRef;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0001B510 File Offset: 0x00019710
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:customMarkFollows", this.customMarkFollows.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0001B57A File Offset: 0x0001977A
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x0001B582 File Offset: 0x00019782
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff customMarkFollows
		{
			get
			{
				return this.customMarkFollowsField;
			}
			set
			{
				this.customMarkFollowsField = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0001B58B File Offset: 0x0001978B
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x0001B593 File Offset: 0x00019793
		[global::System.Xml.Serialization.XmlIgnore]
		public bool customMarkFollowsSpecified
		{
			get
			{
				return this.customMarkFollowsFieldSpecified;
			}
			set
			{
				this.customMarkFollowsFieldSpecified = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0001B59C File Offset: 0x0001979C
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x0001B5A4 File Offset: 0x000197A4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x04000735 RID: 1845
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff customMarkFollowsField;

		// Token: 0x04000736 RID: 1846
		private bool customMarkFollowsFieldSpecified;

		// Token: 0x04000737 RID: 1847
		private string idField;
	}
}
