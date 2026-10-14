using System;
using System.Globalization;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000020 RID: 32
	public sealed class Int32CellRangeSeriesFiller : global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeSeriesFiller<int>
	{
		// Token: 0x060000AB RID: 171 RVA: 0x0000AA28 File Offset: 0x00008C28
		public Int32CellRangeSeriesFiller() : this(null, 1, false)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000AA40 File Offset: 0x00008C40
		public Int32CellRangeSeriesFiller(string name, bool autoCorrect = false) : this(name, 1, autoCorrect)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000AA58 File Offset: 0x00008C58
		public Int32CellRangeSeriesFiller(string name, int increment, bool autoCorrect) : base(name, autoCorrect)
		{
			this.Increment = increment;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000AA74 File Offset: 0x00008C74
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000AB28 File Offset: 0x00008D28
		public int Increment
		{
			get
			{
				short num = (short)2108407426;
				short num2 = num;
				num = (short)1325252226;
				switch (num2 == num)
				{
				}
				num = (short)1567490048;
				short num3 = num;
				num = (short)1821573121;
				if (num != 0)
				{
				}
				num = (short)1072889856;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				int a_ = 11;
				short num;
				if (value < 1)
				{
					num = (short)1638590413;
					short num2 = num;
					num = (short)2127095757;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)837681153;
						if (num != 0)
						{
						}
						num = (short)1188036608;
						if (num != 0)
						{
						}
						break;
					}
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("ꓑ뗓뫕귗뿙", a_));
				}
				num = (short)1684078592;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000AC00 File Offset: 0x00008E00
		protected override bool TryParseValue(string value, out int parsedValue)
		{
			short num = (short)1226534118;
			short num2 = num;
			num = (short)19754214;
			switch (num2 == num)
			{
			}
			num = (short)1462763520;
			short num3 = num;
			num = (short)1292959745;
			if (num != 0)
			{
			}
			num = (short)1335033856;
			if (num != 0)
			{
			}
			return int.TryParse(value, out parsedValue);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000ACB4 File Offset: 0x00008EB4
		protected override bool TryDoIncrement(int oldValue, out int newValue)
		{
			short num = (short)1605563224;
			short num2 = num;
			num = (short)2140402520;
			switch (num2 == num)
			{
			}
			num = (short)1728118784;
			short num3 = num;
			num = (short)758513665;
			if (num != 0)
			{
			}
			num = (short)537133056;
			if (num != 0)
			{
			}
			return this.TryDoIncrement(oldValue, 1, out newValue);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000AD68 File Offset: 0x00008F68
		protected override bool TryDoIncrement(int oldValue, int count, out int newValue)
		{
			short num;
			try
			{
				num = (short)772415383;
				short num2 = num;
				num = (short)1660100503;
				switch (num2 == num)
				{
				}
				num = (short)1735196672;
				if (num != 0)
				{
				}
				newValue = oldValue + this.Increment * count;
			}
			catch (global::System.OverflowException)
			{
				newValue = int.MinValue;
			}
			num = (short)261554177;
			if (num != 0)
			{
			}
			num = (short)1307115520;
			short num3 = num;
			return newValue != int.MinValue;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000AE48 File Offset: 0x00009048
		protected override int ParseValue(string value)
		{
			short num = (short)626117872;
			short num2 = num;
			num = (short)1178914032;
			switch (num2 == num)
			{
			}
			num = (short)602275840;
			short num3 = num;
			num = (short)1467547649;
			if (num != 0)
			{
			}
			num = (short)1855324160;
			if (num != 0)
			{
			}
			return int.Parse(value, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000AF00 File Offset: 0x00009100
		protected override int DoIncrement(int value)
		{
			short num = (short)301165584;
			short num2 = num;
			num = (short)443640848;
			switch (num2 == num)
			{
			}
			num = (short)1855586304;
			short num3 = num;
			num = (short)247791617;
			if (num != 0)
			{
			}
			num = (short)782303232;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000AFB0 File Offset: 0x000091B0
		protected override int DoIncrement(int value, int count)
		{
			short num = (short)2051501398;
			short num2 = num;
			num = (short)36138326;
			switch (num2 == num)
			{
			}
			num = (short)818872320;
			if (num != 0)
			{
			}
			num = (short)664207361;
			if (num != 0)
			{
			}
			num = (short)12517376;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000042 RID: 66
		private int a;
	}
}
