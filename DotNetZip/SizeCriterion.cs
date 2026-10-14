using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x02000006 RID: 6
	internal class SizeCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000206C File Offset: 0x0000026C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("size ").Append(global::Ionic.EnumUtil.GetDescription(this.Operator)).Append(" ").Append(this.Size.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020C0 File Offset: 0x000002C0
		internal override bool Evaluate(string filename)
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(filename);
			return this._Evaluate(fileInfo.Length);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020E0 File Offset: 0x000002E0
		private bool _Evaluate(long Length)
		{
			bool result;
			switch (this.Operator)
			{
			case global::Ionic.ComparisonOperator.GreaterThan:
				result = (Length > this.Size);
				break;
			case global::Ionic.ComparisonOperator.GreaterThanOrEqualTo:
				result = (Length >= this.Size);
				break;
			case global::Ionic.ComparisonOperator.LesserThan:
				result = (Length < this.Size);
				break;
			case global::Ionic.ComparisonOperator.LesserThanOrEqualTo:
				result = (Length <= this.Size);
				break;
			case global::Ionic.ComparisonOperator.EqualTo:
				result = (Length == this.Size);
				break;
			case global::Ionic.ComparisonOperator.NotEqualTo:
				result = (Length != this.Size);
				break;
			default:
				throw new global::System.ArgumentException("Operator");
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002173 File Offset: 0x00000373
		internal override bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			return this._Evaluate(entry.UncompressedSize);
		}

		// Token: 0x04000012 RID: 18
		internal global::Ionic.ComparisonOperator Operator;

		// Token: 0x04000013 RID: 19
		internal long Size;
	}
}
