using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200029A RID: 666
	public class PropertyInterceptionContext<TValue> : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext
	{
		// Token: 0x0600213F RID: 8511 RVA: 0x0005C60C File Offset: 0x0005A80C
		public PropertyInterceptionContext()
		{
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x0005C620 File Offset: 0x0005A820
		public PropertyInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
			global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue> propertyInterceptionContext = copyFrom as global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue>;
			if (propertyInterceptionContext != null)
			{
				this._value = propertyInterceptionContext._value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x0005C661 File Offset: 0x0005A861
		global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext.MutableData
		{
			get
			{
				return this._mutableData;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x0005C669 File Offset: 0x0005A869
		public TValue Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x0005C671 File Offset: 0x0005A871
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x0005C67E File Offset: 0x0005A87E
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

		// Token: 0x06002145 RID: 8517 RVA: 0x0005C68C File Offset: 0x0005A88C
		public object FindUserState(string key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(key, "key");
			return this._mutableData.FindUserState(key);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0005C6A6 File Offset: 0x0005A8A6
		public void SetUserState(string key, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(key, "key");
			this._mutableData.SetUserState(key, value);
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0005C6C1 File Offset: 0x0005A8C1
		public global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue> WithValue(TValue value)
		{
			global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue> propertyInterceptionContext = this.TypedClone();
			propertyInterceptionContext._value = value;
			return propertyInterceptionContext;
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0005C6D0 File Offset: 0x0005A8D0
		private global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue> TypedClone()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue>)this.Clone();
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0005C6DD File Offset: 0x0005A8DD
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue>(this);
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x0005C6E5 File Offset: 0x0005A8E5
		public bool IsExecutionSuppressed
		{
			get
			{
				return this._mutableData.IsExecutionSuppressed;
			}
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0005C6F2 File Offset: 0x0005A8F2
		public void SuppressExecution()
		{
			this._mutableData.SuppressExecution();
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x0005C6FF File Offset: 0x0005A8FF
		public global::System.Exception OriginalException
		{
			get
			{
				return this._mutableData.OriginalException;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x0005C70C File Offset: 0x0005A90C
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x0005C719 File Offset: 0x0005A919
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

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x0005C727 File Offset: 0x0005A927
		public global::System.Threading.Tasks.TaskStatus TaskStatus
		{
			get
			{
				return this._mutableData.TaskStatus;
			}
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x0005C734 File Offset: 0x0005A934
		public new global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue> AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue>)base.AsAsync();
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x0005C741 File Offset: 0x0005A941
		public new global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue> WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue>)base.WithDbContext(context);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x0005C75B File Offset: 0x0005A95B
		public new global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue> WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue>)base.WithObjectContext(context);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x0005C775 File Offset: 0x0005A975
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0005C77D File Offset: 0x0005A97D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x0005C786 File Offset: 0x0005A986
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0005C78E File Offset: 0x0005A98E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B97 RID: 2967
		private readonly global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData _mutableData = new global::System.Data.Entity.Infrastructure.Interception.InterceptionContextMutableData();

		// Token: 0x04000B98 RID: 2968
		private TValue _value;
	}
}
