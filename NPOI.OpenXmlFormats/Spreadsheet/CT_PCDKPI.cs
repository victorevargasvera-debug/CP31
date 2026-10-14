using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004A5 RID: 1189
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PCDKPI
	{
		// Token: 0x0600309D RID: 12445 RVA: 0x00079D6C File Offset: 0x00077F6C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPI Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPI
			{
				uniqueName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uniqueName"]),
				caption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["caption"]),
				displayFolder = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["displayFolder"]),
				measureGroup = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["measureGroup"]),
				parent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["parent"]),
				value = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["value"]),
				goal = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["goal"]),
				status = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["status"]),
				trend = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["trend"]),
				weight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["weight"]),
				time = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["time"])
			};
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x00079EAC File Offset: 0x000780AC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "caption", this.caption);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "displayFolder", this.displayFolder);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "measureGroup", this.measureGroup);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "parent", this.parent);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "value", this.value);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "goal", this.goal);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "status", this.status);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "trend", this.trend);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "weight", this.weight);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "time", this.time);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x00079FA1 File Offset: 0x000781A1
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x00079FA9 File Offset: 0x000781A9
		[global::System.Xml.Serialization.XmlAttribute]
		public string uniqueName
		{
			get
			{
				return this.uniqueNameField;
			}
			set
			{
				this.uniqueNameField = value;
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x00079FB2 File Offset: 0x000781B2
		// (set) Token: 0x060030A2 RID: 12450 RVA: 0x00079FBA File Offset: 0x000781BA
		[global::System.Xml.Serialization.XmlAttribute]
		public string caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x00079FC3 File Offset: 0x000781C3
		// (set) Token: 0x060030A4 RID: 12452 RVA: 0x00079FCB File Offset: 0x000781CB
		[global::System.Xml.Serialization.XmlAttribute]
		public string displayFolder
		{
			get
			{
				return this.displayFolderField;
			}
			set
			{
				this.displayFolderField = value;
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x00079FD4 File Offset: 0x000781D4
		// (set) Token: 0x060030A6 RID: 12454 RVA: 0x00079FDC File Offset: 0x000781DC
		[global::System.Xml.Serialization.XmlAttribute]
		public string measureGroup
		{
			get
			{
				return this.measureGroupField;
			}
			set
			{
				this.measureGroupField = value;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x060030A7 RID: 12455 RVA: 0x00079FE5 File Offset: 0x000781E5
		// (set) Token: 0x060030A8 RID: 12456 RVA: 0x00079FED File Offset: 0x000781ED
		[global::System.Xml.Serialization.XmlAttribute]
		public string parent
		{
			get
			{
				return this.parentField;
			}
			set
			{
				this.parentField = value;
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x00079FF6 File Offset: 0x000781F6
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x00079FFE File Offset: 0x000781FE
		[global::System.Xml.Serialization.XmlAttribute]
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x0007A007 File Offset: 0x00078207
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x0007A00F File Offset: 0x0007820F
		[global::System.Xml.Serialization.XmlAttribute]
		public string goal
		{
			get
			{
				return this.goalField;
			}
			set
			{
				this.goalField = value;
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x0007A018 File Offset: 0x00078218
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x0007A020 File Offset: 0x00078220
		[global::System.Xml.Serialization.XmlAttribute]
		public string status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x0007A029 File Offset: 0x00078229
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x0007A031 File Offset: 0x00078231
		[global::System.Xml.Serialization.XmlAttribute]
		public string trend
		{
			get
			{
				return this.trendField;
			}
			set
			{
				this.trendField = value;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x0007A03A File Offset: 0x0007823A
		// (set) Token: 0x060030B2 RID: 12466 RVA: 0x0007A042 File Offset: 0x00078242
		[global::System.Xml.Serialization.XmlAttribute]
		public string weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x0007A04B File Offset: 0x0007824B
		// (set) Token: 0x060030B4 RID: 12468 RVA: 0x0007A053 File Offset: 0x00078253
		[global::System.Xml.Serialization.XmlAttribute]
		public string time
		{
			get
			{
				return this.timeField;
			}
			set
			{
				this.timeField = value;
			}
		}

		// Token: 0x040020FC RID: 8444
		private string uniqueNameField;

		// Token: 0x040020FD RID: 8445
		private string captionField;

		// Token: 0x040020FE RID: 8446
		private string displayFolderField;

		// Token: 0x040020FF RID: 8447
		private string measureGroupField;

		// Token: 0x04002100 RID: 8448
		private string parentField;

		// Token: 0x04002101 RID: 8449
		private string valueField;

		// Token: 0x04002102 RID: 8450
		private string goalField;

		// Token: 0x04002103 RID: 8451
		private string statusField;

		// Token: 0x04002104 RID: 8452
		private string trendField;

		// Token: 0x04002105 RID: 8453
		private string weightField;

		// Token: 0x04002106 RID: 8454
		private string timeField;
	}
}
