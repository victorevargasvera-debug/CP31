using System;
using System.Collections.Generic;
using System.Globalization;

namespace Motorola.CommonCPS.UI.CellRangeSelect
{
	// Token: 0x02000005 RID: 5
	public struct CellRange
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002530 File Offset: 0x00000730
		public static global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange Empty
		{
			get
			{
				short num = (short)826130941;
				short num2 = num;
				num = (short)1113702909;
				switch (num2 == num)
				{
				}
				num = (short)2117271553;
				if (num != 0)
				{
				}
				num = (short)527564800;
				if (num != 0)
				{
				}
				num = (short)1729888256;
				short num3 = num;
				return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange.e;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000025E0 File Offset: 0x000007E0
		public CellRange(int startRow, int endRow, int column)
		{
			this = new global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange(startRow, endRow, column, column);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000025F8 File Offset: 0x000007F8
		public CellRange(int startRow, int endRow, int startColumn, int endColumn)
		{
			int a_ = 11;
			if (startRow < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("礉砋漍戏昑䘓礕漗", a_));
			}
			if (endRow < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("漉戋樍䈏紑挓", a_));
			}
			if (startColumn < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("礉砋漍戏昑圓礕琗漙焛瀝", a_));
			}
			if (endColumn < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("漉戋樍匏紑砓挕甗琙", a_));
			}
			this.a = startRow;
			this.b = endRow;
			this.c = startColumn;
			this.d = endColumn;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002694 File Offset: 0x00000894
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder RowOrder
		{
			get
			{
				short num = (short)1558839298;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder.Descending;
					case 1:
					{
						num = (short)1573118954;
						short num3 = num;
						num = (short)941941738;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16;
						default:
							num = (short)1030946816;
							if (num != 0)
							{
							}
							num = (short)638844931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_16;
					case 3:
						if (this.b == -2147483648)
						{
							num = (short)2082406404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FB;
					case 4:
						return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder.Undefined;
					case 5:
						if (this.a > this.b)
						{
							num = (short)1550712832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder.Ascending;
					}
					goto IL_8D;
					IL_16:
					num = (short)495976448;
					short num4 = num;
					num = (short)1144061953;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						IL_8D:
						if (this.a != -2147483648)
						{
							goto IL_FB;
						}
						num = (short)1025703937;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_FB:
					num = (short)1356791813;
					num2 = (int)((global::System.IntPtr)num);
				}
				return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder.Descending;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002824 File Offset: 0x00000A24
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder ColumnOrder
		{
			get
			{
				short num = (short)2128150530;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder.Descending;
					case 1:
					{
						num = (short)132107716;
						short num3 = num;
						num = (short)464899524;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)443219969;
							if (num != 0)
							{
							}
							num = (short)1259208704;
							if (num != 0)
							{
							}
							num = (short)506462211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_14;
					case 3:
						if (this.d == -2147483648)
						{
							num = (short)441843716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC;
					case 4:
						return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder.Undefined;
					case 5:
						if (this.c > this.d)
						{
							num = (short)166002688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder.Ascending;
					}
					goto IL_65;
					IL_14:
					num = (short)266993664;
					short num4 = num;
					switch (0)
					{
					case 0:
						IL_65:
						if (this.c != -2147483648)
						{
							goto IL_FC;
						}
						num = (short)1187512321;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_FC:
					num = (short)1252196357;
					num2 = (int)((global::System.IntPtr)num);
				}
				return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder.Descending;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000029B0 File Offset: 0x00000BB0
		public int StartRow
		{
			get
			{
				short num = (short)1900096087;
				short num2 = num;
				num = (short)1185032791;
				switch (num2 == num)
				{
				}
				num = (short)1552547841;
				if (num != 0)
				{
				}
				num = (short)751173632;
				if (num != 0)
				{
				}
				num = (short)1006764032;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002A60 File Offset: 0x00000C60
		public int EndRow
		{
			get
			{
				short num = (short)1607771202;
				short num2 = num;
				num = (short)1991156802;
				switch (num2 == num)
				{
				}
				num = (short)1132855297;
				if (num != 0)
				{
				}
				num = (short)1607467008;
				if (num != 0)
				{
				}
				num = (short)1118371840;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002B10 File Offset: 0x00000D10
		public int StartColumn
		{
			get
			{
				short num = (short)852701712;
				short num2 = num;
				num = (short)877605392;
				switch (num2 == num)
				{
				}
				num = (short)1452081153;
				if (num != 0)
				{
				}
				num = (short)559874048;
				if (num != 0)
				{
				}
				num = (short)1212547072;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002BBC File Offset: 0x00000DBC
		public int EndColumn
		{
			get
			{
				short num = (short)1519895466;
				short num2 = num;
				num = (short)534299562;
				switch (num2 == num)
				{
				}
				num = (short)633929729;
				if (num != 0)
				{
				}
				num = (short)334954496;
				if (num != 0)
				{
				}
				num = (short)526843904;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002C6C File Offset: 0x00000E6C
		public int Height
		{
			get
			{
				short num = (short)2083151951;
				short num2 = num;
				num = (short)61562959;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2037972993;
					if (num != 0)
					{
					}
					num = (short)959381504;
					if (num != 0)
					{
					}
					if (!this.IsEmpty)
					{
						return global::System.Math.Abs(this.b - this.a) + 1;
					}
					num = (short)368574464;
					short num3 = num;
					break;
				}
				}
				return int.MinValue;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002D3C File Offset: 0x00000F3C
		public int Width
		{
			get
			{
				short num = (short)1255262274;
				short num2 = num;
				num = (short)225626178;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1458110464;
					if (num != 0)
					{
					}
					num = (short)1942880257;
					if (num != 0)
					{
					}
					if (!this.IsEmpty)
					{
						return global::System.Math.Abs(this.d - this.c) + 1;
					}
					num = (short)838860800;
					short num3 = num;
					break;
				}
				}
				return int.MinValue;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002E08 File Offset: 0x00001008
		public bool IsSingleRowRange
		{
			get
			{
				short num = (short)1322262756;
				short num2 = num;
				num = (short)449585380;
				switch (num2 == num)
				{
				}
				num = (short)526516224;
				if (num != 0)
				{
				}
				num = (short)1771503617;
				if (num != 0)
				{
				}
				num = (short)610598912;
				short num3 = num;
				return this.Height == 1;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002EBC File Offset: 0x000010BC
		public bool IsSingleColumnRange
		{
			get
			{
				short num = (short)1802051120;
				short num2 = num;
				num = (short)1433214512;
				switch (num2 == num)
				{
				}
				num = (short)512753664;
				if (num != 0)
				{
				}
				num = (short)1934819329;
				if (num != 0)
				{
				}
				num = (short)1880031232;
				short num3 = num;
				return this.Width == 1;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002F70 File Offset: 0x00001170
		public bool IsSingleCellRange
		{
			get
			{
				short num = (short)506877571;
				short num2 = num;
				num = (short)1739282051;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1248264193;
					if (num != 0)
					{
					}
					num = (short)459079680;
					if (num != 0)
					{
					}
					if (!this.IsSingleRowRange)
					{
						return false;
					}
					num = (short)1350434816;
					short num3 = num;
					break;
				}
				}
				return this.IsSingleColumnRange;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003030 File Offset: 0x00001230
		public bool IsEmpty
		{
			get
			{
				short num = (short)69730306;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_14B;
					case 1:
						num = (short)409600003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_16;
					case 3:
						if (this.c == -2147483648)
						{
							num = (short)1381236740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						num = (short)1283325957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.b == -2147483648)
						{
							num = (short)180092928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_3E;
					IL_16:
					switch (0)
					{
					case 0:
					{
						IL_3E:
						num = (short)1619883656;
						short num3 = num;
						num = (short)1151039112;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16;
						default:
						{
							num = (short)468385792;
							short num4 = num;
							num = (short)1017380864;
							if (num != 0)
							{
							}
							num = (short)219348993;
							if (num != 0)
							{
							}
							if (this.a != -2147483648)
							{
								return false;
							}
							num = (short)1028849665;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
						break;
					}
					}
				}
				IL_14B:
				return this.d == int.MinValue;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000031CC File Offset: 0x000013CC
		public bool IsNormalized
		{
			get
			{
				short num = (short)773114089;
				short num2 = num;
				num = (short)1919338729;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1098252288;
					if (num != 0)
					{
					}
					num = (short)1912209409;
					if (num != 0)
					{
					}
					if (this.a > this.b)
					{
						return false;
					}
					num = (short)1486946304;
					short num3 = num;
					break;
				}
				}
				return this.c <= this.d;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000329C File Offset: 0x0000149C
		public void Normalize()
		{
			short num = (short)99745794;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.c > this.d)
					{
						num = (short)1904738307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)2055733249;
					if (num != 0)
					{
					}
					num = (short)1422524735;
					short num3 = num;
					num = (short)234684735;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
					{
						num = (short)1939341312;
						if (num != 0)
						{
						}
						int num4 = this.b;
						this.b = this.a;
						this.a = num4;
						num = (short)1534525444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_14;
				case 3:
				{
					int num4 = this.d;
					this.d = this.c;
					this.c = num4;
					num = (short)1488977925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_130;
				case 5:
					return;
				}
				goto IL_64;
				IL_14:
				num = (short)1910112256;
				short num5 = num;
				switch (0)
				{
				case 0:
					IL_64:
					if (this.a <= this.b)
					{
						goto IL_130;
					}
					num = (short)1095761921;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_130:
				num = (short)852951040;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000344C File Offset: 0x0000164C
		public override string ToString()
		{
			int a_ = 0;
			short num = (short)1521958324;
			short num2 = num;
			num = (short)2045722036;
			switch (num2 == num)
			{
			}
			num = (short)1876099072;
			if (num != 0)
			{
			}
			num = (short)562823169;
			if (num != 0)
			{
			}
			num = (short)560529408;
			short num3 = num;
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("蓾㄀縂⤄簆㠈瘊ℌ琎⌐渒㤔氖⨘昚", a_), new object[]
			{
				this.c,
				this.a,
				this.d,
				this.b
			});
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003554 File Offset: 0x00001754
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition TopLeft
		{
			get
			{
				short num = (short)681836545;
				if (num != 0)
				{
				}
				num = (short)1570027458;
				short num2 = num;
				num = (short)734181314;
				switch (num2 == num)
				{
				}
				num = (short)791674880;
				short num3 = num;
				num = (short)1209073664;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition
				{
					Row = ((this.a < this.b) ? this.a : this.b),
					Column = ((this.c < this.d) ? this.c : this.d)
				};
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003650 File Offset: 0x00001850
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition TopRight
		{
			get
			{
				short num = (short)355467265;
				if (num != 0)
				{
				}
				num = (short)1939190621;
				short num2 = num;
				num = (short)234730333;
				switch (num2 == num)
				{
				}
				num = (short)1647837184;
				short num3 = num;
				num = (short)1368522752;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition
				{
					Row = ((this.a < this.b) ? this.a : this.b),
					Column = ((this.d > this.c) ? this.d : this.c)
				};
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003750 File Offset: 0x00001950
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition BottomLeft
		{
			get
			{
				short num = (short)2014295624;
				short num2 = num;
				num = (short)999339592;
				switch (num2 == num)
				{
				}
				num = (short)785514496;
				if (num != 0)
				{
				}
				num = (short)1528496128;
				short num3 = num;
				num = (short)1216872449;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition
				{
					Row = ((this.b > this.a) ? this.b : this.a),
					Column = ((this.c < this.d) ? this.c : this.d)
				};
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003850 File Offset: 0x00001A50
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition BottomRight
		{
			get
			{
				short num = (short)212176341;
				short num2 = num;
				num = (short)1261342165;
				switch (num2 == num)
				{
				}
				num = (short)1753481216;
				if (num != 0)
				{
				}
				num = (short)1205075968;
				short num3 = num;
				num = (short)1056440321;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition
				{
					Row = ((this.b > this.a) ? this.b : this.a),
					Column = ((this.d > this.c) ? this.d : this.c)
				};
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003954 File Offset: 0x00001B54
		public global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> Forward()
		{
			short num = (short)392651573;
			short num2 = num;
			num = (short)673932085;
			switch (num2 == num)
			{
			}
			num = (short)2090270720;
			if (num != 0)
			{
			}
			num = (short)1656750080;
			short num3 = num;
			num = (short)1631584257;
			if (num != 0)
			{
			}
			return this.Forward(this.a, this.b, null);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003A10 File Offset: 0x00001C10
		public global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> Forward(int startRow, int endRow, global::System.Collections.Generic.List<int> selectionIndexes = null)
		{
			short num = (short)2060169974;
			short num2 = num;
			num = (short)168407798;
			switch (num2 == num)
			{
			}
			num = (short)469762049;
			if (num != 0)
			{
			}
			num = (short)1148190720;
			short num3 = num;
			num = (short)1685454848;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange.a a = new global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange.a(-2);
			a.e = this;
			a.g = startRow;
			a.i = endRow;
			a.k = selectionIndexes;
			return a;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> Reverse()
		{
			short num = (short)1901956999;
			short num2 = num;
			num = (short)222269319;
			switch (num2 == num)
			{
			}
			num = (short)973799425;
			if (num != 0)
			{
			}
			num = (short)70647808;
			short num3 = num;
			num = (short)1024000000;
			if (num != 0)
			{
			}
			return this.Reverse(this.a, this.b, null);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003B9C File Offset: 0x00001D9C
		public global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> Reverse(int startRow, int endRow, global::System.Collections.Generic.List<int> selectionIndexes = null)
		{
			short num = (short)148241115;
			short num2 = num;
			num = (short)555219675;
			switch (num2 == num)
			{
			}
			num = (short)2133590017;
			if (num != 0)
			{
			}
			num = (short)2057764864;
			short num3 = num;
			num = (short)809238528;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange.b b = new global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange.b(-2);
			b.e = this;
			b.g = startRow;
			b.i = endRow;
			b.k = selectionIndexes;
			return b;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003C70 File Offset: 0x00001E70
		// Note: this type is marked as 'beforefieldinit'.
		static CellRange()
		{
			short num = (short)1163056485;
			short num2 = num;
			num = (short)766891365;
			switch (num2 == num)
			{
			}
			num = (short)941883393;
			if (num != 0)
			{
			}
			num = (short)1561788416;
			short num3 = num;
			num = (short)1170997248;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange.e = new global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange
			{
				a = int.MinValue,
				c = int.MinValue,
				b = int.MinValue,
				d = int.MinValue
			};
		}

		// Token: 0x04000009 RID: 9
		private int a;

		// Token: 0x0400000A RID: 10
		private int b;

		// Token: 0x0400000B RID: 11
		private int c;

		// Token: 0x0400000C RID: 12
		private int d;

		// Token: 0x0400000D RID: 13
		private static readonly global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange e;
	}
}
