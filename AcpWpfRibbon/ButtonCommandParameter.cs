using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000011 RID: 17
	public class ButtonCommandParameter : global::System.Windows.DependencyObject, global::DevComponents.WpfRibbon.IButtonCommandParameter
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x00031434 File Offset: 0x0002F634
		static ButtonCommandParameter()
		{
			int a_ = 12;
			short num = (short)1146028778;
			short num2 = num;
			num = (short)411239146;
			switch (num2 == num)
			{
			}
			num = (short)190316544;
			short num3 = num;
			num = (short)225837057;
			if (num != 0)
			{
			}
			num = (short)1244004352;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ButtonCommandParameter.IsCheckedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⵣᕥ⭧ɩ५൭᭯᝱ၳ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonCommandParameter), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.ButtonCommandParameter.TagProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("っݥཧ", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.ButtonCommandParameter), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ButtonCommandParameter.ValueChangedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㉣ݥѧὩ५⵭ᡯ፱ᩳᅵᵷṹ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonCommandParameter), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00031598 File Offset: 0x0002F798
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0003173C File Offset: 0x0002F93C
		public bool IsChecked
		{
			get
			{
				short num;
				bool result;
				try
				{
					num = (short)1464664066;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_109;
						case 1:
						{
							result = (bool)base.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Windows.Threading.DispatcherOperationCallback(delegate(object <p0>)
							{
								short num5 = (short)190267788;
								short num6 = num5;
								num5 = (short)997933452;
								switch (num6 == num5)
								{
								}
								num5 = (short)88080384;
								short num7 = num5;
								num5 = (short)883097601;
								if (num5 != 0)
								{
								}
								num5 = (short)440598528;
								if (num5 != 0)
								{
								}
								return base.GetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.IsCheckedProperty);
							}), global::DevComponents.WpfRibbon.ButtonCommandParameter.IsCheckedProperty);
							num = (short)1283576389;
							short num3 = num;
							num = (short)1841484357;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_10B;
							default:
								num = (short)1806434304;
								if (num != 0)
								{
								}
								num = (short)1883308033;
								if (num != 0)
								{
								}
								num = (short)1335230464;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_35;
							}
							continue;
						case 3:
							goto IL_133;
						}
						IL_35:
						if (!base.Dispatcher.CheckAccess())
						{
							num = (short)403177473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_10B:
						result = (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.IsCheckedProperty);
						num = (short)1783103491;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_109:
					IL_133:;
				}
				catch
				{
					result = (bool)global::DevComponents.WpfRibbon.ButtonCommandParameter.IsCheckedProperty.DefaultMetadata.DefaultValue;
				}
				num = (short)480968704;
				short num4 = num;
				return result;
			}
			set
			{
				if (!base.Dispatcher.CheckAccess())
				{
					short num;
					for (;;)
					{
						num = (short)1134388282;
						short num2 = num;
						num = (short)550003770;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_5A;
						}
					}
					IL_5A:
					num = (short)2128281600;
					short num3 = num;
					num = (short)1697185793;
					if (num != 0)
					{
					}
					num = (short)176291840;
					if (num != 0)
					{
					}
					base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Threading.SendOrPostCallback(delegate(object <p0>)
					{
						short num4 = (short)1033229240;
						short num5 = num4;
						num4 = (short)88658872;
						switch (num5 == num4)
						{
						}
						num4 = (short)837812224;
						short num6 = num4;
						num4 = (short)482803712;
						if (num4 != 0)
						{
						}
						num4 = (short)320143361;
						if (num4 != 0)
						{
						}
						this.SetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.IsCheckedProperty, value);
					}), value);
					return;
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.IsCheckedProperty, value);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00031844 File Offset: 0x0002FA44
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000319D4 File Offset: 0x0002FBD4
		[global::System.ComponentModel.Bindable(true)]
		public object Tag
		{
			get
			{
				short num;
				object result;
				try
				{
					num = (short)1140391938;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_DB;
						case 1:
						{
							result = base.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Windows.Threading.DispatcherOperationCallback(delegate(object <p0>)
							{
								short num5 = (short)726063183;
								short num6 = num5;
								num5 = (short)1122162767;
								switch (num6 == num5)
								{
								}
								num5 = (short)966787072;
								short num7 = num5;
								num5 = (short)1615462401;
								if (num5 != 0)
								{
								}
								num5 = (short)1692532736;
								if (num5 != 0)
								{
								}
								return base.GetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.TagProperty);
							}), global::DevComponents.WpfRibbon.ButtonCommandParameter.TagProperty);
							num = (short)176349701;
							short num3 = num;
							num = (short)375054853;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_DD;
							default:
								num = (short)1400373248;
								if (num != 0)
								{
								}
								num = (short)1743716352;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_35;
							}
							continue;
						case 3:
							goto IL_100;
						}
						IL_35:
						if (!base.Dispatcher.CheckAccess())
						{
							num = (short)1844248577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DD:
						result = base.GetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.TagProperty);
						num = (short)113049603;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_DB:
					IL_100:;
				}
				catch
				{
					result = global::DevComponents.WpfRibbon.ButtonCommandParameter.TagProperty.DefaultMetadata.DefaultValue;
				}
				num = (short)141623296;
				short num4 = num;
				num = (short)1808400385;
				if (num != 0)
				{
				}
				return result;
			}
			set
			{
				if (!base.Dispatcher.CheckAccess())
				{
					short num;
					for (;;)
					{
						num = (short)1772835354;
						short num2 = num;
						num = (short)1144410650;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_5B;
						}
					}
					IL_5B:
					num = (short)1055916032;
					short num3 = num;
					num = (short)1453326337;
					if (num != 0)
					{
					}
					num = (short)1003749376;
					if (num != 0)
					{
					}
					base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Threading.SendOrPostCallback(delegate(object <p0>)
					{
						short num4 = (short)366205771;
						short num5 = num4;
						num4 = (short)925162315;
						switch (num5 == num4)
						{
						}
						num4 = (short)1336082432;
						short num6 = num4;
						num4 = (short)157351936;
						if (num4 != 0)
						{
						}
						num4 = (short)2059927553;
						if (num4 != 0)
						{
						}
						this.SetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.TagProperty, value);
					}), value);
					return;
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.TagProperty, value);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00031AD4 File Offset: 0x0002FCD4
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00031C74 File Offset: 0x0002FE74
		public bool ValueChanged
		{
			get
			{
				short num;
				bool result;
				try
				{
					num = (short)355270658;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_E2;
						case 1:
						{
							result = (bool)base.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Windows.Threading.DispatcherOperationCallback(delegate(object <p0>)
							{
								short num5 = (short)786162890;
								short num6 = num5;
								num5 = (short)1345905866;
								switch (num6 == num5)
								{
								}
								num5 = (short)2066481152;
								short num7 = num5;
								num5 = (short)481427457;
								if (num5 != 0)
								{
								}
								num5 = (short)1110769664;
								if (num5 != 0)
								{
								}
								return base.GetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.ValueChangedProperty);
							}), global::DevComponents.WpfRibbon.ButtonCommandParameter.ValueChangedProperty);
							num = (short)122856052;
							short num3 = num;
							num = (short)1215603316;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_10A;
							default:
								num = (short)1505886208;
								if (num != 0)
								{
								}
								num = (short)1752563712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_34;
							}
							continue;
						case 3:
							goto IL_133;
						}
						IL_34:
						if (!base.Dispatcher.CheckAccess())
						{
							num = (short)836435969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_10A:
						result = (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.ValueChangedProperty);
						num = (short)240254979;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_E2:
					num = (short)1449394177;
					if (num != 0)
					{
					}
					IL_133:;
				}
				catch
				{
					result = (bool)global::DevComponents.WpfRibbon.ButtonCommandParameter.ValueChangedProperty.DefaultMetadata.DefaultValue;
				}
				num = (short)1410400256;
				short num4 = num;
				return result;
			}
			set
			{
				short num;
				if (!base.Dispatcher.CheckAccess())
				{
					for (;;)
					{
						num = (short)1687482842;
						short num2 = num;
						num = (short)1403843034;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_5B;
						}
					}
					IL_5B:
					num = (short)955580416;
					short num3 = num;
					num = (short)49086464;
					if (num != 0)
					{
					}
					base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Threading.SendOrPostCallback(delegate(object <p0>)
					{
						short num4 = (short)373171627;
						short num5 = num4;
						num4 = (short)78980523;
						switch (num5 == num4)
						{
						}
						num4 = (short)385548288;
						short num6 = num4;
						num4 = (short)1179385857;
						if (num4 != 0)
						{
						}
						num4 = (short)1010696192;
						if (num4 != 0)
						{
						}
						this.SetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.ValueChangedProperty, value);
					}), value);
					return;
				}
				num = (short)80936961;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonCommandParameter.ValueChangedProperty, value);
			}
		}

		// Token: 0x040000B5 RID: 181
		public static readonly global::System.Windows.DependencyProperty IsCheckedProperty;

		// Token: 0x040000B6 RID: 182
		public static readonly global::System.Windows.DependencyProperty TagProperty;

		// Token: 0x040000B7 RID: 183
		public static readonly global::System.Windows.DependencyProperty ValueChangedProperty;
	}
}
