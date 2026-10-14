using System;
using System.Collections;
using Org.BouncyCastle.Bcpg.Attr;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005C5 RID: 1477
	public class PgpUserAttributeSubpacketVectorGenerator
	{
		// Token: 0x060037B3 RID: 14259 RVA: 0x00107556 File Offset: 0x00105756
		public virtual void SetImageAttribute(global::Org.BouncyCastle.Bcpg.Attr.ImageAttrib.Format imageType, byte[] imageData)
		{
			if (imageData == null)
			{
				throw new global::System.ArgumentException("attempt to set null image", "imageData");
			}
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Attr.ImageAttrib(imageType, imageData));
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x00107580 File Offset: 0x00105780
		public virtual global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector Generate()
		{
			global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[] a = new global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[this.list.Count];
			for (int i = 0; i < this.list.Count; i++)
			{
				a[i] = (global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket)this.list[i];
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector(a);
		}

		// Token: 0x04001910 RID: 6416
		private global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
	}
}
