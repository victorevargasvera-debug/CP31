using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000082 RID: 130
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroPINPasswordConvertEventArgs : global::System.EventArgs
	{
		// Token: 0x0600081E RID: 2078 RVA: 0x00060F90 File Offset: 0x0005F190
		public AstroPINPasswordConvertEventArgs(string source, bool encrypt)
		{
			this.encrypt = encrypt;
			this.source = source;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00060FB4 File Offset: 0x0005F1B4
		public bool IsEncrypt
		{
			get
			{
				short num = (short)2114921834;
				short num2 = num;
				num = (short)2110793066;
				switch (num2 == num)
				{
				}
				num = (short)150208512;
				short num3 = num;
				num = (short)1497169920;
				if (num != 0)
				{
				}
				num = (short)28770305;
				if (num != 0)
				{
				}
				return this.encrypt;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00061064 File Offset: 0x0005F264
		public string Source
		{
			get
			{
				short num = (short)576922422;
				short num2 = num;
				num = (short)112796470;
				switch (num2 == num)
				{
				}
				num = (short)536805376;
				short num3 = num;
				num = (short)1686700033;
				if (num != 0)
				{
				}
				num = (short)1191641088;
				if (num != 0)
				{
				}
				return this.source;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00061114 File Offset: 0x0005F314
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x000611C8 File Offset: 0x0005F3C8
		public string Target
		{
			get
			{
				short num = (short)621244469;
				short num2 = num;
				num = (short)1338011701;
				switch (num2 == num)
				{
				}
				num = (short)1869545472;
				short num3 = num;
				num = (short)2099904513;
				if (num != 0)
				{
				}
				num = (short)435486720;
				if (num != 0)
				{
				}
				return this.target;
			}
			set
			{
				short num = (short)631868375;
				short num2 = num;
				num = (short)1274055639;
				switch (num2 == num)
				{
				}
				num = (short)687276032;
				short num3 = num;
				num = (short)1296695297;
				if (num != 0)
				{
				}
				num = (short)2112421888;
				if (num != 0)
				{
				}
				this.target = value;
			}
		}

		// Token: 0x040000CE RID: 206
		[global::System.Runtime.Serialization.DataMember]
		private bool encrypt;

		// Token: 0x040000CF RID: 207
		[global::System.Runtime.Serialization.DataMember]
		private string source;

		// Token: 0x040000D0 RID: 208
		[global::System.Runtime.Serialization.DataMember]
		private string target;
	}
}
