using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000059 RID: 89
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DayLabelItem : global::System.Windows.Controls.Label, global::DevComponents.WpfEditors.Primitives.IDateTimePartInput
	{
		// Token: 0x060005B1 RID: 1457 RVA: 0x00079634 File Offset: 0x00077834
		public DayLabelItem()
		{
			base.Margin = default(global::System.Windows.Thickness);
			base.Padding = default(global::System.Windows.Thickness);
			base.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
			base.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00079674 File Offset: 0x00077874
		static DayLabelItem()
		{
			short num = (short)13172736;
			short num2 = num;
			num = (short)1254870700;
			short num3 = num;
			num = (short)1154731692;
			switch (num3 == num)
			{
			}
			num = (short)1055784960;
			if (num != 0)
			{
			}
			num = (short)1516961793;
			if (num != 0)
			{
			}
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.DayLabelItem), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0007973C File Offset: 0x0007793C
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x000797EC File Offset: 0x000779EC
		[global::System.ComponentModel.DefaultValue(null)]
		public int? Day
		{
			get
			{
				short num = (short)1115029504;
				short num2 = num;
				num = (short)985325450;
				short num3 = num;
				num = (short)679927690;
				switch (num3 == num)
				{
				}
				num = (short)277348353;
				if (num != 0)
				{
				}
				num = (short)951517184;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				int a_ = 17;
				switch (0)
				{
				case 0:
					goto IL_3D;
				}
				int num;
				int? num2;
				short num4;
				int? num6;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = value;
						int num3 = 6;
						num4 = (short)801046536;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					case 1:
						goto IL_11E;
					case 2:
					{
						num4 = (short)942800896;
						short num5 = num4;
						num4 = (short)1402798086;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					case 3:
						if (!(num6.GetValueOrDefault() == num2.GetValueOrDefault() & num6 != null == (num2 != null)))
						{
							num4 = (short)1509949442;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						goto IL_1D1;
					case 4:
					{
						int num3;
						if (!(num2.GetValueOrDefault() < num3 & num2 != null))
						{
							goto IL_1B3;
						}
						goto IL_C3;
					}
					case 5:
					{
						num2 = value;
						int num3 = 0;
						num4 = (short)168558596;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					case 6:
						if (value != null)
						{
							num4 = (short)991297541;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						goto IL_15A;
					case 7:
						goto IL_1D1;
					case 8:
					{
						int num3;
						if (num2.GetValueOrDefault() > num3 & num2 != null)
						{
							num4 = (short)868876289;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						goto IL_15A;
					}
					}
					goto IL_3D;
					IL_15A:
					this.a = value;
					this.b();
					num4 = (short)1475674119;
					num = (int)((global::System.IntPtr)num4);
					continue;
					IL_1B3:
					num4 = (short)1146290176;
					num = (int)((global::System.IntPtr)num4);
					continue;
					IL_1D1:
					num4 = (short)776077313;
					if (num4 != 0)
					{
					}
					num4 = (short)295328809;
					short num7 = num4;
					num4 = (short)491543593;
					switch ((num7 == num4) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B3;
					default:
						goto IL_22D;
					}
				}
				IL_C3:
				throw new global::System.ArgumentException(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髝臟鯡쓣该鷧駩飫컭鋯韱퓳胵駷雹觻鯽⃿态愃爅缇漉椋怍』∑㐓眕瘗縙㰛⠝", a_));
				IL_11E:
				goto IL_C3;
				IL_22D:
				num4 = (short)563150848;
				if (num4 != 0)
				{
				}
				return;
				IL_3D:
				num6 = this.a;
				num2 = value;
				num4 = (short)662372355;
				num = (int)((global::System.IntPtr)num4);
				goto IL_13;
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00079A3C File Offset: 0x00077C3C
		private void b()
		{
			short num = (short)2055077888;
			short num2 = num;
			num = (short)2020205268;
			short num3 = num;
			num = (short)425190100;
			switch (num3 == num)
			{
			}
			num = (short)2085617664;
			if (num != 0)
			{
			}
			num = (short)597753857;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00079AEC File Offset: 0x00077CEC
		private void a()
		{
			short num = (short)181993474;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1AB;
				case 1:
				{
					num = (short)177864705;
					if (num != 0)
					{
					}
					int? num3 = this.a;
					int num4 = -1;
					num = (short)559611908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 3:
					goto IL_CE;
				case 4:
				{
					num = (short)769052287;
					short num5 = num;
					num = (short)687591039;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1330905088;
						if (num != 0)
						{
						}
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() == num4 & num3 != null)
						{
							num = (short)58195968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)306970629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					if (this.b != null)
					{
						num = (short)1963393030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1807810567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_10A;
				case 7:
					if (this.c)
					{
						num = (short)956694531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F8;
				}
				IL_45:
				if (this.a == null)
				{
					goto IL_1CF;
				}
				num = (short)1313275905;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CE:
			this.Text = global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.AbbreviatedDayNames[this.a.Value];
			return;
			IL_10A:
			this.Text = this.b[this.a.Value];
			return;
			IL_1AB:
			IL_1CF:
			this.Text = "";
			return;
			IL_1F8:
			num = (short)1727660032;
			short num6 = num;
			this.Text = global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.DayNames[this.a.Value];
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00079D3C File Offset: 0x00077F3C
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00079DE8 File Offset: 0x00077FE8
		public global::System.Collections.Generic.List<string> DayNames
		{
			get
			{
				short num = (short)1087766528;
				short num2 = num;
				num = (short)1441597676;
				short num3 = num;
				num = (short)301861100;
				switch (num3 == num)
				{
				}
				num = (short)39518208;
				if (num != 0)
				{
				}
				num = (short)587923457;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				int a_ = 19;
				short num = (short)2131820544;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)286481687;
					short num3 = num;
					num = (short)1595038999;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)731512832;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							num = (short)1906900993;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_AF;
							}
							continue;
						case 1:
							goto IL_116;
						case 2:
							if (value.Count != 7)
							{
								num = (short)1553661953;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_118;
						case 3:
							goto IL_C6;
						}
						IL_AF:
						if (value != null)
						{
							num = (short)493355011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_118;
					}
					IL_C6:
					num = (short)1706688514;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_116:
				throw new global::System.ArgumentException(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꓟ菡鷣꣥觧蟩觫鷭탯鿱至藵賷\udaf9铻鿽盿朁␃挅瀇欉漋稍簏欑㐓ℕ㠗猙栛笝䴟儡У伥䘧਩伫䄭尯帱儳唵䰷匹医倽渿", a_));
				IL_118:
				num = (short)1385824256;
				short num4 = num;
				this.b = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00079F40 File Offset: 0x00078140
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00079FF0 File Offset: 0x000781F0
		[global::System.ComponentModel.DefaultValue(false)]
		public bool UseAbbreviatedNames
		{
			get
			{
				short num = (short)1605566464;
				short num2 = num;
				num = (short)1964719560;
				short num3 = num;
				num = (short)520240584;
				switch (num3 == num)
				{
				}
				num = (short)703266817;
				if (num != 0)
				{
				}
				num = (short)894238720;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1445068802;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_C0;
					case 1:
						this.c = value;
						this.a();
						num = (short)1853685760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1806615419;
						short num3 = num;
						num = (short)1706083195;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)351666176;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7E;
							}
							continue;
						}
						break;
					}
					}
					IL_7E:
					if (this.c == value)
					{
						break;
					}
					num = (short)672923649;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C0:
				num = (short)307822593;
				if (num != 0)
				{
				}
				num = (short)1715929088;
				short num4 = num;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0007A114 File Offset: 0x00078314
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x0007A1C8 File Offset: 0x000783C8
		public string Text
		{
			get
			{
				short num = (short)276758528;
				short num2 = num;
				num = (short)949911860;
				short num3 = num;
				num = (short)127041844;
				switch (num3 == num)
				{
				}
				num = (short)2099838977;
				if (num != 0)
				{
				}
				num = (short)1503395840;
				if (num != 0)
				{
				}
				return (string)base.Content;
			}
			set
			{
				short num = (short)1687355392;
				short num2 = num;
				num = (short)132023458;
				short num3 = num;
				num = (short)658212002;
				switch (num3 == num)
				{
				}
				num = (short)1036517376;
				if (num != 0)
				{
				}
				num = (short)1101791233;
				if (num != 0)
				{
				}
				base.Content = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0007A274 File Offset: 0x00078474
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x0007A324 File Offset: 0x00078524
		int? global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.Value
		{
			get
			{
				short num = (short)709427200;
				short num2 = num;
				num = (short)77878074;
				short num3 = num;
				num = (short)1575768890;
				switch (num3 == num)
				{
				}
				num = (short)995229697;
				if (num != 0)
				{
				}
				num = (short)1157365760;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1984364544;
				short num2 = num;
				num = (short)1917835838;
				short num3 = num;
				num = (short)388028990;
				switch (num3 == num)
				{
				}
				num = (short)1533083649;
				if (num != 0)
				{
				}
				num = (short)1146880000;
				if (num != 0)
				{
				}
				this.Day = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0007A3D4 File Offset: 0x000785D4
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x0007A480 File Offset: 0x00078680
		int global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.MinValue
		{
			get
			{
				short num = (short)2062811136;
				short num2 = num;
				num = (short)1976257330;
				short num3 = num;
				num = (short)1838238514;
				switch (num3 == num)
				{
				}
				num = (short)1030619136;
				if (num != 0)
				{
				}
				num = (short)2038562817;
				if (num != 0)
				{
				}
				return 0;
			}
			set
			{
				int a_ = 13;
				short num = (short)1322188800;
				short num2 = num;
				num = (short)881197057;
				if (num != 0)
				{
				}
				num = (short)2076976397;
				short num3 = num;
				num = (short)703210765;
				switch (num3 == num)
				{
				}
				num = (short)196411392;
				if (num != 0)
				{
				}
				throw new global::System.Exception(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軙듛믝샟迡臣鋥胧藩裫컭鿯胱퓳駵裷鿹軻鿽瓿欁欃栅⠇按缋⸍縏紑怓㘕焗眙氛爝䔟伡䄣䠥尧伩䠫-", a_));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0007A544 File Offset: 0x00078744
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0007A5F0 File Offset: 0x000787F0
		int global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.MaxValue
		{
			get
			{
				short num = (short)1123418112;
				short num2 = num;
				num = (short)753706558;
				short num3 = num;
				num = (short)64661054;
				switch (num3 == num)
				{
				}
				num = (short)2000289793;
				if (num != 0)
				{
				}
				num = (short)1839333376;
				if (num != 0)
				{
				}
				return 6;
			}
			set
			{
				int a_ = 1;
				short num = (short)1837432832;
				short num2 = num;
				num = (short)2116098254;
				short num3 = num;
				num = (short)1948129486;
				switch (num3 == num)
				{
				}
				num = (short)710279169;
				if (num != 0)
				{
				}
				num = (short)1429995520;
				if (num != 0)
				{
				}
				throw new global::System.Exception(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髍룏럑믕뷗껙듛뇝蓟싡诣铥죧藩鳫语苯鏱胳鿵韷铹\udcfb韽珿∁樃椅簇⨉攋挍怏縑焓笕紗琙栛笝䐟డ", a_));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0007A6B8 File Offset: 0x000788B8
		global::DevComponents.WpfEditors.Primitives.eDateTimePart global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.Part
		{
			get
			{
				short num = (short)1331298304;
				short num2 = num;
				num = (short)864103055;
				short num3 = num;
				num = (short)820914831;
				switch (num3 == num)
				{
				}
				num = (short)538247169;
				if (num != 0)
				{
				}
				num = (short)1658978304;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.Primitives.eDateTimePart.DayName;
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0007A764 File Offset: 0x00078964
		void global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.UndoInput()
		{
			short num = (short)1880489984;
			short num2 = num;
			num = (short)236134828;
			short num3 = num;
			num = (short)608772524;
			switch (num3 == num)
			{
			}
			num = (short)1843920897;
			if (num != 0)
			{
			}
			num = (short)399376384;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400029A RID: 666
		private int? a;

		// Token: 0x0400029B RID: 667
		private global::System.Collections.Generic.List<string> b;

		// Token: 0x0400029C RID: 668
		private bool c;
	}
}
