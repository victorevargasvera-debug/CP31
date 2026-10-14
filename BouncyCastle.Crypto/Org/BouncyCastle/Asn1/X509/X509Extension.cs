using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200067D RID: 1661
	public class X509Extension
	{
		// Token: 0x06003D42 RID: 15682 RVA: 0x00116D54 File Offset: 0x00114F54
		public X509Extension(global::Org.BouncyCastle.Asn1.DerBoolean critical, global::Org.BouncyCastle.Asn1.Asn1OctetString value)
		{
			if (critical == null)
			{
				throw new global::System.ArgumentNullException("critical");
			}
			this.critical = critical.IsTrue;
			this.value = value;
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x00116D7D File Offset: 0x00114F7D
		public X509Extension(bool critical, global::Org.BouncyCastle.Asn1.Asn1OctetString value)
		{
			this.critical = critical;
			this.value = value;
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06003D44 RID: 15684 RVA: 0x00116D93 File Offset: 0x00114F93
		public bool IsCritical
		{
			get
			{
				return this.critical;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06003D45 RID: 15685 RVA: 0x00116D9B File Offset: 0x00114F9B
		public global::Org.BouncyCastle.Asn1.Asn1OctetString Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x00116DA3 File Offset: 0x00114FA3
		public global::Org.BouncyCastle.Asn1.Asn1Encodable GetParsedValue()
		{
			return global::Org.BouncyCastle.Asn1.X509.X509Extension.ConvertValueToObject(this);
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x00116DAC File Offset: 0x00114FAC
		public override int GetHashCode()
		{
			int vh = this.Value.GetHashCode();
			if (!this.IsCritical)
			{
				return ~vh;
			}
			return vh;
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x00116DD4 File Offset: 0x00114FD4
		public override bool Equals(object obj)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Extension other = obj as global::Org.BouncyCastle.Asn1.X509.X509Extension;
			return other != null && this.Value.Equals(other.Value) && this.IsCritical == other.IsCritical;
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x00116E10 File Offset: 0x00115010
		public static global::Org.BouncyCastle.Asn1.Asn1Object ConvertValueToObject(global::Org.BouncyCastle.Asn1.X509.X509Extension ext)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object result;
			try
			{
				result = global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(ext.Value.GetOctets());
			}
			catch (global::System.Exception e)
			{
				throw new global::System.ArgumentException("can't convert extension", e);
			}
			return result;
		}

		// Token: 0x04001B10 RID: 6928
		internal bool critical;

		// Token: 0x04001B11 RID: 6929
		internal global::Org.BouncyCastle.Asn1.Asn1OctetString value;
	}
}
