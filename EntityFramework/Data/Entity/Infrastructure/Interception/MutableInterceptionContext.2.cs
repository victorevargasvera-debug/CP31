using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000299 RID: 665
	public abstract class MutableInterceptionContext<TResult> : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext<TResult>, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext
	{
		// Token: 0x06002127 RID: 8487 RVA: 0x0005C4A0 File Offset: 0x0005A6A0
		protected MutableInterceptionContext()
		{
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0005C4B3 File Offset: 0x0005A6B3
		protected MutableInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x0005C4D3 File Offset: 0x0005A6D3
		global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<TResult> global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext<!0>.MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x0005C4DB File Offset: 0x0005A6DB
		global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext.MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x0005C4E3 File Offset: 0x0005A6E3
		public TResult OriginalResult
		{
			get
			{
				return this._mutableData.OriginalResult;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x0005C4F0 File Offset: 0x0005A6F0
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x0005C4FD File Offset: 0x0005A6FD
		public TResult Result
		{
			get
			{
				return this._mutableData.Result;
			}
			set
			{
				this._mutableData.Result = value;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x0005C50B File Offset: 0x0005A70B
		public bool IsExecutionSuppressed
		{
			get
			{
				return this._mutableData.IsExecutionSuppressed;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x0005C518 File Offset: 0x0005A718
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x0005C525 File Offset: 0x0005A725
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

		// Token: 0x06002131 RID: 8497 RVA: 0x0005C533 File Offset: 0x0005A733
		public object FindUserState(string key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(key, "key");
			return this._mutableData.FindUserState(key);
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0005C54D File Offset: 0x0005A74D
		public void SetUserState(string key, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(key, "key");
			this._mutableData.SetUserState(key, value);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x0005C568 File Offset: 0x0005A768
		public void SuppressExecution()
		{
			this._mutableData.SuppressExecution();
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0005C575 File Offset: 0x0005A775
		public global::System.Exception OriginalException
		{
			get
			{
				return this._mutableData.OriginalException;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x0005C582 File Offset: 0x0005A782
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x0005C58F File Offset: 0x0005A78F
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

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x0005C59D File Offset: 0x0005A79D
		public global::System.Threading.Tasks.TaskStatus TaskStatus
		{
			get
			{
				return this._mutableData.TaskStatus;
			}
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x0005C5AA File Offset: 0x0005A7AA
		public new global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext<TResult> AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext<TResult>)base.AsAsync();
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x0005C5B7 File Offset: 0x0005A7B7
		public new global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext<TResult> WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext<TResult>)base.WithDbContext(context);
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x0005C5D1 File Offset: 0x0005A7D1
		public new global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext<TResult> WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext<TResult>)base.WithObjectContext(context);
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x0005C5EB File Offset: 0x0005A7EB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x0005C5F3 File Offset: 0x0005A7F3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x0005C5FC File Offset: 0x0005A7FC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0005C604 File Offset: 0x0005A804
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B96 RID: 2966
		private readonly global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<TResult> _mutableData = new global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<TResult>();
	}
}
