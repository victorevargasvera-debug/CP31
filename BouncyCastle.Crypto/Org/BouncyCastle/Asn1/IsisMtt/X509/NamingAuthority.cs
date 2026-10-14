using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509
{
	// Token: 0x020006EB RID: 1771
	public class NamingAuthority : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600403C RID: 16444 RVA: 0x001235EC File Offset: 0x001217EC
		public static global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00123639 File Offset: 0x00121839
		public static global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x00123648 File Offset: 0x00121848
		private NamingAuthority(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			if (e.MoveNext())
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable o = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
				if (o is global::Org.BouncyCastle.Asn1.DerObjectIdentifier)
				{
					this.namingAuthorityID = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)o;
				}
				else if (o is global::Org.BouncyCastle.Asn1.DerIA5String)
				{
					this.namingAuthorityUrl = global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(o).GetString();
				}
				else
				{
					if (!(o is global::Org.BouncyCastle.Asn1.IAsn1String))
					{
						throw new global::System.ArgumentException("Bad object encountered: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o));
					}
					this.namingAuthorityText = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(o);
				}
			}
			if (e.MoveNext())
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable o2 = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
				if (o2 is global::Org.BouncyCastle.Asn1.DerIA5String)
				{
					this.namingAuthorityUrl = global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(o2).GetString();
				}
				else
				{
					if (!(o2 is global::Org.BouncyCastle.Asn1.IAsn1String))
					{
						throw new global::System.ArgumentException("Bad object encountered: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o2));
					}
					this.namingAuthorityText = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(o2);
				}
			}
			if (!e.MoveNext())
			{
				return;
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable o3 = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
			if (o3 is global::Org.BouncyCastle.Asn1.IAsn1String)
			{
				this.namingAuthorityText = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(o3);
				return;
			}
			throw new global::System.ArgumentException("Bad object encountered: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o3));
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600403F RID: 16447 RVA: 0x00123798 File Offset: 0x00121998
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier NamingAuthorityID
		{
			get
			{
				return this.namingAuthorityID;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06004040 RID: 16448 RVA: 0x001237A0 File Offset: 0x001219A0
		public virtual global::Org.BouncyCastle.Asn1.X500.DirectoryString NamingAuthorityText
		{
			get
			{
				return this.namingAuthorityText;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06004041 RID: 16449 RVA: 0x001237A8 File Offset: 0x001219A8
		public virtual string NamingAuthorityUrl
		{
			get
			{
				return this.namingAuthorityUrl;
			}
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x001237B0 File Offset: 0x001219B0
		public NamingAuthority(global::Org.BouncyCastle.Asn1.DerObjectIdentifier namingAuthorityID, string namingAuthorityUrl, global::Org.BouncyCastle.Asn1.X500.DirectoryString namingAuthorityText)
		{
			this.namingAuthorityID = namingAuthorityID;
			this.namingAuthorityUrl = namingAuthorityUrl;
			this.namingAuthorityText = namingAuthorityText;
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x001237D0 File Offset: 0x001219D0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.namingAuthorityID
			});
			if (this.namingAuthorityUrl != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerIA5String(this.namingAuthorityUrl, true));
			}
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.namingAuthorityText
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x0012382D File Offset: 0x00121A2D
		// Note: this type is marked as 'beforefieldinit'.
		static NamingAuthority()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthorities = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATNamingAuthorities;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthorities != null) ? idIsisMttATNamingAuthorities.ToString() : null) + ".1");
		}

		// Token: 0x04001E63 RID: 7779
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;

		// Token: 0x04001E64 RID: 7780
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier namingAuthorityID;

		// Token: 0x04001E65 RID: 7781
		private readonly string namingAuthorityUrl;

		// Token: 0x04001E66 RID: 7782
		private readonly global::Org.BouncyCastle.Asn1.X500.DirectoryString namingAuthorityText;
	}
}
