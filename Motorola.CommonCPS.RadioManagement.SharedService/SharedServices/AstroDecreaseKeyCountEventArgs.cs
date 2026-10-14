using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200007A RID: 122
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroDecreaseKeyCountEventArgs : global::System.EventArgs
	{
		// Token: 0x060007F5 RID: 2037 RVA: 0x0005F7D0 File Offset: 0x0005D9D0
		public AstroDecreaseKeyCountEventArgs(string oldModelNumber, byte[] oldFlashCode, int decreaseCount)
		{
			this.oldModelNumber = oldModelNumber;
			this.oldFlashCode = oldFlashCode;
			this.decreaseKeyCount = decreaseCount;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0005F7F8 File Offset: 0x0005D9F8
		public int DecreaseKeyCount
		{
			get
			{
				short num = (short)1784609503;
				short num2 = num;
				num = (short)711457503;
				switch (num2 == num)
				{
				}
				num = (short)1023148032;
				short num3 = num;
				num = (short)758054913;
				if (num != 0)
				{
				}
				num = (short)1458831360;
				if (num != 0)
				{
				}
				return this.decreaseKeyCount;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0005F8AC File Offset: 0x0005DAAC
		public string OldModelNumber
		{
			get
			{
				short num = (short)1836163968;
				short num2 = num;
				num = (short)88318848;
				switch (num2 == num)
				{
				}
				num = (short)397410304;
				short num3 = num;
				num = (short)677576705;
				if (num != 0)
				{
				}
				num = (short)1173356544;
				if (num != 0)
				{
				}
				return this.oldModelNumber;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0005F95C File Offset: 0x0005DB5C
		public byte[] OldFlashCode
		{
			get
			{
				short num = (short)935516536;
				short num2 = num;
				num = (short)480762232;
				switch (num2 == num)
				{
				}
				num = (short)2076311552;
				short num3 = num;
				num = (short)2054291457;
				if (num != 0)
				{
				}
				num = (short)891092992;
				if (num != 0)
				{
				}
				return this.oldFlashCode;
			}
		}

		// Token: 0x040000BA RID: 186
		[global::System.Runtime.Serialization.DataMember]
		private int decreaseKeyCount;

		// Token: 0x040000BB RID: 187
		[global::System.Runtime.Serialization.DataMember]
		private string oldModelNumber;

		// Token: 0x040000BC RID: 188
		[global::System.Runtime.Serialization.DataMember]
		private byte[] oldFlashCode;
	}
}
