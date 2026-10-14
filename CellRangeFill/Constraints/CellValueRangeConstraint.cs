using System;
using System.Runtime.CompilerServices;
using Infragistics.Windows.DataPresenter;

namespace Motorola.CommonCPS.UI.CellRangeFill.Constraints
{
	// Token: 0x0200002E RID: 46
	public abstract class CellValueRangeConstraint<TValue> : global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueRangeConstraint<TValue>, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint<TValue>, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint
	{
		// Token: 0x0600010A RID: 266 RVA: 0x0000F604 File Offset: 0x0000D804
		protected CellValueRangeConstraint(TValue minValue, TValue maxValue)
		{
			this.a = minValue;
			this.b = maxValue;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000F628 File Offset: 0x0000D828
		public TValue MinValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)616955905;
				if (num != 0)
				{
				}
				num = (short)22658383;
				short num2 = num;
				num = (short)1336917327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1592655872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1722155008;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000F6DC File Offset: 0x0000D8DC
		public TValue MaxValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1608410853;
				short num2 = num;
				num = (short)1158244069;
				switch (num2 == num)
				{
				}
				num = (short)372244480;
				short num3 = num;
				num = (short)689766400;
				if (num != 0)
				{
				}
				num = (short)1929379841;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0600010D RID: 269
		public abstract bool IsValid(global::Infragistics.Windows.DataPresenter.Cell cell, out string message);

		// Token: 0x0600010E RID: 270
		public abstract bool IsValid(TValue value, out string message);

		// Token: 0x0600010F RID: 271 RVA: 0x0000F790 File Offset: 0x0000D990
		public bool IsValid(object value, out string message)
		{
			int a_ = 11;
			short num;
			if (!(value is TValue))
			{
				num = (short)711248799;
				short num2 = num;
				num = (short)659016607;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1553989632;
					if (num != 0)
					{
					}
					num = (short)1808138241;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("鯑뫓ꃕ맗뛙뗛뫝샟雡鷣雥跧", a_), global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("ꓑ뗓뫕귗뿙", a_), new global::System.InvalidCastException());
				}
			}
			num = (short)1577254912;
			short num3 = num;
			return this.IsValid((TValue)((object)value), out message);
		}

		// Token: 0x0400005A RID: 90
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly TValue a;

		// Token: 0x0400005B RID: 91
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly TValue b;
	}
}
