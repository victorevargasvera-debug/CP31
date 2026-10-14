using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005C3 RID: 1475
	internal class CompositeKey
	{
		// Token: 0x06004778 RID: 18296 RVA: 0x000FB8FE File Offset: 0x000F9AFE
		internal CompositeKey(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] constants)
		{
			this.KeyComponents = constants;
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x000FB90D File Offset: 0x000F9B0D
		internal static global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey> CreateComparer(global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager keyManager)
		{
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey.CompositeKeyComparer(keyManager);
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x000FB918 File Offset: 0x000F9B18
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey Merge(global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager keyManager, global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey other)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[this.KeyComponents.Length];
			for (int i = 0; i < this.KeyComponents.Length; i++)
			{
				array[i] = this.KeyComponents[i].Merge(keyManager, other.KeyComponents[i]);
			}
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey(array);
		}

		// Token: 0x0400195D RID: 6493
		internal readonly global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] KeyComponents;

		// Token: 0x02000BF2 RID: 3058
		private class CompositeKeyComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey>
		{
			// Token: 0x060068C3 RID: 26819 RVA: 0x001640C5 File Offset: 0x001622C5
			internal CompositeKeyComparer(global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager manager)
			{
				this._manager = manager;
			}

			// Token: 0x060068C4 RID: 26820 RVA: 0x001640D4 File Offset: 0x001622D4
			public bool Equals(global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey left, global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey right)
			{
				if (left == right)
				{
					return true;
				}
				if (left == null || right == null)
				{
					return false;
				}
				if (left.KeyComponents.Length != right.KeyComponents.Length)
				{
					return false;
				}
				for (int i = 0; i < left.KeyComponents.Length; i++)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = left.KeyComponents[i];
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2 = right.KeyComponents[i];
					if (propagatorResult.Identifier != -1)
					{
						if (propagatorResult2.Identifier == -1 || this._manager.GetCliqueIdentifier(propagatorResult.Identifier) != this._manager.GetCliqueIdentifier(propagatorResult2.Identifier))
						{
							return false;
						}
					}
					else if (propagatorResult2.Identifier != -1 || !global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(propagatorResult.GetSimpleValue(), propagatorResult2.GetSimpleValue()))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x060068C5 RID: 26821 RVA: 0x00164184 File Offset: 0x00162384
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey key)
			{
				int num = 0;
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult keyComponent in key.KeyComponents)
				{
					num = (num << 5 ^ this.GetComponentHashCode(keyComponent));
				}
				return num;
			}

			// Token: 0x060068C6 RID: 26822 RVA: 0x001641BC File Offset: 0x001623BC
			private int GetComponentHashCode(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult keyComponent)
			{
				if (keyComponent.Identifier == -1)
				{
					return global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.GetHashCode(keyComponent.GetSimpleValue());
				}
				return this._manager.GetCliqueIdentifier(keyComponent.Identifier).GetHashCode();
			}

			// Token: 0x04002F39 RID: 12089
			private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager _manager;
		}
	}
}
