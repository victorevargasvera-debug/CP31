using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers
{
	// Token: 0x02000132 RID: 306
	internal class b
	{
		// Token: 0x06000965 RID: 2405 RVA: 0x0009B794 File Offset: 0x00099994
		public b(global::Infragistics.Windows.DataPresenter.XamDataGrid A_0)
		{
			A_0.FieldLayouts.CollectionChanged += this.b;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0009B7C0 File Offset: 0x000999C0
		private void b(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1435369472;
			switch (num)
			{
			default:
			{
				num = (short)814153733;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FieldLayout> enumerator2;
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FieldLayout> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_A6;
					case 1:
						goto IL_318;
					case 2:
						if (A_1.OldItems != null)
						{
							num = (short)1090519040;
							short num3 = num;
							num = (short)714342404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						try
						{
							num = (short)649920518;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1402929157;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)641670765;
									short num4 = num;
									num = (short)311631469;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)590807040;
										if (num != 0)
										{
										}
										global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = enumerator.Current;
										fieldLayout.Fields.CollectionChanged += this.a;
										num = (short)1616052226;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 1:
								{
									global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout;
									this.a(fieldLayout.Fields);
									num = (short)84082692;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout;
									if (fieldLayout.Fields.Any<global::Infragistics.Windows.DataPresenter.Field>())
									{
										num = (short)310444033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_2A8;
								case 5:
									num = (short)310050819;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_17D;
									}
									continue;
								}
								IL_253:
								num = (short)711983104;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_17D:
								goto IL_253;
							}
							IL_2A8:
							goto IL_D1;
						}
						finally
						{
							num = (short)1186332674;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_315;
								case 1:
									enumerator.Dispose();
									num = (short)359006208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2DF;
									}
									continue;
								}
								IL_2DF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)976879617;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_315:;
						}
						goto IL_318;
					case 4:
						enumerator2 = A_1.OldItems.Cast<global::Infragistics.Windows.DataPresenter.FieldLayout>().GetEnumerator();
						num = (short)1611333632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					}
					IL_5C:
					if (A_1.NewItems != null)
					{
						num = (short)1820262401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D1:
					num = (short)1203961858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_318:
					enumerator = A_1.NewItems.Cast<global::Infragistics.Windows.DataPresenter.FieldLayout>().GetEnumerator();
					num = (short)1884946435;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A6:
				num = (short)545849345;
				if (num != 0)
				{
				}
				try
				{
					num = (short)877002756;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)1809711105;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = enumerator2.Current;
							fieldLayout2.Fields.CollectionChanged -= this.a;
							num = (short)1446510595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1348075522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_408;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_381;
							}
							continue;
						}
						IL_383:
						num = (short)209584128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_381:
						goto IL_383;
					}
					IL_408:;
				}
				finally
				{
					num = (short)1835532290;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_473;
						case 1:
							enumerator2.Dispose();
							num = (short)1495072768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_43E;
							}
							continue;
						}
						IL_43E:
						if (enumerator2 == null)
						{
							break;
						}
						num = (short)1979514881;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_473:;
				}
				return;
			}
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0009BC78 File Offset: 0x00099E78
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_DA;
				case 1:
					goto IL_C3;
				case 2:
					num2 = (short)1424162817;
					if (num2 != 0)
					{
					}
					goto IL_C3;
				case 3:
				{
					num2 = (short)2126770339;
					short num3 = num2;
					num2 = (short)794226851;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DA;
					case 1:
						break;
					default:
					{
						num2 = (short)1195048960;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)893059072;
					if (num2 != 0)
					{
					}
					global::System.Collections.IList newItems = A_1.NewItems;
					if (newItems == null)
					{
						num2 = (short)1561853953;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					newItems.Cast<global::Infragistics.Windows.DataPresenter.Field>().ToList<global::Infragistics.Windows.DataPresenter.Field>().ForEach(new global::System.Action<global::Infragistics.Windows.DataPresenter.Field>(this.b));
					num2 = (short)1249705986;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
				IL_C3:
				num2 = (short)1075183616;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_DA:
			global::System.Collections.IList oldItems = A_1.OldItems;
			if (oldItems == null)
			{
				return;
			}
			oldItems.Cast<global::Infragistics.Windows.DataPresenter.Field>().ToList<global::Infragistics.Windows.DataPresenter.Field>().ForEach(new global::System.Action<global::Infragistics.Windows.DataPresenter.Field>(this.a));
			return;
			IL_20:
			this.a((global::Infragistics.Windows.DataPresenter.FieldCollection)A_0);
			num2 = (short)874708995;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0009BE0C File Offset: 0x0009A00C
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 3;
			while (A_1.PropertyName != global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춚좠솢첤쮦삨\udfaa풬", a_))
			{
				short num = (short)2022703104;
				short num2 = num;
				num = (short)1199403824;
				short num3 = num;
				num = (short)252343088;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1275199488;
					if (num != 0)
					{
					}
					num = (short)389480449;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)A_0;
			this.a(field.Owner.Fields);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0009BEF8 File Offset: 0x0009A0F8
		private void a(global::Infragistics.Windows.DataPresenter.FieldCollection A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Infragistics.Windows.DataPresenter.Field field;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (field.IsScrollTipField)
					{
						num2 = (short)1552416770;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13E;
				case 1:
					if (field == null)
					{
						num2 = (short)921042947;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_65;
				case 2:
					return;
				case 3:
				{
					num2 = (short)2125024357;
					short num3 = num2;
					num2 = (short)411257957;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_65;
					default:
						goto IL_128;
					}
					break;
				}
				}
				goto IL_20;
				IL_65:
				num2 = (short)1454440448;
				short num4 = num2;
				num2 = (short)518651905;
				if (num2 != 0)
				{
				}
				num2 = (short)2044395520;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_128:
			num2 = (short)1328480256;
			if (num2 != 0)
			{
			}
			return;
			IL_13E:
			field.IsScrollTipField = true;
			return;
			IL_20:
			field = A_0.FirstOrDefault(new global::System.Func<global::Infragistics.Windows.DataPresenter.Field, bool>(this.c));
			num2 = (short)359268353;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0009C04C File Offset: 0x0009A24C
		private bool c(global::Infragistics.Windows.DataPresenter.Field A_0)
		{
			short num = (short)1068367873;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseAlternateBinding)
					{
						num = (short)772407300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					num = (short)206372864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)962014021;
					short num3 = num;
					num = (short)1969171269;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1254359040;
						if (num != 0)
						{
						}
						num = (short)780861445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_152;
				case 5:
					if (A_0.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
					{
						num = (short)933494786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_3D:
				if (A_0.Visibility != global::System.Windows.Visibility.Visible)
				{
					return false;
				}
				num = (short)197459969;
				if (num != 0)
				{
				}
				num = (short)1456865283;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_152:
			num = (short)1551237120;
			short num4 = num;
			return A_0.Label != null;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0009C1DC File Offset: 0x0009A3DC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(global::Infragistics.Windows.DataPresenter.Field A_0)
		{
			short num = (short)1788439792;
			short num2 = num;
			num = (short)413232368;
			switch (num2 == num)
			{
			}
			num = (short)417136641;
			if (num != 0)
			{
			}
			num = (short)1109852160;
			short num3 = num;
			num = (short)2048851968;
			if (num != 0)
			{
			}
			A_0.PropertyChanged += this.a;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0009C298 File Offset: 0x0009A498
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Infragistics.Windows.DataPresenter.Field A_0)
		{
			short num = (short)36709328;
			short num2 = num;
			num = (short)1491542992;
			switch (num2 == num)
			{
			}
			num = (short)486473729;
			if (num != 0)
			{
			}
			num = (short)1259274240;
			short num3 = num;
			num = (short)1291190272;
			if (num != 0)
			{
			}
			A_0.PropertyChanged -= this.a;
		}
	}
}
