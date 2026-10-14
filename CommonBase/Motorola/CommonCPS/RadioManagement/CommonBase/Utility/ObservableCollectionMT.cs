using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Threading;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x02000016 RID: 22
	public class ObservableCollectionMT<T> : global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<T>
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600006F RID: 111 RVA: 0x00009ED8 File Offset: 0x000080D8
		// (remove) Token: 0x06000070 RID: 112 RVA: 0x0000A010 File Offset: 0x00008210
		public override event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)2051670017;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				int num2;
				global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler;
				for (;;)
				{
					IL_32:
					global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
					switch (num2)
					{
					case 0:
						goto IL_D8;
					case 1:
						if (notifyCollectionChangedEventHandler == notifyCollectionChangedEventHandler2)
						{
							num = (short)2121138178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D8;
					case 2:
						return;
					}
					goto IL_44;
					IL_D8:
					notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
					global::System.Collections.Specialized.NotifyCollectionChangedEventHandler value2 = (global::System.Collections.Specialized.NotifyCollectionChangedEventHandler)global::System.Delegate.Combine(notifyCollectionChangedEventHandler2, value);
					notifyCollectionChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.Collections.Specialized.NotifyCollectionChangedEventHandler>(ref this.a, value2, notifyCollectionChangedEventHandler2);
					num = (short)575340545;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_44:
				notifyCollectionChangedEventHandler = this.a;
				num = (short)245542708;
				short num3 = num;
				num = (short)863416116;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_32;
				case 1:
					break;
				default:
				{
					num = (short)1327628288;
					short num4 = num;
					break;
				}
				}
				num = (short)744423424;
				if (num != 0)
				{
				}
				num = (short)1009254400;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_B2;
					case 1:
						if (notifyCollectionChangedEventHandler == notifyCollectionChangedEventHandler2)
						{
							num2 = (short)1234698242;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B2;
					case 2:
						return;
					}
					goto IL_1C;
					IL_B2:
					num2 = (short)1166344193;
					if (num2 != 0)
					{
					}
					notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
					global::System.Collections.Specialized.NotifyCollectionChangedEventHandler value2 = (global::System.Collections.Specialized.NotifyCollectionChangedEventHandler)global::System.Delegate.Remove(notifyCollectionChangedEventHandler2, value);
					notifyCollectionChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.Collections.Specialized.NotifyCollectionChangedEventHandler>(ref this.a, value2, notifyCollectionChangedEventHandler2);
					num2 = (short)789446657;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				notifyCollectionChangedEventHandler = this.a;
				num2 = (short)1843300659;
				short num3 = num2;
				num2 = (short)504531251;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0A;
				default:
				{
					num2 = (short)697434112;
					short num4 = num2;
					num2 = (short)509149184;
					if (num2 != 0)
					{
					}
					num2 = (short)739639296;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000A14C File Offset: 0x0000834C
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)2049909131;
			short num2 = num;
			num = (short)2114462091;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)275906560;
				short num3 = num;
				num = (short)630325248;
				if (num != 0)
				{
				}
				num = (short)416743424;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			global::System.IDisposable disposable = base.BlockReentrancy();
			try
			{
				switch (0)
				{
				case 0:
					goto IL_E1;
				}
				int num4;
				global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
				for (;;)
				{
					IL_A6:
					int num5;
					global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler;
					switch (num4)
					{
					case 0:
					{
						global::System.Windows.Threading.DispatcherObject dispatcherObject;
						if (!dispatcherObject.CheckAccess())
						{
							num = (short)1655898124;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AC;
					}
					case 1:
					{
						global::System.Delegate[] invocationList;
						if (num5 >= invocationList.Length)
						{
							num = (short)1392771080;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						notifyCollectionChangedEventHandler = (global::System.Collections.Specialized.NotifyCollectionChangedEventHandler)invocationList[num5];
						global::System.Windows.Threading.DispatcherObject dispatcherObject = notifyCollectionChangedEventHandler.Target as global::System.Windows.Threading.DispatcherObject;
						num = (short)1015873539;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1D0;
					case 3:
					{
						global::System.Windows.Threading.DispatcherObject dispatcherObject;
						if (dispatcherObject != null)
						{
							num = (short)8454154;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AC;
					}
					case 4:
						goto IL_1D0;
					case 5:
						goto IL_16B;
					case 6:
						goto IL_16B;
					case 7:
						if (notifyCollectionChangedEventHandler2 != null)
						{
							num = (short)1092222985;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_284;
					case 8:
						goto IL_284;
					case 9:
					{
						global::System.Delegate[] invocationList = notifyCollectionChangedEventHandler2.GetInvocationList();
						num5 = 0;
						num = (short)343343106;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)773914624;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_29C;
					case 12:
					{
						global::System.Windows.Threading.DispatcherObject dispatcherObject;
						dispatcherObject.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.SystemIdle, notifyCollectionChangedEventHandler, this, new object[]
						{
							e
						});
						num = (short)1511522309;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_E1;
					IL_16B:
					num5++;
					num = (short)2021588996;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AC:
					notifyCollectionChangedEventHandler(this, e);
					num = (short)1094778886;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D0:
					num = (short)914227201;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_284:
					num = (short)1426063371;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_29C:
				return;
				IL_E1:
				notifyCollectionChangedEventHandler2 = this.a;
				num = (short)1234305031;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_A6;
			}
			finally
			{
				num = (short)1484193792;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1902903297;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_2FB;
						}
						continue;
					case 1:
						disposable.Dispose();
						num = (short)550043650;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_331;
					}
					IL_2FB:
					if (disposable == null)
					{
						break;
					}
					num = (short)1513029633;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_331:;
			}
		}

		// Token: 0x04000038 RID: 56
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler a;
	}
}
