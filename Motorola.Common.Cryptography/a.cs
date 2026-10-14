using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Motorola.Common.Cryptography.Autofac;

// Token: 0x02000003 RID: 3
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class a<a, b, c, d>
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
	public a Value
	{
		get
		{
			short num = (short)985989121;
			if (num != 0)
			{
			}
			num = (short)1090106827;
			short num2 = num;
			num = (short)1031189963;
			switch (num2 == num)
			{
			}
			num = (short)176619520;
			short num3 = num;
			num = (short)68091904;
			if (num != 0)
			{
			}
			return this.a;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
	public b StoreName
	{
		get
		{
			short num = (short)956804119;
			short num2 = num;
			num = (short)1139125271;
			switch (num2 == num)
			{
			}
			num = (short)851705857;
			if (num != 0)
			{
			}
			num = (short)1760231424;
			short num3 = num;
			num = (short)1925578752;
			if (num != 0)
			{
			}
			return this.b;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000006 RID: 6 RVA: 0x0000227C File Offset: 0x0000047C
	public c StoreLocation
	{
		get
		{
			short num = (short)844031022;
			short num2 = num;
			num = (short)252240942;
			switch (num2 == num)
			{
			}
			num = (short)251330561;
			if (num != 0)
			{
			}
			num = (short)1420165120;
			short num3 = num;
			num = (short)1733558272;
			if (num != 0)
			{
			}
			return this.c;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000007 RID: 7 RVA: 0x0000232C File Offset: 0x0000052C
	public d X509FindType
	{
		get
		{
			short num = (short)364427835;
			short num2 = num;
			num = (short)554875451;
			switch (num2 == num)
			{
			}
			num = (short)1148321793;
			if (num != 0)
			{
			}
			num = (short)465764352;
			short num3 = num;
			num = (short)1168637952;
			if (num != 0)
			{
			}
			return this.d;
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000023DC File Offset: 0x000005DC
	[global::System.Diagnostics.DebuggerHidden]
	public a(a A_0, b A_1, c A_2, d A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000240C File Offset: 0x0000060C
	[global::System.Diagnostics.DebuggerHidden]
	public override bool Equals(object value)
	{
		switch (0)
		{
		case 0:
			goto IL_38;
		}
		int num;
		short num2;
		global::a<a, b, c, d> a;
		for (;;)
		{
			IL_0A:
			switch (num)
			{
			case 0:
			{
				num2 = (short)824619888;
				short num3 = num2;
				num2 = (short)1451144048;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FD;
				default:
					num2 = (short)1632305152;
					if (num2 != 0)
					{
					}
					if (global::System.Collections.Generic.EqualityComparer<a>.Default.Equals(this.a, a.a))
					{
						num2 = (short)309592070;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				break;
			}
			case 1:
				if (global::System.Collections.Generic.EqualityComparer<c>.Default.Equals(this.c, a.c))
				{
					num2 = (short)371851269;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				return false;
			case 2:
				num2 = (short)1169162241;
				if (num2 != 0)
				{
				}
				num2 = (short)1923350531;
				num = (int)((global::System.IntPtr)num2);
				continue;
			case 3:
				if (a != null)
				{
					num2 = (short)922812425;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				return false;
			case 4:
				goto IL_FD;
			case 5:
				goto IL_241;
			case 6:
				num2 = (short)1739456520;
				num = (int)((global::System.IntPtr)num2);
				continue;
			case 7:
				if (this != a)
				{
					num2 = (short)749928450;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				return true;
			case 8:
				if (global::System.Collections.Generic.EqualityComparer<b>.Default.Equals(this.b, a.b))
				{
					num2 = (short)702414852;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				return false;
			case 9:
				num2 = (short)97124352;
				num = (int)((global::System.IntPtr)num2);
				continue;
			}
			goto IL_38;
			IL_FD:
			num2 = (short)520028161;
			num = (int)((global::System.IntPtr)num2);
		}
		return false;
		IL_241:
		num2 = (short)2095644672;
		short num4 = num2;
		return global::System.Collections.Generic.EqualityComparer<d>.Default.Equals(this.d, a.d);
		IL_38:
		a = (value as global::a<a, b, c, d>);
		num2 = (short)1180762119;
		num = (int)((global::System.IntPtr)num2);
		goto IL_0A;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002660 File Offset: 0x00000860
	[global::System.Diagnostics.DebuggerHidden]
	public override int GetHashCode()
	{
		short num = (short)1222416867;
		short num2 = num;
		num = (short)1313905123;
		switch (num2 == num)
		{
		}
		num = (short)650969089;
		if (num != 0)
		{
		}
		num = (short)72548352;
		short num3 = num;
		num = (short)374407168;
		if (num != 0)
		{
		}
		return (((1928939170 * -1521134295 + global::System.Collections.Generic.EqualityComparer<a>.Default.GetHashCode(this.a)) * -1521134295 + global::System.Collections.Generic.EqualityComparer<b>.Default.GetHashCode(this.b)) * -1521134295 + global::System.Collections.Generic.EqualityComparer<c>.Default.GetHashCode(this.c)) * -1521134295 + global::System.Collections.Generic.EqualityComparer<d>.Default.GetHashCode(this.d);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002768 File Offset: 0x00000968
	[global::System.Diagnostics.DebuggerHidden]
	public override string ToString()
	{
		int a_ = 1;
		short num = (short)1616052225;
		if (num != 0)
		{
		}
		num = (short)1878332146;
		short num2 = num;
		num = (short)118297330;
		switch (num2 == num)
		{
		}
		num = (short)2103836672;
		short num3 = num;
		num = (short)1343422464;
		if (num != 0)
		{
		}
		global::System.IFormatProvider provider = null;
		string format = global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ⱖ≘筚ଡ଼㹞ൠᙢd䝦周䭪ᙬ彮౰彲啴⑶൸ᑺོ᩾쾀ꦈ뚊권ꂐ릔랖쪘쒠쪤쒦좨\udfaa쒬삮\udfb0鎲袴鞶슸覺삼鎾鯂跊꓌ꇎ뗐蟒곔Ꟗ볘ﯚ￞髠탢飤쟦铨雪", a_);
		object[] array = new object[4];
		int num4 = 0;
		a a = this.a;
		array[num4] = ((a != null) ? a.ToString() : null);
		int num5 = 1;
		b b = this.b;
		array[num5] = ((b != null) ? b.ToString() : null);
		int num6 = 2;
		c c = this.c;
		array[num6] = ((c != null) ? c.ToString() : null);
		int num7 = 3;
		d d = this.d;
		array[num7] = ((d != null) ? d.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000003 RID: 3
	[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	private readonly a a;

	// Token: 0x04000004 RID: 4
	[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	private readonly b b;

	// Token: 0x04000005 RID: 5
	[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	private readonly c c;

	// Token: 0x04000006 RID: 6
	[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	private readonly d d;
}
