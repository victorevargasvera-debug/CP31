using System;
using System.ComponentModel;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001DC RID: 476
	public class ModificationStoredProceduresConfiguration<TEntityType> where TEntityType : class
	{
		// Token: 0x060018EA RID: 6378 RVA: 0x00042664 File Offset: 0x00040864
		internal ModificationStoredProceduresConfiguration()
		{
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x00042677 File Offset: 0x00040877
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration Configuration
		{
			get
			{
				return this._configuration;
			}
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00042680 File Offset: 0x00040880
		public global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<TEntityType> Insert(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType>> modificationStoredProcedureConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType>>>(modificationStoredProcedureConfigurationAction, "modificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> insertModificationStoredProcedureConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType>();
			modificationStoredProcedureConfigurationAction(insertModificationStoredProcedureConfiguration);
			this._configuration.Insert(insertModificationStoredProcedureConfiguration.Configuration);
			return this;
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x000426B8 File Offset: 0x000408B8
		public global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<TEntityType> Update(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType>> modificationStoredProcedureConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType>>>(modificationStoredProcedureConfigurationAction, "modificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> updateModificationStoredProcedureConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType>();
			modificationStoredProcedureConfigurationAction(updateModificationStoredProcedureConfiguration);
			this._configuration.Update(updateModificationStoredProcedureConfiguration.Configuration);
			return this;
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x000426F0 File Offset: 0x000408F0
		public global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<TEntityType> Delete(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType>> modificationStoredProcedureConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType>>>(modificationStoredProcedureConfigurationAction, "modificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> deleteModificationStoredProcedureConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType>();
			modificationStoredProcedureConfigurationAction(deleteModificationStoredProcedureConfiguration);
			this._configuration.Delete(deleteModificationStoredProcedureConfiguration.Configuration);
			return this;
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00042728 File Offset: 0x00040928
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00042730 File Offset: 0x00040930
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00042739 File Offset: 0x00040939
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00042741 File Offset: 0x00040941
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A73 RID: 2675
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration _configuration = new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration();
	}
}
