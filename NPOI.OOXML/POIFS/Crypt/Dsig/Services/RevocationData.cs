using System;
using System.Collections.Generic;

namespace NPOI.POIFS.Crypt.Dsig.Services
{
	// Token: 0x02000104 RID: 260
	public class RevocationData
	{
		// Token: 0x06000F63 RID: 3939 RVA: 0x0003637C File Offset: 0x0003457C
		public RevocationData()
		{
			this.crls = new global::System.Collections.Generic.List<byte[]>();
			this.ocsps = new global::System.Collections.Generic.List<byte[]>();
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0003639A File Offset: 0x0003459A
		public void AddCRL(byte[] encodedCrl)
		{
			this.crls.Add(encodedCrl);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x000363A8 File Offset: 0x000345A8
		public void AddCRL(global::NPOI.POIFS.Crypt.Dsig.Services.X509CRL crl)
		{
			byte[] encoded;
			try
			{
				encoded = crl.getEncoded();
			}
			catch (global::NPOI.POIFS.Crypt.Dsig.Services.CRLException ex)
			{
				throw new global::System.ArgumentException("CRL coding error: " + ex.Message, ex);
			}
			this.AddCRL(encoded);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x000363F0 File Offset: 0x000345F0
		public void AddOCSP(byte[] encodedOcsp)
		{
			this.ocsps.Add(encodedOcsp);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x000363FE File Offset: 0x000345FE
		public global::System.Collections.Generic.List<byte[]> GetCRLs()
		{
			return this.crls;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00036406 File Offset: 0x00034606
		public global::System.Collections.Generic.List<byte[]> GetOCSPs()
		{
			return this.ocsps;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0003640E File Offset: 0x0003460E
		public bool HasOCSPs()
		{
			return this.ocsps.Count > 0;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0003641E File Offset: 0x0003461E
		public bool HasCRLs()
		{
			return this.crls.Count > 0;
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0003642E File Offset: 0x0003462E
		public bool HasRevocationDataEntries()
		{
			return this.HasOCSPs() || this.HasCRLs();
		}

		// Token: 0x040004BD RID: 1213
		private global::System.Collections.Generic.List<byte[]> crls;

		// Token: 0x040004BE RID: 1214
		private global::System.Collections.Generic.List<byte[]> ocsps;
	}
}
