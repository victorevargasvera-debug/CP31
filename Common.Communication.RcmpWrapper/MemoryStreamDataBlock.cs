using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	public class MemoryStreamDataBlock
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00006680 File Offset: 0x00004880
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00006730 File Offset: 0x00004930
		private uint StartAddress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1357250561;
				if (num != 0)
				{
				}
				num = (short)69402624;
				short num2 = num;
				num = (short)858827390;
				short num3 = num;
				num = (short)827763326;
				switch (num3 == num)
				{
				}
				num = (short)1791688704;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)873890528;
				short num2 = num;
				num = (short)1822786272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1609498624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)900005888;
				if (num != 0)
				{
				}
				num = (short)2033844225;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000067E0 File Offset: 0x000049E0
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00006894 File Offset: 0x00004A94
		private uint DataBlockSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1124938237;
				short num2 = num;
				num = (short)302330365;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1691877376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1335754752;
				if (num != 0)
				{
				}
				num = (short)834011137;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)44173789;
				short num2 = num;
				num = (short)222431709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164298752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1907687424;
				if (num != 0)
				{
				}
				num = (short)1394737153;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00006944 File Offset: 0x00004B44
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000069F4 File Offset: 0x00004BF4
		private byte[] Data
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1585106286;
				short num2 = num;
				num = (short)1519570286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)386138112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)836698113;
				if (num != 0)
				{
				}
				num = (short)492699648;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1374013191;
				short num2 = num;
				num = (short)1252837127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)292028416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)481820673;
				if (num != 0)
				{
				}
				num = (short)440795136;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006AA8 File Offset: 0x00004CA8
		public MemoryStreamDataBlock(uint StartAddr, uint DataBlkSize, byte[] data)
		{
			this.StartAddress = StartAddr;
			this.DataBlockSize = DataBlkSize;
			this.Data = data;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006AD0 File Offset: 0x00004CD0
		public int Pack(byte[] buffer, int offset)
		{
			short num = (short)1393921836;
			short num2 = num;
			num = (short)87265068;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2100035584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1056964608;
			if (num != 0)
			{
			}
			num = (short)1180237825;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				this.StartAddress,
				this.DataBlockSize,
				this.Data
			});
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006BAC File Offset: 0x00004DAC
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryStreamDataBlock()
		{
			short num = (short)790691841;
			if (num != 0)
			{
			}
			num = (short)1180368896;
			short num2 = num;
			num = (short)70136461;
			short num3 = num;
			num = (short)114307725;
			switch (num3 == num)
			{
			}
			num = (short)685899776;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.MemoryStreamDataBlock.DataBlockHdrSize = 8;
		}

		// Token: 0x04000025 RID: 37
		public static readonly int DataBlockHdrSize;

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private uint a;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private uint b;

		// Token: 0x04000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] c;
	}
}
