using System;
using Motorola.Common.Cryptography.Autofac;

namespace Motorola.Common.Cryptography.Exceptions
{
	// Token: 0x02000014 RID: 20
	public class NoCertificatesFoundException : global::Motorola.Common.Cryptography.Exceptions.CryptographyException
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003ED4 File Offset: 0x000020D4
		public NoCertificatesFoundException(global::Motorola.Common.Cryptography.CertificateType? registryValue) : base(global::Motorola.Common.Cryptography.Exceptions.NoCertificatesFoundException.a(registryValue))
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003EF0 File Offset: 0x000020F0
		private static string a(global::Motorola.Common.Cryptography.CertificateType? A_0)
		{
			int a_ = 5;
			short num = (short)1537542435;
			short num2 = num;
			num = (short)1962936611;
			switch (num2 == num)
			{
			}
			num = (short)1216479232;
			short num3 = num;
			num = (short)1628897281;
			if (num != 0)
			{
			}
			num = (short)2116681728;
			if (num != 0)
			{
			}
			return string.Format(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ᕚ㉜罞ɠ٢ᝤ፦h൪Ѭ౮ၰݲၴѶ奸ᵺቼ੾ꖄ力권ﺐﶒﺖﺘ爵얠莢톤\udea6\ud9a8캪鞬辮쪰莲좴", a_), A_0);
		}
	}
}
