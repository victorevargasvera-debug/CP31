using System;

namespace NLog.Config
{
	// Token: 0x02000163 RID: 355
	public interface INamedItemFactory<TInstanceType, TDefinitionType> where TInstanceType : class
	{
		// Token: 0x06000F70 RID: 3952
		void RegisterDefinition(string itemName, TDefinitionType itemDefinition);

		// Token: 0x06000F71 RID: 3953
		bool TryGetDefinition(string itemName, out TDefinitionType result);

		// Token: 0x06000F72 RID: 3954
		TInstanceType CreateInstance(string itemName);

		// Token: 0x06000F73 RID: 3955
		bool TryCreateInstance(string itemName, out TInstanceType result);
	}
}
