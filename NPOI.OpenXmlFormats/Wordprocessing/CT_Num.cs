using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000AB RID: 171
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Num
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x0000D51C File Offset: 0x0000B71C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ct_Num = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num();
			ct_Num.numId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:numId"]);
			ct_Num.lvlOverride = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "abstractNumId")
				{
					ct_Num.abstractNumId = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvlOverride")
				{
					ct_Num.lvlOverride.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Num;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000D5E8 File Offset: 0x0000B7E8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:numId", this.numId);
			sw.Write(">");
			if (this.abstractNumId != null)
			{
				this.abstractNumId.Write(sw, "abstractNumId");
			}
			if (this.lvlOverride != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl ct_NumLvl in this.lvlOverride)
				{
					ct_NumLvl.Write(sw, "lvlOverride");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber abstractNumId
		{
			get
			{
				return this.abstractNumIdField;
			}
			set
			{
				this.abstractNumIdField = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0000D6B1 File Offset: 0x0000B8B1
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x0000D6B9 File Offset: 0x0000B8B9
		[global::System.Xml.Serialization.XmlElement("lvlOverride", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl> lvlOverride
		{
			get
			{
				return this.lvlOverrideField;
			}
			set
			{
				this.lvlOverrideField = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0000D6C2 File Offset: 0x0000B8C2
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x0000D6CA File Offset: 0x0000B8CA
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string numId
		{
			get
			{
				return this.numIdField;
			}
			set
			{
				this.numIdField = value;
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0000D6D3 File Offset: 0x0000B8D3
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber AddNewAbstractNumId()
		{
			if (this.abstractNumIdField == null)
			{
				this.abstractNumIdField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			}
			return this.abstractNumIdField;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000D6EE File Offset: 0x0000B8EE
		public int SizeOfLvlOverrideArray()
		{
			if (this.lvlOverrideField != null)
			{
				return this.lvlOverrideField.Count;
			}
			return 0;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000D705 File Offset: 0x0000B905
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl GetLvlOverrideArray(int i)
		{
			if (this.lvlOverrideField != null)
			{
				return this.lvlOverrideField[i];
			}
			return null;
		}

		// Token: 0x0400041D RID: 1053
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber abstractNumIdField;

		// Token: 0x0400041E RID: 1054
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumLvl> lvlOverrideField;

		// Token: 0x0400041F RID: 1055
		private string numIdField;
	}
}
