using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.X509.Store
{
	// Token: 0x0200002E RID: 46
	public sealed class X509StoreFactory
	{
		// Token: 0x06000215 RID: 533 RVA: 0x0000AFDF File Offset: 0x000091DF
		private X509StoreFactory()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000AFE8 File Offset: 0x000091E8
		public static global::Org.BouncyCastle.X509.Store.IX509Store Create(string type, global::Org.BouncyCastle.X509.Store.IX509StoreParameters parameters)
		{
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			string[] array = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(type).Split(new char[]
			{
				'/'
			});
			if (array.Length < 2)
			{
				throw new global::System.ArgumentException("type");
			}
			if (array[1] != "COLLECTION")
			{
				throw new global::Org.BouncyCastle.X509.Store.NoSuchStoreException("X.509 store type '" + type + "' not available.");
			}
			global::System.Collections.ICollection coll = ((global::Org.BouncyCastle.X509.Store.X509CollectionStoreParameters)parameters).GetCollection();
			string a = array[0];
			if (!(a == "ATTRIBUTECERTIFICATE"))
			{
				if (!(a == "CERTIFICATE"))
				{
					if (!(a == "CERTIFICATEPAIR"))
					{
						if (!(a == "CRL"))
						{
							throw new global::Org.BouncyCastle.X509.Store.NoSuchStoreException("X.509 store type '" + type + "' not available.");
						}
						global::Org.BouncyCastle.X509.Store.X509StoreFactory.checkCorrectType(coll, typeof(global::Org.BouncyCastle.X509.X509Crl));
					}
					else
					{
						global::Org.BouncyCastle.X509.Store.X509StoreFactory.checkCorrectType(coll, typeof(global::Org.BouncyCastle.X509.X509CertificatePair));
					}
				}
				else
				{
					global::Org.BouncyCastle.X509.Store.X509StoreFactory.checkCorrectType(coll, typeof(global::Org.BouncyCastle.X509.X509Certificate));
				}
			}
			else
			{
				global::Org.BouncyCastle.X509.Store.X509StoreFactory.checkCorrectType(coll, typeof(global::Org.BouncyCastle.X509.IX509AttributeCertificate));
			}
			return new global::Org.BouncyCastle.X509.Store.X509CollectionStore(coll);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000B0F8 File Offset: 0x000092F8
		private static void checkCorrectType(global::System.Collections.ICollection coll, global::System.Type t)
		{
			foreach (object o in coll)
			{
				if (!t.IsInstanceOfType(o))
				{
					throw new global::System.InvalidCastException("Can't cast object to type: " + t.FullName);
				}
			}
		}
	}
}
