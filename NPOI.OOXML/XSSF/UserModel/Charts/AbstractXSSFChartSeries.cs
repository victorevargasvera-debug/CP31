using System;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel.Charts;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000B6 RID: 182
	public class AbstractXSSFChartSeries : global::NPOI.SS.UserModel.Charts.IChartSeries
	{
		// Token: 0x06000B68 RID: 2920 RVA: 0x0002AC71 File Offset: 0x00028E71
		public void SetTitle(string title)
		{
			this.titleType = new global::NPOI.SS.UserModel.Charts.TitleType?(global::NPOI.SS.UserModel.Charts.TitleType.String);
			this.titleValue = title;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0002AC86 File Offset: 0x00028E86
		public void SetTitle(global::NPOI.SS.Util.CellReference titleReference)
		{
			this.titleType = new global::NPOI.SS.UserModel.Charts.TitleType?(global::NPOI.SS.UserModel.Charts.TitleType.CellReference);
			this.titleRef = titleReference;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0002AC9C File Offset: 0x00028E9C
		public string GetTitleString()
		{
			global::NPOI.SS.UserModel.Charts.TitleType? titleType = this.titleType;
			global::NPOI.SS.UserModel.Charts.TitleType titleType2 = global::NPOI.SS.UserModel.Charts.TitleType.String;
			if (titleType.GetValueOrDefault() == titleType2 & titleType != null)
			{
				return this.titleValue;
			}
			throw new global::System.InvalidOperationException("Title type is not String.");
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0002ACD8 File Offset: 0x00028ED8
		public global::NPOI.SS.Util.CellReference GetTitleCellReference()
		{
			global::NPOI.SS.UserModel.Charts.TitleType? titleType = this.titleType;
			global::NPOI.SS.UserModel.Charts.TitleType titleType2 = global::NPOI.SS.UserModel.Charts.TitleType.CellReference;
			if (titleType.GetValueOrDefault() == titleType2 & titleType != null)
			{
				return this.titleRef;
			}
			throw new global::System.InvalidOperationException("Title type is not CellReference.");
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0002AD13 File Offset: 0x00028F13
		public global::NPOI.SS.UserModel.Charts.TitleType? GetTitleType()
		{
			return this.titleType;
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0002AD1B File Offset: 0x00028F1B
		protected bool IsTitleSet
		{
			get
			{
				return this.titleType != null;
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0002AD28 File Offset: 0x00028F28
		protected global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx GetCTSerTx()
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx ct_SerTx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx();
			global::NPOI.SS.UserModel.Charts.TitleType? titleType = this.titleType;
			if (titleType != null)
			{
				global::NPOI.SS.UserModel.Charts.TitleType valueOrDefault = titleType.GetValueOrDefault();
				if (valueOrDefault == global::NPOI.SS.UserModel.Charts.TitleType.String)
				{
					ct_SerTx.v = this.titleValue;
					return ct_SerTx;
				}
				if (valueOrDefault == global::NPOI.SS.UserModel.Charts.TitleType.CellReference)
				{
					ct_SerTx.AddNewStrRef().f = this.titleRef.FormatAsString();
					return ct_SerTx;
				}
			}
			string str = "Unkown title type: ";
			global::NPOI.SS.UserModel.Charts.TitleType? titleType2 = this.titleType;
			throw new global::System.InvalidOperationException(str + titleType2.ToString());
		}

		// Token: 0x040003BD RID: 957
		private string titleValue;

		// Token: 0x040003BE RID: 958
		private global::NPOI.SS.Util.CellReference titleRef;

		// Token: 0x040003BF RID: 959
		private global::NPOI.SS.UserModel.Charts.TitleType? titleType;
	}
}
