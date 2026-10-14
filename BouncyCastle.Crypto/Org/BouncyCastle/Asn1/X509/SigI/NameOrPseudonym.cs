using System;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.SigI
{
	// Token: 0x02000684 RID: 1668
	public class NameOrPseudonym : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003D93 RID: 15763 RVA: 0x0011924C File Offset: 0x0011744C
		public static global::Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym)
			{
				return (global::Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.IAsn1String)
			{
				return new global::Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym(global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(obj));
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x001192AD File Offset: 0x001174AD
		public NameOrPseudonym(global::Org.BouncyCastle.Asn1.X500.DirectoryString pseudonym)
		{
			this.pseudonym = pseudonym;
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x001192BC File Offset: 0x001174BC
		private NameOrPseudonym(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			if (!(seq[0] is global::Org.BouncyCastle.Asn1.IAsn1String))
			{
				throw new global::System.ArgumentException("Bad object encountered: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(seq[0]));
			}
			this.surname = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(seq[0]);
			this.givenName = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[1]);
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x00119344 File Offset: 0x00117544
		public NameOrPseudonym(string pseudonym) : this(new global::Org.BouncyCastle.Asn1.X500.DirectoryString(pseudonym))
		{
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00119352 File Offset: 0x00117552
		public NameOrPseudonym(global::Org.BouncyCastle.Asn1.X500.DirectoryString surname, global::Org.BouncyCastle.Asn1.Asn1Sequence givenName)
		{
			this.surname = surname;
			this.givenName = givenName;
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06003D98 RID: 15768 RVA: 0x00119368 File Offset: 0x00117568
		public global::Org.BouncyCastle.Asn1.X500.DirectoryString Pseudonym
		{
			get
			{
				return this.pseudonym;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06003D99 RID: 15769 RVA: 0x00119370 File Offset: 0x00117570
		public global::Org.BouncyCastle.Asn1.X500.DirectoryString Surname
		{
			get
			{
				return this.surname;
			}
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00119378 File Offset: 0x00117578
		public global::Org.BouncyCastle.Asn1.X500.DirectoryString[] GetGivenName()
		{
			global::Org.BouncyCastle.Asn1.X500.DirectoryString[] items = new global::Org.BouncyCastle.Asn1.X500.DirectoryString[this.givenName.Count];
			int count = 0;
			foreach (object o in this.givenName)
			{
				items[count++] = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(o);
			}
			return items;
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x001193EC File Offset: 0x001175EC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.pseudonym != null)
			{
				return this.pseudonym.ToAsn1Object();
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.surname,
				this.givenName
			});
		}

		// Token: 0x04001B7D RID: 7037
		private readonly global::Org.BouncyCastle.Asn1.X500.DirectoryString pseudonym;

		// Token: 0x04001B7E RID: 7038
		private readonly global::Org.BouncyCastle.Asn1.X500.DirectoryString surname;

		// Token: 0x04001B7F RID: 7039
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence givenName;
	}
}
