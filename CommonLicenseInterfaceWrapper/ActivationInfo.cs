using System;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x02000003 RID: 3
	public class ActivationInfo
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000213C File Offset: 0x0000033C
		public static implicit operator global::MSI.ActivationInfo(global::CommonLicenseInterfaceWrapper.ActivationInfo parameter)
		{
			short num = (short)1187737824;
			short num2 = num;
			num = (short)968978656;
			switch (num2 == num)
			{
			}
			num = (short)637075456;
			short num3 = num;
			num = (short)2093481985;
			if (num != 0)
			{
			}
			num = (short)283705344;
			if (num != 0)
			{
			}
			return parameter.a;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021E8 File Offset: 0x000003E8
		public static implicit operator global::CommonLicenseInterfaceWrapper.ActivationInfo(global::MSI.ActivationInfo parameter)
		{
			short num = (short)284775403;
			short num2 = num;
			num = (short)2108707819;
			switch (num2 == num)
			{
			}
			num = (short)904593408;
			short num3 = num;
			num = (short)1718878209;
			if (num != 0)
			{
			}
			num = (short)1236664320;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.ActivationInfo
			{
				a = parameter
			};
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000229C File Offset: 0x0000049C
		static ActivationInfo()
		{
			short num = (short)788279126;
			short num2 = num;
			num = (short)2113285974;
			switch (num2 == num)
			{
			}
			num = (short)601948160;
			if (num != 0)
			{
			}
			num = (short)905641985;
			if (num != 0)
			{
			}
			num = (short)203292672;
			short num3 = num;
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000234C File Offset: 0x0000054C
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002404 File Offset: 0x00000604
		public int activationCount
		{
			get
			{
				short num = (short)1329497085;
				short num2 = num;
				num = (short)2008187901;
				switch (num2 == num)
				{
				}
				num = (short)847970304;
				if (num != 0)
				{
				}
				num = (short)1843593217;
				if (num != 0)
				{
				}
				num = (short)630915072;
				short num3 = num;
				return this.a.activationCount;
			}
			set
			{
				short num = (short)1742820114;
				short num2 = num;
				num = (short)1453282066;
				switch (num2 == num)
				{
				}
				num = (short)1236795393;
				if (num != 0)
				{
				}
				num = (short)812515328;
				if (num != 0)
				{
				}
				num = (short)733937664;
				short num3 = num;
				this.a.activationCount = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000024BC File Offset: 0x000006BC
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002570 File Offset: 0x00000770
		public string activationId
		{
			get
			{
				short num = (short)1359105908;
				short num2 = num;
				num = (short)524701556;
				switch (num2 == num)
				{
				}
				num = (short)566886401;
				if (num != 0)
				{
				}
				num = (short)785973248;
				if (num != 0)
				{
				}
				num = (short)872022016;
				short num3 = num;
				return this.a.activationId;
			}
			set
			{
				short num = (short)34118795;
				short num2 = num;
				num = (short)909286539;
				switch (num2 == num)
				{
				}
				num = (short)367722497;
				if (num != 0)
				{
				}
				num = (short)2144075776;
				if (num != 0)
				{
				}
				num = (short)1939341312;
				short num3 = num;
				this.a.activationId = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private global::MSI.ActivationInfo a = new global::MSI.ActivationInfo();
	}
}
