using System;
using System.Collections.Generic;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000035 RID: 53
	internal class SqlBuilder : global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x000124A4 File Offset: 0x000106A4
		private global::System.Collections.Generic.List<object> sqlFragments
		{
			get
			{
				if (this._sqlFragments == null)
				{
					this._sqlFragments = new global::System.Collections.Generic.List<object>();
				}
				return this._sqlFragments;
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000124BF File Offset: 0x000106BF
		public void Append(object s)
		{
			this.sqlFragments.Add(s);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000124CD File Offset: 0x000106CD
		public void AppendLine()
		{
			this.sqlFragments.Add("\r\n");
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x000124DF File Offset: 0x000106DF
		public virtual bool IsEmpty
		{
			get
			{
				return this._sqlFragments == null || this._sqlFragments.Count == 0;
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000124FC File Offset: 0x000106FC
		public virtual void WriteSql(global::System.Data.Entity.SqlServer.SqlGen.SqlWriter writer, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator)
		{
			if (this._sqlFragments != null)
			{
				foreach (object obj in this._sqlFragments)
				{
					string text = obj as string;
					if (text != null)
					{
						writer.Write(text);
					}
					else
					{
						global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment sqlFragment = obj as global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment;
						if (sqlFragment == null)
						{
							throw new global::System.InvalidOperationException();
						}
						sqlFragment.WriteSql(writer, sqlGenerator);
					}
				}
			}
		}

		// Token: 0x040000E5 RID: 229
		private global::System.Collections.Generic.List<object> _sqlFragments;
	}
}
