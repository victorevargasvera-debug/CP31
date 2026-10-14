using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using AcpUtility;

namespace AcpCryptoLib
{
	// Token: 0x02000011 RID: 17
	public class AcpIBtnEncyptDecrpt
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00005970 File Offset: 0x00003B70
		static AcpIBtnEncyptDecrpt()
		{
			short num = (short)238732497;
			short num2 = num;
			num = (short)1804387537;
			switch (num2 == num)
			{
			}
			num = (short)1732706305;
			if (num != 0)
			{
			}
			num = (short)555286528;
			short num3 = num;
			num = (short)1644298240;
			if (num != 0)
			{
			}
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005A20 File Offset: 0x00003C20
		public AcpIBtnEncyptDecrpt()
		{
			int a_ = 8;
			this.a = global::System.Text.Encoding.ASCII.GetBytes(global::AcpCryptoLib.XmlEncryptionUtil.b("㼆㠈䠊䬌㼎匐−吔‖⬘崚⸜⬞搠ဢᔤḦᰨ漪ᔬἮذ眲ȴĶ稸縺఼ܾɀł睄睆ୈ穊硌硎捐杒ፔᅖ慘浚", a_));
			this.b = new byte[11];
			base..ctor();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005A68 File Offset: 0x00003C68
		private byte[] a()
		{
			short num = (short)1041233511;
			short num2 = num;
			num = (short)1486485095;
			switch (num2 == num)
			{
			}
			num = (short)1267531777;
			if (num != 0)
			{
			}
			num = (short)414842880;
			short num3 = num;
			num = (short)1648754688;
			if (num != 0)
			{
			}
			return global::System.Security.Cryptography.MD5.Create().ComputeHash(this.a).Take(5).ToArray<byte>().Concat(this.b).ToArray<byte>();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005B40 File Offset: 0x00003D40
		public void Encrypt(byte[] pDecrypted, out byte[] pEncrypted)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			short num;
			int num2;
			for (;;)
			{
				IL_13:
				num = (short)1257111553;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					if (pDecrypted.Length != 0)
					{
						goto IL_16D;
					}
					num = (short)1406695851;
					short num3 = num;
					num = (short)1483897259;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_159;
					default:
						num = (short)98041856;
						if (num != 0)
						{
						}
						num = (short)2111307778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_A9;
				case 2:
					goto IL_154;
				case 3:
					if (pDecrypted == null)
					{
						num = (short)1685454849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2102263808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_50;
			}
			IL_A9:
			goto IL_159;
			IL_154:
			throw new global::System.ArgumentException(global::AcpCryptoLib.XmlEncryptionUtil.b("稉䠋欍猏怑洓昕気缙砛㸝䤟儡У䌥䔧娩堫圭", a_), global::AcpCryptoLib.XmlEncryptionUtil.b("稉䠋欍猏怑洓昕気缙砛", a_));
			IL_159:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("稉䠋欍猏怑洓昕気缙砛", a_));
			IL_16D:
			byte[] pwd = this.a();
			pEncrypted = global::AcpCryptoLib.Rc4.Encrypt(pwd, pDecrypted);
			return;
			IL_50:
			num = (short)2027421696;
			short num4 = num;
			pEncrypted = null;
			num = (short)497352707;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005CCC File Offset: 0x00003ECC
		public void Decrypt(byte[] pEncrypted, out byte[] pDecrypted)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (pEncrypted.Length != 0)
					{
						goto IL_169;
					}
					num2 = (short)264971327;
					short num3 = num2;
					num2 = (short)1674978367;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_155;
					default:
						num2 = (short)579076097;
						if (num2 != 0)
						{
						}
						num2 = (short)717160448;
						if (num2 != 0)
						{
						}
						num2 = (short)1963196418;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_82;
				case 2:
					goto IL_150;
				case 3:
					if (pEncrypted == null)
					{
						num2 = (short)168034305;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2109145088;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_29;
			}
			IL_82:
			goto IL_155;
			IL_150:
			throw new global::System.ArgumentException(global::AcpCryptoLib.XmlEncryptionUtil.b("烿䜁樃攅稇猉簋稍甏瘑㐓缕欗㨙礛猝借嘡崣", a_), global::AcpCryptoLib.XmlEncryptionUtil.b("烿䜁樃攅稇猉簋稍甏瘑", a_));
			IL_155:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("烿䜁樃攅稇猉簋稍甏瘑", a_));
			IL_169:
			byte[] pwd = this.a();
			pDecrypted = global::AcpCryptoLib.Rc4.Encrypt(pwd, pEncrypted);
			return;
			IL_29:
			pDecrypted = null;
			num2 = (short)275382272;
			short num4 = num2;
			num2 = (short)992280579;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0400001C RID: 28
		private readonly byte[] a;

		// Token: 0x0400001D RID: 29
		private readonly byte[] b;
	}
}
