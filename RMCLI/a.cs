using System;
using CommonLicenseInterfaceWrapper;

namespace commonLicensing
{
	// Token: 0x02000003 RID: 3
	internal class a : global::System.IDisposable
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public void Dispose()
		{
			for (;;)
			{
				IL_00:
				short num = (short)1571291136;
				short num2 = num;
				num = (short)963510273;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_A4;
					case 1:
						num = (short)257818625;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 2:
					{
						num = (short)172226560;
						short num4 = num;
						num = (short)410908672;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)2021654528;
							if (num != 0)
							{
							}
							goto IL_90;
						}
						break;
					}
					case 3:
						goto IL_90;
					}
					IL_85:
					global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface = this.a;
					if (commonClientLicensingInterface == null)
					{
						num = (short)487456770;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					commonClientLicensingInterface.Dispose();
					num = (short)70123523;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_90:
					num = (short)1330315264;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_A4:
			global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface2 = this.b;
			if (commonClientLicensingInterface2 == null)
			{
				return;
			}
			commonClientLicensingInterface2.Dispose();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002268 File Offset: 0x00000468
		public void a(global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface A_0, bool A_1)
		{
			if (A_1)
			{
				short num = (short)87233929;
				short num2 = num;
				num = (short)1635915145;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1589379072;
					short num3 = num;
					num = (short)1236336641;
					if (num != 0)
					{
					}
					num = (short)1965293568;
					if (num != 0)
					{
					}
					this.b = A_0;
					return;
				}
				}
			}
			this.a = A_0;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002328 File Offset: 0x00000528
		public global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface a(bool A_0)
		{
			short num = (short)2090532865;
			if (num != 0)
			{
			}
			if (A_0)
			{
				num = (short)1477353967;
				short num2 = num;
				num = (short)982295023;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A7;
				case 1:
					break;
				default:
				{
					num = (short)933691392;
					short num3 = num;
					break;
				}
				}
				num = (short)813629440;
				if (num != 0)
				{
				}
				return this.b;
			}
			IL_A7:
			return this.a;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023E4 File Offset: 0x000005E4
		public void b(bool A_0)
		{
			short num = (short)1697382403;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B7;
				case 1:
					goto IL_134;
				case 2:
				{
					num = (short)1946628360;
					short num3 = num;
					num = (short)437334280;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)262144;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)51707904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				}
				IL_36:
				if (A_0)
				{
					num = (short)1427898370;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1987903489;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B7:
			num = (short)668205056;
			short num4 = num;
			num = (short)616235009;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface = this.b;
			if (commonClientLicensingInterface == null)
			{
				return;
			}
			commonClientLicensingInterface.Dispose();
			return;
			IL_134:
			global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface commonClientLicensingInterface2 = this.a;
			if (commonClientLicensingInterface2 == null)
			{
				return;
			}
			commonClientLicensingInterface2.Dispose();
		}

		// Token: 0x04000003 RID: 3
		private global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface a;

		// Token: 0x04000004 RID: 4
		private global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface b;
	}
}
