using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Reporting;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure.Dialogs;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure.Utility
{
	// Token: 0x0200004B RID: 75
	public class DataGridOperation
	{
		// Token: 0x060001FC RID: 508 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
		public DataGridOperation(global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid)
		{
			this.a = dataGrid;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0001CBF4 File Offset: 0x0001ADF4
		public global::Infragistics.Windows.DataPresenter.XamDataGrid DevicesDataGrid
		{
			get
			{
				short num = (short)581805074;
				short num2 = num;
				num = (short)1037739026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)631111680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1499398144;
				if (num != 0)
				{
				}
				num = (short)1986396161;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001CCA4 File Offset: 0x0001AEA4
		public void SelectAllDevices()
		{
			short num = (short)495250745;
			short num2 = num;
			num = (short)365161785;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1660420096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1552154625;
			if (num != 0)
			{
			}
			num = (short)1022558208;
			if (num != 0)
			{
			}
			this.a.SelectedItems.Records.Clear();
			this.a.ActiveDataItem = null;
			this.a.SelectedItems.Records.AddRange(this.a.Records.ToArray<global::Infragistics.Windows.DataPresenter.Record>());
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001CD94 File Offset: 0x0001AF94
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> GetPrintRecords(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dataGrid)
		{
			short num = (short)223870976;
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
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> source;
					global::System.Func<global::Infragistics.Windows.DataPresenter.DataRecord, int> keySelector;
					switch (num2)
					{
					case 0:
						if (dataGrid.SelectedItems.Records.Count > 0)
						{
							num = (short)594804738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_496;
					case 1:
					{
						list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)dataGrid.Records).GetEnumerator();
						num = (short)1957691398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)2093088769;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = dataGrid.SelectedItems.Records.GetEnumerator();
						num = (short)1670512647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (dataGrid.SelectedItems != null)
						{
							num = (short)429064202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_496;
					case 4:
						num = (short)2107179008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list2;
						source = list2;
						if ((keySelector = global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation.<>c.<>9__5_0) == null)
						{
							goto IL_269;
						}
						goto IL_C2;
					}
					case 6:
						try
						{
							num = (short)913637379;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
									if (!enumerator.MoveNext())
									{
										goto IL_192;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord item = (global::Infragistics.Windows.DataPresenter.DataRecord)enumerator.Current;
									list.Add(item);
									num = (short)131530753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1F8;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_125;
									}
									continue;
								case 4:
									num = (short)1107099650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_127:
								num = (short)1616125166;
								short num3 = num;
								num = (short)464133358;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_192:
									num = (short)1959591940;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								default:
									num = (short)1783431168;
									if (num != 0)
									{
									}
									num = (short)1652555776;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_125:
								goto IL_127;
							}
							IL_1F8:
							return list;
						}
						finally
						{
							num = (short)16777217;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_266;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_22F;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1264386048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_22F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)641990658;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_266:;
						}
						goto IL_269;
					case 7:
						try
						{
							num = (short)740294659;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)61669378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_425;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3AA;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)373161985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord item2 = (global::Infragistics.Windows.DataPresenter.DataRecord)enumerator.Current;
									global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list2;
									list2.Add(item2);
									num = (short)902955008;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_3D7:
								num = (short)281608196;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3AA:
								goto IL_3D7;
							}
							IL_425:
							goto IL_9C;
						}
						finally
						{
							num = (short)1631191041;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_493;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_45D;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1732902912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_45D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1262026754;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_493:;
						}
						goto IL_496;
						IL_9C:
						num = (short)1623916549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return list;
					case 9:
					{
						num = (short)1394671616;
						short num4 = num;
						if (dataGrid.Records != null)
						{
							num = (short)1469972481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					}
					case 10:
						num = (short)313589771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (dataGrid.SelectedItems.Records != null)
						{
							num = (short)1335951364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_496;
					}
					goto IL_5F;
					IL_C2:
					list = source.OrderBy(keySelector).ToList<global::Infragistics.Windows.DataPresenter.DataRecord>();
					num = (short)519438344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_269:
					keySelector = (global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation.<>c.<>9__5_0 = new global::System.Func<global::Infragistics.Windows.DataPresenter.DataRecord, int>(global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation.<>c.<>9.a));
					goto IL_C2;
					IL_496:
					num = (short)1125842953;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_5F:
				list = null;
				num = (short)419889155;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001D300 File Offset: 0x0001B500
		public void DevicesPrintView(global::System.Collections.Generic.IEnumerable<object> dataItems, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> fieldNeedSpecialConverter, global::System.Collections.Generic.List<string> fieldsNeedCollapsed)
		{
			short num = (short)1278547802;
			short num2 = num;
			num = (short)1047467866;
			switch (num2 == num)
			{
			}
			num = (short)448266240;
			short num3 = num;
			num = (short)1760952320;
			if (num != 0)
			{
			}
			num = (short)550830081;
			if (num != 0)
			{
			}
			this.b(dataItems, fieldNeedSpecialConverter, fieldsNeedCollapsed);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0001D3B4 File Offset: 0x0001B5B4
		public void DevicesPrint(global::System.Collections.Generic.IEnumerable<object> dataItems, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> fieldNeedSpecialConverter, global::System.Collections.Generic.List<string> fieldsNeedCollapsed)
		{
			short num = (short)1248564609;
			short num2 = num;
			num = (short)2003473793;
			switch (num2 == num)
			{
			}
			num = (short)964165632;
			short num3 = num;
			num = (short)1683095553;
			if (num != 0)
			{
			}
			num = (short)257490944;
			if (num != 0)
			{
			}
			this.a(dataItems, fieldNeedSpecialConverter, fieldsNeedCollapsed);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0001D468 File Offset: 0x0001B668
		private void b(global::System.Collections.Generic.IEnumerable<object> A_0, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> A_1, global::System.Collections.Generic.List<string> A_2)
		{
			short num = (short)1492844544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::Infragistics.Windows.DataPresenter.XamDataGrid xamDataGrid;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator3;
					switch (num2)
					{
					case 0:
						num = (short)1510277121;
						if (num != 0)
						{
						}
						if (xamDataGrid == null)
						{
							num = (short)1986396161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D5;
					case 1:
						goto IL_CB;
					case 2:
						try
						{
							num = (short)1045495811;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_44A;
								case 1:
								{
									try
									{
										num = (short)1516109828;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> keyValuePair;
											global::Infragistics.Windows.DataPresenter.Field field;
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>>.Enumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)113180677;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												keyValuePair = enumerator.Current;
												num = (short)1363476481;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												if (field.Name == keyValuePair.Key)
												{
													num = (short)1709083729;
													short num3 = num;
													num = (short)1075022929;
													switch ((num3 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_1E2;
													default:
														num = (short)935264256;
														if (num != 0)
														{
														}
														num = (short)1879048195;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
												}
												break;
											case 3:
												goto IL_1E2;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_1DD;
												}
												continue;
											case 5:
												num = (short)2049835014;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												goto IL_321;
											}
											goto IL_1DD;
											IL_1E2:
											field.DataType = keyValuePair.Value.Value;
											field.Converter = keyValuePair.Value.Key;
											num = (short)2065629186;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2C9:
											num = (short)1833041920;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1DD:
											goto IL_2C9;
										}
										IL_321:
										goto IL_173;
									}
									finally
									{
										global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>>.Enumerator enumerator;
										((global::System.IDisposable)enumerator).Dispose();
									}
									goto Block_5;
									IL_173:
									global::System.Collections.Generic.List<string>.Enumerator enumerator2 = A_2.GetEnumerator();
									num = (short)1558315012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)1948909568;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.Field field = enumerator3.Current;
									global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>>.Enumerator enumerator = A_1.GetEnumerator();
									num = (short)637796353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_10E;
									}
									continue;
								case 4:
									goto IL_334;
								case 5:
									goto IL_463;
								}
								IL_139:
								num = (short)540344322;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								Block_5:
								try
								{
									IL_334:
									num = (short)1415708676;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::System.Collections.Generic.List<string>.Enumerator enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)903675909;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											string b = enumerator2.Current;
											num = (short)1644822530;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
										{
											global::Infragistics.Windows.DataPresenter.Field field;
											field.Visibility = global::System.Windows.Visibility.Collapsed;
											num = (short)1512505347;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
										{
											global::Infragistics.Windows.DataPresenter.Field field;
											string b;
											if (field.Name == b)
											{
												num = (short)1558249473;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 4:
											switch (0)
											{
											case 0:
												goto IL_376;
											}
											continue;
										case 5:
											num = (short)1912274950;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
											goto IL_437;
										}
										IL_3DF:
										num = (short)439615488;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_376:
										goto IL_3DF;
									}
									IL_437:
									goto IL_139;
								}
								finally
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator2;
									((global::System.IDisposable)enumerator2).Dispose();
								}
								goto IL_44A;
								IL_10E:
								goto IL_139;
								IL_44A:
								num = (short)880738309;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_463:
							goto IL_50B;
						}
						finally
						{
							num = (short)1661927424;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_49C;
									}
									continue;
								case 1:
									enumerator3.Dispose();
									num = (short)1040121858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4D2;
								}
								IL_49C:
								if (enumerator3 == null)
								{
									break;
								}
								num = (short)1558970369;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4D2:;
						}
						goto IL_4D5;
					}
					goto IL_3A;
					IL_4D5:
					enumerator3 = xamDataGrid.DefaultFieldLayout.Fields.GetEnumerator();
					num = (short)2009923586;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CB:
				throw new global::System.ArgumentNullException();
				IL_50B:
				xamDataGrid.ReportView = new global::Infragistics.Windows.DataPresenter.TabularReportView
				{
					Orientation = new global::System.Windows.Controls.Orientation?(global::System.Windows.Controls.Orientation.Vertical),
					LevelIndentation = 0.0,
					ExcludeGroupBySettings = true
				};
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.Dialogs.PrintPreviewWindow printPreviewWindow = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.Dialogs.PrintPreviewWindow(xamDataGrid);
				printPreviewWindow.WindowState = global::System.Windows.WindowState.Maximized;
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FlowDirectionHelper.SetUIFlowDirection(printPreviewWindow);
				global::System.Windows.Input.Mouse.OverrideCursor = null;
				printPreviewWindow.ShowDialog();
				return;
				IL_3A:
				num = (short)1592393728;
				short num4 = num;
				xamDataGrid = global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation.FillDataGridCopyForExport(A_0, this.a);
				num = (short)39190528;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0001DA1C File Offset: 0x0001BC1C
		private void a(global::System.Collections.Generic.IEnumerable<object> A_0, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> A_1, global::System.Collections.Generic.List<string> A_2)
		{
			short num = (short)581566464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				global::Infragistics.Windows.DataPresenter.XamDataGrid xamDataGrid;
				for (;;)
				{
					IL_28:
					num = (short)1299644416;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator3;
					switch (num2)
					{
					case 0:
						if (xamDataGrid == null)
						{
							num = (short)57933825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_562;
					case 1:
						goto IL_A4;
					case 2:
						try
						{
							num = (short)1200619521;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.List<string>.Enumerator enumerator;
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)490536964;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											string b;
											switch (num2)
											{
											case 0:
												if (!enumerator.MoveNext())
												{
													num = (short)1180762117;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_166;
											case 1:
											{
												global::Infragistics.Windows.DataPresenter.Field field;
												field.Visibility = global::System.Windows.Visibility.Collapsed;
												num = (short)1854446982;
												short num4 = num;
												num = (short)1392680326;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_166;
												default:
													num = (short)622854144;
													if (num != 0)
													{
													}
													num = (short)402522115;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
											{
												global::Infragistics.Windows.DataPresenter.Field field;
												if (field.Name == b)
												{
													num = (short)1369374721;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_161;
												}
												continue;
											case 5:
												num = (short)324468742;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												goto IL_273;
											}
											goto IL_161;
											IL_166:
											b = enumerator.Current;
											num = (short)605159426;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_21D:
											num = (short)132186112;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_161:
											goto IL_21D;
										}
										IL_273:;
									}
									finally
									{
										((global::System.IDisposable)enumerator).Dispose();
									}
									break;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F7;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>>.Enumerator enumerator2 = A_1.GetEnumerator();
									num = (short)1229979655;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)212336645;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.Field field = enumerator3.Current;
									num = (short)792657928;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									if (A_2 != null)
									{
										num = (short)974979078;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									num = (short)400490505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_447;
								case 7:
									try
									{
										num = (short)536346628;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::Infragistics.Windows.DataPresenter.Field field;
												global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> keyValuePair;
												if (field.Name == keyValuePair.Key)
												{
													num = (short)1964310533;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 1:
												num = (short)1203830790;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>>.Enumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1929052161;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> keyValuePair = enumerator2.Current;
												num = (short)208338944;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_33E;
												}
												continue;
											case 5:
											{
												global::Infragistics.Windows.DataPresenter.Field field;
												global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> keyValuePair;
												field.DataType = keyValuePair.Value.Value;
												field.Converter = keyValuePair.Value.Key;
												num = (short)1124204547;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												goto IL_434;
											}
											IL_340:
											num = (short)1478492162;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_33E:
											goto IL_340;
										}
										IL_434:
										goto IL_2C3;
									}
									finally
									{
										global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_447;
								case 8:
									if (A_1 != null)
									{
										num = (short)312541186;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2C3;
								case 9:
									goto IL_4CA;
								}
								IL_283:
								num = (short)1121845251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F7:
								goto IL_283;
								IL_2C3:
								num = (short)676593668;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_447:
								enumerator = A_2.GetEnumerator();
								num = (short)1472200704;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4CA:
							goto IL_596;
						}
						finally
						{
							num = (short)1930559488;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_501;
									}
									continue;
								case 1:
									enumerator3.Dispose();
									num = (short)1961754625;
									if (num != 0)
									{
									}
									num = (short)352256002;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_55F;
								}
								IL_501:
								if (enumerator3 == null)
								{
									break;
								}
								num = (short)391839745;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_55F:;
						}
						goto IL_562;
					}
					goto IL_66;
					IL_562:
					enumerator3 = xamDataGrid.DefaultFieldLayout.Fields.GetEnumerator();
					num = (short)494141442;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A4:
				throw new global::System.ArgumentNullException();
				IL_596:
				xamDataGrid.ReportView = new global::Infragistics.Windows.DataPresenter.TabularReportView
				{
					LevelIndentation = 0.0,
					ExcludeGroupBySettings = true
				};
				global::Infragistics.Windows.Reporting.Report report = new global::Infragistics.Windows.Reporting.Report();
				report.ReportSettings.HorizontalPaginationMode = global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale;
				report.ReportSettings.PagePrintOrder = global::Infragistics.Windows.Reporting.PagePrintOrder.Vertical;
				report.ReportSettings.PageOrientation = global::Infragistics.Windows.Reporting.PageOrientation.Landscape;
				global::Infragistics.Windows.Reporting.EmbeddedVisualReportSection item = new global::Infragistics.Windows.Reporting.EmbeddedVisualReportSection(xamDataGrid);
				report.Sections.Add(item);
				report.Print(true, false);
				return;
				IL_66:
				xamDataGrid = global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation.FillDataGridCopyForExport(A_0, this.a);
				num = (short)2135097344;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0001E074 File Offset: 0x0001C274
		public static global::Infragistics.Windows.DataPresenter.XamDataGrid FillDataGridCopyForExport(global::System.Collections.Generic.IEnumerable<object> dataItems, global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid)
		{
			short num = (short)1768226816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)13238272;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::System.Windows.Style style;
				global::Infragistics.Windows.DataPresenter.XamDataGrid xamDataGrid;
				for (;;)
				{
					IL_51:
					global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayouts;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1944715265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator;
								global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout;
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FieldLayout> enumerator3;
								global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2;
								switch (num2)
								{
								case 0:
								{
									num = (short)773217586;
									short num4 = num;
									num = (short)858873138;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_447;
									default:
										num = (short)1835466752;
										if (num != 0)
										{
										}
										num = (short)718995458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_11E;
									}
									continue;
								case 2:
									goto IL_7D3;
								case 4:
									try
									{
										num = (short)1827078144;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_4AE;
												}
												continue;
											case 1:
												num = (short)379453442;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_6FE;
											case 3:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)712048641;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Infragistics.Windows.DataPresenter.Field field = enumerator.Current;
												global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator2 = fieldLayout.Fields.GetEnumerator();
												num = (short)1939210244;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												try
												{
													num = (short)1661992961;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
														{
															global::Infragistics.Windows.DataPresenter.Field field;
															global::Infragistics.Windows.DataPresenter.Field field2;
															field2.ActualPosition = new global::Infragistics.Windows.DataPresenter.FieldPosition(field.ActualPosition.Column, field.ActualPosition.Row, field.ActualPosition.ColumnSpan, field.ActualPosition.RowSpan);
															num = (short)481361926;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 1:
															switch (0)
															{
															case 0:
																goto IL_4F6;
															}
															continue;
														case 2:
															goto IL_600;
														case 3:
															num = (short)550961154;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 4:
														{
															global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator2;
															if (!enumerator2.MoveNext())
															{
																num = (short)302907395;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::Infragistics.Windows.DataPresenter.Field field2 = enumerator2.Current;
															num = (short)396296197;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 5:
														{
															global::Infragistics.Windows.DataPresenter.Field field;
															global::Infragistics.Windows.DataPresenter.Field field2;
															if (field2.Name == field.Name)
															{
																num = (short)2071592960;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 6:
															goto IL_5E3;
														}
														IL_544:
														num = (short)1707606020;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_4F6:
														goto IL_544;
													}
													IL_5E3:
													IL_600:;
												}
												finally
												{
													num = (short)1516175361;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator2;
														switch (num2)
														{
														case 0:
															enumerator2.Dispose();
															num = (short)34078722;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															switch (0)
															{
															case 0:
																goto IL_635;
															}
															continue;
														case 2:
															goto IL_66F;
														}
														IL_635:
														if (enumerator2 == null)
														{
															break;
														}
														num = (short)459603968;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_66F:;
												}
												break;
											}
											IL_672:
											num = (short)2140798979;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4AE:
											goto IL_672;
										}
										IL_6FE:
										goto IL_447;
									}
									finally
									{
										num = (short)392364033;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)2020671490;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_735;
												}
												continue;
											case 2:
												goto IL_76E;
											}
											IL_735:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1198260224;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_76E:;
									}
									goto IL_771;
								case 5:
									if (!enumerator3.MoveNext())
									{
										num = (short)1296039936;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_771;
								case 6:
									try
									{
										num = (short)1238564868;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Infragistics.Windows.DataPresenter.Field field3;
											switch (num2)
											{
											case 0:
												if (field3.Converter != null)
												{
													num = (short)439418887;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_392;
											case 1:
												goto IL_392;
											case 2:
												goto IL_3D2;
											case 3:
											{
												global::Infragistics.Windows.DataPresenter.Field field4;
												if (field4.Visibility == global::System.Windows.Visibility.Visible)
												{
													num = (short)1446772744;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_225;
												}
												continue;
											case 6:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)387252233;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Infragistics.Windows.DataPresenter.Field field4 = enumerator.Current;
												num = (short)1407647747;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												global::Infragistics.Windows.DataPresenter.Field field4;
												field3.Settings.EditAsType = field4.Settings.EditAsType;
												num = (short)694091777;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
											{
												field3 = new global::Infragistics.Windows.DataPresenter.Field();
												global::Infragistics.Windows.DataPresenter.Field field4;
												field3.Name = field4.Name;
												field3.Label = field4.Label;
												field3.Visibility = field4.Visibility;
												field3.Settings.EditorStyle = style;
												field3.Settings.CellWidth = field4.CellWidthResolved;
												field3.Settings.LabelWidth = field4.LabelWidthResolved;
												field3.Converter = field4.Converter;
												num = (short)374996992;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
												num = (short)210370562;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_353:
											num = (short)211091462;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_225:
											goto IL_353;
											IL_392:
											fieldLayout.Fields.Add(field3);
											num = (short)989265925;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3D2:
										goto IL_1AB;
									}
									finally
									{
										num = (short)1506344961;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)18153474;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_40A;
												}
												continue;
											case 2:
												goto IL_444;
											}
											IL_40A:
											if (enumerator == null)
											{
												break;
											}
											num = (short)368181248;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_444:;
									}
									goto IL_447;
									IL_1AB:
									enumerator = fieldLayout2.Fields.GetEnumerator();
									num = (short)299106308;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_123:
								num = (short)579141637;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11E:
								goto IL_123;
								IL_447:
								xamDataGrid.FieldLayouts.Add(fieldLayout);
								num = (short)1500512259;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_771:
								fieldLayout2 = enumerator3.Current;
								fieldLayout = new global::Infragistics.Windows.DataPresenter.FieldLayout();
								fieldLayout.Key = fieldLayout2.Key;
								enumerator = fieldLayout2.Fields.GetEnumerator();
								num = (short)595722246;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7D3:
							goto IL_8BC;
						}
						finally
						{
							num = (short)1011613697;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)487522305;
								if (num != 0)
								{
								}
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FieldLayout> enumerator3;
								switch (num2)
								{
								case 0:
									enumerator3.Dispose();
									num = (short)694288386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_831;
									}
									continue;
								case 2:
									goto IL_866;
								}
								IL_831:
								if (enumerator3 == null)
								{
									break;
								}
								num = (short)179437568;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_866:;
						}
						goto IL_869;
					case 1:
						if (xamDataGrid != null)
						{
							num = (short)132579332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return xamDataGrid;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FieldLayout> enumerator3 = fieldLayouts.GetEnumerator();
						num = (short)91619328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (fieldLayouts != null)
						{
							num = (short)2131296258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8BC;
					case 4:
						goto IL_869;
					case 5:
						return xamDataGrid;
					}
					goto IL_70;
					IL_869:
					xamDataGrid.FieldLayoutSettings.AutoGenerateFields = new bool?(false);
					fieldLayouts = dataGrid.FieldLayouts;
					num = (short)561446915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8BC:
					xamDataGrid = global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation.FillDataGrid(dataItems, xamDataGrid);
					num = (short)638320645;
					num2 = (int)((global::System.IntPtr)num);
				}
				return xamDataGrid;
				IL_70:
				xamDataGrid = new global::Infragistics.Windows.DataPresenter.XamDataGrid();
				style = new global::System.Windows.Style(typeof(global::Infragistics.Windows.Editors.XamTextEditor));
				style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.XamTextEditor.TextWrappingProperty, global::System.Windows.TextWrapping.Wrap));
				num = (short)547880961;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0001E9E8 File Offset: 0x0001CBE8
		public static global::Infragistics.Windows.DataPresenter.XamDataGrid FillDataGrid(global::System.Collections.Generic.IEnumerable<object> dataItems, global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid)
		{
			short num = (short)1573715972;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<object> enumerator;
				switch (num2)
				{
				case 0:
					num = (short)564396033;
					if (num != 0)
					{
					}
					num = (short)2049966083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1EC;
				case 2:
				{
					num = (short)1163591680;
					short num3 = num;
					try
					{
						num = (short)1580007428;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_12D;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1413218307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object item = enumerator.Current;
								dataGrid.DataItems.Add(item);
								num = (short)1122041856;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)870121473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_B5;
								}
								continue;
							}
							IL_E2:
							num = (short)575078402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B5:
							goto IL_E2;
						}
						IL_12D:
						return dataGrid;
					}
					finally
					{
						num = (short)1871446018;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1E9;
							case 1:
								for (;;)
								{
									enumerator.Dispose();
									num = (short)841184869;
									short num4 = num;
									num = (short)1793881701;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_1BB;
									}
								}
								IL_1BB:
								num = (short)806420480;
								if (num != 0)
								{
								}
								num = (short)1947598848;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_163;
								}
								continue;
							}
							IL_163:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1467613185;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1E9:;
					}
					goto IL_1EC;
				}
				case 3:
					if (dataItems.Count<object>() > 0)
					{
						num = (short)1435238401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return dataGrid;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				}
				IL_38:
				if (dataItems != null)
				{
					num = (short)867106816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1EC:
				enumerator = dataItems.GetEnumerator();
				num = (short)338821122;
				num2 = (int)((global::System.IntPtr)num);
			}
			return dataGrid;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0001EC80 File Offset: 0x0001CE80
		public static global::Infragistics.Windows.DataPresenter.XamDataGrid FillDataGridCopyForExport(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> records, global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid)
		{
			short num = (short)738197504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				global::Infragistics.Windows.DataPresenter.XamDataGrid xamDataGrid;
				for (;;)
				{
					IL_27:
					global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayouts;
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FieldLayout> enumerator = fieldLayouts.GetEnumerator();
						num = (short)1918107649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)438370310;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator2;
									try
									{
										num = (short)1532559364;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Infragistics.Windows.DataPresenter.Field field2;
											switch (num2)
											{
											case 0:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)1004929032;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Infragistics.Windows.DataPresenter.Field field = enumerator2.Current;
												num = (short)1134821378;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
											{
												field2 = new global::Infragistics.Windows.DataPresenter.Field();
												global::Infragistics.Windows.DataPresenter.Field field;
												field2.Name = field.Name;
												field2.Label = field.Label;
												field2.Visibility = field.Visibility;
												field2.Settings.CellWidth = field.CellWidthResolved;
												field2.Settings.LabelWidth = field.LabelWidthResolved;
												field2.Converter = field.Converter;
												num = (short)837943305;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												global::Infragistics.Windows.DataPresenter.Field field;
												if (field.Visibility == global::System.Windows.Visibility.Visible)
												{
													num = (short)779485185;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
												goto IL_586;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_3DA;
												}
												continue;
											case 6:
											{
												global::Infragistics.Windows.DataPresenter.Field field;
												field2.Settings.EditAsType = field.Settings.EditAsType;
												num = (short)1428094983;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
												goto IL_481;
											case 8:
												num = (short)1168834563;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
												if (field2.Converter != null)
												{
													num = (short)296288262;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_481;
											}
											goto IL_3DA;
											IL_481:
											fieldLayout.Fields.Add(field2);
											num = (short)895811589;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_52F:
											num = (short)510853120;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_3DA:
											goto IL_52F;
										}
										IL_586:
										goto IL_321;
									}
									finally
									{
										num = (short)1319108610;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_5F6;
											case 1:
												enumerator2.Dispose();
												num = (short)867237888;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_5BD;
												}
												continue;
											}
											IL_5BD:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1574502401;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_5F6:;
									}
									goto Block_10;
									IL_321:
									global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2;
									enumerator2 = fieldLayout2.Fields.GetEnumerator();
									num = (short)1366687747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_9D0;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FieldLayout> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1008533508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = enumerator.Current;
									fieldLayout = new global::Infragistics.Windows.DataPresenter.FieldLayout();
									fieldLayout.Key = fieldLayout2.Key;
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator2 = fieldLayout2.Fields.GetEnumerator();
									num = (short)1055457280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_5F9;
								case 4:
									num = (short)1063518209;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_31C;
									}
									continue;
								}
								IL_951:
								num = (short)127139842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								Block_10:
								try
								{
									IL_5F9:
									num = (short)1872822276;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator2;
										global::Infragistics.Windows.DataPresenter.Field field4;
										global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator3;
										switch (num2)
										{
										case 0:
											try
											{
												num = (short)2085879814;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
													{
														global::Infragistics.Windows.DataPresenter.Field field3;
														field3.ActualPosition = new global::Infragistics.Windows.DataPresenter.FieldPosition(field4.ActualPosition.Column, field4.ActualPosition.Row, field4.ActualPosition.ColumnSpan, field4.ActualPosition.RowSpan);
														num = (short)104267778;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 1:
														goto IL_78C;
													case 2:
														goto IL_731;
													case 3:
													{
														global::Infragistics.Windows.DataPresenter.Field field3;
														if (field3.Name == field4.Name)
														{
															num = (short)1344143360;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														break;
													}
													case 4:
													{
														if (!enumerator3.MoveNext())
														{
															num = (short)1833762821;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::Infragistics.Windows.DataPresenter.Field field3 = enumerator3.Current;
														num = (short)1443102723;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 5:
														num = (short)648151041;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 6:
														switch (0)
														{
														case 0:
															goto IL_67B;
														}
														continue;
													}
													IL_736:
													num = (short)667942916;
													num2 = (int)((global::System.IntPtr)num);
													continue;
													IL_67B:
													goto IL_736;
												}
												IL_731:
												IL_78C:
												break;
											}
											finally
											{
												num = (short)1538588674;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														goto IL_84F;
													case 1:
														for (;;)
														{
															enumerator3.Dispose();
															num = (short)267431555;
															short num3 = num;
															num = (short)624602755;
															switch ((num3 == num) ? 1 : 0)
															{
															case 0:
															case 2:
																break;
															default:
																goto IL_820;
															}
														}
														IL_820:
														num = (short)220987392;
														if (num != 0)
														{
														}
														num = (short)1073938432;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_7C4;
														}
														continue;
													}
													IL_7C4:
													if (enumerator3 == null)
													{
														break;
													}
													num = (short)447348737;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_84F:;
											}
											goto IL_852;
										case 1:
											goto IL_8DF;
										case 2:
											if (!enumerator2.MoveNext())
											{
												num = (short)325779459;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_852;
										case 3:
											num = (short)1350762497;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_634;
											}
											continue;
										}
										goto IL_634;
										IL_852:
										field4 = enumerator2.Current;
										enumerator3 = fieldLayout.Fields.GetEnumerator();
										num = (short)1322844160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_886:
										num = (short)956366850;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_634:
										goto IL_886;
									}
									IL_8DF:
									goto IL_990;
								}
								finally
								{
									num = (short)100204546;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator2;
										switch (num2)
										{
										case 0:
											goto IL_94E;
										case 1:
											enumerator2.Dispose();
											num = (short)325648384;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_916;
											}
											continue;
										}
										IL_916:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)1000865793;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_94E:;
								}
								goto IL_951;
								IL_990:
								xamDataGrid.FieldLayouts.Add(fieldLayout);
								num = (short)29949957;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_31C:
								goto IL_951;
							}
							IL_9D0:
							goto IL_B7;
						}
						finally
						{
							num = (short)2044854274;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FieldLayout> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_A3D;
								case 1:
									enumerator.Dispose();
									num = (short)1602486272;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_A07;
									}
									continue;
								}
								IL_A07:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1874264065;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A3D:;
						}
						return xamDataGrid;
					case 2:
						num = (short)1824981000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>.Enumerator enumerator4 = records.GetEnumerator();
						num = (short)1319567366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (xamDataGrid != null)
						{
							num = (short)955252745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return xamDataGrid;
					case 5:
					{
						num = (short)394002433;
						if (num != 0)
						{
						}
						num = (short)985202688;
						short num4 = num;
						if (records != null)
						{
							num = (short)112263170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return xamDataGrid;
					}
					case 6:
						try
						{
							num = (short)1178402820;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>.Enumerator enumerator4;
									if (!enumerator4.MoveNext())
									{
										num = (short)1296498690;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)enumerator4.Current;
									xamDataGrid.DataItems.Add(dataRecord.DataItem);
									num = (short)233570307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_231;
								case 2:
									num = (short)1180237825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1A4;
									}
									continue;
								}
								IL_1A6:
								num = (short)1845886976;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A4:
								goto IL_1A6;
							}
							IL_231:
							return xamDataGrid;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>.Enumerator enumerator4;
							((global::System.IDisposable)enumerator4).Dispose();
						}
						goto IL_244;
					case 7:
						if (fieldLayouts != null)
						{
							num = (short)1570963456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7;
					case 8:
						if (records.Count<global::Infragistics.Windows.DataPresenter.Record>() > 0)
						{
							num = (short)359399427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return xamDataGrid;
					case 9:
						goto IL_244;
					}
					goto IL_56;
					IL_B7:
					num = (short)1432420357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_244:
					xamDataGrid.FieldLayoutSettings.AutoGenerateFields = new bool?(false);
					fieldLayouts = dataGrid.FieldLayouts;
					num = (short)1056833543;
					num2 = (int)((global::System.IntPtr)num);
				}
				return xamDataGrid;
				IL_56:
				xamDataGrid = new global::Infragistics.Windows.DataPresenter.XamDataGrid();
				num = (short)4259844;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x040000DD RID: 221
		private global::Infragistics.Windows.DataPresenter.XamDataGrid a;
	}
}
