using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000575 RID: 1397
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_OutlinePr
	{
		// Token: 0x06003CCD RID: 15565 RVA: 0x00093C28 File Offset: 0x00091E28
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr
			{
				applyStyles = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["applyStyles"]),
				summaryBelow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["summaryBelow"]),
				summaryRight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["summaryRight"]),
				showOutlineSymbols = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showOutlineSymbols"])
			};
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00093CAC File Offset: 0x00091EAC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "applyStyles", this.applyStyles);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "summaryBelow", this.summaryBelow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "summaryRight", this.summaryRight);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showOutlineSymbols", this.showOutlineSymbols);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x00093D2A File Offset: 0x00091F2A
		public CT_OutlinePr()
		{
			this.applyStylesField = false;
			this.summaryBelowField = true;
			this.summaryRightField = true;
			this.showOutlineSymbolsField = true;
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x00093D4E File Offset: 0x00091F4E
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr Clone()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_OutlinePr
			{
				applyStylesField = this.applyStylesField,
				showOutlineSymbolsField = this.showOutlineSymbolsField,
				summaryBelowField = this.summaryBelowField,
				summaryRightField = this.summaryRightField
			};
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x00093D85 File Offset: 0x00091F85
		// (set) Token: 0x06003CD2 RID: 15570 RVA: 0x00093D8D File Offset: 0x00091F8D
		[global::System.ComponentModel.DefaultValue(false)]
		public bool applyStyles
		{
			get
			{
				return this.applyStylesField;
			}
			set
			{
				this.applyStylesField = value;
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x00093D96 File Offset: 0x00091F96
		// (set) Token: 0x06003CD4 RID: 15572 RVA: 0x00093D9E File Offset: 0x00091F9E
		[global::System.ComponentModel.DefaultValue(true)]
		public bool summaryBelow
		{
			get
			{
				return this.summaryBelowField;
			}
			set
			{
				this.summaryBelowField = value;
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06003CD5 RID: 15573 RVA: 0x00093DA7 File Offset: 0x00091FA7
		// (set) Token: 0x06003CD6 RID: 15574 RVA: 0x00093DAF File Offset: 0x00091FAF
		[global::System.ComponentModel.DefaultValue(true)]
		public bool summaryRight
		{
			get
			{
				return this.summaryRightField;
			}
			set
			{
				this.summaryRightField = value;
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06003CD7 RID: 15575 RVA: 0x00093DB8 File Offset: 0x00091FB8
		// (set) Token: 0x06003CD8 RID: 15576 RVA: 0x00093DC0 File Offset: 0x00091FC0
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showOutlineSymbols
		{
			get
			{
				return this.showOutlineSymbolsField;
			}
			set
			{
				this.showOutlineSymbolsField = value;
			}
		}

		// Token: 0x040026E7 RID: 9959
		private bool applyStylesField;

		// Token: 0x040026E8 RID: 9960
		private bool summaryBelowField;

		// Token: 0x040026E9 RID: 9961
		private bool summaryRightField;

		// Token: 0x040026EA RID: 9962
		private bool showOutlineSymbolsField;
	}
}
