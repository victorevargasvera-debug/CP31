using System;
using System.Collections;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x020001A0 RID: 416
	public class PkixCrlUtilities
	{
		// Token: 0x06000F4F RID: 3919 RVA: 0x000399B4 File Offset: 0x00037BB4
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet FindCrls(global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector crlselect, global::Org.BouncyCastle.Pkix.PkixParameters paramsPkix, global::System.DateTime currentDate)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet initialSet = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			try
			{
				initialSet.AddAll(this.FindCrls(crlselect, paramsPkix.GetAdditionalStores()));
				initialSet.AddAll(this.FindCrls(crlselect, paramsPkix.GetStores()));
			}
			catch (global::System.Exception e)
			{
				throw new global::System.Exception("Exception obtaining complete CRLs.", e);
			}
			global::Org.BouncyCastle.Utilities.Collections.ISet finalSet = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			global::System.DateTime validityDate = currentDate;
			if (paramsPkix.Date != null)
			{
				validityDate = paramsPkix.Date.Value;
			}
			foreach (object obj in initialSet)
			{
				global::Org.BouncyCastle.X509.X509Crl crl = (global::Org.BouncyCastle.X509.X509Crl)obj;
				global::Org.BouncyCastle.Utilities.Date.DateTimeObject nextUpdate = crl.NextUpdate;
				if (nextUpdate == null || nextUpdate.Value.CompareTo(validityDate) > 0)
				{
					global::Org.BouncyCastle.X509.X509Certificate cert = crlselect.CertificateChecking;
					if (cert == null || crl.ThisUpdate.CompareTo(cert.NotAfter) < 0)
					{
						finalSet.Add(crl);
					}
				}
			}
			return finalSet;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00039ABC File Offset: 0x00037CBC
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet FindCrls(global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector crlselect, global::Org.BouncyCastle.Pkix.PkixParameters paramsPkix)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet completeSet = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			try
			{
				completeSet.AddAll(this.FindCrls(crlselect, paramsPkix.GetStores()));
			}
			catch (global::System.Exception e)
			{
				throw new global::System.Exception("Exception obtaining complete CRLs.", e);
			}
			return completeSet;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00039B04 File Offset: 0x00037D04
		private global::System.Collections.ICollection FindCrls(global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector crlSelect, global::System.Collections.IList crlStores)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet crls = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			global::System.Exception lastException = null;
			bool foundValidStore = false;
			foreach (object obj in crlStores)
			{
				global::Org.BouncyCastle.X509.Store.IX509Store store = (global::Org.BouncyCastle.X509.Store.IX509Store)obj;
				try
				{
					crls.AddAll(store.GetMatches(crlSelect));
					foundValidStore = true;
				}
				catch (global::Org.BouncyCastle.X509.Store.X509StoreException e)
				{
					lastException = new global::System.Exception("Exception searching in X.509 CRL store.", e);
				}
			}
			if (!foundValidStore && lastException != null)
			{
				throw lastException;
			}
			return crls;
		}
	}
}
