using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000EE RID: 238
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PTab
	{
		// Token: 0x060006B1 RID: 1713 RVA: 0x00015618 File Offset: 0x00013818
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab ct_PTab = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab();
			if (node.Attributes["w:alignment"] != null)
			{
				ct_PTab.alignment = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabAlignment)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabAlignment), node.Attributes["w:alignment"].Value);
			}
			if (node.Attributes["w:relativeTo"] != null)
			{
				ct_PTab.relativeTo = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabRelativeTo)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabRelativeTo), node.Attributes["w:relativeTo"].Value);
			}
			if (node.Attributes["w:leader"] != null)
			{
				ct_PTab.leader = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabLeader)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabLeader), node.Attributes["w:leader"].Value);
			}
			return ct_PTab;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000156F4 File Offset: 0x000138F4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:alignment", this.alignment.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:relativeTo", this.relativeTo.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:leader", this.leader.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0001578B File Offset: 0x0001398B
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00015793 File Offset: 0x00013993
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabAlignment alignment
		{
			get
			{
				return this.alignmentField;
			}
			set
			{
				this.alignmentField = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0001579C File Offset: 0x0001399C
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x000157A4 File Offset: 0x000139A4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabRelativeTo relativeTo
		{
			get
			{
				return this.relativeToField;
			}
			set
			{
				this.relativeToField = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000157AD File Offset: 0x000139AD
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x000157B5 File Offset: 0x000139B5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabLeader leader
		{
			get
			{
				return this.leaderField;
			}
			set
			{
				this.leaderField = value;
			}
		}

		// Token: 0x040005C3 RID: 1475
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabAlignment alignmentField;

		// Token: 0x040005C4 RID: 1476
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabRelativeTo relativeToField;

		// Token: 0x040005C5 RID: 1477
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_PTabLeader leaderField;
	}
}
