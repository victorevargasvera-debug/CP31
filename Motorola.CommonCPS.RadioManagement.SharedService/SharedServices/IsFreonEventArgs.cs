using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000029 RID: 41
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class IsFreonEventArgs : global::System.EventArgs
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x00031BF8 File Offset: 0x0002FDF8
		public IsFreonEventArgs(string modelNumber)
		{
			this.modelNumber = modelNumber;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00031C14 File Offset: 0x0002FE14
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		public string ModelNumber
		{
			get
			{
				short num = (short)907113042;
				short num2 = num;
				num = (short)1546416722;
				switch (num2 == num)
				{
				}
				num = (short)1349648385;
				if (num != 0)
				{
				}
				num = (short)1010892800;
				if (num != 0)
				{
				}
				num = (short)1088028672;
				short num3 = num;
				return this.modelNumber;
			}
			set
			{
				short num = (short)1297296324;
				short num2 = num;
				num = (short)71445444;
				switch (num2 == num)
				{
				}
				num = (short)1827536897;
				if (num != 0)
				{
				}
				num = (short)1274085376;
				if (num != 0)
				{
				}
				num = (short)543686656;
				short num3 = num;
				this.modelNumber = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00031D7C File Offset: 0x0002FF7C
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00031E2C File Offset: 0x0003002C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsFreon
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)557679839;
				short num2 = num;
				num = (short)178685151;
				switch (num2 == num)
				{
				}
				num = (short)1947533312;
				if (num != 0)
				{
				}
				num = (short)1339883521;
				if (num != 0)
				{
				}
				num = (short)4915200;
				short num3 = num;
				return this.<IsFreon>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)34537473;
				if (num != 0)
				{
				}
				num = (short)520170561;
				short num2 = num;
				num = (short)1699753025;
				switch (num2 == num)
				{
				}
				num = (short)1834680320;
				if (num != 0)
				{
				}
				num = (short)1938161664;
				short num3 = num;
				this.<IsFreon>k__BackingField = value;
			}
		}

		// Token: 0x0400003E RID: 62
		[global::System.Runtime.Serialization.DataMember]
		private string modelNumber;
	}
}
