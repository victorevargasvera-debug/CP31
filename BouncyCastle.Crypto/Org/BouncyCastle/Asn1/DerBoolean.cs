using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000603 RID: 1539
	public class DerBoolean : global::Org.BouncyCastle.Asn1.Asn1Object
	{
		// Token: 0x06003968 RID: 14696 RVA: 0x0010C576 File Offset: 0x0010A776
		public static global::Org.BouncyCastle.Asn1.DerBoolean GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerBoolean)
			{
				return (global::Org.BouncyCastle.Asn1.DerBoolean)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x0010C59F File Offset: 0x0010A79F
		public static global::Org.BouncyCastle.Asn1.DerBoolean GetInstance(bool value)
		{
			if (!value)
			{
				return global::Org.BouncyCastle.Asn1.DerBoolean.False;
			}
			return global::Org.BouncyCastle.Asn1.DerBoolean.True;
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x0010C5B0 File Offset: 0x0010A7B0
		public static global::Org.BouncyCastle.Asn1.DerBoolean GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerBoolean)
			{
				return global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(o);
			}
			return global::Org.BouncyCastle.Asn1.DerBoolean.FromOctetString(((global::Org.BouncyCastle.Asn1.Asn1OctetString)o).GetOctets());
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x0010C5E6 File Offset: 0x0010A7E6
		public DerBoolean(byte[] val)
		{
			if (val.Length != 1)
			{
				throw new global::System.ArgumentException("byte value should have 1 byte in it", "val");
			}
			this.value = val[0];
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x0010C60D File Offset: 0x0010A80D
		private DerBoolean(bool value)
		{
			this.value = (value ? byte.MaxValue : 0);
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x0600396D RID: 14701 RVA: 0x0010C626 File Offset: 0x0010A826
		public bool IsTrue
		{
			get
			{
				return this.value > 0;
			}
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x0010C631 File Offset: 0x0010A831
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, 1);
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x0010C63A File Offset: 0x0010A83A
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 1, this.value);
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x0010C64C File Offset: 0x0010A84C
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerBoolean other = asn1Object as global::Org.BouncyCastle.Asn1.DerBoolean;
			return other != null && this.IsTrue == other.IsTrue;
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x0010C674 File Offset: 0x0010A874
		protected override int Asn1GetHashCode()
		{
			return this.IsTrue.GetHashCode();
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x0010C68F File Offset: 0x0010A88F
		public override string ToString()
		{
			if (!this.IsTrue)
			{
				return "FALSE";
			}
			return "TRUE";
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x0010C6A4 File Offset: 0x0010A8A4
		internal static global::Org.BouncyCastle.Asn1.DerBoolean FromOctetString(byte[] value)
		{
			if (value.Length != 1)
			{
				throw new global::System.ArgumentException("BOOLEAN value should have 1 byte in it", "value");
			}
			byte b = value[0];
			if (b == 0)
			{
				return global::Org.BouncyCastle.Asn1.DerBoolean.False;
			}
			if (b != 255)
			{
				return new global::Org.BouncyCastle.Asn1.DerBoolean(value);
			}
			return global::Org.BouncyCastle.Asn1.DerBoolean.True;
		}

		// Token: 0x04001985 RID: 6533
		private readonly byte value;

		// Token: 0x04001986 RID: 6534
		public static readonly global::Org.BouncyCastle.Asn1.DerBoolean False = new global::Org.BouncyCastle.Asn1.DerBoolean(false);

		// Token: 0x04001987 RID: 6535
		public static readonly global::Org.BouncyCastle.Asn1.DerBoolean True = new global::Org.BouncyCastle.Asn1.DerBoolean(true);
	}
}
