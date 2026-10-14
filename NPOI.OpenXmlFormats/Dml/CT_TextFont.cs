using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000273 RID: 627
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextFont
	{
		// Token: 0x06001999 RID: 6553 RVA: 0x00045DFE File Offset: 0x00043FFE
		public CT_TextFont()
		{
			this.pitchFamilyField = 0;
			this.charsetField = 1;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00045E14 File Offset: 0x00044014
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextFont Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextFont ct_TextFont = new global::NPOI.OpenXmlFormats.Dml.CT_TextFont();
			ct_TextFont.typeface = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["typeface"]);
			ct_TextFont.panose = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["panose"]);
			ct_TextFont.pitchFamily = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadSByte(node.Attributes["pitchFamily"]);
			if (node.Attributes["charset"] != null)
			{
				ct_TextFont.charsetField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadSByte(node.Attributes["charset"]);
			}
			return ct_TextFont;
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00045EAC File Offset: 0x000440AC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "typeface", this.typeface, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "panose", this.panose);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pitchFamily", (int)this.pitchFamily);
			if (this.charsetField != 1)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "charset", (int)this.charset, true);
			}
			sw.Write("/>");
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x00045F24 File Offset: 0x00044124
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x00045F2C File Offset: 0x0004412C
		[global::System.Xml.Serialization.XmlAttribute]
		public string typeface
		{
			get
			{
				return this.typefaceField;
			}
			set
			{
				this.typefaceField = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x00045F35 File Offset: 0x00044135
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x00045F3D File Offset: 0x0004413D
		[global::System.Xml.Serialization.XmlAttribute(DataType = "hexBinary")]
		public byte[] panose
		{
			get
			{
				return this.panoseField;
			}
			set
			{
				this.panoseField = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00045F46 File Offset: 0x00044146
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x00045F4E File Offset: 0x0004414E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(sbyte), "0")]
		public sbyte pitchFamily
		{
			get
			{
				return this.pitchFamilyField;
			}
			set
			{
				this.pitchFamilyField = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x00045F57 File Offset: 0x00044157
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x00045F5F File Offset: 0x0004415F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(sbyte), "1")]
		public sbyte charset
		{
			get
			{
				return this.charsetField;
			}
			set
			{
				this.charsetField = value;
			}
		}

		// Token: 0x0400134F RID: 4943
		private string typefaceField;

		// Token: 0x04001350 RID: 4944
		private byte[] panoseField;

		// Token: 0x04001351 RID: 4945
		private sbyte pitchFamilyField;

		// Token: 0x04001352 RID: 4946
		private sbyte charsetField;
	}
}
