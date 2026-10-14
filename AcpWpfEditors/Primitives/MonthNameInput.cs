using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000071 RID: 113
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class MonthNameInput : global::DevComponents.WpfEditors.Primitives.EditorStringListInput, global::DevComponents.WpfEditors.Primitives.IDateTimePartInput
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x00098524 File Offset: 0x00096724
		protected override global::System.Collections.Generic.List<string> GetItems()
		{
			short num = (short)1246887937;
			if (num != 0)
			{
			}
			num = (short)585105410;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a.Count == 13)
					{
						num = (short)1956446217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B7;
				case 1:
					if (this.d)
					{
						num = (short)1769930755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a.AddRange(global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.MonthNames);
					num = (short)981073925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_3D;
				case 3:
				{
					num = (short)477159351;
					short num3 = num;
					num = (short)544333751;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						num = (short)199491584;
						if (num != 0)
						{
						}
						this.a.AddRange(global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.AbbreviatedMonthNames);
						num = (short)1410924548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_FA;
				case 5:
					goto IL_FA;
				case 6:
					this.a.RemoveAt(12);
					num = (short)342163464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)543686668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_223;
				case 9:
				{
					num = (short)65208320;
					short num4 = num;
					num = (short)917372939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					this.a = new global::System.Collections.Generic.List<string>(12);
					num = (short)1578434561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (this.a[12] == "")
					{
						num = (short)1462829062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B7;
				case 12:
					if (this.a == null)
					{
						num = (short)855244810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B7;
				}
				goto IL_81;
				IL_3D:
				switch (0)
				{
				case 0:
					IL_81:
					if (base.Items.Count == 12)
					{
						goto IL_2DC;
					}
					num = (short)2137456647;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_FA:
				num = (short)1514602496;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1B7:
			return this.a;
			IL_223:
			goto IL_1B7;
			IL_2DC:
			return base.GetItems();
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00098814 File Offset: 0x00096A14
		protected override bool ValidateNewInputStack(string s)
		{
			short num = (short)2127364096;
			switch (num)
			{
			default:
			{
				num = (short)744030211;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					bool flag;
					switch (num2)
					{
					case 0:
						num3 = 0;
						int.TryParse(s, out num3);
						num = (short)273809413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int num4;
						if (num4 > this.c)
						{
							num = (short)1976041484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 2:
						num = (short)1038221318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1842394301;
						short num5 = num;
						num = (short)1858319549;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_21B;
						default:
							num = (short)167706624;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_DA;
							}
							continue;
						}
						break;
					}
					case 4:
						base.LastMatchComplete = true;
						num = (short)694419474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_21B;
					case 6:
						if (num3 <= this.c)
						{
							num = (short)127336464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31E;
					case 7:
						num = (short)1557135368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (base.LastValidatedInputStack.Length > 0)
						{
							num = (short)1553268753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 9:
					{
						int num4;
						if (num4 >= this.b)
						{
							num = (short)1214709761;
							if (num != 0)
							{
							}
							num = (short)901120010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 10:
						num = (short)1568342017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (num3 >= this.b)
						{
							num = (short)2114781186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31E;
					case 12:
						return false;
					case 13:
						if (num3 > 1)
						{
							num = (short)422117380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 14:
						if (flag)
						{
							num = (short)354942983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 15:
						num = (short)1263730699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::System.Collections.Generic.List<string> items = this.GetItems();
						base.LastMatch = items[num3 - 1];
						base.LastValidatedInputStack = s;
						num = (short)1159266317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						num = (short)1275985920;
						short num6 = num;
						int num4 = this.GetItems().IndexOf(base.LastMatch) + 1;
						num = (short)221642761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_2DB;
					}
					IL_DA:
					if (s.Length > 0)
					{
						num = (short)1043726336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31E;
					IL_21B:
					if (num3 > 0)
					{
						num = (short)1170407439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31E:
					flag = base.ValidateNewInputStack(s);
					num = (short)278659086;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_2DB:
				return true;
			}
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00098BE0 File Offset: 0x00096DE0
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00098CAC File Offset: 0x00096EAC
		int? global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.Value
		{
			get
			{
				while (base.SelectedIndex == -1)
				{
					short num = (short)402671518;
					short num2 = num;
					num = (short)927090590;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)68026368;
						short num3 = num;
						break;
					}
					}
					num = (short)1662189569;
					if (num != 0)
					{
					}
					num = (short)860815360;
					if (num != 0)
					{
					}
					return null;
				}
				return new int?(base.SelectedIndex + 1);
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)1547239425;
					if (num != 0)
					{
					}
					if (value != null)
					{
						goto IL_B4;
					}
					num = (short)683474944;
					short num2 = num;
					num = (short)97023901;
					short num3 = num;
					num = (short)1074165661;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_95;
					}
				}
				IL_95:
				num = (short)1690959872;
				if (num != 0)
				{
				}
				base.SelectedIndex = -1;
				return;
				IL_B4:
				base.SelectedIndex = value.Value - 1;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00098D7C File Offset: 0x00096F7C
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00098E2C File Offset: 0x0009702C
		int global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.MinValue
		{
			get
			{
				short num = (short)1733631240;
				short num2 = num;
				num = (short)1935285512;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1948647424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252589568;
				if (num != 0)
				{
				}
				num = (short)2074214401;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1733230596;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.b = value;
						num = (short)1065937958;
						short num3 = num;
						num = (short)1760619558;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8B;
						default:
							num = (short)1275789312;
							if (num != 0)
							{
							}
							num = (short)1851195397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (base.SelectedIndex < this.b)
						{
							num = (short)1648230403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
					{
						num = (short)210239488;
						short num4 = num;
						goto IL_8B;
					}
					case 4:
						num = (short)532348929;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_66;
						}
						continue;
					case 5:
						if (!this.IsEmpty)
						{
							num = (short)687013894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num = (short)571670529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_66:
					if (this.b != value)
					{
						num = (short)1135869952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_8B:
					base.SelectedIndex = this.b;
					num = (short)1240924162;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00098FE4 File Offset: 0x000971E4
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00099090 File Offset: 0x00097290
		int global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.MaxValue
		{
			get
			{
				short num = (short)1883868952;
				short num2 = num;
				num = (short)1792118552;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1278476288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1750925313;
				if (num != 0)
				{
				}
				num = (short)895680512;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1677721604;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1650393088;
						short num3 = num;
						this.c = value;
						num = (short)1285813126;
						short num4 = num;
						num = (short)986313606;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_62;
						default:
							num = (short)409468928;
							if (num != 0)
							{
							}
							num = (short)394395653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (base.SelectedIndex > this.c)
						{
							num = (short)315949059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						goto IL_62;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_40;
						}
						continue;
					case 5:
						num = (short)1206517761;
						if (num != 0)
						{
						}
						if (!this.IsEmpty)
						{
							num = (short)745799686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num = (short)646250497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_40:
					if (this.c != value)
					{
						num = (short)251330560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_62:
					base.SelectedIndex = this.c;
					num = (short)2099707906;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00099244 File Offset: 0x00097444
		global::DevComponents.WpfEditors.Primitives.eDateTimePart global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.Part
		{
			get
			{
				short num = (short)1863780192;
				short num2 = num;
				num = (short)700909408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)847773696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284229632;
				if (num != 0)
				{
				}
				num = (short)373686273;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.Primitives.eDateTimePart.Month;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x000992F0 File Offset: 0x000974F0
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x000993A0 File Offset: 0x000975A0
		[global::System.ComponentModel.DefaultValue(false)]
		public bool UseAbbreviatedNames
		{
			get
			{
				short num = (short)2068230721;
				short num2 = num;
				num = (short)1234809409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1430192128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1906049024;
				if (num != 0)
				{
				}
				num = (short)615055361;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1268121600;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1119748097;
					if (num != 0)
					{
					}
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
						goto IL_F1;
					case 2:
						return;
					}
					IL_58:
					num = (short)442761216;
					short num3 = num;
					num = (short)347162184;
					short num4 = num;
					num = (short)454968904;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_F1:
						this.d = value;
						this.a = null;
						base.InvalidateArrange();
						num = (short)750256130;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1959460864;
						if (num != 0)
						{
						}
						if (this.d == value)
						{
							return;
						}
						num = (short)1324089345;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x040002FE RID: 766
		private global::System.Collections.Generic.List<string> a;

		// Token: 0x040002FF RID: 767
		private int b = 1;

		// Token: 0x04000300 RID: 768
		private int c = 12;

		// Token: 0x04000301 RID: 769
		private bool d;
	}
}
