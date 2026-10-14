using System;
using System.Configuration;
using Motorola.Common.Cryptography.Exceptions;

namespace Motorola.Common.Cryptography.Configuration.AppConfig
{
	// Token: 0x02000025 RID: 37
	public class CertificateSectionProvider
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public global::Motorola.Common.Cryptography.Configuration.AppConfig.ICertificateSection Get(string certificateSectionName = "certificates")
		{
			short num = (short)1309315442;
			short num2 = num;
			num = (short)354259314;
			switch (num2 == num)
			{
			}
			num = (short)1606680576;
			short num3 = num;
			num = (short)1782448129;
			if (num != 0)
			{
			}
			num = (short)874381312;
			if (num != 0)
			{
			}
			global::System.Configuration.Configuration configuration = global::System.Configuration.ConfigurationManager.OpenExeConfiguration(global::System.Configuration.ConfigurationUserLevel.None);
			global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateSection certificateSection = (global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateSection)((configuration != null) ? configuration.Sections[certificateSectionName] : null);
			if (certificateSection == null)
			{
				throw new global::Motorola.Common.Cryptography.Exceptions.ConfigSectionNotFoundException(certificateSectionName);
			}
			return certificateSection;
		}
	}
}
