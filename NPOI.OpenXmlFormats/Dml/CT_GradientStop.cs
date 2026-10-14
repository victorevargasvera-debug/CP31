using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000321 RID: 801
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GradientStop
	{
		// Token: 0x06001FFA RID: 8186 RVA: 0x000553D8 File Offset: 0x000535D8
		public static global::NPOI.OpenXmlFormats.Dml.CT_GradientStop Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_GradientStop ct_GradientStop = new global::NPOI.OpenXmlFormats.Dml.CT_GradientStop();
			ct_GradientStop.pos = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["pos"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scrgbClr")
				{
					ct_GradientStop.scrgbClr = global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srgbClr")
				{
					ct_GradientStop.srgbClr = global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hslClr")
				{
					ct_GradientStop.hslClr = global::NPOI.OpenXmlFormats.Dml.CT_HslColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sysClr")
				{
					ct_GradientStop.sysClr = global::NPOI.OpenXmlFormats.Dml.CT_SystemColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "schemeClr")
				{
					ct_GradientStop.schemeClr = global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstClr")
				{
					ct_GradientStop.prstClr = global::NPOI.OpenXmlFormats.Dml.CT_PresetColor.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GradientStop;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00055524 File Offset: 0x00053724
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pos", this.pos, true);
			sw.Write(">");
			if (this.scrgbClr != null)
			{
				this.scrgbClr.Write(sw, "scrgbClr");
			}
			if (this.srgbClr != null)
			{
				this.srgbClr.Write(sw, "srgbClr");
			}
			if (this.hslClr != null)
			{
				this.hslClr.Write(sw, "hslClr");
			}
			if (this.sysClr != null)
			{
				this.sysClr.Write(sw, "sysClr");
			}
			if (this.schemeClr != null)
			{
				this.schemeClr.Write(sw, "schemeClr");
			}
			if (this.prstClr != null)
			{
				this.prstClr.Write(sw, "prstClr");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x00055606 File Offset: 0x00053806
		// (set) Token: 0x06001FFD RID: 8189 RVA: 0x0005560E File Offset: 0x0005380E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClr
		{
			get
			{
				return this.scrgbClrField;
			}
			set
			{
				this.scrgbClrField = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x00055617 File Offset: 0x00053817
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x0005561F File Offset: 0x0005381F
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClr
		{
			get
			{
				return this.srgbClrField;
			}
			set
			{
				this.srgbClrField = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x00055628 File Offset: 0x00053828
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x00055630 File Offset: 0x00053830
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClr
		{
			get
			{
				return this.hslClrField;
			}
			set
			{
				this.hslClrField = value;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x00055639 File Offset: 0x00053839
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x00055641 File Offset: 0x00053841
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClr
		{
			get
			{
				return this.sysClrField;
			}
			set
			{
				this.sysClrField = value;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x0005564A File Offset: 0x0005384A
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x00055652 File Offset: 0x00053852
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClr
		{
			get
			{
				return this.schemeClrField;
			}
			set
			{
				this.schemeClrField = value;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x0005565B File Offset: 0x0005385B
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x00055663 File Offset: 0x00053863
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClr
		{
			get
			{
				return this.prstClrField;
			}
			set
			{
				this.prstClrField = value;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x0005566C File Offset: 0x0005386C
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x00055674 File Offset: 0x00053874
		[global::System.Xml.Serialization.XmlAttribute]
		public int pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		// Token: 0x040018B5 RID: 6325
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x040018B6 RID: 6326
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x040018B7 RID: 6327
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x040018B8 RID: 6328
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x040018B9 RID: 6329
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x040018BA RID: 6330
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;

		// Token: 0x040018BB RID: 6331
		private int posField;
	}
}
