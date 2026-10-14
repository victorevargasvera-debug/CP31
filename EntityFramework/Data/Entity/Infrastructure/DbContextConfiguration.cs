using System;
using System.ComponentModel;
using System.Data.Entity.Internal;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000224 RID: 548
	public class DbContextConfiguration
	{
		// Token: 0x06001CA1 RID: 7329 RVA: 0x00050F83 File Offset: 0x0004F183
		internal DbContextConfiguration(global::System.Data.Entity.Internal.InternalContext internalContext)
		{
			this._internalContext = internalContext;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00050F92 File Offset: 0x0004F192
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00050F9A File Offset: 0x0004F19A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00050FA3 File Offset: 0x0004F1A3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00050FAB File Offset: 0x0004F1AB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00050FB3 File Offset: 0x0004F1B3
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x00050FC0 File Offset: 0x0004F1C0
		public bool EnsureTransactionsForFunctionsAndCommands
		{
			get
			{
				return this._internalContext.EnsureTransactionsForFunctionsAndCommands;
			}
			set
			{
				this._internalContext.EnsureTransactionsForFunctionsAndCommands = value;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00050FCE File Offset: 0x0004F1CE
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x00050FDB File Offset: 0x0004F1DB
		public bool LazyLoadingEnabled
		{
			get
			{
				return this._internalContext.LazyLoadingEnabled;
			}
			set
			{
				this._internalContext.LazyLoadingEnabled = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00050FE9 File Offset: 0x0004F1E9
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x00050FF6 File Offset: 0x0004F1F6
		public bool ProxyCreationEnabled
		{
			get
			{
				return this._internalContext.ProxyCreationEnabled;
			}
			set
			{
				this._internalContext.ProxyCreationEnabled = value;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00051004 File Offset: 0x0004F204
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x00051011 File Offset: 0x0004F211
		public bool UseDatabaseNullSemantics
		{
			get
			{
				return this._internalContext.UseDatabaseNullSemantics;
			}
			set
			{
				this._internalContext.UseDatabaseNullSemantics = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0005101F File Offset: 0x0004F21F
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x0005102C File Offset: 0x0004F22C
		public bool DisableFilterOverProjectionSimplificationForCustomFunctions
		{
			get
			{
				return this._internalContext.DisableFilterOverProjectionSimplificationForCustomFunctions;
			}
			set
			{
				this._internalContext.DisableFilterOverProjectionSimplificationForCustomFunctions = value;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0005103A File Offset: 0x0004F23A
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x00051047 File Offset: 0x0004F247
		public bool AutoDetectChangesEnabled
		{
			get
			{
				return this._internalContext.AutoDetectChangesEnabled;
			}
			set
			{
				this._internalContext.AutoDetectChangesEnabled = value;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00051055 File Offset: 0x0004F255
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00051062 File Offset: 0x0004F262
		public bool ValidateOnSaveEnabled
		{
			get
			{
				return this._internalContext.ValidateOnSaveEnabled;
			}
			set
			{
				this._internalContext.ValidateOnSaveEnabled = value;
			}
		}

		// Token: 0x04000B02 RID: 2818
		private readonly global::System.Data.Entity.Internal.InternalContext _internalContext;
	}
}
