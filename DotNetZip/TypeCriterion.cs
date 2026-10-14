using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x02000009 RID: 9
	internal class TypeCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002510 File Offset: 0x00000710
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000251D File Offset: 0x0000071D
		internal string AttributeString
		{
			get
			{
				return this.ObjectType.ToString();
			}
			set
			{
				if (value.Length != 1 || (value[0] != 'D' && value[0] != 'F'))
				{
					throw new global::System.ArgumentException("Specify a single character: either D or F");
				}
				this.ObjectType = value[0];
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002558 File Offset: 0x00000758
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("type ").Append(global::Ionic.EnumUtil.GetDescription(this.Operator)).Append(" ").Append(this.AttributeString);
			return stringBuilder.ToString();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000025A8 File Offset: 0x000007A8
		internal override bool Evaluate(string filename)
		{
			bool flag = (this.ObjectType == 'D') ? global::System.IO.Directory.Exists(filename) : global::System.IO.File.Exists(filename);
			if (this.Operator != global::Ionic.ComparisonOperator.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000025E0 File Offset: 0x000007E0
		internal override bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			bool flag = (this.ObjectType == 'D') ? entry.IsDirectory : (!entry.IsDirectory);
			if (this.Operator != global::Ionic.ComparisonOperator.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x0400001B RID: 27
		private char ObjectType;

		// Token: 0x0400001C RID: 28
		internal global::Ionic.ComparisonOperator Operator;
	}
}
