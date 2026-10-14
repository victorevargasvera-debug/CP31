using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000B5 RID: 181
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AbstractNum
	{
		// Token: 0x060004FA RID: 1274 RVA: 0x0000E1A4 File Offset: 0x0000C3A4
		public CT_AbstractNum()
		{
			this.multiLevelTypeField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MultiLevelType();
			this.nsidField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber();
			this.nsidField.val = new byte[4];
			global::System.Array.Copy(global::System.BitConverter.GetBytes(global::System.DateTime.Now.Ticks), 4, this.nsidField.val, 0, 4);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0000E203 File Offset: 0x0000C403
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x0000E20B File Offset: 0x0000C40B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber nsid
		{
			get
			{
				return this.nsidField;
			}
			set
			{
				this.nsidField = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0000E214 File Offset: 0x0000C414
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x0000E21C File Offset: 0x0000C41C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_MultiLevelType multiLevelType
		{
			get
			{
				return this.multiLevelTypeField;
			}
			set
			{
				this.multiLevelTypeField = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0000E225 File Offset: 0x0000C425
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x0000E22D File Offset: 0x0000C42D
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber tmpl
		{
			get
			{
				return this.tmplField;
			}
			set
			{
				this.tmplField = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0000E236 File Offset: 0x0000C436
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x0000E23E File Offset: 0x0000C43E
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String name
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0000E247 File Offset: 0x0000C447
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x0000E24F File Offset: 0x0000C44F
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String styleLink
		{
			get
			{
				return this.styleLinkField;
			}
			set
			{
				this.styleLinkField = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0000E258 File Offset: 0x0000C458
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0000E260 File Offset: 0x0000C460
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String numStyleLink
		{
			get
			{
				return this.numStyleLinkField;
			}
			set
			{
				this.numStyleLinkField = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0000E269 File Offset: 0x0000C469
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x0000E271 File Offset: 0x0000C471
		[global::System.Xml.Serialization.XmlElement("lvl", Order = 6)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl> lvl
		{
			get
			{
				return this.lvlField;
			}
			set
			{
				this.lvlField = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0000E27A File Offset: 0x0000C47A
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x0000E282 File Offset: 0x0000C482
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string abstractNumId
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

		// Token: 0x0600050B RID: 1291 RVA: 0x0000E28C File Offset: 0x0000C48C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum Copy()
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum
			{
				abstractNumIdField = this.abstractNumIdField,
				lvlField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl>(this.lvlField),
				multiLevelTypeField = this.multiLevelTypeField,
				nameField = this.nameField,
				nsidField = this.nsidField,
				numStyleLinkField = this.numStyleLinkField,
				styleLinkField = this.styleLinkField,
				tmplField = this.tmplField
			};
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000E303 File Offset: 0x0000C503
		public bool ValueEquals(global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum cT_AbstractNum)
		{
			return this.abstractNumIdField == cT_AbstractNum.abstractNumIdField;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000E318 File Offset: 0x0000C518
		public void Set(global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum cT_AbstractNum)
		{
			this.abstractNumIdField = cT_AbstractNum.abstractNumIdField;
			this.lvlField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl>(cT_AbstractNum.lvlField);
			this.multiLevelTypeField = cT_AbstractNum.multiLevelTypeField;
			this.nameField = cT_AbstractNum.nameField;
			this.nsidField = cT_AbstractNum.nsidField;
			this.numStyleLinkField = cT_AbstractNum.numStyleLinkField;
			this.styleLinkField = cT_AbstractNum.styleLinkField;
			this.tmplField = cT_AbstractNum.tmplField;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000E38C File Offset: 0x0000C58C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum ct_AbstractNum = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum();
			ct_AbstractNum.abstractNumId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:abstractNumId"]);
			ct_AbstractNum.lvl = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "nsid")
				{
					ct_AbstractNum.nsid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "multiLevelType")
				{
					ct_AbstractNum.multiLevelType = global::NPOI.OpenXmlFormats.Wordprocessing.CT_MultiLevelType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tmpl")
				{
					ct_AbstractNum.tmpl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "name")
				{
					ct_AbstractNum.name = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "styleLink")
				{
					ct_AbstractNum.styleLink = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numStyleLink")
				{
					ct_AbstractNum.numStyleLink = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl")
				{
					ct_AbstractNum.lvl.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_AbstractNum;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000E518 File Offset: 0x0000C718
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:abstractNumId", this.abstractNumId);
			sw.Write(">");
			if (this.nsid != null)
			{
				this.nsid.Write(sw, "nsid");
			}
			if (this.multiLevelType != null)
			{
				this.multiLevelType.Write(sw, "multiLevelType");
			}
			if (this.tmpl != null)
			{
				this.tmpl.Write(sw, "tmpl");
			}
			if (this.name != null)
			{
				this.name.Write(sw, "name");
			}
			if (this.styleLink != null)
			{
				this.styleLink.Write(sw, "styleLink");
			}
			if (this.numStyleLink != null)
			{
				this.numStyleLink.Write(sw, "numStyleLink");
			}
			if (this.lvl != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl ct_Lvl in this.lvl)
				{
					ct_Lvl.Write(sw, "lvl");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000E64C File Offset: 0x0000C84C
		public int SizeOfLvlArray()
		{
			if (this.lvlField != null)
			{
				return this.lvlField.Count;
			}
			return 0;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000E663 File Offset: 0x0000C863
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl GetLvlArray(int i)
		{
			if (this.lvlField != null)
			{
				return this.lvlField[i];
			}
			return null;
		}

		// Token: 0x04000472 RID: 1138
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber nsidField;

		// Token: 0x04000473 RID: 1139
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_MultiLevelType multiLevelTypeField;

		// Token: 0x04000474 RID: 1140
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LongHexNumber tmplField;

		// Token: 0x04000475 RID: 1141
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String nameField;

		// Token: 0x04000476 RID: 1142
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String styleLinkField;

		// Token: 0x04000477 RID: 1143
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String numStyleLinkField;

		// Token: 0x04000478 RID: 1144
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl> lvlField;

		// Token: 0x04000479 RID: 1145
		private string abstractNumIdField;
	}
}
