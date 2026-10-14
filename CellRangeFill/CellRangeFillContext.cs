using System;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x0200000D RID: 13
	public class CellRangeFillContext
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00005850 File Offset: 0x00003A50
		public CellRangeFillContext(global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller filler, global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillParameter fillParameter)
		{
			int a_ = 5;
			base..ctor();
			if (filler == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("꫋ꟍ볏뻑뇓ꓕ", a_));
			}
			if (fillParameter == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("꫋ꟍ볏뻑蓓럕꫗믙뇛믝铟蟡難", a_));
			}
			this.a = filler;
			this.b = fillParameter;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000058AC File Offset: 0x00003AAC
		public global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller Filler
		{
			get
			{
				short num = (short)1791128233;
				short num2 = num;
				num = (short)1317040809;
				switch (num2 == num)
				{
				}
				num = (short)1937506304;
				short num3 = num;
				num = (short)970260481;
				if (num != 0)
				{
				}
				num = (short)1299513344;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000595C File Offset: 0x00003B5C
		public global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillParameter Parameter
		{
			get
			{
				short num = (short)62791798;
				short num2 = num;
				num = (short)1924931702;
				switch (num2 == num)
				{
				}
				num = (short)1363673088;
				short num3 = num;
				num = (short)2025848833;
				if (num != 0)
				{
				}
				num = (short)1002373120;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0400001F RID: 31
		private readonly global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller a;

		// Token: 0x04000020 RID: 32
		private readonly global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillParameter b;
	}
}
