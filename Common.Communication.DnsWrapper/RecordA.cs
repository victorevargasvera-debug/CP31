using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	public class RecordA : global::Motorola.Common.Communication.ResourceRecord
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00004DCC File Offset: 0x00002FCC
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00004E78 File Offset: 0x00003078
		public string IP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)54609303;
				short num2 = num;
				num = (short)1664370071;
				switch (num2 == num)
				{
				default:
				{
					num = (short)499122176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)771031040;
				if (num != 0)
				{
				}
				num = (short)1851719681;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)53166742;
				short num2 = num;
				num = (short)827015830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1621753856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1881604096;
				if (num != 0)
				{
				}
				num = (short)553844737;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004F28 File Offset: 0x00003128
		public override void Serialize(global::System.IO.Stream stream)
		{
			short num = (short)830074913;
			short num2 = num;
			num = (short)741404705;
			switch (num2 == num)
			{
			default:
			{
				num = (short)4259840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)396689409;
			if (num != 0)
			{
			}
			num = (short)1663565824;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
