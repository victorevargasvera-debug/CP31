using System;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000BC RID: 188
	internal class XSSFChartUtil
	{
		// Token: 0x06000BBB RID: 3003 RVA: 0x00002FA4 File Offset: 0x000011A4
		private XSSFChartUtil()
		{
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0002B658 File Offset: 0x00029858
		public static void BuildAxDataSource<T>(global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource ctAxDataSource, global::NPOI.SS.UserModel.Charts.IChartDataSource<T> dataSource)
		{
			if (dataSource.IsNumeric)
			{
				if (dataSource.IsReference)
				{
					global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildNumRef<T>(ctAxDataSource.AddNewNumRef(), dataSource);
					return;
				}
				global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildNumLit<T>(ctAxDataSource.AddNewNumLit(), dataSource);
				return;
			}
			else
			{
				if (dataSource.IsReference)
				{
					global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildStrRef<T>(ctAxDataSource.AddNewStrRef(), dataSource);
					return;
				}
				global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildStrLit<T>(ctAxDataSource.AddNewStrLit(), dataSource);
				return;
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0002B6B0 File Offset: 0x000298B0
		public static void BuildNumDataSource<T>(global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource ctNumDataSource, global::NPOI.SS.UserModel.Charts.IChartDataSource<T> dataSource)
		{
			if (dataSource.IsReference)
			{
				global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildNumRef<T>(ctNumDataSource.AddNewNumRef(), dataSource);
				return;
			}
			global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildNumLit<T>(ctNumDataSource.AddNewNumLit(), dataSource);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0002B6D3 File Offset: 0x000298D3
		private static void BuildNumRef<T>(global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef ctNumRef, global::NPOI.SS.UserModel.Charts.IChartDataSource<T> dataSource)
		{
			ctNumRef.f = dataSource.FormulaString;
			global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.FillNumCache<T>(ctNumRef.AddNewNumCache(), dataSource);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0002B6ED File Offset: 0x000298ED
		private static void BuildNumLit<T>(global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData ctNumData, global::NPOI.SS.UserModel.Charts.IChartDataSource<T> dataSource)
		{
			global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.FillNumCache<T>(ctNumData, dataSource);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0002B6F6 File Offset: 0x000298F6
		private static void BuildStrRef<T>(global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef ctStrRef, global::NPOI.SS.UserModel.Charts.IChartDataSource<T> dataSource)
		{
			ctStrRef.f = dataSource.FormulaString;
			global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.FillStringCache<T>(ctStrRef.AddNewStrCache(), dataSource);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0002B710 File Offset: 0x00029910
		private static void BuildStrLit<T>(global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData ctStrData, global::NPOI.SS.UserModel.Charts.IChartDataSource<T> dataSource)
		{
			global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.FillStringCache<T>(ctStrData, dataSource);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0002B71C File Offset: 0x0002991C
		private static void FillStringCache<T>(global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData cache, global::NPOI.SS.UserModel.Charts.IChartDataSource<T> dataSource)
		{
			int pointCount = dataSource.PointCount;
			cache.AddNewPtCount().val = (uint)pointCount;
			for (int i = 0; i < pointCount; i++)
			{
				object obj = dataSource.GetPointAt(i);
				if (obj != null)
				{
					global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal ct_StrVal = cache.AddNewPt();
					ct_StrVal.idx = (uint)i;
					ct_StrVal.v = obj.ToString();
				}
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0002B770 File Offset: 0x00029970
		private static void FillNumCache<T>(global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData cache, global::NPOI.SS.UserModel.Charts.IChartDataSource<T> dataSource)
		{
			int pointCount = dataSource.PointCount;
			cache.AddNewPtCount().val = (uint)pointCount;
			for (int i = 0; i < pointCount; i++)
			{
				double d = global::System.Convert.ToDouble(dataSource.GetPointAt(i));
				if (!double.IsNaN(d))
				{
					global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal ct_NumVal = cache.AddNewPt();
					ct_NumVal.idx = (uint)i;
					ct_NumVal.v = d.ToString();
				}
			}
		}
	}
}
