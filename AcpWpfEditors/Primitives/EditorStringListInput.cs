using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000068 RID: 104
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EditorStringListInput : global::DevComponents.WpfEditors.Primitives.EditorListInput
	{
		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060006FE RID: 1790 RVA: 0x00092A80 File Offset: 0x00090C80
		// (remove) Token: 0x060006FF RID: 1791 RVA: 0x00092B34 File Offset: 0x00090D34
		public event global::System.Windows.RoutedEventHandler SelectedIndexChanged
		{
			add
			{
				short num = (short)1106091734;
				short num2 = num;
				num = (short)96116438;
				switch (num2 == num)
				{
				}
				num = (short)1985019904;
				short num3 = num;
				num = (short)1827864577;
				if (num != 0)
				{
				}
				num = (short)1501036544;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.Primitives.EditorStringListInput.SelectedIndexChangedEvent, value);
			}
			remove
			{
				short num = (short)837352543;
				short num2 = num;
				num = (short)993000543;
				switch (num2 == num)
				{
				}
				num = (short)287965184;
				short num3 = num;
				num = (short)1156120577;
				if (num != 0)
				{
				}
				num = (short)2005860352;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.Primitives.EditorStringListInput.SelectedIndexChangedEvent, value);
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00092BEC File Offset: 0x00090DEC
		protected virtual void OnSelectedIndexChanged()
		{
			short num = (short)69022488;
			short num2 = num;
			num = (short)1545548568;
			switch (num2 == num)
			{
			}
			num = (short)1081606144;
			short num3 = num;
			num = (short)1904148481;
			if (num != 0)
			{
			}
			num = (short)2021654528;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.Primitives.EditorStringListInput.SelectedIndexChangedEvent);
			base.RaiseEvent(routedEventArgs);
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00092CA8 File Offset: 0x00090EA8
		public global::System.Collections.Generic.List<string> Items
		{
			get
			{
				short num = (short)742187224;
				short num2 = num;
				num = (short)1397874904;
				switch (num2 == num)
				{
				}
				num = (short)1204027392;
				short num3 = num;
				num = (short)1037303808;
				if (num != 0)
				{
				}
				num = (short)2112290817;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00092D58 File Offset: 0x00090F58
		protected virtual global::System.Collections.Generic.List<string> GetItems()
		{
			short num = (short)1020850522;
			short num2 = num;
			num = (short)2090791258;
			switch (num2 == num)
			{
			}
			num = (short)274071552;
			short num3 = num;
			num = (short)1292763136;
			if (num != 0)
			{
			}
			num = (short)1673068545;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00092E08 File Offset: 0x00091008
		protected override bool ValidateNewInputStack(string s)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::System.Collections.Generic.List<string> list;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)980546808;
					short num3 = num2;
					num2 = (short)1821766904;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
						num2 = (short)181927936;
						if (num2 != 0)
						{
						}
						if (list.Count == 0)
						{
							num2 = (short)885129217;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B7;
					}
					break;
				}
				case 1:
					goto IL_132;
				case 2:
					if (list != null)
					{
						num2 = (short)2057895939;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					num2 = (short)697696256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1277296641;
					if (num2 != 0)
					{
					}
					global::System.Collections.Generic.List<string> items = this.GetItems();
					global::DevComponents.WpfEditors.Primitives.a a = new global::DevComponents.WpfEditors.Primitives.a(s.ToLower(), 2);
					list = items.FindAll(a.i());
					num2 = (short)614334466;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_83;
				}
				goto IL_28;
				IL_83:
				if (s.Length <= 0)
				{
					goto IL_1DC;
				}
				num2 = (short)823132164;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_132:
			return false;
			IL_1B7:
			this.d = list[0];
			this.c = s;
			this.e = (list.Count == 1);
			return true;
			IL_1DC:
			return base.ValidateNewInputStack(s);
			IL_28:
			this.c = "";
			this.d = "";
			this.e = false;
			num2 = (short)873398272;
			short num4 = num2;
			num2 = (short)190709765;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00092FF8 File Offset: 0x000911F8
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x000930A8 File Offset: 0x000912A8
		protected string LastValidatedInputStack
		{
			get
			{
				short num = (short)584196669;
				short num2 = num;
				num = (short)563225149;
				switch (num2 == num)
				{
				}
				num = (short)806682624;
				short num3 = num;
				num = (short)765853697;
				if (num != 0)
				{
				}
				num = (short)1951596544;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)379846657;
				if (num != 0)
				{
				}
				num = (short)1074787170;
				short num2 = num;
				num = (short)312734562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1554644992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)23724032;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0009315C File Offset: 0x0009135C
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x0009320C File Offset: 0x0009140C
		protected string LastMatch
		{
			get
			{
				short num = (short)807144939;
				short num2 = num;
				num = (short)1092292075;
				switch (num2 == num)
				{
				}
				num = (short)176422912;
				short num3 = num;
				num = (short)877854721;
				if (num != 0)
				{
				}
				num = (short)523894784;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1267218860;
				short num2 = num;
				num = (short)319764908;
				switch (num2 == num)
				{
				}
				num = (short)602669057;
				if (num != 0)
				{
				}
				num = (short)229769216;
				if (num != 0)
				{
				}
				num = (short)1862991872;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x000932B8 File Offset: 0x000914B8
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x0009336C File Offset: 0x0009156C
		protected bool LastMatchComplete
		{
			get
			{
				short num = (short)1454695755;
				short num2 = num;
				num = (short)877454667;
				switch (num2 == num)
				{
				}
				num = (short)631898113;
				if (num != 0)
				{
				}
				num = (short)2024538112;
				if (num != 0)
				{
				}
				num = (short)1247543296;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)216677195;
				short num2 = num;
				num = (short)217004875;
				switch (num2 == num)
				{
				}
				num = (short)2110455809;
				if (num != 0)
				{
				}
				num = (short)774307840;
				if (num != 0)
				{
				}
				num = (short)1040711680;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0009341C File Offset: 0x0009161C
		protected override void OnInputStackChanged()
		{
			switch (0)
			{
			case 0:
				goto IL_B1;
			}
			short num;
			int num4;
			bool flag;
			for (;;)
			{
				IL_0A:
				num = (short)1365510297;
				short num2 = num;
				num = (short)34932889;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)962002944;
					short num3 = num;
					num = (short)855638016;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (flag)
						{
							num = (short)1414070276;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27C;
					case 1:
						flag = (this.b != "");
						this.b = "";
						num = (short)711655430;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1DE;
					case 3:
						if (base.InputStack == this.c)
						{
							num = (short)1871970311;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13C;
					case 4:
						this.OnSelectedIndexChanged();
						num = (short)562102274;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_F6;
					case 6:
						goto IL_F6;
					case 7:
						num = (short)1061027841;
						if (num != 0)
						{
						}
						flag = (this.b != this.d);
						this.b = this.d;
						goto IL_228;
					case 8:
						num = (short)2490371;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.c.Length > 0)
						{
							num = (short)115015688;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13C;
					case 10:
						if (base.InputStack.Length == 0)
						{
							num = (short)1915027457;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F6;
					}
					goto IL_B1;
					IL_F6:
					base.InvalidateMeasure();
					base.InvalidateVisual();
					num = (short)281280512;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_13C:
					num = (short)151846922;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_228:
				num = (short)385286149;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_1DE:
			IL_27C:
			base.OnInputStackChanged();
			return;
			IL_B1:
			flag = false;
			num = (short)672661513;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000936AC File Offset: 0x000918AC
		protected override void OnInputKeyAccepted()
		{
			short num = (short)264044545;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					this.TextInputComplete(true);
					this.e = false;
					goto IL_5F;
				}
				IL_32:
				if (this.e)
				{
					num = (short)1803616258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_9F;
				IL_5F:
				num = (short)2112356352;
				short num3 = num;
				num = (short)1268056064;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9F:
				num = (short)55967745;
				if (num != 0)
				{
				}
				num = (short)1253555514;
				short num4 = num;
				num = (short)1540537658;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5F;
				default:
					goto IL_FA;
				}
			}
			IL_FA:
			num = (short)1956249600;
			if (num != 0)
			{
			}
			base.OnInputKeyAccepted();
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x000937D0 File Offset: 0x000919D0
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00093880 File Offset: 0x00091A80
		[global::System.ComponentModel.DefaultValue("")]
		public string Text
		{
			get
			{
				short num = (short)763580147;
				short num2 = num;
				num = (short)1100173043;
				switch (num2 == num)
				{
				}
				num = (short)2036989953;
				if (num != 0)
				{
				}
				num = (short)1758003200;
				if (num != 0)
				{
				}
				num = (short)1420623872;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1515388944;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_332;
					case 1:
						if (value != null)
						{
							num = (short)2081882120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB;
					case 2:
						if (value == null)
						{
							num = (short)1067319300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_337;
					case 3:
					{
						global::System.Collections.Generic.List<string> items;
						if (items.Count > 0)
						{
							num = (short)2097217545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_337;
					}
					case 4:
						num = (short)194183183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						this.IsEmpty = true;
						num = (short)998047761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_BB;
					case 7:
					{
						global::System.Collections.Generic.List<string> items;
						value = items[0];
						num = (short)827981847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)996147222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::System.Collections.Generic.List<string> items;
						value = items[0];
						num = (short)143654931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)405995523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)942342157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1341652993;
						if (num != 0)
						{
						}
						num = (short)1380515858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::System.Collections.Generic.List<string> items;
						if (items.Count > 0)
						{
							num = (short)1808203783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					}
					case 14:
						num = (short)216203289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						num = (short)697499648;
						short num3 = num;
						if (!base.AllowEmptyState)
						{
							num = (short)77856778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_337;
					}
					case 16:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 17:
						goto IL_25F;
					case 18:
						if (value != null)
						{
							num = (short)1072758784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C8;
					case 19:
						goto IL_BB;
					case 20:
						if (this.IsEmpty)
						{
							num = (short)593166348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C8;
					case 21:
						if (value == null)
						{
							num = (short)1554907141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 22:
					{
						global::System.Collections.Generic.List<string> items;
						if (!items.Contains(value))
						{
							num = (short)1689387022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB;
					}
					case 23:
						goto IL_BB;
					case 24:
					{
						global::System.Collections.Generic.List<string> items = this.GetItems();
						num = (short)1450749110;
						short num4 = num;
						num = (short)2007215286;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_337;
						default:
							num = (short)1661730816;
							if (num != 0)
							{
							}
							num = (short)842072066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 25:
						if (!base.AllowEmptyState)
						{
							num = (short)1253376011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					}
					IL_8C:
					if (this.b != value)
					{
						num = (short)1701314584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_BB:
					this.b = value;
					base.ResetInputStack();
					this.OnInputChanged();
					this.OnSelectedIndexChanged();
					base.InvalidateMeasure();
					base.InvalidateVisual();
					num = (short)930938900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21E:
					value = null;
					num = (short)300679174;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C8:
					num = (short)1736704021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_337:
					num = (short)1217986561;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_25F:
				return;
				IL_332:
				this.IsEmpty = false;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00093D0C File Offset: 0x00091F0C
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00093DC0 File Offset: 0x00091FC0
		public override bool IsEmpty
		{
			get
			{
				short num = (short)28179664;
				short num2 = num;
				num = (short)1314520272;
				switch (num2 == num)
				{
				}
				num = (short)773783552;
				if (num != 0)
				{
				}
				num = (short)414384129;
				if (num != 0)
				{
				}
				num = (short)1224736768;
				short num3 = num;
				return this.b == null;
			}
			set
			{
				short num = (short)1037056456;
				short num2 = num;
				num = (short)923154888;
				switch (num2 == num)
				{
				}
				num = (short)1969881089;
				if (num != 0)
				{
				}
				num = (short)835584000;
				if (num != 0)
				{
				}
				num = (short)1592852480;
				short num3 = num;
				base.IsEmpty = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00093E74 File Offset: 0x00092074
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00093FC4 File Offset: 0x000921C4
		[global::System.ComponentModel.DefaultValue(-1)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public int SelectedIndex
		{
			get
			{
				short num = (short)679018498;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_12A;
					case 1:
					{
						if (this.b != null)
						{
							goto IL_12F;
						}
						num = (short)743911875;
						short num3 = num;
						num = (short)83440067;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1155137536;
							if (num != 0)
							{
							}
							num = (short)238419968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 3:
					{
						num = (short)1583546368;
						short num4 = num;
						num = (short)1644036097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_34:
					if (this.IsEmpty)
					{
						break;
					}
					num = (short)795869185;
					if (num != 0)
					{
					}
					num = (short)2131099651;
					num2 = (int)((global::System.IntPtr)num);
				}
				return -1;
				IL_12A:
				return -1;
				IL_12F:
				return this.GetItems().IndexOf(this.Text);
			}
			set
			{
				if (value < 0)
				{
					short num = (short)861045311;
					short num2 = num;
					num = (short)1357546047;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1533214720;
						if (num != 0)
						{
						}
						num = (short)1642594305;
						if (num != 0)
						{
						}
						num = (short)328204288;
						short num3 = num;
						this.Text = null;
						return;
					}
					}
				}
				global::System.Collections.Generic.List<string> items = this.GetItems();
				this.Text = items[value];
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00094090 File Offset: 0x00092290
		protected override string GetInputStringValue()
		{
			short num = (short)472973313;
			if (num != 0)
			{
			}
			if (this.b != null)
			{
				num = (short)1970214022;
				short num2 = num;
				num = (short)192222342;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1383858176;
					if (num != 0)
					{
					}
					num = (short)318701568;
					short num3 = num;
					return this.b;
				}
				}
			}
			return "";
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0009414C File Offset: 0x0009234C
		public override void SelectNext()
		{
			short num = (short)810942465;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			int num3;
			for (;;)
			{
				IL_31:
				int num2;
				switch (num2)
				{
				case 0:
					goto IL_119;
				case 1:
					goto IL_DD;
				case 2:
					num3 = 0;
					num = (short)2074935296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_43;
			}
			IL_DD:
			global::System.Collections.Generic.List<string> items;
			if (num3 >= items.Count)
			{
				goto IL_E6;
			}
			IL_119:
			this.SelectedIndex = num3;
			base.SelectNext();
			return;
			IL_43:
			num = (short)32243712;
			short num4 = num;
			num = (short)1125641979;
			short num5 = num;
			num = (short)1615261435;
			switch ((num5 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E6:
				num = (short)1050542082;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			default:
			{
				num = (short)547356672;
				if (num != 0)
				{
				}
				num3 = this.SelectedIndex + 1;
				items = this.GetItems();
				num = (short)1425932289;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00094284 File Offset: 0x00092484
		public override void SelectPrevious()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_121;
				case 1:
					goto IL_DD;
				case 2:
					num2 = this.GetItems().Count - 1;
					num3 = (short)79364096;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				goto IL_1C;
			}
			IL_DD:
			if (num2 < 0)
			{
				goto IL_E1;
			}
			IL_121:
			this.SelectedIndex = num2;
			base.SelectPrevious();
			return;
			IL_1C:
			num3 = (short)1674196154;
			short num4 = num3;
			num3 = (short)97399994;
			switch ((num4 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E1:
				num3 = (short)1844117506;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num3 = (short)1293418496;
				short num5 = num3;
				break;
			}
			}
			num3 = (short)967180288;
			if (num3 != 0)
			{
			}
			num3 = (short)1683423233;
			if (num3 != 0)
			{
			}
			num2 = this.SelectedIndex - 1;
			num3 = (short)413401089;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000943F8 File Offset: 0x000925F8
		// Note: this type is marked as 'beforefieldinit'.
		static EditorStringListInput()
		{
			int a_ = 18;
			short num = (short)998055455;
			short num2 = num;
			num = (short)139337247;
			switch (num2 == num)
			{
			}
			num = (short)2028404737;
			if (num != 0)
			{
			}
			num = (short)1636696064;
			if (num != 0)
			{
			}
			num = (short)1333592064;
			short num3 = num;
			global::DevComponents.WpfEditors.Primitives.EditorStringListInput.SelectedIndexChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("賞蓠迢胤蓦鷨軪觬ꛮ鿰韲郴迶뫸鏺鳼釾昀昂愄", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.Primitives.EditorStringListInput));
		}

		// Token: 0x040002DF RID: 735
		private global::System.Collections.Generic.List<string> a = new global::System.Collections.Generic.List<string>();

		// Token: 0x040002E0 RID: 736
		private string b;

		// Token: 0x040002E1 RID: 737
		private string c = "";

		// Token: 0x040002E2 RID: 738
		private string d = "";

		// Token: 0x040002E3 RID: 739
		private bool e;
	}
}
