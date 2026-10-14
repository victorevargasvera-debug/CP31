using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using authAES;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001B RID: 27
	public class CodeplugParseHelper
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x000189B0 File Offset: 0x00016BB0
		public static bool ReadEncryptPasswordFlag(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)1833038107;
			short num2 = num;
			num = (short)1808789787;
			int num3;
			bool result;
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_35C:
				try
				{
					num = (short)1662058501;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_2CB;
						case 1:
							result = true;
							num = (short)959315977;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							int num4 = value.Data.Length;
							value = keyValuePair.Value;
							global::Motorola.Common.Communication.CodeplugParseHelper.a(value.Data, 1, num4 - 3);
							int num5 = 1;
							value = keyValuePair.Value;
							num = (short)898236419;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							int num5;
							if ((value.Data[num5] & 1) != 0)
							{
								num = (short)1713831937;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = false;
							num = (short)403963912;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1083637766;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)980877319;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_167;
							}
							continue;
						case 6:
							num = (short)173932544;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 903)
							{
								num = (short)10485762;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							goto IL_20D;
						case 9:
							goto IL_22D;
						}
						IL_169:
						num = (short)427884548;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_167:
						goto IL_169;
					}
					IL_20D:
					IL_22D:
					IL_2CB:
					return result;
				}
				finally
				{
					num = (short)992739328;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_304;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)663879682;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_33A;
						}
						IL_304:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1717698561;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_33A:;
				}
				goto IL_33D;
			default:
				num = (short)335478784;
				if (num != 0)
				{
				}
				num = (short)1644822528;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					break;
				}
				break;
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
			for (;;)
			{
				IL_71:
				switch (num3)
				{
				case 0:
					if (codeplugInIshItemCollection.Count > 0)
					{
						num = (short)591790081;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					goto IL_C4;
				case 2:
					goto IL_35C;
				}
				goto IL_84;
			}
			IL_C4:
			num = (short)1728970753;
			if (num != 0)
			{
			}
			num = (short)549388288;
			short num6 = num;
			goto IL_33D;
			IL_84:
			codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
			result = false;
			num = (short)668139520;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_71;
			IL_33D:
			enumerator = codeplugInIshItemCollection.GetEnumerator();
			num = (short)938409986;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_71;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00018D3C File Offset: 0x00016F3C
		private static bool a(byte A_0, int A_1)
		{
			short num = (short)523173625;
			short num2 = num;
			num = (short)1191706361;
			switch (num2 == num)
			{
			}
			num = (short)45088769;
			if (num != 0)
			{
			}
			num = (short)1723269120;
			if (num != 0)
			{
			}
			num = (short)2126381056;
			short num3 = num;
			return ((int)A_0 & 1 << A_1) != 0;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00018DF4 File Offset: 0x00016FF4
		public static bool ReadOutOfBoxExperienceFlag(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)754761133;
			short num2 = num;
			num = (short)1175829933;
			byte[] data;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1614479360;
				if (num != 0)
				{
				}
				num = (short)921894912;
				short num3 = num;
				num = (short)1673199617;
				if (num != 0)
				{
				}
				num = (short)724303873;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)136511490;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_D3;
						}
						continue;
					case 2:
						if (data.Length <= 164)
						{
							num = (short)1172832259;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_188;
					case 3:
						return false;
					case 4:
						if (data != null)
						{
							num = (short)2029191168;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					IL_D3:
					data = pba.GetCodeplugInIshItemCollection().FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>, bool>(global::Motorola.Common.Communication.CodeplugParseHelper.<>c.<>9.a)).Value.Data;
					num = (short)437780484;
					num4 = (int)((global::System.IntPtr)num);
				}
				return false;
			}
			}
			IL_188:
			return global::Motorola.Common.Communication.CodeplugParseHelper.a(data[164], 2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00018F98 File Offset: 0x00017198
		public static void UpdateOutOfBoxExperienceFlagToFalse(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)1417674752;
			switch (num)
			{
			default:
			{
				num = (short)1989148672;
				short num2 = num;
				num = (short)763428865;
				int num3 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
				global::Motorola.Common.Communication.CommonUtil.IshItem value;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						value = keyValuePair.Value;
						num = (short)931921922;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 2:
						if (value.Data.Length <= 164)
						{
							num = (short)844759043;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BC;
					case 3:
						goto IL_D8;
					case 4:
					{
						num = (short)590489394;
						short num4 = num;
						num = (short)1747920690;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)452591616;
							if (num != 0)
							{
							}
							if (value.Data != null)
							{
								num = (short)1396178944;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_194;
						}
						break;
					}
					}
					IL_80:
					keyValuePair = pba.GetCodeplugInIshItemCollection().FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>, bool>(global::Motorola.Common.Communication.CodeplugParseHelper.<>c.<>9.b));
					value = keyValuePair.Value;
					num = (short)1877540868;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_D8:
				IL_194:
				num = (short)768999425;
				if (num != 0)
				{
				}
				return;
				IL_1BC:
				int num5 = -5;
				value = keyValuePair.Value;
				byte[] data = value.Data;
				int num6 = 164;
				data[num6] &= (byte)num5;
				value = keyValuePair.Value;
				byte[] data2 = value.Data;
				int start = 0;
				value = keyValuePair.Value;
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data2, start, value.Data.Length - 2);
				return;
			}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000191B0 File Offset: 0x000173B0
		public static string ReadEncryptPassword(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)496444252;
			short num2 = num;
			num = (short)2122720092;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)124452864;
				if (num != 0)
				{
				}
				num = (short)944832512;
				switch (num)
				{
				}
				break;
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
			string result = string.Empty;
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
			try
			{
				num = (short)1672675330;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_1F5;
					case 1:
						goto IL_212;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_C2;
						}
						continue;
					case 3:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader key;
						if (key.IshType == 1150)
						{
							num = (short)1134034948;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)554041345;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						int num4 = keyValuePair.Value.Data.Length;
						global::Motorola.Common.Communication.CodeplugParseHelper.a(keyValuePair.Value.Data, 1, num4 - 3);
						int sourceIndex = 1;
						int num5 = 48;
						byte[] array = new byte[num5];
						global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array, 0, num5);
						result = global::authAES.AESCryptography.HEXString(array);
						num = (short)1150091264;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1909784582;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
						global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
						num = (short)168099843;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)406323201;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_137:
					num = (short)1907884037;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_C2:
					goto IL_137;
				}
				IL_1F5:
				IL_212:;
			}
			finally
			{
				num = (short)1310064640;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_247;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)784662530;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_27D;
					}
					IL_247:
					if (enumerator == null)
					{
						break;
					}
					num = (short)840892417;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_27D:;
			}
			num = (short)2026962944;
			short num6 = num;
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00019484 File Offset: 0x00017684
		public static string ReadClearPassword(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)1409638929;
			short num2 = num;
			num = (short)959799825;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1648427008;
				if (num != 0)
				{
				}
				num = (short)1877475328;
				switch (num)
				{
				}
				break;
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
			string text = string.Empty;
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
			try
			{
				num = (short)1859256322;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_208;
					case 1:
						goto IL_227;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_BD;
						}
						continue;
					case 3:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader key;
						if (key.IshType == 1028)
						{
							num = (short)2061500420;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						int num4 = keyValuePair.Value.Data.Length;
						global::Motorola.Common.Communication.CodeplugParseHelper.a(keyValuePair.Value.Data, 1, num4 - 3);
						int sourceIndex = 103;
						int num5 = 34;
						byte[] array = new byte[num5];
						global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array, 0, num5);
						text = global::authAES.AESCryptography.HEXString(array);
						sourceIndex = 155;
						byte[] array2 = new byte[num5];
						global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array2, 0, num5);
						text += global::authAES.AESCryptography.HEXString(array2);
						num = (short)1065222144;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2060582918;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
						global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
						num = (short)2100887555;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1331167233;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_10F:
					num = (short)2120876037;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_BD:
					goto IL_10F;
				}
				IL_208:
				IL_227:;
			}
			finally
			{
				num = (short)2094661632;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_25B;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)162201602;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_291;
					}
					IL_25B:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1112408065;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_291:;
			}
			num = (short)964558848;
			short num6 = num;
			num = (short)1369702401;
			if (num != 0)
			{
			}
			return text;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00019794 File Offset: 0x00017994
		private static void b(global::Motorola.Common.Communication.CommonUtil.IshItem A_0, byte[] A_1, byte[] A_2, int A_3, int A_4, int A_5, int A_6, bool A_7)
		{
			short num = (short)1390804992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				string text2;
				int num4;
				byte[] array2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						string text;
						int num3;
						if (text[num3] != '0')
						{
							num = (short)1226965003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)396165125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_296;
					case 2:
					{
						string text3;
						text2 = global::authAES.AESCryptography.AESDecrypt_Ex(text3, A_2, 0, 4);
						num = (short)1095106575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_310;
					case 4:
						goto IL_470;
					case 5:
						goto IL_3B4;
					case 6:
						text2 = string.Empty;
						num = (short)1242628104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						byte[] array = global::authAES.AESCryptography.HexString2Bytes(global::authAES.AESCryptography.AESEncrypt_Ex(text2, A_2, 0, 4));
						if (array.Length != A_3)
						{
							goto Block_3;
						}
						global::System.Array.Copy(array, 0, A_0.Data, A_5 + num4 * A_4, A_3);
						num4++;
						num = (short)942080010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_310;
					case 9:
					{
						bool flag;
						if (flag)
						{
							num = (short)1400307718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1284636684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_435;
					case 11:
					{
						bool flag = false;
						num = (short)569442324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						if (A_7)
						{
							num = (short)197525506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text3;
						text2 = global::authAES.AESCryptography.AESDecrypt_Ex(text3, A_1, 0, 4);
						num = (short)1609760771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_34D;
					case 14:
						goto IL_233;
					case 15:
						goto IL_310;
					case 16:
					{
						if (num4 >= A_6)
						{
							num = (short)1288175620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Array.Clear(array2, 0, A_3);
						global::System.Array.Copy(A_0.Data, A_5 + num4 * A_4, array2, 0, A_3);
						string text3 = global::authAES.AESCryptography.HEXString(array2);
						bool flag = true;
						string text = text3;
						int num3 = 0;
						num = (short)1582563345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_3B4;
					case 18:
					{
						string text;
						int num3;
						if (num3 >= text.Length)
						{
							num = (short)265027598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1946057173;
						short num5 = num;
						num = (short)1511619029;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34D;
						default:
							num = (short)148766720;
							if (num != 0)
							{
							}
							num = (short)1859977216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 19:
						if (!global::Motorola.Common.Communication.CodeplugParseHelper.a(text2, 63))
						{
							num = (short)1404895245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_296;
					case 20:
						num = (short)1206779905;
						if (num != 0)
						{
						}
						goto IL_233;
					case 21:
						goto IL_435;
					}
					goto IL_87;
					IL_233:
					num = (short)964493321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_296:
					num = (short)1258094599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_310:
					num = (short)561512467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34D:
					num = (short)522059776;
					short num6 = num;
					text2 = string.Empty;
					num = (short)1392115713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B4:
					num = (short)800522258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_435:
					num = (short)968884240;
					num2 = (int)((global::System.IntPtr)num);
				}
				Block_3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				IL_470:
				byte[] data = A_0.Data;
				int num7;
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 0, num7 - 2);
				return;
				IL_87:
				num7 = A_0.Data.Length;
				array2 = new byte[A_3];
				text2 = string.Empty;
				string empty = string.Empty;
				num4 = 0;
				num = (short)166723605;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00019C28 File Offset: 0x00017E28
		public static void UpdateWiFiEncryptPassword(global::Motorola.Common.Communication.Pba.PbaObject pba, byte[] decryptKey, byte[] encryptKey, bool outOfBoxExperience)
		{
			short num = (short)1170669568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)804061185;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_69;
				}
				int num3;
				int num4;
				int num5;
				string text3;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator2;
				byte[] array2;
				int num11;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshItem> list;
				for (;;)
				{
					IL_52:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshItem>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_B20;
					case 1:
						if (num3 != 0)
						{
							num = (short)244711424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						try
						{
							num = (short)1733754884;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1AF;
								case 1:
									num = (short)2129330176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1822949377;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.CommonUtil.IshItem a_ = enumerator.Current;
									num4 = 82;
									num5 = ((int)a_.Data[1] << 8) + (int)a_.Data[2];
									global::Motorola.Common.Communication.CodeplugParseHelper.b(a_, decryptKey, encryptKey, 64, num3, num4, num5, outOfBoxExperience);
									num = (short)1954873346;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_10B;
									}
									continue;
								}
								IL_10D:
								num = (short)1468006403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10B:
								goto IL_10D;
							}
							IL_1AF:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1C2;
					case 3:
					{
						num = (short)742326272;
						short num6 = num;
						try
						{
							num = (short)1165950995;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text;
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
								int num8;
								global::Motorola.Common.Communication.CommonUtil.IshHeader key;
								int num10;
								switch (num2)
								{
								case 0:
									goto IL_502;
								case 1:
									goto IL_650;
								case 2:
									goto IL_650;
								case 3:
									text = string.Empty;
									num = (short)1979187240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									int num7;
									string text2;
									if (num7 >= text2.Length)
									{
										num = (short)1950220318;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1601241116;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_AAD;
								case 7:
									text = global::authAES.AESCryptography.AESDecrypt_Ex(text3, encryptKey, 0, 4);
									num = (short)1587216385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_807;
								case 9:
									goto IL_502;
								case 10:
									num4 = 19;
									num8 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
									num5 = ((int)keyValuePair.Value.Data[11] << 8) + (int)keyValuePair.Value.Data[12];
									num = (short)1611530262;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									text = string.Empty;
									num = (short)971112482;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (key.IshType != 3665)
									{
										num = (short)834666517;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4B1;
								case 13:
								{
									bool flag = false;
									num = (short)348848136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									goto IL_4B1;
								case 15:
									if (key.IshType != 1160)
									{
										num = (short)1056702496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_970;
								case 16:
									if (key.IshType == 1160)
									{
										num = (short)994836490;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num4 = 7;
									num5 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
									num = (short)847380516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									num4 = 94;
									num3 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
									num5 = ((int)keyValuePair.Value.Data[11] << 8) + (int)keyValuePair.Value.Data[12];
									global::Motorola.Common.Communication.CodeplugParseHelper.b(keyValuePair.Value, decryptKey, encryptKey, 64, num3, num4, num5, outOfBoxExperience);
									num = (short)707919895;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_970;
								case 19:
									switch (0)
									{
									case 0:
										goto IL_2D2;
									}
									continue;
								case 20:
								{
									bool flag;
									if (flag)
									{
										num = (short)2016739331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1010237467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 21:
									key = keyValuePair.Key;
									num = (short)2147090467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									goto IL_773;
								case 24:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1734148135;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									keyValuePair = enumerator2.Current;
									key = keyValuePair.Key;
									num = (short)1883456699;
									short num9 = num;
									num = (short)345195707;
									switch ((num9 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_773;
									default:
										num = (short)1249378304;
										if (num != 0)
										{
										}
										num = (short)129040399;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 26:
								{
									byte[] array = global::authAES.AESCryptography.HexString2Bytes(global::authAES.AESCryptography.AESEncrypt_Ex(text, encryptKey, 0, 4));
									if (array.Length != 64)
									{
										goto Block_9;
									}
									global::System.Array.Copy(array, 0, keyValuePair.Value.Data, num4 + num10 * num8, 64);
									num10++;
									num = (short)2100428800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 27:
									if (outOfBoxExperience)
									{
										num = (short)448135175;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									text = global::authAES.AESCryptography.AESDecrypt_Ex(text3, decryptKey, 0, 4);
									num = (short)94437378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
								{
									int num7;
									string text2;
									if (text2[num7] != '0')
									{
										num = (short)572915725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num7++;
									num = (short)5570593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 29:
									if (!global::Motorola.Common.Communication.CodeplugParseHelper.a(text, 63))
									{
										num = (short)585498635;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_45B;
								case 30:
									goto IL_807;
								case 31:
									if (key.IshType == 3676)
									{
										num = (short)759037970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									key = keyValuePair.Key;
									num = (short)1812594700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									key = keyValuePair.Key;
									num = (short)1644560415;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									goto IL_694;
								case 34:
									goto IL_45B;
								case 35:
									if (key.IshType == 3664)
									{
										num = (short)1216020494;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 36:
									goto IL_619;
								case 37:
								{
									if (num10 >= num5)
									{
										num = (short)2057502758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Array.Clear(array2, 0, 64);
									global::System.Array.Copy(keyValuePair.Value.Data, num4 + num10 * num8, array2, 0, 64);
									text3 = global::authAES.AESCryptography.HEXString(array2);
									bool flag = true;
									string text2 = text3;
									int num7 = 0;
									num = (short)207618090;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 38:
								{
									byte[] data = keyValuePair.Value.Data;
									global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 0, num11 - 2);
									num = (short)868286489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 39:
									num = (short)596705286;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 40:
									goto IL_650;
								case 41:
									if (key.IshType == 3665)
									{
										num = (short)1924202513;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									list.Add(keyValuePair.Value);
									num = (short)624689156;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									goto IL_694;
								}
								goto IL_2D2;
								IL_45B:
								num = (short)1769498;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4B1:
								key = keyValuePair.Key;
								num = (short)1097072681;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_502:
								num = (short)1610481701;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_619:
								array2 = new byte[64];
								text = string.Empty;
								string empty = string.Empty;
								num10 = 0;
								num = (short)2096824329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_773:
								goto IL_619;
								IL_650:
								num = (short)137887773;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_694:
								num = (short)1810235397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_807:
								num = (short)1683554324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_881:
								num = (short)1097596952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D2:
								goto IL_881;
								IL_970:
								num8 = 99;
								num11 = keyValuePair.Value.Data.Length;
								global::Motorola.Common.Communication.CodeplugParseHelper.a(keyValuePair.Value.Data, 0, num11 - 2);
								key = keyValuePair.Key;
								num = (short)767098896;
								num2 = (int)((global::System.IntPtr)num);
							}
							Block_9:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
							IL_AAD:
							goto IL_1C2;
						}
						finally
						{
							num = (short)1193869314;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)841023489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_B1D;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_AE6;
									}
									continue;
								}
								IL_AE6:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1075642368;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B1D:;
						}
						goto IL_B20;
					}
					}
					goto IL_69;
					IL_1C2:
					num = (short)898105345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B20:
					enumerator = list.GetEnumerator();
					num = (short)1227554818;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_69:
				text3 = string.Empty;
				num4 = 0;
				num5 = 0;
				num11 = 0;
				array2 = null;
				num3 = 0;
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshItem>();
				enumerator2 = pba.GetCodeplugInIshItemCollection().GetEnumerator();
				num = (short)1556807683;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_52;
			}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0001A7B0 File Offset: 0x000189B0
		private static void a(global::Motorola.Common.Communication.CommonUtil.IshItem A_0, byte[] A_1, byte[] A_2, int A_3, int A_4, int A_5, int A_6, bool A_7)
		{
			int a_ = 12;
			short num = (short)2015690752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				string text;
				int num4;
				byte[] array;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						num = (short)1402208256;
						short num3 = num;
						text = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("췻쳽㏿㘁㄃", a_);
						num = (short)1716715526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (num4 >= A_6)
						{
							num = (short)1636237323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Array.Clear(array, 0, A_3);
						global::System.Array.Copy(A_0.Data, A_5 + num4 * A_4, array, 0, A_3);
						string text2 = global::authAES.AESCryptography.HEXString(array);
						bool flag = true;
						string text3 = text2;
						int num5 = 0;
						num = (short)1706033172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						string text3;
						int num5;
						if (num5 >= text3.Length)
						{
							num = (short)1227292680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)6225923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						string text3;
						int num5;
						if (text3[num5] != '0')
						{
							num = (short)1742405647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)1033961491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_232;
					case 5:
						goto IL_232;
					case 6:
						goto IL_32D;
					case 7:
						goto IL_2A1;
					case 8:
						goto IL_434;
					case 9:
						if (!global::Motorola.Common.Communication.CodeplugParseHelper.a(text, 32))
						{
							num = (short)234815488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32D;
					case 10:
						goto IL_434;
					case 11:
						goto IL_2DC;
					case 12:
					{
						string text2;
						text = global::authAES.AESCryptography.AESDecrypt_Ex(text2, A_2, 0, 3);
						num = (short)961871876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						bool flag;
						if (flag)
						{
							num = (short)1176567824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)58327058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_232;
					case 15:
					{
						num = (short)274237904;
						short num6 = num;
						num = (short)1728285136;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3A5;
						default:
						{
							num = (short)1069088768;
							if (num != 0)
							{
							}
							bool flag = false;
							num = (short)1803288586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 16:
						text = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("췻쳽㏿㘁㄃", a_);
						num = (short)171573262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_2A1;
					case 18:
					{
						num = (short)203096065;
						if (num != 0)
						{
						}
						if (A_7)
						{
							num = (short)668794892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text2;
						text = global::authAES.AESCryptography.AESDecrypt_Ex(text2, A_1, 0, 3);
						num = (short)1634729989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_3A5;
					case 20:
						goto IL_3A5;
					}
					goto IL_8C;
					IL_232:
					num = (short)658767881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A1:
					num = (short)716963841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32D:
					global::System.Array.Copy(global::authAES.AESCryptography.HexString2Bytes(global::authAES.AESCryptography.AESEncrypt_Ex(text, A_2, 0, 3).Substring(0, 66)), 0, A_0.Data, A_5 + num4 * A_4, A_3);
					num4++;
					num = (short)2090139655;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A5:
					num = (short)1004339202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_434:
					num = (short)1131544589;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2DC:
				byte[] data = A_0.Data;
				int num7;
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 0, num7 - 2);
				return;
				IL_8C:
				text = string.Empty;
				string empty = string.Empty;
				num7 = A_0.Data.Length;
				array = new byte[A_3];
				num4 = 0;
				num = (short)1774911505;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0001AC44 File Offset: 0x00018E44
		public static void UpdateExternalDataModemEncryptPassword(global::Motorola.Common.Communication.Pba.PbaObject pba, byte[] decryptKey, byte[] encryptKey, bool outOfBoxExperience)
		{
			int a_ = 0;
			short num = (short)1490550784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				int num4;
				int num7;
				string text2;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshItem> list;
				for (;;)
				{
					IL_32:
					num = (short)991887360;
					short num3 = num;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshItem>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						if (num4 != 0)
						{
							num = (short)266076162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						try
						{
							num = (short)603586582;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text;
								int num5;
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
								int num6;
								global::Motorola.Common.Communication.CommonUtil.IshHeader key;
								switch (num2)
								{
								case 0:
									goto IL_4DB;
								case 1:
									if (!global::Motorola.Common.Communication.CodeplugParseHelper.a(text, 32))
									{
										num = (short)397934622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7A8;
								case 2:
								{
									if (num5 < 430)
									{
										num = (short)368705545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.CodeplugParseHelper.a(keyValuePair.Value.Data, 1, num5 - 3);
									num6 = 396;
									byte[] array = new byte[num7];
									global::System.Array.Copy(keyValuePair.Value.Data, num6, array, 0, num7);
									text2 = global::authAES.AESCryptography.HEXString(array);
									bool flag = true;
									string text3 = text2;
									int num8 = 0;
									num = (short)662437888;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_813;
								case 5:
									goto IL_8E4;
								case 6:
									goto IL_687;
								case 7:
									key = keyValuePair.Key;
									num = (short)447152161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (key.IshType == 1027)
									{
										num = (short)1850277905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									key = keyValuePair.Key;
									num = (short)1701117972;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1146290182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_7A8;
								case 11:
									goto IL_813;
								case 12:
								{
									string text3;
									int num8;
									if (num8 >= text3.Length)
									{
										num = (short)1953562642;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2013397018;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									text = global::authAES.AESCryptography.AESDecrypt_Ex(text2, encryptKey, 0, 3);
									num = (short)1649082379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (outOfBoxExperience)
									{
										goto IL_5DC;
									}
									text = global::authAES.AESCryptography.AESDecrypt_Ex(text2, decryptKey, 0, 3);
									num = (short)977928207;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									goto IL_813;
								case 16:
								{
									int a_2 = 61;
									num4 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
									int a_3 = ((int)keyValuePair.Value.Data[11] << 8) + (int)keyValuePair.Value.Data[12];
									global::Motorola.Common.Communication.CodeplugParseHelper.a(keyValuePair.Value, decryptKey, encryptKey, num7, num4, a_2, a_3, outOfBoxExperience);
									num = (short)1930625027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									text = string.Empty;
									string empty = string.Empty;
									num5 = keyValuePair.Value.Data.Length;
									num = (short)1773993986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									goto IL_6DC;
								case 19:
									if (!enumerator.MoveNext())
									{
										num = (short)1121386528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									keyValuePair = enumerator.Current;
									key = keyValuePair.Key;
									num = (short)949944328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									if (key.IshType != 3665)
									{
										num = (short)1521483783;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_51F;
								case 21:
									goto IL_51F;
								case 22:
									switch (0)
									{
									case 0:
										goto IL_2B0;
									}
									continue;
								case 23:
									goto IL_4DB;
								case 24:
								{
									bool flag = false;
									num = (short)314900511;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
								{
									bool flag;
									if (flag)
									{
										num = (short)430440475;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2099970062;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
								{
									string text3;
									int num8;
									if (text3[num8] != '0')
									{
										num = (short)242876440;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num8++;
									num = (short)1952579607;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 27:
									text = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("쇯샱쟳싵췷", a_);
									num = (short)1998585860;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
								{
									num = (short)826597654;
									short num9 = num;
									num = (short)787472662;
									switch ((num9 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_5DC;
									default:
										num = (short)388038656;
										if (num != 0)
										{
										}
										break;
									}
									break;
								}
								case 29:
									if (key.IshType == 3665)
									{
										num = (short)1573257232;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									list.Add(keyValuePair.Value);
									num = (short)283246620;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									text = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("쇯샱쟳싵췷", a_);
									num = (short)1716125706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									goto IL_6DC;
								case 32:
									num = (short)1521876997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									if (key.IshType == 3664)
									{
										num = (short)2137325589;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_35C:
								num = (short)1203306515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B0:
								goto IL_35C;
								IL_4DB:
								num = (short)566362124;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_51F:
								key = keyValuePair.Key;
								num = (short)1220870173;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5DC:
								num = (short)801767437;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6DC:
								num = (short)1847132185;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7A8:
								global::System.Array.Copy(global::authAES.AESCryptography.HexString2Bytes(global::authAES.AESCryptography.AESEncrypt_Ex(text, encryptKey, 0, 3).Substring(0, 66)), 0, keyValuePair.Value.Data, num6, num7);
								byte[] data = keyValuePair.Value.Data;
								global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 1, num5 - 3);
								num = (short)22347810;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_813:
								num = (short)946405377;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_687:
							return;
							IL_8E4:
							goto IL_199;
						}
						finally
						{
							num = (short)1772945408;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_91C;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1539375106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_954;
								}
								IL_91C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1164050433;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_954:;
						}
						goto IL_957;
					case 2:
						num = (short)509542401;
						if (num != 0)
						{
						}
						goto IL_957;
					case 3:
						try
						{
							num = (short)1696333826;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)123928579;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.CommonUtil.IshItem a_4 = enumerator2.Current;
									int a_5 = 49;
									int a_6 = ((int)a_4.Data[1] << 8) + (int)a_4.Data[2];
									global::Motorola.Common.Communication.CodeplugParseHelper.a(a_4, decryptKey, encryptKey, num7, num4, a_5, a_6, outOfBoxExperience);
									num = (short)76349441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E5;
									}
									continue;
								case 3:
									num = (short)1385234436;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_186;
								}
								IL_E7:
								num = (short)1663762432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E5:
								goto IL_E7;
							}
							IL_186:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_199;
					}
					goto IL_73;
					IL_199:
					num = (short)597884928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_957:
					enumerator2 = list.GetEnumerator();
					num = (short)1638858755;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_73:
				text2 = string.Empty;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				num7 = 33;
				num4 = 0;
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshItem>();
				enumerator = codeplugInIshItemCollection.GetEnumerator();
				num = (short)216203265;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0001B604 File Offset: 0x00019804
		private static bool a(string A_0, int A_1)
		{
			short num = (short)55967745;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_20:
				int i;
				switch (num2)
				{
				case 0:
					goto IL_6C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 2:
					goto IL_EC;
				case 3:
					return true;
				case 4:
					while (i < A_0.Length)
					{
						num = (short)1633607956;
						short num3 = num;
						num = (short)1436672276;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)49479680;
							if (num != 0)
							{
							}
							char c = A_0[i];
							num = (short)1290534918;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_20;
						}
						}
					}
					num = (short)1843986435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_EC;
				case 6:
				{
					char c;
					if (c <= '~')
					{
						num = (short)289800199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 7:
					num = (short)987693065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_A6;
				case 9:
				{
					char c;
					if (c < ' ')
					{
						num = (short)1390805000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					i++;
					num = (short)801177605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4E:
				if (A_0.Length > A_1)
				{
					num = (short)2050883584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1949761537;
				if (num != 0)
				{
				}
				i = 0;
				num = (short)825163778;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC:
				num = (short)1174601732;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6C:
			num = (short)1610743808;
			short num4 = num;
			return false;
			IL_A6:
			return false;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0001B818 File Offset: 0x00019A18
		public static bool IsPINPSWBlockExist(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)383909888;
			switch (num)
			{
			default:
			{
				num = (short)478609408;
				short num2 = num;
				bool result = false;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pba.GetCodeplugInIshItemCollection();
				string empty = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)1097269249;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_199;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)476512259;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)1119223814;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)1208745988;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1B6;
						case 5:
							result = true;
							goto IL_181;
						case 6:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1150)
							{
								num = (short)1621659060;
								short num4 = num;
								num = (short)252939700;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_181;
								default:
									num = (short)229703680;
									if (num != 0)
									{
									}
									num = (short)43515909;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							break;
						}
						}
						IL_13F:
						num = (short)315424770;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1:
						goto IL_13F;
						IL_181:
						num = (short)2109145088;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_199:
					IL_1B6:;
				}
				finally
				{
					num = (short)1973616642;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1120468993;
							if (num != 0)
							{
							}
							num = (short)18350081;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_24B;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1ED;
							}
							continue;
						}
						IL_1ED:
						if (enumerator == null)
						{
							break;
						}
						num = (short)303955968;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_24B:;
				}
				return result;
			}
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0001BA90 File Offset: 0x00019C90
		public static void WriteEncryptPassword(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite, string encryptedPwd)
		{
			short num = (short)111673345;
			if (num != 0)
			{
			}
			num = (short)1903427584;
			switch (num)
			{
			default:
			{
				num = (short)1965555712;
				short num2 = num;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaToWrite.GetCodeplugInIshItemCollection();
				string empty = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)184156160;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_C6;
							}
							continue;
						case 1:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1150)
							{
								num = (short)1310457859;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							num = (short)859242501;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							int destinationIndex = 1;
							int num4 = 48;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							int num5 = keyValuePair.Value.Data.Length;
							global::Motorola.Common.Communication.CodeplugParseHelper.a(keyValuePair.Value.Data, 1, num5 - 3);
							num = (short)373293063;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_25D;
						case 5:
							goto IL_281;
						case 6:
						{
							num = (short)695700600;
							short num6 = num;
							num = (short)1002278008;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
							{
								num = (short)2103771136;
								if (num != 0)
								{
								}
								if (!enumerator.MoveNext())
								{
									num = (short)1315569666;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
								global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
								num = (short)622002177;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 7:
						{
							byte[] array = global::authAES.AESCryptography.HexString2Bytes(encryptedPwd);
							int num4;
							if (array.Length != num4)
							{
								goto Block_2;
							}
							int destinationIndex;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::System.Array.Copy(array, 0, keyValuePair.Value.Data, destinationIndex, num4);
							byte[] data = keyValuePair.Value.Data;
							int num5;
							global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 1, num5 - 3);
							num = (short)897384452;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_12B:
						num = (short)382074886;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C6:
						goto IL_12B;
					}
					Block_2:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
					IL_25D:
					IL_281:;
				}
				finally
				{
					num = (short)1167327234;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1786118145;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2EC;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2B5;
							}
							continue;
						}
						IL_2B5:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1822687232;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2EC:;
				}
				return;
			}
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0001BDA8 File Offset: 0x00019FA8
		public static void WriteClearPassword(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite, string targetPwdHead, string targetPwdTail)
		{
			short num = (short)940310528;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaToWrite.GetCodeplugInIshItemCollection();
				string empty = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)2048458754;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader key;
						switch (num2)
						{
						case 0:
							goto IL_186;
						case 1:
						{
							byte[] bytes;
							if (bytes.Length <= 8)
							{
								num = (short)2104885258;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22C;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_84;
							}
							continue;
						case 3:
							goto IL_227;
						case 4:
							num = (short)1697644552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							int destinationIndex = 103;
							int destinationIndex2 = 155;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							int num3 = keyValuePair.Value.Data.Length;
							global::Motorola.Common.Communication.CodeplugParseHelper.a(keyValuePair.Value.Data, 1, num3 - 3);
							byte[] bytes = global::System.Text.Encoding.BigEndianUnicode.GetBytes(targetPwdHead);
							byte[] bytes2 = global::System.Text.Encoding.BigEndianUnicode.GetBytes(targetPwdTail);
							num = (short)54001665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							byte[] bytes2;
							if (bytes2.Length > 34)
							{
								num = (short)110362631;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] bytes;
							int destinationIndex;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::System.Array.Copy(bytes, 0, keyValuePair.Value.Data, destinationIndex, bytes.Length);
							int destinationIndex2;
							global::System.Array.Copy(bytes2, 0, keyValuePair.Value.Data, destinationIndex2, bytes2.Length);
							byte[] data = keyValuePair.Value.Data;
							int num3;
							global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 1, num3 - 3);
							num = (short)884146179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_2BC;
						case 8:
							goto IL_2D9;
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2130051076;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							key = keyValuePair.Key;
							num = (short)904921088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							num = (short)979426334;
							short num4 = num;
							num = (short)784522270;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_186;
							default:
								num = (short)1368326144;
								if (num != 0)
								{
								}
								num = (short)1256914950;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_11D:
						num = (short)1261568009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_186:
						if (key.IshType == 1028)
						{
							num = (short)1720451077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_84:
						goto IL_11D;
					}
					IL_227:
					goto IL_349;
					IL_22C:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
					IL_2BC:
					goto IL_22C;
					IL_2D9:;
				}
				finally
				{
					num = (short)2126381058;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)472645633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_346;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_30E;
							}
							continue;
						}
						IL_30E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1505886208;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_346:;
				}
				IL_349:
				num = (short)764936192;
				short num5 = num;
				num = (short)566034433;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0001C16C File Offset: 0x0001A36C
		public static void UpdateIPAddress(ref byte[] Data)
		{
			short num = (short)1683488769;
			if (num != 0)
			{
			}
			num = (short)839458583;
			short num2 = num;
			num = (short)1353654039;
			switch (num2 == num)
			{
			}
			num = (short)1221722112;
			short num3 = num;
			num = (short)208207872;
			if (num != 0)
			{
			}
			Data[18] = 111;
			Data[34] = 111;
			global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref Data, 0, Data.Length - 2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0001C230 File Offset: 0x0001A430
		private static void a(global::Motorola.Common.Communication.Pba.PbaObject A_0, out string A_1, out string A_2)
		{
			short num = (short)2026962944;
			switch (num)
			{
			default:
			{
				num = (short)519766016;
				short num2 = num;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				A_1 = string.Empty;
				A_2 = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)384630785;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_286;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A5;
							}
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)689045505;
								if (num != 0)
								{
								}
								num = (short)1697054723;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)136642566;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)960430084;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_2A3;
						case 5:
						{
							int sourceIndex = 103;
							int sourceIndex2 = 155;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							int num4 = keyValuePair.Value.Data.Length;
							global::Motorola.Common.Communication.CodeplugParseHelper.a(keyValuePair.Value.Data, 1, num4 - 3);
							byte[] array = new byte[global::Motorola.Common.Communication.CodeplugParseHelper.a];
							byte[] array2 = new byte[global::Motorola.Common.Communication.CodeplugParseHelper.a];
							global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array, 0, array.Length);
							global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex2, array2, 0, array2.Length);
							A_1 = global::System.Text.Encoding.BigEndianUnicode.GetString(array).TrimEnd(new char[1]);
							A_2 = global::System.Text.Encoding.BigEndianUnicode.GetString(array2).TrimEnd(new char[1]);
							goto IL_26D;
						}
						case 6:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1028)
							{
								num = (short)269776645;
								short num5 = num;
								num = (short)725448453;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_26D;
								default:
									num = (short)1318387712;
									if (num != 0)
									{
									}
									num = (short)344195077;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							break;
						}
						}
						IL_146:
						num = (short)487194626;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A5:
						goto IL_146;
						IL_26D:
						num = (short)1974927360;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_286:
					IL_2A3:;
				}
				finally
				{
					num = (short)1110966274;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)76742657;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_30F;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2D8;
							}
							continue;
						}
						IL_2D8:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1174339584;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_30F:;
				}
				return;
			}
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0001C56C File Offset: 0x0001A76C
		public static void WriteMacAddress(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite, byte[] address, int index)
		{
			short num = (short)1963393024;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaToWrite.GetCodeplugInIshItemCollection();
				string empty = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)964952064;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_7B;
							}
							continue;
						case 1:
							goto IL_20B;
						case 2:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							if (value.Data.Length > index + address.Length)
							{
								num = (short)513998853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							num = (short)923598854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 900)
							{
								num = (short)1929445384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							int num3 = value.Data.Length;
							int sourceIndex = 0;
							value = keyValuePair.Value;
							global::System.Array.Copy(address, sourceIndex, value.Data, index, address.Length);
							value = keyValuePair.Value;
							byte[] data = value.Data;
							global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 1, num3 - 3);
							num = (short)986513409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_229;
						case 7:
						{
							num = (short)182545545;
							short num4 = num;
							num = (short)11234441;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)942080000;
								if (num != 0)
								{
								}
								if (!enumerator.MoveNext())
								{
									num = (short)1626210307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
								global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
								num = (short)1956184068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 8:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							num = (short)1353646082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_CE:
						num = (short)1724776455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7B:
						goto IL_CE;
					}
					IL_20B:
					IL_229:;
				}
				finally
				{
					num = (short)916389890;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)322043905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_294;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_25E;
							}
							continue;
						}
						IL_25E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)11141120;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_294:;
				}
				num = (short)977534976;
				short num5 = num;
				num = (short)1783627777;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001C87C File Offset: 0x0001AA7C
		public static void UpdateIshItemCRC(ref byte[] data, int start, int length)
		{
			short num = (short)815735017;
			short num2 = num;
			num = (short)1053630697;
			switch (num2 == num)
			{
			}
			num = (short)137232384;
			if (num != 0)
			{
			}
			num = (short)401866752;
			short num3 = num;
			num = (short)275447809;
			if (num != 0)
			{
			}
			int num4 = data.Length;
			ushort num5 = global::Motorola.Common.Communication.CodeplugParseHelper.a(data, start, length);
			data[num4 - 2] = (byte)(num5 >> 8);
			data[num4 - 1] = (byte)num5;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0001C948 File Offset: 0x0001AB48
		private static ushort a(byte[] A_0, int A_1, int A_2)
		{
			short num = (short)1407023324;
			short num2 = num;
			num = (short)1866496220;
			switch (num2 == num)
			{
			}
			num = (short)1908473857;
			if (num != 0)
			{
			}
			num = (short)707198976;
			short num3 = num;
			num = (short)146735104;
			if (num != 0)
			{
			}
			uint num4 = 0U;
			num4 = (uint)global::Motorola.Common.Communication.RcmpBaseMessage.CalculateCRC16(ref num4, A_0, A_1, A_2);
			return (ushort)num4;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0001CA14 File Offset: 0x0001AC14
		// Note: this type is marked as 'beforefieldinit'.
		static CodeplugParseHelper()
		{
			short num = (short)1954385035;
			short num2 = num;
			num = (short)2018806923;
			switch (num2 == num)
			{
			}
			num = (short)181403649;
			if (num != 0)
			{
			}
			num = (short)2089287680;
			short num3 = num;
			num = (short)110624768;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CodeplugParseHelper.a = 34;
		}

		// Token: 0x04000043 RID: 67
		private static int a;

		// Token: 0x04000044 RID: 68
		private const int b = 164;

		// Token: 0x04000045 RID: 69
		private const int c = 2;
	}
}
