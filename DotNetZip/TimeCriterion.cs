using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x02000007 RID: 7
	internal class TimeCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000218C File Offset: 0x0000038C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(this.Which.ToString()).Append(" ").Append(global::Ionic.EnumUtil.GetDescription(this.Operator)).Append(" ").Append(this.Time.ToString("yyyy-MM-dd-HH:mm:ss"));
			return stringBuilder.ToString();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021FC File Offset: 0x000003FC
		internal override bool Evaluate(string filename)
		{
			global::System.DateTime x;
			switch (this.Which)
			{
			case global::Ionic.WhichTime.atime:
				x = global::System.IO.File.GetLastAccessTime(filename).ToUniversalTime();
				break;
			case global::Ionic.WhichTime.mtime:
				x = global::System.IO.File.GetLastWriteTime(filename).ToUniversalTime();
				break;
			case global::Ionic.WhichTime.ctime:
				x = global::System.IO.File.GetCreationTime(filename).ToUniversalTime();
				break;
			default:
				throw new global::System.ArgumentException("Operator");
			}
			return this._Evaluate(x);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000226C File Offset: 0x0000046C
		private bool _Evaluate(global::System.DateTime x)
		{
			bool result;
			switch (this.Operator)
			{
			case global::Ionic.ComparisonOperator.GreaterThan:
				result = (x > this.Time);
				break;
			case global::Ionic.ComparisonOperator.GreaterThanOrEqualTo:
				result = (x >= this.Time);
				break;
			case global::Ionic.ComparisonOperator.LesserThan:
				result = (x < this.Time);
				break;
			case global::Ionic.ComparisonOperator.LesserThanOrEqualTo:
				result = (x <= this.Time);
				break;
			case global::Ionic.ComparisonOperator.EqualTo:
				result = (x == this.Time);
				break;
			case global::Ionic.ComparisonOperator.NotEqualTo:
				result = (x != this.Time);
				break;
			default:
				throw new global::System.ArgumentException("Operator");
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002308 File Offset: 0x00000508
		internal override bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			global::System.DateTime x;
			switch (this.Which)
			{
			case global::Ionic.WhichTime.atime:
				x = entry.AccessedTime;
				break;
			case global::Ionic.WhichTime.mtime:
				x = entry.ModifiedTime;
				break;
			case global::Ionic.WhichTime.ctime:
				x = entry.CreationTime;
				break;
			default:
				throw new global::System.ArgumentException("??time");
			}
			return this._Evaluate(x);
		}

		// Token: 0x04000014 RID: 20
		internal global::Ionic.ComparisonOperator Operator;

		// Token: 0x04000015 RID: 21
		internal global::Ionic.WhichTime Which;

		// Token: 0x04000016 RID: 22
		internal global::System.DateTime Time;
	}
}
