using System;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x020000A9 RID: 169
	public class RecordOperationEventArgs : global::System.EventArgs
	{
		// Token: 0x06000684 RID: 1668 RVA: 0x00082B48 File Offset: 0x00080D48
		internal RecordOperationEventArgs(global::AcpCommonLib.IAcpFeatureNode A_0, int A_1, int A_2)
		{
			this.a = A_1;
			this.b = A_0;
			this.c = A_2;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00082B70 File Offset: 0x00080D70
		internal int Operation
		{
			get
			{
				short num = (short)526843904;
				short num2 = num;
				num = (short)1443233793;
				if (num != 0)
				{
				}
				num = (short)658196953;
				short num3 = num;
				num = (short)1673087449;
				switch (num3 == num)
				{
				}
				num = (short)1321730048;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00082C20 File Offset: 0x00080E20
		internal int Index
		{
			get
			{
				short num = (short)392167424;
				short num2 = num;
				num = (short)1225653594;
				short num3 = num;
				num = (short)1660026202;
				switch (num3 == num)
				{
				}
				num = (short)780206081;
				if (num != 0)
				{
				}
				num = (short)289079296;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00082CD0 File Offset: 0x00080ED0
		internal global::AcpCommonLib.IAcpFeatureNode FeatureNodeRecord
		{
			get
			{
				short num = (short)228458496;
				short num2 = num;
				num = (short)1016365715;
				short num3 = num;
				num = (short)1224901267;
				switch (num3 == num)
				{
				}
				num = (short)1570570241;
				if (num != 0)
				{
				}
				num = (short)1762656256;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0400033A RID: 826
		private int a;

		// Token: 0x0400033B RID: 827
		private global::AcpCommonLib.IAcpFeatureNode b;

		// Token: 0x0400033C RID: 828
		private int c;
	}
}
