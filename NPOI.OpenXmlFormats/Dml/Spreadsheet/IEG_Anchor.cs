using System;
using System.IO;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000376 RID: 886
	public interface IEG_Anchor
	{
		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x0600235D RID: 9053
		// (set) Token: 0x0600235E RID: 9054
		global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape sp { get; set; }

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x0600235F RID: 9055
		// (set) Token: 0x06002360 RID: 9056
		global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Connector connector { get; set; }

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002361 RID: 9057
		// (set) Token: 0x06002362 RID: 9058
		global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GraphicalObjectFrame graphicFrame { get; set; }

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06002363 RID: 9059
		// (set) Token: 0x06002364 RID: 9060
		global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Picture picture { get; set; }

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002365 RID: 9061
		// (set) Token: 0x06002366 RID: 9062
		global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_GroupShape groupShape { get; set; }

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002367 RID: 9063
		// (set) Token: 0x06002368 RID: 9064
		global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData clientData { get; set; }

		// Token: 0x06002369 RID: 9065
		void Write(global::System.IO.StreamWriter sw);
	}
}
