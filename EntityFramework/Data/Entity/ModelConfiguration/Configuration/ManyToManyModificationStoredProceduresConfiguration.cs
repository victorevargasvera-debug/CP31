using System;
using System.ComponentModel;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001D8 RID: 472
	public class ManyToManyModificationStoredProceduresConfiguration<TEntityType, TTargetEntityType> where TEntityType : class where TTargetEntityType : class
	{
		// Token: 0x060018BB RID: 6331 RVA: 0x00041AE5 File Offset: 0x0003FCE5
		internal ManyToManyModificationStoredProceduresConfiguration()
		{
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x00041AF8 File Offset: 0x0003FCF8
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration Configuration
		{
			get
			{
				return this._configuration;
			}
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00041B00 File Offset: 0x0003FD00
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProceduresConfiguration<TEntityType, TTargetEntityType> Insert(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType>> modificationStoredProcedureConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType>>>(modificationStoredProcedureConfigurationAction, "modificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> manyToManyModificationStoredProcedureConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType>();
			modificationStoredProcedureConfigurationAction(manyToManyModificationStoredProcedureConfiguration);
			this._configuration.Insert(manyToManyModificationStoredProcedureConfiguration.Configuration);
			return this;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00041B38 File Offset: 0x0003FD38
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProceduresConfiguration<TEntityType, TTargetEntityType> Delete(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType>> modificationStoredProcedureConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType>>>(modificationStoredProcedureConfigurationAction, "modificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> manyToManyModificationStoredProcedureConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType>();
			modificationStoredProcedureConfigurationAction(manyToManyModificationStoredProcedureConfiguration);
			this._configuration.Delete(manyToManyModificationStoredProcedureConfiguration.Configuration);
			return this;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00041B70 File Offset: 0x0003FD70
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00041B78 File Offset: 0x0003FD78
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00041B81 File Offset: 0x0003FD81
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00041B89 File Offset: 0x0003FD89
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A68 RID: 2664
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration _configuration = new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration();
	}
}
