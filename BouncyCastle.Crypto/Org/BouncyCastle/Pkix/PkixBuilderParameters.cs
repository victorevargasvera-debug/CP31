using System;
using System.Text;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x02000196 RID: 406
	public class PkixBuilderParameters : global::Org.BouncyCastle.Pkix.PkixParameters
	{
		// Token: 0x06000EFB RID: 3835 RVA: 0x000374D4 File Offset: 0x000356D4
		public static global::Org.BouncyCastle.Pkix.PkixBuilderParameters GetInstance(global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			global::Org.BouncyCastle.Pkix.PkixBuilderParameters pkixBuilderParameters = new global::Org.BouncyCastle.Pkix.PkixBuilderParameters(pkixParams.GetTrustAnchors(), new global::Org.BouncyCastle.X509.Store.X509CertStoreSelector(pkixParams.GetTargetCertConstraints()));
			pkixBuilderParameters.SetParams(pkixParams);
			return pkixBuilderParameters;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000374F3 File Offset: 0x000356F3
		public PkixBuilderParameters(global::Org.BouncyCastle.Utilities.Collections.ISet trustAnchors, global::Org.BouncyCastle.X509.Store.IX509Selector targetConstraints) : base(trustAnchors)
		{
			this.SetTargetCertConstraints(targetConstraints);
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00037515 File Offset: 0x00035715
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x0003751D File Offset: 0x0003571D
		public virtual int MaxPathLength
		{
			get
			{
				return this.maxPathLength;
			}
			set
			{
				if (value < -1)
				{
					throw new global::Org.BouncyCastle.Security.InvalidParameterException("The maximum path length parameter can not be less than -1.");
				}
				this.maxPathLength = value;
			}
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00037535 File Offset: 0x00035735
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetExcludedCerts()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.HashSet(this.excludedCerts);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00037542 File Offset: 0x00035742
		public virtual void SetExcludedCerts(global::Org.BouncyCastle.Utilities.Collections.ISet excludedCerts)
		{
			if (excludedCerts == null)
			{
				this.excludedCerts = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				return;
			}
			this.excludedCerts = new global::Org.BouncyCastle.Utilities.Collections.HashSet(excludedCerts);
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00037560 File Offset: 0x00035760
		protected override void SetParams(global::Org.BouncyCastle.Pkix.PkixParameters parameters)
		{
			base.SetParams(parameters);
			if (parameters is global::Org.BouncyCastle.Pkix.PkixBuilderParameters)
			{
				global::Org.BouncyCastle.Pkix.PkixBuilderParameters _params = (global::Org.BouncyCastle.Pkix.PkixBuilderParameters)parameters;
				this.maxPathLength = _params.maxPathLength;
				this.excludedCerts = new global::Org.BouncyCastle.Utilities.Collections.HashSet(_params.excludedCerts);
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x000375A0 File Offset: 0x000357A0
		public override object Clone()
		{
			global::Org.BouncyCastle.Pkix.PkixBuilderParameters pkixBuilderParameters = new global::Org.BouncyCastle.Pkix.PkixBuilderParameters(this.GetTrustAnchors(), this.GetTargetCertConstraints());
			pkixBuilderParameters.SetParams(this);
			return pkixBuilderParameters;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000375BC File Offset: 0x000357BC
		public override string ToString()
		{
			string nl = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("PkixBuilderParameters [" + nl);
			stringBuilder.Append(base.ToString());
			stringBuilder.Append("  Maximum Path Length: ");
			stringBuilder.Append(this.MaxPathLength);
			stringBuilder.Append(nl + "]" + nl);
			return stringBuilder.ToString();
		}

		// Token: 0x04000851 RID: 2129
		private int maxPathLength = 5;

		// Token: 0x04000852 RID: 2130
		private global::Org.BouncyCastle.Utilities.Collections.ISet excludedCerts = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
	}
}
