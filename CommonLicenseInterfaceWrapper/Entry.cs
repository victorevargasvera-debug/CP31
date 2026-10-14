using System;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x0200000E RID: 14
	public class Entry
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00006C04 File Offset: 0x00004E04
		public static implicit operator global::MSI.Entry(global::CommonLicenseInterfaceWrapper.Entry parameter)
		{
			short num = (short)419424694;
			short num2 = num;
			num = (short)800188854;
			switch (num2 == num)
			{
			default:
			{
				num = (short)997916672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1654521857;
			if (num != 0)
			{
			}
			num = (short)1260126208;
			if (num != 0)
			{
			}
			return parameter.a;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006CB4 File Offset: 0x00004EB4
		public static implicit operator global::CommonLicenseInterfaceWrapper.Entry(global::MSI.Entry parameter)
		{
			short num = (short)773324801;
			if (num != 0)
			{
			}
			num = (short)1358954496;
			short num2 = num;
			num = (short)943359146;
			short num3 = num;
			num = (short)1903723690;
			switch (num3 == num)
			{
			}
			num = (short)1575354368;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.Entry
			{
				a = parameter
			};
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00006D6C File Offset: 0x00004F6C
		static Entry()
		{
			short num = (short)982134984;
			short num2 = num;
			num = (short)1460744392;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1934032896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1669726209;
			if (num != 0)
			{
			}
			num = (short)1947795456;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00006E1C File Offset: 0x0000501C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00006ED0 File Offset: 0x000050D0
		public string deviceId
		{
			get
			{
				short num = (short)198647650;
				short num2 = num;
				num = (short)838279010;
				switch (num2 == num)
				{
				default:
				{
					num = (short)588054528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1319895040;
				if (num != 0)
				{
				}
				num = (short)1438121985;
				if (num != 0)
				{
				}
				return this.a.deviceId;
			}
			set
			{
				short num = (short)1944572991;
				short num2 = num;
				num = (short)1617024063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1671430144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)788856833;
				if (num != 0)
				{
				}
				num = (short)487915520;
				if (num != 0)
				{
				}
				this.a.deviceId = value;
			}
		}

		// Token: 0x0400001D RID: 29
		private global::MSI.Entry a = new global::MSI.Entry();
	}
}
