using System;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
	// Token: 0x02000058 RID: 88
	public class PemHeader
	{
		// Token: 0x060003D4 RID: 980 RVA: 0x000140EE File Offset: 0x000122EE
		public PemHeader(string name, string val)
		{
			this.name = name;
			this.val = val;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00014104 File Offset: 0x00012304
		public virtual string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0001410C File Offset: 0x0001230C
		public virtual string Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00014114 File Offset: 0x00012314
		public override int GetHashCode()
		{
			return this.GetHashCode(this.name) + 31 * this.GetHashCode(this.val);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00014134 File Offset: 0x00012334
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			if (!(obj is global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader))
			{
				return false;
			}
			global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader other = (global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader)obj;
			return object.Equals(this.name, other.name) && object.Equals(this.val, other.val);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0001417E File Offset: 0x0001237E
		private int GetHashCode(string s)
		{
			if (s == null)
			{
				return 1;
			}
			return s.GetHashCode();
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0001418B File Offset: 0x0001238B
		public override string ToString()
		{
			return this.name + ":" + this.val;
		}

		// Token: 0x0400027F RID: 639
		private string name;

		// Token: 0x04000280 RID: 640
		private string val;
	}
}
