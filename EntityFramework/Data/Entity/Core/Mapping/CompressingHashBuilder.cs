using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000525 RID: 1317
	internal class CompressingHashBuilder : global::System.Data.Entity.Core.Mapping.StringHashBuilder
	{
		// Token: 0x060040FF RID: 16639 RVA: 0x000DAB0C File Offset: 0x000D8D0C
		internal CompressingHashBuilder(global::System.Security.Cryptography.HashAlgorithm hashAlgorithm) : base(hashAlgorithm, 6144)
		{
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x000DAB1A File Offset: 0x000D8D1A
		internal override void Append(string content)
		{
			base.Append(string.Empty.PadLeft(4 * this._indent, ' '));
			base.Append(content);
			this.CompressHash();
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x000DAB43 File Offset: 0x000D8D43
		internal override void AppendLine(string content)
		{
			base.Append(string.Empty.PadLeft(4 * this._indent, ' '));
			base.AppendLine(content);
			this.CompressHash();
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x000DAB6C File Offset: 0x000D8D6C
		private static global::System.Collections.Generic.Dictionary<global::System.Type, string> InitializeLegacyTypeNames()
		{
			return new global::System.Collections.Generic.Dictionary<global::System.Type, string>
			{
				{
					typeof(global::System.Data.Entity.Core.Mapping.AssociationSetMapping),
					"System.Data.Entity.Core.Mapping.StorageAssociationSetMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping),
					"System.Data.Entity.Core.Mapping.StorageAssociationSetModificationFunctionMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.AssociationTypeMapping),
					"System.Data.Entity.Core.Mapping.StorageAssociationTypeMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping),
					"System.Data.Entity.Core.Mapping.StorageComplexPropertyMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.ComplexTypeMapping),
					"System.Data.Entity.Core.Mapping.StorageComplexTypeMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping),
					"System.Data.Entity.Core.Mapping.StorageConditionPropertyMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.EndPropertyMapping),
					"System.Data.Entity.Core.Mapping.StorageEndPropertyMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.EntityContainerMapping),
					"System.Data.Entity.Core.Mapping.StorageEntityContainerMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.EntitySetMapping),
					"System.Data.Entity.Core.Mapping.StorageEntitySetMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.EntityTypeMapping),
					"System.Data.Entity.Core.Mapping.StorageEntityTypeMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping),
					"System.Data.Entity.Core.Mapping.StorageEntityTypeModificationFunctionMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.MappingFragment),
					"System.Data.Entity.Core.Mapping.StorageMappingFragment"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping),
					"System.Data.Entity.Core.Mapping.StorageModificationFunctionMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath),
					"System.Data.Entity.Core.Mapping.StorageModificationFunctionMemberPath"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding),
					"System.Data.Entity.Core.Mapping.StorageModificationFunctionParameterBinding"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding),
					"System.Data.Entity.Core.Mapping.StorageModificationFunctionResultBinding"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.PropertyMapping),
					"System.Data.Entity.Core.Mapping.StoragePropertyMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping),
					"System.Data.Entity.Core.Mapping.StorageScalarPropertyMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping),
					"System.Data.Entity.Core.Mapping.StorageSetMapping"
				},
				{
					typeof(global::System.Data.Entity.Core.Mapping.TypeMapping),
					"System.Data.Entity.Core.Mapping.StorageTypeMapping"
				}
			};
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x000DAD24 File Offset: 0x000D8F24
		internal void AppendObjectStartDump(object o, int objectIndex)
		{
			base.Append(string.Empty.PadLeft(4 * this._indent, ' '));
			string s;
			if (!global::System.Data.Entity.Core.Mapping.CompressingHashBuilder._legacyTypeNames.TryGetValue(o.GetType(), out s))
			{
				s = o.GetType().ToString();
			}
			base.Append(s);
			base.Append(" Instance#");
			base.AppendLine(objectIndex.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			this.CompressHash();
			this._indent++;
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x000DADA3 File Offset: 0x000D8FA3
		internal void AppendObjectEndDump()
		{
			this._indent--;
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x000DADB4 File Offset: 0x000D8FB4
		private void CompressHash()
		{
			if (base.CharCount >= 2048)
			{
				string s = base.ComputeHash();
				base.Clear();
				base.Append(s);
			}
		}

		// Token: 0x0400168B RID: 5771
		private const int HashCharacterCompressionThreshold = 2048;

		// Token: 0x0400168C RID: 5772
		private const int SpacesPerIndent = 4;

		// Token: 0x0400168D RID: 5773
		private int _indent;

		// Token: 0x0400168E RID: 5774
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, string> _legacyTypeNames = global::System.Data.Entity.Core.Mapping.CompressingHashBuilder.InitializeLegacyTypeNames();
	}
}
