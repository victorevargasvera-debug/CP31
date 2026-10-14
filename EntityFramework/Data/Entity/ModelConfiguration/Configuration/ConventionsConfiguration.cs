using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Configuration.Properties;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.ModelConfiguration.Conventions.Sets;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001C5 RID: 453
	public class ConventionsConfiguration
	{
		// Token: 0x060017EC RID: 6124 RVA: 0x0003FCFC File Offset: 0x0003DEFC
		internal ConventionsConfiguration() : this(global::System.Data.Entity.ModelConfiguration.Conventions.Sets.V2ConventionSet.Conventions)
		{
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0003FD0C File Offset: 0x0003DF0C
		internal ConventionsConfiguration(global::System.Data.Entity.ModelConfiguration.Conventions.Sets.ConventionSet conventionSet)
		{
			this._configurationConventions = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>();
			this._conceptualModelConventions = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>();
			this._conceptualToStoreMappingConventions = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>();
			this._storeModelConventions = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>();
			base..ctor();
			this._configurationConventions.AddRange(conventionSet.ConfigurationConventions);
			this._conceptualModelConventions.AddRange(conventionSet.ConceptualModelConventions);
			this._conceptualToStoreMappingConventions.AddRange(conventionSet.ConceptualToStoreMappingConventions);
			this._storeModelConventions.AddRange(conventionSet.StoreModelConventions);
			this._initialConventionSet = conventionSet;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0003FD98 File Offset: 0x0003DF98
		private ConventionsConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration source)
		{
			this._configurationConventions = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>();
			this._conceptualModelConventions = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>();
			this._conceptualToStoreMappingConventions = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>();
			this._storeModelConventions = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>();
			base..ctor();
			this._configurationConventions.AddRange(source._configurationConventions);
			this._conceptualModelConventions.AddRange(source._conceptualModelConventions);
			this._conceptualToStoreMappingConventions.AddRange(source._conceptualToStoreMappingConventions);
			this._storeModelConventions.AddRange(source._storeModelConventions);
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0003FE1B File Offset: 0x0003E01B
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> ConfigurationConventions
		{
			get
			{
				return this._configurationConventions;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0003FE23 File Offset: 0x0003E023
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> ConceptualModelConventions
		{
			get
			{
				return this._conceptualModelConventions;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0003FE2B File Offset: 0x0003E02B
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> ConceptualToStoreMappingConventions
		{
			get
			{
				return this._conceptualToStoreMappingConventions;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0003FE33 File Offset: 0x0003E033
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> StoreModelConventions
		{
			get
			{
				return this._storeModelConventions;
			}
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0003FE3B File Offset: 0x0003E03B
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration(this);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x0003FE44 File Offset: 0x0003E044
		public void AddFromAssembly(global::System.Reflection.Assembly assembly)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.Assembly>(assembly, "assembly");
			global::System.Linq.IOrderedEnumerable<global::System.Type> types = from type in assembly.GetAccessibleTypes()
			orderby type.Name
			select type;
			new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFinder().AddConventions(types, delegate(global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention)
			{
				this.Add(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
				{
					convention
				});
			});
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
		public void Add(params global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[] conventions)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]>(conventions, "conventions");
			foreach (global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention in conventions)
			{
				bool flag = true;
				if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConfigurationConvention(convention.GetType()))
				{
					flag = false;
					int num = this._configurationConventions.FindIndex((global::System.Data.Entity.ModelConfiguration.Conventions.IConvention initialConvention) => this._initialConventionSet.ConfigurationConventions.Contains(initialConvention));
					num = ((num == -1) ? this._configurationConventions.Count : num);
					this._configurationConventions.Insert(num, convention);
				}
				if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualModelConvention(convention.GetType()))
				{
					flag = false;
					this._conceptualModelConventions.Add(convention);
				}
				if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsStoreModelConvention(convention.GetType()))
				{
					flag = false;
					this._storeModelConventions.Add(convention);
				}
				if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualToStoreMappingConvention(convention.GetType()))
				{
					flag = false;
					this._conceptualToStoreMappingConventions.Add(convention);
				}
				if (flag)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConventionsConfiguration_InvalidConventionType(convention.GetType()));
				}
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x0003FF86 File Offset: 0x0003E186
		public void Add<TConvention>() where TConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConvention, new()
		{
			this.Add(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
			{
				global::System.Activator.CreateInstance<TConvention>()
			});
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0003FFA4 File Offset: 0x0003E1A4
		public void AddAfter<TExistingConvention>(global::System.Data.Entity.ModelConfiguration.Conventions.IConvention newConvention) where TExistingConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>(newConvention, "newConvention");
			bool flag = true;
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConfigurationConvention(newConvention.GetType()) && global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConfigurationConvention(typeof(TExistingConvention)))
			{
				flag = false;
				global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.Insert(typeof(TExistingConvention), 1, newConvention, this._configurationConventions);
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualModelConvention(newConvention.GetType()) && global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualModelConvention(typeof(TExistingConvention)))
			{
				flag = false;
				global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.Insert(typeof(TExistingConvention), 1, newConvention, this._conceptualModelConventions);
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsStoreModelConvention(newConvention.GetType()) && global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsStoreModelConvention(typeof(TExistingConvention)))
			{
				flag = false;
				global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.Insert(typeof(TExistingConvention), 1, newConvention, this._storeModelConventions);
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualToStoreMappingConvention(newConvention.GetType()) && global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualToStoreMappingConvention(typeof(TExistingConvention)))
			{
				flag = false;
				global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.Insert(typeof(TExistingConvention), 1, newConvention, this._conceptualToStoreMappingConventions);
			}
			if (flag)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConventionsConfiguration_ConventionTypeMissmatch(newConvention.GetType(), typeof(TExistingConvention)));
			}
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000400BC File Offset: 0x0003E2BC
		public void AddBefore<TExistingConvention>(global::System.Data.Entity.ModelConfiguration.Conventions.IConvention newConvention) where TExistingConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>(newConvention, "newConvention");
			bool flag = true;
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConfigurationConvention(newConvention.GetType()) && global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConfigurationConvention(typeof(TExistingConvention)))
			{
				flag = false;
				global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.Insert(typeof(TExistingConvention), 0, newConvention, this._configurationConventions);
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualModelConvention(newConvention.GetType()) && global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualModelConvention(typeof(TExistingConvention)))
			{
				flag = false;
				global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.Insert(typeof(TExistingConvention), 0, newConvention, this._conceptualModelConventions);
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsStoreModelConvention(newConvention.GetType()) && global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsStoreModelConvention(typeof(TExistingConvention)))
			{
				flag = false;
				global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.Insert(typeof(TExistingConvention), 0, newConvention, this._storeModelConventions);
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualToStoreMappingConvention(newConvention.GetType()) && global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualToStoreMappingConvention(typeof(TExistingConvention)))
			{
				flag = false;
				global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.Insert(typeof(TExistingConvention), 0, newConvention, this._conceptualToStoreMappingConventions);
			}
			if (flag)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConventionsConfiguration_ConventionTypeMissmatch(newConvention.GetType(), typeof(TExistingConvention)));
			}
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x000401D4 File Offset: 0x0003E3D4
		private static void Insert(global::System.Type existingConventionType, int offset, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention newConvention, global::System.Collections.Generic.IList<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> conventions)
		{
			int num = global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.IndexOf(existingConventionType, conventions);
			if (num < 0)
			{
				throw global::System.Data.Entity.Resources.Error.ConventionNotFound(newConvention.GetType(), existingConventionType);
			}
			conventions.Insert(num + offset, newConvention);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00040204 File Offset: 0x0003E404
		private static int IndexOf(global::System.Type existingConventionType, global::System.Collections.Generic.IList<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> conventions)
		{
			int num = 0;
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> enumerator = conventions.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetType() == existingConventionType)
					{
						return num;
					}
					num++;
				}
			}
			return -1;
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00040260 File Offset: 0x0003E460
		public void Remove(params global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[] conventions)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]>(conventions, "conventions");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]>(conventions, "conventions");
			foreach (global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention in conventions)
			{
				if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConfigurationConvention(convention.GetType()))
				{
					this._configurationConventions.Remove(convention);
				}
				if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualModelConvention(convention.GetType()))
				{
					this._conceptualModelConventions.Remove(convention);
				}
				if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsStoreModelConvention(convention.GetType()))
				{
					this._storeModelConventions.Remove(convention);
				}
				if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualToStoreMappingConvention(convention.GetType()))
				{
					this._conceptualToStoreMappingConventions.Remove(convention);
				}
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00040304 File Offset: 0x0003E504
		public void Remove<TConvention>() where TConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
		{
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConfigurationConvention(typeof(TConvention)))
			{
				this._configurationConventions.RemoveAll((global::System.Data.Entity.ModelConfiguration.Conventions.IConvention c) => c.GetType() == typeof(TConvention));
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualModelConvention(typeof(TConvention)))
			{
				this._conceptualModelConventions.RemoveAll((global::System.Data.Entity.ModelConfiguration.Conventions.IConvention c) => c.GetType() == typeof(TConvention));
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsStoreModelConvention(typeof(TConvention)))
			{
				this._storeModelConventions.RemoveAll((global::System.Data.Entity.ModelConfiguration.Conventions.IConvention c) => c.GetType() == typeof(TConvention));
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualToStoreMappingConvention(typeof(TConvention)))
			{
				this._conceptualToStoreMappingConventions.RemoveAll((global::System.Data.Entity.ModelConfiguration.Conventions.IConvention c) => c.GetType() == typeof(TConvention));
			}
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00040404 File Offset: 0x0003E604
		internal void ApplyConceptualModel(global::System.Data.Entity.Infrastructure.DbModel model)
		{
			foreach (global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention in this._conceptualModelConventions)
			{
				new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.ModelConventionDispatcher(convention, model, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace).Dispatch();
			}
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0004045C File Offset: 0x0003E65C
		internal void ApplyStoreModel(global::System.Data.Entity.Infrastructure.DbModel model)
		{
			foreach (global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention in this._storeModelConventions)
			{
				new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.ModelConventionDispatcher(convention, model, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace).Dispatch();
			}
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000404B4 File Offset: 0x0003E6B4
		internal void ApplyPluralizingTableNameConvention(global::System.Data.Entity.Infrastructure.DbModel model)
		{
			foreach (global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention in from c in this._storeModelConventions
			where c is global::System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention
			select c)
			{
				new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.ModelConventionDispatcher(convention, model, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace).Dispatch();
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0004052C File Offset: 0x0003E72C
		internal void ApplyMapping(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			foreach (global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention in this._conceptualToStoreMappingConventions)
			{
				global::System.Data.Entity.ModelConfiguration.Conventions.IDbMappingConvention dbMappingConvention = convention as global::System.Data.Entity.ModelConfiguration.Conventions.IDbMappingConvention;
				if (dbMappingConvention != null)
				{
					dbMappingConvention.Apply(databaseMapping);
				}
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00040588 File Offset: 0x0003E788
		internal virtual void ApplyModelConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			for (int i = this._configurationConventions.Count - 1; i >= 0; i--)
			{
				global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention = this._configurationConventions[i];
				global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention configurationConvention = convention as global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention;
				if (configurationConvention != null)
				{
					configurationConvention.Apply(modelConfiguration);
				}
				global::System.Data.Entity.ModelConfiguration.Conventions.Convention convention2 = convention as global::System.Data.Entity.ModelConfiguration.Conventions.Convention;
				if (convention2 != null)
				{
					convention2.ApplyModelConfiguration(modelConfiguration);
				}
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x000405DC File Offset: 0x0003E7DC
		internal virtual void ApplyModelConfiguration(global::System.Type type, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			for (int i = this._configurationConventions.Count - 1; i >= 0; i--)
			{
				global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention = this._configurationConventions[i];
				global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Type> configurationConvention = convention as global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Type>;
				if (configurationConvention != null)
				{
					configurationConvention.Apply(type, modelConfiguration);
				}
				global::System.Data.Entity.ModelConfiguration.Conventions.Convention convention2 = convention as global::System.Data.Entity.ModelConfiguration.Conventions.Convention;
				if (convention2 != null)
				{
					convention2.ApplyModelConfiguration(type, modelConfiguration);
				}
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00040630 File Offset: 0x0003E830
		internal virtual void ApplyTypeConfiguration<TStructuralTypeConfiguration>(global::System.Type type, global::System.Func<TStructuralTypeConfiguration> structuralTypeConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration) where TStructuralTypeConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration
		{
			for (int i = this._configurationConventions.Count - 1; i >= 0; i--)
			{
				global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention = this._configurationConventions[i];
				global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Type, TStructuralTypeConfiguration> configurationConvention = convention as global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Type, TStructuralTypeConfiguration>;
				if (configurationConvention != null)
				{
					configurationConvention.Apply(type, structuralTypeConfiguration, modelConfiguration);
				}
				global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration> configurationConvention2 = convention as global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration>;
				if (configurationConvention2 != null)
				{
					configurationConvention2.Apply(type, structuralTypeConfiguration, modelConfiguration);
				}
				global::System.Data.Entity.ModelConfiguration.Conventions.Convention convention2 = convention as global::System.Data.Entity.ModelConfiguration.Conventions.Convention;
				if (convention2 != null)
				{
					convention2.ApplyTypeConfiguration<TStructuralTypeConfiguration>(type, structuralTypeConfiguration, modelConfiguration);
				}
			}
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x0004069C File Offset: 0x0003E89C
		internal virtual void ApplyPropertyConfiguration(global::System.Reflection.PropertyInfo propertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			for (int i = this._configurationConventions.Count - 1; i >= 0; i--)
			{
				global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention = this._configurationConventions[i];
				global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Reflection.PropertyInfo> configurationConvention = convention as global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Reflection.PropertyInfo>;
				if (configurationConvention != null)
				{
					configurationConvention.Apply(propertyInfo, modelConfiguration);
				}
				global::System.Data.Entity.ModelConfiguration.Conventions.Convention convention2 = convention as global::System.Data.Entity.ModelConfiguration.Conventions.Convention;
				if (convention2 != null)
				{
					convention2.ApplyPropertyConfiguration(propertyInfo, modelConfiguration);
				}
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000406F0 File Offset: 0x0003E8F0
		internal virtual void ApplyPropertyConfiguration(global::System.Reflection.PropertyInfo propertyInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration> propertyConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			global::System.Type propertyConfigurationType = global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration.GetPropertyConfigurationType(propertyInfo.PropertyType);
			for (int i = this._configurationConventions.Count - 1; i >= 0; i--)
			{
				global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention = this._configurationConventions[i];
				new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration.PropertyConfigurationConventionDispatcher(convention, propertyConfigurationType, propertyInfo, propertyConfiguration, modelConfiguration).Dispatch();
				global::System.Data.Entity.ModelConfiguration.Conventions.Convention convention2 = convention as global::System.Data.Entity.ModelConfiguration.Conventions.Convention;
				if (convention2 != null)
				{
					convention2.ApplyPropertyConfiguration(propertyInfo, propertyConfiguration, modelConfiguration);
				}
			}
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00040750 File Offset: 0x0003E950
		internal virtual void ApplyPropertyTypeConfiguration<TStructuralTypeConfiguration>(global::System.Reflection.PropertyInfo propertyInfo, global::System.Func<TStructuralTypeConfiguration> structuralTypeConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration) where TStructuralTypeConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration
		{
			for (int i = this._configurationConventions.Count - 1; i >= 0; i--)
			{
				global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention = this._configurationConventions[i];
				global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Reflection.PropertyInfo, TStructuralTypeConfiguration> configurationConvention = convention as global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Reflection.PropertyInfo, TStructuralTypeConfiguration>;
				if (configurationConvention != null)
				{
					configurationConvention.Apply(propertyInfo, structuralTypeConfiguration, modelConfiguration);
				}
				global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Reflection.PropertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration> configurationConvention2 = convention as global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Reflection.PropertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration>;
				if (configurationConvention2 != null)
				{
					configurationConvention2.Apply(propertyInfo, structuralTypeConfiguration, modelConfiguration);
				}
				global::System.Data.Entity.ModelConfiguration.Conventions.Convention convention2 = convention as global::System.Data.Entity.ModelConfiguration.Conventions.Convention;
				if (convention2 != null)
				{
					convention2.ApplyPropertyTypeConfiguration<TStructuralTypeConfiguration>(propertyInfo, structuralTypeConfiguration, modelConfiguration);
				}
			}
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x000407B9 File Offset: 0x0003E9B9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x000407C1 File Offset: 0x0003E9C1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000407CA File Offset: 0x0003E9CA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000407D2 File Offset: 0x0003E9D2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A4A RID: 2634
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> _configurationConventions;

		// Token: 0x04000A4B RID: 2635
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> _conceptualModelConventions;

		// Token: 0x04000A4C RID: 2636
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> _conceptualToStoreMappingConventions;

		// Token: 0x04000A4D RID: 2637
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> _storeModelConventions;

		// Token: 0x04000A4E RID: 2638
		private readonly global::System.Data.Entity.ModelConfiguration.Conventions.Sets.ConventionSet _initialConventionSet;

		// Token: 0x020008A8 RID: 2216
		private class ModelConventionDispatcher : global::System.Data.Entity.Edm.EdmModelVisitor
		{
			// Token: 0x06005B98 RID: 23448 RVA: 0x0013D93A File Offset: 0x0013BB3A
			public ModelConventionDispatcher(global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention, global::System.Data.Entity.Infrastructure.DbModel model, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>(convention, "convention");
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
				this._convention = convention;
				this._model = model;
				this._dataSpace = dataSpace;
			}

			// Token: 0x06005B99 RID: 23449 RVA: 0x0013D96F File Offset: 0x0013BB6F
			public void Dispatch()
			{
				this.VisitEdmModel((this._dataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace) ? this._model.ConceptualModel : this._model.StoreModel);
			}

			// Token: 0x06005B9A RID: 23450 RVA: 0x0013D998 File Offset: 0x0013BB98
			private void Dispatch<T>(T item) where T : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
			{
				if (this._dataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
				{
					global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<T> conceptualModelConvention = this._convention as global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<T>;
					if (conceptualModelConvention != null)
					{
						conceptualModelConvention.Apply(item, this._model);
						return;
					}
				}
				else
				{
					global::System.Data.Entity.ModelConfiguration.Conventions.IStoreModelConvention<T> storeModelConvention = this._convention as global::System.Data.Entity.ModelConfiguration.Conventions.IStoreModelConvention<T>;
					if (storeModelConvention != null)
					{
						storeModelConvention.Apply(item, this._model);
					}
				}
			}

			// Token: 0x06005B9B RID: 23451 RVA: 0x0013D9E7 File Offset: 0x0013BBE7
			protected internal override void VisitEdmModel(global::System.Data.Entity.Core.Metadata.Edm.EdmModel item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>(item);
				base.VisitEdmModel(item);
			}

			// Token: 0x06005B9C RID: 23452 RVA: 0x0013D9F7 File Offset: 0x0013BBF7
			protected override void VisitEdmNavigationProperty(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(item);
				base.VisitEdmNavigationProperty(item);
			}

			// Token: 0x06005B9D RID: 23453 RVA: 0x0013DA07 File Offset: 0x0013BC07
			protected override void VisitEdmAssociationConstraint(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(item);
				if (item != null)
				{
					this.VisitMetadataItem(item);
				}
			}

			// Token: 0x06005B9E RID: 23454 RVA: 0x0013DA1A File Offset: 0x0013BC1A
			protected override void VisitEdmAssociationEnd(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>(item);
				base.VisitEdmAssociationEnd(item);
			}

			// Token: 0x06005B9F RID: 23455 RVA: 0x0013DA2A File Offset: 0x0013BC2A
			protected internal override void VisitEdmProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(item);
				base.VisitEdmProperty(item);
			}

			// Token: 0x06005BA0 RID: 23456 RVA: 0x0013DA3A File Offset: 0x0013BC3A
			protected internal override void VisitMetadataItem(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem>(item);
				base.VisitMetadataItem(item);
			}

			// Token: 0x06005BA1 RID: 23457 RVA: 0x0013DA4A File Offset: 0x0013BC4A
			protected override void VisitEdmEntityContainer(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(item);
				base.VisitEdmEntityContainer(item);
			}

			// Token: 0x06005BA2 RID: 23458 RVA: 0x0013DA5A File Offset: 0x0013BC5A
			protected internal override void VisitEdmEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySet item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(item);
				base.VisitEdmEntitySet(item);
			}

			// Token: 0x06005BA3 RID: 23459 RVA: 0x0013DA6A File Offset: 0x0013BC6A
			protected override void VisitEdmAssociationSet(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(item);
				base.VisitEdmAssociationSet(item);
			}

			// Token: 0x06005BA4 RID: 23460 RVA: 0x0013DA7A File Offset: 0x0013BC7A
			protected override void VisitEdmAssociationSetEnd(global::System.Data.Entity.Core.Metadata.Edm.EntitySet item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(item);
				base.VisitEdmAssociationSetEnd(item);
			}

			// Token: 0x06005BA5 RID: 23461 RVA: 0x0013DA8A File Offset: 0x0013BC8A
			protected override void VisitComplexType(global::System.Data.Entity.Core.Metadata.Edm.ComplexType item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(item);
				base.VisitComplexType(item);
			}

			// Token: 0x06005BA6 RID: 23462 RVA: 0x0013DA9A File Offset: 0x0013BC9A
			protected internal override void VisitEdmEntityType(global::System.Data.Entity.Core.Metadata.Edm.EntityType item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(item);
				this.VisitMetadataItem(item);
				if (item != null)
				{
					this.VisitDeclaredProperties(item, item.DeclaredProperties);
					this.VisitDeclaredNavigationProperties(item, item.DeclaredNavigationProperties);
				}
			}

			// Token: 0x06005BA7 RID: 23463 RVA: 0x0013DAC7 File Offset: 0x0013BCC7
			protected internal override void VisitEdmAssociationType(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item)
			{
				this.Dispatch<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item);
				base.VisitEdmAssociationType(item);
			}

			// Token: 0x040023CF RID: 9167
			private readonly global::System.Data.Entity.ModelConfiguration.Conventions.IConvention _convention;

			// Token: 0x040023D0 RID: 9168
			private readonly global::System.Data.Entity.Infrastructure.DbModel _model;

			// Token: 0x040023D1 RID: 9169
			private readonly global::System.Data.Entity.Core.Metadata.Edm.DataSpace _dataSpace;
		}

		// Token: 0x020008A9 RID: 2217
		private class PropertyConfigurationConventionDispatcher
		{
			// Token: 0x06005BA8 RID: 23464 RVA: 0x0013DAD8 File Offset: 0x0013BCD8
			public PropertyConfigurationConventionDispatcher(global::System.Data.Entity.ModelConfiguration.Conventions.IConvention convention, global::System.Type propertyConfigurationType, global::System.Reflection.PropertyInfo propertyInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration> propertyConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>(convention, "convention");
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(propertyConfigurationType, "propertyConfigurationType");
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration>>(propertyConfiguration, "propertyConfiguration");
				this._convention = convention;
				this._propertyConfigurationType = propertyConfigurationType;
				this._propertyInfo = propertyInfo;
				this._propertyConfiguration = propertyConfiguration;
				this._modelConfiguration = modelConfiguration;
			}

			// Token: 0x06005BA9 RID: 23465 RVA: 0x0013DB41 File Offset: 0x0013BD41
			public void Dispatch()
			{
				this.Dispatch<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration>();
				this.Dispatch<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>();
				this.Dispatch<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration>();
				this.Dispatch<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>();
				this.Dispatch<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration>();
				this.Dispatch<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration>();
				this.Dispatch<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration>();
				this.Dispatch<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration>();
			}

			// Token: 0x06005BAA RID: 23466 RVA: 0x0013DB74 File Offset: 0x0013BD74
			private void Dispatch<TPropertyConfiguration>() where TPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration
			{
				global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Reflection.PropertyInfo, TPropertyConfiguration> configurationConvention = this._convention as global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Reflection.PropertyInfo, TPropertyConfiguration>;
				if (configurationConvention != null && typeof(TPropertyConfiguration).IsAssignableFrom(this._propertyConfigurationType))
				{
					configurationConvention.Apply(this._propertyInfo, () => (TPropertyConfiguration)((object)this._propertyConfiguration()), this._modelConfiguration);
				}
			}

			// Token: 0x040023D2 RID: 9170
			private readonly global::System.Data.Entity.ModelConfiguration.Conventions.IConvention _convention;

			// Token: 0x040023D3 RID: 9171
			private readonly global::System.Type _propertyConfigurationType;

			// Token: 0x040023D4 RID: 9172
			private readonly global::System.Reflection.PropertyInfo _propertyInfo;

			// Token: 0x040023D5 RID: 9173
			private readonly global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration> _propertyConfiguration;

			// Token: 0x040023D6 RID: 9174
			private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration _modelConfiguration;
		}
	}
}
