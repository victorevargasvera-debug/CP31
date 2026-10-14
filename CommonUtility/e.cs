using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CommonUtility;

// Token: 0x02000004 RID: 4
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class e<a, b>
{
	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600001D RID: 29 RVA: 0x00003A24 File Offset: 0x00001C24
	public a f
	{
		get
		{
			short num = (short)592117761;
			if (num != 0)
			{
			}
			num = (short)1245970432;
			short num2 = num;
			num = (short)995120734;
			short num3 = num;
			num = (short)1612797534;
			switch (num3 == num)
			{
			}
			num = (short)874250240;
			if (num != 0)
			{
			}
			return this.a;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600001E RID: 30 RVA: 0x00003AD4 File Offset: 0x00001CD4
	public b s
	{
		get
		{
			short num = (short)800110042;
			short num2 = num;
			num = (short)1114486234;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1302921216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)805699585;
			if (num != 0)
			{
			}
			num = (short)39583744;
			if (num != 0)
			{
			}
			return this.b;
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003B88 File Offset: 0x00001D88
	[global::System.Diagnostics.DebuggerHidden]
	public e(a A_0, b A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00003BAC File Offset: 0x00001DAC
	[global::System.Diagnostics.DebuggerHidden]
	public override bool Equals(object value)
	{
		switch (0)
		{
		case 0:
			goto IL_4F;
		}
		short num;
		int num2;
		global::e<a, b> e;
		for (;;)
		{
			IL_0A:
			num = (short)790822913;
			if (num != 0)
			{
			}
			switch (num2)
			{
			case 0:
			{
				if (!global::System.Collections.Generic.EqualityComparer<a>.Default.Equals(this.a, e.a))
				{
					return false;
				}
				num = (short)49681792;
				short num3 = num;
				num = (short)1198790016;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_167;
				default:
				{
					num = (short)1245970432;
					short num4 = num;
					num = (short)62652416;
					if (num != 0)
					{
					}
					num = (short)1019281410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				break;
			}
			case 1:
				num = (short)82837504;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			case 2:
				goto IL_162;
			case 3:
				if (e != null)
				{
					num = (short)777715713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
			case 4:
				goto IL_167;
			case 5:
				if (this != e)
				{
					num = (short)1887371268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
			}
			goto IL_4F;
			IL_167:
			num = (short)1178468355;
			num2 = (int)((global::System.IntPtr)num);
		}
		IL_162:
		return global::System.Collections.Generic.EqualityComparer<b>.Default.Equals(this.b, e.b);
		IL_4F:
		e = (value as global::e<a, b>);
		num = (short)680263685;
		num2 = (int)((global::System.IntPtr)num);
		goto IL_0A;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00003D5C File Offset: 0x00001F5C
	[global::System.Diagnostics.DebuggerHidden]
	public override int GetHashCode()
	{
		short num = (short)681200585;
		short num2 = num;
		num = (short)791104457;
		switch (num2 == num)
		{
		default:
		{
			num = (short)600571904;
			short num3 = num;
			break;
		}
		case true:
			break;
		}
		num = (short)1961951232;
		if (num != 0)
		{
		}
		num = (short)1645871105;
		if (num != 0)
		{
		}
		return (-75616895 * -1521134295 + global::System.Collections.Generic.EqualityComparer<a>.Default.GetHashCode(this.a)) * -1521134295 + global::System.Collections.Generic.EqualityComparer<b>.Default.GetHashCode(this.b);
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00003E3C File Offset: 0x0000203C
	[global::System.Diagnostics.DebuggerHidden]
	public override string ToString()
	{
		int a_ = 12;
		short num = (short)958529537;
		if (num != 0)
		{
		}
		num = (short)379453440;
		short num2 = num;
		num = (short)1433212963;
		short num3 = num;
		num = (short)812455971;
		switch (num3 == num)
		{
		}
		num = (short)1428488192;
		if (num != 0)
		{
		}
		global::System.IFormatProvider provider = null;
		string format = global::CommonUtility.VersionUtility.b("䘼䐾慀╂敄穆楈お経㉎結獒♔睖摘筚♜湞ᱠ䍢ᡤᩦ", a_);
		object[] array = new object[2];
		int num4 = 0;
		a a = this.a;
		array[num4] = ((a != null) ? a.ToString() : null);
		int num5 = 1;
		b b = this.b;
		array[num5] = ((b != null) ? b.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x0400000E RID: 14
	[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	private readonly a a;

	// Token: 0x0400000F RID: 15
	[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	private readonly b b;
}
