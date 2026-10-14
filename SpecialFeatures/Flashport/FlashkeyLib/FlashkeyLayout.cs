using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.Flashport.FlashkeyLib
{
	// Token: 0x02000100 RID: 256
	internal sealed class FlashkeyLayout
	{
		// Token: 0x06000E45 RID: 3653 RVA: 0x000031C7 File Offset: 0x000013C7
		public FlashkeyLayout()
		{
			this.a = new global::System.Collections.Generic.Dictionary<global::SpecialFeatures.Flashport.FlashkeyLib.FieldType, global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout>();
			this.b = false;
			this.d = 0;
			this.e = 0;
			this.f = 5;
			this.c = 0;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00141394 File Offset: 0x0013F594
		internal bool ValidLayout
		{
			get
			{
				short num = (short)1687754034;
				short num2 = num;
				num = (short)762385714;
				switch (num2 == num)
				{
				}
				num = (short)1965228033;
				if (num != 0)
				{
				}
				num = (short)814678016;
				if (num != 0)
				{
				}
				num = (short)1755185152;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00141444 File Offset: 0x0013F644
		internal int KeyDecDataSize
		{
			get
			{
				short num = (short)1165391185;
				short num2 = num;
				num = (short)1930327377;
				switch (num2 == num)
				{
				}
				num = (short)1977155585;
				if (num != 0)
				{
				}
				num = (short)458620928;
				if (num != 0)
				{
				}
				num = (short)999817216;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x001414F4 File Offset: 0x0013F6F4
		internal byte[] GetEncryptedData(byte[] fkeyData)
		{
			short num = (short)1065906930;
			short num2 = num;
			num = (short)1242133234;
			switch (num2 == num)
			{
			}
			num = (short)431947776;
			if (num != 0)
			{
			}
			num = (short)1566507009;
			if (num != 0)
			{
			}
			num = (short)1836711936;
			short num3 = num;
			byte[] array = new byte[fkeyData.Length - 1];
			global::System.Array.Copy(fkeyData, 1, array, 0, array.Length);
			return array;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x001415B4 File Offset: 0x0013F7B4
		internal byte[] GetDecryptedData(byte[] fkeyData)
		{
			short num = (short)1177017138;
			short num2 = num;
			num = (short)1365498674;
			switch (num2 == num)
			{
			}
			num = (short)101580801;
			if (num != 0)
			{
			}
			num = (short)511442944;
			if (num != 0)
			{
			}
			num = (short)1823408128;
			short num3 = num;
			byte[] array = new byte[fkeyData.Length - 1];
			global::System.Array.Copy(fkeyData, 1, array, 0, array.Length);
			return array;
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00141678 File Offset: 0x0013F878
		internal byte[] GetAllData(byte[] data, byte[] keyData)
		{
			int a_ = 15;
			short num = (short)2053963777;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (data.Length == 0)
					{
						num = (short)152305668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C6;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 2:
					num = (short)155189248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_182;
				case 4:
					goto IL_9A;
				case 5:
				{
					num = (short)935201689;
					short num3 = num;
					num = (short)305007513;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9A;
					default:
						num = (short)53084160;
						if (num != 0)
						{
						}
						if (data == null)
						{
							num = (short)75956227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)569245702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					if (keyData.Length != 0)
					{
						num = (short)1142358018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_184;
				case 7:
				{
					num = (short)1172963328;
					short num4 = num;
					num = (short)989069317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4D:
				if (keyData == null)
				{
					goto IL_1B2;
				}
				num = (short)166526983;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9A:
			goto IL_184;
			IL_182:
			goto IL_1B2;
			IL_184:
			num = (short)35323905;
			if (num != 0)
			{
			}
			throw new global::System.IO.InvalidDataException();
			IL_1B2:
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾓ\ude99ﶛ솟", a_));
			IL_1C6:
			byte b = keyData[0];
			byte[] array = new byte[data.Length + 1];
			global::System.Array.Copy(data, 0, array, 1, data.Length);
			array[0] = b;
			return array;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0014186C File Offset: 0x0013FA6C
		internal bool InitLayout(byte[] fkeyData)
		{
			int a_ = 13;
			short num = (short)666304512;
			switch (num)
			{
			default:
			{
				num = (short)1092550660;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout;
					int num3;
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout4;
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout5;
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout6;
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout7;
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout8;
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout9;
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout10;
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout11;
					int num4;
					byte b;
					int value3;
					switch (num2)
					{
					case 0:
						goto IL_9B;
					case 1:
					{
						if (fkeyData.Length == 0)
						{
							num = (short)667222024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b = false;
						fieldLayout = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.EncryptionType, 1, 0, global::System.TypeCode.Byte);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.EncryptionType, fieldLayout);
						global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout2 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FileVersion, 1, 6, global::System.TypeCode.Byte);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FileVersion, fieldLayout2);
						global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout3 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.DateCode, 6, 7, global::System.TypeCode.String, global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding.Bcd);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.DateCode, fieldLayout3);
						this.d = fieldLayout2.Size + fieldLayout3.Size;
						num3 = 22;
						fieldLayout4 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FactOrderNo, 15, 18, global::System.TypeCode.String, global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding.Ascii);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FactOrderNo, fieldLayout4);
						fieldLayout5 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.ModelNumber, 16, 34, global::System.TypeCode.String, global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding.Ascii);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.ModelNumber, fieldLayout5);
						fieldLayout6 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeSize, 1, 71, global::System.TypeCode.Byte);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeSize, fieldLayout6);
						int size = (int)global::System.Convert.ToInt16(this.a(fieldLayout6, fkeyData));
						fieldLayout7 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.Flashcode, size, 72, global::System.TypeCode.String, global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding.Flashcode);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.Flashcode, fieldLayout7);
						fieldLayout8 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeNewSize, 1, fieldLayout7.Offset + fieldLayout7.Size, global::System.TypeCode.Byte);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeNewSize, fieldLayout8);
						int size2 = (int)global::System.Convert.ToInt16(this.a(fieldLayout8, fkeyData));
						fieldLayout9 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeNew, size2, fieldLayout8.Offset + fieldLayout8.Size, global::System.TypeCode.String, global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding.Flashcode);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeNew, fieldLayout9);
						fieldLayout10 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesPurchased, 2, fieldLayout9.Offset + fieldLayout9.Size, global::System.TypeCode.Int16);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesPurchased, fieldLayout10);
						fieldLayout11 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesRemaining, 2, fieldLayout10.Offset + fieldLayout10.Size, global::System.TypeCode.Int16);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesRemaining, fieldLayout11);
						num4 = 0;
						int value = (int)global::System.Convert.ToInt16(this.a(fieldLayout2, fkeyData));
						goto IL_4DC;
					}
					case 2:
					{
						global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout value2 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.ModelNumberNew, 16, fieldLayout11.Offset + fieldLayout11.Size, global::System.TypeCode.String, global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding.Ascii);
						this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.ModelNumberNew, value2);
						num4 = 16;
						num = (short)1425408011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						int value;
						if (global::System.Convert.ToInt16(value) != 4)
						{
							num = (short)116523010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A6;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					case 5:
					{
						if (b != global::System.Convert.ToByte(value3))
						{
							goto IL_577;
						}
						num = (short)710139055;
						short num5 = num;
						num = (short)166780079;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4DC;
						default:
							num = (short)1967783936;
							if (num != 0)
							{
							}
							num = (short)1340080134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						this.b = true;
						num = (short)1868300298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)2010775553;
						if (num != 0)
						{
						}
						num = (short)1188298755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_167;
					case 9:
					{
						num = (short)459735040;
						short num6 = num;
						int value;
						if (global::System.Convert.ToInt16(value) == 3)
						{
							num = (short)121438215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A6;
					}
					case 10:
						goto IL_18D;
					case 11:
						goto IL_1A6;
					}
					IL_7F:
					if (fkeyData == null)
					{
						num = (short)1847787520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)100139009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A6:
					this.e = fieldLayout4.Size + fieldLayout5.Size + fieldLayout6.Size + fieldLayout7.Size + fieldLayout8.Size + fieldLayout9.Size + fieldLayout10.Size + fieldLayout11.Size + num3 + num4;
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout12 = new global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.Checksum, 1, fieldLayout.Size + this.d + this.f + this.f + this.e, global::System.TypeCode.Byte);
					this.a.Add(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.Checksum, fieldLayout12);
					this.c = fieldLayout.Size + this.d + this.f + this.e + this.f + fieldLayout12.Size;
					b = 0;
					global::SpecialFeatures.Flashport.FlashkeyLib.Crc8Generator crc8Generator = new global::SpecialFeatures.Flashport.FlashkeyLib.Crc8Generator();
					value3 = (int)global::System.Convert.ToInt16(this.a(fieldLayout12, fkeyData));
					b = crc8Generator.Compute(fkeyData, fieldLayout.Offset + fieldLayout.Size, this.c - fieldLayout.Size - fieldLayout12.Size, b);
					num = (short)313393157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DC:
					num = (short)1243086857;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9B:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("撚\udc97ﮙﾝ", a_));
				IL_167:
				throw new global::System.IO.InvalidDataException();
				IL_18D:
				IL_577:
				return this.b;
			}
			}
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00141DF8 File Offset: 0x0013FFF8
		internal object GetFieldValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType fieldType, byte[] data)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			short num2;
			object result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout = this.a[fieldType];
					num2 = (short)1155661829;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_8F;
				case 2:
					if (this.a != null)
					{
						num2 = (short)1576665094;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
				{
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout;
					result = this.a(fieldLayout, data);
					num2 = (short)880476161;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (this.a.ContainsKey(fieldType))
					{
						num2 = (short)1401487360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
				{
					global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout;
					if (fieldLayout != null)
					{
						num2 = (short)2013331457;
						if (num2 != 0)
						{
						}
						num2 = (short)822673411;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B7;
				}
				case 6:
				{
					num2 = (short)1766417396;
					short num3 = num2;
					num2 = (short)164324340;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8F;
					default:
					{
						num2 = (short)1252524032;
						if (num2 != 0)
						{
						}
						num2 = (short)1324220416;
						short num4 = num2;
						num2 = (short)770965508;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_35;
			}
			IL_8F:
			return result;
			IL_1B7:
			throw new global::System.NullReferenceException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			IL_35:
			result = null;
			num2 = (short)754450434;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00141FD4 File Offset: 0x001401D4
		private object a(global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout A_0, byte[] A_1)
		{
			int a_ = 7;
			short num = (short)689635328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C5;
				}
				object result;
				for (;;)
				{
					IL_32:
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_534;
					case 1:
						if (A_1 == null)
						{
							num = (short)23527440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1192558607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)87752729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (A_0.Encoding == global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding.Bcd)
						{
							num = (short)1544814621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1500250121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_3F2;
					case 5:
						goto IL_46B;
					case 6:
						goto IL_149;
					case 7:
					{
						global::System.TypeCode tcode;
						if (tcode != global::System.TypeCode.String)
						{
							num = (short)2102984706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)191168526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)73269255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (A_0.Encoding == global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding.Flashcode)
						{
							num = (short)1007484950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C5;
					case 10:
						goto IL_100;
					case 11:
					{
						byte[] array;
						if (num3 >= array.Length)
						{
							num = (short)425197600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = array[num3];
						num = (short)577175582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_256;
					case 13:
						goto IL_586;
					case 14:
						if (A_0.Encoding == global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding.Ascii)
						{
							num = (short)1819738131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)32112643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						if (A_1.Length < A_0.Offset + A_0.Size)
						{
							num = (short)836632599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array = new byte[A_0.Size];
						global::System.Array.Copy(A_1, A_0.Offset, array, 0, A_0.Size);
						global::System.TypeCode tcode = A_0.TCode;
						num = (short)1890639146;
						short num4 = num;
						num = (short)1142611242;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_662;
						case 1:
							break;
						default:
						{
							num = (short)2089877504;
							short num5 = num;
							break;
						}
						}
						num = (short)1073676288;
						if (num != 0)
						{
						}
						num = (short)669253660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_662;
					case 17:
						goto IL_5E8;
					case 18:
					{
						global::System.TypeCode tcode;
						if (tcode != global::System.TypeCode.Int16)
						{
							num = (short)1720844296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						result = ((int)array[1] | (int)array[0] << 8);
						num = (short)2008547332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						char[] array2 = new char[2];
						array2[0] = ' ';
						char[] trimChars = array2;
						byte[] array;
						string @string = new global::System.Text.ASCIIEncoding().GetString(array);
						@string.TrimEnd(trimChars);
						result = @string;
						num = (short)940244992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_256;
					case 21:
					{
						byte b;
						byte b2 = b & 240;
						b2 = (byte)(b2 >> 4);
						num = (short)800653338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						byte[] array3 = new byte[24];
						byte[] array;
						array.CopyTo(array3, 0);
						result = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(array3, A_0.Size);
						num = (short)491257887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_2DA;
					case 24:
						num = (short)1334640658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_466;
					case 26:
					{
						byte b2;
						if (b2 > 9)
						{
							num = (short)2075983885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b;
						byte value = b & 15;
						num = (short)1655046177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_3C0;
					case 28:
					{
						global::System.TypeCode tcode;
						if (tcode != global::System.TypeCode.Byte)
						{
							num = (short)1840906264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						result = array[0];
						num = (short)1725235217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(A_0.Size);
						num3 = 0;
						num = (short)1870397460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						byte b;
						if (b != 0)
						{
							num = (short)997785621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46B;
					}
					case 31:
						goto IL_627;
					case 32:
					{
						global::System.Text.StringBuilder stringBuilder;
						result = stringBuilder.ToString();
						num = (short)1836449819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						byte b2;
						if (b2 > 9)
						{
							num = (short)385024006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Text.StringBuilder stringBuilder;
						stringBuilder.Append(b2);
						byte value;
						stringBuilder.Append(value);
						num = (short)412811269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						if (A_0 == null)
						{
							num = (short)1295319050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1144193025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C5;
					IL_256:
					num = (short)1361969163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46B:
					num3++;
					num = (short)1376780300;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_100:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲏ", a_));
				IL_149:
				throw new global::System.IO.InvalidDataException();
				IL_2DA:
				throw new global::System.IO.InvalidDataException();
				IL_3C0:
				return result;
				IL_3C5:
				throw new global::System.NotImplementedException();
				IL_3F2:
				IL_466:
				IL_534:
				return result;
				IL_586:
				throw new global::System.IO.InvalidDataException();
				IL_5E8:
				IL_627:
				return result;
				IL_662:
				num = (short)2038562817;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("揄", a_));
				IL_C5:
				result = null;
				num = (short)418119714;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00142694 File Offset: 0x00140894
		internal void SetFieldValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType fieldType, ref byte[] data, object value)
		{
			int a_ = 13;
			short num = (short)1345388549;
			int num2 = (int)((global::System.IntPtr)num);
			global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_158;
				case 1:
					goto IL_174;
				case 2:
					if (fieldLayout != null)
					{
						num = (short)562495488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19F;
				case 3:
					num = (short)611713025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					fieldLayout = this.a[fieldType];
					num = (short)107648232;
					short num3 = num;
					num = (short)1626838248;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_174;
					default:
					{
						num = (short)994443265;
						if (num != 0)
						{
						}
						num = (short)1253048320;
						short num4 = num;
						num = (short)648675328;
						if (num != 0)
						{
						}
						num = (short)1188691970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				IL_45:
				if (this.a != null)
				{
					num = (short)1982070787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_174:
				if (!this.a.ContainsKey(fieldType))
				{
					return;
				}
				num = (short)1649213444;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_158:
			this.a(fieldLayout, ref data, value);
			this.a(data);
			return;
			IL_19F:
			throw new global::System.NullReferenceException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲏ秊", a_));
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00142854 File Offset: 0x00140A54
		private void a(global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout A_0, ref byte[] A_1, object A_2)
		{
			int a_ = 17;
			short num = (short)1643773952;
			switch (num)
			{
			default:
			{
				num = (short)703725587;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					int offset;
					switch (num2)
					{
					case 0:
					{
						byte[] bytes;
						if (num3 >= bytes.Length)
						{
							num = (short)606404611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1[offset++] = bytes[num3];
						num3++;
						num = (short)2035875854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (A_2 == null)
						{
							num = (short)1963130884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2037121040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2B3;
					case 3:
						return;
					case 4:
						goto IL_15D;
					case 5:
						goto IL_21C;
					case 6:
						num = (short)1074397201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_323;
					case 8:
					{
						byte[] bytes;
						global::System.Array.Reverse(bytes);
						num = (short)878379010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.TypeCode tcode;
						if (tcode != global::System.TypeCode.Byte)
						{
							num = (short)1010237451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_402;
					}
					case 10:
						goto IL_1F2;
					case 11:
						num = (short)2131820545;
						if (num != 0)
						{
						}
						num = (short)1807679503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						num = (short)240713728;
						short num4 = num;
						if (A_1 == null)
						{
							num = (short)990642186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1881997313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (global::System.BitConverter.IsLittleEndian)
						{
							num = (short)1544421384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B3;
					case 14:
						goto IL_21C;
					case 15:
					{
						global::System.TypeCode tcode;
						if (tcode == global::System.TypeCode.Int16)
						{
							byte[] bytes = global::System.BitConverter.GetBytes(global::System.Convert.ToInt16(A_2));
							num = (short)1312358413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1673907404;
						short num5 = num;
						num = (short)1443876044;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_263;
						default:
							num = (short)2001469440;
							if (num != 0)
							{
							}
							num = (short)725942278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
					{
						if (A_1.Length < A_0.Offset + A_0.Size)
						{
							num = (short)1089077255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.TypeCode tcode = A_0.TCode;
						goto IL_263;
					}
					case 17:
						goto IL_120;
					case 18:
						goto IL_B7;
					case 19:
						switch (0)
						{
						case 0:
							goto IL_9C;
						}
						continue;
					}
					IL_9C:
					if (A_0 == null)
					{
						num = (short)1132855314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1254293516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21C:
					num = (short)1027080192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_263:
					num = (short)1610219529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B3:
					offset = A_0.Offset;
					num3 = 0;
					num = (short)1568145413;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B7:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾕﶗ", a_));
				IL_120:
				throw new global::System.NotImplementedException();
				IL_15D:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮙ", a_));
				IL_1F2:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮙ", a_));
				IL_323:
				throw new global::System.IO.InvalidDataException();
				IL_402:
				byte b = global::System.Convert.ToByte(A_2);
				A_1[A_0.Offset] = b;
				return;
			}
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00142C7C File Offset: 0x00140E7C
		private byte a(byte[] A_0)
		{
			short num = (short)1822031873;
			if (num != 0)
			{
			}
			num = (short)529006592;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_8E;
			}
			int num3;
			global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout;
			byte b;
			global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout fieldLayout2;
			for (;;)
			{
				IL_5C:
				switch (num3)
				{
				case 0:
					if (fieldLayout != null)
					{
						num = (short)772538371;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return b;
				case 1:
					b = new global::SpecialFeatures.Flashport.FlashkeyLib.Crc8Generator().Compute(A_0, fieldLayout.Offset + fieldLayout.Size, this.c - fieldLayout.Size - fieldLayout2.Size, b);
					A_0[fieldLayout2.Offset] = b;
					num = (short)868548613;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1197398637;
					short num4 = num;
					num = (short)930339437;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_240;
					default:
						num = (short)1139146752;
						if (num != 0)
						{
						}
						num = (short)597164036;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					num = (short)1858207752;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.a.ContainsKey(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.EncryptionType))
					{
						num = (short)1557004295;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return b;
				case 5:
					return b;
				case 6:
					if (this.a.ContainsKey(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.Checksum))
					{
						num = (short)521666569;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return b;
				case 7:
					goto IL_240;
				case 8:
					if (fieldLayout2 != null)
					{
						num = (short)2006319105;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return b;
				case 9:
					fieldLayout = this.a[global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.EncryptionType];
					fieldLayout2 = this.a[global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.Checksum];
					num = (short)851640320;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this.a != null)
					{
						num = (short)2056126466;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return b;
				}
				goto IL_8E;
				IL_240:
				num = (short)1177485318;
				num3 = (int)((global::System.IntPtr)num);
			}
			return b;
			IL_8E:
			b = 0;
			fieldLayout = null;
			fieldLayout2 = null;
			num = (short)2057240586;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_5C;
		}

		// Token: 0x04000782 RID: 1922
		private global::System.Collections.Generic.Dictionary<global::SpecialFeatures.Flashport.FlashkeyLib.FieldType, global::SpecialFeatures.Flashport.FlashkeyLib.FieldLayout> a;

		// Token: 0x04000783 RID: 1923
		private bool b;

		// Token: 0x04000784 RID: 1924
		private int c;

		// Token: 0x04000785 RID: 1925
		private int d;

		// Token: 0x04000786 RID: 1926
		private int e;

		// Token: 0x04000787 RID: 1927
		private int f;
	}
}
