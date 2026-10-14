using System;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x02000421 RID: 1057
	internal class CompoundCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x00099F18 File Offset: 0x00098118
		// (set) Token: 0x06002DC9 RID: 11721 RVA: 0x00099F20 File Offset: 0x00098120
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

		// Token: 0x06002DCA RID: 11722 RVA: 0x00099F4C File Offset: 0x0009814C
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

		// Token: 0x06002DCB RID: 11723 RVA: 0x00099FDC File Offset: 0x000981DC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("(").Append((this.Left != null) ? this.Left.ToString() : "null").Append(" ").Append(this.Conjunction.ToString()).Append(" ").Append((this.Right != null) ? this.Right.ToString() : "null").Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x0009A084 File Offset: 0x00098284
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

		// Token: 0x04000F8A RID: 3978
		internal global::Ionic.LogicalConjunction Conjunction;

		// Token: 0x04000F8B RID: 3979
		internal global::Ionic.SelectionCriterion Left;

		// Token: 0x04000F8C RID: 3980
		private global::Ionic.SelectionCriterion _Right;
	}
}
