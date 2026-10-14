using System;
using System.Configuration;
using Motorola.Common.Cryptography.Autofac;

namespace Motorola.Common.Cryptography.Configuration.AppConfig
{
	// Token: 0x02000027 RID: 39
	public class RelyingPartiesSection : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00006008 File Offset: 0x00004208
		[global::System.Configuration.ConfigurationProperty("", IsDefaultCollection = true)]
		[global::System.Configuration.ConfigurationCollection(typeof(global::Motorola.Common.Cryptography.Configuration.AppConfig.RelyingPartyCollection), AddItemName = "relyingParty")]
		public global::Motorola.Common.Cryptography.Configuration.AppConfig.RelyingPartyCollection RelyingParties
		{
			get
			{
				short num = (short)1377412901;
				short num2 = num;
				num = (short)752854821;
				switch (num2 == num)
				{
				}
				num = (short)1461059584;
				short num3 = num;
				num = (short)876871681;
				if (num != 0)
				{
				}
				num = (short)1421475840;
				if (num != 0)
				{
				}
				return (global::Motorola.Common.Cryptography.Configuration.AppConfig.RelyingPartyCollection)base[""];
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000060C0 File Offset: 0x000042C0
		public static global::Motorola.Common.Cryptography.Configuration.AppConfig.RelyingPartiesSection Get(string sectionName = "relyingParties")
		{
			int a_ = 7;
			short num = (short)1925390829;
			short num2 = num;
			num = (short)1255743981;
			switch (num2 == num)
			{
			}
			num = (short)365887488;
			short num3 = num;
			num = (short)1035862017;
			if (num != 0)
			{
			}
			num = (short)526385152;
			if (num != 0)
			{
			}
			global::Motorola.Common.Cryptography.Configuration.AppConfig.RelyingPartiesSection relyingPartiesSection = (global::Motorola.Common.Cryptography.Configuration.AppConfig.RelyingPartiesSection)global::System.Configuration.ConfigurationManager.GetSection(sectionName);
			if (relyingPartiesSection == null)
			{
				throw new global::System.Configuration.ConfigurationErrorsException(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("Ṝぞའբ౤f䥨ᡪ࡬౮հᩲᩴ᥶奸ᕺቼ୾ꆀꎌ꾎\udf90ꎘ뮚爵춠\udaa2첤즦캨ﮪ첬\uddae얰\udab2킴쒶閸鮺즼욾뇀ꛂￄ", a_) + typeof(global::Motorola.Common.Cryptography.Configuration.AppConfig.RelyingPartiesSection).FullName);
			}
			return relyingPartiesSection;
		}

		// Token: 0x04000020 RID: 32
		private const string a = "";

		// Token: 0x04000021 RID: 33
		public const string DefaultSectionName = "relyingParties";
	}
}
