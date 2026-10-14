using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.Pba;

// Token: 0x02000004 RID: 4
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class a<a, b>
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600000F RID: 15 RVA: 0x00002858 File Offset: 0x00000A58
	public a Value
	{
		get
		{
			short num = (short)742589804;
			short num2 = num;
			num = (short)770573676;
			switch (num2 == num)
			{
			}
			num = (short)1367998464;
			short num3 = num;
			num = (short)884342785;
			if (num != 0)
			{
			}
			num = (short)183042048;
			if (num != 0)
			{
			}
			return this.a;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000010 RID: 16 RVA: 0x00002908 File Offset: 0x00000B08
	public b Index
	{
		get
		{
			short num = (short)1189596898;
			short num2 = num;
			num = (short)1125109474;
			switch (num2 == num)
			{
			}
			num = (short)2101936128;
			short num3 = num;
			num = (short)1954873344;
			if (num != 0)
			{
			}
			num = (short)142671873;
			if (num != 0)
			{
			}
			return this.b;
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000029B8 File Offset: 0x00000BB8
	[global::System.Diagnostics.DebuggerHidden]
	public a(a A_0, b A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000029DC File Offset: 0x00000BDC
	[global::System.Diagnostics.DebuggerHidden]
	public override bool Equals(object value)
	{
		short num = (short)751743910;
		short num2 = num;
		num = (short)1840559014;
		int num3;
		switch ((num2 == num) ? 1 : 0)
		{
		case 0:
		case 2:
			IL_CB:
			num = (short)701104130;
			num3 = (int)((global::System.IntPtr)num);
			break;
		case 1:
			goto IL_60;
		default:
		{
			num = (short)2004877312;
			short num4 = num;
			goto IL_60;
		}
		}
		global::a<a, b> a;
		for (;;)
		{
			IL_7F:
			num = (short)463208449;
			if (num != 0)
			{
			}
			switch (num3)
			{
			case 0:
				goto IL_15C;
			case 1:
				if (a != null)
				{
					num = (short)491520004;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
			case 2:
				if (this != a)
				{
					num = (short)1027670021;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
			case 3:
				if (global::System.Collections.Generic.EqualityComparer<a>.Default.Equals(this.a, a.a))
				{
					num = (short)802619392;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
			case 4:
				num = (short)635699203;
				num3 = (int)((global::System.IntPtr)num);
				continue;
			case 5:
				num = (short)1390477313;
				num3 = (int)((global::System.IntPtr)num);
				continue;
			}
			goto IL_C4;
		}
		IL_15C:
		return global::System.Collections.Generic.EqualityComparer<b>.Default.Equals(this.b, a.b);
		IL_60:
		num = (short)1914437632;
		if (num != 0)
		{
		}
		switch (0)
		{
		case 0:
			goto IL_C4;
		}
		goto IL_7F;
		IL_C4:
		a = (value as global::a<a, b>);
		goto IL_CB;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002B80 File Offset: 0x00000D80
	[global::System.Diagnostics.DebuggerHidden]
	public override int GetHashCode()
	{
		short num = (short)2080703137;
		short num2 = num;
		num = (short)2043085473;
		switch (num2 == num)
		{
		}
		num = (short)448593921;
		if (num != 0)
		{
		}
		num = (short)1721696256;
		if (num != 0)
		{
		}
		num = (short)385941504;
		short num3 = num;
		return (1140703263 * -1521134295 + global::System.Collections.Generic.EqualityComparer<a>.Default.GetHashCode(this.a)) * -1521134295 + global::System.Collections.Generic.EqualityComparer<b>.Default.GetHashCode(this.b);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002C60 File Offset: 0x00000E60
	[global::System.Diagnostics.DebuggerHidden]
	public override string ToString()
	{
		int a_ = 16;
		short num = (short)668336129;
		if (num != 0)
		{
		}
		num = (short)371487047;
		short num2 = num;
		num = (short)1028616519;
		switch (num2 == num)
		{
		}
		num = (short)883163136;
		if (num != 0)
		{
		}
		num = (short)412876800;
		short num3 = num;
		global::System.IFormatProvider provider = null;
		string format = global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("뗍ꯏ苓럕듗꿙맛ﻝ\udddf싡鿣훥闧웩쳫꟭黯雱釳軵\ud8f7쟹\udcfb藽ㇿ缁␃笅甇", a_);
		object[] array = new object[2];
		int num4 = 0;
		a a = this.a;
		array[num4] = ((a != null) ? a.ToString() : null);
		int num5 = 1;
		b b = this.b;
		array[num5] = ((b != null) ? b.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x0400000B RID: 11
	[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	private readonly a a;

	// Token: 0x0400000C RID: 12
	[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	private readonly b b;
}
