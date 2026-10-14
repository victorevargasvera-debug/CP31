using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200047E RID: 1150
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("pivotCacheRecords", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public class CT_PivotCacheRecords
	{
		// Token: 0x06002DCC RID: 11724 RVA: 0x00072E18 File Offset: 0x00071018
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheRecords Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheRecords ct_PivotCacheRecords = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheRecords();
			if (node.Attributes["count"] != null)
			{
				ct_PivotCacheRecords.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_PivotCacheRecords.r = new global::System.Collections.Generic.List<object>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_PivotCacheRecords.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "n")
				{
					ct_PivotCacheRecords.r.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "b")
				{
					ct_PivotCacheRecords.r.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "d")
				{
					ct_PivotCacheRecords.r.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_PivotCacheRecords.r.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "m")
				{
					ct_PivotCacheRecords.r.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "s")
				{
					ct_PivotCacheRecords.r.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_String.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "x")
				{
					ct_PivotCacheRecords.r.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotCacheRecords;
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x00072FF8 File Offset: 0x000711F8
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<pivotCacheRecords xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" ");
			sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" ");
			sw.Write("xmlns:s=\"http://schemas.openxmlformats.org/officeDocument/2006/sharedTypes\" ");
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			foreach (object obj in this.r)
			{
				if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number)obj).Write(sw, "n");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean)obj).Write(sw, "b");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime)obj).Write(sw, "d");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error)obj).Write(sw, "e");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing)obj).Write(sw, "m");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_String)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_String)obj).Write(sw, "s");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index)obj).Write(sw, "x");
				}
			}
			sw.Write(string.Format("</pivotCacheRecords>", new object[0]));
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00073184 File Offset: 0x00071384
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.Write(streamWriter);
			}
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x000731BC File Offset: 0x000713BC
		public CT_PivotCacheRecords()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.rField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x000731DA File Offset: 0x000713DA
		// (set) Token: 0x06002DD1 RID: 11729 RVA: 0x000731E2 File Offset: 0x000713E2
		[global::System.Xml.Serialization.XmlArray(Order = 0)]
		[global::System.Xml.Serialization.XmlArrayItem("b", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean), IsNullable = false)]
		[global::System.Xml.Serialization.XmlArrayItem("d", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime), IsNullable = false)]
		[global::System.Xml.Serialization.XmlArrayItem("e", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error), IsNullable = false)]
		[global::System.Xml.Serialization.XmlArrayItem("m", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing), IsNullable = false)]
		[global::System.Xml.Serialization.XmlArrayItem("n", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number), IsNullable = false)]
		[global::System.Xml.Serialization.XmlArrayItem("s", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_String), IsNullable = false)]
		[global::System.Xml.Serialization.XmlArrayItem("x", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index), IsNullable = false)]
		public global::System.Collections.Generic.List<object> r
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

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x000731EB File Offset: 0x000713EB
		// (set) Token: 0x06002DD3 RID: 11731 RVA: 0x000731F3 File Offset: 0x000713F3
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
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

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06002DD4 RID: 11732 RVA: 0x000731FC File Offset: 0x000713FC
		// (set) Token: 0x06002DD5 RID: 11733 RVA: 0x00073204 File Offset: 0x00071404
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

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x0007320D File Offset: 0x0007140D
		// (set) Token: 0x06002DD7 RID: 11735 RVA: 0x00073215 File Offset: 0x00071415
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

		// Token: 0x04001FC1 RID: 8129
		private global::System.Collections.Generic.List<object> rField;

		// Token: 0x04001FC2 RID: 8130
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04001FC3 RID: 8131
		private uint countField;

		// Token: 0x04001FC4 RID: 8132
		private bool countFieldSpecified;
	}
}
