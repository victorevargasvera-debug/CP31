using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x020001A3 RID: 419
	public class PkixParameters
	{
		// Token: 0x06000F9C RID: 3996 RVA: 0x0003C114 File Offset: 0x0003A314
		public PkixParameters(global::Org.BouncyCastle.Utilities.Collections.ISet trustAnchors)
		{
			this.SetTrustAnchors(trustAnchors);
			this.initialPolicies = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			this.certPathCheckers = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			this.stores = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			this.additionalStores = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			this.trustedACIssuers = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			this.necessaryACAttributes = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			this.prohibitedACAttributes = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			this.attrCertCheckers = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x0003C194 File Offset: 0x0003A394
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x0003C19C File Offset: 0x0003A39C
		public virtual bool IsRevocationEnabled
		{
			get
			{
				return this.revocationEnabled;
			}
			set
			{
				this.revocationEnabled = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x0003C1A5 File Offset: 0x0003A3A5
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x0003C1AD File Offset: 0x0003A3AD
		public virtual bool IsExplicitPolicyRequired
		{
			get
			{
				return this.explicitPolicyRequired;
			}
			set
			{
				this.explicitPolicyRequired = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x0003C1B6 File Offset: 0x0003A3B6
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x0003C1BE File Offset: 0x0003A3BE
		public virtual bool IsAnyPolicyInhibited
		{
			get
			{
				return this.anyPolicyInhibited;
			}
			set
			{
				this.anyPolicyInhibited = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x0003C1C7 File Offset: 0x0003A3C7
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x0003C1CF File Offset: 0x0003A3CF
		public virtual bool IsPolicyMappingInhibited
		{
			get
			{
				return this.policyMappingInhibited;
			}
			set
			{
				this.policyMappingInhibited = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x0003C1D8 File Offset: 0x0003A3D8
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x0003C1E0 File Offset: 0x0003A3E0
		public virtual bool IsPolicyQualifiersRejected
		{
			get
			{
				return this.policyQualifiersRejected;
			}
			set
			{
				this.policyQualifiersRejected = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x0003C1E9 File Offset: 0x0003A3E9
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x0003C1F1 File Offset: 0x0003A3F1
		public virtual global::Org.BouncyCastle.Utilities.Date.DateTimeObject Date
		{
			get
			{
				return this.date;
			}
			set
			{
				this.date = value;
			}
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0003C1FA File Offset: 0x0003A3FA
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetTrustAnchors()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.HashSet(this.trustAnchors);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x0003C208 File Offset: 0x0003A408
		public virtual void SetTrustAnchors(global::Org.BouncyCastle.Utilities.Collections.ISet tas)
		{
			if (tas == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			if (tas.IsEmpty)
			{
				throw new global::System.ArgumentException("non-empty set required", "value");
			}
			this.trustAnchors = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj in tas)
			{
				global::Org.BouncyCastle.Pkix.TrustAnchor ta = (global::Org.BouncyCastle.Pkix.TrustAnchor)obj;
				if (ta != null)
				{
					this.trustAnchors.Add(ta);
				}
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x0003C298 File Offset: 0x0003A498
		public virtual global::Org.BouncyCastle.X509.Store.X509CertStoreSelector GetTargetCertConstraints()
		{
			if (this.certSelector == null)
			{
				return null;
			}
			return (global::Org.BouncyCastle.X509.Store.X509CertStoreSelector)this.certSelector.Clone();
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0003C2B4 File Offset: 0x0003A4B4
		public virtual void SetTargetCertConstraints(global::Org.BouncyCastle.X509.Store.IX509Selector selector)
		{
			if (selector == null)
			{
				this.certSelector = null;
				return;
			}
			this.certSelector = (global::Org.BouncyCastle.X509.Store.IX509Selector)selector.Clone();
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0003C2D4 File Offset: 0x0003A4D4
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetInitialPolicies()
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet returnSet = this.initialPolicies;
			if (this.initialPolicies == null)
			{
				returnSet = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			}
			return new global::Org.BouncyCastle.Utilities.Collections.HashSet(returnSet);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0003C2FC File Offset: 0x0003A4FC
		public virtual void SetInitialPolicies(global::Org.BouncyCastle.Utilities.Collections.ISet initialPolicies)
		{
			this.initialPolicies = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			if (initialPolicies != null)
			{
				foreach (object obj2 in initialPolicies)
				{
					string obj = (string)obj2;
					if (obj != null)
					{
						this.initialPolicies.Add(obj);
					}
				}
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0003C368 File Offset: 0x0003A568
		public virtual void SetCertPathCheckers(global::System.Collections.IList checkers)
		{
			this.certPathCheckers = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (checkers != null)
			{
				foreach (object obj2 in checkers)
				{
					global::Org.BouncyCastle.Pkix.PkixCertPathChecker obj = (global::Org.BouncyCastle.Pkix.PkixCertPathChecker)obj2;
					this.certPathCheckers.Add(obj.Clone());
				}
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0003C3D8 File Offset: 0x0003A5D8
		public virtual global::System.Collections.IList GetCertPathCheckers()
		{
			global::System.Collections.IList checkers = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj2 in this.certPathCheckers)
			{
				global::Org.BouncyCastle.Pkix.PkixCertPathChecker obj = (global::Org.BouncyCastle.Pkix.PkixCertPathChecker)obj2;
				checkers.Add(obj.Clone());
			}
			return checkers;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0003C440 File Offset: 0x0003A640
		public virtual void AddCertPathChecker(global::Org.BouncyCastle.Pkix.PkixCertPathChecker checker)
		{
			if (checker != null)
			{
				this.certPathCheckers.Add(checker.Clone());
			}
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0003C457 File Offset: 0x0003A657
		public virtual object Clone()
		{
			global::Org.BouncyCastle.Pkix.PkixParameters pkixParameters = new global::Org.BouncyCastle.Pkix.PkixParameters(this.GetTrustAnchors());
			pkixParameters.SetParams(this);
			return pkixParameters;
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0003C46C File Offset: 0x0003A66C
		protected virtual void SetParams(global::Org.BouncyCastle.Pkix.PkixParameters parameters)
		{
			this.Date = parameters.Date;
			this.SetCertPathCheckers(parameters.GetCertPathCheckers());
			this.IsAnyPolicyInhibited = parameters.IsAnyPolicyInhibited;
			this.IsExplicitPolicyRequired = parameters.IsExplicitPolicyRequired;
			this.IsPolicyMappingInhibited = parameters.IsPolicyMappingInhibited;
			this.IsRevocationEnabled = parameters.IsRevocationEnabled;
			this.SetInitialPolicies(parameters.GetInitialPolicies());
			this.IsPolicyQualifiersRejected = parameters.IsPolicyQualifiersRejected;
			this.SetTargetCertConstraints(parameters.GetTargetCertConstraints());
			this.SetTrustAnchors(parameters.GetTrustAnchors());
			this.validityModel = parameters.validityModel;
			this.useDeltas = parameters.useDeltas;
			this.additionalLocationsEnabled = parameters.additionalLocationsEnabled;
			this.selector = ((parameters.selector == null) ? null : ((global::Org.BouncyCastle.X509.Store.IX509Selector)parameters.selector.Clone()));
			this.stores = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(parameters.stores);
			this.additionalStores = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(parameters.additionalStores);
			this.trustedACIssuers = new global::Org.BouncyCastle.Utilities.Collections.HashSet(parameters.trustedACIssuers);
			this.prohibitedACAttributes = new global::Org.BouncyCastle.Utilities.Collections.HashSet(parameters.prohibitedACAttributes);
			this.necessaryACAttributes = new global::Org.BouncyCastle.Utilities.Collections.HashSet(parameters.necessaryACAttributes);
			this.attrCertCheckers = new global::Org.BouncyCastle.Utilities.Collections.HashSet(parameters.attrCertCheckers);
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0003C59C File Offset: 0x0003A79C
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x0003C5A4 File Offset: 0x0003A7A4
		public virtual bool IsUseDeltasEnabled
		{
			get
			{
				return this.useDeltas;
			}
			set
			{
				this.useDeltas = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0003C5AD File Offset: 0x0003A7AD
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x0003C5B5 File Offset: 0x0003A7B5
		public virtual int ValidityModel
		{
			get
			{
				return this.validityModel;
			}
			set
			{
				this.validityModel = value;
			}
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0003C5C0 File Offset: 0x0003A7C0
		public virtual void SetStores(global::System.Collections.IList stores)
		{
			if (stores == null)
			{
				this.stores = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				return;
			}
			using (global::System.Collections.IEnumerator enumerator = stores.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!(enumerator.Current is global::Org.BouncyCastle.X509.Store.IX509Store))
					{
						throw new global::System.InvalidCastException("All elements of list must be of type " + typeof(global::Org.BouncyCastle.X509.Store.IX509Store).FullName);
					}
				}
			}
			this.stores = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(stores);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0003C648 File Offset: 0x0003A848
		public virtual void AddStore(global::Org.BouncyCastle.X509.Store.IX509Store store)
		{
			if (store != null)
			{
				this.stores.Add(store);
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0003C65A File Offset: 0x0003A85A
		public virtual void AddAdditionalStore(global::Org.BouncyCastle.X509.Store.IX509Store store)
		{
			if (store != null)
			{
				this.additionalStores.Add(store);
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0003C66C File Offset: 0x0003A86C
		public virtual global::System.Collections.IList GetAdditionalStores()
		{
			return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.additionalStores);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0003C679 File Offset: 0x0003A879
		public virtual global::System.Collections.IList GetStores()
		{
			return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.stores);
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x0003C686 File Offset: 0x0003A886
		public virtual bool IsAdditionalLocationsEnabled
		{
			get
			{
				return this.additionalLocationsEnabled;
			}
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0003C68E File Offset: 0x0003A88E
		public virtual void SetAdditionalLocationsEnabled(bool enabled)
		{
			this.additionalLocationsEnabled = enabled;
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0003C697 File Offset: 0x0003A897
		public virtual global::Org.BouncyCastle.X509.Store.IX509Selector GetTargetConstraints()
		{
			if (this.selector != null)
			{
				return (global::Org.BouncyCastle.X509.Store.IX509Selector)this.selector.Clone();
			}
			return null;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0003C6B3 File Offset: 0x0003A8B3
		public virtual void SetTargetConstraints(global::Org.BouncyCastle.X509.Store.IX509Selector selector)
		{
			if (selector != null)
			{
				this.selector = (global::Org.BouncyCastle.X509.Store.IX509Selector)selector.Clone();
				return;
			}
			this.selector = null;
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0003C6D1 File Offset: 0x0003A8D1
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetTrustedACIssuers()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.HashSet(this.trustedACIssuers);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0003C6E0 File Offset: 0x0003A8E0
		public virtual void SetTrustedACIssuers(global::Org.BouncyCastle.Utilities.Collections.ISet trustedACIssuers)
		{
			if (trustedACIssuers == null)
			{
				this.trustedACIssuers = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				return;
			}
			using (global::System.Collections.IEnumerator enumerator = trustedACIssuers.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!(enumerator.Current is global::Org.BouncyCastle.Pkix.TrustAnchor))
					{
						throw new global::System.InvalidCastException("All elements of set must be of type " + typeof(global::Org.BouncyCastle.Pkix.TrustAnchor).FullName + ".");
					}
				}
			}
			this.trustedACIssuers = new global::Org.BouncyCastle.Utilities.Collections.HashSet(trustedACIssuers);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0003C770 File Offset: 0x0003A970
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetNecessaryACAttributes()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.HashSet(this.necessaryACAttributes);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0003C780 File Offset: 0x0003A980
		public virtual void SetNecessaryACAttributes(global::Org.BouncyCastle.Utilities.Collections.ISet necessaryACAttributes)
		{
			if (necessaryACAttributes == null)
			{
				this.necessaryACAttributes = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				return;
			}
			using (global::System.Collections.IEnumerator enumerator = necessaryACAttributes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!(enumerator.Current is string))
					{
						throw new global::System.InvalidCastException("All elements of set must be of type string.");
					}
				}
			}
			this.necessaryACAttributes = new global::Org.BouncyCastle.Utilities.Collections.HashSet(necessaryACAttributes);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0003C7F4 File Offset: 0x0003A9F4
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetProhibitedACAttributes()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.HashSet(this.prohibitedACAttributes);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0003C804 File Offset: 0x0003AA04
		public virtual void SetProhibitedACAttributes(global::Org.BouncyCastle.Utilities.Collections.ISet prohibitedACAttributes)
		{
			if (prohibitedACAttributes == null)
			{
				this.prohibitedACAttributes = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				return;
			}
			using (global::System.Collections.IEnumerator enumerator = prohibitedACAttributes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!(enumerator.Current is string))
					{
						throw new global::System.InvalidCastException("All elements of set must be of type string.");
					}
				}
			}
			this.prohibitedACAttributes = new global::Org.BouncyCastle.Utilities.Collections.HashSet(prohibitedACAttributes);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0003C878 File Offset: 0x0003AA78
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetAttrCertCheckers()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.HashSet(this.attrCertCheckers);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0003C888 File Offset: 0x0003AA88
		public virtual void SetAttrCertCheckers(global::Org.BouncyCastle.Utilities.Collections.ISet attrCertCheckers)
		{
			if (attrCertCheckers == null)
			{
				this.attrCertCheckers = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				return;
			}
			using (global::System.Collections.IEnumerator enumerator = attrCertCheckers.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!(enumerator.Current is global::Org.BouncyCastle.Pkix.PkixAttrCertChecker))
					{
						throw new global::System.InvalidCastException("All elements of set must be of type " + typeof(global::Org.BouncyCastle.Pkix.PkixAttrCertChecker).FullName + ".");
					}
				}
			}
			this.attrCertCheckers = new global::Org.BouncyCastle.Utilities.Collections.HashSet(attrCertCheckers);
		}

		// Token: 0x04000870 RID: 2160
		public const int PkixValidityModel = 0;

		// Token: 0x04000871 RID: 2161
		public const int ChainValidityModel = 1;

		// Token: 0x04000872 RID: 2162
		private global::Org.BouncyCastle.Utilities.Collections.ISet trustAnchors;

		// Token: 0x04000873 RID: 2163
		private global::Org.BouncyCastle.Utilities.Date.DateTimeObject date;

		// Token: 0x04000874 RID: 2164
		private global::System.Collections.IList certPathCheckers;

		// Token: 0x04000875 RID: 2165
		private bool revocationEnabled = true;

		// Token: 0x04000876 RID: 2166
		private global::Org.BouncyCastle.Utilities.Collections.ISet initialPolicies;

		// Token: 0x04000877 RID: 2167
		private bool explicitPolicyRequired;

		// Token: 0x04000878 RID: 2168
		private bool anyPolicyInhibited;

		// Token: 0x04000879 RID: 2169
		private bool policyMappingInhibited;

		// Token: 0x0400087A RID: 2170
		private bool policyQualifiersRejected = true;

		// Token: 0x0400087B RID: 2171
		private global::Org.BouncyCastle.X509.Store.IX509Selector certSelector;

		// Token: 0x0400087C RID: 2172
		private global::System.Collections.IList stores;

		// Token: 0x0400087D RID: 2173
		private global::Org.BouncyCastle.X509.Store.IX509Selector selector;

		// Token: 0x0400087E RID: 2174
		private bool additionalLocationsEnabled;

		// Token: 0x0400087F RID: 2175
		private global::System.Collections.IList additionalStores;

		// Token: 0x04000880 RID: 2176
		private global::Org.BouncyCastle.Utilities.Collections.ISet trustedACIssuers;

		// Token: 0x04000881 RID: 2177
		private global::Org.BouncyCastle.Utilities.Collections.ISet necessaryACAttributes;

		// Token: 0x04000882 RID: 2178
		private global::Org.BouncyCastle.Utilities.Collections.ISet prohibitedACAttributes;

		// Token: 0x04000883 RID: 2179
		private global::Org.BouncyCastle.Utilities.Collections.ISet attrCertCheckers;

		// Token: 0x04000884 RID: 2180
		private int validityModel;

		// Token: 0x04000885 RID: 2181
		private bool useDeltas;
	}
}
