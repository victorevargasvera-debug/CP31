using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Cryptography.Configuration.AppConfig
{
	// Token: 0x02000021 RID: 33
	[global::System.Reflection.DefaultMember("Item")]
	internal class a : global::System.Configuration.ConfigurationElementCollection
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000057A0 File Offset: 0x000039A0
		protected override global::System.Configuration.ConfigurationElement CreateNewElement()
		{
			short num = (short)665165462;
			short num2 = num;
			num = (short)2084871830;
			switch (num2 == num)
			{
			}
			num = (short)458162176;
			short num3 = num;
			num = (short)996016128;
			if (num != 0)
			{
			}
			num = (short)470548481;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateGroup();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000584C File Offset: 0x00003A4C
		protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
		{
			short num = (short)2105340914;
			short num2 = num;
			num = (short)562426866;
			switch (num2 == num)
			{
			}
			num = (short)465698816;
			short num3 = num;
			num = (short)314703873;
			if (num != 0)
			{
			}
			num = (short)385548288;
			if (num != 0)
			{
			}
			return this.b((global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateGroup)element);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005900 File Offset: 0x00003B00
		private object b(global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateGroup A_0)
		{
			short num = (short)1108750128;
			short num2 = num;
			num = (short)1559703344;
			switch (num2 == num)
			{
			}
			num = (short)1085734912;
			short num3 = num;
			num = (short)43057153;
			if (num != 0)
			{
			}
			num = (short)424411136;
			if (num != 0)
			{
			}
			return A_0.Type;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000059B0 File Offset: 0x00003BB0
		public global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateGroup b(string A_0)
		{
			short num = (short)986119150;
			short num2 = num;
			num = (short)2109012974;
			switch (num2 == num)
			{
			}
			num = (short)785907712;
			short num3 = num;
			num = (short)1273102336;
			if (num != 0)
			{
			}
			num = (short)1066532865;
			if (num != 0)
			{
			}
			global::Motorola.Common.Cryptography.Configuration.AppConfig.a.a a = new global::Motorola.Common.Cryptography.Configuration.AppConfig.a.a();
			a.a = A_0;
			return this.Cast<global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateGroup>().FirstOrDefault(new global::System.Func<global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateGroup, bool>(a.b));
		}

		// Token: 0x02000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600005D RID: 93 RVA: 0x00005AA8 File Offset: 0x00003CA8
			internal bool b(global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateGroup A_0)
			{
				short num = (short)286524979;
				short num2 = num;
				num = (short)59508275;
				switch (num2 == num)
				{
				}
				num = (short)733151232;
				short num3 = num;
				num = (short)393217;
				if (num != 0)
				{
				}
				num = (short)149880832;
				if (num != 0)
				{
				}
				return A_0.Type == this.a;
			}

			// Token: 0x0400001E RID: 30
			public string a;
		}
	}
}
