using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000298 RID: 664
	public abstract class MutableInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext
	{
		// Token: 0x06002112 RID: 8466 RVA: 0x0005C35C File Offset: 0x0005A55C
		protected MutableInterceptionContext()
		{
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x0005C36F File Offset: 0x0005A56F
		protected MutableInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x0005C38F File Offset: 0x0005A58F
		global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext.MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x0005C397 File Offset: 0x0005A597
		internal global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x0005C39F File Offset: 0x0005A59F
		public bool IsExecutionSuppressed
		{
			get
			{
				return this._mutableData.IsExecutionSuppressed;
			}
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x0005C3AC File Offset: 0x0005A5AC
		public void SuppressExecution()
		{
			this._mutableData.SuppressExecution();
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x0005C3B9 File Offset: 0x0005A5B9
		public global::System.Exception OriginalException
		{
			get
			{
				return this._mutableData.OriginalException;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x0005C3C6 File Offset: 0x0005A5C6
		// (set) Token: 0x0600211A RID: 8474 RVA: 0x0005C3D3 File Offset: 0x0005A5D3
		public global::System.Exception Exception
		{
			get
			{
				return this._mutableData.Exception;
			}
			set
			{
				this._mutableData.Exception = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x0005C3E1 File Offset: 0x0005A5E1
		public global::System.Threading.Tasks.TaskStatus TaskStatus
		{
			get
			{
				return this._mutableData.TaskStatus;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x0005C3EE File Offset: 0x0005A5EE
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x0005C3FB File Offset: 0x0005A5FB
		[global::System.Obsolete("Not safe when multiple interceptors are in use. Use SetUserState and FindUserState instead.")]
		public object UserState
		{
			get
			{
				return this._mutableData.UserState;
			}
			set
			{
				this._mutableData.UserState = value;
			}
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0005C409 File Offset: 0x0005A609
		public object FindUserState(string key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(key, "key");
			return this._mutableData.FindUserState(key);
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0005C423 File Offset: 0x0005A623
		public void SetUserState(string key, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(key, "key");
			this._mutableData.SetUserState(key, value);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x0005C43E File Offset: 0x0005A63E
		public new global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext)base.AsAsync();
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x0005C44B File Offset: 0x0005A64B
		public new global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext)base.WithDbContext(context);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0005C465 File Offset: 0x0005A665
		public new global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext)base.WithObjectContext(context);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x0005C47F File Offset: 0x0005A67F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x0005C487 File Offset: 0x0005A687
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x0005C490 File Offset: 0x0005A690
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x0005C498 File Offset: 0x0005A698
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B95 RID: 2965
		private readonly global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData _mutableData = new global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData();
	}
}
