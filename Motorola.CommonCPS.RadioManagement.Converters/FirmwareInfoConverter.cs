using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000093 RID: 147
	public class FirmwareInfoConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001BD RID: 445 RVA: 0x00016C90 File Offset: 0x00014E90
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 4;
			short num = (short)1120993280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)8912896;
				short num3 = num;
				num = (short)937295873;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				object result;
				try
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> observableCollection;
					switch (0)
					{
					case 0:
						break;
					default:
						for (;;)
						{
							IL_86:
							switch (num2)
							{
							case 0:
								goto IL_EF;
							case 1:
								result = list;
								num = (short)1729167360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (observableCollection == null)
								{
									num = (short)1807024129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1004472676;
								short num4 = num;
								num = (short)1668286820;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_A8;
								default:
								{
									num = (short)166920192;
									if (num != 0)
									{
									}
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> enumerator = observableCollection.GetEnumerator();
									num = (short)1419116548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 3:
								goto IL_356;
							case 4:
								try
								{
									num = (short)236978179;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware;
											if (firmware == null)
											{
												num = (short)1862926342;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											list.Add(string.Concat(new string[]
											{
												global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Firmware,
												global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("헮", a_),
												firmware.Version,
												global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("쿮\udcf0폲", a_),
												firmware.Name
											}));
											num = (short)1912799239;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											goto IL_2CB;
										case 3:
											switch (0)
											{
											case 0:
												goto IL_1A7;
											}
											continue;
										case 4:
											num = (short)688324610;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
										{
											global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> enumerator;
											if (!enumerator.MoveNext())
											{
												num = (short)1971912708;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware = enumerator.Current;
											num = (short)1593704448;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
											list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable);
											num = (short)1914634241;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1A9:
										num = (short)511115269;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_1A7:
										goto IL_1A9;
									}
									IL_2CB:;
								}
								finally
								{
									num = (short)2084438016;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> enumerator;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_301;
											}
											continue;
										case 1:
											enumerator.Dispose();
											num = (short)282918914;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_338;
										}
										IL_301:
										if (enumerator == null)
										{
											break;
										}
										num = (short)12648449;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_338:;
								}
								result = list;
								num = (short)944242691;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A1;
						}
						IL_EF:
						IL_356:
						return result;
					}
					IL_A1:
					observableCollection = (value as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>);
					IL_A8:
					num = (short)1005846530;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_86;
				}
				catch
				{
					result = list;
				}
				return result;
			}
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00017030 File Offset: 0x00015230
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)843740423;
			short num2 = num;
			num = (short)1626502407;
			switch (num2 == num)
			{
			}
			num = (short)514392064;
			short num3 = num;
			num = (short)1896349697;
			if (num != 0)
			{
			}
			num = (short)1694171136;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
