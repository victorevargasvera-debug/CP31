using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.Server.RMServerContract.DataTransferObjects
{
	// Token: 0x0200000F RID: 15
	public class APXCodeplugDTO : global::Motorola.CommonCPS.Server.RMServerContract.DataTransferObjects.CodeplugDTO
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00012104 File Offset: 0x00010304
		// (set) Token: 0x06000345 RID: 837 RVA: 0x000121B4 File Offset: 0x000103B4
		public byte[] PSK
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1930196897;
				short num2 = num;
				num = (short)1515550625;
				switch (num2 == num)
				{
				}
				num = (short)138674176;
				short num3 = num;
				num = (short)1647443969;
				if (num != 0)
				{
				}
				num = (short)576716800;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)397926315;
				short num2 = num;
				num = (short)1918427051;
				switch (num2 == num)
				{
				}
				num = (short)72941568;
				short num3 = num;
				num = (short)213516288;
				if (num != 0)
				{
				}
				num = (short)2094661633;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00012264 File Offset: 0x00010464
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00012318 File Offset: 0x00010518
		public short PSK_ID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)873449953;
				short num2 = num;
				num = (short)652069345;
				switch (num2 == num)
				{
				}
				num = (short)737607680;
				short num3 = num;
				num = (short)213319681;
				if (num != 0)
				{
				}
				num = (short)1651441664;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1625489409;
				if (num != 0)
				{
				}
				num = (short)517601944;
				short num2 = num;
				num = (short)1541470872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)375390208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1304035328;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x040000BC RID: 188
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] a;

		// Token: 0x040000BD RID: 189
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private short b;
	}
}
