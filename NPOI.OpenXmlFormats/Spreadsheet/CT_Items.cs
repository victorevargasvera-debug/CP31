using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004BD RID: 1213
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Items
	{
		// Token: 0x060032C5 RID: 12997 RVA: 0x0007F294 File Offset: 0x0007D494
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items ct_Items = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Items();
			if (node.Attributes["count"] != null)
			{
				ct_Items.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_Items.item = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "item")
				{
					ct_Items.item.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Items;
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x0007F350 File Offset: 0x0007D550
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.item != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item ct_Item in this.item)
				{
					ct_Item.Write(sw, "item");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x0007F3F0 File Offset: 0x0007D5F0
		public CT_Items()
		{
			this.itemField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item>();
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x0007F403 File Offset: 0x0007D603
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x0007F40B File Offset: 0x0007D60B
		[global::System.Xml.Serialization.XmlElement("item", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item> item
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

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x0007F414 File Offset: 0x0007D614
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x0007F41C File Offset: 0x0007D61C
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x0007F425 File Offset: 0x0007D625
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x0007F42D File Offset: 0x0007D62D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x0007F438 File Offset: 0x0007D638
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item AddNewItem()
		{
			if (this.itemField == null)
			{
				this.itemField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item ct_Item = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item();
			this.itemField.Add(ct_Item);
			return ct_Item;
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x0007F46B File Offset: 0x0007D66B
		public uint SizeOfItemArray()
		{
			if (this.itemField == null)
			{
				this.itemField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item>();
			}
			return (uint)this.itemField.Count;
		}

		// Token: 0x040021EF RID: 8687
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item> itemField;

		// Token: 0x040021F0 RID: 8688
		private uint countField;

		// Token: 0x040021F1 RID: 8689
		private bool countFieldSpecified;
	}
}
