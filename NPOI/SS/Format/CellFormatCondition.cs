using System;
using System.Collections.Generic;
using System.Globalization;

namespace NPOI.SS.Format
{
	// Token: 0x02000246 RID: 582
	public abstract class CellFormatCondition
	{
		// Token: 0x06000E39 RID: 3641 RVA: 0x00028EF4 File Offset: 0x000270F4
		static CellFormatCondition()
		{
			global::NPOI.SS.Format.CellFormatCondition.TESTS.Add("<", 0);
			global::NPOI.SS.Format.CellFormatCondition.TESTS.Add("<=", 1);
			global::NPOI.SS.Format.CellFormatCondition.TESTS.Add(">", 2);
			global::NPOI.SS.Format.CellFormatCondition.TESTS.Add(">=", 3);
			global::NPOI.SS.Format.CellFormatCondition.TESTS.Add("=", 4);
			global::NPOI.SS.Format.CellFormatCondition.TESTS.Add("==", 4);
			global::NPOI.SS.Format.CellFormatCondition.TESTS.Add("!=", 5);
			global::NPOI.SS.Format.CellFormatCondition.TESTS.Add("<>", 5);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00028F8C File Offset: 0x0002718C
		public static global::NPOI.SS.Format.CellFormatCondition GetInstance(string opString, string constStr)
		{
			if (!global::NPOI.SS.Format.CellFormatCondition.TESTS.ContainsKey(opString))
			{
				throw new global::System.ArgumentException("Unknown test: " + opString);
			}
			int num = global::NPOI.SS.Format.CellFormatCondition.TESTS[opString];
			double c = double.Parse(constStr, global::System.Globalization.CultureInfo.InvariantCulture);
			switch (num)
			{
			case 0:
				return new global::NPOI.SS.Format.CellFormatCondition.LT_CellFormatCondition(c);
			case 1:
				return new global::NPOI.SS.Format.CellFormatCondition.LE_CellFormatCondition(c);
			case 2:
				return new global::NPOI.SS.Format.CellFormatCondition.GT_CellFormatCondition(c);
			case 3:
				return new global::NPOI.SS.Format.CellFormatCondition.GE_CellFormatCondition(c);
			case 4:
				return new global::NPOI.SS.Format.CellFormatCondition.EQ_CellFormatCondition(c);
			case 5:
				return new global::NPOI.SS.Format.CellFormatCondition.NE_CellFormatCondition(c);
			default:
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Cannot create for test number ",
					num.ToString(),
					"(\"",
					opString,
					"\")"
				}));
			}
		}

		// Token: 0x06000E3B RID: 3643
		public abstract bool Pass(double value);

		// Token: 0x0400066B RID: 1643
		private const int LT = 0;

		// Token: 0x0400066C RID: 1644
		private const int LE = 1;

		// Token: 0x0400066D RID: 1645
		private const int GT = 2;

		// Token: 0x0400066E RID: 1646
		private const int GE = 3;

		// Token: 0x0400066F RID: 1647
		private const int EQ = 4;

		// Token: 0x04000670 RID: 1648
		private const int NE = 5;

		// Token: 0x04000671 RID: 1649
		private static global::System.Collections.Generic.Dictionary<string, int> TESTS = new global::System.Collections.Generic.Dictionary<string, int>();

		// Token: 0x02000598 RID: 1432
		private class LT_CellFormatCondition : global::NPOI.SS.Format.CellFormatCondition
		{
			// Token: 0x0600345C RID: 13404 RVA: 0x000A31FD File Offset: 0x000A13FD
			public LT_CellFormatCondition(double c)
			{
				this._c = c;
			}

			// Token: 0x0600345D RID: 13405 RVA: 0x000A320C File Offset: 0x000A140C
			public override bool Pass(double value)
			{
				return value < this._c;
			}

			// Token: 0x04001913 RID: 6419
			private double _c;
		}

		// Token: 0x02000599 RID: 1433
		private class LE_CellFormatCondition : global::NPOI.SS.Format.CellFormatCondition
		{
			// Token: 0x0600345E RID: 13406 RVA: 0x000A3217 File Offset: 0x000A1417
			public LE_CellFormatCondition(double c)
			{
				this._c = c;
			}

			// Token: 0x0600345F RID: 13407 RVA: 0x000A3226 File Offset: 0x000A1426
			public override bool Pass(double value)
			{
				return value <= this._c;
			}

			// Token: 0x04001914 RID: 6420
			private double _c;
		}

		// Token: 0x0200059A RID: 1434
		private class GT_CellFormatCondition : global::NPOI.SS.Format.CellFormatCondition
		{
			// Token: 0x06003460 RID: 13408 RVA: 0x000A3234 File Offset: 0x000A1434
			public GT_CellFormatCondition(double c)
			{
				this._c = c;
			}

			// Token: 0x06003461 RID: 13409 RVA: 0x000A3243 File Offset: 0x000A1443
			public override bool Pass(double value)
			{
				return value > this._c;
			}

			// Token: 0x04001915 RID: 6421
			private double _c;
		}

		// Token: 0x0200059B RID: 1435
		private class GE_CellFormatCondition : global::NPOI.SS.Format.CellFormatCondition
		{
			// Token: 0x06003462 RID: 13410 RVA: 0x000A324E File Offset: 0x000A144E
			public GE_CellFormatCondition(double c)
			{
				this._c = c;
			}

			// Token: 0x06003463 RID: 13411 RVA: 0x000A325D File Offset: 0x000A145D
			public override bool Pass(double value)
			{
				return value >= this._c;
			}

			// Token: 0x04001916 RID: 6422
			private double _c;
		}

		// Token: 0x0200059C RID: 1436
		private class EQ_CellFormatCondition : global::NPOI.SS.Format.CellFormatCondition
		{
			// Token: 0x06003464 RID: 13412 RVA: 0x000A326B File Offset: 0x000A146B
			public EQ_CellFormatCondition(double c)
			{
				this._c = c;
			}

			// Token: 0x06003465 RID: 13413 RVA: 0x000A327A File Offset: 0x000A147A
			public override bool Pass(double value)
			{
				return value == this._c;
			}

			// Token: 0x04001917 RID: 6423
			private double _c;
		}

		// Token: 0x0200059D RID: 1437
		private class NE_CellFormatCondition : global::NPOI.SS.Format.CellFormatCondition
		{
			// Token: 0x06003466 RID: 13414 RVA: 0x000A3285 File Offset: 0x000A1485
			public NE_CellFormatCondition(double c)
			{
				this._c = c;
			}

			// Token: 0x06003467 RID: 13415 RVA: 0x000A3294 File Offset: 0x000A1494
			public override bool Pass(double value)
			{
				return value != this._c;
			}

			// Token: 0x04001918 RID: 6424
			private double _c;
		}
	}
}
