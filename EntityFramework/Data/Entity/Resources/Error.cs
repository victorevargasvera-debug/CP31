using System;
using System.CodeDom.Compiler;
using System.Data.Entity.Core;
using System.Data.Entity.Migrations.Infrastructure;

namespace System.Data.Entity.Resources
{
	// Token: 0x0200009B RID: 155
	[global::System.CodeDom.Compiler.GeneratedCode("Resources.tt", "1.0.0.0")]
	internal static class Error
	{
		// Token: 0x06000D4F RID: 3407 RVA: 0x0001A88A File Offset: 0x00018A8A
		internal static global::System.Exception AutomaticDataLoss()
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.AutomaticDataLossException(global::System.Data.Entity.Resources.Strings.AutomaticDataLoss);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0001A896 File Offset: 0x00018A96
		internal static global::System.Exception MetadataOutOfDate()
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.MetadataOutOfDate);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0001A8A2 File Offset: 0x00018AA2
		internal static global::System.Exception MigrationNotFound(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.MigrationNotFound(p0));
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0001A8AF File Offset: 0x00018AAF
		internal static global::System.Exception PartialFkOperation(object p0, object p1)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.PartialFkOperation(p0, p1));
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0001A8BD File Offset: 0x00018ABD
		internal static global::System.Exception AutoNotValidTarget(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.AutoNotValidTarget(p0));
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0001A8CA File Offset: 0x00018ACA
		internal static global::System.Exception AutoNotValidForScriptWindows(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.AutoNotValidForScriptWindows(p0));
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0001A8D7 File Offset: 0x00018AD7
		internal static global::System.Exception ContextNotConstructible(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.ContextNotConstructible(p0));
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0001A8E4 File Offset: 0x00018AE4
		internal static global::System.Exception AmbiguousMigrationName(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.AmbiguousMigrationName(p0));
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0001A8F1 File Offset: 0x00018AF1
		internal static global::System.Exception AutomaticDisabledException()
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.AutomaticMigrationsDisabledException(global::System.Data.Entity.Resources.Strings.AutomaticDisabledException);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0001A8FD File Offset: 0x00018AFD
		internal static global::System.Exception DownScriptWindowsNotSupported()
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.DownScriptWindowsNotSupported);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0001A909 File Offset: 0x00018B09
		internal static global::System.Exception AssemblyMigrator_NoConfigurationWithName(object p0, object p1)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.AssemblyMigrator_NoConfigurationWithName(p0, p1));
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0001A917 File Offset: 0x00018B17
		internal static global::System.Exception AssemblyMigrator_MultipleConfigurationsWithName(object p0, object p1)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.AssemblyMigrator_MultipleConfigurationsWithName(p0, p1));
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0001A925 File Offset: 0x00018B25
		internal static global::System.Exception AssemblyMigrator_NoConfiguration(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.AssemblyMigrator_NoConfiguration(p0));
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0001A932 File Offset: 0x00018B32
		internal static global::System.Exception AssemblyMigrator_MultipleConfigurations(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.AssemblyMigrator_MultipleConfigurations(p0));
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0001A93F File Offset: 0x00018B3F
		internal static global::System.Exception MigrationsNamespaceNotUnderRootNamespace(object p0, object p1)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.MigrationsNamespaceNotUnderRootNamespace(p0, p1));
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0001A94D File Offset: 0x00018B4D
		internal static global::System.Exception UnableToDispatchAddOrUpdate(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDispatchAddOrUpdate(p0));
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0001A95A File Offset: 0x00018B5A
		internal static global::System.Exception NoSqlGeneratorForProvider(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.NoSqlGeneratorForProvider(p0));
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0001A967 File Offset: 0x00018B67
		internal static global::System.Exception EntityTypeConfigurationMismatch(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityTypeConfigurationMismatch(p0));
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0001A974 File Offset: 0x00018B74
		internal static global::System.Exception ComplexTypeConfigurationMismatch(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ComplexTypeConfigurationMismatch(p0));
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0001A981 File Offset: 0x00018B81
		internal static global::System.Exception KeyPropertyNotFound(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.KeyPropertyNotFound(p0, p1));
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0001A98F File Offset: 0x00018B8F
		internal static global::System.Exception ForeignKeyPropertyNotFound(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ForeignKeyPropertyNotFound(p0, p1));
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0001A99D File Offset: 0x00018B9D
		internal static global::System.Exception PropertyNotFound(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.PropertyNotFound(p0, p1));
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0001A9AB File Offset: 0x00018BAB
		internal static global::System.Exception NavigationPropertyNotFound(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.NavigationPropertyNotFound(p0, p1));
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0001A9B9 File Offset: 0x00018BB9
		internal static global::System.Exception InvalidPropertyExpression(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidPropertyExpression(p0));
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0001A9C6 File Offset: 0x00018BC6
		internal static global::System.Exception InvalidComplexPropertyExpression(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidComplexPropertyExpression(p0));
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0001A9D3 File Offset: 0x00018BD3
		internal static global::System.Exception InvalidPropertiesExpression(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidPropertiesExpression(p0));
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0001A9E0 File Offset: 0x00018BE0
		internal static global::System.Exception InvalidComplexPropertiesExpression(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidComplexPropertiesExpression(p0));
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0001A9ED File Offset: 0x00018BED
		internal static global::System.Exception DuplicateStructuralTypeConfiguration(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DuplicateStructuralTypeConfiguration(p0));
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0001A9FA File Offset: 0x00018BFA
		internal static global::System.Exception ConflictingPropertyConfiguration(object p0, object p1, object p2)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingPropertyConfiguration(p0, p1, p2));
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0001AA09 File Offset: 0x00018C09
		internal static global::System.Exception ConflictingTypeAnnotation(object p0, object p1, object p2, object p3)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingTypeAnnotation(p0, p1, p2, p3));
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0001AA19 File Offset: 0x00018C19
		internal static global::System.Exception ConflictingColumnConfiguration(object p0, object p1, object p2)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingColumnConfiguration(p0, p1, p2));
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0001AA28 File Offset: 0x00018C28
		internal static global::System.Exception CodeFirstInvalidComplexType(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeFirstInvalidComplexType(p0));
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0001AA35 File Offset: 0x00018C35
		internal static global::System.Exception InvalidEntityType(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidEntityType(p0));
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0001AA42 File Offset: 0x00018C42
		internal static global::System.Exception NavigationInverseItself(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.NavigationInverseItself(p0, p1));
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0001AA50 File Offset: 0x00018C50
		internal static global::System.Exception ConflictingConstraint(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingConstraint(p0, p1));
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0001AA5E File Offset: 0x00018C5E
		internal static global::System.Exception ConflictingInferredColumnType(object p0, object p1, object p2)
		{
			return new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.ConflictingInferredColumnType(p0, p1, p2));
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0001AA6D File Offset: 0x00018C6D
		internal static global::System.Exception ConflictingMapping(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingMapping(p0, p1));
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0001AA7B File Offset: 0x00018C7B
		internal static global::System.Exception ConflictingCascadeDeleteOperation(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingCascadeDeleteOperation(p0, p1));
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0001AA89 File Offset: 0x00018C89
		internal static global::System.Exception ConflictingMultiplicities(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingMultiplicities(p0, p1));
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0001AA97 File Offset: 0x00018C97
		internal static global::System.Exception MaxLengthAttributeConvention_InvalidMaxLength(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.MaxLengthAttributeConvention_InvalidMaxLength(p0, p1));
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0001AAA5 File Offset: 0x00018CA5
		internal static global::System.Exception StringLengthAttributeConvention_InvalidMaximumLength(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.StringLengthAttributeConvention_InvalidMaximumLength(p0, p1));
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0001AAB3 File Offset: 0x00018CB3
		internal static global::System.Exception ModelGeneration_UnableToDetermineKeyOrder(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ModelGeneration_UnableToDetermineKeyOrder(p0));
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		internal static global::System.Exception ForeignKeyAttributeConvention_EmptyKey(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ForeignKeyAttributeConvention_EmptyKey(p0, p1));
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0001AACE File Offset: 0x00018CCE
		internal static global::System.Exception ForeignKeyAttributeConvention_InvalidKey(object p0, object p1, object p2, object p3)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ForeignKeyAttributeConvention_InvalidKey(p0, p1, p2, p3));
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0001AADE File Offset: 0x00018CDE
		internal static global::System.Exception ForeignKeyAttributeConvention_InvalidNavigationProperty(object p0, object p1, object p2)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ForeignKeyAttributeConvention_InvalidNavigationProperty(p0, p1, p2));
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0001AAED File Offset: 0x00018CED
		internal static global::System.Exception ForeignKeyAttributeConvention_OrderRequired(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ForeignKeyAttributeConvention_OrderRequired(p0));
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0001AAFA File Offset: 0x00018CFA
		internal static global::System.Exception InversePropertyAttributeConvention_PropertyNotFound(object p0, object p1, object p2, object p3)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InversePropertyAttributeConvention_PropertyNotFound(p0, p1, p2, p3));
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0001AB0A File Offset: 0x00018D0A
		internal static global::System.Exception InversePropertyAttributeConvention_SelfInverseDetected(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InversePropertyAttributeConvention_SelfInverseDetected(p0, p1));
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0001AB18 File Offset: 0x00018D18
		internal static global::System.Exception KeyRegisteredOnDerivedType(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.KeyRegisteredOnDerivedType(p0, p1));
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0001AB26 File Offset: 0x00018D26
		internal static global::System.Exception InvalidTableMapping(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidTableMapping(p0, p1));
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0001AB34 File Offset: 0x00018D34
		internal static global::System.Exception InvalidTableMapping_NoTableName(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidTableMapping_NoTableName(p0));
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0001AB41 File Offset: 0x00018D41
		internal static global::System.Exception InvalidChainedMappingSyntax(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidChainedMappingSyntax(p0));
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0001AB4E File Offset: 0x00018D4E
		internal static global::System.Exception InvalidNotNullCondition(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidNotNullCondition(p0, p1));
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0001AB5C File Offset: 0x00018D5C
		internal static global::System.Exception InvalidDiscriminatorType(object p0)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidDiscriminatorType(p0));
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0001AB69 File Offset: 0x00018D69
		internal static global::System.Exception ConventionNotFound(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConventionNotFound(p0, p1));
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0001AB77 File Offset: 0x00018D77
		internal static global::System.Exception InvalidEntitySplittingProperties(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidEntitySplittingProperties(p0));
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0001AB84 File Offset: 0x00018D84
		internal static global::System.Exception InvalidDatabaseName(object p0)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidDatabaseName(p0));
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0001AB91 File Offset: 0x00018D91
		internal static global::System.Exception EntityMappingConfiguration_DuplicateMapInheritedProperties(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityMappingConfiguration_DuplicateMapInheritedProperties(p0));
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0001AB9E File Offset: 0x00018D9E
		internal static global::System.Exception EntityMappingConfiguration_DuplicateMappedProperties(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityMappingConfiguration_DuplicateMappedProperties(p0));
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0001ABAB File Offset: 0x00018DAB
		internal static global::System.Exception EntityMappingConfiguration_DuplicateMappedProperty(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityMappingConfiguration_DuplicateMappedProperty(p0, p1));
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0001ABB9 File Offset: 0x00018DB9
		internal static global::System.Exception EntityMappingConfiguration_CannotMapIgnoredProperty(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityMappingConfiguration_CannotMapIgnoredProperty(p0, p1));
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0001ABC7 File Offset: 0x00018DC7
		internal static global::System.Exception EntityMappingConfiguration_InvalidTableSharing(object p0, object p1, object p2)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityMappingConfiguration_InvalidTableSharing(p0, p1, p2));
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0001ABD6 File Offset: 0x00018DD6
		internal static global::System.Exception EntityMappingConfiguration_TPCWithIAsOnNonLeafType(object p0, object p1, object p2)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityMappingConfiguration_TPCWithIAsOnNonLeafType(p0, p1, p2));
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0001ABE5 File Offset: 0x00018DE5
		internal static global::System.Exception CannotIgnoreMappedBaseProperty(object p0, object p1, object p2)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CannotIgnoreMappedBaseProperty(p0, p1, p2));
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0001ABF4 File Offset: 0x00018DF4
		internal static global::System.Exception ModelBuilder_KeyPropertiesMustBePrimitive(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ModelBuilder_KeyPropertiesMustBePrimitive(p0, p1));
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0001AC02 File Offset: 0x00018E02
		internal static global::System.Exception TableNotFound(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.TableNotFound(p0));
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0001AC0F File Offset: 0x00018E0F
		internal static global::System.Exception IncorrectColumnCount(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.IncorrectColumnCount(p0));
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0001AC1C File Offset: 0x00018E1C
		internal static global::System.Exception CircularComplexTypeHierarchy()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CircularComplexTypeHierarchy);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0001AC28 File Offset: 0x00018E28
		internal static global::System.Exception UnableToDeterminePrincipal(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDeterminePrincipal(p0, p1));
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0001AC36 File Offset: 0x00018E36
		internal static global::System.Exception UnmappedAbstractType(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnmappedAbstractType(p0));
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0001AC43 File Offset: 0x00018E43
		internal static global::System.Exception UnsupportedHybridInheritanceMapping(object p0)
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.UnsupportedHybridInheritanceMapping(p0));
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0001AC50 File Offset: 0x00018E50
		internal static global::System.Exception OrphanedConfiguredTableDetected(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OrphanedConfiguredTableDetected(p0));
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0001AC5D File Offset: 0x00018E5D
		internal static global::System.Exception DuplicateConfiguredColumnOrder(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DuplicateConfiguredColumnOrder(p0));
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0001AC6A File Offset: 0x00018E6A
		internal static global::System.Exception UnsupportedUseOfV3Type(object p0, object p1)
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.UnsupportedUseOfV3Type(p0, p1));
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0001AC78 File Offset: 0x00018E78
		internal static global::System.Exception MultiplePropertiesMatchedAsKeys(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.MultiplePropertiesMatchedAsKeys(p0, p1));
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0001AC86 File Offset: 0x00018E86
		internal static global::System.Exception DbPropertyEntry_CannotGetCurrentValue(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyEntry_CannotGetCurrentValue(p0, p1));
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0001AC94 File Offset: 0x00018E94
		internal static global::System.Exception DbPropertyEntry_CannotSetCurrentValue(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyEntry_CannotSetCurrentValue(p0, p1));
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0001ACA2 File Offset: 0x00018EA2
		internal static global::System.Exception DbPropertyEntry_NotSupportedForDetached(object p0, object p1, object p2)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyEntry_NotSupportedForDetached(p0, p1, p2));
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0001ACB1 File Offset: 0x00018EB1
		internal static global::System.Exception DbPropertyEntry_SettingEntityRefNotSupported(object p0, object p1, object p2)
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.DbPropertyEntry_SettingEntityRefNotSupported(p0, p1, p2));
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0001ACC0 File Offset: 0x00018EC0
		internal static global::System.Exception DbPropertyEntry_NotSupportedForPropertiesNotInTheModel(object p0, object p1, object p2)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyEntry_NotSupportedForPropertiesNotInTheModel(p0, p1, p2));
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0001ACCF File Offset: 0x00018ECF
		internal static global::System.Exception DbEntityEntry_NotSupportedForDetached(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_NotSupportedForDetached(p0, p1));
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0001ACDD File Offset: 0x00018EDD
		internal static global::System.Exception DbSet_BadTypeForAddAttachRemove(object p0, object p1, object p2)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbSet_BadTypeForAddAttachRemove(p0, p1, p2));
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0001ACEC File Offset: 0x00018EEC
		internal static global::System.Exception DbSet_BadTypeForCreate(object p0, object p1)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbSet_BadTypeForCreate(p0, p1));
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0001ACFA File Offset: 0x00018EFA
		internal static global::System.Exception DbEntity_BadTypeForCast(object p0, object p1, object p2)
		{
			return new global::System.InvalidCastException(global::System.Data.Entity.Resources.Strings.DbEntity_BadTypeForCast(p0, p1, p2));
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0001AD09 File Offset: 0x00018F09
		internal static global::System.Exception DbMember_BadTypeForCast(object p0, object p1, object p2, object p3, object p4)
		{
			return new global::System.InvalidCastException(global::System.Data.Entity.Resources.Strings.DbMember_BadTypeForCast(p0, p1, p2, p3, p4));
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0001AD1B File Offset: 0x00018F1B
		internal static global::System.Exception DbEntityEntry_UsedReferenceForCollectionProp(object p0, object p1)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_UsedReferenceForCollectionProp(p0, p1));
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0001AD29 File Offset: 0x00018F29
		internal static global::System.Exception DbEntityEntry_UsedCollectionForReferenceProp(object p0, object p1)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_UsedCollectionForReferenceProp(p0, p1));
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0001AD37 File Offset: 0x00018F37
		internal static global::System.Exception DbEntityEntry_NotANavigationProperty(object p0, object p1)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_NotANavigationProperty(p0, p1));
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0001AD45 File Offset: 0x00018F45
		internal static global::System.Exception DbEntityEntry_NotAScalarProperty(object p0, object p1)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_NotAScalarProperty(p0, p1));
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0001AD53 File Offset: 0x00018F53
		internal static global::System.Exception DbEntityEntry_NotAComplexProperty(object p0, object p1)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_NotAComplexProperty(p0, p1));
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0001AD61 File Offset: 0x00018F61
		internal static global::System.Exception DbEntityEntry_NotAProperty(object p0, object p1)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_NotAProperty(p0, p1));
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0001AD6F File Offset: 0x00018F6F
		internal static global::System.Exception DbEntityEntry_DottedPartNotComplex(object p0, object p1, object p2)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_DottedPartNotComplex(p0, p1, p2));
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0001AD7E File Offset: 0x00018F7E
		internal static global::System.Exception DbEntityEntry_DottedPathMustBeProperty(object p0)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_DottedPathMustBeProperty(p0));
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0001AD8B File Offset: 0x00018F8B
		internal static global::System.Exception DbEntityEntry_WrongGenericForNavProp(object p0, object p1, object p2, object p3)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_WrongGenericForNavProp(p0, p1, p2, p3));
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0001AD9B File Offset: 0x00018F9B
		internal static global::System.Exception DbEntityEntry_WrongGenericForCollectionNavProp(object p0, object p1, object p2, object p3)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_WrongGenericForCollectionNavProp(p0, p1, p2, p3));
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0001ADAB File Offset: 0x00018FAB
		internal static global::System.Exception DbEntityEntry_WrongGenericForProp(object p0, object p1, object p2, object p3)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_WrongGenericForProp(p0, p1, p2, p3));
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0001ADBB File Offset: 0x00018FBB
		internal static global::System.Exception DbPropertyValues_CannotGetValuesForState(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_CannotGetValuesForState(p0, p1));
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0001ADC9 File Offset: 0x00018FC9
		internal static global::System.Exception DbPropertyValues_CannotSetNullValue(object p0, object p1, object p2)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_CannotSetNullValue(p0, p1, p2));
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0001ADD8 File Offset: 0x00018FD8
		internal static global::System.Exception DbPropertyValues_CannotGetStoreValuesWhenComplexPropertyIsNull(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_CannotGetStoreValuesWhenComplexPropertyIsNull(p0, p1));
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0001ADE6 File Offset: 0x00018FE6
		internal static global::System.Exception DbPropertyValues_WrongTypeForAssignment(object p0, object p1, object p2, object p3)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_WrongTypeForAssignment(p0, p1, p2, p3));
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0001ADF6 File Offset: 0x00018FF6
		internal static global::System.Exception DbPropertyValues_PropertyValueNamesAreReadonly()
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_PropertyValueNamesAreReadonly);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0001AE02 File Offset: 0x00019002
		internal static global::System.Exception DbPropertyValues_PropertyDoesNotExist(object p0, object p1)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_PropertyDoesNotExist(p0, p1));
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0001AE10 File Offset: 0x00019010
		internal static global::System.Exception DbPropertyValues_AttemptToSetValuesFromWrongObject(object p0, object p1)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_AttemptToSetValuesFromWrongObject(p0, p1));
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0001AE1E File Offset: 0x0001901E
		internal static global::System.Exception DbPropertyValues_AttemptToSetValuesFromWrongType(object p0, object p1)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_AttemptToSetValuesFromWrongType(p0, p1));
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0001AE2C File Offset: 0x0001902C
		internal static global::System.Exception DbPropertyValues_AttemptToSetNonValuesOnComplexProperty()
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_AttemptToSetNonValuesOnComplexProperty);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0001AE38 File Offset: 0x00019038
		internal static global::System.Exception DbPropertyValues_ComplexObjectCannotBeNull(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_ComplexObjectCannotBeNull(p0, p1));
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0001AE46 File Offset: 0x00019046
		internal static global::System.Exception DbPropertyValues_NestedPropertyValuesNull(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_NestedPropertyValuesNull(p0, p1));
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0001AE54 File Offset: 0x00019054
		internal static global::System.Exception DbPropertyValues_CannotSetPropertyOnNullCurrentValue(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_CannotSetPropertyOnNullCurrentValue(p0, p1));
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0001AE62 File Offset: 0x00019062
		internal static global::System.Exception DbPropertyValues_CannotSetPropertyOnNullOriginalValue(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbPropertyValues_CannotSetPropertyOnNullOriginalValue(p0, p1));
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0001AE70 File Offset: 0x00019070
		internal static global::System.Exception DatabaseInitializationStrategy_ModelMismatch(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DatabaseInitializationStrategy_ModelMismatch(p0));
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0001AE7D File Offset: 0x0001907D
		internal static global::System.Exception Database_DatabaseAlreadyExists(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Database_DatabaseAlreadyExists(p0));
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0001AE8A File Offset: 0x0001908A
		internal static global::System.Exception Database_NonCodeFirstCompatibilityCheck()
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Database_NonCodeFirstCompatibilityCheck);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0001AE96 File Offset: 0x00019096
		internal static global::System.Exception Database_NoDatabaseMetadata()
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Database_NoDatabaseMetadata);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0001AEA2 File Offset: 0x000190A2
		internal static global::System.Exception ContextConfiguredMultipleTimes(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ContextConfiguredMultipleTimes(p0));
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0001AEAF File Offset: 0x000190AF
		internal static global::System.Exception DbContext_ContextUsedInModelCreating()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_ContextUsedInModelCreating);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0001AEBB File Offset: 0x000190BB
		internal static global::System.Exception DbContext_MESTNotSupported()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_MESTNotSupported);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0001AEC7 File Offset: 0x000190C7
		internal static global::System.Exception DbContext_Disposed()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_Disposed);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0001AED3 File Offset: 0x000190D3
		internal static global::System.Exception DbContext_ProviderReturnedNullConnection()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_ProviderReturnedNullConnection);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0001AEDF File Offset: 0x000190DF
		internal static global::System.Exception DbContext_ProviderNameMissing(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_ProviderNameMissing(p0));
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0001AEEC File Offset: 0x000190EC
		internal static global::System.Exception DbContext_ConnectionFactoryReturnedNullConnection()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_ConnectionFactoryReturnedNullConnection);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0001AEF8 File Offset: 0x000190F8
		internal static global::System.Exception DbSet_WrongEntityTypeFound(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbSet_WrongEntityTypeFound(p0, p1));
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0001AF06 File Offset: 0x00019106
		internal static global::System.Exception DbSet_MultipleAddedEntitiesFound()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbSet_MultipleAddedEntitiesFound);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0001AF12 File Offset: 0x00019112
		internal static global::System.Exception DbSet_DbSetUsedWithComplexType(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbSet_DbSetUsedWithComplexType(p0));
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0001AF1F File Offset: 0x0001911F
		internal static global::System.Exception DbSet_PocoAndNonPocoMixedInSameAssembly(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbSet_PocoAndNonPocoMixedInSameAssembly(p0));
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0001AF2C File Offset: 0x0001912C
		internal static global::System.Exception DbSet_EntityTypeNotInModel(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbSet_EntityTypeNotInModel(p0));
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0001AF39 File Offset: 0x00019139
		internal static global::System.Exception DbQuery_BindingToDbQueryNotSupported()
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.DbQuery_BindingToDbQueryNotSupported);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0001AF45 File Offset: 0x00019145
		internal static global::System.Exception DbContext_ConnectionStringNotFound(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_ConnectionStringNotFound(p0));
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0001AF52 File Offset: 0x00019152
		internal static global::System.Exception DbContext_ConnectionHasModel()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_ConnectionHasModel);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0001AF5E File Offset: 0x0001915E
		internal static global::System.Exception DbCollectionEntry_CannotSetCollectionProp(object p0, object p1)
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.DbCollectionEntry_CannotSetCollectionProp(p0, p1));
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0001AF6C File Offset: 0x0001916C
		internal static global::System.Exception CodeFirstCachedMetadataWorkspace_SameModelDifferentProvidersNotSupported()
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.CodeFirstCachedMetadataWorkspace_SameModelDifferentProvidersNotSupported);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0001AF78 File Offset: 0x00019178
		internal static global::System.Exception Mapping_MESTNotSupported(object p0, object p1, object p2)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Mapping_MESTNotSupported(p0, p1, p2));
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0001AF87 File Offset: 0x00019187
		internal static global::System.Exception DbModelBuilder_MissingRequiredCtor(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbModelBuilder_MissingRequiredCtor(p0));
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0001AF94 File Offset: 0x00019194
		internal static global::System.Exception SqlConnectionFactory_MdfNotSupported(object p0)
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.SqlConnectionFactory_MdfNotSupported(p0));
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0001AFA1 File Offset: 0x000191A1
		internal static global::System.Exception EdmxWriter_EdmxFromObjectContextNotSupported()
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.EdmxWriter_EdmxFromObjectContextNotSupported);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0001AFAD File Offset: 0x000191AD
		internal static global::System.Exception EdmxWriter_EdmxFromModelFirstNotSupported()
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.EdmxWriter_EdmxFromModelFirstNotSupported);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0001AFB9 File Offset: 0x000191B9
		internal static global::System.Exception EdmxWriter_EdmxFromRawCompiledModelNotSupported()
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.EdmxWriter_EdmxFromRawCompiledModelNotSupported);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0001AFC5 File Offset: 0x000191C5
		internal static global::System.Exception DbContextServices_MissingDefaultCtor(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContextServices_MissingDefaultCtor(p0));
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0001AFD2 File Offset: 0x000191D2
		internal static global::System.Exception CannotCallGenericSetWithProxyType()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CannotCallGenericSetWithProxyType);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0001AFDE File Offset: 0x000191DE
		internal static global::System.Exception MaxLengthAttribute_InvalidMaxLength()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.MaxLengthAttribute_InvalidMaxLength);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0001AFEA File Offset: 0x000191EA
		internal static global::System.Exception MinLengthAttribute_InvalidMinLength()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.MinLengthAttribute_InvalidMinLength);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0001AFF6 File Offset: 0x000191F6
		internal static global::System.Exception DbConnectionInfo_ConnectionStringNotFound(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbConnectionInfo_ConnectionStringNotFound(p0));
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0001B003 File Offset: 0x00019203
		internal static global::System.Exception EagerInternalContext_CannotSetConnectionInfo()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EagerInternalContext_CannotSetConnectionInfo);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0001B00F File Offset: 0x0001920F
		internal static global::System.Exception LazyInternalContext_CannotReplaceEfConnectionWithDbConnection()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LazyInternalContext_CannotReplaceEfConnectionWithDbConnection);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x0001B01B File Offset: 0x0001921B
		internal static global::System.Exception LazyInternalContext_CannotReplaceDbConnectionWithEfConnection()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LazyInternalContext_CannotReplaceDbConnectionWithEfConnection);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0001B027 File Offset: 0x00019227
		internal static global::System.Exception EntityKey_UnexpectedNull()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_UnexpectedNull);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0001B033 File Offset: 0x00019233
		internal static global::System.Exception EntityClient_ConnectionStringNeededBeforeOperation()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_ConnectionStringNeededBeforeOperation);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0001B03F File Offset: 0x0001923F
		internal static global::System.Exception EntityClient_ConnectionNotOpen()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_ConnectionNotOpen);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0001B04B File Offset: 0x0001924B
		internal static global::System.Exception EntityClient_NoConnectionForAdapter()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_NoConnectionForAdapter);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0001B057 File Offset: 0x00019257
		internal static global::System.Exception EntityClient_ClosedConnectionForUpdate()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_ClosedConnectionForUpdate);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0001B063 File Offset: 0x00019263
		internal static global::System.Exception EntityClient_NoStoreConnectionForUpdate()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_NoStoreConnectionForUpdate);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0001B06F File Offset: 0x0001926F
		internal static global::System.Exception Mapping_Default_OCMapping_Member_Type_Mismatch(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)
		{
			return new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Default_OCMapping_Member_Type_Mismatch(p0, p1, p2, p3, p4, p5, p6, p7));
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0001B087 File Offset: 0x00019287
		internal static global::System.Exception ObjectStateManager_ConflictingChangesOfRelationshipDetected(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ConflictingChangesOfRelationshipDetected(p0, p1));
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0001B095 File Offset: 0x00019295
		internal static global::System.Exception RelatedEnd_InvalidOwnerStateForAttach()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_InvalidOwnerStateForAttach);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0001B0A1 File Offset: 0x000192A1
		internal static global::System.Exception RelatedEnd_InvalidNthElementNullForAttach(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_InvalidNthElementNullForAttach(p0));
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0001B0AE File Offset: 0x000192AE
		internal static global::System.Exception RelatedEnd_InvalidNthElementContextForAttach(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_InvalidNthElementContextForAttach(p0));
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0001B0BB File Offset: 0x000192BB
		internal static global::System.Exception RelatedEnd_InvalidNthElementStateForAttach(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_InvalidNthElementStateForAttach(p0));
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0001B0C8 File Offset: 0x000192C8
		internal static global::System.Exception RelatedEnd_InvalidEntityContextForAttach()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_InvalidEntityContextForAttach);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0001B0D4 File Offset: 0x000192D4
		internal static global::System.Exception RelatedEnd_InvalidEntityStateForAttach()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_InvalidEntityStateForAttach);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0001B0E0 File Offset: 0x000192E0
		internal static global::System.Exception RelatedEnd_UnableToAddRelationshipWithDeletedEntity()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_UnableToAddRelationshipWithDeletedEntity);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0001B0EC File Offset: 0x000192EC
		internal static global::System.Exception Collections_NoRelationshipSetMatched(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Collections_NoRelationshipSetMatched(p0));
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0001B0F9 File Offset: 0x000192F9
		internal static global::System.Exception Collections_InvalidEntityStateSource()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Collections_InvalidEntityStateSource);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0001B105 File Offset: 0x00019305
		internal static global::System.Exception Collections_InvalidEntityStateLoad(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Collections_InvalidEntityStateLoad(p0));
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0001B112 File Offset: 0x00019312
		internal static global::System.Exception EntityReference_LessThanExpectedRelatedEntitiesFound()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_LessThanExpectedRelatedEntitiesFound);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0001B11E File Offset: 0x0001931E
		internal static global::System.Exception EntityReference_MoreThanExpectedRelatedEntitiesFound()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_MoreThanExpectedRelatedEntitiesFound);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0001B12A File Offset: 0x0001932A
		internal static global::System.Exception EntityReference_CannotSetSpecialKeys()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotSetSpecialKeys);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0001B136 File Offset: 0x00019336
		internal static global::System.Exception RelatedEnd_RelatedEndNotFound()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_RelatedEndNotFound);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0001B142 File Offset: 0x00019342
		internal static global::System.Exception RelatedEnd_RelatedEndNotAttachedToContext(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_RelatedEndNotAttachedToContext(p0));
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0001B14F File Offset: 0x0001934F
		internal static global::System.Exception RelatedEnd_LoadCalledOnNonEmptyNoTrackedRelatedEnd()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_LoadCalledOnNonEmptyNoTrackedRelatedEnd);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0001B15B File Offset: 0x0001935B
		internal static global::System.Exception RelatedEnd_LoadCalledOnAlreadyLoadedNoTrackedRelatedEnd()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_LoadCalledOnAlreadyLoadedNoTrackedRelatedEnd);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0001B167 File Offset: 0x00019367
		internal static global::System.Exception RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities(p0));
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0001B174 File Offset: 0x00019374
		internal static global::System.Exception RelatedEnd_CannotCreateRelationshipEntitiesInDifferentContexts()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_CannotCreateRelationshipEntitiesInDifferentContexts);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0001B180 File Offset: 0x00019380
		internal static global::System.Exception RelatedEnd_MismatchedMergeOptionOnLoad(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_MismatchedMergeOptionOnLoad(p0));
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0001B18D File Offset: 0x0001938D
		internal static global::System.Exception RelatedEnd_EntitySetIsNotValidForRelationship(object p0, object p1, object p2, object p3, object p4)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_EntitySetIsNotValidForRelationship(p0, p1, p2, p3, p4));
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0001B19F File Offset: 0x0001939F
		internal static global::System.Exception RelatedEnd_OwnerIsNull()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_OwnerIsNull);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0001B1AB File Offset: 0x000193AB
		internal static global::System.Exception RelationshipManager_NavigationPropertyNotFound(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_NavigationPropertyNotFound(p0));
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0001B1B8 File Offset: 0x000193B8
		internal static global::System.Exception ADP_ClosedDataReaderError()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_ClosedDataReaderError);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0001B1C4 File Offset: 0x000193C4
		internal static global::System.Exception ADP_DataReaderClosed(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_DataReaderClosed(p0));
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0001B1D1 File Offset: 0x000193D1
		internal static global::System.Exception ADP_ImplicitlyClosedDataReaderError()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_ImplicitlyClosedDataReaderError);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0001B1DD File Offset: 0x000193DD
		internal static global::System.Exception ADP_NoData()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_NoData);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0001B1E9 File Offset: 0x000193E9
		internal static global::System.Exception InvalidEdmMemberInstance()
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidEdmMemberInstance);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0001B1F5 File Offset: 0x000193F5
		internal static global::System.Exception EnableMigrations_MultipleContextsWithName(object p0, object p1)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.EnableMigrations_MultipleContextsWithName(p0, p1));
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0001B203 File Offset: 0x00019403
		internal static global::System.Exception EnableMigrations_NoContext(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.EnableMigrations_NoContext(p0));
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0001B210 File Offset: 0x00019410
		internal static global::System.Exception EnableMigrations_NoContextWithName(object p0, object p1)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.EnableMigrations_NoContextWithName(p0, p1));
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0001B21E File Offset: 0x0001941E
		internal static global::System.Exception MoreThanOneElement()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.MoreThanOneElement);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0001B22A File Offset: 0x0001942A
		internal static global::System.Exception IQueryable_Not_Async(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.IQueryable_Not_Async(p0));
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0001B237 File Offset: 0x00019437
		internal static global::System.Exception IQueryable_Provider_Not_Async()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.IQueryable_Provider_Not_Async);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0001B243 File Offset: 0x00019443
		internal static global::System.Exception EmptySequence()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EmptySequence);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0001B24F File Offset: 0x0001944F
		internal static global::System.Exception UnableToMoveHistoryTableWithAuto()
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.UnableToMoveHistoryTableWithAuto);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0001B25B File Offset: 0x0001945B
		internal static global::System.Exception NoMatch()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.NoMatch);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0001B267 File Offset: 0x00019467
		internal static global::System.Exception MoreThanOneMatch()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.MoreThanOneMatch);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0001B273 File Offset: 0x00019473
		internal static global::System.Exception ModelBuilder_PropertyFilterTypeMustBePrimitive(object p0)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ModelBuilder_PropertyFilterTypeMustBePrimitive(p0));
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0001B280 File Offset: 0x00019480
		internal static global::System.Exception MigrationsPendingException(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsPendingException(global::System.Data.Entity.Resources.Strings.MigrationsPendingException(p0));
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0001B28D File Offset: 0x0001948D
		internal static global::System.Exception BaseTypeNotMappedToFunctions(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.BaseTypeNotMappedToFunctions(p0, p1));
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0001B29B File Offset: 0x0001949B
		internal static global::System.Exception InvalidResourceName(object p0)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidResourceName(p0));
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0001B2A8 File Offset: 0x000194A8
		internal static global::System.Exception ModificationFunctionParameterNotFound(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ModificationFunctionParameterNotFound(p0, p1));
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0001B2B6 File Offset: 0x000194B6
		internal static global::System.Exception EntityClient_CannotOpenBrokenConnection()
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_CannotOpenBrokenConnection);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0001B2C2 File Offset: 0x000194C2
		internal static global::System.Exception ModificationFunctionParameterNotFoundOriginal(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ModificationFunctionParameterNotFoundOriginal(p0, p1));
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0001B2D0 File Offset: 0x000194D0
		internal static global::System.Exception ResultBindingNotFound(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ResultBindingNotFound(p0, p1));
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0001B2DE File Offset: 0x000194DE
		internal static global::System.Exception ConflictingFunctionsMapping(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingFunctionsMapping(p0, p1));
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0001B2EC File Offset: 0x000194EC
		internal static global::System.Exception AutomaticStaleFunctions(object p0)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.AutomaticStaleFunctions(p0));
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0001B2F9 File Offset: 0x000194F9
		internal static global::System.Exception UnableToUpgradeHistoryWhenCustomFactory()
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.UnableToUpgradeHistoryWhenCustomFactory);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0001B305 File Offset: 0x00019505
		internal static global::System.Exception StoreTypeNotFound(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.StoreTypeNotFound(p0, p1));
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0001B313 File Offset: 0x00019513
		internal static global::System.Exception IndexPropertyNotFound(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.IndexPropertyNotFound(p0, p1));
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0001B321 File Offset: 0x00019521
		internal static global::System.Exception ConflictingIndexAttributeMatches(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingIndexAttributeMatches(p0, p1));
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0001B32F File Offset: 0x0001952F
		internal static global::System.Exception ArgumentOutOfRange(string paramName)
		{
			return new global::System.ArgumentOutOfRangeException(paramName);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0001B337 File Offset: 0x00019537
		internal static global::System.Exception NotImplemented()
		{
			return new global::System.NotImplementedException();
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0001B33E File Offset: 0x0001953E
		internal static global::System.Exception NotSupported()
		{
			return new global::System.NotSupportedException();
		}
	}
}
