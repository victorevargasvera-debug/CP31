using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000E3 RID: 227
	public class MapInfo : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000E1F RID: 3615 RVA: 0x00030AA8 File Offset: 0x0002ECA8
		public MapInfo()
		{
			this.mapInfo = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MapInfo();
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00030ABB File Offset: 0x0002ECBB
		internal MapInfo(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.ReadFrom(part.GetInputStream());
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00030AD0 File Offset: 0x0002ECD0
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public MapInfo(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00030ADC File Offset: 0x0002ECDC
		public void ReadFrom(global::System.IO.Stream is1)
		{
			try
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.MapInfoDocument mapInfoDocument = global::NPOI.OpenXmlFormats.Spreadsheet.MapInfoDocument.Parse(global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(is1), global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.mapInfo = mapInfoDocument.GetMapInfo();
				this.maps = new global::System.Collections.Generic.Dictionary<int, global::NPOI.XSSF.UserModel.XSSFMap>();
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map ct_Map in this.mapInfo.Map)
				{
					this.maps[(int)ct_Map.ID] = new global::NPOI.XSSF.UserModel.XSSFMap(ct_Map, this);
				}
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0001CF0B File Offset: 0x0001B10B
		public global::NPOI.XSSF.UserModel.XSSFWorkbook Workbook
		{
			get
			{
				return (global::NPOI.XSSF.UserModel.XSSFWorkbook)base.GetParent();
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00030B88 File Offset: 0x0002ED88
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MapInfo GetCTMapInfo()
		{
			return this.mapInfo;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00030B90 File Offset: 0x0002ED90
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema GetCTSchemaById(string schemaId)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema result = null;
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema ct_Schema in this.mapInfo.Schema)
			{
				if (ct_Schema.ID.Equals(schemaId))
				{
					result = ct_Schema;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00030BF8 File Offset: 0x0002EDF8
		public global::NPOI.XSSF.UserModel.XSSFMap GetXSSFMapById(int id)
		{
			return this.maps[id];
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00030C08 File Offset: 0x0002EE08
		public global::NPOI.XSSF.UserModel.XSSFMap GetXSSFMapByName(string name)
		{
			global::NPOI.XSSF.UserModel.XSSFMap result = null;
			foreach (global::NPOI.XSSF.UserModel.XSSFMap xssfmap in this.maps.Values)
			{
				if (xssfmap.GetCTMap().Name != null && xssfmap.GetCTMap().Name.Equals(name))
				{
					result = xssfmap;
				}
			}
			return result;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00030C80 File Offset: 0x0002EE80
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFMap> GetAllXSSFMaps()
		{
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFMap> list = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFMap>();
			foreach (global::NPOI.XSSF.UserModel.XSSFMap item in this.maps.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00030CE0 File Offset: 0x0002EEE0
		protected void WriteTo(global::System.IO.Stream out1)
		{
			this.xml.Save(out1);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00030CF0 File Offset: 0x0002EEF0
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.WriteTo(outputStream);
			outputStream.Close();
		}

		// Token: 0x0400041C RID: 1052
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MapInfo mapInfo;

		// Token: 0x0400041D RID: 1053
		private global::System.Collections.Generic.Dictionary<int, global::NPOI.XSSF.UserModel.XSSFMap> maps;

		// Token: 0x0400041E RID: 1054
		private global::System.Xml.XmlDocument xml;
	}
}
