using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200007C RID: 124
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroEncodeFlashCodeEventArgs : global::System.EventArgs
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x0005FC40 File Offset: 0x0005DE40
		public AstroEncodeFlashCodeEventArgs(string flashCode)
		{
			this.flashCode = flashCode;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0005FC5C File Offset: 0x0005DE5C
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0005FD0C File Offset: 0x0005DF0C
		[global::System.Runtime.Serialization.DataMember]
		public byte[] EncodeFlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)315538510;
				short num2 = num;
				num = (short)1461501006;
				switch (num2 == num)
				{
				}
				num = (short)1129971712;
				short num3 = num;
				num = (short)1394540545;
				if (num != 0)
				{
				}
				num = (short)1775042560;
				if (num != 0)
				{
				}
				return this.<EncodeFlashCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1464335591;
				short num2 = num;
				num = (short)1757871335;
				switch (num2 == num)
				{
				}
				num = (short)2005598208;
				short num3 = num;
				num = (short)107413505;
				if (num != 0)
				{
				}
				num = (short)127401984;
				if (num != 0)
				{
				}
				this.<EncodeFlashCode>k__BackingField = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0005FDBC File Offset: 0x0005DFBC
		public string FlashCode
		{
			get
			{
				short num = (short)816112526;
				short num2 = num;
				num = (short)1674240910;
				switch (num2 == num)
				{
				}
				num = (short)751828992;
				short num3 = num;
				num = (short)1519124481;
				if (num != 0)
				{
				}
				num = (short)1829175296;
				if (num != 0)
				{
				}
				return this.flashCode;
			}
		}

		// Token: 0x040000BF RID: 191
		[global::System.Runtime.Serialization.DataMember]
		private string flashCode;
	}
}
