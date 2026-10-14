using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200048D RID: 1165
	internal sealed class ClrEntityType : global::System.Data.Entity.Core.Metadata.Edm.EntityType
	{
		// Token: 0x060039DC RID: 14812 RVA: 0x000BD934 File Offset: 0x000BBB34
		internal ClrEntityType(global::System.Type type, string cspaceNamespaceName, string cspaceTypeName) : base(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type").Name, type.NestingNamespace() ?? string.Empty, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
		{
			this._type = type;
			this._cspaceNamespaceName = cspaceNamespaceName;
			this._cspaceTypeName = cspaceNamespaceName + "." + cspaceTypeName;
			base.Abstract = type.IsAbstract();
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x060039DD RID: 14813 RVA: 0x000BD993 File Offset: 0x000BBB93
		// (set) Token: 0x060039DE RID: 14814 RVA: 0x000BD99B File Offset: 0x000BBB9B
		internal global::System.Func<object> Constructor
		{
			get
			{
				return this._constructor;
			}
			set
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Func<object>>(ref this._constructor, value, null);
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x060039DF RID: 14815 RVA: 0x000BD9AB File Offset: 0x000BBBAB
		internal override global::System.Type ClrType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x000BD9B3 File Offset: 0x000BBBB3
		internal string CSpaceTypeName
		{
			get
			{
				return this._cspaceTypeName;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x060039E1 RID: 14817 RVA: 0x000BD9BB File Offset: 0x000BBBBB
		internal string CSpaceNamespaceName
		{
			get
			{
				return this._cspaceNamespaceName;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x000BD9C3 File Offset: 0x000BBBC3
		internal string HashedDescription
		{
			get
			{
				if (this._hash == null)
				{
					global::System.Threading.Interlocked.CompareExchange<string>(ref this._hash, this.BuildEntityTypeHash(), null);
				}
				return this._hash;
			}
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x000BD9E8 File Offset: 0x000BBBE8
		private string BuildEntityTypeHash()
		{
			string result;
			using (global::System.Security.Cryptography.SHA256 sha = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CreateSHA256HashAlgorithm())
			{
				byte[] array = sha.ComputeHash(global::System.Text.Encoding.ASCII.GetBytes(this.BuildEntityTypeDescription()));
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(array.Length * 2);
				foreach (byte b in array)
				{
					stringBuilder.Append(b.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x000BDA70 File Offset: 0x000BBC70
		private string BuildEntityTypeDescription()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(512);
			stringBuilder.Append("CLR:").Append(this.ClrType.FullName);
			stringBuilder.Append("Conceptual:").Append(this.CSpaceTypeName);
			global::System.Collections.Generic.SortedSet<string> sortedSet = new global::System.Collections.Generic.SortedSet<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty in base.NavigationProperties)
			{
				sortedSet.Add(string.Concat(new string[]
				{
					navigationProperty.Name,
					"*",
					navigationProperty.FromEndMember.Name,
					"*",
					navigationProperty.FromEndMember.RelationshipMultiplicity.ToString(),
					"*",
					navigationProperty.ToEndMember.Name,
					"*",
					navigationProperty.ToEndMember.RelationshipMultiplicity.ToString(),
					"*"
				}));
			}
			stringBuilder.Append("NavProps:");
			foreach (string value in sortedSet)
			{
				stringBuilder.Append(value);
			}
			global::System.Collections.Generic.SortedSet<string> sortedSet2 = new global::System.Collections.Generic.SortedSet<string>();
			foreach (string item in this.KeyMemberNames)
			{
				sortedSet2.Add(item);
			}
			stringBuilder.Append("Keys:");
			foreach (string str in sortedSet2)
			{
				stringBuilder.Append(str + "*");
			}
			global::System.Collections.Generic.SortedSet<string> sortedSet3 = new global::System.Collections.Generic.SortedSet<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in base.Members)
			{
				if (!sortedSet2.Contains(edmMember.Name))
				{
					sortedSet3.Add(edmMember.Name + "*");
				}
			}
			stringBuilder.Append("Scalars:");
			foreach (string str2 in sortedSet3)
			{
				stringBuilder.Append(str2 + "*");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0400134C RID: 4940
		private readonly global::System.Type _type;

		// Token: 0x0400134D RID: 4941
		private global::System.Func<object> _constructor;

		// Token: 0x0400134E RID: 4942
		private readonly string _cspaceTypeName;

		// Token: 0x0400134F RID: 4943
		private readonly string _cspaceNamespaceName;

		// Token: 0x04001350 RID: 4944
		private string _hash;
	}
}
