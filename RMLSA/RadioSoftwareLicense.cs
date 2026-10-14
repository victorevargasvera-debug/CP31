using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter
{
	// Token: 0x02000004 RID: 4
	public abstract class RadioSoftwareLicense
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002990 File Offset: 0x00000B90
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002A40 File Offset: 0x00000C40
		public string AID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)155334739;
				short num2 = num;
				num = (short)933771347;
				switch (num2 == num)
				{
				}
				num = (short)806289408;
				if (num != 0)
				{
				}
				num = (short)299106304;
				short num3 = num;
				num = (short)1102839809;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1706729688;
				short num2 = num;
				num = (short)2137825496;
				switch (num2 == num)
				{
				}
				num = (short)1117782017;
				if (num != 0)
				{
				}
				num = (short)1383333888;
				short num3 = num;
				num = (short)833683456;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000010 RID: 16
		public abstract bool IsSameLicense(global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense license);

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17
		public abstract bool CanValidateResponseByAID { get; }

		// Token: 0x06000012 RID: 18 RVA: 0x00002AF4 File Offset: 0x00000CF4
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation> GenerateActivationInfo()
		{
			short num = (short)279122871;
			short num2 = num;
			num = (short)1792807863;
			switch (num2 == num)
			{
			}
			num = (short)949485569;
			if (num != 0)
			{
			}
			num = (short)1105920000;
			short num3 = num;
			num = (short)2078605312;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation>();
			global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation item = this.GenerateActivationInfo(this.AID);
			list.Add(item);
			return list;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002BB8 File Offset: 0x00000DB8
		protected global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation GenerateActivationInfo(string aid)
		{
			short num = (short)588626055;
			short num2 = num;
			num = (short)2139732103;
			switch (num2 == num)
			{
			}
			num = (short)2089156609;
			if (num != 0)
			{
			}
			num = (short)319946752;
			short num3 = num;
			num = (short)904790016;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation
			{
				Count = 1,
				ID = aid
			};
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002C90 File Offset: 0x00000E90
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(2019522708 + A_1) + (global::System.IntPtr)98 + (global::System.IntPtr)83 + (global::System.IntPtr)44);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
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
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x04000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
