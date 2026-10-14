using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000620 RID: 1568
	internal struct Triple<T1, T2, T3> : global::System.IEquatable<global::System.Data.Entity.Core.Common.Utils.Boolean.Triple<T1, T2, T3>> where T1 : global::System.IEquatable<T1> where T2 : global::System.IEquatable<T2> where T3 : global::System.IEquatable<T3>
	{
		// Token: 0x06004BF7 RID: 19447 RVA: 0x0010AF0F File Offset: 0x0010910F
		internal Triple(T1 value1, T2 value2, T3 value3)
		{
			this._value1 = value1;
			this._value2 = value2;
			this._value3 = value3;
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x0010AF28 File Offset: 0x00109128
		public bool Equals(global::System.Data.Entity.Core.Common.Utils.Boolean.Triple<T1, T2, T3> other)
		{
			T1 value = this._value1;
			if (value.Equals(other._value1))
			{
				T2 value2 = this._value2;
				if (value2.Equals(other._value2))
				{
					T3 value3 = this._value3;
					return value3.Equals(other._value3);
				}
			}
			return false;
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x0010AF89 File Offset: 0x00109189
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x0010AF9C File Offset: 0x0010919C
		public override int GetHashCode()
		{
			T1 value = this._value1;
			int hashCode = value.GetHashCode();
			T2 value2 = this._value2;
			int num = hashCode ^ value2.GetHashCode();
			T3 value3 = this._value3;
			return num ^ value3.GetHashCode();
		}

		// Token: 0x04001A87 RID: 6791
		private readonly T1 _value1;

		// Token: 0x04001A88 RID: 6792
		private readonly T2 _value2;

		// Token: 0x04001A89 RID: 6793
		private readonly T3 _value3;
	}
}
