using System;
using System.Globalization;

namespace Motorola.CommonCPS.UI.CellRangeSelect
{
	// Token: 0x02000003 RID: 3
	public struct CellPosition
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public CellPosition(int row, int column)
		{
			int a_ = 9;
			if (row < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("稇攉笋", a_));
			}
			if (column < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("稇攉笋", a_));
			}
			this.a = row;
			this.b = column;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002174 File Offset: 0x00000374
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002224 File Offset: 0x00000424
		public int Row
		{
			get
			{
				short num = (short)1427896330;
				short num2 = num;
				num = (short)810350602;
				switch (num2 == num)
				{
				}
				num = (short)21757952;
				if (num != 0)
				{
				}
				num = (short)1901723649;
				if (num != 0)
				{
				}
				num = (short)532873216;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)540391675;
				short num2 = num;
				num = (short)644987131;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1675165696;
					if (num != 0)
					{
					}
					if (value >= 0)
					{
						this.a = value;
						return;
					}
					break;
				}
				num = (short)1749614592;
				short num3 = num;
				num = (short)811859969;
				if (num != 0)
				{
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000022E4 File Offset: 0x000004E4
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002394 File Offset: 0x00000594
		public int Column
		{
			get
			{
				short num = (short)1255857572;
				short num2 = num;
				num = (short)564780452;
				switch (num2 == num)
				{
				}
				num = (short)1181548545;
				if (num != 0)
				{
				}
				num = (short)97910784;
				if (num != 0)
				{
				}
				num = (short)458752;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1154238120;
				short num2 = num;
				num = (short)606160552;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)40632320;
					if (num != 0)
					{
					}
					if (value >= 0)
					{
						this.b = value;
						return;
					}
					num = (short)283049985;
					if (num != 0)
					{
					}
					num = (short)1197670400;
					short num3 = num;
					break;
				}
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002450 File Offset: 0x00000650
		public override string ToString()
		{
			int a_ = 15;
			short num = (short)1992753153;
			if (num != 0)
			{
			}
			num = (short)1955904267;
			short num2 = num;
			num = (short)907131659;
			switch (num2 == num)
			{
			}
			num = (short)416546816;
			if (num != 0)
			{
			}
			num = (short)703332352;
			short num3 = num;
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("唍欏∑椓㨕挗⬙愛䌝", a_), this.b, this.a);
		}

		// Token: 0x04000003 RID: 3
		private int a;

		// Token: 0x04000004 RID: 4
		private int b;
	}
}
