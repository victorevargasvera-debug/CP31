using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers
{
	// Token: 0x0200012D RID: 301
	internal class a
	{
		// Token: 0x0600094A RID: 2378 RVA: 0x00099430 File Offset: 0x00097630
		public a(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid A_0)
		{
			this.a = A_0;
			this.a.Loaded += this.a;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00099464 File Offset: 0x00097664
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1841889280;
			short num2 = num;
			num = (short)1362210508;
			short num3 = num;
			num = (short)666283724;
			switch (num3 == num)
			{
			}
			num = (short)871366657;
			if (num != 0)
			{
			}
			num = (short)448856064;
			if (num != 0)
			{
			}
			this.b();
			this.c();
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0009951C File Offset: 0x0009771C
		private void c()
		{
			short num = (short)1845035008;
			short num2 = num;
			num = (short)1905065985;
			if (num != 0)
			{
			}
			num = (short)1026600758;
			short num3 = num;
			num = (short)767602486;
			switch (num3 == num)
			{
			}
			num = (short)1719074816;
			if (num != 0)
			{
			}
			this.a.InitializeRecord += this.a;
			this.a.Records.CollectionChanged += this.a;
			this.a.Records.DataPresenter.SelectedItemsChanged += this.a;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00099618 File Offset: 0x00097818
		private void b()
		{
			short num = (short)1457061888;
			short num2 = num;
			num = (short)1631335529;
			short num3 = num;
			num = (short)151008361;
			switch (num3 == num)
			{
			}
			num = (short)393871360;
			if (num != 0)
			{
			}
			num = (short)1800863745;
			if (num != 0)
			{
			}
			this.a.InitializeRecord -= this.a;
			this.a.Records.CollectionChanged -= this.a;
			this.a.Records.DataPresenter.SelectedItemsChanged -= this.a;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00099714 File Offset: 0x00097914
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs A_1)
		{
			short num = (short)1172439042;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						A_1.Record.IsSelected = true;
						return;
					}
					finally
					{
						this.b = false;
					}
					goto IL_C5;
				case 1:
					goto IL_C5;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)1077552137;
				short num3 = num;
				num = (short)785720329;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_C5:
					global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.IsServerEventLocal = true;
					this.b = true;
					num = (short)1478819840;
					short num4 = num;
					num = (short)1230438401;
					if (num != 0)
					{
					}
					num = (short)1903624192;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)1160708096;
					if (num != 0)
					{
					}
					if (this.a.Records.Count != 1)
					{
						return;
					}
					num = (short)646709249;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0009987C File Offset: 0x00097A7C
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1865416704;
			short num2 = num;
			num = (short)233570309;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					this.a();
					num = (short)484442113;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_183;
				case 2:
					if (A_1.NewItems.Count != 0)
					{
						num = (short)154992650;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					if (A_1.NewItems != null)
					{
						num = (short)2144010258;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					num = (short)1441862052;
					short num4 = num;
					num = (short)1921585572;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_183;
					default:
						goto IL_3AD;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_AD;
					}
					continue;
				case 6:
					if (!this.a.IsLoadingItemsFromViewCache)
					{
						num = (short)1917911055;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					if (this.a.IsLoadingItemsFromViewCache)
					{
						num = (short)1468596244;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)825098243;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (!this.a.IsLoadingItemsFromViewCache)
					{
						num = (short)1934032896;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CB;
				case 9:
					this.a(A_1.NewItems);
					num = (short)1639776278;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)1247215639;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (A_1.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
					{
						num = (short)430178320;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CB;
				case 12:
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> source;
					if (!source.Any<global::Infragistics.Windows.DataPresenter.DataRecord>())
					{
						num = (short)758382596;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					object dataItem = source.First<global::Infragistics.Windows.DataPresenter.DataRecord>().DataItem;
					num = (short)859242517;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					goto IL_15F;
				case 14:
					num = (short)362086406;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> source = A_1.NewItems.OfType<global::Infragistics.Windows.DataPresenter.DataRecord>().ToList<global::Infragistics.Windows.DataPresenter.DataRecord>();
					num = (short)1979645964;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 16:
					num = (short)1811742721;
					if (num != 0)
					{
					}
					num = (short)644087816;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (A_1.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						num = (short)124059662;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 18:
					num = (short)1322254338;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					return;
				case 20:
					return;
				case 21:
				{
					object dataItem;
					if (dataItem is global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)
					{
						num = (short)996409353;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 22:
					goto IL_252;
				case 23:
					if (this.a.Visibility != global::System.Windows.Visibility.Visible)
					{
						num = (short)1124794381;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1295843345;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AD:
				if (!global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.IsServerEventLocal)
				{
					num = (short)1958084627;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)169017355;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_3CB:
				num = (short)763953159;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_183:
				goto IL_3CB;
			}
			return;
			IL_15F:
			return;
			IL_252:
			return;
			IL_3AD:
			num = (short)96993280;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00099CD0 File Offset: 0x00097ED0
		private void a()
		{
			short num = (short)1585905664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.a a;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::System.Guid> list;
					global::System.Collections.Generic.List<global::System.Guid> list2;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy instance = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance();
						if (instance == null)
						{
							num = (short)330235915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService localService = instance.LocalService;
						if (localService == null)
						{
							num = (short)1035206660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.KeyValuePair<global::System.Guid?, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> keyValuePair;
						list = localService.GetLastSelected(keyValuePair.Value);
						goto IL_22C;
					}
					case 1:
						num = (short)1640169481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						goto IL_310;
					case 4:
						list = null;
						goto IL_22C;
					case 5:
						return;
					case 6:
					{
						if (!a.a.Any<global::System.Collections.Generic.KeyValuePair<global::System.Guid?, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>>())
						{
							num = (short)84344834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.KeyValuePair<global::System.Guid?, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> keyValuePair = a.a.First<global::System.Collections.Generic.KeyValuePair<global::System.Guid?, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>>();
						num = (short)1209335808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (a.a != null)
						{
							num = (short)322633740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.a a2 = a;
						global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = this.a;
						global::System.Collections.Generic.Dictionary<global::System.Guid?, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> dictionary;
						if (rmdataGrid == null)
						{
							dictionary = null;
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.RecordManager recordManager = rmdataGrid.RecordManager;
							if (recordManager == null)
							{
								dictionary = null;
							}
							else
							{
								global::System.Collections.IEnumerable sourceItems = recordManager.SourceItems;
								if (sourceItems == null)
								{
									dictionary = null;
								}
								else
								{
									dictionary = sourceItems.OfType<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>().Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.<>c.<>9.a)).ToDictionary(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Guid?>(global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.<>c.<>9.b), new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>(global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.<>c.<>9.c));
								}
							}
						}
						a2.a = dictionary;
						num = (short)1597177863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (list2.Count == 0)
						{
							num = (short)425984005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b = true;
						num = (short)1972109315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (list2 != null)
						{
							num = (short)1595932672;
							short num3 = num;
							num = (short)70778881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						list = null;
						goto IL_22C;
					case 12:
						num = (short)2019164166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62;
					IL_22C:
					list2 = list;
					num = (short)646250497;
					if (num != 0)
					{
					}
					num = (short)838860810;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_310:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_3AB;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase[] array2;
					for (;;)
					{
						IL_31C:
						global::Infragistics.Windows.DataPresenter.Record[] array;
						global::Infragistics.Windows.DataPresenter.DataRecord[] recordsFromDataItems;
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
						int? num4;
						int num5;
						bool flag;
						int? num7;
						global::Infragistics.Windows.DataPresenter.Record[] array3;
						switch (num2)
						{
						case 0:
							num = (short)2020868120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!array.Except(recordsFromDataItems).Any<global::Infragistics.Windows.DataPresenter.Record>())
							{
								num = (short)731578379;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_74A;
						case 2:
							goto IL_745;
						case 3:
							if (array2.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>())
							{
								num = (short)1170931741;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_47B;
						case 4:
							num = (short)694288404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_7D4;
						case 6:
							if (this.a.ActiveRecord == dataRecord)
							{
								num = (short)201719808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.a.ActiveRecord = dataRecord;
							this.a(dataRecord);
							num = (short)983302166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (num4.GetValueOrDefault() == num5 & num4 != null)
							{
								num = (short)164102176;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_74A;
						case 8:
							goto IL_47B;
						case 9:
							goto IL_86A;
						case 10:
							goto IL_72C;
						case 11:
							num = (short)300417043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems = this.a.SelectedItems;
							if (selectedItems == null)
							{
								num = (short)784531487;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records = selectedItems.Records;
							if (records == null)
							{
								num = (short)952303621;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							records.Clear();
							num = (short)207814686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							goto IL_86A;
						case 14:
							goto IL_453;
						case 15:
						{
							global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems2 = this.a.SelectedItems;
							if (selectedItems2 == null)
							{
								num = (short)943915022;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = (selectedItems2.Records != null);
							goto IL_45D;
						}
						case 16:
							goto IL_494;
						case 17:
						{
							global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems3 = this.a.SelectedItems;
							if (selectedItems3 == null)
							{
								int? num6 = null;
								num = (short)1720188954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records2 = selectedItems3.Records;
							if (records2 == null)
							{
								int? num6 = null;
								num = (short)246415387;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num7 = new int?(records2.Count);
							goto IL_653;
						}
						case 18:
						{
							num = (short)938170902;
							short num8 = num;
							num = (short)756963862;
							switch ((num8 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_453;
							default:
								num = (short)253165568;
								if (num != 0)
								{
								}
								num = (short)2004418577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 19:
							if (!recordsFromDataItems.Except(array).Any<global::Infragistics.Windows.DataPresenter.Record>())
							{
								num = (short)1914503178;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_74A;
						case 20:
							if (recordsFromDataItems != null)
							{
								num = (short)2038693906;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_72C;
						case 21:
						{
							global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems4 = this.a.SelectedItems;
							if (selectedItems4 == null)
							{
								num = (short)2065629197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records3 = selectedItems4.Records;
							if (records3 == null)
							{
								num = (short)1039335449;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							records3.AddRange(recordsFromDataItems.OfType<global::Infragistics.Windows.DataPresenter.Record>().ToArray<global::Infragistics.Windows.DataPresenter.Record>(), false, false);
							num = (short)1910898697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
							goto IL_8FC;
						case 23:
							if (array != null)
							{
								num = (short)1895759876;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_72C;
						case 24:
							goto IL_8CD;
						case 25:
							goto IL_86A;
						case 26:
						{
							int? num6;
							num7 = num6;
							goto IL_653;
						}
						case 27:
						{
							int? num6;
							num7 = num6;
							goto IL_653;
						}
						case 28:
						{
							global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems5 = this.a.SelectedItems;
							if (selectedItems5 == null)
							{
								num = (short)874774561;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array3 = selectedItems5.Records.OfType<global::Infragistics.Windows.DataPresenter.Record>().ToArray<global::Infragistics.Windows.DataPresenter.Record>();
							goto IL_4F0;
						}
						case 29:
							num = (short)950468623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							goto IL_7D4;
						case 31:
							goto IL_7D4;
						case 32:
							num = (short)1143078913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							array3 = null;
							goto IL_4F0;
						}
						goto IL_3AB;
						IL_45D:
						if (!flag)
						{
							num = (short)70320136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1605238812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_453:
						flag = (null != null);
						goto IL_45D;
						IL_47B:
						num = (short)1456537616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4F0:
						array = array3;
						recordsFromDataItems = this.a.GetRecordsFromDataItems(array2.OfType<object>().ToArray<object>(), false);
						num = (short)11337751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_653:
						num4 = num7;
						num5 = array2.Length;
						num = (short)501940231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_72C:
						num = (short)958595074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_74A:
						num = (short)1352597516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7D4:
						num = (short)1208549397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_86A:
						dataRecord = recordsFromDataItems.FirstOrDefault<global::Infragistics.Windows.DataPresenter.DataRecord>();
						num = (short)403046406;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_494:
					IL_745:
					IL_8CD:
					IL_8FC:
					return;
					IL_3AB:
					global::System.Collections.Generic.List<global::System.Guid> list2;
					array2 = list2.Where(new global::System.Func<global::System.Guid, bool>(a.b)).Select(new global::System.Func<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>(a.c)).ToArray<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
					num = (short)954793987;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31C;
				}
				finally
				{
					this.b = false;
				}
				return;
				IL_62:
				a = new global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.a();
				num = (short)2043805704;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0009A600 File Offset: 0x00098800
		private void a(global::System.Collections.IEnumerable A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Infragistics.Windows.DataPresenter.Record[] array;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_F7;
				case 2:
				{
					num2 = (short)1152909312;
					short num3 = num2;
					num2 = (short)1101957051;
					short num4 = num2;
					num2 = (short)808486843;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F7;
					default:
						num2 = (short)144375808;
						if (num2 != 0)
						{
						}
						if (array.Any<global::Infragistics.Windows.DataPresenter.Record>())
						{
							num2 = (short)1739784193;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_1C;
				IL_F7:
				this.a.SelectedItems.Records.Clear();
				this.a.ActiveRecord = array.FirstOrDefault<global::Infragistics.Windows.DataPresenter.Record>();
				this.a.SelectedItems.Records.AddRange(array);
				num2 = (short)1605500928;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			array = A_0.OfType<global::Infragistics.Windows.DataPresenter.Record>().ToArray<global::Infragistics.Windows.DataPresenter.Record>();
			num2 = (short)1528561665;
			if (num2 != 0)
			{
			}
			num2 = (short)528744450;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0009A75C File Offset: 0x0009895C
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs A_1)
		{
			short num = (short)736952339;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_31F;
				case 1:
				{
					object dataItem;
					if (dataItem is global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)
					{
						num = (short)1292369920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1650720781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell> source = this.a.Records.DataPresenter.SelectedItems.Cells.OfType<global::Infragistics.Windows.DataPresenter.Cell>();
					num = (short)662110218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					object dataItem;
					if (dataItem is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)
					{
						num = (short)1608908804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1238827025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_1BE;
				case 5:
					return;
				case 6:
					if (!list.Any<global::Infragistics.Windows.DataPresenter.DataRecord>())
					{
						num = (short)569376770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11F;
				case 7:
					goto IL_11F;
				case 8:
				{
					object dataItem;
					if (dataItem is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)
					{
						num = (short)58064896;
						short num3 = num;
						num = (short)903806991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1231159299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.a<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(list);
					num = (short)2013134860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell> source;
					list = source.Select(new global::System.Func<global::Infragistics.Windows.DataPresenter.Cell, global::Infragistics.Windows.DataPresenter.DataRecord>(global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.<>c.<>9.a)).ToList<global::Infragistics.Windows.DataPresenter.DataRecord>();
					num = (short)1874657287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					return;
				case 12:
					goto IL_351;
				case 13:
					for (;;)
					{
						num = (short)2062090241;
						if (num != 0)
						{
						}
						object dataItem;
						if (dataItem is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)
						{
							goto Block_9;
						}
						num = (short)792533058;
						short num4 = num;
						num = (short)2130581570;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_25C;
						}
					}
					IL_25C:
					num = (short)481820672;
					if (num != 0)
					{
					}
					num = (short)1070465032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_9:
					num = (short)2129002512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
				{
					if (!list.Any<global::Infragistics.Windows.DataPresenter.DataRecord>())
					{
						num = (short)276758533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					object dataItem = list.First<global::Infragistics.Windows.DataPresenter.DataRecord>().DataItem;
					num = (short)2115633153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					goto IL_2D7;
				case 16:
					global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.a<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(list);
					num = (short)228524050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					object dataItem;
					if (dataItem is global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)
					{
						num = (short)1351417865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 18:
					return;
				case 19:
					switch (0)
					{
					case 0:
						goto IL_75;
					}
					continue;
				}
				IL_75:
				if (this.b)
				{
					num = (short)1678114827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				list = this.a.Records.DataPresenter.SelectedItems.Records.OfType<global::Infragistics.Windows.DataPresenter.DataRecord>().ToList<global::Infragistics.Windows.DataPresenter.DataRecord>();
				num = (short)339804166;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11F:
				num = (short)192675854;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_1BE:
			global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.a<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(list);
			return;
			IL_2D7:
			global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.a<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(list);
			return;
			IL_31F:
			global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.a<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(list);
			return;
			IL_351:;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0009AB68 File Offset: 0x00098D68
		private void a(global::Infragistics.Windows.DataPresenter.Record A_0)
		{
			short num = (short)2066939914;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Infragistics.Windows.DataPresenter.Record[] recordsInView;
				int num3;
				switch (num2)
				{
				case 0:
					if (recordsInView.First<global::Infragistics.Windows.DataPresenter.Record>().Index <= num3)
					{
						num = (short)252510214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 1:
					if (this.a.ScrollInfo.CanVerticallyScroll)
					{
						num = (short)932577283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_1E6;
				case 3:
					goto IL_1E4;
				case 4:
					return;
				case 5:
					if (recordsInView.Last<global::Infragistics.Windows.DataPresenter.Record>().Index < num3)
					{
						num = (short)1194065922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)450887685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1726021632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)1312913975;
					short num4 = num;
					num = (short)813988407;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E4;
					default:
					{
						num = (short)1896677376;
						if (num != 0)
						{
						}
						num = (short)103874560;
						short num5 = num;
						num = (short)1472004097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 9:
					if (recordsInView.Any<global::Infragistics.Windows.DataPresenter.Record>())
					{
						num = (short)1283653639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				}
				IL_50:
				num = (short)597557249;
				if (num != 0)
				{
				}
				if (this.a.ScrollInfo != null)
				{
					num = (short)336068616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1E4:
				num3 = this.a.Records.IndexOf(A_0);
				recordsInView = this.a.GetRecordsInView(false);
				num = (short)904658953;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E6:
				this.a.ScrollInfo.SetVerticalOffset((double)num3);
				num = (short)111149060;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0009ADE4 File Offset: 0x00098FE4
		private static void a<a>(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> A_0) where a : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			short num = (short)1760522252;
			short num2 = num;
			num = (short)1613721612;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1389035520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1668677633;
			if (num != 0)
			{
			}
			num = (short)472907776;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a<a>.b b = new global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a<a>.b();
			b.a = A_0.Select(new global::System.Func<global::Infragistics.Windows.DataPresenter.DataRecord, object>(global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a.<>c__12<a>.<>9.a)).OfType<a>().ToList<a>();
			global::System.Threading.Tasks.Task.Run(new global::System.Action(b.b));
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0009AEDC File Offset: 0x000990DC
		internal void d()
		{
			short num = (short)1819047813;
			short num2 = num;
			num = (short)1120302981;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1179779072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)986972161;
			if (num != 0)
			{
			}
			num = (short)1432748032;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0009AF8C File Offset: 0x0009918C
		internal void e()
		{
			short num = (short)1351050754;
			short num2 = num;
			num = (short)375154178;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1259208704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1639186432;
			if (num != 0)
			{
			}
			num = (short)1543897089;
			if (num != 0)
			{
			}
			this.c();
		}

		// Token: 0x0400044E RID: 1102
		private readonly global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid a;

		// Token: 0x0400044F RID: 1103
		private bool b;

		// Token: 0x0200012E RID: 302
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000958 RID: 2392 RVA: 0x0009B050 File Offset: 0x00099250
			internal bool b(global::System.Guid A_0)
			{
				short num = (short)935798249;
				short num2 = num;
				num = (short)1109403113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)428474368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1341587456;
				if (num != 0)
				{
				}
				num = (short)337248257;
				if (num != 0)
				{
				}
				return this.a.ContainsKey(new global::System.Guid?(A_0));
			}

			// Token: 0x06000959 RID: 2393 RVA: 0x0009B108 File Offset: 0x00099308
			internal global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase c(global::System.Guid A_0)
			{
				short num = (short)2066499200;
				short num2 = num;
				num = (short)471877248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1485307904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1118568449;
				if (num != 0)
				{
				}
				num = (short)1446182912;
				if (num != 0)
				{
				}
				return this.a[new global::System.Guid?(A_0)];
			}

			// Token: 0x04000450 RID: 1104
			public global::System.Collections.Generic.Dictionary<global::System.Guid?, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> a;
		}

		// Token: 0x02000130 RID: 304
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b<a> where a : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			// Token: 0x06000961 RID: 2401 RVA: 0x0009B564 File Offset: 0x00099764
			internal void b()
			{
				short num = (short)1326836789;
				short num2 = num;
				num = (short)1453386805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1316290560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)441057280;
				if (num != 0)
				{
				}
				num = (short)1764163585;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.SaveLastSelectedItemSetting<a>(this.a);
			}

			// Token: 0x04000456 RID: 1110
			public global::System.Collections.Generic.List<a> a;
		}
	}
}
