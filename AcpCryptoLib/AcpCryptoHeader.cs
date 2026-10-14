using System;

namespace AcpCryptoLib
{
	// Token: 0x0200000A RID: 10
	internal class AcpCryptoHeader : global::AcpCryptoLib.AcpCryptoHeaderBase
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00003FA8 File Offset: 0x000021A8
		internal AcpCryptoHeader(byte[] encrytedData)
		{
			this.a = encrytedData;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003FC4 File Offset: 0x000021C4
		internal AcpCryptoHeader()
		{
			this.a();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003FE0 File Offset: 0x000021E0
		private byte[] b(byte[] A_0)
		{
			short num = (short)1050083329;
			if (num != 0)
			{
			}
			num = (short)832595425;
			short num2 = num;
			num = (short)1105421793;
			switch (num2 == num)
			{
			}
			num = (short)542965760;
			if (num != 0)
			{
			}
			num = (short)1671692288;
			short num3 = num;
			return new global::AcpCryptoLib.AcpSmartNetAlgorithm().Encrypt(A_0);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00004094 File Offset: 0x00002294
		private byte[] b()
		{
			short num = (short)622195496;
			short num2 = num;
			num = (short)20640552;
			switch (num2 == num)
			{
			}
			num = (short)1625882625;
			if (num != 0)
			{
			}
			num = (short)672858112;
			if (num != 0)
			{
			}
			num = (short)2045247488;
			short num3 = num;
			return new global::AcpCryptoLib.AcpSmartNetAlgorithm().Decrypt(this.a);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000414C File Offset: 0x0000234C
		internal override byte[] Data
		{
			get
			{
				short num = (short)2028615717;
				short num2 = num;
				num = (short)1709455397;
				switch (num2 == num)
				{
				}
				num = (short)420806656;
				if (num != 0)
				{
				}
				num = (short)689831937;
				if (num != 0)
				{
				}
				num = (short)2080178176;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00004200 File Offset: 0x00002400
		internal override object Key
		{
			get
			{
				short num = (short)934908134;
				short num2 = num;
				num = (short)1532989670;
				switch (num2 == num)
				{
				}
				num = (short)859766785;
				if (num != 0)
				{
				}
				num = (short)541196288;
				if (num != 0)
				{
				}
				num = (short)1667170304;
				short num3 = num;
				byte[] array = this.b();
				int saltLength = global::AcpCryptoLib.AcpRNGenerator.GetSaltLength(array);
				byte[] array2 = new byte[this.a(array)];
				global::System.Array.Copy(array, saltLength, array2, 0, array2.Length);
				return new global::AcpCryptoLib.AcpKeyManager().GetKey(array2);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000042DC File Offset: 0x000024DC
		private void a()
		{
			short num = (short)1048313857;
			if (num != 0)
			{
			}
			num = (short)797692059;
			short num2 = num;
			num = (short)2001457307;
			switch (num2 == num)
			{
			}
			num = (short)1830158336;
			if (num != 0)
			{
			}
			num = (short)1273298944;
			short num3 = num;
			byte[] array = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(16, 32);
			byte[] array2 = global::AcpCryptoLib.AcpRNGenerator.GenerateRandomBytes(8, 64);
			byte[] array3 = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(16, 32);
			this.a(array, array2.Length);
			byte[] array4 = new byte[array.Length + array2.Length + array3.Length];
			global::System.Array.Copy(array, 0, array4, 0, array.Length);
			global::System.Array.Copy(array2, 0, array4, array.Length, array2.Length);
			global::System.Array.Copy(array3, 0, array4, array.Length + array2.Length, array3.Length);
			this.a = this.b(array4);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000043F8 File Offset: 0x000025F8
		private void a(byte[] A_0, int A_1)
		{
			short num = (short)358547457;
			if (num != 0)
			{
			}
			num = (short)931273350;
			short num2 = num;
			num = (short)1137908358;
			switch (num2 == num)
			{
			}
			num = (short)1570373632;
			if (num != 0)
			{
			}
			num = (short)1890385920;
			short num3 = num;
			A_0[4] = (byte)((int)(A_0[4] & 252) | (A_1 & 3));
			A_0[5] = (byte)((int)(A_0[5] & 243) | (A_1 & 12));
			A_0[6] = (byte)((int)(A_0[6] & 207) | (A_1 & 48));
			A_0[7] = (byte)((int)(A_0[7] & 63) | (A_1 & 192));
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000044E4 File Offset: 0x000026E4
		private int a(byte[] A_0)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_4F;
			}
			short num;
			for (;;)
			{
				IL_13:
				num = (short)1274019840;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					goto IL_F5;
				case 1:
					if (A_0 != null)
					{
						num = (short)1070202880;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7;
				case 2:
				{
					int result;
					return result;
				}
				}
				goto IL_4F;
			}
			IL_F7:
			throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("伅昇簉洋戍礏瘑㐓刕礗渙紛", a_));
			IL_4F:
			num = (short)726061925;
			short num4 = num;
			num = (short)591647589;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F5:
				int result = (int)((A_0[4] & 3) | (A_0[5] & 12) | (A_0[6] & 48) | (A_0[7] & 192));
				num = (short)1544486914;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			default:
			{
				num = (short)833421313;
				if (num != 0)
				{
				}
				num = (short)1700855808;
				if (num != 0)
				{
				}
				int result = 0;
				num = (short)129433601;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			}
		}

		// Token: 0x04000018 RID: 24
		private byte[] a;
	}
}
