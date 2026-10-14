using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200007B RID: 123
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroDecodeFlashCodeEventArgs : global::System.EventArgs
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x0005FA0C File Offset: 0x0005DC0C
		public AstroDecodeFlashCodeEventArgs(byte[] flashCode)
		{
			this.flashCode = flashCode;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0005FA28 File Offset: 0x0005DC28
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x0005FADC File Offset: 0x0005DCDC
		[global::System.Runtime.Serialization.DataMember]
		public string DecodeFlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1278279681;
				if (num != 0)
				{
				}
				num = (short)1966796925;
				short num2 = num;
				num = (short)524284029;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816002560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1523187712;
				if (num != 0)
				{
				}
				return this.<DecodeFlashCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1293950811;
				short num2 = num;
				num = (short)2093031259;
				switch (num2 == num)
				{
				}
				num = (short)748552192;
				short num3 = num;
				num = (short)1863122945;
				if (num != 0)
				{
				}
				num = (short)594149376;
				if (num != 0)
				{
				}
				this.<DecodeFlashCode>k__BackingField = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0005FB90 File Offset: 0x0005DD90
		public byte[] FlashCode
		{
			get
			{
				short num = (short)1393812818;
				short num2 = num;
				num = (short)55240018;
				switch (num2 == num)
				{
				}
				num = (short)1149566976;
				short num3 = num;
				num = (short)919404544;
				if (num != 0)
				{
				}
				num = (short)259260417;
				if (num != 0)
				{
				}
				return this.flashCode;
			}
		}

		// Token: 0x040000BD RID: 189
		[global::System.Runtime.Serialization.DataMember]
		private byte[] flashCode;
	}
}
