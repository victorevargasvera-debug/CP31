using System;
using System.Threading;

namespace SpecialFeatures.Programming
{
	// Token: 0x02000083 RID: 131
	public sealed class DeviceOperationInProgressWindow : global::System.IDisposable
	{
		// Token: 0x06000A36 RID: 2614 RVA: 0x000BBE6C File Offset: 0x000BA06C
		public void ShowWindow(string message)
		{
			short num = (short)177209345;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)199819264;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_9F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 2:
				{
					num = (short)461569806;
					short num4 = num;
					num = (short)819461902;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9F;
					default:
						goto IL_126;
					}
					break;
				}
				}
				IL_5A:
				num = (short)447807489;
				if (num != 0)
				{
				}
				if (!this.c)
				{
					num = (short)1504378880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_9F:
				this.d = message;
				global::System.Threading.Thread thread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.a));
				thread.SetApartmentState(global::System.Threading.ApartmentState.STA);
				thread.Start();
				this.c = true;
				this.b.WaitOne();
				num = (short)1296105474;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_126:
			num = (short)1263271936;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000BBFB8 File Offset: 0x000BA1B8
		public void CloseWindow()
		{
			short num = (short)509214723;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1196776923;
				short num3 = num;
				num = (short)1749835227;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1543503872;
					short num4 = num;
					num = (short)470286336;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (this.a != null)
						{
							goto IL_149;
						}
						goto IL_164;
					case 1:
						goto IL_127;
					case 2:
						num = (short)1642332160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					case 4:
						this.a.Dispose();
						this.b.WaitOne();
						num = (short)1728708609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AC:
					if (this.c)
					{
						num = (short)45481985;
						if (num != 0)
						{
						}
						num = (short)1584463874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_164;
				}
				}
				IL_149:
				num = (short)1744896004;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_127:
			IL_164:
			this.c = false;
			this.a = null;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x000BC138 File Offset: 0x000BA338
		private void a()
		{
			short num = (short)509655509;
			short num2 = num;
			num = (short)1143978453;
			switch (num2 == num)
			{
			}
			num = (short)875495424;
			if (num != 0)
			{
			}
			num = (short)1557069824;
			short num3 = num;
			num = (short)680787969;
			if (num != 0)
			{
			}
			this.a = new global::SpecialFeatures.Programming.DeviceOpStatusWindow();
			this.a.StatusMsg = this.d;
			this.a.WaitStatusThread = this.b;
			this.a.Run();
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000BC21C File Offset: 0x000BA41C
		private void a(bool A_0)
		{
			short num = (short)943915014;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a != null)
					{
						num = (short)960692227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66;
				case 1:
					if (this.b != null)
					{
						num = (short)245891077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_61;
				case 3:
					this.a.Dispose();
					num = (short)323485700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)645464065;
					if (num != 0)
					{
					}
					num = (short)220634367;
					short num3 = num;
					num = (short)494836991;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_61;
					default:
						num = (short)554369024;
						if (num != 0)
						{
						}
						goto IL_66;
					}
					break;
				}
				case 5:
				{
					num = (short)134545408;
					short num4 = num;
					this.b.Dispose();
					num = (short)2003304455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 7:
					return;
				}
				IL_46:
				if (A_0)
				{
					num = (short)1981218818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_61:
				num = (short)545587200;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_66:
				num = (short)74776577;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000BC3F4 File Offset: 0x000BA5F4
		public void Dispose()
		{
			short num = (short)106561537;
			if (num != 0)
			{
			}
			num = (short)387279380;
			short num2 = num;
			num = (short)1696885268;
			switch (num2 == num)
			{
			}
			num = (short)798294016;
			short num3 = num;
			num = (short)1980301312;
			if (num != 0)
			{
			}
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040003FA RID: 1018
		private global::SpecialFeatures.Programming.DeviceOpStatusWindow a;

		// Token: 0x040003FB RID: 1019
		private global::System.Threading.EventWaitHandle b = new global::System.Threading.EventWaitHandle(false, global::System.Threading.EventResetMode.AutoReset);

		// Token: 0x040003FC RID: 1020
		private bool c;

		// Token: 0x040003FD RID: 1021
		private string d = "";
	}
}
