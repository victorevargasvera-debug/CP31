using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000619 RID: 1561
	public class TableDocument
	{
		// Token: 0x060043FF RID: 17407 RVA: 0x0000205F File Offset: 0x0000025F
		public TableDocument()
		{
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x000A1BE5 File Offset: 0x0009FDE5
		public TableDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table table)
		{
			this.ctTable = table;
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.TableDocument Parse(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlNamespaceManager namespaceMgr)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.TableDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table.Parse(xmldoc.DocumentElement, namespaceMgr));
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x000A1C07 File Offset: 0x0009FE07
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table GetTable()
		{
			return this.ctTable;
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x000A1C0F File Offset: 0x0009FE0F
		public void SetTable(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table table)
		{
			this.ctTable = table;
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x000A1C18 File Offset: 0x0009FE18
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.ctTable.Write(streamWriter);
			}
		}

		// Token: 0x04002ABE RID: 10942
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table ctTable;
	}
}
