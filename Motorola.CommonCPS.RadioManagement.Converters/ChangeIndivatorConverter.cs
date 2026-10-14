using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200004D RID: 77
	public class ChangeIndivatorConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x0000C848 File Offset: 0x0000AA48
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1877671937;
			if (num != 0)
			{
			}
			num = (short)725856593;
			short num2 = num;
			num = (short)679063889;
			switch (num2 == num)
			{
			}
			num = (short)905183232;
			short num3 = num;
			num = (short)50200576;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Converters.ChangeIndivatorConverter.ConvertChangeIndicatorToString((int)value);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)870441599;
			short num2 = num;
			num = (short)257352319;
			switch (num2 == num)
			{
			}
			num = (short)991690753;
			if (num != 0)
			{
			}
			num = (short)940900352;
			short num3 = num;
			num = (short)792330240;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000C9AC File Offset: 0x0000ABAC
		public static string ConvertChangeIndicatorToString(int changeIndicator)
		{
			int a_ = 16;
			short num = (short)1975451648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BC;
				}
				global::System.Collections.Generic.IList<string> list;
				string text2;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.IEnumerator<string> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1511391233;
						if (num != 0)
						{
						}
						list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_VoiceFilesModified);
						num = (short)753926155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_493;
					case 2:
						if ((changeIndicator & 1) == 1)
						{
							num = (short)646119438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F6;
					case 3:
						num = (short)1581973506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FlashCodeModified);
						num = (short)590610439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if ((changeIndicator & 2) == 2)
						{
							num = (short)1341390867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18D;
					case 6:
						goto IL_6B5;
					case 7:
						goto IL_723;
					case 8:
						if ((changeIndicator & 256) == 256)
						{
							num = (short)242548757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_100;
					case 9:
						list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ProvisioningPackage_Modified);
						num = (short)1324679174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if ((changeIndicator & 512) == 512)
						{
							num = (short)833683471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_643;
					case 11:
						goto IL_5DD;
					case 12:
						try
						{
							num = (short)12845059;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text;
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										goto IL_2CB;
									}
									text = enumerator.Current;
									num = (short)990707717;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)746323977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_2AC;
									}
									continue;
								case 4:
									goto IL_365;
								case 5:
									if (!string.IsNullOrEmpty(text2))
									{
										num = (short)173670401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_365;
								case 7:
									goto IL_421;
								case 8:
									num = (short)869990407;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									if (string.IsNullOrEmpty(text))
									{
										num = (short)2091778052;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2123870422;
									short num3 = num;
									num = (short)2001842390;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2CB;
									default:
										num = (short)578551808;
										if (num != 0)
										{
										}
										text2 = text2 + global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("\udbfa\udbfc\udffe", a_) + text;
										num = (short)1529348102;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_2AE:
								num = (short)85590016;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2AC:
								goto IL_2AE;
								IL_2CB:
								num = (short)898957320;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_365:
								text2 += text;
								num = (short)245825538;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_421:
							return text2;
						}
						finally
						{
							num = (short)877068290;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1644494849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_490;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_45A;
									}
									continue;
								}
								IL_45A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1501560832;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_490:;
						}
						goto IL_493;
					case 13:
						if (changeIndicator != -1)
						{
							num = (short)994508803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50A;
					case 14:
						list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_CodeplugModified);
						num = (short)2145058848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBBLicense_Modified);
						num = (short)848232476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_LanguagePackModified);
						num = (short)581304340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_147;
					case 18:
						goto IL_18D;
					case 19:
						list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FirmwareModified);
						num = (short)77332498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_534;
					case 21:
						list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_APKApplication_Modified);
						num = (short)340918294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_100;
					case 23:
						if ((changeIndicator & 16) == 16)
						{
							num = (short)1085014020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_723;
					case 24:
						goto IL_50A;
					case 25:
						if ((changeIndicator & 128) == 128)
						{
							num = (short)1807745033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B5;
					case 26:
					{
						num = (short)848297984;
						short num4 = num;
						list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBBHomeSet_Modified);
						num = (short)1878917144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						if ((changeIndicator & 2048) == 2048)
						{
							num = (short)663420954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50A;
					case 28:
						goto IL_643;
					case 29:
						if ((changeIndicator & 32) == 32)
						{
							num = (short)852492289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147;
					case 30:
						if ((changeIndicator & 4) == 4)
						{
							num = (short)884736000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DD;
					case 31:
						if ((changeIndicator & 8) == 8)
						{
							num = (short)1162412048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 32:
						goto IL_1F6;
					}
					goto IL_BC;
					IL_100:
					num = (short)1937113098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_147:
					num = (short)1784807449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18D:
					num = (short)361758750;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F6:
					num = (short)1822228485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_493:
					list.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RadioLicenseModified);
					num = (short)1166868497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50A:
					text2 = string.Empty;
					enumerator = list.GetEnumerator();
					num = (short)1053491212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_534:
					num = (short)1977548823;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5DD:
					num = (short)848298015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_643:
					num = (short)1554055195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B5:
					num = (short)351010824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_723:
					num = (short)1349058589;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text2;
				IL_BC:
				list = new global::System.Collections.Generic.List<string>();
				num = (short)783810573;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}
	}
}
