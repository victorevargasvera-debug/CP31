using System;

namespace AcpBusinessLayer
{
	// Token: 0x02000029 RID: 41
	public class DifferenceCountChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000311 RID: 785 RVA: 0x0003BEB0 File Offset: 0x0003A0B0
		internal DifferenceCountChangedEventArgs(string name, global::AcpBusinessLayer.DifferenceCountChangedAction action)
		{
			this.a = name;
			this.b = action;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0003BED4 File Offset: 0x0003A0D4
		internal string Name
		{
			get
			{
				short num = (short)633217505;
				short num2 = num;
				num = (short)1812079073;
				switch (num2 == num)
				{
				}
				num = (short)390004737;
				if (num != 0)
				{
				}
				num = (short)1524105216;
				if (num != 0)
				{
				}
				num = (short)956235776;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0003BF84 File Offset: 0x0003A184
		internal global::AcpBusinessLayer.DifferenceCountChangedAction Action
		{
			get
			{
				short num = (short)59413096;
				short num2 = num;
				num = (short)594186856;
				switch (num2 == num)
				{
				}
				num = (short)1593311232;
				if (num != 0)
				{
				}
				num = (short)1666580481;
				if (num != 0)
				{
				}
				num = (short)1607663616;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x040000A9 RID: 169
		private string a;

		// Token: 0x040000AA RID: 170
		private global::AcpBusinessLayer.DifferenceCountChangedAction b;
	}
}
