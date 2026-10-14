using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.Global.Properties;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000051 RID: 81
	public class ButtonBarMode : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x0600024C RID: 588 RVA: 0x00023C84 File Offset: 0x00021E84
		public ButtonBarMode()
		{
			this.c = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum>();
			this.c.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum.TextMode);
			this.c.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum.IconMode);
			this.a();
			this.a = this.b;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00023CCC File Offset: 0x00021ECC
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00023D80 File Offset: 0x00021F80
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum SelectedMode
		{
			get
			{
				short num = (short)856672139;
				short num2 = num;
				num = (short)1374275467;
				switch (num2 == num)
				{
				}
				num = (short)1832779777;
				if (num != 0)
				{
				}
				num = (short)490209280;
				if (num != 0)
				{
				}
				num = (short)280690688;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1542127619;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode.get_SelectedMode())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1298202625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)927268864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)1666056193;
						if (num != 0)
						{
						}
						num = (short)1064774351;
						short num3 = num;
						num = (short)2079926991;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_144;
						default:
							num = (short)109969408;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_AA;
							}
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)825425920;
						short num4 = num;
						goto IL_144;
					}
					}
					IL_AA:
					if (value != this.a)
					{
						num = (short)688586756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_144:
					this.a = value;
					num = (short)324206594;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00023F18 File Offset: 0x00022118
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00023FC8 File Offset: 0x000221C8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum InitialModeSelection
		{
			get
			{
				short num = (short)326731283;
				short num2 = num;
				num = (short)532842003;
				switch (num2 == num)
				{
				}
				num = (short)917241857;
				if (num != 0)
				{
				}
				num = (short)197459968;
				if (num != 0)
				{
				}
				num = (short)371195904;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1348534275;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode.get_InitialModeSelection())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1423835137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)184287232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)1713113702;
						short num3 = num;
						num = (short)271125094;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_145;
						default:
							num = (short)1573388288;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_86;
							}
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)597229568;
						short num4 = num;
						goto IL_145;
					}
					}
					IL_86:
					if (value != this.b)
					{
						num = (short)565313537;
						if (num != 0)
						{
						}
						num = (short)1617362948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_145:
					this.b = value;
					num = (short)614334466;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00024160 File Offset: 0x00022360
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00024210 File Offset: 0x00022410
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum> SupportedMode
		{
			get
			{
				short num = (short)830878848;
				short num2 = num;
				num = (short)2023240832;
				switch (num2 == num)
				{
				}
				num = (short)966787073;
				if (num != 0)
				{
				}
				num = (short)1903624192;
				if (num != 0)
				{
				}
				num = (short)523436032;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)251920387;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode.get_SupportedMode())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1584726017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)1469775872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)2048728140;
						short num3 = num;
						num = (short)1400183884;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_147;
						default:
							num = (short)806027265;
							if (num != 0)
							{
							}
							num = (short)931725312;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_B0;
							}
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)224591872;
						short num4 = num;
						goto IL_147;
					}
					}
					IL_B0:
					if (value != this.c)
					{
						num = (short)1321009156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_147:
					this.c = value;
					num = (short)1020067842;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000243A8 File Offset: 0x000225A8
		private void a()
		{
			short num = (short)709400953;
			short num2 = num;
			num = (short)566335865;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B5:
				num = (short)655294464;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)367919104;
				if (num != 0)
				{
				}
				num = (short)1900806146;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					this.b = (global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum)global::System.Enum.Parse(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum), global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.ButtonMode);
					num = (short)269746177;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_107;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				}
				break;
			}
			IL_7C:
			num = (short)884801536;
			short num4 = num;
			if (!string.IsNullOrEmpty(global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.ButtonMode))
			{
				goto IL_B5;
			}
			return;
			IL_107:
			num = (short)1718484993;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000F4 RID: 244
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum a;

		// Token: 0x040000F5 RID: 245
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum b;

		// Token: 0x040000F6 RID: 246
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum> c;
	}
}
