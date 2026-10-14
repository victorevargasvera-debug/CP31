using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Motorola.Common.Cryptography.Exceptions;

namespace Motorola.Common.Cryptography.Configuration.AppConfig
{
	// Token: 0x02000023 RID: 35
	public class CertificateSection : global::System.Configuration.ConfigurationSection, global::Motorola.Common.Cryptography.Configuration.AppConfig.ICertificateSection
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00005B60 File Offset: 0x00003D60
		[global::System.Configuration.ConfigurationCollection(typeof(global::Motorola.Common.Cryptography.Configuration.AppConfig.a), AddItemName = "group")]
		[global::System.Configuration.ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
		internal global::Motorola.Common.Cryptography.Configuration.AppConfig.a Groups
		{
			get
			{
				short num = (short)898764711;
				short num2 = num;
				num = (short)943263655;
				switch (num2 == num)
				{
				}
				num = (short)345767936;
				short num3 = num;
				num = (short)1845559297;
				if (num != 0)
				{
				}
				num = (short)349044736;
				if (num != 0)
				{
				}
				return (global::Motorola.Common.Cryptography.Configuration.AppConfig.a)base[""];
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005C18 File Offset: 0x00003E18
		public global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement> GetCertificates(string groupName)
		{
			short num = (short)1000734721;
			if (num != 0)
			{
			}
			num = (short)1792251950;
			short num2 = num;
			num = (short)488413230;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1482620928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2143420416;
			if (num != 0)
			{
			}
			global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateGroup certificateGroup = this.Groups.b(groupName);
			if (certificateGroup == null)
			{
				throw new global::Motorola.Common.Cryptography.Exceptions.CertificateGroupNotFoundException(groupName);
			}
			return certificateGroup.Elements.Cast<global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement>();
		}

		// Token: 0x0400001F RID: 31
		private const string a = "";
	}
}
