using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.Global
{
	// Token: 0x02000007 RID: 7
	public class ModeAttribute : global::System.Attribute
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000268C File Offset: 0x0000088C
		public ModeAttribute(global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[] modes)
		{
			this.Modes = modes;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000026A8 File Offset: 0x000008A8
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002758 File Offset: 0x00000958
		public global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[] Modes
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)756627238;
				short num2 = num;
				num = (short)2123052838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1663369216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1450901505;
				if (num != 0)
				{
				}
				num = (short)208273408;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)279171647;
				short num2 = num;
				num = (short)1066521151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)728498176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146893825;
				if (num != 0)
				{
				}
				num = (short)1093795840;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x04000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[] a;
	}
}
