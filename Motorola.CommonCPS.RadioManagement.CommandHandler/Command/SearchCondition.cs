using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000B6 RID: 182
	internal class SearchCondition
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00041458 File Offset: 0x0003F658
		public SearchCondition(string searchString)
		{
			this.ExcludeConditions = new global::System.Collections.Generic.List<string>();
			this.MatchConditions = new global::System.Collections.Generic.List<string>();
			if (string.IsNullOrWhiteSpace(searchString))
			{
				return;
			}
			searchString = searchString.Trim();
			global::System.Collections.Generic.List<string> a_ = global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition.a(searchString);
			this.a(a_);
			this.ExcludeConditions = this.ExcludeConditions.Distinct<string>().ToList<string>();
			this.MatchConditions = this.MatchConditions.Distinct<string>().ToList<string>();
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x000414D0 File Offset: 0x0003F6D0
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00041580 File Offset: 0x0003F780
		public global::System.Collections.Generic.List<string> MatchConditions
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1748828161;
				if (num != 0)
				{
				}
				num = (short)1346277880;
				short num2 = num;
				num = (short)2043187704;
				switch (num2 == num)
				{
				}
				num = (short)1607598080;
				if (num != 0)
				{
				}
				num = (short)709820416;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)303313327;
				short num2 = num;
				num = (short)700068271;
				switch (num2 == num)
				{
				}
				num = (short)987955201;
				if (num != 0)
				{
				}
				num = (short)388366336;
				if (num != 0)
				{
				}
				num = (short)539295744;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00041630 File Offset: 0x0003F830
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x000416E0 File Offset: 0x0003F8E0
		public global::System.Collections.Generic.List<string> ExcludeConditions
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)22865205;
				short num2 = num;
				num = (short)660333877;
				switch (num2 == num)
				{
				}
				num = (short)1250557952;
				if (num != 0)
				{
				}
				num = (short)980090881;
				if (num != 0)
				{
				}
				num = (short)828309504;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1059964117;
				short num2 = num;
				num = (short)1966916821;
				switch (num2 == num)
				{
				}
				num = (short)2030108673;
				if (num != 0)
				{
				}
				num = (short)480378880;
				if (num != 0)
				{
				}
				num = (short)831127552;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00041790 File Offset: 0x0003F990
		private static string b(string A_0)
		{
			short num = (short)1849622528;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			int num3;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					goto IL_A2;
				case 1:
					if (A_0[0] == '"')
					{
						num = (short)400752643;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F1;
				case 2:
					goto IL_F1;
				case 3:
					num = (short)1932263429;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					if (A_0[0] != '\'')
					{
						return A_0;
					}
					num = (short)1010594057;
					short num4 = num;
					num = (short)1168273673;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A2;
					default:
						num = (short)1093664769;
						if (num != 0)
						{
						}
						num = (short)296681472;
						if (num != 0)
						{
						}
						num = (short)1635975177;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (A_0[A_0.Length - 1] != '"')
					{
						num = (short)456065026;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 6:
					if (A_0[A_0.Length - 1] == '\'')
					{
						num = (short)197591050;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return A_0;
				case 7:
					if (A_0.Length > 2)
					{
						num = (short)308674560;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return A_0;
				case 8:
					return A_0;
				case 9:
					num = (short)469303302;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_1E6;
				}
				goto IL_65;
				IL_A2:
				num = (short)1889009665;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_F1:
				num = (short)1652686852;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E6:
				A_0 = A_0.Substring(1, A_0.Length - 2);
				num = (short)500695048;
				num3 = (int)((global::System.IntPtr)num);
			}
			return A_0;
			IL_65:
			A_0 = A_0.Trim();
			num = (short)1149173767;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000419F8 File Offset: 0x0003FBF8
		private static global::System.Collections.Generic.List<string> a(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::System.Collections.Generic.List<string> list;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_BA;
				case 1:
					return list;
				case 2:
				{
					num2 = (short)400556033;
					if (num2 != 0)
					{
					}
					string value;
					A_0 = A_0.Substring(value.Length);
					num2 = (short)617349120;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					if (string.IsNullOrWhiteSpace(A_0))
					{
						goto IL_D9;
					}
					global::System.Text.RegularExpressions.Match match = global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition.a.Match(A_0);
					bool success = match.Success;
					string value = match.Value;
					list.Add(value);
					num2 = (short)2057371652;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					string value;
					if (A_0.Length != value.Length)
					{
						num2 = (short)1509621762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return list;
				}
				case 5:
				{
					num2 = (short)20843852;
					short num3 = num2;
					num2 = (short)898501964;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
					{
						num2 = (short)1033895936;
						short num4 = num2;
						num2 = (short)2011824128;
						if (num2 != 0)
						{
						}
						goto IL_BA;
					}
					}
					break;
				}
				}
				goto IL_28;
				IL_BA:
				num2 = (short)1272381443;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_D9:
				num2 = (short)1573126145;
				num = (int)((global::System.IntPtr)num2);
			}
			return list;
			IL_28:
			list = new global::System.Collections.Generic.List<string>();
			num2 = (short)635371525;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00041BB0 File Offset: 0x0003FDB0
		private void a(global::System.Collections.Generic.List<string> A_0)
		{
			int a_ = 7;
			short num;
			using (global::System.Collections.Generic.List<string>.Enumerator enumerator = A_0.GetEnumerator())
			{
				num = (short)1923350538;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)853753876;
						short num3 = num;
						num = (short)704331796;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_28;
						default:
						{
							num = (short)37355520;
							if (num != 0)
							{
							}
							string text;
							this.ExcludeConditions.Add(text);
							num = (short)1728249869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
					{
						string text;
						if (text[0] == '-')
						{
							num = (short)788725767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition.b(text);
						num = (short)1843855365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						string text;
						if (text == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("헷", a_))
						{
							num = (short)1188823052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)790167553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)345112582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = enumerator.Current.Trim();
						num = (short)496173058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						string text;
						if (text.Length != 0)
						{
							num = (short)2083717128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						num = (short)79560715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						string text = text.Substring(1).TrimStart(global::System.Array.Empty<char>());
						text = global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition.b(text);
						num = (short)1172373513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						string text;
						this.MatchConditions.Add(text);
						num = (short)1408106510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						string text;
						if (text.Length != 0)
						{
							num = (short)224657408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_28;
					case 11:
						goto IL_2EE;
					case 12:
					{
						num = (short)290390017;
						if (num != 0)
						{
						}
						string text;
						this.MatchConditions.Add(text);
						num = (short)1035993091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_74;
					IL_28:
					switch (0)
					{
					case 0:
						IL_74:
						goto IL_18E;
					}
					continue;
					IL_18E:
					num = (short)1015939076;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2EE:;
			}
			num = (short)1288962048;
			short num4 = num;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00041F00 File Offset: 0x00040100
		// Note: this type is marked as 'beforefieldinit'.
		static SearchCondition()
		{
			int a_ = 16;
			short num = (short)1822711346;
			short num2 = num;
			num = (short)1837129266;
			switch (num2 == num)
			{
			}
			num = (short)518914048;
			short num3 = num;
			num = (short)763428864;
			if (num != 0)
			{
			}
			num = (short)107872257;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Command.SearchCondition.a = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("⤀⬂处理∈眊匌☎㤐伒└∖Ⱈ䜚渜㔞ࠠᰢ礤ᜦᴨᤪԬĮᨰలᰴ欶स༺༼᜾ᵀあ湄㭆浈扊摌㍎祐筒॔⑖牘❚͜癞䥠㽢啤剦屨㝪Ṭ䕮塰䱲⥴䝶䵸䱺啼兾ꪀ벂겄\udb86릈뾊몌ꞎ춐뺔붘늚뒜覠订捻풦芨힪蚮馰薴芶貸캼閾ﳂ鯆髈귐﯒﷔诖꫘ꇜ臞죠쯢매ퟦ\udce8\udeea뇬鳮\udbf0\udaf2꯴\udef6", a_));
		}

		// Token: 0x040000C4 RID: 196
		private static readonly global::System.Text.RegularExpressions.Regex a;

		// Token: 0x040000C5 RID: 197
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<string> b;

		// Token: 0x040000C6 RID: 198
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<string> c;
	}
}
