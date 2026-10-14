using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.EntityClient
{
	// Token: 0x020005DE RID: 1502
	public sealed class EntityConnectionStringBuilder : global::System.Data.Common.DbConnectionStringBuilder
	{
		// Token: 0x06004934 RID: 18740 RVA: 0x00103746 File Offset: 0x00101946
		public EntityConnectionStringBuilder()
		{
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x0010374E File Offset: 0x0010194E
		public EntityConnectionStringBuilder(string connectionString)
		{
			base.ConnectionString = connectionString;
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06004936 RID: 18742 RVA: 0x0010375D File Offset: 0x0010195D
		// (set) Token: 0x06004937 RID: 18743 RVA: 0x0010376E File Offset: 0x0010196E
		[global::System.ComponentModel.DisplayName("Name")]
		[global::System.Data.Entity.Core.EntityResCategory("EntityDataCategory_NamedConnectionString")]
		[global::System.Data.Entity.Core.EntityResDescription("EntityConnectionString_Name")]
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		public string Name
		{
			get
			{
				return this._namedConnectionName ?? "";
			}
			set
			{
				this._namedConnectionName = value;
				base["name"] = value;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06004938 RID: 18744 RVA: 0x00103783 File Offset: 0x00101983
		// (set) Token: 0x06004939 RID: 18745 RVA: 0x00103794 File Offset: 0x00101994
		[global::System.ComponentModel.DisplayName("Provider")]
		[global::System.Data.Entity.Core.EntityResCategory("EntityDataCategory_Source")]
		[global::System.Data.Entity.Core.EntityResDescription("EntityConnectionString_Provider")]
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		public string Provider
		{
			get
			{
				return this._providerName ?? "";
			}
			set
			{
				this._providerName = value;
				base["provider"] = value;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x0600493A RID: 18746 RVA: 0x001037A9 File Offset: 0x001019A9
		// (set) Token: 0x0600493B RID: 18747 RVA: 0x001037BA File Offset: 0x001019BA
		[global::System.ComponentModel.DisplayName("Metadata")]
		[global::System.Data.Entity.Core.EntityResCategory("EntityDataCategory_Context")]
		[global::System.Data.Entity.Core.EntityResDescription("EntityConnectionString_Metadata")]
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		public string Metadata
		{
			get
			{
				return this._metadataLocations ?? "";
			}
			set
			{
				this._metadataLocations = value;
				base["metadata"] = value;
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x0600493C RID: 18748 RVA: 0x001037CF File Offset: 0x001019CF
		// (set) Token: 0x0600493D RID: 18749 RVA: 0x001037E0 File Offset: 0x001019E0
		[global::System.ComponentModel.DisplayName("Provider Connection String")]
		[global::System.Data.Entity.Core.EntityResCategory("EntityDataCategory_Source")]
		[global::System.Data.Entity.Core.EntityResDescription("EntityConnectionString_ProviderConnectionString")]
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		public string ProviderConnectionString
		{
			get
			{
				return this._storeProviderConnectionString ?? "";
			}
			set
			{
				this._storeProviderConnectionString = value;
				base["provider connection string"] = value;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x0600493E RID: 18750 RVA: 0x001037F5 File Offset: 0x001019F5
		public override bool IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x0600493F RID: 18751 RVA: 0x001037F8 File Offset: 0x001019F8
		public override global::System.Collections.ICollection Keys
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<string>(global::System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder.ValidKeywords);
			}
		}

		// Token: 0x17000E73 RID: 3699
		public override object this[string keyword]
		{
			get
			{
				global::System.Data.Entity.Utilities.Check.NotNull<string>(keyword, "keyword");
				if (string.Compare(keyword, "metadata", global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					return this.Metadata;
				}
				if (string.Compare(keyword, "provider connection string", global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					return this.ProviderConnectionString;
				}
				if (string.Compare(keyword, "name", global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					return this.Name;
				}
				if (string.Compare(keyword, "provider", global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					return this.Provider;
				}
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_KeywordNotSupported(keyword));
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<string>(keyword, "keyword");
				if (value == null)
				{
					this.Remove(keyword);
					return;
				}
				string text = value as string;
				if (text == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_ValueNotString, "value");
				}
				if (string.Compare(keyword, "metadata", global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					this.Metadata = text;
					return;
				}
				if (string.Compare(keyword, "provider connection string", global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					this.ProviderConnectionString = text;
					return;
				}
				if (string.Compare(keyword, "name", global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					this.Name = text;
					return;
				}
				if (string.Compare(keyword, "provider", global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					this.Provider = text;
					return;
				}
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_KeywordNotSupported(keyword));
			}
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x0010391E File Offset: 0x00101B1E
		public override void Clear()
		{
			base.Clear();
			this._namedConnectionName = null;
			this._providerName = null;
			this._metadataLocations = null;
			this._storeProviderConnectionString = null;
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x00103944 File Offset: 0x00101B44
		public override bool ContainsKey(string keyword)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(keyword, "keyword");
			string[] validKeywords = global::System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder.ValidKeywords;
			for (int i = 0; i < validKeywords.Length; i++)
			{
				if (validKeywords[i].Equals(keyword, global::System.StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x00103980 File Offset: 0x00101B80
		public override bool TryGetValue(string keyword, out object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(keyword, "keyword");
			if (this.ContainsKey(keyword))
			{
				value = this[keyword];
				return true;
			}
			value = null;
			return false;
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x001039A8 File Offset: 0x00101BA8
		public override bool Remove(string keyword)
		{
			if (string.Compare(keyword, "metadata", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				this._metadataLocations = null;
			}
			else if (string.Compare(keyword, "provider connection string", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				this._storeProviderConnectionString = null;
			}
			else if (string.Compare(keyword, "name", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				this._namedConnectionName = null;
			}
			else if (string.Compare(keyword, "provider", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				this._providerName = null;
			}
			return base.Remove(keyword);
		}

		// Token: 0x040019E6 RID: 6630
		internal const string NameParameterName = "name";

		// Token: 0x040019E7 RID: 6631
		internal const string MetadataParameterName = "metadata";

		// Token: 0x040019E8 RID: 6632
		internal const string ProviderParameterName = "provider";

		// Token: 0x040019E9 RID: 6633
		internal const string ProviderConnectionStringParameterName = "provider connection string";

		// Token: 0x040019EA RID: 6634
		internal static readonly string[] ValidKeywords = new string[]
		{
			"name",
			"metadata",
			"provider",
			"provider connection string"
		};

		// Token: 0x040019EB RID: 6635
		private string _namedConnectionName;

		// Token: 0x040019EC RID: 6636
		private string _providerName;

		// Token: 0x040019ED RID: 6637
		private string _metadataLocations;

		// Token: 0x040019EE RID: 6638
		private string _storeProviderConnectionString;
	}
}
