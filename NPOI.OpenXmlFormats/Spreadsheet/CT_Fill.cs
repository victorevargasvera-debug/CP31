using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.OPC.Internal;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000504 RID: 1284
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Fill
	{
		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x00088607 File Offset: 0x00086807
		// (set) Token: 0x060036BE RID: 14014 RVA: 0x0008860F File Offset: 0x0008680F
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill patternFill
		{
			get
			{
				return this.patternFillField;
			}
			set
			{
				this.patternFillField = value;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x060036BF RID: 14015 RVA: 0x00088618 File Offset: 0x00086818
		// (set) Token: 0x060036C0 RID: 14016 RVA: 0x00088620 File Offset: 0x00086820
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientFill gradientFill
		{
			get
			{
				return this.gradientFillField;
			}
			set
			{
				this.gradientFillField = value;
			}
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x00088607 File Offset: 0x00086807
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill GetPatternFill()
		{
			return this.patternFillField;
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x00088629 File Offset: 0x00086829
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill AddNewPatternFill()
		{
			this.patternFillField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill();
			return this.GetPatternFill();
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x0008863C File Offset: 0x0008683C
		public bool IsSetPatternFill()
		{
			return this.patternFillField != null;
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x00088647 File Offset: 0x00086847
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill Copy()
		{
			return global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill.Parse(this.ToString());
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x00088654 File Offset: 0x00086854
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill ct_Fill = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "patternFill")
				{
					ct_Fill.patternFill = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gradientFill")
				{
					ct_Fill.gradientFill = global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientFill.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Fill;
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x000886F4 File Offset: 0x000868F4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.patternFill != null)
			{
				this.patternFill.Write(sw, "patternFill");
			}
			if (this.gradientFill != null)
			{
				this.gradientFill.Write(sw, "gradientFill");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00088760 File Offset: 0x00086960
		public override string ToString()
		{
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(memoryStream);
				this.Write(streamWriter, "fill");
				streamWriter.Flush();
				memoryStream.Position = 0L;
				result = new global::System.IO.StreamReader(memoryStream).ReadToEnd();
			}
			return result;
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x000887C0 File Offset: 0x000869C0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill Parse(string p)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.LoadXml(p);
			return global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill.Parse(xmlDocument.DocumentElement, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill.CreateDefaultNSM());
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x000887E0 File Offset: 0x000869E0
		public static global::System.Xml.XmlNamespaceManager CreateDefaultNSM()
		{
			global::System.Xml.XmlNamespaceManager xmlNamespaceManager = new global::System.Xml.XmlNamespaceManager(new global::System.Xml.NameTable());
			xmlNamespaceManager.AddNamespace(string.Empty, "http://schemas.openxmlformats.org/spreadsheetml/2006/main");
			xmlNamespaceManager.AddNamespace("d", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");
			xmlNamespaceManager.AddNamespace("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
			xmlNamespaceManager.AddNamespace("xdr", "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing");
			xmlNamespaceManager.AddNamespace("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
			xmlNamespaceManager.AddNamespace("c", "http://schemas.openxmlformats.org/drawingml/2006/chart");
			xmlNamespaceManager.AddNamespace("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
			xmlNamespaceManager.AddNamespace("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
			xmlNamespaceManager.AddNamespace("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
			xmlNamespaceManager.AddNamespace("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
			xmlNamespaceManager.AddNamespace("ve", "http://schemas.openxmlformats.org/markup-compatibility/2006");
			xmlNamespaceManager.AddNamespace("o", "urn:schemas-microsoft-com:office:office");
			xmlNamespaceManager.AddNamespace("v", "urn:schemas-microsoft-com:vml");
			xmlNamespaceManager.AddNamespace("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
			xmlNamespaceManager.AddNamespace("xp", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties");
			xmlNamespaceManager.AddNamespace("ctp", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties");
			xmlNamespaceManager.AddNamespace("cp", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_CP_URI);
			xmlNamespaceManager.AddNamespace("dc", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_DC_URI);
			xmlNamespaceManager.AddNamespace("dcterms", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_DCTERMS_URI);
			xmlNamespaceManager.AddNamespace("dcmitype", "http://purl.org/dc/dcmitype/");
			xmlNamespaceManager.AddNamespace("xsi", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_XSI_URI);
			xmlNamespaceManager.AddNamespace("xsd", "http://www.w3.org/2001/XMLSchema");
			return xmlNamespaceManager;
		}

		// Token: 0x040023F3 RID: 9203
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill patternFillField;

		// Token: 0x040023F4 RID: 9204
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientFill gradientFillField;
	}
}
