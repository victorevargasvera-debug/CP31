using System;
using System.ComponentModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200027D RID: 637
	public class DbCommandTreeInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree>, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext
	{
		// Token: 0x06002020 RID: 8224 RVA: 0x0005A500 File Offset: 0x00058700
		public DbCommandTreeInterceptionContext()
		{
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0005A513 File Offset: 0x00058713
		public DbCommandTreeInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x0005A533 File Offset: 0x00058733
		internal global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree> MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x0005A53B File Offset: 0x0005873B
		global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree> global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree>.MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x0005A543 File Offset: 0x00058743
		global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext.MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x0005A54B File Offset: 0x0005874B
		public global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree OriginalResult
		{
			get
			{
				return this._mutableData.OriginalResult;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x0005A558 File Offset: 0x00058758
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x0005A565 File Offset: 0x00058765
		public global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree Result
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

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x0005A573 File Offset: 0x00058773
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x0005A580 File Offset: 0x00058780
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

		// Token: 0x0600202A RID: 8234 RVA: 0x0005A58E File Offset: 0x0005878E
		public object FindUserState(string key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(key, "key");
			return this._mutableData.FindUserState(key);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0005A5A8 File Offset: 0x000587A8
		public void SetUserState(string key, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(key, "key");
			this._mutableData.SetUserState(key, value);
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0005A5C3 File Offset: 0x000587C3
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext(this);
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0005A5CB File Offset: 0x000587CB
		public new global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext)base.WithDbContext(context);
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x0005A5E5 File Offset: 0x000587E5
		public new global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext)base.WithObjectContext(context);
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x0005A5FF File Offset: 0x000587FF
		public new global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext)base.AsAsync();
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x0005A60C File Offset: 0x0005880C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x0005A614 File Offset: 0x00058814
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x0005A61D File Offset: 0x0005881D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0005A625 File Offset: 0x00058825
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B79 RID: 2937
		private readonly global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree> _mutableData = new global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree>();
	}
}
