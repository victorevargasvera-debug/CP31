using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping.ViewGeneration;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200052A RID: 1322
	internal struct InputForComputingCellGroups : global::System.IEquatable<global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups>, global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups>
	{
		// Token: 0x06004161 RID: 16737 RVA: 0x000DC5C3 File Offset: 0x000DA7C3
		internal InputForComputingCellGroups(global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			this.ContainerMapping = containerMapping;
			this.Config = config;
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x000DC5D3 File Offset: 0x000DA7D3
		public bool Equals(global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups other)
		{
			return this.ContainerMapping.Equals(other.ContainerMapping) && this.Config.Equals(other.Config);
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x000DC5FB File Offset: 0x000DA7FB
		public bool Equals(global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups one, global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups two)
		{
			return one == two || (one != null && two != null && one.Equals(two));
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x000DC627 File Offset: 0x000DA827
		public int GetHashCode(global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups value)
		{
			return value.GetHashCode();
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x000DC636 File Offset: 0x000DA836
		public override int GetHashCode()
		{
			return this.ContainerMapping.GetHashCode();
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x000DC643 File Offset: 0x000DA843
		public override bool Equals(object obj)
		{
			return obj is global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups && this.Equals((global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups)obj);
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x000DC65B File Offset: 0x000DA85B
		public static bool operator ==(global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups input1, global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups input2)
		{
			return input1 == input2 || input1.Equals(input2);
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x000DC675 File Offset: 0x000DA875
		public static bool operator !=(global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups input1, global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups input2)
		{
			return !(input1 == input2);
		}

		// Token: 0x040016A6 RID: 5798
		internal readonly global::System.Data.Entity.Core.Mapping.EntityContainerMapping ContainerMapping;

		// Token: 0x040016A7 RID: 5799
		internal readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator Config;
	}
}
