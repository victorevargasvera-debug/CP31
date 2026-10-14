using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002C9 RID: 713
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Hyperlink
	{
		// Token: 0x06001C50 RID: 7248 RVA: 0x0004DBBC File Offset: 0x0004BDBC
		public static global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink ct_Hyperlink = new global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink();
			ct_Hyperlink.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			ct_Hyperlink.invalidUrl = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["invalidUrl"]);
			ct_Hyperlink.action = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["action"]);
			ct_Hyperlink.tgtFrame = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["tgtFrame"]);
			ct_Hyperlink.tooltip = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["tooltip"]);
			ct_Hyperlink.history = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["history"]);
			ct_Hyperlink.highlightClick = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["highlightClick"]);
			ct_Hyperlink.endSnd = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["endSnd"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "snd")
				{
					ct_Hyperlink.snd = global::NPOI.OpenXmlFormats.Dml.CT_EmbeddedWAVAudioFile.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Hyperlink.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Hyperlink;
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0004DD34 File Offset: 0x0004BF34
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "invalidUrl", this.invalidUrl);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "action", this.action);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tgtFrame", this.tgtFrame);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tooltip", this.tooltip);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "history", this.history);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "highlightClick", this.highlightClick);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "endSnd", this.endSnd);
			sw.Write(">");
			if (this.snd != null)
			{
				this.snd.Write(sw, "snd");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0004DE28 File Offset: 0x0004C028
		public CT_Hyperlink()
		{
			this.invalidUrlField = "";
			this.actionField = "";
			this.tgtFrameField = "";
			this.tooltipField = "";
			this.historyField = true;
			this.highlightClickField = false;
			this.endSndField = false;
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x0004DE7C File Offset: 0x0004C07C
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x0004DE84 File Offset: 0x0004C084
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EmbeddedWAVAudioFile snd
		{
			get
			{
				return this.sndField;
			}
			set
			{
				this.sndField = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x0004DE8D File Offset: 0x0004C08D
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x0004DE95 File Offset: 0x0004C095
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x0004DE9E File Offset: 0x0004C09E
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x0004DEA6 File Offset: 0x0004C0A6
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

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0004DEAF File Offset: 0x0004C0AF
		// (set) Token: 0x06001C5A RID: 7258 RVA: 0x0004DEB7 File Offset: 0x0004C0B7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string invalidUrl
		{
			get
			{
				return this.invalidUrlField;
			}
			set
			{
				this.invalidUrlField = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0004DEC0 File Offset: 0x0004C0C0
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x0004DEC8 File Offset: 0x0004C0C8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x0004DED1 File Offset: 0x0004C0D1
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x0004DED9 File Offset: 0x0004C0D9
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string tgtFrame
		{
			get
			{
				return this.tgtFrameField;
			}
			set
			{
				this.tgtFrameField = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0004DEE2 File Offset: 0x0004C0E2
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x0004DEEA File Offset: 0x0004C0EA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string tooltip
		{
			get
			{
				return this.tooltipField;
			}
			set
			{
				this.tooltipField = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0004DEF3 File Offset: 0x0004C0F3
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x0004DEFB File Offset: 0x0004C0FB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool history
		{
			get
			{
				return this.historyField;
			}
			set
			{
				this.historyField = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x0004DF04 File Offset: 0x0004C104
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x0004DF0C File Offset: 0x0004C10C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool highlightClick
		{
			get
			{
				return this.highlightClickField;
			}
			set
			{
				this.highlightClickField = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x0004DF15 File Offset: 0x0004C115
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x0004DF1D File Offset: 0x0004C11D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool endSnd
		{
			get
			{
				return this.endSndField;
			}
			set
			{
				this.endSndField = value;
			}
		}

		// Token: 0x04001605 RID: 5637
		private global::NPOI.OpenXmlFormats.Dml.CT_EmbeddedWAVAudioFile sndField;

		// Token: 0x04001606 RID: 5638
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001607 RID: 5639
		private string idField;

		// Token: 0x04001608 RID: 5640
		private string invalidUrlField;

		// Token: 0x04001609 RID: 5641
		private string actionField;

		// Token: 0x0400160A RID: 5642
		private string tgtFrameField;

		// Token: 0x0400160B RID: 5643
		private string tooltipField;

		// Token: 0x0400160C RID: 5644
		private bool historyField;

		// Token: 0x0400160D RID: 5645
		private bool highlightClickField;

		// Token: 0x0400160E RID: 5646
		private bool endSndField;
	}
}
