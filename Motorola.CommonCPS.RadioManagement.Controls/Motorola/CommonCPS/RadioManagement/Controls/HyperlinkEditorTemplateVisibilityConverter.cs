using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000014 RID: 20
	public class HyperlinkEditorTemplateVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00004850 File Offset: 0x00002A50
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)717488128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
				for (;;)
				{
					IL_27:
					global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
					string text;
					switch (num2)
					{
					case 0:
						if (values.Length == 2)
						{
							num = (short)448528406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_170;
					case 1:
						if (values[1] != null)
						{
							num = (short)923992077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50E;
					case 2:
					{
						if (set.Fields.ContainsFieldName(text))
						{
							num = (short)1449459713;
							if (num != 0)
							{
							}
							num = (short)375521295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory = set.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory;
						num = (short)1445855249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (set != null)
						{
							num = (short)1257308174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_170;
					case 4:
						if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1188298763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50E;
					case 5:
						goto IL_351;
					case 6:
						goto IL_131;
					case 7:
						if (fieldBase != null)
						{
							num = (short)2039414789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_605;
					case 8:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)448921624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_170;
					case 9:
					{
						if (fieldBase.IsVisible)
						{
							goto IL_605;
						}
						num = (short)1115112802;
						short num3 = num;
						num = (short)1553810786;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4E3;
						default:
						{
							num = (short)1959854080;
							short num4 = num;
							num = (short)453574656;
							if (num != 0)
							{
							}
							num = (short)7995412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 10:
						num = (short)2027749376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						set = (values[1] as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
						num = (short)1724317708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_50E;
					case 13:
						num = (short)699203588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)634126338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						fieldBase = set.Fields[text];
						num = (short)839122963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (values[0] != null)
						{
							num = (short)1318584341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131;
					case 17:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
						if (setCategory != null)
						{
							num = (short)558432279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_170;
					}
					case 18:
						try
						{
							num = (short)2135621640;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)238485508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string fieldName = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase2 = set.Fields[fieldName];
									num = (short)1382416387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase2;
									if (fieldBase2.IsVisible)
									{
										num = (short)64749573;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase2;
									if (fieldBase2 != null)
									{
										num = (short)1006829575;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)1441464326;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase2;
									fieldBase = fieldBase2;
									num = (short)1844969474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_33E;
								case 7:
									num = (short)67371009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_23D;
									}
									continue;
								}
								IL_23F:
								num = (short)310312960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_23D:
								goto IL_23F;
							}
							IL_33E:
							goto IL_170;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_351;
					case 19:
						goto IL_170;
					case 20:
						goto IL_400;
					case 21:
						text = values[0].ToString();
						num = (short)1645215750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_4E3;
					case 23:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
						global::System.Collections.Generic.List<string> childFields = setCategory.GetChildFields(text, set.SetType);
						global::System.Collections.Generic.List<string>.Enumerator enumerator = childFields.GetEnumerator();
						num = (short)585105426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						num = (short)1534263299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (values == null)
						{
							num = (short)1175191562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AD;
					}
					goto IL_96;
					IL_131:
					num = (short)948305921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_170:
					num = (short)971243527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AD:
					text = string.Empty;
					set = null;
					num = (short)1630732304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E3:
					goto IL_1AD;
					IL_351:
					num = (short)2004549641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50E:
					num = (short)175570952;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_400:
				return global::System.Windows.Visibility.Collapsed;
				IL_605:
				return global::System.Windows.Visibility.Visible;
				IL_96:
				fieldBase = null;
				num = (short)510001177;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004E84 File Offset: 0x00003084
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)946344482;
			short num2 = num;
			num = (short)1269305890;
			switch (num2 == num)
			{
			}
			num = (short)490602496;
			short num3 = num;
			num = (short)1655308289;
			if (num != 0)
			{
			}
			num = (short)345505792;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
