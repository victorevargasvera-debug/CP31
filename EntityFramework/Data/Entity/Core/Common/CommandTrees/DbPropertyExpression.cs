using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006D7 RID: 1751
	public class DbPropertyExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x06005173 RID: 20851 RVA: 0x00122F3E File Offset: 0x0012113E
		internal DbPropertyExpression()
		{
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x00122F46 File Offset: 0x00121146
		internal DbPropertyExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Metadata.Edm.EdmMember property, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property, resultType, true)
		{
			this._property = property;
			this._instance = instance;
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06005175 RID: 20853 RVA: 0x00122F60 File Offset: 0x00121160
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EdmMember Property
		{
			get
			{
				return this._property;
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x00122F68 File Offset: 0x00121168
		public virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Instance
		{
			get
			{
				return this._instance;
			}
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x00122F70 File Offset: 0x00121170
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x00122F85 File Offset: 0x00121185
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x00122F9A File Offset: 0x0012119A
		public global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> ToKeyValuePair()
		{
			return new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this.Property.Name, this);
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x00122FAD File Offset: 0x001211AD
		public static implicit operator global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(value, "value");
			return value.ToKeyValuePair();
		}

		// Token: 0x04001DC2 RID: 7618
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember _property;

		// Token: 0x04001DC3 RID: 7619
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _instance;
	}
}
