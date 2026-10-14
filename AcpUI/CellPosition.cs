using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Windows.DataPresenter;

namespace AcpUI
{
	// Token: 0x0200004B RID: 75
	internal struct CellPosition
	{
		// Token: 0x0600040E RID: 1038 RVA: 0x0004579C File Offset: 0x0004399C
		internal CellPosition(global::Infragistics.Windows.DataPresenter.Cell A_0)
		{
			this.a = global::AcpUI.CellPosition.c(A_0);
			this.b = global::AcpUI.CellPosition.b(A_0);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000457C4 File Offset: 0x000439C4
		internal CellPosition(int A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x000457E0 File Offset: 0x000439E0
		internal int ColumnIndex
		{
			get
			{
				short num = (short)655806687;
				short num2 = num;
				num = (short)1346556127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)657784832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1842479105;
				if (num != 0)
				{
				}
				num = (short)343670784;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00045890 File Offset: 0x00043A90
		internal int RowIndex
		{
			get
			{
				short num = (short)1272366258;
				short num2 = num;
				num = (short)1559479474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1982922752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)247398401;
				if (num != 0)
				{
				}
				num = (short)1020919808;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00045940 File Offset: 0x00043B40
		internal static int c(global::Infragistics.Windows.DataPresenter.Cell A_0)
		{
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell> cells = A_0.Record.Cells;
			int num = 0;
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator = cells.GetEnumerator();
			short num2;
			try
			{
				num2 = (short)1339555849;
				int num3 = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_16F;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num2 = (short)1641414658;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::Infragistics.Windows.DataPresenter.Cell cell = enumerator.Current;
						num2 = (short)1564606472;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						num2 = (short)1298202624;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)456720388;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
					{
						global::Infragistics.Windows.DataPresenter.Cell cell;
						if (cell == A_0)
						{
							num2 = (short)1438973959;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						num++;
						num2 = (short)1042546694;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						goto IL_151;
					case 7:
						num2 = (short)671678469;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
					{
						global::Infragistics.Windows.DataPresenter.Cell cell;
						if (cell.Field.Visibility == global::System.Windows.Visibility.Visible)
						{
							num2 = (short)1732378627;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 9:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					IL_98:
					num2 = (short)467075073;
					num3 = (int)((global::System.IntPtr)num2);
					continue;
					IL_61:
					goto IL_98;
				}
				IL_151:
				IL_16F:;
			}
			finally
			{
				num2 = (short)401670146;
				int num3 = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_1DC;
					case 1:
						enumerator.Dispose();
						num2 = (short)1464795136;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1A5;
						}
						continue;
					}
					IL_1A5:
					if (enumerator != null)
					{
						num2 = (short)1163001857;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_1DC:
					num2 = (short)84544550;
					short num4 = num2;
					num2 = (short)1882000422;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A5;
					default:
						goto IL_210;
					}
				}
				IL_210:
				num2 = (short)79626240;
				if (num2 != 0)
				{
				}
			}
			num2 = (short)553648129;
			if (num2 != 0)
			{
			}
			num2 = (short)601620480;
			short num5 = num2;
			return num;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00045BE4 File Offset: 0x00043DE4
		internal static int b(global::Infragistics.Windows.DataPresenter.Cell A_0)
		{
			short num = (short)652923016;
			short num2 = num;
			num = (short)1792594056;
			switch (num2 == num)
			{
			default:
			{
				num = (short)748683264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1214513153;
			if (num != 0)
			{
			}
			num = (short)58327040;
			if (num != 0)
			{
			}
			return A_0.Record.DataItemIndex;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00045C98 File Offset: 0x00043E98
		internal static global::AcpUI.CellPosition a(global::Infragistics.Windows.DataPresenter.Cell A_0)
		{
			short num = (short)1175515454;
			short num2 = num;
			num = (short)1994584382;
			switch (num2 == num)
			{
			default:
			{
				num = (short)366739456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1373700097;
			if (num != 0)
			{
			}
			num = (short)1808793600;
			if (num != 0)
			{
			}
			return new global::AcpUI.CellPosition(global::AcpUI.CellPosition.c(A_0), global::AcpUI.CellPosition.b(A_0));
		}

		// Token: 0x04000252 RID: 594
		private int a;

		// Token: 0x04000253 RID: 595
		private int b;
	}
}
