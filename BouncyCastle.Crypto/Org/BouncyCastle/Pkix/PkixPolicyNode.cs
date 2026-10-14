using System;
using System.Collections;
using System.Text;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x020001A4 RID: 420
	public class PkixPolicyNode
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0003C918 File Offset: 0x0003AB18
		public virtual int Depth
		{
			get
			{
				return this.mDepth;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x0003C920 File Offset: 0x0003AB20
		public virtual global::System.Collections.IEnumerable Children
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.mChildren);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0003C92D File Offset: 0x0003AB2D
		// (set) Token: 0x06000FCC RID: 4044 RVA: 0x0003C935 File Offset: 0x0003AB35
		public virtual bool IsCritical
		{
			get
			{
				return this.mCritical;
			}
			set
			{
				this.mCritical = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0003C93E File Offset: 0x0003AB3E
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet PolicyQualifiers
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.HashSet(this.mPolicyQualifiers);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0003C94B File Offset: 0x0003AB4B
		public virtual string ValidPolicy
		{
			get
			{
				return this.mValidPolicy;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0003C953 File Offset: 0x0003AB53
		public virtual bool HasChildren
		{
			get
			{
				return this.mChildren.Count != 0;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0003C963 File Offset: 0x0003AB63
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x0003C970 File Offset: 0x0003AB70
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet ExpectedPolicies
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.HashSet(this.mExpectedPolicies);
			}
			set
			{
				this.mExpectedPolicies = new global::Org.BouncyCastle.Utilities.Collections.HashSet(value);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0003C97E File Offset: 0x0003AB7E
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x0003C986 File Offset: 0x0003AB86
		public virtual global::Org.BouncyCastle.Pkix.PkixPolicyNode Parent
		{
			get
			{
				return this.mParent;
			}
			set
			{
				this.mParent = value;
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0003C990 File Offset: 0x0003AB90
		public PkixPolicyNode(global::System.Collections.IList children, int depth, global::Org.BouncyCastle.Utilities.Collections.ISet expectedPolicies, global::Org.BouncyCastle.Pkix.PkixPolicyNode parent, global::Org.BouncyCastle.Utilities.Collections.ISet policyQualifiers, string validPolicy, bool critical)
		{
			if (children == null)
			{
				this.mChildren = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			}
			else
			{
				this.mChildren = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(children);
			}
			this.mDepth = depth;
			this.mExpectedPolicies = expectedPolicies;
			this.mParent = parent;
			this.mPolicyQualifiers = policyQualifiers;
			this.mValidPolicy = validPolicy;
			this.mCritical = critical;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0003C9ED File Offset: 0x0003ABED
		public virtual void AddChild(global::Org.BouncyCastle.Pkix.PkixPolicyNode child)
		{
			child.Parent = this;
			this.mChildren.Add(child);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0003CA03 File Offset: 0x0003AC03
		public virtual void RemoveChild(global::Org.BouncyCastle.Pkix.PkixPolicyNode child)
		{
			this.mChildren.Remove(child);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0003CA11 File Offset: 0x0003AC11
		public override string ToString()
		{
			return this.ToString("");
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0003CA20 File Offset: 0x0003AC20
		public virtual string ToString(string indent)
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			buf.Append(indent);
			buf.Append(this.mValidPolicy);
			buf.Append(" {");
			buf.Append(global::Org.BouncyCastle.Utilities.Platform.NewLine);
			foreach (object obj in this.mChildren)
			{
				global::Org.BouncyCastle.Pkix.PkixPolicyNode child = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj;
				buf.Append(child.ToString(indent + "    "));
			}
			buf.Append(indent);
			buf.Append("}");
			buf.Append(global::Org.BouncyCastle.Utilities.Platform.NewLine);
			return buf.ToString();
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0003CAE4 File Offset: 0x0003ACE4
		public virtual object Clone()
		{
			return this.Copy();
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0003CAEC File Offset: 0x0003ACEC
		public virtual global::Org.BouncyCastle.Pkix.PkixPolicyNode Copy()
		{
			global::Org.BouncyCastle.Pkix.PkixPolicyNode node = new global::Org.BouncyCastle.Pkix.PkixPolicyNode(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(), this.mDepth, new global::Org.BouncyCastle.Utilities.Collections.HashSet(this.mExpectedPolicies), null, new global::Org.BouncyCastle.Utilities.Collections.HashSet(this.mPolicyQualifiers), this.mValidPolicy, this.mCritical);
			foreach (object obj in this.mChildren)
			{
				global::Org.BouncyCastle.Pkix.PkixPolicyNode copy = ((global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj).Copy();
				copy.Parent = node;
				node.AddChild(copy);
			}
			return node;
		}

		// Token: 0x04000886 RID: 2182
		protected global::System.Collections.IList mChildren;

		// Token: 0x04000887 RID: 2183
		protected int mDepth;

		// Token: 0x04000888 RID: 2184
		protected global::Org.BouncyCastle.Utilities.Collections.ISet mExpectedPolicies;

		// Token: 0x04000889 RID: 2185
		protected global::Org.BouncyCastle.Pkix.PkixPolicyNode mParent;

		// Token: 0x0400088A RID: 2186
		protected global::Org.BouncyCastle.Utilities.Collections.ISet mPolicyQualifiers;

		// Token: 0x0400088B RID: 2187
		protected string mValidPolicy;

		// Token: 0x0400088C RID: 2188
		protected bool mCritical;
	}
}
