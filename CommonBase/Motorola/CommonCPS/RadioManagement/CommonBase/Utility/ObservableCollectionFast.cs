using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.CommonBase.Comparers;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x02000017 RID: 23
	public class ObservableCollectionFast<T> : global::System.Collections.ObjectModel.ObservableCollection<T>
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000A4C0 File Offset: 0x000086C0
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000A574 File Offset: 0x00008774
		public bool SuppressNotification
		{
			get
			{
				short num = (short)1148096237;
				short num2 = num;
				num = (short)997363437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1224540160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1145700353;
				if (num != 0)
				{
				}
				num = (short)1056440320;
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
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						if (!value)
						{
							num2 = (short)1856634881;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						num2 = (short)1254096897;
						if (num2 != 0)
						{
						}
						this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
						num2 = (short)342294530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				this.a = value;
				num2 = (short)380142232;
				short num3 = num2;
				num2 = (short)1534165656;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0A;
				default:
				{
					num2 = (short)704446464;
					short num4 = num2;
					num2 = (short)544342016;
					if (num2 != 0)
					{
					}
					num2 = (short)1006567424;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A69C File Offset: 0x0000889C
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1362231296;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_15;
				case 1:
				{
					base.OnCollectionChanged(e);
					num = (short)186859035;
					short num3 = num;
					num = (short)1116945947;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1414463488;
						if (num != 0)
						{
						}
						num = (short)1814822914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_BB;
				}
				goto IL_31;
				IL_15:
				switch (0)
				{
				case 0:
					IL_31:
					if (this.a)
					{
						return;
					}
					num = (short)1671036929;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_BB:
			num = (short)1166999552;
			short num4 = num;
			num = (short)790036481;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000A7B8 File Offset: 0x000089B8
		public ObservableCollectionFast()
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000A7CC File Offset: 0x000089CC
		public ObservableCollectionFast(global::System.Collections.Generic.IEnumerable<T> collection) : base(collection)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000A7E0 File Offset: 0x000089E0
		public ObservableCollectionFast(global::System.Collections.Generic.List<T> list) : base(list)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000A7F4 File Offset: 0x000089F4
		public virtual void AddRange(global::System.Collections.Generic.IEnumerable<T> collection)
		{
			int a_ = 6;
			short num = (short)1971453952;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<T> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_1D;
				case 1:
					return;
				case 2:
					try
					{
						num = (short)2101936130;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1198653443;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								T item = enumerator.Current;
								base.Items.Add(item);
								num = (short)1434386432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_135;
								}
								continue;
							case 3:
								num = (short)1916403716;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_1AD;
							}
							IL_161:
							num = (short)1288110081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_135:
							goto IL_161;
						}
						IL_1AD:
						goto IL_23F;
					}
					finally
					{
						num = (short)1115160576;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1E4;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)627900418;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_217;
							}
							IL_1E4:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1639514113;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_217:;
					}
					goto IL_21A;
				}
				goto IL_39;
				IL_1D:
				switch (0)
				{
				case 0:
				{
					IL_39:
					num = (short)843382785;
					if (num != 0)
					{
					}
					num = (short)450936705;
					short num3 = num;
					num = (short)628670337;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					case 1:
						break;
					default:
					{
						num = (short)1915092992;
						short num4 = num;
						break;
					}
					}
					num = (short)1987575808;
					if (num != 0)
					{
					}
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<T>.a(collection))
					{
						goto IL_21A;
					}
					num = (short)952369153;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				continue;
				IL_21A:
				enumerator = collection.GetEnumerator();
				num = (short)568852482;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_23F:
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᥙ㍛⭝๟ᙡ", a_)));
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ፙ⡛㭝ൟ㥡㥣", a_)));
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000AA90 File Offset: 0x00008C90
		public virtual void InsertRange(int startIndx, global::System.Collections.Generic.IEnumerable<T> collection)
		{
			int a_ = 7;
			short num = (short)1769930753;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<T> enumerator;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					try
					{
						num = (short)307298305;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)92800301;
								short num3 = num;
								num = (short)1921254701;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_148;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_97;
								}
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1568669700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								T item = enumerator.Current;
								base.Items.Insert(startIndx++, item);
								num = (short)394919939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)90767360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_C8:
							num = (short)1481506818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_97:
							goto IL_C8;
						}
						IL_148:
						num = (short)1454964736;
						if (num != 0)
						{
						}
						goto IL_240;
					}
					finally
					{
						num = (short)1102905345;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)115867650;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_194;
								}
								continue;
							case 2:
								goto IL_1C7;
							}
							IL_194:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2089549824;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1C7:;
					}
					goto IL_1CA;
				}
				IL_39:
				if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<T>.a(collection))
				{
					num = (short)514260992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1CA:
				num = (short)1787691009;
				if (num != 0)
				{
				}
				enumerator = collection.GetEnumerator();
				num = (short)709427200;
				short num4 = num;
				num = (short)189464578;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_240:
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᡚ㉜⩞འᝢ", a_)));
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ቚ⥜㩞ౠ㡢㡤", a_)));
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000AD38 File Offset: 0x00008F38
		public virtual void RemoveRange(global::System.Collections.Generic.IEnumerable<T> collection)
		{
			int a_ = 10;
			short num = (short)1292959746;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1681784833;
					if (num != 0)
					{
					}
					bool flag;
					if (flag)
					{
						num = (short)751304707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 1:
					try
					{
						num = (short)163315713;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								T item;
								if (base.Items.Remove(item))
								{
									num = (short)1885929478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
							{
								num = (short)286167812;
								short num3 = num;
								num = (short)1510576900;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1EA;
								default:
									num = (short)611975168;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_156;
									}
									continue;
								}
								break;
							}
							case 2:
								goto IL_201;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<T> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1866006533;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								T item = enumerator.Current;
								num = (short)1732706304;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_1EA;
							case 6:
							{
								bool flag = true;
								num = (short)863698948;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_158:
							num = (short)1027080195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_156:
							goto IL_158;
							IL_1EA:
							num = (short)2116485122;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_201:
						goto IL_6A;
					}
					finally
					{
						num = (short)1064239105;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<T> enumerator;
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)386727938;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_237;
								}
								continue;
							case 2:
								goto IL_26A;
							}
							IL_237:
							if (enumerator == null)
							{
								break;
							}
							num = (short)166461440;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_26A:;
					}
					return;
					IL_6A:
					num = (short)1236467712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 3:
					this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᵝཟᝡ੣ብ", a_)));
					this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("᝝ᑟݡॣ㵥㕧", a_)));
					this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
					num = (short)309198853;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
					return;
				}
				IL_45:
				if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<T>.a(collection))
				{
					num = (short)1450967044;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					bool flag = false;
					global::System.Collections.Generic.IEnumerator<T> enumerator = collection.GetEnumerator();
					num = (short)428802048;
					short num4 = num;
					num = (short)1919549441;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000B078 File Offset: 0x00009278
		public void MoveRange(int oldIndex, int newIndex, int length)
		{
			int a_ = 1;
			short num = (short)546439168;
			switch (num)
			{
			default:
			{
				num = (short)839188485;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_245;
					case 1:
						num = (short)2056978440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)2027421588;
						short num3 = num;
						num = (short)2103771028;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1BC;
						default:
							num = (short)720371712;
							if (num != 0)
							{
							}
							num = (short)1553727488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_EC;
					case 4:
					{
						int num4;
						if (num4 >= length)
						{
							num = (short)382730252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2088304640;
						short num5 = num;
						T item = base[oldIndex];
						base.Items.RemoveAt(oldIndex);
						base.Items.Insert(newIndex - 1, item);
						num4++;
						oldIndex++;
						newIndex++;
						num = (short)1187119117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 6:
					{
						if (newIndex < oldIndex)
						{
							num = (short)2048131079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = 0;
						num = (short)630128649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						int num6 = 0;
						num = (short)1306394638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_1BC;
					case 9:
						num = (short)1426063361;
						if (num != 0)
						{
						}
						goto IL_24A;
					case 10:
						goto IL_1DB;
					case 11:
					{
						int num6;
						if (num6 >= length)
						{
							num = (short)201195522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						T item2 = base[oldIndex];
						base.Items.RemoveAt(oldIndex);
						base.Items.Insert(newIndex, item2);
						num6++;
						oldIndex++;
						newIndex++;
						num = (short)1938685955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_285;
					case 13:
						goto IL_24A;
					case 14:
						goto IL_EC;
					}
					IL_89:
					if (length != 0)
					{
						num = (short)906690561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_EC:
					num = (short)1259929611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BC:
					if (oldIndex == newIndex)
					{
						num = (short)1858863114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)426049542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24A:
					num = (short)485556228;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1DB:
				return;
				IL_245:
				IL_285:
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᙔ㡖ⱘ㕚⥜", a_)));
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("᱔⍖㱘㙚ٜɞ", a_)));
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				return;
			}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000B3F4 File Offset: 0x000095F4
		public void RemoveRange(int startIndex, int length)
		{
			int a_ = 15;
			short num = (short)1737162753;
			if (num != 0)
			{
			}
			num = (short)2040922114;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2074738688;
				short num3 = num;
				num = (short)1632008352;
				short num4 = num;
				num = (short)418412704;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2134114304;
					if (num != 0)
					{
					}
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_151;
					case 1:
						if (num5 >= length)
						{
							num = (short)367263751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)908853248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_E8;
						}
						continue;
					case 3:
						goto IL_175;
					case 4:
						return;
					case 5:
						base.Items.RemoveAt(startIndex);
						num5++;
						num = (short)331087878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_175;
					case 7:
						goto IL_1A8;
					}
					IL_E8:
					if (startIndex >= base.Count)
					{
						num = (short)629538820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5 = 0;
					num = (short)2128805891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_175:
					num = (short)876412929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_151:
				if (base.Count <= startIndex)
				{
					goto IL_1C5;
				}
				num = (short)1249902597;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_1A8:
			IL_1C5:
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⁢੤ቦݨὪ", a_)));
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⩢ᅤɦѨなぬ", a_)));
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000B604 File Offset: 0x00009804
		public virtual void Reset(T item)
		{
			short num = (short)1894342878;
			short num2 = num;
			num = (short)40788190;
			switch (num2 == num)
			{
			}
			num = (short)1669726209;
			if (num != 0)
			{
			}
			num = (short)1565917184;
			if (num != 0)
			{
			}
			num = (short)1647902720;
			short num3 = num;
			this.Reset(new global::System.Collections.Generic.List<T>
			{
				item
			});
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000B6C0 File Offset: 0x000098C0
		public virtual void Reset(global::System.Collections.Generic.IEnumerable<T> collection)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			int count;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (base.Count != count)
					{
						num2 = (short)712704003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CA;
				case 1:
					goto IL_15A;
				case 2:
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<T>.a(collection))
					{
						num2 = (short)1347092484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A3;
				case 3:
				{
					this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("≠ౢၤ०ᵨ", a_)));
					num2 = (short)327680000;
					short num3 = num2;
					num2 = (short)350420993;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					global::System.Collections.Generic.IEnumerator<T> enumerator = collection.GetEnumerator();
					num2 = (short)1921843205;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					try
					{
						num2 = (short)289341441;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)1472678983;
								short num4 = num2;
								num2 = (short)543116359;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_246;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_198;
								}
								continue;
							case 2:
								num2 = (short)866451456;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<T> enumerator;
								if (!enumerator.MoveNext())
								{
									num2 = (short)443351042;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								T item = enumerator.Current;
								base.Items.Add(item);
								num2 = (short)2133000196;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							IL_19A:
							num2 = (short)1252196355;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_198:
							goto IL_19A;
						}
						IL_246:
						num2 = (short)1370882048;
						if (num2 != 0)
						{
						}
						goto IL_A3;
					}
					finally
					{
						num2 = (short)1667432449;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<T> enumerator;
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)343146498;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_291;
								}
								continue;
							case 2:
								goto IL_2C7;
							}
							IL_291:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1416953856;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_2C7:;
					}
					goto IL_2CA;
				}
				goto IL_31;
				IL_A3:
				num2 = (short)1033043968;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_15A:
			IL_2CA:
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⡠ᝢd੦㉨㙪", a_)));
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			return;
			IL_31:
			num2 = (short)791347201;
			if (num2 != 0)
			{
			}
			count = base.Count;
			base.Items.Clear();
			num2 = (short)1336672258;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000B9D8 File Offset: 0x00009BD8
		public void ResetRange(int startIndx, int count, global::System.Collections.Generic.IEnumerable<T> collection)
		{
			int a_ = 14;
			short num = (short)1718812672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				int count2;
				int num3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_1F8;
					case 1:
						if (count2 != base.Count)
						{
							num = (short)1656684551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38D;
					case 2:
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<T>.a(collection))
						{
							num = (short)220659715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EA;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<T> enumerator = collection.GetEnumerator();
						num = (short)1445134345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (num3 >= count)
						{
							num = (short)42926086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.Items.RemoveAt(startIndx);
						num3++;
						num = (short)2029060101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1F8;
					case 6:
						num = (short)1656750082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅱୣ፥٧ṩ", a_)));
						num = (short)1635188737;
						if (num != 0)
						{
						}
						num = (short)2059993096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_28F;
					case 9:
						try
						{
							num = (short)1342242817;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1720587260;
									short num4 = num;
									num = (short)538711036;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										goto IL_173;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_BC;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<T> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1357709316;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									T item = enumerator.Current;
									base.Items.Insert(startIndx++, item);
									num = (short)1486094339;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1591672832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_EE:
								num = (short)1560018946;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BC:
								goto IL_EE;
							}
							IL_173:
							num = (short)440795136;
							if (num != 0)
							{
							}
							goto IL_2EA;
						}
						finally
						{
							num = (short)1317863425;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<T> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)836763650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1C0;
									}
									continue;
								case 2:
									goto IL_1F5;
								}
								IL_1C0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1122762752;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1F5:;
						}
						goto IL_1F8;
					}
					goto IL_5F;
					IL_1F8:
					num = (short)892207108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EA:
					num = (short)2006515713;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_28F:
				num = (short)397213696;
				short num5 = num;
				IL_38D:
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⭡ၣͥէㅩㅫ", a_)));
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				return;
				IL_5F:
				count2 = base.Count;
				num3 = 0;
				num = (short)2066612224;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000BDB4 File Offset: 0x00009FB4
		private static bool a(global::System.Collections.Generic.IEnumerable<T> A_0)
		{
			short num = (short)1101398016;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
				{
					if (A_0.Count<T>() == 0)
					{
						num = (short)1719271427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)27525121;
					if (num != 0)
					{
					}
					num = (short)1678097180;
					short num3 = num;
					num = (short)655080220;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_DE;
					}
					break;
				}
				case 2:
					return true;
				case 3:
					return true;
				}
				IL_35:
				if (A_0 == null)
				{
					num = (short)809566210;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1230110721;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_DE:
			num = (short)1296695296;
			short num4 = num;
			num = (short)591593472;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x04000039 RID: 57
		private bool a;
	}
}
