using System;

namespace AcpCryptoLib
{
	// Token: 0x02000010 RID: 16
	internal class AcpEncryptionHeader : global::AcpCryptoLib.AcpCryptoHeaderBase
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000051FC File Offset: 0x000033FC
		internal AcpEncryptionHeader(byte[] encrytedData)
		{
			this.a = encrytedData;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005218 File Offset: 0x00003418
		internal AcpEncryptionHeader()
		{
			this.a();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005234 File Offset: 0x00003434
		private byte[] b(byte[] A_0)
		{
			short num = (short)1993061839;
			short num2 = num;
			num = (short)1700246991;
			switch (num2 == num)
			{
			}
			num = (short)1996029952;
			if (num != 0)
			{
			}
			num = (short)2143289344;
			short num3 = num;
			num = (short)326631425;
			if (num != 0)
			{
			}
			return new global::AcpCryptoLib.AcpSmartNetAlgorithm().Encrypt(A_0);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000052E8 File Offset: 0x000034E8
		private byte[] b()
		{
			short num = (short)1854052366;
			short num2 = num;
			num = (short)332503054;
			switch (num2 == num)
			{
			}
			num = (short)1568079873;
			if (num != 0)
			{
			}
			num = (short)1336606720;
			short num3 = num;
			num = (short)418906112;
			if (num != 0)
			{
			}
			return new global::AcpCryptoLib.AcpSmartNetAlgorithm().Decrypt(this.a);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000053A0 File Offset: 0x000035A0
		internal override byte[] Data
		{
			get
			{
				short num = (short)1473853375;
				short num2 = num;
				num = (short)1794258879;
				switch (num2 == num)
				{
				}
				num = (short)837287937;
				if (num != 0)
				{
				}
				num = (short)930086912;
				short num3 = num;
				num = (short)590675968;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00005450 File Offset: 0x00003650
		internal override object Key
		{
			get
			{
				short num = (short)192560163;
				short num2 = num;
				num = (short)1268464675;
				switch (num2 == num)
				{
				}
				num = (short)886702081;
				if (num != 0)
				{
				}
				num = (short)1918894080;
				short num3 = num;
				num = (short)748290048;
				if (num != 0)
				{
				}
				byte[] array = this.b();
				int saltLength = global::AcpCryptoLib.AcpRNGenerator.GetSaltLength(array);
				byte[] array2 = new byte[array.Length - saltLength];
				global::System.Array.Copy(array, saltLength, array2, 0, array2.Length);
				int[] positions = this.a(array);
				return new global::AcpCryptoLib.AcpKeyManager().GetKey(array2, positions);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005534 File Offset: 0x00003734
		private void a()
		{
			short num = (short)720784731;
			short num2 = num;
			num = (short)1559121243;
			switch (num2 == num)
			{
			}
			num = (short)233963521;
			if (num != 0)
			{
			}
			num = (short)18612224;
			short num3 = num;
			num = (short)333512704;
			if (num != 0)
			{
			}
			byte[] array = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(32, 64);
			byte[] array2 = global::AcpCryptoLib.AcpRNGenerator.GenerateRandomBytes(64, 128);
			this.a(array, array2.Length - 1);
			byte[] array3 = new byte[array.Length + array2.Length];
			global::System.Array.Copy(array, 0, array3, 0, array.Length);
			global::System.Array.Copy(array2, 0, array3, array.Length, array2.Length);
			this.a = this.b(array3);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005634 File Offset: 0x00003834
		private void a(byte[] A_0, int A_1)
		{
			short num;
			int num3;
			int num4;
			int[] array;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)998375424;
					short num2 = num;
					switch (num3)
					{
					case 0:
						return;
					case 1:
						if (num4 >= 4)
						{
							num = (short)2023161856;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num4] = global::AcpCryptoLib.AcpRNGenerator.GenerateRandomNumber(0, A_1);
						A_0[7 + 4 * num4] = (byte)((int)(A_0[7 + 4 * num4] & 252) | (array[num4] & 3));
						A_0[8 + 4 * num4] = (byte)((int)(A_0[8 + 4 * num4] & 243) | (array[num4] & 12));
						A_0[9 + 4 * num4] = (byte)((int)(A_0[9 + 4 * num4] & 207) | (array[num4] & 48));
						A_0[10 + 4 * num4] = (byte)((int)(A_0[10 + 4 * num4] & 63) | (array[num4] & 192));
						num4++;
						num = (short)2117206018;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1732217290;
						short num5 = num;
						num = (short)954370506;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_79;
						default:
							num = (short)498008064;
							if (num != 0)
							{
							}
							goto IL_95;
						}
						break;
					}
					case 3:
						goto IL_95;
					}
					goto IL_48;
					IL_95:
					num = (short)991559681;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			IL_48:
			num = (short)326893569;
			if (num != 0)
			{
			}
			array = new int[4];
			num4 = 0;
			IL_79:
			num = (short)2058944515;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000057FC File Offset: 0x000039FC
		private int[] a(byte[] A_0)
		{
			short num;
			int num3;
			int[] array;
			int num4;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)175833088;
					short num2 = num;
					switch (num3)
					{
					case 0:
						return array;
					case 1:
						if (num4 >= 4)
						{
							num = (short)433913856;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1990852609;
						if (num != 0)
						{
						}
						array[num4] = (int)((A_0[7 + 4 * num4] & 3) | (A_0[8 + 4 * num4] & 12) | (A_0[9 + 4 * num4] & 48) | (A_0[10 + 4 * num4] & 192));
						num4++;
						num = (short)1046937602;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)90453802;
						short num5 = num;
						num = (short)480196394;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_52;
						default:
							num = (short)1811480576;
							if (num != 0)
							{
							}
							goto IL_69;
						}
						break;
					}
					case 3:
						goto IL_69;
					}
					goto IL_49;
					IL_69:
					num = (short)845807617;
					num3 = (int)((global::System.IntPtr)num);
				}
				return array;
			}
			IL_49:
			array = new int[4];
			num4 = 0;
			IL_52:
			num = (short)467009539;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0400001B RID: 27
		private byte[] a;
	}
}
