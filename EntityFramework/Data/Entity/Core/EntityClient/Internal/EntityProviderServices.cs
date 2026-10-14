using System;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.EntityClient.Internal
{
	// Token: 0x020005E7 RID: 1511
	internal sealed class EntityProviderServices : global::System.Data.Entity.Core.Common.DbProviderServices
	{
		// Token: 0x060049F1 RID: 18929 RVA: 0x00105918 File Offset: 0x00103B18
		protected override global::System.Data.Entity.Core.Common.DbCommandDefinition CreateDbCommandDefinition(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.DbProviderManifest>(providerManifest, "providerManifest");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree>(commandTree, "commandTree");
			return this.CreateDbCommandDefinition(providerManifest, commandTree, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x0010593F File Offset: 0x00103B3F
		internal static global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition CreateCommandDefinition(global::System.Data.Common.DbProviderFactory storeProviderFactory, global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver = null)
		{
			return new global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition(storeProviderFactory, commandTree, interceptionContext, resolver, null, null);
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x0010594C File Offset: 0x00103B4C
		internal override global::System.Data.Entity.Core.Common.DbCommandDefinition CreateDbCommandDefinition(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			return global::System.Data.Entity.Core.EntityClient.Internal.EntityProviderServices.CreateCommandDefinition(((global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)commandTree.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)).ProviderFactory, commandTree, interceptionContext, null);
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x0010596C File Offset: 0x00103B6C
		internal override void ValidateDataSpace(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree)
		{
			if (commandTree.DataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.EntityClient_RequiresNonStoreCommandTree);
			}
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x00105982 File Offset: 0x00103B82
		public override global::System.Data.Entity.Core.Common.DbCommandDefinition CreateCommandDefinition(global::System.Data.Common.DbCommand prototype)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(prototype, "prototype");
			return ((global::System.Data.Entity.Core.EntityClient.EntityCommand)prototype).GetCommandDefinition();
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x0010599C File Offset: 0x00103B9C
		protected override string GetDbProviderManifestToken(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			if (connection.GetType() != typeof(global::System.Data.Entity.Core.EntityClient.EntityConnection))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Mapping_Provider_WrongConnectionType(typeof(global::System.Data.Entity.Core.EntityClient.EntityConnection)));
			}
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.Token;
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x001059EB File Offset: 0x00103BEB
		protected override global::System.Data.Entity.Core.Common.DbProviderManifest GetDbProviderManifest(string manifestToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(manifestToken, "manifestToken");
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest;
		}

		// Token: 0x04001A16 RID: 6678
		internal static readonly global::System.Data.Entity.Core.EntityClient.Internal.EntityProviderServices Instance = new global::System.Data.Entity.Core.EntityClient.Internal.EntityProviderServices();
	}
}
