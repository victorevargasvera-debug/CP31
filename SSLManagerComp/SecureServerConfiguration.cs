using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace SSLMangrComp
{
	// Token: 0x02000022 RID: 34
	[global::System.Runtime.Serialization.KnownType(typeof(global::SSLMangrComp.SecureClientConfiguration))]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class SecureServerConfiguration : global::SSLMangrComp.SecureClientConfiguration
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000DA88 File Offset: 0x0000BC88
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000DB38 File Offset: 0x0000BD38
		[global::System.Runtime.Serialization.DataMember]
		public byte[] DHParameters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)560310563;
				short num2 = num;
				num = (short)25209123;
				switch (num2 == num)
				{
				}
				num = (short)602537985;
				if (num != 0)
				{
				}
				num = (short)141623296;
				short num3 = num;
				num = (short)943521792;
				if (num != 0)
				{
				}
				return this.<DHParameters>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2080630915;
				short num2 = num;
				num = (short)657909891;
				switch (num2 == num)
				{
				}
				num = (short)746258432;
				if (num != 0)
				{
				}
				num = (short)1801191424;
				short num3 = num;
				num = (short)1184432129;
				if (num != 0)
				{
				}
				this.<DHParameters>k__BackingField = value;
			}
		}
	}
}
