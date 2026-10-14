using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002F RID: 47
	[global::System.Runtime.Serialization.DataContract]
	public class DeviceInventory
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000B7C4 File Offset: 0x000099C4
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000B878 File Offset: 0x00009A78
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.InnerInventory deviceInventory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)41347748;
				short num2 = num;
				num = (short)1782639268;
				switch (num2 == num)
				{
				}
				num = (short)965672961;
				if (num != 0)
				{
				}
				num = (short)1643905024;
				if (num != 0)
				{
				}
				num = (short)1909129216;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1013801307;
				short num2 = num;
				num = (short)1997431131;
				switch (num2 == num)
				{
				}
				num = (short)176750593;
				if (num != 0)
				{
				}
				num = (short)1846870016;
				if (num != 0)
				{
				}
				num = (short)844038144;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000B924 File Offset: 0x00009B24
		public DeviceInventory(global::Motorola.Common.Communication.InnerInventory inner)
		{
			this.deviceInventory = inner;
		}

		// Token: 0x04000076 RID: 118
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.InnerInventory a;
	}
}
