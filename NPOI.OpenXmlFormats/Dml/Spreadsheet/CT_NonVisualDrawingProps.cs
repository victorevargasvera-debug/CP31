using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000368 RID: 872
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_NonVisualDrawingProps
	{
		// Token: 0x0600229D RID: 8861 RVA: 0x0005A510 File Offset: 0x00058710
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps ct_NonVisualDrawingProps = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps();
			ct_NonVisualDrawingProps.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["id"]);
			ct_NonVisualDrawingProps.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_NonVisualDrawingProps.descr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["descr"]);
			ct_NonVisualDrawingProps.hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "hlinkClick")
				{
					ct_NonVisualDrawingProps.hlinkClick = global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hlinkHover")
				{
					ct_NonVisualDrawingProps.hlinkHover = global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_NonVisualDrawingProps.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NonVisualDrawingProps;
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x0005A63C File Offset: 0x0005883C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "descr", this.descr);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden, false);
			sw.Write(">");
			if (this.hlinkClick != null)
			{
				this.hlinkClick.Write(sw, "hlinkClick");
			}
			if (this.hlinkHover != null)
			{
				this.hlinkHover.Write(sw, "hlinkHover");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x0005A707 File Offset: 0x00058907
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x0005A70F File Offset: 0x0005890F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkClick
		{
			get
			{
				return this.hlinkClickField;
			}
			set
			{
				this.hlinkClickField = value;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0005A718 File Offset: 0x00058918
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x0005A720 File Offset: 0x00058920
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkHover
		{
			get
			{
				return this.hlinkHoverField;
			}
			set
			{
				this.hlinkHoverField = value;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x0005A729 File Offset: 0x00058929
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x0005A731 File Offset: 0x00058931
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
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

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0005A73A File Offset: 0x0005893A
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x0005A742 File Offset: 0x00058942
		[global::System.Xml.Serialization.XmlAttribute]
		public uint id
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

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x0005A74B File Offset: 0x0005894B
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x0005A753 File Offset: 0x00058953
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x0005A75C File Offset: 0x0005895C
		// (set) Token: 0x060022AA RID: 8874 RVA: 0x0005A772 File Offset: 0x00058972
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string descr
		{
			get
			{
				if (this.descrField != null)
				{
					return this.descrField;
				}
				return "";
			}
			set
			{
				this.descrField = value;
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x0005A77B File Offset: 0x0005897B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool descrSpecified
		{
			get
			{
				return this.descrField != null;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x0005A786 File Offset: 0x00058986
		// (set) Token: 0x060022AD RID: 8877 RVA: 0x0005A7A2 File Offset: 0x000589A2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hidden
		{
			get
			{
				return this.hiddenField != null && this.hiddenField.Value;
			}
			set
			{
				this.hiddenField = new bool?(value);
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x0005A7B0 File Offset: 0x000589B0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hiddenSpecified
		{
			get
			{
				return this.hiddenField != null;
			}
		}

		// Token: 0x04001A27 RID: 6695
		private global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkClickField;

		// Token: 0x04001A28 RID: 6696
		private global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkHoverField;

		// Token: 0x04001A29 RID: 6697
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001A2A RID: 6698
		private uint idField;

		// Token: 0x04001A2B RID: 6699
		private string nameField;

		// Token: 0x04001A2C RID: 6700
		private string descrField;

		// Token: 0x04001A2D RID: 6701
		private bool? hiddenField;
	}
}
