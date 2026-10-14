using System;
using System.Runtime.CompilerServices;

namespace Infragistics
{
	// Token: 0x020000CC RID: 204
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public abstract class BrushAppearanceData : global::Infragistics.IVisualData
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000884 RID: 2180
		public abstract string Type { get; }

		// Token: 0x06000885 RID: 2181 RVA: 0x0002795C File Offset: 0x00025B5C
		public string Serialize()
		{
			return string.Concat(new string[]
			{
				"{ type: \"",
				this.Type,
				"\", ",
				this.SerializeOverride(),
				" }"
			});
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000279A0 File Offset: 0x00025BA0
		protected virtual string SerializeOverride()
		{
			return "";
		}
	}
}
