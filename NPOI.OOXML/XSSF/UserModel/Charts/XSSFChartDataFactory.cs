using System;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000BA RID: 186
	public class XSSFChartDataFactory : global::NPOI.SS.UserModel.Charts.IChartDataFactory
	{
		// Token: 0x06000BAC RID: 2988 RVA: 0x00002FA4 File Offset: 0x000011A4
		private XSSFChartDataFactory()
		{
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0002B493 File Offset: 0x00029693
		public global::NPOI.SS.UserModel.Charts.IScatterChartData<Tx, Ty> CreateScatterChartData<Tx, Ty>()
		{
			return new global::NPOI.XSSF.UserModel.Charts.XSSFScatterChartData<Tx, Ty>();
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0002B49A File Offset: 0x0002969A
		public global::NPOI.SS.UserModel.Charts.ILineChartData<Tx, Ty> CreateLineChartData<Tx, Ty>()
		{
			return new global::NPOI.XSSF.UserModel.Charts.XSSFLineChartData<Tx, Ty>();
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0002B4A1 File Offset: 0x000296A1
		public global::NPOI.SS.UserModel.Charts.IBarChartData<Tx, Ty> CreateBarChartData<Tx, Ty>()
		{
			return new global::NPOI.XSSF.UserModel.Charts.XSSFBarChartData<Tx, Ty>();
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0002B4A8 File Offset: 0x000296A8
		public static global::NPOI.XSSF.UserModel.Charts.XSSFChartDataFactory GetInstance()
		{
			if (global::NPOI.XSSF.UserModel.Charts.XSSFChartDataFactory.instance == null)
			{
				global::NPOI.XSSF.UserModel.Charts.XSSFChartDataFactory.instance = new global::NPOI.XSSF.UserModel.Charts.XSSFChartDataFactory();
			}
			return global::NPOI.XSSF.UserModel.Charts.XSSFChartDataFactory.instance;
		}

		// Token: 0x040003C5 RID: 965
		private static global::NPOI.XSSF.UserModel.Charts.XSSFChartDataFactory instance;
	}
}
