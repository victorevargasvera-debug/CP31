using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005E3 RID: 1507
	public class Asn1OutputStream : global::Org.BouncyCastle.Asn1.DerOutputStream
	{
		// Token: 0x0600387B RID: 14459 RVA: 0x00109C6E File Offset: 0x00107E6E
		public static global::Org.BouncyCastle.Asn1.Asn1OutputStream Create(global::System.IO.Stream output)
		{
			return new global::Org.BouncyCastle.Asn1.Asn1OutputStream(output);
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x00109C76 File Offset: 0x00107E76
		public static global::Org.BouncyCastle.Asn1.Asn1OutputStream Create(global::System.IO.Stream output, string encoding)
		{
			if ("DER".Equals(encoding))
			{
				return new global::Org.BouncyCastle.Asn1.DerOutputStreamNew(output);
			}
			return new global::Org.BouncyCastle.Asn1.Asn1OutputStream(output);
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00109C92 File Offset: 0x00107E92
		[global::System.Obsolete("Use static Create method(s)")]
		public Asn1OutputStream(global::System.IO.Stream os) : base(os)
		{
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x00109C9B File Offset: 0x00107E9B
		public override void WriteObject(global::Org.BouncyCastle.Asn1.Asn1Encodable encodable)
		{
			if (encodable == null)
			{
				throw new global::System.IO.IOException("null object detected");
			}
			this.WritePrimitive(encodable.ToAsn1Object(), true);
			this.FlushInternal();
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00109CBE File Offset: 0x00107EBE
		public override void WriteObject(global::Org.BouncyCastle.Asn1.Asn1Object primitive)
		{
			if (primitive == null)
			{
				throw new global::System.IO.IOException("null object detected");
			}
			this.WritePrimitive(primitive, true);
			this.FlushInternal();
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x00109CDC File Offset: 0x00107EDC
		internal void FlushInternal()
		{
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x00109CDE File Offset: 0x00107EDE
		internal virtual bool IsBer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x00109CE4 File Offset: 0x00107EE4
		internal void WriteDL(int length)
		{
			if (length < 128)
			{
				this.WriteByte((byte)length);
				return;
			}
			byte[] stack = new byte[5];
			int pos = stack.Length;
			do
			{
				stack[--pos] = (byte)length;
				length >>= 8;
			}
			while (length > 0);
			int count = stack.Length - pos;
			stack[--pos] = (byte)(128 | count);
			this.Write(stack, pos, count + 1);
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x00109D40 File Offset: 0x00107F40
		internal virtual void WriteElements(global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements)
		{
			int i = 0;
			int count = elements.Length;
			while (i < count)
			{
				elements[i].ToAsn1Object().Encode(this, true);
				i++;
			}
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00109D6C File Offset: 0x00107F6C
		internal void WriteEncodingDL(bool withID, int identifier, byte contents)
		{
			this.WriteIdentifier(withID, identifier);
			this.WriteDL(1);
			this.WriteByte(contents);
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00109D84 File Offset: 0x00107F84
		internal void WriteEncodingDL(bool withID, int identifier, byte[] contents)
		{
			this.WriteIdentifier(withID, identifier);
			this.WriteDL(contents.Length);
			this.Write(contents, 0, contents.Length);
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x00109DA2 File Offset: 0x00107FA2
		internal void WriteEncodingDL(bool withID, int identifier, byte[] contents, int contentsOff, int contentsLen)
		{
			this.WriteIdentifier(withID, identifier);
			this.WriteDL(contentsLen);
			this.Write(contents, contentsOff, contentsLen);
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x00109DBF File Offset: 0x00107FBF
		internal void WriteEncodingDL(bool withID, int identifier, byte contentsPrefix, byte[] contents, int contentsOff, int contentsLen)
		{
			this.WriteIdentifier(withID, identifier);
			this.WriteDL(1 + contentsLen);
			this.WriteByte(contentsPrefix);
			this.Write(contents, contentsOff, contentsLen);
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x00109DE6 File Offset: 0x00107FE6
		internal void WriteEncodingDL(bool withID, int identifier, byte[] contents, int contentsOff, int contentsLen, byte contentsSuffix)
		{
			this.WriteIdentifier(withID, identifier);
			this.WriteDL(contentsLen + 1);
			this.Write(contents, contentsOff, contentsLen);
			this.WriteByte(contentsSuffix);
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x00109E0D File Offset: 0x0010800D
		internal void WriteEncodingDL(bool withID, int flags, int tag, byte[] contents)
		{
			this.WriteIdentifier(withID, flags, tag);
			this.WriteDL(contents.Length);
			this.Write(contents, 0, contents.Length);
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x00109E2F File Offset: 0x0010802F
		internal void WriteEncodingIL(bool withID, int identifier, global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements)
		{
			this.WriteIdentifier(withID, identifier);
			this.WriteByte(128);
			this.WriteElements(elements);
			this.WriteByte(0);
			this.WriteByte(0);
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x00109E59 File Offset: 0x00108059
		internal void WriteIdentifier(bool withID, int identifier)
		{
			if (withID)
			{
				this.WriteByte((byte)identifier);
			}
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x00109E68 File Offset: 0x00108068
		internal void WriteIdentifier(bool withID, int flags, int tag)
		{
			if (withID)
			{
				if (tag < 31)
				{
					this.WriteByte((byte)(flags | tag));
					return;
				}
				byte[] stack = new byte[6];
				int pos = stack.Length;
				stack[--pos] = (byte)(tag & 127);
				while (tag > 127)
				{
					tag >>= 7;
					stack[--pos] = (byte)((tag & 127) | 128);
				}
				stack[--pos] = (byte)(flags | 31);
				this.Write(stack, pos, stack.Length - pos);
			}
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x00109ED6 File Offset: 0x001080D6
		internal virtual void WritePrimitive(global::Org.BouncyCastle.Asn1.Asn1Object primitive, bool withID)
		{
			primitive.Encode(this, withID);
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x00109EE0 File Offset: 0x001080E0
		internal virtual void WritePrimitives(global::Org.BouncyCastle.Asn1.Asn1Object[] primitives)
		{
			int i = 0;
			int count = primitives.Length;
			while (i < count)
			{
				this.WritePrimitive(primitives[i], true);
				i++;
			}
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x00109F08 File Offset: 0x00108108
		internal static int GetLengthOfDL(int dl)
		{
			if (dl < 128)
			{
				return 1;
			}
			int length = 2;
			while ((dl >>= 8) > 0)
			{
				length++;
			}
			return length;
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x00109F31 File Offset: 0x00108131
		internal static int GetLengthOfEncodingDL(bool withID, int contentsLength)
		{
			return (withID ? 1 : 0) + global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfDL(contentsLength) + contentsLength;
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x00109F43 File Offset: 0x00108143
		internal static int GetLengthOfEncodingDL(bool withID, int tag, int contentsLength)
		{
			return (withID ? global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfIdentifier(tag) : 0) + global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfDL(contentsLength) + contentsLength;
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x00109F5C File Offset: 0x0010815C
		internal static int GetLengthOfIdentifier(int tag)
		{
			if (tag < 31)
			{
				return 1;
			}
			int length = 2;
			while ((tag >>= 7) > 0)
			{
				length++;
			}
			return length;
		}
	}
}
