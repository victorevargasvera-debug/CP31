using System;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Internal;
using System.Data.Entity.ModelConfiguration.Edm.Serialization;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Xml;
using System.Xml.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000241 RID: 577
	public static class EdmxWriter
	{
		// Token: 0x06001E40 RID: 7744 RVA: 0x000536E8 File Offset: 0x000518E8
		public static void WriteEdmx(global::System.Data.Entity.DbContext context, global::System.Xml.XmlWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Xml.XmlWriter>(writer, "writer");
			global::System.Data.Entity.Internal.InternalContext internalContext = context.InternalContext;
			if (internalContext is global::System.Data.Entity.Internal.EagerInternalContext)
			{
				throw global::System.Data.Entity.Resources.Error.EdmxWriter_EdmxFromObjectContextNotSupported();
			}
			global::System.Data.Entity.Infrastructure.DbModel modelBeingInitialized = internalContext.ModelBeingInitialized;
			if (modelBeingInitialized != null)
			{
				global::System.Data.Entity.Infrastructure.EdmxWriter.WriteEdmx(modelBeingInitialized, writer);
				return;
			}
			global::System.Data.Entity.Infrastructure.DbCompiledModel codeFirstModel = internalContext.CodeFirstModel;
			if (codeFirstModel == null)
			{
				throw global::System.Data.Entity.Resources.Error.EdmxWriter_EdmxFromModelFirstNotSupported();
			}
			global::System.Data.Entity.Infrastructure.DbModelStore service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.DbModelStore>();
			if (service != null)
			{
				global::System.Xml.Linq.XDocument xdocument = service.TryGetEdmx(context.GetType());
				if (xdocument != null)
				{
					xdocument.WriteTo(writer);
					return;
				}
			}
			global::System.Data.Entity.DbModelBuilder cachedModelBuilder = codeFirstModel.CachedModelBuilder;
			if (cachedModelBuilder == null)
			{
				throw global::System.Data.Entity.Resources.Error.EdmxWriter_EdmxFromRawCompiledModelNotSupported();
			}
			global::System.Data.Entity.DbModelBuilder dbModelBuilder = cachedModelBuilder.Clone();
			global::System.Data.Entity.Infrastructure.EdmxWriter.WriteEdmx((internalContext.ModelProviderInfo == null) ? dbModelBuilder.Build(internalContext.Connection) : dbModelBuilder.Build(internalContext.ModelProviderInfo), writer);
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x000537AD File Offset: 0x000519AD
		public static void WriteEdmx(global::System.Data.Entity.Infrastructure.DbModel model, global::System.Xml.XmlWriter writer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Xml.XmlWriter>(writer, "writer");
			new global::System.Data.Entity.ModelConfiguration.Edm.Serialization.EdmxSerializer().Serialize(model.DatabaseMapping, writer);
		}
	}
}
