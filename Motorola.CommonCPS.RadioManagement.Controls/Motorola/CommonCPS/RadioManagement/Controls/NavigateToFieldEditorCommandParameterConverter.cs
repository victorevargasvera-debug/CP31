using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000016 RID: 22
	public class NavigateToFieldEditorCommandParameterConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00005220 File Offset: 0x00003420
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1976107008;
			switch (num)
			{
			default:
			{
				num = (short)2059403281;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
				string text;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1423507458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 1:
					{
						if (set.Fields.ContainsFieldName(text))
						{
							num = (short)1148059667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory = set.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory;
						num = (short)49807365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						set = (values[1] as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
						num = (short)118095872;
						short num3 = num;
						num = (short)1106903060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)2059730951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)27656193;
						if (num != 0)
						{
						}
						num = (short)1641414656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
						if (setCategory != null)
						{
							num = (short)1408434192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					}
					case 6:
						if (values[0] != null)
						{
							num = (short)1403584525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35A;
					case 7:
						if (values.Length == 2)
						{
							num = (short)220332043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					case 8:
						num = (short)1801256961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_35A;
					case 10:
						if (values[1] != null)
						{
							num = (short)1079508996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 11:
						goto IL_2C7;
					case 12:
						if (set != null)
						{
							num = (short)1740242952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					case 13:
						text = values[0].ToString();
						num = (short)22609929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)1340820483;
						short num4 = num;
						num = (short)1893551107;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_33D;
						default:
							num = (short)1765933056;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1223229445;
								num2 = (int)((global::System.IntPtr)num);
								object result;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_25D;
									case 1:
										num = (short)1162346499;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
										if (fieldBase.IsVisible)
										{
											num = (short)379977736;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										goto IL_2B7;
									case 4:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
										if (fieldBase != null)
										{
											num = (short)629735431;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_1BA;
										}
										continue;
									case 6:
									{
										global::System.Collections.Generic.List<string>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)643760129;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string fieldName = enumerator.Current;
										global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase = set.Fields[fieldName];
										num = (short)1742667780;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										num = (short)924909570;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
										result = fieldBase;
										num = (short)293339136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_205:
									num = (short)1244856326;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1BA:
									goto IL_205;
								}
								IL_25D:
								return result;
								IL_2B7:
								goto IL_318;
							}
							finally
							{
								global::System.Collections.Generic.List<string>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_2C7;
						}
						break;
					}
					case 15:
						num = (short)797638668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
						global::System.Collections.Generic.List<string> childFields = setCategory.GetChildFields(text, set.SetType);
						global::System.Collections.Generic.List<string>.Enumerator enumerator = childFields.GetEnumerator();
						num = (short)2047475726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					case 18:
						if (!string.IsNullOrEmpty(text))
						{
							goto IL_33D;
						}
						goto IL_318;
					case 19:
						goto IL_142;
					case 20:
						goto IL_31A;
					}
					IL_9A:
					if (values == null)
					{
						num = (short)1563164675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2C7:
					text = string.Empty;
					set = null;
					num = (short)2044723206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31A:
					num = (short)32178194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33D:
					num = (short)72679439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35A:
					num = (short)1812922378;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_142:
				return set.Fields[text];
				IL_318:
				return null;
			}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005794 File Offset: 0x00003994
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)662585456;
			short num2 = num;
			num = (short)499138672;
			switch (num2 == num)
			{
			}
			num = (short)86966272;
			short num3 = num;
			num = (short)909180929;
			if (num != 0)
			{
			}
			num = (short)966459392;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
