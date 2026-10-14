using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000123 RID: 291
	internal class NumericFieldToBitmapItemSrouceConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000928 RID: 2344 RVA: 0x00097484 File Offset: 0x00095684
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1203765248;
			switch (num)
			{
			default:
			{
				num = (short)652148736;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.Controls.NumericFieldToBitmapItemSrouceConverter.ValuePair> observableCollection;
				for (;;)
				{
					int num5;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_75;
						}
						continue;
					case 1:
					{
						num = (short)87425024;
						short num3 = num;
						goto IL_11A;
					}
					case 2:
					{
						num = (short)2060200909;
						short num4 = num;
						num = (short)844377037;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1481572352;
							if (num != 0)
							{
							}
							int num6;
							if (num5 >= num6)
							{
								num = (short)1575682057;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)619511812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						goto IL_1E2;
					case 4:
					{
						string text;
						if (num5 < text.Length)
						{
							num = (short)1693450251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.Controls.NumericFieldToBitmapItemSrouceConverter.ValuePair
						{
							Index = num5 + 1,
							Value = '0'
						});
						num = (short)647626757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1E7;
					case 6:
						num = (short)1612120071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (values[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.NullField)
						{
							num = (short)1880162307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int value = global::System.Convert.ToInt32(values[0], global::System.Globalization.CultureInfo.CurrentCulture);
						int num6 = (int)values[1];
						observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.Controls.NumericFieldToBitmapItemSrouceConverter.ValuePair>();
						string text = global::System.Convert.ToString(value, 2);
						char[] array = text.ToCharArray();
						global::System.Array.Reverse(array);
						text = new string(array);
						num5 = 0;
						num = (short)1700528129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_1E7;
					case 9:
						goto IL_19E;
					case 10:
						goto IL_11A;
					case 11:
					{
						string text;
						observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.Controls.NumericFieldToBitmapItemSrouceConverter.ValuePair
						{
							Index = num5 + 1,
							Value = text[num5]
						});
						num = (short)533135368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_75:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)485752838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_11A:
					num = (short)495452162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E7:
					num5++;
					num = (short)164560906;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_118:
				return null;
				IL_19E:
				num = (short)206045185;
				if (num != 0)
				{
				}
				return observableCollection;
				IL_1E2:
				goto IL_118;
			}
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00097790 File Offset: 0x00095990
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)498689304;
			short num2 = num;
			num = (short)836723992;
			switch (num2 == num)
			{
			}
			num = (short)2131820544;
			short num3 = num;
			num = (short)1988820993;
			if (num != 0)
			{
			}
			num = (short)1966997504;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x02000124 RID: 292
		public class ValuePair : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			// Token: 0x17000187 RID: 391
			// (get) Token: 0x0600092B RID: 2347 RVA: 0x00097854 File Offset: 0x00095A54
			// (set) Token: 0x0600092C RID: 2348 RVA: 0x00097904 File Offset: 0x00095B04
			public int Index
			{
				get
				{
					short num = (short)5874567;
					short num2 = num;
					num = (short)2005508999;
					switch (num2 == num)
					{
					}
					num = (short)487391232;
					short num3 = num;
					num = (short)1493696512;
					if (num != 0)
					{
					}
					num = (short)2107899905;
					if (num != 0)
					{
					}
					return this.a;
				}
				set
				{
					for (;;)
					{
						IL_00:
						short num = (short)1219231745;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								return;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_39;
								}
								continue;
							case 2:
							{
								num = (short)921788430;
								short num3 = num;
								num = (short)521953294;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_00;
								default:
								{
									num = (short)340459520;
									short num4 = num;
									num = (short)1068892160;
									if (num != 0)
									{
									}
									this.a = value;
									num = (short)1934032899;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 3:
								if (!base.IsLoading)
								{
									num = (short)1575485444;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return;
							case 4:
								base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Controls.NumericFieldToBitmapItemSrouceConverter.ValuePair)), methodof(global::Motorola.CommonCPS.RadioManagement.Controls.NumericFieldToBitmapItemSrouceConverter.ValuePair.a())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1372651520;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_39:
							num = (short)1974861825;
							if (num != 0)
							{
							}
							if (this.a == value)
							{
								return;
							}
							num = (short)1699086338;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x0600092D RID: 2349 RVA: 0x00097A98 File Offset: 0x00095C98
			// (set) Token: 0x0600092E RID: 2350 RVA: 0x00097B48 File Offset: 0x00095D48
			public char Value
			{
				get
				{
					short num = (short)594561368;
					short num2 = num;
					num = (short)363481432;
					switch (num2 == num)
					{
					}
					num = (short)1432289280;
					short num3 = num;
					num = (short)1086980097;
					if (num != 0)
					{
					}
					num = (short)2091057152;
					if (num != 0)
					{
					}
					return this.b;
				}
				set
				{
					for (;;)
					{
						IL_00:
						short num = (short)173342721;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								return;
							case 1:
								num = (short)1550057473;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_60;
								}
								continue;
							case 2:
							{
								num = (short)1311595906;
								short num3 = num;
								num = (short)294346114;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_00;
								default:
								{
									num = (short)762249216;
									short num4 = num;
									num = (short)2060451840;
									if (num != 0)
									{
									}
									this.b = value;
									num = (short)1729626115;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 3:
								if (!base.IsLoading)
								{
									num = (short)498401284;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return;
							case 4:
								base.RaisePropertyChanged<char>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<char>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Controls.NumericFieldToBitmapItemSrouceConverter.ValuePair)), methodof(global::Motorola.CommonCPS.RadioManagement.Controls.NumericFieldToBitmapItemSrouceConverter.ValuePair.b())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)487915520;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_60:
							if (this.b == value)
							{
								return;
							}
							num = (short)469237762;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
				}
			}

			// Token: 0x0400043F RID: 1087
			private int a;

			// Token: 0x04000440 RID: 1088
			private char b;
		}
	}
}
