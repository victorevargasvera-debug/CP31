using System;
using Loupe.Extensibility.Client;

namespace Loupe.Extensibility
{
	// Token: 0x02000049 RID: 73
	internal interface IExtensionDefinition
	{
		// Token: 0x0600045F RID: 1119
		void Register(global::Loupe.Extensibility.Client.IGlobalContext context, global::Loupe.Extensibility.IExtensionDefinitionContext definitionContext);
	}
}
