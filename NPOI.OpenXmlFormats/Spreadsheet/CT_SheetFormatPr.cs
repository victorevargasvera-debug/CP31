using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000584 RID: 1412
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SheetFormatPr
	{
		// Token: 0x06003DD2 RID: 15826 RVA: 0x00096134 File Offset: 0x00094334
		public CT_SheetFormatPr()
		{
			this.baseColWidth = 8U;
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x00096143 File Offset: 0x00094343
		// (set) Token: 0x06003DD4 RID: 15828 RVA: 0x0009614B File Offset: 0x0009434B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "8")]
		public uint baseColWidth
		{
			get
			{
				return this.baseColWidthField;
			}
			set
			{
				this.baseColWidthField = value;
			}
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x00096154 File Offset: 0x00094354
		// (set) Token: 0x06003DD6 RID: 15830 RVA: 0x0009615C File Offset: 0x0009435C
		[global::System.Xml.Serialization.XmlAttribute]
		public double defaultColWidth
		{
			get
			{
				return this.defaultColWidthField;
			}
			set
			{
				this.defaultColWidthField = value;
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06003DD7 RID: 15831 RVA: 0x00096165 File Offset: 0x00094365
		// (set) Token: 0x06003DD8 RID: 15832 RVA: 0x0009616D File Offset: 0x0009436D
		[global::System.Xml.Serialization.XmlAttribute]
		public double defaultRowHeight
		{
			get
			{
				return this.defaultRowHeightField;
			}
			set
			{
				this.defaultRowHeightField = value;
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06003DD9 RID: 15833 RVA: 0x00096176 File Offset: 0x00094376
		// (set) Token: 0x06003DDA RID: 15834 RVA: 0x0009617E File Offset: 0x0009437E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool customHeight
		{
			get
			{
				return this.customHeightField;
			}
			set
			{
				this.customHeightField = value;
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06003DDB RID: 15835 RVA: 0x00096187 File Offset: 0x00094387
		// (set) Token: 0x06003DDC RID: 15836 RVA: 0x0009618F File Offset: 0x0009438F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool zeroHeight
		{
			get
			{
				return this.zeroHeightField;
			}
			set
			{
				this.zeroHeightField = value;
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06003DDD RID: 15837 RVA: 0x00096198 File Offset: 0x00094398
		// (set) Token: 0x06003DDE RID: 15838 RVA: 0x000961A0 File Offset: 0x000943A0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool thickTop
		{
			get
			{
				return this.thickTopField;
			}
			set
			{
				this.thickTopField = value;
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06003DDF RID: 15839 RVA: 0x000961A9 File Offset: 0x000943A9
		// (set) Token: 0x06003DE0 RID: 15840 RVA: 0x000961B1 File Offset: 0x000943B1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool thickBottom
		{
			get
			{
				return this.thickBottomField;
			}
			set
			{
				this.thickBottomField = value;
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06003DE1 RID: 15841 RVA: 0x000961BA File Offset: 0x000943BA
		// (set) Token: 0x06003DE2 RID: 15842 RVA: 0x000961C2 File Offset: 0x000943C2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		public byte outlineLevelRow
		{
			get
			{
				return this.outlineLevelRowField;
			}
			set
			{
				this.outlineLevelRowField = value;
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06003DE3 RID: 15843 RVA: 0x000961CB File Offset: 0x000943CB
		// (set) Token: 0x06003DE4 RID: 15844 RVA: 0x000961D3 File Offset: 0x000943D3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		public byte outlineLevelCol
		{
			get
			{
				return this.outlineLevelColField;
			}
			set
			{
				this.outlineLevelColField = value;
			}
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x000961DC File Offset: 0x000943DC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr
			{
				baseColWidth = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["baseColWidth"]),
				defaultColWidth = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["defaultColWidth"]),
				defaultRowHeight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["defaultRowHeight"]),
				customHeight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["customHeight"]),
				zeroHeight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["zeroHeight"]),
				thickTop = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["thickTop"]),
				outlineLevelRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["outlineLevelRow"]),
				outlineLevelCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["outlineLevelCol"]),
				thickBottom = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["thickBottom"]),
				dyDescentField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["x14ac:dyDescent"])
			};
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x00096304 File Offset: 0x00094504
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "baseColWidth", this.baseColWidth, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defaultColWidth", this.defaultColWidth);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defaultRowHeight", this.defaultRowHeight);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "customHeight", this.customHeight, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "zeroHeight", this.zeroHeight, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "thickTop", this.thickTop, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "thickBottom", this.thickBottom, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outlineLevelRow", (int)this.outlineLevelRow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outlineLevelCol", (int)this.outlineLevelCol);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "x14ac:dyDescent", this.dyDescentField, false);
			sw.Write("/>");
		}

		// Token: 0x0400275A RID: 10074
		private uint baseColWidthField;

		// Token: 0x0400275B RID: 10075
		private double defaultColWidthField;

		// Token: 0x0400275C RID: 10076
		private double defaultRowHeightField;

		// Token: 0x0400275D RID: 10077
		private bool customHeightField;

		// Token: 0x0400275E RID: 10078
		private bool zeroHeightField;

		// Token: 0x0400275F RID: 10079
		private bool thickTopField;

		// Token: 0x04002760 RID: 10080
		private bool thickBottomField;

		// Token: 0x04002761 RID: 10081
		private byte outlineLevelRowField;

		// Token: 0x04002762 RID: 10082
		private byte outlineLevelColField;

		// Token: 0x04002763 RID: 10083
		private double dyDescentField;
	}
}
