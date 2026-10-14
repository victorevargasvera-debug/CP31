using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000009 RID: 9
	public class EditModeCheckBehavior<T>
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00003638 File Offset: 0x00001838
		public EditModeCheckBehavior(global::Infragistics.Windows.DataPresenter.XamDataGrid grid)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000364C File Offset: 0x0000184C
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs A_1)
		{
			int a_ = 15;
			short num = (short)2055929856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				T t;
				for (;;)
				{
					IL_32:
					global::System.Windows.Style cellValuePresenterStyle;
					global::System.Collections.Generic.IEnumerator<global::System.Windows.TriggerBase> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_99;
					case 1:
						goto IL_66A;
					case 2:
						if (cellValuePresenterStyle != null)
						{
							num = (short)723255297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (t == null)
						{
							num = (short)241565696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						cellValuePresenterStyle = A_1.Cell.Field.Settings.CellValuePresenterStyle;
						num = (short)601358338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)267976707;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Windows.SetterBase> enumerator2;
								global::System.Windows.DataTrigger dataTrigger;
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)653328388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5AA;
								case 1:
									goto IL_5F9;
								case 2:
									try
									{
										num = (short)63897618;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												if (((global::System.Windows.Setter)enumerator2.Current).Property.Name == global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("渦娨渪䌬丮匰弲倴匶", a_))
												{
													num = (short)1633550351;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1C0;
											case 1:
											{
												int num3;
												string text;
												if (num3 < text.Length)
												{
													num = (short)1812070404;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_4DA;
											}
											case 2:
												num = (short)839188489;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												num = (short)136773639;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												int num3;
												string text = text.Substring(num3 + 1);
												num = (short)929693701;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												goto IL_4DA;
											case 6:
											{
												bool flag;
												if (flag != global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(A_1.Cell).IsEnabled)
												{
													num = (short)1029701644;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1C0;
											}
											case 7:
												if ((dataTrigger.Binding as global::System.Windows.Data.Binding).Path != null)
												{
													num = (short)1561460756;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1C0;
											case 8:
											{
												string text;
												if (!string.IsNullOrEmpty(text))
												{
													num = (short)767623182;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1C0;
											}
											case 9:
												goto IL_534;
											case 10:
												if (dataTrigger.Binding != null)
												{
													num = (short)668467203;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1C0;
											case 11:
												goto IL_1C0;
											case 12:
											{
												bool flag;
												global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(A_1.Cell).IsEnabled = flag;
												A_1.Cancel = true;
												num = (short)2034434059;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 13:
											{
												num = (short)2115916710;
												short num4 = num;
												num = (short)782652326;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_4DA;
												default:
													num = (short)1857486848;
													if (num != 0)
													{
													}
													num = (short)193069057;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 14:
											{
												string text;
												bool flag = (bool)t.GetType().GetProperty(text).GetValue(t, null);
												num = (short)831979526;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 15:
												num = (short)1187381258;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 16:
											{
												int num3;
												if (num3 >= 0)
												{
													num = (short)222298125;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_4DA;
											}
											case 17:
												if (!enumerator2.MoveNext())
												{
													num = (short)831193090;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1563688960;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 18:
												switch (0)
												{
												case 0:
													goto IL_1BB;
												}
												continue;
											case 19:
												goto IL_1D7;
											case 20:
											{
												string text = (dataTrigger.Binding as global::System.Windows.Data.Binding).Path.Path;
												int num3 = text.LastIndexOf(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("द", a_), global::System.StringComparison.Ordinal);
												num = (short)699465744;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_1BB:
											num = (short)536084497;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1C0:
											num = (short)762052627;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4DA:
											num = (short)585105416;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_1D7:
										return;
										IL_534:
										break;
									}
									finally
									{
										num = (short)192937984;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_56D;
												}
												continue;
											case 1:
												enumerator2.Dispose();
												num = (short)299302914;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_5A7;
											}
											IL_56D:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)663617537;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_5A7:;
									}
									goto IL_5AA;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_101;
									}
									continue;
								case 4:
									num = (short)989986817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_106:
								num = (short)1983905792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_101:
								goto IL_106;
								IL_5AA:
								dataTrigger = (global::System.Windows.DataTrigger)enumerator.Current;
								enumerator2 = dataTrigger.Setters.GetEnumerator();
								num = (short)724959234;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5F9:
							return;
						}
						finally
						{
							num = (short)1438449664;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_630;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1887698946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_667;
								}
								IL_630:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1288044545;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_667:;
						}
						goto IL_66A;
					}
					goto IL_4D;
					IL_66A:
					num = (short)129826817;
					if (num != 0)
					{
					}
					enumerator = cellValuePresenterStyle.Triggers.GetEnumerator();
					num = (short)1164640260;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_99:
				num = (short)27394048;
				short num5 = num;
				return;
				IL_4D:
				t = (T)((object)A_1.Cell.Record.DataItem);
				num = (short)1256456195;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}
	}
}
