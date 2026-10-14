using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.LocalService;

// Token: 0x02000004 RID: 4
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class a<a, b>
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600003A RID: 58 RVA: 0x0000A00C File Offset: 0x0000820C
	public a Radio
	{
		get
		{
			short num = (short)1361467347;
			short num2 = num;
			num = (short)15226835;
			switch (num2 == num)
			{
			}
			num = (short)1002176513;
			if (num != 0)
			{
			}
			num = (short)1657536512;
			if (num != 0)
			{
			}
			num = (short)277807104;
			short num3 = num;
			return this.a;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600003B RID: 59 RVA: 0x0000A0BC File Offset: 0x000082BC
	public b RadioSummary
	{
		get
		{
			short num = (short)218095687;
			short num2 = num;
			num = (short)635363399;
			switch (num2 == num)
			{
			}
			num = (short)1124139008;
			if (num != 0)
			{
			}
			num = (short)22020097;
			if (num != 0)
			{
			}
			num = (short)1752891392;
			short num3 = num;
			return this.b;
		}
	}

	// Token: 0x0600003C RID: 60 RVA: 0x0000A16C File Offset: 0x0000836C
	[global::System.Diagnostics.DebuggerHidden]
	public a(a A_0, b A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x0000A190 File Offset: 0x00008390
	[global::System.Diagnostics.DebuggerHidden]
	public override bool Equals(object value)
	{
		switch (0)
		{
		case 0:
			goto IL_28;
		}
		int num;
		short num2;
		global::a<a, b> a;
		for (;;)
		{
			IL_0A:
			switch (num)
			{
			case 0:
				goto IL_C4;
			case 1:
				num2 = (short)1066532869;
				num = (int)((global::System.IntPtr)num2);
				continue;
			case 2:
			{
				num2 = (short)794551517;
				short num3 = num2;
				num2 = (short)749462749;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num2 = (short)1147928576;
					if (num2 != 0)
					{
					}
					num2 = (short)21364737;
					if (num2 != 0)
					{
					}
					num2 = (short)984350724;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
			}
			case 3:
				if (this != a)
				{
					num2 = (short)1986199554;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_171;
			case 4:
				if (a != null)
				{
					num2 = (short)1186922497;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				return false;
			case 5:
				if (global::System.Collections.Generic.EqualityComparer<a>.Default.Equals(this.a, a.a))
				{
					num2 = (short)792330240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				return false;
			}
			goto IL_28;
		}
		IL_C4:
		return global::System.Collections.Generic.EqualityComparer<b>.Default.Equals(this.b, a.b);
		IL_171:
		num2 = (short)606928896;
		short num4 = num2;
		return true;
		IL_28:
		a = (value as global::a<a, b>);
		num2 = (short)1081671683;
		num = (int)((global::System.IntPtr)num2);
		goto IL_0A;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x0000A338 File Offset: 0x00008538
	[global::System.Diagnostics.DebuggerHidden]
	public override int GetHashCode()
	{
		short num = (short)1501181998;
		short num2 = num;
		num = (short)1004877870;
		switch (num2 == num)
		{
		}
		num = (short)1292500993;
		if (num != 0)
		{
		}
		num = (short)609484800;
		if (num != 0)
		{
		}
		num = (short)275382272;
		short num3 = num;
		return (-1710185654 * -1521134295 + global::System.Collections.Generic.EqualityComparer<a>.Default.GetHashCode(this.a)) * -1521134295 + global::System.Collections.Generic.EqualityComparer<b>.Default.GetHashCode(this.b);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x0000A418 File Offset: 0x00008618
	[global::System.Diagnostics.DebuggerHidden]
	public override string ToString()
	{
		int a_ = 18;
		short num = (short)1327169537;
		if (num != 0)
		{
		}
		num = (short)1451587008;
		short num2 = num;
		num = (short)554333632;
		switch (num2 == num)
		{
		}
		num = (short)1423310848;
		if (num != 0)
		{
		}
		num = (short)2020278272;
		short num3 = num;
		global::System.IFormatProvider provider = null;
		string format = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("圫唭ု怱唳刵儷唹᰻̽怿㥁瑃㭅摇橉ṋ⽍㑏㭑㭓Օⵗ㝙ㅛ㽝቟᭡䑣孥䡧ᅩ嵫፭偯ཱॳ", a_);
		object[] array = new object[2];
		int num4 = 0;
		a a = this.a;
		array[num4] = ((a != null) ? a.ToString() : null);
		int num5 = 1;
		b b = this.b;
		array[num5] = ((b != null) ? b.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000003 RID: 3
	[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	private readonly a a;

	// Token: 0x04000004 RID: 4
	[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	private readonly b b;
}
