using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000050 RID: 80
	public class CheckforPasswordCollectionConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x0000D748 File Offset: 0x0000B948
		public object Convert(object[] value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)271122432;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)492044288;
				short num3 = num;
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				object result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy> observableCollection;
					for (;;)
					{
						IL_59:
						switch (num2)
						{
						case 0:
							goto IL_C4;
						case 1:
						{
							if (observableCollection == null)
							{
								num = (short)592707588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName = (global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName)value[1];
							bool flag = (bool)value[2];
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy> enumerator = observableCollection.GetEnumerator();
							num = (short)242221058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)2060255233;
							if (num != 0)
							{
							}
							try
							{
								num = (short)517472258;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy pcrpasswordPolicy;
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)973602824;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										pcrpasswordPolicy = enumerator.Current;
										num = (short)931594241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
									{
										global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName;
										bool flag;
										if (regionName == global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.EMEA || flag)
										{
											num = (short)913309701;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_221;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_16D;
										}
										continue;
									case 3:
										if (pcrpasswordPolicy != global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy.ReadWrite)
										{
											num = (short)435290116;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 4:
										goto IL_221;
									case 5:
										num = (short)429260803;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_264;
									case 8:
										num = (short)1155989511;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_16F:
									num = (short)1013121024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_16D:
									goto IL_16F;
									IL_221:
									list.Add(pcrpasswordPolicy.ToResourceString());
									num = (short)224329734;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_264:;
							}
							finally
							{
								num = (short)704970753;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy> enumerator;
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)395575298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										num = (short)697546265;
										short num4 = num;
										num = (short)1646310937;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											continue;
										default:
											num = (short)1794506752;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_2E9;
											}
											continue;
										}
										break;
									}
									case 2:
										goto IL_322;
									}
									IL_2E9:
									if (enumerator == null)
									{
										break;
									}
									num = (short)281411584;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_322:;
							}
							result = list;
							num = (short)1527250947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_340;
						case 4:
							result = list;
							num = (short)948502528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74;
					}
					IL_C4:
					IL_340:
					return result;
					IL_74:
					observableCollection = (value[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy>);
					num = (short)1382612993;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_59;
				}
				catch (global::System.Exception)
				{
					result = list;
				}
				return result;
			}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)402022980;
			short num2 = num;
			num = (short)586113604;
			switch (num2 == num)
			{
			}
			num = (short)367001600;
			if (num != 0)
			{
			}
			num = (short)2012807169;
			if (num != 0)
			{
			}
			num = (short)104267776;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
