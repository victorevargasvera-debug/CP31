using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000B3 RID: 179
	public class Option : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x060006C4 RID: 1732 RVA: 0x00061C8C File Offset: 0x0005FE8C
		public Option()
		{
			this.Visible = true;
			this.Editable = true;
			this.IsActive = false;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00061CC0 File Offset: 0x0005FEC0
		public Option(string optionTag, string ResourceID) : this()
		{
			this.OptionTag = optionTag;
			this.ResourceID = ResourceID;
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00061CE4 File Offset: 0x0005FEE4
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00061D94 File Offset: 0x0005FF94
		public string OptionTag
		{
			get
			{
				short num = (short)826474496;
				short num2 = num;
				num = (short)36342432;
				short num3 = num;
				num = (short)1220512416;
				switch (num3 == num)
				{
				}
				num = (short)311558144;
				if (num != 0)
				{
				}
				num = (short)1028587521;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1425932288;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1827274753;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_58;
							}
							continue;
						case 1:
							return;
						case 2:
						{
							num = (short)1522881245;
							short num3 = num;
							num = (short)899044061;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1693646848;
								short num4 = num;
								num = (short)29032448;
								if (num != 0)
								{
								}
								this.a = value;
								base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option.get_OptionTag())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1223294977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_58:
						if (!(value != this.a))
						{
							return;
						}
						num = (short)2086993922;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00061EEC File Offset: 0x000600EC
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00061F98 File Offset: 0x00060198
		public string ResourceID
		{
			get
			{
				short num = (short)1211957248;
				short num2 = num;
				num = (short)1958822845;
				short num3 = num;
				num = (short)1830372285;
				switch (num3 == num)
				{
				}
				num = (short)229769217;
				if (num != 0)
				{
				}
				num = (short)71630848;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num;
				for (;;)
				{
					IL_00:
					num = (short)639238144;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 1:
							goto IL_121;
						case 2:
						{
							num = (short)1347068978;
							short num3 = num;
							num = (short)1712628786;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)656343040;
								if (num != 0)
								{
								}
								num = (short)2035941376;
								short num4 = num;
								this.b = value;
								base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option.get_ResourceID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1781727233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_30:
						if (!(value != this.b))
						{
							goto IL_123;
						}
						num = (short)1769340930;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_121:
				IL_123:
				num = (short)617218049;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x000620F0 File Offset: 0x000602F0
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x0006219C File Offset: 0x0006039C
		public string DisplayName
		{
			get
			{
				short num = (short)558694400;
				short num2 = num;
				num = (short)1982160547;
				short num3 = num;
				num = (short)1826512547;
				switch (num3 == num)
				{
				}
				num = (short)763101184;
				if (num != 0)
				{
				}
				num = (short)365232129;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)2026962944;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)441712641;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_58;
							}
							continue;
						case 1:
							return;
						case 2:
						{
							num = (short)1431417305;
							short num3 = num;
							num = (short)757182937;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1069809664;
								short num4 = num;
								num = (short)1993211904;
								if (num != 0)
								{
								}
								this.c = value;
								base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option.get_DisplayName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1686896641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_58:
						if (!(value != this.c))
						{
							return;
						}
						num = (short)1753415682;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x000622F4 File Offset: 0x000604F4
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x000623A4 File Offset: 0x000605A4
		public bool Visible
		{
			get
			{
				short num = (short)861274112;
				short num2 = num;
				num = (short)503513089;
				if (num != 0)
				{
				}
				num = (short)24852608;
				short num3 = num;
				num = (short)1764309120;
				switch (num3 == num)
				{
				}
				num = (short)1673330688;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1471807488;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 1:
							return;
						case 2:
						{
							num = (short)1657373700;
							short num3 = num;
							num = (short)592348164;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)936837120;
								short num4 = num;
								num = (short)1312292864;
								if (num != 0)
								{
								}
								this.d = value;
								base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option.get_Visible())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1035272193;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_30:
						num = (short)1944780801;
						if (num != 0)
						{
						}
						if (value == this.d)
						{
							return;
						}
						num = (short)732889090;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000624F4 File Offset: 0x000606F4
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x000625A8 File Offset: 0x000607A8
		public bool Editable
		{
			get
			{
				short num = (short)1079771136;
				short num2 = num;
				num = (short)1559372892;
				short num3 = num;
				num = (short)669459548;
				switch (num3 == num)
				{
				}
				num = (short)1471807489;
				if (num != 0)
				{
				}
				num = (short)1490157568;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num;
				for (;;)
				{
					IL_00:
					num = (short)1020264448;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 1:
							goto IL_119;
						case 2:
						{
							num = (short)642564490;
							short num3 = num;
							num = (short)495305098;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)982056960;
								if (num != 0)
								{
								}
								num = (short)1975123968;
								short num4 = num;
								this.e = value;
								base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option.get_Editable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)672137217;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_30:
						if (value == this.e)
						{
							return;
						}
						num = (short)2010710018;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_119:
				num = (short)40763393;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x000626F8 File Offset: 0x000608F8
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x000627A8 File Offset: 0x000609A8
		public bool IsActive
		{
			get
			{
				short num = (short)2106720256;
				short num2 = num;
				num = (short)1281476229;
				short num3 = num;
				num = (short)462734981;
				switch (num3 == num)
				{
				}
				num = (short)1713504257;
				if (num != 0)
				{
				}
				num = (short)791281664;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)300089344;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 1:
							return;
						case 2:
						{
							num = (short)339935094;
							short num3 = num;
							num = (short)1640890230;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1815281665;
								if (num != 0)
								{
								}
								num = (short)1052770304;
								short num4 = num;
								num = (short)3735552;
								if (num != 0)
								{
								}
								this.f = value;
								base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option.get_IsActive())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)660668417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_30:
						if (value == this.f)
						{
							return;
						}
						num = (short)116981762;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000628F8 File Offset: 0x00060AF8
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x000629A8 File Offset: 0x00060BA8
		public string DisplayStatus
		{
			get
			{
				short num = (short)838991872;
				short num2 = num;
				num = (short)1200883702;
				short num3 = num;
				num = (short)1211434998;
				switch (num3 == num)
				{
				}
				num = (short)347144193;
				if (num != 0)
				{
				}
				num = (short)367525888;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1759576064;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 1:
							return;
						case 2:
						{
							num = (short)357523745;
							short num3 = num;
							num = (short)510288161;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)196608000;
								short num4 = num;
								break;
							}
							}
							num = (short)1785200640;
							if (num != 0)
							{
							}
							num = (short)193986561;
							if (num != 0)
							{
							}
							this.g = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option.get_DisplayStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1150484481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_30:
						if (!(value != this.g))
						{
							return;
						}
						num = (short)205979650;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00062AFC File Offset: 0x00060CFC
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00062BAC File Offset: 0x00060DAC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> ChildrenOptions
		{
			get
			{
				short num = (short)1188167680;
				short num2 = num;
				num = (short)928270043;
				short num3 = num;
				num = (short)1490306779;
				switch (num3 == num)
				{
				}
				num = (short)214040577;
				if (num != 0)
				{
				}
				num = (short)247201792;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)462028801;
					if (num != 0)
					{
					}
					num = (short)838074368;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_58;
							}
							continue;
						case 1:
							this.h = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Option.get_ChildrenOptions())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)285933570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						}
						IL_58:
						num = (short)959307664;
						short num3 = num;
						num = (short)2079317904;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)731381760;
							if (num != 0)
							{
							}
							num = (short)2023292928;
							short num4 = num;
							if (value == this.h)
							{
								return;
							}
							num = (short)110624769;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00062D00 File Offset: 0x00060F00
		public override bool Equals(object obj)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_40;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.Option option;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return true;
					case 1:
						num2 = (short)1076756481;
						if (num2 != 0)
						{
						}
						num2 = (short)1213399050;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						num2 = (short)2125332488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (option != null)
						{
							num2 = (short)1090650113;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 4:
						if (option.e == this.e)
						{
							num2 = (short)196214793;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 5:
					{
						num2 = (short)16187392;
						short num3 = num2;
						num2 = (short)230359046;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 6:
						if (option.f == this.f)
						{
							num2 = (short)1133445120;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 7:
						num2 = (short)921042948;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						if (option.b == this.b)
						{
							num2 = (short)150863879;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 9:
					{
						num2 = (short)1055660127;
						short num4 = num2;
						num2 = (short)953292895;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1111687168;
							if (num2 != 0)
							{
							}
							num2 = (short)977141771;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 10:
						if (option.a == this.a)
						{
							num2 = (short)1762852866;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 11:
						if (option.d == this.d)
						{
							num2 = (short)382730245;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				IL_40:
				option = (obj as global::Motorola.CommonCPS.RadioManagement.UIModels.Option);
				num2 = (short)1505165315;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return true;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00062F84 File Offset: 0x00061184
		public override int GetHashCode()
		{
			short num = (short)1522335744;
			short num2 = num;
			num = (short)2140258434;
			short num3 = num;
			num = (short)35242114;
			switch (num3 == num)
			{
			}
			num = (short)1623326721;
			if (num != 0)
			{
			}
			num = (short)1505427456;
			if (num != 0)
			{
			}
			return base.GetHashCode();
		}

		// Token: 0x040002D3 RID: 723
		private string a;

		// Token: 0x040002D4 RID: 724
		private string b;

		// Token: 0x040002D5 RID: 725
		private string c;

		// Token: 0x040002D6 RID: 726
		private bool d;

		// Token: 0x040002D7 RID: 727
		private bool e;

		// Token: 0x040002D8 RID: 728
		private bool f;

		// Token: 0x040002D9 RID: 729
		private string g;

		// Token: 0x040002DA RID: 730
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> h = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option>();
	}
}
