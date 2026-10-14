using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000515 RID: 1301
	internal class ObjectItemConventionAssemblyLoader : global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader
	{
		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06004021 RID: 16417 RVA: 0x000D4F94 File Offset: 0x000D3194
		public new virtual global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry CacheEntry
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry)base.CacheEntry;
			}
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x000D4FA1 File Offset: 0x000D31A1
		internal ObjectItemConventionAssemblyLoader(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData sessionData) : base(assembly, new global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry(), sessionData)
		{
			base.SessionData.RegisterForLevel1PostSessionProcessing(this);
			this._factory = new global::System.Data.Entity.Core.Metadata.Edm.ObjectItemConventionAssemblyLoader.ConventionOSpaceTypeFactory(this);
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x000D4FD4 File Offset: 0x000D31D4
		protected override void LoadTypesFromAssembly()
		{
			foreach (global::System.Type type in base.SourceAssembly.GetAccessibleTypes())
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
				if (this.TryGetCSpaceTypeMatch(type, out edmType))
				{
					if (type.IsValueType() && !type.IsEnum())
					{
						base.SessionData.LoadMessageLogger.LogLoadMessage(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_Struct(edmType.FullName, type.FullName), edmType);
					}
					else
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = this._factory.TryCreateType(type, edmType);
						if (edmType2 != null)
						{
							this.CacheEntry.TypesInAssembly.Add(edmType2);
							if (!base.SessionData.CspaceToOspace.ContainsKey(edmType))
							{
								base.SessionData.CspaceToOspace.Add(edmType, edmType2);
							}
							else
							{
								global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType3 = base.SessionData.CspaceToOspace[edmType];
								base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_AmbiguousClrType(edmType.Name, edmType3.ClrType.FullName, type.FullName)));
							}
						}
					}
				}
			}
			if (base.SessionData.TypesInLoading.Count == 0)
			{
				base.SessionData.ObjectItemAssemblyLoaderFactory = null;
			}
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x000D5118 File Offset: 0x000D3318
		protected override void AddToAssembliesLoaded()
		{
			base.SessionData.AssembliesLoaded.Add(base.SourceAssembly, this.CacheEntry);
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x000D5138 File Offset: 0x000D3338
		private bool TryGetCSpaceTypeMatch(global::System.Type type, out global::System.Data.Entity.Core.Metadata.Edm.EdmType cspaceType)
		{
			global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmType, int> keyValuePair;
			if (base.SessionData.ConventionCSpaceTypeNames.TryGetValue(type.Name, out keyValuePair))
			{
				if (keyValuePair.Value == 1)
				{
					cspaceType = keyValuePair.Key;
					return true;
				}
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_MultipleTypesWithSameName(type.Name)));
			}
			cspaceType = null;
			return false;
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x000D5198 File Offset: 0x000D3398
		internal override void OnLevel1SessionProcessing()
		{
			this.CreateRelationships();
			foreach (global::System.Action action in this._referenceResolutions)
			{
				action();
			}
			base.OnLevel1SessionProcessing();
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x000D51F4 File Offset: 0x000D33F4
		internal virtual void TrackClosure(global::System.Type type)
		{
			if (base.SourceAssembly != type.Assembly() && !this.CacheEntry.ClosureAssemblies.Contains(type.Assembly()) && (!type.IsGenericType() || (!global::System.Data.Entity.Core.EntityUtil.IsAnICollection(type) && !(type.GetGenericTypeDefinition() == typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<>)) && !(type.GetGenericTypeDefinition() == typeof(global::System.Nullable<>)))))
			{
				this.CacheEntry.ClosureAssemblies.Add(type.Assembly());
			}
			if (type.IsGenericType())
			{
				foreach (global::System.Type type2 in type.GetGenericArguments())
				{
					this.TrackClosure(type2);
				}
			}
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x000D52A8 File Offset: 0x000D34A8
		private void CreateRelationships()
		{
			if (base.SessionData.ConventionBasedRelationshipsAreLoaded)
			{
				return;
			}
			base.SessionData.ConventionBasedRelationshipsAreLoaded = true;
			this._factory.CreateRelationships(base.SessionData.EdmItemCollection);
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x000D52DA File Offset: 0x000D34DA
		internal static bool SessionContainsConventionParameters(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData sessionData)
		{
			return sessionData.EdmItemCollection != null;
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x000D52E5 File Offset: 0x000D34E5
		internal static global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader Create(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData sessionData)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAttributeAssemblyLoader.IsSchemaAttributePresent(assembly))
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.ObjectItemConventionAssemblyLoader(assembly, sessionData);
			}
			sessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_AttributeAssemblyReferenced(assembly.FullName)));
			return new global::System.Data.Entity.Core.Metadata.Edm.ObjectItemNoOpAssemblyLoader(assembly, sessionData);
		}

		// Token: 0x04001659 RID: 5721
		private readonly global::System.Collections.Generic.List<global::System.Action> _referenceResolutions = new global::System.Collections.Generic.List<global::System.Action>();

		// Token: 0x0400165A RID: 5722
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ObjectItemConventionAssemblyLoader.ConventionOSpaceTypeFactory _factory;

		// Token: 0x02000B1E RID: 2846
		internal class ConventionOSpaceTypeFactory : global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory
		{
			// Token: 0x060064B1 RID: 25777 RVA: 0x0015AEE8 File Offset: 0x001590E8
			public ConventionOSpaceTypeFactory(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemConventionAssemblyLoader loader)
			{
				this._loader = loader;
			}

			// Token: 0x170010F8 RID: 4344
			// (get) Token: 0x060064B2 RID: 25778 RVA: 0x0015AEF7 File Offset: 0x001590F7
			public override global::System.Collections.Generic.List<global::System.Action> ReferenceResolutions
			{
				get
				{
					return this._loader._referenceResolutions;
				}
			}

			// Token: 0x060064B3 RID: 25779 RVA: 0x0015AF04 File Offset: 0x00159104
			public override void LogLoadMessage(string message, global::System.Data.Entity.Core.Metadata.Edm.EdmType relatedType)
			{
				this._loader.SessionData.LoadMessageLogger.LogLoadMessage(message, relatedType);
			}

			// Token: 0x060064B4 RID: 25780 RVA: 0x0015AF20 File Offset: 0x00159120
			public override void LogError(string errorMessage, global::System.Data.Entity.Core.Metadata.Edm.EdmType relatedType)
			{
				string message = this._loader.SessionData.LoadMessageLogger.CreateErrorMessageWithTypeSpecificLoadLogs(errorMessage, relatedType);
				this._loader.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(message));
			}

			// Token: 0x060064B5 RID: 25781 RVA: 0x0015AF60 File Offset: 0x00159160
			public override void TrackClosure(global::System.Type type)
			{
				this._loader.TrackClosure(type);
			}

			// Token: 0x170010F9 RID: 4345
			// (get) Token: 0x060064B6 RID: 25782 RVA: 0x0015AF6E File Offset: 0x0015916E
			public override global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType> CspaceToOspace
			{
				get
				{
					return this._loader.SessionData.CspaceToOspace;
				}
			}

			// Token: 0x170010FA RID: 4346
			// (get) Token: 0x060064B7 RID: 25783 RVA: 0x0015AF80 File Offset: 0x00159180
			public override global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> LoadedTypes
			{
				get
				{
					return this._loader.SessionData.TypesInLoading;
				}
			}

			// Token: 0x060064B8 RID: 25784 RVA: 0x0015AF92 File Offset: 0x00159192
			public override void AddToTypesInAssembly(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
			{
				this._loader.CacheEntry.TypesInAssembly.Add(type);
			}

			// Token: 0x04002CE7 RID: 11495
			private readonly global::System.Data.Entity.Core.Metadata.Edm.ObjectItemConventionAssemblyLoader _loader;
		}
	}
}
