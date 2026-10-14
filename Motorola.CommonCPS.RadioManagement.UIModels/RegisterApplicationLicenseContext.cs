using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000073 RID: 115
	public class RegisterApplicationLicenseContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x0600033B RID: 827 RVA: 0x00030640 File Offset: 0x0002E840
		public RegisterApplicationLicenseContext()
		{
			this.c = new global::System.Collections.Generic.List<string>();
			this.e = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>();
			this.e.CollectionChanged += this.a;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00030680 File Offset: 0x0002E880
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0003072C File Offset: 0x0002E92C
		public int CurrentMode
		{
			get
			{
				short num = (short)614926918;
				short num2 = num;
				num = (short)107285062;
				switch (num2 == num)
				{
				}
				num = (short)2117271553;
				if (num != 0)
				{
				}
				num = (short)520617984;
				short num3 = num;
				num = (short)1795358720;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1674706946;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)579076097;
							if (num != 0)
							{
							}
							num = (short)1520107524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
					{
						num = (short)710487893;
						short num3 = num;
						num = (short)1827614549;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_189;
						default:
						{
							num = (short)1992753152;
							short num4 = num;
							num = (short)1269760000;
							if (num != 0)
							{
							}
							this.a = value;
							num = (short)208273408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						goto IL_189;
					}
					IL_38:
					if (value != this.a)
					{
						num = (short)702873603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_189:
					base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext.get_CurrentMode())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1508769793;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600033E RID: 830 RVA: 0x000308C8 File Offset: 0x0002EAC8
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00030978 File Offset: 0x0002EB78
		public global::System.Collections.Generic.List<string> EIDHistory
		{
			get
			{
				short num = (short)1036993725;
				short num2 = num;
				num = (short)1384137917;
				switch (num2 == num)
				{
				}
				num = (short)1491730433;
				if (num != 0)
				{
				}
				num = (short)1642921984;
				short num3 = num;
				num = (short)1292304384;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)208076802;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)1446445060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_A8;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
					{
						num = (short)1049735834;
						short num3 = num;
						num = (short)1951838874;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_188;
						case 1:
							break;
						default:
						{
							num = (short)747438080;
							short num4 = num;
							break;
						}
						}
						num = (short)1612775424;
						if (num != 0)
						{
						}
						this.c = value;
						num = (short)1321664512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_188;
					}
					IL_38:
					if (value != this.c)
					{
						num = (short)96600067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_188:
					base.RaisePropertyChanged<global::System.Collections.Generic.List<string>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.Generic.List<string>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext.get_EIDHistory())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)700645377;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A8:
				num = (short)1547632641;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00030B14 File Offset: 0x0002ED14
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00030BC4 File Offset: 0x0002EDC4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo EidInfoItem
		{
			get
			{
				short num = (short)286299206;
				short num2 = num;
				num = (short)460428358;
				switch (num2 == num)
				{
				}
				num = (short)810352640;
				if (num != 0)
				{
				}
				num = (short)416481280;
				short num3 = num;
				num = (short)1571946497;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1521942530;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)777650180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
					{
						num = (short)1574149631;
						short num3 = num;
						num = (short)799972863;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_184;
						case 1:
							break;
						default:
						{
							num = (short)442236928;
							short num4 = num;
							break;
						}
						}
						num = (short)979828736;
						if (num != 0)
						{
						}
						this.f = value;
						num = (short)1396768768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_184;
					}
					IL_38:
					if (value != this.f)
					{
						num = (short)1429143553;
						if (num != 0)
						{
						}
						num = (short)1403781123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_184:
					base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext.get_EidInfoItem())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1405616129;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00030D5C File Offset: 0x0002EF5C
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00030E0C File Offset: 0x0002F00C
		public string EIDString
		{
			get
			{
				short num = (short)1235623478;
				short num2 = num;
				num = (short)743120438;
				switch (num2 == num)
				{
				}
				num = (short)62849025;
				if (num != 0)
				{
				}
				num = (short)1420623872;
				short num3 = num;
				num = (short)537198592;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1780088834;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)514654212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_168;
					case 1:
						goto IL_AB;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 3:
					{
						num = (short)1552814174;
						short num3 = num;
						num = (short)291639390;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_163;
						default:
							num = (short)181141504;
							if (num != 0)
							{
							}
							num = (short)973471745;
							if (num != 0)
							{
							}
							this.b = value;
							num = (short)292487168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_163;
					}
					IL_39:
					if (value != this.b)
					{
						num = (short)194445315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_163:
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext.get_EIDString())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)2074279937;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AB:
				IL_168:
				num = (short)1603928064;
				short num4 = num;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00030FAC File Offset: 0x0002F1AC
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00031058 File Offset: 0x0002F258
		public string LicenseFile
		{
			get
			{
				short num = (short)1302641139;
				short num2 = num;
				num = (short)485997043;
				switch (num2 == num)
				{
				}
				num = (short)2056912897;
				if (num != 0)
				{
				}
				num = (short)2117730304;
				short num3 = num;
				num = (short)2056192000;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1173553155;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1235489565;
						short num3 = num;
						num = (short)2030834461;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D9;
						default:
							num = (short)2061762560;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)712310786;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16A;
						}
						break;
					}
					case 1:
						goto IL_D4;
					case 2:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext.get_LicenseFile())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1885798401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 4:
						goto IL_D9;
					}
					IL_38:
					num = (short)804126721;
					if (num != 0)
					{
					}
					if (value != this.d)
					{
						num = (short)53411844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_D9:
					this.d = value;
					num = (short)1197539328;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D4:
				IL_16A:
				num = (short)544473088;
				short num4 = num;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000346 RID: 838 RVA: 0x000311F8 File Offset: 0x0002F3F8
		// (set) Token: 0x06000347 RID: 839 RVA: 0x000312AC File Offset: 0x0002F4AC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> EIDInfos
		{
			get
			{
				short num = (short)103123023;
				short num2 = num;
				num = (short)1484949583;
				switch (num2 == num)
				{
				}
				num = (short)1428160512;
				if (num != 0)
				{
				}
				num = (short)980418560;
				short num3 = num;
				num = (short)560529409;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1947664387;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)656878528;
						short num3 = num;
						num = (short)1885481920;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AD;
						default:
							num = (short)394133504;
							if (num != 0)
							{
							}
							num = (short)236847105;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)681639938;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15E;
						}
						break;
					}
					case 1:
						goto IL_A8;
					case 2:
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext.get_EIDInfos())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1420230657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 4:
						goto IL_AD;
					}
					IL_39:
					if (value != this.e)
					{
						num = (short)574029828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_AD:
					this.e = value;
					num = (short)1753677824;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A8:
				IL_15E:
				num = (short)1859452928;
				short num4 = num;
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00031440 File Offset: 0x0002F640
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1577385984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1578237954;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						try
						{
							num = (short)492765187;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)444661762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										goto IL_156;
									}
									object obj = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo eidinfo = obj as global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo;
									eidinfo.PropertyChanged += this.a;
									num = (short)240517124;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_18B;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_B0;
									}
									continue;
								}
								IL_E9:
								num = (short)2016301918;
								short num3 = num;
								num = (short)818828126;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_156:
									num = (short)1623326720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								default:
									num = (short)1695875072;
									if (num != 0)
									{
									}
									num = (short)1614282753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B0:
								goto IL_E9;
							}
							IL_18B:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1AD;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_19A:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1565392897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1FF;
								case 2:
									if (disposable != null)
									{
										num = (short)307298304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_201;
								}
								goto IL_1AD;
							}
							IL_1FF:
							IL_201:
							goto EndFinally_5;
							IL_1AD:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)157483010;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_19A;
							EndFinally_5:;
						}
						goto IL_202;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					}
					IL_50:
					if (A_1.NewItems == null)
					{
						num = (short)198377472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_202:
					num = (short)1039990784;
					short num4 = num;
					num = (short)152043521;
					if (num != 0)
					{
					}
					enumerator = A_1.NewItems.GetEnumerator();
					num = (short)306053121;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000316E8 File Offset: 0x0002F8E8
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)1047658498;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1173946368;
					short num3 = num;
					num = (short)1314062337;
					if (num != 0)
					{
					}
					base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext.get_EIDInfos())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					goto IL_141;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				num = (short)1303273286;
				short num4 = num;
				num = (short)2056085318;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_141:
					num = (short)72286209;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)424542208;
					if (num != 0)
					{
					}
					if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᩇ⭉⡋❍㽏ᅑ㭓⍕㙗⹙ज़⹝џ͡ၣͥ᭧", a_)))
					{
						return;
					}
					num = (short)457310208;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0400017F RID: 383
		private int a;

		// Token: 0x04000180 RID: 384
		private string b;

		// Token: 0x04000181 RID: 385
		private global::System.Collections.Generic.List<string> c;

		// Token: 0x04000182 RID: 386
		private string d;

		// Token: 0x04000183 RID: 387
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> e;

		// Token: 0x04000184 RID: 388
		private global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo f;
	}
}
