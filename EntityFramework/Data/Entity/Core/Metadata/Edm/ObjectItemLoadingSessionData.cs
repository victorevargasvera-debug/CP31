using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000516 RID: 1302
	internal class ObjectItemLoadingSessionData
	{
		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x0600402B RID: 16427 RVA: 0x000D5319 File Offset: 0x000D3519
		internal virtual global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> TypesInLoading
		{
			get
			{
				return this._typesInLoading;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600402C RID: 16428 RVA: 0x000D5321 File Offset: 0x000D3521
		internal global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry> AssembliesLoaded
		{
			get
			{
				return this._listOfAssembliesLoaded;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600402D RID: 16429 RVA: 0x000D5329 File Offset: 0x000D3529
		internal virtual global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> EdmItemErrors
		{
			get
			{
				return this._errors;
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600402E RID: 16430 RVA: 0x000D5331 File Offset: 0x000D3531
		internal global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet KnownAssemblies
		{
			get
			{
				return this._knownAssemblies;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x0600402F RID: 16431 RVA: 0x000D5339 File Offset: 0x000D3539
		internal global::System.Data.Entity.Core.Metadata.Edm.LockedAssemblyCache LockedAssemblyCache
		{
			get
			{
				return this._lockedAssemblyCache;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06004030 RID: 16432 RVA: 0x000D5341 File Offset: 0x000D3541
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection EdmItemCollection
		{
			get
			{
				return this._edmItemCollection;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06004031 RID: 16433 RVA: 0x000D5349 File Offset: 0x000D3549
		internal virtual global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType> CspaceToOspace
		{
			get
			{
				return this._cspaceToOspace;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06004032 RID: 16434 RVA: 0x000D5351 File Offset: 0x000D3551
		// (set) Token: 0x06004033 RID: 16435 RVA: 0x000D5359 File Offset: 0x000D3559
		internal bool ConventionBasedRelationshipsAreLoaded { get; set; }

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x000D5362 File Offset: 0x000D3562
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.LoadMessageLogger LoadMessageLogger
		{
			get
			{
				return this._loadMessageLogger;
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06004035 RID: 16437 RVA: 0x000D536C File Offset: 0x000D356C
		internal global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmType, int>> ConventionCSpaceTypeNames
		{
			get
			{
				if (this._edmItemCollection != null && this._conventionCSpaceTypeNames == null)
				{
					this._conventionCSpaceTypeNames = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmType, int>>();
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in this._edmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EdmType>())
					{
						if ((edmType is global::System.Data.Entity.Core.Metadata.Edm.StructuralType && edmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType))
						{
							global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmType, int> value;
							if (this._conventionCSpaceTypeNames.TryGetValue(edmType.Name, out value))
							{
								this._conventionCSpaceTypeNames[edmType.Name] = new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmType, int>(value.Key, value.Value + 1);
							}
							else
							{
								value = new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmType, int>(edmType, 1);
								this._conventionCSpaceTypeNames.Add(edmType.Name, value);
							}
						}
					}
				}
				return this._conventionCSpaceTypeNames;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06004036 RID: 16438 RVA: 0x000D5450 File Offset: 0x000D3650
		// (set) Token: 0x06004037 RID: 16439 RVA: 0x000D5458 File Offset: 0x000D3658
		internal global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader> ObjectItemAssemblyLoaderFactory
		{
			get
			{
				return this._loaderFactory;
			}
			set
			{
				if (this._loaderFactory != value)
				{
					this._loaderFactory = value;
				}
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x000D546F File Offset: 0x000D366F
		internal object LoaderCookie
		{
			get
			{
				if (this._originalLoaderCookie != null)
				{
					return this._originalLoaderCookie;
				}
				return this._loaderFactory;
			}
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x000D5486 File Offset: 0x000D3686
		internal ObjectItemLoadingSessionData()
		{
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x000D54B0 File Offset: 0x000D36B0
		internal ObjectItemLoadingSessionData(global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet knownAssemblies, global::System.Data.Entity.Core.Metadata.Edm.LockedAssemblyCache lockedAssemblyCache, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Action<string> logLoadMessage, object loaderCookie)
		{
			this._typesInLoading = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType>(global::System.StringComparer.Ordinal);
			this._errors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError>();
			this._knownAssemblies = knownAssemblies;
			this._lockedAssemblyCache = lockedAssemblyCache;
			this._edmItemCollection = edmItemCollection;
			this._loadMessageLogger = new global::System.Data.Entity.Core.Metadata.Edm.LoadMessageLogger(logLoadMessage);
			this._cspaceToOspace = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType>();
			this._loaderFactory = (global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>)loaderCookie;
			this._originalLoaderCookie = loaderCookie;
			if (this._loaderFactory == new global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemConventionAssemblyLoader.Create) && this._edmItemCollection != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry knownAssemblyEntry in this._knownAssemblies.GetEntries(this._loaderFactory, edmItemCollection))
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in knownAssemblyEntry.CacheEntry.TypesInAssembly.OfType<global::System.Data.Entity.Core.Metadata.Edm.EdmType>())
					{
						if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType))
						{
							global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType clrEntityType = (global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType)edmType;
							this._cspaceToOspace.Add(this._edmItemCollection.GetItem<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>(clrEntityType.CSpaceTypeName), clrEntityType);
						}
						else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmType))
						{
							global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType clrComplexType = (global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType)edmType;
							this._cspaceToOspace.Add(this._edmItemCollection.GetItem<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>(clrComplexType.CSpaceTypeName), clrComplexType);
						}
						else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType))
						{
							global::System.Data.Entity.Core.Metadata.Edm.ClrEnumType clrEnumType = (global::System.Data.Entity.Core.Metadata.Edm.ClrEnumType)edmType;
							this._cspaceToOspace.Add(this._edmItemCollection.GetItem<global::System.Data.Entity.Core.Metadata.Edm.EnumType>(clrEnumType.CSpaceTypeName), clrEnumType);
						}
						else
						{
							this._cspaceToOspace.Add(this._edmItemCollection.GetItem<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>(edmType.FullName), edmType);
						}
					}
				}
			}
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x000D56A4 File Offset: 0x000D38A4
		internal void RegisterForLevel1PostSessionProcessing(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader loader)
		{
			this._loadersThatNeedLevel1PostSessionProcessing.Add(loader);
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x000D56B3 File Offset: 0x000D38B3
		internal void RegisterForLevel2PostSessionProcessing(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader loader)
		{
			this._loadersThatNeedLevel2PostSessionProcessing.Add(loader);
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x000D56C4 File Offset: 0x000D38C4
		internal void CompleteSession()
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader objectItemAssemblyLoader in this._loadersThatNeedLevel1PostSessionProcessing)
			{
				objectItemAssemblyLoader.OnLevel1SessionProcessing();
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader objectItemAssemblyLoader2 in this._loadersThatNeedLevel2PostSessionProcessing)
			{
				objectItemAssemblyLoader2.OnLevel2SessionProcessing();
			}
		}

		// Token: 0x0400165B RID: 5723
		private global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader> _loaderFactory;

		// Token: 0x0400165C RID: 5724
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> _typesInLoading;

		// Token: 0x0400165D RID: 5725
		private readonly global::System.Data.Entity.Core.Metadata.Edm.LoadMessageLogger _loadMessageLogger;

		// Token: 0x0400165E RID: 5726
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> _errors;

		// Token: 0x0400165F RID: 5727
		private readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry> _listOfAssembliesLoaded = new global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry>();

		// Token: 0x04001660 RID: 5728
		private readonly global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet _knownAssemblies;

		// Token: 0x04001661 RID: 5729
		private readonly global::System.Data.Entity.Core.Metadata.Edm.LockedAssemblyCache _lockedAssemblyCache;

		// Token: 0x04001662 RID: 5730
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader> _loadersThatNeedLevel1PostSessionProcessing = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>();

		// Token: 0x04001663 RID: 5731
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader> _loadersThatNeedLevel2PostSessionProcessing = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>();

		// Token: 0x04001664 RID: 5732
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection _edmItemCollection;

		// Token: 0x04001665 RID: 5733
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmType, int>> _conventionCSpaceTypeNames;

		// Token: 0x04001666 RID: 5734
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType> _cspaceToOspace;

		// Token: 0x04001667 RID: 5735
		private readonly object _originalLoaderCookie;
	}
}
