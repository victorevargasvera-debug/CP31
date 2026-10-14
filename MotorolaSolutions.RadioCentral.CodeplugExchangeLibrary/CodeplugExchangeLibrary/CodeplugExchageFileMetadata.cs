using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CodeplugExchangeLibrary
{
	// Token: 0x02000004 RID: 4
	public sealed class CodeplugExchageFileMetadata
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002348 File Offset: 0x00000548
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000023F8 File Offset: 0x000005F8
		[global::System.Xml.Serialization.XmlElement(IsNullable = false)]
		public string CodeplugVersion
		{
			get
			{
				short num = (short)1206517760;
				short num2 = num;
				num = (short)1201570004;
				short num3 = num;
				num = (short)1494122708;
				switch (num3 == num)
				{
				}
				num = (short)1237057536;
				if (num != 0)
				{
				}
				num = (short)1495007233;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)512098304;
				short num2 = num;
				num = (short)2126535567;
				short num3 = num;
				num = (short)810376079;
				switch (num3 == num)
				{
				}
				num = (short)203489281;
				if (num != 0)
				{
				}
				num = (short)610336768;
				if (num != 0)
				{
				}
				this.a = (char.IsLetter(value[0]) ? value.Substring(1) : value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000024C4 File Offset: 0x000006C4
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002574 File Offset: 0x00000774
		[global::System.Xml.Serialization.XmlElement(IsNullable = false)]
		public string ConfigTargetName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)643629056;
				short num2 = num;
				num = (short)913333722;
				short num3 = num;
				num = (short)274161114;
				switch (num3 == num)
				{
				}
				num = (short)824377345;
				if (num != 0)
				{
				}
				num = (short)159121408;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)794951680;
				short num2 = num;
				num = (short)1966692803;
				short num3 = num;
				num = (short)690248131;
				switch (num3 == num)
				{
				}
				num = (short)1746075648;
				if (num != 0)
				{
				}
				num = (short)1779040257;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002628 File Offset: 0x00000828
		public CodeplugExchageFileMetadata()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000263C File Offset: 0x0000083C
		public CodeplugExchageFileMetadata(string codeplugVersion, string configTargetName)
		{
			this.CodeplugVersion = codeplugVersion;
			this.ConfigTargetName = configTargetName;
		}

		// Token: 0x04000003 RID: 3
		private string a;

		// Token: 0x04000004 RID: 4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;
	}
}
