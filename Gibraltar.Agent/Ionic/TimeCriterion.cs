using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x0200041D RID: 1053
	internal class TimeCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x06002DAF RID: 11695 RVA: 0x000995F4 File Offset: 0x000977F4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(this.Which.ToString()).Append(" ").Append(global::Ionic.EnumUtil.GetDescription(this.Operator)).Append(" ").Append(this.Time.ToString("yyyy-MM-dd-HH:mm:ss"));
			return stringBuilder.ToString();
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00099668 File Offset: 0x00097868
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

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000996E8 File Offset: 0x000978E8
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

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000997A0 File Offset: 0x000979A0
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

		// Token: 0x04000F7F RID: 3967
		internal global::Ionic.ComparisonOperator Operator;

		// Token: 0x04000F80 RID: 3968
		internal global::Ionic.WhichTime Which;

		// Token: 0x04000F81 RID: 3969
		internal global::System.DateTime Time;
	}
}
