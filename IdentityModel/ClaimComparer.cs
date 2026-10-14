using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityModel
{
	// Token: 0x02000005 RID: 5
	public class ClaimComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Security.Claims.Claim>
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002184 File Offset: 0x00000384
		public ClaimComparer()
		{
			this._valueAndTypeOnly = false;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002194 File Offset: 0x00000394
		public ClaimComparer(bool compareValueAndTypeOnly)
		{
			this._valueAndTypeOnly = compareValueAndTypeOnly;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021A4 File Offset: 0x000003A4
		public bool Equals(global::System.Security.Claims.Claim x, global::System.Security.Claims.Claim y)
		{
			if (x == null && y == null)
			{
				return true;
			}
			if (x == null && y != null)
			{
				return false;
			}
			if (x != null && y == null)
			{
				return false;
			}
			if (this._valueAndTypeOnly)
			{
				return x.Type == y.Type && x.Value == y.Value;
			}
			return x.Type == y.Type && x.Value == y.Value && x.Issuer == y.Issuer && x.ValueType == y.ValueType;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002244 File Offset: 0x00000444
		public int GetHashCode(global::System.Security.Claims.Claim claim)
		{
			if (claim == null)
			{
				return 0;
			}
			string type = claim.Type;
			int num = (type != null) ? type.GetHashCode() : 0;
			string value = claim.Value;
			int num2 = (value != null) ? value.GetHashCode() : 0;
			return num ^ num2;
		}

		// Token: 0x04000001 RID: 1
		private readonly bool _valueAndTypeOnly;
	}
}
