using System;
using System.Collections.Generic;

namespace AcpASKLib
{
	// Token: 0x02000014 RID: 20
	public class AccessRecordData
	{
		// Token: 0x06000094 RID: 148 RVA: 0x0000F88C File Offset: 0x0000DA8C
		internal AccessRecordData(int A_0, byte[] A_1, global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> A_2)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000F968 File Offset: 0x0000DB68
		internal int PrimaryKey
		{
			get
			{
				short num = (short)982675849;
				short num2 = num;
				num = (short)100888969;
				switch (num2 == num)
				{
				}
				num = (short)62259200;
				if (num != 0)
				{
				}
				num = (short)146014209;
				if (num != 0)
				{
				}
				num = (short)208470016;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)141868241;
				short num2 = num;
				num = (short)1647819985;
				switch (num2 == num)
				{
				}
				num = (short)1070923776;
				if (num != 0)
				{
				}
				num = (short)19267585;
				if (num != 0)
				{
				}
				num = (short)807862272;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000FA1C File Offset: 0x0000DC1C
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000FACC File Offset: 0x0000DCCC
		internal byte[] FieldCode
		{
			get
			{
				short num = (short)31889274;
				short num2 = num;
				num = (short)744200058;
				switch (num2 == num)
				{
				}
				num = (short)1136852992;
				if (num != 0)
				{
				}
				num = (short)1422000129;
				if (num != 0)
				{
				}
				num = (short)1773731840;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1434757892;
				short num2 = num;
				num = (short)1530374916;
				switch (num2 == num)
				{
				}
				num = (short)2081619969;
				if (num != 0)
				{
				}
				num = (short)1401552896;
				if (num != 0)
				{
				}
				num = (short)1282801664;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000FB7C File Offset: 0x0000DD7C
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		internal global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> Ranges
		{
			get
			{
				short num = (short)288896139;
				short num2 = num;
				num = (short)1730229387;
				switch (num2 == num)
				{
				}
				num = (short)620888065;
				if (num != 0)
				{
				}
				num = (short)254148608;
				if (num != 0)
				{
				}
				num = (short)69599232;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)111869953;
				if (num != 0)
				{
				}
				num = (short)379098336;
				short num2 = num;
				num = (short)953980128;
				switch (num2 == num)
				{
				}
				num = (short)685178880;
				if (num != 0)
				{
				}
				num = (short)757727232;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x040000EE RID: 238
		private int a;

		// Token: 0x040000EF RID: 239
		private byte[] b;

		// Token: 0x040000F0 RID: 240
		private global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> c;
	}
}
