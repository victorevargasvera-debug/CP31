using System;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x0200000B RID: 11
	internal class CompoundCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000029CB File Offset: 0x00000BCB
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000029D3 File Offset: 0x00000BD3
		internal global::Ionic.SelectionCriterion Right
		{
			get
			{
				return this._Right;
			}
			set
			{
				this._Right = value;
				if (value == null)
				{
					this.Conjunction = global::Ionic.LogicalConjunction.NONE;
					return;
				}
				if (this.Conjunction == global::Ionic.LogicalConjunction.NONE)
				{
					this.Conjunction = global::Ionic.LogicalConjunction.AND;
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000029F8 File Offset: 0x00000BF8
		internal override bool Evaluate(string filename)
		{
			bool flag = this.Left.Evaluate(filename);
			switch (this.Conjunction)
			{
			case global::Ionic.LogicalConjunction.AND:
				if (flag)
				{
					flag = this.Right.Evaluate(filename);
				}
				break;
			case global::Ionic.LogicalConjunction.OR:
				if (!flag)
				{
					flag = this.Right.Evaluate(filename);
				}
				break;
			case global::Ionic.LogicalConjunction.XOR:
				flag ^= this.Right.Evaluate(filename);
				break;
			default:
				throw new global::System.ArgumentException("Conjunction");
			}
			return flag;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002A70 File Offset: 0x00000C70
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("(").Append((this.Left != null) ? this.Left.ToString() : "null").Append(" ").Append(this.Conjunction.ToString()).Append(" ").Append((this.Right != null) ? this.Right.ToString() : "null").Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002B08 File Offset: 0x00000D08
		internal override bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			bool flag = this.Left.Evaluate(entry);
			switch (this.Conjunction)
			{
			case global::Ionic.LogicalConjunction.AND:
				if (flag)
				{
					flag = this.Right.Evaluate(entry);
				}
				break;
			case global::Ionic.LogicalConjunction.OR:
				if (!flag)
				{
					flag = this.Right.Evaluate(entry);
				}
				break;
			case global::Ionic.LogicalConjunction.XOR:
				flag ^= this.Right.Evaluate(entry);
				break;
			}
			return flag;
		}

		// Token: 0x0400001F RID: 31
		internal global::Ionic.LogicalConjunction Conjunction;

		// Token: 0x04000020 RID: 32
		internal global::Ionic.SelectionCriterion Left;

		// Token: 0x04000021 RID: 33
		private global::Ionic.SelectionCriterion _Right;
	}
}
