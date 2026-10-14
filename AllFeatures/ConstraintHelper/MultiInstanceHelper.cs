using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using AllFeatures;

namespace ConstraintHelper
{
	// Token: 0x020005FB RID: 1531
	public class MultiInstanceHelper : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600D0FC RID: 53500 RVA: 0x00C3C888 File Offset: 0x00C3AA88
		internal MultiInstanceHelper()
		{
		}

		// Token: 0x170068CA RID: 26826
		// (get) Token: 0x0600D0FD RID: 53501 RVA: 0x00C3C89C File Offset: 0x00C3AA9C
		// (set) Token: 0x0600D0FE RID: 53502 RVA: 0x00C3C94C File Offset: 0x00C3AB4C
		public int ParentRecsetPosition
		{
			get
			{
				short num = (short)282893480;
				short num2 = num;
				num = (short)921541800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)165609472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1725956096;
				if (num != 0)
				{
				}
				num = (short)502333441;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.AppMultiInstanceManager.ParentRecsetPosition;
			}
			internal set
			{
				int a_ = 15;
				short num = (short)1170540044;
				short num2 = num;
				num = (short)189335052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)401735680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)597164032;
				if (num != 0)
				{
				}
				num = (short)1282211841;
				if (num != 0)
				{
				}
				this.FirePropertyChanged(global::AllFeatures.CodeplugGuid.b("胏돑ꛓ돕뛗껙軛믝菟釡臣鋥룧藩鿫蟭蓯鯱鯳飵", a_));
			}
		}

		// Token: 0x170068CB RID: 26827
		// (get) Token: 0x0600D0FF RID: 53503 RVA: 0x00C3CA14 File Offset: 0x00C3AC14
		// (set) Token: 0x0600D100 RID: 53504 RVA: 0x00C3CAC0 File Offset: 0x00C3ACC0
		public bool IsDynamicZoneChanged
		{
			get
			{
				short num = (short)905052161;
				if (num != 0)
				{
				}
				num = (short)653393920;
				short num2 = num;
				num = (short)650018991;
				short num3 = num;
				num = (short)1410105519;
				switch (num3 == num)
				{
				}
				num = (short)1294794752;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.AppMultiInstanceManager.IsDynamicZoneChanged;
			}
			internal set
			{
				int a_ = 4;
				short num = (short)1889320003;
				short num2 = num;
				num = (short)734444611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379663872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)8978432;
				if (num != 0)
				{
				}
				num = (short)1184890881;
				if (num != 0)
				{
				}
				this.FirePropertyChanged(global::AllFeatures.CodeplugGuid.b("賄듆跈닊ꏌ껎볐뫒뛔跖뛘뗚룜鳞觠苢诤胦賨迪", a_));
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600D101 RID: 53505 RVA: 0x00C3CB88 File Offset: 0x00C3AD88
		// (remove) Token: 0x0600D102 RID: 53506 RVA: 0x00C3CCC0 File Offset: 0x00C3AEC0
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				int num;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_39;
						case 1:
						{
							global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num2 = (short)1100021762;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_39;
						}
						case 2:
							goto IL_101;
						}
						goto IL_1C;
						IL_39:
						num2 = (short)402228433;
						short num3 = num2;
						num2 = (short)1933935825;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23;
						default:
						{
							num2 = (short)643366912;
							if (num2 != 0)
							{
							}
							global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
							global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
							propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.a, value2, propertyChangedEventHandler2);
							num2 = (short)568066048;
							short num4 = num2;
							num2 = (short)210698241;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						}
					}
					IL_101:
					num2 = (short)1086521345;
					if (num2 != 0)
					{
					}
					return;
				}
				IL_1C:
				propertyChangedEventHandler = this.a;
				IL_23:
				num2 = (short)1994194944;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				int num;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_5F;
						case 1:
						{
							global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num2 = (short)530251778;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_5F;
						}
						case 2:
							return;
						}
						goto IL_1C;
						IL_5F:
						num2 = (short)1124539197;
						short num3 = num2;
						num2 = (short)1470765885;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_49;
						default:
						{
							num2 = (short)930873344;
							if (num2 != 0)
							{
							}
							num2 = (short)2011168768;
							short num4 = num2;
							global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
							global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
							propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.a, value2, propertyChangedEventHandler2);
							num2 = (short)144834561;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						}
					}
					return;
				}
				IL_1C:
				num2 = (short)1797128193;
				if (num2 != 0)
				{
				}
				propertyChangedEventHandler = this.a;
				IL_49:
				num2 = (short)1651965952;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600D103 RID: 53507 RVA: 0x00C3CDF8 File Offset: 0x00C3AFF8
		public void FirePropertyChanged(string name)
		{
			int num;
			global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (propertyChangedEventHandler == null)
						{
							return;
						}
						num2 = (short)1472504238;
						short num3 = num2;
						num2 = (short)349086126;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23;
						default:
							num2 = (short)1123483648;
							if (num2 != 0)
							{
							}
							num2 = (short)1251344385;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
					{
						num2 = (short)1662255104;
						short num4 = num2;
						propertyChangedEventHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
						num2 = (short)305332226;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						goto IL_F3;
					}
					goto IL_1C;
				}
				IL_F3:
				num2 = (short)421462017;
				if (num2 != 0)
				{
				}
				return;
			}
			IL_1C:
			propertyChangedEventHandler = this.a;
			IL_23:
			num2 = (short)2082537472;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040065E3 RID: 26083
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler a;
	}
}
