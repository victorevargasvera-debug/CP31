using System;
using System.Windows;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000078 RID: 120
	public class PushBindingManager
	{
		// Token: 0x060002B3 RID: 691 RVA: 0x0002C82C File Offset: 0x0002AA2C
		public static global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection GetPushBindings(global::System.Windows.DependencyObject obj)
		{
			short num = (short)923140096;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_11C;
				case 2:
					num = (short)810418177;
					if (num != 0)
					{
					}
					obj.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager.PushBindingsProperty, new global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection(obj));
					num = (short)52756481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)1978553517;
				short num3 = num;
				num = (short)217666733;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1427308544;
					short num4 = num;
					num = (short)1736179712;
					if (num != 0)
					{
					}
					if (obj.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager.PushBindingsProperty) != null)
					{
						goto IL_11E;
					}
					num = (short)1966931970;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_11C:
			IL_11E:
			return (global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection)obj.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager.PushBindingsProperty);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0002C968 File Offset: 0x0002AB68
		public static void SetPushBindings(global::System.Windows.DependencyObject obj, global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection value)
		{
			short num = (short)716374016;
			short num2 = num;
			num = (short)1289398771;
			short num3 = num;
			num = (short)295086579;
			switch (num3 == num)
			{
			}
			num = (short)672792576;
			if (num != 0)
			{
			}
			num = (short)854392833;
			if (num != 0)
			{
			}
			obj.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager.PushBindingsProperty, value);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0002CA20 File Offset: 0x0002AC20
		public static global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection GetStylePushBindings(global::System.Windows.DependencyObject obj)
		{
			short num = (short)116195328;
			short num2 = num;
			num = (short)1660813313;
			if (num != 0)
			{
			}
			num = (short)558399213;
			short num3 = num;
			num = (short)826048237;
			switch (num3 == num)
			{
			}
			num = (short)1670447104;
			if (num != 0)
			{
			}
			return (global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection)obj.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager.StylePushBindingsProperty);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0002CADC File Offset: 0x0002ACDC
		public static void SetStylePushBindings(global::System.Windows.DependencyObject obj, global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection value)
		{
			short num = (short)2077097984;
			short num2 = num;
			num = (short)311974556;
			short num3 = num;
			num = (short)853891740;
			switch (num3 == num)
			{
			}
			num = (short)837681153;
			if (num != 0)
			{
			}
			num = (short)1349844992;
			if (num != 0)
			{
			}
			obj.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager.StylePushBindingsProperty, value);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0002CB94 File Offset: 0x0002AD94
		public static void StylePushBindingsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)900661248;
			switch (num)
			{
			default:
			{
				num = (short)368836608;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.FreezableCollection<global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding>.Enumerator enumerator;
					global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection pushBindings;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					case 1:
						try
						{
							num = (short)2029977600;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_148;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)62324740;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding pushBinding = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding value = pushBinding.Clone() as global::Motorola.CommonCPS.RadioManagement.Controls.PushBinding;
									pushBindings.Add(value);
									num = (short)445513731;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1D0;
								case 4:
									num = (short)360644610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_14A:
								num = (short)1157496833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_148:
								goto IL_14A;
							}
							IL_1D0:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1E0;
					case 2:
						goto IL_1E0;
					}
					IL_50:
					num = (short)1421410305;
					if (num != 0)
					{
					}
					num = (short)1568669696;
					short num3 = num;
					num = (short)211302434;
					short num4 = num;
					num = (short)1863989282;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1579417600;
						if (num != 0)
						{
						}
						if (target != null)
						{
							num = (short)1628962818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_1E0:
					global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection pushBindingCollection = e.NewValue as global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection;
					pushBindings = global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager.GetPushBindings(target);
					enumerator = pushBindingCollection.GetEnumerator();
					num = (short)1051525121;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0002CDE0 File Offset: 0x0002AFE0
		// Note: this type is marked as 'beforefieldinit'.
		static PushBindingManager()
		{
			int a_ = 18;
			short num = (short)463863808;
			short num2 = num;
			num = (short)1311932746;
			short num3 = num;
			num = (short)110788938;
			switch (num3 == num)
			{
			}
			num = (short)1876819968;
			if (num != 0)
			{
			}
			num = (short)637599745;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager.PushBindingsProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("睊\ud9ab\uddad\ud8af\uddb3\ud8b5\udcb7펹튻\ud9bd뎿证꫃닅귇룉ꋋ꿍볏", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager), new global::System.Windows.UIPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager.StylePushBindingsProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("囹\ud8ab힭\udcafힱ쎵쮷특ﺻힽ꺿ꛁ귃ꣅ꿇막", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingCollection), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.PushBindingManager.StylePushBindingsChanged)));
		}

		// Token: 0x040000C0 RID: 192
		public static global::System.Windows.DependencyProperty PushBindingsProperty;

		// Token: 0x040000C1 RID: 193
		public static global::System.Windows.DependencyProperty StylePushBindingsProperty;
	}
}
