using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000077 RID: 119
	public class PushBindingCollection : global::System.Windows.FreezableCollection<global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding>
	{
		// Token: 0x060002AE RID: 686 RVA: 0x0002C428 File Offset: 0x0002A628
		public PushBindingCollection()
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0002C43C File Offset: 0x0002A63C
		public PushBindingCollection(global::System.Windows.DependencyObject targetObject)
		{
			this.TargetObject = targetObject;
			((global::System.Collections.Specialized.INotifyCollectionChanged)this).CollectionChanged += this.a;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0002C468 File Offset: 0x0002A668
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)806027264;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					try
					{
						num = (short)105644032;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_12E;
								}
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1397555204;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding pushBinding = (global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding)enumerator.Current;
								pushBinding.SetupTargetBinding(this.TargetObject);
								num = (short)1088880643;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_1AA;
							case 4:
								num = (short)884015106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_130:
							num = (short)664010753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_12E:
							goto IL_130;
						}
						IL_1AA:
						return;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1CB;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1B9:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)708575234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_220;
							case 1:
								goto IL_21E;
							case 2:
								disposable.Dispose();
								num = (short)282656769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CB;
						}
						IL_21E:
						IL_220:
						goto EndFinally_6;
						IL_1CB:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1842348032;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1B9;
						EndFinally_6:;
					}
					goto IL_221;
				case 2:
					num = (short)1460862977;
					if (num != 0)
					{
					}
					goto IL_221;
				}
				IL_31:
				num = (short)1390784148;
				short num3 = num;
				num = (short)676310676;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
				{
					num = (short)1659961344;
					short num4 = num;
					num = (short)531955712;
					if (num != 0)
					{
					}
					if (A_1.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						num = (short)1489240066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_221:
				enumerator = A_1.NewItems.GetEnumerator();
				num = (short)475398145;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0002C6D0 File Offset: 0x0002A8D0
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x0002C77C File Offset: 0x0002A97C
		public global::System.Windows.DependencyObject TargetObject
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1340211200;
				short num2 = num;
				num = (short)1054960445;
				short num3 = num;
				num = (short)693201725;
				switch (num3 == num)
				{
				}
				num = (short)1685454849;
				if (num != 0)
				{
				}
				num = (short)1693319168;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)279511040;
				short num2 = num;
				num = (short)1098892715;
				short num3 = num;
				num = (short)1186514347;
				switch (num3 == num)
				{
				}
				num = (short)676331520;
				if (num != 0)
				{
				}
				num = (short)577961985;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x040000BF RID: 191
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.DependencyObject a;
	}
}
