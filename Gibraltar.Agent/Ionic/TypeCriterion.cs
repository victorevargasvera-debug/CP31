using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x0200041F RID: 1055
	internal class TypeCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002DBA RID: 11706 RVA: 0x000999AC File Offset: 0x00097BAC
		// (set) Token: 0x06002DBB RID: 11707 RVA: 0x000999BC File Offset: 0x00097BBC
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

		// Token: 0x06002DBC RID: 11708 RVA: 0x00099A10 File Offset: 0x00097C10
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("type ").Append(global::Ionic.EnumUtil.GetDescription(this.Operator)).Append(" ").Append(this.AttributeString);
			return stringBuilder.ToString();
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00099A64 File Offset: 0x00097C64
		internal override bool Evaluate(string filename)
		{
			bool flag = (this.ObjectType == 'D') ? global::System.IO.Directory.Exists(filename) : global::System.IO.File.Exists(filename);
			if (this.Operator != global::Ionic.ComparisonOperator.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x00099AA8 File Offset: 0x00097CA8
		internal override bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			bool flag = (this.ObjectType == 'D') ? entry.IsDirectory : (!entry.IsDirectory);
			if (this.Operator != global::Ionic.ComparisonOperator.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x04000F86 RID: 3974
		private char ObjectType;

		// Token: 0x04000F87 RID: 3975
		internal global::Ionic.ComparisonOperator Operator;
	}
}
