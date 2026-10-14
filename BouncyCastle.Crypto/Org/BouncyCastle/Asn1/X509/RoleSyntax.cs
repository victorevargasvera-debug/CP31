using System;
using System.Text;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000668 RID: 1640
	public class RoleSyntax : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C81 RID: 15489 RVA: 0x00114DE5 File Offset: 0x00112FE5
		public static global::Org.BouncyCastle.Asn1.X509.RoleSyntax GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.RoleSyntax)
			{
				return (global::Org.BouncyCastle.Asn1.X509.RoleSyntax)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.X509.RoleSyntax(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00114E08 File Offset: 0x00113008
		public RoleSyntax(global::Org.BouncyCastle.Asn1.X509.GeneralNames roleAuthority, global::Org.BouncyCastle.Asn1.X509.GeneralName roleName)
		{
			if (roleName == null || roleName.TagNo != 6 || ((global::Org.BouncyCastle.Asn1.IAsn1String)roleName.Name).GetString().Equals(""))
			{
				throw new global::System.ArgumentException("the role name MUST be non empty and MUST use the URI option of GeneralName");
			}
			this.roleAuthority = roleAuthority;
			this.roleName = roleName;
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00114E5C File Offset: 0x0011305C
		public RoleSyntax(global::Org.BouncyCastle.Asn1.X509.GeneralName roleName) : this(null, roleName)
		{
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x00114E66 File Offset: 0x00113066
		public RoleSyntax(string roleName) : this(new global::Org.BouncyCastle.Asn1.X509.GeneralName(6, (roleName == null) ? "" : roleName))
		{
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x00114E80 File Offset: 0x00113080
		private RoleSyntax(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			for (int i = 0; i != seq.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject taggedObject = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[i]);
				int tagNo = taggedObject.TagNo;
				if (tagNo != 0)
				{
					if (tagNo != 1)
					{
						throw new global::System.ArgumentException("Unknown tag in RoleSyntax");
					}
					this.roleName = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(taggedObject, true);
				}
				else
				{
					this.roleAuthority = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(taggedObject, false);
				}
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06003C86 RID: 15494 RVA: 0x00114F1A File Offset: 0x0011311A
		public global::Org.BouncyCastle.Asn1.X509.GeneralNames RoleAuthority
		{
			get
			{
				return this.roleAuthority;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06003C87 RID: 15495 RVA: 0x00114F22 File Offset: 0x00113122
		public global::Org.BouncyCastle.Asn1.X509.GeneralName RoleName
		{
			get
			{
				return this.roleName;
			}
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x00114F2A File Offset: 0x0011312A
		public string GetRoleNameAsString()
		{
			return ((global::Org.BouncyCastle.Asn1.IAsn1String)this.roleName.Name).GetString();
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x00114F44 File Offset: 0x00113144
		public string[] GetRoleAuthorityAsString()
		{
			if (this.roleAuthority == null)
			{
				return new string[0];
			}
			global::Org.BouncyCastle.Asn1.X509.GeneralName[] names = this.roleAuthority.GetNames();
			string[] namesString = new string[names.Length];
			for (int i = 0; i < names.Length; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Value = names[i].Name;
				if (asn1Value is global::Org.BouncyCastle.Asn1.IAsn1String)
				{
					namesString[i] = ((global::Org.BouncyCastle.Asn1.IAsn1String)asn1Value).GetString();
				}
				else
				{
					namesString[i] = asn1Value.ToString();
				}
			}
			return namesString;
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x00114FAE File Offset: 0x001131AE
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(false, 0, this.roleAuthority);
			asn1EncodableVector.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, this.roleName));
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x00114FDC File Offset: 0x001131DC
		public override string ToString()
		{
			global::System.Text.StringBuilder buff = new global::System.Text.StringBuilder("Name: " + this.GetRoleNameAsString() + " - Auth: ");
			if (this.roleAuthority == null || this.roleAuthority.GetNames().Length == 0)
			{
				buff.Append("N/A");
			}
			else
			{
				string[] names = this.GetRoleAuthorityAsString();
				buff.Append('[').Append(names[0]);
				for (int i = 1; i < names.Length; i++)
				{
					buff.Append(", ").Append(names[i]);
				}
				buff.Append(']');
			}
			return buff.ToString();
		}

		// Token: 0x04001ABD RID: 6845
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralNames roleAuthority;

		// Token: 0x04001ABE RID: 6846
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName roleName;
	}
}
