using System;
using System.Globalization;
using ASK.Interface;

namespace CommonASK
{
	// Token: 0x02000003 RID: 3
	public class MockSystemKeyData : global::ASK.Interface.ISystemKeyData
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public MockSystemKeyData(global::ASK.Interface.KeyAccessLevelType aclvl, string serialNum, bool otapEnabled, global::ASK.Interface.KeySource src, int id, global::ASK.Interface.KeyType type, string uuid, bool bWriteProtected)
		{
			int a_ = 0;
			base..ctor();
			this.a = aclvl;
			this.b = serialNum;
			this.c = otapEnabled;
			this.d = src;
			this.e = id;
			this.f = id.ToString(global::CommonASK.SystemKeyHelper.b("搛", a_), global::System.Globalization.CultureInfo.InvariantCulture);
			this.g = type;
			this.h = uuid;
			this.i = bWriteProtected;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002198 File Offset: 0x00000398
		public global::ASK.Interface.KeyAccessLevelType AccessLevelType
		{
			get
			{
				short num = (short)1441774916;
				short num2 = num;
				num = (short)1039711556;
				switch (num2 == num)
				{
				}
				num = (short)1928200193;
				if (num != 0)
				{
				}
				num = (short)2098331648;
				short num3 = num;
				num = (short)543817728;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002248 File Offset: 0x00000448
		public string iBtnSerialNum
		{
			get
			{
				short num = (short)1973944321;
				if (num != 0)
				{
				}
				num = (short)743374652;
				short num2 = num;
				num = (short)903413564;
				switch (num2 == num)
				{
				}
				num = (short)998047744;
				short num3 = num;
				num = (short)1073348608;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000022F8 File Offset: 0x000004F8
		public bool OtapEnabled
		{
			get
			{
				short num = (short)1869875098;
				short num2 = num;
				num = (short)1519060890;
				switch (num2 == num)
				{
				}
				num = (short)270467073;
				if (num != 0)
				{
				}
				num = (short)1747386368;
				short num3 = num;
				num = (short)978845696;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000023A8 File Offset: 0x000005A8
		public global::ASK.Interface.KeySource Source
		{
			get
			{
				short num = (short)1909005714;
				short num2 = num;
				num = (short)672996754;
				switch (num2 == num)
				{
				}
				num = (short)869007361;
				if (num != 0)
				{
				}
				num = (short)987168768;
				short num3 = num;
				num = (short)1422262272;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002458 File Offset: 0x00000658
		public int SystemID
		{
			get
			{
				short num = (short)2095121777;
				short num2 = num;
				num = (short)1128007025;
				switch (num2 == num)
				{
				}
				num = (short)762773504;
				if (num != 0)
				{
				}
				num = (short)620822528;
				short num3 = num;
				num = (short)1982595073;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002508 File Offset: 0x00000708
		public string SystemIDHex
		{
			get
			{
				short num = (short)1877479145;
				short num2 = num;
				num = (short)14749417;
				switch (num2 == num)
				{
				}
				num = (short)1479999488;
				if (num != 0)
				{
				}
				num = (short)261292032;
				short num3 = num;
				num = (short)445120513;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000025B8 File Offset: 0x000007B8
		public global::ASK.Interface.KeyType Type
		{
			get
			{
				short num = (short)566608111;
				short num2 = num;
				num = (short)1709687023;
				switch (num2 == num)
				{
				}
				num = (short)1253048320;
				if (num != 0)
				{
				}
				num = (short)621477888;
				short num3 = num;
				num = (short)749207553;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002668 File Offset: 0x00000868
		public string UuId
		{
			get
			{
				short num = (short)1327349998;
				short num2 = num;
				num = (short)1260110062;
				switch (num2 == num)
				{
				}
				num = (short)346882049;
				if (num != 0)
				{
				}
				num = (short)2006319104;
				short num3 = num;
				num = (short)136904704;
				if (num != 0)
				{
				}
				return this.h;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002718 File Offset: 0x00000918
		public bool WriteProtectEnabled
		{
			get
			{
				short num = (short)509083886;
				short num2 = num;
				num = (short)630653166;
				switch (num2 == num)
				{
				}
				num = (short)1345257473;
				if (num != 0)
				{
				}
				num = (short)639303680;
				short num3 = num;
				num = (short)1037041664;
				if (num != 0)
				{
				}
				return this.i;
			}
		}

		// Token: 0x04000003 RID: 3
		private global::ASK.Interface.KeyAccessLevelType a;

		// Token: 0x04000004 RID: 4
		private string b;

		// Token: 0x04000005 RID: 5
		private bool c;

		// Token: 0x04000006 RID: 6
		private global::ASK.Interface.KeySource d;

		// Token: 0x04000007 RID: 7
		private int e;

		// Token: 0x04000008 RID: 8
		private string f;

		// Token: 0x04000009 RID: 9
		private global::ASK.Interface.KeyType g;

		// Token: 0x0400000A RID: 10
		private string h;

		// Token: 0x0400000B RID: 11
		private bool i;
	}
}
