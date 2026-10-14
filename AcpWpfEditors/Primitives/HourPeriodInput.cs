using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x0200006B RID: 107
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class HourPeriodInput : global::DevComponents.WpfEditors.Primitives.EditorStringListInput
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x000959DC File Offset: 0x00093BDC
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00095A90 File Offset: 0x00093C90
		public global::DevComponents.WpfEditors.Primitives.NumericHourInput HourInput
		{
			get
			{
				short num = (short)1104674817;
				if (num != 0)
				{
				}
				num = (short)1452153622;
				short num2 = num;
				num = (short)424745750;
				switch (num2 == num)
				{
				default:
				{
					num = (short)60686336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)730529792;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)2037055488;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 1:
						goto IL_12D;
					case 2:
						goto IL_12F;
					case 3:
						this.a.ValueChanged -= this.a;
						num = (short)1038680066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.a != null)
						{
							num = (short)1726087173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A1;
					case 5:
						goto IL_FD;
					}
					IL_3D:
					num = (short)1522816787;
					short num3 = num;
					num = (short)1001019155;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_FD:
						this.a.ValueChanged += this.a;
						num = (short)1626537985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
					{
						num = (short)1345388544;
						if (num != 0)
						{
						}
						num = (short)1074266112;
						short num4 = num;
						if (this.a != null)
						{
							num = (short)1375076353;
							if (num != 0)
							{
							}
							num = (short)16318467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_12F:
					this.a = value;
					num = (short)1329266692;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12D:
				IL_1A1:
				this.c();
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00095C44 File Offset: 0x00093E44
		private void c()
		{
			short num = (short)1604386816;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 1:
					if (this.a.Period == global::DevComponents.WpfEditors.Primitives.eHourPeriod.AM)
					{
						num = (short)778043392;
						short num3 = num;
						num = (short)1674051588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11D;
				case 2:
					goto IL_B4;
				case 3:
					return;
				case 4:
					goto IL_11A;
				case 5:
				{
					int? value;
					if (value != null)
					{
						num = (short)766836738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_197;
				}
				}
				IL_3C:
				if (this.a != null)
				{
					num = (short)2087321601;
					if (num != 0)
					{
					}
					int? value = this.a.Value;
					num = (short)212598789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1922440473;
				short num4 = num;
				num = (short)1648434457;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1486749696;
					if (num != 0)
					{
					}
					num = (short)1771241475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B4:
				num = (short)1622999041;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_11A:
			base.SelectedIndex = 0;
			return;
			IL_11D:
			base.SelectedIndex = 1;
			return;
			IL_197:
			base.SelectedIndex = -1;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00095DF0 File Offset: 0x00093FF0
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1840153866;
			short num2 = num;
			num = (short)1154188554;
			switch (num2 == num)
			{
			}
			num = (short)1958477824;
			short num3 = num;
			num = (short)1508769792;
			if (num != 0)
			{
			}
			num = (short)1906704385;
			if (num != 0)
			{
			}
			this.c();
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00095EA0 File Offset: 0x000940A0
		protected override global::System.Collections.Generic.List<string> GetItems()
		{
			short num = (short)644218881;
			if (num != 0)
			{
			}
			num = (short)1433201189;
			short num2 = num;
			num = (short)1958865445;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1953431552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)862257152;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>(2)
			{
				this.a(),
				this.b()
			};
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00095F6C File Offset: 0x0009416C
		private string b()
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1383006208;
					short num3 = num2;
					if (this.d.Length > 0)
					{
						num2 = (short)1342767110;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B6;
				}
				case 1:
					if (text.Length > 0)
					{
						num2 = (short)1760100360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 2:
					num2 = (short)826605568;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1258029057;
					if (num2 != 0)
					{
					}
					if (this.b)
					{
						num2 = (short)1736048647;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 4:
					goto IL_197;
				case 5:
					if (this.d != null)
					{
						num2 = (short)1903624194;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B6;
				case 6:
					IL_147:
					text = this.d;
					num2 = (short)1775960074;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1079640065;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					text = text[0].ToString();
					num2 = (short)1452015625;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return text;
				case 10:
					goto IL_197;
				}
				goto IL_3C;
				IL_B6:
				text = global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.PMDesignator;
				num2 = (short)1634992132;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_197:
				num2 = (short)281021090;
				short num4 = num2;
				num2 = (short)1326254754;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_147;
				default:
					num2 = (short)1469513728;
					if (num2 != 0)
					{
					}
					num2 = (short)1941635075;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return text;
			IL_3C:
			text = "";
			num2 = (short)229572613;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000961BC File Offset: 0x000943BC
		private string a()
		{
			switch (0)
			{
			case 0:
				goto IL_64;
			}
			short num;
			int num2;
			string text;
			for (;;)
			{
				IL_0A:
				num = (short)1918697473;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (this.c.Length > 0)
					{
						num = (short)1300299782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF;
				case 1:
					if (text.Length > 0)
					{
						num = (short)1948319752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				case 2:
				{
					num = (short)898367488;
					short num3 = num;
					num = (short)850591744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (this.b)
					{
						num = (short)1897725959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				case 4:
					goto IL_1C1;
				case 5:
					if (this.c != null)
					{
						num = (short)1803288578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF;
				case 6:
					IL_170:
					text = this.c;
					num = (short)963182602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1437138945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					text = text[0].ToString();
					num = (short)1473904649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return text;
				case 10:
					goto IL_1C1;
				}
				goto IL_64;
				IL_DF:
				text = global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.AMDesignator;
				num = (short)1180106756;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C1:
				num = (short)1975056254;
				short num4 = num;
				num = (short)1668282238;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_170;
				default:
					num = (short)63766528;
					if (num != 0)
					{
					}
					num = (short)526254083;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return text;
			IL_64:
			text = "";
			num = (short)1802240005;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00096414 File Offset: 0x00094614
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x000964C4 File Offset: 0x000946C4
		public bool UseSingleLetterLabel
		{
			get
			{
				short num = (short)1298203349;
				short num2 = num;
				num = (short)1581122261;
				switch (num2 == num)
				{
				}
				num = (short)2113208320;
				short num3 = num;
				num = (short)49152000;
				if (num != 0)
				{
				}
				num = (short)224133121;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1303969792;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_14;
					case 1:
					{
						num = (short)1427243008;
						short num3 = num;
						this.b = value;
						base.InvalidateArrange();
						num = (short)1938489346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_F1;
					}
					goto IL_30;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_30:
						if (this.b == value)
						{
							goto IL_F3;
						}
						num = (short)1855038881;
						short num4 = num;
						num = (short)553887137;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)1439694848;
							if (num != 0)
							{
							}
							num = (short)332922881;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
				}
				IL_F1:
				IL_F3:
				num = (short)2099576833;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x000965EC File Offset: 0x000947EC
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00096698 File Offset: 0x00094898
		[global::System.ComponentModel.DefaultValue("")]
		public string AMText
		{
			get
			{
				short num = (short)1327180441;
				short num2 = num;
				num = (short)2057382553;
				switch (num2 == num)
				{
				}
				num = (short)1049559040;
				short num3 = num;
				num = (short)1724055553;
				if (num != 0)
				{
				}
				num = (short)1092485120;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)2130182357;
				short num2 = num;
				num = (short)1533411541;
				switch (num2 == num)
				{
				}
				num = (short)182976512;
				short num3 = num;
				num = (short)1894252545;
				if (num != 0)
				{
				}
				num = (short)1151139840;
				if (num != 0)
				{
				}
				this.c = value;
				base.InvalidateMeasure();
				base.InvalidateVisual();
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00096754 File Offset: 0x00094954
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00096804 File Offset: 0x00094A04
		[global::System.ComponentModel.DefaultValue("")]
		public string PMText
		{
			get
			{
				short num = (short)1916993537;
				if (num != 0)
				{
				}
				num = (short)2130130267;
				short num2 = num;
				num = (short)195573083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2044854272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)508100608;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1764015244;
				short num2 = num;
				num = (short)254721164;
				switch (num2 == num)
				{
				}
				num = (short)351862784;
				short num3 = num;
				num = (short)1285947393;
				if (num != 0)
				{
				}
				num = (short)1628700672;
				if (num != 0)
				{
				}
				this.d = value;
				base.InvalidateMeasure();
				base.InvalidateVisual();
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000968C0 File Offset: 0x00094AC0
		protected override void OnSelectedIndexChanged()
		{
			short num = (short)1988165632;
			switch (num)
			{
			default:
			{
				num = (short)145555459;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfEditors.Primitives.eHourPeriod eHourPeriod;
					global::DevComponents.WpfEditors.Primitives.eHourPeriod eHourPeriod2;
					switch (num2)
					{
					case 0:
						num = (short)1186267155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int? value = this.a.Value;
						num = (short)1308753922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						int? value;
						if (value != null)
						{
							num = (short)599719943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1633419285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					case 4:
					{
						global::DevComponents.WpfEditors.Primitives.NumericHourInput numericHourInput = this.a;
						int? value = numericHourInput.Value;
						numericHourInput.Value = value - 12;
						num = (short)42663951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2A8;
					case 6:
						num = (short)2077294596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)544538637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						eHourPeriod = global::DevComponents.WpfEditors.Primitives.eHourPeriod.PM;
						goto IL_48C;
					case 9:
					{
						int? value;
						int num3;
						if (value.GetValueOrDefault() >= num3 & value != null)
						{
							num = (short)1584267270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_549;
					}
					case 10:
						num = (short)508297217;
						if (num != 0)
						{
						}
						num = (short)2142961675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (!this.a.IsEmpty)
						{
							num = (short)421396503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_549;
					case 12:
						this.a.Value = new int?(0);
						num = (short)476577797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						if (eHourPeriod2 == global::DevComponents.WpfEditors.Primitives.eHourPeriod.AM)
						{
							num = (short)268697618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int? value = this.a.Value;
						int num3 = 12;
						num = (short)1231224848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)865140753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_487;
					case 16:
					{
						int? value;
						int num3;
						if (value.GetValueOrDefault() < num3 & value != null)
						{
							num = (short)113639438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_549;
					}
					case 17:
					{
						global::DevComponents.WpfEditors.Primitives.NumericHourInput numericHourInput2 = this.a;
						int? value = numericHourInput2.Value;
						numericHourInput2.Value = value + 12;
						num = (short)1225785369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						int? value = this.a.Value;
						int num3 = 12;
						num = (short)1476722697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						eHourPeriod = global::DevComponents.WpfEditors.Primitives.eHourPeriod.AM;
						goto IL_48C;
					case 20:
					{
						if (this.a.Period == eHourPeriod2)
						{
							goto IL_549;
						}
						num = (short)1648099328;
						short num4 = num;
						num = (short)1558997276;
						short num5 = num;
						num = (short)56584476;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12E;
						default:
							num = (short)237633536;
							if (num != 0)
							{
							}
							num = (short)1028259841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
						if (eHourPeriod2 == global::DevComponents.WpfEditors.Primitives.eHourPeriod.AM)
						{
							num = (short)1767637004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Value = new int?(12);
						num = (short)1953759254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_2D7;
					case 23:
						num = (short)1558446104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (base.SelectedIndex != 1)
						{
							num = (short)602275840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12E;
					case 25:
						goto IL_351;
					}
					IL_AC:
					if (this.a != null)
					{
						num = (short)870907914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_12E:
					num = (short)1375731720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48C:
					eHourPeriod2 = eHourPeriod;
					num = (short)366542868;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2A8:
				IL_2D7:
				IL_351:
				IL_487:
				IL_549:
				base.OnSelectedIndexChanged();
				return;
			}
			}
		}

		// Token: 0x040002EB RID: 747
		private global::DevComponents.WpfEditors.Primitives.NumericHourInput a;

		// Token: 0x040002EC RID: 748
		private bool b;

		// Token: 0x040002ED RID: 749
		private string c = "";

		// Token: 0x040002EE RID: 750
		private string d = "";
	}
}
