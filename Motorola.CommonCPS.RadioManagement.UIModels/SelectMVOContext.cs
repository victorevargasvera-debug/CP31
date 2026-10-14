using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200007D RID: 125
	public class SelectMVOContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x060003C9 RID: 969 RVA: 0x0003882C File Offset: 0x00036A2C
		public SelectMVOContext()
		{
			this.AppOption = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option>();
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060003CA RID: 970 RVA: 0x00038898 File Offset: 0x00036A98
		// (remove) Token: 0x060003CB RID: 971 RVA: 0x000389D4 File Offset: 0x00036BD4
		public event global::System.ComponentModel.PropertyChangedEventHandler SelectedProductFamilyPropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)920293557;
					short num2 = num;
					num = (short)1889767605;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1563164672;
						if (num != 0)
						{
						}
						num = (short)193396737;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1793916929;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AF;
						case 1:
							return;
						case 2:
							goto IL_AF;
						}
						goto IL_8F;
						IL_AF:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.q, value2, propertyChangedEventHandler2);
						num = (short)1149829120;
						short num4 = num;
						num = (short)1665204224;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_8F:
				propertyChangedEventHandler = this.q;
				num = (short)1586692098;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)738610849;
					short num2 = num;
					num = (short)2032357025;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1107165184;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)576323585;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B1;
						case 1:
							return;
						case 2:
							goto IL_B1;
						}
						goto IL_67;
						IL_B1:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.q, value2, propertyChangedEventHandler2);
						num = (short)226099200;
						short num4 = num;
						num = (short)1272053760;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_67:
				num = (short)2080571393;
				if (num != 0)
				{
				}
				propertyChangedEventHandler = this.q;
				num = (short)1505492994;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060003CC RID: 972 RVA: 0x00038B10 File Offset: 0x00036D10
		// (remove) Token: 0x060003CD RID: 973 RVA: 0x00038C44 File Offset: 0x00036E44
		public event global::System.ComponentModel.PropertyChangedEventHandler SelectedVersionPropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1845362689;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8D;
				}
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_31:
					num = (short)1769358391;
					short num2 = num;
					num = (short)1292583991;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)248512512;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1020133377;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AB;
						case 1:
							return;
						case 2:
							goto IL_AB;
						}
						goto IL_8D;
						IL_AB:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.r, value2, propertyChangedEventHandler2);
						num = (short)385613824;
						short num4 = num;
						num = (short)1870659584;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_8D:
				propertyChangedEventHandler = this.r;
				num = (short)88145922;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)1840194978;
					short num2 = num;
					num = (short)298853794;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1526530048;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)409141249;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_88;
						case 1:
							return;
						case 2:
							goto IL_88;
						}
						goto IL_6A;
						IL_88:
						num = (short)1370423297;
						if (num != 0)
						{
						}
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.r, value2, propertyChangedEventHandler2);
						num = (short)553975808;
						short num4 = num;
						num = (short)1107427328;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_6A:
				propertyChangedEventHandler = this.r;
				num = (short)1011744770;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060003CE RID: 974 RVA: 0x00038D80 File Offset: 0x00036F80
		// (remove) Token: 0x060003CF RID: 975 RVA: 0x00038EC0 File Offset: 0x000370C0
		public event global::System.ComponentModel.PropertyChangedEventHandler SelectedProductIdentifierPropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)661344159;
					short num2 = num;
					num = (short)628641695;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)2093940736;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
						{
							num = (short)25493504;
							short num4 = num;
							num = (short)427425793;
							if (num != 0)
							{
							}
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1700462593;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_85;
						}
						case 1:
							return;
						case 2:
							goto IL_85;
						}
						goto IL_68;
						IL_85:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.s, value2, propertyChangedEventHandler2);
						num = (short)128319488;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_68:
				propertyChangedEventHandler = this.s;
				num = (short)573112322;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1773142017;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_31:
					num = (short)448437381;
					short num2 = num;
					num = (short)852991109;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)315817984;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1094057985;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AC;
						case 1:
							return;
						case 2:
							goto IL_AC;
						}
						goto IL_8E;
						IL_AC:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.s, value2, propertyChangedEventHandler2);
						num = (short)4784128;
						short num4 = num;
						num = (short)190775296;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_8E:
				propertyChangedEventHandler = this.s;
				num = (short)1273954306;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060003D0 RID: 976 RVA: 0x00038FF8 File Offset: 0x000371F8
		// (remove) Token: 0x060003D1 RID: 977 RVA: 0x0003912C File Offset: 0x0003732C
		public event global::System.ComponentModel.PropertyChangedEventHandler SelectedModelNumberPropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1628045313;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_31:
					num = (short)126811385;
					short num2 = num;
					num = (short)1028259065;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)156303360;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1546059777;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AC;
						case 1:
							return;
						case 2:
							goto IL_AC;
						}
						goto IL_8F;
						IL_AC:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.t, value2, propertyChangedEventHandler2);
						num = (short)2135097344;
						short num4 = num;
						num = (short)164954112;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_8F:
				propertyChangedEventHandler = this.t;
				num = (short)1542782978;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)2108851617;
					short num2 = num;
					num = (short)1670808993;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1159069696;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1719730177;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_83;
						case 1:
							return;
						case 2:
							goto IL_83;
						}
						goto IL_66;
						IL_83:
						num = (short)2090663937;
						if (num != 0)
						{
						}
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.t, value2, propertyChangedEventHandler2);
						num = (short)1786314752;
						short num4 = num;
						num = (short)1585774592;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_66:
				propertyChangedEventHandler = this.t;
				num = (short)1551237122;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060003D2 RID: 978 RVA: 0x00039264 File Offset: 0x00037464
		// (remove) Token: 0x060003D3 RID: 979 RVA: 0x000393A0 File Offset: 0x000375A0
		public event global::System.ComponentModel.PropertyChangedEventHandler FlashCodePropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)603946927;
					short num2 = num;
					num = (short)1785823151;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1367670784;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
						{
							num = (short)1291452416;
							short num4 = num;
							num = (short)494665729;
							if (num != 0)
							{
							}
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1441792001;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_87;
						}
						case 1:
							return;
						case 2:
							goto IL_87;
						}
						goto IL_68;
						IL_87:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.u, value2, propertyChangedEventHandler2);
						num = (short)1855062016;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_68:
				propertyChangedEventHandler = this.u;
				num = (short)316407810;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)90478065;
					short num2 = num;
					num = (short)1362990577;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)296419328;
						if (num != 0)
						{
						}
						num = (short)922943489;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1013055489;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AF;
						case 1:
							return;
						case 2:
							goto IL_AF;
						}
						goto IL_8E;
						IL_AF:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.u, value2, propertyChangedEventHandler2);
						num = (short)597688320;
						short num4 = num;
						num = (short)559087616;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_8E:
				propertyChangedEventHandler = this.u;
				num = (short)1394343938;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000394D8 File Offset: 0x000376D8
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00039588 File Offset: 0x00037788
		public int CurrentMode
		{
			get
			{
				short num = (short)1855267911;
				short num2 = num;
				num = (short)668607559;
				switch (num2 == num)
				{
				}
				num = (short)77398016;
				short num3 = num;
				num = (short)262602753;
				if (num != 0)
				{
				}
				num = (short)316407808;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)489226242;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (!base.IsLoading)
						{
							num = (short)312541187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_CurrentMode())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1993867264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						this.a = value;
						num = (short)560005120;
						short num3 = num;
						num = (short)1314859289;
						short num4 = num;
						num = (short)852699417;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1363935232;
							if (num != 0)
							{
							}
							num = (short)1448017921;
							if (num != 0)
							{
							}
							num = (short)1040973825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_38:
					if (value == this.a)
					{
						break;
					}
					num = (short)465895428;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00039724 File Offset: 0x00037924
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000397D4 File Offset: 0x000379D4
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily> AvailableProductFamily
		{
			get
			{
				short num = (short)25190764;
				short num2 = num;
				num = (short)1633182060;
				switch (num2 == num)
				{
				}
				num = (short)1783496704;
				short num3 = num;
				num = (short)53936129;
				if (num != 0)
				{
				}
				num = (short)318636032;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)180944897;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							this.e = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_AvailableProductFamily())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)395051010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_31;
							}
							continue;
						case 2:
							return;
						}
						IL_31:
						num = (short)1494402510;
						short num3 = num;
						num = (short)784123342;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1365835776;
							if (num != 0)
							{
							}
							num = (short)108396545;
							if (num != 0)
							{
							}
							num = (short)2063073280;
							short num4 = num;
							if (value == this.e)
							{
								return;
							}
							num = (short)1214709760;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00039928 File Offset: 0x00037B28
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x000399D8 File Offset: 0x00037BD8
		public global::System.Collections.ObjectModel.ObservableCollection<string> AvailableVersions
		{
			get
			{
				short num = (short)196819909;
				short num2 = num;
				num = (short)645610437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1575026688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1514012673;
				if (num != 0)
				{
				}
				num = (short)1436483584;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num;
				for (;;)
				{
					IL_00:
					num = (short)1471807489;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							this.f = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<string>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<string>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_AvailableVersions())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1073741826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 2:
							goto IL_11E;
						}
						IL_30:
						num = (short)1436786874;
						short num3 = num;
						num = (short)246259898;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)493682688;
							if (num != 0)
							{
							}
							if (value == this.f)
							{
								return;
							}
							num = (short)44630016;
							short num4 = num;
							num = (short)1885143040;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
				IL_11E:
				num = (short)1015742465;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00039B2C File Offset: 0x00037D2C
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00039BE0 File Offset: 0x00037DE0
		public global::System.Collections.ObjectModel.ObservableCollection<string> AvailableProductIdentifiers
		{
			get
			{
				short num = (short)1404698625;
				if (num != 0)
				{
				}
				num = (short)2015363072;
				short num2 = num;
				num = (short)1184766758;
				short num3 = num;
				num = (short)163060518;
				switch (num3 == num)
				{
				}
				num = (short)13959168;
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
					short num = (short)786433;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							this.g = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<string>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<string>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_AvailableProductIdentifiers())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1034813442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1399717889;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_5A;
							}
							continue;
						case 2:
							return;
						}
						IL_5A:
						num = (short)1696165654;
						short num3 = num;
						num = (short)764899094;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)398524416;
							if (num != 0)
							{
							}
							num = (short)1532624896;
							short num4 = num;
							if (value == this.g)
							{
								return;
							}
							num = (short)1133314048;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00039D34 File Offset: 0x00037F34
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00039DE0 File Offset: 0x00037FE0
		public global::System.Collections.ObjectModel.ObservableCollection<string> AvailableModelNumbers
		{
			get
			{
				short num = (short)1608403852;
				short num2 = num;
				num = (short)1464945548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2077753344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981073920;
				if (num != 0)
				{
				}
				num = (short)1420230657;
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
					short num = (short)828571649;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							this.h = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<string>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<string>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_AvailableModelNumbers())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1695875074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 2:
							return;
						}
						IL_30:
						num = (short)2146493330;
						short num3 = num;
						num = (short)350413714;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1193476097;
							if (num != 0)
							{
							}
							num = (short)1179189248;
							if (num != 0)
							{
							}
							num = (short)738197504;
							short num4 = num;
							if (value == this.h)
							{
								return;
							}
							num = (short)638976000;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00039F30 File Offset: 0x00038130
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00039FE0 File Offset: 0x000381E0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> AvailableOptions
		{
			get
			{
				short num = (short)237414061;
				short num2 = num;
				num = (short)2052368045;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1759510528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)699072513;
				if (num != 0)
				{
				}
				num = (short)933101568;
				if (num != 0)
				{
				}
				return this.n;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)748027905;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1148715009;
							if (num != 0)
							{
							}
							this.n = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_AvailableOptions())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)456916994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_31;
							}
							continue;
						case 2:
							return;
						}
						IL_31:
						num = (short)2021176941;
						short num3 = num;
						num = (short)1976546925;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)942014464;
							if (num != 0)
							{
							}
							if (value == this.n)
							{
								return;
							}
							num = (short)1150877696;
							short num4 = num;
							num = (short)482541568;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0003A134 File Offset: 0x00038334
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0003A1E4 File Offset: 0x000383E4
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily SelectedProductFamily
		{
			get
			{
				short num = (short)707385442;
				short num2 = num;
				num = (short)1716050018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2074542080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)295763968;
				if (num != 0)
				{
				}
				num = (short)605093889;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				int a_ = 8;
				short num = (short)596967427;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.i = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_SelectedProductFamily())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)39387137;
						if (num != 0)
						{
						}
						num = (short)99745796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)932773888;
						short num3 = num;
						num = (short)709231173;
						short num4 = num;
						num = (short)737083973;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)363200512;
							if (num != 0)
							{
							}
							this.q(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("၂⁄⭆ⱈ⡊㥌⩎㕐͒❔㡖㵘⹚㹜⭞❠ɢࡤ๦ըቪ", a_)));
							num = (short)1400504321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 4:
						if (this.q != null)
						{
							num = (short)177143810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_41:
					if (value == this.i)
					{
						break;
					}
					num = (short)1835139072;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0003A3A8 File Offset: 0x000385A8
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x0003A484 File Offset: 0x00038684
		public string SelectedVersion
		{
			get
			{
				if (this.AvailableVersions.Count <= 0)
				{
					short num = (short)649799600;
					short num2 = num;
					num = (short)276309936;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B5;
					case 1:
						break;
					default:
					{
						num = (short)228524032;
						short num3 = num;
						break;
					}
					}
					num = (short)1574174720;
					if (num != 0)
					{
					}
					num = (short)716439553;
					if (num != 0)
					{
					}
					return string.Empty;
				}
				IL_B5:
				return this.AvailableVersions[this.AvailableVersions.Count - 1];
			}
			set
			{
				int a_ = 5;
				short num = (short)1809645571;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.j = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_SelectedVersion())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)557252612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)263520256;
						short num3 = num;
						num = (short)971722320;
						short num4 = num;
						num = (short)725241424;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1792212992;
							if (num != 0)
							{
							}
							this.r(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ጿ❁⡃⍅⭇㹉⥋⩍ُ㝑♓╕ㅗ㕙㉛", a_)));
							num = (short)405602305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_43;
						}
						continue;
					case 4:
						num = (short)561446913;
						if (num != 0)
						{
						}
						if (this.r != null)
						{
							num = (short)1329004546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_43:
					if (!(value != this.j))
					{
						break;
					}
					num = (short)88342528;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0003A650 File Offset: 0x00038850
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x0003A700 File Offset: 0x00038900
		public string SelectedProductIdentifier
		{
			get
			{
				short num = (short)664929888;
				short num2 = num;
				num = (short)16385632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)666501120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)138936320;
				if (num != 0)
				{
				}
				num = (short)1345781761;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				int a_ = 4;
				short num = (short)764477443;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)2123890689;
						if (num != 0)
						{
						}
						this.k = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_SelectedProductIdentifier())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)439222276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)2074673152;
						short num3 = num;
						num = (short)556746117;
						short num4 = num;
						num = (short)47531397;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)495714304;
							if (num != 0)
							{
							}
							this.s(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("氾⑀⽂⁄⑆㵈⹊⥌὎⍐㱒ㅔ≖㩘⽚ᑜ㭞Ѡൢᅤ๦ཨɪ࡬ᵮ", a_)));
							num = (short)1270022145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_43;
						}
						continue;
					case 4:
						if (this.s != null)
						{
							num = (short)435159042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_43:
					if (!(value != this.k))
					{
						break;
					}
					num = (short)184745984;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0003A8C8 File Offset: 0x00038AC8
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0003A974 File Offset: 0x00038B74
		public string SelectedModelNumber
		{
			get
			{
				short num = (short)1298400530;
				short num2 = num;
				num = (short)313984274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508493824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1075970048;
				if (num != 0)
				{
				}
				num = (short)940507137;
				if (num != 0)
				{
				}
				return this.l;
			}
			set
			{
				int a_ = 17;
				short num = (short)438370307;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.l = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_SelectedModelNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1664352260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)1774125057;
						if (num != 0)
						{
						}
						num = (short)1640169472;
						short num3 = num;
						num = (short)1462719521;
						short num4 = num;
						num = (short)518345761;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)932708352;
							if (num != 0)
							{
							}
							this.t(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ὃ⭍㱏㝑㝓≕㵗㹙ᅛㅝџݡࡣ⡥ᵧݩ๫୭ɯ", a_)));
							num = (short)357892097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_42;
						}
						continue;
					case 4:
						if (this.t != null)
						{
							num = (short)171245570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_42:
					if (!(value != this.l))
					{
						break;
					}
					num = (short)1616314368;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0003AB3C File Offset: 0x00038D3C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> SelectedOptions
		{
			get
			{
				short num = (short)1373372416;
				switch (num)
				{
				default:
				{
					num = (short)1712259072;
					short num2 = num;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Option>();
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> enumerator = this.n.GetEnumerator();
					try
					{
						num = (short)80871427;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_C6;
							case 1:
							{
								if (enumerator.MoveNext())
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Option option = enumerator.Current;
									list.Add(option);
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> enumerator2 = option.ChildrenOptions.GetEnumerator();
									num = (short)150536192;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1138714539;
								short num4 = num;
								num = (short)390162347;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_C6;
								default:
									num = (short)1217789952;
									if (num != 0)
									{
									}
									num = (short)1604386820;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_291;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_95;
								}
								continue;
							case 4:
								goto IL_278;
							}
							IL_CB:
							num = (short)211484673;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_C6:
							try
							{
								num = (short)1219035139;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1718943745;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.Option item = enumerator2.Current;
										list.Add(item);
										num = (short)2081554436;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)1639055362;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_207;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_18F;
										}
										continue;
									}
									IL_191:
									num = (short)2146697216;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_18F:
									goto IL_191;
								}
								IL_207:
								goto IL_CB;
							}
							finally
							{
								num = (short)1595277313;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1856962562;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_23F;
										}
										continue;
									case 2:
										goto IL_275;
									}
									IL_23F:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1174339584;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_275:;
							}
							goto IL_278;
							IL_95:
							goto IL_CB;
							IL_278:
							num = (short)1587937282;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_291:;
					}
					finally
					{
						num = (short)1548091393;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1075314690;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2C5;
								}
								continue;
							case 2:
								goto IL_2FC;
							}
							IL_2C5:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2044985344;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2FC:;
					}
					num = (short)1518206977;
					if (num != 0)
					{
					}
					return list;
				}
				}
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0003AEA8 File Offset: 0x000390A8
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x0003AF58 File Offset: 0x00039158
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName> RegionList
		{
			get
			{
				short num = (short)1121197388;
				short num2 = num;
				num = (short)1837964620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)289996800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)101253120;
				if (num != 0)
				{
				}
				num = (short)2044264449;
				if (num != 0)
				{
				}
				return this.o;
			}
			set
			{
				short num;
				for (;;)
				{
					IL_00:
					num = (short)1025114113;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							this.o = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_RegionList())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)2056847362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 2:
							goto IL_11A;
						}
						IL_30:
						num = (short)346777524;
						short num3 = num;
						num = (short)377579444;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1543766016;
							if (num != 0)
							{
							}
							if (value == this.o)
							{
								return;
							}
							num = (short)1670578176;
							short num4 = num;
							num = (short)144310272;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
				IL_11A:
				num = (short)276234241;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0003B0A8 File Offset: 0x000392A8
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x0003B15C File Offset: 0x0003935C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName SelectedRegion
		{
			get
			{
				short num = (short)1128258180;
				short num2 = num;
				num = (short)384359044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)260308992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)543358977;
				if (num != 0)
				{
				}
				num = (short)1770520576;
				if (num != 0)
				{
				}
				return this.p;
			}
			set
			{
				short num = (short)1322319875;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.p = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_SelectedRegion())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1030488068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)1031405569;
						if (num != 0)
						{
						}
						num = (short)128319488;
						short num3 = num;
						num = (short)2057531217;
						short num4 = num;
						num = (short)1261137745;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1541931008;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastRegionForNewRadio = this.p.ToString();
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)1902772225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 4:
						if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastRegionForNewRadio != this.p.ToString())
						{
							num = (short)1775304706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_38:
					if (value == this.p)
					{
						break;
					}
					num = (short)1364787200;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0003B338 File Offset: 0x00039538
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x0003B3E8 File Offset: 0x000395E8
		public string FlashCode
		{
			get
			{
				short num = (short)1101569633;
				short num2 = num;
				num = (short)1999216225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1068367872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1187708929;
				if (num != 0)
				{
				}
				num = (short)1158610944;
				if (num != 0)
				{
				}
				return this.m;
			}
			set
			{
				int a_ = 9;
				short num = (short)112001027;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.m = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_FlashCode())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2109014020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)1482358784;
						short num3 = num;
						num = (short)1600158310;
						short num4 = num;
						num = (short)1253341798;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)439877632;
							if (num != 0)
							{
							}
							this.u(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ƀ⩅⥇㥉⑋്㽏㙑ㅓ", a_)));
							num = (short)242417665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						num = (short)240320513;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_67;
						}
						continue;
					case 4:
						if (this.u != null)
						{
							num = (short)1446248450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_67:
					if (!(value != this.m))
					{
						break;
					}
					num = (short)626130944;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0003B5AC File Offset: 0x000397AC
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0003B65C File Offset: 0x0003985C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> RadiosToApplyMVO
		{
			get
			{
				short num = (short)2002583553;
				if (num != 0)
				{
				}
				num = (short)430899200;
				short num2 = num;
				num = (short)314383507;
				short num3 = num;
				num = (short)297016467;
				switch (num3 == num)
				{
				}
				num = (short)1423376384;
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
					num = (short)344522753;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)811401217;
							if (num != 0)
							{
							}
							this.b = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_RadiosToApplyMVO())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)891682818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 2:
							goto IL_115;
						}
						IL_30:
						num = (short)217316526;
						short num3 = num;
						num = (short)1103166638;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1841102848;
							if (num != 0)
							{
							}
							if (value == this.b)
							{
								goto IL_117;
							}
							num = (short)1347092480;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
				IL_115:
				IL_117:
				num = (short)2122645504;
				short num4 = num;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0003B7A8 File Offset: 0x000399A8
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x0003B858 File Offset: 0x00039A58
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> RadiosHaveMVO
		{
			get
			{
				short num = (short)1018691585;
				if (num != 0)
				{
				}
				num = (short)486733352;
				short num2 = num;
				num = (short)383252008;
				switch (num2 == num)
				{
				}
				num = (short)665583616;
				if (num != 0)
				{
				}
				num = (short)901054464;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)2106982402;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11E;
					case 1:
						this.c = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_RadiosHaveMVO())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)108134400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					}
					IL_32:
					if (value == this.c)
					{
						break;
					}
					num = (short)1856042957;
					short num3 = num;
					num = (short)2136995789;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_120;
					default:
						num = (short)1924988929;
						if (num != 0)
						{
						}
						num = (short)1046544384;
						if (num != 0)
						{
						}
						num = (short)1510080513;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_11E:
				IL_120:
				num = (short)584056832;
				short num4 = num;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0003B9B0 File Offset: 0x00039BB0
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0003BA64 File Offset: 0x00039C64
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase SelectedMVORadio
		{
			get
			{
				short num = (short)845938689;
				if (num != 0)
				{
				}
				num = (short)961785953;
				short num2 = num;
				num = (short)1110618209;
				switch (num2 == num)
				{
				}
				num = (short)1899233280;
				if (num != 0)
				{
				}
				num = (short)922877952;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)707395586;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11B;
					case 1:
						this.d = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectMVOContext.get_SelectedMVORadio())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1564934144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (value == this.d)
					{
						break;
					}
					num = (short)734855169;
					if (num != 0)
					{
					}
					num = (short)211504581;
					short num3 = num;
					num = (short)1050168773;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11D;
					default:
						num = (short)1642135552;
						if (num != 0)
						{
						}
						num = (short)2020343809;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_11B:
				IL_11D:
				num = (short)374145024;
				short num4 = num;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0003BBB8 File Offset: 0x00039DB8
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0003BC68 File Offset: 0x00039E68
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> AppOption
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1471331735;
				short num2 = num;
				num = (short)1085259159;
				switch (num2 == num)
				{
				}
				num = (short)622460929;
				if (num != 0)
				{
				}
				num = (short)1138753536;
				if (num != 0)
				{
				}
				num = (short)1282146304;
				short num3 = num;
				return this.v;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1736684077;
				short num2 = num;
				num = (short)1015067181;
				switch (num2 == num)
				{
				}
				num = (short)1116995584;
				if (num != 0)
				{
				}
				num = (short)1547042817;
				if (num != 0)
				{
				}
				num = (short)478019584;
				short num3 = num;
				this.v = value;
			}
		}

		// Token: 0x040001C4 RID: 452
		public const int MVOMODE = 1;

		// Token: 0x040001C5 RID: 453
		public const int RADIOMODE = 0;

		// Token: 0x040001C6 RID: 454
		private int a;

		// Token: 0x040001C7 RID: 455
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> b = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();

		// Token: 0x040001C8 RID: 456
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> c = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();

		// Token: 0x040001C9 RID: 457
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d;

		// Token: 0x040001CA RID: 458
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily> e = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily>();

		// Token: 0x040001CB RID: 459
		private global::System.Collections.ObjectModel.ObservableCollection<string> f = new global::System.Collections.ObjectModel.ObservableCollection<string>();

		// Token: 0x040001CC RID: 460
		private global::System.Collections.ObjectModel.ObservableCollection<string> g = new global::System.Collections.ObjectModel.ObservableCollection<string>();

		// Token: 0x040001CD RID: 461
		private global::System.Collections.ObjectModel.ObservableCollection<string> h = new global::System.Collections.ObjectModel.ObservableCollection<string>();

		// Token: 0x040001CE RID: 462
		private global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily i;

		// Token: 0x040001CF RID: 463
		private string j;

		// Token: 0x040001D0 RID: 464
		private string k;

		// Token: 0x040001D1 RID: 465
		private string l;

		// Token: 0x040001D2 RID: 466
		private string m;

		// Token: 0x040001D3 RID: 467
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> n = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option>();

		// Token: 0x040001D4 RID: 468
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName> o;

		// Token: 0x040001D5 RID: 469
		private global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName p;

		// Token: 0x040001D6 RID: 470
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler q;

		// Token: 0x040001D7 RID: 471
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler r;

		// Token: 0x040001D8 RID: 472
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler s;

		// Token: 0x040001D9 RID: 473
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler t;

		// Token: 0x040001DA RID: 474
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler u;

		// Token: 0x040001DB RID: 475
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> v;
	}
}
