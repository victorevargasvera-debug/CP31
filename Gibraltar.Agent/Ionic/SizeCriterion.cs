using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x0200041C RID: 1052
	internal class SizeCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x06002DAA RID: 11690 RVA: 0x000994B4 File Offset: 0x000976B4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("size ").Append(global::Ionic.EnumUtil.GetDescription(this.Operator)).Append(" ").Append(this.Size.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x0009950C File Offset: 0x0009770C
		internal override bool Evaluate(string filename)
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(filename);
			return this._Evaluate(fileInfo.Length);
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00099530 File Offset: 0x00097730
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

		// Token: 0x06002DAD RID: 11693 RVA: 0x000995DC File Offset: 0x000977DC
		internal override bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			return this._Evaluate(entry.UncompressedSize);
		}

		// Token: 0x04000F7D RID: 3965
		internal global::Ionic.ComparisonOperator Operator;

		// Token: 0x04000F7E RID: 3966
		internal long Size;
	}
}
