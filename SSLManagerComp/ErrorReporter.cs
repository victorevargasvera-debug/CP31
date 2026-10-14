using System;
using IACustomException;

namespace SSLMangrComp
{
	// Token: 0x02000012 RID: 18
	public sealed class ErrorReporter
	{
		// Token: 0x0600007E RID: 126 RVA: 0x000088C8 File Offset: 0x00006AC8
		private ErrorReporter()
		{
			this.ResetErrorReport();
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000088E4 File Offset: 0x00006AE4
		public static global::SSLMangrComp.ErrorReporter Instance
		{
			get
			{
				short num = (short)644330654;
				short num2 = num;
				num = (short)1457829022;
				switch (num2 == num)
				{
				}
				num = (short)734461953;
				if (num != 0)
				{
				}
				num = (short)1570504704;
				short num3 = num;
				num = (short)2141323264;
				if (num != 0)
				{
				}
				return global::SSLMangrComp.ErrorReporter.b;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00008994 File Offset: 0x00006B94
		public void SetErrorReportCategory(global::SSLMangrComp.ErrorCategory ec)
		{
			short num = (short)826560695;
			short num2 = num;
			num = (short)1559253175;
			switch (num2 == num)
			{
			}
			num = (short)118358016;
			if (num != 0)
			{
			}
			num = (short)2130116608;
			short num3 = num;
			num = (short)1577254913;
			if (num != 0)
			{
			}
			this.a.ErrCat = (uint)ec;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00008A48 File Offset: 0x00006C48
		public void ResetErrorReport()
		{
			short num = (short)1015853625;
			short num2 = num;
			num = (short)146125369;
			switch (num2 == num)
			{
			}
			num = (short)930021377;
			if (num != 0)
			{
			}
			num = (short)694419456;
			short num3 = num;
			num = (short)2077491200;
			if (num != 0)
			{
			}
			this.a.ErrCat = 0U;
			this.a.ErrorID = (global::IACustomException.IACommonErrorCode)0;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00008B0C File Offset: 0x00006D0C
		public uint ReportCategory
		{
			get
			{
				short num = (short)1416489524;
				short num2 = num;
				num = (short)582150708;
				switch (num2 == num)
				{
				}
				num = (short)1970339841;
				if (num != 0)
				{
				}
				num = (short)185991168;
				short num3 = num;
				num = (short)1351352320;
				if (num != 0)
				{
				}
				return this.a.ErrCat;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00008BC4 File Offset: 0x00006DC4
		public global::IACustomException.IACommonErrorCode ReportId
		{
			get
			{
				short num = (short)652345042;
				short num2 = num;
				num = (short)1997143762;
				switch (num2 == num)
				{
				}
				num = (short)77529089;
				if (num != 0)
				{
				}
				num = (short)972095488;
				short num3 = num;
				num = (short)1135345664;
				if (num != 0)
				{
				}
				return this.a.ErrorID;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00008C78 File Offset: 0x00006E78
		public void SendReportOnError(global::SSLMangrComp.ReportOnError_CallBack Rcb)
		{
			short num = (short)1190985728;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1315438592;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				}
				case 1:
					this.CallErrorRepCallback(ref this.a);
					num = (short)1535967235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_F5;
				case 3:
					return;
				case 4:
					goto IL_10D;
				case 5:
				{
					num = (short)42281276;
					short num4 = num;
					num = (short)2059217212;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10D;
					default:
						num = (short)1755447296;
						if (num != 0)
						{
						}
						this.c = Rcb;
						num = (short)1097007106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_65:
				if (Rcb != null)
				{
					num = (short)578027525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F5:
				num = (short)1035599876;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10D:
				if (this.a.ErrorID == (global::IACustomException.IACommonErrorCode)0)
				{
					break;
				}
				num = (short)2818049;
				if (num != 0)
				{
				}
				num = (short)508821505;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00008E08 File Offset: 0x00007008
		public void CallErrorRepCallback(ref global::SSLMangrComp.ErrorReport ErrorRep)
		{
			short num = (short)811073538;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					this.c(ref ErrorRep);
					num = (short)118554624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)634263970;
					short num3 = num;
					num = (short)317921698;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)574685184;
						short num4 = num;
						num = (short)259391488;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					}
					}
					break;
				}
				}
				IL_A8:
				num = (short)2122907649;
				if (num != 0)
				{
				}
				if (this.c == null)
				{
					break;
				}
				num = (short)1769668609;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00008F28 File Offset: 0x00007128
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorReporter()
		{
			short num = (short)814825239;
			short num2 = num;
			num = (short)270483223;
			switch (num2 == num)
			{
			}
			num = (short)1885732865;
			if (num != 0)
			{
			}
			num = (short)1151664128;
			short num3 = num;
			num = (short)2075721728;
			if (num != 0)
			{
			}
			global::SSLMangrComp.ErrorReporter.b = new global::SSLMangrComp.ErrorReporter();
		}

		// Token: 0x04000048 RID: 72
		private global::SSLMangrComp.ErrorReport a;

		// Token: 0x04000049 RID: 73
		private static readonly global::SSLMangrComp.ErrorReporter b;

		// Token: 0x0400004A RID: 74
		private global::SSLMangrComp.ReportOnError_CallBack c;
	}
}
