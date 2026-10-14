using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006D0 RID: 1744
	public sealed class DbNewInstanceExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x06005154 RID: 20820 RVA: 0x00122D38 File Offset: 0x00120F38
		internal DbNewInstanceExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList args) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance, type, true)
		{
			this._elements = args;
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x00122D4B File Offset: 0x00120F4B
		internal DbNewInstanceExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList attributeValues, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> relationships) : this(resultType, attributeValues)
		{
			this._relatedEntityRefs = ((relationships.Count > 0) ? relationships : null);
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x00122D68 File Offset: 0x00120F68
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> Arguments
		{
			get
			{
				return this._elements;
			}
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x00122D70 File Offset: 0x00120F70
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x00122D85 File Offset: 0x00120F85
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06005159 RID: 20825 RVA: 0x00122D9A File Offset: 0x00120F9A
		internal bool HasRelatedEntityReferences
		{
			get
			{
				return this._relatedEntityRefs != null;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x0600515A RID: 20826 RVA: 0x00122DA5 File Offset: 0x00120FA5
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> RelatedEntityReferences
		{
			get
			{
				return this._relatedEntityRefs;
			}
		}

		// Token: 0x04001DBC RID: 7612
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList _elements;

		// Token: 0x04001DBD RID: 7613
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> _relatedEntityRefs;
	}
}
