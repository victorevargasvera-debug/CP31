using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Common
{
	// Token: 0x0200045E RID: 1118
	public class FeatFormulaErr2 : global::NPOI.HSSF.Record.Common.SharedFeature
	{
		// Token: 0x06002951 RID: 10577 RVA: 0x0000253E File Offset: 0x0000073E
		public FeatFormulaErr2()
		{
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x0007CA0A File Offset: 0x0007AC0A
		public FeatFormulaErr2(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.errorCheck = in1.ReadInt();
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x0007CA20 File Offset: 0x0007AC20
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(" [FEATURE FORMULA ERRORS]\n");
			stringBuilder.Append("  checkCalculationErrors    = ");
			stringBuilder.Append("  checkEmptyCellRef         = ");
			stringBuilder.Append("  checkNumbersAsText        = ");
			stringBuilder.Append("  checkInconsistentRanges   = ");
			stringBuilder.Append("  checkInconsistentFormulas = ");
			stringBuilder.Append("  checkDateTimeFormats      = ");
			stringBuilder.Append("  checkUnprotectedFormulas  = ");
			stringBuilder.Append("  performDataValidation     = ");
			stringBuilder.Append(" [/FEATURE FORMULA ERRORS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x0007CAAF File Offset: 0x0007ACAF
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.errorCheck);
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x00018498 File Offset: 0x00016698
		public int DataSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x0007CABD File Offset: 0x0007ACBD
		public int RawErrorCheckValue
		{
			get
			{
				return this.errorCheck;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x0007CAC5 File Offset: 0x0007ACC5
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x0007CAD7 File Offset: 0x0007ACD7
		public bool CheckCalculationErrors
		{
			get
			{
				return global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_CALCULATION_ERRORS.IsSet(this.errorCheck);
			}
			set
			{
				this.errorCheck = global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_CALCULATION_ERRORS.SetBoolean(this.errorCheck, value);
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x0007CAF0 File Offset: 0x0007ACF0
		// (set) Token: 0x0600295A RID: 10586 RVA: 0x0007CB02 File Offset: 0x0007AD02
		public bool CheckEmptyCellRef
		{
			get
			{
				return global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_EMPTY_CELL_REF.IsSet(this.errorCheck);
			}
			set
			{
				this.errorCheck = global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_EMPTY_CELL_REF.SetBoolean(this.errorCheck, value);
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x0007CB1B File Offset: 0x0007AD1B
		// (set) Token: 0x0600295C RID: 10588 RVA: 0x0007CB2D File Offset: 0x0007AD2D
		public bool CheckNumbersAsText
		{
			get
			{
				return global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_NUMBERS_AS_TEXT.IsSet(this.errorCheck);
			}
			set
			{
				this.errorCheck = global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_NUMBERS_AS_TEXT.SetBoolean(this.errorCheck, value);
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x0007CB46 File Offset: 0x0007AD46
		// (set) Token: 0x0600295E RID: 10590 RVA: 0x0007CB58 File Offset: 0x0007AD58
		public bool CheckInconsistentRanges
		{
			get
			{
				return global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_INCONSISTENT_RANGES.IsSet(this.errorCheck);
			}
			set
			{
				this.errorCheck = global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_INCONSISTENT_RANGES.SetBoolean(this.errorCheck, value);
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x0007CB71 File Offset: 0x0007AD71
		// (set) Token: 0x06002960 RID: 10592 RVA: 0x0007CB83 File Offset: 0x0007AD83
		public bool CheckInconsistentFormulas
		{
			get
			{
				return global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_INCONSISTENT_FORMULAS.IsSet(this.errorCheck);
			}
			set
			{
				this.errorCheck = global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_INCONSISTENT_FORMULAS.SetBoolean(this.errorCheck, value);
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002961 RID: 10593 RVA: 0x0007CB9C File Offset: 0x0007AD9C
		// (set) Token: 0x06002962 RID: 10594 RVA: 0x0007CBAE File Offset: 0x0007ADAE
		public bool CheckDateTimeFormats
		{
			get
			{
				return global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_DATETIME_FORMATS.IsSet(this.errorCheck);
			}
			set
			{
				this.errorCheck = global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_DATETIME_FORMATS.SetBoolean(this.errorCheck, value);
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002963 RID: 10595 RVA: 0x0007CBC7 File Offset: 0x0007ADC7
		// (set) Token: 0x06002964 RID: 10596 RVA: 0x0007CBD9 File Offset: 0x0007ADD9
		public bool CheckUnprotectedFormulas
		{
			get
			{
				return global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_UNPROTECTED_FORMULAS.IsSet(this.errorCheck);
			}
			set
			{
				this.errorCheck = global::NPOI.HSSF.Record.Common.FeatFormulaErr2.CHECK_UNPROTECTED_FORMULAS.SetBoolean(this.errorCheck, value);
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x0007CBF2 File Offset: 0x0007ADF2
		// (set) Token: 0x06002966 RID: 10598 RVA: 0x0007CC04 File Offset: 0x0007AE04
		public bool PerformDataValidation
		{
			get
			{
				return global::NPOI.HSSF.Record.Common.FeatFormulaErr2.PERFORM_DATA_VALIDATION.IsSet(this.errorCheck);
			}
			set
			{
				this.errorCheck = global::NPOI.HSSF.Record.Common.FeatFormulaErr2.PERFORM_DATA_VALIDATION.SetBoolean(this.errorCheck, value);
			}
		}

		// Token: 0x040011E1 RID: 4577
		private static global::NPOI.Util.BitField CHECK_CALCULATION_ERRORS = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040011E2 RID: 4578
		private static global::NPOI.Util.BitField CHECK_EMPTY_CELL_REF = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x040011E3 RID: 4579
		private static global::NPOI.Util.BitField CHECK_NUMBERS_AS_TEXT = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x040011E4 RID: 4580
		private static global::NPOI.Util.BitField CHECK_INCONSISTENT_RANGES = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x040011E5 RID: 4581
		private static global::NPOI.Util.BitField CHECK_INCONSISTENT_FORMULAS = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x040011E6 RID: 4582
		private static global::NPOI.Util.BitField CHECK_DATETIME_FORMATS = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x040011E7 RID: 4583
		private static global::NPOI.Util.BitField CHECK_UNPROTECTED_FORMULAS = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x040011E8 RID: 4584
		private static global::NPOI.Util.BitField PERFORM_DATA_VALIDATION = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x040011E9 RID: 4585
		private int errorCheck;
	}
}
