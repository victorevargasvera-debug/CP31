using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003B3 RID: 947
	internal class KeyVec
	{
		// Token: 0x06002D9F RID: 11679 RVA: 0x00091170 File Offset: 0x0008F370
		internal KeyVec(global::System.Data.Entity.Core.Query.InternalTrees.Command itree)
		{
			this.m_keys = itree.CreateVarVec();
			this.m_noKeys = true;
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x0009118B File Offset: 0x0008F38B
		internal void InitFrom(global::System.Data.Entity.Core.Query.InternalTrees.KeyVec keyset)
		{
			this.m_keys.InitFrom(keyset.m_keys);
			this.m_noKeys = keyset.m_noKeys;
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000911AA File Offset: 0x0008F3AA
		internal void InitFrom(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> varSet)
		{
			this.InitFrom(varSet, false);
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000911B4 File Offset: 0x0008F3B4
		internal void InitFrom(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> varSet, bool ignoreParameters)
		{
			this.m_keys.InitFrom(varSet, ignoreParameters);
			this.m_noKeys = false;
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000911CC File Offset: 0x0008F3CC
		internal void InitFrom(global::System.Data.Entity.Core.Query.InternalTrees.KeyVec left, global::System.Data.Entity.Core.Query.InternalTrees.KeyVec right)
		{
			if (left.m_noKeys || right.m_noKeys)
			{
				this.m_noKeys = true;
				return;
			}
			this.m_noKeys = false;
			this.m_keys.InitFrom(left.m_keys);
			this.m_keys.Or(right.m_keys);
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x0009121C File Offset: 0x0008F41C
		internal void InitFrom(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.KeyVec> keyVecList)
		{
			this.m_noKeys = false;
			this.m_keys.Clear();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.KeyVec keyVec in keyVecList)
			{
				if (keyVec.m_noKeys)
				{
					this.m_noKeys = true;
					break;
				}
				this.m_keys.Or(keyVec.m_keys);
			}
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00091298 File Offset: 0x0008F498
		internal void Clear()
		{
			this.m_noKeys = true;
			this.m_keys.Clear();
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x000912AC File Offset: 0x0008F4AC
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec KeyVars
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002DA7 RID: 11687 RVA: 0x000912B4 File Offset: 0x0008F4B4
		// (set) Token: 0x06002DA8 RID: 11688 RVA: 0x000912BC File Offset: 0x0008F4BC
		internal bool NoKeys
		{
			get
			{
				return this.m_noKeys;
			}
			set
			{
				this.m_noKeys = value;
			}
		}

		// Token: 0x04000F43 RID: 3907
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_keys;

		// Token: 0x04000F44 RID: 3908
		private bool m_noKeys;
	}
}
