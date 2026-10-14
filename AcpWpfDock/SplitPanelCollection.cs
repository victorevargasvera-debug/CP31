using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DevComponents.WpfDock
{
	// Token: 0x0200003E RID: 62
	public class SplitPanelCollection : global::System.Collections.ObjectModel.ObservableCollection<global::DevComponents.WpfDock.SplitPanel>
	{
		// Token: 0x060002CE RID: 718 RVA: 0x0004956C File Offset: 0x0004776C
		public SplitPanelCollection()
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00049580 File Offset: 0x00047780
		public SplitPanelCollection(global::DevComponents.WpfDock.DockSite parent)
		{
			this.a = parent;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0004959C File Offset: 0x0004779C
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1448214528;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)591527937;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_44B;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 2:
						if (e.NewItems != null)
						{
							num = (short)72941568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_266;
					case 3:
						num = (short)1851588609;
						if (num != 0)
						{
						}
						try
						{
							num = (short)755387171;
							short num3 = num;
							num = (short)2024229667;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_386;
							default:
								num = (short)1261961216;
								if (num != 0)
								{
								}
								num = (short)26345474;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								IL_33A:
								switch (num2)
								{
								case 0:
									num = (short)777060353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3D4;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_355;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)458424320;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.SplitPanel a_ = (global::DevComponents.WpfDock.SplitPanel)enumerator.Current;
									this.a.c(a_);
									num = (short)241631236;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							IL_355:
							goto IL_386;
							IL_3D4:
							goto IL_266;
							IL_386:
							num = (short)997457923;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_33A;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_3F6;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_3E3:
								switch (num2)
								{
								case 0:
									goto IL_448;
								case 1:
									disposable.Dispose();
									num = (short)923729920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)1883570177;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_44A;
								}
								goto IL_3F6;
							}
							IL_448:
							IL_44A:
							goto EndFinally_14;
							IL_3F6:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)2019819522;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3E3;
							EndFinally_14:;
						}
						goto IL_44B;
					case 4:
						enumerator = e.OldItems.GetEnumerator();
						num = (short)315883529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1287913472;
						short num4 = num;
						if (e.OldItems != null)
						{
							num = (short)96468996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49C;
					}
					case 6:
						goto IL_B2;
					case 7:
						goto IL_224;
					case 8:
						if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
						{
							num = (short)2037186566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49C;
					case 9:
						try
						{
							num = (short)708247554;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_1AD;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_12D;
									}
									continue;
								case 3:
									num = (short)964952065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)209518595;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.SplitPanel a_2 = (global::DevComponents.WpfDock.SplitPanel)enumerator.Current;
									this.a.d(a_2);
									num = (short)1219493888;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_12F:
								num = (short)1031864324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12D:
								goto IL_12F;
							}
							IL_1AD:
							goto IL_49C;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1CF;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1BC:
								switch (num2)
								{
								case 0:
									goto IL_221;
								case 1:
									disposable.Dispose();
									num = (short)1973551104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)115212289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_223;
								}
								goto IL_1CF;
							}
							IL_221:
							IL_223:
							goto EndFinally_13;
							IL_1CF:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)2066612226;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1BC;
							EndFinally_13:;
						}
						goto IL_224;
					}
					IL_6D:
					if (e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						num = (short)713097223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B2:
					num = (short)98697218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_224:
					num = (short)1565589512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_266:
					num = (short)312082437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44B:
					enumerator = e.NewItems.GetEnumerator();
					num = (short)174915587;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_49C:
				base.OnCollectionChanged(e);
				return;
			}
		}

		// Token: 0x040001A9 RID: 425
		private global::DevComponents.WpfDock.DockSite a;
	}
}
