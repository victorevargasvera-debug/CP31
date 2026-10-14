using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.Utilities;
using System.Linq;
using System.Text;
using System.Xml;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x0200000F RID: 15
	internal class SqlProviderManifest : global::System.Data.Entity.Core.Common.DbXmlEnabledProviderManifest
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x00003B28 File Offset: 0x00001D28
		public SqlProviderManifest(string manifestToken) : base(global::System.Data.Entity.SqlServer.SqlProviderManifest.GetProviderManifest())
		{
			this._version = global::System.Data.Entity.SqlServer.SqlVersionUtils.GetSqlVersion(manifestToken);
			this.Initialize();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003B50 File Offset: 0x00001D50
		private void Initialize()
		{
			if (this._version == global::System.Data.Entity.SqlServer.SqlVersion.Sql10 || this._version == global::System.Data.Entity.SqlServer.SqlVersion.Sql11)
			{
				this._primitiveTypes = base.GetStoreTypes();
				this._functions = base.GetStoreFunctions();
				return;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(base.GetStoreTypes());
			list.RemoveAll((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType) => primitiveType.Name.Equals("time", global::System.StringComparison.OrdinalIgnoreCase) || primitiveType.Name.Equals("date", global::System.StringComparison.OrdinalIgnoreCase) || primitiveType.Name.Equals("datetime2", global::System.StringComparison.OrdinalIgnoreCase) || primitiveType.Name.Equals("datetimeoffset", global::System.StringComparison.OrdinalIgnoreCase) || primitiveType.Name.Equals("hierarchyid", global::System.StringComparison.OrdinalIgnoreCase) || primitiveType.Name.Equals("geography", global::System.StringComparison.OrdinalIgnoreCase) || primitiveType.Name.Equals("geometry", global::System.StringComparison.OrdinalIgnoreCase));
			if (this._version == global::System.Data.Entity.SqlServer.SqlVersion.Sql8)
			{
				list.RemoveAll((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType) => primitiveType.Name.Equals("xml", global::System.StringComparison.OrdinalIgnoreCase) || primitiveType.Name.EndsWith("(max)", global::System.StringComparison.OrdinalIgnoreCase));
			}
			this._primitiveTypes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(list);
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> source = from f in base.GetStoreFunctions()
			where !global::System.Data.Entity.SqlServer.SqlProviderManifest.IsKatmaiOrNewer(f)
			select f;
			if (this._version == global::System.Data.Entity.SqlServer.SqlVersion.Sql8)
			{
				source = from f in source
				where !global::System.Data.Entity.SqlServer.SqlProviderManifest.IsYukonOrNewer(f)
				select f;
			}
			this._functions = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(source.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>());
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00003C64 File Offset: 0x00001E64
		internal global::System.Data.Entity.SqlServer.SqlVersion SqlVersion
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003C6C File Offset: 0x00001E6C
		private static global::System.Xml.XmlReader GetXmlResource(string resourceName)
		{
			return global::System.Xml.XmlReader.Create(typeof(global::System.Data.Entity.SqlServer.SqlProviderManifest).Assembly().GetManifestResourceStream(resourceName));
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003C88 File Offset: 0x00001E88
		internal static global::System.Xml.XmlReader GetProviderManifest()
		{
			return global::System.Data.Entity.SqlServer.SqlProviderManifest.GetXmlResource("System.Data.Resources.SqlClient.SqlProviderServices.ProviderManifest.xml");
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003C94 File Offset: 0x00001E94
		internal static global::System.Xml.XmlReader GetStoreSchemaMapping(string mslName)
		{
			return global::System.Data.Entity.SqlServer.SqlProviderManifest.GetXmlResource("System.Data.Resources.SqlClient.SqlProviderServices." + mslName + ".msl");
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003CAB File Offset: 0x00001EAB
		internal global::System.Xml.XmlReader GetStoreSchemaDescription(string ssdlName)
		{
			if (this._version == global::System.Data.Entity.SqlServer.SqlVersion.Sql8)
			{
				return global::System.Data.Entity.SqlServer.SqlProviderManifest.GetXmlResource("System.Data.Resources.SqlClient.SqlProviderServices." + ssdlName + "_Sql8.ssdl");
			}
			return global::System.Data.Entity.SqlServer.SqlProviderManifest.GetXmlResource("System.Data.Resources.SqlClient.SqlProviderServices." + ssdlName + ".ssdl");
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003CE4 File Offset: 0x00001EE4
		internal static string EscapeLikeText(string text, bool alwaysEscapeEscapeChar, out bool usedEscapeChar)
		{
			usedEscapeChar = false;
			if (!text.Contains("%") && !text.Contains("_") && !text.Contains("[") && !text.Contains("^") && (!alwaysEscapeEscapeChar || !text.Contains("~")))
			{
				return text;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(text.Length);
			foreach (char c in text)
			{
				if (c == '%' || c == '_' || c == '[' || c == '^' || c == '~')
				{
					stringBuilder.Append('~');
					usedEscapeChar = true;
				}
				stringBuilder.Append(c);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003D94 File Offset: 0x00001F94
		protected override global::System.Xml.XmlReader GetDbInformation(string informationType)
		{
			if (informationType == "StoreSchemaDefinitionVersion3" || informationType == "StoreSchemaDefinition")
			{
				return this.GetStoreSchemaDescription(informationType);
			}
			if (informationType == "StoreSchemaMappingVersion3" || informationType == "StoreSchemaMapping")
			{
				return global::System.Data.Entity.SqlServer.SqlProviderManifest.GetStoreSchemaMapping(informationType);
			}
			if (informationType == "ConceptualSchemaDefinitionVersion3" || informationType == "ConceptualSchemaDefinition")
			{
				return null;
			}
			throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.SqlServer.Resources.Strings.ProviderReturnedNullForGetDbInformation(informationType));
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003E0B File Offset: 0x0000200B
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetStoreTypes()
		{
			return this._primitiveTypes;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00003E13 File Offset: 0x00002013
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> GetStoreFunctions()
		{
			return this._functions;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003E1C File Offset: 0x0000201C
		private static bool IsKatmaiOrNewer(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction)
		{
			if (edmFunction.ReturnParameter == null || !edmFunction.ReturnParameter.TypeUsage.IsSpatialType())
			{
				if (!edmFunction.Parameters.Any((global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter p) => p.TypeUsage.IsSpatialType()))
				{
					global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> parameters = edmFunction.Parameters;
					string text = edmFunction.Name.ToUpperInvariant();
					if (text != null)
					{
						uint num = global::<PrivateImplementationDetails>.ComputeStringHash(text);
						if (num > 1900062112U)
						{
							if (num <= 2897371749U)
							{
								if (num <= 2725144690U)
								{
									if (num != 2585027932U)
									{
										if (num != 2725144690U)
										{
											return false;
										}
										if (!(text == "DATENAME"))
										{
											return false;
										}
									}
									else
									{
										if (!(text == "YEAR"))
										{
											return false;
										}
										goto IL_305;
									}
								}
								else if (num != 2750919380U)
								{
									if (num != 2897371749U)
									{
										return false;
									}
									if (!(text == "COUNT_BIG"))
									{
										return false;
									}
									goto IL_2C2;
								}
								else
								{
									if (!(text == "COUNT"))
									{
										return false;
									}
									goto IL_2C2;
								}
							}
							else if (num <= 3457630659U)
							{
								if (num != 3224348880U)
								{
									if (num != 3457630659U)
									{
										return false;
									}
									if (!(text == "SYSDATETIME"))
									{
										return false;
									}
									return true;
								}
								else if (!(text == "DATEPART"))
								{
									return false;
								}
							}
							else if (num != 3865452901U)
							{
								if (num != 4246149173U)
								{
									return false;
								}
								if (!(text == "DATALENGTH"))
								{
									return false;
								}
								goto IL_305;
							}
							else
							{
								if (!(text == "MONTH"))
								{
									return false;
								}
								goto IL_305;
							}
							string name = parameters[1].TypeUsage.EdmType.Name;
							return name.Equals("DateTimeOffset", global::System.StringComparison.OrdinalIgnoreCase) || name.Equals("Time", global::System.StringComparison.OrdinalIgnoreCase);
						}
						if (num <= 688247133U)
						{
							if (num <= 437886384U)
							{
								if (num != 239465655U)
								{
									if (num != 437886384U)
									{
										return false;
									}
									if (!(text == "SYSDATETIMEOFFSET"))
									{
										return false;
									}
									return true;
								}
								else if (!(text == "MIN"))
								{
									return false;
								}
							}
							else if (num != 475632249U)
							{
								if (num != 688247133U)
								{
									return false;
								}
								if (!(text == "DAY"))
								{
									return false;
								}
								goto IL_305;
							}
							else if (!(text == "MAX"))
							{
								return false;
							}
						}
						else
						{
							if (num > 999103698U)
							{
								if (num != 1674423462U)
								{
									if (num != 1900062112U)
									{
										return false;
									}
									if (!(text == "DATEADD"))
									{
										return false;
									}
								}
								else if (!(text == "DATEDIFF"))
								{
									return false;
								}
								string name2 = parameters[1].TypeUsage.EdmType.Name;
								string name3 = parameters[2].TypeUsage.EdmType.Name;
								return name2.Equals("Time", global::System.StringComparison.OrdinalIgnoreCase) || name3.Equals("Time", global::System.StringComparison.OrdinalIgnoreCase) || name2.Equals("DateTimeOffset", global::System.StringComparison.OrdinalIgnoreCase) || name3.Equals("DateTimeOffset", global::System.StringComparison.OrdinalIgnoreCase);
							}
							if (num != 719394705U)
							{
								if (num != 999103698U)
								{
									return false;
								}
								if (!(text == "CHECKSUM"))
								{
									return false;
								}
								goto IL_305;
							}
							else
							{
								if (!(text == "SYSUTCDATETIME"))
								{
									return false;
								}
								return true;
							}
						}
						IL_2C2:
						string name4 = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)parameters[0].TypeUsage.EdmType).TypeUsage.EdmType.Name;
						return name4.Equals("DateTimeOffset", global::System.StringComparison.OrdinalIgnoreCase) || name4.Equals("Time", global::System.StringComparison.OrdinalIgnoreCase);
						IL_305:
						string name5 = parameters[0].TypeUsage.EdmType.Name;
						return name5.Equals("DateTimeOffset", global::System.StringComparison.OrdinalIgnoreCase) || name5.Equals("Time", global::System.StringComparison.OrdinalIgnoreCase);
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000420C File Offset: 0x0000240C
		private static bool IsYukonOrNewer(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> parameters = edmFunction.Parameters;
			if (parameters == null || parameters.Count == 0)
			{
				return false;
			}
			string text = edmFunction.Name.ToUpperInvariant();
			if (text != null)
			{
				if (text == "COUNT" || text == "COUNT_BIG")
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)parameters[0].TypeUsage.EdmType).TypeUsage.EdmType.Name.Equals("Guid", global::System.StringComparison.OrdinalIgnoreCase);
				}
				if (text == "CHARINDEX")
				{
					using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>.Enumerator enumerator = parameters.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.TypeUsage.EdmType.Name.Equals("Int64", global::System.StringComparison.OrdinalIgnoreCase))
							{
								return true;
							}
						}
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000042F8 File Offset: 0x000024F8
		public override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetEdmType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(storeType, "storeType");
			string text = storeType.EdmType.Name.ToLowerInvariant();
			if (!base.StoreTypeNameToEdmPrimitiveType.ContainsKey(text))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.ProviderDoesNotSupportType(text));
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = base.StoreTypeNameToEdmPrimitiveType[text];
			int maxLength = 0;
			bool isUnicode = true;
			if (text != null)
			{
				uint num = global::<PrivateImplementationDetails>.ComputeStringHash(text);
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
				bool flag;
				bool isFixedLength;
				if (num > 2746163861U)
				{
					if (num <= 3437915536U)
					{
						if (num <= 3008443898U)
						{
							if (num <= 2823553821U)
							{
								if (num != 2797886853U)
								{
									if (num != 2823553821U)
									{
										goto IL_737;
									}
									if (!(text == "char"))
									{
										goto IL_737;
									}
									primitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String;
									flag = !storeType.TryGetMaxLength(out maxLength);
									isUnicode = false;
									isFixedLength = true;
									goto IL_743;
								}
								else if (!(text == "float"))
								{
									goto IL_737;
								}
							}
							else if (num != 2994984227U)
							{
								if (num != 3008443898U)
								{
									goto IL_737;
								}
								if (!(text == "image"))
								{
									goto IL_737;
								}
								goto IL_6A5;
							}
							else
							{
								if (!(text == "timestamp"))
								{
									goto IL_737;
								}
								goto IL_6B3;
							}
						}
						else if (num <= 3286697625U)
						{
							if (num != 3185987134U)
							{
								if (num != 3286697625U)
								{
									goto IL_737;
								}
								if (!(text == "geography"))
								{
									goto IL_737;
								}
								goto IL_5E0;
							}
							else
							{
								if (!(text == "text"))
								{
									goto IL_737;
								}
								goto IL_653;
							}
						}
						else if (num != 3347933383U)
						{
							if (num != 3431564149U)
							{
								if (num != 3437915536U)
								{
									goto IL_737;
								}
								if (!(text == "datetime"))
								{
									goto IL_737;
								}
								goto IL_6FD;
							}
							else
							{
								if (!(text == "uniqueidentifier"))
								{
									goto IL_737;
								}
								goto IL_5E0;
							}
						}
						else
						{
							if (!(text == "varbinary"))
							{
								goto IL_737;
							}
							primitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary;
							flag = !storeType.TryGetMaxLength(out maxLength);
							isFixedLength = false;
							goto IL_743;
						}
					}
					else if (num <= 3664801462U)
					{
						if (num <= 3604983901U)
						{
							if (num != 3564297305U)
							{
								if (num != 3604983901U)
								{
									goto IL_737;
								}
								if (!(text == "real"))
								{
									goto IL_737;
								}
							}
							else
							{
								if (!(text == "date"))
								{
									goto IL_737;
								}
								return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(primitiveType);
							}
						}
						else if (num != 3659634113U)
						{
							if (num != 3664801462U)
							{
								goto IL_737;
							}
							if (!(text == "xml"))
							{
								goto IL_737;
							}
							goto IL_664;
						}
						else
						{
							if (!(text == "smalldatetime"))
							{
								goto IL_737;
							}
							goto IL_6FD;
						}
					}
					else if (num <= 3761451113U)
					{
						if (num != 3716508924U)
						{
							if (num != 3761451113U)
							{
								goto IL_737;
							}
							if (!(text == "nchar"))
							{
								goto IL_737;
							}
							primitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String;
							flag = !storeType.TryGetMaxLength(out maxLength);
							isUnicode = true;
							isFixedLength = true;
							goto IL_743;
						}
						else
						{
							if (!(text == "binary"))
							{
								goto IL_737;
							}
							primitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary;
							flag = !storeType.TryGetMaxLength(out maxLength);
							isFixedLength = true;
							goto IL_743;
						}
					}
					else if (num != 3780168015U)
					{
						if (num != 3918255874U)
						{
							if (num != 4163743794U)
							{
								goto IL_737;
							}
							if (!(text == "varchar"))
							{
								goto IL_737;
							}
							primitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String;
							flag = !storeType.TryGetMaxLength(out maxLength);
							isUnicode = false;
							isFixedLength = false;
							goto IL_743;
						}
						else
						{
							if (!(text == "ntext"))
							{
								goto IL_737;
							}
							goto IL_664;
						}
					}
					else
					{
						if (!(text == "money"))
						{
							goto IL_737;
						}
						return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDecimalTypeUsage(primitiveType, 19, 4);
					}
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(primitiveType);
				}
				if (num <= 1564253156U)
				{
					if (num <= 750634308U)
					{
						if (num <= 520654156U)
						{
							if (num != 132678327U)
							{
								if (num != 520654156U)
								{
									goto IL_737;
								}
								if (!(text == "decimal"))
								{
									goto IL_737;
								}
							}
							else
							{
								if (!(text == "nvarchar(max)"))
								{
									goto IL_737;
								}
								goto IL_664;
							}
						}
						else if (num != 711820689U)
						{
							if (num != 750634308U)
							{
								goto IL_737;
							}
							if (!(text == "tinyint"))
							{
								goto IL_737;
							}
							goto IL_5E0;
						}
						else
						{
							if (!(text == "geometry"))
							{
								goto IL_737;
							}
							goto IL_5E0;
						}
					}
					else if (num <= 956906072U)
					{
						if (num != 923440646U)
						{
							if (num != 956906072U)
							{
								goto IL_737;
							}
							if (!(text == "smallmoney"))
							{
								goto IL_737;
							}
							return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDecimalTypeUsage(primitiveType, 10, 4);
						}
						else
						{
							if (!(text == "datetime2"))
							{
								goto IL_737;
							}
							goto IL_6FD;
						}
					}
					else if (num != 1498571224U)
					{
						if (num != 1539863742U)
						{
							if (num != 1564253156U)
							{
								goto IL_737;
							}
							if (!(text == "time"))
							{
								goto IL_737;
							}
							return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateTimeTypeUsage(primitiveType, null);
						}
						else
						{
							if (!(text == "nvarchar"))
							{
								goto IL_737;
							}
							primitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String;
							flag = !storeType.TryGetMaxLength(out maxLength);
							isUnicode = true;
							isFixedLength = false;
							goto IL_743;
						}
					}
					else
					{
						if (!(text == "varbinary(max)"))
						{
							goto IL_737;
						}
						goto IL_6A5;
					}
				}
				else if (num <= 2174562837U)
				{
					if (num <= 1761125480U)
					{
						if (num != 1623908912U)
						{
							if (num != 1761125480U)
							{
								goto IL_737;
							}
							if (!(text == "numeric"))
							{
								goto IL_737;
							}
						}
						else
						{
							if (!(text == "bit"))
							{
								goto IL_737;
							}
							goto IL_5E0;
						}
					}
					else if (num != 1762504443U)
					{
						if (num != 2174562837U)
						{
							goto IL_737;
						}
						if (!(text == "smallint"))
						{
							goto IL_737;
						}
						goto IL_5E0;
					}
					else
					{
						if (!(text == "varchar(max)"))
						{
							goto IL_737;
						}
						goto IL_653;
					}
				}
				else if (num <= 2336348659U)
				{
					if (num != 2322048458U)
					{
						if (num != 2336348659U)
						{
							goto IL_737;
						}
						if (!(text == "datetimeoffset"))
						{
							goto IL_737;
						}
						return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDateTimeOffsetTypeUsage(primitiveType, null);
					}
					else
					{
						if (!(text == "bigint"))
						{
							goto IL_737;
						}
						goto IL_5E0;
					}
				}
				else if (num != 2515107422U)
				{
					if (num != 2603927413U)
					{
						if (num != 2746163861U)
						{
							goto IL_737;
						}
						if (!(text == "hierarchyid"))
						{
							goto IL_737;
						}
						goto IL_5E0;
					}
					else
					{
						if (!(text == "rowversion"))
						{
							goto IL_737;
						}
						goto IL_6B3;
					}
				}
				else
				{
					if (!(text == "int"))
					{
						goto IL_737;
					}
					goto IL_5E0;
				}
				byte precision;
				byte scale;
				if (storeType.TryGetPrecision(out precision) && storeType.TryGetScale(out scale))
				{
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDecimalTypeUsage(primitiveType, precision, scale);
				}
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDecimalTypeUsage(primitiveType);
				IL_5E0:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(primitiveType);
				IL_653:
				primitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String;
				flag = true;
				isUnicode = false;
				isFixedLength = false;
				goto IL_743;
				IL_664:
				primitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String;
				flag = true;
				isUnicode = true;
				isFixedLength = false;
				goto IL_743;
				IL_6A5:
				primitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary;
				flag = true;
				isFixedLength = false;
				goto IL_743;
				IL_6B3:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateBinaryTypeUsage(primitiveType, true, 8);
				IL_6FD:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDateTimeTypeUsage(primitiveType, null);
				IL_743:
				if (primitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary)
				{
					if (primitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ProviderDoesNotSupportType(text));
					}
					if (!flag)
					{
						return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(primitiveType, isUnicode, isFixedLength, maxLength);
					}
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(primitiveType, isUnicode, isFixedLength);
				}
				else
				{
					if (!flag)
					{
						return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateBinaryTypeUsage(primitiveType, isFixedLength, maxLength);
					}
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateBinaryTypeUsage(primitiveType, isFixedLength);
				}
			}
			IL_737:
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ProviderDoesNotSupportType(text));
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004A90 File Offset: 0x00002C90
		public override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetStoreType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(edmType, "edmType");
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = edmType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			if (primitiveType == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.ProviderDoesNotSupportType(edmType.EdmType.Name));
			}
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.Facet> facets = edmType.Facets;
			switch (primitiveType.PrimitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
			{
				bool flag = facets["FixedLength"].Value != null && (bool)facets["FixedLength"].Value;
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet = facets["MaxLength"];
				bool flag2 = facet.IsUnbounded || facet.Value == null || (int)facet.Value > 8000;
				int num = (!flag2) ? ((int)facet.Value) : int.MinValue;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
				if (flag)
				{
					result = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateBinaryTypeUsage(base.StoreTypeNameToStorePrimitiveType["binary"], true, flag2 ? 8000 : num);
				}
				else if (flag2)
				{
					if (this._version != global::System.Data.Entity.SqlServer.SqlVersion.Sql8)
					{
						result = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateBinaryTypeUsage(base.StoreTypeNameToStorePrimitiveType["varbinary(max)"], false);
					}
					else
					{
						result = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateBinaryTypeUsage(base.StoreTypeNameToStorePrimitiveType["varbinary"], false, 8000);
					}
				}
				else
				{
					result = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateBinaryTypeUsage(base.StoreTypeNameToStorePrimitiveType["varbinary"], false, num);
				}
				return result;
			}
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType["bit"]);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType["tinyint"]);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType["datetime"]);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
			{
				byte precision;
				if (!edmType.TryGetPrecision(out precision))
				{
					precision = 18;
				}
				byte scale;
				if (!edmType.TryGetScale(out scale))
				{
					scale = 0;
				}
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDecimalTypeUsage(base.StoreTypeNameToStorePrimitiveType["decimal"], precision, scale);
			}
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType["float"]);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType["uniqueidentifier"]);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType["real"]);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType["smallint"]);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType["int"]);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType["bigint"]);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
			{
				bool flag3 = facets["Unicode"].Value == null || (bool)facets["Unicode"].Value;
				bool flag4 = facets["FixedLength"].Value != null && (bool)facets["FixedLength"].Value;
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet2 = facets["MaxLength"];
				bool flag5 = facet2.IsUnbounded || facet2.Value == null || (int)facet2.Value > (flag3 ? 4000 : 8000);
				int num2 = (!flag5) ? ((int)facet2.Value) : int.MinValue;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result2;
				if (flag3)
				{
					if (flag4)
					{
						result2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(base.StoreTypeNameToStorePrimitiveType["nchar"], true, true, flag5 ? 4000 : num2);
					}
					else if (flag5)
					{
						if (this._version != global::System.Data.Entity.SqlServer.SqlVersion.Sql8)
						{
							result2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(base.StoreTypeNameToStorePrimitiveType["nvarchar(max)"], true, false);
						}
						else
						{
							result2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(base.StoreTypeNameToStorePrimitiveType["nvarchar"], true, false, 4000);
						}
					}
					else
					{
						result2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(base.StoreTypeNameToStorePrimitiveType["nvarchar"], true, false, num2);
					}
				}
				else if (flag4)
				{
					result2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(base.StoreTypeNameToStorePrimitiveType["char"], false, true, flag5 ? 8000 : num2);
				}
				else if (flag5)
				{
					if (this._version != global::System.Data.Entity.SqlServer.SqlVersion.Sql8)
					{
						result2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(base.StoreTypeNameToStorePrimitiveType["varchar(max)"], false, false);
					}
					else
					{
						result2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(base.StoreTypeNameToStorePrimitiveType["varchar"], false, false, 8000);
					}
				}
				else
				{
					result2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(base.StoreTypeNameToStorePrimitiveType["varchar"], false, false, num2);
				}
				return result2;
			}
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
				return this.GetStorePrimitiveTypeIfPostSql9("time", edmType.EdmType.Name, primitiveType.PrimitiveTypeKind);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
				return this.GetStorePrimitiveTypeIfPostSql9("datetimeoffset", edmType.EdmType.Name, primitiveType.PrimitiveTypeKind);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection:
				return this.GetStorePrimitiveTypeIfPostSql9("geometry", edmType.EdmType.Name, primitiveType.PrimitiveTypeKind);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection:
				return this.GetStorePrimitiveTypeIfPostSql9("geography", edmType.EdmType.Name, primitiveType.PrimitiveTypeKind);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId:
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType["hierarchyid"]);
			}
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.NoStoreTypeForEdmType(edmType.EdmType.Name, primitiveType.PrimitiveTypeKind));
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004FFC File Offset: 0x000031FC
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetStorePrimitiveTypeIfPostSql9(string storeTypeName, string nameForException, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			if (this.SqlVersion != global::System.Data.Entity.SqlServer.SqlVersion.Sql8 && this.SqlVersion != global::System.Data.Entity.SqlServer.SqlVersion.Sql9)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(base.StoreTypeNameToStorePrimitiveType[storeTypeName]);
			}
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.NoStoreTypeForEdmType(nameForException, primitiveTypeKind));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00005035 File Offset: 0x00003235
		public override bool SupportsEscapingLikeArgument(out char escapeCharacter)
		{
			escapeCharacter = '~';
			return true;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000503C File Offset: 0x0000323C
		public override string EscapeLikeArgument(string argument)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<string>(argument, "argument");
			bool flag;
			return global::System.Data.Entity.SqlServer.SqlProviderManifest.EscapeLikeText(argument, true, out flag);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000505E File Offset: 0x0000325E
		public override bool SupportsParameterOptimizationInSchemaQueries()
		{
			return true;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005061 File Offset: 0x00003261
		public override bool SupportsInExpression()
		{
			return true;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005064 File Offset: 0x00003264
		public override bool SupportsIntersectAndUnionAllFlattening()
		{
			return true;
		}

		// Token: 0x0400000A RID: 10
		internal const string TokenSql8 = "2000";

		// Token: 0x0400000B RID: 11
		internal const string TokenSql9 = "2005";

		// Token: 0x0400000C RID: 12
		internal const string TokenSql10 = "2008";

		// Token: 0x0400000D RID: 13
		internal const string TokenSql11 = "2012";

		// Token: 0x0400000E RID: 14
		internal const string TokenAzure11 = "2012.Azure";

		// Token: 0x0400000F RID: 15
		internal const char LikeEscapeChar = '~';

		// Token: 0x04000010 RID: 16
		internal const string LikeEscapeCharToString = "~";

		// Token: 0x04000011 RID: 17
		private readonly global::System.Data.Entity.SqlServer.SqlVersion _version = global::System.Data.Entity.SqlServer.SqlVersion.Sql9;

		// Token: 0x04000012 RID: 18
		private const int varcharMaxSize = 8000;

		// Token: 0x04000013 RID: 19
		private const int nvarcharMaxSize = 4000;

		// Token: 0x04000014 RID: 20
		private const int binaryMaxSize = 8000;

		// Token: 0x04000015 RID: 21
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> _primitiveTypes;

		// Token: 0x04000016 RID: 22
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> _functions;
	}
}
