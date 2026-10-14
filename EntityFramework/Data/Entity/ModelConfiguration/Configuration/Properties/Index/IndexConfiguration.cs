using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Index
{
	// Token: 0x0200020D RID: 525
	internal class IndexConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration
	{
		// Token: 0x06001BD0 RID: 7120 RVA: 0x0004C324 File Offset: 0x0004A524
		public IndexConfiguration()
		{
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0004C32C File Offset: 0x0004A52C
		internal IndexConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration source)
		{
			this._isUnique = source._isUnique;
			this._isClustered = source._isClustered;
			this._name = source._name;
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x0004C358 File Offset: 0x0004A558
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x0004C360 File Offset: 0x0004A560
		public bool? IsUnique
		{
			get
			{
				return this._isUnique;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<bool>(value, "value");
				this._isUnique = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x0004C375 File Offset: 0x0004A575
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x0004C37D File Offset: 0x0004A57D
		public bool? IsClustered
		{
			get
			{
				return this._isClustered;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<bool>(value, "value");
				this._isClustered = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x0004C392 File Offset: 0x0004A592
		// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x0004C39A File Offset: 0x0004A59A
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<string>(value, "value");
				this._name = value;
			}
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0004C3AF File Offset: 0x0004A5AF
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration(this);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0004C3B7 File Offset: 0x0004A5B7
		internal void Configure(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty, int indexOrder)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration.AddAnnotationWithMerge(edmProperty, new global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation(new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute(this._name, indexOrder, this._isClustered, this._isUnique)));
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0004C3DC File Offset: 0x0004A5DC
		internal void Configure(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration.AddAnnotationWithMerge(entityType, new global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation(new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute(this._name, this._isClustered, this._isUnique)));
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0004C400 File Offset: 0x0004A600
		private static void AddAnnotationWithMerge(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem metadataItem, global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation newAnnotation)
		{
			object annotation = metadataItem.Annotations.GetAnnotation("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:Index");
			if (annotation != null)
			{
				newAnnotation = (global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation)((global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation)annotation).MergeWith(newAnnotation);
			}
			metadataItem.AddAnnotation("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:Index", newAnnotation);
		}

		// Token: 0x04000AD7 RID: 2775
		private bool? _isUnique;

		// Token: 0x04000AD8 RID: 2776
		private bool? _isClustered;

		// Token: 0x04000AD9 RID: 2777
		private string _name;
	}
}
