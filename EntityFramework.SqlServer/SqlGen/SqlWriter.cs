using System;
using System.Data.Entity.Migrations.Utilities;
using System.IO;
using System.Text;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x0200003B RID: 59
	internal class SqlWriter : global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter
	{
		// Token: 0x060005AF RID: 1455 RVA: 0x00019DFE File Offset: 0x00017FFE
		public SqlWriter(global::System.Text.StringBuilder b) : base(new global::System.IO.StringWriter(b, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter.Culture))
		{
		}
	}
}
