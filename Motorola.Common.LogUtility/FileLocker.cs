using System;
using System.Globalization;
using System.Threading;
using Motorola.Common.LogUtility.PerformanceMeasurement;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000012 RID: 18
	public class FileLocker : global::System.IDisposable
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000C024 File Offset: 0x0000A224
		public FileLocker(string fileName)
		{
			int a_ = 2;
			this.b = string.Empty;
			base..ctor();
			fileName = fileName.Replace(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("੕", a_), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ॕ", a_));
			fileName = fileName.Replace(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("汕", a_), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ॕ", a_));
			this.b = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᅕ㑗㕙㹛㽝౟㹡ὣ噥ᕧ", a_), fileName);
			this.a = new global::System.Threading.Mutex(false, this.b);
			this.a.WaitOne();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public void Dispose()
		{
			short num = (short)1840119808;
			short num2 = num;
			num = (short)477600629;
			short num3 = num;
			num = (short)2040044405;
			switch (num3 == num)
			{
			}
			num = (short)1330970625;
			if (num != 0)
			{
			}
			num = (short)1540227072;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000C184 File Offset: 0x0000A384
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)50659328;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1104289024;
					short num3 = num;
					num = (short)1921391872;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F3;
					default:
						num = (short)2134048768;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					}
					break;
				}
				case 1:
					num = (short)2051735553;
					if (num != 0)
					{
					}
					num = (short)787087362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.a != null)
					{
						num = (short)2038169604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					goto IL_F3;
				}
				IL_84:
				num = (short)244187136;
				short num4 = num;
				if (disposing)
				{
					num = (short)407240705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F3:
				this.a.ReleaseMutex();
				this.a.Close();
				this.a = null;
				num = (short)232652803;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000052 RID: 82
		private global::System.Threading.Mutex a;

		// Token: 0x04000053 RID: 83
		private string b;
	}
}
