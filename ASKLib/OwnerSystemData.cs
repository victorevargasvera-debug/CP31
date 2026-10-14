using System;
using ASK.Interface;

namespace ASKLib
{
	// Token: 0x0200000E RID: 14
	public class OwnerSystemData
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0000B91C File Offset: 0x00009B1C
		public OwnerSystemData(int ownerID, global::ASK.Interface.KeyType ownerType)
		{
			this.a = ownerID;
			this.b = ownerType;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000B940 File Offset: 0x00009B40
		public int OwnerSystemID
		{
			get
			{
				short num = (short)2071920640;
				short num2 = num;
				num = (short)1503190237;
				short num3 = num;
				num = (short)1372511453;
				switch (num3 == num)
				{
				}
				num = (short)1127088129;
				if (num != 0)
				{
				}
				num = (short)941621248;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public string SystemIDHex
		{
			get
			{
				int a_ = 13;
				short num = (short)134414336;
				short num2 = num;
				num = (short)371773747;
				short num3 = num;
				num = (short)1494995251;
				switch (num3 == num)
				{
				}
				num = (short)408485888;
				if (num != 0)
				{
				}
				num = (short)1839005697;
				if (num != 0)
				{
				}
				return this.a.ToString(global::ASKLib.SystemKeyManager.b("뫡", a_));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000BABC File Offset: 0x00009CBC
		public global::ASK.Interface.KeyType OwnerSystemType
		{
			get
			{
				short num = (short)227672064;
				short num2 = num;
				num = (short)811840320;
				short num3 = num;
				num = (short)2085401408;
				switch (num3 == num)
				{
				}
				num = (short)1237516289;
				if (num != 0)
				{
				}
				num = (short)434896896;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0400002C RID: 44
		private int a;

		// Token: 0x0400002D RID: 45
		private global::ASK.Interface.KeyType b;
	}
}
