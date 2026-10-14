using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation
{
	// Token: 0x0200020B RID: 523
	internal class IndependentConstraintConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration
	{
		// Token: 0x06001BAE RID: 7086 RVA: 0x0004B9D8 File Offset: 0x00049BD8
		private IndependentConstraintConfiguration()
		{
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x0004B9E0 File Offset: 0x00049BE0
		public static global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration Instance
		{
			get
			{
				return global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.IndependentConstraintConfiguration._instance;
			}
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0004B9E7 File Offset: 0x00049BE7
		internal override global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration Clone()
		{
			return global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.IndependentConstraintConfiguration._instance;
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0004B9EE File Offset: 0x00049BEE
		internal override void Configure(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentEnd, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration)
		{
			associationType.MarkIndependent();
		}

		// Token: 0x04000ACD RID: 2765
		private static readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration _instance = new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.IndependentConstraintConfiguration();
	}
}
