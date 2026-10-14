using System;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200005F RID: 95
	public class SetValueTask : global::AcpBusinessLayer.UndoRedo.FieldTaskBase
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x0006F04C File Offset: 0x0006D24C
		private SetValueTask()
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0006F060 File Offset: 0x0006D260
		public SetValueTask(global::AcpBusinessLayer.AcpFieldBase field, string newValue)
		{
			this.field = field;
			this.a = newValue;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0006F084 File Offset: 0x0006D284
		public override void Do()
		{
			short num = (short)456654495;
			short num2 = num;
			num = (short)739770015;
			switch (num2 == num)
			{
			}
			num = (short)1610153985;
			if (num != 0)
			{
			}
			num = (short)1050411008;
			short num3 = num;
			num = (short)324009984;
			if (num != 0)
			{
			}
			this.a();
			base.Do();
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0006F13C File Offset: 0x0006D33C
		public override void Undo()
		{
			short num = (short)1426259969;
			if (num != 0)
			{
			}
			num = (short)1533626102;
			short num2 = num;
			num = (short)741951222;
			switch (num2 == num)
			{
			}
			num = (short)615579648;
			short num3 = num;
			num = (short)2033778688;
			if (num != 0)
			{
			}
			this.a();
			base.Undo();
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0006F1F4 File Offset: 0x0006D3F4
		private void a()
		{
			short num = (short)1237161420;
			short num2 = num;
			num = (short)1358665164;
			switch (num2 == num)
			{
			}
			num = (short)1698758657;
			if (num != 0)
			{
			}
			num = (short)1192099840;
			short num3 = num;
			num = (short)1322844160;
			if (num != 0)
			{
			}
			string text = this.field.ToString();
			this.field.ParseValueFrom(this.a);
			this.field.CalculateApplicability();
			this.field.CalculateValidity();
			this.a = text;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0006F2D8 File Offset: 0x0006D4D8
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1457420657 + A_1) + (global::System.IntPtr)21 + (global::System.IntPtr)19 + (global::System.IntPtr)34 + (global::System.IntPtr)22);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
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
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x04000177 RID: 375
		private string a;
	}
}
