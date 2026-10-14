using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200027A RID: 634
	public class DbCommandInterceptionContext<TResult> : global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext<!0>, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext
	{
		// Token: 0x06001FFB RID: 8187 RVA: 0x0005A320 File Offset: 0x00058520
		public DbCommandInterceptionContext()
		{
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0005A333 File Offset: 0x00058533
		public DbCommandInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0005A347 File Offset: 0x00058547
		global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext.MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x0005A34F File Offset: 0x0005854F
		global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<TResult> global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext<!0>.MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x0005A357 File Offset: 0x00058557
		internal global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<TResult> MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x0005A35F File Offset: 0x0005855F
		public TResult OriginalResult
		{
			get
			{
				return this._mutableData.OriginalResult;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x0005A36C File Offset: 0x0005856C
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x0005A379 File Offset: 0x00058579
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

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x0005A387 File Offset: 0x00058587
		public bool IsExecutionSuppressed
		{
			get
			{
				return this._mutableData.IsExecutionSuppressed;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x0005A394 File Offset: 0x00058594
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x0005A3A1 File Offset: 0x000585A1
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

		// Token: 0x06002006 RID: 8198 RVA: 0x0005A3AF File Offset: 0x000585AF
		public object FindUserState(string key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(key, "key");
			return this._mutableData.FindUserState(key);
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0005A3C9 File Offset: 0x000585C9
		public void SetUserState(string key, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(key, "key");
			this._mutableData.SetUserState(key, value);
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0005A3E4 File Offset: 0x000585E4
		public void SuppressExecution()
		{
			this._mutableData.SuppressExecution();
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x0005A3F1 File Offset: 0x000585F1
		public global::System.Exception OriginalException
		{
			get
			{
				return this._mutableData.OriginalException;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x0005A3FE File Offset: 0x000585FE
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x0005A40B File Offset: 0x0005860B
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

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x0005A419 File Offset: 0x00058619
		public global::System.Threading.Tasks.TaskStatus TaskStatus
		{
			get
			{
				return this._mutableData.TaskStatus;
			}
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0005A426 File Offset: 0x00058626
		public new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult> AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult>)base.AsAsync();
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0005A433 File Offset: 0x00058633
		public new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult> WithCommandBehavior(global::System.Data.CommandBehavior commandBehavior)
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult>)base.WithCommandBehavior(commandBehavior);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0005A441 File Offset: 0x00058641
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult>(this);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0005A449 File Offset: 0x00058649
		public new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult> WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult>)base.WithDbContext(context);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0005A463 File Offset: 0x00058663
		public new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult> WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult>)base.WithObjectContext(context);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0005A47D File Offset: 0x0005867D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0005A485 File Offset: 0x00058685
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0005A48E File Offset: 0x0005868E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x0005A496 File Offset: 0x00058696
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B77 RID: 2935
		private readonly global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<TResult> _mutableData = new global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<TResult>();
	}
}
