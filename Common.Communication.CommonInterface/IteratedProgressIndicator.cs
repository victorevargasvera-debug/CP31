using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001F RID: 31
	public class IteratedProgressIndicator : global::Motorola.Common.Communication.IProgressIndicator
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00004024 File Offset: 0x00002224
		public IteratedProgressIndicator(global::Motorola.Common.Communication.IProgressIndicator parentProgress, double progressRate = 1.0)
		{
			this.c = parentProgress;
			this.d = progressRate;
			this.b = 0.0;
			this.a = ((parentProgress == null) ? global::Motorola.Common.Communication.CommonUtil.ProgressStatus.None : parentProgress.CurrentStatus);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000406C File Offset: 0x0000226C
		private IteratedProgressIndicator()
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004080 File Offset: 0x00002280
		public void StartRecord()
		{
			short num = (short)2039676930;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C0;
				case 1:
					this.c.StartRecord();
					goto IL_A8;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (this.c == null)
				{
					break;
				}
				num = (short)1514564574;
				short num3 = num;
				num = (short)1083927518;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)733085696;
					if (num != 0)
					{
					}
					num = (short)795672577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A8:
				num = (short)147456000;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C0:
			num = (short)229244928;
			short num4 = num;
			num = (short)1218838529;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000041A0 File Offset: 0x000023A0
		public void StopRecord()
		{
			short num = (short)664403970;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EA;
				case 1:
					this.c.StopRecord();
					goto IL_D2;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.c == null)
				{
					return;
				}
				num = (short)886344981;
				short num3 = num;
				num = (short)1653574933;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)393217;
					if (num != 0)
					{
					}
					num = (short)473759744;
					if (num != 0)
					{
					}
					num = (short)545259521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D2:
				num = (short)376963072;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EA:
			num = (short)1583349760;
			short num4 = num;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000042C4 File Offset: 0x000024C4
		public global::Motorola.Common.Communication.CommonUtil.ProgressStatus CurrentStatus
		{
			get
			{
				short num = (short)183968051;
				short num2 = num;
				num = (short)1681269043;
				switch (num2 == num)
				{
				}
				num = (short)1002897408;
				if (num != 0)
				{
				}
				num = (short)1360461824;
				short num3 = num;
				num = (short)785448961;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00004374 File Offset: 0x00002574
		public double CurrentProgress
		{
			get
			{
				short num = (short)119729045;
				short num2 = num;
				num = (short)1136520085;
				switch (num2 == num)
				{
				}
				num = (short)342491136;
				if (num != 0)
				{
				}
				num = (short)305528832;
				short num3 = num;
				num = (short)234422273;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004424 File Offset: 0x00002624
		public void SetCurrentScope(int start, int end)
		{
			short num = (short)581763074;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EE;
				case 1:
					this.c.SetCurrentScope(start, end);
					goto IL_D6;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				if (this.c == null)
				{
					return;
				}
				num = (short)1441923073;
				if (num != 0)
				{
				}
				num = (short)1661754929;
				short num3 = num;
				num = (short)1837653553;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)572522496;
					if (num != 0)
					{
					}
					num = (short)2021654529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D6:
				num = (short)2098528256;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EE:
			num = (short)1011417088;
			short num4 = num;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000454C File Offset: 0x0000274C
		public void UpdateProgress(double percent)
		{
			short num = (short)1432435100;
			short num2 = num;
			num = (short)1464613276;
			switch (num2 == num)
			{
			}
			num = (short)1507329;
			if (num != 0)
			{
			}
			num = (short)2102919168;
			short num3 = num;
			num = (short)94371840;
			if (num != 0)
			{
			}
			double a_ = percent - this.b;
			this.b = percent;
			this.a(a_);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000460C File Offset: 0x0000280C
		public void UpdateProgress(double percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus)
		{
			short num = (short)650127551;
			short num2 = num;
			num = (short)1562388671;
			switch (num2 == num)
			{
			}
			num = (short)1444937729;
			if (num != 0)
			{
			}
			num = (short)1707868160;
			short num3 = num;
			num = (short)2090663936;
			if (num != 0)
			{
			}
			double a_ = percent - this.b;
			this.b = percent;
			this.a = processStatus;
			this.a(a_);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000046D8 File Offset: 0x000028D8
		public void IncreaseProcess(double increasePercent)
		{
			short num = (short)367328301;
			short num2 = num;
			num = (short)410319917;
			switch (num2 == num)
			{
			}
			num = (short)1324285953;
			if (num != 0)
			{
			}
			num = (short)1893924864;
			short num3 = num;
			num = (short)510263296;
			if (num != 0)
			{
			}
			this.b += increasePercent;
			this.a(increasePercent);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00004794 File Offset: 0x00002994
		public void IncreaseProcess(double increasePercent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus)
		{
			short num = (short)226146233;
			short num2 = num;
			num = (short)565688249;
			switch (num2 == num)
			{
			}
			num = (short)1056636929;
			if (num != 0)
			{
			}
			num = (short)1731526656;
			short num3 = num;
			num = (short)1015218176;
			if (num != 0)
			{
			}
			this.b += increasePercent;
			this.a = processStatus;
			this.a(increasePercent);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000485C File Offset: 0x00002A5C
		public void Reset()
		{
			short num = (short)113358177;
			short num2 = num;
			num = (short)1346418017;
			switch (num2 == num)
			{
			}
			num = (short)843513857;
			if (num != 0)
			{
			}
			num = (short)1113718784;
			short num3 = num;
			num = (short)501350400;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004904 File Offset: 0x00002B04
		private void a(double A_0)
		{
			short num = (short)1435697154;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C6;
				case 1:
					this.c.IncreaseProcess(A_0 * this.d);
					goto IL_AF;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (this.c == null)
				{
					return;
				}
				num = (short)483409831;
				short num3 = num;
				num = (short)1635336103;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1425539072;
					if (num != 0)
					{
					}
					num = (short)108396545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AF:
				num = (short)673316864;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C6:
			num = (short)1338966017;
			if (num != 0)
			{
			}
			num = (short)368705536;
			short num4 = num;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004A2C File Offset: 0x00002C2C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1594063421 + A_1) + (global::System.IntPtr)54 + (global::System.IntPtr)56 + (global::System.IntPtr)63 + (global::System.IntPtr)66 + (global::System.IntPtr)13);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x04000018 RID: 24
		private global::Motorola.Common.Communication.CommonUtil.ProgressStatus a;

		// Token: 0x04000019 RID: 25
		private double b;

		// Token: 0x0400001A RID: 26
		private global::Motorola.Common.Communication.IProgressIndicator c;

		// Token: 0x0400001B RID: 27
		private double d;
	}
}
