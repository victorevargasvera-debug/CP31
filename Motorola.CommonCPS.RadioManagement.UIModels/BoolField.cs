using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000CB RID: 203
	public class BoolField : global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase, global::Motorola.CommonCPS.RadioManagement.UIModels.IBoolEdit, global::Motorola.CommonCPS.RadioManagement.UIModels.IFieldEdit, global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit
	{
		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0009231C File Offset: 0x0009051C
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x000923CC File Offset: 0x000905CC
		public virtual bool IsChecked
		{
			get
			{
				short num = (short)1760362496;
				short num2 = num;
				num = (short)293723180;
				short num3 = num;
				num = (short)293723180;
				switch (num3 == num)
				{
				}
				num = (short)95354881;
				if (num != 0)
				{
				}
				num = (short)1960378368;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				for (;;)
				{
					IL_0A:
					num = (short)2883585;
					if (num != 0)
					{
					}
					int num2;
					switch (num2)
					{
					case 0:
						goto IL_133;
					case 1:
						if (CS$<>8__locals1.value != this.a)
						{
							num = (short)2005532674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						base.DoModifyBlValue(delegate
						{
							int a_ = 14;
							switch (0)
							{
							case 0:
								goto IL_25;
							}
							short num6;
							for (;;)
							{
								IL_13:
								int num5;
								switch (num5)
								{
								case 0:
									goto IL_142;
								case 1:
								{
									num6 = (short)1657143296;
									short num7 = num6;
									if (!CS$<>8__locals1.<>4__this.IsLoading)
									{
										num6 = (short)1886978050;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									return;
								}
								case 2:
									num6 = (short)572194817;
									if (num6 != 0)
									{
									}
									CS$<>8__locals1.<>4__this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("H㡊์❎㑐げ㹔㉖㵘", a_));
									num6 = (short)2018115584;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								}
								break;
							}
							IL_25:
							num6 = (short)1753199484;
							short num8 = num6;
							num6 = (short)1731244924;
							switch ((num8 == num6) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_142:
								break;
							default:
							{
								num6 = (short)1498546176;
								if (num6 != 0)
								{
								}
								CS$<>8__locals1.<>4__this.a = CS$<>8__locals1.value;
								num6 = (short)1933508609;
								int num5 = (int)((global::System.IntPtr)num6);
								goto IL_13;
							}
							}
						});
						num = (short)1990983680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_43:
				num = (short)1633702949;
				short num3 = num;
				num = (short)972051493;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_133:
					break;
				default:
				{
					num = (short)457048064;
					if (num != 0)
					{
					}
					num = (short)312868864;
					short num4 = num;
					num = (short)433455105;
					int num2 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00092510 File Offset: 0x00090710
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> Items
		{
			get
			{
				short num = (short)818085888;
				short num2 = num;
				num = (short)1433420806;
				short num3 = num;
				num = (short)1176716294;
				switch (num3 == num)
				{
				}
				num = (short)1744699392;
				if (num != 0)
				{
				}
				num = (short)165019649;
				if (num != 0)
				{
				}
				return new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem>
				{
					new global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem(bool.FalseString),
					new global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem(bool.TrueString)
				};
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x000925E4 File Offset: 0x000907E4
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x0009269C File Offset: 0x0009089C
		public int SelectedIndex
		{
			get
			{
				short num = (short)1755250688;
				short num2 = num;
				num = (short)965528396;
				short num3 = num;
				num = (short)2004863820;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1354563585;
					if (num != 0)
					{
					}
					num = (short)1271922688;
					if (num != 0)
					{
					}
					if (!this.a)
					{
						return 0;
					}
					break;
				}
				return 1;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				bool val;
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)125348649;
					short num2 = num;
					num = (short)1137224489;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)335609856;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (value == -1)
							{
								goto IL_9B;
							}
							num = (short)1211432964;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							return;
						case 2:
						{
							num = (short)845414401;
							if (num != 0)
							{
							}
							num = (short)2061172736;
							short num4 = num;
							base.DoModifyBlValue(delegate
							{
								int a_ = 15;
								switch (0)
								{
								case 0:
									goto IL_25;
								}
								short num6;
								for (;;)
								{
									IL_13:
									int num5;
									switch (num5)
									{
									case 0:
										goto IL_117;
									case 1:
									{
										num6 = (short)1318060032;
										short num7 = num6;
										if (!this.IsLoading)
										{
											num6 = (short)2128347138;
											num5 = (int)((global::System.IntPtr)num6);
											continue;
										}
										return;
									}
									case 2:
										this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("᥉⥋≍㕏ㅑ⁓㍕㱗ፙ㉛㩝՟ᩡ", a_));
										num6 = (short)4521984;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									break;
								}
								IL_25:
								num6 = (short)1619399828;
								short num8 = num6;
								num6 = (short)232658068;
								switch ((num8 == num6) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_117:
									num6 = (short)9306113;
									if (num6 != 0)
									{
									}
									break;
								default:
								{
									num6 = (short)1951531008;
									if (num6 != 0)
									{
									}
									this.a = val;
									num6 = (short)797769729;
									int num5 = (int)((global::System.IntPtr)num6);
									goto IL_13;
								}
								}
							});
							num = (short)428408837;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (val != this.a)
							{
								num = (short)1826881538;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 4:
							val = (value != 0);
							num = (short)1964965891;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							return;
						}
						goto IL_72;
					}
					IL_9B:
					num = (short)729939969;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_72:
				num = (short)1055719424;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0009284C File Offset: 0x00090A4C
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x000928FC File Offset: 0x00090AFC
		public bool SortedDefaultValue
		{
			get
			{
				short num = (short)355926016;
				short num2 = num;
				num = (short)246217676;
				short num3 = num;
				num = (short)1337523148;
				switch (num3 == num)
				{
				}
				num = (short)495124481;
				if (num != 0)
				{
				}
				num = (short)1230503936;
				if (num != 0)
				{
				}
				return false;
			}
			set
			{
				short num = (short)747110400;
				short num2 = num;
				num = (short)494429031;
				short num3 = num;
				num = (short)331047783;
				switch (num3 == num)
				{
				}
				num = (short)29884416;
				if (num != 0)
				{
				}
				num = (short)1508245505;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000929A0 File Offset: 0x00090BA0
		public bool IsReferField
		{
			get
			{
				short num = (short)2009726976;
				short num2 = num;
				num = (short)1468334081;
				if (num != 0)
				{
				}
				num = (short)2100252632;
				short num3 = num;
				num = (short)421416920;
				switch (num3 == num)
				{
				}
				num = (short)773062656;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00092A4C File Offset: 0x00090C4C
		public void RefreshChoices(bool isSortRequired)
		{
			short num = (short)505675776;
			short num2 = num;
			num = (short)401735681;
			if (num != 0)
			{
			}
			num = (short)1186789598;
			short num3 = num;
			num = (short)1584199902;
			switch (num3 == num)
			{
			}
			num = (short)1561329664;
			if (num != 0)
			{
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00092AFC File Offset: 0x00090CFC
		public override void RaisePropertyChanged()
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_7C;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)674615405;
				short num2 = num;
				num = (short)587649133;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1422327808;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)1593507841;
						if (num != 0)
						{
						}
						if (!base.IsLoading)
						{
							goto IL_CA;
						}
						goto IL_114;
					case 1:
						this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཅ㭇ॉ⑋⭍㍏㥑ㅓ㉕", a_));
						num = (short)2139291650;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1309474816;
						short num4 = num;
						goto IL_114;
					}
					case 3:
						this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᕅⵇ♉⥋ⵍ⑏㝑こὕ㙗㹙㥛♝", a_));
						num = (short)1032126468;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_10F;
					case 5:
						if (!base.IsLoading)
						{
							num = (short)692453379;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A6;
					}
					goto IL_7C;
					IL_114:
					num = (short)249364485;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CA:
				num = (short)103940097;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			IL_1A6:
			base.IsSelfChangeOnly = false;
			return;
			IL_7C:
			base.RaisePropertyChanged();
			num = (short)1602551808;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00092CB8 File Offset: 0x00090EB8
		public override string ToString()
		{
			short num;
			string result;
			try
			{
				num = (short)369688576;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1939013633;
					if (num != 0)
					{
					}
					string text;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 1:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Common_Bool_False;
						goto IL_107;
					case 2:
						goto IL_11F;
					case 3:
						num = (short)866385921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Common_Bool_True;
						goto IL_107;
					}
					IL_60:
					if (this.IsChecked)
					{
						num = (short)319225860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)872472315;
					short num3 = num;
					num = (short)66707195;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2028404736;
						if (num != 0)
						{
						}
						num = (short)5701635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_108:
					num = (short)75497474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_107:
					result = text;
					goto IL_108;
				}
				IL_11F:;
			}
			catch (global::System.Exception)
			{
				result = string.Empty;
			}
			num = (short)1179582464;
			short num4 = num;
			return result;
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00092E38 File Offset: 0x00091038
		public override string ValueForCompare
		{
			get
			{
				short num = (short)1212809216;
				short num2 = num;
				num = (short)621227438;
				short num3 = num;
				num = (short)2008690094;
				switch (num3 == num)
				{
				}
				num = (short)1447428097;
				if (num != 0)
				{
				}
				num = (short)1863122944;
				if (num != 0)
				{
				}
				return this.IsChecked.ToString();
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00092EF0 File Offset: 0x000910F0
		protected override global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult PasteFromOverride(global::System.Xml.Linq.XElement xmlElement, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>> setsToAdd, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> setsToRemove, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.PasteContext pasteContext)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			bool? flag;
			string value;
			global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1229651969;
					if (num2 != 0)
					{
					}
					if (flag != null)
					{
						num2 = (short)1837563914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					pasteContext.Statuses.InvalidFieldValue(this, value);
					goto IL_18D;
				case 1:
					return result;
				case 2:
					if (this.IsChecked != flag.Value)
					{
						num2 = (short)161873925;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (value == global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Common_Bool_True)
					{
						num2 = (short)203358212;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)726663177;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)140902400;
					short num3 = num2;
					flag = new bool?(true);
					num2 = (short)1167327238;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					this.IsChecked = flag.Value;
					result = global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Changed;
					num2 = (short)1025376257;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_D4;
				case 7:
				{
					num2 = (short)765189582;
					short num4 = num2;
					num2 = (short)1625087438;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18D;
					default:
						goto IL_1D9;
					}
					break;
				}
				case 8:
					goto IL_D4;
				case 9:
					if (value == global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Common_Bool_False)
					{
						num2 = (short)846331915;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D4;
				case 10:
					num2 = (short)1118830594;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					flag = new bool?(false);
					num2 = (short)467468296;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_D4:
				result = global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
				num2 = (short)975372288;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18D:
				num2 = (short)584318983;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1D9:
			num2 = (short)1775960064;
			if (num2 != 0)
			{
			}
			return result;
			IL_40:
			value = xmlElement.Value;
			flag = null;
			num2 = (short)2096758787;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000388 RID: 904
		private bool a;
	}
}
