using System;

namespace Org.BouncyCastle.X509.Store
{
	// Token: 0x02000028 RID: 40
	public class X509CertPairStoreSelector : global::Org.BouncyCastle.X509.Store.IX509Selector, global::System.ICloneable
	{
		// Token: 0x060001BF RID: 447 RVA: 0x0000A470 File Offset: 0x00008670
		private static global::Org.BouncyCastle.X509.Store.X509CertStoreSelector CloneSelector(global::Org.BouncyCastle.X509.Store.X509CertStoreSelector s)
		{
			if (s != null)
			{
				return (global::Org.BouncyCastle.X509.Store.X509CertStoreSelector)s.Clone();
			}
			return null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000A482 File Offset: 0x00008682
		public X509CertPairStoreSelector()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000A48A File Offset: 0x0000868A
		private X509CertPairStoreSelector(global::Org.BouncyCastle.X509.Store.X509CertPairStoreSelector o)
		{
			this.certPair = o.CertPair;
			this.forwardSelector = o.ForwardSelector;
			this.reverseSelector = o.ReverseSelector;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000A4B6 File Offset: 0x000086B6
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000A4BE File Offset: 0x000086BE
		public global::Org.BouncyCastle.X509.X509CertificatePair CertPair
		{
			get
			{
				return this.certPair;
			}
			set
			{
				this.certPair = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000A4C7 File Offset: 0x000086C7
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000A4D4 File Offset: 0x000086D4
		public global::Org.BouncyCastle.X509.Store.X509CertStoreSelector ForwardSelector
		{
			get
			{
				return global::Org.BouncyCastle.X509.Store.X509CertPairStoreSelector.CloneSelector(this.forwardSelector);
			}
			set
			{
				this.forwardSelector = global::Org.BouncyCastle.X509.Store.X509CertPairStoreSelector.CloneSelector(value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000A4E2 File Offset: 0x000086E2
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000A4EF File Offset: 0x000086EF
		public global::Org.BouncyCastle.X509.Store.X509CertStoreSelector ReverseSelector
		{
			get
			{
				return global::Org.BouncyCastle.X509.Store.X509CertPairStoreSelector.CloneSelector(this.reverseSelector);
			}
			set
			{
				this.reverseSelector = global::Org.BouncyCastle.X509.Store.X509CertPairStoreSelector.CloneSelector(value);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000A500 File Offset: 0x00008700
		public bool Match(object obj)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException("obj");
			}
			global::Org.BouncyCastle.X509.X509CertificatePair pair = obj as global::Org.BouncyCastle.X509.X509CertificatePair;
			return pair != null && (this.certPair == null || this.certPair.Equals(pair)) && (this.forwardSelector == null || this.forwardSelector.Match(pair.Forward)) && (this.reverseSelector == null || this.reverseSelector.Match(pair.Reverse));
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000A57A File Offset: 0x0000877A
		public object Clone()
		{
			return new global::Org.BouncyCastle.X509.Store.X509CertPairStoreSelector(this);
		}

		// Token: 0x040000CC RID: 204
		private global::Org.BouncyCastle.X509.X509CertificatePair certPair;

		// Token: 0x040000CD RID: 205
		private global::Org.BouncyCastle.X509.Store.X509CertStoreSelector forwardSelector;

		// Token: 0x040000CE RID: 206
		private global::Org.BouncyCastle.X509.Store.X509CertStoreSelector reverseSelector;
	}
}
