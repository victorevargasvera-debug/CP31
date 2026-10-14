using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200000D RID: 13
	public class FilePathToFilePathWithEllipsisConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00003488 File Offset: 0x00001688
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 8;
			short num = (short)567083008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string text;
				for (;;)
				{
					IL_26:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					int num5;
					for (;;)
					{
						IL_30:
						num = (short)1514209280;
						short num3 = num;
						string text2;
						string text3;
						string result;
						switch (num2)
						{
						case 0:
						{
							num = (short)537408233;
							short num4 = num;
							num = (short)1546334953;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_26;
							default:
								num = (short)605224960;
								if (num != 0)
								{
								}
								num = (short)2099380225;
								if (num != 0)
								{
								}
								try
								{
									num = (short)1977090057;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(text, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("귲\uddf4죶엸韺飼駾甀眂樄氆氈攊㌌匎䴐伒䤔䰖䜘䜚䄜䈞ਠਢ礤符", a_));
											if (!match.Success)
											{
												goto Block_4;
											}
											text2 = match.Groups[global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("鿲郴釶跸迺鋼链搀洂", a_)].Value;
											num = (short)1632370702;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											goto IL_23E;
										case 2:
											goto IL_1F9;
										case 3:
											text2 = this.a(text2, text2.Length - num5 / 4);
											num = (short)4784129;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
										{
											if (this.b(text3))
											{
												num = (short)951517190;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											int a_2 = text2.Length + text3.Length - num5;
											text3 = this.a(text3, a_2);
											num = (short)1381498891;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
											goto IL_1F9;
										case 6:
											text3 = this.c(text3);
											num = (short)1231093765;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 7:
											if (this.b(text3))
											{
												num = (short)600834064;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_1F9;
										case 8:
											if (text2.Length + text3.Length <= num5)
											{
												num = (short)2037055503;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1000734724;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 9:
											switch (0)
											{
											case 0:
												goto IL_129;
											}
											continue;
										case 10:
											num = (short)1913061376;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 11:
											goto IL_3C3;
										case 12:
											goto IL_3E4;
										case 13:
											goto IL_23E;
										case 14:
											if (text2.Length > num5 / 4)
											{
												num = (short)664141827;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_23E;
										case 15:
											goto IL_3C3;
										case 16:
											text3 = this.c(text3);
											text2 += global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꿲폔꯶", a_);
											num = (short)1510932482;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_129:
										if (this.a(text))
										{
											num = (short)1580793866;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										text2 = text.Substring(0, 2);
										num = (short)1496055821;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_1F9:
										num = (short)1886388232;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_23E:
										text3 = text.Substring(text2.Length);
										num = (short)1780547591;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_3C3:
										result = text2 + text3;
										num = (short)1808203788;
										num2 = (int)((global::System.IntPtr)num);
									}
									Block_4:
									throw new global::System.Exception(string.Format(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뫲鯴臶飸韺铼鯾℀攂氄欆氈⬊紌渎攐笒㔔氖⤘昚", a_), text));
									IL_3E4:
									return result;
								}
								catch
								{
									return this.a(text, text.Length - num5);
								}
								goto IL_400;
							}
							break;
						}
						case 1:
							if (num5 >= text.Length)
							{
								num = (short)460587010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_400;
						case 2:
							return text;
						}
						break;
						IL_400:
						text2 = string.Empty;
						text3 = string.Empty;
						result = string.Empty;
						num = (short)805502976;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_6C:
					text = value.ToString();
					num5 = int.Parse(parameter.ToString());
					num = (short)827523073;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				return text;
			}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003958 File Offset: 0x00001B58
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1166671872;
			short num2 = num;
			num = (short)1296663264;
			short num3 = num;
			num = (short)1226736352;
			switch (num3 == num)
			{
			}
			num = (short)1692073985;
			if (num != 0)
			{
			}
			num = (short)1880883200;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003A08 File Offset: 0x00001C08
		private string a(string A_0, int A_1)
		{
			int a_ = 2;
			short num = (short)1650917376;
			short num2 = num;
			num = (short)442458898;
			short num3 = num;
			num = (short)1937793810;
			switch (num3 == num)
			{
			}
			num = (short)1168048129;
			if (num != 0)
			{
			}
			num = (short)1244135424;
			if (num != 0)
			{
			}
			A_1++;
			int startIndex = A_0.Length / 2 - A_1 / 2;
			return A_0.Remove(startIndex, A_1).Insert(startIndex, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("쯌", a_));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003AE8 File Offset: 0x00001CE8
		private string c(string A_0)
		{
			short num = (short)1551171584;
			short num2 = num;
			num = (short)1723458558;
			short num3 = num;
			num = (short)436855806;
			switch (num3 == num)
			{
			}
			num = (short)1071579136;
			if (num != 0)
			{
			}
			num = (short)1224605697;
			if (num != 0)
			{
			}
			return A_0.Substring(A_0.Substring(1).IndexOf('\\') + 2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003BA8 File Offset: 0x00001DA8
		private bool b(string A_0)
		{
			int a_ = 5;
			short num = (short)200867840;
			short num2 = num;
			num = (short)1114963969;
			if (num != 0)
			{
			}
			num = (short)270838670;
			short num3 = num;
			num = (short)771468174;
			switch (num3 == num)
			{
			}
			num = (short)1097859072;
			if (num != 0)
			{
			}
			return A_0.Contains(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("곯", a_));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003C70 File Offset: 0x00001E70
		private bool a(string A_0)
		{
			int a_ = 2;
			short num = (short)196018176;
			short num2 = num;
			num = (short)2135220526;
			short num3 = num;
			num = (short)248701230;
			switch (num3 == num)
			{
			}
			num = (short)1109196801;
			if (num != 0)
			{
			}
			num = (short)1224998912;
			if (num != 0)
			{
			}
			return A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뇬돮", a_));
		}
	}
}
