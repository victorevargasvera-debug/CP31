using System;
using System.IO;
using AcpUtility;

namespace AcpCryptoLib
{
	// Token: 0x02000008 RID: 8
	public class AcpCryptoBase
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00003BF4 File Offset: 0x00001DF4
		static AcpCryptoBase()
		{
			short num = (short)1167740769;
			short num2 = num;
			num = (short)1317228385;
			switch (num2 == num)
			{
			}
			num = (short)2142961665;
			if (num != 0)
			{
			}
			num = (short)915210240;
			if (num != 0)
			{
			}
			num = (short)1642921984;
			short num3 = num;
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003CB4 File Offset: 0x00001EB4
		internal byte[] ExtractHeader(global::System.IO.Stream stream)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			for (;;)
			{
				IL_13:
				num = (short)1320157184;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					goto IL_FA;
				case 1:
					if (stream.CanSeek)
					{
						num = (short)1994784768;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FC;
				case 2:
					goto IL_14E;
				}
				goto IL_4D;
			}
			IL_FC:
			throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("嬇漉椋攍』崑搓猕樗笙栛眝伟䰡У伥嬧਩䈫䄭䐯ሱ䜳䌵䠷䨹医䰽㐿❁⁃晅⹇╉㹋湍⑏㩑㵓╕硗⥙⡛ⱝ՟͡ॣ", a_));
			IL_14E:
			int num4;
			byte[] array = new byte[num4];
			stream.Read(array, 0, array.Length);
			return array;
			IL_4D:
			num = (short)734461953;
			if (num != 0)
			{
			}
			num = (short)2119735460;
			short num5 = num;
			num = (short)1073977508;
			switch ((num5 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_FA:
				byte[] array2 = new byte[10];
				stream.Read(array2, 0, array2.Length);
				num4 = (int)array2[7];
				stream.Seek((long)(-(long)array2.Length), global::System.IO.SeekOrigin.Current);
				num = (short)605159426;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			default:
			{
				num = (short)964820992;
				if (num != 0)
				{
				}
				num4 = 0;
				num = (short)968294401;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003E28 File Offset: 0x00002028
		internal byte[] ExtractSalt(global::System.IO.Stream stream)
		{
			short num = (short)2066153473;
			if (num != 0)
			{
			}
			num = (short)615846237;
			short num2 = num;
			num = (short)1264587101;
			switch (num2 == num)
			{
			}
			num = (short)736231424;
			if (num != 0)
			{
			}
			num = (short)111149056;
			short num3 = num;
			int count = global::AcpCryptoLib.AcpRNGenerator.GetSaltLength(stream.ReadRequestedBytes(4)) - 4;
			return stream.ReadRequestedBytes(count);
		}
	}
}
