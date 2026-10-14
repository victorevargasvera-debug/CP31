using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Globalization;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003DD RID: 989
	internal class ScalarColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap
	{
		// Token: 0x06002EE4 RID: 12004 RVA: 0x0009438A File Offset: 0x0009258A
		internal ScalarColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, int commandId, int columnPos) : base(type, name)
		{
			this.m_commandId = commandId;
			this.m_columnPos = columnPos;
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x000943A3 File Offset: 0x000925A3
		internal int CommandId
		{
			get
			{
				return this.m_commandId;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x000943AB File Offset: 0x000925AB
		internal int ColumnPos
		{
			get
			{
				return this.m_columnPos;
			}
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x000943B3 File Offset: 0x000925B3
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg)
		{
			visitor.Visit(this, arg);
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x000943BD File Offset: 0x000925BD
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg)
		{
			return visitor.Visit(this, arg);
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x000943C7 File Offset: 0x000925C7
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "S({0},{1})", new object[]
			{
				this.CommandId,
				this.ColumnPos
			});
		}

		// Token: 0x04000FD2 RID: 4050
		private readonly int m_commandId;

		// Token: 0x04000FD3 RID: 4051
		private readonly int m_columnPos;
	}
}
