using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200054D RID: 1357
	public class MapInfoDocument
	{
		// Token: 0x06003B24 RID: 15140 RVA: 0x0000205F File Offset: 0x0000025F
		public MapInfoDocument()
		{
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x000922EE File Offset: 0x000904EE
		public MapInfoDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_MapInfo map)
		{
			this.map = map;
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x000922FD File Offset: 0x000904FD
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MapInfo GetMapInfo()
		{
			return this.map;
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x00092305 File Offset: 0x00090505
		public void SetMapInfo(global::NPOI.OpenXmlFormats.Spreadsheet.CT_MapInfo map)
		{
			this.map = map;
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x00092305 File Offset: 0x00090505
		public void SetComments(global::NPOI.OpenXmlFormats.Spreadsheet.CT_MapInfo map)
		{
			this.map = map;
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00092310 File Offset: 0x00090510
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				streamWriter.Write("<MapInfo xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" SelectionNamespaces=\"xmlns:ns1='http://schemas.openxmlformats.org/spreadsheetml/2006/main'\">");
				if (this.map.Schema != null)
				{
					foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema ct_Schema in this.map.Schema)
					{
						streamWriter.Write(string.Format("<Schema ID=\"{0}\"", ct_Schema.ID));
						if (ct_Schema.Namespace != null)
						{
							streamWriter.Write(string.Format(" Namespace=\"{0}\"", ct_Schema.Namespace));
						}
						if (ct_Schema.SchemaRef != null)
						{
							streamWriter.Write(string.Format(" SchemaRef=\"{0}\"", ct_Schema.SchemaRef));
						}
						streamWriter.Write(">");
						streamWriter.Write(ct_Schema.InnerXml);
						streamWriter.Write("</Schema>");
					}
				}
				if (this.map.Map != null)
				{
					foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map ct_Map in this.map.Map)
					{
						streamWriter.Write(string.Format("<Map ID=\"{0}\"", ct_Map.ID));
						if (ct_Map.SchemaID != null)
						{
							streamWriter.Write(string.Format(" SchemaID=\"{0}\"", ct_Map.SchemaID));
						}
						if (ct_Map.RootElement != null)
						{
							streamWriter.Write(string.Format(" RootElement=\"{0}\"", ct_Map.RootElement));
						}
						if (ct_Map.Name != null)
						{
							streamWriter.Write(string.Format(" Name=\"{0}\"", ct_Map.Name));
						}
						if (ct_Map.PreserveFormat)
						{
							streamWriter.Write(" PreserveFormat=\"true\"");
						}
						if (ct_Map.PreserveSortAFLayout)
						{
							streamWriter.Write(" PreserveSortAFLayout=\"true\"");
						}
						if (ct_Map.ShowImportExportValidationErrors)
						{
							streamWriter.Write(" ShowImportExportValidationErrors=\"true\"");
						}
						if (ct_Map.Append)
						{
							streamWriter.Write(" Append=\"true\"");
						}
						if (ct_Map.AutoFit)
						{
							streamWriter.Write(" AutoFit=\"true\"");
						}
						streamWriter.Write(" />");
					}
				}
				streamWriter.Write("</MapInfo");
			}
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00092584 File Offset: 0x00090784
		public static global::NPOI.OpenXmlFormats.Spreadsheet.MapInfoDocument Parse(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlNamespaceManager NameSpaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.MapInfoDocument mapInfoDocument = new global::NPOI.OpenXmlFormats.Spreadsheet.MapInfoDocument();
			mapInfoDocument.map = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MapInfo();
			mapInfoDocument.map.Map = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map>();
			foreach (object obj in xmldoc.SelectNodes("d:MapInfo/d:Map", NameSpaceManager))
			{
				global::System.Xml.XmlElement xmlElement = (global::System.Xml.XmlElement)obj;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map ct_Map = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map();
				ct_Map.ID = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(xmlElement.GetAttributeNode("ID"));
				ct_Map.Name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(xmlElement.GetAttributeNode("Name"));
				ct_Map.RootElement = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(xmlElement.GetAttributeNode("RootElement"));
				ct_Map.SchemaID = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(xmlElement.GetAttributeNode("SchemaID"));
				ct_Map.ShowImportExportValidationErrors = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(xmlElement.GetAttributeNode("ShowImportExportValidationErrors"));
				ct_Map.PreserveFormat = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(xmlElement.GetAttributeNode("PreserveFormat"));
				ct_Map.PreserveSortAFLayout = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(xmlElement.GetAttributeNode("PreserveSortAFLayout"));
				ct_Map.Append = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(xmlElement.GetAttributeNode("Append"));
				ct_Map.AutoFit = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(xmlElement.GetAttributeNode("AutoFit"));
				mapInfoDocument.map.Map.Add(ct_Map);
			}
			mapInfoDocument.map.Schema = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema>();
			foreach (object obj2 in xmldoc.SelectNodes("d:MapInfo/d:Schema", NameSpaceManager))
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj2;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema ct_Schema = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema();
				ct_Schema.ID = xmlNode.Attributes["ID"].Value;
				if (xmlNode.Attributes["Namespace"] != null)
				{
					ct_Schema.Namespace = xmlNode.Attributes["Namespace"].Value;
				}
				if (xmlNode.Attributes["SchemaRef"] != null)
				{
					ct_Schema.SchemaRef = xmlNode.Attributes["SchemaRef"].Value;
				}
				ct_Schema.InnerXml = xmlNode.InnerXml;
				mapInfoDocument.map.Schema.Add(ct_Schema);
			}
			return mapInfoDocument;
		}

		// Token: 0x040025CA RID: 9674
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MapInfo map;
	}
}
