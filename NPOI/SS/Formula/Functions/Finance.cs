using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200013F RID: 319
	public class Finance
	{
		// Token: 0x06000A3F RID: 2623 RVA: 0x0001B0C8 File Offset: 0x000192C8
		public static double PMT(double r, int nper, double pv, double fv, int type)
		{
			return -r * (pv * global::System.Math.Pow(1.0 + r, (double)nper) + fv) / ((1.0 + r * (double)type) * (global::System.Math.Pow(1.0 + r, (double)nper) - 1.0));
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0001B11B File Offset: 0x0001931B
		public static double PMT(double r, int nper, double pv, double fv)
		{
			return global::NPOI.SS.Formula.Functions.Finance.PMT(r, nper, pv, fv, 0);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0001B127 File Offset: 0x00019327
		public static double PMT(double r, int nper, double pv)
		{
			return global::NPOI.SS.Formula.Functions.Finance.PMT(r, nper, pv, 0.0);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0001B13C File Offset: 0x0001933C
		public static double IPMT(double r, int per, int nper, double pv, double fv, int type)
		{
			double num = global::NPOI.SS.Formula.Functions.Finance.FV(r, per - 1, global::NPOI.SS.Formula.Functions.Finance.PMT(r, nper, pv, fv, type), pv, type) * r;
			if (type == 1)
			{
				num /= 1.0 + r;
			}
			return num;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0001B178 File Offset: 0x00019378
		public static double IPMT(double r, int per, int nper, double pv, double fv)
		{
			return global::NPOI.SS.Formula.Functions.Finance.IPMT(r, per, nper, pv, fv, 0);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0001B186 File Offset: 0x00019386
		public static double IPMT(double r, int per, int nper, double pv)
		{
			return global::NPOI.SS.Formula.Functions.Finance.IPMT(r, per, nper, pv, 0.0);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0001B19A File Offset: 0x0001939A
		public static double PPMT(double r, int per, int nper, double pv, double fv, int type)
		{
			return global::NPOI.SS.Formula.Functions.Finance.PMT(r, nper, pv, fv, type) - global::NPOI.SS.Formula.Functions.Finance.IPMT(r, per, nper, pv, fv, type);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0001B1B6 File Offset: 0x000193B6
		public static double PPMT(double r, int per, int nper, double pv, double fv)
		{
			return global::NPOI.SS.Formula.Functions.Finance.PMT(r, nper, pv, fv) - global::NPOI.SS.Formula.Functions.Finance.IPMT(r, per, nper, pv, fv);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0001B1CE File Offset: 0x000193CE
		public static double PPMT(double r, int per, int nper, double pv)
		{
			return global::NPOI.SS.Formula.Functions.Finance.PMT(r, nper, pv) - global::NPOI.SS.Formula.Functions.Finance.IPMT(r, per, nper, pv);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0001B1E4 File Offset: 0x000193E4
		public static double FV(double r, int nper, double pmt, double pv, int type)
		{
			return -(pv * global::System.Math.Pow(1.0 + r, (double)nper) + pmt * (1.0 + r * (double)type) * (global::System.Math.Pow(1.0 + r, (double)nper) - 1.0) / r);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0001B237 File Offset: 0x00019437
		public static double FV(double r, int nper, double c, double pv)
		{
			return global::NPOI.SS.Formula.Functions.Finance.FV(r, nper, c, pv, 0);
		}
	}
}
