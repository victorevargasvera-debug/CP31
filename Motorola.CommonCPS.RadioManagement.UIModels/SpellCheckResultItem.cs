using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000066 RID: 102
	public class SpellCheckResultItem : global::Motorola.CommonCPS.RadioManagement.UIModels.GuiResultItem
	{
		// Token: 0x060002D7 RID: 727 RVA: 0x0002B028 File Offset: 0x00029228
		public SpellCheckResultItem(global::Motorola.CommonCPS.RadioManagement.UIModels.RfGuiPath guiPath, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, bool IsShareableSet)
		{
			if (guiPath != null)
			{
				base.Copy(guiPath);
			}
			this.c = radio;
			this.f = IsShareableSet;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0002B064 File Offset: 0x00029264
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0002B114 File Offset: 0x00029314
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase Radio
		{
			get
			{
				short num = (short)1558422722;
				short num2 = num;
				num = (short)800892098;
				switch (num2 == num)
				{
				}
				num = (short)1616314369;
				if (num != 0)
				{
				}
				num = (short)282066944;
				if (num != 0)
				{
				}
				num = (short)1120337920;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1203240960;
				short num2 = num;
				num = (short)2078539778;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						this.c = value;
						goto IL_F2;
					case 2:
						num = (short)1257635841;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					}
					IL_81:
					num = (short)266918502;
					short num4 = num;
					num = (short)1253431910;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_F2:
						num = (short)1548681216;
						num3 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)484245504;
						if (num != 0)
						{
						}
						if (this.c == value)
						{
							return;
						}
						num = (short)2112225281;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0002B230 File Offset: 0x00029430
		public string SerialNumber
		{
			get
			{
				while (this.c != null)
				{
					short num = (short)444071937;
					if (num != 0)
					{
					}
					num = (short)664377146;
					short num2 = num;
					num = (short)1698273082;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1776353280;
						short num3 = num;
						num = (short)179961856;
						if (num != 0)
						{
						}
						return this.c.SerialNumber;
					}
					}
				}
				return string.Empty;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0002B2F8 File Offset: 0x000294F8
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0002B3A8 File Offset: 0x000295A8
		public string ConfigUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1184352018;
				short num2 = num;
				num = (short)1541850898;
				switch (num2 == num)
				{
				}
				num = (short)178192385;
				if (num != 0)
				{
				}
				num = (short)223739904;
				if (num != 0)
				{
				}
				num = (short)1445068800;
				short num3 = num;
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1354366976;
				short num2 = num;
				num = (short)1316749313;
				if (num != 0)
				{
				}
				num = (short)178512629;
				short num3 = num;
				num = (short)1868030709;
				switch (num3 == num)
				{
				}
				num = (short)1939472384;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0002B458 File Offset: 0x00029658
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0002B50C File Offset: 0x0002970C
		public string Configuration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1488846848;
				short num2 = num;
				num = (short)1591083743;
				short num3 = num;
				num = (short)1055720159;
				switch (num3 == num)
				{
				}
				num = (short)1897070592;
				if (num != 0)
				{
				}
				num = (short)2104295425;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)18415616;
				short num2 = num;
				num = (short)2103181313;
				if (num != 0)
				{
				}
				num = (short)1393268811;
				short num3 = num;
				num = (short)76585035;
				switch (num3 == num)
				{
				}
				num = (short)1903099904;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0002B5BC File Offset: 0x000297BC
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0002B66C File Offset: 0x0002986C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ResultType CheckResult
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1800142848;
				short num2 = num;
				num = (short)176553985;
				if (num != 0)
				{
				}
				num = (short)1770269909;
				short num3 = num;
				num = (short)1611738325;
				switch (num3 == num)
				{
				}
				num = (short)2022440960;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1971257344;
				short num2 = num;
				num = (short)1395033703;
				short num3 = num;
				num = (short)1773766247;
				switch (num3 == num)
				{
				}
				num = (short)756154369;
				if (num != 0)
				{
				}
				num = (short)2047082496;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0002B71C File Offset: 0x0002991C
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0002B7CC File Offset: 0x000299CC
		public string Description
		{
			get
			{
				short num = (short)780795904;
				short num2 = num;
				num = (short)2103787328;
				short num3 = num;
				num = (short)969948992;
				switch (num3 == num)
				{
				}
				num = (short)1916731393;
				if (num != 0)
				{
				}
				num = (short)1095172096;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)371589120;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 1:
						return;
					case 2:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem.get_Description())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)123142145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1128136704;
						short num3 = num;
						this.b = value;
						num = (short)2098987012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)481201586;
						short num4 = num;
						num = (short)568495538;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1628307457;
							if (num != 0)
							{
							}
							num = (short)1747714048;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)2012086274;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					}
					IL_39:
					if (!(value != this.b))
					{
						break;
					}
					num = (short)1292107779;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0002B968 File Offset: 0x00029B68
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0002BA18 File Offset: 0x00029C18
		public bool IsOutOfDate
		{
			get
			{
				short num = (short)467533824;
				short num2 = num;
				num = (short)1651496148;
				short num3 = num;
				num = (short)257938644;
				switch (num3 == num)
				{
				}
				num = (short)26476545;
				if (num != 0)
				{
				}
				num = (short)2102329344;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1874788352;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 1:
						return;
					case 2:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem.get_IsOutOfDate())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1402798081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1117257728;
						short num3 = num;
						this.a = value;
						num = (short)1832058884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)679069041;
						short num4 = num;
						num = (short)269993329;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1650982913;
							if (num != 0)
							{
							}
							num = (short)1200816128;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)573898754;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					}
					IL_38:
					if (value == this.a)
					{
						break;
					}
					num = (short)1674313731;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0002BBB0 File Offset: 0x00029DB0
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0002BC5C File Offset: 0x00029E5C
		public bool IsRadioSpecific
		{
			get
			{
				short num = (short)1197408256;
				short num2 = num;
				num = (short)2039661866;
				short num3 = num;
				num = (short)1097319722;
				switch (num3 == num)
				{
				}
				num = (short)611385345;
				if (num != 0)
				{
				}
				num = (short)791674880;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)15990784;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 1:
						return;
					case 2:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem.get_IsRadioSpecific())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1801125889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						this.d = value;
						num = (short)558891012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)41572068;
						short num3 = num;
						num = (short)1441355492;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1428750336;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)794689538;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					}
					IL_39:
					num = (short)1177026561;
					if (num != 0)
					{
					}
					if (value == this.d)
					{
						break;
					}
					num = (short)2106261504;
					short num4 = num;
					num = (short)1227882499;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0002BDF8 File Offset: 0x00029FF8
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0002BEA8 File Offset: 0x0002A0A8
		public bool IsComplementSet
		{
			get
			{
				short num = (short)734593024;
				short num2 = num;
				num = (short)161581177;
				short num3 = num;
				num = (short)1604946041;
				switch (num3 == num)
				{
				}
				num = (short)553254913;
				if (num != 0)
				{
				}
				num = (short)1189543936;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1621032960;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 1:
						return;
					case 2:
						num = (short)1934819329;
						if (num != 0)
						{
						}
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem.get_IsComplementSet())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)666304513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)614531072;
						short num3 = num;
						this.e = value;
						num = (short)719978500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)2029182322;
						short num4 = num;
						num = (short)1682627954;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1931542528;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)2060582914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					}
					IL_38:
					if (value == this.e)
					{
						break;
					}
					num = (short)941883395;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0002C03C File Offset: 0x0002A23C
		public bool IsShareableSet
		{
			get
			{
				short num = (short)745275392;
				short num2 = num;
				num = (short)2014374784;
				short num3 = num;
				num = (short)708701056;
				switch (num3 == num)
				{
				}
				num = (short)1955987456;
				if (num != 0)
				{
				}
				num = (short)601030657;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0002C0EC File Offset: 0x0002A2EC
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0002C19C File Offset: 0x0002A39C
		public bool CanResetValue
		{
			get
			{
				short num = (short)1190264832;
				short num2 = num;
				num = (short)957320700;
				short num3 = num;
				num = (short)752455164;
				switch (num3 == num)
				{
				}
				num = (short)1742471168;
				if (num != 0)
				{
				}
				num = (short)995033089;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1768751104;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 1:
						goto IL_CF;
					case 2:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem.get_CanResetValue())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)274071553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1846214656;
						short num3 = num;
						this.g = value;
						num = (short)1983643652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)42850191;
						short num4 = num;
						num = (short)827512719;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)384106496;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)905838594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_162;
						}
						break;
					}
					}
					IL_38:
					if (value == this.g)
					{
						break;
					}
					num = (short)2084831235;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CF:
				IL_162:
				num = (short)1193410561;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0002C334 File Offset: 0x0002A534
		// (set) Token: 0x060002ED RID: 749 RVA: 0x0002C3E4 File Offset: 0x0002A5E4
		public object DefaultValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)961478656;
				short num2 = num;
				num = (short)1759540539;
				short num3 = num;
				num = (short)1715828027;
				switch (num3 == num)
				{
				}
				num = (short)557252609;
				if (num != 0)
				{
				}
				num = (short)119013376;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)572456960;
				short num2 = num;
				num = (short)1535141886;
				short num3 = num;
				num = (short)1763207166;
				switch (num3 == num)
				{
				}
				num = (short)759103488;
				if (num != 0)
				{
				}
				num = (short)970784769;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0002C494 File Offset: 0x0002A694
		// (set) Token: 0x060002EF RID: 751 RVA: 0x0002C548 File Offset: 0x0002A748
		public global::Motorola.CommonCPS.RadioManagement.UIModels.NavigateModeType NavigateMode
		{
			get
			{
				short num = (short)310116352;
				short num2 = num;
				num = (short)908120320;
				short num3 = num;
				num = (short)1912852736;
				switch (num3 == num)
				{
				}
				num = (short)693370880;
				if (num != 0)
				{
				}
				num = (short)1715339265;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1315794810;
				short num2 = num;
				num = (short)132738938;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2127560704;
					if (num != 0)
					{
					}
					num = (short)1980104705;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						num = (short)1615724545;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						continue;
					case 2:
					{
						num = (short)1644691456;
						short num4 = num;
						this.h = value;
						num = (short)923992064;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9F:
					if (value == this.h)
					{
						break;
					}
					num = (short)717619202;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0002C65C File Offset: 0x0002A85C
		public void Copy(global::Motorola.CommonCPS.RadioManagement.UIModels.SpellCheckResultItem newItem)
		{
			short num = (short)394264576;
			short num2 = num;
			num = (short)1005175686;
			short num3 = num;
			num = (short)1972421510;
			switch (num3 == num)
			{
			}
			num = (short)174653441;
			if (num != 0)
			{
			}
			num = (short)700841984;
			if (num != 0)
			{
			}
			base.ArrayFieldPath = newItem.ArrayFieldPath;
			base.OriginalBLFullPath = newItem.OriginalBLFullPath;
			base.Type = newItem.Type;
			base.Path = newItem.Path;
			this.Radio = newItem.Radio;
			this.Configuration = newItem.Configuration;
			this.Description = newItem.Description;
			this.CheckResult = newItem.CheckResult;
			this.IsOutOfDate = newItem.IsOutOfDate;
		}

		// Token: 0x04000147 RID: 327
		private bool a;

		// Token: 0x04000148 RID: 328
		private string b = string.Empty;

		// Token: 0x04000149 RID: 329
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase c;

		// Token: 0x0400014A RID: 330
		private bool d;

		// Token: 0x0400014B RID: 331
		private bool e;

		// Token: 0x0400014C RID: 332
		private bool f;

		// Token: 0x0400014D RID: 333
		private bool g;

		// Token: 0x0400014E RID: 334
		private global::Motorola.CommonCPS.RadioManagement.UIModels.NavigateModeType h;

		// Token: 0x0400014F RID: 335
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string i;

		// Token: 0x04000150 RID: 336
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string j;

		// Token: 0x04000151 RID: 337
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ResultType k;

		// Token: 0x04000152 RID: 338
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private object l;
	}
}
