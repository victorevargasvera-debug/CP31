using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000A1 RID: 161
	public class Langauge : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x060005DB RID: 1499 RVA: 0x00054A50 File Offset: 0x00052C50
		public Langauge()
		{
			this.b = new global::System.Collections.ObjectModel.ObservableCollection<string>();
			this.b();
			this.a();
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00054A7C File Offset: 0x00052C7C
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00054B28 File Offset: 0x00052D28
		public string InitialLanguageSelection
		{
			get
			{
				short num = (short)362760657;
				short num2 = num;
				num = (short)625625553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)918683648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)430571521;
				if (num != 0)
				{
				}
				num = (short)583794688;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1144520706;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_A5;
					case 1:
						goto IL_EE;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (!(value != this.a))
					{
						break;
					}
					num = (short)1201002513;
					short num3 = num;
					num = (short)1039783953;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)637337600;
						if (num != 0)
						{
						}
						num = (short)657326080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A5:
					num = (short)1480327168;
					short num4 = num;
					this.a = value;
					num = (short)221446145;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EE:
				num = (short)1669464065;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00054C4C File Offset: 0x00052E4C
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00054CFC File Offset: 0x00052EFC
		public global::System.Collections.ObjectModel.ObservableCollection<string> SupportedLanguages
		{
			get
			{
				short num = (short)1650160607;
				short num2 = num;
				num = (short)1269658591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1060044800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1092485121;
				if (num != 0)
				{
				}
				num = (short)2005860352;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)690159620;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)999185126;
						short num3 = num;
						num = (short)997350118;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)296419329;
							if (num != 0)
							{
							}
							num = (short)79822848;
							short num4 = num;
							num = (short)1701445632;
							if (num != 0)
							{
							}
							this.b = value;
							num = (short)1068695554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)1675493379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<string>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<string>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge.get_SupportedLanguages())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2028797953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					}
					IL_38:
					if (this.b == value)
					{
						break;
					}
					num = (short)2037055488;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00054E98 File Offset: 0x00053098
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00054F48 File Offset: 0x00053148
		public string SelectedLanguage
		{
			get
			{
				short num = (short)656526730;
				short num2 = num;
				num = (short)1061539210;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2073296896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1130168320;
				if (num != 0)
				{
				}
				num = (short)336986113;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1660420097;
				if (num != 0)
				{
				}
				num = (short)378863620;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)528475292;
						short num3 = num;
						num = (short)1916986524;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)716308480;
							short num4 = num;
							num = (short)704774144;
							if (num != 0)
							{
							}
							this.c = value;
							num = (short)397803522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)1415774211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge.get_SelectedLanguage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)17498113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					IL_61:
					if (!(this.c != value))
					{
						break;
					}
					num = (short)1884815360;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000550E4 File Offset: 0x000532E4
		private void b()
		{
			short num = (short)1594621952;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage instance;
				for (;;)
				{
					IL_27:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_29F;
					case 1:
						num = (short)950927361;
						if (num != 0)
						{
							goto IL_2E5;
						}
						goto IL_2E5;
						IL_2E5:
						goto IL_C3;
						try
						{
							for (;;)
							{
								IL_C3:
								num = (short)1793916933;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
										if (keyValuePair.Key != null)
										{
											num = (short)1900085251;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_156;
									}
									case 1:
										num = (short)948699138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_225;
									case 3:
									{
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
										this.SupportedLanguages.Add(keyValuePair.Key);
										num = (short)782696452;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_156;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_107;
										}
										continue;
									case 6:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)122421249;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = (global::System.Collections.Generic.KeyValuePair<string, string>)enumerator.Current;
										num = (short)347799552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_107;
									IL_156:
									num = (short)291635206;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_107:
									num = (short)869608509;
									short num3 = num;
									num = (short)2090413117;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_C3;
									default:
										num = (short)1531969536;
										if (num != 0)
										{
										}
										goto IL_156;
									}
								}
							}
							IL_225:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_247;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_234:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)587792385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_29C;
								case 2:
									if (disposable != null)
									{
										num = (short)854654976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29E;
								}
								goto IL_247;
							}
							IL_29C:
							IL_29E:
							goto EndFinally_7;
							IL_247:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1254948866;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_234;
							EndFinally_7:;
						}
						goto IL_29F;
					case 2:
						if (instance.Count > 0)
						{
							num = (short)1469579264;
							short num4 = num;
							num = (short)454885376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_3A;
					IL_29F:
					enumerator = ((global::System.Collections.IEnumerable)instance).GetEnumerator();
					num = (short)80478209;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3A:
				instance = global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.GetInstance();
				global::System.Globalization.CultureInfo cultureInfo = new global::System.Globalization.CultureInfo(global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.MainAssemblyCulture);
				this.SupportedLanguages.Add(cultureInfo.NativeName);
				num = (short)1180237826;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000553F8 File Offset: 0x000535F8
		private void a()
		{
			int a_ = 8;
			short num = (short)1405026304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage instance;
				for (;;)
				{
					IL_31:
					bool flag;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_39B;
					case 1:
						num = (short)1300430857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_AF;
					case 3:
						goto IL_3CD;
					case 4:
						if (!string.IsNullOrEmpty(instance.DefaultRMCLanguage))
						{
							num = (short)426639371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)690290696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_AF;
					case 6:
						goto IL_AF;
					case 7:
						if (!flag)
						{
							num = (short)1486880768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B0;
					case 8:
						if (!global::Motorola.CommonCPS.ResourceRepository.Resources.Culture.Name.Contains(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("♂㙄", a_)))
						{
							num = (short)980287489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D2;
					case 9:
						if (global::Motorola.CommonCPS.ResourceRepository.Resources.Culture.Name.Contains(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("≂㝄", a_)))
						{
							num = (short)264306698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a = global::Motorola.CommonCPS.ResourceRepository.Resources.Culture.Name;
						num = (short)1487863814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1609826305;
						if (num != 0)
						{
						}
						goto IL_3D2;
					case 11:
					{
						num = (short)1062600704;
						short num3 = num;
						this.a = instance.DefaultRMCLanguage;
						num = (short)844365826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_1BE;
						try
						{
							for (;;)
							{
								IL_1BE:
								num = (short)2105212933;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
										if (keyValuePair.Value == this.a)
										{
											num = (short)1183645699;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_24D;
									}
									case 1:
										num = (short)1933508610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_322;
									case 3:
									{
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
										this.SelectedLanguage = keyValuePair.Key;
										flag = true;
										num = (short)1407778820;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_305;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_201;
										}
										continue;
									case 6:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1565720577;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = (global::System.Collections.Generic.KeyValuePair<string, string>)enumerator.Current;
										num = (short)1136328704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_201;
									IL_24D:
									num = (short)227344390;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_201:
									num = (short)1952401572;
									short num4 = num;
									num = (short)270157988;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1BE;
									default:
										num = (short)1181089792;
										if (num != 0)
										{
										}
										goto IL_24D;
									}
								}
							}
							IL_305:
							IL_322:
							goto IL_12F;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_344;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_331:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)940310529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_398;
								case 2:
									if (disposable != null)
									{
										num = (short)755171328;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_39A;
								}
								goto IL_344;
							}
							IL_398:
							IL_39A:
							goto EndFinally_10;
							IL_344:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)2120876034;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_331;
							EndFinally_10:;
						}
						goto IL_39B;
						IL_12F:
						num = (short)580780039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C;
					IL_AF:
					flag = false;
					enumerator = ((global::System.Collections.IEnumerable)instance).GetEnumerator();
					num = (short)1347354636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39B:
					global::System.Globalization.CultureInfo cultureInfo = new global::System.Globalization.CultureInfo(global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.MainAssemblyCulture);
					this.SelectedLanguage = cultureInfo.NativeName;
					num = (short)2107441155;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D2:
					this.a = global::Motorola.CommonCPS.ResourceRepository.Resources.Culture.Name.Substring(0, 2);
					num = (short)1829240837;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3CD:
				IL_4B0:
				this.a = this.SelectedLanguage;
				return;
				IL_6C:
				instance = global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.GetInstance();
				num = (short)1983315972;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x040002A5 RID: 677
		private string a;

		// Token: 0x040002A6 RID: 678
		private global::System.Collections.ObjectModel.ObservableCollection<string> b;

		// Token: 0x040002A7 RID: 679
		private string c;
	}
}
