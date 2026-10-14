using System;
using System.Collections;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000015 RID: 21
	internal class b
	{
		// Token: 0x0600013B RID: 315 RVA: 0x0001A25C File Offset: 0x0001845C
		public b(global::System.Collections.IComparer A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0001A278 File Offset: 0x00018478
		public int a(string A_0, string A_1)
		{
			if (this.a == null)
			{
				short num;
				for (;;)
				{
					num = (short)2107703296;
					short num2 = num;
					num = (short)2042754200;
					short num3 = num;
					num = (short)2043344024;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6C;
					}
				}
				IL_6C:
				num = (short)64880640;
				if (num != 0)
				{
				}
				num = (short)776536065;
				if (num != 0)
				{
				}
				return string.Compare(A_0, A_1, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return this.a.Compare(A_0, A_1);
		}

		// Token: 0x04000023 RID: 35
		private global::System.Collections.IComparer a;
	}
}
