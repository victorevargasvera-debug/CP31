using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000D9 RID: 217
	internal class ModificationCommandTreeGenerator
	{
		// Token: 0x060010A2 RID: 4258 RVA: 0x00024CA0 File Offset: 0x00022EA0
		public ModificationCommandTreeGenerator(global::System.Data.Entity.Infrastructure.DbModel model, global::System.Data.Common.DbConnection connection = null)
		{
			this._compiledModel = model.Compile();
			this._connection = connection;
			using (global::System.Data.Entity.DbContext dbContext = this.CreateContext())
			{
				this._metadataWorkspace = ((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)dbContext).ObjectContext.MetadataWorkspace;
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00024CFC File Offset: 0x00022EFC
		private global::System.Data.Entity.DbContext CreateContext()
		{
			if (this._connection != null)
			{
				return new global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator.TempDbContext(this._connection, this._compiledModel);
			}
			return new global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator.TempDbContext(this._compiledModel);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00024D23 File Offset: 0x00022F23
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree> GenerateAssociationInsert(string associationIdentity)
		{
			return this.GenerateAssociation<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree>(associationIdentity, global::System.Data.Entity.EntityState.Added);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00024D2D File Offset: 0x00022F2D
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree> GenerateAssociationDelete(string associationIdentity)
		{
			return this.GenerateAssociation<global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree>(associationIdentity, global::System.Data.Entity.EntityState.Deleted);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00024D37 File Offset: 0x00022F37
		private global::System.Collections.Generic.IEnumerable<TCommandTree> GenerateAssociation<TCommandTree>(string associationIdentity, global::System.Data.Entity.EntityState state) where TCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType item = this._metadataWorkspace.GetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(associationIdentity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			using (global::System.Data.Entity.DbContext context = this.CreateContext())
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = item.SourceEnd.GetEntityType();
				object obj = this.InstantiateAndAttachEntity(entityType, context);
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = item.TargetEnd.GetEntityType();
				object targetEntity = (entityType.GetRootType() == entityType2.GetRootType()) ? obj : this.InstantiateAndAttachEntity(entityType2, context);
				((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)context).ObjectContext.ObjectStateManager.ChangeRelationshipState(obj, targetEntity, item.FullName, item.TargetEnd.Name, (state == global::System.Data.Entity.EntityState.Deleted) ? state : global::System.Data.Entity.EntityState.Added);
				using (global::System.Data.Entity.Internal.CommandTracer commandTracer = new global::System.Data.Entity.Internal.CommandTracer(context))
				{
					context.SaveChanges();
					foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree dbCommandTree in commandTracer.CommandTrees)
					{
						yield return (TCommandTree)((object)dbCommandTree);
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree> enumerator = null;
				}
				global::System.Data.Entity.Internal.CommandTracer commandTracer = null;
			}
			global::System.Data.Entity.DbContext context = null;
			yield break;
			yield break;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00024D58 File Offset: 0x00022F58
		private object InstantiateAndAttachEntity(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.DbContext context)
		{
			global::System.Type clrType = entityType.GetClrType();
			global::System.Data.Entity.DbSet dbSet = context.Set(clrType);
			object obj = this.InstantiateEntity(entityType, context, clrType, dbSet);
			global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator.SetFakeReferenceKeyValues(obj, entityType);
			global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator.SetFakeKeyValues(obj, entityType);
			dbSet.Attach(obj);
			return obj;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00024D98 File Offset: 0x00022F98
		private object InstantiateEntity(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.DbContext context, global::System.Type clrType, global::System.Data.Entity.DbSet set)
		{
			object obj;
			if (!clrType.IsAbstract())
			{
				obj = set.Create();
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = this._metadataWorkspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace).First((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => entityType.IsAncestorOf(et) && !et.Abstract);
				obj = context.Set(entityType2.GetClrType()).Create();
			}
			global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator.InstantiateComplexProperties(obj, entityType.Properties);
			return obj;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00024E06 File Offset: 0x00023006
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree> GenerateInsert(string entityIdentity)
		{
			return this.Generate(entityIdentity, global::System.Data.Entity.EntityState.Added);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00024E10 File Offset: 0x00023010
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree> GenerateUpdate(string entityIdentity)
		{
			return this.Generate(entityIdentity, global::System.Data.Entity.EntityState.Modified);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00024E1B File Offset: 0x0002301B
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree> GenerateDelete(string entityIdentity)
		{
			return this.Generate(entityIdentity, global::System.Data.Entity.EntityState.Deleted);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00024E25 File Offset: 0x00023025
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree> Generate(string entityIdentity, global::System.Data.Entity.EntityState state)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType item = this._metadataWorkspace.GetItem<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityIdentity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			using (global::System.Data.Entity.DbContext context = this.CreateContext())
			{
				object entity = this.InstantiateAndAttachEntity(item, context);
				if (state != global::System.Data.Entity.EntityState.Deleted)
				{
					context.Entry(entity).State = state;
				}
				this.ChangeRelationshipStates(context, item, entity, state);
				if (state == global::System.Data.Entity.EntityState.Deleted)
				{
					context.Entry(entity).State = state;
				}
				this.HandleTableSplitting(context, item, entity, state);
				using (global::System.Data.Entity.Internal.CommandTracer commandTracer = new global::System.Data.Entity.Internal.CommandTracer(context))
				{
					((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)context).ObjectContext.SaveChanges(global::System.Data.Entity.Core.Objects.SaveOptions.None);
					foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree dbCommandTree in commandTracer.CommandTrees)
					{
						yield return (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree)dbCommandTree;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree> enumerator = null;
				}
				global::System.Data.Entity.Internal.CommandTracer commandTracer = null;
			}
			global::System.Data.Entity.DbContext context = null;
			yield break;
			yield break;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00024E44 File Offset: 0x00023044
		private void ChangeRelationshipStates(global::System.Data.Entity.DbContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, object entity, global::System.Data.Entity.EntityState state)
		{
			global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = ((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)context).ObjectContext.ObjectStateManager;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType in from at in this._metadataWorkspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			where !at.IsForeignKey && !at.IsManyToMany() && (at.SourceEnd.GetEntityType().IsAssignableFrom(entityType) || at.TargetEnd.GetEntityType().IsAssignableFrom(entityType))
			select at)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceEnd;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetEnd;
				if (!associationType.TryGuessPrincipalAndDependentEnds(out sourceEnd, out targetEnd))
				{
					sourceEnd = associationType.SourceEnd;
					targetEnd = associationType.TargetEnd;
				}
				if (targetEnd.GetEntityType().IsAssignableFrom(entityType))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = sourceEnd.GetEntityType();
					global::System.Type clrType = entityType2.GetClrType();
					global::System.Data.Entity.DbSet dbSet = context.Set(clrType);
					object obj = dbSet.Local.Cast<object>().SingleOrDefault<object>();
					if (obj == null || (entity == obj && state == global::System.Data.Entity.EntityState.Added))
					{
						obj = this.InstantiateEntity(entityType2, context, clrType, dbSet);
						global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator.SetFakeReferenceKeyValues(obj, entityType2);
						dbSet.Attach(obj);
					}
					if (sourceEnd.IsRequired() && state == global::System.Data.Entity.EntityState.Modified)
					{
						object obj2 = this.InstantiateEntity(entityType2, context, clrType, dbSet);
						global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator.SetFakeKeyValues(obj2, entityType2);
						dbSet.Attach(obj2);
						objectStateManager.ChangeRelationshipState(entity, obj2, associationType.FullName, sourceEnd.Name, global::System.Data.Entity.EntityState.Deleted);
					}
					objectStateManager.ChangeRelationshipState(entity, obj, associationType.FullName, sourceEnd.Name, (state == global::System.Data.Entity.EntityState.Deleted) ? state : global::System.Data.Entity.EntityState.Added);
				}
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00024FC8 File Offset: 0x000231C8
		private void HandleTableSplitting(global::System.Data.Entity.DbContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, object entity, global::System.Data.Entity.EntityState state)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType in from at in this._metadataWorkspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			where at.IsForeignKey && at.IsRequiredToRequired() && !at.IsSelfReferencing() && (at.SourceEnd.GetEntityType().IsAssignableFrom(entityType) || at.TargetEnd.GetEntityType().IsAssignableFrom(entityType)) && this._metadataWorkspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace).All((global::System.Data.Entity.Core.Metadata.Edm.AssociationType fk) => fk.Name != at.Name)
			select at)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceEnd;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetEnd;
				if (!associationType.TryGuessPrincipalAndDependentEnds(out sourceEnd, out targetEnd))
				{
					sourceEnd = associationType.SourceEnd;
					targetEnd = associationType.TargetEnd;
				}
				bool flag = false;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2;
				if (sourceEnd.GetEntityType().GetRootType() == entityType.GetRootType())
				{
					flag = true;
					entityType2 = targetEnd.GetEntityType();
				}
				else
				{
					entityType2 = sourceEnd.GetEntityType();
				}
				object entity2 = this.InstantiateAndAttachEntity(entityType2, context);
				if (!flag)
				{
					if (state == global::System.Data.Entity.EntityState.Added)
					{
						context.Entry(entity).State = global::System.Data.Entity.EntityState.Modified;
					}
					else if (state == global::System.Data.Entity.EntityState.Deleted)
					{
						context.Entry(entity).State = global::System.Data.Entity.EntityState.Unchanged;
					}
				}
				else if (state != global::System.Data.Entity.EntityState.Modified)
				{
					context.Entry(entity2).State = state;
				}
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x000250D8 File Offset: 0x000232D8
		private static void SetFakeReferenceKeyValues(object entity, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in entityType.KeyProperties)
			{
				global::System.Reflection.PropertyInfo clrPropertyInfo = edmProperty.GetClrPropertyInfo();
				object fakeReferenceKeyValue = global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator.GetFakeReferenceKeyValue(edmProperty.UnderlyingPrimitiveType.PrimitiveTypeKind);
				if (fakeReferenceKeyValue != null)
				{
					clrPropertyInfo.GetPropertyInfoForSet().SetValue(entity, fakeReferenceKeyValue, null);
				}
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0002514C File Offset: 0x0002334C
		private static object GetFakeReferenceKeyValue(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			if (primitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary)
			{
				switch (primitiveTypeKind)
				{
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
					return "42";
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry:
					return global::System.Data.Entity.Spatial.DefaultSpatialServices.Instance.GeometryFromText("POINT (4 2)");
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography:
					return global::System.Data.Entity.Spatial.DefaultSpatialServices.Instance.GeographyFromText("POINT (4 2)");
				}
				return null;
			}
			return new byte[0];
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x000251AC File Offset: 0x000233AC
		private static void SetFakeKeyValues(object entity, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in entityType.KeyProperties)
			{
				global::System.Reflection.PropertyInfo clrPropertyInfo = edmProperty.GetClrPropertyInfo();
				object fakeKeyValue = global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator.GetFakeKeyValue(edmProperty.UnderlyingPrimitiveType.PrimitiveTypeKind);
				clrPropertyInfo.GetPropertyInfoForSet().SetValue(entity, fakeKeyValue, null);
			}
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0002521C File Offset: 0x0002341C
		private static object GetFakeKeyValue(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			switch (primitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
				return new byte[]
				{
					66
				};
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
				return 66;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
				return global::System.DateTime.Now;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
				return 42m;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
				return 42.0;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
				return global::System.Guid.NewGuid();
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
				return 42f;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte:
				return 42;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
				return 42;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
				return 42;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
				return 42L;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
				return "42'";
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
				return global::System.TimeSpan.FromMilliseconds(42.0);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
				return global::System.DateTimeOffset.Now;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry:
				return global::System.Data.Entity.Spatial.DefaultSpatialServices.Instance.GeometryFromText("POINT (4 3)");
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography:
				return global::System.Data.Entity.Spatial.DefaultSpatialServices.Instance.GeographyFromText("POINT (4 3)");
			default:
				return null;
			}
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00025338 File Offset: 0x00023538
		private static void InstantiateComplexProperties(object structuralObject, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in properties)
			{
				if (edmProperty.IsComplexType)
				{
					global::System.Reflection.PropertyInfo clrPropertyInfo = edmProperty.GetClrPropertyInfo();
					object obj = global::System.Activator.CreateInstance(clrPropertyInfo.PropertyType);
					global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator.InstantiateComplexProperties(obj, edmProperty.ComplexType.Properties);
					clrPropertyInfo.GetPropertyInfoForSet().SetValue(structuralObject, obj, null);
				}
			}
		}

		// Token: 0x040008AB RID: 2219
		private readonly global::System.Data.Entity.Infrastructure.DbCompiledModel _compiledModel;

		// Token: 0x040008AC RID: 2220
		private readonly global::System.Data.Common.DbConnection _connection;

		// Token: 0x040008AD RID: 2221
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _metadataWorkspace;

		// Token: 0x020007AD RID: 1965
		private class TempDbContext : global::System.Data.Entity.DbContext
		{
			// Token: 0x06005806 RID: 22534 RVA: 0x00136DD7 File Offset: 0x00134FD7
			public TempDbContext(global::System.Data.Entity.Infrastructure.DbCompiledModel model) : base(model)
			{
				this.InternalContext.InitializerDisabled = true;
			}

			// Token: 0x06005807 RID: 22535 RVA: 0x00136DEC File Offset: 0x00134FEC
			public TempDbContext(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connection, model, false)
			{
				this.InternalContext.InitializerDisabled = true;
			}
		}
	}
}
