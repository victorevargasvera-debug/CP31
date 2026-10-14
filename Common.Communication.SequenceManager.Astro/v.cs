using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using authAES;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000010 RID: 16
	internal class v
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00012D74 File Offset: 0x00010F74
		public static bool f(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)1042612224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				bool result;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)628752388;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1CB;
								case 1:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									int num3 = value.Data.Length;
									value = keyValuePair.Value;
									global::Motorola.Common.Communication.v.a(value.Data, 1, num3 - 3);
									int num4 = 1;
									value = keyValuePair.Value;
									num = (short)1818427400;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1190264841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									num = (short)1345519622;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1EB;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_123;
									}
									continue;
								case 5:
									goto IL_28B;
								case 6:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 903)
									{
										num = (short)1984561153;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									result = true;
									num = (short)980353027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									int num4;
									if ((value.Data[num4] & 1) != 0)
									{
										num = (short)1090060295;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									result = false;
									num = (short)771686400;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)95354885;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_125:
								num = (short)544145410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_123:
								goto IL_125;
							}
							IL_1CB:
							IL_1EB:
							IL_28B:
							return result;
						}
						finally
						{
							num = (short)2031419394;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_348;
								case 1:
								{
									num = (short)977372364;
									short num5 = num;
									num = (short)971605196;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2C9;
									default:
										num = (short)530186240;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)992673792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2C3;
									}
									continue;
								}
								goto IL_2C3;
								IL_2C9:
								num = (short)349569025;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2C3:
								if (enumerator != null)
								{
									goto IL_2C9;
								}
								break;
							}
							IL_348:;
						}
						goto IL_34B;
					case 1:
						goto IL_34B;
					case 2:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)407896064;
							short num6 = num;
							num = (short)513409025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_3C;
					IL_34B:
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)475332608;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_3C:
				num = (short)1197867009;
				if (num != 0)
				{
				}
				codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				result = false;
				num = (short)2080243714;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00013110 File Offset: 0x00011310
		private static bool a(byte A_0, int A_1)
		{
			short num = (short)1893267966;
			short num2 = num;
			num = (short)1499920894;
			switch (num2 == num)
			{
			}
			num = (short)305201153;
			if (num != 0)
			{
			}
			num = (short)2098921472;
			if (num != 0)
			{
			}
			num = (short)1709768704;
			short num3 = num;
			return ((int)A_0 & 1 << A_1) != 0;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000131C4 File Offset: 0x000113C4
		public static bool e(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)258539521;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] data;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)151912452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
					return false;
				case 3:
					if (data != null)
					{
						num = (short)1469120512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					goto IL_89;
				}
				goto IL_3A;
				IL_89:
				if (data.Length <= 164)
				{
					num = (short)1693384706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_191;
				IL_3A:
				num = (short)975962113;
				if (num != 0)
				{
				}
				data = A_0.GetCodeplugInIshItemCollection().FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>, bool>(global::Motorola.Common.Communication.v.<>c.<>9.a)).Value.Data;
				num = (short)78558303;
				short num3 = num;
				num = (short)564900959;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_89;
				case 1:
					break;
				default:
				{
					num = (short)1906835456;
					short num4 = num;
					break;
				}
				}
				num = (short)1646395392;
				if (num != 0)
				{
				}
				num = (short)1041891331;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_191:
			return global::Motorola.Common.Communication.v.a(data[164], 2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00013370 File Offset: 0x00011570
		public static void d(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)94371840;
			short num2 = num;
			num = (short)1390673920;
			switch (num)
			{
			default:
			{
				num = (short)504823809;
				int num3 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
				global::Motorola.Common.Communication.CommonUtil.IshItem value;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						value = keyValuePair.Value;
						num = (short)1450967044;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)703342044;
						short num4 = num;
						num = (short)1055794652;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)838664192;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CC;
							}
							continue;
						}
						break;
					}
					case 2:
						return;
					case 3:
						num = (short)1084096513;
						if (num != 0)
						{
						}
						if (value.Data != null)
						{
							num = (short)1748041728;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (value.Data.Length <= 164)
						{
							num = (short)280363010;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BE;
					}
					IL_CC:
					keyValuePair = A_0.GetCodeplugInIshItemCollection().FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>, bool>(global::Motorola.Common.Communication.v.<>c.<>9.b));
					value = keyValuePair.Value;
					num = (short)1734672387;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1BE:
				int num5 = -5;
				value = keyValuePair.Value;
				byte[] data = value.Data;
				int num6 = 164;
				data[num6] &= (byte)num5;
				value = keyValuePair.Value;
				byte[] data2 = value.Data;
				int a_ = 0;
				value = keyValuePair.Value;
				global::Motorola.Common.Communication.v.a(ref data2, a_, value.Data.Length - 2);
				return;
			}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0001358C File Offset: 0x0001178C
		public static string c(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)422248448;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				string result = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)810483716;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_181;
						case 1:
							goto IL_19F;
						case 2:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1150)
							{
								num = (short)2127233029;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1939341318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)364314626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_74;
							}
							continue;
						case 5:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							int num3 = keyValuePair.Value.Data.Length;
							global::Motorola.Common.Communication.v.a(keyValuePair.Value.Data, 1, num3 - 3);
							int sourceIndex = 1;
							int num4 = 48;
							byte[] array = new byte[num4];
							global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array, 0, num4);
							result = global::authAES.AESCryptography.HEXString(array);
							num = (short)774635520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)1898512385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_C3:
						num = (short)519176195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_74:
						goto IL_C3;
					}
					IL_181:
					IL_19F:;
				}
				finally
				{
					num = (short)466616321;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)26799353;
						short num5 = num;
						num = (short)593685753;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_25B;
						default:
							num = (short)2034565120;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_25B;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_222;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)41811968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_222:
							if (enumerator == null)
							{
								goto IL_25D;
							}
							num = (short)1784348674;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_25B:
					IL_25D:;
				}
				num = (short)425459713;
				if (num != 0)
				{
				}
				num = (short)1432616960;
				short num6 = num;
				return result;
			}
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00013868 File Offset: 0x00011A68
		public static string b(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)2050752513;
			if (num != 0)
			{
			}
			num = (short)31784960;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				string text = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)824901636;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1E5;
						case 1:
							goto IL_202;
						case 2:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1028)
							{
								num = (short)646774789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2124218374;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)693239810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_9D;
							}
							continue;
						case 5:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							int num3 = keyValuePair.Value.Data.Length;
							global::Motorola.Common.Communication.v.a(keyValuePair.Value.Data, 1, num3 - 3);
							int sourceIndex = 103;
							int num4 = 34;
							byte[] array = new byte[num4];
							global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array, 0, num4);
							text = global::authAES.AESCryptography.HEXString(array);
							sourceIndex = 155;
							byte[] array2 = new byte[num4];
							global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array2, 0, num4);
							text += global::authAES.AESCryptography.HEXString(array2);
							num = (short)2038497280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)260177921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_EE:
						num = (short)1427374083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9D:
						goto IL_EE;
					}
					IL_1E5:
					IL_202:;
				}
				finally
				{
					num = (short)1986592769;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1392659583;
						short num5 = num;
						num = (short)230902911;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2C0;
						default:
							num = (short)729546752;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_2C0;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_286;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)459603968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_286:
							if (enumerator == null)
							{
								goto IL_2C2;
							}
							num = (short)223543298;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_2C0:
					IL_2C2:;
				}
				num = (short)1879572480;
				short num6 = num;
				return text;
			}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00013B80 File Offset: 0x00011D80
		public static void b(global::Motorola.Common.Communication.Pba.PbaObject A_0, byte[] A_1, byte[] A_2, bool A_3)
		{
			short num = (short)338752602;
			short num2 = num;
			num = (short)1529214042;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1528889344;
				short num3 = num;
				break;
			}
			}
			num = (short)2035089408;
			if (num != 0)
			{
			}
			num = (short)928186368;
			switch (num)
			{
			default:
			{
				string text = string.Empty;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				byte[] array = null;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = A_0.GetCodeplugInIshItemCollection().GetEnumerator();
				try
				{
					num = (short)155058214;
					int num7 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string text2;
						string text3;
						global::Motorola.Common.Communication.CommonUtil.IshHeader key;
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						int num8;
						int num9;
						int num11;
						int num12;
						switch (num7)
						{
						case 0:
							if (A_3)
							{
								num = (short)1812791341;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							text2 = global::authAES.AESCryptography.AESDecrypt_Ex(text, A_1, 0, 4);
							num = (short)1168900144;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!global::Motorola.Common.Communication.v.a(text3, 63))
							{
								num = (short)555024421;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_712;
						case 2:
							if (key.IshType != 3665)
							{
								num = (short)315424801;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2BB;
						case 3:
							key = keyValuePair.Key;
							num = (short)524746814;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_3E8;
						case 5:
						{
							if (num8 >= num5)
							{
								num = (short)848298027;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Array.Clear(array, 0, 64);
							global::System.Array.Copy(keyValuePair.Value.Data, num4 + num8 * num9, array, 0, 64);
							text = global::authAES.AESCryptography.HEXString(array);
							bool flag = true;
							string text4 = text;
							int num10 = 0;
							num = (short)1751842865;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_367;
						case 7:
							goto IL_956;
						case 8:
							goto IL_B79;
						case 9:
						{
							string text4;
							int num10;
							if (num10 >= text4.Length)
							{
								num = (short)1597702209;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1777270804;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_2BB;
						case 11:
							goto IL_55C;
						case 12:
							goto IL_255;
						case 13:
							num = (short)1708392502;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (key.IshType == 3664)
							{
								num = (short)1953431562;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 15:
							goto IL_A49;
						case 16:
							num = (short)743374849;
							if (num != 0)
							{
							}
							goto IL_675;
						case 17:
							if (!global::Motorola.Common.Communication.v.a(text2, 63))
							{
								num = (short)479658036;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3E8;
						case 18:
							goto IL_B79;
						case 19:
							if (!enumerator.MoveNext())
							{
								num = (short)1004273677;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							keyValuePair = enumerator.Current;
							key = keyValuePair.Key;
							num = (short)1049755673;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
						{
							string text4;
							int num10;
							if (text4[num10] != '0')
							{
								num = (short)214237230;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							num10++;
							num = (short)512622651;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							goto IL_367;
						case 22:
							text2 = string.Empty;
							num = (short)1084096533;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
						{
							string text4;
							int num10;
							if (num10 >= text4.Length)
							{
								num = (short)820314169;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)455475247;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
							if (key.IshType == 1160)
							{
								num = (short)1857224759;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 = 7;
							num5 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
							num = (short)378994695;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							if (key.IshType != 1160)
							{
								num = (short)1738342403;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A49;
						case 27:
							if (key.IshType == 3665)
							{
								num = (short)1970274367;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 = 7;
							num5 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
							num = (short)365494311;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							goto IL_5DE;
						case 29:
							goto IL_5DE;
						case 30:
							text3 = string.Empty;
							num = (short)586219528;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)1208614942;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)384434232;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 32:
						{
							bool flag;
							if (flag)
							{
								num = (short)1041367062;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1917124608;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 33:
							key = keyValuePair.Key;
							num = (short)971112462;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
						{
							if (num11 >= num5)
							{
								num = (short)1272971305;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Array.Clear(array, 0, 64);
							global::System.Array.Copy(keyValuePair.Value.Data, num4 + num11 * num12, array, 0, 64);
							text = global::authAES.AESCryptography.HEXString(array);
							bool flag2 = true;
							string text4 = text;
							int num10 = 0;
							num = (short)847118364;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 35:
							goto IL_956;
						case 36:
							goto IL_9E6;
						case 37:
							text3 = string.Empty;
							num = (short)333971500;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 38:
							switch (0)
							{
							case 0:
								goto IL_1DF;
							}
							continue;
						case 39:
							goto IL_675;
						case 40:
							goto IL_9E6;
						case 41:
						{
							byte[] data = keyValuePair.Value.Data;
							global::Motorola.Common.Communication.v.a(ref data, 0, num6 - 2);
							num = (short)658178074;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 42:
							goto IL_255;
						case 43:
						{
							byte[] data2 = keyValuePair.Value.Data;
							global::Motorola.Common.Communication.v.a(ref data2, 0, num6 - 2);
							num = (short)1710161981;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 44:
							goto IL_712;
						case 45:
							text2 = global::authAES.AESCryptography.AESDecrypt_Ex(text, A_2, 0, 4);
							num = (short)885456902;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
						{
							bool flag = false;
							num = (short)1857814539;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 47:
						{
							string text4;
							int num10;
							if (text4[num10] != '0')
							{
								num = (short)1274806330;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							num10++;
							num = (short)1435762717;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 48:
							goto IL_367;
						case 49:
							goto IL_835;
						case 50:
							goto IL_6D5;
						case 51:
							text3 = global::authAES.AESCryptography.AESDecrypt_Ex(text, A_2, 0, 4);
							num = (short)1120403516;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
							text2 = string.Empty;
							num = (short)316932100;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 53:
						{
							byte[] array2 = global::authAES.AESCryptography.HexString2Bytes(global::authAES.AESCryptography.AESEncrypt_Ex(text2, A_2, 0, 4));
							if (array2.Length != 64)
							{
								goto Block_8;
							}
							global::System.Array.Copy(array2, 0, keyValuePair.Value.Data, num4 + num8 * num9, 64);
							num8++;
							num = (short)765526058;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 54:
							goto IL_D80;
						case 55:
							num4 = 19;
							num12 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
							num5 = ((int)keyValuePair.Value.Data[11] << 8) + (int)keyValuePair.Value.Data[12];
							num = (short)1887961123;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 56:
							if (A_3)
							{
								num = (short)1173880883;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							text3 = global::authAES.AESCryptography.AESDecrypt_Ex(text, A_1, 0, 4);
							num = (short)412811282;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 57:
							goto IL_6D5;
						case 58:
						{
							bool flag2 = false;
							num = (short)1993539634;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 59:
							goto IL_835;
						case 60:
							goto IL_B79;
						case 62:
							if (key.IshType == 3676)
							{
								num = (short)1141047311;
								num7 = (int)((global::System.IntPtr)num);
								continue;
							}
							key = keyValuePair.Key;
							num = (short)1562771458;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 63:
							num4 = 94;
							num9 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
							num5 = ((int)keyValuePair.Value.Data[11] << 8) + (int)keyValuePair.Value.Data[12];
							num = (short)1924530192;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						case 64:
						{
							byte[] array3 = global::authAES.AESCryptography.HexString2Bytes(global::authAES.AESCryptography.AESEncrypt_Ex(text3, A_2, 0, 4));
							if (array3.Length != 64)
							{
								goto Block_14;
							}
							global::System.Array.Copy(array3, 0, keyValuePair.Value.Data, num4 + num11 * num12, 64);
							num11++;
							num = (short)1507459108;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 65:
							goto IL_55C;
						}
						goto IL_1DF;
						IL_255:
						num = (short)1899364357;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_2BB:
						num9 = 139;
						num6 = keyValuePair.Value.Data.Length;
						global::Motorola.Common.Communication.v.a(keyValuePair.Value.Data, 0, num6 - 2);
						key = keyValuePair.Key;
						num = (short)2086404123;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_367:
						num = (short)210763793;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A7:
						num = (short)1432027155;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_1DF:
						goto IL_3A7;
						IL_3E8:
						num = (short)2103312437;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_55C:
						num = (short)1192230944;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_5DE:
						num = (short)1681981463;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_675:
						array = new byte[64];
						text2 = string.Empty;
						string empty = string.Empty;
						num8 = 0;
						num = (short)1509425164;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_6D5:
						num = (short)1245118495;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_712:
						num = (short)1684930624;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_835:
						num = (short)1076232201;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_956:
						array = new byte[64];
						text3 = string.Empty;
						string empty2 = string.Empty;
						num11 = 0;
						num = (short)490537000;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_9E6:
						num = (short)1949040674;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_A49:
						num12 = 99;
						num6 = keyValuePair.Value.Data.Length;
						global::Motorola.Common.Communication.v.a(keyValuePair.Value.Data, 0, num6 - 2);
						key = keyValuePair.Key;
						num = (short)991166488;
						num7 = (int)((global::System.IntPtr)num);
						continue;
						IL_B79:
						num = (short)1361772545;
						num7 = (int)((global::System.IntPtr)num);
					}
					Block_8:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
					Block_14:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
					IL_D80:;
				}
				finally
				{
					num = (short)1482293248;
					int num7 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num7)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_DB4;
							}
							continue;
						case 1:
							goto IL_DED;
						case 2:
							enumerator.Dispose();
							num = (short)200474625;
							num7 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DB4:
						if (enumerator == null)
						{
							break;
						}
						num = (short)928776194;
						num7 = (int)((global::System.IntPtr)num);
					}
					IL_DED:;
				}
				break;
			}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0001499C File Offset: 0x00012B9C
		public static void a(global::Motorola.Common.Communication.Pba.PbaObject A_0, byte[] A_1, byte[] A_2, bool A_3)
		{
			int a_ = 1;
			short num = (short)506855425;
			if (num != 0)
			{
			}
			num = (short)284011649;
			short num2 = num;
			num = (short)1830202497;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C1;
			case 1:
				break;
			default:
			{
				num = (short)491126784;
				short num3 = num;
				break;
			}
			}
			num = (short)1035665408;
			if (num != 0)
			{
			}
			num = (short)288423936;
			switch (num)
			{
			default:
			{
				IL_C1:
				string text = string.Empty;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				int num4 = 33;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)43450380;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num6;
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						int num7;
						global::Motorola.Common.Communication.CommonUtil.IshHeader key;
						string text2;
						int num9;
						int num10;
						int num12;
						byte[] array2;
						string text4;
						int num13;
						switch (num5)
						{
						case 0:
						{
							num6 = 61;
							num7 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
							int num8 = ((int)keyValuePair.Value.Data[11] << 8) + (int)keyValuePair.Value.Data[12];
							num = (short)1581645878;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_966;
						case 2:
						{
							if (key.IshType == 3665)
							{
								num = (short)1636827136;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							num6 = 7;
							int num8 = ((int)keyValuePair.Value.Data[1] << 8) + (int)keyValuePair.Value.Data[2];
							num = (short)902430759;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (!global::Motorola.Common.Communication.v.a(text2, 32))
							{
								num = (short)723976219;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DB;
						case 4:
							goto IL_5BB;
						case 5:
							goto IL_296;
						case 6:
						{
							bool flag;
							if (flag)
							{
								num = (short)1609826311;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1446510644;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							text2 = global::Motorola.Common.Communication.Crc32.c("궛겝鎟隡醣", a_);
							num = (short)1326972936;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_54B;
						case 9:
							goto IL_1E8;
						case 10:
							goto IL_1E8;
						case 11:
							if (key.IshType == 1027)
							{
								num = (short)1662058518;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							key = keyValuePair.Key;
							num = (short)1566375952;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							switch (0)
							{
							case 0:
								goto IL_1E3;
							}
							continue;
						case 13:
							goto IL_4BD;
						case 14:
							goto IL_2DB;
						case 15:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)964231198;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1618280474;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							if (key.IshType != 3665)
							{
								num = (short)1599930411;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_966;
						case 17:
						{
							if (num9 < 430)
							{
								num = (short)2056323105;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.v.a(keyValuePair.Value.Data, 1, num9 - 3);
							num10 = 396;
							byte[] array = new byte[num4];
							global::System.Array.Copy(keyValuePair.Value.Data, num10, array, 0, num4);
							text = global::authAES.AESCryptography.HEXString(array);
							bool flag2 = true;
							string text3 = text;
							int num11 = 0;
							num = (short)451411981;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
							goto IL_71A;
						case 19:
						{
							string text3;
							int num11;
							if (text3[num11] != '0')
							{
								num = (short)1082196017;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							num11++;
							num = (short)1169555494;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
							goto IL_54B;
						case 21:
						{
							int num8;
							if (num12 >= num8)
							{
								num = (short)104071202;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Array.Clear(array2, 0, num4);
							global::System.Array.Copy(keyValuePair.Value.Data, num6 + num12 * num7, array2, 0, num4);
							text = global::authAES.AESCryptography.HEXString(array2);
							bool flag = true;
							string text3 = text;
							int num11 = 0;
							num = (short)986906664;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							text4 = string.Empty;
							string empty = string.Empty;
							num9 = keyValuePair.Value.Data.Length;
							num = (short)1714290705;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							goto IL_9DE;
						case 24:
							text4 = global::authAES.AESCryptography.AESDecrypt_Ex(text, A_2, 0, 3);
							num = (short)499384362;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
						{
							bool flag = false;
							num = (short)347930665;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 26:
							if (A_3)
							{
								num = (short)1137311768;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							text4 = global::authAES.AESCryptography.AESDecrypt_Ex(text, A_1, 0, 3);
							num = (short)539951132;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							text2 = global::Motorola.Common.Communication.Crc32.c("궛겝鎟隡醣", a_);
							num = (short)1476395022;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							goto IL_71A;
						case 29:
						{
							string text3;
							int num11;
							if (num11 >= text3.Length)
							{
								num = (short)1270677551;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1469317165;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
							text4 = global::Motorola.Common.Communication.Crc32.c("궛겝鎟隡醣", a_);
							num = (short)142082066;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							if (!global::Motorola.Common.Communication.v.a(text4, 32))
							{
								num = (short)1311309870;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5BB;
						case 32:
							goto IL_AA9;
						case 33:
							num = (short)1142292512;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
						{
							byte[] data = keyValuePair.Value.Data;
							global::Motorola.Common.Communication.v.a(ref data, 0, num13 - 2);
							num = (short)1480589360;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 35:
							goto IL_9DE;
						case 36:
							num = (short)823132210;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
						{
							string text3;
							int num11;
							if (num11 >= text3.Length)
							{
								num = (short)1089732617;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)672530451;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 38:
							goto IL_4BD;
						case 39:
							goto IL_335;
						case 40:
							goto IL_296;
						case 41:
							goto IL_B59;
						case 42:
							goto IL_71A;
						case 43:
							key = keyValuePair.Key;
							num = (short)404029484;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							if (key.IshType == 3664)
							{
								num = (short)1706098689;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 45:
						{
							string text3;
							int num11;
							if (text3[num11] != '0')
							{
								num = (short)546308121;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							num11++;
							num = (short)1108606981;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 46:
							text4 = global::Motorola.Common.Communication.Crc32.c("궛겝鎟隡醣", a_);
							num = (short)616038404;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
							goto IL_B59;
						case 49:
						{
							bool flag2 = false;
							num = (short)1513029642;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 50:
							goto IL_BAE;
						case 51:
							if (!enumerator.MoveNext())
							{
								num = (short)1385365540;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							keyValuePair = enumerator.Current;
							key = keyValuePair.Key;
							num = (short)1894187019;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
							if (A_3)
							{
								num = (short)841809975;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							text2 = global::authAES.AESCryptography.AESDecrypt_Ex(text, A_1, 0, 3);
							num = (short)981991444;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 54:
							goto IL_335;
						case 55:
							text2 = global::authAES.AESCryptography.AESDecrypt_Ex(text, A_2, 0, 3);
							num = (short)68354104;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 56:
							goto IL_54B;
						}
						goto IL_1E3;
						IL_1E8:
						num = (short)925892623;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_296:
						num = (short)18022429;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_2DB:
						global::System.Array.Copy(global::authAES.AESCryptography.HexString2Bytes(global::authAES.AESCryptography.AESEncrypt_Ex(text2, A_2, 0, 3).Substring(0, 66)), 0, keyValuePair.Value.Data, num6 + num12 * num7, num4);
						num12++;
						num = (short)1872494627;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_335:
						global::Motorola.Common.Communication.v.a(keyValuePair.Value.Data, 1, num13 - 3);
						array2 = new byte[num4];
						num12 = 0;
						num = (short)508428311;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_3D3:
						num = (short)1975779379;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E3:
						goto IL_3D3;
						IL_4BD:
						num = (short)801636389;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_54B:
						num = (short)1292632067;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_5BB:
						global::System.Array.Copy(global::authAES.AESCryptography.HexString2Bytes(global::authAES.AESCryptography.AESEncrypt_Ex(text4, A_2, 0, 3).Substring(0, 66)), 0, keyValuePair.Value.Data, num10, num4);
						byte[] data2 = keyValuePair.Value.Data;
						global::Motorola.Common.Communication.v.a(ref data2, 1, num9 - 3);
						num = (short)1127481397;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_71A:
						num = (short)1396113439;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_966:
						text2 = string.Empty;
						string empty2 = string.Empty;
						num13 = keyValuePair.Value.Data.Length;
						num7 = 139;
						key = keyValuePair.Key;
						num = (short)1129316354;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_9DE:
						num = (short)443875349;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_B59:
						num = (short)237764614;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_AA9:
					IL_BAE:;
				}
				finally
				{
					num = (short)819134464;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_BE2;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1182203906;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_C19;
						}
						IL_BE2:
						if (enumerator == null)
						{
							break;
						}
						num = (short)645267457;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_C19:;
				}
				return;
			}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000155E4 File Offset: 0x000137E4
		private static bool a(string A_0, int A_1)
		{
			short num = (short)732758019;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
				{
					if (num3 >= A_0.Length)
					{
						num = (short)940507142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					char c = A_0[num3];
					num = (short)822116949;
					short num4 = num;
					num = (short)1223393877;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C4;
					default:
						num = (short)1837432832;
						if (num != 0)
						{
						}
						num = (short)713883649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
				{
					char c;
					if (c <= '~')
					{
						num = (short)981663748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 2:
					goto IL_A5;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 4:
					num = (short)508624904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_C4;
				case 6:
					goto IL_FC;
				case 7:
					goto IL_C4;
				case 8:
				{
					char c;
					if (c < ' ')
					{
						num = (short)1379139586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3++;
					num = (short)462094343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					return false;
				}
				IL_4C:
				if (A_0.Length > A_1)
				{
					num = (short)1394540553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num3 = 0;
				num = (short)464650245;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C4:
				num = (short)1877147648;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_A5:
			return false;
			IL_FC:
			num = (short)696975360;
			short num5 = num;
			num = (short)1926168577;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000157F8 File Offset: 0x000139F8
		public static bool a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)1912930304;
			switch (num)
			{
			default:
			{
				num = (short)1864499201;
				if (num != 0)
				{
				}
				num = (short)2131886080;
				short num2 = num;
				bool result = false;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				string empty = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)232194049;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader key;
						switch (num3)
						{
						case 0:
							goto IL_1B9;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_C6;
							}
							continue;
						case 2:
						{
							num = (short)1958196022;
							short num4 = num;
							num = (short)2002301750;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_179;
							default:
								num = (short)1919221760;
								if (num != 0)
								{
								}
								result = true;
								num = (short)561250304;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_179;
						case 4:
							num = (short)701628421;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_1D7;
						case 6:
							if (key.IshType == 1150)
							{
								num = (short)1312096258;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						goto IL_C6;
						IL_179:
						if (!enumerator.MoveNext())
						{
							num = (short)1010302980;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
						key = keyValuePair.Key;
						num = (short)1227227142;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_160:
						num = (short)448790531;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C6:
						goto IL_160;
					}
					IL_1B9:
					IL_1D7:;
				}
				finally
				{
					num = (short)822018050;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)2022834177;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_245;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_20C;
							}
							continue;
						}
						IL_20C:
						if (enumerator == null)
						{
							break;
						}
						num = (short)806944768;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_245:;
				}
				return result;
			}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00015A6C File Offset: 0x00013C6C
		public static void a(global::Motorola.Common.Communication.Pba.PbaObject A_0, string A_1)
		{
			short num = (short)60817408;
			switch (num)
			{
			default:
			{
				num = (short)171245568;
				short num2 = num;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				string empty = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)279642114;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_23C;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1792868355;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)1601437700;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						case 3:
						{
							num = (short)1601636655;
							short num4 = num;
							num = (short)948439343;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_223;
							default:
								num = (short)286982144;
								if (num != 0)
								{
								}
								num = (short)874643462;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1150)
							{
								num = (short)862257157;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							int destinationIndex = 1;
							int num5 = 48;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							int num6 = keyValuePair.Value.Data.Length;
							global::Motorola.Common.Communication.v.a(keyValuePair.Value.Data, 1, num6 - 3);
							num = (short)616693767;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_260;
						case 7:
						{
							byte[] array = global::authAES.AESCryptography.HexString2Bytes(A_1);
							int num5;
							if (array.Length != num5)
							{
								goto Block_2;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							int destinationIndex;
							global::System.Array.Copy(array, 0, keyValuePair.Value.Data, destinationIndex, num5);
							byte[] data = keyValuePair.Value.Data;
							int num6;
							global::Motorola.Common.Communication.v.a(ref data, 1, num6 - 3);
							goto IL_223;
						}
						}
						IL_106:
						num = (short)1260978177;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1:
						goto IL_106;
						IL_223:
						num = (short)1413939200;
						num3 = (int)((global::System.IntPtr)num);
					}
					Block_2:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
					IL_23C:
					IL_260:;
				}
				finally
				{
					num = (short)2054881282;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)7536641;
							if (num != 0)
							{
							}
							num = (short)1788215297;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2F6;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_299;
							}
							continue;
						}
						IL_299:
						if (enumerator == null)
						{
							break;
						}
						num = (short)616824832;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2F6:;
				}
				return;
			}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00015D90 File Offset: 0x00013F90
		public static void a(global::Motorola.Common.Communication.Pba.PbaObject A_0, string A_1, string A_2)
		{
			short num = (short)91357184;
			switch (num)
			{
			default:
			{
				num = (short)722010113;
				if (num != 0)
				{
				}
				num = (short)1642201088;
				short num2 = num;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				string empty = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)1015873540;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							int destinationIndex = 103;
							int destinationIndex2 = 155;
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							int num4 = keyValuePair.Value.Data.Length;
							global::Motorola.Common.Communication.v.a(keyValuePair.Value.Data, 1, num4 - 3);
							byte[] bytes = global::System.Text.Encoding.BigEndianUnicode.GetBytes(A_1);
							byte[] bytes2 = global::System.Text.Encoding.BigEndianUnicode.GetBytes(A_2);
							num = (short)1287782410;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_306;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2129985539;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							goto IL_1BB;
						}
						case 3:
							num = (short)1725300741;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_D3;
							}
							continue;
						case 5:
							goto IL_323;
						case 6:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 1028)
							{
								num = (short)1820262400;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							goto IL_274;
						case 8:
						{
							num = (short)512606031;
							short num5 = num;
							num = (short)226475855;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1BB;
							default:
							{
								num = (short)549519360;
								if (num != 0)
								{
								}
								byte[] bytes2;
								if (bytes2.Length > 34)
								{
									num = (short)1351417857;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								int destinationIndex;
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
								byte[] bytes;
								global::System.Array.Copy(bytes, 0, keyValuePair.Value.Data, destinationIndex, bytes.Length);
								int destinationIndex2;
								global::System.Array.Copy(bytes2, 0, keyValuePair.Value.Data, destinationIndex2, bytes2.Length);
								byte[] data = keyValuePair.Value.Data;
								int num4;
								global::Motorola.Common.Communication.v.a(ref data, 1, num4 - 3);
								num = (short)954925063;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 9:
							num = (short)1472921608;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							byte[] bytes;
							if (bytes.Length <= 8)
							{
								num = (short)1713045513;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_279;
						}
						}
						IL_16B:
						num = (short)1419968514;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D3:
						goto IL_16B;
						IL_1BB:
						num = (short)1943339014;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_274:
					return;
					IL_279:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
					IL_306:
					goto IL_279;
					IL_323:;
				}
				finally
				{
					num = (short)2056388610;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)161415169;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_38F;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_358;
							}
							continue;
						}
						IL_358:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1434648576;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_38F:;
				}
				return;
			}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0001614C File Offset: 0x0001434C
		public static void a(ref byte[] A_0)
		{
			short num = (short)395143803;
			short num2 = num;
			num = (short)472738427;
			switch (num2 == num)
			{
			}
			num = (short)1377828865;
			if (num != 0)
			{
			}
			num = (short)1029570560;
			if (num != 0)
			{
			}
			num = (short)1443233792;
			short num3 = num;
			A_0[18] = 111;
			A_0[34] = 111;
			global::Motorola.Common.Communication.v.a(ref A_0, 0, A_0.Length - 2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00016210 File Offset: 0x00014410
		private static void a(global::Motorola.Common.Communication.Pba.PbaObject A_0, out string A_1, out string A_2)
		{
			short num = (short)927465472;
			switch (num)
			{
			default:
			{
				num = (short)143917057;
				if (num != 0)
				{
				}
				num = (short)801898496;
				short num2 = num;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				A_1 = string.Empty;
				A_2 = string.Empty;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)166461441;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						global::Motorola.Common.Communication.CommonUtil.IshHeader key;
						switch (num3)
						{
						case 0:
							goto IL_287;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_CE;
							}
							continue;
						case 2:
						{
							num = (short)834756314;
							short num4 = num;
							num = (short)1507352282;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_188;
							default:
							{
								num = (short)826146816;
								if (num != 0)
								{
								}
								int sourceIndex = 103;
								int sourceIndex2 = 155;
								int num5 = keyValuePair.Value.Data.Length;
								global::Motorola.Common.Communication.v.a(keyValuePair.Value.Data, 1, num5 - 3);
								byte[] array = new byte[global::Motorola.Common.Communication.v.a];
								byte[] array2 = new byte[global::Motorola.Common.Communication.v.a];
								global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex, array, 0, array.Length);
								global::System.Array.Copy(keyValuePair.Value.Data, sourceIndex2, array2, 0, array2.Length);
								A_1 = global::System.Text.Encoding.BigEndianUnicode.GetString(array).TrimEnd(new char[1]);
								A_2 = global::System.Text.Encoding.BigEndianUnicode.GetString(array2).TrimEnd(new char[1]);
								num = (short)2029846528;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 3:
							goto IL_188;
						case 4:
							num = (short)1836187653;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_2A4;
						case 6:
							if (key.IshType == 1028)
							{
								num = (short)1076756482;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						goto IL_CE;
						IL_188:
						if (!enumerator.MoveNext())
						{
							num = (short)1173815300;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						keyValuePair = enumerator.Current;
						key = keyValuePair.Key;
						num = (short)1539375110;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_16E:
						num = (short)45809667;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CE:
						goto IL_16E;
					}
					IL_287:
					IL_2A4:;
				}
				finally
				{
					num = (short)1163001858;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1686306817;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_30E;
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
						num = (short)2006253568;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_30E:;
				}
				return;
			}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0001654C File Offset: 0x0001474C
		public static void a(global::Motorola.Common.Communication.Pba.PbaObject A_0, byte[] A_1, int A_2)
		{
			short num = (short)1807104569;
			short num2 = num;
			num = (short)541604409;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1493303296;
				if (num != 0)
				{
				}
				num = (short)1546780672;
				switch (num)
				{
				}
				break;
			}
			num = (short)972750849;
			if (num != 0)
			{
			}
			num = (short)358285312;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
			string empty = string.Empty;
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
			try
			{
				num = (short)1327890437;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_254;
					case 1:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
						int num5 = value.Data.Length;
						int sourceIndex = 0;
						value = keyValuePair.Value;
						global::System.Array.Copy(A_1, sourceIndex, value.Data, A_2, A_1.Length);
						value = keyValuePair.Value;
						byte[] data = value.Data;
						global::Motorola.Common.Communication.v.a(ref data, 1, num5 - 3);
						num = (short)1188167680;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1096286216;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader key;
						if (key.IshType == 900)
						{
							num = (short)1079967748;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
						num = (short)969998343;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_116;
						}
						continue;
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)891420674;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
						global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
						num = (short)2042691587;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.Common.Communication.CommonUtil.IshItem value;
						if (value.Data.Length > A_2 + A_1.Length)
						{
							num = (short)870514689;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_271;
					}
					IL_166:
					num = (short)2128674822;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_116:
					goto IL_166;
				}
				IL_254:
				IL_271:;
			}
			finally
			{
				num = (short)1920794624;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_2A6;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)387055618;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2DC;
					}
					IL_2A6:
					if (enumerator == null)
					{
						break;
					}
					num = (short)342687745;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_2DC:;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00016854 File Offset: 0x00014A54
		private static void a(ref byte[] A_0, int A_1, int A_2)
		{
			short num = (short)913308508;
			short num2 = num;
			num = (short)49281884;
			switch (num2 == num)
			{
			}
			num = (short)807075840;
			if (num != 0)
			{
			}
			num = (short)1185546240;
			short num3 = num;
			num = (short)1861091329;
			if (num != 0)
			{
			}
			int num4 = A_0.Length;
			ushort num5 = global::Motorola.Common.Communication.v.a(A_0, A_1, A_2);
			A_0[num4 - 2] = (byte)(num5 >> 8);
			A_0[num4 - 1] = (byte)num5;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00016920 File Offset: 0x00014B20
		private static ushort a(byte[] A_0, int A_1, int A_2)
		{
			short num = (short)1992657215;
			short num2 = num;
			num = (short)1684900159;
			switch (num2 == num)
			{
			}
			num = (short)570556416;
			if (num != 0)
			{
			}
			num = (short)707395584;
			short num3 = num;
			num = (short)2130706433;
			if (num != 0)
			{
			}
			uint num4 = 0U;
			num4 = (uint)global::Motorola.Common.Communication.RcmpBaseMessage.CalculateCRC16(ref num4, A_0, A_1, A_2);
			return (ushort)num4;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000169EC File Offset: 0x00014BEC
		// Note: this type is marked as 'beforefieldinit'.
		static v()
		{
			short num = (short)479133697;
			if (num != 0)
			{
			}
			num = (short)1354101355;
			short num2 = num;
			num = (short)784724587;
			switch (num2 == num)
			{
			}
			num = (short)1614282752;
			short num3 = num;
			num = (short)810418176;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.v.a = 34;
		}

		// Token: 0x04000068 RID: 104
		private static int a;

		// Token: 0x04000069 RID: 105
		private const int b = 164;

		// Token: 0x0400006A RID: 106
		private const int c = 2;
	}
}
