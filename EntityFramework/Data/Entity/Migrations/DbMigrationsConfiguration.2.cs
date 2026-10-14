using System;
using System.ComponentModel;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations
{
	// Token: 0x0200009F RID: 159
	public class DbMigrationsConfiguration<TContext> : global::System.Data.Entity.Migrations.DbMigrationsConfiguration where TContext : global::System.Data.Entity.DbContext
	{
		// Token: 0x06000E7A RID: 3706 RVA: 0x0001C3BF File Offset: 0x0001A5BF
		static DbMigrationsConfiguration()
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForContext(typeof(TContext));
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0001C3D5 File Offset: 0x0001A5D5
		public DbMigrationsConfiguration()
		{
			base.ContextType = typeof(TContext);
			base.MigrationsAssembly = this.GetType().Assembly();
			base.MigrationsNamespace = this.GetType().Namespace;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0001C40F File Offset: 0x0001A60F
		protected virtual void Seed(TContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TContext>(context, "context");
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0001C41D File Offset: 0x0001A61D
		internal override void OnSeed(global::System.Data.Entity.DbContext context)
		{
			this.Seed((TContext)((object)context));
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0001C42B File Offset: 0x0001A62B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0001C433 File Offset: 0x0001A633
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0001C43C File Offset: 0x0001A63C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0001C444 File Offset: 0x0001A644
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0001C44C File Offset: 0x0001A64C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected new object MemberwiseClone()
		{
			return base.MemberwiseClone();
		}
	}
}
