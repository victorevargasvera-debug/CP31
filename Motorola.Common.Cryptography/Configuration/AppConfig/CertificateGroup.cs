using System;
using System.Configuration;
using System.Diagnostics;
using Motorola.Common.Cryptography.Autofac;

namespace Motorola.Common.Cryptography.Configuration.AppConfig
{
	// Token: 0x02000020 RID: 32
	[global::System.Diagnostics.DebuggerDisplay("Group = {Type}")]
	public class CertificateGroup : global::System.Configuration.ConfigurationElement
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00005604 File Offset: 0x00003804
		[global::System.Configuration.ConfigurationProperty("type", IsRequired = true)]
		public string Type
		{
			get
			{
				int a_ = 0;
				short num = (short)1815728590;
				short num2 = num;
				num = (short)1184944590;
				switch (num2 == num)
				{
				}
				num = (short)2093809664;
				short num3 = num;
				num = (short)988741633;
				if (num != 0)
				{
				}
				num = (short)1233715200;
				if (num != 0)
				{
				}
				return (string)base[global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("≕⅗⩙㥛", a_)];
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000056D0 File Offset: 0x000038D0
		[global::System.Configuration.ConfigurationProperty("", IsDefaultCollection = true)]
		[global::System.Configuration.ConfigurationCollection(typeof(global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElements), AddItemName = "certificate")]
		public global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElements Elements
		{
			get
			{
				short num = (short)796960055;
				short num2 = num;
				num = (short)2037818679;
				switch (num2 == num)
				{
				}
				num = (short)1882259456;
				short num3 = num;
				num = (short)1395064833;
				if (num != 0)
				{
				}
				num = (short)1036648448;
				if (num != 0)
				{
				}
				return (global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElements)base[""];
			}
		}

		// Token: 0x0400001C RID: 28
		private const string a = "type";

		// Token: 0x0400001D RID: 29
		private const string b = "";
	}
}
